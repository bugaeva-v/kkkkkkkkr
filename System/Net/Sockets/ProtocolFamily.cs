using System;

namespace System.Net.Sockets
{
	/// <summary>Задает тип протокола, который может использоваться экземпляром класса <see cref="T:System.Net.Sockets.Socket" />.</summary>
	// Token: 0x020007AC RID: 1964
	public enum ProtocolFamily
	{
		/// <summary>Неизвестный протокол.</summary>
		// Token: 0x040024E3 RID: 9443
		Unknown = -1,
		/// <summary>Неуказанный протокол.</summary>
		// Token: 0x040024E4 RID: 9444
		Unspecified,
		/// <summary>Протокол Unix для связи с узелом.</summary>
		// Token: 0x040024E5 RID: 9445
		Unix,
		/// <summary>Протокол IPv4.</summary>
		// Token: 0x040024E6 RID: 9446
		InterNetwork,
		/// <summary>Протокол ARPANET IMP.</summary>
		// Token: 0x040024E7 RID: 9447
		ImpLink,
		/// <summary>Протокол PUP.</summary>
		// Token: 0x040024E8 RID: 9448
		Pup,
		/// <summary>Протокол MIT CHAOS.</summary>
		// Token: 0x040024E9 RID: 9449
		Chaos,
		/// <summary>Протокол Xerox NS.</summary>
		// Token: 0x040024EA RID: 9450
		NS,
		/// <summary>Протокол IPX или SPX.</summary>
		// Token: 0x040024EB RID: 9451
		Ipx = 6,
		/// <summary>Протокол ISO.</summary>
		// Token: 0x040024EC RID: 9452
		Iso,
		/// <summary>Протокол OSI.</summary>
		// Token: 0x040024ED RID: 9453
		Osi = 7,
		/// <summary>Протокол ЕСМА.</summary>
		// Token: 0x040024EE RID: 9454
		Ecma,
		/// <summary>Протокол DataKit.</summary>
		// Token: 0x040024EF RID: 9455
		DataKit,
		/// <summary>Протокол CCITT, например X.25.</summary>
		// Token: 0x040024F0 RID: 9456
		Ccitt,
		/// <summary>Протокол IBM SNA.</summary>
		// Token: 0x040024F1 RID: 9457
		Sna,
		/// <summary>Протокол DECNet.</summary>
		// Token: 0x040024F2 RID: 9458
		DecNet,
		/// <summary>Протокол DataLink.</summary>
		// Token: 0x040024F3 RID: 9459
		DataLink,
		/// <summary>Протокол LAT.</summary>
		// Token: 0x040024F4 RID: 9460
		Lat,
		/// <summary>Протокол NSC HyperChannel.</summary>
		// Token: 0x040024F5 RID: 9461
		HyperChannel,
		/// <summary>Протокол AppleTalk.</summary>
		// Token: 0x040024F6 RID: 9462
		AppleTalk,
		/// <summary>Протокол NetBIOS.</summary>
		// Token: 0x040024F7 RID: 9463
		NetBios,
		/// <summary>Протокол VoiceView.</summary>
		// Token: 0x040024F8 RID: 9464
		VoiceView,
		/// <summary>Протокол FireFox.</summary>
		// Token: 0x040024F9 RID: 9465
		FireFox,
		/// <summary>Протокол Banyan.</summary>
		// Token: 0x040024FA RID: 9466
		Banyan = 21,
		/// <summary>Собственный протокол ATM-служб.</summary>
		// Token: 0x040024FB RID: 9467
		Atm,
		/// <summary>Протокол IPv6.</summary>
		// Token: 0x040024FC RID: 9468
		InterNetworkV6,
		/// <summary>Протокол Cluster.</summary>
		// Token: 0x040024FD RID: 9469
		Cluster,
		/// <summary>Протокол IEEE 1284.4.</summary>
		// Token: 0x040024FE RID: 9470
		Ieee12844,
		/// <summary>Протокол IrDA.</summary>
		// Token: 0x040024FF RID: 9471
		Irda,
		/// <summary>Шлюзовый протокол Network Designers OSI.</summary>
		// Token: 0x04002500 RID: 9472
		NetworkDesigners = 28,
		/// <summary>Протокол MAX.</summary>
		// Token: 0x04002501 RID: 9473
		Max
	}
}
