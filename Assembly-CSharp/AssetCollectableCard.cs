using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000047 RID: 71
[CreateAssetMenu(fileName = "assetCollectableCardX", menuName = "ROMANCE/Create assetCollectableCardX", order = 1)]
public class AssetCollectableCard : ScriptableObject
{
	// Token: 0x0400032B RID: 811
	public int index;

	// Token: 0x0400032C RID: 812
	public List<Sprite> frames;

	// Token: 0x0400032D RID: 813
	public float frameChangeInterval = 0.1f;
}
