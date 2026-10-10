using System;

namespace UnityEngine.Purchasing.Telemetry
{
	// Token: 0x0200010D RID: 269
	internal struct TelemetryDiagnosticParams
	{
		// Token: 0x060004E8 RID: 1256 RVA: 0x0000B57B File Offset: 0x0000977B
		internal TelemetryDiagnosticParams(string diagnosticName, string diagnosticException)
		{
			this.name = diagnosticName;
			this.exception = diagnosticException;
		}

		// Token: 0x04000233 RID: 563
		internal string name;

		// Token: 0x04000234 RID: 564
		internal string exception;
	}
}
