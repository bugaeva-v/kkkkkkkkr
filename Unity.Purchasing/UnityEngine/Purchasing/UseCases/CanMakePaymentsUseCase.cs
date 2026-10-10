using System;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	// Token: 0x0200013F RID: 319
	internal class CanMakePaymentsUseCase : ICanMakePaymentsUseCase
	{
		// Token: 0x060005A2 RID: 1442 RVA: 0x0000C237 File Offset: 0x0000A437
		[NullableContext(1)]
		[Preserve]
		internal CanMakePaymentsUseCase(INativeAppleStore nativeStore)
		{
			this.m_NativeAppleStore = nativeStore;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0000C246 File Offset: 0x0000A446
		public bool CanMakePayments()
		{
			return this.m_NativeAppleStore.canMakePayments;
		}

		// Token: 0x04000297 RID: 663
		[Nullable(1)]
		private readonly INativeAppleStore m_NativeAppleStore;
	}
}
