using System;
using UnityEngine;

namespace Unity.Services.LevelPlay
{
	// Token: 0x02000017 RID: 23
	internal sealed class AndroidRewardedAd : IPlatformRewardedAd, IDisposable, IUnityRewardedAdListener
	{
		// Token: 0x1400003F RID: 63
		// (add) Token: 0x0600014F RID: 335 RVA: 0x00004978 File Offset: 0x00002B78
		// (remove) Token: 0x06000150 RID: 336 RVA: 0x000049B0 File Offset: 0x00002BB0
		public event Action<LevelPlayAdInfo> OnAdLoaded;

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x06000151 RID: 337 RVA: 0x000049E8 File Offset: 0x00002BE8
		// (remove) Token: 0x06000152 RID: 338 RVA: 0x00004A20 File Offset: 0x00002C20
		public event Action<LevelPlayAdError> OnAdLoadFailed;

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x06000153 RID: 339 RVA: 0x00004A58 File Offset: 0x00002C58
		// (remove) Token: 0x06000154 RID: 340 RVA: 0x00004A90 File Offset: 0x00002C90
		public event Action<LevelPlayAdInfo> OnAdDisplayed;

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x06000155 RID: 341 RVA: 0x00004AC8 File Offset: 0x00002CC8
		// (remove) Token: 0x06000156 RID: 342 RVA: 0x00004B00 File Offset: 0x00002D00
		public event Action<LevelPlayAdInfo, LevelPlayAdError> OnAdDisplayFailed;

		// Token: 0x14000043 RID: 67
		// (add) Token: 0x06000157 RID: 343 RVA: 0x00004B38 File Offset: 0x00002D38
		// (remove) Token: 0x06000158 RID: 344 RVA: 0x00004B70 File Offset: 0x00002D70
		public event Action<LevelPlayAdInfo, LevelPlayReward> OnAdRewarded;

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x06000159 RID: 345 RVA: 0x00004BA8 File Offset: 0x00002DA8
		// (remove) Token: 0x0600015A RID: 346 RVA: 0x00004BE0 File Offset: 0x00002DE0
		public event Action<LevelPlayAdInfo> OnAdClicked;

		// Token: 0x14000045 RID: 69
		// (add) Token: 0x0600015B RID: 347 RVA: 0x00004C18 File Offset: 0x00002E18
		// (remove) Token: 0x0600015C RID: 348 RVA: 0x00004C50 File Offset: 0x00002E50
		public event Action<LevelPlayAdInfo> OnAdClosed;

