using System;
using Firebase.Platform.Default;

namespace Firebase.Platform
{
	// Token: 0x0200000B RID: 11
	internal static class Services
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000036 RID: 54 RVA: 0x0000284E File Offset: 0x00000A4E
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00002855 File Offset: 0x00000A55
		public static IAppConfigExtensions AppConfig { get; internal set; } = AppConfigExtensions.Instance;

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0000285D File Offset: 0x00000A5D
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00002864 File Offset: 0x00000A64
		public static IClockService Clock { get; internal set; } = SystemClock.Instance;

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003A RID: 58 RVA: 0x0000286C File Offset: 0x00000A6C
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002873 File Offset: 0x00000A73
		public static ILoggingService Logging { get; internal set; } = DebugLogger.Instance;
	}
}
