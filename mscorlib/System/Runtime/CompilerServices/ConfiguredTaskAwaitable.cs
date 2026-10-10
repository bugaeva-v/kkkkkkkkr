using System;
using System.Diagnostics;
using System.Security;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	/// <summary>Предоставляет объект типа awaitable, который включает настроенные объекты типа awaiter для задачи.</summary>
	// Token: 0x02000814 RID: 2068
	public readonly struct ConfiguredTaskAwaitable
	{
		// Token: 0x0600464A RID: 17994 RVA: 0x000E5E05 File Offset: 0x000E4005
		internal ConfiguredTaskAwaitable(Task task, bool continueOnCapturedContext)
		{
			this.m_configuredTaskAwaiter = new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(task, continueOnCapturedContext);
		}

		/// <summary>Возвращает объект типа awaiter для этого объекта типа awaitable.</summary>
		/// <returns>Объект типа awaiter.</returns>
		// Token: 0x0600464B RID: 17995 RVA: 0x000E5E14 File Offset: 0x000E4014
		public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter()
		{
			return this.m_configuredTaskAwaiter;
		}

		// Token: 0x04002D4D RID: 11597
		private readonly ConfiguredTaskAwaitable.ConfiguredTaskAwaiter m_configuredTaskAwaiter;

		/// <summary>Предоставляет объект типа awaiter для объекта awaitable (<see cref="T:System.Runtime.CompilerServices.ConfiguredTaskAwaitable" />).</summary>
		// Token: 0x02000815 RID: 2069
		public readonly struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion, IConfiguredTaskAwaiter
		{
			// Token: 0x0600464C RID: 17996 RVA: 0x000E5E1C File Offset: 0x000E401C
			internal ConfiguredTaskAwaiter(Task task, bool continueOnCapturedContext)
			{
				this.m_task = task;
				this.m_continueOnCapturedContext = continueOnCapturedContext;
			}

			/// <summary>Получает значение, указывающее, завершена ли ожидаемая задача.</summary>
			/// <returns>Значение <see langword="true" />, если задача, выполнение которой ожидается, завершена; в противном случае — значение <see langword="false" />.</returns>
			/// <exception cref="T:System.NullReferenceException">Объект типа awaiter не был инициализирован надлежащим образом.</exception>
			// Token: 0x17000AD2 RID: 2770
			// (get) Token: 0x0600464D RID: 17997 RVA: 0x000E5E2C File Offset: 0x000E402C
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
			// Token: 0x0600464E RID: 17998 RVA: 0x000E5E39 File Offset: 0x000E4039
			[SecuritySafeCritical]
			public void OnCompleted(Action continuation)
			{
				TaskAwaiter.OnCompletedInternal(this.m_task, continuation, this.m_continueOnCapturedContext, true);
			}

			/// <summary>Планирует действие продолжения для задачи, связанной с этим объектом типа awaiter.</summary>
			/// <param name="continuation">Действие, которое необходимо вызвать после завершения операции ожидания.</param>
			/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="continuation" /> имеет значение <see langword="null" />.</exception>
			/// <exception cref="T:System.NullReferenceException">Объект типа awaiter не был инициализирован надлежащим образом.</exception>
			// Token: 0x0600464F RID: 17999 RVA: 0x000E5E4E File Offset: 0x000E404E
			[SecurityCritical]
			public void UnsafeOnCompleted(Action continuation)
			{
				TaskAwaiter.OnCompletedInternal(this.m_task, continuation, this.m_continueOnCapturedContext, false);
			}

			/// <summary>Завершает ожидание в завершенной задачи.</summary>
			/// <exception cref="T:System.NullReferenceException">Объект типа awaiter не был инициализирован надлежащим образом.</exception>
			/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">Задача отменена.</exception>
			/// <exception cref="T:System.Exception">Задача завершилась состоянием сбоя.</exception>
			// Token: 0x06004650 RID: 18000 RVA: 0x000E5E63 File Offset: 0x000E4063
			[StackTraceHidden]
			public void GetResult()
			{
				TaskAwaiter.ValidateEnd(this.m_task);
			}

			// Token: 0x04002D4E RID: 11598
			internal readonly Task m_task;

			// Token: 0x04002D4F RID: 11599
			internal readonly bool m_continueOnCapturedContext;
		}
	}
}
