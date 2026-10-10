using System;
using System.Diagnostics;

namespace UnityEngine.Purchasing.Telemetry
{
	// Token: 0x02000116 RID: 278
	internal class TelemetryMetricEvent : ITelemetryMetricEvent
	{
		// Token: 0x060004FE RID: 1278 RVA: 0x0000B82E File Offset: 0x00009A2E
		internal TelemetryMetricEvent(ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper, TelemetryMetricTypes metricType, string metricName)
		{
			this.m_TelemetryMetricsInstanceWrapper = telemetryMetricsInstanceWrapper;
			this.m_MetricType = metricType;
			this.m_MetricName = metricName;
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0000B856 File Offset: 0x00009A56
		public void StartMetric()
		{
			if (this.m_Stopwatch == null)
			{
				throw new IapTelemetryException("Metric was already sent.");
			}
			if (!this.m_Stopwatch.IsRunning)
			{
				this.m_Stopwatch.Start();
				return;
			}
			throw new IapTelemetryException("Metric was already started.");
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0000B890 File Offset: 0x00009A90
		public void StopAndSendMetric()
		{
			if (this.m_Stopwatch != null)
			{
				ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper = this.m_TelemetryMetricsInstanceWrapper;
				if (telemetryMetricsInstanceWrapper != null)
				{
					telemetryMetricsInstanceWrapper.SendMetric(this.m_MetricType, this.m_MetricName, (double)this.m_Stopwatch.Elapsed.Seconds);
				}
				this.m_Stopwatch = null;
				return;
			}
			throw new IapTelemetryException("Metric was already sent.");
		}

		// Token: 0x0400024B RID: 587
		private readonly ITelemetryMetricsInstanceWrapper m_TelemetryMetricsInstanceWrapper;

		// Token: 0x0400024C RID: 588
		private readonly TelemetryMetricTypes m_MetricType;

		// Token: 0x0400024D RID: 589
		private readonly string m_MetricName;

		// Token: 0x0400024E RID: 590
		private Stopwatch m_Stopwatch = new Stopwatch();
	}
}
