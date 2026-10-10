using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200001B RID: 27
	internal class ProductServiceFactoryManager : IProductServiceFactoryManager, IProductServiceFactoryManagerInjectionPoint
	{
		// Token: 0x06000068 RID: 104 RVA: 0x000028EB File Offset: 0x00000AEB
		internal static ProductServiceFactoryManager Instance()
		{
			if (ProductServiceFactoryManager.s_Instance == null)
			{
				ProductServiceFactoryManager.s_Instance = new ProductServiceFactoryManager();
			}
			return ProductServiceFactoryManager.s_Instance;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002903 File Offset: 0x00000B03
		public void SetServiceFactory(IProductServiceFactory serviceFactory)
		{
			this.m_Factory = serviceFactory;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000290C File Offset: 0x00000B0C
		public IProductServiceFactory GetServiceFactory()
		{
			return this.m_Factory;
		}

		// Token: 0x0400001E RID: 30
		private static ProductServiceFactoryManager s_Instance;

		// Token: 0x0400001F RID: 31
		private IProductServiceFactory m_Factory;
	}
}
