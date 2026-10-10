using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200006E RID: 110
	[NullableContext(1)]
	[Nullable(0)]
	internal static class PurchaseServiceProvider
	{
		// Token: 0x06000202 RID: 514 RVA: 0x00005B3F File Offset: 0x00003D3F
		public static IPurchaseService GetDefaultPurchaseService()
		{
			return PurchaseServiceProvider.GetPurchaseServiceInternal(StoreManager.Instance().GetDefaultStore());
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00005B50 File Offset: 0x00003D50
		public static IPurchaseService GetPurchaseService(string storeName)
		{
			return PurchaseServiceProvider.GetPurchaseServiceInternal(StoreManager.Instance().GetStore(storeName));
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00005B62 File Offset: 0x00003D62
		private static IPurchaseService GetPurchaseServiceInternal(IStoreWrapper storeWrapper)
		{
			return PurchaseServiceProvider.LocateExistingService(storeWrapper) ?? PurchaseServiceProvider.CreateNewService(storeWrapper);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00005B74 File Offset: 0x00003D74
		[return: Nullable(2)]
		private static IPurchaseService LocateExistingService(IStoreWrapper wrapper)
		{
			return PurchaseServiceContainer.Instance().FindService(wrapper.name);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00005B88 File Offset: 0x00003D88
		private static IPurchaseService CreateNewService(IStoreWrapper wrapper)
		{
			IPurchaseService purchaseService = new PurchaseServiceDependencyInjector(wrapper).CreatePurchaseService();
			try
			{
				PurchaseServiceContainer.Instance().SetService(wrapper.name, purchaseService);
			}
			catch (ServiceCreationException exception)
			{
				Debug.unityLogger.LogIAPException(exception);
			}
			return purchaseService;
		}
	}
}
