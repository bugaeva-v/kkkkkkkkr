using System;
using System.Collections.Generic;

namespace UnityEngine.Analytics
{
	// Token: 0x02000010 RID: 16
	[Serializable]
	public class TriggerListContainer
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002908 File Offset: 0x00000B08
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002910 File Offset: 0x00000B10
		internal List<TriggerRule> rules
		{
			get
			{
				return this.m_Rules;
			}
			set
			{
				this.m_Rules = value;
			}
		}

		// Token: 0x04000043 RID: 67
		[SerializeField]
		private List<TriggerRule> m_Rules = new List<TriggerRule>();
	}
}
