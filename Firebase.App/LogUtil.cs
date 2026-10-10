using System;
using Firebase.Platform;

namespace Firebase
{
	// Token: 0x02000007 RID: 7
	internal sealed class LogUtil : IDisposable
	{
		// Token: 0x06000023 RID: 35 RVA: 0x000023DA File Offset: 0x000005DA
		static LogUtil()
		{
			LogUtil._instance = new LogUtil();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000023F8 File Offset: 0x000005F8
		public static void InitializeLogging()
		{
			object initializeLoggingLock = LogUtil.InitializeLoggingLock;
			lock (initializeLoggingLock)
			{
				AppUtil.AppEnableLogCallback(true);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002440 File Offset: 0x00000640
		internal static PlatformLogLevel ConvertLogLevel(LogLevel logLevel)
		{
			switch (logLevel)
			{
			case LogLevel.Verbose:
				return PlatformLogLevel.Verbose;
			case LogLevel.Info:
				return PlatformLogLevel.Info;
			case LogLevel.Warning:
				return PlatformLogLevel.Warning;
			case LogLevel.Error:
				return PlatformLogLevel.Error;
			}
			return PlatformLogLevel.Debug;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002483 File Offset: 0x00000683
		internal static void LogMessage(LogLevel logLevel, string message)
		{
			FirebaseLogger.LogMessage(LogUtil.ConvertLogLevel(logLevel), message);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002494 File Offset: 0x00000694
		[MonoPInvokeCallback(typeof(LogUtil.LogMessageDelegate))]
		internal static void LogMessageFromCallback(LogLevel logLevel, string message)
		{
			bool canRedirectNativeLogs = FirebaseLogger.CanRedirectNativeLogs;
			if (canRedirectNativeLogs)
			{
				LogUtil.LogMessage(logLevel, message);
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000024B3 File Offset: 0x000006B3
		public LogUtil()
		{
			AppUtil.SetLogFunction(new LogUtil.LogMessageDelegate(LogUtil.LogMessageFromCallback));
			AppDomain.CurrentDomain.DomainUnload += delegate(object sender, EventArgs e)
			{
				this.Dispose(false);
			};
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000024F0 File Offset: 0x000006F0
		~LogUtil()
		{
			this.Dispose(false);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002524 File Offset: 0x00000724
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002538 File Offset: 0x00000738
		protected void Dispose(bool disposing)
		{
			bool flag = !this._disposed;
			if (flag)
			{
				AppUtil.SetLogFunction(null);
				this._disposed = true;
			}
		}

		// Token: 0x04000019 RID: 25
		private static LogUtil _instance = null;

		// Token: 0x0400001A RID: 26
		private static object InitializeLoggingLock = new object();

		// Token: 0x0400001B RID: 27
		private bool _disposed = false;

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x0600029C RID: 668
		internal delegate void LogMessageDelegate(LogLevel log_level, string message);
	}
}
