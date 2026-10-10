using System;

namespace Unity.Services.LevelPlay
{
	// Token: 0x02000025 RID: 37
	internal interface IPlatformRewardedAd : IDisposable
	{
		// Token: 0x14000056 RID: 86
		// (add) Token: 0x060001D3 RID: 467
		// (remove) Token: 0x060001D4 RID: 468
		event Action<LevelPlayAdInfo> OnAdLoaded;

		// Token: 0x14000057 RID: 87
		// (add) Token: 0x060001D5 RID: 469
		// (remove) Token: 0x060001D6 RID: 470
		event Action<LevelPlayAdError> OnAdLoadFailed;

		// Token: 0x14000058 RID: 88
		// (add) Token: 0x060001D7 RID: 471
		// (remove) Token: 0x060001D8 RID: 472
		event Action<LevelPlayAdInfo> OnAdDisplayed;

		// Token: 0x14000059 RID: 89
		// (add) Token: 0x060001D9 RID: 473
		// (remove) Token: 0x060001DA RID: 474
		event Action<LevelPlayAdInfo, LevelPlayAdError> OnAdDisplayFailed;

		// Token: 0x1400005A RID: 90
		// (add) Token: 0x060001DB RID: 475
		// (remove) Token: 0x060001DC RID: 476
		event Action<LevelPlayAdInfo, LevelPlayReward> OnAdRewarded;

		// Token: 0x1400005B RID: 91
		// (add) Token: 0x060001DD RID: 477
		// (remove) Token: 0x060001DE RID: 478
		event Action<LevelPlayAdInfo> OnAdClicked;

		// Token: 0x1400005C RID: 92
		// (add) Token: 0x060001DF RID: 479
		// (remove) Token: 0x060001E0 RID: 480
		event Action<LevelPlayAdInfo> OnAdClosed;

		// Token: 0x1400005D RID: 93
		// (add) Token: 0x060001E1 RID: 481
		// (remove) Token: 0x060001E2 RID: 482
		event Action<LevelPlayAdInfo> OnAdInfoChanged;

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060001E3 RID: 483
		string AdId { get; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001E4 RID: 484
		string AdUnitId { get; }

		// Token: 0x060001E5 RID: 485
		void LoadAd();

		// Token: 0x060001E6 RID: 486
		void ShowAd(string placementName);

		// Token: 0x060001E7 RID: 487
		bool IsAdReady();

		// Token: 0x060001E8 RID: 488
		LevelPlayReward GetReward(string placement);

		// Token: 0x02000051 RID: 81
		public interface IConfig
		{
		}

		// Token: 0x02000052 RID: 82
		public interface IConfigBuilder
		{
			// Token: 0x0600028E RID: 654
			void SetBidFloor(double bidFloor);

			// Token: 0x0600028F RID: 655
			IPlatformRewardedAd.IConfig Build();
		}
	}
}
