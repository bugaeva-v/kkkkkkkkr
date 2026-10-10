using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Principal;
using Unity;

namespace System.Net.WebSockets
{
	/// <summary>Предоставляет доступ к сведениям, полученный классом <see cref="T:System.Net.HttpListener" /> при приеме подключений WebSocket.</summary>
	// Token: 0x020007DD RID: 2013
	public class HttpListenerWebSocketContext : WebSocketContext
	{
		// Token: 0x0600402D RID: 16429 RVA: 0x000DCC54 File Offset: 0x000DAE54
		internal HttpListenerWebSocketContext(Uri requestUri, NameValueCollection headers, CookieCollection cookieCollection, IPrincipal user, bool isAuthenticated, bool isLocal, bool isSecureConnection, string origin, IEnumerable<string> secWebSocketProtocols, string secWebSocketVersion, string secWebSocketKey, WebSocket webSocket)
		{
			this._cookieCollection = new CookieCollection();
			this._cookieCollection.Add(cookieCollection);
			this._headers = new NameValueCollection(headers);
			this._user = HttpListenerWebSocketContext.CopyPrincipal(user);
			this._requestUri = requestUri;
			this._isAuthenticated = isAuthenticated;
			this._isLocal = isLocal;
			this._isSecureConnection = isSecureConnection;
			this._origin = origin;
			this._secWebSocketProtocols = secWebSocketProtocols;
			this._secWebSocketVersion = secWebSocketVersion;
			this._secWebSocketKey = secWebSocketKey;
			this._webSocket = webSocket;
		}

		/// <summary>Получает Универсальный код ресурса (URI), запрашиваемый клиентом WebSocket.</summary>
		/// <returns>URI, запрашиваемый клиентом WebSocket.</returns>
		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x0600402E RID: 16430 RVA: 0x000DCCDE File Offset: 0x000DAEDE
		public override Uri RequestUri
		{
			get
			{
				return this._requestUri;
			}
		}

		/// <summary>Получает заголовки HTTP, получаемые объектом <see cref="T:System.Net.HttpListener" /> в открывающем подтверждении WebSocket.</summary>
		/// <returns>Заголовки HTTP, полученные объектом <see cref="T:System.Net.HttpListener" />.</returns>
		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x0600402F RID: 16431 RVA: 0x000DCCE6 File Offset: 0x000DAEE6
		public override NameValueCollection Headers
		{
			get
			{
				return this._headers;
			}
		}

		/// <summary>Получает Значение HTTP-заголовка "Origin", включенного в подтверждение открытия WebSocket.</summary>
		/// <returns>Значение HTTP-заголовка "Origin".</returns>
		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x06004030 RID: 16432 RVA: 0x000DCCEE File Offset: 0x000DAEEE
		public override string Origin
		{
			get
			{
				return this._origin;
			}
		}

		/// <summary>Получает список безопасных протоколов WebSocket, включенных в открывающее подтверждение WebSocket.</summary>
		/// <returns>Список безопасных протоколов WebSocket.</returns>
		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06004031 RID: 16433 RVA: 0x000DCCF6 File Offset: 0x000DAEF6
		public override IEnumerable<string> SecWebSocketProtocols
		{
			get
			{
				return this._secWebSocketProtocols;
			}
		}

		/// <summary>Получает Список подпротоколов, запрошенных клиентом WebSocket.</summary>
		/// <returns>Список подпротоколов, запрошенных клиентом WebSocket.</returns>
		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x06004032 RID: 16434 RVA: 0x000DCCFE File Offset: 0x000DAEFE
		public override string SecWebSocketVersion
		{
			get
			{
				return this._secWebSocketVersion;
			}
		}

		/// <summary>Получает Значение HTTP-заголовка SecWebSocketKey, включенного в подтверждение открытия WebSocket.</summary>
		/// <returns>Значение HTTP-заголовка SecWebSocketKey.</returns>
		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x06004033 RID: 16435 RVA: 0x000DCD06 File Offset: 0x000DAF06
		public override string SecWebSocketKey
		{
			get
			{
				return this._secWebSocketKey;
			}
		}

		/// <summary>Получает файлы cookie, получаемые объектом <see cref="T:System.Net.HttpListener" /> в открывающем подтверждении WebSocket.</summary>
		/// <returns>Файлы cookie, полученные объектом <see cref="T:System.Net.HttpListener" />.</returns>
		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x06004034 RID: 16436 RVA: 0x000DCD0E File Offset: 0x000DAF0E
		public override CookieCollection CookieCollection
		{
			get
			{
				return this._cookieCollection;
			}
		}

