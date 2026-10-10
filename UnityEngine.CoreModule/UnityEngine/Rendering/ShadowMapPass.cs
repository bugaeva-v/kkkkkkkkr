using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020003BA RID: 954
	[Flags]
	public enum ShadowMapPass
	{
		// Token: 0x04000B09 RID: 2825
		PointlightPositiveX = 1,
		// Token: 0x04000B0A RID: 2826
		PointlightNegativeX = 2,
		// Token: 0x04000B0B RID: 2827
		PointlightPositiveY = 4,
		// Token: 0x04000B0C RID: 2828
		PointlightNegativeY = 8,
		// Token: 0x04000B0D RID: 2829
		PointlightPositiveZ = 16,
		// Token: 0x04000B0E RID: 2830
		PointlightNegativeZ = 32,
		// Token: 0x04000B0F RID: 2831
		DirectionalCascade0 = 64,
		// Token: 0x04000B10 RID: 2832
		DirectionalCascade1 = 128,
		// Token: 0x04000B11 RID: 2833
		DirectionalCascade2 = 256,
		// Token: 0x04000B12 RID: 2834
		DirectionalCascade3 = 512,
		// Token: 0x04000B13 RID: 2835
		Spotlight = 1024,
		// Token: 0x04000B14 RID: 2836
		Pointlight = 63,
		// Token: 0x04000B15 RID: 2837
		Directional = 960,
		// Token: 0x04000B16 RID: 2838
		All = 2047
	}
}
