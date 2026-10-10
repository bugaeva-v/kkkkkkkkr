using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000A RID: 10
	[AddComponentMenu("In-App Purchasing/IAP Listener")]
	[HelpURL("https://docs.unity.com/ugs/en-us/manual/iap/manual/overview")]
	public class IAPListener : MonoBehaviour
	{
		// Token: 0x06000064 RID: 100 RVA: 0x00003657 File Offset: 0x00001857
		private void OnEnable()
		{
			if (this.dontDestroyOnLoad)
			{
				Object.DontDestroyOnLoad(base.gameObject);
			}
			CodelessIAPStoreListener.Instance.AddListener(this);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00003677 File Offset: 0x00001877
		private void OnDisable()
		{
			CodelessIAPStoreListener.Instance.RemoveListener(this);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003684 File Offset: 0x00001884
		public void OnProductsFetched(List<Product> products)
		{
			this.onProductsFetched.Invoke(products);
			this.onProductsFetchedLegacy.Invoke(new ProductCollection());
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000036A2 File Offset: 0x000018A2
		public void OnProductsFetchFailed(ProductFetchFailed productFetchFailed)
		{
			this.onProductsFetchFailed.Invoke(productFetchFailed);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000036B0 File Offset: 0x000018B0
		public void OnPurchasesFetched(Orders orders)
		{
			this.onPurchasesFetched.Invoke(orders);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000036BE File Offset: 0x000018BE
		public void OnPurchasesFetchFailure(PurchasesFetchFailureDescription purchasesFetchFailureDescription)
		{
			this.onPurchasesFetchFailure.Invoke(purchasesFetchFailureDescription);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000036CC File Offset: 0x000018CC
		public void OnOrderPending(PendingOrder pendingOrder)
		{
			this.onOrderPending.Invoke(pendingOrder);
			UnityEvent<Product> unityEvent = this.onPurchaseCompleteLegacy;
			CartItem cartItem = pendingOrder.CartOrdered.Items().FirstOrDefault<CartItem>();
			unityEvent.Invoke((cartItem != null) ? cartItem.Product : null);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003701 File Offset: 0x00001901
		public void OnOrderConfirmed(ConfirmedOrder confirmedOrder)
		{
			IAPListener.OnOrderConfirmedEvent onOrderConfirmedEvent = this.onOrderConfirmed;
			if (onOrderConfirmedEvent == null)
			{
				return;
			}
			onOrderConfirmedEvent.Invoke(confirmedOrder);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003714 File Offset: 0x00001914
		public void OnPurchaseFailed(FailedOrder failedOrder)
		{
			this.onPurchaseFailed.Invoke(failedOrder);
			CartItem cartItem = failedOrder.CartOrdered.Items().FirstOrDefault<CartItem>();
			Product arg = (cartItem != null) ? cartItem.Product : null;
			this.onPurchaseFailedLegacy.Invoke(arg, failedOrder.FailureReason);
			this.onPurchaseDetailedFailedLegacy.Invoke(arg, new PurchaseFailureDescription(failedOrder.CartOrdered.Items().FirstOrDefault<CartItem>(), failedOrder.FailureReason, failedOrder.Details));
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003789 File Offset: 0x00001989
		public void OnOrderDeferred(DeferredOrder deferredOrder)
		{
			this.onOrderDeferred.Invoke(deferredOrder);
		}

		// Token: 0x04000030 RID: 48
		[Tooltip("Automatically confirm the transaction immediately after a successful purchase.")]
		public bool automaticallyConfirmTransaction = true;

		// Token: 0x04000031 RID: 49
		[Tooltip("Preserve this GameObject when a new scene is loaded.")]
		public bool dontDestroyOnLoad = true;

		// Token: 0x04000032 RID: 50
		[Tooltip("Event fired after fetching products.")]
		public IAPListener.OnProductsFetchedEvent onProductsFetched;

		// Token: 0x04000033 RID: 51
		[Tooltip("Event fired after failing to fetch products.")]
		public IAPListener.OnProductsFetchFailedEvent onProductsFetchFailed;

		// Token: 0x04000034 RID: 52
		[Tooltip("Event fired after fetching purchases.")]
		public IAPListener.OnPurchasesFetchedEvent onPurchasesFetched;

		// Token: 0x04000035 RID: 53
		[Tooltip("Event fired after failing to fetch purchases.")]
		public IAPListener.OnPurchasesFetchFailureEvent onPurchasesFetchFailure;

		// Token: 0x04000036 RID: 54
		[Tooltip("Event fired after updating a pending order.")]
		public IAPListener.OnOrderPendingEvent onOrderPending;

		// Token: 0x04000037 RID: 55
		[Tooltip("Event fired after updating a confirmed order.")]
		public IAPListener.OnOrderConfirmedEvent onOrderConfirmed;

		// Token: 0x04000038 RID: 56
		[Tooltip("Event fired after failing to purchase an order.")]
		public IAPListener.OnPurchaseFailedEvent onPurchaseFailed;

		// Token: 0x04000039 RID: 57
		[Tooltip("Event fired after the payment of a purchase was delayed or postponed.")]
		public IAPListener.OnOrderDeferredEvent onOrderDeferred;

		// Token: 0x0400003A RID: 58
		[Header("Obsolete Events (for backward compatibility only)")]
		[FormerlySerializedAs("onProductsFetched")]
		[Tooltip("Event fired after a successful fetching the products from the store.")]
		[Obsolete]
		public IAPListener.OnProductsFetchedLegacyEvent onProductsFetchedLegacy;

		// Token: 0x0400003B RID: 59
		[FormerlySerializedAs("onPurchaseComplete")]
		[Tooltip("Event fired after a successful purchase of this product.")]
		[Obsolete]
		public IAPListener.OnPurchaseCompletedLegacyEvent onPurchaseCompleteLegacy;

		// Token: 0x0400003C RID: 60
		[FormerlySerializedAs("onPurchaseFailed")]
		[Tooltip("Event fired after failing to purchase an order.")]
		[Obsolete]
		public IAPListener.OnPurchaseFailedLegacyEvent onPurchaseFailedLegacy;

		// Token: 0x0400003D RID: 61
		[FormerlySerializedAs("onPurchaseDetailedFailedEvent")]
		[Tooltip("Event fired after failing to purchase an order.")]
		[Obsolete]
		public IAPListener.OnPurchaseDetailedFailedLegacyEvent onPurchaseDetailedFailedLegacy;

		// Token: 0x0200002D RID: 45
		[Serializable]
		public class OnProductsFetchedEvent : UnityEvent<List<Product>>
		{
		}

		// Token: 0x0200002E RID: 46
		[Serializable]
		public class OnProductsFetchFailedEvent : UnityEvent<ProductFetchFailed>
		{
		}

		// Token: 0x0200002F RID: 47
		[Serializable]
		public class OnPurchasesFetchedEvent : UnityEvent<Orders>
		{
		}

		// Token: 0x02000030 RID: 48
		[Serializable]
		public class OnPurchasesFetchFailureEvent : UnityEvent<PurchasesFetchFailureDescription>
		{
		}

		// Token: 0x02000031 RID: 49
		[Serializable]
		public class OnOrderPendingEvent : UnityEvent<PendingOrder>
		{
		}

		// Token: 0x02000032 RID: 50
		[Serializable]
		public class OnOrderConfirmedEvent : UnityEvent<ConfirmedOrder>
		{
		}

		// Token: 0x02000033 RID: 51
		[Serializable]
		public class OnPurchaseFailedEvent : UnityEvent<FailedOrder>
		{
		}

		// Token: 0x02000034 RID: 52
		[Serializable]
		public class OnOrderDeferredEvent : UnityEvent<DeferredOrder>
		{
		}

		// Token: 0x02000035 RID: 53
		[Obsolete]
		[Serializable]
		public class OnProductsFetchedLegacyEvent : UnityEvent<ProductCollection>
		{
		}

		// Token: 0x02000036 RID: 54
		[Obsolete]
		[Serializable]
		public class OnPurchaseCompletedLegacyEvent : UnityEvent<Product>
		{
		}

		// Token: 0x02000037 RID: 55
		[Obsolete]
		[Serializable]
		public class OnPurchaseFailedLegacyEvent : UnityEvent<Product, PurchaseFailureReason>
		{
		}

		// Token: 0x02000038 RID: 56
		[Obsolete]
		[Serializable]
		public class OnPurchaseDetailedFailedLegacyEvent : UnityEvent<Product, PurchaseFailureDescription>
		{
		}
	}
}
