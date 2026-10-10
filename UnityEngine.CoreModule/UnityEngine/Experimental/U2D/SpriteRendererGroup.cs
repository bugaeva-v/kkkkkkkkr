using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.U2D
{
	// Token: 0x02000456 RID: 1110
	[NativeHeader("Runtime/2D/Renderer/SpriteRendererGroup.h")]
	[RequiredByNativeCode]
	[StructLayout(LayoutKind.Sequential)]
	internal class SpriteRendererGroup
	{
		// Token: 0x060027C0 RID: 10176 RVA: 0x00041890 File Offset: 0x0003FA90
		public static void AddRenderers(NativeArray<SpriteIntermediateRendererInfo> renderers)
		{
			SpriteRendererGroup.AddRenderers(renderers.GetUnsafeReadOnlyPtr<SpriteIntermediateRendererInfo>(), renderers.Length);
		}

		// Token: 0x060027C1 RID: 10177
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void AddRenderers(void* renderers, int count);

		// Token: 0x060027C2 RID: 10178
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Clear();
	}
}
