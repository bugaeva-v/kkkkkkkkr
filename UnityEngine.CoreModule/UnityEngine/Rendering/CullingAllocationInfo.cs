using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020003FB RID: 1019
	internal struct CullingAllocationInfo
	{
		// Token: 0x04000CCD RID: 3277
		public unsafe VisibleLight* visibleLightsPtr;

		// Token: 0x04000CCE RID: 3278
		public unsafe VisibleLight* visibleOffscreenVertexLightsPtr;

		// Token: 0x04000CCF RID: 3279
		public unsafe VisibleReflectionProbe* visibleReflectionProbesPtr;

		// Token: 0x04000CD0 RID: 3280
		public int visibleLightCount;

		// Token: 0x04000CD1 RID: 3281
		public int visibleOffscreenVertexLightCount;

		// Token: 0x04000CD2 RID: 3282
		public int visibleReflectionProbeCount;
	}
}
