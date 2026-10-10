using System;

namespace UnityEngine
{
	// Token: 0x02000187 RID: 391
	[Flags]
	public enum MaterialGlobalIlluminationFlags
	{
		// Token: 0x04000575 RID: 1397
		None = 0,
		// Token: 0x04000576 RID: 1398
		RealtimeEmissive = 1,
		// Token: 0x04000577 RID: 1399
		BakedEmissive = 2,
		// Token: 0x04000578 RID: 1400
		EmissiveIsBlack = 4,
		// Token: 0x04000579 RID: 1401
		AnyEmissive = 3
	}
}
