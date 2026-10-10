using System;
using System.Reflection;
using Castle.Core.Internal;
using Castle.DynamicProxy.Generators;

namespace Castle.DynamicProxy.Internal
{
	// Token: 0x0200002B RID: 43
	public static class InvocationHelper
	{
		// Token: 0x06000161 RID: 353 RVA: 0x000058F2 File Offset: 0x00003AF2
		public static MethodInfo GetMethodOnObject(object target, MethodInfo proxiedMethod)
		{
			if (target == null)
			{
				return null;
			}
			return InvocationHelper.GetMethodOnType(target.GetType(), proxiedMethod);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00005908 File Offset: 0x00003B08
		public static MethodInfo GetMethodOnType(Type type, MethodInfo proxiedMethod)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			InvocationHelper.CacheKey key = new InvocationHelper.CacheKey(proxiedMethod, type);
			return InvocationHelper.cache.GetOrAdd(key, (InvocationHelper.CacheKey ck) => InvocationHelper.ObtainMethod(proxiedMethod, type));
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000596C File Offset: 0x00003B6C
		private static MethodInfo ObtainMethod(MethodInfo proxiedMethod, Type type)
		{
			Type[] array = null;
			if (proxiedMethod.IsGenericMethod)
			{
				array = proxiedMethod.GetGenericArguments();
				proxiedMethod = proxiedMethod.GetGenericMethodDefinition();
			}
			Type declaringType = proxiedMethod.DeclaringType;
			MethodInfo methodInfo = null;
			if (declaringType.GetTypeInfo().IsInterface)
			{
				InterfaceMapping runtimeInterfaceMap = type.GetTypeInfo().GetRuntimeInterfaceMap(declaringType);
				int num = Array.IndexOf<MethodInfo>(runtimeInterfaceMap.InterfaceMethods, proxiedMethod);
				methodInfo = runtimeInterfaceMap.TargetMethods[num];
			}
			else
			{
				foreach (MethodInfo methodInfo2 in MethodFinder.GetAllInstanceMethods(type, BindingFlags.Public | BindingFlags.NonPublic))
				{
					if (MethodSignatureComparer.Instance.Equals(methodInfo2.GetBaseDefinition(), proxiedMethod))
					{
						methodInfo = methodInfo2;
						break;
					}
				}
			}
			if (methodInfo == null)
			{
				throw new ArgumentException(string.Format("Could not find method overriding {0} on type {1}. This is most likely a bug. Please report it.", proxiedMethod, type));
			}
			if (array == null)
			{
				return methodInfo;
			}
			return methodInfo.MakeGenericMethod(array);
		}

		// Token: 0x04000065 RID: 101
		private static readonly SynchronizedDictionary<InvocationHelper.CacheKey, MethodInfo> cache = new SynchronizedDictionary<InvocationHelper.CacheKey, MethodInfo>();

		// Token: 0x020001BF RID: 447
		private struct CacheKey : IEquatable<InvocationHelper.CacheKey>
		{
			// Token: 0x06000DA9 RID: 3497 RVA: 0x00020F6F File Offset: 0x0001F16F
			public CacheKey(MethodInfo method, Type type)
			{
				this.Method = method;
				this.Type = type;
			}

			// Token: 0x17000291 RID: 657
			// (get) Token: 0x06000DAA RID: 3498 RVA: 0x00020F7F File Offset: 0x0001F17F
			public MethodInfo Method { get; }

			// Token: 0x17000292 RID: 658
			// (get) Token: 0x06000DAB RID: 3499 RVA: 0x00020F87 File Offset: 0x0001F187
			public Type Type { get; }

			// Token: 0x06000DAC RID: 3500 RVA: 0x00020F8F File Offset: 0x0001F18F
			public bool Equals(InvocationHelper.CacheKey other)
			{
				return this.Method == other.Method && this.Type == other.Type;
			}

			// Token: 0x06000DAD RID: 3501 RVA: 0x00020FB4 File Offset: 0x0001F1B4
			public override bool Equals(object obj)
			{
				if (obj == null)
				{
					return false;
				}
				if (obj is InvocationHelper.CacheKey)
				{
					InvocationHelper.CacheKey other = (InvocationHelper.CacheKey)obj;
					return this.Equals(other);
				}
				return false;
			}

			// Token: 0x06000DAE RID: 3502 RVA: 0x00020FE0 File Offset: 0x0001F1E0
			public override int GetHashCode()
			{
				return ((this.Method != null) ? this.Method.GetHashCode() : 0) * 397 ^ ((this.Type != null) ? this.Type.GetHashCode() : 0);
			}
		}
	}
}
