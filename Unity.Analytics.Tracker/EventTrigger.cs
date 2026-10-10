using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000011 RID: 17
	[Serializable]
	public class EventTrigger
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0000292C File Offset: 0x00000B2C
		public TriggerType triggerType
		{
			get
			{
				return this.m_Type;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002934 File Offset: 0x00000B34
		public TriggerLifecycleEvent lifecycleEvent
		{
			get
			{
				return this.m_LifecycleEvent;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003F RID: 63 RVA: 0x0000293C File Offset: 0x00000B3C
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00002944 File Offset: 0x00000B44
		public float initTime
		{
			get
			{
				return this.m_InitTime;
			}
			set
			{
				this.m_InitTime = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000041 RID: 65 RVA: 0x0000294D File Offset: 0x00000B4D
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002955 File Offset: 0x00000B55
		public float repeatTime
		{
			get
			{
				return this.m_RepeatTime;
			}
			set
			{
				this.m_RepeatTime = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000043 RID: 67 RVA: 0x0000295E File Offset: 0x00000B5E
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002966 File Offset: 0x00000B66
		public int repetitions
		{
			get
			{
				return this.m_Repetitions;
			}
			set
			{
				this.m_Repetitions = value;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000296F File Offset: 0x00000B6F
		public EventTrigger()
		{
			this.m_Rules = new TriggerListContainer();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000029A0 File Offset: 0x00000BA0
		public void AddRule()
		{
			TriggerRule item = new TriggerRule();
			this.m_Rules.rules.Add(item);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000029C4 File Offset: 0x00000BC4
		public void RemoveRule(int index)
		{
			this.m_Rules.rules.RemoveAt(index);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000029D8 File Offset: 0x00000BD8
		public bool Test(GameObject gameObject = null)
		{
			if (!this.m_ApplyRules)
			{
				return true;
			}
			if (this.repetitions > 0 && this.repetitionCount >= this.repetitions)
			{
				return false;
			}
			bool flag = false;
			int num = 0;
			int num2 = 0;
			foreach (TriggerRule triggerRule in this.m_Rules.rules)
			{
				num2++;
				bool flag2;
				string text;
				if (triggerRule.Test(out flag2, out text))
				{
					num++;
				}
				else if (flag2)
				{
					Debug.LogWarningFormat("Event trigger rule {0}{2} is incomplete ({1}). Result is false.", new object[]
					{
						num2,
						text,
						(gameObject == null) ? null : string.Format(" on GameObject '{0}'", gameObject.name)
					});
				}
				switch (this.m_TriggerBool)
				{
				case TriggerBool.All:
					if (num < num2)
					{
						flag = false;
					}
					break;
				case TriggerBool.Any:
					if (num > 0)
					{
						flag = true;
					}
					break;
				case TriggerBool.None:
					if (num > 0)
					{
						flag = false;
					}
					break;
				}
			}
			if ((this.m_TriggerBool == TriggerBool.All && num == num2) || (this.m_TriggerBool == TriggerBool.None && num == 0))
			{
				flag = true;
			}
			if (this.repetitions > 0 && flag)
			{
				this.repetitionCount++;
			}
			return flag;
		}

		// Token: 0x04000044 RID: 68
		[SerializeField]
		private bool m_IsTriggerExpanded = true;

		// Token: 0x04000045 RID: 69
		[SerializeField]
		private TriggerType m_Type;

		// Token: 0x04000046 RID: 70
		[SerializeField]
		private TriggerLifecycleEvent m_LifecycleEvent;

		// Token: 0x04000047 RID: 71
		[SerializeField]
		private bool m_ApplyRules;

		// Token: 0x04000048 RID: 72
		[SerializeField]
		private TriggerListContainer m_Rules;

		// Token: 0x04000049 RID: 73
		[SerializeField]
		private TriggerBool m_TriggerBool;

		// Token: 0x0400004A RID: 74
		[SerializeField]
		private float m_InitTime = 5f;

		// Token: 0x0400004B RID: 75
		[SerializeField]
		private float m_RepeatTime = 5f;

		// Token: 0x0400004C RID: 76
		[SerializeField]
		private int m_Repetitions;

		// Token: 0x0400004D RID: 77
		public int repetitionCount;

		// Token: 0x0400004E RID: 78
		private EventTrigger.OnTrigger m_TriggerFunction;

		// Token: 0x0400004F RID: 79
		[SerializeField]
		private TriggerMethod m_Method;

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x0600006A RID: 106
		internal delegate void OnTrigger();
	}
}
