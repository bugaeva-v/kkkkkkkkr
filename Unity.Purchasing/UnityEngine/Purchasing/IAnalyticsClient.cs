using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000008 RID: 8
	internal interface IAnalyticsClient
	{
		// Token: 0x0600000D RID: 13
		void OnPurchaseSucceeded(ConfirmedOrder confirmedOrder);

		// Token: 0x0600000E RID: 14
		void OnPurchaseFailed(FailedOrder failedOrder);
	}
}
