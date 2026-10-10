using System;

namespace UnityEngine.Purchasing.Telemetry
{
	// Token: 0x02000111 RID: 273
	internal interface ITelemetryMetricEvent
	{
		// Token: 0x060004F3 RID: 1267
		void StartMetric();

		// Token: 0x060004F4 RID: 1268
		void StopAndSendMetric();
	}
}
