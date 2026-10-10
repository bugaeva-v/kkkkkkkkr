using System;
using System.Collections.Generic;

namespace Unity.Services.Core.Telemetry.Internal
{
	// Token: 0x02000008 RID: 8
	internal class Metrics : IMetrics
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000020EB File Offset: 0x000002EB
		internal IDictionary<string, string> PackageTags { get; } = new Dictionary<string, string>();

		// Token: 0x06000014 RID: 20 RVA: 0x000020F3 File Offset: 0x000002F3
		void IMetrics.SendGaugeMetric(string name, double value, IDictionary<string, string> tags)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000020F5 File Offset: 0x000002F5
		void IMetrics.SendHistogramMetric(string name, double time, IDictionary<string, string> tags)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020F7 File Offset: 0x000002F7
		void IMetrics.SendSumMetric(string name, double value, IDictionary<string, string> tags)
		{
		}
	}
}
