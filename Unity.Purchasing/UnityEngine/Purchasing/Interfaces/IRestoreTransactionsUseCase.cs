using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing.Interfaces
{
	// Token: 0x02000122 RID: 290
	[NullableContext(2)]
	internal interface IRestoreTransactionsUseCase
	{
		// Token: 0x06000517 RID: 1303
		void RestoreTransactions(Action<bool, string> callback);
	}
}
