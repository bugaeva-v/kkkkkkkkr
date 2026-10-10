using System;

namespace Castle.Core.Logging
{
	// Token: 0x020000D1 RID: 209
	public interface IExtendedLogger : ILogger
	{
		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000526 RID: 1318
		IContextProperties GlobalProperties { get; }

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000527 RID: 1319
		IContextProperties ThreadProperties { get; }

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000528 RID: 1320
		IContextStacks ThreadStacks { get; }
	}
}
