using System;

namespace Unity.Services.LevelPlay
{
	// Token: 0x02000003 RID: 3
	public interface ILevelPlayBannerAd : IDisposable
	{
		// Token: 0x06000003 RID: 3
		void LoadAd();

		// Token: 0x06000004 RID: 4
		void DestroyAd();

		// Token: 0x06000005 RID: 5
		void ShowAd();

		// Token: 0x06000006 RID: 6
		void HideAd();

		// Token: 0x06000007 RID: 7
		string GetAdId();

		// Token: 0x06000008 RID: 8
		string GetAdUnitId();

		// Token: 0x06000009 RID: 9
		LevelPlayAdSize GetAdSize();

		// Token: 0x0600000A RID: 10
		LevelPlayBannerPosition GetPosition();

		// Token: 0x0600000B RID: 11
		string GetPlacementName();

		// Token: 0x0600000C RID: 12
		void PauseAutoRefresh();

		// Token: 0x0600000D RID: 13
		void ResumeAutoRefresh();

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600000E RID: 14
		// (remove) Token: 0x0600000F RID: 15
		event Action<LevelPlayAdInfo> OnAdLoaded;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000010 RID: 16
		// (remove) Token: 0x06000011 RID: 17
		event Action<LevelPlayAdError> OnAdLoadFailed;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000012 RID: 18
		// (remove) Token: 0x06000013 RID: 19
		event Action<LevelPlayAdInfo> OnAdClicked;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000014 RID: 20
		// (remove) Token: 0x06000015 RID: 21
		event Action<LevelPlayAdInfo> OnAdDisplayed;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000016 RID: 22
		// (remove) Token: 0x06000017 RID: 23
		event Action<LevelPlayAdInfo, LevelPlayAdError> OnAdDisplayFailed;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000018 RID: 24
		// (remove) Token: 0x06000019 RID: 25
		event Action<LevelPlayAdInfo> OnAdExpanded;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600001A RID: 26
		// (remove) Token: 0x0600001B RID: 27
		event Action<LevelPlayAdInfo> OnAdCollapsed;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600001C RID: 28
		// (remove) Token: 0x0600001D RID: 29
		event Action<LevelPlayAdInfo> OnAdLeftApplication;
	}
}
