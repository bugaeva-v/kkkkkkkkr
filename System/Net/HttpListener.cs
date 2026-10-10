using System;
using System.Collections;
using System.IO;
using System.Net.Security;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Mono.Net.Security.Private;
using Mono.Security.Authenticode;
using Mono.Security.Interface;

namespace System.Net
{
	/// <summary>Предоставляет простой программно управляемый прослушиватель протокола HTTP. Этот класс не наследуется.</summary>
	// Token: 0x02000688 RID: 1672
	public sealed class HttpListener : IDisposable
	{
		// Token: 0x060034AF RID: 13487 RVA: 0x000B8515 File Offset: 0x000B6715
		internal HttpListener(X509Certificate certificate, MonoTlsProvider tlsProvider, MonoTlsSettings tlsSettings) : this()
		{
			this.certificate = certificate;
			this.tlsProvider = tlsProvider;
			this.tlsSettings = tlsSettings;
		}

		// Token: 0x060034B0 RID: 13488 RVA: 0x000B8534 File Offset: 0x000B6734
		internal X509Certificate LoadCertificateAndKey(IPAddress addr, int port)
		{
			object internalLock = this._internalLock;
			X509Certificate result;
			lock (internalLock)
			{
				if (this.certificate != null)
				{
					result = this.certificate;
				}
				else
				{
					try
					{
						string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".mono");
						path = Path.Combine(path, "httplistener");
						string text = Path.Combine(path, string.Format("{0}.cer", port));
						if (!File.Exists(text))
						{
							result = null;
						}
						else
						{
							string text2 = Path.Combine(path, string.Format("{0}.pvk", port));
							if (!File.Exists(text2))
							{
								result = null;
							}
							else
							{
								X509Certificate2 x509Certificate = new X509Certificate2(text);
								RSA rsa = PrivateKey.CreateFromFile(text2).RSA;
								this.certificate = new X509Certificate2((X509Certificate2Impl)x509Certificate.Impl.CopyWithPrivateKey(rsa));
								result = this.certificate;
							}
						}
					}
					catch
					{
						this.certificate = null;
						result = null;
					}
				}
			}
			return result;
		}

