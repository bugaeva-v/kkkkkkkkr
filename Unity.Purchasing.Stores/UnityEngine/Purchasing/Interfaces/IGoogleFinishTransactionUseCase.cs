using System;
using System.Threading.Tasks;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing.Interfaces
{
	// Token: 0x02000058 RID: 88
	internal interface IGoogleFinishTransactionUseCase
	{
		// Token: 0x0600022E RID: 558
		Task FinishTransaction(ProductDefinition product, string purchaseToken, Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished);
	}
}
