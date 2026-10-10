using System;
using System.ComponentModel;
using System.Reflection;

namespace Castle.DynamicProxy.Internal
{
	// Token: 0x0200002A RID: 42
	public static class InternalsUtil
	{
		// Token: 0x0600015E RID: 350 RVA: 0x000058DA File Offset: 0x00003ADA
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete]
		public static bool IsInternal(this MethodBase method)
		{
			return ProxyUtil.IsInternal(method);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000058E2 File Offset: 0x00003AE2
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete]
		public static bool IsInternalToDynamicProxy(this Assembly asm)
		{
			return ProxyUtil.AreInternalsVisibleToDynamicProxy(asm);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000058EA File Offset: 0x00003AEA
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use ProxyUtil.IsAccessible instead, which performs a more accurate accessibility check.")]
		public static bool IsAccessible(this MethodBase method)
		{
			return ProxyUtil.IsAccessibleMethod(method);
		}
	}
}
