using System;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200002C RID: 44
	internal class GooglePlayStorePurchaseService : IGooglePlayStorePurchaseService
	{
		// Token: 0x060000EE RID: 238 RVA: 0x00004C9B File Offset: 0x00002E9B
		[Preserve]
		internal GooglePlayStorePurchaseService(IGooglePlayStoreService googlePlayStoreService)
		{
			this.m_GooglePlayStoreService = googlePlayStoreService;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00004CAA File Offset: 0x00002EAA
		public void Purchase(ProductDefinition product)
		{
			this.m_GooglePlayStoreService.Purchase(product);
		}

		// Token: 0x0400006C RID: 108
		private readonly IGooglePlayStoreService m_GooglePlayStoreService;
	}
}
