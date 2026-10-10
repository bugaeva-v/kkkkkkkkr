using System;

namespace UnityEngine.Rendering
{
	// Token: 0x0200040C RID: 1036
	[Flags]
	public enum RenderStateMask
	{
		// Token: 0x04000D28 RID: 3368
		Nothing = 0,
		// Token: 0x04000D29 RID: 3369
		Blend = 1,
		// Token: 0x04000D2A RID: 3370
		Raster = 2,
		// Token: 0x04000D2B RID: 3371
		Depth = 4,
		// Token: 0x04000D2C RID: 3372
		Stencil = 8,
		// Token: 0x04000D2D RID: 3373
		Everything = 15
	}
}
