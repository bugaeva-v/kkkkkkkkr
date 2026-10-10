using System;
using UnityEngine;

namespace Unity.Services.LevelPlay
{
	// Token: 0x02000016 RID: 22
	internal sealed class AndroidInterstitialAd : IPlatformInterstitialAd, IDisposable, IUnityInterstitialAdListener
	{
		// Token: 0x14000038 RID: 56
		// (add) Token: 0x0600012B RID: 299 RVA: 0x000042F4 File Offset: 0x000024F4
		// (remove) Token: 0x0600012C RID: 300 RVA: 0x0000432C File Offset: 0x0000252C
		public event Action<LevelPlayAdInfo> OnAdLoaded;

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x0600012D RID: 301 RVA: 0x00004364 File Offset: 0x00002564
		// (remove) Token: 0x0600012E RID: 302 RVA: 0x0000439C File Offset: 0x0000259C
		public event Action<LevelPlayAdError> OnAdLoadFailed;

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x0600012F RID: 303 RVA: 0x000043D4 File Offset: 0x000025D4
		// (remove) Token: 0x06000130 RID: 304 RVA: 0x0000440C File Offset: 0x0000260C
		public event Action<LevelPlayAdInfo> OnAdDisplayed;

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x06000131 RID: 305 RVA: 0x00004444 File Offset: 0x00002644
		// (remove) Token: 0x06000132 RID: 306 RVA: 0x0000447C File Offset: 0x0000267C
		public event Action<LevelPlayAdInfo> OnAdClosed;

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x06000133 RID: 307 RVA: 0x000044B4 File Offset: 0x000026B4
		// (remove) Token: 0x06000134 RID: 308 RVA: 0x000044EC File Offset: 0x000026EC
		public event Action<LevelPlayAdInfo> OnAdClicked;

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x06000135 RID: 309 RVA: 0x00004524 File Offset: 0x00002724
		// (remove) Token: 0x06000136 RID: 310 RVA: 0x0000455C File Offset: 0x0000275C
		public event Action<LevelPlayAdInfo, LevelPlayAdError> OnAdDisplayFailed;

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x06000137 RID: 311 RVA: 0x00004594 File Offset: 0x00002794
		// (remove) Token: 0x06000138 RID: 312 RVA: 0x000045CC File Offset: 0x000027CC
		public event Action<LevelPlayAdInfo> OnAdInfoChanged;

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00004601 File Offset: 0x00002801
		public string AdUnitId { get; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00004609 File Offset: 0x00002809
		public string AdId
		{
			get
			{
				return this.m_InterstitialJavaObject.Call<string>("getAdId", Array.Empty<object>());
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00004620 File Offset: 0x00002820
		internal AndroidInterstitialAd(string adUnitId)
		{
			AndroidInterstitialAd <>4__this = this;
			this.AdUnitId = adUnitId;
			ThreadUtil.Send(delegate(object state)
			{
				try
				{
					if (<>4__this.m_InterstitialListener == null)
					{
						<>4__this.m_InterstitialListener = new UnityInterstitialAdListener(<>4__this);
					}
					<>4__this.m_InterstitialJavaObject = new AndroidJavaObject("com.ironsource.unity.androidbridge.InterstitialAd", new object[]
					{
						adUnitId,
						<>4__this.m_InterstitialListener
					});
				}
				catch (Exception exception)
				{
					LevelPlayLogger.LogException(exception);
				}
			}, null);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00004668 File Offset: 0x00002868
		internal AndroidInterstitialAd(string adUnitId, AndroidInterstitialAd.Config config)
		{
			AndroidInterstitialAd <>4__this = this;
			this.AdUnitId = adUnitId;
			ThreadUtil.Send(delegate(object state)
			{
				try
				{
					if (<>4__this.m_InterstitialListener == null)
					{
						<>4__this.m_InterstitialListener = new UnityInterstitialAdListener(<>4__this);
					}
					<>4__this.m_InterstitialJavaObject = new AndroidJavaObject("com.ironsource.unity.androidbridge.InterstitialAd", new object[]
					{
						adUnitId,
						config.ConfigJavaObject,
						<>4__this.m_InterstitialListener
					});
				}
				catch (Exception exception)
				{
					LevelPlayLogger.LogException(exception);
				}
			}, null);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000046B4 File Offset: 0x000028B4
		public void LoadAd()
		{
			if (!this.CheckDisposedAndLogError())
			{
				ThreadUtil.Post(delegate(object state)
				{
					try
					{
						this.m_InterstitialJavaObject.Call("loadAd", Array.Empty<object>());
					}
					catch (Exception exception)
					{
						LevelPlayLogger.LogException(exception);
					}
				}, null);
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000046D0 File Offset: 0x000028D0
		public void ShowAd(string placementName)
		{
			if (!this.CheckDisposedAndLogError())
			{
				ThreadUtil.Post(delegate(object state)
				{
					try
					{
						this.m_InterstitialJavaObject.Call("showAd", new object[]
						{
							placementName
						});
					}
					catch (Exception exception)
					{
						LevelPlayLogger.LogException(exception);
					}
				}, null);
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000470B File Offset: 0x0000290B
		public bool IsAdReady()
		{
			if (!this.CheckDisposedAndLogError())
			{
				ThreadUtil.Send(delegate(object state)
				{
					try
					{
						this.m_IsReady = this.m_InterstitialJavaObject.Call<bool>("isAdReady", Array.Empty<object>());
					}
					catch (Exception exception)
					{
						LevelPlayLogger.LogException(exception);
					}
				}, null);
			}
			return this.m_IsReady;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00004730 File Offset: 0x00002930
		public static bool IsPlacementCapped(string placementName)
		{
			bool result = false;
			try
			{
				using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.ironsource.unity.androidbridge.InterstitialAd"))
				{
					result = androidJavaClass.CallStatic<bool>("isPlacementCapped", new object[]
					{
						placementName
					});
				}
			}
			catch (Exception exception)
			{
				LevelPlayLogger.LogException(exception);
			}
			return result;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00004794 File Offset: 0x00002994
		public void onAdLoaded(string adInfo)
		{
			Action<LevelPlayAdInfo> onAdLoaded = this.OnAdLoaded;
			if (onAdLoaded == null)
			{
				return;
			}
			onAdLoaded(new LevelPlayAdInfo(adInfo));
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000047AC File Offset: 0x000029AC
		public void onAdLoadFailed(string error)
		{
			Action<LevelPlayAdError> onAdLoadFailed = this.OnAdLoadFailed;
			if (onAdLoadFailed == null)
			{
				return;
			}
			onAdLoadFailed(new LevelPlayAdError(error));
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000047C4 File Offset: 0x000029C4
		public void onAdDisplayed(string adInfo)
		{
			Action<LevelPlayAdInfo> onAdDisplayed = this.OnAdDisplayed;
			if (onAdDisplayed == null)
			{
				return;
			}
			onAdDisplayed(new LevelPlayAdInfo(adInfo));
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000047DC File Offset: 0x000029DC
		public void onAdClosed(string adInfo)
		{
			Action<LevelPlayAdInfo> onAdClosed = this.OnAdClosed;
			if (onAdClosed == null)
			{
				return;
			}
			onAdClosed(new LevelPlayAdInfo(adInfo));
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000047F4 File Offset: 0x000029F4
		public void onAdDisplayFailed(string error, string adInfo)
		{
			Action<LevelPlayAdInfo, LevelPlayAdError> onAdDisplayFailed = this.OnAdDisplayFailed;
			if (onAdDisplayFailed == null)
			{
				return;
			}
			onAdDisplayFailed(new LevelPlayAdInfo(adInfo), new LevelPlayAdError(error));
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00004812 File Offset: 0x00002A12
		public void onAdClicked(string adInfo)
		{
			Action<LevelPlayAdInfo> onAdClicked = this.OnAdClicked;
			if (onAdClicked == null)
			{
				return;
			}
			onAdClicked(new LevelPlayAdInfo(adInfo));
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000482A File Offset: 0x00002A2A
		public void onAdInfoChanged(string adInfo)
		{
			Action<LevelPlayAdInfo> onAdInfoChanged = this.OnAdInfoChanged;
			if (onAdInfoChanged == null)
			{
				return;
			}
			onAdInfoChanged(new LevelPlayAdInfo(adInfo));
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00004842 File Offset: 0x00002A42
		private void Dispose(bool disposing)
		{
			if (this.m_Disposed)
			{
				return;
			}
			this.m_Disposed = true;
			if (disposing)
			{
				ThreadUtil.Post(delegate(object state)
				{
					AndroidJavaObject interstitialJavaObject = this.m_InterstitialJavaObject;
					if (interstitialJavaObject != null)
					{
						interstitialJavaObject.Dispose();
					}
					this.m_IsReady = false;
					this.m_InterstitialListener = null;
					this.m_InterstitialJavaObject = null;
				}, null);
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000486D File Offset: 0x00002A6D
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000487C File Offset: 0x00002A7C
		~AndroidInterstitialAd()
		{
			this.Dispose(false);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000048AC File Offset: 0x00002AAC
		private bool CheckDisposedAndLogError()
		{
			if (this.m_Disposed)
			{
				LevelPlayLogger.LogError("Instance is disposed. Please create a new instance in order to call any method.");
			}
			return this.m_Disposed;
		}

		// Token: 0x04000070 RID: 112
		private const string k_AndroidInterstitialClass = "com.ironsource.unity.androidbridge.InterstitialAd";

		// Token: 0x04000071 RID: 113
		private const string k_AndroidLoadAdFunction = "loadAd";

		// Token: 0x04000072 RID: 114
		private const string k_AndroidShowAdFunction = "showAd";

		// Token: 0x04000073 RID: 115
		private const string k_IsAdReadyFunction = "isAdReady";

		// Token: 0x04000074 RID: 116
		private const string k_IsPlacementCappedStaticFunction = "isPlacementCapped";

		// Token: 0x04000075 RID: 117
		private const string k_FuncGetAdId = "getAdId";

		// Token: 0x04000076 RID: 118
		private const string k_ErrorDisposed = "Instance is disposed. Please create a new instance in order to call any method.";

		// Token: 0x0400007E RID: 126
		private AndroidJavaObject m_InterstitialJavaObject;

		// Token: 0x0400007F RID: 127
		private IUnityInterstitialAdListener m_InterstitialListener;

		// Token: 0x04000080 RID: 128
		private volatile bool m_Disposed;

		// Token: 0x04000081 RID: 129
		private volatile bool m_IsReady;

		// Token: 0x02000036 RID: 54
		internal class Config : IPlatformInterstitialAd.IConfig
		{
			// Token: 0x17000046 RID: 70
			// (get) Token: 0x06000257 RID: 599 RVA: 0x000061E9 File Offset: 0x000043E9
			internal AndroidJavaObject ConfigJavaObject { get; }

			// Token: 0x06000258 RID: 600 RVA: 0x000061F1 File Offset: 0x000043F1
			private Config(AndroidJavaObject config)
			{
				this.ConfigJavaObject = config;
			}

			// Token: 0x0200005B RID: 91
			internal class Builder : IPlatformInterstitialAd.IConfigBuilder
			{
				// Token: 0x060002B6 RID: 694 RVA: 0x000070BE File Offset: 0x000052BE
				internal Builder()
				{
					this.m_BuilderJavaObject = new AndroidJavaObject("com.ironsource.unity.androidbridge.InterstitialAd$ConfigBuilder", Array.Empty<object>());
				}

				// Token: 0x060002B7 RID: 695 RVA: 0x000070DB File Offset: 0x000052DB
				public void SetBidFloor(double bidFloor)
				{
					this.m_BuilderJavaObject.Call("setBidFloor", new object[]
					{
						bidFloor
					});
				}

				// Token: 0x060002B8 RID: 696 RVA: 0x000070FC File Offset: 0x000052FC
				public IPlatformInterstitialAd.IConfig Build()
				{
					return new AndroidInterstitialAd.Config(this.m_BuilderJavaObject.Call<AndroidJavaObject>("build", Array.Empty<object>()));
				}

				// Token: 0x04000134 RID: 308
				private const string KBuilderClass = "com.ironsource.unity.androidbridge.InterstitialAd$ConfigBuilder";

				// Token: 0x04000135 RID: 309
				private readonly AndroidJavaObject m_BuilderJavaObject;
			}
		}
	}
}
