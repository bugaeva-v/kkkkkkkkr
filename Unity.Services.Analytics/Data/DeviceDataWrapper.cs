using System;
using UnityEngine;

namespace Unity.Services.Analytics.Data
{
	// Token: 0x02000020 RID: 32
	internal class DeviceDataWrapper : IDeviceData
	{
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00003CD4 File Offset: 0x00001ED4
		public string CpuType
		{
			get
			{
				return SystemInfo.processorType;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00003CDB File Offset: 0x00001EDB
		public string GpuType
		{
			get
			{
				return SystemInfo.graphicsDeviceName;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00003CE2 File Offset: 0x00001EE2
		public int CpuCores
		{
			get
			{
				return SystemInfo.processorCount;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00003CE9 File Offset: 0x00001EE9
		public int RamTotal
		{
			get
			{
				return SystemInfo.systemMemorySize;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00003CF0 File Offset: 0x00001EF0
		public int ScreenWidth
		{
			get
			{
				return Screen.width;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00003CF7 File Offset: 0x00001EF7
		public int ScreenHeight
		{
			get
			{
				return Screen.height;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00003CFE File Offset: 0x00001EFE
		public float ScreenDpi
		{
			get
			{
				return Screen.dpi;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00003D05 File Offset: 0x00001F05
		public string OperatingSystem
		{
			get
			{
				return SystemInfo.operatingSystem;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00003D0C File Offset: 0x00001F0C
		public string DeviceModel
		{
			get
			{
				return SystemInfo.deviceModel;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00003D13 File Offset: 0x00001F13
		public bool IsDebugDevice
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00003D16 File Offset: 0x00001F16
		public bool IsTiny
		{
			get
			{
				return false;
			}
		}
	}
}
