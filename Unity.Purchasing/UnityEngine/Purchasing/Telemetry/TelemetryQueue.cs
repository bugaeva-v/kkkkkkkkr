using System;
using System.Collections.Concurrent;

namespace UnityEngine.Purchasing.Telemetry
{
	// Token: 0x0200011B RID: 283
	internal class TelemetryQueue<TTelemetryEventParams>
	{
		// Token: 0x0600050B RID: 1291 RVA: 0x0000BB3C File Offset: 0x00009D3C
		public TelemetryQueue(Action<TTelemetryEventParams> sendTelemetryEvent)
		{
			this.m_SendTelemetryEvent = sendTelemetryEvent;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0000BB4C File Offset: 0x00009D4C
		internal void QueueEvent(TTelemetryEventParams telemetryEvent)
		{
			if (this.m_Queue == null)
			{
				this.m_Queue = new ConcurrentQueue<TTelemetryEventParams>();
			}
			this.m_Queue.Enqueue(telemetryEvent);
			if (this.m_Queue.Count > 10)
			{
				TTelemetryEventParams ttelemetryEventParams;
				this.m_Queue.TryDequeue(out ttelemetryEventParams);
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0000BB98 File Offset: 0x00009D98
		internal void SendQueuedEvents()
		{
			if (this.m_SendTelemetryEvent == null || this.m_Queue == null)
			{
				return;
			}
			TTelemetryEventParams obj;
			while (this.m_Queue.TryDequeue(out obj))
			{
				this.m_SendTelemetryEvent(obj);
			}
		}

		// Token: 0x0400025B RID: 603
		private readonly Action<TTelemetryEventParams> m_SendTelemetryEvent;

		// Token: 0x0400025C RID: 604
		private ConcurrentQueue<TTelemetryEventParams> m_Queue;

		// Token: 0x0400025D RID: 605
		internal const int k_maxQueueSize = 10;
	}
}
