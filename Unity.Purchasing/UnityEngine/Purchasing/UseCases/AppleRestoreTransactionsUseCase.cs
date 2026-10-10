using System;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	// Token: 0x02000139 RID: 313
	[NullableContext(1)]
	[Nullable(0)]
	internal class AppleRestoreTransactionsUseCase : IRestoreTransactionsUseCase
	{
		// Token: 0x06000594 RID: 1428 RVA: 0x0000C15F File Offset: 0x0000A35F
		[Preserve]
		internal AppleRestoreTransactionsUseCase(IAppleStoreCallbacks appleStoreCallbacks, INativeAppleStore nativeStore)
		{
			this.m_AppleStoreCallbacks = appleStoreCallbacks;
			this.m_NativeAppleStore = nativeStore;
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0000C175 File Offset: 0x0000A375
		[NullableContext(2)]
		public void RestoreTransactions(Action<bool, string> callback)
		{
			this.m_AppleStoreCallbacks.SetRestoreTransactionsCallback(callback);
			this.m_NativeAppleStore.RestoreTransactions();
		}

		// Token: 0x04000290 RID: 656
		private readonly IAppleStoreCallbacks m_AppleStoreCallbacks;

		// Token: 0x04000291 RID: 657
		private readonly INativeAppleStore m_NativeAppleStore;
	}
}
