using System;

namespace Unity.Services.LevelPlay
{
	// Token: 0x02000024 RID: 36
	internal interface IPlatformLevelPlayAdSize
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060001D0 RID: 464
		int Width { get; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001D1 RID: 465
		int Height { get; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060001D2 RID: 466
		PlatformLevelPlayAdSizeType AdSizeType { get; }
	}
}
