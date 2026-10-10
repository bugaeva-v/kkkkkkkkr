using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200048D RID: 1165
[CreateAssetMenu(fileName = "assetLiveEventContentX", menuName = "ROMANCE/Create assetLiveEventContentX", order = 1)]
public class AssetLiveEventContent : ScriptableObject
{
	// Token: 0x0400275E RID: 10078
	public int index;

	// Token: 0x0400275F RID: 10079
	public List<Sprite> thumbnailLargeFramesFront;

	// Token: 0x04002760 RID: 10080
	public List<Sprite> thumbnailLargeFramesBack;

	// Token: 0x04002761 RID: 10081
	public Sprite logo;

	// Token: 0x04002762 RID: 10082
	public float logoScaleFactor = 1f;

	// Token: 0x04002763 RID: 10083
	public int logoOffsetY;

	// Token: 0x04002764 RID: 10084
	public int logoOffsetX;

	// Token: 0x04002765 RID: 10085
	public List<AssetLiveEventContentCustomLanguageLogoOffset> customLanguageLogoOffset;

	// Token: 0x04002766 RID: 10086
	public Sprite logoBackOptional;

	// Token: 0x04002767 RID: 10087
	public float logoBackOptionalScaleFactor = 1f;

	// Token: 0x04002768 RID: 10088
	public int logoBackOptionalOffsetY;

	// Token: 0x04002769 RID: 10089
	public int logoBackOptionalOffsetX;

	// Token: 0x0400276A RID: 10090
	public float frameChangeInterval = 0.18f;

	// Token: 0x0400276B RID: 10091
	public Color textColor;

	// Token: 0x0400276C RID: 10092
	public bool disableBackAnimationLoop;

	// Token: 0x0400276D RID: 10093
	public float innerShadowFrontAlpha = 1f;

	// Token: 0x0400276E RID: 10094
	public float innerShadowBackAlpha = 1f;
}
