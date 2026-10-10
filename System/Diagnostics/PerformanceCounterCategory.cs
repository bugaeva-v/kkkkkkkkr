using System;
using System.Runtime.CompilerServices;
using System.Security.Permissions;

namespace System.Diagnostics
{
	/// <summary>Представляет объект производительности, который определяет категорию счетчиков производительности.</summary>
	// Token: 0x02000271 RID: 625
	[PermissionSet(SecurityAction.LinkDemand, Unrestricted = true)]
	public sealed class PerformanceCounterCategory
	{
		// Token: 0x060013E6 RID: 5094
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern bool CategoryDelete_icall(char* name, int name_length);

		// Token: 0x060013E7 RID: 5095 RVA: 0x00052790 File Offset: 0x00050990
		private unsafe static bool CategoryDelete(string name)
		{
			char* ptr = name;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			return PerformanceCounterCategory.CategoryDelete_icall(ptr, (name != null) ? name.Length : 0);
		}

		// Token: 0x060013E8 RID: 5096
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern string CategoryHelp_icall(char* category, int category_length);

		// Token: 0x060013E9 RID: 5097 RVA: 0x000527C0 File Offset: 0x000509C0
		private unsafe static string CategoryHelpInternal(string category)
		{
			char* ptr = category;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			return PerformanceCounterCategory.CategoryHelp_icall(ptr, (category != null) ? category.Length : 0);
		}

		// Token: 0x060013EA RID: 5098
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern bool CounterCategoryExists_icall(char* counter, int counter_length, char* category, int category_length);

		// Token: 0x060013EB RID: 5099 RVA: 0x000527F0 File Offset: 0x000509F0
		private unsafe static bool CounterCategoryExists(string counter, string category)
		{
			char* ptr = counter;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			char* ptr2 = category;
			if (ptr2 != null)
			{
				ptr2 += RuntimeHelpers.OffsetToStringData / 2;
			}
			return PerformanceCounterCategory.CounterCategoryExists_icall(ptr, (counter != null) ? counter.Length : 0, ptr2, (category != null) ? category.Length : 0);
		}

		// Token: 0x060013EC RID: 5100
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern bool Create_icall(char* categoryName, int categoryName_length, char* categoryHelp, int categoryHelp_length, PerformanceCounterCategoryType categoryType, CounterCreationData[] items);

		// Token: 0x060013ED RID: 5101 RVA: 0x0005283C File Offset: 0x00050A3C
		private unsafe static bool Create(string categoryName, string categoryHelp, PerformanceCounterCategoryType categoryType, CounterCreationData[] items)
		{
			char* ptr = categoryName;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			char* ptr2 = categoryHelp;
			if (ptr2 != null)
			{
				ptr2 += RuntimeHelpers.OffsetToStringData / 2;
			}
			return PerformanceCounterCategory.Create_icall(ptr, (categoryName != null) ? categoryName.Length : 0, ptr2, (categoryHelp != null) ? categoryHelp.Length : 0, categoryType, items);
		}

		// Token: 0x060013EE RID: 5102
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern bool InstanceExistsInternal_icall(char* instance, int instance_length, char* category, int category_length);

		// Token: 0x060013EF RID: 5103 RVA: 0x0005288C File Offset: 0x00050A8C
		private unsafe static bool InstanceExistsInternal(string instance, string category)
		{
			char* ptr = instance;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			char* ptr2 = category;
			if (ptr2 != null)
			{
				ptr2 += RuntimeHelpers.OffsetToStringData / 2;
			}
			return PerformanceCounterCategory.InstanceExistsInternal_icall(ptr, (instance != null) ? instance.Length : 0, ptr2, (category != null) ? category.Length : 0);
		}

		// Token: 0x060013F0 RID: 5104
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string[] GetCategoryNames();

		// Token: 0x060013F1 RID: 5105
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern string[] GetCounterNames_icall(char* category, int category_length);

		// Token: 0x060013F2 RID: 5106 RVA: 0x000528D8 File Offset: 0x00050AD8
		private unsafe static string[] GetCounterNames(string category)
		{
			char* ptr = category;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			return PerformanceCounterCategory.GetCounterNames_icall(ptr, (category != null) ? category.Length : 0);
		}

		// Token: 0x060013F3 RID: 5107
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern string[] GetInstanceNames_icall(char* category, int category_length);

