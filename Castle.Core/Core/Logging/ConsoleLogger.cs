using System;
using System.Globalization;

namespace Castle.Core.Logging
{
	// Token: 0x020000CB RID: 203
	[Serializable]
	public class ConsoleLogger : LevelFilteredLogger
	{
		// Token: 0x0600050D RID: 1293 RVA: 0x00010CBE File Offset: 0x0000EEBE
		public ConsoleLogger() : this(string.Empty, LoggerLevel.Debug)
		{
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00010CCC File Offset: 0x0000EECC
		public ConsoleLogger(LoggerLevel logLevel) : this(string.Empty, logLevel)
		{
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00010CDA File Offset: 0x0000EEDA
		public ConsoleLogger(string name) : this(name, LoggerLevel.Debug)
		{
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00010CE4 File Offset: 0x0000EEE4
		public ConsoleLogger(string name, LoggerLevel logLevel) : base(name, logLevel)
		{
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00010CF0 File Offset: 0x0000EEF0
		protected override void Log(LoggerLevel loggerLevel, string loggerName, string message, Exception exception)
		{
			Console.Out.WriteLine("[{0}] '{1}' {2}", loggerLevel, loggerName, message);
			if (exception != null)
			{
				Console.Out.WriteLine("[{0}] '{1}' {2}: {3} {4}", new object[]
				{
					loggerLevel,
					loggerName,
					exception.GetType().FullName,
					exception.Message,
					exception.StackTrace
				});
			}
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00010D60 File Offset: 0x0000EF60
		public override ILogger CreateChildLogger(string loggerName)
		{
			if (loggerName == null)
			{
				throw new ArgumentNullException("loggerName", "To create a child logger you must supply a non null name");
			}
			return new ConsoleLogger(string.Format(CultureInfo.CurrentCulture, "{0}.{1}", new object[]
			{
				base.Name,
				loggerName
			}), base.Level);
		}
	}
}
