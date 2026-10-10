using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000028 RID: 40
	[NullableContext(1)]
	[Nullable(0)]
	internal class GooglePlayPurchaseUseCase : PurchaseUseCase, IGooglePlayChangeSubscriptionUseCase, IGooglePlayChangeSubscriptionCallback, IStorePurchaseCallback
	{
		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060000A3 RID: 163 RVA: 0x00002F5C File Offset: 0x0000115C
		// (remove) Token: 0x060000A4 RID: 164 RVA: 0x00002F94 File Offset: 0x00001194
		[Nullable(new byte[]
		{
			2,
			1
		})]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<DeferredPaymentUntilRenewalDateOrder> OnDeferredPaymentUntilRenewalDate;

		// Token: 0x060000A5 RID: 165 RVA: 0x00002FC9 File Offset: 0x000011C9
		internal GooglePlayPurchaseUseCase(IGooglePlayStore storeResponsible, IProductCache productCache) : base(storeResponsible)
		{
			storeResponsible.SetChangeSubscriptionCallback(this);
			this.m_ProductCache = productCache;
			base.OnPurchaseFail += this.OnSubscriptionChangeFailed;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00003000 File Offset: 0x00001200
		public void ChangeSubscription(Order currentOrder, Product newSubscription, GooglePlayReplacementMode replacementMode)
		{
			if (!this.IsSubscriptionChangeValid(currentOrder, newSubscription))
			{
				base.OnPurchaseFailed(new FailedOrder(new Cart(new CartItem(newSubscription)), PurchaseFailureReason.Unknown, "Invalid SubscriptionProducts requested for purchase. Please pass a valid `SubscriptionProduct` object."));
				return;
			}
			if (this.FindExistingPurchaseRequest(newSubscription) || this.ConflictingSubscriptionChangeRequestExists(currentOrder, newSubscription))
			{
				this.RejectPurchaseDueToPendingDuplicate(newSubscription);
				return;
			}
			SubscriptionChangeRequest subscriptionChangeRequest = new SubscriptionChangeRequest(currentOrder, newSubscription, replacementMode);
			this.AddAndSendSubscriptionChangeRequest(subscriptionChangeRequest);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00003060 File Offset: 0x00001260
		private bool IsSubscriptionChangeValid(Order currentOrder, Product newSubscription)
		{
			CartItem cartItem = currentOrder.CartOrdered.Items().FirstOrDefault<CartItem>();
			Product product = (cartItem != null) ? cartItem.Product : null;
			return product != null && (GooglePlayPurchaseUseCase.IsSubscriptionProductValid(newSubscription) && GooglePlayPurchaseUseCase.IsSubscriptionProductValid(product)) && !product.Equals(newSubscription);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000030AB File Offset: 0x000012AB
		[NullableContext(2)]
		private static bool IsSubscriptionProductValid(Product subscription)
		{
			return ((subscription != null) ? subscription.definition : null) != null;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000030BC File Offset: 0x000012BC
		private bool ConflictingSubscriptionChangeRequestExists(Order currentOrder, Product newSubscription)
		{
			return this.m_PendingRequests.Exists((SubscriptionChangeRequest request) => request.CurrentOrder.Equals(currentOrder) || request.NewSubscription.Equals(newSubscription));
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000030F4 File Offset: 0x000012F4
		private void AddAndSendSubscriptionChangeRequest(SubscriptionChangeRequest subscriptionChangeRequest)
		{
			this.m_PendingRequests.Add(subscriptionChangeRequest);
			IGooglePlayStore googlePlayStore = this.GooglePlayStore();
			if (googlePlayStore == null)
			{
				return;
			}
			googlePlayStore.ChangeSubscription(subscriptionChangeRequest.NewSubscription.definition, subscriptionChangeRequest.CurrentOrder, new GooglePlayReplacementMode?(subscriptionChangeRequest.ReplacementMode));
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000312E File Offset: 0x0000132E
		[NullableContext(2)]
		private IGooglePlayStore GooglePlayStore()
		{
			return base.m_Store as IGooglePlayStore;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000313C File Offset: 0x0000133C
		private void OnSubscriptionChangeFailed(FailedOrder order)
		{
			try
			{
				SubscriptionChangeRequest matchingRequest = this.GetMatchingRequest(order.CartOrdered.Items().First<CartItem>().Product.definition.storeSpecificId);
				if (matchingRequest != null)
				{
					this.m_PendingRequests.Remove(matchingRequest);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00003194 File Offset: 0x00001394
		public void OnSubscriptionChangeDeferredUntilRenewal(string storeSpecificId)
		{
			try
			{
				SubscriptionChangeRequest matchingRequest = this.GetMatchingRequest(storeSpecificId);
				DeferredPaymentUntilRenewalDateOrder pendingPurchase = new DeferredPaymentUntilRenewalDateOrder((matchingRequest != null) ? matchingRequest.CurrentOrder : null, (matchingRequest != null) ? matchingRequest.NewSubscription : null);
				if (matchingRequest != null)
				{
					this.m_PendingRequests.Remove(matchingRequest);
				}
				this.InvokeOnDeferredPaymentUntilRenewalDate(pendingPurchase);
			}
			catch (Exception)
			{
				Product product = this.m_ProductCache.FindOrDefault(storeSpecificId);
				base.OnPurchaseFailed(new FailedOrder(new Cart(new CartItem(product)), PurchaseFailureReason.Unknown, "The product with sku id: " + storeSpecificId + ", was successfully purchased. The request list may be corrupt."));
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00003228 File Offset: 0x00001428
		internal void InvokeOnDeferredPaymentUntilRenewalDate(DeferredPaymentUntilRenewalDateOrder pendingPurchase)
		{
			Action<DeferredPaymentUntilRenewalDateOrder> onDeferredPaymentUntilRenewalDate = this.OnDeferredPaymentUntilRenewalDate;
			if (onDeferredPaymentUntilRenewalDate == null)
			{
				return;
			}
			onDeferredPaymentUntilRenewalDate(pendingPurchase);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000323C File Offset: 0x0000143C
		public void OnSubscriptionChange(string storeSpecificId)
		{
			try
			{
				SubscriptionChangeRequest matchingRequest = this.GetMatchingRequest(storeSpecificId);
				if (matchingRequest != null)
				{
					this.m_PendingRequests.Remove(matchingRequest);
				}
			}
			catch (Exception)
			{
				Product product = this.m_ProductCache.FindOrDefault(storeSpecificId);
				base.OnPurchaseFailed(new FailedOrder(new Cart(new CartItem(product)), PurchaseFailureReason.Unknown, "The product with sku id: " + storeSpecificId + ", was successfully purchased. The request list may be corrupt."));
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000032AC File Offset: 0x000014AC
		[return: Nullable(2)]
		private SubscriptionChangeRequest GetMatchingRequest(string productId)
		{
			return this.m_PendingRequests.FirstOrDefault((SubscriptionChangeRequest request) => request.NewSubscription.definition.storeSpecificId == productId);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000032E0 File Offset: 0x000014E0
		private bool FindExistingPurchaseRequest(Product productToCheckFor)
		{
			return this.m_PendingRequests.Exists((SubscriptionChangeRequest request) => request.NewSubscription.Equals(productToCheckFor));
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00003314 File Offset: 0x00001514
		private void RejectPurchaseDueToPendingDuplicate(Product product)
		{
			FailedOrder failedOrder = new FailedOrder(new Cart(new CartItem(product)), PurchaseFailureReason.DuplicateTransaction, "Cannot attempt to purchase a Product that has an existing pending purchase request");
			base.OnPurchaseFailed(failedOrder);
		}

		// Token: 0x0400002C RID: 44
		private readonly List<SubscriptionChangeRequest> m_PendingRequests = new List<SubscriptionChangeRequest>();

		// Token: 0x0400002D RID: 45
		private IProductCache m_ProductCache;
	}
}
