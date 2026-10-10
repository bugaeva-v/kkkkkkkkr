using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000007 RID: 7
	internal interface IAnalyticsAdapter
	{
		// Token: 0x0600000B RID: 11
		void SendTransactionEvent(CartItem item, string receipt);

		// Token: 0x0600000C RID: 12
		void SendTransactionFailedEvent(PurchaseFailureDescription failureDescription);
	}
}
