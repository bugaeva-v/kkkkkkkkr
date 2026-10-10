using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000429 RID: 1065
	[Flags]
	public enum ShaderPropertyFlags
	{
		// Token: 0x04000DC7 RID: 3527
		None = 0,
		// Token: 0x04000DC8 RID: 3528
		HideInInspector = 1,
		// Token: 0x04000DC9 RID: 3529
		PerRendererData = 2,
		// Token: 0x04000DCA RID: 3530
		NoScaleOffset = 4,
		// Token: 0x04000DCB RID: 3531
		Normal = 8,
		// Token: 0x04000DCC RID: 3532
		HDR = 16,
		// Token: 0x04000DCD RID: 3533
		Gamma = 32,
		// Token: 0x04000DCE RID: 3534
		NonModifiableTextureData = 64,
		// Token: 0x04000DCF RID: 3535
		MainTexture = 128,
		// Token: 0x04000DD0 RID: 3536
		MainColor = 256
	}
}