		// Token: 0x060013F4 RID: 5108 RVA: 0x00052908 File Offset: 0x00050B08
		private unsafe static string[] GetInstanceNames(string category)
		{
			char* ptr = category;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			return PerformanceCounterCategory.GetInstanceNames_icall(ptr, (category != null) ? category.Length : 0);
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x00052937 File Offset: 0x00050B37
		private static void CheckCategory(string categoryName)
		{
			if (categoryName == null)
			{
				throw new ArgumentNullException("categoryName");
			}
			if (categoryName == "")
			{
				throw new ArgumentException("categoryName");
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.PerformanceCounterCategory" />, оставляет пустым свойство <see cref="P:System.Diagnostics.PerformanceCounterCategory.CategoryName" /> и задает в качестве значения свойства <see cref="P:System.Diagnostics.PerformanceCounterCategory.MachineName" /> локальный компьютер.</summary>
		// Token: 0x060013F6 RID: 5110 RVA: 0x0005295F File Offset: 0x00050B5F
		public PerformanceCounterCategory() : this("", ".")
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.PerformanceCounterCategory" />, задает для свойства <see cref="P:System.Diagnostics.PerformanceCounterCategory.CategoryName" /> указанное значение, а в качестве значения свойства <see cref="P:System.Diagnostics.PerformanceCounterCategory.MachineName" /> устанавливает локальный компьютер.</summary>
		/// <param name="categoryName">Имя категории счетчиков производительности (объекта производительности), с которым связывается данный экземпляр <see cref="T:System.Diagnostics.PerformanceCounterCategory" />.</param>
		/// <exception cref="T:System.ArgumentException">Значением параметра <paramref name="categoryName" /> является пустая строка ("").</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="categoryName" /> — <see langword="null" />.</exception>
		// Token: 0x060013F7 RID: 5111 RVA: 0x00052971 File Offset: 0x00050B71
		public PerformanceCounterCategory(string categoryName) : this(categoryName, ".")
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.PerformanceCounterCategory" /> и присваивает свойствам <see cref="P:System.Diagnostics.PerformanceCounterCategory.CategoryName" /> и <see cref="P:System.Diagnostics.PerformanceCounterCategory.MachineName" /> указанные значения.</summary>
		/// <param name="categoryName">Имя категории счетчиков производительности (объекта производительности), с которым связывается данный экземпляр <see cref="T:System.Diagnostics.PerformanceCounterCategory" />.</param>
		/// <param name="machineName">Компьютер, на котором находятся счетчик производительности и связанная с ним категория.</param>
		/// <exception cref="T:System.ArgumentException">Значением параметра <paramref name="categoryName" /> является пустая строка ("").  
		/// -или- 
		/// Неправильный синтаксис параметра <paramref name="machineName" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="categoryName" /> — <see langword="null" />.</exception>
		// Token: 0x060013F8 RID: 5112 RVA: 0x0005297F File Offset: 0x00050B7F
		public PerformanceCounterCategory(string categoryName, string machineName)
		{
			PerformanceCounterCategory.CheckCategory(categoryName);
			if (machineName == null)
			{
				throw new ArgumentNullException("machineName");
			}
			this.categoryName = categoryName;
			this.machineName = machineName;
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x0005248C File Offset: 0x0005068C
		private static bool IsValidMachine(string machine)
		{
			return machine == ".";
		}

		/// <summary>Возвращает текст справки для данной категории.</summary>
		/// <returns>Описание объекта производительности, который измеряется этой категорией.</returns>
		/// <exception cref="T:System.InvalidOperationException">Значение свойства <see cref="P:System.Diagnostics.PerformanceCounterCategory.CategoryName" /> — <see langword="null" />. Перед извлечением справки для категории следует задать ее имя.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Сбой при вызове основного API системы.</exception>
		// Token: 0x170003BB RID: 955
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x000529B0 File Offset: 0x00050BB0
		public string CategoryHelp
		{
			get
			{
				string text = null;
				if (PerformanceCounterCategory.IsValidMachine(this.machineName))
				{
					text = PerformanceCounterCategory.CategoryHelpInternal(this.categoryName);
				}
				if (text != null)
				{
					return text;
				}
				throw new InvalidOperationException();
			}
		}

		/// <summary>Получает или задает имя объекта производительности, который определяет эту категорию.</summary>
		/// <returns>Имя категории счетчиков производительности (объекта производительности), с которым связывается данный экземпляр <see cref="T:System.Diagnostics.PerformanceCounterCategory" />.</returns>
		/// <exception cref="T:System.ArgumentException">Значением параметра <see cref="P:System.Diagnostics.PerformanceCounterCategory.CategoryName" /> является пустая строка ("").</exception>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <see cref="P:System.Diagnostics.PerformanceCounterCategory.CategoryName" /> — <see langword="null" />.</exception>
		// Token: 0x170003BC RID: 956
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x000529E2 File Offset: 0x00050BE2
		// (set) Token: 0x060013FC RID: 5116 RVA: 0x000529EA File Offset: 0x00050BEA
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
					throw new ArgumentNullException("value");
				}
				if (value == "")
				{
					throw new ArgumentException("value");
				}
				this.categoryName = value;
			}
		}

		/// <summary>Получает или задает имя компьютера, на котором находится эта категория.</summary>
		/// <returns>Имя компьютера, на котором находятся категория счетчиков производительности и связанный с ней счетчик.</returns>
		/// <exception cref="T:System.ArgumentException">Неправильный синтаксис параметра <see cref="P:System.Diagnostics.PerformanceCounterCategory.MachineName" />.</exception>
		// Token: 0x170003BD RID: 957
		// (get) Token: 0x060013FD RID: 5117 RVA: 0x00052A19 File Offset: 0x00050C19
		// (set) Token: 0x060013FE RID: 5118 RVA: 0x00052A21 File Offset: 0x00050C21
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
				if (value == "")
				{
					throw new ArgumentException("value");
				}
				this.machineName = value;
			}
		}

