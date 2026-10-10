using System;

namespace Unity.Services.Analytics.Data
{
	// Token: 0x0200001E RID: 30
	internal interface ICommonData
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000A4 RID: 164
		string Version { get; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000A5 RID: 165
		string GameBundleId { get; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000A6 RID: 166
		string ProjectId { get; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000A7 RID: 167
		string Platform { get; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000A8 RID: 168
		string BuildGUID { get; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000A9 RID: 169
		string Idfv { get; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000AA RID: 170
		string GameStoreId { get; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000AB RID: 171
		bool HasVolume { get; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000AC RID: 172
		float Volume { get; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000AD RID: 173
		double BatteryLevel { get; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000AE RID: 174
		string AnalyticsRegionLanguageCode { get; }
	}
}
