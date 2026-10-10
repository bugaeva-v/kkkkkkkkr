using System;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000009 RID: 9
	[NullableContext(2)]
	[Nullable(0)]
	[RequireComponent(typeof(Button))]
	[AddComponentMenu("In-App Purchasing/IAP Button")]
	[HelpURL("https://docs.unity.com/ugs/en-us/manual/iap/manual/overview")]
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public class IAPButton : MonoBehaviour
	{
		// Token: 0x0600005B RID: 91 RVA: 0x00003610 File Offset: 0x00001810
		[NullableContext(1)]
		public void OnProductFetched(Product product)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003617 File Offset: 0x00001817
		[NullableContext(1)]
		public void OnProductFetchFailed(ProductDefinition product, string failureReason)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000361E File Offset: 0x0000181E
		[NullableContext(1)]
		public void OnPurchaseFetched(Order order)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003625 File Offset: 0x00001825
		private void OnTransactionsRestored(bool success, string error)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000362C File Offset: 0x0000182C
		[NullableContext(1)]
		public void OnOrderPending(PendingOrder order)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003633 File Offset: 0x00001833
		[NullableContext(1)]
		public void OnOrderConfirmed(ConfirmedOrder order)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000363A File Offset: 0x0000183A
		[NullableContext(1)]
		public void OnPurchaseFailed(FailedOrder failedOrder)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003641 File Offset: 0x00001841
		[NullableContext(1)]
		public void OnOrderDeferred(DeferredOrder deferredOrder)
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000022 RID: 34
		[HideInInspector]
		public string productId;

		// Token: 0x04000023 RID: 35
		[Tooltip("The type of this button, can be either a purchase or a restore button.")]
		public IAPButton.ButtonType buttonType;

		// Token: 0x04000024 RID: 36
		[Tooltip("Consume the product immediately after a successful purchase.")]
		public bool consumePurchase = true;

		// Token: 0x04000025 RID: 37
		[Tooltip("Event fired after fetching a product.")]
		public IAPButton.OnProductFetchedEvent onProductFetched;

		// Token: 0x04000026 RID: 38
		[Tooltip("Event fired after failing to fetch a product.")]
		public IAPButton.OnProductFetchFailedEvent onProductFetchFailed;

		// Token: 0x04000027 RID: 39
		[Tooltip("Event fired after fetching a purchase.")]
		public IAPButton.OnPurchaseFetchedEvent onPurchaseFetched;

		// Token: 0x04000028 RID: 40
		[Tooltip("Event fired after a restore transactions.")]
		public IAPButton.OnTransactionsRestoredEvent onTransactionsRestored;

		// Token: 0x04000029 RID: 41
		[Tooltip("Event fired after a pending order.")]
		public IAPButton.OnOrderPendingEvent onOrderPending;

		// Token: 0x0400002A RID: 42
		[Tooltip("Event fired after a confirmed order.")]
		public IAPButton.OnOrderConfirmedEvent onOrderConfirmed;

		// Token: 0x0400002B RID: 43
		[Tooltip("Event fired after a failed purchase of this product.")]
		public IAPButton.OnPurchaseFailedEvent onPurchaseFailed;

		// Token: 0x0400002C RID: 44
		[Tooltip("Event fired after the payment of a purchase was delayed or postponed for this product.")]
		public IAPButton.OnOrderDeferredEvent onOrderDeferred;

		// Token: 0x0400002D RID: 45
		[Tooltip("[Optional] Displays the localized title from the app store.")]
		public Text titleText;

		// Token: 0x0400002E RID: 46
		[Tooltip("[Optional] Displays the localized description from the app store.")]
		public Text descriptionText;

		// Token: 0x0400002F RID: 47
		[Tooltip("[Optional] Displays the localized price from the app store.")]
		public Text priceText;

		// Token: 0x02000024 RID: 36
		[NullableContext(0)]
		public enum ButtonType
		{
			// Token: 0x04000062 RID: 98
			Purchase,
			// Token: 0x04000063 RID: 99
			Restore
		}

		// Token: 0x02000025 RID: 37
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Serializable]
		public class OnProductFetchedEvent : UnityEvent<Product>
		{
		}

		// Token: 0x02000026 RID: 38
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		[Serializable]
		public class OnProductFetchFailedEvent : UnityEvent<ProductDefinition, string>
		{
		}

		// Token: 0x02000027 RID: 39
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Serializable]
		public class OnPurchaseFetchedEvent : UnityEvent<Order>
		{
		}

		// Token: 0x02000028 RID: 40
		[Nullable(new byte[]
		{
			0,
			2
		})]
		[Serializable]
		public class OnTransactionsRestoredEvent : UnityEvent<bool, string>
		{
		}

		// Token: 0x02000029 RID: 41
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Serializable]
		public class OnOrderPendingEvent : UnityEvent<PendingOrder>
		{
		}

		// Token: 0x0200002A RID: 42
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Serializable]
		public class OnOrderConfirmedEvent : UnityEvent<ConfirmedOrder>
		{
		}

		// Token: 0x0200002B RID: 43
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Serializable]
		public class OnPurchaseFailedEvent : UnityEvent<FailedOrder>
		{
		}

		// Token: 0x0200002C RID: 44
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Serializable]
		public class OnOrderDeferredEvent : UnityEvent<DeferredOrder>
		{
		}
	}
}
