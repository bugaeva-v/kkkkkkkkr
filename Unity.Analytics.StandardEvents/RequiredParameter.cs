using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000006 RID: 6
	[AttributeUsage(AttributeTargets.Field)]
	public class RequiredParameter : AnalyticsEventParameter
	{
		// Token: 0x0600004E RID: 78 RVA: 0x00003C5F File Offset: 0x00001E5F
		public RequiredParameter(string sendName, string tooltip, string groupId = null) : base(sendName, tooltip, groupId)
		{
		}
	}
}
