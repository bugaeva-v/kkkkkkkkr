using System;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace System.Net.Sockets
{
	/// <summary>Предоставляет сетевые службы по протоколу UDP (User Datagram Protocol).</summary>
	// Token: 0x020007BD RID: 1981
	public class UdpClient : IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.UdpClient" />.</summary>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		// Token: 0x06003F16 RID: 16150 RVA: 0x000D781B File Offset: 0x000D5A1B
		public UdpClient() : this(AddressFamily.InterNetwork)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.UdpClient" />.</summary>
		/// <param name="family">Одно из значений <see cref="T:System.Net.Sockets.AddressFamily" />, которое задает схему адресации для сокета.</param>
		/// <exception cref="T:System.ArgumentException">Свойству <paramref name="family" /> задано значение, отличное от <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> или <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		// Token: 0x06003F17 RID: 16151 RVA: 0x000D7824 File Offset: 0x000D5A24
		public UdpClient(AddressFamily family)
		{
			this.m_Buffer = new byte[65536];
			this.m_Family = AddressFamily.InterNetwork;
			base..ctor();
			if (family != AddressFamily.InterNetwork && family != AddressFamily.InterNetworkV6)
			{
				throw new ArgumentException(SR.GetString("'{0}' Client can only accept InterNetwork or InterNetworkV6 addresses.", new object[]
				{
					"UDP"
				}), "family");
			}
			this.m_Family = family;
			this.createClientSocket();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.UdpClient" /> и связывает его с заданным номером локального порта.</summary>
		/// <param name="port">Номер локального порта, который планируется использовать для связи.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="port" /> больше значения <see cref="F:System.Net.IPEndPoint.MaxPort" /> или меньше значения <see cref="F:System.Net.IPEndPoint.MinPort" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		// Token: 0x06003F18 RID: 16152 RVA: 0x000D7887 File Offset: 0x000D5A87
		public UdpClient(int port) : this(port, AddressFamily.InterNetwork)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.UdpClient" /> и связывает его с заданным номером локального порта.</summary>
		/// <param name="port">Порт, на котором производится ожидание входящих попыток подключений.</param>
		/// <param name="family">Одно из значений <see cref="T:System.Net.Sockets.AddressFamily" />, которое задает схему адресации для сокета.</param>
		/// <exception cref="T:System.ArgumentException">Свойству <paramref name="family" /> задано значение, отличное от <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> или <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="port" /> больше <see cref="F:System.Net.IPEndPoint.MaxPort" /> или меньше <see cref="F:System.Net.IPEndPoint.MinPort" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		// Token: 0x06003F19 RID: 16153 RVA: 0x000D7894 File Offset: 0x000D5A94
		public UdpClient(int port, AddressFamily family)
		{
			this.m_Buffer = new byte[65536];
			this.m_Family = AddressFamily.InterNetwork;
			base..ctor();
			if (!ValidationHelper.ValidateTcpPort(port))
			{
				throw new ArgumentOutOfRangeException("port");
			}
			if (family != AddressFamily.InterNetwork && family != AddressFamily.InterNetworkV6)
			{
				throw new ArgumentException(SR.GetString("'{0}' Client can only accept InterNetwork or InterNetworkV6 addresses."), "family");
			}
			this.m_Family = family;
			IPEndPoint localEP;
			if (this.m_Family == AddressFamily.InterNetwork)
			{
				localEP = new IPEndPoint(IPAddress.Any, port);
			}
			else
			{
				localEP = new IPEndPoint(IPAddress.IPv6Any, port);
			}
			this.createClientSocket();
			this.Client.Bind(localEP);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.UdpClient" /> и связывает его с заданной локальной конечной точкой.</summary>
		/// <param name="localEP">Объект <see cref="T:System.Net.IPEndPoint" />, предоставляющий локальную конечную точку, к которой выполняется привязка UDP-подключения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="localEP" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		// Token: 0x06003F1A RID: 16154 RVA: 0x000D792C File Offset: 0x000D5B2C
		public UdpClient(IPEndPoint localEP)
		{
			this.m_Buffer = new byte[65536];
			this.m_Family = AddressFamily.InterNetwork;
			base..ctor();
			if (localEP == null)
			{
				throw new ArgumentNullException("localEP");
			}
			this.m_Family = localEP.AddressFamily;
			this.createClientSocket();
			this.Client.Bind(localEP);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.UdpClient" /> и устанавливает удаленный узел, используемый по умолчанию.</summary>
		/// <param name="hostname">Имя удаленного DNS-узла, к которому планируется подключение.</param>
		/// <param name="port">Номер удаленного порта, к которому планируется выполнить подключение.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="hostname" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="port" /> не находится в диапазоне между значениями <see cref="F:System.Net.IPEndPoint.MinPort" /> и <see cref="F:System.Net.IPEndPoint.MaxPort" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		// Token: 0x06003F1B RID: 16155 RVA: 0x000D7984 File Offset: 0x000D5B84
		public UdpClient(string hostname, int port)
		{
			this.m_Buffer = new byte[65536];
			this.m_Family = AddressFamily.InterNetwork;
			base..ctor();
			if (hostname == null)
			{
				throw new ArgumentNullException("hostname");
			}
			if (!ValidationHelper.ValidateTcpPort(port))
			{
				throw new ArgumentOutOfRangeException("port");
			}
			this.Connect(hostname, port);
		}

		/// <summary>Получает или задает основной сетевой объект <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <returns>Основной сетевой объект <see cref="T:System.Net.Sockets.Socket" />.</returns>
		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06003F1C RID: 16156 RVA: 0x000D79D7 File Offset: 0x000D5BD7
		// (set) Token: 0x06003F1D RID: 16157 RVA: 0x000D79DF File Offset: 0x000D5BDF
		public Socket Client
		{
			get
			{
				return this.m_ClientSocket;
			}
			set
			{
				this.m_ClientSocket = value;
			}
		}

		/// <summary>Получает или задает значение, указывающее, установлен ли удаленный узел, используемый по умолчанию.</summary>
		/// <returns>Значение <see langword="true" />, если подключение активно; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x06003F1E RID: 16158 RVA: 0x000D79E8 File Offset: 0x000D5BE8
		// (set) Token: 0x06003F1F RID: 16159 RVA: 0x000D79F0 File Offset: 0x000D5BF0
		protected bool Active
		{
			get
			{
				return this.m_Active;
			}
			set
			{
				this.m_Active = value;
			}
		}

		/// <summary>Возвращает значение, указывающее количество полученных из сети и доступных для чтения данных.</summary>
		/// <returns>Число байтов данных, полученных из сети.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x06003F20 RID: 16160 RVA: 0x000D79F9 File Offset: 0x000D5BF9
		public int Available
		{
			get
			{
				return this.m_ClientSocket.Available;
			}
		}

		/// <summary>Получает или задает значение, указывающее время существования TTL (Time To Live) для IP-пакетов, отправленных объектом <see cref="T:System.Net.Sockets.UdpClient" />.</summary>
		/// <returns>Значение времени существования TTL.</returns>
		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06003F21 RID: 16161 RVA: 0x000D7A06 File Offset: 0x000D5C06
		// (set) Token: 0x06003F22 RID: 16162 RVA: 0x000D7A13 File Offset: 0x000D5C13
		public short Ttl
		{
			get
			{
				return this.m_ClientSocket.Ttl;
			}
			set
			{
				this.m_ClientSocket.Ttl = value;
			}
		}

		/// <summary>Возвращает или задает значение <see cref="T:System.Boolean" />, указывающее, разрешает ли объект <see cref="T:System.Net.Sockets.UdpClient" /> выполнение фрагментации датаграмм протокола IP.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Net.Sockets.UdpClient" /> разрешает фрагментацию датаграмм; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Это свойство может быть установлено только для сокетов, которые используют флаг <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> или <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" />.</exception>
		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06003F23 RID: 16163 RVA: 0x000D7A21 File Offset: 0x000D5C21
		// (set) Token: 0x06003F24 RID: 16164 RVA: 0x000D7A2E File Offset: 0x000D5C2E
		public bool DontFragment
		{
			get
			{
				return this.m_ClientSocket.DontFragment;
			}
			set
			{
				this.m_ClientSocket.DontFragment = value;
			}
		}

		/// <summary>Получает или задает значение <see cref="T:System.Boolean" />, указывающее, могут ли доставляться исходящие пакеты многоадресной рассылки в передающем приложении.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Net.Sockets.UdpClient" /> получает исходящие пакеты многоадресной рассылки; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x06003F25 RID: 16165 RVA: 0x000D7A3C File Offset: 0x000D5C3C
		// (set) Token: 0x06003F26 RID: 16166 RVA: 0x000D7A49 File Offset: 0x000D5C49
		public bool MulticastLoopback
		{
			get
			{
				return this.m_ClientSocket.MulticastLoopback;
			}
			set
			{
				this.m_ClientSocket.MulticastLoopback = value;
			}
		}

		/// <summary>Получает или задает значение <see cref="T:System.Boolean" />, указывающее, может ли объект <see cref="T:System.Net.Sockets.UdpClient" /> производить отправку или прием широковещательных пакетов.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Net.Sockets.UdpClient" /> разрешает использование широковещательных пакетов; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06003F27 RID: 16167 RVA: 0x000D7A57 File Offset: 0x000D5C57
		// (set) Token: 0x06003F28 RID: 16168 RVA: 0x000D7A64 File Offset: 0x000D5C64
		public bool EnableBroadcast
		{
			get
			{
				return this.m_ClientSocket.EnableBroadcast;
			}
			set
			{
				this.m_ClientSocket.EnableBroadcast = value;
			}
		}

		/// <summary>Возвращает или задает значение <see cref="T:System.Boolean" />, указывающее, разрешает ли объект <see cref="T:System.Net.Sockets.UdpClient" /> использовать порт только одному клиенту.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Net.Sockets.UdpClient" /> разрешает только одному клиенту использовать конкретный порт; в противном случае — значение <see langword="false" />. По умолчанию используется значение <see langword="true" /> для Windows Server 2003 и Windows XP с пакетом обновления 2 (SP2) и более поздней версии; для всех остальных версий по умолчанию используется значение <see langword="false" />.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к основному сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Основной объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x06003F29 RID: 16169 RVA: 0x000D7A72 File Offset: 0x000D5C72
		// (set) Token: 0x06003F2A RID: 16170 RVA: 0x000D7A7F File Offset: 0x000D5C7F
		public bool ExclusiveAddressUse
		{
			get
			{
				return this.m_ClientSocket.ExclusiveAddressUse;
			}
			set
			{
				this.m_ClientSocket.ExclusiveAddressUse = value;
			}
		}

		/// <summary>Включает или отключает обход механизма преобразования сетевых адресов (NAT) для экземпляра <see cref="T:System.Net.Sockets.UdpClient" />.</summary>
		/// <param name="allowed">Логическое значение, указывающее, что надо включить или выключить обход NAT.</param>
		// Token: 0x06003F2B RID: 16171 RVA: 0x000D7A8D File Offset: 0x000D5C8D
		public void AllowNatTraversal(bool allowed)
		{
			if (allowed)
			{
				this.m_ClientSocket.SetIPProtectionLevel(IPProtectionLevel.Unrestricted);
				return;
			}
			this.m_ClientSocket.SetIPProtectionLevel(IPProtectionLevel.EdgeRestricted);
		}

		/// <summary>Закрывает UDP-подключение.</summary>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		// Token: 0x06003F2C RID: 16172 RVA: 0x000D7AAD File Offset: 0x000D5CAD
		public void Close()
		{
			this.Dispose(true);
		}

		// Token: 0x06003F2D RID: 16173 RVA: 0x000D7AB8 File Offset: 0x000D5CB8
		private void FreeResources()
		{
			if (this.m_CleanedUp)
			{
				return;
			}
			Socket client = this.Client;
			if (client != null)
			{
				client.InternalShutdown(SocketShutdown.Both);
				client.Close();
				this.Client = null;
			}
			this.m_CleanedUp = true;
		}

		/// <summary>Освобождает все управляемые и неуправляемые ресурсы, используемые <see cref="T:System.Net.Sockets.UdpClient" />.</summary>
		// Token: 0x06003F2E RID: 16174 RVA: 0x000D7AAD File Offset: 0x000D5CAD
		public void Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Net.Sockets.UdpClient" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06003F2F RID: 16175 RVA: 0x000D7AF3 File Offset: 0x000D5CF3
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.FreeResources();
				GC.SuppressFinalize(this);
			}
		}

		/// <summary>Устанавливает удаленный узел по умолчанию, используя заданное имя узла и номер порта.</summary>
		/// <param name="hostname">DNS-имя удаленного узла, на который предполагается передавать данные.</param>
		/// <param name="port">Имя порта удаленного узла, на который предполагается передавать данные.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.UdpClient" /> закрыт.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="port" /> не находится в диапазоне между значениями <see cref="F:System.Net.IPEndPoint.MinPort" /> и <see cref="F:System.Net.IPEndPoint.MaxPort" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		// Token: 0x06003F30 RID: 16176 RVA: 0x000D7B04 File Offset: 0x000D5D04
		public void Connect(string hostname, int port)
		{
			if (this.m_CleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (hostname == null)
			{
				throw new ArgumentNullException("hostname");
			}
			if (!ValidationHelper.ValidateTcpPort(port))
			{
				throw new ArgumentOutOfRangeException("port");
			}
			IPAddress[] hostAddresses = Dns.GetHostAddresses(hostname);
			Exception ex = null;
			Socket socket = null;
			Socket socket2 = null;
			try
			{
				if (this.m_ClientSocket == null)
				{
					if (Socket.OSSupportsIPv4)
					{
						socket2 = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
					}
					if (Socket.OSSupportsIPv6)
					{
						socket = new Socket(AddressFamily.InterNetworkV6, SocketType.Dgram, ProtocolType.Udp);
					}
				}
				foreach (IPAddress ipaddress in hostAddresses)
				{
					try
					{
						if (this.m_ClientSocket == null)
						{
							if (ipaddress.AddressFamily == AddressFamily.InterNetwork && socket2 != null)
							{
								socket2.Connect(ipaddress, port);
								this.m_ClientSocket = socket2;
								if (socket != null)
								{
									socket.Close();
								}
							}
							else if (socket != null)
							{
								socket.Connect(ipaddress, port);
								this.m_ClientSocket = socket;
								if (socket2 != null)
								{
									socket2.Close();
								}
							}
							this.m_Family = ipaddress.AddressFamily;
							this.m_Active = true;
							break;
						}
						if (ipaddress.AddressFamily == this.m_Family)
						{
							this.Connect(new IPEndPoint(ipaddress, port));
							this.m_Active = true;
							break;
						}
					}
					catch (Exception ex2)
					{
						if (NclUtilities.IsFatal(ex2))
						{
							throw;
						}
						ex = ex2;
					}
				}
			}
			catch (Exception ex3)
			{
				if (NclUtilities.IsFatal(ex3))
				{
					throw;
				}
				ex = ex3;
			}
			finally
			{
				if (!this.m_Active)
				{
					if (socket != null)
					{
						socket.Close();
					}
					if (socket2 != null)
					{
						socket2.Close();
					}
					if (ex != null)
					{
						throw ex;
					}
					throw new SocketException(SocketError.NotConnected);
				}
			}
		}

		/// <summary>Устанавливает удаленный узел по умолчанию, используя заданный IP-адрес и номер порта.</summary>
		/// <param name="addr">Объект <see cref="T:System.Net.IPAddress" /> удаленного узла, которому предполагается передавать данные.</param>
		/// <param name="port">Номер порта, на который предполагается передавать данные.</param>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.UdpClient" /> закрыт.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="addr" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="port" /> не находится в диапазоне между значениями <see cref="F:System.Net.IPEndPoint.MinPort" /> и <see cref="F:System.Net.IPEndPoint.MaxPort" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		// Token: 0x06003F31 RID: 16177 RVA: 0x000D7CA0 File Offset: 0x000D5EA0
		public void Connect(IPAddress addr, int port)
		{
			if (this.m_CleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (addr == null)
			{
				throw new ArgumentNullException("addr");
			}
			if (!ValidationHelper.ValidateTcpPort(port))
			{
				throw new ArgumentOutOfRangeException("port");
			}
			IPEndPoint endPoint = new IPEndPoint(addr, port);
			this.Connect(endPoint);
		}

		/// <summary>Устанавливает удаленный узел по умолчанию, используя заданную сетевую конечную точку.</summary>
		/// <param name="endPoint">Объект <see cref="T:System.Net.IPEndPoint" />, задающий сетевую конечную точку, которую предполагается использовать для передачи данных.</param>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="endPoint" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.UdpClient" /> закрыт.</exception>
		// Token: 0x06003F32 RID: 16178 RVA: 0x000D7CF8 File Offset: 0x000D5EF8
		public void Connect(IPEndPoint endPoint)
		{
			if (this.m_CleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (endPoint == null)
			{
				throw new ArgumentNullException("endPoint");
			}
			this.CheckForBroadcast(endPoint.Address);
			this.Client.Connect(endPoint);
			this.m_Active = true;
		}

		// Token: 0x06003F33 RID: 16179 RVA: 0x000D7D4B File Offset: 0x000D5F4B
		private void CheckForBroadcast(IPAddress ipAddress)
		{
			if (this.Client != null && !this.m_IsBroadcast && UdpClient.IsBroadcast(ipAddress))
			{
				this.m_IsBroadcast = true;
				this.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);
			}
		}

		// Token: 0x06003F34 RID: 16180 RVA: 0x000D7D7F File Offset: 0x000D5F7F
		private static bool IsBroadcast(IPAddress address)
		{
			return address.AddressFamily != AddressFamily.InterNetworkV6 && address.Equals(IPAddress.Broadcast);
		}

		/// <summary>Отправляет UDP-датаграмму в узел в указанной удаленной конечной точке.</summary>
		/// <param name="dgram">Массив типа <see cref="T:System.Byte" />, задающий UDP-датаграмму, которую предполагается послать в виде байтового массива.</param>
		/// <param name="bytes">Число байт в датаграмме.</param>
		/// <param name="endPoint">Объект <see cref="T:System.Net.IPEndPoint" />, предоставляющий узел и порт, на которые передается датаграмма.</param>
		/// <returns>Число отправленных байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="dgram" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для объекта <see cref="T:System.Net.Sockets.UdpClient" /> уже установлен удаленный узел, используемый по умолчанию.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.UdpClient" /> закрыт.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		// Token: 0x06003F35 RID: 16181 RVA: 0x000D7D98 File Offset: 0x000D5F98
		public int Send(byte[] dgram, int bytes, IPEndPoint endPoint)
		{
			if (this.m_CleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (dgram == null)
			{
				throw new ArgumentNullException("dgram");
			}
			if (this.m_Active && endPoint != null)
			{
				throw new InvalidOperationException(SR.GetString("Cannot send packets to an arbitrary host while connected."));
			}
			if (endPoint == null)
			{
				return this.Client.Send(dgram, 0, bytes, SocketFlags.None);
			}
			this.CheckForBroadcast(endPoint.Address);
			return this.Client.SendTo(dgram, 0, bytes, SocketFlags.None, endPoint);
		}

		/// <summary>Отправляет UDP-датаграмму на заданный порт указанного удаленного узла.</summary>
		/// <param name="dgram">Массив типа <see cref="T:System.Byte" />, задающий UDP-датаграмму, которую предполагается послать в виде байтового массива.</param>
		/// <param name="bytes">Число байт в датаграмме.</param>
		/// <param name="hostname">Имя удаленного узла, на который планируется отправить датаграмму.</param>
		/// <param name="port">Номер удаленного порта, с которым планируется обмен данных.</param>
		/// <returns>Число отправленных байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="dgram" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для объекта <see cref="T:System.Net.Sockets.UdpClient" /> уже установлен удаленный узел, используемый по умолчанию.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.UdpClient" /> закрыт.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		// Token: 0x06003F36 RID: 16182 RVA: 0x000D7E18 File Offset: 0x000D6018
		public int Send(byte[] dgram, int bytes, string hostname, int port)
		{
			if (this.m_CleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (dgram == null)
			{
				throw new ArgumentNullException("dgram");
			}
			if (this.m_Active && (hostname != null || port != 0))
			{
				throw new InvalidOperationException(SR.GetString("Cannot send packets to an arbitrary host while connected."));
			}
			if (hostname == null || port == 0)
			{
				return this.Client.Send(dgram, 0, bytes, SocketFlags.None);
			}
			IPAddress[] hostAddresses = Dns.GetHostAddresses(hostname);
			int num = 0;
			while (num < hostAddresses.Length && hostAddresses[num].AddressFamily != this.m_Family)
			{
				num++;
			}
			if (hostAddresses.Length == 0 || num == hostAddresses.Length)
			{
				throw new ArgumentException(SR.GetString("None of the discovered or specified addresses match the socket address family."), "hostname");
			}
			this.CheckForBroadcast(hostAddresses[num]);
			IPEndPoint remoteEP = new IPEndPoint(hostAddresses[num], port);
			return this.Client.SendTo(dgram, 0, bytes, SocketFlags.None, remoteEP);
		}

		/// <summary>Отправляет датаграмму UDP в удаленный узел.</summary>
		/// <param name="dgram">Массив типа <see cref="T:System.Byte" />, задающий UDP-датаграмму, которую предполагается послать в виде байтового массива.</param>
		/// <param name="bytes">Число байт в датаграмме.</param>
		/// <returns>Число отправленных байтов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="dgram" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для объекта <see cref="T:System.Net.Sockets.UdpClient" /> уже установлен удаленный узел, используемый по умолчанию.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.UdpClient" /> закрыт.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		// Token: 0x06003F37 RID: 16183 RVA: 0x000D7EEC File Offset: 0x000D60EC
		public int Send(byte[] dgram, int bytes)
		{
			if (this.m_CleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (dgram == null)
			{
				throw new ArgumentNullException("dgram");
			}
			if (!this.m_Active)
			{
				throw new InvalidOperationException(SR.GetString("The operation is not allowed on non-connected sockets."));
			}
			return this.Client.Send(dgram, 0, bytes, SocketFlags.None);
		}

		/// <summary>Отправляет датаграмму в пункт назначения в асинхронном режиме. Пункт назначения задается объектом <see cref="T:System.Net.EndPoint" />.</summary>
		/// <param name="datagram">Массив <see cref="T:System.Byte" />, содержащий отправляемые данные.</param>
		/// <param name="bytes">Количество байтов для отправки.</param>
		/// <param name="endPoint">Объект <see cref="T:System.Net.EndPoint" />, представляющий пункт назначения для данных.</param>
		/// <param name="requestCallback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, вызываемый по завершении данной операции.</param>
		/// <param name="state">Пользовательский объект, содержащий информацию об операции отправки. Этот объект передается делегату <paramref name="requestCallback" /> по завершении операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронную отправку.</returns>
		// Token: 0x06003F38 RID: 16184 RVA: 0x000D7F48 File Offset: 0x000D6148
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public IAsyncResult BeginSend(byte[] datagram, int bytes, IPEndPoint endPoint, AsyncCallback requestCallback, object state)
		{
			if (this.m_CleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (datagram == null)
			{
				throw new ArgumentNullException("datagram");
			}
			if (bytes > datagram.Length || bytes < 0)
			{
				throw new ArgumentOutOfRangeException("bytes");
			}
			if (this.m_Active && endPoint != null)
			{
				throw new InvalidOperationException(SR.GetString("Cannot send packets to an arbitrary host while connected."));
			}
			if (endPoint == null)
			{
				return this.Client.BeginSend(datagram, 0, bytes, SocketFlags.None, requestCallback, state);
			}
			this.CheckForBroadcast(endPoint.Address);
			return this.Client.BeginSendTo(datagram, 0, bytes, SocketFlags.None, endPoint, requestCallback, state);
		}

		/// <summary>Отправляет датаграмму в пункт назначения в асинхронном режиме. Пункт назначения задается именем узла и номером порта.</summary>
		/// <param name="datagram">Массив <see cref="T:System.Byte" />, содержащий отправляемые данные.</param>
		/// <param name="bytes">Количество байтов для отправки.</param>
		/// <param name="hostname">узел назначения.</param>
		/// <param name="port">Номер порта узла назначения.</param>
		/// <param name="requestCallback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, вызываемый по завершении данной операции.</param>
		/// <param name="state">Пользовательский объект, содержащий информацию об операции отправки. Этот объект передается делегату <paramref name="requestCallback" /> по завершении операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронную отправку.</returns>
		// Token: 0x06003F39 RID: 16185 RVA: 0x000D7FE4 File Offset: 0x000D61E4
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public IAsyncResult BeginSend(byte[] datagram, int bytes, string hostname, int port, AsyncCallback requestCallback, object state)
		{
			if (this.m_Active && (hostname != null || port != 0))
			{
				throw new InvalidOperationException(SR.GetString("Cannot send packets to an arbitrary host while connected."));
			}
			IPEndPoint endPoint = null;
			if (hostname != null && port != 0)
			{
				IPAddress[] hostAddresses = Dns.GetHostAddresses(hostname);
				int num = 0;
				while (num < hostAddresses.Length && hostAddresses[num].AddressFamily != this.m_Family)
				{
					num++;
				}
				if (hostAddresses.Length == 0 || num == hostAddresses.Length)
				{
					throw new ArgumentException(SR.GetString("None of the discovered or specified addresses match the socket address family."), "hostname");
				}
				this.CheckForBroadcast(hostAddresses[num]);
				endPoint = new IPEndPoint(hostAddresses[num], port);
			}
			return this.BeginSend(datagram, bytes, endPoint, requestCallback, state);
		}

		/// <summary>Отправляет датаграмму на удаленный узел в асинхронном режиме. Пункт назначения был задан заранее путем обращения к объекту <see cref="Overload:System.Net.Sockets.UdpClient.Connect" />.</summary>
		/// <param name="datagram">Массив <see cref="T:System.Byte" />, содержащий отправляемые данные.</param>
		/// <param name="bytes">Количество байтов для отправки.</param>
		/// <param name="requestCallback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, вызываемый по завершении данной операции.</param>
		/// <param name="state">Пользовательский объект, содержащий информацию об операции отправки. Этот объект передается делегату <paramref name="requestCallback" /> по завершении операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронную отправку.</returns>
		// Token: 0x06003F3A RID: 16186 RVA: 0x000D807E File Offset: 0x000D627E
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public IAsyncResult BeginSend(byte[] datagram, int bytes, AsyncCallback requestCallback, object state)
		{
			return this.BeginSend(datagram, bytes, null, requestCallback, state);
		}

		/// <summary>Завершает отложенную операцию асинхронной передачи.</summary>
		/// <param name="asyncResult">Объект <see cref="T:System.IAsyncResult" />, возвращаемый при вызове объекта <see cref="Overload:System.Net.Sockets.UdpClient.BeginSend" />.</param>
		/// <returns>Количество отправленных объекту <see cref="T:System.Net.Sockets.UdpClient" /> байтов, если операция успешно выполнена.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asyncResult" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="asyncResult" /> не был возвращен вызовом метода <see cref="M:System.Net.Sockets.Socket.BeginSend(System.Byte[],System.Int32,System.Int32,System.Net.Sockets.SocketFlags,System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Net.Sockets.Socket.EndSend(System.IAsyncResult)" /> был ранее вызван для асинхронного чтения.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к основному сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Основной объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		// Token: 0x06003F3B RID: 16187 RVA: 0x000D808C File Offset: 0x000D628C
		public int EndSend(IAsyncResult asyncResult)
		{
			if (this.m_CleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (this.m_Active)
			{
				return this.Client.EndSend(asyncResult);
			}
			return this.Client.EndSendTo(asyncResult);
		}

		/// <summary>Возвращает UDP-датаграмму, которая была послана на удаленный узел.</summary>
		/// <param name="remoteEP">Объект <see cref="T:System.Net.IPEndPoint" />, представляющий удаленный узел, с которого выполняется передача данных.</param>
		/// <returns>Массив типа <see cref="T:System.Byte" />, который содержит данные датаграммы.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Основной объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		// Token: 0x06003F3C RID: 16188 RVA: 0x000D80C8 File Offset: 0x000D62C8
		public byte[] Receive(ref IPEndPoint remoteEP)
		{
			if (this.m_CleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			EndPoint endPoint;
			if (this.m_Family == AddressFamily.InterNetwork)
			{
				endPoint = IPEndPoint.Any;
			}
			else
			{
				endPoint = IPEndPoint.IPv6Any;
			}
			int num = this.Client.ReceiveFrom(this.m_Buffer, 65536, SocketFlags.None, ref endPoint);
			remoteEP = (IPEndPoint)endPoint;
			if (num < 65536)
			{
				byte[] array = new byte[num];
				Buffer.BlockCopy(this.m_Buffer, 0, array, 0, num);
				return array;
			}
			return this.m_Buffer;
		}

		/// <summary>Принимает датаграмму с удаленного узла в асинхронном режиме.</summary>
		/// <param name="requestCallback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, вызываемый по завершении данной операции.</param>
		/// <param name="state">Пользовательский объект, содержащий информацию об операции приема. Этот объект передается делегату <paramref name="requestCallback" /> по завершении операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронный прием.</returns>
		// Token: 0x06003F3D RID: 16189 RVA: 0x000D8150 File Offset: 0x000D6350
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public IAsyncResult BeginReceive(AsyncCallback requestCallback, object state)
		{
			if (this.m_CleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			EndPoint endPoint;
			if (this.m_Family == AddressFamily.InterNetwork)
			{
				endPoint = IPEndPoint.Any;
			}
			else
			{
				endPoint = IPEndPoint.IPv6Any;
			}
			return this.Client.BeginReceiveFrom(this.m_Buffer, 0, 65536, SocketFlags.None, ref endPoint, requestCallback, state);
		}

		/// <summary>Завершает отложенный асинхронный прием.</summary>
		/// <param name="asyncResult">Объект <see cref="T:System.IAsyncResult" />, возвращаемый при вызове объекта <see cref="M:System.Net.Sockets.UdpClient.BeginReceive(System.AsyncCallback,System.Object)" />.</param>
		/// <param name="remoteEP">Заданная удаленная конечная точка.</param>
		/// <returns>В случае успешного выполнения массив байтов, который содержит данные датаграммы.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asyncResult" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="asyncResult" /> не был возвращен вызовом метода <see cref="M:System.Net.Sockets.UdpClient.BeginReceive(System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Net.Sockets.UdpClient.EndReceive(System.IAsyncResult,System.Net.IPEndPoint@)" /> был ранее вызван для асинхронного чтения.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к основному объекту <see cref="T:System.Net.Sockets.Socket" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Основной объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		// Token: 0x06003F3E RID: 16190 RVA: 0x000D81AC File Offset: 0x000D63AC
		public byte[] EndReceive(IAsyncResult asyncResult, ref IPEndPoint remoteEP)
		{
			if (this.m_CleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			EndPoint endPoint;
			if (this.m_Family == AddressFamily.InterNetwork)
			{
				endPoint = IPEndPoint.Any;
			}
			else
			{
				endPoint = IPEndPoint.IPv6Any;
			}
			int num = this.Client.EndReceiveFrom(asyncResult, ref endPoint);
			remoteEP = (IPEndPoint)endPoint;
			if (num < 65536)
			{
				byte[] array = new byte[num];
				Buffer.BlockCopy(this.m_Buffer, 0, array, 0, num);
				return array;
			}
			return this.m_Buffer;
		}

		/// <summary>Добавляет объект <see cref="T:System.Net.Sockets.UdpClient" /> в группу многоадресной рассылки.</summary>
		/// <param name="multicastAddr">Групповой адрес <see cref="T:System.Net.IPAddress" /> для группы, к которой производится присоединение.</param>
		/// <exception cref="T:System.ObjectDisposedException">Основной объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		/// <exception cref="T:System.ArgumentException">IP-адрес несовместим со значением <see cref="T:System.Net.Sockets.AddressFamily" />, которое определяет схему адресации сокета.</exception>
		// Token: 0x06003F3F RID: 16191 RVA: 0x000D8228 File Offset: 0x000D6428
		public void JoinMulticastGroup(IPAddress multicastAddr)
		{
			if (this.m_CleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (multicastAddr == null)
			{
				throw new ArgumentNullException("multicastAddr");
			}
			if (multicastAddr.AddressFamily != this.m_Family)
			{
				throw new ArgumentException(SR.GetString("Multicast family is not the same as the family of the '{0}' Client.", new object[]
				{
					"UDP"
				}), "multicastAddr");
			}
			if (this.m_Family == AddressFamily.InterNetwork)
			{
				MulticastOption optionValue = new MulticastOption(multicastAddr);
				this.Client.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, optionValue);
				return;
			}
			IPv6MulticastOption optionValue2 = new IPv6MulticastOption(multicastAddr);
			this.Client.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.AddMembership, optionValue2);
		}

		/// <summary>Добавляет объект <see cref="T:System.Net.Sockets.UdpClient" /> в группу многоадресной рассылки.</summary>
		/// <param name="multicastAddr">Групповой адрес <see cref="T:System.Net.IPAddress" /> для группы, к которой производится присоединение.</param>
		/// <param name="localAddress">Локальный адрес <see cref="T:System.Net.IPAddress" />.</param>
		/// <exception cref="T:System.ObjectDisposedException">Основной объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		// Token: 0x06003F40 RID: 16192 RVA: 0x000D82C4 File Offset: 0x000D64C4
		public void JoinMulticastGroup(IPAddress multicastAddr, IPAddress localAddress)
		{
			if (this.m_CleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (this.m_Family != AddressFamily.InterNetwork)
			{
				throw new SocketException(SocketError.OperationNotSupported);
			}
			MulticastOption optionValue = new MulticastOption(multicastAddr, localAddress);
			this.Client.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, optionValue);
		}

		/// <summary>Добавляет объект <see cref="T:System.Net.Sockets.UdpClient" /> в группу многоадресной рассылки.</summary>
		/// <param name="ifindex">Индекс интерфейса, связанный с локальным IP-адресом, по которому требуется присоединиться к группе многоадресной рассылки.</param>
		/// <param name="multicastAddr">Групповой адрес <see cref="T:System.Net.IPAddress" /> для группы, к которой производится присоединение.</param>
		/// <exception cref="T:System.ObjectDisposedException">Основной объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		// Token: 0x06003F41 RID: 16193 RVA: 0x000D8318 File Offset: 0x000D6518
		public void JoinMulticastGroup(int ifindex, IPAddress multicastAddr)
		{
			if (this.m_CleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (multicastAddr == null)
			{
				throw new ArgumentNullException("multicastAddr");
			}
			if (ifindex < 0)
			{
				throw new ArgumentException(SR.GetString("The specified value cannot be negative."), "ifindex");
			}
			if (this.m_Family != AddressFamily.InterNetworkV6)
			{
				throw new SocketException(SocketError.OperationNotSupported);
			}
			IPv6MulticastOption optionValue = new IPv6MulticastOption(multicastAddr, (long)ifindex);
			this.Client.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.AddMembership, optionValue);
		}

		/// <summary>Добавьте в группу многоадресной рассылки объект <see cref="T:System.Net.Sockets.UdpClient" /> с заданным параметром времени существования TTL (Time to Live).</summary>
		/// <param name="multicastAddr">Объект <see cref="T:System.Net.IPAddress" />, присоединяемый к группе многоадресной рассылки.</param>
		/// <param name="timeToLive">Параметр TTL (Time to Live), измеряемый в количестве переходов между марштутизаторами.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Указанное значение параметра TTL не находится в диапазоне от 0 до 255.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Основной объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="multicastAddr" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">IP-адрес несовместим со значением <see cref="T:System.Net.Sockets.AddressFamily" />, которое определяет схему адресации сокета.</exception>
		// Token: 0x06003F42 RID: 16194 RVA: 0x000D8394 File Offset: 0x000D6594
		public void JoinMulticastGroup(IPAddress multicastAddr, int timeToLive)
		{
			if (this.m_CleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (multicastAddr == null)
			{
				throw new ArgumentNullException("multicastAddr");
			}
			if (!ValidationHelper.ValidateRange(timeToLive, 0, 255))
			{
				throw new ArgumentOutOfRangeException("timeToLive");
			}
			this.JoinMulticastGroup(multicastAddr);
			this.Client.SetSocketOption((this.m_Family == AddressFamily.InterNetwork) ? SocketOptionLevel.IP : SocketOptionLevel.IPv6, SocketOptionName.MulticastTimeToLive, timeToLive);
		}

		/// <summary>Покидает группу многоадресной рассылки.</summary>
		/// <param name="multicastAddr">Удаляемый объект <see cref="T:System.Net.IPAddress" /> группы многоадресной рассылки.</param>
		/// <exception cref="T:System.ObjectDisposedException">Основной объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		/// <exception cref="T:System.ArgumentException">IP-адрес несовместим со значением <see cref="T:System.Net.Sockets.AddressFamily" />, которое определяет схему адресации сокета.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="multicastAddr" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003F43 RID: 16195 RVA: 0x000D8404 File Offset: 0x000D6604
		public void DropMulticastGroup(IPAddress multicastAddr)
		{
			if (this.m_CleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (multicastAddr == null)
			{
				throw new ArgumentNullException("multicastAddr");
			}
			if (multicastAddr.AddressFamily != this.m_Family)
			{
				throw new ArgumentException(SR.GetString("Multicast family is not the same as the family of the '{0}' Client.", new object[]
				{
					"UDP"
				}), "multicastAddr");
			}
			if (this.m_Family == AddressFamily.InterNetwork)
			{
				MulticastOption optionValue = new MulticastOption(multicastAddr);
				this.Client.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.DropMembership, optionValue);
				return;
			}
			IPv6MulticastOption optionValue2 = new IPv6MulticastOption(multicastAddr);
			this.Client.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.DropMembership, optionValue2);
		}

		/// <summary>Покидает группу многоадресной рассылки.</summary>
		/// <param name="multicastAddr">Удаляемый объект <see cref="T:System.Net.IPAddress" /> группы многоадресной рассылки.</param>
		/// <param name="ifindex">Локальный адрес удаляемой группы многоадресной рассылки.</param>
		/// <exception cref="T:System.ObjectDisposedException">Основной объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		/// <exception cref="T:System.ArgumentException">IP-адрес несовместим со значением <see cref="T:System.Net.Sockets.AddressFamily" />, которое определяет схему адресации сокета.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="multicastAddr" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003F44 RID: 16196 RVA: 0x000D84A0 File Offset: 0x000D66A0
		public void DropMulticastGroup(IPAddress multicastAddr, int ifindex)
		{
			if (this.m_CleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (multicastAddr == null)
			{
				throw new ArgumentNullException("multicastAddr");
			}
			if (ifindex < 0)
			{
				throw new ArgumentException(SR.GetString("The specified value cannot be negative."), "ifindex");
			}
			if (this.m_Family != AddressFamily.InterNetworkV6)
			{
				throw new SocketException(SocketError.OperationNotSupported);
			}
			IPv6MulticastOption optionValue = new IPv6MulticastOption(multicastAddr, (long)ifindex);
			this.Client.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.DropMembership, optionValue);
		}

		/// <summary>Асинхронно отправляет датаграмму UPD на удаленный узел.</summary>
		/// <param name="datagram">Массив типа <see cref="T:System.Byte" />, задающий UDP-датаграмму, которую предполагается послать в виде байтового массива.</param>
		/// <param name="bytes">Число байт в датаграмме.</param>
		/// <returns>Возвращает <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="dgram" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для объекта <see cref="T:System.Net.Sockets.UdpClient" /> уже установлен удаленный узел, используемый по умолчанию.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.UdpClient" /> закрыт.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		// Token: 0x06003F45 RID: 16197 RVA: 0x000D851B File Offset: 0x000D671B
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public Task<int> SendAsync(byte[] datagram, int bytes)
		{
			return Task<int>.Factory.FromAsync<byte[], int>(new Func<byte[], int, AsyncCallback, object, IAsyncResult>(this.BeginSend), new Func<IAsyncResult, int>(this.EndSend), datagram, bytes, null);
		}

		/// <summary>Асинхронно отправляет датаграмму UPD на удаленный узел.</summary>
		/// <param name="datagram">Массив типа <see cref="T:System.Byte" />, задающий UDP-датаграмму, которую предполагается послать в виде байтового массива.</param>
		/// <param name="bytes">Число байт в датаграмме.</param>
		/// <param name="endPoint">Объект <see cref="T:System.Net.IPEndPoint" />, предоставляющий узел и порт, на которые передается датаграмма.</param>
		/// <returns>Возвращает <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="dgram" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для объекта <see cref="T:System.Net.Sockets.UdpClient" /> уже установлен удаленный узел, используемый по умолчанию.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.UdpClient" /> закрыт.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		// Token: 0x06003F46 RID: 16198 RVA: 0x000D8542 File Offset: 0x000D6742
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public Task<int> SendAsync(byte[] datagram, int bytes, IPEndPoint endPoint)
		{
			return Task<int>.Factory.FromAsync<byte[], int, IPEndPoint>(new Func<byte[], int, IPEndPoint, AsyncCallback, object, IAsyncResult>(this.BeginSend), new Func<IAsyncResult, int>(this.EndSend), datagram, bytes, endPoint, null);
		}

		/// <summary>Асинхронно отправляет датаграмму UPD на удаленный узел.</summary>
		/// <param name="datagram">Массив типа <see cref="T:System.Byte" />, задающий UDP-датаграмму, которую предполагается послать в виде байтового массива.</param>
		/// <param name="bytes">Число байт в датаграмме.</param>
		/// <param name="hostname">Имя удаленного узла, на который планируется отправить датаграмму.</param>
		/// <param name="port">Номер удаленного порта, с которым планируется обмен данных.</param>
		/// <returns>Возвращает <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="dgram" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для объекта <see cref="T:System.Net.Sockets.UdpClient" /> уже установлен удаленный узел, используемый по умолчанию.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.UdpClient" /> закрыт.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		// Token: 0x06003F47 RID: 16199 RVA: 0x000D856C File Offset: 0x000D676C
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public Task<int> SendAsync(byte[] datagram, int bytes, string hostname, int port)
		{
			return Task<int>.Factory.FromAsync((AsyncCallback callback, object state) => this.BeginSend(datagram, bytes, hostname, port, callback, state), new Func<IAsyncResult, int>(this.EndSend), null);
		}

		/// <summary>Асинхронно возвращает UDP-датаграмму, которая была послана на удаленный узел.</summary>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Основной объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		// Token: 0x06003F48 RID: 16200 RVA: 0x000D85C6 File Offset: 0x000D67C6
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public Task<UdpReceiveResult> ReceiveAsync()
		{
			return Task<UdpReceiveResult>.Factory.FromAsync((AsyncCallback callback, object state) => this.BeginReceive(callback, state), delegate(IAsyncResult ar)
			{
				IPEndPoint remoteEndPoint = null;
				return new UdpReceiveResult(this.EndReceive(ar, ref remoteEndPoint), remoteEndPoint);
			}, null);
		}

		// Token: 0x06003F49 RID: 16201 RVA: 0x000D85EB File Offset: 0x000D67EB
		private void createClientSocket()
		{
			this.Client = new Socket(this.m_Family, SocketType.Dgram, ProtocolType.Udp);
		}

		// Token: 0x040025C6 RID: 9670
		private const int MaxUDPSize = 65536;

		// Token: 0x040025C7 RID: 9671
		private Socket m_ClientSocket;

		// Token: 0x040025C8 RID: 9672
		private bool m_Active;

		// Token: 0x040025C9 RID: 9673
		private byte[] m_Buffer;

		// Token: 0x040025CA RID: 9674
		private AddressFamily m_Family;

		// Token: 0x040025CB RID: 9675
		private bool m_CleanedUp;

		// Token: 0x040025CC RID: 9676
		private bool m_IsBroadcast;
	}
}
