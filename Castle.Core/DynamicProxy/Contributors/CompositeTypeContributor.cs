using System;
using System.Collections.Generic;
using Castle.Core.Logging;
using Castle.DynamicProxy.Generators;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Internal;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x02000094 RID: 148
	public abstract class CompositeTypeContributor : ITypeContributor
	{
		// Token: 0x060003B1 RID: 945 RVA: 0x0000D960 File Offset: 0x0000BB60
		protected CompositeTypeContributor(INamingScope namingScope)
		{
			this.namingScope = namingScope;
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x0000D9B1 File Offset: 0x0000BBB1
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x0000D9B9 File Offset: 0x0000BBB9
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

		// Token: 0x060003B4 RID: 948 RVA: 0x0000D9C4 File Offset: 0x0000BBC4
		public void CollectElementsToProxy(IProxyGenerationHook hook, MetaType model)
		{
			foreach (MembersCollector membersCollector in this.CollectElementsToProxyInternal(hook))
			{
				foreach (MetaMethod metaMethod in membersCollector.Methods)
				{
					model.AddMethod(metaMethod);
					this.methods.Add(metaMethod);
				}
				foreach (MetaEvent metaEvent in membersCollector.Events)
				{
					model.AddEvent(metaEvent);
					this.events.Add(metaEvent);
				}
				foreach (MetaProperty metaProperty in membersCollector.Properties)
				{
					model.AddProperty(metaProperty);
					this.properties.Add(metaProperty);
				}
			}
		}

		// Token: 0x060003B5 RID: 949
		protected abstract IEnumerable<MembersCollector> CollectElementsToProxyInternal(IProxyGenerationHook hook);

		// Token: 0x060003B6 RID: 950 RVA: 0x0000DAFC File Offset: 0x0000BCFC
		public virtual void Generate(ClassEmitter @class, ProxyGenerationOptions options)
		{
			foreach (MetaMethod metaMethod in this.methods)
			{
				if (metaMethod.Standalone)
				{
					this.ImplementMethod(metaMethod, @class, options, new OverrideMethodDelegate(@class.CreateMethod));
				}
			}
			foreach (MetaProperty property in this.properties)
			{
				this.ImplementProperty(@class, property, options);
			}
			foreach (MetaEvent @event in this.events)
			{
				this.ImplementEvent(@class, @event, options);
			}
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000DBE4 File Offset: 0x0000BDE4
		public void AddInterfaceToProxy(Type @interface)
		{
			this.interfaces.Add(@interface);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0000DBF4 File Offset: 0x0000BDF4
		private void ImplementEvent(ClassEmitter emitter, MetaEvent @event, ProxyGenerationOptions options)
		{
			@event.BuildEventEmitter(emitter);
			this.ImplementMethod(@event.Adder, emitter, options, new OverrideMethodDelegate(@event.Emitter.CreateAddMethod));
			this.ImplementMethod(@event.Remover, emitter, options, new OverrideMethodDelegate(@event.Emitter.CreateRemoveMethod));
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000DC48 File Offset: 0x0000BE48
		private void ImplementProperty(ClassEmitter emitter, MetaProperty property, ProxyGenerationOptions options)
		{
			property.BuildPropertyEmitter(emitter);
			if (property.CanRead)
			{
				this.ImplementMethod(property.Getter, emitter, options, new OverrideMethodDelegate(property.Emitter.CreateGetMethod));
			}
			if (property.CanWrite)
			{
				this.ImplementMethod(property.Setter, emitter, options, new OverrideMethodDelegate(property.Emitter.CreateSetMethod));
			}
		}

		// Token: 0x060003BA RID: 954
		protected abstract MethodGenerator GetMethodGenerator(MetaMethod method, ClassEmitter @class, ProxyGenerationOptions options, OverrideMethodDelegate overrideMethod);

		// Token: 0x060003BB RID: 955 RVA: 0x0000DCAC File Offset: 0x0000BEAC
		private void ImplementMethod(MetaMethod method, ClassEmitter @class, ProxyGenerationOptions options, OverrideMethodDelegate overrideMethod)
		{
			MethodGenerator methodGenerator = this.GetMethodGenerator(method, @class, options, overrideMethod);
			if (methodGenerator == null)
			{
				return;
			}
			MethodEmitter methodEmitter = methodGenerator.Generate(@class, options, this.namingScope);
			foreach (CustomAttributeInfo customAttributeInfo in method.Method.GetNonInheritableAttributes())
			{
				methodEmitter.DefineCustomAttribute(customAttributeInfo.Builder);
			}
		}

		// Token: 0x04000112 RID: 274
		protected readonly INamingScope namingScope;

		// Token: 0x04000113 RID: 275
		protected readonly ICollection<Type> interfaces = new HashSet<Type>();

		// Token: 0x04000114 RID: 276
		private ILogger logger = NullLogger.Instance;

		// Token: 0x04000115 RID: 277
		private readonly ICollection<MetaProperty> properties = new TypeElementCollection<MetaProperty>();

		// Token: 0x04000116 RID: 278
		private readonly ICollection<MetaEvent> events = new TypeElementCollection<MetaEvent>();

		// Token: 0x04000117 RID: 279
		private readonly ICollection<MetaMethod> methods = new TypeElementCollection<MetaMethod>();
	}
}
