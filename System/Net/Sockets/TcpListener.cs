using System;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace System.Net.Sockets
{
	/// <summary>Прослушивает подключения от TCP-клиентов сети.</summary>
	// Token: 0x020007BB RID: 1979
	public class TcpListener
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.TcpListener" /> с заданной локальной конечной точкой.</summary>
		/// <param name="localEP">Объект <see cref="T:System.Net.IPEndPoint" />, представляющий локальную конечную точка, назначенную для связывания со слушателем <see cref="T:System.Net.Sockets.Socket" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="localEP" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003F00 RID: 16128 RVA: 0x000D7374 File Offset: 0x000D5574
		public TcpListener(IPEndPoint localEP)
		{
			bool on = Logging.On;
			if (localEP == null)
			{
				throw new ArgumentNullException("localEP");
			}
			this.m_ServerSocketEP = localEP;
			this.m_ServerSocket = new Socket(this.m_ServerSocketEP.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
			bool on2 = Logging.On;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.TcpListener" />, который выполняет ожидание входящих попыток подключения для заданных локального IP-адреса и номера локального порта.</summary>
		/// <param name="localaddr">Объект <see cref="T:System.Net.IPAddress" />, представляющий локальный IP-адрес.</param>
		/// <param name="port">Порт, на котором производится ожидание входящих попыток подключений.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="localaddr" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="port" /> не находится в диапазоне между значениями <see cref="F:System.Net.IPEndPoint.MinPort" /> и <see cref="F:System.Net.IPEndPoint.MaxPort" />.</exception>
		// Token: 0x06003F01 RID: 16129 RVA: 0x000D73C0 File Offset: 0x000D55C0
		public TcpListener(IPAddress localaddr, int port)
		{
			bool on = Logging.On;
			if (localaddr == null)
			{
				throw new ArgumentNullException("localaddr");
			}
			if (!ValidationHelper.ValidateTcpPort(port))
			{
				throw new ArgumentOutOfRangeException("port");
			}
			this.m_ServerSocketEP = new IPEndPoint(localaddr, port);
			this.m_ServerSocket = new Socket(this.m_ServerSocketEP.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
			bool on2 = Logging.On;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Sockets.TcpListener" />, который ожидает передачу данных для указанного порта.</summary>
		/// <param name="port">Порт, на котором производится ожидание входящих попыток подключений.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="port" /> не находится в диапазоне между значениями <see cref="F:System.Net.IPEndPoint.MinPort" /> и <see cref="F:System.Net.IPEndPoint.MaxPort" />.</exception>
		// Token: 0x06003F02 RID: 16130 RVA: 0x000D7428 File Offset: 0x000D5628
		[Obsolete("This method has been deprecated. Please use TcpListener(IPAddress localaddr, int port) instead. http://go.microsoft.com/fwlink/?linkid=14202")]
		public TcpListener(int port)
		{
			if (!ValidationHelper.ValidateTcpPort(port))
			{
				throw new ArgumentOutOfRangeException("port");
			}
			this.m_ServerSocketEP = new IPEndPoint(IPAddress.Any, port);
			this.m_ServerSocket = new Socket(this.m_ServerSocketEP.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
		}

		/// <summary>Создает Новый экземпляр <see cref="T:System.Net.Sockets.TcpListener" />, который должен прослушивать на определенном порту.</summary>
		/// <param name="port">Порт, на котором производится ожидание входящих попыток подключений.</param>
		/// <returns>Новый экземпляр <see cref="T:System.Net.Sockets.TcpListener" />, который должен прослушивать на определенном порту.</returns>
		// Token: 0x06003F03 RID: 16131 RVA: 0x000D7477 File Offset: 0x000D5677
		public static TcpListener Create(int port)
		{
			bool on = Logging.On;
			if (!ValidationHelper.ValidateTcpPort(port))
			{
				throw new ArgumentOutOfRangeException("port");
			}
			TcpListener tcpListener = new TcpListener(IPAddress.IPv6Any, port);
			tcpListener.Server.DualMode = true;
			bool on2 = Logging.On;
			return tcpListener;
		}

		/// <summary>Получает основной сетевой объект <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <returns>Базовый объект <see cref="T:System.Net.Sockets.Socket" />.</returns>
		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x06003F04 RID: 16132 RVA: 0x000D74AF File Offset: 0x000D56AF
		public Socket Server
		{
			get
			{
				return this.m_ServerSocket;
			}
		}

		/// <summary>Получает значение, указывающее, является ли активным объект <see cref="T:System.Net.Sockets.TcpListener" />, выполняющий прослушивание клиентских подключений.</summary>
		/// <returns>Значение <see langword="true" />, если прослушивающий объект <see cref="T:System.Net.Sockets.TcpListener" /> активен; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x06003F05 RID: 16133 RVA: 0x000D74B7 File Offset: 0x000D56B7
		protected bool Active
		{
			get
			{
				return this.m_Active;
			}
		}

		/// <summary>Получает основной объект <see cref="T:System.Net.EndPoint" /> для текущего объекта <see cref="T:System.Net.Sockets.TcpListener" />.</summary>
		/// <returns>Объект <see cref="T:System.Net.EndPoint" />, с которым связан объект <see cref="T:System.Net.Sockets.Socket" />.</returns>
		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x06003F06 RID: 16134 RVA: 0x000D74BF File Offset: 0x000D56BF
		public EndPoint LocalEndpoint
		{
			get
			{
				if (!this.m_Active)
				{
					return this.m_ServerSocketEP;
				}
				return this.m_ServerSocket.LocalEndPoint;
			}
		}

		/// <summary>Возвращает или задает значение <see cref="T:System.Boolean" />, указывающее, позволяет ли объект <see cref="T:System.Net.Sockets.TcpListener" /> осуществлять ожидание передачи данных только на одном основном сокете на указанном порту.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Net.Sockets.TcpListener" /> разрешает осуществлять ожидание передачи данных только на одном объекте <see cref="T:System.Net.Sockets.TcpListener" /> на указанном порту; в противном случае — значение <see langword="false" />. . По умолчанию используется значение <see langword="true" /> для Windows Server 2003 и Windows XP с пакетом обновления 2 (SP2) и более поздней версии; для всех остальных версий по умолчанию используется значение <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Объект <see cref="T:System.Net.Sockets.TcpListener" /> запущен. Вызовите метод <see cref="M:System.Net.Sockets.TcpListener.Stop" />, а затем задайте свойство <see cref="P:System.Net.Sockets.Socket.ExclusiveAddressUse" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к основному сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Основной объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x06003F07 RID: 16135 RVA: 0x000D74DB File Offset: 0x000D56DB
		// (set) Token: 0x06003F08 RID: 16136 RVA: 0x000D74E8 File Offset: 0x000D56E8
		public bool ExclusiveAddressUse
		{
			get
			{
				return this.m_ServerSocket.ExclusiveAddressUse;
			}
			set
			{
				if (this.m_Active)
				{
					throw new InvalidOperationException(SR.GetString("The TcpListener must not be listening before performing this operation."));
				}
				this.m_ServerSocket.ExclusiveAddressUse = value;
				this.m_ExclusiveAddressUse = value;
			}
		}

		/// <summary>Включает или отключает обход механизма преобразования сетевых адресов (NAT) для экземпляра <see cref="T:System.Net.Sockets.TcpListener" />.</summary>
		/// <param name="allowed">Логическое значение, указывающее, что надо включить или выключить обход NAT.</param>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Net.Sockets.TcpListener.AllowNatTraversal(System.Boolean)" /> был вызван после метода <see cref="M:System.Net.Sockets.TcpListener.Start" />.</exception>
		// Token: 0x06003F09 RID: 16137 RVA: 0x000D7515 File Offset: 0x000D5715
		public void AllowNatTraversal(bool allowed)
		{
			if (this.m_Active)
			{
				throw new InvalidOperationException(SR.GetString("The TcpListener must not be listening before performing this operation."));
			}
			if (allowed)
			{
				this.m_ServerSocket.SetIPProtectionLevel(IPProtectionLevel.Unrestricted);
				return;
			}
			this.m_ServerSocket.SetIPProtectionLevel(IPProtectionLevel.EdgeRestricted);
		}

		/// <summary>Запускает ожидание входящих запросов на подключение.</summary>
		/// <exception cref="T:System.Net.Sockets.SocketException">Для получения кода ошибки можно воспользоваться свойством <see cref="P:System.Net.Sockets.SocketException.ErrorCode" />. Получив этот код, можно обратиться за подробным описанием ошибки к документации Коды ошибок API для сокетов Windows версии 2.</exception>
		// Token: 0x06003F0A RID: 16138 RVA: 0x000D754D File Offset: 0x000D574D
		public void Start()
		{
			this.Start(int.MaxValue);
		}

		/// <summary>Запускает ожидание входящих запросов на подключение с максимальным числом ожидающих подключений.</summary>
		/// <param name="backlog">Максимальная длина очереди ожидающих подключений.</param>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при получении доступа к сокету.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="backlog" /> меньше нуля или превышает максимальное число разрешенных подключений.</exception>
		/// <exception cref="T:System.InvalidOperationException">Основной объект <see cref="T:System.Net.Sockets.Socket" /> имеет значение null.</exception>
		// Token: 0x06003F0B RID: 16139 RVA: 0x000D755C File Offset: 0x000D575C
		public void Start(int backlog)
		{
			if (backlog > 2147483647 || backlog < 0)
			{
				throw new ArgumentOutOfRangeException("backlog");
			}
			bool on = Logging.On;
			if (this.m_ServerSocket == null)
			{
				throw new InvalidOperationException(SR.GetString("The socket handle is not valid."));
			}
			if (this.m_Active)
			{
				bool on2 = Logging.On;
				return;
			}
			this.m_ServerSocket.Bind(this.m_ServerSocketEP);
			try
			{
				this.m_ServerSocket.Listen(backlog);
			}
			catch (SocketException)
			{
				this.Stop();
				throw;
			}
			this.m_Active = true;
			bool on3 = Logging.On;
		}

		/// <summary>Закрывает слушатель.</summary>
		/// <exception cref="T:System.Net.Sockets.SocketException">Для получения кода ошибки можно воспользоваться свойством <see cref="P:System.Net.Sockets.SocketException.ErrorCode" />. Получив этот код, можно обратиться за подробным описанием ошибки к документации Коды ошибок API для сокетов Windows версии 2.</exception>
		// Token: 0x06003F0C RID: 16140 RVA: 0x000D75F4 File Offset: 0x000D57F4
		public void Stop()
		{
			bool on = Logging.On;
			if (this.m_ServerSocket != null)
			{
				this.m_ServerSocket.Close();
				this.m_ServerSocket = null;
			}
			this.m_Active = false;
			this.m_ServerSocket = new Socket(this.m_ServerSocketEP.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
			if (this.m_ExclusiveAddressUse)
			{
				this.m_ServerSocket.ExclusiveAddressUse = true;
			}
			bool on2 = Logging.On;
		}

		/// <summary>Определяет, имеются ли ожидающие запросы на подключение.</summary>
		/// <returns>Значение <see langword="true" />, если имеются ожидающие подключения; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Слушатель не запущен с помощью вызова метода <see cref="M:System.Net.Sockets.TcpListener.Start" />.</exception>
		// Token: 0x06003F0D RID: 16141 RVA: 0x000D765A File Offset: 0x000D585A
		public bool Pending()
		{
			if (!this.m_Active)
			{
				throw new InvalidOperationException(SR.GetString("Not listening. You must call the Start() method before calling this method."));
			}
			return this.m_ServerSocket.Poll(0, SelectMode.SelectRead);
		}

		/// <summary>Принимает ожидающий запрос на подключение.</summary>
		/// <returns>Объект <see cref="T:System.Net.Sockets.Socket" />, используемый для приема и передачи данных.</returns>
		/// <exception cref="T:System.InvalidOperationException">Слушатель не запущен с помощью вызова метода <see cref="M:System.Net.Sockets.TcpListener.Start" />.</exception>
		// Token: 0x06003F0E RID: 16142 RVA: 0x000D7681 File Offset: 0x000D5881
		public Socket AcceptSocket()
		{
			bool on = Logging.On;
			if (!this.m_Active)
			{
				throw new InvalidOperationException(SR.GetString("Not listening. You must call the Start() method before calling this method."));
			}
			Socket result = this.m_ServerSocket.Accept();
			bool on2 = Logging.On;
			return result;
		}

		/// <summary>Принимает ожидающий запрос на подключение.</summary>
		/// <returns>Объект <see cref="T:System.Net.Sockets.TcpClient" />, используемый для приема и передачи данных.</returns>
		/// <exception cref="T:System.InvalidOperationException">Слушатель не запущен с помощью вызова метода <see cref="M:System.Net.Sockets.TcpListener.Start" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Для получения кода ошибки можно воспользоваться свойством <see cref="P:System.Net.Sockets.SocketException.ErrorCode" />. Получив этот код, можно обратиться за подробным описанием ошибки к документации Коды ошибок API для сокетов Windows версии 2.</exception>
		// Token: 0x06003F0F RID: 16143 RVA: 0x000D76B2 File Offset: 0x000D58B2
		public TcpClient AcceptTcpClient()
		{
			bool on = Logging.On;
			if (!this.m_Active)
			{
				throw new InvalidOperationException(SR.GetString("Not listening. You must call the Start() method before calling this method."));
			}
			TcpClient result = new TcpClient(this.m_ServerSocket.Accept());
			bool on2 = Logging.On;
			return result;
		}

		/// <summary>Начинает асинхронную операцию, чтобы принять попытку входящего подключения.</summary>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, вызываемый по завершении данной операции.</param>
		/// <param name="state">Пользовательский объект, содержащий информацию о данной операции принятия запроса на подключения. Этот объект передается делегату <paramref name="callback" /> по завершении операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронное создание объекта <see cref="T:System.Net.Sockets.Socket" />.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003F10 RID: 16144 RVA: 0x000D76E8 File Offset: 0x000D58E8
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public IAsyncResult BeginAcceptSocket(AsyncCallback callback, object state)
		{
			bool on = Logging.On;
			if (!this.m_Active)
			{
				throw new InvalidOperationException(SR.GetString("Not listening. You must call the Start() method before calling this method."));
			}
			IAsyncResult result = this.m_ServerSocket.BeginAccept(callback, state);
			bool on2 = Logging.On;
			return result;
		}

		/// <summary>Асинхронно принимает входящие попытки подключения и создает новый объект <see cref="T:System.Net.Sockets.Socket" /> для связи с удаленным узлом.</summary>
		/// <param name="asyncResult">Объект <see cref="T:System.IAsyncResult" /> возвращен посредством вызова метода <see cref="M:System.Net.Sockets.TcpListener.BeginAcceptSocket(System.AsyncCallback,System.Object)" />.</param>
		/// <returns>Объект <see cref="T:System.Net.Sockets.Socket" />.  
		/// Объект <see cref="T:System.Net.Sockets.Socket" />, используемый для приема и передачи данных.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Основной объект <see cref="T:System.Net.Sockets.Socket" /> закрыт.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="asyncResult" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="asyncResult" /> не было создано при вызове метода <see cref="M:System.Net.Sockets.TcpListener.BeginAcceptSocket(System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Был ранее вызван метод <see cref="M:System.Net.Sockets.TcpListener.EndAcceptSocket(System.IAsyncResult)" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к объекту <see cref="T:System.Net.Sockets.Socket" />.</exception>
		// Token: 0x06003F11 RID: 16145 RVA: 0x000D771C File Offset: 0x000D591C
		public Socket EndAcceptSocket(IAsyncResult asyncResult)
		{
			bool on = Logging.On;
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			SocketAsyncResult socketAsyncResult = asyncResult as SocketAsyncResult;
			object obj = (socketAsyncResult == null) ? null : socketAsyncResult.socket;
			if (obj == null)
			{
				throw new ArgumentException(SR.GetString("The IAsyncResult object was not returned from the corresponding asynchronous method on this class."), "asyncResult");
			}
			Socket result = obj.EndAccept(asyncResult);
			bool on2 = Logging.On;
			return result;
		}

		/// <summary>Начинает асинхронную операцию, чтобы принять попытку входящего подключения.</summary>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, вызываемый по завершении данной операции.</param>
		/// <param name="state">Пользовательский объект, содержащий информацию о данной операции принятия запроса на подключения. Этот объект передается делегату <paramref name="callback" /> по завершении операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который ссылается на асинхронное создание объекта <see cref="T:System.Net.Sockets.TcpClient" />.</returns>
		/// <exception cref="T:System.Net.Sockets.SocketException">Произошла ошибка при попытке доступа к сокету.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Net.Sockets.Socket" /> был закрыт.</exception>
		// Token: 0x06003F12 RID: 16146 RVA: 0x000D76E8 File Offset: 0x000D58E8
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public IAsyncResult BeginAcceptTcpClient(AsyncCallback callback, object state)
		{
			bool on = Logging.On;
			if (!this.m_Active)
			{
				throw new InvalidOperationException(SR.GetString("Not listening. You must call the Start() method before calling this method."));
			}
			IAsyncResult result = this.m_ServerSocket.BeginAccept(callback, state);
			bool on2 = Logging.On;
			return result;
		}

		/// <summary>Асинхронно принимает входящие попытки подключения и создает новый объект <see cref="T:System.Net.Sockets.TcpClient" /> для связи с удаленным узлом.</summary>
		/// <param name="asyncResult">Объект <see cref="T:System.IAsyncResult" /> возвращен посредством вызова метода <see cref="M:System.Net.Sockets.TcpListener.BeginAcceptTcpClient(System.AsyncCallback,System.Object)" />.</param>
		/// <returns>Объект <see cref="T:System.Net.Sockets.TcpClient" />.  
		/// Объект <see cref="T:System.Net.Sockets.TcpClient" />, используемый для приема и передачи данных.</returns>
		// Token: 0x06003F13 RID: 16147 RVA: 0x000D7774 File Offset: 0x000D5974
		public TcpClient EndAcceptTcpClient(IAsyncResult asyncResult)
		{
			bool on = Logging.On;
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			SocketAsyncResult socketAsyncResult = asyncResult as SocketAsyncResult;
			object obj = (socketAsyncResult == null) ? null : socketAsyncResult.socket;
			if (obj == null)
			{
				throw new ArgumentException(SR.GetString("The IAsyncResult object was not returned from the corresponding asynchronous method on this class."), "asyncResult");
			}
			Socket acceptedSocket = obj.EndAccept(asyncResult);
			bool on2 = Logging.On;
			return new TcpClient(acceptedSocket);
		}

		/// <summary>Принимает запрос ожидающего подключения как асинхронную операцию.</summary>
		/// <returns>Объект задачи, представляющий асинхронную операцию. Свойство <see cref="P:System.Threading.Tasks.Task`1.Result" /> в объекте задачи возвращает <see cref="T:System.Net.Sockets.Socket" />, используемый для отправки и получения данных.</returns>
		/// <exception cref="T:System.InvalidOperationException">Слушатель не запущен с помощью вызова метода <see cref="M:System.Net.Sockets.TcpListener.Start" />.</exception>
		// Token: 0x06003F14 RID: 16148 RVA: 0x000D77D1 File Offset: 0x000D59D1
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public Task<Socket> AcceptSocketAsync()
		{
			return Task<Socket>.Factory.FromAsync(new Func<AsyncCallback, object, IAsyncResult>(this.BeginAcceptSocket), new Func<IAsyncResult, Socket>(this.EndAcceptSocket), null);
		}

		/// <summary>Принимает запрос ожидающего подключения как асинхронную операцию.</summary>
		/// <returns>Объект задачи, представляющий асинхронную операцию. Свойство <see cref="P:System.Threading.Tasks.Task`1.Result" /> в объекте задачи возвращает <see cref="T:System.Net.Sockets.TcpClient" />, используемый для отправки и получения данных.</returns>
		/// <exception cref="T:System.InvalidOperationException">Слушатель не запущен с помощью вызова метода <see cref="M:System.Net.Sockets.TcpListener.Start" />.</exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">Для получения кода ошибки можно воспользоваться свойством <see cref="P:System.Net.Sockets.SocketException.ErrorCode" />. Получив этот код, можно обратиться за подробным описанием ошибки к документации Коды ошибок API для сокетов Windows версии 2.</exception>
		// Token: 0x06003F15 RID: 16149 RVA: 0x000D77F6 File Offset: 0x000D59F6
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public Task<TcpClient> AcceptTcpClientAsync()
		{
			return Task<TcpClient>.Factory.FromAsync(new Func<AsyncCallback, object, IAsyncResult>(this.BeginAcceptTcpClient), new Func<IAsyncResult, TcpClient>(this.EndAcceptTcpClient), null);
		}

		// Token: 0x040025BB RID: 9659
		private IPEndPoint m_ServerSocketEP;

		// Token: 0x040025BC RID: 9660
		private Socket m_ServerSocket;

		// Token: 0x040025BD RID: 9661
		private bool m_Active;

		// Token: 0x040025BE RID: 9662
		private bool m_ExclusiveAddressUse;
	}
}
