using System;
using Unity.Services.Core.Telemetry.Internal;

namespace UnityEngine.Purchasing.Telemetry
{
	// Token: 0x0200010B RID: 267
	internal interface ITelemetryDiagnosticsInstanceWrapper
	{
		// Token: 0x060004E6 RID: 1254
		void SetDiagnosticsInstance(IDiagnostics diagnosticsInstance);

		// Token: 0x060004E7 RID: 1255
		void SendDiagnostic(string diagnosticName, string diagnosticException);
	}
}
