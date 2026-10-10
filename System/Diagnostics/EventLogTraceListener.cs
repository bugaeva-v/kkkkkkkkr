using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Diagnostics
{
	/// <summary>Предоставляет простой прослушиватель, который направляет вывод отладки или трассировки в журнал <see cref="T:System.Diagnostics.EventLog" />.</summary>
	// Token: 0x02000265 RID: 613
	[PermissionSet(SecurityAction.LinkDemand, Unrestricted = true)]
	public sealed class EventLogTraceListener : TraceListener
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.EventLogTraceListener" /> без прослушивателя трассировки.</summary>
		// Token: 0x0600132A RID: 4906 RVA: 0x00046FA4 File Offset: 0x000451A4
		public EventLogTraceListener()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.EventLogTraceListener" /> с помощью указанного журнала событий.</summary>
		/// <param name="eventLog">Журнал событий, в который производится запись.</param>
		// Token: 0x0600132B RID: 4907 RVA: 0x00051167 File Offset: 0x0004F367
		public EventLogTraceListener(EventLog eventLog)
		{
			if (eventLog == null)
			{
				throw new ArgumentNullException("eventLog");
			}
			this.event_log = eventLog;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.EventLogTraceListener" />, используя указанный источник.</summary>
		/// <param name="source">Имя существующего источника журнала событий.</param>
		// Token: 0x0600132C RID: 4908 RVA: 0x00051184 File Offset: 0x0004F384
		public EventLogTraceListener(string source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			this.event_log = new EventLog();
			this.event_log.Source = source;
		}

		/// <summary>Получает или задает журнал событий для записи.</summary>
		/// <returns>Журнал событий, в который производится запись.</returns>
		// Token: 0x1700037B RID: 891
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x000511B1 File Offset: 0x0004F3B1
		// (set) Token: 0x0600132E RID: 4910 RVA: 0x000511B9 File Offset: 0x0004F3B9
		public EventLog EventLog
		{
			get
			{
				return this.event_log;
			}
			set
			{
				this.event_log = value;
			}
		}

		/// <summary>Получает или задает имя данного объекта <see cref="T:System.Diagnostics.EventLogTraceListener" />.</summary>
		/// <returns>Имя этого прослушивателя трассировки.</returns>
		// Token: 0x1700037C RID: 892
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x000511C2 File Offset: 0x0004F3C2
		// (set) Token: 0x06001330 RID: 4912 RVA: 0x000511DE File Offset: 0x0004F3DE
		public override string Name
		{
			get
			{
				if (this.name == null)
				{
					return this.event_log.Source;
				}
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		/// <summary>Закрывает журнал событий; таким образом журнал больше не получает выходных данных трассировки или отладки.</summary>
		// Token: 0x06001331 RID: 4913 RVA: 0x000511E7 File Offset: 0x0004F3E7
		public override void Close()
		{
			this.event_log.Close();
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x000511F4 File Offset: 0x0004F3F4
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.event_log.Dispose();
			}
		}

		/// <summary>Записывает сообщение в журнал событий для данного экземпляра.</summary>
		/// <param name="message">Сообщение для записи.</param>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="message" /> превышает 32,766 символов.</exception>
		// Token: 0x06001333 RID: 4915 RVA: 0x00051204 File Offset: 0x0004F404
		public override void Write(string message)
		{
			this.TraceData(new TraceEventCache(), this.event_log.Source, TraceEventType.Information, 0, message);
		}

		/// <summary>Записывает сообщение в журнал событий для данного экземпляра.</summary>
		/// <param name="message">Сообщение для записи.</param>
		/// <exception cref="T:System.ArgumentException">Длина параметра <paramref name="message" /> превышает 32,766 символов.</exception>
		// Token: 0x06001334 RID: 4916 RVA: 0x0005121F File Offset: 0x0004F41F
		public override void WriteLine(string message)
		{
			this.Write(message);
		}

		/// <summary>Записывает информацию трассировки, объект данных и информацию о событиях в журнал событий.</summary>
		/// <param name="eventCache">Объект, содержащий текущие идентификаторы процесса и потока, а также сведения о трассировке стека.</param>
		/// <param name="source">Имя, используемое для идентификации выходных данных, обычно имя приложения, создавшего событие трассировки.</param>
		/// <param name="severity">Одно из значений перечисления, с помощью которого задается тип события, вызвавшего трассировку.</param>
		/// <param name="id">Числовой идентификатор события. Сочетание <paramref name="source" /> и <paramref name="id" /> уникально идентифицирует событие.</param>
		/// <param name="data">Объект данных для записи в исходящий файл или поток.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="source" /> не задан.  
		/// -или- 
		/// Длина строки записи журнала превышает 32766 знаков.</exception>
		// Token: 0x06001335 RID: 4917 RVA: 0x00051228 File Offset: 0x0004F428
		[ComVisible(false)]
		public override void TraceData(TraceEventCache eventCache, string source, TraceEventType severity, int id, object data)
		{
			EventLogEntryType type;
			if (severity - TraceEventType.Critical > 1)
			{
				if (severity != TraceEventType.Warning)
				{
					type = EventLogEntryType.Information;
				}
				else
				{
					type = EventLogEntryType.Warning;
				}
			}
			else
			{
				type = EventLogEntryType.Error;
			}
			this.event_log.WriteEntry((data != null) ? data.ToString() : string.Empty, type, id, 0);
		}

		/// <summary>Записывает информацию трассировки, массив объектов данных и информацию о событиях в журнал событий.</summary>
		/// <param name="eventCache">Объект, содержащий текущие идентификаторы процесса и потока, а также сведения о трассировке стека.</param>
		/// <param name="source">Имя, используемое для идентификации выходных данных, обычно имя приложения, создавшего событие трассировки.</param>
		/// <param name="severity">Одно из значений перечисления, с помощью которого задается тип события, вызвавшего трассировку.</param>
		/// <param name="id">Числовой идентификатор события. Сочетание <paramref name="source" /> и <paramref name="id" /> уникально идентифицирует событие.</param>
		/// <param name="data">Массив объектов данных.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="source" /> не задан.  
		/// -или- 
		/// Длина строки записи журнала превышает 32766 знаков.</exception>
		// Token: 0x06001336 RID: 4918 RVA: 0x0005126C File Offset: 0x0004F46C
		[ComVisible(false)]
		public override void TraceData(TraceEventCache eventCache, string source, TraceEventType severity, int id, params object[] data)
		{
			string data2 = string.Empty;
			if (data != null)
			{
				string[] array = new string[data.Length];
				for (int i = 0; i < data.Length; i++)
				{
					array[i] = ((data[i] != null) ? data[i].ToString() : string.Empty);
				}
				data2 = string.Join(", ", array);
			}
			this.TraceData(eventCache, source, severity, id, data2);
		}

		/// <summary>Записывает информацию трассировки, сообщение и информацию о событиях в журнал событий.</summary>
		/// <param name="eventCache">Объект, содержащий текущие идентификаторы процесса и потока, а также сведения о трассировке стека.</param>
		/// <param name="source">Имя, используемое для идентификации выходных данных, обычно имя приложения, создавшего событие трассировки.</param>
		/// <param name="severity">Одно из значений перечисления, с помощью которого задается тип события, вызвавшего трассировку.</param>
		/// <param name="id">Числовой идентификатор события. Сочетание <paramref name="source" /> и <paramref name="id" /> уникально идентифицирует событие.</param>
		/// <param name="message">Сообщение трассировки.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="source" /> не задан.  
		/// -или- 
		/// Длина строки записи журнала превышает 32766 знаков.</exception>
		// Token: 0x06001337 RID: 4919 RVA: 0x000512CD File Offset: 0x0004F4CD
		[ComVisible(false)]
		public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType severity, int id, string message)
		{
			this.TraceData(eventCache, source, severity, id, message);
		}

		/// <summary>Записывает информацию трассировки, форматированный массив объектов и информацию о событиях в журнал событий.</summary>
		/// <param name="eventCache">Объект, содержащий текущие идентификаторы процесса и потока, а также сведения о трассировке стека.</param>
		/// <param name="source">Имя, используемое для идентификации выходных данных, обычно имя приложения, создавшего событие трассировки.</param>
		/// <param name="severity">Одно из значений перечисления, с помощью которого задается тип события, вызвавшего трассировку.</param>
		/// <param name="id">Числовой идентификатор события. Сочетание <paramref name="source" /> и <paramref name="id" /> уникально идентифицирует событие.</param>
		/// <param name="format">Строка форматирования, содержащая 0 или несколько элементов форматирования, связанных с объектами в массиве <paramref name="args" />.</param>
		/// <param name="args">Массив <see langword="object" />, содержащий несколько (или ни одного) объектов, которые необходимо форматировать.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="source" /> не задан.  
		/// -или- 
		/// Длина строки записи журнала превышает 32766 знаков.</exception>
		// Token: 0x06001338 RID: 4920 RVA: 0x000512DC File Offset: 0x0004F4DC
		[ComVisible(false)]
		public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType severity, int id, string format, params object[] args)
		{
			this.TraceEvent(eventCache, source, severity, id, (format != null) ? string.Format(format, args) : null);
		}

		// Token: 0x04000ADC RID: 2780
		private EventLog event_log;

		// Token: 0x04000ADD RID: 2781
		private string name;
	}
}
