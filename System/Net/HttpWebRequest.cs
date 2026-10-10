using System;
using System.ComponentModel;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Net.Cache;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Mono.Net.Security;
using Mono.Security.Interface;
using Unity;

namespace System.Net
{
	/// <summary>Предоставляет связанную с HTTP реализацию класса <see cref="T:System.Net.WebRequest" />.</summary>
	// Token: 0x02000694 RID: 1684
	[Serializable]
	public class HttpWebRequest : WebRequest, ISerializable
	{
		// Token: 0x06003570 RID: 13680 RVA: 0x000BAD00 File Offset: 0x000B8F00
		static HttpWebRequest()
		{
			NetConfig netConfig = ConfigurationSettings.GetConfig("system.net/settings") as NetConfig;
			if (netConfig != null)
			{
				HttpWebRequest.defaultMaxResponseHeadersLength = netConfig.MaxResponseHeadersLength;
			}
		}

		// Token: 0x06003571 RID: 13681 RVA: 0x000BAD44 File Offset: 0x000B8F44
		internal HttpWebRequest(Uri uri)
		{
			this.allowAutoRedirect = true;
			this.allowBuffering = true;
			this.contentLength = -1L;
			this.keepAlive = true;
			this.maxAutoRedirect = 50;
			this.mediaType = string.Empty;
			this.method = "GET";
			this.initialMethod = "GET";
			this.pipelined = true;
			this.version = HttpVersion.Version11;
			this.timeout = 100000;
			this.continueTimeout = 350;
			this.locker = new object();
			this.readWriteTimeout = 300000;
			base..ctor();
			this.requestUri = uri;
			this.actualUri = uri;
			this.proxy = WebRequest.InternalDefaultWebProxy;
			this.webHeaders = new WebHeaderCollection(WebHeaderCollectionType.HttpWebRequest);
			this.ThrowOnError = true;
			this.ResetAuthorization();
		}

		// Token: 0x06003572 RID: 13682 RVA: 0x000BAE0D File Offset: 0x000B900D
		internal HttpWebRequest(Uri uri, MobileTlsProvider tlsProvider, MonoTlsSettings settings = null) : this(uri)
		{
			this.tlsProvider = tlsProvider;
			this.tlsSettings = settings;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.HttpWebRequest" /> на основе указанных экземпляров классов <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" />. Этот конструктор является устаревшим.</summary>
		/// <param name="serializationInfo">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который содержит сведения, требуемые для сериализации нового объекта <see cref="T:System.Net.HttpWebRequest" />.</param>
		/// <param name="streamingContext">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий исходный объект и объект назначения для сериализованного потока, связанного с новым объектом <see cref="T:System.Net.HttpWebRequest" />.</param>
		// Token: 0x06003573 RID: 13683 RVA: 0x000BAE24 File Offset: 0x000B9024
		[Obsolete("Serialization is obsoleted for this type.  http://go.microsoft.com/fwlink/?linkid=14202")]
		protected HttpWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			this.allowAutoRedirect = true;
			this.allowBuffering = true;
			this.contentLength = -1L;
			this.keepAlive = true;
			this.maxAutoRedirect = 50;
			this.mediaType = string.Empty;
			this.method = "GET";
			this.initialMethod = "GET";
			this.pipelined = true;
			this.version = HttpVersion.Version11;
			this.timeout = 100000;
			this.continueTimeout = 350;
			this.locker = new object();
			this.readWriteTimeout = 300000;
			base..ctor();
			throw new SerializationException();
		}

		// Token: 0x06003574 RID: 13684 RVA: 0x000BAEC0 File Offset: 0x000B90C0
		private void ResetAuthorization()
		{
			this.auth_state = new HttpWebRequest.AuthorizationState(this, false);
			this.proxy_auth_state = new HttpWebRequest.AuthorizationState(this, true);
		}

		// Token: 0x06003575 RID: 13685 RVA: 0x000BAEDC File Offset: 0x000B90DC
		private void SetSpecialHeaders(string HeaderName, string value)
		{
			value = WebHeaderCollection.CheckBadChars(value, true);
			this.webHeaders.RemoveInternal(HeaderName);
			if (value.Length != 0)
			{
				this.webHeaders.AddInternal(HeaderName, value);
			}
		}

		/// <summary>Возвращает или задает значение заголовка HTTP <see langword="Accept" />.</summary>
		/// <returns>Значение HTTP-заголовка <see langword="Accept" />. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06003576 RID: 13686 RVA: 0x000BAF08 File Offset: 0x000B9108
		// (set) Token: 0x06003577 RID: 13687 RVA: 0x000BAF1A File Offset: 0x000B911A
		public string Accept
		{
			get
			{
				return this.webHeaders["Accept"];
			}
			set
			{
				this.CheckRequestStarted();
				this.SetSpecialHeaders("Accept", value);
			}
		}

		/// <summary>Возвращает код URI интернет-ресурса, который фактически отвечает на запрос.</summary>
		/// <returns>Класс <see cref="T:System.Uri" />, идентифицирующий интернет-ресурс, который фактически отвечает на запрос. По умолчанию это код URI, используемый методом <see cref="M:System.Net.WebRequest.Create(System.String)" /> для инициализации запроса.</returns>
		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06003578 RID: 13688 RVA: 0x000BAF2E File Offset: 0x000B912E
		// (set) Token: 0x06003579 RID: 13689 RVA: 0x000BAF36 File Offset: 0x000B9136
		public Uri Address
		{
			get
			{
				return this.actualUri;
			}
			internal set
			{
				this.actualUri = value;
			}
		}

		/// <summary>Возвращает или задает значение, которое указывает, должен ли запрос следовать ответам переадресации.</summary>
		/// <returns>Значение <see langword="true" />, если запрос должен автоматически следовать ответам переадресации, получаемым от интернет-ресурса; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x0600357A RID: 13690 RVA: 0x000BAF3F File Offset: 0x000B913F
		// (set) Token: 0x0600357B RID: 13691 RVA: 0x000BAF47 File Offset: 0x000B9147
		public virtual bool AllowAutoRedirect
		{
			get
			{
				return this.allowAutoRedirect;
			}
			set
			{
				this.allowAutoRedirect = value;
			}
		}

		/// <summary>Возвращает или задает значение, которое указывает, будет ли выполняться буферизация данных, отправляемых в интернет-ресурс.</summary>
		/// <returns>Значение <see langword="true" /> устанавливается для включения буферизации данных, отправляемых в интернет-ресурс; значение <see langword="false" /> — для выключения буферизации. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x0600357C RID: 13692 RVA: 0x000BAF50 File Offset: 0x000B9150
		// (set) Token: 0x0600357D RID: 13693 RVA: 0x000BAF58 File Offset: 0x000B9158
		public virtual bool AllowWriteStreamBuffering
		{
			get
			{
				return this.allowBuffering;
			}
			set
			{
				this.allowBuffering = value;
			}
		}

		/// <summary>Возвращает или задает значение, которое указывает, будет ли выполняться буферизация данных, полученных от интернет-ресурса.</summary>
		/// <returns>Значение <see langword="true" /> устанавливается для включения буферизации данных, получаемых от интернет-ресурса; значение <see langword="false" /> — для выключения буферизации. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x0600357E RID: 13694 RVA: 0x000BAF61 File Offset: 0x000B9161
		// (set) Token: 0x0600357F RID: 13695 RVA: 0x000BAF69 File Offset: 0x000B9169
		public virtual bool AllowReadStreamBuffering
		{
			get
			{
				return this.allowReadStreamBuffering;
			}
			set
			{
				this.allowReadStreamBuffering = value;
			}
		}

		// Token: 0x06003580 RID: 13696 RVA: 0x0001FD2F File Offset: 0x0001DF2F
		private static Exception GetMustImplement()
		{
			return new NotImplementedException();
		}

