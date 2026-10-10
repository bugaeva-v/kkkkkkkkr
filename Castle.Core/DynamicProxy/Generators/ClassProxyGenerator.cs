using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Castle.DynamicProxy.Contributors;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Castle.DynamicProxy.Internal;
using Castle.DynamicProxy.Serialization;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x02000030 RID: 48
	public class ClassProxyGenerator : BaseProxyGenerator
	{
		// Token: 0x0600019A RID: 410 RVA: 0x000067F7 File Offset: 0x000049F7
		public ClassProxyGenerator(ModuleScope scope, Type targetType) : base(scope, targetType)
		{
			base.CheckNotGenericTypeDefinition(targetType, "targetType");
			this.EnsureDoesNotImplementIProxyTargetAccessor(targetType, "targetType");
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000681C File Offset: 0x00004A1C
		public Type GenerateCode(Type[] interfaces, ProxyGenerationOptions options)
		{
			options.Initialize();
			interfaces = TypeUtil.GetAllInterfaces(interfaces);
			base.CheckNotGenericTypeDefinitions(interfaces, "interfaces");
			base.ProxyGenerationOptions = options;
			CacheKey cacheKey = new CacheKey(this.targetType, interfaces, options);
			return base.ObtainProxyType(cacheKey, (string n, INamingScope s) => this.GenerateType(n, interfaces, s));
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00006894 File Offset: 0x00004A94
		protected virtual Type GenerateType(string name, Type[] interfaces, INamingScope namingScope)
		{
			IEnumerable<ITypeContributor> enumerable;
			IEnumerable<Type> typeImplementerMapping = this.GetTypeImplementerMapping(interfaces, out enumerable, namingScope);
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
			List<FieldReference> list = new List<FieldReference>();
			foreach (ITypeContributor typeContributor2 in enumerable)
			{
				typeContributor2.Generate(classEmitter, base.ProxyGenerationOptions);
				MixinContributor mixinContributor = typeContributor2 as MixinContributor;
				if (mixinContributor != null)
				{
					list.AddRange(mixinContributor.Fields);
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

		// Token: 0x0600019D RID: 413 RVA: 0x00006A04 File Offset: 0x00004C04
		protected virtual IEnumerable<Type> GetTypeImplementerMapping(Type[] interfaces, out IEnumerable<ITypeContributor> contributors, INamingScope namingScope)
		{
			List<MethodInfo> methodsToSkip = new List<MethodInfo>();
			ClassProxyInstanceContributor classProxyInstanceContributor = new ClassProxyInstanceContributor(this.targetType, methodsToSkip, interfaces, ProxyTypeConstants.Class);
			ClassProxyTargetContributor classProxyTargetContributor = new ClassProxyTargetContributor(this.targetType, methodsToSkip, namingScope)
			{
				Logger = base.Logger
			};
			IDictionary<Type, ITypeContributor> dictionary = new Dictionary<Type, ITypeContributor>();
			Type[] allInterfaces = this.targetType.GetAllInterfaces();
			Type[] allInterfaces2 = TypeUtil.GetAllInterfaces(interfaces);
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
						if (allInterfaces2.Contains(type) && !dictionary.ContainsKey(type))
						{
							base.AddMappingNoCheck(type, classProxyTargetContributor, dictionary);
							classProxyTargetContributor.AddInterfaceToProxy(type);
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
			foreach (Type type2 in allInterfaces2)
			{
				if (allInterfaces.Contains(type2))
				{
					if (!dictionary.ContainsKey(type2))
					{
						base.AddMappingNoCheck(type2, classProxyTargetContributor, dictionary);
						classProxyTargetContributor.AddInterfaceToProxy(type2);
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
				base.AddMappingForISerializable(dictionary, classProxyInstanceContributor);
			}
			try
			{
				base.AddMappingNoCheck(typeof(IProxyTargetAccessor), classProxyInstanceContributor, dictionary);
			}
			catch (ArgumentException)
			{
				base.HandleExplicitlyPassedProxyTargetAccessor(allInterfaces, allInterfaces2);
			}
			contributors = new List<ITypeContributor>
			{
				classProxyTargetContributor,
				mixinContributor,
				interfaceProxyWithoutTargetContributor,
				classProxyInstanceContributor
			};
			return dictionary.Keys;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00006C38 File Offset: 0x00004E38
		private void EnsureDoesNotImplementIProxyTargetAccessor(Type type, string name)
		{
			if (!typeof(IProxyTargetAccessor).IsAssignableFrom(type))
			{
				return;
			}
			throw new ArgumentException(string.Format("Target type for the proxy implements {0} which is a DynamicProxy infrastructure interface and you should never implement it yourself. Are you trying to proxy an existing proxy?", typeof(IProxyTargetAccessor)), name);
		}
	}
}
