using System;

namespace Unity.Services.LevelPlay
{
	// Token: 0x02000013 RID: 19
	public sealed class LevelPlayRewardedAd : ILevelPlayRewardedAd, IDisposable
	{
		// Token: 0x14000030 RID: 48
		// (add) Token: 0x060000FF RID: 255 RVA: 0x00003BDC File Offset: 0x00001DDC
		// (remove) Token: 0x06000100 RID: 256 RVA: 0x00003C14 File Offset: 0x00001E14
		public event Action<LevelPlayAdInfo> OnAdLoaded;

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x06000101 RID: 257 RVA: 0x00003C4C File Offset: 0x00001E4C
		// (remove) Token: 0x06000102 RID: 258 RVA: 0x00003C84 File Offset: 0x00001E84
		public event Action<LevelPlayAdError> OnAdLoadFailed;

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x06000103 RID: 259 RVA: 0x00003CBC File Offset: 0x00001EBC
		// (remove) Token: 0x06000104 RID: 260 RVA: 0x00003CF4 File Offset: 0x00001EF4
		public event Action<LevelPlayAdInfo> OnAdDisplayed;

		// Token: 0x14000033 RID: 51
		// (add) Token: 0x06000105 RID: 261 RVA: 0x00003D2C File Offset: 0x00001F2C
		// (remove) Token: 0x06000106 RID: 262 RVA: 0x00003D64 File Offset: 0x00001F64
		public event Action<LevelPlayAdInfo, LevelPlayAdError> OnAdDisplayFailed;

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x06000107 RID: 263 RVA: 0x00003D9C File Offset: 0x00001F9C
		// (remove) Token: 0x06000108 RID: 264 RVA: 0x00003DD4 File Offset: 0x00001FD4
		public event Action<LevelPlayAdInfo, LevelPlayReward> OnAdRewarded;

