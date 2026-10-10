using System;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using Unity;

namespace System.Net
{
	/// <summary>Обеспечивает управление HTTP-подключениями.</summary>
	// Token: 0x020006AD RID: 1709
	public class ServicePoint
	{
		// Token: 0x060036B1 RID: 14001 RVA: 0x000BFF40 File Offset: 0x000BE140
		internal ServicePoint(ServicePointManager.SPKey key, Uri uri, int connectionLimit, int maxIdleTime)
		{
			this.sendContinue = true;
			this.hostE = new object();
			this.connectionLeaseTimeout = -1;
			this.receiveBufferSize = -1;
			base..ctor();
			this.Key = key;
			this.uri = uri;
			this.connectionLimit = connectionLimit;
			this.maxIdleTime = maxIdleTime;
			this.Scheduler = new ServicePointScheduler(this, connectionLimit, maxIdleTime);
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x060036B2 RID: 14002 RVA: 0x000BFF9F File Offset: 0x000BE19F
		internal ServicePointManager.SPKey Key { get; }

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x060036B3 RID: 14003 RVA: 0x000BFFA7 File Offset: 0x000BE1A7
		// (set) Token: 0x060036B4 RID: 14004 RVA: 0x000BFFAF File Offset: 0x000BE1AF
		private ServicePointScheduler Scheduler { get; set; }

		/// <summary>Возвращает универсальный код ресурса (URI) сервера, к которому подключается этот объект <see cref="T:System.Net.ServicePoint" />.</summary>
		/// <returns>Экземпляр класса <see cref="T:System.Uri" />, содержащий URI сервера в Интернете, к которому подключается этот объект <see cref="T:System.Net.ServicePoint" />.</returns>
		/// <exception cref="T:System.NotSupportedException">точка обслуживания <see cref="T:System.Net.ServicePoint" /> находится в режиме узла.</exception>
		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x060036B5 RID: 14005 RVA: 0x000BFFB8 File Offset: 0x000BE1B8
		public Uri Address
		{
			get
			{
				return this.uri;
			}
		}

		/// <summary>Указывает делегат, который следует использовать для связи локальной точки <see cref="T:System.Net.IPEndPoint" /> и точки обслуживания <see cref="T:System.Net.ServicePoint" />.</summary>
		/// <returns>Делегат, который приводит к использованию точкой обслуживания <see cref="T:System.Net.ServicePoint" /> определенного локального IP-адреса и номера порта. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x060036B6 RID: 14006 RVA: 0x000BFFC0 File Offset: 0x000BE1C0
		// (set) Token: 0x060036B7 RID: 14007 RVA: 0x000BFFC8 File Offset: 0x000BE1C8
		public BindIPEndPoint BindIPEndPointDelegate
		{
			get
			{
				return this.endPointCallback;
			}
			set
			{
				this.endPointCallback = value;
			}
		}

		/// <summary>Возвращает или задает количество миллисекунд, по истечении которого закрывается активное подключение <see cref="T:System.Net.ServicePoint" />.</summary>
		/// <returns>Объект <see cref="T:System.Int32" />, указывающий количество миллисекунд, в течение которого активное подключение <see cref="T:System.Net.ServicePoint" /> остается открытым. Значение по умолчанию равно -1, что позволяет активному подключению <see cref="T:System.Net.ServicePoint" /> оставаться открытым неограниченное количество времени. Установите это свойство равным 0, чтобы принудительно закрыть подключения <see cref="T:System.Net.ServicePoint" /> после обслуживания запроса.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение, указанное для операции задания, является отрицательным числом меньше -1.</exception>
		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x060036B8 RID: 14008 RVA: 0x000BFFD1 File Offset: 0x000BE1D1
		// (set) Token: 0x060036B9 RID: 14009 RVA: 0x000BFFD9 File Offset: 0x000BE1D9
		public int ConnectionLeaseTimeout
		{
			get
			{
				return this.connectionLeaseTimeout;
			}
			set
			{
				if (value < -1)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.connectionLeaseTimeout = value;
			}
		}

		/// <summary>Возвращает или задает максимальное число подключений, разрешенное для этого объекта <see cref="T:System.Net.ServicePoint" />.</summary>
		/// <returns>Максимальное число подключений, разрешенное для этого объекта <see cref="T:System.Net.ServicePoint" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Предел подключения равен 0 или меньше 0.</exception>
		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x060036BA RID: 14010 RVA: 0x000BFFF1 File Offset: 0x000BE1F1
		// (set) Token: 0x060036BB RID: 14011 RVA: 0x000BFFF9 File Offset: 0x000BE1F9
		public int ConnectionLimit
		{
			get
			{
				return this.connectionLimit;
			}
			set
			{
				this.connectionLimit = value;
				if (!this.disposed)
				{
					this.Scheduler.ConnectionLimit = value;
				}
			}
		}

		/// <summary>Возвращает имя подключения.</summary>
		/// <returns>Строка <see cref="T:System.String" />, представляющая имя подключения.</returns>
		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x060036BC RID: 14012 RVA: 0x000C0016 File Offset: 0x000BE216
		public string ConnectionName
		{
			get
			{
				return this.uri.Scheme;
			}
		}

		/// <summary>Возвращает число открытых подключений, связанных с данным объектом <see cref="T:System.Net.ServicePoint" />.</summary>
		/// <returns>Число открытых подключений, связанных с данным объектом <see cref="T:System.Net.ServicePoint" />.</returns>
		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x060036BD RID: 14013 RVA: 0x000C0023 File Offset: 0x000BE223
		public int CurrentConnections
		{
			get
			{
				if (!this.disposed)
				{
					return this.Scheduler.CurrentConnections;
				}
				return 0;
			}
		}

		/// <summary>Возвращает дату и время последнего подключения объекта <see cref="T:System.Net.ServicePoint" /> к узлу.</summary>
		/// <returns>Объект <see cref="T:System.DateTime" />, который содержит дату и время последнего подключения объекта <see cref="T:System.Net.ServicePoint" />.</returns>
		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x060036BE RID: 14014 RVA: 0x000C003C File Offset: 0x000BE23C
		public DateTime IdleSince
		{
			get
			{
				if (this.disposed)
				{
					return DateTime.MinValue;
				}
				return this.Scheduler.IdleSince.ToLocalTime();
			}
		}

		/// <summary>Возвращает или задает промежуток времени, в течение которого подключение, связанное с объектом <see cref="T:System.Net.ServicePoint" />, может находиться в состоянии простоя до своего закрытия.</summary>
		/// <returns>Временной промежуток в миллисекундах, в течение которого подключение, связанное с объектом <see cref="T:System.Net.ServicePoint" />, будет простаивать до его закрытия и повторного использования.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Устанавливаемое значение <see cref="P:System.Net.ServicePoint.MaxIdleTime" /> меньше <see cref="F:System.Threading.Timeout.Infinite" /> или больше <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x060036BF RID: 14015 RVA: 0x000C006A File Offset: 0x000BE26A
		// (set) Token: 0x060036C0 RID: 14016 RVA: 0x000C0072 File Offset: 0x000BE272
		public int MaxIdleTime
		{
			get
			{
				return this.maxIdleTime;
			}
			set
			{
				this.maxIdleTime = value;
				if (!this.disposed)
				{
					this.Scheduler.MaxIdleTime = value;
				}
			}
		}

		/// <summary>Возвращает версию протокола HTTP, используемую объектом <see cref="T:System.Net.ServicePoint" />.</summary>
		/// <returns>Объект <see cref="T:System.Version" />, содержащий версию протокола HTTP, используемую объектом <see cref="T:System.Net.ServicePoint" />.</returns>
		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x060036C1 RID: 14017 RVA: 0x000C008F File Offset: 0x000BE28F
		public virtual Version ProtocolVersion
		{
			get
			{
				return this.protocolVersion;
			}
		}

		/// <summary>Возвращает или задает размер приемного буфера для сокета, используемого этой точкой обслуживания <see cref="T:System.Net.ServicePoint" />.</summary>
		/// <returns>Объект <see cref="T:System.Int32" />, который содержит значение размера приемного буфера в байтах. Значение по умолчанию — 8192.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение, указанное для операции установки, больше <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x060036C2 RID: 14018 RVA: 0x000C0097 File Offset: 0x000BE297
		// (set) Token: 0x060036C3 RID: 14019 RVA: 0x000C009F File Offset: 0x000BE29F
		public int ReceiveBufferSize
		{
			get
			{
				return this.receiveBufferSize;
			}
			set
			{
				if (value < -1)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.receiveBufferSize = value;
			}
		}

		/// <summary>Указывает, поддерживает ли объект <see cref="T:System.Net.ServicePoint" /> конвейерные подключения.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Net.ServicePoint" /> поддерживает конвейерные подключения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x060036C4 RID: 14020 RVA: 0x000C00B7 File Offset: 0x000BE2B7
		public bool SupportsPipelining
		{
			get
			{
				return HttpVersion.Version11.Equals(this.protocolVersion);
			}
		}

		/// <summary>Возвращает или задает значение <see cref="T:System.Boolean" />, которое определяет, используется ли поведение 100-Continue.</summary>
		/// <returns>Значение <see langword="true" /> для ожидания ответов 100-Continue для запросов <see langword="POST" />; в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x060036C5 RID: 14021 RVA: 0x000C00C9 File Offset: 0x000BE2C9
		// (set) Token: 0x060036C6 RID: 14022 RVA: 0x000C00D1 File Offset: 0x000BE2D1
		public bool Expect100Continue
		{
			get
			{
				return this.SendContinue;
			}
			set
			{
				this.SendContinue = value;
			}
		}

		/// <summary>Возвращает или задает значение <see cref="T:System.Boolean" />, которое определяет, используется ли алгоритм Nagle для подключений, которые находятся под управлением этого объекта <see cref="T:System.Net.ServicePoint" />.</summary>
		/// <returns>Значение <see langword="true" /> для использования алгоритма Nagle; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x060036C7 RID: 14023 RVA: 0x000C00DA File Offset: 0x000BE2DA
		// (set) Token: 0x060036C8 RID: 14024 RVA: 0x000C00E2 File Offset: 0x000BE2E2
		public bool UseNagleAlgorithm
		{
			get
			{
				return this.useNagle;
			}
			set
			{
				this.useNagle = value;
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x060036C9 RID: 14025 RVA: 0x000C00EB File Offset: 0x000BE2EB
		// (set) Token: 0x060036CA RID: 14026 RVA: 0x000C0117 File Offset: 0x000BE317
		internal bool SendContinue
		{
			get
			{
				return this.sendContinue && (this.protocolVersion == null || this.protocolVersion == HttpVersion.Version11);
			}
			set
			{
				this.sendContinue = value;
			}
		}

		/// <summary>Включает или отключает параметр поддержания активности соединения TCP.</summary>
		/// <param name="enabled">Если этот параметр имеет значение true, параметр поддержания активности соединения TCP будет включен с помощью указанных значений <paramref name="keepAliveTime" /> и <paramref name="keepAliveInterval" />.  
		/// Если этот параметр имеет значение false, параметр поддержания активности TCP отключен, и остальные параметры игнорируются.  
		/// Значением по умолчанию является false.</param>
		/// <param name="keepAliveTime">Задает время ожидания в миллисекундах при отсутствии активности до отправки первого пакета поддержания активности.  
		/// Значение должно быть больше нуля.  При передаче значения, меньшего или равного нулю, возникает исключение <see cref="T:System.ArgumentOutOfRangeException" />.</param>
		/// <param name="keepAliveInterval">Задает интервал в миллисекундах между успешной отправкой пакетов поддержания активности в случае отсутствия подтверждения.  
		/// Значение должно быть больше нуля.  При передаче значения, меньшего или равного нулю, возникает исключение <see cref="T:System.ArgumentOutOfRangeException" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="keepAliveTime" /> или <paramref name="keepAliveInterval" /> меньше или равно 0.</exception>
		// Token: 0x060036CB RID: 14027 RVA: 0x000C0120 File Offset: 0x000BE320
		public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval)
		{
			if (enabled)
			{
				if (keepAliveTime <= 0)
				{
					throw new ArgumentOutOfRangeException("keepAliveTime", "Must be greater than 0");
				}
				if (keepAliveInterval <= 0)
				{
					throw new ArgumentOutOfRangeException("keepAliveInterval", "Must be greater than 0");
				}
			}
			this.tcp_keepalive = enabled;
			this.tcp_keepalive_time = keepAliveTime;
			this.tcp_keepalive_interval = keepAliveInterval;
		}

		// Token: 0x060036CC RID: 14028 RVA: 0x000C0170 File Offset: 0x000BE370
		internal void KeepAliveSetup(Socket socket)
		{
			if (!this.tcp_keepalive)
			{
				return;
			}
			byte[] array = new byte[12];
			ServicePoint.PutBytes(array, this.tcp_keepalive ? 1U : 0U, 0);
			ServicePoint.PutBytes(array, (uint)this.tcp_keepalive_time, 4);
			ServicePoint.PutBytes(array, (uint)this.tcp_keepalive_interval, 8);
			socket.IOControl((IOControlCode)((ulong)-1744830460), array, null);
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x000C01CC File Offset: 0x000BE3CC
		private static void PutBytes(byte[] bytes, uint v, int offset)
		{
			if (BitConverter.IsLittleEndian)
			{
				bytes[offset] = (byte)(v & 255U);
				bytes[offset + 1] = (byte)((v & 65280U) >> 8);
				bytes[offset + 2] = (byte)((v & 16711680U) >> 16);
				bytes[offset + 3] = (byte)((v & 4278190080U) >> 24);
				return;
			}
			bytes[offset + 3] = (byte)(v & 255U);
			bytes[offset + 2] = (byte)((v & 65280U) >> 8);
			bytes[offset + 1] = (byte)((v & 16711680U) >> 16);
			bytes[offset] = (byte)((v & 4278190080U) >> 24);
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x060036CE RID: 14030 RVA: 0x000C0255 File Offset: 0x000BE455
		// (set) Token: 0x060036CF RID: 14031 RVA: 0x000C025D File Offset: 0x000BE45D
		internal bool UsesProxy
		{
			get
			{
				return this.usesProxy;
			}
			set
			{
				this.usesProxy = value;
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x060036D0 RID: 14032 RVA: 0x000C0266 File Offset: 0x000BE466
		// (set) Token: 0x060036D1 RID: 14033 RVA: 0x000C026E File Offset: 0x000BE46E
		internal bool UseConnect
		{
			get
			{
				return this.useConnect;
			}
			set
			{
				this.useConnect = value;
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x060036D2 RID: 14034 RVA: 0x000C0278 File Offset: 0x000BE478
		private bool HasTimedOut
		{
			get
			{
				int dnsRefreshTimeout = ServicePointManager.DnsRefreshTimeout;
				return dnsRefreshTimeout != -1 && this.lastDnsResolve + TimeSpan.FromMilliseconds((double)dnsRefreshTimeout) < DateTime.UtcNow;
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x060036D3 RID: 14035 RVA: 0x000C02B0 File Offset: 0x000BE4B0
		internal IPHostEntry HostEntry
		{
			get
			{
				object obj = this.hostE;
				lock (obj)
				{
					string text = this.uri.Host;
					if (this.uri.HostNameType == UriHostNameType.IPv6 || this.uri.HostNameType == UriHostNameType.IPv4)
					{
						if (this.host != null)
						{
							return this.host;
						}
						if (this.uri.HostNameType == UriHostNameType.IPv6)
						{
							text = text.Substring(1, text.Length - 2);
						}
						this.host = new IPHostEntry();
						this.host.AddressList = new IPAddress[]
						{
							IPAddress.Parse(text)
						};
						return this.host;
					}
					else
					{
						if (!this.HasTimedOut && this.host != null)
						{
							return this.host;
						}
						this.lastDnsResolve = DateTime.UtcNow;
						try
						{
							this.host = Dns.GetHostEntry(text);
						}
						catch
						{
							return null;
						}
					}
				}
				return this.host;
			}
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x000C03BC File Offset: 0x000BE5BC
		internal void SetVersion(Version version)
		{
			this.protocolVersion = version;
		}

		// Token: 0x060036D5 RID: 14037 RVA: 0x000C03C8 File Offset: 0x000BE5C8
		internal void SendRequest(WebOperation operation, string groupName)
		{
			lock (this)
			{
				if (this.disposed)
				{
					throw new ObjectDisposedException(typeof(ServicePoint).FullName);
				}
				this.Scheduler.SendRequest(operation, groupName);
			}
		}

		/// <summary>Удаляет указанную группу подключений из этого объекта <see cref="T:System.Net.ServicePoint" />.</summary>
		/// <param name="connectionGroupName">Имя группы подключений, содержащей подключения, которые следует закрыть и удалить из этой точки обслуживания.</param>
		/// <returns>Значение <see cref="T:System.Boolean" />, которое указывает, была ли закрыта группа подключений.</returns>
		// Token: 0x060036D6 RID: 14038 RVA: 0x000C0428 File Offset: 0x000BE628
		public bool CloseConnectionGroup(string connectionGroupName)
		{
			bool result;
			lock (this)
			{
				if (this.disposed)
				{
					result = true;
				}
				else
				{
					result = this.Scheduler.CloseConnectionGroup(connectionGroupName);
				}
			}
			return result;
		}

		// Token: 0x060036D7 RID: 14039 RVA: 0x000C0478 File Offset: 0x000BE678
		internal void FreeServicePoint()
		{
			this.disposed = true;
			this.Scheduler = null;
		}

		/// <summary>Возвращает сертификат, полученный для данного объекта <see cref="T:System.Net.ServicePoint" />.</summary>
		/// <returns>Экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />, содержащий сертификат безопасности, полученный для данного объекта <see cref="T:System.Net.ServicePoint" />.</returns>
		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x060036D8 RID: 14040 RVA: 0x000C0488 File Offset: 0x000BE688
		public X509Certificate Certificate
		{
			get
			{
				object serverCertificateOrBytes = this.m_ServerCertificateOrBytes;
				if (serverCertificateOrBytes != null && serverCertificateOrBytes.GetType() == typeof(byte[]))
				{
					return (X509Certificate)(this.m_ServerCertificateOrBytes = new X509Certificate((byte[])serverCertificateOrBytes));
				}
				return serverCertificateOrBytes as X509Certificate;
			}
		}

		// Token: 0x060036D9 RID: 14041 RVA: 0x000C04D6 File Offset: 0x000BE6D6
		internal void UpdateServerCertificate(X509Certificate certificate)
		{
			if (certificate != null)
			{
				this.m_ServerCertificateOrBytes = certificate.GetRawCertData();
				return;
			}
			this.m_ServerCertificateOrBytes = null;
		}

		/// <summary>Возвращает последний сертификат клиента, отправленный на сервер.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />, содержащий открытые значения последнего сертификата клиента, отправленного на сервер.</returns>
		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x060036DA RID: 14042 RVA: 0x000C04F0 File Offset: 0x000BE6F0
		public X509Certificate ClientCertificate
		{
			get
			{
				object clientCertificateOrBytes = this.m_ClientCertificateOrBytes;
				if (clientCertificateOrBytes != null && clientCertificateOrBytes.GetType() == typeof(byte[]))
				{
					return (X509Certificate)(this.m_ClientCertificateOrBytes = new X509Certificate((byte[])clientCertificateOrBytes));
				}
				return clientCertificateOrBytes as X509Certificate;
			}
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x000C053E File Offset: 0x000BE73E
		internal void UpdateClientCertificate(X509Certificate certificate)
		{
			if (certificate != null)
			{
				this.m_ClientCertificateOrBytes = certificate.GetRawCertData();
				return;
			}
			this.m_ClientCertificateOrBytes = null;
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x000C0558 File Offset: 0x000BE758
		internal bool CallEndPointDelegate(Socket sock, IPEndPoint remote)
		{
			if (this.endPointCallback == null)
			{
				return true;
			}
			int num = 0;
			checked
			{
				for (;;)
				{
					IPEndPoint ipendPoint = null;
					try
					{
						ipendPoint = this.endPointCallback(this, remote, num);
					}
					catch
					{
						return false;
					}
					if (ipendPoint == null)
					{
						break;
					}
					try
					{
						sock.Bind(ipendPoint);
					}
					catch (SocketException)
					{
						num++;
						continue;
					}
					return true;
				}
				return true;
			}
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x00013BCA File Offset: 0x00011DCA
		internal ServicePoint()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04001FE3 RID: 8163
		private readonly Uri uri;

		// Token: 0x04001FE4 RID: 8164
		private DateTime lastDnsResolve;

		// Token: 0x04001FE5 RID: 8165
		private Version protocolVersion;

		// Token: 0x04001FE6 RID: 8166
		private IPHostEntry host;

		// Token: 0x04001FE7 RID: 8167
		private bool usesProxy;

		// Token: 0x04001FE8 RID: 8168
		private bool sendContinue;

		// Token: 0x04001FE9 RID: 8169
		private bool useConnect;

		// Token: 0x04001FEA RID: 8170
		private object hostE;

		// Token: 0x04001FEB RID: 8171
		private bool useNagle;

		// Token: 0x04001FEC RID: 8172
		private BindIPEndPoint endPointCallback;

		// Token: 0x04001FED RID: 8173
		private bool tcp_keepalive;

		// Token: 0x04001FEE RID: 8174
		private int tcp_keepalive_time;

		// Token: 0x04001FEF RID: 8175
		private int tcp_keepalive_interval;

		// Token: 0x04001FF0 RID: 8176
		private bool disposed;

		// Token: 0x04001FF1 RID: 8177
		private int connectionLeaseTimeout;

		// Token: 0x04001FF2 RID: 8178
		private int receiveBufferSize;

		// Token: 0x04001FF5 RID: 8181
		private int connectionLimit;

		// Token: 0x04001FF6 RID: 8182
		private int maxIdleTime;

		// Token: 0x04001FF7 RID: 8183
		private object m_ServerCertificateOrBytes;

		// Token: 0x04001FF8 RID: 8184
		private object m_ClientCertificateOrBytes;
	}
}
