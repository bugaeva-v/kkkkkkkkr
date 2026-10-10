using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Castle.DynamicProxy;
using NSubstitute.Core;
using NSubstitute.Exceptions;

namespace NSubstitute.Proxies.CastleDynamicProxy
{
	// Token: 0x0200003F RID: 63
	public class CastleDynamicProxyFactory : IProxyFactory
	{
		// Token: 0x060000D9 RID: 217 RVA: 0x0000405A File Offset: 0x0000225A
		public CastleDynamicProxyFactory(ICallFactory callFactory, IArgumentSpecificationDequeue argSpecificationDequeue)
		{
			this._callFactory = callFactory;
			this._argSpecificationDequeue = argSpecificationDequeue;
			this._proxyGenerator = new ProxyGenerator();
			this._allMethodsExceptCallRouterCallsHook = new CastleDynamicProxyFactory.AllMethodsExceptCallRouterCallsHook();
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00004086 File Offset: 0x00002286
		public object GenerateProxy(ICallRouter callRouter, Type typeToProxy, [Nullable(new byte[]
		{
			2,
			0
		})] Type[] additionalInterfaces, [Nullable(2)] object[] constructorArguments)
		{
			if (!typeToProxy.IsDelegate())
			{
				return this.GenerateTypeProxy(callRouter, typeToProxy, additionalInterfaces, constructorArguments);
			}
			return this.GenerateDelegateProxy(callRouter, typeToProxy, additionalInterfaces, constructorArguments);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000040A8 File Offset: 0x000022A8
		private object GenerateTypeProxy(ICallRouter callRouter, Type typeToProxy, [Nullable(new byte[]
		{
			2,
			0
		})] Type[] additionalInterfaces, [Nullable(2)] object[] constructorArguments)
		{
			CastleDynamicProxyFactory.VerifyClassHasNotBeenPassedAsAnAdditionalInterface(additionalInterfaces);
			ProxyIdInterceptor proxyIdInterceptor = new ProxyIdInterceptor(typeToProxy);
			CastleForwardingInterceptor castleForwardingInterceptor = this.CreateForwardingInterceptor(callRouter);
			ProxyGenerationOptions optionsToMixinCallRouterProvider = this.GetOptionsToMixinCallRouterProvider(callRouter);
			object result = this.CreateProxyUsingCastleProxyGenerator(typeToProxy, additionalInterfaces, constructorArguments, new IInterceptor[]
			{
				proxyIdInterceptor,
				castleForwardingInterceptor
			}, optionsToMixinCallRouterProvider);
			castleForwardingInterceptor.SwitchToFullDispatchMode();
			return result;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000040F4 File Offset: 0x000022F4
		private object GenerateDelegateProxy(ICallRouter callRouter, Type delegateType, [Nullable(new byte[]
		{
			2,
			0
		})] Type[] additionalInterfaces, [Nullable(2)] object[] constructorArguments)
		{
			CastleDynamicProxyFactory.VerifyNoAdditionalInterfacesGivenForDelegate(additionalInterfaces);
			CastleDynamicProxyFactory.VerifyNoConstructorArgumentsGivenForDelegate(constructorArguments);
			CastleForwardingInterceptor castleForwardingInterceptor = this.CreateForwardingInterceptor(callRouter);
			ProxyIdInterceptor proxyIdInterceptor = new ProxyIdInterceptor(delegateType);
			ProxyGenerationOptions optionsToMixinCallRouterProvider = this.GetOptionsToMixinCallRouterProvider(callRouter);
			optionsToMixinCallRouterProvider.AddDelegateTypeMixin(delegateType);
			object obj = this.CreateProxyUsingCastleProxyGenerator(typeof(object), null, null, new IInterceptor[]
			{
				proxyIdInterceptor,
				castleForwardingInterceptor
			}, optionsToMixinCallRouterProvider);
			castleForwardingInterceptor.SwitchToFullDispatchMode();
			return obj.GetType().GetInvokeMethod().CreateDelegate(delegateType, obj);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00004166 File Offset: 0x00002366
		private CastleForwardingInterceptor CreateForwardingInterceptor(ICallRouter callRouter)
		{
			return new CastleForwardingInterceptor(new CastleInvocationMapper(this._callFactory, this._argSpecificationDequeue), callRouter);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00004180 File Offset: 0x00002380
		private object CreateProxyUsingCastleProxyGenerator(Type typeToProxy, [Nullable(new byte[]
		{
			2,
			0
		})] Type[] additionalInterfaces, [Nullable(2)] object[] constructorArguments, IInterceptor[] interceptors, ProxyGenerationOptions proxyGenerationOptions)
		{
			if (typeToProxy.GetTypeInfo().IsInterface)
			{
				CastleDynamicProxyFactory.VerifyNoConstructorArgumentsGivenForInterface(constructorArguments);
				Type[] array = new Type[(additionalInterfaces != null) ? (additionalInterfaces.Length + 1) : 1];
				array[0] = typeToProxy;
				if (additionalInterfaces != null)
				{
					Array.Copy(additionalInterfaces, 0, array, 1, additionalInterfaces.Length);
				}
				typeToProxy = typeof(object);
				additionalInterfaces = array;
			}
			return this._proxyGenerator.CreateClassProxy(typeToProxy, additionalInterfaces, proxyGenerationOptions, constructorArguments, interceptors);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000041E5 File Offset: 0x000023E5
		private ProxyGenerationOptions GetOptionsToMixinCallRouterProvider(ICallRouter callRouter)
		{
			ProxyGenerationOptions proxyGenerationOptions = new ProxyGenerationOptions(this._allMethodsExceptCallRouterCallsHook);
			proxyGenerationOptions.AddMixinInstance(new CastleDynamicProxyFactory.StaticCallRouterProvider(callRouter));
			return proxyGenerationOptions;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000041FE File Offset: 0x000023FE
		[NullableContext(2)]
		private static void VerifyNoConstructorArgumentsGivenForInterface(object[] constructorArguments)
		{
			if (CastleDynamicProxyFactory.HasItems<object>(constructorArguments))
			{
				throw new SubstituteException("Can not provide constructor arguments when substituting for an interface.");
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00004213 File Offset: 0x00002413
		[NullableContext(2)]
		private static void VerifyNoConstructorArgumentsGivenForDelegate(object[] constructorArguments)
		{
			if (CastleDynamicProxyFactory.HasItems<object>(constructorArguments))
			{
				throw new SubstituteException("Can not provide constructor arguments when substituting for a delegate.");
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00004228 File Offset: 0x00002428
		private static void VerifyNoAdditionalInterfacesGivenForDelegate([Nullable(new byte[]
		{
			2,
			0
		})] Type[] constructorArguments)
		{
			if (CastleDynamicProxyFactory.HasItems<Type>(constructorArguments))
			{
				throw new SubstituteException("Can not specify additional interfaces when substituting for a delegate. You must specify only a single delegate type if you need to substitute for a delegate.");
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000423D File Offset: 0x0000243D
		private static void VerifyClassHasNotBeenPassedAsAnAdditionalInterface([Nullable(new byte[]
		{
			2,
			0
		})] Type[] additionalInterfaces)
		{
			if (additionalInterfaces != null)
			{
				if (additionalInterfaces.Any((Type x) => x.GetTypeInfo().IsClass))
				{
					throw new SubstituteException("Can not substitute for multiple classes. To substitute for multiple types only one type can be a concrete class; other types can only be interfaces.");
				}
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00004274 File Offset: 0x00002474
		private static bool HasItems<T>([Nullable(new byte[]
		{
			2,
			0
		})] T[] array)
		{
			return array == null || array.Length != 0;
		}

		// Token: 0x0400004F RID: 79
		private readonly ICallFactory _callFactory;

		// Token: 0x04000050 RID: 80
		private readonly IArgumentSpecificationDequeue _argSpecificationDequeue;

		// Token: 0x04000051 RID: 81
		private readonly ProxyGenerator _proxyGenerator;

		// Token: 0x04000052 RID: 82
		private readonly CastleDynamicProxyFactory.AllMethodsExceptCallRouterCallsHook _allMethodsExceptCallRouterCallsHook;

		// Token: 0x020000FB RID: 251
		private class AllMethodsExceptCallRouterCallsHook : AllMethodsHook
		{
			// Token: 0x060003F9 RID: 1017 RVA: 0x000096E0 File Offset: 0x000078E0
			public override bool ShouldInterceptMethod(Type type, MethodInfo methodInfo)
			{
				return ProxyIdInterceptor.IsDefaultToStringMethod(methodInfo) || (CastleDynamicProxyFactory.AllMethodsExceptCallRouterCallsHook.IsNotCallRouterProviderMethod(methodInfo) && CastleDynamicProxyFactory.AllMethodsExceptCallRouterCallsHook.IsNotBaseObjectMethod(methodInfo) && base.ShouldInterceptMethod(type, methodInfo));
			}

			// Token: 0x060003FA RID: 1018 RVA: 0x00009706 File Offset: 0x00007906
			private static bool IsNotCallRouterProviderMethod(MethodInfo methodInfo)
			{
				return methodInfo.DeclaringType != typeof(ICallRouterProvider);
			}

			// Token: 0x060003FB RID: 1019 RVA: 0x0000971D File Offset: 0x0000791D
			private static bool IsNotBaseObjectMethod(MethodInfo methodInfo)
			{
				return methodInfo.GetBaseDefinition().DeclaringType != typeof(object);
			}
		}

		// Token: 0x020000FC RID: 252
		private class StaticCallRouterProvider : ICallRouterProvider
		{
			// Token: 0x060003FD RID: 1021 RVA: 0x00009741 File Offset: 0x00007941
			public StaticCallRouterProvider(ICallRouter callRouter)
			{
				this._callRouter = callRouter;
			}

			// Token: 0x060003FE RID: 1022 RVA: 0x00009750 File Offset: 0x00007950
			public ICallRouter GetCallRouter()
			{
				return this._callRouter;
			}

			// Token: 0x04000125 RID: 293
			private readonly ICallRouter _callRouter;
		}
	}
}
