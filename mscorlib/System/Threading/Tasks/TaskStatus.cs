using System;

namespace System.Threading.Tasks
{
	/// <summary>Представляет текущий этап жизненного цикла задачи <see cref="T:System.Threading.Tasks.Task" />.</summary>
	// Token: 0x02000356 RID: 854
	public enum TaskStatus
	{
		/// <summary>Задача инициализирована, но еще не запланирована.</summary>
		// Token: 0x04001CC1 RID: 7361
		Created,
		/// <summary>Задача ожидает активации и внутреннего планирования инфраструктурой платформы .NET Framework.</summary>
		// Token: 0x04001CC2 RID: 7362
		WaitingForActivation,
		/// <summary>Задача запланирована для выполнения, но еще не начала выполняться.</summary>
		// Token: 0x04001CC3 RID: 7363
		WaitingToRun,
		/// <summary>Задача выполняется, но еще не завершилась.</summary>
		// Token: 0x04001CC4 RID: 7364
		Running,
		/// <summary>Задача закончила выполнение и неявно ожидает завершения подключенных к ней дочерних задач.</summary>
		// Token: 0x04001CC5 RID: 7365
		WaitingForChildrenToComplete,
		/// <summary>Задача успешно завершена.</summary>
		// Token: 0x04001CC6 RID: 7366
		RanToCompletion,
		/// <summary>Задача приняла отмену, создав исключение OperationCanceledException с собственным токеном CancellationToken, пока он находился в состоянии получения сигнала, или токен CancellationToken задачи уже получил сигнал до начала выполнения задачи. Дополнительные сведения см. в разделе Отмена задач.</summary>
		// Token: 0x04001CC7 RID: 7367
		Canceled,
		/// <summary>Задача завершилась из-за необработанного исключения.</summary>
		// Token: 0x04001CC8 RID: 7368
		Faulted
	}
}
