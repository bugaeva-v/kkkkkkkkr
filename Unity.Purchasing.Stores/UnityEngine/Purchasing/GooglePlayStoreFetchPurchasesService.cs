using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Uniject;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200002A RID: 42
	[NullableContext(1)]
	[Nullable(0)]
	internal class GooglePlayStoreFetchPurchasesService : IGooglePlayStoreFetchPurchasesService
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x000047B5 File Offset: 0x000029B5
		[Preserve]
		internal GooglePlayStoreFetchPurchasesService(IGooglePlayStoreService googlePlayStoreService, IGooglePlayStoreFinishTransactionService transactionService, IGooglePurchaseConverter purchaseConverter, IUtil util)
		{
			this.m_GooglePlayStoreService = googlePlayStoreService;
			this.m_PurchaseConverter = purchaseConverter;
			this.m_Util = util;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000047D3 File Offset: 0x000029D3
		public void SetProductCache(IProductCache productCache)
		{
			this.m_ProductCache = productCache;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000047DC File Offset: 0x000029DC
		public void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchCallback)
		{
			this.m_FetchCallback = fetchCallback;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000047E5 File Offset: 0x000029E5
		public void FetchPurchases()
		{
			this.m_GooglePlayStoreService.FetchPurchases(new Action<List<IGooglePurchase>>(this.OnPurchasesFetched), new Action<string>(this.PurchaseRetrievalFailedForUnknownReasons));
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000480C File Offset: 0x00002A0C
		public void FetchPurchases(Action<List<Product>> onQueryPurchaseSucceed)
		{
			this.m_GooglePlayStoreService.FetchPurchases(delegate(List<IGooglePurchase> googlePurchases)
			{
				onQueryPurchaseSucceed(this.FillProductsWithPurchases(googlePurchases));
			}, new Action<string>(this.PurchaseRetrievalFailedForUnknownReasons));
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00004850 File Offset: 0x00002A50
		[return: Nullable(2)]
		public IGooglePurchase GetGooglePurchase(string purchaseToken)
		{
			IGooglePurchase purchase = null;
			Func<IGooglePurchase, bool> <>9__1;
			this.m_GooglePlayStoreService.FetchPurchases(delegate(List<IGooglePurchase> googlePurchases)
			{
				Func<IGooglePurchase, bool> predicate;
				if ((predicate = <>9__1) == null)
				{
					predicate = (<>9__1 = ((IGooglePurchase purchases) => purchases.purchaseToken == purchaseToken));
				}
				purchase = googlePurchases.FirstOrDefault(predicate);
			}, new Action<string>(this.PurchaseRetrievalFailedForUnknownReasons));
			return purchase;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000489A File Offset: 0x00002A9A
		private List<Product> FillProductsWithPurchases(IEnumerable<IGooglePurchase> purchases)
		{
			return purchases.SelectMany(new Func<IGooglePurchase, IEnumerable<Product>>(this.BuildProductsFromPurchase)).ToList<Product>();
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000048B4 File Offset: 0x00002AB4
		private IEnumerable<Product> BuildProductsFromPurchase(IGooglePurchase purchase)
		{
			return from product in purchase.skus.Select(delegate(string sku)
			{
				IProductCache productCache = this.m_ProductCache;
				if (productCache == null)
				{
					return null;
				}
				return productCache.Find(sku);
			}).NonNull<Product>()
			select GooglePlayStoreFetchPurchasesService.CompleteProductInfoWithPurchase(product, purchase);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00004907 File Offset: 0x00002B07
		private static Product CompleteProductInfoWithPurchase(Product product, IGooglePurchase purchase)
		{
			return new Product(product.definition, product.metadata, purchase.receipt)
			{
				transactionID = purchase.purchaseToken
			};
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000492C File Offset: 0x00002B2C
		private void OnPurchasesFetched([Nullable(new byte[]
		{
			2,
			1
		})] List<IGooglePurchase> purchases)
		{
			if (purchases == null)
			{
				this.PurchaseRetrievalFailedForUnknownReasons(null);
				return;
			}
			List<Order> orders = (from purchase in purchases
			select this.m_PurchaseConverter.CreateOrderFromPurchase(purchase, this.m_ProductCache)).ToList<Order>();
			IStorePurchaseFetchCallback fetchCallback = this.m_FetchCallback;
			if (fetchCallback != null)
			{
				fetchCallback.OnAllPurchasesRetrieved(orders);
			}
			List<IGooglePurchase> deferredPurchases = purchases.Where(GooglePlayStoreFetchPurchasesService.PurchaseIsPending()).ToList<IGooglePurchase>();
			this.m_Util.RunOnMainThread(delegate
			{
				this.UpdateDeferredProductsByPurchases(deferredPurchases);
			});
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000049A8 File Offset: 0x00002BA8
		[NullableContext(2)]
		private void PurchaseRetrievalFailedForUnknownReasons(string message = null)
		{
			IStorePurchaseFetchCallback fetchCallback = this.m_FetchCallback;
			if (fetchCallback == null)
			{
				return;
			}
			fetchCallback.OnPurchasesRetrievalFailed(new PurchasesFetchFailureDescription(PurchasesFetchFailureReason.Unknown, message ?? string.Empty));
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000049CA File Offset: 0x00002BCA
		private static Func<IGooglePurchase, bool> PurchaseIsPurchased()
		{
			return (IGooglePurchase purchase) => purchase.IsPurchased();
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000049EB File Offset: 0x00002BEB
		private static Func<IGooglePurchase, bool> PurchaseIsPending()
		{
			return (IGooglePurchase purchase) => purchase.IsPending();
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00004A0C File Offset: 0x00002C0C
		private void UpdateDeferredProductsByPurchases(List<IGooglePurchase> deferredPurchases)
		{
			foreach (IGooglePurchase deferredPurchase in deferredPurchases)
			{
				this.UpdateDeferredProductsByPurchase(deferredPurchase);
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00004A5C File Offset: 0x00002C5C
		private void UpdateDeferredProductsByPurchase(IGooglePurchase deferredPurchase)
		{
			foreach (string sku in deferredPurchase.skus)
			{
				this.UpdateDeferredProduct(deferredPurchase, sku);
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00004AB0 File Offset: 0x00002CB0
		private void UpdateDeferredProduct(IGooglePurchase deferredPurchase, string sku)
		{
			IProductCache productCache = this.m_ProductCache;
			Product product = (productCache != null) ? productCache.Find(sku) : null;
			if (product != null)
			{
				product.receipt = deferredPurchase.receipt;
				product.transactionID = deferredPurchase.purchaseToken;
			}
		}

		// Token: 0x04000061 RID: 97
		private readonly IGooglePlayStoreService m_GooglePlayStoreService;

		// Token: 0x04000062 RID: 98
		private readonly IGooglePurchaseConverter m_PurchaseConverter;

		// Token: 0x04000063 RID: 99
		[Nullable(2)]
		private IProductCache m_ProductCache;

		// Token: 0x04000064 RID: 100
		[Nullable(2)]
		private IStorePurchaseFetchCallback m_FetchCallback;

		// Token: 0x04000065 RID: 101
		private IUtil m_Util;
	}
}
