using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Security;
using System.Threading;
using System.Threading.Tasks;
using Internal.Threading.Tasks.Tracing;

namespace System.Runtime.CompilerServices
{
	/// <summary>Предоставляет объект, который ожидает завершения асинхронной задачи.</summary>
	// Token: 0x0200080F RID: 2063
	public readonly struct TaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion, ITaskAwaiter
	{
		// Token: 0x06004639 RID: 17977 RVA: 0x000E5BDF File Offset: 0x000E3DDF
		internal TaskAwaiter(Task task)
		{
			this.m_task = task;
		}

		/// <summary>Получает значение, показывающее, завершена ли асинхронная задача.</summary>
		/// <returns>Значение <see langword="true" />, если задача была завершена; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.NullReferenceException">Объект <see cref="T:System.Runtime.CompilerServices.TaskAwaiter" /> не был инициализирован надлежащим образом.</exception>
		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x0600463A RID: 17978 RVA: 0x000E5BE8 File Offset: 0x000E3DE8
		public bool IsCompleted
		{
			get
			{
				return this.m_task.IsCompleted;
			}
		}

		/// <summary>Задает действие, выполняемое, когда объект <see cref="T:System.Runtime.CompilerServices.TaskAwaiter" /> прекращает ожидать завершения выполнения асинхронной задачи.</summary>
		/// <param name="continuation">Действие, которое необходимо выполнить после завершения операции ожидания.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="continuation" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NullReferenceException">Объект <see cref="T:System.Runtime.CompilerServices.TaskAwaiter" /> не был инициализирован надлежащим образом.</exception>
		// Token: 0x0600463B RID: 17979 RVA: 0x000E5BF5 File Offset: 0x000E3DF5
		[SecuritySafeCritical]
		public void OnCompleted(Action continuation)
		{
			TaskAwaiter.OnCompletedInternal(this.m_task, continuation, true, true);
		}

		/// <summary>Планирует действие продолжения для асинхронной задачи, связанной с этим объектом типа awaiter.</summary>
		/// <param name="continuation">Действие, которое необходимо вызвать после завершения операции ожидания.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="continuation" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Объект типа awaiter не был инициализирован надлежащим образом.</exception>
		// Token: 0x0600463C RID: 17980 RVA: 0x000E5C05 File Offset: 0x000E3E05
		[SecurityCritical]
		public void UnsafeOnCompleted(Action continuation)
		{
			TaskAwaiter.OnCompletedInternal(this.m_task, continuation, true, false);
		}

		/// <summary>Завершает ожидание завершения асинхронной задачи.</summary>
		/// <exception cref="T:System.NullReferenceException">Объект <see cref="T:System.Runtime.CompilerServices.TaskAwaiter" /> не был инициализирован надлежащим образом.</exception>
		/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">Задача отменена.</exception>
		/// <exception cref="T:System.Exception">Задача завершилась в состоянии <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" />.</exception>
		// Token: 0x0600463D RID: 17981 RVA: 0x000E5C15 File Offset: 0x000E3E15
		[StackTraceHidden]
		public void GetResult()
		{
			TaskAwaiter.ValidateEnd(this.m_task);
		}

		// Token: 0x0600463E RID: 17982 RVA: 0x000E5C22 File Offset: 0x000E3E22
		[StackTraceHidden]
		internal static void ValidateEnd(Task task)
		{
			if (task.IsWaitNotificationEnabledOrNotRanToCompletion)
			{
				TaskAwaiter.HandleNonSuccessAndDebuggerNotification(task);
			}
		}

		// Token: 0x0600463F RID: 17983 RVA: 0x000E5C34 File Offset: 0x000E3E34
		[StackTraceHidden]
		private static void HandleNonSuccessAndDebuggerNotification(Task task)
		{
			if (!task.IsCompleted)
			{
				task.InternalWait(-1, default(CancellationToken));
			}
			task.NotifyDebuggerOfWaitCompletionIfNecessary();
			if (!task.IsCompletedSuccessfully)
			{
				TaskAwaiter.ThrowForNonSuccess(task);
			}
		}

		// Token: 0x06004640 RID: 17984 RVA: 0x000E5C70 File Offset: 0x000E3E70
		[StackTraceHidden]
		private static void ThrowForNonSuccess(Task task)
		{
			TaskStatus status = task.Status;
			if (status == TaskStatus.Canceled)
			{
				ExceptionDispatchInfo cancellationExceptionDispatchInfo = task.GetCancellationExceptionDispatchInfo();
				if (cancellationExceptionDispatchInfo != null)
				{
					cancellationExceptionDispatchInfo.Throw();
				}
				throw new TaskCanceledException(task);
			}
			if (status != TaskStatus.Faulted)
			{
				return;
			}
			ReadOnlyCollection<ExceptionDispatchInfo> exceptionDispatchInfos = task.GetExceptionDispatchInfos();
			if (exceptionDispatchInfos.Count > 0)
			{
				exceptionDispatchInfos[0].Throw();
				return;
			}
			throw task.Exception;
		}

		// Token: 0x06004641 RID: 17985 RVA: 0x000E5CC7 File Offset: 0x000E3EC7
		internal static void OnCompletedInternal(Task task, Action continuation, bool continueOnCapturedContext, bool flowExecutionContext)
		{
			if (continuation == null)
			{
				throw new ArgumentNullException("continuation");
			}
			if (TaskTrace.Enabled)
			{
				continuation = TaskAwaiter.OutputWaitEtwEvents(task, continuation);
			}
			task.SetContinuationForAwait(continuation, continueOnCapturedContext, flowExecutionContext);
		}

		// Token: 0x06004642 RID: 17986 RVA: 0x000E5CF0 File Offset: 0x000E3EF0
		private static Action OutputWaitEtwEvents(Task task, Action continuation)
		{
			Task internalCurrent = Task.InternalCurrent;
			TaskTrace.TaskWaitBegin_Asynchronous((internalCurrent != null) ? internalCurrent.m_taskScheduler.Id : TaskScheduler.Default.Id, (internalCurrent != null) ? internalCurrent.Id : 0, task.Id);
			return delegate()
			{
				if (TaskTrace.Enabled)
				{
					Task internalCurrent2 = Task.InternalCurrent;
					TaskTrace.TaskWaitEnd((internalCurrent2 != null) ? internalCurrent2.m_taskScheduler.Id : TaskScheduler.Default.Id, (internalCurrent2 != null) ? internalCurrent2.Id : 0, task.Id);
				}
				continuation();
			};
		}

		// Token: 0x04002D49 RID: 11593
		internal readonly Task m_task;
	}
}
