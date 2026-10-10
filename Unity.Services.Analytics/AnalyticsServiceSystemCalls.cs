using System;

namespace Unity.Services.Analytics
{
	// Token: 0x02000005 RID: 5
	internal class AnalyticsServiceSystemCalls : IAnalyticsServiceSystemCalls
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000023D6 File Offset: 0x000005D6
		public DateTime UtcNow
		{
			get
			{
				return DateTime.UtcNow;
			}
		}
	}
}
