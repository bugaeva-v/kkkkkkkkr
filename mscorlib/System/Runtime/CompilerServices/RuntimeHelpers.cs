using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;
using System.Security;

namespace System.Runtime.CompilerServices
{
	/// <summary>Предоставляет набор статических методов и свойств, которые обеспечивают поддержку компиляторов. Этот класс не наследуется.</summary>
	// Token: 0x02000852 RID: 2130
	public static class RuntimeHelpers
	{
		// Token: 0x060046F1 RID: 18161
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InitializeArray(Array array, IntPtr fldHandle);

		/// <summary>Предоставляет быстрый способ инициализации массива данных, хранящихся в модуле.</summary>
		/// <param name="array">Инициализируемый массив.</param>
		/// <param name="fldHandle">Дескриптор поля, указывающий расположение данных, используемых для инициализации массива.</param>
		// Token: 0x060046F2 RID: 18162 RVA: 0x000E7DBF File Offset: 0x000E5FBF
		public static void InitializeArray(Array array, RuntimeFieldHandle fldHandle)
		{
			if (array == null || fldHandle.Value == IntPtr.Zero)
			{
				throw new ArgumentNullException();
			}
			RuntimeHelpers.InitializeArray(array, fldHandle.Value);
		}

		/// <summary>Получает смещение в байтах к данным в указанной строке.</summary>
		/// <returns>Смещение в байтах от начала объекта <see cref="T:System.String" /> до первого символа строки.</returns>
		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x060046F3 RID: 18163
		public static extern int OffsetToStringData { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		/// <summary>Служит в качестве хэш-функции для конкретного объекта и подходит для использования в алгоритмах и структурах данных, использующих хэш-коды, например в хэш-таблице.</summary>
		/// <param name="o">Объект, для которого нужно извлечь хэш-код.</param>
		/// <returns>Хэш-код для объекта, идентифицируемого по параметру <paramref name="o" />.</returns>
		// Token: 0x060046F4 RID: 18164 RVA: 0x00064577 File Offset: 0x00062777
		public static int GetHashCode(object o)
		{
			return object.InternalGetHashCode(o);
		}

		/// <summary>Определяет, считаются ли равными указанные экземпляры <see cref="T:System.Object" />.</summary>
		/// <param name="o1">Первый из сравниваемых объектов.</param>
		/// <param name="o2">Второй из сравниваемых объектов.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="o1" /> является тем же экземпляром, что и параметр <paramref name="o2" />, или если оба они равны <see langword="null" />, или если o1.Equals(o2) возвращает <see langword="true" />; в противном случае значение <see langword="false" />.</returns>
		// Token: 0x060046F5 RID: 18165 RVA: 0x000E7DEA File Offset: 0x000E5FEA
		public new static bool Equals(object o1, object o2)
		{
			if (o1 == o2)
			{
				return true;
			}
			if (o1 == null || o2 == null)
			{
				return false;
			}
			if (o1 is ValueType)
			{
				return ValueType.DefaultEquals(o1, o2);
			}
			return object.Equals(o1, o2);
		}

		/// <summary>Упаковывает тип значения.</summary>
		/// <param name="obj">Упаковываемый тип значения.</param>
		/// <returns>Упакованная копия <paramref name="obj" />, если это класс значения; в противном случае — <paramref name="obj" />.</returns>
		// Token: 0x060046F6 RID: 18166
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object GetObjectValue(object obj);

		// Token: 0x060046F7 RID: 18167
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void RunClassConstructor(IntPtr type);

		/// <summary>Обеспечивает выполнение инициализатора типа (также называемого статическим конструктором) для указанного типа.</summary>
		/// <param name="type">Дескриптор типа, указывающий тип, для которого следует запустить инициализатор типа.</param>
		/// <exception cref="T:System.TypeInitializationException">Инициализатор типа выдает исключение.</exception>
		// Token: 0x060046F8 RID: 18168 RVA: 0x000E7E11 File Offset: 0x000E6011
		public static void RunClassConstructor(RuntimeTypeHandle type)
		{
			if (type.Value == IntPtr.Zero)
			{
				throw new ArgumentException("Handle is not initialized.", "type");
			}
			RuntimeHelpers.RunClassConstructor(type.Value);
		}

		// Token: 0x060046F9 RID: 18169
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool SufficientExecutionStack();

		/// <summary>Обеспечивает достаточный запас пространства стека для выполнения средней функции платформы .NET Framework.</summary>
		/// <exception cref="T:System.InsufficientExecutionStackException">Доступного стекового пространства для выполнения средней функции .NET Framework. недостаточно.</exception>
		// Token: 0x060046FA RID: 18170 RVA: 0x000E7E42 File Offset: 0x000E6042
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void EnsureSufficientExecutionStack()
		{
			if (RuntimeHelpers.SufficientExecutionStack())
			{
				return;
			}
			throw new InsufficientExecutionStackException();
		}

		// Token: 0x060046FB RID: 18171 RVA: 0x000E7E51 File Offset: 0x000E6051
		public static bool TryEnsureSufficientExecutionStack()
		{
			return RuntimeHelpers.SufficientExecutionStack();
		}

		/// <summary>Выполняет код с помощью делегата <see cref="T:System.Delegate" />, используя другой делегат <see cref="T:System.Delegate" /> для выполнения дополнительного кода в случае исключения.</summary>
		/// <param name="code">Делегат для кода для выполнения попытки.</param>
		/// <param name="backoutCode">Делегат для кода, выполняемого в случае исключения.</param>
		/// <param name="userData">Данные, передаваемые в код <paramref name="code" /> и <paramref name="backoutCode" />.</param>
		// Token: 0x060046FC RID: 18172 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public static void ExecuteCodeWithGuaranteedCleanup(RuntimeHelpers.TryCode code, RuntimeHelpers.CleanupCode backoutCode, object userData)
		{
		}

		/// <summary>Назначает основную часть кода как область с ограничением исполнения (CER).</summary>
		// Token: 0x060046FD RID: 18173 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static void PrepareConstrainedRegions()
		{
		}

		/// <summary>Назначает основную часть кода областью с ограничением исполнения (CER) без какой-либо проверки.</summary>
		// Token: 0x060046FE RID: 18174 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static void PrepareConstrainedRegionsNoOP()
		{
		}

		/// <summary>Проверяет наличие определенного объема стекового пространства, чтобы предотвратить переполнение стека в последующем блоке кода (предполагая, что код использует только конечный и небольшой объем стекового пространства). Рекомендуется вместо этого метода использовать область с ограничением исполнения (CER).</summary>
		// Token: 0x060046FF RID: 18175 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static void ProbeForSufficientStack()
		{
		}

		/// <summary>Указывает, что заданный делегат следует подготовить к включению в область с ограничением исполнения (CER).</summary>
		/// <param name="d">Тип делегата, который следует подготовить.</param>
		// Token: 0x06004700 RID: 18176 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[SecurityCritical]
		public static void PrepareDelegate(Delegate d)
		{
		}

		/// <summary>Предоставляет приложению способ динамической подготовки делегатов событий <see cref="T:System.AppDomain" />.</summary>
		/// <param name="d">Делегат события, который следует подготовить.</param>
		// Token: 0x06004701 RID: 18177 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[SecurityCritical]
		public static void PrepareContractedDelegate(Delegate d)
		{
		}

		/// <summary>Подготавливает метод к включению в область с ограничением исполнения (CER).</summary>
		/// <param name="method">Дескриптор метода, который следует подготовить.</param>
		// Token: 0x06004702 RID: 18178 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public static void PrepareMethod(RuntimeMethodHandle method)
		{
		}

		/// <summary>Подготавливает метод для включения в область с ограничением исполнения (CER) с указанной реализацией.</summary>
		/// <param name="method">Дескриптор метода, который следует подготовить.</param>
		/// <param name="instantiation">Экземпляр для передачи в метод.</param>
		// Token: 0x06004703 RID: 18179 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public static void PrepareMethod(RuntimeMethodHandle method, RuntimeTypeHandle[] instantiation)
		{
		}

		/// <summary>Выполняет указанный метод конструктора модуля.</summary>
		/// <param name="module">Дескриптор, определяющий метод конструктора модуля, который нужно выполнить.</param>
		/// <exception cref="T:System.TypeInitializationException">Конструктор модуля выдает исключение.</exception>
		// Token: 0x06004704 RID: 18180 RVA: 0x000E7E58 File Offset: 0x000E6058
		public static void RunModuleConstructor(ModuleHandle module)
		{
			if (module == ModuleHandle.EmptyHandle)
			{
				throw new ArgumentException("Handle is not initialized.", "module");
			}
			RuntimeHelpers.RunModuleConstructor(module.Value);
		}

		// Token: 0x06004705 RID: 18181
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void RunModuleConstructor(IntPtr module);

		// Token: 0x06004706 RID: 18182 RVA: 0x000E7E83 File Offset: 0x000E6083
		public static bool IsReferenceOrContainsReferences<T>()
		{
			return !typeof(T).IsValueType || RuntimeTypeHandle.HasReferences(typeof(T) as RuntimeType);
		}

		// Token: 0x06004707 RID: 18183 RVA: 0x000E7EAC File Offset: 0x000E60AC
		public static object GetUninitializedObject(Type type)
		{
			return FormatterServices.GetUninitializedObject(type);
		}

		// Token: 0x06004708 RID: 18184 RVA: 0x000E7EB4 File Offset: 0x000E60B4
		public static T[] GetSubArray<T>(T[] array, Range range)
		{
			Type elementType = array.GetType().GetElementType();
			Span<T> span = array.AsSpan(range);
			if (elementType.IsValueType)
			{
				return span.ToArray();
			}
			T[] array2 = (T[])Array.CreateInstance(elementType, span.Length);
			span.CopyTo(array2);
			return array2;
		}

		/// <summary>Представляет делегат для кода, который должен выполняться в блоке try.</summary>
		/// <param name="userData">Данные, передаваемые делегату.</param>
		// Token: 0x02000853 RID: 2131
		// (Invoke) Token: 0x0600470A RID: 18186
		public delegate void TryCode(object userData);

		/// <summary>Представляет метод, выполняемый в случае исключения.</summary>
		/// <param name="userData">Данные, передаваемые делегату.</param>
		/// <param name="exceptionThrown">
		///   <see langword="true" /> означает, что было выдано исключение; в противном случае — <see langword="false" />.</param>
		// Token: 0x02000854 RID: 2132
		// (Invoke) Token: 0x0600470E RID: 18190
		public delegate void CleanupCode(object userData, bool exceptionThrown);
	}
}
