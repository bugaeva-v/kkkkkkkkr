using System;

namespace Castle.Core.Logging
{
	// Token: 0x020000D9 RID: 217
	public class NullLogger : IExtendedLogger, ILogger
	{
		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x000114E3 File Offset: 0x0000F6E3
		public IContextProperties GlobalProperties
		{
			get
			{
				return NullLogger.NullContextProperties.Instance;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x000114EA File Offset: 0x0000F6EA
		public IContextProperties ThreadProperties
		{
			get
			{
				return NullLogger.NullContextProperties.Instance;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x000114F1 File Offset: 0x0000F6F1
		public IContextStacks ThreadStacks
		{
			get
			{
				return NullLogger.NullContextStacks.Instance;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x000114F8 File Offset: 0x0000F6F8
		public bool IsTraceEnabled
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x000114FB File Offset: 0x0000F6FB
		public bool IsDebugEnabled
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x000114FE File Offset: 0x0000F6FE
		public bool IsErrorEnabled
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x00011501 File Offset: 0x0000F701
		public bool IsFatalEnabled
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x00011504 File Offset: 0x0000F704
		public bool IsInfoEnabled
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x00011507 File Offset: 0x0000F707
		public bool IsWarnEnabled
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0001150A File Offset: 0x0000F70A
		public ILogger CreateChildLogger(string loggerName)
		{
			return this;
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0001150D File Offset: 0x0000F70D
		public void Trace(string message)
		{
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0001150F File Offset: 0x0000F70F
		public void Trace(Func<string> messageFactory)
		{
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00011511 File Offset: 0x0000F711
		public void Trace(string message, Exception exception)
		{
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00011513 File Offset: 0x0000F713
		public void TraceFormat(string format, params object[] args)
		{
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00011515 File Offset: 0x0000F715
		public void TraceFormat(Exception exception, string format, params object[] args)
		{
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00011517 File Offset: 0x0000F717
		public void TraceFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00011519 File Offset: 0x0000F719
		public void TraceFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
		{
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0001151B File Offset: 0x0000F71B
		public void Debug(string message)
		{
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0001151D File Offset: 0x0000F71D
		public void Debug(Func<string> messageFactory)
		{
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0001151F File Offset: 0x0000F71F
		public void Debug(string message, Exception exception)
		{
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00011521 File Offset: 0x0000F721
		public void DebugFormat(string format, params object[] args)
		{
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00011523 File Offset: 0x0000F723
		public void DebugFormat(Exception exception, string format, params object[] args)
		{
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00011525 File Offset: 0x0000F725
		public void DebugFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00011527 File Offset: 0x0000F727
		public void DebugFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
		{
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00011529 File Offset: 0x0000F729
		public void Error(string message)
		{
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0001152B File Offset: 0x0000F72B
		public void Error(Func<string> messageFactory)
		{
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0001152D File Offset: 0x0000F72D
		public void Error(string message, Exception exception)
		{
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0001152F File Offset: 0x0000F72F
		public void ErrorFormat(string format, params object[] args)
		{
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00011531 File Offset: 0x0000F731
		public void ErrorFormat(Exception exception, string format, params object[] args)
		{
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00011533 File Offset: 0x0000F733
		public void ErrorFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00011535 File Offset: 0x0000F735
		public void ErrorFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
		{
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00011537 File Offset: 0x0000F737
		public void Fatal(string message)
		{
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00011539 File Offset: 0x0000F739
		public void Fatal(Func<string> messageFactory)
		{
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0001153B File Offset: 0x0000F73B
		public void Fatal(string message, Exception exception)
		{
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0001153D File Offset: 0x0000F73D
		public void FatalFormat(string format, params object[] args)
		{
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0001153F File Offset: 0x0000F73F
		public void FatalFormat(Exception exception, string format, params object[] args)
		{
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00011541 File Offset: 0x0000F741
		public void FatalFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00011543 File Offset: 0x0000F743
		public void FatalFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
		{
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00011545 File Offset: 0x0000F745
		public void Info(string message)
		{
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00011547 File Offset: 0x0000F747
		public void Info(Func<string> messageFactory)
		{
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00011549 File Offset: 0x0000F749
		public void Info(string message, Exception exception)
		{
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0001154B File Offset: 0x0000F74B
		public void InfoFormat(string format, params object[] args)
		{
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0001154D File Offset: 0x0000F74D
		public void InfoFormat(Exception exception, string format, params object[] args)
		{
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0001154F File Offset: 0x0000F74F
		public void InfoFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00011551 File Offset: 0x0000F751
		public void InfoFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
		{
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00011553 File Offset: 0x0000F753
		public void Warn(string message)
		{
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00011555 File Offset: 0x0000F755
		public void Warn(Func<string> messageFactory)
		{
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00011557 File Offset: 0x0000F757
		public void Warn(string message, Exception exception)
		{
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00011559 File Offset: 0x0000F759
		public void WarnFormat(string format, params object[] args)
		{
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0001155B File Offset: 0x0000F75B
		public void WarnFormat(Exception exception, string format, params object[] args)
		{
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0001155D File Offset: 0x0000F75D
		public void WarnFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0001155F File Offset: 0x0000F75F
		public void WarnFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
		{
		}

		// Token: 0x04000168 RID: 360
		public static readonly NullLogger Instance = new NullLogger();

		// Token: 0x020001EC RID: 492
		private class NullContextProperties : IContextProperties
		{
			// Token: 0x170002A5 RID: 677
			public object this[string key]
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			// Token: 0x04000397 RID: 919
			public static readonly NullLogger.NullContextProperties Instance = new NullLogger.NullContextProperties();
		}

		// Token: 0x020001ED RID: 493
		private class NullContextStack : IContextStack, IDisposable
		{
			// Token: 0x170002A6 RID: 678
			// (get) Token: 0x06000E4D RID: 3661 RVA: 0x00022293 File Offset: 0x00020493
			public int Count
			{
				get
				{
					return 0;
				}
			}

			// Token: 0x06000E4E RID: 3662 RVA: 0x00022296 File Offset: 0x00020496
			public void Clear()
			{
			}

			// Token: 0x06000E4F RID: 3663 RVA: 0x00022298 File Offset: 0x00020498
			public string Pop()
			{
				return null;
			}

			// Token: 0x06000E50 RID: 3664 RVA: 0x0002229B File Offset: 0x0002049B
			public IDisposable Push(string message)
			{
				return this;
			}

			// Token: 0x06000E51 RID: 3665 RVA: 0x0002229E File Offset: 0x0002049E
			public void Dispose()
			{
				GC.SuppressFinalize(this);
			}

			// Token: 0x04000398 RID: 920
			public static readonly NullLogger.NullContextStack Instance = new NullLogger.NullContextStack();
		}

		// Token: 0x020001EE RID: 494
		private class NullContextStacks : IContextStacks
		{
			// Token: 0x170002A7 RID: 679
			public IContextStack this[string key]
			{
				get
				{
					return NullLogger.NullContextStack.Instance;
				}
			}

			// Token: 0x04000399 RID: 921
			public static readonly NullLogger.NullContextStacks Instance = new NullLogger.NullContextStacks();
		}
	}
}
