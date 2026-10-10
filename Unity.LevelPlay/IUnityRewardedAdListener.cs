using System;

namespace Unity.Services.LevelPlay
{
	// Token: 0x02000019 RID: 25
	internal interface IUnityRewardedAdListener
	{
		// Token: 0x0600017E RID: 382
		void onAdLoaded(string adInfo);

		// Token: 0x0600017F RID: 383
		void onAdLoadFailed(string error);

		// Token: 0x06000180 RID: 384
		void onAdDisplayed(string adInfo);

		// Token: 0x06000181 RID: 385
		void onAdDisplayFailed(string error, string adInfo);

		// Token: 0x06000182 RID: 386
		void onAdRewarded(string adInfo, string rewardName, int rewardAmount);

		// Token: 0x06000183 RID: 387
		void onAdClicked(string adInfo);

		// Token: 0x06000184 RID: 388
		void onAdClosed(string adInfo);

		// Token: 0x06000185 RID: 389
		void onAdInfoChanged(string adInfo);
	}
}
