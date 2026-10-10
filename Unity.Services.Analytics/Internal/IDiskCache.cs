using System;
using System.Collections.Generic;
using System.IO;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x02000030 RID: 48
	internal interface IDiskCache
	{
		// Token: 0x06000150 RID: 336
		void Clear();

		// Token: 0x06000151 RID: 337
		void Write(List<EventSummary> eventSummaries, Stream payload);

		// Token: 0x06000152 RID: 338
		bool Read(List<EventSummary> eventSummaries, Stream buffer);
	}
}
