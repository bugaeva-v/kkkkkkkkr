using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200002D RID: 45
	internal interface IGooglePlayStoreChangeSubscriptionService
	{
		// Token: 0x060000F0 RID: 240
		void ChangeSubscription(ProductDefinition product, Order currentOrder, GooglePlayReplacementMode? desiredReplacementMode);
	}
}
