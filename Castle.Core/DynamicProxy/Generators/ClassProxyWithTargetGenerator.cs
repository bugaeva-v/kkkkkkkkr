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
	// Token: 0x02000031 RID: 49
	public class ClassProxyWithTargetGenerator : BaseProxyGenerator
	{
		// Token: 0x0600019F RID: 415 RVA: 0x00006C68 File Offset: 0x00004E68
		public ClassProxyWithTargetGenerator(ModuleScope scope, Type classToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options) : base(scope, classToProxy)
		{
			base.CheckNotGenericTypeDefinition(this.targetType, "targetType");
			this.EnsureDoesNotImplementIProxyTargetAccessor(this.targetType, "targetType");
			base.CheckNotGenericTypeDefinitions(additionalInterfacesToProxy, "additionalInterfacesToProxy");
			options.Initialize();
			base.ProxyGenerationOptions = options;
			this.additionalInterfacesToProxy = TypeUtil.GetAllInterfaces(additionalInterfacesToProxy);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00006CC8 File Offset: 0x00004EC8
		public Type GetGeneratedType()
		{
			CacheKey cacheKey = new CacheKey(this.targetType.GetTypeInfo(), this.targetType, this.additionalInterfacesToProxy, base.ProxyGenerationOptions);
			return base.ObtainProxyType(cacheKey, new Func<string, INamingScope, Type>(this.GenerateType));
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00006D0C File Offset: 0x00004F0C
		protected virtual IEnumerable<Type> GetTypeImplementerMapping(out IEnumerable<ITypeContributor> contributors, INamingScope namingScope)
		{
			List<MethodInfo> methodsToSkip = new List<MethodInfo>();
			ClassProxyWithTargetInstanceContributor classProxyWithTargetInstanceContributor = new ClassProxyWithTargetInstanceContributor(this.targetType, methodsToSkip, this.additionalInterfacesToProxy, ProxyTypeConstants.ClassWithTarget);
			ClassProxyWithTargetTargetContributor classProxyWithTargetTargetContributor = new ClassProxyWithTargetTargetContributor(this.targetType, methodsToSkip, namingScope)
			{
				Logger = base.Logger
			};
			IDictionary<Type, ITypeContributor> dictionary = new Dictionary<Type, ITypeContributor>();
			Type[] allInterfaces = this.targetType.GetAllInterfaces();
			MixinContributor mixinContributor = new MixinContributor(namingScope, false)
			{
				Logger = base.Logger
			};
			if (base.ProxyGenerationOptions.HasMixins)
			{
				foreach (Type type in base.ProxyGenerationOptions.MixinData.MixinInterfaces)
				{
					if (allInterfaces.Contains(type))
					{
						if (this.additionalInterfacesToProxy.Contains(type) && !dictionary.ContainsKey(type))
						{
							base.AddMappingNoCheck(type, classProxyWithTargetTargetContributor, dictionary);
							classProxyWithTargetTargetContributor.AddInterfaceToProxy(type);
						}
						mixinContributor.AddEmptyInterface(type);
					}
					else if (!dictionary.ContainsKey(type))
					{
						mixinContributor.AddInterfaceToProxy(type);
						base.AddMappingNoCheck(type, mixinContributor, dictionary);
					}
				}
			}
			InterfaceProxyWithoutTargetContributor interfaceProxyWithoutTargetContributor = new InterfaceProxyWithoutTargetContributor(namingScope, (ClassEmitter c, MethodInfo m) => NullExpression.Instance)
			{
				Logger = base.Logger
			};
			foreach (Type type2 in this.additionalInterfacesToProxy)
			{
				if (allInterfaces.Contains(type2))
				{
					if (!dictionary.ContainsKey(type2))
					{
						base.AddMappingNoCheck(type2, classProxyWithTargetTargetContributor, dictionary);
						classProxyWithTargetTargetContributor.AddInterfaceToProxy(type2);
					}
				}
				else if (!base.ProxyGenerationOptions.MixinData.ContainsMixin(type2))
				{
					interfaceProxyWithoutTargetContributor.AddInterfaceToProxy(type2);
					base.AddMapping(type2, interfaceProxyWithoutTargetContributor, dictionary);
				}
			}
			if (this.targetType.IsSerializable)
			{
				base.AddMappingForISerializable(dictionary, classProxyWithTargetInstanceContributor);
			}
			try
			{
				base.AddMappingNoCheck(typeof(IProxyTargetAccessor), classProxyWithTargetInstanceContributor, dictionary);
			}
			catch (ArgumentException)
			{
				base.HandleExplicitlyPassedProxyTargetAccessor(allInterfaces, this.additionalInterfacesToProxy);
			}
			contributors = new List<ITypeContributor>
			{
				classProxyWithTargetTargetContributor,
				mixinContributor,
				interfaceProxyWithoutTargetContributor,
				classProxyWithTargetInstanceContributor
			};
			return dictionary.Keys;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00006F4C File Offset: 0x0000514C
		private FieldReference CreateTargetField(ClassEmitter emitter)
		{
			FieldReference fieldReference = emitter.CreateField("__target", this.targetType);
			emitter.DefineCustomAttributeFor<XmlIgnoreAttribute>(fieldReference);
			return fieldReference;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00006F73 File Offset: 0x00005173
		private void EnsureDoesNotImplementIProxyTargetAccessor(Type type, string name)
		{
			if (!typeof(IProxyTargetAccessor).IsAssignableFrom(type))
			{
				return;
			}
			throw new ArgumentException(string.Format("Target type for the proxy implements {0} which is a DynamicProxy infrastructure interface and you should never implement it yourself. Are you trying to proxy an existing proxy?", typeof(IProxyTargetAccessor)), name);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00006FA4 File Offset: 0x000051A4
		private Type GenerateType(string name, INamingScope namingScope)
		{
			IEnumerable<ITypeContributor> enumerable;
			IEnumerable<Type> typeImplementerMapping = this.GetTypeImplementerMapping(out enumerable, namingScope);
			MetaType model = new MetaType();
			foreach (ITypeContributor typeContributor in enumerable)
			{
				typeContributor.CollectElementsToProxy(base.ProxyGenerationOptions.Hook, model);
			}
			base.ProxyGenerationOptions.Hook.MethodsInspected();
			ClassEmitter classEmitter = this.BuildClassEmitter(name, this.targetType, typeImplementerMapping);
			this.CreateFields(classEmitter);
			this.CreateTypeAttributes(classEmitter);
			ConstructorEmitter constructorEmitter = base.GenerateStaticConstructor(classEmitter);
			FieldReference item = this.CreateTargetField(classEmitter);
			List<FieldReference> list = new List<FieldReference>
			{
				item
			};
			foreach (ITypeContributor typeContributor2 in enumerable)
			{
				typeContributor2.Generate(classEmitter, base.ProxyGenerationOptions);
				if (typeContributor2 is MixinContributor)
				{
					list.AddRange((typeContributor2 as MixinContributor).Fields);
				}
			}
			FieldReference field = classEmitter.GetField("__interceptors");
			list.Add(field);
			FieldReference field2 = classEmitter.GetField("__selector");
			if (field2 != null)
			{
				list.Add(field2);
			}
			base.GenerateConstructors(classEmitter, this.targetType, list.ToArray());
			base.GenerateParameterlessConstructor(classEmitter, this.targetType, field);
			base.CompleteInitCacheMethod(constructorEmitter.CodeBuilder);
			Type type = classEmitter.BuildType();
			base.InitializeStaticFields(type);
			return type;
		}

		// Token: 0x04000070 RID: 112
		private readonly Type[] additionalInterfacesToProxy;
	}
}
