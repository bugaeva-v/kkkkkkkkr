using System;
using System.Diagnostics;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	/// <summary>Представляет конструктор для асинхронных методов, которые не возвращают никакое значение.</summary>
	// Token: 0x0200081A RID: 2074
	[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
	public struct AsyncVoidMethodBuilder
	{
		/// <summary>Создает экземпляр класса <see cref="T:System.Runtime.CompilerServices.AsyncVoidMethodBuilder" />.</summary>
		/// <returns>Новый экземпляр построителя.</returns>
		// Token: 0x06004663 RID: 18019 RVA: 0x000E6260 File Offset: 0x000E4460
		public static AsyncVoidMethodBuilder Create()
		{
			SynchronizationContext currentNoFlow = SynchronizationContext.CurrentNoFlow;
			if (currentNoFlow != null)
			{
				currentNoFlow.OperationStarted();
			}
			return new AsyncVoidMethodBuilder
			{
				m_synchronizationContext = currentNoFlow
			};
		}

		/// <summary>Начинает выполнение построителя со связанным конечным автоматом.</summary>
		/// <param name="stateMachine">Экземпляр конечного автомата, переданный ссылкой.</param>
		/// <typeparam name="TStateMachine">Тип конечного автомата.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="stateMachine" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004664 RID: 18020 RVA: 0x000E6290 File Offset: 0x000E4490
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
		// Token: 0x06004665 RID: 18021 RVA: 0x000E62F0 File Offset: 0x000E44F0
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.m_coreState.SetStateMachine(stateMachine);
		}

		/// <summary>Планирует переход конечного автомата к следующему действию по завершении выполнения указанного объекта типа awaiter.</summary>
		/// <param name="awaiter">Объект типа awaiter.</param>
		/// <param name="stateMachine">Конечный автомат.</param>
		/// <typeparam name="TAwaiter">Тип объекта типа awaiter.</typeparam>
		/// <typeparam name="TStateMachine">Тип конечного автомата.</typeparam>
		// Token: 0x06004666 RID: 18022 RVA: 0x000E6300 File Offset: 0x000E4500
		public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			try
			{
				AsyncMethodBuilderCore.MoveNextRunner runner = null;
				Action completionAction = this.m_coreState.GetCompletionAction(AsyncCausalityTracer.LoggingOn ? this.Task : null, ref runner);
				if (this.m_coreState.m_stateMachine == null)
				{
					if (AsyncCausalityTracer.LoggingOn)
					{
						AsyncCausalityTracer.TraceOperationCreation(CausalityTraceLevel.Required, this.Task.Id, "Async: " + stateMachine.GetType().Name, 0UL);
					}
					this.m_coreState.PostBoxInitialization(stateMachine, runner, null);
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
		// Token: 0x06004667 RID: 18023 RVA: 0x000E63B0 File Offset: 0x000E45B0
		[SecuritySafeCritical]
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			try
			{
				AsyncMethodBuilderCore.MoveNextRunner runner = null;
				Action completionAction = this.m_coreState.GetCompletionAction(AsyncCausalityTracer.LoggingOn ? this.Task : null, ref runner);
				if (this.m_coreState.m_stateMachine == null)
				{
					if (AsyncCausalityTracer.LoggingOn)
					{
						AsyncCausalityTracer.TraceOperationCreation(CausalityTraceLevel.Required, this.Task.Id, "Async: " + stateMachine.GetType().Name, 0UL);
					}
					this.m_coreState.PostBoxInitialization(stateMachine, runner, null);
				}
				awaiter.UnsafeOnCompleted(completionAction);
			}
			catch (Exception exception)
			{
				AsyncMethodBuilderCore.ThrowAsync(exception, null);
			}
		}

		/// <summary>Помечает простроитель метода как успешно завершенный.</summary>
		/// <exception cref="T:System.InvalidOperationException">Построитель не инициализирован.</exception>
		// Token: 0x06004668 RID: 18024 RVA: 0x000E6460 File Offset: 0x000E4660
		public void SetResult()
		{
			if (AsyncCausalityTracer.LoggingOn)
			{
				AsyncCausalityTracer.TraceOperationCompletion(CausalityTraceLevel.Required, this.Task.Id, AsyncCausalityStatus.Completed);
			}
			if (this.m_synchronizationContext != null)
			{
				this.NotifySynchronizationContextOfCompletion();
			}
		}

		/// <summary>Привязывает исключение к построителю метода.</summary>
		/// <param name="exception">Исключение для привязки.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="exception" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Построитель не инициализирован.</exception>
		// Token: 0x06004669 RID: 18025 RVA: 0x000E648C File Offset: 0x000E468C
		public void SetException(Exception exception)
		{
			if (exception == null)
			{
				throw new ArgumentNullException("exception");
			}
			if (AsyncCausalityTracer.LoggingOn)
			{
				AsyncCausalityTracer.TraceOperationCompletion(CausalityTraceLevel.Required, this.Task.Id, AsyncCausalityStatus.Error);
			}
			if (this.m_synchronizationContext != null)
			{
				try
				{
					AsyncMethodBuilderCore.ThrowAsync(exception, this.m_synchronizationContext);
					return;
				}
				finally
				{
					this.NotifySynchronizationContextOfCompletion();
				}
			}
			AsyncMethodBuilderCore.ThrowAsync(exception, null);
		}

		// Token: 0x0600466A RID: 18026 RVA: 0x000E64F4 File Offset: 0x000E46F4
		private void NotifySynchronizationContextOfCompletion()
		{
			try
			{
				this.m_synchronizationContext.OperationCompleted();
			}
			catch (Exception exception)
			{
				AsyncMethodBuilderCore.ThrowAsync(exception, null);
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x0600466B RID: 18027 RVA: 0x000E6528 File Offset: 0x000E4728
		internal Task Task
		{
			get
			{
				if (this.m_task == null)
				{
					this.m_task = new Task();
				}
				return this.m_task;
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x0600466C RID: 18028 RVA: 0x000E6543 File Offset: 0x000E4743
		private object ObjectIdForDebugger
		{
			get
			{
				return this.Task;
			}
		}

		// Token: 0x04002D56 RID: 11606
		private SynchronizationContext m_synchronizationContext;

		// Token: 0x04002D57 RID: 11607
		private AsyncMethodBuilderCore m_coreState;

		// Token: 0x04002D58 RID: 11608
		private Task m_task;
	}
}
