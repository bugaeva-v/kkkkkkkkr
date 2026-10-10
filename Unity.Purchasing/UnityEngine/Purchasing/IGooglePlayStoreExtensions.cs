using System;
using UnityEngine.Purchasing.Security;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000C8 RID: 200
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public interface IGooglePlayStoreExtensions : IStoreExtension
	{
		// Token: 0x060003BB RID: 955
		void UpgradeDowngradeSubscription(string oldSku, string newSku);

		// Token: 0x060003BC RID: 956
		void UpgradeDowngradeSubscription(string oldSku, string newSku, int desiredProrationMode);

		// Token: 0x060003BD RID: 957
		void UpgradeDowngradeSubscription(string oldSku, string newSku, GooglePlayProrationMode desiredProrationMode);

		// Token: 0x060003BE RID: 958
		void RestoreTransactions(Action<bool, string> callback);

		// Token: 0x060003BF RID: 959
		[Obsolete("No longer functional. This calls launchPriceChangeConfirmationFlow which was removed from Google Play Billing Library 6.0.0")]
		void ConfirmSubscriptionPriceChange(string productId, Action<bool> callback);

		// Token: 0x060003C0 RID: 960
		bool IsPurchasedProductDeferred(Product product);

		// Token: 0x060003C1 RID: 961
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		GooglePurchaseState GetPurchaseState(Product product);

		// Token: 0x060003C2 RID: 962
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		string GetObfuscatedAccountId(Product product);

		// Token: 0x060003C3 RID: 963
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		string GetObfuscatedProfileId(Product product);
	}
}
