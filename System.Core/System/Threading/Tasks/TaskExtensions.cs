using System;

namespace System.Threading.Tasks
{
	/// <summary>
	///         Предоставляет набор статических (Shared в Visual Basic) методов для работы с определенными типами из <see cref="T:System.Threading.Tasks.Task" /> экземпляров.
	///       </summary>
	// Token: 0x02000366 RID: 870
	public static class TaskExtensions
	{
		/// <summary>
		///         Создает прокси <see cref="T:System.Threading.Tasks.Task" /> представляющий собой асинхронную операцию <see cref="M:System.Threading.Tasks.TaskScheduler.TryExecuteTaskInline(System.Threading.Tasks.Task,System.Boolean)" />.
		///       </summary>
		/// <param name="task">
		///           <see langword="Task&lt;Task&gt;" /> (C#) или <see langword="Task (Of Task)" /> (Visual Basic), чтобы разворачивать.
		///         </param>
		/// <returns>
		///         Задача, представляющая асинхронную операцию указанных <see langword="System.Threading.Tasks.Task(Of Task)" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Исключение, возникающее, если <paramref name="task" /> аргумент имеет значение null.
		///           </exception>
		// Token: 0x06001AA5 RID: 6821 RVA: 0x00059FF0 File Offset: 0x000581F0
		public static Task Unwrap(this Task<Task> task)
		{
			if (task == null)
			{
				throw new ArgumentNullException("task");
			}
			Task result;
			if (task.IsCompletedSuccessfully)
			{
				if ((result = task.Result) == null)
				{
					return Task.FromCanceled(new CancellationToken(true));
				}
			}
			else
			{
				result = Task.CreateUnwrapPromise<VoidTaskResult>(task, false);
			}
			return result;
		}

		/// <summary>
		///         Создает прокси <see cref="T:System.Threading.Tasks.Task" /> представляющий собой асинхронную операцию <see langword="Task&lt;Task&lt;T&gt;&gt;" /> (C#) или <see langword="Task (Of Task(Of T))" /> (Visual Basic).
		///       </summary>
		/// <param name="task">
		///           <see langword="Task&lt;Task&lt;T&gt;&gt;" /> (C#) или <see langword="Task (Of Task(Of T))" /> (Visual Basic), чтобы разворачивать.
		///         </param>
		/// <typeparam name="TResult">
		///           Тип результата задачи.
		///         </typeparam>
		/// <returns>
		///         Объект <see cref="T:System.Threading.Tasks.Task" /> представляющий асинхронную операцию указанных <see langword="Task&lt;Task&lt;T&gt;&gt;" /> (C#) или <see langword="Task (Of Task(Of T))" /> (Visual Basic).
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Исключение, возникающее, если <paramref name="task" /> аргумент имеет значение null.
		///           </exception>
		// Token: 0x06001AA6 RID: 6822 RVA: 0x0005A025 File Offset: 0x00058225
		public static Task<TResult> Unwrap<TResult>(this Task<Task<TResult>> task)
		{
			if (task == null)
			{
				throw new ArgumentNullException("task");
			}
			Task<TResult> result;
			if (task.IsCompletedSuccessfully)
			{
				if ((result = task.Result) == null)
				{
					return Task.FromCanceled<TResult>(new CancellationToken(true));
				}
			}
			else
			{
				result = Task.CreateUnwrapPromise<TResult>(task, false);
			}
			return result;
		}
	}
}
