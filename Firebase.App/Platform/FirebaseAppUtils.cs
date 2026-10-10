using System;

namespace Firebase.Platform
{
	// Token: 0x0200001D RID: 29
	internal class FirebaseAppUtils : IFirebaseAppUtils
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600028A RID: 650 RVA: 0x00008738 File Offset: 0x00006938
		public static FirebaseAppUtils Instance
		{
			get
			{
				return FirebaseAppUtils.instance;
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000874F File Offset: 0x0000694F
		public void TranslateDllNotFoundException(Action action)
		{
			FirebaseApp.TranslateDllNotFoundException(action);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00008759 File Offset: 0x00006959
		public void PollCallbacks()
		{
			AppUtil.PollCallbacks();
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00008764 File Offset: 0x00006964
		public IFirebaseAppPlatform GetDefaultInstance()
		{
			return FirebaseApp.DefaultInstance.AppPlatform;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00008780 File Offset: 0x00006980
		public string GetDefaultInstanceName()
		{
			return FirebaseApp.DefaultName;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00008798 File Offset: 0x00006998
		public PlatformLogLevel GetLogLevel()
		{
			LogLevel logLevel;
			try
			{
				logLevel = FirebaseApp.LogLevel;
			}
			catch (InitializationException)
			{
				logLevel = LogLevel.Debug;
			}
			return LogUtil.ConvertLogLevel(logLevel);
		}

		// Token: 0x04000069 RID: 105
		private static FirebaseAppUtils instance = new FirebaseAppUtils();
	}
}
