using System;

namespace Unity.Services.LevelPlay
{
	// Token: 0x02000021 RID: 33
	internal interface IPlatformBannerAd : IDisposable
	{
		// Token: 0x14000047 RID: 71
		// (add) Token: 0x060001A2 RID: 418
		// (remove) Token: 0x060001A3 RID: 419
		event Action<LevelPlayAdInfo> OnAdLoaded;

		// Token: 0x14000048 RID: 72
		// (add) Token: 0x060001A4 RID: 420
		// (remove) Token: 0x060001A5 RID: 421
		event Action<LevelPlayAdError> OnAdLoadFailed;

		// Token: 0x14000049 RID: 73
		// (add) Token: 0x060001A6 RID: 422
		// (remove) Token: 0x060001A7 RID: 423
		event Action<LevelPlayAdInfo> OnAdClicked;

		// Token: 0x1400004A RID: 74
		// (add) Token: 0x060001A8 RID: 424
		// (remove) Token: 0x060001A9 RID: 425
		event Action<LevelPlayAdInfo> OnAdDisplayed;

		// Token: 0x1400004B RID: 75
		// (add) Token: 0x060001AA RID: 426
		// (remove) Token: 0x060001AB RID: 427
		event Action<LevelPlayAdInfo, LevelPlayAdError> OnAdDisplayFailed;

		// Token: 0x1400004C RID: 76
		// (add) Token: 0x060001AC RID: 428
		// (remove) Token: 0x060001AD RID: 429
		event Action<LevelPlayAdInfo> OnAdExpanded;

		// Token: 0x1400004D RID: 77
		// (add) Token: 0x060001AE RID: 430
		// (remove) Token: 0x060001AF RID: 431
		event Action<LevelPlayAdInfo> OnAdCollapsed;

		// Token: 0x1400004E RID: 78
		// (add) Token: 0x060001B0 RID: 432
		// (remove) Token: 0x060001B1 RID: 433
		event Action<LevelPlayAdInfo> OnAdLeftApplication;

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060001B2 RID: 434
		string AdId { get; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001B3 RID: 435
		string AdUnitId { get; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001B4 RID: 436
		LevelPlayAdSize AdSize { get; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001B5 RID: 437
		string PlacementName { get; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001B6 RID: 438
		LevelPlayBannerPosition Position { get; }

		// Token: 0x060001B7 RID: 439
		void LoadAd();

		// Token: 0x060001B8 RID: 440
		void DestroyAd();

		// Token: 0x060001B9 RID: 441
		void ShowAd();

		// Token: 0x060001BA RID: 442
		void HideAd();

		// Token: 0x060001BB RID: 443
		void PauseAutoRefresh();

		// Token: 0x060001BC RID: 444
		void ResumeAutoRefresh();

		// Token: 0x0200004D RID: 77
		internal interface IConfig
		{
		}

		// Token: 0x0200004E RID: 78
		internal interface IConfigBuilder
		{
			// Token: 0x06000285 RID: 645
			void SetBidFloor(double bidFloor);

			// Token: 0x06000286 RID: 646
			void SetSize(LevelPlayAdSize size);

			// Token: 0x06000287 RID: 647
			void SetPosition(LevelPlayBannerPosition position);

			// Token: 0x06000288 RID: 648
			void SetPlacementName(string placementName);

			// Token: 0x06000289 RID: 649
			void SetDisplayOnLoad(bool displayOnLoad);

			// Token: 0x0600028A RID: 650
			void SetRespectSafeArea(bool respectSafeArea);

			// Token: 0x0600028B RID: 651
			IPlatformBannerAd.IConfig Build();
		}
	}
}
