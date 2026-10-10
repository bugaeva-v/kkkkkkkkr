using System;

namespace Castle.Core.Logging
{
	// Token: 0x020000CD RID: 205
	[Serializable]
	public class DiagnosticsLoggerFactory : AbstractLoggerFactory
	{
		// Token: 0x0600051C RID: 1308 RVA: 0x00010F53 File Offset: 0x0000F153
		public override ILogger Create(string name)
		{
			return new DiagnosticsLogger("CastleDefaultLogger", name);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00010F60 File Offset: 0x0000F160
		public override ILogger Create(string name, LoggerLevel level)
		{
			return new DiagnosticsLogger("CastleDefaultLogger", name)
			{
				Level = level
			};
		}

		// Token: 0x0400015D RID: 349
		private const string DefaultLogName = "CastleDefaultLogger";
	}
}
