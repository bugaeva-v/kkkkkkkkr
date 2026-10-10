using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing.UseCases.Interfaces
{
	// Token: 0x0200014B RID: 331
	[NullableContext(1)]
	internal interface ISetPromotionalPurchaseInterceptorCallbackUseCase
	{
		// Token: 0x1400003D RID: 61
		// (add) Token: 0x060005B1 RID: 1457
		// (remove) Token: 0x060005B2 RID: 1458
		event Action<Product> OnPromotionalPurchaseIntercepted;
	}
}
