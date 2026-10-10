using System;
using System.Diagnostics;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	/// <summary>Представляет построитель для асинхронных методов, который возвращает задачу и предоставляет параметр для результата.</summary>
	/// <typeparam name="TResult">Результат, используемый для выполнения задачи.</typeparam>
	// Token: 0x0200081C RID: 2076
	[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
	public struct AsyncTaskMethodBuilder<TResult>
	{
		/// <summary>Создает экземпляр класса <see cref="T:System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1" />.</summary>
		/// <returns>Новый экземпляр построителя.</returns>
		// Token: 0x06004678 RID: 18040 RVA: 0x000E6640 File Offset: 0x000E4840
		public static AsyncTaskMethodBuilder<TResult> Create()
		{
			return default(AsyncTaskMethodBuilder<TResult>);
		}

		/// <summary>Начинает выполнение построителя со связанным конечным автоматом.</summary>
		/// <param name="stateMachine">Экземпляр конечного автомата, переданный ссылкой.</param>
		/// <typeparam name="TStateMachine">Тип конечного автомата.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="stateMachine" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004679 RID: 18041 RVA: 0x000E6658 File Offset: 0x000E4858
		[SecuritySafeCritical]
		[DebuggerStepThrough]
		public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
			if (stateMachine == null)
			{
				throw new ArgumentNullException("stateMachine");
			}
			ExecutionContextSwitcher executionContextSwitcher = default(ExecutionContextSwitcher);
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
				ExecutionContext.EstablishCopyOnWriteScope(ref executionContextSwitcher);
				stateMachine.MoveNext();
			}
			finally
			{
				executionContextSwitcher.Undo();
			}
		}

		/// <summary>Связывает построитель с указанным конечным автоматом.</summary>
		/// <param name="stateMachine">Экземпляр конечного автомата, связываемый с построителем.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="stateMachine" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Конечный автомат был ранее установлен.</exception>
		// Token: 0x0600467A RID: 18042 RVA: 0x000E66B8 File Offset: 0x000E48B8
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.m_coreState.SetStateMachine(stateMachine);
		}

		/// <summary>Планирует переход конечного автомата к следующему действию по завершении выполнения указанного объекта типа awaiter.</summary>
		/// <param name="awaiter">Объект типа awaiter.</param>
		/// <param name="stateMachine">Конечный автомат.</param>
		/// <typeparam name="TAwaiter">Тип объекта типа awaiter.</typeparam>
		/// <typeparam name="TStateMachine">Тип конечного автомата.</typeparam>
		// Token: 0x0600467B RID: 18043 RVA: 0x000E66C8 File Offset: 0x000E48C8
		public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			try
			{
				AsyncMethodBuilderCore.MoveNextRunner runner = null;
				Action completionAction = this.m_coreState.GetCompletionAction(AsyncCausalityTracer.LoggingOn ? this.Task : null, ref runner);
				if (this.m_coreState.m_stateMachine == null)
				{
					Task<TResult> task = this.Task;
					this.m_coreState.PostBoxInitialization(stateMachine, runner, task);
				}
				awaiter.OnCompleted(completionAction);
			}
			catch (Exception exception)
			{
				AsyncMethodBuilderCore.ThrowAsync(exception, null);
			}
		}

		/// <summary>Планирует переход конечного автомата к следующему действию по завершении выполнения указанного объекта типа awaiter. Этот метод может вызываться из частично доверенного кода.</summary>
		/// <param name="awaiter">Объект типа awaiter.</param>
		/// <param name="stateMachine">Конечный автомат.</param>
		/// <typeparam name="TAwaiter">Тип объекта типа awaiter.</typeparam>
		/// <typeparam name="TStateMachine">Тип конечного автомата.</typeparam>
		// Token: 0x0600467C RID: 18044 RVA: 0x000E6748 File Offset: 0x000E4948
		[SecuritySafeCritical]
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			try
			{
				AsyncMethodBuilderCore.MoveNextRunner runner = null;
				Action completionAction = this.m_coreState.GetCompletionAction(AsyncCausalityTracer.LoggingOn ? this.Task : null, ref runner);
				if (this.m_coreState.m_stateMachine == null)
				{
					Task<TResult> task = this.Task;
					this.m_coreState.PostBoxInitialization(stateMachine, runner, task);
				}
				awaiter.UnsafeOnCompleted(completionAction);
			}
			catch (Exception exception)
			{
				AsyncMethodBuilderCore.ThrowAsync(exception, null);
			}
		}

		/// <summary>Получает задачу для данного построителя.</summary>
		/// <returns>Задача для этого построителя.</returns>
		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x0600467D RID: 18045 RVA: 0x000E67C8 File Offset: 0x000E49C8
		public Task<TResult> Task
		{
			get
			{
				Task<TResult> task = this.m_task;
				if (task == null)
				{
					task = (this.m_task = new Task<TResult>());
				}
				return task;
			}
		}

		/// <summary>Отмечает задачу как успешно завершенную.</summary>
		/// <param name="result">Результат, используемый для выполнения задачи.</param>
		/// <exception cref="T:System.InvalidOperationException">Задача уже завершена.</exception>
		// Token: 0x0600467E RID: 18046 RVA: 0x000E67F0 File Offset: 0x000E49F0
		public void SetResult(TResult result)
		{
			Task<TResult> task = this.m_task;
			if (task == null)
			{
				this.m_task = AsyncTaskMethodBuilder<TResult>.GetTaskForResult(result);
				return;
			}
			if (AsyncCausalityTracer.LoggingOn)
			{
				AsyncCausalityTracer.TraceOperationCompletion(CausalityTraceLevel.Required, task.Id, AsyncCausalityStatus.Completed);
			}
			if (System.Threading.Tasks.Task.s_asyncDebuggingEnabled)
			{
				System.Threading.Tasks.Task.RemoveFromActiveTasks(task.Id);
			}
			if (!task.TrySetResult(result))
			{
				throw new InvalidOperationException(Environment.GetResourceString("An attempt was made to transition a task to a final state when it had already completed."));
			}
		}

		// Token: 0x0600467F RID: 18047 RVA: 0x000E6854 File Offset: 0x000E4A54
		internal void SetResult(Task<TResult> completedTask)
		{
			if (this.m_task == null)
			{
				this.m_task = completedTask;
				return;
			}
			this.SetResult(default(TResult));
		}

		/// <summary>Помечает задачу как сбойную и привязывает указанное исключение в задаче.</summary>
		/// <param name="exception">Исключение для привязки к задаче.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="exception" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Задача уже завершена.</exception>
		// Token: 0x06004680 RID: 18048 RVA: 0x000E6880 File Offset: 0x000E4A80
		public void SetException(Exception exception)
		{
			if (exception == null)
			{
				throw new ArgumentNullException("exception");
			}
			Task<TResult> task = this.m_task;
			if (task == null)
			{
				task = this.Task;
			}
			OperationCanceledException ex = exception as OperationCanceledException;
			if (!((ex != null) ? task.TrySetCanceled(ex.CancellationToken, ex) : task.TrySetException(exception)))
			{
				throw new InvalidOperationException(Environment.GetResourceString("An attempt was made to transition a task to a final state when it had already completed."));
			}
		}

		// Token: 0x06004681 RID: 18049 RVA: 0x000E68DE File Offset: 0x000E4ADE
		internal void SetNotificationForWaitCompletion(bool enabled)
		{
			this.Task.SetNotificationForWaitCompletion(enabled);
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06004682 RID: 18050 RVA: 0x000E68EC File Offset: 0x000E4AEC
		private object ObjectIdForDebugger
		{
			get
			{
				return this.Task;
			}
		}

		// Token: 0x06004683 RID: 18051 RVA: 0x000E68F4 File Offset: 0x000E4AF4
		[SecuritySafeCritical]
		internal static Task<TResult> GetTaskForResult(TResult result)
		{
			if (default(TResult) != null)
			{
				if (typeof(TResult) == typeof(bool))
				{
					return JitHelpers.UnsafeCast<Task<TResult>>(((bool)((object)result)) ? AsyncTaskCache.TrueTask : AsyncTaskCache.FalseTask);
				}
				if (typeof(TResult) == typeof(int))
				{
					int num = (int)((object)result);
					if (num < 9 && num >= -1)
					{
						return JitHelpers.UnsafeCast<Task<TResult>>(AsyncTaskCache.Int32Tasks[num - -1]);
					}
				}
				else if ((typeof(TResult) == typeof(uint) && (uint)((object)result) == 0U) || (typeof(TResult) == typeof(byte) && (byte)((object)result) == 0) || (typeof(TResult) == typeof(sbyte) && (sbyte)((object)result) == 0) || (typeof(TResult) == typeof(char) && (char)((object)result) == '\0') || (typeof(TResult) == typeof(long) && (long)((object)result) == 0L) || (typeof(TResult) == typeof(ulong) && (ulong)((object)result) == 0UL) || (typeof(TResult) == typeof(short) && (short)((object)result) == 0) || (typeof(TResult) == typeof(ushort) && (ushort)((object)result) == 0) || (typeof(TResult) == typeof(IntPtr) && (IntPtr)0 == (IntPtr)((object)result)) || (typeof(TResult) == typeof(UIntPtr) && (UIntPtr)0 == (UIntPtr)((object)result)))
				{
					return AsyncTaskMethodBuilder<TResult>.s_defaultResultTask;
				}
			}
			else if (result == null)
			{
				return AsyncTaskMethodBuilder<TResult>.s_defaultResultTask;
			}
			return new Task<TResult>(result);
		}

		// Token: 0x04002D5B RID: 11611
		internal static readonly Task<TResult> s_defaultResultTask = AsyncTaskCache.CreateCacheableTask<TResult>(default(TResult));

		// Token: 0x04002D5C RID: 11612
		private AsyncMethodBuilderCore m_coreState;

		// Token: 0x04002D5D RID: 11613
		private Task<TResult> m_task;
	}
}
