using System;
using System.Collections.Generic;

namespace UnityEngine.Analytics
{
	// Token: 0x02000006 RID: 6
	[Serializable]
	public class StandardEventPayload
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000016 RID: 22 RVA: 0x0000223F File Offset: 0x0000043F
		public AnalyticsEventParamListContainer parameters
		{
			get
			{
				return this.m_Parameters;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002247 File Offset: 0x00000447
		// (set) Token: 0x06000018 RID: 24 RVA: 0x0000224F File Offset: 0x0000044F
		public string name
		{
			get
			{
				return this.m_Name;
			}
			set
			{
				this.m_Name = value;
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002258 File Offset: 0x00000458
		public StandardEventPayload()
		{
			this.m_Parameters = new AnalyticsEventParamListContainer();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002288 File Offset: 0x00000488
		public virtual AnalyticsResult Send()
		{
			if (string.IsNullOrEmpty(this.name))
			{
				throw new Exception("Analtyics Event Tracker failed to send the CustomEvent. The event Name field cannot be empty.");
			}
			if (!this.IsCustomDataValid())
			{
				throw new Exception("Analytics event tracker failed to send. The event data is not valid. Parameter names cannot be null or empty.");
			}
			if (!this.IsRequiredDataValid())
			{
				throw new Exception("Analytics event tracker failed to send. The event data is not valid. Please check the values of required parameters.");
			}
			return AnalyticsEvent.Custom(this.name.Trim(), this.GetParameters());
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000022EC File Offset: 0x000004EC
		private IDictionary<string, object> GetParameters()
		{
			StandardEventPayload.m_EventData.Clear();
			List<AnalyticsEventParam> parameters = this.parameters.parameters;
			for (int i = 0; i < parameters.Count; i++)
			{
				if (parameters[i] != null && parameters[i].valueProperty.IsValid())
				{
					StandardEventPayload.m_EventData.Add(parameters[i].name, parameters[i].value);
				}
			}
			return StandardEventPayload.m_EventData;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002364 File Offset: 0x00000564
		private bool IsCustomDataValid()
		{
			List<AnalyticsEventParam> parameters = this.parameters.parameters;
			for (int i = 0; i < parameters.Count; i++)
			{
				if (parameters[i] != null && string.IsNullOrEmpty(parameters[i].name) && parameters[i].valueProperty.IsValid())
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000023C0 File Offset: 0x000005C0
		private bool IsRequiredDataValid()
		{
			List<AnalyticsEventParam> parameters = this.parameters.parameters;
			Dictionary<string, List<bool>> dictionary = new Dictionary<string, List<bool>>();
			for (int i = 0; i < parameters.Count; i++)
			{
				if (parameters[i] != null && parameters[i].requirementType == AnalyticsEventParam.RequirementType.Required)
				{
					if (string.IsNullOrEmpty(parameters[i].groupID))
					{
						if (!dictionary.ContainsKey("none"))
						{
							dictionary.Add("none", new List<bool>());
						}
						dictionary["none"].Add(parameters[i].valueProperty.IsValid());
					}
					else
					{
						if (!dictionary.ContainsKey(parameters[i].groupID))
						{
							dictionary.Add(parameters[i].groupID, new List<bool>());
						}
						dictionary[parameters[i].groupID].Add(parameters[i].valueProperty.IsValid());
					}
				}
			}
			foreach (string text in dictionary.Keys)
			{
				if (text != null && text == "none")
				{
					if (dictionary[text].Contains(false))
					{
						return false;
					}
				}
				else if (!dictionary[text].Contains(true))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0400000B RID: 11
		[SerializeField]
		private bool m_IsEventExpanded = true;

		// Token: 0x0400000C RID: 12
		[SerializeField]
		private string m_StandardEventType = "CustomEvent";

		// Token: 0x0400000D RID: 13
		public Type standardEventType;

		// Token: 0x0400000E RID: 14
		[SerializeField]
		private AnalyticsEventParamListContainer m_Parameters;

		// Token: 0x0400000F RID: 15
		private static Dictionary<string, object> m_EventData = new Dictionary<string, object>();

		// Token: 0x04000010 RID: 16
		[SerializeField]
		private string m_Name = "";
	}
}
