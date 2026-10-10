using System;

namespace Firebase.Platform
{
	// Token: 0x02000008 RID: 8
	internal interface IClockService
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600002E RID: 46
		DateTime Now { get; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002F RID: 47
		DateTime UtcNow { get; }
	}
}