		// Token: 0x060034B1 RID: 13489 RVA: 0x000B8640 File Offset: 0x000B6840
		internal SslStream CreateSslStream(Stream innerStream, bool ownsStream, RemoteCertificateValidationCallback callback)
		{
			object internalLock = this._internalLock;
			SslStream result;
			lock (internalLock)
			{
				if (this.tlsProvider == null)
				{
					this.tlsProvider = MonoTlsProviderFactory.GetProvider();
				}
				MonoTlsSettings monoTlsSettings = (this.tlsSettings ?? MonoTlsSettings.DefaultSettings).Clone();
				monoTlsSettings.RemoteCertificateValidationCallback = CallbackHelpers.PublicToMono(callback);
				result = new SslStream(innerStream, ownsStream, this.tlsProvider, monoTlsSettings);
			}
			return result;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.HttpListener" />.</summary>
		/// <exception cref="T:System.PlatformNotSupportedException">Этот класс не может использоваться в этой операционной системе. Для использования экземпляров этого класса требуется операционная система Windows Server 2003 или Windows XP с пакетом обновления 2.</exception>
		// Token: 0x060034B2 RID: 13490 RVA: 0x000B86C0 File Offset: 0x000B68C0
		public HttpListener()
		{
			this._internalLock = new object();
			this.prefixes = new HttpListenerPrefixCollection(this);
			this.registry = new Hashtable();
			this.connections = Hashtable.Synchronized(new Hashtable());
			this.ctx_queue = new ArrayList();
			this.wait_queue = new ArrayList();
			this.auth_schemes = AuthenticationSchemes.Anonymous;
			this.defaultServiceNames = new ServiceNameStore();
			this.extendedProtectionPolicy = new ExtendedProtectionPolicy(PolicyEnforcement.Never);
		}

		/// <summary>Возвращает или задает схему, используемую для аутентификации клиентов.</summary>
		/// <returns>Битовая комбинация значений перечисления <see cref="T:System.Net.AuthenticationSchemes" />, которая указывает, как клиенты должны проходить аутентификацию. Значение по умолчанию — <see cref="F:System.Net.AuthenticationSchemes.Anonymous" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x060034B3 RID: 13491 RVA: 0x000B873D File Offset: 0x000B693D
		// (set) Token: 0x060034B4 RID: 13492 RVA: 0x000B8745 File Offset: 0x000B6945
		public AuthenticationSchemes AuthenticationSchemes
		{
			get
			{
				return this.auth_schemes;
			}
			set
			{
				this.CheckDisposed();
				this.auth_schemes = value;
			}
		}

		/// <summary>Возвращает или задает делегат, вызываемый для определения протокола, который будет использоваться для аутентификации клиентов.</summary>
		/// <returns>Делегат <see cref="T:System.Net.AuthenticationSchemeSelector" />, который вызывает метод, используемый для выбора протокола аутентификации. Значение по умолчанию — <see langword="null" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x060034B5 RID: 13493 RVA: 0x000B8754 File Offset: 0x000B6954
		// (set) Token: 0x060034B6 RID: 13494 RVA: 0x000B875C File Offset: 0x000B695C
		public AuthenticationSchemeSelector AuthenticationSchemeSelectorDelegate
		{
			get
			{
				return this.auth_selector;
			}
			set
			{
				this.CheckDisposed();
				this.auth_selector = value;
			}
		}

		/// <summary>Получает или задает делегат, вызываемый для определения объекта <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />, который следует использовать для каждого запроса.</summary>
		/// <returns>Объект <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />, который задает политику для расширенной защиты.</returns>
		/// <exception cref="T:System.ArgumentException">Предпринята попытка установить свойство <see cref="P:System.Net.HttpListener.ExtendedProtectionSelectorDelegate" />, но свойство <see cref="P:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy.CustomChannelBinding" /> должно иметь значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Предпринята попытка задать свойству <see cref="P:System.Net.HttpListener.ExtendedProtectionSelectorDelegate" /> значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Предпринята попытка установить свойство <see cref="P:System.Net.HttpListener.ExtendedProtectionSelectorDelegate" /> после вызова метода <see cref="M:System.Net.HttpListener.Start" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Данный объект закрыт.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Предпринята попытка задать свойство  <see cref="P:System.Net.HttpListener.ExtendedProtectionSelectorDelegate" /> на платформе, не поддерживающей расширенную защиту.</exception>
		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x060034B7 RID: 13495 RVA: 0x000B876B File Offset: 0x000B696B
		// (set) Token: 0x060034B8 RID: 13496 RVA: 0x000B8773 File Offset: 0x000B6973
		public HttpListener.ExtendedProtectionSelector ExtendedProtectionSelectorDelegate
		{
			get
			{
				return this.extendedProtectionSelectorDelegate;
			}
			set
			{
				this.CheckDisposed();
				if (value == null)
				{
					throw new ArgumentNullException();
				}
				if (!AuthenticationManager.OSSupportsExtendedProtection)
				{
					throw new PlatformNotSupportedException(SR.GetString("This operation requires OS support for extended protection."));
				}
				this.extendedProtectionSelectorDelegate = value;
			}
		}

		/// <summary>Возвращает или задает значение <see cref="T:System.Boolean" />, которое определяет, получает ли приложение исключения, которые возникают при отправке прослушивателем <see cref="T:System.Net.HttpListener" /> ответа клиенту.</summary>
		/// <returns>
		///   <see langword="true" /> Если этот <see cref="T:System.Net.HttpListener" /> не должен возвращать исключения, возникающие при отправке ответа клиенту; в противном случае <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x060034B9 RID: 13497 RVA: 0x000B87A2 File Offset: 0x000B69A2
		// (set) Token: 0x060034BA RID: 13498 RVA: 0x000B87AA File Offset: 0x000B69AA
		public bool IgnoreWriteExceptions
		{
			get
			{
				return this.ignore_write_exceptions;
			}
			set
			{
				this.CheckDisposed();
				this.ignore_write_exceptions = value;
			}
		}

		/// <summary>Возвращает значение, показывающее, был ли запущен прослушиватель <see cref="T:System.Net.HttpListener" />.</summary>
		/// <returns>Значение <see langword="true" />, если прослушиватель <see cref="T:System.Net.HttpListener" /> был запущен; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x060034BB RID: 13499 RVA: 0x000B87B9 File Offset: 0x000B69B9
		public bool IsListening
		{
			get
			{
				return this.listening;
			}
		}

		/// <summary>Возвращает значение, которое указывает, можно ли использовать прослушиватель <see cref="T:System.Net.HttpListener" /> в текущей операционной системе.</summary>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Net.HttpListener" /> поддерживается; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x060034BC RID: 13500 RVA: 0x0000390E File Offset: 0x00001B0E
		public static bool IsSupported
		{
			get
			{
				return true;
			}
		}

		/// <summary>Возвращает префиксы URI, обрабатываемые этим объектом <see cref="T:System.Net.HttpListener" />.</summary>
		/// <returns>Коллекция <see cref="T:System.Net.HttpListenerPrefixCollection" />, содержащая префиксы URI, которые может обрабатывать этот объект <see cref="T:System.Net.HttpListener" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x060034BD RID: 13501 RVA: 0x000B87C1 File Offset: 0x000B69C1
		public HttpListenerPrefixCollection Prefixes
		{
			get
			{
				this.CheckDisposed();
				return this.prefixes;
			}
		}

		/// <summary>Диспетчер времени ожидания для этого экземпляра <see cref="T:System.Net.HttpListener" />.</summary>
		/// <returns>Диспетчер времени ожидания для этого экземпляра <see cref="T:System.Net.HttpListener" />.</returns>
		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x060034BE RID: 13502 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		public HttpListenerTimeoutManager TimeoutManager
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Получает или задает объект <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />, который используется для расширенной защиты сеанса.</summary>
		/// <returns>Объект <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />, который задает политику для расширенной защиты.</returns>
		/// <exception cref="T:System.ArgumentException">Предпринята попытка установить свойство <see cref="P:System.Net.HttpListener.ExtendedProtectionPolicy" />, но свойство <see cref="P:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy.CustomChannelBinding" /> не имело значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Предпринята попытка задать свойству <see cref="P:System.Net.HttpListener.ExtendedProtectionPolicy" /> значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Предпринята попытка установить свойство <see cref="P:System.Net.HttpListener.ExtendedProtectionPolicy" /> после вызова метода <see cref="M:System.Net.HttpListener.Start" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Данный объект закрыт.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Свойству <see cref="P:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy.PolicyEnforcement" /> было присвоено значение <see cref="F:System.Security.Authentication.ExtendedProtection.PolicyEnforcement.Always" /> на платформе, не поддерживающей расширенную защиту.</exception>
		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x060034BF RID: 13503 RVA: 0x000B87CF File Offset: 0x000B69CF
		// (set) Token: 0x060034C0 RID: 13504 RVA: 0x000B87D8 File Offset: 0x000B69D8
		[MonoTODO("not used anywhere in the implementation")]
		public ExtendedProtectionPolicy ExtendedProtectionPolicy
		{
			get
			{
				return this.extendedProtectionPolicy;
			}
			set
			{
				this.CheckDisposed();
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				if (!AuthenticationManager.OSSupportsExtendedProtection && value.PolicyEnforcement == PolicyEnforcement.Always)
				{
					throw new PlatformNotSupportedException(SR.GetString("This operation requires OS support for extended protection."));
				}
				if (value.CustomChannelBinding != null)
				{
					throw new ArgumentException(SR.GetString("Custom channel bindings are not supported."), "CustomChannelBinding");
				}
				this.extendedProtectionPolicy = value;
			}
		}

		/// <summary>Получает список имен поставщиков услуг (SPN) по умолчанию в соответствии с зарегистрированными префиксами.</summary>
		/// <returns>Объект <see cref="T:System.Security.Authentication.ExtendedProtection.ServiceNameCollection" />, содержащий список SPN.</returns>
		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x060034C1 RID: 13505 RVA: 0x000B883D File Offset: 0x000B6A3D
		public ServiceNameCollection DefaultServiceNames
		{
			get
			{
				return this.defaultServiceNames.ServiceNames;
			}
		}

		/// <summary>Возвращает или задает область или раздел ресурса, связанные с этим объектом <see cref="T:System.Net.HttpListener" />.</summary>
		/// <returns>Значение <see cref="T:System.String" />, которое содержит имя области, связанной с этим объектом <see cref="T:System.Net.HttpListener" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x060034C2 RID: 13506 RVA: 0x000B884A File Offset: 0x000B6A4A
		// (set) Token: 0x060034C3 RID: 13507 RVA: 0x000B8852 File Offset: 0x000B6A52
		public string Realm
		{
			get
			{
				return this.realm;
			}
			set
			{
				this.CheckDisposed();
				this.realm = value;
			}
		}

		/// <summary>Возвращает или задает значение <see cref="T:System.Boolean" />, которое определяет, должны ли дополнительные запросы, использующие то же TCP-подключение, проходить аутентификацию при использовании протокола NTLM.</summary>
		/// <returns>Значение <see langword="true" />, если сведения об идентификации <see cref="T:System.Security.Principal.IIdentity" /> первого запроса будут использоваться для последующих запросов на том же подключении, в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x060034C4 RID: 13508 RVA: 0x000B8861 File Offset: 0x000B6A61
		// (set) Token: 0x060034C5 RID: 13509 RVA: 0x000B8869 File Offset: 0x000B6A69
		[MonoTODO("Support for NTLM needs some loving.")]
		public bool UnsafeConnectionNtlmAuthentication
		{
			get
			{
				return this.unsafe_ntlm_auth;
			}
			set
			{
				this.CheckDisposed();
				this.unsafe_ntlm_auth = value;
			}
		}

		/// <summary>Незамедлительно завершает работу объекта <see cref="T:System.Net.HttpListener" />, отменяя все текущие запросы в очереди.</summary>
		// Token: 0x060034C6 RID: 13510 RVA: 0x000B8878 File Offset: 0x000B6A78
		public void Abort()
		{
			if (this.disposed)
			{
				return;
			}
			if (!this.listening)
			{
				return;
			}
			this.Close(true);
		}

		/// <summary>Завершает работу <see cref="T:System.Net.HttpListener" />.</summary>
		// Token: 0x060034C7 RID: 13511 RVA: 0x000B8893 File Offset: 0x000B6A93
		public void Close()
		{
			if (this.disposed)
			{
				return;
			}
			if (!this.listening)
			{
				this.disposed = true;
				return;
			}
			this.Close(true);
			this.disposed = true;
		}

		// Token: 0x060034C8 RID: 13512 RVA: 0x000B88BC File Offset: 0x000B6ABC
		private void Close(bool force)
		{
			this.CheckDisposed();
			EndPointManager.RemoveListener(this);
			this.Cleanup(force);
		}

		// Token: 0x060034C9 RID: 13513 RVA: 0x000B88D4 File Offset: 0x000B6AD4
		private void Cleanup(bool close_existing)
		{
			object internalLock = this._internalLock;
			lock (internalLock)
			{
				if (close_existing)
				{
					ICollection keys = this.registry.Keys;
					HttpListenerContext[] array = new HttpListenerContext[keys.Count];
					keys.CopyTo(array, 0);
					this.registry.Clear();
					for (int i = array.Length - 1; i >= 0; i--)
					{
						array[i].Connection.Close(true);
					}
				}
				object syncRoot = this.connections.SyncRoot;
				lock (syncRoot)
				{
					ICollection keys2 = this.connections.Keys;
					HttpConnection[] array2 = new HttpConnection[keys2.Count];
					keys2.CopyTo(array2, 0);
					this.connections.Clear();
					for (int j = array2.Length - 1; j >= 0; j--)
					{
						array2[j].Close(true);
					}
				}
				ArrayList obj = this.ctx_queue;
				lock (obj)
				{
					HttpListenerContext[] array3 = (HttpListenerContext[])this.ctx_queue.ToArray(typeof(HttpListenerContext));
					this.ctx_queue.Clear();
					for (int k = array3.Length - 1; k >= 0; k--)
					{
						array3[k].Connection.Close(true);
					}
				}
				obj = this.wait_queue;
				lock (obj)
				{
					Exception exc = new ObjectDisposedException("listener");
					foreach (object obj2 in this.wait_queue)
					{
						((ListenerAsyncResult)obj2).Complete(exc);
					}
					this.wait_queue.Clear();
				}
			}
		}

		/// <summary>Начинает асинхронное получение входящего запроса.</summary>
		/// <param name="callback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, который следует вызвать при наличии клиентского запроса.</param>
		/// <param name="state">Пользовательский объект, содержащий сведения об операции. Этот объект передается делегату <paramref name="callback" /> после завершения операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, представляющий состояние асинхронной операции.</returns>
		/// <exception cref="T:System.Net.HttpListenerException">Вызов функции Win32 завершился с ошибкой. Проверьте свойство исключения <see cref="P:System.Net.HttpListenerException.ErrorCode" />, чтобы определить причину исключения.</exception>
		/// <exception cref="T:System.InvalidOperationException">Этот объект не был запущен или в настоящее время остановлен.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Данный объект закрыт.</exception>
		// Token: 0x060034CA RID: 13514 RVA: 0x000B8B20 File Offset: 0x000B6D20
		public IAsyncResult BeginGetContext(AsyncCallback callback, object state)
		{
			this.CheckDisposed();
			if (!this.listening)
			{
				throw new InvalidOperationException("Please, call Start before using this method.");
			}
			ListenerAsyncResult listenerAsyncResult = new ListenerAsyncResult(callback, state);
			ArrayList obj = this.wait_queue;
			lock (obj)
			{
				ArrayList obj2 = this.ctx_queue;
				lock (obj2)
				{
					HttpListenerContext contextFromQueue = this.GetContextFromQueue();
					if (contextFromQueue != null)
					{
						listenerAsyncResult.Complete(contextFromQueue, true);
						return listenerAsyncResult;
					}
				}
				this.wait_queue.Add(listenerAsyncResult);
			}
			return listenerAsyncResult;
		}

		/// <summary>Завершает асинхронную операцию получения входящего клиентского запроса.</summary>
		/// <param name="asyncResult">Объект <see cref="T:System.IAsyncResult" />, который был получен при запуске асинхронной операции.</param>
		/// <returns>Объект <see cref="T:System.Net.HttpListenerContext" />, представляющий клиентский запрос.</returns>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="asyncResult" /> не получено вызовом метода <see cref="M:System.Net.HttpListener.BeginGetContext(System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="asyncResult" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.HttpListenerException">Вызов функции Win32 завершился с ошибкой. Проверьте свойство исключения <see cref="P:System.Net.HttpListenerException.ErrorCode" />, чтобы определить причину исключения.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Net.HttpListener.EndGetContext(System.IAsyncResult)" /> уже был вызван для указанного объекта <paramref name="asyncResult" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Данный объект закрыт.</exception>
		// Token: 0x060034CB RID: 13515 RVA: 0x000B8BD4 File Offset: 0x000B6DD4
		public HttpListenerContext EndGetContext(IAsyncResult asyncResult)
		{
			this.CheckDisposed();
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			ListenerAsyncResult listenerAsyncResult = asyncResult as ListenerAsyncResult;
			if (listenerAsyncResult == null)
			{
				throw new ArgumentException("Wrong IAsyncResult.", "asyncResult");
			}
			if (listenerAsyncResult.EndCalled)
			{
				throw new ArgumentException("Cannot reuse this IAsyncResult");
			}
			listenerAsyncResult.EndCalled = true;
			if (!listenerAsyncResult.IsCompleted)
			{
				listenerAsyncResult.AsyncWaitHandle.WaitOne();
			}
			ArrayList obj = this.wait_queue;
			lock (obj)
			{
				int num = this.wait_queue.IndexOf(listenerAsyncResult);
				if (num >= 0)
				{
					this.wait_queue.RemoveAt(num);
				}
			}
			HttpListenerContext context = listenerAsyncResult.GetContext();
			context.ParseAuthentication(this.SelectAuthenticationScheme(context));
			return context;
		}

		// Token: 0x060034CC RID: 13516 RVA: 0x000B8CA0 File Offset: 0x000B6EA0
		internal AuthenticationSchemes SelectAuthenticationScheme(HttpListenerContext context)
		{
			if (this.AuthenticationSchemeSelectorDelegate != null)
			{
				return this.AuthenticationSchemeSelectorDelegate(context.Request);
			}
			return this.auth_schemes;
		}

		/// <summary>Ожидает входящий запрос и выполняет возврат при его получении.</summary>
		/// <returns>Объект <see cref="T:System.Net.HttpListenerContext" />, представляющий клиентский запрос.</returns>
		/// <exception cref="T:System.Net.HttpListenerException">Вызов функции Win32 завершился с ошибкой. Проверьте свойство исключения <see cref="P:System.Net.HttpListenerException.ErrorCode" />, чтобы определить причину исключения.</exception>
		/// <exception cref="T:System.InvalidOperationException">Этот объект не был запущен или в настоящее время остановлен.  
		/// -или- 
		/// Прослушиватель <see cref="T:System.Net.HttpListener" /> не имеет префиксов URI для ответа.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Данный объект закрыт.</exception>
		// Token: 0x060034CD RID: 13517 RVA: 0x000B8CC4 File Offset: 0x000B6EC4
		public HttpListenerContext GetContext()
		{
			if (this.prefixes.Count == 0)
			{
				throw new InvalidOperationException("Please, call AddPrefix before using this method.");
			}
			ListenerAsyncResult listenerAsyncResult = (ListenerAsyncResult)this.BeginGetContext(null, null);
			listenerAsyncResult.InGet = true;
			return this.EndGetContext(listenerAsyncResult);
		}

		/// <summary>Позволяет этому экземпляру получать входящие запросы.</summary>
		/// <exception cref="T:System.Net.HttpListenerException">Вызов функции Win32 завершился с ошибкой. Проверьте свойство исключения <see cref="P:System.Net.HttpListenerException.ErrorCode" />, чтобы определить причину исключения.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Данный объект закрыт.</exception>
		// Token: 0x060034CE RID: 13518 RVA: 0x000B8D05 File Offset: 0x000B6F05
		public void Start()
		{
			this.CheckDisposed();
			if (this.listening)
			{
				return;
			}
			EndPointManager.AddListener(this);
			this.listening = true;
		}

		/// <summary>Заставляет этот экземпляр прекратить получать входящие запросы.</summary>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		// Token: 0x060034CF RID: 13519 RVA: 0x000B8D23 File Offset: 0x000B6F23
		public void Stop()
		{
			this.CheckDisposed();
			this.listening = false;
			this.Close(false);
		}

		/// <summary>Освобождает ресурсы, удерживаемые этим объектом <see cref="T:System.Net.HttpListener" />.</summary>
		// Token: 0x060034D0 RID: 13520 RVA: 0x000B8D39 File Offset: 0x000B6F39
		void IDisposable.Dispose()
		{
			if (this.disposed)
			{
				return;
			}
			this.Close(true);
			this.disposed = true;
		}

		/// <summary>Ожидает входящий запрос как асинхронную операцию.</summary>
		/// <returns>Объект задачи, представляющий асинхронную операцию. Свойство <see cref="P:System.Threading.Tasks.Task`1.Result" /> объекта задачи возвращает объект <see cref="T:System.Net.HttpListenerContext" />, представляющий запрос клиента.</returns>
		// Token: 0x060034D1 RID: 13521 RVA: 0x000B8D52 File Offset: 0x000B6F52
		public Task<HttpListenerContext> GetContextAsync()
		{
			return Task<HttpListenerContext>.Factory.FromAsync(new Func<AsyncCallback, object, IAsyncResult>(this.BeginGetContext), new Func<IAsyncResult, HttpListenerContext>(this.EndGetContext), null);
		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x000B8D77 File Offset: 0x000B6F77
		internal void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().ToString());
			}
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x000B8D92 File Offset: 0x000B6F92
		private HttpListenerContext GetContextFromQueue()
		{
			if (this.ctx_queue.Count == 0)
			{
				return null;
			}
			HttpListenerContext result = (HttpListenerContext)this.ctx_queue[0];
			this.ctx_queue.RemoveAt(0);
			return result;
		}

