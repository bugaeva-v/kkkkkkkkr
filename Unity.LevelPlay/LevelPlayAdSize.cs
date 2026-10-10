using System;

namespace Unity.Services.LevelPlay
{
	// Token: 0x0200000A RID: 10
	public sealed class LevelPlayAdSize
	{
		// Token: 0x06000083 RID: 131 RVA: 0x000029C4 File Offset: 0x00000BC4
		internal IPlatformLevelPlayAdSize GetPlatformLevelPlayAdSize()
		{
			return this.m_PlatformLevelPlayAdSize;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000029CC File Offset: 0x00000BCC
		internal LevelPlayAdSize() : this(PlatformLevelPlayAdSizeType.Unknown)
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000029D5 File Offset: 0x00000BD5
		internal LevelPlayAdSize(IPlatformLevelPlayAdSize adSize)
		{
			this.m_PlatformLevelPlayAdSize = adSize;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000029E4 File Offset: 0x00000BE4
		private LevelPlayAdSize(PlatformLevelPlayAdSizeType adSizeType)
		{
			this.m_PlatformLevelPlayAdSize = new UnsupportedLevelPlayAdSize();
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000029F7 File Offset: 0x00000BF7
		private LevelPlayAdSize(int width, int height)
		{
			this.m_PlatformLevelPlayAdSize = new UnsupportedLevelPlayAdSize();
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002A0A File Offset: 0x00000C0A
		public static LevelPlayAdSize CreateCustomBannerSize(int width, int height)
		{
			return new LevelPlayAdSize(width, height);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002A13 File Offset: 0x00000C13
		public static LevelPlayAdSize CreateAdaptiveAdSize(int customWidth = -1)
		{
			return new LevelPlayAdSize(new UnsupportedLevelPlayAdSize());
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00002A24 File Offset: 0x00000C24
		public string Description
		{
			get
			{
				switch (this.m_PlatformLevelPlayAdSize.AdSizeType)
				{
				case PlatformLevelPlayAdSizeType.Banner:
					return "BANNER";
				case PlatformLevelPlayAdSizeType.Large:
					return "LARGE";
				case PlatformLevelPlayAdSizeType.MediumRectangle:
					return "MEDIUM_RECTANGLE";
				case PlatformLevelPlayAdSizeType.Custom:
					return "CUSTOM";
				case PlatformLevelPlayAdSizeType.LeaderBoard:
					return "LEADERBOARD";
				case PlatformLevelPlayAdSizeType.Adaptive:
					return "ADAPTIVE";
				default:
					return "UNKNOWN";
				}
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00002A88 File Offset: 0x00000C88
		public int Width
		{
			get
			{
				return this.m_PlatformLevelPlayAdSize.Width;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00002A95 File Offset: 0x00000C95
		public int Height
		{
			get
			{
				return this.m_PlatformLevelPlayAdSize.Height;
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002AA2 File Offset: 0x00000CA2
		public override string ToString()
		{
			return string.Format("Description: {0}, Width: {1}, Height: {2}", this.Description, this.Width, this.Height);
		}

		// Token: 0x04000035 RID: 53
		private IPlatformLevelPlayAdSize m_PlatformLevelPlayAdSize;

		// Token: 0x04000036 RID: 54
		public static LevelPlayAdSize BANNER = new LevelPlayAdSize(PlatformLevelPlayAdSizeType.Banner);

		// Token: 0x04000037 RID: 55
		public static LevelPlayAdSize LARGE = new LevelPlayAdSize(PlatformLevelPlayAdSizeType.Large);

		// Token: 0x04000038 RID: 56
		public static LevelPlayAdSize MEDIUM_RECTANGLE = new LevelPlayAdSize(PlatformLevelPlayAdSizeType.MediumRectangle);

		// Token: 0x04000039 RID: 57
		public static LevelPlayAdSize LEADERBOARD = new LevelPlayAdSize(PlatformLevelPlayAdSizeType.LeaderBoard);
	}
}
