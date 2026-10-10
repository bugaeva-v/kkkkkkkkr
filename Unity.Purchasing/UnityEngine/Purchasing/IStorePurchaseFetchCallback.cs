using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200003A RID: 58
	[NullableContext(1)]
	public interface IStorePurchaseFetchCallback
	{
		// Token: 0x060000F6 RID: 246
		void OnAllPurchasesRetrieved(IReadOnlyList<Order> orders);

		// Token: 0x060000F7 RID: 247
		void OnPurchasesRetrievalFailed(PurchasesFetchFailureDescription failureReason);
	}
}