		// Token: 0x060034D4 RID: 13524 RVA: 0x000B8DC0 File Offset: 0x000B6FC0
		internal void RegisterContext(HttpListenerContext context)
		{
			object internalLock = this._internalLock;
			lock (internalLock)
			{
				this.registry[context] = context;
			}
			ListenerAsyncResult listenerAsyncResult = null;
			ArrayList obj = this.wait_queue;
			lock (obj)
			{
				if (this.wait_queue.Count == 0)
				{
					ArrayList obj2 = this.ctx_queue;
					lock (obj2)
					{
						this.ctx_queue.Add(context);
						goto IL_A3;
					}
				}
				listenerAsyncResult = (ListenerAsyncResult)this.wait_queue[0];
				this.wait_queue.RemoveAt(0);
			}
			IL_A3:
			if (listenerAsyncResult != null)
			{
				listenerAsyncResult.Complete(context);
			}
		}

		// Token: 0x060034D5 RID: 13525 RVA: 0x000B8EA4 File Offset: 0x000B70A4
		internal void UnregisterContext(HttpListenerContext context)
		{
			object internalLock = this._internalLock;
			lock (internalLock)
			{
				this.registry.Remove(context);
			}
			ArrayList obj = this.ctx_queue;
			lock (obj)
			{
				int num = this.ctx_queue.IndexOf(context);
				if (num >= 0)
				{
					this.ctx_queue.RemoveAt(num);
				}
			}
		}

