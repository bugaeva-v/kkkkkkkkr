using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security;

namespace Castle.Core.Logging
{
	// Token: 0x020000DC RID: 220
	public class TraceLogger : LevelFilteredLogger
	{
		// Token: 0x060005E7 RID: 1511 RVA: 0x000116E7 File Offset: 0x0000F8E7
		[SecuritySafeCritical]
		public TraceLogger(string name) : base(name)
		{
			this.Initialize();
			base.Level = TraceLogger.MapLoggerLevel(this.traceSource.Switch.Level);
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00011711 File Offset: 0x0000F911
		[SecuritySafeCritical]
		public TraceLogger(string name, LoggerLevel level) : base(name, level)
		{
			this.Initialize();
			base.Level = TraceLogger.MapLoggerLevel(this.traceSource.Switch.Level);
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0001173C File Offset: 0x0000F93C
		[SecuritySafeCritical]
		public override ILogger CreateChildLogger(string loggerName)
		{
			return this.InternalCreateChildLogger(loggerName);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00011745 File Offset: 0x0000F945
		[SecurityCritical]
		private ILogger InternalCreateChildLogger(string loggerName)
		{
			return new TraceLogger(base.Name + "." + loggerName, base.Level);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00011763 File Offset: 0x0000F963
		protected override void Log(LoggerLevel loggerLevel, string loggerName, string message, Exception exception)
		{
			if (exception == null)
			{
				this.traceSource.TraceEvent(TraceLogger.MapTraceEventType(loggerLevel), 0, message);
				return;
			}
			this.traceSource.TraceData(TraceLogger.MapTraceEventType(loggerLevel), 0, new object[]
			{
				message,
				exception
			});
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x000117A0 File Offset: 0x0000F9A0
		[SecurityCritical]
		private void Initialize()
		{
			Dictionary<string, TraceSource> obj = TraceLogger.cache;
			lock (obj)
			{
				if (!TraceLogger.cache.TryGetValue(base.Name, out this.traceSource))
				{
					SourceLevels defaultLevel = TraceLogger.MapSourceLevels(base.Level);
					this.traceSource = new TraceSource(base.Name, defaultLevel);
					if (TraceLogger.IsSourceConfigured(this.traceSource))
					{
						TraceLogger.cache.Add(base.Name, this.traceSource);
					}
					else
					{
						TraceSource traceSource = new TraceSource("Default", defaultLevel);
						string text = TraceLogger.ShortenName(base.Name);
						while (!string.IsNullOrEmpty(text))
						{
							TraceSource traceSource2 = new TraceSource(text, defaultLevel);
							if (TraceLogger.IsSourceConfigured(traceSource2))
							{
								traceSource = traceSource2;
								break;
							}
							text = TraceLogger.ShortenName(text);
						}
						this.traceSource.Switch = traceSource.Switch;
						this.traceSource.Listeners.Clear();
						foreach (object obj2 in traceSource.Listeners)
						{
							TraceListener listener = (TraceListener)obj2;
							this.traceSource.Listeners.Add(listener);
						}
						TraceLogger.cache.Add(base.Name, this.traceSource);
					}
				}
			}
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0001192C File Offset: 0x0000FB2C
		private static string ShortenName(string name)
		{
			int num = name.LastIndexOf('.');
			if (num != -1)
			{
				return name.Substring(0, num);
			}
			return null;
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00011950 File Offset: 0x0000FB50
		[SecuritySafeCritical]
		private static bool IsSourceConfigured(TraceSource source)
		{
			return source.Listeners.Count != 1 || !(source.Listeners[0] is DefaultTraceListener) || !(source.Listeners[0].Name == "Default");
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x000119A0 File Offset: 0x0000FBA0
		private static LoggerLevel MapLoggerLevel(SourceLevels level)
		{
			if (level <= SourceLevels.Warning)
			{
				switch (level)
				{
				case SourceLevels.All:
					return LoggerLevel.Trace;
				case SourceLevels.Off:
				case (SourceLevels)2:
					break;
				case SourceLevels.Critical:
					return LoggerLevel.Fatal;
				case SourceLevels.Error:
					return LoggerLevel.Error;
				default:
					if (level == SourceLevels.Warning)
					{
						return LoggerLevel.Warn;
					}
					break;
				}
			}
			else
			{
				if (level == SourceLevels.Information)
				{
					return LoggerLevel.Info;
				}
				if (level == SourceLevels.Verbose)
				{
					return LoggerLevel.Debug;
				}
			}
			return LoggerLevel.Off;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x000119EC File Offset: 0x0000FBEC
		private static SourceLevels MapSourceLevels(LoggerLevel level)
		{
			switch (level)
			{
			case LoggerLevel.Fatal:
				return SourceLevels.Critical;
			case LoggerLevel.Error:
				return SourceLevels.Error;
			case LoggerLevel.Warn:
				return SourceLevels.Warning;
			case LoggerLevel.Info:
				return SourceLevels.Information;
			case LoggerLevel.Debug:
				return SourceLevels.Verbose;
			case LoggerLevel.Trace:
				return SourceLevels.All;
			default:
				return SourceLevels.Off;
			}
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00011A1F File Offset: 0x0000FC1F
		private static TraceEventType MapTraceEventType(LoggerLevel level)
		{
			switch (level)
			{
			case LoggerLevel.Fatal:
				return TraceEventType.Critical;
			case LoggerLevel.Error:
				return TraceEventType.Error;
			case LoggerLevel.Warn:
				return TraceEventType.Warning;
			case LoggerLevel.Info:
				return TraceEventType.Information;
			case LoggerLevel.Debug:
			case LoggerLevel.Trace:
				return TraceEventType.Verbose;
			default:
				return TraceEventType.Verbose;
			}
		}

		// Token: 0x0400016A RID: 362
		private static readonly Dictionary<string, TraceSource> cache = new Dictionary<string, TraceSource>();

		// Token: 0x0400016B RID: 363
		private TraceSource traceSource;
	}
}
