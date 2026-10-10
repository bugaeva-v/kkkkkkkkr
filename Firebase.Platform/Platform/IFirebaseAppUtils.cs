using System;

namespace Firebase.Platform
{
	// Token: 0x0200000D RID: 13
	internal interface IFirebaseAppUtils
	{
		// Token: 0x0600003C RID: 60
		void TranslateDllNotFoundException(Action action);

		// Token: 0x0600003D RID: 61
		void PollCallbacks();

		// Token: 0x0600003E RID: 62
		IFirebaseAppPlatform GetDefaultInstance();

		// Token: 0x0600003F RID: 63
		string GetDefaultInstanceName();

		// Token: 0x06000040 RID: 64
		PlatformLogLevel GetLogLevel();
	}
}
