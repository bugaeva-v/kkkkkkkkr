using System;

namespace System.Threading.Tasks
{
	/// <summary>Задает поведение для задачи, созданной с помощью метода <see cref="M:System.Threading.Tasks.Task.ContinueWith(System.Action{System.Threading.Tasks.Task},System.Threading.CancellationToken,System.Threading.Tasks.TaskContinuationOptions,System.Threading.Tasks.TaskScheduler)" /> или <see cref="M:System.Threading.Tasks.Task`1.ContinueWith(System.Action{System.Threading.Tasks.Task{`0}},System.Threading.Tasks.TaskContinuationOptions)" />.</summary>
	// Token: 0x02000363 RID: 867
	[Flags]
	public enum TaskContinuationOptions
	{
		/// <summary>Если параметры продолжения не указаны, указывает поведение по умолчанию, которое следует использовать при выполнении продолжения. После завершения предыдущей задачи продолжение выполняется асинхронно независимо от конечного значения свойства <see cref="P:System.Threading.Tasks.Task.Status" /> предшествующей задачи. Если продолжение является дочерней задачей, оно создается как отсоединенная вложенная задача.</summary>
		// Token: 0x04001D16 RID: 7446
		None = 0,
		/// <summary>Указание для планирования задач <see cref="T:System.Threading.Tasks.TaskScheduler" /> в том порядке, в котором они были запланированы, т. е. задачи, запланированные ранее, будут выполняться ранее, а более поздние —позже.</summary>
		// Token: 0x04001D17 RID: 7447
		PreferFairness = 1,
		/// <summary>Указывает, что продолжение будет длительной подробной операцией. Предоставляет сведения для <see cref="T:System.Threading.Tasks.TaskScheduler" />, что следует ожидать избыточной подписки.</summary>
		// Token: 0x04001D18 RID: 7448
		LongRunning = 2,
		/// <summary>Указывает, что если продолжение является дочерней задачей, оно присоединяется к родительской задаче в иерархии задач. Продолжение может быть дочерней задачей, только если ее предшествующая задача тоже была дочерней. По умолчанию дочерняя задача (это внутренняя задача, создаваемая внешней задачей) выполняется независимо от своей родительской задачи. Вы можете воспользоваться параметром <see cref="F:System.Threading.Tasks.TaskContinuationOptions.AttachedToParent" />, чтобы синхронизировать родительские и дочерние задачи.  
		/// Обратите внимание, что если родительская задача настроена с параметром <see cref="F:System.Threading.Tasks.TaskCreationOptions.DenyChildAttach" />, параметр <see cref="F:System.Threading.Tasks.TaskCreationOptions.AttachedToParent" /> в дочерней задаче не действует, и эта дочерняя задача будет выполняться как отсоединенная.  
		/// Дополнительные сведения см. в разделе Присоединенные и отсоединенные дочерние задачи.</summary>
		// Token: 0x04001D19 RID: 7449
		AttachedToParent = 4,
		/// <summary>Указывает, что любая дочерняя задача (т. е. любая вложенная задача, созданная продолжением), которая создается с параметром <see cref="F:System.Threading.Tasks.TaskCreationOptions.AttachedToParent" /> и для которой производится попытка выполнения в качестве подключенной дочерней задачи, не сможет подключиться к родительской задаче и будет выполняться как отсоединенная дочерняя задача. Дополнительные сведения см. в разделе Присоединенные и отсоединенные дочерние задачи.</summary>
		// Token: 0x04001D1A RID: 7450
		DenyChildAttach = 8,
		/// <summary>Указывает, что в задачах, созданных путем вызова таких методов, как <see cref="M:System.Threading.Tasks.Task.Run(System.Action)" /> или <see cref="M:System.Threading.Tasks.Task.ContinueWith(System.Action{System.Threading.Tasks.Task})" />, в качестве текущего планировщика отображается планировщик по умолчанию (<see cref="P:System.Threading.Tasks.TaskScheduler.Default" />), а не планировщик, в котором запущено продолжение.</summary>
		// Token: 0x04001D1B RID: 7451
		HideScheduler = 16,
		/// <summary>В случае отмены продолжения предотвращает завершение продолжения до тех пор, пока не будет завершена предшествующая задача.</summary>
		// Token: 0x04001D1C RID: 7452
		LazyCancellation = 32,
		/// <summary>Указывает, что задача продолжения должна выполняться асинхронно.  Этот приоритет имеет приоритет над <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</summary>
		// Token: 0x04001D1D RID: 7453
		RunContinuationsAsynchronously = 64,
		/// <summary>Указывает, что задача продолжения не должна планироваться, если предшествующая ей задача завершилась. Предшествующая задача выполняется полностью, если после завершения ее свойство <see cref="P:System.Threading.Tasks.Task.Status" /> имеет значение <see cref="F:System.Threading.Tasks.TaskStatus.RanToCompletion" />. Данный параметр не является действительным для продолжений нескольких задач.</summary>
		// Token: 0x04001D1E RID: 7454
		NotOnRanToCompletion = 65536,
		/// <summary>Указывает, что задача продолжения не должна планироваться, если предшествующая ей задача создала необработанное исключение. Предшествующая задача вызывает необработанное исключение, если после завершения ее свойство <see cref="P:System.Threading.Tasks.Task.Status" /> имеет значение <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" />. Данный параметр не является действительным для продолжений нескольких задач.</summary>
		// Token: 0x04001D1F RID: 7455
		NotOnFaulted = 131072,
		/// <summary>Указывает, что задача продолжения не должна планироваться, если предшествующая задача отменена. Предшествующая задача отменяется, если после завершения ее свойство <see cref="P:System.Threading.Tasks.Task.Status" /> имеет значение <see cref="F:System.Threading.Tasks.TaskStatus.Canceled" />. Данный параметр не является действительным для продолжений нескольких задач.</summary>
		// Token: 0x04001D20 RID: 7456
		NotOnCanceled = 262144,
		/// <summary>Указывает, что продолжение должно планироваться, только если предшествующая задача завершилась. Предшествующая задача выполняется полностью, если после завершения ее свойство <see cref="P:System.Threading.Tasks.Task.Status" /> имеет значение <see cref="F:System.Threading.Tasks.TaskStatus.RanToCompletion" />. Данный параметр не является действительным для продолжений нескольких задач.</summary>
		// Token: 0x04001D21 RID: 7457
		OnlyOnRanToCompletion = 393216,
		/// <summary>Указывает, что задача продолжения должна планироваться, только если предшествующая ей задача создала необработанное исключение. Предшествующая задача вызывает необработанное исключение, если после завершения ее свойство <see cref="P:System.Threading.Tasks.Task.Status" /> имеет значение <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" />.  
		/// Параметр <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnFaulted" /> гарантирует, что свойство <see cref="P:System.Threading.Tasks.Task.Exception" /> в предшествующей задаче не равно <see langword="null" />. Это свойство можно использовать для перехвата исключения и определения исключения, вызвавшего сбой задачи. Если не обратиться к свойству <see cref="P:System.Threading.Tasks.Task.Exception" />, исключение обрабатываться не будет. Кроме того, при попытке доступа к свойству <see cref="P:System.Threading.Tasks.Task`1.Result" /> задачи, которая была отменена или завершилась ошибкой, будет вызвано новое исключение.  
		/// Данный параметр не является действительным для продолжений нескольких задач.</summary>
		// Token: 0x04001D22 RID: 7458
		OnlyOnFaulted = 327680,
		/// <summary>Указывает, что продолжение должно планироваться, только если предшествующая задача отменена.  Предшествующая задача отменяется, если после завершения ее свойство <see cref="P:System.Threading.Tasks.Task.Status" /> имеет значение <see cref="F:System.Threading.Tasks.TaskStatus.Canceled" />. Данный параметр не является действительным для продолжений нескольких задач.</summary>
		// Token: 0x04001D23 RID: 7459
		OnlyOnCanceled = 196608,
		/// <summary>Указывает, что задача продолжения должна выполняться синхронно. Если этот параметр указан, продолжение выполняется в том же потоке, который приводит к переходу предшествующей задачи в конечное состояние. Если при создании продолжения предшествующая задача уже завершена, продолжение будет выполняться в потоке, создавшем его. Если объект <see cref="T:System.Threading.CancellationTokenSource" /> предшествующей задачи в блоке <see langword="finally" /> (<see langword="Finally" /> в Visual Basic) удаляется, продолжение с этим параметром будет запущено в указанном блоке<see langword="finally" />. Только очень короткие продолжения должны выполняться синхронно.  
		/// Так как задача выполняется синхронно, нет необходимости вызывать, например, метод <see cref="M:System.Threading.Tasks.Task.Wait" />, чтобы убедиться, что вызывающий поток ожидает завершения задачи.</summary>
		// Token: 0x04001D24 RID: 7460
		ExecuteSynchronously = 524288
	}
}
