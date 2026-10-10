using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000038 RID: 56
	public interface IStorePurchaseCallback
	{
		// Token: 0x060000F1 RID: 241
		void OnPurchaseSucceeded(PendingOrder order);

		// Token: 0x060000F2 RID: 242
		void OnPurchaseFailed(FailedOrder failedOrder);

		// Token: 0x060000F3 RID: 243
		void OnPurchaseDeferred(DeferredOrder deferredOrder);
	}
}
