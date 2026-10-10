using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000044 RID: 68
	internal interface IFetchPurchasesUseCase
	{
		// Token: 0x06000119 RID: 281
		void FetchPurchases(Action<Orders> fetchSuccessAction, Action<PurchasesFetchFailureDescription> fetchFailureAction);
	}
}
