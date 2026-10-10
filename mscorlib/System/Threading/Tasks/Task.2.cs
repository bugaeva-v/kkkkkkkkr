using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security;
using Internal.Runtime.Augments;
using Internal.Threading.Tasks.Tracing;

namespace System.Threading.Tasks
{
	/// <summary>Представляет асинхронную операцию.</summary>
	// Token: 0x02000357 RID: 855
	[DebuggerTypeProxy(typeof(SystemThreadingTasks_TaskDebugView))]
	[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}")]
	public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable
	{
		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x0600237C RID: 9084 RVA: 0x0007F1CD File Offset: 0x0007D3CD
		private Task ParentForDebugger
		{
			get
			{
				return this.m_parent;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x0600237D RID: 9085 RVA: 0x0007F1D5 File Offset: 0x0007D3D5
		private int StateFlagsForDebugger
		{
			get
			{
				return this.m_stateFlags;
			}
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x0007F1E0 File Offset: 0x0007D3E0
		internal Task(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct)
		{
			if (canceled)
			{
				this.m_stateFlags = (int)((TaskCreationOptions)5242880 | creationOptions);
				Task.ContingentProperties contingentProperties = this.m_contingentProperties = new Task.ContingentProperties();
				contingentProperties.m_cancellationToken = ct;
				contingentProperties.m_internalCancellationRequested = 1;
				return;
			}
			this.m_stateFlags = (int)((TaskCreationOptions)16777216 | creationOptions);
		}

		// Token: 0x0600237F RID: 9087 RVA: 0x0007F236 File Offset: 0x0007D436
		internal Task()
		{
			this.m_stateFlags = 33555456;
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x0007F24C File Offset: 0x0007D44C
		internal Task(object state, TaskCreationOptions creationOptions, bool promiseStyle)
		{
			if ((creationOptions & ~(TaskCreationOptions.AttachedToParent | TaskCreationOptions.RunContinuationsAsynchronously)) != TaskCreationOptions.None)
			{
				throw new ArgumentOutOfRangeException("creationOptions");
			}
			if ((creationOptions & TaskCreationOptions.AttachedToParent) != TaskCreationOptions.None)
			{
				this.m_parent = Task.InternalCurrent;
			}
			this.TaskConstructorCore(null, state, default(CancellationToken), creationOptions, InternalTaskOptions.PromiseTask, null);
		}

		/// <summary>Инициализирует новую задачу <see cref="T:System.Threading.Tasks.Task" /> с заданным действием.</summary>
		/// <param name="action">Делегат, который представляет код, выполняемый в рамках задачи.</param>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="action" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002381 RID: 9089 RVA: 0x0007F298 File Offset: 0x0007D498
		public Task(Action action) : this(action, null, null, default(CancellationToken), TaskCreationOptions.None, InternalTaskOptions.None, null)
		{
		}

		/// <summary>Инициализирует новую задачу <see cref="T:System.Threading.Tasks.Task" /> с заданным действием и токеном <see cref="T:System.Threading.CancellationToken" />.</summary>
		/// <param name="action">Делегат, который представляет код, выполняемый в рамках задачи.</param>
		/// <param name="cancellationToken">Токен <see cref="T:System.Threading.CancellationToken" />, который будет контролироваться новой задачей.</param>
		/// <exception cref="T:System.ObjectDisposedException">Предоставленный объект <see cref="T:System.Threading.CancellationToken" /> уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="action" /> имеет значение NULL.</exception>
		// Token: 0x06002382 RID: 9090 RVA: 0x0007F2BA File Offset: 0x0007D4BA
		public Task(Action action, CancellationToken cancellationToken) : this(action, null, null, cancellationToken, TaskCreationOptions.None, InternalTaskOptions.None, null)
		{
		}

		/// <summary>Инициализирует новую задачу <see cref="T:System.Threading.Tasks.Task" /> с заданными действием и параметрами создания.</summary>
		/// <param name="action">Делегат, который представляет код, выполняемый в рамках задачи.</param>
		/// <param name="creationOptions">Объект <see cref="T:System.Threading.Tasks.TaskCreationOptions" />, который используется для настройки поведения задачи.</param>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="action" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="creationOptions" /> задает недопустимое значение для <see cref="T:System.Threading.Tasks.TaskCreationOptions" />.</exception>
		// Token: 0x06002383 RID: 9091 RVA: 0x0007F2CC File Offset: 0x0007D4CC
		public Task(Action action, TaskCreationOptions creationOptions) : this(action, null, Task.InternalCurrentIfAttached(creationOptions), default(CancellationToken), creationOptions, InternalTaskOptions.None, null)
		{
		}

		/// <summary>Инициализирует новую задачу <see cref="T:System.Threading.Tasks.Task" /> с заданными действием и параметрами создания.</summary>
		/// <param name="action">Делегат, который представляет код, выполняемый в рамках задачи.</param>
		/// <param name="cancellationToken">Токен <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" />, который будет контролироваться новой задачей.</param>
		/// <param name="creationOptions">Объект <see cref="T:System.Threading.Tasks.TaskCreationOptions" />, который используется для настройки поведения задачи.</param>
		/// <exception cref="T:System.ObjectDisposedException">Класс <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="action" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="creationOptions" /> задает недопустимое значение для <see cref="T:System.Threading.Tasks.TaskCreationOptions" />.</exception>
		// Token: 0x06002384 RID: 9092 RVA: 0x0007F2F3 File Offset: 0x0007D4F3
		public Task(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions) : this(action, null, Task.InternalCurrentIfAttached(creationOptions), cancellationToken, creationOptions, InternalTaskOptions.None, null)
		{
		}

		/// <summary>Инициализирует новую задачу <see cref="T:System.Threading.Tasks.Task" /> с заданным действием и состоянием.</summary>
		/// <param name="action">Делегат, который представляет код, выполняемый в рамках задачи.</param>
		/// <param name="state">Объект, который представляет данные, используемые действием.</param>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="action" /> имеет значение NULL.</exception>
		// Token: 0x06002385 RID: 9093 RVA: 0x0007F308 File Offset: 0x0007D508
		public Task(Action<object> action, object state) : this(action, state, null, default(CancellationToken), TaskCreationOptions.None, InternalTaskOptions.None, null)
		{
		}

		/// <summary>Инициализирует новую задачу <see cref="T:System.Threading.Tasks.Task" /> с заданными действием, состоянием и параметрами.</summary>
		/// <param name="action">Делегат, который представляет код, выполняемый в рамках задачи.</param>
		/// <param name="state">Объект, который представляет данные, используемые действием.</param>
		/// <param name="cancellationToken">Токен <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" />, который будет контролироваться новой задачей.</param>
		/// <exception cref="T:System.ObjectDisposedException">Класс <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="action" /> имеет значение NULL.</exception>
		// Token: 0x06002386 RID: 9094 RVA: 0x0007F32A File Offset: 0x0007D52A
		public Task(Action<object> action, object state, CancellationToken cancellationToken) : this(action, state, null, cancellationToken, TaskCreationOptions.None, InternalTaskOptions.None, null)
		{
		}

		/// <summary>Инициализирует новую задачу <see cref="T:System.Threading.Tasks.Task" /> с заданными действием, состоянием и параметрами.</summary>
		/// <param name="action">Делегат, который представляет код, выполняемый в рамках задачи.</param>
		/// <param name="state">Объект, который представляет данные, используемые действием.</param>
		/// <param name="creationOptions">Объект <see cref="T:System.Threading.Tasks.TaskCreationOptions" />, который используется для настройки поведения задачи.</param>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="action" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="creationOptions" /> задает недопустимое значение для <see cref="T:System.Threading.Tasks.TaskCreationOptions" />.</exception>
		// Token: 0x06002387 RID: 9095 RVA: 0x0007F33C File Offset: 0x0007D53C
		public Task(Action<object> action, object state, TaskCreationOptions creationOptions) : this(action, state, Task.InternalCurrentIfAttached(creationOptions), default(CancellationToken), creationOptions, InternalTaskOptions.None, null)
		{
		}

		/// <summary>Инициализирует новую задачу <see cref="T:System.Threading.Tasks.Task" /> с заданными действием, состоянием и параметрами.</summary>
		/// <param name="action">Делегат, который представляет код, выполняемый в рамках задачи.</param>
		/// <param name="state">Объект, который представляет данные, используемые действием.</param>
		/// <param name="cancellationToken">Токен <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" />, который будет контролироваться новой задачей.</param>
		/// <param name="creationOptions">Объект <see cref="T:System.Threading.Tasks.TaskCreationOptions" />, который используется для настройки поведения задачи.</param>
		/// <exception cref="T:System.ObjectDisposedException">Класс <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="action" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="creationOptions" /> задает недопустимое значение для <see cref="T:System.Threading.Tasks.TaskCreationOptions" />.</exception>
		// Token: 0x06002388 RID: 9096 RVA: 0x0007F363 File Offset: 0x0007D563
		public Task(Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) : this(action, state, Task.InternalCurrentIfAttached(creationOptions), cancellationToken, creationOptions, InternalTaskOptions.None, null)
		{
		}

		// Token: 0x06002389 RID: 9097 RVA: 0x0007F379 File Offset: 0x0007D579
		internal Task(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			if (action == null)
			{
				throw new ArgumentNullException("action");
			}
			if ((creationOptions & TaskCreationOptions.AttachedToParent) != TaskCreationOptions.None)
			{
				this.m_parent = parent;
			}
			this.TaskConstructorCore(action, state, cancellationToken, creationOptions, internalOptions, scheduler);
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x0007F3AC File Offset: 0x0007D5AC
		internal void TaskConstructorCore(Delegate action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			this.m_action = action;
			this.m_stateObject = state;
			this.m_taskScheduler = scheduler;
			if ((creationOptions & ~(TaskCreationOptions.PreferFairness | TaskCreationOptions.LongRunning | TaskCreationOptions.AttachedToParent | TaskCreationOptions.DenyChildAttach | TaskCreationOptions.HideScheduler | TaskCreationOptions.RunContinuationsAsynchronously)) != TaskCreationOptions.None)
			{
				throw new ArgumentOutOfRangeException("creationOptions");
			}
			int num = (int)(creationOptions | (TaskCreationOptions)internalOptions);
			if (this.m_action == null || (internalOptions & InternalTaskOptions.ContinuationTask) != InternalTaskOptions.None)
			{
				num |= 33554432;
			}
			this.m_stateFlags = num;
			if (this.m_parent != null && (creationOptions & TaskCreationOptions.AttachedToParent) != TaskCreationOptions.None && (this.m_parent.CreationOptions & TaskCreationOptions.DenyChildAttach) == TaskCreationOptions.None)
			{
				this.m_parent.AddNewChild();
			}
			if (cancellationToken.CanBeCanceled)
			{
				this.AssignCancellationToken(cancellationToken, null, null);
			}
			this.CapturedContext = ExecutionContext.Capture();
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x0007F450 File Offset: 0x0007D650
		private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation)
		{
			Task.ContingentProperties contingentProperties = this.EnsureContingentPropertiesInitialized(false);
			contingentProperties.m_cancellationToken = cancellationToken;
			try
			{
				if ((this.Options & (TaskCreationOptions)13312) == TaskCreationOptions.None)
				{
					if (cancellationToken.IsCancellationRequested)
					{
						this.InternalCancel(false);
					}
					else
					{
						CancellationTokenRegistration cancellationTokenRegistration;
						if (antecedent == null)
						{
							cancellationTokenRegistration = cancellationToken.InternalRegisterWithoutEC(Task.s_taskCancelCallback, this);
						}
						else
						{
							cancellationTokenRegistration = cancellationToken.InternalRegisterWithoutEC(Task.s_taskCancelCallback, new Tuple<Task, Task, TaskContinuation>(this, antecedent, continuation));
						}
						contingentProperties.m_cancellationRegistration = cancellationTokenRegistration;
					}
				}
			}
			catch
			{
				if (this.m_parent != null && (this.Options & TaskCreationOptions.AttachedToParent) != TaskCreationOptions.None && (this.m_parent.Options & TaskCreationOptions.DenyChildAttach) == TaskCreationOptions.None)
				{
					this.m_parent.DisregardChild();
				}
				throw;
			}
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x0007F504 File Offset: 0x0007D704
		private static void TaskCancelCallback(object o)
		{
			Task task = o as Task;
			if (task == null)
			{
				Tuple<Task, Task, TaskContinuation> tuple = o as Tuple<Task, Task, TaskContinuation>;
				if (tuple != null)
				{
					task = tuple.Item1;
					Task item = tuple.Item2;
					TaskContinuation item2 = tuple.Item3;
					item.RemoveContinuation(item2);
				}
			}
			task.InternalCancel(false);
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x0007F549 File Offset: 0x0007D749
		internal bool TrySetCanceled(CancellationToken tokenToRecord)
		{
			return this.TrySetCanceled(tokenToRecord, null);
		}

		// Token: 0x0600238E RID: 9102 RVA: 0x0007F554 File Offset: 0x0007D754
		internal bool TrySetCanceled(CancellationToken tokenToRecord, object cancellationException)
		{
			bool result = false;
			if (this.AtomicStateUpdate(67108864, 90177536))
			{
				this.RecordInternalCancellationRequest(tokenToRecord, cancellationException);
				this.CancellationCleanupLogic();
				result = true;
			}
			return result;
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x0007F588 File Offset: 0x0007D788
		internal bool TrySetException(object exceptionObject)
		{
			bool result = false;
			this.EnsureContingentPropertiesInitialized(true);
			if (this.AtomicStateUpdate(67108864, 90177536))
			{
				this.AddException(exceptionObject);
				this.Finish(false);
				result = true;
			}
			return result;
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06002390 RID: 9104 RVA: 0x0007F5C4 File Offset: 0x0007D7C4
		private string DebuggerDisplayMethodDescription
		{
			get
			{
				Delegate action = this.m_action;
				if (action == null)
				{
					return "{null}";
				}
				return "0x" + action.GetNativeFunctionPointer().ToString("x");
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06002391 RID: 9105 RVA: 0x0007F5FE File Offset: 0x0007D7FE
		internal TaskCreationOptions Options
		{
			get
			{
				return Task.OptionsMethod(this.m_stateFlags);
			}
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x0007F60D File Offset: 0x0007D80D
		internal static TaskCreationOptions OptionsMethod(int flags)
		{
			return (TaskCreationOptions)(flags & 65535);
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x0007F618 File Offset: 0x0007D818
		internal bool AtomicStateUpdate(int newBits, int illegalBits)
		{
			SpinWait spinWait = default(SpinWait);
			for (;;)
			{
				int stateFlags = this.m_stateFlags;
				if ((stateFlags & illegalBits) != 0)
				{
					break;
				}
				if (Interlocked.CompareExchange(ref this.m_stateFlags, stateFlags | newBits, stateFlags) == stateFlags)
				{
					return true;
				}
				spinWait.SpinOnce();
			}
			return false;
		}

		// Token: 0x06002394 RID: 9108 RVA: 0x0007F65C File Offset: 0x0007D85C
		internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags)
		{
			SpinWait spinWait = default(SpinWait);
			for (;;)
			{
				oldFlags = this.m_stateFlags;
				if ((oldFlags & illegalBits) != 0)
				{
					break;
				}
				if (Interlocked.CompareExchange(ref this.m_stateFlags, oldFlags | newBits, oldFlags) == oldFlags)
				{
					return true;
				}
				spinWait.SpinOnce();
			}
			return false;
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x0007F6A4 File Offset: 0x0007D8A4
		internal void SetNotificationForWaitCompletion(bool enabled)
		{
			if (enabled)
			{
				this.AtomicStateUpdate(268435456, 90177536);
				return;
			}
			SpinWait spinWait = default(SpinWait);
			for (;;)
			{
				int stateFlags = this.m_stateFlags;
				int value = stateFlags & -268435457;
				if (Interlocked.CompareExchange(ref this.m_stateFlags, value, stateFlags) == stateFlags)
				{
					break;
				}
				spinWait.SpinOnce();
			}
		}

		// Token: 0x06002396 RID: 9110 RVA: 0x0007F6F8 File Offset: 0x0007D8F8
		internal bool NotifyDebuggerOfWaitCompletionIfNecessary()
		{
			if (this.IsWaitNotificationEnabled && this.ShouldNotifyDebuggerOfWaitCompletion)
			{
				this.NotifyDebuggerOfWaitCompletion();
				return true;
			}
			return false;
		}

		// Token: 0x06002397 RID: 9111 RVA: 0x0007F714 File Offset: 0x0007D914
		internal static bool AnyTaskRequiresNotifyDebuggerOfWaitCompletion(Task[] tasks)
		{
			foreach (Task task in tasks)
			{
				if (task != null && task.IsWaitNotificationEnabled && task.ShouldNotifyDebuggerOfWaitCompletion)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06002398 RID: 9112 RVA: 0x0007F74B File Offset: 0x0007D94B
		internal bool IsWaitNotificationEnabledOrNotRanToCompletion
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return (this.m_stateFlags & 285212672) != 16777216;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06002399 RID: 9113 RVA: 0x0007F765 File Offset: 0x0007D965
		internal virtual bool ShouldNotifyDebuggerOfWaitCompletion
		{
			get
			{
				return this.IsWaitNotificationEnabled;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x0600239A RID: 9114 RVA: 0x0007F76D File Offset: 0x0007D96D
		internal bool IsWaitNotificationEnabled
		{
			get
			{
				return (this.m_stateFlags & 268435456) != 0;
			}
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x0007F780 File Offset: 0x0007D980
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void NotifyDebuggerOfWaitCompletion()
		{
			this.SetNotificationForWaitCompletion(false);
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x0007F789 File Offset: 0x0007D989
		internal bool MarkStarted()
		{
			return this.AtomicStateUpdate(65536, 4259840);
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x0007F79C File Offset: 0x0007D99C
		internal void AddNewChild()
		{
			Task.ContingentProperties contingentProperties = this.EnsureContingentPropertiesInitialized(true);
			if (contingentProperties.m_completionCountdown == 1)
			{
				contingentProperties.m_completionCountdown++;
				return;
			}
			Interlocked.Increment(ref contingentProperties.m_completionCountdown);
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x0007F7DB File Offset: 0x0007D9DB
		internal void DisregardChild()
		{
			Interlocked.Decrement(ref this.EnsureContingentPropertiesInitialized(true).m_completionCountdown);
		}

		/// <summary>Запускает задачу <see cref="T:System.Threading.Tasks.Task" />, планируя ее выполнение в текущем планировщике <see cref="T:System.Threading.Tasks.TaskScheduler" />.</summary>
		/// <exception cref="T:System.ObjectDisposedException">Экземпляр <see cref="T:System.Threading.Tasks.Task" /> удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Задача <see cref="T:System.Threading.Tasks.Task" /> не находится в допустимом состоянии для запуска. Возможно, она уже запущена, выполнена или отменена, или она была создана способом, не поддерживающим прямое планирование.</exception>
		// Token: 0x0600239F RID: 9119 RVA: 0x0007F7EF File Offset: 0x0007D9EF
		public void Start()
		{
			this.Start(TaskScheduler.Current);
		}

		/// <summary>Запускает задачу <see cref="T:System.Threading.Tasks.Task" />, планируя ее выполнение в заданном планировщике <see cref="T:System.Threading.Tasks.TaskScheduler" />.</summary>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, с которым нужно связать и в котором нужно выполнить данную задачу.</param>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="scheduler" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Задача <see cref="T:System.Threading.Tasks.Task" /> не находится в допустимом состоянии для запуска. Возможно, она уже запущена, выполнена или отменена, или она была создана способом, не поддерживающим прямое планирование.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Экземпляр <see cref="T:System.Threading.Tasks.Task" /> удален.</exception>
		/// <exception cref="T:System.Threading.Tasks.TaskSchedulerException">Планировщику не удалось поставить эту задачу в очередь.</exception>
		// Token: 0x060023A0 RID: 9120 RVA: 0x0007F7FC File Offset: 0x0007D9FC
		public void Start(TaskScheduler scheduler)
		{
			int stateFlags = this.m_stateFlags;
			if (Task.IsCompletedMethod(stateFlags))
			{
				throw new InvalidOperationException("Start may not be called on a task that has completed.");
			}
			if (scheduler == null)
			{
				throw new ArgumentNullException("scheduler");
			}
			TaskCreationOptions taskCreationOptions = Task.OptionsMethod(stateFlags);
			if ((taskCreationOptions & (TaskCreationOptions)1024) != TaskCreationOptions.None)
			{
				throw new InvalidOperationException("Start may not be called on a promise-style task.");
			}
			if ((taskCreationOptions & (TaskCreationOptions)512) != TaskCreationOptions.None)
			{
				throw new InvalidOperationException("Start may not be called on a continuation task.");
			}
			if (Interlocked.CompareExchange<TaskScheduler>(ref this.m_taskScheduler, scheduler, null) != null)
			{
				throw new InvalidOperationException("Start may not be called on a task that was already started.");
			}
			this.ScheduleAndStart(true);
		}

		/// <summary>Синхронно выполняет задачу <see cref="T:System.Threading.Tasks.Task" /> в текущем планировщике <see cref="T:System.Threading.Tasks.TaskScheduler" />.</summary>
		/// <exception cref="T:System.ObjectDisposedException">Экземпляр <see cref="T:System.Threading.Tasks.Task" /> удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Задача <see cref="T:System.Threading.Tasks.Task" /> не находится в допустимом состоянии для запуска. Возможно, она уже запущена, выполнена или отменена, или она была создана способом, не поддерживающим прямое планирование.</exception>
		// Token: 0x060023A1 RID: 9121 RVA: 0x0007F87F File Offset: 0x0007DA7F
		public void RunSynchronously()
		{
			this.InternalRunSynchronously(TaskScheduler.Current, true);
		}

		/// <summary>Синхронно выполняет задачу <see cref="T:System.Threading.Tasks.Task" /> в предоставленном планировщике <see cref="T:System.Threading.Tasks.TaskScheduler" />.</summary>
		/// <param name="scheduler">Планировщик, в котором следует попытаться выполнить задачу.</param>
		/// <exception cref="T:System.ObjectDisposedException">Экземпляр <see cref="T:System.Threading.Tasks.Task" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="scheduler" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Задача <see cref="T:System.Threading.Tasks.Task" /> не находится в допустимом состоянии для запуска. Возможно, она уже запущена, выполнена или отменена, или она была создана способом, не поддерживающим прямое планирование.</exception>
		// Token: 0x060023A2 RID: 9122 RVA: 0x0007F88D File Offset: 0x0007DA8D
		public void RunSynchronously(TaskScheduler scheduler)
		{
			if (scheduler == null)
			{
				throw new ArgumentNullException("scheduler");
			}
			this.InternalRunSynchronously(scheduler, true);
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x0007F8A8 File Offset: 0x0007DAA8
		internal void InternalRunSynchronously(TaskScheduler scheduler, bool waitForCompletion)
		{
			int stateFlags = this.m_stateFlags;
			TaskCreationOptions taskCreationOptions = Task.OptionsMethod(stateFlags);
			if ((taskCreationOptions & (TaskCreationOptions)512) != TaskCreationOptions.None)
			{
				throw new InvalidOperationException("RunSynchronously may not be called on a continuation task.");
			}
			if ((taskCreationOptions & (TaskCreationOptions)1024) != TaskCreationOptions.None)
			{
				throw new InvalidOperationException("RunSynchronously may not be called on a task not bound to a delegate, such as the task returned from an asynchronous method.");
			}
			if (Task.IsCompletedMethod(stateFlags))
			{
				throw new InvalidOperationException("RunSynchronously may not be called on a task that has already completed.");
			}
			if (Interlocked.CompareExchange<TaskScheduler>(ref this.m_taskScheduler, scheduler, null) != null)
			{
				throw new InvalidOperationException("RunSynchronously may not be called on a task that was already started.");
			}
			if (this.MarkStarted())
			{
				bool flag = false;
				try
				{
					if (!scheduler.TryRunInline(this, false))
					{
						scheduler.QueueTask(this);
						flag = true;
					}
					if (waitForCompletion && !this.IsCompleted)
					{
						this.SpinThenBlockingWait(-1, default(CancellationToken));
					}
					return;
				}
				catch (Exception innerException)
				{
					if (!flag)
					{
						TaskSchedulerException ex = new TaskSchedulerException(innerException);
						this.AddException(ex);
						this.Finish(false);
						this.m_contingentProperties.m_exceptionsHolder.MarkAsHandled(false);
						throw ex;
					}
					throw;
				}
			}
			throw new InvalidOperationException("RunSynchronously may not be called on a task that has already completed.");
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x0007F9A0 File Offset: 0x0007DBA0
		internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions)
		{
			if (scheduler == null)
			{
				throw new ArgumentNullException("scheduler");
			}
			Task task = new Task(action, state, creatingTask, cancellationToken, options, internalOptions | InternalTaskOptions.QueuedByRuntime, scheduler);
			task.ScheduleAndStart(false);
			return task;
		}

		/// <summary>Возвращает идентификатор данного экземпляра <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <returns>Идентификатор, присвоенный системой данному экземпляру <see cref="T:System.Threading.Tasks.Task" />.</returns>
		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060023A5 RID: 9125 RVA: 0x0007F9D0 File Offset: 0x0007DBD0
		public int Id
		{
			get
			{
				if (this.m_taskId == 0)
				{
					int num;
					do
					{
						num = Interlocked.Increment(ref Task.s_taskIdCounter);
					}
					while (num == 0);
					Interlocked.CompareExchange(ref this.m_taskId, num, 0);
				}
				return this.m_taskId;
			}
		}

		/// <summary>Возвращает идентификатор выполняющейся в настоящее время задачи <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <returns>Целое число, присвоенное системой выполняемой в настоящее время задаче.</returns>
		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060023A6 RID: 9126 RVA: 0x0007FA10 File Offset: 0x0007DC10
		public static int? CurrentId
		{
			get
			{
				Task internalCurrent = Task.InternalCurrent;
				if (internalCurrent != null)
				{
					return new int?(internalCurrent.Id);
				}
				return null;
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060023A7 RID: 9127 RVA: 0x0007FA3B File Offset: 0x0007DC3B
		internal static Task InternalCurrent
		{
			get
			{
				return Task.t_currentTask;
			}
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x0007FA42 File Offset: 0x0007DC42
		internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions)
		{
			if ((creationOptions & TaskCreationOptions.AttachedToParent) == TaskCreationOptions.None)
			{
				return null;
			}
			return Task.InternalCurrent;
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060023A9 RID: 9129 RVA: 0x0007FA50 File Offset: 0x0007DC50
		internal static StackGuard CurrentStackGuard
		{
			get
			{
				StackGuard stackGuard = Task.t_stackGuard;
				if (stackGuard == null)
				{
					stackGuard = (Task.t_stackGuard = new StackGuard());
				}
				return stackGuard;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.AggregateException" />, который привел к преждевременному завершению задачи <see cref="T:System.Threading.Tasks.Task" />. Если задача <see cref="T:System.Threading.Tasks.Task" /> завершилась успешно или еще не создала ни одного исключения, возвращает значение <see langword="null" />.</summary>
		/// <returns>Объект <see cref="T:System.AggregateException" />, который привел к преждевременному завершению задачи <see cref="T:System.Threading.Tasks.Task" />.</returns>
		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060023AA RID: 9130 RVA: 0x0007FA74 File Offset: 0x0007DC74
		public AggregateException Exception
		{
			get
			{
				AggregateException result = null;
				if (this.IsFaulted)
				{
					result = this.GetExceptions(false);
				}
				return result;
			}
		}

		/// <summary>Возвращает состояние <see cref="T:System.Threading.Tasks.TaskStatus" /> данной задачи.</summary>
		/// <returns>Текущее состояние <see cref="T:System.Threading.Tasks.TaskStatus" /> данного экземпляра задачи.</returns>
		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060023AB RID: 9131 RVA: 0x0007FA94 File Offset: 0x0007DC94
		public TaskStatus Status
		{
			get
			{
				int stateFlags = this.m_stateFlags;
				TaskStatus result;
				if ((stateFlags & 2097152) != 0)
				{
					result = TaskStatus.Faulted;
				}
				else if ((stateFlags & 4194304) != 0)
				{
					result = TaskStatus.Canceled;
				}
				else if ((stateFlags & 16777216) != 0)
				{
					result = TaskStatus.RanToCompletion;
				}
				else if ((stateFlags & 8388608) != 0)
				{
					result = TaskStatus.WaitingForChildrenToComplete;
				}
				else if ((stateFlags & 131072) != 0)
				{
					result = TaskStatus.Running;
				}
				else if ((stateFlags & 65536) != 0)
				{
					result = TaskStatus.WaitingToRun;
				}
				else if ((stateFlags & 33554432) != 0)
				{
					result = TaskStatus.WaitingForActivation;
				}
				else
				{
					result = TaskStatus.Created;
				}
				return result;
			}
		}

		/// <summary>Возвращает значение, указывающее, завершилось ли выполнение данного экземпляра <see cref="T:System.Threading.Tasks.Task" /> из-за отмены.</summary>
		/// <returns>Значение <see langword="true" />, если задача была завершена из-за отмены; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x060023AC RID: 9132 RVA: 0x0007FB08 File Offset: 0x0007DD08
		public bool IsCanceled
		{
			get
			{
				return (this.m_stateFlags & 6291456) == 4194304;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x060023AD RID: 9133 RVA: 0x0007FB20 File Offset: 0x0007DD20
		internal bool IsCancellationRequested
		{
			get
			{
				Task.ContingentProperties contingentProperties = this.m_contingentProperties;
				return contingentProperties != null && (contingentProperties.m_internalCancellationRequested == 1 || contingentProperties.m_cancellationToken.IsCancellationRequested);
			}
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x0007FB54 File Offset: 0x0007DD54
		internal Task.ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection)
		{
			Task.ContingentProperties contingentProperties = this.m_contingentProperties;
			if (contingentProperties == null)
			{
				return this.EnsureContingentPropertiesInitializedCore(needsProtection);
			}
			return contingentProperties;
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x0007FB78 File Offset: 0x0007DD78
		private Task.ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection)
		{
			if (needsProtection)
			{
				return LazyInitializer.EnsureInitialized<Task.ContingentProperties>(ref this.m_contingentProperties, Task.s_createContingentProperties);
			}
			return this.m_contingentProperties = new Task.ContingentProperties();
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x060023B0 RID: 9136 RVA: 0x0007FBAC File Offset: 0x0007DDAC
		internal CancellationToken CancellationToken
		{
			get
			{
				Task.ContingentProperties contingentProperties = this.m_contingentProperties;
				if (contingentProperties != null)
				{
					return contingentProperties.m_cancellationToken;
				}
				return default(CancellationToken);
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060023B1 RID: 9137 RVA: 0x0007FBD5 File Offset: 0x0007DDD5
		internal bool IsCancellationAcknowledged
		{
			get
			{
				return (this.m_stateFlags & 1048576) != 0;
			}
		}

		/// <summary>Возвращает значение, которое показывает, завершилась ли задача <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <returns>Значение <see langword="true" />, если задача была завершена; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x060023B2 RID: 9138 RVA: 0x0007FBE8 File Offset: 0x0007DDE8
		public bool IsCompleted
		{
			get
			{
				return Task.IsCompletedMethod(this.m_stateFlags);
			}
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x0007FBF7 File Offset: 0x0007DDF7
		private static bool IsCompletedMethod(int flags)
		{
			return (flags & 23068672) != 0;
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060023B4 RID: 9140 RVA: 0x0007FC03 File Offset: 0x0007DE03
		public bool IsCompletedSuccessfully
		{
			get
			{
				return (this.m_stateFlags & 23068672) == 16777216;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Threading.Tasks.TaskCreationOptions" />, используемый для создания данной задачи.</summary>
		/// <returns>Объект <see cref="T:System.Threading.Tasks.TaskCreationOptions" />, используемый для создания данной задачи.</returns>
		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060023B5 RID: 9141 RVA: 0x0007FC1A File Offset: 0x0007DE1A
		public TaskCreationOptions CreationOptions
		{
			get
			{
				return this.Options & (TaskCreationOptions)(-65281);
			}
		}

		/// <summary>Возвращает дескриптор <see cref="T:System.Threading.WaitHandle" />, который можно использовать для ожидания завершения задачи.</summary>
		/// <returns>Дескриптор <see cref="T:System.Threading.WaitHandle" />, который можно использовать для ожидания завершения задачи.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Tasks.Task" /> удален.</exception>
		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x060023B6 RID: 9142 RVA: 0x0007FC28 File Offset: 0x0007DE28
		WaitHandle IAsyncResult.AsyncWaitHandle
		{
			get
			{
				if ((this.m_stateFlags & 262144) != 0)
				{
					throw new ObjectDisposedException(null, "The task has been disposed.");
				}
				return this.CompletedEvent.WaitHandle;
			}
		}

		/// <summary>Возвращает объект состояния, предоставленный при создании задачи <see cref="T:System.Threading.Tasks.Task" />, или значение null, если объект не предоставлен.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий данные о состоянии, переданные задаче на этапе создания.</returns>
		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x060023B7 RID: 9143 RVA: 0x0007FC54 File Offset: 0x0007DE54
		public object AsyncState
		{
			get
			{
				return this.m_stateObject;
			}
		}

		/// <summary>Возвращает значение, указывающее, синхронно ли выполнена операция.</summary>
		/// <returns>Значение <see langword="true" />, если операция завершилась синхронно, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060023B8 RID: 9144 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		bool IAsyncResult.CompletedSynchronously
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060023B9 RID: 9145 RVA: 0x0007FC5C File Offset: 0x0007DE5C
		internal TaskScheduler ExecutingTaskScheduler
		{
			get
			{
				return this.m_taskScheduler;
			}
		}

		/// <summary>Предоставляет доступ к методам фабрики для создания и настройки экземпляров <see cref="T:System.Threading.Tasks.Task" /> и <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <returns>Объект фабрики, который может создавать разнообразные объекты <see cref="T:System.Threading.Tasks.Task" /> и <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060023BA RID: 9146 RVA: 0x0007FC64 File Offset: 0x0007DE64
		public static TaskFactory Factory { get; } = new TaskFactory();

		/// <summary>Возвращает задачу, которая уже завершилась успешно.</summary>
		/// <returns>Успешно завершенная задача.</returns>
		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060023BB RID: 9147 RVA: 0x0007FC6B File Offset: 0x0007DE6B
		public static Task CompletedTask { get; } = new Task(false, (TaskCreationOptions)16384, default(CancellationToken));

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x060023BC RID: 9148 RVA: 0x0007FC74 File Offset: 0x0007DE74
		internal ManualResetEventSlim CompletedEvent
		{
			get
			{
				Task.ContingentProperties contingentProperties = this.EnsureContingentPropertiesInitialized(true);
				if (contingentProperties.m_completionEvent == null)
				{
					bool isCompleted = this.IsCompleted;
					ManualResetEventSlim manualResetEventSlim = new ManualResetEventSlim(isCompleted);
					if (Interlocked.CompareExchange<ManualResetEventSlim>(ref contingentProperties.m_completionEvent, manualResetEventSlim, null) != null)
					{
						manualResetEventSlim.Dispose();
					}
					else if (!isCompleted && this.IsCompleted)
					{
						manualResetEventSlim.Set();
					}
				}
				return contingentProperties.m_completionEvent;
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x060023BD RID: 9149 RVA: 0x0007FCD4 File Offset: 0x0007DED4
		internal bool ExceptionRecorded
		{
			get
			{
				Task.ContingentProperties contingentProperties = this.m_contingentProperties;
				return contingentProperties != null && contingentProperties.m_exceptionsHolder != null && contingentProperties.m_exceptionsHolder.ContainsFaultList;
			}
		}

		/// <summary>Возвращает значение, указывающее, завершилась ли задача <see cref="T:System.Threading.Tasks.Task" /> из-за необработанного исключения.</summary>
		/// <returns>Значение <see langword="true" />, если задача создала необрабатываемое исключение; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060023BE RID: 9150 RVA: 0x0007FD06 File Offset: 0x0007DF06
		public bool IsFaulted
		{
			get
			{
				return (this.m_stateFlags & 2097152) != 0;
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060023BF RID: 9151 RVA: 0x0007FD1C File Offset: 0x0007DF1C
		// (set) Token: 0x060023C0 RID: 9152 RVA: 0x0007FD49 File Offset: 0x0007DF49
		internal ExecutionContext CapturedContext
		{
			get
			{
				Task.ContingentProperties contingentProperties = this.m_contingentProperties;
				if (contingentProperties != null && contingentProperties.m_capturedContext != null)
				{
					return contingentProperties.m_capturedContext;
				}
				return ExecutionContext.Default;
			}
			set
			{
				if (value != ExecutionContext.Default)
				{
					this.EnsureContingentPropertiesInitialized(false).m_capturedContext = value;
				}
			}
		}

		/// <summary>Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <exception cref="T:System.InvalidOperationException">Задача не находится в одном из окончательных состояний: <see cref="F:System.Threading.Tasks.TaskStatus.RanToCompletion" />, <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" /> или <see cref="F:System.Threading.Tasks.TaskStatus.Canceled" />.</exception>
		// Token: 0x060023C1 RID: 9153 RVA: 0x0007FD60 File Offset: 0x0007DF60
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Удаляет задачу<see cref="T:System.Threading.Tasks.Task" />, освобождая все используемые ею неуправляемые ресурсы.</summary>
		/// <param name="disposing">Логическое значение, указывающее, вызывается ли данный метод из-за вызова задачи <see cref="M:System.Threading.Tasks.Task.Dispose" />.</param>
		/// <exception cref="T:System.InvalidOperationException">Задача не находится в одном из окончательных состояний: <see cref="F:System.Threading.Tasks.TaskStatus.RanToCompletion" />, <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" /> или <see cref="F:System.Threading.Tasks.TaskStatus.Canceled" />.</exception>
		// Token: 0x060023C2 RID: 9154 RVA: 0x0007FD70 File Offset: 0x0007DF70
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				if ((this.Options & (TaskCreationOptions)16384) != TaskCreationOptions.None)
				{
					return;
				}
				if (!this.IsCompleted)
				{
					throw new InvalidOperationException("A task may only be disposed if it is in a completion state (RanToCompletion, Faulted or Canceled).");
				}
				Task.ContingentProperties contingentProperties = Volatile.Read<Task.ContingentProperties>(ref this.m_contingentProperties);
				if (contingentProperties != null)
				{
					ManualResetEventSlim completionEvent = contingentProperties.m_completionEvent;
					if (completionEvent != null)
					{
						contingentProperties.m_completionEvent = null;
						if (!completionEvent.IsSet)
						{
							completionEvent.Set();
						}
						completionEvent.Dispose();
					}
				}
			}
			this.m_stateFlags |= 262144;
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x0007FDF0 File Offset: 0x0007DFF0
		internal void ScheduleAndStart(bool needsProtection)
		{
			if (needsProtection)
			{
				if (!this.MarkStarted())
				{
					return;
				}
			}
			else
			{
				this.m_stateFlags |= 65536;
			}
			DebuggerSupport.AddToActiveTasks(this);
			if (DebuggerSupport.LoggingOn && (this.Options & (TaskCreationOptions)512) == TaskCreationOptions.None)
			{
				CausalityTraceLevel traceLevel = CausalityTraceLevel.Required;
				string str = "Task: ";
				Delegate action = this.m_action;
				DebuggerSupport.TraceOperationCreation(traceLevel, this, str + ((action != null) ? action.ToString() : null), 0UL);
			}
			try
			{
				this.m_taskScheduler.QueueTask(this);
			}
			catch (Exception innerException)
			{
				TaskSchedulerException ex = new TaskSchedulerException(innerException);
				this.AddException(ex);
				this.Finish(false);
				if ((this.Options & (TaskCreationOptions)512) == TaskCreationOptions.None)
				{
					this.m_contingentProperties.m_exceptionsHolder.MarkAsHandled(false);
				}
				throw ex;
			}
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x0007FEB8 File Offset: 0x0007E0B8
		internal void AddException(object exceptionObject)
		{
			this.AddException(exceptionObject, false);
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x0007FEC4 File Offset: 0x0007E0C4
		internal void AddException(object exceptionObject, bool representsCancellation)
		{
			Task.ContingentProperties contingentProperties = this.EnsureContingentPropertiesInitialized(true);
			if (contingentProperties.m_exceptionsHolder == null)
			{
				TaskExceptionHolder taskExceptionHolder = new TaskExceptionHolder(this);
				if (Interlocked.CompareExchange<TaskExceptionHolder>(ref contingentProperties.m_exceptionsHolder, taskExceptionHolder, null) != null)
				{
					taskExceptionHolder.MarkAsHandled(false);
				}
			}
			Task.ContingentProperties obj = contingentProperties;
			lock (obj)
			{
				contingentProperties.m_exceptionsHolder.Add(exceptionObject, representsCancellation);
			}
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x0007FF38 File Offset: 0x0007E138
		private AggregateException GetExceptions(bool includeTaskCanceledExceptions)
		{
			Exception ex = null;
			if (includeTaskCanceledExceptions && this.IsCanceled)
			{
				ex = new TaskCanceledException(this);
			}
			if (this.ExceptionRecorded)
			{
				return this.m_contingentProperties.m_exceptionsHolder.CreateExceptionObject(false, ex);
			}
			if (ex != null)
			{
				return new AggregateException(new Exception[]
				{
					ex
				});
			}
			return null;
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x0007FF8C File Offset: 0x0007E18C
		internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos()
		{
			if (!this.IsFaulted || !this.ExceptionRecorded)
			{
				return new ReadOnlyCollection<ExceptionDispatchInfo>(Array.Empty<ExceptionDispatchInfo>());
			}
			return this.m_contingentProperties.m_exceptionsHolder.GetExceptionDispatchInfos();
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x0007FFC0 File Offset: 0x0007E1C0
		internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
		{
			Task.ContingentProperties contingentProperties = this.m_contingentProperties;
			if (contingentProperties == null)
			{
				return null;
			}
			TaskExceptionHolder exceptionsHolder = contingentProperties.m_exceptionsHolder;
			if (exceptionsHolder == null)
			{
				return null;
			}
			return exceptionsHolder.GetCancellationExceptionDispatchInfo();
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x0007FFF0 File Offset: 0x0007E1F0
		internal void ThrowIfExceptional(bool includeTaskCanceledExceptions)
		{
			Exception exceptions = this.GetExceptions(includeTaskCanceledExceptions);
			if (exceptions != null)
			{
				this.UpdateExceptionObservedStatus();
				throw exceptions;
			}
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x00080010 File Offset: 0x0007E210
		internal void UpdateExceptionObservedStatus()
		{
			if (this.m_parent != null && (this.Options & TaskCreationOptions.AttachedToParent) != TaskCreationOptions.None && (this.m_parent.CreationOptions & TaskCreationOptions.DenyChildAttach) == TaskCreationOptions.None && Task.InternalCurrent == this.m_parent)
			{
				this.m_stateFlags |= 524288;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060023CB RID: 9163 RVA: 0x00080061 File Offset: 0x0007E261
		internal bool IsExceptionObservedByParent
		{
			get
			{
				return (this.m_stateFlags & 524288) != 0;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060023CC RID: 9164 RVA: 0x00080074 File Offset: 0x0007E274
		internal bool IsDelegateInvoked
		{
			get
			{
				return (this.m_stateFlags & 131072) != 0;
			}
		}

		// Token: 0x060023CD RID: 9165 RVA: 0x00080088 File Offset: 0x0007E288
		internal void Finish(bool bUserDelegateExecuted)
		{
			if (!bUserDelegateExecuted)
			{
				this.FinishStageTwo();
				return;
			}
			Task.ContingentProperties contingentProperties = this.m_contingentProperties;
			if (contingentProperties == null || contingentProperties.m_completionCountdown == 1 || Interlocked.Decrement(ref contingentProperties.m_completionCountdown) == 0)
			{
				this.FinishStageTwo();
			}
			else
			{
				this.AtomicStateUpdate(8388608, 23068672);
			}
			LowLevelListWithIList<Task> lowLevelListWithIList = (contingentProperties != null) ? contingentProperties.m_exceptionalChildren : null;
			if (lowLevelListWithIList != null)
			{
				LowLevelListWithIList<Task> obj = lowLevelListWithIList;
				lock (obj)
				{
					lowLevelListWithIList.RemoveAll(Task.s_IsExceptionObservedByParentPredicate);
				}
			}
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x00080124 File Offset: 0x0007E324
		internal void FinishStageTwo()
		{
			this.AddExceptionsFromChildren();
			int num;
			if (this.ExceptionRecorded)
			{
				num = 2097152;
				if (DebuggerSupport.LoggingOn)
				{
					DebuggerSupport.TraceOperationCompletion(CausalityTraceLevel.Required, this, AsyncStatus.Error);
				}
				DebuggerSupport.RemoveFromActiveTasks(this);
			}
			else if (this.IsCancellationRequested && this.IsCancellationAcknowledged)
			{
				num = 4194304;
				if (DebuggerSupport.LoggingOn)
				{
					DebuggerSupport.TraceOperationCompletion(CausalityTraceLevel.Required, this, AsyncStatus.Canceled);
				}
				DebuggerSupport.RemoveFromActiveTasks(this);
			}
			else
			{
				num = 16777216;
				if (DebuggerSupport.LoggingOn)
				{
					DebuggerSupport.TraceOperationCompletion(CausalityTraceLevel.Required, this, AsyncStatus.Completed);
				}
				DebuggerSupport.RemoveFromActiveTasks(this);
			}
			Interlocked.Exchange(ref this.m_stateFlags, this.m_stateFlags | num);
			Task.ContingentProperties contingentProperties = this.m_contingentProperties;
			if (contingentProperties != null)
			{
				contingentProperties.SetCompleted();
				contingentProperties.UnregisterCancellationCallback();
			}
			this.FinishStageThree();
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x000801D8 File Offset: 0x0007E3D8
		internal void FinishStageThree()
		{
			this.m_action = null;
			if (this.m_parent != null && (this.m_parent.CreationOptions & TaskCreationOptions.DenyChildAttach) == TaskCreationOptions.None && (this.m_stateFlags & 65535 & 4) != 0)
			{
				this.m_parent.ProcessChildCompletion(this);
			}
			this.FinishContinuations();
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x00080228 File Offset: 0x0007E428
		internal void ProcessChildCompletion(Task childTask)
		{
			Task.ContingentProperties contingentProperties = this.m_contingentProperties;
			if (childTask.IsFaulted && !childTask.IsExceptionObservedByParent)
			{
				if (contingentProperties.m_exceptionalChildren == null)
				{
					Interlocked.CompareExchange<LowLevelListWithIList<Task>>(ref contingentProperties.m_exceptionalChildren, new LowLevelListWithIList<Task>(), null);
				}
				LowLevelListWithIList<Task> exceptionalChildren = contingentProperties.m_exceptionalChildren;
				if (exceptionalChildren != null)
				{
					LowLevelListWithIList<Task> obj = exceptionalChildren;
					lock (obj)
					{
						exceptionalChildren.Add(childTask);
					}
				}
			}
			if (Interlocked.Decrement(ref contingentProperties.m_completionCountdown) == 0)
			{
				this.FinishStageTwo();
			}
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x000802B8 File Offset: 0x0007E4B8
		internal void AddExceptionsFromChildren()
		{
			Task.ContingentProperties contingentProperties = this.m_contingentProperties;
			LowLevelListWithIList<Task> lowLevelListWithIList = (contingentProperties != null) ? contingentProperties.m_exceptionalChildren : null;
			if (lowLevelListWithIList != null)
			{
				LowLevelListWithIList<Task> obj = lowLevelListWithIList;
				lock (obj)
				{
					foreach (Task task in ((IEnumerable<Task>)lowLevelListWithIList))
					{
						if (task.IsFaulted && !task.IsExceptionObservedByParent)
						{
							TaskExceptionHolder exceptionsHolder = task.m_contingentProperties.m_exceptionsHolder;
							this.AddException(exceptionsHolder.CreateExceptionObject(false, null));
						}
					}
				}
				contingentProperties.m_exceptionalChildren = null;
			}
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x00080378 File Offset: 0x0007E578
		private void Execute()
		{
			try
			{
				this.InnerInvoke();
			}
			catch (Exception unhandledException)
			{
				this.HandleException(unhandledException);
			}
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x000803A8 File Offset: 0x0007E5A8
		void IThreadPoolWorkItem.ExecuteWorkItem()
		{
			this.ExecuteEntry(false);
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x000803B4 File Offset: 0x0007E5B4
		internal bool ExecuteEntry(bool bPreventDoubleExecution)
		{
			if (bPreventDoubleExecution)
			{
				int num = 0;
				if (!this.AtomicStateUpdate(131072, 23199744, ref num) && (num & 4194304) == 0)
				{
					return false;
				}
			}
			else
			{
				this.m_stateFlags |= 131072;
			}
			if (!this.IsCancellationRequested && !this.IsCanceled)
			{
				this.ExecuteWithThreadLocal(ref Task.t_currentTask);
			}
			else if (!this.IsCanceled && (Interlocked.Exchange(ref this.m_stateFlags, this.m_stateFlags | 4194304) & 4194304) == 0)
			{
				this.CancellationCleanupLogic();
			}
			return true;
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x00080448 File Offset: 0x0007E648
		private static void ExecutionContextCallback(object obj)
		{
			(obj as Task).Execute();
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x00080458 File Offset: 0x0007E658
		internal virtual void InnerInvoke()
		{
			Action action = this.m_action as Action;
			if (action != null)
			{
				action();
				return;
			}
			Action<object> action2 = this.m_action as Action<object>;
			if (action2 != null)
			{
				action2(this.m_stateObject);
				return;
			}
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x00080498 File Offset: 0x0007E698
		private void HandleException(Exception unhandledException)
		{
			OperationCanceledException ex = unhandledException as OperationCanceledException;
			if (ex != null && this.IsCancellationRequested && this.m_contingentProperties.m_cancellationToken == ex.CancellationToken)
			{
				this.SetCancellationAcknowledged();
				this.AddException(ex, true);
				return;
			}
			this.AddException(unhandledException);
		}

		/// <summary>Возвращает объект типа awaiter, используемый для данного объекта <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <returns>Экземпляр объекта типа awaiter.</returns>
		// Token: 0x060023D8 RID: 9176 RVA: 0x000804E7 File Offset: 0x0007E6E7
		public TaskAwaiter GetAwaiter()
		{
			return new TaskAwaiter(this);
		}

		/// <summary>Настраивает объект типа awaiter, используемый для данного объекта <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <param name="continueOnCapturedContext">Значение <see langword="true" />, чтобы попытаться выполнить маршалинг продолжения обратно в исходный захваченный контекст; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Объект, используемый для ожидания данной задачи.</returns>
		// Token: 0x060023D9 RID: 9177 RVA: 0x000804EF File Offset: 0x0007E6EF
		public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext)
		{
			return new ConfiguredTaskAwaitable(this, continueOnCapturedContext);
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x000804F8 File Offset: 0x0007E6F8
		internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext)
		{
			TaskContinuation taskContinuation = null;
			if (continueOnCapturedContext)
			{
				SynchronizationContext synchronizationContext = SynchronizationContext.Current;
				if (synchronizationContext != null && synchronizationContext.GetType() != typeof(SynchronizationContext))
				{
					taskContinuation = new SynchronizationContextAwaitTaskContinuation(synchronizationContext, continuationAction, flowExecutionContext);
				}
				else
				{
					TaskScheduler internalCurrent = TaskScheduler.InternalCurrent;
					if (internalCurrent != null && internalCurrent != TaskScheduler.Default)
					{
						taskContinuation = new TaskSchedulerAwaitTaskContinuation(internalCurrent, continuationAction, flowExecutionContext);
					}
				}
			}
			if (taskContinuation != null)
			{
				if (!this.AddTaskContinuation(taskContinuation, false))
				{
					taskContinuation.Run(this, false);
					return;
				}
			}
			else if (!this.AddTaskContinuation(continuationAction, false))
			{
				AwaitTaskContinuation.UnsafeScheduleAction(continuationAction);
			}
		}

		/// <summary>Создает поддерживающий ожидание объект задачи, который асинхронным образом выдает возврат текущему контексту, когда его ожидают.</summary>
		/// <returns>Контекст, который при ожидании будет асинхронно переходить назад в текущий контекст во время ожидания. Если текущий <see cref="T:System.Threading.SynchronizationContext" /> отличен от null, он также обрабатывается как текущий контекст. В противном случае планировщик задач, связанный с задачей, выполняющейся в данный момент, рассматривается как текущий контекст.</returns>
		// Token: 0x060023DB RID: 9179 RVA: 0x00080578 File Offset: 0x0007E778
		public static YieldAwaitable Yield()
		{
			return default(YieldAwaitable);
		}

		/// <summary>Ожидает завершения выполнения задачи <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Tasks.Task" /> удален.</exception>
		/// <exception cref="T:System.AggregateException">Задача отменена. Коллекция <see cref="P:System.AggregateException.InnerExceptions" /> содержит объект <see cref="T:System.Threading.Tasks.TaskCanceledException" />.  
		/// -или- 
		/// Во время выполнения задачи возникло исключение. Коллекция <see cref="P:System.AggregateException.InnerExceptions" /> содержит сведения об исключении или исключениях.</exception>
		// Token: 0x060023DC RID: 9180 RVA: 0x00080590 File Offset: 0x0007E790
		public void Wait()
		{
			this.Wait(-1, default(CancellationToken));
		}

		/// <summary>Ожидает завершения выполнения задач <see cref="T:System.Threading.Tasks.Task" /> в течение указанного временного периода.</summary>
		/// <param name="timeout">Период <see cref="T:System.TimeSpan" />, представляющий время ожидания в миллисекундах, или период <see cref="T:System.TimeSpan" />, представляющий -1 миллисекунду для неограниченного ожидания.</param>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Threading.Tasks.Task" /> завершил выполнение в течение отведенного времени; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Tasks.Task" /> удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="timeout" /> является отрицательным числом, отличным от -1 миллисекунды, которое представляет неограниченное время ожидания. 
		/// -или- 
		///  Значение <paramref name="timeout" /> больше значения <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.AggregateException">Задача отменена. Коллекция <see cref="P:System.AggregateException.InnerExceptions" /> содержит объект <see cref="T:System.Threading.Tasks.TaskCanceledException" />.  
		/// -или- 
		/// Во время выполнения задачи возникло исключение. Коллекция <see cref="P:System.AggregateException.InnerExceptions" /> содержит сведения об исключении или исключениях.</exception>
		// Token: 0x060023DD RID: 9181 RVA: 0x000805B0 File Offset: 0x0007E7B0
		public bool Wait(TimeSpan timeout)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (num < -1L || num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("timeout");
			}
			return this.Wait((int)num, default(CancellationToken));
		}

		/// <summary>Ожидает завершения выполнения задачи <see cref="T:System.Threading.Tasks.Task" />. Ожидание завершается, если токен отмены отменяется до завершения задачи.</summary>
		/// <param name="cancellationToken">Токен отмены, который нужно контролировать во время ожидания выполнения задачи.</param>
		/// <exception cref="T:System.OperationCanceledException">Объект <paramref name="cancellationToken" /> отменен.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Задача была удалена.</exception>
		/// <exception cref="T:System.AggregateException">Задача отменена. Коллекция <see cref="P:System.AggregateException.InnerExceptions" /> содержит объект <see cref="T:System.Threading.Tasks.TaskCanceledException" />.  
		/// -или- 
		/// Во время выполнения задачи возникло исключение. Коллекция <see cref="P:System.AggregateException.InnerExceptions" /> содержит сведения об исключении или исключениях.</exception>
		// Token: 0x060023DE RID: 9182 RVA: 0x000805F0 File Offset: 0x0007E7F0
		public void Wait(CancellationToken cancellationToken)
		{
			this.Wait(-1, cancellationToken);
		}

		/// <summary>Ожидает завершения задачи <see cref="T:System.Threading.Tasks.Task" /> в течение указанного числа миллисекунд.</summary>
		/// <param name="millisecondsTimeout">Время ожидания в миллисекундах или функция <see cref="F:System.Threading.Timeout.Infinite" /> (-1) в случае неограниченного времени ожидания.</param>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Threading.Tasks.Task" /> завершил выполнение в течение отведенного времени; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Tasks.Task" /> удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от –1, что означает бесконечное время ожидания.</exception>
		/// <exception cref="T:System.AggregateException">Задача отменена. Коллекция <see cref="P:System.AggregateException.InnerExceptions" /> содержит объект <see cref="T:System.Threading.Tasks.TaskCanceledException" />.  
		/// -или- 
		/// Во время выполнения задачи возникло исключение. Коллекция <see cref="P:System.AggregateException.InnerExceptions" /> содержит сведения об исключении или исключениях.</exception>
		// Token: 0x060023DF RID: 9183 RVA: 0x000805FC File Offset: 0x0007E7FC
		public bool Wait(int millisecondsTimeout)
		{
			return this.Wait(millisecondsTimeout, default(CancellationToken));
		}

		/// <summary>Ожидает завершения выполнения задачи <see cref="T:System.Threading.Tasks.Task" />. Ожидание завершается, если время ожидания истекает или токен отмены отменяется до завершения задачи.</summary>
		/// <param name="millisecondsTimeout">Время ожидания в миллисекундах или функция <see cref="F:System.Threading.Timeout.Infinite" /> (-1) в случае неограниченного времени ожидания.</param>
		/// <param name="cancellationToken">Токен отмены, который нужно контролировать во время ожидания выполнения задачи.</param>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Threading.Tasks.Task" /> завершил выполнение в течение отведенного времени; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.OperationCanceledException">Объект <paramref name="cancellationToken" /> отменен.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Tasks.Task" /> удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от –1, что означает бесконечное время ожидания.</exception>
		/// <exception cref="T:System.AggregateException">Задача отменена. Коллекция <see cref="P:System.AggregateException.InnerExceptions" /> содержит объект <see cref="T:System.Threading.Tasks.TaskCanceledException" />.  
		/// -или- 
		/// Во время выполнения задачи возникло исключение. Коллекция <see cref="P:System.AggregateException.InnerExceptions" /> содержит сведения об исключении или исключениях.</exception>
		// Token: 0x060023E0 RID: 9184 RVA: 0x0008061C File Offset: 0x0007E81C
		public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			if (millisecondsTimeout < -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout");
			}
			if (!this.IsWaitNotificationEnabledOrNotRanToCompletion)
			{
				return true;
			}
			if (!this.InternalWait(millisecondsTimeout, cancellationToken))
			{
				return false;
			}
			if (this.IsWaitNotificationEnabledOrNotRanToCompletion)
			{
				this.NotifyDebuggerOfWaitCompletionIfNecessary();
				if (this.IsCanceled)
				{
					cancellationToken.ThrowIfCancellationRequested();
				}
				this.ThrowIfExceptional(true);
			}
			return true;
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x00080674 File Offset: 0x0007E874
		private bool WrappedTryRunInline()
		{
			if (this.m_taskScheduler == null)
			{
				return false;
			}
			bool result;
			try
			{
				result = this.m_taskScheduler.TryRunInline(this, true);
			}
			catch (Exception innerException)
			{
				throw new TaskSchedulerException(innerException);
			}
			return result;
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x000806B4 File Offset: 0x0007E8B4
		[MethodImpl(MethodImplOptions.NoOptimization)]
		internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			if (TaskTrace.Enabled)
			{
				Task internalCurrent = Task.InternalCurrent;
				TaskTrace.TaskWaitBegin_Synchronous((internalCurrent != null) ? internalCurrent.m_taskScheduler.Id : TaskScheduler.Default.Id, (internalCurrent != null) ? internalCurrent.Id : 0, this.Id);
			}
			bool flag = this.IsCompleted;
			if (!flag)
			{
				flag = ((millisecondsTimeout == -1 && !cancellationToken.CanBeCanceled && this.WrappedTryRunInline() && this.IsCompleted) || this.SpinThenBlockingWait(millisecondsTimeout, cancellationToken));
			}
			if (TaskTrace.Enabled)
			{
				Task internalCurrent2 = Task.InternalCurrent;
				if (internalCurrent2 != null)
				{
					TaskTrace.TaskWaitEnd(internalCurrent2.m_taskScheduler.Id, internalCurrent2.Id, this.Id);
				}
				else
				{
					TaskTrace.TaskWaitEnd(TaskScheduler.Default.Id, 0, this.Id);
				}
			}
			return flag;
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x00080778 File Offset: 0x0007E978
		private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			bool flag = millisecondsTimeout == -1;
			uint num = (uint)(flag ? 0 : Environment.TickCount);
			bool flag2 = this.SpinWait(millisecondsTimeout);
			if (!flag2)
			{
				Task.SetOnInvokeMres setOnInvokeMres = new Task.SetOnInvokeMres();
				try
				{
					this.AddCompletionAction(setOnInvokeMres, true);
					if (flag)
					{
						flag2 = setOnInvokeMres.Wait(-1, cancellationToken);
					}
					else
					{
						uint num2 = (uint)(Environment.TickCount - (int)num);
						if ((ulong)num2 < (ulong)((long)millisecondsTimeout))
						{
							flag2 = setOnInvokeMres.Wait((int)((long)millisecondsTimeout - (long)((ulong)num2)), cancellationToken);
						}
					}
				}
				finally
				{
					if (!this.IsCompleted)
					{
						this.RemoveContinuation(setOnInvokeMres);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060023E4 RID: 9188 RVA: 0x00080800 File Offset: 0x0007EA00
		private bool SpinWait(int millisecondsTimeout)
		{
			if (this.IsCompleted)
			{
				return true;
			}
			if (millisecondsTimeout == 0)
			{
				return false;
			}
			int spinCountforSpinBeforeWait = System.Threading.SpinWait.SpinCountforSpinBeforeWait;
			SpinWait spinWait = default(SpinWait);
			while (spinWait.Count < spinCountforSpinBeforeWait)
			{
				spinWait.SpinOnce(-1);
				if (this.IsCompleted)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x0008084C File Offset: 0x0007EA4C
		internal bool InternalCancel(bool bCancelNonExecutingOnly)
		{
			bool flag = false;
			bool flag2 = false;
			TaskSchedulerException ex = null;
			if ((this.m_stateFlags & 65536) != 0)
			{
				TaskScheduler taskScheduler = this.m_taskScheduler;
				try
				{
					flag = (taskScheduler != null && taskScheduler.TryDequeue(this));
				}
				catch (Exception innerException)
				{
					ex = new TaskSchedulerException(innerException);
				}
				bool flag3 = taskScheduler != null && taskScheduler.RequiresAtomicStartTransition;
				if (!flag && bCancelNonExecutingOnly && flag3)
				{
					flag2 = this.AtomicStateUpdate(4194304, 4325376);
				}
			}
			if (!bCancelNonExecutingOnly || flag || flag2)
			{
				this.RecordInternalCancellationRequest();
				if (flag)
				{
					flag2 = this.AtomicStateUpdate(4194304, 4325376);
				}
				else if (!flag2 && (this.m_stateFlags & 65536) == 0)
				{
					flag2 = this.AtomicStateUpdate(4194304, 23265280);
				}
				if (flag2)
				{
					this.CancellationCleanupLogic();
				}
			}
			if (ex != null)
			{
				throw ex;
			}
			return flag2;
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x00080924 File Offset: 0x0007EB24
		internal void RecordInternalCancellationRequest()
		{
			this.EnsureContingentPropertiesInitialized(true).m_internalCancellationRequested = 1;
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x00080938 File Offset: 0x0007EB38
		internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord)
		{
			this.RecordInternalCancellationRequest();
			if (tokenToRecord != default(CancellationToken))
			{
				this.m_contingentProperties.m_cancellationToken = tokenToRecord;
			}
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x0008096A File Offset: 0x0007EB6A
		internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException)
		{
			this.RecordInternalCancellationRequest(tokenToRecord);
			if (cancellationException != null)
			{
				this.AddException(cancellationException, true);
			}
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x00080980 File Offset: 0x0007EB80
		internal void CancellationCleanupLogic()
		{
			Interlocked.Exchange(ref this.m_stateFlags, this.m_stateFlags | 4194304);
			Task.ContingentProperties contingentProperties = this.m_contingentProperties;
			if (contingentProperties != null)
			{
				contingentProperties.SetCompleted();
				contingentProperties.UnregisterCancellationCallback();
			}
			if (DebuggerSupport.LoggingOn)
			{
				DebuggerSupport.TraceOperationCompletion(CausalityTraceLevel.Required, this, AsyncStatus.Canceled);
			}
			DebuggerSupport.RemoveFromActiveTasks(this);
			this.FinishStageThree();
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x000809DA File Offset: 0x0007EBDA
		private void SetCancellationAcknowledged()
		{
			this.m_stateFlags |= 1048576;
		}

		// Token: 0x060023EB RID: 9195 RVA: 0x000809F4 File Offset: 0x0007EBF4
		internal void FinishContinuations()
		{
			object obj = Interlocked.Exchange(ref this.m_continuationObject, Task.s_taskCompletionSentinel);
			if (obj != null)
			{
				if (DebuggerSupport.LoggingOn)
				{
					DebuggerSupport.TraceSynchronousWorkStart(CausalityTraceLevel.Required, this, CausalitySynchronousWork.CompletionNotification);
				}
				bool flag = (this.m_stateFlags & 134217728) == 0 && (this.m_stateFlags & 64) == 0;
				Action action = obj as Action;
				if (action != null)
				{
					AwaitTaskContinuation.RunOrScheduleAction(action, flag, ref Task.t_currentTask);
					this.LogFinishCompletionNotification();
					return;
				}
				ITaskCompletionAction taskCompletionAction = obj as ITaskCompletionAction;
				if (taskCompletionAction != null)
				{
					if (flag || !taskCompletionAction.InvokeMayRunArbitraryCode)
					{
						taskCompletionAction.Invoke(this);
					}
					else
					{
						ThreadPool.UnsafeQueueCustomWorkItem(new CompletionActionInvoker(taskCompletionAction, this), false);
					}
					this.LogFinishCompletionNotification();
					return;
				}
				TaskContinuation taskContinuation = obj as TaskContinuation;
				if (taskContinuation != null)
				{
					taskContinuation.Run(this, flag);
					this.LogFinishCompletionNotification();
					return;
				}
				LowLevelListWithIList<object> lowLevelListWithIList = obj as LowLevelListWithIList<object>;
				if (lowLevelListWithIList == null)
				{
					this.LogFinishCompletionNotification();
					return;
				}
				LowLevelListWithIList<object> obj2 = lowLevelListWithIList;
				lock (obj2)
				{
				}
				int count = lowLevelListWithIList.Count;
				for (int i = 0; i < count; i++)
				{
					StandardTaskContinuation standardTaskContinuation = lowLevelListWithIList[i] as StandardTaskContinuation;
					if (standardTaskContinuation != null && (standardTaskContinuation.m_options & TaskContinuationOptions.ExecuteSynchronously) == TaskContinuationOptions.None)
					{
						lowLevelListWithIList[i] = null;
						standardTaskContinuation.Run(this, flag);
					}
				}
				for (int j = 0; j < count; j++)
				{
					object obj3 = lowLevelListWithIList[j];
					if (obj3 != null)
					{
						lowLevelListWithIList[j] = null;
						Action action2 = obj3 as Action;
						if (action2 != null)
						{
							AwaitTaskContinuation.RunOrScheduleAction(action2, flag, ref Task.t_currentTask);
						}
						else
						{
							TaskContinuation taskContinuation2 = obj3 as TaskContinuation;
							if (taskContinuation2 != null)
							{
								taskContinuation2.Run(this, flag);
							}
							else
							{
								ITaskCompletionAction taskCompletionAction2 = (ITaskCompletionAction)obj3;
								if (flag || !taskCompletionAction2.InvokeMayRunArbitraryCode)
								{
									taskCompletionAction2.Invoke(this);
								}
								else
								{
									ThreadPool.UnsafeQueueCustomWorkItem(new CompletionActionInvoker(taskCompletionAction2, this), false);
								}
							}
						}
					}
				}
				this.LogFinishCompletionNotification();
			}
		}

		// Token: 0x060023EC RID: 9196 RVA: 0x00080BDC File Offset: 0x0007EDDC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void LogFinishCompletionNotification()
		{
			if (DebuggerSupport.LoggingOn)
			{
				DebuggerSupport.TraceSynchronousWorkCompletion(CausalityTraceLevel.Required, CausalitySynchronousWork.CompletionNotification);
			}
		}

		/// <summary>Создает продолжение, которое выполняется асинхронно после завершения выполнения целевой задачи <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <param name="continuationAction">Действие, которое необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task" />. При запуске делегата завершенная задача будет передана ему в качестве аргумента.</param>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationAction" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060023ED RID: 9197 RVA: 0x00080BEC File Offset: 0x0007EDEC
		public Task ContinueWith(Action<Task> continuationAction)
		{
			return this.ContinueWith(continuationAction, TaskScheduler.Current, default(CancellationToken), TaskContinuationOptions.None);
		}

		/// <summary>Создает продолжение, которое получает токен отмены и выполняется асинхронно после завершения целевой задачи <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <param name="continuationAction">Действие, которое необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task" />. При запуске делегата завершенная задача будет передана ему в качестве аргумента.</param>
		/// <param name="cancellationToken">Токен <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" />, который будет назначен новой задаче продолжения.</param>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Threading.CancellationTokenSource" />, создавший уже освобожденный токен.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationAction" /> имеет значение NULL.</exception>
		// Token: 0x060023EE RID: 9198 RVA: 0x00080C0F File Offset: 0x0007EE0F
		public Task ContinueWith(Action<Task> continuationAction, CancellationToken cancellationToken)
		{
			return this.ContinueWith(continuationAction, TaskScheduler.Current, cancellationToken, TaskContinuationOptions.None);
		}

		/// <summary>Создает продолжение, которое выполняется асинхронно после завершения выполнения целевой задачи <see cref="T:System.Threading.Tasks.Task" />. Продолжение использует указанный планировщик.</summary>
		/// <param name="continuationAction">Действие, которое необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task" />. При запуске делегата завершенная задача будет передана ему в качестве аргумента.</param>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, который следует связать с задачей продолжения и использовать для ее запуска.</param>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Tasks.Task" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationAction" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Аргумент <paramref name="scheduler" /> имеет значение NULL.</exception>
		// Token: 0x060023EF RID: 9199 RVA: 0x00080C20 File Offset: 0x0007EE20
		public Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler)
		{
			return this.ContinueWith(continuationAction, scheduler, default(CancellationToken), TaskContinuationOptions.None);
		}

		/// <summary>Создает продолжение, выполняемое после завершения целевой задачи в соответствии с заданными параметрами <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</summary>
		/// <param name="continuationAction">Действие для запуска в соответствии с заданными параметрами <paramref name="continuationOptions" />. При запуске делегата завершенная задача будет передана ему в качестве аргумента.</param>
		/// <param name="continuationOptions">Параметры, определяющие запланированное время продолжения и его поведение. Включаются критерии, такие как <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, а также параметры выполнения, например <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationAction" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> задает недопустимое значение для <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		// Token: 0x060023F0 RID: 9200 RVA: 0x00080C40 File Offset: 0x0007EE40
		public Task ContinueWith(Action<Task> continuationAction, TaskContinuationOptions continuationOptions)
		{
			return this.ContinueWith(continuationAction, TaskScheduler.Current, default(CancellationToken), continuationOptions);
		}

		/// <summary>Создает продолжение, выполняемое после завершения целевой задачи в соответствии с заданными параметрами <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />. Продолжение получает токен отмены и использует указанный планировщик.</summary>
		/// <param name="continuationAction">Действие для запуска в соответствии с заданными параметрами <paramref name="continuationOptions" />. При запуске делегата завершенная задача будет передана ему в качестве аргумента.</param>
		/// <param name="cancellationToken">Токен <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" />, который будет назначен новой задаче продолжения.</param>
		/// <param name="continuationOptions">Параметры, определяющие запланированное время продолжения и его поведение. Включаются критерии, такие как <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, а также параметры выполнения, например <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, который следует связать с задачей продолжения и использовать для ее запуска.</param>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Threading.CancellationTokenSource" />, создавший уже освобожденный токен.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationAction" /> имеет значение NULL.  
		/// -или- 
		/// Аргумент <paramref name="scheduler" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> задает недопустимое значение для <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		// Token: 0x060023F1 RID: 9201 RVA: 0x00080C63 File Offset: 0x0007EE63
		public Task ContinueWith(Action<Task> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return this.ContinueWith(continuationAction, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x00080C70 File Offset: 0x0007EE70
		private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			if (continuationAction == null)
			{
				throw new ArgumentNullException("continuationAction");
			}
			if (scheduler == null)
			{
				throw new ArgumentNullException("scheduler");
			}
			TaskCreationOptions creationOptions;
			InternalTaskOptions internalOptions;
			Task.CreationOptionsFromContinuationOptions(continuationOptions, out creationOptions, out internalOptions);
			Task task = new ContinuationTaskFromTask(this, continuationAction, null, creationOptions, internalOptions);
			this.ContinueWithCore(task, scheduler, cancellationToken, continuationOptions);
			return task;
		}

		/// <summary>Создает продолжение, которое получает предоставленные вызывающей стороной сведения о состоянии и выполняется после завершения целевой задачи <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <param name="continuationAction">Действие, которое необходимо выполнить после завершения задачи. При запуске делегату передается в качестве аргументов завершенная задача и предоставленный вызывающей стороной объект состояния.</param>
		/// <param name="state">Объект, который представляет данные, используемые действием продолжения.</param>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationAction" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060023F3 RID: 9203 RVA: 0x00080CBC File Offset: 0x0007EEBC
		public Task ContinueWith(Action<Task, object> continuationAction, object state)
		{
			return this.ContinueWith(continuationAction, state, TaskScheduler.Current, default(CancellationToken), TaskContinuationOptions.None);
		}

		/// <summary>Создает продолжение, которое получает предоставленные вызывающей стороной сведения о состоянии и токен отмены и которое выполняется асинхронно после завершения целевой задачи <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <param name="continuationAction">Действие, которое необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task" />. При запуске делегату будут переданы в качестве аргументов завершенная задача и предоставленный вызывающей стороной объект состояния.</param>
		/// <param name="state">Объект, который представляет данные, используемые действием продолжения.</param>
		/// <param name="cancellationToken">Токен <see cref="T:System.Threading.CancellationToken" />, который будет назначен новой задаче продолжения.</param>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationAction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Предоставленный объект <see cref="T:System.Threading.CancellationToken" /> уже удален.</exception>
		// Token: 0x060023F4 RID: 9204 RVA: 0x00080CE0 File Offset: 0x0007EEE0
		public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken)
		{
			return this.ContinueWith(continuationAction, state, TaskScheduler.Current, cancellationToken, TaskContinuationOptions.None);
		}

		/// <summary>Создает продолжение, которое получает предоставленные вызывающей стороной сведения о состоянии и выполняется асинхронно после завершения целевой задачи <see cref="T:System.Threading.Tasks.Task" />. Продолжение использует указанный планировщик.</summary>
		/// <param name="continuationAction">Действие, которое необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task" />.  При запуске делегату будут переданы в качестве аргументов завершенная задача и предоставленный вызывающей стороной объект состояния.</param>
		/// <param name="state">Объект, который представляет данные, используемые действием продолжения.</param>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, который следует связать с задачей продолжения и использовать для ее запуска.</param>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="scheduler" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060023F5 RID: 9205 RVA: 0x00080CF4 File Offset: 0x0007EEF4
		public Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler)
		{
			return this.ContinueWith(continuationAction, state, scheduler, default(CancellationToken), TaskContinuationOptions.None);
		}

		/// <summary>Создает продолжение, которое получает предоставленные вызывающей стороной сведения о состоянии и выполняется после завершения целевой задачи <see cref="T:System.Threading.Tasks.Task" />. Продолжение выполняется на основе набора указанных условий.</summary>
		/// <param name="continuationAction">Действие, которое необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task" />. При запуске делегату будут переданы в качестве аргументов завершенная задача и предоставленный вызывающей стороной объект состояния.</param>
		/// <param name="state">Объект, который представляет данные, используемые действием продолжения.</param>
		/// <param name="continuationOptions">Параметры, определяющие запланированное время продолжения и его поведение. Включаются критерии, такие как <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, а также параметры выполнения, например <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationAction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> задает недопустимое значение для <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		// Token: 0x060023F6 RID: 9206 RVA: 0x00080D14 File Offset: 0x0007EF14
		public Task ContinueWith(Action<Task, object> continuationAction, object state, TaskContinuationOptions continuationOptions)
		{
			return this.ContinueWith(continuationAction, state, TaskScheduler.Current, default(CancellationToken), continuationOptions);
		}

		/// <summary>Создает продолжение, которое получает предоставленные вызывающей стороной сведения о состоянии и токен отмены и которое выполняется после завершения целевой задачи <see cref="T:System.Threading.Tasks.Task" />. Продолжение выполняется на основе набора указанных условий и использует указанный планировщик.</summary>
		/// <param name="continuationAction">Действие, которое необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task" />. При запуске делегату будут переданы в качестве аргументов завершенная задача и предоставленный вызывающей стороной объект состояния.</param>
		/// <param name="state">Объект, который представляет данные, используемые действием продолжения.</param>
		/// <param name="cancellationToken">Токен <see cref="T:System.Threading.CancellationToken" />, который будет назначен новой задаче продолжения.</param>
		/// <param name="continuationOptions">Параметры, определяющие запланированное время продолжения и его поведение. Включаются критерии, такие как <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, а также параметры выполнения, например <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, который следует связать с задачей продолжения и использовать для ее запуска.</param>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="scheduler" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> задает недопустимое значение для <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Предоставленный объект <see cref="T:System.Threading.CancellationToken" /> уже удален.</exception>
		// Token: 0x060023F7 RID: 9207 RVA: 0x00080D38 File Offset: 0x0007EF38
		public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return this.ContinueWith(continuationAction, state, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x00080D48 File Offset: 0x0007EF48
		private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			if (continuationAction == null)
			{
				throw new ArgumentNullException("continuationAction");
			}
			if (scheduler == null)
			{
				throw new ArgumentNullException("scheduler");
			}
			TaskCreationOptions creationOptions;
			InternalTaskOptions internalOptions;
			Task.CreationOptionsFromContinuationOptions(continuationOptions, out creationOptions, out internalOptions);
			Task task = new ContinuationTaskFromTask(this, continuationAction, state, creationOptions, internalOptions);
			this.ContinueWithCore(task, scheduler, cancellationToken, continuationOptions);
			return task;
		}

		/// <summary>Создает продолжение, которое выполняется асинхронно после завершения целевой задачи <see cref="T:System.Threading.Tasks.Task`1" /> и возвращает значение.</summary>
		/// <param name="continuationFunction">Функция, которую необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task`1" />. При запуске делегата завершенная задача будет передана ему в качестве аргумента.</param>
		/// <typeparam name="TResult">Тип результата, созданного продолжением.</typeparam>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Tasks.Task" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationFunction" /> имеет значение NULL.</exception>
		// Token: 0x060023F9 RID: 9209 RVA: 0x00080D94 File Offset: 0x0007EF94
		public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction)
		{
			return this.ContinueWith<TResult>(continuationFunction, TaskScheduler.Current, default(CancellationToken), TaskContinuationOptions.None);
		}

		/// <summary>Создает продолжение, которое выполняется асинхронно после завершения целевой задачи <see cref="T:System.Threading.Tasks.Task" /> и возвращает значение. Продолжение получает токен отмены.</summary>
		/// <param name="continuationFunction">Функция, которую необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task" />. При запуске делегата завершенная задача будет передана ему в качестве аргумента.</param>
		/// <param name="cancellationToken">Токен <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" />, который будет назначен новой задаче продолжения.</param>
		/// <typeparam name="TResult">Тип результата, созданного продолжением.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Tasks.Task" /> удален.  
		/// -или- 
		/// <see cref="T:System.Threading.CancellationTokenSource" />, создавший уже освобожденный токен.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationFunction" /> имеет значение NULL.</exception>
		// Token: 0x060023FA RID: 9210 RVA: 0x00080DB7 File Offset: 0x0007EFB7
		public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction, CancellationToken cancellationToken)
		{
			return this.ContinueWith<TResult>(continuationFunction, TaskScheduler.Current, cancellationToken, TaskContinuationOptions.None);
		}

		/// <summary>Создает продолжение, которое выполняется асинхронно после завершения целевой задачи <see cref="T:System.Threading.Tasks.Task" /> и возвращает значение. Продолжение использует указанный планировщик.</summary>
		/// <param name="continuationFunction">Функция, которую необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task" />. При запуске делегата завершенная задача будет передана ему в качестве аргумента.</param>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, который следует связать с задачей продолжения и использовать для ее запуска.</param>
		/// <typeparam name="TResult">Тип результата, созданного продолжением.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Tasks.Task" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationFunction" /> имеет значение NULL.  
		/// -или- 
		/// Аргумент <paramref name="scheduler" /> имеет значение NULL.</exception>
		// Token: 0x060023FB RID: 9211 RVA: 0x00080DC8 File Offset: 0x0007EFC8
		public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction, TaskScheduler scheduler)
		{
			return this.ContinueWith<TResult>(continuationFunction, scheduler, default(CancellationToken), TaskContinuationOptions.None);
		}

		/// <summary>Создает продолжение, выполняемое в соответствии с заданными параметрами и возвращает значение.</summary>
		/// <param name="continuationFunction">Функция для запуска в соответствии с условием, заданным в <paramref name="continuationOptions" />. При запуске делегата завершенная задача будет передана ему в качестве аргумента.</param>
		/// <param name="continuationOptions">Параметры, определяющие запланированное время продолжения и его поведение. Включаются критерии, такие как <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, а также параметры выполнения, например <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <typeparam name="TResult">Тип результата, созданного продолжением.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Tasks.Task" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationFunction" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> задает недопустимое значение для <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		// Token: 0x060023FC RID: 9212 RVA: 0x00080DE8 File Offset: 0x0007EFE8
		public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			return this.ContinueWith<TResult>(continuationFunction, TaskScheduler.Current, default(CancellationToken), continuationOptions);
		}

		/// <summary>Создает продолжение, выполняемое в соответствии с заданными параметрами и возвращает значение. Продолжение получает токен отмены и использует указанный планировщик.</summary>
		/// <param name="continuationFunction">Функция для запуска в соответствии с заданными параметрами continuationOptions. При запуске делегата завершенная задача будет передана ему в качестве аргумента.</param>
		/// <param name="cancellationToken">Токен <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" />, который будет назначен новой задаче продолжения.</param>
		/// <param name="continuationOptions">Параметры, определяющие запланированное время продолжения и его поведение. Включаются критерии, такие как <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, а также параметры выполнения, например <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, который следует связать с задачей продолжения и использовать для ее запуска.</param>
		/// <typeparam name="TResult">Тип результата, созданного продолжением.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Tasks.Task" /> удален.  
		/// -или- 
		/// <see cref="T:System.Threading.CancellationTokenSource" />, создавший уже освобожденный токен.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationFunction" /> имеет значение NULL.  
		/// -или- 
		/// Аргумент <paramref name="scheduler" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> задает недопустимое значение для <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		// Token: 0x060023FD RID: 9213 RVA: 0x00080E0B File Offset: 0x0007F00B
		public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return this.ContinueWith<TResult>(continuationFunction, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x00080E18 File Offset: 0x0007F018
		private Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			if (scheduler == null)
			{
				throw new ArgumentNullException("scheduler");
			}
			TaskCreationOptions creationOptions;
			InternalTaskOptions internalOptions;
			Task.CreationOptionsFromContinuationOptions(continuationOptions, out creationOptions, out internalOptions);
			Task<TResult> task = new ContinuationResultTaskFromTask<TResult>(this, continuationFunction, null, creationOptions, internalOptions);
			this.ContinueWithCore(task, scheduler, cancellationToken, continuationOptions);
			return task;
		}

		/// <summary>Создает продолжение, которое получает предоставленные вызывающей стороной сведения о состоянии и выполняется асинхронно после завершения целевой задачи <see cref="T:System.Threading.Tasks.Task" />, а также возвращает значение.</summary>
		/// <param name="continuationFunction">Функция, которую необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task" />. При запуске делегату будут переданы в качестве аргументов завершенная задача и предоставленный вызывающей стороной объект состояния.</param>
		/// <param name="state">Объект, который представляет данные, используемые функцией продолжения.</param>
		/// <typeparam name="TResult">Тип результата, созданного продолжением.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationFunction" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060023FF RID: 9215 RVA: 0x00080E64 File Offset: 0x0007F064
		public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state)
		{
			return this.ContinueWith<TResult>(continuationFunction, state, TaskScheduler.Current, default(CancellationToken), TaskContinuationOptions.None);
		}

		/// <summary>Создает продолжение, которое выполняется асинхронно после завершения целевой задачи <see cref="T:System.Threading.Tasks.Task" /> и возвращает значение. Продолжение получает предоставленные вызывающей стороной сведения и токен отмены.</summary>
		/// <param name="continuationFunction">Функция, которую необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task" />. При запуске делегату будут переданы в качестве аргументов завершенная задача и предоставленный вызывающей стороной объект состояния.</param>
		/// <param name="state">Объект, который представляет данные, используемые функцией продолжения.</param>
		/// <param name="cancellationToken">Токен <see cref="T:System.Threading.CancellationToken" />, который будет назначен новой задаче продолжения.</param>
		/// <typeparam name="TResult">Тип результата, созданного продолжением.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationFunction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Предоставленный объект <see cref="T:System.Threading.CancellationToken" /> уже удален.</exception>
		// Token: 0x06002400 RID: 9216 RVA: 0x00080E88 File Offset: 0x0007F088
		public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state, CancellationToken cancellationToken)
		{
			return this.ContinueWith<TResult>(continuationFunction, state, TaskScheduler.Current, cancellationToken, TaskContinuationOptions.None);
		}

		/// <summary>Создает продолжение, которое выполняется асинхронно после завершения выполнения целевой задачи <see cref="T:System.Threading.Tasks.Task" />. Продолжение получает предоставленные вызывающей стороной сведения и использует указанный планировщик.</summary>
		/// <param name="continuationFunction">Функция, которую необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task" />.  При запуске делегату будут переданы в качестве аргументов завершенная задача и предоставленный вызывающей стороной объект состояния.</param>
		/// <param name="state">Объект, который представляет данные, используемые функцией продолжения.</param>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, который следует связать с задачей продолжения и использовать для ее запуска.</param>
		/// <typeparam name="TResult">Тип результата, созданного продолжением.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="scheduler" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002401 RID: 9217 RVA: 0x00080E9C File Offset: 0x0007F09C
		public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state, TaskScheduler scheduler)
		{
			return this.ContinueWith<TResult>(continuationFunction, state, scheduler, default(CancellationToken), TaskContinuationOptions.None);
		}

		/// <summary>Создает продолжение, которое выполняется на основе указанных параметров продолжения токена после завершения целевой задачи <see cref="T:System.Threading.Tasks.Task" />. Продолжение получает предоставленные вызывающей стороной сведения.</summary>
		/// <param name="continuationFunction">Функция, которую необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task" />. При запуске делегату будут переданы в качестве аргументов завершенная задача и предоставленный вызывающей стороной объект состояния.</param>
		/// <param name="state">Объект, который представляет данные, используемые функцией продолжения.</param>
		/// <param name="continuationOptions">Параметры, определяющие запланированное время продолжения и его поведение. Включаются критерии, такие как <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, а также параметры выполнения, например <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <typeparam name="TResult">Тип результата, созданного продолжением.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationFunction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> задает недопустимое значение для <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		// Token: 0x06002402 RID: 9218 RVA: 0x00080EBC File Offset: 0x0007F0BC
		public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state, TaskContinuationOptions continuationOptions)
		{
			return this.ContinueWith<TResult>(continuationFunction, state, TaskScheduler.Current, default(CancellationToken), continuationOptions);
		}

		/// <summary>Создает продолжение, которое выполняется на основе указанных параметров продолжения токена после завершения целевой задачи <see cref="T:System.Threading.Tasks.Task" /> и возвращает значение. Продолжение получает предоставленные вызывающей стороной сведения и токен отмены, а также использует указанный планировщик.</summary>
		/// <param name="continuationFunction">Функция, которую необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task" />. При запуске делегату будут переданы в качестве аргументов завершенная задача и предоставленный вызывающей стороной объект состояния.</param>
		/// <param name="state">Объект, который представляет данные, используемые функцией продолжения.</param>
		/// <param name="cancellationToken">Токен <see cref="T:System.Threading.CancellationToken" />, который будет назначен новой задаче продолжения.</param>
		/// <param name="continuationOptions">Параметры, определяющие запланированное время продолжения и его поведение. Включаются критерии, такие как <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, а также параметры выполнения, например <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, который следует связать с задачей продолжения и использовать для ее запуска.</param>
		/// <typeparam name="TResult">Тип результата, созданного продолжением.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="scheduler" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> задает недопустимое значение для <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Предоставленный объект <see cref="T:System.Threading.CancellationToken" /> уже удален.</exception>
		// Token: 0x06002403 RID: 9219 RVA: 0x00080EE0 File Offset: 0x0007F0E0
		public Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return this.ContinueWith<TResult>(continuationFunction, state, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x00080EF0 File Offset: 0x0007F0F0
		private Task<TResult> ContinueWith<TResult>(Func<Task, object, TResult> continuationFunction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			if (scheduler == null)
			{
				throw new ArgumentNullException("scheduler");
			}
			TaskCreationOptions creationOptions;
			InternalTaskOptions internalOptions;
			Task.CreationOptionsFromContinuationOptions(continuationOptions, out creationOptions, out internalOptions);
			Task<TResult> task = new ContinuationResultTaskFromTask<TResult>(this, continuationFunction, state, creationOptions, internalOptions);
			this.ContinueWithCore(task, scheduler, cancellationToken, continuationOptions);
			return task;
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x00080F3C File Offset: 0x0007F13C
		internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions)
		{
			TaskContinuationOptions taskContinuationOptions = TaskContinuationOptions.NotOnRanToCompletion | TaskContinuationOptions.NotOnFaulted | TaskContinuationOptions.NotOnCanceled;
			TaskContinuationOptions taskContinuationOptions2 = TaskContinuationOptions.PreferFairness | TaskContinuationOptions.LongRunning | TaskContinuationOptions.AttachedToParent | TaskContinuationOptions.DenyChildAttach | TaskContinuationOptions.HideScheduler | TaskContinuationOptions.RunContinuationsAsynchronously;
			TaskContinuationOptions taskContinuationOptions3 = TaskContinuationOptions.LongRunning | TaskContinuationOptions.ExecuteSynchronously;
			if ((continuationOptions & taskContinuationOptions3) == taskContinuationOptions3)
			{
				throw new ArgumentOutOfRangeException("continuationOptions", "The specified TaskContinuationOptions combined LongRunning and ExecuteSynchronously.  Synchronous continuations should not be long running.");
			}
			if ((continuationOptions & ~((taskContinuationOptions2 | taskContinuationOptions | TaskContinuationOptions.LazyCancellation | TaskContinuationOptions.ExecuteSynchronously) != TaskContinuationOptions.None)) != TaskContinuationOptions.None)
			{
				throw new ArgumentOutOfRangeException("continuationOptions");
			}
			if ((continuationOptions & taskContinuationOptions) == taskContinuationOptions)
			{
				throw new ArgumentOutOfRangeException("continuationOptions", "The specified TaskContinuationOptions excluded all continuation kinds.");
			}
			creationOptions = (TaskCreationOptions)(continuationOptions & taskContinuationOptions2);
			internalOptions = InternalTaskOptions.ContinuationTask;
			if ((continuationOptions & TaskContinuationOptions.LazyCancellation) != TaskContinuationOptions.None)
			{
				internalOptions |= InternalTaskOptions.LazyCancellation;
			}
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x00080FBC File Offset: 0x0007F1BC
		internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options)
		{
			TaskContinuation taskContinuation = new StandardTaskContinuation(continuationTask, options, scheduler);
			if (cancellationToken.CanBeCanceled)
			{
				if (this.IsCompleted || cancellationToken.IsCancellationRequested)
				{
					continuationTask.AssignCancellationToken(cancellationToken, null, null);
				}
				else
				{
					continuationTask.AssignCancellationToken(cancellationToken, this, taskContinuation);
				}
			}
			if (!continuationTask.IsCompleted && !this.AddTaskContinuation(taskContinuation, false))
			{
				taskContinuation.Run(this, true);
			}
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x0008101B File Offset: 0x0007F21B
		internal void AddCompletionAction(ITaskCompletionAction action)
		{
			this.AddCompletionAction(action, false);
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x00081025 File Offset: 0x0007F225
		private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers)
		{
			if (!this.AddTaskContinuation(action, addBeforeOthers))
			{
				action.Invoke(this);
			}
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x00081038 File Offset: 0x0007F238
		private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers)
		{
			object continuationObject = this.m_continuationObject;
			if (continuationObject != Task.s_taskCompletionSentinel && !(continuationObject is LowLevelListWithIList<object>))
			{
				Interlocked.CompareExchange(ref this.m_continuationObject, new LowLevelListWithIList<object>
				{
					continuationObject
				}, continuationObject);
			}
			LowLevelListWithIList<object> lowLevelListWithIList = this.m_continuationObject as LowLevelListWithIList<object>;
			if (lowLevelListWithIList != null)
			{
				LowLevelListWithIList<object> obj = lowLevelListWithIList;
				lock (obj)
				{
					if (this.m_continuationObject != Task.s_taskCompletionSentinel)
					{
						if (lowLevelListWithIList.Count == lowLevelListWithIList.Capacity)
						{
							lowLevelListWithIList.RemoveAll(Task.s_IsTaskContinuationNullPredicate);
						}
						if (addBeforeOthers)
						{
							lowLevelListWithIList.Insert(0, tc);
						}
						else
						{
							lowLevelListWithIList.Add(tc);
						}
						return true;
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x000810FC File Offset: 0x0007F2FC
		private bool AddTaskContinuation(object tc, bool addBeforeOthers)
		{
			return !this.IsCompleted && ((this.m_continuationObject == null && Interlocked.CompareExchange(ref this.m_continuationObject, tc, null) == null) || this.AddTaskContinuationComplex(tc, addBeforeOthers));
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x0008112C File Offset: 0x0007F32C
		internal void RemoveContinuation(object continuationObject)
		{
			object continuationObject2 = this.m_continuationObject;
			if (continuationObject2 == Task.s_taskCompletionSentinel)
			{
				return;
			}
			LowLevelListWithIList<object> lowLevelListWithIList = continuationObject2 as LowLevelListWithIList<object>;
			if (lowLevelListWithIList == null)
			{
				if (Interlocked.CompareExchange(ref this.m_continuationObject, new LowLevelListWithIList<object>(), continuationObject) == continuationObject)
				{
					return;
				}
				lowLevelListWithIList = (this.m_continuationObject as LowLevelListWithIList<object>);
			}
			if (lowLevelListWithIList != null)
			{
				LowLevelListWithIList<object> obj = lowLevelListWithIList;
				lock (obj)
				{
					if (this.m_continuationObject != Task.s_taskCompletionSentinel)
					{
						int num = lowLevelListWithIList.IndexOf(continuationObject);
						if (num != -1)
						{
							lowLevelListWithIList[num] = null;
						}
					}
				}
			}
		}

		/// <summary>Ожидает завершения выполнения всех указанных объектов <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <param name="tasks">Массив экземпляров <see cref="T:System.Threading.Tasks.Task" />, завершения выполнения которых следует дождаться.</param>
		/// <exception cref="T:System.ObjectDisposedException">Один или несколько объектов <see cref="T:System.Threading.Tasks.Task" /> в <paramref name="tasks" /> были удалены.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="tasks" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Аргумент <paramref name="tasks" /> содержит элемент NULL.  
		/// -или- 
		/// Аргумент <paramref name="tasks" /> — пустой массив.</exception>
		/// <exception cref="T:System.AggregateException">По крайней мере один из экземпляров <see cref="T:System.Threading.Tasks.Task" /> был удален. Если задача была отменена, <see cref="T:System.AggregateException" /> содержит исключение <see cref="T:System.OperationCanceledException" /> в коллекции <see cref="P:System.AggregateException.InnerExceptions" />.  
		/// -или- 
		/// Возникло исключение во время выполнения по крайней мере одного из экземпляров <see cref="T:System.Threading.Tasks.Task" />.</exception>
		// Token: 0x0600240C RID: 9228 RVA: 0x000811D0 File Offset: 0x0007F3D0
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static void WaitAll(params Task[] tasks)
		{
			Task.WaitAll(tasks, -1);
		}

		/// <summary>Ожидает завершения выполнения всех указанных отменяемых объектов <see cref="T:System.Threading.Tasks.Task" /> в течение указанного временного интервала.</summary>
		/// <param name="tasks">Массив экземпляров <see cref="T:System.Threading.Tasks.Task" />, завершения выполнения которых следует дождаться.</param>
		/// <param name="timeout">Период <see cref="T:System.TimeSpan" />, представляющий время ожидания в миллисекундах, или период <see cref="T:System.TimeSpan" />, представляющий -1 миллисекунду для неограниченного ожидания.</param>
		/// <returns>
		///   <see langword="true" />, если все экземпляры <see cref="T:System.Threading.Tasks.Task" /> завершили выполнение в выделенное время; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один или несколько объектов <see cref="T:System.Threading.Tasks.Task" /> в <paramref name="tasks" /> были удалены.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="tasks" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.AggregateException">По крайней мере один из экземпляров <see cref="T:System.Threading.Tasks.Task" /> был удален. Если задача была отменена, <see cref="T:System.AggregateException" /> содержит <see cref="T:System.OperationCanceledException" /> в коллекции <see cref="P:System.AggregateException.InnerExceptions" />.  
		/// -или- 
		/// Возникло исключение во время выполнения по крайней мере одного из экземпляров <see cref="T:System.Threading.Tasks.Task" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="timeout" /> является отрицательным числом, отличным от -1 миллисекунды, которое представляет неограниченное время ожидания. 
		/// -или- 
		///  Значение <paramref name="timeout" /> больше значения <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.ArgumentException">Аргумент <paramref name="tasks" /> содержит элемент NULL.  
		/// -или- 
		/// Аргумент <paramref name="tasks" /> — пустой массив.</exception>
		// Token: 0x0600240D RID: 9229 RVA: 0x000811DC File Offset: 0x0007F3DC
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static bool WaitAll(Task[] tasks, TimeSpan timeout)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (num < -1L || num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("timeout");
			}
			return Task.WaitAll(tasks, (int)num);
		}

		/// <summary>Ожидает завершения выполнения всех указанных объектов <see cref="T:System.Threading.Tasks.Task" /> в течение указанного числа миллисекунд.</summary>
		/// <param name="tasks">Массив экземпляров <see cref="T:System.Threading.Tasks.Task" />, завершения выполнения которых следует дождаться.</param>
		/// <param name="millisecondsTimeout">Время ожидания в миллисекундах или функция <see cref="F:System.Threading.Timeout.Infinite" /> (-1) в случае неограниченного времени ожидания.</param>
		/// <returns>
		///   <see langword="true" />, если все экземпляры <see cref="T:System.Threading.Tasks.Task" /> завершили выполнение в выделенное время; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один или несколько объектов <see cref="T:System.Threading.Tasks.Task" /> в <paramref name="tasks" /> были удалены.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="tasks" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.AggregateException">По крайней мере один из экземпляров <see cref="T:System.Threading.Tasks.Task" /> был удален. Если задача была отменена, <see cref="T:System.AggregateException" /> содержит <see cref="T:System.OperationCanceledException" /> в коллекции <see cref="P:System.AggregateException.InnerExceptions" />.  
		/// -или- 
		/// Возникло исключение во время выполнения по крайней мере одного из экземпляров <see cref="T:System.Threading.Tasks.Task" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от –1, что означает бесконечное время ожидания.</exception>
		/// <exception cref="T:System.ArgumentException">Аргумент <paramref name="tasks" /> содержит элемент NULL.  
		/// -или- 
		/// Аргумент <paramref name="tasks" /> — пустой массив.</exception>
		// Token: 0x0600240E RID: 9230 RVA: 0x00081214 File Offset: 0x0007F414
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static bool WaitAll(Task[] tasks, int millisecondsTimeout)
		{
			return Task.WaitAll(tasks, millisecondsTimeout, default(CancellationToken));
		}

		/// <summary>Ожидает завершения выполнения всех указанных объектов <see cref="T:System.Threading.Tasks.Task" />, пока ожидание не будет отменено.</summary>
		/// <param name="tasks">Массив экземпляров <see cref="T:System.Threading.Tasks.Task" />, завершения выполнения которых следует дождаться.</param>
		/// <param name="cancellationToken">Токен <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" />, который нужно контролировать во время ожидания выполнения задач.</param>
		/// <exception cref="T:System.OperationCanceledException">Объект <paramref name="cancellationToken" /> отменен.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="tasks" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.AggregateException">По крайней мере один из экземпляров <see cref="T:System.Threading.Tasks.Task" /> был удален. Если задача была отменена, <see cref="T:System.AggregateException" /> содержит <see cref="T:System.OperationCanceledException" /> в коллекции <see cref="P:System.AggregateException.InnerExceptions" />.  
		/// -или- 
		/// Возникло исключение во время выполнения по крайней мере одного из экземпляров <see cref="T:System.Threading.Tasks.Task" />.</exception>
		/// <exception cref="T:System.ArgumentException">Аргумент <paramref name="tasks" /> содержит элемент NULL.  
		/// -или- 
		/// Аргумент <paramref name="tasks" /> — пустой массив.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Один или несколько объектов <see cref="T:System.Threading.Tasks.Task" /> в <paramref name="tasks" /> были удалены.</exception>
		// Token: 0x0600240F RID: 9231 RVA: 0x00081231 File Offset: 0x0007F431
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static void WaitAll(Task[] tasks, CancellationToken cancellationToken)
		{
			Task.WaitAll(tasks, -1, cancellationToken);
		}

		/// <summary>Ожидает завершения выполнения всех указанных объектов <see cref="T:System.Threading.Tasks.Task" /> в течение указанного числа миллисекунд или до отмены ожидания.</summary>
		/// <param name="tasks">Массив экземпляров <see cref="T:System.Threading.Tasks.Task" />, завершения выполнения которых следует дождаться.</param>
		/// <param name="millisecondsTimeout">Время ожидания в миллисекундах или функция <see cref="F:System.Threading.Timeout.Infinite" /> (-1) в случае неограниченного времени ожидания.</param>
		/// <param name="cancellationToken">Токен <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" />, который нужно контролировать во время ожидания выполнения задач.</param>
		/// <returns>
		///   <see langword="true" />, если все экземпляры <see cref="T:System.Threading.Tasks.Task" /> завершили выполнение в выделенное время; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один или несколько объектов <see cref="T:System.Threading.Tasks.Task" /> в <paramref name="tasks" /> были удалены.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="tasks" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.AggregateException">По крайней мере один из экземпляров <see cref="T:System.Threading.Tasks.Task" /> был удален. Если задача была отменена, <see cref="T:System.AggregateException" /> содержит <see cref="T:System.OperationCanceledException" /> в коллекции <see cref="P:System.AggregateException.InnerExceptions" />.  
		/// -или- 
		/// Возникло исключение во время выполнения по крайней мере одного из экземпляров <see cref="T:System.Threading.Tasks.Task" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от –1, что означает бесконечное время ожидания.</exception>
		/// <exception cref="T:System.ArgumentException">Аргумент <paramref name="tasks" /> содержит элемент NULL.  
		/// -или- 
		/// Аргумент <paramref name="tasks" /> — пустой массив.</exception>
		/// <exception cref="T:System.OperationCanceledException">Объект <paramref name="cancellationToken" /> отменен.</exception>
		// Token: 0x06002410 RID: 9232 RVA: 0x0008123C File Offset: 0x0007F43C
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static bool WaitAll(Task[] tasks, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			if (tasks == null)
			{
				throw new ArgumentNullException("tasks");
			}
			if (millisecondsTimeout < -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout");
			}
			cancellationToken.ThrowIfCancellationRequested();
			LowLevelListWithIList<Exception> innerExceptions = null;
			LowLevelListWithIList<Task> lowLevelListWithIList = null;
			LowLevelListWithIList<Task> lowLevelListWithIList2 = null;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = true;
			for (int i = tasks.Length - 1; i >= 0; i--)
			{
				Task task = tasks[i];
				if (task == null)
				{
					throw new ArgumentException("The tasks array included at least one null element.", "tasks");
				}
				bool flag4 = task.IsCompleted;
				if (!flag4)
				{
					if (millisecondsTimeout != -1 || cancellationToken.CanBeCanceled)
					{
						Task.AddToList<Task>(task, ref lowLevelListWithIList, tasks.Length);
					}
					else
					{
						flag4 = (task.WrappedTryRunInline() && task.IsCompleted);
						if (!flag4)
						{
							Task.AddToList<Task>(task, ref lowLevelListWithIList, tasks.Length);
						}
					}
				}
				if (flag4)
				{
					if (task.IsFaulted)
					{
						flag = true;
					}
					else if (task.IsCanceled)
					{
						flag2 = true;
					}
					if (task.IsWaitNotificationEnabled)
					{
						Task.AddToList<Task>(task, ref lowLevelListWithIList2, 1);
					}
				}
			}
			if (lowLevelListWithIList != null)
			{
				flag3 = Task.WaitAllBlockingCore(lowLevelListWithIList, millisecondsTimeout, cancellationToken);
				if (flag3)
				{
					foreach (Task task2 in ((IEnumerable<Task>)lowLevelListWithIList))
					{
						if (task2.IsFaulted)
						{
							flag = true;
						}
						else if (task2.IsCanceled)
						{
							flag2 = true;
						}
						if (task2.IsWaitNotificationEnabled)
						{
							Task.AddToList<Task>(task2, ref lowLevelListWithIList2, 1);
						}
					}
				}
				GC.KeepAlive(tasks);
			}
			if (flag3 && lowLevelListWithIList2 != null)
			{
				using (IEnumerator<Task> enumerator = ((IEnumerable<Task>)lowLevelListWithIList2).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.NotifyDebuggerOfWaitCompletionIfNecessary())
						{
							break;
						}
					}
				}
			}
			if (flag3 && (flag || flag2))
			{
				if (!flag)
				{
					cancellationToken.ThrowIfCancellationRequested();
				}
				foreach (Task t in tasks)
				{
					Task.AddExceptionsForCompletedTask(ref innerExceptions, t);
				}
				throw new AggregateException(innerExceptions);
			}
			return flag3;
		}

		// Token: 0x06002411 RID: 9233 RVA: 0x00081430 File Offset: 0x0007F630
		private static void AddToList<T>(T item, ref LowLevelListWithIList<T> list, int initSize)
		{
			if (list == null)
			{
				list = new LowLevelListWithIList<T>(initSize);
			}
			list.Add(item);
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x00081448 File Offset: 0x0007F648
		private static bool WaitAllBlockingCore(LowLevelListWithIList<Task> tasks, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			bool flag = false;
			Task.SetOnCountdownMres setOnCountdownMres = new Task.SetOnCountdownMres(tasks.Count);
			try
			{
				foreach (Task task in ((IEnumerable<Task>)tasks))
				{
					task.AddCompletionAction(setOnCountdownMres, true);
				}
				flag = setOnCountdownMres.Wait(millisecondsTimeout, cancellationToken);
			}
			finally
			{
				if (!flag)
				{
					foreach (Task task2 in ((IEnumerable<Task>)tasks))
					{
						if (!task2.IsCompleted)
						{
							task2.RemoveContinuation(setOnCountdownMres);
						}
					}
				}
			}
			return flag;
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x000814F8 File Offset: 0x0007F6F8
		internal static void AddExceptionsForCompletedTask(ref LowLevelListWithIList<Exception> exceptions, Task t)
		{
			AggregateException exceptions2 = t.GetExceptions(true);
			if (exceptions2 != null)
			{
				t.UpdateExceptionObservedStatus();
				if (exceptions == null)
				{
					exceptions = new LowLevelListWithIList<Exception>(exceptions2.InnerExceptions.Count);
				}
				exceptions.AddRange(exceptions2.InnerExceptions);
			}
		}

		/// <summary>Ожидает завершения выполнения любого из указанных объектов <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <param name="tasks">Массив экземпляров <see cref="T:System.Threading.Tasks.Task" />, завершения выполнения которых следует дождаться.</param>
		/// <returns>Индекс завершенного объекта <see cref="T:System.Threading.Tasks.Task" /> в массиве <paramref name="tasks" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Tasks.Task" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="tasks" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Аргумент <paramref name="tasks" /> содержит элемент NULL.</exception>
		// Token: 0x06002414 RID: 9236 RVA: 0x00081539 File Offset: 0x0007F739
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static int WaitAny(params Task[] tasks)
		{
			return Task.WaitAny(tasks, -1);
		}

		/// <summary>Ожидает завершения выполнения любого из указанных отменяемых объектов <see cref="T:System.Threading.Tasks.Task" /> в течение указанного временного интервала.</summary>
		/// <param name="tasks">Массив экземпляров <see cref="T:System.Threading.Tasks.Task" />, завершения выполнения которых следует дождаться.</param>
		/// <param name="timeout">Период <see cref="T:System.TimeSpan" />, представляющий время ожидания в миллисекундах, или период <see cref="T:System.TimeSpan" />, представляющий -1 миллисекунду для неограниченного ожидания.</param>
		/// <returns>Индекс завершенной задачи в аргументе-массиве <paramref name="tasks" /> или -1, если истекло время ожидания.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Tasks.Task" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="tasks" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="timeout" /> является отрицательным числом, отличным от -1 миллисекунды, которое означает бесконечное время ожидания. 
		/// -или- 
		///  Значение <paramref name="timeout" /> больше значения <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.ArgumentException">Аргумент <paramref name="tasks" /> содержит элемент NULL.</exception>
		// Token: 0x06002415 RID: 9237 RVA: 0x00081544 File Offset: 0x0007F744
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static int WaitAny(Task[] tasks, TimeSpan timeout)
		{
			long num = (long)timeout.TotalMilliseconds;
			if (num < -1L || num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("timeout");
			}
			return Task.WaitAny(tasks, (int)num);
		}

		/// <summary>Ожидает завершения выполнения всех указанных объектов <see cref="T:System.Threading.Tasks.Task" />, пока ожидание не будет отменено.</summary>
		/// <param name="tasks">Массив экземпляров <see cref="T:System.Threading.Tasks.Task" />, завершения выполнения которых следует дождаться.</param>
		/// <param name="cancellationToken">Токен <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" />, который нужно контролировать во время ожидания выполнения задачи.</param>
		/// <returns>Индекс завершенной задачи в аргументе-массиве <paramref name="tasks" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Tasks.Task" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="tasks" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Аргумент <paramref name="tasks" /> содержит элемент NULL.</exception>
		/// <exception cref="T:System.OperationCanceledException">Объект <paramref name="cancellationToken" /> отменен.</exception>
		// Token: 0x06002416 RID: 9238 RVA: 0x0008157B File Offset: 0x0007F77B
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static int WaitAny(Task[] tasks, CancellationToken cancellationToken)
		{
			return Task.WaitAny(tasks, -1, cancellationToken);
		}

		/// <summary>Ожидает завершения выполнения любого из указанных объектов <see cref="T:System.Threading.Tasks.Task" /> в течение указанного числа миллисекунд.</summary>
		/// <param name="tasks">Массив экземпляров <see cref="T:System.Threading.Tasks.Task" />, завершения выполнения которых следует дождаться.</param>
		/// <param name="millisecondsTimeout">Время ожидания в миллисекундах или функция <see cref="F:System.Threading.Timeout.Infinite" /> (-1) в случае неограниченного времени ожидания.</param>
		/// <returns>Индекс завершенной задачи в аргументе-массиве <paramref name="tasks" /> или -1, если истекло время ожидания.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Tasks.Task" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="tasks" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от –1, что означает бесконечное время ожидания.</exception>
		/// <exception cref="T:System.ArgumentException">Аргумент <paramref name="tasks" /> содержит элемент NULL.</exception>
		// Token: 0x06002417 RID: 9239 RVA: 0x00081588 File Offset: 0x0007F788
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static int WaitAny(Task[] tasks, int millisecondsTimeout)
		{
			return Task.WaitAny(tasks, millisecondsTimeout, default(CancellationToken));
		}

		/// <summary>Ожидает завершения выполнения всех указанных объектов <see cref="T:System.Threading.Tasks.Task" /> в течение указанного числа миллисекунд или до отмены токена отмены.</summary>
		/// <param name="tasks">Массив экземпляров <see cref="T:System.Threading.Tasks.Task" />, завершения выполнения которых следует дождаться.</param>
		/// <param name="millisecondsTimeout">Время ожидания в миллисекундах или функция <see cref="F:System.Threading.Timeout.Infinite" /> (-1) в случае неограниченного времени ожидания.</param>
		/// <param name="cancellationToken">Токен <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" />, который нужно контролировать во время ожидания выполнения задачи.</param>
		/// <returns>Индекс завершенной задачи в аргументе-массиве <paramref name="tasks" /> или -1, если истекло время ожидания.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Tasks.Task" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="tasks" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от –1, что означает бесконечное время ожидания.</exception>
		/// <exception cref="T:System.ArgumentException">Аргумент <paramref name="tasks" /> содержит элемент NULL.</exception>
		/// <exception cref="T:System.OperationCanceledException">Объект <paramref name="cancellationToken" /> отменен.</exception>
		// Token: 0x06002418 RID: 9240 RVA: 0x000815A8 File Offset: 0x0007F7A8
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static int WaitAny(Task[] tasks, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			if (tasks == null)
			{
				throw new ArgumentNullException("tasks");
			}
			if (millisecondsTimeout < -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout");
			}
			cancellationToken.ThrowIfCancellationRequested();
			int num = -1;
			for (int i = 0; i < tasks.Length; i++)
			{
				Task task = tasks[i];
				if (task == null)
				{
					throw new ArgumentException("The tasks array included at least one null element.", "tasks");
				}
				if (num == -1 && task.IsCompleted)
				{
					num = i;
				}
			}
			if (num == -1 && tasks.Length != 0)
			{
				Task<Task> task2 = TaskFactory.CommonCWAnyLogic(tasks);
				if (task2.Wait(millisecondsTimeout, cancellationToken))
				{
					num = Array.IndexOf<Task>(tasks, task2.Result);
				}
			}
			GC.KeepAlive(tasks);
			return num;
		}

		/// <summary>Создает задачу <see cref="T:System.Threading.Tasks.Task`1" />, которая завершается удачно с указанным результатом.</summary>
		/// <param name="result">Результат, сохраняемый в завершенную задачу.</param>
		/// <typeparam name="TResult">Тип результата, возвращенного задачей.</typeparam>
		/// <returns>Успешно завершенная задача.</returns>
		// Token: 0x06002419 RID: 9241 RVA: 0x0008163B File Offset: 0x0007F83B
		public static Task<TResult> FromResult<TResult>(TResult result)
		{
			return new Task<TResult>(result);
		}

		/// <summary>Создает задачу <see cref="T:System.Threading.Tasks.Task" />, которая завершилась с указанным исключением.</summary>
		/// <param name="exception">Исключение, с которым завершается задача.</param>
		/// <returns>Задача, завершившаяся сбоем.</returns>
		// Token: 0x0600241A RID: 9242 RVA: 0x00081643 File Offset: 0x0007F843
		public static Task FromException(Exception exception)
		{
			return Task.FromException<VoidTaskResult>(exception);
		}

		/// <summary>Создает задачу <see cref="T:System.Threading.Tasks.Task`1" />, которая завершилась с указанным исключением.</summary>
		/// <param name="exception">Исключение, с которым завершается задача.</param>
		/// <typeparam name="TResult">Тип результата, возвращенного задачей.</typeparam>
		/// <returns>Задача, завершившаяся сбоем.</returns>
		// Token: 0x0600241B RID: 9243 RVA: 0x0008164B File Offset: 0x0007F84B
		public static Task<TResult> FromException<TResult>(Exception exception)
		{
			if (exception == null)
			{
				throw new ArgumentNullException("exception");
			}
			Task<TResult> task = new Task<TResult>();
			task.TrySetException(exception);
			return task;
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x00081668 File Offset: 0x0007F868
		internal static Task FromCancellation(CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				throw new ArgumentOutOfRangeException("cancellationToken");
			}
			return new Task(true, TaskCreationOptions.None, cancellationToken);
		}

		/// <summary>Создает задачу <see cref="T:System.Threading.Tasks.Task" />, которая завершилась из-за отмены с помощью указанного маркера отмены.</summary>
		/// <param name="cancellationToken">Маркер отмены, с которым завершается задача.</param>
		/// <returns>Отменяемая задача.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Не запрошена отмена для параметра <paramref name="cancellationToken" />; его свойство <see cref="P:System.Threading.CancellationToken.IsCancellationRequested" /> имеет значение <see langword="false" />.</exception>
		// Token: 0x0600241D RID: 9245 RVA: 0x00081686 File Offset: 0x0007F886
		public static Task FromCanceled(CancellationToken cancellationToken)
		{
			return Task.FromCancellation(cancellationToken);
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x00081690 File Offset: 0x0007F890
		internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				throw new ArgumentOutOfRangeException("cancellationToken");
			}
			return new Task<TResult>(true, default(TResult), TaskCreationOptions.None, cancellationToken);
		}

		/// <summary>Создает задачу <see cref="T:System.Threading.Tasks.Task`1" />, которая завершилась из-за отмены с помощью указанного маркера отмены.</summary>
		/// <param name="cancellationToken">Маркер отмены, с которым завершается задача.</param>
		/// <typeparam name="TResult">Тип результата, возвращенного задачей.</typeparam>
		/// <returns>Отменяемая задача.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Не запрошена отмена для параметра <paramref name="cancellationToken" />; его свойство <see cref="P:System.Threading.CancellationToken.IsCancellationRequested" /> имеет значение <see langword="false" />.</exception>
		// Token: 0x0600241F RID: 9247 RVA: 0x000816C2 File Offset: 0x0007F8C2
		public static Task<TResult> FromCanceled<TResult>(CancellationToken cancellationToken)
		{
			return Task.FromCancellation<TResult>(cancellationToken);
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x000816CA File Offset: 0x0007F8CA
		internal static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception)
		{
			if (exception == null)
			{
				throw new ArgumentNullException("exception");
			}
			Task<TResult> task = new Task<TResult>();
			task.TrySetCanceled(exception.CancellationToken, exception);
			return task;
		}

		/// <summary>Ставит в очередь заданную работу для запуска в пуле потоков и возвращает объект <see cref="T:System.Threading.Tasks.Task" />, представляющий эту работу.</summary>
		/// <param name="action">Работа для асинхронного выполнения</param>
		/// <returns>Задача, которая представляет работу в очереди на выполнение в ThreadPool.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="action" /> имел значение <see langword="null" />.</exception>
		// Token: 0x06002421 RID: 9249 RVA: 0x000816F0 File Offset: 0x0007F8F0
		public static Task Run(Action action)
		{
			return Task.InternalStartNew(null, action, null, default(CancellationToken), TaskScheduler.Default, TaskCreationOptions.DenyChildAttach, InternalTaskOptions.None);
		}

		/// <summary>Ставит в очередь заданную работу для запуска в пуле потоков и возвращает объект <see cref="T:System.Threading.Tasks.Task" />, представляющий эту работу. Токен отмены позволяет отменить работу.</summary>
		/// <param name="action">Работа для асинхронного выполнения</param>
		/// <param name="cancellationToken">Токен отмены, который может использоваться для отмены работы.</param>
		/// <returns>Задача, которая представляет работу в очереди на выполнение в пуле потоков.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="action" /> имел значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">Задача была отменена.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.CancellationTokenSource" />, связанный с <paramref name="cancellationToken" />, был удален.</exception>
		// Token: 0x06002422 RID: 9250 RVA: 0x00081715 File Offset: 0x0007F915
		public static Task Run(Action action, CancellationToken cancellationToken)
		{
			return Task.InternalStartNew(null, action, null, cancellationToken, TaskScheduler.Default, TaskCreationOptions.DenyChildAttach, InternalTaskOptions.None);
		}

		/// <summary>Ставит в очередь заданную работу для запуска в пуле потоков и возвращает объект <see cref="T:System.Threading.Tasks.Task`1" />, представляющий эту работу.</summary>
		/// <param name="function">Работа для асинхронного выполнения.</param>
		/// <typeparam name="TResult">Тип возвращаемого значения задачи.</typeparam>
		/// <returns>Объект задачи, представляющий работу в очереди на выполнение в пуле потоков.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="function" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002423 RID: 9251 RVA: 0x00081728 File Offset: 0x0007F928
		public static Task<TResult> Run<TResult>(Func<TResult> function)
		{
			return Task<TResult>.StartNew(null, function, default(CancellationToken), TaskCreationOptions.DenyChildAttach, InternalTaskOptions.None, TaskScheduler.Default);
		}

		/// <summary>Ставит в очередь заданную работу для запуска в пуле потоков и возвращает объект <see langword="Task(TResult)" />, представляющий эту работу. Токен отмены позволяет отменить работу.</summary>
		/// <param name="function">Работа для асинхронного выполнения</param>
		/// <param name="cancellationToken">Токен отмены, который должен использоваться для отмены работы</param>
		/// <typeparam name="TResult">Тип результата задачи.</typeparam>
		/// <returns>Задача <see langword="Task(TResult)" />, которая представляет работу в очереди на выполнение в пуле потоков.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="function" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">Задача была отменена.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.CancellationTokenSource" />, связанный с <paramref name="cancellationToken" />, был удален.</exception>
		// Token: 0x06002424 RID: 9252 RVA: 0x0008174C File Offset: 0x0007F94C
		public static Task<TResult> Run<TResult>(Func<TResult> function, CancellationToken cancellationToken)
		{
			return Task<TResult>.StartNew(null, function, cancellationToken, TaskCreationOptions.DenyChildAttach, InternalTaskOptions.None, TaskScheduler.Default);
		}

		/// <summary>Ставит в очередь указанную работу для запуска в пуле потоков и возвращает прокси для задачи, возвращаемой функцией <paramref name="function" />.</summary>
		/// <param name="function">Работа для асинхронного выполнения</param>
		/// <returns>Задача, которая представляет прокси для задачи, возвращаемой <paramref name="function" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="function" /> имел значение <see langword="null" />.</exception>
		// Token: 0x06002425 RID: 9253 RVA: 0x00081760 File Offset: 0x0007F960
		public static Task Run(Func<Task> function)
		{
			return Task.Run(function, default(CancellationToken));
		}

		/// <summary>Ставит в очередь указанную работу для запуска в пуле потоков и возвращает прокси для задачи, возвращаемой функцией <paramref name="function" />.</summary>
		/// <param name="function">Работа для асинхронного выполнения.</param>
		/// <param name="cancellationToken">Токен отмены, который должен использоваться для отмены работы.</param>
		/// <returns>Задача, которая представляет прокси для задачи, возвращаемой <paramref name="function" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="function" /> имел значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">Задача была отменена.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.CancellationTokenSource" />, связанный с <paramref name="cancellationToken" />, был удален.</exception>
		// Token: 0x06002426 RID: 9254 RVA: 0x0008177C File Offset: 0x0007F97C
		public static Task Run(Func<Task> function, CancellationToken cancellationToken)
		{
			if (function == null)
			{
				throw new ArgumentNullException("function");
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCancellation(cancellationToken);
			}
			return new UnwrapPromise<VoidTaskResult>(Task.Factory.StartNew<Task>(function, cancellationToken, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default), true);
		}

		/// <summary>Ставит в очередь заданную работу для запуска в пуле потоков и возвращает прокси для задачи <see langword="Task(TResult)" />, возвращаемой <paramref name="function" />.</summary>
		/// <param name="function">Работа для асинхронного выполнения</param>
		/// <typeparam name="TResult">Тип результата, возвращенного задачей прокси-сервера.</typeparam>
		/// <returns>Объект <see langword="Task(TResult)" />, представляющий прокси для объекта <see langword="Task(TResult)" />, возвращаемого <paramref name="function" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="function" /> имел значение <see langword="null" />.</exception>
		// Token: 0x06002427 RID: 9255 RVA: 0x000817B4 File Offset: 0x0007F9B4
		public static Task<TResult> Run<TResult>(Func<Task<TResult>> function)
		{
			return Task.Run<TResult>(function, default(CancellationToken));
		}

		/// <summary>Ставит в очередь заданную работу для запуска в пуле потоков и возвращает прокси для задачи <see langword="Task(TResult)" />, возвращаемой <paramref name="function" />.</summary>
		/// <param name="function">Работа для асинхронного выполнения</param>
		/// <param name="cancellationToken">Токен отмены, который должен использоваться для отмены работы</param>
		/// <typeparam name="TResult">Тип результата, возвращенного задачей прокси-сервера.</typeparam>
		/// <returns>Объект <see langword="Task(TResult)" />, представляющий прокси для объекта <see langword="Task(TResult)" />, возвращаемого <paramref name="function" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="function" /> имел значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">Задача была отменена.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.CancellationTokenSource" />, связанный с <paramref name="cancellationToken" />, был удален.</exception>
		// Token: 0x06002428 RID: 9256 RVA: 0x000817D0 File Offset: 0x0007F9D0
		public static Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken)
		{
			if (function == null)
			{
				throw new ArgumentNullException("function");
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCancellation<TResult>(cancellationToken);
			}
			return new UnwrapPromise<TResult>(Task.Factory.StartNew<Task<TResult>>(function, cancellationToken, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default), true);
		}

		/// <summary>Создает задачу, которая завершается через заданное время.</summary>
		/// <param name="delay">Интервал времени, в течение которого ожидается завершение возвращаемой задачи, или <see langword="TimeSpan.FromMilliseconds(-1)" /> для неограниченного времени ожидания.</param>
		/// <returns>Задача, представляющая временную задержку.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="delay" /> представляет отрицательный интервал времени, отличный от <see langword="TimeSpan.FromMillseconds(-1)" />.  
		/// -или- 
		/// Свойство <see cref="P:System.TimeSpan.TotalMilliseconds" /> аргумента <paramref name="delay" /> больше, чем <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x06002429 RID: 9257 RVA: 0x00081808 File Offset: 0x0007FA08
		public static Task Delay(TimeSpan delay)
		{
			return Task.Delay(delay, default(CancellationToken));
		}

		/// <summary>Создает отменяемую задачу, которая завершается через заданное время.</summary>
		/// <param name="delay">Интервал времени, в течение которого ожидается завершение возвращаемой задачи, или <see langword="TimeSpan.FromMilliseconds(-1)" /> для неограниченного времени ожидания.</param>
		/// <param name="cancellationToken">Токен отмены, который нужно контролировать во время ожидания выполнения задачи.</param>
		/// <returns>Задача, представляющая временную задержку.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="delay" /> представляет отрицательный интервал времени, отличный от <see langword="TimeSpan.FromMillseconds(-1)" />.  
		/// -или- 
		/// Свойство <see cref="P:System.TimeSpan.TotalMilliseconds" /> аргумента <paramref name="delay" /> больше, чем <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">Задача была отменена.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Предоставленный объект <paramref name="cancellationToken" /> уже удален.</exception>
		// Token: 0x0600242A RID: 9258 RVA: 0x00081824 File Offset: 0x0007FA24
		public static Task Delay(TimeSpan delay, CancellationToken cancellationToken)
		{
			long num = (long)delay.TotalMilliseconds;
			if (num < -1L || num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("delay", "The value needs to translate in milliseconds to -1 (signifying an infinite timeout), 0 or a positive integer less than or equal to Int32.MaxValue.");
			}
			return Task.Delay((int)num, cancellationToken);
		}

		/// <summary>Создает задачу, которая завершается через заданное количество миллисекунд.</summary>
		/// <param name="millisecondsDelay">Число миллисекунд, в течение которого ожидается завершение возвращаемой задачи, или -1 для неограниченного времени ожидания.</param>
		/// <returns>Задача, представляющая временную задержку.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="millisecondsDelay" /> меньше –1.</exception>
		// Token: 0x0600242B RID: 9259 RVA: 0x00081860 File Offset: 0x0007FA60
		public static Task Delay(int millisecondsDelay)
		{
			return Task.Delay(millisecondsDelay, default(CancellationToken));
		}

		/// <summary>Создает отменяемую задачу, которая завершается через заданное количество миллисекунд.</summary>
		/// <param name="millisecondsDelay">Число миллисекунд, в течение которого ожидается завершение возвращаемой задачи, или -1 для неограниченного времени ожидания.</param>
		/// <param name="cancellationToken">Токен отмены, который нужно контролировать во время ожидания выполнения задачи.</param>
		/// <returns>Задача, представляющая временную задержку.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="millisecondsDelay" /> меньше –1.</exception>
		/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">Задача была отменена.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Предоставленный объект <paramref name="cancellationToken" /> уже удален.</exception>
		// Token: 0x0600242C RID: 9260 RVA: 0x0008187C File Offset: 0x0007FA7C
		public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken)
		{
			if (millisecondsDelay < -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsDelay", "The value needs to be either -1 (signifying an infinite timeout), 0 or a positive integer.");
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCancellation(cancellationToken);
			}
			if (millisecondsDelay == 0)
			{
				return Task.CompletedTask;
			}
			Task.DelayPromise delayPromise = new Task.DelayPromise(cancellationToken);
			if (cancellationToken.CanBeCanceled)
			{
				delayPromise.Registration = cancellationToken.InternalRegisterWithoutEC(delegate(object state)
				{
					((Task.DelayPromise)state).Complete();
				}, delayPromise);
			}
			if (millisecondsDelay != -1)
			{
				delayPromise.Timer = new Timer(delegate(object state)
				{
					((Task.DelayPromise)state).Complete();
				}, delayPromise, millisecondsDelay, -1);
				delayPromise.Timer.KeepRootedWhileScheduled();
			}
			return delayPromise;
		}

		/// <summary>Создает задачу, которая будет выполнена, когда все <see cref="T:System.Threading.Tasks.Task" /> объекты в перечислимой коллекции будут завершены.</summary>
		/// <param name="tasks">Задачи, завершение которых требуется подождать.</param>
		/// <returns>Задача, представляющая завершение всех предоставленных задач.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="tasks" /> имел значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Коллекция <paramref name="tasks" />содержала задачу <see langword="null" />.</exception>
		// Token: 0x0600242D RID: 9261 RVA: 0x00081930 File Offset: 0x0007FB30
		public static Task WhenAll(IEnumerable<Task> tasks)
		{
			Task[] array = tasks as Task[];
			if (array != null)
			{
				return Task.WhenAll(array);
			}
			ICollection<Task> collection = tasks as ICollection<Task>;
			if (collection != null)
			{
				int num = 0;
				array = new Task[collection.Count];
				foreach (Task task in tasks)
				{
					if (task == null)
					{
						throw new ArgumentException("The tasks argument included a null value.", "tasks");
					}
					array[num++] = task;
				}
				return Task.InternalWhenAll(array);
			}
			if (tasks == null)
			{
				throw new ArgumentNullException("tasks");
			}
			LowLevelListWithIList<Task> lowLevelListWithIList = new LowLevelListWithIList<Task>();
			foreach (Task task2 in tasks)
			{
				if (task2 == null)
				{
					throw new ArgumentException("The tasks argument included a null value.", "tasks");
				}
				lowLevelListWithIList.Add(task2);
			}
			return Task.InternalWhenAll(lowLevelListWithIList.ToArray());
		}

		/// <summary>Создает задачу, которая будет выполнена, когда все <see cref="T:System.Threading.Tasks.Task" /> объекты в массиве будут завершены.</summary>
		/// <param name="tasks">Задачи, завершение которых требуется подождать.</param>
		/// <returns>Задача, представляющая завершение всех предоставленных задач.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="tasks" /> имел значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> содержал задачу <see langword="null" />.</exception>
		// Token: 0x0600242E RID: 9262 RVA: 0x00081A38 File Offset: 0x0007FC38
		public static Task WhenAll(params Task[] tasks)
		{
			if (tasks == null)
			{
				throw new ArgumentNullException("tasks");
			}
			int num = tasks.Length;
			if (num == 0)
			{
				return Task.InternalWhenAll(tasks);
			}
			Task[] array = new Task[num];
			for (int i = 0; i < num; i++)
			{
				Task task = tasks[i];
				if (task == null)
				{
					throw new ArgumentException("The tasks argument included a null value.", "tasks");
				}
				array[i] = task;
			}
			return Task.InternalWhenAll(array);
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x00081A95 File Offset: 0x0007FC95
		private static Task InternalWhenAll(Task[] tasks)
		{
			if (tasks.Length != 0)
			{
				return new Task.WhenAllPromise(tasks);
			}
			return Task.CompletedTask;
		}

		/// <summary>Создает задачу, которая будет выполнена, когда все <see cref="T:System.Threading.Tasks.Task`1" /> объекты в перечислимой коллекции будут завершены.</summary>
		/// <param name="tasks">Задачи, завершение которых требуется подождать.</param>
		/// <typeparam name="TResult">Тип завершенной задачи.</typeparam>
		/// <returns>Задача, представляющая завершение всех предоставленных задач.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="tasks" /> имел значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Коллекция <paramref name="tasks" />содержала задачу <see langword="null" />.</exception>
		// Token: 0x06002430 RID: 9264 RVA: 0x00081AA8 File Offset: 0x0007FCA8
		public static Task<TResult[]> WhenAll<TResult>(IEnumerable<Task<TResult>> tasks)
		{
			Task<TResult>[] array = tasks as Task<TResult>[];
			if (array != null)
			{
				return Task.WhenAll<TResult>(array);
			}
			ICollection<Task<TResult>> collection = tasks as ICollection<Task<TResult>>;
			if (collection != null)
			{
				int num = 0;
				array = new Task<TResult>[collection.Count];
				foreach (Task<TResult> task in tasks)
				{
					if (task == null)
					{
						throw new ArgumentException("The tasks argument included a null value.", "tasks");
					}
					array[num++] = task;
				}
				return Task.InternalWhenAll<TResult>(array);
			}
			if (tasks == null)
			{
				throw new ArgumentNullException("tasks");
			}
			LowLevelListWithIList<Task<TResult>> lowLevelListWithIList = new LowLevelListWithIList<Task<TResult>>();
			foreach (Task<TResult> task2 in tasks)
			{
				if (task2 == null)
				{
					throw new ArgumentException("The tasks argument included a null value.", "tasks");
				}
				lowLevelListWithIList.Add(task2);
			}
			return Task.InternalWhenAll<TResult>(lowLevelListWithIList.ToArray());
		}

		/// <summary>Создает задачу, которая будет выполнена, когда все <see cref="T:System.Threading.Tasks.Task`1" /> объекты в массиве будут завершены.</summary>
		/// <param name="tasks">Задачи, завершение которых требуется подождать.</param>
		/// <typeparam name="TResult">Тип завершенной задачи.</typeparam>
		/// <returns>Задача, представляющая завершение всех предоставленных задач.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="tasks" /> имел значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> содержал задачу <see langword="null" />.</exception>
		// Token: 0x06002431 RID: 9265 RVA: 0x00081BB0 File Offset: 0x0007FDB0
		public static Task<TResult[]> WhenAll<TResult>(params Task<TResult>[] tasks)
		{
			if (tasks == null)
			{
				throw new ArgumentNullException("tasks");
			}
			int num = tasks.Length;
			if (num == 0)
			{
				return Task.InternalWhenAll<TResult>(tasks);
			}
			Task<TResult>[] array = new Task<TResult>[num];
			for (int i = 0; i < num; i++)
			{
				Task<TResult> task = tasks[i];
				if (task == null)
				{
					throw new ArgumentException("The tasks argument included a null value.", "tasks");
				}
				array[i] = task;
			}
			return Task.InternalWhenAll<TResult>(array);
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x00081C10 File Offset: 0x0007FE10
		private static Task<TResult[]> InternalWhenAll<TResult>(Task<TResult>[] tasks)
		{
			if (tasks.Length != 0)
			{
				return new Task.WhenAllPromise<TResult>(tasks);
			}
			return new Task<TResult[]>(false, Array.Empty<TResult>(), TaskCreationOptions.None, default(CancellationToken));
		}

		/// <summary>Создает задачу, которая будет выполнена после выполнения любой из предоставленных задач.</summary>
		/// <param name="tasks">Задачи, завершение которых требуется подождать.</param>
		/// <returns>Задача, представляющая завершение одной из предоставленных задач.  Результат возвращенной задачи — задача, которая была завершена.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="tasks" /> имел значение NULL.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> содержал задачу со значением NULL или был пустым.</exception>
		// Token: 0x06002433 RID: 9267 RVA: 0x00081C40 File Offset: 0x0007FE40
		public static Task<Task> WhenAny(params Task[] tasks)
		{
			if (tasks == null)
			{
				throw new ArgumentNullException("tasks");
			}
			if (tasks.Length == 0)
			{
				throw new ArgumentException("The tasks argument contains no tasks.", "tasks");
			}
			int num = tasks.Length;
			Task[] array = new Task[num];
			for (int i = 0; i < num; i++)
			{
				Task task = tasks[i];
				if (task == null)
				{
					throw new ArgumentException("The tasks argument included a null value.", "tasks");
				}
				array[i] = task;
			}
			return TaskFactory.CommonCWAnyLogic(array);
		}

		/// <summary>Создает задачу, которая будет выполнена после выполнения любой из предоставленных задач.</summary>
		/// <param name="tasks">Задачи, завершение которых требуется подождать.</param>
		/// <returns>Задача, представляющая завершение одной из предоставленных задач.  Результат возвращенной задачи — задача, которая была завершена.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="tasks" /> имел значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> содержал задачу со значением NULL или был пустым.</exception>
		// Token: 0x06002434 RID: 9268 RVA: 0x00081CA8 File Offset: 0x0007FEA8
		public static Task<Task> WhenAny(IEnumerable<Task> tasks)
		{
			if (tasks == null)
			{
				throw new ArgumentNullException("tasks");
			}
			LowLevelListWithIList<Task> lowLevelListWithIList = new LowLevelListWithIList<Task>();
			foreach (Task task in tasks)
			{
				if (task == null)
				{
					throw new ArgumentException("The tasks argument included a null value.", "tasks");
				}
				lowLevelListWithIList.Add(task);
			}
			if (lowLevelListWithIList.Count == 0)
			{
				throw new ArgumentException("The tasks argument contains no tasks.", "tasks");
			}
			return TaskFactory.CommonCWAnyLogic(lowLevelListWithIList);
		}

		/// <summary>Создает задачу, которая будет выполнена после выполнения любой из предоставленных задач.</summary>
		/// <param name="tasks">Задачи, завершение которых требуется подождать.</param>
		/// <typeparam name="TResult">Тип завершенной задачи.</typeparam>
		/// <returns>Задача, представляющая завершение одной из предоставленных задач.  Результат возвращенной задачи — задача, которая была завершена.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="tasks" /> имел значение NULL.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> содержал задачу со значением NULL или был пустым.</exception>
		// Token: 0x06002435 RID: 9269 RVA: 0x00081D38 File Offset: 0x0007FF38
		public static Task<Task<TResult>> WhenAny<TResult>(params Task<TResult>[] tasks)
		{
			return Task.WhenAny(tasks).ContinueWith<Task<TResult>>(Task<TResult>.TaskWhenAnyCast.Value, default(CancellationToken), TaskContinuationOptions.DenyChildAttach | TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
		}

		/// <summary>Создает задачу, которая будет выполнена после выполнения любой из предоставленных задач.</summary>
		/// <param name="tasks">Задачи, завершение которых требуется подождать.</param>
		/// <typeparam name="TResult">Тип завершенной задачи.</typeparam>
		/// <returns>Задача, представляющая завершение одной из предоставленных задач.  Результат возвращенной задачи — задача, которая была завершена.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="tasks" /> имел значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> содержал задачу со значением NULL или был пустым.</exception>
		// Token: 0x06002436 RID: 9270 RVA: 0x00081D6C File Offset: 0x0007FF6C
		public static Task<Task<TResult>> WhenAny<TResult>(IEnumerable<Task<TResult>> tasks)
		{
			return Task.WhenAny(tasks).ContinueWith<Task<TResult>>(Task<TResult>.TaskWhenAnyCast.Value, default(CancellationToken), TaskContinuationOptions.DenyChildAttach | TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x00081D9C File Offset: 0x0007FF9C
		public static Task<TResult> CreateUnwrapPromise<TResult>(Task outerTask, bool lookForOce)
		{
			return new UnwrapPromise<TResult>(outerTask, lookForOce);
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x00081DA5 File Offset: 0x0007FFA5
		internal virtual Delegate[] GetDelegateContinuationsForDebugger()
		{
			return Task.GetDelegatesFromContinuationObject(this.m_continuationObject);
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x00081DB4 File Offset: 0x0007FFB4
		private static Delegate[] GetDelegatesFromContinuationObject(object continuationObject)
		{
			if (continuationObject != null)
			{
				Action action = continuationObject as Action;
				if (action != null)
				{
					return new Delegate[]
					{
						AsyncMethodBuilderCore.TryGetStateMachineForDebugger(action)
					};
				}
				TaskContinuation taskContinuation = continuationObject as TaskContinuation;
				if (taskContinuation != null)
				{
					return taskContinuation.GetDelegateContinuationsForDebugger();
				}
				Task task = continuationObject as Task;
				if (task != null)
				{
					return task.GetDelegateContinuationsForDebugger();
				}
				ITaskCompletionAction taskCompletionAction = continuationObject as ITaskCompletionAction;
				if (taskCompletionAction != null)
				{
					return new Delegate[]
					{
						new Action<Task>(taskCompletionAction.Invoke)
					};
				}
				LowLevelListWithIList<object> lowLevelListWithIList = continuationObject as LowLevelListWithIList<object>;
				if (lowLevelListWithIList != null)
				{
					LowLevelListWithIList<Delegate> lowLevelListWithIList2 = new LowLevelListWithIList<Delegate>();
					foreach (object continuationObject2 in ((IEnumerable<object>)lowLevelListWithIList))
					{
						Delegate[] delegatesFromContinuationObject = Task.GetDelegatesFromContinuationObject(continuationObject2);
						if (delegatesFromContinuationObject != null)
						{
							foreach (Delegate @delegate in delegatesFromContinuationObject)
							{
								if (@delegate != null)
								{
									lowLevelListWithIList2.Add(@delegate);
								}
							}
						}
					}
					return lowLevelListWithIList2.ToArray();
				}
			}
			return null;
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x00081EB0 File Offset: 0x000800B0
		private static Task GetActiveTaskFromId(int taskId)
		{
			return DebuggerSupport.GetActiveTaskFromId(taskId);
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x00081EB8 File Offset: 0x000800B8
		[FriendAccessAllowed]
		internal static bool AddToActiveTasks(Task task)
		{
			object obj = Task.s_activeTasksLock;
			lock (obj)
			{
				Task.s_currentActiveTasks[task.Id] = task;
			}
			return true;
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x00081F04 File Offset: 0x00080104
		[FriendAccessAllowed]
		internal static void RemoveFromActiveTasks(int taskId)
		{
			object obj = Task.s_activeTasksLock;
			lock (obj)
			{
				Task.s_currentActiveTasks.Remove(taskId);
			}
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public void MarkAborted(ThreadAbortException e)
		{
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x00081F4C File Offset: 0x0008014C
		[SecurityCritical]
		private void ExecuteWithThreadLocal(ref Task currentTaskSlot)
		{
			Task task = currentTaskSlot;
			try
			{
				currentTaskSlot = this;
				ExecutionContext capturedContext = this.CapturedContext;
				if (capturedContext == null)
				{
					this.Execute();
				}
				else
				{
					ContextCallback contextCallback = Task.s_ecCallback;
					if (contextCallback == null)
					{
						contextCallback = (Task.s_ecCallback = new ContextCallback(Task.ExecutionContextCallback));
					}
					ExecutionContext.Run(capturedContext, contextCallback, this, true);
				}
				if (AsyncCausalityTracer.LoggingOn)
				{
					AsyncCausalityTracer.TraceSynchronousWorkCompletion(CausalityTraceLevel.Required, CausalitySynchronousWork.Execution);
				}
				this.Finish(true);
			}
			finally
			{
				currentTaskSlot = task;
			}
		}

		// Token: 0x04001CC9 RID: 7369
		internal static int s_taskIdCounter;

		// Token: 0x04001CCA RID: 7370
		private volatile int m_taskId;

		// Token: 0x04001CCB RID: 7371
		internal Delegate m_action;

		// Token: 0x04001CCC RID: 7372
		internal object m_stateObject;

		// Token: 0x04001CCD RID: 7373
		internal TaskScheduler m_taskScheduler;

		// Token: 0x04001CCE RID: 7374
		internal readonly Task m_parent;

		// Token: 0x04001CCF RID: 7375
		internal volatile int m_stateFlags;

		// Token: 0x04001CD0 RID: 7376
		private const int OptionsMask = 65535;

		// Token: 0x04001CD1 RID: 7377
		internal const int TASK_STATE_STARTED = 65536;

		// Token: 0x04001CD2 RID: 7378
		internal const int TASK_STATE_DELEGATE_INVOKED = 131072;

		// Token: 0x04001CD3 RID: 7379
		internal const int TASK_STATE_DISPOSED = 262144;

		// Token: 0x04001CD4 RID: 7380
		internal const int TASK_STATE_EXCEPTIONOBSERVEDBYPARENT = 524288;

		// Token: 0x04001CD5 RID: 7381
		internal const int TASK_STATE_CANCELLATIONACKNOWLEDGED = 1048576;

		// Token: 0x04001CD6 RID: 7382
		internal const int TASK_STATE_FAULTED = 2097152;

		// Token: 0x04001CD7 RID: 7383
		internal const int TASK_STATE_CANCELED = 4194304;

		// Token: 0x04001CD8 RID: 7384
		internal const int TASK_STATE_WAITING_ON_CHILDREN = 8388608;

		// Token: 0x04001CD9 RID: 7385
		internal const int TASK_STATE_RAN_TO_COMPLETION = 16777216;

		// Token: 0x04001CDA RID: 7386
		internal const int TASK_STATE_WAITINGFORACTIVATION = 33554432;

		// Token: 0x04001CDB RID: 7387
		internal const int TASK_STATE_COMPLETION_RESERVED = 67108864;

		// Token: 0x04001CDC RID: 7388
		internal const int TASK_STATE_THREAD_WAS_ABORTED = 134217728;

		// Token: 0x04001CDD RID: 7389
		internal const int TASK_STATE_WAIT_COMPLETION_NOTIFICATION = 268435456;

		// Token: 0x04001CDE RID: 7390
		private const int TASK_STATE_COMPLETED_MASK = 23068672;

		// Token: 0x04001CDF RID: 7391
		private const int CANCELLATION_REQUESTED = 1;

		// Token: 0x04001CE0 RID: 7392
		private volatile object m_continuationObject;

		// Token: 0x04001CE1 RID: 7393
		private static readonly object s_taskCompletionSentinel = new object();

		// Token: 0x04001CE2 RID: 7394
		internal static bool s_asyncDebuggingEnabled;

		// Token: 0x04001CE3 RID: 7395
		internal volatile Task.ContingentProperties m_contingentProperties;

		// Token: 0x04001CE4 RID: 7396
		private static readonly Action<object> s_taskCancelCallback = new Action<object>(Task.TaskCancelCallback);

		// Token: 0x04001CE5 RID: 7397
		[ThreadStatic]
		internal static Task t_currentTask;

		// Token: 0x04001CE6 RID: 7398
		[ThreadStatic]
		private static StackGuard t_stackGuard;

		// Token: 0x04001CE7 RID: 7399
		private static readonly Func<Task.ContingentProperties> s_createContingentProperties = () => new Task.ContingentProperties();

		// Token: 0x04001CEA RID: 7402
		private static readonly Predicate<Task> s_IsExceptionObservedByParentPredicate = (Task t) => t.IsExceptionObservedByParent;

		// Token: 0x04001CEB RID: 7403
		private static ContextCallback s_ecCallback;

		// Token: 0x04001CEC RID: 7404
		private static readonly Predicate<object> s_IsTaskContinuationNullPredicate = (object tc) => tc == null;

		// Token: 0x04001CED RID: 7405
		private static readonly Dictionary<int, Task> s_currentActiveTasks = new Dictionary<int, Task>();

		// Token: 0x04001CEE RID: 7406
		private static readonly object s_activeTasksLock = new object();

		// Token: 0x02000358 RID: 856
		internal class ContingentProperties
		{
			// Token: 0x06002440 RID: 9280 RVA: 0x00082064 File Offset: 0x00080264
			internal void SetCompleted()
			{
				ManualResetEventSlim completionEvent = this.m_completionEvent;
				if (completionEvent != null)
				{
					completionEvent.Set();
				}
			}

			// Token: 0x06002441 RID: 9281 RVA: 0x00082084 File Offset: 0x00080284
			internal void UnregisterCancellationCallback()
			{
				if (this.m_cancellationRegistration != null)
				{
					try
					{
						((CancellationTokenRegistration)this.m_cancellationRegistration).Dispose();
					}
					catch (ObjectDisposedException)
					{
					}
					this.m_cancellationRegistration = null;
				}
			}

			// Token: 0x04001CEF RID: 7407
			internal ExecutionContext m_capturedContext;

			// Token: 0x04001CF0 RID: 7408
			internal volatile ManualResetEventSlim m_completionEvent;

			// Token: 0x04001CF1 RID: 7409
			internal volatile TaskExceptionHolder m_exceptionsHolder;

			// Token: 0x04001CF2 RID: 7410
			internal CancellationToken m_cancellationToken;

			// Token: 0x04001CF3 RID: 7411
			internal object m_cancellationRegistration;

			// Token: 0x04001CF4 RID: 7412
			internal volatile int m_internalCancellationRequested;

			// Token: 0x04001CF5 RID: 7413
			internal volatile int m_completionCountdown = 1;

			// Token: 0x04001CF6 RID: 7414
			internal volatile LowLevelListWithIList<Task> m_exceptionalChildren;
		}

		// Token: 0x02000359 RID: 857
		private sealed class SetOnInvokeMres : ManualResetEventSlim, ITaskCompletionAction
		{
			// Token: 0x06002443 RID: 9283 RVA: 0x000820D9 File Offset: 0x000802D9
			internal SetOnInvokeMres() : base(false, 0)
			{
			}

			// Token: 0x06002444 RID: 9284 RVA: 0x000820E3 File Offset: 0x000802E3
			public void Invoke(Task completingTask)
			{
				base.Set();
			}

			// Token: 0x1700045E RID: 1118
			// (get) Token: 0x06002445 RID: 9285 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
			public bool InvokeMayRunArbitraryCode
			{
				get
				{
					return false;
				}
			}
		}

		// Token: 0x0200035A RID: 858
		private sealed class SetOnCountdownMres : ManualResetEventSlim, ITaskCompletionAction
		{
			// Token: 0x06002446 RID: 9286 RVA: 0x000820EB File Offset: 0x000802EB
			internal SetOnCountdownMres(int count)
			{
				this._count = count;
			}

			// Token: 0x06002447 RID: 9287 RVA: 0x000820FA File Offset: 0x000802FA
			public void Invoke(Task completingTask)
			{
				if (Interlocked.Decrement(ref this._count) == 0)
				{
					base.Set();
				}
			}

			// Token: 0x1700045F RID: 1119
			// (get) Token: 0x06002448 RID: 9288 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
			public bool InvokeMayRunArbitraryCode
			{
				get
				{
					return false;
				}
			}

			// Token: 0x04001CF7 RID: 7415
			private int _count;
		}

		// Token: 0x0200035B RID: 859
		private sealed class DelayPromise : Task<VoidTaskResult>
		{
			// Token: 0x06002449 RID: 9289 RVA: 0x0008210F File Offset: 0x0008030F
			internal DelayPromise(CancellationToken token)
			{
				this.Token = token;
				if (DebuggerSupport.LoggingOn)
				{
					DebuggerSupport.TraceOperationCreation(CausalityTraceLevel.Required, this, "Task.Delay", 0UL);
				}
				DebuggerSupport.AddToActiveTasks(this);
			}

			// Token: 0x0600244A RID: 9290 RVA: 0x0008213C File Offset: 0x0008033C
			internal void Complete()
			{
				bool flag;
				if (this.Token.IsCancellationRequested)
				{
					flag = base.TrySetCanceled(this.Token);
				}
				else
				{
					if (DebuggerSupport.LoggingOn)
					{
						DebuggerSupport.TraceOperationCompletion(CausalityTraceLevel.Required, this, AsyncStatus.Completed);
					}
					DebuggerSupport.RemoveFromActiveTasks(this);
					flag = base.TrySetResult(default(VoidTaskResult));
				}
				if (flag)
				{
					if (this.Timer != null)
					{
						this.Timer.Dispose();
					}
					this.Registration.Dispose();
				}
			}

			// Token: 0x04001CF8 RID: 7416
			internal readonly CancellationToken Token;

			// Token: 0x04001CF9 RID: 7417
			internal CancellationTokenRegistration Registration;

			// Token: 0x04001CFA RID: 7418
			internal Timer Timer;
		}

		// Token: 0x0200035C RID: 860
		private sealed class WhenAllPromise : Task<VoidTaskResult>, ITaskCompletionAction
		{
			// Token: 0x0600244B RID: 9291 RVA: 0x000821AC File Offset: 0x000803AC
			internal WhenAllPromise(Task[] tasks)
			{
				if (DebuggerSupport.LoggingOn)
				{
					DebuggerSupport.TraceOperationCreation(CausalityTraceLevel.Required, this, "Task.WhenAll", 0UL);
				}
				DebuggerSupport.AddToActiveTasks(this);
				this.m_tasks = tasks;
				this.m_count = tasks.Length;
				foreach (Task task in tasks)
				{
					if (task.IsCompleted)
					{
						this.Invoke(task);
					}
					else
					{
						task.AddCompletionAction(this);
					}
				}
			}

			// Token: 0x0600244C RID: 9292 RVA: 0x00082218 File Offset: 0x00080418
			public void Invoke(Task ignored)
			{
				if (DebuggerSupport.LoggingOn)
				{
					DebuggerSupport.TraceOperationRelation(CausalityTraceLevel.Important, this, CausalityRelation.Join);
				}
				if (Interlocked.Decrement(ref this.m_count) == 0)
				{
					LowLevelListWithIList<ExceptionDispatchInfo> lowLevelListWithIList = null;
					Task task = null;
					for (int i = 0; i < this.m_tasks.Length; i++)
					{
						Task task2 = this.m_tasks[i];
						if (task2.IsFaulted)
						{
							if (lowLevelListWithIList == null)
							{
								lowLevelListWithIList = new LowLevelListWithIList<ExceptionDispatchInfo>();
							}
							lowLevelListWithIList.AddRange(task2.GetExceptionDispatchInfos());
						}
						else if (task2.IsCanceled && task == null)
						{
							task = task2;
						}
						if (task2.IsWaitNotificationEnabled)
						{
							base.SetNotificationForWaitCompletion(true);
						}
						else
						{
							this.m_tasks[i] = null;
						}
					}
					if (lowLevelListWithIList != null)
					{
						base.TrySetException(lowLevelListWithIList);
						return;
					}
					if (task != null)
					{
						base.TrySetCanceled(task.CancellationToken, task.GetCancellationExceptionDispatchInfo());
						return;
					}
					if (DebuggerSupport.LoggingOn)
					{
						DebuggerSupport.TraceOperationCompletion(CausalityTraceLevel.Required, this, AsyncStatus.Completed);
					}
					DebuggerSupport.RemoveFromActiveTasks(this);
					base.TrySetResult(default(VoidTaskResult));
				}
			}

			// Token: 0x17000460 RID: 1120
			// (get) Token: 0x0600244D RID: 9293 RVA: 0x000822F3 File Offset: 0x000804F3
			internal override bool ShouldNotifyDebuggerOfWaitCompletion
			{
				get
				{
					return base.ShouldNotifyDebuggerOfWaitCompletion && Task.AnyTaskRequiresNotifyDebuggerOfWaitCompletion(this.m_tasks);
				}
			}

			// Token: 0x17000461 RID: 1121
			// (get) Token: 0x0600244E RID: 9294 RVA: 0x000040F7 File Offset: 0x000022F7
			public bool InvokeMayRunArbitraryCode
			{
				get
				{
					return true;
				}
			}

			// Token: 0x04001CFB RID: 7419
			private readonly Task[] m_tasks;

			// Token: 0x04001CFC RID: 7420
			private int m_count;
		}

		// Token: 0x0200035D RID: 861
		private sealed class WhenAllPromise<T> : Task<T[]>, ITaskCompletionAction
		{
			// Token: 0x0600244F RID: 9295 RVA: 0x0008230C File Offset: 0x0008050C
			internal WhenAllPromise(Task<T>[] tasks)
			{
				this.m_tasks = tasks;
				this.m_count = tasks.Length;
				if (DebuggerSupport.LoggingOn)
				{
					DebuggerSupport.TraceOperationCreation(CausalityTraceLevel.Required, this, "Task.WhenAll", 0UL);
				}
				DebuggerSupport.AddToActiveTasks(this);
				foreach (Task<T> task in tasks)
				{
					if (task.IsCompleted)
					{
						this.Invoke(task);
					}
					else
					{
						task.AddCompletionAction(this);
					}
				}
			}

			// Token: 0x06002450 RID: 9296 RVA: 0x00082378 File Offset: 0x00080578
			public void Invoke(Task ignored)
			{
				if (DebuggerSupport.LoggingOn)
				{
					DebuggerSupport.TraceOperationRelation(CausalityTraceLevel.Important, this, CausalityRelation.Join);
				}
				if (Interlocked.Decrement(ref this.m_count) == 0)
				{
					T[] array = new T[this.m_tasks.Length];
					LowLevelListWithIList<ExceptionDispatchInfo> lowLevelListWithIList = null;
					Task task = null;
					for (int i = 0; i < this.m_tasks.Length; i++)
					{
						Task<T> task2 = this.m_tasks[i];
						if (task2.IsFaulted)
						{
							if (lowLevelListWithIList == null)
							{
								lowLevelListWithIList = new LowLevelListWithIList<ExceptionDispatchInfo>();
							}
							lowLevelListWithIList.AddRange(task2.GetExceptionDispatchInfos());
						}
						else if (task2.IsCanceled)
						{
							if (task == null)
							{
								task = task2;
							}
						}
						else
						{
							array[i] = task2.GetResultCore(false);
						}
						if (task2.IsWaitNotificationEnabled)
						{
							base.SetNotificationForWaitCompletion(true);
						}
						else
						{
							this.m_tasks[i] = null;
						}
					}
					if (lowLevelListWithIList != null)
					{
						base.TrySetException(lowLevelListWithIList);
						return;
					}
					if (task != null)
					{
						base.TrySetCanceled(task.CancellationToken, task.GetCancellationExceptionDispatchInfo());
						return;
					}
					if (DebuggerSupport.LoggingOn)
					{
						DebuggerSupport.TraceOperationCompletion(CausalityTraceLevel.Required, this, AsyncStatus.Completed);
					}
					DebuggerSupport.RemoveFromActiveTasks(this);
					base.TrySetResult(array);
				}
			}

			// Token: 0x17000462 RID: 1122
			// (get) Token: 0x06002451 RID: 9297 RVA: 0x00082470 File Offset: 0x00080670
			internal override bool ShouldNotifyDebuggerOfWaitCompletion
			{
				get
				{
					if (base.ShouldNotifyDebuggerOfWaitCompletion)
					{
						Task[] tasks = this.m_tasks;
						return Task.AnyTaskRequiresNotifyDebuggerOfWaitCompletion(tasks);
					}
					return false;
				}
			}

			// Token: 0x17000463 RID: 1123
			// (get) Token: 0x06002452 RID: 9298 RVA: 0x000040F7 File Offset: 0x000022F7
			public bool InvokeMayRunArbitraryCode
			{
				get
				{
					return true;
				}
			}

			// Token: 0x04001CFD RID: 7421
			private readonly Task<T>[] m_tasks;

			// Token: 0x04001CFE RID: 7422
			private int m_count;
		}
	}
}
