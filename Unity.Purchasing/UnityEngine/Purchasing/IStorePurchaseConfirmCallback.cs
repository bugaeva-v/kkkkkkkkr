using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000039 RID: 57
	public interface IStorePurchaseConfirmCallback
	{
		// Token: 0x060000F4 RID: 244
		void OnConfirmOrderSucceeded(string transactionId);

		// Token: 0x060000F5 RID: 245
		void OnConfirmOrderFailed(FailedOrder failedOrder);
	}
}
