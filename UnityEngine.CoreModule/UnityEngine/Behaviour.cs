using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001FC RID: 508
	[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
	[UsedByNativeCode]
	public class Behaviour : Component
	{
		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001678 RID: 5752
		// (set) Token: 0x06001679 RID: 5753
		[NativeProperty]
		[RequiredByNativeCode]
		public extern bool enabled { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x0600167A RID: 5754
		[NativeProperty]
		public extern bool isActiveAndEnabled { [NativeMethod("IsAddedToManager")] [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
