using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security;

namespace System
{
	/// <summary>Управляет системным сборщиком мусора — службой, которая автоматически высвобождает неиспользуемую память.</summary>
	// Token: 0x020001FF RID: 511
	public static class GC
	{
		// Token: 0x060015EC RID: 5612
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetCollectionCount(int generation);

		// Token: 0x060015ED RID: 5613
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetMaxGeneration();

		// Token: 0x060015EE RID: 5614
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InternalCollect(int generation);

		// Token: 0x060015EF RID: 5615
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void RecordPressure(long bytesAllocated);

		// Token: 0x060015F0 RID: 5616
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void register_ephemeron_array(Ephemeron[] array);

		// Token: 0x060015F1 RID: 5617
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern object get_ephemeron_tombstone();

		// Token: 0x060015F2 RID: 5618 RVA: 0x00056B65 File Offset: 0x00054D65
		internal static void GetMemoryInfo(out uint highMemLoadThreshold, out ulong totalPhysicalMem, out uint lastRecordedMemLoad, out UIntPtr lastRecordedHeapSize, out UIntPtr lastRecordedFragmentation)
		{
			highMemLoadThreshold = 0U;
			totalPhysicalMem = ulong.MaxValue;
			lastRecordedMemLoad = 0U;
			lastRecordedHeapSize = UIntPtr.Zero;
			lastRecordedFragmentation = UIntPtr.Zero;
		}

		/// <summary>Возвращает общее число байтов, выделенных для текущего потока с начала времени его существования.</summary>
		/// <returns>Общее число байтов, выделенных для текущего потока с начала времени его существования.</returns>
		// Token: 0x060015F3 RID: 5619
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long GetAllocatedBytesForCurrentThread();

		/// <summary>Информирует среду выполнения о выделении большого объема неуправляемой памяти, которую необходимо учесть при планировании сборки мусора.</summary>
		/// <param name="bytesAllocated">Дополнительный объем выделенной неуправляемой памяти.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="bytesAllocated" /> меньше или равно 0.  
		/// -или- 
		/// На 32-разрядном компьютере <paramref name="bytesAllocated" /> больше <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x060015F4 RID: 5620 RVA: 0x00056B80 File Offset: 0x00054D80
		[SecurityCritical]
		public static void AddMemoryPressure(long bytesAllocated)
		{
			if (bytesAllocated <= 0L)
			{
				throw new ArgumentOutOfRangeException("bytesAllocated", Environment.GetResourceString("Positive number required."));
			}
			if (4 == IntPtr.Size && bytesAllocated > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("pressure", Environment.GetResourceString("Value must be non-negative and less than or equal to Int32.MaxValue."));
			}
			GC.RecordPressure(bytesAllocated);
		}

		/// <summary>Информирует среду выполнения о том, что неуправляемая память освобождена и ее более не требуется учитывать при планировании сборки мусора.</summary>
		/// <param name="bytesAllocated">Объем освобожденной неуправляемой памяти.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="bytesAllocated" /> меньше или равно 0.  
		/// -или- 
		/// На 32-разрядном компьютере <paramref name="bytesAllocated" /> больше <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x060015F5 RID: 5621 RVA: 0x00056BD4 File Offset: 0x00054DD4
		[SecurityCritical]
		public static void RemoveMemoryPressure(long bytesAllocated)
		{
			if (bytesAllocated <= 0L)
			{
				throw new ArgumentOutOfRangeException("bytesAllocated", Environment.GetResourceString("Positive number required."));
			}
			if (4 == IntPtr.Size && bytesAllocated > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("bytesAllocated", Environment.GetResourceString("Value must be non-negative and less than or equal to Int32.MaxValue."));
			}
			GC.RecordPressure(-bytesAllocated);
		}

		/// <summary>Возвращает номер текущего поколения указанного объекта.</summary>
		/// <param name="obj">Объект, информация о поколении которого извлекается.</param>
		/// <returns>Текущий номер поколения <paramref name="obj" />.</returns>
		// Token: 0x060015F6 RID: 5622
		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetGeneration(object obj);

