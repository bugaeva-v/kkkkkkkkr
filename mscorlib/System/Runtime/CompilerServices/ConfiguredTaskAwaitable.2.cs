using System;
using System.Diagnostics;
using System.Security;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	/// <summary>Предоставляет объект типа awaitable, который включает настроенные объекты типа awaiter для задачи.</summary>
	/// <typeparam name="TResult">Тип результата, созданного данной задачей <see cref="T:System.Threading.Tasks.Task`1" />.</typeparam>
	// Token: 0x02000816 RID: 2070
	public readonly struct ConfiguredTaskAwaitable<TResult>
	{
		// Token: 0x06004651 RID: 18001 RVA: 0x000E5E70 File Offset: 0x000E4070
		internal ConfiguredTaskAwaitable(Task<TResult> task, bool continueOnCapturedContext)
		{
			this.m_configuredTaskAwaiter = new ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter(task, continueOnCapturedContext);
		}

		/// <summary>Возвращает объект типа awaiter для этого объекта типа awaitable.</summary>
		/// <returns>Объект типа awaiter.</returns>
		// Token: 0x06004652 RID: 18002 RVA: 0x000E5E7F File Offset: 0x000E407F
		public ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter GetAwaiter()
		{
			return this.m_configuredTaskAwaiter;
		}

		// Token: 0x04002D50 RID: 11600
		private readonly ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter m_configuredTaskAwaiter;

		/// <summary>Предоставляет объект типа awaiter для объекта типа awaitable (<see cref="T:System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1" />).</summary>
		/// <typeparam name="TResult" />
		// Token: 0x02000817 RID: 2071
		public readonly struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion, IConfiguredTaskAwaiter
		{
			// Token: 0x06004653 RID: 18003 RVA: 0x000E5E87 File Offset: 0x000E4087
			internal ConfiguredTaskAwaiter(Task<TResult> task, bool continueOnCapturedContext)
			{
				this.m_task = task;
				this.m_continueOnCapturedContext = continueOnCapturedContext;
			}

			/// <summary>Возвращает значение, указывающее, завершена ли ожидаемая задача.</summary>
			/// <returns>Значение <see langword="true" />, если задача, выполнение которой ожидается, завершена; в противном случае — значение <see langword="false" />.</returns>
			/// <exception cref="T:System.NullReferenceException">Объект типа awaiter не был инициализирован надлежащим образом.</exception>
			// Token: 0x17000AD3 RID: 2771
			// (get) Token: 0x06004654 RID: 18004 RVA: 0x000E5E97 File Offset: 0x000E4097
			public bool IsCompleted
			{
				get
				{
					return this.m_task.IsCompleted;
				}
			}

			/// <summary>Планирует действие продолжения для задачи, связанной с этим объектом типа awaiter.</summary>
			/// <param name="continuation">Действие, которое необходимо вызвать после завершения операции ожидания.</param>
			/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuation" /> имеет значение <see langword="null" />.</exception>
			/// <exception cref="T:System.NullReferenceException">Объект типа awaiter не был инициализирован надлежащим образом.</exception>
			// Token: 0x06004655 RID: 18005 RVA: 0x000E5EA4 File Offset: 0x000E40A4
			[SecuritySafeCritical]
			public void OnCompleted(Action continuation)
			{
				TaskAwaiter.OnCompletedInternal(this.m_task, continuation, this.m_continueOnCapturedContext, true);
			}

			/// <summary>Планирует действие продолжения для задачи, связанной с этим объектом типа awaiter.</summary>
			/// <param name="continuation">Действие, которое необходимо вызвать после завершения операции ожидания.</param>
			/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuation" /> имеет значение <see langword="null" />.</exception>
			/// <exception cref="T:System.NullReferenceException">Объект типа awaiter не был инициализирован надлежащим образом.</exception>
			// Token: 0x06004656 RID: 18006 RVA: 0x000E5EB9 File Offset: 0x000E40B9
			[SecurityCritical]
			public void UnsafeOnCompleted(Action continuation)
			{
				TaskAwaiter.OnCompletedInternal(this.m_task, continuation, this.m_continueOnCapturedContext, false);
			}

			/// <summary>Завершает ожидание в завершенной задачи.</summary>
			/// <returns>Результат завершенной задачи.</returns>
			/// <exception cref="T:System.NullReferenceException">Объект типа awaiter не был инициализирован надлежащим образом.</exception>
			/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">Задача отменена.</exception>
			/// <exception cref="T:System.Exception">Задача завершилась состоянием сбоя.</exception>
			// Token: 0x06004657 RID: 18007 RVA: 0x000E5ECE File Offset: 0x000E40CE
			[StackTraceHidden]
			public TResult GetResult()
			{
				TaskAwaiter.ValidateEnd(this.m_task);
				return this.m_task.ResultOnSuccess;
			}

			// Token: 0x04002D51 RID: 11601
			private readonly Task<TResult> m_task;

			// Token: 0x04002D52 RID: 11602
			private readonly bool m_continueOnCapturedContext;
		}
	}
}
