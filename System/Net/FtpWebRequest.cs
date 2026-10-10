using System;
using System.IO;
using System.Net.Cache;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Unity;

namespace System.Net
{
	/// <summary>Реализует FTP-клиент.</summary>
	// Token: 0x0200058E RID: 1422
	public sealed class FtpWebRequest : WebRequest
	{
		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06002E0D RID: 11789 RVA: 0x0009EC94 File Offset: 0x0009CE94
		internal FtpMethodInfo MethodInfo
		{
			get
			{
				return this._methodInfo;
			}
		}

		/// <summary>Определяет политику кэширования по умолчанию для всех запросов FTP.</summary>
		/// <returns>Объект <see cref="T:System.Net.Cache.RequestCachePolicy" />, который определяет политику кэширования для запросов FTP.</returns>
		/// <exception cref="T:System.ArgumentNullException">Вызывающий объект пытался установить значение этого свойства, равное <see langword="null" />.</exception>
		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06002E0E RID: 11790 RVA: 0x0009EC9C File Offset: 0x0009CE9C
		// (set) Token: 0x06002E0F RID: 11791 RVA: 0x00003917 File Offset: 0x00001B17
		public new static RequestCachePolicy DefaultCachePolicy
		{
			get
			{
				return WebRequest.DefaultCachePolicy;
			}
			set
			{
			}
		}

