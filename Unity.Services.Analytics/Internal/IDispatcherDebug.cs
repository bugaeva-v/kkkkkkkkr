using System;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x02000038 RID: 56
	internal interface IDispatcherDebug
	{
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600017D RID: 381
		bool FlushInProgress { get; }

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600017E RID: 382
		// (remove) Token: 0x0600017F RID: 383
		event Action<byte[]> FlushStarted;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000180 RID: 384
		// (remove) Token: 0x06000181 RID: 385
		event Action<int, bool, bool, bool, bool, byte[]> FlushFinished;
	}
}
