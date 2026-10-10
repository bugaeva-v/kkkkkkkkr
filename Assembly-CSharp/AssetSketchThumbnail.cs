using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200015D RID: 349
[CreateAssetMenu(fileName = "assetSketchThumbnailX", menuName = "ROMANCE/Create assetSketchThumbnailX", order = 1)]
public class AssetSketchThumbnail : ScriptableObject
{
	// Token: 0x04000D69 RID: 3433
	public int sketchId;

	// Token: 0x04000D6A RID: 3434
	public List<Sprite> framesColor;

	// Token: 0x04000D6B RID: 3435
	public List<Sprite> framesGrayscale;

	// Token: 0x04000D6C RID: 3436
	public float frameChangeInterval = 0.1f;
}
