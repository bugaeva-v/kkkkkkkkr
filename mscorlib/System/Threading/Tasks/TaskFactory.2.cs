using System;
using System.Collections.Generic;
using Internal.Runtime.Augments;

namespace System.Threading.Tasks
{
	/// <summary>Предоставляет поддержку создания и планирования объектов <see cref="T:System.Threading.Tasks.Task" />.</summary>
	// Token: 0x02000375 RID: 885
	public class TaskFactory
	{
		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x060024AB RID: 9387 RVA: 0x000832A0 File Offset: 0x000814A0
		private TaskScheduler DefaultScheduler
		{
			get
			{
				if (this.m_defaultScheduler == null)
				{
					return TaskScheduler.Current;
				}
				return this.m_defaultScheduler;
			}
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x000832B6 File Offset: 0x000814B6
		private TaskScheduler GetDefaultScheduler(Task currTask)
		{
			if (this.m_defaultScheduler != null)
			{
				return this.m_defaultScheduler;
			}
			if (currTask != null && (currTask.CreationOptions & TaskCreationOptions.HideScheduler) == TaskCreationOptions.None)
			{
				return currTask.ExecutingTaskScheduler;
			}
			return TaskScheduler.Default;
		}

		/// <summary>Инициализирует экземпляр <see cref="T:System.Threading.Tasks.TaskFactory" /> с конфигурацией по умолчанию.</summary>
		// Token: 0x060024AD RID: 9389 RVA: 0x000832E4 File Offset: 0x000814E4
		public TaskFactory() : this(default(CancellationToken), TaskCreationOptions.None, TaskContinuationOptions.None, null)
		{
		}

		/// <summary>Инициализирует экземпляр <see cref="T:System.Threading.Tasks.TaskFactory" /> с заданной конфигурацией.</summary>
		/// <param name="cancellationToken">Токен <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" />, который будет назначен для задач, созданных данной фабрикой <see cref="T:System.Threading.Tasks.TaskFactory" />, если при вызове фабричных методов не задан явно другой токен CancellationToken.</param>
		// Token: 0x060024AE RID: 9390 RVA: 0x00083303 File Offset: 0x00081503
		public TaskFactory(CancellationToken cancellationToken) : this(cancellationToken, TaskCreationOptions.None, TaskContinuationOptions.None, null)
		{
		}

		/// <summary>Инициализирует экземпляр <see cref="T:System.Threading.Tasks.TaskFactory" /> с заданной конфигурацией.</summary>
		/// <param name="scheduler">Объект <see cref="T:System.Threading.Tasks.TaskScheduler" />, который нужно использовать при планировании задач, созданных с помощью данной фабрики TaskFactory. Значение NULL означает, что следует использовать текущий TaskScheduler.</param>
		// Token: 0x060024AF RID: 9391 RVA: 0x00083310 File Offset: 0x00081510
		public TaskFactory(TaskScheduler scheduler) : this(default(CancellationToken), TaskCreationOptions.None, TaskContinuationOptions.None, scheduler)
		{
		}

		/// <summary>Инициализирует экземпляр <see cref="T:System.Threading.Tasks.TaskFactory" /> с заданной конфигурацией.</summary>
		/// <param name="creationOptions">Объект <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> по умолчанию, который нужно использовать при создании задач с помощью данной фабрики TaskFactory.</param>
		/// <param name="continuationOptions">Объект <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> по умолчанию, который нужно использовать при создании задач продолжения с помощью данной фабрики TaskFactory.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="creationOptions" /> указывает недопустимое значение <see cref="T:System.Threading.Tasks.TaskCreationOptions" />. Дополнительные сведения см. в примечаниях к описанию <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationOptions" /> указывает недопустимое значение.</exception>
		// Token: 0x060024B0 RID: 9392 RVA: 0x00083330 File Offset: 0x00081530
		public TaskFactory(TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions) : this(default(CancellationToken), creationOptions, continuationOptions, null)
		{
		}

		/// <summary>Инициализирует экземпляр <see cref="T:System.Threading.Tasks.TaskFactory" /> с заданной конфигурацией.</summary>
		/// <param name="cancellationToken">Токен <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> по умолчанию, который будет назначен для задач, созданных данной фабрикой <see cref="T:System.Threading.Tasks.TaskFactory" />, если при вызове фабричных методов не задан явно другой токен CancellationToken.</param>
		/// <param name="creationOptions">Объект <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> по умолчанию, который нужно использовать при создании задач с помощью данной фабрики TaskFactory.</param>
		/// <param name="continuationOptions">Объект <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> по умолчанию, который нужно использовать при создании задач продолжения с помощью данной фабрики TaskFactory.</param>
		/// <param name="scheduler">Объект <see cref="T:System.Threading.Tasks.TaskScheduler" /> по умолчанию, который нужно использовать при планировании задач, созданных с помощью данной фабрики TaskFactory. Значение NULL означает, что следует использовать TaskScheduler.Current.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="creationOptions" /> указывает недопустимое значение <see cref="T:System.Threading.Tasks.TaskCreationOptions" />. Дополнительные сведения см. в примечаниях к описанию <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationOptions" /> указывает недопустимое значение.</exception>
		// Token: 0x060024B1 RID: 9393 RVA: 0x0008334F File Offset: 0x0008154F
		public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			TaskFactory.CheckMultiTaskContinuationOptions(continuationOptions);
			TaskFactory.CheckCreationOptions(creationOptions);
			this.m_defaultCancellationToken = cancellationToken;
			this.m_defaultScheduler = scheduler;
			this.m_defaultCreationOptions = creationOptions;
			this.m_defaultContinuationOptions = continuationOptions;
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x00083380 File Offset: 0x00081580
		internal static void CheckCreationOptions(TaskCreationOptions creationOptions)
		{
			if ((creationOptions & ~(TaskCreationOptions.PreferFairness | TaskCreationOptions.LongRunning | TaskCreationOptions.AttachedToParent | TaskCreationOptions.DenyChildAttach | TaskCreationOptions.HideScheduler | TaskCreationOptions.RunContinuationsAsynchronously)) != TaskCreationOptions.None)
			{
				throw new ArgumentOutOfRangeException("creationOptions");
			}
		}

		/// <summary>Возвращает токен отмены по умолчанию для этой фабрики задач.</summary>
		/// <returns>Токен отмены задачи по умолчанию для этой фабрики задач.</returns>
		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x060024B3 RID: 9395 RVA: 0x00083393 File Offset: 0x00081593
		public CancellationToken CancellationToken
		{
			get
			{
				return this.m_defaultCancellationToken;
			}
		}

		/// <summary>Возвращает планировщик задач по умолчанию для этой фабрики задач.</summary>
		/// <returns>Планировщик задач по умолчанию для этой фабрики задач.</returns>
		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x060024B4 RID: 9396 RVA: 0x0008339B File Offset: 0x0008159B
		public TaskScheduler Scheduler
		{
			get
			{
				return this.m_defaultScheduler;
			}
		}

		/// <summary>Возвращает параметры создания задач по умолчанию для этой фабрики задач.</summary>
		/// <returns>Параметры создания задач по умолчанию для этой фабрики задач.</returns>
		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x060024B5 RID: 9397 RVA: 0x000833A3 File Offset: 0x000815A3
		public TaskCreationOptions CreationOptions
		{
			get
			{
				return this.m_defaultCreationOptions;
			}
		}

		/// <summary>Возвращает параметры продолжения задач по умолчанию для этой фабрики задач.</summary>
		/// <returns>Параметры продолжения задач по умолчанию для этой фабрики задач.</returns>
		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x060024B6 RID: 9398 RVA: 0x000833AB File Offset: 0x000815AB
		public TaskContinuationOptions ContinuationOptions
		{
			get
			{
				return this.m_defaultContinuationOptions;
			}
		}

		/// <summary>Создает и запускает задачу.</summary>
		/// <param name="action">Делегат действия для асинхронного выполнения.</param>
		/// <returns>Запущенная задача.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="action" /> имеет значение NULL.</exception>
		// Token: 0x060024B7 RID: 9399 RVA: 0x000833B4 File Offset: 0x000815B4
		public Task StartNew(Action action)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task.InternalStartNew(internalCurrent, action, null, this.m_defaultCancellationToken, this.GetDefaultScheduler(internalCurrent), this.m_defaultCreationOptions, InternalTaskOptions.None);
		}

		/// <summary>Создает и запускает задачу <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <param name="action">Делегат действия для асинхронного выполнения.</param>
		/// <param name="cancellationToken">Токен <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" />, который будет назначен новой задаче.</param>
		/// <returns>Запущенная задача <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Предоставленный объект <see cref="T:System.Threading.CancellationToken" /> уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="action" /> имеет значение NULL.</exception>
		// Token: 0x060024B8 RID: 9400 RVA: 0x000833E4 File Offset: 0x000815E4
		public Task StartNew(Action action, CancellationToken cancellationToken)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task.InternalStartNew(internalCurrent, action, null, cancellationToken, this.GetDefaultScheduler(internalCurrent), this.m_defaultCreationOptions, InternalTaskOptions.None);
		}

