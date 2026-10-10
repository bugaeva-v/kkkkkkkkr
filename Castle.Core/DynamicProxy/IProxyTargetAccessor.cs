using System;

namespace Castle.DynamicProxy
{
	// Token: 0x02000013 RID: 19
	public interface IProxyTargetAccessor
	{
		// Token: 0x06000099 RID: 153
		object DynProxyGetTarget();

		// Token: 0x0600009A RID: 154
		void DynProxySetTarget(object target);

		// Token: 0x0600009B RID: 155
		IInterceptor[] GetInterceptors();
	}
}
