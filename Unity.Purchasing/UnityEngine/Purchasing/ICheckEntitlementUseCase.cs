using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000042 RID: 66
	internal interface ICheckEntitlementUseCase
	{
		// Token: 0x06000117 RID: 279
		void IsProductEntitled(Product product, Action<Entitlement> onResult);
	}
}