		/// <summary>Возвращает или задает тип используемой распаковки.</summary>
		/// <returns>Объект <see cref="T:System.Net.DecompressionMethods" /> , указывающий тип используемой распаковки.</returns>
		/// <exception cref="T:System.InvalidOperationException">Текущее состояние объекта не позволяет задать это свойство.</exception>
		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06003581 RID: 13697 RVA: 0x000BAF72 File Offset: 0x000B9172
		// (set) Token: 0x06003582 RID: 13698 RVA: 0x000BAF7A File Offset: 0x000B917A
		public DecompressionMethods AutomaticDecompression
		{
			get
			{
				return this.auto_decomp;
			}
			set
			{
				this.CheckRequestStarted();
				this.auto_decomp = value;
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06003583 RID: 13699 RVA: 0x000BAF89 File Offset: 0x000B9189
		internal bool InternalAllowBuffering
		{
			get
			{
				return this.allowBuffering && this.MethodWithBuffer;
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06003584 RID: 13700 RVA: 0x000BAF9C File Offset: 0x000B919C
		private bool MethodWithBuffer
		{
			get
			{
				return this.method != "HEAD" && this.method != "GET" && this.method != "MKCOL" && this.method != "CONNECT" && this.method != "TRACE";
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06003585 RID: 13701 RVA: 0x000BB003 File Offset: 0x000B9203
		internal MobileTlsProvider TlsProvider
		{
			get
			{
				return this.tlsProvider;
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06003586 RID: 13702 RVA: 0x000BB00B File Offset: 0x000B920B
		internal MonoTlsSettings TlsSettings
		{
			get
			{
				return this.tlsSettings;
			}
		}

		/// <summary>Возвращает или задает коллекцию сертификатов безопасности, связанных с данным запросом.</summary>
		/// <returns>Коллекция <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />, содержащая сертификаты безопасности, связанные этим с запросом.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для операции задания указано значение <see langword="null" />.</exception>
		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06003587 RID: 13703 RVA: 0x000BB013 File Offset: 0x000B9213
		// (set) Token: 0x06003588 RID: 13704 RVA: 0x000BB02E File Offset: 0x000B922E
		public X509CertificateCollection ClientCertificates
		{
			get
			{
				if (this.certificates == null)
				{
					this.certificates = new X509CertificateCollection();
				}
				return this.certificates;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.certificates = value;
			}
		}

		/// <summary>Возвращает или задает значение заголовка HTTP <see langword="Connection" />.</summary>
		/// <returns>Значение HTTP-заголовка <see langword="Connection" />. Значение по умолчанию — <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">Для <see cref="P:System.Net.HttpWebRequest.Connection" /> задано значение "Проверка активности" или "Закрыто".</exception>
		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06003589 RID: 13705 RVA: 0x000BB045 File Offset: 0x000B9245
		// (set) Token: 0x0600358A RID: 13706 RVA: 0x000BB058 File Offset: 0x000B9258
		public string Connection
		{
			get
			{
				return this.webHeaders["Connection"];
			}
			set
			{
				this.CheckRequestStarted();
				if (string.IsNullOrWhiteSpace(value))
				{
					this.webHeaders.RemoveInternal("Connection");
					return;
				}
				string text = value.ToLowerInvariant();
				if (text.Contains("keep-alive") || text.Contains("close"))
				{
					throw new ArgumentException("Keep-Alive and Close may not be set using this property.", "value");
				}
				string value2 = HttpValidationHelpers.CheckBadHeaderValueChars(value);
				this.webHeaders.CheckUpdate("Connection", value2);
			}
		}

		/// <summary>Возвращает или задает имя группы подключения для запроса.</summary>
		/// <returns>Имя группы подключения для данного запроса. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x0600358B RID: 13707 RVA: 0x000BB0CD File Offset: 0x000B92CD
		// (set) Token: 0x0600358C RID: 13708 RVA: 0x000BB0D5 File Offset: 0x000B92D5
		public override string ConnectionGroupName
		{
			get
			{
				return this.connectionGroup;
			}
			set
			{
				this.connectionGroup = value;
			}
		}

		/// <summary>Возвращает или задает заголовок HTTP <see langword="Content-length" />.</summary>
		/// <returns>Количество байтов данных, отправляемых в интернет-ресурс. Значение по умолчанию, равное –1, показывает, что свойство не установлено и отсутствуют данные запроса, предназначенные для отправки.</returns>
		/// <exception cref="T:System.InvalidOperationException">Запрос запущен с помощью метода <see cref="M:System.Net.HttpWebRequest.GetRequestStream" />, <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />, <see cref="M:System.Net.HttpWebRequest.GetResponse" /> или <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Новое значение <see cref="P:System.Net.HttpWebRequest.ContentLength" /> меньше 0.</exception>
		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x0600358D RID: 13709 RVA: 0x000BB0DE File Offset: 0x000B92DE
		// (set) Token: 0x0600358E RID: 13710 RVA: 0x000BB0E6 File Offset: 0x000B92E6
		public override long ContentLength
		{
			get
			{
				return this.contentLength;
			}
			set
			{
				this.CheckRequestStarted();
				if (value < 0L)
				{
					throw new ArgumentOutOfRangeException("value", "Content-Length must be >= 0");
				}
				this.contentLength = value;
				this.haveContentLength = true;
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (set) Token: 0x0600358F RID: 13711 RVA: 0x000BB111 File Offset: 0x000B9311
		internal long InternalContentLength
		{
			set
			{
				this.contentLength = value;
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06003590 RID: 13712 RVA: 0x000BB11A File Offset: 0x000B931A
		// (set) Token: 0x06003591 RID: 13713 RVA: 0x000BB122 File Offset: 0x000B9322
		internal bool ThrowOnError { get; set; }

		/// <summary>Возвращает или задает значение заголовка HTTP <see langword="Content-type" />.</summary>
		/// <returns>Значение HTTP-заголовка <see langword="Content-type" />. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06003592 RID: 13714 RVA: 0x000BB12B File Offset: 0x000B932B
		// (set) Token: 0x06003593 RID: 13715 RVA: 0x000BB13D File Offset: 0x000B933D
		public override string ContentType
		{
			get
			{
				return this.webHeaders["Content-Type"];
			}
			set
			{
				this.SetSpecialHeaders("Content-Type", value);
			}
		}

		/// <summary>Возвращает или задает метод делегата, вызываемый при получении от интернет-ресурса HTTP-ответа 100-continue.</summary>
		/// <returns>Делегат, реализующий метод обратного вызова, который выполняется при возвращении от интернет-ресурса ответа HTTP Continue. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06003594 RID: 13716 RVA: 0x000BB14B File Offset: 0x000B934B
		// (set) Token: 0x06003595 RID: 13717 RVA: 0x000BB153 File Offset: 0x000B9353
		public HttpContinueDelegate ContinueDelegate
		{
			get
			{
				return this.continueDelegate;
			}
			set
			{
				this.continueDelegate = value;
			}
		}

		/// <summary>Возвращает или задает файлы cookie, связанные с запросом.</summary>
		/// <returns>Контейнер <see cref="T:System.Net.CookieContainer" />, в котором содержатся файлы cookie, связанные с этим запросом.</returns>
		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06003596 RID: 13718 RVA: 0x000BB15C File Offset: 0x000B935C
		// (set) Token: 0x06003597 RID: 13719 RVA: 0x000BB164 File Offset: 0x000B9364
		public virtual CookieContainer CookieContainer
		{
			get
			{
				return this.cookieContainer;
			}
			set
			{
				this.cookieContainer = value;
			}
		}

		/// <summary>Возвращает или задает сведения о проверке подлинности для этого запроса.</summary>
		/// <returns>Класс <see cref="T:System.Net.ICredentials" />, содержащий учетные данные для проверки подлинности, связанные с запросом. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06003598 RID: 13720 RVA: 0x000BB16D File Offset: 0x000B936D
		// (set) Token: 0x06003599 RID: 13721 RVA: 0x000BB175 File Offset: 0x000B9375
		public override ICredentials Credentials
		{
			get
			{
				return this.credentials;
			}
			set
			{
				this.credentials = value;
			}
		}

		/// <summary>Получает или задает значение заголовка HTTP <see langword="Date" /> для использования в HTTP-запросе.</summary>
		/// <returns>Значение заголовка Date в HTTP-запросе.</returns>
		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x0600359A RID: 13722 RVA: 0x000BB180 File Offset: 0x000B9380
		// (set) Token: 0x0600359B RID: 13723 RVA: 0x000BB1BF File Offset: 0x000B93BF
		public DateTime Date
		{
			get
			{
				string text = this.webHeaders["Date"];
				if (text == null)
				{
					return DateTime.MinValue;
				}
				return DateTime.ParseExact(text, "r", CultureInfo.InvariantCulture).ToLocalTime();
			}
			set
			{
				this.SetDateHeaderHelper("Date", value);
			}
		}

		// Token: 0x0600359C RID: 13724 RVA: 0x000BB1CD File Offset: 0x000B93CD
		private void SetDateHeaderHelper(string headerName, DateTime dateTime)
		{
			if (dateTime == DateTime.MinValue)
			{
				this.SetSpecialHeaders(headerName, null);
				return;
			}
			this.SetSpecialHeaders(headerName, HttpProtocolUtils.date2string(dateTime));
		}

		/// <summary>Возвращает или задает политику кэширования для этого запроса.</summary>
		/// <returns>Свойство <see cref="T:System.Net.Cache.HttpRequestCachePolicy" />, которое указывает политику кэширования, действующую для этого запроса, если неприменима любая другая политика.</returns>
		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x0600359D RID: 13725 RVA: 0x000BB1F2 File Offset: 0x000B93F2
		// (set) Token: 0x0600359E RID: 13726 RVA: 0x000BB1F9 File Offset: 0x000B93F9
		[MonoTODO]
		public new static RequestCachePolicy DefaultCachePolicy
		{
			get
			{
				return HttpWebRequest.defaultCachePolicy;
			}
			set
			{
				HttpWebRequest.defaultCachePolicy = value;
			}
		}

		/// <summary>Возвращает или задает наибольшую длину по умолчанию для ответа HTTP об ошибке.</summary>
		/// <returns>Наибольшая длина по умолчанию для ответа HTTP об ошибке.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение меньше нуля и не равно –1.</exception>
		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x0600359F RID: 13727 RVA: 0x000BB201 File Offset: 0x000B9401
		// (set) Token: 0x060035A0 RID: 13728 RVA: 0x000BB208 File Offset: 0x000B9408
		[MonoTODO]
		public static int DefaultMaximumErrorResponseLength
		{
			get
			{
				return HttpWebRequest.defaultMaximumErrorResponseLength;
			}
			set
			{
				HttpWebRequest.defaultMaximumErrorResponseLength = value;
			}
		}

		/// <summary>Возвращает или задает значение заголовка HTTP <see langword="Expect" />.</summary>
		/// <returns>Содержимое заголовка HTTP <see langword="Expect" />. Значение по умолчанию — <see langword="null" />.  
		///
		///  Значение данного свойства содержится в <see cref="T:System.Net.WebHeaderCollection" />. Если задана коллекция WebHeaderCollection, значение свойства утрачивается.</returns>
		/// <exception cref="T:System.ArgumentException">Для <see langword="Expect" /> указана строка, содержащая значение 100-continue в виде подстроки.</exception>
		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x060035A1 RID: 13729 RVA: 0x000BB210 File Offset: 0x000B9410
		// (set) Token: 0x060035A2 RID: 13730 RVA: 0x000BB224 File Offset: 0x000B9424
		public string Expect
		{
			get
			{
				return this.webHeaders["Expect"];
			}
			set
			{
				this.CheckRequestStarted();
				string text = value;
				if (text != null)
				{
					text = text.Trim().ToLower();
				}
				if (text == null || text.Length == 0)
				{
					this.webHeaders.RemoveInternal("Expect");
					return;
				}
				if (text == "100-continue")
				{
					throw new ArgumentException("100-Continue cannot be set with this property.", "value");
				}
				this.webHeaders.CheckUpdate("Expect", value);
			}
		}

		/// <summary>Возвращает значение, показывающее, был ли получен ответ от интернет-ресурса.</summary>
		/// <returns>Значение <see langword="true" />, если ответ получен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x060035A3 RID: 13731 RVA: 0x000BB292 File Offset: 0x000B9492
		public virtual bool HaveResponse
		{
			get
			{
				return this.haveResponse;
			}
		}

		/// <summary>Указывает коллекцию пар "имя-значение", из которых создаются заголовки HTTP.</summary>
		/// <returns>Коллекция <see cref="T:System.Net.WebHeaderCollection" />, содержащая пары "имя-значение", из которых состоят заголовки HTTP-запроса.</returns>
		/// <exception cref="T:System.InvalidOperationException">Запрос запущен с помощью метода <see cref="M:System.Net.HttpWebRequest.GetRequestStream" />, <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />, <see cref="M:System.Net.HttpWebRequest.GetResponse" /> или <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />.</exception>
		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x060035A4 RID: 13732 RVA: 0x000BB29A File Offset: 0x000B949A
		// (set) Token: 0x060035A5 RID: 13733 RVA: 0x000BB2A4 File Offset: 0x000B94A4
		public override WebHeaderCollection Headers
		{
			get
			{
				return this.webHeaders;
			}
			set
			{
				this.CheckRequestStarted();
				WebHeaderCollection webHeaderCollection = new WebHeaderCollection(WebHeaderCollectionType.HttpWebRequest);
				foreach (string name in value.AllKeys)
				{
					webHeaderCollection.Add(name, value[name]);
				}
				this.webHeaders = webHeaderCollection;
			}
		}

		/// <summary>Получает или задает значение заголовка Host для использования в HTTP-запросе независимо от URI запроса.</summary>
		/// <returns>Значение заголовка Host в HTTP-запросе.</returns>
		/// <exception cref="T:System.ArgumentNullException">Заголовок узла не может иметь значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Заголовку узла не может задано недопустимое значение.</exception>
		/// <exception cref="T:System.InvalidOperationException">Нельзя установить заголовок узла после начала отправки <see cref="T:System.Net.HttpWebRequest" />.</exception>
		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x060035A6 RID: 13734 RVA: 0x000BB2F4 File Offset: 0x000B94F4
		// (set) Token: 0x060035A7 RID: 13735 RVA: 0x000BB35C File Offset: 0x000B955C
		public string Host
		{
			get
			{
				Uri uri = this.hostUri ?? this.Address;
				if ((!(this.hostUri == null) && this.hostHasPort) || !this.Address.IsDefaultPort)
				{
					return uri.Host + ":" + uri.Port.ToString();
				}
				return uri.Host;
			}
			set
			{
				this.CheckRequestStarted();
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				Uri uri;
				if (value.IndexOf('/') != -1 || !this.TryGetHostUri(value, out uri))
				{
					throw new ArgumentException("The specified value is not a valid Host header string.", "value");
				}
				this.hostUri = uri;
				if (!this.hostUri.IsDefaultPort)
				{
					this.hostHasPort = true;
					return;
				}
				if (value.IndexOf(':') == -1)
				{
					this.hostHasPort = false;
					return;
				}
				int num = value.IndexOf(']');
				this.hostHasPort = (num == -1 || value.LastIndexOf(':') > num);
			}
		}

		// Token: 0x060035A8 RID: 13736 RVA: 0x000BB3F3 File Offset: 0x000B95F3
		private bool TryGetHostUri(string hostName, out Uri hostUri)
		{
			return Uri.TryCreate(this.Address.Scheme + "://" + hostName + this.Address.PathAndQuery, UriKind.Absolute, out hostUri);
		}

		/// <summary>Возвращает или задает значение заголовка HTTP <see langword="If-Modified-Since" />.</summary>
		/// <returns>Объект <see cref="T:System.DateTime" />, в котором размещено содержимое заголовка HTTP <see langword="If-Modified-Since" />. Значением по умолчанию являются текущие дата и время.</returns>
		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x060035A9 RID: 13737 RVA: 0x000BB420 File Offset: 0x000B9620
		// (set) Token: 0x060035AA RID: 13738 RVA: 0x000BB46C File Offset: 0x000B966C
		public DateTime IfModifiedSince
		{
			get
			{
				string text = this.webHeaders["If-Modified-Since"];
				if (text == null)
				{
					return DateTime.Now;
				}
				DateTime result;
				try
				{
					result = MonoHttpDate.Parse(text);
				}
				catch (Exception)
				{
					result = DateTime.Now;
				}
				return result;
			}
			set
			{
				this.CheckRequestStarted();
				this.webHeaders.SetInternal("If-Modified-Since", value.ToUniversalTime().ToString("r", null));
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, необходимо ли устанавливать постоянное подключение к интернет-ресурсу.</summary>
		/// <returns>Значение <see langword="true" />, если запрос к интернет-ресурсу должен содержать заголовок HTTP <see langword="Connection" /> со значением Keep-alive; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x060035AB RID: 13739 RVA: 0x000BB4A4 File Offset: 0x000B96A4
		// (set) Token: 0x060035AC RID: 13740 RVA: 0x000BB4AC File Offset: 0x000B96AC
		public bool KeepAlive
		{
			get
			{
				return this.keepAlive;
			}
			set
			{
				this.keepAlive = value;
			}
		}

		/// <summary>Возвращает или задает максимальное количество переадресаций, выполняемых запросом.</summary>
		/// <returns>Максимальное количество ответов переадресации, указаниям которых следует запрос. Значение по умолчанию — 50.</returns>
		/// <exception cref="T:System.ArgumentException">Задано значение 0 или меньше 0.</exception>
		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x060035AD RID: 13741 RVA: 0x000BB4B5 File Offset: 0x000B96B5
		// (set) Token: 0x060035AE RID: 13742 RVA: 0x000BB4BD File Offset: 0x000B96BD
		public int MaximumAutomaticRedirections
		{
			get
			{
				return this.maxAutoRedirect;
			}
			set
			{
				if (value <= 0)
				{
					throw new ArgumentException("Must be > 0", "value");
				}
				this.maxAutoRedirect = value;
			}
		}

		/// <summary>Возвращает или задает максимальную допустимую длину заголовков ответов.</summary>
		/// <returns>Длина заголовков ответов, выраженная в килобайтах (1024 байта).</returns>
		/// <exception cref="T:System.InvalidOperationException">Свойство установлено уже после отправки запроса.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение меньше нуля и не равно –1.</exception>
		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x060035AF RID: 13743 RVA: 0x000BB4DA File Offset: 0x000B96DA
		// (set) Token: 0x060035B0 RID: 13744 RVA: 0x000BB4E2 File Offset: 0x000B96E2
		[MonoTODO("Use this")]
		public int MaximumResponseHeadersLength
		{
			get
			{
				return this.maxResponseHeadersLength;
			}
			set
			{
				this.CheckRequestStarted();
				if (value < 0 && value != -1)
				{
					throw new ArgumentOutOfRangeException("value", "The specified value must be greater than 0.");
				}
				this.maxResponseHeadersLength = value;
			}
		}

		/// <summary>Возвращает или задает значение по умолчанию для свойства <see cref="P:System.Net.HttpWebRequest.MaximumResponseHeadersLength" />.</summary>
		/// <returns>Длина в килобайтах (1024 байта) или максимум по умолчанию для получаемых заголовков ответов. В файле конфигурации по умолчанию это значение устанавливается равным 64 килобайтам.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение меньше нуля и не равно -1.</exception>
		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x060035B1 RID: 13745 RVA: 0x000BB509 File Offset: 0x000B9709
		// (set) Token: 0x060035B2 RID: 13746 RVA: 0x000BB510 File Offset: 0x000B9710
		[MonoTODO("Use this")]
		public static int DefaultMaximumResponseHeadersLength
		{
			get
			{
				return HttpWebRequest.defaultMaxResponseHeadersLength;
			}
			set
			{
				HttpWebRequest.defaultMaxResponseHeadersLength = value;
			}
		}

		/// <summary>Возвращает или задает время ожидания в миллисекундах при записи в поток или при чтении из него.</summary>
		/// <returns>Количество миллисекунд до истечения срока действия записи или чтения. По умолчанию установлено значение 300 000 миллисекунд (5 минут).</returns>
		/// <exception cref="T:System.InvalidOperationException">Запрос уже был отправлен.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение, указанное для операции задания, меньше или равно нулю и не равно <see cref="F:System.Threading.Timeout.Infinite" /></exception>
		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x060035B3 RID: 13747 RVA: 0x000BB518 File Offset: 0x000B9718
		// (set) Token: 0x060035B4 RID: 13748 RVA: 0x000BB520 File Offset: 0x000B9720
		public int ReadWriteTimeout
		{
			get
			{
				return this.readWriteTimeout;
			}
			set
			{
				this.CheckRequestStarted();
				if (value <= 0 && value != -1)
				{
					throw new ArgumentOutOfRangeException("value", "Timeout can be only be set to 'System.Threading.Timeout.Infinite' or a value > 0.");
				}
				this.readWriteTimeout = value;
			}
		}

		/// <summary>Возвращает или задает время ожидания в миллисекундах до получения ответа 100-Continue с сервера.</summary>
		/// <returns>Время ожидания в миллисекундах до получения ответа 100-Continue.</returns>
		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x060035B5 RID: 13749 RVA: 0x000BB547 File Offset: 0x000B9747
		// (set) Token: 0x060035B6 RID: 13750 RVA: 0x000BB54F File Offset: 0x000B974F
		[MonoTODO]
		public int ContinueTimeout
		{
			get
			{
				return this.continueTimeout;
			}
			set
			{
				this.CheckRequestStarted();
				if (value < 0 && value != -1)
				{
					throw new ArgumentOutOfRangeException("value", "Timeout can be only be set to 'System.Threading.Timeout.Infinite' or a value >= 0.");
				}
				this.continueTimeout = value;
			}
		}

		/// <summary>Возвращает или задает формат носителя запроса.</summary>
		/// <returns>Формат носителя запроса. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x060035B7 RID: 13751 RVA: 0x000BB576 File Offset: 0x000B9776
		// (set) Token: 0x060035B8 RID: 13752 RVA: 0x000BB57E File Offset: 0x000B977E
		public string MediaType
		{
			get
			{
				return this.mediaType;
			}
			set
			{
				this.mediaType = value;
			}
		}

		/// <summary>Возвращает или задает метод для запроса.</summary>
		/// <returns>Метод запроса, используемый для связи с интернет-ресурсом. Значение по умолчанию — GET.</returns>
		/// <exception cref="T:System.ArgumentException">Метод не указан.  
		/// -или- 
		/// Строка метода содержит недопустимые символы.</exception>
		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x060035B9 RID: 13753 RVA: 0x000BB587 File Offset: 0x000B9787
		// (set) Token: 0x060035BA RID: 13754 RVA: 0x000BB590 File Offset: 0x000B9790
		public override string Method
		{
			get
			{
				return this.method;
			}
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Cannot set null or blank methods on request.", "value");
				}
				if (HttpValidationHelpers.IsInvalidMethodOrHeaderString(value))
				{
					throw new ArgumentException("Cannot set null or blank methods on request.", "value");
				}
				this.method = value.ToUpperInvariant();
				if (this.method != "HEAD" && this.method != "GET" && this.method != "POST" && this.method != "PUT" && this.method != "DELETE" && this.method != "CONNECT" && this.method != "TRACE" && this.method != "MKCOL")
				{
					this.method = value;
				}
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, выполняется ли конвейерная передача запроса в интернет-ресурс.</summary>
		/// <returns>Значение <see langword="true" />, если должна выполняться конвейерная передача запроса; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x060035BB RID: 13755 RVA: 0x000BB673 File Offset: 0x000B9873
		// (set) Token: 0x060035BC RID: 13756 RVA: 0x000BB67B File Offset: 0x000B987B
		public bool Pipelined
		{
			get
			{
				return this.pipelined;
			}
			set
			{
				this.pipelined = value;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, следует ли отправлять заголовок авторизации вместе с запросом.</summary>
		/// <returns>Значение <see langword="true" />, если с запросом требуется отправить заголовок авторизации HTTP после выполнения аутентификации; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x060035BD RID: 13757 RVA: 0x000BB684 File Offset: 0x000B9884
		// (set) Token: 0x060035BE RID: 13758 RVA: 0x000BB68C File Offset: 0x000B988C
		public override bool PreAuthenticate
		{
			get
			{
				return this.preAuthenticate;
			}
			set
			{
				this.preAuthenticate = value;
			}
		}

		/// <summary>Возвращает или задает версию HTTP-протокола, используемую для запроса.</summary>
		/// <returns>Версия HTTP-протокола, используемая для запроса. Значение по умолчанию — <see cref="F:System.Net.HttpVersion.Version11" />.</returns>
		/// <exception cref="T:System.ArgumentException">Для версии HTTP задано значение, отличное от 1.0 или 1.1.</exception>
		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x060035BF RID: 13759 RVA: 0x000BB695 File Offset: 0x000B9895
		// (set) Token: 0x060035C0 RID: 13760 RVA: 0x000BB69D File Offset: 0x000B989D
		public Version ProtocolVersion
		{
			get
			{
				return this.version;
			}
			set
			{
				if (value != HttpVersion.Version10 && value != HttpVersion.Version11)
				{
					throw new ArgumentException("Only HTTP/1.0 and HTTP/1.1 version requests are currently supported.", "value");
				}
				this.force_version = true;
				this.version = value;
			}
		}

		/// <summary>Возвращает или задает сведения о прокси-сервере для запроса.</summary>
		/// <returns>Объект <see cref="T:System.Net.IWebProxy" />, используемый в качестве прокси-сервера для этого запроса. Значение по умолчанию устанавливается путем вызова свойства <see cref="P:System.Net.GlobalProxySelection.Select" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметру <see cref="P:System.Net.HttpWebRequest.Proxy" /> задается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Запрос запущен с помощью вызова <see cref="M:System.Net.HttpWebRequest.GetRequestStream" />, <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />, <see cref="M:System.Net.HttpWebRequest.GetResponse" /> или <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий объект не имеет разрешения на запрошенную операцию.</exception>
		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x060035C1 RID: 13761 RVA: 0x000BB6D7 File Offset: 0x000B98D7
		// (set) Token: 0x060035C2 RID: 13762 RVA: 0x000BB6DF File Offset: 0x000B98DF
		public override IWebProxy Proxy
		{
			get
			{
				return this.proxy;
			}
			set
			{
				this.CheckRequestStarted();
				this.proxy = value;
				this.servicePoint = null;
				this.GetServicePoint();
			}
		}

		/// <summary>Возвращает или задает значение заголовка HTTP <see langword="Referer" />.</summary>
		/// <returns>Значение HTTP-заголовка <see langword="Referer" />. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x060035C3 RID: 13763 RVA: 0x000BB6FC File Offset: 0x000B98FC
		// (set) Token: 0x060035C4 RID: 13764 RVA: 0x000BB70E File Offset: 0x000B990E
		public string Referer
		{
			get
			{
				return this.webHeaders["Referer"];
			}
			set
			{
				this.CheckRequestStarted();
				if (value == null || value.Trim().Length == 0)
				{
					this.webHeaders.RemoveInternal("Referer");
					return;
				}
				this.webHeaders.SetInternal("Referer", value);
			}
		}

		/// <summary>Возвращает исходный код URI запроса.</summary>
		/// <returns>Объект <see cref="T:System.Uri" />, который содержит код URI интернет-ресурса, переданный методу <see cref="M:System.Net.WebRequest.Create(System.String)" />.</returns>
		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x060035C5 RID: 13765 RVA: 0x000BB748 File Offset: 0x000B9948
		public override Uri RequestUri
		{
			get
			{
				return this.requestUri;
			}
		}

		/// <summary>Возвращает или задает значение, которое указывает, будут ли отправляться данные в интернет-ресурс в виде сегментов.</summary>
		/// <returns>Значение <see langword="true" />, если требуется отправлять данные в интернет-ресурс сегментами. В противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Запрос запущен с помощью метода <see cref="M:System.Net.HttpWebRequest.GetRequestStream" />, <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />, <see cref="M:System.Net.HttpWebRequest.GetResponse" /> или <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />.</exception>
		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x060035C6 RID: 13766 RVA: 0x000BB750 File Offset: 0x000B9950
		// (set) Token: 0x060035C7 RID: 13767 RVA: 0x000BB758 File Offset: 0x000B9958
		public bool SendChunked
		{
			get
			{
				return this.sendChunked;
			}
			set
			{
				this.CheckRequestStarted();
				this.sendChunked = value;
			}
		}

		/// <summary>Возвращает точку обслуживания, используемую для запроса.</summary>
		/// <returns>Объект <see cref="T:System.Net.ServicePoint" />, представляющий сетевое подключение к интернет-ресурсу.</returns>
		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x060035C8 RID: 13768 RVA: 0x000BB767 File Offset: 0x000B9967
		public ServicePoint ServicePoint
		{
			get
			{
				return this.GetServicePoint();
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x060035C9 RID: 13769 RVA: 0x000BB76F File Offset: 0x000B996F
		internal ServicePoint ServicePointNoLock
		{
			get
			{
				return this.servicePoint;
			}
		}

		/// <summary>Получает значение, которое указывает, поддерживает ли запрос <see cref="T:System.Net.CookieContainer" />.</summary>
		/// <returns>Значение <see langword="true" />, если запрос поддерживает <see cref="T:System.Net.CookieContainer" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x060035CA RID: 13770 RVA: 0x0000390E File Offset: 0x00001B0E
		public virtual bool SupportsCookieContainer
		{
			get
			{
				return true;
			}
		}

		/// <summary>Возвращает или задает значение времени ожидания в миллисекундах для методов <see cref="M:System.Net.HttpWebRequest.GetResponse" /> и <see cref="M:System.Net.HttpWebRequest.GetRequestStream" />.</summary>
		/// <returns>Количество миллисекунд, ожидаемых до остановки запроса. По умолчанию установлено значение 100 000 миллисекунд (100 секунд).</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Указанное значение меньше нуля и не равно <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x060035CB RID: 13771 RVA: 0x000BB777 File Offset: 0x000B9977
		// (set) Token: 0x060035CC RID: 13772 RVA: 0x000BB77F File Offset: 0x000B997F
		public override int Timeout
		{
			get
			{
				return this.timeout;
			}
			set
			{
				if (value < -1)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.timeout = value;
			}
		}

		/// <summary>Возвращает или задает значение заголовка HTTP <see langword="Transfer-encoding" />.</summary>
		/// <returns>Значение HTTP-заголовка <see langword="Transfer-encoding" />. Значение по умолчанию — <see langword="null" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Значение <see cref="P:System.Net.HttpWebRequest.TransferEncoding" /> устанавливается, если <see cref="P:System.Net.HttpWebRequest.SendChunked" /> имеет значение <see langword="false" />.</exception>
		/// <exception cref="T:System.ArgumentException">Для <see cref="P:System.Net.HttpWebRequest.TransferEncoding" /> установлено значение Chunked.</exception>
		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x060035CD RID: 13773 RVA: 0x000BB797 File Offset: 0x000B9997
		// (set) Token: 0x060035CE RID: 13774 RVA: 0x000BB7AC File Offset: 0x000B99AC
		public string TransferEncoding
		{
			get
			{
				return this.webHeaders["Transfer-Encoding"];
			}
			set
			{
				this.CheckRequestStarted();
				if (string.IsNullOrWhiteSpace(value))
				{
					this.webHeaders.RemoveInternal("Transfer-Encoding");
					return;
				}
				if (value.ToLower().Contains("chunked"))
				{
					throw new ArgumentException("Chunked encoding must be set via the SendChunked property.", "value");
				}
				if (!this.SendChunked)
				{
					throw new InvalidOperationException("TransferEncoding requires the SendChunked property to be set to true.");
				}
				string value2 = HttpValidationHelpers.CheckBadHeaderValueChars(value);
				this.webHeaders.CheckUpdate("Transfer-Encoding", value2);
			}
		}

		/// <summary>Возвращает или задает значение <see cref="T:System.Boolean" />, которое управляет отправкой учетных данных по умолчанию вместе с запросами.</summary>
		/// <returns>Значение равно <see langword="true" />, если используются учетные данные по умолчанию, в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Попытка задать для этого свойства значение после отправки запроса.</exception>
		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x060035CF RID: 13775 RVA: 0x000BB825 File Offset: 0x000B9A25
		// (set) Token: 0x060035D0 RID: 13776 RVA: 0x000BB834 File Offset: 0x000B9A34
		public override bool UseDefaultCredentials
		{
			get
			{
				return CredentialCache.DefaultCredentials == this.Credentials;
			}
			set
			{
				this.Credentials = (value ? CredentialCache.DefaultCredentials : null);
			}
		}

		/// <summary>Возвращает или задает значение заголовка HTTP <see langword="User-agent" />.</summary>
		/// <returns>Значение HTTP-заголовка <see langword="User-agent" />. Значение по умолчанию — <see langword="null" />.  
		///
		///  Значение данного свойства содержится в <see cref="T:System.Net.WebHeaderCollection" />. Если задана коллекция WebHeaderCollection, значение свойства утрачивается.</returns>
		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x060035D1 RID: 13777 RVA: 0x000BB847 File Offset: 0x000B9A47
		// (set) Token: 0x060035D2 RID: 13778 RVA: 0x000BB859 File Offset: 0x000B9A59
		public string UserAgent
		{
			get
			{
				return this.webHeaders["User-Agent"];
			}
			set
			{
				this.webHeaders.SetInternal("User-Agent", value);
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, будет ли разрешено совместное использование высокоскоростного подключения с проверкой подлинности NTLM.</summary>
		/// <returns>Значение <see langword="true" />, если необходимо сохранить открытым подключение, прошедшее проверку подлинности. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x060035D3 RID: 13779 RVA: 0x000BB86C File Offset: 0x000B9A6C
		// (set) Token: 0x060035D4 RID: 13780 RVA: 0x000BB874 File Offset: 0x000B9A74
		public bool UnsafeAuthenticatedConnectionSharing
		{
			get
			{
				return this.unsafe_auth_blah;
			}
			set
			{
				this.unsafe_auth_blah = value;
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x060035D5 RID: 13781 RVA: 0x000BB87D File Offset: 0x000B9A7D
		internal bool GotRequestStream
		{
			get
			{
				return this.gotRequestStream;
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x060035D6 RID: 13782 RVA: 0x000BB885 File Offset: 0x000B9A85
		// (set) Token: 0x060035D7 RID: 13783 RVA: 0x000BB88D File Offset: 0x000B9A8D
		internal bool ExpectContinue
		{
			get
			{
				return this.expectContinue;
			}
			set
			{
				this.expectContinue = value;
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x060035D8 RID: 13784 RVA: 0x000BAF2E File Offset: 0x000B912E
		internal Uri AuthUri
		{
			get
			{
				return this.actualUri;
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x060035D9 RID: 13785 RVA: 0x000BB896 File Offset: 0x000B9A96
		internal bool ProxyQuery
		{
			get
			{
				return this.servicePoint.UsesProxy && !this.servicePoint.UseConnect;
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x060035DA RID: 13786 RVA: 0x000BB8B5 File Offset: 0x000B9AB5
		internal ServerCertValidationCallback ServerCertValidationCallback
		{
			get
			{
				return this.certValidationCallback;
			}
		}

		/// <summary>Возвращает или задает функцию обратного вызова для проверки сертификата сервера.</summary>
		/// <returns>Функция обратного вызова для проверки сертификата сервера.</returns>
		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x060035DB RID: 13787 RVA: 0x000BB8BD File Offset: 0x000B9ABD
		// (set) Token: 0x060035DC RID: 13788 RVA: 0x000BB8D4 File Offset: 0x000B9AD4
		public RemoteCertificateValidationCallback ServerCertificateValidationCallback
		{
			get
			{
				if (this.certValidationCallback == null)
				{
					return null;
				}
				return this.certValidationCallback.ValidationCallback;
			}
			set
			{
				if (value == null)
				{
					this.certValidationCallback = null;
					return;
				}
				this.certValidationCallback = new ServerCertValidationCallback(value);
			}
		}

		// Token: 0x060035DD RID: 13789 RVA: 0x000BB8F0 File Offset: 0x000B9AF0
		internal ServicePoint GetServicePoint()
		{
			object obj = this.locker;
			lock (obj)
			{
				if (this.hostChanged || this.servicePoint == null)
				{
					this.servicePoint = ServicePointManager.FindServicePoint(this.actualUri, this.proxy);
					this.hostChanged = false;
				}
			}
			return this.servicePoint;
		}

		/// <summary>Добавляет в запрос заголовок диапазона байтов для определенного диапазона, располагающегося с начала или с конца запрашиваемых данных.</summary>
		/// <param name="range">Начальная или конечная точка диапазона.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="rangeSpecifier" /> недопустим.</exception>
		/// <exception cref="T:System.InvalidOperationException">Не удалось добавить заголовок диапазона.</exception>
		// Token: 0x060035DE RID: 13790 RVA: 0x000BB960 File Offset: 0x000B9B60
		public void AddRange(int range)
		{
			this.AddRange("bytes", (long)range);
		}

		/// <summary>Добавляет в запрос заголовок диапазона байтов для заданного диапазона.</summary>
		/// <param name="from">Место начала передачи данных.</param>
		/// <param name="to">Место остановки передачи данных.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="rangeSpecifier" /> недопустим.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="from" /> больше <paramref name="to" />  
		/// -или- 
		///  Значение <paramref name="from" /> или <paramref name="to" /> меньше 0.</exception>
		/// <exception cref="T:System.InvalidOperationException">Не удалось добавить заголовок диапазона.</exception>
		// Token: 0x060035DF RID: 13791 RVA: 0x000BB96F File Offset: 0x000B9B6F
		public void AddRange(int from, int to)
		{
			this.AddRange("bytes", (long)from, (long)to);
		}

		/// <summary>Добавляет в запрос заголовок Range для определенного диапазона, располагающегося с начала или с конца запрашиваемых данных.</summary>
		/// <param name="rangeSpecifier">Описание диапазона.</param>
		/// <param name="range">Начальная или конечная точка диапазона.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="rangeSpecifier" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="rangeSpecifier" /> недопустим.</exception>
		/// <exception cref="T:System.InvalidOperationException">Не удалось добавить заголовок диапазона.</exception>
		// Token: 0x060035E0 RID: 13792 RVA: 0x000BB980 File Offset: 0x000B9B80
		public void AddRange(string rangeSpecifier, int range)
		{
			this.AddRange(rangeSpecifier, (long)range);
		}

		/// <summary>Добавляет в запрос заголовок диапазона для заданного диапазона.</summary>
		/// <param name="rangeSpecifier">Описание диапазона.</param>
		/// <param name="from">Место начала передачи данных.</param>
		/// <param name="to">Место остановки передачи данных.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="rangeSpecifier" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="from" /> больше <paramref name="to" />  
		/// -или- 
		///  Значение параметра <paramref name="from" /> или <paramref name="to" /> меньше 0.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="rangeSpecifier" /> недопустим.</exception>
		/// <exception cref="T:System.InvalidOperationException">Не удалось добавить заголовок диапазона.</exception>
		// Token: 0x060035E1 RID: 13793 RVA: 0x000BB98B File Offset: 0x000B9B8B
		public void AddRange(string rangeSpecifier, int from, int to)
		{
			this.AddRange(rangeSpecifier, (long)from, (long)to);
		}

		/// <summary>Добавляет в запрос заголовок диапазона байтов для определенного диапазона, располагающегося с начала или с конца запрашиваемых данных.</summary>
		/// <param name="range">Начальная или конечная точка диапазона.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="rangeSpecifier" /> недопустим.</exception>
		/// <exception cref="T:System.InvalidOperationException">Не удалось добавить заголовок диапазона.</exception>
		// Token: 0x060035E2 RID: 13794 RVA: 0x000BB998 File Offset: 0x000B9B98
		public void AddRange(long range)
		{
			this.AddRange("bytes", range);
		}

		/// <summary>Добавляет в запрос заголовок диапазона байтов для заданного диапазона.</summary>
		/// <param name="from">Место начала передачи данных.</param>
		/// <param name="to">Место остановки передачи данных.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="rangeSpecifier" /> недопустим.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="from" /> больше <paramref name="to" />  
		/// -или- 
		///  Значение <paramref name="from" /> или <paramref name="to" /> меньше 0.</exception>
		/// <exception cref="T:System.InvalidOperationException">Не удалось добавить заголовок диапазона.</exception>
		// Token: 0x060035E3 RID: 13795 RVA: 0x000BB9A6 File Offset: 0x000B9BA6
		public void AddRange(long from, long to)
		{
			this.AddRange("bytes", from, to);
		}

		/// <summary>Добавляет в запрос заголовок Range для определенного диапазона, располагающегося с начала или с конца запрашиваемых данных.</summary>
		/// <param name="rangeSpecifier">Описание диапазона.</param>
		/// <param name="range">Начальная или конечная точка диапазона.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="rangeSpecifier" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="rangeSpecifier" /> недопустим.</exception>
		/// <exception cref="T:System.InvalidOperationException">Не удалось добавить заголовок диапазона.</exception>
		// Token: 0x060035E4 RID: 13796 RVA: 0x000BB9B8 File Offset: 0x000B9BB8
		public void AddRange(string rangeSpecifier, long range)
		{
			if (rangeSpecifier == null)
			{
				throw new ArgumentNullException("rangeSpecifier");
			}
			if (!WebHeaderCollection.IsValidToken(rangeSpecifier))
			{
				throw new ArgumentException("Invalid range specifier", "rangeSpecifier");
			}
			string text = this.webHeaders["Range"];
			if (text == null)
			{
				text = rangeSpecifier + "=";
			}
			else
			{
				if (string.Compare(text.Substring(0, text.IndexOf('=')), rangeSpecifier, StringComparison.OrdinalIgnoreCase) != 0)
				{
					throw new InvalidOperationException("A different range specifier is already in use");
				}
				text += ",";
			}
			string text2 = range.ToString(CultureInfo.InvariantCulture);
			if (range < 0L)
			{
				text = text + "0" + text2;
			}
			else
			{
				text = text + text2 + "-";
			}
			this.webHeaders.ChangeInternal("Range", text);
		}

		/// <summary>Добавляет в запрос заголовок диапазона для заданного диапазона.</summary>
		/// <param name="rangeSpecifier">Описание диапазона.</param>
		/// <param name="from">Место начала передачи данных.</param>
		/// <param name="to">Место остановки передачи данных.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="rangeSpecifier" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="from" /> больше <paramref name="to" />  
		/// -или- 
		///  Значение параметра <paramref name="from" /> или <paramref name="to" /> меньше 0.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="rangeSpecifier" /> недопустим.</exception>
		/// <exception cref="T:System.InvalidOperationException">Не удалось добавить заголовок диапазона.</exception>
		// Token: 0x060035E5 RID: 13797 RVA: 0x000BBA7C File Offset: 0x000B9C7C
		public void AddRange(string rangeSpecifier, long from, long to)
		{
			if (rangeSpecifier == null)
			{
				throw new ArgumentNullException("rangeSpecifier");
			}
			if (!WebHeaderCollection.IsValidToken(rangeSpecifier))
			{
				throw new ArgumentException("Invalid range specifier", "rangeSpecifier");
			}
			if (from > to || from < 0L)
			{
				throw new ArgumentOutOfRangeException("from");
			}
			if (to < 0L)
			{
				throw new ArgumentOutOfRangeException("to");
			}
			string text = this.webHeaders["Range"];
			if (text == null)
			{
				text = rangeSpecifier + "=";
			}
			else
			{
				text += ",";
			}
			text = string.Format("{0}{1}-{2}", text, from, to);
			this.webHeaders.ChangeInternal("Range", text);
		}

		// Token: 0x060035E6 RID: 13798 RVA: 0x000BBB2C File Offset: 0x000B9D2C
		private WebOperation SendRequest(bool redirecting, BufferOffsetSize writeBuffer, CancellationToken cancellationToken)
		{
			object obj = this.locker;
			WebOperation result;
			lock (obj)
			{
				if (!redirecting && this.requestSent)
				{
					WebOperation webOperation = this.currentOperation;
					if (webOperation == null)
					{
						throw new InvalidOperationException("Should never happen!");
					}
					result = webOperation;
				}
				else
				{
					WebOperation webOperation = new WebOperation(this, writeBuffer, false, cancellationToken);
					if (Interlocked.CompareExchange<WebOperation>(ref this.currentOperation, webOperation, null) != null)
					{
						throw new InvalidOperationException("Invalid nested call.");
					}
					this.requestSent = true;
					if (!redirecting)
					{
						this.redirects = 0;
					}
					this.servicePoint = this.GetServicePoint();
					this.servicePoint.SendRequest(webOperation, this.connectionGroup);
					result = webOperation;
				}
			}
			return result;
		}

		// Token: 0x060035E7 RID: 13799 RVA: 0x000BBBE0 File Offset: 0x000B9DE0
		private Task<Stream> MyGetRequestStreamAsync(CancellationToken cancellationToken)
		{
			if (this.Aborted)
			{
				throw HttpWebRequest.CreateRequestAbortedException();
			}
			bool flag = !(this.method == "GET") && !(this.method == "CONNECT") && !(this.method == "HEAD") && !(this.method == "TRACE");
			if (this.method == null || !flag)
			{
				throw new ProtocolViolationException("Cannot send a content-body with this verb-type.");
			}
			if (this.contentLength == -1L && !this.sendChunked && !this.allowBuffering && this.KeepAlive)
			{
				throw new ProtocolViolationException("Content-Length not set");
			}
			string transferEncoding = this.TransferEncoding;
			if (!this.sendChunked && transferEncoding != null && transferEncoding.Trim() != "")
			{
				throw new InvalidOperationException("TransferEncoding requires the SendChunked property to be set to true.");
			}
			object obj = this.locker;
			WebOperation webOperation;
			lock (obj)
			{
				if (this.getResponseCalled)
				{
					throw new InvalidOperationException("This operation cannot be performed after the request has been submitted.");
				}
				webOperation = this.currentOperation;
				if (webOperation == null)
				{
					this.initialMethod = this.method;
					this.gotRequestStream = true;
					webOperation = this.SendRequest(false, null, cancellationToken);
				}
			}
			return webOperation.GetRequestStream();
		}

		/// <summary>Начинает асинхронный запрос объекта <see cref="T:System.IO.Stream" />, используемого для записи данных.</summary>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />.</param>
		/// <param name="state">Объект состояния для данного запроса.</param>
		/// <returns>Класс <see cref="T:System.IAsyncResult" />, ссылающийся на асинхронный запрос.</returns>
		/// <exception cref="T:System.Net.ProtocolViolationException">Свойство <see cref="P:System.Net.HttpWebRequest.Method" /> имеет значение GET или HEAD.  
		/// -или- 
		///  <see cref="P:System.Net.HttpWebRequest.KeepAlive" /> равно <see langword="true" />, <see cref="P:System.Net.HttpWebRequest.AllowWriteStreamBuffering" /> равно <see langword="false" />, <see cref="P:System.Net.HttpWebRequest.ContentLength" /> равно –1, <see cref="P:System.Net.HttpWebRequest.SendChunked" /> равно <see langword="false" />, а <see cref="P:System.Net.HttpWebRequest.Method" /> равно POST или PUT.</exception>
		/// <exception cref="T:System.InvalidOperationException">Поток используется предыдущим вызовом в <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />  
		/// -или- 
		///  Для <see cref="P:System.Net.HttpWebRequest.TransferEncoding" /> задано значение, а <see cref="P:System.Net.HttpWebRequest.SendChunked" /> равно <see langword="false" />.  
		/// -или- 
		/// В пуле потоков заканчиваются потоки.</exception>
		/// <exception cref="T:System.NotSupportedException">Проверяющий элемент управления кэша запросов указывает, что ответ на этот запрос может быть предоставлен из кэша. Однако запросы, которые записывают данные, не должны использовать кэш. Это исключение может возникнуть при использовании пользовательского средства проверки кэша, которое неправильно реализовано.</exception>
		/// <exception cref="T:System.Net.WebException">
		///   <see cref="M:System.Net.HttpWebRequest.Abort" /> был вызван ранее.</exception>
		/// <exception cref="T:System.ObjectDisposedException">В приложении .NET Compact Framework поток запроса с нулевой длиной содержимого не был правильно получен и закрыт. Дополнительные сведения об обработке запросов с нулевой длиной содержимого см. в разделе Сетевое программирование в .NET Compact Framework.</exception>
		// Token: 0x060035E8 RID: 13800 RVA: 0x000BBD2C File Offset: 0x000B9F2C
		public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
		{
			return TaskToApm.Begin(this.RunWithTimeout<Stream>(new Func<CancellationToken, Task<Stream>>(this.MyGetRequestStreamAsync)), callback, state);
		}

		/// <summary>Завершает асинхронный запрос объекта <see cref="T:System.IO.Stream" />, используемого для записи данных.</summary>
		/// <param name="asyncResult">Незавершенный запрос потока.</param>
		/// <returns>Объект <see cref="T:System.IO.Stream" />, используемый для записи данных запроса.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.IOException">Запрос не завершил работу, и нет ни одного доступного потока.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="asyncResult" /> не был возвращен текущим экземпляром из вызова <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Этот метод был вызван ранее с помощью <paramref name="asyncResult" />.</exception>
		/// <exception cref="T:System.Net.WebException">
		///   <see cref="M:System.Net.HttpWebRequest.Abort" /> был вызван ранее.  
		/// -или- 
		/// При обработке этого запроса возникла ошибка.</exception>
		// Token: 0x060035E9 RID: 13801 RVA: 0x000BBD48 File Offset: 0x000B9F48
		public override Stream EndGetRequestStream(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			Stream result;
			try
			{
				result = TaskToApm.End<Stream>(asyncResult);
			}
			catch (Exception e)
			{
				throw this.GetWebException(e);
			}
			return result;
		}

		/// <summary>Получает объект <see cref="T:System.IO.Stream" />, используемый для записи данных запроса.</summary>
		/// <returns>Объект <see cref="T:System.IO.Stream" />, используемый для записи данных запроса.</returns>
		/// <exception cref="T:System.Net.ProtocolViolationException">Свойство <see cref="P:System.Net.HttpWebRequest.Method" /> имеет значение GET или HEAD.  
		/// -или- 
		///  <see cref="P:System.Net.HttpWebRequest.KeepAlive" /> равно <see langword="true" />, <see cref="P:System.Net.HttpWebRequest.AllowWriteStreamBuffering" /> равно <see langword="false" />, <see cref="P:System.Net.HttpWebRequest.ContentLength" /> равно –1, <see cref="P:System.Net.HttpWebRequest.SendChunked" /> равно <see langword="false" />, а <see cref="P:System.Net.HttpWebRequest.Method" /> равно POST или PUT.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Net.HttpWebRequest.GetRequestStream" /> вызывается несколько раз.  
		/// -или- 
		///  Для <see cref="P:System.Net.HttpWebRequest.TransferEncoding" /> задано значение, а <see cref="P:System.Net.HttpWebRequest.SendChunked" /> равно <see langword="false" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Проверяющий элемент управления кэша запросов указывает, что ответ на этот запрос может быть предоставлен из кэша. Однако запросы, которые записывают данные, не должны использовать кэш. Это исключение может возникнуть при использовании пользовательского средства проверки кэша, которое неправильно реализовано.</exception>
		/// <exception cref="T:System.Net.WebException">
		///   <see cref="M:System.Net.HttpWebRequest.Abort" /> был вызван ранее.  
		/// -или- 
		/// Истекло время ожидания для запроса.  
		/// -или- 
		/// При обработке этого запроса возникла ошибка.</exception>
		/// <exception cref="T:System.ObjectDisposedException">В приложении .NET Compact Framework поток запроса с нулевой длиной содержимого не был правильно получен и закрыт. Дополнительные сведения об обработке запросов с нулевой длиной содержимого см. в разделе Сетевое программирование в .NET Compact Framework.</exception>
		// Token: 0x060035EA RID: 13802 RVA: 0x000BBD88 File Offset: 0x000B9F88
		public override Stream GetRequestStream()
		{
			Stream result;
			try
			{
				result = this.GetRequestStreamAsync().Result;
			}
			catch (Exception e)
			{
				throw this.GetWebException(e);
			}
			return result;
		}

		/// <summary>Получает объект <see cref="T:System.IO.Stream" />, используемый для записи данных запроса, и выводит объект <see cref="T:System.Net.TransportContext" />, связанный с потоком.</summary>
		/// <param name="context">Объект <see cref="T:System.Net.TransportContext" /> для <see cref="T:System.IO.Stream" />.</param>
		/// <returns>Объект <see cref="T:System.IO.Stream" />, используемый для записи данных запроса.</returns>
		/// <exception cref="T:System.Exception">Методу <see cref="M:System.Net.HttpWebRequest.GetRequestStream" /> не удалось получить <see cref="T:System.IO.Stream" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Net.HttpWebRequest.GetRequestStream" /> вызывается несколько раз.  
		/// -или- 
		///  Для <see cref="P:System.Net.HttpWebRequest.TransferEncoding" /> задано значение, а <see cref="P:System.Net.HttpWebRequest.SendChunked" /> равно <see langword="false" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Проверяющий элемент управления кэша запросов указывает, что ответ на этот запрос может быть предоставлен из кэша. Однако запросы, которые записывают данные, не должны использовать кэш. Это исключение может возникнуть при использовании пользовательского средства проверки кэша, которое неправильно реализовано.</exception>
		/// <exception cref="T:System.Net.ProtocolViolationException">Свойство <see cref="P:System.Net.HttpWebRequest.Method" /> имеет значение GET или HEAD.  
		/// -или- 
		///  <see cref="P:System.Net.HttpWebRequest.KeepAlive" /> равно <see langword="true" />, <see cref="P:System.Net.HttpWebRequest.AllowWriteStreamBuffering" /> равно <see langword="false" />, <see cref="P:System.Net.HttpWebRequest.ContentLength" /> равно –1, <see cref="P:System.Net.HttpWebRequest.SendChunked" /> равно <see langword="false" />, а <see cref="P:System.Net.HttpWebRequest.Method" /> равно POST или PUT.</exception>
		/// <exception cref="T:System.Net.WebException">
		///   <see cref="M:System.Net.HttpWebRequest.Abort" /> был вызван ранее.  
		/// -или- 
		/// Истекло время ожидания для запроса.  
		/// -или- 
		/// При обработке этого запроса возникла ошибка.</exception>
		// Token: 0x060035EB RID: 13803 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public Stream GetRequestStream(out TransportContext context)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060035EC RID: 13804 RVA: 0x000BBDC0 File Offset: 0x000B9FC0
		public override Task<Stream> GetRequestStreamAsync()
		{
			return this.RunWithTimeout<Stream>(new Func<CancellationToken, Task<Stream>>(this.MyGetRequestStreamAsync));
		}

		// Token: 0x060035ED RID: 13805 RVA: 0x000BBDD4 File Offset: 0x000B9FD4
		internal static Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func, int timeout, Action abort, Func<bool> aborted, CancellationToken cancellationToken)
		{
			CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
			return HttpWebRequest.RunWithTimeoutWorker<T>(func(cancellationTokenSource.Token), timeout, abort, aborted, cancellationTokenSource);
		}

		// Token: 0x060035EE RID: 13806 RVA: 0x000BBE00 File Offset: 0x000BA000
		private static Task<T> RunWithTimeoutWorker<T>(Task<T> workerTask, int timeout, Action abort, Func<bool> aborted, CancellationTokenSource cts)
		{
			HttpWebRequest.<RunWithTimeoutWorker>d__244<T> <RunWithTimeoutWorker>d__;
			<RunWithTimeoutWorker>d__.workerTask = workerTask;
			<RunWithTimeoutWorker>d__.timeout = timeout;
			<RunWithTimeoutWorker>d__.abort = abort;
			<RunWithTimeoutWorker>d__.aborted = aborted;
			<RunWithTimeoutWorker>d__.cts = cts;
			<RunWithTimeoutWorker>d__.<>t__builder = AsyncTaskMethodBuilder<T>.Create();
			<RunWithTimeoutWorker>d__.<>1__state = -1;
			<RunWithTimeoutWorker>d__.<>t__builder.Start<HttpWebRequest.<RunWithTimeoutWorker>d__244<T>>(ref <RunWithTimeoutWorker>d__);
			return <RunWithTimeoutWorker>d__.<>t__builder.Task;
		}

		// Token: 0x060035EF RID: 13807 RVA: 0x000BBE64 File Offset: 0x000BA064
		private Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func)
		{
			CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
			return HttpWebRequest.RunWithTimeoutWorker<T>(func(cancellationTokenSource.Token), this.timeout, new Action(this.Abort), () => this.Aborted, cancellationTokenSource);
		}

		// Token: 0x060035F0 RID: 13808 RVA: 0x000BBEA8 File Offset: 0x000BA0A8
		private Task<HttpWebResponse> MyGetResponseAsync(CancellationToken cancellationToken)
		{
			HttpWebRequest.<MyGetResponseAsync>d__246 <MyGetResponseAsync>d__;
			<MyGetResponseAsync>d__.<>4__this = this;
			<MyGetResponseAsync>d__.cancellationToken = cancellationToken;
			<MyGetResponseAsync>d__.<>t__builder = AsyncTaskMethodBuilder<HttpWebResponse>.Create();
			<MyGetResponseAsync>d__.<>1__state = -1;
			<MyGetResponseAsync>d__.<>t__builder.Start<HttpWebRequest.<MyGetResponseAsync>d__246>(ref <MyGetResponseAsync>d__);
			return <MyGetResponseAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060035F1 RID: 13809 RVA: 0x000BBEF4 File Offset: 0x000BA0F4
		[return: TupleElementNames(new string[]
		{
			"response",
			"redirect",
			"mustReadAll",
			"writeBuffer",
			"ntlm"
		})]
		private Task<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>> GetResponseFromData(WebResponseStream stream, CancellationToken cancellationToken)
		{
			HttpWebRequest.<GetResponseFromData>d__247 <GetResponseFromData>d__;
			<GetResponseFromData>d__.<>4__this = this;
			<GetResponseFromData>d__.stream = stream;
			<GetResponseFromData>d__.cancellationToken = cancellationToken;
			<GetResponseFromData>d__.<>t__builder = AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.Create();
			<GetResponseFromData>d__.<>1__state = -1;
			<GetResponseFromData>d__.<>t__builder.Start<HttpWebRequest.<GetResponseFromData>d__247>(ref <GetResponseFromData>d__);
			return <GetResponseFromData>d__.<>t__builder.Task;
		}

		// Token: 0x060035F2 RID: 13810 RVA: 0x000BBF48 File Offset: 0x000BA148
		internal static Exception FlattenException(Exception e)
		{
			AggregateException ex = e as AggregateException;
			if (ex != null)
			{
				ex = ex.Flatten();
				if (ex.InnerExceptions.Count == 1)
				{
					return ex.InnerException;
				}
			}
			return e;
		}

		// Token: 0x060035F3 RID: 13811 RVA: 0x000BBF7C File Offset: 0x000BA17C
		private WebException GetWebException(Exception e)
		{
			return HttpWebRequest.GetWebException(e, this.Aborted);
		}

		// Token: 0x060035F4 RID: 13812 RVA: 0x000BBF8C File Offset: 0x000BA18C
		private static WebException GetWebException(Exception e, bool aborted)
		{
			e = HttpWebRequest.FlattenException(e);
			WebException ex = e as WebException;
			if (ex != null && (!aborted || ex.Status == WebExceptionStatus.RequestCanceled || ex.Status == WebExceptionStatus.Timeout))
			{
				return ex;
			}
			if (aborted || e is OperationCanceledException || e is ObjectDisposedException)
			{
				return HttpWebRequest.CreateRequestAbortedException();
			}
			return new WebException(e.Message, e, WebExceptionStatus.UnknownError, null);
		}

		// Token: 0x060035F5 RID: 13813 RVA: 0x000BBFEB File Offset: 0x000BA1EB
		internal static WebException CreateRequestAbortedException()
		{
			return new WebException(SR.Format("The request was aborted: The request was canceled.", WebExceptionStatus.RequestCanceled), WebExceptionStatus.RequestCanceled);
		}

		/// <summary>Начинает асинхронный запрос интернет-ресурса.</summary>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" /></param>
		/// <param name="state">Объект состояния для данного запроса.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, ссылающийся на асинхронный запрос ответа.</returns>
		/// <exception cref="T:System.InvalidOperationException">Поток уже используется предыдущим вызовом <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />  
		/// -или- 
		///  Для <see cref="P:System.Net.HttpWebRequest.TransferEncoding" /> задано значение, а <see cref="P:System.Net.HttpWebRequest.SendChunked" /> равно <see langword="false" />.  
		/// -или- 
		/// В пуле потоков заканчиваются потоки.</exception>
		/// <exception cref="T:System.Net.ProtocolViolationException">
		///   <see cref="P:System.Net.HttpWebRequest.Method" /> равно GET или HEAD, и либо <see cref="P:System.Net.HttpWebRequest.ContentLength" /> больше нуля, либо <see cref="P:System.Net.HttpWebRequest.SendChunked" /> равно <see langword="true" />.  
		/// -или- 
		///  <see cref="P:System.Net.HttpWebRequest.KeepAlive" /> равно <see langword="true" />, <see cref="P:System.Net.HttpWebRequest.AllowWriteStreamBuffering" /> равно <see langword="false" />, и какое-либо одно из значений <see cref="P:System.Net.HttpWebRequest.ContentLength" /> равно –1, <see cref="P:System.Net.HttpWebRequest.SendChunked" /> равно <see langword="false" />, или <see cref="P:System.Net.HttpWebRequest.Method" /> равно POST или PUT.  
		/// -или- 
		/// Запрос <see cref="T:System.Net.HttpWebRequest" /> имеет тело сущности, но метод <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" /> вызывается без вызова метода <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />.  
		/// -или- 
		/// Значение <see cref="P:System.Net.HttpWebRequest.ContentLength" /> больше нуля, но приложение не записывает все обещанные данные.</exception>
		/// <exception cref="T:System.Net.WebException">
		///   <see cref="M:System.Net.HttpWebRequest.Abort" /> был вызван ранее.</exception>
		// Token: 0x060035F6 RID: 13814 RVA: 0x000BC004 File Offset: 0x000BA204
		public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
		{
			if (this.Aborted)
			{
				throw HttpWebRequest.CreateRequestAbortedException();
			}
			string transferEncoding = this.TransferEncoding;
			if (!this.sendChunked && transferEncoding != null && transferEncoding.Trim() != "")
			{
				throw new InvalidOperationException("TransferEncoding requires the SendChunked property to be set to true.");
			}
			return TaskToApm.Begin(this.RunWithTimeout<HttpWebResponse>(new Func<CancellationToken, Task<HttpWebResponse>>(this.MyGetResponseAsync)), callback, state);
		}

		/// <summary>Завершает асинхронный запрос интернет-ресурса.</summary>
		/// <param name="asyncResult">Незавершенный запрос ответа.</param>
		/// <returns>Объект <see cref="T:System.Net.WebResponse" />, содержащий ответ от интернет-ресурса.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Этот метод был вызван ранее с помощью <paramref name="asyncResult." />.  
		/// -или- 
		/// Свойство <see cref="P:System.Net.HttpWebRequest.ContentLength" /> больше 0, но данные не были записаны в поток запроса.</exception>
		/// <exception cref="T:System.Net.WebException">
		///   <see cref="M:System.Net.HttpWebRequest.Abort" /> был вызван ранее.  
		/// -или- 
		/// При обработке этого запроса возникла ошибка.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="asyncResult" /> не был возвращен текущим экземпляром из вызова <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />.</exception>
		// Token: 0x060035F7 RID: 13815 RVA: 0x000BC068 File Offset: 0x000BA268
		public override WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			WebResponse result;
			try
			{
				result = TaskToApm.End<HttpWebResponse>(asyncResult);
			}
			catch (Exception e)
			{
				throw this.GetWebException(e);
			}
			return result;
		}

		/// <summary>Завершает асинхронный запрос объекта <see cref="T:System.IO.Stream" />, используемого для записи данных, и выводит объект <see cref="T:System.Net.TransportContext" />, связанный с потоком.</summary>
		/// <param name="asyncResult">Незавершенный запрос потока.</param>
		/// <param name="context">Объект <see cref="T:System.Net.TransportContext" /> для <see cref="T:System.IO.Stream" />.</param>
		/// <returns>Объект <see cref="T:System.IO.Stream" />, используемый для записи данных запроса.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="asyncResult" /> не был возвращен текущим экземпляром из вызова <see cref="M:System.Net.HttpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Этот метод был вызван ранее с помощью <paramref name="asyncResult" />.</exception>
		/// <exception cref="T:System.IO.IOException">Запрос не завершен, и поток недоступен.</exception>
		/// <exception cref="T:System.Net.WebException">
		///   <see cref="M:System.Net.HttpWebRequest.Abort" /> был вызван ранее.  
		/// -или- 
		/// При обработке этого запроса возникла ошибка.</exception>
		// Token: 0x060035F8 RID: 13816 RVA: 0x000BC0A8 File Offset: 0x000BA2A8
		public Stream EndGetRequestStream(IAsyncResult asyncResult, out TransportContext context)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			context = null;
			return this.EndGetRequestStream(asyncResult);
		}

		/// <summary>Возвращает ответ от интернет-ресурса.</summary>
		/// <returns>Объект <see cref="T:System.Net.WebResponse" />, содержащий ответ от интернет-ресурса.</returns>
		/// <exception cref="T:System.InvalidOperationException">Поток уже используется предыдущим вызовом <see cref="M:System.Net.HttpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />  
		/// -или- 
		///  Для <see cref="P:System.Net.HttpWebRequest.TransferEncoding" /> задано значение, а <see cref="P:System.Net.HttpWebRequest.SendChunked" /> равно <see langword="false" />.</exception>
		/// <exception cref="T:System.Net.ProtocolViolationException">
		///   <see cref="P:System.Net.HttpWebRequest.Method" /> равно GET или HEAD, и либо <see cref="P:System.Net.HttpWebRequest.ContentLength" /> больше или равно нулю, либо <see cref="P:System.Net.HttpWebRequest.SendChunked" /> равно <see langword="true" />.  
		/// -или- 
		///  <see cref="P:System.Net.HttpWebRequest.KeepAlive" /> равно <see langword="true" />, <see cref="P:System.Net.HttpWebRequest.AllowWriteStreamBuffering" /> равно <see langword="false" />, <see cref="P:System.Net.HttpWebRequest.ContentLength" /> равно –1, <see cref="P:System.Net.HttpWebRequest.SendChunked" /> равно <see langword="false" />, а <see cref="P:System.Net.HttpWebRequest.Method" /> равно POST или PUT.  
		/// -или- 
		/// Запрос <see cref="T:System.Net.HttpWebRequest" /> имеет тело сущности, но метод <see cref="M:System.Net.HttpWebRequest.GetResponse" /> вызывается без вызова метода <see cref="M:System.Net.HttpWebRequest.GetRequestStream" />.  
		/// -или- 
		/// <see cref="P:System.Net.HttpWebRequest.ContentLength" /> больше нуля, но приложение не записывает все обещанные данные.</exception>
		/// <exception cref="T:System.NotSupportedException">Проверяющий элемент управления кэша запросов указывает, что ответ на этот запрос может быть предоставлен из кэша. Однако этот запрос содержит данные, которые будут отправлены на сервер. Запросы, отправляющие данные, не должны использовать кэш. Это исключение может возникнуть при использовании настраиваемого проверяющего элемента управления кэша, который неправильно реализован.</exception>
		/// <exception cref="T:System.Net.WebException">
		///   <see cref="M:System.Net.HttpWebRequest.Abort" /> был вызван ранее.  
		/// -или- 
		/// Истекло время ожидания для запроса.  
		/// -или- 
		/// При обработке этого запроса возникла ошибка.</exception>
		// Token: 0x060035F9 RID: 13817 RVA: 0x000BC0C4 File Offset: 0x000BA2C4
		public override WebResponse GetResponse()
		{
			WebResponse result;
			try
			{
				result = this.GetResponseAsync().Result;
			}
			catch (Exception e)
			{
				throw this.GetWebException(e);
			}
			return result;
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x060035FA RID: 13818 RVA: 0x000BC0FC File Offset: 0x000BA2FC
		// (set) Token: 0x060035FB RID: 13819 RVA: 0x000BC104 File Offset: 0x000BA304
		internal bool FinishedReading
		{
			get
			{
				return this.finished_reading;
			}
			set
			{
				this.finished_reading = value;
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x060035FC RID: 13820 RVA: 0x000BC10D File Offset: 0x000BA30D
		internal bool Aborted
		{
			get
			{
				return Interlocked.CompareExchange(ref this.aborted, 0, 0) == 1;
			}
		}

		/// <summary>Отменяет запрос к интернет-ресурсу.</summary>
		// Token: 0x060035FD RID: 13821 RVA: 0x000BC120 File Offset: 0x000BA320
		public override void Abort()
		{
			if (Interlocked.CompareExchange(ref this.aborted, 1, 0) == 1)
			{
				return;
			}
			this.haveResponse = true;
			WebOperation webOperation = this.currentOperation;
			if (webOperation != null)
			{
				webOperation.Abort();
			}
			WebCompletionSource webCompletionSource = this.responseTask;
			if (webCompletionSource != null)
			{
				webCompletionSource.TrySetCanceled();
			}
			if (this.webResponse != null)
			{
				try
				{
					this.webResponse.Close();
					this.webResponse = null;
				}
				catch
				{
				}
			}
		}

		/// <summary>Заполняет объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации целевого объекта.</summary>
		/// <param name="serializationInfo">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> для заполнения данными.</param>
		/// <param name="streamingContext">Контекст <see cref="T:System.Runtime.Serialization.StreamingContext" />, определяющий целевой объект сериализации.</param>
		// Token: 0x060035FE RID: 13822 RVA: 0x000BC198 File Offset: 0x000BA398
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw new SerializationException();
		}

		/// <summary>Заполняет объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации целевого объекта.</summary>
		/// <param name="serializationInfo">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> для заполнения данными.</param>
		/// <param name="streamingContext">Контекст <see cref="T:System.Runtime.Serialization.StreamingContext" />, определяющий целевой объект сериализации.</param>
		// Token: 0x060035FF RID: 13823 RVA: 0x000BC198 File Offset: 0x000BA398
		[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw new SerializationException();
		}

		// Token: 0x06003600 RID: 13824 RVA: 0x000BC19F File Offset: 0x000BA39F
		private void CheckRequestStarted()
		{
			if (this.requestSent)
			{
				throw new InvalidOperationException("request started");
			}
		}

		// Token: 0x06003601 RID: 13825 RVA: 0x000BC1B4 File Offset: 0x000BA3B4
		internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers)
		{
			if (this.continueDelegate != null)
			{
				this.continueDelegate(statusCode, headers);
			}
		}

		// Token: 0x06003602 RID: 13826 RVA: 0x000BC1CB File Offset: 0x000BA3CB
		private void RewriteRedirectToGet()
		{
			this.method = "GET";
			this.webHeaders.RemoveInternal("Transfer-Encoding");
			this.sendChunked = false;
		}

		// Token: 0x06003603 RID: 13827 RVA: 0x000BC1F0 File Offset: 0x000BA3F0
		private bool Redirect(HttpStatusCode code, WebResponse response)
		{
			this.redirects++;
			Exception ex = null;
			string text = null;
			switch (code)
			{
			case HttpStatusCode.MultipleChoices:
				ex = new WebException("Ambiguous redirect.");
				goto IL_97;
			case HttpStatusCode.MovedPermanently:
			case HttpStatusCode.Found:
				if (this.method == "POST")
				{
					this.RewriteRedirectToGet();
					goto IL_97;
				}
				goto IL_97;
			case HttpStatusCode.SeeOther:
				this.RewriteRedirectToGet();
				goto IL_97;
			case HttpStatusCode.NotModified:
				return false;
			case HttpStatusCode.UseProxy:
				ex = new NotImplementedException("Proxy support not available.");
				goto IL_97;
			case HttpStatusCode.TemporaryRedirect:
				goto IL_97;
			}
			string str = "Invalid status code: ";
			int num = (int)code;
			ex = new ProtocolViolationException(str + num.ToString());
			IL_97:
			if (this.method != "GET" && !this.InternalAllowBuffering && this.ResendContentFactory == null && (this.writeStream.WriteBufferLength > 0 || this.contentLength > 0L))
			{
				ex = new WebException("The request requires buffering data to succeed.", null, WebExceptionStatus.ProtocolError, response);
			}
			if (ex != null)
			{
				throw ex;
			}
			if (this.AllowWriteStreamBuffering || this.method == "GET")
			{
				this.contentLength = -1L;
			}
			text = response.Headers["Location"];
			if (text == null)
			{
				throw new WebException(string.Format("No Location header found for {0}", (int)code), null, WebExceptionStatus.ProtocolError, response);
			}
			Uri uri = this.actualUri;
			try
			{
				this.actualUri = new Uri(this.actualUri, text);
			}
			catch (Exception)
			{
				throw new WebException(string.Format("Invalid URL ({0}) for {1}", text, (int)code), null, WebExceptionStatus.ProtocolError, response);
			}
			this.hostChanged = (this.actualUri.Scheme != uri.Scheme || this.Host != uri.Authority);
			return true;
		}

		// Token: 0x06003604 RID: 13828 RVA: 0x000BC3AC File Offset: 0x000BA5AC
		private string GetHeaders()
		{
			bool flag = false;
			if (this.sendChunked)
			{
				flag = true;
				this.webHeaders.ChangeInternal("Transfer-Encoding", "chunked");
				this.webHeaders.RemoveInternal("Content-Length");
			}
			else if (this.contentLength != -1L)
			{
				if (this.auth_state.NtlmAuthState == HttpWebRequest.NtlmAuthState.Challenge || this.proxy_auth_state.NtlmAuthState == HttpWebRequest.NtlmAuthState.Challenge)
				{
					if (this.haveContentLength || this.gotRequestStream || this.contentLength > 0L)
					{
						this.webHeaders.SetInternal("Content-Length", "0");
					}
					else
					{
						this.webHeaders.RemoveInternal("Content-Length");
					}
				}
				else
				{
					if (this.contentLength > 0L)
					{
						flag = true;
					}
					if (this.haveContentLength || this.gotRequestStream || this.contentLength > 0L)
					{
						this.webHeaders.SetInternal("Content-Length", this.contentLength.ToString());
					}
				}
				this.webHeaders.RemoveInternal("Transfer-Encoding");
			}
			else
			{
				this.webHeaders.RemoveInternal("Content-Length");
			}
			if (this.actualVersion == HttpVersion.Version11 && flag && this.servicePoint.SendContinue)
			{
				this.webHeaders.ChangeInternal("Expect", "100-continue");
				this.expectContinue = true;
			}
			else
			{
				this.webHeaders.RemoveInternal("Expect");
				this.expectContinue = false;
			}
			bool proxyQuery = this.ProxyQuery;
			string name = proxyQuery ? "Proxy-Connection" : "Connection";
			this.webHeaders.RemoveInternal((!proxyQuery) ? "Proxy-Connection" : "Connection");
			Version protocolVersion = this.servicePoint.ProtocolVersion;
			bool flag2 = protocolVersion == null || protocolVersion == HttpVersion.Version10;
			if (this.keepAlive && (this.version == HttpVersion.Version10 || flag2))
			{
				if (this.webHeaders[name] == null || this.webHeaders[name].IndexOf("keep-alive", StringComparison.OrdinalIgnoreCase) == -1)
				{
					this.webHeaders.ChangeInternal(name, "keep-alive");
				}
			}
			else if (!this.keepAlive && this.version == HttpVersion.Version11)
			{
				this.webHeaders.ChangeInternal(name, "close");
			}
			string components;
			if (this.hostUri != null)
			{
				if (this.hostHasPort)
				{
					components = this.hostUri.GetComponents(UriComponents.HostAndPort, UriFormat.Unescaped);
				}
				else
				{
					components = this.hostUri.GetComponents(UriComponents.Host, UriFormat.Unescaped);
				}
			}
			else if (this.Address.IsDefaultPort)
			{
				components = this.Address.GetComponents(UriComponents.Host, UriFormat.Unescaped);
			}
			else
			{
				components = this.Address.GetComponents(UriComponents.HostAndPort, UriFormat.Unescaped);
			}
			this.webHeaders.SetInternal("Host", components);
			if (this.cookieContainer != null)
			{
				string cookieHeader = this.cookieContainer.GetCookieHeader(this.actualUri);
				if (cookieHeader != "")
				{
					this.webHeaders.ChangeInternal("Cookie", cookieHeader);
				}
				else
				{
					this.webHeaders.RemoveInternal("Cookie");
				}
			}
			string text = null;
			if ((this.auto_decomp & DecompressionMethods.GZip) != DecompressionMethods.None)
			{
				text = "gzip";
			}
			if ((this.auto_decomp & DecompressionMethods.Deflate) != DecompressionMethods.None)
			{
				text = ((text != null) ? "gzip, deflate" : "deflate");
			}
			if (text != null)
			{
				this.webHeaders.ChangeInternal("Accept-Encoding", text);
			}
			if (!this.usedPreAuth && this.preAuthenticate)
			{
				this.DoPreAuthenticate();
			}
			return this.webHeaders.ToString();
		}

		// Token: 0x06003605 RID: 13829 RVA: 0x000BC720 File Offset: 0x000BA920
		private void DoPreAuthenticate()
		{
			bool flag = this.proxy != null && !this.proxy.IsBypassed(this.actualUri);
			ICredentials credentials = (!flag || this.credentials != null) ? this.credentials : this.proxy.Credentials;
			Authorization authorization = AuthenticationManager.PreAuthenticate(this, credentials);
			if (authorization == null)
			{
				return;
			}
			this.webHeaders.RemoveInternal("Proxy-Authorization");
			this.webHeaders.RemoveInternal("Authorization");
			string name = (flag && this.credentials == null) ? "Proxy-Authorization" : "Authorization";
			this.webHeaders[name] = authorization.Message;
			this.usedPreAuth = true;
		}

		// Token: 0x06003606 RID: 13830 RVA: 0x000BC7CC File Offset: 0x000BA9CC
		internal byte[] GetRequestHeaders()
		{
			StringBuilder stringBuilder = new StringBuilder();
			string text;
			if (!this.ProxyQuery)
			{
				text = this.actualUri.PathAndQuery;
			}
			else
			{
				text = string.Format("{0}://{1}{2}", this.actualUri.Scheme, this.Host, this.actualUri.PathAndQuery);
			}
			if (!this.force_version && this.servicePoint.ProtocolVersion != null && this.servicePoint.ProtocolVersion < this.version)
			{
				this.actualVersion = this.servicePoint.ProtocolVersion;
			}
			else
			{
				this.actualVersion = this.version;
			}
			stringBuilder.AppendFormat("{0} {1} HTTP/{2}.{3}\r\n", new object[]
			{
				this.method,
				text,
				this.actualVersion.Major,
				this.actualVersion.Minor
			});
			stringBuilder.Append(this.GetHeaders());
			string s = stringBuilder.ToString();
			return Encoding.UTF8.GetBytes(s);
		}

		// Token: 0x06003607 RID: 13831 RVA: 0x000BC8D4 File Offset: 0x000BAAD4
		private ValueTuple<WebOperation, bool> HandleNtlmAuth(WebResponseStream stream, HttpWebResponse response, BufferOffsetSize writeBuffer, CancellationToken cancellationToken)
		{
			bool flag = response.StatusCode == HttpStatusCode.ProxyAuthenticationRequired;
			if ((flag ? this.proxy_auth_state : this.auth_state).NtlmAuthState == HttpWebRequest.NtlmAuthState.None)
			{
				return new ValueTuple<WebOperation, bool>(null, false);
			}
			bool flag2 = this.auth_state.NtlmAuthState == HttpWebRequest.NtlmAuthState.Challenge || this.proxy_auth_state.NtlmAuthState == HttpWebRequest.NtlmAuthState.Challenge;
			WebOperation webOperation = new WebOperation(this, writeBuffer, flag2, cancellationToken);
			stream.Operation.SetPriorityRequest(webOperation);
			ICredentials credentials = (!flag || this.proxy == null) ? this.credentials : this.proxy.Credentials;
			if (credentials != null)
			{
				stream.Connection.NtlmCredential = credentials.GetCredential(this.requestUri, "NTLM");
				stream.Connection.UnsafeAuthenticatedConnectionSharing = this.unsafe_auth_blah;
			}
			return new ValueTuple<WebOperation, bool>(webOperation, flag2);
		}

		// Token: 0x06003608 RID: 13832 RVA: 0x000BC9A0 File Offset: 0x000BABA0
		private bool CheckAuthorization(WebResponse response, HttpStatusCode code)
		{
			if (code != HttpStatusCode.ProxyAuthenticationRequired)
			{
				return this.auth_state.CheckAuthorization(response, code);
			}
			return this.proxy_auth_state.CheckAuthorization(response, code);
		}

		// Token: 0x06003609 RID: 13833 RVA: 0x000BC9C8 File Offset: 0x000BABC8
		[return: TupleElementNames(new string[]
		{
			"task",
			"throwMe"
		})]
		private ValueTuple<Task<BufferOffsetSize>, WebException> GetRewriteHandler(HttpWebResponse response, bool redirect)
		{
			if (redirect)
			{
				if (!this.MethodWithBuffer)
				{
					return new ValueTuple<Task<BufferOffsetSize>, WebException>(null, null);
				}
				if (this.writeStream.WriteBufferLength == 0 || this.contentLength == 0L)
				{
					return new ValueTuple<Task<BufferOffsetSize>, WebException>(null, null);
				}
			}
			if (this.AllowWriteStreamBuffering)
			{
				return new ValueTuple<Task<BufferOffsetSize>, WebException>(Task.FromResult<BufferOffsetSize>(this.writeStream.GetWriteBuffer()), null);
			}
			if (this.ResendContentFactory == null)
			{
				return new ValueTuple<Task<BufferOffsetSize>, WebException>(null, new WebException("The request requires buffering data to succeed.", null, WebExceptionStatus.ProtocolError, response));
			}
			return new ValueTuple<Task<BufferOffsetSize>, WebException>(delegate
			{
				HttpWebRequest.<<GetRewriteHandler>b__274_0>d <<GetRewriteHandler>b__274_0>d;
				<<GetRewriteHandler>b__274_0>d.<>4__this = this;
				<<GetRewriteHandler>b__274_0>d.<>t__builder = AsyncTaskMethodBuilder<BufferOffsetSize>.Create();
				<<GetRewriteHandler>b__274_0>d.<>1__state = -1;
				<<GetRewriteHandler>b__274_0>d.<>t__builder.Start<HttpWebRequest.<<GetRewriteHandler>b__274_0>d>(ref <<GetRewriteHandler>b__274_0>d);
				return <<GetRewriteHandler>b__274_0>d.<>t__builder.Task;
			}(), null);
		}

		// Token: 0x0600360A RID: 13834 RVA: 0x000BCA58 File Offset: 0x000BAC58
		[return: TupleElementNames(new string[]
		{
			"redirect",
			"mustReadAll",
			"writeBuffer",
			"throwMe"
		})]
		private ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException> CheckFinalStatus(HttpWebResponse response)
		{
			WebException ex = null;
			bool item = false;
			Task<BufferOffsetSize> item2 = null;
			HttpStatusCode statusCode = response.StatusCode;
			if (((!this.auth_state.IsCompleted && statusCode == HttpStatusCode.Unauthorized && this.credentials != null) || (this.ProxyQuery && !this.proxy_auth_state.IsCompleted && statusCode == HttpStatusCode.ProxyAuthenticationRequired)) && !this.usedPreAuth && this.CheckAuthorization(response, statusCode))
			{
				item = true;
				if (!this.MethodWithBuffer)
				{
					return new ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>(true, item, null, null);
				}
				ValueTuple<Task<BufferOffsetSize>, WebException> rewriteHandler = this.GetRewriteHandler(response, false);
				item2 = rewriteHandler.Item1;
				ex = rewriteHandler.Item2;
				if (ex == null)
				{
					return new ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>(true, item, item2, null);
				}
				if (!this.ThrowOnError)
				{
					return new ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>(false, item, null, null);
				}
				this.writeStream.InternalClose();
				this.writeStream = null;
				response.Close();
				return new ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>(false, item, null, ex);
			}
			else
			{
				if (statusCode >= HttpStatusCode.BadRequest)
				{
					ex = new WebException(string.Format("The remote server returned an error: ({0}) {1}.", (int)statusCode, response.StatusDescription), null, WebExceptionStatus.ProtocolError, response);
					item = true;
				}
				else if (statusCode == HttpStatusCode.NotModified && this.allowAutoRedirect)
				{
					ex = new WebException(string.Format("The remote server returned an error: ({0}) {1}.", (int)statusCode, response.StatusDescription), null, WebExceptionStatus.ProtocolError, response);
				}
				else if (statusCode >= HttpStatusCode.MultipleChoices && this.allowAutoRedirect && this.redirects >= this.maxAutoRedirect)
				{
					ex = new WebException("Max. redirections exceeded.", null, WebExceptionStatus.ProtocolError, response);
					item = true;
				}
				if (ex == null)
				{
					int num = (int)statusCode;
					bool flag = false;
					if (this.allowAutoRedirect && num >= 300)
					{
						flag = this.Redirect(statusCode, response);
						ValueTuple<Task<BufferOffsetSize>, WebException> rewriteHandler2 = this.GetRewriteHandler(response, true);
						item2 = rewriteHandler2.Item1;
						ex = rewriteHandler2.Item2;
						if (flag && !this.unsafe_auth_blah)
						{
							this.auth_state.Reset();
							this.proxy_auth_state.Reset();
						}
					}
					if (num >= 300 && num != 304)
					{
						item = true;
					}
					if (ex == null)
					{
						return new ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>(flag, item, item2, null);
					}
				}
				if (!this.ThrowOnError)
				{
					return new ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>(false, item, null, null);
				}
				if (this.writeStream != null)
				{
					this.writeStream.InternalClose();
					this.writeStream = null;
				}
				return new ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>(false, item, null, ex);
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x0600360B RID: 13835 RVA: 0x000BCC6C File Offset: 0x000BAE6C
		// (set) Token: 0x0600360C RID: 13836 RVA: 0x000BCC74 File Offset: 0x000BAE74
		internal bool ReuseConnection { get; set; }

		// Token: 0x0600360D RID: 13837 RVA: 0x000BCC80 File Offset: 0x000BAE80
		internal static StringBuilder GenerateConnectionGroup(string connectionGroupName, bool unsafeConnectionGroup, bool isInternalGroup)
		{
			StringBuilder stringBuilder = new StringBuilder(connectionGroupName);
			stringBuilder.Append(unsafeConnectionGroup ? "U>" : "S>");
			if (isInternalGroup)
			{
				stringBuilder.Append("I>");
			}
			return stringBuilder;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.HttpWebRequest" />. Этот конструктор является устаревшим.</summary>
		// Token: 0x06003610 RID: 13840 RVA: 0x00013BCA File Offset: 0x00011DCA
		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public HttpWebRequest()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04001F1B RID: 7963
		private Uri requestUri;

		// Token: 0x04001F1C RID: 7964
		private Uri actualUri;

		// Token: 0x04001F1D RID: 7965
		private bool hostChanged;

		// Token: 0x04001F1E RID: 7966
		private bool allowAutoRedirect;

		// Token: 0x04001F1F RID: 7967
		private bool allowBuffering;

		// Token: 0x04001F20 RID: 7968
		private bool allowReadStreamBuffering;

		// Token: 0x04001F21 RID: 7969
		private X509CertificateCollection certificates;

		// Token: 0x04001F22 RID: 7970
		private string connectionGroup;

		// Token: 0x04001F23 RID: 7971
		private bool haveContentLength;

		// Token: 0x04001F24 RID: 7972
		private long contentLength;

		// Token: 0x04001F25 RID: 7973
		private HttpContinueDelegate continueDelegate;

		// Token: 0x04001F26 RID: 7974
		private CookieContainer cookieContainer;

		// Token: 0x04001F27 RID: 7975
		private ICredentials credentials;

		// Token: 0x04001F28 RID: 7976
		private bool haveResponse;

		// Token: 0x04001F29 RID: 7977
		private bool requestSent;

		// Token: 0x04001F2A RID: 7978
		private WebHeaderCollection webHeaders;

		// Token: 0x04001F2B RID: 7979
		private bool keepAlive;

		// Token: 0x04001F2C RID: 7980
		private int maxAutoRedirect;

		// Token: 0x04001F2D RID: 7981
		private string mediaType;

		// Token: 0x04001F2E RID: 7982
		private string method;

		// Token: 0x04001F2F RID: 7983
		private string initialMethod;

		// Token: 0x04001F30 RID: 7984
		private bool pipelined;

		// Token: 0x04001F31 RID: 7985
		private bool preAuthenticate;

		// Token: 0x04001F32 RID: 7986
		private bool usedPreAuth;

		// Token: 0x04001F33 RID: 7987
		private Version version;

		// Token: 0x04001F34 RID: 7988
		private bool force_version;

		// Token: 0x04001F35 RID: 7989
		private Version actualVersion;

		// Token: 0x04001F36 RID: 7990
		private IWebProxy proxy;

		// Token: 0x04001F37 RID: 7991
		private bool sendChunked;

		// Token: 0x04001F38 RID: 7992
		private ServicePoint servicePoint;

		// Token: 0x04001F39 RID: 7993
		private int timeout;

		// Token: 0x04001F3A RID: 7994
		private int continueTimeout;

		// Token: 0x04001F3B RID: 7995
		private WebRequestStream writeStream;

		// Token: 0x04001F3C RID: 7996
		private HttpWebResponse webResponse;

		// Token: 0x04001F3D RID: 7997
		private WebCompletionSource responseTask;

		// Token: 0x04001F3E RID: 7998
		private WebOperation currentOperation;

		// Token: 0x04001F3F RID: 7999
		private int aborted;

		// Token: 0x04001F40 RID: 8000
		private bool gotRequestStream;

		// Token: 0x04001F41 RID: 8001
		private int redirects;

		// Token: 0x04001F42 RID: 8002
		private bool expectContinue;

		// Token: 0x04001F43 RID: 8003
		private bool getResponseCalled;

		// Token: 0x04001F44 RID: 8004
		private object locker;

		// Token: 0x04001F45 RID: 8005
		private bool finished_reading;

		// Token: 0x04001F46 RID: 8006
		private DecompressionMethods auto_decomp;

		// Token: 0x04001F47 RID: 8007
		private int maxResponseHeadersLength;

		// Token: 0x04001F48 RID: 8008
		private static int defaultMaxResponseHeadersLength = 64;

		// Token: 0x04001F49 RID: 8009
		private static int defaultMaximumErrorResponseLength = 64;

		// Token: 0x04001F4A RID: 8010
		private static RequestCachePolicy defaultCachePolicy = new RequestCachePolicy(RequestCacheLevel.BypassCache);

		// Token: 0x04001F4B RID: 8011
		private int readWriteTimeout;

		// Token: 0x04001F4C RID: 8012
		private MobileTlsProvider tlsProvider;

		// Token: 0x04001F4D RID: 8013
		private MonoTlsSettings tlsSettings;

		// Token: 0x04001F4E RID: 8014
		private ServerCertValidationCallback certValidationCallback;

		// Token: 0x04001F4F RID: 8015
		private bool hostHasPort;

		// Token: 0x04001F50 RID: 8016
		private Uri hostUri;

		// Token: 0x04001F51 RID: 8017
		private HttpWebRequest.AuthorizationState auth_state;

		// Token: 0x04001F52 RID: 8018
		private HttpWebRequest.AuthorizationState proxy_auth_state;

		// Token: 0x04001F53 RID: 8019
		[NonSerialized]
		internal Func<Stream, Task> ResendContentFactory;

		// Token: 0x04001F54 RID: 8020
		internal readonly int ID;

		// Token: 0x04001F56 RID: 8022
		private bool unsafe_auth_blah;

		// Token: 0x02000695 RID: 1685
		private enum NtlmAuthState
		{
			// Token: 0x04001F59 RID: 8025
			None,
			// Token: 0x04001F5A RID: 8026
			Challenge,
			// Token: 0x04001F5B RID: 8027
			Response
		}

		// Token: 0x02000696 RID: 1686
		private struct AuthorizationState
		{
			// Token: 0x17000B26 RID: 2854
			// (get) Token: 0x06003611 RID: 13841 RVA: 0x000BCD07 File Offset: 0x000BAF07
			public bool IsCompleted
			{
				get
				{
					return this.isCompleted;
				}
			}

			// Token: 0x17000B27 RID: 2855
			// (get) Token: 0x06003612 RID: 13842 RVA: 0x000BCD0F File Offset: 0x000BAF0F
			public HttpWebRequest.NtlmAuthState NtlmAuthState
			{
				get
				{
					return this.ntlm_auth_state;
				}
			}

			// Token: 0x17000B28 RID: 2856
			// (get) Token: 0x06003613 RID: 13843 RVA: 0x000BCD17 File Offset: 0x000BAF17
			public bool IsNtlmAuthenticated
			{
				get
				{
					return this.isCompleted && this.ntlm_auth_state > HttpWebRequest.NtlmAuthState.None;
				}
			}

			// Token: 0x06003614 RID: 13844 RVA: 0x000BCD2C File Offset: 0x000BAF2C
			public AuthorizationState(HttpWebRequest request, bool isProxy)
			{
				this.request = request;
				this.isProxy = isProxy;
				this.isCompleted = false;
				this.ntlm_auth_state = HttpWebRequest.NtlmAuthState.None;
			}

			// Token: 0x06003615 RID: 13845 RVA: 0x000BCD4C File Offset: 0x000BAF4C
			public bool CheckAuthorization(WebResponse response, HttpStatusCode code)
			{
				this.isCompleted = false;
				if (code == HttpStatusCode.Unauthorized && this.request.credentials == null)
				{
					return false;
				}
				if (this.isProxy != (code == HttpStatusCode.ProxyAuthenticationRequired))
				{
					return false;
				}
				if (this.isProxy && (this.request.proxy == null || this.request.proxy.Credentials == null))
				{
					return false;
				}
				string[] values = response.Headers.GetValues(this.isProxy ? "Proxy-Authenticate" : "WWW-Authenticate");
				if (values == null || values.Length == 0)
				{
					return false;
				}
				ICredentials credentials = (!this.isProxy) ? this.request.credentials : this.request.proxy.Credentials;
				Authorization authorization = null;
				string[] array = values;
				for (int i = 0; i < array.Length; i++)
				{
					authorization = AuthenticationManager.Authenticate(array[i], this.request, credentials);
					if (authorization != null)
					{
						break;
					}
				}
				if (authorization == null)
				{
					return false;
				}
				this.request.webHeaders[this.isProxy ? "Proxy-Authorization" : "Authorization"] = authorization.Message;
				this.isCompleted = authorization.Complete;
				if (authorization.ModuleAuthenticationType == "NTLM")
				{
					this.ntlm_auth_state++;
				}
				return true;
			}

			// Token: 0x06003616 RID: 13846 RVA: 0x000BCE87 File Offset: 0x000BB087
			public void Reset()
			{
				this.isCompleted = false;
				this.ntlm_auth_state = HttpWebRequest.NtlmAuthState.None;
				this.request.webHeaders.RemoveInternal(this.isProxy ? "Proxy-Authorization" : "Authorization");
			}

			// Token: 0x06003617 RID: 13847 RVA: 0x000BCEBB File Offset: 0x000BB0BB
			public override string ToString()
			{
				return string.Format("{0}AuthState [{1}:{2}]", this.isProxy ? "Proxy" : "", this.isCompleted, this.ntlm_auth_state);
			}

			// Token: 0x04001F5C RID: 8028
			private readonly HttpWebRequest request;

			// Token: 0x04001F5D RID: 8029
			private readonly bool isProxy;

			// Token: 0x04001F5E RID: 8030
			private bool isCompleted;

			// Token: 0x04001F5F RID: 8031
			private HttpWebRequest.NtlmAuthState ntlm_auth_state;
		}
	}
}
