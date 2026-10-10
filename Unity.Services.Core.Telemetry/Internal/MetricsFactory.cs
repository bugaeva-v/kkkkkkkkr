using System;
using System.Collections.Generic;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Telemetry.Internal
{
	// Token: 0x02000009 RID: 9
	internal class MetricsFactory : IMetricsFactory, IServiceComponent
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000018 RID: 24 RVA: 0x0000210C File Offset: 0x0000030C
		public IReadOnlyDictionary<string, string> CommonTags { get; } = new Dictionary<string, string>();

		// Token: 0x06000019 RID: 25 RVA: 0x00002114 File Offset: 0x00000314
		public IMetrics Create(string packageName)
		{
			return new Metrics();
		}
	}
}
