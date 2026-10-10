using System;

namespace Unity.Services.LevelPlay
{
	// Token: 0x02000018 RID: 24
	internal interface IUnityInterstitialAdListener
	{
		// Token: 0x06000177 RID: 375
		void onAdLoaded(string adInfo);

		// Token: 0x06000178 RID: 376
		void onAdLoadFailed(string error);

		// Token: 0x06000179 RID: 377
		void onAdDisplayed(string adInfo);

		// Token: 0x0600017A RID: 378
		void onAdDisplayFailed(string error, string adInfo);

		// Token: 0x0600017B RID: 379
		void onAdClosed(string adInfo);

		// Token: 0x0600017C RID: 380
		void onAdClicked(string adInfo);

		// Token: 0x0600017D RID: 381
		void onAdInfoChanged(string adInfo);
	}
}