		/// <summary>Возвращает тип категории счетчика производительности.</summary>
		/// <returns>Одно из значений <see cref="T:System.Diagnostics.PerformanceCounterCategoryType" />.</returns>
		// Token: 0x170003BE RID: 958
		// (get) Token: 0x060013FF RID: 5119 RVA: 0x00052A50 File Offset: 0x00050C50
		public PerformanceCounterCategoryType CategoryType
		{
			get
			{
				return this.type;
			}
		}

		/// <summary>Определяет, является ли заданный счетчик зарегистрированным в категории, на которую указывают свойства <see cref="P:System.Diagnostics.PerformanceCounterCategory.CategoryName" /> и <see cref="P:System.Diagnostics.PerformanceCounterCategory.MachineName" />.</summary>
		/// <param name="counterName">Имя искомого счетчика производительности.</param>
		/// <returns>Значение <see langword="true" />, если счетчик зарегистрирован в категории, определяемой свойствами <see cref="P:System.Diagnostics.PerformanceCounterCategory.CategoryName" /> и <see cref="P:System.Diagnostics.PerformanceCounterCategory.MachineName" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="counterName" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Свойство <see cref="P:System.Diagnostics.PerformanceCounterCategory.CategoryName" /> не установлено.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Сбой при вызове основного API системы.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x06001400 RID: 5120 RVA: 0x00052A58 File Offset: 0x00050C58
		public bool CounterExists(string counterName)
		{
			return PerformanceCounterCategory.CounterExists(counterName, this.categoryName, this.machineName);
		}

		/// <summary>Определяет, зарегистрирован ли заданный счетчик в указанной категории на локальном компьютере.</summary>
		/// <param name="counterName">Имя искомого счетчика производительности.</param>
		/// <param name="categoryName">Имя категории счетчиков производительности (объекта производительности), с которым связан указанный счетчик производительности.</param>
		/// <returns>Значение <see langword="true" />, если счетчик зарегистрирован в указанной категории на локальном компьютере; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="categoryName" /> — <see langword="null" />.  
		/// -или- 
		/// Значение параметра <paramref name="counterName" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значением параметра <paramref name="categoryName" /> является пустая строка ("").</exception>
		/// <exception cref="T:System.InvalidOperationException">Имя категории не существует.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Сбой при вызове основного API системы.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x06001401 RID: 5121 RVA: 0x00052A6C File Offset: 0x00050C6C
		public static bool CounterExists(string counterName, string categoryName)
		{
			return PerformanceCounterCategory.CounterExists(counterName, categoryName, ".");
		}