		// Token: 0x14000035 RID: 53
		// (add) Token: 0x06000109 RID: 265 RVA: 0x00003E0C File Offset: 0x0000200C
		// (remove) Token: 0x0600010A RID: 266 RVA: 0x00003E44 File Offset: 0x00002044
		public event Action<LevelPlayAdInfo> OnAdClicked;

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x0600010B RID: 267 RVA: 0x00003E7C File Offset: 0x0000207C
		// (remove) Token: 0x0600010C RID: 268 RVA: 0x00003EB4 File Offset: 0x000020B4
		public event Action<LevelPlayAdInfo> OnAdClosed;

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x0600010D RID: 269 RVA: 0x00003EEC File Offset: 0x000020EC
		// (remove) Token: 0x0600010E RID: 270 RVA: 0x00003F24 File Offset: 0x00002124
		public event Action<LevelPlayAdInfo> OnAdInfoChanged;

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00003F59 File Offset: 0x00002159
		public string AdUnitId
		{
			get
			{
				return this.m_RewardedAd.AdUnitId;
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00003F66 File Offset: 0x00002166
		public LevelPlayRewardedAd(string adUnitId, LevelPlayRewardedAd.Config config = null)
		{
			if (config == null)
			{
				config = new LevelPlayRewardedAd.Config.Builder().Build();
			}
			this.m_RewardedAd = new UnsupportedRewardedAd(adUnitId);
			this.SetupEvents();
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00003F90 File Offset: 0x00002190
		private void SetupEvents()
		{
			this.m_RewardedAd.OnAdLoaded += delegate(LevelPlayAdInfo info)
			{
				Action<LevelPlayAdInfo> onAdLoaded = this.OnAdLoaded;
				if (onAdLoaded == null)
				{
					return;
				}
				onAdLoaded(info);
			};
			this.m_RewardedAd.OnAdLoadFailed += delegate(LevelPlayAdError error)
			{
				Action<LevelPlayAdError> onAdLoadFailed = this.OnAdLoadFailed;
				if (onAdLoadFailed == null)
				{
					return;
				}
				onAdLoadFailed(error);
			};
			this.m_RewardedAd.OnAdDisplayed += delegate(LevelPlayAdInfo info)
			{
				Action<LevelPlayAdInfo> onAdDisplayed = this.OnAdDisplayed;
				if (onAdDisplayed == null)
				{
					return;
				}
				onAdDisplayed(info);
			};
			this.m_RewardedAd.OnAdDisplayFailed += delegate(LevelPlayAdInfo info, LevelPlayAdError error)
			{
				Action<LevelPlayAdInfo, LevelPlayAdError> onAdDisplayFailed = this.OnAdDisplayFailed;
				if (onAdDisplayFailed == null)
				{
					return;
				}
				onAdDisplayFailed(info, error);
			};
			this.m_RewardedAd.OnAdRewarded += delegate(LevelPlayAdInfo info, LevelPlayReward reward)
			{
				Action<LevelPlayAdInfo, LevelPlayReward> onAdRewarded = this.OnAdRewarded;
				if (onAdRewarded == null)
				{
					return;
				}
				onAdRewarded(info, reward);
			};
			this.m_RewardedAd.OnAdClicked += delegate(LevelPlayAdInfo info)
			{
				Action<LevelPlayAdInfo> onAdClicked = this.OnAdClicked;
				if (onAdClicked == null)
				{
					return;
				}
				onAdClicked(info);
			};
			this.m_RewardedAd.OnAdClosed += delegate(LevelPlayAdInfo info)
			{
				Action<LevelPlayAdInfo> onAdClosed = this.OnAdClosed;
				if (onAdClosed == null)
				{
					return;
				}
				onAdClosed(info);
			};
			this.m_RewardedAd.OnAdInfoChanged += delegate(LevelPlayAdInfo info)
			{
				Action<LevelPlayAdInfo> onAdInfoChanged = this.OnAdInfoChanged;
				if (onAdInfoChanged == null)
				{
					return;
				}
				onAdInfoChanged(info);
			};
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00004055 File Offset: 0x00002255
		internal LevelPlayRewardedAd(IPlatformRewardedAd platformRewardedAd)
		{
			this.m_RewardedAd = platformRewardedAd;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00004064 File Offset: 0x00002264
		public void LoadAd()
		{
			this.m_RewardedAd.LoadAd();
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00004071 File Offset: 0x00002271
		public void ShowAd(string placementName = null)
		{
			this.m_RewardedAd.ShowAd(placementName);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000407F File Offset: 0x0000227F
		public void DestroyAd()
		{
			this.Dispose();
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00004087 File Offset: 0x00002287
		public bool IsAdReady()
		{
			return this.m_RewardedAd.IsAdReady();
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00004094 File Offset: 0x00002294
		public static bool IsPlacementCapped(string placementName)
		{
			return false;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00004097 File Offset: 0x00002297
		public void Dispose()
		{
			this.m_RewardedAd.Dispose();
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000040A4 File Offset: 0x000022A4
		public string GetAdId()
		{
			return this.m_RewardedAd.AdId;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000040B1 File Offset: 0x000022B1
		public LevelPlayReward GetReward(string placement = null)
		{
			return this.m_RewardedAd.GetReward(placement);
		}

		// Token: 0x04000068 RID: 104
		private readonly IPlatformRewardedAd m_RewardedAd;

		// Token: 0x02000034 RID: 52
		public class Config
		{
			// Token: 0x17000045 RID: 69
			// (get) Token: 0x06000252 RID: 594 RVA: 0x000061BB File Offset: 0x000043BB
			internal IPlatformRewardedAd.IConfig PlatformConfig { get; }

			// Token: 0x06000253 RID: 595 RVA: 0x000061C3 File Offset: 0x000043C3
			private Config(IPlatformRewardedAd.IConfig platformConfig)
			{
				this.PlatformConfig = platformConfig;
			}

			// Token: 0x0200005A RID: 90
			public class Builder
			{
				// Token: 0x060002B3 RID: 691 RVA: 0x0000708A File Offset: 0x0000528A
				public Builder()
				{
					this.m_Builder = new UnsupportedRewardedAd.Config.Builder();
				}

				// Token: 0x060002B4 RID: 692 RVA: 0x0000709D File Offset: 0x0000529D
				public LevelPlayRewardedAd.Config.Builder SetBidFloor(double bidFloor)
				{
					this.m_Builder.SetBidFloor(bidFloor);
					return this;
				}

				// Token: 0x060002B5 RID: 693 RVA: 0x000070AC File Offset: 0x000052AC
				public LevelPlayRewardedAd.Config Build()
				{
					return new LevelPlayRewardedAd.Config(this.m_Builder.Build());
				}

				// Token: 0x04000133 RID: 307
				private readonly IPlatformRewardedAd.IConfigBuilder m_Builder;
			}
		}
	}
}
