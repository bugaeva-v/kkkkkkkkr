using System;

namespace Unity.Services.LevelPlay
{
	// Token: 0x0200000B RID: 11
	public sealed class LevelPlayBannerAd : ILevelPlayBannerAd, IDisposable
	{
		// Token: 0x14000021 RID: 33
		// (add) Token: 0x0600008F RID: 143 RVA: 0x00002AF8 File Offset: 0x00000CF8
		// (remove) Token: 0x06000090 RID: 144 RVA: 0x00002B30 File Offset: 0x00000D30
		public event Action<LevelPlayAdInfo> OnAdLoaded;

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06000091 RID: 145 RVA: 0x00002B68 File Offset: 0x00000D68
		// (remove) Token: 0x06000092 RID: 146 RVA: 0x00002BA0 File Offset: 0x00000DA0
		public event Action<LevelPlayAdError> OnAdLoadFailed;

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x06000093 RID: 147 RVA: 0x00002BD8 File Offset: 0x00000DD8
		// (remove) Token: 0x06000094 RID: 148 RVA: 0x00002C10 File Offset: 0x00000E10
		public event Action<LevelPlayAdInfo> OnAdClicked;

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x06000095 RID: 149 RVA: 0x00002C48 File Offset: 0x00000E48
		// (remove) Token: 0x06000096 RID: 150 RVA: 0x00002C80 File Offset: 0x00000E80
		public event Action<LevelPlayAdInfo> OnAdDisplayed;

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x06000097 RID: 151 RVA: 0x00002CB8 File Offset: 0x00000EB8
		// (remove) Token: 0x06000098 RID: 152 RVA: 0x00002CF0 File Offset: 0x00000EF0
		public event Action<LevelPlayAdInfo, LevelPlayAdError> OnAdDisplayFailed;

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x06000099 RID: 153 RVA: 0x00002D28 File Offset: 0x00000F28
		// (remove) Token: 0x0600009A RID: 154 RVA: 0x00002D60 File Offset: 0x00000F60
		public event Action<LevelPlayAdInfo> OnAdExpanded;

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x0600009B RID: 155 RVA: 0x00002D98 File Offset: 0x00000F98
		// (remove) Token: 0x0600009C RID: 156 RVA: 0x00002DD0 File Offset: 0x00000FD0
		public event Action<LevelPlayAdInfo> OnAdCollapsed;

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x0600009D RID: 157 RVA: 0x00002E08 File Offset: 0x00001008
		// (remove) Token: 0x0600009E RID: 158 RVA: 0x00002E40 File Offset: 0x00001040
		public event Action<LevelPlayAdInfo> OnAdLeftApplication;

