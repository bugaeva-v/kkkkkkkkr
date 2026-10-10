using System;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x02000034 RID: 52
	internal interface IDispatcher
	{
		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000165 RID: 357
		int ConsecutiveFailedUploadCount { get; }

		// Token: 0x06000166 RID: 358
		void SetBuffer(IBuffer buffer);

		// Token: 0x06000167 RID: 359
		void Flush();
	}
}
