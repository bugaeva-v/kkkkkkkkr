using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000130 RID: 304
	[NativeHeader("Runtime/GfxDevice/ScalableBufferManager.h")]
	[StaticAccessor("ScalableBufferManager::GetInstance()", StaticAccessorType.Dot)]
	public static class ScalableBufferManager
	{
		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x0600098F RID: 2447
		public static extern float widthScaleFactor { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000990 RID: 2448
		public static extern float heightScaleFactor { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000991 RID: 2449
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResizeBuffers(float widthScale, float heightScale);
	}
}
