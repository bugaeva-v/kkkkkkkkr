using System;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	// Token: 0x0200013A RID: 314
	internal class AppReceiptUseCase : IAppReceiptUseCase
	{
		// Token: 0x06000596 RID: 1430 RVA: 0x0000C18E File Offset: 0x0000A38E
		[NullableContext(1)]
		[Preserve]
		internal AppReceiptUseCase(IAppleAppReceiptViewer appleAppReceiptViewer)
		{
			this.m_AppleAppReceiptViewer = appleAppReceiptViewer;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0000C19D File Offset: 0x0000A39D
		[NullableContext(2)]
		public string AppReceipt()
		{
			return this.m_AppleAppReceiptViewer.AppReceipt();
		}

		// Token: 0x04000292 RID: 658
		[Nullable(1)]
		private readonly IAppleAppReceiptViewer m_AppleAppReceiptViewer;
	}
}
