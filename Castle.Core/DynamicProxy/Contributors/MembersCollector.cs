using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using Castle.Core.Logging;
using Castle.DynamicProxy.Generators;
using Castle.DynamicProxy.Internal;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x020000A7 RID: 167
	public abstract class MembersCollector
	{
		// Token: 0x060003FF RID: 1023 RVA: 0x0000E84C File Offset: 0x0000CA4C
		protected MembersCollector(Type type)
		{
			this.type = type;
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x0000E89D File Offset: 0x0000CA9D
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x0000E8A5 File Offset: 0x0000CAA5
		public ILogger Logger
		{
			get
			{
				return this.logger;
			}
			set
			{
				this.logger = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x0000E8AE File Offset: 0x0000CAAE
		public IEnumerable<MetaMethod> Methods
		{
			get
			{
				return this.methods.Values;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x0000E8BB File Offset: 0x0000CABB
		public IEnumerable<MetaProperty> Properties
		{
			get
			{
				return this.properties.Values;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x0000E8C8 File Offset: 0x0000CAC8
		public IEnumerable<MetaEvent> Events
		{
			get
			{
				return this.events.Values;
			}
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000E8D5 File Offset: 0x0000CAD5
		public virtual void CollectMembersToProxy(IProxyGenerationHook hook)
		{
			if (this.checkedMethods == null)
			{
				throw new InvalidOperationException(string.Format("Can't call 'CollectMembersToProxy' method twice. This usually signifies a bug in custom {0}.", typeof(ITypeContributor)));
			}
			this.CollectProperties(hook);
			this.CollectEvents(hook);
			this.CollectMethods(hook);
			this.checkedMethods = null;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0000E918 File Offset: 0x0000CB18
		private void CollectProperties(IProxyGenerationHook hook)
		{
			foreach (PropertyInfo property in this.type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
			{
				this.AddProperty(property, hook);
			}
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0000E950 File Offset: 0x0000CB50
		private void CollectEvents(IProxyGenerationHook hook)
		{
			foreach (EventInfo @event in this.type.GetEvents(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
			{
				this.AddEvent(@event, hook);
			}
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0000E988 File Offset: 0x0000CB88
		private void CollectMethods(IProxyGenerationHook hook)
		{
			foreach (MethodInfo method in MethodFinder.GetAllInstanceMethods(this.type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
			{
				this.AddMethod(method, hook, true);
			}
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0000E9C0 File Offset: 0x0000CBC0
		private void AddProperty(PropertyInfo property, IProxyGenerationHook hook)
		{
			MetaMethod metaMethod = null;
			MetaMethod metaMethod2 = null;
			if (property.CanRead)
			{
				MethodInfo getMethod = property.GetGetMethod(true);
				metaMethod = this.AddMethod(getMethod, hook, false);
			}
			if (property.CanWrite)
			{
				MethodInfo setMethod = property.GetSetMethod(true);
				metaMethod2 = this.AddMethod(setMethod, hook, false);
			}
			if (metaMethod2 == null && metaMethod == null)
			{
				return;
			}
			IEnumerable<CustomAttributeInfo> nonInheritableAttributes = property.GetNonInheritableAttributes();
			ParameterInfo[] indexParameters = property.GetIndexParameters();
			this.properties[property] = new MetaProperty(property.Name, property.PropertyType, property.DeclaringType, metaMethod, metaMethod2, from a in nonInheritableAttributes
			select a.Builder, indexParameters.Select((ParameterInfo a) => a.ParameterType).ToArray<Type>());
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0000EA94 File Offset: 0x0000CC94
		private void AddEvent(EventInfo @event, IProxyGenerationHook hook)
		{
			MethodInfo addMethod = @event.GetAddMethod(true);
			MethodInfo removeMethod = @event.GetRemoveMethod(true);
			MetaMethod metaMethod = null;
			MetaMethod metaMethod2 = null;
			if (addMethod != null)
			{
				metaMethod = this.AddMethod(addMethod, hook, false);
			}
			if (removeMethod != null)
			{
				metaMethod2 = this.AddMethod(removeMethod, hook, false);
			}
			if (metaMethod == null && metaMethod2 == null)
			{
				return;
			}
			this.events[@event] = new MetaEvent(@event.Name, @event.DeclaringType, @event.EventHandlerType, metaMethod, metaMethod2, EventAttributes.None);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0000EB08 File Offset: 0x0000CD08
		private MetaMethod AddMethod(MethodInfo method, IProxyGenerationHook hook, bool isStandalone)
		{
			if (this.checkedMethods.Contains(method))
			{
				return null;
			}
			this.checkedMethods.Add(method);
			if (this.methods.ContainsKey(method))
			{
				return null;
			}
			MetaMethod methodToGenerate = this.GetMethodToGenerate(method, hook, isStandalone);
			if (methodToGenerate != null)
			{
				this.methods[method] = methodToGenerate;
			}
			return methodToGenerate;
		}

		// Token: 0x0600040C RID: 1036
		protected abstract MetaMethod GetMethodToGenerate(MethodInfo method, IProxyGenerationHook hook, bool isStandalone);

		// Token: 0x0600040D RID: 1037 RVA: 0x0000EB5C File Offset: 0x0000CD5C
		protected bool AcceptMethod(MethodInfo method, bool onlyVirtuals, IProxyGenerationHook hook)
		{
			if (MembersCollector.IsInternalAndNotVisibleToDynamicProxy(method))
			{
				return false;
			}
			bool flag = method.IsVirtual && !method.IsFinal;
			if (onlyVirtuals && !flag)
			{
				if (method.DeclaringType != typeof(MarshalByRefObject) && !method.IsGetType() && !method.IsMemberwiseClone())
				{
					this.Logger.DebugFormat("Excluded non-overridable method {0} on {1} because it cannot be intercepted.", new object[]
					{
						method.Name,
						method.DeclaringType.FullName
					});
					hook.NonProxyableMemberNotification(this.type, method);
				}
				return false;
			}
			if (method.IsFinal)
			{
				this.Logger.DebugFormat("Excluded sealed method {0} on {1} because it cannot be intercepted.", new object[]
				{
					method.Name,
					method.DeclaringType.FullName
				});
				return false;
			}
			return (method.IsPublic || method.IsFamily || method.IsAssembly || method.IsFamilyOrAssembly) && !(method.DeclaringType == typeof(MarshalByRefObject)) && !method.IsFinalizer() && hook.ShouldInterceptMethod(this.type, method);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0000EC7A File Offset: 0x0000CE7A
		private static bool IsInternalAndNotVisibleToDynamicProxy(MethodInfo method)
		{
			return ProxyUtil.IsInternal(method) && !ProxyUtil.AreInternalsVisibleToDynamicProxy(method.DeclaringType.GetTypeInfo().Assembly);
		}

		// Token: 0x0400012B RID: 299
		private const BindingFlags Flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

		// Token: 0x0400012C RID: 300
		private ILogger logger = NullLogger.Instance;

		// Token: 0x0400012D RID: 301
		private ICollection<MethodInfo> checkedMethods = new HashSet<MethodInfo>();

		// Token: 0x0400012E RID: 302
		private readonly IDictionary<PropertyInfo, MetaProperty> properties = new Dictionary<PropertyInfo, MetaProperty>();

		// Token: 0x0400012F RID: 303
		private readonly IDictionary<EventInfo, MetaEvent> events = new Dictionary<EventInfo, MetaEvent>();

		// Token: 0x04000130 RID: 304
		private readonly IDictionary<MethodInfo, MetaMethod> methods = new Dictionary<MethodInfo, MetaMethod>();

		// Token: 0x04000131 RID: 305
		protected readonly Type type;
	}
}
