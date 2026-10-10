using System;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	// Token: 0x02000133 RID: 307
	[NullableContext(1)]
	[Nullable(0)]
	internal class FetchStorePromotionVisibilityUseCase : IFetchStorePromotionVisibilityUseCase
	{
		// Token: 0x06000587 RID: 1415 RVA: 0x0000BFA5 File Offset: 0x0000A1A5
		[Preserve]
		internal FetchStorePromotionVisibilityUseCase(IAppleStoreCallbacks appleStoreCallbacks, INativeAppleStore nativeStore)
		{
			this.m_AppleStoreCallbacks = appleStoreCallbacks;
			this.m_NativeAppleStore = nativeStore;
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x0000BFBB File Offset: 0x0000A1BB
		public void FetchStorePromotionVisibility(Product product, Action<string, AppleStorePromotionVisibility> successCallback, Action<string> errorCallback)
		{
			this.m_AppleStoreCallbacks.SetFetchStorePromotionVisibilityCallbacks(successCallback, errorCallback);
			this.m_NativeAppleStore.FetchStorePromotionVisibility(product.definition.storeSpecificId);
		}

		// Token: 0x04000287 RID: 647
		private readonly IAppleStoreCallbacks m_AppleStoreCallbacks;

		// Token: 0x04000288 RID: 648
		private readonly INativeAppleStore m_NativeAppleStore;
	}
}
