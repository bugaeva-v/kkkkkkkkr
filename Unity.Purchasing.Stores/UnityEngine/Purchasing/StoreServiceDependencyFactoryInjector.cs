using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000043 RID: 67
	internal static class StoreServiceDependencyFactoryInjector
	{
		// Token: 0x06000199 RID: 409 RVA: 0x00006C54 File Offset: 0x00004E54
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void SetStoreManagerFactory()
		{
			((IStoreServiceFactoryManagerInjectionPoint)StoreServiceFactoryManager.Instance()).SetServiceFactory(StoreServiceFactory.Instance());
		}
	}
}
