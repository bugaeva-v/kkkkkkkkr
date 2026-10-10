using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200019C RID: 412
[CreateAssetMenu(fileName = "assetStoryInkHeader", menuName = "ROMANCE/Create assetStoryInkHeader", order = 1)]
public class AssetStoryInkHeader : ScriptableObject
{
	// Token: 0x04000F80 RID: 3968
	public int revision;

	// Token: 0x04000F81 RID: 3969
	public List<StoryChapterLanguageSupport2> chapterSupportedLanguages;
}
