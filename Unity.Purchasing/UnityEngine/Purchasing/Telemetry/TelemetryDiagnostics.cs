using System;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.Telemetry
{
	// Token: 0x0200010E RID: 270
	internal class TelemetryDiagnostics : ITelemetryDiagnostics
	{
		// Token: 0x060004E9 RID: 1257 RVA: 0x0000B58B File Offset: 0x0000978B
		[Preserve]
		internal TelemetryDiagnostics(ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper)
		{
			this.m_TelemetryDiagnosticsInstanceWrapper = telemetryDiagnosticsInstanceWrapper;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0000B59C File Offset: 0x0000979C
		public void SendDiagnostic(string diagnosticName, Exception e)
		{
			try
			{
				this.m_TelemetryDiagnosticsInstanceWrapper.SendDiagnostic(diagnosticName, e.ToString());
			}
			catch (IapTelemetryException ex)
			{
				Debug.unityLogger.LogIAPError("An exception occured while sending a diagnostic: " + ex.Message);
			}
		}

		// Token: 0x04000235 RID: 565
		private readonly ITelemetryDiagnosticsInstanceWrapper m_TelemetryDiagnosticsInstanceWrapper;
	}
}
