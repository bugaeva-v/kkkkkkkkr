using System;

namespace System.Net.Sockets
{
	/// <summary>Определяет имена параметров конфигурации.</summary>
	// Token: 0x020007B7 RID: 1975
	public enum SocketOptionName
	{
		/// <summary>Записать отладочную информацию.</summary>
		// Token: 0x0400257D RID: 9597
		Debug = 1,
		/// <summary>Сокет прослушивает.</summary>
		// Token: 0x0400257E RID: 9598
		AcceptConnection,
		/// <summary>Позволяет ограничить сокет, разрешив только тот адрес, который уже используется.</summary>
		// Token: 0x0400257F RID: 9599
		ReuseAddress = 4,
		/// <summary>Использовать поддержание активности.</summary>
		// Token: 0x04002580 RID: 9600
		KeepAlive = 8,
		/// <summary>Не использовать маршрутизацию; отправлять пакет непосредственно на адреса интерфейса.</summary>
		// Token: 0x04002581 RID: 9601
		DontRoute = 16,
		/// <summary>Разрешить отправку широковещательных сообщений в сокет.</summary>
		// Token: 0x04002582 RID: 9602
		Broadcast = 32,
		/// <summary>Не использовать оборудование, когда это возможно.</summary>
		// Token: 0x04002583 RID: 9603
		UseLoopback = 64,
		/// <summary>Задержка при закрытии, если имеются неотправленные данные.</summary>
		// Token: 0x04002584 RID: 9604
		Linger = 128,
		/// <summary>Получает внешние данные в обычном потоке данных.</summary>
		// Token: 0x04002585 RID: 9605
		OutOfBandInline = 256,
		/// <summary>Закрыть сокет правильно и без задержки.</summary>
		// Token: 0x04002586 RID: 9606
		DontLinger = -129,
		/// <summary>Включает для сокета ограничение на монопольный доступ.</summary>
		// Token: 0x04002587 RID: 9607
		ExclusiveAddressUse = -5,
		/// <summary>Задает общий размер буферного пространства сокета, которое зарезервировано для отправки. Это не связано с максимальным размером сообщения или с размером TCP-окна.</summary>
		// Token: 0x04002588 RID: 9608
		SendBuffer = 4097,
		/// <summary>Задает общий размер буферного пространства сокета, которое зарезервировано для приема. Это не связано с максимальным размером сообщения или с размером TCP-окна.</summary>
		// Token: 0x04002589 RID: 9609
		ReceiveBuffer,
		/// <summary>Указывает отметку нижнего уровня для операций <see cref="Overload:System.Net.Sockets.Socket.Send" />.</summary>
		// Token: 0x0400258A RID: 9610
		SendLowWater,
		/// <summary>Указывает отметку нижнего уровня для операций <see cref="Overload:System.Net.Sockets.Socket.Receive" />.</summary>
		// Token: 0x0400258B RID: 9611
		ReceiveLowWater,
		/// <summary>Отправить время ожидания. Этот параметр применяется только для синхронных методов; он не действует для асинхронных методов, таких как <see cref="M:System.Net.Sockets.Socket.BeginSend(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.AsyncCallback,System.Object)" />.</summary>
		// Token: 0x0400258C RID: 9612
		SendTimeout,
		/// <summary>Получить время ожидания. Этот параметр применяется только для синхронных методов; он не действует для асинхронных методов, таких как <see cref="M:System.Net.Sockets.Socket.BeginSend(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.AsyncCallback,System.Object)" />.</summary>
		// Token: 0x0400258D RID: 9613
		ReceiveTimeout,
		/// <summary>Получает состояние ошибки и выполняет очистку.</summary>
		// Token: 0x0400258E RID: 9614
		Error,
		/// <summary>Получает тип сокета.</summary>
		// Token: 0x0400258F RID: 9615
		Type,
		/// <summary>Указывает, что система должна отложить выделение временных портов для исходящих соединений. Это эквивалентно использованию параметра сокета Winsock2 SO_REUSE_UNICASTPORT.</summary>
		// Token: 0x04002590 RID: 9616
		ReuseUnicastPort = 12295,
		/// <summary>Не поддерживается; при попытке использования возникает исключение <see cref="T:System.Net.Sockets.SocketException" />.</summary>
		// Token: 0x04002591 RID: 9617
		MaxConnections = 2147483647,
		/// <summary>Задает IP-параметры, которые включаются в исходящие датаграммы.</summary>
		// Token: 0x04002592 RID: 9618
		IPOptions = 1,
		/// <summary>Указывает, что приложение обеспечивает IP-заголовок для исходящих датаграмм.</summary>
		// Token: 0x04002593 RID: 9619
		HeaderIncluded,
		/// <summary>Изменить тип IP-заголовка служебного поля.</summary>
		// Token: 0x04002594 RID: 9620
		TypeOfService,
		/// <summary>Задает поле срока жизни в IP-заголовке.</summary>
		// Token: 0x04002595 RID: 9621
		IpTimeToLive,
		/// <summary>Задает интерфейс для исходящих пакетов многоадресной рассылки.</summary>
		// Token: 0x04002596 RID: 9622
		MulticastInterface = 9,
		/// <summary>Срок жизни многоадресной IP-рассылки.</summary>
		// Token: 0x04002597 RID: 9623
		MulticastTimeToLive,
		/// <summary>Замыкание на себя многоадресной IP-рассылки.</summary>
		// Token: 0x04002598 RID: 9624
		MulticastLoopback,
		/// <summary>Добавить членство в IP-группе.</summary>
		// Token: 0x04002599 RID: 9625
		AddMembership,
		/// <summary>Отключить членство в IP-группе.</summary>
		// Token: 0x0400259A RID: 9626
		DropMembership,
		/// <summary>Не фрагментировать IP-датаграммы.</summary>
		// Token: 0x0400259B RID: 9627
		DontFragment,
		/// <summary>Присоединить группу источника.</summary>
		// Token: 0x0400259C RID: 9628
		AddSourceMembership,
		/// <summary>Отключить группу источника.</summary>
		// Token: 0x0400259D RID: 9629
		DropSourceMembership,
		/// <summary>Блокировать данные из источника.</summary>
		// Token: 0x0400259E RID: 9630
		BlockSource,
		/// <summary>Разблокировать предварительно заблокированный источник.</summary>
		// Token: 0x0400259F RID: 9631
		UnblockSource,
		/// <summary>Возвратить сведения о полученных пакетах.</summary>
		// Token: 0x040025A0 RID: 9632
		PacketInformation,
		/// <summary>Указывает максимальное количество прыжков маршрутизатора для IPv6-пакетов. Аналогично сроку жизни для протокола IPv4.</summary>
		// Token: 0x040025A1 RID: 9633
		HopLimit = 21,
		/// <summary>Включает ограничение сокета IPv6 до указанной области, например до адресов с одинаковой локальной ссылкой или локальным префиксом сайта. Этот параметр сокета позволяет приложениям ограничивать доступ к сокетам IPv6. Такие ограничения позволяют приложению, работающему в частной локальной сети, просто и надежно защититься от внешних атак. Этот параметр сокета расширяет или сужает диапазон прослушивающего сокета, обеспечивая при необходимости неограниченный доступ со стороны открытых и закрытых пользователей или ограничивая доступ только тем же сайтом. Определенные уровни защиты этого параметра сокета указаны в перечислении <see cref="T:System.Net.Sockets.IPProtectionLevel" />.</summary>
		// Token: 0x040025A2 RID: 9634
		IPProtectionLevel = 23,
		/// <summary>Указывает, ограничен ли сокет, созданный для семейства адресов AF_INET6, связью через IPv6. Сокеты, созданные для семейства адресов AF_INET6, можно использовать для связи и через IPv6, и через IPv4. Некоторым приложениям может быть нужно ограничивать использование сокета, созданного для семейства адресов AF_INET6, связью через IPv6. Если это значение не равно нулю (по умолчанию в Windows), то сокет, созданный для семейства адресов AF_INET6, может использоваться для отправки и получения только пакетов IPv6. Если это значение равно нулю, сокет, созданный для семейства адресов AF_INET6, может использоваться для отправки и получения пакетов IPv6 и IPv4. Обратите внимание, что возможность взаимодействия с адресами IPv4 требует использования адресов, сопоставленных по IPv4. Этот параметр сокета поддерживается в Windows Vista и более поздних версиях.</summary>
		// Token: 0x040025A3 RID: 9635
		IPv6Only = 27,
		/// <summary>Отключить алгоритм Nagle для отправки объединенных пакетов.</summary>
		// Token: 0x040025A4 RID: 9636
		NoDelay = 1,
		/// <summary>Использовать срочные данные в соответствии с определением стандарта RFC-1222. Этот параметр может быть установлен только один раз, и после этого он не может быть отключен.</summary>
		// Token: 0x040025A5 RID: 9637
		BsdUrgent,
		/// <summary>Использовать срочные данные в соответствии с определением стандарта RFC-1222. Этот параметр может быть установлен только один раз, и после этого он не может быть отключен.</summary>
		// Token: 0x040025A6 RID: 9638
		Expedited = 2,
		/// <summary>Отправить UDP-датаграммы с контрольной суммой, заданной равной нулю.</summary>
		// Token: 0x040025A7 RID: 9639
		NoChecksum = 1,
		/// <summary>Задать или получить контрольную сумму для протокола UDP.</summary>
		// Token: 0x040025A8 RID: 9640
		ChecksumCoverage = 20,
		/// <summary>Обновляет свойства принятого сокета, используя свойства существующего сокета. Это эквивалентно применению параметра сокета Winsock2 SO_UPDATE_ACCEPT_CONTEXT и поддерживается только для сокетов, ориентированных на подключение.</summary>
		// Token: 0x040025A9 RID: 9641
		UpdateAcceptContext = 28683,
		/// <summary>Обновляет свойства подключенного сокета, используя свойства существующего сокета. Это эквивалентно применению параметра сокета Winsock2 SO_UPDATE_CONNECT_CONTEXT и поддерживается только для сокетов, ориентированных на подключение.</summary>
		// Token: 0x040025AA RID: 9642
		UpdateConnectContext = 28688
	}
}