		/// <summary>Получает Объект, используемый для получения идентификатора, сведений для аутентификации, и ролей безопасности для клиента WebSocket.</summary>
		/// <returns>Идентификатор, сведения для аутентификации, и роли безопасности для клиента WebSocket.</returns>
		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06004035 RID: 16437 RVA: 0x000DCD16 File Offset: 0x000DAF16
		public override IPrincipal User
		{
			get
			{
				return this._user;
			}
		}

		/// <summary>Получает значение, указывающее, аутентифицирован ли клиент WebSocket.</summary>
		/// <returns>
		///   <see langword="true" /> Если клиент WebSocket прошел проверку подлинности; в противном случае <see langword="false" />.</returns>
		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x06004036 RID: 16438 RVA: 0x000DCD1E File Offset: 0x000DAF1E
		public override bool IsAuthenticated
		{
			get
			{
				return this._isAuthenticated;
			}
		}

		/// <summary>Получает значение, указывающее, если клиент WebSocket подключился с локального компьютера.</summary>
		/// <returns>
		///   <see langword="true" /> Если клиент WebSocket подключился с локального компьютера; в противном случае <see langword="false" />.</returns>
		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x06004037 RID: 16439 RVA: 0x000DCD26 File Offset: 0x000DAF26
		public override bool IsLocal
		{
			get
			{
				return this._isLocal;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли подключение WebSocket защищенным с помощью Secure Sockets Layer (SSL).</summary>
		/// <returns>
		///   <see langword="true" /> Если соединение WebSocket защищена с помощью SSL; в противном случае <see langword="false" />.</returns>
		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x06004038 RID: 16440 RVA: 0x000DCD2E File Offset: 0x000DAF2E
		public override bool IsSecureConnection
		{
			get
			{
				return this._isSecureConnection;
			}
		}

		/// <summary>Возвращает экземпляр <see cref="T:System.Net.WebSockets.WebSocket" />, используемый для отправки и получения данных по соединению <see cref="T:System.Net.WebSockets.WebSocket" />.</summary>
		/// <returns>
		///   <see cref="T:System.Net.WebSockets.WebSocket" /> Экземпляр, используемый для отправки и получения данных по <see cref="T:System.Net.WebSockets.WebSocket" /> подключения.</returns>
		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x06004039 RID: 16441 RVA: 0x000DCD36 File Offset: 0x000DAF36
		public override WebSocket WebSocket
		{
			get
			{
				return this._webSocket;
			}
		}

		// Token: 0x0600403A RID: 16442 RVA: 0x000DCD40 File Offset: 0x000DAF40
		private static IPrincipal CopyPrincipal(IPrincipal user)
		{
			if (user != null)
			{
				if (user is WindowsPrincipal)
				{
					throw new PlatformNotSupportedException();
				}
				HttpListenerBasicIdentity httpListenerBasicIdentity = user.Identity as HttpListenerBasicIdentity;
				if (httpListenerBasicIdentity != null)
				{
					return new GenericPrincipal(new HttpListenerBasicIdentity(httpListenerBasicIdentity.Name, httpListenerBasicIdentity.Password), null);
				}
			}
			return null;
		}

		// Token: 0x0600403B RID: 16443 RVA: 0x00013BCA File Offset: 0x00011DCA
		internal HttpListenerWebSocketContext()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040026C2 RID: 9922
		private readonly Uri _requestUri;

		// Token: 0x040026C3 RID: 9923
		private readonly NameValueCollection _headers;

		// Token: 0x040026C4 RID: 9924
		private readonly CookieCollection _cookieCollection;

		// Token: 0x040026C5 RID: 9925
		private readonly IPrincipal _user;

		// Token: 0x040026C6 RID: 9926
		private readonly bool _isAuthenticated;

		// Token: 0x040026C7 RID: 9927
		private readonly bool _isLocal;

		// Token: 0x040026C8 RID: 9928
		private readonly bool _isSecureConnection;

		// Token: 0x040026C9 RID: 9929
		private readonly string _origin;

		// Token: 0x040026CA RID: 9930
		private readonly IEnumerable<string> _secWebSocketProtocols;

		// Token: 0x040026CB RID: 9931
		private readonly string _secWebSocketVersion;

		// Token: 0x040026CC RID: 9932
		private readonly string _secWebSocketKey;

		// Token: 0x040026CD RID: 9933
		private readonly WebSocket _webSocket;
	}
}
