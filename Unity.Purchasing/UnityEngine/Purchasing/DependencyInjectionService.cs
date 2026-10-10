using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000AB RID: 171
	[NullableContext(1)]
	[Nullable(0)]
	internal class DependencyInjectionService : IDependencyInjectionService
	{
		// Token: 0x06000306 RID: 774 RVA: 0x00007317 File Offset: 0x00005517
		public void AddInstance(object instance)
		{
			this.m_ServiceInstances.Add(instance);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00007328 File Offset: 0x00005528
		public void AddService<T>() where T : class
		{
			Type typeFromHandle = typeof(T);
			this.ValidateTypeIsNotAnInterface(typeFromHandle);
			this.ValidateTypeIsNotADuplicate(typeFromHandle);
			this.m_ServiceConcreteTypes.Add(typeFromHandle);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000735B File Offset: 0x0000555B
		private void ValidateTypeIsNotAnInterface(Type type)
		{
			if (type.IsInterface)
			{
				throw new DependencyInjectionException(string.Format("Cannot use interface as service type {0}", type));
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00007376 File Offset: 0x00005576
		private void ValidateTypeIsNotADuplicate(Type type)
		{
			if (this.m_ServiceConcreteTypes.Contains(type))
			{
				throw new DependencyInjectionException(string.Format("Service of type {0} is already present", type));
			}
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00007398 File Offset: 0x00005598
		public T GetInstance<T>() where T : class
		{
			Type typeFromHandle = typeof(T);
			return this.GetInstance(typeFromHandle) as T;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x000073C1 File Offset: 0x000055C1
		private object GetInstance(Type type)
		{
			return this.FindServiceInstance(type) ?? this.CreateServiceInstance(this.FindConcreteServiceType(type));
		}

		// Token: 0x0600030C RID: 780 RVA: 0x000073DB File Offset: 0x000055DB
		[return: Nullable(2)]
		private object FindServiceInstance(Type type)
		{
			List<object> list = this.m_ServiceInstances.Where(new Func<object, bool>(type.IsInstanceOfType)).ToList<object>();
			if (list.Count > 1)
			{
				throw new DependencyInjectionException(string.Format("Multiple instances found for the type: {0}", type));
			}
			return list.FirstOrDefault<object>();
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000741C File Offset: 0x0000561C
		private Type FindConcreteServiceType(Type type)
		{
			List<Type> list = this.m_ServiceConcreteTypes.Where(new Func<Type, bool>(type.IsAssignableFrom)).ToList<Type>();
			if (list.Count > 1)
			{
				throw new DependencyInjectionException(string.Format("Multiple possible assignable types found for the type: {0}", type));
			}
			if (!list.Any<Type>())
			{
				throw new DependencyInjectionException(string.Format("No possible assignable types found for the type: {0}", type));
			}
			return list.First<Type>();
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00007480 File Offset: 0x00005680
		private object CreateServiceInstance(Type concreteType)
		{
			ConstructorInfo constructorInfo = this.FindConstructorForType(concreteType);
			object[] parameterInstancesForConstructor = this.GetParameterInstancesForConstructor(constructorInfo);
			object obj = constructorInfo.Invoke(parameterInstancesForConstructor);
			this.AddInstance(obj);
			return obj;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x000074B0 File Offset: 0x000056B0
		private ConstructorInfo FindConstructorForType(Type concreteType)
		{
			ConstructorInfo[] constructors = concreteType.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			if (constructors.Length == 0)
			{
				throw new DependencyInjectionException(string.Format("Service {0} has no visible constructor from this assembly.", concreteType));
			}
			if (constructors.Length != 1)
			{
				return this.HandleMultipleConstructors(constructors, concreteType);
			}
			return constructors.First<ConstructorInfo>();
		}

		// Token: 0x06000310 RID: 784 RVA: 0x000074F0 File Offset: 0x000056F0
		private ConstructorInfo HandleMultipleConstructors(ConstructorInfo[] constructors, Type concreteType)
		{
			List<ConstructorInfo> list = this.FindInjectableConstructors(constructors);
			if (list.Count == 0)
			{
				throw new DependencyInjectionException(string.Format("Service {0} has multiple constructors, select one by adding the [Inject] attribute to it.", concreteType));
			}
			if (list.Count > 1)
			{
				throw new DependencyInjectionException(string.Format("Service {0} has multiple injectable constructors, the class must have only one constructor with the [Inject] attribute.", concreteType));
			}
			return list.First<ConstructorInfo>();
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000753C File Offset: 0x0000573C
		private List<ConstructorInfo> FindInjectableConstructors(ConstructorInfo[] constructors)
		{
			return (from constructor in constructors
			where constructor.CustomAttributes.Any((CustomAttributeData attribute) => attribute.AttributeType == typeof(InjectAttribute))
			select constructor).ToList<ConstructorInfo>();
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00007568 File Offset: 0x00005768
		private object[] GetParameterInstancesForConstructor(ConstructorInfo constructor)
		{
			return (from paramInfo in constructor.GetParameters()
			select paramInfo.ParameterType).Select(new Func<Type, object>(this.GetInstance)).ToArray<object>();
		}

		// Token: 0x040000E8 RID: 232
		private readonly HashSet<object> m_ServiceInstances = new HashSet<object>();

		// Token: 0x040000E9 RID: 233
		private readonly HashSet<Type> m_ServiceConcreteTypes = new HashSet<Type>();
	}
}
