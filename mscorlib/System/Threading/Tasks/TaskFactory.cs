using System;
using Internal.Runtime.Augments;

namespace System.Threading.Tasks
{
	/// <summary>Предоставляет поддержку создания и планирования объектов <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
	/// <typeparam name="TResult">Возвращаемое значение объектов <see cref="T:System.Threading.Tasks.Task`1" />, созданных методами этого класса.</typeparam>
	// Token: 0x02000343 RID: 835
	public class TaskFactory<TResult>
	{
		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x060022FF RID: 8959 RVA: 0x0007D5ED File Offset: 0x0007B7ED
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

		// Token: 0x06002300 RID: 8960 RVA: 0x0007D603 File Offset: 0x0007B803
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

		/// <summary>Инициализирует экземпляр <see cref="T:System.Threading.Tasks.TaskFactory`1" /> с конфигурацией по умолчанию.</summary>
		// Token: 0x06002301 RID: 8961 RVA: 0x0007D630 File Offset: 0x0007B830
		public TaskFactory() : this(default(CancellationToken), TaskCreationOptions.None, TaskContinuationOptions.None, null)
		{
		}

		/// <summary>Инициализирует экземпляр <see cref="T:System.Threading.Tasks.TaskFactory`1" /> с конфигурацией по умолчанию.</summary>
		/// <param name="cancellationToken">Токен отмены по умолчанию, который будет назначен задачам, созданным данной фабрикой <see cref="T:System.Threading.Tasks.TaskFactory" />, если при вызове методов фабрики не задан явно другой токен отмены.</param>
		// Token: 0x06002302 RID: 8962 RVA: 0x0007D64F File Offset: 0x0007B84F
		public TaskFactory(CancellationToken cancellationToken) : this(cancellationToken, TaskCreationOptions.None, TaskContinuationOptions.None, null)
		{
		}

		/// <summary>Инициализирует экземпляр <see cref="T:System.Threading.Tasks.TaskFactory`1" /> с заданной конфигурацией.</summary>
		/// <param name="scheduler">Планировщик, который нужно использовать при планировании задач, созданных с помощью данной фабрики <see cref="T:System.Threading.Tasks.TaskFactory`1" />. Значение NULL означает, что следует использовать текущий объект <see cref="T:System.Threading.Tasks.TaskScheduler" />.</param>
		// Token: 0x06002303 RID: 8963 RVA: 0x0007D65C File Offset: 0x0007B85C
		public TaskFactory(TaskScheduler scheduler) : this(default(CancellationToken), TaskCreationOptions.None, TaskContinuationOptions.None, scheduler)
		{
		}

		/// <summary>Инициализирует экземпляр <see cref="T:System.Threading.Tasks.TaskFactory`1" /> с заданной конфигурацией.</summary>
		/// <param name="creationOptions">Параметры по умолчанию, которые необходимо использовать при создании задач данной фабрикой <see cref="T:System.Threading.Tasks.TaskFactory`1" />.</param>
		/// <param name="continuationOptions">Параметры по умолчанию, которые необходимо использовать при создании задач продолжения данной фабрикой <see cref="T:System.Threading.Tasks.TaskFactory`1" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="creationOptions" /> или <paramref name="continuationOptions" /> имеет недопустимое значение.</exception>
		// Token: 0x06002304 RID: 8964 RVA: 0x0007D67C File Offset: 0x0007B87C
		public TaskFactory(TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions) : this(default(CancellationToken), creationOptions, continuationOptions, null)
		{
		}

		/// <summary>Инициализирует экземпляр <see cref="T:System.Threading.Tasks.TaskFactory`1" /> с заданной конфигурацией.</summary>
		/// <param name="cancellationToken">Токен отмены по умолчанию, который будет назначен задачам, созданным данной фабрикой <see cref="T:System.Threading.Tasks.TaskFactory" />, если при вызове методов фабрики не задан явно другой токен отмены.</param>
		/// <param name="creationOptions">Параметры по умолчанию, которые необходимо использовать при создании задач данной фабрикой <see cref="T:System.Threading.Tasks.TaskFactory`1" />.</param>
		/// <param name="continuationOptions">Параметры по умолчанию, которые необходимо использовать при создании задач продолжения данной фабрикой <see cref="T:System.Threading.Tasks.TaskFactory`1" />.</param>
		/// <param name="scheduler">Планировщик по умолчанию, который нужно использовать при планировании задач, созданных с помощью данной фабрики <see cref="T:System.Threading.Tasks.TaskFactory`1" />. Значение NULL указывает на то, что должно использоваться <see cref="P:System.Threading.Tasks.TaskScheduler.Current" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="creationOptions" /> или <paramref name="continuationOptions" /> имеет недопустимое значение.</exception>
		// Token: 0x06002305 RID: 8965 RVA: 0x0007D69B File Offset: 0x0007B89B
		public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			TaskFactory.CheckMultiTaskContinuationOptions(continuationOptions);
			TaskFactory.CheckCreationOptions(creationOptions);
			this.m_defaultCancellationToken = cancellationToken;
			this.m_defaultScheduler = scheduler;
			this.m_defaultCreationOptions = creationOptions;
			this.m_defaultContinuationOptions = continuationOptions;
		}

		/// <summary>Возвращает токен отмены по умолчанию для этой фабрики задач.</summary>
		/// <returns>Токен отмены по умолчанию для этой фабрики задач.</returns>
		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06002306 RID: 8966 RVA: 0x0007D6CC File Offset: 0x0007B8CC
		public CancellationToken CancellationToken
		{
			get
			{
				return this.m_defaultCancellationToken;
			}
		}

		/// <summary>Возвращает планировщик задач для этой фабрики задач.</summary>
		/// <returns>Планировщик задач для этой фабрики задач.</returns>
		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06002307 RID: 8967 RVA: 0x0007D6D4 File Offset: 0x0007B8D4
		public TaskScheduler Scheduler
		{
			get
			{
				return this.m_defaultScheduler;
			}
		}

		/// <summary>Возвращает значение перечисления <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> для этой фабрики задач.</summary>
		/// <returns>Одно из значений перечисления, которое задает параметры создания по умолчанию для этой фабрики задач.</returns>
		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06002308 RID: 8968 RVA: 0x0007D6DC File Offset: 0x0007B8DC
		public TaskCreationOptions CreationOptions
		{
			get
			{
				return this.m_defaultCreationOptions;
			}
		}

		/// <summary>Возвращает значение перечисления <see cref="T:System.Threading.Tasks.TaskContinuationOptions" /> для этой фабрики задач.</summary>
		/// <returns>Одно из значений перечисления, которое задает параметры продолжения по умолчанию для этой фабрики задач.</returns>
		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06002309 RID: 8969 RVA: 0x0007D6E4 File Offset: 0x0007B8E4
		public TaskContinuationOptions ContinuationOptions
		{
			get
			{
				return this.m_defaultContinuationOptions;
			}
		}

