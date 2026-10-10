using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020003C5 RID: 965
	[Flags]
	public enum RenderTargetFlags
	{
		// Token: 0x04000B82 RID: 2946
		None = 0,
		// Token: 0x04000B83 RID: 2947
		ReadOnlyDepth = 1,
		// Token: 0x04000B84 RID: 2948
		ReadOnlyStencil = 2,
		// Token: 0x04000B85 RID: 2949
		ReadOnlyDepthStencil = 3
	}
}
