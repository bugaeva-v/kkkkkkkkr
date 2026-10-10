using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000200 RID: 512
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Mono/Coroutine.h")]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class Coroutine : YieldInstruction
	{
		// Token: 0x060016AD RID: 5805 RVA: 0x00024418 File Offset: 0x00022618
		private Coroutine()
		{
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x00024424 File Offset: 0x00022624
		~Coroutine()
		{
			Coroutine.ReleaseCoroutine(this.m_Ptr);
		}

		// Token: 0x060016AF RID: 5807
		[FreeFunction("Coroutine::CleanupCoroutineGC", true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void ReleaseCoroutine(IntPtr ptr);

		// Token: 0x040007E1 RID: 2017
		internal IntPtr m_Ptr;
	}
}
