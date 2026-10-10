using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020003DB RID: 987
	[Flags]
	public enum RTClearFlags
	{
		// Token: 0x04000C07 RID: 3079
		None = 0,
		// Token: 0x04000C08 RID: 3080
		Color = 1,
		// Token: 0x04000C09 RID: 3081
		Depth = 2,
		// Token: 0x04000C0A RID: 3082
		Stencil = 4,
		// Token: 0x04000C0B RID: 3083
		All = 7,
		// Token: 0x04000C0C RID: 3084
		DepthStencil = 6,
		// Token: 0x04000C0D RID: 3085
		ColorDepth = 3,
		// Token: 0x04000C0E RID: 3086
		ColorStencil = 5
	}
}
