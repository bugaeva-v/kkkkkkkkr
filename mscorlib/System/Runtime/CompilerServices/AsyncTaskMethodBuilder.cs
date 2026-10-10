using System;
using System.Diagnostics;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	/// <summary>Представляет конструктор для асинхронных методов, возвращающих задачу.</summary>
	// Token: 0x0200081B RID: 2075
	[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
	public struct AsyncTaskMethodBuilder
	{
		/// <summary>Создает экземпляр класса <see cref="T:System.Runtime.CompilerServices.AsyncTaskMethodBuilder" />.</summary>
		/// <returns>Новый экземпляр построителя.</returns>
		// Token: 0x0600466D RID: 18029 RVA: 0x000E654C File Offset: 0x000E474C
		public static AsyncTaskMethodBuilder Create()
		{
			return default(AsyncTaskMethodBuilder);
		}

		/// <summary>Начинает выполнение построителя со связанным конечным автоматом.</summary>
		/// <param name="stateMachine">Экземпляр конечного автомата, переданный ссылкой.</param>
		/// <typeparam name="TStateMachine">Тип конечного автомата.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="stateMachine" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600466E RID: 18030 RVA: 0x000E6564 File Offset: 0x000E4764
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
		// Token: 0x0600466F RID: 18031 RVA: 0x000E65C4 File Offset: 0x000E47C4
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this.m_builder.SetStateMachine(stateMachine);
		}

		/// <summary>Планирует переход конечного автомата к следующему действию по завершении выполнения указанного объекта типа awaiter.</summary>
		/// <param name="awaiter">Объект типа awaiter.</param>
		/// <param name="stateMachine">Конечный автомат.</param>
		/// <typeparam name="TAwaiter">Тип объекта типа awaiter.</typeparam>
		/// <typeparam name="TStateMachine">Тип конечного автомата.</typeparam>
		// Token: 0x06004670 RID: 18032 RVA: 0x000E65D2 File Offset: 0x000E47D2
		public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			this.m_builder.AwaitOnCompleted<TAwaiter, TStateMachine>(ref awaiter, ref stateMachine);
		}

		/// <summary>Планирует переход конечного автомата к следующему действию по завершении выполнения указанного объекта типа awaiter. Этот метод может вызываться из частично доверенного кода.</summary>
		/// <param name="awaiter">Объект типа awaiter.</param>
		/// <param name="stateMachine">Конечный автомат.</param>
		/// <typeparam name="TAwaiter">Тип объекта типа awaiter.</typeparam>
		/// <typeparam name="TStateMachine">Тип конечного автомата.</typeparam>
		// Token: 0x06004671 RID: 18033 RVA: 0x000E65E1 File Offset: 0x000E47E1
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			this.m_builder.AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref awaiter, ref stateMachine);
		}

		/// <summary>Получает задачу для данного построителя.</summary>
		/// <returns>Задача для этого построителя.</returns>
		/// <exception cref="T:System.InvalidOperationException">Построитель не инициализирован.</exception>
		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06004672 RID: 18034 RVA: 0x000E65F0 File Offset: 0x000E47F0
		public Task Task
		{
			get
			{
				return this.m_builder.Task;
			}
		}

		/// <summary>Отмечает задачу как успешно завершенную.</summary>
		/// <exception cref="T:System.InvalidOperationException">Задача уже завершена.  
		///
		/// или - 
		/// Построитель не инициализирован.</exception>
		// Token: 0x06004673 RID: 18035 RVA: 0x000E65FD File Offset: 0x000E47FD
		public void SetResult()
		{
			this.m_builder.SetResult(AsyncTaskMethodBuilder.s_cachedCompleted);
		}

		/// <summary>Помечает задачу как сбойную и привязывает указанное исключение в задаче.</summary>
		/// <param name="exception">Исключение для привязки к задаче.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="exception" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Задача уже завершена.  
		///
		/// или - 
		/// Построитель не инициализирован.</exception>
		// Token: 0x06004674 RID: 18036 RVA: 0x000E660F File Offset: 0x000E480F
		public void SetException(Exception exception)
		{
			this.m_builder.SetException(exception);
		}

		// Token: 0x06004675 RID: 18037 RVA: 0x000E661D File Offset: 0x000E481D
		internal void SetNotificationForWaitCompletion(bool enabled)
		{
			this.m_builder.SetNotificationForWaitCompletion(enabled);
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06004676 RID: 18038 RVA: 0x000E662B File Offset: 0x000E482B
		internal object ObjectIdForDebugger
		{
			get
			{
				return this.Task;
			}
		}

		// Token: 0x04002D59 RID: 11609
		private static readonly Task<VoidTaskResult> s_cachedCompleted = AsyncTaskMethodBuilder<VoidTaskResult>.s_defaultResultTask;

		// Token: 0x04002D5A RID: 11610
		private AsyncTaskMethodBuilder<VoidTaskResult> m_builder;
	}
}
