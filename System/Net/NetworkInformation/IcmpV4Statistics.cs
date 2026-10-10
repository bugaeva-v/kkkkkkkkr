using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Предоставляет статистику протокола ICMPv4 для локального компьютера.</summary>
	// Token: 0x020006EC RID: 1772
	public abstract class IcmpV4Statistics
	{
		/// <summary>Возвращает количество полученных сообщений ICMPv4 "Ответ с маской адреса" (Address Mask Reply).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество полученных сообщений "Ответ с маской адреса" (Address Mask Reply).</returns>
		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x060038E9 RID: 14569
		public abstract long AddressMaskRepliesReceived { get; }

		/// <summary>Возвращает количество отправленных сообщений ICMPv4 "Ответ с маской адреса" (Address Mask Reply).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество отправленных сообщений "Ответ с маской адреса" (Address Mask Reply).</returns>
		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x060038EA RID: 14570
		public abstract long AddressMaskRepliesSent { get; }

		/// <summary>Возвращает количество полученных сообщений ICMPv4 "Запрос маски адреса" (Address Mask Request).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество полученных сообщений "Запрос маски адреса" (Address Mask Request).</returns>
		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x060038EB RID: 14571
		public abstract long AddressMaskRequestsReceived { get; }

		/// <summary>Возвращает количество отправленных сообщений ICMPv4 "Запрос маски адреса" (Address Mask Request).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество отправленных сообщений "Запрос маски адреса" (Address Mask Request).</returns>
		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x060038EC RID: 14572
		public abstract long AddressMaskRequestsSent { get; }

		/// <summary>Возвращает количество сообщений ICMPv4, полученных из-за того, что пакет имеет недоступный адрес в поле назначения.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество полученных сообщений "узел назначения недоступен" (Destination Unreachable).</returns>
		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x060038ED RID: 14573
		public abstract long DestinationUnreachableMessagesReceived { get; }

		/// <summary>Возвращает количество сообщений ICMPv4, отправленных из-за того, что пакет имеет недоступный адрес в поле назначения.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество отправленных сообщений "узел назначения недоступен" (Destination Unreachable).</returns>
		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x060038EE RID: 14574
		public abstract long DestinationUnreachableMessagesSent { get; }

		/// <summary>Возвращает количество полученных сообщений ICMPv4 "Ответ проверки связи" (Echo Reply).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество полученных сообщений ICMP "Ответ проверки связи" (Echo Reply).</returns>
		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x060038EF RID: 14575
		public abstract long EchoRepliesReceived { get; }

		/// <summary>Возвращает количество отправленных сообщений ICMPv4 "Ответ проверки связи" (Echo Reply).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество отправленных сообщений ICMP "Ответ проверки связи" (Echo Reply).</returns>
		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x060038F0 RID: 14576
		public abstract long EchoRepliesSent { get; }

		/// <summary>Возвращает количество полученных сообщений ICMPv4 "Запрос проверки связи" (Echo Request).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество полученных сообщений ICMP "Запрос проверки связи" (Echo Request).</returns>
		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x060038F1 RID: 14577
		public abstract long EchoRequestsReceived { get; }

		/// <summary>Возвращает количество отправленных сообщений ICMPv4 "Запрос проверки связи" (Echo Request).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество отпарвленных сообщений ICMP "Запрос проверки связи" (Echo Request).</returns>
		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x060038F2 RID: 14578
		public abstract long EchoRequestsSent { get; }

		/// <summary>Возвращает количество полученных сообщений ICMPv4 об ошибках.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество полученных сообщений ICMP об ошибках.</returns>
		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x060038F3 RID: 14579
		public abstract long ErrorsReceived { get; }

		/// <summary>Возвращает количество отправленных сообщений ICMPv4 об ошибках.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество отправленных сообщений ICMP об ошибках.</returns>
		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x060038F4 RID: 14580
		public abstract long ErrorsSent { get; }

		/// <summary>Возвращает количество полученных сообщений ICMP.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество полученных сообщений ICMPv4.</returns>
		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x060038F5 RID: 14581
		public abstract long MessagesReceived { get; }

		/// <summary>Возвращает количество отправленных сообщений ICMPv4.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество отправленных сообщений ICMPv4.</returns>
		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x060038F6 RID: 14582
		public abstract long MessagesSent { get; }

		/// <summary>Возвращает количество полученных сообщений ICMPv4 "Ошибка параметра" (Parameter Problem).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество полученных сообщений ICMP "Ошибка параметра" (Parameter Problem).</returns>
		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x060038F7 RID: 14583
		public abstract long ParameterProblemsReceived { get; }

		/// <summary>Возвращает количество отправленных сообщений ICMPv4 "Ошибка параметра" (Parameter Problem).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество отправленных сообщений ICMP "Ошибка параметра" (Parameter Problem).</returns>
		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x060038F8 RID: 14584
		public abstract long ParameterProblemsSent { get; }

		/// <summary>Возвращает количество полученных сообщений ICMPv4 "Перенаправление маршрута" (Redirect).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество полученных сообщений ICMP "Перенаправление маршрута" (Redirect).</returns>
		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x060038F9 RID: 14585
		public abstract long RedirectsReceived { get; }

		/// <summary>Возвращает количество отправленных сообщений ICMPv4 "Перенаправление маршрута" (Redirect).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество отправленных сообщений ICMP "Перенаправление маршрута" (Redirect).</returns>
		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x060038FA RID: 14586
		public abstract long RedirectsSent { get; }

		/// <summary>Возвращает количество полученных сообщений ICMPv4 "Понижение скорости источником" (Source Quench).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество полученных сообщений "Понижение скорости источником" (Source Quench).</returns>
		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x060038FB RID: 14587
		public abstract long SourceQuenchesReceived { get; }

		/// <summary>Возвращает количество отправленных сообщений ICMPv4 "Понижение скорости источником" (Source Quench).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество отправленных сообщений "Понижение скорости источником" (Source Quench).</returns>
		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x060038FC RID: 14588
		public abstract long SourceQuenchesSent { get; }

		/// <summary>Возвращает количество полученных сообщений ICMPv4 "Превышено время" (Time Exceeded).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество полученных сообщений ICMP "Превышено время" (Time Exceeded).</returns>
		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x060038FD RID: 14589
		public abstract long TimeExceededMessagesReceived { get; }

		/// <summary>Возвращает количество отправленных сообщений ICMPv4 "Превышено время" (Time Exceeded).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество отправленных сообщений ICMP "Превышено время" (Time Exceeded).</returns>
		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x060038FE RID: 14590
		public abstract long TimeExceededMessagesSent { get; }

		/// <summary>Возвращает количество полученных сообщений ICMPv4 "Ответ штампа времени" (Timestamp Reply).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество полученных сообщений "Ответ штампа времени" (Timestamp Reply).</returns>
		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x060038FF RID: 14591
		public abstract long TimestampRepliesReceived { get; }

		/// <summary>Возвращает количество отправленных сообщений ICMPv4 "Ответ штампа времени" (Timestamp Reply).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество отправленных сообщений "Ответ штампа времени" (Timestamp Reply).</returns>
		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x06003900 RID: 14592
		public abstract long TimestampRepliesSent { get; }

		/// <summary>Возвращает количество полученных сообщений ICMPv4 "Запрос штампа времени" (Timestamp Request).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество полученных сообщений "Запрос штампа времени" (Timestamp Request).</returns>
		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06003901 RID: 14593
		public abstract long TimestampRequestsReceived { get; }

		/// <summary>Возвращает количество отправленных сообщений ICMPv4 "Запрос штампа времени" (Timestamp Request).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество отправленных сообщений "Запрос штампа времени" (Timestamp Request).</returns>
		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x06003902 RID: 14594
		public abstract long TimestampRequestsSent { get; }
	}
}
