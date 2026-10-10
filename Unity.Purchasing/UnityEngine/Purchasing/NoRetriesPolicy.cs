using System;
using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200007F RID: 127
	public class NoRetriesPolicy : IRetryPolicy
	{
		// Token: 0x06000243 RID: 579 RVA: 0x0000656C File Offset: 0x0000476C
		public virtual Task<bool> ShouldRetry(IRetryPolicyInformation info)
		{
			return Task.FromResult<bool>(false);
		}
	}
}
