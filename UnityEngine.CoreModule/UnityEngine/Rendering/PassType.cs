using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020003BC RID: 956
	public enum PassType
	{
		// Token: 0x04000B30 RID: 2864
		Normal,
		// Token: 0x04000B31 RID: 2865
		Vertex,
		// Token: 0x04000B32 RID: 2866
		VertexLM,
		// Token: 0x04000B33 RID: 2867
		[Obsolete("VertexLMRGBM PassType is obsolete. Please use VertexLM PassType together with DecodeLightmap shader function.")]
		VertexLMRGBM,
		// Token: 0x04000B34 RID: 2868
		ForwardBase,
		// Token: 0x04000B35 RID: 2869
		ForwardAdd,
		// Token: 0x04000B36 RID: 2870
		LightPrePassBase,
		// Token: 0x04000B37 RID: 2871
		LightPrePassFinal,
		// Token: 0x04000B38 RID: 2872
		ShadowCaster,
		// Token: 0x04000B39 RID: 2873
		Deferred = 10,
		// Token: 0x04000B3A RID: 2874
		Meta,
		// Token: 0x04000B3B RID: 2875
		MotionVectors,
		// Token: 0x04000B3C RID: 2876
		ScriptableRenderPipeline,
		// Token: 0x04000B3D RID: 2877
		ScriptableRenderPipelineDefaultUnlit,
		// Token: 0x04000B3E RID: 2878
		GrabPass
	}
}
