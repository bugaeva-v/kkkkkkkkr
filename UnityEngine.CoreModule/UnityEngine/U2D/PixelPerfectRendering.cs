using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D
{
	// Token: 0x02000272 RID: 626
	[NativeHeader("Runtime/2D/Common/PixelSnapping.h")]
	[MovedFrom("UnityEngine.Experimental.U2D")]
	public static class PixelPerfectRendering
	{
		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001B25 RID: 6949
		// (set) Token: 0x06001B26 RID: 6950
		public static extern float pixelSnapSpacing { [FreeFunction("GetPixelSnapSpacing")] [MethodImpl(MethodImplOptions.InternalCall)] get; [FreeFunction("SetPixelSnapSpacing")] [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
