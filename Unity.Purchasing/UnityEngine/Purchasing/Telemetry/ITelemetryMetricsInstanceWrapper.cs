using System;
using Unity.Services.Core.Telemetry.Internal;

namespace UnityEngine.Purchasing.Telemetry
{
	// Token: 0x02000112 RID: 274
	internal interface ITelemetryMetricsInstanceWrapper
	{
		// Token: 0x060004F5 RID: 1269
		void SetMetricsInstance(IMetrics metricsInstance);

		// Token: 0x060004F6 RID: 1270
		void SendMetric(TelemetryMetricTypes telemetryMetricTypes, string metricName, double metricTimeSeconds);
	}
}
