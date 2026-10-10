using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000063 RID: 99
	public class TimeSpanUnits
	{
		// Token: 0x060001BA RID: 442 RVA: 0x00004997 File Offset: 0x00002B97
		public TimeSpanUnits(double d, int m, int y)
		{
			this.days = d;
			this.months = m;
			this.years = y;
		}

		// Token: 0x04000086 RID: 134
		public double days;

		// Token: 0x04000087 RID: 135
		public int months;

		// Token: 0x04000088 RID: 136
		public int years;
	}
}
