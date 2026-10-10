using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020003B7 RID: 951
	public enum CameraEvent
	{
		// Token: 0x04000AE6 RID: 2790
		BeforeDepthTexture,
		// Token: 0x04000AE7 RID: 2791
		AfterDepthTexture,
		// Token: 0x04000AE8 RID: 2792
		BeforeDepthNormalsTexture,
		// Token: 0x04000AE9 RID: 2793
		AfterDepthNormalsTexture,
		// Token: 0x04000AEA RID: 2794
		BeforeGBuffer,
		// Token: 0x04000AEB RID: 2795
		AfterGBuffer,
		// Token: 0x04000AEC RID: 2796
		BeforeLighting,
		// Token: 0x04000AED RID: 2797
		AfterLighting,
		// Token: 0x04000AEE RID: 2798
		BeforeFinalPass,
		// Token: 0x04000AEF RID: 2799
		AfterFinalPass,
		// Token: 0x04000AF0 RID: 2800
		BeforeForwardOpaque,
		// Token: 0x04000AF1 RID: 2801
		AfterForwardOpaque,
		// Token: 0x04000AF2 RID: 2802
		BeforeImageEffectsOpaque,
		// Token: 0x04000AF3 RID: 2803
		AfterImageEffectsOpaque,
		// Token: 0x04000AF4 RID: 2804
		BeforeSkybox,
		// Token: 0x04000AF5 RID: 2805
		AfterSkybox,
		// Token: 0x04000AF6 RID: 2806
		BeforeForwardAlpha,
		// Token: 0x04000AF7 RID: 2807
		AfterForwardAlpha,
		// Token: 0x04000AF8 RID: 2808
		BeforeImageEffects,
		// Token: 0x04000AF9 RID: 2809
		AfterImageEffects,
		// Token: 0x04000AFA RID: 2810
		AfterEverything,
		// Token: 0x04000AFB RID: 2811
		BeforeReflections,
		// Token: 0x04000AFC RID: 2812
		AfterReflections,
		// Token: 0x04000AFD RID: 2813
		BeforeHaloAndLensFlares,
		// Token: 0x04000AFE RID: 2814
		AfterHaloAndLensFlares
	}
}
