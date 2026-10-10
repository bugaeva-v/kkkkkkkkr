using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000464 RID: 1124
[CreateAssetMenu(fileName = "assetSketchActorsX", menuName = "ROMANCE/Create assetSketchActorsX", order = 1)]
public class AssetSketchActors : ScriptableObject
{
	// Token: 0x0400262D RID: 9773
	public int sketchId;

	// Token: 0x0400262E RID: 9774
	public List<Sprite> actors;
}
