using System;

namespace Unity.Services.Analytics.Platform
{
	// Token: 0x02000024 RID: 36
	internal static class DeviceVolumeProvider
	{
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x000043A2 File Offset: 0x000025A2
		internal static bool VolumeAvailable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000043A5 File Offset: 0x000025A5
		internal static float GetDeviceVolume()
		{
			return 0f;
		}
	}
}
