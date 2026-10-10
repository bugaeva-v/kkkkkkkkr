using System;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200006F RID: 111
	internal static class PurchaseUseCaseFactory
	{
		// Token: 0x06000207 RID: 519 RVA: 0x00005BD4 File Offset: 0x00003DD4
		internal static IPurchaseUseCase Create(IStore store, IProductCache productCache)
		{
			IGooglePlayStore googlePlayStore = store as IGooglePlayStore;
			if (googlePlayStore != null)
			{
				return new GooglePlayPurchaseUseCase(googlePlayStore, productCache);
			}
			return new PurchaseUseCase(store);
		}
	}
}
