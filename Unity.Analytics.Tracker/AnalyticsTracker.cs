using System;
using System.Collections.Generic;

namespace UnityEngine.Analytics
{
	// Token: 0x0200000A RID: 10
	[AddComponentMenu("")]
	[Obsolete("Analytics Tracker is deprecated. Use Analytics Event Tracker instead!")]
	public class AnalyticsTracker : MonoBehaviour
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002731 File Offset: 0x00000931
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002739 File Offset: 0x00000939
		public string eventName
		{
			get
			{
				return this.m_EventName;
			}
			set
			{
				this.m_EventName = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002742 File Offset: 0x00000942
		// (set) Token: 0x0600002B RID: 43 RVA: 0x0000274A File Offset: 0x0000094A
		internal TrackableProperty TP
		{
			get
			{
				return this.m_TrackableProperty;
			}
			set
			{
				this.m_TrackableProperty = value;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002753 File Offset: 0x00000953
		private void Awake()
		{
			if (this.m_Trigger == AnalyticsTracker.Trigger.Awake)
			{
				this.TriggerEvent();
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002764 File Offset: 0x00000964
		private void Start()
		{
			if (this.m_Trigger == AnalyticsTracker.Trigger.Start)
			{
				this.TriggerEvent();
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002775 File Offset: 0x00000975
		private void OnEnable()
		{
			if (this.m_Trigger == AnalyticsTracker.Trigger.OnEnable)
			{
				this.TriggerEvent();
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002786 File Offset: 0x00000986
		private void OnDisable()
		{
			if (this.m_Trigger == AnalyticsTracker.Trigger.OnDisable)
			{
				this.TriggerEvent();
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002797 File Offset: 0x00000997
		private void OnApplicationPause()
		{
			if (this.m_Trigger == AnalyticsTracker.Trigger.OnApplicationPause)
			{
				this.TriggerEvent();
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000027A8 File Offset: 0x000009A8
		private void OnDestroy()
		{
			if (this.m_Trigger == AnalyticsTracker.Trigger.OnDestroy)
			{
				this.TriggerEvent();
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000027B9 File Offset: 0x000009B9
		public void TriggerEvent()
		{
			this.BuildParameters();
			this.SendEvent();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000027C7 File Offset: 0x000009C7
		private void SendEvent()
		{
			Analytics.CustomEvent(this.m_EventName, this.m_Dict);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000027DC File Offset: 0x000009DC
		private void BuildParameters()
		{
			int hashCode = this.m_TrackableProperty.GetHashCode();
			if (hashCode != this.m_PrevDictHash)
			{
				this.m_Dict.Clear();
			}
			this.m_PrevDictHash = hashCode;
			int i = 0;
			int count = this.m_TrackableProperty.fields.Count;
			while (i < count)
			{
				TrackableProperty.FieldWithTarget fieldWithTarget = this.m_TrackableProperty.fields[i];
				if (fieldWithTarget.target != null || fieldWithTarget.doStatic)
				{
					string value = fieldWithTarget.GetValue().ToString();
					this.m_Dict[fieldWithTarget.paramName] = value;
				}
				i++;
			}
		}

		// Token: 0x04000021 RID: 33
		[SerializeField]
		private string m_EventName;

		// Token: 0x04000022 RID: 34
		private Dictionary<string, object> m_Dict = new Dictionary<string, object>();

		// Token: 0x04000023 RID: 35
		private int m_PrevDictHash;

		// Token: 0x04000024 RID: 36
		[SerializeField]
		private TrackableProperty m_TrackableProperty = new TrackableProperty();

		// Token: 0x04000025 RID: 37
		[SerializeField]
		internal AnalyticsTracker.Trigger m_Trigger;

		// Token: 0x02000018 RID: 24
		[Serializable]
		internal enum Trigger
		{
			// Token: 0x04000062 RID: 98
			External,
			// Token: 0x04000063 RID: 99
			Awake,
			// Token: 0x04000064 RID: 100
			Start,
			// Token: 0x04000065 RID: 101
			OnEnable,
			// Token: 0x04000066 RID: 102
			OnDisable,
			// Token: 0x04000067 RID: 103
			OnApplicationPause,
			// Token: 0x04000068 RID: 104
			OnDestroy
		}
	}
}
