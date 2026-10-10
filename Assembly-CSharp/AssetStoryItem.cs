using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020002BE RID: 702
[CreateAssetMenu(fileName = "assetStoryXItemY", menuName = "ROMANCE/Create assetStoryXItemY", order = 1)]
public class AssetStoryItem : ScriptableObject
{
	// Token: 0x040018DB RID: 6363
	public string id;

	// Token: 0x040018DC RID: 6364
	public List<string> mappings;

	// Token: 0x040018DD RID: 6365
	public Sprite sprite;
}
