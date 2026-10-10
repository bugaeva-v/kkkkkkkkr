using System;
using System.Collections.Generic;

namespace Unity.Services.Core.Telemetry.Internal
{
	// Token: 0x02000002 RID: 2
	internal class Diagnostics : IDiagnostics
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		internal IDictionary<string, string> PackageTags { get; } = new Dictionary<string, string>();

		// Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		public void SendDiagnostic(string name, string message, IDictionary<string, string> tags = null)
		{
		}
	}
}
