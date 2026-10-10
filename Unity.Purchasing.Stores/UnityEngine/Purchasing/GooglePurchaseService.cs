using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000015 RID: 21
	[NullableContext(1)]
	[Nullable(0)]
	internal class GooglePurchaseService : IGooglePurchaseService
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00002CD7 File Offset: 0x00000ED7
		[Preserve]
		internal GooglePurchaseService(IGoogleBillingClient billingClient, IGooglePurchaseCallback googlePurchaseCallback, IQueryProductDetailsService queryProductDetailsService, ILogger logger)
		{
			this.m_BillingClient = billingClient;
			this.m_GooglePurchaseCallback = googlePurchaseCallback;
			this.m_QueryProductDetailsService = queryProductDetailsService;
			this.m_Logger = logger;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002CFC File Offset: 0x00000EFC
		public void Purchase(ProductDefinition product, [Nullable(2)] Order currentOrder, GooglePlayReplacementMode? desiredReplacementMode)
		{
			GooglePurchaseService.<Purchase>d__6 <Purchase>d__;
			<Purchase>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Purchase>d__.<>4__this = this;
			<Purchase>d__.product = product;
			<Purchase>d__.currentOrder = currentOrder;
			<Purchase>d__.desiredReplacementMode = desiredReplacementMode;
			<Purchase>d__.<>1__state = -1;
			<Purchase>d__.<>t__builder.Start<GooglePurchaseService.<Purchase>d__6>(ref <Purchase>d__);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002D4B File Offset: 0x00000F4B
		private void OnQueryProductDetailsResponse(List<AndroidJavaObject> productDetailsList, ProductDefinition productToBuy, [Nullable(2)] Order currentOrder, GooglePlayReplacementMode? desiredReplacementMode)
		{
			if (this.ValidateQueryProductDetailsResponseParams(productDetailsList, productToBuy, currentOrder))
			{
				this.LaunchGoogleBillingFlow(productDetailsList[0], currentOrder, desiredReplacementMode);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002D68 File Offset: 0x00000F68
		private bool ValidateQueryProductDetailsResponseParams(List<AndroidJavaObject> skus, ProductDefinition productToBuy, [Nullable(2)] Order currentOrder)
		{
			if (!this.ValidateSkus(skus))
			{
				this.PurchaseFailedSkuNotFound(productToBuy);
				return false;
			}
			if (currentOrder != null && !GooglePurchaseService.ValidateCurrentOrder(currentOrder))
			{
				this.PurchaseFailedInvalidOldProduct(productToBuy, currentOrder);
				return false;
			}
			return true;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002D92 File Offset: 0x00000F92
		private bool ValidateSkus([Nullable(new byte[]
		{
			2,
			1
		})] List<AndroidJavaObject> skus)
		{
			this.VerifyAndWarnIfMoreThanOneSku(skus);
			return skus != null && skus.Count > 0;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002DA9 File Offset: 0x00000FA9
		private void VerifyAndWarnIfMoreThanOneSku([Nullable(new byte[]
		{
			2,
			1
		})] List<AndroidJavaObject> skus)
		{
			if (skus != null && skus.Count > 1)
			{
				this.m_Logger.LogIAPWarning(GoogleBillingStrings.getWarningMessageMoreThanOneSkuFound(skus[0].Call<string>("getProductId", Array.Empty<object>())));
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002DE0 File Offset: 0x00000FE0
		private void PurchaseFailedSkuNotFound(ProductDefinition productToBuy)
		{
			IGooglePurchaseCallback googlePurchaseCallback = this.m_GooglePurchaseCallback;
			IProductCache productCache = this.m_ProductCache;
			googlePurchaseCallback.OnPurchaseFailed(new PurchaseFailureDescription(((productCache != null) ? productCache.FindOrDefault(productToBuy.id) : null) ?? Product.CreateUnknownProduct(productToBuy.id), PurchaseFailureReason.ProductUnavailable, "SKU does not exist in the store."));
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002E2F File Offset: 0x0000102F
		[NullableContext(2)]
		private static bool ValidateCurrentOrder(Order currentOrder)
		{
			return !string.IsNullOrEmpty((currentOrder != null) ? currentOrder.Info.TransactionID : null);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002E4C File Offset: 0x0000104C
		private void PurchaseFailedInvalidOldProduct(ProductDefinition productToBuy, [Nullable(2)] Order currentOrder)
		{
			Product product;
			if (currentOrder == null)
			{
				product = null;
			}
			else
			{
				CartItem cartItem = currentOrder.CartOrdered.Items().FirstOrDefault<CartItem>();
				product = ((cartItem != null) ? cartItem.Product : null);
			}
			Product product2 = product;
			IGooglePurchaseCallback googlePurchaseCallback = this.m_GooglePurchaseCallback;
			IProductCache productCache = this.m_ProductCache;
			googlePurchaseCallback.OnPurchaseFailed(new PurchaseFailureDescription(((productCache != null) ? productCache.FindOrDefault(productToBuy.id) : null) ?? Product.CreateUnknownProduct(productToBuy.id), PurchaseFailureReason.ProductUnavailable, "Invalid transaction id for old product: " + ((product2 != null) ? product2.definition.id : null)));
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002ED4 File Offset: 0x000010D4
		private void LaunchGoogleBillingFlow(AndroidJavaObject productToPurchase, [Nullable(2)] Order currentOrder, GooglePlayReplacementMode? desiredReplacementMode)
		{
			AndroidJavaObject billingResult = this.m_BillingClient.LaunchBillingFlow(productToPurchase, (currentOrder != null) ? currentOrder.Info.TransactionID : null, desiredReplacementMode);
			this.HandleBillingFlowResult(new GoogleBillingResult(billingResult), productToPurchase);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002F10 File Offset: 0x00001110
		private void HandleBillingFlowResult(IGoogleBillingResult billingResult, AndroidJavaObject sku)
		{
			if (billingResult.responseCode != GoogleBillingResponseCode.Ok)
			{
				string productId = sku.Call<string>("getProductId", Array.Empty<object>());
				IGooglePurchaseCallback googlePurchaseCallback = this.m_GooglePurchaseCallback;
				IProductCache productCache = this.m_ProductCache;
				googlePurchaseCallback.OnPurchaseFailed(new PurchaseFailureDescription(((productCache != null) ? productCache.FindOrDefault(productId) : null) ?? Product.CreateUnknownProduct(productId), PurchaseFailureReason.PurchasingUnavailable, billingResult.debugMessage));
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002F6F File Offset: 0x0000116F
		[NullableContext(2)]
		public void SetProductCache(IProductCache productCache)
		{
			this.m_ProductCache = productCache;
		}

		// Token: 0x04000023 RID: 35
		private readonly IGoogleBillingClient m_BillingClient;

		// Token: 0x04000024 RID: 36
		private readonly IGooglePurchaseCallback m_GooglePurchaseCallback;

		// Token: 0x04000025 RID: 37
		private readonly IQueryProductDetailsService m_QueryProductDetailsService;

		// Token: 0x04000026 RID: 38
		private readonly ILogger m_Logger;

		// Token: 0x04000027 RID: 39
		[Nullable(2)]
		private IProductCache m_ProductCache;
	}
}
