using System;

namespace UnityEngine.Purchasing.Telemetry
{
	// Token: 0x02000113 RID: 275
	internal interface ITelemetryMetricsService
	{
		// Token: 0x060004F7 RID: 1271
		void ExecuteTimedAction(Action timedAction, TelemetryMetricDefinition metricDefinition);

		// Token: 0x060004F8 RID: 1272
		ITelemetryMetricEvent CreateAndStartMetricEvent(TelemetryMetricDefinition metricDefinition);
	}
}
