using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200003F RID: 63
	internal static class PurchaseServiceDependencyFactoryInjector
	{
		// Token: 0x06000177 RID: 375 RVA: 0x00006542 File Offset: 0x00004742
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void SetStoreManagerFactory()
		{
			((IPurchaseServiceFactoryManagerInjectionPoint)PurchaseServiceFactoryManager.Instance()).SetServiceFactory(PurchaseServiceFactory.Instance());
		}
	}
}
