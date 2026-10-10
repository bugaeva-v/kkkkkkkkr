using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000259 RID: 601
	[NativeHeader("Runtime/Profiler/PerformanceTools/FrameDebugger.h")]
	[StaticAccessor("FrameDebugger", StaticAccessorType.DoubleColon)]
	public static class FrameDebugger
	{
		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001A05 RID: 6661 RVA: 0x0002A216 File Offset: 0x00028416
		public static bool enabled
		{
			get
			{
				return FrameDebugger.IsLocalEnabled() || FrameDebugger.IsRemoteEnabled();
			}
		}

		// Token: 0x06001A06 RID: 6662
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool IsLocalEnabled();

		// Token: 0x06001A07 RID: 6663
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool IsRemoteEnabled();
	}
}
