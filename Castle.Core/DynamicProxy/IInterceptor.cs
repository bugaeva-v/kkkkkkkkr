using System;

namespace Castle.DynamicProxy
{
	// Token: 0x0200000A RID: 10
	public interface IInterceptor
	{
		// Token: 0x0600004B RID: 75
		void Intercept(IInvocation invocation);
	}
}
