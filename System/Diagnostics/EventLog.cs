using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	/// <summary>Обеспечивает взаимодействие с журналами событий Windows.</summary>
	// Token: 0x02000259 RID: 601
	[InstallerType(typeof(EventLogInstaller))]
	[MonitoringDescription("Represents an event log")]
	[DefaultEvent("EntryWritten")]
	public class EventLog : Component, ISupportInitialize
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.EventLog" />. Не связывает экземпляр с каким-либо журналом.</summary>
		// Token: 0x06001280 RID: 4736 RVA: 0x0004FCB8 File Offset: 0x0004DEB8
		public EventLog() : this(string.Empty)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.EventLog" />. Связывает экземпляр с журналом на локальном компьютере.</summary>
		/// <param name="logName">Имя журнала на локальном компьютере.</param>
		/// <exception cref="T:System.ArgumentNullException">Имя журнала <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Недопустимое имя журнала.</exception>
		// Token: 0x06001281 RID: 4737 RVA: 0x0004FCC5 File Offset: 0x0004DEC5
		public EventLog(string logName) : this(logName, ".")
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.EventLog" />. Связывает экземпляр с журналом на указанном компьютере.</summary>
		/// <param name="logName">Имя журнала на указанном компьютере.</param>
		/// <param name="machineName">Компьютер, на котором существует журнал.</param>
		/// <exception cref="T:System.ArgumentNullException">Имя журнала <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Недопустимое имя журнала.  
		/// -или- 
		/// Недопустимое имя компьютера.</exception>
		// Token: 0x06001282 RID: 4738 RVA: 0x0004FCD3 File Offset: 0x0004DED3
		public EventLog(string logName, string machineName) : this(logName, machineName, string.Empty)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.EventLog" />. Связывает экземпляр с журналом на указанном компьютере и создает или присваивает заданный источник классу <see cref="T:System.Diagnostics.EventLog" />.</summary>
		/// <param name="logName">Имя журнала на указанном компьютере</param>
		/// <param name="machineName">Компьютер, на котором существует журнал.</param>
		/// <param name="source">Источник записей журнала событий.</param>
		/// <exception cref="T:System.ArgumentNullException">Имя журнала <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Недопустимое имя журнала.  
		/// -или- 
		/// Недопустимое имя компьютера.</exception>
		// Token: 0x06001283 RID: 4739 RVA: 0x0004FCE4 File Offset: 0x0004DEE4
		public EventLog(string logName, string machineName, string source)
		{
			if (logName == null)
			{
				throw new ArgumentNullException("logName");
			}
			if (machineName == null || machineName.Trim().Length == 0)
			{
				throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "Invalid value '{0}' for parameter 'machineName'.", machineName));
			}
			this.source = source;
			this.machineName = machineName;
			this.logName = logName;
			this.Impl = EventLog.CreateEventLogImpl(this);
		}

		/// <summary>Возвращает или задает значение, определяющее, получает ли класс <see cref="T:System.Diagnostics.EventLog" /> уведомления о событии <see cref="E:System.Diagnostics.EventLog.EntryWritten" />.</summary>
		/// <returns>Значение <see langword="true" />, если класс <see cref="T:System.Diagnostics.EventLog" /> получает уведомления при внесении записи в журнал; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Журнал событий на удаленном компьютере.</exception>
		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06001284 RID: 4740 RVA: 0x0004FD4C File Offset: 0x0004DF4C
		// (set) Token: 0x06001285 RID: 4741 RVA: 0x0004FD54 File Offset: 0x0004DF54
		[Browsable(false)]
		[DefaultValue(false)]
		[MonitoringDescription("If enabled raises event when a log is written.")]
		public bool EnableRaisingEvents
		{
			get
			{
				return this.doRaiseEvents;
			}
			set
			{
				if (value == this.doRaiseEvents)
				{
					return;
				}
				if (value)
				{
					this.Impl.EnableNotification();
				}
				else
				{
					this.Impl.DisableNotification();
				}
				this.doRaiseEvents = value;
			}
		}

		/// <summary>Возвращает содержимое журнала событий.</summary>
		/// <returns>Класс <see cref="T:System.Diagnostics.EventLogEntryCollection" />, в котором хранятся записи журнала событий. Каждая запись связана с экземпляром класса <see cref="T:System.Diagnostics.EventLogEntry" />.</returns>
		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06001286 RID: 4742 RVA: 0x0004FD82 File Offset: 0x0004DF82
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The entries in the log.")]
		public EventLogEntryCollection Entries
		{
			get
			{
				return new EventLogEntryCollection(this.Impl);
			}
		}

		/// <summary>Возвращает или задает имя журнала, из которого производится чтение или запись.</summary>
		/// <returns>Имя журнала. Существуют следующие имена: журнал приложения, журнал системы, журнал безопасности или имя, указанное пользователем. Значение по умолчанию — пустая строка ("").</returns>
		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06001287 RID: 4743 RVA: 0x0004FD8F File Offset: 0x0004DF8F
		// (set) Token: 0x06001288 RID: 4744 RVA: 0x0004FDB4 File Offset: 0x0004DFB4
		[ReadOnly(true)]
		[DefaultValue("")]
		[RecommendedAsConfigurable(true)]
		[TypeConverter("System.Diagnostics.Design.LogConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[MonitoringDescription("Name of the log that is read and written.")]
		public string Log
		{
			get
			{
				if (this.source != null && this.source.Length > 0)
				{
					return this.GetLogName();
				}
				return this.logName;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				if (string.Compare(this.logName, value, true) != 0)
				{
					this.logName = value;
					this.Reset();
				}
			}
		}

		/// <summary>Возвращает понятное имя журнала событий.</summary>
		/// <returns>Имя, представляющее журнал событий в "Просмотре событий".</returns>
		/// <exception cref="T:System.InvalidOperationException">Параметр <see cref="P:System.Diagnostics.EventLog.Log" /> отсутствует в реестре для этого компьютера.</exception>
		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x0004FDE0 File Offset: 0x0004DFE0
		[Browsable(false)]
		public string LogDisplayName
		{
			get
			{
				return this.Impl.LogDisplayName;
			}
		}

		/// <summary>Возвращает или задает имя компьютера, на котором производится чтение или запись событий.</summary>
		/// <returns>Имя сервера, на котором находится журнал событий. Значение по умолчанию — локальный компьютер (".").</returns>
		/// <exception cref="T:System.ArgumentException">Недопустимое имя компьютера.</exception>
		// Token: 0x17000352 RID: 850
		// (get) Token: 0x0600128A RID: 4746 RVA: 0x0004FDED File Offset: 0x0004DFED
		// (set) Token: 0x0600128B RID: 4747 RVA: 0x0004FDF8 File Offset: 0x0004DFF8
		[RecommendedAsConfigurable(true)]
		[DefaultValue(".")]
		[ReadOnly(true)]
		[MonitoringDescription("Name of the machine that this log get written to.")]
		public string MachineName
		{
			get
			{
				return this.machineName;
			}
			set
			{
				if (value == null || value.Trim().Length == 0)
				{
					throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "Invalid value {0} for property MachineName.", value));
				}
				if (string.Compare(this.machineName, value, true) != 0)
				{
					this.Close();
					this.machineName = value;
				}
			}
		}

		/// <summary>Возвращает или задает имя источника, регистрируемого в журнале и используемого при записи в журнал событий.</summary>
		/// <returns>Имя, регистрируемое в журнале событий как имя источника записей. Значение по умолчанию — пустая строка ("").</returns>
		/// <exception cref="T:System.ArgumentException">При таком имени источника длина пути к разделу реестра превышает 254 символа.</exception>
		// Token: 0x17000353 RID: 851
		// (get) Token: 0x0600128C RID: 4748 RVA: 0x0004FE47 File Offset: 0x0004E047
		// (set) Token: 0x0600128D RID: 4749 RVA: 0x0004FE50 File Offset: 0x0004E050
		[ReadOnly(true)]
		[DefaultValue("")]
		[MonitoringDescription("The application name that writes the log.")]
		[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[RecommendedAsConfigurable(true)]
		public string Source
		{
			get
			{
				return this.source;
			}
			set
			{
				if (value == null)
				{
					value = string.Empty;
				}
				if (this.source == null || (this.source.Length == 0 && (this.logName == null || this.logName.Length == 0)))
				{
					this.source = value;
					return;
				}
				if (string.Compare(this.source, value, true) != 0)
				{
					this.source = value;
					this.Reset();
				}
			}
		}

		/// <summary>Возвращает или задает объект, используемый для маршалинга вызовов обработчика событий, возникающих в результате события записи в <see cref="T:System.Diagnostics.EventLog" />.</summary>
		/// <returns>Объект <see cref="T:System.ComponentModel.ISynchronizeInvoke" />, используемый для маршалинга вызовов обработчика событий, возникающих в результате события записи <see cref="E:System.Diagnostics.EventLog.EntryWritten" /> в журнал событий.</returns>
		// Token: 0x17000354 RID: 852
		// (get) Token: 0x0600128E RID: 4750 RVA: 0x0004FEB5 File Offset: 0x0004E0B5
		// (set) Token: 0x0600128F RID: 4751 RVA: 0x0004FEBD File Offset: 0x0004E0BD
		[MonitoringDescription("An object that synchronizes event handler calls.")]
		[Browsable(false)]
		[DefaultValue(null)]
		public ISynchronizeInvoke SynchronizingObject
		{
			get
			{
				return this.synchronizingObject;
			}
			set
			{
				this.synchronizingObject = value;
			}
		}

		/// <summary>Возвращает поведение при переполнении для хранения новых записей, когда файл журнала событий достигает максимального размера.</summary>
		/// <returns>Значение <see cref="T:System.Diagnostics.OverflowAction" />, которое определяет поведение при переполнении для хранения новых записей, когда файл журнала событий достигает максимального размера. Значение по умолчанию — <see cref="F:System.Diagnostics.OverflowAction.OverwriteOlder" />.</returns>
		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06001290 RID: 4752 RVA: 0x0004FEC6 File Offset: 0x0004E0C6
		[MonoTODO]
		[Browsable(false)]
		[ComVisible(false)]
		public OverflowAction OverflowAction
		{
			get
			{
				return this.Impl.OverflowAction;
			}
		}

		/// <summary>Возвращает количество дней, которое записи хранятся в журнале событий.</summary>
		/// <returns>Количество дней, которое записи хранятся в журнале событий. Значение по умолчанию — 7.</returns>
		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x0004FED3 File Offset: 0x0004E0D3
		[ComVisible(false)]
		[MonoTODO]
		[Browsable(false)]
		public int MinimumRetentionDays
		{
			get
			{
				return this.Impl.MinimumRetentionDays;
			}
		}

		/// <summary>Возвращает или устанавливает максимальный размер журнала событий в килобайтах.</summary>
		/// <returns>Максимальный размер журнала событий в килобайтах. Значение по умолчанию — 512, что означает максимальный размер файла 512 килобайт.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Указанное значение меньше 64 или больше 4194240 или не кратно 64.</exception>
		/// <exception cref="T:System.InvalidOperationException">Значение параметра <see cref="P:System.Diagnostics.EventLog.Log" /> является недопустимым именем журнала.  
		/// -или- 
		/// Раздел реестра для журнала событий не может быть открыт на конечном компьютере.</exception>
		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06001292 RID: 4754 RVA: 0x0004FEE0 File Offset: 0x0004E0E0
		// (set) Token: 0x06001293 RID: 4755 RVA: 0x0004FEED File Offset: 0x0004E0ED
		[MonoTODO]
		[ComVisible(false)]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public long MaximumKilobytes
		{
			get
			{
				return this.Impl.MaximumKilobytes;
			}
			set
			{
				this.Impl.MaximumKilobytes = value;
			}
		}

		/// <summary>Изменяет поведение при внесении новых записей, когда файл журнала событий достигает максимального размера.</summary>
		/// <param name="action">Поведение при внесении новых записей в журнал событий в случае переполнения.</param>
		/// <param name="retentionDays">Минимальное количество дней, которое будет храниться каждая запись журнала событий. Этот параметр используется только в том случае, если значение <paramref name="action" /> равно <see cref="F:System.Diagnostics.OverflowAction.OverwriteOlder" />.</param>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
		///   <paramref name="action" /> не является допустимым значением <see cref="P:System.Diagnostics.EventLog.OverflowAction" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="retentionDays" /> меньше 1 или больше 365.</exception>
		/// <exception cref="T:System.InvalidOperationException">Значение параметра <see cref="P:System.Diagnostics.EventLog.Log" /> является недопустимым именем журнала.  
		/// -или- 
		/// Раздел реестра для журнала событий не может быть открыт на конечном компьютере.</exception>
		// Token: 0x06001294 RID: 4756 RVA: 0x0004FEFB File Offset: 0x0004E0FB
		[MonoTODO]
		[ComVisible(false)]
		public void ModifyOverflowPolicy(OverflowAction action, int retentionDays)
		{
			this.Impl.ModifyOverflowPolicy(action, retentionDays);
		}

		/// <summary>Определяет локализованное имя для журнала событий, которое отображается в "Просмотре событий" сервера.</summary>
		/// <param name="resourceFile">Полный путь к локализованному файлу ресурсов.</param>
		/// <param name="resourceId">Идентификатор ресурса, который индексирует локализованную строку в файле ресурсов.</param>
		/// <exception cref="T:System.InvalidOperationException">Значение параметра <see cref="P:System.Diagnostics.EventLog.Log" /> является недопустимым именем журнала.  
		/// -или- 
		/// Раздел реестра для журнала событий не может быть открыт на конечном компьютере.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="resourceFile" /> — <see langword="null" />.</exception>
		// Token: 0x06001295 RID: 4757 RVA: 0x0004FF0A File Offset: 0x0004E10A
		[ComVisible(false)]
		[MonoTODO]
		public void RegisterDisplayName(string resourceFile, long resourceId)
		{
			this.Impl.RegisterDisplayName(resourceFile, resourceId);
		}

		/// <summary>Начинает инициализацию класса <see cref="T:System.Diagnostics.EventLog" />, используемого в форме или используемого другим компонентом. Инициализация происходит во время выполнения.</summary>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="T:System.Diagnostics.EventLog" /> уже инициализирован.</exception>
		// Token: 0x06001296 RID: 4758 RVA: 0x0004FF19 File Offset: 0x0004E119
		public void BeginInit()
		{
			this.Impl.BeginInit();
		}

		/// <summary>Удаляет все записи из журнала событий.</summary>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Создание журнала событий не было завершено успешно.  
		/// -или- 
		/// Невозможно открыть журнал. Код ошибки Windows недоступен.</exception>
		/// <exception cref="T:System.ArgumentException">Для свойства <see cref="P:System.Diagnostics.EventLog.Log" /> не указано значение. Убедитесь, что имя журнала — не пустая строка.</exception>
		/// <exception cref="T:System.InvalidOperationException">Журнал не существует.</exception>
		// Token: 0x06001297 RID: 4759 RVA: 0x0004FF28 File Offset: 0x0004E128
		public void Clear()
		{
			string log = this.Log;
			if (log == null || log.Length == 0)
			{
				throw new ArgumentException("Log property value has not been specified.");
			}
			if (!EventLog.Exists(log, this.MachineName))
			{
				throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Event Log '{0}' does not exist on computer '{1}'.", log, this.machineName));
			}
			this.Impl.Clear();
			this.Reset();
		}

		/// <summary>Закрывает журнал событий и удаляет дескрипторы чтения и записи.</summary>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Дескриптор чтения или записи события не был успешно удален.</exception>
		// Token: 0x06001298 RID: 4760 RVA: 0x0004FF8D File Offset: 0x0004E18D
		public void Close()
		{
			this.Impl.Close();
			this.EnableRaisingEvents = false;
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x0004FFA4 File Offset: 0x0004E1A4
		internal void Reset()
		{
			bool enableRaisingEvents = this.EnableRaisingEvents;
			this.Close();
			this.EnableRaisingEvents = enableRaisingEvents;
		}

		/// <summary>Задает указанное имя источника в качестве допустимого источника событий для внесения записей в журнал на локальном компьютере. Используя этот метод, можно также создать новый пользовательский журнал на локальном компьютере.</summary>
		/// <param name="source">Имя источника, по которому приложение регистрируется на локальном компьютере.</param>
		/// <param name="logName">Имя журнала, в который вносятся записи о событиях источника. Допустимые значения: Application, System или имя пользовательского журнала событий.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="source" /> является пустой строкой ("") или <see langword="null" />.  
		/// -или- 
		///  <paramref name="logName" /> не является допустимым именем журнала событий. Имена журналов событий должны содержать печатные символы и не должны содержать символы "*", "?" или "\".  
		/// -или- 
		///  Значение <paramref name="logName" /> недопустимо для создания журнала пользователя. Имена AppEvent, SysEvent и SecEvent зарезервированы для системного использования.  
		/// -или- 
		/// Имя журнала совпадает с существующим именем источника событий.  
		/// -или- 
		/// При таком имени источника длина пути к разделу реестра превышает 254 символа.  
		/// -или- 
		/// Первые 8 символов <paramref name="logName" /> совпадают с первыми 8 символами имени существующего журнала событий.  
		/// -или- 
		/// Невозможно зарегистрировать источник, поскольку он уже существует на локальном компьютере.  
		/// -или- 
		/// Имя источника совпадает с существующим именем журнала событий.</exception>
		/// <exception cref="T:System.InvalidOperationException">Раздел реестра для журнала событий не может быть открыт на локальном компьютере.</exception>
		// Token: 0x0600129A RID: 4762 RVA: 0x0004FFC5 File Offset: 0x0004E1C5
		public static void CreateEventSource(string source, string logName)
		{
			EventLog.CreateEventSource(source, logName, ".");
		}

		/// <summary>Устанавливает заданное имяисточника в качестве допустимого источника событий для внесения записей в журнал на указанном компьютере. Этот метод можно также использовать для создания нового пользовательского журнала на заданном компьютере.</summary>
		/// <param name="source">Источник, по которому приложение регистрируется на указанном компьютере.</param>
		/// <param name="logName">Имя журнала, в который вносятся записи о событиях источника. Допустимые значения: Application, System или имя пользовательского журнала событий. Если значение не указано, то параметр <paramref name="logName" /> по умолчанию имеет значение Application.</param>
		/// <param name="machineName">Имя компьютера, на котором регистрируется источник событий, или значение ".", если используется локальный компьютер.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="machineName" /> не является допустимым именем компьютера.  
		/// -или- 
		///  <paramref name="source" /> является пустой строкой ("") или <see langword="null" />.  
		/// -или- 
		///  <paramref name="logName" /> не является допустимым именем журнала событий. Имена журналов событий должны содержать печатные символы и не должны содержать символы "*", "?" или "\".  
		/// -или- 
		///  Значение <paramref name="logName" /> недопустимо для создания журнала пользователя. Имена AppEvent, SysEvent и SecEvent зарезервированы для системного использования.  
		/// -или- 
		/// Имя журнала совпадает с существующим именем источника событий.  
		/// -или- 
		/// При таком имени источника длина пути к разделу реестра превышает 254 символа.  
		/// -или- 
		/// Первые 8 символов <paramref name="logName" /> совпадают с первыми 8 символами имени существующего журнала событий на указанном компьютере.  
		/// -или- 
		/// Невозможно зарегистрировать источник, так как он уже существует на заданном компьютере.  
		/// -или- 
		/// Имя источника совпадает с существующим именем источника событий.</exception>
		/// <exception cref="T:System.InvalidOperationException">Раздел реестра для журнала событий не может быть открыт на указанном компьютере.</exception>
		// Token: 0x0600129B RID: 4763 RVA: 0x0004FFD3 File Offset: 0x0004E1D3
		[Obsolete("use CreateEventSource(EventSourceCreationData) instead")]
		public static void CreateEventSource(string source, string logName, string machineName)
		{
			EventLog.CreateEventSource(new EventSourceCreationData(source, logName, machineName));
		}

		/// <summary>Задает допустимый источник событий для записи локализованных сообщений о событиях, используя указанные свойства конфигурации источника событий и соответствующий журнал событий.</summary>
		/// <param name="sourceData">Свойства конфигурации для источника событий и его целевого журнала событий.</param>
		/// <exception cref="T:System.ArgumentException">Имя компьютера, заданное в <paramref name="sourceData" />, недопустимо.  
		/// -или- 
		/// Имя источника, указанное в параметре <paramref name="sourceData" />, равно <see langword="null" />.  
		/// -или- 
		/// Имя журнала, заданное в <paramref name="sourceData" /> недопустимо. Имена журналов событий должны содержать печатные символы и не должны содержать символы "*", "?" или "\".  
		/// -или- 
		/// Имя журнала, заданное в <paramref name="sourceData" />, недопустимо для создания пользовательского журнала. Имена AppEvent, SysEvent и SecEvent зарезервированы для системного использования.  
		/// -или- 
		/// Имя журнала совпадает с существующим именем источника событий.  
		/// -или- 
		/// При таком имени источника, заданном в <paramref name="sourceData" />, длина пути к разделу реестра превышает 254 символа.  
		/// -или- 
		/// Первые 8 символов имени журнала, заданные в <paramref name="sourceData" />, не уникальны.  
		/// -или- 
		/// Имя источника, заданное в <paramref name="sourceData" />, уже зарегистрировано.  
		/// -или- 
		/// Имя источника, заданное в <paramref name="sourceData" />, совпадает с существующим именем журнала событий.</exception>
		/// <exception cref="T:System.InvalidOperationException">Не удается открыть раздел реестра для журнала событий.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="sourceData" /> — <see langword="null" />.</exception>
		// Token: 0x0600129C RID: 4764 RVA: 0x0004FFE4 File Offset: 0x0004E1E4
		[MonoNotSupported("remote machine is not supported")]
		public static void CreateEventSource(EventSourceCreationData sourceData)
		{
			if (sourceData.Source == null || sourceData.Source.Length == 0)
			{
				throw new ArgumentException("Source property value has not been specified.");
			}
			if (sourceData.LogName == null || sourceData.LogName.Length == 0)
			{
				throw new ArgumentException("Log property value has not been specified.");
			}
			if (EventLog.SourceExists(sourceData.Source, sourceData.MachineName))
			{
				throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "Source '{0}' already exists on '{1}'.", sourceData.Source, sourceData.MachineName));
			}
			EventLog.CreateEventLogImpl(sourceData.LogName, sourceData.MachineName, sourceData.Source).CreateEventSource(sourceData);
		}

		/// <summary>Удаляет журнал событий с локального компьютера.</summary>
		/// <param name="logName">Имя удаляемого журнала. Возможные допустимые значения приведены ниже. Application, Security, System или имя пользовательского журнала событий на компьютере.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="logName" /> является пустой строкой ("") или <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Раздел реестра для журнала событий не может быть открыт на локальном компьютере.  
		/// -или- 
		/// Журнала на локальном компьютере не существует.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Создание журнала событий не было завершено успешно.  
		/// -или- 
		/// Невозможно открыть журнал. Код ошибки Windows недоступен.</exception>
		// Token: 0x0600129D RID: 4765 RVA: 0x00050082 File Offset: 0x0004E282
		public static void Delete(string logName)
		{
			EventLog.Delete(logName, ".");
		}

		/// <summary>Удаляет журнал событий с указанного компьютера.</summary>
		/// <param name="logName">Имя удаляемого журнала. Возможные допустимые значения приведены ниже. Application, Security, System или имя пользовательского журнала событий на компьютере.</param>
		/// <param name="machineName">Имя компьютера, с которого удаляется журнал, или значение ".", если используется локальный компьютер.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="logName" /> является пустой строкой ("") или <see langword="null" />.  
		/// -или- 
		///  Параметр <paramref name="machineName" /> не является допустимым именем компьютера.</exception>
		/// <exception cref="T:System.InvalidOperationException">Раздел реестра для журнала событий не может быть открыт на указанном компьютере.  
		/// -или- 
		/// Журнала на указанном компьютере не существует.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Создание журнала событий не было завершено успешно.  
		/// -или- 
		/// Невозможно открыть журнал. Код ошибки Windows недоступен.</exception>
		// Token: 0x0600129E RID: 4766 RVA: 0x00050090 File Offset: 0x0004E290
		[MonoNotSupported("remote machine is not supported")]
		public static void Delete(string logName, string machineName)
		{
			if (machineName == null || machineName.Trim().Length == 0)
			{
				throw new ArgumentException("Invalid format for argument machineName.");
			}
			if (logName == null || logName.Length == 0)
			{
				throw new ArgumentException("Log to delete was not specified.");
			}
			EventLog.CreateEventLogImpl(logName, machineName, string.Empty).Delete(logName, machineName);
		}

		/// <summary>Удаляет регистрацию источника событий из журнала событий на локальном компьютере.</summary>
		/// <param name="source">Имя, с которым приложение регистрируется в журнале событий системы.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="source" /> отсутствует в реестре локального компьютера.  
		/// -или- 
		/// Отсутствуют права на запись в раздел реестра для журнала событий.</exception>
		// Token: 0x0600129F RID: 4767 RVA: 0x000500E1 File Offset: 0x0004E2E1
		public static void DeleteEventSource(string source)
		{
			EventLog.DeleteEventSource(source, ".");
		}

		/// <summary>Удаляет регистрацию источника событий приложения с указанного компьютера.</summary>
		/// <param name="source">Имя, с которым приложение регистрируется в журнале событий системы.</param>
		/// <param name="machineName">Имя компьютера, с которого удаляется регистрация, или "." для локального компьютера.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="machineName" /> является недопустимым.  
		/// -или- 
		/// Параметр <paramref name="source" /> отсутствует в реестре заданного компьютера.  
		/// -или- 
		/// Отсутствуют права на запись в раздел реестра для журнала событий.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="source" /> не может быть удален, так как в реестре, родительский раздел реестра <paramref name="source" /> не содержит подразделы с тем же именем.</exception>
		// Token: 0x060012A0 RID: 4768 RVA: 0x000500EE File Offset: 0x0004E2EE
		[MonoNotSupported("remote machine is not supported")]
		public static void DeleteEventSource(string source, string machineName)
		{
			if (machineName == null || machineName.Trim().Length == 0)
			{
				throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "Invalid value '{0}' for parameter 'machineName'.", machineName));
			}
			EventLog.CreateEventLogImpl(string.Empty, machineName, source).DeleteEventSource(source, machineName);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые журналом <see cref="T:System.Diagnostics.EventLog" />, и при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить управляемые и неуправляемые ресурсы; значение <see langword="false" /> позволяет освободить только неуправляемые ресурсы.</param>
		// Token: 0x060012A1 RID: 4769 RVA: 0x00050129 File Offset: 0x0004E329
		protected override void Dispose(bool disposing)
		{
			if (this.Impl != null)
			{
				this.Impl.Dispose(disposing);
			}
		}

		/// <summary>Завершает инициализацию класса <see cref="T:System.Diagnostics.EventLog" />, используемого в форме или другим компонентом. Инициализация происходит во время выполнения.</summary>
		// Token: 0x060012A2 RID: 4770 RVA: 0x0005013F File Offset: 0x0004E33F
		public void EndInit()
		{
			this.Impl.EndInit();
		}

		/// <summary>Определяет наличие журнала на локальном компьютере.</summary>
		/// <param name="logName">Имя журнала, который нужно найти. Возможные допустимые значения приведены ниже. Application, Security, System, имена журналов определенных приложений (например, службы каталогов Active Directory) или имя любого пользовательского журнала на компьютере.</param>
		/// <returns>Значение <see langword="true" />, если журнал существует на локальном компьютере; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр logName принимает значение <see langword="null" /> или пустое значение.</exception>
		// Token: 0x060012A3 RID: 4771 RVA: 0x0005014C File Offset: 0x0004E34C
		public static bool Exists(string logName)
		{
			return EventLog.Exists(logName, ".");
		}

		/// <summary>Определяет наличие журнала на заданном компьютере.</summary>
		/// <param name="logName">Журнал, который нужно найти. Возможные допустимые значения приведены ниже. Application, Security, System, имена журналов определенных приложений (например, службы каталогов Active Directory) или имя любого пользовательского журнала на компьютере.</param>
		/// <param name="machineName">Имя компьютера, на котором выполняется поиск журнала, или значение ".", если используется локальный компьютер.</param>
		/// <returns>Значение <see langword="true" />, если журнал существует на заданном компьютере; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Недопустимый формат параметра <paramref name="machineName" />. Убедитесь, что при поиске на компьютере используется правильный синтаксис.  
		/// -или- 
		/// Параметр <paramref name="logName" /> принимает значение <see langword="null" /> или пустое значение.</exception>
		// Token: 0x060012A4 RID: 4772 RVA: 0x00050159 File Offset: 0x0004E359
		[MonoNotSupported("remote machine is not supported")]
		public static bool Exists(string logName, string machineName)
		{
			if (machineName == null || machineName.Trim().Length == 0)
			{
				throw new ArgumentException("Invalid format for argument machineName.");
			}
			return logName != null && logName.Length != 0 && EventLog.CreateEventLogImpl(logName, machineName, string.Empty).Exists(logName, machineName);
		}

		/// <summary>Выполняет поиск всех журналов событий на локальном компьютере и создает массив объектов <see cref="T:System.Diagnostics.EventLog" />, содержащих список.</summary>
		/// <returns>Массив типа <see cref="T:System.Diagnostics.EventLog" />, представляющий журналы на локальном компьютере.</returns>
		/// <exception cref="T:System.SystemException">Отсутствуют права на доступ к реестру.  
		/// -или- 
		/// На компьютере отсутствует служба журнала событий.</exception>
		// Token: 0x060012A5 RID: 4773 RVA: 0x00050196 File Offset: 0x0004E396
		public static EventLog[] GetEventLogs()
		{
			return EventLog.GetEventLogs(".");
		}

		/// <summary>Выполняет поиск всех журналов событий на заданном компьютере и создает массив объектов <see cref="T:System.Diagnostics.EventLog" />, содержащих список.</summary>
		/// <param name="machineName">Компьютер, на котором выполняется поиск журналов событий.</param>
		/// <returns>Массив типа <see cref="T:System.Diagnostics.EventLog" />, представляющий журналы на заданном компьютере.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="machineName" /> содержит недопустимое имя компьютера.</exception>
		/// <exception cref="T:System.InvalidOperationException">Отсутствуют права на доступ к реестру.  
		/// -или- 
		/// На компьютере отсутствует служба журнала событий.</exception>
		// Token: 0x060012A6 RID: 4774 RVA: 0x000501A2 File Offset: 0x0004E3A2
		[MonoNotSupported("remote machine is not supported")]
		public static EventLog[] GetEventLogs(string machineName)
		{
			return EventLog.CreateEventLogImpl(new EventLog()).GetEventLogs(machineName);
		}

		/// <summary>Возвращает имя журнала, в котором зарегистрирован указанный источник.</summary>
		/// <param name="source">Имя источника событий.</param>
		/// <param name="machineName">Имя компьютера, на котором выполняется поиск, или значение ".", если используется локальный компьютер.</param>
		/// <returns>Имя журнала, связанное с указанным источником в реестре.</returns>
		// Token: 0x060012A7 RID: 4775 RVA: 0x000501B4 File Offset: 0x0004E3B4
		[MonoNotSupported("remote machine is not supported")]
		public static string LogNameFromSourceName(string source, string machineName)
		{
			if (machineName == null || machineName.Trim().Length == 0)
			{
				throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "Invalid value '{0}' for parameter 'MachineName'.", machineName));
			}
			return EventLog.CreateEventLogImpl(string.Empty, machineName, source).LogNameFromSourceName(source, machineName);
		}

		/// <summary>Определяет, зарегистрирован ли источник событий на локальном компьютере.</summary>
		/// <param name="source">Имя источника событий.</param>
		/// <returns>Значение <see langword="true" />, если источник событий зарегистрирован на локальном компьютере; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">
		///   <paramref name="source" /> не найден, но поиск некоторых или всех журналов событий не был произведен.</exception>
		// Token: 0x060012A8 RID: 4776 RVA: 0x000501EF File Offset: 0x0004E3EF
		public static bool SourceExists(string source)
		{
			return EventLog.SourceExists(source, ".");
		}

		/// <summary>Определяет, зарегистрирован ли источник событий на указанном компьютере.</summary>
		/// <param name="source">Имя источника событий.</param>
		/// <param name="machineName">Имя компьютера, на котором выполняется поиск, или значение ".", если используется локальный компьютер.</param>
		/// <returns>Значение <see langword="true" />, если источник событий зарегистрирован на заданном компьютере; в противном случае — значение <see langword="false" /></returns>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="machineName" /> не является допустимым именем компьютера.</exception>
		/// <exception cref="T:System.Security.SecurityException">
		///   <paramref name="source" /> не найден, но поиск некоторых или всех журналов событий не был произведен.</exception>
		// Token: 0x060012A9 RID: 4777 RVA: 0x000501FC File Offset: 0x0004E3FC
		[MonoNotSupported("remote machine is not supported")]
		public static bool SourceExists(string source, string machineName)
		{
			if (machineName == null || machineName.Trim().Length == 0)
			{
				throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "Invalid value '{0}' for parameter 'machineName'.", machineName));
			}
			return EventLog.CreateEventLogImpl(string.Empty, machineName, source).SourceExists(source, machineName);
		}

		/// <summary>Вносит в журнал событий запись сведений с заданным текстом сообщения.</summary>
		/// <param name="message">Строка для записи в журнал событий.</param>
		/// <exception cref="T:System.ArgumentException">Не задано свойство <see cref="P:System.Diagnostics.EventLog.Source" /> класса <see cref="T:System.Diagnostics.EventLog" />.  
		/// -или- 
		/// Метод пытается зарегистрировать новый источник событий, но имя компьютера в <see cref="P:System.Diagnostics.EventLog.MachineName" /> является недопустимым.  
		/// -или- 
		/// Источник уже зарегистрирован для различных журналов событий.  
		/// -или- 
		/// Строка сообщения превышает 31,839 байт (32,766 байт в операционных системах Windows до Windows Vista).  
		/// -или- 
		/// При таком имени источника длина пути к разделу реестра превышает 254 символа.</exception>
		/// <exception cref="T:System.InvalidOperationException">Не удается открыть раздел реестра для журнала событий.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Операционная система сообщила об ошибке при записи сведений о событии в журнал событий. Код ошибки Windows недоступен.</exception>
		// Token: 0x060012AA RID: 4778 RVA: 0x00050237 File Offset: 0x0004E437
		public void WriteEntry(string message)
		{
			this.WriteEntry(message, EventLogEntryType.Information);
		}

		/// <summary>Вносит в журнал событий следующие записи с заданным текстом сообщения: ошибка, предупреждение, сведения, аудит отказов или аудит успехов.</summary>
		/// <param name="message">Строка для записи в журнал событий.</param>
		/// <param name="type">Одно из значений <see cref="T:System.Diagnostics.EventLogEntryType" />.</param>
		/// <exception cref="T:System.ArgumentException">Не задано свойство <see cref="P:System.Diagnostics.EventLog.Source" /> класса <see cref="T:System.Diagnostics.EventLog" />.  
		/// -или- 
		/// Метод пытается зарегистрировать новый источник событий, но имя компьютера в <see cref="P:System.Diagnostics.EventLog.MachineName" /> является недопустимым.  
		/// -или- 
		/// Источник уже зарегистрирован для различных журналов событий.  
		/// -или- 
		/// Строка сообщения превышает 31,839 байт (32,766 байт в операционных системах Windows до Windows Vista).  
		/// -или- 
		/// При таком имени источника длина пути к разделу реестра превышает 254 символа.</exception>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
		///   <paramref name="type" /> не является допустимым <see cref="T:System.Diagnostics.EventLogEntryType" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Не удается открыть раздел реестра для журнала событий.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Операционная система сообщила об ошибке при записи сведений о событии в журнал событий. Код ошибки Windows недоступен.</exception>
		// Token: 0x060012AB RID: 4779 RVA: 0x00050241 File Offset: 0x0004E441
		public void WriteEntry(string message, EventLogEntryType type)
		{
			this.WriteEntry(message, type, 0);
		}

		/// <summary>Вносит в журнал событий запись с заданным текстом сообщения и идентификатором события, который определяется приложением.</summary>
		/// <param name="message">Строка для записи в журнал событий.</param>
		/// <param name="type">Одно из значений <see cref="T:System.Diagnostics.EventLogEntryType" />.</param>
		/// <param name="eventID">Идентификатор для события, зависящий от приложения.</param>
		/// <exception cref="T:System.ArgumentException">Не задано свойство <see cref="P:System.Diagnostics.EventLog.Source" /> класса <see cref="T:System.Diagnostics.EventLog" />.  
		/// -или- 
		/// Метод пытается зарегистрировать новый источник событий, но имя компьютера в <see cref="P:System.Diagnostics.EventLog.MachineName" /> является недопустимым.  
		/// -или- 
		/// Источник уже зарегистрирован для различных журналов событий.  
		/// -или- 
		///  <paramref name="eventID" /> меньше нуля или больше <see cref="F:System.UInt16.MaxValue" />.  
		/// -или- 
		/// Строка сообщения превышает 31,839 байт (32,766 байт в операционных системах Windows до Windows Vista).  
		/// -или- 
		/// При таком имени источника длина пути к разделу реестра превышает 254 символа.</exception>
		/// <exception cref="T:System.InvalidOperationException">Не удается открыть раздел реестра для журнала событий.</exception>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
		///   <paramref name="type" /> не является допустимым <see cref="T:System.Diagnostics.EventLogEntryType" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Операционная система сообщила об ошибке при записи сведений о событии в журнал событий. Код ошибки Windows недоступен.</exception>
		// Token: 0x060012AC RID: 4780 RVA: 0x0005024C File Offset: 0x0004E44C
		public void WriteEntry(string message, EventLogEntryType type, int eventID)
		{
			this.WriteEntry(message, type, eventID, 0);
		}

		/// <summary>Вносит в журнал событий запись с заданным текстом сообщения, идентификатором события и категорией, которая определяется приложением.</summary>
		/// <param name="message">Строка для записи в журнал событий.</param>
		/// <param name="type">Одно из значений <see cref="T:System.Diagnostics.EventLogEntryType" />.</param>
		/// <param name="eventID">Идентификатор для события, зависящий от приложения.</param>
		/// <param name="category">Подкатегория конкретного приложения, связанная с сообщением.</param>
		/// <exception cref="T:System.ArgumentException">Не задано свойство <see cref="P:System.Diagnostics.EventLog.Source" /> класса <see cref="T:System.Diagnostics.EventLog" />.  
		/// -или- 
		/// Метод пытается зарегистрировать новый источник событий, но имя компьютера в <see cref="P:System.Diagnostics.EventLog.MachineName" /> является недопустимым.  
		/// -или- 
		/// Источник уже зарегистрирован для различных журналов событий.  
		/// -или- 
		///  <paramref name="eventID" /> меньше нуля или больше <see cref="F:System.UInt16.MaxValue" />.  
		/// -или- 
		/// Строка сообщения превышает 31,839 байт (32,766 байт в операционных системах Windows до Windows Vista).  
		/// -или- 
		/// При таком имени источника длина пути к разделу реестра превышает 254 символа.</exception>
		/// <exception cref="T:System.InvalidOperationException">Не удается открыть раздел реестра для журнала событий.</exception>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
		///   <paramref name="type" /> не является допустимым <see cref="T:System.Diagnostics.EventLogEntryType" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Операционная система сообщила об ошибке при записи сведений о событии в журнал событий. Код ошибки Windows недоступен.</exception>
		// Token: 0x060012AD RID: 4781 RVA: 0x00050258 File Offset: 0x0004E458
		public void WriteEntry(string message, EventLogEntryType type, int eventID, short category)
		{
			this.WriteEntry(message, type, eventID, category, null);
		}

		/// <summary>Вносит в журнал событий запись с заданным текстом сообщения, идентификатором события и категорией (которые определяются приложением), а затем добавляет в сообщение двоичные данные.</summary>
		/// <param name="message">Строка для записи в журнал событий.</param>
		/// <param name="type">Одно из значений <see cref="T:System.Diagnostics.EventLogEntryType" />.</param>
		/// <param name="eventID">Идентификатор для события, зависящий от приложения.</param>
		/// <param name="category">Подкатегория конкретного приложения, связанная с сообщением.</param>
		/// <param name="rawData">Массив байтов, в котором хранятся двоичные данные, связанные с записью.</param>
		/// <exception cref="T:System.ArgumentException">Не задано свойство <see cref="P:System.Diagnostics.EventLog.Source" /> класса <see cref="T:System.Diagnostics.EventLog" />.  
		/// -или- 
		/// Метод пытается зарегистрировать новый источник событий, но имя компьютера в <see cref="P:System.Diagnostics.EventLog.MachineName" /> является недопустимым.  
		/// -или- 
		/// Источник уже зарегистрирован для различных журналов событий.  
		/// -или- 
		///  <paramref name="eventID" /> меньше нуля или больше <see cref="F:System.UInt16.MaxValue" />.  
		/// -или- 
		/// Строка сообщения превышает 31,839 байт (32,766 байт в операционных системах Windows до Windows Vista).  
		/// -или- 
		/// При таком имени источника длина пути к разделу реестра превышает 254 символа.</exception>
		/// <exception cref="T:System.InvalidOperationException">Не удается открыть раздел реестра для журнала событий.</exception>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
		///   <paramref name="type" /> не является допустимым <see cref="T:System.Diagnostics.EventLogEntryType" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Операционная система сообщила об ошибке при записи сведений о событии в журнал событий. Код ошибки Windows недоступен.</exception>
		// Token: 0x060012AE RID: 4782 RVA: 0x00050266 File Offset: 0x0004E466
		public void WriteEntry(string message, EventLogEntryType type, int eventID, short category, byte[] rawData)
		{
			this.WriteEntry(new string[]
			{
				message
			}, type, (long)eventID, category, rawData);
		}

		/// <summary>Вносит в журнал событий запись сведений с заданным текстом сообщения, используя указанный зарегистрированный источник.</summary>
		/// <param name="source">Источник, по которому приложение регистрируется на указанном компьютере.</param>
		/// <param name="message">Строка для записи в журнал событий.</param>
		/// <exception cref="T:System.ArgumentException">Значением <paramref name="source" /> является пустая строка ("").  
		/// -или- 
		/// Значение <paramref name="source" /> равно <see langword="null" />.  
		/// -или- 
		/// Строка сообщения превышает 31,839 байт (32,766 байт в операционных системах Windows до Windows Vista).  
		/// -или- 
		/// При таком имени источника длина пути к разделу реестра превышает 254 символа.</exception>
		/// <exception cref="T:System.InvalidOperationException">Не удается открыть раздел реестра для журнала событий.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Операционная система сообщила об ошибке при записи сведений о событии в журнал событий. Код ошибки Windows недоступен.</exception>
		// Token: 0x060012AF RID: 4783 RVA: 0x0005027F File Offset: 0x0004E47F
		public static void WriteEntry(string source, string message)
		{
			EventLog.WriteEntry(source, message, EventLogEntryType.Information);
		}

		/// <summary>Вносит в журнал событий, используя указанный зарегистрированный источник, следующие записи с заданным текстом сообщения: ошибка, предупреждение, сведения, аудит отказов или аудит успехов.</summary>
		/// <param name="source">Источник, по которому приложение регистрируется на указанном компьютере.</param>
		/// <param name="message">Строка для записи в журнал событий.</param>
		/// <param name="type">Одно из значений <see cref="T:System.Diagnostics.EventLogEntryType" />.</param>
		/// <exception cref="T:System.ArgumentException">Значением <paramref name="source" /> является пустая строка ("").  
		/// -или- 
		/// Значение <paramref name="source" /> равно <see langword="null" />.  
		/// -или- 
		/// Строка сообщения превышает 31,839 байт (32,766 байт в операционных системах Windows до Windows Vista).  
		/// -или- 
		/// При таком имени источника длина пути к разделу реестра превышает 254 символа.</exception>
		/// <exception cref="T:System.InvalidOperationException">Не удается открыть раздел реестра для журнала событий.</exception>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
		///   <paramref name="type" /> не является допустимым <see cref="T:System.Diagnostics.EventLogEntryType" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Операционная система сообщила об ошибке при записи сведений о событии в журнал событий. Код ошибки Windows недоступен.</exception>
		// Token: 0x060012B0 RID: 4784 RVA: 0x00050289 File Offset: 0x0004E489
		public static void WriteEntry(string source, string message, EventLogEntryType type)
		{
			EventLog.WriteEntry(source, message, type, 0);
		}

		/// <summary>Вносит в журнал событий запись с заданным текстом сообщения и идентификатором события (который определяется приложением), используя указанный зарегистрированный источник событий.</summary>
		/// <param name="source">Источник, по которому приложение регистрируется на указанном компьютере.</param>
		/// <param name="message">Строка для записи в журнал событий.</param>
		/// <param name="type">Одно из значений <see cref="T:System.Diagnostics.EventLogEntryType" />.</param>
		/// <param name="eventID">Идентификатор для события, зависящий от приложения.</param>
		/// <exception cref="T:System.ArgumentException">Значением <paramref name="source" /> является пустая строка ("").  
		/// -или- 
		/// Значение <paramref name="source" /> равно <see langword="null" />.  
		/// -или- 
		///  <paramref name="eventID" /> меньше нуля или больше <see cref="F:System.UInt16.MaxValue" />.  
		/// -или- 
		/// Строка сообщения превышает 31,839 байт (32,766 байт в операционных системах Windows до Windows Vista).  
		/// -или- 
		/// При таком имени источника длина пути к разделу реестра превышает 254 символа.</exception>
		/// <exception cref="T:System.InvalidOperationException">Не удается открыть раздел реестра для журнала событий.</exception>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
		///   <paramref name="type" /> не является допустимым <see cref="T:System.Diagnostics.EventLogEntryType" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Операционная система сообщила об ошибке при записи сведений о событии в журнал событий. Код ошибки Windows недоступен.</exception>
		// Token: 0x060012B1 RID: 4785 RVA: 0x00050294 File Offset: 0x0004E494
		public static void WriteEntry(string source, string message, EventLogEntryType type, int eventID)
		{
			EventLog.WriteEntry(source, message, type, eventID, 0);
		}

		/// <summary>Вносит в журнал событий запись с заданным текстом сообщения и идентификатором события и категорией (которые определяется приложением), используя указанный зарегистрированный источник событий. С помощью <paramref name="category" /> осуществляется фильтрация событий журнала в компоненте "Просмотр событий".</summary>
		/// <param name="source">Источник, по которому приложение регистрируется на указанном компьютере.</param>
		/// <param name="message">Строка для записи в журнал событий.</param>
		/// <param name="type">Одно из значений <see cref="T:System.Diagnostics.EventLogEntryType" />.</param>
		/// <param name="eventID">Идентификатор для события, зависящий от приложения.</param>
		/// <param name="category">Подкатегория конкретного приложения, связанная с сообщением.</param>
		/// <exception cref="T:System.ArgumentException">Значением <paramref name="source" /> является пустая строка ("").  
		/// -или- 
		/// Значение <paramref name="source" /> равно <see langword="null" />.  
		/// -или- 
		///  <paramref name="eventID" /> меньше нуля или больше <see cref="F:System.UInt16.MaxValue" />.  
		/// -или- 
		/// Строка сообщения превышает 31,839 байт (32,766 байт в операционных системах Windows до Windows Vista).  
		/// -или- 
		/// При таком имени источника длина пути к разделу реестра превышает 254 символа.</exception>
		/// <exception cref="T:System.InvalidOperationException">Не удается открыть раздел реестра для журнала событий.</exception>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
		///   <paramref name="type" /> не является допустимым <see cref="T:System.Diagnostics.EventLogEntryType" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Операционная система сообщила об ошибке при записи сведений о событии в журнал событий. Код ошибки Windows недоступен.</exception>
		// Token: 0x060012B2 RID: 4786 RVA: 0x000502A0 File Offset: 0x0004E4A0
		public static void WriteEntry(string source, string message, EventLogEntryType type, int eventID, short category)
		{
			EventLog.WriteEntry(source, message, type, eventID, category, null);
		}

		/// <summary>Вносит в журнал событий запись с заданным текстом сообщения, идентификатором события и категорией (которые определяются приложением), используя указанный зарегистрированный источник событий, а затем добавляет в сообщение двоичные данные.</summary>
		/// <param name="source">Источник, по которому приложение регистрируется на указанном компьютере.</param>
		/// <param name="message">Строка для записи в журнал событий.</param>
		/// <param name="type">Одно из значений <see cref="T:System.Diagnostics.EventLogEntryType" />.</param>
		/// <param name="eventID">Идентификатор для события, зависящий от приложения.</param>
		/// <param name="category">Подкатегория конкретного приложения, связанная с сообщением.</param>
		/// <param name="rawData">Массив байтов, в котором хранятся двоичные данные, связанные с записью.</param>
		/// <exception cref="T:System.ArgumentException">Значением <paramref name="source" /> является пустая строка ("").  
		/// -или- 
		/// Значение <paramref name="source" /> равно <see langword="null" />.  
		/// -или- 
		///  <paramref name="eventID" /> меньше нуля или больше <see cref="F:System.UInt16.MaxValue" />.  
		/// -или- 
		/// Строка сообщения превышает 31,839 байт (32,766 байт в операционных системах Windows до Windows Vista).  
		/// -или- 
		/// При таком имени источника длина пути к разделу реестра превышает 254 символа.</exception>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
		///   <paramref name="type" /> не является допустимым <see cref="T:System.Diagnostics.EventLogEntryType" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Не удается открыть раздел реестра для журнала событий.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Операционная система сообщила об ошибке при записи сведений о событии в журнал событий. Код ошибки Windows недоступен.</exception>
		// Token: 0x060012B3 RID: 4787 RVA: 0x000502B0 File Offset: 0x0004E4B0
		public static void WriteEntry(string source, string message, EventLogEntryType type, int eventID, short category, byte[] rawData)
		{
			using (EventLog eventLog = new EventLog())
			{
				eventLog.Source = source;
				eventLog.WriteEntry(message, type, eventID, category, rawData);
			}
		}

		/// <summary>Вносит локализованные записи в журнал событий.</summary>
		/// <param name="instance">Экземпляр <see cref="T:System.Diagnostics.EventInstance" />, который представляет локализованную запись журнала событий.</param>
		/// <param name="values">Массив строк для слияния в текстовое сообщение записи журнала событий.</param>
		/// <exception cref="T:System.ArgumentException">Не задано свойство <see cref="P:System.Diagnostics.EventLog.Source" /> класса <see cref="T:System.Diagnostics.EventLog" />.  
		/// -или- 
		/// Метод пытается зарегистрировать новый источник событий, но имя компьютера в <see cref="P:System.Diagnostics.EventLog.MachineName" /> является недопустимым.  
		/// -или- 
		/// Источник уже зарегистрирован для различных журналов событий.  
		/// -или- 
		///  <paramref name="instance.InstanceId" /> меньше нуля или больше <see cref="F:System.UInt16.MaxValue" />.  
		/// -или- 
		///  <paramref name="values" /> содержит более 256 элементов.  
		/// -или- 
		/// Один из элементов <paramref name="values" /> длиннее 32766 байт.  
		/// -или- 
		/// При таком имени источника длина пути к разделу реестра превышает 254 символа.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="instance" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Не удается открыть раздел реестра для журнала событий.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Операционная система сообщила об ошибке при записи сведений о событии в журнал событий. Код ошибки Windows недоступен.</exception>
		// Token: 0x060012B4 RID: 4788 RVA: 0x000502F4 File Offset: 0x0004E4F4
		[ComVisible(false)]
		public void WriteEvent(EventInstance instance, params object[] values)
		{
			this.WriteEvent(instance, null, values);
		}

		/// <summary>Заносит записи журнала событий с данными события, строками замещения сообщения и связанными двоичными данными.</summary>
		/// <param name="instance">Экземпляр <see cref="T:System.Diagnostics.EventInstance" />, который представляет локализованную запись журнала событий.</param>
		/// <param name="data">Массив байтов, в котором хранятся двоичные данные, связанные с записью.</param>
		/// <param name="values">Массив строк для слияния в текстовое сообщение записи журнала событий.</param>
		/// <exception cref="T:System.ArgumentException">Не задано свойство <see cref="P:System.Diagnostics.EventLog.Source" /> класса <see cref="T:System.Diagnostics.EventLog" />.  
		/// -или- 
		/// Метод пытается зарегистрировать новый источник событий, но имя компьютера в <see cref="P:System.Diagnostics.EventLog.MachineName" /> является недопустимым.  
		/// -или- 
		/// Источник уже зарегистрирован для различных журналов событий.  
		/// -или- 
		///  <paramref name="instance.InstanceId" /> меньше нуля или больше <see cref="F:System.UInt16.MaxValue" />.  
		/// -или- 
		///  <paramref name="values" /> содержит более 256 элементов.  
		/// -или- 
		/// Один из элементов <paramref name="values" /> длиннее 32766 байт.  
		/// -или- 
		/// При таком имени источника длина пути к разделу реестра превышает 254 символа.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="instance" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Не удается открыть раздел реестра для журнала событий.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Операционная система сообщила об ошибке при записи сведений о событии в журнал событий. Код ошибки Windows недоступен.</exception>
		// Token: 0x060012B5 RID: 4789 RVA: 0x00050300 File Offset: 0x0004E500
		[ComVisible(false)]
		public void WriteEvent(EventInstance instance, byte[] data, params object[] values)
		{
			if (instance == null)
			{
				throw new ArgumentNullException("instance");
			}
			string[] array;
			if (values != null)
			{
				array = new string[values.Length];
				for (int i = 0; i < values.Length; i++)
				{
					if (values[i] == null)
					{
						array[i] = string.Empty;
					}
					else
					{
						array[i] = values[i].ToString();
					}
				}
			}
			else
			{
				array = new string[0];
			}
			this.WriteEntry(array, instance.EntryType, instance.InstanceId, (short)instance.CategoryId, data);
		}

		/// <summary>Вносит в журнал событий запись с заданными данными сообщения и строками замещения сообщения, используя указанный зарегистрированный источник событий.</summary>
		/// <param name="source">Имя источника событий, зарегистрированного для приложения на заданном компьютере.</param>
		/// <param name="instance">Экземпляр <see cref="T:System.Diagnostics.EventInstance" />, который представляет локализованную запись журнала событий.</param>
		/// <param name="values">Массив строк для слияния в текстовое сообщение записи журнала событий.</param>
		/// <exception cref="T:System.ArgumentException">Значением <paramref name="source" /> является пустая строка ("").  
		/// -или- 
		/// Значение <paramref name="source" /> равно <see langword="null" />.  
		/// -или- 
		///  <paramref name="instance.InstanceId" /> меньше нуля или больше <see cref="F:System.UInt16.MaxValue" />.  
		/// -или- 
		///  <paramref name="values" /> содержит более 256 элементов.  
		/// -или- 
		/// Один из элементов <paramref name="values" /> длиннее 32766 байт.  
		/// -или- 
		/// При таком имени источника длина пути к разделу реестра превышает 254 символа.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="instance" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Не удается открыть раздел реестра для журнала событий.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Операционная система сообщила об ошибке при записи сведений о событии в журнал событий. Код ошибки Windows недоступен.</exception>
		// Token: 0x060012B6 RID: 4790 RVA: 0x00050375 File Offset: 0x0004E575
		public static void WriteEvent(string source, EventInstance instance, params object[] values)
		{
			EventLog.WriteEvent(source, instance, null, values);
		}

		/// <summary>Вносит в журнал событий запись с заданными данными сообщения, строками замещения сообщения и связанными двоичными данными, используя указанный зарегистрированный источник событий.</summary>
		/// <param name="source">Имя источника событий, зарегистрированного для приложения на заданном компьютере.</param>
		/// <param name="instance">Экземпляр <see cref="T:System.Diagnostics.EventInstance" />, который представляет локализованную запись журнала событий.</param>
		/// <param name="data">Массив байтов, в котором хранятся двоичные данные, связанные с записью.</param>
		/// <param name="values">Массив строк для слияния в текстовое сообщение записи журнала событий.</param>
		/// <exception cref="T:System.ArgumentException">Значением <paramref name="source" /> является пустая строка ("").  
		/// -или- 
		/// Значение <paramref name="source" /> равно <see langword="null" />.  
		/// -или- 
		///  <paramref name="instance.InstanceId" /> меньше нуля или больше <see cref="F:System.UInt16.MaxValue" />.  
		/// -или- 
		///  <paramref name="values" /> содержит более 256 элементов.  
		/// -или- 
		/// Один из элементов <paramref name="values" /> длиннее 32766 байт.  
		/// -или- 
		/// При таком имени источника длина пути к разделу реестра превышает 254 символа.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="instance" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Не удается открыть раздел реестра для журнала событий.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Операционная система сообщила об ошибке при записи сведений о событии в журнал событий. Код ошибки Windows недоступен.</exception>
		// Token: 0x060012B7 RID: 4791 RVA: 0x00050380 File Offset: 0x0004E580
		public static void WriteEvent(string source, EventInstance instance, byte[] data, params object[] values)
		{
			using (EventLog eventLog = new EventLog())
			{
				eventLog.Source = source;
				eventLog.WriteEvent(instance, data, values);
			}
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x000503C0 File Offset: 0x0004E5C0
		internal void OnEntryWritten(EventLogEntry newEntry)
		{
			if (this.doRaiseEvents && this.EntryWritten != null)
			{
				this.EntryWritten(this, new EntryWrittenEventArgs(newEntry));
			}
		}

		/// <summary>Происходит при внесении записи в журнал событий на локальном компьютере.</summary>
		// Token: 0x1400001C RID: 28
		// (add) Token: 0x060012B9 RID: 4793 RVA: 0x000503E4 File Offset: 0x0004E5E4
		// (remove) Token: 0x060012BA RID: 4794 RVA: 0x0005041C File Offset: 0x0004E61C
		[MonitoringDescription("Raised for each EventLog entry written.")]
		public event EntryWrittenEventHandler EntryWritten;

		// Token: 0x060012BB RID: 4795 RVA: 0x00050451 File Offset: 0x0004E651
		internal string GetLogName()
		{
			if (this.logName != null && this.logName.Length > 0)
			{
				return this.logName;
			}
			this.logName = EventLog.LogNameFromSourceName(this.source, this.machineName);
			return this.logName;
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x0005048D File Offset: 0x0004E68D
		private static EventLogImpl CreateEventLogImpl(string logName, string machineName, string source)
		{
			return EventLog.CreateEventLogImpl(new EventLog(logName, machineName, source));
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x0005049C File Offset: 0x0004E69C
		private static EventLogImpl CreateEventLogImpl(EventLog eventLog)
		{
			string eventLogImplType = EventLog.EventLogImplType;
			if (eventLogImplType == "local")
			{
				return new LocalFileEventLog(eventLog);
			}
			if (eventLogImplType == "win32")
			{
				return new Win32EventLog(eventLog);
			}
			if (!(eventLogImplType == "null"))
			{
				throw new NotSupportedException(string.Format(CultureInfo.InvariantCulture, "Eventlog implementation '{0}' is not supported.", EventLog.EventLogImplType));
			}
			return new NullEventLog(eventLog);
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x060012BE RID: 4798 RVA: 0x00050506 File Offset: 0x0004E706
		private static bool Win32EventLogEnabled
		{
			get
			{
				return Environment.OSVersion.Platform == PlatformID.Win32NT;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x060012BF RID: 4799 RVA: 0x00050518 File Offset: 0x0004E718
		private static string EventLogImplType
		{
			get
			{
				string text = Environment.GetEnvironmentVariable("MONO_EVENTLOG_TYPE");
				if (text == null)
				{
					if (EventLog.Win32EventLogEnabled)
					{
						return "win32";
					}
					text = "null";
				}
				else if (EventLog.Win32EventLogEnabled && string.Compare(text, "win32", true) == 0)
				{
					text = "win32";
				}
				else if (string.Compare(text, "null", true) == 0)
				{
					text = "null";
				}
				else
				{
					if (string.Compare(text, 0, "local", 0, "local".Length, true) != 0)
					{
						throw new NotSupportedException(string.Format(CultureInfo.InvariantCulture, "Eventlog implementation '{0}' is not supported.", text));
					}
					text = "local";
				}
				return text;
			}
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x000505B4 File Offset: 0x0004E7B4
		private void WriteEntry(string[] replacementStrings, EventLogEntryType type, long instanceID, short category, byte[] rawData)
		{
			if (this.Source.Length == 0)
			{
				throw new ArgumentException("Source property was not setbefore writing to the event log.");
			}
			if (!Enum.IsDefined(typeof(EventLogEntryType), type))
			{
				throw new InvalidEnumArgumentException("type", (int)type, typeof(EventLogEntryType));
			}
			this.ValidateEventID(instanceID);
			if (!EventLog.SourceExists(this.Source, this.MachineName))
			{
				if (this.Log == null || this.Log.Length == 0)
				{
					this.Log = "Application";
				}
				EventLog.CreateEventSource(this.Source, this.Log, this.MachineName);
			}
			else if (this.logName != null && this.logName.Length != 0)
			{
				string text = EventLog.LogNameFromSourceName(this.Source, this.MachineName);
				if (string.Compare(this.logName, text, true, CultureInfo.InvariantCulture) != 0)
				{
					throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "The source '{0}' is not registered in log '{1}' (it is registered in log '{2}'). The Source and Log properties must be matched, or you may set Log to the empty string, and it will automatically be matched to the Source property.", this.Source, this.logName, text));
				}
			}
			if (rawData == null)
			{
				rawData = new byte[0];
			}
			this.Impl.WriteEntry(replacementStrings, type, (uint)instanceID, category, rawData);
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x000506D8 File Offset: 0x0004E8D8
		private void ValidateEventID(long instanceID)
		{
			int eventID = EventLog.GetEventID(instanceID);
			if (eventID < 0 || eventID > 65535)
			{
				throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "Invalid eventID value '{0}'. It must be in the range between '{1}' and '{2}'.", instanceID, 0, ushort.MaxValue));
			}
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x00050724 File Offset: 0x0004E924
		internal static int GetEventID(long instanceID)
		{
			int num = (int)(((instanceID < 0L) ? (-instanceID) : instanceID) & 1073741823L);
			if (instanceID >= 0L)
			{
				return num;
			}
			return -num;
		}

		// Token: 0x04000AAB RID: 2731
		private string source;

		// Token: 0x04000AAC RID: 2732
		private string logName;

		// Token: 0x04000AAD RID: 2733
		private string machineName;

		// Token: 0x04000AAE RID: 2734
		private bool doRaiseEvents;

		// Token: 0x04000AAF RID: 2735
		private ISynchronizeInvoke synchronizingObject;

		// Token: 0x04000AB0 RID: 2736
		internal const string LOCAL_FILE_IMPL = "local";

		// Token: 0x04000AB1 RID: 2737
		private const string WIN32_IMPL = "win32";

		// Token: 0x04000AB2 RID: 2738
		private const string NULL_IMPL = "null";

		// Token: 0x04000AB3 RID: 2739
		internal const string EVENTLOG_TYPE_VAR = "MONO_EVENTLOG_TYPE";

		// Token: 0x04000AB4 RID: 2740
		private EventLogImpl Impl;
	}
}
