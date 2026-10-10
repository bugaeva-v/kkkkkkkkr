using System;
using System.IO;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Threading;

namespace System.Net
{
	/// <summary>Предоставляет реализацию файловой системы класса <see cref="T:System.Net.WebRequest" />.</summary>
	// Token: 0x02000657 RID: 1623
	[Serializable]
	public class FileWebRequest : WebRequest, ISerializable
	{
		// Token: 0x0600331E RID: 13086 RVA: 0x000B24EC File Offset: 0x000B06EC
		internal FileWebRequest(Uri uri)
		{
			if (uri.Scheme != Uri.UriSchemeFile)
			{
				throw new ArgumentOutOfRangeException("uri");
			}
			this.m_uri = uri;
			this.m_fileAccess = FileAccess.Read;
			this.m_headers = new WebHeaderCollection(WebHeaderCollectionType.FileWebRequest);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.FileWebRequest" /> на основе указанных экземпляров классов <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="serializationInfo">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который содержит сведения, требуемые для сериализации нового объекта <see cref="T:System.Net.FileWebRequest" />.</param>
		/// <param name="streamingContext">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий источник сериализованного потока, связанного с новым объектом <see cref="T:System.Net.FileWebRequest" />.</param>
		// Token: 0x0600331F RID: 13087 RVA: 0x000B2548 File Offset: 0x000B0748
		[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
		protected FileWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
			this.m_headers = (WebHeaderCollection)serializationInfo.GetValue("headers", typeof(WebHeaderCollection));
			this.m_proxy = (IWebProxy)serializationInfo.GetValue("proxy", typeof(IWebProxy));
			this.m_uri = (Uri)serializationInfo.GetValue("uri", typeof(Uri));
			this.m_connectionGroupName = serializationInfo.GetString("connectionGroupName");
			this.m_method = serializationInfo.GetString("method");
			this.m_contentLength = serializationInfo.GetInt64("contentLength");
			this.m_timeout = serializationInfo.GetInt32("timeout");
			this.m_fileAccess = (FileAccess)serializationInfo.GetInt32("fileAccess");
		}

		/// <summary>Передает объекту <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данные, необходимые для сериализации объекта <see cref="T:System.Net.FileWebRequest" />.</summary>
		/// <param name="serializationInfo">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который содержит сериализованные данные для <see cref="T:System.Net.FileWebRequest" />.</param>
		/// <param name="streamingContext">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий назначение сериализованного потока, связанного с классом <see cref="T:System.Net.FileWebRequest" />.</param>
		// Token: 0x06003320 RID: 13088 RVA: 0x000AB5FA File Offset: 0x000A97FA
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter, SerializationFormatter = true)]
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			this.GetObjectData(serializationInfo, streamingContext);
		}

		/// <summary>Заполняет объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации целевого объекта.</summary>
		/// <param name="serializationInfo">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> для заполнения данными.</param>
		/// <param name="streamingContext">Контекст <see cref="T:System.Runtime.Serialization.StreamingContext" />, определяющий целевой объект сериализации.</param>
		// Token: 0x06003321 RID: 13089 RVA: 0x000B2628 File Offset: 0x000B0828
		[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			serializationInfo.AddValue("headers", this.m_headers, typeof(WebHeaderCollection));
			serializationInfo.AddValue("proxy", this.m_proxy, typeof(IWebProxy));
			serializationInfo.AddValue("uri", this.m_uri, typeof(Uri));
			serializationInfo.AddValue("connectionGroupName", this.m_connectionGroupName);
			serializationInfo.AddValue("method", this.m_method);
			serializationInfo.AddValue("contentLength", this.m_contentLength);
			serializationInfo.AddValue("timeout", this.m_timeout);
			serializationInfo.AddValue("fileAccess", this.m_fileAccess);
			serializationInfo.AddValue("preauthenticate", false);
			base.GetObjectData(serializationInfo, streamingContext);
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06003322 RID: 13090 RVA: 0x000B26F4 File Offset: 0x000B08F4
		internal bool Aborted
		{
			get
			{
				return this.m_Aborted != 0;
			}
		}

		/// <summary>Возвращает или задает имя группы подключения для запроса. Это свойство зарезервировано для дальнейшего использования.</summary>
		/// <returns>Имя группы подключения для запроса.</returns>
		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06003323 RID: 13091 RVA: 0x000B26FF File Offset: 0x000B08FF
		// (set) Token: 0x06003324 RID: 13092 RVA: 0x000B2707 File Offset: 0x000B0907
		public override string ConnectionGroupName
		{
			get
			{
				return this.m_connectionGroupName;
			}
			set
			{
				this.m_connectionGroupName = value;
			}
		}

		/// <summary>Возвращает или задает длину содержимого отправляемых данных.</summary>
		/// <returns>Число байтов посылаемых данных запроса.</returns>
		/// <exception cref="T:System.ArgumentException">Значение параметра <see cref="P:System.Net.FileWebRequest.ContentLength" /> меньше 0.</exception>
		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06003325 RID: 13093 RVA: 0x000B2710 File Offset: 0x000B0910
		// (set) Token: 0x06003326 RID: 13094 RVA: 0x000B2718 File Offset: 0x000B0918
		public override long ContentLength
		{
			get
			{
				return this.m_contentLength;
			}
			set
			{
				if (value < 0L)
				{
					throw new ArgumentException(SR.GetString("The Content-Length value must be greater than or equal to zero."), "value");
				}
				this.m_contentLength = value;
			}
		}

		/// <summary>Возвращает или задает тип содержимого отправляемых данных. Это свойство зарезервировано для дальнейшего использования.</summary>
		/// <returns>Тип содержимого отправляемых данных.</returns>
		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06003327 RID: 13095 RVA: 0x000B273B File Offset: 0x000B093B
		// (set) Token: 0x06003328 RID: 13096 RVA: 0x000B274D File Offset: 0x000B094D
		public override string ContentType
		{
			get
			{
				return this.m_headers["Content-Type"];
			}
			set
			{
				this.m_headers["Content-Type"] = value;
			}
		}

		/// <summary>Возвращает или устанавливает учетные данные, связанные с этим запросом. Это свойство зарезервировано для дальнейшего использования.</summary>
		/// <returns>Класс <see cref="T:System.Net.ICredentials" />, содержащий учетные данные для проверки подлинности, связанные с этим запросом. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06003329 RID: 13097 RVA: 0x000B2760 File Offset: 0x000B0960
		// (set) Token: 0x0600332A RID: 13098 RVA: 0x000B2768 File Offset: 0x000B0968
		public override ICredentials Credentials
		{
			get
			{
				return this.m_credentials;
			}
			set
			{
				this.m_credentials = value;
			}
		}

		/// <summary>Возвращает или задает коллекцию пар "имя-значение", связанных с запросом. Это свойство зарезервировано для дальнейшего использования.</summary>
		/// <returns>Класс <see cref="T:System.Net.WebHeaderCollection" />, содержащий пары "имя-значение" заголовка, связанные с данным запросом.</returns>
		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x0600332B RID: 13099 RVA: 0x000B2771 File Offset: 0x000B0971
		public override WebHeaderCollection Headers
		{
			get
			{
				return this.m_headers;
			}
		}

		/// <summary>Возвращает или задает метод протокола, используемый для запроса. Это свойство зарезервировано для дальнейшего использования.</summary>
		/// <returns>Метод протокола для использования в данном запросе.</returns>
		/// <exception cref="T:System.ArgumentException">Метод является недопустимым.  
		/// -или- 
		/// Метод не поддерживается.  
		/// -или- 
		/// Было указано несколько методов.</exception>
		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x0600332C RID: 13100 RVA: 0x000B2779 File Offset: 0x000B0979
		// (set) Token: 0x0600332D RID: 13101 RVA: 0x000B2781 File Offset: 0x000B0981
		public override string Method
		{
			get
			{
				return this.m_method;
			}
			set
			{
				if (ValidationHelper.IsBlankString(value))
				{
					throw new ArgumentException(SR.GetString("Cannot set null or blank methods on request."), "value");
				}
				this.m_method = value;
			}
		}

		/// <summary>Возвращает или задает значение, показывающее, необходимо ли выполнять предварительную проверку подлинности запроса. Это свойство зарезервировано для дальнейшего использования.</summary>
		/// <returns>Значение <see langword="true" /> — выполнять предварительную проверку подлинности; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x0600332E RID: 13102 RVA: 0x000B27A7 File Offset: 0x000B09A7
		// (set) Token: 0x0600332F RID: 13103 RVA: 0x000B27AF File Offset: 0x000B09AF
		public override bool PreAuthenticate
		{
			get
			{
				return this.m_preauthenticate;
			}
			set
			{
				this.m_preauthenticate = true;
			}
		}

		/// <summary>Возвращает или задает сетевой прокси-сервер, используемый для этого запроса. Это свойство зарезервировано для дальнейшего использования.</summary>
		/// <returns>Класс <see cref="T:System.Net.IWebProxy" />, указывающий сетевой прокси-сервер, используемый для этого запроса.</returns>
		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06003330 RID: 13104 RVA: 0x000B27B8 File Offset: 0x000B09B8
		// (set) Token: 0x06003331 RID: 13105 RVA: 0x000B27C0 File Offset: 0x000B09C0
		public override IWebProxy Proxy
		{
			get
			{
				return this.m_proxy;
			}
			set
			{
				this.m_proxy = value;
			}
		}

		/// <summary>Возвращает или задает срок действия запроса.</summary>
		/// <returns>Время в миллисекундах срока действия запроса, или значение <see cref="F:System.Threading.Timeout.Infinite" /> для указания, что срок действия запроса не истекает.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Указанное значение меньше или равно нулю, и флаг <see cref="F:System.Threading.Timeout.Infinite" /> не установлен.</exception>
		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06003332 RID: 13106 RVA: 0x000B27C9 File Offset: 0x000B09C9
		// (set) Token: 0x06003333 RID: 13107 RVA: 0x000B27D1 File Offset: 0x000B09D1
		public override int Timeout
		{
			get
			{
				return this.m_timeout;
			}
			set
			{
				if (value < 0 && value != -1)
				{
					throw new ArgumentOutOfRangeException("value", SR.GetString("Timeout can be only be set to 'System.Threading.Timeout.Infinite' or a value >= 0."));
				}
				this.m_timeout = value;
			}
		}

		/// <summary>Возвращает URI этого запроса.</summary>
		/// <returns>Экземпляр <see cref="T:System.Uri" />, в котором содержится URI запроса.</returns>
		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06003334 RID: 13108 RVA: 0x000B27F7 File Offset: 0x000B09F7
		public override Uri RequestUri
		{
			get
			{
				return this.m_uri;
			}
		}

		/// <summary>Начинает асинхронный запрос объекта <see cref="T:System.IO.Stream" />, используемого для записи данных.</summary>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />.</param>
		/// <param name="state">Объект, содержащий сведения о состоянии для этого запроса.</param>
		/// <returns>Класс <see cref="T:System.IAsyncResult" />, ссылающийся на асинхронный запрос.</returns>
		/// <exception cref="T:System.Net.ProtocolViolationException">Свойство <see cref="P:System.Net.FileWebRequest.Method" /> — <c>GET</c>, и приложение записывает в поток.</exception>
		/// <exception cref="T:System.InvalidOperationException">Поток занят предыдущим вызовом <see cref="M:System.Net.FileWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.ApplicationException">Отсутствует доступный поток записи.</exception>
		/// <exception cref="T:System.Net.WebException">Запрос <see cref="T:System.Net.FileWebRequest" /> был прерван.</exception>
		// Token: 0x06003335 RID: 13109 RVA: 0x000B2800 File Offset: 0x000B0A00
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
		{
			try
			{
				if (this.Aborted)
				{
					throw ExceptionHelper.RequestAbortedException;
				}
				if (!this.CanGetRequestStream())
				{
					throw new ProtocolViolationException(SR.GetString("Cannot send a content-body with this verb-type."));
				}
				if (this.m_response != null)
				{
					throw new InvalidOperationException(SR.GetString("This operation cannot be performed after the request has been submitted."));
				}
				lock (this)
				{
					if (this.m_writePending)
					{
						throw new InvalidOperationException(SR.GetString("Cannot re-call BeginGetRequestStream/BeginGetResponse while a previous call is still in progress."));
					}
					this.m_writePending = true;
				}
				this.m_ReadAResult = new LazyAsyncResult(this, state, callback);
				ThreadPool.QueueUserWorkItem(FileWebRequest.s_GetRequestStreamCallback, this.m_ReadAResult);
			}
			catch (Exception)
			{
				bool on = Logging.On;
				throw;
			}
			finally
			{
			}
			return this.m_ReadAResult;
		}

		/// <summary>Начинает асинхронный запрос ресурса файловой системы.</summary>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />.</param>
		/// <param name="state">Объект, содержащий сведения о состоянии для этого запроса.</param>
		/// <returns>Класс <see cref="T:System.IAsyncResult" />, ссылающийся на асинхронный запрос.</returns>
		/// <exception cref="T:System.InvalidOperationException">Поток уже используется предыдущим вызовом <see cref="M:System.Net.FileWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" /></exception>
		/// <exception cref="T:System.Net.WebException">Запрос <see cref="T:System.Net.FileWebRequest" /> был прерван.</exception>
		// Token: 0x06003336 RID: 13110 RVA: 0x000B28DC File Offset: 0x000B0ADC
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
		{
			try
			{
				if (this.Aborted)
				{
					throw ExceptionHelper.RequestAbortedException;
				}
				lock (this)
				{
					if (this.m_readPending)
					{
						throw new InvalidOperationException(SR.GetString("Cannot re-call BeginGetRequestStream/BeginGetResponse while a previous call is still in progress."));
					}
					this.m_readPending = true;
				}
				this.m_WriteAResult = new LazyAsyncResult(this, state, callback);
				ThreadPool.QueueUserWorkItem(FileWebRequest.s_GetResponseCallback, this.m_WriteAResult);
			}
			catch (Exception)
			{
				bool on = Logging.On;
				throw;
			}
			finally
			{
			}
			return this.m_WriteAResult;
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x000B2988 File Offset: 0x000B0B88
		private bool CanGetRequestStream()
		{
			return !KnownHttpVerb.Parse(this.m_method).ContentBodyNotAllowed;
		}

		/// <summary>Завершает асинхронный запрос экземпляра класса <see cref="T:System.IO.Stream" />, используемого приложением для записи данных.</summary>
		/// <param name="asyncResult">
		///   <see cref="T:System.IAsyncResult" />, ссылающийся на отложенный запрос для потока.</param>
		/// <returns>Объект <see cref="T:System.IO.Stream" />, используемый приложением для записи данных.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asyncResult" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003338 RID: 13112 RVA: 0x000B29A0 File Offset: 0x000B0BA0
		public override Stream EndGetRequestStream(IAsyncResult asyncResult)
		{
			Stream result;
			try
			{
				LazyAsyncResult lazyAsyncResult = asyncResult as LazyAsyncResult;
				if (asyncResult == null || lazyAsyncResult == null)
				{
					throw (asyncResult == null) ? new ArgumentNullException("asyncResult") : new ArgumentException(SR.GetString("The AsyncResult is not valid."), "asyncResult");
				}
				object obj = lazyAsyncResult.InternalWaitForCompletion();
				if (obj is Exception)
				{
					throw (Exception)obj;
				}
				result = (Stream)obj;
				this.m_writePending = false;
			}
			catch (Exception)
			{
				bool on = Logging.On;
				throw;
			}
			finally
			{
			}
			return result;
		}

		/// <summary>Завершает асинхронный запрос ресурса файловой системы.</summary>
		/// <param name="asyncResult">
		///   <see cref="T:System.IAsyncResult" />, ссылающийся на отложенный запрос ответа.</param>
		/// <returns>Класс <see cref="T:System.Net.WebResponse" />, содержащий ответ ресурса файловой системы.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asyncResult" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003339 RID: 13113 RVA: 0x000B2A2C File Offset: 0x000B0C2C
		public override WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			WebResponse result;
			try
			{
				LazyAsyncResult lazyAsyncResult = asyncResult as LazyAsyncResult;
				if (asyncResult == null || lazyAsyncResult == null)
				{
					throw (asyncResult == null) ? new ArgumentNullException("asyncResult") : new ArgumentException(SR.GetString("The AsyncResult is not valid."), "asyncResult");
				}
				object obj = lazyAsyncResult.InternalWaitForCompletion();
				if (obj is Exception)
				{
					throw (Exception)obj;
				}
				result = (WebResponse)obj;
				this.m_readPending = false;
			}
			catch (Exception)
			{
				bool on = Logging.On;
				throw;
			}
			finally
			{
			}
			return result;
		}

		/// <summary>Возвращает экземпляр объекта <see cref="T:System.IO.Stream" /> для записи данных в ресурс файловой системы.</summary>
		/// <returns>Класс <see cref="T:System.IO.Stream" /> для записи данных в ресурс файловой системы.</returns>
		/// <exception cref="T:System.Net.WebException">Истек срок действия запроса.</exception>
		// Token: 0x0600333A RID: 13114 RVA: 0x000B2AB8 File Offset: 0x000B0CB8
		public override Stream GetRequestStream()
		{
			IAsyncResult asyncResult;
			try
			{
				asyncResult = this.BeginGetRequestStream(null, null);
				if (this.Timeout != -1 && !asyncResult.IsCompleted && (!asyncResult.AsyncWaitHandle.WaitOne(this.Timeout, false) || !asyncResult.IsCompleted))
				{
					if (this.m_stream != null)
					{
						this.m_stream.Close();
					}
					throw new WebException(NetRes.GetWebStatusString(WebExceptionStatus.Timeout), WebExceptionStatus.Timeout);
				}
			}
			catch (Exception)
			{
				bool on = Logging.On;
				throw;
			}
			finally
			{
			}
			return this.EndGetRequestStream(asyncResult);
		}

		/// <summary>Возвращает ответ на запрос файловой системы.</summary>
		/// <returns>Класс <see cref="T:System.Net.WebResponse" />, содержащий ответ ресурса файловой системы.</returns>
		/// <exception cref="T:System.Net.WebException">Истек срок действия запроса.</exception>
		// Token: 0x0600333B RID: 13115 RVA: 0x000B2B4C File Offset: 0x000B0D4C
		public override WebResponse GetResponse()
		{
			this.m_syncHint = true;
			IAsyncResult asyncResult;
			try
			{
				asyncResult = this.BeginGetResponse(null, null);
				if (this.Timeout != -1 && !asyncResult.IsCompleted && (!asyncResult.AsyncWaitHandle.WaitOne(this.Timeout, false) || !asyncResult.IsCompleted))
				{
					if (this.m_response != null)
					{
						this.m_response.Close();
					}
					throw new WebException(NetRes.GetWebStatusString(WebExceptionStatus.Timeout), WebExceptionStatus.Timeout);
				}
			}
			catch (Exception)
			{
				bool on = Logging.On;
				throw;
			}
			finally
			{
			}
			return this.EndGetResponse(asyncResult);
		}

		// Token: 0x0600333C RID: 13116 RVA: 0x000B2BE8 File Offset: 0x000B0DE8
		private static void GetRequestStreamCallback(object state)
		{
			LazyAsyncResult lazyAsyncResult = (LazyAsyncResult)state;
			FileWebRequest fileWebRequest = (FileWebRequest)lazyAsyncResult.AsyncObject;
			try
			{
				if (fileWebRequest.m_stream == null)
				{
					fileWebRequest.m_stream = new FileWebStream(fileWebRequest, fileWebRequest.m_uri.LocalPath, FileMode.Create, FileAccess.Write, FileShare.Read);
					fileWebRequest.m_fileAccess = FileAccess.Write;
					fileWebRequest.m_writing = true;
				}
			}
			catch (Exception ex)
			{
				Exception result = new WebException(ex.Message, ex);
				lazyAsyncResult.InvokeCallback(result);
				return;
			}
			lazyAsyncResult.InvokeCallback(fileWebRequest.m_stream);
		}

		// Token: 0x0600333D RID: 13117 RVA: 0x000B2C70 File Offset: 0x000B0E70
		private static void GetResponseCallback(object state)
		{
			LazyAsyncResult lazyAsyncResult = (LazyAsyncResult)state;
			FileWebRequest fileWebRequest = (FileWebRequest)lazyAsyncResult.AsyncObject;
			if (fileWebRequest.m_writePending || fileWebRequest.m_writing)
			{
				FileWebRequest obj = fileWebRequest;
				lock (obj)
				{
					if (fileWebRequest.m_writePending || fileWebRequest.m_writing)
					{
						fileWebRequest.m_readerEvent = new ManualResetEvent(false);
					}
				}
			}
			if (fileWebRequest.m_readerEvent != null)
			{
				fileWebRequest.m_readerEvent.WaitOne();
			}
			try
			{
				if (fileWebRequest.m_response == null)
				{
					fileWebRequest.m_response = new FileWebResponse(fileWebRequest, fileWebRequest.m_uri, fileWebRequest.m_fileAccess, !fileWebRequest.m_syncHint);
				}
			}
			catch (Exception ex)
			{
				Exception result = new WebException(ex.Message, ex);
				lazyAsyncResult.InvokeCallback(result);
				return;
			}
			lazyAsyncResult.InvokeCallback(fileWebRequest.m_response);
		}

		// Token: 0x0600333E RID: 13118 RVA: 0x000B2D58 File Offset: 0x000B0F58
		internal void UnblockReader()
		{
			lock (this)
			{
				if (this.m_readerEvent != null)
				{
					this.m_readerEvent.Set();
				}
			}
			this.m_writing = false;
		}

		/// <summary>Всегда создает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>Всегда создает исключение <see cref="T:System.NotSupportedException" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Учетные данные по умолчанию не поддерживается для URI файлов.</exception>
		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x0600333F RID: 13119 RVA: 0x000A0568 File Offset: 0x0009E768
		// (set) Token: 0x06003340 RID: 13120 RVA: 0x000A0568 File Offset: 0x0009E768
		public override bool UseDefaultCredentials
		{
			get
			{
				throw ExceptionHelper.PropertyNotSupportedException;
			}
			set
			{
				throw ExceptionHelper.PropertyNotSupportedException;
			}
		}

		/// <summary>Отменяет запрос к интернет-ресурсу.</summary>
		// Token: 0x06003341 RID: 13121 RVA: 0x000B2DA8 File Offset: 0x000B0FA8
		public override void Abort()
		{
			bool on = Logging.On;
			try
			{
				if (Interlocked.Increment(ref this.m_Aborted) == 1)
				{
					LazyAsyncResult readAResult = this.m_ReadAResult;
					LazyAsyncResult writeAResult = this.m_WriteAResult;
					WebException result = new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.RequestCanceled), WebExceptionStatus.RequestCanceled);
					Stream stream = this.m_stream;
					if (readAResult != null && !readAResult.IsCompleted)
					{
						readAResult.InvokeCallback(result);
					}
					if (writeAResult != null && !writeAResult.IsCompleted)
					{
						writeAResult.InvokeCallback(result);
					}
					if (stream != null)
					{
						if (stream is ICloseEx)
						{
							((ICloseEx)stream).CloseEx(CloseExState.Abort);
						}
						else
						{
							stream.Close();
						}
					}
					if (this.m_response != null)
					{
						((ICloseEx)this.m_response).CloseEx(CloseExState.Abort);
					}
				}
			}
			catch (Exception)
			{
				bool on2 = Logging.On;
				throw;
			}
			finally
			{
			}
		}

		// Token: 0x04001DFB RID: 7675
		private static WaitCallback s_GetRequestStreamCallback = new WaitCallback(FileWebRequest.GetRequestStreamCallback);

		// Token: 0x04001DFC RID: 7676
		private static WaitCallback s_GetResponseCallback = new WaitCallback(FileWebRequest.GetResponseCallback);

		// Token: 0x04001DFD RID: 7677
		private string m_connectionGroupName;

		// Token: 0x04001DFE RID: 7678
		private long m_contentLength;

		// Token: 0x04001DFF RID: 7679
		private ICredentials m_credentials;

		// Token: 0x04001E00 RID: 7680
		private FileAccess m_fileAccess;

		// Token: 0x04001E01 RID: 7681
		private WebHeaderCollection m_headers;

		// Token: 0x04001E02 RID: 7682
		private string m_method = "GET";

		// Token: 0x04001E03 RID: 7683
		private bool m_preauthenticate;

		// Token: 0x04001E04 RID: 7684
		private IWebProxy m_proxy;

		// Token: 0x04001E05 RID: 7685
		private ManualResetEvent m_readerEvent;

		// Token: 0x04001E06 RID: 7686
		private bool m_readPending;

		// Token: 0x04001E07 RID: 7687
		private WebResponse m_response;

		// Token: 0x04001E08 RID: 7688
		private Stream m_stream;

		// Token: 0x04001E09 RID: 7689
		private bool m_syncHint;

		// Token: 0x04001E0A RID: 7690
		private int m_timeout = 100000;

		// Token: 0x04001E0B RID: 7691
		private Uri m_uri;

		// Token: 0x04001E0C RID: 7692
		private bool m_writePending;

		// Token: 0x04001E0D RID: 7693
		private bool m_writing;

		// Token: 0x04001E0E RID: 7694
		private LazyAsyncResult m_WriteAResult;

		// Token: 0x04001E0F RID: 7695
		private LazyAsyncResult m_ReadAResult;

		// Token: 0x04001E10 RID: 7696
		private int m_Aborted;
	}
}
