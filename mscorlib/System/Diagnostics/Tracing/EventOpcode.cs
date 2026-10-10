using System;

namespace System.Diagnostics.Tracing
{
	/// <summary>Определяет стандартные коды операций, вложенные в события источником событий.</summary>
	// Token: 0x020009E9 RID: 2537
	public enum EventOpcode
	{
		/// <summary>Информационное событие.</summary>
		// Token: 0x040037F2 RID: 14322
		Info,
		/// <summary>Событие, публикуемое при запуске приложением новой транзакции или нового действия. Этот код операции можно внедрять в другие транзакции или действия, если несколько событий, содержащих код <see cref="F:System.Diagnostics.Tracing.EventOpcode.Start" />, следуют друг за другом без промежуточных событий, содержащих код <see cref="F:System.Diagnostics.Tracing.EventOpcode.Stop" />.</summary>
		// Token: 0x040037F3 RID: 14323
		Start,
		/// <summary>Событие, публикуемое при завершении действия или транзакции в приложении. Событие соответствует последнему непарному событию с кодом операции <see cref="F:System.Diagnostics.Tracing.EventOpcode.Start" />.</summary>
		// Token: 0x040037F4 RID: 14324
		Stop,
		/// <summary>Событие начала коллекции трассировки.</summary>
		// Token: 0x040037F5 RID: 14325
		DataCollectionStart,
		/// <summary>Событие окончания коллекции трассировки.</summary>
		// Token: 0x040037F6 RID: 14326
		DataCollectionStop,
		/// <summary>Событие расширения.</summary>
		// Token: 0x040037F7 RID: 14327
		Extension,
		/// <summary>Событие, публикуемое после ответа действия в приложении на событие.</summary>
		// Token: 0x040037F8 RID: 14328
		Reply,
		/// <summary>Событие, публикуемое после выхода действия в приложении из приостановленного состояния. Событие должно следовать за событием, содержащим код операции <see cref="F:System.Diagnostics.Tracing.EventOpcode.Suspend" />.</summary>
		// Token: 0x040037F9 RID: 14329
		Resume,
		/// <summary>Событие, публикуемое при приостановке действия в приложении.</summary>
		// Token: 0x040037FA RID: 14330
		Suspend,
		/// <summary>Событие, публикуемое при передаче одним действием в приложении данных или системных ресурсов другому действию.</summary>
		// Token: 0x040037FB RID: 14331
		Send,
		/// <summary>Событие, публикуемое при приеме одним действием данных в приложении.</summary>
		// Token: 0x040037FC RID: 14332
		Receive = 240
	}
}
