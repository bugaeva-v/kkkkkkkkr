using System;

namespace UnityEngine.Purchasing.Telemetry
{
	// Token: 0x02000117 RID: 279
	internal struct TelemetryMetricParams
	{
		// Token: 0x06000501 RID: 1281 RVA: 0x0000B8E8 File Offset: 0x00009AE8
		internal TelemetryMetricParams(TelemetryMetricTypes metricType, string metricName, double metricTimeSeconds)
		{
			this.type = metricType;
			this.name = metricName;
			this.timeSeconds = metricTimeSeconds;
		}

		// Token: 0x0400024F RID: 591
		internal TelemetryMetricTypes type;

		// Token: 0x04000250 RID: 592
		internal string name;

		// Token: 0x04000251 RID: 593
		internal double timeSeconds;
	}
}
