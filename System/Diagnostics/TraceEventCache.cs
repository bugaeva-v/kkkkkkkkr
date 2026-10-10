using System;
using System.Collections;
using System.Globalization;
using System.Threading;

namespace System.Diagnostics
{
	/// <summary>Предоставляет данные событий трассировки специфичные для потока и процесса.</summary>
	// Token: 0x0200022C RID: 556
	public class TraceEventCache
	{
		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x0004732D File Offset: 0x0004552D
		internal Guid ActivityId
		{
			get
			{
				return Trace.CorrelationManager.ActivityId;
			}
		}

		/// <summary>Возвращает стек вызовов для текущего потока.</summary>
		/// <returns>Строка, содержащая сведения о трассировке стека. Это значение может быть пустой строкой ("").</returns>
		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x0600105D RID: 4189 RVA: 0x00047339 File Offset: 0x00045539
		public string Callstack
		{
			get
			{
				if (this.stackTrace == null)
				{
					this.stackTrace = Environment.StackTrace;
				}
				return this.stackTrace;
			}
		}

		/// <summary>Возвращает данные корреляции, содержащиеся в стеке.</summary>
		/// <returns>Поток <see cref="T:System.Collections.Stack" />, содержащий данные корреляции.</returns>
		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x0600105E RID: 4190 RVA: 0x00047354 File Offset: 0x00045554
		public Stack LogicalOperationStack
		{
			get
			{
				return Trace.CorrelationManager.LogicalOperationStack;
			}
		}

		/// <summary>Возвращает дату и время, когда произошла трассировка событий.</summary>
		/// <returns>Структура <see cref="T:System.DateTime" />, значением которой является дата и время, выраженные в формате (UTC).</returns>
		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x0600105F RID: 4191 RVA: 0x00047360 File Offset: 0x00045560
		public DateTime DateTime
		{
			get
			{
				if (this.dateTime == DateTime.MinValue)
				{
					this.dateTime = DateTime.UtcNow;
				}
				return this.dateTime;
			}
		}

		/// <summary>Возвращает уникальный идентификатор текущего процесса.</summary>
		/// <returns>Созданный системой уникальный идентификатор текущего процесса.</returns>
		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06001060 RID: 4192 RVA: 0x00047385 File Offset: 0x00045585
		public int ProcessId
		{
			get
			{
				return TraceEventCache.GetProcessId();
			}
		}

		/// <summary>Возвращает уникальный идентификатор текущего управляемого потока.</summary>
		/// <returns>Строка, представляющая уникальный целочисленный идентификатор для этого управляемого потока.</returns>
		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06001061 RID: 4193 RVA: 0x0004738C File Offset: 0x0004558C
		public string ThreadId
		{
			get
			{
				return TraceEventCache.GetThreadId().ToString(CultureInfo.InvariantCulture);
			}
		}

		/// <summary>Получает текущее число тактов временного механизма.</summary>
		/// <returns>Значение счетчика тактов базового временного механизма.</returns>
		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06001062 RID: 4194 RVA: 0x000473AB File Offset: 0x000455AB
		public long Timestamp
		{
			get
			{
				if (this.timeStamp == -1L)
				{
					this.timeStamp = Stopwatch.GetTimestamp();
				}
				return this.timeStamp;
			}
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x000473C8 File Offset: 0x000455C8
		private static void InitProcessInfo()
		{
			if (TraceEventCache.processName == null)
			{
				Process currentProcess = Process.GetCurrentProcess();
				try
				{
					TraceEventCache.processId = currentProcess.Id;
					TraceEventCache.processName = currentProcess.ProcessName;
				}
				finally
				{
					currentProcess.Dispose();
				}
			}
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x00047418 File Offset: 0x00045618
		internal static int GetProcessId()
		{
			TraceEventCache.InitProcessInfo();
			return TraceEventCache.processId;
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x00047426 File Offset: 0x00045626
		internal static string GetProcessName()
		{
			TraceEventCache.InitProcessInfo();
			return TraceEventCache.processName;
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x00047434 File Offset: 0x00045634
		internal static int GetThreadId()
		{
			return Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x040009D3 RID: 2515
		private static volatile int processId;

		// Token: 0x040009D4 RID: 2516
		private static volatile string processName;

		// Token: 0x040009D5 RID: 2517
		private long timeStamp = -1L;

		// Token: 0x040009D6 RID: 2518
		private DateTime dateTime = DateTime.MinValue;

		// Token: 0x040009D7 RID: 2519
		private string stackTrace;
	}
}
