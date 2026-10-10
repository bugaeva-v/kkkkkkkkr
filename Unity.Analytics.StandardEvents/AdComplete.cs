using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000016 RID: 22
	[StandardEventName("ad_complete", "Monetization", "Send this event when an ad is successfully viewed and not skipped.")]
	public struct AdComplete
	{
		// Token: 0x040000A6 RID: 166
		[RequiredParameter("rewarded", "Set to true if a reward is offered for this ad.", null)]
		public bool rewarded;

		// Token: 0x040000A7 RID: 167
		[CustomizableEnum(true)]
		[OptionalParameter("network", "The ad or mediation network provider.")]
		public AdvertisingNetwork network;

		// Token: 0x040000A8 RID: 168
		[OptionalParameter("placement_id", "An ad placement or configuration ID.")]
		public string placementId;
	}
}
