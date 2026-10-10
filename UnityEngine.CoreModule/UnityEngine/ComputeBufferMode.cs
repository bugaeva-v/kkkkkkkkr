using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200012D RID: 301
	[NativeType("Runtime/GfxDevice/GfxDeviceTypes.h")]
	public enum ComputeBufferMode
	{
		// Token: 0x040003C7 RID: 967
		Immutable,
		// Token: 0x040003C8 RID: 968
		Dynamic,
		// Token: 0x040003C9 RID: 969
		[Obsolete("ComputeBufferMode.Circular is deprecated (legacy mode)")]
		Circular,
		// Token: 0x040003CA RID: 970
		[Obsolete("ComputeBufferMode.StreamOut is deprecated (internal use only)")]
		StreamOut,
		// Token: 0x040003CB RID: 971
		SubUpdates
	}
}