		/// <summary>Принудительно начинает немедленную сборку мусора, начиная с нулевого поколения и вплоть до указанного поколения.</summary>
		/// <param name="generation">Количество старших поколений, для которых следует выполнить сборку мусора.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Недопустимый параметр <paramref name="generation" />.</exception>
		// Token: 0x060015F7 RID: 5623 RVA: 0x00056C28 File Offset: 0x00054E28
		public static void Collect(int generation)
		{
			GC.Collect(generation, GCCollectionMode.Default);
		}

		/// <summary>Принудительно запускает немедленную сборку мусора для всех поколений.</summary>
		// Token: 0x060015F8 RID: 5624 RVA: 0x00056C31 File Offset: 0x00054E31
		[SecuritySafeCritical]
		public static void Collect()
		{
			GC.InternalCollect(GC.MaxGeneration);
		}

		/// <summary>Принудительно запускает немедленную сборку мусора начиная с нулевого поколения и вплоть до указанного поколения в момент времени, заданный значением <see cref="T:System.GCCollectionMode" />.</summary>
		/// <param name="generation">Количество старших поколений, для которых следует выполнить сборку мусора.</param>
		/// <param name="mode">Значение перечисления, указывающее, является ли сборка мусора принудительной (<see cref="F:System.GCCollectionMode.Default" /> или <see cref="F:System.GCCollectionMode.Forced" />) или оптимизированной (<see cref="F:System.GCCollectionMode.Optimized" />).</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Недопустимый параметр <paramref name="generation" />.  
		/// -или- 
		///  <paramref name="mode" /> не является одним из значений <see cref="T:System.GCCollectionMode" />.</exception>
		// Token: 0x060015F9 RID: 5625 RVA: 0x00056C3D File Offset: 0x00054E3D
		[SecuritySafeCritical]
		public static void Collect(int generation, GCCollectionMode mode)
		{
			GC.Collect(generation, mode, true);
		}

		/// <summary>Принудительная сборка мусора с поколения 0 до указанного поколения во время, указанное значением <see cref="T:System.GCCollectionMode" />, со значением, указывающим, должна ли сборка быть блокирующей.</summary>
		/// <param name="generation">Количество старших поколений, для которых следует выполнить сборку мусора.</param>
		/// <param name="mode">Значение перечисления, указывающее, является ли сборка мусора принудительной (<see cref="F:System.GCCollectionMode.Default" /> или <see cref="F:System.GCCollectionMode.Forced" />) или оптимизированной (<see cref="F:System.GCCollectionMode.Optimized" />).</param>
		/// <param name="blocking">Значение <see langword="true" /> для выполнения блокирующей сборки мусора; значение <see langword="false" /> для выполнения фоновой сборки мусора, где это возможно.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Недопустимый параметр <paramref name="generation" />.  
		/// -или- 
		///  <paramref name="mode" /> не является одним из значений <see cref="T:System.GCCollectionMode" />.</exception>
		// Token: 0x060015FA RID: 5626 RVA: 0x00056C47 File Offset: 0x00054E47
		[SecuritySafeCritical]
		public static void Collect(int generation, GCCollectionMode mode, bool blocking)
		{
			GC.Collect(generation, mode, blocking, false);
		}

