using System;

namespace System.Net.Sockets
{
	/// <summary>Задает схему адресации, которую может использовать экземпляр класса <see cref="T:System.Net.Sockets.Socket" />.</summary>
	// Token: 0x020007A5 RID: 1957
	public enum AddressFamily
	{
		/// <summary>Семейство неизвестных адресов.</summary>
		// Token: 0x04002492 RID: 9362
		Unknown = -1,
		/// <summary>Семейство неуказанных адресов.</summary>
		// Token: 0x04002493 RID: 9363
		Unspecified,
		/// <summary>Локальный адрес Unix для узла.</summary>
		// Token: 0x04002494 RID: 9364
		Unix,
		/// <summary>IPv4-адрес.</summary>
		// Token: 0x04002495 RID: 9365
		InterNetwork,
		/// <summary>Адрес ARPANET IMP.</summary>
		// Token: 0x04002496 RID: 9366
		ImpLink,
		/// <summary>Адрес протоколов PUP.</summary>
		// Token: 0x04002497 RID: 9367
		Pup,
		/// <summary>Адрес протоколов MIT CHAOS.</summary>
		// Token: 0x04002498 RID: 9368
		Chaos,
		/// <summary>Адрес протоколов Xerox NS.</summary>
		// Token: 0x04002499 RID: 9369
		NS,
		/// <summary>IPX- или SPX-адрес.</summary>
		// Token: 0x0400249A RID: 9370
		Ipx = 6,
		/// <summary>Адрес протоколов ISO.</summary>
		// Token: 0x0400249B RID: 9371
		Iso,
		/// <summary>Адрес протоколов OSI.</summary>
		// Token: 0x0400249C RID: 9372
		Osi = 7,
		/// <summary>Адрес ЕСМА (European Computer Manufacturers Association — европейская ассоциация производителей компьютеров).</summary>
		// Token: 0x0400249D RID: 9373
		Ecma,
		/// <summary>Адрес протоколов Datakit.</summary>
		// Token: 0x0400249E RID: 9374
		DataKit,
		/// <summary>Адреса протоколов CCITT, таких как протокол X.25.</summary>
		// Token: 0x0400249F RID: 9375
		Ccitt,
		/// <summary>Адрес IBM SNA.</summary>
		// Token: 0x040024A0 RID: 9376
		Sna,
		/// <summary>Адрес DECnet.</summary>
		// Token: 0x040024A1 RID: 9377
		DecNet,
		/// <summary>Адрес интерфейса прямого канала передачи данных.</summary>
		// Token: 0x040024A2 RID: 9378
		DataLink,
		/// <summary>LAT-адрес.</summary>
		// Token: 0x040024A3 RID: 9379
		Lat,
		/// <summary>Адрес NSC Hyperchannel.</summary>
		// Token: 0x040024A4 RID: 9380
		HyperChannel,
		/// <summary>Адрес AppleTalk.</summary>
		// Token: 0x040024A5 RID: 9381
		AppleTalk,
		/// <summary>Адрес NetBios.</summary>
		// Token: 0x040024A6 RID: 9382
		NetBios,
		/// <summary>Адрес VoiceView.</summary>
		// Token: 0x040024A7 RID: 9383
		VoiceView,
		/// <summary>Адрес FireFox.</summary>
		// Token: 0x040024A8 RID: 9384
		FireFox,
		/// <summary>Адрес Banyan.</summary>
		// Token: 0x040024A9 RID: 9385
		Banyan = 21,
		/// <summary>Адрес собственных служб ATM.</summary>
		// Token: 0x040024AA RID: 9386
		Atm,
		/// <summary>IPv6-адрес.</summary>
		// Token: 0x040024AB RID: 9387
		InterNetworkV6,
		/// <summary>Адрес кластерных продуктов корпорации Майкрософт.</summary>
		// Token: 0x040024AC RID: 9388
		Cluster,
		/// <summary>Адрес рабочей группы IEEE 1284.4.</summary>
		// Token: 0x040024AD RID: 9389
		Ieee12844,
		/// <summary>IrDA-адрес.</summary>
		// Token: 0x040024AE RID: 9390
		Irda,
		/// <summary>Адрес шлюзовых протоколов Network Designers OSI.</summary>
		// Token: 0x040024AF RID: 9391
		NetworkDesigners = 28,
		/// <summary>MAX-адрес.</summary>
		// Token: 0x040024B0 RID: 9392
		Max
	}
}
