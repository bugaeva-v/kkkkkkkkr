using System;
using Firebase.Platform;
using Firebase.Platform.Default;

namespace Firebase.Unity
{
	// Token: 0x02000005 RID: 5
	internal class UnityPlatformServices
	{
		// Token: 0x06000013 RID: 19 RVA: 0x000024F6 File Offset: 0x000006F6
		public static void SetupServices()
		{
			Services.AppConfig = UnityConfigExtensions.DefaultInstance;
			Services.Logging = UnityLoggingService.Instance;
		}
	}
}
