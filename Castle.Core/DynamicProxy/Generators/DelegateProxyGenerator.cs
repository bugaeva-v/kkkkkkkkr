using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Serialization;
using Castle.DynamicProxy.Contributors;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Castle.DynamicProxy.Serialization;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x02000035 RID: 53
	public class DelegateProxyGenerator : BaseProxyGenerator
	{
		// Token: 0x060001B3 RID: 435 RVA: 0x0000726F File Offset: 0x0000546F
		public DelegateProxyGenerator(ModuleScope scope, Type delegateType) : base(scope, delegateType)
		{
			base.ProxyGenerationOptions = new ProxyGenerationOptions(new DelegateProxyGenerationHook());
			base.ProxyGenerationOptions.Initialize();
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00007294 File Offset: 0x00005494
		public Type GetProxyType()
		{
			CacheKey cacheKey = new CacheKey(this.targetType, null, null);
			return base.ObtainProxyType(cacheKey, new Func<string, INamingScope, Type>(this.GenerateType));
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000072C4 File Offset: 0x000054C4
		protected virtual IEnumerable<Type> GetTypeImplementerMapping(out IEnumerable<ITypeContributor> contributors, INamingScope namingScope)
		{
			List<MethodInfo> methodsToSkip = new List<MethodInfo>();
			ClassProxyInstanceContributor classProxyInstanceContributor = new ClassProxyInstanceContributor(this.targetType, methodsToSkip, Type.EmptyTypes, ProxyTypeConstants.ClassWithTarget);
			DelegateProxyTargetContributor item = new DelegateProxyTargetContributor(this.targetType, namingScope)
			{
				Logger = base.Logger
			};
			IDictionary<Type, ITypeContributor> dictionary = new Dictionary<Type, ITypeContributor>();
			if (this.targetType.IsSerializable)
			{
				base.AddMappingForISerializable(dictionary, classProxyInstanceContributor);
			}
			base.AddMappingNoCheck(typeof(IProxyTargetAccessor), classProxyInstanceContributor, dictionary);
			contributors = new List<ITypeContributor>
			{
				item,
				classProxyInstanceContributor
			};
			return dictionary.Keys;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00007350 File Offset: 0x00005550
		private FieldReference CreateTargetField(ClassEmitter emitter)
		{
			FieldReference fieldReference = emitter.CreateField("__target", this.targetType);
			emitter.DefineCustomAttributeFor<XmlIgnoreAttribute>(fieldReference);
			return fieldReference;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00007378 File Offset: 0x00005578
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
			ClassEmitter classEmitter = this.BuildClassEmitter(name, typeof(object), typeImplementerMapping);
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
			}
			FieldReference field = classEmitter.GetField("__interceptors");
			list.Add(field);
			FieldReference field2 = classEmitter.GetField("__selector");
			if (field2 != null)
			{
				list.Add(field2);
			}
			base.GenerateConstructor(classEmitter, null, list.ToArray());
			base.GenerateParameterlessConstructor(classEmitter, this.targetType, field);
			base.CompleteInitCacheMethod(constructorEmitter.CodeBuilder);
			Type type = classEmitter.BuildType();
			base.InitializeStaticFields(type);
			return type;
		}
	}
}
