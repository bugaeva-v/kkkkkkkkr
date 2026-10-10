using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000CB RID: 203
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public interface IDetailedStoreListener : IStoreListener
	{
		// Token: 0x060003C4 RID: 964
		void OnPurchaseFailed(Product product, PurchaseFailureDescription failureDescription);
	}
}