		/// <summary>Принудительная сборка мусора с поколения 0 до указанного поколения во время, указанное значением <see cref="T:System.GCCollectionMode" />, со значениями, указывающими, должна ли сборка быть блокирующей и сжимающей.</summary>
		/// <param name="generation">Количество старших поколений, для которых следует выполнить сборку мусора.</param>
		/// <param name="mode">Значение перечисления, указывающее, является ли сборка мусора принудительной (<see cref="F:System.GCCollectionMode.Default" /> или <see cref="F:System.GCCollectionMode.Forced" />) или оптимизированной (<see cref="F:System.GCCollectionMode.Optimized" />).</param>
		/// <param name="blocking">Значение <see langword="true" /> для выполнения блокирующей сборки мусора; значение <see langword="false" /> для выполнения фоновой сборки мусора, где это возможно.</param>
		/// <param name="compacting">Значение <see langword="true" />, чтобы сжимать кучу маленьких объектов; значение <see langword="false" />, чтобы только очищать.</param>
		// Token: 0x060015FB RID: 5627 RVA: 0x00056C54 File Offset: 0x00054E54
		[SecuritySafeCritical]
		public static void Collect(int generation, GCCollectionMode mode, bool blocking, bool compacting)
		{
			if (generation < 0)
			{
				throw new ArgumentOutOfRangeException("generation", Environment.GetResourceString("Value must be positive."));
			}
			if (mode < GCCollectionMode.Default || mode > GCCollectionMode.Optimized)
			{
				throw new ArgumentOutOfRangeException("mode", Environment.GetResourceString("Enum value was out of legal range."));
			}
			int num = 0;
			if (mode == GCCollectionMode.Optimized)
			{
				num |= 4;
			}
			if (compacting)
			{
				num |= 8;
			}
			if (blocking)
			{
				num |= 2;
			}
			else if (!compacting)
			{
				num |= 1;
			}
			GC.InternalCollect(generation);
		}

		/// <summary>Возвращает количество операций сборки мусора, выполненных для заданного поколения объектов.</summary>
		/// <param name="generation">Поколение объектов, для которого будет определено количество операций сборки мусора.</param>
		/// <returns>Количество операций сборки мусора, выполненных для заданного поколения объектов с начала процесса.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="generation" /> меньше 0.</exception>
		// Token: 0x060015FC RID: 5628 RVA: 0x00056CBE File Offset: 0x00054EBE
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[SecuritySafeCritical]
		public static int CollectionCount(int generation)
		{
			if (generation < 0)
			{
				throw new ArgumentOutOfRangeException("generation", Environment.GetResourceString("Value must be positive."));
			}
			return GC.GetCollectionCount(generation);
		}

		/// <summary>Ссылается на указанный объект, делая его недоступным для сборщика мусора с момента начала текущей процедуры до вызова этого метода.</summary>
		/// <param name="obj">Объект для ссылки.</param>
		// Token: 0x060015FD RID: 5629 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void KeepAlive(object obj)
		{
		}

		/// <summary>Возвращает текущий номер поколения для целевого объекта указанной слабой ссылки.</summary>
		/// <param name="wo">Объект <see cref="T:System.WeakReference" />, указывающий на целевой объект, номер поколения которого требуется определить.</param>
		/// <returns>Текущий номер поколения для целевого объекта <paramref name="wo" />.</returns>
		/// <exception cref="T:System.ArgumentException">Сборка мусора уже выполнена для <paramref name="wo" />.</exception>
		// Token: 0x060015FE RID: 5630 RVA: 0x00056CDF File Offset: 0x00054EDF
		[SecuritySafeCritical]
		public static int GetGeneration(WeakReference wo)
		{
			object target = wo.Target;
			if (target == null)
			{
				throw new ArgumentException();
			}
			return GC.GetGeneration(target);
		}

		/// <summary>Возвращает наибольшее число поколений, поддерживаемое системой в настоящее время.</summary>
		/// <returns>Значение от нуля до максимального числа поддерживаемых поколений.</returns>
		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060015FF RID: 5631 RVA: 0x00056CF5 File Offset: 0x00054EF5
		public static int MaxGeneration
		{
			[SecuritySafeCritical]
			get
			{
				return GC.GetMaxGeneration();
			}
		}

		/// <summary>Приостанавливает текущий поток до тех пор, пока поток, обрабатывающий очередь методов завершения, не обработает всю очередь.</summary>
		// Token: 0x06001600 RID: 5632
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void WaitForPendingFinalizers();

		// Token: 0x06001601 RID: 5633
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void _SuppressFinalize(object o);

