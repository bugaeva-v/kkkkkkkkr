using System;
using Uniject;
using Unity.Services.Core.Telemetry.Internal;

namespace UnityEngine.Purchasing.Telemetry
{
	// Token: 0x0200010F RID: 271
	internal class TelemetryDiagnosticsInstanceWrapper : ITelemetryDiagnosticsInstanceWrapper
	{
		// Token: 0x060004EB RID: 1259 RVA: 0x0000B5EC File Offset: 0x000097EC
		internal TelemetryDiagnosticsInstanceWrapper(ILogger logger, IUtil util)
		{
			this.m_Logger = logger;
			this.m_Util = util;
			this.m_Queue = new TelemetryQueue<TelemetryDiagnosticParams>(new Action<TelemetryDiagnosticParams>(this.SendDiagnosticOnMainThread));
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0000B619 File Offset: 0x00009819
		public void SetDiagnosticsInstance(IDiagnostics diagnosticsInstance)
		{
			this.m_Instance = diagnosticsInstance;
			this.m_Queue.SendQueuedEvents();
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0000B630 File Offset: 0x00009830
		public void SendDiagnostic(string diagnosticName, string diagnosticException)
		{
			TelemetryDiagnosticParams telemetryDiagnosticParams = new TelemetryDiagnosticParams(diagnosticName, diagnosticException);
			if (this.m_Instance != null)
			{
				this.SendDiagnosticOnMainThread(telemetryDiagnosticParams);
				return;
			}
			this.m_Queue.QueueEvent(telemetryDiagnosticParams);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0000B664 File Offset: 0x00009864
		private void SendDiagnosticOnMainThread(TelemetryDiagnosticParams diagnosticParams)
		{
			this.m_Util.RunOnMainThread(delegate
			{
				this.SendDiagnosticAndCatchExceptions(diagnosticParams);
			});
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0000B69C File Offset: 0x0000989C
		private void SendDiagnosticAndCatchExceptions(TelemetryDiagnosticParams diagnosticParams)
		{
			try
			{
				this.m_Instance.SendDiagnostic(diagnosticParams.name, diagnosticParams.exception, null);
			}
			catch (Exception ex)
			{
				this.m_Logger.LogIAPError("An exception occurred when sending diagnostic " + diagnosticParams.name + ". Message: " + ex.Message);
			}
		}

		// Token: 0x04000236 RID: 566
		private IDiagnostics m_Instance;

		// Token: 0x04000237 RID: 567
		private ILogger m_Logger;

		// Token: 0x04000238 RID: 568
		private IUtil m_Util;

		// Token: 0x04000239 RID: 569
		private readonly TelemetryQueue<TelemetryDiagnosticParams> m_Queue;
	}
}
