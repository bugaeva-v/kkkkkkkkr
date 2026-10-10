using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020003A4 RID: 932
	[Flags]
	public enum MeshUpdateFlags
	{
		// Token: 0x04000A47 RID: 2631
		Default = 0,
		// Token: 0x04000A48 RID: 2632
		DontValidateIndices = 1,
		// Token: 0x04000A49 RID: 2633
		DontResetBoneBounds = 2,
		// Token: 0x04000A4A RID: 2634
		DontNotifyMeshUsers = 4,
		// Token: 0x04000A4B RID: 2635
		DontRecalculateBounds = 8
	}
}
