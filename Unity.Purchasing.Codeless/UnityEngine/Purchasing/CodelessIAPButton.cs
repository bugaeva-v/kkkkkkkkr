using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000007 RID: 7
	[NullableContext(2)]
	[Nullable(0)]
	[AddComponentMenu("In-App Purchasing/IAP Button")]
	[HelpURL("https://docs.unity.com/ugs/en-us/manual/iap/manual/overview")]
	public class CodelessIAPButton : MonoBehaviour
	{
		// Token: 0x06000006 RID: 6 RVA: 0x000021CC File Offset: 0x000003CC
		private void Start()
		{
			if (this.IsAPurchaseButton())
			{
				this.AddPurchaseButtonListener();
				return;
			}
			if (this.IsARestoreButton())
			{
				this.AddRestoreButtonListener();
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000021EC File Offset: 0x000003EC
		private void AddPurchaseButtonListener()
		{
			Button button = this.GetButton();
			if (button != null)
			{
				button.onClick.AddListener(new UnityAction(this.PurchaseProduct));
			}
			if (string.IsNullOrEmpty(this.productId))
			{
				Debug.LogError("IAPButton productId is empty");
				return;
			}
			if (!CodelessIAPStoreListener.Instance.HasProductInCatalog(this.productId))
			{
				Debug.LogWarning("The product catalog has no product with the ID \"" + this.productId + "\"");
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000225F File Offset: 0x0000045F
		private void AddRestoreButtonListener()
		{
			Button button = this.GetButton();
			if (button == null)
			{
				return;
			}
			button.onClick.AddListener(new UnityAction(this.Restore));
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002282 File Offset: 0x00000482
		private void OnEnable()
		{
			if (this.IsAPurchaseButton())
			{
				this.AddButtonToCodelessListener();
				if (CodelessIAPStoreListener.Instance.IsInitialized())
				{
					this.OnInitCompleted();
				}
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000022A4 File Offset: 0x000004A4
		private void OnDisable()
		{
			if (this.IsAPurchaseButton())
			{
				this.RemoveButtonToCodelessListener();
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000022B4 File Offset: 0x000004B4
		private void PurchaseProduct()
		{
			if (this.IsAPurchaseButton())
			{
				CodelessIAPStoreListener.Instance.InitiatePurchase(this.productId);
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000022CE File Offset: 0x000004CE
		private void Restore()
		{
			if (this.IsARestoreButton())
			{
				UnityIAPServices.DefaultPurchase().RestoreTransactions(new Action<bool, string>(this.OnTransactionsRestored));
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000022EE File Offset: 0x000004EE
		internal bool IsAPurchaseButton()
		{
			return this.buttonType == CodelessButtonType.Purchase;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000022F9 File Offset: 0x000004F9
		private bool IsARestoreButton()
		{
			return this.buttonType == CodelessButtonType.Restore;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002304 File Offset: 0x00000504
		[NullableContext(1)]
		public void OnProductFetched(Product product)
		{
			CodelessIAPButton.OnProductFetchedEvent onProductFetchedEvent = this.onProductFetched;
			if (onProductFetchedEvent == null)
			{
				return;
			}
			onProductFetchedEvent.Invoke(product);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002317 File Offset: 0x00000517
		[NullableContext(1)]
		public void OnProductFetchFailed(ProductDefinition product, string failureReason)
		{
			CodelessIAPButton.OnProductFetchFailedEvent onProductFetchFailedEvent = this.onProductFetchFailed;
			if (onProductFetchFailedEvent == null)
			{
				return;
			}
			onProductFetchFailedEvent.Invoke(product, failureReason);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000232B File Offset: 0x0000052B
		[NullableContext(1)]
		public void OnPurchaseFetched(Order order)
		{
			CodelessIAPButton.OnPurchaseFetchedEvent onPurchaseFetchedEvent = this.onPurchaseFetched;
			if (onPurchaseFetchedEvent == null)
			{
				return;
			}
			onPurchaseFetchedEvent.Invoke(order);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000233E File Offset: 0x0000053E
		public void OnTransactionsRestored(bool success, string error)
		{
			CodelessIAPButton.OnTransactionsRestoredEvent onTransactionsRestoredEvent = this.onTransactionsRestored;
			if (onTransactionsRestoredEvent == null)
			{
				return;
			}
			onTransactionsRestoredEvent.Invoke(success, error);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002354 File Offset: 0x00000554
		[NullableContext(1)]
		public void OnOrderPending(PendingOrder order)
		{
			CodelessIAPButton.OnOrderPendingEvent onOrderPendingEvent = this.onOrderPending;
			if (onOrderPendingEvent != null)
			{
				onOrderPendingEvent.Invoke(order);
			}
			CartItem cartItem2 = order.CartOrdered.Items().FirstOrDefault((CartItem cartItem) => cartItem.Product.definition.id == this.productId);
			if (cartItem2 != null)
			{
				CodelessIAPButton.OnPurchaseCompletedLegacyEvent onPurchaseCompletedLegacyEvent = this.onPurchaseCompleteLegacy;
				if (onPurchaseCompletedLegacyEvent == null)
				{
					return;
				}
				onPurchaseCompletedLegacyEvent.Invoke(cartItem2.Product);
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000023A9 File Offset: 0x000005A9
		[NullableContext(1)]
		public void OnOrderConfirmed(ConfirmedOrder order)
		{
			CodelessIAPButton.OnOrderConfirmedEvent onOrderConfirmedEvent = this.onOrderConfirmed;
			if (onOrderConfirmedEvent == null)
			{
				return;
			}
			onOrderConfirmedEvent.Invoke(order);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000023BC File Offset: 0x000005BC
		[NullableContext(1)]
		public void OnPurchaseFailed(FailedOrder failedOrder)
		{
			CodelessIAPButton.OnPurchaseFailedEvent onPurchaseFailedEvent = this.onPurchaseFailed;
			if (onPurchaseFailedEvent != null)
			{
				onPurchaseFailedEvent.Invoke(failedOrder);
			}
			CartItem cartItem2 = failedOrder.CartOrdered.Items().FirstOrDefault((CartItem cartItem) => cartItem.Product.definition.id == this.productId);
			if (cartItem2 != null)
			{
				CodelessIAPButton.OnPurchaseFailedLegacyEvent onPurchaseFailedLegacyEvent = this.onPurchaseFailedLegacy;
				if (onPurchaseFailedLegacyEvent == null)
				{
					return;
				}
				onPurchaseFailedLegacyEvent.Invoke(cartItem2.Product, new PurchaseFailureDescription(cartItem2, failedOrder.FailureReason, failedOrder.Details));
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002423 File Offset: 0x00000623
		[NullableContext(1)]
		public void OnOrderDeferred(DeferredOrder deferredOrder)
		{
			CodelessIAPButton.OnOrderDeferredEvent onOrderDeferredEvent = this.onOrderDeferred;
			if (onOrderDeferredEvent == null)
			{
				return;
			}
			onOrderDeferredEvent.Invoke(deferredOrder);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002436 File Offset: 0x00000636
		private Button GetButton()
		{
			return this.button;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000243E File Offset: 0x0000063E
		private void AddButtonToCodelessListener()
		{
			CodelessIAPStoreListener.Instance.AddButton(this);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000244B File Offset: 0x0000064B
		private void RemoveButtonToCodelessListener()
		{
			CodelessIAPStoreListener.Instance.RemoveButton(this);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002458 File Offset: 0x00000658
		internal void OnInitCompleted()
		{
			Product product = CodelessIAPStoreListener.Instance.GetProduct(this.productId);
			if (product != null)
			{
				CodelessIAPButton.OnProductFetchedEvent onProductFetchedEvent = this.onProductFetched;
				if (onProductFetchedEvent == null)
				{
					return;
				}
				onProductFetchedEvent.Invoke(product);
			}
		}

		// Token: 0x04000006 RID: 6
		[HideInInspector]
		public string productId;

		// Token: 0x04000007 RID: 7
		[Tooltip("The type of this button, can be either a purchase or a restore button.")]
		public CodelessButtonType buttonType;

		// Token: 0x04000008 RID: 8
		[FormerlySerializedAs("consumePurchase")]
		[Tooltip("Automatically confirm the transaction immediately after a successful purchase.")]
		public bool automaticallyConfirmTransaction = true;

		// Token: 0x04000009 RID: 9
		[Tooltip("Event fired after fetching a product.")]
		public CodelessIAPButton.OnProductFetchedEvent onProductFetched;

		// Token: 0x0400000A RID: 10
		[Tooltip("Event fired after failing to fetch a product.")]
		public CodelessIAPButton.OnProductFetchFailedEvent onProductFetchFailed;

		// Token: 0x0400000B RID: 11
		[Tooltip("Event fired after fetching a purchase.")]
		public CodelessIAPButton.OnPurchaseFetchedEvent onPurchaseFetched;

		// Token: 0x0400000C RID: 12
		[Tooltip("Event fired after a restore transactions.")]
		public CodelessIAPButton.OnTransactionsRestoredEvent onTransactionsRestored;

		// Token: 0x0400000D RID: 13
		[Tooltip("Event fired after a pending order.")]
		public CodelessIAPButton.OnOrderPendingEvent onOrderPending;

		// Token: 0x0400000E RID: 14
		[Tooltip("Event fired after a confirmed order.")]
		public CodelessIAPButton.OnOrderConfirmedEvent onOrderConfirmed;

		// Token: 0x0400000F RID: 15
		[Tooltip("Event fired after a failed purchase of this product.")]
		public CodelessIAPButton.OnPurchaseFailedEvent onPurchaseFailed;

		// Token: 0x04000010 RID: 16
		[Tooltip("Event fired after the payment of a purchase was delayed or postponed for this product.")]
		public CodelessIAPButton.OnOrderDeferredEvent onOrderDeferred;

		// Token: 0x04000011 RID: 17
		[Header("Obsolete Events (for backward compatibility only)")]
		[FormerlySerializedAs("onPurchaseComplete")]
		[Tooltip("Event fired after a successful purchase of this product.")]
		[Obsolete]
		public CodelessIAPButton.OnPurchaseCompletedLegacyEvent onPurchaseCompleteLegacy;

		// Token: 0x04000012 RID: 18
		[FormerlySerializedAs("onPurchaseFailed")]
		[Tooltip("Event fired after failing to purchase an order.")]
		[Obsolete]
		public CodelessIAPButton.OnPurchaseFailedLegacyEvent onPurchaseFailedLegacy;

		// Token: 0x04000013 RID: 19
		[Tooltip("Button that triggers purchase.")]
		public Button button;

		// Token: 0x0200000B RID: 11
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Serializable]
		public class OnProductFetchedEvent : UnityEvent<Product>
		{
		}

		// Token: 0x0200000C RID: 12
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

		// Token: 0x0200000D RID: 13
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Serializable]
		public class OnPurchaseFetchedEvent : UnityEvent<Order>
		{
		}

		// Token: 0x0200000E RID: 14
		[Nullable(new byte[]
		{
			0,
			2
		})]
		[Serializable]
		public class OnTransactionsRestoredEvent : UnityEvent<bool, string>
		{
		}

		// Token: 0x0200000F RID: 15
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Serializable]
		public class OnOrderPendingEvent : UnityEvent<PendingOrder>
		{
		}

		// Token: 0x02000010 RID: 16
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Serializable]
		public class OnOrderConfirmedEvent : UnityEvent<ConfirmedOrder>
		{
		}

		// Token: 0x02000011 RID: 17
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Serializable]
		public class OnPurchaseFailedEvent : UnityEvent<FailedOrder>
		{
		}

		// Token: 0x02000012 RID: 18
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Serializable]
		public class OnOrderDeferredEvent : UnityEvent<DeferredOrder>
		{
		}

		// Token: 0x02000013 RID: 19
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[Obsolete]
		[Serializable]
		public class OnPurchaseCompletedLegacyEvent : UnityEvent<Product>
		{
		}

		// Token: 0x02000014 RID: 20
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		[Obsolete]
		[Serializable]
		public class OnPurchaseFailedLegacyEvent : UnityEvent<Product, PurchaseFailureDescription>
		{
		}
	}
}
