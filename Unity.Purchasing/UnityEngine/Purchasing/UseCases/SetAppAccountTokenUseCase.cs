using System;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	// Token: 0x02000140 RID: 320
	internal class SetAppAccountTokenUseCase : ISetAppAccountTokenUseCase
	{
		// Token: 0x060005A4 RID: 1444 RVA: 0x0000C253 File Offset: 0x0000A453
		[NullableContext(1)]
		[Preserve]
		internal SetAppAccountTokenUseCase(IAppleStoreCallbacks appleStoreCallbacks)
		{
			this.m_AppleStoreCallbacks = appleStoreCallbacks;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0000C262 File Offset: 0x0000A462
		public void SetAppAccountToken(Guid token)
		{
			this.m_AppleStoreCallbacks.SetAppAccountToken(token);
		}

		// Token: 0x04000298 RID: 664
		[Nullable(1)]
		private readonly IAppleStoreCallbacks m_AppleStoreCallbacks;
	}
}
