using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace UnityEngine.Purchasing.Interfaces
{
	// Token: 0x02000060 RID: 96
	[NullableContext(1)]
	internal interface IGoogleQueryPurchasesUseCase
	{
		// Token: 0x06000246 RID: 582
		Task<List<IGooglePurchase>> QueryPurchases();

		// Token: 0x06000247 RID: 583
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		Task<IGooglePurchase> GetPurchaseByToken(string purchaseToken);
	}
}
