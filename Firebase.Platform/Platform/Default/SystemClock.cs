using System;

namespace Firebase.Platform.Default
{
	// Token: 0x02000017 RID: 23
	internal class SystemClock : IClockService
	{
		// Token: 0x0600009C RID: 156 RVA: 0x000035EF File Offset: 0x000017EF
		protected SystemClock()
		{
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00003918 File Offset: 0x00001B18
		public DateTime Now
		{
			get
			{
				return DateTime.Now;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00003930 File Offset: 0x00001B30
		public DateTime UtcNow
		{
			get
			{
				return DateTime.UtcNow;
			}
		}

		// Token: 0x0400002B RID: 43
		public static readonly IClockService Instance = new SystemClock();
	}
}