		/// <summary>Определяет, зарегистрирован ли заданный счетчик в указанной категории на удаленном компьютере.</summary>
		/// <param name="counterName">Имя искомого счетчика производительности.</param>
		/// <param name="categoryName">Имя категории счетчиков производительности (объекта производительности), с которым связан указанный счетчик производительности.</param>
		/// <param name="machineName">Имя компьютера, на котором находятся категория счетчиков производительности и связанный с ней счетчик.</param>
		/// <returns>Значение <see langword="true" />, если счетчик зарегистрирован в указанной категории на заданном компьютере; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="categoryName" /> — <see langword="null" />.  
		/// -или- 
		/// Значение параметра <paramref name="counterName" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значением параметра <paramref name="categoryName" /> является пустая строка ("").  
		/// -или- 
		/// <paramref name="machineName" /> не является допустимым.</exception>
		/// <exception cref="T:System.InvalidOperationException">Имя категории не существует.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Сбой при вызове основного API системы.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x06001402 RID: 5122 RVA: 0x00052A7A File Offset: 0x00050C7A
		public static bool CounterExists(string counterName, string categoryName, string machineName)
		{
			if (counterName == null)
			{
				throw new ArgumentNullException("counterName");
			}
			PerformanceCounterCategory.CheckCategory(categoryName);
			if (machineName == null)
			{
				throw new ArgumentNullException("machineName");
			}
			return PerformanceCounterCategory.IsValidMachine(machineName) && PerformanceCounterCategory.CounterCategoryExists(counterName, categoryName);
		}

		/// <summary>Регистрирует пользовательскую категорию счетчиков производительности, содержащую указанные счетчики на локальном компьютере.</summary>
		/// <param name="categoryName">Имя пользовательской категории счетчиков производительности, которую нужно создать и зарегистрировать в системе.</param>
		/// <param name="categoryHelp">Описание пользовательской категории.</param>
		/// <param name="counterData">Коллекция <see cref="T:System.Diagnostics.CounterCreationDataCollection" />, в которой определяются счетчики, создаваемые в новой категории.</param>
		/// <returns>Категория <see cref="T:System.Diagnostics.PerformanceCounterCategory" />, связанная с новой пользовательской категорией, или объект производительности.</returns>
		/// <exception cref="T:System.ArgumentException">Имя счетчика, указанное в коллекции <paramref name="counterData" />, — <see langword="null" /> или пустая строка ("").  
		/// -или- 
		/// Счетчик, указанный в коллекции <paramref name="counterData" />, уже существует.  
		/// -или- 
		/// Синтаксис параметра <paramref name="counterName" /> недопустим. Возможно, значение параметра содержит обратную косую черту ("\") или его длина превышает 80 символов.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="categoryName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Категория уже существует на локальном компьютере.  
		/// -или- 
		/// Структура коллекции <paramref name="counterData" /> является неверной для базовых счетчиков. Счетчики типа <see langword="AverageCount64" />, <see langword="AverageTimer32" />, <see langword="CounterMultiTimer" />, <see langword="CounterMultiTimerInverse" />, <see langword="CounterMultiTimer100Ns" />, <see langword="CounterMultiTimer100NsInverse" />, <see langword="RawFraction" />, <see langword="SampleFraction" /> или <see langword="SampleCounter" /> должны непосредственно предшествовать одному из типов базовых счетчиков (<see langword="AverageBase" />, <see langword="MultiBase" />, <see langword="RawBase" /> или <see langword="SampleBase" />).</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Сбой при вызове основного API системы.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x06001403 RID: 5123 RVA: 0x00052AAF File Offset: 0x00050CAF
		[Obsolete("Use another overload that uses PerformanceCounterCategoryType instead")]
		public static PerformanceCounterCategory Create(string categoryName, string categoryHelp, CounterCreationDataCollection counterData)
		{
			return PerformanceCounterCategory.Create(categoryName, categoryHelp, PerformanceCounterCategoryType.Unknown, counterData);
		}

		/// <summary>Регистрирует пользовательскую категорию счетчиков производительности, содержащую на локальном компьютере один счетчик типа <see langword="NumberOfItems32" />.</summary>
		/// <param name="categoryName">Имя пользовательской категории счетчиков производительности, которую нужно создать и зарегистрировать в системе.</param>
		/// <param name="categoryHelp">Описание пользовательской категории.</param>
		/// <param name="counterName">Имя нового счетчика типа <see langword="NumberOfItems32" />, создаваемого в новой категории.</param>
		/// <param name="counterHelp">Описание счетчика, связанного с новой пользовательской категорией.</param>
		/// <returns>Категория <see cref="T:System.Diagnostics.PerformanceCounterCategory" />, связанная с новой системной категорией, или объект производительности.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="counterName" /> равен <see langword="null" /> или является пустой строкой ("").  
		/// -или- 
		/// Счетчик, указанный параметром <paramref name="counterName" />, уже существует.  
		/// -или- 
		///  Синтаксис параметра <paramref name="counterName" /> недопустим. Возможно, значение параметра содержит обратную косую черту ("\") или его длина превышает 80 символов.</exception>
		/// <exception cref="T:System.InvalidOperationException">Категория уже существует на локальном компьютере.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="categoryName" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="counterHelp" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Сбой при вызове основного API системы.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x06001404 RID: 5124 RVA: 0x00052ABA File Offset: 0x00050CBA
		[Obsolete("Use another overload that uses PerformanceCounterCategoryType instead")]
		public static PerformanceCounterCategory Create(string categoryName, string categoryHelp, string counterName, string counterHelp)
		{
			return PerformanceCounterCategory.Create(categoryName, categoryHelp, PerformanceCounterCategoryType.Unknown, counterName, counterHelp);
		}

