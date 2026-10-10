using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200006C RID: 108
	internal class PurchaseServiceDependencyInjector
	{
		// Token: 0x060001FC RID: 508 RVA: 0x00005ADC File Offset: 0x00003CDC
		internal PurchaseServiceDependencyInjector(IStoreWrapper storeWrapper)
		{
			this.m_ServiceFactoryManager = PurchaseServiceFactoryManager.Instance();
			this.m_storeWrapper = storeWrapper;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00005AF6 File Offset: 0x00003CF6
		internal IPurchaseService CreatePurchaseService()
		{
			return this.m_ServiceFactoryManager.GetServiceFactory().Create(this.m_storeWrapper);
		}

		// Token: 0x0400009F RID: 159
		private IStoreWrapper m_storeWrapper;

		// Token: 0x040000A0 RID: 160
		private IPurchaseServiceFactoryManager m_ServiceFactoryManager;
	}
}
