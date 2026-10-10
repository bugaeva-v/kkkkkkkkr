using System;
using UnityEngine;

namespace Unity.Services.LevelPlay
{
	// Token: 0x0200000C RID: 12
	public sealed class LevelPlayBannerPosition
	{
		// Token: 0x060000B6 RID: 182 RVA: 0x000030C0 File Offset: 0x000012C0
		private LevelPlayBannerPosition(LevelPlayBannerPosition.Presets presets, Vector2 position = default(Vector2))
		{
			this.Position = position;
			this.Description = presets.ToString();
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000030E2 File Offset: 0x000012E2
		public LevelPlayBannerPosition(Vector2 position) : this(LevelPlayBannerPosition.Presets.Custom, position)
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000030ED File Offset: 0x000012ED
		public override string ToString()
		{
			return "Banner Position: " + this.Description;
		}

		// Token: 0x04000044 RID: 68
		internal readonly Vector2 Position;

		// Token: 0x04000045 RID: 69
		public readonly string Description;

		// Token: 0x04000046 RID: 70
		public static readonly LevelPlayBannerPosition TopLeft = new LevelPlayBannerPosition(LevelPlayBannerPosition.Presets.TopLeft, default(Vector2));

		// Token: 0x04000047 RID: 71
		public static readonly LevelPlayBannerPosition TopCenter = new LevelPlayBannerPosition(LevelPlayBannerPosition.Presets.TopCenter, default(Vector2));

		// Token: 0x04000048 RID: 72
		public static readonly LevelPlayBannerPosition TopRight = new LevelPlayBannerPosition(LevelPlayBannerPosition.Presets.TopRight, default(Vector2));

		// Token: 0x04000049 RID: 73
		public static readonly LevelPlayBannerPosition CenterLeft = new LevelPlayBannerPosition(LevelPlayBannerPosition.Presets.CenterLeft, default(Vector2));

		// Token: 0x0400004A RID: 74
		public static readonly LevelPlayBannerPosition Center = new LevelPlayBannerPosition(LevelPlayBannerPosition.Presets.Center, default(Vector2));

		// Token: 0x0400004B RID: 75
		public static readonly LevelPlayBannerPosition CenterRight = new LevelPlayBannerPosition(LevelPlayBannerPosition.Presets.CenterRight, default(Vector2));

		// Token: 0x0400004C RID: 76
		public static readonly LevelPlayBannerPosition BottomLeft = new LevelPlayBannerPosition(LevelPlayBannerPosition.Presets.BottomLeft, default(Vector2));

		// Token: 0x0400004D RID: 77
		public static readonly LevelPlayBannerPosition BottomCenter = new LevelPlayBannerPosition(LevelPlayBannerPosition.Presets.BottomCenter, default(Vector2));

		// Token: 0x0400004E RID: 78
		public static readonly LevelPlayBannerPosition BottomRight = new LevelPlayBannerPosition(LevelPlayBannerPosition.Presets.BottomRight, default(Vector2));

		// Token: 0x02000032 RID: 50
		private enum Presets
		{
			// Token: 0x040000ED RID: 237
			TopLeft,
			// Token: 0x040000EE RID: 238
			TopCenter,
			// Token: 0x040000EF RID: 239
			TopRight,
			// Token: 0x040000F0 RID: 240
			CenterLeft,
			// Token: 0x040000F1 RID: 241
			Center,
			// Token: 0x040000F2 RID: 242
			CenterRight,
			// Token: 0x040000F3 RID: 243
			BottomLeft,
			// Token: 0x040000F4 RID: 244
			BottomCenter,
			// Token: 0x040000F5 RID: 245
			BottomRight,
			// Token: 0x040000F6 RID: 246
			Custom
		}
	}
}