		/// <summary>Регистрирует пользовательскую категорию счетчиков производительности, содержащую указанные счетчики на локальном компьютере.</summary>
		/// <param name="categoryName">Имя пользовательской категории счетчиков производительности, которую нужно создать и зарегистрировать в системе.</param>
		/// <param name="categoryHelp">Описание пользовательской категории.</param>
		/// <param name="categoryType">Одно из значений <see cref="T:System.Diagnostics.PerformanceCounterCategoryType" />.</param>
		/// <param name="counterData">Коллекция <see cref="T:System.Diagnostics.CounterCreationDataCollection" />, в которой определяются счетчики, создаваемые в новой категории.</param>
		/// <returns>Категория <see cref="T:System.Diagnostics.PerformanceCounterCategory" />, связанная с новой пользовательской категорией, или объект производительности.</returns>
		/// <exception cref="T:System.ArgumentException">Имя счетчика, указанное в коллекции <paramref name="counterData" />, — <see langword="null" /> или пустая строка ("").  
		/// -или- 
		/// Счетчик, указанный в коллекции <paramref name="counterData" />, уже существует.  
		/// -или- 
		///  Синтаксис параметра <paramref name="counterName" /> недопустим. Возможно, значение параметра содержит обратную косую черту ("\") или его длина превышает 80 символов.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="categoryName" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="counterData" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="categoryType" /> выходит за рамки диапазона следующих значений: <see langword="MultiInstance" />, <see langword="SingleInstance" /><see langword="Unknown" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Категория уже существует на локальном компьютере.  
		/// -или- 
		/// Структура коллекции <paramref name="counterData" /> является неверной для базовых счетчиков. Счетчики типа <see langword="AverageCount64" />, <see langword="AverageTimer32" />, <see langword="CounterMultiTimer" />, <see langword="CounterMultiTimerInverse" />, <see langword="CounterMultiTimer100Ns" />, <see langword="CounterMultiTimer100NsInverse" />, <see langword="RawFraction" />, <see langword="SampleFraction" /> или <see langword="SampleCounter" /> должны непосредственно предшествовать одному из типов базовых счетчиков (<see langword="AverageBase" />, <see langword="MultiBase" />, <see langword="RawBase" /> или <see langword="SampleBase" />).</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Сбой при вызове основного API системы.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x06001405 RID: 5125 RVA: 0x00052AC8 File Offset: 0x00050CC8
		public static PerformanceCounterCategory Create(string categoryName, string categoryHelp, PerformanceCounterCategoryType categoryType, CounterCreationDataCollection counterData)
		{
			PerformanceCounterCategory.CheckCategory(categoryName);
			if (counterData == null)
			{
				throw new ArgumentNullException("counterData");
			}
			if (counterData.Count == 0)
			{
				throw new ArgumentException("counterData");
			}
			CounterCreationData[] array = new CounterCreationData[counterData.Count];
			counterData.CopyTo(array, 0);
			if (!PerformanceCounterCategory.Create(categoryName, categoryHelp, categoryType, array))
			{
				throw new InvalidOperationException();
			}
			return new PerformanceCounterCategory(categoryName, categoryHelp);
		}

