using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Security.Principal;
using Internal.Runtime.Augments;

namespace System.Threading
{
	/// <summary>Создает и контролирует поток, задает приоритет и возвращает статус.</summary>
	// Token: 0x020002D5 RID: 725
	[StructLayout(LayoutKind.Sequential)]
	public sealed class Thread : CriticalFinalizerObject, _Thread
	{
		// Token: 0x06001F63 RID: 8035 RVA: 0x00073C6B File Offset: 0x00071E6B
		private static void AsyncLocalSetCurrentCulture(AsyncLocalValueChangedArgs<CultureInfo> args)
		{
			Thread.m_CurrentCulture = args.CurrentValue;
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x00073C79 File Offset: 0x00071E79
		private static void AsyncLocalSetCurrentUICulture(AsyncLocalValueChangedArgs<CultureInfo> args)
		{
			Thread.m_CurrentUICulture = args.CurrentValue;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.Thread" />.</summary>
		/// <param name="start">Делегат <see cref="T:System.Threading.ThreadStart" />, указывающий на методы, которые вызываются при запуске потока.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="start" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001F65 RID: 8037 RVA: 0x00073C87 File Offset: 0x00071E87
		[SecuritySafeCritical]
		public Thread(ThreadStart start)
		{
			if (start == null)
			{
				throw new ArgumentNullException("start");
			}
			this.SetStartHelper(start, 0);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.Thread" />, указывая максимальный размер стека для потока.</summary>
		/// <param name="start">Делегат <see cref="T:System.Threading.ThreadStart" />, указывающий на методы, которые вызываются при запуске потока.</param>
		/// <param name="maxStackSize">Максимальный размер стека в байтах, используемый потоком, или же 0 для использования максимального размера по умолчанию, указывается в заголовке исполняемого файла.  
		/// Внимание! Для частично доверенного кода значение параметра <paramref name="maxStackSize" /> игнорируется, если оно превышает размер стека по умолчанию. Исключение не возникает.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="start" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="maxStackSize" /> меньше нуля.</exception>
		// Token: 0x06001F66 RID: 8038 RVA: 0x00073CA5 File Offset: 0x00071EA5
		[SecuritySafeCritical]
		public Thread(ThreadStart start, int maxStackSize)
		{
			if (start == null)
			{
				throw new ArgumentNullException("start");
			}
			if (0 > maxStackSize)
			{
				throw new ArgumentOutOfRangeException("maxStackSize", Environment.GetResourceString("Non-negative number required."));
			}
			this.SetStartHelper(start, maxStackSize);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.Thread" />, при этом указывается делегат, позволяющий объекту быть переданным в поток при запуске потока.</summary>
		/// <param name="start">Делегат, указывающий на методы, которые вызываются при запуске потока.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="start" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001F67 RID: 8039 RVA: 0x00073C87 File Offset: 0x00071E87
		[SecuritySafeCritical]
		public Thread(ParameterizedThreadStart start)
		{
			if (start == null)
			{
				throw new ArgumentNullException("start");
			}
			this.SetStartHelper(start, 0);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.Thread" />, при этом указывается делегат, позволяющий объекту быть переданным в поток при запуске потока с указанием максимального размера стека для потока.</summary>
		/// <param name="start">Делегат <see cref="T:System.Threading.ParameterizedThreadStart" />, указывающий на методы, которые вызываются при запуске потока.</param>
		/// <param name="maxStackSize">Максимальный размер стека в байтах, используемый потоком, или же 0 для использования максимального размера по умолчанию, указывается в заголовке исполняемого файла.  
		/// Внимание! Для частично доверенного кода значение параметра <paramref name="maxStackSize" /> игнорируется, если оно превышает размер стека по умолчанию. Исключение не возникает.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="start" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="maxStackSize" /> меньше нуля.</exception>
		// Token: 0x06001F68 RID: 8040 RVA: 0x00073CA5 File Offset: 0x00071EA5
		[SecuritySafeCritical]
		public Thread(ParameterizedThreadStart start, int maxStackSize)
		{
			if (start == null)
			{
				throw new ArgumentNullException("start");
			}
			if (0 > maxStackSize)
			{
				throw new ArgumentOutOfRangeException("maxStackSize", Environment.GetResourceString("Non-negative number required."));
			}
			this.SetStartHelper(start, maxStackSize);
		}

		/// <summary>Вынуждает операционную систему изменить состояние текущего экземпляра на <see cref="F:System.Threading.ThreadState.Running" />.</summary>
		/// <exception cref="T:System.Threading.ThreadStateException">Поток уже запущен.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Недостаточно памяти для запуска этого потока.</exception>
		// Token: 0x06001F69 RID: 8041 RVA: 0x00073CDC File Offset: 0x00071EDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start()
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			this.Start(ref stackCrawlMark);
		}

		/// <summary>Заставляет операционную систему изменить состояние текущего экземпляра на <see cref="F:System.Threading.ThreadState.Running" />, а также (необязательно) передает объект с данными, используемыми методом в потоке.</summary>
		/// <param name="parameter">Объект, содержащий данные, используемые методом, который выполняется потоком.</param>
		/// <exception cref="T:System.Threading.ThreadStateException">Поток уже запущен.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Недостаточно памяти для запуска этого потока.</exception>
		/// <exception cref="T:System.InvalidOperationException">Этот поток был создан с помощью делегата <see cref="T:System.Threading.ThreadStart" />, а не делегата <see cref="T:System.Threading.ParameterizedThreadStart" />.</exception>
		// Token: 0x06001F6A RID: 8042 RVA: 0x00073CF4 File Offset: 0x00071EF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start(object parameter)
		{
			if (this.m_Delegate is ThreadStart)
			{
				throw new InvalidOperationException(Environment.GetResourceString("The thread was created with a ThreadStart delegate that does not accept a parameter."));
			}
			this.m_ThreadStartArg = parameter;
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			this.Start(ref stackCrawlMark);
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x00073D30 File Offset: 0x00071F30
		[SecuritySafeCritical]
		private void Start(ref StackCrawlMark stackMark)
		{
			if (this.m_Delegate != null)
			{
				ThreadHelper threadHelper = (ThreadHelper)this.m_Delegate.Target;
				ExecutionContext executionContextHelper = ExecutionContext.Capture(ref stackMark, ExecutionContext.CaptureOptions.IgnoreSyncCtx);
				threadHelper.SetExecutionContextHelper(executionContextHelper);
			}
			object obj = null;
			this.StartInternal(obj, ref stackMark);
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x00073D6D File Offset: 0x00071F6D
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal ExecutionContext.Reader GetExecutionContextReader()
		{
			return new ExecutionContext.Reader(this.m_ExecutionContext);
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001F6D RID: 8045 RVA: 0x00073D7A File Offset: 0x00071F7A
		// (set) Token: 0x06001F6E RID: 8046 RVA: 0x00073D85 File Offset: 0x00071F85
		internal bool ExecutionContextBelongsToCurrentScope
		{
			get
			{
				return !this.m_ExecutionContextBelongsToOuterScope;
			}
			set
			{
				this.m_ExecutionContextBelongsToOuterScope = !value;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Threading.ExecutionContext" />, содержащий сведения о различных контекстах текущего потока.</summary>
		/// <returns>Объект <see cref="T:System.Threading.ExecutionContext" />, содержащий консолидированную информацию о контекстах текущего потока.</returns>
		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001F6F RID: 8047 RVA: 0x00073D94 File Offset: 0x00071F94
		public ExecutionContext ExecutionContext
		{
			[SecuritySafeCritical]
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
			get
			{
				ExecutionContext result;
				if (this == Thread.CurrentThread)
				{
					result = this.GetMutableExecutionContext();
				}
				else
				{
					result = this.m_ExecutionContext;
				}
				return result;
			}
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x00073DBC File Offset: 0x00071FBC
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[SecurityCritical]
		internal ExecutionContext GetMutableExecutionContext()
		{
			if (this.m_ExecutionContext == null)
			{
				this.m_ExecutionContext = new ExecutionContext();
			}
			else if (!this.ExecutionContextBelongsToCurrentScope)
			{
				ExecutionContext executionContext = this.m_ExecutionContext.CreateMutableCopy();
				this.m_ExecutionContext = executionContext;
			}
			this.ExecutionContextBelongsToCurrentScope = true;
			return this.m_ExecutionContext;
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x00073E06 File Offset: 0x00072006
		[SecurityCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope)
		{
			this.m_ExecutionContext = value;
			this.ExecutionContextBelongsToCurrentScope = belongsToCurrentScope;
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x00073E16 File Offset: 0x00072016
		[SecurityCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal void SetExecutionContext(ExecutionContext.Reader value, bool belongsToCurrentScope)
		{
			this.m_ExecutionContext = value.DangerousGetRawExecutionContext();
			this.ExecutionContextBelongsToCurrentScope = belongsToCurrentScope;
		}

		/// <summary>Применяет записанное значение <see cref="T:System.Threading.CompressedStack" /> к текущему потоку.</summary>
		/// <param name="stack">Объект <see cref="T:System.Threading.CompressedStack" />, который будет применен к текущему потоку.</param>
		/// <exception cref="T:System.InvalidOperationException">Во всех случаях.</exception>
		// Token: 0x06001F73 RID: 8051 RVA: 0x00073E2C File Offset: 0x0007202C
		[Obsolete("Thread.SetCompressedStack is no longer supported. Please use the System.Threading.CompressedStack class")]
		public void SetCompressedStack(CompressedStack stack)
		{
			throw new InvalidOperationException(Environment.GetResourceString("Use CompressedStack.(Capture/Run) or ExecutionContext.(Capture/Run) APIs instead."));
		}

		/// <summary>Возвращает объект <see cref="T:System.Threading.CompressedStack" />, который может быть использован для записи стека текущего потока.</summary>
		/// <returns>Отсутствует.</returns>
		/// <exception cref="T:System.InvalidOperationException">Во всех случаях.</exception>
		// Token: 0x06001F74 RID: 8052 RVA: 0x00073E2C File Offset: 0x0007202C
		[SecurityCritical]
		[Obsolete("Thread.GetCompressedStack is no longer supported. Please use the System.Threading.CompressedStack class")]
		public CompressedStack GetCompressedStack()
		{
			throw new InvalidOperationException(Environment.GetResourceString("Use CompressedStack.(Capture/Run) or ExecutionContext.(Capture/Run) APIs instead."));
		}

		/// <summary>Отменяет метод <see cref="M:System.Threading.Thread.Abort(System.Object)" />, запрошенный для текущего потока.</summary>
		/// <exception cref="T:System.PlatformNotSupportedException">Только в .NET Core: этот элемент не поддерживается.</exception>
		/// <exception cref="T:System.Threading.ThreadStateException">Метод <see langword="Abort" /> не был вызван в текущем потоке.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающая сторона не имеет требуемого разрешения безопасности для текущего потока.</exception>
		// Token: 0x06001F75 RID: 8053 RVA: 0x00073E3D File Offset: 0x0007203D
		public static void ResetAbort()
		{
			Thread currentThread = Thread.CurrentThread;
			if ((currentThread.ThreadState & ThreadState.AbortRequested) == ThreadState.Running)
			{
				throw new ThreadStateException(Environment.GetResourceString("Unable to reset abort because no abort was requested."));
			}
			currentThread.ResetAbortNative();
			currentThread.ClearAbortReason();
		}

		// Token: 0x06001F76 RID: 8054
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void ResetAbortNative();

		/// <summary>Приостанавливает работу потока; если работа потока уже приостановлена, не оказывает влияния.</summary>
		/// <exception cref="T:System.PlatformNotSupportedException">Только в .NET Core: этот элемент не поддерживается.</exception>
		/// <exception cref="T:System.Threading.ThreadStateException">Поток не запущен или удален.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует соответствующее разрешение <see cref="T:System.Security.Permissions.SecurityPermission" />.</exception>
		// Token: 0x06001F77 RID: 8055 RVA: 0x00073E6D File Offset: 0x0007206D
		[Obsolete("Thread.Suspend has been deprecated.  Please use other classes in System.Threading, such as Monitor, Mutex, Event, and Semaphore, to synchronize Threads or protect resources.  http://go.microsoft.com/fwlink/?linkid=14202", false)]
		[SecuritySafeCritical]
		public void Suspend()
		{
			this.SuspendInternal();
		}

		// Token: 0x06001F78 RID: 8056
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SuspendInternal();

		/// <summary>Возобновляет приостановленную работу потока.</summary>
		/// <exception cref="T:System.PlatformNotSupportedException">Только в .NET Core: этот элемент не поддерживается.</exception>
		/// <exception cref="T:System.Threading.ThreadStateException">Поток не был запущен, бездействует или не находится в приостановленном состоянии.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует соответствующее разрешение <see cref="T:System.Security.Permissions.SecurityPermission" />.</exception>
		// Token: 0x06001F79 RID: 8057 RVA: 0x00073E75 File Offset: 0x00072075
		[SecuritySafeCritical]
		[Obsolete("Thread.Resume has been deprecated.  Please use other classes in System.Threading, such as Monitor, Mutex, Event, and Semaphore, to synchronize Threads or protect resources.  http://go.microsoft.com/fwlink/?linkid=14202", false)]
		public void Resume()
		{
			this.ResumeInternal();
		}

		// Token: 0x06001F7A RID: 8058
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void ResumeInternal();

		/// <summary>Прерывает работу потока, находящегося в состоянии <see langword="WaitSleepJoin" />.</summary>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует соответствующее разрешение <see cref="T:System.Security.Permissions.SecurityPermission" />.</exception>
		// Token: 0x06001F7B RID: 8059 RVA: 0x00073E7D File Offset: 0x0007207D
		public void Interrupt()
		{
			this.InterruptInternal();
		}

		// Token: 0x06001F7C RID: 8060
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void InterruptInternal();

		/// <summary>Возвращает или задает значение, указывающее на планируемый приоритет потока.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Threading.ThreadPriority" />. Значение по умолчанию — <see cref="F:System.Threading.ThreadPriority.Normal" />.</returns>
		/// <exception cref="T:System.Threading.ThreadStateException">Поток достиг конечного состояния, например <see cref="F:System.Threading.ThreadState.Aborted" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значение, указанное для операции задания, не является допустимым значением <see cref="T:System.Threading.ThreadPriority" />.</exception>
		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001F7D RID: 8061 RVA: 0x00073E85 File Offset: 0x00072085
		// (set) Token: 0x06001F7E RID: 8062 RVA: 0x00073E8D File Offset: 0x0007208D
		public ThreadPriority Priority
		{
			[SecuritySafeCritical]
			get
			{
				return (ThreadPriority)this.GetPriorityNative();
			}
			set
			{
				this.SetPriorityNative((int)value);
			}
		}

		// Token: 0x06001F7F RID: 8063
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int GetPriorityNative();

		// Token: 0x06001F80 RID: 8064
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetPriorityNative(int priority);

		// Token: 0x06001F81 RID: 8065
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool JoinInternal(int millisecondsTimeout);

		/// <summary>Блокирует вызывающий поток до завершения потока, представленного экземпляром, продолжая отправлять стандартные сообщения COM и <see langword="SendMessage" />.</summary>
		/// <exception cref="T:System.Threading.ThreadStateException">Вызывающая сторона пыталась присоединиться к потоку, который находится в состоянии <see cref="F:System.Threading.ThreadState.Unstarted" />.</exception>
		/// <exception cref="T:System.Threading.ThreadInterruptedException">Выполнение потока прервано во время ожидания.</exception>
		// Token: 0x06001F82 RID: 8066 RVA: 0x00073E96 File Offset: 0x00072096
		public void Join()
		{
			this.JoinInternal(-1);
		}

		/// <summary>Блокирует вызывающий поток до завершения потока, представленного экземпляром, или истечения указанного времени, продолжая отправлять стандартные сообщения COM и SendMessage.</summary>
		/// <param name="millisecondsTimeout">Количество миллисекунд ожидания завершения потока.</param>
		/// <returns>Значение <see langword="true" />, если поток завершился; значение <see langword="false" />, если поток не завершился по истечении количества времени, заданного параметром <paramref name="millisecondsTimeout" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="millisecondsTimeout" /> является отрицательным и не равно <see cref="F:System.Threading.Timeout.Infinite" /> (в миллисекундах).</exception>
		/// <exception cref="T:System.Threading.ThreadStateException">Поток не запущен.</exception>
		// Token: 0x06001F83 RID: 8067 RVA: 0x00073EA0 File Offset: 0x000720A0
		public bool Join(int millisecondsTimeout)
		{
			if (millisecondsTimeout < -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout", Environment.GetResourceString("Number must be either non-negative and less than or equal to Int32.MaxValue or -1."));
			}
			return this.JoinInternal(millisecondsTimeout);
		}

		/// <summary>Блокирует вызывающий поток до завершения потока, представленного экземпляром, или истечения указанного времени, продолжая отправлять стандартные сообщения COM и SendMessage.</summary>
		/// <param name="timeout">Объект <see cref="T:System.TimeSpan" />, в качестве значения которого задано время ожидания завершения процесса.</param>
		/// <returns>Значение <see langword="true" />, если поток завершился; <see langword="false" />, если поток не завершился по истечении количества времени, заданного параметром <paramref name="timeout" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="timeout" /> является отрицательным и не равно <see cref="F:System.Threading.Timeout.Infinite" /> (в миллисекундах) или больше <see cref="F:System.Int32.MaxValue" /> миллисекунд.</exception>
		/// <exception cref="T:System.Threading.ThreadStateException">Вызывающая сторона пыталась присоединиться к потоку, который находится в состоянии <see cref="F:System.Threading.ThreadState.Unstarted" />.</exception>
		// Token: 0x06001F84 RID: 8068 RVA: 0x00073EC4 File Offset: 0x000720C4
		public bool Join(TimeSpan timeout)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (num < -1L || num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("Number must be either non-negative and less than or equal to Int32.MaxValue or -1."));
			}
			return this.Join((int)num);
		}

		// Token: 0x06001F85 RID: 8069
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SleepInternal(int millisecondsTimeout);

		/// <summary>Приостанавливает текущий поток на заданное количество миллисекунд.</summary>
		/// <param name="millisecondsTimeout">Количество миллисекунд, на которое приостанавливается поток. Если значение аргумента <paramref name="millisecondsTimeout" /> равно нулю, поток освобождает оставшуюся часть своего интервала времени для любого потока с таким же приоритетом, готовым к выполнению. Если других готовых к выполнению потоков с таким же приоритетом нет, выполнение текущего потока не приостанавливается.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение времени ожидания является отрицательной величиной и не равно <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
		// Token: 0x06001F86 RID: 8070 RVA: 0x00073F05 File Offset: 0x00072105
		[SecuritySafeCritical]
		public static void Sleep(int millisecondsTimeout)
		{
			if (millisecondsTimeout < -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout", Environment.GetResourceString("Number must be either non-negative and less than or equal to Int32.MaxValue or -1."));
			}
			Thread.SleepInternal(millisecondsTimeout);
		}

		/// <summary>Приостанавливает текущий поток на заданное время.</summary>
		/// <param name="timeout">Время, на которое приостанавливается поток. Если значение аргумента <paramref name="millisecondsTimeout" /> равно <see cref="F:System.TimeSpan.Zero" />, поток освобождает оставшуюся часть своего интервала времени для любого потока с таким же приоритетом, готовым к выполнению. Если других готовых к выполнению потоков с таким же приоритетом нет, выполнение текущего потока не приостанавливается.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="timeout" /> является отрицательным и не равно <see cref="F:System.Threading.Timeout.Infinite" /> (в миллисекундах) или больше <see cref="F:System.Int32.MaxValue" /> миллисекунд.</exception>
		// Token: 0x06001F87 RID: 8071 RVA: 0x00073F28 File Offset: 0x00072128
		public static void Sleep(TimeSpan timeout)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (num < -1L || num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("Number must be either non-negative and less than or equal to Int32.MaxValue or -1."));
			}
			Thread.Sleep((int)num);
		}

		// Token: 0x06001F88 RID: 8072
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool YieldInternal();

		/// <summary>Позволяет вызвавшему потоку передать выполнение другому потоку, готовому к использованию на текущем процессоре. Операционная система выбирает, какому потоку передается выполнение.</summary>
		/// <returns>Значение <see langword="true" />, если операционная система переключила выполнение на другой поток, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001F89 RID: 8073 RVA: 0x00073F68 File Offset: 0x00072168
		public static bool Yield()
		{
			return Thread.YieldInternal();
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x00073F70 File Offset: 0x00072170
		[SecurityCritical]
		private void SetStartHelper(Delegate start, int maxStackSize)
		{
			maxStackSize = Thread.GetProcessDefaultStackSize(maxStackSize);
			ThreadHelper @object = new ThreadHelper(start);
			if (start is ThreadStart)
			{
				this.SetStart(new ThreadStart(@object.ThreadStart), maxStackSize);
				return;
			}
			this.SetStart(new ParameterizedThreadStart(@object.ThreadStart), maxStackSize);
		}

		/// <summary>Выделяет неименованную область данных всем потокам. Для улучшения производительности используйте поля, отмеченные атрибутом <see cref="T:System.ThreadStaticAttribute" />.</summary>
		/// <returns>Выделенная именованная область данных всем потокам.</returns>
		// Token: 0x06001F8B RID: 8075 RVA: 0x00073FBB File Offset: 0x000721BB
		public static LocalDataStoreSlot AllocateDataSlot()
		{
			return Thread.LocalDataStoreManager.AllocateDataSlot();
		}

		/// <summary>Выделяет именованную область данных всем потокам. Для улучшения производительности используйте поля, отмеченные атрибутом <see cref="T:System.ThreadStaticAttribute" />.</summary>
		/// <param name="name">Имя выделяемой области данных.</param>
		/// <returns>Выделенная именованная область данных всем потокам.</returns>
		/// <exception cref="T:System.ArgumentException">Именованная область данных с указанным именем уже существует.</exception>
		// Token: 0x06001F8C RID: 8076 RVA: 0x00073FC7 File Offset: 0x000721C7
		public static LocalDataStoreSlot AllocateNamedDataSlot(string name)
		{
			return Thread.LocalDataStoreManager.AllocateNamedDataSlot(name);
		}

		/// <summary>Ищет именованную область данных. Для улучшения производительности используйте поля, отмеченные атрибутом <see cref="T:System.ThreadStaticAttribute" />.</summary>
		/// <param name="name">Имя локальной области данных.</param>
		/// <returns>Объект <see cref="T:System.LocalDataStoreSlot" />, выделенный для данного потока.</returns>
		// Token: 0x06001F8D RID: 8077 RVA: 0x00073FD4 File Offset: 0x000721D4
		public static LocalDataStoreSlot GetNamedDataSlot(string name)
		{
			return Thread.LocalDataStoreManager.GetNamedDataSlot(name);
		}

		/// <summary>Удаляет связь между названием и областью для всех потоков в процессе. Для улучшения производительности используйте поля, отмеченные атрибутом <see cref="T:System.ThreadStaticAttribute" />.</summary>
		/// <param name="name">Имя освобождаемой области данных.</param>
		// Token: 0x06001F8E RID: 8078 RVA: 0x00073FE1 File Offset: 0x000721E1
		public static void FreeNamedDataSlot(string name)
		{
			Thread.LocalDataStoreManager.FreeNamedDataSlot(name);
		}

		/// <summary>Извлекает значение из заданной области текущего потока, внутри текущей области текущего потока. Для улучшения производительности используйте поля, отмеченные атрибутом <see cref="T:System.ThreadStaticAttribute" />.</summary>
		/// <param name="slot">Объект <see cref="T:System.LocalDataStoreSlot" />, из которого возвращается значение.</param>
		/// <returns>Извлекаемое значение.</returns>
		// Token: 0x06001F8F RID: 8079 RVA: 0x00073FF0 File Offset: 0x000721F0
		public static object GetData(LocalDataStoreSlot slot)
		{
			LocalDataStoreHolder localDataStoreHolder = Thread.s_LocalDataStore;
			if (localDataStoreHolder == null)
			{
				Thread.LocalDataStoreManager.ValidateSlot(slot);
				return null;
			}
			return localDataStoreHolder.Store.GetData(slot);
		}

		/// <summary>Задает данные в указанной области для текущей области потока, выполняющегося в данный момент. Для улучшения производительности используйте поля, отмеченные атрибутом <see cref="T:System.ThreadStaticAttribute" />.</summary>
		/// <param name="slot">Объект <see cref="T:System.LocalDataStoreSlot" />, для которого задается значение.</param>
		/// <param name="data">Задаваемое значение.</param>
		// Token: 0x06001F90 RID: 8080 RVA: 0x00074020 File Offset: 0x00072220
		public static void SetData(LocalDataStoreSlot slot, object data)
		{
			LocalDataStoreHolder localDataStoreHolder = Thread.s_LocalDataStore;
			if (localDataStoreHolder == null)
			{
				localDataStoreHolder = Thread.LocalDataStoreManager.CreateLocalDataStore();
				Thread.s_LocalDataStore = localDataStoreHolder;
			}
			localDataStoreHolder.Store.SetData(slot, data);
		}

		/// <summary>Возвращает или задает текущие язык и региональные параметры, используемые диспетчером ресурсов для поиска ресурсов, связанных с языком и региональными параметрами, во время выполнения.</summary>
		/// <returns>Объект, представляющий текущие языковые стандарты.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задано значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойству присвоено имя языка и региональных параметров, которое не может использоваться для нахождения файла ресурсов. Имена файлов ресурсов могут содержать только буквы, цифры, дефисы или символы подчеркивания.</exception>
		/// <exception cref="T:System.InvalidOperationException">Только в .NET Core. Чтение или запись данных о языке и региональных параметрах потока из другого потока не поддерживается.</exception>
		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001F91 RID: 8081 RVA: 0x00074054 File Offset: 0x00072254
		// (set) Token: 0x06001F92 RID: 8082 RVA: 0x00074074 File Offset: 0x00072274
		public CultureInfo CurrentUICulture
		{
			get
			{
				if (AppDomain.IsAppXModel())
				{
					return CultureInfo.GetCultureInfoForUserPreferredLanguageInAppX() ?? this.GetCurrentUICultureNoAppX();
				}
				return this.GetCurrentUICultureNoAppX();
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				CultureInfo.VerifyCultureName(value, true);
				if (AppDomain.IsAppXModel())
				{
					CultureInfo.SetCultureInfoForUserPreferredLanguageInAppX(value);
					return;
				}
				if (Thread.m_CurrentUICulture == null && Thread.m_CurrentCulture == null)
				{
					Thread.nativeInitCultureAccessors();
				}
				if (!AppContextSwitches.NoAsyncCurrentCulture)
				{
					if (Thread.s_asyncLocalCurrentUICulture == null)
					{
						Interlocked.CompareExchange<AsyncLocal<CultureInfo>>(ref Thread.s_asyncLocalCurrentUICulture, new AsyncLocal<CultureInfo>(new Action<AsyncLocalValueChangedArgs<CultureInfo>>(Thread.AsyncLocalSetCurrentUICulture)), null);
					}
					Thread.s_asyncLocalCurrentUICulture.Value = value;
					return;
				}
				Thread.m_CurrentUICulture = value;
			}
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x000740F8 File Offset: 0x000722F8
		internal CultureInfo GetCurrentUICultureNoAppX()
		{
			if (Thread.m_CurrentUICulture != null)
			{
				return Thread.m_CurrentUICulture;
			}
			CultureInfo defaultThreadCurrentUICulture = CultureInfo.DefaultThreadCurrentUICulture;
			if (defaultThreadCurrentUICulture == null)
			{
				return CultureInfo.UserDefaultUICulture;
			}
			return defaultThreadCurrentUICulture;
		}

		/// <summary>Возвращает или задает язык и региональные параметры для текущего потока.</summary>
		/// <returns>Объект, представляющий язык и региональные параметры, используемые текущим потоком.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для свойства задано значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Только в .NET Core. Чтение или запись данных о языке и региональных параметрах потока из другого потока не поддерживается.</exception>
		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001F94 RID: 8084 RVA: 0x00074122 File Offset: 0x00072322
		// (set) Token: 0x06001F95 RID: 8085 RVA: 0x00074144 File Offset: 0x00072344
		public CultureInfo CurrentCulture
		{
			get
			{
				if (AppDomain.IsAppXModel())
				{
					return CultureInfo.GetCultureInfoForUserPreferredLanguageInAppX() ?? this.GetCurrentCultureNoAppX();
				}
				return this.GetCurrentCultureNoAppX();
			}
			[SecuritySafeCritical]
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				if (AppDomain.IsAppXModel())
				{
					CultureInfo.SetCultureInfoForUserPreferredLanguageInAppX(value);
					return;
				}
				if (Thread.m_CurrentCulture == null && Thread.m_CurrentUICulture == null)
				{
					Thread.nativeInitCultureAccessors();
				}
				if (!AppContextSwitches.NoAsyncCurrentCulture)
				{
					if (Thread.s_asyncLocalCurrentCulture == null)
					{
						Interlocked.CompareExchange<AsyncLocal<CultureInfo>>(ref Thread.s_asyncLocalCurrentCulture, new AsyncLocal<CultureInfo>(new Action<AsyncLocalValueChangedArgs<CultureInfo>>(Thread.AsyncLocalSetCurrentCulture)), null);
					}
					Thread.s_asyncLocalCurrentCulture.Value = value;
					return;
				}
				Thread.m_CurrentCulture = value;
			}
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x000741C0 File Offset: 0x000723C0
		private CultureInfo GetCurrentCultureNoAppX()
		{
			if (Thread.m_CurrentCulture != null)
			{
				return Thread.m_CurrentCulture;
			}
			CultureInfo defaultThreadCurrentCulture = CultureInfo.DefaultThreadCurrentCulture;
			if (defaultThreadCurrentCulture == null)
			{
				return CultureInfo.UserDefaultCulture;
			}
			return defaultThreadCurrentCulture;
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x000741EA File Offset: 0x000723EA
		private static void nativeInitCultureAccessors()
		{
			Thread.m_CurrentCulture = CultureInfo.ConstructCurrentCulture();
			Thread.m_CurrentUICulture = CultureInfo.ConstructCurrentUICulture();
		}

		/// <summary>Синхронизирует доступ к памяти следующим образом: процессор, выполняющий текущий поток, не способен упорядочить инструкции так, чтобы обращения к памяти до вызова метода <see cref="M:System.Threading.Thread.MemoryBarrier" /> выполнялись после обращений к памяти, следующих за вызовом метода <see cref="M:System.Threading.Thread.MemoryBarrier" />.</summary>
		// Token: 0x06001F98 RID: 8088
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MemoryBarrier();

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001F99 RID: 8089 RVA: 0x00074200 File Offset: 0x00072400
		private static LocalDataStoreMgr LocalDataStoreManager
		{
			get
			{
				if (Thread.s_LocalDataStoreMgr == null)
				{
					Interlocked.CompareExchange<LocalDataStoreMgr>(ref Thread.s_LocalDataStoreMgr, new LocalDataStoreMgr(), null);
				}
				return Thread.s_LocalDataStoreMgr;
			}
		}

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06001F9A RID: 8090 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _Thread.GetTypeInfoCount(out uint pcTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06001F9B RID: 8091 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _Thread.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06001F9C RID: 8092 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _Thread.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			throw new NotImplementedException();
		}

		/// <summary>Предоставляет доступ к открытым свойствам и методам объекта.</summary>
		/// <param name="dispIdMember">Идентифицирует член.</param>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="lcid">Контекст языкового стандарта, в котором следует интерпретировать аргументы.</param>
		/// <param name="wFlags">Флаги, описывающие контекст вызова.</param>
		/// <param name="pDispParams">Указатель на структуру, содержащую массив аргументов, массив DISPID для именованных аргументов, а также счетчики количества элементов в массивах.</param>
		/// <param name="pVarResult">Указатель, по которому будет сохранен результат.</param>
		/// <param name="pExcepInfo">Указатель на структуру, содержащую сведения об исключении.</param>
		/// <param name="puArgErr">Индекс первого аргумента, вызвавшего ошибку.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x06001F9D RID: 8093 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _Thread.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001F9E RID: 8094
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void ConstructInternalThread();

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001F9F RID: 8095 RVA: 0x0007421F File Offset: 0x0007241F
		private InternalThread Internal
		{
			get
			{
				if (this.internal_thread == null)
				{
					this.ConstructInternalThread();
				}
				return this.internal_thread;
			}
		}

		// Token: 0x06001FA0 RID: 8096
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern byte[] ByteArrayToRootDomain(byte[] arr);

		// Token: 0x06001FA1 RID: 8097
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern byte[] ByteArrayToCurrentDomain(byte[] arr);

		/// <summary>Возвращает текущий контекст, в котором выполняется поток.</summary>
		/// <returns>Класс <see cref="T:System.Runtime.Remoting.Contexts.Context" />, представляющий текущий контекст потока.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001FA2 RID: 8098 RVA: 0x00074235 File Offset: 0x00072435
		public static Context CurrentContext
		{
			get
			{
				return AppDomain.InternalGetContext();
			}
		}

		// Token: 0x06001FA3 RID: 8099 RVA: 0x0007423C File Offset: 0x0007243C
		private static void DeserializePrincipal(Thread th)
		{
			MemoryStream memoryStream = new MemoryStream(Thread.ByteArrayToCurrentDomain(th.Internal._serialized_principal));
			int num = memoryStream.ReadByte();
			if (num == 0)
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				th.principal = (IPrincipal)binaryFormatter.Deserialize(memoryStream);
				th.principal_version = th.Internal._serialized_principal_version;
				return;
			}
			if (num == 1)
			{
				BinaryReader binaryReader = new BinaryReader(memoryStream);
				string name = binaryReader.ReadString();
				string type = binaryReader.ReadString();
				int num2 = binaryReader.ReadInt32();
				string[] array = null;
				if (num2 >= 0)
				{
					array = new string[num2];
					for (int i = 0; i < num2; i++)
					{
						array[i] = binaryReader.ReadString();
					}
				}
				th.principal = new GenericPrincipal(new GenericIdentity(name, type), array);
				return;
			}
			if (num == 2 || num == 3)
			{
				string[] roles = (num == 2) ? null : new string[0];
				th.principal = new GenericPrincipal(new GenericIdentity("", ""), roles);
			}
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x00074330 File Offset: 0x00072530
		private static void SerializePrincipal(Thread th, IPrincipal value)
		{
			MemoryStream memoryStream = new MemoryStream();
			bool flag = false;
			if (value.GetType() == typeof(GenericPrincipal))
			{
				GenericPrincipal genericPrincipal = (GenericPrincipal)value;
				if (genericPrincipal.Identity != null && genericPrincipal.Identity.GetType() == typeof(GenericIdentity))
				{
					GenericIdentity genericIdentity = (GenericIdentity)genericPrincipal.Identity;
					if (genericIdentity.Name == "" && genericIdentity.AuthenticationType == "")
					{
						if (genericPrincipal.Roles == null)
						{
							memoryStream.WriteByte(2);
							flag = true;
						}
						else if (genericPrincipal.Roles.Length == 0)
						{
							memoryStream.WriteByte(3);
							flag = true;
						}
					}
					else
					{
						memoryStream.WriteByte(1);
						BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
						binaryWriter.Write(genericPrincipal.Identity.Name);
						binaryWriter.Write(genericPrincipal.Identity.AuthenticationType);
						string[] roles = genericPrincipal.Roles;
						if (roles == null)
						{
							binaryWriter.Write(-1);
						}
						else
						{
							binaryWriter.Write(roles.Length);
							foreach (string value2 in roles)
							{
								binaryWriter.Write(value2);
							}
						}
						binaryWriter.Flush();
						flag = true;
					}
				}
			}
			if (!flag)
			{
				memoryStream.WriteByte(0);
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				try
				{
					binaryFormatter.Serialize(memoryStream, value);
				}
				catch
				{
				}
			}
			th.Internal._serialized_principal = Thread.ByteArrayToRootDomain(memoryStream.ToArray());
		}

		/// <summary>Возвращает или задает текущего участника потока (для безопасности на основе ролей).</summary>
		/// <returns>Значение <see cref="T:System.Security.Principal.IPrincipal" />, представляющее контекст безопасности.</returns>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий объект не имеет разрешений, необходимых для задания участника.</exception>
		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x000744BC File Offset: 0x000726BC
		// (set) Token: 0x06001FA6 RID: 8102 RVA: 0x00074570 File Offset: 0x00072770
		public static IPrincipal CurrentPrincipal
		{
			get
			{
				Thread currentThread = Thread.CurrentThread;
				IPrincipal principal = currentThread.GetExecutionContextReader().LogicalCallContext.Principal;
				if (principal != null)
				{
					return principal;
				}
				if (currentThread.principal_version != currentThread.Internal._serialized_principal_version)
				{
					currentThread.principal = null;
				}
				if (currentThread.principal != null)
				{
					return currentThread.principal;
				}
				if (currentThread.Internal._serialized_principal != null)
				{
					try
					{
						Thread.DeserializePrincipal(currentThread);
						return currentThread.principal;
					}
					catch
					{
					}
				}
				currentThread.principal = Thread.GetDomain().DefaultPrincipal;
				currentThread.principal_version = currentThread.Internal._serialized_principal_version;
				return currentThread.principal;
			}
			set
			{
				Thread currentThread = Thread.CurrentThread;
				currentThread.GetMutableExecutionContext().LogicalCallContext.Principal = value;
				if (value != Thread.GetDomain().DefaultPrincipal)
				{
					currentThread.Internal._serialized_principal_version++;
					try
					{
						Thread.SerializePrincipal(currentThread, value);
					}
					catch (Exception)
					{
						currentThread.Internal._serialized_principal = null;
					}
					currentThread.principal_version = currentThread.Internal._serialized_principal_version;
				}
				else
				{
					currentThread.Internal._serialized_principal = null;
				}
				currentThread.principal = value;
			}
		}

		/// <summary>Возвращает текущую область, в которой выполняется текущий поток.</summary>
		/// <returns>Объект <see cref="T:System.AppDomain" />, представляющий собой текущий домен приложения выполняющегося потока.</returns>
		// Token: 0x06001FA7 RID: 8103 RVA: 0x00074604 File Offset: 0x00072804
		public static AppDomain GetDomain()
		{
			return AppDomain.CurrentDomain;
		}

		// Token: 0x06001FA8 RID: 8104
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetCurrentThread_icall(ref Thread thread);

		// Token: 0x06001FA9 RID: 8105 RVA: 0x0007460C File Offset: 0x0007280C
		private static Thread GetCurrentThread()
		{
			Thread result = null;
			Thread.GetCurrentThread_icall(ref result);
			return result;
		}

		/// <summary>Возвращает выполняющийся в данный момент поток.</summary>
		/// <returns>Объект <see cref="T:System.Threading.Thread" />, представляющий собой выполняющийся в данный момент поток.</returns>
		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001FAA RID: 8106 RVA: 0x00074624 File Offset: 0x00072824
		public static Thread CurrentThread
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
			get
			{
				Thread thread = Thread.current_thread;
				if (thread != null)
				{
					return thread;
				}
				return Thread.GetCurrentThread();
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06001FAB RID: 8107 RVA: 0x00074641 File Offset: 0x00072841
		internal static int CurrentThreadId
		{
			get
			{
				return (int)Thread.CurrentThread.internal_thread.thread_id;
			}
		}

		/// <summary>Возвращает уникальный идентификатор домена приложения.</summary>
		/// <returns>32-разрядное знаковое целое число, однозначно определяющее домен приложения.</returns>
		// Token: 0x06001FAC RID: 8108
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetDomainID();

		// Token: 0x06001FAD RID: 8109
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool Thread_internal(MulticastDelegate start);

		// Token: 0x06001FAE RID: 8110 RVA: 0x00074653 File Offset: 0x00072853
		private Thread(InternalThread it)
		{
			this.internal_thread = it;
		}

		/// <summary>Обеспечивает освобождение ресурсов и выполнение других завершающих операций, когда сборщик мусора восстанавливает объект <see cref="T:System.Threading.Thread" />.</summary>
		// Token: 0x06001FAF RID: 8111 RVA: 0x00074664 File Offset: 0x00072864
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		~Thread()
		{
		}

		/// <summary>Возвращает или задает модель "apartment" для данного потока.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Threading.ApartmentState" />. Начальное значение — <see langword="Unknown" />.</returns>
		/// <exception cref="T:System.ArgumentException">Предпринята попытка задать в этом свойстве состояние, которое не является допустимым состоянием подразделения (состояние, отличное от однопотокового подразделения (<see langword="STA" />) или многопотокового подразделения (<see langword="MTA" />)).</exception>
		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06001FB0 RID: 8112 RVA: 0x0007468C File Offset: 0x0007288C
		// (set) Token: 0x06001FB1 RID: 8113 RVA: 0x000746A0 File Offset: 0x000728A0
		[Obsolete("Deprecated in favor of GetApartmentState, SetApartmentState and TrySetApartmentState.")]
		public ApartmentState ApartmentState
		{
			get
			{
				this.ValidateThreadState();
				return (ApartmentState)this.Internal.apartment_state;
			}
			set
			{
				this.ValidateThreadState();
				this.TrySetApartmentState(value);
			}
		}

		/// <summary>Возвращает значение, показывающее, принадлежит ли поток к группе управляемых потоков.</summary>
		/// <returns>Значение <see langword="true" />, если этот поток принадлежит группе управляемых потоков; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001FB2 RID: 8114 RVA: 0x000746B1 File Offset: 0x000728B1
		public bool IsThreadPoolThread
		{
			get
			{
				return this.IsThreadPoolThreadInternal;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001FB3 RID: 8115 RVA: 0x000746B9 File Offset: 0x000728B9
		// (set) Token: 0x06001FB4 RID: 8116 RVA: 0x000746C6 File Offset: 0x000728C6
		internal bool IsThreadPoolThreadInternal
		{
			get
			{
				return this.Internal.threadpool_thread;
			}
			set
			{
				this.Internal.threadpool_thread = value;
			}
		}

		/// <summary>Возвращает значение, показывающее статус выполнения текущего потока.</summary>
		/// <returns>Значение <see langword="true" />, если этот поток был запущен и не был завершен нормально, либо был прерван; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001FB5 RID: 8117 RVA: 0x000746D4 File Offset: 0x000728D4
		public bool IsAlive
		{
			get
			{
				ThreadState state = Thread.GetState(this.Internal);
				return (state & ThreadState.Aborted) == ThreadState.Running && (state & ThreadState.Stopped) == ThreadState.Running && (state & ThreadState.Unstarted) == ThreadState.Running;
			}
		}

		/// <summary>Возвращает или задает значение, показывающее, является ли поток фоновым.</summary>
		/// <returns>Значение <see langword="true" />, если этот поток является или станет фоновым потоком; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.Threading.ThreadStateException">Поток не работает.</exception>
		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001FB6 RID: 8118 RVA: 0x00074704 File Offset: 0x00072904
		// (set) Token: 0x06001FB7 RID: 8119 RVA: 0x00074711 File Offset: 0x00072911
		public bool IsBackground
		{
			get
			{
				return (this.ValidateThreadState() & ThreadState.Background) > ThreadState.Running;
			}
			set
			{
				this.ValidateThreadState();
				if (value)
				{
					Thread.SetState(this.Internal, ThreadState.Background);
					return;
				}
				Thread.ClrState(this.Internal, ThreadState.Background);
			}
		}

		// Token: 0x06001FB8 RID: 8120
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string GetName_internal(InternalThread thread);

		// Token: 0x06001FB9 RID: 8121
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void SetName_icall(InternalThread thread, char* name, int nameLength);

		// Token: 0x06001FBA RID: 8122 RVA: 0x00074738 File Offset: 0x00072938
		private unsafe static void SetName_internal(InternalThread thread, string name)
		{
			fixed (string text = name)
			{
				char* ptr = text;
				if (ptr != null)
				{
					ptr += RuntimeHelpers.OffsetToStringData / 2;
				}
				Thread.SetName_icall(thread, ptr, (name != null) ? name.Length : 0);
			}
		}

		/// <summary>Получает или задает имя потока.</summary>
		/// <returns>Строка, содержащая имя потока или <see langword="null" />, если имя не задано.</returns>
		/// <exception cref="T:System.InvalidOperationException">Запрошена операция задания, но свойство <see langword="Name" /> уже задано.</exception>
		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001FBB RID: 8123 RVA: 0x0007476A File Offset: 0x0007296A
		// (set) Token: 0x06001FBC RID: 8124 RVA: 0x00074777 File Offset: 0x00072977
		public string Name
		{
			get
			{
				return Thread.GetName_internal(this.Internal);
			}
			set
			{
				Thread.SetName_internal(this.Internal, value);
			}
		}

		/// <summary>Возвращает значение, содержащее состояния текущего потока.</summary>
		/// <returns>Одно из значений <see cref="T:System.Threading.ThreadState" />, показывающее состояние текущего потока. Начальное значение — <see langword="Unstarted" />.</returns>
		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001FBD RID: 8125 RVA: 0x00074785 File Offset: 0x00072985
		public ThreadState ThreadState
		{
			get
			{
				return Thread.GetState(this.Internal);
			}
		}

		// Token: 0x06001FBE RID: 8126
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Abort_internal(InternalThread thread, object stateInfo);

		/// <summary>Вызывает исключение <see cref="T:System.Threading.ThreadAbortException" /> в вызвавшем его потоке для того, чтобы начать процесс завершения потока. Вызов данного метода обычно завершает поток.</summary>
		/// <exception cref="T:System.PlatformNotSupportedException">Только в .NET Core: этот элемент не поддерживается.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.Threading.ThreadStateException">Поток, который прерывается, в настоящий момент приостановлен.</exception>
		// Token: 0x06001FBF RID: 8127 RVA: 0x00074792 File Offset: 0x00072992
		public void Abort()
		{
			Thread.Abort_internal(this.Internal, null);
		}

		/// <summary>Вызывает исключение <see cref="T:System.Threading.ThreadAbortException" /> в вызвавшем его потоке для того, чтобы начать процесс завершения потока, в то же время предоставляя сведения об исключении касательно исключения завершения потока. Вызов данного метода обычно завершает поток.</summary>
		/// <param name="stateInfo">Объект, который содержит информацию об определенном приложении, например состояние, которое может использоваться аварийно завершающимся потоком.</param>
		/// <exception cref="T:System.PlatformNotSupportedException">Только в .NET Core: этот элемент не поддерживается.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		/// <exception cref="T:System.Threading.ThreadStateException">Поток, который прерывается, в настоящий момент приостановлен.</exception>
		// Token: 0x06001FC0 RID: 8128 RVA: 0x000747A0 File Offset: 0x000729A0
		public void Abort(object stateInfo)
		{
			Thread.Abort_internal(this.Internal, stateInfo);
		}

		// Token: 0x06001FC1 RID: 8129
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern object GetAbortExceptionState();

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x000747AE File Offset: 0x000729AE
		internal object AbortReason
		{
			get
			{
				return this.GetAbortExceptionState();
			}
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x00004BF9 File Offset: 0x00002DF9
		private void ClearAbortReason()
		{
		}

		// Token: 0x06001FC4 RID: 8132
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SpinWait_nop();

		/// <summary>Вынуждает поток выполнять ожидание столько раз, сколько определено параметром <paramref name="iterations" />.</summary>
		/// <param name="iterations">32-разрядное знаковое целое число, определяющее, как долго потоку ожидать.</param>
		// Token: 0x06001FC5 RID: 8133 RVA: 0x000747B6 File Offset: 0x000729B6
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void SpinWait(int iterations)
		{
			if (iterations < 0)
			{
				return;
			}
			while (iterations-- > 0)
			{
				Thread.SpinWait_nop();
			}
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x000747CB File Offset: 0x000729CB
		private void StartInternal(object principal, ref StackCrawlMark stackMark)
		{
			this.Internal._serialized_principal = Thread.CurrentThread.Internal._serialized_principal;
			if (!this.Thread_internal(this.m_Delegate))
			{
				throw new SystemException("Thread creation failed.");
			}
			this.m_ThreadStartArg = null;
		}

		// Token: 0x06001FC7 RID: 8135
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetState(InternalThread thread, ThreadState set);

		// Token: 0x06001FC8 RID: 8136
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void ClrState(InternalThread thread, ThreadState clr);

		// Token: 0x06001FC9 RID: 8137
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ThreadState GetState(InternalThread thread);

		/// <summary>Считывает значение поля. Это значение является последним записанным каким-либо из процессоров компьютера, независимо от количества процессоров и от состояния кэш-буфера процессоров.</summary>
		/// <param name="address">Поле для чтения.</param>
		/// <returns>Последнее значение, записанное в поле любым процессором.</returns>
		// Token: 0x06001FCA RID: 8138
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte VolatileRead(ref byte address);

		/// <summary>Считывает значение поля. Это значение является последним записанным каким-либо из процессоров компьютера, независимо от количества процессоров и от состояния кэш-буфера процессоров.</summary>
		/// <param name="address">Поле для чтения.</param>
		/// <returns>Последнее значение, записанное в поле любым процессором.</returns>
		// Token: 0x06001FCB RID: 8139
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double VolatileRead(ref double address);

		/// <summary>Считывает значение поля. Это значение является последним записанным каким-либо из процессоров компьютера, независимо от количества процессоров и от состояния кэш-буфера процессоров.</summary>
		/// <param name="address">Поле для чтения.</param>
		/// <returns>Последнее значение, записанное в поле любым процессором.</returns>
		// Token: 0x06001FCC RID: 8140
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern short VolatileRead(ref short address);

		/// <summary>Считывает значение поля. Это значение является последним записанным каким-либо из процессоров компьютера, независимо от количества процессоров и от состояния кэш-буфера процессоров.</summary>
		/// <param name="address">Поле для чтения.</param>
		/// <returns>Последнее значение, записанное в поле любым процессором.</returns>
		// Token: 0x06001FCD RID: 8141
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int VolatileRead(ref int address);

		/// <summary>Считывает значение поля. Это значение является последним записанным каким-либо из процессоров компьютера, независимо от количества процессоров и от состояния кэш-буфера процессоров.</summary>
		/// <param name="address">Поле для чтения.</param>
		/// <returns>Последнее значение, записанное в поле любым процессором.</returns>
		// Token: 0x06001FCE RID: 8142
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long VolatileRead(ref long address);

		/// <summary>Считывает значение поля. Это значение является последним записанным каким-либо из процессоров компьютера, независимо от количества процессоров и от состояния кэш-буфера процессоров.</summary>
		/// <param name="address">Поле для чтения.</param>
		/// <returns>Последнее значение, записанное в поле любым процессором.</returns>
		// Token: 0x06001FCF RID: 8143
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr VolatileRead(ref IntPtr address);

		/// <summary>Считывает значение поля. Это значение является последним записанным каким-либо из процессоров компьютера, независимо от количества процессоров и от состояния кэш-буфера процессоров.</summary>
		/// <param name="address">Поле для чтения.</param>
		/// <returns>Последнее значение, записанное в поле любым процессором.</returns>
		// Token: 0x06001FD0 RID: 8144
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object VolatileRead(ref object address);

		/// <summary>Считывает значение поля. Это значение является последним записанным каким-либо из процессоров компьютера, независимо от количества процессоров и от состояния кэш-буфера процессоров.</summary>
		/// <param name="address">Поле для чтения.</param>
		/// <returns>Последнее значение, записанное в поле любым процессором.</returns>
		// Token: 0x06001FD1 RID: 8145
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern sbyte VolatileRead(ref sbyte address);

		/// <summary>Считывает значение поля. Это значение является последним записанным каким-либо из процессоров компьютера, независимо от количества процессоров и от состояния кэш-буфера процессоров.</summary>
		/// <param name="address">Поле для чтения.</param>
		/// <returns>Последнее значение, записанное в поле любым процессором.</returns>
		// Token: 0x06001FD2 RID: 8146
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float VolatileRead(ref float address);

		/// <summary>Считывает значение поля. Это значение является последним записанным каким-либо из процессоров компьютера, независимо от количества процессоров и от состояния кэш-буфера процессоров.</summary>
		/// <param name="address">Поле для чтения.</param>
		/// <returns>Последнее значение, записанное в поле любым процессором.</returns>
		// Token: 0x06001FD3 RID: 8147
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern ushort VolatileRead(ref ushort address);

		/// <summary>Считывает значение поля. Это значение является последним записанным каким-либо из процессоров компьютера, независимо от количества процессоров и от состояния кэш-буфера процессоров.</summary>
		/// <param name="address">Поле для чтения.</param>
		/// <returns>Последнее значение, записанное в поле любым процессором.</returns>
		// Token: 0x06001FD4 RID: 8148
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern uint VolatileRead(ref uint address);

		/// <summary>Считывает значение поля. Это значение является последним записанным каким-либо из процессоров компьютера, независимо от количества процессоров и от состояния кэш-буфера процессоров.</summary>
		/// <param name="address">Поле для чтения.</param>
		/// <returns>Последнее значение, записанное в поле любым процессором.</returns>
		// Token: 0x06001FD5 RID: 8149
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern ulong VolatileRead(ref ulong address);

		/// <summary>Считывает значение поля. Это значение является последним записанным каким-либо из процессоров компьютера, независимо от количества процессоров и от состояния кэш-буфера процессоров.</summary>
		/// <param name="address">Поле для чтения.</param>
		/// <returns>Последнее значение, записанное в поле любым процессором.</returns>
		// Token: 0x06001FD6 RID: 8150
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern UIntPtr VolatileRead(ref UIntPtr address);

		/// <summary>Записывает значение непосредственно в поле, так что оно становится видимым для всех процессоров компьютера.</summary>
		/// <param name="address">Поле, в которое требуется записать значение.</param>
		/// <param name="value">Записываемое значение.</param>
		// Token: 0x06001FD7 RID: 8151
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void VolatileWrite(ref byte address, byte value);

		/// <summary>Записывает значение непосредственно в поле, так что оно становится видимым для всех процессоров компьютера.</summary>
		/// <param name="address">Поле, в которое требуется записать значение.</param>
		/// <param name="value">Записываемое значение.</param>
		// Token: 0x06001FD8 RID: 8152
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void VolatileWrite(ref double address, double value);

		/// <summary>Записывает значение непосредственно в поле, так что оно становится видимым для всех процессоров компьютера.</summary>
		/// <param name="address">Поле, в которое требуется записать значение.</param>
		/// <param name="value">Записываемое значение.</param>
		// Token: 0x06001FD9 RID: 8153
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void VolatileWrite(ref short address, short value);

		/// <summary>Записывает значение непосредственно в поле, так что оно становится видимым для всех процессоров компьютера.</summary>
		/// <param name="address">Поле, в которое требуется записать значение.</param>
		/// <param name="value">Записываемое значение.</param>
		// Token: 0x06001FDA RID: 8154
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void VolatileWrite(ref int address, int value);

		/// <summary>Записывает значение непосредственно в поле, так что оно становится видимым для всех процессоров компьютера.</summary>
		/// <param name="address">Поле, в которое требуется записать значение.</param>
		/// <param name="value">Записываемое значение.</param>
		// Token: 0x06001FDB RID: 8155
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void VolatileWrite(ref long address, long value);

		/// <summary>Записывает значение непосредственно в поле, так что оно становится видимым для всех процессоров компьютера.</summary>
		/// <param name="address">Поле, в которое требуется записать значение.</param>
		/// <param name="value">Записываемое значение.</param>
		// Token: 0x06001FDC RID: 8156
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void VolatileWrite(ref IntPtr address, IntPtr value);

		/// <summary>Записывает значение непосредственно в поле, так что оно становится видимым для всех процессоров компьютера.</summary>
		/// <param name="address">Поле, в которое требуется записать значение.</param>
		/// <param name="value">Записываемое значение.</param>
		// Token: 0x06001FDD RID: 8157
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void VolatileWrite(ref object address, object value);

		/// <summary>Записывает значение непосредственно в поле, так что оно становится видимым для всех процессоров компьютера.</summary>
		/// <param name="address">Поле, в которое требуется записать значение.</param>
		/// <param name="value">Записываемое значение.</param>
		// Token: 0x06001FDE RID: 8158
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void VolatileWrite(ref sbyte address, sbyte value);

		/// <summary>Записывает значение непосредственно в поле, так что оно становится видимым для всех процессоров компьютера.</summary>
		/// <param name="address">Поле, в которое требуется записать значение.</param>
		/// <param name="value">Записываемое значение.</param>
		// Token: 0x06001FDF RID: 8159
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void VolatileWrite(ref float address, float value);

		/// <summary>Записывает значение непосредственно в поле, так что оно становится видимым для всех процессоров компьютера.</summary>
		/// <param name="address">Поле, в которое требуется записать значение.</param>
		/// <param name="value">Записываемое значение.</param>
		// Token: 0x06001FE0 RID: 8160
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void VolatileWrite(ref ushort address, ushort value);

		/// <summary>Записывает значение непосредственно в поле, так что оно становится видимым для всех процессоров компьютера.</summary>
		/// <param name="address">Поле, в которое требуется записать значение.</param>
		/// <param name="value">Записываемое значение.</param>
		// Token: 0x06001FE1 RID: 8161
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void VolatileWrite(ref uint address, uint value);

		/// <summary>Записывает значение непосредственно в поле, так что оно становится видимым для всех процессоров компьютера.</summary>
		/// <param name="address">Поле, в которое требуется записать значение.</param>
		/// <param name="value">Записываемое значение.</param>
		// Token: 0x06001FE2 RID: 8162
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void VolatileWrite(ref ulong address, ulong value);

		/// <summary>Записывает значение непосредственно в поле, так что оно становится видимым для всех процессоров компьютера.</summary>
		/// <param name="address">Поле, в которое требуется записать значение.</param>
		/// <param name="value">Записываемое значение.</param>
		// Token: 0x06001FE3 RID: 8163
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void VolatileWrite(ref UIntPtr address, UIntPtr value);

		// Token: 0x06001FE4 RID: 8164
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int SystemMaxStackStize();

		// Token: 0x06001FE5 RID: 8165 RVA: 0x00074808 File Offset: 0x00072A08
		private static int GetProcessDefaultStackSize(int maxStackSize)
		{
			if (maxStackSize == 0)
			{
				return 0;
			}
			if (maxStackSize < 131072)
			{
				return 131072;
			}
			int pageSize = Environment.GetPageSize();
			if (maxStackSize % pageSize != 0)
			{
				maxStackSize = maxStackSize / (pageSize - 1) * pageSize;
			}
			return Math.Min(maxStackSize, Thread.SystemMaxStackStize());
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x00074847 File Offset: 0x00072A47
		private void SetStart(MulticastDelegate start, int maxStackSize)
		{
			this.m_Delegate = start;
			this.Internal.stack_size = maxStackSize;
		}

		/// <summary>Возвращает уникальный идентификатор текущего управляемого потока.</summary>
		/// <returns>Целочисленное значение, представляющее уникальный идентификатор для этого управляемого потока.</returns>
		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001FE7 RID: 8167 RVA: 0x0007485C File Offset: 0x00072A5C
		public int ManagedThreadId
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				return this.Internal.managed_id;
			}
		}

		/// <summary>Уведомляет узел, что выполнение близится ко входу в область кода, в которой эффекты прерывания выполнения или неуправляемого выполнения могут повлиять на другие задачи в домене приложения.</summary>
		// Token: 0x06001FE8 RID: 8168 RVA: 0x00074869 File Offset: 0x00072A69
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static void BeginCriticalRegion()
		{
			Thread.CurrentThread.Internal.critical_region_level++;
		}

		/// <summary>Уведомляет узел, что выполнение близится ко входу в область кода, в которой эффекты прерывания выполнения или неуправляемой ошибки ограничены текущей задачей.</summary>
		// Token: 0x06001FE9 RID: 8169 RVA: 0x00074886 File Offset: 0x00072A86
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void EndCriticalRegion()
		{
			Thread.CurrentThread.Internal.critical_region_level--;
		}

		/// <summary>Уведомляет узел, что управляемый код близок к выполнению инструкций, зависящих от идентификации текущего потока операционной системы.</summary>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06001FEA RID: 8170 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static void BeginThreadAffinity()
		{
		}

		/// <summary>Уведомляет узел об окончании выполнения кодом инструкций, которые зависят от идентификатора текущего потока в операционной системе.</summary>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x06001FEB RID: 8171 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static void EndThreadAffinity()
		{
		}

		/// <summary>Возвращает значение типа <see cref="T:System.Threading.ApartmentState" />, показывающее состояние апартамента.</summary>
		/// <returns>Одно из значений <see cref="T:System.Threading.ApartmentState" />, показывающее состояние подразделения управляемого потока. Значение по умолчанию — <see cref="F:System.Threading.ApartmentState.Unknown" />.</returns>
		// Token: 0x06001FEC RID: 8172 RVA: 0x0007468C File Offset: 0x0007288C
		public ApartmentState GetApartmentState()
		{
			this.ValidateThreadState();
			return (ApartmentState)this.Internal.apartment_state;
		}

		/// <summary>Задает модель "apartment" для потока до его запуска.</summary>
		/// <param name="state">Новая модель "apartment".</param>
		/// <exception cref="T:System.PlatformNotSupportedException">Только в .NET Core: этот элемент не поддерживается на платформах Linux и macOS.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="state" /> не является допустимым состоянием подразделения.</exception>
		/// <exception cref="T:System.Threading.ThreadStateException">Поток уже запущен.</exception>
		/// <exception cref="T:System.InvalidOperationException">Состояние подразделения уже инициализировано.</exception>
		// Token: 0x06001FED RID: 8173 RVA: 0x000748A3 File Offset: 0x00072AA3
		public void SetApartmentState(ApartmentState state)
		{
			if (!this.TrySetApartmentState(state))
			{
				throw new InvalidOperationException("Failed to set the specified COM apartment state.");
			}
		}

		/// <summary>Задает модель "apartment" для потока до его запуска.</summary>
		/// <param name="state">Новая модель "apartment".</param>
		/// <returns>Значение <see langword="true" />, если задана модель "apartment"; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="state" /> не является допустимым состоянием подразделения.</exception>
		/// <exception cref="T:System.Threading.ThreadStateException">Поток уже запущен.</exception>
		// Token: 0x06001FEE RID: 8174 RVA: 0x000748BC File Offset: 0x00072ABC
		public bool TrySetApartmentState(ApartmentState state)
		{
			if ((this.ThreadState & ThreadState.Unstarted) == ThreadState.Running)
			{
				throw new ThreadStateException("Thread was in an invalid state for the operation being executed.");
			}
			if (this.Internal.apartment_state != 2 && (ApartmentState)this.Internal.apartment_state != state)
			{
				return false;
			}
			this.Internal.apartment_state = (byte)state;
			return true;
		}

		/// <summary>Возвращает хэш-код текущего потока.</summary>
		/// <returns>Целочисленное значение хэш-кода.</returns>
		// Token: 0x06001FEF RID: 8175 RVA: 0x0007490A File Offset: 0x00072B0A
		[ComVisible(false)]
		public override int GetHashCode()
		{
			return this.ManagedThreadId;
		}

		// Token: 0x06001FF0 RID: 8176
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void GetStackTraces(out Thread[] threads, out object[] stack_frames);

		// Token: 0x06001FF1 RID: 8177 RVA: 0x00074914 File Offset: 0x00072B14
		internal static Dictionary<Thread, StackTrace> Mono_GetStackTraces()
		{
			Thread[] array;
			object[] array2;
			Thread.GetStackTraces(out array, out array2);
			Dictionary<Thread, StackTrace> dictionary = new Dictionary<Thread, StackTrace>();
			for (int i = 0; i < array.Length; i++)
			{
				dictionary[array[i]] = new StackTrace((StackFrame[])array2[i]);
			}
			return dictionary;
		}

		/// <summary>Отключает автоматическую очистку вызываемых оболочек времени выполнения (RCW) для текущего потока.</summary>
		// Token: 0x06001FF2 RID: 8178 RVA: 0x0001B98B File Offset: 0x00019B8B
		public void DisableComObjectEagerCleanup()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x00074955 File Offset: 0x00072B55
		private ThreadState ValidateThreadState()
		{
			ThreadState state = Thread.GetState(this.Internal);
			if ((state & ThreadState.Stopped) != ThreadState.Running)
			{
				throw new ThreadStateException("Thread is dead; state can not be accessed.");
			}
			return state;
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x00074973 File Offset: 0x00072B73
		public static int GetCurrentProcessorId()
		{
			return RuntimeThread.GetCurrentProcessorId();
		}

		// Token: 0x04001B15 RID: 6933
		private static LocalDataStoreMgr s_LocalDataStoreMgr;

		// Token: 0x04001B16 RID: 6934
		[ThreadStatic]
		private static LocalDataStoreHolder s_LocalDataStore;

		// Token: 0x04001B17 RID: 6935
		[ThreadStatic]
		internal static CultureInfo m_CurrentCulture;

		// Token: 0x04001B18 RID: 6936
		[ThreadStatic]
		internal static CultureInfo m_CurrentUICulture;

		// Token: 0x04001B19 RID: 6937
		private static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture;

		// Token: 0x04001B1A RID: 6938
		private static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture;

		// Token: 0x04001B1B RID: 6939
		private InternalThread internal_thread;

		// Token: 0x04001B1C RID: 6940
		private object m_ThreadStartArg;

		// Token: 0x04001B1D RID: 6941
		private object pending_exception;

		// Token: 0x04001B1E RID: 6942
		[ThreadStatic]
		private static Thread current_thread;

		// Token: 0x04001B1F RID: 6943
		private MulticastDelegate m_Delegate;

		// Token: 0x04001B20 RID: 6944
		private ExecutionContext m_ExecutionContext;

		// Token: 0x04001B21 RID: 6945
		private bool m_ExecutionContextBelongsToOuterScope;

		// Token: 0x04001B22 RID: 6946
		private IPrincipal principal;

		// Token: 0x04001B23 RID: 6947
		private int principal_version;
	}
}
