using System;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000026 RID: 38
	internal class GooglePlayStoreChangeSubscriptionService : IGooglePlayStoreChangeSubscriptionService
	{
		// Token: 0x060000C3 RID: 195 RVA: 0x00004588 File Offset: 0x00002788
		[Preserve]
		internal GooglePlayStoreChangeSubscriptionService(IGooglePlayStoreService googlePlayStoreService)
		{
			this.m_GooglePlayStoreService = googlePlayStoreService;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00004597 File Offset: 0x00002797
		public void ChangeSubscription(ProductDefinition product, Order currentOrder, GooglePlayReplacementMode? desiredReplacementMode)
		{
			this.m_GooglePlayStoreService.Purchase(product, currentOrder, desiredReplacementMode);
		}

		// Token: 0x04000059 RID: 89
		private readonly IGooglePlayStoreService m_GooglePlayStoreService;
	}
}
