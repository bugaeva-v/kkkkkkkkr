using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;
using Castle.DynamicProxy.Contributors;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Castle.DynamicProxy.Internal;
using Castle.DynamicProxy.Serialization;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x0200003D RID: 61
	public class InterfaceProxyWithTargetGenerator : BaseProxyGenerator
	{
		// Token: 0x060001D3 RID: 467 RVA: 0x000078EC File Offset: 0x00005AEC
		public InterfaceProxyWithTargetGenerator(ModuleScope scope, Type @interface) : base(scope, @interface)
		{
			base.CheckNotGenericTypeDefinition(@interface, "@interface");
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00007902 File Offset: 0x00005B02
		protected virtual bool AllowChangeTarget
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00007905 File Offset: 0x00005B05
		protected virtual string GeneratorType
		{
			get
			{
				return ProxyTypeConstants.InterfaceWithTarget;
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000790C File Offset: 0x00005B0C
		public Type GenerateCode(Type proxyTargetType, Type[] interfaces, ProxyGenerationOptions options)
		{
			options.Initialize();
			base.CheckNotGenericTypeDefinition(proxyTargetType, "proxyTargetType");
			base.CheckNotGenericTypeDefinitions(interfaces, "interfaces");
			this.EnsureValidBaseType(options.BaseTypeForInterfaceProxy);
			base.ProxyGenerationOptions = options;
			interfaces = TypeUtil.GetAllInterfaces(interfaces);
			CacheKey cacheKey = new CacheKey(proxyTargetType.GetTypeInfo(), this.targetType, interfaces, options);
			return base.ObtainProxyType(cacheKey, (string n, INamingScope s) => this.GenerateType(n, proxyTargetType, interfaces, s));
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000079B4 File Offset: 0x00005BB4
		protected virtual ITypeContributor AddMappingForTargetType(IDictionary<Type, ITypeContributor> typeImplementerMapping, Type proxyTargetType, ICollection<Type> targetInterfaces, ICollection<Type> additionalInterfaces, INamingScope namingScope)
		{
			InterfaceProxyTargetContributor interfaceProxyTargetContributor = new InterfaceProxyTargetContributor(proxyTargetType, this.AllowChangeTarget, namingScope)
			{
				Logger = base.Logger
			};
			Type[] allInterfaces = this.targetType.GetAllInterfaces();
			foreach (Type @interface in allInterfaces)
			{
				interfaceProxyTargetContributor.AddInterfaceToProxy(@interface);
				base.AddMappingNoCheck(@interface, interfaceProxyTargetContributor, typeImplementerMapping);
			}
			foreach (Type type in additionalInterfaces)
			{
				if (this.ImplementedByTarget(targetInterfaces, type) && !allInterfaces.Contains(type))
				{
					interfaceProxyTargetContributor.AddInterfaceToProxy(type);
					base.AddMappingNoCheck(type, interfaceProxyTargetContributor, typeImplementerMapping);
				}
			}
			return interfaceProxyTargetContributor;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00007A74 File Offset: 0x00005C74
		protected override void CreateTypeAttributes(ClassEmitter emitter)
		{
			base.CreateTypeAttributes(emitter);
			emitter.DefineCustomAttribute<SerializableAttribute>();
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00007A84 File Offset: 0x00005C84
		protected virtual Type GenerateType(string typeName, Type proxyTargetType, Type[] interfaces, INamingScope namingScope)
		{
			IEnumerable<ITypeContributor> enumerable;
			IEnumerable<Type> typeImplementerMapping = this.GetTypeImplementerMapping(interfaces, proxyTargetType, out enumerable, namingScope);
			ClassEmitter classEmitter;
			FieldReference item;
			Type baseType = this.Init(typeName, out classEmitter, proxyTargetType, out item, typeImplementerMapping);
			MetaType model = new MetaType();
			foreach (ITypeContributor typeContributor in enumerable)
			{
				typeContributor.CollectElementsToProxy(base.ProxyGenerationOptions.Hook, model);
			}
			base.ProxyGenerationOptions.Hook.MethodsInspected();
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
			list.Add(item);
			list.Add(this.targetField);
			FieldReference field = classEmitter.GetField("__selector");
			if (field != null)
			{
				list.Add(field);
			}
			base.GenerateConstructors(classEmitter, baseType, list.ToArray());
			base.CompleteInitCacheMethod(constructorEmitter.CodeBuilder);
			Type type = classEmitter.BuildType();
			base.InitializeStaticFields(type);
			return type;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00007BDC File Offset: 0x00005DDC
		protected virtual InterfaceProxyWithoutTargetContributor GetContributorForAdditionalInterfaces(INamingScope namingScope)
		{
			return new InterfaceProxyWithoutTargetContributor(namingScope, (ClassEmitter c, MethodInfo m) => NullExpression.Instance)
			{
				Logger = base.Logger
			};
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00007C10 File Offset: 0x00005E10
		protected virtual IEnumerable<Type> GetTypeImplementerMapping(Type[] interfaces, Type proxyTargetType, out IEnumerable<ITypeContributor> contributors, INamingScope namingScope)
		{
			IDictionary<Type, ITypeContributor> dictionary = new Dictionary<Type, ITypeContributor>();
			MixinContributor mixinContributor = new MixinContributor(namingScope, this.AllowChangeTarget)
			{
				Logger = base.Logger
			};
			Type[] allInterfaces = proxyTargetType.GetAllInterfaces();
			Type[] allInterfaces2 = TypeUtil.GetAllInterfaces(interfaces);
			ITypeContributor typeContributor = this.AddMappingForTargetType(dictionary, proxyTargetType, allInterfaces, allInterfaces2, namingScope);
			if (base.ProxyGenerationOptions.HasMixins)
			{
				foreach (Type type in base.ProxyGenerationOptions.MixinData.MixinInterfaces)
				{
					if (allInterfaces.Contains(type))
					{
						if (allInterfaces2.Contains(type))
						{
							base.AddMapping(type, typeContributor, dictionary);
						}
						mixinContributor.AddEmptyInterface(type);
					}
					else if (!dictionary.ContainsKey(type))
					{
						mixinContributor.AddInterfaceToProxy(type);
						dictionary.Add(type, mixinContributor);
					}
				}
			}
			InterfaceProxyWithoutTargetContributor contributorForAdditionalInterfaces = this.GetContributorForAdditionalInterfaces(namingScope);
			foreach (Type type2 in allInterfaces2)
			{
				if (!dictionary.ContainsKey(type2) && !base.ProxyGenerationOptions.MixinData.ContainsMixin(type2))
				{
					contributorForAdditionalInterfaces.AddInterfaceToProxy(type2);
					base.AddMappingNoCheck(type2, contributorForAdditionalInterfaces, dictionary);
				}
			}
			InterfaceProxyInstanceContributor interfaceProxyInstanceContributor = new InterfaceProxyInstanceContributor(this.targetType, this.GeneratorType, interfaces);
			base.AddMappingForISerializable(dictionary, interfaceProxyInstanceContributor);
			try
			{
				base.AddMappingNoCheck(typeof(IProxyTargetAccessor), interfaceProxyInstanceContributor, dictionary);
			}
			catch (ArgumentException)
			{
				base.HandleExplicitlyPassedProxyTargetAccessor(allInterfaces, allInterfaces2);
			}
			contributors = new List<ITypeContributor>
			{
				typeContributor,
				contributorForAdditionalInterfaces,
				mixinContributor,
				interfaceProxyInstanceContributor
			};
			return dictionary.Keys;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00007DC4 File Offset: 0x00005FC4
		protected virtual Type Init(string typeName, out ClassEmitter emitter, Type proxyTargetType, out FieldReference interceptorsField, IEnumerable<Type> interfaces)
		{
			Type baseTypeForInterfaceProxy = base.ProxyGenerationOptions.BaseTypeForInterfaceProxy;
			emitter = this.BuildClassEmitter(typeName, baseTypeForInterfaceProxy, interfaces);
			this.CreateFields(emitter, proxyTargetType);
			this.CreateTypeAttributes(emitter);
			interceptorsField = emitter.GetField("__interceptors");
			return baseTypeForInterfaceProxy;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00007E0A File Offset: 0x0000600A
		private void CreateFields(ClassEmitter emitter, Type proxyTargetType)
		{
			base.CreateFields(emitter);
			this.targetField = emitter.CreateField("__target", proxyTargetType);
			emitter.DefineCustomAttributeFor<XmlIgnoreAttribute>(this.targetField);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00007E34 File Offset: 0x00006034
		private void EnsureValidBaseType(Type type)
		{
			if (type == null)
			{
				throw new ArgumentException("Base type for proxy is null reference. Please set it to System.Object or some other valid type.");
			}
			if (!type.GetTypeInfo().IsClass)
			{
				this.ThrowInvalidBaseType(type, "it is not a class type");
			}
			if (type.GetTypeInfo().IsSealed)
			{
				this.ThrowInvalidBaseType(type, "it is sealed");
			}
			ConstructorInfo constructor = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null);
			if (constructor == null || constructor.IsPrivate)
			{
				this.ThrowInvalidBaseType(type, "it does not have accessible parameterless constructor");
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00007EB4 File Offset: 0x000060B4
		private bool ImplementedByTarget(ICollection<Type> targetInterfaces, Type @interface)
		{
			return targetInterfaces.Contains(@interface);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00007EBD File Offset: 0x000060BD
		private void ThrowInvalidBaseType(Type type, string doesNotHaveAccessibleParameterlessConstructor)
		{
			throw new ArgumentException(string.Format("Type {0} is not valid base type for interface proxy, because {1}. Only a non-sealed class with non-private default constructor can be used as base type for interface proxy. Please use some other valid type.", type, doesNotHaveAccessibleParameterlessConstructor));
		}

		// Token: 0x04000073 RID: 115
		protected FieldReference targetField;
	}
}
