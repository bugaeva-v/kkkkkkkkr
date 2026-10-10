using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020003D5 RID: 981
	[Flags]
	public enum CopyTextureSupport
	{
		// Token: 0x04000BEC RID: 3052
		None = 0,
		// Token: 0x04000BED RID: 3053
		Basic = 1,
		// Token: 0x04000BEE RID: 3054
		Copy3D = 2,
		// Token: 0x04000BEF RID: 3055
		DifferentTypes = 4,
		// Token: 0x04000BF0 RID: 3056
		TextureToRT = 8,
		// Token: 0x04000BF1 RID: 3057
		RTToTexture = 16
	}
}
