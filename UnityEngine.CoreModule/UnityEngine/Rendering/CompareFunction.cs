using System;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	// Token: 0x020003B0 RID: 944
	[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
	public enum CompareFunction
	{
		// Token: 0x04000ABD RID: 2749
		Disabled,
		// Token: 0x04000ABE RID: 2750
		Never,
		// Token: 0x04000ABF RID: 2751
		Less,
		// Token: 0x04000AC0 RID: 2752
		Equal,
		// Token: 0x04000AC1 RID: 2753
		LessEqual,
		// Token: 0x04000AC2 RID: 2754
		Greater,
		// Token: 0x04000AC3 RID: 2755
		NotEqual,
		// Token: 0x04000AC4 RID: 2756
		GreaterEqual,
		// Token: 0x04000AC5 RID: 2757
		Always
	}
}
