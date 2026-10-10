using System;
using UnityEngine;

// Token: 0x020004F4 RID: 1268
[CreateAssetMenu(fileName = "assetLiveEventX", menuName = "ROMANCE/Create assetLiveEventX", order = 1)]
public class AssetLiveEvent : ScriptableObject
{
	// Token: 0x04002A44 RID: 10820
	public EGMCEPOABBF eventType;

	// Token: 0x04002A45 RID: 10821
	public int contentIndex;

	// Token: 0x04002A46 RID: 10822
	public string extraData;

	// Token: 0x04002A47 RID: 10823
	public string liveEventId;

	// Token: 0x04002A48 RID: 10824
	public int minRevision;

	// Token: 0x04002A49 RID: 10825
	public string startDateUTC;

	// Token: 0x04002A4A RID: 10826
	public string endDateUTC;

	// Token: 0x04002A4B RID: 10827
	public int priority;

	// Token: 0x04002A4C RID: 10828
	public int featureCount;

	// Token: 0x04002A4D RID: 10829
	public int previewSeconds;

	// Token: 0x04002A4E RID: 10830
	public bool eventIsHidden;

	// Token: 0x04002A4F RID: 10831
	public bool timerIsHidden;

	// Token: 0x04002A50 RID: 10832
	public string secret = "";

	// Token: 0x04002A51 RID: 10833
	public string supportedLanguages = "";

	// Token: 0x04002A52 RID: 10834
	public bool lowEndVersionAvailable;

	// Token: 0x04002A53 RID: 10835
	public string freePassIndex = "-1";

	// Token: 0x04002A54 RID: 10836
	public int useMessageV2Text;

	// Token: 0x04002A55 RID: 10837
	public string openUrlOnClick = "";
}
