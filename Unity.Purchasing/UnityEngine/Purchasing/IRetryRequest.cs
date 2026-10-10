using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200007A RID: 122
	[NullableContext(1)]
	internal interface IRetryRequest
	{
		// Token: 0x06000234 RID: 564
		Task<bool> Invoke();

		// Token: 0x06000235 RID: 565
		Task<bool> Retry(IRetryableRequestFailureDescription requestFailureDescription);
	}
}
