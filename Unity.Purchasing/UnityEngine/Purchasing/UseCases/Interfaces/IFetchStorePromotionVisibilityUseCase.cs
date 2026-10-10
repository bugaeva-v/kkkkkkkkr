using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing.UseCases.Interfaces
{
	// Token: 0x02000142 RID: 322
	[NullableContext(1)]
	internal interface IFetchStorePromotionVisibilityUseCase
	{
		// Token: 0x060005A7 RID: 1447
		void FetchStorePromotionVisibility(Product product, Action<string, AppleStorePromotionVisibility> successCallback, Action<string> errorCallback);
	}
}
