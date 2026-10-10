using System;
using UnityEngine;

namespace DG.DemiLib
{
	// Token: 0x02000009 RID: 9
	[Serializable]
	public struct Range
	{
		// Token: 0x06000018 RID: 24 RVA: 0x000025C3 File Offset: 0x000007C3
		public Range(float min, float max)
		{
			this.min = min;
			this.max = max;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000025D4 File Offset: 0x000007D4
		public float RandomWithin()
		{
			float maxInclusive = this.max - this.min;
			return this.min + Random.Range(0f, maxInclusive);
		}

		// Token: 0x04000018 RID: 24
		public float min;

		// Token: 0x04000019 RID: 25
		public float max;
	}
}
