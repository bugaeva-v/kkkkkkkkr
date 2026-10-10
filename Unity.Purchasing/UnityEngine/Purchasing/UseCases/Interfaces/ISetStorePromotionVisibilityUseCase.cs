using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing.UseCases.Interfaces
{
	// Token: 0x02000146 RID: 326
	[NullableContext(1)]
	internal interface ISetStorePromotionVisibilityUseCase
	{
		// Token: 0x060005AB RID: 1451
		void SetStorePromotionVisibility(Product product, AppleStorePromotionVisibility visibility);
	}
}
