using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	// Token: 0x02000132 RID: 306
	[NullableContext(1)]
	[Nullable(0)]
	internal class FetchStorePromotionOrderUseCase : IFetchStorePromotionOrderUseCase
	{
		// Token: 0x06000585 RID: 1413 RVA: 0x0000BF75 File Offset: 0x0000A175
		[Preserve]
		internal FetchStorePromotionOrderUseCase(IAppleStoreCallbacks appleStoreCallbacks, INativeAppleStore nativeStore)
		{
			this.m_AppleStoreCallbacks = appleStoreCallbacks;
			this.m_NativeAppleStore = nativeStore;
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0000BF8B File Offset: 0x0000A18B
		public void FetchStorePromotionOrder(Action<List<Product>> successCallback, Action<string> errorCallback)
		{
			this.m_AppleStoreCallbacks.SetFetchStorePromotionOrderCallbacks(successCallback, errorCallback);
			this.m_NativeAppleStore.FetchStorePromotionOrder();
		}

		// Token: 0x04000285 RID: 645
		private readonly IAppleStoreCallbacks m_AppleStoreCallbacks;

		// Token: 0x04000286 RID: 646
		private readonly INativeAppleStore m_NativeAppleStore;
	}
}
