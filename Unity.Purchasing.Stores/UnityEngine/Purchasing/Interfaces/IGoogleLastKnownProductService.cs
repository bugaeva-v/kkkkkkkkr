using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing.Interfaces
{
	// Token: 0x02000059 RID: 89
	[NullableContext(2)]
	internal interface IGoogleLastKnownProductService
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600022F RID: 559
		// (set) Token: 0x06000230 RID: 560
		string LastKnownOldProductId { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000231 RID: 561
		// (set) Token: 0x06000232 RID: 562
		string LastKnownProductId { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000233 RID: 563
		// (set) Token: 0x06000234 RID: 564
		GooglePlayReplacementMode? LastKnownReplacementMode { get; set; }
	}
}
