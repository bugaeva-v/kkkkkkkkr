using System;
using System.Collections.Generic;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Telemetry.Internal
{
	// Token: 0x02000003 RID: 3
	internal class DiagnosticsFactory : IDiagnosticsFactory, IServiceComponent
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000206D File Offset: 0x0000026D
		public IReadOnlyDictionary<string, string> CommonTags { get; } = new Dictionary<string, string>();

		// Token: 0x06000005 RID: 5 RVA: 0x00002075 File Offset: 0x00000275
		public IDiagnostics Create(string packageName)
		{
			return new Diagnostics();
		}
	}
}
