using System;
using System.Collections.Generic;
using System.Reflection;
using Castle.DynamicProxy.Contributors;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Castle.DynamicProxy.Internal;
using Castle.DynamicProxy.Serialization;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x0200003C RID: 60
	public class InterfaceProxyWithoutTargetGenerator : InterfaceProxyWithTargetGenerator
	{
		// Token: 0x060001CF RID: 463 RVA: 0x00007704 File Offset: 0x00005904
		public InterfaceProxyWithoutTargetGenerator(ModuleScope scope, Type @interface) : base(scope, @interface)
		{
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0000770E File Offset: 0x0000590E
		protected override string GeneratorType
		{
			get
			{
				return ProxyTypeConstants.InterfaceWithoutTarget;
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00007718 File Offset: 0x00005918
		protected override ITypeContributor AddMappingForTargetType(IDictionary<Type, ITypeContributor> interfaceTypeImplementerMapping, Type proxyTargetType, ICollection<Type> targetInterfaces, ICollection<Type> additionalInterfaces, INamingScope namingScope)
		{
			InterfaceProxyWithoutTargetContributor interfaceProxyWithoutTargetContributor = new InterfaceProxyWithoutTargetContributor(namingScope, (ClassEmitter c, MethodInfo m) => NullExpression.Instance)
			{
				Logger = base.Logger
			};
			foreach (Type @interface in this.targetType.GetAllInterfaces())
			{
				interfaceProxyWithoutTargetContributor.AddInterfaceToProxy(@interface);
				base.AddMappingNoCheck(@interface, interfaceProxyWithoutTargetContributor, interfaceTypeImplementerMapping);
			}
			return interfaceProxyWithoutTargetContributor;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00007788 File Offset: 0x00005988
		protected override Type GenerateType(string typeName, Type proxyTargetType, Type[] interfaces, INamingScope namingScope)
		{
			IEnumerable<ITypeContributor> enumerable;
			IEnumerable<Type> typeImplementerMapping = this.GetTypeImplementerMapping(interfaces, this.targetType, out enumerable, namingScope);
			MetaType model = new MetaType();
			foreach (ITypeContributor typeContributor in enumerable)
			{
				typeContributor.CollectElementsToProxy(base.ProxyGenerationOptions.Hook, model);
			}
			base.ProxyGenerationOptions.Hook.MethodsInspected();
			ClassEmitter classEmitter;
			FieldReference item;
			Type baseType = this.Init(typeName, out classEmitter, proxyTargetType, out item, typeImplementerMapping);
			ConstructorEmitter constructorEmitter = base.GenerateStaticConstructor(classEmitter);
			List<FieldReference> list = new List<FieldReference>();
			foreach (ITypeContributor typeContributor2 in enumerable)
			{
				typeContributor2.Generate(classEmitter, base.ProxyGenerationOptions);
				if (typeContributor2 is MixinContributor)
				{
					list.AddRange((typeContributor2 as MixinContributor).Fields);
				}
			}
			List<FieldReference> list2 = new List<FieldReference>(list)
			{
				item,
				this.targetField
			};
			FieldReference field = classEmitter.GetField("__selector");
			if (field != null)
			{
				list2.Add(field);
			}
			base.GenerateConstructors(classEmitter, baseType, list2.ToArray());
			base.CompleteInitCacheMethod(constructorEmitter.CodeBuilder);
			Type type = classEmitter.BuildType();
			base.InitializeStaticFields(type);
			return type;
		}
	}
}
