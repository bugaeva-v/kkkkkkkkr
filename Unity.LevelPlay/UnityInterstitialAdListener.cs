using System;
using UnityEngine;

namespace Unity.Services.LevelPlay
{
	// Token: 0x0200001A RID: 26
	internal sealed class UnityInterstitialAdListener : AndroidJavaProxy, IUnityInterstitialAdListener
	{
		// Token: 0x06000186 RID: 390 RVA: 0x0000512A File Offset: 0x0000332A
		public UnityInterstitialAdListener(IUnityInterstitialAdListener listener) : base("com.ironsource.unity.androidbridge.IUnityInterstitialAdListener")
		{
			this.m_UnityListener = listener;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000513E File Offset: 0x0000333E
		public void onAdLoaded(string adInfo)
		{
			ThreadUtil.Post(delegate(object state)
			{
				this.m_UnityListener.onAdLoaded(adInfo);
			}, null);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00005164 File Offset: 0x00003364
		public void onAdLoadFailed(string error)
		{
			ThreadUtil.Post(delegate(object state)
			{
				this.m_UnityListener.onAdLoadFailed(error);
			}, null);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000518A File Offset: 0x0000338A
		public void onAdDisplayed(string adInfo)
		{
			ThreadUtil.Post(delegate(object state)
			{
				this.m_UnityListener.onAdDisplayed(adInfo);
			}, null);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000051B0 File Offset: 0x000033B0
		public void onAdDisplayFailed(string error, string adInfo)
		{
			ThreadUtil.Post(delegate(object state)
			{
				this.m_UnityListener.onAdDisplayFailed(error, adInfo);
			}, null);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x000051DD File Offset: 0x000033DD
		public void onAdClosed(string adInfo)
		{
			ThreadUtil.Post(delegate(object state)
			{
				this.m_UnityListener.onAdClosed(adInfo);
			}, null);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00005203 File Offset: 0x00003403
		public void onAdClicked(string adInfo)
		{
			ThreadUtil.Post(delegate(object state)
			{
				this.m_UnityListener.onAdClicked(adInfo);
			}, null);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00005229 File Offset: 0x00003429
		public void onAdInfoChanged(string adInfo)
		{
			ThreadUtil.Post(delegate(object state)
			{
				this.m_UnityListener.onAdInfoChanged(adInfo);
			}, null);
		}

		// Token: 0x0400009A RID: 154
		private const string k_AndroidInterstitialListenerName = "com.ironsource.unity.androidbridge.IUnityInterstitialAdListener";

		// Token: 0x0400009B RID: 155
		private readonly IUnityInterstitialAdListener m_UnityListener;
	}
}