		/// <summary>Регистрирует пользовательскую категорию счетчиков производительности, содержащую на локальном компьютере один счетчик типа <see cref="F:System.Diagnostics.PerformanceCounterType.NumberOfItems32" />.</summary>
		/// <param name="categoryName">Имя пользовательской категории счетчиков производительности, которую нужно создать и зарегистрировать в системе.</param>
		/// <param name="categoryHelp">Описание пользовательской категории.</param>
		/// <param name="categoryType">Одно из значений <see cref="T:System.Diagnostics.PerformanceCounterCategoryType" />, позволяющих определить тип категории: <see cref="F:System.Diagnostics.PerformanceCounterCategoryType.MultiInstance" />, <see cref="F:System.Diagnostics.PerformanceCounterCategoryType.SingleInstance" /> или <see cref="F:System.Diagnostics.PerformanceCounterCategoryType.Unknown" />.</param>
		/// <param name="counterName">Имя нового счетчика, создаваемого в новой категории.</param>
		/// <param name="counterHelp">Описание счетчика, связанного с новой пользовательской категорией.</param>
		/// <returns>Категория <see cref="T:System.Diagnostics.PerformanceCounterCategory" />, связанная с новой системной категорией, или объект производительности.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="counterName" /> равен <see langword="null" /> или является пустой строкой ("").  
		/// -или- 
		/// Счетчик, указанный параметром <paramref name="counterName" />, уже существует.  
		/// -или- 
		///  Синтаксис параметра <paramref name="counterName" /> недопустим. Возможно, значение параметра содержит обратную косую черту ("\") или его длина превышает 80 символов.</exception>
		/// <exception cref="T:System.InvalidOperationException">Категория уже существует на локальном компьютере.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="categoryName" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="counterHelp" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Сбой при вызове основного API системы.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x06001406 RID: 5126 RVA: 0x00052B28 File Offset: 0x00050D28
		public static PerformanceCounterCategory Create(string categoryName, string categoryHelp, PerformanceCounterCategoryType categoryType, string counterName, string counterHelp)
		{
			PerformanceCounterCategory.CheckCategory(categoryName);
			if (!PerformanceCounterCategory.Create(categoryName, categoryHelp, categoryType, new CounterCreationData[]
			{
				new CounterCreationData(counterName, counterHelp, PerformanceCounterType.NumberOfItems32)
			}))
			{
				throw new InvalidOperationException();
			}
			return new PerformanceCounterCategory(categoryName, categoryHelp);
		}

		/// <summary>Удаляет категорию и связанные с ней счетчики с локального компьютера.</summary>
		/// <param name="categoryName">Имя удаляемой пользовательской категории счетчиков производительности.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="categoryName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Синтаксис параметра <paramref name="categoryName" /> недопустим. Возможно, значение параметра содержит обратную косую черту ("\") или его длина превышает 80 символов.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Сбой при вызове основного API системы.</exception>
		/// <exception cref="T:System.InvalidOperationException">Не удается удалить категорию, поскольку она не является пользовательской.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x06001407 RID: 5127 RVA: 0x00052B6A File Offset: 0x00050D6A
		public static void Delete(string categoryName)
		{
			PerformanceCounterCategory.CheckCategory(categoryName);
			if (!PerformanceCounterCategory.CategoryDelete(categoryName))
			{
				throw new InvalidOperationException();
			}
		}

		/// <summary>Определяет, зарегистрирована ли категория на локальном компьютере.</summary>
		/// <param name="categoryName">Имя искомой категории счетчиков производительности.</param>
		/// <returns>Если категория зарегистрирована, значение <see langword="true" />, если нет, значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="categoryName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="categoryName" /> представляет собой пустую строку ("").</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Сбой при вызове основного API системы.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x06001408 RID: 5128 RVA: 0x00052B80 File Offset: 0x00050D80
		public static bool Exists(string categoryName)
		{
			return PerformanceCounterCategory.Exists(categoryName, ".");
		}

		/// <summary>Определяет, зарегистрирована ли категория на указанном компьютере.</summary>
		/// <param name="categoryName">Имя искомой категории счетчиков производительности.</param>
		/// <param name="machineName">Имя компьютера для проверки категории.</param>
		/// <returns>Если категория зарегистрирована, значение <see langword="true" />, если нет, значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="categoryName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="categoryName" /> представляет собой пустую строку ("").  
		/// -или- 
		/// Параметр <paramref name="machineName" /> является недопустимым.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Сбой при вызове основного API системы.</exception>
		/// <exception cref="T:System.IO.IOException">Сетевой путь не найден.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">У вызывающего объекта отсутствует необходимое разрешение.  
		/// -или- 
		/// Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x06001409 RID: 5129 RVA: 0x00052B8D File Offset: 0x00050D8D
		public static bool Exists(string categoryName, string machineName)
		{
			PerformanceCounterCategory.CheckCategory(categoryName);
			return PerformanceCounterCategory.IsValidMachine(machineName) && PerformanceCounterCategory.CounterCategoryExists(null, categoryName);
		}

