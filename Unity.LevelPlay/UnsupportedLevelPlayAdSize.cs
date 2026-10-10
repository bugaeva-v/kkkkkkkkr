using System;

namespace Unity.Services.LevelPlay
{
	// Token: 0x02000029 RID: 41
	internal sealed class UnsupportedLevelPlayAdSize : IPlatformLevelPlayAdSize
	{
		// Token: 0x06000221 RID: 545 RVA: 0x00005C14 File Offset: 0x00003E14
		internal UnsupportedLevelPlayAdSize()
		{
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00005C1C File Offset: 0x00003E1C
		public int Width
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00005C1F File Offset: 0x00003E1F
		public int Height
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00005C22 File Offset: 0x00003E22
		public PlatformLevelPlayAdSizeType AdSizeType
		{
			get
			{
				return PlatformLevelPlayAdSizeType.Custom;
			}
		}
	}
}
