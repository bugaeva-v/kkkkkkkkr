using System;

namespace Castle.Core.Logging
{
	// Token: 0x020000D4 RID: 212
	public interface ILoggerFactory
	{
		// Token: 0x0600055E RID: 1374
		ILogger Create(Type type);

		// Token: 0x0600055F RID: 1375
		ILogger Create(string name);

		// Token: 0x06000560 RID: 1376
		ILogger Create(Type type, LoggerLevel level);

		// Token: 0x06000561 RID: 1377
		ILogger Create(string name, LoggerLevel level);
	}
}
