using System;

namespace Castle.Core.Logging
{
	// Token: 0x020000D3 RID: 211
	public interface ILogger
	{
		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600052D RID: 1325
		bool IsTraceEnabled { get; }

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600052E RID: 1326
		bool IsDebugEnabled { get; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600052F RID: 1327
		bool IsErrorEnabled { get; }

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000530 RID: 1328
		bool IsFatalEnabled { get; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000531 RID: 1329
		bool IsInfoEnabled { get; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000532 RID: 1330
		bool IsWarnEnabled { get; }

		// Token: 0x06000533 RID: 1331
		ILogger CreateChildLogger(string loggerName);

		// Token: 0x06000534 RID: 1332
		void Trace(string message);

		// Token: 0x06000535 RID: 1333
		void Trace(Func<string> messageFactory);

		// Token: 0x06000536 RID: 1334
		void Trace(string message, Exception exception);

		// Token: 0x06000537 RID: 1335
		void TraceFormat(string format, params object[] args);

		// Token: 0x06000538 RID: 1336
		void TraceFormat(Exception exception, string format, params object[] args);

		// Token: 0x06000539 RID: 1337
		void TraceFormat(IFormatProvider formatProvider, string format, params object[] args);

		// Token: 0x0600053A RID: 1338
		void TraceFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args);

		// Token: 0x0600053B RID: 1339
		void Debug(string message);

		// Token: 0x0600053C RID: 1340
		void Debug(Func<string> messageFactory);

		// Token: 0x0600053D RID: 1341
		void Debug(string message, Exception exception);

		// Token: 0x0600053E RID: 1342
		void DebugFormat(string format, params object[] args);

		// Token: 0x0600053F RID: 1343
		void DebugFormat(Exception exception, string format, params object[] args);

		// Token: 0x06000540 RID: 1344
		void DebugFormat(IFormatProvider formatProvider, string format, params object[] args);

		// Token: 0x06000541 RID: 1345
		void DebugFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args);

		// Token: 0x06000542 RID: 1346
		void Error(string message);

		// Token: 0x06000543 RID: 1347
		void Error(Func<string> messageFactory);

		// Token: 0x06000544 RID: 1348
		void Error(string message, Exception exception);

		// Token: 0x06000545 RID: 1349
		void ErrorFormat(string format, params object[] args);

		// Token: 0x06000546 RID: 1350
		void ErrorFormat(Exception exception, string format, params object[] args);

		// Token: 0x06000547 RID: 1351
		void ErrorFormat(IFormatProvider formatProvider, string format, params object[] args);

		// Token: 0x06000548 RID: 1352
		void ErrorFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args);

		// Token: 0x06000549 RID: 1353
		void Fatal(string message);

		// Token: 0x0600054A RID: 1354
		void Fatal(Func<string> messageFactory);

		// Token: 0x0600054B RID: 1355
		void Fatal(string message, Exception exception);

		// Token: 0x0600054C RID: 1356
		void FatalFormat(string format, params object[] args);

		// Token: 0x0600054D RID: 1357
		void FatalFormat(Exception exception, string format, params object[] args);

		// Token: 0x0600054E RID: 1358
		void FatalFormat(IFormatProvider formatProvider, string format, params object[] args);

		// Token: 0x0600054F RID: 1359
		void FatalFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args);

		// Token: 0x06000550 RID: 1360
		void Info(string message);

		// Token: 0x06000551 RID: 1361
		void Info(Func<string> messageFactory);

		// Token: 0x06000552 RID: 1362
		void Info(string message, Exception exception);

		// Token: 0x06000553 RID: 1363
		void InfoFormat(string format, params object[] args);

		// Token: 0x06000554 RID: 1364
		void InfoFormat(Exception exception, string format, params object[] args);

		// Token: 0x06000555 RID: 1365
		void InfoFormat(IFormatProvider formatProvider, string format, params object[] args);

		// Token: 0x06000556 RID: 1366
		void InfoFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args);

		// Token: 0x06000557 RID: 1367
		void Warn(string message);

		// Token: 0x06000558 RID: 1368
		void Warn(Func<string> messageFactory);

		// Token: 0x06000559 RID: 1369
		void Warn(string message, Exception exception);

		// Token: 0x0600055A RID: 1370
		void WarnFormat(string format, params object[] args);

		// Token: 0x0600055B RID: 1371
		void WarnFormat(Exception exception, string format, params object[] args);

		// Token: 0x0600055C RID: 1372
		void WarnFormat(IFormatProvider formatProvider, string format, params object[] args);

		// Token: 0x0600055D RID: 1373
		void WarnFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args);
	}
}
