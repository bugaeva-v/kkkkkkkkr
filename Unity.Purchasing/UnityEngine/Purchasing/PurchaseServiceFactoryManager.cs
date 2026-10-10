using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200006D RID: 109
	internal class PurchaseServiceFactoryManager : IPurchaseServiceFactoryManager, IPurchaseServiceFactoryManagerInjectionPoint
	{
		// Token: 0x060001FE RID: 510 RVA: 0x00005B0E File Offset: 0x00003D0E
		internal static PurchaseServiceFactoryManager Instance()
		{
			if (PurchaseServiceFactoryManager.s_Instance == null)
			{
				PurchaseServiceFactoryManager.s_Instance = new PurchaseServiceFactoryManager();
			}
			return PurchaseServiceFactoryManager.s_Instance;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00005B26 File Offset: 0x00003D26
		public void SetServiceFactory(IPurchaseServiceFactory serviceFactory)
		{
			this.m_Factory = serviceFactory;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00005B2F File Offset: 0x00003D2F
		public IPurchaseServiceFactory GetServiceFactory()
		{
			return this.m_Factory;
		}

		// Token: 0x040000A1 RID: 161
		private static PurchaseServiceFactoryManager s_Instance;

		// Token: 0x040000A2 RID: 162
		private IPurchaseServiceFactory m_Factory;
	}
}
