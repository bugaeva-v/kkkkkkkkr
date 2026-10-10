using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000026 RID: 38
	[NullableContext(1)]
	internal interface IGooglePlayChangeSubscriptionUseCase
	{
		// Token: 0x0600009C RID: 156
		void ChangeSubscription(Order currentOrder, Product newSubscription, GooglePlayReplacementMode replacementMode);

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600009D RID: 157
		// (remove) Token: 0x0600009E RID: 158
		[Nullable(new byte[]
		{
			2,
			1
		})]
		event Action<DeferredPaymentUntilRenewalDateOrder> OnDeferredPaymentUntilRenewalDate;
	}
}
