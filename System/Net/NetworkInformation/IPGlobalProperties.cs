using System;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace System.Net.NetworkInformation
{
	/// <summary>Предоставляет сведения о возможности сетевых подключений на локальном компьютере.</summary>
	// Token: 0x020006E2 RID: 1762
	public abstract class IPGlobalProperties
	{
		/// <summary>Возвращает объект, предоставляющий сведения о возможности подключения локального компьютера по сети и статистику трафика.</summary>
		/// <returns>Объект <see cref="T:System.Net.NetworkInformation.IPGlobalProperties" />, содержащий сведения о локальном компьютере.</returns>
		// Token: 0x06003888 RID: 14472 RVA: 0x000C8249 File Offset: 0x000C6449
		public static IPGlobalProperties GetIPGlobalProperties()
		{
			return IPGlobalPropertiesFactoryPal.Create();
		}

		// Token: 0x06003889 RID: 14473 RVA: 0x000C8250 File Offset: 0x000C6450
		internal static IPGlobalProperties InternalGetIPGlobalProperties()
		{
			return IPGlobalProperties.GetIPGlobalProperties();
		}

		/// <summary>Возвращает сведения о прослушивателях IPv4 и IPv6 UDP на локальном компьютере.</summary>
		/// <returns>Массив <see cref="T:System.Net.IPEndPoint" />, который содержит объекты, описывающие прослушиватели UDP, или пустой массив, если прослушивателей UDP не обнаружено.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">Сбой вызова функции Win32 <see langword="GetUdpTable" />.</exception>
		// Token: 0x0600388A RID: 14474
		public abstract IPEndPoint[] GetActiveUdpListeners();

		/// <summary>Возвращает сведения о конечной точке для прослушивателей IPv4 и IPv6 TCP на локальном компьютере.</summary>
		/// <returns>Массив <see cref="T:System.Net.IPEndPoint" />, который содержит объекты, описывающие активные прослушиватели TCP, или пустой массив, если активных прослушивателей TCP не обнаружено.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">Сбой функции Win32 <see langword="GetTcpTable" />.</exception>
		// Token: 0x0600388B RID: 14475
		public abstract IPEndPoint[] GetActiveTcpListeners();

		/// <summary>Возвращает сведения о подключениях IPv4 и IPv6 TCP на локальном компьютере.</summary>
		/// <returns>Массив <see cref="T:System.Net.NetworkInformation.TcpConnectionInformation" />, который содержит объекты, описывающие активные подключения TCP, или пустой массив, если активных подключений TCP не обнаружено.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">Сбой функции Win32 <see langword="GetTcpTable" />.</exception>
		// Token: 0x0600388C RID: 14476
		public abstract TcpConnectionInformation[] GetActiveTcpConnections();

		/// <summary>Возвращает имя области DHCP.</summary>
		/// <returns>Экземпляр <see cref="T:System.String" />, содержащий имя области DHCP, в которой находится компьютер.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">Вызов функции Win32 завершился с ошибкой.</exception>
		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x0600388D RID: 14477
		public abstract string DhcpScopeName { get; }

		/// <summary>Возвращает домен, в котором зарегистрирован локальный компьютер.</summary>
		/// <returns>Экземпляр <see cref="T:System.String" />, содержащий доменное имя компьютера. Если компьютер не принадлежит ни одному домену, возвращается значение <see cref="F:System.String.Empty" />.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">Вызов функции Win32 завершился с ошибкой.</exception>
		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x0600388E RID: 14478
		public abstract string DomainName { get; }

		/// <summary>Возвращает имя узла локального компьютера.</summary>
		/// <returns>Экземпляр <see cref="T:System.String" />, содержащий имя NetBIOS компьютера.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">Вызов функции Win32 завершился с ошибкой.</exception>
		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x0600388F RID: 14479
		public abstract string HostName { get; }

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, работает ли локальный компьютер в качестве WINS-прокси.</summary>
		/// <returns>Значение <see langword="true" />, если локальный компьютер является WINS-прокси; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">Вызов функции Win32 завершился с ошибкой.</exception>
		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06003890 RID: 14480
		public abstract bool IsWinsProxy { get; }

		/// <summary>Возвращает тип узла NetBIOS локального компьютера.</summary>
		/// <returns>Значение <see cref="T:System.Net.NetworkInformation.NetBiosNodeType" />.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">Вызов функции Win32 завершился с ошибкой.</exception>
		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x06003891 RID: 14481
		public abstract NetBiosNodeType NodeType { get; }

		/// <summary>Предоставляет статистику протокола TCP/IPv4 для локального компьютера.</summary>
		/// <returns>Объект <see cref="T:System.Net.NetworkInformation.TcpStatistics" />, предоставляющий статистику трафика протокола TCP/IPv4 для локального компьютера.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">Сбой вызова функции Win32 <see langword="GetTcpStatistics" />.</exception>
		// Token: 0x06003892 RID: 14482
		public abstract TcpStatistics GetTcpIPv4Statistics();

		/// <summary>Предоставляет статистику протокола TCP/IPv6 для локального компьютера.</summary>
		/// <returns>Объект <see cref="T:System.Net.NetworkInformation.TcpStatistics" />, предоставляющий статистику трафика протокола TCP/IPv6 для локального компьютера.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">Сбой вызова функции Win32 <see langword="GetTcpStatistics" />.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Операционная система на локальном компьютере не поддерживает протокол IPv6.</exception>
		// Token: 0x06003893 RID: 14483
		public abstract TcpStatistics GetTcpIPv6Statistics();

		/// <summary>Предоставляет статистику протокола UDP/IPv4 для локального компьютера.</summary>
		/// <returns>Объект <see cref="T:System.Net.NetworkInformation.UdpStatistics" />, предоставляющий статистику трафика протокола UDP/IPv4 для локального компьютера.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">Сбой вызова функции Win32 GetUdpStatistics.</exception>
		// Token: 0x06003894 RID: 14484
		public abstract UdpStatistics GetUdpIPv4Statistics();

		/// <summary>Предоставляет статистику протокола UDP/IPv6 для локального компьютера.</summary>
		/// <returns>Объект <see cref="T:System.Net.NetworkInformation.UdpStatistics" />, предоставляющий статистику трафика протокола UDP/IPv6 для локального компьютера.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">Сбой вызова функции Win32 <see langword="GetUdpStatistics" />.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Операционная система на локальном компьютере не поддерживает протокол IPv6.</exception>
		// Token: 0x06003895 RID: 14485
		public abstract UdpStatistics GetUdpIPv6Statistics();

		/// <summary>Предоставляет статистику протокола ICMPv4 для локального компьютера.</summary>
		/// <returns>Объект <see cref="T:System.Net.NetworkInformation.IcmpV4Statistics" />, предоставляющий статистику трафика протокола ICMPv4 для локального компьютера.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">Сбой функции Win32 <see langword="GetIcmpStatistics" />.</exception>
		// Token: 0x06003896 RID: 14486
		public abstract IcmpV4Statistics GetIcmpV4Statistics();

		/// <summary>Предоставляет статистику протокола ICMPv6 для локального компьютера.</summary>
		/// <returns>Объект <see cref="T:System.Net.NetworkInformation.IcmpV6Statistics" />, предоставляющий статистику трафика протокола ICMPv6 для локального компьютера.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">Сбой функции Win32 <see langword="GetIcmpStatisticsEx" />.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Операционная система, установленная на локальном компьютере, не является системой Microsoft XP или более поздней версией Windows.</exception>
		// Token: 0x06003897 RID: 14487
		public abstract IcmpV6Statistics GetIcmpV6Statistics();

		/// <summary>Предоставляет статистику протокола IPv4 для локального компьютера.</summary>
		/// <returns>Объект <see cref="T:System.Net.NetworkInformation.IPGlobalStatistics" />, предоставляющий статистику трафика протокола IPv4 для локального компьютера.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">Сбой вызова функции Win32 <see langword="GetIpStatistics" />.</exception>
		// Token: 0x06003898 RID: 14488
		public abstract IPGlobalStatistics GetIPv4GlobalStatistics();

		/// <summary>Предоставляет статистику протокола IPv6 для локального компьютера.</summary>
		/// <returns>Объект <see cref="T:System.Net.NetworkInformation.IPGlobalStatistics" />, предоставляющий статистику трафика протокола IPv6 для локального компьютера.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">Сбой вызова функции Win32 <see langword="GetIpStatistics" />.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Операционная система на локальном компьютере не поддерживает протокол IPv6.</exception>
		// Token: 0x06003899 RID: 14489
		public abstract IPGlobalStatistics GetIPv6GlobalStatistics();

		/// <summary>Получает стабильную одноадресную таблицу IP-адресов на локальном компьютере.</summary>
		/// <returns>Объект <see cref="T:System.Net.NetworkInformation.UnicastIPAddressInformationCollection" />, содержащий список стабильных одноадресных таблиц IP-адресов на локальном компьютере.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">Сбой вызова машинной функции <see langword="GetAdaptersAddresses" />.</exception>
		/// <exception cref="T:System.NotImplementedException">Этот метод не реализован на платформе. Этот метод использует собственную функцию <see langword="NotifyStableUnicastIpAddressTable" />, которая поддерживается в Windows Vista и более поздних версиях.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий оператор не обязан иметь разрешение <see cref="F:System.Net.NetworkInformation.NetworkInformationAccess.Read" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Сбой вызова машинной функции <see langword="NotifyStableUnicastIpAddressTable" />.</exception>
		// Token: 0x0600389A RID: 14490 RVA: 0x000A5C4A File Offset: 0x000A3E4A
		public virtual UnicastIPAddressInformationCollection GetUnicastAddresses()
		{
			throw ExceptionHelper.MethodNotImplementedException;
		}

		/// <summary>Начинает асинхронный запрос для получения стабильной одноадресной таблицы IP-адресов на локальном компьютере.</summary>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />.</param>
		/// <param name="state">Объект, содержащий сведения о состоянии для этого запроса.</param>
		/// <returns>Класс <see cref="T:System.IAsyncResult" />, ссылающийся на асинхронный запрос.</returns>
		/// <exception cref="T:System.NotImplementedException">Этот метод не реализован на платформе. Этот метод использует собственную функцию <see langword="NotifyStableUnicastIpAddressTable" />, которая поддерживается в Windows Vista и более поздних версиях.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Сбой вызова машинной функции <see langword="NotifyStableUnicastIpAddressTable" />.</exception>
		// Token: 0x0600389B RID: 14491 RVA: 0x000A5C4A File Offset: 0x000A3E4A
		public virtual IAsyncResult BeginGetUnicastAddresses(AsyncCallback callback, object state)
		{
			throw ExceptionHelper.MethodNotImplementedException;
		}

		/// <summary>Завершает ожидающий асинхронный запрос для получения стабильной одноадресной таблицы IP-адресов на локальном компьютере.</summary>
		/// <param name="asyncResult">Класс <see cref="T:System.IAsyncResult" />, ссылающийся на асинхронный запрос.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, в котором хранятся сведения о состоянии и любые данные, определенные пользователем, для этой асинхронной операции.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">Сбой вызова машинной функции <see langword="GetAdaptersAddresses" />.</exception>
		/// <exception cref="T:System.NotImplementedException">Этот метод не реализован на платформе. Этот метод использует собственную функцию <see langword="NotifyStableUnicastIpAddressTable" />, которая поддерживается в Windows Vista и более поздних версиях.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий оператор не обязан иметь разрешение <see cref="F:System.Net.NetworkInformation.NetworkInformationAccess.Read" />.</exception>
		// Token: 0x0600389C RID: 14492 RVA: 0x000A5C4A File Offset: 0x000A3E4A
		public virtual UnicastIPAddressInformationCollection EndGetUnicastAddresses(IAsyncResult asyncResult)
		{
			throw ExceptionHelper.MethodNotImplementedException;
		}

		/// <summary>Извлекает стабильной одноадресной таблицы IP-адресов на локальном компьютере как асинхронная операция.</summary>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">Сбой вызова машинной функции <see langword="GetAdaptersAddresses" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий оператор не обязан иметь разрешение <see cref="F:System.Net.NetworkInformation.NetworkInformationAccess.Read" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Сбой вызова машинной функции <see langword="NotifyStableUnicastIpAddressTable" />.</exception>
		// Token: 0x0600389D RID: 14493 RVA: 0x000C8257 File Offset: 0x000C6457
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public virtual Task<UnicastIPAddressInformationCollection> GetUnicastAddressesAsync()
		{
			return Task<UnicastIPAddressInformationCollection>.Factory.FromAsync(new Func<AsyncCallback, object, IAsyncResult>(this.BeginGetUnicastAddresses), new Func<IAsyncResult, UnicastIPAddressInformationCollection>(this.EndGetUnicastAddresses), null);
		}
	}
}
