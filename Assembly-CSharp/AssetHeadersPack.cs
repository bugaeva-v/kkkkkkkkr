using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000036 RID: 54
[CreateAssetMenu(fileName = "assetHeadersPack", menuName = "ROMANCE/Create assetHeadersPack", order = 1)]
public class AssetHeadersPack : ScriptableObject
{
	// Token: 0x040001E0 RID: 480
	public List<AssetAnthology> anthologiesList;

	// Token: 0x040001E1 RID: 481
	public List<AssetStoryHeader> storyHeadersList;

	// Token: 0x040001E2 RID: 482
	public TextAsset recommendatioAlgorithmBalance;

	// Token: 0x040001E3 RID: 483
	public TextAsset storiesSearchBalance;
}
