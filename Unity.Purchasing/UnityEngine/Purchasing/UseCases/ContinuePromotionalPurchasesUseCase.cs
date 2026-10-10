using System;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	// Token: 0x0200013B RID: 315
	internal class ContinuePromotionalPurchasesUseCase : IContinuePromotionalPurchasesUseCase
	{
		// Token: 0x06000598 RID: 1432 RVA: 0x0000C1AA File Offset: 0x0000A3AA
		[NullableContext(1)]
		[Preserve]
		internal ContinuePromotionalPurchasesUseCase(INativeAppleStore nativeStore)
		{
			this.m_NativeAppleStore = nativeStore;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0000C1B9 File Offset: 0x0000A3B9
		public void ContinuePromotionalPurchases()
		{
			this.m_NativeAppleStore.ContinuePromotionalPurchases();
		}

		// Token: 0x04000293 RID: 659
		[Nullable(1)]
		private readonly INativeAppleStore m_NativeAppleStore;
	}
}
