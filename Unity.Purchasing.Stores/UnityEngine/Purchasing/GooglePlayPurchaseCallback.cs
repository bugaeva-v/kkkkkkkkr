using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Uniject;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000022 RID: 34
	[NullableContext(1)]
	[Nullable(0)]
	internal class GooglePlayPurchaseCallback : IGooglePurchaseCallback
	{
		// Token: 0x0600009F RID: 159 RVA: 0x00004133 File Offset: 0x00002333
		[Preserve]
		internal GooglePlayPurchaseCallback(IGooglePurchaseConverter googlePurchaseConverter, IUtil util)
		{
			this.m_GooglePurchaseConverter = googlePurchaseConverter;
			this.m_Util = util;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00004149 File Offset: 0x00002349
		public void SetProductCache(IProductCache productCache)
		{
			this.m_ProductCache = productCache;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00004152 File Offset: 0x00002352
		public void SetPurchaseCallback(IStorePurchaseCallback purchaseCallback)
		{
			this.m_PurchaseCallback = purchaseCallback;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000415B File Offset: 0x0000235B
		public void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchCallback)
		{
			this.m_PurchaseFetchCallback = fetchCallback;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00004164 File Offset: 0x00002364
		public void SetChangeSubscriptionCallback(IGooglePlayChangeSubscriptionCallback changeSubscriptionCallback)
		{
			this.m_ChangeSubscriptionCallback = changeSubscriptionCallback;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00004170 File Offset: 0x00002370
		public void OnPurchaseSuccessful(IGooglePurchase purchase)
		{
			Order order = this.m_GooglePurchaseConverter.CreateOrderFromPurchase(purchase, this.m_ProductCache);
			this.OnOrderPurchaseSuccessful(order);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00004198 File Offset: 0x00002398
		private void OnOrderPurchaseSuccessful(Order order)
		{
			PendingOrder pendingOrder = order as PendingOrder;
			if (pendingOrder == null)
			{
				ConfirmedOrder confirmedOrder = order as ConfirmedOrder;
				if (confirmedOrder != null)
				{
					IStorePurchaseFetchCallback purchaseFetchCallback = this.m_PurchaseFetchCallback;
					if (purchaseFetchCallback == null)
					{
						return;
					}
					purchaseFetchCallback.OnAllPurchasesRetrieved(new List<ConfirmedOrder>
					{
						confirmedOrder
					});
				}
				return;
			}
			IStorePurchaseCallback purchaseCallback = this.m_PurchaseCallback;
			if (purchaseCallback == null)
			{
				return;
			}
			purchaseCallback.OnPurchaseSucceeded(pendingOrder);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000041E7 File Offset: 0x000023E7
		public void OnPurchaseFailed(PurchaseFailureDescription purchaseFailureDescription)
		{
			IStorePurchaseCallback purchaseCallback = this.m_PurchaseCallback;
			if (purchaseCallback == null)
			{
				return;
			}
			purchaseCallback.OnPurchaseFailed(purchaseFailureDescription.ConvertToFailedOrder(""));
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00004204 File Offset: 0x00002404
		public void NotifyDeferredPurchase(IGooglePurchase purchase)
		{
			DeferredOrder deferredOrder = (DeferredOrder)this.m_GooglePurchaseConverter.CreateOrderFromPurchase(purchase, this.m_ProductCache);
			IStorePurchaseCallback purchaseCallback = this.m_PurchaseCallback;
			if (purchaseCallback == null)
			{
				return;
			}
			purchaseCallback.OnPurchaseDeferred(deferredOrder);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000423A File Offset: 0x0000243A
		public void NotifyDeferredProrationUpgradeDowngradeSubscription(string sku)
		{
			IGooglePlayChangeSubscriptionCallback changeSubscriptionCallback = this.m_ChangeSubscriptionCallback;
			if (changeSubscriptionCallback == null)
			{
				return;
			}
			changeSubscriptionCallback.OnSubscriptionChangeDeferredUntilRenewal(sku);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000424D File Offset: 0x0000244D
		public void NotifyUpgradeDowngradeSubscription(string sku)
		{
			IGooglePlayChangeSubscriptionCallback changeSubscriptionCallback = this.m_ChangeSubscriptionCallback;
			if (changeSubscriptionCallback == null)
			{
				return;
			}
			changeSubscriptionCallback.OnSubscriptionChange(sku);
		}

		// Token: 0x04000049 RID: 73
		[Nullable(2)]
		private IProductCache m_ProductCache;

		// Token: 0x0400004A RID: 74
		[Nullable(2)]
		private IStorePurchaseCallback m_PurchaseCallback;

		// Token: 0x0400004B RID: 75
		[Nullable(2)]
		private IStorePurchaseFetchCallback m_PurchaseFetchCallback;

		// Token: 0x0400004C RID: 76
		[Nullable(2)]
		private IGooglePlayChangeSubscriptionCallback m_ChangeSubscriptionCallback;

		// Token: 0x0400004D RID: 77
		private readonly IGooglePurchaseConverter m_GooglePurchaseConverter;

		// Token: 0x0400004E RID: 78
		private readonly IUtil m_Util;
	}
}
