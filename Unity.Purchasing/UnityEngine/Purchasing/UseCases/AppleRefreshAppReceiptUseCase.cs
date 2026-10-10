using System;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	// Token: 0x02000138 RID: 312
	[NullableContext(1)]
	[Nullable(0)]
	internal class AppleRefreshAppReceiptUseCase : IRefreshAppReceiptUseCase
	{
		// Token: 0x06000591 RID: 1425 RVA: 0x0000C121 File Offset: 0x0000A321
		[Preserve]
		internal AppleRefreshAppReceiptUseCase(IAppleStoreCallbacks appleStoreCallbacks, INativeAppleStore nativeStore)
		{
			this.m_AppleStoreCallbacks = appleStoreCallbacks;
			this.m_NativeAppleStore = nativeStore;
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0000C137 File Offset: 0x0000A337
		public void RefreshAppReceipt(Action<string> successCallback, Action<string> errorCallback)
		{
			this.m_AppleStoreCallbacks.SetRefreshAppReceiptCallbacks(successCallback, errorCallback);
			this.m_NativeAppleStore.RefreshAppReceipt();
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0000C151 File Offset: 0x0000A351
		public void SetRefreshAppReceipt(bool refreshAppReceipt)
		{
			this.m_AppleStoreCallbacks.SetRefreshAppReceipt(refreshAppReceipt);
		}

		// Token: 0x0400028E RID: 654
		private readonly IAppleStoreCallbacks m_AppleStoreCallbacks;

		// Token: 0x0400028F RID: 655
		private readonly INativeAppleStore m_NativeAppleStore;
	}
}
