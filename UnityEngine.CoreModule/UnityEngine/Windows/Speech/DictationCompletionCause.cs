using System;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x02000299 RID: 665
	public enum DictationCompletionCause
	{
		// Token: 0x0400094C RID: 2380
		Complete,
		// Token: 0x0400094D RID: 2381
		AudioQualityFailure,
		// Token: 0x0400094E RID: 2382
		Canceled,
		// Token: 0x0400094F RID: 2383
		TimeoutExceeded,
		// Token: 0x04000950 RID: 2384
		PauseLimitExceeded,
		// Token: 0x04000951 RID: 2385
		NetworkFailure,
		// Token: 0x04000952 RID: 2386
		MicrophoneUnavailable,
		// Token: 0x04000953 RID: 2387
		UnknownError
	}
}
