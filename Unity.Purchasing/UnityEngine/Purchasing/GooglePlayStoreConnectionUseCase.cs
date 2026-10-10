using System;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000085 RID: 133
	internal class GooglePlayStoreConnectionUseCase : IGooglePlayStoreConnectionUseCase
	{
		// Token: 0x06000256 RID: 598 RVA: 0x00006755 File Offset: 0x00004955
		[Preserve]
		public GooglePlayStoreConnectionUseCase(IGoogleBillingClient billingClient)
		{
			this.m_BillingClient = billingClient;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00006764 File Offset: 0x00004964
		public void EndConnection()
		{
			this.m_BillingClient.EndConnection();
		}

		// Token: 0x040000BF RID: 191
		private readonly IGoogleBillingClient m_BillingClient;
	}
}