		/// <summary>Сообщает среде CLR, что она на не должна вызывать метод завершения для указанного объекта.</summary>
		/// <param name="obj">Объект, метод завершения для которого не должен выполняться.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="obj" /> — <see langword="null" />.</exception>
		// Token: 0x06001602 RID: 5634 RVA: 0x00056CFC File Offset: 0x00054EFC
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[SecuritySafeCritical]
		public static void SuppressFinalize(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			GC._SuppressFinalize(obj);
		}

		// Token: 0x06001603 RID: 5635
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void _ReRegisterForFinalize(object o);

		/// <summary>Требует, чтобы система вызвала метод завершения для указанного объекта, для которого ранее был вызван метод <see cref="M:System.GC.SuppressFinalize(System.Object)" />.</summary>
		/// <param name="obj">Объект, для которого должен быть вызван метод завершения.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="obj" /> — <see langword="null" />.</exception>
		// Token: 0x06001604 RID: 5636 RVA: 0x00056D12 File Offset: 0x00054F12
		[SecuritySafeCritical]
		public static void ReRegisterForFinalize(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			GC._ReRegisterForFinalize(obj);
		}

		/// <summary>Извлекает предполагаемое количество выделенных в данный момент байтов. Параметр указывает, может ли этот метод выдержать короткий интервал времени ожидания перед возвратом, пока система выполняет сборку мусора и завершает объекты.</summary>
		/// <param name="forceFullCollection">Значение <see langword="true" />, указывающий, что перед возвратом этот метод может дождаться выполнения сборки мусора; в противном случае — <see langword="false" />.</param>
		/// <returns>Наилучшая доступная аппроксимация числа байтов, распределенных в данный момент в управляемой памяти.</returns>
		// Token: 0x06001605 RID: 5637
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long GetTotalMemory(bool forceFullCollection);

		// Token: 0x06001606 RID: 5638 RVA: 0x000479F8 File Offset: 0x00045BF8
		private static bool _RegisterForFullGCNotification(int maxGenerationPercentage, int largeObjectHeapPercentage)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x000479F8 File Offset: 0x00045BF8
		private static bool _CancelFullGCNotification()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x000479F8 File Offset: 0x00045BF8
		private static int _WaitForFullGCApproach(int millisecondsTimeout)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x000479F8 File Offset: 0x00045BF8
		private static int _WaitForFullGCComplete(int millisecondsTimeout)
		{
			throw new NotImplementedException();
		}

