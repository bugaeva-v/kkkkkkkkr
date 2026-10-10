using System;

namespace Unity.Services.LevelPlay
{
	// Token: 0x02000004 RID: 4
	public interface ILevelPlayInterstitialAd : IDisposable
	{
		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600001E RID: 30
		// (remove) Token: 0x0600001F RID: 31
		event Action<LevelPlayAdInfo> OnAdLoaded;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000020 RID: 32
		// (remove) Token: 0x06000021 RID: 33
		event Action<LevelPlayAdError> OnAdLoadFailed;

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000022 RID: 34
		// (remove) Token: 0x06000023 RID: 35
		event Action<LevelPlayAdInfo> OnAdDisplayed;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000024 RID: 36
		// (remove) Token: 0x06000025 RID: 37
		event Action<LevelPlayAdInfo> OnAdClosed;

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000026 RID: 38
		// (remove) Token: 0x06000027 RID: 39
		event Action<LevelPlayAdInfo> OnAdClicked;

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000028 RID: 40
		// (remove) Token: 0x06000029 RID: 41
		event Action<LevelPlayAdInfo, LevelPlayAdError> OnAdDisplayFailed;

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x0600002A RID: 42
		// (remove) Token: 0x0600002B RID: 43
		event Action<LevelPlayAdInfo> OnAdInfoChanged;

		// Token: 0x0600002C RID: 44
		string GetAdId();

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600002D RID: 45
		string AdUnitId { get; }

		// Token: 0x0600002E RID: 46
		void LoadAd();

		// Token: 0x0600002F RID: 47
		void ShowAd(string placementName = null);

		// Token: 0x06000030 RID: 48
		void DestroyAd();

		// Token: 0x06000031 RID: 49
		bool IsAdReady();
	}
}
