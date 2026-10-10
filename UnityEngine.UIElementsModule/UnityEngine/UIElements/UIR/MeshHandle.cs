using System;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000335 RID: 821
	internal class MeshHandle : LinkedPoolItem<MeshHandle>
	{
		// Token: 0x04000C61 RID: 3169
		internal Alloc allocVerts;

		// Token: 0x04000C62 RID: 3170
		internal Alloc allocIndices;

		// Token: 0x04000C63 RID: 3171
		internal uint triangleCount;

		// Token: 0x04000C64 RID: 3172
		internal Page allocPage;

		// Token: 0x04000C65 RID: 3173
		internal uint allocTime;

		// Token: 0x04000C66 RID: 3174
		internal uint updateAllocID;
	}
}
