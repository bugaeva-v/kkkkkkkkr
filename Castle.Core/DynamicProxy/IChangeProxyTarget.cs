using System;

namespace Castle.DynamicProxy
{
	// Token: 0x02000009 RID: 9
	public interface IChangeProxyTarget
	{
		// Token: 0x06000049 RID: 73
		void ChangeInvocationTarget(object target);

		// Token: 0x0600004A RID: 74
		[Obsolete("Use ((IProxyTargetAccessor)invocation.Proxy).DynProxySetTarget(target) instead.")]
		void ChangeProxyTarget(object target);
	}
}
