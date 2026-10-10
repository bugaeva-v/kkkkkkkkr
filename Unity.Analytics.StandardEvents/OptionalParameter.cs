using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000007 RID: 7
	[AttributeUsage(AttributeTargets.Field)]
	public class OptionalParameter : AnalyticsEventParameter
	{
		// Token: 0x0600004F RID: 79 RVA: 0x00003C6A File Offset: 0x00001E6A
		public OptionalParameter(string sendName, string tooltip) : base(sendName, tooltip, null)
		{
		}
	}
}
