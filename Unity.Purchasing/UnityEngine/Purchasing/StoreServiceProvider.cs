using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000A1 RID: 161
	[NullableContext(1)]
	[Nullable(0)]
	internal static class StoreServiceProvider
	{
		// Token: 0x060002A8 RID: 680 RVA: 0x00006B0F File Offset: 0x00004D0F
		public static IStoreService GetDefaultStoreService()
		{
			return StoreServiceProvider.GetStoreServiceInternal(StoreManager.Instance().GetDefaultStore());
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00006B20 File Offset: 0x00004D20
		public static IStoreService GetStoreService(string storeName)
		{
			return StoreServiceProvider.GetStoreServiceInternal(StoreManager.Instance().GetStore(storeName));
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00006B32 File Offset: 0x00004D32
		private static IStoreService GetStoreServiceInternal(IStoreWrapper storeWrapper)
		{
			return StoreServiceProvider.LocateExistingService(storeWrapper) ?? StoreServiceProvider.CreateNewService(storeWrapper);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00006B44 File Offset: 0x00004D44
		[return: Nullable(2)]
		private static IStoreService LocateExistingService(IStoreWrapper wrapper)
		{
			return StoreServiceContainer.Instance().FindService(wrapper.name);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00006B58 File Offset: 0x00004D58
		private static IStoreService CreateNewService(IStoreWrapper wrapper)
		{
			IStoreService storeService = new StoreServiceDependencyInjector(wrapper, new ExponentialBackOffRetryPolicy(1000, 30000, 2f)).CreateStoreService();
			try
			{
				StoreServiceContainer.Instance().SetService(wrapper.name, storeService);
			}
			catch (ServiceCreationException exception)
			{
				Debug.unityLogger.LogIAPException(exception);
			}
			return storeService;
		}
	}
}
