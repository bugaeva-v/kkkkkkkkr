using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000D RID: 13
	public interface IAppleStoreExtendedProductService : IProductServiceExtension
	{
		// Token: 0x0600002B RID: 43
		void FetchStorePromotionOrder(Action<List<Product>> successCallback, Action<string> errorCallback);

		// Token: 0x0600002C RID: 44
		void SetStorePromotionOrder(List<Product> products);

		// Token: 0x0600002D RID: 45
		void FetchStorePromotionVisibility(Product product, Action<string, AppleStorePromotionVisibility> successCallback, Action<string> errorCallback);

		// Token: 0x0600002E RID: 46
		void SetStorePromotionVisibility(Product product, AppleStorePromotionVisibility visible);

		// Token: 0x0600002F RID: 47
		Dictionary<string, string> GetIntroductoryPriceDictionary();

		// Token: 0x06000030 RID: 48
		Dictionary<string, string> GetProductDetails();
	}
}
