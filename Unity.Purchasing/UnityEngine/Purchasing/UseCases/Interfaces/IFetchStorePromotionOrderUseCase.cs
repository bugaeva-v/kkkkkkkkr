using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing.UseCases.Interfaces
{
	// Token: 0x02000141 RID: 321
	[NullableContext(1)]
	internal interface IFetchStorePromotionOrderUseCase
	{
		// Token: 0x060005A6 RID: 1446
		void FetchStorePromotionOrder(Action<List<Product>> successCallback, Action<string> errorCallback);
	}
}
