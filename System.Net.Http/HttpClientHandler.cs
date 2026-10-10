using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
	/// <summary>Обработчик сообщений по умолчанию, используемый <see cref="T:System.Net.Http.HttpClient" />.</summary>
	// Token: 0x0200000B RID: 11
	public class HttpClientHandler : HttpMessageHandler
	{
		// Token: 0x06000027 RID: 39 RVA: 0x0000286D File Offset: 0x00000A6D
		private static IMonoHttpClientHandler CreateDefaultHandler()
		{
			return new MonoWebRequestHandler();
		}

		/// <summary>Получает кэшированный делегат, который всегда возвращает <see langword="true" />.</summary>
		/// <returns>Кэшированный делегат, который всегда возвращает <see langword="true" />.</returns>
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002874 File Offset: 0x00000A74
		public static Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool> DangerousAcceptAnyServerCertificateValidator
		{
			get
			{
				throw new PlatformNotSupportedException();
			}
		}

		/// <summary>Создает экземпляр класса <see cref="T:System.Net.Http.HttpClientHandler" />.</summary>
		// Token: 0x06000029 RID: 41 RVA: 0x0000287B File Offset: 0x00000A7B
		public HttpClientHandler() : this(HttpClientHandler.CreateDefaultHandler())
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002888 File Offset: 0x00000A88
		internal HttpClientHandler(IMonoHttpClientHandler handler)
		{
			this._delegatingHandler = handler;
			this.ClientCertificateOptions = ClientCertificateOption.Manual;
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Net.Http.HttpClientHandler" />, и опционально удаляет управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> для освобождения управляемых и неуправляемых ресурсов; значение <see langword="false" /> для освобождения только неуправляемых ресурсов.</param>
		// Token: 0x0600002B RID: 43 RVA: 0x0000289E File Offset: 0x00000A9E
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this._delegatingHandler.Dispose();
			}
			base.Dispose(disposing);
		}

		/// <summary>Возвращает значение, указывающее, поддерживает ли обработчик автоматическую распаковку содержимого ответов.</summary>
		/// <returns>Значение <see langword="true" />, если обработчик поддерживает автоматическую распаковку содержимого ответов; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000028B5 File Offset: 0x00000AB5
		public virtual bool SupportsAutomaticDecompression
		{
			get
			{
				return this._delegatingHandler.SupportsAutomaticDecompression;
			}
		}

		/// <summary>Получает значение, указывающее, поддерживает ли обработчик параметры прокси.</summary>
		/// <returns>Значение, <see langword="true" /> если обработчик поддерживает параметры прокси; в противном случае <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000028C2 File Offset: 0x00000AC2
		public virtual bool SupportsProxy
		{
			get
			{
				return true;
			}
		}

		/// <summary>Получает значение, указывающее, поддерживает ли обработчик параметры конфигурации для свойств <see cref="P:System.Net.Http.HttpClientHandler.AllowAutoRedirect" /> и <see cref="P:System.Net.Http.HttpClientHandler.MaxAutomaticRedirections" />.</summary>
		/// <returns>Значение <see langword="true" />, если обработчик поддерживает параметры конфигурации для свойств <see cref="P:System.Net.Http.HttpClientHandler.AllowAutoRedirect" /> и <see cref="P:System.Net.Http.HttpClientHandler.MaxAutomaticRedirections" />; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000028C2 File Offset: 0x00000AC2
		public virtual bool SupportsRedirectConfiguration
		{
			get
			{
				return true;
			}
		}

		/// <summary>Получает или задает значение, указывающее, использует ли обработчик свойство <see cref="P:System.Net.Http.HttpClientHandler.CookieContainer" /> для хранения файлов cookie сервера и использует ли он такие файлы cookie при отправке запросов.</summary>
		/// <returns>Значение <see langword="true" />, если обработчик использует свойство <see cref="P:System.Net.Http.HttpClientHandler.CookieContainer" /> для хранения файлов cookie сервера и использует такие файлы cookie при отправке запросов; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000028C5 File Offset: 0x00000AC5
		// (set) Token: 0x06000030 RID: 48 RVA: 0x000028D2 File Offset: 0x00000AD2
		public bool UseCookies
		{
			get
			{
				return this._delegatingHandler.UseCookies;
			}
			set
			{
				this._delegatingHandler.UseCookies = value;
			}
		}

		/// <summary>Возвращает или задает контейнер файлов cookie, используемый для хранения файлов cookie сервера обработчиком.</summary>
		/// <returns>Контейнер файлов cookie, используемый для хранения файлов cookie сервера обработчиком.</returns>
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000031 RID: 49 RVA: 0x000028E0 File Offset: 0x00000AE0
		// (set) Token: 0x06000032 RID: 50 RVA: 0x000028ED File Offset: 0x00000AED
		public CookieContainer CookieContainer
		{
			get
			{
				return this._delegatingHandler.CookieContainer;
			}
			set
			{
				this._delegatingHandler.CookieContainer = value;
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000028FB File Offset: 0x00000AFB
		private void ThrowForModifiedManagedSslOptionsIfStarted()
		{
			this._delegatingHandler.SslOptions = this._delegatingHandler.SslOptions;
		}

		/// <summary>Возвращает или задает значение, указывающее, выбирается ли автоматически сертификат из хранилища сертификатов, или может ли вызывающий объект передавать определенный клиентский сертификат.</summary>
		/// <returns>Коллекция сертификатов безопасности, связанных с данным дескриптором.</returns>
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00002913 File Offset: 0x00000B13
		// (set) Token: 0x06000035 RID: 53 RVA: 0x0000291C File Offset: 0x00000B1C
		public ClientCertificateOption ClientCertificateOptions
		{
			get
			{
				return this._clientCertificateOptions;
			}
			set
			{
				if (value == ClientCertificateOption.Manual)
				{
					this.ThrowForModifiedManagedSslOptionsIfStarted();
					this._clientCertificateOptions = value;
					this._delegatingHandler.SslOptions.LocalCertificateSelectionCallback = ((object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) => CertificateHelper.GetEligibleClientCertificate(this.ClientCertificates));
					return;
				}
				if (value != ClientCertificateOption.Automatic)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.ThrowForModifiedManagedSslOptionsIfStarted();
				this._clientCertificateOptions = value;
				this._delegatingHandler.SslOptions.LocalCertificateSelectionCallback = ((object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) => CertificateHelper.GetEligibleClientCertificate());
			}
		}

		/// <summary>Получает коллекцию сертификатов безопасности, связанных с запросами к серверу.</summary>
		/// <returns>X509CertificateCollection, представленные на сервер при выполнении сертификат на основе проверки подлинности клиента.</returns>
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000029A4 File Offset: 0x00000BA4
		public X509CertificateCollection ClientCertificates
		{
			get
			{
				if (this.ClientCertificateOptions != ClientCertificateOption.Manual)
				{
					throw new InvalidOperationException(SR.Format("The {0} property must be set to '{1}' to use this property.", "ClientCertificateOptions", "Manual"));
				}
				X509CertificateCollection result;
				if ((result = this._delegatingHandler.SslOptions.ClientCertificates) == null)
				{
					result = (this._delegatingHandler.SslOptions.ClientCertificates = new X509CertificateCollection());
				}
				return result;
			}
		}

		/// <summary>Возвращает или задает метод обратного вызова для проверки сертификата сервера.</summary>
		/// <returns>Метод обратного вызова для проверки сертификата сервера.</returns>
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000029FF File Offset: 0x00000BFF
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00002A2D File Offset: 0x00000C2D
		public Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool> ServerCertificateCustomValidationCallback
		{
			get
			{
				RemoteCertificateValidationCallback remoteCertificateValidationCallback = this._delegatingHandler.SslOptions.RemoteCertificateValidationCallback;
				ConnectHelper.CertificateCallbackMapper certificateCallbackMapper = ((remoteCertificateValidationCallback != null) ? remoteCertificateValidationCallback.Target : null) as ConnectHelper.CertificateCallbackMapper;
				if (certificateCallbackMapper == null)
				{
					return null;
				}
				return certificateCallbackMapper.FromHttpClientHandler;
			}
			set
			{
				this.ThrowForModifiedManagedSslOptionsIfStarted();
				this._delegatingHandler.SslOptions.RemoteCertificateValidationCallback = ((value != null) ? new ConnectHelper.CertificateCallbackMapper(value).ForSocketsHttpHandler : null);
			}
		}

		/// <summary>Получает или задает значение, указывающее, проверяется ли сертификат по списку отзыва центра сертификации.</summary>
		/// <returns>Значение <see langword="true" />, если проверяется список отзыва сертификатов; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Только .NET Framework 4.7.1: Это свойство не реализовано.</exception>
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002A56 File Offset: 0x00000C56
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002A6B File Offset: 0x00000C6B
		public bool CheckCertificateRevocationList
		{
			get
			{
				return this._delegatingHandler.SslOptions.CertificateRevocationCheckMode == X509RevocationMode.Online;
			}
			set
			{
				this.ThrowForModifiedManagedSslOptionsIfStarted();
				this._delegatingHandler.SslOptions.CertificateRevocationCheckMode = (value ? X509RevocationMode.Online : X509RevocationMode.NoCheck);
			}
		}

		/// <summary>Возвращает или задает протокол TLS/SSL, используемый объектами <see cref="T:System.Net.Http.HttpClient" />, которые управляются объектом HttpClientHandler.</summary>
		/// <returns>Одно из значений, определенных в перечислении <see cref="T:System.Security.Authentication.SslProtocols" />.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">Только .NET Framework 4.7.1: Это свойство не реализовано.</exception>
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002A8A File Offset: 0x00000C8A
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00002A9C File Offset: 0x00000C9C
		public SslProtocols SslProtocols
		{
			get
			{
				return this._delegatingHandler.SslOptions.EnabledSslProtocols;
			}
			set
			{
				this.ThrowForModifiedManagedSslOptionsIfStarted();
				this._delegatingHandler.SslOptions.EnabledSslProtocols = value;
			}
		}

		/// <summary>Возвращает или задает тип метода распаковки, используемый обработчиком для автоматической распаковки содержимого HTTP-ответа.</summary>
		/// <returns>Метод автоматической распаковки, используемый обработчиком.</returns>
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002AB5 File Offset: 0x00000CB5
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002AC2 File Offset: 0x00000CC2
		public DecompressionMethods AutomaticDecompression
		{
			get
			{
				return this._delegatingHandler.AutomaticDecompression;
			}
			set
			{
				this._delegatingHandler.AutomaticDecompression = value;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, использует ли обработчик прокси-сервер для запросов.</summary>
		/// <returns>
		///   <see langword="true" />, если обработчик должен использовать прокси-сервер для запросов. В противном случае — <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002AD0 File Offset: 0x00000CD0
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00002ADD File Offset: 0x00000CDD
		public bool UseProxy
		{
			get
			{
				return this._delegatingHandler.UseProxy;
			}
			set
			{
				this._delegatingHandler.UseProxy = value;
			}
		}

		/// <summary>Возвращает или задает сведения о прокси-сервере, используемые обработчиком.</summary>
		/// <returns>Сведения о прокси-сервере, используемые обработчиком. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002AEB File Offset: 0x00000CEB
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002AF8 File Offset: 0x00000CF8
		public IWebProxy Proxy
		{
			get
			{
				return this._delegatingHandler.Proxy;
			}
			set
			{
				this._delegatingHandler.Proxy = value;
			}
		}

		/// <summary>Если используется прокси-сервер по умолчанию (системный), возвращает или задает учетные данные, отправляемые на прокси-сервер по умолчанию для проверки подлинности. Прокси-сервер по умолчанию используется только если <see cref="P:System.Net.Http.HttpClientHandler.UseProxy" /> задано значение <see langword="true" /> и <see cref="P:System.Net.Http.HttpClientHandler.Proxy" /> задано значение <see langword="null" />.</summary>
		/// <returns>Учетные данные, необходимые для проверки подлинности запроса к прокси-сервера по умолчанию.</returns>
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002B06 File Offset: 0x00000D06
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002B13 File Offset: 0x00000D13
		public ICredentials DefaultProxyCredentials
		{
			get
			{
				return this._delegatingHandler.DefaultProxyCredentials;
			}
			set
			{
				this._delegatingHandler.DefaultProxyCredentials = value;
			}
		}

		/// <summary>Получает или задает значение, указывающее, будет ли обработчик отправлять заголовок авторизации вместе с запросом.</summary>
		/// <returns>Значение <see langword="true" /> для отправки обработчиком заголовка авторизации HTTP с запросом после выполнения аутентификации; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002B21 File Offset: 0x00000D21
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002B2E File Offset: 0x00000D2E
		public bool PreAuthenticate
		{
			get
			{
				return this._delegatingHandler.PreAuthenticate;
			}
			set
			{
				this._delegatingHandler.PreAuthenticate = value;
			}
		}

		/// <summary>Возвращает или задает значение, которое определяет, должен ли обработчик отправлять учетные данные по умолчанию вместе с запросами.</summary>
		/// <returns>Значение <see langword="true" />, если используются учетные данные по умолчанию; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002B3C File Offset: 0x00000D3C
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002B50 File Offset: 0x00000D50
		public bool UseDefaultCredentials
		{
			get
			{
				return this._delegatingHandler.Credentials == CredentialCache.DefaultCredentials;
			}
			set
			{
				if (value)
				{
					this._delegatingHandler.Credentials = CredentialCache.DefaultCredentials;
					return;
				}
				if (this._delegatingHandler.Credentials == CredentialCache.DefaultCredentials)
				{
					this._delegatingHandler.Credentials = null;
				}
			}
		}

		/// <summary>Возвращает или задает сведения о проверке подлинности, используемые данным обработчиком.</summary>
		/// <returns>Учетные записи проверки подлинности, связанные с обработчиком. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002B84 File Offset: 0x00000D84
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00002B91 File Offset: 0x00000D91
		public ICredentials Credentials
		{
			get
			{
				return this._delegatingHandler.Credentials;
			}
			set
			{
				this._delegatingHandler.Credentials = value;
			}
		}

		/// <summary>Возвращает или задает значение, которое указывает, должен ли обработчик следовать ответам перенаправления.</summary>
		/// <returns>
		///   <see langword="true" /> Если обработчик должен следовать ответам переадресации, получаемым; в противном случае <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002B9F File Offset: 0x00000D9F
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002BAC File Offset: 0x00000DAC
		public bool AllowAutoRedirect
		{
			get
			{
				return this._delegatingHandler.AllowAutoRedirect;
			}
			set
			{
				this._delegatingHandler.AllowAutoRedirect = value;
			}
		}

		/// <summary>Возвращает или задает максимальное количество переадресаций, выполняемых обработчиком.</summary>
		/// <returns>Максимальное количество ответов переадресации, выполняемых обработчиком. Значение по умолчанию — 50.</returns>
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002BBA File Offset: 0x00000DBA
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00002BC7 File Offset: 0x00000DC7
		public int MaxAutomaticRedirections
		{
			get
			{
				return this._delegatingHandler.MaxAutomaticRedirections;
			}
			set
			{
				this._delegatingHandler.MaxAutomaticRedirections = value;
			}
		}

		/// <summary>Возвращает или задает максимально допустимое число одновременных подключений (для каждой конечной точки сервера) при выполнении запросов с помощью объекта <see cref="T:System.Net.Http.HttpClient" />. Обратите внимание, что для каждой конечной точки сервера существует ограничение, например, значение 256 разрешает выполнять 256 одновременных подключений к http://www.adatum.com/ и еще 256 подключений — к http://www.adventure-works.com/.</summary>
		/// <returns>Максимальное число одновременных подключений (каждой конечной точки сервера), разрешенное <see cref="T:System.Net.Http.HttpClient" /> объекта.</returns>
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00002BD5 File Offset: 0x00000DD5
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002BE2 File Offset: 0x00000DE2
		public int MaxConnectionsPerServer
		{
			get
			{
				return this._delegatingHandler.MaxConnectionsPerServer;
			}
			set
			{
				this._delegatingHandler.MaxConnectionsPerServer = value;
			}
		}

		/// <summary>Возвращает или задает максимальную длину заголовков ответов, выраженную в килобайтах (1024 байта). Например, если значение равно 64, для максимальной длины заголовков ответов разрешено использовать 65536 байт.</summary>
		/// <returns>Максимальная длина в килобайтах (1024 байта), заголовков ответов.</returns>
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002BF0 File Offset: 0x00000DF0
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00002BFD File Offset: 0x00000DFD
		public int MaxResponseHeadersLength
		{
			get
			{
				return this._delegatingHandler.MaxResponseHeadersLength;
			}
			set
			{
				this._delegatingHandler.MaxResponseHeadersLength = value;
			}
		}

		/// <summary>Получает или задает максимальный размер буфера содержимого запроса, используемого обработчиком.</summary>
		/// <returns>Максимальный размер буфера содержимого запроса в байтах. Значение по умолчанию — 2 ГБ.</returns>
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002C0B File Offset: 0x00000E0B
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00002C18 File Offset: 0x00000E18
		public long MaxRequestContentBufferSize
		{
			get
			{
				return this._delegatingHandler.MaxRequestContentBufferSize;
			}
			set
			{
				this._delegatingHandler.MaxRequestContentBufferSize = value;
			}
		}

		/// <summary>Возвращает доступный для записи словарь (т. е. карту) настраиваемых свойств запросов <see cref="T:System.Net.Http.HttpClient" />. Словарь инициализируется пустым. Можно вставить и запросить пары "ключ-значение" для пользовательских обработчиков и особой обработки.</summary>
		/// <returns>для записи словарь пользовательских свойств.</returns>
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00002C26 File Offset: 0x00000E26
		public IDictionary<string, object> Properties
		{
			get
			{
				return this._delegatingHandler.Properties;
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002C33 File Offset: 0x00000E33
		internal void SetWebRequestTimeout(TimeSpan timeout)
		{
			this._delegatingHandler.SetWebRequestTimeout(timeout);
		}

		/// <summary>Создает экземпляр <see cref="T:System.Net.Http.HttpResponseMessage" /> на основе сведений, предоставленных в <see cref="T:System.Net.Http.HttpRequestMessage" />, в качестве неблокируемой операции.</summary>
		/// <param name="request">Сообщение HTTP-запроса.</param>
		/// <param name="cancellationToken">Маркер отмены для отмены операции.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Запрос <paramref name="request" /> имел значение <see langword="null" />.</exception>
		// Token: 0x06000057 RID: 87 RVA: 0x00002C41 File Offset: 0x00000E41
		protected internal override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			return this._delegatingHandler.SendAsync(request, cancellationToken);
		}

		// Token: 0x0400001C RID: 28
		private readonly IMonoHttpClientHandler _delegatingHandler;

		// Token: 0x0400001D RID: 29
		private ClientCertificateOption _clientCertificateOptions;
	}
}
