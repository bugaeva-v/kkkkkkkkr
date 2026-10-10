using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000046 RID: 70
	internal class FakeStore : JsonStore, INativeStore
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00006EFD File Offset: 0x000050FD
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00006F05 File Offset: 0x00005105
		public string unavailableProductId { get; set; }

		// Token: 0x060001A6 RID: 422 RVA: 0x00006F0E File Offset: 0x0000510E
		public FakeStore(ICartValidator cartValidator, ILogger logger) : base(cartValidator, logger, "fake")
		{
			base.SetNativeStore(this);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00006F2F File Offset: 0x0000512F
		public override void Connect()
		{
			base.OnStoreConnectionSucceeded();
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00006F38 File Offset: 0x00005138
		public void FetchProducts(string json)
		{
			List<ProductDefinition> source = ((List<object>)MiniJson.JsonDecode(json)).DecodeJSON("fake");
			this.StoreFetchProducts(new ReadOnlyCollection<ProductDefinition>(source.ToList<ProductDefinition>()));
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00006F6C File Offset: 0x0000516C
		public void StoreFetchProducts(ReadOnlyCollection<ProductDefinition> productDefinitions)
		{
			FakeStore.<>c__DisplayClass13_0 CS$<>8__locals1 = new FakeStore.<>c__DisplayClass13_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.products = new List<ProductDescription>();
			foreach (ProductDefinition productDefinition in productDefinitions)
			{
				if (this.unavailableProductId != productDefinition.id)
				{
					CS$<>8__locals1.products.Add(new ProductDescription(productDefinition.storeSpecificId, this.GetOrCreateProductMetadata(productDefinition.id)));
				}
			}
			if (this.UIMode != FakeStoreUIMode.DeveloperUser || !this.StartUI<ProductFetchFailureReason>(productDefinitions, FakeStore.DialogType.FetchProducts, new Action<bool, ProductFetchFailureReason>(CS$<>8__locals1.<StoreFetchProducts>g__handleAllowInitializeOrFetchProducts|0)))
			{
				IStoreProductsCallback productsCallback = this.ProductsCallback;
				if (productsCallback == null)
				{
					return;
				}
				productsCallback.OnProductsFetched(CS$<>8__locals1.products);
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00007034 File Offset: 0x00005234
		private ProductMetadata GetOrCreateProductMetadata(string productId)
		{
			ProductMetadata result = new ProductMetadata("$0.01", "Fake title for " + productId, "Fake description", "USD", 0.01m);
			ProductCatalog productCatalog = ProductCatalog.LoadDefaultCatalog();
			if (productCatalog != null)
			{
				foreach (ProductCatalogItem productCatalogItem in productCatalog.allProducts)
				{
					if (productCatalogItem.id == productId)
					{
						result = new ProductMetadata(productCatalogItem.googlePrice.value.ToString(), productCatalogItem.defaultDescription.Title, productCatalogItem.defaultDescription.Description, "USD", productCatalogItem.googlePrice.value);
					}
				}
			}
			return result;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000070F8 File Offset: 0x000052F8
		public void FetchExistingPurchases()
		{
			IStorePurchaseFetchCallback purchaseFetchCallback = this.PurchaseFetchCallback;
			if (purchaseFetchCallback == null)
			{
				return;
			}
			purchaseFetchCallback.OnAllPurchasesRetrieved(this.m_ConfirmedOrders);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00007110 File Offset: 0x00005310
		public void Purchase(string productJson, string optionsJson)
		{
			this.FakePurchase(this.ParseProductDefinition(productJson), optionsJson);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00007120 File Offset: 0x00005320
		private ProductDefinition ParseProductDefinition(string productJSON)
		{
			Dictionary<string, object> dictionary = (Dictionary<string, object>)MiniJson.JsonDecode(productJSON);
			object obj;
			dictionary.TryGetValue("id", out obj);
			string id = obj.ToString();
			dictionary.TryGetValue("storeSpecificId", out obj);
			string storeSpecificId = obj.ToString();
			return new ProductDefinition(id, storeSpecificId, this.ParseProductType(dictionary));
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00007170 File Offset: 0x00005370
		private ProductType ParseProductType(Dictionary<string, object> dictionary)
		{
			object obj;
			dictionary.TryGetValue("type", out obj);
			string value = obj.ToString();
			if (!Enum.IsDefined(typeof(ProductType), value))
			{
				return ProductType.Consumable;
			}
			return (ProductType)Enum.Parse(typeof(ProductType), value);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000071BC File Offset: 0x000053BC
		private void FakePurchase(ProductDefinition productDefinition, string developerPayload)
		{
			FakeStore.<>c__DisplayClass19_0 CS$<>8__locals1 = new FakeStore.<>c__DisplayClass19_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.productDefinition = productDefinition;
			if (CS$<>8__locals1.productDefinition.type != ProductType.Consumable)
			{
				ConfirmedOrder item = new ConfirmedOrder(new Cart(new Product(CS$<>8__locals1.productDefinition, this.GetOrCreateProductMetadata(CS$<>8__locals1.productDefinition.id))), new OrderInfo("", "", ""));
				this.m_ConfirmedOrders.Add(item);
			}
			if (!this.StartUI<PurchaseFailureReason>(CS$<>8__locals1.productDefinition, FakeStore.DialogType.Purchase, new Action<bool, PurchaseFailureReason>(CS$<>8__locals1.<FakePurchase>g__handleAllowPurchase|0)))
			{
				CS$<>8__locals1.<FakePurchase>g__handleAllowPurchase|0(true, (PurchaseFailureReason)Enum.Parse(typeof(PurchaseFailureReason), "Unknown"));
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00007274 File Offset: 0x00005474
		public bool CheckEntitlement(string productJSON)
		{
			ProductDefinition productDefinition = this.ParseProductDefinition(productJSON);
			bool flag = this.CheckIfProductEntitled(productDefinition);
			EntitlementStatus status = flag ? EntitlementStatus.FullyEntitled : EntitlementStatus.NotEntitled;
			IStoreCheckEntitlementCallback entitlementCallback = this.EntitlementCallback;
			if (entitlementCallback == null)
			{
				return flag;
			}
			entitlementCallback.OnCheckEntitlement(productDefinition, status, null);
			return flag;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000072AC File Offset: 0x000054AC
		private bool CheckIfProductEntitled(ProductDefinition definition)
		{
			return (from item in this.m_ConfirmedOrders.SelectMany((ConfirmedOrder order) => order.CartOrdered.Items())
			select item.Product).Any((Product product) => product.definition.id == definition.id);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00007328 File Offset: 0x00005528
		public void RestoreTransactions(Action<bool, string> callback)
		{
			foreach (ConfirmedOrder confirmedOrder in this.m_ConfirmedOrders)
			{
				PendingOrder order = new PendingOrder(confirmedOrder.CartOrdered, confirmedOrder.Info);
				IStorePurchaseCallback purchaseCallback = this.PurchaseCallback;
				if (purchaseCallback != null)
				{
					purchaseCallback.OnPurchaseSucceeded(order);
				}
			}
			if (callback != null)
			{
				callback(true, null);
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000073A4 File Offset: 0x000055A4
		public void FinishTransaction(string productJSON, string transactionID)
		{
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000073A6 File Offset: 0x000055A6
		protected virtual bool StartUI<T>(object model, FakeStore.DialogType dialogType, Action<bool, T> callback) where T : Enum
		{
			return false;
		}

		// Token: 0x040000A2 RID: 162
		public const string Name = "fake";

		// Token: 0x040000A3 RID: 163
		private readonly List<ConfirmedOrder> m_ConfirmedOrders = new List<ConfirmedOrder>();

		// Token: 0x040000A5 RID: 165
		public FakeStoreUIMode UIMode;

		// Token: 0x040000A6 RID: 166
		public bool purchaseCalled;

		// Token: 0x040000A7 RID: 167
		public bool restoreCalled;

		// Token: 0x0200009F RID: 159
		protected enum DialogType
		{
			// Token: 0x040001AF RID: 431
			Purchase,
			// Token: 0x040001B0 RID: 432
			FetchProducts
		}
	}
}
