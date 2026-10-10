using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000CC RID: 204
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public interface IStoreController
	{
		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060003C5 RID: 965
		ProductCollection products { get; }

		// Token: 0x060003C6 RID: 966
		void InitiatePurchase(Product product, string payload);

		// Token: 0x060003C7 RID: 967
		void InitiatePurchase(string productId, string payload);

		// Token: 0x060003C8 RID: 968
		void InitiatePurchase(Product product);

		// Token: 0x060003C9 RID: 969
		void InitiatePurchase(string productId);

		// Token: 0x060003CA RID: 970
		void FetchAdditionalProducts(HashSet<ProductDefinition> additionalProducts, Action successCallback, Action<InitializationFailureReason, string> failCallback);

		// Token: 0x060003CB RID: 971
		void ConfirmPendingPurchase(Product product);
	}
}
