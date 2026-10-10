using System;

namespace System.Net.Sockets
{
	/// <summary>Задает протоколы, которые поддерживает класс <see cref="T:System.Net.Sockets.Socket" />.</summary>
	// Token: 0x020007AD RID: 1965
	public enum ProtocolType
	{
		/// <summary>Интернет-протокол.</summary>
		// Token: 0x04002503 RID: 9475
		IP,
		/// <summary>Заголовок IPv6 Hop by Hop Options.</summary>
		// Token: 0x04002504 RID: 9476
		IPv6HopByHopOptions = 0,
		/// <summary>Протокол управления интернет-сообщениями (ICMP).</summary>
		// Token: 0x04002505 RID: 9477
		Icmp,
		/// <summary>Протокол управления интернет-группами (IGMP).</summary>
		// Token: 0x04002506 RID: 9478
		Igmp,
		/// <summary>Протокол межшлюзового взаимодействия (GGP).</summary>
		// Token: 0x04002507 RID: 9479
		Ggp,
		/// <summary>IP-протокол версии 4</summary>
		// Token: 0x04002508 RID: 9480
		IPv4,
		/// <summary>Управляющий протокол передачи (TCP).</summary>
		// Token: 0x04002509 RID: 9481
		Tcp = 6,
		/// <summary>PUP-протокол.</summary>
		// Token: 0x0400250A RID: 9482
		Pup = 12,
		/// <summary>Протокол пользовательских датаграмм (UDP).</summary>
		// Token: 0x0400250B RID: 9483
		Udp = 17,
		/// <summary>Протокол интернет-датаграмм (IDP).</summary>
		// Token: 0x0400250C RID: 9484
		Idp = 22,
		/// <summary>IP-протокол версии 6 (IPv6).</summary>
		// Token: 0x0400250D RID: 9485
		IPv6 = 41,
		/// <summary>Заголовок IPv6 Routing.</summary>
		// Token: 0x0400250E RID: 9486
		IPv6RoutingHeader = 43,
		/// <summary>Заголовок IPv6 Fragment.</summary>
		// Token: 0x0400250F RID: 9487
		IPv6FragmentHeader,
		/// <summary>Заголовок ESP IPv6.</summary>
		// Token: 0x04002510 RID: 9488
		IPSecEncapsulatingSecurityPayload = 50,
		/// <summary>Заголовок IPv6 Authentication. Дополнительные сведения см. в разделе 2.2.1 RFC 2292 по адресу https://www.ietf.org.</summary>
		// Token: 0x04002511 RID: 9489
		IPSecAuthenticationHeader,
		/// <summary>Протокол управления интернет-сообщениями (ICMP) для IPv6.</summary>
		// Token: 0x04002512 RID: 9490
		IcmpV6 = 58,
		/// <summary>Заголовок IPv6 No next.</summary>
		// Token: 0x04002513 RID: 9491
		IPv6NoNextHeader,
		/// <summary>Заголовок IPv6 Destination Options.</summary>
		// Token: 0x04002514 RID: 9492
		IPv6DestinationOptions,
		/// <summary>Протокол сетевого диска (NDP) (неофициальный).</summary>
		// Token: 0x04002515 RID: 9493
		ND = 77,
		/// <summary>Протокол необработанных IP-пакетов.</summary>
		// Token: 0x04002516 RID: 9494
		Raw = 255,
		/// <summary>Неуказанный протокол.</summary>
		// Token: 0x04002517 RID: 9495
		Unspecified = 0,
		/// <summary>Протокол обмена интернет-пакетами (IPX).</summary>
		// Token: 0x04002518 RID: 9496
		Ipx = 1000,
		/// <summary>Протокол последовательного обмена пакетами (SPX).</summary>
		// Token: 0x04002519 RID: 9497
		Spx = 1256,
		/// <summary>Протокол последовательного обмена пакетами (SPX) версии 2.</summary>
		// Token: 0x0400251A RID: 9498
		SpxII,
		/// <summary>Неизвестный протокол.</summary>
		// Token: 0x0400251B RID: 9499
		Unknown = -1
	}
}
