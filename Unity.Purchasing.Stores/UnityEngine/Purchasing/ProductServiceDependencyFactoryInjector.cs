using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200003D RID: 61
	internal static class ProductServiceDependencyFactoryInjector
	{
		// Token: 0x0600016E RID: 366 RVA: 0x00006319 File Offset: 0x00004519
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void SetStoreManagerFactory()
		{
			((IProductServiceFactoryManagerInjectionPoint)ProductServiceFactoryManager.Instance()).SetServiceFactory(ProductServiceFactory.Instance());
		}
	}
}
