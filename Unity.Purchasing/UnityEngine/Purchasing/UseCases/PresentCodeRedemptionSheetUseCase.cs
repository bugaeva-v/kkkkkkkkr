using System;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	// Token: 0x0200013C RID: 316
	internal class PresentCodeRedemptionSheetUseCase : IPresentCodeRedemptionSheetUseCase
	{
		// Token: 0x0600059A RID: 1434 RVA: 0x0000C1C6 File Offset: 0x0000A3C6
		[NullableContext(1)]
		[Preserve]
		internal PresentCodeRedemptionSheetUseCase(INativeAppleStore nativeStore)
		{
			this.m_NativeAppleStore = nativeStore;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0000C1D5 File Offset: 0x0000A3D5
		public void PresentCodeRedemptionSheet()
		{
			this.m_NativeAppleStore.PresentCodeRedemptionSheet();
		}

		// Token: 0x04000294 RID: 660
		[Nullable(1)]
		private readonly INativeAppleStore m_NativeAppleStore;
	}
}
