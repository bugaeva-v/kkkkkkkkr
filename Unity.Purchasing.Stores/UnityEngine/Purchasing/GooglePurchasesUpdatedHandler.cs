using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Stores.Android.GooglePlay.AAR.Interfaces;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000016 RID: 22
	[NullableContext(1)]
	[Nullable(0)]
	internal class GooglePurchasesUpdatedHandler : IGooglePurchasesUpdatedHandler
	{
		// Token: 0x06000055 RID: 85 RVA: 0x00002F78 File Offset: 0x00001178
		[Preserve]
		internal GooglePurchasesUpdatedHandler(IGoogleLastKnownProductService googleLastKnownProductService, IGooglePurchaseCallback googlePurchaseCallback, IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, IGoogleQueryPurchasesUseCase googleQueryPurchasesUseCase)
		{
			this.m_LastKnownProductService = googleLastKnownProductService;
			this.m_GooglePurchaseCallback = googlePurchaseCallback;
			this.m_GooglePurchaseStateEnumProvider = googlePurchaseStateEnumProvider;
			this.m_GoogleQueryPurchasesUseCase = googleQueryPurchasesUseCase;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002F9D File Offset: 0x0000119D
		public void SubscribeToPurchasesUpdatedEvent(IGooglePurchasesUpdatedListener purchasesUpdatedListener)
		{
			purchasesUpdatedListener.OnPurchaseUpdated += this.HandleUpdatedPurchases;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002FB2 File Offset: 0x000011B2
		public void HandleUpdatedPurchases(IGoogleBillingResult result, List<IGooglePurchase> purchases)
		{
			if (result.responseCode == GoogleBillingResponseCode.Ok)
			{
				this.HandleResultOkCases(result, purchases);
				return;
			}
			this.HandleErrorCases(result, purchases);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002FCD File Offset: 0x000011CD
		private void HandleResultOkCases(IGoogleBillingResult result, List<IGooglePurchase> purchases)
		{
			if (purchases.Any<IGooglePurchase>())
			{
				this.ApplyOnPurchases(purchases, new Action<IGooglePurchase>(this.OnPurchaseOk));
				return;
			}
			this.HandleNoPurchasesErrorCase(result);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002FF2 File Offset: 0x000011F2
		private void HandleErrorCases(IGoogleBillingResult billingResult, List<IGooglePurchase> purchases)
		{
			if (purchases.Any<IGooglePurchase>())
			{
				this.HandleExistingPurchasesErrorCase(purchases, billingResult);
				return;
			}
			this.HandleNoPurchasesErrorCase(billingResult);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000300C File Offset: 0x0000120C
		private void HandleExistingPurchasesErrorCase(List<IGooglePurchase> purchases, IGoogleBillingResult billingResult)
		{
			if (billingResult.responseCode == GoogleBillingResponseCode.UserCanceled)
			{
				this.ApplyOnPurchases(purchases, new Action<IGooglePurchase>(this.OnPurchaseCancelled));
				return;
			}
			if (billingResult.responseCode == GoogleBillingResponseCode.ItemAlreadyOwned)
			{
				this.ApplyOnPurchases(purchases, new Action<IGooglePurchase>(this.OnPurchaseAlreadyOwned));
				return;
			}
			this.ApplyOnPurchases(purchases, delegate(IGooglePurchase purchase)
			{
				this.OnPurchaseFailedForUnknownReason(purchase, billingResult.debugMessage);
			});
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003084 File Offset: 0x00001284
		private void HandleNoPurchasesErrorCase(IGoogleBillingResult billingResult)
		{
			GoogleBillingResponseCode responseCode = billingResult.responseCode;
			switch (responseCode)
			{
			case GoogleBillingResponseCode.Ok:
			{
				IGooglePurchaseCallback googlePurchaseCallback = this.m_GooglePurchaseCallback;
				IProductCache productCache = this.m_ProductCache;
				googlePurchaseCallback.OnPurchaseFailed(new PurchaseFailureDescription(((productCache != null) ? productCache.FindOrDefault(this.m_LastKnownProductService.LastKnownProductId) : null) ?? Product.CreateUnknownProduct(this.m_LastKnownProductService.LastKnownProductId), PurchaseFailureReason.PurchaseMissing, billingResult.debugMessage + " - onPurchasesUpdated: purchases list is empty - Google BillingResponseCode = " + billingResult.responseCode.ToString()));
				return;
			}
			case GoogleBillingResponseCode.UserCanceled:
				this.HandleUserCancelledPurchaseFailure(billingResult);
				return;
			case GoogleBillingResponseCode.ServiceUnavailable:
				break;
			case GoogleBillingResponseCode.BillingUnavailable:
			{
				IGooglePurchaseCallback googlePurchaseCallback2 = this.m_GooglePurchaseCallback;
				IProductCache productCache2 = this.m_ProductCache;
				googlePurchaseCallback2.OnPurchaseFailed(new PurchaseFailureDescription(((productCache2 != null) ? productCache2.FindOrDefault(this.m_LastKnownProductService.LastKnownProductId) : null) ?? Product.CreateUnknownProduct(this.m_LastKnownProductService.LastKnownProductId), PurchaseFailureReason.PurchasingUnavailable, billingResult.debugMessage + " - Google BillingResponseCode = " + billingResult.responseCode.ToString()));
				return;
			}
			default:
				if (responseCode == GoogleBillingResponseCode.ItemAlreadyOwned)
				{
					IGooglePurchaseCallback googlePurchaseCallback3 = this.m_GooglePurchaseCallback;
					IProductCache productCache3 = this.m_ProductCache;
					googlePurchaseCallback3.OnPurchaseFailed(new PurchaseFailureDescription(((productCache3 != null) ? productCache3.FindOrDefault(this.m_LastKnownProductService.LastKnownProductId) : null) ?? Product.CreateUnknownProduct(this.m_LastKnownProductService.LastKnownProductId), PurchaseFailureReason.DuplicateTransaction, billingResult.debugMessage + " - Google BillingResponseCode = " + billingResult.responseCode.ToString()));
					return;
				}
				break;
			}
			IGooglePurchaseCallback googlePurchaseCallback4 = this.m_GooglePurchaseCallback;
			IProductCache productCache4 = this.m_ProductCache;
			googlePurchaseCallback4.OnPurchaseFailed(new PurchaseFailureDescription(((productCache4 != null) ? productCache4.FindOrDefault(this.m_LastKnownProductService.LastKnownProductId) : null) ?? Product.CreateUnknownProduct(this.m_LastKnownProductService.LastKnownProductId), PurchaseFailureReason.Unknown, billingResult.debugMessage + " {M: GPUL.HEC} - Google BillingResponseCode = " + billingResult.responseCode.ToString()));
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003270 File Offset: 0x00001470
		private void HandleUserCancelledPurchaseFailure(IGoogleBillingResult billingResult)
		{
			GooglePurchasesUpdatedHandler.<HandleUserCancelledPurchaseFailure>d__12 <HandleUserCancelledPurchaseFailure>d__;
			<HandleUserCancelledPurchaseFailure>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<HandleUserCancelledPurchaseFailure>d__.<>4__this = this;
			<HandleUserCancelledPurchaseFailure>d__.billingResult = billingResult;
			<HandleUserCancelledPurchaseFailure>d__.<>1__state = -1;
			<HandleUserCancelledPurchaseFailure>d__.<>t__builder.Start<GooglePurchasesUpdatedHandler.<HandleUserCancelledPurchaseFailure>d__12>(ref <HandleUserCancelledPurchaseFailure>d__);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000032B0 File Offset: 0x000014B0
		private void HandleUserCancelledPurchaseFailure(IGoogleBillingResult billingResult, List<IGooglePurchase> googlePurchases)
		{
			IGooglePurchase googlePurchase = googlePurchases.FirstOrDefault((IGooglePurchase purchase) => ((purchase != null) ? purchase.sku : null) == this.m_LastKnownProductService.LastKnownProductId);
			if (googlePurchase != null && !googlePurchase.IsAcknowledged())
			{
				this.OnPurchaseOk(googlePurchase);
				return;
			}
			this.OnPurchaseCancelled(billingResult);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000032EC File Offset: 0x000014EC
		private void ApplyOnPurchases(List<IGooglePurchase> purchases, Action<IGooglePurchase> action)
		{
			foreach (IGooglePurchase obj in purchases)
			{
				action(obj);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000333C File Offset: 0x0000153C
		private void OnPurchaseOk(IGooglePurchase googlePurchase)
		{
			if (googlePurchase.purchaseState == this.m_GooglePurchaseStateEnumProvider.Purchased())
			{
				this.HandlePurchasedProduct(googlePurchase);
				return;
			}
			if (googlePurchase.purchaseState == this.m_GooglePurchaseStateEnumProvider.Pending())
			{
				this.m_GooglePurchaseCallback.NotifyDeferredPurchase(googlePurchase);
				return;
			}
			IGooglePurchaseCallback googlePurchaseCallback = this.m_GooglePurchaseCallback;
			IProductCache productCache = this.m_ProductCache;
			googlePurchaseCallback.OnPurchaseFailed(new PurchaseFailureDescription(((productCache != null) ? productCache.FindOrDefault(googlePurchase.purchaseToken) : null) ?? Product.CreateUnknownProduct(googlePurchase.purchaseToken), PurchaseFailureReason.Unknown, "PurchaseState is UNSPECIFIED_STATE, no more details exists {M: GPUL.OPO}"));
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000033C8 File Offset: 0x000015C8
		private void HandlePurchasedProduct(IGooglePurchase googlePurchase)
		{
			if (this.IsDeferredSubscriptionChange(googlePurchase))
			{
				this.m_GooglePurchaseCallback.NotifyDeferredProrationUpgradeDowngradeSubscription(this.m_LastKnownProductService.LastKnownProductId);
				return;
			}
			if (!string.IsNullOrEmpty(this.m_LastKnownProductService.LastKnownOldProductId) && this.m_LastKnownProductService.LastKnownOldProductId != this.m_LastKnownProductService.LastKnownProductId)
			{
				this.m_GooglePurchaseCallback.NotifyUpgradeDowngradeSubscription(this.m_LastKnownProductService.LastKnownProductId);
			}
			this.m_GooglePurchaseCallback.OnPurchaseSuccessful(googlePurchase);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003446 File Offset: 0x00001646
		private bool IsDeferredSubscriptionChange(IGooglePurchase googlePurchase)
		{
			return this.IsLastReplacementModeDeferred() && googlePurchase.sku == this.m_LastKnownProductService.LastKnownOldProductId;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003468 File Offset: 0x00001668
		private bool IsLastReplacementModeDeferred()
		{
			GooglePlayReplacementMode? lastKnownReplacementMode = this.m_LastKnownProductService.LastKnownReplacementMode;
			GooglePlayReplacementMode googlePlayReplacementMode = GooglePlayReplacementMode.Deferred;
			return lastKnownReplacementMode.GetValueOrDefault() == googlePlayReplacementMode & lastKnownReplacementMode != null;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003498 File Offset: 0x00001698
		private void OnPurchaseCancelled(IGoogleBillingResult billingResult)
		{
			if (!string.IsNullOrEmpty(this.m_LastKnownProductService.LastKnownOldProductId) && this.m_LastKnownProductService.LastKnownOldProductId != this.m_LastKnownProductService.LastKnownProductId)
			{
				this.m_GooglePurchaseCallback.NotifyUpgradeDowngradeSubscription(this.m_LastKnownProductService.LastKnownProductId);
			}
			IGooglePurchaseCallback googlePurchaseCallback = this.m_GooglePurchaseCallback;
			IProductCache productCache = this.m_ProductCache;
			googlePurchaseCallback.OnPurchaseFailed(new PurchaseFailureDescription(((productCache != null) ? productCache.FindOrDefault(this.m_LastKnownProductService.LastKnownProductId) : null) ?? Product.CreateUnknownProduct(this.m_LastKnownProductService.LastKnownProductId), PurchaseFailureReason.UserCancelled, billingResult.debugMessage + " - Google BillingResponseCode = " + billingResult.responseCode.ToString()));
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003558 File Offset: 0x00001758
		private void OnPurchaseCancelled(IGooglePurchase googlePurchase)
		{
			IGooglePurchaseCallback googlePurchaseCallback = this.m_GooglePurchaseCallback;
			IProductCache productCache = this.m_ProductCache;
			googlePurchaseCallback.OnPurchaseFailed(new PurchaseFailureDescription(((productCache != null) ? productCache.FindOrDefault(googlePurchase.purchaseToken) : null) ?? Product.CreateUnknownProduct(googlePurchase.purchaseToken), PurchaseFailureReason.UserCancelled, "User cancelled purchase - Google BillingResponseCode = " + GoogleBillingResponseCode.UserCanceled.ToString()));
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000035BC File Offset: 0x000017BC
		private void OnPurchaseAlreadyOwned(IGooglePurchase googlePurchase)
		{
			IGooglePurchaseCallback googlePurchaseCallback = this.m_GooglePurchaseCallback;
			IProductCache productCache = this.m_ProductCache;
			googlePurchaseCallback.OnPurchaseFailed(new PurchaseFailureDescription(((productCache != null) ? productCache.FindOrDefault(googlePurchase.purchaseToken) : null) ?? Product.CreateUnknownProduct(googlePurchase.purchaseToken), PurchaseFailureReason.DuplicateTransaction, "Item already owned - Google BillingResponseCode = " + GoogleBillingResponseCode.ItemAlreadyOwned.ToString()));
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003620 File Offset: 0x00001820
		private void OnPurchaseFailedForUnknownReason(IGooglePurchase googlePurchase, string debugMessage)
		{
			IGooglePurchaseCallback googlePurchaseCallback = this.m_GooglePurchaseCallback;
			IProductCache productCache = this.m_ProductCache;
			googlePurchaseCallback.OnPurchaseFailed(new PurchaseFailureDescription(((productCache != null) ? productCache.FindOrDefault(googlePurchase.purchaseToken) : null) ?? Product.CreateUnknownProduct(googlePurchase.purchaseToken), PurchaseFailureReason.Unknown, debugMessage + " {M: GPUL.OPF}"));
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003676 File Offset: 0x00001876
		[NullableContext(2)]
		public void SetProductCache(IProductCache productCache)
		{
			this.m_ProductCache = productCache;
		}

		// Token: 0x04000028 RID: 40
		private readonly IGoogleLastKnownProductService m_LastKnownProductService;

		// Token: 0x04000029 RID: 41
		private readonly IGooglePurchaseStateEnumProvider m_GooglePurchaseStateEnumProvider;

		// Token: 0x0400002A RID: 42
		private readonly IGoogleQueryPurchasesUseCase m_GoogleQueryPurchasesUseCase;

		// Token: 0x0400002B RID: 43
		private readonly IGooglePurchaseCallback m_GooglePurchaseCallback;

		// Token: 0x0400002C RID: 44
		[Nullable(2)]
		private IProductCache m_ProductCache;
	}
}
