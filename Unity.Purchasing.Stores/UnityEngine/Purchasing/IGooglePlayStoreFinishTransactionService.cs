using System;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000031 RID: 49
	internal interface IGooglePlayStoreFinishTransactionService
	{
		// Token: 0x060000FC RID: 252
		void SetProductCache(IProductCache productCache);

		// Token: 0x060000FD RID: 253
		void SetConfirmCallback(IStorePurchaseConfirmCallback confirmCallback);

		// Token: 0x060000FE RID: 254
		void FinishTransaction(ProductDefinition product, string purchaseToken);
	}
}
