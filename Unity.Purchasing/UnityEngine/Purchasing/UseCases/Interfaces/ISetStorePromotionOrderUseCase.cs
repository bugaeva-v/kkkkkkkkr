using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing.UseCases.Interfaces
{
	// Token: 0x02000145 RID: 325
	[NullableContext(1)]
	internal interface ISetStorePromotionOrderUseCase
	{
		// Token: 0x060005AA RID: 1450
		void SetStorePromotionOrder(List<Product> products);
	}
}
