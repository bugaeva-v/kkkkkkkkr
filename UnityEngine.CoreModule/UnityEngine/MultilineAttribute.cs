using System;

namespace UnityEngine
{
	// Token: 0x020001DE RID: 478
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class MultilineAttribute : PropertyAttribute
	{
		// Token: 0x060015E6 RID: 5606 RVA: 0x00023240 File Offset: 0x00021440
		public MultilineAttribute()
		{
			this.lines = 3;
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00023251 File Offset: 0x00021451
		public MultilineAttribute(int lines)
		{
			this.lines = lines;
		}

		// Token: 0x040007B9 RID: 1977
		public readonly int lines;
	}
}
