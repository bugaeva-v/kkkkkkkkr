using System;

namespace UnityEngine.Purchasing.Models
{
	// Token: 0x0200011F RID: 287
	internal interface IGoogleBillingResult
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000515 RID: 1301
		GoogleBillingResponseCode responseCode { get; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000516 RID: 1302
		string debugMessage { get; }
	}
}
