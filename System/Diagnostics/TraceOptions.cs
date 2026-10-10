using System;

namespace System.Diagnostics
{
	/// <summary>Задает параметры данных трассировки, записываемые в выходные данные трассировки.</summary>
	// Token: 0x02000233 RID: 563
	[Flags]
	public enum TraceOptions
	{
		/// <summary>Не записывает элементы.</summary>
		// Token: 0x040009FD RID: 2557
		None = 0,
		/// <summary>Записывает стек логических операций, представленный возвращаемым значением свойства <see cref="P:System.Diagnostics.CorrelationManager.LogicalOperationStack" />.</summary>
		// Token: 0x040009FE RID: 2558
		LogicalOperationStack = 1,
		/// <summary>Записывает дату и время.</summary>
		// Token: 0x040009FF RID: 2559
		DateTime = 2,
		/// <summary>Записывает отметку времени, представленную возвращаемым значением метода <see cref="M:System.Diagnostics.Stopwatch.GetTimestamp" />.</summary>
		// Token: 0x04000A00 RID: 2560
		Timestamp = 4,
		/// <summary>Записывает стек идентификации процесса, представленный возвращаемым значением свойства <see cref="P:System.Diagnostics.Process.Id" />.</summary>
		// Token: 0x04000A01 RID: 2561
		ProcessId = 8,
		/// <summary>Записывает стек удостоверений процесса, представленный возвращаемым значением свойства <see cref="P:System.Threading.Thread.ManagedThreadId" /> для текущего потока.</summary>
		// Token: 0x04000A02 RID: 2562
		ThreadId = 16,
		/// <summary>Записывает стек вызова, представленный возвращаемым значением свойства <see cref="P:System.Environment.StackTrace" />.</summary>
		// Token: 0x04000A03 RID: 2563
		Callstack = 32
	}
}
