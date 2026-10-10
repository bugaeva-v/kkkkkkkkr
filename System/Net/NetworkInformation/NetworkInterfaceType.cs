using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Указывает типы сетевых интерфейсов.</summary>
	// Token: 0x0200070B RID: 1803
	public enum NetworkInterfaceType
	{
		/// <summary>Неизвестный тип интерфейса.</summary>
		// Token: 0x040021DE RID: 8670
		Unknown = 1,
		/// <summary>Сетевой интерфейс использует подключение Ethernet. Ethernet определяется в стандарте IEEE 802.3.</summary>
		// Token: 0x040021DF RID: 8671
		Ethernet = 6,
		/// <summary>Сетевой интерфейс использует подключение Token Ring. Token Ring определяется в стандарте IEEE 802.5.</summary>
		// Token: 0x040021E0 RID: 8672
		TokenRing = 9,
		/// <summary>Сетевой интерфейс использует подключение FDDI (Fiber Distributed Data Interface). FDDI — это набор стандартов передачи данных по оптоволоконным линиям в локальной сети.</summary>
		// Token: 0x040021E1 RID: 8673
		Fddi = 15,
		/// <summary>Сетевой интерфейс использует интерфейс базового уровня подключения ISDN (Integrated Services Digital Network). ISDN — это набор стандартов передачи данных по телефонным линиям.</summary>
		// Token: 0x040021E2 RID: 8674
		BasicIsdn = 20,
		/// <summary>Сетевой интерфейс использует интерфейс первичного уровня подключения ISDN (Integrated Services Digital Network). ISDN — это набор стандартов передачи данных по телефонным линиям.</summary>
		// Token: 0x040021E3 RID: 8675
		PrimaryIsdn,
		/// <summary>Сетевой интерфейс использует подключение PPP (Point-To-Point Protocol). PPP — это протокол передачи данных с использованием последовательного устройства.</summary>
		// Token: 0x040021E4 RID: 8676
		Ppp = 23,
		/// <summary>Сетевой интерфейс является петлевым адаптером. Такие интерфейсы часто используются для тестирования; они не отправляют трафик в сеть.</summary>
		// Token: 0x040021E5 RID: 8677
		Loopback,
		/// <summary>Сетевой интерфейс использует подключение Ethernet со скоростью 3 Мбит/с. Эта версия Ethernet определяется в стандарте IETF RFC 895.</summary>
		// Token: 0x040021E6 RID: 8678
		Ethernet3Megabit = 26,
		/// <summary>Сетевой интерфейс использует подключение SLIP (Serial Line Internet Protocol). SLIP определяется в стандарте IETF RFC 1055.</summary>
		// Token: 0x040021E7 RID: 8679
		Slip = 28,
		/// <summary>Сетевой интерфейс использует для передачи данных асинхронный режим передачи (ATM).</summary>
		// Token: 0x040021E8 RID: 8680
		Atm = 37,
		/// <summary>Сетевой интерфейс использует модем.</summary>
		// Token: 0x040021E9 RID: 8681
		GenericModem = 48,
		/// <summary>Сетевой интерфейс использует подключение Fast Ethernet по витой паре со скоростью передачи данных 100 Мбит/с. Этот тип подключения также называется 100Base-T.</summary>
		// Token: 0x040021EA RID: 8682
		FastEthernetT = 62,
		/// <summary>Сетевой интерфейс использует подключение, настроенное для использования ISDN и протокола X.25. X.25 позволяет компьютерам в общедоступных сетях взаимодействовать через промежуточный компьютер.</summary>
		// Token: 0x040021EB RID: 8683
		Isdn,
		/// <summary>Сетевой интерфейс использует подключение Fast Ethernet по оптическому волокну со скоростью передачи данных 100 Мбит/с. Этот тип подключения также называется 100Base-FX.</summary>
		// Token: 0x040021EC RID: 8684
		FastEthernetFx = 69,
		/// <summary>Сетевой интерфейс использует беспроводное подключение к локальной сети (стандарт IEEE 802.11).</summary>
		// Token: 0x040021ED RID: 8685
		Wireless80211 = 71,
		/// <summary>Сетевой интерфейс использует ADSL (Asymmetric Digital Subscriber Line).</summary>
		// Token: 0x040021EE RID: 8686
		AsymmetricDsl = 94,
		/// <summary>Сетевой интерфейс использует RADSL (Rate Adaptive Digital Subscriber Line).</summary>
		// Token: 0x040021EF RID: 8687
		RateAdaptDsl,
		/// <summary>Сетевой интерфейс использует SDSL (Symmetric Digital Subscriber Line).</summary>
		// Token: 0x040021F0 RID: 8688
		SymmetricDsl,
		/// <summary>Сетевой интерфейс использует VDSL (Very High Data Rate Digital Subscriber Line).</summary>
		// Token: 0x040021F1 RID: 8689
		VeryHighSpeedDsl,
		/// <summary>Сетевой интерфейс использует для передачи данных протокол IP в сочетании с асинхронный режимом передачи (ATM).</summary>
		// Token: 0x040021F2 RID: 8690
		IPOverAtm = 114,
		/// <summary>Сетевой интерфейс использует подключение Fast Ethernet по оптическому волокну со скоростью передачи данных 1 Гбит/с (1000 Мбит/с).</summary>
		// Token: 0x040021F3 RID: 8691
		GigabitEthernet = 117,
		/// <summary>Сетевой интерфейс использует туннельное подключение.</summary>
		// Token: 0x040021F4 RID: 8692
		Tunnel = 131,
		/// <summary>Сетевой интерфейс использует MDSL (Multirate Digital Subscriber Line).</summary>
		// Token: 0x040021F5 RID: 8693
		MultiRateSymmetricDsl = 143,
		/// <summary>Сетевой интерфейс использует подключение IEEE 1394 (High Performance Serial Bus).</summary>
		// Token: 0x040021F6 RID: 8694
		HighPerformanceSerialBus,
		/// <summary>Сетевой интерфейс использует мобильный широкополосный интерфейс для устройств WiMax.</summary>
		// Token: 0x040021F7 RID: 8695
		Wman = 237,
		/// <summary>Сетевой интерфейс использует мобильный широкополосный интерфейс для устройств на базе GSM.</summary>
		// Token: 0x040021F8 RID: 8696
		Wwanpp = 243,
		/// <summary>Сетевой интерфейс использует мобильный широкополосный интерфейс для устройств на базе CDMA.</summary>
		// Token: 0x040021F9 RID: 8697
		Wwanpp2
	}
}
