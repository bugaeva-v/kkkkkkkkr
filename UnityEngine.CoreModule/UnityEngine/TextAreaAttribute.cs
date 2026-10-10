using System;

namespace UnityEngine
{
	// Token: 0x020001DF RID: 479
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class TextAreaAttribute : PropertyAttribute
	{
		// Token: 0x060015E8 RID: 5608 RVA: 0x00023262 File Offset: 0x00021462
		public TextAreaAttribute()
		{
			this.minLines = 3;
			this.maxLines = 3;
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x0002327A File Offset: 0x0002147A
		public TextAreaAttribute(int minLines, int maxLines)
		{
			this.minLines = minLines;
			this.maxLines = maxLines;
		}

		// Token: 0x040007BA RID: 1978
		public readonly int minLines;

		// Token: 0x040007BB RID: 1979
		public readonly int maxLines;
	}
}
