using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000027 RID: 39
	internal class SubscriptionChangeRequest
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00002F24 File Offset: 0x00001124
		internal Order CurrentOrder { get; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00002F2C File Offset: 0x0000112C
		internal Product NewSubscription { get; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00002F34 File Offset: 0x00001134
		internal GooglePlayReplacementMode ReplacementMode { get; }

		// Token: 0x060000A2 RID: 162 RVA: 0x00002F3C File Offset: 0x0000113C
		internal SubscriptionChangeRequest(Order currentOrder, Product newSubscription, GooglePlayReplacementMode replacementMode)
		{
			this.CurrentOrder = currentOrder;
			this.NewSubscription = newSubscription;
			this.ReplacementMode = replacementMode;
		}

		// Token: 0x04000028 RID: 40
		private readonly Action<DeferredPaymentUntilRenewalDateOrder> m_OnPurchaseDeferredUntilRenewalDate;
	}
}
