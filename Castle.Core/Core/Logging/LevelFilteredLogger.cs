using System;
using System.Globalization;
using System.Security;

namespace Castle.Core.Logging
{
	// Token: 0x020000D5 RID: 213
	[Serializable]
	public abstract class LevelFilteredLogger : MarshalByRefObject, ILogger
	{
		// Token: 0x06000562 RID: 1378 RVA: 0x00010F7C File Offset: 0x0000F17C
		protected LevelFilteredLogger()
		{
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00010F8F File Offset: 0x0000F18F
		protected LevelFilteredLogger(string name)
		{
			this.ChangeName(name);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00010FA9 File Offset: 0x0000F1A9
		protected LevelFilteredLogger(LoggerLevel loggerLevel)
		{
			this.level = loggerLevel;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00010FC3 File Offset: 0x0000F1C3
		protected LevelFilteredLogger(string loggerName, LoggerLevel loggerLevel) : this(loggerLevel)
		{
			this.ChangeName(loggerName);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00010FD3 File Offset: 0x0000F1D3
		[SecurityCritical]
		public override object InitializeLifetimeService()
		{
			return null;
		}

		// Token: 0x06000567 RID: 1383
		public abstract ILogger CreateChildLogger(string loggerName);

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x00010FD6 File Offset: 0x0000F1D6
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x00010FDE File Offset: 0x0000F1DE
		public LoggerLevel Level
		{
			get
			{
				return this.level;
			}
			set
			{
				this.level = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00010FE7 File Offset: 0x0000F1E7
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00010FEF File Offset: 0x0000F1EF
		public void Trace(string message)
		{
			if (this.IsTraceEnabled)
			{
				this.Log(LoggerLevel.Trace, message, null);
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00011002 File Offset: 0x0000F202
		public void Trace(Func<string> messageFactory)
		{
			if (this.IsTraceEnabled)
			{
				this.Log(LoggerLevel.Trace, messageFactory(), null);
			}
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0001101A File Offset: 0x0000F21A
		public void Trace(string message, Exception exception)
		{
			if (this.IsTraceEnabled)
			{
				this.Log(LoggerLevel.Trace, message, exception);
			}
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0001102D File Offset: 0x0000F22D
		public void TraceFormat(string format, params object[] args)
		{
			if (this.IsTraceEnabled)
			{
				this.Log(LoggerLevel.Trace, string.Format(CultureInfo.CurrentCulture, format, args), null);
			}
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0001104B File Offset: 0x0000F24B
		public void TraceFormat(Exception exception, string format, params object[] args)
		{
			if (this.IsTraceEnabled)
			{
				this.Log(LoggerLevel.Trace, string.Format(CultureInfo.CurrentCulture, format, args), exception);
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00011069 File Offset: 0x0000F269
		public void TraceFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
			if (this.IsTraceEnabled)
			{
				this.Log(LoggerLevel.Trace, string.Format(formatProvider, format, args), null);
			}
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00011083 File Offset: 0x0000F283
		public void TraceFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
		{
			if (this.IsTraceEnabled)
			{
				this.Log(LoggerLevel.Trace, string.Format(formatProvider, format, args), exception);
			}
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0001109E File Offset: 0x0000F29E
		public void Debug(string message)
		{
			if (!this.IsDebugEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Debug, message, null);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x000110B2 File Offset: 0x0000F2B2
		public void Debug(Func<string> messageFactory)
		{
			if (!this.IsDebugEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Debug, messageFactory(), null);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x000110CB File Offset: 0x0000F2CB
		public void Debug(string message, Exception exception)
		{
			if (!this.IsDebugEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Debug, message, exception);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x000110DF File Offset: 0x0000F2DF
		public void DebugFormat(string format, params object[] args)
		{
			if (!this.IsDebugEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Debug, string.Format(CultureInfo.CurrentCulture, format, args), null);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x000110FE File Offset: 0x0000F2FE
		public void DebugFormat(Exception exception, string format, params object[] args)
		{
			if (!this.IsDebugEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Debug, string.Format(CultureInfo.CurrentCulture, format, args), exception);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0001111D File Offset: 0x0000F31D
		public void DebugFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
			if (!this.IsDebugEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Debug, string.Format(formatProvider, format, args), null);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00011138 File Offset: 0x0000F338
		public void DebugFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
		{
			if (!this.IsDebugEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Debug, string.Format(formatProvider, format, args), exception);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00011154 File Offset: 0x0000F354
		public void Info(string message)
		{
			if (!this.IsInfoEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Info, message, null);
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00011168 File Offset: 0x0000F368
		public void Info(Func<string> messageFactory)
		{
			if (!this.IsInfoEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Info, messageFactory(), null);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00011181 File Offset: 0x0000F381
		public void Info(string message, Exception exception)
		{
			if (!this.IsInfoEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Info, message, exception);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00011195 File Offset: 0x0000F395
		public void InfoFormat(string format, params object[] args)
		{
			if (!this.IsInfoEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Info, string.Format(CultureInfo.CurrentCulture, format, args), null);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x000111B4 File Offset: 0x0000F3B4
		public void InfoFormat(Exception exception, string format, params object[] args)
		{
			if (!this.IsInfoEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Info, string.Format(CultureInfo.CurrentCulture, format, args), exception);
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x000111D3 File Offset: 0x0000F3D3
		public void InfoFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
			if (!this.IsInfoEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Info, string.Format(formatProvider, format, args), null);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x000111EE File Offset: 0x0000F3EE
		public void InfoFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
		{
			if (!this.IsInfoEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Info, string.Format(formatProvider, format, args), exception);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0001120A File Offset: 0x0000F40A
		public void Warn(string message)
		{
			if (!this.IsWarnEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Warn, message, null);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0001121E File Offset: 0x0000F41E
		public void Warn(Func<string> messageFactory)
		{
			if (!this.IsWarnEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Warn, messageFactory(), null);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00011237 File Offset: 0x0000F437
		public void Warn(string message, Exception exception)
		{
			if (!this.IsWarnEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Warn, message, exception);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0001124B File Offset: 0x0000F44B
		public void WarnFormat(string format, params object[] args)
		{
			if (!this.IsWarnEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Warn, string.Format(CultureInfo.CurrentCulture, format, args), null);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0001126A File Offset: 0x0000F46A
		public void WarnFormat(Exception exception, string format, params object[] args)
		{
			if (!this.IsWarnEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Warn, string.Format(CultureInfo.CurrentCulture, format, args), exception);
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00011289 File Offset: 0x0000F489
		public void WarnFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
			if (!this.IsWarnEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Warn, string.Format(formatProvider, format, args), null);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x000112A4 File Offset: 0x0000F4A4
		public void WarnFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
		{
			if (!this.IsWarnEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Warn, string.Format(formatProvider, format, args), exception);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x000112C0 File Offset: 0x0000F4C0
		public void Error(string message)
		{
			if (!this.IsErrorEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Error, message, null);
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x000112D4 File Offset: 0x0000F4D4
		public void Error(Func<string> messageFactory)
		{
			if (!this.IsErrorEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Error, messageFactory(), null);
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x000112ED File Offset: 0x0000F4ED
		public void Error(string message, Exception exception)
		{
			if (!this.IsErrorEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Error, message, exception);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00011301 File Offset: 0x0000F501
		public void ErrorFormat(string format, params object[] args)
		{
			if (!this.IsErrorEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Error, string.Format(CultureInfo.CurrentCulture, format, args), null);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00011320 File Offset: 0x0000F520
		public void ErrorFormat(Exception exception, string format, params object[] args)
		{
			if (!this.IsErrorEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Error, string.Format(CultureInfo.CurrentCulture, format, args), exception);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x0001133F File Offset: 0x0000F53F
		public void ErrorFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
			if (!this.IsErrorEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Error, string.Format(formatProvider, format, args), null);
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0001135A File Offset: 0x0000F55A
		public void ErrorFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
		{
			if (!this.IsErrorEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Error, string.Format(formatProvider, format, args), exception);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00011376 File Offset: 0x0000F576
		public void Fatal(string message)
		{
			if (!this.IsFatalEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Fatal, message, null);
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x0001138A File Offset: 0x0000F58A
		public void Fatal(Func<string> messageFactory)
		{
			if (!this.IsFatalEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Fatal, messageFactory(), null);
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x000113A3 File Offset: 0x0000F5A3
		public void Fatal(string message, Exception exception)
		{
			if (!this.IsFatalEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Fatal, message, exception);
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x000113B7 File Offset: 0x0000F5B7
		public void FatalFormat(string format, params object[] args)
		{
			if (!this.IsFatalEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Fatal, string.Format(CultureInfo.CurrentCulture, format, args), null);
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x000113D6 File Offset: 0x0000F5D6
		public void FatalFormat(Exception exception, string format, params object[] args)
		{
			if (!this.IsFatalEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Fatal, string.Format(CultureInfo.CurrentCulture, format, args), exception);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x000113F5 File Offset: 0x0000F5F5
		public void FatalFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
			if (!this.IsFatalEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Fatal, string.Format(formatProvider, format, args), null);
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00011410 File Offset: 0x0000F610
		public void FatalFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
		{
			if (!this.IsFatalEnabled)
			{
				return;
			}
			this.Log(LoggerLevel.Fatal, string.Format(formatProvider, format, args), exception);
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x0001142C File Offset: 0x0000F62C
		public bool IsTraceEnabled
		{
			get
			{
				return this.Level >= LoggerLevel.Trace;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x0001143A File Offset: 0x0000F63A
		public bool IsDebugEnabled
		{
			get
			{
				return this.Level >= LoggerLevel.Debug;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00011448 File Offset: 0x0000F648
		public bool IsInfoEnabled
		{
			get
			{
				return this.Level >= LoggerLevel.Info;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x00011456 File Offset: 0x0000F656
		public bool IsWarnEnabled
		{
			get
			{
				return this.Level >= LoggerLevel.Warn;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00011464 File Offset: 0x0000F664
		public bool IsErrorEnabled
		{
			get
			{
				return this.Level >= LoggerLevel.Error;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x00011472 File Offset: 0x0000F672
		public bool IsFatalEnabled
		{
			get
			{
				return this.Level >= LoggerLevel.Fatal;
			}
		}

		// Token: 0x0600059B RID: 1435
		protected abstract void Log(LoggerLevel loggerLevel, string loggerName, string message, Exception exception);

		// Token: 0x0600059C RID: 1436 RVA: 0x00011480 File Offset: 0x0000F680
		protected void ChangeName(string newName)
		{
			if (newName == null)
			{
				throw new ArgumentNullException("newName");
			}
			this.name = newName;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00011497 File Offset: 0x0000F697
		private void Log(LoggerLevel loggerLevel, string message, Exception exception)
		{
			this.Log(loggerLevel, this.Name, message, exception);
		}

		// Token: 0x0400015E RID: 350
		private LoggerLevel level;

		// Token: 0x0400015F RID: 351
		private string name = "unnamed";
	}
}
