using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000415 RID: 1045
	[Flags]
	public enum SortingCriteria
	{
		// Token: 0x04000D4A RID: 3402
		None = 0,
		// Token: 0x04000D4B RID: 3403
		SortingLayer = 1,
		// Token: 0x04000D4C RID: 3404
		RenderQueue = 2,
		// Token: 0x04000D4D RID: 3405
		BackToFront = 4,
		// Token: 0x04000D4E RID: 3406
		QuantizedFrontToBack = 8,
		// Token: 0x04000D4F RID: 3407
		OptimizeStateChanges = 16,
		// Token: 0x04000D50 RID: 3408
		CanvasOrder = 32,
		// Token: 0x04000D51 RID: 3409
		RendererPriority = 64,
		// Token: 0x04000D52 RID: 3410
		CommonOpaque = 59,
		// Token: 0x04000D53 RID: 3411
		CommonTransparent = 23
	}
}
