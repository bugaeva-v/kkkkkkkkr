using System;
using System.Collections;

namespace UnityEngine.Analytics
{
	// Token: 0x02000002 RID: 2
	[AddComponentMenu("Analytics/Analytics Event Tracker")]
	public class AnalyticsEventTracker : MonoBehaviour
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public StandardEventPayload payload
		{
			get
			{
				return this.m_EventPayload;
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		public void TriggerEvent()
		{
			this.SendEvent();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002061 File Offset: 0x00000261
		private AnalyticsResult SendEvent()
		{
			if (this.m_Trigger.Test(base.gameObject))
			{
				return this.payload.Send();
			}
			return AnalyticsResult.Ok;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002083 File Offset: 0x00000283
		private void Awake()
		{
			if (this.m_Trigger.triggerType == TriggerType.Lifecycle && this.m_Trigger.lifecycleEvent == TriggerLifecycleEvent.Awake)
			{
				this.SendEvent();
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020A7 File Offset: 0x000002A7
		private void Start()
		{
			if (this.m_Trigger.triggerType == TriggerType.Lifecycle && this.m_Trigger.lifecycleEvent == TriggerLifecycleEvent.Start)
			{
				this.SendEvent();
				return;
			}
			if (this.m_Trigger.triggerType == TriggerType.Timer)
			{
				base.StartCoroutine(this.TimedTrigger());
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020E7 File Offset: 0x000002E7
		private void OnEnable()
		{
			if (this.m_Trigger.triggerType == TriggerType.Lifecycle && this.m_Trigger.lifecycleEvent == TriggerLifecycleEvent.OnEnable)
			{
				this.SendEvent();
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000210B File Offset: 0x0000030B
		private void OnDisable()
		{
			if (this.m_Trigger.triggerType == TriggerType.Lifecycle && this.m_Trigger.lifecycleEvent == TriggerLifecycleEvent.OnDisable)
			{
				this.SendEvent();
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000212F File Offset: 0x0000032F
		private void OnApplicationPause(bool paused)
		{
			if (this.m_Trigger.triggerType == TriggerType.Lifecycle)
			{
				if (paused && this.m_Trigger.lifecycleEvent == TriggerLifecycleEvent.OnApplicationPause)
				{
					this.SendEvent();
					return;
				}
				if (!paused && this.m_Trigger.lifecycleEvent == TriggerLifecycleEvent.OnApplicationUnpause)
				{
					this.SendEvent();
				}
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000216F File Offset: 0x0000036F
		private void OnDestroy()
		{
			if (this.m_Trigger.triggerType == TriggerType.Lifecycle && this.m_Trigger.lifecycleEvent == TriggerLifecycleEvent.OnDestroy)
			{
				this.SendEvent();
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002193 File Offset: 0x00000393
		private IEnumerator TimedTrigger()
		{
			if (this.m_Trigger.initTime > 0f)
			{
				yield return new WaitForSeconds(this.m_Trigger.initTime);
			}
			this.SendEvent();
			while (this.m_Trigger.repetitions == 0 || this.m_Trigger.repetitionCount <= this.m_Trigger.repetitions)
			{
				if (this.m_Trigger.repeatTime > 0f)
				{
					yield return new WaitForSeconds(this.m_Trigger.repeatTime);
				}
				else
				{
					yield return null;
				}
				this.SendEvent();
			}
			yield break;
		}

		// Token: 0x04000001 RID: 1
		[SerializeField]
		public EventTrigger m_Trigger = new EventTrigger();

		// Token: 0x04000002 RID: 2
		[SerializeField]
		private StandardEventPayload m_EventPayload = new StandardEventPayload();
	}
}
