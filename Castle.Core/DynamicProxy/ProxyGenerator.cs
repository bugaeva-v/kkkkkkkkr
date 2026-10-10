using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security;
using System.Security.Permissions;
using System.Text;
using Castle.Core.Internal;
using Castle.Core.Logging;
using Castle.DynamicProxy.Generators;

namespace Castle.DynamicProxy
{
	// Token: 0x02000019 RID: 25
	[CLSCompliant(true)]
	public class ProxyGenerator : IProxyGenerator
	{
		// Token: 0x060000DA RID: 218 RVA: 0x00003D72 File Offset: 0x00001F72
		public ProxyGenerator(IProxyBuilder builder)
		{
			this.proxyBuilder = builder;
			if (this.HasSecurityPermission())
			{
				this.Logger = new TraceLogger("Castle.DynamicProxy", LoggerLevel.Warn);
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00003DA5 File Offset: 0x00001FA5
		private bool HasSecurityPermission()
		{
			return new SecurityPermission(SecurityPermissionFlag.ControlEvidence | SecurityPermissionFlag.ControlPolicy).IsGranted();
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00003DB3 File Offset: 0x00001FB3
		public ProxyGenerator() : this(new DefaultProxyBuilder())
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00003DC0 File Offset: 0x00001FC0
		public ProxyGenerator(bool disableSignedModule) : this(new DefaultProxyBuilder(new ModuleScope(false, disableSignedModule)))
		{
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00003DD4 File Offset: 0x00001FD4
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00003DDC File Offset: 0x00001FDC
		public ILogger Logger
		{
			get
			{
				return this.logger;
			}
			set
			{
				this.logger = value;
				this.proxyBuilder.Logger = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00003DF1 File Offset: 0x00001FF1
		public IProxyBuilder ProxyBuilder
		{
			get
			{
				return this.proxyBuilder;
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00003DF9 File Offset: 0x00001FF9
		public TInterface CreateInterfaceProxyWithTarget<TInterface>(TInterface target, params IInterceptor[] interceptors) where TInterface : class
		{
			return (TInterface)((object)this.CreateInterfaceProxyWithTarget(typeof(TInterface), target, ProxyGenerationOptions.Default, interceptors));
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00003E1C File Offset: 0x0000201C
		public TInterface CreateInterfaceProxyWithTarget<TInterface>(TInterface target, ProxyGenerationOptions options, params IInterceptor[] interceptors) where TInterface : class
		{
			return (TInterface)((object)this.CreateInterfaceProxyWithTarget(typeof(TInterface), target, options, interceptors));
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00003E3B File Offset: 0x0000203B
		public object CreateInterfaceProxyWithTarget(Type interfaceToProxy, object target, params IInterceptor[] interceptors)
		{
			return this.CreateInterfaceProxyWithTarget(interfaceToProxy, target, ProxyGenerationOptions.Default, interceptors);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00003E4B File Offset: 0x0000204B
		public object CreateInterfaceProxyWithTarget(Type interfaceToProxy, object target, ProxyGenerationOptions options, params IInterceptor[] interceptors)
		{
			return this.CreateInterfaceProxyWithTarget(interfaceToProxy, null, target, options, interceptors);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00003E59 File Offset: 0x00002059
		public object CreateInterfaceProxyWithTarget(Type interfaceToProxy, Type[] additionalInterfacesToProxy, object target, params IInterceptor[] interceptors)
		{
			return this.CreateInterfaceProxyWithTarget(interfaceToProxy, additionalInterfacesToProxy, target, ProxyGenerationOptions.Default, interceptors);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00003E6C File Offset: 0x0000206C
		public virtual object CreateInterfaceProxyWithTarget(Type interfaceToProxy, Type[] additionalInterfacesToProxy, object target, ProxyGenerationOptions options, params IInterceptor[] interceptors)
		{
			if (interfaceToProxy == null)
			{
				throw new ArgumentNullException("interfaceToProxy");
			}
			if (target == null)
			{
				throw new ArgumentNullException("target");
			}
			if (interceptors == null)
			{
				throw new ArgumentNullException("interceptors");
			}
			if (!interfaceToProxy.GetTypeInfo().IsInterface)
			{
				throw new ArgumentException("Specified type is not an interface", "interfaceToProxy");
			}
			Type type = target.GetType();
			if (!interfaceToProxy.IsAssignableFrom(type))
			{
				throw new ArgumentException("Target does not implement interface " + interfaceToProxy.FullName, "target");
			}
			this.CheckNotGenericTypeDefinition(interfaceToProxy, "interfaceToProxy");
			this.CheckNotGenericTypeDefinitions(additionalInterfacesToProxy, "additionalInterfacesToProxy");
			Type type2 = this.CreateInterfaceProxyTypeWithTarget(interfaceToProxy, additionalInterfacesToProxy, type, options);
			List<object> constructorArguments = this.GetConstructorArguments(target, interceptors, options);
			return Activator.CreateInstance(type2, constructorArguments.ToArray());
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00003F2C File Offset: 0x0000212C
		protected List<object> GetConstructorArguments(object target, IInterceptor[] interceptors, ProxyGenerationOptions options)
		{
			List<object> list = new List<object>(options.MixinData.Mixins)
			{
				interceptors,
				target
			};
			if (options.Selector != null)
			{
				list.Add(options.Selector);
			}
			return list;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00003F6D File Offset: 0x0000216D
		public object CreateInterfaceProxyWithTargetInterface(Type interfaceToProxy, object target, params IInterceptor[] interceptors)
		{
			return this.CreateInterfaceProxyWithTargetInterface(interfaceToProxy, target, ProxyGenerationOptions.Default, interceptors);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00003F7D File Offset: 0x0000217D
		public TInterface CreateInterfaceProxyWithTargetInterface<TInterface>(TInterface target, params IInterceptor[] interceptors) where TInterface : class
		{
			return (TInterface)((object)this.CreateInterfaceProxyWithTargetInterface(typeof(TInterface), target, ProxyGenerationOptions.Default, interceptors));
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00003FA0 File Offset: 0x000021A0
		public TInterface CreateInterfaceProxyWithTargetInterface<TInterface>(TInterface target, ProxyGenerationOptions options, params IInterceptor[] interceptors) where TInterface : class
		{
			return (TInterface)((object)this.CreateInterfaceProxyWithTargetInterface(typeof(TInterface), target, options, interceptors));
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00003FBF File Offset: 0x000021BF
		public object CreateInterfaceProxyWithTargetInterface(Type interfaceToProxy, Type[] additionalInterfacesToProxy, object target, params IInterceptor[] interceptors)
		{
			return this.CreateInterfaceProxyWithTargetInterface(interfaceToProxy, additionalInterfacesToProxy, target, ProxyGenerationOptions.Default, interceptors);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00003FD1 File Offset: 0x000021D1
		public object CreateInterfaceProxyWithTargetInterface(Type interfaceToProxy, object target, ProxyGenerationOptions options, params IInterceptor[] interceptors)
		{
			return this.CreateInterfaceProxyWithTargetInterface(interfaceToProxy, null, target, options, interceptors);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00003FE0 File Offset: 0x000021E0
		[SecuritySafeCritical]
		public virtual object CreateInterfaceProxyWithTargetInterface(Type interfaceToProxy, Type[] additionalInterfacesToProxy, object target, ProxyGenerationOptions options, params IInterceptor[] interceptors)
		{
			if (interfaceToProxy == null)
			{
				throw new ArgumentNullException("interfaceToProxy");
			}
			if (target != null && !interfaceToProxy.IsInstanceOfType(target))
			{
				throw new ArgumentException("Target does not implement interface " + interfaceToProxy.FullName, "target");
			}
			if (interceptors == null)
			{
				throw new ArgumentNullException("interceptors");
			}
			if (!interfaceToProxy.GetTypeInfo().IsInterface)
			{
				throw new ArgumentException("Specified type is not an interface", "interfaceToProxy");
			}
			bool flag = false;
			if (target != null)
			{
				flag = RemotingServices.IsTransparentProxy(target);
				if (!flag && Marshal.IsComObject(target))
				{
					Guid guid = interfaceToProxy.GUID;
					if (guid != Guid.Empty)
					{
						IntPtr iunknownForObject = Marshal.GetIUnknownForObject(target);
						IntPtr zero = IntPtr.Zero;
						int num = Marshal.QueryInterface(iunknownForObject, ref guid, out zero);
						bool flag2 = zero == IntPtr.Zero;
						Marshal.Release(iunknownForObject);
						if (!flag2)
						{
							Marshal.Release(zero);
						}
						if (num == 0 && flag2)
						{
							throw new ArgumentException("Target COM object does not implement interface " + interfaceToProxy.FullName, "target");
						}
					}
				}
			}
			this.CheckNotGenericTypeDefinition(interfaceToProxy, "interfaceToProxy");
			this.CheckNotGenericTypeDefinitions(additionalInterfacesToProxy, "additionalInterfacesToProxy");
			Type type = this.CreateInterfaceProxyTypeWithTargetInterface(interfaceToProxy, additionalInterfacesToProxy, options);
			List<object> constructorArguments = this.GetConstructorArguments(target, interceptors, options);
			if (flag)
			{
				return type.GetConstructors()[0].Invoke(constructorArguments.ToArray());
			}
			return Activator.CreateInstance(type, constructorArguments.ToArray());
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00004132 File Offset: 0x00002332
		public TInterface CreateInterfaceProxyWithoutTarget<TInterface>(IInterceptor interceptor) where TInterface : class
		{
			return (TInterface)((object)this.CreateInterfaceProxyWithoutTarget(typeof(TInterface), interceptor));
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000414A File Offset: 0x0000234A
		public TInterface CreateInterfaceProxyWithoutTarget<TInterface>(params IInterceptor[] interceptors) where TInterface : class
		{
			return (TInterface)((object)this.CreateInterfaceProxyWithoutTarget(typeof(TInterface), interceptors));
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00004162 File Offset: 0x00002362
		public TInterface CreateInterfaceProxyWithoutTarget<TInterface>(ProxyGenerationOptions options, params IInterceptor[] interceptors) where TInterface : class
		{
			return (TInterface)((object)this.CreateInterfaceProxyWithoutTarget(typeof(TInterface), Type.EmptyTypes, options, interceptors));
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00004180 File Offset: 0x00002380
		public object CreateInterfaceProxyWithoutTarget(Type interfaceToProxy, IInterceptor interceptor)
		{
			return this.CreateInterfaceProxyWithoutTarget(interfaceToProxy, Type.EmptyTypes, ProxyGenerationOptions.Default, new IInterceptor[]
			{
				interceptor
			});
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000419D File Offset: 0x0000239D
		public object CreateInterfaceProxyWithoutTarget(Type interfaceToProxy, params IInterceptor[] interceptors)
		{
			return this.CreateInterfaceProxyWithoutTarget(interfaceToProxy, Type.EmptyTypes, ProxyGenerationOptions.Default, interceptors);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000041B1 File Offset: 0x000023B1
		public object CreateInterfaceProxyWithoutTarget(Type interfaceToProxy, Type[] additionalInterfacesToProxy, params IInterceptor[] interceptors)
		{
			return this.CreateInterfaceProxyWithoutTarget(interfaceToProxy, additionalInterfacesToProxy, ProxyGenerationOptions.Default, interceptors);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000041C1 File Offset: 0x000023C1
		public object CreateInterfaceProxyWithoutTarget(Type interfaceToProxy, ProxyGenerationOptions options, params IInterceptor[] interceptors)
		{
			return this.CreateInterfaceProxyWithoutTarget(interfaceToProxy, Type.EmptyTypes, options, interceptors);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000041D4 File Offset: 0x000023D4
		public virtual object CreateInterfaceProxyWithoutTarget(Type interfaceToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options, params IInterceptor[] interceptors)
		{
			if (interfaceToProxy == null)
			{
				throw new ArgumentNullException("interfaceToProxy");
			}
			if (interceptors == null)
			{
				throw new ArgumentNullException("interceptors");
			}
			if (!interfaceToProxy.GetTypeInfo().IsInterface)
			{
				throw new ArgumentException("Specified type is not an interface", "interfaceToProxy");
			}
			this.CheckNotGenericTypeDefinition(interfaceToProxy, "interfaceToProxy");
			this.CheckNotGenericTypeDefinitions(additionalInterfacesToProxy, "additionalInterfacesToProxy");
			Type type = this.CreateInterfaceProxyTypeWithoutTarget(interfaceToProxy, additionalInterfacesToProxy, options);
			List<object> constructorArguments = this.GetConstructorArguments(null, interceptors, options);
			return Activator.CreateInstance(type, constructorArguments.ToArray());
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00004258 File Offset: 0x00002458
		public TClass CreateClassProxyWithTarget<TClass>(TClass target, params IInterceptor[] interceptors) where TClass : class
		{
			return (TClass)((object)this.CreateClassProxyWithTarget(typeof(TClass), Type.EmptyTypes, target, ProxyGenerationOptions.Default, new object[0], interceptors));
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00004286 File Offset: 0x00002486
		public TClass CreateClassProxyWithTarget<TClass>(TClass target, ProxyGenerationOptions options, params IInterceptor[] interceptors) where TClass : class
		{
			return (TClass)((object)this.CreateClassProxyWithTarget(typeof(TClass), Type.EmptyTypes, target, options, new object[0], interceptors));
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000042B0 File Offset: 0x000024B0
		public object CreateClassProxyWithTarget(Type classToProxy, Type[] additionalInterfacesToProxy, object target, params IInterceptor[] interceptors)
		{
			return this.CreateClassProxyWithTarget(classToProxy, additionalInterfacesToProxy, target, ProxyGenerationOptions.Default, new object[0], interceptors);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000042C8 File Offset: 0x000024C8
		public object CreateClassProxyWithTarget(Type classToProxy, object target, ProxyGenerationOptions options, object[] constructorArguments, params IInterceptor[] interceptors)
		{
			return this.CreateClassProxyWithTarget(classToProxy, Type.EmptyTypes, target, options, constructorArguments, interceptors);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000042DC File Offset: 0x000024DC
		public object CreateClassProxyWithTarget(Type classToProxy, object target, object[] constructorArguments, params IInterceptor[] interceptors)
		{
			return this.CreateClassProxyWithTarget(classToProxy, Type.EmptyTypes, target, ProxyGenerationOptions.Default, constructorArguments, interceptors);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000042F3 File Offset: 0x000024F3
		public object CreateClassProxyWithTarget(Type classToProxy, object target, params IInterceptor[] interceptors)
		{
			return this.CreateClassProxyWithTarget(classToProxy, Type.EmptyTypes, target, ProxyGenerationOptions.Default, new object[0], interceptors);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000430E File Offset: 0x0000250E
		public object CreateClassProxyWithTarget(Type classToProxy, object target, ProxyGenerationOptions options, params IInterceptor[] interceptors)
		{
			return this.CreateClassProxyWithTarget(classToProxy, Type.EmptyTypes, target, options, new object[0], interceptors);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00004326 File Offset: 0x00002526
		public object CreateClassProxyWithTarget(Type classToProxy, Type[] additionalInterfacesToProxy, object target, ProxyGenerationOptions options, params IInterceptor[] interceptors)
		{
			return this.CreateClassProxyWithTarget(classToProxy, additionalInterfacesToProxy, target, options, new object[0], interceptors);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000433C File Offset: 0x0000253C
		public virtual object CreateClassProxyWithTarget(Type classToProxy, Type[] additionalInterfacesToProxy, object target, ProxyGenerationOptions options, object[] constructorArguments, params IInterceptor[] interceptors)
		{
			if (classToProxy == null)
			{
				throw new ArgumentNullException("classToProxy");
			}
			if (options == null)
			{
				throw new ArgumentNullException("options");
			}
			if (!classToProxy.GetTypeInfo().IsClass)
			{
				throw new ArgumentException("'classToProxy' must be a class", "classToProxy");
			}
			this.CheckNotGenericTypeDefinition(classToProxy, "classToProxy");
			this.CheckNotGenericTypeDefinitions(additionalInterfacesToProxy, "additionalInterfacesToProxy");
			Type proxyType = this.CreateClassProxyTypeWithTarget(classToProxy, additionalInterfacesToProxy, options);
			List<object> list = this.BuildArgumentListForClassProxyWithTarget(target, options, interceptors);
			if (constructorArguments != null && constructorArguments.Length != 0)
			{
				list.AddRange(constructorArguments);
			}
			return this.CreateClassProxyInstance(proxyType, list, classToProxy, constructorArguments);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000043D4 File Offset: 0x000025D4
		public TClass CreateClassProxy<TClass>(params IInterceptor[] interceptors) where TClass : class
		{
			return (TClass)((object)this.CreateClassProxy(typeof(TClass), ProxyGenerationOptions.Default, interceptors));
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000043F1 File Offset: 0x000025F1
		public TClass CreateClassProxy<TClass>(ProxyGenerationOptions options, params IInterceptor[] interceptors) where TClass : class
		{
			return (TClass)((object)this.CreateClassProxy(typeof(TClass), options, interceptors));
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000440A File Offset: 0x0000260A
		public object CreateClassProxy(Type classToProxy, Type[] additionalInterfacesToProxy, params IInterceptor[] interceptors)
		{
			return this.CreateClassProxy(classToProxy, additionalInterfacesToProxy, ProxyGenerationOptions.Default, interceptors);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000441A File Offset: 0x0000261A
		public object CreateClassProxy(Type classToProxy, ProxyGenerationOptions options, object[] constructorArguments, params IInterceptor[] interceptors)
		{
			return this.CreateClassProxy(classToProxy, null, options, constructorArguments, interceptors);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00004428 File Offset: 0x00002628
		public object CreateClassProxy(Type classToProxy, object[] constructorArguments, params IInterceptor[] interceptors)
		{
			return this.CreateClassProxy(classToProxy, null, ProxyGenerationOptions.Default, constructorArguments, interceptors);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00004439 File Offset: 0x00002639
		public object CreateClassProxy(Type classToProxy, params IInterceptor[] interceptors)
		{
			return this.CreateClassProxy(classToProxy, null, ProxyGenerationOptions.Default, null, interceptors);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000444A File Offset: 0x0000264A
		public object CreateClassProxy(Type classToProxy, ProxyGenerationOptions options, params IInterceptor[] interceptors)
		{
			return this.CreateClassProxy(classToProxy, null, options, interceptors);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00004456 File Offset: 0x00002656
		public object CreateClassProxy(Type classToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options, params IInterceptor[] interceptors)
		{
			return this.CreateClassProxy(classToProxy, additionalInterfacesToProxy, options, null, interceptors);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00004464 File Offset: 0x00002664
		public virtual object CreateClassProxy(Type classToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options, object[] constructorArguments, params IInterceptor[] interceptors)
		{
			if (classToProxy == null)
			{
				throw new ArgumentNullException("classToProxy");
			}
			if (options == null)
			{
				throw new ArgumentNullException("options");
			}
			if (!classToProxy.GetTypeInfo().IsClass)
			{
				throw new ArgumentException("'classToProxy' must be a class", "classToProxy");
			}
			this.CheckNotGenericTypeDefinition(classToProxy, "classToProxy");
			this.CheckNotGenericTypeDefinitions(additionalInterfacesToProxy, "additionalInterfacesToProxy");
			Type proxyType = this.CreateClassProxyType(classToProxy, additionalInterfacesToProxy, options);
			List<object> list = this.BuildArgumentListForClassProxy(options, interceptors);
			if (constructorArguments != null && constructorArguments.Length != 0)
			{
				list.AddRange(constructorArguments);
			}
			return this.CreateClassProxyInstance(proxyType, list, classToProxy, constructorArguments);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000044F8 File Offset: 0x000026F8
		protected object CreateClassProxyInstance(Type proxyType, List<object> proxyArguments, Type classToProxy, object[] constructorArguments)
		{
			object result;
			try
			{
				result = Activator.CreateInstance(proxyType, proxyArguments.ToArray());
			}
			catch (MissingMethodException)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendFormat("Can not instantiate proxy of class: {0}.", classToProxy.FullName);
				stringBuilder.AppendLine();
				if (constructorArguments == null || constructorArguments.Length == 0)
				{
					stringBuilder.Append("Could not find a parameterless constructor.");
				}
				else
				{
					stringBuilder.AppendLine("Could not find a constructor that would match given arguments:");
					foreach (object obj in constructorArguments)
					{
						string value = (obj == null) ? "<null>" : obj.GetType().ToString();
						stringBuilder.AppendLine(value);
					}
				}
				throw new InvalidProxyConstructorArgumentsException(stringBuilder.ToString(), proxyType, classToProxy);
			}
			return result;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000045B4 File Offset: 0x000027B4
		protected void CheckNotGenericTypeDefinition(Type type, string argumentName)
		{
			if (type != null && type.GetTypeInfo().IsGenericTypeDefinition)
			{
				throw new GeneratorException(string.Format("Can not create proxy for type {0} because it is an open generic type.", type.GetBestName()));
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000045E4 File Offset: 0x000027E4
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

		// Token: 0x0600010B RID: 267 RVA: 0x00004634 File Offset: 0x00002834
		protected List<object> BuildArgumentListForClassProxyWithTarget(object target, ProxyGenerationOptions options, IInterceptor[] interceptors)
		{
			List<object> list = new List<object>();
			list.Add(target);
			list.AddRange(options.MixinData.Mixins);
			list.Add(interceptors);
			if (options.Selector != null)
			{
				list.Add(options.Selector);
			}
			return list;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000467C File Offset: 0x0000287C
		protected List<object> BuildArgumentListForClassProxy(ProxyGenerationOptions options, IInterceptor[] interceptors)
		{
			List<object> list = new List<object>(options.MixinData.Mixins)
			{
				interceptors
			};
			if (options.Selector != null)
			{
				list.Add(options.Selector);
			}
			return list;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000046B6 File Offset: 0x000028B6
		protected Type CreateClassProxyType(Type classToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options)
		{
			return this.ProxyBuilder.CreateClassProxyType(classToProxy, additionalInterfacesToProxy, options);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000046C6 File Offset: 0x000028C6
		protected Type CreateInterfaceProxyTypeWithTarget(Type interfaceToProxy, Type[] additionalInterfacesToProxy, Type targetType, ProxyGenerationOptions options)
		{
			return this.ProxyBuilder.CreateInterfaceProxyTypeWithTarget(interfaceToProxy, additionalInterfacesToProxy, targetType, options);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000046D8 File Offset: 0x000028D8
		protected Type CreateInterfaceProxyTypeWithTargetInterface(Type interfaceToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options)
		{
			return this.ProxyBuilder.CreateInterfaceProxyTypeWithTargetInterface(interfaceToProxy, additionalInterfacesToProxy, options);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000046E8 File Offset: 0x000028E8
		protected Type CreateInterfaceProxyTypeWithoutTarget(Type interfaceToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options)
		{
			return this.ProxyBuilder.CreateInterfaceProxyTypeWithoutTarget(interfaceToProxy, additionalInterfacesToProxy, options);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000046F8 File Offset: 0x000028F8
		protected Type CreateClassProxyTypeWithTarget(Type classToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options)
		{
			return this.ProxyBuilder.CreateClassProxyTypeWithTarget(classToProxy, additionalInterfacesToProxy, options);
		}

		// Token: 0x04000032 RID: 50
		private ILogger logger = NullLogger.Instance;

		// Token: 0x04000033 RID: 51
		private readonly IProxyBuilder proxyBuilder;
	}
}