		/// <summary>Создает и запускает задачу.</summary>
		/// <param name="function">Делегат функции, возвращающий будущий результат с использованием задачи.</param>
		/// <returns>Запущенная задача.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="function" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600230A RID: 8970 RVA: 0x0007D6EC File Offset: 0x0007B8EC
		public Task<TResult> StartNew(Func<TResult> function)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task<TResult>.StartNew(internalCurrent, function, this.m_defaultCancellationToken, this.m_defaultCreationOptions, InternalTaskOptions.None, this.GetDefaultScheduler(internalCurrent));
		}

		/// <summary>Создает и запускает задачу.</summary>
		/// <param name="function">Делегат функции, возвращающий будущий результат с использованием задачи.</param>
		/// <param name="cancellationToken">Токен отмены, который будет назначен новой задаче.</param>
		/// <returns>Запущенная задача.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Источник токена отмены, создавший <paramref name="cancellationToken" />, был удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="function" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600230B RID: 8971 RVA: 0x0007D71C File Offset: 0x0007B91C
		public Task<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task<TResult>.StartNew(internalCurrent, function, cancellationToken, this.m_defaultCreationOptions, InternalTaskOptions.None, this.GetDefaultScheduler(internalCurrent));
		}

		/// <summary>Создает и запускает задачу.</summary>
		/// <param name="function">Делегат функции, возвращающий будущий результат с использованием задачи.</param>
		/// <param name="creationOptions">Одно из значений перечисления, которое управляет поведением созданной задачи.</param>
		/// <returns>Запущенная задача <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="function" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="creationOptions" /> задает недопустимое значение.</exception>
		// Token: 0x0600230C RID: 8972 RVA: 0x0007D748 File Offset: 0x0007B948
		public Task<TResult> StartNew(Func<TResult> function, TaskCreationOptions creationOptions)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task<TResult>.StartNew(internalCurrent, function, this.m_defaultCancellationToken, creationOptions, InternalTaskOptions.None, this.GetDefaultScheduler(internalCurrent));
		}

		/// <summary>Создает и запускает задачу.</summary>
		/// <param name="function">Делегат функции, возвращающий будущий результат с использованием задачи.</param>
		/// <param name="cancellationToken">Токен отмены, который будет назначен новой задаче.</param>
		/// <param name="creationOptions">Одно из значений перечисления, которое управляет поведением созданной задачи.</param>
		/// <param name="scheduler">Планировщик задач, который используется для планирования созданной задачи.</param>
		/// <returns>Запущенная задача.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Источник токена отмены, создавший <paramref name="cancellationToken" />, был удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="function" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="scheduler" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="creationOptions" /> задает недопустимое значение.</exception>
		// Token: 0x0600230D RID: 8973 RVA: 0x0007D771 File Offset: 0x0007B971
		public Task<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return Task<TResult>.StartNew(Task.InternalCurrentIfAttached(creationOptions), function, cancellationToken, creationOptions, InternalTaskOptions.None, scheduler);
		}

		/// <summary>Создает и запускает задачу.</summary>
		/// <param name="function">Делегат функции, возвращающий будущий результат с использованием задачи.</param>
		/// <param name="state">Объект, содержащий данные для использования этим делегатом <paramref name="function" />.</param>
		/// <returns>Запущенная задача.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="function" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600230E RID: 8974 RVA: 0x0007D784 File Offset: 0x0007B984
		public Task<TResult> StartNew(Func<object, TResult> function, object state)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task<TResult>.StartNew(internalCurrent, function, state, this.m_defaultCancellationToken, this.m_defaultCreationOptions, InternalTaskOptions.None, this.GetDefaultScheduler(internalCurrent));
		}

		/// <summary>Создает и запускает задачу.</summary>
		/// <param name="function">Делегат функции, возвращающий будущий результат с использованием задачи.</param>
		/// <param name="state">Объект, содержащий данные для использования этим делегатом <paramref name="function" />.</param>
		/// <param name="cancellationToken">Токен отмены, который будет назначен новой задаче.</param>
		/// <returns>Запущенная задача.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Источник токена отмены, создавший <paramref name="cancellationToken" />, был удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="function" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600230F RID: 8975 RVA: 0x0007D7B4 File Offset: 0x0007B9B4
		public Task<TResult> StartNew(Func<object, TResult> function, object state, CancellationToken cancellationToken)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task<TResult>.StartNew(internalCurrent, function, state, cancellationToken, this.m_defaultCreationOptions, InternalTaskOptions.None, this.GetDefaultScheduler(internalCurrent));
		}

		/// <summary>Создает и запускает задачу.</summary>
		/// <param name="function">Делегат функции, возвращающий будущий результат с использованием задачи.</param>
		/// <param name="state">Объект, содержащий данные для использования этим делегатом <paramref name="function" />.</param>
		/// <param name="creationOptions">Одно из значений перечисления, которое управляет поведением созданной задачи.</param>
		/// <returns>Запущенная задача.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="function" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="creationOptions" /> задает недопустимое значение.</exception>
		// Token: 0x06002310 RID: 8976 RVA: 0x0007D7E0 File Offset: 0x0007B9E0
		public Task<TResult> StartNew(Func<object, TResult> function, object state, TaskCreationOptions creationOptions)
		{
			Task internalCurrent = Task.InternalCurrent;
			return Task<TResult>.StartNew(internalCurrent, function, state, this.m_defaultCancellationToken, creationOptions, InternalTaskOptions.None, this.GetDefaultScheduler(internalCurrent));
		}

		/// <summary>Создает и запускает задачу.</summary>
		/// <param name="function">Делегат функции, возвращающий будущий результат с использованием задачи.</param>
		/// <param name="state">Объект, содержащий данные для использования этим делегатом <paramref name="function" />.</param>
		/// <param name="cancellationToken">Токен отмены, который будет назначен новой задаче.</param>
		/// <param name="creationOptions">Одно из значений перечисления, которое управляет поведением созданной задачи.</param>
		/// <param name="scheduler">Планировщик задач, который используется для планирования созданной задачи.</param>
		/// <returns>Запущенная задача.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Источник токена отмены, создавший <paramref name="cancellationToken" />, был удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="function" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="scheduler" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="creationOptions" /> задает недопустимое значение.</exception>
		// Token: 0x06002311 RID: 8977 RVA: 0x0007D80A File Offset: 0x0007BA0A
		public Task<TResult> StartNew(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return Task<TResult>.StartNew(Task.InternalCurrentIfAttached(creationOptions), function, state, cancellationToken, creationOptions, InternalTaskOptions.None, scheduler);
		}

		// Token: 0x06002312 RID: 8978 RVA: 0x0007D820 File Offset: 0x0007BA20
		private static void FromAsyncCoreLogic(IAsyncResult iar, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Task<TResult> promise, bool requiresSynchronization)
		{
			Exception ex = null;
			OperationCanceledException ex2 = null;
			TResult result = default(TResult);
			try
			{
				if (endFunction != null)
				{
					result = endFunction(iar);
				}
				else
				{
					endAction(iar);
				}
			}
			catch (OperationCanceledException ex2)
			{
			}
			catch (Exception ex)
			{
			}
			finally
			{
				if (ex2 != null)
				{
					promise.TrySetCanceled(ex2.CancellationToken, ex2);
				}
				else if (ex != null)
				{
					promise.TrySetException(ex);
				}
				else
				{
					if (DebuggerSupport.LoggingOn)
					{
						DebuggerSupport.TraceOperationCompletion(CausalityTraceLevel.Required, promise, AsyncStatus.Completed);
					}
					DebuggerSupport.RemoveFromActiveTasks(promise);
					if (requiresSynchronization)
					{
						promise.TrySetResult(result);
					}
					else
					{
						promise.DangerousSetResult(result);
					}
				}
			}
		}

		/// <summary>Создает задачу, которая выполняет функцию метода End по завершении заданного объекта <see cref="T:System.IAsyncResult" />.</summary>
		/// <param name="asyncResult">Интерфейс <see cref="T:System.IAsyncResult" />, завершение выполнения которого инициирует обработку <paramref name="endMethod" />.</param>
		/// <param name="endMethod">Делегат функции, который обрабатывает завершенный результат <paramref name="asyncResult" />.</param>
		/// <returns>Объект <see cref="T:System.Threading.Tasks.Task`1" />, который представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="asyncResult" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="endMethod" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002313 RID: 8979 RVA: 0x0007D8C8 File Offset: 0x0007BAC8
		public Task<TResult> FromAsync(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod)
		{
			return TaskFactory<TResult>.FromAsyncImpl(asyncResult, endMethod, null, this.m_defaultCreationOptions, this.DefaultScheduler);
		}

		/// <summary>Создает задачу, которая выполняет функцию метода End по завершении заданного объекта <see cref="T:System.IAsyncResult" />.</summary>
		/// <param name="asyncResult">Интерфейс <see cref="T:System.IAsyncResult" />, завершение выполнения которого инициирует обработку <paramref name="endMethod" />.</param>
		/// <param name="endMethod">Делегат функции, который обрабатывает завершенный результат <paramref name="asyncResult" />.</param>
		/// <param name="creationOptions">Одно из значений перечисления, которое управляет поведением созданной задачи.</param>
		/// <returns>Задача, представляющая асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="asyncResult" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="endMethod" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="creationOptions" /> указывает недопустимое значение.</exception>
		// Token: 0x06002314 RID: 8980 RVA: 0x0007D8DE File Offset: 0x0007BADE
		public Task<TResult> FromAsync(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions)
		{
			return TaskFactory<TResult>.FromAsyncImpl(asyncResult, endMethod, null, creationOptions, this.DefaultScheduler);
		}

		/// <summary>Создает задачу, которая выполняет функцию метода End по завершении заданного объекта <see cref="T:System.IAsyncResult" />.</summary>
		/// <param name="asyncResult">Интерфейс <see cref="T:System.IAsyncResult" />, завершение выполнения которого инициирует обработку <paramref name="endMethod" />.</param>
		/// <param name="endMethod">Делегат функции, который обрабатывает завершенный результат <paramref name="asyncResult" />.</param>
		/// <param name="creationOptions">Одно из значений перечисления, которое управляет поведением созданной задачи.</param>
		/// <param name="scheduler">Планировщик задач, который используется для планирования задачи, выполняющей метод End.</param>
		/// <returns>Созданная задача, которая представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="asyncResult" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="endMethod" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="scheduler" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="creationOptions" /> задает недопустимое значение.</exception>
		// Token: 0x06002315 RID: 8981 RVA: 0x0007D8EF File Offset: 0x0007BAEF
		public Task<TResult> FromAsync(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return TaskFactory<TResult>.FromAsyncImpl(asyncResult, endMethod, null, creationOptions, scheduler);
		}

		// Token: 0x06002316 RID: 8982 RVA: 0x0007D8FC File Offset: 0x0007BAFC
		internal static Task<TResult> FromAsyncImpl(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			if (endFunction == null && endAction == null)
			{
				throw new ArgumentNullException("endMethod");
			}
			if (scheduler == null)
			{
				throw new ArgumentNullException("scheduler");
			}
			TaskFactory.CheckFromAsyncOptions(creationOptions, false);
			Task<TResult> promise = new Task<TResult>(null, creationOptions);
			Task t = new Task(new Action<object>(delegate(object <p0>)
			{
				TaskFactory<TResult>.FromAsyncCoreLogic(asyncResult, endFunction, endAction, promise, true);
			}), null, null, default(CancellationToken), TaskCreationOptions.None, InternalTaskOptions.None, null);
			if (asyncResult.IsCompleted)
			{
				try
				{
					t.InternalRunSynchronously(scheduler, false);
					goto IL_EE;
				}
				catch (Exception exceptionObject)
				{
					promise.TrySetException(exceptionObject);
					goto IL_EE;
				}
			}
			ThreadPool.RegisterWaitForSingleObject(asyncResult.AsyncWaitHandle, delegate(object <p0>, bool <p1>)
			{
				try
				{
					t.InternalRunSynchronously(scheduler, false);
				}
				catch (Exception exceptionObject2)
				{
					promise.TrySetException(exceptionObject2);
				}
			}, null, -1, true);
			IL_EE:
			return promise;
		}

		/// <summary>Создает задачу, которая представляет пару методов Begin и End, соответствующих шаблону модели асинхронного программирования.</summary>
		/// <param name="beginMethod">Делегат, который начинает асинхронную операцию.</param>
		/// <param name="endMethod">Делегат, который заканчивает асинхронную операцию.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="beginMethod" />.</param>
		/// <returns>Созданная задача, которая представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="beginMethod" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="endMethod" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002317 RID: 8983 RVA: 0x0007DA10 File Offset: 0x0007BC10
		public Task<TResult> FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state)
		{
			return TaskFactory<TResult>.FromAsyncImpl(beginMethod, endMethod, null, state, this.m_defaultCreationOptions);
		}

		/// <summary>Создает задачу, которая представляет пару методов Begin и End, соответствующих шаблону модели асинхронного программирования.</summary>
		/// <param name="beginMethod">Делегат, который начинает асинхронную операцию.</param>
		/// <param name="endMethod">Делегат, который заканчивает асинхронную операцию.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="beginMethod" />.</param>
		/// <param name="creationOptions">Одно из значений перечисления, которое управляет поведением созданной задачи.</param>
		/// <returns>Созданный объект <see cref="T:System.Threading.Tasks.Task`1" />, который представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="beginMethod" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="endMethod" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="creationOptions" /> указывает недопустимое значение.</exception>
		// Token: 0x06002318 RID: 8984 RVA: 0x0007DA21 File Offset: 0x0007BC21
		public Task<TResult> FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state, TaskCreationOptions creationOptions)
		{
			return TaskFactory<TResult>.FromAsyncImpl(beginMethod, endMethod, null, state, creationOptions);
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x0007DA30 File Offset: 0x0007BC30
		internal static Task<TResult> FromAsyncImpl(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, object state, TaskCreationOptions creationOptions)
		{
			if (beginMethod == null)
			{
				throw new ArgumentNullException("beginMethod");
			}
			if (endFunction == null && endAction == null)
			{
				throw new ArgumentNullException("endMethod");
			}
			TaskFactory.CheckFromAsyncOptions(creationOptions, true);
			Task<TResult> promise = new Task<TResult>(state, creationOptions);
			if (DebuggerSupport.LoggingOn)
			{
				DebuggerSupport.TraceOperationCreation(CausalityTraceLevel.Required, promise, "TaskFactory.FromAsync: " + ((beginMethod != null) ? beginMethod.ToString() : null), 0UL);
			}
			DebuggerSupport.AddToActiveTasks(promise);
			try
			{
				IAsyncResult asyncResult = beginMethod(delegate(IAsyncResult iar)
				{
					if (!iar.CompletedSynchronously)
					{
						TaskFactory<TResult>.FromAsyncCoreLogic(iar, endFunction, endAction, promise, true);
					}
				}, state);
				if (asyncResult.CompletedSynchronously)
				{
					TaskFactory<TResult>.FromAsyncCoreLogic(asyncResult, endFunction, endAction, promise, false);
				}
			}
			catch
			{
				if (DebuggerSupport.LoggingOn)
				{
					DebuggerSupport.TraceOperationCompletion(CausalityTraceLevel.Required, promise, AsyncStatus.Error);
				}
				DebuggerSupport.RemoveFromActiveTasks(promise);
				promise.TrySetResult(default(TResult));
				throw;
			}
			return promise;
		}

		/// <summary>Создает задачу, которая представляет пару методов Begin и End, соответствующих шаблону модели асинхронного программирования.</summary>
		/// <param name="beginMethod">Делегат, который начинает асинхронную операцию.</param>
		/// <param name="endMethod">Делегат, который заканчивает асинхронную операцию.</param>
		/// <param name="arg1">Первый аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="beginMethod" />.</param>
		/// <typeparam name="TArg1">Тип первого аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <returns>Созданная задача, которая представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="beginMethod" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="endMethod" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600231A RID: 8986 RVA: 0x0007DB4C File Offset: 0x0007BD4C
		public Task<TResult> FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state)
		{
			return TaskFactory<TResult>.FromAsyncImpl<TArg1>(beginMethod, endMethod, null, arg1, state, this.m_defaultCreationOptions);
		}

		/// <summary>Создает задачу, которая представляет пару методов Begin и End, соответствующих шаблону модели асинхронного программирования.</summary>
		/// <param name="beginMethod">Делегат, который начинает асинхронную операцию.</param>
		/// <param name="endMethod">Делегат, который заканчивает асинхронную операцию.</param>
		/// <param name="arg1">Первый аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="beginMethod" />.</param>
		/// <param name="creationOptions">Одно из значений перечисления, которое управляет поведением созданной задачи.</param>
		/// <typeparam name="TArg1">Тип первого аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <returns>Созданная задача, которая представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="beginMethod" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="endMethod" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="creationOptions" /> задает недопустимое значение.</exception>
		// Token: 0x0600231B RID: 8987 RVA: 0x0007DB5F File Offset: 0x0007BD5F
		public Task<TResult> FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions)
		{
			return TaskFactory<TResult>.FromAsyncImpl<TArg1>(beginMethod, endMethod, null, arg1, state, creationOptions);
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x0007DB70 File Offset: 0x0007BD70
		internal static Task<TResult> FromAsyncImpl<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, object state, TaskCreationOptions creationOptions)
		{
			if (beginMethod == null)
			{
				throw new ArgumentNullException("beginMethod");
			}
			if (endFunction == null && endAction == null)
			{
				throw new ArgumentNullException("endFunction");
			}
			TaskFactory.CheckFromAsyncOptions(creationOptions, true);
			Task<TResult> promise = new Task<TResult>(state, creationOptions);
			if (DebuggerSupport.LoggingOn)
			{
				DebuggerSupport.TraceOperationCreation(CausalityTraceLevel.Required, promise, "TaskFactory.FromAsync: " + ((beginMethod != null) ? beginMethod.ToString() : null), 0UL);
			}
			DebuggerSupport.AddToActiveTasks(promise);
			try
			{
				IAsyncResult asyncResult = beginMethod(arg1, delegate(IAsyncResult iar)
				{
					if (!iar.CompletedSynchronously)
					{
						TaskFactory<TResult>.FromAsyncCoreLogic(iar, endFunction, endAction, promise, true);
					}
				}, state);
				if (asyncResult.CompletedSynchronously)
				{
					TaskFactory<TResult>.FromAsyncCoreLogic(asyncResult, endFunction, endAction, promise, false);
				}
			}
			catch
			{
				if (DebuggerSupport.LoggingOn)
				{
					DebuggerSupport.TraceOperationCompletion(CausalityTraceLevel.Required, promise, AsyncStatus.Error);
				}
				DebuggerSupport.RemoveFromActiveTasks(promise);
				promise.TrySetResult(default(TResult));
				throw;
			}
			return promise;
		}

		/// <summary>Создает задачу, которая представляет пару методов Begin и End, соответствующих шаблону модели асинхронного программирования.</summary>
		/// <param name="beginMethod">Делегат, который начинает асинхронную операцию.</param>
		/// <param name="endMethod">Делегат, который заканчивает асинхронную операцию.</param>
		/// <param name="arg1">Первый аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="arg2">Второй аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="beginMethod" />.</param>
		/// <typeparam name="TArg1">Тип второго аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <typeparam name="TArg2">Тип первого аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <returns>Созданная задача, которая представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="beginMethod" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="endMethod" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600231D RID: 8989 RVA: 0x0007DC90 File Offset: 0x0007BE90
		public Task<TResult> FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state)
		{
			return TaskFactory<TResult>.FromAsyncImpl<TArg1, TArg2>(beginMethod, endMethod, null, arg1, arg2, state, this.m_defaultCreationOptions);
		}

		/// <summary>Создает задачу, которая представляет пару методов Begin и End, соответствующих шаблону модели асинхронного программирования.</summary>
		/// <param name="beginMethod">Делегат, который начинает асинхронную операцию.</param>
		/// <param name="endMethod">Делегат, который заканчивает асинхронную операцию.</param>
		/// <param name="arg1">Первый аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="arg2">Второй аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="beginMethod" />.</param>
		/// <param name="creationOptions">Объект, который управляет поведением созданной <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TArg1">Тип второго аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <typeparam name="TArg2">Тип первого аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <returns>Созданная задача, которая представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="beginMethod" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="endMethod" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="creationOptions" /> задает недопустимое значение.</exception>
		// Token: 0x0600231E RID: 8990 RVA: 0x0007DCA5 File Offset: 0x0007BEA5
		public Task<TResult> FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions)
		{
			return TaskFactory<TResult>.FromAsyncImpl<TArg1, TArg2>(beginMethod, endMethod, null, arg1, arg2, state, creationOptions);
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x0007DCB8 File Offset: 0x0007BEB8
		internal static Task<TResult> FromAsyncImpl<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions)
		{
			if (beginMethod == null)
			{
				throw new ArgumentNullException("beginMethod");
			}
			if (endFunction == null && endAction == null)
			{
				throw new ArgumentNullException("endMethod");
			}
			TaskFactory.CheckFromAsyncOptions(creationOptions, true);
			Task<TResult> promise = new Task<TResult>(state, creationOptions);
			if (DebuggerSupport.LoggingOn)
			{
				DebuggerSupport.TraceOperationCreation(CausalityTraceLevel.Required, promise, "TaskFactory.FromAsync: " + ((beginMethod != null) ? beginMethod.ToString() : null), 0UL);
			}
			DebuggerSupport.AddToActiveTasks(promise);
			try
			{
				IAsyncResult asyncResult = beginMethod(arg1, arg2, delegate(IAsyncResult iar)
				{
					if (!iar.CompletedSynchronously)
					{
						TaskFactory<TResult>.FromAsyncCoreLogic(iar, endFunction, endAction, promise, true);
					}
				}, state);
				if (asyncResult.CompletedSynchronously)
				{
					TaskFactory<TResult>.FromAsyncCoreLogic(asyncResult, endFunction, endAction, promise, false);
				}
			}
			catch
			{
				if (DebuggerSupport.LoggingOn)
				{
					DebuggerSupport.TraceOperationCompletion(CausalityTraceLevel.Required, promise, AsyncStatus.Error);
				}
				DebuggerSupport.RemoveFromActiveTasks(promise);
				promise.TrySetResult(default(TResult));
				throw;
			}
			return promise;
		}

		/// <summary>Создает задачу, которая представляет пару методов Begin и End, соответствующих шаблону модели асинхронного программирования.</summary>
		/// <param name="beginMethod">Делегат, который начинает асинхронную операцию.</param>
		/// <param name="endMethod">Делегат, который заканчивает асинхронную операцию.</param>
		/// <param name="arg1">Первый аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="arg2">Второй аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="arg3">Третий аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="beginMethod" />.</param>
		/// <typeparam name="TArg1">Тип второго аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <typeparam name="TArg2">Тип третьего аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <typeparam name="TArg3">Тип первого аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <returns>Созданная задача, которая представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="beginMethod" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="endMethod" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002320 RID: 8992 RVA: 0x0007DDD8 File Offset: 0x0007BFD8
		public Task<TResult> FromAsync<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state)
		{
			return TaskFactory<TResult>.FromAsyncImpl<TArg1, TArg2, TArg3>(beginMethod, endMethod, null, arg1, arg2, arg3, state, this.m_defaultCreationOptions);
		}

		/// <summary>Создает задачу, которая представляет пару методов Begin и End, соответствующих шаблону модели асинхронного программирования.</summary>
		/// <param name="beginMethod">Делегат, который начинает асинхронную операцию.</param>
		/// <param name="endMethod">Делегат, который заканчивает асинхронную операцию.</param>
		/// <param name="arg1">Первый аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="arg2">Второй аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="arg3">Третий аргумент, переданный делегату <paramref name="beginMethod" />.</param>
		/// <param name="state">Объект, содержащий данные, которые используются делегатом метода <paramref name="beginMethod" />.</param>
		/// <param name="creationOptions">Объект, который управляет поведением созданной задачи.</param>
		/// <typeparam name="TArg1">Тип второго аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <typeparam name="TArg2">Тип третьего аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <typeparam name="TArg3">Тип первого аргумента, переданного делегату <paramref name="beginMethod" />.</typeparam>
		/// <returns>Созданная задача, которая представляет асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="beginMethod" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="endMethod" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="creationOptions" /> задает недопустимое значение.</exception>
		// Token: 0x06002321 RID: 8993 RVA: 0x0007DDEF File Offset: 0x0007BFEF
		public Task<TResult> FromAsync<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, TaskCreationOptions creationOptions)
		{
			return TaskFactory<TResult>.FromAsyncImpl<TArg1, TArg2, TArg3>(beginMethod, endMethod, null, arg1, arg2, arg3, state, creationOptions);
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x0007DE04 File Offset: 0x0007C004
		internal static Task<TResult> FromAsyncImpl<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, TaskCreationOptions creationOptions)
		{
			if (beginMethod == null)
			{
				throw new ArgumentNullException("beginMethod");
			}
			if (endFunction == null && endAction == null)
			{
				throw new ArgumentNullException("endMethod");
			}
			TaskFactory.CheckFromAsyncOptions(creationOptions, true);
			Task<TResult> promise = new Task<TResult>(state, creationOptions);
			if (DebuggerSupport.LoggingOn)
			{
				DebuggerSupport.TraceOperationCreation(CausalityTraceLevel.Required, promise, "TaskFactory.FromAsync: " + ((beginMethod != null) ? beginMethod.ToString() : null), 0UL);
			}
			DebuggerSupport.AddToActiveTasks(promise);
			try
			{
				IAsyncResult asyncResult = beginMethod(arg1, arg2, arg3, delegate(IAsyncResult iar)
				{
					if (!iar.CompletedSynchronously)
					{
						TaskFactory<TResult>.FromAsyncCoreLogic(iar, endFunction, endAction, promise, true);
					}
				}, state);
				if (asyncResult.CompletedSynchronously)
				{
					TaskFactory<TResult>.FromAsyncCoreLogic(asyncResult, endFunction, endAction, promise, false);
				}
			}
			catch
			{
				if (DebuggerSupport.LoggingOn)
				{
					DebuggerSupport.TraceOperationCompletion(CausalityTraceLevel.Required, promise, AsyncStatus.Error);
				}
				DebuggerSupport.RemoveFromActiveTasks(promise);
				promise.TrySetResult(default(TResult));
				throw;
			}
			return promise;
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x0007DF28 File Offset: 0x0007C128
		internal static Task<TResult> FromAsyncTrim<TInstance, TArgs>(TInstance thisRef, TArgs args, Func<TInstance, TArgs, AsyncCallback, object, IAsyncResult> beginMethod, Func<TInstance, IAsyncResult, TResult> endMethod) where TInstance : class
		{
			TaskFactory<TResult>.FromAsyncTrimPromise<TInstance> fromAsyncTrimPromise = new TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>(thisRef, endMethod);
			IAsyncResult asyncResult = beginMethod(thisRef, args, TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.s_completeFromAsyncResult, fromAsyncTrimPromise);
			if (asyncResult.CompletedSynchronously)
			{
				fromAsyncTrimPromise.Complete(thisRef, endMethod, asyncResult, false);
			}
			return fromAsyncTrimPromise;
		}

		// Token: 0x06002324 RID: 8996 RVA: 0x0007DF60 File Offset: 0x0007C160
		private static Task<TResult> CreateCanceledTask(TaskContinuationOptions continuationOptions, CancellationToken ct)
		{
			TaskCreationOptions creationOptions;
			InternalTaskOptions internalTaskOptions;
			Task.CreationOptionsFromContinuationOptions(continuationOptions, out creationOptions, out internalTaskOptions);
			return new Task<TResult>(true, default(TResult), creationOptions, ct);
		}

		/// <summary>Создает задачу продолжения, которая будет запущена после выполнения набора указанных задач.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения всех задач в массиве <paramref name="tasks" />.</param>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> равен <see langword="null" />.  
		///
		/// или - 
		/// Значение параметра <paramref name="continuationFunction" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> содержит значение NULL или является пустым.</exception>
		// Token: 0x06002325 RID: 8997 RVA: 0x0007DF88 File Offset: 0x0007C188
		public Task<TResult> ContinueWhenAll(Task[] tasks, Func<Task[], TResult> continuationFunction)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAllImpl(tasks, continuationFunction, this.m_defaultContinuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает задачу продолжения, которая будет запущена после выполнения набора указанных задач.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения всех задач в массиве <paramref name="tasks" />.</param>
		/// <param name="cancellationToken">Токен отмены, который будет назначен новой задаче продолжения.</param>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.  
		///
		/// или - 
		/// Класс <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="continuationFunction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> содержит значение NULL или является пустым.</exception>
		// Token: 0x06002326 RID: 8998 RVA: 0x0007DFB1 File Offset: 0x0007C1B1
		public Task<TResult> ContinueWhenAll(Task[] tasks, Func<Task[], TResult> continuationFunction, CancellationToken cancellationToken)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAllImpl(tasks, continuationFunction, this.m_defaultContinuationOptions, cancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает задачу продолжения, которая будет запущена после выполнения набора указанных задач.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения всех задач в массиве <paramref name="tasks" />.</param>
		/// <param name="continuationOptions">Одно из значений перечисления, которое управляет поведением созданной задачи продолжения. Значения NotOn* и OnlyOn* являются недопустимыми.</param>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationFunction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> указывает недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> содержит значение NULL или является пустым.</exception>
		// Token: 0x06002327 RID: 8999 RVA: 0x0007DFD5 File Offset: 0x0007C1D5
		public Task<TResult> ContinueWhenAll(Task[] tasks, Func<Task[], TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAllImpl(tasks, continuationFunction, continuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает задачу продолжения, которая будет запущена после выполнения набора указанных задач.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения всех задач в массиве <paramref name="tasks" />.</param>
		/// <param name="cancellationToken">Токен отмены, который будет назначен новой задаче продолжения.</param>
		/// <param name="continuationOptions">Одно из значений перечисления, которое управляет поведением созданной задачи продолжения. Значения NotOn* и OnlyOn* являются недопустимыми.</param>
		/// <param name="scheduler">Планировщик, который используется для планирования созданной задачи продолжения.</param>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationFunction" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="scheduler" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> содержит значение NULL или является пустым.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="continuationOptions" /> содержит недопустимое значение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.  
		///
		/// или - 
		/// Класс <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, уже удален.</exception>
		// Token: 0x06002328 RID: 9000 RVA: 0x0007DFF9 File Offset: 0x0007C1F9
		public Task<TResult> ContinueWhenAll(Task[] tasks, Func<Task[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAllImpl(tasks, continuationFunction, continuationOptions, cancellationToken, scheduler);
		}

		/// <summary>Создает задачу продолжения, которая будет запущена после выполнения набора указанных задач.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения всех задач в массиве <paramref name="tasks" />.</param>
		/// <typeparam name="TAntecedentResult">Тип результата предыдущего объекта <paramref name="tasks" />.</typeparam>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationFunction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> содержит значение NULL или является пустым.</exception>
		// Token: 0x06002329 RID: 9001 RVA: 0x0007E015 File Offset: 0x0007C215
		public Task<TResult> ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAllImpl<TAntecedentResult>(tasks, continuationFunction, this.m_defaultContinuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает задачу продолжения, которая будет запущена после выполнения набора указанных задач.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения всех задач в массиве <paramref name="tasks" />.</param>
		/// <param name="cancellationToken">Токен отмены, который будет назначен новой задаче продолжения.</param>
		/// <typeparam name="TAntecedentResult">Тип результата предыдущего объекта <paramref name="tasks" />.</typeparam>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.  
		///
		/// или - 
		/// Класс <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationFunction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> содержит значение NULL или является пустым.</exception>
		// Token: 0x0600232A RID: 9002 RVA: 0x0007E03E File Offset: 0x0007C23E
		public Task<TResult> ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAllImpl<TAntecedentResult>(tasks, continuationFunction, this.m_defaultContinuationOptions, cancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает задачу продолжения, которая будет запущена после выполнения набора указанных задач.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения всех задач в массиве <paramref name="tasks" />.</param>
		/// <param name="continuationOptions">Одно из значений перечисления, которое управляет поведением созданной задачи продолжения. Значения NotOn* и OnlyOn* являются недопустимыми.</param>
		/// <typeparam name="TAntecedentResult">Тип результата предыдущего объекта <paramref name="tasks" />.</typeparam>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationFunction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> указывает недопустимое значение.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> содержит значение NULL или является пустым.</exception>
		// Token: 0x0600232B RID: 9003 RVA: 0x0007E062 File Offset: 0x0007C262
		public Task<TResult> ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAllImpl<TAntecedentResult>(tasks, continuationFunction, continuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает задачу продолжения, которая будет запущена после выполнения набора указанных задач.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения всех задач в массиве <paramref name="tasks" />.</param>
		/// <param name="cancellationToken">Токен отмены, который будет назначен новой задаче продолжения.</param>
		/// <param name="continuationOptions">Одно из значений перечисления, которое управляет поведением созданной задачи продолжения. Значения NotOn* и OnlyOn* являются недопустимыми.</param>
		/// <param name="scheduler">Планировщик, который используется для планирования созданной задачи продолжения.</param>
		/// <typeparam name="TAntecedentResult">Тип результата предыдущего объекта <paramref name="tasks" />.</typeparam>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationFunction" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="scheduler" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> содержит значение NULL или является пустым.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> указывает недопустимое значение.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.  
		///
		/// или - 
		/// Класс <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, уже удален.</exception>
		// Token: 0x0600232C RID: 9004 RVA: 0x0007E086 File Offset: 0x0007C286
		public Task<TResult> ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAllImpl<TAntecedentResult>(tasks, continuationFunction, continuationOptions, cancellationToken, scheduler);
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x0007E0A4 File Offset: 0x0007C2A4
		internal static Task<TResult> ContinueWhenAllImpl<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction, TaskContinuationOptions continuationOptions, CancellationToken cancellationToken, TaskScheduler scheduler)
		{
			TaskFactory.CheckMultiTaskContinuationOptions(continuationOptions);
			if (tasks == null)
			{
				throw new ArgumentNullException("tasks");
			}
			if (scheduler == null)
			{
				throw new ArgumentNullException("scheduler");
			}
			Task<TAntecedentResult>[] tasksCopy = TaskFactory.CheckMultiContinuationTasksAndCopy<TAntecedentResult>(tasks);
			if (cancellationToken.IsCancellationRequested && (continuationOptions & TaskContinuationOptions.LazyCancellation) == TaskContinuationOptions.None)
			{
				return TaskFactory<TResult>.CreateCanceledTask(continuationOptions, cancellationToken);
			}
			return TaskFactory.CommonCWAllLogic<TAntecedentResult>(tasksCopy).ContinueWith<TResult>(GenericDelegateCache<TAntecedentResult, TResult>.CWAllFuncDelegate, continuationFunction, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x0007E108 File Offset: 0x0007C308
		internal static Task<TResult> ContinueWhenAllImpl<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>[]> continuationAction, TaskContinuationOptions continuationOptions, CancellationToken cancellationToken, TaskScheduler scheduler)
		{
			TaskFactory.CheckMultiTaskContinuationOptions(continuationOptions);
			if (tasks == null)
			{
				throw new ArgumentNullException("tasks");
			}
			if (scheduler == null)
			{
				throw new ArgumentNullException("scheduler");
			}
			Task<TAntecedentResult>[] tasksCopy = TaskFactory.CheckMultiContinuationTasksAndCopy<TAntecedentResult>(tasks);
			if (cancellationToken.IsCancellationRequested && (continuationOptions & TaskContinuationOptions.LazyCancellation) == TaskContinuationOptions.None)
			{
				return TaskFactory<TResult>.CreateCanceledTask(continuationOptions, cancellationToken);
			}
			return TaskFactory.CommonCWAllLogic<TAntecedentResult>(tasksCopy).ContinueWith<TResult>(GenericDelegateCache<TAntecedentResult, TResult>.CWAllActionDelegate, continuationAction, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x0007E16C File Offset: 0x0007C36C
		internal static Task<TResult> ContinueWhenAllImpl(Task[] tasks, Func<Task[], TResult> continuationFunction, TaskContinuationOptions continuationOptions, CancellationToken cancellationToken, TaskScheduler scheduler)
		{
			TaskFactory.CheckMultiTaskContinuationOptions(continuationOptions);
			if (tasks == null)
			{
				throw new ArgumentNullException("tasks");
			}
			if (scheduler == null)
			{
				throw new ArgumentNullException("scheduler");
			}
			Task[] tasksCopy = TaskFactory.CheckMultiContinuationTasksAndCopy(tasks);
			if (cancellationToken.IsCancellationRequested && (continuationOptions & TaskContinuationOptions.LazyCancellation) == TaskContinuationOptions.None)
			{
				return TaskFactory<TResult>.CreateCanceledTask(continuationOptions, cancellationToken);
			}
			return TaskFactory.CommonCWAllLogic(tasksCopy).ContinueWith<TResult>(delegate(Task<Task[]> completedTasks, object state)
			{
				completedTasks.NotifyDebuggerOfWaitCompletionIfNecessary();
				return ((Func<Task[], TResult>)state)(completedTasks.Result);
			}, continuationFunction, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x0007E1EC File Offset: 0x0007C3EC
		internal static Task<TResult> ContinueWhenAllImpl(Task[] tasks, Action<Task[]> continuationAction, TaskContinuationOptions continuationOptions, CancellationToken cancellationToken, TaskScheduler scheduler)
		{
			TaskFactory.CheckMultiTaskContinuationOptions(continuationOptions);
			if (tasks == null)
			{
				throw new ArgumentNullException("tasks");
			}
			if (scheduler == null)
			{
				throw new ArgumentNullException("scheduler");
			}
			Task[] tasksCopy = TaskFactory.CheckMultiContinuationTasksAndCopy(tasks);
			if (cancellationToken.IsCancellationRequested && (continuationOptions & TaskContinuationOptions.LazyCancellation) == TaskContinuationOptions.None)
			{
				return TaskFactory<TResult>.CreateCanceledTask(continuationOptions, cancellationToken);
			}
			return TaskFactory.CommonCWAllLogic(tasksCopy).ContinueWith<TResult>(delegate(Task<Task[]> completedTasks, object state)
			{
				completedTasks.NotifyDebuggerOfWaitCompletionIfNecessary();
				((Action<Task[]>)state)(completedTasks.Result);
				return default(TResult);
			}, continuationAction, scheduler, cancellationToken, continuationOptions);
		}

		/// <summary>Создает задачу продолжения, которая будет запущена после выполнения любой задачи в указанном наборе.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено после завершения выполнения одной задачи.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения одной задачи в массиве <paramref name="tasks" />.</param>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationFunction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> содержит значение NULL или является пустым.</exception>
		// Token: 0x06002331 RID: 9009 RVA: 0x0007E269 File Offset: 0x0007C469
		public Task<TResult> ContinueWhenAny(Task[] tasks, Func<Task, TResult> continuationFunction)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAnyImpl(tasks, continuationFunction, this.m_defaultContinuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает задачу продолжения, которая будет запущена после выполнения любой задачи в указанном наборе.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено после завершения выполнения одной задачи.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения одной задачи в массиве <paramref name="tasks" />.</param>
		/// <param name="cancellationToken">Токен отмены, который будет назначен новой задаче продолжения.</param>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.  
		///
		/// или - 
		/// Класс <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> равняется NULL.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationFunction" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> содержит значение NULL.  
		///
		/// или - 
		/// Массив <paramref name="tasks" /> является пустым.</exception>
		// Token: 0x06002332 RID: 9010 RVA: 0x0007E292 File Offset: 0x0007C492
		public Task<TResult> ContinueWhenAny(Task[] tasks, Func<Task, TResult> continuationFunction, CancellationToken cancellationToken)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAnyImpl(tasks, continuationFunction, this.m_defaultContinuationOptions, cancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает задачу продолжения, которая будет запущена после выполнения любой задачи в указанном наборе.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено после завершения выполнения одной задачи.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения одной задачи в массиве <paramref name="tasks" />.</param>
		/// <param name="continuationOptions">Одно из значений перечисления, которое управляет поведением созданной задачи продолжения. Значения <see langword="NotOn" /> и <see langword="OnlyOn" /> являются недопустимыми.</param>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationFunction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> указывает недопустимое значение перечисления.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> содержит значение NULL.  
		///
		/// или - 
		/// Массив <paramref name="tasks" /> является пустым.</exception>
		// Token: 0x06002333 RID: 9011 RVA: 0x0007E2B6 File Offset: 0x0007C4B6
		public Task<TResult> ContinueWhenAny(Task[] tasks, Func<Task, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAnyImpl(tasks, continuationFunction, continuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает задачу продолжения, которая будет запущена после выполнения любой задачи в указанном наборе.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено после завершения выполнения одной задачи.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения одной задачи в массиве <paramref name="tasks" />.</param>
		/// <param name="cancellationToken">Токен отмены, который будет назначен новой задаче продолжения.</param>
		/// <param name="continuationOptions">Одно из значений перечисления, которое управляет поведением созданной задачи продолжения. Значения <see langword="NotOn" /> и <see langword="OnlyOn" /> являются недопустимыми.</param>
		/// <param name="scheduler">Планировщик задач, который используется для планирования созданной задачи продолжения.</param>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationFunction" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="scheduler" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> содержит значение NULL.  
		///
		/// или - 
		/// Массив <paramref name="tasks" /> является пустым.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> указывает недопустимое значение <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.  
		///
		/// или - 
		/// Класс <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, уже удален.</exception>
		// Token: 0x06002334 RID: 9012 RVA: 0x0007E2DA File Offset: 0x0007C4DA
		public Task<TResult> ContinueWhenAny(Task[] tasks, Func<Task, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAnyImpl(tasks, continuationFunction, continuationOptions, cancellationToken, scheduler);
		}

		/// <summary>Создает задачу продолжения, которая будет запущена после выполнения любой задачи в указанном наборе.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено после завершения выполнения одной задачи.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения одной задачи в массиве <paramref name="tasks" />.</param>
		/// <typeparam name="TAntecedentResult">Тип результата предыдущего объекта <paramref name="tasks" />.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationFunction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> содержит значение NULL.  
		///
		/// или - 
		/// Массив <paramref name="tasks" /> является пустым.</exception>
		// Token: 0x06002335 RID: 9013 RVA: 0x0007E2F6 File Offset: 0x0007C4F6
		public Task<TResult> ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAnyImpl<TAntecedentResult>(tasks, continuationFunction, this.m_defaultContinuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает задачу продолжения, которая будет запущена после выполнения любой задачи в указанном наборе.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено после завершения выполнения одной задачи.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения одной задачи в массиве <paramref name="tasks" />.</param>
		/// <param name="cancellationToken">Токен отмены, который будет назначен новой задаче продолжения.</param>
		/// <typeparam name="TAntecedentResult">Тип результата предыдущего объекта <paramref name="tasks" />.</typeparam>
		/// <returns>Новая задача продолжения.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.  
		///
		/// или - 
		/// Класс <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, уже удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationFunction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> содержит значение NULL.  
		///
		/// или - 
		/// Массив <paramref name="tasks" /> является пустым.</exception>
		// Token: 0x06002336 RID: 9014 RVA: 0x0007E31F File Offset: 0x0007C51F
		public Task<TResult> ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAnyImpl<TAntecedentResult>(tasks, continuationFunction, this.m_defaultContinuationOptions, cancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает задачу продолжения, которая будет запущена после выполнения любой задачи в указанном наборе.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено после завершения выполнения одной задачи.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения одной задачи в массиве <paramref name="tasks" />.</param>
		/// <param name="continuationOptions">Одно из значений перечисления, которое управляет поведением созданной задачи продолжения. Значения <see langword="NotOn" /> и <see langword="OnlyOn" /> являются недопустимыми.</param>
		/// <typeparam name="TAntecedentResult">Тип результата предыдущего объекта <paramref name="tasks" />.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationFunction" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> указывает недопустимое значение перечисления.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> содержит значение NULL.  
		///
		/// или - 
		/// Массив <paramref name="tasks" /> является пустым.</exception>
		// Token: 0x06002337 RID: 9015 RVA: 0x0007E343 File Offset: 0x0007C543
		public Task<TResult> ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAnyImpl<TAntecedentResult>(tasks, continuationFunction, continuationOptions, this.m_defaultCancellationToken, this.DefaultScheduler);
		}

		/// <summary>Создает задачу продолжения, которая будет запущена после выполнения любой задачи в указанном наборе.</summary>
		/// <param name="tasks">Массив задач, выполнение которых должно быть продолжено после завершения выполнения одной задачи.</param>
		/// <param name="continuationFunction">Делегат функции, выполняемый асинхронно после завершения выполнения одной задачи в массиве <paramref name="tasks" />.</param>
		/// <param name="cancellationToken">Токен отмены, который будет назначен новой задаче продолжения.</param>
		/// <param name="continuationOptions">Одно из значений перечисления, которое управляет поведением созданной задачи продолжения. Значения <see langword="NotOn" /> и <see langword="OnlyOn" /> являются недопустимыми.</param>
		/// <param name="scheduler">Планировщик <see cref="T:System.Threading.Tasks.TaskScheduler" />, который используется для планирования созданной задачи продолжения <see cref="T:System.Threading.Tasks.Task`1" />.</param>
		/// <typeparam name="TAntecedentResult">Тип результата предыдущего объекта <paramref name="tasks" />.</typeparam>
		/// <returns>Новое продолжение <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Массив <paramref name="tasks" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="continuationFunction" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Аргумент <paramref name="scheduler" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="tasks" /> содержит значение NULL.  
		///
		/// или - 
		/// Массив <paramref name="tasks" /> является пустым.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="continuationOptions" /> задает недопустимое значение для TaskContinuationOptions.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Один из элементов массива <paramref name="tasks" /> удален.  
		///
		/// или - 
		/// Класс <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, уже удален.</exception>
		// Token: 0x06002338 RID: 9016 RVA: 0x0007E367 File Offset: 0x0007C567
		public Task<TResult> ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			if (continuationFunction == null)
			{
				throw new ArgumentNullException("continuationFunction");
			}
			return TaskFactory<TResult>.ContinueWhenAnyImpl<TAntecedentResult>(tasks, continuationFunction, continuationOptions, cancellationToken, scheduler);
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x0007E384 File Offset: 0x0007C584
		internal static Task<TResult> ContinueWhenAnyImpl(Task[] tasks, Action<Task> continuationAction, TaskContinuationOptions continuationOptions, CancellationToken cancellationToken, TaskScheduler scheduler)
		{
			TaskFactory.CheckMultiTaskContinuationOptions(continuationOptions);
			if (tasks == null)
			{
				throw new ArgumentNullException("tasks");
			}
			if (tasks.Length == 0)
			{
				throw new ArgumentException("The tasks argument contains no tasks.", "tasks");
			}
			if (scheduler == null)
			{
				throw new ArgumentNullException("scheduler");
			}
			Task<Task> task = TaskFactory.CommonCWAnyLogic(tasks);
			if (cancellationToken.IsCancellationRequested && (continuationOptions & TaskContinuationOptions.LazyCancellation) == TaskContinuationOptions.None)
			{
				return TaskFactory<TResult>.CreateCanceledTask(continuationOptions, cancellationToken);
			}
			return task.ContinueWith<TResult>(delegate(Task<Task> completedTask, object state)
			{
				((Action<Task>)state)(completedTask.Result);
				return default(TResult);
			}, continuationAction, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x0007E410 File Offset: 0x0007C610
		internal static Task<TResult> ContinueWhenAnyImpl(Task[] tasks, Func<Task, TResult> continuationFunction, TaskContinuationOptions continuationOptions, CancellationToken cancellationToken, TaskScheduler scheduler)
		{
			TaskFactory.CheckMultiTaskContinuationOptions(continuationOptions);
			if (tasks == null)
			{
				throw new ArgumentNullException("tasks");
			}
			if (tasks.Length == 0)
			{
				throw new ArgumentException("The tasks argument contains no tasks.", "tasks");
			}
			if (scheduler == null)
			{
				throw new ArgumentNullException("scheduler");
			}
			Task<Task> task = TaskFactory.CommonCWAnyLogic(tasks);
			if (cancellationToken.IsCancellationRequested && (continuationOptions & TaskContinuationOptions.LazyCancellation) == TaskContinuationOptions.None)
			{
				return TaskFactory<TResult>.CreateCanceledTask(continuationOptions, cancellationToken);
			}
			return task.ContinueWith<TResult>((Task<Task> completedTask, object state) => ((Func<Task, TResult>)state)(completedTask.Result), continuationFunction, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x0007E49C File Offset: 0x0007C69C
		internal static Task<TResult> ContinueWhenAnyImpl<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, TaskContinuationOptions continuationOptions, CancellationToken cancellationToken, TaskScheduler scheduler)
		{
			TaskFactory.CheckMultiTaskContinuationOptions(continuationOptions);
			if (tasks == null)
			{
				throw new ArgumentNullException("tasks");
			}
			if (tasks.Length == 0)
			{
				throw new ArgumentException("The tasks argument contains no tasks.", "tasks");
			}
			if (scheduler == null)
			{
				throw new ArgumentNullException("scheduler");
			}
			Task<Task> task = TaskFactory.CommonCWAnyLogic(tasks);
			if (cancellationToken.IsCancellationRequested && (continuationOptions & TaskContinuationOptions.LazyCancellation) == TaskContinuationOptions.None)
			{
				return TaskFactory<TResult>.CreateCanceledTask(continuationOptions, cancellationToken);
			}
			return task.ContinueWith<TResult>(GenericDelegateCache<TAntecedentResult, TResult>.CWAnyFuncDelegate, continuationFunction, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x0007E510 File Offset: 0x0007C710
		internal static Task<TResult> ContinueWhenAnyImpl<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>> continuationAction, TaskContinuationOptions continuationOptions, CancellationToken cancellationToken, TaskScheduler scheduler)
		{
			TaskFactory.CheckMultiTaskContinuationOptions(continuationOptions);
			if (tasks == null)
			{
				throw new ArgumentNullException("tasks");
			}
			if (tasks.Length == 0)
			{
				throw new ArgumentException("The tasks argument contains no tasks.", "tasks");
			}
			if (scheduler == null)
			{
				throw new ArgumentNullException("scheduler");
			}
			Task<Task> task = TaskFactory.CommonCWAnyLogic(tasks);
			if (cancellationToken.IsCancellationRequested && (continuationOptions & TaskContinuationOptions.LazyCancellation) == TaskContinuationOptions.None)
			{
				return TaskFactory<TResult>.CreateCanceledTask(continuationOptions, cancellationToken);
			}
			return task.ContinueWith<TResult>(GenericDelegateCache<TAntecedentResult, TResult>.CWAnyActionDelegate, continuationAction, scheduler, cancellationToken, continuationOptions);
		}

		// Token: 0x04001C88 RID: 7304
		private CancellationToken m_defaultCancellationToken;

		// Token: 0x04001C89 RID: 7305
		private TaskScheduler m_defaultScheduler;

		// Token: 0x04001C8A RID: 7306
		private TaskCreationOptions m_defaultCreationOptions;

		// Token: 0x04001C8B RID: 7307
		private TaskContinuationOptions m_defaultContinuationOptions;

		// Token: 0x02000344 RID: 836
		private sealed class FromAsyncTrimPromise<TInstance> : Task<TResult> where TInstance : class
		{
			// Token: 0x0600233D RID: 9021 RVA: 0x0007E582 File Offset: 0x0007C782
			internal FromAsyncTrimPromise(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod)
			{
				this.m_thisRef = thisRef;
				this.m_endMethod = endMethod;
			}

			// Token: 0x0600233E RID: 9022 RVA: 0x0007E598 File Offset: 0x0007C798
			internal static void CompleteFromAsyncResult(IAsyncResult asyncResult)
			{
				if (asyncResult == null)
				{
					throw new ArgumentNullException("asyncResult");
				}
				TaskFactory<TResult>.FromAsyncTrimPromise<TInstance> fromAsyncTrimPromise = asyncResult.AsyncState as TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>;
				if (fromAsyncTrimPromise == null)
				{
					throw new ArgumentException("Either the IAsyncResult object did not come from the corresponding async method on this type, or the End method was called multiple times with the same IAsyncResult.", "asyncResult");
				}
				TInstance thisRef = fromAsyncTrimPromise.m_thisRef;
				Func<TInstance, IAsyncResult, TResult> endMethod = fromAsyncTrimPromise.m_endMethod;
				fromAsyncTrimPromise.m_thisRef = default(TInstance);
				fromAsyncTrimPromise.m_endMethod = null;
				if (endMethod == null)
				{
					throw new ArgumentException("Either the IAsyncResult object did not come from the corresponding async method on this type, or the End method was called multiple times with the same IAsyncResult.", "asyncResult");
				}
				if (!asyncResult.CompletedSynchronously)
				{
					fromAsyncTrimPromise.Complete(thisRef, endMethod, asyncResult, true);
				}
			}

			// Token: 0x0600233F RID: 9023 RVA: 0x0007E618 File Offset: 0x0007C818
			internal void Complete(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod, IAsyncResult asyncResult, bool requiresSynchronization)
			{
				try
				{
					TResult result = endMethod(thisRef, asyncResult);
					if (requiresSynchronization)
					{
						base.TrySetResult(result);
					}
					else
					{
						base.DangerousSetResult(result);
					}
				}
				catch (OperationCanceledException ex)
				{
					base.TrySetCanceled(ex.CancellationToken, ex);
				}
				catch (Exception exceptionObject)
				{
					base.TrySetException(exceptionObject);
				}
			}

			// Token: 0x04001C8C RID: 7308
			internal static readonly AsyncCallback s_completeFromAsyncResult = new AsyncCallback(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.CompleteFromAsyncResult);

			// Token: 0x04001C8D RID: 7309
			private TInstance m_thisRef;

			// Token: 0x04001C8E RID: 7310
			private Func<TInstance, IAsyncResult, TResult> m_endMethod;
		}
	}
}
