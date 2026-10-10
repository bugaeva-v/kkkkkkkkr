using System;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	// Token: 0x0200013D RID: 317
	internal class SetPromotionalPurchaseInterceptorCallbackUseCase : ISetPromotionalPurchaseInterceptorCallbackUseCase
	{
		// Token: 0x0600059C RID: 1436 RVA: 0x0000C1E2 File Offset: 0x0000A3E2
		[NullableContext(1)]
		[Preserve]
		internal SetPromotionalPurchaseInterceptorCallbackUseCase(IAppleStoreCallbacks appleStoreCallbacks)
		{
			this.m_AppleStoreCallbacks = appleStoreCallbacks;
		}

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x0600059D RID: 1437 RVA: 0x0000C1F1 File Offset: 0x0000A3F1
		// (remove) Token: 0x0600059E RID: 1438 RVA: 0x0000C1FF File Offset: 0x0000A3FF
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<Product> OnPromotionalPurchaseIntercepted
		{
			add
			{
				this.m_AppleStoreCallbacks.OnPromotionalPurchaseIntercepted += value;
			}
			remove
			{
				this.m_AppleStoreCallbacks.OnPromotionalPurchaseIntercepted -= value;
			}
		}

		// Token: 0x04000295 RID: 661
		[Nullable(1)]
		private readonly IAppleStoreCallbacks m_AppleStoreCallbacks;
	}
}
