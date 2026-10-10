using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000011 RID: 17
	internal interface IProductServiceFactory
	{
		// Token: 0x06000044 RID: 68
		void RegisterNewService(string name, Func<IProductService> createFunction);

		// Token: 0x06000045 RID: 69
		void RegisterNewExtendedService(string name, Func<IProductService, ExtensibleProductService> createFunction);

		// Token: 0x06000046 RID: 70
		IProductService Create(IStoreWrapper store);
	}
}
