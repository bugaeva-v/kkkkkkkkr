using System;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	// Token: 0x020003AE RID: 942
	[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
	public enum BlendMode
	{
		// Token: 0x04000A8C RID: 2700
		Zero,
		// Token: 0x04000A8D RID: 2701
		One,
		// Token: 0x04000A8E RID: 2702
		DstColor,
		// Token: 0x04000A8F RID: 2703
		SrcColor,
		// Token: 0x04000A90 RID: 2704
		OneMinusDstColor,
		// Token: 0x04000A91 RID: 2705
		SrcAlpha,
		// Token: 0x04000A92 RID: 2706
		OneMinusSrcColor,
		// Token: 0x04000A93 RID: 2707
		DstAlpha,
		// Token: 0x04000A94 RID: 2708
		OneMinusDstAlpha,
		// Token: 0x04000A95 RID: 2709
		SrcAlphaSaturate,
		// Token: 0x04000A96 RID: 2710
		OneMinusSrcAlpha
	}
}
