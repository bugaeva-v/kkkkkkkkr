using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200003A RID: 58
[CreateAssetMenu(fileName = "assetLiveProfileThemeX", menuName = "ROMANCE/Create assetLiveProfileThemeX", order = 1)]
public class AssetLiveProfileTheme : ScriptableObject
{
	// Token: 0x0400025A RID: 602
	public int index;

	// Token: 0x0400025B RID: 603
	public List<Sprite> frames;

	// Token: 0x0400025C RID: 604
	public float frameChangeInterval = 0.08f;

	// Token: 0x0400025D RID: 605
	public int pauseFrame = -1;

	// Token: 0x0400025E RID: 606
	public float pauseTime;

	// Token: 0x0400025F RID: 607
	public bool reverseDirection;
}
