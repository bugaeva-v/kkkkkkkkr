using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Предоставляет статистику протокола Интернета (IP) для сетевого интерфейса локального компьютера.</summary>
	// Token: 0x020006E5 RID: 1765
	public abstract class IPInterfaceStatistics
	{
		/// <summary>Возвращает число байтов, полученных интерфейсом.</summary>
		/// <returns>Общее число байтов, полученных интерфейсом.</returns>
		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x060038C3 RID: 14531
		public abstract long BytesReceived { get; }

		/// <summary>Возвращает число байтов, отправленных интерфейсом.</summary>
		/// <returns>Общее число байтов, отправленных интерфейсом.</returns>
		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x060038C4 RID: 14532
		public abstract long BytesSent { get; }

		/// <summary>Возвращает число входящих пакетов, которые были удалены.</summary>
		/// <returns>Общее число входящих пакетов, которые были удалены.</returns>
		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x060038C5 RID: 14533
		public abstract long IncomingPacketsDiscarded { get; }

		/// <summary>Возвращает число входящих пакетов с ошибками.</summary>
		/// <returns>Общее число входящих пакетов с ошибками.</returns>
		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x060038C6 RID: 14534
		public abstract long IncomingPacketsWithErrors { get; }

		/// <summary>Получает число входящих пакетов с неизвестным протоколом, которые были получены в интерфейсе.</summary>
		/// <returns>Общее число входящих пакетов с неизвестным протоколом, которые были получены в интерфейсе.</returns>
		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x060038C7 RID: 14535
		public abstract long IncomingUnknownProtocolPackets { get; }

		/// <summary>Возвращает число неодноадресных пакетов, полученных интерфейсом.</summary>
		/// <returns>Общее число входящих неодноадресных пакетов, полученных интерфейсом.</returns>
		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x060038C8 RID: 14536
		public abstract long NonUnicastPacketsReceived { get; }

		/// <summary>Возвращает число неодноадресных пакетов, отправленных интерфейсом.</summary>
		/// <returns>Общее число неодноадресных пакетов, отправленных интерфейсом.</returns>
		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x060038C9 RID: 14537
		public abstract long NonUnicastPacketsSent { get; }

		/// <summary>Возвращает число исходящих пакетов, которые были удалены.</summary>
		/// <returns>Общее число исходящих пакетов, которые были удалены.</returns>
		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x060038CA RID: 14538
		public abstract long OutgoingPacketsDiscarded { get; }

		/// <summary>Возвращает число исходящих пакетов с ошибками.</summary>
		/// <returns>Общее число исходящих пакетов с ошибками.</returns>
		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x060038CB RID: 14539
		public abstract long OutgoingPacketsWithErrors { get; }

		/// <summary>Возвращает длину очереди вывода.</summary>
		/// <returns>Общее число пакетов в выходной очереди.</returns>
		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x060038CC RID: 14540
		public abstract long OutputQueueLength { get; }

		/// <summary>Возвращает число одноадресных пакетов, полученных интерфейсом.</summary>
		/// <returns>Общее число одноадресных пакетов, полученных интерфейсом.</returns>
		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x060038CD RID: 14541
		public abstract long UnicastPacketsReceived { get; }

		/// <summary>Возвращает число одноадресных пакетов, отправленных интерфейсом.</summary>
		/// <returns>Общее число одноадресных пакетов, отправленных интерфейсом.</returns>
		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x060038CE RID: 14542
		public abstract long UnicastPacketsSent { get; }
	}
}
