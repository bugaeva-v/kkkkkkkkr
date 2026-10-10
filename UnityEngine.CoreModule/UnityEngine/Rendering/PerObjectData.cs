using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000403 RID: 1027
	[Flags]
	public enum PerObjectData
	{
		// Token: 0x04000CF3 RID: 3315
		None = 0,
		// Token: 0x04000CF4 RID: 3316
		LightProbe = 1,
		// Token: 0x04000CF5 RID: 3317
		ReflectionProbes = 2,
		// Token: 0x04000CF6 RID: 3318
		LightProbeProxyVolume = 4,
		// Token: 0x04000CF7 RID: 3319
		Lightmaps = 8,
		// Token: 0x04000CF8 RID: 3320
		LightData = 16,
		// Token: 0x04000CF9 RID: 3321
		MotionVectors = 32,
		// Token: 0x04000CFA RID: 3322
		LightIndices = 64,
		// Token: 0x04000CFB RID: 3323
		ReflectionProbeData = 128,
		// Token: 0x04000CFC RID: 3324
		OcclusionProbe = 256,
		// Token: 0x04000CFD RID: 3325
		OcclusionProbeProxyVolume = 512,
		// Token: 0x04000CFE RID: 3326
		ShadowMask = 1024
	}
}
