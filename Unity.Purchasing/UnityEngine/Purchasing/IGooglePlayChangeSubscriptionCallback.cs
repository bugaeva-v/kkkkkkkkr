using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000025 RID: 37
	internal interface IGooglePlayChangeSubscriptionCallback : IStorePurchaseCallback
	{
		// Token: 0x0600009A RID: 154
		void OnSubscriptionChangeDeferredUntilRenewal(string storeSpecificId);

		// Token: 0x0600009B RID: 155
		void OnSubscriptionChange(string storeSpecificId);
	}
}
