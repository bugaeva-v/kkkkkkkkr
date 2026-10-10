using System;

namespace UnityEngine.Purchasing.Models
{
	// Token: 0x02000120 RID: 288
	internal enum GoogleBillingResponseCode
	{
		// Token: 0x04000262 RID: 610
		ServiceTimeout = -3,
		// Token: 0x04000263 RID: 611
		FeatureNotSupported,
		// Token: 0x04000264 RID: 612
		ServiceDisconnected,
		// Token: 0x04000265 RID: 613
		Ok,
		// Token: 0x04000266 RID: 614
		UserCanceled,
		// Token: 0x04000267 RID: 615
		ServiceUnavailable,
		// Token: 0x04000268 RID: 616
		BillingUnavailable,
		// Token: 0x04000269 RID: 617
		ItemUnavailable,
		// Token: 0x0400026A RID: 618
		DeveloperError,
		// Token: 0x0400026B RID: 619
		FatalError,
		// Token: 0x0400026C RID: 620
		ItemAlreadyOwned,
		// Token: 0x0400026D RID: 621
		ItemNotOwned,
		// Token: 0x0400026E RID: 622
		NetworkError = 12
	}
}
