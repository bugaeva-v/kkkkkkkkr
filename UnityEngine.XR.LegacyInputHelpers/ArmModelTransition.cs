using System;

namespace UnityEngine.XR.LegacyInputHelpers
{
	// Token: 0x02000006 RID: 6
	[Serializable]
	public class ArmModelTransition
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00002F5D File Offset: 0x0000115D
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00002F65 File Offset: 0x00001165
		public string transitionKeyName
		{
			get
			{
				return this.m_KeyName;
			}
			set
			{
				this.m_KeyName = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002F6E File Offset: 0x0000116E
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002F76 File Offset: 0x00001176
		public ArmModel armModel
		{
			get
			{
				return this.m_ArmModel;
			}
			set
			{
				this.m_ArmModel = value;
			}
		}

		// Token: 0x04000037 RID: 55
		[SerializeField]
		private string m_KeyName;

		// Token: 0x04000038 RID: 56
		[SerializeField]
		private ArmModel m_ArmModel;
	}
}
