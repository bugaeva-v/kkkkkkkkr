using System;
using System.Collections.Generic;

// Token: 0x02000450 RID: 1104
[Serializable]
public class StoryChapterAssetPackInfo
{
	// Token: 0x040025C0 RID: 9664
	public int storyIndexOptional = -1;

	// Token: 0x040025C1 RID: 9665
	public int index;

	// Token: 0x040025C2 RID: 9666
	public bool keepAlive;

	// Token: 0x040025C3 RID: 9667
	public List<OnDemandResourcesCheckpoint> onDemandResourcesCheckpoints;
}
