using System;

namespace System.Net.Sockets
{
	/// <summary>Указывает тип сокета, являющегося экземпляром класса <see cref="T:System.Net.Sockets.Socket" />.</summary>
	// Token: 0x020007B9 RID: 1977
	public enum SocketType
	{
		/// <summary>Поддерживает надежные двусторонние байтовые потоки в режиме с установлением подключения, без дублирования данных и без сохранения границ данных. Объект <see cref="T:System.Net.Sockets.Socket" /> этого типа взаимодействует с одним узлом и требует установления подключения к удаленному узлу перед началом передачи данных. <see cref="F:System.Net.Sockets.SocketType.Stream" /> использует протокол TCP (<see langword="ProtocolType" />.<see cref="F:System.Net.Sockets.ProtocolType.Tcp" />) и семейство адресов <see langword="AddressFamily" />.<see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> .</summary>
		// Token: 0x040025B0 RID: 9648
		Stream = 1,
		/// <summary>Поддерживает датаграммы — ненадежные сообщения с фиксированной (обычно малой) максимальной длиной, передаваемые без установления подключения. Возможны потеря и дублирование сообщений, а также их получение не в том порядке, в котором они отправлены. Объект <see cref="T:System.Net.Sockets.Socket" /> типа <see cref="F:System.Net.Sockets.SocketType.Dgram" /> не требует установки подключения до приема и передачи данных и может обеспечивать связь со множеством одноранговых узлов. <see cref="F:System.Net.Sockets.SocketType.Dgram" /> использует протокол Datagram (<see langword="ProtocolType" />.<see cref="F:System.Net.Sockets.ProtocolType.Udp" />) семейство адресов <see langword="AddressFamily" />.<see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> .</summary>
		// Token: 0x040025B1 RID: 9649
		Dgram,
		/// <summary>Поддерживает доступ к основному транспортному протоколу. Используя <see cref="F:System.Net.Sockets.SocketType.Raw" />, можно организовать связь с применением протоколов, таких как протокол ICMP (<see langword="ProtocolType" />.<see cref="F:System.Net.Sockets.ProtocolType.Icmp" />) и протокол IGMP (<see langword="ProtocolType" />.<see cref="F:System.Net.Sockets.ProtocolType.Igmp" />). При передаче приложение должно обеспечивать полный IP-заголовок. Полученные датаграммы возвращаются с неизмененными IP-заголовком и параметрами.</summary>
		// Token: 0x040025B2 RID: 9650
		Raw,
		/// <summary>Поддерживает ориентированную на сообщения связь без установления подключения с надежной доставкой сообщений и сохранением границ сообщений в данных. Сообщения RDM (Reliably-Delivered Messages — сообщения с надежной доставкой) принимаются без получения дубликатов и в порядке отправки. Кроме того, отправителю отправляется уведомление в случае потери сообщений. Если инициализируется сокет <see cref="T:System.Net.Sockets.Socket" /> типа <see cref="F:System.Net.Sockets.SocketType.Rdm" />, нет необходимости в установлении подключения к удаленному узлу перед началом отправки или получения данных. Используя тип <see cref="F:System.Net.Sockets.SocketType.Rdm" />, можно организовать связь со множеством узелов.</summary>
		// Token: 0x040025B3 RID: 9651
		Rdm,
		/// <summary>Обеспечивает надежную двустороннюю передачу упорядоченных байтовых потоков через сеть в режиме с установлением подключения. <see cref="F:System.Net.Sockets.SocketType.Seqpacket" /> не дублирует данные и сохраняет границы в потоке данных. Объект <see cref="T:System.Net.Sockets.Socket" /> типа <see cref="F:System.Net.Sockets.SocketType.Seqpacket" /> взаимодействует с одним узелом и требует установления подключения к удаленному узлу перед началом передачи данных.</summary>
		// Token: 0x040025B4 RID: 9652
		Seqpacket,
		/// <summary>Задает неизвестный тип <see cref="T:System.Net.Sockets.Socket" />.</summary>
		// Token: 0x040025B5 RID: 9653
		Unknown = -1
	}
}
