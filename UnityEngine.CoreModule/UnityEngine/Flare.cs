using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000152 RID: 338
	[NativeHeader("Runtime/Camera/Flare.h")]
	public sealed class Flare : Object
	{
		// Token: 0x06000E27 RID: 3623 RVA: 0x00012B90 File Offset: 0x00010D90
		public Flare()
		{
			Flare.Internal_Create(this);
		}

		// Token: 0x06000E28 RID: 3624
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Create([Writable] Flare self);
	}
}
