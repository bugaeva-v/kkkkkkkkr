using System;

namespace UnityEngine.Purchasing.Telemetry
{
	// Token: 0x0200010A RID: 266
	internal interface ITelemetryDiagnostics
	{
		// Token: 0x060004E5 RID: 1253
		void SendDiagnostic(string diagnosticName, Exception e);
	}
}
