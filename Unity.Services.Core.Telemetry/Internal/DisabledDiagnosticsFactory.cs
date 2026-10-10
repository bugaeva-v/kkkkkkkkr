using System;
using System.Collections.Generic;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Telemetry.Internal
{
	// Token: 0x02000005 RID: 5
	internal class DisabledDiagnosticsFactory : IDiagnosticsFactory, IServiceComponent
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002099 File Offset: 0x00000299
		IReadOnlyDictionary<string, string> IDiagnosticsFactory.CommonTags { get; } = new Dictionary<string, string>();

		// Token: 0x0600000A RID: 10 RVA: 0x000020A1 File Offset: 0x000002A1
		IDiagnostics IDiagnosticsFactory.Create(string packageName)
		{
			return new DisabledDiagnostics();
		}
	}
}
