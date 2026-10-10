using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Security.Permissions;
using System.Text;

namespace System.Diagnostics
{
	/// <summary>Направляет выходные данные трассировки или отладки в модуль записи текста, такой как модуль записи в поток или в поток, такой как файловый поток.</summary>
	// Token: 0x02000216 RID: 534
	[HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
	public class DelimitedListTraceListener : TextWriterTraceListener
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.DelimitedListTraceListener" />, с помощью которого осуществляется запись в указанный исходящий поток.</summary>
		/// <param name="stream">
		///   <see cref="T:System.IO.Stream" /> для получения выходных данных.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="stream" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000F7B RID: 3963 RVA: 0x00044D4A File Offset: 0x00042F4A
		public DelimitedListTraceListener(Stream stream) : base(stream)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.DelimitedListTraceListener" />, с помощью которого осуществляется запись в заданный исходящий поток и который имеет указанное имя.</summary>
		/// <param name="stream">
		///   <see cref="T:System.IO.Stream" /> для получения выходных данных.</param>
		/// <param name="name">Имя нового экземпляра прослушивателя трассировки.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="stream" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000F7C RID: 3964 RVA: 0x00044D69 File Offset: 0x00042F69
		public DelimitedListTraceListener(Stream stream, string name) : base(stream, name)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.DelimitedListTraceListener" />, с помощью которого осуществляется запись в указанный модуль записи текста.</summary>
		/// <param name="writer">
		///   <see cref="T:System.IO.TextWriter" /> для получения выходных данных.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="writer" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000F7D RID: 3965 RVA: 0x00044D89 File Offset: 0x00042F89
		public DelimitedListTraceListener(TextWriter writer) : base(writer)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.DelimitedListTraceListener" />, с помощью которого осуществляется запись в заданный модуль записи текста и который имеет указанное имя.</summary>
		/// <param name="writer">
		///   <see cref="T:System.IO.TextWriter" /> для получения выходных данных.</param>
		/// <param name="name">Имя нового экземпляра прослушивателя трассировки.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="writer" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000F7E RID: 3966 RVA: 0x00044DA8 File Offset: 0x00042FA8
		public DelimitedListTraceListener(TextWriter writer, string name) : base(writer, name)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.DelimitedListTraceListener" /> с помощью которого осуществляется запись в указанный файл.</summary>
		/// <param name="fileName">Имя файла, предназначенного для получения выходных данных.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="fileName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000F7F RID: 3967 RVA: 0x00044DC8 File Offset: 0x00042FC8
		public DelimitedListTraceListener(string fileName) : base(fileName)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.DelimitedListTraceListener" />, с помощью которого осуществляется запись в заданный файл и который имеет указанное имя.</summary>
		/// <param name="fileName">Имя файла, предназначенного для получения выходных данных.</param>
		/// <param name="name">Имя нового экземпляра прослушивателя трассировки.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="fileName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000F80 RID: 3968 RVA: 0x00044DE7 File Offset: 0x00042FE7
		public DelimitedListTraceListener(string fileName, string name) : base(fileName, name)
		{
		}

		/// <summary>Возвращает или задает разделитель для разделенного списка.</summary>
		/// <returns>Разделитель для разделенного списка.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметру <see cref="P:System.Diagnostics.DelimitedListTraceListener.Delimiter" /> задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойству <see cref="P:System.Diagnostics.DelimitedListTraceListener.Delimiter" /> задана пустая строка ("").</exception>
		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000F81 RID: 3969 RVA: 0x00044E08 File Offset: 0x00043008
		// (set) Token: 0x06000F82 RID: 3970 RVA: 0x00044E7C File Offset: 0x0004307C
		public string Delimiter
		{
			get
			{
				lock (this)
				{
					if (!this.initializedDelim)
					{
						if (base.Attributes.ContainsKey("delimiter"))
						{
							this.delimiter = base.Attributes["delimiter"];
						}
						this.initializedDelim = true;
					}
				}
				return this.delimiter;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("Delimiter");
				}
				if (value.Length == 0)
				{
					throw new ArgumentException(SR.GetString("Generic_ArgCantBeEmptyString", new object[]
					{
						"Delimiter"
					}));
				}
				lock (this)
				{
					this.delimiter = value;
					this.initializedDelim = true;
				}
				if (this.delimiter == ",")
				{
					this.secondaryDelim = ";";
					return;
				}
				this.secondaryDelim = ",";
			}
		}

