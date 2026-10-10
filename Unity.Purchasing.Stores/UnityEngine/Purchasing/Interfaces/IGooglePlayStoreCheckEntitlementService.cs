using System;

namespace UnityEngine.Purchasing.Interfaces
{
	// Token: 0x02000063 RID: 99
	internal interface IGooglePlayStoreCheckEntitlementService
	{
		// Token: 0x0600024D RID: 589
		void CheckEntitlement(ProductDefinition product);

		// Token: 0x0600024E RID: 590
		void SetCheckEntitlementCallback(IStoreCheckEntitlementCallback entitlementCallback);
	}
}
