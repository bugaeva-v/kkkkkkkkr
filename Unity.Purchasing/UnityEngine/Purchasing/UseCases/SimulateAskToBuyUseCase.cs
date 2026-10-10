using System;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	// Token: 0x0200013E RID: 318
	internal class SimulateAskToBuyUseCase : ISimulateAskToBuyUseCase
	{
		// Token: 0x0600059F RID: 1439 RVA: 0x0000C20D File Offset: 0x0000A40D
		[NullableContext(1)]
		[Preserve]
		internal SimulateAskToBuyUseCase(IAppleStoreCallbacks appleStoreCallbacks)
		{
			this.m_AppleStoreCallbacks = appleStoreCallbacks;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0000C21C File Offset: 0x0000A41C
		public bool SimulateAskToBuy()
		{
			return this.m_AppleStoreCallbacks.simulateAskToBuy;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0000C229 File Offset: 0x0000A429
		public void SetSimulateAskToBuy(bool value)
		{
			this.m_AppleStoreCallbacks.simulateAskToBuy = value;
		}

		// Token: 0x04000296 RID: 662
		[Nullable(1)]
		private readonly IAppleStoreCallbacks m_AppleStoreCallbacks;
	}
}
