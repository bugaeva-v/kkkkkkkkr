using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x0200047F RID: 1151
	[Flags]
	[NativeHeader("Runtime/Export/Graphics/RayTracingAccelerationStructure.bindings.h")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Shaders/RayTracingAccelerationStructure.h")]
	public enum RayTracingSubMeshFlags
	{
		// Token: 0x04000F8A RID: 3978
		Disabled = 0,
		// Token: 0x04000F8B RID: 3979
		Enabled = 1,
		// Token: 0x04000F8C RID: 3980
		ClosestHitOnly = 2,
		// Token: 0x04000F8D RID: 3981
		UniqueAnyHitCalls = 4
	}
}
