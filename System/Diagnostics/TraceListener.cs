using System;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;

namespace System.Diagnostics
{
	/// <summary>Предоставляет <see langword="abstract" /> базовый класс для прослушивателей, осуществляющих мониторинг вывода трассировочной и отладочной информации.</summary>
	// Token: 0x02000231 RID: 561
	[HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
	public abstract class TraceListener : MarshalByRefObject, IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.TraceListener" />.</summary>
		// Token: 0x06001095 RID: 4245 RVA: 0x00048A78 File Offset: 0x00046C78
		protected TraceListener()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.TraceListener" /> с использованием заданного имени в качестве прослушивателя.</summary>
		/// <param name="name">Имя <see cref="T:System.Diagnostics.TraceListener" />.</param>
		// Token: 0x06001096 RID: 4246 RVA: 0x00048A8E File Offset: 0x00046C8E
		protected TraceListener(string name)
		{
			this.listenerName = name;
		}

		/// <summary>Возвращает настраиваемые атрибуты прослушивателя трассировки, определенные в файле конфигурации приложения.</summary>
		/// <returns>Объект <see cref="T:System.Collections.Specialized.StringDictionary" />, содержащий настраиваемые атрибуты для прослушивателя трассировки.</returns>
		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x00048AAB File Offset: 0x00046CAB
		public StringDictionary Attributes
		{
			get
			{
				if (this.attributes == null)
				{
					this.attributes = new StringDictionary();
				}
				return this.attributes;
			}
		}

		/// <summary>Возвращает или задает имя для данного <see cref="T:System.Diagnostics.TraceListener" />.</summary>
		/// <returns>Имя для данного <see cref="T:System.Diagnostics.TraceListener" />. Значение по умолчанию — пустая строка ("").</returns>
		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06001098 RID: 4248 RVA: 0x00048AC6 File Offset: 0x00046CC6
		// (set) Token: 0x06001099 RID: 4249 RVA: 0x00048ADC File Offset: 0x00046CDC
		public virtual string Name
		{
			get
			{
				if (this.listenerName != null)
				{
					return this.listenerName;
				}
				return "";
			}
			set
			{
				this.listenerName = value;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли прослушиватель трассировки потокобезопасным.</summary>
		/// <returns>Значение <see langword="true" />, если прослушиватель трассировки потокобезопасен; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x00003062 File Offset: 0x00001262
		public virtual bool IsThreadSafe
		{
			get
			{
				return false;
			}
		}

		/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.Diagnostics.TraceListener" />.</summary>
		// Token: 0x0600109B RID: 4251 RVA: 0x00048AE5 File Offset: 0x00046CE5
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Diagnostics.TraceListener" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x0600109C RID: 4252 RVA: 0x00003917 File Offset: 0x00001B17
		protected virtual void Dispose(bool disposing)
		{
		}

		/// <summary>Если переопределено в производном классе, закрывает выходной поток, который, таким образом, больше не принимает выходные данные трассировки и отладки.</summary>
		// Token: 0x0600109D RID: 4253 RVA: 0x00003917 File Offset: 0x00001B17
		public virtual void Close()
		{
		}

		/// <summary>Если переопределено в производном классе, очищает выходной буфер.</summary>
		// Token: 0x0600109E RID: 4254 RVA: 0x00003917 File Offset: 0x00001B17
		public virtual void Flush()
		{
		}

		/// <summary>Возвращает или задает уровень отступа.</summary>
		/// <returns>Уровень отступа. По умолчанию используется значение ноль.</returns>
		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x0600109F RID: 4255 RVA: 0x00048AF4 File Offset: 0x00046CF4
		// (set) Token: 0x060010A0 RID: 4256 RVA: 0x00048AFC File Offset: 0x00046CFC
		public int IndentLevel
		{
			get
			{
				return this.indentLevel;
			}
			set
			{
				this.indentLevel = ((value < 0) ? 0 : value);
			}
		}

		/// <summary>Возвращает или задает число пробелов в отступе.</summary>
		/// <returns>Число пробелов в отступе. По умолчанию — четыре пробела.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Происходит сбой операции Set, т.к. значение меньше 0.</exception>
		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060010A1 RID: 4257 RVA: 0x00048B0C File Offset: 0x00046D0C
		// (set) Token: 0x060010A2 RID: 4258 RVA: 0x00048B14 File Offset: 0x00046D14
		public int IndentSize
		{
			get
			{
				return this.indentSize;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("IndentSize", value, SR.GetString("The IndentSize property must be non-negative."));
				}
				this.indentSize = value;
			}
		}

		/// <summary>Получает или задает фильтр трассировки для прослушивателя трассировки.</summary>
		/// <returns>Объект производится из базового класса <see cref="T:System.Diagnostics.TraceFilter" />.</returns>
		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x00048B3C File Offset: 0x00046D3C
		// (set) Token: 0x060010A4 RID: 4260 RVA: 0x00048B44 File Offset: 0x00046D44
		[ComVisible(false)]
		public TraceFilter Filter
		{
			get
			{
				return this.filter;
			}
			set
			{
				this.filter = value;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, нужен ли отступ в выходных данных.</summary>
		/// <returns>Значение <see langword="true" />, если требуется отступ; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x00048B4D File Offset: 0x00046D4D
		// (set) Token: 0x060010A6 RID: 4262 RVA: 0x00048B55 File Offset: 0x00046D55
		protected bool NeedIndent
		{
			get
			{
				return this.needIndent;
			}
			set
			{
				this.needIndent = value;
			}
		}

		/// <summary>Возвращает или задает параметры выходных данных трассировки.</summary>
		/// <returns>Побитовое сочетание значений перечисления. Значение по умолчанию — <see cref="F:System.Diagnostics.TraceOptions.None" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Происходит сбой операции Set, т.к. значение недопустимо.</exception>
		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060010A7 RID: 4263 RVA: 0x00048B5E File Offset: 0x00046D5E
		// (set) Token: 0x060010A8 RID: 4264 RVA: 0x00048B66 File Offset: 0x00046D66
		[ComVisible(false)]
		public TraceOptions TraceOutputOptions
		{
			get
			{
				return this.traceOptions;
			}
			set
			{
				if (value >> 6 != TraceOptions.None)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.traceOptions = value;
			}
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x00048B7F File Offset: 0x00046D7F
		internal void SetAttributes(Hashtable attribs)
		{
			TraceUtils.VerifyAttributes(attribs, this.GetSupportedAttributes(), this);
			this.attributes = new StringDictionary();
			this.attributes.ReplaceHashtable(attribs);
		}

		/// <summary>Посылает сообщение об ошибке в прослушиватель, создаваемый при реализации класса <see cref="T:System.Diagnostics.TraceListener" />.</summary>
		/// <param name="message">Выдаваемое сообщение.</param>
		// Token: 0x060010AA RID: 4266 RVA: 0x00048BA5 File Offset: 0x00046DA5
		public virtual void Fail(string message)
		{
			this.Fail(message, null);
		}

		/// <summary>Выдает простое и подробное сообщение об ошибке в прослушиватель, создаваемый при реализации класса <see cref="T:System.Diagnostics.TraceListener" />.</summary>
		/// <param name="message">Выдаваемое сообщение.</param>
		/// <param name="detailMessage">Выдаваемое подробное сообщение.</param>
		// Token: 0x060010AB RID: 4267 RVA: 0x00048BB0 File Offset: 0x00046DB0
		public virtual void Fail(string message, string detailMessage)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(SR.GetString("Fail:"));
			stringBuilder.Append(" ");
			stringBuilder.Append(message);
			if (detailMessage != null)
			{
				stringBuilder.Append(" ");
				stringBuilder.Append(detailMessage);
			}
			this.WriteLine(stringBuilder.ToString());
		}

		/// <summary>Возвращает настраиваемые атрибуты, поддерживаемые прослушивателем трассировки.</summary>
		/// <returns>Строковый массив, именующий настраиваемые атрибуты, поддерживаемые прослушивателем трассировки, или <see langword="null" />, если нет никаких настраиваемых атрибутов.</returns>
		// Token: 0x060010AC RID: 4268 RVA: 0x00002F6A File Offset: 0x0000116A
		protected internal virtual string[] GetSupportedAttributes()
		{
			return null;
		}

		/// <summary>Если переопределено в производном классе, записывает заданное сообщение в прослушиватель, создаваемый в производном классе.</summary>
		/// <param name="message">Записываемое сообщение.</param>
		// Token: 0x060010AD RID: 4269
		public abstract void Write(string message);

		/// <summary>Записывает значение метода <see cref="M:System.Object.ToString" /> объекта в прослушиватель, создаваемый при реализации класса <see cref="T:System.Diagnostics.TraceListener" />.</summary>
		/// <param name="o">Объект <see cref="T:System.Object" />, для которого нужно записать полное имя класса.</param>
		// Token: 0x060010AE RID: 4270 RVA: 0x00048C0B File Offset: 0x00046E0B
		public virtual void Write(object o)
		{
			if (this.Filter != null && !this.Filter.ShouldTrace(null, "", TraceEventType.Verbose, 0, null, null, o))
			{
				return;
			}
			if (o == null)
			{
				return;
			}
			this.Write(o.ToString());
		}

		/// <summary>Записывает имя категории и сообщение в прослушиватель, создаваемый при реализации класса <see cref="T:System.Diagnostics.TraceListener" />.</summary>
		/// <param name="message">Записываемое сообщение.</param>
		/// <param name="category">Имя категории, используемое для систематизации выходных данных.</param>
		// Token: 0x060010AF RID: 4271 RVA: 0x00048C40 File Offset: 0x00046E40
		public virtual void Write(string message, string category)
		{
			if (this.Filter != null && !this.Filter.ShouldTrace(null, "", TraceEventType.Verbose, 0, message))
			{
				return;
			}
			if (category == null)
			{
				this.Write(message);
				return;
			}
			this.Write(category + ": " + ((message == null) ? string.Empty : message));
		}

		/// <summary>Записывает имя категории и значение метода <see cref="M:System.Object.ToString" /> объекта в прослушиватель, создаваемый при реализации класса <see cref="T:System.Diagnostics.TraceListener" />.</summary>
		/// <param name="o">Объект <see cref="T:System.Object" />, для которого нужно записать полное имя класса.</param>
		/// <param name="category">Имя категории, используемое для систематизации выходных данных.</param>
		// Token: 0x060010B0 RID: 4272 RVA: 0x00048C94 File Offset: 0x00046E94
		public virtual void Write(object o, string category)
		{
			if (this.Filter != null && !this.Filter.ShouldTrace(null, "", TraceEventType.Verbose, 0, category, null, o))
			{
				return;
			}
			if (category == null)
			{
				this.Write(o);
				return;
			}
			this.Write((o == null) ? "" : o.ToString(), category);
		}

		/// <summary>Записывает отступ в прослушиватель, создаваемый при реализации этого класса, и восстанавливает для свойства <see cref="P:System.Diagnostics.TraceListener.NeedIndent" /> значение <see langword="false" />.</summary>
		// Token: 0x060010B1 RID: 4273 RVA: 0x00048CE8 File Offset: 0x00046EE8
		protected virtual void WriteIndent()
		{
			this.NeedIndent = false;
			for (int i = 0; i < this.indentLevel; i++)
			{
				if (this.indentSize == 4)
				{
					this.Write("    ");
				}
				else
				{
					for (int j = 0; j < this.indentSize; j++)
					{
						this.Write(" ");
					}
				}
			}
		}

		/// <summary>Если переопределено в производном классе, записывает сообщение, заканчивающееся знаком завершения строки, в прослушиватель, создаваемый в производном классе.</summary>
		/// <param name="message">Записываемое сообщение.</param>
		// Token: 0x060010B2 RID: 4274
		public abstract void WriteLine(string message);

		/// <summary>Записывает значение метода <see cref="M:System.Object.ToString" /> объекта, заканчивающееся знаком завершения строки, в прослушиватель, создаваемый при реализации класса <see cref="T:System.Diagnostics.TraceListener" />.</summary>
		/// <param name="o">Объект <see cref="T:System.Object" />, для которого нужно записать полное имя класса.</param>
		// Token: 0x060010B3 RID: 4275 RVA: 0x00048D3F File Offset: 0x00046F3F
		public virtual void WriteLine(object o)
		{
			if (this.Filter != null && !this.Filter.ShouldTrace(null, "", TraceEventType.Verbose, 0, null, null, o))
			{
				return;
			}
			this.WriteLine((o == null) ? "" : o.ToString());
		}

		/// <summary>Записывает имя категории и сообщение, заканчивающееся знаком завершения строки, в прослушиватель, создаваемый при реализации класса <see cref="T:System.Diagnostics.TraceListener" />.</summary>
		/// <param name="message">Записываемое сообщение.</param>
		/// <param name="category">Имя категории, используемое для систематизации выходных данных.</param>
		// Token: 0x060010B4 RID: 4276 RVA: 0x00048D7C File Offset: 0x00046F7C
		public virtual void WriteLine(string message, string category)
		{
			if (this.Filter != null && !this.Filter.ShouldTrace(null, "", TraceEventType.Verbose, 0, message))
			{
				return;
			}
			if (category == null)
			{
				this.WriteLine(message);
				return;
			}
			this.WriteLine(category + ": " + ((message == null) ? string.Empty : message));
		}

		/// <summary>Записывает имя категории и значение метода <see cref="M:System.Object.ToString" /> объекта, заканчивающееся знаком завершения строки, в прослушиватель, создаваемый при реализации класса <see cref="T:System.Diagnostics.TraceListener" />.</summary>
		/// <param name="o">Объект <see cref="T:System.Object" />, для которого нужно записать полное имя класса.</param>
		/// <param name="category">Имя категории, используемое для систематизации выходных данных.</param>
		// Token: 0x060010B5 RID: 4277 RVA: 0x00048DD0 File Offset: 0x00046FD0
		public virtual void WriteLine(object o, string category)
		{
			if (this.Filter != null && !this.Filter.ShouldTrace(null, "", TraceEventType.Verbose, 0, category, null, o))
			{
				return;
			}
			this.WriteLine((o == null) ? "" : o.ToString(), category);
		}

		/// <summary>Записывает сведения трассировки, объект данных и сведения о событиях в специальные выходные данные прослушивателя.</summary>
		/// <param name="eventCache">Объект <see cref="T:System.Diagnostics.TraceEventCache" />, содержащий текущие идентификатор процесса, идентификатор потока и сведения о трассировке стека.</param>
		/// <param name="source">Имя, используемое для идентификации выходных данных, обычно имя приложения, создавшего событие трассировки.</param>
		/// <param name="eventType">Одно из значений <see cref="T:System.Diagnostics.TraceEventType" />, задающее тип события, ставшего причиной трассировки.</param>
		/// <param name="id">Числовой идентификатор события.</param>
		/// <param name="data">Выдаваемые данные трассировки.</param>
		// Token: 0x060010B6 RID: 4278 RVA: 0x00048E0C File Offset: 0x0004700C
		[ComVisible(false)]
		public virtual void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data)
		{
			if (this.Filter != null && !this.Filter.ShouldTrace(eventCache, source, eventType, id, null, null, data))
			{
				return;
			}
			this.WriteHeader(source, eventType, id);
			string message = string.Empty;
			if (data != null)
			{
				message = data.ToString();
			}
			this.WriteLine(message);
			this.WriteFooter(eventCache);
		}

		/// <summary>Записывает сведения трассировки, массив объектов данных и сведения о событии в специальные выходные данные прослушивателя.</summary>
		/// <param name="eventCache">Объект <see cref="T:System.Diagnostics.TraceEventCache" />, содержащий текущие идентификатор процесса, идентификатор потока и сведения о трассировке стека.</param>
		/// <param name="source">Имя, используемое для идентификации выходных данных, обычно имя приложения, создавшего событие трассировки.</param>
		/// <param name="eventType">Одно из значений <see cref="T:System.Diagnostics.TraceEventType" />, задающее тип события, ставшего причиной трассировки.</param>
		/// <param name="id">Числовой идентификатор события.</param>
		/// <param name="data">Выдаваемые данные массива объектов.</param>
		// Token: 0x060010B7 RID: 4279 RVA: 0x00048E64 File Offset: 0x00047064
		[ComVisible(false)]
		public virtual void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, params object[] data)
		{
			if (this.Filter != null && !this.Filter.ShouldTrace(eventCache, source, eventType, id, null, null, null, data))
			{
				return;
			}
			this.WriteHeader(source, eventType, id);
			StringBuilder stringBuilder = new StringBuilder();
			if (data != null)
			{
				for (int i = 0; i < data.Length; i++)
				{
					if (i != 0)
					{
						stringBuilder.Append(", ");
					}
					if (data[i] != null)
					{
						stringBuilder.Append(data[i].ToString());
					}
				}
			}
			this.WriteLine(stringBuilder.ToString());
			this.WriteFooter(eventCache);
		}

		/// <summary>Записывает сведения трассировки и сведения о событиях в специальные выходные данные прослушивателя.</summary>
		/// <param name="eventCache">Объект <see cref="T:System.Diagnostics.TraceEventCache" />, содержащий текущие идентификатор процесса, идентификатор потока и сведения о трассировке стека.</param>
		/// <param name="source">Имя, используемое для идентификации выходных данных, обычно имя приложения, создавшего событие трассировки.</param>
		/// <param name="eventType">Одно из значений <see cref="T:System.Diagnostics.TraceEventType" />, задающее тип события, ставшего причиной трассировки.</param>
		/// <param name="id">Числовой идентификатор события.</param>
		// Token: 0x060010B8 RID: 4280 RVA: 0x00048EEC File Offset: 0x000470EC
		[ComVisible(false)]
		public virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id)
		{
			this.TraceEvent(eventCache, source, eventType, id, string.Empty);
		}

		/// <summary>Записывает сведения трассировки, сообщение и сведения о событиях в специальные выходные данные прослушивателя.</summary>
		/// <param name="eventCache">Объект <see cref="T:System.Diagnostics.TraceEventCache" />, содержащий текущие идентификатор процесса, идентификатор потока и сведения о трассировке стека.</param>
		/// <param name="source">Имя, используемое для идентификации выходных данных, обычно имя приложения, создавшего событие трассировки.</param>
		/// <param name="eventType">Одно из значений <see cref="T:System.Diagnostics.TraceEventType" />, задающее тип события, ставшего причиной трассировки.</param>
		/// <param name="id">Числовой идентификатор события.</param>
		/// <param name="message">Записываемое сообщение.</param>
		// Token: 0x060010B9 RID: 4281 RVA: 0x00048EFE File Offset: 0x000470FE
		[ComVisible(false)]
		public virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message)
		{
			if (this.Filter != null && !this.Filter.ShouldTrace(eventCache, source, eventType, id, message))
			{
				return;
			}
			this.WriteHeader(source, eventType, id);
			this.WriteLine(message);
			this.WriteFooter(eventCache);
		}

