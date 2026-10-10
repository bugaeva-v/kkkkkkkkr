using System;

namespace Castle.Core.Logging
{
	// Token: 0x020000D2 RID: 210
	public interface IExtendedLoggerFactory : ILoggerFactory
	{
		// Token: 0x06000529 RID: 1321
		IExtendedLogger Create(Type type);

		// Token: 0x0600052A RID: 1322
		IExtendedLogger Create(string name);

		// Token: 0x0600052B RID: 1323
		IExtendedLogger Create(Type type, LoggerLevel level);

		// Token: 0x0600052C RID: 1324
		IExtendedLogger Create(string name, LoggerLevel level);
	}
}
