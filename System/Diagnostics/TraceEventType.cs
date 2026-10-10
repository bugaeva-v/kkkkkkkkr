using System;
using System.ComponentModel;

namespace System.Diagnostics
{
	/// <summary>Идентифицирует тип события, ставшего причиной трассировки.</summary>
	// Token: 0x0200022D RID: 557
	public enum TraceEventType
	{
		/// <summary>Неустранимая ошибка или сбой в работе приложения.</summary>
		// Token: 0x040009D9 RID: 2521
		Critical = 1,
		/// <summary>Устранимая ошибка.</summary>
		// Token: 0x040009DA RID: 2522
		Error,
		/// <summary>Несущественная проблема.</summary>
		// Token: 0x040009DB RID: 2523
		Warning = 4,
		/// <summary>Информационное сообщение.</summary>
		// Token: 0x040009DC RID: 2524
		Information = 8,
		/// <summary>Трассировка отладки.</summary>
		// Token: 0x040009DD RID: 2525
		Verbose = 16,
		/// <summary>Запуск логической операции.</summary>
		// Token: 0x040009DE RID: 2526
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Start = 256,
		/// <summary>Прекращение выполнения логической операции.</summary>
		// Token: 0x040009DF RID: 2527
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Stop = 512,
		/// <summary>Приостановка логической операции.</summary>
		// Token: 0x040009E0 RID: 2528
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Suspend = 1024,
		/// <summary>Возобновление логической операции.</summary>
		// Token: 0x040009E1 RID: 2529
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Resume = 2048,
		/// <summary>Изменение идентификации взаимосвязей.</summary>
		// Token: 0x040009E2 RID: 2530
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Transfer = 4096
	}
}