		/// <summary>Записывает сведения трассировки, форматированный массив объектов данных и сведения о событиях в специальные выходные данные прослушивателя.</summary>
		/// <param name="eventCache">Объект <see cref="T:System.Diagnostics.TraceEventCache" />, содержащий текущие идентификатор процесса, идентификатор потока и сведения о трассировке стека.</param>
		/// <param name="source">Имя, используемое для идентификации выходных данных, обычно имя приложения, создавшего событие трассировки.</param>
		/// <param name="eventType">Одно из значений <see cref="T:System.Diagnostics.TraceEventType" />, задающее тип события, ставшего причиной трассировки.</param>
		/// <param name="id">Числовой идентификатор события.</param>
		/// <param name="format">Строка формата, не содержащая элементов формата или содержащая один либо несколько элементов формата, связанных с объектами в массиве <paramref name="args" />.</param>
		/// <param name="args">Массив <see langword="object" />, содержащий несколько объектов (или ни одного), которые необходимо отформатировать.</param>
		// Token: 0x060010BA RID: 4282 RVA: 0x00048F38 File Offset: 0x00047138
		[ComVisible(false)]
		public virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string format, params object[] args)
		{
			if (this.Filter != null && !this.Filter.ShouldTrace(eventCache, source, eventType, id, format, args))
			{
				return;
			}
			this.WriteHeader(source, eventType, id);
			if (args != null)
			{
				this.WriteLine(string.Format(CultureInfo.InvariantCulture, format, args));
			}
			else
			{
				this.WriteLine(format);
			}
			this.WriteFooter(eventCache);
		}

		/// <summary>Записывает сведения трассировки, сообщение, идентификатор сопутствующего действия и сведения о событиях в специальные выходные данные прослушивателя.</summary>
		/// <param name="eventCache">Объект <see cref="T:System.Diagnostics.TraceEventCache" />, содержащий текущие идентификатор процесса, идентификатор потока и сведения о трассировке стека.</param>
		/// <param name="source">Имя, используемое для идентификации выходных данных, обычно имя приложения, создавшего событие трассировки.</param>
		/// <param name="id">Числовой идентификатор события.</param>
		/// <param name="message">Записываемое сообщение.</param>
		/// <param name="relatedActivityId">Объект <see cref="T:System.Guid" />, идентифицирующий сопутствующее действие.</param>
		// Token: 0x060010BB RID: 4283 RVA: 0x00048F97 File Offset: 0x00047197
		[ComVisible(false)]
		public virtual void TraceTransfer(TraceEventCache eventCache, string source, int id, string message, Guid relatedActivityId)
		{
			this.TraceEvent(eventCache, source, TraceEventType.Transfer, id, message + ", relatedActivityId=" + relatedActivityId.ToString());
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x00048FC0 File Offset: 0x000471C0
		private void WriteHeader(string source, TraceEventType eventType, int id)
		{
			this.Write(string.Format(CultureInfo.InvariantCulture, "{0} {1}: {2} : ", source, eventType.ToString(), id.ToString(CultureInfo.InvariantCulture)));
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x00048FF4 File Offset: 0x000471F4
		private void WriteFooter(TraceEventCache eventCache)
		{
			if (eventCache == null)
			{
				return;
			}
			this.indentLevel++;
			if (this.IsEnabled(TraceOptions.ProcessId))
			{
				this.WriteLine("ProcessId=" + eventCache.ProcessId.ToString());
			}
			if (this.IsEnabled(TraceOptions.LogicalOperationStack))
			{
				this.Write("LogicalOperationStack=");
				Stack logicalOperationStack = eventCache.LogicalOperationStack;
				bool flag = true;
				foreach (object obj in logicalOperationStack)
				{
					if (!flag)
					{
						this.Write(", ");
					}
					else
					{
						flag = false;
					}
					this.Write(obj.ToString());
				}
				this.WriteLine(string.Empty);
			}
			if (this.IsEnabled(TraceOptions.ThreadId))
			{
				this.WriteLine("ThreadId=" + eventCache.ThreadId);
			}
			if (this.IsEnabled(TraceOptions.DateTime))
			{
				this.WriteLine("DateTime=" + eventCache.DateTime.ToString("o", CultureInfo.InvariantCulture));
			}
			if (this.IsEnabled(TraceOptions.Timestamp))
			{
				this.WriteLine("Timestamp=" + eventCache.Timestamp.ToString());
			}
			if (this.IsEnabled(TraceOptions.Callstack))
			{
				this.WriteLine("Callstack=" + eventCache.Callstack);
			}
			this.indentLevel--;
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x00049164 File Offset: 0x00047364
		internal bool IsEnabled(TraceOptions opts)
		{
			return (opts & this.TraceOutputOptions) > TraceOptions.None;
		}

		// Token: 0x040009F3 RID: 2547
		private int indentLevel;

		// Token: 0x040009F4 RID: 2548
		private int indentSize = 4;

		// Token: 0x040009F5 RID: 2549
		private TraceOptions traceOptions;

		// Token: 0x040009F6 RID: 2550
		private bool needIndent = true;

		// Token: 0x040009F7 RID: 2551
		private string listenerName;

		// Token: 0x040009F8 RID: 2552
		private TraceFilter filter;

		// Token: 0x040009F9 RID: 2553
		private StringDictionary attributes;

		// Token: 0x040009FA RID: 2554
		internal string initializeData;
	}
}
