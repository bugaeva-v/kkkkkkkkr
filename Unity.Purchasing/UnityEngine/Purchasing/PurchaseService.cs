using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200006A RID: 106
	[NullableContext(1)]
	[Nullable(0)]
	public class PurchaseService : IPurchaseService
	{
		// Token: 0x060001CE RID: 462 RVA: 0x00004DF4 File Offset: 0x00002FF4
		public void ProcessPendingOrdersOnPurchasesFetched(bool shouldProcess)
		{
			this.m_ProcessFetchedPendingOrders = shouldProcess;
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x060001CF RID: 463 RVA: 0x00004E00 File Offset: 0x00003000
		// (remove) Token: 0x060001D0 RID: 464 RVA: 0x00004E38 File Offset: 0x00003038
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
		public event Action<PendingOrder> OnPurchasePending;

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x060001D1 RID: 465 RVA: 0x00004E70 File Offset: 0x00003070
		// (remove) Token: 0x060001D2 RID: 466 RVA: 0x00004EA8 File Offset: 0x000030A8
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
		public event Action<Order> OnPurchaseConfirmed;

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x060001D3 RID: 467 RVA: 0x00004EE0 File Offset: 0x000030E0
		// (remove) Token: 0x060001D4 RID: 468 RVA: 0x00004F18 File Offset: 0x00003118
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
		public event Action<FailedOrder> OnPurchaseFailed;

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x060001D5 RID: 469 RVA: 0x00004F50 File Offset: 0x00003150
		// (remove) Token: 0x060001D6 RID: 470 RVA: 0x00004F88 File Offset: 0x00003188
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
		public event Action<DeferredOrder> OnPurchaseDeferred;

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x060001D7 RID: 471 RVA: 0x00004FC0 File Offset: 0x000031C0
		// (remove) Token: 0x060001D8 RID: 472 RVA: 0x00004FF8 File Offset: 0x000031F8
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
		public event Action<Orders> OnPurchasesFetched;

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x060001D9 RID: 473 RVA: 0x00005030 File Offset: 0x00003230
		// (remove) Token: 0x060001DA RID: 474 RVA: 0x00005068 File Offset: 0x00003268
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
		public event Action<PurchasesFetchFailureDescription> OnPurchasesFetchFailed;

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x060001DB RID: 475 RVA: 0x000050A0 File Offset: 0x000032A0
		// (remove) Token: 0x060001DC RID: 476 RVA: 0x000050D8 File Offset: 0x000032D8
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
		public event Action<Entitlement> OnCheckEntitlement;

		// Token: 0x060001DD RID: 477 RVA: 0x00005110 File Offset: 0x00003310
		internal PurchaseService(IFetchPurchasesUseCase fetchPurchasesUseCase, IPurchaseUseCase purchaseUseCase, IConfirmOrderUseCase confirmOrderUseCase, ICheckEntitlementUseCase checkEntitlementUseCase, IStoreWrapper storeWrapper, IAnalyticsClient analyticsClient)
		{
			this.m_FetchPurchasesUseCase = fetchPurchasesUseCase;
			this.m_PurchaseUseCase = purchaseUseCase;
			this.m_ConfirmOrderUseCase = confirmOrderUseCase;
			this.m_CheckEntitlementUseCase = checkEntitlementUseCase;
			this.m_PurchasesReadOnly = new ReadOnlyObservableCollection<Order>(this.m_Purchases);
			purchaseUseCase.OnPurchaseSuccess += this.PurchaseSucceeded;
			purchaseUseCase.OnPurchaseFail += this.PurchaseFailed;
			purchaseUseCase.OnPurchaseDefer += this.PurchaseDeferred;
			this.m_StoreWrapper = storeWrapper;
			this.m_AnalyticsClient = analyticsClient;
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001DE RID: 478 RVA: 0x000051B4 File Offset: 0x000033B4
		[Nullable(2)]
		public IAppleStoreExtendedPurchaseService Apple
		{
			[NullableContext(2)]
			get
			{
				return this as IAppleStoreExtendedPurchaseService;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001DF RID: 479 RVA: 0x000051BC File Offset: 0x000033BC
		[Nullable(2)]
		public IGooglePlayStoreExtendedPurchaseService Google
		{
			[NullableContext(2)]
			get
			{
				return this as IGooglePlayStoreExtendedPurchaseService;
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000051C4 File Offset: 0x000033C4
		public void PurchaseProduct(Product product)
		{
			try
			{
				Cart cart = new Cart(product);
				this.Purchase(cart);
			}
			catch (InvalidCartItemException ex)
			{
				Action<FailedOrder> onPurchaseFailed = this.OnPurchaseFailed;
				if (onPurchaseFailed != null)
				{
					onPurchaseFailed(new FailedOrder(new Cart(Product.CreateUnknownProduct("InvalidProduct")), PurchaseFailureReason.ProductUnavailable, "Attempting to purchase an invalid product: " + ex.Message));
				}
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00005234 File Offset: 0x00003434
		public void Purchase(ICart cart)
		{
			if (this.IsStoreConnected())
			{
				try
				{
					this.m_PurchaseUseCase.Purchase(cart);
				}
				catch (Exception ex)
				{
					Action<FailedOrder> onPurchaseFailed = this.OnPurchaseFailed;
					if (onPurchaseFailed != null)
					{
						onPurchaseFailed(new FailedOrder(cart, PurchaseFailureReason.Unknown, ex.Message));
					}
				}
				return;
			}
			Action<FailedOrder> onPurchaseFailed2 = this.OnPurchaseFailed;
			if (onPurchaseFailed2 == null)
			{
				return;
			}
			onPurchaseFailed2(new FailedOrder(cart, PurchaseFailureReason.StoreNotConnected, "Store is not connected. Please check your internet connection and try again."));
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x000052A8 File Offset: 0x000034A8
		internal void PurchaseSucceeded(PendingOrder order)
		{
			try
			{
				this.RemoveDeferredOrders(order);
				this.RemovePendingOrders(order);
				this.m_Purchases.Add(order);
				this.ProcessPendingOrder(order);
			}
			catch (Exception exception)
			{
				Debug.unityLogger.LogException(exception);
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x000052F8 File Offset: 0x000034F8
		private void RemovePendingOrders(PendingOrder order)
		{
			foreach (PendingOrder item in from pendingOrder in this.m_Purchases.OfType<PendingOrder>().ToList<PendingOrder>().AsReadOnly()
			where object.Equals(order.Info.TransactionID, pendingOrder.Info.TransactionID)
			select pendingOrder)
			{
				this.m_Purchases.Remove(item);
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00005378 File Offset: 0x00003578
		private void RemoveDeferredOrders(PendingOrder pendingOrder)
		{
			ICart pendingOrderItems = pendingOrder.CartOrdered;
			foreach (Order item in (from deferredOrder in this.m_Purchases.OfType<DeferredOrder>().ToList<DeferredOrder>().AsReadOnly()
			where object.Equals(deferredOrder.CartOrdered, pendingOrderItems)
			select deferredOrder).Cast<Order>().ToList<Order>())
			{
				this.m_Purchases.Remove(item);
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00005410 File Offset: 0x00003610
		internal void PurchaseFailed(FailedOrder order)
		{
			this.m_AnalyticsClient.OnPurchaseFailed(order);
			Action<FailedOrder> onPurchaseFailed = this.OnPurchaseFailed;
			if (onPurchaseFailed == null)
			{
				return;
			}
			onPurchaseFailed(order);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000542F File Offset: 0x0000362F
		private void PurchaseDeferred(DeferredOrder order)
		{
			this.m_Purchases.Add(order);
			Action<DeferredOrder> onPurchaseDeferred = this.OnPurchaseDeferred;
			if (onPurchaseDeferred == null)
			{
				return;
			}
			onPurchaseDeferred(order);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00005450 File Offset: 0x00003650
		public void ConfirmPurchase(PendingOrder order)
		{
			FailedOrder failedOrder = this.ConfirmPurchaseValidations(order);
			if (failedOrder != null)
			{
				this.OnConfirmFailed(failedOrder);
				return;
			}
			try
			{
				this.m_ConfirmOrderUseCase.ConfirmOrder(order, delegate(PendingOrder pendingOrder, Order resultOrder)
				{
					ConfirmedOrder confirmedOrder = resultOrder as ConfirmedOrder;
					if (confirmedOrder != null)
					{
						this.OnConfirmSucceeded(pendingOrder, confirmedOrder);
						return;
					}
					FailedOrder failedOrder2 = resultOrder as FailedOrder;
					if (failedOrder2 == null)
					{
						this.OnConfirmFailed(new FailedOrder(pendingOrder, PurchaseFailureReason.Unknown, string.Format("Received invalid order type after confirmation: {0}", resultOrder.GetType())));
						return;
					}
					this.OnConfirmFailed(failedOrder2);
				});
			}
			catch (Exception ex)
			{
				this.OnConfirmFailed(new FailedOrder(order, PurchaseFailureReason.Unknown, ex.Message));
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000054B4 File Offset: 0x000036B4
		[return: Nullable(2)]
		private FailedOrder ConfirmPurchaseValidations(PendingOrder order)
		{
			if (order == null)
			{
				return new FailedOrder(new Cart(Product.CreateUnknownProduct("InvalidProduct")), PurchaseFailureReason.ProductUnavailable, "Attempting to confirm a null order.");
			}
			if (order.Info == null)
			{
				return new FailedOrder(order, PurchaseFailureReason.Unknown, "Order info is null");
			}
			if (string.IsNullOrEmpty(order.Info.TransactionID))
			{
				return new FailedOrder(order, PurchaseFailureReason.Unknown, "Transaction ID is null or empty");
			}
			if (!this.IsStoreConnected())
			{
				return new FailedOrder(order, PurchaseFailureReason.StoreNotConnected, "Unable to confirm purchase - store is not connected. Please check your internet connection and try again.");
			}
			return null;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00005530 File Offset: 0x00003730
		private void OnConfirmSucceeded(PendingOrder pendingOrder, ConfirmedOrder confirmedOrder)
		{
			this.RemovePendingOrders(pendingOrder);
			this.m_Purchases.Add(confirmedOrder);
			this.m_AnalyticsClient.OnPurchaseSucceeded(confirmedOrder);
			Action<Order> onPurchaseConfirmed = this.OnPurchaseConfirmed;
			if (onPurchaseConfirmed == null)
			{
				return;
			}
			onPurchaseConfirmed(confirmedOrder);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00005562 File Offset: 0x00003762
		private void OnConfirmFailed(FailedOrder failedOrder)
		{
			Action<Order> onPurchaseConfirmed = this.OnPurchaseConfirmed;
			if (onPurchaseConfirmed == null)
			{
				return;
			}
			onPurchaseConfirmed(failedOrder);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00005578 File Offset: 0x00003778
		public void FetchPurchases()
		{
			if (!this.IsStoreConnected())
			{
				this.OnFetchFailure(new PurchasesFetchFailureDescription(PurchasesFetchFailureReason.StoreNotConnected, "Store not connected."));
			}
			try
			{
				this.m_FetchPurchasesUseCase.FetchPurchases(new Action<Orders>(this.OnFetchSuccess), new Action<PurchasesFetchFailureDescription>(this.OnFetchFailure));
			}
			catch (Exception ex)
			{
				this.OnFetchFailure(new PurchasesFetchFailureDescription(PurchasesFetchFailureReason.Unknown, ex.Message));
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x000055EC File Offset: 0x000037EC
		private void OnFetchSuccess(Orders fetchedPurchases)
		{
			this.m_Purchases.Clear();
			foreach (ConfirmedOrder item in fetchedPurchases.ConfirmedOrders)
			{
				this.m_Purchases.Add(item);
			}
			foreach (PendingOrder pendingOrder in fetchedPurchases.PendingOrders)
			{
				this.m_Purchases.Add(pendingOrder);
				if (this.m_ProcessFetchedPendingOrders && !this.WasPurchaseAlreadyProcessed(pendingOrder.Info.TransactionID) && this.m_StoreWrapper.name == "GooglePlay")
				{
					this.ProcessPendingOrder(pendingOrder);
				}
			}
			foreach (DeferredOrder item2 in fetchedPurchases.DeferredOrders)
			{
				this.m_Purchases.Add(item2);
			}
			Action<Orders> onPurchasesFetched = this.OnPurchasesFetched;
			if (onPurchasesFetched == null)
			{
				return;
			}
			onPurchasesFetched(fetchedPurchases);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000571C File Offset: 0x0000391C
		private bool WasPurchaseAlreadyProcessed(string transactionId)
		{
			return this.m_PurchasesProcessedInSession.Contains(transactionId);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000572A File Offset: 0x0000392A
		private void ProcessPendingOrder(PendingOrder fetchedPurchase)
		{
			Action<PendingOrder> onPurchasePending = this.OnPurchasePending;
			if (onPurchasePending != null)
			{
				onPurchasePending(fetchedPurchase);
			}
			this.m_PurchasesProcessedInSession.Add(fetchedPurchase.Info.TransactionID);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00005755 File Offset: 0x00003955
		private void OnFetchFailure(PurchasesFetchFailureDescription fetchFailed)
		{
			Action<PurchasesFetchFailureDescription> onPurchasesFetchFailed = this.OnPurchasesFetchFailed;
			if (onPurchasesFetchFailed == null)
			{
				return;
			}
			onPurchasesFetchFailed(fetchFailed);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00005768 File Offset: 0x00003968
		public void CheckEntitlement(Product product)
		{
			if (this.OnCheckEntitlement == null)
			{
				return;
			}
			if (!this.IsStoreConnected())
			{
				this.OnEntitlementChecked(new Entitlement(product, null, EntitlementStatus.Unknown, "Store is not connected."));
				return;
			}
			try
			{
				this.m_CheckEntitlementUseCase.IsProductEntitled(product, new Action<Entitlement>(this.OnEntitlementChecked));
			}
			catch (Exception ex)
			{
				this.OnEntitlementChecked(new Entitlement(product, null, EntitlementStatus.Unknown, "Exception during entitlement check: " + ex.Message));
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000057E8 File Offset: 0x000039E8
		private void OnEntitlementChecked(Entitlement entitlement)
		{
			this.UpdateEntitlementOrder(entitlement);
			Action<Entitlement> onCheckEntitlement = this.OnCheckEntitlement;
			if (onCheckEntitlement == null)
			{
				return;
			}
			onCheckEntitlement(entitlement);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00005804 File Offset: 0x00003A04
		private void UpdateEntitlementOrder(Entitlement entitlement)
		{
			if (entitlement.Product != null)
			{
				EntitlementStatus status = entitlement.Status;
				if (status - EntitlementStatus.EntitledUntilConsumed > 1)
				{
					if (status != EntitlementStatus.FullyEntitled)
					{
						return;
					}
				}
				else
				{
					using (IEnumerator<Order> enumerator = this.GetPurchases().GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Order order = enumerator.Current;
							PendingOrder pendingOrder = order as PendingOrder;
							if (pendingOrder != null)
							{
								CartItem cartItem = pendingOrder.CartOrdered.Items().First<CartItem>();
								if (((cartItem != null) ? cartItem.Product.definition.storeSpecificId : null) == entitlement.Product.definition.storeSpecificId)
								{
									entitlement.Order = pendingOrder;
									break;
								}
							}
						}
						return;
					}
				}
				foreach (Order order2 in this.GetPurchases())
				{
					ConfirmedOrder confirmedOrder = order2 as ConfirmedOrder;
					if (confirmedOrder != null)
					{
						CartItem cartItem2 = confirmedOrder.CartOrdered.Items().First<CartItem>();
						if (((cartItem2 != null) ? cartItem2.Product.definition.storeSpecificId : null) == entitlement.Product.definition.storeSpecificId)
						{
							entitlement.Order = confirmedOrder;
							break;
						}
					}
				}
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00005940 File Offset: 0x00003B40
		[NullableContext(2)]
		public void RestoreTransactions(Action<bool, string> callback)
		{
			if (this.IsStoreConnected())
			{
				try
				{
					Action<bool, string> callback2 = delegate(bool success, string error)
					{
						if (success)
						{
							this.FetchPurchases();
						}
						Action<bool, string> callback5 = callback;
						if (callback5 == null)
						{
							return;
						}
						callback5(success, error);
					};
					this.RestoreTransactionsInternal(callback2);
				}
				catch (Exception ex)
				{
					Action<bool, string> callback3 = callback;
					if (callback3 != null)
					{
						callback3(false, ex.Message);
					}
				}
				return;
			}
			Action<bool, string> callback4 = callback;
			if (callback4 == null)
			{
				return;
			}
			callback4(false, "Store not connected.");
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000059C4 File Offset: 0x00003BC4
		[NullableContext(2)]
		protected virtual void RestoreTransactionsInternal(Action<bool, string> callback)
		{
			if (callback != null)
			{
				callback(false, Application.platform.ToString() + " is not a supported platform for the restore button");
			}
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x000059F8 File Offset: 0x00003BF8
		public ReadOnlyObservableCollection<Order> GetPurchases()
		{
			return this.m_PurchasesReadOnly;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00005A00 File Offset: 0x00003C00
		internal bool IsStoreConnected()
		{
			return this.m_StoreWrapper.GetStoreConnectionState() == ConnectionState.Connected;
		}

		// Token: 0x0400008C RID: 140
		private readonly IFetchPurchasesUseCase m_FetchPurchasesUseCase;

		// Token: 0x0400008D RID: 141
		private readonly IPurchaseUseCase m_PurchaseUseCase;

		// Token: 0x0400008E RID: 142
		private readonly IConfirmOrderUseCase m_ConfirmOrderUseCase;

		// Token: 0x0400008F RID: 143
		private readonly ICheckEntitlementUseCase m_CheckEntitlementUseCase;

		// Token: 0x04000090 RID: 144
		internal readonly ObservableCollection<Order> m_Purchases = new ObservableCollection<Order>();

		// Token: 0x04000091 RID: 145
		private readonly ReadOnlyObservableCollection<Order> m_PurchasesReadOnly;

		// Token: 0x04000092 RID: 146
		private readonly IStoreWrapper m_StoreWrapper;

		// Token: 0x04000093 RID: 147
		private readonly IAnalyticsClient m_AnalyticsClient;

		// Token: 0x04000094 RID: 148
		private bool m_ProcessFetchedPendingOrders = true;

		// Token: 0x04000095 RID: 149
		private readonly HashSet<string> m_PurchasesProcessedInSession = new HashSet<string>();
	}
}