		// Token: 0x060034D6 RID: 13526 RVA: 0x000B8F30 File Offset: 0x000B7130
		internal void AddConnection(HttpConnection cnc)
		{
			this.connections[cnc] = cnc;
		}

		// Token: 0x060034D7 RID: 13527 RVA: 0x000B8F3F File Offset: 0x000B713F
		internal void RemoveConnection(HttpConnection cnc)
		{
			this.connections.Remove(cnc);
		}

		// Token: 0x04001ECC RID: 7884
		private MonoTlsProvider tlsProvider;

		// Token: 0x04001ECD RID: 7885
		private MonoTlsSettings tlsSettings;

		// Token: 0x04001ECE RID: 7886
		private X509Certificate certificate;

		// Token: 0x04001ECF RID: 7887
		private AuthenticationSchemes auth_schemes;

		// Token: 0x04001ED0 RID: 7888
		private HttpListenerPrefixCollection prefixes;

		// Token: 0x04001ED1 RID: 7889
		private AuthenticationSchemeSelector auth_selector;

		// Token: 0x04001ED2 RID: 7890
		private string realm;

		// Token: 0x04001ED3 RID: 7891
		private bool ignore_write_exceptions;

		// Token: 0x04001ED4 RID: 7892
		private bool unsafe_ntlm_auth;

