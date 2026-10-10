using System;
using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000030 RID: 48
	internal interface IGooglePlayStoreFetchPurchasesService
	{
		// Token: 0x060000F7 RID: 247
		void SetProductCache(IProductCache productCache);

		// Token: 0x060000F8 RID: 248
		void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchCallback);

		// Token: 0x060000F9 RID: 249
		void FetchPurchases();

		// Token: 0x060000FA RID: 250
		void FetchPurchases(Action<List<Product>> onQueryPurchaseSucceed);

		// Token: 0x060000FB RID: 251
		IGooglePurchase GetGooglePurchase(string purchaseToken);
	}
}
