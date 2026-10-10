using System;
using System.Diagnostics;
using System.Security;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	/// <summary>Представляет объект, который ожидает завершения асинхронной задачи и предоставляет параметр для результата.</summary>
	/// <typeparam name="TResult">Результат для задачи.</typeparam>
	// Token: 0x02000811 RID: 2065
	public readonly struct TaskAwaiter<TResult> : ICriticalNotifyCompletion, INotifyCompletion, ITaskAwaiter
	{
		// Token: 0x06004645 RID: 17989 RVA: 0x000E5DB7 File Offset: 0x000E3FB7
		internal TaskAwaiter(Task<TResult> task)
		{
			this.m_task = task;
		}

		/// <summary>Получает значение, показывающее, завершена ли асинхронная задача.</summary>
		/// <returns>Значение <see langword="true" />, если задача была завершена; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.NullReferenceException">Объект <see cref="T:System.Runtime.CompilerServices.TaskAwaiter`1" /> не был инициализирован надлежащим образом.</exception>
		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06004646 RID: 17990 RVA: 0x000E5DC0 File Offset: 0x000E3FC0
		public bool IsCompleted
		{
			get
			{
				return this.m_task.IsCompleted;
			}
		}

		/// <summary>Задает действие, выполняемое, когда объект <see cref="T:System.Runtime.CompilerServices.TaskAwaiter`1" /> прекращает ожидать завершения выполнения асинхронной задачи.</summary>
		/// <param name="continuation">Действие, которое необходимо выполнить после завершения операции ожидания.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="continuation" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NullReferenceException">Объект <see cref="T:System.Runtime.CompilerServices.TaskAwaiter`1" /> не был инициализирован надлежащим образом.</exception>
		// Token: 0x06004647 RID: 17991 RVA: 0x000E5DCD File Offset: 0x000E3FCD
		[SecuritySafeCritical]
		public void OnCompleted(Action continuation)
		{
			TaskAwaiter.OnCompletedInternal(this.m_task, continuation, true, true);
		}

		/// <summary>Планирует действие продолжения для асинхронной задачи, связанной с этим объектом типа awaiter.</summary>
		/// <param name="continuation">Действие, которое необходимо вызвать после завершения операции ожидания.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="continuation" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Объект типа awaiter не был инициализирован надлежащим образом.</exception>
		// Token: 0x06004648 RID: 17992 RVA: 0x000E5DDD File Offset: 0x000E3FDD
		[SecurityCritical]
		public void UnsafeOnCompleted(Action continuation)
		{
			TaskAwaiter.OnCompletedInternal(this.m_task, continuation, true, false);
		}

		/// <summary>Завершает ожидание завершения асинхронной задачи.</summary>
		/// <returns>Результат завершенной задачи.</returns>
		/// <exception cref="T:System.NullReferenceException">Объект <see cref="T:System.Runtime.CompilerServices.TaskAwaiter`1" /> не был инициализирован надлежащим образом.</exception>
		/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">Задача отменена.</exception>
		/// <exception cref="T:System.Exception">Задача завершилась в состоянии <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" />.</exception>
		// Token: 0x06004649 RID: 17993 RVA: 0x000E5DED File Offset: 0x000E3FED
		[StackTraceHidden]
		public TResult GetResult()
		{
			TaskAwaiter.ValidateEnd(this.m_task);
			return this.m_task.ResultOnSuccess;
		}

		// Token: 0x04002D4C RID: 11596
		private readonly Task<TResult> m_task;
	}
}
