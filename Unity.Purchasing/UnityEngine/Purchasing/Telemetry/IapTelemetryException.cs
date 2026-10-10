using System;

namespace UnityEngine.Purchasing.Telemetry
{
	// Token: 0x02000110 RID: 272
	internal class IapTelemetryException : Exception
	{
		// Token: 0x060004F0 RID: 1264 RVA: 0x0000B6FC File Offset: 0x000098FC
		public IapTelemetryException()
		{
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0000B704 File Offset: 0x00009904
		public IapTelemetryException(string message) : base(message)
		{
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0000B70D File Offset: 0x0000990D
		public IapTelemetryException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
