using System;

namespace UnityEngine.Analytics
{
	// Token: 0x0200001A RID: 26
	[StandardEventName("post_ad_action", "Monetization", "Send this event with the first action a player takes after an ad is shown, or after an ad is offered but not shown.")]
	public struct PostAdAction
	{
		// Token: 0x040000B2 RID: 178
		[RequiredParameter("rewarded", "Set to true if a reward is offered for this ad.", null)]
		public bool rewarded;

		// Token: 0x040000B3 RID: 179
		[OptionalParameter("network", "The ad or mediation network provider.")]
		[CustomizableEnum(true)]
		public AdvertisingNetwork network;

		// Token: 0x040000B4 RID: 180
		[OptionalParameter("placement_id", "An ad placement or configuration ID.")]
		public string placementId;
	}
}
