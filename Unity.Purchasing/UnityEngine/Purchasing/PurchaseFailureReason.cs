using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000DC RID: 220
	public enum PurchaseFailureReason
	{
		// Token: 0x040001B1 RID: 433
		PurchasingUnavailable,
		// Token: 0x040001B2 RID: 434
		ExistingPurchasePending,
		// Token: 0x040001B3 RID: 435
		ProductUnavailable,
		// Token: 0x040001B4 RID: 436
		SignatureInvalid,
		// Token: 0x040001B5 RID: 437
		UserCancelled,
		// Token: 0x040001B6 RID: 438
		PaymentDeclined,
		// Token: 0x040001B7 RID: 439
		DuplicateTransaction,
		// Token: 0x040001B8 RID: 440
		ValidationFailure,
		// Token: 0x040001B9 RID: 441
		StoreNotConnected,
		// Token: 0x040001BA RID: 442
		PurchaseMissing,
		// Token: 0x040001BB RID: 443
		Unknown
	}
}
