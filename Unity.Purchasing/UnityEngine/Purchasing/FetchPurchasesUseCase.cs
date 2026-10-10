using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000072 RID: 114
	internal class FetchPurchasesUseCase : IFetchPurchasesUseCase, IStorePurchaseFetchCallback
	{
		// Token: 0x14000026 RID: 38
		// (add) Token: 0x06000215 RID: 533 RVA: 0x00005FDC File Offset: 0x000041DC
		// (remove) Token: 0x06000216 RID: 534 RVA: 0x00006014 File Offset: 0x00004214
		private event Action<Orders> FetchSuccessAction;

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x06000217 RID: 535 RVA: 0x0000604C File Offset: 0x0000424C
		// (remove) Token: 0x06000218 RID: 536 RVA: 0x00006084 File Offset: 0x00004284
		private event Action<PurchasesFetchFailureDescription> FetchFailureAction;

		// Token: 0x06000219 RID: 537 RVA: 0x000060B9 File Offset: 0x000042B9
		[Preserve]
		internal FetchPurchasesUseCase(IStore storeResponsible)
		{
			this.m_Store = storeResponsible;
			this.m_Store.SetPurchaseFetchCallback(this);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000060D4 File Offset: 0x000042D4
		public void FetchPurchases(Action<Orders> fetchSuccessAction, Action<PurchasesFetchFailureDescription> fetchFailureAction)
		{
			this.FetchSuccessAction = fetchSuccessAction;
			this.FetchFailureAction = fetchFailureAction;
			this.m_Store.FetchPurchases();
		}

		// Token: 0x0600021B RID: 539 RVA: 0x000060F0 File Offset: 0x000042F0
		public void OnAllPurchasesRetrieved(IReadOnlyList<Order> orders)
		{
			IReadOnlyList<ConfirmedOrder> confirmedOrders = orders.OfType<ConfirmedOrder>().ToList<ConfirmedOrder>().AsReadOnly();
			ReadOnlyCollection<PendingOrder> pendingOrders = orders.OfType<PendingOrder>().ToList<PendingOrder>().AsReadOnly();
			ReadOnlyCollection<DeferredOrder> deferredOrders = orders.OfType<DeferredOrder>().ToList<DeferredOrder>().AsReadOnly();
			Orders obj = new Orders(confirmedOrders, pendingOrders, deferredOrders);
			Action<Orders> fetchSuccessAction = this.FetchSuccessAction;
			if (fetchSuccessAction == null)
			{
				return;
			}
			fetchSuccessAction(obj);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00006148 File Offset: 0x00004348
		public void OnPurchasesRetrievalFailed(PurchasesFetchFailureDescription failureReason)
		{
			Action<PurchasesFetchFailureDescription> fetchFailureAction = this.FetchFailureAction;
			if (fetchFailureAction == null)
			{
				return;
			}
			fetchFailureAction(failureReason);
		}

		// Token: 0x040000A7 RID: 167
		private readonly IStore m_Store;
	}
}
