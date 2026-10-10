using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing.Extension
{
	// Token: 0x02000130 RID: 304
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class Store : IStore
	{
		// Token: 0x06000577 RID: 1399 RVA: 0x0000BF23 File Offset: 0x0000A123
		protected Store()
		{
			this.ProductCache = new ProductCache();
		}

		// Token: 0x06000578 RID: 1400
		public abstract void Connect();

		// Token: 0x06000579 RID: 1401
		public abstract void FetchProducts(IReadOnlyCollection<ProductDefinition> products);

		// Token: 0x0600057A RID: 1402
		public abstract void FetchPurchases();

		// Token: 0x0600057B RID: 1403
		public abstract void Purchase(ICart cart);

		// Token: 0x0600057C RID: 1404
		public abstract void FinishTransaction(PendingOrder pendingOrder);

		// Token: 0x0600057D RID: 1405
		public abstract void CheckEntitlement(ProductDefinition product);

		// Token: 0x0600057E RID: 1406 RVA: 0x0000BF36 File Offset: 0x0000A136
		public virtual void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchPurchaseCallback)
		{
			this.PurchaseFetchCallback = fetchPurchaseCallback;
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0000BF3F File Offset: 0x0000A13F
		public virtual void SetPurchaseCallback(IStorePurchaseCallback purchaseCallback)
		{
			this.PurchaseCallback = purchaseCallback;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0000BF48 File Offset: 0x0000A148
		public virtual void SetPurchaseConfirmCallback(IStorePurchaseConfirmCallback confirmCallback)
		{
			this.ConfirmCallback = confirmCallback;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0000BF51 File Offset: 0x0000A151
		public virtual void SetStoreConnectionCallback(IStoreConnectCallback storeConnectCallback)
		{
			this.ConnectCallback = storeConnectCallback;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0000BF5A File Offset: 0x0000A15A
		public virtual void SetProductsCallback(IStoreProductsCallback productsCallback)
		{
			this.ProductsCallback = productsCallback;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0000BF63 File Offset: 0x0000A163
		public virtual void SetEntitlementCheckCallback(IStoreCheckEntitlementCallback entitlementCallback)
		{
			this.EntitlementCallback = entitlementCallback;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0000BF6C File Offset: 0x0000A16C
		public virtual void SetOnRevokedEntitlementCallback(IOnEntitlementRevokedCallback entitlementRevokedCallback)
		{
			this.EntitlementRevokedCallback = entitlementRevokedCallback;
		}

		// Token: 0x0400027D RID: 637
		[Nullable(2)]
		protected IStoreProductsCallback ProductsCallback;

		// Token: 0x0400027E RID: 638
		[Nullable(2)]
		protected IStorePurchaseFetchCallback PurchaseFetchCallback;

		// Token: 0x0400027F RID: 639
		[Nullable(2)]
		protected IStorePurchaseCallback PurchaseCallback;

		// Token: 0x04000280 RID: 640
		[Nullable(2)]
		protected IStorePurchaseConfirmCallback ConfirmCallback;

		// Token: 0x04000281 RID: 641
		[Nullable(2)]
		protected IStoreCheckEntitlementCallback EntitlementCallback;

		// Token: 0x04000282 RID: 642
		[Nullable(2)]
		protected IStoreConnectCallback ConnectCallback;

		// Token: 0x04000283 RID: 643
		[Nullable(2)]
		protected IOnEntitlementRevokedCallback EntitlementRevokedCallback;

		// Token: 0x04000284 RID: 644
		internal IProductCache ProductCache;
	}
}
