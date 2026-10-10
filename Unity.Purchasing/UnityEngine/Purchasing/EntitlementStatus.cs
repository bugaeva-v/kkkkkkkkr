using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000050 RID: 80
	public enum EntitlementStatus
	{
		// Token: 0x04000048 RID: 72
		Unknown,
		// Token: 0x04000049 RID: 73
		NotEntitled,
		// Token: 0x0400004A RID: 74
		EntitledUntilConsumed,
		// Token: 0x0400004B RID: 75
		EntitledButNotFinished,
		// Token: 0x0400004C RID: 76
		FullyEntitled
	}
}
