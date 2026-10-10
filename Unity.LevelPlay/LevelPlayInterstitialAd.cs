using System;
using JetBrains.Annotations;

namespace Unity.Services.LevelPlay
{
	// Token: 0x02000010 RID: 16
	public sealed class LevelPlayInterstitialAd : ILevelPlayInterstitialAd, IDisposable
	{
		// Token: 0x14000029 RID: 41
		// (add) Token: 0x060000D7 RID: 215 RVA: 0x00003690 File Offset: 0x00001890
		// (remove) Token: 0x060000D8 RID: 216 RVA: 0x000036C8 File Offset: 0x000018C8
		public event Action<LevelPlayAdInfo> OnAdLoaded;

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x060000D9 RID: 217 RVA: 0x00003700 File Offset: 0x00001900
		// (remove) Token: 0x060000DA RID: 218 RVA: 0x00003738 File Offset: 0x00001938
		public event Action<LevelPlayAdError> OnAdLoadFailed;

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x060000DB RID: 219 RVA: 0x00003770 File Offset: 0x00001970
		// (remove) Token: 0x060000DC RID: 220 RVA: 0x000037A8 File Offset: 0x000019A8
		public event Action<LevelPlayAdInfo> OnAdDisplayed;

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x060000DD RID: 221 RVA: 0x000037E0 File Offset: 0x000019E0
		// (remove) Token: 0x060000DE RID: 222 RVA: 0x00003818 File Offset: 0x00001A18
		public event Action<LevelPlayAdInfo> OnAdClosed;

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x060000DF RID: 223 RVA: 0x00003850 File Offset: 0x00001A50
		// (remove) Token: 0x060000E0 RID: 224 RVA: 0x00003888 File Offset: 0x00001A88
		public event Action<LevelPlayAdInfo> OnAdClicked;

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x060000E1 RID: 225 RVA: 0x000038C0 File Offset: 0x00001AC0
		// (remove) Token: 0x060000E2 RID: 226 RVA: 0x000038F8 File Offset: 0x00001AF8
		public event Action<LevelPlayAdInfo, LevelPlayAdError> OnAdDisplayFailed;

