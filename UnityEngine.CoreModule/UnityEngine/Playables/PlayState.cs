using System;

namespace UnityEngine.Playables
{
	// Token: 0x02000447 RID: 1095
	public enum PlayState
	{
		// Token: 0x04000E29 RID: 3625
		Paused,
		// Token: 0x04000E2A RID: 3626
		Playing,
		// Token: 0x04000E2B RID: 3627
		[Obsolete("Delayed is obsolete; use a custom ScriptPlayable to implement this feature", false)]
		Delayed
	}
}
