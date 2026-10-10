using System;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000022 RID: 34
	internal class GooglePlayRestoreTransactionUseCase : IRestoreTransactionsUseCase
	{
		// Token: 0x06000096 RID: 150 RVA: 0x00002EF6 File Offset: 0x000010F6
		[NullableContext(1)]
		[Preserve]
		public GooglePlayRestoreTransactionUseCase(IFetchPurchasesUseCase fetchPurchasesUseCase)
		{
			this.m_FetchPurchasesUseCase = fetchPurchasesUseCase;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002F05 File Offset: 0x00001105
		[NullableContext(2)]
		public void RestoreTransactions(Action<bool, string> callback)
		{
			if (callback != null)
			{
				callback(true, null);
			}
		}

		// Token: 0x04000027 RID: 39
		[Nullable(1)]
		private readonly IFetchPurchasesUseCase m_FetchPurchasesUseCase;
	}
}
