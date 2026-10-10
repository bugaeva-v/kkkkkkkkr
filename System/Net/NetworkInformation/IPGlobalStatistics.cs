using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Предоставляет статистику протокола IP.</summary>
	// Token: 0x020006E3 RID: 1763
	public abstract class IPGlobalStatistics
	{
		/// <summary>Возвращает значение по умолчанию срока жизни (TTL) IP-пакетов.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее срок жизни пакетов.</returns>
		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x0600389F RID: 14495
		public abstract int DefaultTtl { get; }

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, которое указывает, разрешена ли переадресация IP-пакетов.</summary>
		/// <returns>Значение типа <see cref="T:System.Boolean" />, которое указывает, разрешена ли переадресация пакетов.</returns>
		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x060038A0 RID: 14496
		public abstract bool ForwardingEnabled { get; }

		/// <summary>Возвращает число сетевых интерфейсов.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, которое содержит число сетевых интерфейсов для семейства адресов, используемых для получения данного экземпляра <see cref="T:System.Net.NetworkInformation.IPGlobalStatistics" />.</returns>
		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x060038A1 RID: 14497
		public abstract int NumberOfInterfaces { get; }

		/// <summary>Возвращает число IP-адресов, назначенных локальному компьютеру.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее число IP-адресов, назначенных семейству адресов (IPv4 или IPv6), которое описывается этим объектом.</returns>
		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x060038A2 RID: 14498
		public abstract int NumberOfIPAddresses { get; }

		/// <summary>Возвращает число исходящих IP-пакетов.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число исходящих пакетов.</returns>
		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x060038A3 RID: 14499
		public abstract long OutputPacketRequests { get; }

		/// <summary>Возвращает число маршрутов, удаленных из таблицы маршрутизации.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число допустимых маршрутов, которые были удалены.</returns>
		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x060038A4 RID: 14500
		public abstract long OutputPacketRoutingDiscards { get; }

		/// <summary>Возвращает число переданных IP-пакетов, которые были удалены.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число исходящих пакетов, которые были удалены.</returns>
		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x060038A5 RID: 14501
		public abstract long OutputPacketsDiscarded { get; }

		/// <summary>Возвращает число IP-пакетов, для которых локальному компьютеру не удалось определить маршрут к адресу назначения.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее число пакетов, которые не удалось отправить из-за того, что не найден маршрут.</returns>
		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x060038A6 RID: 14502
		public abstract long OutputPacketsWithNoRoute { get; }

		/// <summary>Возвращает число IP-пакетов, которые не удалось фрагментировать.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество пакетов с установленным битом "Не фрагментировать", для которых требовалась фрагментация.</returns>
		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x060038A7 RID: 14503
		public abstract long PacketFragmentFailures { get; }

		/// <summary>Возвращает число IP-пакетов, требовавших сборки.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число требовавшихся сборок пакетов.</returns>
		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x060038A8 RID: 14504
		public abstract long PacketReassembliesRequired { get; }

		/// <summary>Возвращает число IP-пакетов, которые не были успешно собраны.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число исходящих пакетов, которые не удалось собрать.</returns>
		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x060038A9 RID: 14505
		public abstract long PacketReassemblyFailures { get; }

		/// <summary>Возвращает максимальное время, в течение которого должны поступить все фрагменты IP-пакета.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее максимальное время (в миллисекундах), в течение которого должны поступить все фрагменты пакета, чтобы он не был удален.</returns>
		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x060038AA RID: 14506
		public abstract long PacketReassemblyTimeout { get; }

		/// <summary>Возвращает число фрагментированных IP-пакетов.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число фрагментированных пакетов.</returns>
		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x060038AB RID: 14507
		public abstract long PacketsFragmented { get; }

		/// <summary>Возвращает число собранных IP-пакетов.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число фрагментированных пакетов, которые были успешно собраны.</returns>
		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x060038AC RID: 14508
		public abstract long PacketsReassembled { get; }

		/// <summary>Возвращает число полученных IP-пакетов.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число полученных IP-пакетов.</returns>
		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x060038AD RID: 14509
		public abstract long ReceivedPackets { get; }

		/// <summary>Возвращает число доставленных IP-пакетов.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число доставленных IP-пакетов.</returns>
		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x060038AE RID: 14510
		public abstract long ReceivedPacketsDelivered { get; }

		/// <summary>Возвращает число полученных IP-пакетов, которые были удалены.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число входящих пакетов, которые были удалены.</returns>
		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x060038AF RID: 14511
		public abstract long ReceivedPacketsDiscarded { get; }

		/// <summary>Возвращает число переадресованных IP-пакетов.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число переадресованных пакетов.</returns>
		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x060038B0 RID: 14512
		public abstract long ReceivedPacketsForwarded { get; }

		/// <summary>Возвращает число полученных IP-пакетов с ошибками в адресе.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число IP-пакетов с ошибками в той части заголовка, которая касается адресов.</returns>
		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x060038B1 RID: 14513
		public abstract long ReceivedPacketsWithAddressErrors { get; }

		/// <summary>Возвращает число полученных IP-пакетов с ошибками в заголовке.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число полученных IP-пакетов, которые были удалены из-за ошибок в заголовке.</returns>
		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x060038B2 RID: 14514
		public abstract long ReceivedPacketsWithHeadersErrors { get; }

		/// <summary>Возвращает число IP-пакетов с неизвестным протоколом в заголовке, полученных локальным компьютером.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число полученных IP-пакетов с неизвестным протоколом.</returns>
		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x060038B3 RID: 14515
		public abstract long ReceivedPacketsWithUnknownProtocol { get; }

		/// <summary>Возвращает число маршрутов в таблице IP-маршрутизации.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число маршрутов в таблице маршрутизации.</returns>
		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x060038B4 RID: 14516
		public abstract int NumberOfRoutes { get; }
	}
}
