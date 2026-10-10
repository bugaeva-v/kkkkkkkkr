using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020003D7 RID: 983
[CreateAssetMenu(fileName = "assetProfilePack", menuName = "ROMANCE/Create assetProfilePackX", order = 1)]
public class AssetProfilePack : ScriptableObject
{
	// Token: 0x040021FC RID: 8700
	public int index;

	// Token: 0x040021FD RID: 8701
	public List<Sprite> publicProfileThemes;

	// Token: 0x040021FE RID: 8702
	public List<Sprite> publicProfileChars;

	// Token: 0x040021FF RID: 8703
	public List<Sprite> publicProfileCutscenes;
}
