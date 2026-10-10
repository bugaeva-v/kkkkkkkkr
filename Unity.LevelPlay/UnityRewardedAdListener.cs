using System;
using UnityEngine;

namespace Unity.Services.LevelPlay
{
	// Token: 0x0200001B RID: 27
	internal sealed class UnityRewardedAdListener : AndroidJavaProxy, IUnityRewardedAdListener
	{
		// Token: 0x0600018E RID: 398 RVA: 0x0000524F File Offset: 0x0000344F
		public UnityRewardedAdListener(IUnityRewardedAdListener listener) : base("com.ironsource.unity.androidbridge.IUnityRewardedAdListener")
		{
			this.m_UnityListener = listener;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00005263 File Offset: 0x00003463
		public void onAdLoaded(string adInfo)
		{
			ThreadUtil.Post(delegate(object state)
			{
				this.m_UnityListener.onAdLoaded(adInfo);
			}, null);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00005289 File Offset: 0x00003489
		public void onAdLoadFailed(string error)
		{
			ThreadUtil.Post(delegate(object state)
			{
				this.m_UnityListener.onAdLoadFailed(error);
			}, null);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000052AF File Offset: 0x000034AF
		public void onAdDisplayed(string adInfo)
		{
			ThreadUtil.Post(delegate(object state)
			{
				this.m_UnityListener.onAdDisplayed(adInfo);
			}, null);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000052D5 File Offset: 0x000034D5
		public void onAdDisplayFailed(string error, string adInfo)
		{
			ThreadUtil.Post(delegate(object state)
			{
				this.m_UnityListener.onAdDisplayFailed(error, adInfo);
			}, null);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00005302 File Offset: 0x00003502
		public void onAdRewarded(string adInfo, string rewardName, int rewardAmount)
		{
			ThreadUtil.Post(delegate(object state)
			{
				this.m_UnityListener.onAdRewarded(adInfo, rewardName, rewardAmount);
			}, null);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00005336 File Offset: 0x00003536
		public void onAdClicked(string adInfo)
		{
			ThreadUtil.Post(delegate(object state)
			{
				this.m_UnityListener.onAdClicked(adInfo);
			}, null);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000535C File Offset: 0x0000355C
		public void onAdClosed(string adInfo)
		{
			ThreadUtil.Post(delegate(object state)
			{
				this.m_UnityListener.onAdClosed(adInfo);
			}, null);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00005382 File Offset: 0x00003582
		public void onAdInfoChanged(string adInfo)
		{
			ThreadUtil.Post(delegate(object state)
			{
				this.m_UnityListener.onAdInfoChanged(adInfo);
			}, null);
		}

		// Token: 0x0400009C RID: 156
		private const string k_AndroidRewardedAdListenerName = "com.ironsource.unity.androidbridge.IUnityRewardedAdListener";

		// Token: 0x0400009D RID: 157
		private readonly IUnityRewardedAdListener m_UnityListener;
	}
}
