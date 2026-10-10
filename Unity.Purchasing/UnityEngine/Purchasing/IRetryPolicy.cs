using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000078 RID: 120
	[NullableContext(1)]
	public interface IRetryPolicy
	{
		// Token: 0x06000231 RID: 561
		Task<bool> ShouldRetry(IRetryPolicyInformation info);
	}
}
