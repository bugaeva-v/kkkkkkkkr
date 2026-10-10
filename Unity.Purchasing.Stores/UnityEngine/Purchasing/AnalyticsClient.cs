using System;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000006 RID: 6
	internal class AnalyticsClient : IAnalyticsClient
	{
		// Token: 0x06000007 RID: 7 RVA: 0x0000208E File Offset: 0x0000028E
		[Preserve]
		internal AnalyticsClient(IAnalyticsAdapter analytics)
		{
			this.m_Analytics = analytics;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020A0 File Offset: 0x000002A0
		public void OnPurchaseSucceeded(ConfirmedOrder confirmedOrder)
		{
			foreach (CartItem item in confirmedOrder.CartOrdered.Items())
			{
				this.m_Analytics.SendTransactionEvent(item, confirmedOrder.Info.Receipt);
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002104 File Offset: 0x00000304
		public void OnPurchaseFailed(FailedOrder failedOrder)
		{
			foreach (CartItem cartItem in failedOrder.CartOrdered.Items())
			{
				PurchaseFailureDescription failureDescription = new PurchaseFailureDescription(cartItem.Product, failedOrder.FailureReason, failedOrder.Details);
				this.m_Analytics.SendTransactionFailedEvent(failureDescription);
			}
		}

		// Token: 0x04000003 RID: 3
		private readonly IAnalyticsAdapter m_Analytics;
	}
}
