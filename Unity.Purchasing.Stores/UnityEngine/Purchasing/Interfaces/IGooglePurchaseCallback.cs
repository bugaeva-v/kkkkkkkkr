using System;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing.Interfaces
{
	// Token: 0x0200005C RID: 92
	internal interface IGooglePurchaseCallback
	{
		// Token: 0x06000237 RID: 567
		void SetProductCache(IProductCache productCache);

		// Token: 0x06000238 RID: 568
		void SetPurchaseCallback(IStorePurchaseCallback purchaseCallback);

		// Token: 0x06000239 RID: 569
		void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchCallback);

		// Token: 0x0600023A RID: 570
		void SetChangeSubscriptionCallback(IGooglePlayChangeSubscriptionCallback changeSubscriptionCallback);

		// Token: 0x0600023B RID: 571
		void OnPurchaseSuccessful(IGooglePurchase purchase);

		// Token: 0x0600023C RID: 572
		void OnPurchaseFailed(PurchaseFailureDescription purchaseFailureDescription);

		// Token: 0x0600023D RID: 573
		void NotifyDeferredPurchase(IGooglePurchase purchase);

		// Token: 0x0600023E RID: 574
		void NotifyDeferredProrationUpgradeDowngradeSubscription(string sku);

		// Token: 0x0600023F RID: 575
		void NotifyUpgradeDowngradeSubscription(string sku);
	}
}
