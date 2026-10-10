using System;

namespace System.Net.Sockets
{
	/// <summary>Определяет коды ошибок для класса <see cref="T:System.Net.Sockets.Socket" />.</summary>
	// Token: 0x020007B2 RID: 1970
	public enum SocketError
	{
		/// <summary>Операция <see cref="T:System.Net.Sockets.Socket" /> выполнена успешно.</summary>
		// Token: 0x04002534 RID: 9524
		Success,
		/// <summary>Произошла неопознанная ошибка объекта <see cref="T:System.Net.Sockets.Socket" />.</summary>
		// Token: 0x04002535 RID: 9525
		SocketError = -1,
		/// <summary>Вызов к заблокированному сокету <see cref="T:System.Net.Sockets.Socket" />был отменен.</summary>
		// Token: 0x04002536 RID: 9526
		Interrupted = 10004,
		/// <summary>Предпринята попытка получить доступ к объекту <see cref="T:System.Net.Sockets.Socket" /> способом, запрещенным его правами доступа.</summary>
		// Token: 0x04002537 RID: 9527
		AccessDenied = 10013,
		/// <summary>Поставщиком основного сокета обнаружен недопустимый указатель адреса.</summary>
		// Token: 0x04002538 RID: 9528
		Fault,
		/// <summary>Предоставлен недопустимый аргумент для члена объекта <see cref="T:System.Net.Sockets.Socket" />.</summary>
		// Token: 0x04002539 RID: 9529
		InvalidArgument = 10022,
		/// <summary>Слишком много открытых сокетов в основном поставщике сокета.</summary>
		// Token: 0x0400253A RID: 9530
		TooManyOpenSockets = 10024,
		/// <summary>Операция на незаблокированном сокете не может быть закончена немедленно.</summary>
		// Token: 0x0400253B RID: 9531
		WouldBlock = 10035,
		/// <summary>Выполняется блокирующая операция.</summary>
		// Token: 0x0400253C RID: 9532
		InProgress,
		/// <summary>На незаблокированном сокете <see cref="T:System.Net.Sockets.Socket" /> уже выполняется операция.</summary>
		// Token: 0x0400253D RID: 9533
		AlreadyInProgress,
		/// <summary>Предпринята попытка выполнить операцию объекта <see cref="T:System.Net.Sockets.Socket" /> не на сокете.</summary>
		// Token: 0x0400253E RID: 9534
		NotSocket,
		/// <summary>В операции на сокете <see cref="T:System.Net.Sockets.Socket" /> пропущен обязательный адрес.</summary>
		// Token: 0x0400253F RID: 9535
		DestinationAddressRequired,
		/// <summary>У датаграммы слишком большая длина.</summary>
		// Token: 0x04002540 RID: 9536
		MessageSize,
		/// <summary>Неверный тип протокола для данного объекта <see cref="T:System.Net.Sockets.Socket" />.</summary>
		// Token: 0x04002541 RID: 9537
		ProtocolType,
		/// <summary>Для объекта <see cref="T:System.Net.Sockets.Socket" /> был использован неизвестный, недопустимый или неподдерживаемый параметр или уровень.</summary>
		// Token: 0x04002542 RID: 9538
		ProtocolOption,
		/// <summary>Протокол не реализован или не настроен.</summary>
		// Token: 0x04002543 RID: 9539
		ProtocolNotSupported,
		/// <summary>Указанный тип сокета не поддерживается в данном семействе адресов.</summary>
		// Token: 0x04002544 RID: 9540
		SocketNotSupported,
		/// <summary>Семейство адресов не поддерживается семейством протоколов.</summary>
		// Token: 0x04002545 RID: 9541
		OperationNotSupported,
		/// <summary>Семейство протоколов не реализовано или не настроено.</summary>
		// Token: 0x04002546 RID: 9542
		ProtocolFamilyNotSupported,
		/// <summary>Указанное семейство адресов не поддерживается. Эта ошибка возвращается, если указано семейство IPv6-адресов, а стек протокола IPv6 не установлен на локальном компьютере. Эта ошибка возвращается, если указано семейство IPv4-адресов, а стек протокола IPv4 не установлен на локальном компьютере.</summary>
		// Token: 0x04002547 RID: 9543
		AddressFamilyNotSupported,
		/// <summary>Обычно разрешается использовать только адрес.</summary>
		// Token: 0x04002548 RID: 9544
		AddressAlreadyInUse,
		/// <summary>Выбранный IP-адрес является недопустимым в этом контексте.</summary>
		// Token: 0x04002549 RID: 9545
		AddressNotAvailable,
		/// <summary>сеть недоступна;</summary>
		// Token: 0x0400254A RID: 9546
		NetworkDown,
		/// <summary>Не существует маршрута к удаленному узлу.</summary>
		// Token: 0x0400254B RID: 9547
		NetworkUnreachable,
		/// <summary>Приложение пытается задать значение <see cref="F:System.Net.Sockets.SocketOptionName.KeepAlive" /> для подключения, которое уже отключено.</summary>
		// Token: 0x0400254C RID: 9548
		NetworkReset,
		/// <summary>Подключение разорвано платформой .NET Framework или поставщиком основного сокета.</summary>
		// Token: 0x0400254D RID: 9549
		ConnectionAborted,
		/// <summary>Подключение сброшено удаленным компьютером.</summary>
		// Token: 0x0400254E RID: 9550
		ConnectionReset,
		/// <summary>Отсутствует свободное буферное пространство для операции объекта <see cref="T:System.Net.Sockets.Socket" />.</summary>
		// Token: 0x0400254F RID: 9551
		NoBufferSpaceAvailable,
		/// <summary>Объект <see cref="T:System.Net.Sockets.Socket" /> уже подключен.</summary>
		// Token: 0x04002550 RID: 9552
		IsConnected,
		/// <summary>Приложение пытается отправить или получить данные, а объект <see cref="T:System.Net.Sockets.Socket" /> не подключен.</summary>
		// Token: 0x04002551 RID: 9553
		NotConnected,
		/// <summary>Запрос на отправку или получение данных отклонен, так как объект <see cref="T:System.Net.Sockets.Socket" /> уже закрыт.</summary>
		// Token: 0x04002552 RID: 9554
		Shutdown,
		/// <summary>Истекло время ожидания попытки подключения, или произошел сбой при отклике подключенного узла.</summary>
		// Token: 0x04002553 RID: 9555
		TimedOut = 10060,
		/// <summary>Удаленный узел активно отказывает в подключении.</summary>
		// Token: 0x04002554 RID: 9556
		ConnectionRefused,
		/// <summary>Ошибка при выполнении операции, вызванная отключением удаленного узла.</summary>
		// Token: 0x04002555 RID: 9557
		HostDown = 10064,
		/// <summary>Отсутствует сетевой маршрут к указанному узлу.</summary>
		// Token: 0x04002556 RID: 9558
		HostUnreachable,
		/// <summary>Слишком много процессов используется основным поставщиком сокета.</summary>
		// Token: 0x04002557 RID: 9559
		ProcessLimit = 10067,
		/// <summary>Подсистема сети недоступна.</summary>
		// Token: 0x04002558 RID: 9560
		SystemNotReady = 10091,
		/// <summary>Версия основного поставщика сокета выходит за пределы допустимого диапазона.</summary>
		// Token: 0x04002559 RID: 9561
		VersionNotSupported,
		/// <summary>Основной поставщик сокета не инициализирован.</summary>
		// Token: 0x0400255A RID: 9562
		NotInitialized,
		/// <summary>Выполняется правильная последовательность отключения.</summary>
		// Token: 0x0400255B RID: 9563
		Disconnecting = 10101,
		/// <summary>Указанный класс не найден.</summary>
		// Token: 0x0400255C RID: 9564
		TypeNotFound = 10109,
		/// <summary>Такой узел не существует. Данное имя не является ни официальным именем узла, ни псевдонимом.</summary>
		// Token: 0x0400255D RID: 9565
		HostNotFound = 11001,
		/// <summary>Не удалось разрешить имя узла. Повторите попытку позже.</summary>
		// Token: 0x0400255E RID: 9566
		TryAgain,
		/// <summary>Неустранимая ошибка, или не удается найти запрошенную базу данных.</summary>
		// Token: 0x0400255F RID: 9567
		NoRecovery,
		/// <summary>Требуемое имя или IP-адрес не найдены на сервере имен.</summary>
		// Token: 0x04002560 RID: 9568
		NoData,
		/// <summary>Приложение инициировало перекрывающуюся операцию, которая не может быть закончена немедленно.</summary>
		// Token: 0x04002561 RID: 9569
		IOPending = 997,
		/// <summary>Перекрывающаяся операция была прервана из-за закрытия объекта <see cref="T:System.Net.Sockets.Socket" />.</summary>
		// Token: 0x04002562 RID: 9570
		OperationAborted = 995
	}
}
