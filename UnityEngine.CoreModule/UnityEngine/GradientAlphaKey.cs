using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020001C2 RID: 450
	[UsedByNativeCode]
	public struct GradientAlphaKey
	{
		// Token: 0x060013BE RID: 5054 RVA: 0x0001C70E File Offset: 0x0001A90E
		public GradientAlphaKey(float alpha, float time)
		{
			this.alpha = alpha;
			this.time = time;
		}

		// Token: 0x04000747 RID: 1863
		public float alpha;

		// Token: 0x04000748 RID: 1864
		public float time;
	}
}
