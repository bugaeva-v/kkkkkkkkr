using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000042 RID: 66
	internal static class StoreManagerFactoryInjector
	{
		// Token: 0x06000198 RID: 408 RVA: 0x00006C43 File Offset: 0x00004E43
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void SetStoreManagerFactory()
		{
			((IStoreManagerFactoryInjectionPoint)StoreManager.Instance()).SetStoreFactory(StoreFactory.Instance());
		}
	}
}
