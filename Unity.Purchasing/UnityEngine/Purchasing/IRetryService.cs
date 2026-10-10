using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200007B RID: 123
	[NullableContext(1)]
	internal interface IRetryService
	{
		// Token: 0x06000236 RID: 566
		IRetryRequest CreateRequest(Action request, IRetryPolicy retryPolicy);
	}
}
