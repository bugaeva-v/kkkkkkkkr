using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000178 RID: 376
	[NativeHeader("Runtime/Graphics/ColorGamut.h")]
	[UsedByNativeCode]
	public enum ColorGamut
	{
		// Token: 0x040004C9 RID: 1225
		sRGB,
		// Token: 0x040004CA RID: 1226
		Rec709,
		// Token: 0x040004CB RID: 1227
		Rec2020,
		// Token: 0x040004CC RID: 1228
		DisplayP3,
		// Token: 0x040004CD RID: 1229
		HDR10,
		// Token: 0x040004CE RID: 1230
		DolbyHDR
	}
}
