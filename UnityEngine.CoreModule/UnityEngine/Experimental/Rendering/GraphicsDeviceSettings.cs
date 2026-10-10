using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000478 RID: 1144
	public static class GraphicsDeviceSettings
	{
		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06002844 RID: 10308
		// (set) Token: 0x06002845 RID: 10309
		[StaticAccessor("GetGfxDevice()", StaticAccessorType.Dot)]
		public static extern WaitForPresentSyncPoint waitForPresentSyncPoint { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06002846 RID: 10310
		// (set) Token: 0x06002847 RID: 10311
		[StaticAccessor("GetGfxDevice()", StaticAccessorType.Dot)]
		public static extern GraphicsJobsSyncPoint graphicsJobsSyncPoint { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }
	}
}
