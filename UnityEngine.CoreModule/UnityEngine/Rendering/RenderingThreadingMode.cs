using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering
{
	// Token: 0x020003DD RID: 989
	[MovedFrom("UnityEngine.Experimental.Rendering")]
	public enum RenderingThreadingMode
	{
		// Token: 0x04000C15 RID: 3093
		Direct,
		// Token: 0x04000C16 RID: 3094
		SingleThreaded,
		// Token: 0x04000C17 RID: 3095
		MultiThreaded,
		// Token: 0x04000C18 RID: 3096
		LegacyJobified,
		// Token: 0x04000C19 RID: 3097
		NativeGraphicsJobs,
		// Token: 0x04000C1A RID: 3098
		NativeGraphicsJobsWithoutRenderThread
	}
}
