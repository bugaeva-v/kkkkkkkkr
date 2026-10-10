using System;
using Uniject;
using Unity.Services.Core.Telemetry.Internal;

namespace UnityEngine.Purchasing.Telemetry
{
	// Token: 0x02000118 RID: 280
	internal class TelemetryMetricsInstanceWrapper : ITelemetryMetricsInstanceWrapper
	{
		// Token: 0x06000502 RID: 1282 RVA: 0x0000B8FF File Offset: 0x00009AFF
		internal TelemetryMetricsInstanceWrapper(ILogger logger, IUtil util)
		{
			this.m_Logger = logger;
			this.m_Util = util;
			this.m_Queue = new TelemetryQueue<TelemetryMetricParams>(new Action<TelemetryMetricParams>(this.SendMetricOnMainThread));
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0000B92C File Offset: 0x00009B2C
		public void SetMetricsInstance(IMetrics metricsInstance)
		{
			this.m_Instance = metricsInstance;
			if (this.m_Instance != null)
			{
				this.m_Queue.SendQueuedEvents();
			}
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0000B948 File Offset: 0x00009B48
		public void SendMetric(TelemetryMetricTypes metricType, string metricName, double metricTimeSeconds)
		{
			TelemetryMetricParams telemetryMetricParams = new TelemetryMetricParams(metricType, metricName, metricTimeSeconds);
			if (this.m_Instance != null)
			{
				this.SendMetricOnMainThread(telemetryMetricParams);
				return;
			}
			this.m_Queue.QueueEvent(telemetryMetricParams);
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0000B97C File Offset: 0x00009B7C
		private void SendMetricOnMainThread(TelemetryMetricParams metricParams)
		{
			this.m_Util.RunOnMainThread(delegate
			{
				this.SendMetricByTypeAndCatchExceptions(metricParams);
			});
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0000B9B4 File Offset: 0x00009BB4
		private void SendMetricByTypeAndCatchExceptions(TelemetryMetricParams metricParams)
		{
			try
			{
				this.SendMetricByType(metricParams);
			}
			catch (Exception ex)
			{
				this.m_Logger.LogIAPError(string.Format("An exception occurred when sending metric {0} of type {1}. Message: {2}", metricParams.name, metricParams.type, ex.Message));
			}
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0000BA0C File Offset: 0x00009C0C
		private void SendMetricByType(TelemetryMetricParams metricParams)
		{
			switch (metricParams.type)
			{
			case TelemetryMetricTypes.Gauge:
				this.m_Instance.SendGaugeMetric(metricParams.name, metricParams.timeSeconds, null);
				return;
			case TelemetryMetricTypes.Sum:
				this.m_Instance.SendSumMetric(metricParams.name, metricParams.timeSeconds, null);
				return;
			case TelemetryMetricTypes.Histogram:
				this.m_Instance.SendHistogramMetric(metricParams.name, metricParams.timeSeconds, null);
				return;
			default:
				return;
			}
		}

		// Token: 0x04000252 RID: 594
		private IMetrics m_Instance;

		// Token: 0x04000253 RID: 595
		private ILogger m_Logger;

		// Token: 0x04000254 RID: 596
		private IUtil m_Util;

		// Token: 0x04000255 RID: 597
		private readonly TelemetryQueue<TelemetryMetricParams> m_Queue;
	}
}
