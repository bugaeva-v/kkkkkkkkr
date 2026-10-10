using System;
using System.IO;
using System.Text;

namespace Castle.Core.Logging
{
	// Token: 0x020000DA RID: 218
	[Serializable]
	public class StreamLogger : LevelFilteredLogger, IDisposable
	{
		// Token: 0x060005DB RID: 1499 RVA: 0x00011575 File Offset: 0x0000F775
		public StreamLogger(string name, Stream stream) : this(name, new StreamWriter(stream))
		{
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00011584 File Offset: 0x0000F784
		public StreamLogger(string name, Stream stream, Encoding encoding) : this(name, new StreamWriter(stream, encoding))
		{
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00011594 File Offset: 0x0000F794
		public StreamLogger(string name, Stream stream, Encoding encoding, int bufferSize) : this(name, new StreamWriter(stream, encoding, bufferSize))
		{
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x000115A8 File Offset: 0x0000F7A8
		~StreamLogger()
		{
			this.Dispose(false);
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x000115D8 File Offset: 0x0000F7D8
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x000115E7 File Offset: 0x0000F7E7
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && this.writer != null)
			{
				this.writer.Dispose();
				this.writer = null;
			}
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00011606 File Offset: 0x0000F806
		protected StreamLogger(string name, StreamWriter writer) : base(name, LoggerLevel.Trace)
		{
			this.writer = writer;
			writer.AutoFlush = true;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00011620 File Offset: 0x0000F820
		protected override void Log(LoggerLevel loggerLevel, string loggerName, string message, Exception exception)
		{
			if (this.writer == null)
			{
				return;
			}
			this.writer.WriteLine("[{0}] '{1}' {2}", loggerLevel, loggerName, message);
			if (exception != null)
			{
				this.writer.WriteLine("[{0}] '{1}' {2}: {3} {4}", new object[]
				{
					loggerLevel,
					loggerName,
					exception.GetType().FullName,
					exception.Message,
					exception.StackTrace
				});
			}
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00011698 File Offset: 0x0000F898
		public override ILogger CreateChildLogger(string loggerName)
		{
			throw new NotSupportedException("A streamlogger does not support child loggers");
		}

		// Token: 0x04000169 RID: 361
		private StreamWriter writer;
	}
}