		// Token: 0x14000046 RID: 70
		// (add) Token: 0x0600015D RID: 349 RVA: 0x00004C88 File Offset: 0x00002E88
		// (remove) Token: 0x0600015E RID: 350 RVA: 0x00004CC0 File Offset: 0x00002EC0
		public event Action<LevelPlayAdInfo> OnAdInfoChanged;

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00004CF5 File Offset: 0x00002EF5
		public string AdUnitId { get; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00004CFD File Offset: 0x00002EFD
		public string AdId
		{
			get
			{
				return this.m_RewardedAdJavaObject.Call<string>("getAdId", Array.Empty<object>());
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00004D14 File Offset: 0x00002F14
		internal AndroidRewardedAd(string adUnitId)
		{
			AndroidRewardedAd <>4__this = this;
			this.AdUnitId = adUnitId;
			ThreadUtil.Send(delegate(object state)
			{
				try
				{
					if (<>4__this.m_RewardedAdListener == null)
					{
						<>4__this.m_RewardedAdListener = new UnityRewardedAdListener(<>4__this);
					}
					<>4__this.m_RewardedAdJavaObject = new AndroidJavaObject("com.ironsource.unity.androidbridge.RewardedAd", new object[]
					{
						adUnitId,
						<>4__this.m_RewardedAdListener
					});
				}
				catch (Exception exception)
				{
					LevelPlayLogger.LogException(exception);
				}
			}, null);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00004D5C File Offset: 0x00002F5C
		internal AndroidRewardedAd(string adUnitId, AndroidRewardedAd.Config config)
		{
			AndroidRewardedAd <>4__this = this;
			this.AdUnitId = adUnitId;
			ThreadUtil.Send(delegate(object state)
			{
				try
				{
					if (<>4__this.m_RewardedAdListener == null)
					{
						<>4__this.m_RewardedAdListener = new UnityRewardedAdListener(<>4__this);
					}
					<>4__this.m_RewardedAdJavaObject = new AndroidJavaObject("com.ironsource.unity.androidbridge.RewardedAd", new object[]
					{
						adUnitId,
						config.ConfigJavaObject,
						<>4__this.m_RewardedAdListener
					});
				}
				catch (Exception exception)
				{
					LevelPlayLogger.LogException(exception);
				}
			}, null);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00004DA8 File Offset: 0x00002FA8
		public void LoadAd()
		{
			if (!this.CheckDisposedAndLogError())
			{
				ThreadUtil.Post(delegate(object state)
				{
					try
					{
						this.m_RewardedAdJavaObject.Call("loadAd", Array.Empty<object>());
					}
					catch (Exception exception)
					{
						LevelPlayLogger.LogException(exception);
					}
				}, null);
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00004DC4 File Offset: 0x00002FC4
		public void ShowAd(string placementName)
		{
			if (!this.CheckDisposedAndLogError())
			{
				ThreadUtil.Post(delegate(object state)
				{
					try
					{
						this.m_RewardedAdJavaObject.Call("showAd", new object[]
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

		// Token: 0x06000165 RID: 357 RVA: 0x00004DFF File Offset: 0x00002FFF
		public bool IsAdReady()
		{
			if (!this.CheckDisposedAndLogError())
			{
				ThreadUtil.Send(delegate(object state)
				{
					try
					{
						this.m_IsReady = this.m_RewardedAdJavaObject.Call<bool>("isAdReady", Array.Empty<object>());
					}
					catch (Exception exception)
					{
						LevelPlayLogger.LogException(exception);
					}
				}, null);
			}
			return this.m_IsReady;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00004E24 File Offset: 0x00003024
		public static bool IsPlacementCapped(string placementName)
		{
			bool result = false;
			try
			{
				using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.ironsource.unity.androidbridge.RewardedAd"))
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

		// Token: 0x06000167 RID: 359 RVA: 0x00004E88 File Offset: 0x00003088
		public LevelPlayReward GetReward(string placement)
		{
			if (this.CheckDisposedAndLogError())
			{
				return LevelPlayReward.Default;
			}
			LevelPlayReward result;
			try
			{
				using (AndroidJavaObject androidJavaObject = this.m_RewardedAdJavaObject.Call<AndroidJavaObject>("getReward", new object[]
				{
					placement
				}))
				{
					if (androidJavaObject == null)
					{
						result = LevelPlayReward.Default;
					}
					else
					{
						string name = androidJavaObject.Call<string>("getName", Array.Empty<object>());
						int amount = androidJavaObject.Call<int>("getAmount", Array.Empty<object>());
						result = new LevelPlayReward(name, amount);
					}
				}
			}
			catch (Exception exception)
			{
				LevelPlayLogger.LogException(exception);
				result = LevelPlayReward.Default;
			}
			return result;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00004F28 File Offset: 0x00003128
		public void onAdLoaded(string adInfo)
		{
			Action<LevelPlayAdInfo> onAdLoaded = this.OnAdLoaded;
			if (onAdLoaded == null)
			{
				return;
			}
			onAdLoaded(new LevelPlayAdInfo(adInfo));
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00004F40 File Offset: 0x00003140
		public void onAdLoadFailed(string error)
		{
			Action<LevelPlayAdError> onAdLoadFailed = this.OnAdLoadFailed;
			if (onAdLoadFailed == null)
			{
				return;
			}
			onAdLoadFailed(new LevelPlayAdError(error));
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00004F58 File Offset: 0x00003158
		public void onAdDisplayed(string adInfo)
		{
			Action<LevelPlayAdInfo> onAdDisplayed = this.OnAdDisplayed;
			if (onAdDisplayed == null)
			{
				return;
			}
			onAdDisplayed(new LevelPlayAdInfo(adInfo));
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00004F70 File Offset: 0x00003170
		public void onAdDisplayFailed(string error, string adInfo)
		{
			Action<LevelPlayAdInfo, LevelPlayAdError> onAdDisplayFailed = this.OnAdDisplayFailed;
			if (onAdDisplayFailed == null)
			{
				return;
			}
			onAdDisplayFailed(new LevelPlayAdInfo(adInfo), new LevelPlayAdError(error));
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00004F8E File Offset: 0x0000318E
		public void onAdRewarded(string adInfo, string rewardName, int rewardAmount)
		{
			Action<LevelPlayAdInfo, LevelPlayReward> onAdRewarded = this.OnAdRewarded;
			if (onAdRewarded == null)
			{
				return;
			}
			onAdRewarded(new LevelPlayAdInfo(adInfo), new LevelPlayReward(rewardName, rewardAmount));
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00004FAD File Offset: 0x000031AD
		public void onAdClicked(string adInfo)
		{
			Action<LevelPlayAdInfo> onAdClicked = this.OnAdClicked;
			if (onAdClicked == null)
			{
				return;
			}
			onAdClicked(new LevelPlayAdInfo(adInfo));
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00004FC5 File Offset: 0x000031C5
		public void onAdClosed(string adInfo)
		{
			Action<LevelPlayAdInfo> onAdClosed = this.OnAdClosed;
			if (onAdClosed == null)
			{
				return;
			}
			onAdClosed(new LevelPlayAdInfo(adInfo));
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00004FDD File Offset: 0x000031DD
		public void onAdInfoChanged(string adInfo)
		{
			Action<LevelPlayAdInfo> onAdInfoChanged = this.OnAdInfoChanged;
			if (onAdInfoChanged == null)
			{
				return;
			}
			onAdInfoChanged(new LevelPlayAdInfo(adInfo));
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00004FF5 File Offset: 0x000031F5
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
					AndroidJavaObject rewardedAdJavaObject = this.m_RewardedAdJavaObject;
					if (rewardedAdJavaObject != null)
					{
						rewardedAdJavaObject.Dispose();
					}
					this.m_IsReady = false;
					this.m_RewardedAdListener = null;
					this.m_RewardedAdJavaObject = null;
				}, null);
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00005020 File Offset: 0x00003220
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00005030 File Offset: 0x00003230
		~AndroidRewardedAd()
		{
			this.Dispose(false);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00005060 File Offset: 0x00003260
		private bool CheckDisposedAndLogError()
		{
			if (this.m_Disposed)
			{
				LevelPlayLogger.LogError("Instance is disposed. Please create a new instance in order to call any method.");
			}
			return this.m_Disposed;
		}

		// Token: 0x04000083 RID: 131
		private const string k_AndroidRewardedAdClass = "com.ironsource.unity.androidbridge.RewardedAd";

		// Token: 0x04000084 RID: 132
		private const string k_AndroidLoadAdFunction = "loadAd";

		// Token: 0x04000085 RID: 133
		private const string k_AndroidShowAdFunction = "showAd";

		// Token: 0x04000086 RID: 134
		private const string k_IsAdReadyFunction = "isAdReady";

		// Token: 0x04000087 RID: 135
		private const string k_IsPlacementCappedStaticFunction = "isPlacementCapped";

		// Token: 0x04000088 RID: 136
		private const string k_FuncGetAdId = "getAdId";

		// Token: 0x04000089 RID: 137
		private const string k_FuncGetReward = "getReward";

		// Token: 0x0400008A RID: 138
		private const string k_FuncGetName = "getName";

		// Token: 0x0400008B RID: 139
		private const string k_FuncGetAmount = "getAmount";

		// Token: 0x0400008C RID: 140
		private const string k_ErrorDisposed = "Instance is disposed. Please create a new instance in order to call any method.";

		// Token: 0x04000095 RID: 149
		private AndroidJavaObject m_RewardedAdJavaObject;

		// Token: 0x04000096 RID: 150
		private IUnityRewardedAdListener m_RewardedAdListener;

		// Token: 0x04000097 RID: 151
		private volatile bool m_Disposed;

		// Token: 0x04000098 RID: 152
		private volatile bool m_IsReady;

		// Token: 0x0200003A RID: 58
		internal class Config : IPlatformRewardedAd.IConfig
		{
			// Token: 0x17000047 RID: 71
			// (get) Token: 0x0600025F RID: 607 RVA: 0x0000636C File Offset: 0x0000456C
			internal AndroidJavaObject ConfigJavaObject { get; }

			// Token: 0x06000260 RID: 608 RVA: 0x00006374 File Offset: 0x00004574
			private Config(AndroidJavaObject config)
			{
				this.ConfigJavaObject = config;
			}

			// Token: 0x0200005C RID: 92
			internal class Builder : IPlatformRewardedAd.IConfigBuilder
			{
				// Token: 0x060002B9 RID: 697 RVA: 0x00007118 File Offset: 0x00005318
				internal Builder()
				{
					this.m_BuilderJavaObject = new AndroidJavaObject("com.ironsource.unity.androidbridge.RewardedAd$ConfigBuilder", Array.Empty<object>());
				}

				// Token: 0x060002BA RID: 698 RVA: 0x00007135 File Offset: 0x00005335
				public void SetBidFloor(double bidFloor)
				{
					this.m_BuilderJavaObject.Call("setBidFloor", new object[]
					{
						bidFloor
					});
				}

				// Token: 0x060002BB RID: 699 RVA: 0x00007156 File Offset: 0x00005356
				public IPlatformRewardedAd.IConfig Build()
				{
					return new AndroidRewardedAd.Config(this.m_BuilderJavaObject.Call<AndroidJavaObject>("build", Array.Empty<object>()));
				}

				// Token: 0x04000136 RID: 310
				private const string KBuilderClass = "com.ironsource.unity.androidbridge.RewardedAd$ConfigBuilder";

				// Token: 0x04000137 RID: 311
				private readonly AndroidJavaObject m_BuilderJavaObject;
			}
		}
	}
}
