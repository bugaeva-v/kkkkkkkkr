using System;
using Firebase.Platform;

namespace Firebase.Unity
{
	// Token: 0x02000004 RID: 4
	internal class UnityLoggingService : ILoggingService
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000024C8 File Offset: 0x000006C8
		public static UnityLoggingService Instance
		{
			get
			{
				return UnityLoggingService._instance;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000024DF File Offset: 0x000006DF
		public void LogMessage(PlatformLogLevel level, string message)
		{
			FirebaseLogger.LogMessage(level, message);
		}

		// Token: 0x04000004 RID: 4
		private static UnityLoggingService _instance = new UnityLoggingService();
	}
}
