using System;
using System.Collections.Generic;

// Token: 0x02000090 RID: 144
[Serializable]
public struct CustomAvatarFilteringOptions
{
	// Token: 0x0400067C RID: 1660
	public int avatarFilter;

	// Token: 0x0400067D RID: 1661
	public bool applyInsideStory;

	// Token: 0x0400067E RID: 1662
	public bool applyInsideLobby;

	// Token: 0x0400067F RID: 1663
	public bool appliesForTargetClothes;

	// Token: 0x04000680 RID: 1664
	public bool appliesForTargetFace;

	// Token: 0x04000681 RID: 1665
	public bool appliesForTargetBody;

	// Token: 0x04000682 RID: 1666
	public bool appliesForTargetTrinket;

	// Token: 0x04000683 RID: 1667
	public bool appliesForTargetHair;

	// Token: 0x04000684 RID: 1668
	public bool appliesForTargetOverlay;

	// Token: 0x04000685 RID: 1669
	public List<int> targetedAvatarFilters;
}
