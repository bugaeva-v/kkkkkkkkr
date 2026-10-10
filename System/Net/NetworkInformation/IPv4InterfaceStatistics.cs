using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Предоставляет статистику сетевого интерфейса локального компьютера.</summary>
	// Token: 0x020006E6 RID: 1766
	public abstract class IPv4InterfaceStatistics
	{
		/// <summary>Возвращает число байтов, полученных интерфейсом.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число байтов, полученных интерфейсом.</returns>
		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x060038D0 RID: 14544
		public abstract long BytesReceived { get; }

		/// <summary>Возвращает число байтов, отправленных интерфейсом.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число байтов, переданных интерфейсом.</returns>
		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x060038D1 RID: 14545
		public abstract long BytesSent { get; }

		/// <summary>Возвращает число входящих пакетов, которые были удалены.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число удаленных входящих пакетов.</returns>
		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x060038D2 RID: 14546
		public abstract long IncomingPacketsDiscarded { get; }

		/// <summary>Возвращает число входящих пакетов с ошибками.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число удаленных входящих пакетов с ошибками.</returns>
		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x060038D3 RID: 14547
		public abstract long IncomingPacketsWithErrors { get; }

		/// <summary>Получает число входящих пакетов с неизвестным протоколом, которые были получены в интерфейсе.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число удаленных входящих пакетов с неизвестным протоколом.</returns>
		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x060038D4 RID: 14548
		public abstract long IncomingUnknownProtocolPackets { get; }

		/// <summary>Возвращает число неодноадресных пакетов, полученных интерфейсом.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число неодноадресных пакетов, полученных интерфейсом.</returns>
		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x060038D5 RID: 14549
		public abstract long NonUnicastPacketsReceived { get; }

		/// <summary>Возвращает число неодноадресных пакетов, отправленных интерфейсом.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число неодноадресных пакетов, отправленных интерфейсом.</returns>
		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x060038D6 RID: 14550
		public abstract long NonUnicastPacketsSent { get; }

		/// <summary>Возвращает число исходящих пакетов, которые были удалены.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число удаленных исходящих пакетов.</returns>
		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x060038D7 RID: 14551
		public abstract long OutgoingPacketsDiscarded { get; }

		/// <summary>Возвращает число исходящих пакетов с ошибками.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число удаленных исходящих пакетов с ошибками.</returns>
		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x060038D8 RID: 14552
		public abstract long OutgoingPacketsWithErrors { get; }

		/// <summary>Возвращает длину очереди вывода.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число пакетов в очереди вывода.</returns>
		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x060038D9 RID: 14553
		public abstract long OutputQueueLength { get; }

		/// <summary>Возвращает число одноадресных пакетов, полученных интерфейсом.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число одноадресных пакетов, полученных интерфейсом.</returns>
		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x060038DA RID: 14554
		public abstract long UnicastPacketsReceived { get; }

		/// <summary>Возвращает число одноадресных пакетов, отправленных интерфейсом.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее число одноадресных пакетов, отправленных интерфейсом.</returns>
		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x060038DB RID: 14555
		public abstract long UnicastPacketsSent { get; }
	}
}
