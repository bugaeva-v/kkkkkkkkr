using System;
using System.Collections.Generic;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x02000037 RID: 55
	internal interface IBufferDebug
	{
		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000177 RID: 375
		// (remove) Token: 0x06000178 RID: 376
		event Action<string, string, DateTime, byte[]> EventRecorded;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000179 RID: 377
		// (remove) Token: 0x0600017A RID: 378
		event Action<HashSet<string>> EventsClearing;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x0600017B RID: 379
		// (remove) Token: 0x0600017C RID: 380
		event Action<HashSet<string>> EventsCleared;
	}
}
