using System;
using System.Collections.Generic;

namespace UnityEngine.Analytics
{
	// Token: 0x02000005 RID: 5
	[Serializable]
	public class AnalyticsEventParamListContainer
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000013 RID: 19 RVA: 0x0000221B File Offset: 0x0000041B
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002223 File Offset: 0x00000423
		public List<AnalyticsEventParam> parameters
		{
			get
			{
				return this.m_Parameters;
			}
			set
			{
				this.m_Parameters = value;
			}
		}

		// Token: 0x0400000A RID: 10
		[SerializeField]
		private List<AnalyticsEventParam> m_Parameters = new List<AnalyticsEventParam>();
	}
}
