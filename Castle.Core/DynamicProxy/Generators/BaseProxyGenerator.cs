using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Castle.Core.Logging;
using Castle.DynamicProxy.Contributors;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Generators.Emitters.CodeBuilders;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Castle.DynamicProxy.Internal;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x0200002E RID: 46
	public abstract class BaseProxyGenerator
	{
		// Token: 0x06000179 RID: 377 RVA: 0x00005F8C File Offset: 0x0000418C
		protected BaseProxyGenerator(ModuleScope scope, Type targetType)
		{
			this.scope = scope;
			this.targetType = targetType;
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00005FAD File Offset: 0x000041AD
		// (set) Token: 0x0600017B RID: 379 RVA: 0x00005FB5 File Offset: 0x000041B5
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

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00005FBE File Offset: 0x000041BE
		// (set) Token: 0x0600017D RID: 381 RVA: 0x00005FD9 File Offset: 0x000041D9
		protected ProxyGenerationOptions ProxyGenerationOptions
		{
			get
			{
				if (this.proxyGenerationOptions == null)
				{
					throw new InvalidOperationException("ProxyGenerationOptions must be set before being retrieved.");
				}
				return this.proxyGenerationOptions;
			}
			set
			{
				if (this.proxyGenerationOptions != null)
				{
					throw new InvalidOperationException("ProxyGenerationOptions can only be set once.");
				}
				this.proxyGenerationOptions = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00005FF5 File Offset: 0x000041F5
		protected ModuleScope Scope
		{
			get
			{
				return this.scope;
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00005FFD File Offset: 0x000041FD
		protected void AddMapping(Type @interface, ITypeContributor implementer, IDictionary<Type, ITypeContributor> mapping)
		{
			if (!mapping.ContainsKey(@interface))
			{
				this.AddMappingNoCheck(@interface, implementer, mapping);
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00006011 File Offset: 0x00004211
		protected void AddMappingForISerializable(IDictionary<Type, ITypeContributor> typeImplementerMapping, ITypeContributor instance)
		{
			this.AddMapping(typeof(ISerializable), instance, typeImplementerMapping);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00006025 File Offset: 0x00004225
		protected void AddMappingNoCheck(Type @interface, ITypeContributor implementer, IDictionary<Type, ITypeContributor> mapping)
		{
			mapping.Add(@interface, implementer);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000602F File Offset: 0x0000422F
		[Obsolete("Exposes a component that is intended for internal use only.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected void AddToCache(CacheKey key, Type type)
		{
			this.scope.RegisterInCache(key, type);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000603E File Offset: 0x0000423E
		protected virtual ClassEmitter BuildClassEmitter(string typeName, Type parentType, IEnumerable<Type> interfaces)
		{
			this.CheckNotGenericTypeDefinition(parentType, "parentType");
			this.CheckNotGenericTypeDefinitions(interfaces, "interfaces");
			return new ClassEmitter(this.Scope, typeName, parentType, interfaces);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00006066 File Offset: 0x00004266
		protected void CheckNotGenericTypeDefinition(Type type, string argumentName)
		{
			if (type != null && type.GetTypeInfo().IsGenericTypeDefinition)
			{
				throw new ArgumentException("Type cannot be a generic type definition. Type: " + type.FullName, argumentName);
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00006098 File Offset: 0x00004298
		protected void CheckNotGenericTypeDefinitions(IEnumerable<Type> types, string argumentName)
		{
			if (types == null)
			{
				return;
			}
			foreach (Type type in types)
			{
				this.CheckNotGenericTypeDefinition(type, argumentName);
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000060E8 File Offset: 0x000042E8
		protected void CompleteInitCacheMethod(ConstructorCodeBuilder constCodeBuilder)
		{
			constCodeBuilder.AddStatement(new ReturnStatement());
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000060F6 File Offset: 0x000042F6
		protected virtual void CreateFields(ClassEmitter emitter)
		{
			this.CreateOptionsField(emitter);
			this.CreateSelectorField(emitter);
			this.CreateInterceptorsField(emitter);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00006110 File Offset: 0x00004310
		protected void CreateInterceptorsField(ClassEmitter emitter)
		{
			FieldReference field = emitter.CreateField("__interceptors", typeof(IInterceptor[]));
			emitter.DefineCustomAttributeFor<XmlIgnoreAttribute>(field);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000613A File Offset: 0x0000433A
		protected FieldReference CreateOptionsField(ClassEmitter emitter)
		{
			return emitter.CreateStaticField("proxyGenerationOptions", typeof(ProxyGenerationOptions));
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00006151 File Offset: 0x00004351
		protected void CreateSelectorField(ClassEmitter emitter)
		{
			if (this.ProxyGenerationOptions.Selector == null)
			{
				return;
			}
			emitter.CreateField("__selector", typeof(IInterceptorSelector));
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00006177 File Offset: 0x00004377
		protected virtual void CreateTypeAttributes(ClassEmitter emitter)
		{
			emitter.AddCustomAttributes(this.ProxyGenerationOptions);
			emitter.DefineCustomAttribute<XmlIncludeAttribute>(new object[]
			{
				this.targetType
			});
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000619C File Offset: 0x0000439C
		protected void EnsureOptionsOverrideEqualsAndGetHashCode(ProxyGenerationOptions options)
		{
			if (this.Logger.IsWarnEnabled && !this.OverridesEqualsAndGetHashCode(options.Hook.GetType()))
			{
				this.Logger.WarnFormat("The IProxyGenerationHook type {0} does not override both Equals and GetHashCode. If these are not correctly overridden caching will fail to work causing performance problems.", new object[]
				{
					options.Hook.GetType().FullName
				});
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000061F4 File Offset: 0x000043F4
		protected void GenerateConstructor(ClassEmitter emitter, ConstructorInfo baseConstructor, params FieldReference[] fields)
		{
			ParameterInfo[] array = null;
			if (baseConstructor != null)
			{
				array = baseConstructor.GetParameters();
			}
			ArgumentReference[] array2;
			if (array != null && array.Length != 0)
			{
				array2 = new ArgumentReference[fields.Length + array.Length];
				int num = fields.Length;
				for (int i = num; i < num + array.Length; i++)
				{
					ParameterInfo parameterInfo = array[i - num];
					array2[i] = new ArgumentReference(parameterInfo.ParameterType);
				}
			}
			else
			{
				array2 = new ArgumentReference[fields.Length];
			}
			for (int j = 0; j < fields.Length; j++)
			{
				array2[j] = new ArgumentReference(fields[j].Reference.FieldType);
			}
			ConstructorEmitter constructorEmitter = emitter.CreateConstructor(array2);
			if (array != null && array.Length != 0)
			{
				int num2 = 1 + fields.Length;
				int k = 0;
				int num3 = array.Length;
				while (k < num3)
				{
					ParameterBuilder parameterBuilder = constructorEmitter.ConstructorBuilder.DefineParameter(num2 + k, array[k].Attributes, array[k].Name);
					foreach (CustomAttributeInfo customAttributeInfo in array[k].GetNonInheritableAttributes())
					{
						parameterBuilder.SetCustomAttribute(customAttributeInfo.Builder);
					}
					k++;
				}
			}
			for (int l = 0; l < fields.Length; l++)
			{
				constructorEmitter.CodeBuilder.AddStatement(new AssignStatement(fields[l], array2[l].ToExpression()));
			}
			if (baseConstructor != null)
			{
				ArgumentReference[] array3 = new ArgumentReference[array.Length];
				Array.Copy(array2, fields.Length, array3, 0, array.Length);
				constructorEmitter.CodeBuilder.InvokeBaseConstructor(baseConstructor, array3);
			}
			else
			{
				constructorEmitter.CodeBuilder.InvokeBaseConstructor();
			}
			constructorEmitter.CodeBuilder.AddStatement(new ReturnStatement());
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000063B0 File Offset: 0x000045B0
		protected void GenerateConstructors(ClassEmitter emitter, Type baseType, params FieldReference[] fields)
		{
			foreach (ConstructorInfo constructorInfo in baseType.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
			{
				if (ProxyUtil.IsAccessibleMethod(constructorInfo))
				{
					this.GenerateConstructor(emitter, constructorInfo, fields);
				}
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000063EC File Offset: 0x000045EC
		protected void GenerateParameterlessConstructor(ClassEmitter emitter, Type baseClass, FieldReference interceptorField)
		{
			ConstructorInfo constructor = baseClass.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, Type.EmptyTypes, null);
			if (constructor == null)
			{
				constructor = baseClass.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, Type.EmptyTypes, null);
				if (constructor == null || constructor.IsPrivate)
				{
					return;
				}
			}
			ConstructorEmitter constructorEmitter = emitter.CreateConstructor(new ArgumentReference[0]);
			constructorEmitter.CodeBuilder.AddStatement(new AssignStatement(interceptorField, new NewArrayExpression(1, typeof(IInterceptor))));
			constructorEmitter.CodeBuilder.AddStatement(new AssignArrayStatement(interceptorField, 0, new NewInstanceExpression(typeof(StandardInterceptor), new Type[0], new Expression[0])));
			constructorEmitter.CodeBuilder.InvokeBaseConstructor(constructor);
			constructorEmitter.CodeBuilder.AddStatement(new ReturnStatement());
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000064AE File Offset: 0x000046AE
		protected ConstructorEmitter GenerateStaticConstructor(ClassEmitter emitter)
		{
			return emitter.CreateTypeConstructor();
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000064B6 File Offset: 0x000046B6
		[Obsolete("Exposes a component that is intended for internal use only.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected Type GetFromCache(CacheKey key)
		{
			return this.scope.GetFromCache(key);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000064C4 File Offset: 0x000046C4
		protected void HandleExplicitlyPassedProxyTargetAccessor(ICollection<Type> targetInterfaces, ICollection<Type> additionalInterfaces)
		{
			string text = typeof(IProxyTargetAccessor).ToString();
			string str;
			if (targetInterfaces.Contains(typeof(IProxyTargetAccessor)))
			{
				str = string.Format("Target type for the proxy implements {0} which is a DynamicProxy infrastructure interface and you should never implement it yourself. Are you trying to proxy an existing proxy?", text);
			}
			else if (this.ProxyGenerationOptions.MixinData.ContainsMixin(typeof(IProxyTargetAccessor)))
			{
				Type type = this.ProxyGenerationOptions.MixinData.GetMixinInstance(typeof(IProxyTargetAccessor)).GetType();
				str = string.Format("Mixin type {0} implements {1} which is a DynamicProxy infrastructure interface and you should never implement it yourself. Are you trying to mix in an existing proxy?", type.Name, text);
			}
			else if (additionalInterfaces.Contains(typeof(IProxyTargetAccessor)))
			{
				str = string.Format("You passed {0} as one of additional interfaces to proxy which is a DynamicProxy infrastructure interface and is implemented by every proxy anyway. Please remove it from the list of additional interfaces to proxy.", text);
			}
			else
			{
				str = string.Format("It looks like we have a bug with regards to how we handle {0}. Please report it.", text);
			}
			throw new ProxyGenerationException("This is a DynamicProxy2 error: " + str);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000658D File Offset: 0x0000478D
		protected void InitializeStaticFields(Type builtType)
		{
			builtType.SetStaticField("proxyGenerationOptions", BindingFlags.NonPublic, this.ProxyGenerationOptions);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000065A4 File Offset: 0x000047A4
		[Obsolete("Exposes a component that is intended for internal use only.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected Type ObtainProxyType(CacheKey cacheKey, Func<string, INamingScope, Type> factory)
		{
			bool notFoundInTypeCache = false;
			Type orAdd = this.Scope.TypeCache.GetOrAdd(cacheKey, delegate(CacheKey _)
			{
				notFoundInTypeCache = true;
				this.Logger.DebugFormat("No cached proxy type was found for target type {0}.", new object[]
				{
					this.targetType.FullName
				});
				this.EnsureOptionsOverrideEqualsAndGetHashCode(this.ProxyGenerationOptions);
				string uniqueName = this.Scope.NamingScope.GetUniqueName("Castle.Proxies." + this.targetType.Name + "Proxy");
				return factory(uniqueName, this.Scope.NamingScope.SafeSubScope());
			});
			if (!notFoundInTypeCache)
			{
				this.Logger.DebugFormat("Found cached proxy type {0} for target type {1}.", new object[]
				{
					orAdd.FullName,
					this.targetType.FullName
				});
			}
			return orAdd;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00006620 File Offset: 0x00004820
		private bool OverridesEqualsAndGetHashCode(Type type)
		{
			MethodInfo method = type.GetMethod("Equals", BindingFlags.Instance | BindingFlags.Public);
			if (method == null || method.DeclaringType == typeof(object) || method.IsAbstract)
			{
				return false;
			}
			MethodInfo method2 = type.GetMethod("GetHashCode", BindingFlags.Instance | BindingFlags.Public);
			return !(method2 == null) && !(method2.DeclaringType == typeof(object)) && !method2.IsAbstract;
		}

		// Token: 0x04000068 RID: 104
		protected readonly Type targetType;

		// Token: 0x04000069 RID: 105
		private readonly ModuleScope scope;

		// Token: 0x0400006A RID: 106
		private ILogger logger = NullLogger.Instance;

		// Token: 0x0400006B RID: 107
		private ProxyGenerationOptions proxyGenerationOptions;
	}
}
