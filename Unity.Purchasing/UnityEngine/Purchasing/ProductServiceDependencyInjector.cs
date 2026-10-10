using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200001A RID: 26
	[NullableContext(1)]
	[Nullable(0)]
	internal class ProductServiceDependencyInjector
	{
		// Token: 0x06000066 RID: 102 RVA: 0x000028B9 File Offset: 0x00000AB9
		internal ProductServiceDependencyInjector(IStoreWrapper storeWrapper)
		{
			this.m_ServiceFactoryManager = ProductServiceFactoryManager.Instance();
			this.m_storeWrapper = storeWrapper;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000028D3 File Offset: 0x00000AD3
		internal IProductService CreateProductService()
		{
			return this.m_ServiceFactoryManager.GetServiceFactory().Create(this.m_storeWrapper);
		}

		// Token: 0x0400001C RID: 28
		private IStoreWrapper m_storeWrapper;

		// Token: 0x0400001D RID: 29
		private IProductServiceFactoryManager m_ServiceFactoryManager;
	}
}
