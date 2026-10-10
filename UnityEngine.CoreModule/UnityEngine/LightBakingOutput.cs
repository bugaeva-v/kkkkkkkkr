using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000155 RID: 341
	[NativeHeader("Runtime/Camera/SharedLightData.h")]
	public struct LightBakingOutput
	{
		// Token: 0x0400042F RID: 1071
		public int probeOcclusionLightIndex;

		// Token: 0x04000430 RID: 1072
		public int occlusionMaskChannel;

		// Token: 0x04000431 RID: 1073
		[NativeName("lightmapBakeMode.lightmapBakeType")]
		public LightmapBakeType lightmapBakeType;

		// Token: 0x04000432 RID: 1074
		[NativeName("lightmapBakeMode.mixedLightingMode")]
		public MixedLightingMode mixedLightingMode;

		// Token: 0x04000433 RID: 1075
		public bool isBaked;
	}
}
