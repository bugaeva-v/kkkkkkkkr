using System;

namespace Unity.Services.LevelPlay
{
	// Token: 0x02000022 RID: 34
	internal interface IPlatformInterstitialAd : IDisposable
	{
		// Token: 0x1400004F RID: 79
		// (add) Token: 0x060001BD RID: 445
		// (remove) Token: 0x060001BE RID: 446
		event Action<LevelPlayAdInfo> OnAdLoaded;

		// Token: 0x14000050 RID: 80
		// (add) Token: 0x060001BF RID: 447
		// (remove) Token: 0x060001C0 RID: 448
		event Action<LevelPlayAdError> OnAdLoadFailed;

		// Token: 0x14000051 RID: 81
		// (add) Token: 0x060001C1 RID: 449
		// (remove) Token: 0x060001C2 RID: 450
		event Action<LevelPlayAdInfo> OnAdDisplayed;

		// Token: 0x14000052 RID: 82
		// (add) Token: 0x060001C3 RID: 451
		// (remove) Token: 0x060001C4 RID: 452
		event Action<LevelPlayAdInfo> OnAdClosed;

		// Token: 0x14000053 RID: 83
		// (add) Token: 0x060001C5 RID: 453
		// (remove) Token: 0x060001C6 RID: 454
		event Action<LevelPlayAdInfo> OnAdClicked;

		// Token: 0x14000054 RID: 84
		// (add) Token: 0x060001C7 RID: 455
		// (remove) Token: 0x060001C8 RID: 456
		event Action<LevelPlayAdInfo, LevelPlayAdError> OnAdDisplayFailed;

		// Token: 0x14000055 RID: 85
		// (add) Token: 0x060001C9 RID: 457
		// (remove) Token: 0x060001CA RID: 458
		event Action<LevelPlayAdInfo> OnAdInfoChanged;

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060001CB RID: 459
		string AdId { get; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060001CC RID: 460
		string AdUnitId { get; }

		// Token: 0x060001CD RID: 461
		void LoadAd();

		// Token: 0x060001CE RID: 462
		void ShowAd(string placementName);

		// Token: 0x060001CF RID: 463
		bool IsAdReady();

		// Token: 0x0200004F RID: 79
		internal interface IConfig
		{
		}

		// Token: 0x02000050 RID: 80
		internal interface IConfigBuilder
		{
			// Token: 0x0600028C RID: 652
			void SetBidFloor(double bidFloor);

			// Token: 0x0600028D RID: 653
			IPlatformInterstitialAd.IConfig Build();
		}
	}
}
