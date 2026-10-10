using System;
using System.Collections.Generic;

namespace Unity.Services.Core.Telemetry.Internal
{
	// Token: 0x02000006 RID: 6
	internal class DisabledMetrics : IMetrics
	{
		// Token: 0x0600000C RID: 12 RVA: 0x000020BB File Offset: 0x000002BB
		void IMetrics.SendGaugeMetric(string name, double value, IDictionary<string, string> tags)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020BD File Offset: 0x000002BD
		void IMetrics.SendHistogramMetric(string name, double time, IDictionary<string, string> tags)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020BF File Offset: 0x000002BF
		void IMetrics.SendSumMetric(string name, double value, IDictionary<string, string> tags)
		{
		}
	}
}
