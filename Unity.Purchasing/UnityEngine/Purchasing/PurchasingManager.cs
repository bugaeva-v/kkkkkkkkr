using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000D1 RID: 209
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	internal class PurchasingManager : IStoreController
	{
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060003DB RID: 987 RVA: 0x00009050 File Offset: 0x00007250
		// (set) Token: 0x060003DC RID: 988 RVA: 0x00009058 File Offset: 0x00007258
		public bool useTransactionLog { get; set; }

		// Token: 0x060003DD RID: 989 RVA: 0x00009064 File Offset: 0x00007264
		public PurchasingManager()
		{
			this.m_StoreController.OnPurchaseFailed += PurchasingManager.OnPurchaseFailedAction;
			this.m_StoreController.OnPurchasePending += this.OnPurchasePendingAction;
			this.m_StoreController.OnPurchaseConfirmed += this.OnPurchaseConfirmedAction;
			this.m_StoreController.OnPurchasesFetched += this.OnPurchasesFetchedAction;
			AppStore defaultBuiltInAppStore = DefaultStoreHelper.GetDefaultBuiltInAppStore();
			if (defaultBuiltInAppStore == AppStore.AppleAppStore || defaultBuiltInAppStore == AppStore.MacAppStore)
			{
				IAppleStoreExtendedPurchaseService apple = UnityIAPServices.DefaultPurchase().Apple;
				if (apple != null)
				{
					apple.SetRefreshAppReceipt(true);
				}
			}
			this.useTransactionLog = true;
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060003DE RID: 990 RVA: 0x00009125 File Offset: 0x00007325
		public ProductCollection products { get; } = new ProductCollection();

		// Token: 0x060003DF RID: 991 RVA: 0x0000912D File Offset: 0x0000732D
		public void InitiatePurchase(Product product, string payload)
		{
			this.InitiatePurchase(product.definition.id);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00009140 File Offset: 0x00007340
		public void InitiatePurchase(string productId, string payload)
		{
			this.InitiatePurchase(productId);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00009149 File Offset: 0x00007349
		public void InitiatePurchase(Product product)
		{
			this.InitiatePurchase(product.definition.id);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0000915C File Offset: 0x0000735C
		public void InitiatePurchase(string productId)
		{
			this.m_StoreController.Purchase(this.CreateCart(productId));
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00009170 File Offset: 0x00007370
		private static void OnPurchaseFailedAction(FailedOrder failedOrder)
		{
			IStoreListener storeListener = UnityPurchasing.m_StoreListener;
			if (storeListener == null)
			{
				return;
			}
			CartItem cartItem = failedOrder.CartOrdered.Items().FirstOrDefault<CartItem>();
			storeListener.OnPurchaseFailed((cartItem != null) ? cartItem.Product : null, failedOrder.FailureReason);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x000091A4 File Offset: 0x000073A4
		private void OnPurchasePendingAction(PendingOrder pendingOrder)
		{
			PurchasingManager.<>c__DisplayClass15_0 CS$<>8__locals1 = new PurchasingManager.<>c__DisplayClass15_0();
			PurchasingManager.<>c__DisplayClass15_0 CS$<>8__locals2 = CS$<>8__locals1;
			CartItem cartItem = pendingOrder.CartOrdered.Items().FirstOrDefault<CartItem>();
			CS$<>8__locals2.product = ((cartItem != null) ? cartItem.Product : null);
			if (CS$<>8__locals1.product != null)
			{
				CS$<>8__locals1.product.transactionID = pendingOrder.Info.TransactionID;
				CS$<>8__locals1.product.receipt = pendingOrder.Info.Receipt;
				Product product = CS$<>8__locals1.product;
				IAppleOrderInfo apple = pendingOrder.Info.Apple;
				product.appleOriginalTransactionID = ((apple != null) ? apple.OriginalTransactionID : null);
				Product product2 = this.m_StoreController.GetProducts().FirstOrDefault((Product p) => p.definition.id == CS$<>8__locals1.product.definition.id);
				if (product2 != null)
				{
					product2.transactionID = pendingOrder.Info.TransactionID;
					product2.receipt = pendingOrder.Info.Receipt;
					Product product3 = product2;
					IAppleOrderInfo apple2 = pendingOrder.Info.Apple;
					product3.appleOriginalTransactionID = ((apple2 != null) ? apple2.OriginalTransactionID : null);
				}
				this.InvokeProcessPurchase(CS$<>8__locals1.product, pendingOrder);
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x000092A0 File Offset: 0x000074A0
		private void OnPurchaseConfirmedAction(Order order)
		{
			PurchasingManager.<>c__DisplayClass16_0 CS$<>8__locals1 = new PurchasingManager.<>c__DisplayClass16_0();
			ConfirmedOrder confirmedOrder = order as ConfirmedOrder;
			if (confirmedOrder == null)
			{
				return;
			}
			PurchasingManager.<>c__DisplayClass16_0 CS$<>8__locals2 = CS$<>8__locals1;
			CartItem cartItem = confirmedOrder.CartOrdered.Items().FirstOrDefault<CartItem>();
			CS$<>8__locals2.product = ((cartItem != null) ? cartItem.Product : null);
			if (CS$<>8__locals1.product != null && CS$<>8__locals1.product.definition.type == ProductType.Consumable)
			{
				CS$<>8__locals1.product.receipt = null;
				CS$<>8__locals1.product.transactionID = null;
				CS$<>8__locals1.product.appleOriginalTransactionID = null;
				Product product = this.m_StoreController.GetProducts().FirstOrDefault((Product p) => p.definition.id == CS$<>8__locals1.product.definition.id);
				if (product != null)
				{
					product.receipt = null;
					product.transactionID = null;
					product.appleOriginalTransactionID = null;
				}
			}
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00009354 File Offset: 0x00007554
		private void OnPurchasesFetchedAction(Orders orders)
		{
			foreach (PendingOrder pendingOrder in orders.PendingOrders)
			{
				foreach (CartItem cartItem in pendingOrder.CartOrdered.Items())
				{
					Product product = cartItem.Product;
					product.receipt = pendingOrder.Info.Receipt;
					product.transactionID = pendingOrder.Info.TransactionID;
					Product product7 = product;
					IAppleOrderInfo apple = pendingOrder.Info.Apple;
					product7.appleOriginalTransactionID = ((apple != null) ? apple.OriginalTransactionID : null);
					Product product2 = this.m_StoreController.GetProducts().FirstOrDefault((Product p) => p.definition.id == product.definition.id);
					if (product2 != null)
					{
						product2.receipt = pendingOrder.Info.Receipt;
						product2.transactionID = pendingOrder.Info.TransactionID;
						Product product3 = product2;
						IAppleOrderInfo apple2 = pendingOrder.Info.Apple;
						product3.appleOriginalTransactionID = ((apple2 != null) ? apple2.OriginalTransactionID : null);
					}
				}
			}
			foreach (ConfirmedOrder confirmedOrder in orders.ConfirmedOrders)
			{
				foreach (CartItem cartItem2 in confirmedOrder.CartOrdered.Items())
				{
					Product product = cartItem2.Product;
					product.receipt = confirmedOrder.Info.Receipt;
					product.transactionID = confirmedOrder.Info.TransactionID;
					Product product4 = product;
					IAppleOrderInfo apple3 = confirmedOrder.Info.Apple;
					product4.appleOriginalTransactionID = ((apple3 != null) ? apple3.OriginalTransactionID : null);
					Product product5 = this.m_StoreController.GetProducts().FirstOrDefault((Product p) => p.definition.id == product.definition.id);
					if (product5 != null)
					{
						product5.receipt = confirmedOrder.Info.Receipt;
						product5.transactionID = confirmedOrder.Info.TransactionID;
						Product product6 = product5;
						IAppleOrderInfo apple4 = confirmedOrder.Info.Apple;
						product6.appleOriginalTransactionID = ((apple4 != null) ? apple4.OriginalTransactionID : null);
					}
					this.InvokeProcessPurchase(product, confirmedOrder);
				}
			}
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00009640 File Offset: 0x00007840
		private void InvokeProcessPurchase(Product product, Order order)
		{
			if (order is ConfirmedOrder && this.HasRecordedTransaction(product.transactionID))
			{
				return;
			}
			IStoreListener storeListener = UnityPurchasing.m_StoreListener;
			PurchaseProcessingResult? purchaseProcessingResult = (storeListener != null) ? new PurchaseProcessingResult?(storeListener.ProcessPurchase(new PurchaseEventArgs(product))) : null;
			PurchaseProcessingResult purchaseProcessingResult2 = PurchaseProcessingResult.Complete;
			if (purchaseProcessingResult.GetValueOrDefault() == purchaseProcessingResult2 & purchaseProcessingResult != null)
			{
				if (order is PendingOrder)
				{
					this.ConfirmPendingPurchase(product);
					return;
				}
				if (this.useTransactionLog)
				{
					this.m_TransactionLog.Record(product.transactionID);
				}
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x000096C8 File Offset: 0x000078C8
		private ICart CreateCart(string productId)
		{
			return new Cart(new CartItem(this.FindProductByProductId(productId)));
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x000096DC File Offset: 0x000078DC
		private Product FindProductByProductId(string productId)
		{
			return this.m_StoreController.GetProducts().FirstOrDefault((Product product) => product.definition.id == productId);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00009714 File Offset: 0x00007914
		public void FetchAdditionalProducts(HashSet<ProductDefinition> additionalProducts, Action successCallback, Action<InitializationFailureReason, string> failCallback)
		{
			Action<List<Product>> onFetched = null;
			Action<ProductFetchFailed> onFailed = null;
			onFetched = delegate(List<Product> _)
			{
				this.m_StoreController.OnProductsFetched -= onFetched;
				this.m_StoreController.OnProductsFetchFailed -= onFailed;
				successCallback();
			};
			onFailed = delegate(ProductFetchFailed failed)
			{
				this.m_StoreController.OnProductsFetched -= onFetched;
				this.m_StoreController.OnProductsFetchFailed -= onFailed;
				failCallback(InitializationFailureReason.NoProductsAvailable, failed.FailureReason);
			};
			this.m_StoreController.OnProductsFetched += onFetched;
			this.m_StoreController.OnProductsFetchFailed += onFailed;
			this.m_StoreController.FetchProductsWithNoRetries(new List<ProductDefinition>(additionalProducts));
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x000097A1 File Offset: 0x000079A1
		public void ConfirmPendingPurchase(Product product)
		{
			this.m_StoreController.ConfirmPurchase(PurchasingManager.CreatePendingOrderFromProduct(product));
			if (this.useTransactionLog)
			{
				this.m_TransactionLog.Record(product.transactionID);
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x000097D0 File Offset: 0x000079D0
		private static PendingOrder CreatePendingOrderFromProduct(Product product)
		{
			foreach (Order order in PurchaseServiceProvider.GetDefaultPurchaseService().GetPurchases())
			{
				PendingOrder pendingOrder = order as PendingOrder;
				if (pendingOrder != null)
				{
					CartItem cartItem = pendingOrder.CartOrdered.Items().FirstOrDefault<CartItem>();
					if (cartItem != null && cartItem.Product.definition.storeSpecificId == product.definition.storeSpecificId)
					{
						return pendingOrder;
					}
				}
			}
			Debug.LogWarning("No pending order found for product " + product.definition.id + ". Returning a new PendingOrder with empty OrderInfo.");
			return new PendingOrder(new Cart(new CartItem(product)), new OrderInfo(string.Empty, string.Empty, string.Empty));
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x000098A4 File Offset: 0x00007AA4
		private bool HasRecordedTransaction(string transactionId)
		{
			return this.useTransactionLog && this.m_TransactionLog.HasRecordOf(transactionId);
		}

		// Token: 0x0400017E RID: 382
		private readonly ITransactionLog m_TransactionLog = new TransactionLog(Application.persistentDataPath);

		// Token: 0x0400017F RID: 383
		private StoreController m_StoreController = new StoreController(null);
	}
}
