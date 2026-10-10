using System;

namespace Castle.Core.Logging
{
	// Token: 0x020000CA RID: 202
	[Serializable]
	public class ConsoleFactory : MarshalByRefObject, ILoggerFactory
	{
		// Token: 0x06000507 RID: 1287 RVA: 0x00010C55 File Offset: 0x0000EE55
		public ConsoleFactory()
		{
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00010C5D File Offset: 0x0000EE5D
		public ConsoleFactory(LoggerLevel level)
		{
			this.level = new LoggerLevel?(level);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00010C71 File Offset: 0x0000EE71
		public ILogger Create(Type type)
		{
			return this.Create(type.FullName);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00010C7F File Offset: 0x0000EE7F
		public ILogger Create(string name)
		{
			if (this.level != null)
			{
				return this.Create(name, this.level.Value);
			}
			return new ConsoleLogger(name);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00010CA7 File Offset: 0x0000EEA7
		public ILogger Create(Type type, LoggerLevel level)
		{
			return new ConsoleLogger(type.Name, level);
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00010CB5 File Offset: 0x0000EEB5
		public ILogger Create(string name, LoggerLevel level)
		{
			return new ConsoleLogger(name, level);
		}

		// Token: 0x0400015B RID: 347
		private LoggerLevel? level;
	}
}
