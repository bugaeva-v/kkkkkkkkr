using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace System.Diagnostics
{
	/// <summary>Представляет компонент счетчика производительности Windows NT.</summary>
	// Token: 0x02000270 RID: 624
	[InstallerType(typeof(PerformanceCounterInstaller))]
	public sealed class PerformanceCounter : Component, ISupportInitialize
	{
		/// <summary>Выполняет инициализацию нового, доступного только для чтения экземпляра класса <see cref="T:System.Diagnostics.PerformanceCounter" />, не связывая этот экземпляр с каким-нибудь системным или определенным пользователем счетчиком производительности.</summary>
		/// <exception cref="T:System.PlatformNotSupportedException">Используемая платформа, Windows 98 или Windows Millennium Edition (Me), не поддерживает счетчики производительности.</exception>
		// Token: 0x060013BD RID: 5053 RVA: 0x00052310 File Offset: 0x00050510
		public PerformanceCounter()
		{
			this.categoryName = (this.counterName = (this.instanceName = ""));
			this.machineName = ".";
		}

		/// <summary>Выполняет инициализацию нового, доступного только для чтения экземпляра класса <see cref="T:System.Diagnostics.PerformanceCounter" /> и связывает этот экземпляр с конкретным системным или определенным пользователем счетчиком производительности на локальном компьютере. Этот конструктор требует, чтобы категория имела единственный экземпляр.</summary>
		/// <param name="categoryName">Имя категории счетчика производительности (объект производительности), которому соответствует этот счетчик производительности.</param>
		/// <param name="counterName">Имя счетчика производительности.</param>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="categoryName" /> является пустой строкой ("").  
		///
		/// или - 
		/// Параметр <paramref name="counterName" /> является пустой строкой ("").  
		///
		/// -или- 
		/// Указанная категория не существует.  
		///
		/// или - 
		/// Указанная категория отмечается как многоэкземплярная и требует создания счетчика производительности с именем экземпляра.  
		///
		/// -или- 
		///  Параметры <paramref name="categoryName" /> и <paramref name="counterName" /> были локализованы на разных языках.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="categoryName" /> или <paramref name="counterName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Произошла ошибка при обращении к API-интерфейсу системы.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используемая платформа, Windows 98 или Windows Millennium Edition (Me), не поддерживает счетчики производительности.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x060013BE RID: 5054 RVA: 0x0005234B File Offset: 0x0005054B
		public PerformanceCounter(string categoryName, string counterName) : this(categoryName, counterName, false)
		{
		}

		/// <summary>Выполняет инициализацию нового, доступного только для чтения или для чтения и записи экземпляра класса <see cref="T:System.Diagnostics.PerformanceCounter" /> и связывает этот экземпляр с конкретным системным или определенным пользователем счетчиком производительности на локальном компьютере. Этот конструктор требует, чтобы категория содержала единственный экземпляр.</summary>
		/// <param name="categoryName">Имя категории счетчика производительности (объект производительности), которому соответствует этот счетчик производительности.</param>
		/// <param name="counterName">Имя счетчика производительности.</param>
		/// <param name="readOnly">Значение <see langword="true" /> для доступа к счетчику в режиме только для чтения (хотя сам счетчик может быть для чтения/записи); значение <see langword="false" /> для доступа к счетчику в режиме чтения/записи.</param>
		/// <exception cref="T:System.InvalidOperationException">Значением параметра <paramref name="categoryName" /> является пустая строка ("").  
		///
		/// или - 
		/// Значением параметра <paramref name="counterName" /> является пустая строка ("").  
		///
		/// -или- 
		/// Указанная категория не существует. (если <paramref name="readOnly" /> равен <see langword="true" />).  
		/// -или- 
		/// Заданная категория не является определенной пользователем .NET Framework категорией (если <paramref name="readOnly" /> равен <see langword="false" />).  
		/// -или- 
		/// Указанная категория отмечается как многоэкземплярная и требует создания счетчика производительности с именем экземпляра.  
		/// -или- 
		///  Параметры <paramref name="categoryName" /> и <paramref name="counterName" /> были локализованы на разных языках.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="categoryName" /> или <paramref name="counterName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Произошла ошибка при обращении к API-интерфейсу системы.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используемая платформа, Windows 98 или Windows Millennium Edition (Me), не поддерживает счетчики производительности.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x060013BF RID: 5055 RVA: 0x00052356 File Offset: 0x00050556
		public PerformanceCounter(string categoryName, string counterName, bool readOnly) : this(categoryName, counterName, "", readOnly)
		{
		}

		/// <summary>Выполняет инициализацию нового, доступного только для чтения экземпляра класса <see cref="T:System.Diagnostics.PerformanceCounter" /> и связывает этот экземпляр с конкретным системным или определенным пользователем счетчиком производительности и экземпляром категории на локальном компьютере.</summary>
		/// <param name="categoryName">Имя категории счетчика производительности (объект производительности), которому соответствует этот счетчик производительности.</param>
		/// <param name="counterName">Имя счетчика производительности.</param>
		/// <param name="instanceName">Имя экземпляра категории счетчика производительности или пустая строка (""), если категория содержит единственный экземпляр.</param>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="categoryName" /> является пустой строкой ("").  
		/// -или- 
		///  Параметр <paramref name="counterName" /> является пустой строкой ("").  
		///
		/// или - 
		/// Задана недопустимая категория.  
		///
		/// -или- 
		/// Указанная категория отмечается как многоэкземплярная и требует создания счетчика производительности с именем экземпляра.  
		/// -или- 
		///  Длина параметра <paramref name="instanceName" /> превышает 127 символов.  
		/// -или- 
		///  Параметры <paramref name="categoryName" /> и <paramref name="counterName" /> были локализованы на разных языках.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="categoryName" /> или <paramref name="counterName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Произошла ошибка при обращении к API-интерфейсу системы.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используемая платформа, Windows 98 или Windows Millennium Edition (Me), не поддерживает счетчики производительности.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x060013C0 RID: 5056 RVA: 0x00052366 File Offset: 0x00050566
		public PerformanceCounter(string categoryName, string counterName, string instanceName) : this(categoryName, counterName, instanceName, false)
		{
		}

		/// <summary>Выполняет инициализацию нового, доступного только для чтения или для чтения и записи экземпляра класса <see cref="T:System.Diagnostics.PerformanceCounter" /> и связывает этот экземпляр с конкретным системным или определенным пользователем счетчиком производительности и экземпляром категории на локальном компьютере.</summary>
		/// <param name="categoryName">Имя категории счетчика производительности (объект производительности), которому соответствует этот счетчик производительности.</param>
		/// <param name="counterName">Имя счетчика производительности.</param>
		/// <param name="instanceName">Имя экземпляра категории счетчика производительности или пустая строка (""), если категория содержит единственный экземпляр.</param>
		/// <param name="readOnly">Значение <see langword="true" /> для доступа к счетчику в режиме только для чтения; значение <see langword="false" /> для доступа к счетчику в режиме чтения/записи.</param>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="categoryName" /> является пустой строкой ("").  
		/// -или- 
		///  Параметр <paramref name="counterName" /> является пустой строкой ("").  
		/// -или- 
		/// Запрошенные параметры настройки разрешения на чтение/запись являются недопустимыми для этого счетчика.  
		/// -или- 
		/// Указанная категория не существует (если <paramref name="readOnly" /> равен <see langword="true" />).  
		/// -или- 
		/// Заданная категория не является определенной пользователем .NET Framework категорией (если <paramref name="readOnly" /> равен <see langword="false" />).  
		/// -или- 
		/// Указанная категория отмечается как многоэкземплярная и требует создания счетчика производительности с именем экземпляра.  
		///
		/// или - 
		/// Длина параметра <paramref name="instanceName" /> превышает 127 символов.  
		///
		/// -или- 
		///  Параметры <paramref name="categoryName" /> и <paramref name="counterName" /> были локализованы на разных языках.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="categoryName" /> или <paramref name="counterName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Произошла ошибка при обращении к API-интерфейсу системы.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используемая платформа, Windows 98 или Windows Millennium Edition (Me), не поддерживает счетчики производительности.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x060013C1 RID: 5057 RVA: 0x00052374 File Offset: 0x00050574
		public PerformanceCounter(string categoryName, string counterName, string instanceName, bool readOnly)
		{
			if (categoryName == null)
			{
				throw new ArgumentNullException("categoryName");
			}
			if (counterName == null)
			{
				throw new ArgumentNullException("counterName");
			}
			if (instanceName == null)
			{
				throw new ArgumentNullException("instanceName");
			}
			this.CategoryName = categoryName;
			this.CounterName = counterName;
			if (categoryName == "" || counterName == "")
			{
				throw new InvalidOperationException();
			}
			this.InstanceName = instanceName;
			this.instanceName = instanceName;
			this.machineName = ".";
			this.readOnly = readOnly;
			this.changed = true;
		}

		/// <summary>Выполняет инициализацию нового, доступного только для чтения экземпляра класса <see cref="T:System.Diagnostics.PerformanceCounter" /> и связывает этот экземпляр с конкретным системным или определенным пользователем счетчиком производительности на указанном компьютере.</summary>
		/// <param name="categoryName">Имя категории счетчика производительности (объект производительности), которому соответствует этот счетчик производительности.</param>
		/// <param name="counterName">Имя счетчика производительности.</param>
		/// <param name="instanceName">Имя экземпляра категории счетчика производительности или пустая строка (""), если категория содержит единственный экземпляр.</param>
		/// <param name="machineName">Компьютер, на котором существуют счетчик производительности и связанная с ним категория.</param>
		/// <exception cref="T:System.InvalidOperationException">Параметр <paramref name="categoryName" /> является пустой строкой ("").  
		/// -или- 
		///  Параметр <paramref name="counterName" /> является пустой строкой ("").  
		/// -или- 
		/// Запрошенные параметры настройки разрешения на чтение/запись являются недопустимыми для этого счетчика.  
		///
		/// или - 
		/// Счетчика не существует на указанном компьютере.  
		///
		/// или - 
		/// Указанная категория отмечается как многоэкземплярная и требует создания счетчика производительности с именем экземпляра.  
		///
		/// или - 
		/// Длина параметра <paramref name="instanceName" /> превышает 127 символов.  
		///
		///
		/// -или- 
		///  Параметры <paramref name="categoryName" /> и <paramref name="counterName" /> были локализованы на разных языках.</exception>
		/// <exception cref="T:System.ArgumentException">Недопустимый параметр <paramref name="machineName" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="categoryName" /> или <paramref name="counterName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Произошла ошибка при обращении к API-интерфейсу системы.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используемая платформа, Windows 98 или Windows Millennium Edition (Me), не поддерживает счетчики производительности.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x060013C2 RID: 5058 RVA: 0x00052407 File Offset: 0x00050607
		public PerformanceCounter(string categoryName, string counterName, string instanceName, string machineName) : this(categoryName, counterName, instanceName, false)
		{
			this.machineName = machineName;
		}

		// Token: 0x060013C3 RID: 5059
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern IntPtr GetImpl_icall(char* category, int category_length, char* counter, int counter_length, char* instance, int instance_length, out PerformanceCounterType ctype, out bool custom);

		// Token: 0x060013C4 RID: 5060 RVA: 0x0005241C File Offset: 0x0005061C
		private unsafe static IntPtr GetImpl(string category, string counter, string instance, out PerformanceCounterType ctype, out bool custom)
		{
			char* ptr = category;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			char* ptr2 = counter;
			if (ptr2 != null)
			{
				ptr2 += RuntimeHelpers.OffsetToStringData / 2;
			}
			char* ptr3 = instance;
			if (ptr3 != null)
			{
				ptr3 += RuntimeHelpers.OffsetToStringData / 2;
			}
			return PerformanceCounter.GetImpl_icall(ptr, (category != null) ? category.Length : 0, ptr2, (counter != null) ? counter.Length : 0, ptr3, (instance != null) ? instance.Length : 0, out ctype, out custom);
		}

		// Token: 0x060013C5 RID: 5061
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetSample(IntPtr impl, bool only_value, out CounterSample sample);

		// Token: 0x060013C6 RID: 5062
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern long UpdateValue(IntPtr impl, bool do_incr, long value);

		// Token: 0x060013C7 RID: 5063
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void FreeData(IntPtr impl);

		// Token: 0x060013C8 RID: 5064 RVA: 0x0005248C File Offset: 0x0005068C
		private static bool IsValidMachine(string machine)
		{
			return machine == ".";
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x0005249C File Offset: 0x0005069C
		private void UpdateInfo()
		{
			if (this.impl != IntPtr.Zero)
			{
				this.Close();
			}
			if (PerformanceCounter.IsValidMachine(this.machineName))
			{
				this.impl = PerformanceCounter.GetImpl(this.categoryName, this.counterName, this.instanceName, out this.type, out this.is_custom);
			}
			if (!this.is_custom)
			{
				this.readOnly = true;
			}
			this.changed = false;
		}

		/// <summary>Получает или задает имя категории счетчика производительности для этого счетчика производительности.</summary>
		/// <returns>Имя категории счетчика производительности (объект производительности), которому соответствует этот счетчик производительности.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <see cref="P:System.Diagnostics.PerformanceCounter.CategoryName" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используемая платформа, Windows 98 или Windows Millennium Edition (Me), не поддерживает счетчики производительности.</exception>
		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x060013CA RID: 5066 RVA: 0x0005250D File Offset: 0x0005070D
		// (set) Token: 0x060013CB RID: 5067 RVA: 0x00052515 File Offset: 0x00050715
		[SRDescription("The category name for this performance counter.")]
		[ReadOnly(true)]
		[DefaultValue("")]
		[TypeConverter("System.Diagnostics.Design.CategoryValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[SettingsBindable(true)]
		public string CategoryName
		{
			get
			{
				return this.categoryName;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("categoryName");
				}
				this.categoryName = value;
				this.changed = true;
			}
		}

		/// <summary>Получает описание для этого счетчика производительности.</summary>
		/// <returns>Описание элемента или количества, которое измеряет этот счетчик производительности.</returns>
		/// <exception cref="T:System.InvalidOperationException">Экземпляр класса <see cref="T:System.Diagnostics.PerformanceCounter" /> не связан со счетчиком производительности.  
		/// -или- 
		/// При использовании глобальной общей памяти свойству <see cref="P:System.Diagnostics.PerformanceCounter.InstanceLifetime" /> присваивается значение <see cref="F:System.Diagnostics.PerformanceCounterInstanceLifetime.Process" />.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используемая платформа, Windows 98 или Windows Millennium Edition (Me), не поддерживает счетчики производительности.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x060013CC RID: 5068 RVA: 0x00052533 File Offset: 0x00050733
		[MonitoringDescription("A description describing the counter.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[ReadOnly(true)]
		[MonoTODO]
		public string CounterHelp
		{
			get
			{
				return "";
			}
		}

		/// <summary>Получает или задает имя категории счетчика производительности, связанного с данным экземпляром <see cref="T:System.Diagnostics.PerformanceCounter" />.</summary>
		/// <returns>Имя счетчика, который описывает подсчитываемое количество. Имя, отображаемое в списке счетчиков закладки диспетчера счетчиков производительности MMC в диалоговом окне "Добавить счетчики".</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <see cref="P:System.Diagnostics.PerformanceCounter.CounterName" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используемая платформа, Windows 98 или Windows Millennium Edition (Me), не поддерживает счетчики производительности.</exception>
		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x060013CD RID: 5069 RVA: 0x0005253A File Offset: 0x0005073A
		// (set) Token: 0x060013CE RID: 5070 RVA: 0x00052542 File Offset: 0x00050742
		[TypeConverter("System.Diagnostics.Design.CounterNameConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[DefaultValue("")]
		[SRDescription("The name of this performance counter.")]
		[SettingsBindable(true)]
		[ReadOnly(true)]
		public string CounterName
		{
			get
			{
				return this.counterName;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("counterName");
				}
				this.counterName = value;
				this.changed = true;
			}
		}

		/// <summary>Получает тип счетчика, с которым связан счетчик производительности.</summary>
		/// <returns>Значение <see cref="T:System.Diagnostics.PerformanceCounterType" />, которое описывает, каким образом счетчик взаимодействует с отслеживающим приложением, и характер значений, которые он содержит (например, подсчитано или не подсчитано).</returns>
		/// <exception cref="T:System.InvalidOperationException">Экземпляр класса, неправильно связанный со счетчиком производительности.  
		/// -или- 
		/// При использовании глобальной общей памяти свойству <see cref="P:System.Diagnostics.PerformanceCounter.InstanceLifetime" /> присваивается значение <see cref="F:System.Diagnostics.PerformanceCounterInstanceLifetime.Process" />.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используемая платформа, Windows 98 или Windows Millennium Edition (Me), не поддерживает счетчики производительности.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x060013CF RID: 5071 RVA: 0x00052560 File Offset: 0x00050760
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The type of the counter.")]
		public PerformanceCounterType CounterType
		{
			get
			{
				if (this.changed)
				{
					this.UpdateInfo();
				}
				return this.type;
			}
		}

		/// <summary>Получает или задает время существования процесса.</summary>
		/// <returns>Одно из значений <see cref="T:System.Diagnostics.PerformanceCounterInstanceLifetime" />. Значение по умолчанию — <see cref="F:System.Diagnostics.PerformanceCounterInstanceLifetime.Global" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Присвоенное значение не является членом перечисления <see cref="T:System.Diagnostics.PerformanceCounterInstanceLifetime" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="P:System.Diagnostics.PerformanceCounter.InstanceLifetime" /> задается после инициализации <see cref="T:System.Diagnostics.PerformanceCounter" />.</exception>
		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x060013D0 RID: 5072 RVA: 0x00052576 File Offset: 0x00050776
		// (set) Token: 0x060013D1 RID: 5073 RVA: 0x0005257E File Offset: 0x0005077E
		[MonoTODO]
		[DefaultValue(PerformanceCounterInstanceLifetime.Global)]
		public PerformanceCounterInstanceLifetime InstanceLifetime
		{
			get
			{
				return this.lifetime;
			}
			set
			{
				this.lifetime = value;
			}
		}

		/// <summary>Получает или задает имя экземпляра для этого счетчика производительности.</summary>
		/// <returns>Имя экземпляра категории счетчика производительности или пустая строка (""), если счетчик является единственным экземпляром.</returns>
		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x060013D2 RID: 5074 RVA: 0x00052587 File Offset: 0x00050787
		// (set) Token: 0x060013D3 RID: 5075 RVA: 0x0005258F File Offset: 0x0005078F
		[DefaultValue("")]
		[ReadOnly(true)]
		[SettingsBindable(true)]
		[TypeConverter("System.Diagnostics.Design.InstanceNameConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[SRDescription("The instance name for this performance counter.")]
		public string InstanceName
		{
			get
			{
				return this.instanceName;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.instanceName = value;
				this.changed = true;
			}
		}

		/// <summary>Получает или задает имя компьютера для этого счетчика производительности.</summary>
		/// <returns>Сервер, на котором постоянно находятся счетчик производительности и связанная с ним категория.</returns>
		/// <exception cref="T:System.ArgumentException">Недопустимый формат <see cref="P:System.Diagnostics.PerformanceCounter.MachineName" />.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используемая платформа, Windows 98 или Windows Millennium Edition (Me), не поддерживает счетчики производительности.</exception>
		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x000525AD File Offset: 0x000507AD
		// (set) Token: 0x060013D5 RID: 5077 RVA: 0x000525B8 File Offset: 0x000507B8
		[SRDescription("The machine where this performance counter resides.")]
		[SettingsBindable(true)]
		[DefaultValue(".")]
		[MonoTODO("What's the machine name format?")]
		[Browsable(false)]
		public string MachineName
		{
			get
			{
				return this.machineName;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				if (value == "" || value == ".")
				{
					this.machineName = ".";
					this.changed = true;
					return;
				}
				throw new PlatformNotSupportedException();
			}
		}

		/// <summary>Получает или задает начальное или не рассчитанное значение этого счетчика.</summary>
		/// <returns>Начальное значение счетчика.</returns>
		/// <exception cref="T:System.InvalidOperationException">Попытка установить начальное значение счетчика, но счетчик доступен только для чтения.  
		///
		/// или - 
		/// Экземпляр класса, неправильно связанный со счетчиком производительности.  
		///
		/// или - 
		/// При использовании глобальной общей памяти свойству <see cref="P:System.Diagnostics.PerformanceCounter.InstanceLifetime" /> присваивается значение <see cref="F:System.Diagnostics.PerformanceCounterInstanceLifetime.Process" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Произошла ошибка при обращении к API-интерфейсу системы.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используемая платформа, Windows 98 или Windows Millennium Edition (Me), не поддерживает счетчики производительности.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x060013D6 RID: 5078 RVA: 0x00052608 File Offset: 0x00050808
		// (set) Token: 0x060013D7 RID: 5079 RVA: 0x00052639 File Offset: 0x00050839
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The raw value of the counter.")]
		public long RawValue
		{
			get
			{
				if (this.changed)
				{
					this.UpdateInfo();
				}
				CounterSample counterSample;
				PerformanceCounter.GetSample(this.impl, true, out counterSample);
				return counterSample.RawValue;
			}
			set
			{
				if (this.changed)
				{
					this.UpdateInfo();
				}
				if (this.readOnly)
				{
					throw new InvalidOperationException();
				}
				PerformanceCounter.UpdateValue(this.impl, false, value);
			}
		}

		/// <summary>Получает или задает значение, определяющее, доступен ли экземпляр <see cref="T:System.Diagnostics.PerformanceCounter" /> только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если экземпляр <see cref="T:System.Diagnostics.PerformanceCounter" /> доступен только для чтения (даже если сам счетчик является определенным счетчиком .NET Framework); значение <see langword="false" />, если счетчик работает в режиме чтения/записи. Значение по умолчанию — значение, заданное конструктором.</returns>
		// Token: 0x170003BA RID: 954
		// (get) Token: 0x060013D8 RID: 5080 RVA: 0x00052665 File Offset: 0x00050865
		// (set) Token: 0x060013D9 RID: 5081 RVA: 0x0005266D File Offset: 0x0005086D
		[Browsable(false)]
		[MonitoringDescription("The accessability level of the counter.")]
		[DefaultValue(true)]
		public bool ReadOnly
		{
			get
			{
				return this.readOnly;
			}
			set
			{
				this.readOnly = value;
			}
		}

		/// <summary>Начинает инициализацию экземпляра <see cref="T:System.Diagnostics.PerformanceCounter" />, используемого в форме или другим компонентом. Инициализация происходит во время выполнения.</summary>
		// Token: 0x060013DA RID: 5082 RVA: 0x00003917 File Offset: 0x00001B17
		public void BeginInit()
		{
		}

		/// <summary>Завершает инициализацию экземпляра <see cref="T:System.Diagnostics.PerformanceCounter" />, используемого в форме или другим компонентом. Инициализация происходит во время выполнения.</summary>
		// Token: 0x060013DB RID: 5083 RVA: 0x00003917 File Offset: 0x00001B17
		public void EndInit()
		{
		}

		/// <summary>Закрывает счетчик производительности и высвобождает все ресурсы, распределенные под этот экземпляр счетчика производительности.</summary>
		// Token: 0x060013DC RID: 5084 RVA: 0x00052678 File Offset: 0x00050878
		public void Close()
		{
			IntPtr value = this.impl;
			this.impl = IntPtr.Zero;
			if (value != IntPtr.Zero)
			{
				PerformanceCounter.FreeData(value);
			}
		}

		/// <summary>Высвобождает разделенное состояние библиотеки счетчика производительности, распределенное под счетчики.</summary>
		// Token: 0x060013DD RID: 5085 RVA: 0x00003917 File Offset: 0x00001B17
		public static void CloseSharedResources()
		{
		}

		/// <summary>Уменьшает значение связанного счетчика производительности на единицу через эффективные атомарные операции.</summary>
		/// <returns>Уменьшенное значение счетчика.</returns>
		/// <exception cref="T:System.InvalidOperationException">Счетчик доступен только для чтения, поэтому приложение не может уменьшить его значение.  
		/// -или- 
		/// Экземпляр класса, неправильно связанный со счетчиком производительности.  
		/// -или- 
		/// При использовании глобальной общей памяти свойству <see cref="P:System.Diagnostics.PerformanceCounter.InstanceLifetime" /> присваивается значение <see cref="F:System.Diagnostics.PerformanceCounterInstanceLifetime.Process" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Произошла ошибка при обращении к API-интерфейсу системы.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используемая платформа, Windows 98 или Windows Millennium Edition (Me), не поддерживает счетчики производительности.</exception>
		// Token: 0x060013DE RID: 5086 RVA: 0x000526AA File Offset: 0x000508AA
		public long Decrement()
		{
			return this.IncrementBy(-1L);
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x000526B4 File Offset: 0x000508B4
		protected override void Dispose(bool disposing)
		{
			this.Close();
		}

		/// <summary>Увеличивает значение связанного счетчика производительности на единицу через эффективные атомарные операции.</summary>
		/// <returns>Увеличенное значение счетчика.</returns>
		/// <exception cref="T:System.InvalidOperationException">Счетчик доступен только для чтения, поэтому приложение не может увеличить его значение.  
		/// -или- 
		/// Экземпляр класса, неправильно связанный со счетчиком производительности.  
		///
		/// или - 
		/// При использовании глобальной общей памяти свойству <see cref="P:System.Diagnostics.PerformanceCounter.InstanceLifetime" /> присваивается значение <see cref="F:System.Diagnostics.PerformanceCounterInstanceLifetime.Process" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Произошла ошибка при обращении к API-интерфейсу системы.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используемая платформа, Windows 98 или Windows Millennium Edition (Me), не поддерживает счетчики производительности.</exception>
		// Token: 0x060013E0 RID: 5088 RVA: 0x000526BC File Offset: 0x000508BC
		public long Increment()
		{
			return this.IncrementBy(1L);
		}

		/// <summary>Увеличивает или уменьшает значение связанного счетчика производительности на заданное значение посредством эффективных атомарных операций.</summary>
		/// <param name="value">Увеличиваемое значение. (Отрицательное значение уменьшает счетчик.)</param>
		/// <returns>Новое значение счетчика.</returns>
		/// <exception cref="T:System.InvalidOperationException">Счетчик доступен только для чтения, поэтому приложение не может увеличить его значение.  
		///
		/// или - 
		/// Экземпляр класса, неправильно связанный со счетчиком производительности.  
		///
		/// -или- 
		/// При использовании глобальной общей памяти свойству <see cref="P:System.Diagnostics.PerformanceCounter.InstanceLifetime" /> присваивается значение <see cref="F:System.Diagnostics.PerformanceCounterInstanceLifetime.Process" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Произошла ошибка при обращении к API-интерфейсу системы.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используемая платформа, Windows 98 или Windows Millennium Edition (Me), не поддерживает счетчики производительности.</exception>
		// Token: 0x060013E1 RID: 5089 RVA: 0x000526C6 File Offset: 0x000508C6
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public long IncrementBy(long value)
		{
			if (this.changed)
			{
				this.UpdateInfo();
			}
			if (this.readOnly)
			{
				return 0L;
			}
			return PerformanceCounter.UpdateValue(this.impl, true, value);
		}

		/// <summary>Получает образец счетчика и возвращает начальное или не рассчитанное значение для него.</summary>
		/// <returns>Тип <see cref="T:System.Diagnostics.CounterSample" />, представляющий следующее начальное значение, которое система получает для этого счетчика.</returns>
		/// <exception cref="T:System.InvalidOperationException">Экземпляр класса, неправильно связанный со счетчиком производительности.  
		/// -или- 
		/// При использовании глобальной общей памяти свойству <see cref="P:System.Diagnostics.PerformanceCounter.InstanceLifetime" /> присваивается значение <see cref="F:System.Diagnostics.PerformanceCounterInstanceLifetime.Process" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Произошла ошибка при обращении к API-интерфейсу системы.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используемая платформа, Windows 98 или Windows Millennium Edition (Me), не поддерживает счетчики производительности.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x060013E2 RID: 5090 RVA: 0x000526F0 File Offset: 0x000508F0
		public CounterSample NextSample()
		{
			if (this.changed)
			{
				this.UpdateInfo();
			}
			CounterSample result;
			PerformanceCounter.GetSample(this.impl, false, out result);
			this.valid_old = true;
			this.old_sample = result;
			return result;
		}

		/// <summary>Получает образец счетчика и возвращает расчетное значение для него.</summary>
		/// <returns>Следующее расчетное значение, получаемое системой для этого счетчика.</returns>
		/// <exception cref="T:System.InvalidOperationException">Экземпляр класса, неправильно связанный со счетчиком производительности.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Произошла ошибка при обращении к API-интерфейсу системы.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используемая платформа, Windows 98 или Windows Millennium Edition (Me), не поддерживает счетчики производительности.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x060013E3 RID: 5091 RVA: 0x0005272C File Offset: 0x0005092C
		public float NextValue()
		{
			if (this.changed)
			{
				this.UpdateInfo();
			}
			CounterSample newSample;
			PerformanceCounter.GetSample(this.impl, false, out newSample);
			float result;
			if (this.valid_old)
			{
				result = CounterSampleCalculator.ComputeCounterValue(this.old_sample, newSample);
			}
			else
			{
				result = CounterSampleCalculator.ComputeCounterValue(newSample);
			}
			this.valid_old = true;
			this.old_sample = newSample;
			return result;
		}

		/// <summary>Удаляет экземпляр категории, указанной объектом <see cref="T:System.Diagnostics.PerformanceCounter" /> свойства <see cref="P:System.Diagnostics.PerformanceCounter.InstanceName" />.</summary>
		/// <exception cref="T:System.InvalidOperationException">Счетчик доступен только для чтения, поэтому любой экземпляр, связанный с данной категорией, не может быть удален.  
		///
		/// или - 
		/// Экземпляр класса, неправильно связанный со счетчиком производительности.  
		///
		/// -или- 
		/// При использовании глобальной общей памяти свойству <see cref="P:System.Diagnostics.PerformanceCounter.InstanceLifetime" /> присваивается значение <see cref="F:System.Diagnostics.PerformanceCounterInstanceLifetime.Process" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Произошла ошибка при обращении к API-интерфейсу системы.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Используемая платформа, Windows 98 или Windows Millennium Edition (Me), не поддерживает счетчики производительности.</exception>
		// Token: 0x060013E4 RID: 5092 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public void RemoveInstance()
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000B0C RID: 2828
		private string categoryName;

		// Token: 0x04000B0D RID: 2829
		private string counterName;

		// Token: 0x04000B0E RID: 2830
		private string instanceName;

		// Token: 0x04000B0F RID: 2831
		private string machineName;

		// Token: 0x04000B10 RID: 2832
		private IntPtr impl;

		// Token: 0x04000B11 RID: 2833
		private PerformanceCounterType type;

		// Token: 0x04000B12 RID: 2834
		private CounterSample old_sample;

		// Token: 0x04000B13 RID: 2835
		private bool readOnly;

		// Token: 0x04000B14 RID: 2836
		private bool valid_old;

		// Token: 0x04000B15 RID: 2837
		private bool changed;

		// Token: 0x04000B16 RID: 2838
		private bool is_custom;

		// Token: 0x04000B17 RID: 2839
		private PerformanceCounterInstanceLifetime lifetime;

		/// <summary>Он указывает размер глобальной памяти в байтах, используемой счетчиками производительности. Размер по умолчанию равен 524,288 байт.</summary>
		// Token: 0x04000B18 RID: 2840
		[Obsolete]
		public static int DefaultFileMappingSize = 524288;
	}
}
