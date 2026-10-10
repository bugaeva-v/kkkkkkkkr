using System;

namespace Firebase.Platform
{
	// Token: 0x0200000A RID: 10
	internal class DebugLogger : ILoggingService
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002804 File Offset: 0x00000A04
		public static DebugLogger Instance
		{
			get
			{
				return DebugLogger._instance;
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000281B File Offset: 0x00000A1B
		public void LogMessage(PlatformLogLevel level, string message)
		{
		}

		// Token: 0x0400000B RID: 11
		private static DebugLogger _instance = new DebugLogger();
	}
}
