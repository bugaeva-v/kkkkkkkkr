using System;
using System.Collections.Generic;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Telemetry.Internal
{
	// Token: 0x02000017 RID: 23
	public interface IMetricsFactory : IServiceComponent
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002D RID: 45
		IReadOnlyDictionary<string, string> CommonTags { get; }

		// Token: 0x0600002E RID: 46
		IMetrics Create(string packageName);
	}
}