		/// <summary>Создает и запускает задачу <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <param name="action">Делегат действия для асинхронного выполнения.</param>
		/// <param name="creationOptions">Значение TaskCreationOptions, которое управляет поведением созданного объекта <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <returns>Запущенная задача <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="action" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions.</exception>
		// Token: 0x060024B9 RID: 9401 RVA: 0x00083410 File Offset: 0x00081610
		public Task StartNew(Action action, TaskCreationOptions creationOptions)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task.InternalStartNew(internalCurrent, action, null, this.m_defaultCancellationToken, this.GetDefaultScheduler(internalCurrent), creationOptions, InternalTaskOptions.None);
		}

		/// <summary>Создает и запускает задачу <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <param name="action">Делегат действия для асинхронного выполнения.</param>
		/// <param name="cancellationToken">Токен <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" />, который будет назначен новой задаче <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <param name="creationOptions">Значение TaskCreationOptions, которое управляет поведением созданного объекта <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, который используется для планирования созданной задачи <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <returns>Запущенная задача <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Предоставленный объект <see cref="T:System.Threading.CancellationToken" /> уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="action" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="scheduler" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Дополнительные сведения см. в примечаниях к описанию <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" />.</exception>
		// Token: 0x060024BA RID: 9402 RVA: 0x0008343A File Offset: 0x0008163A
		public Task StartNew(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return Task.InternalStartNew(Task.InternalCurrentIfAttached(creationOptions), action, null, cancellationToken, scheduler, creationOptions, InternalTaskOptions.None);
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x0008344E File Offset: 0x0008164E
		internal Task StartNew(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			return Task.InternalStartNew(Task.InternalCurrentIfAttached(creationOptions), action, null, cancellationToken, scheduler, creationOptions, internalOptions);
		}

		/// <summary>Создает и запускает задачу <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <param name="action">Делегат действия для асинхронного выполнения.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="action" />.</param>
		/// <returns>Запущенная задача <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="action" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060024BC RID: 9404 RVA: 0x00083464 File Offset: 0x00081664
		public Task StartNew(Action<object> action, object state)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task.InternalStartNew(internalCurrent, action, state, this.m_defaultCancellationToken, this.GetDefaultScheduler(internalCurrent), this.m_defaultCreationOptions, InternalTaskOptions.None);
		}

		/// <summary>Создает и запускает задачу <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <param name="action">Делегат действия для асинхронного выполнения.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="action" />.</param>
		/// <param name="cancellationToken">Токен <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" />, который будет назначен новой задаче <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <returns>Запущенная задача <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Предоставленный объект <see cref="T:System.Threading.CancellationToken" /> уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="action" /> имеет значение NULL.</exception>
		// Token: 0x060024BD RID: 9405 RVA: 0x00083494 File Offset: 0x00081694
		public Task StartNew(Action<object> action, object state, CancellationToken cancellationToken)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task.InternalStartNew(internalCurrent, action, state, cancellationToken, this.GetDefaultScheduler(internalCurrent), this.m_defaultCreationOptions, InternalTaskOptions.None);
		}

		/// <summary>Создает и запускает задачу <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <param name="action">Делегат действия для асинхронного выполнения.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="action" />.</param>
		/// <param name="creationOptions">Значение TaskCreationOptions, которое управляет поведением созданного объекта <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <returns>Запущенная задача <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="action" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions.</exception>
		// Token: 0x060024BE RID: 9406 RVA: 0x000834C0 File Offset: 0x000816C0
		public Task StartNew(Action<object> action, object state, TaskCreationOptions creationOptions)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task.InternalStartNew(internalCurrent, action, state, this.m_defaultCancellationToken, this.GetDefaultScheduler(internalCurrent), creationOptions, InternalTaskOptions.None);
		}

		/// <summary>Создает и запускает задачу <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <param name="action">Делегат действия для асинхронного выполнения.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="action" />.</param>
		/// <param name="cancellationToken">Токен <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" />, который будет назначен новой задаче.</param>
		/// <param name="creationOptions">Значение TaskCreationOptions, которое управляет поведением созданного объекта <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, который используется для планирования созданной задачи <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <returns>Запущенная задача <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Предоставленный объект <see cref="T:System.Threading.CancellationToken" /> уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="action" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="scheduler" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Дополнительные сведения см. в примечаниях к описанию <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" />.</exception>
		// Token: 0x060024BF RID: 9407 RVA: 0x000834EA File Offset: 0x000816EA
		public Task StartNew(Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return Task.InternalStartNew(Task.InternalCurrentIfAttached(creationOptions), action, state, cancellationToken, scheduler, creationOptions, InternalTaskOptions.None);
		}

		/// <summary>Создает и запускает задачу <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="function">Делегат функции, возвращающий будущий результат с использованием <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TResult">Тип результата, доступный с использованием <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>Запущенная задача <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="function" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060024C0 RID: 9408 RVA: 0x00083500 File Offset: 0x00081700
		public Task<TResult> StartNew<TResult>(Func<TResult> function)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task<TResult>.StartNew(internalCurrent, function, this.m_defaultCancellationToken, this.m_defaultCreationOptions, InternalTaskOptions.None, this.GetDefaultScheduler(internalCurrent));
		}

		/// <summary>Создает и запускает задачу <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="function">Делегат функции, возвращающий будущий результат с использованием <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <param name="cancellationToken">Токен <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" />, который будет назначен новой задаче <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <typeparam name="TResult">Тип результата, доступный с использованием <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>Запущенная задача <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Предоставленный объект <see cref="T:System.Threading.CancellationToken" /> уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="function" /> имеет значение NULL.</exception>
		// Token: 0x060024C1 RID: 9409 RVA: 0x00083530 File Offset: 0x00081730
		public Task<TResult> StartNew<TResult>(Func<TResult> function, CancellationToken cancellationToken)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task<TResult>.StartNew(internalCurrent, function, cancellationToken, this.m_defaultCreationOptions, InternalTaskOptions.None, this.GetDefaultScheduler(internalCurrent));
		}

		/// <summary>Создает и запускает задачу <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="function">Делегат функции, возвращающий будущий результат с использованием <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <param name="creationOptions">Значение TaskCreationOptions, которое управляет поведением созданного объекта <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TResult">Тип результата, доступный с использованием <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>Запущенная задача <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="function" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Дополнительные сведения см. в примечаниях к описанию <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" />.</exception>
		// Token: 0x060024C2 RID: 9410 RVA: 0x0008355C File Offset: 0x0008175C
		public Task<TResult> StartNew<TResult>(Func<TResult> function, TaskCreationOptions creationOptions)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task<TResult>.StartNew(internalCurrent, function, this.m_defaultCancellationToken, creationOptions, InternalTaskOptions.None, this.GetDefaultScheduler(internalCurrent));
		}

		/// <summary>Создает и запускает задачу <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="function">Делегат функции, возвращающий будущий результат с использованием <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <param name="cancellationToken">Токен <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" />, который будет назначен новой задаче.</param>
		/// <param name="creationOptions">Значение TaskCreationOptions, которое управляет поведением созданного объекта <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, который используется для планирования созданной задачи <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TResult">Тип результата, доступный с использованием <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>Запущенная задача <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Предоставленный объект <see cref="T:System.Threading.CancellationToken" /> уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="function" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="scheduler" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Дополнительные сведения см. в примечаниях к описанию <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" />.</exception>
		// Token: 0x060024C3 RID: 9411 RVA: 0x00083585 File Offset: 0x00081785
		public Task<TResult> StartNew<TResult>(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return Task<TResult>.StartNew(Task.InternalCurrentIfAttached(creationOptions), function, cancellationToken, creationOptions, InternalTaskOptions.None, scheduler);
		}

		/// <summary>Создает и запускает задачу <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="function">Делегат функции, возвращающий будущий результат с использованием <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="function" />.</param>
		/// <typeparam name="TResult">Тип результата, доступный с использованием <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>Запущенная задача <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="function" /> имеет значение NULL.</exception>
		// Token: 0x060024C4 RID: 9412 RVA: 0x00083598 File Offset: 0x00081798
		public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task<TResult>.StartNew(internalCurrent, function, state, this.m_defaultCancellationToken, this.m_defaultCreationOptions, InternalTaskOptions.None, this.GetDefaultScheduler(internalCurrent));
		}

		/// <summary>Создает и запускает задачу <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="function">Делегат функции, возвращающий будущий результат с использованием <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="function" />.</param>
		/// <param name="cancellationToken">Токен <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" />, который будет назначен новой задаче <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <typeparam name="TResult">Тип результата, доступный с использованием <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>Запущенная задача <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Предоставленный объект <see cref="T:System.Threading.CancellationToken" /> уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="function" /> имеет значение NULL.</exception>
		// Token: 0x060024C5 RID: 9413 RVA: 0x000835C8 File Offset: 0x000817C8
		public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state, CancellationToken cancellationToken)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task<TResult>.StartNew(internalCurrent, function, state, cancellationToken, this.m_defaultCreationOptions, InternalTaskOptions.None, this.GetDefaultScheduler(internalCurrent));
		}

		/// <summary>Создает и запускает задачу <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="function">Делегат функции, возвращающий будущий результат с использованием <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="function" />.</param>
		/// <param name="creationOptions">Значение TaskCreationOptions, которое управляет поведением созданного объекта <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TResult">Тип результата, доступный с использованием <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>Запущенная задача <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="function" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Дополнительные сведения см. в примечаниях к описанию <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" />.</exception>
		// Token: 0x060024C6 RID: 9414 RVA: 0x000835F4 File Offset: 0x000817F4
		public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state, TaskCreationOptions creationOptions)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task<TResult>.StartNew(internalCurrent, function, state, this.m_defaultCancellationToken, creationOptions, InternalTaskOptions.None, this.GetDefaultScheduler(internalCurrent));
		}

		/// <summary>Создает и запускает задачу <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <param name="function">Делегат функции, возвращающий будущий результат с использованием <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="function" />.</param>
		/// <param name="cancellationToken">Токен <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" />, который будет назначен новой задаче.</param>
		/// <param name="creationOptions">Значение TaskCreationOptions, которое управляет поведением созданного объекта <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, который используется для планирования созданной задачи <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TResult">Тип результата, доступный с использованием <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>Запущенная задача <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Предоставленный объект <see cref="T:System.Threading.CancellationToken" /> уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="function" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="scheduler" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Дополнительные сведения см. в примечаниях к описанию <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" />.</exception>
		// Token: 0x060024C7 RID: 9415 RVA: 0x0008361E File Offset: 0x0008181E
		public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return Task<TResult>.StartNew(Task.InternalCurrentIfAttached(creationOptions), function, state, cancellationToken, creationOptions, InternalTaskOptions.None, scheduler);
		}

		/// <summary>Создает объект <see cref="T:System.Threading.Tasks.Task" />, который выполняет действие метода End по завершении заданного объекта <see cref="T:System.IAsyncResult" />.</summary>
		/// <param name="asyncResult">Интерфейс IAsyncResult, завершение выполнения которого инициирует обработку <paramref name="endMethod" />.</param>
		/// <param name="endMethod">Делегат действия, который обрабатывает завершенный результат <paramref name="asyncResult" />.</param>
		/// <returns>Объект <see cref="T:System.Threading.Tasks.Task" />, который представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="asyncResult" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="endMethod" /> имеет значение NULL.</exception>
		// Token: 0x060024C8 RID: 9416 RVA: 0x00083634 File Offset: 0x00081834
		public Task FromAsync(IAsyncResult asyncResult, Action<IAsyncResult> endMethod)
		{
			return this.FromAsync(asyncResult, endMethod, this.m_defaultCreationOptions, this.DefaultScheduler);
		}

		/// <summary>Создает объект <see cref="T:System.Threading.Tasks.Task" />, который выполняет действие метода End по завершении заданного объекта <see cref="T:System.IAsyncResult" />.</summary>
		/// <param name="asyncResult">Интерфейс IAsyncResult, завершение выполнения которого инициирует обработку <paramref name="endMethod" />.</param>
		/// <param name="endMethod">Делегат действия, который обрабатывает завершенный результат <paramref name="asyncResult" />.</param>
		/// <param name="creationOptions">Значение TaskCreationOptions, которое управляет поведением созданного объекта <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <returns>Объект <see cref="T:System.Threading.Tasks.Task" />, который представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="asyncResult" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="endMethod" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Дополнительные сведения см. в примечаниях к описанию <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" />.</exception>
		// Token: 0x060024C9 RID: 9417 RVA: 0x0008364A File Offset: 0x0008184A
		public Task FromAsync(IAsyncResult asyncResult, Action<IAsyncResult> endMethod, TaskCreationOptions creationOptions)
		{
			return this.FromAsync(asyncResult, endMethod, creationOptions, this.DefaultScheduler);
		}

		/// <summary>Создает объект <see cref="T:System.Threading.Tasks.Task" />, который выполняет действие метода End по завершении заданного объекта <see cref="T:System.IAsyncResult" />.</summary>
		/// <param name="asyncResult">Интерфейс IAsyncResult, завершение выполнения которого инициирует обработку <paramref name="endMethod" />.</param>
		/// <param name="endMethod">Делегат действия, который обрабатывает завершенный результат <paramref name="asyncResult" />.</param>
		/// <param name="creationOptions">Значение TaskCreationOptions, которое управляет поведением созданного объекта <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, который используется для планирования задачи, выполняющей метод end.</param>
		/// <returns>Созданный объект <see cref="T:System.Threading.Tasks.Task" />, который представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="asyncResult" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="endMethod" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="scheduler" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Дополнительные сведения см. в примечаниях к описанию <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" />.</exception>
		// Token: 0x060024CA RID: 9418 RVA: 0x0008365B File Offset: 0x0008185B
		public Task FromAsync(IAsyncResult asyncResult, Action<IAsyncResult> endMethod, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return TaskFactory<VoidTaskResult>.FromAsyncImpl(asyncResult, null, endMethod, creationOptions, scheduler);
		}

		/// <summary>Создает объект <see cref="T:System.Threading.Tasks.Task" />, который представляет пару методов begin и end, соответствующую шаблону модели асинхронного программирования.</summary>
		/// <param name="beginMethod">Делегат, который начинает асинхронную операцию.</param>
		/// <param name="endMethod">Делегат, который заканчивает асинхронную операцию.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="beginMethod" />.</param>
		/// <returns>Созданный объект <see cref="T:System.Threading.Tasks.Task" />, который представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="beginMethod" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="endMethod" /> имеет значение NULL.</exception>
		// Token: 0x060024CB RID: 9419 RVA: 0x00083668 File Offset: 0x00081868
		public Task FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, object state)
		{
			return this.FromAsync(beginMethod, endMethod, state, this.m_defaultCreationOptions);
		}

		/// <summary>Создает объект <see cref="T:System.Threading.Tasks.Task" />, который представляет пару методов begin и end, соответствующую шаблону модели асинхронного программирования.</summary>
		/// <param name="beginMethod">Делегат, который начинает асинхронную операцию.</param>
		/// <param name="endMethod">Делегат, который заканчивает асинхронную операцию.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="beginMethod" />.</param>
		/// <param name="creationOptions">Значение TaskCreationOptions, которое управляет поведением созданного объекта <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <returns>Созданный объект <see cref="T:System.Threading.Tasks.Task" />, который представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="beginMethod" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="endMethod" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions.</exception>
		// Token: 0x060024CC RID: 9420 RVA: 0x00083679 File Offset: 0x00081879
		public Task FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, object state, TaskCreationOptions creationOptions)
		{
			return TaskFactory<VoidTaskResult>.FromAsyncImpl(beginMethod, null, endMethod, state, creationOptions);
		}

		/// <summary>Создает объект <see cref="T:System.Threading.Tasks.Task" />, который представляет пару методов begin и end, соответствующую шаблону модели асинхронного программирования.</summary>
		/// <param name="beginMethod">Делегат, который начинает асинхронную операцию.</param>
		/// <param name="endMethod">Делегат, который заканчивает асинхронную операцию.</param>
		/// <param name="arg1">Первый аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="beginMethod" />.</param>
		/// <typeparam name="TArg1">Тип первого аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <returns>Созданный объект <see cref="T:System.Threading.Tasks.Task" />, который представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="beginMethod" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="endMethod" /> имеет значение NULL.</exception>
		// Token: 0x060024CD RID: 9421 RVA: 0x00083686 File Offset: 0x00081886
		public Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state)
		{
			return this.FromAsync<TArg1>(beginMethod, endMethod, arg1, state, this.m_defaultCreationOptions);
		}

		/// <summary>Создает объект <see cref="T:System.Threading.Tasks.Task" />, который представляет пару методов begin и end, соответствующую шаблону модели асинхронного программирования.</summary>
		/// <param name="beginMethod">Делегат, который начинает асинхронную операцию.</param>
		/// <param name="endMethod">Делегат, который заканчивает асинхронную операцию.</param>
		/// <param name="arg1">Первый аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="beginMethod" />.</param>
		/// <param name="creationOptions">Значение TaskCreationOptions, которое управляет поведением созданного объекта <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <typeparam name="TArg1">Тип первого аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <returns>Созданный объект <see cref="T:System.Threading.Tasks.Task" />, который представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="beginMethod" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="endMethod" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Дополнительные сведения см. в примечаниях к описанию <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" />.</exception>
		// Token: 0x060024CE RID: 9422 RVA: 0x00083699 File Offset: 0x00081899
		public Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions)
		{
			return TaskFactory<VoidTaskResult>.FromAsyncImpl<TArg1>(beginMethod, null, endMethod, arg1, state, creationOptions);
		}

		/// <summary>Создает объект <see cref="T:System.Threading.Tasks.Task" />, который представляет пару методов begin и end, соответствующую шаблону модели асинхронного программирования.</summary>
		/// <param name="beginMethod">Делегат, который начинает асинхронную операцию.</param>
		/// <param name="endMethod">Делегат, который заканчивает асинхронную операцию.</param>
		/// <param name="arg1">Первый аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="arg2">Второй аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="beginMethod" />.</param>
		/// <typeparam name="TArg1">Тип второго аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <typeparam name="TArg2">Тип первого аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <returns>Созданный объект <see cref="T:System.Threading.Tasks.Task" />, который представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="beginMethod" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="endMethod" /> имеет значение NULL.</exception>
		// Token: 0x060024CF RID: 9423 RVA: 0x000836A8 File Offset: 0x000818A8
		public Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state)
		{
			return this.FromAsync<TArg1, TArg2>(beginMethod, endMethod, arg1, arg2, state, this.m_defaultCreationOptions);
		}

		/// <summary>Создает объект <see cref="T:System.Threading.Tasks.Task" />, который представляет пару методов begin и end, соответствующую шаблону модели асинхронного программирования.</summary>
		/// <param name="beginMethod">Делегат, который начинает асинхронную операцию.</param>
		/// <param name="endMethod">Делегат, который заканчивает асинхронную операцию.</param>
		/// <param name="arg1">Первый аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="arg2">Второй аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="beginMethod" />.</param>
		/// <param name="creationOptions">Значение TaskCreationOptions, которое управляет поведением созданного объекта <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <typeparam name="TArg1">Тип второго аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <typeparam name="TArg2">Тип первого аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <returns>Созданный объект <see cref="T:System.Threading.Tasks.Task" />, который представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="beginMethod" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="endMethod" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Дополнительные сведения см. в примечаниях к описанию <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" />.</exception>
		// Token: 0x060024D0 RID: 9424 RVA: 0x000836BD File Offset: 0x000818BD
		public Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions)
		{
			return TaskFactory<VoidTaskResult>.FromAsyncImpl<TArg1, TArg2>(beginMethod, null, endMethod, arg1, arg2, state, creationOptions);
		}

		/// <summary>Создает объект <see cref="T:System.Threading.Tasks.Task" />, который представляет пару методов begin и end, соответствующую шаблону модели асинхронного программирования.</summary>
		/// <param name="beginMethod">Делегат, который начинает асинхронную операцию.</param>
		/// <param name="endMethod">Делегат, который заканчивает асинхронную операцию.</param>
		/// <param name="arg1">Первый аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="arg2">Второй аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="arg3">Третий аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="beginMethod" />.</param>
		/// <typeparam name="TArg1">Тип второго аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <typeparam name="TArg2">Тип третьего аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <typeparam name="TArg3">Тип первого аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <returns>Созданный объект <see cref="T:System.Threading.Tasks.Task" />, который представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="beginMethod" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="endMethod" /> имеет значение NULL.</exception>
		// Token: 0x060024D1 RID: 9425 RVA: 0x000836CE File Offset: 0x000818CE
		public Task FromAsync<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state)
		{
			return this.FromAsync<TArg1, TArg2, TArg3>(beginMethod, endMethod, arg1, arg2, arg3, state, this.m_defaultCreationOptions);
		}

		/// <summary>Создает объект <see cref="T:System.Threading.Tasks.Task" />, который представляет пару методов begin и end, соответствующую шаблону модели асинхронного программирования.</summary>
		/// <param name="beginMethod">Делегат, который начинает асинхронную операцию.</param>
		/// <param name="endMethod">Делегат, который заканчивает асинхронную операцию.</param>
		/// <param name="arg1">Первый аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="arg2">Второй аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="arg3">Третий аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="beginMethod" />.</param>
		/// <param name="creationOptions">Значение TaskCreationOptions, которое управляет поведением созданного объекта <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <typeparam name="TArg1">Тип второго аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <typeparam name="TArg2">Тип третьего аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <typeparam name="TArg3">Тип первого аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <returns>Созданный объект <see cref="T:System.Threading.Tasks.Task" />, который представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="beginMethod" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="endMethod" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Дополнительные сведения см. в примечаниях к описанию <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" />.</exception>
		// Token: 0x060024D2 RID: 9426 RVA: 0x000836E5 File Offset: 0x000818E5
		public Task FromAsync<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, TaskCreationOptions creationOptions)
		{
			return TaskFactory<VoidTaskResult>.FromAsyncImpl<TArg1, TArg2, TArg3>(beginMethod, null, endMethod, arg1, arg2, arg3, state, creationOptions);
		}

		/// <summary>Создает объект <see cref="T:System.Threading.Tasks.Task`1" />, который выполняет функцию метода End по завершении заданного объекта <see cref="T:System.IAsyncResult" />.</summary>
		/// <param name="asyncResult">Интерфейс IAsyncResult, завершение выполнения которого инициирует обработку <paramref name="endMethod" />.</param>
		/// <param name="endMethod">Делегат функции, который обрабатывает завершенный результат <paramref name="asyncResult" />.</param>
		/// <typeparam name="TResult">Тип результата, доступный с использованием <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>Объект <see cref="T:System.Threading.Tasks.Task`1" />, который представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="asyncResult" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="endMethod" /> имеет значение NULL.</exception>
		// Token: 0x060024D3 RID: 9427 RVA: 0x000836F8 File Offset: 0x000818F8
		public Task<TResult> FromAsync<TResult>(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod)
		{
			return TaskFactory<TResult>.FromAsyncImpl(asyncResult, endMethod, null, this.m_defaultCreationOptions, this.DefaultScheduler);
		}

		/// <summary>Создает объект <see cref="T:System.Threading.Tasks.Task`1" />, который выполняет функцию метода End по завершении заданного объекта <see cref="T:System.IAsyncResult" />.</summary>
		/// <param name="asyncResult">Интерфейс IAsyncResult, завершение выполнения которого инициирует обработку <paramref name="endMethod" />.</param>
		/// <param name="endMethod">Делегат функции, который обрабатывает завершенный результат <paramref name="asyncResult" />.</param>
		/// <param name="creationOptions">Значение TaskCreationOptions, которое управляет поведением созданного объекта <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TResult">Тип результата, доступный с использованием <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>Объект <see cref="T:System.Threading.Tasks.Task`1" />, который представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="asyncResult" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="endMethod" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Дополнительные сведения см. в примечаниях к описанию <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" />.</exception>
		// Token: 0x060024D4 RID: 9428 RVA: 0x0008370E File Offset: 0x0008190E
		public Task<TResult> FromAsync<TResult>(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions)
		{
			return TaskFactory<TResult>.FromAsyncImpl(asyncResult, endMethod, null, creationOptions, this.DefaultScheduler);
		}

		/// <summary>Создает объект <see cref="T:System.Threading.Tasks.Task`1" />, который выполняет функцию метода End по завершении заданного объекта <see cref="T:System.IAsyncResult" />.</summary>
		/// <param name="asyncResult">Интерфейс IAsyncResult, завершение выполнения которого инициирует обработку <paramref name="endMethod" />.</param>
		/// <param name="endMethod">Делегат функции, который обрабатывает завершенный результат <paramref name="asyncResult" />.</param>
		/// <param name="creationOptions">Значение TaskCreationOptions, которое управляет поведением созданного объекта <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, который используется для планирования задачи, выполняющей метод end.</param>
		/// <typeparam name="TResult">Тип результата, доступный с использованием <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>Объект <see cref="T:System.Threading.Tasks.Task`1" />, который представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="asyncResult" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="endMethod" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="scheduler" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Дополнительные сведения см. в примечаниях к описанию <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" />.</exception>
		// Token: 0x060024D5 RID: 9429 RVA: 0x0008371F File Offset: 0x0008191F
		public Task<TResult> FromAsync<TResult>(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return TaskFactory<TResult>.FromAsyncImpl(asyncResult, endMethod, null, creationOptions, scheduler);
		}

		/// <summary>Создает объект <see cref="T:System.Threading.Tasks.Task`1" />, который представляет пару методов begin и end, соответствующую шаблону модели асинхронного программирования.</summary>
		/// <param name="beginMethod">Делегат, который начинает асинхронную операцию.</param>
		/// <param name="endMethod">Делегат, который заканчивает асинхронную операцию.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="beginMethod" />.</param>
		/// <typeparam name="TResult">Тип результата, доступный с использованием <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>Созданный объект <see cref="T:System.Threading.Tasks.Task`1" />, который представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="beginMethod" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="endMethod" /> имеет значение NULL.</exception>
		// Token: 0x060024D6 RID: 9430 RVA: 0x0008372C File Offset: 0x0008192C
		public Task<TResult> FromAsync<TResult>(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state)
		{
			return TaskFactory<TResult>.FromAsyncImpl(beginMethod, endMethod, null, state, this.m_defaultCreationOptions);
		}

		/// <summary>Создает объект <see cref="T:System.Threading.Tasks.Task`1" />, который представляет пару методов begin и end, соответствующую шаблону модели асинхронного программирования.</summary>
		/// <param name="beginMethod">Делегат, который начинает асинхронную операцию.</param>
		/// <param name="endMethod">Делегат, который заканчивает асинхронную операцию.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="beginMethod" />.</param>
		/// <param name="creationOptions">Значение TaskCreationOptions, которое управляет поведением созданного объекта <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TResult">Тип результата, доступный с использованием <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>Созданный объект <see cref="T:System.Threading.Tasks.Task`1" />, который представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="beginMethod" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="endMethod" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Дополнительные сведения см. в примечаниях к описанию <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" />.</exception>
		// Token: 0x060024D7 RID: 9431 RVA: 0x0008373D File Offset: 0x0008193D
		public Task<TResult> FromAsync<TResult>(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state, TaskCreationOptions creationOptions)
		{
			return TaskFactory<TResult>.FromAsyncImpl(beginMethod, endMethod, null, state, creationOptions);
		}

		/// <summary>Создает объект <see cref="T:System.Threading.Tasks.Task`1" />, который представляет пару методов begin и end, соответствующую шаблону модели асинхронного программирования.</summary>
		/// <param name="beginMethod">Делегат, который начинает асинхронную операцию.</param>
		/// <param name="endMethod">Делегат, который заканчивает асинхронную операцию.</param>
		/// <param name="arg1">Первый аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="beginMethod" />.</param>
		/// <typeparam name="TArg1">Тип первого аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <typeparam name="TResult">Тип результата, доступный с использованием <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>Созданный объект <see cref="T:System.Threading.Tasks.Task`1" />, который представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="beginMethod" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="endMethod" /> имеет значение NULL.</exception>
		// Token: 0x060024D8 RID: 9432 RVA: 0x0008374A File Offset: 0x0008194A
		public Task<TResult> FromAsync<TArg1, TResult>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state)
		{
			return TaskFactory<TResult>.FromAsyncImpl<TArg1>(beginMethod, endMethod, null, arg1, state, this.m_defaultCreationOptions);
		}

		/// <summary>Создает объект <see cref="T:System.Threading.Tasks.Task`1" />, который представляет пару методов begin и end, соответствующую шаблону модели асинхронного программирования.</summary>
		/// <param name="beginMethod">Делегат, который начинает асинхронную операцию.</param>
		/// <param name="endMethod">Делегат, который заканчивает асинхронную операцию.</param>
		/// <param name="arg1">Первый аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="beginMethod" />.</param>
		/// <param name="creationOptions">Значение TaskCreationOptions, которое управляет поведением созданного объекта <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TArg1">Тип первого аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <typeparam name="TResult">Тип результата, доступный с использованием <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>Созданный объект <see cref="T:System.Threading.Tasks.Task`1" />, который представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="beginMethod" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="endMethod" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Дополнительные сведения см. в примечаниях к описанию <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" />.</exception>
		// Token: 0x060024D9 RID: 9433 RVA: 0x0008375D File Offset: 0x0008195D
		public Task<TResult> FromAsync<TArg1, TResult>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions)
		{
			return TaskFactory<TResult>.FromAsyncImpl<TArg1>(beginMethod, endMethod, null, arg1, state, creationOptions);
		}

		/// <summary>Создает объект <see cref="T:System.Threading.Tasks.Task`1" />, который представляет пару методов begin и end, соответствующую шаблону модели асинхронного программирования.</summary>
		/// <param name="beginMethod">Делегат, который начинает асинхронную операцию.</param>
		/// <param name="endMethod">Делегат, который заканчивает асинхронную операцию.</param>
		/// <param name="arg1">Первый аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="arg2">Второй аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="beginMethod" />.</param>
		/// <typeparam name="TArg1">Тип второго аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <typeparam name="TArg2">Тип первого аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <typeparam name="TResult">Тип результата, доступный с использованием <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>Созданный объект <see cref="T:System.Threading.Tasks.Task`1" />, который представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="beginMethod" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="endMethod" /> имеет значение NULL.</exception>
		// Token: 0x060024DA RID: 9434 RVA: 0x0008376C File Offset: 0x0008196C
		public Task<TResult> FromAsync<TArg1, TArg2, TResult>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state)
		{
			return TaskFactory<TResult>.FromAsyncImpl<TArg1, TArg2>(beginMethod, endMethod, null, arg1, arg2, state, this.m_defaultCreationOptions);
		}

		/// <summary>Создает объект <see cref="T:System.Threading.Tasks.Task`1" />, который представляет пару методов begin и end, соответствующую шаблону модели асинхронного программирования.</summary>
		/// <param name="beginMethod">Делегат, который начинает асинхронную операцию.</param>
		/// <param name="endMethod">Делегат, который заканчивает асинхронную операцию.</param>
		/// <param name="arg1">Первый аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="arg2">Второй аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="beginMethod" />.</param>
		/// <param name="creationOptions">Значение TaskCreationOptions, которое управляет поведением созданного объекта <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TArg1">Тип второго аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <typeparam name="TArg2">Тип первого аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <typeparam name="TResult">Тип результата, доступный с использованием <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>Созданный объект <see cref="T:System.Threading.Tasks.Task`1" />, который представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="beginMethod" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="endMethod" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Дополнительные сведения см. в примечаниях к описанию <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" />.</exception>
		// Token: 0x060024DB RID: 9435 RVA: 0x00083781 File Offset: 0x00081981
		public Task<TResult> FromAsync<TArg1, TArg2, TResult>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions)
		{
			return TaskFactory<TResult>.FromAsyncImpl<TArg1, TArg2>(beginMethod, endMethod, null, arg1, arg2, state, creationOptions);
		}

		/// <summary>Создает объект <see cref="T:System.Threading.Tasks.Task`1" />, который представляет пару методов begin и end, соответствующую шаблону модели асинхронного программирования.</summary>
		/// <param name="beginMethod">Делегат, который начинает асинхронную операцию.</param>
		/// <param name="endMethod">Делегат, который заканчивает асинхронную операцию.</param>
		/// <param name="arg1">Первый аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="arg2">Второй аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="arg3">Третий аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="beginMethod" />.</param>
		/// <typeparam name="TArg1">Тип второго аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <typeparam name="TArg2">Тип третьего аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <typeparam name="TArg3">Тип первого аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <typeparam name="TResult">Тип результата, доступный с использованием <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>Созданный объект <see cref="T:System.Threading.Tasks.Task`1" />, который представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="beginMethod" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="endMethod" /> имеет значение NULL.</exception>
		// Token: 0x060024DC RID: 9436 RVA: 0x00083792 File Offset: 0x00081992
		public Task<TResult> FromAsync<TArg1, TArg2, TArg3, TResult>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state)
		{
			return TaskFactory<TResult>.FromAsyncImpl<TArg1, TArg2, TArg3>(beginMethod, endMethod, null, arg1, arg2, arg3, state, this.m_defaultCreationOptions);
		}

		/// <summary>Создает объект <see cref="T:System.Threading.Tasks.Task`1" />, который представляет пару методов begin и end, соответствующую шаблону модели асинхронного программирования.</summary>
		/// <param name="beginMethod">Делегат, который начинает асинхронную операцию.</param>
		/// <param name="endMethod">Делегат, который заканчивает асинхронную операцию.</param>
		/// <param name="arg1">Первый аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="arg2">Второй аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="arg3">Третий аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="beginMethod" />.</param>
		/// <param name="creationOptions">Значение TaskCreationOptions, которое управляет поведением созданного объекта <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TArg1">Тип второго аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <typeparam name="TArg2">Тип третьего аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <typeparam name="TArg3">Тип первого аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <typeparam name="TResult">Тип результата, доступный с использованием <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>Созданный объект <see cref="T:System.Threading.Tasks.Task`1" />, который представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое вызывается, когда аргумент <paramref name="beginMethod" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="endMethod" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Исключение, которое возникает, когда аргумент <paramref name="creationOptions" /> задает недопустимое значение TaskCreationOptions. Дополнительные сведения см. в примечаниях к описанию <see cref="M:System.Threading.Tasks.TaskFactory.FromAsync(System.Func{System.AsyncCallback,System.Object,System.IAsyncResult},System.Action{System.IAsyncResult},System.Object,System.Threading.Tasks.TaskCreationOptions)" />.</exception>
		// Token: 0x060024DD RID: 9437 RVA: 0x000837A9 File Offset: 0x000819A9
		public Task<TResult> FromAsync<TArg1, TArg2, TArg3, TResult>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, TaskCreationOptions creationOptions)
		{
			return TaskFactory<TResult>.FromAsyncImpl<TArg1, TArg2, TArg3>(beginMethod, endMethod, null, arg1, arg2, arg3, state, creationOptions);
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x000837BC File Offset: 0x000819BC
		internal static void CheckFromAsyncOptions(TaskCreationOptions creationOptions, bool hasBeginMethod)
		{
			if (hasBeginMethod)
			{
				if ((creationOptions & TaskCreationOptions.LongRunning) != TaskCreationOptions.None)
				{
					throw new ArgumentOutOfRangeException("creationOptions", "It is invalid to specify TaskCreationOptions.LongRunning in calls to FromAsync.");
				}
				if ((creationOptions & TaskCreationOptions.PreferFairness) != TaskCreationOptions.None)
				{
					throw new ArgumentOutOfRangeException("creationOptions", "It is invalid to specify TaskCreationOptions.PreferFairness in calls to FromAsync.");
				}
			}
			if ((creationOptions & ~(TaskCreationOptions.PreferFairness | TaskCreationOptions.LongRunning | TaskCreationOptions.AttachedToParent | TaskCreationOptions.DenyChildAttach | TaskCreationOptions.HideScheduler)) != TaskCreationOptions.None)
			{
				throw new ArgumentOutOfRangeException("creationOptions");
			}
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x000837FC File Offset: 0x000819FC
		internal static Task<Task[]> CommonCWAllLogic(Task[] tasksCopy)
		{
			TaskFactory.CompleteOnCountdownPromise completeOnCountdownPromise = new TaskFactory.CompleteOnCountdownPromise(tasksCopy);
			for (int i = 0; i < tasksCopy.Length; i++)
			{
				if (tasksCopy[i].IsCompleted)
				{
					completeOnCountdownPromise.Invoke(tasksCopy[i]);
				}
				else
				{
					tasksCopy[i].AddCompletionAction(completeOnCountdownPromise);
				}
			}
			return completeOnCountdownPromise;
		}

		// Token: 0x060024E0 RID: 9440 RVA: 0x00083840 File Offset: 0x00081A40
		internal static Task<Task<T>[]> CommonCWAllLogic<T>(Task<T>[] tasksCopy)
		{
			TaskFactory.CompleteOnCountdownPromise<T> completeOnCountdownPromise = new TaskFactory.CompleteOnCountdownPromise<T>(tasksCopy);
			for (int i = 0; i < tasksCopy.Length; i++)
			{
				if (tasksCopy[i].IsCompleted)
				{
					completeOnCountdownPromise.Invoke(tasksCopy[i]);
				}
				else
				{
					tasksCopy[i].AddCompletionAction(completeOnCountdownPromise);
				}
			}
			return completeOnCountdownPromise;
		}

		/// <summary>Создает задачу продолжения, которая запускается при завершении набора заданных задач.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено.</param>
		/// <param name="continuationAction">Делегат действия для выполнения после завершения выполнения всех задач в массиве <paramref name="tasks" />.</param>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationAction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> является пустым или содержит значение NULL.</exception>
		// Token: 0x060024E1 RID: 9441 RVA: 0x00083881 File Offset: 0x00081A81
		public Task ContinueWhenAll(Task[] tasks, Action<Task[]> continuationAction)
		{
			if (continuationAction == null)
			{
				throw new ArgumentNullException("continuationAction");
			}
			return TaskFactory<VoidTaskResult>.ContinueWhenAllImpl(tasks, continuationAction, this.m_defaultContinuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает задачу продолжения, которая запускается при завершении набора заданных задач.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено.</param>
		/// <param name="continuationAction">Делегат действия для выполнения после завершения выполнения всех задач в массиве <paramref name="tasks" />.</param>
		/// <param name="cancellationToken">Токен отмены для присвоения новой задаче продолжения.</param>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.  
		///
		/// или - 
		/// Класс <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationAction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> является пустым или содержит значение NULL.</exception>
		// Token: 0x060024E2 RID: 9442 RVA: 0x000838AA File Offset: 0x00081AAA
		public Task ContinueWhenAll(Task[] tasks, Action<Task[]> continuationAction, CancellationToken cancellationToken)
		{
			if (continuationAction == null)
			{
				throw new ArgumentNullException("continuationAction");
			}
			return TaskFactory<VoidTaskResult>.ContinueWhenAllImpl(tasks, continuationAction, this.m_defaultContinuationOptions, cancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает задачу продолжения, которая запускается при завершении набора заданных задач.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено.</param>
		/// <param name="continuationAction">Делегат действия для выполнения после завершения выполнения всех задач в массиве <paramref name="tasks" />.</param>
		/// <param name="continuationOptions">Побитовое сочетание значений перечисления, которые управляют поведением новой задачи продолжения. Члены NotOn* и OnlyOn* не поддерживаются.</param>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationAction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> указывает недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> является пустым или содержит значение NULL.</exception>
		// Token: 0x060024E3 RID: 9443 RVA: 0x000838CE File Offset: 0x00081ACE
		public Task ContinueWhenAll(Task[] tasks, Action<Task[]> continuationAction, TaskContinuationOptions continuationOptions)
		{
			if (continuationAction == null)
			{
				throw new ArgumentNullException("continuationAction");
			}
			return TaskFactory<VoidTaskResult>.ContinueWhenAllImpl(tasks, continuationAction, continuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает задачу продолжения, которая запускается при завершении набора заданных задач.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено.</param>
		/// <param name="continuationAction">Делегат действия для выполнения после завершения выполнения всех задач в массиве <paramref name="tasks" />.</param>
		/// <param name="cancellationToken">Токен отмены для присвоения новой задаче продолжения.</param>
		/// <param name="continuationOptions">Побитовое сочетание значений перечисления, которые управляют поведением новой задачи продолжения.</param>
		/// <param name="scheduler">Объект, который используется для планирования новой задачи продолжения.</param>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationAction" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="scheduler" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> является пустым или содержит значение NULL.</exception>
		// Token: 0x060024E4 RID: 9444 RVA: 0x000838F2 File Offset: 0x00081AF2
		public Task ContinueWhenAll(Task[] tasks, Action<Task[]> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			if (continuationAction == null)
			{
				throw new ArgumentNullException("continuationAction");
			}
			return TaskFactory<VoidTaskResult>.ContinueWhenAllImpl(tasks, continuationAction, continuationOptions, cancellationToken, scheduler);
		}

		/// <summary>Создает задачу продолжения, которая запускается при завершении набора заданных задач.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено.</param>
		/// <param name="continuationAction">Делегат действия для выполнения после завершения выполнения всех задач в массиве <paramref name="tasks" />.</param>
		/// <typeparam name="TAntecedentResult">Тип результата предыдущего объекта <paramref name="tasks" />.</typeparam>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationAction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> является пустым или содержит значение NULL.</exception>
		// Token: 0x060024E5 RID: 9445 RVA: 0x0008390E File Offset: 0x00081B0E
		public Task ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>[]> continuationAction)
		{
			if (continuationAction == null)
			{
				throw new ArgumentNullException("continuationAction");
			}
			return TaskFactory<VoidTaskResult>.ContinueWhenAllImpl<TAntecedentResult>(tasks, continuationAction, this.m_defaultContinuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает задачу продолжения, которая запускается при завершении набора заданных задач.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено.</param>
		/// <param name="continuationAction">Делегат действия для выполнения после завершения выполнения всех задач в массиве <paramref name="tasks" />.</param>
		/// <param name="cancellationToken">Токен отмены для присвоения новой задаче продолжения.</param>
		/// <typeparam name="TAntecedentResult">Тип результата предыдущего объекта <paramref name="tasks" />.</typeparam>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.  
		///
		/// или - 
		/// Класс <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationAction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> является пустым или содержит значение NULL.</exception>
		// Token: 0x060024E6 RID: 9446 RVA: 0x00083937 File Offset: 0x00081B37
		public Task ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>[]> continuationAction, CancellationToken cancellationToken)
		{
			if (continuationAction == null)
			{
				throw new ArgumentNullException("continuationAction");
			}
			return TaskFactory<VoidTaskResult>.ContinueWhenAllImpl<TAntecedentResult>(tasks, continuationAction, this.m_defaultContinuationOptions, cancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает задачу продолжения, которая запускается при завершении набора заданных задач.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено.</param>
		/// <param name="continuationAction">Делегат действия для выполнения после завершения выполнения всех задач в массиве <paramref name="tasks" />.</param>
		/// <param name="continuationOptions">Побитовое сочетание значений перечисления, которые управляют поведением новой задачи продолжения. Члены NotOn* и OnlyOn* не поддерживаются.</param>
		/// <typeparam name="TAntecedentResult">Тип результата предыдущего объекта <paramref name="tasks" />.</typeparam>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationAction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> указывает недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> является пустым или содержит значение NULL.</exception>
		// Token: 0x060024E7 RID: 9447 RVA: 0x0008395B File Offset: 0x00081B5B
		public Task ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>[]> continuationAction, TaskContinuationOptions continuationOptions)
		{
			if (continuationAction == null)
			{
				throw new ArgumentNullException("continuationAction");
			}
			return TaskFactory<VoidTaskResult>.ContinueWhenAllImpl<TAntecedentResult>(tasks, continuationAction, continuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает задачу продолжения, которая запускается при завершении набора заданных задач.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено.</param>
		/// <param name="continuationAction">Делегат действия для выполнения после завершения выполнения всех задач в массиве <paramref name="tasks" />.</param>
		/// <param name="cancellationToken">Токен отмены для присвоения новой задаче продолжения.</param>
		/// <param name="continuationOptions">Побитовое сочетание значений перечисления, которые управляют поведением новой задачи продолжения. Члены NotOn* и OnlyOn* не поддерживаются.</param>
		/// <param name="scheduler">Объект, который используется для планирования новой задачи продолжения.</param>
		/// <typeparam name="TAntecedentResult">Тип результата предыдущего объекта <paramref name="tasks" />.</typeparam>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationAction" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="scheduler" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> является пустым или содержит значение NULL.</exception>
		// Token: 0x060024E8 RID: 9448 RVA: 0x0008397F File Offset: 0x00081B7F
		public Task ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>[]> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			if (continuationAction == null)
			{
				throw new ArgumentNullException("continuationAction");
			}
			return TaskFactory<VoidTaskResult>.ContinueWhenAllImpl<TAntecedentResult>(tasks, continuationAction, continuationOptions, cancellationToken, scheduler);
		}

		/// <summary>Создает задачу продолжения, которая запускается при завершении набора заданных задач.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения всех задач в массиве <paramref name="tasks" />.</param>
		/// <typeparam name="TResult">Тип результата, возвращенного делегатом <paramref name="continuationFunction" /> и связанного с созданной задачей.</typeparam>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationFunction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> является пустым или содержит значение NULL.</exception>
		// Token: 0x060024E9 RID: 9449 RVA: 0x0008399B File Offset: 0x00081B9B
		public Task<TResult> ContinueWhenAll<TResult>(Task[] tasks, Func<Task[], TResult> continuationFunction)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAllImpl(tasks, continuationFunction, this.m_defaultContinuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает задачу продолжения, которая запускается при завершении набора заданных задач.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения всех задач в массиве <paramref name="tasks" />.</param>
		/// <param name="cancellationToken">Токен отмены для присвоения новой задаче продолжения.</param>
		/// <typeparam name="TResult">Тип результата, возвращенного делегатом <paramref name="continuationFunction" /> и связанного с созданной задачей.</typeparam>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.  
		///
		/// или - 
		/// Класс <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationFunction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> является пустым или содержит значение NULL.</exception>
		// Token: 0x060024EA RID: 9450 RVA: 0x000839C4 File Offset: 0x00081BC4
		public Task<TResult> ContinueWhenAll<TResult>(Task[] tasks, Func<Task[], TResult> continuationFunction, CancellationToken cancellationToken)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAllImpl(tasks, continuationFunction, this.m_defaultContinuationOptions, cancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает задачу продолжения, которая запускается при завершении набора заданных задач.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения всех задач в массиве <paramref name="tasks" />.</param>
		/// <param name="continuationOptions">Побитовое сочетание значений перечисления, которые управляют поведением новой задачи продолжения. Члены NotOn* и OnlyOn* не поддерживаются.</param>
		/// <typeparam name="TResult">Тип результата, возвращенного делегатом <paramref name="continuationFunction" /> и связанного с созданной задачей.</typeparam>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationFunction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> указывает недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> является пустым или содержит значение NULL.</exception>
		// Token: 0x060024EB RID: 9451 RVA: 0x000839E8 File Offset: 0x00081BE8
		public Task<TResult> ContinueWhenAll<TResult>(Task[] tasks, Func<Task[], TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAllImpl(tasks, continuationFunction, continuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает задачу продолжения, которая запускается при завершении набора заданных задач.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения всех задач в массиве <paramref name="tasks" />.</param>
		/// <param name="cancellationToken">Токен отмены для присвоения новой задаче продолжения.</param>
		/// <param name="continuationOptions">Побитовое сочетание значений перечисления, которые управляют поведением новой задачи продолжения. Члены NotOn* и OnlyOn* не поддерживаются.</param>
		/// <param name="scheduler">Объект, который используется для планирования новой задачи продолжения.</param>
		/// <typeparam name="TResult">Тип результата, возвращенного делегатом <paramref name="continuationFunction" /> и связанного с созданной задачей.</typeparam>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationFunction" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="scheduler" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> является пустым или содержит значение NULL.</exception>
		// Token: 0x060024EC RID: 9452 RVA: 0x00083A0C File Offset: 0x00081C0C
		public Task<TResult> ContinueWhenAll<TResult>(Task[] tasks, Func<Task[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAllImpl(tasks, continuationFunction, continuationOptions, cancellationToken, scheduler);
		}

		/// <summary>Создает задачу продолжения, которая запускается при завершении набора заданных задач.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения всех задач в массиве <paramref name="tasks" />.</param>
		/// <typeparam name="TAntecedentResult">Тип результата предыдущего объекта <paramref name="tasks" />.</typeparam>
		/// <typeparam name="TResult">Тип результата, возвращенного делегатом <paramref name="continuationFunction" /> и связанного с созданной задачей.</typeparam>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationFunction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> является пустым или содержит значение NULL.</exception>
		// Token: 0x060024ED RID: 9453 RVA: 0x00083A28 File Offset: 0x00081C28
		public Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAllImpl<TAntecedentResult>(tasks, continuationFunction, this.m_defaultContinuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает задачу продолжения, которая запускается при завершении набора заданных задач.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения всех задач в массиве <paramref name="tasks" />.</param>
		/// <param name="cancellationToken">Токен отмены для присвоения новой задаче продолжения.</param>
		/// <typeparam name="TAntecedentResult">Тип результата предыдущего объекта <paramref name="tasks" />.</typeparam>
		/// <typeparam name="TResult">Тип результата, возвращенного делегатом <paramref name="continuationFunction" /> и связанного с созданной задачей.</typeparam>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.  
		///
		/// или - 
		/// Класс <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationFunction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> является пустым или содержит значение NULL.</exception>
		// Token: 0x060024EE RID: 9454 RVA: 0x00083A51 File Offset: 0x00081C51
		public Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAllImpl<TAntecedentResult>(tasks, continuationFunction, this.m_defaultContinuationOptions, cancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает задачу продолжения, которая запускается при завершении набора заданных задач.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения всех задач в массиве <paramref name="tasks" />.</param>
		/// <param name="continuationOptions">Побитовое сочетание значений перечисления, которые управляют поведением новой задачи продолжения. Члены NotOn* и OnlyOn* не поддерживаются.</param>
		/// <typeparam name="TAntecedentResult">Тип результата предыдущего объекта <paramref name="tasks" />.</typeparam>
		/// <typeparam name="TResult">Тип результата, возвращенного делегатом <paramref name="continuationFunction" /> и связанного с созданной задачей.</typeparam>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationFunction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> указывает недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> является пустым или содержит значение NULL.</exception>
		// Token: 0x060024EF RID: 9455 RVA: 0x00083A75 File Offset: 0x00081C75
		public Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAllImpl<TAntecedentResult>(tasks, continuationFunction, continuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает задачу продолжения, которая запускается при завершении набора заданных задач.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения всех задач в массиве <paramref name="tasks" />.</param>
		/// <param name="cancellationToken">Токен отмены для присвоения новой задаче продолжения.</param>
		/// <param name="continuationOptions">Побитовое сочетание значений перечисления, которые управляют поведением новой задачи продолжения. Члены NotOn* и OnlyOn* не поддерживаются.</param>
		/// <param name="scheduler">Объект, который используется для планирования новой задачи продолжения.</param>
		/// <typeparam name="TAntecedentResult">Тип результата предыдущего объекта <paramref name="tasks" />.</typeparam>
		/// <typeparam name="TResult">Тип результата, возвращенного делегатом <paramref name="continuationFunction" /> и связанного с созданной задачей.</typeparam>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationFunction" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="scheduler" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> является пустым или содержит значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> указывает недопустимое значение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.  
		///
		/// или - 
		/// Класс <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, уже удален.</exception>
		// Token: 0x060024F0 RID: 9456 RVA: 0x00083A99 File Offset: 0x00081C99
		public Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAllImpl<TAntecedentResult>(tasks, continuationFunction, continuationOptions, cancellationToken, scheduler);
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x00083AB8 File Offset: 0x00081CB8
		internal static Task<Task> CommonCWAnyLogic(IList<Task> tasks)
		{
			TaskFactory.CompleteOnInvokePromise completeOnInvokePromise = new TaskFactory.CompleteOnInvokePromise(tasks);
			bool flag = false;
			int count = tasks.Count;
			for (int i = 0; i < count; i++)
			{
				Task task = tasks[i];
				if (task == null)
				{
					throw new ArgumentException("The tasks argument included a null value.", "tasks");
				}
				if (!flag)
				{
					if (completeOnInvokePromise.IsCompleted)
					{
						flag = true;
					}
					else if (task.IsCompleted)
					{
						completeOnInvokePromise.Invoke(task);
						flag = true;
					}
					else
					{
						task.AddCompletionAction(completeOnInvokePromise);
						if (completeOnInvokePromise.IsCompleted)
						{
							task.RemoveContinuation(completeOnInvokePromise);
						}
					}
				}
			}
			return completeOnInvokePromise;
		}

		/// <summary>Создает продолжение задачи <see cref="T:System.Threading.Tasks.Task" />, которое будет запущено после завершения выполнения любой задачи в указанном наборе.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено после завершения выполнения одной задачи.</param>
		/// <param name="continuationAction">Делегат действия для выполнения после завершения выполнения одной задачи в массиве <paramref name="tasks" />.</param>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationAction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> содержит значение <see langword="null" />.  
		///
		/// или - 
		/// Массив <paramref name="tasks" /> является пустым.</exception>
		// Token: 0x060024F2 RID: 9458 RVA: 0x00083B3B File Offset: 0x00081D3B
		public Task ContinueWhenAny(Task[] tasks, Action<Task> continuationAction)
		{
			if (continuationAction == null)
			{
				throw new ArgumentNullException("continuationAction");
			}
			return TaskFactory<VoidTaskResult>.ContinueWhenAnyImpl(tasks, continuationAction, this.m_defaultContinuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает продолжение задачи <see cref="T:System.Threading.Tasks.Task" />, которое будет запущено после завершения выполнения любой задачи в указанном наборе.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено после завершения выполнения одной задачи.</param>
		/// <param name="continuationAction">Делегат действия для выполнения после завершения выполнения одной задачи в массиве <paramref name="tasks" />.</param>
		/// <param name="cancellationToken">Токен <see cref="T:System.Threading.CancellationToken" />, который будет назначен новой задаче продолжения.</param>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.  
		///
		/// или - 
		/// Объект <paramref name="cancellationToken" /> уже был удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationAction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> содержит значение <see langword="null" />.  
		///
		/// или - 
		/// Массив <paramref name="tasks" /> является пустым.</exception>
		// Token: 0x060024F3 RID: 9459 RVA: 0x00083B64 File Offset: 0x00081D64
		public Task ContinueWhenAny(Task[] tasks, Action<Task> continuationAction, CancellationToken cancellationToken)
		{
			if (continuationAction == null)
			{
				throw new ArgumentNullException("continuationAction");
			}
			return TaskFactory<VoidTaskResult>.ContinueWhenAnyImpl(tasks, continuationAction, this.m_defaultContinuationOptions, cancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает продолжение задачи <see cref="T:System.Threading.Tasks.Task" />, которое будет запущено после завершения выполнения любой задачи в указанном наборе.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено после завершения выполнения одной задачи.</param>
		/// <param name="continuationAction">Делегат действия для выполнения после завершения выполнения одной задачи в массиве <paramref name="tasks" />.</param>
		/// <param name="continuationOptions">Значение <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />, которое управляет поведением созданной задачи продолжения <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Исключение, которое возникает, когда один из элементов в массиве <paramref name="tasks" /> был удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое возникает, когда массив <paramref name="tasks" /> равен null.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="continuationAction" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Исключение, которое возникает, когда аргумент <paramref name="continuationOptions" /> задает недопустимое значение TaskContinuationOptions.</exception>
		/// <exception cref="T:System.ArgumentException">Исключение, которое возникает, когда массив <paramref name="tasks" /> содержит значение null.  
		///
		/// или - 
		/// Исключение, которое возникает, когда массив <paramref name="tasks" /> пуст.</exception>
		// Token: 0x060024F4 RID: 9460 RVA: 0x00083B88 File Offset: 0x00081D88
		public Task ContinueWhenAny(Task[] tasks, Action<Task> continuationAction, TaskContinuationOptions continuationOptions)
		{
			if (continuationAction == null)
			{
				throw new ArgumentNullException("continuationAction");
			}
			return TaskFactory<VoidTaskResult>.ContinueWhenAnyImpl(tasks, continuationAction, continuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает продолжение задачи <see cref="T:System.Threading.Tasks.Task" />, которое будет запущено после завершения выполнения любой задачи в указанном наборе.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено после завершения выполнения одной задачи.</param>
		/// <param name="continuationAction">Делегат действия для выполнения после завершения выполнения одной задачи в массиве <paramref name="tasks" />.</param>
		/// <param name="cancellationToken">Токен <see cref="T:System.Threading.CancellationToken" />, который будет назначен новой задаче продолжения.</param>
		/// <param name="continuationOptions">Значение <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />, которое управляет поведением созданной задачи продолжения <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, который используется для планирования созданной задачи продолжения <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое возникает, когда массив <paramref name="tasks" /> равен null.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="continuationAction" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="scheduler" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentException">Исключение, которое возникает, когда массив <paramref name="tasks" /> содержит значение null.  
		///
		/// или - 
		/// Исключение, которое возникает, когда массив <paramref name="tasks" /> пуст.</exception>
		// Token: 0x060024F5 RID: 9461 RVA: 0x00083BAC File Offset: 0x00081DAC
		public Task ContinueWhenAny(Task[] tasks, Action<Task> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			if (continuationAction == null)
			{
				throw new ArgumentNullException("continuationAction");
			}
			return TaskFactory<VoidTaskResult>.ContinueWhenAnyImpl(tasks, continuationAction, continuationOptions, cancellationToken, scheduler);
		}

		/// <summary>Создает продолжение задачи <see cref="T:System.Threading.Tasks.Task`1" />, которое будет запущено после завершения выполнения любой задачи в указанном наборе.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено после завершения выполнения одной задачи.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения одной задачи в массиве <paramref name="tasks" />.</param>
		/// <typeparam name="TResult">Тип результата, возвращенного делегатом <paramref name="continuationFunction" /> и связанного с созданным объектом <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Исключение, которое возникает, когда один из элементов в массиве <paramref name="tasks" /> был удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое возникает, когда массив <paramref name="tasks" /> равен null.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="continuationFunction" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentException">Исключение, которое возникает, когда массив <paramref name="tasks" /> содержит значение null.  
		///
		/// или - 
		/// Исключение, которое возникает, когда массив <paramref name="tasks" /> пуст.</exception>
		// Token: 0x060024F6 RID: 9462 RVA: 0x00083BC8 File Offset: 0x00081DC8
		public Task<TResult> ContinueWhenAny<TResult>(Task[] tasks, Func<Task, TResult> continuationFunction)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAnyImpl(tasks, continuationFunction, this.m_defaultContinuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает продолжение задачи <see cref="T:System.Threading.Tasks.Task`1" />, которое будет запущено после завершения выполнения любой задачи в указанном наборе.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено после завершения выполнения одной задачи.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения одной задачи в массиве <paramref name="tasks" />.</param>
		/// <param name="cancellationToken">Токен <see cref="T:System.Threading.CancellationToken" />, который будет назначен новой задаче продолжения.</param>
		/// <typeparam name="TResult">Тип результата, возвращенного делегатом <paramref name="continuationFunction" /> и связанного с созданным объектом <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Исключение, которое возникает, когда один из элементов в массиве <paramref name="tasks" /> был удален.  
		///
		/// или - 
		/// Предоставленный объект <see cref="T:System.Threading.CancellationToken" /> уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое возникает, когда массив <paramref name="tasks" /> равен null.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="continuationFunction" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentException">Исключение, которое возникает, когда массив <paramref name="tasks" /> содержит значение null.  
		///
		/// или - 
		/// Исключение, которое возникает, когда массив <paramref name="tasks" /> пуст.</exception>
		// Token: 0x060024F7 RID: 9463 RVA: 0x00083BF1 File Offset: 0x00081DF1
		public Task<TResult> ContinueWhenAny<TResult>(Task[] tasks, Func<Task, TResult> continuationFunction, CancellationToken cancellationToken)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAnyImpl(tasks, continuationFunction, this.m_defaultContinuationOptions, cancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает продолжение задачи <see cref="T:System.Threading.Tasks.Task`1" />, которое будет запущено после завершения выполнения любой задачи в указанном наборе.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено после завершения выполнения одной задачи.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения одной задачи в массиве <paramref name="tasks" />.</param>
		/// <param name="continuationOptions">Значение <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />, которое управляет поведением созданной задачи продолжения <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TResult">Тип результата, возвращенного делегатом <paramref name="continuationFunction" /> и связанного с созданным объектом <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Исключение, которое возникает, когда один из элементов в массиве <paramref name="tasks" /> был удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое возникает, когда массив <paramref name="tasks" /> равен null.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="continuationFunction" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Исключение, которое возникает, когда аргумент <paramref name="continuationOptions" /> задает недопустимое значение TaskContinuationOptions.</exception>
		/// <exception cref="T:System.ArgumentException">Исключение, которое возникает, когда массив <paramref name="tasks" /> содержит значение null.  
		///
		/// или - 
		/// Исключение, которое возникает, когда массив <paramref name="tasks" /> пуст.</exception>
		// Token: 0x060024F8 RID: 9464 RVA: 0x00083C15 File Offset: 0x00081E15
		public Task<TResult> ContinueWhenAny<TResult>(Task[] tasks, Func<Task, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAnyImpl(tasks, continuationFunction, continuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает продолжение задачи <see cref="T:System.Threading.Tasks.Task`1" />, которое будет запущено после завершения выполнения любой задачи в указанном наборе.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено после завершения выполнения одной задачи.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения одной задачи в массиве <paramref name="tasks" />.</param>
		/// <param name="cancellationToken">Токен <see cref="T:System.Threading.CancellationToken" />, который будет назначен новой задаче продолжения.</param>
		/// <param name="continuationOptions">Значение <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />, которое управляет поведением созданной задачи продолжения <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, который используется для планирования созданной задачи продолжения <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TResult">Тип результата, возвращенного делегатом <paramref name="continuationFunction" /> и связанного с созданным объектом <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое возникает, когда массив <paramref name="tasks" /> равен null.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="continuationFunction" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="scheduler" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentException">Исключение, которое возникает, когда массив <paramref name="tasks" /> содержит значение null.  
		///
		/// или - 
		/// Исключение, которое возникает, когда массив <paramref name="tasks" /> пуст.</exception>
		// Token: 0x060024F9 RID: 9465 RVA: 0x00083C39 File Offset: 0x00081E39
		public Task<TResult> ContinueWhenAny<TResult>(Task[] tasks, Func<Task, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAnyImpl(tasks, continuationFunction, continuationOptions, cancellationToken, scheduler);
		}

		/// <summary>Создает продолжение задачи <see cref="T:System.Threading.Tasks.Task`1" />, которое будет запущено после завершения выполнения любой задачи в указанном наборе.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено после завершения выполнения одной задачи.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения одной задачи в массиве <paramref name="tasks" />.</param>
		/// <typeparam name="TAntecedentResult">Тип результата предыдущего объекта <paramref name="tasks" />.</typeparam>
		/// <typeparam name="TResult">Тип результата, возвращенного делегатом <paramref name="continuationFunction" /> и связанного с созданным объектом <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Исключение, которое возникает, когда один из элементов в массиве <paramref name="tasks" /> был удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое возникает, когда массив <paramref name="tasks" /> равен null.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="continuationFunction" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentException">Исключение, которое возникает, когда массив <paramref name="tasks" /> содержит значение null.  
		///
		/// или - 
		/// Исключение, которое возникает, когда массив <paramref name="tasks" /> пуст.</exception>
		// Token: 0x060024FA RID: 9466 RVA: 0x00083C55 File Offset: 0x00081E55
		public Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAnyImpl<TAntecedentResult>(tasks, continuationFunction, this.m_defaultContinuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает продолжение задачи <see cref="T:System.Threading.Tasks.Task`1" />, которое будет запущено после завершения выполнения любой задачи в указанном наборе.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено после завершения выполнения одной задачи.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения одной задачи в массиве <paramref name="tasks" />.</param>
		/// <param name="cancellationToken">Токен <see cref="T:System.Threading.CancellationToken" />, который будет назначен новой задаче продолжения.</param>
		/// <typeparam name="TAntecedentResult">Тип результата предыдущего объекта <paramref name="tasks" />.</typeparam>
		/// <typeparam name="TResult">Тип результата, возвращенного делегатом <paramref name="continuationFunction" /> и связанного с созданным объектом <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Исключение, которое возникает, когда один из элементов в массиве <paramref name="tasks" /> был удален.  
		///
		/// или - 
		/// Предоставленный объект <see cref="T:System.Threading.CancellationToken" /> уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое возникает, когда массив <paramref name="tasks" /> равен null.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="continuationFunction" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentException">Исключение, которое возникает, когда массив <paramref name="tasks" /> содержит значение null.  
		///
		/// или - 
		/// Исключение, которое возникает, когда массив <paramref name="tasks" /> пуст.</exception>
		// Token: 0x060024FB RID: 9467 RVA: 0x00083C7E File Offset: 0x00081E7E
		public Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAnyImpl<TAntecedentResult>(tasks, continuationFunction, this.m_defaultContinuationOptions, cancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает продолжение задачи <see cref="T:System.Threading.Tasks.Task`1" />, которое будет запущено после завершения выполнения любой задачи в указанном наборе.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено после завершения выполнения одной задачи.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения одной задачи в массиве <paramref name="tasks" />.</param>
		/// <param name="continuationOptions">Значение <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />, которое управляет поведением созданной задачи продолжения <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TAntecedentResult">Тип результата предыдущего объекта <paramref name="tasks" />.</typeparam>
		/// <typeparam name="TResult">Тип результата, возвращенного делегатом <paramref name="continuationFunction" /> и связанного с созданным объектом <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Исключение, которое возникает, когда один из элементов в массиве <paramref name="tasks" /> был удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое возникает, когда массив <paramref name="tasks" /> равен null.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="continuationFunction" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Исключение, которое возникает, когда аргумент <paramref name="continuationOptions" /> задает недопустимое значение TaskContinuationOptions.</exception>
		/// <exception cref="T:System.ArgumentException">Исключение, которое возникает, когда массив <paramref name="tasks" /> содержит значение null.  
		///
		/// или - 
		/// Исключение, которое возникает, когда массив <paramref name="tasks" /> пуст.</exception>
		// Token: 0x060024FC RID: 9468 RVA: 0x00083CA2 File Offset: 0x00081EA2
		public Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAnyImpl<TAntecedentResult>(tasks, continuationFunction, continuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает продолжение задачи <see cref="T:System.Threading.Tasks.Task`1" />, которое будет запущено после завершения выполнения любой задачи в указанном наборе.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено после завершения выполнения одной задачи.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения одной задачи в массиве <paramref name="tasks" />.</param>
		/// <param name="cancellationToken">Токен <see cref="T:System.Threading.CancellationToken" />, который будет назначен новой задаче продолжения.</param>
		/// <param name="continuationOptions">Значение <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />, которое управляет поведением созданной задачи продолжения <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, который используется для планирования созданной задачи продолжения <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TAntecedentResult">Тип результата предыдущего объекта <paramref name="tasks" />.</typeparam>
		/// <typeparam name="TResult">Тип результата, возвращенного делегатом <paramref name="continuationFunction" /> и связанного с созданным объектом <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое возникает, когда массив <paramref name="tasks" /> равен null.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="continuationFunction" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="scheduler" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentException">Исключение, которое возникает, когда массив <paramref name="tasks" /> содержит значение null.  
		///
		/// или - 
		/// Исключение, которое возникает, когда массив <paramref name="tasks" /> пуст.</exception>
		// Token: 0x060024FD RID: 9469 RVA: 0x00083CC6 File Offset: 0x00081EC6
		public Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAnyImpl<TAntecedentResult>(tasks, continuationFunction, continuationOptions, cancellationToken, scheduler);
		}

		/// <summary>Создает продолжение задачи <see cref="T:System.Threading.Tasks.Task" />, которое будет запущено после завершения выполнения любой задачи в указанном наборе.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено после завершения выполнения одной задачи.</param>
		/// <param name="continuationAction">Делегат действия для выполнения после завершения выполнения одной задачи в массиве <paramref name="tasks" />.</param>
		/// <typeparam name="TAntecedentResult">Тип результата предыдущего объекта <paramref name="tasks" />.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Исключение, которое возникает, когда один из элементов в массиве <paramref name="tasks" /> был удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое возникает, когда массив <paramref name="tasks" /> равен null.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="continuationAction" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentException">Исключение, которое возникает, когда массив <paramref name="tasks" /> содержит значение null.  
		///
		/// или - 
		/// Исключение, которое возникает, когда массив <paramref name="tasks" /> пуст.</exception>
		// Token: 0x060024FE RID: 9470 RVA: 0x00083CE2 File Offset: 0x00081EE2
		public Task ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>> continuationAction)
		{
			if (continuationAction == null)
			{
				throw new ArgumentNullException("continuationAction");
			}
			return TaskFactory<VoidTaskResult>.ContinueWhenAnyImpl<TAntecedentResult>(tasks, continuationAction, this.m_defaultContinuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает продолжение задачи <see cref="T:System.Threading.Tasks.Task" />, которое будет запущено после завершения выполнения любой задачи в указанном наборе.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено после завершения выполнения одной задачи.</param>
		/// <param name="continuationAction">Делегат действия для выполнения после завершения выполнения одной задачи в массиве <paramref name="tasks" />.</param>
		/// <param name="cancellationToken">Токен <see cref="T:System.Threading.CancellationToken" />, который будет назначен новой задаче продолжения.</param>
		/// <typeparam name="TAntecedentResult">Тип результата предыдущего объекта <paramref name="tasks" />.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Исключение, которое возникает, когда один из элементов в массиве <paramref name="tasks" /> был удален.  
		///
		/// или - 
		/// Предоставленный объект <see cref="T:System.Threading.CancellationToken" /> уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое возникает, когда массив <paramref name="tasks" /> равен null.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="continuationAction" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentException">Исключение, которое возникает, когда массив <paramref name="tasks" /> содержит значение null.  
		///
		/// или - 
		/// Исключение, которое возникает, когда массив <paramref name="tasks" /> пуст.</exception>
		// Token: 0x060024FF RID: 9471 RVA: 0x00083D0B File Offset: 0x00081F0B
		public Task ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>> continuationAction, CancellationToken cancellationToken)
		{
			if (continuationAction == null)
			{
				throw new ArgumentNullException("continuationAction");
			}
			return TaskFactory<VoidTaskResult>.ContinueWhenAnyImpl<TAntecedentResult>(tasks, continuationAction, this.m_defaultContinuationOptions, cancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает продолжение задачи <see cref="T:System.Threading.Tasks.Task" />, которое будет запущено после завершения выполнения любой задачи в указанном наборе.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено после завершения выполнения одной задачи.</param>
		/// <param name="continuationAction">Делегат действия для выполнения после завершения выполнения одной задачи в массиве <paramref name="tasks" />.</param>
		/// <param name="continuationOptions">Значение <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />, которое управляет поведением созданной задачи продолжения <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <typeparam name="TAntecedentResult">Тип результата предыдущего объекта <paramref name="tasks" />.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Исключение, которое возникает, когда один из элементов в массиве <paramref name="tasks" /> был удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое возникает, когда массив <paramref name="tasks" /> равен null.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="continuationAction" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Исключение, которое возникает, когда аргумент <paramref name="continuationOptions" /> задает недопустимое значение TaskContinuationOptions.</exception>
		/// <exception cref="T:System.ArgumentException">Исключение, которое возникает, когда массив <paramref name="tasks" /> содержит значение null.  
		///
		/// или - 
		/// Исключение, которое возникает, когда массив <paramref name="tasks" /> пуст.</exception>
		// Token: 0x06002500 RID: 9472 RVA: 0x00083D2F File Offset: 0x00081F2F
		public Task ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>> continuationAction, TaskContinuationOptions continuationOptions)
		{
			if (continuationAction == null)
			{
				throw new ArgumentNullException("continuationAction");
			}
			return TaskFactory<VoidTaskResult>.ContinueWhenAnyImpl<TAntecedentResult>(tasks, continuationAction, continuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает продолжение задачи <see cref="T:System.Threading.Tasks.Task" />, которое будет запущено после завершения выполнения любой задачи в указанном наборе.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено после завершения выполнения одной задачи.</param>
		/// <param name="continuationAction">Делегат действия для выполнения после завершения выполнения одной задачи в массиве <paramref name="tasks" />.</param>
		/// <param name="cancellationToken">Токен <see cref="T:System.Threading.CancellationToken" />, который будет назначен новой задаче продолжения.</param>
		/// <param name="continuationOptions">Значение <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />, которое управляет поведением созданной задачи продолжения <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, который используется для планирования созданной задачи продолжения <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TAntecedentResult">Тип результата предыдущего объекта <paramref name="tasks" />.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Исключение, которое возникает, когда массив <paramref name="tasks" /> равен null.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="continuationAction" /> имеет значение NULL.  
		///
		/// или - 
		/// Исключение, которое вызывается, когда аргумент <paramref name="scheduler" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentException">Исключение, которое возникает, когда массив <paramref name="tasks" /> содержит значение null.  
		///
		/// или - 
		/// Исключение, которое возникает, когда массив <paramref name="tasks" /> пуст.</exception>
		// Token: 0x06002501 RID: 9473 RVA: 0x00083D53 File Offset: 0x00081F53
		public Task ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			if (continuationAction == null)
			{
				throw new ArgumentNullException("continuationAction");
			}
			return TaskFactory<VoidTaskResult>.ContinueWhenAnyImpl<TAntecedentResult>(tasks, continuationAction, continuationOptions, cancellationToken, scheduler);
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x00083D70 File Offset: 0x00081F70
		internal static Task[] CheckMultiContinuationTasksAndCopy(Task[] tasks)
		{
			if (tasks == null)
			{
				throw new ArgumentNullException("tasks");
			}
			if (tasks.Length == 0)
			{
				throw new ArgumentException("The tasks argument contains no tasks.", "tasks");
			}
			Task[] array = new Task[tasks.Length];
			for (int i = 0; i < tasks.Length; i++)
			{
				array[i] = tasks[i];
				if (array[i] == null)
				{
					throw new ArgumentException("The tasks argument included a null value.", "tasks");
				}
			}
			return array;
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x00083DD4 File Offset: 0x00081FD4
		internal static Task<TResult>[] CheckMultiContinuationTasksAndCopy<TResult>(Task<TResult>[] tasks)
		{
			if (tasks == null)
			{
				throw new ArgumentNullException("tasks");
			}
			if (tasks.Length == 0)
			{
				throw new ArgumentException("The tasks argument contains no tasks.", "tasks");
			}
			Task<TResult>[] array = new Task<TResult>[tasks.Length];
			for (int i = 0; i < tasks.Length; i++)
			{
				array[i] = tasks[i];
				if (array[i] == null)
				{
					throw new ArgumentException("The tasks argument included a null value.", "tasks");
				}
			}
			return array;
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x00083E38 File Offset: 0x00082038
		internal static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions)
		{
			if ((continuationOptions & (TaskContinuationOptions.LongRunning | TaskContinuationOptions.ExecuteSynchronously)) == (TaskContinuationOptions.LongRunning | TaskContinuationOptions.ExecuteSynchronously))
			{
				throw new ArgumentOutOfRangeException("continuationOptions", "The specified TaskContinuationOptions combined LongRunning and ExecuteSynchronously.  Synchronous continuations should not be long running.");
			}
			if ((continuationOptions & ~(TaskContinuationOptions.PreferFairness | TaskContinuationOptions.LongRunning | TaskContinuationOptions.AttachedToParent | TaskContinuationOptions.DenyChildAttach | TaskContinuationOptions.HideScheduler | TaskContinuationOptions.LazyCancellation | TaskContinuationOptions.NotOnRanToCompletion | TaskContinuationOptions.NotOnFaulted | TaskContinuationOptions.NotOnCanceled | TaskContinuationOptions.ExecuteSynchronously)) != TaskContinuationOptions.None)
			{
				throw new ArgumentOutOfRangeException("continuationOptions");
			}
			if ((continuationOptions & (TaskContinuationOptions.NotOnRanToCompletion | TaskContinuationOptions.NotOnFaulted | TaskContinuationOptions.NotOnCanceled)) != TaskContinuationOptions.None)
			{
				throw new ArgumentOutOfRangeException("continuationOptions", "It is invalid to exclude specific continuation kinds for continuations off of multiple tasks.");
			}
		}

		// Token: 0x04001D44 RID: 7492
		private readonly CancellationToken m_defaultCancellationToken;

		// Token: 0x04001D45 RID: 7493
		private readonly TaskScheduler m_defaultScheduler;

		// Token: 0x04001D46 RID: 7494
		private readonly TaskCreationOptions m_defaultCreationOptions;

		// Token: 0x04001D47 RID: 7495
		private readonly TaskContinuationOptions m_defaultContinuationOptions;

		// Token: 0x02000376 RID: 886
		private sealed class CompleteOnCountdownPromise : Task<Task[]>, ITaskCompletionAction
		{
			// Token: 0x06002505 RID: 9477 RVA: 0x00083E90 File Offset: 0x00082090
			internal CompleteOnCountdownPromise(Task[] tasksCopy)
			{
				this._tasks = tasksCopy;
				this._count = tasksCopy.Length;
				if (DebuggerSupport.LoggingOn)
				{
					DebuggerSupport.TraceOperationCreation(CausalityTraceLevel.Required, this, "TaskFactory.ContinueWhenAll", 0UL);
				}
				DebuggerSupport.AddToActiveTasks(this);
			}

			// Token: 0x06002506 RID: 9478 RVA: 0x00083EC4 File Offset: 0x000820C4
			public void Invoke(Task completingTask)
			{
				if (DebuggerSupport.LoggingOn)
				{
					DebuggerSupport.TraceOperationRelation(CausalityTraceLevel.Important, this, CausalityRelation.Join);
				}
				if (completingTask.IsWaitNotificationEnabled)
				{
					base.SetNotificationForWaitCompletion(true);
				}
				if (Interlocked.Decrement(ref this._count) == 0)
				{
					if (DebuggerSupport.LoggingOn)
					{
						DebuggerSupport.TraceOperationCompletion(CausalityTraceLevel.Required, this, AsyncStatus.Completed);
					}
					DebuggerSupport.RemoveFromActiveTasks(this);
					base.TrySetResult(this._tasks);
				}
			}

			// Token: 0x17000473 RID: 1139
			// (get) Token: 0x06002507 RID: 9479 RVA: 0x000040F7 File Offset: 0x000022F7
			public bool InvokeMayRunArbitraryCode
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000474 RID: 1140
			// (get) Token: 0x06002508 RID: 9480 RVA: 0x00083F1E File Offset: 0x0008211E
			internal override bool ShouldNotifyDebuggerOfWaitCompletion
			{
				get
				{
					return base.ShouldNotifyDebuggerOfWaitCompletion && Task.AnyTaskRequiresNotifyDebuggerOfWaitCompletion(this._tasks);
				}
			}

			// Token: 0x04001D48 RID: 7496
			private readonly Task[] _tasks;

			// Token: 0x04001D49 RID: 7497
			private int _count;
		}

		// Token: 0x02000377 RID: 887
		private sealed class CompleteOnCountdownPromise<T> : Task<Task<T>[]>, ITaskCompletionAction
		{
			// Token: 0x06002509 RID: 9481 RVA: 0x00083F35 File Offset: 0x00082135
			internal CompleteOnCountdownPromise(Task<T>[] tasksCopy)
			{
				this._tasks = tasksCopy;
				this._count = tasksCopy.Length;
				if (DebuggerSupport.LoggingOn)
				{
					DebuggerSupport.TraceOperationCreation(CausalityTraceLevel.Required, this, "TaskFactory.ContinueWhenAll<>", 0UL);
				}
				DebuggerSupport.AddToActiveTasks(this);
			}

			// Token: 0x0600250A RID: 9482 RVA: 0x00083F68 File Offset: 0x00082168
			public void Invoke(Task completingTask)
			{
				if (DebuggerSupport.LoggingOn)
				{
					DebuggerSupport.TraceOperationRelation(CausalityTraceLevel.Important, this, CausalityRelation.Join);
				}
				if (completingTask.IsWaitNotificationEnabled)
				{
					base.SetNotificationForWaitCompletion(true);
				}
				if (Interlocked.Decrement(ref this._count) == 0)
				{
					if (DebuggerSupport.LoggingOn)
					{
						DebuggerSupport.TraceOperationCompletion(CausalityTraceLevel.Required, this, AsyncStatus.Completed);
					}
					DebuggerSupport.RemoveFromActiveTasks(this);
					base.TrySetResult(this._tasks);
				}
			}

			// Token: 0x17000475 RID: 1141
			// (get) Token: 0x0600250B RID: 9483 RVA: 0x000040F7 File Offset: 0x000022F7
			public bool InvokeMayRunArbitraryCode
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000476 RID: 1142
			// (get) Token: 0x0600250C RID: 9484 RVA: 0x00083FC4 File Offset: 0x000821C4
			internal override bool ShouldNotifyDebuggerOfWaitCompletion
			{
				get
				{
					if (base.ShouldNotifyDebuggerOfWaitCompletion)
					{
						Task[] tasks = this._tasks;
						return Task.AnyTaskRequiresNotifyDebuggerOfWaitCompletion(tasks);
					}
					return false;
				}
			}

			// Token: 0x04001D4A RID: 7498
			private readonly Task<T>[] _tasks;

			// Token: 0x04001D4B RID: 7499
			private int _count;
		}

		// Token: 0x02000378 RID: 888
		internal sealed class CompleteOnInvokePromise : Task<Task>, ITaskCompletionAction
		{
			// Token: 0x0600250D RID: 9485 RVA: 0x00083FE8 File Offset: 0x000821E8
			public CompleteOnInvokePromise(IList<Task> tasks)
			{
				this._tasks = tasks;
				if (DebuggerSupport.LoggingOn)
				{
					DebuggerSupport.TraceOperationCreation(CausalityTraceLevel.Required, this, "TaskFactory.ContinueWhenAny", 0UL);
				}
				DebuggerSupport.AddToActiveTasks(this);
			}

			// Token: 0x0600250E RID: 9486 RVA: 0x00084014 File Offset: 0x00082214
			public void Invoke(Task completingTask)
			{
				if (base.TrySetResult(completingTask))
				{
					if (DebuggerSupport.LoggingOn)
					{
						DebuggerSupport.TraceOperationRelation(CausalityTraceLevel.Important, this, CausalityRelation.Choice);
						DebuggerSupport.TraceOperationCompletion(CausalityTraceLevel.Required, this, AsyncStatus.Completed);
					}
					DebuggerSupport.RemoveFromActiveTasks(this);
					IList<Task> tasks = this._tasks;
					int count = tasks.Count;
					for (int i = 0; i < count; i++)
					{
						Task task = tasks[i];
						if (task != null && !task.IsCompleted)
						{
							task.RemoveContinuation(this);
						}
					}
					this._tasks = null;
				}
			}

			// Token: 0x17000477 RID: 1143
			// (get) Token: 0x0600250F RID: 9487 RVA: 0x000040F7 File Offset: 0x000022F7
			public bool InvokeMayRunArbitraryCode
			{
				get
				{
					return true;
				}
			}

			// Token: 0x04001D4C RID: 7500
			private IList<Task> _tasks;
		}
	}
}
