using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	/// <summary>Представляет асинхронную операцию, которая может вернуть значение.</summary>
	/// <typeparam name="TResult">Тип результата, созданного данной задачей <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
	// Token: 0x0200033F RID: 831
	[DebuggerTypeProxy(typeof(SystemThreadingTasks_FutureDebugView<>))]
	[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}, Result = {DebuggerDisplayResultDescription}")]
	public class Task<TResult> : Task
	{
		// Token: 0x060022C0 RID: 8896 RVA: 0x0007CDFB File Offset: 0x0007AFFB
		internal Task()
		{
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x0007CE03 File Offset: 0x0007B003
		internal Task(object state, TaskCreationOptions options) : base(state, options, true)
		{
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x0007CE10 File Offset: 0x0007B010
		internal Task(TResult result) : base(false, TaskCreationOptions.None, default(CancellationToken))
		{
			this.m_result = result;
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x0007CE35 File Offset: 0x0007B035
		internal Task(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct) : base(canceled, creationOptions, ct)
		{
			if (!canceled)
			{
				this.m_result = result;
			}
		}

		/// <summary>Инициализирует новую задачу <see cref="T:System.Threading.Tasks.Task`1" /> с указанной функцией.</summary>
		/// <param name="function">Делегат, который представляет код, выполняемый в рамках задачи. После завершения выполнения функции будет установлено свойство <see cref="P:System.Threading.Tasks.Task`1.Result" /> результата задачи для возврата результата выполнения функции.</param>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="function" /> имеет значение NULL.</exception>
		// Token: 0x060022C4 RID: 8900 RVA: 0x0007CE4C File Offset: 0x0007B04C
		public Task(Func<TResult> function) : this(function, null, default(CancellationToken), TaskCreationOptions.None, InternalTaskOptions.None, null)
		{
		}

		/// <summary>Инициализирует новую задачу <see cref="T:System.Threading.Tasks.Task`1" /> с указанной функцией.</summary>
		/// <param name="function">Делегат, который представляет код, выполняемый в рамках задачи. После завершения выполнения функции будет установлено свойство <see cref="P:System.Threading.Tasks.Task`1.Result" /> результата задачи для возврата результата выполнения функции.</param>
		/// <param name="cancellationToken">Токен <see cref="T:System.Threading.CancellationToken" /> для назначения данной задаче.</param>
		/// <exception cref="T:System.ObjectDisposedException">Класс <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="function" /> имеет значение NULL.</exception>
		// Token: 0x060022C5 RID: 8901 RVA: 0x0007CE6D File Offset: 0x0007B06D
		public Task(Func<TResult> function, CancellationToken cancellationToken) : this(function, null, cancellationToken, TaskCreationOptions.None, InternalTaskOptions.None, null)
		{
		}

		/// <summary>Инициализирует новую задачу <see cref="T:System.Threading.Tasks.Task`1" /> с указанной функцией и параметрами создания.</summary>
		/// <param name="function">Делегат, который представляет код, выполняемый в рамках задачи. После завершения выполнения функции будет установлено свойство <see cref="P:System.Threading.Tasks.Task`1.Result" /> результата задачи для возврата результата выполнения функции.</param>
		/// <param name="creationOptions">Объект <see cref="T:System.Threading.Tasks.TaskCreationOptions" />, который используется для настройки поведения задачи.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="creationOptions" /> задает недопустимое значение для <see cref="T:System.Threading.Tasks.TaskCreationOptions" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="function" /> имеет значение NULL.</exception>
		// Token: 0x060022C6 RID: 8902 RVA: 0x0007CE7C File Offset: 0x0007B07C
		public Task(Func<TResult> function, TaskCreationOptions creationOptions) : this(function, Task.InternalCurrentIfAttached(creationOptions), default(CancellationToken), creationOptions, InternalTaskOptions.None, null)
		{
		}

		/// <summary>Инициализирует новую задачу <see cref="T:System.Threading.Tasks.Task`1" /> с указанной функцией и параметрами создания.</summary>
		/// <param name="function">Делегат, который представляет код, выполняемый в рамках задачи. После завершения выполнения функции будет установлено свойство <see cref="P:System.Threading.Tasks.Task`1.Result" /> результата задачи для возврата результата выполнения функции.</param>
		/// <param name="cancellationToken">Токен <see cref="T:System.Threading.CancellationToken" />, который будет назначен новой задаче.</param>
		/// <param name="creationOptions">Объект <see cref="T:System.Threading.Tasks.TaskCreationOptions" />, который используется для настройки поведения задачи.</param>
		/// <exception cref="T:System.ObjectDisposedException">Класс <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, уже удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="creationOptions" /> задает недопустимое значение для <see cref="T:System.Threading.Tasks.TaskCreationOptions" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="function" /> имеет значение NULL.</exception>
		// Token: 0x060022C7 RID: 8903 RVA: 0x0007CEA2 File Offset: 0x0007B0A2
		public Task(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions) : this(function, Task.InternalCurrentIfAttached(creationOptions), cancellationToken, creationOptions, InternalTaskOptions.None, null)
		{
		}

		/// <summary>Инициализирует новую задачу <see cref="T:System.Threading.Tasks.Task`1" /> с указанными функцией и состоянием.</summary>
		/// <param name="function">Делегат, который представляет код, выполняемый в рамках задачи. После завершения выполнения функции будет установлено свойство <see cref="P:System.Threading.Tasks.Task`1.Result" /> результата задачи для возврата результата выполнения функции.</param>
		/// <param name="state">Объект, который представляет данные, используемые действием.</param>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="function" /> имеет значение NULL.</exception>
		// Token: 0x060022C8 RID: 8904 RVA: 0x0007CEB8 File Offset: 0x0007B0B8
		public Task(Func<object, TResult> function, object state) : this(function, state, null, default(CancellationToken), TaskCreationOptions.None, InternalTaskOptions.None, null)
		{
		}

		/// <summary>Инициализирует новую задачу <see cref="T:System.Threading.Tasks.Task`1" /> с заданными действием, состоянием и параметрами.</summary>
		/// <param name="function">Делегат, который представляет код, выполняемый в рамках задачи. После завершения выполнения функции будет установлено свойство <see cref="P:System.Threading.Tasks.Task`1.Result" /> результата задачи для возврата результата выполнения функции.</param>
		/// <param name="state">Объект, который представляет данные, используемые функцией.</param>
		/// <param name="cancellationToken">Токен <see cref="T:System.Threading.CancellationToken" /> для назначения новой задаче.</param>
		/// <exception cref="T:System.ObjectDisposedException">Класс <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="function" /> имеет значение NULL.</exception>
		// Token: 0x060022C9 RID: 8905 RVA: 0x0007CEDA File Offset: 0x0007B0DA
		public Task(Func<object, TResult> function, object state, CancellationToken cancellationToken) : this(function, state, null, cancellationToken, TaskCreationOptions.None, InternalTaskOptions.None, null)
		{
		}

		/// <summary>Инициализирует новую задачу <see cref="T:System.Threading.Tasks.Task`1" /> с заданными действием, состоянием и параметрами.</summary>
		/// <param name="function">Делегат, который представляет код, выполняемый в рамках задачи. После завершения выполнения функции будет установлено свойство <see cref="P:System.Threading.Tasks.Task`1.Result" /> результата задачи для возврата результата выполнения функции.</param>
		/// <param name="state">Объект, который представляет данные, используемые функцией.</param>
		/// <param name="creationOptions">Объект <see cref="T:System.Threading.Tasks.TaskCreationOptions" />, который используется для настройки поведения задачи.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="creationOptions" /> задает недопустимое значение для <see cref="T:System.Threading.Tasks.TaskCreationOptions" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="function" /> имеет значение NULL.</exception>
		// Token: 0x060022CA RID: 8906 RVA: 0x0007CEEC File Offset: 0x0007B0EC
		public Task(Func<object, TResult> function, object state, TaskCreationOptions creationOptions) : this(function, state, Task.InternalCurrentIfAttached(creationOptions), default(CancellationToken), creationOptions, InternalTaskOptions.None, null)
		{
		}

		/// <summary>Инициализирует новую задачу <see cref="T:System.Threading.Tasks.Task`1" /> с заданными действием, состоянием и параметрами.</summary>
		/// <param name="function">Делегат, который представляет код, выполняемый в рамках задачи. После завершения выполнения функции будет установлено свойство <see cref="P:System.Threading.Tasks.Task`1.Result" /> результата задачи для возврата результата выполнения функции.</param>
		/// <param name="state">Объект, который представляет данные, используемые функцией.</param>
		/// <param name="cancellationToken">Токен <see cref="T:System.Threading.CancellationToken" /> для назначения новой задаче.</param>
		/// <param name="creationOptions">Объект <see cref="T:System.Threading.Tasks.TaskCreationOptions" />, который используется для настройки поведения задачи.</param>
		/// <exception cref="T:System.ObjectDisposedException">Класс <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, уже удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="creationOptions" /> задает недопустимое значение для <see cref="T:System.Threading.Tasks.TaskCreationOptions" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="function" /> имеет значение NULL.</exception>
		// Token: 0x060022CB RID: 8907 RVA: 0x0007CF13 File Offset: 0x0007B113
		public Task(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) : this(function, state, Task.InternalCurrentIfAttached(creationOptions), cancellationToken, creationOptions, InternalTaskOptions.None, null)
		{
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x0007CF29 File Offset: 0x0007B129
		internal Task(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) : base(valueSelector, null, parent, cancellationToken, creationOptions, internalOptions, scheduler)
		{
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x0007CF3B File Offset: 0x0007B13B
		internal Task(Delegate valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) : base(valueSelector, state, parent, cancellationToken, creationOptions, internalOptions, scheduler)
		{
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x0007CF4E File Offset: 0x0007B14E
		internal static Task<TResult> StartNew(Task parent, Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			if (function == null)
			{
				throw new ArgumentNullException("function");
			}
			if (scheduler == null)
			{
				throw new ArgumentNullException("scheduler");
			}
			Task<TResult> task = new Task<TResult>(function, parent, cancellationToken, creationOptions, internalOptions | InternalTaskOptions.QueuedByRuntime, scheduler);
			task.ScheduleAndStart(false);
			return task;
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x0007CF87 File Offset: 0x0007B187
		internal static Task<TResult> StartNew(Task parent, Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			if (function == null)
			{
				throw new ArgumentNullException("function");
			}
			if (scheduler == null)
			{
				throw new ArgumentNullException("scheduler");
			}
			Task<TResult> task = new Task<TResult>(function, state, parent, cancellationToken, creationOptions, internalOptions | InternalTaskOptions.QueuedByRuntime, scheduler);
			task.ScheduleAndStart(false);
			return task;
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x060022D0 RID: 8912 RVA: 0x0007CFC4 File Offset: 0x0007B1C4
		private string DebuggerDisplayResultDescription
		{
			get
			{
				if (!base.IsCompletedSuccessfully)
				{
					return "{Not yet computed}";
				}
				TResult result = this.m_result;
				return ((result != null) ? result.ToString() : null) ?? "";
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x060022D1 RID: 8913 RVA: 0x0007D008 File Offset: 0x0007B208
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

		// Token: 0x060022D2 RID: 8914 RVA: 0x0007D044 File Offset: 0x0007B244
		internal bool TrySetResult(TResult result)
		{
			if (base.IsCompleted)
			{
				return false;
			}
			if (base.AtomicStateUpdate(67108864, 90177536))
			{
				this.m_result = result;
				Interlocked.Exchange(ref this.m_stateFlags, this.m_stateFlags | 16777216);
				Task.ContingentProperties contingentProperties = this.m_contingentProperties;
				if (contingentProperties != null)
				{
					contingentProperties.SetCompleted();
				}
				base.FinishStageThree();
				return true;
			}
			return false;
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x0007D0A9 File Offset: 0x0007B2A9
		internal void DangerousSetResult(TResult result)
		{
			if (this.m_parent != null)
			{
				this.TrySetResult(result);
				return;
			}
			this.m_result = result;
			this.m_stateFlags |= 16777216;
		}

		/// <summary>Получает итоговое значение данного объекта <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <returns>Итоговое значение данного объекта <see cref="T:System.Threading.Tasks.Task`1" />, который имеет тот же тип, что параметр типа данной задачи.</returns>
		/// <exception cref="T:System.AggregateException">Задача отменена. Коллекция <see cref="P:System.AggregateException.InnerExceptions" /> содержит объект <see cref="T:System.Threading.Tasks.TaskCanceledException" />.  
		/// -или- 
		/// Во время выполнения задачи возникло исключение. Коллекция <see cref="P:System.AggregateException.InnerExceptions" /> содержит сведения об исключении или исключениях.</exception>
		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x060022D4 RID: 8916 RVA: 0x0007D0D9 File Offset: 0x0007B2D9
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public TResult Result
		{
			get
			{
				if (!base.IsWaitNotificationEnabledOrNotRanToCompletion)
				{
					return this.m_result;
				}
				return this.GetResultCore(true);
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x060022D5 RID: 8917 RVA: 0x0007D0F1 File Offset: 0x0007B2F1
		internal TResult ResultOnSuccess
		{
			get
			{
				return this.m_result;
			}
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x0007D0FC File Offset: 0x0007B2FC
		internal TResult GetResultCore(bool waitCompletionNotification)
		{
			if (!base.IsCompleted)
			{
				base.InternalWait(-1, default(CancellationToken));
			}
			if (waitCompletionNotification)
			{
				base.NotifyDebuggerOfWaitCompletionIfNecessary();
			}
			if (!base.IsCompletedSuccessfully)
			{
				base.ThrowIfExceptional(true);
			}
			return this.m_result;
		}

		/// <summary>Предоставляет доступ к методам фабрики для создания и настройки экземпляров <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <returns>Объект фабрики, который может создавать разнообразные объекты <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x060022D7 RID: 8919 RVA: 0x0007D141 File Offset: 0x0007B341
		public new static TaskFactory<TResult> Factory
		{
			get
			{
				if (Task<TResult>.s_defaultFactory == null)
				{
					Interlocked.CompareExchange<TaskFactory<TResult>>(ref Task<TResult>.s_defaultFactory, new TaskFactory<TResult>(), null);
				}
				return Task<TResult>.s_defaultFactory;
			}
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x0007D160 File Offset: 0x0007B360
		internal override void InnerInvoke()
		{
			Func<TResult> func = this.m_action as Func<TResult>;
			if (func != null)
			{
				this.m_result = func();
				return;
			}
			Func<object, TResult> func2 = this.m_action as Func<object, TResult>;
			if (func2 != null)
			{
				this.m_result = func2(this.m_stateObject);
				return;
			}
		}

		/// <summary>Возвращает объект типа awaiter, используемый для данного объекта <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <returns>Экземпляр объекта типа awaiter.</returns>
		// Token: 0x060022D9 RID: 8921 RVA: 0x0007D1AB File Offset: 0x0007B3AB
		public new TaskAwaiter<TResult> GetAwaiter()
		{
			return new TaskAwaiter<TResult>(this);
		}

		/// <summary>Настраивает объект типа awaiter, используемый для данного объекта <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="continueOnCapturedContext">Значение true, чтобы попытаться выполнить маршалинг продолжения обратно в исходный захваченный контекст; в противном случае — значение false.</param>
		/// <returns>Объект, используемый для ожидания данной задачи.</returns>
		// Token: 0x060022DA RID: 8922 RVA: 0x0007D1B3 File Offset: 0x0007B3B3
		public new ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext)
		{
			return new ConfiguredTaskAwaitable<TResult>(this, continueOnCapturedContext);
		}

		/// <summary>Создает продолжение, которое выполняется асинхронно после завершения выполнения целевой задачи.</summary>
		/// <param name="continuationAction">Действие, которое необходимо выполнить после завершения предыдущей задачи <see cref="T:System.Threading.Tasks.Task`1" />. При запуске делегата завершенная задача будет передана ему в качестве аргумента.</param>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Tasks.Task`1" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationAction" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060022DB RID: 8923 RVA: 0x0007D1BC File Offset: 0x0007B3BC
		public Task ContinueWith(Action<Task<TResult>> continuationAction)
		{
			return this.ContinueWith(continuationAction, TaskScheduler.Current, default(CancellationToken), TaskContinuationOptions.None);
		}

		/// <summary>Создает отменяемое продолжение, которое выполняется асинхронно после завершения выполнения целевой задачи <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="continuationAction">Действие, которое необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task`1" />. При запуске делегата завершенная задача будет передана ему в качестве аргумента.</param>
		/// <param name="cancellationToken">Токен отмены, передаваемый новой задаче продолжения.</param>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Tasks.Task`1" /> удален.  
		/// -или- 
		/// Класс <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationAction" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060022DC RID: 8924 RVA: 0x0007D1DF File Offset: 0x0007B3DF
		public Task ContinueWith(Action<Task<TResult>> continuationAction, CancellationToken cancellationToken)
		{
			return this.ContinueWith(continuationAction, TaskScheduler.Current, cancellationToken, TaskContinuationOptions.None);
		}

		/// <summary>Создает продолжение, которое выполняется асинхронно после завершения выполнения целевой задачи <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="continuationAction">Действие, которое необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task`1" />. При запуске делегата завершенная задача будет передана ему в качестве аргумента.</param>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, который следует связать с задачей продолжения и использовать для ее запуска.</param>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Tasks.Task`1" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationAction" /> имеет значение NULL.  
		///
		/// или - 
		/// Аргумент <paramref name="scheduler" /> имеет значение NULL.</exception>
		// Token: 0x060022DD RID: 8925 RVA: 0x0007D1F0 File Offset: 0x0007B3F0
		public Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler)
		{
			return this.ContinueWith(continuationAction, scheduler, default(CancellationToken), TaskContinuationOptions.None);
		}

		/// <summary>Создает продолжение, выполняемое в соответствии с условием, заданным в <paramref name="continuationOptions" />.</summary>
		/// <param name="continuationAction">Действие в соответствии с условием, заданным в <paramref name="continuationOptions" />. При запуске делегата завершенная задача будет передана ему в качестве аргумента.</param>
		/// <param name="continuationOptions">Параметры, определяющие запланированное время продолжения и его поведение. Включаются критерии, такие как <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, а также параметры выполнения, например <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Tasks.Task`1" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationAction" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> задает недопустимое значение для <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		// Token: 0x060022DE RID: 8926 RVA: 0x0007D210 File Offset: 0x0007B410
		public Task ContinueWith(Action<Task<TResult>> continuationAction, TaskContinuationOptions continuationOptions)
		{
			return this.ContinueWith(continuationAction, TaskScheduler.Current, default(CancellationToken), continuationOptions);
		}

		/// <summary>Создает продолжение, выполняемое в соответствии с условием, заданным в <paramref name="continuationOptions" />.</summary>
		/// <param name="continuationAction">Действие для запуска в соответствии с заданным условием в <paramref name="continuationOptions" />. При запуске делегата завершенная задача будет передана ему в качестве аргумента.</param>
		/// <param name="cancellationToken">Токен <see cref="T:System.Threading.CancellationToken" />, который будет назначен новой задаче продолжения.</param>
		/// <param name="continuationOptions">Параметры, определяющие запланированное время продолжения и его поведение. Включаются критерии, такие как <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, а также параметры выполнения, например <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, который следует связать с задачей продолжения и использовать для ее запуска.</param>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Tasks.Task`1" /> удален.  
		/// -или- 
		/// Класс <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationAction" /> имеет значение NULL.  
		/// -или- 
		/// Аргумент <paramref name="scheduler" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> задает недопустимое значение для <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		// Token: 0x060022DF RID: 8927 RVA: 0x0007D233 File Offset: 0x0007B433
		public Task ContinueWith(Action<Task<TResult>> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return this.ContinueWith(continuationAction, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x0007D240 File Offset: 0x0007B440
		internal Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
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
			Task task = new ContinuationTaskFromResultTask<TResult>(this, continuationAction, null, creationOptions, internalOptions);
			base.ContinueWithCore(task, scheduler, cancellationToken, continuationOptions);
			return task;
		}

		/// <summary>Создает продолжение, которое получает сведения о состоянии и выполняется после завершения целевой задачи <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="continuationAction">Действие, которое необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task`1" />. При запуске делегату передается в качестве аргументов завершенная задача и предоставленный вызывающей стороной объект состояния.</param>
		/// <param name="state">Объект, который представляет данные, используемые действием продолжения.</param>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationAction" /> имеет значение NULL.</exception>
		// Token: 0x060022E1 RID: 8929 RVA: 0x0007D28C File Offset: 0x0007B48C
		public Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state)
		{
			return this.ContinueWith(continuationAction, state, TaskScheduler.Current, default(CancellationToken), TaskContinuationOptions.None);
		}

		/// <summary>Создает продолжение, которое выполняется после завершения выполнения целевого объекта <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="continuationAction">Действие, которое необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task`1" />. При запуске делегату будут переданы в качестве аргументов завершенная задача и предоставленный вызывающей стороной объект состояния.</param>
		/// <param name="state">Объект, который представляет данные, используемые действием продолжения.</param>
		/// <param name="cancellationToken">Токен <see cref="T:System.Threading.CancellationToken" />, который будет назначен новой задаче продолжения.</param>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationAction" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Предоставленный объект <see cref="T:System.Threading.CancellationToken" /> уже удален.</exception>
		// Token: 0x060022E2 RID: 8930 RVA: 0x0007D2B0 File Offset: 0x0007B4B0
		public Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state, CancellationToken cancellationToken)
		{
			return this.ContinueWith(continuationAction, state, TaskScheduler.Current, cancellationToken, TaskContinuationOptions.None);
		}

		/// <summary>Создает продолжение, которое выполняется после завершения выполнения целевого объекта <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="continuationAction">Действие, которое необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task`1" />. При запуске делегату будут переданы в качестве аргументов завершенная задача и предоставленный вызывающей стороной объект состояния.</param>
		/// <param name="state">Объект, который представляет данные, используемые действием продолжения.</param>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, который следует связать с задачей продолжения и использовать для ее запуска.</param>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="scheduler" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060022E3 RID: 8931 RVA: 0x0007D2C4 File Offset: 0x0007B4C4
		public Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state, TaskScheduler scheduler)
		{
			return this.ContinueWith(continuationAction, state, scheduler, default(CancellationToken), TaskContinuationOptions.None);
		}

		/// <summary>Создает продолжение, которое выполняется после завершения выполнения целевого объекта <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="continuationAction">Действие, которое необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task`1" />. При запуске делегату будут переданы в качестве аргументов завершенная задача и предоставленный вызывающей стороной объект состояния.</param>
		/// <param name="state">Объект, который представляет данные, используемые действием продолжения.</param>
		/// <param name="continuationOptions">Параметры, определяющие запланированное время продолжения и его поведение. Включаются критерии, такие как <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, а также параметры выполнения, например <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationAction" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> задает недопустимое значение для <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		// Token: 0x060022E4 RID: 8932 RVA: 0x0007D2E4 File Offset: 0x0007B4E4
		public Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state, TaskContinuationOptions continuationOptions)
		{
			return this.ContinueWith(continuationAction, state, TaskScheduler.Current, default(CancellationToken), continuationOptions);
		}

		/// <summary>Создает продолжение, которое выполняется после завершения выполнения целевого объекта <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="continuationAction">Действие, которое необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task`1" />. При запуске делегату будут переданы в качестве аргументов завершенная задача и предоставленный вызывающей стороной объект состояния.</param>
		/// <param name="state">Объект, который представляет данные, используемые действием продолжения.</param>
		/// <param name="cancellationToken">Токен <see cref="T:System.Threading.CancellationToken" />, который будет назначен новой задаче продолжения.</param>
		/// <param name="continuationOptions">Параметры, определяющие запланированное время продолжения и его поведение. Включаются критерии, такие как <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, а также параметры выполнения, например <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, который следует связать с задачей продолжения и использовать для ее запуска.</param>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="scheduler" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> задает недопустимое значение для <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Предоставленный объект <see cref="T:System.Threading.CancellationToken" /> уже удален.</exception>
		// Token: 0x060022E5 RID: 8933 RVA: 0x0007D308 File Offset: 0x0007B508
		public Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return this.ContinueWith(continuationAction, state, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x0007D318 File Offset: 0x0007B518
		internal Task ContinueWith(Action<Task<TResult>, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
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
			Task task = new ContinuationTaskFromResultTask<TResult>(this, continuationAction, state, creationOptions, internalOptions);
			base.ContinueWithCore(task, scheduler, cancellationToken, continuationOptions);
			return task;
		}

		/// <summary>Создает продолжение, которое выполняется асинхронно после завершения выполнения целевой задачи <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="continuationFunction">Функция, которую необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task`1" />. При запуске делегата завершенная задача будет передана ему в качестве аргумента.</param>
		/// <typeparam name="TNewResult">Тип результата, созданного продолжением.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Tasks.Task`1" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationFunction" /> имеет значение NULL.</exception>
		// Token: 0x060022E7 RID: 8935 RVA: 0x0007D364 File Offset: 0x0007B564
		public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction)
		{
			return this.ContinueWith<TNewResult>(continuationFunction, TaskScheduler.Current, default(CancellationToken), TaskContinuationOptions.None);
		}

		/// <summary>Создает продолжение, которое выполняется асинхронно после завершения выполнения целевой задачи <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="continuationFunction">Функция, которую необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task`1" />. При запуске делегата завершенная задача будет передана ему в качестве аргумента.</param>
		/// <param name="cancellationToken">Токен <see cref="T:System.Threading.CancellationToken" />, который будет назначен новой задаче.</param>
		/// <typeparam name="TNewResult">Тип результата, созданного продолжением.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Tasks.Task`1" /> удален.  
		///
		/// или - 
		/// Класс <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationFunction" /> имеет значение NULL.</exception>
		// Token: 0x060022E8 RID: 8936 RVA: 0x0007D387 File Offset: 0x0007B587
		public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, CancellationToken cancellationToken)
		{
			return this.ContinueWith<TNewResult>(continuationFunction, TaskScheduler.Current, cancellationToken, TaskContinuationOptions.None);
		}

		/// <summary>Создает продолжение, которое выполняется асинхронно после завершения выполнения целевой задачи <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="continuationFunction">Функция, которую необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task`1" />. При запуске делегата завершенная задача будет передана ему в качестве аргумента.</param>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, который следует связать с задачей продолжения и использовать для ее запуска.</param>
		/// <typeparam name="TNewResult">Тип результата, созданного продолжением.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Tasks.Task`1" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationFunction" /> имеет значение NULL.  
		/// -или- 
		/// Аргумент <paramref name="scheduler" /> имеет значение NULL.</exception>
		// Token: 0x060022E9 RID: 8937 RVA: 0x0007D398 File Offset: 0x0007B598
		public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler)
		{
			return this.ContinueWith<TNewResult>(continuationFunction, scheduler, default(CancellationToken), TaskContinuationOptions.None);
		}

		/// <summary>Создает продолжение, выполняемое в соответствии с условием, заданным в <paramref name="continuationOptions" />.</summary>
		/// <param name="continuationFunction">Функция для запуска в соответствии с условием, заданным в <paramref name="continuationOptions" />.  
		/// При запуске делегата завершенная задача будет передана ему в качестве аргумента.</param>
		/// <param name="continuationOptions">Параметры, определяющие запланированное время продолжения и его поведение. Включаются критерии, такие как <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, а также параметры выполнения, например <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <typeparam name="TNewResult">Тип результата, созданного продолжением.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Tasks.Task`1" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationFunction" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> задает недопустимое значение для <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		// Token: 0x060022EA RID: 8938 RVA: 0x0007D3B8 File Offset: 0x0007B5B8
		public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			return this.ContinueWith<TNewResult>(continuationFunction, TaskScheduler.Current, default(CancellationToken), continuationOptions);
		}

		/// <summary>Создает продолжение, выполняемое в соответствии с условием, заданным в <paramref name="continuationOptions" />.</summary>
		/// <param name="continuationFunction">Функция для запуска в соответствии с условием, заданным в <paramref name="continuationOptions" />.  
		/// При запуске делегата завершенная задача будет передана ему в качестве аргумента.</param>
		/// <param name="cancellationToken">Токен <see cref="T:System.Threading.CancellationToken" />, который будет назначен новой задаче.</param>
		/// <param name="continuationOptions">Параметры, определяющие запланированное время продолжения и его поведение. Включаются критерии, такие как <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, а также параметры выполнения, например <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, который следует связать с задачей продолжения и использовать для ее запуска.</param>
		/// <typeparam name="TNewResult">Тип результата, созданного продолжением.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Threading.Tasks.Task`1" /> удален.  
		///
		/// или - 
		/// Класс <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationFunction" /> имеет значение NULL.  
		/// -или- 
		/// Аргумент <paramref name="scheduler" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> задает недопустимое значение для <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		// Token: 0x060022EB RID: 8939 RVA: 0x0007D3DB File Offset: 0x0007B5DB
		public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return this.ContinueWith<TNewResult>(continuationFunction, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x0007D3E8 File Offset: 0x0007B5E8
		internal Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
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
			Task<TNewResult> task = new ContinuationResultTaskFromResultTask<TResult, TNewResult>(this, continuationFunction, null, creationOptions, internalOptions);
			base.ContinueWithCore(task, scheduler, cancellationToken, continuationOptions);
			return task;
		}

		/// <summary>Создает продолжение, которое выполняется после завершения выполнения целевого объекта <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="continuationFunction">Функция, которую необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task`1" />. При запуске делегату будут переданы в качестве аргументов завершенная задача и предоставленный вызывающей стороной объект состояния.</param>
		/// <param name="state">Объект, который представляет данные, используемые функцией продолжения.</param>
		/// <typeparam name="TNewResult">Тип результата, созданного продолжением.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationFunction" /> имеет значение NULL.</exception>
		// Token: 0x060022ED RID: 8941 RVA: 0x0007D434 File Offset: 0x0007B634
		public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, object, TNewResult> continuationFunction, object state)
		{
			return this.ContinueWith<TNewResult>(continuationFunction, state, TaskScheduler.Current, default(CancellationToken), TaskContinuationOptions.None);
		}

		/// <summary>Создает продолжение, которое выполняется после завершения выполнения целевого объекта <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="continuationFunction">Функция, которую необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task`1" />. При запуске делегату будут переданы в качестве аргументов завершенная задача и предоставленный вызывающей стороной объект состояния.</param>
		/// <param name="state">Объект, который представляет данные, используемые функцией продолжения.</param>
		/// <param name="cancellationToken">Токен <see cref="T:System.Threading.CancellationToken" />, который будет назначен новой задаче.</param>
		/// <typeparam name="TNewResult">Тип результата, созданного продолжением.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationFunction" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Предоставленный объект <see cref="T:System.Threading.CancellationToken" /> уже удален.</exception>
		// Token: 0x060022EE RID: 8942 RVA: 0x0007D458 File Offset: 0x0007B658
		public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, object, TNewResult> continuationFunction, object state, CancellationToken cancellationToken)
		{
			return this.ContinueWith<TNewResult>(continuationFunction, state, TaskScheduler.Current, cancellationToken, TaskContinuationOptions.None);
		}

		/// <summary>Создает продолжение, которое выполняется после завершения выполнения целевого объекта <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="continuationFunction">Функция, которую необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task`1" />. При запуске делегату будут переданы в качестве аргументов завершенная задача и предоставленный вызывающей стороной объект состояния.</param>
		/// <param name="state">Объект, который представляет данные, используемые функцией продолжения.</param>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, который следует связать с задачей продолжения и использовать для ее запуска.</param>
		/// <typeparam name="TNewResult">Тип результата, созданного продолжением.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="scheduler" /> имеет значение NULL.</exception>
		// Token: 0x060022EF RID: 8943 RVA: 0x0007D46C File Offset: 0x0007B66C
		public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, object, TNewResult> continuationFunction, object state, TaskScheduler scheduler)
		{
			return this.ContinueWith<TNewResult>(continuationFunction, state, scheduler, default(CancellationToken), TaskContinuationOptions.None);
		}

		/// <summary>Создает продолжение, которое выполняется после завершения выполнения целевого объекта <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="continuationFunction">Функция, которую необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task`1" />. При запуске делегату будут переданы в качестве аргументов завершенная задача и предоставленный вызывающей стороной объект состояния.</param>
		/// <param name="state">Объект, который представляет данные, используемые функцией продолжения.</param>
		/// <param name="continuationOptions">Параметры, определяющие запланированное время продолжения и его поведение. Включаются критерии, такие как <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, а также параметры выполнения, например <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <typeparam name="TNewResult">Тип результата, созданного продолжением.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuationFunction" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> задает недопустимое значение для <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		// Token: 0x060022F0 RID: 8944 RVA: 0x0007D48C File Offset: 0x0007B68C
		public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, object, TNewResult> continuationFunction, object state, TaskContinuationOptions continuationOptions)
		{
			return this.ContinueWith<TNewResult>(continuationFunction, state, TaskScheduler.Current, default(CancellationToken), continuationOptions);
		}

		/// <summary>Создает продолжение, которое выполняется после завершения выполнения целевого объекта <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="continuationFunction">Функция, которую необходимо выполнить после завершения <see cref="T:System.Threading.Tasks.Task`1" />. При запуске делегату будут переданы в качестве аргументов завершенная задача и предоставленный вызывающей стороной объект состояния.</param>
		/// <param name="state">Объект, который представляет данные, используемые функцией продолжения.</param>
		/// <param name="cancellationToken">Токен <see cref="T:System.Threading.CancellationToken" />, который будет назначен новой задаче.</param>
		/// <param name="continuationOptions">Параметры, определяющие запланированное время продолжения и его поведение. Включаются критерии, такие как <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, а также параметры выполнения, например <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, который следует связать с задачей продолжения и использовать для ее запуска.</param>
		/// <typeparam name="TNewResult">Тип результата, созданного продолжением.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="scheduler" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> задает недопустимое значение для <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Предоставленный объект <see cref="T:System.Threading.CancellationToken" /> уже удален.</exception>
		// Token: 0x060022F1 RID: 8945 RVA: 0x0007D4B0 File Offset: 0x0007B6B0
		public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, object, TNewResult> continuationFunction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return this.ContinueWith<TNewResult>(continuationFunction, state, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x0007D4C0 File Offset: 0x0007B6C0
		internal Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, object, TNewResult> continuationFunction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
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
			Task<TNewResult> task = new ContinuationResultTaskFromResultTask<TResult, TNewResult>(this, continuationFunction, state, creationOptions, internalOptions);
			base.ContinueWithCore(task, scheduler, cancellationToken, continuationOptions);
			return task;
		}

		// Token: 0x04001C83 RID: 7299
		internal TResult m_result;

		// Token: 0x04001C84 RID: 7300
		private static TaskFactory<TResult> s_defaultFactory;

		// Token: 0x02000340 RID: 832
		internal static class TaskWhenAnyCast
		{
			// Token: 0x04001C85 RID: 7301
			internal static readonly Func<Task<Task>, Task<TResult>> Value = (Task<Task> completed) => (Task<TResult>)completed.Result;
		}
	}
}
