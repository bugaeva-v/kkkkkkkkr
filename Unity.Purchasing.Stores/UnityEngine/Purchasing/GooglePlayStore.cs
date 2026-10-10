using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Purchasing.Extension;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000023 RID: 35
	[NullableContext(1)]
	[Nullable(0)]
	internal class GooglePlayStore : InternalStore, IGooglePlayStore, IStore
	{
		// Token: 0x060000AA RID: 170 RVA: 0x00004260 File Offset: 0x00002460
		[Preserve]
		internal GooglePlayStore(IGooglePlayStoreFetchProductsService fetchProductsService, IGooglePlayStorePurchaseService storePurchaseService, IGooglePlayStoreFetchPurchasesService playStoreFetchPurchasesService, IGooglePlayStoreFinishTransactionService transactionService, IGooglePlayStoreChangeSubscriptionService changeSubscriptionService, IGooglePlayStoreCheckEntitlementService checkEntitlementsService, IGooglePurchaseCallback googlePurchaseCallback, ICartValidator cartValidator, IGooglePlayStoreConnectionService connectionService, IGoogleBillingClient billingClient)
		{
			this.m_FetchProductsService = fetchProductsService;
			this.m_StorePurchaseService = storePurchaseService;
			this.m_PlayStoreFetchPurchasesService = playStoreFetchPurchasesService;
			this.m_CheckEntitlementsService = checkEntitlementsService;
			this.m_FinishTransactionService = transactionService;
			this.m_ChangeSubscriptionService = changeSubscriptionService;
			this.m_GooglePurchaseCallback = googlePurchaseCallback;
			this.m_CartValidator = cartValidator;
			this.m_ConnectionService = connectionService;
			this.m_BillingClient = billingClient;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000042C0 File Offset: 0x000024C0
		public override void FetchProducts(IReadOnlyCollection<ProductDefinition> products)
		{
			this.m_FetchProductsService.FetchProducts(products);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000042CE File Offset: 0x000024CE
		public override void FetchPurchases()
		{
			this.FetchPurchasesInternal();
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000042D6 File Offset: 0x000024D6
		private void FetchPurchasesInternal()
		{
			this.m_PlayStoreFetchPurchasesService.FetchPurchases();
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000042E4 File Offset: 0x000024E4
		public override void Purchase(ICart cart)
		{
			this.m_CartValidator.Validate(cart);
			ProductDefinition definition = cart.Items().First<CartItem>().Product.definition;
			this.m_StorePurchaseService.Purchase(definition);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000431F File Offset: 0x0000251F
		public void ChangeSubscription(ProductDefinition product, Order currentOrder, GooglePlayReplacementMode? desiredReplacementMode)
		{
			this.m_ChangeSubscriptionService.ChangeSubscription(product, currentOrder, desiredReplacementMode);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00004330 File Offset: 0x00002530
		public override void FinishTransaction(PendingOrder pendingOrder)
		{
			this.m_CartValidator.Validate(pendingOrder.CartOrdered);
			ProductDefinition definition = pendingOrder.CartOrdered.Items().First<CartItem>().Product.definition;
			this.m_FinishTransactionService.FinishTransaction(definition, pendingOrder.Info.TransactionID);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00004380 File Offset: 0x00002580
		public override void Connect()
		{
			this.m_ConnectionService.Connect();
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000438D File Offset: 0x0000258D
		public override void CheckEntitlement(ProductDefinition product)
		{
			this.m_CheckEntitlementsService.CheckEntitlement(product);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000439B File Offset: 0x0000259B
		public override void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchPurchaseCallback)
		{
			this.m_PlayStoreFetchPurchasesService.SetPurchaseFetchCallback(fetchPurchaseCallback);
			this.m_GooglePurchaseCallback.SetPurchaseFetchCallback(fetchPurchaseCallback);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000043B5 File Offset: 0x000025B5
		public override void SetPurchaseCallback(IStorePurchaseCallback purchaseCallback)
		{
			this.m_GooglePurchaseCallback.SetPurchaseCallback(purchaseCallback);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000043C3 File Offset: 0x000025C3
		public void SetChangeSubscriptionCallback(IGooglePlayChangeSubscriptionCallback changeSubscriptionCallback)
		{
			this.m_GooglePurchaseCallback.SetChangeSubscriptionCallback(changeSubscriptionCallback);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000043D1 File Offset: 0x000025D1
		public override void SetPurchaseConfirmCallback(IStorePurchaseConfirmCallback confirmCallback)
		{
			this.m_FinishTransactionService.SetConfirmCallback(confirmCallback);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000043DF File Offset: 0x000025DF
		public override void SetProductsCallback(IStoreProductsCallback productsCallback)
		{
			this.m_FetchProductsService.SetProductsCallback(productsCallback);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000043ED File Offset: 0x000025ED
		public override void SetEntitlementCheckCallback(IStoreCheckEntitlementCallback entitlementCallback)
		{
			this.m_CheckEntitlementsService.SetCheckEntitlementCallback(entitlementCallback);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000043FB File Offset: 0x000025FB
		public override void SetStoreConnectionCallback(IStoreConnectCallback storeConnectCallback)
		{
			this.m_ConnectionService.SetConnectionCallback(storeConnectCallback);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00004409 File Offset: 0x00002609
		public void OnPause(bool isPaused)
		{
			if (!isPaused)
			{
				this.FetchPurchasesInternal();
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00004414 File Offset: 0x00002614
		public IGooglePurchase GetGooglePurchase(string purchaseToken)
		{
			return this.m_PlayStoreFetchPurchasesService.GetGooglePurchase(purchaseToken);
		}

		// Token: 0x0400004F RID: 79
		private readonly IGooglePlayStoreConnectionService m_ConnectionService;

		// Token: 0x04000050 RID: 80
		private readonly IGooglePlayStoreFetchProductsService m_FetchProductsService;

		// Token: 0x04000051 RID: 81
		private readonly IGooglePlayStorePurchaseService m_StorePurchaseService;

		// Token: 0x04000052 RID: 82
		private readonly IGooglePlayStoreFetchPurchasesService m_PlayStoreFetchPurchasesService;

		// Token: 0x04000053 RID: 83
		private readonly IGooglePlayStoreCheckEntitlementService m_CheckEntitlementsService;

		// Token: 0x04000054 RID: 84
		private readonly IGooglePlayStoreFinishTransactionService m_FinishTransactionService;

		// Token: 0x04000055 RID: 85
		private readonly IGooglePlayStoreChangeSubscriptionService m_ChangeSubscriptionService;

		// Token: 0x04000056 RID: 86
		private readonly IGooglePurchaseCallback m_GooglePurchaseCallback;

		// Token: 0x04000057 RID: 87
		private readonly ICartValidator m_CartValidator;

		// Token: 0x04000058 RID: 88
		internal IGoogleBillingClient m_BillingClient;
	}
}
