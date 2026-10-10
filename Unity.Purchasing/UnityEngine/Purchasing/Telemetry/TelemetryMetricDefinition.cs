using System;

namespace UnityEngine.Purchasing.Telemetry
{
	// Token: 0x02000114 RID: 276
	internal struct TelemetryMetricDefinition
	{
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x0000B717 File Offset: 0x00009917
		public readonly TelemetryMetricTypes MetricType { get; }

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x0000B71F File Offset: 0x0000991F
		public readonly string MetricName { get; }

		// Token: 0x060004FB RID: 1275 RVA: 0x0000B727 File Offset: 0x00009927
		public TelemetryMetricDefinition(string metricName, TelemetryMetricTypes metricType = TelemetryMetricTypes.Histogram)
		{
			this.MetricName = metricName;
			this.MetricType = metricType;
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0000B737 File Offset: 0x00009937
		public static implicit operator TelemetryMetricDefinition(string name)
		{
			return new TelemetryMetricDefinition(name, TelemetryMetricTypes.Histogram);
		}
	}
}
