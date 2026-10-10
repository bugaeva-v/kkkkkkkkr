using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000004 RID: 4
	[Serializable]
	public class AnalyticsEventParam
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000021CF File Offset: 0x000003CF
		public AnalyticsEventParam.RequirementType requirementType
		{
			get
			{
				return this.m_RequirementType;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000021D7 File Offset: 0x000003D7
		public string groupID
		{
			get
			{
				return this.m_GroupID;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000021DF File Offset: 0x000003DF
		public ValueProperty valueProperty
		{
			get
			{
				return this.m_Value;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000021E7 File Offset: 0x000003E7
		public AnalyticsEventParam(string name)
		{
			this.m_Name = name.Trim();
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002206 File Offset: 0x00000406
		public string name
		{
			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000012 RID: 18 RVA: 0x0000220E File Offset: 0x0000040E
		public object value
		{
			get
			{
				return this.m_Value.propertyValue;
			}
		}

		// Token: 0x04000005 RID: 5
		[SerializeField]
		private AnalyticsEventParam.RequirementType m_RequirementType;

		// Token: 0x04000006 RID: 6
		[SerializeField]
		private string m_GroupID;

		// Token: 0x04000007 RID: 7
		[SerializeField]
		private string m_Tooltip = "";

		// Token: 0x04000008 RID: 8
		[SerializeField]
		private string m_Name;

		// Token: 0x04000009 RID: 9
		[SerializeField]
		private ValueProperty m_Value;

		// Token: 0x02000016 RID: 22
		public enum RequirementType
		{
			// Token: 0x0400005A RID: 90
			None,
			// Token: 0x0400005B RID: 91
			Required,
			// Token: 0x0400005C RID: 92
			Optional
		}
	}
}
