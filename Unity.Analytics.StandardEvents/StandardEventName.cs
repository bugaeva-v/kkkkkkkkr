using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000004 RID: 4
	[AttributeUsage(AttributeTargets.Struct)]
	public class StandardEventName : AnalyticsEventAttribute
	{
		// Token: 0x0600004C RID: 76 RVA: 0x00003C25 File Offset: 0x00001E25
		public StandardEventName(string sendName, string path, string tooltip)
		{
			this.sendName = sendName;
			this.path = path;
			this.tooltip = tooltip;
		}

		// Token: 0x04000007 RID: 7
		public string sendName;

		// Token: 0x04000008 RID: 8
		public string path;

		// Token: 0x04000009 RID: 9
		public string tooltip;
	}
}
