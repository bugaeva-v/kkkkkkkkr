using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using Castle.Core.Internal;
using Castle.DynamicProxy.Generators;
using Castle.DynamicProxy.Internal;

namespace Castle.DynamicProxy
{
	// Token: 0x0200001A RID: 26
	public static class ProxyUtil
	{
		// Token: 0x06000112 RID: 274 RVA: 0x00004708 File Offset: 0x00002908
		public static TDelegate CreateDelegateToMixin<TDelegate>(object proxy)
		{
			return (TDelegate)((object)ProxyUtil.CreateDelegateToMixin(proxy, typeof(TDelegate)));
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00004720 File Offset: 0x00002920
		public static Delegate CreateDelegateToMixin(object proxy, Type delegateType)
		{
			if (proxy == null)
			{
				throw new ArgumentNullException("proxy");
			}
			if (delegateType == null)
			{
				throw new ArgumentNullException("delegateType");
			}
			if (!delegateType.IsDelegateType())
			{
				throw new ArgumentException("Type is not a delegate type.", "delegateType");
			}
			MethodInfo invokeMethod = delegateType.GetMethod("Invoke");
			MethodInfo methodInfo = proxy.GetType().GetMember("Invoke", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).Cast<MethodInfo>().FirstOrDefault((MethodInfo m) => MethodSignatureComparer.Instance.EqualParameters(m, invokeMethod));
			if (methodInfo == null)
			{
				throw new MissingMethodException("The proxy does not have an Invoke method that is compatible with the requested delegate type.");
			}
			return Delegate.CreateDelegate(delegateType, proxy, methodInfo);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000047C4 File Offset: 0x000029C4
		public static object GetUnproxiedInstance(object instance)
		{
			if (!RemotingServices.IsTransparentProxy(instance))
			{
				IProxyTargetAccessor proxyTargetAccessor = instance as IProxyTargetAccessor;
				if (proxyTargetAccessor != null)
				{
					instance = proxyTargetAccessor.DynProxyGetTarget();
				}
			}
			return instance;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000047EC File Offset: 0x000029EC
		public static Type GetUnproxiedType(object instance)
		{
			if (!RemotingServices.IsTransparentProxy(instance))
			{
				IProxyTargetAccessor proxyTargetAccessor = instance as IProxyTargetAccessor;
				if (proxyTargetAccessor != null)
				{
					object obj = proxyTargetAccessor.DynProxyGetTarget();
					if (obj != null)
					{
						if (obj == instance)
						{
							return instance.GetType().GetTypeInfo().BaseType;
						}
						instance = obj;
					}
				}
			}
			return instance.GetType();
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00004833 File Offset: 0x00002A33
		public static bool IsProxy(object instance)
		{
			return RemotingServices.IsTransparentProxy(instance) || instance is IProxyTargetAccessor;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00004848 File Offset: 0x00002A48
		public static bool IsProxyType(Type type)
		{
			return typeof(IProxyTargetAccessor).IsAssignableFrom(type);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000485A File Offset: 0x00002A5A
		public static bool IsAccessible(MethodBase method)
		{
			return ProxyUtil.IsAccessibleMethod(method) && ProxyUtil.IsAccessibleType(method.DeclaringType);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00004871 File Offset: 0x00002A71
		public static bool IsAccessible(MethodBase method, out string message)
		{
			if (ProxyUtil.IsAccessible(method))
			{
				message = null;
				return true;
			}
			message = ProxyUtil.CreateMessageForInaccessibleMethod(method);
			return false;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00004889 File Offset: 0x00002A89
		public static bool IsAccessible(Type type)
		{
			return ProxyUtil.IsAccessibleType(type);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00004894 File Offset: 0x00002A94
		internal static bool AreInternalsVisibleToDynamicProxy(Assembly asm)
		{
			return ProxyUtil.internalsVisibleToDynamicProxy.GetOrAdd(asm, (Assembly a) => asm.GetCustomAttributes<InternalsVisibleToAttribute>().Any((InternalsVisibleToAttribute attr) => attr.AssemblyName.Contains(ModuleScope.DEFAULT_ASSEMBLY_NAME)));
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000048CC File Offset: 0x00002ACC
		internal static bool IsAccessibleType(Type target)
		{
			TypeInfo typeInfo = target.GetTypeInfo();
			if (typeInfo.IsPublic || typeInfo.IsNestedPublic)
			{
				return true;
			}
			bool isNested = target.IsNested;
			bool flag = isNested && (typeInfo.IsNestedAssembly || typeInfo.IsNestedFamORAssem);
			return ((!typeInfo.IsVisible && !isNested) || flag) && ProxyUtil.AreInternalsVisibleToDynamicProxy(typeInfo.Assembly);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00004938 File Offset: 0x00002B38
		internal static bool IsAccessibleMethod(MethodBase method)
		{
			return method.IsPublic || method.IsFamily || method.IsFamilyOrAssembly || ((method.IsAssembly || method.IsFamilyAndAssembly) && ProxyUtil.AreInternalsVisibleToDynamicProxy(method.DeclaringType.GetTypeInfo().Assembly));
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00004986 File Offset: 0x00002B86
		internal static bool IsInternal(MethodBase method)
		{
			return method.IsAssembly || (method.IsFamilyAndAssembly && !method.IsFamilyOrAssembly);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000049A8 File Offset: 0x00002BA8
		private static string CreateMessageForInaccessibleMethod(MethodBase inaccessibleMethod)
		{
			Assembly assembly = inaccessibleMethod.DeclaringType.GetTypeInfo().Assembly;
			string str = string.Format("Can not create proxy for method {0} because it or its declaring type is not accessible. ", inaccessibleMethod);
			string str2 = ExceptionMessageBuilder.CreateInstructionsToMakeVisible(assembly);
			return str + str2;
		}

		// Token: 0x04000034 RID: 52
		private static readonly SynchronizedDictionary<Assembly, bool> internalsVisibleToDynamicProxy = new SynchronizedDictionary<Assembly, bool>();
	}
}
