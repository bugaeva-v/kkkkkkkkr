using System;

namespace Unity.Services.LevelPlay
{
	// Token: 0x02000005 RID: 5
	public interface ILevelPlayRewardedAd : IDisposable
	{
		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000032 RID: 50
		// (remove) Token: 0x06000033 RID: 51
		event Action<LevelPlayAdInfo> OnAdLoaded;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000034 RID: 52
		// (remove) Token: 0x06000035 RID: 53
		event Action<LevelPlayAdError> OnAdLoadFailed;

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000036 RID: 54
		// (remove) Token: 0x06000037 RID: 55
		event Action<LevelPlayAdInfo> OnAdDisplayed;

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000038 RID: 56
		// (remove) Token: 0x06000039 RID: 57
		event Action<LevelPlayAdInfo, LevelPlayAdError> OnAdDisplayFailed;

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x0600003A RID: 58
		// (remove) Token: 0x0600003B RID: 59
		event Action<LevelPlayAdInfo, LevelPlayReward> OnAdRewarded;

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x0600003C RID: 60
		// (remove) Token: 0x0600003D RID: 61
		event Action<LevelPlayAdInfo> OnAdClicked;

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x0600003E RID: 62
		// (remove) Token: 0x0600003F RID: 63
		event Action<LevelPlayAdInfo> OnAdClosed;

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06000040 RID: 64
		// (remove) Token: 0x06000041 RID: 65
		event Action<LevelPlayAdInfo> OnAdInfoChanged;

		// Token: 0x06000042 RID: 66
		string GetAdId();

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000043 RID: 67
		string AdUnitId { get; }

		// Token: 0x06000044 RID: 68
		void LoadAd();

		// Token: 0x06000045 RID: 69
		void ShowAd(string placementName = null);

		// Token: 0x06000046 RID: 70
		void DestroyAd();

		// Token: 0x06000047 RID: 71
		bool IsAdReady();

		// Token: 0x06000048 RID: 72
		LevelPlayReward GetReward(string placement);
	}
}
