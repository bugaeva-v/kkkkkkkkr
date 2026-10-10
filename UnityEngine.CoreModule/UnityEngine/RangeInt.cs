using System;

namespace UnityEngine
{
	// Token: 0x02000212 RID: 530
	public struct RangeInt
	{
		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06001756 RID: 5974 RVA: 0x0002588C File Offset: 0x00023A8C
		public int end
		{
			get
			{
				return this.start + this.length;
			}
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x000258AB File Offset: 0x00023AAB
		public RangeInt(int start, int length)
		{
			this.start = start;
			this.length = length;
		}

		// Token: 0x040007FD RID: 2045
		public int start;

		// Token: 0x040007FE RID: 2046
		public int length;
	}
}
