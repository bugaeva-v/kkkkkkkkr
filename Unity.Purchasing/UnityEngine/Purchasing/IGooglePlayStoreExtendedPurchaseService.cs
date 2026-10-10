using System;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Security;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000020 RID: 32
	[NullableContext(1)]
	public interface IGooglePlayStoreExtendedPurchaseService : IPurchaseServiceExtension
	{
		// Token: 0x06000089 RID: 137
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		void UpgradeDowngradeSubscription(Product oldProduct, Product newProduct);

		// Token: 0x0600008A RID: 138
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		void UpgradeDowngradeSubscription(Product oldProduct, Product newProduct, GooglePlayProrationMode desiredProrationMode);

		// Token: 0x0600008B RID: 139
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		void UpgradeDowngradeSubscription(Product oldProduct, Product newProduct, GooglePlayReplacementMode desiredReplacementMode);

		// Token: 0x0600008C RID: 140
		void UpgradeDowngradeSubscription(Order currentOrder, Product newProduct, GooglePlayReplacementMode desiredReplacementMode);

		// Token: 0x0600008D RID: 141
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		bool IsOrderDeferred(Order order);

		// Token: 0x0600008E RID: 142
		[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
		GooglePurchaseState? GetPurchaseState(Order order);

		// Token: 0x0600008F RID: 143
		[return: Nullable(2)]
		string GetObfuscatedAccountId(Order order);

		// Token: 0x06000090 RID: 144
		[return: Nullable(2)]
		string GetObfuscatedProfileId(Order order);

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000091 RID: 145
		// (remove) Token: 0x06000092 RID: 146
		event Action<DeferredPaymentUntilRenewalDateOrder> OnDeferredPaymentUntilRenewalDate;
	}
}
