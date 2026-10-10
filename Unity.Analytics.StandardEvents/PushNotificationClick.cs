using System;

namespace UnityEngine.Analytics
{
	// Token: 0x0200002A RID: 42
	[StandardEventName("push_notification_click", "Engagement", "Send this event when the player responds to a push notification.")]
	public struct PushNotificationClick
	{
		// Token: 0x040000DC RID: 220
		[RequiredParameter("message_id", "The message name or ID.", null)]
		public string message_id;
	}
}
