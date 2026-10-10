using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Предоставляет сведения о сетевых интерфейсах, поддерживающих протокол IPv4 или IPv6.</summary>
	// Token: 0x020006E4 RID: 1764
	public abstract class IPInterfaceProperties
	{
		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, настроен ли на этом интерфейсе NetBIOS через TCP/IP для использования разрешения DNS-имен.</summary>
		/// <returns>Значение <see langword="true" />, если на этом интерфейсе настроен NetBIOS через TCP/IP для использования разрешения DNS-имен; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x060038B6 RID: 14518
		public abstract bool IsDnsEnabled { get; }

		/// <summary>Возвращает DNS-суффикс, соответствующий данному интерфейсу.</summary>
		/// <returns>Строка <see cref="T:System.String" />, которая содержит DNS-суффикс данного интерфейса или значение <see cref="F:System.String.Empty" />, если у интерфейса нет DNS-суффикса.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Это свойство не поддерживается на компьютерах с операционными системами более ранних версий, чем Windows 2000.</exception>
		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x060038B7 RID: 14519
		public abstract string DnsSuffix { get; }

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />. указывающее, настроена ли на интерфейсе автоматическая регистрация IP-адресов в DNS.</summary>
		/// <returns>Значение <see langword="true" />, если на интерфейсе настроена автоматическая регистрация соответствия между динамическим IP-адресом и статическими доменными именами; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x060038B8 RID: 14520
		public abstract bool IsDynamicDnsEnabled { get; }

		/// <summary>Возвращает адреса одноадресной рассылки, назначенные интерфейсу.</summary>
		/// <returns>Объект <see cref="T:System.Net.NetworkInformation.UnicastIPAddressInformationCollection" />, содержащий адреса одноадресной рассылки интерфейса.</returns>
		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x060038B9 RID: 14521
		public abstract UnicastIPAddressInformationCollection UnicastAddresses { get; }

		/// <summary>Возвращает адреса многоадресной рассылки, назначенные интерфейсу.</summary>
		/// <returns>Объект <see cref="T:System.Net.NetworkInformation.MulticastIPAddressInformationCollection" />, содержащий адреса многоадресной рассылки интерфейса.</returns>
		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x060038BA RID: 14522
		public abstract MulticastIPAddressInformationCollection MulticastAddresses { get; }

		/// <summary>Возвращает IP-адреса произвольной рассылки, назначенные интерфейсу.</summary>
		/// <returns>Объект <see cref="T:System.Net.NetworkInformation.IPAddressInformationCollection" />, содержащий адреса произвольной рассылки интерфейса.</returns>
		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x060038BB RID: 14523
		public abstract IPAddressInformationCollection AnycastAddresses { get; }

		/// <summary>Возвращает адреса DNS-серверов для данного интерфейса.</summary>
		/// <returns>Объект <see cref="T:System.Net.NetworkInformation.IPAddressCollection" />, содержащий адреса DNS-серверов.</returns>
		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x060038BC RID: 14524
		public abstract IPAddressCollection DnsAddresses { get; }

		/// <summary>Возвращает адреса сетевых шлюзов IPv4 для данного интерфейса.</summary>
		/// <returns>Объект <see cref="T:System.Net.NetworkInformation.GatewayIPAddressInformationCollection" />, содержащий адреса сетевых шлюзов, или пустой массив, если шлюзы не обнаружены.</returns>
		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x060038BD RID: 14525
		public abstract GatewayIPAddressInformationCollection GatewayAddresses { get; }

		/// <summary>Возвращает адреса DHCP-серверов для данного интерфейса.</summary>
		/// <returns>Объект <see cref="T:System.Net.NetworkInformation.IPAddressCollection" />, содержащий адреса DHCP-серверов, или пустой массив, если серверы не обнаружены.</returns>
		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x060038BE RID: 14526
		public abstract IPAddressCollection DhcpServerAddresses { get; }

		/// <summary>Возвращает адреса WINS-серверов.</summary>
		/// <returns>Объект <see cref="T:System.Net.NetworkInformation.IPAddressCollection" />, содержащий адреса WINS-серверов, или пустой массив, если серверы не обнаружены.</returns>
		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x060038BF RID: 14527
		public abstract IPAddressCollection WinsServersAddresses { get; }

		/// <summary>Предоставляет данные конфигурации протокола IPv4 для данного сетевого интерфейса.</summary>
		/// <returns>Объект <see cref="T:System.Net.NetworkInformation.IPv4InterfaceProperties" />, содержащий данные конфигурации протокола IPv4, или <see langword="null" />, если эти данные для интерфейса недоступны.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">Интерфейс не поддерживает протокол IPv4.</exception>
		// Token: 0x060038C0 RID: 14528
		public abstract IPv4InterfaceProperties GetIPv4Properties();

		/// <summary>Предоставляет данные конфигурации протокола IPv6 для данного сетевого интерфейса.</summary>
		/// <returns>Объект <see cref="T:System.Net.NetworkInformation.IPv6InterfaceProperties" />, содержащий данные конфигурации протокола IPv6.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">Интерфейс не поддерживает протокол IPv6.</exception>
		// Token: 0x060038C1 RID: 14529
		public abstract IPv6InterfaceProperties GetIPv6Properties();
	}
}
