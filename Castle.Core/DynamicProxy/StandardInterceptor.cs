using System;

namespace Castle.DynamicProxy
{
	// Token: 0x0200001B RID: 27
	[Serializable]
	public class StandardInterceptor : MarshalByRefObject, IInterceptor
	{
		// Token: 0x06000121 RID: 289 RVA: 0x000049EA File Offset: 0x00002BEA
		public void Intercept(IInvocation invocation)
		{
			this.PreProceed(invocation);
			this.PerformProceed(invocation);
			this.PostProceed(invocation);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00004A01 File Offset: 0x00002C01
		protected virtual void PerformProceed(IInvocation invocation)
		{
			invocation.Proceed();
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00004A09 File Offset: 0x00002C09
		protected virtual void PreProceed(IInvocation invocation)
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00004A0B File Offset: 0x00002C0B
		protected virtual void PostProceed(IInvocation invocation)
		{
		}
	}
}
