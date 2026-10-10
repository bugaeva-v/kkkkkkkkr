using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.LowLevel
{
	// Token: 0x020002ED RID: 749
	[RequiredByNativeCode]
	[NativeType(Header = "Runtime/Misc/PlayerLoop.h")]
	[MovedFrom("UnityEngine.Experimental.LowLevel")]
	internal struct PlayerLoopSystemInternal
	{
		// Token: 0x040009F9 RID: 2553
		public Type type;

		// Token: 0x040009FA RID: 2554
		public PlayerLoopSystem.UpdateFunction updateDelegate;

		// Token: 0x040009FB RID: 2555
		public IntPtr updateFunction;

		// Token: 0x040009FC RID: 2556
		public IntPtr loopConditionFunction;

		// Token: 0x040009FD RID: 2557
		public int numSubSystems;
	}
}
