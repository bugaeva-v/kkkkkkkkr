using System;

namespace UnityEngine.Purchasing.Models
{
	// Token: 0x02000052 RID: 82
	internal class GoogleBillingResult : IGoogleBillingResult
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00008F88 File Offset: 0x00007188
		public GoogleBillingResponseCode responseCode { get; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000213 RID: 531 RVA: 0x00008F90 File Offset: 0x00007190
		public string debugMessage { get; }

		// Token: 0x06000214 RID: 532 RVA: 0x00008F98 File Offset: 0x00007198
		internal GoogleBillingResult(AndroidJavaObject billingResult)
		{
			if (billingResult != null)
			{
				this.responseCode = billingResult.Call<int>("getResponseCode", Array.Empty<object>());
				this.debugMessage = billingResult.Call<string>("getDebugMessage", Array.Empty<object>());
			}
		}
	}
}
