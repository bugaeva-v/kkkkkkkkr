using System;

namespace UnityEngine.Analytics
{
	// Token: 0x0200002E RID: 46
	[StandardEventName("social_share_accept", "Engagement", "Send this event when the player accepts a message, gift, or invitation through social media.")]
	public struct SocialShareAccept
	{
		// Token: 0x040000E2 RID: 226
		[RequiredParameter("share_type", "The mode of sharing, or media type used in the social engagement.", null)]
		[CustomizableEnum(true)]
		public ShareType shareType;

		// Token: 0x040000E3 RID: 227
		[CustomizableEnum(true)]
		[RequiredParameter("social_network", "The network through which the message is shared.", null)]
		public SocialNetwork socialNetwork;

		// Token: 0x040000E4 RID: 228
		[OptionalParameter("sender_id", "A unique identifier for the sender.")]
		public string senderId;

		// Token: 0x040000E5 RID: 229
		[OptionalParameter("recipient_id", "A unique identifier for the recipient.")]
		public string recipientId;
	}
}
