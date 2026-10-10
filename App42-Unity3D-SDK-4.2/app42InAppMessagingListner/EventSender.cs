using System;

namespace app42InAppMessagingListner
{
	// Token: 0x02000060 RID: 96
	public class EventSender
	{
		// Token: 0x0600039A RID: 922 RVA: 0x00014709 File Offset: 0x00012909
		public void Send(string eventTypeToProcess, string eventNameToProcess, bool isNewEvent)
		{
			this.EventType = eventTypeToProcess;
			this.EventName = eventNameToProcess;
			this.IsNewEventFired = isNewEvent;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00014720 File Offset: 0x00012920
		// (set) Token: 0x0600039C RID: 924 RVA: 0x00014727 File Offset: 0x00012927
		public string EventName
		{
			get
			{
				return EventSender.eventName;
			}
			set
			{
				EventSender.eventName = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600039D RID: 925 RVA: 0x0001472F File Offset: 0x0001292F
		// (set) Token: 0x0600039E RID: 926 RVA: 0x00014736 File Offset: 0x00012936
		public string EventType
		{
			get
			{
				return EventSender.eventType;
			}
			set
			{
				EventSender.eventType = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600039F RID: 927 RVA: 0x0001473E File Offset: 0x0001293E
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x00014745 File Offset: 0x00012945
		public bool IsNewEventFired
		{
			get
			{
				return EventSender.isNewEventFired;
			}
			set
			{
				EventSender.isNewEventFired = value;
			}
		}

		// Token: 0x0400017F RID: 383
		private static string eventName = "";

		// Token: 0x04000180 RID: 384
		private static string eventType = "";

		// Token: 0x04000181 RID: 385
		private static bool isNewEventFired = false;
	}
}
