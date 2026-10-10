using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000017 RID: 23
	[NullableContext(1)]
	[Nullable(0)]
	internal class GoogleQueryPurchasesUseCase : IGoogleQueryPurchasesUseCase
	{
		// Token: 0x06000069 RID: 105 RVA: 0x0000369D File Offset: 0x0000189D
		[Preserve]
		internal GoogleQueryPurchasesUseCase(IGoogleBillingClient billingClient, IGooglePurchaseBuilder purchaseBuilder)
		{
			this.m_BillingClient = billingClient;
			this.m_PurchaseBuilder = purchaseBuilder;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000036B4 File Offset: 0x000018B4
		public Task<List<IGooglePurchase>> QueryPurchases()
		{
			GoogleQueryPurchasesUseCase.<QueryPurchases>d__3 <QueryPurchases>d__;
			<QueryPurchases>d__.<>t__builder = AsyncTaskMethodBuilder<List<IGooglePurchase>>.Create();
			<QueryPurchases>d__.<>4__this = this;
			<QueryPurchases>d__.<>1__state = -1;
			<QueryPurchases>d__.<>t__builder.Start<GoogleQueryPurchasesUseCase.<QueryPurchases>d__3>(ref <QueryPurchases>d__);
			return <QueryPurchases>d__.<>t__builder.Task;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000036F8 File Offset: 0x000018F8
		private Task<IEnumerable<IGooglePurchase>> QueryPurchasesWithSkuType(string skuType)
		{
			TaskCompletionSource<IEnumerable<IGooglePurchase>> taskCompletion = new TaskCompletionSource<IEnumerable<IGooglePurchase>>();
			this.m_BillingClient.QueryPurchasesAsync(skuType, delegate(IGoogleBillingResult billingResult, IEnumerable<AndroidJavaObject> purchases)
			{
				IEnumerable<IGooglePurchase> enumerable2;
				if (!GoogleQueryPurchasesUseCase.IsResultOk(billingResult))
				{
					IEnumerable<IGooglePurchase> enumerable = Enumerable.Empty<IGooglePurchase>();
					enumerable2 = enumerable;
				}
				else
				{
					enumerable2 = this.m_PurchaseBuilder.BuildPurchases(purchases);
				}
				IEnumerable<IGooglePurchase> result = enumerable2;
				taskCompletion.TrySetResult(result);
			});
			return taskCompletion.Task;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003740 File Offset: 0x00001940
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		public Task<IGooglePurchase> GetPurchaseByToken(string purchaseToken)
		{
			GoogleQueryPurchasesUseCase.<GetPurchaseByToken>d__5 <GetPurchaseByToken>d__;
			<GetPurchaseByToken>d__.<>t__builder = AsyncTaskMethodBuilder<IGooglePurchase>.Create();
			<GetPurchaseByToken>d__.<>4__this = this;
			<GetPurchaseByToken>d__.purchaseToken = purchaseToken;
			<GetPurchaseByToken>d__.<>1__state = -1;
			<GetPurchaseByToken>d__.<>t__builder.Start<GoogleQueryPurchasesUseCase.<GetPurchaseByToken>d__5>(ref <GetPurchaseByToken>d__);
			return <GetPurchaseByToken>d__.<>t__builder.Task;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000378B File Offset: 0x0000198B
		private static bool IsResultOk(IGoogleBillingResult result)
		{
			return result.responseCode == GoogleBillingResponseCode.Ok;
		}

		// Token: 0x0400002D RID: 45
		private readonly IGoogleBillingClient m_BillingClient;

		// Token: 0x0400002E RID: 46
		private readonly IGooglePurchaseBuilder m_PurchaseBuilder;
	}
}
