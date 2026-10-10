using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000A0 RID: 160
	internal class StoreServiceFactoryManager : IStoreServiceFactoryManager, IStoreServiceFactoryManagerInjectionPoint
	{
		// Token: 0x060002A4 RID: 676 RVA: 0x00006ADE File Offset: 0x00004CDE
		internal static StoreServiceFactoryManager Instance()
		{
			if (StoreServiceFactoryManager.s_Instance == null)
			{
				StoreServiceFactoryManager.s_Instance = new StoreServiceFactoryManager();
			}
			return StoreServiceFactoryManager.s_Instance;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00006AF6 File Offset: 0x00004CF6
		public void SetServiceFactory(IStoreServiceFactory serviceFactory)
		{
			this.m_Factory = serviceFactory;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00006AFF File Offset: 0x00004CFF
		public IStoreServiceFactory GetServiceFactory()
		{
			return this.m_Factory;
		}

		// Token: 0x040000D7 RID: 215
		private static StoreServiceFactoryManager s_Instance;

		// Token: 0x040000D8 RID: 216
		private IStoreServiceFactory m_Factory;
	}
}
