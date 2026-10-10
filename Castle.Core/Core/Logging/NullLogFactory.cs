using System;

namespace Castle.Core.Logging
{
	// Token: 0x020000D8 RID: 216
	[Serializable]
	public class NullLogFactory : AbstractLoggerFactory
	{
		// Token: 0x060005A2 RID: 1442 RVA: 0x000114CD File Offset: 0x0000F6CD
		public override ILogger Create(string name)
		{
			return NullLogger.Instance;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x000114D4 File Offset: 0x0000F6D4
		public override ILogger Create(string name, LoggerLevel level)
		{
			return NullLogger.Instance;
		}
	}
}
