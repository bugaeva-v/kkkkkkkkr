using System;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace System.Net
{
	/// <summary>Описывает входящий HTTP-запрос для объекта <see cref="T:System.Net.HttpListener" />. Этот класс не наследуется.</summary>
	// Token: 0x0200068D RID: 1677
	public sealed class HttpListenerRequest
	{
		// Token: 0x060034FC RID: 13564 RVA: 0x000B923A File Offset: 0x000B743A
		internal HttpListenerRequest(HttpListenerContext context)
		{
			this.context = context;
			this.headers = new WebHeaderCollection();
			this.version = HttpVersion.Version10;
		}

		// Token: 0x060034FD RID: 13565 RVA: 0x000B9260 File Offset: 0x000B7460
		internal void SetRequestLine(string req)
		{
			string[] array = req.Split(HttpListenerRequest.separators, 3);
			if (array.Length != 3)
			{
				this.context.ErrorMessage = "Invalid request line (parts).";
				return;
			}
			this.method = array[0];
			foreach (char c in this.method)
			{
				int num = (int)c;
				if ((num < 65 || num > 90) && (num <= 32 || c >= '\u007f' || c == '(' || c == ')' || c == '<' || c == '<' || c == '>' || c == '@' || c == ',' || c == ';' || c == ':' || c == '\\' || c == '"' || c == '/' || c == '[' || c == ']' || c == '?' || c == '=' || c == '{' || c == '}'))
				{
					this.context.ErrorMessage = "(Invalid verb)";
					return;
				}
			}
			this.raw_url = array[1];
			if (array[2].Length != 8 || !array[2].StartsWith("HTTP/"))
			{
				this.context.ErrorMessage = "Invalid request line (version).";
				return;
			}
			try
			{
				this.version = new Version(array[2].Substring(5));
				if (this.version.Major < 1)
				{
					throw new Exception();
				}
			}
			catch
			{
				this.context.ErrorMessage = "Invalid request line (version).";
			}
		}

		// Token: 0x060034FE RID: 13566 RVA: 0x000B93C8 File Offset: 0x000B75C8
		private void CreateQueryString(string query)
		{
			if (query == null || query.Length == 0)
			{
				this.query_string = new NameValueCollection(1);
				return;
			}
			this.query_string = new NameValueCollection();
			if (query[0] == '?')
			{
				query = query.Substring(1);
			}
			foreach (string text in query.Split('&', StringSplitOptions.None))
			{
				int num = text.IndexOf('=');
				if (num == -1)
				{
					this.query_string.Add(null, WebUtility.UrlDecode(text));
				}
				else
				{
					string name = WebUtility.UrlDecode(text.Substring(0, num));
					string value = WebUtility.UrlDecode(text.Substring(num + 1));
					this.query_string.Add(name, value);
				}
			}
		}

		// Token: 0x060034FF RID: 13567 RVA: 0x000B9478 File Offset: 0x000B7678
		private static bool MaybeUri(string s)
		{
			int num = s.IndexOf(':');
			return num != -1 && num < 10 && HttpListenerRequest.IsPredefinedScheme(s.Substring(0, num));
		}

		// Token: 0x06003500 RID: 13568 RVA: 0x000B94A8 File Offset: 0x000B76A8
		private static bool IsPredefinedScheme(string scheme)
		{
			if (scheme == null || scheme.Length < 3)
			{
				return false;
			}
			char c = scheme[0];
			if (c == 'h')
			{
				return scheme == "http" || scheme == "https";
			}
			if (c == 'f')
			{
				return scheme == "file" || scheme == "ftp";
			}
			if (c != 'n')
			{
				return (c == 'g' && scheme == "gopher") || (c == 'm' && scheme == "mailto");
			}
			c = scheme[1];
			if (c == 'e')
			{
				return scheme == "news" || scheme == "net.pipe" || scheme == "net.tcp";
			}
			return scheme == "nntp";
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x000B9580 File Offset: 0x000B7780
		internal bool FinishInitialization()
		{
			string text = this.UserHostName;
			if (this.version > HttpVersion.Version10 && (text == null || text.Length == 0))
			{
				this.context.ErrorMessage = "Invalid host name";
				return true;
			}
			Uri uri = null;
			string pathAndQuery;
			if (HttpListenerRequest.MaybeUri(this.raw_url.ToLowerInvariant()) && Uri.TryCreate(this.raw_url, UriKind.Absolute, out uri))
			{
				pathAndQuery = uri.PathAndQuery;
			}
			else
			{
				pathAndQuery = this.raw_url;
			}
			if (text == null || text.Length == 0)
			{
				text = this.UserHostAddress;
			}
			if (uri != null)
			{
				text = uri.Host;
			}
			int num = text.IndexOf(':');
			if (num >= 0)
			{
				text = text.Substring(0, num);
			}
			string text2 = string.Format("{0}://{1}:{2}", this.IsSecureConnection ? "https" : "http", text, this.LocalEndPoint.Port);
			if (!Uri.TryCreate(text2 + pathAndQuery, UriKind.Absolute, out this.url))
			{
				this.context.ErrorMessage = WebUtility.HtmlEncode("Invalid url: " + text2 + pathAndQuery);
				return true;
			}
			this.CreateQueryString(this.url.Query);
			this.url = HttpListenerRequestUriBuilder.GetRequestUri(this.raw_url, this.url.Scheme, this.url.Authority, this.url.LocalPath, this.url.Query);
			if (this.version >= HttpVersion.Version11)
			{
				string text3 = this.Headers["Transfer-Encoding"];
				this.is_chunked = (text3 != null && string.Compare(text3, "chunked", StringComparison.OrdinalIgnoreCase) == 0);
				if (text3 != null && !this.is_chunked)
				{
					this.context.Connection.SendError(null, 501);
					return false;
				}
			}
			if (!this.is_chunked && !this.cl_set && (string.Compare(this.method, "POST", StringComparison.OrdinalIgnoreCase) == 0 || string.Compare(this.method, "PUT", StringComparison.OrdinalIgnoreCase) == 0))
			{
				this.context.Connection.SendError(null, 411);
				return false;
			}
			if (string.Compare(this.Headers["Expect"], "100-continue", StringComparison.OrdinalIgnoreCase) == 0)
			{
				this.context.Connection.GetResponseStream().InternalWrite(HttpListenerRequest._100continue, 0, HttpListenerRequest._100continue.Length);
			}
			return true;
		}

		// Token: 0x06003502 RID: 13570 RVA: 0x000B97D8 File Offset: 0x000B79D8
		internal static string Unquote(string str)
		{
			int num = str.IndexOf('"');
			int num2 = str.LastIndexOf('"');
			if (num >= 0 && num2 >= 0)
			{
				str = str.Substring(num + 1, num2 - 1);
			}
			return str.Trim();
		}

		// Token: 0x06003503 RID: 13571 RVA: 0x000B9814 File Offset: 0x000B7A14
		internal void AddHeader(string header)
		{
			int num = header.IndexOf(':');
			if (num == -1 || num == 0)
			{
				this.context.ErrorMessage = "Bad Request";
				this.context.ErrorStatus = 400;
				return;
			}
			string text = header.Substring(0, num).Trim();
			string text2 = header.Substring(num + 1).Trim();
			string a = text.ToLower(CultureInfo.InvariantCulture);
			this.headers.SetInternal(text, text2);
			if (a == "accept-language")
			{
				this.user_languages = text2.Split(',', StringSplitOptions.None);
				return;
			}
			if (!(a == "accept"))
			{
				if (!(a == "content-length"))
				{
					if (!(a == "referer"))
					{
						if (!(a == "cookie"))
						{
							return;
						}
						goto IL_142;
					}
				}
				else
				{
					try
					{
						this.content_length = long.Parse(text2.Trim());
						if (this.content_length < 0L)
						{
							this.context.ErrorMessage = "Invalid Content-Length.";
						}
						this.cl_set = true;
						return;
					}
					catch
					{
						this.context.ErrorMessage = "Invalid Content-Length.";
						return;
					}
				}
				try
				{
					this.referrer = new Uri(text2);
					return;
				}
				catch
				{
					this.referrer = new Uri("http://someone.is.screwing.with.the.headers.com/");
					return;
				}
				IL_142:
				if (this.cookies == null)
				{
					this.cookies = new CookieCollection();
				}
				string[] array = text2.Split(new char[]
				{
					',',
					';'
				});
				Cookie cookie = null;
				int num2 = 0;
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					string text3 = array2[i].Trim();
					if (text3.Length != 0)
					{
						if (text3.StartsWith("$Version"))
						{
							num2 = int.Parse(HttpListenerRequest.Unquote(text3.Substring(text3.IndexOf('=') + 1)));
						}
						else if (text3.StartsWith("$Path"))
						{
							if (cookie != null)
							{
								cookie.Path = text3.Substring(text3.IndexOf('=') + 1).Trim();
							}
						}
						else if (text3.StartsWith("$Domain"))
						{
							if (cookie != null)
							{
								cookie.Domain = text3.Substring(text3.IndexOf('=') + 1).Trim();
							}
						}
						else if (text3.StartsWith("$Port"))
						{
							if (cookie != null)
							{
								cookie.Port = text3.Substring(text3.IndexOf('=') + 1).Trim();
							}
						}
						else
						{
							if (cookie != null)
							{
								this.cookies.Add(cookie);
							}
							try
							{
								cookie = new Cookie();
								int num3 = text3.IndexOf('=');
								if (num3 > 0)
								{
									cookie.Name = text3.Substring(0, num3).Trim();
									cookie.Value = text3.Substring(num3 + 1).Trim();
								}
								else
								{
									cookie.Name = text3.Trim();
									cookie.Value = string.Empty;
								}
								cookie.Version = num2;
							}
							catch (CookieException)
							{
								cookie = null;
							}
						}
					}
				}
				if (cookie != null)
				{
					this.cookies.Add(cookie);
				}
				return;
			}
			this.accept_types = text2.Split(',', StringSplitOptions.None);
		}

		// Token: 0x06003504 RID: 13572 RVA: 0x000B9B5C File Offset: 0x000B7D5C
		internal bool FlushInput()
		{
			if (!this.HasEntityBody)
			{
				return true;
			}
			int num = 2048;
			if (this.content_length > 0L)
			{
				num = (int)Math.Min(this.content_length, (long)num);
			}
			byte[] buffer = new byte[num];
			bool result;
			for (;;)
			{
				try
				{
					IAsyncResult asyncResult = this.InputStream.BeginRead(buffer, 0, num, null, null);
					if (!asyncResult.IsCompleted && !asyncResult.AsyncWaitHandle.WaitOne(1000))
					{
						result = false;
					}
					else
					{
						if (this.InputStream.EndRead(asyncResult) > 0)
						{
							continue;
						}
						result = true;
					}
				}
				catch (ObjectDisposedException)
				{
					this.input_stream = null;
					result = true;
				}
				catch
				{
					result = false;
				}
				break;
			}
			return result;
		}

		/// <summary>Возвращает типы MIME, принятые клиентом.</summary>
		/// <returns>Массив <see cref="T:System.String" />, содержащий имена типов, указанные в заголовке запроса <see langword="Accept" />, или значение <see langword="null" />, если клиентский запрос не содержал заголовка <see langword="Accept" />.</returns>
		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06003505 RID: 13573 RVA: 0x000B9C0C File Offset: 0x000B7E0C
		public string[] AcceptTypes
		{
			get
			{
				return this.accept_types;
			}
		}

		/// <summary>Возвращает код ошибки, который указывает на неполадку, связанную с сертификатом <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />, предоставленным клиентом.</summary>
		/// <returns>Значение <see cref="T:System.Int32" />, содержащее код ошибки Windows.</returns>
		/// <exception cref="T:System.InvalidOperationException">Клиентский сертификат еще не был инициализирован с помощью вызова методов <see cref="M:System.Net.HttpListenerRequest.BeginGetClientCertificate(System.AsyncCallback,System.Object)" /> или <see cref="M:System.Net.HttpListenerRequest.GetClientCertificate" /> 
		/// -или- 
		/// Операция не завершена.</exception>
		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06003506 RID: 13574 RVA: 0x000B9C14 File Offset: 0x000B7E14
		public int ClientCertificateError
		{
			get
			{
				HttpConnection connection = this.context.Connection;
				if (connection.ClientCertificate == null)
				{
					throw new InvalidOperationException("No client certificate");
				}
				int[] clientCertificateErrors = connection.ClientCertificateErrors;
				if (clientCertificateErrors != null && clientCertificateErrors.Length != 0)
				{
					return clientCertificateErrors[0];
				}
				return 0;
			}
		}

		/// <summary>Возвращает кодировку содержимого, которая может быть использована вместе с данными, отправляемыми с запросом</summary>
		/// <returns>Объект <see cref="T:System.Text.Encoding" />, подходящий для использования вместе с данными в свойстве <see cref="P:System.Net.HttpListenerRequest.InputStream" />.</returns>
		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06003507 RID: 13575 RVA: 0x000B9C51 File Offset: 0x000B7E51
		public Encoding ContentEncoding
		{
			get
			{
				if (this.content_encoding == null)
				{
					this.content_encoding = Encoding.Default;
				}
				return this.content_encoding;
			}
		}

		/// <summary>Возвращает длину данных основного текста, содержащихся в запросе.</summary>
		/// <returns>Значение из заголовка запроса <see langword="Content-Length" />. Это значение равно -1, если длина содержимого неизвестна.</returns>
		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06003508 RID: 13576 RVA: 0x000B9C6C File Offset: 0x000B7E6C
		public long ContentLength64
		{
			get
			{
				if (!this.is_chunked)
				{
					return this.content_length;
				}
				return -1L;
			}
		}

		/// <summary>Возвращает тип MIME данных основного текста, содержащихся в запросе.</summary>
		/// <returns>Строка <see cref="T:System.String" />, содержащая текст заголовка запроса <see langword="Content-Type" />.</returns>
		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06003509 RID: 13577 RVA: 0x000B9C7F File Offset: 0x000B7E7F
		public string ContentType
		{
			get
			{
				return this.headers["content-type"];
			}
		}

		/// <summary>Возвращает файлы cookie, отправленные вместе с запросом.</summary>
		/// <returns>Коллекция <see cref="T:System.Net.CookieCollection" />, которая содержит файлы cookie, которые сопровождают запрос. Это свойство возвращает пустую коллекцию, если запрос не содержит файлы cookie.</returns>
		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x0600350A RID: 13578 RVA: 0x000B9C91 File Offset: 0x000B7E91
		public CookieCollection Cookies
		{
			get
			{
				if (this.cookies == null)
				{
					this.cookies = new CookieCollection();
				}
				return this.cookies;
			}
		}

		/// <summary>Возвращает значение <see cref="T:System.Boolean" />, указывающее, имеет ли запрос связанные данные основного текста.</summary>
		/// <returns>Значение <see langword="true" />, если запрос содержит данные в основном тексте, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x0600350B RID: 13579 RVA: 0x000B9CAC File Offset: 0x000B7EAC
		public bool HasEntityBody
		{
			get
			{
				return this.content_length > 0L || this.is_chunked;
			}
		}

		/// <summary>Возвращает коллекцию пар "имя-значение" заголовка, отправляемых в запросе.</summary>
		/// <returns>Коллекция <see cref="T:System.Net.WebHeaderCollection" />, содержащая HTTP-заголовки, включенные в запросе.</returns>
		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x0600350C RID: 13580 RVA: 0x000B9CC0 File Offset: 0x000B7EC0
		public NameValueCollection Headers
		{
			get
			{
				return this.headers;
			}
		}

		/// <summary>Возвращает метод HTTP, определенный клиентом.</summary>
		/// <returns>Строка <see cref="T:System.String" />, содержащая метод, используемый в запросе.</returns>
		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x0600350D RID: 13581 RVA: 0x000B9CC8 File Offset: 0x000B7EC8
		public string HttpMethod
		{
			get
			{
				return this.method;
			}
		}

		/// <summary>Возвращает поток, содержащий данные основного текста, отправленные клиентом.</summary>
		/// <returns>Доступный для чтения объект <see cref="T:System.IO.Stream" />, который содержит байты, отправленные клиентом в основном тексте запроса. Это свойство возвращает значение <see cref="F:System.IO.Stream.Null" />, если вместе с запросом не было отправлено никаких данных.</returns>
		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x0600350E RID: 13582 RVA: 0x000B9CD0 File Offset: 0x000B7ED0
		public Stream InputStream
		{
			get
			{
				if (this.input_stream == null)
				{
					if (this.is_chunked || this.content_length > 0L)
					{
						this.input_stream = this.context.Connection.GetRequestStream(this.is_chunked, this.content_length);
					}
					else
					{
						this.input_stream = Stream.Null;
					}
				}
				return this.input_stream;
			}
		}

		/// <summary>Возвращает значение <see cref="T:System.Boolean" />, которое указывает, прошел ли проверку подлинности клиент, отправивший этот запрос.</summary>
		/// <returns>Если клиент прошел проверку подлинности, значение <see langword="true" />, если нет — значение <see langword="false" />.</returns>
		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x0600350F RID: 13583 RVA: 0x00003062 File Offset: 0x00001262
		[MonoTODO("Always returns false")]
		public bool IsAuthenticated
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает значение <see cref="T:System.Boolean" />, которое указывает, был ли запрос отправлен с локального компьютера.</summary>
		/// <returns>Значение <see langword="true" />, если запрос происходит с того же компьютера, что и объект <see cref="T:System.Net.HttpListener" />, предоставивший запрос; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06003510 RID: 13584 RVA: 0x000B9D2C File Offset: 0x000B7F2C
		public bool IsLocal
		{
			get
			{
				return this.LocalEndPoint.Address.Equals(this.RemoteEndPoint.Address);
			}
		}

		/// <summary>Возвращает значение <see cref="T:System.Boolean" />, которое указывает, используется ли для подключения TCP, по которому отправляются запросы, протокол SSL.</summary>
		/// <returns>Значение <see langword="true" />, если для подключения TCP используется SSL, в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06003511 RID: 13585 RVA: 0x000B9D49 File Offset: 0x000B7F49
		public bool IsSecureConnection
		{
			get
			{
				return this.context.Connection.IsSecure;
			}
		}

		/// <summary>Возвращает значение <see cref="T:System.Boolean" />, которое указывает, требует ли клиент постоянного подключения.</summary>
		/// <returns>Значение <see langword="true" />, если подключение должно быть открытым; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06003512 RID: 13586 RVA: 0x000B9D5C File Offset: 0x000B7F5C
		public bool KeepAlive
		{
			get
			{
				if (this.ka_set)
				{
					return this.keep_alive;
				}
				this.ka_set = true;
				string text = this.headers["Connection"];
				if (!string.IsNullOrEmpty(text))
				{
					this.keep_alive = (string.Compare(text, "keep-alive", StringComparison.OrdinalIgnoreCase) == 0);
				}
				else if (this.version == HttpVersion.Version11)
				{
					this.keep_alive = true;
				}
				else
				{
					text = this.headers["keep-alive"];
					if (!string.IsNullOrEmpty(text))
					{
						this.keep_alive = (string.Compare(text, "closed", StringComparison.OrdinalIgnoreCase) != 0);
					}
				}
				return this.keep_alive;
			}
		}

		/// <summary>Возвращает IP-адрес сервера и номер порта, на который будет перенаправлен запрос.</summary>
		/// <returns>Конечная точка <see cref="T:System.Net.IPEndPoint" />, которая представляет IP-адрес, на который отправляется запрос.</returns>
		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06003513 RID: 13587 RVA: 0x000B9DFE File Offset: 0x000B7FFE
		public IPEndPoint LocalEndPoint
		{
			get
			{
				return this.context.Connection.LocalEndPoint;
			}
		}

		/// <summary>Возвращает версию HTTP, используемую отправляющим запрос клиентом.</summary>
		/// <returns>Версия <see cref="T:System.Version" />, указывающая клиентскую версию HTTP.</returns>
		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06003514 RID: 13588 RVA: 0x000B9E10 File Offset: 0x000B8010
		public Version ProtocolVersion
		{
			get
			{
				return this.version;
			}
		}

		/// <summary>Возвращает строку, включенную в запрос.</summary>
		/// <returns>Объект <see cref="T:System.Collections.Specialized.NameValueCollection" />, который содержит данные запроса, включенные в запрос <see cref="P:System.Net.HttpListenerRequest.Url" />.</returns>
		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06003515 RID: 13589 RVA: 0x000B9E18 File Offset: 0x000B8018
		public NameValueCollection QueryString
		{
			get
			{
				return this.query_string;
			}
		}

		/// <summary>Возвращает сведения об URL-адресе (без узла и порта), запрошенные клиентом.</summary>
		/// <returns>Строка <see cref="T:System.String" />, содержащая исходный URL-адрес для этого запроса.</returns>
		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06003516 RID: 13590 RVA: 0x000B9E20 File Offset: 0x000B8020
		public string RawUrl
		{
			get
			{
				return this.raw_url;
			}
		}

		/// <summary>Возвращает клиентский IP-адрес и номер порта, которые являются источниками запроса.</summary>
		/// <returns>Конечная точка <see cref="T:System.Net.IPEndPoint" />, которая представляет IP-адрес и номер порта, которые являются источниками запроса.</returns>
		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06003517 RID: 13591 RVA: 0x000B9E28 File Offset: 0x000B8028
		public IPEndPoint RemoteEndPoint
		{
			get
			{
				return this.context.Connection.RemoteEndPoint;
			}
		}

		/// <summary>Возвращает идентификатор запроса входящего HTTP-запроса.</summary>
		/// <returns>Объект <see cref="T:System.Guid" />, содержащий идентификатор HTTP-запроса.</returns>
		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06003518 RID: 13592 RVA: 0x000B9E3A File Offset: 0x000B803A
		[MonoTODO("Always returns Guid.Empty")]
		public Guid RequestTraceIdentifier
		{
			get
			{
				return Guid.Empty;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Uri" />, запрошенный клиентом.</summary>
		/// <returns>Объект <see cref="T:System.Uri" />, который определяет ресурс, запрошенный клиентом.</returns>
		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06003519 RID: 13593 RVA: 0x000B9E41 File Offset: 0x000B8041
		public Uri Url
		{
			get
			{
				return this.url;
			}
		}

		/// <summary>Возвращает URI ресурса, который перенаправляет клиент на сервер.</summary>
		/// <returns>Объект <see cref="T:System.Uri" />, содержащий текст заголовка запроса <see cref="F:System.Net.HttpRequestHeader.Referer" />, или <see langword="null" />, если заголовок не был включен в запрос.</returns>
		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x0600351A RID: 13594 RVA: 0x000B9E49 File Offset: 0x000B8049
		public Uri UrlReferrer
		{
			get
			{
				return this.referrer;
			}
		}

		/// <summary>Возвращает агента пользователя, предоставляемого клиентом.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий текст заголовка <see langword="User-Agent" /> запроса.</returns>
		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x0600351B RID: 13595 RVA: 0x000B9E51 File Offset: 0x000B8051
		public string UserAgent
		{
			get
			{
				return this.headers["user-agent"];
			}
		}

		/// <summary>Возвращает IP-адрес сервера и номер порта, на который будет перенаправлен запрос.</summary>
		/// <returns>Строка <see cref="T:System.String" />, в которой содержатся сведения об адресе узла.</returns>
		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x0600351C RID: 13596 RVA: 0x000B9E63 File Offset: 0x000B8063
		public string UserHostAddress
		{
			get
			{
				return this.LocalEndPoint.ToString();
			}
		}

		/// <summary>Возвращает DNS-имя и, если применимо, номер порта, указанный клиентом.</summary>
		/// <returns>Значение <see cref="T:System.String" />, содержащее текст заголовка <see langword="Host" /> запроса.</returns>
		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x0600351D RID: 13597 RVA: 0x000B9E70 File Offset: 0x000B8070
		public string UserHostName
		{
			get
			{
				return this.headers["host"];
			}
		}

		/// <summary>Возвращает естественные языки, предпочитаемые для ответа.</summary>
		/// <returns>Массив <see cref="T:System.String" />, содержащий языки, указанные в заголовке запроса <see cref="F:System.Net.HttpRequestHeader.AcceptLanguage" />, или значение <see langword="null" />, если клиентский запрос не содержал заголовка <see cref="F:System.Net.HttpRequestHeader.AcceptLanguage" />.</returns>
		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x0600351E RID: 13598 RVA: 0x000B9E82 File Offset: 0x000B8082
		public string[] UserLanguages
		{
			get
			{
				return this.user_languages;
			}
		}

		/// <summary>Начинает асинхронный запрос клиентского сертификата X.509 v.3.</summary>
		/// <param name="requestCallback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, вызываемый по завершении данной операции.</param>
		/// <param name="state">Пользовательский объект, содержащий сведения об операции. Этот объект передается делегату "callback" по завершении операции.</param>
		/// <returns>Экземпляр <see cref="T:System.IAsyncResult" />, представляющий состояние операции.</returns>
		// Token: 0x0600351F RID: 13599 RVA: 0x000B9E8A File Offset: 0x000B808A
		public IAsyncResult BeginGetClientCertificate(AsyncCallback requestCallback, object state)
		{
			if (this.gcc_delegate == null)
			{
				this.gcc_delegate = new HttpListenerRequest.GCCDelegate(this.GetClientCertificate);
			}
			return this.gcc_delegate.BeginInvoke(requestCallback, state);
		}

		/// <summary>Завершает асинхронный запрос клиентского сертификата X.509 v.3.</summary>
		/// <param name="asyncResult">Незавершенный запрос сертификата.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, который возвращается при начале операции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asyncResult" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="asyncResult" /> не был получен путем вызова <see cref="M:System.Net.HttpListenerRequest.BeginGetClientCertificate(System.AsyncCallback,System.Object)" /><paramref name="e." />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Этот метод уже был вызван для операции, указанной в параметре <paramref name="asyncResult" />.</exception>
		// Token: 0x06003520 RID: 13600 RVA: 0x000B9EB3 File Offset: 0x000B80B3
		public X509Certificate2 EndGetClientCertificate(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			if (this.gcc_delegate == null)
			{
				throw new InvalidOperationException();
			}
			return this.gcc_delegate.EndInvoke(asyncResult);
		}

		/// <summary>Получает клиентский сертификат X.509 v.3.</summary>
		/// <returns>Объект <see cref="N:System.Security.Cryptography.X509Certificates" />, который содержит клиентский сертификат X.509 v.3.</returns>
		/// <exception cref="T:System.InvalidOperationException">Вызов этого метода для получения клиентского сертификата X.509 v.3 все еще не завершен, поэтому невозможно выполнить еще один вызов этого метода.</exception>
		// Token: 0x06003521 RID: 13601 RVA: 0x000B9EDD File Offset: 0x000B80DD
		public X509Certificate2 GetClientCertificate()
		{
			return this.context.Connection.ClientCertificate;
		}

		/// <summary>Получает имя поставщика услуг (SPN), которое было отправлено клиентом в запросе.</summary>
		/// <returns>Строка <see cref="T:System.String" />, содержащая SPN, отправленное клиентом в запросе.</returns>
		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06003522 RID: 13602 RVA: 0x00002F6A File Offset: 0x0000116A
		[MonoTODO]
		public string ServiceName
		{
			get
			{
				return null;
			}
		}

		/// <summary>Получает <see cref="T:System.Net.TransportContext" /> для запроса клиента.</summary>
		/// <returns>Объект <see cref="T:System.Net.TransportContext" /> для запроса клиента.</returns>
		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06003523 RID: 13603 RVA: 0x000B9EEF File Offset: 0x000B80EF
		public TransportContext TransportContext
		{
			get
			{
				return new HttpListenerRequest.Context();
			}
		}

		/// <summary>Получает значение <see cref="T:System.Boolean" />, которое указывает, было ли подключение TCP запросом WebSocket.</summary>
		/// <returns>Возвращает <see cref="T:System.Boolean" />.  
		///  значение <see langword="true" />, если подключение TCP — запрос WebSocket; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06003524 RID: 13604 RVA: 0x00003062 File Offset: 0x00001262
		[MonoTODO]
		public bool IsWebSocketRequest
		{
			get
			{
				return false;
			}
		}

		/// <summary>Извлекает клиентский сертификат X.509 v.3 как асинхронную операцию.</summary>
		/// <returns>Объект задачи, представляющий асинхронную операцию. Свойство <see cref="P:System.Threading.Tasks.Task`1.Result" /> в объекте задачи возвращает объект <see cref="N:System.Security.Cryptography.X509Certificates" />, содержащий сертификат X.509 v.3 клиента.</returns>
		// Token: 0x06003525 RID: 13605 RVA: 0x000B9EF6 File Offset: 0x000B80F6
		public Task<X509Certificate2> GetClientCertificateAsync()
		{
			return Task<X509Certificate2>.Factory.FromAsync(new Func<AsyncCallback, object, IAsyncResult>(this.BeginGetClientCertificate), new Func<IAsyncResult, X509Certificate2>(this.EndGetClientCertificate), null);
		}

		// Token: 0x06003527 RID: 13607 RVA: 0x00013BCA File Offset: 0x00011DCA
		internal HttpListenerRequest()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04001EE9 RID: 7913
		private string[] accept_types;

		// Token: 0x04001EEA RID: 7914
		private Encoding content_encoding;

		// Token: 0x04001EEB RID: 7915
		private long content_length;

		// Token: 0x04001EEC RID: 7916
		private bool cl_set;

		// Token: 0x04001EED RID: 7917
		private CookieCollection cookies;

		// Token: 0x04001EEE RID: 7918
		private WebHeaderCollection headers;

		// Token: 0x04001EEF RID: 7919
		private string method;

		// Token: 0x04001EF0 RID: 7920
		private Stream input_stream;

		// Token: 0x04001EF1 RID: 7921
		private Version version;

		// Token: 0x04001EF2 RID: 7922
		private NameValueCollection query_string;

		// Token: 0x04001EF3 RID: 7923
		private string raw_url;

		// Token: 0x04001EF4 RID: 7924
		private Uri url;

		// Token: 0x04001EF5 RID: 7925
		private Uri referrer;

		// Token: 0x04001EF6 RID: 7926
		private string[] user_languages;

		// Token: 0x04001EF7 RID: 7927
		private HttpListenerContext context;

		// Token: 0x04001EF8 RID: 7928
		private bool is_chunked;

		// Token: 0x04001EF9 RID: 7929
		private bool ka_set;

		// Token: 0x04001EFA RID: 7930
		private bool keep_alive;

		// Token: 0x04001EFB RID: 7931
		private HttpListenerRequest.GCCDelegate gcc_delegate;

		// Token: 0x04001EFC RID: 7932
		private static byte[] _100continue = Encoding.ASCII.GetBytes("HTTP/1.1 100 Continue\r\n\r\n");

		// Token: 0x04001EFD RID: 7933
		private static char[] separators = new char[]
		{
			' '
		};

		// Token: 0x0200068E RID: 1678
		private class Context : TransportContext
		{
			// Token: 0x06003528 RID: 13608 RVA: 0x0000829A File Offset: 0x0000649A
			public override ChannelBinding GetChannelBinding(ChannelBindingKind kind)
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x0200068F RID: 1679
		// (Invoke) Token: 0x0600352B RID: 13611
		private delegate X509Certificate2 GCCDelegate();
	}
}
