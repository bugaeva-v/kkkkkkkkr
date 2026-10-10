using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000011 RID: 17
	[NullableContext(1)]
	[Nullable(0)]
	internal class GoogleFinishTransactionUseCase : IGoogleFinishTransactionUseCase
	{
		// Token: 0x06000030 RID: 48 RVA: 0x000028C7 File Offset: 0x00000AC7
		[Preserve]
		internal GoogleFinishTransactionUseCase(IGoogleBillingClient billingClient, IGoogleQueryPurchasesUseCase googleQueryPurchasesUseCase)
		{
			this.m_BillingClient = billingClient;
			this.m_GoogleQueryPurchasesUseCase = googleQueryPurchasesUseCase;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000028E0 File Offset: 0x00000AE0
		public Task FinishTransaction([Nullable(2)] ProductDefinition product, [Nullable(2)] string purchaseToken, Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished)
		{
			GoogleFinishTransactionUseCase.<FinishTransaction>d__3 <FinishTransaction>d__;
			<FinishTransaction>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<FinishTransaction>d__.<>4__this = this;
			<FinishTransaction>d__.product = product;
			<FinishTransaction>d__.purchaseToken = purchaseToken;
			<FinishTransaction>d__.onTransactionFinished = onTransactionFinished;
			<FinishTransaction>d__.<>1__state = -1;
			<FinishTransaction>d__.<>t__builder.Start<GoogleFinishTransactionUseCase.<FinishTransaction>d__3>(ref <FinishTransaction>d__);
			return <FinishTransaction>d__.<>t__builder.Task;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000293C File Offset: 0x00000B3C
		private void FinishTransactionForPurchase(IGooglePurchase purchase, [Nullable(2)] ProductDefinition product, [Nullable(2)] string purchaseToken, Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished)
		{
			if (product != null && product.type == ProductType.Consumable)
			{
				this.m_BillingClient.ConsumeAsync(purchaseToken, delegate(IGoogleBillingResult result)
				{
					onTransactionFinished(result, purchase);
				});
				return;
			}
			if (!purchase.IsAcknowledged())
			{
				this.m_BillingClient.AcknowledgePurchase(purchaseToken, delegate(IGoogleBillingResult result)
				{
					onTransactionFinished(result, purchase);
				});
			}
		}

		// Token: 0x04000014 RID: 20
		private readonly IGoogleBillingClient m_BillingClient;

		// Token: 0x04000015 RID: 21
		private readonly IGoogleQueryPurchasesUseCase m_GoogleQueryPurchasesUseCase;
	}
}
