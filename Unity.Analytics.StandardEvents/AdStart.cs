using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000019 RID: 25
	[StandardEventName("ad_start", "Monetization", "Send this event when playback of an ad begins.")]
	public struct AdStart
	{
		// Token: 0x040000AF RID: 175
		[RequiredParameter("rewarded", "Set to true if a reward is offered for this ad.", null)]
		public bool rewarded;

		// Token: 0x040000B0 RID: 176
		[OptionalParameter("network", "The ad or mediation network provider.")]
		[CustomizableEnum(true)]
		public AdvertisingNetwork network;

		// Token: 0x040000B1 RID: 177
		[OptionalParameter("placement_id", "An ad placement or configuration ID.")]
		public string placementId;
	}
}
