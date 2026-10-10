using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000017 RID: 23
	[StandardEventName("ad_offer", "Monetization", "Send this event when the player is offered the opportunity to view an ad.")]
	public struct AdOffer
	{
		// Token: 0x040000A9 RID: 169
		[RequiredParameter("rewarded", "Set to true if a reward is offered for this ad.", null)]
		public bool rewarded;

		// Token: 0x040000AA RID: 170
		[OptionalParameter("network", "The ad or mediation network provider.")]
		[CustomizableEnum(true)]
		public AdvertisingNetwork network;

		// Token: 0x040000AB RID: 171
		[OptionalParameter("placement_id", "An ad placement or configuration ID.")]
		public string placementId;
	}
}
