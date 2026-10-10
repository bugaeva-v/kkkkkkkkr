using System;
using System.Collections.Generic;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Telemetry.Internal
{
	// Token: 0x02000007 RID: 7
	internal class DisabledMetricsFactory : IMetricsFactory, IServiceComponent
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000020C9 File Offset: 0x000002C9
		IReadOnlyDictionary<string, string> IMetricsFactory.CommonTags { get; } = new Dictionary<string, string>();

		// Token: 0x06000011 RID: 17 RVA: 0x000020D1 File Offset: 0x000002D1
		IMetrics IMetricsFactory.Create(string packageName)
		{
			return new DisabledMetrics();
		}
	}
}
