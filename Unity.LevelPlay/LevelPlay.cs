using System;
using System.Linq;
using UnityEngine;

namespace Unity.Services.LevelPlay
{
	// Token: 0x02000007 RID: 7
	public class LevelPlay
	{
		// Token: 0x0600005D RID: 93 RVA: 0x00002084 File Offset: 0x00000284
		static LevelPlay()
		{
			LevelPlay.Sdk = LevelPlaySdkProvider.Get();
			if (LevelPlay.Sdk == null)
			{
				return;
			}
			LevelPlay.Sdk.OnInitSuccess += delegate(LevelPlayConfiguration configuration)
			{
				Action<LevelPlayConfiguration> onInitSuccessReceived = LevelPlay.OnInitSuccessReceived;
				if (onInitSuccessReceived == null)
				{
					return;
				}
				onInitSuccessReceived(configuration);
			};
			LevelPlay.Sdk.OnInitFailed += delegate(LevelPlayInitError error)
			{
				Action<LevelPlayInitError> onInitFailedReceived = LevelPlay.OnInitFailedReceived;
				if (onInitFailedReceived == null)
				{
					return;
				}
				onInitFailedReceived(error);
			};
			LevelPlay.Sdk.OnImpressionDataReady += delegate(LevelPlayImpressionData impressionData)
			{
				Action<LevelPlayImpressionData> onImpressionDataReadyReceived = LevelPlay.OnImpressionDataReadyReceived;
				if (onImpressionDataReadyReceived == null)
				{
					return;
				}
				onImpressionDataReadyReceived(impressionData);
			};
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600005E RID: 94 RVA: 0x000020FB File Offset: 0x000002FB
		public static string UnityVersion
		{
			get
			{
				return Application.unityVersion;
			}
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x0600005F RID: 95 RVA: 0x00002104 File Offset: 0x00000304
		// (remove) Token: 0x06000060 RID: 96 RVA: 0x00002138 File Offset: 0x00000338
		private static event Action<LevelPlayConfiguration> OnInitSuccessReceived;

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06000061 RID: 97 RVA: 0x0000216C File Offset: 0x0000036C
		// (remove) Token: 0x06000062 RID: 98 RVA: 0x000021A0 File Offset: 0x000003A0
		private static event Action<LevelPlayInitError> OnInitFailedReceived;

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06000063 RID: 99 RVA: 0x000021D4 File Offset: 0x000003D4
		// (remove) Token: 0x06000064 RID: 100 RVA: 0x00002208 File Offset: 0x00000408
		private static event Action<LevelPlayImpressionData> OnImpressionDataReadyReceived;

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06000065 RID: 101 RVA: 0x0000223B File Offset: 0x0000043B
		// (remove) Token: 0x06000066 RID: 102 RVA: 0x0000225C File Offset: 0x0000045C
		public static event Action<LevelPlayConfiguration> OnInitSuccess
		{
			add
			{
				if (LevelPlay.OnInitSuccessReceived == null || !LevelPlay.OnInitSuccessReceived.GetInvocationList().Contains(value))
				{
					LevelPlay.OnInitSuccessReceived += value;
				}
			}
			remove
			{
				if (LevelPlay.OnInitSuccessReceived != null && LevelPlay.OnInitSuccessReceived.GetInvocationList().Contains(value))
				{
					LevelPlay.OnInitSuccessReceived -= value;
				}
			}
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06000067 RID: 103 RVA: 0x0000227D File Offset: 0x0000047D
		// (remove) Token: 0x06000068 RID: 104 RVA: 0x0000229E File Offset: 0x0000049E
		public static event Action<LevelPlayInitError> OnInitFailed
		{
			add
			{
				if (LevelPlay.OnInitFailedReceived == null || !LevelPlay.OnInitFailedReceived.GetInvocationList().Contains(value))
				{
					LevelPlay.OnInitFailedReceived += value;
				}
			}
			remove
			{
				if (LevelPlay.OnInitFailedReceived != null && LevelPlay.OnInitFailedReceived.GetInvocationList().Contains(value))
				{
					LevelPlay.OnInitFailedReceived -= value;
				}
			}
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x06000069 RID: 105 RVA: 0x000022BF File Offset: 0x000004BF
		// (remove) Token: 0x0600006A RID: 106 RVA: 0x000022E0 File Offset: 0x000004E0
		public static event Action<LevelPlayImpressionData> OnImpressionDataReady
		{
			add
			{
				if (LevelPlay.OnImpressionDataReadyReceived == null || !LevelPlay.OnImpressionDataReadyReceived.GetInvocationList().Contains(value))
				{
					LevelPlay.OnImpressionDataReadyReceived += value;
				}
			}
			remove
			{
				if (LevelPlay.OnImpressionDataReadyReceived != null && LevelPlay.OnImpressionDataReadyReceived.GetInvocationList().Contains(value))
				{
					LevelPlay.OnImpressionDataReadyReceived -= value;
				}
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002301 File Offset: 0x00000501
		public static void Init(string appKey, string userId = null)
		{
			if (LevelPlay.Sdk == null)
			{
				return;
			}
			LevelPlay.Sdk.Initialize(appKey, userId);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002317 File Offset: 0x00000517
		public static void SetPauseGame(bool pause)
		{
			ILevelPlaySdk sdk = LevelPlay.Sdk;
			if (sdk == null)
			{
				return;
			}
			sdk.SetPauseGame(pause);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002329 File Offset: 0x00000529
		public static bool SetDynamicUserId(string dynamicUserId)
		{
			ILevelPlaySdk sdk = LevelPlay.Sdk;
			return sdk != null && sdk.SetDynamicUserId(dynamicUserId);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000233C File Offset: 0x0000053C
		public static void ValidateIntegration()
		{
			ILevelPlaySdk sdk = LevelPlay.Sdk;
			if (sdk == null)
			{
				return;
			}
			sdk.ValidateIntegration();
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000234D File Offset: 0x0000054D
		public static void LaunchTestSuite()
		{
			ILevelPlaySdk sdk = LevelPlay.Sdk;
			if (sdk == null)
			{
				return;
			}
			sdk.LaunchTestSuite();
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000235E File Offset: 0x0000055E
		public static void SetAdaptersDebug(bool enabled)
		{
			ILevelPlaySdk sdk = LevelPlay.Sdk;
			if (sdk == null)
			{
				return;
			}
			sdk.SetAdaptersDebug(enabled);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002370 File Offset: 0x00000570
		public static void SetNetworkData(string networkKey, string networkData)
		{
			ILevelPlaySdk sdk = LevelPlay.Sdk;
			if (sdk == null)
			{
				return;
			}
			sdk.SetNetworkData(networkKey, networkData);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002383 File Offset: 0x00000583
		public static void SetMetaData(string key, string value)
		{
			ILevelPlaySdk sdk = LevelPlay.Sdk;
			if (sdk == null)
			{
				return;
			}
			sdk.SetMetaData(key, value);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002396 File Offset: 0x00000596
		public static void SetMetaData(string key, params string[] values)
		{
			ILevelPlaySdk sdk = LevelPlay.Sdk;
			if (sdk == null)
			{
				return;
			}
			sdk.SetMetaData(key, values);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000023A9 File Offset: 0x000005A9
		[Obsolete("Use LevelPlayPrivacySettings.SetGDPRConsents() for GDPR consent management.", false)]
		public static void SetConsent(bool consent)
		{
			ILevelPlaySdk sdk = LevelPlay.Sdk;
			if (sdk == null)
			{
				return;
			}
			sdk.SetConsent(consent);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000023BB File Offset: 0x000005BB
		public static void SetSegment(LevelPlaySegment segment)
		{
			ILevelPlaySdk sdk = LevelPlay.Sdk;
			if (sdk == null)
			{
				return;
			}
			sdk.SetSegment(segment);
		}

		// Token: 0x04000008 RID: 8
		private static readonly ILevelPlaySdk Sdk;

		// Token: 0x04000009 RID: 9
		public static string PluginVersion = "9.4.1";
	}
}
