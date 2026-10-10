using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing.Extension
{
	// Token: 0x0200012D RID: 301
	[NullableContext(1)]
	internal interface IStore
	{
		// Token: 0x06000552 RID: 1362
		void Connect();

		// Token: 0x06000553 RID: 1363
		void FetchProducts(IReadOnlyCollection<ProductDefinition> products);

		// Token: 0x06000554 RID: 1364
		void FetchPurchases();

		// Token: 0x06000555 RID: 1365
		void Purchase(ICart cart);

		// Token: 0x06000556 RID: 1366
		void FinishTransaction(PendingOrder pendingOrder);

		// Token: 0x06000557 RID: 1367
		void CheckEntitlement(ProductDefinition product);

		// Token: 0x06000558 RID: 1368
		void SetProductsCallback(IStoreProductsCallback productsCallback);

		// Token: 0x06000559 RID: 1369
		void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchPurchaseCallback);

		// Token: 0x0600055A RID: 1370
		void SetPurchaseCallback(IStorePurchaseCallback purchaseCallback);

		// Token: 0x0600055B RID: 1371
		void SetPurchaseConfirmCallback(IStorePurchaseConfirmCallback confirmCallback);

		// Token: 0x0600055C RID: 1372
		void SetStoreConnectionCallback(IStoreConnectCallback storeConnectCallback);

		// Token: 0x0600055D RID: 1373
		void SetEntitlementCheckCallback(IStoreCheckEntitlementCallback entitlementCallback);

		// Token: 0x0600055E RID: 1374
		void SetOnRevokedEntitlementCallback(IOnEntitlementRevokedCallback entitlementRevokedCallback);
	}
}
