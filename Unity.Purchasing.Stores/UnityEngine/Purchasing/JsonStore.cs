using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Purchasing.Extension;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200003A RID: 58
	[NullableContext(1)]
	[Nullable(0)]
	internal class JsonStore : InternalStore, IUnityCallback
	{
		// Token: 0x06000149 RID: 329 RVA: 0x00005CB7 File Offset: 0x00003EB7
		public void SetNativeStore(INativeStore native)
		{
			this.m_Store = native;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00005CC0 File Offset: 0x00003EC0
		internal JsonStore(ICartValidator cartValidator, ILogger logger, string storeName)
		{
			this.m_CartValidator = cartValidator;
			this.Logger = logger;
			this.m_StoreName = storeName;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00005CE5 File Offset: 0x00003EE5
		public override void FetchProducts(IReadOnlyCollection<ProductDefinition> products)
		{
			INativeStore store = this.m_Store;
			if (store == null)
			{
				return;
			}
			store.FetchProducts(JSONSerializer.SerializeProductDefs(products));
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00005D00 File Offset: 0x00003F00
		internal void ProcessManagedStoreResponse([Nullable(new byte[]
		{
			2,
			1
		})] List<ProductDefinition> storeProducts)
		{
			if (this.m_IsRefreshing)
			{
				this.m_IsRefreshing = false;
				if (storeProducts != null && storeProducts.Count == 0 && this.m_RefreshCallback != null)
				{
					this.m_RefreshCallback();
					this.m_RefreshCallback = null;
					return;
				}
			}
			HashSet<ProductDefinition> hashSet = new HashSet<ProductDefinition>();
			if (storeProducts != null)
			{
				hashSet.UnionWith(storeProducts);
			}
			INativeStore store = this.m_Store;
			if (store == null)
			{
				return;
			}
			store.FetchProducts(JSONSerializer.SerializeProductDefs(hashSet));
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00005D68 File Offset: 0x00003F68
		public override void FetchPurchases()
		{
			INativeStore store = this.m_Store;
			if (store == null)
			{
				return;
			}
			store.FetchExistingPurchases();
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00005D7C File Offset: 0x00003F7C
		public void OnProductsFetchFailed(string jsonFailureDescription)
		{
			ProductFetchFailureDescription failureDescription = JSONSerializer.DeserializeProductFetchFailureDescription(jsonFailureDescription);
			IStoreProductsCallback productsCallback = this.ProductsCallback;
			if (productsCallback == null)
			{
				return;
			}
			productsCallback.OnProductsFetchFailed(failureDescription);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00005DA4 File Offset: 0x00003FA4
		public void OnPurchasesRetrievalFailed(string jsonFailureDescription)
		{
			PurchasesFetchFailureDescription failureReason = JSONSerializer.DeserializePurchasesFetchFailureDescription(jsonFailureDescription);
			IStorePurchaseFetchCallback purchaseFetchCallback = this.PurchaseFetchCallback;
			if (purchaseFetchCallback == null)
			{
				return;
			}
			purchaseFetchCallback.OnPurchasesRetrievalFailed(failureReason);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00005DCC File Offset: 0x00003FCC
		public virtual void OnPurchasesFetched(string json)
		{
			List<ProductDescription> productDescriptions = JSONSerializer.DeserializeProductDescriptions(json);
			List<Order> orders = this.CreateOrdersFromFetchedPurchases(productDescriptions);
			IStorePurchaseFetchCallback purchaseFetchCallback = this.PurchaseFetchCallback;
			if (purchaseFetchCallback == null)
			{
				return;
			}
			purchaseFetchCallback.OnAllPurchasesRetrieved(orders);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00005DFC File Offset: 0x00003FFC
		internal List<Order> CreateOrdersFromFetchedPurchases(List<ProductDescription> productDescriptions)
		{
			List<Order> list = new List<Order>();
			foreach (ProductDescription productDescription in productDescriptions)
			{
				if (productDescription.type == ProductType.Consumable)
				{
					list.Add(this.GeneratePendingOrder(productDescription.storeSpecificId, productDescription.receipt, productDescription.transactionId));
				}
				else
				{
					list.Add(this.GenerateConfirmedOrder(productDescription.storeSpecificId, productDescription.receipt, productDescription.transactionId));
				}
			}
			return list;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00005E90 File Offset: 0x00004090
		public override void Purchase(ICart cart)
		{
			this.m_CartValidator.Validate(cart);
			ProductDefinition definition = cart.Items().First<CartItem>().Product.definition;
			this.Purchase(definition, string.Empty);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00005ECB File Offset: 0x000040CB
		protected virtual void Purchase(ProductDefinition productDefinition, string developerPayload)
		{
			INativeStore store = this.m_Store;
			if (store == null)
			{
				return;
			}
			store.Purchase(JSONSerializer.SerializeProductDef(productDefinition), developerPayload);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00005EE4 File Offset: 0x000040E4
		public override void FinishTransaction(PendingOrder pendingOrder)
		{
			this.m_CartValidator.Validate(pendingOrder.CartOrdered);
			CartItem cartItem = pendingOrder.CartOrdered.Items().FirstOrDefault<CartItem>();
			ProductDefinition productDefinition = (cartItem != null) ? cartItem.Product.definition : null;
			this.FinishTransaction(productDefinition, pendingOrder.Info.TransactionID);
			IStorePurchaseConfirmCallback confirmCallback = this.ConfirmCallback;
			if (confirmCallback == null)
			{
				return;
			}
			confirmCallback.OnConfirmOrderSucceeded(pendingOrder.Info.TransactionID);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00005F54 File Offset: 0x00004154
		protected virtual void FinishTransaction([Nullable(2)] ProductDefinition productDefinition, string transactionId)
		{
			string productJSON = (productDefinition == null) ? null : JSONSerializer.SerializeProductDef(productDefinition);
			INativeStore store = this.m_Store;
			if (store == null)
			{
				return;
			}
			store.FinishTransaction(productJSON, transactionId);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00005F80 File Offset: 0x00004180
		public override void Connect()
		{
			INativeStore store = this.m_Store;
			if (store == null)
			{
				return;
			}
			store.Connect();
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00005F92 File Offset: 0x00004192
		public void OnStoreConnectionSucceeded()
		{
			IStoreConnectCallback connectCallback = this.ConnectCallback;
			if (connectCallback == null)
			{
				return;
			}
			connectCallback.OnStoreConnectionSucceeded();
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00005FA4 File Offset: 0x000041A4
		public void OnStoreConnectionFailed(string jsonFailureDescription)
		{
			StoreConnectionFailureDescription failureDescription = JSONSerializer.DeserializeConnectionFailureDescription(jsonFailureDescription);
			IStoreConnectCallback connectCallback = this.ConnectCallback;
			if (connectCallback == null)
			{
				return;
			}
			connectCallback.OnStoreConnectionFailed(failureDescription);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00005FC9 File Offset: 0x000041C9
		public override void CheckEntitlement(ProductDefinition product)
		{
			INativeStore store = this.m_Store;
			if (store == null)
			{
				return;
			}
			store.CheckEntitlement(JSONSerializer.SerializeProductDef(product));
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00005FE4 File Offset: 0x000041E4
		public virtual void OnProductsFetched(string json)
		{
			List<ProductDescription> products = JSONSerializer.DeserializeProductDescriptions(json);
			IStoreProductsCallback productsCallback = this.ProductsCallback;
			if (productsCallback == null)
			{
				return;
			}
			productsCallback.OnProductsFetched(products);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000600C File Offset: 0x0000420C
		public virtual void OnPurchaseSucceeded(string id, string receipt, string transactionID)
		{
			PendingOrder order = this.GeneratePendingOrder(id, receipt, transactionID);
			IStorePurchaseCallback purchaseCallback = this.PurchaseCallback;
			if (purchaseCallback == null)
			{
				return;
			}
			purchaseCallback.OnPurchaseSucceeded(order);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00006034 File Offset: 0x00004234
		protected DeferredOrder GenerateDeferredOrder(string id, string receipt, string transactionID)
		{
			return new DeferredOrder(new Cart(this.FindProductById(id)), new OrderInfo(receipt, transactionID, this.m_StoreName));
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00006059 File Offset: 0x00004259
		protected PendingOrder GeneratePendingOrder(string id, string receipt, string transactionID)
		{
			return new PendingOrder(new Cart(this.FindProductById(id)), new OrderInfo(receipt, transactionID, this.m_StoreName));
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000607E File Offset: 0x0000427E
		protected ConfirmedOrder GenerateConfirmedOrder(string id, string receipt, string transactionID)
		{
			return new ConfirmedOrder(new Cart(this.FindProductById(id)), new OrderInfo(receipt, transactionID, this.m_StoreName));
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000060A3 File Offset: 0x000042A3
		protected Product FindProductById(string productId)
		{
			return this.ProductCache.FindOrDefault(productId);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000060B4 File Offset: 0x000042B4
		public void OnPurchaseFailed(string json)
		{
			try
			{
				Dictionary<string, object> dic = JSONSerializer.DeserializePurchaseDetails(json);
				string productId = dic.TryGetString("productId");
				string message = dic.TryGetString("verificationError");
				PurchaseFailureReason reason = (PurchaseFailureReason)Convert.ToInt32(dic.TryGetString("reason"));
				PurchaseFailureDescription failure = new PurchaseFailureDescription(this.ProductCache.FindOrDefault(productId), reason, message);
				this.OnPurchaseFailed(failure, null);
			}
			catch
			{
				this.OnPurchaseFailed(new PurchaseFailureDescription(Product.CreateUnknownProduct("Unknown ProductID"), PurchaseFailureReason.Unknown, "Unable to parse purchase failure details"), null);
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00006148 File Offset: 0x00004348
		public void OnPurchaseFailed(PurchaseFailureDescription failure, [Nullable(2)] string json = null)
		{
			this.LastPurchaseFailureDescription = failure;
			this.m_LastPurchaseErrorCode = JsonStore.ParseStoreSpecificPurchaseErrorCode(json);
			IStorePurchaseCallback purchaseCallback = this.PurchaseCallback;
			if (purchaseCallback == null)
			{
				return;
			}
			purchaseCallback.OnPurchaseFailed(failure.ConvertToFailedOrder(""));
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00006178 File Offset: 0x00004378
		public virtual void OnPurchaseDeferred(string productDetails)
		{
			ProductDescription productDescription = JSONSerializer.DeserializeProductDescriptions(productDetails).FirstOrDefault<ProductDescription>();
			if (productDescription != null)
			{
				DeferredOrder deferredOrder = this.GenerateDeferredOrder(productDescription.storeSpecificId, productDescription.receipt, productDescription.transactionId);
				IStorePurchaseCallback purchaseCallback = this.PurchaseCallback;
				if (purchaseCallback == null)
				{
					return;
				}
				purchaseCallback.OnPurchaseDeferred(deferredOrder);
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000061BE File Offset: 0x000043BE
		[NullableContext(2)]
		public PurchaseFailureDescription GetLastPurchaseFailureDescription()
		{
			return this.LastPurchaseFailureDescription;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000061C6 File Offset: 0x000043C6
		public StoreSpecificPurchaseErrorCode GetLastStoreSpecificPurchaseErrorCode()
		{
			return this.m_LastPurchaseErrorCode;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000061D0 File Offset: 0x000043D0
		[NullableContext(2)]
		private static StoreSpecificPurchaseErrorCode ParseStoreSpecificPurchaseErrorCode(string json)
		{
			if (json == null)
			{
				return StoreSpecificPurchaseErrorCode.Unknown;
			}
			Dictionary<string, object> dictionary = MiniJson.JsonDecode(json) as Dictionary<string, object>;
			if (dictionary != null && dictionary.ContainsKey("storeSpecificErrorCode") && Enum.IsDefined(typeof(StoreSpecificPurchaseErrorCode), (string)dictionary["storeSpecificErrorCode"]))
			{
				string value = (string)dictionary["storeSpecificErrorCode"];
				return (StoreSpecificPurchaseErrorCode)Enum.Parse(typeof(StoreSpecificPurchaseErrorCode), value);
			}
			return StoreSpecificPurchaseErrorCode.Unknown;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00006249 File Offset: 0x00004449
		public ConnectionState CheckConnectionState()
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000086 RID: 134
		protected ICartValidator m_CartValidator;

		// Token: 0x04000087 RID: 135
		protected string m_StoreName;

		// Token: 0x04000088 RID: 136
		[Nullable(2)]
		private INativeStore m_Store;

		// Token: 0x04000089 RID: 137
		private bool m_IsRefreshing;

		// Token: 0x0400008A RID: 138
		[Nullable(2)]
		private Action m_RefreshCallback;

		// Token: 0x0400008B RID: 139
		protected readonly ILogger Logger;

		// Token: 0x0400008C RID: 140
		[Nullable(2)]
		private PurchaseFailureDescription LastPurchaseFailureDescription;

		// Token: 0x0400008D RID: 141
		private StoreSpecificPurchaseErrorCode m_LastPurchaseErrorCode = StoreSpecificPurchaseErrorCode.Unknown;

		// Token: 0x0400008E RID: 142
		private const string k_StoreSpecificErrorCodeKey = "storeSpecificErrorCode";
	}
}
