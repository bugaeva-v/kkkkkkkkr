using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200003F RID: 63
	internal interface IPurchaseServiceFactory
	{
		// Token: 0x06000112 RID: 274
		void RegisterNewService(string name, Func<IPurchaseService> createFunction);

		// Token: 0x06000113 RID: 275
		void RegisterNewExtendedService(string name, Func<IPurchaseService, ExtensiblePurchaseService> createFunction);

		// Token: 0x06000114 RID: 276
		IPurchaseService Create(IStoreWrapper store);
	}
}
