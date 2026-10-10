using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000035 RID: 53
	[StandardEventName("user_signup", "Engagement", "Send this event when the player registers or logs in for the first time.")]
	public struct UserSignup
	{
		// Token: 0x040000EF RID: 239
		[RequiredParameter("authorization_network", "The authorization network or login service provider.", null)]
		[CustomizableEnum(true)]
		public AuthorizationNetwork authorizationNetwork;
	}
}
