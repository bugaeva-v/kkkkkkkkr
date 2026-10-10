using System;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000027 RID: 39
	internal class GooglePlayStoreCheckEntitlementService : IGooglePlayStoreCheckEntitlementService
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x000045A7 File Offset: 0x000027A7
		[Preserve]
		internal GooglePlayStoreCheckEntitlementService(IGooglePlayStoreService googlePlayStoreService)
		{
			this.m_GooglePlayStoreService = googlePlayStoreService;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000045B6 File Offset: 0x000027B6
		public void CheckEntitlement(ProductDefinition product)
		{
			this.m_GooglePlayStoreService.CheckEntitlement(product, delegate(ProductDefinition checkedProduct, EntitlementStatus status)
			{
				IStoreCheckEntitlementCallback entitlementCallback = this.m_EntitlementCallback;
				if (entitlementCallback == null)
				{
					return;
				}
				entitlementCallback.OnCheckEntitlement(checkedProduct, status, null);
			});
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000045D0 File Offset: 0x000027D0
		public void SetCheckEntitlementCallback(IStoreCheckEntitlementCallback entitlementCallback)
		{
			this.m_EntitlementCallback = entitlementCallback;
		}

		// Token: 0x0400005A RID: 90
		private readonly IGooglePlayStoreService m_GooglePlayStoreService;

		// Token: 0x0400005B RID: 91
		private IStoreCheckEntitlementCallback m_EntitlementCallback;
	}
}
