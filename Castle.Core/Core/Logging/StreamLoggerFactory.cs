using System;
using System.IO;

namespace Castle.Core.Logging
{
	// Token: 0x020000DB RID: 219
	[Serializable]
	public class StreamLoggerFactory : AbstractLoggerFactory
	{
		// Token: 0x060005E4 RID: 1508 RVA: 0x000116A4 File Offset: 0x0000F8A4
		public override ILogger Create(string name)
		{
			return new StreamLogger(name, new FileStream(name + ".log", FileMode.Append, FileAccess.Write));
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x000116BE File Offset: 0x0000F8BE
		public override ILogger Create(string name, LoggerLevel level)
		{
			return new StreamLogger(name, new FileStream(name + ".log", FileMode.Append, FileAccess.Write))
			{
				Level = level
			};
		}
	}
}