		/// <summary>Указывает, что необходимо отправлять уведомления о сборке мусора, когда соблюдены условия для полной сборки мусора и когда завершена сборка.</summary>
		/// <param name="maxGenerationThreshold">Число от 1 до 99, указывающее условия создания уведомления в зависимости от объектов, выделенных в поколение 2.</param>
		/// <param name="largeObjectHeapThreshold">Число от 1 до 99, указывающее условия создания уведомления в зависимости от объектов, помещенных в кучу больших объектов.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="maxGenerationThreshold" /> или <paramref name="largeObjectHeapThreshold" /> не входит в диапазон от 1 до 99.</exception>
		/// <exception cref="T:System.InvalidOperationException">Этот член недоступен, если включена параллельная сборка мусора. Сведения об отключении параллельной сборки мусора см. в статье, посвященной параметру среды выполнения &lt;gcConcurrent&gt;.</exception>
		// Token: 0x0600160A RID: 5642 RVA: 0x00056D28 File Offset: 0x00054F28
		[SecurityCritical]
		public static void RegisterForFullGCNotification(int maxGenerationThreshold, int largeObjectHeapThreshold)
		{
			if (maxGenerationThreshold <= 0 || maxGenerationThreshold >= 100)
			{
				throw new ArgumentOutOfRangeException("maxGenerationThreshold", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument must be between {0} and {1}."), 1, 99));
			}
			if (largeObjectHeapThreshold <= 0 || largeObjectHeapThreshold >= 100)
			{
				throw new ArgumentOutOfRangeException("largeObjectHeapThreshold", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Argument must be between {0} and {1}."), 1, 99));
			}
			if (!GC._RegisterForFullGCNotification(maxGenerationThreshold, largeObjectHeapThreshold))
			{
				throw new InvalidOperationException(Environment.GetResourceString("This API is not available when the concurrent GC is enabled."));
			}
		}

		/// <summary>Отменяет регистрацию уведомления о сборке мусора.</summary>
		/// <exception cref="T:System.InvalidOperationException">Этот член недоступен, если включена параллельная сборка мусора. Сведения об отключении параллельной сборки мусора см. в статье, посвященной параметру среды выполнения &lt;gcConcurrent&gt;.</exception>
		// Token: 0x0600160B RID: 5643 RVA: 0x00056DB8 File Offset: 0x00054FB8
		[SecurityCritical]
		public static void CancelFullGCNotification()
		{
			if (!GC._CancelFullGCNotification())
			{
				throw new InvalidOperationException(Environment.GetResourceString("This API is not available when the concurrent GC is enabled."));
			}
		}

		/// <summary>Возвращает состояние зарегистрированного уведомления, чтобы определить, является ли неизбежной полная, блокирующая сборка мусора средой CLR.</summary>
		/// <returns>Состояние зарегистрированного уведомления о сборке мусора.</returns>
		// Token: 0x0600160C RID: 5644 RVA: 0x00056DD1 File Offset: 0x00054FD1
		[SecurityCritical]
		public static GCNotificationStatus WaitForFullGCApproach()
		{
			return (GCNotificationStatus)GC._WaitForFullGCApproach(-1);
		}

		/// <summary>Возвращает состояние зарегистрированного уведомления в пределах указанного времени ожидания, чтобы определить, является ли неизбежной полная блокировка сборки мусора средой CLR.</summary>
		/// <param name="millisecondsTimeout">Продолжительность времени ожидания, прежде чем можно извлечь состояние уведомления. Укажите значение -1, если период ожидания неограниченный.</param>
		/// <returns>Состояние зарегистрированного уведомления о сборке мусора.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="millisecondsTimeout" /> должно быть либо неотрицательным, либо меньше или равно <see cref="F:System.Int32.MaxValue" /> или –1.</exception>
		// Token: 0x0600160D RID: 5645 RVA: 0x00056DD9 File Offset: 0x00054FD9
		[SecurityCritical]
		public static GCNotificationStatus WaitForFullGCApproach(int millisecondsTimeout)
		{
			if (millisecondsTimeout < -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout", Environment.GetResourceString("Number must be either non-negative and less than or equal to Int32.MaxValue or -1."));
			}
			return (GCNotificationStatus)GC._WaitForFullGCApproach(millisecondsTimeout);
		}

		/// <summary>Возвращает состояние зарегистрированного уведомления, чтобы определить, завершена ли полная блокировка сборки мусора средой CLR.</summary>
		/// <returns>Состояние зарегистрированного уведомления о сборке мусора.</returns>
		// Token: 0x0600160E RID: 5646 RVA: 0x00056DFA File Offset: 0x00054FFA
		[SecurityCritical]
		public static GCNotificationStatus WaitForFullGCComplete()
		{
			return (GCNotificationStatus)GC._WaitForFullGCComplete(-1);
		}

		/// <summary>Возвращает состояние зарегистрированного уведомления в пределах указанного времени ожидания, чтобы определить, завершена ли полная блокировка сборки мусора средой CLR.</summary>
		/// <param name="millisecondsTimeout">Продолжительность времени ожидания, прежде чем можно извлечь состояние уведомления. Укажите значение -1, если период ожидания неограниченный.</param>
		/// <returns>Состояние зарегистрированного уведомления о сборке мусора.</returns>
		/// <exception cref="T:System.InvalidOperationException">Значение <paramref name="millisecondsTimeout" /> должно быть либо неотрицательным, либо меньше или равно <see cref="F:System.Int32.MaxValue" /> или –1.</exception>
		// Token: 0x0600160F RID: 5647 RVA: 0x00056E02 File Offset: 0x00055002
		[SecurityCritical]
		public static GCNotificationStatus WaitForFullGCComplete(int millisecondsTimeout)
		{
			if (millisecondsTimeout < -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout", Environment.GetResourceString("Number must be either non-negative and less than or equal to Int32.MaxValue or -1."));
			}
			return (GCNotificationStatus)GC._WaitForFullGCComplete(millisecondsTimeout);
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x000479F8 File Offset: 0x00045BF8
		[SecurityCritical]
		private static bool StartNoGCRegionWorker(long totalSize, bool hasLohSize, long lohSize, bool disallowFullBlockingGC)
		{
			throw new NotImplementedException();
		}

		/// <summary>Пытается запретить сборку мусора во время выполнения критического пути, если доступен указанный достаточный объем памяти.</summary>
		/// <param name="totalSize">Объем памяти в байтах для выделения без запуска сборки мусора. Он должен быть меньше или равен размеру временного сегмента. Сведения о размере эфемерных сегментов см. в разделе "Эфемерные поколения и сегменты" статьи Основы сборки мусора.</param>
		/// <returns>Значение <see langword="true" />, если среде выполнения удалось зафиксировать необходимый объем памяти и сборщик мусора может перейти в режим задержки без области сборки мусора; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="totalSize" /> превышает размер эфемерного сегмента.</exception>
		/// <exception cref="T:System.InvalidOperationException">Процесс уже находится в режиме задержки без области сборки мусора.</exception>
		// Token: 0x06001611 RID: 5649 RVA: 0x00056E23 File Offset: 0x00055023
		[SecurityCritical]
		public static bool TryStartNoGCRegion(long totalSize)
		{
			return GC.StartNoGCRegionWorker(totalSize, false, 0L, false);
		}

		/// <summary>Пытается запретить сборку мусора во время выполнения критического пути, если указанный объем памяти доступен для кучи больших объектов и для кучи маленьких объектов.</summary>
		/// <param name="totalSize">Объем памяти в байтах для выделения без запуска сборки мусора. Значение <paramref name="totalSize" /> -<paramref name="lohSize" /> должно быть меньше или равно размеру эфемерного сегмента. Сведения о размере эфемерных сегментов см. в разделе "Эфемерные поколения и сегменты" статьи Основы сборки мусора.</param>
		/// <param name="lohSize">Число байтов в <paramref name="totalSize" /> для назначения кучи больших объектов.</param>
		/// <returns>Значение <see langword="true" />, если среде выполнения удалось зафиксировать необходимый объем памяти и сборщик мусора может перейти в режим задержки без области сборки мусора; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="totalSize" /> - <paramref name="lohSize" /> превышает размер эфемерного сегмента.</exception>
		/// <exception cref="T:System.InvalidOperationException">Процесс уже находится в режиме задержки без области сборки мусора.</exception>
		// Token: 0x06001612 RID: 5650 RVA: 0x00056E2F File Offset: 0x0005502F
		[SecurityCritical]
		public static bool TryStartNoGCRegion(long totalSize, long lohSize)
		{
			return GC.StartNoGCRegionWorker(totalSize, true, lohSize, false);
		}

		/// <summary>Пытается запретить сборку мусора во время выполнения критического пути, если доступен указанный объем памяти, и устанавливает, будет ли выполняться полная блокирующая сборка мусора, если изначально не хватает памяти.</summary>
		/// <param name="totalSize">Объем памяти в байтах для выделения без запуска сборки мусора. Он должен быть меньше или равен размеру временного сегмента. Сведения о размере эфемерных сегментов см. в разделе "Эфемерные поколения и сегменты" статьи Основы сборки мусора.</param>
		/// <param name="disallowFullBlockingGC">Значение <see langword="true" />, чтобы пропустить полную блокирующую сборку мусора, если сборщику мусора изначально не удалось выделить <paramref name="totalSize" /> байтов; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Значение <see langword="true" />, если среде выполнения удалось зафиксировать необходимый объем памяти и сборщик мусора может перейти в режим задержки без области сборки мусора; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="totalSize" /> превышает размер эфемерного сегмента.</exception>
		/// <exception cref="T:System.InvalidOperationException">Процесс уже находится в режиме задержки без области сборки мусора.</exception>
		// Token: 0x06001613 RID: 5651 RVA: 0x00056E3A File Offset: 0x0005503A
		[SecurityCritical]
		public static bool TryStartNoGCRegion(long totalSize, bool disallowFullBlockingGC)
		{
			return GC.StartNoGCRegionWorker(totalSize, false, 0L, disallowFullBlockingGC);
		}

		/// <summary>Пытается запретить сборку мусора во время выполнения критического пути, если доступен указанный объем памяти для кучи больших объектов и для кучи маленьких объектов, и устанавливает, будет ли выполняться полная блокирующая сборка мусора, если изначально не хватает памяти.</summary>
		/// <param name="totalSize">Объем памяти в байтах для выделения без запуска сборки мусора. Значение <paramref name="totalSize" /> -<paramref name="lohSize" /> должно быть меньше или равно размеру эфемерного сегмента. Сведения о размере эфемерных сегментов см. в разделе "Эфемерные поколения и сегменты" статьи Основы сборки мусора.</param>
		/// <param name="lohSize">Число байтов в <paramref name="totalSize" /> для назначения кучи больших объектов.</param>
		/// <param name="disallowFullBlockingGC">Значение <see langword="true" />, чтобы пропустить полную блокирующую сборку мусора, если сборщику мусора изначально не удалось выделить указанную память в куче малых и в куче больших объектов; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Значение <see langword="true" />, если среде выполнения удалось зафиксировать необходимый объем памяти и сборщик мусора может перейти в режим задержки без области сборки мусора; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="totalSize" /> - <paramref name="lohSize" /> превышает размер эфемерного сегмента.</exception>
		/// <exception cref="T:System.InvalidOperationException">Процесс уже находится в режиме задержки без области сборки мусора.</exception>
		// Token: 0x06001614 RID: 5652 RVA: 0x00056E46 File Offset: 0x00055046
		[SecurityCritical]
		public static bool TryStartNoGCRegion(long totalSize, long lohSize, bool disallowFullBlockingGC)
		{
			return GC.StartNoGCRegionWorker(totalSize, true, lohSize, disallowFullBlockingGC);
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x000479F8 File Offset: 0x00045BF8
		[SecurityCritical]
		private static GC.EndNoGCRegionStatus EndNoGCRegionWorker()
		{
			throw new NotImplementedException();
		}

		/// <summary>Завершает режим задержки без области сборки мусора.</summary>
		/// <exception cref="T:System.InvalidOperationException">Сборщик мусора не находится в режиме задержки без области сборки мусора.  
		/// -или- 
		/// Режим задержки без области сборки мусора был завершен заранее, поскольку была вызвана сборка мусора.  
		/// -или- 
		/// Выделение памяти превышает объем, указанный в вызове метода <see cref="M:System.GC.TryStartNoGCRegion(System.Int64)" />.</exception>
		// Token: 0x06001616 RID: 5654 RVA: 0x00056E51 File Offset: 0x00055051
		[SecurityCritical]
		public static void EndNoGCRegion()
		{
			GC.EndNoGCRegionWorker();
		}

		// Token: 0x04001545 RID: 5445
		internal static readonly object EPHEMERON_TOMBSTONE = GC.get_ephemeron_tombstone();

		// Token: 0x02000200 RID: 512
		private enum StartNoGCRegionStatus
		{
			// Token: 0x04001547 RID: 5447
			Succeeded,
			// Token: 0x04001548 RID: 5448
			NotEnoughMemory,
			// Token: 0x04001549 RID: 5449
			AmountTooLarge,
			// Token: 0x0400154A RID: 5450
			AlreadyInProgress
		}

		// Token: 0x02000201 RID: 513
		private enum EndNoGCRegionStatus
		{
			// Token: 0x0400154C RID: 5452
			Succeeded,
			// Token: 0x0400154D RID: 5453
			NotInProgress,
			// Token: 0x0400154E RID: 5454
			GCInduced,
			// Token: 0x0400154F RID: 5455
			AllocationExceeded
		}
	}
}
