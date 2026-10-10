using System;

namespace System.Diagnostics
{
	/// <summary>
	///         Задает структуру файла, который будет использоваться для <see cref="T:System.Diagnostics.EventSchemaTraceListener" /> журнала.
	///       </summary>
	// Token: 0x0200038B RID: 907
	public enum TraceLogRetentionOption
	{
		/// <summary>
		///         Конечное число последовательных файлов, каждый из которых имеет максимальный размер файла.
		///          Когда <see cref="P:System.Diagnostics.EventSchemaTraceListener.MaximumFileSize" /> будет достигнуто значение свойства, начинается запись в новый файл с суффиксом увеличивается целое число со знаком.
		///          Когда <see cref="P:System.Diagnostics.EventSchemaTraceListener.MaximumNumberOfFiles" /> будет достигнуто значение свойства, первый файл очищается и перезаписаны.
		///          Затем файлы последовательно перезаписываются циклически.
		///       </summary>
		// Token: 0x04000D0D RID: 3341
		LimitedCircularFiles = 1,
		/// <summary>
		///         Конечное число последовательных файлов, каждый из которых имеет максимальный размер файла.
		///          Когда <see cref="P:System.Diagnostics.EventSchemaTraceListener.MaximumFileSize" /> будет достигнуто значение свойства, начинается запись в новый файл с суффиксом увеличивается целое число со знаком.
		///       </summary>
		// Token: 0x04000D0E RID: 3342
		LimitedSequentialFiles = 3,
		/// <summary>
		///         Один файл с максимально допустимый размер файла определяется <see cref="P:System.Diagnostics.EventSchemaTraceListener.MaximumFileSize" /> свойство.
		///       </summary>
		// Token: 0x04000D0F RID: 3343
		SingleFileBoundedSize,
		/// <summary>
		///         Один файл без ограничения максимального размера.
		///       </summary>
		// Token: 0x04000D10 RID: 3344
		SingleFileUnboundedSize = 2,
		/// <summary>
		///         Неограниченное число последовательных файлов, каждый из которых имеет максимальный размер файла, определяется <see cref="P:System.Diagnostics.EventSchemaTraceListener.MaximumFileSize" /> свойство.
		///          Нет нет логических границ для количества или размера файлов, но она ограничена физических ограничений, налагаемых компьютером.
		///       </summary>
		// Token: 0x04000D11 RID: 3345
		UnlimitedSequentialFiles = 0
	}
}
