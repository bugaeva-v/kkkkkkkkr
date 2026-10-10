using System;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000086 RID: 134
	internal class GooglePlayStoreSetObfuscatedIdUseCase : IGooglePlayStoreSetObfuscatedIdUseCase
	{
		// Token: 0x06000258 RID: 600 RVA: 0x00006771 File Offset: 0x00004971
		[Preserve]
		internal GooglePlayStoreSetObfuscatedIdUseCase(IGoogleBillingClient billingClient)
		{
			this.m_BillingClient = billingClient;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00006780 File Offset: 0x00004980
		public void SetObfuscatedAccountId(string accountId)
		{
			this.m_BillingClient.SetObfuscationAccountId(accountId);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000678E File Offset: 0x0000498E
		public void SetObfuscatedProfileId(string profileId)
		{
			this.m_BillingClient.SetObfuscationProfileId(profileId);
		}

		// Token: 0x040000C0 RID: 192
		private readonly IGoogleBillingClient m_BillingClient;
	}
}
