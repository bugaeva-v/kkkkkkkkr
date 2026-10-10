using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000150 RID: 336
	[NativeHeader("Runtime/Camera/OcclusionPortal.h")]
	public sealed class OcclusionPortal : Component
	{
		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000E1B RID: 3611
		// (set) Token: 0x06000E1C RID: 3612
		[NativeProperty("IsOpen")]
		public extern bool open { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