		/// <summary>Возвращает или задает команду, которая будет отправлена на FTP-сервер.</summary>
		/// <returns>Значение <see cref="T:System.String" />, содержащее FTP-команду для отправки на сервер. Значение по умолчанию — <see cref="F:System.Net.WebRequestMethods.Ftp.DownloadFile" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Для этого свойства задано новое значение для уже выполняющегося запроса.</exception>
		/// <exception cref="T:System.ArgumentException">Метод является недопустимым.  
		///
		/// или - 
		/// Метод не поддерживается.  
		///
		/// или - 
		/// Было указано несколько методов.</exception>
		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06002E10 RID: 11792 RVA: 0x0009ECA3 File Offset: 0x0009CEA3
		// (set) Token: 0x06002E11 RID: 11793 RVA: 0x0009ECB0 File Offset: 0x0009CEB0
		public override string Method
		{
			get
			{
				return this._methodInfo.Method;
			}
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("FTP Method names cannot be null or empty.", "value");
				}
				if (this.InUse)
				{
					throw new InvalidOperationException("This operation cannot be performed after the request has been submitted.");
				}
				try
				{
					this._methodInfo = FtpMethodInfo.GetMethodInfo(value);
				}
				catch (ArgumentException)
				{
					throw new ArgumentException("This method is not supported.", "value");
				}
			}
		}

		/// <summary>Возвращает или задает новое имя переименовываемого файла.</summary>
		/// <returns>Новое имя переименовываемого файла.</returns>
		/// <exception cref="T:System.ArgumentException">Значение, указанное для операции Set, равно <see langword="null" /> или пустой строке.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для этого свойства задано новое значение для уже выполняющегося запроса.</exception>
		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06002E12 RID: 11794 RVA: 0x0009ED18 File Offset: 0x0009CF18
		// (set) Token: 0x06002E13 RID: 11795 RVA: 0x0009ED20 File Offset: 0x0009CF20
		public string RenameTo
		{
			get
			{
				return this._renameTo;
			}
			set
			{
				if (this.InUse)
				{
					throw new InvalidOperationException("This operation cannot be performed after the request has been submitted.");
				}
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("The RenameTo filename cannot be null or empty.", "value");
				}
				this._renameTo = value;
			}
		}

		/// <summary>Возвращает или задает учетные данные, используемые для связи с FTP-сервером.</summary>
		/// <returns>Экземпляр <see cref="T:System.Net.ICredentials" />; в противном случае — <see langword="null" />, если свойство не было задано.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для операции задания указано значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Для операции присвоения был указан тип <see cref="T:System.Net.ICredentials" />, отличный от <see cref="T:System.Net.NetworkCredential" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для этого свойства задано новое значение для уже выполняющегося запроса.</exception>
		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06002E14 RID: 11796 RVA: 0x0009ED54 File Offset: 0x0009CF54
		// (set) Token: 0x06002E15 RID: 11797 RVA: 0x0009ED5C File Offset: 0x0009CF5C
		public override ICredentials Credentials
		{
			get
			{
				return this._authInfo;
			}
			set
			{
				if (this.InUse)
				{
					throw new InvalidOperationException("This operation cannot be performed after the request has been submitted.");
				}
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				if (value == CredentialCache.DefaultNetworkCredentials)
				{
					throw new ArgumentException("Default credentials are not supported on an FTP request.", "value");
				}
				this._authInfo = value;
			}
		}

		/// <summary>Возвращает универсальный код ресурса (URI), запрошенный этим экземпляром.</summary>
		/// <returns>Экземпляр <see cref="T:System.Uri" />, идентифицирующий ресурс, доступ к которому предоставляется посредством FTP.</returns>
		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06002E16 RID: 11798 RVA: 0x0009EDA9 File Offset: 0x0009CFA9
		public override Uri RequestUri
		{
			get
			{
				return this._uri;
			}
		}

		/// <summary>Возвращает или задает количество миллисекунд для ожидания запроса.</summary>
		/// <returns>Значение <see cref="T:System.Int32" />, которое содержит количество миллисекунд для ожидания перед завершением срока действия запроса. Значение по умолчанию — <see cref="F:System.Threading.Timeout.Infinite" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Указанное значение меньше нуля и не равно <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для этого свойства задано новое значение для уже выполняющегося запроса.</exception>
		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06002E17 RID: 11799 RVA: 0x0009EDB1 File Offset: 0x0009CFB1
		// (set) Token: 0x06002E18 RID: 11800 RVA: 0x0009EDBC File Offset: 0x0009CFBC
		public override int Timeout
		{
			get
			{
				return this._timeout;
			}
			set
			{
				if (this.InUse)
				{
					throw new InvalidOperationException("This operation cannot be performed after the request has been submitted.");
				}
				if (value < 0 && value != -1)
				{
					throw new ArgumentOutOfRangeException("value", "Timeout can be only be set to 'System.Threading.Timeout.Infinite' or a value >= 0.");
				}
				if (this._timeout != value)
				{
					this._timeout = value;
					this._timerQueue = null;
				}
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06002E19 RID: 11801 RVA: 0x0009EE0B File Offset: 0x0009D00B
		internal int RemainingTimeout
		{
			get
			{
				return this._remainingTimeout;
			}
		}

		/// <summary>Возвращает или задает время ожидания при записи в поток или при чтении из него.</summary>
		/// <returns>Количество миллисекунд до истечения срока действия записи или чтения. По умолчанию установлено значение 300 000 миллисекунд (5 минут).</returns>
		/// <exception cref="T:System.InvalidOperationException">Запрос уже был отправлен.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Указанное значение для операции присвоения меньше или равно нулю и не равно <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06002E1A RID: 11802 RVA: 0x0009EE13 File Offset: 0x0009D013
		// (set) Token: 0x06002E1B RID: 11803 RVA: 0x0009EE1B File Offset: 0x0009D01B
		public int ReadWriteTimeout
		{
			get
			{
				return this._readWriteTimeout;
			}
			set
			{
				if (this._getResponseStarted)
				{
					throw new InvalidOperationException("This operation cannot be performed after the request has been submitted.");
				}
				if (value <= 0 && value != -1)
				{
					throw new ArgumentOutOfRangeException("value", "Timeout can be only be set to 'System.Threading.Timeout.Infinite' or a value > 0.");
				}
				this._readWriteTimeout = value;
			}
		}

		/// <summary>Возвращает или задает смещение в байтах для файла, скачиваемого через этот запрос.</summary>
		/// <returns>Экземпляр <see cref="T:System.Int64" />, указывающий смещение файла (в байтах). Значение по умолчанию равно нулю.</returns>
		/// <exception cref="T:System.InvalidOperationException">Для этого свойства задано новое значение для уже выполняющегося запроса.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Заданное для этого свойства значение меньше нуля.</exception>
		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06002E1C RID: 11804 RVA: 0x0009EE4F File Offset: 0x0009D04F
		// (set) Token: 0x06002E1D RID: 11805 RVA: 0x0009EE57 File Offset: 0x0009D057
		public long ContentOffset
		{
			get
			{
				return this._contentOffset;
			}
			set
			{
				if (this.InUse)
				{
					throw new InvalidOperationException("This operation cannot be performed after the request has been submitted.");
				}
				if (value < 0L)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._contentOffset = value;
			}
		}

		/// <summary>Возвращает или задает значение, игнорируемое классом <see cref="T:System.Net.FtpWebRequest" />.</summary>
		/// <returns>Значение <see cref="T:System.Int64" />, которое следует игнорировать.</returns>
		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06002E1E RID: 11806 RVA: 0x0009EE83 File Offset: 0x0009D083
		// (set) Token: 0x06002E1F RID: 11807 RVA: 0x0009EE8B File Offset: 0x0009D08B
		public override long ContentLength
		{
			get
			{
				return this._contentLength;
			}
			set
			{
				this._contentLength = value;
			}
		}

		/// <summary>Возвращает или задает прокси-сервер, используемый для связи с FTP-сервером.</summary>
		/// <returns>Экземпляр <see cref="T:System.Net.IWebProxy" />, ответственный за связь с FTP-сервером. В .NET Core, его значение равно <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значением этого свойства не может быть <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Для этого свойства задано новое значение для уже выполняющегося запроса.</exception>
		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06002E20 RID: 11808 RVA: 0x00002F6A File Offset: 0x0000116A
		// (set) Token: 0x06002E21 RID: 11809 RVA: 0x0009EE94 File Offset: 0x0009D094
		public override IWebProxy Proxy
		{
			get
			{
				return null;
			}
			set
			{
				if (this.InUse)
				{
					throw new InvalidOperationException("This operation cannot be performed after the request has been submitted.");
				}
			}
		}

		/// <summary>Возвращает или задает имя группы подключения, которая содержит точку обслуживания, используемую для отправки текущего запроса.</summary>
		/// <returns>Значение <see cref="T:System.String" />, которое содержит имя группы подключения.</returns>
		/// <exception cref="T:System.InvalidOperationException">Для этого свойства задано новое значение для уже выполняющегося запроса.</exception>
		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06002E22 RID: 11810 RVA: 0x0009EEA9 File Offset: 0x0009D0A9
		// (set) Token: 0x06002E23 RID: 11811 RVA: 0x0009EEB1 File Offset: 0x0009D0B1
		public override string ConnectionGroupName
		{
			get
			{
				return this._connectionGroupName;
			}
			set
			{
				if (this.InUse)
				{
					throw new InvalidOperationException("This operation cannot be performed after the request has been submitted.");
				}
				this._connectionGroupName = value;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Net.ServicePoint" />, используемый для подключения к FTP-серверу.</summary>
		/// <returns>Объект <see cref="T:System.Net.ServicePoint" /> может использоваться для настройки поведения при подключении.</returns>
		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06002E24 RID: 11812 RVA: 0x0009EECD File Offset: 0x0009D0CD
		public ServicePoint ServicePoint
		{
			get
			{
				if (this._servicePoint == null)
				{
					this._servicePoint = ServicePointManager.FindServicePoint(this._uri);
				}
				return this._servicePoint;
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06002E25 RID: 11813 RVA: 0x0009EEEE File Offset: 0x0009D0EE
		internal bool Aborted
		{
			get
			{
				return this._aborted;
			}
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x0009EEF8 File Offset: 0x0009D0F8
		internal FtpWebRequest(Uri uri)
		{
			this._timeout = 100000;
			this._passive = true;
			this._binary = true;
			this._timerQueue = FtpWebRequest.s_DefaultTimerQueue;
			this._readWriteTimeout = 300000;
			base..ctor();
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Info(this, uri, ".ctor");
			}
			if (uri.Scheme != Uri.UriSchemeFtp)
			{
				throw new ArgumentOutOfRangeException("uri");
			}
			this._timerCallback = new TimerThread.Callback(this.TimerCallback);
			this._syncObject = new object();
			NetworkCredential networkCredential = null;
			this._uri = uri;
			this._methodInfo = FtpMethodInfo.GetMethodInfo("RETR");
			if (this._uri.UserInfo != null && this._uri.UserInfo.Length != 0)
			{
				string userInfo = this._uri.UserInfo;
				string userName = userInfo;
				string password = "";
				int num = userInfo.IndexOf(':');
				if (num != -1)
				{
					userName = Uri.UnescapeDataString(userInfo.Substring(0, num));
					num++;
					password = Uri.UnescapeDataString(userInfo.Substring(num, userInfo.Length - num));
				}
				networkCredential = new NetworkCredential(userName, password);
			}
			if (networkCredential == null)
			{
				networkCredential = FtpWebRequest.s_defaultFtpNetworkCredential;
			}
			this._authInfo = networkCredential;
		}

		/// <summary>Возвращает ответ FTP-сервера.</summary>
		/// <returns>Ссылка <see cref="T:System.Net.WebResponse" />, которая содержит экземпляр <see cref="T:System.Net.FtpWebResponse" />. Этот объект содержит ответ FTP-сервера на запрос.</returns>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="M:System.Net.FtpWebRequest.GetResponse" /> или <see cref="M:System.Net.FtpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" /> уже был вызван для этого экземпляра.  
		/// -или- 
		/// Прокси-сервер HTTP включен, и была предпринята попытка использования FTP-команды, отличной от <see cref="F:System.Net.WebRequestMethods.Ftp.DownloadFile" />, <see cref="F:System.Net.WebRequestMethods.Ftp.ListDirectory" /> или <see cref="F:System.Net.WebRequestMethods.Ftp.ListDirectoryDetails" />.</exception>
		/// <exception cref="T:System.Net.WebException">Значение свойства <see cref="P:System.Net.FtpWebRequest.EnableSsl" /> равно <see langword="true" />, однако сервер не поддерживает эту функциональную возможность.  
		///
		/// или - 
		/// Срок ожидания <see cref="P:System.Net.FtpWebRequest.Timeout" /> был указан и истек.</exception>
		// Token: 0x06002E27 RID: 11815 RVA: 0x0009F024 File Offset: 0x0009D224
		public override WebResponse GetResponse()
		{
			if (NetEventSource.IsEnabled)
			{
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Enter(this, null, "GetResponse");
				}
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Info(this, FormattableStringFactory.Create("Method: {0}", new object[]
					{
						this._methodInfo.Method
					}), "GetResponse");
				}
			}
			try
			{
				this.CheckError();
				if (this._ftpWebResponse != null)
				{
					return this._ftpWebResponse;
				}
				if (this._getResponseStarted)
				{
					throw new InvalidOperationException("Cannot re-call BeginGetRequestStream/BeginGetResponse while a previous call is still in progress.");
				}
				this._getResponseStarted = true;
				this._startTime = DateTime.UtcNow;
				this._remainingTimeout = this.Timeout;
				if (this.Timeout != -1)
				{
					this._remainingTimeout = this.Timeout - (int)(DateTime.UtcNow - this._startTime).TotalMilliseconds;
					if (this._remainingTimeout <= 0)
					{
						throw ExceptionHelper.TimeoutException;
					}
				}
				FtpWebRequest.RequestStage requestStage = this.FinishRequestStage(FtpWebRequest.RequestStage.RequestStarted);
				if (requestStage >= FtpWebRequest.RequestStage.RequestStarted)
				{
					if (requestStage < FtpWebRequest.RequestStage.ReadReady)
					{
						object syncObject = this._syncObject;
						lock (syncObject)
						{
							if (this._requestStage < FtpWebRequest.RequestStage.ReadReady)
							{
								this._readAsyncResult = new LazyAsyncResult(null, null, null);
							}
						}
						if (this._readAsyncResult != null)
						{
							this._readAsyncResult.InternalWaitForCompletion();
						}
						this.CheckError();
					}
				}
				else
				{
					this.SubmitRequest(false);
					if (this._methodInfo.IsUpload)
					{
						this.FinishRequestStage(FtpWebRequest.RequestStage.WriteReady);
					}
					else
					{
						this.FinishRequestStage(FtpWebRequest.RequestStage.ReadReady);
					}
					this.CheckError();
					this.EnsureFtpWebResponse(null);
				}
			}
			catch (Exception ex)
			{
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Error(this, ex, "GetResponse");
				}
				if (this._exception == null)
				{
					if (NetEventSource.IsEnabled)
					{
						NetEventSource.Error(this, ex, "GetResponse");
					}
					this.SetException(ex);
					this.FinishRequestStage(FtpWebRequest.RequestStage.CheckForError);
				}
				throw;
			}
			finally
			{
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Exit(this, this._ftpWebResponse, "GetResponse");
				}
			}
			return this._ftpWebResponse;
		}

		/// <summary>Начинает асинхронно отправлять запрос и получать ответ с FTP-сервера.</summary>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, вызываемый по завершении данной операции.</param>
		/// <param name="state">Пользовательский объект, содержащий сведения об операции. Этот объект передается делегату <paramref name="callback" /> после завершения операции.</param>
		/// <returns>Экземпляр <see cref="T:System.IAsyncResult" />, представляющий состояние операции.</returns>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="M:System.Net.FtpWebRequest.GetResponse" /> или <see cref="M:System.Net.FtpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" /> уже был вызван для этого экземпляра.</exception>
		// Token: 0x06002E28 RID: 11816 RVA: 0x0009F250 File Offset: 0x0009D450
		public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Enter(this, null, "BeginGetResponse");
				NetEventSource.Info(this, FormattableStringFactory.Create("Method: {0}", new object[]
				{
					this._methodInfo.Method
				}), "BeginGetResponse");
			}
			ContextAwareResult contextAwareResult;
			try
			{
				if (this._ftpWebResponse != null)
				{
					contextAwareResult = new ContextAwareResult(this, state, callback);
					contextAwareResult.InvokeCallback(this._ftpWebResponse);
					return contextAwareResult;
				}
				if (this._getResponseStarted)
				{
					throw new InvalidOperationException("Cannot re-call BeginGetRequestStream/BeginGetResponse while a previous call is still in progress.");
				}
				this._getResponseStarted = true;
				this.CheckError();
				FtpWebRequest.RequestStage requestStage = this.FinishRequestStage(FtpWebRequest.RequestStage.RequestStarted);
				contextAwareResult = new ContextAwareResult(true, true, this, state, callback);
				this._readAsyncResult = contextAwareResult;
				if (requestStage >= FtpWebRequest.RequestStage.RequestStarted)
				{
					contextAwareResult.StartPostingAsyncOp();
					contextAwareResult.FinishPostingAsyncOp();
					if (requestStage >= FtpWebRequest.RequestStage.ReadReady)
					{
						contextAwareResult = null;
					}
					else
					{
						object obj = this._syncObject;
						lock (obj)
						{
							if (this._requestStage >= FtpWebRequest.RequestStage.ReadReady)
							{
								contextAwareResult = null;
							}
						}
					}
					if (contextAwareResult == null)
					{
						contextAwareResult = (ContextAwareResult)this._readAsyncResult;
						if (!contextAwareResult.InternalPeekCompleted)
						{
							contextAwareResult.InvokeCallback();
						}
					}
				}
				else
				{
					object obj = contextAwareResult.StartPostingAsyncOp();
					lock (obj)
					{
						this.SubmitRequest(true);
						contextAwareResult.FinishPostingAsyncOp();
					}
					this.FinishRequestStage(FtpWebRequest.RequestStage.CheckForError);
				}
			}
			catch (Exception message)
			{
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Error(this, message, "BeginGetResponse");
				}
				throw;
			}
			finally
			{
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Exit(this, null, "BeginGetResponse");
				}
			}
			return contextAwareResult;
		}

		/// <summary>Завершает асинхронную операцию в очереди, начинавшуюся с <see cref="M:System.Net.FtpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />.</summary>
		/// <param name="asyncResult">Объект <see cref="T:System.IAsyncResult" />, который был возвращен в начале операции.</param>
		/// <returns>Ссылка <see cref="T:System.Net.WebResponse" />, которая содержит экземпляр <see cref="T:System.Net.FtpWebResponse" />. Этот объект содержит ответ FTP-сервера на запрос.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asyncResult" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="asyncResult" /> не был получен путем вызова <see cref="M:System.Net.FtpWebRequest.BeginGetResponse(System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Этот метод уже был вызван для операции, указанной в параметре <paramref name="asyncResult" />.</exception>
		/// <exception cref="T:System.Net.WebException">Произошла ошибка при использовании прокси-сервера HTTP.</exception>
		// Token: 0x06002E29 RID: 11817 RVA: 0x0009F428 File Offset: 0x0009D628
		public override WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Enter(this, null, "EndGetResponse");
			}
			try
			{
				if (asyncResult == null)
				{
					throw new ArgumentNullException("asyncResult");
				}
				LazyAsyncResult lazyAsyncResult = asyncResult as LazyAsyncResult;
				if (lazyAsyncResult == null)
				{
					throw new ArgumentException("The IAsyncResult object was not returned from the corresponding asynchronous method on this class.", "asyncResult");
				}
				if (lazyAsyncResult.EndCalled)
				{
					throw new InvalidOperationException(SR.Format("{0} can only be called once for each asynchronous operation.", "EndGetResponse"));
				}
				lazyAsyncResult.InternalWaitForCompletion();
				lazyAsyncResult.EndCalled = true;
				this.CheckError();
			}
			catch (Exception message)
			{
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Error(this, message, "EndGetResponse");
				}
				throw;
			}
			finally
			{
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Exit(this, null, "EndGetResponse");
				}
			}
			return this._ftpWebResponse;
		}

		/// <summary>Возвращает поток, используемый для выгрузки данных на FTP-сервер.</summary>
		/// <returns>Доступный для записи экземпляр <see cref="T:System.IO.Stream" />, используемый для хранения данных, отправляемых на сервер текущим запросом.</returns>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Net.FtpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" /> был вызван, но не был завершен.  
		///
		/// или - 
		/// Прокси-сервер HTTP включен, и была предпринята попытка использования FTP-команды, отличной от <see cref="F:System.Net.WebRequestMethods.Ftp.DownloadFile" />, <see cref="F:System.Net.WebRequestMethods.Ftp.ListDirectory" /> или <see cref="F:System.Net.WebRequestMethods.Ftp.ListDirectoryDetails" />.</exception>
		/// <exception cref="T:System.Net.WebException">Не удается установить подключение к FTP-серверу.</exception>
		/// <exception cref="T:System.Net.ProtocolViolationException">Свойству <see cref="P:System.Net.FtpWebRequest.Method" /> не присвоено значение <see cref="F:System.Net.WebRequestMethods.Ftp.UploadFile" /> или <see cref="F:System.Net.WebRequestMethods.Ftp.AppendFile" />.</exception>
		// Token: 0x06002E2A RID: 11818 RVA: 0x0009F4F0 File Offset: 0x0009D6F0
		public override Stream GetRequestStream()
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Enter(this, null, "GetRequestStream");
				NetEventSource.Info(this, FormattableStringFactory.Create("Method: {0}", new object[]
				{
					this._methodInfo.Method
				}), "GetRequestStream");
			}
			try
			{
				if (this._getRequestStreamStarted)
				{
					throw new InvalidOperationException("Cannot re-call BeginGetRequestStream/BeginGetResponse while a previous call is still in progress.");
				}
				this._getRequestStreamStarted = true;
				if (!this._methodInfo.IsUpload)
				{
					throw new ProtocolViolationException("Cannot send a content-body with this verb-type.");
				}
				this.CheckError();
				this._startTime = DateTime.UtcNow;
				this._remainingTimeout = this.Timeout;
				if (this.Timeout != -1)
				{
					this._remainingTimeout = this.Timeout - (int)(DateTime.UtcNow - this._startTime).TotalMilliseconds;
					if (this._remainingTimeout <= 0)
					{
						throw ExceptionHelper.TimeoutException;
					}
				}
				this.FinishRequestStage(FtpWebRequest.RequestStage.RequestStarted);
				this.SubmitRequest(false);
				this.FinishRequestStage(FtpWebRequest.RequestStage.WriteReady);
				this.CheckError();
				if (this._stream.CanTimeout)
				{
					this._stream.WriteTimeout = this.ReadWriteTimeout;
					this._stream.ReadTimeout = this.ReadWriteTimeout;
				}
			}
			catch (Exception message)
			{
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Error(this, message, "GetRequestStream");
				}
				throw;
			}
			finally
			{
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Exit(this, null, "GetRequestStream");
				}
			}
			return this._stream;
		}

		/// <summary>Начинает асинхронное открытие потока с содержимым запроса для записи.</summary>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, вызываемый по завершении данной операции.</param>
		/// <param name="state">Пользовательский объект, содержащий сведения об операции. Этот объект передается делегату <paramref name="callback" /> после завершения операции.</param>
		/// <returns>Экземпляр <see cref="T:System.IAsyncResult" />, представляющий состояние операции.</returns>
		/// <exception cref="T:System.InvalidOperationException">Предыдущий вызов этого метода или потока <see cref="M:System.Net.FtpWebRequest.GetRequestStream" /> еще не был завершен.</exception>
		/// <exception cref="T:System.Net.WebException">Не удается установить подключение к FTP-серверу.</exception>
		/// <exception cref="T:System.Net.ProtocolViolationException">Свойству <see cref="P:System.Net.FtpWebRequest.Method" /> невозможно присвоить значение <see cref="F:System.Net.WebRequestMethods.Ftp.UploadFile" />.</exception>
		// Token: 0x06002E2B RID: 11819 RVA: 0x0009F664 File Offset: 0x0009D864
		public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Enter(this, null, "BeginGetRequestStream");
				NetEventSource.Info(this, FormattableStringFactory.Create("Method: {0}", new object[]
				{
					this._methodInfo.Method
				}), "BeginGetRequestStream");
			}
			ContextAwareResult contextAwareResult = null;
			try
			{
				if (this._getRequestStreamStarted)
				{
					throw new InvalidOperationException("Cannot re-call BeginGetRequestStream/BeginGetResponse while a previous call is still in progress.");
				}
				this._getRequestStreamStarted = true;
				if (!this._methodInfo.IsUpload)
				{
					throw new ProtocolViolationException("Cannot send a content-body with this verb-type.");
				}
				this.CheckError();
				this.FinishRequestStage(FtpWebRequest.RequestStage.RequestStarted);
				contextAwareResult = new ContextAwareResult(true, true, this, state, callback);
				object obj = contextAwareResult.StartPostingAsyncOp();
				lock (obj)
				{
					this._writeAsyncResult = contextAwareResult;
					this.SubmitRequest(true);
					contextAwareResult.FinishPostingAsyncOp();
					this.FinishRequestStage(FtpWebRequest.RequestStage.CheckForError);
				}
			}
			catch (Exception message)
			{
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Error(this, message, "BeginGetRequestStream");
				}
				throw;
			}
			finally
			{
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Exit(this, null, "BeginGetRequestStream");
				}
			}
			return contextAwareResult;
		}

		/// <summary>Завершает асинхронную операцию в очереди, начинавшуюся с <see cref="M:System.Net.FtpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />.</summary>
		/// <param name="asyncResult">Объект <see cref="T:System.IAsyncResult" />, который был возвращен при начале операции.</param>
		/// <returns>Доступный для записи экземпляр <see cref="T:System.IO.Stream" />, который связан с этим экземпляром.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asyncResult" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="asyncResult" /> не был получен путем вызова <see cref="M:System.Net.FtpWebRequest.BeginGetRequestStream(System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Этот метод уже был вызван для операции, указанной в параметре <paramref name="asyncResult" />.</exception>
		// Token: 0x06002E2C RID: 11820 RVA: 0x0009F78C File Offset: 0x0009D98C
		public override Stream EndGetRequestStream(IAsyncResult asyncResult)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Enter(this, null, "EndGetRequestStream");
			}
			Stream stream = null;
			try
			{
				if (asyncResult == null)
				{
					throw new ArgumentNullException("asyncResult");
				}
				LazyAsyncResult lazyAsyncResult = asyncResult as LazyAsyncResult;
				if (lazyAsyncResult == null)
				{
					throw new ArgumentException("The IAsyncResult object was not returned from the corresponding asynchronous method on this class.", "asyncResult");
				}
				if (lazyAsyncResult.EndCalled)
				{
					throw new InvalidOperationException(SR.Format("{0} can only be called once for each asynchronous operation.", "EndGetResponse"));
				}
				lazyAsyncResult.InternalWaitForCompletion();
				lazyAsyncResult.EndCalled = true;
				this.CheckError();
				stream = this._stream;
				lazyAsyncResult.EndCalled = true;
				if (stream.CanTimeout)
				{
					stream.WriteTimeout = this.ReadWriteTimeout;
					stream.ReadTimeout = this.ReadWriteTimeout;
				}
			}
			catch (Exception message)
			{
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Error(this, message, "EndGetRequestStream");
				}
				throw;
			}
			finally
			{
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Exit(this, null, "EndGetRequestStream");
				}
			}
			return stream;
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x0009F87C File Offset: 0x0009DA7C
		private void SubmitRequest(bool isAsync)
		{
			try
			{
				this._async = isAsync;
				for (;;)
				{
					FtpControlStream ftpControlStream = this._connection;
					if (ftpControlStream == null)
					{
						if (isAsync)
						{
							break;
						}
						ftpControlStream = this.CreateConnection();
						this._connection = ftpControlStream;
					}
					if (!isAsync && this.Timeout != -1)
					{
						this._remainingTimeout = this.Timeout - (int)(DateTime.UtcNow - this._startTime).TotalMilliseconds;
						if (this._remainingTimeout <= 0)
						{
							goto Block_6;
						}
					}
					if (NetEventSource.IsEnabled)
					{
						NetEventSource.Info(this, "Request being submitted", "SubmitRequest");
					}
					ftpControlStream.SetSocketTimeoutOption(this.RemainingTimeout);
					try
					{
						this.TimedSubmitRequestHelper(isAsync);
					}
					catch (Exception e)
					{
						if (this.AttemptedRecovery(e))
						{
							if (!isAsync && this.Timeout != -1)
							{
								this._remainingTimeout = this.Timeout - (int)(DateTime.UtcNow - this._startTime).TotalMilliseconds;
								if (this._remainingTimeout <= 0)
								{
									throw;
								}
							}
							continue;
						}
						throw;
					}
					goto IL_E9;
				}
				this.CreateConnectionAsync();
				return;
				Block_6:
				throw ExceptionHelper.TimeoutException;
				IL_E9:;
			}
			catch (WebException ex)
			{
				IOException ex2 = ex.InnerException as IOException;
				if (ex2 != null)
				{
					SocketException ex3 = ex2.InnerException as SocketException;
					if (ex3 != null && ex3.SocketErrorCode == SocketError.TimedOut)
					{
						this.SetException(new WebException("The operation has timed out.", WebExceptionStatus.Timeout));
					}
				}
				this.SetException(ex);
			}
			catch (Exception exception)
			{
				this.SetException(exception);
			}
		}

		// Token: 0x06002E2E RID: 11822 RVA: 0x0009F9F8 File Offset: 0x0009DBF8
		private Exception TranslateConnectException(Exception e)
		{
			SocketException ex = e as SocketException;
			if (ex == null)
			{
				return e;
			}
			if (ex.SocketErrorCode == SocketError.HostNotFound)
			{
				return new WebException("The remote name could not be resolved", WebExceptionStatus.NameResolutionFailure);
			}
			return new WebException("Unable to connect to the remote server", WebExceptionStatus.ConnectFailure);
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x0009FA38 File Offset: 0x0009DC38
		private void CreateConnectionAsync()
		{
			FtpWebRequest.<CreateConnectionAsync>d__86 <CreateConnectionAsync>d__;
			<CreateConnectionAsync>d__.<>4__this = this;
			<CreateConnectionAsync>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CreateConnectionAsync>d__.<>1__state = -1;
			<CreateConnectionAsync>d__.<>t__builder.Start<FtpWebRequest.<CreateConnectionAsync>d__86>(ref <CreateConnectionAsync>d__);
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x0009FA70 File Offset: 0x0009DC70
		private FtpControlStream CreateConnection()
		{
			string host = this._uri.Host;
			int port = this._uri.Port;
			TcpClient tcpClient = new TcpClient();
			try
			{
				tcpClient.Connect(host, port);
			}
			catch (Exception e)
			{
				throw this.TranslateConnectException(e);
			}
			return new FtpControlStream(tcpClient);
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x0009FAC4 File Offset: 0x0009DCC4
		private Stream TimedSubmitRequestHelper(bool isAsync)
		{
			if (isAsync)
			{
				if (this._requestCompleteAsyncResult == null)
				{
					this._requestCompleteAsyncResult = new LazyAsyncResult(null, null, null);
				}
				return this._connection.SubmitRequest(this, true, true);
			}
			Stream stream = null;
			bool flag = false;
			TimerThread.Timer timer = this.TimerQueue.CreateTimer(this._timerCallback, null);
			try
			{
				stream = this._connection.SubmitRequest(this, false, true);
			}
			catch (Exception ex)
			{
				if ((!(ex is SocketException) && !(ex is ObjectDisposedException)) || !timer.HasExpired)
				{
					timer.Cancel();
					throw;
				}
				flag = true;
			}
			if (flag || !timer.Cancel())
			{
				this._timedOut = true;
				throw ExceptionHelper.TimeoutException;
			}
			if (stream != null)
			{
				object syncObject = this._syncObject;
				lock (syncObject)
				{
					if (this._aborted)
					{
						((ICloseEx)stream).CloseEx(CloseExState.Abort | CloseExState.Silent);
						this.CheckError();
						throw new InternalException();
					}
					this._stream = stream;
				}
			}
			return stream;
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x0009FBC8 File Offset: 0x0009DDC8
		private void TimerCallback(TimerThread.Timer timer, int timeNoticed, object context)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Info(this, null, "TimerCallback");
			}
			FtpControlStream connection = this._connection;
			if (connection != null)
			{
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Info(this, "aborting connection", "TimerCallback");
				}
				connection.AbortConnect();
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06002E33 RID: 11827 RVA: 0x0009FC0F File Offset: 0x0009DE0F
		private TimerThread.Queue TimerQueue
		{
			get
			{
				if (this._timerQueue == null)
				{
					this._timerQueue = TimerThread.GetOrCreateQueue(this.RemainingTimeout);
				}
				return this._timerQueue;
			}
		}

		// Token: 0x06002E34 RID: 11828 RVA: 0x0009FC30 File Offset: 0x0009DE30
		private bool AttemptedRecovery(Exception e)
		{
			if (e is OutOfMemoryException || this._onceFailed || this._aborted || this._timedOut || this._connection == null || !this._connection.RecoverableFailure)
			{
				return false;
			}
			this._onceFailed = true;
			object syncObject = this._syncObject;
			lock (syncObject)
			{
				if (this._connection == null)
				{
					return false;
				}
				this._connection.CloseSocket();
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Info(this, FormattableStringFactory.Create("Releasing connection: {0}", new object[]
					{
						this._connection
					}), "AttemptedRecovery");
				}
				this._connection = null;
			}
			return true;
		}

		// Token: 0x06002E35 RID: 11829 RVA: 0x0009FCF4 File Offset: 0x0009DEF4
		private void SetException(Exception exception)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Info(this, null, "SetException");
			}
			if (exception is OutOfMemoryException)
			{
				this._exception = exception;
				throw exception;
			}
			FtpControlStream connection = this._connection;
			if (this._exception == null)
			{
				if (exception is WebException)
				{
					this.EnsureFtpWebResponse(exception);
					this._exception = new WebException(exception.Message, null, ((WebException)exception).Status, this._ftpWebResponse);
				}
				else if (exception is AuthenticationException || exception is SecurityException)
				{
					this._exception = exception;
				}
				else if (connection != null && connection.StatusCode != FtpStatusCode.Undefined)
				{
					this.EnsureFtpWebResponse(exception);
					this._exception = new WebException(SR.Format("The remote server returned an error: {0}.", connection.StatusLine), exception, WebExceptionStatus.ProtocolError, this._ftpWebResponse);
				}
				else
				{
					this._exception = new WebException(exception.Message, exception);
				}
				if (connection != null && this._ftpWebResponse != null)
				{
					this._ftpWebResponse.UpdateStatus(connection.StatusCode, connection.StatusLine, connection.ExitMessage);
				}
			}
		}

		// Token: 0x06002E36 RID: 11830 RVA: 0x0009FDF5 File Offset: 0x0009DFF5
		private void CheckError()
		{
			if (this._exception != null)
			{
				ExceptionDispatchInfo.Throw(this._exception);
			}
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x0009FE0A File Offset: 0x0009E00A
		internal void RequestCallback(object obj)
		{
			if (this._async)
			{
				this.AsyncRequestCallback(obj);
				return;
			}
			this.SyncRequestCallback(obj);
		}

		// Token: 0x06002E38 RID: 11832 RVA: 0x0009FE24 File Offset: 0x0009E024
		private void SyncRequestCallback(object obj)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Enter(this, obj, "SyncRequestCallback");
			}
			FtpWebRequest.RequestStage stage = FtpWebRequest.RequestStage.CheckForError;
			try
			{
				bool flag = obj == null;
				Exception ex = obj as Exception;
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Info(this, FormattableStringFactory.Create("exp:{0} completedRequest:{1}", new object[]
					{
						ex,
						flag
					}), "SyncRequestCallback");
				}
				if (ex != null)
				{
					this.SetException(ex);
				}
				else
				{
					if (!flag)
					{
						throw new InternalException();
					}
					FtpControlStream connection = this._connection;
					if (connection != null)
					{
						this.EnsureFtpWebResponse(null);
						this._ftpWebResponse.UpdateStatus(connection.StatusCode, connection.StatusLine, connection.ExitMessage);
					}
					stage = FtpWebRequest.RequestStage.ReleaseConnection;
				}
			}
			catch (Exception exception)
			{
				this.SetException(exception);
			}
			finally
			{
				this.FinishRequestStage(stage);
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Exit(this, null, "SyncRequestCallback");
				}
				this.CheckError();
			}
		}

		// Token: 0x06002E39 RID: 11833 RVA: 0x0009FF14 File Offset: 0x0009E114
		private void AsyncRequestCallback(object obj)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Enter(this, obj, "AsyncRequestCallback");
			}
			FtpWebRequest.RequestStage stage = FtpWebRequest.RequestStage.CheckForError;
			try
			{
				FtpControlStream ftpControlStream = obj as FtpControlStream;
				FtpDataStream ftpDataStream = obj as FtpDataStream;
				Exception ex = obj as Exception;
				bool flag = obj == null;
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Info(this, FormattableStringFactory.Create("stream:{0} conn:{1} exp:{2} completedRequest:{3}", new object[]
					{
						ftpDataStream,
						ftpControlStream,
						ex,
						flag
					}), "AsyncRequestCallback");
				}
				for (;;)
				{
					if (ex != null)
					{
						if (this.AttemptedRecovery(ex))
						{
							ftpControlStream = this.CreateConnection();
							if (ftpControlStream == null)
							{
								break;
							}
							ex = null;
						}
						if (ex != null)
						{
							goto Block_9;
						}
					}
					if (ftpControlStream != null)
					{
						object syncObject = this._syncObject;
						lock (syncObject)
						{
							if (this._aborted)
							{
								if (NetEventSource.IsEnabled)
								{
									NetEventSource.Info(this, FormattableStringFactory.Create("Releasing connect:{0}", new object[]
									{
										ftpControlStream
									}), "AsyncRequestCallback");
								}
								ftpControlStream.CloseSocket();
								break;
							}
							this._connection = ftpControlStream;
							if (NetEventSource.IsEnabled)
							{
								NetEventSource.Associate(this, this._connection, "AsyncRequestCallback");
							}
						}
						try
						{
							ftpDataStream = (FtpDataStream)this.TimedSubmitRequestHelper(true);
						}
						catch (Exception ex)
						{
							continue;
						}
						break;
					}
					goto IL_12F;
				}
				return;
				Block_9:
				this.SetException(ex);
				return;
				IL_12F:
				if (ftpDataStream != null)
				{
					object syncObject = this._syncObject;
					lock (syncObject)
					{
						if (this._aborted)
						{
							((ICloseEx)ftpDataStream).CloseEx(CloseExState.Abort | CloseExState.Silent);
							goto IL_1CA;
						}
						this._stream = ftpDataStream;
					}
					ftpDataStream.SetSocketTimeoutOption(this.Timeout);
					this.EnsureFtpWebResponse(null);
					stage = (ftpDataStream.CanRead ? FtpWebRequest.RequestStage.ReadReady : FtpWebRequest.RequestStage.WriteReady);
				}
				else
				{
					if (!flag)
					{
						throw new InternalException();
					}
					ftpControlStream = this._connection;
					if (ftpControlStream != null)
					{
						this.EnsureFtpWebResponse(null);
						this._ftpWebResponse.UpdateStatus(ftpControlStream.StatusCode, ftpControlStream.StatusLine, ftpControlStream.ExitMessage);
					}
					stage = FtpWebRequest.RequestStage.ReleaseConnection;
				}
				IL_1CA:;
			}
			catch (Exception exception)
			{
				this.SetException(exception);
			}
			finally
			{
				this.FinishRequestStage(stage);
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Exit(this, null, "AsyncRequestCallback");
				}
			}
		}

		// Token: 0x06002E3A RID: 11834 RVA: 0x000A0194 File Offset: 0x0009E394
		private FtpWebRequest.RequestStage FinishRequestStage(FtpWebRequest.RequestStage stage)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Info(this, FormattableStringFactory.Create("state:{0}", new object[]
				{
					stage
				}), "FinishRequestStage");
			}
			if (this._exception != null)
			{
				stage = FtpWebRequest.RequestStage.ReleaseConnection;
			}
			object syncObject = this._syncObject;
			FtpWebRequest.RequestStage requestStage;
			LazyAsyncResult writeAsyncResult;
			LazyAsyncResult readAsyncResult;
			FtpControlStream connection;
			lock (syncObject)
			{
				requestStage = this._requestStage;
				if (stage == FtpWebRequest.RequestStage.CheckForError)
				{
					return requestStage;
				}
				if (requestStage == FtpWebRequest.RequestStage.ReleaseConnection && stage == FtpWebRequest.RequestStage.ReleaseConnection)
				{
					return FtpWebRequest.RequestStage.ReleaseConnection;
				}
				if (stage > requestStage)
				{
					this._requestStage = stage;
				}
				if (stage <= FtpWebRequest.RequestStage.RequestStarted)
				{
					return requestStage;
				}
				writeAsyncResult = this._writeAsyncResult;
				readAsyncResult = this._readAsyncResult;
				connection = this._connection;
				if (stage == FtpWebRequest.RequestStage.ReleaseConnection)
				{
					if (this._exception == null && !this._aborted && requestStage != FtpWebRequest.RequestStage.ReadReady && this._methodInfo.IsDownload && !this._ftpWebResponse.IsFromCache)
					{
						return requestStage;
					}
					this._connection = null;
				}
			}
			FtpWebRequest.RequestStage result;
			try
			{
				if ((stage == FtpWebRequest.RequestStage.ReleaseConnection || requestStage == FtpWebRequest.RequestStage.ReleaseConnection) && connection != null)
				{
					try
					{
						if (this._exception != null)
						{
							connection.Abort(this._exception);
						}
					}
					finally
					{
						if (NetEventSource.IsEnabled)
						{
							NetEventSource.Info(this, FormattableStringFactory.Create("Releasing connection: {0}", new object[]
							{
								connection
							}), "FinishRequestStage");
						}
						connection.CloseSocket();
						if (this._async && this._requestCompleteAsyncResult != null)
						{
							this._requestCompleteAsyncResult.InvokeCallback();
						}
					}
				}
				result = requestStage;
			}
			finally
			{
				try
				{
					if (stage >= FtpWebRequest.RequestStage.WriteReady)
					{
						if (this._methodInfo.IsUpload && !this._getRequestStreamStarted)
						{
							if (this._stream != null)
							{
								this._stream.Close();
							}
						}
						else if (writeAsyncResult != null && !writeAsyncResult.InternalPeekCompleted)
						{
							writeAsyncResult.InvokeCallback();
						}
					}
				}
				finally
				{
					if (stage >= FtpWebRequest.RequestStage.ReadReady && readAsyncResult != null && !readAsyncResult.InternalPeekCompleted)
					{
						readAsyncResult.InvokeCallback();
					}
				}
			}
			return result;
		}

		/// <summary>Прерывает асинхронную операцию FTP.</summary>
		// Token: 0x06002E3B RID: 11835 RVA: 0x000A0388 File Offset: 0x0009E588
		public override void Abort()
		{
			if (this._aborted)
			{
				return;
			}
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Enter(this, null, "Abort");
			}
			try
			{
				object syncObject = this._syncObject;
				Stream stream;
				FtpControlStream connection;
				lock (syncObject)
				{
					if (this._requestStage >= FtpWebRequest.RequestStage.ReleaseConnection)
					{
						return;
					}
					this._aborted = true;
					stream = this._stream;
					connection = this._connection;
					this._exception = ExceptionHelper.RequestAbortedException;
				}
				if (stream != null)
				{
					if (!(stream is ICloseEx))
					{
						NetEventSource.Fail(this, "The _stream member is not CloseEx hence the risk of connection been orphaned.", "Abort");
					}
					((ICloseEx)stream).CloseEx(CloseExState.Abort | CloseExState.Silent);
				}
				if (connection != null)
				{
					connection.Abort(ExceptionHelper.RequestAbortedException);
				}
			}
			catch (Exception message)
			{
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Error(this, message, "Abort");
				}
				throw;
			}
			finally
			{
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Exit(this, null, "Abort");
				}
			}
		}

		/// <summary>Возвращает или задает значение <see cref="T:System.Boolean" />, которое указывает, следует ли закрывать управляющее подключение к FTP-серверу после завершения запроса.</summary>
		/// <returns>Значение <see langword="true" />, если подключение к серверу не должно быть уничтожено; в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Для этого свойства задано новое значение для уже выполняющегося запроса.</exception>
		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06002E3C RID: 11836 RVA: 0x0000390E File Offset: 0x00001B0E
		// (set) Token: 0x06002E3D RID: 11837 RVA: 0x0009EE94 File Offset: 0x0009D094
		public bool KeepAlive
		{
			get
			{
				return true;
			}
			set
			{
				if (this.InUse)
				{
					throw new InvalidOperationException("This operation cannot be performed after the request has been submitted.");
				}
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06002E3E RID: 11838 RVA: 0x000A0488 File Offset: 0x0009E688
		// (set) Token: 0x06002E3F RID: 11839 RVA: 0x0009EE94 File Offset: 0x0009D094
		public override RequestCachePolicy CachePolicy
		{
			get
			{
				return FtpWebRequest.DefaultCachePolicy;
			}
			set
			{
				if (this.InUse)
				{
					throw new InvalidOperationException("This operation cannot be performed after the request has been submitted.");
				}
			}
		}

		/// <summary>Возвращает или задает значение <see cref="T:System.Boolean" />, которое указывает тип данных для передачи файлов.</summary>
		/// <returns>Значение <see langword="true" />, чтобы указать серверу, что передаваемые данные являются двоичными; значение <see langword="false" />, чтобы указать на передачу текстовых данных. Значение по умолчанию — <see langword="true" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Для этого свойства задано новое значение для уже выполняющегося запроса.</exception>
		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06002E40 RID: 11840 RVA: 0x000A048F File Offset: 0x0009E68F
		// (set) Token: 0x06002E41 RID: 11841 RVA: 0x000A0497 File Offset: 0x0009E697
		public bool UseBinary
		{
			get
			{
				return this._binary;
			}
			set
			{
				if (this.InUse)
				{
					throw new InvalidOperationException("This operation cannot be performed after the request has been submitted.");
				}
				this._binary = value;
			}
		}

		/// <summary>Возвращает или задает поведение процесса передачи данных в клиентском приложении.</summary>
		/// <returns>Значение <see langword="false" />, если процесс передачи данных в клиентском приложении прослушивает подключение на порту данных; в противном случае — <see langword="true" />, если клиент должен инициировать подключение по порту данных. Значение по умолчанию — <see langword="true" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Для этого свойства задано новое значение для уже выполняющегося запроса.</exception>
		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06002E42 RID: 11842 RVA: 0x000A04B3 File Offset: 0x0009E6B3
		// (set) Token: 0x06002E43 RID: 11843 RVA: 0x000A04BB File Offset: 0x0009E6BB
		public bool UsePassive
		{
			get
			{
				return this._passive;
			}
			set
			{
				if (this.InUse)
				{
					throw new InvalidOperationException("This operation cannot be performed after the request has been submitted.");
				}
				this._passive = value;
			}
		}

		/// <summary>Возвращает или задает сертификаты, используемые для установки и шифрования подключения к FTP-серверу.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />, который содержит сертификаты клиента.</returns>
		/// <exception cref="T:System.ArgumentNullException">Для операции задания указано значение <see langword="null" />.</exception>
		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06002E44 RID: 11844 RVA: 0x000A04D7 File Offset: 0x0009E6D7
		// (set) Token: 0x06002E45 RID: 11845 RVA: 0x000A0509 File Offset: 0x0009E709
		public X509CertificateCollection ClientCertificates
		{
			get
			{
				return LazyInitializer.EnsureInitialized<X509CertificateCollection>(ref this._clientCertificates, ref this._syncObject, () => new X509CertificateCollection());
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this._clientCertificates = value;
			}
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Boolean" />, который указывает, что необходимо использовать SSL-соединение.</summary>
		/// <returns>Значение <see langword="true" />, если передачи управления и данных шифруются; в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Подключение к FTP-серверу уже было установлено.</exception>
		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06002E46 RID: 11846 RVA: 0x000A0520 File Offset: 0x0009E720
		// (set) Token: 0x06002E47 RID: 11847 RVA: 0x000A0528 File Offset: 0x0009E728
		public bool EnableSsl
		{
			get
			{
				return this._enableSsl;
			}
			set
			{
				if (this.InUse)
				{
					throw new InvalidOperationException("This operation cannot be performed after the request has been submitted.");
				}
				this._enableSsl = value;
			}
		}

		/// <summary>Возвращает пустой объект <see cref="T:System.Net.WebHeaderCollection" />.</summary>
		/// <returns>Пустой объект <see cref="T:System.Net.WebHeaderCollection" /></returns>
		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06002E48 RID: 11848 RVA: 0x000A0544 File Offset: 0x0009E744
		// (set) Token: 0x06002E49 RID: 11849 RVA: 0x000A055F File Offset: 0x0009E75F
		public override WebHeaderCollection Headers
		{
			get
			{
				if (this._ftpRequestHeaders == null)
				{
					this._ftpRequestHeaders = new WebHeaderCollection();
				}
				return this._ftpRequestHeaders;
			}
			set
			{
				this._ftpRequestHeaders = value;
			}
		}

		/// <summary>Всегда создает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>Всегда создает исключение <see cref="T:System.NotSupportedException" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Сведения о типе содержимого не поддерживается для FTP.</exception>
		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06002E4A RID: 11850 RVA: 0x000A0568 File Offset: 0x0009E768
		// (set) Token: 0x06002E4B RID: 11851 RVA: 0x000A0568 File Offset: 0x0009E768
		public override string ContentType
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

		/// <summary>Всегда создает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>Всегда создает исключение <see cref="T:System.NotSupportedException" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Учетные данные по умолчанию для FTP не поддерживаются.</exception>
		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06002E4C RID: 11852 RVA: 0x000A0568 File Offset: 0x0009E768
		// (set) Token: 0x06002E4D RID: 11853 RVA: 0x000A0568 File Offset: 0x0009E768
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

		/// <summary>Всегда создает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>Всегда создает исключение <see cref="T:System.NotSupportedException" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Предварительная проверка подлинности для FTP не поддерживается.</exception>
		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06002E4E RID: 11854 RVA: 0x000A0568 File Offset: 0x0009E768
		// (set) Token: 0x06002E4F RID: 11855 RVA: 0x000A0568 File Offset: 0x0009E768
		public override bool PreAuthenticate
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

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06002E50 RID: 11856 RVA: 0x000A056F File Offset: 0x0009E76F
		private bool InUse
		{
			get
			{
				return this._getRequestStreamStarted || this._getResponseStarted;
			}
		}

		// Token: 0x06002E51 RID: 11857 RVA: 0x000A0584 File Offset: 0x0009E784
		private void EnsureFtpWebResponse(Exception exception)
		{
			if (this._ftpWebResponse == null || (this._ftpWebResponse.GetResponseStream() is FtpWebResponse.EmptyStream && this._stream != null))
			{
				object syncObject = this._syncObject;
				lock (syncObject)
				{
					if (this._ftpWebResponse == null || (this._ftpWebResponse.GetResponseStream() is FtpWebResponse.EmptyStream && this._stream != null))
					{
						Stream stream = this._stream;
						if (this._methodInfo.IsUpload)
						{
							stream = null;
						}
						if (this._stream != null && this._stream.CanRead && this._stream.CanTimeout)
						{
							this._stream.ReadTimeout = this.ReadWriteTimeout;
							this._stream.WriteTimeout = this.ReadWriteTimeout;
						}
						FtpControlStream connection = this._connection;
						long num = (connection != null) ? connection.ContentLength : -1L;
						if (stream == null && num < 0L)
						{
							num = 0L;
						}
						if (this._ftpWebResponse != null)
						{
							this._ftpWebResponse.SetResponseStream(stream);
						}
						else if (connection != null)
						{
							this._ftpWebResponse = new FtpWebResponse(stream, num, connection.ResponseUri, connection.StatusCode, connection.StatusLine, connection.LastModified, connection.BannerMessage, connection.WelcomeMessage, connection.ExitMessage);
						}
						else
						{
							this._ftpWebResponse = new FtpWebResponse(stream, -1L, this._uri, FtpStatusCode.Undefined, null, DateTime.Now, null, null, null);
						}
					}
				}
			}
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Info(this, FormattableStringFactory.Create("Returns {0} with stream {1}", new object[]
				{
					this._ftpWebResponse,
					this._ftpWebResponse._responseStream
				}), "EnsureFtpWebResponse");
			}
		}

		// Token: 0x06002E52 RID: 11858 RVA: 0x000A0744 File Offset: 0x0009E944
		internal void DataStreamClosed(CloseExState closeState)
		{
			if ((closeState & CloseExState.Abort) == CloseExState.Normal)
			{
				if (this._async)
				{
					this._requestCompleteAsyncResult.InternalWaitForCompletion();
					this.CheckError();
					return;
				}
				if (this._connection != null)
				{
					this._connection.CheckContinuePipeline();
					return;
				}
			}
			else
			{
				FtpControlStream connection = this._connection;
				if (connection != null)
				{
					connection.Abort(ExceptionHelper.RequestAbortedException);
				}
			}
		}

		// Token: 0x06002E54 RID: 11860 RVA: 0x00013BCA File Offset: 0x00011DCA
		internal FtpWebRequest()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04001968 RID: 6504
		private object _syncObject;

		// Token: 0x04001969 RID: 6505
		private ICredentials _authInfo;

		// Token: 0x0400196A RID: 6506
		private readonly Uri _uri;

		// Token: 0x0400196B RID: 6507
		private FtpMethodInfo _methodInfo;

		// Token: 0x0400196C RID: 6508
		private string _renameTo;

		// Token: 0x0400196D RID: 6509
		private bool _getRequestStreamStarted;

		// Token: 0x0400196E RID: 6510
		private bool _getResponseStarted;

		// Token: 0x0400196F RID: 6511
		private DateTime _startTime;

		// Token: 0x04001970 RID: 6512
		private int _timeout;

		// Token: 0x04001971 RID: 6513
		private int _remainingTimeout;

		// Token: 0x04001972 RID: 6514
		private long _contentLength;

		// Token: 0x04001973 RID: 6515
		private long _contentOffset;

		// Token: 0x04001974 RID: 6516
		private X509CertificateCollection _clientCertificates;

		// Token: 0x04001975 RID: 6517
		private bool _passive;

		// Token: 0x04001976 RID: 6518
		private bool _binary;

		// Token: 0x04001977 RID: 6519
		private string _connectionGroupName;

		// Token: 0x04001978 RID: 6520
		private ServicePoint _servicePoint;

		// Token: 0x04001979 RID: 6521
		private bool _async;

		// Token: 0x0400197A RID: 6522
		private bool _aborted;

		// Token: 0x0400197B RID: 6523
		private bool _timedOut;

		// Token: 0x0400197C RID: 6524
		private Exception _exception;

		// Token: 0x0400197D RID: 6525
		private TimerThread.Queue _timerQueue;

		// Token: 0x0400197E RID: 6526
		private TimerThread.Callback _timerCallback;

		// Token: 0x0400197F RID: 6527
		private bool _enableSsl;

		// Token: 0x04001980 RID: 6528
		private FtpControlStream _connection;

		// Token: 0x04001981 RID: 6529
		private Stream _stream;

		// Token: 0x04001982 RID: 6530
		private FtpWebRequest.RequestStage _requestStage;

		// Token: 0x04001983 RID: 6531
		private bool _onceFailed;

		// Token: 0x04001984 RID: 6532
		private WebHeaderCollection _ftpRequestHeaders;

		// Token: 0x04001985 RID: 6533
		private FtpWebResponse _ftpWebResponse;

		// Token: 0x04001986 RID: 6534
		private int _readWriteTimeout;

		// Token: 0x04001987 RID: 6535
		private ContextAwareResult _writeAsyncResult;

		// Token: 0x04001988 RID: 6536
		private LazyAsyncResult _readAsyncResult;

		// Token: 0x04001989 RID: 6537
		private LazyAsyncResult _requestCompleteAsyncResult;

		// Token: 0x0400198A RID: 6538
		private static readonly NetworkCredential s_defaultFtpNetworkCredential = new NetworkCredential("anonymous", "anonymous@", string.Empty);

		// Token: 0x0400198B RID: 6539
		private const int s_DefaultTimeout = 100000;

		// Token: 0x0400198C RID: 6540
		private static readonly TimerThread.Queue s_DefaultTimerQueue = TimerThread.GetOrCreateQueue(100000);

		// Token: 0x0200058F RID: 1423
		private enum RequestStage
		{
			// Token: 0x0400198E RID: 6542
			CheckForError,
			// Token: 0x0400198F RID: 6543
			RequestStarted,
			// Token: 0x04001990 RID: 6544
			WriteReady,
			// Token: 0x04001991 RID: 6545
			ReadReady,
			// Token: 0x04001992 RID: 6546
			ReleaseConnection
		}
	}
}
