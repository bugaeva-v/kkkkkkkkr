using System;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases.Interfaces
{
	// Token: 0x0200014D RID: 333
	internal class ClearAppleTransactionLogsUseCase : IClearAppleTransactionLogsUseCase
	{
		// Token: 0x060005B5 RID: 1461 RVA: 0x0000C270 File Offset: 0x0000A470
		[Preserve]
		internal ClearAppleTransactionLogsUseCase(IAppleStoreCallbacks appleStoreCallbacks)
		{
			this.m_AppleStoreCallbacks = appleStoreCallbacks;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0000C27F File Offset: 0x0000A47F
		public void ClearTransactionLog()
		{
			this.m_AppleStoreCallbacks.ClearTransactionLog();
		}

		// Token: 0x04000299 RID: 665
		private readonly IAppleStoreCallbacks m_AppleStoreCallbacks;
	}
}
