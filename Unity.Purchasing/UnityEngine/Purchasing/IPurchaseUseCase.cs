using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000046 RID: 70
	internal interface IPurchaseUseCase
	{
		// Token: 0x0600011C RID: 284
		void Purchase(ICart cart);

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x0600011D RID: 285
		// (remove) Token: 0x0600011E RID: 286
		event Action<PendingOrder> OnPurchaseSuccess;

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x0600011F RID: 287
		// (remove) Token: 0x06000120 RID: 288
		event Action<FailedOrder> OnPurchaseFail;

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06000121 RID: 289
		// (remove) Token: 0x06000122 RID: 290
		event Action<DeferredOrder> OnPurchaseDefer;
	}
}
