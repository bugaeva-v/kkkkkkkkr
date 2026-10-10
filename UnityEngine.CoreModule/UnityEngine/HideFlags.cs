using System;

namespace UnityEngine
{
	// Token: 0x02000226 RID: 550
	[Flags]
	public enum HideFlags
	{
		// Token: 0x0400081B RID: 2075
		None = 0,
		// Token: 0x0400081C RID: 2076
		HideInHierarchy = 1,
		// Token: 0x0400081D RID: 2077
		HideInInspector = 2,
		// Token: 0x0400081E RID: 2078
		DontSaveInEditor = 4,
		// Token: 0x0400081F RID: 2079
		NotEditable = 8,
		// Token: 0x04000820 RID: 2080
		DontSaveInBuild = 16,
		// Token: 0x04000821 RID: 2081
		DontUnloadUnusedAsset = 32,
		// Token: 0x04000822 RID: 2082
		DontSave = 52,
		// Token: 0x04000823 RID: 2083
		HideAndDontSave = 61
	}
}
