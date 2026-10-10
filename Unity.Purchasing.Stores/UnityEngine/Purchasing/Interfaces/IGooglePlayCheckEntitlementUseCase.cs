using System;

namespace UnityEngine.Purchasing.Interfaces
{
	// Token: 0x0200005A RID: 90
	internal interface IGooglePlayCheckEntitlementUseCase
	{
		// Token: 0x06000235 RID: 565
		void CheckEntitlement(ProductDefinition product, Action<ProductDefinition, EntitlementStatus> onEntitlementChecked);
	}
}
