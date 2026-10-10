using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000CA RID: 202
	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", false)]
	public enum InitializationFailureReason
	{
		// Token: 0x04000173 RID: 371
		PurchasingUnavailable,
		// Token: 0x04000174 RID: 372
		NoProductsAvailable,
		// Token: 0x04000175 RID: 373
		AppNotKnown
	}
}
