using System;

namespace UnityEngine.Analytics
{
	// Token: 0x0200002D RID: 45
	[StandardEventName("social_share", "Engagement", "Send this event when the player posts a message, gift, or invitation through social media.")]
	public struct SocialShare
	{
		// Token: 0x040000DE RID: 222
		[RequiredParameter("share_type", "The mode of sharing, or media type used in the social engagement.", null)]
		[CustomizableEnum(true)]
		public ShareType shareType;

		// Token: 0x040000DF RID: 223
		[CustomizableEnum(true)]
		[RequiredParameter("social_network", "The network through which the message is shared.", null)]
		public SocialNetwork socialNetwork;

		// Token: 0x040000E0 RID: 224
		[OptionalParameter("sender_id", "A unique identifier for the sender.")]
		public string senderId;

		// Token: 0x040000E1 RID: 225
		[OptionalParameter("recipient_id", "A unique identifier for the recipient.")]
		public string recipientId;
	}
}
