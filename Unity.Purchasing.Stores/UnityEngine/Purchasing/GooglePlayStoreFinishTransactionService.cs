using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200002B RID: 43
	[NullableContext(1)]
	[Nullable(0)]
	internal class GooglePlayStoreFinishTransactionService : IGooglePlayStoreFinishTransactionService
	{
		// Token: 0x060000E6 RID: 230 RVA: 0x00004AEC File Offset: 0x00002CEC
		[Preserve]
		internal GooglePlayStoreFinishTransactionService(IGooglePlayStoreService googlePlayStoreService)
		{
			this.m_ProcessedPurchaseToken = new HashSet<string>();
			this.m_GooglePlayStoreService = googlePlayStoreService;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00004B06 File Offset: 0x00002D06
		[NullableContext(2)]
		public void SetProductCache(IProductCache productCache)
		{
			this.m_ProductCache = productCache;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00004B0F File Offset: 0x00002D0F
		public void SetConfirmCallback(IStorePurchaseConfirmCallback confirmCallback)
		{
			this.m_ConfirmCallback = confirmCallback;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00004B18 File Offset: 0x00002D18
		public void FinishTransaction([Nullable(2)] ProductDefinition product, string purchaseToken)
		{
			GooglePlayStoreFinishTransactionService.<FinishTransaction>d__9 <FinishTransaction>d__;
			<FinishTransaction>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<FinishTransaction>d__.<>4__this = this;
			<FinishTransaction>d__.product = product;
			<FinishTransaction>d__.purchaseToken = purchaseToken;
			<FinishTransaction>d__.<>1__state = -1;
			<FinishTransaction>d__.<>t__builder.Start<GooglePlayStoreFinishTransactionService.<FinishTransaction>d__9>(ref <FinishTransaction>d__);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00004B60 File Offset: 0x00002D60
		private void HandleFinishTransaction([Nullable(2)] ProductDefinition product, IGoogleBillingResult billingResult, IGooglePurchase purchase)
		{
			if (this.m_ProcessedPurchaseToken.Contains(purchase.purchaseToken))
			{
				return;
			}
			if (billingResult.responseCode == GoogleBillingResponseCode.Ok)
			{
				this.m_RetryCount = 0;
				this.m_ProcessedPurchaseToken.Add(purchase.purchaseToken);
				this.CallPurchaseSucceededUpdateReceipt(purchase);
				return;
			}
			if (this.m_RetryCount <= 5 && GooglePlayStoreFinishTransactionService.IsResponseCodeInRecoverableState(billingResult))
			{
				this.m_RetryCount++;
				this.FinishTransaction(product, purchase.purchaseToken);
				return;
			}
			IProductCache productCache = this.m_ProductCache;
			Product product2;
			if ((product2 = ((productCache != null) ? productCache.FindOrDefault((product != null) ? product.storeSpecificId : null) : null)) == null)
			{
				product2 = Product.CreateUnknownProduct((product != null) ? product.storeSpecificId : null);
			}
			this.SendTransactionFailedCallback(new PurchaseFailureDescription(product2, PurchaseFailureReason.Unknown, billingResult.debugMessage + " {code: " + billingResult.responseCode.ToString() + ", M: GPSFTS.HFT}"), purchase.purchaseToken);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00004C4B File Offset: 0x00002E4B
		private void SendTransactionFailedCallback(PurchaseFailureDescription purchaseFailureDescription, [Nullable(2)] string purchaseToken)
		{
			IStorePurchaseConfirmCallback confirmCallback = this.m_ConfirmCallback;
			if (confirmCallback == null)
			{
				return;
			}
			confirmCallback.OnConfirmOrderFailed(purchaseFailureDescription.ConvertToFailedOrder(purchaseToken));
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00004C64 File Offset: 0x00002E64
		private void CallPurchaseSucceededUpdateReceipt(IGooglePurchase googlePurchase)
		{
			IStorePurchaseConfirmCallback confirmCallback = this.m_ConfirmCallback;
			if (confirmCallback == null)
			{
				return;
			}
			confirmCallback.OnConfirmOrderSucceeded(googlePurchase.purchaseToken);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00004C7C File Offset: 0x00002E7C
		private static bool IsResponseCodeInRecoverableState(IGoogleBillingResult billingResult)
		{
			return billingResult.responseCode == GoogleBillingResponseCode.ServiceUnavailable || billingResult.responseCode == GoogleBillingResponseCode.DeveloperError || billingResult.responseCode == GoogleBillingResponseCode.FatalError;
		}

		// Token: 0x04000066 RID: 102
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly HashSet<string> m_ProcessedPurchaseToken;

		// Token: 0x04000067 RID: 103
		private readonly IGooglePlayStoreService m_GooglePlayStoreService;

		// Token: 0x04000068 RID: 104
		[Nullable(2)]
		private IProductCache m_ProductCache;

		// Token: 0x04000069 RID: 105
		[Nullable(2)]
		private IStorePurchaseConfirmCallback m_ConfirmCallback;

		// Token: 0x0400006A RID: 106
		private int m_RetryCount;

		// Token: 0x0400006B RID: 107
		private const int k_MaxRetryAttempts = 5;
	}
}
