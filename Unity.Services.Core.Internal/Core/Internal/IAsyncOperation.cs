using System;
using System.Collections;

namespace Unity.Services.Core.Internal
{
	// Token: 0x0200002F RID: 47
	internal interface IAsyncOperation : IEnumerator
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000B4 RID: 180
		bool IsDone { get; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000B5 RID: 181
		AsyncOperationStatus Status { get; }

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060000B6 RID: 182
		// (remove) Token: 0x060000B7 RID: 183
		event Action<IAsyncOperation> Completed;

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000B8 RID: 184
		Exception Exception { get; }
	}
}
