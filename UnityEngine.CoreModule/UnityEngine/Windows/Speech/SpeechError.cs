using System;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x02000297 RID: 663
	public enum SpeechError
	{
		// Token: 0x0400093D RID: 2365
		NoError,
		// Token: 0x0400093E RID: 2366
		TopicLanguageNotSupported,
		// Token: 0x0400093F RID: 2367
		GrammarLanguageMismatch,
		// Token: 0x04000940 RID: 2368
		GrammarCompilationFailure,
		// Token: 0x04000941 RID: 2369
		AudioQualityFailure,
		// Token: 0x04000942 RID: 2370
		PauseLimitExceeded,
		// Token: 0x04000943 RID: 2371
		TimeoutExceeded,
		// Token: 0x04000944 RID: 2372
		NetworkFailure,
		// Token: 0x04000945 RID: 2373
		MicrophoneUnavailable,
		// Token: 0x04000946 RID: 2374
		UnknownError
	}
}
