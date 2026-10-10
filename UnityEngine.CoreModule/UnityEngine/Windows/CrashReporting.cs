using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.Windows
{
	// Token: 0x02000289 RID: 649
	public static class CrashReporting
	{
		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001C2E RID: 7214
		public static extern string crashReportFolder { [ThreadSafe] [NativeHeader("PlatformDependent/WinPlayer/Bindings/CrashReportingBindings.h")] [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
