using System;
using System.Collections.Generic;

namespace Unity.Services.LevelPlay
{
	// Token: 0x02000006 RID: 6
	internal interface ILevelPlaySdk
	{
		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06000049 RID: 73
		// (remove) Token: 0x0600004A RID: 74
		event Action<LevelPlayConfiguration> OnInitSuccess;

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x0600004B RID: 75
		// (remove) Token: 0x0600004C RID: 76
		event Action<LevelPlayInitError> OnInitFailed;

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x0600004D RID: 77
		// (remove) Token: 0x0600004E RID: 78
		event Action<LevelPlayImpressionData> OnImpressionDataReady;

		// Token: 0x0600004F RID: 79
		void Initialize(string appKey, string userId);

		// Token: 0x06000050 RID: 80
		void SetPauseGame(bool pause);

		// Token: 0x06000051 RID: 81
		bool SetDynamicUserId(string dynamicUserId);

		// Token: 0x06000052 RID: 82
		void ValidateIntegration();

		// Token: 0x06000053 RID: 83
		void LaunchTestSuite();

		// Token: 0x06000054 RID: 84
		void SetAdaptersDebug(bool enabled);

		// Token: 0x06000055 RID: 85
		void SetNetworkData(string networkKey, string networkData);

		// Token: 0x06000056 RID: 86
		void SetMetaData(string key, string value);

		// Token: 0x06000057 RID: 87
		void SetMetaData(string key, params string[] values);

		// Token: 0x06000058 RID: 88
		void SetConsent(bool consent);

		// Token: 0x06000059 RID: 89
		void SetSegment(LevelPlaySegment segment);

		// Token: 0x0600005A RID: 90
		void SetGDPRConsents(Dictionary<string, bool> networkConsents);

		// Token: 0x0600005B RID: 91
		void SetCCPA(bool value);

		// Token: 0x0600005C RID: 92
		void SetCOPPA(bool value);
	}
}
