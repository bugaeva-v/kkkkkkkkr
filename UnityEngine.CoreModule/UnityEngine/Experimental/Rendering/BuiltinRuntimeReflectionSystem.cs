using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000470 RID: 1136
	[NativeHeader("Runtime/Camera/ReflectionProbes.h")]
	internal class BuiltinRuntimeReflectionSystem : IScriptableRuntimeReflectionSystem, IDisposable
	{
		// Token: 0x0600282B RID: 10283 RVA: 0x00042F00 File Offset: 0x00041100
		public bool TickRealtimeProbes()
		{
			return BuiltinRuntimeReflectionSystem.BuiltinUpdate();
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x00042F17 File Offset: 0x00041117
		public void Dispose()
		{
			this.Dispose(true);
		}

		// Token: 0x0600282D RID: 10285 RVA: 0x00004563 File Offset: 0x00002763
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x0600282E RID: 10286
		[StaticAccessor("GetReflectionProbes()", Type = StaticAccessorType.Dot)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool BuiltinUpdate();

		// Token: 0x0600282F RID: 10287 RVA: 0x00042F24 File Offset: 0x00041124
		[RequiredByNativeCode]
		private static BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New()
		{
			return new BuiltinRuntimeReflectionSystem();
		}
	}
}
