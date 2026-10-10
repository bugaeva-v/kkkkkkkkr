using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020003AA RID: 938
	public enum RenderQueue
	{
		// Token: 0x04000A78 RID: 2680
		Background = 1000,
		// Token: 0x04000A79 RID: 2681
		Geometry = 2000,
		// Token: 0x04000A7A RID: 2682
		AlphaTest = 2450,
		// Token: 0x04000A7B RID: 2683
		GeometryLast = 2500,
		// Token: 0x04000A7C RID: 2684
		Transparent = 3000,
		// Token: 0x04000A7D RID: 2685
		Overlay = 4000
	}
}
