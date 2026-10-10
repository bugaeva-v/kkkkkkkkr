using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Security;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200001F RID: 31
	[NullableContext(1)]
	[Nullable(0)]
	internal class GooglePlayStoreExtendedPurchaseService : PurchaseService, IGooglePlayStoreExtendedPurchaseService, IPurchaseServiceExtension
	{
		// Token: 0x0600007D RID: 125 RVA: 0x00002CAB File Offset: 0x00000EAB
		[Preserve]
		internal GooglePlayStoreExtendedPurchaseService(IGooglePlayChangeSubscriptionUseCase googlePlayChangeSubscriptionUseCase, IRestoreTransactionsUseCase restoreTransactionsUseCase, IFetchPurchasesUseCase fetchPurchasesUseCase, IPurchaseUseCase purchaseUseCase, IConfirmOrderUseCase confirmOrderUseCase, ICheckEntitlementUseCase checkEntitlementUseCase, IStoreWrapper storeWrapper, IAnalyticsClient analyticsClient) : base(fetchPurchasesUseCase, purchaseUseCase, confirmOrderUseCase, checkEntitlementUseCase, storeWrapper, analyticsClient)
		{
			this.m_GooglePlayChangeSubscriptionUseCase = googlePlayChangeSubscriptionUseCase;
			this.m_RestoreTransactionsUseCase = restoreTransactionsUseCase;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002CCC File Offset: 0x00000ECC
		public void UpgradeDowngradeSubscription(Product oldProduct, Product newProduct)
		{
			this.UpgradeDowngradeSubscription(oldProduct, newProduct, GooglePlayProrationMode.ImmediateWithoutProration);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002CD7 File Offset: 0x00000ED7
		public void UpgradeDowngradeSubscription(Product oldProduct, Product newProduct, GooglePlayProrationMode desiredProrationMode)
		{
			this.UpgradeDowngradeSubscription(oldProduct, newProduct, (GooglePlayReplacementMode)desiredProrationMode);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002CE4 File Offset: 0x00000EE4
		public void UpgradeDowngradeSubscription(Product oldProduct, Product newProduct, GooglePlayReplacementMode desiredReplacementMode)
		{
			try
			{
				Order order2 = UnityIAPServices.Purchase("GooglePlay").GetPurchases().First((Order order) => order.CartOrdered.Items().Contains(oldProduct)) ?? new ConfirmedOrder(new Cart(new CartItem(oldProduct)), new OrderInfo("", oldProduct.transactionID, ""));
				this.UpgradeDowngradeSubscription(order2, newProduct, desiredReplacementMode);
			}
			catch (Exception ex)
			{
				base.PurchaseFailed(new FailedOrder(new Cart(new CartItem(newProduct)), PurchaseFailureReason.Unknown, ex.Message));
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002D90 File Offset: 0x00000F90
		public void UpgradeDowngradeSubscription(Order order, Product newProduct, GooglePlayReplacementMode desiredReplacementMode)
		{
			try
			{
				this.m_GooglePlayChangeSubscriptionUseCase.ChangeSubscription(order, newProduct, desiredReplacementMode);
			}
			catch (Exception ex)
			{
				base.PurchaseFailed(new FailedOrder(new Cart(new CartItem(newProduct)), PurchaseFailureReason.Unknown, ex.Message));
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002DE0 File Offset: 0x00000FE0
		public bool IsOrderDeferred(Order order)
		{
			GooglePurchaseState? purchaseState = this.GetPurchaseState(order);
			GooglePurchaseState? googlePurchaseState = purchaseState;
			GooglePurchaseState googlePurchaseState2 = GooglePurchaseState.Refunded;
			if (!(googlePurchaseState.GetValueOrDefault() == googlePurchaseState2 & googlePurchaseState != null))
			{
				googlePurchaseState = purchaseState;
				googlePurchaseState2 = GooglePurchaseState.Deferred;
				return googlePurchaseState.GetValueOrDefault() == googlePurchaseState2 & googlePurchaseState != null;
			}
			return true;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002E25 File Offset: 0x00001025
		[return: Nullable(2)]
		public string GetObfuscatedAccountId(Order order)
		{
			IGoogleOrderInfo google = order.Info.Google;
			if (google == null)
			{
				return null;
			}
			return google.ObfuscatedAccountId;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002E3D File Offset: 0x0000103D
		[return: Nullable(2)]
		public string GetObfuscatedProfileId(Order order)
		{
			IGoogleOrderInfo google = order.Info.Google;
			if (google == null)
			{
				return null;
			}
			return google.ObfuscatedProfileId;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002E58 File Offset: 0x00001058
		public GooglePurchaseState? GetPurchaseState(Order order)
		{
			GooglePurchaseState? result;
			if (!(order is DeferredOrder))
			{
				if (!(order is PendingOrder) && !(order is ConfirmedOrder))
				{
					result = null;
				}
				else
				{
					result = new GooglePurchaseState?(GooglePurchaseState.Purchased);
				}
			}
			else
			{
				result = new GooglePurchaseState?(GooglePurchaseState.Deferred);
			}
			return result;
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000086 RID: 134 RVA: 0x00002E9C File Offset: 0x0000109C
		// (remove) Token: 0x06000087 RID: 135 RVA: 0x00002EAA File Offset: 0x000010AA
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<DeferredPaymentUntilRenewalDateOrder> OnDeferredPaymentUntilRenewalDate
		{
			add
			{
				this.m_GooglePlayChangeSubscriptionUseCase.OnDeferredPaymentUntilRenewalDate += value;
			}
			remove
			{
				this.m_GooglePlayChangeSubscriptionUseCase.OnDeferredPaymentUntilRenewalDate -= value;
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002EB8 File Offset: 0x000010B8
		[NullableContext(2)]
		protected override void RestoreTransactionsInternal(Action<bool, string> callback)
		{
			this.m_RestoreTransactionsUseCase.RestoreTransactions(callback);
		}

		// Token: 0x04000024 RID: 36
		private readonly IGooglePlayChangeSubscriptionUseCase m_GooglePlayChangeSubscriptionUseCase;

		// Token: 0x04000025 RID: 37
		private readonly IRestoreTransactionsUseCase m_RestoreTransactionsUseCase;
	}
}