		// Token: 0x1400002F RID: 47
		// (add) Token: 0x060000E3 RID: 227 RVA: 0x00003930 File Offset: 0x00001B30
		// (remove) Token: 0x060000E4 RID: 228 RVA: 0x00003968 File Offset: 0x00001B68
		public event Action<LevelPlayAdInfo> OnAdInfoChanged;

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000399D File Offset: 0x00001B9D
		public string AdUnitId
		{
			get
			{
				return this.m_InterstitialAd.AdUnitId;
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000039AA File Offset: 0x00001BAA
		public LevelPlayInterstitialAd(string adUnitId, LevelPlayInterstitialAd.Config config = null)
		{
			if (config == null)
			{
				config = new LevelPlayInterstitialAd.Config.Builder().Build();
			}
			this.m_InterstitialAd = new UnsupportedInterstitialAd(adUnitId);
			this.SetupEvents();
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000039D4 File Offset: 0x00001BD4
		private void SetupEvents()
		{
			this.m_InterstitialAd.OnAdLoaded += delegate(LevelPlayAdInfo info)
			{
				Action<LevelPlayAdInfo> onAdLoaded = this.OnAdLoaded;
				if (onAdLoaded == null)
				{
					return;
				}
				onAdLoaded(info);
			};
			this.m_InterstitialAd.OnAdLoadFailed += delegate(LevelPlayAdError error)
			{
				Action<LevelPlayAdError> onAdLoadFailed = this.OnAdLoadFailed;
				if (onAdLoadFailed == null)
				{
					return;
				}
				onAdLoadFailed(error);
			};
			this.m_InterstitialAd.OnAdDisplayed += delegate(LevelPlayAdInfo info)
			{
				Action<LevelPlayAdInfo> onAdDisplayed = this.OnAdDisplayed;
				if (onAdDisplayed == null)
				{
					return;
				}
				onAdDisplayed(info);
			};
			this.m_InterstitialAd.OnAdClosed += delegate(LevelPlayAdInfo info)
			{
				Action<LevelPlayAdInfo> onAdClosed = this.OnAdClosed;
				if (onAdClosed == null)
				{
					return;
				}
				onAdClosed(info);
			};
			this.m_InterstitialAd.OnAdClicked += delegate(LevelPlayAdInfo info)
			{
				Action<LevelPlayAdInfo> onAdClicked = this.OnAdClicked;
				if (onAdClicked == null)
				{
					return;
				}
				onAdClicked(info);
			};
			this.m_InterstitialAd.OnAdDisplayFailed += delegate(LevelPlayAdInfo info, LevelPlayAdError error)
			{
				Action<LevelPlayAdInfo, LevelPlayAdError> onAdDisplayFailed = this.OnAdDisplayFailed;
				if (onAdDisplayFailed == null)
				{
					return;
				}
				onAdDisplayFailed(info, error);
			};
			this.m_InterstitialAd.OnAdInfoChanged += delegate(LevelPlayAdInfo info)
			{
				Action<LevelPlayAdInfo> onAdInfoChanged = this.OnAdInfoChanged;
				if (onAdInfoChanged == null)
				{
					return;
				}
				onAdInfoChanged(info);
			};
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00003A82 File Offset: 0x00001C82
		internal LevelPlayInterstitialAd(IPlatformInterstitialAd platformInterstitialAd)
		{
			this.m_InterstitialAd = platformInterstitialAd;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00003A91 File Offset: 0x00001C91
		public void LoadAd()
		{
			this.m_InterstitialAd.LoadAd();
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00003A9E File Offset: 0x00001C9E
		public void DestroyAd()
		{
			this.Dispose();
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00003AA6 File Offset: 0x00001CA6
		public void ShowAd(string placementName = null)
		{
			this.m_InterstitialAd.ShowAd(placementName);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00003AB4 File Offset: 0x00001CB4
		public bool IsAdReady()
		{
			return this.m_InterstitialAd.IsAdReady();
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00003AC1 File Offset: 0x00001CC1
		public static bool IsPlacementCapped(string placementName)
		{
			return false;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00003AC4 File Offset: 0x00001CC4
		public void Dispose()
		{
			this.m_InterstitialAd.Dispose();
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00003AD1 File Offset: 0x00001CD1
		public string GetAdId()
		{
			return this.m_InterstitialAd.AdId;
		}

		// Token: 0x0400005C RID: 92
		private readonly IPlatformInterstitialAd m_InterstitialAd;

		// Token: 0x02000033 RID: 51
		public class Config
		{
			// Token: 0x17000044 RID: 68
			// (get) Token: 0x06000250 RID: 592 RVA: 0x000061A4 File Offset: 0x000043A4
			[CanBeNull]
			internal IPlatformInterstitialAd.IConfig PlatformConfig { get; }

			// Token: 0x06000251 RID: 593 RVA: 0x000061AC File Offset: 0x000043AC
			private Config([CanBeNull] IPlatformInterstitialAd.IConfig platformConfig)
			{
				this.PlatformConfig = platformConfig;
			}

			// Token: 0x02000059 RID: 89
			public class Builder
			{
				// Token: 0x060002B0 RID: 688 RVA: 0x00007056 File Offset: 0x00005256
				public Builder()
				{
					this.m_Builder = new UnsupportedInterstitialAd.Config.Builder();
				}

				// Token: 0x060002B1 RID: 689 RVA: 0x00007069 File Offset: 0x00005269
				public LevelPlayInterstitialAd.Config.Builder SetBidFloor(double bidFloor)
				{
					this.m_Builder.SetBidFloor(bidFloor);
					return this;
				}

				// Token: 0x060002B2 RID: 690 RVA: 0x00007078 File Offset: 0x00005278
				public LevelPlayInterstitialAd.Config Build()
				{
					return new LevelPlayInterstitialAd.Config(this.m_Builder.Build());
				}

				// Token: 0x04000132 RID: 306
				private readonly IPlatformInterstitialAd.IConfigBuilder m_Builder;
			}
		}
	}
}
