using System;

namespace System.Net.Sockets
{
	/// <summary>Перечисление <see cref="T:System.Net.Sockets.TransmitFileOptions" /> определяет значения, используемые в запросах на передачу файлов.</summary>
	// Token: 0x020007BC RID: 1980
	[Flags]
	public enum TransmitFileOptions
	{
		/// <summary>Использовать для обработки длительных запросов передачи файлов поток по умолчанию.</summary>
		// Token: 0x040025C0 RID: 9664
		UseDefaultWorkerThread = 0,
		/// <summary>Запустить отключение уровня транспорта, после того как все данные файла поставлены в очередь на передачу. При использовании вместе с флагом <see cref="F:System.Net.Sockets.TransmitFileOptions.ReuseSocket" /> эти флаги возвращают сокет в отключенное состояние для повторного использования после передачи файла.</summary>
		// Token: 0x040025C1 RID: 9665
		Disconnect = 1,
		/// <summary>После выполнения запроса дескриптор сокета можно использовать повторно. Этот флаг допустим, только если также указан флаг <see cref="F:System.Net.Sockets.TransmitFileOptions.Disconnect" />. При использовании вместе с флагом <see cref="F:System.Net.Sockets.TransmitFileOptions.Disconnect" /> эти флаги возвращают сокет в отключенное состояние для повторного использования после передачи файла.</summary>
		// Token: 0x040025C2 RID: 9666
		ReuseSocket = 2,
		/// <summary>Выполнить запрос на передачу файла немедленно, не откладывая его выполнения. Если этот флаг указан и передача файлов завершается успешно, значит данные приняты системой, но не обязательно получено подтверждение на удаленном конце. Не используйте этот флаг с флагами <see cref="F:System.Net.Sockets.TransmitFileOptions.Disconnect" /> и <see cref="F:System.Net.Sockets.TransmitFileOptions.ReuseSocket" />.</summary>
		// Token: 0x040025C3 RID: 9667
		WriteBehind = 4,
		/// <summary>Использовать для обработки длительных запросов передачи файлов системные потоки.</summary>
		// Token: 0x040025C4 RID: 9668
		UseSystemThread = 16,
		/// <summary>Использовать для обработки длительных запросов передачи файлов асинхронные вызовы процедур ядра, а не рабочие потоки. Длительные запросы — это запросы, которые требуют более одного чтения из файла или из кэша, поэтому продолжительность выполнения такого запроса зависит от размера файла и указанной длины отправляемого пакета.</summary>
		// Token: 0x040025C5 RID: 9669
		UseKernelApc = 32
	}
}
