using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	/// <summary>Представляет объект, обрабатывающий низкоуровневую постановку задач в очередь на потоки.</summary>
	// Token: 0x02000379 RID: 889
	[DebuggerDisplay("Id={Id}")]
	[DebuggerTypeProxy(typeof(TaskScheduler.SystemThreadingTasks_TaskSchedulerDebugView))]
	public abstract class TaskScheduler
	{
		/// <summary>Ставит объект <see cref="T:System.Threading.Tasks.Task" /> в очередь планировщика.</summary>
		/// <param name="task">Помещаемый в очередь объект <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="task" /> имеет значение NULL.</exception>
		// Token: 0x06002510 RID: 9488
		protected internal abstract void QueueTask(Task task);

		/// <summary>Определяет, можно ли выполнить предоставленную задачу <see cref="T:System.Threading.Tasks.Task" /> в этом вызове синхронно, и если возможно, выполняет ее.</summary>
		/// <param name="task">Выполняемый объект <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <param name="taskWasPreviouslyQueued">Логическое значение, указывающее, была ли задача ранее поставлена в очередь. Если этот параметр имеет значение True, задача могла ранее быть в очереди; если он имеет значение False, задача не была поставлена в очередь, а данный вызов совершается для выполнения задачи на месте без постановки в очередь.</param>
		/// <returns>Логическое значение, определяющее, была ли задача выполнена на месте.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="task" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="task" /> уже выполнена.</exception>
		// Token: 0x06002511 RID: 9489
		protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued);

		/// <summary>Создает перечисляемый объект экземпляров <see cref="T:System.Threading.Tasks.Task" />, которые в настоящее время находятся в очереди планировщика, ожидая выполнения (только для поддержки отладки).</summary>
		/// <returns>Перечисляемый объект, позволяющий отладчику перемещаться по задачам, которые находятся в очереди данного планировщика.</returns>
		/// <exception cref="T:System.NotSupportedException">Этому планировщику не удается создать список находящихся в данный момент в очереди задач.</exception>
		// Token: 0x06002512 RID: 9490
		protected abstract IEnumerable<Task> GetScheduledTasks();

		/// <summary>Указывает максимальный уровень параллелизма, который может поддерживаться данным планировщиком <see cref="T:System.Threading.Tasks.TaskScheduler" />.</summary>
		/// <returns>Возвращает целое число, представляющее максимальный уровень параллелизма. Планировщик по умолчанию возвращает значение свойства <see cref="F:System.Int32.MaxValue" />.</returns>
		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06002513 RID: 9491 RVA: 0x00084082 File Offset: 0x00082282
		public virtual int MaximumConcurrencyLevel
		{
			get
			{
				return int.MaxValue;
			}
		}

		// Token: 0x06002514 RID: 9492 RVA: 0x0008408C File Offset: 0x0008228C
		internal bool TryRunInline(Task task, bool taskWasPreviouslyQueued)
		{
			TaskScheduler executingTaskScheduler = task.ExecutingTaskScheduler;
			if (executingTaskScheduler != this && executingTaskScheduler != null)
			{
				return executingTaskScheduler.TryRunInline(task, taskWasPreviouslyQueued);
			}
			StackGuard currentStackGuard;
			if (executingTaskScheduler == null || task.m_action == null || task.IsDelegateInvoked || task.IsCanceled || !(currentStackGuard = Task.CurrentStackGuard).TryBeginInliningScope())
			{
				return false;
			}
			bool flag = false;
			try
			{
				flag = this.TryExecuteTaskInline(task, taskWasPreviouslyQueued);
			}
			finally
			{
				currentStackGuard.EndInliningScope();
			}
			if (flag && !task.IsDelegateInvoked && !task.IsCanceled)
			{
				throw new InvalidOperationException("The TryExecuteTaskInline call to the underlying scheduler succeeded, but the task body was not invoked.");
			}
			return flag;
		}

		/// <summary>Пытается удалить из очереди задачу <see cref="T:System.Threading.Tasks.Task" />, ранее поставленную в очередь данного планировщика.</summary>
		/// <param name="task">Объект <see cref="T:System.Threading.Tasks.Task" /> для удаления из очереди.</param>
		/// <returns>Логическое значение, указывающее, был ли аргумент <paramref name="task" /> успешно удален из очереди.</returns>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="task" /> имеет значение NULL.</exception>
		// Token: 0x06002515 RID: 9493 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		protected internal virtual bool TryDequeue(Task task)
		{
			return false;
		}

		// Token: 0x06002516 RID: 9494 RVA: 0x00004BF9 File Offset: 0x00002DF9
		internal virtual void NotifyWorkItemProgress()
		{
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06002517 RID: 9495 RVA: 0x000040F7 File Offset: 0x000022F7
		internal virtual bool RequiresAtomicStartTransition
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06002519 RID: 9497 RVA: 0x00084120 File Offset: 0x00082320
		private void AddToActiveTaskSchedulers()
		{
			ConditionalWeakTable<TaskScheduler, object> conditionalWeakTable = TaskScheduler.s_activeTaskSchedulers;
			if (conditionalWeakTable == null)
			{
				Interlocked.CompareExchange<ConditionalWeakTable<TaskScheduler, object>>(ref TaskScheduler.s_activeTaskSchedulers, new ConditionalWeakTable<TaskScheduler, object>(), null);
				conditionalWeakTable = TaskScheduler.s_activeTaskSchedulers;
			}
			conditionalWeakTable.Add(this, null);
		}

		/// <summary>Получает экземпляр <see cref="T:System.Threading.Tasks.TaskScheduler" /> по умолчанию, предоставляемый платформой .NET Framework.</summary>
		/// <returns>Возвращает экземпляр <see cref="T:System.Threading.Tasks.TaskScheduler" /> по умолчанию.</returns>
		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x0600251A RID: 9498 RVA: 0x00084155 File Offset: 0x00082355
		public static TaskScheduler Default
		{
			get
			{
				return TaskScheduler.s_defaultTaskScheduler;
			}
		}

		/// <summary>Получает объект <see cref="T:System.Threading.Tasks.TaskScheduler" />, связанный с выполняемой в настоящий момент задачей.</summary>
		/// <returns>Возвращает объект <see cref="T:System.Threading.Tasks.TaskScheduler" />, связанный с выполняемой в настоящий момент задачей.</returns>
		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x0600251B RID: 9499 RVA: 0x0008415C File Offset: 0x0008235C
		public static TaskScheduler Current
		{
			get
			{
				return TaskScheduler.InternalCurrent ?? TaskScheduler.Default;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x0600251C RID: 9500 RVA: 0x0008416C File Offset: 0x0008236C
		internal static TaskScheduler InternalCurrent
		{
			get
			{
				Task internalCurrent = Task.InternalCurrent;
				if (internalCurrent == null || (internalCurrent.CreationOptions & TaskCreationOptions.HideScheduler) != TaskCreationOptions.None)
				{
					return null;
				}
				return internalCurrent.ExecutingTaskScheduler;
			}
		}

		/// <summary>Создает <see cref="T:System.Threading.Tasks.TaskScheduler" /> для связывания с текущим элементом <see cref="T:System.Threading.SynchronizationContext" />.</summary>
		/// <returns>
		///   <see cref="T:System.Threading.Tasks.TaskScheduler" /> для связывания с текущим элементом <see cref="T:System.Threading.SynchronizationContext" />, как определено в <see cref="P:System.Threading.SynchronizationContext.Current" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Текущий SynchronizationContext нельзя использовать как TaskScheduler.</exception>
		// Token: 0x0600251D RID: 9501 RVA: 0x00084195 File Offset: 0x00082395
		public static TaskScheduler FromCurrentSynchronizationContext()
		{
			return new SynchronizationContextTaskScheduler();
		}

		/// <summary>Получает уникальный идентификатор данного объекта <see cref="T:System.Threading.Tasks.TaskScheduler" />.</summary>
		/// <returns>Возвращает уникальный идентификатор для данного объекта <see cref="T:System.Threading.Tasks.TaskScheduler" />.</returns>
		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x0600251E RID: 9502 RVA: 0x0008419C File Offset: 0x0008239C
		public int Id
		{
			get
			{
				if (this.m_taskSchedulerId == 0)
				{
					int num;
					do
					{
						num = Interlocked.Increment(ref TaskScheduler.s_taskSchedulerIdCounter);
					}
					while (num == 0);
					Interlocked.CompareExchange(ref this.m_taskSchedulerId, num, 0);
				}
				return this.m_taskSchedulerId;
			}
		}

		/// <summary>Пытается выполнить предоставленную задачу <see cref="T:System.Threading.Tasks.Task" /> в этом планировщике.</summary>
		/// <param name="task">Выполняемая задача <see cref="T:System.Threading.Tasks.Task" />.</param>
		/// <returns>Логическое значение true, если задача <paramref name="task" /> успешно выполнена; в противном случае — значение false. Общая причина ошибки выполнения состоит в том, что задача выполнялась ранее или выполняется другим потоком.</returns>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="task" /> не связана с данным планировщиком.</exception>
		// Token: 0x0600251F RID: 9503 RVA: 0x000841D9 File Offset: 0x000823D9
		protected bool TryExecuteTask(Task task)
		{
			if (task.ExecutingTaskScheduler != this)
			{
				throw new InvalidOperationException("ExecuteTask may not be called for a task which was previously queued to a different TaskScheduler.");
			}
			return task.ExecuteEntry(true);
		}

		/// <summary>Создается при активации политики эскалации исключений из-за непредвиденного исключения задачи, завершившейся сбоем. По умолчанию из-за этой политики процесс будет прерван.</summary>
		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06002520 RID: 9504 RVA: 0x000841F8 File Offset: 0x000823F8
		// (remove) Token: 0x06002521 RID: 9505 RVA: 0x00084248 File Offset: 0x00082448
		public static event EventHandler<UnobservedTaskExceptionEventArgs> UnobservedTaskException
		{
			add
			{
				if (value != null)
				{
					using (LockHolder.Hold(TaskScheduler._unobservedTaskExceptionLockObject))
					{
						TaskScheduler._unobservedTaskException = (EventHandler<UnobservedTaskExceptionEventArgs>)Delegate.Combine(TaskScheduler._unobservedTaskException, value);
					}
				}
			}
			remove
			{
				using (LockHolder.Hold(TaskScheduler._unobservedTaskExceptionLockObject))
				{
					TaskScheduler._unobservedTaskException = (EventHandler<UnobservedTaskExceptionEventArgs>)Delegate.Remove(TaskScheduler._unobservedTaskException, value);
				}
			}
		}

		// Token: 0x06002522 RID: 9506 RVA: 0x00084298 File Offset: 0x00082498
		internal static void PublishUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs ueea)
		{
			using (LockHolder.Hold(TaskScheduler._unobservedTaskExceptionLockObject))
			{
				EventHandler<UnobservedTaskExceptionEventArgs> unobservedTaskException = TaskScheduler._unobservedTaskException;
				if (unobservedTaskException != null)
				{
					unobservedTaskException(sender, ueea);
				}
			}
		}

		// Token: 0x06002523 RID: 9507 RVA: 0x000842E4 File Offset: 0x000824E4
		internal Task[] GetScheduledTasksForDebugger()
		{
			IEnumerable<Task> scheduledTasks = this.GetScheduledTasks();
			if (scheduledTasks == null)
			{
				return null;
			}
			Task[] array = scheduledTasks as Task[];
			if (array == null)
			{
				array = new LowLevelList<Task>(scheduledTasks).ToArray();
			}
			Task[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				int id = array2[i].Id;
			}
			return array;
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x00084330 File Offset: 0x00082530
		internal static TaskScheduler[] GetTaskSchedulersForDebugger()
		{
			if (TaskScheduler.s_activeTaskSchedulers == null)
			{
				return new TaskScheduler[]
				{
					TaskScheduler.s_defaultTaskScheduler
				};
			}
			LowLevelList<TaskScheduler> lowLevelList = new LowLevelList<TaskScheduler>();
			foreach (KeyValuePair<TaskScheduler, object> keyValuePair in ((IEnumerable<KeyValuePair<TaskScheduler, object>>)TaskScheduler.s_activeTaskSchedulers))
			{
				lowLevelList.Add(keyValuePair.Key);
			}
			if (!lowLevelList.Contains(TaskScheduler.s_defaultTaskScheduler))
			{
				lowLevelList.Add(TaskScheduler.s_defaultTaskScheduler);
			}
			TaskScheduler[] array = lowLevelList.ToArray();
			TaskScheduler[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				int id = array2[i].Id;
			}
			return array;
		}

		// Token: 0x04001D4D RID: 7501
		private static ConditionalWeakTable<TaskScheduler, object> s_activeTaskSchedulers;

		// Token: 0x04001D4E RID: 7502
		private static readonly TaskScheduler s_defaultTaskScheduler = new ThreadPoolTaskScheduler();

		// Token: 0x04001D4F RID: 7503
		internal static int s_taskSchedulerIdCounter;

		// Token: 0x04001D50 RID: 7504
		private volatile int m_taskSchedulerId;

		// Token: 0x04001D51 RID: 7505
		private static EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException;

		// Token: 0x04001D52 RID: 7506
		private static readonly Lock _unobservedTaskExceptionLockObject = new Lock();

		// Token: 0x0200037A RID: 890
		internal sealed class SystemThreadingTasks_TaskSchedulerDebugView
		{
			// Token: 0x06002526 RID: 9510 RVA: 0x000843F6 File Offset: 0x000825F6
			public SystemThreadingTasks_TaskSchedulerDebugView(TaskScheduler scheduler)
			{
				this.m_taskScheduler = scheduler;
			}

			// Token: 0x1700047E RID: 1150
			// (get) Token: 0x06002527 RID: 9511 RVA: 0x00084405 File Offset: 0x00082605
			public int Id
			{
				get
				{
					return this.m_taskScheduler.Id;
				}
			}

			// Token: 0x1700047F RID: 1151
			// (get) Token: 0x06002528 RID: 9512 RVA: 0x00084412 File Offset: 0x00082612
			public IEnumerable<Task> ScheduledTasks
			{
				get
				{
					return this.m_taskScheduler.GetScheduledTasks();
				}
			}

			// Token: 0x04001D53 RID: 7507
			private readonly TaskScheduler m_taskScheduler;
		}
	}
}
