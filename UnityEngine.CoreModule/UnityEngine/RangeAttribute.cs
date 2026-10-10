using System;

namespace UnityEngine
{
	// Token: 0x020001DC RID: 476
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class RangeAttribute : PropertyAttribute
	{
		// Token: 0x060015E4 RID: 5604 RVA: 0x00023217 File Offset: 0x00021417
		public RangeAttribute(float min, float max)
		{
			this.min = min;
			this.max = max;
		}

		// Token: 0x040007B6 RID: 1974
		public readonly float min;

		// Token: 0x040007B7 RID: 1975
		public readonly float max;
	}
}
