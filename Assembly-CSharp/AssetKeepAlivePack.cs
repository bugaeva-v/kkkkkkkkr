using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020004F2 RID: 1266
[CreateAssetMenu(fileName = "assetKeepAlivePackX", menuName = "ROMANCE/Create assetKeepAlivePackX", order = 1)]
public class AssetKeepAlivePack : ScriptableObject
{
	// Token: 0x04002A1E RID: 10782
	public int index;

	// Token: 0x04002A1F RID: 10783
	public List<AudioClip> sfxList;

	// Token: 0x04002A20 RID: 10784
	public List<AudioClip> musicList;

	// Token: 0x04002A21 RID: 10785
	public List<AudioClip> ambientList;
}
