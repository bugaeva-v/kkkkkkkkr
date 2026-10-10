using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000C6 RID: 198
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public interface IAppleExtensions : IStoreExtension
	{
		// Token: 0x060003AB RID: 939
		void RefreshAppReceipt(Action<string> successCallback, Action<string> errorCallback);

		// Token: 0x060003AC RID: 940
		string GetTransactionReceiptForProduct(Product product);

		// Token: 0x060003AD RID: 941
		void RestoreTransactions(Action<bool, string> callback);

		// Token: 0x060003AE RID: 942
		void RegisterPurchaseDeferredListener(Action<Product> callback);

		// Token: 0x060003AF RID: 943
		void SetApplicationUsername(string applicationUsername);

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060003B0 RID: 944
		// (set) Token: 0x060003B1 RID: 945
		bool simulateAskToBuy { get; set; }

		// Token: 0x060003B2 RID: 946
		void FetchStorePromotionOrder(Action<List<Product>> successCallback, Action errorCallback);

		// Token: 0x060003B3 RID: 947
		void SetStorePromotionOrder(List<Product> products);

		// Token: 0x060003B4 RID: 948
		void FetchStorePromotionVisibility(Product product, Action<string, AppleStorePromotionVisibility> successCallback, Action errorCallback);

		// Token: 0x060003B5 RID: 949
		void SetStorePromotionVisibility(Product product, AppleStorePromotionVisibility visible);

		// Token: 0x060003B6 RID: 950
		void ContinuePromotionalPurchases();

		// Token: 0x060003B7 RID: 951
		Dictionary<string, string> GetIntroductoryPriceDictionary();

		// Token: 0x060003B8 RID: 952
		Dictionary<string, string> GetProductDetails();

		// Token: 0x060003B9 RID: 953
		void PresentCodeRedemptionSheet();
	}
}
