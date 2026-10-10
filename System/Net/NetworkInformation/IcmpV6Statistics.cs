using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Предоставляет статистику протокола ICMPv6 для локального компьютера.</summary>
	// Token: 0x020006ED RID: 1773
	public abstract class IcmpV6Statistics
	{
		/// <summary>Возвращает количество сообщений ICMPv6, полученных из-за того, что пакет имеет недоступный адрес в поле назначения.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество полученных сообщений "узел назначения недоступен" (Destination Unreachable).</returns>
		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x06003904 RID: 14596
		public abstract long DestinationUnreachableMessagesReceived { get; }

		/// <summary>Возвращает количество сообщений ICMPv6, отправленных из-за того, что пакет имеет недоступный адрес в поле назначения.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество отправленных сообщений "узел назначения недоступен" (Destination Unreachable).</returns>
		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x06003905 RID: 14597
		public abstract long DestinationUnreachableMessagesSent { get; }

		/// <summary>Возвращает количество полученных сообщений ICMPv6 "Эхо-ответ" (Echo Reply).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее количество полученных сообщений ICMP "Эхо-ответ" (Echo Reply).</returns>
		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x06003906 RID: 14598
		public abstract long EchoRepliesReceived { get; }

		/// <summary>Возвращает количество отправленных сообщений ICMPv6 "Эхо-ответ" (Echo Reply).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее количество отправленных сообщений ICMP "Эхо-ответ" (Echo Reply).</returns>
		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x06003907 RID: 14599
		public abstract long EchoRepliesSent { get; }

		/// <summary>Возвращает количество полученных сообщений ICMPv6 "Эхо-запрос" (Echo Request).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее количество полученных сообщений ICMP "Эхо-запрос" (Echo Request).</returns>
		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x06003908 RID: 14600
		public abstract long EchoRequestsReceived { get; }

		/// <summary>Возвращает количество отправленных сообщений ICMPv6 "Эхо-запрос" (Echo Request).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее количество отправленных сообщений ICMP "Эхо-запрос" (Echo Request).</returns>
		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x06003909 RID: 14601
		public abstract long EchoRequestsSent { get; }

		/// <summary>Возвращает количество полученных сообщений ICMPv6 об ошибках.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество полученных сообщений ICMP об ошибках.</returns>
		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x0600390A RID: 14602
		public abstract long ErrorsReceived { get; }

		/// <summary>Возвращает количество отправленных сообщений ICMPv6 об ошибках.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество отправленных сообщений ICMP об ошибках.</returns>
		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x0600390B RID: 14603
		public abstract long ErrorsSent { get; }

		/// <summary>Возвращает количество полученных сообщений IGMP "Запрос о членстве в группе" (Group Membership Query).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество полученных сообщений "Запрос о членстве в группе" (Group Membership Query).</returns>
		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x0600390C RID: 14604
		public abstract long MembershipQueriesReceived { get; }

		/// <summary>Возвращает количество отправленных сообщений IGMP "Запрос о членстве в группе" (Group Membership Query).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество отправленных сообщений "Запрос о членстве в группе" (Group Membership Query).</returns>
		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x0600390D RID: 14605
		public abstract long MembershipQueriesSent { get; }

		/// <summary>Возвращает количество полученных сообщений IGMP "Прекращение членства в группе" (Group Membership Reduction).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество полученных сообщений "Прекращение членства в группе" (Group Membership Reduction).</returns>
		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x0600390E RID: 14606
		public abstract long MembershipReductionsReceived { get; }

		/// <summary>Возвращает количество отправленных сообщений IGMP "Прекращение членства в группе" (Group Membership Reduction).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество отправленных сообщений "Прекращение членства в группе" (Group Membership Reduction).</returns>
		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x0600390F RID: 14607
		public abstract long MembershipReductionsSent { get; }

		/// <summary>Возвращает количество полученных сообщений IGMP "Отчет о членстве в группе" (Group Membership Report).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество полученных сообщений "Отчет о членстве в группе" (Group Membership Report).</returns>
		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x06003910 RID: 14608
		public abstract long MembershipReportsReceived { get; }

		/// <summary>Возвращает количество отправленных сообщений IGMP "Отчет о членстве в группе" (Group Membership Report).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество отправленных сообщений "Отчет о членстве в группе" (Group Membership Report).</returns>
		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x06003911 RID: 14609
		public abstract long MembershipReportsSent { get; }

		/// <summary>Возвращает количество полученных сообщений ICMPv6.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество полученных сообщений ICMPv6.</returns>
		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x06003912 RID: 14610
		public abstract long MessagesReceived { get; }

		/// <summary>Возвращает количество отправленных сообщений ICMPv6.</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество отправленных сообщений ICMPv6.</returns>
		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06003913 RID: 14611
		public abstract long MessagesSent { get; }

		/// <summary>Возвращает количество полученных сообщений ICMPv6 "Объявление соседа" (Neighbor Advertisement).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее количество полученных сообщений ICMP "Объявление соседа" (Neighbor Advertisement).</returns>
		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x06003914 RID: 14612
		public abstract long NeighborAdvertisementsReceived { get; }

		/// <summary>Возвращает количество отправленных сообщений ICMPv6 "Объявление соседа" (Neighbor Advertisement).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество отправленных сообщений "Объявление соседа" (Neighbor Advertisement).</returns>
		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x06003915 RID: 14613
		public abstract long NeighborAdvertisementsSent { get; }

		/// <summary>Возвращает количество полученных сообщений ICMPv6 "Запрос соседа" (Neighbor Solicitation).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество полученных сообщений "Запрос соседа" (Neighbor Solicitation).</returns>
		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x06003916 RID: 14614
		public abstract long NeighborSolicitsReceived { get; }

		/// <summary>Возвращает количество отправленных сообщений ICMPv6 "Запрос соседа" (Neighbor Solicitation).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество отправленных сообщений "Запрос соседа" (Neighbor Solicitation).</returns>
		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x06003917 RID: 14615
		public abstract long NeighborSolicitsSent { get; }

		/// <summary>Возвращает количество полученных сообщений ICMPv6 "Пакет слишком велик" (Packet Too Big).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество полученных сообщений ICMP "Пакет слишком велик" (Packet Too Big).</returns>
		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x06003918 RID: 14616
		public abstract long PacketTooBigMessagesReceived { get; }

		/// <summary>Возвращает количество отправленных сообщений ICMPv6 "Пакет слишком велик" (Packet Too Big).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество отправленных сообщений ICMP "Пакет слишком велик" (Packet Too Big).</returns>
		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x06003919 RID: 14617
		public abstract long PacketTooBigMessagesSent { get; }

		/// <summary>Возвращает количество полученных сообщений ICMPv6 "Ошибка параметра" (Parameter Problem).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество полученных сообщений ICMP "Ошибка параметра" (Parameter Problem).</returns>
		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x0600391A RID: 14618
		public abstract long ParameterProblemsReceived { get; }

		/// <summary>Возвращает количество отправленных сообщений ICMPv6 "Ошибка параметра" (Parameter Problem).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество отправленных сообщений ICMP "Ошибка параметра" (Parameter Problem).</returns>
		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x0600391B RID: 14619
		public abstract long ParameterProblemsSent { get; }

		/// <summary>Возвращает количество полученных сообщений ICMPv6 "Перенаправление маршрута" (Redirect).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество полученных сообщений ICMP "Перенаправление маршрута" (Redirect).</returns>
		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x0600391C RID: 14620
		public abstract long RedirectsReceived { get; }

		/// <summary>Возвращает количество отправленных сообщений ICMPv6 "Перенаправление маршрута" (Redirect).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество отправленных сообщений ICMP "Перенаправление маршрута" (Redirect).</returns>
		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x0600391D RID: 14621
		public abstract long RedirectsSent { get; }

		/// <summary>Возвращает количество полученных сообщений ICMPv6 "Объявление маршрутизатора" (Router Advertisement).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество полученных сообщений "Объявление маршрутизатора" (Router Advertisement).</returns>
		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x0600391E RID: 14622
		public abstract long RouterAdvertisementsReceived { get; }

		/// <summary>Возвращает количество отправленных сообщений ICMPv6 "Объявление маршрутизатора".</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество отправленных сообщений "Объявление маршрутизатора".</returns>
		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x0600391F RID: 14623
		public abstract long RouterAdvertisementsSent { get; }

		/// <summary>Возвращает количество полученных сообщений ICMPv6 "Запрос маршрутизатора" (Router Solicitation).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество полученных сообщений "Запрос маршрутизатора" (Router Solicitation).</returns>
		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06003920 RID: 14624
		public abstract long RouterSolicitsReceived { get; }

		/// <summary>Возвращает количество отправленных сообщений ICMPv6 "Запрос маршрутизатора" (Router Solicitation).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество отправленных сообщений "Запрос маршрутизатора" (Router Solicitation).</returns>
		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x06003921 RID: 14625
		public abstract long RouterSolicitsSent { get; }

		/// <summary>Возвращает количество полученных сообщений ICMPv6 "Превышено время" (Time Exceeded).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество полученных сообщений ICMP "Превышено время" (Time Exceeded).</returns>
		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x06003922 RID: 14626
		public abstract long TimeExceededMessagesReceived { get; }

		/// <summary>Возвращает количество отправленных сообщений ICMPv6 "Превышено время" (Time Exceeded).</summary>
		/// <returns>Значение типа <see cref="T:System.Int64" />, указывающее общее количество отправленных сообщений ICMP "Превышено время" (Time Exceeded).</returns>
		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x06003923 RID: 14627
		public abstract long TimeExceededMessagesSent { get; }
	}
}
