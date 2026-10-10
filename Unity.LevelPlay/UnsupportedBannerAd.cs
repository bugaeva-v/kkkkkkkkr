using System;

namespace Unity.Services.LevelPlay
{
	// Token: 0x02000027 RID: 39
	internal sealed class UnsupportedBannerAd : IPlatformBannerAd, IDisposable
	{
		// Token: 0x060001EC RID: 492 RVA: 0x00005515 File Offset: 0x00003715
		internal UnsupportedBannerAd(string adUnitId, LevelPlayAdSize size, LevelPlayBannerPosition position, string placementId)
		{
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000551D File Offset: 0x0000371D
		internal UnsupportedBannerAd(string adUnitId, UnsupportedBannerAd.Config config)
		{
		}

		// Token: 0x1400005E RID: 94
		// (add) Token: 0x060001EE RID: 494 RVA: 0x00005528 File Offset: 0x00003728
		// (remove) Token: 0x060001EF RID: 495 RVA: 0x00005560 File Offset: 0x00003760
		public event Action<LevelPlayAdInfo> OnAdLoaded;

		// Token: 0x1400005F RID: 95
		// (add) Token: 0x060001F0 RID: 496 RVA: 0x00005598 File Offset: 0x00003798
		// (remove) Token: 0x060001F1 RID: 497 RVA: 0x000055D0 File Offset: 0x000037D0
		public event Action<LevelPlayAdError> OnAdLoadFailed;

		// Token: 0x14000060 RID: 96
		// (add) Token: 0x060001F2 RID: 498 RVA: 0x00005608 File Offset: 0x00003808
		// (remove) Token: 0x060001F3 RID: 499 RVA: 0x00005640 File Offset: 0x00003840
		public event Action<LevelPlayAdInfo> OnAdClicked;

		// Token: 0x14000061 RID: 97
		// (add) Token: 0x060001F4 RID: 500 RVA: 0x00005678 File Offset: 0x00003878
		// (remove) Token: 0x060001F5 RID: 501 RVA: 0x000056B0 File Offset: 0x000038B0
		public event Action<LevelPlayAdInfo> OnAdDisplayed;

		// Token: 0x14000062 RID: 98
		// (add) Token: 0x060001F6 RID: 502 RVA: 0x000056E8 File Offset: 0x000038E8
		// (remove) Token: 0x060001F7 RID: 503 RVA: 0x00005720 File Offset: 0x00003920
		public event Action<LevelPlayAdInfo, LevelPlayAdError> OnAdDisplayFailed;

		// Token: 0x14000063 RID: 99
		// (add) Token: 0x060001F8 RID: 504 RVA: 0x00005758 File Offset: 0x00003958
		// (remove) Token: 0x060001F9 RID: 505 RVA: 0x00005790 File Offset: 0x00003990
		public event Action<LevelPlayAdInfo> OnAdExpanded;

		// Token: 0x14000064 RID: 100
		// (add) Token: 0x060001FA RID: 506 RVA: 0x000057C8 File Offset: 0x000039C8
		// (remove) Token: 0x060001FB RID: 507 RVA: 0x00005800 File Offset: 0x00003A00
		public event Action<LevelPlayAdInfo> OnAdCollapsed;

		// Token: 0x14000065 RID: 101
		// (add) Token: 0x060001FC RID: 508 RVA: 0x00005838 File Offset: 0x00003A38
		// (remove) Token: 0x060001FD RID: 509 RVA: 0x00005870 File Offset: 0x00003A70
		public event Action<LevelPlayAdInfo> OnAdLeftApplication;

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060001FE RID: 510 RVA: 0x000058A5 File Offset: 0x00003AA5
		public LevelPlayBannerPosition Position { get; }

		// Token: 0x060001FF RID: 511 RVA: 0x000058AD File Offset: 0x00003AAD
		public void LoadAd()
		{
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000058AF File Offset: 0x00003AAF
		public void DestroyAd()
		{
		}

		// Token: 0x06000201 RID: 513 RVA: 0x000058B1 File Offset: 0x00003AB1
		public void ShowAd()
		{
		}

		// Token: 0x06000202 RID: 514 RVA: 0x000058B3 File Offset: 0x00003AB3
		public void HideAd()
		{
		}

		// Token: 0x06000203 RID: 515 RVA: 0x000058B5 File Offset: 0x00003AB5
		public void PauseAutoRefresh()
		{
		}

		// Token: 0x06000204 RID: 516 RVA: 0x000058B7 File Offset: 0x00003AB7
		public void ResumeAutoRefresh()
		{
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000058B9 File Offset: 0x00003AB9
		public void SetAutoRefresh(bool flag)
		{
		}

		// Token: 0x06000206 RID: 518 RVA: 0x000058BB File Offset: 0x00003ABB
		public void Dispose()
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000207 RID: 519 RVA: 0x000058BD File Offset: 0x00003ABD
		public string AdId { get; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000208 RID: 520 RVA: 0x000058C5 File Offset: 0x00003AC5
		public string AdUnitId { get; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000209 RID: 521 RVA: 0x000058CD File Offset: 0x00003ACD
		public LevelPlayAdSize AdSize { get; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600020A RID: 522 RVA: 0x000058D5 File Offset: 0x00003AD5
		public LevelPlayAdSize Size { get; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600020B RID: 523 RVA: 0x000058DD File Offset: 0x00003ADD
		public string PlacementName { get; }

		// Token: 0x02000053 RID: 83
		internal class Config : IPlatformBannerAd.IConfig
		{
			// Token: 0x0200005D RID: 93
			internal class Builder : IPlatformBannerAd.IConfigBuilder
			{
				// Token: 0x060002BC RID: 700 RVA: 0x00007172 File Offset: 0x00005372
				public void SetBidFloor(double bidFloor)
				{
				}

				// Token: 0x060002BD RID: 701 RVA: 0x00007174 File Offset: 0x00005374
				public void SetSize(LevelPlayAdSize size)
				{
				}

				// Token: 0x060002BE RID: 702 RVA: 0x00007176 File Offset: 0x00005376
				public void SetPosition(LevelPlayBannerPosition position)
				{
				}

				// Token: 0x060002BF RID: 703 RVA: 0x00007178 File Offset: 0x00005378
				public void SetPlacementName(string placementName)
				{
				}

				// Token: 0x060002C0 RID: 704 RVA: 0x0000717A File Offset: 0x0000537A
				public void SetDisplayOnLoad(bool displayOnLoad)
				{
				}

				// Token: 0x060002C1 RID: 705 RVA: 0x0000717C File Offset: 0x0000537C
				public void SetRespectSafeArea(bool respectSafeArea)
				{
				}

				// Token: 0x060002C2 RID: 706 RVA: 0x0000717E File Offset: 0x0000537E
				public IPlatformBannerAd.IConfig Build()
				{
					return new UnsupportedBannerAd.Config();
				}
			}
		}
	}
}
