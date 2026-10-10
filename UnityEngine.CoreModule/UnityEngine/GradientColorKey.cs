using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001C1 RID: 449
	[UsedByNativeCode]
	public struct GradientColorKey
	{
		// Token: 0x060013BD RID: 5053 RVA: 0x0001C6FD File Offset: 0x0001A8FD
		public GradientColorKey(Color col, float time)
		{
			this.color = col;
			this.time = time;
		}

		// Token: 0x04000745 RID: 1861
		public Color color;

		// Token: 0x04000746 RID: 1862
		public float time;
	}
}
