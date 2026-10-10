using System;

namespace Firebase.Platform
{
	// Token: 0x0200000E RID: 14
	internal class FirebaseAppUtilsStub : IFirebaseAppUtils
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000041 RID: 65 RVA: 0x0000287C File Offset: 0x00000A7C
		public static FirebaseAppUtilsStub Instance
		{
			get
			{
				return FirebaseAppUtilsStub._instance;
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002893 File Offset: 0x00000A93
		public void TranslateDllNotFoundException(Action action)
		{
			action();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000281B File Offset: 0x00000A1B
		public void PollCallbacks()
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000028A0 File Offset: 0x00000AA0
		public IFirebaseAppPlatform GetDefaultInstance()
		{
			return null;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000028B4 File Offset: 0x00000AB4
		public string GetDefaultInstanceName()
		{
			return "__FIRAPP_DEFAULT";
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000028CC File Offset: 0x00000ACC
		public PlatformLogLevel GetLogLevel()
		{
			return PlatformLogLevel.Debug;
		}

		// Token: 0x04000016 RID: 22
		private static FirebaseAppUtilsStub _instance = new FirebaseAppUtilsStub();
	}
}
