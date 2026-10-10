using System;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Sockets
{
	/// <summary>Предоставляет клиентские подключения для сетевых служб протокола TCP.</summary>
	// Token: 0x020007BA RID: 1978
	public class TcpClient : IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.TcpClient" /> и связывает его с заданной локальной конечной точкой.</summary>
		/// <param name="localEP">Объект <see cref="T:System.Net.IPEndPoint" />, с которым связан объект <see cref="T:System.Net.Sockets.Socket" />, работающий по протоколу TCP.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="localEP" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003ED5 RID: 16085 RVA: 0x000D6B50 File Offset: 0x000D4D50
		public TcpClient(IPEndPoint localEP)
		{
			bool on = Logging.On;
			if (localEP == null)
			{
				throw new ArgumentNullException("localEP");
			}
			this.m_Family = localEP.AddressFamily;
			this.initialize();
			this.Client.Bind(localEP);
			bool on2 = Logging.On;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.TcpClient" />.</summary>
		// Token: 0x06003ED6 RID: 16086 RVA: 0x000D6BA2 File Offset: 0x000D4DA2
		public TcpClient() : this(AddressFamily.InterNetwork)
		{
			bool on = Logging.On;
			bool on2 = Logging.On;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.TcpClient" /> с заданным семейством.</summary>
		/// <param name="family">Параметр <see cref="P:System.Net.IPAddress.AddressFamily" /> протокола IP.</param>
		/// <exception cref="T:System.ArgumentException">Значением параметра <paramref name="family" /> не является AddressFamily.InterNetwork 
		/// -или- 
		/// Значением параметра <paramref name="family" /> не является AddressFamily.InterNetworkV6</exception>
		// Token: 0x06003ED7 RID: 16087 RVA: 0x000D6BB8 File Offset: 0x000D4DB8
		public TcpClient(AddressFamily family)
		{
			bool on = Logging.On;
			if (family != AddressFamily.InterNetwork && family != AddressFamily.InterNetworkV6)
			{
				throw new ArgumentException(SR.GetString("'{0}' Client can only accept InterNetwork or InterNetworkV6 addresses.", new object[]
				{
					"TCP"
				}), "family");
			}
			this.m_Family = family;
			this.initialize();
			bool on2 = Logging.On;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.TcpClient" /> и подключает его к указанному порту заданного узла.</summary>
		/// <param name="hostname">DNS-имя удаленного узла, к которому планируется подключение.</param>
		/// <param name="port">Имя порта удаленного узла, к которому планируется подключение.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="hostname" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="port" /> не находится между <see cref="F:System.Net.IPEndPoint.MinPort" /> и <see cref="F:System.Net.IPEndPoint.MaxPort" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		// Token: 0x06003ED8 RID: 16088 RVA: 0x000D6C18 File Offset: 0x000D4E18
		public TcpClient(string hostname, int port)
		{
			bool on = Logging.On;
			if (hostname == null)
			{
				throw new ArgumentNullException("hostname");
			}
			if (!ValidationHelper.ValidateTcpPort(port))
			{
				throw new ArgumentOutOfRangeException("port");
			}
			try
			{
				this.Connect(hostname, port);
			}
			catch (Exception ex)
			{
				if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
				{
					throw;
				}
				if (this.m_ClientSocket != null)
				{
					this.m_ClientSocket.Close();
				}
				throw ex;
			}
			bool on2 = Logging.On;
		}

		// Token: 0x06003ED9 RID: 16089 RVA: 0x000D6CAC File Offset: 0x000D4EAC
		internal TcpClient(Socket acceptedSocket)
		{
			bool on = Logging.On;
			this.Client = acceptedSocket;
			this.m_Active = true;
			bool on2 = Logging.On;
		}

		/// <summary>Возвращает или задает базовый объект <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <returns>Базовый сетевой объект <see cref="T:System.Net.Sockets.Socket" />.</returns>
		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06003EDA RID: 16090 RVA: 0x000D6CD5 File Offset: 0x000D4ED5
		// (set) Token: 0x06003EDB RID: 16091 RVA: 0x000D6CDD File Offset: 0x000D4EDD
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

		/// <summary>Получает или задает значение, указывающее, установлено ли подключение.</summary>
		/// <returns>Значение <see langword="true" />, если подключение установлено; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x06003EDC RID: 16092 RVA: 0x000D6CE6 File Offset: 0x000D4EE6
		// (set) Token: 0x06003EDD RID: 16093 RVA: 0x000D6CEE File Offset: 0x000D4EEE
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
		/// <returns>Количество байтов данных, полученных из сети и доступных для чтения.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x06003EDE RID: 16094 RVA: 0x000D6CF7 File Offset: 0x000D4EF7
		public int Available
		{
			get
			{
				return this.m_ClientSocket.Available;
			}
		}

		/// <summary>Возвращает значение, указывающее, подключен ли основной объект <see cref="T:System.Net.Sockets.Socket" /> для объекта <see cref="T:System.Net.Sockets.TcpClient" /> к удаленному узлу.</summary>
		/// <returns>Значение <see langword="true" />, если сокет <see cref="P:System.Net.Sockets.TcpClient.Client" /> был подключен к удаленному узлу в результате последней операции; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x06003EDF RID: 16095 RVA: 0x000D6D04 File Offset: 0x000D4F04
		public bool Connected
		{
			get
			{
				return this.m_ClientSocket.Connected;
			}
		}

		/// <summary>Возвращает или задает значение <see cref="T:System.Boolean" />, указывающее, разрешает ли объект <see cref="T:System.Net.Sockets.TcpClient" /> использовать порт только одному клиенту.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Net.Sockets.TcpClient" /> разрешает только одному клиенту использовать конкретный порт; в противном случае — значение <see langword="false" />. По умолчанию используется значение <see langword="true" /> для Windows Server 2003 и Windows XP с пакетом обновления 2 (SP2) и более поздней версии; для всех остальных версий по умолчанию используется значение <see langword="false" />.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к основному сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Основной объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06003EE0 RID: 16096 RVA: 0x000D6D11 File Offset: 0x000D4F11
		// (set) Token: 0x06003EE1 RID: 16097 RVA: 0x000D6D1E File Offset: 0x000D4F1E
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

		/// <summary>Подключает клиента к указанному порту заданного узла.</summary>
		/// <param name="hostname">DNS-имя удаленного узла, к которому планируется подключение.</param>
		/// <param name="port">Имя порта удаленного узла, к которому планируется подключение.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="hostname" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="port" /> не находится между <see cref="F:System.Net.IPEndPoint.MinPort" /> и <see cref="F:System.Net.IPEndPoint.MaxPort" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.TcpClient" /> закрыт.</exception>
		// Token: 0x06003EE2 RID: 16098 RVA: 0x000D6D2C File Offset: 0x000D4F2C
		public void Connect(string hostname, int port)
		{
			bool on = Logging.On;
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
			if (this.m_Active)
			{
				throw new SocketException(SocketError.IsConnected);
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
						socket2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
					}
					if (Socket.OSSupportsIPv6)
					{
						socket = new Socket(AddressFamily.InterNetworkV6, SocketType.Stream, ProtocolType.Tcp);
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
						if (ex2 is ThreadAbortException || ex2 is StackOverflowException || ex2 is OutOfMemoryException)
						{
							throw;
						}
						ex = ex2;
					}
				}
			}
			catch (Exception ex3)
			{
				if (ex3 is ThreadAbortException || ex3 is StackOverflowException || ex3 is OutOfMemoryException)
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
			bool on2 = Logging.On;
		}

		/// <summary>Подключает клиента к удаленному TCP-узлу, используя указанный IP-адрес и номер порта.</summary>
		/// <param name="address">Объект <see cref="T:System.Net.IPAddress" /> узла, к которому выполняется подключение.</param>
		/// <param name="port">Номер порта, к которому выполняется подключение.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="address" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="port" /> имеет значение, не лежащее в диапазоне между <see cref="F:System.Net.IPEndPoint.MinPort" /> и <see cref="F:System.Net.IPEndPoint.MaxPort" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.TcpClient" /> закрыт.</exception>
		// Token: 0x06003EE3 RID: 16099 RVA: 0x000D6F38 File Offset: 0x000D5138
		public void Connect(IPAddress address, int port)
		{
			bool on = Logging.On;
			if (this.m_CleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			if (!ValidationHelper.ValidateTcpPort(port))
			{
				throw new ArgumentOutOfRangeException("port");
			}
			IPEndPoint remoteEP = new IPEndPoint(address, port);
			this.Connect(remoteEP);
			bool on2 = Logging.On;
		}

		/// <summary>Подключает клиента к удаленному TCP-узлу, используя указанную удаленную сетевую конечную точку.</summary>
		/// <param name="remoteEP">Объект <see cref="T:System.Net.IPEndPoint" />, к которому выполняется подключение.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="remoteEp" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Net.Sockets.TcpClient" /> закрыт.</exception>
		// Token: 0x06003EE4 RID: 16100 RVA: 0x000D6F9C File Offset: 0x000D519C
		public void Connect(IPEndPoint remoteEP)
		{
			bool on = Logging.On;
			if (this.m_CleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (remoteEP == null)
			{
				throw new ArgumentNullException("remoteEP");
			}
			this.Client.Connect(remoteEP);
			this.m_Active = true;
			bool on2 = Logging.On;
		}

		/// <summary>Подключает клиента к удаленному TCP-узлу, используя указанный IP-адрес и номер порта.</summary>
		/// <param name="ipAddresses">Массив <see cref="T:System.Net.IPAddress" /> узла, к которому выполняется подключение.</param>
		/// <param name="port">Номер порта, к которому выполняется подключение.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="ipAddresses" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Недействительный номер порта.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий объект, находящийся выше в стеке вызовов, не имеет разрешения на запрошенную операцию.</exception>
		/// <exception cref="T:System.NotSupportedException">Этот метод может быть применен только для сокетов, которые используют флаг <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> или <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" />.</exception>
		// Token: 0x06003EE5 RID: 16101 RVA: 0x000D6FEF File Offset: 0x000D51EF
		public void Connect(IPAddress[] ipAddresses, int port)
		{
			bool on = Logging.On;
			this.Client.Connect(ipAddresses, port);
			this.m_Active = true;
			bool on2 = Logging.On;
		}

		/// <summary>Начинает выполнение асинхронного запроса для подключения к удаленному узлу. Удаленный узел задается именем узла (<see cref="T:System.String" />) и номером порта (<see cref="T:System.Int32" />).</summary>
		/// <param name="host">Имя удаленного узла.</param>
		/// <param name="port">Номер порта удаленного узла.</param>
		/// <param name="requestCallback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, вызываемый по завершении данной операции.</param>
		/// <param name="state">Пользовательский объект, содержащий информацию об операции подключения. Этот объект передается делегату <paramref name="requestCallback" /> по завершении операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронное подключение.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="host" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий объект, находящийся выше в стеке вызовов, не имеет разрешения на запрошенную операцию.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Недействительный номер порта.</exception>
		// Token: 0x06003EE6 RID: 16102 RVA: 0x000D7011 File Offset: 0x000D5211
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state)
		{
			bool on = Logging.On;
			IAsyncResult result = this.Client.BeginConnect(host, port, requestCallback, state);
			bool on2 = Logging.On;
			return result;
		}

		/// <summary>Начинает выполнение асинхронного запроса для подключения к удаленному узлу. Удаленный узел задается объектом <see cref="T:System.Net.IPAddress" /> и номером порта (<see cref="T:System.Int32" />).</summary>
		/// <param name="address">Адрес <see cref="T:System.Net.IPAddress" /> удаленного узла.</param>
		/// <param name="port">Номер порта удаленного узла.</param>
		/// <param name="requestCallback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, вызываемый по завершении данной операции.</param>
		/// <param name="state">Пользовательский объект, содержащий информацию об операции подключения. Этот объект передается делегату <paramref name="requestCallback" /> по завершении операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронное подключение.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="address" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий объект, находящийся выше в стеке вызовов, не имеет разрешения на запрошенную операцию.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Недействительный номер порта.</exception>
		// Token: 0x06003EE7 RID: 16103 RVA: 0x000D702F File Offset: 0x000D522F
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public IAsyncResult BeginConnect(IPAddress address, int port, AsyncCallback requestCallback, object state)
		{
			bool on = Logging.On;
			IAsyncResult result = this.Client.BeginConnect(address, port, requestCallback, state);
			bool on2 = Logging.On;
			return result;
		}

		/// <summary>Начинает выполнение асинхронного запроса для подключения к удаленному узлу. Удаленный узел задается массивом <see cref="T:System.Net.IPAddress" /> и номером порта (<see cref="T:System.Int32" />).</summary>
		/// <param name="addresses">По крайней мере один объект <see cref="T:System.Net.IPAddress" />, определяющий удаленные узлы.</param>
		/// <param name="port">Номер порта удаленных узлов.</param>
		/// <param name="requestCallback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, вызываемый по завершении данной операции.</param>
		/// <param name="state">Пользовательский объект, содержащий информацию об операции подключения. Этот объект передается делегату <paramref name="requestCallback" /> по завершении операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронное подключение.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="addresses" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий объект, находящийся выше в стеке вызовов, не имеет разрешения на запрошенную операцию.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Недействительный номер порта.</exception>
		// Token: 0x06003EE8 RID: 16104 RVA: 0x000D704D File Offset: 0x000D524D
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public IAsyncResult BeginConnect(IPAddress[] addresses, int port, AsyncCallback requestCallback, object state)
		{
			bool on = Logging.On;
			IAsyncResult result = this.Client.BeginConnect(addresses, port, requestCallback, state);
			bool on2 = Logging.On;
			return result;
		}

		/// <summary>Завершает ожидающую асинхронную попытку на подключение.</summary>
		/// <param name="asyncResult">Объект <see cref="T:System.IAsyncResult" />, возвращаемый при вызове объекта <see cref="Overload:System.Net.Sockets.TcpClient.BeginConnect" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="asyncResult" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="asyncResult" /> не было возвращено при вызове метода <see cref="Overload:System.Net.Sockets.TcpClient.BeginConnect" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Net.Sockets.TcpClient.EndConnect(System.IAsyncResult)" /> был ранее вызван для асинхронного подключения.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к объекту <see cref="T:System.Net.Sockets.Socket" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Основной объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		// Token: 0x06003EE9 RID: 16105 RVA: 0x000D706B File Offset: 0x000D526B
		public void EndConnect(IAsyncResult asyncResult)
		{
			bool on = Logging.On;
			this.Client.EndConnect(asyncResult);
			this.m_Active = true;
			bool on2 = Logging.On;
		}

		/// <summary>Подключает клиента к удаленному TCP-узлу, используя заданный IP-адрес и номер порта в асинхронной операции.</summary>
		/// <param name="address">Объект <see cref="T:System.Net.IPAddress" /> узла, к которому выполняется подключение.</param>
		/// <param name="port">Номер порта, к которому выполняется подключение.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="address" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="port" /> имеет значение, не лежащее в диапазоне между <see cref="F:System.Net.IPEndPoint.MinPort" /> и <see cref="F:System.Net.IPEndPoint.MaxPort" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.TcpClient" /> закрыт.</exception>
		// Token: 0x06003EEA RID: 16106 RVA: 0x000D708C File Offset: 0x000D528C
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public Task ConnectAsync(IPAddress address, int port)
		{
			return Task.Factory.FromAsync<IPAddress, int>(new Func<IPAddress, int, AsyncCallback, object, IAsyncResult>(this.BeginConnect), new Action<IAsyncResult>(this.EndConnect), address, port, null);
		}

		/// <summary>Подключает клиента к указанному TCP-порту заданного узла в асинхронной операции.</summary>
		/// <param name="host">DNS-имя удаленного узла, к которому планируется подключение.</param>
		/// <param name="port">Имя порта удаленного узла, к которому планируется подключение.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="hostname" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="port" /> не находится между <see cref="F:System.Net.IPEndPoint.MinPort" /> и <see cref="F:System.Net.IPEndPoint.MaxPort" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при обращении к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.TcpClient" /> закрыт.</exception>
		// Token: 0x06003EEB RID: 16107 RVA: 0x000D70B3 File Offset: 0x000D52B3
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public Task ConnectAsync(string host, int port)
		{
			return Task.Factory.FromAsync<string, int>(new Func<string, int, AsyncCallback, object, IAsyncResult>(this.BeginConnect), new Action<IAsyncResult>(this.EndConnect), host, port, null);
		}

		/// <summary>Подключает клиента к удаленному TCP-узлу, используя заданные IP-адреса и номер порта в асинхронной операции.</summary>
		/// <param name="addresses">Массив <see cref="T:System.Net.IPAddress" /> узла, к которому выполняется подключение.</param>
		/// <param name="port">Номер порта, к которому выполняется подключение.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="ipAddresses" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Недействительный номер порта.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий объект, находящийся выше в стеке вызовов, не имеет разрешения на запрошенную операцию.</exception>
		/// <exception cref="T:System.NotSupportedException">Этот метод может быть применен только для сокетов, которые используют флаг <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" /> или <see cref="F:System.Net.Sockets.AddressFamily.InterNetworkV6" />.</exception>
		// Token: 0x06003EEC RID: 16108 RVA: 0x000D70DA File Offset: 0x000D52DA
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public Task ConnectAsync(IPAddress[] addresses, int port)
		{
			return Task.Factory.FromAsync<IPAddress[], int>(new Func<IPAddress[], int, AsyncCallback, object, IAsyncResult>(this.BeginConnect), new Action<IAsyncResult>(this.EndConnect), addresses, port, null);
		}

		/// <summary>Возвращает объект <see cref="T:System.Net.Sockets.NetworkStream" />, используемый для отправки и получения данных.</summary>
		/// <returns>Базовый объект <see cref="T:System.Net.Sockets.NetworkStream" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Объект <see cref="T:System.Net.Sockets.TcpClient" /> не подключен к удаленному узлу.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.TcpClient" /> был закрыт.</exception>
		// Token: 0x06003EED RID: 16109 RVA: 0x000D7104 File Offset: 0x000D5304
		public NetworkStream GetStream()
		{
			bool on = Logging.On;
			if (this.m_CleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (!this.Client.Connected)
			{
				throw new InvalidOperationException(SR.GetString("The operation is not allowed on non-connected sockets."));
			}
			if (this.m_DataStream == null)
			{
				this.m_DataStream = new NetworkStream(this.Client, true);
			}
			bool on2 = Logging.On;
			return this.m_DataStream;
		}

		/// <summary>Удаляет данный экземпляр <see cref="T:System.Net.Sockets.TcpClient" /> и запрашивает закрытие базового подключения TCP.</summary>
		// Token: 0x06003EEE RID: 16110 RVA: 0x000D7173 File Offset: 0x000D5373
		public void Close()
		{
			bool on = Logging.On;
			((IDisposable)this).Dispose();
			bool on2 = Logging.On;
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Net.Sockets.TcpClient" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Задайте значение <see langword="true" /> для освобождения управляемых и неуправляемых ресурсов; значение <see langword="false" /> для освобождения только неуправляемых ресурсов.</param>
		// Token: 0x06003EEF RID: 16111 RVA: 0x000D7188 File Offset: 0x000D5388
		protected virtual void Dispose(bool disposing)
		{
			bool on = Logging.On;
			if (this.m_CleanedUp)
			{
				bool on2 = Logging.On;
				return;
			}
			if (disposing)
			{
				IDisposable dataStream = this.m_DataStream;
				if (dataStream != null)
				{
					dataStream.Dispose();
				}
				else
				{
					Socket client = this.Client;
					if (client != null)
					{
						try
						{
							client.InternalShutdown(SocketShutdown.Both);
						}
						finally
						{
							client.Close();
							this.Client = null;
						}
					}
				}
				GC.SuppressFinalize(this);
			}
			this.m_CleanedUp = true;
			bool on3 = Logging.On;
		}

		/// <summary>Освобождает все управляемые и неуправляемые ресурсы, используемые <see cref="T:System.Net.Sockets.TcpClient" />.</summary>
		// Token: 0x06003EF0 RID: 16112 RVA: 0x000D7204 File Offset: 0x000D5404
		public void Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>Освобождает ресурсы, используемые классом <see cref="T:System.Net.Sockets.TcpClient" />.</summary>
		// Token: 0x06003EF1 RID: 16113 RVA: 0x000D7210 File Offset: 0x000D5410
		~TcpClient()
		{
			this.Dispose(false);
		}

		/// <summary>Возвращает или задает размер буфера приема.</summary>
		/// <returns>Размер буфера приема (в байтах). Значение по умолчанию — 8192 байта.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при задании размера буфера.  
		/// -или- 
		/// В приложениях .NET Compact Framework это свойство задать нельзя. Обходные пути см. в примечании, относящемся к платформам, в разделе "Примечания".</exception>
		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06003EF2 RID: 16114 RVA: 0x000D7240 File Offset: 0x000D5440
		// (set) Token: 0x06003EF3 RID: 16115 RVA: 0x000D7252 File Offset: 0x000D5452
		public int ReceiveBufferSize
		{
			get
			{
				return this.numericOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveBuffer);
			}
			set
			{
				this.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveBuffer, value);
			}
		}

		/// <summary>Возвращает или задает размер буфера отправки.</summary>
		/// <returns>Размер буфера отправки (в байтах). Значение по умолчанию — 8192 байта.</returns>
		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06003EF4 RID: 16116 RVA: 0x000D726A File Offset: 0x000D546A
		// (set) Token: 0x06003EF5 RID: 16117 RVA: 0x000D727C File Offset: 0x000D547C
		public int SendBufferSize
		{
			get
			{
				return this.numericOption(SocketOptionLevel.Socket, SocketOptionName.SendBuffer);
			}
			set
			{
				this.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendBuffer, value);
			}
		}

		/// <summary>Возвращает или задает длительность временного интервала, в течение которого объект <see cref="T:System.Net.Sockets.TcpClient" /> будет ожидать получение данных после инициации операции чтения.</summary>
		/// <returns>Значение времени ожидания подключения в миллисекундах. Значение по умолчанию — 0.</returns>
		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06003EF6 RID: 16118 RVA: 0x000D7294 File Offset: 0x000D5494
		// (set) Token: 0x06003EF7 RID: 16119 RVA: 0x000D72A6 File Offset: 0x000D54A6
		public int ReceiveTimeout
		{
			get
			{
				return this.numericOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout);
			}
			set
			{
				this.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, value);
			}
		}

		/// <summary>Возвращает или задает длительность временного интервала, в течение которого объект <see cref="T:System.Net.Sockets.TcpClient" /> будет ожидать успешного завершения операции отправки данных.</summary>
		/// <returns>Значение времени ожидания отправки (в миллисекундах). Значение по умолчанию — 0.</returns>
		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06003EF8 RID: 16120 RVA: 0x000D72BE File Offset: 0x000D54BE
		// (set) Token: 0x06003EF9 RID: 16121 RVA: 0x000D72D0 File Offset: 0x000D54D0
		public int SendTimeout
		{
			get
			{
				return this.numericOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout);
			}
			set
			{
				this.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout, value);
			}
		}

		/// <summary>Возвращает или задает информацию о состоянии задержки связанного сокета.</summary>
		/// <returns>Объект <see cref="T:System.Net.Sockets.LingerOption" />. По умолчанию режим задержки отключен.</returns>
		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06003EFA RID: 16122 RVA: 0x000D72E8 File Offset: 0x000D54E8
		// (set) Token: 0x06003EFB RID: 16123 RVA: 0x000D7304 File Offset: 0x000D5504
		public LingerOption LingerState
		{
			get
			{
				return (LingerOption)this.Client.GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Linger);
			}
			set
			{
				this.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Linger, value);
			}
		}

		/// <summary>Возвращает или задает значение, которое отключает задержку в том случае, когда буферы отправки и получения не заполнены.</summary>
		/// <returns>
		///   <see langword="true" /> Если задержка отключена; в противном случае <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x06003EFC RID: 16124 RVA: 0x000D731C File Offset: 0x000D551C
		// (set) Token: 0x06003EFD RID: 16125 RVA: 0x000D732B File Offset: 0x000D552B
		public bool NoDelay
		{
			get
			{
				return this.numericOption(SocketOptionLevel.Tcp, SocketOptionName.Debug) != 0;
			}
			set
			{
				this.Client.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.Debug, value ? 1 : 0);
			}
		}

		// Token: 0x06003EFE RID: 16126 RVA: 0x000D7341 File Offset: 0x000D5541
		private void initialize()
		{
			this.Client = new Socket(this.m_Family, SocketType.Stream, ProtocolType.Tcp);
			this.m_Active = false;
		}

		// Token: 0x06003EFF RID: 16127 RVA: 0x000D735D File Offset: 0x000D555D
		private int numericOption(SocketOptionLevel optionLevel, SocketOptionName optionName)
		{
			return (int)this.Client.GetSocketOption(optionLevel, optionName);
		}

		// Token: 0x040025B6 RID: 9654
		private Socket m_ClientSocket;

		// Token: 0x040025B7 RID: 9655
		private bool m_Active;

		// Token: 0x040025B8 RID: 9656
		private NetworkStream m_DataStream;

		// Token: 0x040025B9 RID: 9657
		private AddressFamily m_Family = AddressFamily.InterNetwork;

		// Token: 0x040025BA RID: 9658
		private bool m_CleanedUp;
	}
}
