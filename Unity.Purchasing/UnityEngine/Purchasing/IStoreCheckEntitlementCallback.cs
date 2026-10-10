using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000037 RID: 55
	public interface IStoreCheckEntitlementCallback
	{
		// Token: 0x060000F0 RID: 240
		void OnCheckEntitlement(ProductDefinition productDefinition, EntitlementStatus status, string message = null);
	}
}
