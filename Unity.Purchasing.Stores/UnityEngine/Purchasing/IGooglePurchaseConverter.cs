using System;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000025 RID: 37
	[NullableContext(1)]
	internal interface IGooglePurchaseConverter
	{
		// Token: 0x060000C1 RID: 193
		Order CreateOrderFromPurchase(IGooglePurchase purchase, [Nullable(2)] IProductCache productCache);

		// Token: 0x060000C2 RID: 194
		ICart CreateCartFromPurchase(IGooglePurchase purchase, [Nullable(2)] IProductCache productCache);
	}
}