		/// <summary>Извлекает список категорий счетчиков производительности, зарегистрированных на локальном компьютере.</summary>
		/// <returns>Массив объектов <see cref="T:System.Diagnostics.PerformanceCounterCategory" />, которыми определяются категории, зарегистрированные на локальном компьютере.</returns>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Сбой при вызове основного API системы.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x0600140A RID: 5130 RVA: 0x00052BA6 File Offset: 0x00050DA6
		public static PerformanceCounterCategory[] GetCategories()
		{
			return PerformanceCounterCategory.GetCategories(".");
		}

		/// <summary>Извлекает список категорий счетчиков производительности, зарегистрированных на заданном компьютере.</summary>
		/// <param name="machineName">Компьютер, на котором будет производиться поиск.</param>
		/// <returns>Массив объектов <see cref="T:System.Diagnostics.PerformanceCounterCategory" />, указывающих на категории, зарегистрированные на заданном компьютере.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="machineName" /> является недопустимым.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Сбой при вызове основного API системы.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x0600140B RID: 5131 RVA: 0x00052BB4 File Offset: 0x00050DB4
		public static PerformanceCounterCategory[] GetCategories(string machineName)
		{
			if (machineName == null)
			{
				throw new ArgumentNullException("machineName");
			}
			if (!PerformanceCounterCategory.IsValidMachine(machineName))
			{
				return Array.Empty<PerformanceCounterCategory>();
			}
			string[] categoryNames = PerformanceCounterCategory.GetCategoryNames();
			PerformanceCounterCategory[] array = new PerformanceCounterCategory[categoryNames.Length];
			for (int i = 0; i < categoryNames.Length; i++)
			{
				array[i] = new PerformanceCounterCategory(categoryNames[i], machineName);
			}
			return array;
		}

		/// <summary>Извлекает список счетчиков в категории счетчиков производительности, содержащей только один экземпляр.</summary>
		/// <returns>Массив объектов <see cref="T:System.Diagnostics.PerformanceCounter" />, обозначающих счетчики, связанные с категорией счетчиков производительности с единственным экземпляром.</returns>
		/// <exception cref="T:System.ArgumentException">Категория не является категорией с единственным экземпляром.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Сбой при вызове основного API системы.</exception>
		/// <exception cref="T:System.InvalidOperationException">У категории нет связанного с ней экземпляра.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x0600140C RID: 5132 RVA: 0x00052C07 File Offset: 0x00050E07
		public PerformanceCounter[] GetCounters()
		{
			return this.GetCounters("");
		}

		/// <summary>Извлекает список счетчиков в категории счетчиков производительности, содержащей один или несколько экземпляров.</summary>
		/// <param name="instanceName">Экземпляр объекта производительности, для которого нужно извлечь список связанных с ним счетчиков.</param>
		/// <returns>Массив объектов <see cref="T:System.Diagnostics.PerformanceCounter" />, обозначающих счетчики, связанные с указанным экземпляром объекта этой категории счетчиков производительности.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="instanceName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Значение свойства <see cref="P:System.Diagnostics.PerformanceCounterCategory.CategoryName" /> для данного экземпляра <see cref="T:System.Diagnostics.PerformanceCounterCategory" /> не задано.  
		/// -или- 
		/// Категория не содержит экземпляр, заданный параметром <paramref name="instanceName" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Сбой при вызове основного API системы.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x0600140D RID: 5133 RVA: 0x00052C14 File Offset: 0x00050E14
		public PerformanceCounter[] GetCounters(string instanceName)
		{
			if (!PerformanceCounterCategory.IsValidMachine(this.machineName))
			{
				return Array.Empty<PerformanceCounter>();
			}
			string[] counterNames = PerformanceCounterCategory.GetCounterNames(this.categoryName);
			PerformanceCounter[] array = new PerformanceCounter[counterNames.Length];
			for (int i = 0; i < counterNames.Length; i++)
			{
				array[i] = new PerformanceCounter(this.categoryName, counterNames[i], instanceName, this.machineName);
			}
			return array;
		}

		/// <summary>Извлекает список экземпляров объекта производительности, связанных с данной категорией.</summary>
		/// <returns>Массив строк, представляющих имена экземпляров объекта производительности, связанных с этой категории или, если категория содержит только один экземпляр объекта производительности, одноэлементный массив, содержащий пустую строку ("").</returns>
		/// <exception cref="T:System.InvalidOperationException">Значение свойства <see cref="P:System.Diagnostics.PerformanceCounterCategory.CategoryName" /> — <see langword="null" />. Возможно, свойство не задано.  
		/// -или- 
		/// У категории нет связанного с ней экземпляра.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Сбой при вызове основного API системы.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x0600140E RID: 5134 RVA: 0x00052C70 File Offset: 0x00050E70
		public string[] GetInstanceNames()
		{
			if (!PerformanceCounterCategory.IsValidMachine(this.machineName))
			{
				return Array.Empty<string>();
			}
			return PerformanceCounterCategory.GetInstanceNames(this.categoryName);
		}

