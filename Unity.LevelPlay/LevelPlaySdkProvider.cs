using System;

namespace Unity.Services.LevelPlay
{
	// Token: 0x02000014 RID: 20
	internal static class LevelPlaySdkProvider
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00004159 File Offset: 0x00002359
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00004160 File Offset: 0x00002360
		internal static Func<ILevelPlaySdk> Factory { get; set; }

		// Token: 0x06000125 RID: 293 RVA: 0x00004168 File Offset: 0x00002368
		static LevelPlaySdkProvider()
		{
			LevelPlaySdkProvider.Reset();
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000416F File Offset: 0x0000236F
		internal static ILevelPlaySdk Get()
		{
			return LevelPlaySdkProvider.Factory();
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000417B File Offset: 0x0000237B
		internal static void Reset()
		{
			LevelPlaySdkProvider.Factory = (() => null);
		}
	}
}
