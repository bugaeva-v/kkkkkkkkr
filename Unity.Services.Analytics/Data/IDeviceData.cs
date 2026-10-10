using System;

namespace Unity.Services.Analytics.Data
{
	// Token: 0x0200001F RID: 31
	internal interface IDeviceData
	{
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000AF RID: 175
		string CpuType { get; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000B0 RID: 176
		string GpuType { get; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000B1 RID: 177
		int CpuCores { get; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000B2 RID: 178
		int RamTotal { get; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000B3 RID: 179
		int ScreenWidth { get; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000B4 RID: 180
		int ScreenHeight { get; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000B5 RID: 181
		float ScreenDpi { get; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000B6 RID: 182
		string OperatingSystem { get; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000B7 RID: 183
		string DeviceModel { get; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000B8 RID: 184
		bool IsDebugDevice { get; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000B9 RID: 185
		bool IsTiny { get; }
	}
}
