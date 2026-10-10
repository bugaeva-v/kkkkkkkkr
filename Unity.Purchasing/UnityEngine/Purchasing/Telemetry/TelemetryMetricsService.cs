using System;

namespace UnityEngine.Purchasing.Telemetry
{
	// Token: 0x02000119 RID: 281
	internal class TelemetryMetricsService : ITelemetryMetricsService
	{
		// Token: 0x06000508 RID: 1288 RVA: 0x0000BA7D File Offset: 0x00009C7D
		public TelemetryMetricsService(ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper)
		{
			this.m_TelemetryMetricsInstanceWrapper = telemetryMetricsInstanceWrapper;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0000BA8C File Offset: 0x00009C8C
		public void ExecuteTimedAction(Action timedAction, TelemetryMetricDefinition metricDefinition)
		{
			ITelemetryMetricEvent telemetryMetricEvent = this.CreateAndStartMetricEvent(metricDefinition);
			timedAction();
			try
			{
				telemetryMetricEvent.StopAndSendMetric();
			}
			catch (IapTelemetryException ex)
			{
				Debug.unityLogger.LogIAPError("An exception occured while sending a metric: " + ex.Message);
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0000BADC File Offset: 0x00009CDC
		public ITelemetryMetricEvent CreateAndStartMetricEvent(TelemetryMetricDefinition metricDefinition)
		{
			ITelemetryMetricEvent telemetryMetricEvent = new TelemetryMetricEvent(this.m_TelemetryMetricsInstanceWrapper, metricDefinition.MetricType, metricDefinition.MetricName);
			try
			{
				telemetryMetricEvent.StartMetric();
			}
			catch (IapTelemetryException ex)
			{
				Debug.unityLogger.LogIAPError("An exception occured while starting a metric: " + ex.Message);
			}
			return telemetryMetricEvent;
		}

		// Token: 0x04000256 RID: 598
		private readonly ITelemetryMetricsInstanceWrapper m_TelemetryMetricsInstanceWrapper;
	}
}
