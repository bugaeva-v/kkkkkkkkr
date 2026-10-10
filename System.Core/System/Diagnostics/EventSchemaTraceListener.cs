using System;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics
{
	/// <summary>
	///         Направляет результаты трассировки или отладки сквозных событий в совместимый со схемой файл журнала в XML-представлении.
	///       </summary>
	// Token: 0x0200038A RID: 906
	[HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public class EventSchemaTraceListener : TextWriterTraceListener
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.EventSchemaTraceListener" />, используя указанный файл в качестве получателя выходных данных отладки и трассировки.
		///       </summary>
		/// <param name="fileName">
		///           Путь к файлу журнала.
		///         </param>
		// Token: 0x06001B2E RID: 6958 RVA: 0x0000235B File Offset: 0x0000055B
		public EventSchemaTraceListener(string fileName)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.EventSchemaTraceListener" /> заданным именем, используя указанный файл в качестве получателя выходных данных отладки и трассировки.
		///       </summary>
		/// <param name="fileName">
		///           Путь к файлу журнала.
		///         </param>
		/// <param name="name">
		///           Имя прослушивателя.
		///         </param>
		// Token: 0x06001B2F RID: 6959 RVA: 0x0000235B File Offset: 0x0000055B
		public EventSchemaTraceListener(string fileName, string name)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.EventSchemaTraceListener" /> заданным именем и указанным размером буфера, используя указанный файл в качестве получателя выходных данных отладки и трассировки.
		///       </summary>
		/// <param name="fileName">
		///           Путь к файлу журнала.
		///         </param>
		/// <param name="name">
		///           Имя прослушивателя.
		///         </param>
		/// <param name="bufferSize">
		///           Размер выходного буфера в байтах.
		///         </param>
		// Token: 0x06001B30 RID: 6960 RVA: 0x0000235B File Offset: 0x0000055B
		public EventSchemaTraceListener(string fileName, string name, int bufferSize)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.EventSchemaTraceListener" /> заданным именем и указанным размером буфера, используя указанный файл с заданной политикой хранения журнала в качестве получателя выходных данных отладки и трассировки.
		///       </summary>
		/// <param name="fileName">
		///           Путь к файлу журнала.
		///         </param>
		/// <param name="name">
		///           Имя прослушивателя.
		///         </param>
		/// <param name="bufferSize">
		///           Размер выходного буфера в байтах.
		///         </param>
		/// <param name="logRetentionOption">
		///           Одно из значений <see cref="T:System.Diagnostics.TraceLogRetentionOption" />.
		///         </param>
		// Token: 0x06001B31 RID: 6961 RVA: 0x0000235B File Offset: 0x0000055B
		public EventSchemaTraceListener(string fileName, string name, int bufferSize, TraceLogRetentionOption logRetentionOption)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.EventSchemaTraceListener" /> заданным именем и указанным размером буфера, используя указанный файл с заданной политикой хранения и максимальным размером журнала в качестве получателя выходных данных отладки и трассировки.
		///       </summary>
		/// <param name="fileName">
		///           Путь к файлу журнала.
		///         </param>
		/// <param name="name">
		///           Имя прослушивателя.
		///         </param>
		/// <param name="bufferSize">
		///           Размер выходного буфера в байтах.
		///         </param>
		/// <param name="logRetentionOption">
		///           Одно из значений <see cref="T:System.Diagnostics.TraceLogRetentionOption" />.
		///         </param>
		/// <param name="maximumFileSize">
		///           Максимальный размер файла в байтах.
		///         </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Значение <paramref name="maximumFileSize" /> меньше <paramref name="bufferSize" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="maximumFileSize" /> является отрицательным числом.
		///           </exception>
		// Token: 0x06001B32 RID: 6962 RVA: 0x0000235B File Offset: 0x0000055B
		public EventSchemaTraceListener(string fileName, string name, int bufferSize, TraceLogRetentionOption logRetentionOption, long maximumFileSize)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.EventSchemaTraceListener" /> заданным именем и указанным размером буфера, используя в качестве получателя выходных данных отладки и трассировки указанный файл с заданной политикой хранения и максимальным размером журнала, а также счетчиком файлов.
		///       </summary>
		/// <param name="fileName">
		///           Путь к файлу журнала.
		///         </param>
		/// <param name="name">
		///           Имя прослушивателя.
		///         </param>
		/// <param name="bufferSize">
		///           Размер выходного буфера в байтах.
		///         </param>
		/// <param name="logRetentionOption">
		///           Одно из значений <see cref="T:System.Diagnostics.TraceLogRetentionOption" />.
		///         </param>
		/// <param name="maximumFileSize">
		///           Максимальный размер файла в байтах.
		///         </param>
		/// <param name="maximumNumberOfFiles">
		///           Максимальное количество выходных файлов журнала.
		///         </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Значение <paramref name="maximumFileSize" /> меньше <paramref name="bufferSize" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="maximumFileSize" /> является отрицательным числом.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="maximumNumberOfFiles" /> меньше 1 и <paramref name="logRetentionOption" /> — <see cref="F:System.Diagnostics.TraceLogRetentionOption.LimitedSequentialFiles" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="maximumNumberOfFiles" /> меньше 2 и <paramref name="logRetentionOption" /> — <see cref="F:System.Diagnostics.TraceLogRetentionOption.LimitedCircularFiles" />.
		///           </exception>
		// Token: 0x06001B33 RID: 6963 RVA: 0x0000235B File Offset: 0x0000055B
		public EventSchemaTraceListener(string fileName, string name, int bufferSize, TraceLogRetentionOption logRetentionOption, long maximumFileSize, int maximumNumberOfFiles)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Возвращает размер выходного буфера.
		///       </summary>
		/// <returns>
		///         Размер выходного буфера в байтах.
		///       </returns>
		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06001B34 RID: 6964 RVA: 0x0005A294 File Offset: 0x00058494
		public int BufferSize
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}

		/// <summary>
		///         Возвращает максимальный размер файла журнала.
		///       </summary>
		/// <returns>
		///         Максимальный размер файла в байтах.
		///       </returns>
		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06001B35 RID: 6965 RVA: 0x0005A2B0 File Offset: 0x000584B0
		public long MaximumFileSize
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0L;
			}
		}

		/// <summary>
		///         Возвращает максимальное количество файлов журнала.
		///       </summary>
		/// <returns>
		///         Максимальное количество файлов журнала, определяемое значением свойства <see cref="P:System.Diagnostics.EventSchemaTraceListener.TraceLogRetentionOption" /> файла.
		///       </returns>
		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06001B36 RID: 6966 RVA: 0x0005A2CC File Offset: 0x000584CC
		public int MaximumNumberOfFiles
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}

		/// <summary>
		///         Возвращает для файла параметр хранения журнала трассировки.
		///       </summary>
		/// <returns>
		///         Одно из значений перечисления <see cref="T:System.Diagnostics.TraceLogRetentionOption" />.
		///          Значение по умолчанию — <see cref="F:System.Diagnostics.TraceLogRetentionOption.SingleFileUnboundedSize" />.
		///       </returns>
		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001B37 RID: 6967 RVA: 0x0005A2E8 File Offset: 0x000584E8
		public TraceLogRetentionOption TraceLogRetentionOption
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return TraceLogRetentionOption.UnlimitedSequentialFiles;
			}
		}
	}
}
