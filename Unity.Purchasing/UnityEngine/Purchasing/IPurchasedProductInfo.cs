using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000056 RID: 86
	[NullableContext(1)]
	public interface IPurchasedProductInfo
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600016C RID: 364
		string productId { get; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600016D RID: 365
		[Nullable(2)]
		SubscriptionInfo subscriptionInfo { [NullableContext(2)] get; }
	}
}
