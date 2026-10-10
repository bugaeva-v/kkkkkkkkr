using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000469 RID: 1129
	[StaticAccessor("GetRenderSettings()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/Camera/RenderSettings.h")]
	public class RenderSettings
	{
		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x060027F5 RID: 10229
		// (set) Token: 0x060027F6 RID: 10230
		public static extern bool useRadianceAmbientProbe { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
