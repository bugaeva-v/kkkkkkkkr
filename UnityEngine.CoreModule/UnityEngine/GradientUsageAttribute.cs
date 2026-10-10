using System;

namespace UnityEngine
{
	// Token: 0x020001E1 RID: 481
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class GradientUsageAttribute : PropertyAttribute
	{
		// Token: 0x060015ED RID: 5613 RVA: 0x000233C8 File Offset: 0x000215C8
		public GradientUsageAttribute(bool hdr)
		{
			this.hdr = hdr;
			this.colorSpace = ColorSpace.Gamma;
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x000233EE File Offset: 0x000215EE
		public GradientUsageAttribute(bool hdr, ColorSpace colorSpace)
		{
			this.hdr = hdr;
			this.colorSpace = colorSpace;
		}

		// Token: 0x040007C2 RID: 1986
		public readonly bool hdr = false;

		// Token: 0x040007C3 RID: 1987
		public readonly ColorSpace colorSpace = ColorSpace.Gamma;
	}
}
