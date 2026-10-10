using System;

namespace Unity.Services.LevelPlay
{
	// Token: 0x0200002A RID: 42
	internal sealed class UnsupportedRewardedAd : IPlatformRewardedAd, IDisposable
	{
		// Token: 0x06000225 RID: 549 RVA: 0x00005C25 File Offset: 0x00003E25
		public void Dispose()
		{
		}

		// Token: 0x1400006D RID: 109
		// (add) Token: 0x06000226 RID: 550 RVA: 0x00005C28 File Offset: 0x00003E28
		// (remove) Token: 0x06000227 RID: 551 RVA: 0x00005C60 File Offset: 0x00003E60
		public event Action<LevelPlayAdInfo> OnAdLoaded;

		// Token: 0x1400006E RID: 110
		// (add) Token: 0x06000228 RID: 552 RVA: 0x00005C98 File Offset: 0x00003E98
		// (remove) Token: 0x06000229 RID: 553 RVA: 0x00005CD0 File Offset: 0x00003ED0
		public event Action<LevelPlayAdError> OnAdLoadFailed;

		// Token: 0x1400006F RID: 111
		// (add) Token: 0x0600022A RID: 554 RVA: 0x00005D08 File Offset: 0x00003F08
		// (remove) Token: 0x0600022B RID: 555 RVA: 0x00005D40 File Offset: 0x00003F40
		public event Action<LevelPlayAdInfo> OnAdDisplayed;

		// Token: 0x14000070 RID: 112
		// (add) Token: 0x0600022C RID: 556 RVA: 0x00005D78 File Offset: 0x00003F78
		// (remove) Token: 0x0600022D RID: 557 RVA: 0x00005DB0 File Offset: 0x00003FB0
		public event Action<LevelPlayAdInfo, LevelPlayAdError> OnAdDisplayFailed;

		// Token: 0x14000071 RID: 113
		// (add) Token: 0x0600022E RID: 558 RVA: 0x00005DE8 File Offset: 0x00003FE8
		// (remove) Token: 0x0600022F RID: 559 RVA: 0x00005E20 File Offset: 0x00004020
		public event Action<LevelPlayAdInfo, LevelPlayReward> OnAdRewarded;

		// Token: 0x14000072 RID: 114
		// (add) Token: 0x06000230 RID: 560 RVA: 0x00005E58 File Offset: 0x00004058
		// (remove) Token: 0x06000231 RID: 561 RVA: 0x00005E90 File Offset: 0x00004090
		public event Action<LevelPlayAdInfo> OnAdClicked;

		// Token: 0x14000073 RID: 115
		// (add) Token: 0x06000232 RID: 562 RVA: 0x00005EC8 File Offset: 0x000040C8
		// (remove) Token: 0x06000233 RID: 563 RVA: 0x00005F00 File Offset: 0x00004100
		public event Action<LevelPlayAdInfo> OnAdClosed;

		// Token: 0x14000074 RID: 116
		// (add) Token: 0x06000234 RID: 564 RVA: 0x00005F38 File Offset: 0x00004138
		// (remove) Token: 0x06000235 RID: 565 RVA: 0x00005F70 File Offset: 0x00004170
		public event Action<LevelPlayAdInfo> OnAdInfoChanged;

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000236 RID: 566 RVA: 0x00005FA5 File Offset: 0x000041A5
		public string AdId { get; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00005FAD File Offset: 0x000041AD
		public string AdUnitId { get; }

		// Token: 0x06000238 RID: 568 RVA: 0x00005FB5 File Offset: 0x000041B5
		public UnsupportedRewardedAd(string adUnitId)
		{
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00005FBD File Offset: 0x000041BD
		public void LoadAd()
		{
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00005FBF File Offset: 0x000041BF
		public void ShowAd(string placementName)
		{
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00005FC1 File Offset: 0x000041C1
		public bool IsAdReady()
		{
			return false;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00005FC4 File Offset: 0x000041C4
		public LevelPlayReward GetReward(string placement)
		{
			return LevelPlayReward.Default;
		}

		// Token: 0x02000055 RID: 85
		internal class Config : IPlatformRewardedAd.IConfig
		{
			// Token: 0x0200005F RID: 95
			internal class Builder : IPlatformRewardedAd.IConfigBuilder
			{
				// Token: 0x060002C7 RID: 711 RVA: 0x0000719E File Offset: 0x0000539E
				public void SetBidFloor(double bidFloor)
				{
				}

				// Token: 0x060002C8 RID: 712 RVA: 0x000071A0 File Offset: 0x000053A0
				public IPlatformRewardedAd.IConfig Build()
				{
					return new UnsupportedRewardedAd.Config();
				}
			}
		}
	}
}
