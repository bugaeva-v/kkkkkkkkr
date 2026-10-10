using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200007C RID: 124
	[NullableContext(1)]
	[Nullable(0)]
	public class AggregateRetryPolicy : IRetryPolicy
	{
		// Token: 0x06000237 RID: 567 RVA: 0x000063B2 File Offset: 0x000045B2
		public AggregateRetryPolicy(List<IRetryPolicy> retryPolicies)
		{
			this.m_RetryPolicies = retryPolicies;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000063C1 File Offset: 0x000045C1
		public AggregateRetryPolicy(params IRetryPolicy[] retryPolicies)
		{
			this.m_RetryPolicies = new List<IRetryPolicy>(retryPolicies);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000063D8 File Offset: 0x000045D8
		public Task<bool> ShouldRetry(IRetryPolicyInformation info)
		{
			AggregateRetryPolicy.<ShouldRetry>d__3 <ShouldRetry>d__;
			<ShouldRetry>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<ShouldRetry>d__.<>4__this = this;
			<ShouldRetry>d__.info = info;
			<ShouldRetry>d__.<>1__state = -1;
			<ShouldRetry>d__.<>t__builder.Start<AggregateRetryPolicy.<ShouldRetry>d__3>(ref <ShouldRetry>d__);
			return <ShouldRetry>d__.<>t__builder.Task;
		}

		// Token: 0x040000AF RID: 175
		private readonly List<IRetryPolicy> m_RetryPolicies;
	}
}