		// Token: 0x04001ED5 RID: 7893
		private bool listening;

		// Token: 0x04001ED6 RID: 7894
		private bool disposed;

		// Token: 0x04001ED7 RID: 7895
		private readonly object _internalLock;

		// Token: 0x04001ED8 RID: 7896
		private Hashtable registry;

		// Token: 0x04001ED9 RID: 7897
		private ArrayList ctx_queue;

		// Token: 0x04001EDA RID: 7898
		private ArrayList wait_queue;

		// Token: 0x04001EDB RID: 7899
		private Hashtable connections;

		// Token: 0x04001EDC RID: 7900
		private ServiceNameStore defaultServiceNames;

		// Token: 0x04001EDD RID: 7901
		private ExtendedProtectionPolicy extendedProtectionPolicy;

		// Token: 0x04001EDE RID: 7902
		private HttpListener.ExtendedProtectionSelector extendedProtectionSelectorDelegate;

		/// <summary>Делегат, вызываемый для определения объекта <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />, который следует использовать для каждого запроса <see cref="T:System.Net.HttpListener" />.</summary>
		/// <param name="request">Объект <see cref="T:System.Net.HttpListenerRequest" /> для определения политики расширенной защиты, которую будет использовать экземпляр <see cref="T:System.Net.HttpListener" /> для обеспечения расширенной защиты.</param>
		/// <returns>Объект <see cref="T:System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy" />, который задает политику расширенной защиты, используемую в этом запросе.</returns>
		// Token: 0x02000689 RID: 1673
		// (Invoke) Token: 0x060034D9 RID: 13529
		public delegate ExtendedProtectionPolicy ExtendedProtectionSelector(HttpListenerRequest request);
	}
}