		// Token: 0x0600009F RID: 159 RVA: 0x00002E75 File Offset: 0x00001075
		public LevelPlayBannerAd(string adUnitId, LevelPlayBannerAd.Config config = null)
		{
			if (config == null)
			{
				config = new LevelPlayBannerAd.Config.Builder().Build();
			}
			this.m_BannerAd = new UnsupportedBannerAd(adUnitId, ((config != null) ? config.PlatformConfig : null) as UnsupportedBannerAd.Config);
			this.SetupCallbacks();
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002EAF File Offset: 0x000010AF
		internal LevelPlayBannerAd(IPlatformBannerAd platformBannerAd)
		{
			this.m_BannerAd = platformBannerAd;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002EBE File Offset: 0x000010BE
		public void LoadAd()
		{
			this.m_BannerAd.LoadAd();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002ECB File Offset: 0x000010CB
		public void DestroyAd()
		{
			this.m_BannerAd.DestroyAd();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002ED8 File Offset: 0x000010D8
		public void ShowAd()
		{
			this.m_BannerAd.ShowAd();
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002EE5 File Offset: 0x000010E5
		public void HideAd()
		{
			this.m_BannerAd.HideAd();
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002EF2 File Offset: 0x000010F2
		public string GetAdId()
		{
			return this.m_BannerAd.AdId;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002EFF File Offset: 0x000010FF
		public string GetAdUnitId()
		{
			return this.m_BannerAd.AdUnitId;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002F0C File Offset: 0x0000110C
		public LevelPlayAdSize GetAdSize()
		{
			return this.m_BannerAd.AdSize;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002F19 File Offset: 0x00001119
		public LevelPlayBannerPosition GetPosition()
		{
			return this.m_BannerAd.Position;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002F26 File Offset: 0x00001126
		public string GetPlacementName()
		{
			return this.m_BannerAd.PlacementName;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002F33 File Offset: 0x00001133
		public void PauseAutoRefresh()
		{
			this.m_BannerAd.PauseAutoRefresh();
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002F40 File Offset: 0x00001140
		public void ResumeAutoRefresh()
		{
			this.m_BannerAd.ResumeAutoRefresh();
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002F50 File Offset: 0x00001150
		private void SetupCallbacks()
		{
			this.m_BannerAd.OnAdLoaded += delegate(LevelPlayAdInfo info)
			{
				Action<LevelPlayAdInfo> onAdLoaded = this.OnAdLoaded;
				if (onAdLoaded == null)
				{
					return;
				}
				onAdLoaded(info);
			};
			this.m_BannerAd.OnAdLoadFailed += delegate(LevelPlayAdError error)
			{
				Action<LevelPlayAdError> onAdLoadFailed = this.OnAdLoadFailed;
				if (onAdLoadFailed == null)
				{
					return;
				}
				onAdLoadFailed(error);
			};
			this.m_BannerAd.OnAdClicked += delegate(LevelPlayAdInfo info)
			{
				Action<LevelPlayAdInfo> onAdClicked = this.OnAdClicked;
				if (onAdClicked == null)
				{
					return;
				}
				onAdClicked(info);
			};
			this.m_BannerAd.OnAdDisplayed += delegate(LevelPlayAdInfo info)
			{
				Action<LevelPlayAdInfo> onAdDisplayed = this.OnAdDisplayed;
				if (onAdDisplayed == null)
				{
					return;
				}
				onAdDisplayed(info);
			};
			this.m_BannerAd.OnAdExpanded += delegate(LevelPlayAdInfo info)
			{
				Action<LevelPlayAdInfo> onAdExpanded = this.OnAdExpanded;
				if (onAdExpanded == null)
				{
					return;
				}
				onAdExpanded(info);
			};
			this.m_BannerAd.OnAdCollapsed += delegate(LevelPlayAdInfo info)
			{
				Action<LevelPlayAdInfo> onAdCollapsed = this.OnAdCollapsed;
				if (onAdCollapsed == null)
				{
					return;
				}
				onAdCollapsed(info);
			};
			this.m_BannerAd.OnAdLeftApplication += delegate(LevelPlayAdInfo info)
			{
				Action<LevelPlayAdInfo> onAdLeftApplication = this.OnAdLeftApplication;
				if (onAdLeftApplication == null)
				{
					return;
				}
				onAdLeftApplication(info);
			};
			this.m_BannerAd.OnAdDisplayFailed += delegate(LevelPlayAdInfo info, LevelPlayAdError error)
			{
				Action<LevelPlayAdInfo, LevelPlayAdError> onAdDisplayFailed = this.OnAdDisplayFailed;
				if (onAdDisplayFailed == null)
				{
					return;
				}
				onAdDisplayFailed(info, error);
			};
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00003015 File Offset: 0x00001215
		public void Dispose()
		{
			IPlatformBannerAd bannerAd = this.m_BannerAd;
			if (bannerAd == null)
			{
				return;
			}
			bannerAd.DestroyAd();
		}

		// Token: 0x04000042 RID: 66
		private bool m_autoRefresh;

		// Token: 0x04000043 RID: 67
		private readonly IPlatformBannerAd m_BannerAd;

		// Token: 0x02000031 RID: 49
		public class Config
		{
			// Token: 0x17000043 RID: 67
			// (get) Token: 0x0600024E RID: 590 RVA: 0x0000618D File Offset: 0x0000438D
			internal IPlatformBannerAd.IConfig PlatformConfig { get; }

			// Token: 0x0600024F RID: 591 RVA: 0x00006195 File Offset: 0x00004395
			private Config(IPlatformBannerAd.IConfig platformConfig)
			{
				this.PlatformConfig = platformConfig;
			}

			// Token: 0x02000058 RID: 88
			public class Builder
			{
				// Token: 0x060002A8 RID: 680 RVA: 0x00006FD4 File Offset: 0x000051D4
				public Builder()
				{
					this.m_Builder = new UnsupportedBannerAd.Config.Builder();
				}

				// Token: 0x060002A9 RID: 681 RVA: 0x00006FE7 File Offset: 0x000051E7
				public LevelPlayBannerAd.Config.Builder SetBidFloor(double bidFloor)
				{
					this.m_Builder.SetBidFloor(bidFloor);
					return this;
				}

				// Token: 0x060002AA RID: 682 RVA: 0x00006FF6 File Offset: 0x000051F6
				public LevelPlayBannerAd.Config.Builder SetSize(LevelPlayAdSize size)
				{
					this.m_Builder.SetSize(size);
					return this;
				}

				// Token: 0x060002AB RID: 683 RVA: 0x00007005 File Offset: 0x00005205
				public LevelPlayBannerAd.Config.Builder SetPosition(LevelPlayBannerPosition position)
				{
					this.m_Builder.SetPosition(position);
					return this;
				}

				// Token: 0x060002AC RID: 684 RVA: 0x00007014 File Offset: 0x00005214
				public LevelPlayBannerAd.Config.Builder SetPlacementName(string placementName)
				{
					if (placementName != null)
					{
						this.m_Builder.SetPlacementName(placementName);
					}
					return this;
				}

				// Token: 0x060002AD RID: 685 RVA: 0x00007026 File Offset: 0x00005226
				public LevelPlayBannerAd.Config.Builder SetDisplayOnLoad(bool displayOnLoad)
				{
					this.m_Builder.SetDisplayOnLoad(displayOnLoad);
					return this;
				}

				// Token: 0x060002AE RID: 686 RVA: 0x00007035 File Offset: 0x00005235
				public LevelPlayBannerAd.Config.Builder SetRespectSafeArea(bool respectSafeArea)
				{
					this.m_Builder.SetRespectSafeArea(respectSafeArea);
					return this;
				}

				// Token: 0x060002AF RID: 687 RVA: 0x00007044 File Offset: 0x00005244
				public LevelPlayBannerAd.Config Build()
				{
					return new LevelPlayBannerAd.Config(this.m_Builder.Build());
				}

				// Token: 0x04000131 RID: 305
				private readonly IPlatformBannerAd.IConfigBuilder m_Builder;
			}
		}
	}
}
