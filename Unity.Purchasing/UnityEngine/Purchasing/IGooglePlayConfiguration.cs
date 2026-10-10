using System;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000C1 RID: 193
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public interface IGooglePlayConfiguration : IStoreConfiguration
	{
		// Token: 0x06000381 RID: 897
		void SetServiceDisconnectAtInitializeListener(Action action);

		// Token: 0x06000382 RID: 898
		void SetQueryProductDetailsFailedListener(Action<int> action);

		// Token: 0x06000383 RID: 899
		void SetDeferredPurchaseListener(Action<Product> action);

		// Token: 0x06000384 RID: 900
		void SetDeferredProrationUpgradeDowngradeSubscriptionListener(Action<Product> action);

		// Token: 0x06000385 RID: 901
		void SetObfuscatedAccountId(string accountId);

		// Token: 0x06000386 RID: 902
		void SetObfuscatedProfileId(string profileId);

		// Token: 0x06000387 RID: 903
		void SetFetchPurchasesAtInitialize(bool enable);

		// Token: 0x06000388 RID: 904
		void SetFetchPurchasesExcludeDeferred(bool exclude);
	}
}
