using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.Diagnostics
{
	// Token: 0x02000450 RID: 1104
	[NativeHeader("Runtime/Export/Diagnostics/DiagnosticsUtils.bindings.h")]
	public static class Utils
	{
		// Token: 0x060026F5 RID: 9973
		[FreeFunction("DiagnosticsUtils_Bindings::ForceCrash", ThrowsException = true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ForceCrash(ForcedCrashCategory crashCategory);

		// Token: 0x060026F6 RID: 9974
		[FreeFunction("DiagnosticsUtils_Bindings::NativeAssert")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NativeAssert(string message);

		// Token: 0x060026F7 RID: 9975
		[FreeFunction("DiagnosticsUtils_Bindings::NativeError")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NativeError(string message);

		// Token: 0x060026F8 RID: 9976
		[FreeFunction("DiagnosticsUtils_Bindings::NativeWarning")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NativeWarning(string message);
	}
}
