using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200025B RID: 603
[CreateAssetMenu(fileName = "assetSketchesData", menuName = "ROMANCE/Create assetSketchesData", order = 1)]
public class AssetSketchesData : ScriptableObject
{
	// Token: 0x04001548 RID: 5448
	public List<TextAsset> sketchesFramesList;

	// Token: 0x04001549 RID: 5449
	public List<TextAsset> sketchesActorsList;

	// Token: 0x0400154A RID: 5450
	public List<TextAsset> sketchesLayersList;

	// Token: 0x0400154B RID: 5451
	public List<TextAsset> sketchesDialogsList;
}
