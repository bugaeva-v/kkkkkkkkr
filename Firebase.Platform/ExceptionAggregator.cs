using System;
using System.Collections.Generic;
using Firebase.Platform;

namespace Firebase
{
	// Token: 0x02000002 RID: 2
	internal class ExceptionAggregator
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		private static List<Exception> Exceptions
		{
			get
			{
				bool flag = ExceptionAggregator.threadLocalExceptions == null;
				if (flag)
				{
					ExceptionAggregator.threadLocalExceptions = new List<Exception>();
				}
				return ExceptionAggregator.threadLocalExceptions;
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002080 File Offset: 0x00000280
		public static Exception GetAndClearPendingExceptions()
		{
			List<Exception> exceptions = ExceptionAggregator.Exceptions;
			int count = exceptions.Count;
			Exception result = null;
			bool flag = count == 1;
			if (flag)
			{
				result = exceptions[0];
			}
			else
			{
				bool flag2 = count > 1;
				if (flag2)
				{
					result = new AggregateException(exceptions.ToArray());
				}
			}
			exceptions.Clear();
			return result;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020D8 File Offset: 0x000002D8
		public static void ThrowAndClearPendingExceptions()
		{
			Exception andClearPendingExceptions = ExceptionAggregator.GetAndClearPendingExceptions();
			bool flag = andClearPendingExceptions != null;
			if (flag)
			{
				ExceptionAggregator.LogException(andClearPendingExceptions);
				throw andClearPendingExceptions;
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002100 File Offset: 0x00000300
		public static Exception LogException(Exception exception)
		{
			bool flag = exception != null;
			if (flag)
			{
				AggregateException ex = exception as AggregateException;
				bool flag2 = ex != null;
				if (flag2)
				{
					List<string> list = new List<string>();
					foreach (Exception ex2 in ex.Flatten().InnerExceptions)
					{
						list.Add(ex2.ToString());
					}
					FirebaseLogger.LogMessage(PlatformLogLevel.Error, string.Join("\n\n", list.ToArray()));
				}
				else
				{
					FirebaseLogger.LogMessage(PlatformLogLevel.Error, exception.ToString());
				}
			}
			return exception;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021B8 File Offset: 0x000003B8
		public static void Wrap(Action action)
		{
			try
			{
				action();
			}
			catch (Exception item)
			{
				ExceptionAggregator.Exceptions.Add(item);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021F4 File Offset: 0x000003F4
		public static T Wrap<T>(Func<T> func, T errorValue)
		{
			try
			{
				return func();
			}
			catch (Exception item)
			{
				ExceptionAggregator.Exceptions.Add(item);
			}
			return errorValue;
		}

		// Token: 0x04000001 RID: 1
		[ThreadStatic]
		private static List<Exception> threadLocalExceptions = null;
	}
}