		/// <summary>Возвращает атрибут пользовательского файла конфигурации, поддерживаемый прослушивателем трассировки с разделителями.</summary>
		/// <returns>Строковый массив, содержащий единственное значение "delimiter".</returns>
		// Token: 0x06000F83 RID: 3971 RVA: 0x00044F1C File Offset: 0x0004311C
		protected internal override string[] GetSupportedAttributes()
		{
			return new string[]
			{
				"delimiter"
			};
		}

		/// <summary>Записывает сведения трассировки, форматированный массив объектов данных и сведения о событии в исходящий файл или поток.</summary>
		/// <param name="eventCache">Объект <see cref="T:System.Diagnostics.TraceEventCache" />, содержащий текущие идентификатор процесса, идентификатор потока и сведения о трассировке стека.</param>
		/// <param name="source">Имя, используемое для идентификации выходных данных, обычно имя приложения, создавшего событие трассировки.</param>
		/// <param name="eventType">Одно из значений <see cref="T:System.Diagnostics.TraceEventType" />, задающее тип события, ставшего причиной трассировки.</param>
		/// <param name="id">Числовой идентификатор события.</param>
		/// <param name="format">Строка форматирования, содержащая 0 или больше элементов форматирования, соответствующих объектам в массиве <paramref name="args" />.</param>
		/// <param name="args">Массив, содержащий несколько (или ни одного) объектов, которые необходимо отформатировать.</param>
		// Token: 0x06000F84 RID: 3972 RVA: 0x00044F2C File Offset: 0x0004312C
		public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string format, params object[] args)
		{
			if (base.Filter != null && !base.Filter.ShouldTrace(eventCache, source, eventType, id, format, args))
			{
				return;
			}
			this.WriteHeader(source, eventType, id);
			if (args != null)
			{
				this.WriteEscaped(string.Format(CultureInfo.InvariantCulture, format, args));
			}
			else
			{
				this.WriteEscaped(format);
			}
			this.Write(this.Delimiter);
			this.Write(this.Delimiter);
			this.WriteFooter(eventCache);
		}

		/// <summary>Записывает сведения трассировки, сообщение и сведения о событии в исходящий файл или поток.</summary>
		/// <param name="eventCache">Объект <see cref="T:System.Diagnostics.TraceEventCache" />, содержащий текущие идентификатор процесса, идентификатор потока и сведения о трассировке стека.</param>
		/// <param name="source">Имя, используемое для идентификации выходных данных, обычно имя приложения, создавшего событие трассировки.</param>
		/// <param name="eventType">Одно из значений <see cref="T:System.Diagnostics.TraceEventType" />, задающее тип события, ставшего причиной трассировки.</param>
		/// <param name="id">Числовой идентификатор события.</param>
		/// <param name="message">Сообщение трассировки для записи в исходящий файл или поток.</param>
		// Token: 0x06000F85 RID: 3973 RVA: 0x00044FA4 File Offset: 0x000431A4
		public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message)
		{
			if (base.Filter != null && !base.Filter.ShouldTrace(eventCache, source, eventType, id, message))
			{
				return;
			}
			this.WriteHeader(source, eventType, id);
			this.WriteEscaped(message);
			this.Write(this.Delimiter);
			this.Write(this.Delimiter);
			this.WriteFooter(eventCache);
		}

		/// <summary>Записывает сведения трассировки, объект данных и сведения о событии в исходящий файл или поток.</summary>
		/// <param name="eventCache">Объект <see cref="T:System.Diagnostics.TraceEventCache" />, содержащий текущие идентификатор процесса, идентификатор потока и сведения о трассировке стека.</param>
		/// <param name="source">Имя, используемое для идентификации выходных данных, обычно имя приложения, создавшего событие трассировки.</param>
		/// <param name="eventType">Одно из значений <see cref="T:System.Diagnostics.TraceEventType" />, задающее тип события, ставшего причиной трассировки.</param>
		/// <param name="id">Числовой идентификатор события.</param>
		/// <param name="data">Объект данных для записи в исходящий файл или поток.</param>
		// Token: 0x06000F86 RID: 3974 RVA: 0x00045000 File Offset: 0x00043200
		public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data)
		{
			if (base.Filter != null && !base.Filter.ShouldTrace(eventCache, source, eventType, id, null, null, data))
			{
				return;
			}
			this.WriteHeader(source, eventType, id);
			this.Write(this.Delimiter);
			this.WriteEscaped(data.ToString());
			this.Write(this.Delimiter);
			this.WriteFooter(eventCache);
		}

		/// <summary>Записывает сведения трассировки, массив объектов данных и сведения о событии в выходной файл или поток.</summary>
		/// <param name="eventCache">Объект <see cref="T:System.Diagnostics.TraceEventCache" />, содержащий текущие идентификатор процесса, идентификатор потока и сведения о трассировке стека.</param>
		/// <param name="source">Имя, используемое для идентификации выходных данных, обычно имя приложения, создавшего событие трассировки.</param>
		/// <param name="eventType">Одно из значений <see cref="T:System.Diagnostics.TraceEventType" />, задающее тип события, ставшего причиной трассировки.</param>
		/// <param name="id">Числовой идентификатор события.</param>
		/// <param name="data">Массив объектов данных для записи в исходящий файл или поток.</param>
		// Token: 0x06000F87 RID: 3975 RVA: 0x00045064 File Offset: 0x00043264
		public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, params object[] data)
		{
			if (base.Filter != null && !base.Filter.ShouldTrace(eventCache, source, eventType, id, null, null, null, data))
			{
				return;
			}
			this.WriteHeader(source, eventType, id);
			this.Write(this.Delimiter);
			if (data != null)
			{
				for (int i = 0; i < data.Length; i++)
				{
					if (i != 0)
					{
						this.Write(this.secondaryDelim);
					}
					this.WriteEscaped(data[i].ToString());
				}
			}
			this.Write(this.Delimiter);
			this.WriteFooter(eventCache);
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x000450EC File Offset: 0x000432EC
		private void WriteHeader(string source, TraceEventType eventType, int id)
		{
			this.WriteEscaped(source);
			this.Write(this.Delimiter);
			this.Write(eventType.ToString());
			this.Write(this.Delimiter);
			this.Write(id.ToString(CultureInfo.InvariantCulture));
			this.Write(this.Delimiter);
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x0004514C File Offset: 0x0004334C
		private void WriteFooter(TraceEventCache eventCache)
		{
			if (eventCache != null)
			{
				if (base.IsEnabled(TraceOptions.ProcessId))
				{
					this.Write(eventCache.ProcessId.ToString(CultureInfo.InvariantCulture));
				}
				this.Write(this.Delimiter);
				if (base.IsEnabled(TraceOptions.LogicalOperationStack))
				{
					this.WriteStackEscaped(eventCache.LogicalOperationStack);
				}
				this.Write(this.Delimiter);
				if (base.IsEnabled(TraceOptions.ThreadId))
				{
					this.WriteEscaped(eventCache.ThreadId.ToString(CultureInfo.InvariantCulture));
				}
				this.Write(this.Delimiter);
				if (base.IsEnabled(TraceOptions.DateTime))
				{
					this.WriteEscaped(eventCache.DateTime.ToString("o", CultureInfo.InvariantCulture));
				}
				this.Write(this.Delimiter);
				if (base.IsEnabled(TraceOptions.Timestamp))
				{
					this.Write(eventCache.Timestamp.ToString(CultureInfo.InvariantCulture));
				}
				this.Write(this.Delimiter);
				if (base.IsEnabled(TraceOptions.Callstack))
				{
					this.WriteEscaped(eventCache.Callstack);
				}
			}
			else
			{
				for (int i = 0; i < 5; i++)
				{
					this.Write(this.Delimiter);
				}
			}
			this.WriteLine("");
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00045278 File Offset: 0x00043478
		private void WriteEscaped(string message)
		{
			if (!string.IsNullOrEmpty(message))
			{
				StringBuilder stringBuilder = new StringBuilder("\"");
				int num = 0;
				int num2;
				while ((num2 = message.IndexOf('"', num)) != -1)
				{
					stringBuilder.Append(message, num, num2 - num);
					stringBuilder.Append("\"\"");
					num = num2 + 1;
				}
				stringBuilder.Append(message, num, message.Length - num);
				stringBuilder.Append("\"");
				this.Write(stringBuilder.ToString());
			}
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x000452F0 File Offset: 0x000434F0
		private void WriteStackEscaped(Stack stack)
		{
			StringBuilder stringBuilder = new StringBuilder("\"");
			bool flag = true;
			foreach (object obj in stack)
			{
				if (!flag)
				{
					stringBuilder.Append(", ");
				}
				else
				{
					flag = false;
				}
				string text = obj.ToString();
				int num = 0;
				int num2;
				while ((num2 = text.IndexOf('"', num)) != -1)
				{
					stringBuilder.Append(text, num, num2 - num);
					stringBuilder.Append("\"\"");
					num = num2 + 1;
				}
				stringBuilder.Append(text, num, text.Length - num);
			}
			stringBuilder.Append("\"");
			this.Write(stringBuilder.ToString());
		}

		// Token: 0x04000991 RID: 2449
		private string delimiter = ";";

		// Token: 0x04000992 RID: 2450
		private string secondaryDelim = ",";

		// Token: 0x04000993 RID: 2451
		private bool initializedDelim;
	}
}
