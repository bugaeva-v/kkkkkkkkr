using System;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Interfaces;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000023 RID: 35
	[NullableContext(1)]
	internal interface IGooglePlayGetGooglePurchaseUseCase
	{
		// Token: 0x06000098 RID: 152
		[return: Nullable(2)]
		IGooglePurchase GetGooglePurchase(string purchaseToken);
	}
}
