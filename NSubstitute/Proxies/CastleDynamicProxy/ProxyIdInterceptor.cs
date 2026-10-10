using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Castle.DynamicProxy;
using NSubstitute.Core;

namespace NSubstitute.Proxies.CastleDynamicProxy
{
	// Token: 0x02000042 RID: 66
	public class ProxyIdInterceptor : IInterceptor
	{
		// Token: 0x060000EB RID: 235 RVA: 0x000043C5 File Offset: 0x000025C5
		public ProxyIdInterceptor(Type primaryProxyType)
		{
			this._primaryProxyType = primaryProxyType;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000043D4 File Offset: 0x000025D4
		public void Intercept(IInvocation invocation)
		{
			if (ProxyIdInterceptor.IsDefaultToStringMethod(invocation.Method))
			{
				string returnValue;
				if ((returnValue = this._cachedProxyId) == null)
				{
					returnValue = (this._cachedProxyId = this.GenerateId(invocation));
				}
				invocation.ReturnValue = returnValue;
				return;
			}
			invocation.Proceed();
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00004418 File Offset: 0x00002618
		private string GenerateId(IInvocation invocation)
		{
			object invocationTarget = invocation.InvocationTarget;
			string nonMangledTypeName = this._primaryProxyType.GetNonMangledTypeName();
			int hashCode = invocationTarget.GetHashCode();
			return string.Format(CultureInfo.InvariantCulture, "Substitute.{0}|{1:x8}", new object[]
			{
				nonMangledTypeName,
				hashCode
			});
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000445F File Offset: 0x0000265F
		public static bool IsDefaultToStringMethod(MethodInfo methodInfo)
		{
			return methodInfo.DeclaringType == typeof(object) && string.Equals(methodInfo.Name, "ToString", StringComparison.Ordinal) && methodInfo.GetParameters().Length == 0;
		}

		// Token: 0x04000058 RID: 88
		private readonly Type _primaryProxyType;

		// Token: 0x04000059 RID: 89
		[Nullable(2)]
		private string _cachedProxyId;
	}
}
