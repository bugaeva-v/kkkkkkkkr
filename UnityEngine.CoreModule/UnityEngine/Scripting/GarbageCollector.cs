using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.Scripting
{
	// Token: 0x020002D8 RID: 728
	[NativeHeader("Runtime/Scripting/GarbageCollector.h")]
	public static class GarbageCollector
	{
		// Token: 0x14000027 RID: 39
		// (add) Token: 0x06001DFA RID: 7674 RVA: 0x00030CE0 File Offset: 0x0002EEE0
		// (remove) Token: 0x06001DFB RID: 7675 RVA: 0x00030D14 File Offset: 0x0002EF14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action<GarbageCollector.Mode> GCModeChanged;

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001DFC RID: 7676 RVA: 0x00030D48 File Offset: 0x0002EF48
		// (set) Token: 0x06001DFD RID: 7677 RVA: 0x00030D60 File Offset: 0x0002EF60
		public static GarbageCollector.Mode GCMode
		{
			get
			{
				return GarbageCollector.GetMode();
			}
			set
			{
				bool flag = value == GarbageCollector.GetMode();
				if (!flag)
				{
					GarbageCollector.SetMode(value);
					bool flag2 = GarbageCollector.GCModeChanged != null;
					if (flag2)
					{
						GarbageCollector.GCModeChanged(value);
					}
				}
			}
		}

		// Token: 0x06001DFE RID: 7678
		[NativeThrows]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetMode(GarbageCollector.Mode mode);

		// Token: 0x06001DFF RID: 7679
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern GarbageCollector.Mode GetMode();

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001E00 RID: 7680
		public static extern bool isIncremental { [NativeMethod("GetIncrementalEnabled")] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001E01 RID: 7681
		// (set) Token: 0x06001E02 RID: 7682
		public static extern ulong incrementalTimeSliceNanoseconds { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x06001E03 RID: 7683
		[NativeMethod("CollectIncrementalWrapper")]
		[NativeThrows]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool CollectIncremental(ulong nanoseconds = 0UL);

		// Token: 0x020002D9 RID: 729
		public enum Mode
		{
			// Token: 0x040009D5 RID: 2517
			Disabled,
			// Token: 0x040009D6 RID: 2518
			Enabled,
			// Token: 0x040009D7 RID: 2519
			Manual
		}
	}
}
