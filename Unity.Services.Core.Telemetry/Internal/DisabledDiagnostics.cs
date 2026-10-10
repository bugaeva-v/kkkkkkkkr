using System;
using System.Collections.Generic;

namespace Unity.Services.Core.Telemetry.Internal
{
	// Token: 0x02000004 RID: 4
	internal class DisabledDiagnostics : IDiagnostics
	{
		// Token: 0x06000007 RID: 7 RVA: 0x0000208F File Offset: 0x0000028F
		void IDiagnostics.SendDiagnostic(string name, string message, IDictionary<string, string> tags)
		{
		}
	}
}
