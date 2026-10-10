using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000005 RID: 5
	public class AnalyticsEventParameter : AnalyticsEventAttribute
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00003C42 File Offset: 0x00001E42
		public AnalyticsEventParameter(string sendName, string tooltip, string groupId = null)
		{
			this.sendName = sendName;
			this.tooltip = tooltip;
			this.groupId = groupId;
		}

		// Token: 0x0400000A RID: 10
		public string sendName;

		// Token: 0x0400000B RID: 11
		public string tooltip;

		// Token: 0x0400000C RID: 12
		public string groupId;
	}
}
