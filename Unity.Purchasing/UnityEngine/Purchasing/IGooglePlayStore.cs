using System;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000EA RID: 234
	internal interface IGooglePlayStore : IStore
	{
		// Token: 0x06000468 RID: 1128
		void SetChangeSubscriptionCallback(IGooglePlayChangeSubscriptionCallback changeSubscriptionCallback);

		// Token: 0x06000469 RID: 1129
		void ChangeSubscription(ProductDefinition product, Order currentOrder, GooglePlayReplacementMode? desiredReplacementMode);

		// Token: 0x0600046A RID: 1130
		void OnPause(bool isPaused);

		// Token: 0x0600046B RID: 1131
		IGooglePurchase GetGooglePurchase(string purchaseToken);
	}
}
