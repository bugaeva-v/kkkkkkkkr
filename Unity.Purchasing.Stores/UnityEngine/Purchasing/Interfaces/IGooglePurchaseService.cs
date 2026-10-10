using System;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing.Interfaces
{
	// Token: 0x0200005D RID: 93
	[NullableContext(1)]
	internal interface IGooglePurchaseService
	{
		// Token: 0x06000240 RID: 576
		void Purchase(ProductDefinition product, [Nullable(2)] Order currentOrder, GooglePlayReplacementMode? desiredReplacementMode);

		// Token: 0x06000241 RID: 577
		void SetProductCache(IProductCache productCache);
	}
}
