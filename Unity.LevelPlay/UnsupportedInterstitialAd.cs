using System;

namespace Unity.Services.LevelPlay
{
	// Token: 0x02000028 RID: 40
	internal sealed class UnsupportedInterstitialAd : IPlatformInterstitialAd, IDisposable
	{
		// Token: 0x0600020C RID: 524 RVA: 0x000058E5 File Offset: 0x00003AE5
		public void Dispose()
		{
		}

		// Token: 0x14000066 RID: 102
		// (add) Token: 0x0600020D RID: 525 RVA: 0x000058E8 File Offset: 0x00003AE8
		// (remove) Token: 0x0600020E RID: 526 RVA: 0x00005920 File Offset: 0x00003B20
		public event Action<LevelPlayAdInfo> OnAdLoaded;

		// Token: 0x14000067 RID: 103
		// (add) Token: 0x0600020F RID: 527 RVA: 0x00005958 File Offset: 0x00003B58
		// (remove) Token: 0x06000210 RID: 528 RVA: 0x00005990 File Offset: 0x00003B90
		public event Action<LevelPlayAdError> OnAdLoadFailed;

		// Token: 0x14000068 RID: 104
		// (add) Token: 0x06000211 RID: 529 RVA: 0x000059C8 File Offset: 0x00003BC8
		// (remove) Token: 0x06000212 RID: 530 RVA: 0x00005A00 File Offset: 0x00003C00
		public event Action<LevelPlayAdInfo> OnAdDisplayed;

		// Token: 0x14000069 RID: 105
		// (add) Token: 0x06000213 RID: 531 RVA: 0x00005A38 File Offset: 0x00003C38
		// (remove) Token: 0x06000214 RID: 532 RVA: 0x00005A70 File Offset: 0x00003C70
		public event Action<LevelPlayAdInfo> OnAdClosed;

		// Token: 0x1400006A RID: 106
		// (add) Token: 0x06000215 RID: 533 RVA: 0x00005AA8 File Offset: 0x00003CA8
		// (remove) Token: 0x06000216 RID: 534 RVA: 0x00005AE0 File Offset: 0x00003CE0
		public event Action<LevelPlayAdInfo> OnAdClicked;

		// Token: 0x1400006B RID: 107
		// (add) Token: 0x06000217 RID: 535 RVA: 0x00005B18 File Offset: 0x00003D18
		// (remove) Token: 0x06000218 RID: 536 RVA: 0x00005B50 File Offset: 0x00003D50
		public event Action<LevelPlayAdInfo, LevelPlayAdError> OnAdDisplayFailed;

		// Token: 0x1400006C RID: 108
		// (add) Token: 0x06000219 RID: 537 RVA: 0x00005B88 File Offset: 0x00003D88
		// (remove) Token: 0x0600021A RID: 538 RVA: 0x00005BC0 File Offset: 0x00003DC0
		public event Action<LevelPlayAdInfo> OnAdInfoChanged;

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00005BF5 File Offset: 0x00003DF5
		public string AdId { get; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00005BFD File Offset: 0x00003DFD
		public string AdUnitId { get; }

		// Token: 0x0600021D RID: 541 RVA: 0x00005C05 File Offset: 0x00003E05
		public UnsupportedInterstitialAd(string adUnitId)
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00005C0D File Offset: 0x00003E0D
		public void LoadAd()
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00005C0F File Offset: 0x00003E0F
		public void ShowAd(string placementName)
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00005C11 File Offset: 0x00003E11
		public bool IsAdReady()
		{
			return false;
		}

		// Token: 0x02000054 RID: 84
		internal class Config : IPlatformInterstitialAd.IConfig
		{
			// Token: 0x0200005E RID: 94
			internal class Builder : IPlatformInterstitialAd.IConfigBuilder
			{
				// Token: 0x060002C4 RID: 708 RVA: 0x0000718D File Offset: 0x0000538D
				public void SetBidFloor(double bidFloor)
				{
				}

				// Token: 0x060002C5 RID: 709 RVA: 0x0000718F File Offset: 0x0000538F
				public IPlatformInterstitialAd.IConfig Build()
				{
					return new UnsupportedInterstitialAd.Config();
				}
			}
		}
	}
}
