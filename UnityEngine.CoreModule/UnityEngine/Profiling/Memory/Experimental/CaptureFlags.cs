using System;

namespace UnityEngine.Profiling.Memory.Experimental
{
	// Token: 0x0200027F RID: 639
	[Flags]
	public enum CaptureFlags : uint
	{
		// Token: 0x0400091A RID: 2330
		ManagedObjects = 1U,
		// Token: 0x0400091B RID: 2331
		NativeObjects = 2U,
		// Token: 0x0400091C RID: 2332
		NativeAllocations = 4U,
		// Token: 0x0400091D RID: 2333
		NativeAllocationSites = 8U,
		// Token: 0x0400091E RID: 2334
		NativeStackTraces = 16U
	}
}
