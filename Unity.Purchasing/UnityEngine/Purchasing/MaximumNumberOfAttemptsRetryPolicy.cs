using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200007E RID: 126
	public class MaximumNumberOfAttemptsRetryPolicy : IRetryPolicy
	{
		// Token: 0x06000241 RID: 577 RVA: 0x00006545 File Offset: 0x00004745
		public MaximumNumberOfAttemptsRetryPolicy(int maximumNumberOfAttempts)
		{
			this.m_MaximumNumberOfAttempts = maximumNumberOfAttempts;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00006554 File Offset: 0x00004754
		[NullableContext(1)]
		public virtual Task<bool> ShouldRetry(IRetryPolicyInformation info)
		{
			return Task.FromResult<bool>(info.NumberOfAttempts <= this.m_MaximumNumberOfAttempts);
		}

		// Token: 0x040000B5 RID: 181
		private readonly int m_MaximumNumberOfAttempts;
	}
}
