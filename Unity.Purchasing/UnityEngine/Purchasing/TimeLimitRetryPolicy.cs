using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000080 RID: 128
	public class TimeLimitRetryPolicy : IRetryPolicy
	{
		// Token: 0x06000245 RID: 581 RVA: 0x0000657C File Offset: 0x0000477C
		public TimeLimitRetryPolicy(float timeLimit)
		{
			this.m_TimeLimit = timeLimit;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000658B File Offset: 0x0000478B
		[NullableContext(1)]
		public virtual Task<bool> ShouldRetry(IRetryPolicyInformation info)
		{
			return Task.FromResult<bool>(info.TimeSinceFirstAttempt <= this.m_TimeLimit);
		}

		// Token: 0x040000B6 RID: 182
		private readonly float m_TimeLimit;
	}
}
