using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000E9 RID: 233
	[Obsolete("Use GooglePlayReplacementMode instead.")]
	public enum GooglePlayProrationMode
	{
		// Token: 0x040001DD RID: 477
		UnknownSubscriptionUpgradeDowngradePolicy,
		// Token: 0x040001DE RID: 478
		ImmediateWithTimeProration,
		// Token: 0x040001DF RID: 479
		ImmediateAndChargeProratedPrice,
		// Token: 0x040001E0 RID: 480
		ImmediateWithoutProration,
		// Token: 0x040001E1 RID: 481
		Deferred = 6,
		// Token: 0x040001E2 RID: 482
		ImmediateAndChargeFullPrice = 5
	}
}
