using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000018 RID: 24
	[StandardEventName("ad_skip", "Monetization", "Send this event when the player opts to skip a video ad during video playback.")]
	public struct AdSkip
	{
		// Token: 0x040000AC RID: 172
		[RequiredParameter("rewarded", "Set to true if a reward is offered for this ad.", null)]
		public bool rewarded;

		// Token: 0x040000AD RID: 173
		[CustomizableEnum(true)]
		[OptionalParameter("network", "The ad or mediation network provider.")]
		public AdvertisingNetwork network;

		// Token: 0x040000AE RID: 174
		[OptionalParameter("placement_id", "An ad placement or configuration ID.")]
		public string placementId;
	}
}
