using System;
using System.Diagnostics;
using System.Globalization;

namespace Castle.Core.Logging
{
	// Token: 0x020000CC RID: 204
	[Serializable]
	public class DiagnosticsLogger : LevelFilteredLogger, IDisposable
	{
		// Token: 0x06000513 RID: 1299 RVA: 0x00010DAD File Offset: 0x0000EFAD
		public DiagnosticsLogger(string logName) : this(logName, "default")
		{
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00010DBB File Offset: 0x0000EFBB
		public DiagnosticsLogger(string logName, string source) : base(LoggerLevel.Trace)
		{
			if (!EventLog.SourceExists(source))
			{
				EventLog.CreateEventSource(source, logName);
			}
			this.eventLog = new EventLog(logName);
			this.eventLog.Source = source;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00010DEB File Offset: 0x0000EFEB
		public DiagnosticsLogger(string logName, string machineName, string source)
		{
			if (!EventLog.SourceExists(source, machineName))
			{
				EventLog.CreateEventSource(new EventSourceCreationData(source, logName)
				{
					MachineName = machineName
				});
			}
			this.eventLog = new EventLog(logName, machineName, source);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00010E1D File Offset: 0x0000F01D
		public override ILogger CreateChildLogger(string loggerName)
		{
			return new DiagnosticsLogger(this.eventLog.Log, this.eventLog.MachineName, this.eventLog.Source);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00010E45 File Offset: 0x0000F045
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00010E54 File Offset: 0x0000F054
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && this.eventLog != null)
			{
				this.eventLog.Close();
				this.eventLog = null;
			}
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00010E74 File Offset: 0x0000F074
		protected override void Log(LoggerLevel loggerLevel, string loggerName, string message, Exception exception)
		{
			if (this.eventLog == null)
			{
				return;
			}
			EventLogEntryType type = DiagnosticsLogger.TranslateLevel(loggerLevel);
			string message2;
			if (exception == null)
			{
				message2 = string.Format(CultureInfo.CurrentCulture, "[{0}] '{1}' message: {2}", new object[]
				{
					loggerLevel,
					loggerName,
					message
				});
			}
			else
			{
				message2 = string.Format(CultureInfo.CurrentCulture, "[{0}] '{1}' message: {2} exception: {3} {4} {5}", new object[]
				{
					loggerLevel,
					loggerName,
					message,
					exception.GetType(),
					exception.Message,
					exception.StackTrace
				});
			}
			this.eventLog.WriteEntry(message2, type);
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00010F10 File Offset: 0x0000F110
		~DiagnosticsLogger()
		{
			this.Dispose(false);
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00010F40 File Offset: 0x0000F140
		private static EventLogEntryType TranslateLevel(LoggerLevel level)
		{
			if (level - LoggerLevel.Fatal <= 1)
			{
				return EventLogEntryType.Error;
			}
			if (level != LoggerLevel.Warn)
			{
				return EventLogEntryType.Information;
			}
			return EventLogEntryType.Warning;
		}

		// Token: 0x0400015C RID: 348
		[NonSerialized]
		private EventLog eventLog;
	}
}
