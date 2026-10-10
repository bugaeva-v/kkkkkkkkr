using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020003B8 RID: 952
	internal static class CameraEventUtils
	{
		// Token: 0x06001F5C RID: 8028 RVA: 0x00033258 File Offset: 0x00031458
		public static bool IsValid(CameraEvent value)
		{
			return value >= CameraEvent.BeforeDepthTexture && value <= CameraEvent.AfterHaloAndLensFlares;
		}

		// Token: 0x04000AFF RID: 2815
		private const CameraEvent k_MinimumValue = CameraEvent.BeforeDepthTexture;

		// Token: 0x04000B00 RID: 2816
		private const CameraEvent k_MaximumValue = CameraEvent.AfterHaloAndLensFlares;
	}
}
