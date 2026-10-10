using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200004E RID: 78
	public class DeferredPaymentUntilRenewalDateOrder
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00003ACB File Offset: 0x00001CCB
		public Order CurrentOrder { get; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00003AD3 File Offset: 0x00001CD3
		public Product SubscriptionOrdered { get; }

		// Token: 0x06000147 RID: 327 RVA: 0x00003ADB File Offset: 0x00001CDB
		public DeferredPaymentUntilRenewalDateOrder(Order currentOrder, Product subscriptionOrdered)
		{
			this.CurrentOrder = currentOrder;
			this.SubscriptionOrdered = subscriptionOrdered;
		}
	}
}