		/// <summary>Определяет, существует ли указанный экземпляр объекта производительности в категории, определяемой свойством <see cref="T:System.Diagnostics.PerformanceCounterCategory" /> объекта <see cref="P:System.Diagnostics.PerformanceCounterCategory.CategoryName" />.</summary>
		/// <param name="instanceName">Искомый экземпляр объекта производительности в данной категории счетчиков производительности.</param>
		/// <returns>Если категория содержит указанный экземпляр объекта производительности, значение <see langword="true" />, если нет, значение <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Значение свойства <see cref="P:System.Diagnostics.PerformanceCounterCategory.CategoryName" /> — <see langword="null" />. Возможно, свойство не задано.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="instanceName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Сбой при вызове основного API системы.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x0600140F RID: 5135 RVA: 0x00052C90 File Offset: 0x00050E90
		public bool InstanceExists(string instanceName)
		{
			return PerformanceCounterCategory.InstanceExists(instanceName, this.categoryName, this.machineName);
		}

		/// <summary>Определяет, содержит ли указанная категория заданный экземпляр объекта производительности на локальном компьютере.</summary>
		/// <param name="instanceName">Искомый экземпляр объекта производительности.</param>
		/// <param name="categoryName">Искомая категория счетчиков производительности.</param>
		/// <returns>Если категория содержит указанный экземпляр объекта производительности, значение <see langword="true" />, если нет, значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="instanceName" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Параметр <paramref name="categoryName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="categoryName" /> представляет собой пустую строку ("").</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Сбой при вызове основного API системы.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x06001410 RID: 5136 RVA: 0x00052CA4 File Offset: 0x00050EA4
		public static bool InstanceExists(string instanceName, string categoryName)
		{
			return PerformanceCounterCategory.InstanceExists(instanceName, categoryName, ".");
		}

		/// <summary>Определяет, содержит ли указанная категория на заданном компьютере заданный экземпляр объекта производительности.</summary>
		/// <param name="instanceName">Искомый экземпляр объекта производительности.</param>
		/// <param name="categoryName">Искомая категория счетчиков производительности.</param>
		/// <param name="machineName">Имя компьютера, на котором будет производиться поиск экземпляра и соответствующей категории.</param>
		/// <returns>Если категория содержит указанный экземпляр объекта производительности, значение <see langword="true" />, если нет, значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="instanceName" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Параметр <paramref name="categoryName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="categoryName" /> представляет собой пустую строку ("").  
		/// -или- 
		/// Параметр <paramref name="machineName" /> является недопустимым.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Сбой при вызове основного API системы.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x06001411 RID: 5137 RVA: 0x00052CB2 File Offset: 0x00050EB2
		public static bool InstanceExists(string instanceName, string categoryName, string machineName)
		{
			if (instanceName == null)
			{
				throw new ArgumentNullException("instanceName");
			}
			PerformanceCounterCategory.CheckCategory(categoryName);
			if (machineName == null)
			{
				throw new ArgumentNullException("machineName");
			}
			return PerformanceCounterCategory.InstanceExistsInternal(instanceName, categoryName);
		}

		/// <summary>Считывает все счетчики и данные экземпляра объекта производительности, связанные с этой категорией счетчиков производительности.</summary>
		/// <returns>Коллекция <see cref="T:System.Diagnostics.InstanceDataCollectionCollection" />, содержащая данные счетчика и экземпляра объекта производительности для данной категории.</returns>
		/// <exception cref="T:System.InvalidOperationException">Значение свойства <see cref="P:System.Diagnostics.PerformanceCounterCategory.CategoryName" /> — <see langword="null" />. Возможно, свойство не задано.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Сбой при вызове основного API системы.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Код, выполняющийся без привилегий администратора, предпринял попытку считывания значения счетчика производительности.</exception>
		// Token: 0x06001412 RID: 5138 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public InstanceDataCollectionCollection ReadCategory()
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000B19 RID: 2841
		private string categoryName;

		// Token: 0x04000B1A RID: 2842
		private string machineName;

		// Token: 0x04000B1B RID: 2843
		private PerformanceCounterCategoryType type = PerformanceCounterCategoryType.Unknown;
	}
}
