using System;
using System.IO;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Mono.Net.Security;
using Mono.Net.Security.Private;
using Mono.Security.Interface;

namespace System.Net.Security
{
	/// <summary>Предоставляет поток, который служит для взаимодействия между клиентом и сервером и использует протокол безопасности SSL для проверки подлинности сервера и при необходимости клиента.</summary>
	// Token: 0x02000863 RID: 2147
	public class SslStream : AuthenticatedStream
	{
		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x06004453 RID: 17491 RVA: 0x000EC975 File Offset: 0x000EAB75
		internal MobileAuthenticatedStream Impl
		{
			get
			{
				this.CheckDisposed();
				return this.impl;
			}
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x06004454 RID: 17492 RVA: 0x000EC983 File Offset: 0x000EAB83
		internal MonoTlsProvider Provider
		{
			get
			{
				this.CheckDisposed();
				return this.provider;
			}
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x06004455 RID: 17493 RVA: 0x000EC991 File Offset: 0x000EAB91
		internal string InternalTargetHost
		{
			get
			{
				this.CheckDisposed();
				return this.impl.TargetHost;
			}
		}

		// Token: 0x06004456 RID: 17494 RVA: 0x000EC9A4 File Offset: 0x000EABA4
		private static MobileTlsProvider GetProvider()
		{
			return (MobileTlsProvider)Mono.Security.Interface.MonoTlsProviderFactory.GetProvider();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Security.SslStream" /> с использованием указанного объекта <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="innerStream">Объект <see cref="T:System.IO.Stream" />, используемый потоком <see cref="T:System.Net.Security.SslStream" /> для отправки и получения данных.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="innerStream" /> недоступно для чтения.  
		/// -или- 
		///  <paramref name="innerStream" /> недоступно для записи.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="innerStream" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="innerStream" /> равно <see cref="F:System.IO.Stream.Null" />.</exception>
		// Token: 0x06004457 RID: 17495 RVA: 0x000EC9B0 File Offset: 0x000EABB0
		public SslStream(Stream innerStream) : this(innerStream, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Security.SslStream" />, используя заданный поток <see cref="T:System.IO.Stream" /> и параметр, указывающий поведение потока при закрытии.</summary>
		/// <param name="innerStream">Объект <see cref="T:System.IO.Stream" />, используемый потоком <see cref="T:System.Net.Security.SslStream" /> для отправки и получения данных.</param>
		/// <param name="leaveInnerStreamOpen">Логическое значение, указывающее поведение при закрытии объекта <see cref="T:System.IO.Stream" />, который используется объектом <see cref="T:System.Net.Security.SslStream" /> для отправки и получения данных. Данный параметр указывает, оставлен ли открытым внутренний поток.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="innerStream" /> недоступно для чтения.  
		/// -или- 
		///  <paramref name="innerStream" /> недоступно для записи.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="innerStream" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="innerStream" /> равно <see cref="F:System.IO.Stream.Null" />.</exception>
		// Token: 0x06004458 RID: 17496 RVA: 0x000EC9BA File Offset: 0x000EABBA
		public SslStream(Stream innerStream, bool leaveInnerStreamOpen) : base(innerStream, leaveInnerStreamOpen)
		{
			this.provider = SslStream.GetProvider();
			this.settings = MonoTlsSettings.CopyDefaultSettings();
			this.impl = this.provider.CreateSslStream(this, innerStream, leaveInnerStreamOpen, this.settings);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Security.SslStream" />, используя заданный поток <see cref="T:System.IO.Stream" />, параметр, указывающий поведение потока при закрытии, и делегат проверки сертификата.</summary>
		/// <param name="innerStream">Объект <see cref="T:System.IO.Stream" />, используемый потоком <see cref="T:System.Net.Security.SslStream" /> для отправки и получения данных.</param>
		/// <param name="leaveInnerStreamOpen">Логическое значение, указывающее поведение при закрытии объекта <see cref="T:System.IO.Stream" />, который используется объектом <see cref="T:System.Net.Security.SslStream" /> для отправки и получения данных. Данный параметр указывает, оставлен ли открытым внутренний поток.</param>
		/// <param name="userCertificateValidationCallback">Делегат <see cref="T:System.Net.Security.RemoteCertificateValidationCallback" />, отвечающий за проверку сертификата, представленного удаленной стороной.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="innerStream" /> недоступно для чтения.  
		///
		/// или - 
		/// <paramref name="innerStream" /> недоступно для записи.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="innerStream" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  <paramref name="innerStream" /> равно <see cref="F:System.IO.Stream.Null" />.</exception>
		// Token: 0x06004459 RID: 17497 RVA: 0x000EC9F4 File Offset: 0x000EABF4
		public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback) : this(innerStream, leaveInnerStreamOpen, userCertificateValidationCallback, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Security.SslStream" />, используя заданный поток <see cref="T:System.IO.Stream" />, параметр, указывающий поведение потока при закрытии, делегат проверки сертификата и делегат выбора сертификата.</summary>
		/// <param name="innerStream">Объект <see cref="T:System.IO.Stream" />, используемый потоком <see cref="T:System.Net.Security.SslStream" /> для отправки и получения данных.</param>
		/// <param name="leaveInnerStreamOpen">Логическое значение, указывающее поведение при закрытии объекта <see cref="T:System.IO.Stream" />, который используется объектом <see cref="T:System.Net.Security.SslStream" /> для отправки и получения данных. Данный параметр указывает, оставлен ли открытым внутренний поток.</param>
		/// <param name="userCertificateValidationCallback">Делегат <see cref="T:System.Net.Security.RemoteCertificateValidationCallback" />, отвечающий за проверку сертификата, представленного удаленной стороной.</param>
		/// <param name="userCertificateSelectionCallback">Делегат <see cref="T:System.Net.Security.LocalCertificateSelectionCallback" />, отвечающий за выбор сертификата, используемого для проверки подлинности.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="innerStream" /> недоступно для чтения.  
		///
		/// или - 
		/// <paramref name="innerStream" /> недоступно для записи.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="innerStream" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="innerStream" /> равно <see cref="F:System.IO.Stream.Null" />.</exception>
		// Token: 0x0600445A RID: 17498 RVA: 0x000ECA00 File Offset: 0x000EAC00
		public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback) : base(innerStream, leaveInnerStreamOpen)
		{
			this.provider = SslStream.GetProvider();
			this.settings = MonoTlsSettings.CopyDefaultSettings();
			this.SetAndVerifyValidationCallback(userCertificateValidationCallback);
			this.SetAndVerifySelectionCallback(userCertificateSelectionCallback);
			this.impl = this.provider.CreateSslStream(this, innerStream, leaveInnerStreamOpen, this.settings);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Security.SslStream" /> с использованием указанного объекта <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="innerStream">Объект <see cref="T:System.IO.Stream" />, используемый потоком <see cref="T:System.Net.Security.SslStream" /> для отправки и получения данных.</param>
		/// <param name="leaveInnerStreamOpen">Логическое значение, указывающее поведение при закрытии объекта <see cref="T:System.IO.Stream" />, который используется объектом <see cref="T:System.Net.Security.SslStream" /> для отправки и получения данных. Данный параметр указывает, оставлен ли открытым внутренний поток.</param>
		/// <param name="userCertificateValidationCallback">Делегат <see cref="T:System.Net.Security.RemoteCertificateValidationCallback" />, отвечающий за проверку сертификата, представленного удаленной стороной.</param>
		/// <param name="userCertificateSelectionCallback">Делегат <see cref="T:System.Net.Security.LocalCertificateSelectionCallback" />, отвечающий за выбор сертификата, используемого для проверки подлинности.</param>
		/// <param name="encryptionPolicy">Используемый <see cref="T:System.Net.Security.EncryptionPolicy" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="innerStream" /> недоступно для чтения.  
		/// -или- 
		///  <paramref name="innerStream" /> недоступно для записи.  
		/// -или- 
		///  Недопустимый параметр <paramref name="encryptionPolicy" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="innerStream" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="innerStream" /> равно <see cref="F:System.IO.Stream.Null" />.</exception>
		// Token: 0x0600445B RID: 17499 RVA: 0x000ECA54 File Offset: 0x000EAC54
		[MonoLimitation("encryptionPolicy is ignored")]
		public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback, EncryptionPolicy encryptionPolicy) : this(innerStream, leaveInnerStreamOpen, userCertificateValidationCallback, userCertificateSelectionCallback)
		{
		}

		// Token: 0x0600445C RID: 17500 RVA: 0x000ECA61 File Offset: 0x000EAC61
		internal SslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) : base(innerStream, leaveInnerStreamOpen)
		{
			this.provider = (MobileTlsProvider)provider;
			this.settings = settings.Clone();
			this.explicitSettings = true;
			this.impl = this.provider.CreateSslStream(this, innerStream, leaveInnerStreamOpen, settings);
		}

		// Token: 0x0600445D RID: 17501 RVA: 0x000ECAA1 File Offset: 0x000EACA1
		internal static IMonoSslStream CreateMonoSslStream(Stream innerStream, bool leaveInnerStreamOpen, MobileTlsProvider provider, MonoTlsSettings settings)
		{
			return new SslStream(innerStream, leaveInnerStreamOpen, provider, settings).Impl;
		}

		// Token: 0x0600445E RID: 17502 RVA: 0x000ECAB4 File Offset: 0x000EACB4
		private void SetAndVerifyValidationCallback(RemoteCertificateValidationCallback callback)
		{
			if (this.validationCallback == null)
			{
				this.validationCallback = callback;
				this.settings.RemoteCertificateValidationCallback = CallbackHelpers.PublicToMono(callback);
				return;
			}
			if ((callback != null && this.validationCallback != callback) || (this.explicitSettings & this.settings.RemoteCertificateValidationCallback != null))
			{
				throw new InvalidOperationException(SR.Format("The '{0}' option was already set in the SslStream constructor.", "RemoteCertificateValidationCallback"));
			}
		}

		// Token: 0x0600445F RID: 17503 RVA: 0x000ECB20 File Offset: 0x000EAD20
		private void SetAndVerifySelectionCallback(LocalCertificateSelectionCallback callback)
		{
			if (this.selectionCallback == null)
			{
				this.selectionCallback = callback;
				if (callback == null)
				{
					this.settings.ClientCertificateSelectionCallback = null;
					return;
				}
				this.settings.ClientCertificateSelectionCallback = ((string t, X509CertificateCollection lc, X509Certificate rc, string[] ai) => callback(this, t, lc, rc, ai));
				return;
			}
			else
			{
				if ((callback != null && this.selectionCallback != callback) || (this.explicitSettings && this.settings.ClientCertificateSelectionCallback != null))
				{
					throw new InvalidOperationException(SR.Format("The '{0}' option was already set in the SslStream constructor.", "LocalCertificateSelectionCallback"));
				}
				return;
			}
		}

		// Token: 0x06004460 RID: 17504 RVA: 0x000ECBC8 File Offset: 0x000EADC8
		private MonoSslServerAuthenticationOptions CreateAuthenticationOptions(SslServerAuthenticationOptions sslServerAuthenticationOptions)
		{
			if (sslServerAuthenticationOptions.ServerCertificate == null && sslServerAuthenticationOptions.ServerCertificateSelectionCallback == null && this.selectionCallback == null)
			{
				throw new ArgumentNullException("ServerCertificate");
			}
			if ((sslServerAuthenticationOptions.ServerCertificate != null || this.selectionCallback != null) && sslServerAuthenticationOptions.ServerCertificateSelectionCallback != null)
			{
				throw new InvalidOperationException(SR.Format("The '{0}' option was already set in the SslStream constructor.", "ServerCertificateSelectionCallback"));
			}
			MonoSslServerAuthenticationOptions monoSslServerAuthenticationOptions = new MonoSslServerAuthenticationOptions(sslServerAuthenticationOptions);
			ServerCertificateSelectionCallback serverSelectionCallback = sslServerAuthenticationOptions.ServerCertificateSelectionCallback;
			if (serverSelectionCallback != null)
			{
				monoSslServerAuthenticationOptions.ServerCertSelectionDelegate = ((string x) => serverSelectionCallback(this, x));
			}
			return monoSslServerAuthenticationOptions;
		}

		/// <summary>Вызывается клиентами для проверки подлинности сервера и, при необходимости, клиента в подключении "клиент-сервер".</summary>
		/// <param name="targetHost">Имя сервера, который совместно использует <see cref="T:System.Net.Security.SslStream" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="targetHost" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Произошел сбой проверки подлинности, и этот объект остался в неработоспособном состоянии.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		///
		/// или - 
		/// Попытка проверки подлинности сервера с использованием <see cref="T:System.Net.Security.SslStream" /> уже выполнена.  
		///
		/// -или- 
		/// Проверка подлинности уже выполняется.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		// Token: 0x06004461 RID: 17505 RVA: 0x000ECC60 File Offset: 0x000EAE60
		public virtual void AuthenticateAsClient(string targetHost)
		{
			this.AuthenticateAsClient(targetHost, new X509CertificateCollection(), SslProtocols.None, false);
		}

		/// <summary>Вызывается клиентами для проверки подлинности сервера и, при необходимости, клиента в подключении "клиент-сервер". Процесс проверки подлинности использует указанную коллекцию сертификатов и протокол SSL системы по умолчанию.</summary>
		/// <param name="targetHost">Имя сервера, который будет совместно использовать <see cref="T:System.Net.Security.SslStream" />.</param>
		/// <param name="clientCertificates">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />, который содержит сертификаты клиента.</param>
		/// <param name="checkCertificateRevocation">Значение <see cref="T:System.Boolean" />, которое указывает, проверяется ли список отзыва сертификатов при проверке подлинности.</param>
		// Token: 0x06004462 RID: 17506 RVA: 0x000ECC70 File Offset: 0x000EAE70
		public virtual void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, bool checkCertificateRevocation)
		{
			this.AuthenticateAsClient(targetHost, clientCertificates, SslProtocols.None, checkCertificateRevocation);
		}

		/// <summary>Вызывается клиентами для проверки подлинности сервера и, при необходимости, клиента в подключении "клиент-сервер". Процесс проверки подлинности использует заданную коллекцию сертификатов и протокол SSL.</summary>
		/// <param name="targetHost">Имя сервера, который будет совместно использовать <see cref="T:System.Net.Security.SslStream" />.</param>
		/// <param name="clientCertificates">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />, который содержит сертификаты клиента.</param>
		/// <param name="enabledSslProtocols">Значение из перечисления <see cref="T:System.Security.Authentication.SslProtocols" />, представляющее протокол, используемый для проверки подлинности.</param>
		/// <param name="checkCertificateRevocation">Значение <see cref="T:System.Boolean" />, которое указывает, проверяется ли список отзыва сертификатов при проверке подлинности.</param>
		// Token: 0x06004463 RID: 17507 RVA: 0x000ECC7C File Offset: 0x000EAE7C
		public virtual void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			this.Impl.AuthenticateAsClient(targetHost, clientCertificates, enabledSslProtocols, checkCertificateRevocation);
		}

		/// <summary>Вызывается клиентами для запуска асинхронной операции проверки подлинности сервера и, при необходимости, клиента.</summary>
		/// <param name="targetHost">Имя сервера, который совместно использует <see cref="T:System.Net.Security.SslStream" />.</param>
		/// <param name="asyncCallback">Делегат <see cref="T:System.AsyncCallback" />, который ссылается на метод, вызываемый после выполнения проверки подлинности.</param>
		/// <param name="asyncState">Пользовательский объект, содержащий сведения об операции. Этот объект передается делегату <paramref name="asyncCallback" /> после завершения операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, представляющий состояние асинхронной операции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="targetHost" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Произошел сбой проверки подлинности, и этот объект остался в неработоспособном состоянии.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		///
		/// или - 
		/// Попытка проверки подлинности сервера с использованием <see cref="T:System.Net.Security.SslStream" /> уже выполнена.  
		///
		/// -или- 
		/// Проверка подлинности уже выполняется.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		// Token: 0x06004464 RID: 17508 RVA: 0x000ECC8E File Offset: 0x000EAE8E
		public virtual IAsyncResult BeginAuthenticateAsClient(string targetHost, AsyncCallback asyncCallback, object asyncState)
		{
			return this.BeginAuthenticateAsClient(targetHost, new X509CertificateCollection(), SslProtocols.None, false, asyncCallback, asyncState);
		}

		/// <summary>Вызывается клиентами для запуска асинхронной операции проверки подлинности сервера и (при необходимости) клиента с использованием указанных сертификатов и протокола безопасности системы по умолчанию.</summary>
		/// <param name="targetHost">Имя сервера, который совместно использует <see cref="T:System.Net.Security.SslStream" />.</param>
		/// <param name="clientCertificates">Коллекция <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />, содержащая сертификаты клиента.</param>
		/// <param name="checkCertificateRevocation">Значение <see cref="T:System.Boolean" />, которое указывает, проверяется ли список отзыва сертификатов при проверке подлинности.</param>
		/// <param name="asyncCallback">Делегат <see cref="T:System.AsyncCallback" />, который ссылается на метод, вызываемый после выполнения проверки подлинности.</param>
		/// <param name="asyncState">Пользовательский объект, содержащий сведения об операции. Этот объект передается делегату <paramref name="asyncCallback" /> после завершения операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, представляющий состояние асинхронной операции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="targetHost" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Произошел сбой проверки подлинности, и этот объект остался в неработоспособном состоянии.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		/// -или- 
		/// Попытка проверки подлинности сервера с использованием <see cref="T:System.Net.Security.SslStream" /> уже выполнена.  
		///
		/// или - 
		/// Проверка подлинности уже выполняется.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		// Token: 0x06004465 RID: 17509 RVA: 0x000ECCA0 File Offset: 0x000EAEA0
		public virtual IAsyncResult BeginAuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState)
		{
			return this.BeginAuthenticateAsClient(targetHost, clientCertificates, SslProtocols.None, checkCertificateRevocation, asyncCallback, asyncState);
		}

		/// <summary>Вызывается клиентами для запуска асинхронной операции проверки подлинности сервера, и, при необходимости, клиента с использованием указанных сертификатов и протокола безопасности.</summary>
		/// <param name="targetHost">Имя сервера, который совместно использует <see cref="T:System.Net.Security.SslStream" />.</param>
		/// <param name="clientCertificates">Коллекция <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />, содержащая сертификаты клиента.</param>
		/// <param name="enabledSslProtocols">Значение из перечисления <see cref="T:System.Security.Authentication.SslProtocols" />, представляющее протокол, используемый для проверки подлинности.</param>
		/// <param name="checkCertificateRevocation">Значение <see cref="T:System.Boolean" />, которое указывает, проверяется ли список отзыва сертификатов при проверке подлинности.</param>
		/// <param name="asyncCallback">Делегат <see cref="T:System.AsyncCallback" />, который ссылается на метод, вызываемый после выполнения проверки подлинности.</param>
		/// <param name="asyncState">Пользовательский объект, содержащий сведения об операции. Этот объект передается делегату <paramref name="asyncCallback" /> после завершения операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, представляющий состояние асинхронной операции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="targetHost" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="enabledSslProtocols" /> не является допустимым значением <see cref="T:System.Security.Authentication.SslProtocols" />.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Произошел сбой проверки подлинности, и этот объект остался в неработоспособном состоянии.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		/// -или- 
		/// Попытка проверки подлинности сервера с использованием <see cref="T:System.Net.Security.SslStream" /> уже выполнена.  
		/// -или- 
		/// Проверка подлинности уже выполняется.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		// Token: 0x06004466 RID: 17510 RVA: 0x000ECCB0 File Offset: 0x000EAEB0
		public virtual IAsyncResult BeginAuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState)
		{
			return TaskToApm.Begin(this.Impl.AuthenticateAsClientAsync(targetHost, clientCertificates, enabledSslProtocols, checkCertificateRevocation), asyncCallback, asyncState);
		}

		/// <summary>Завершает находящуюся в состоянии ожидания асинхронную операцию проверки подлинности сервера, которая была до этого запущена вызовом метода <see cref="Overload:System.Net.Security.SslStream.BeginAuthenticateAsClient" />.</summary>
		/// <param name="asyncResult">Экземпляр <see cref="T:System.IAsyncResult" />, возвращенный вызовом метода <see cref="Overload:System.Net.Security.SslStream.BeginAuthenticateAsClient" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asyncResult" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="asyncResult" /> не был создан вызовом метода <see cref="Overload:System.Net.Security.SslStream.BeginAuthenticateAsClient" />.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Произошел сбой проверки подлинности, и этот объект остался в неработоспособном состоянии.</exception>
		/// <exception cref="T:System.InvalidOperationException">Нет ожидающей завершения операции проверки подлинности сервера.</exception>
		// Token: 0x06004467 RID: 17511 RVA: 0x0009571A File Offset: 0x0009391A
		public virtual void EndAuthenticateAsClient(IAsyncResult asyncResult)
		{
			TaskToApm.End(asyncResult);
		}

		/// <summary>Вызывается серверами для проверки подлинности сервера и, при необходимости, клиента в соединении клиент-сервер с использованием заданного сертификата.</summary>
		/// <param name="serverCertificate">Сертификат используется для проверки подлинности сервера.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="serverCertificate" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Произошел сбой проверки подлинности, и этот объект остался в неработоспособном состоянии.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		/// -или- 
		/// Попытка проверки подлинности клиента с помощью этого параметра <see cref="T:System.Net.Security.SslStream" /> уже выполнена ранее.  
		///
		/// или - 
		/// Проверка подлинности уже выполняется.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Метод <see cref="Overload:System.Net.Security.SslStream.AuthenticateAsServer" /> не поддерживается в Windows 95, Windows 98 и Windows Millennium.</exception>
		// Token: 0x06004468 RID: 17512 RVA: 0x000ECCCB File Offset: 0x000EAECB
		public virtual void AuthenticateAsServer(X509Certificate serverCertificate)
		{
			this.Impl.AuthenticateAsServer(serverCertificate, false, SslProtocols.None, false);
		}

		/// <summary>Вызывается серверами для проверки подлинности сервера и, при необходимости, клиента в подключении между клиентом и сервером с использованием указанных сертификатов, требований и протокола безопасности системы по умолчанию.</summary>
		/// <param name="serverCertificate">Сертификат X509, который используется для проверки подлинности сервера.</param>
		/// <param name="clientCertificateRequired">Значение <see cref="T:System.Boolean" />, которое указывает, получает ли клиент запрос на сертификат для проверки подлинности. Обратите внимание, что это — только запрос. Если сертификат не предоставляется, сервер продолжает принимать запрос на подключение.</param>
		/// <param name="checkCertificateRevocation">Значение <see cref="T:System.Boolean" />, которое указывает, проверяется ли список отзыва сертификатов при проверке подлинности.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="serverCertificate" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Произошел сбой проверки подлинности, и этот объект остался в неработоспособном состоянии.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		/// -или- 
		/// Попытка проверки подлинности клиента с помощью этого параметра <see cref="T:System.Net.Security.SslStream" /> уже выполнена ранее.  
		/// -или- 
		/// Проверка подлинности уже выполняется.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Метод <see cref="Overload:System.Net.Security.SslStream.AuthenticateAsServer" /> не поддерживается в Windows 95, Windows 98 и Windows Millennium.</exception>
		// Token: 0x06004469 RID: 17513 RVA: 0x000ECCDC File Offset: 0x000EAEDC
		public virtual void AuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, bool checkCertificateRevocation)
		{
			this.Impl.AuthenticateAsServer(serverCertificate, clientCertificateRequired, SslProtocols.None, checkCertificateRevocation);
		}

		/// <summary>Вызывается серверами для проверки подлинности сервера и при необходимости клиента в подключении между клиентом и сервером с использованием указанных сертификатов, требований и протокола безопасности.</summary>
		/// <param name="serverCertificate">Сертификат X509, который используется для проверки подлинности сервера.</param>
		/// <param name="clientCertificateRequired">Значение <see cref="T:System.Boolean" />, которое указывает, получает ли клиент запрос на сертификат для проверки подлинности. Обратите внимание, что это — только запрос. Если сертификат не предоставляется, сервер продолжает принимать запрос на подключение.</param>
		/// <param name="enabledSslProtocols">Значение из перечисления <see cref="T:System.Security.Authentication.SslProtocols" />, представляющее протокол, используемый для проверки подлинности.</param>
		/// <param name="checkCertificateRevocation">Значение <see cref="T:System.Boolean" />, которое указывает, проверяется ли список отзыва сертификатов при проверке подлинности.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="serverCertificate" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="enabledSslProtocols" /> не является допустимым значением <see cref="T:System.Security.Authentication.SslProtocols" />.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Произошел сбой проверки подлинности, и этот объект остался в неработоспособном состоянии.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		///
		/// или - 
		/// Попытка проверки подлинности клиента с помощью этого параметра <see cref="T:System.Net.Security.SslStream" /> уже выполнена ранее.  
		///
		/// или - 
		/// Проверка подлинности уже выполняется.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Метод <see cref="Overload:System.Net.Security.SslStream.AuthenticateAsServer" /> не поддерживается в Windows 95, Windows 98 и Windows Millennium.</exception>
		// Token: 0x0600446A RID: 17514 RVA: 0x000ECCED File Offset: 0x000EAEED
		public virtual void AuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			this.Impl.AuthenticateAsServer(serverCertificate, clientCertificateRequired, enabledSslProtocols, checkCertificateRevocation);
		}

		/// <summary>Вызывается серверами для начала асинхронной операции проверки подлинности клиента, и, при необходимости, сервера в соединении клиент-сервер.</summary>
		/// <param name="serverCertificate">Сертификат X509, который используется для проверки подлинности сервера.</param>
		/// <param name="asyncCallback">Делегат <see cref="T:System.AsyncCallback" />, который ссылается на метод, вызываемый после выполнения проверки подлинности.</param>
		/// <param name="asyncState">Пользовательский объект, содержащий сведения об операции. Этот объект передается делегату <paramref name="asyncCallback" /> после завершения операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, указывающий состояние асинхронной операции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="serverCertificate" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Произошел сбой проверки подлинности, и этот объект остался в неработоспособном состоянии.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		/// -или- 
		/// Попытка проверки подлинности клиента с помощью этого параметра <see cref="T:System.Net.Security.SslStream" /> уже выполнена ранее.  
		/// -или- 
		/// Проверка подлинности уже выполняется.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Метод <see cref="Overload:System.Net.Security.SslStream.BeginAuthenticateAsServer" /> не поддерживается в Windows 95, Windows 98 и Windows Millennium.</exception>
		// Token: 0x0600446B RID: 17515 RVA: 0x000ECCFF File Offset: 0x000EAEFF
		public virtual IAsyncResult BeginAuthenticateAsServer(X509Certificate serverCertificate, AsyncCallback asyncCallback, object asyncState)
		{
			return this.BeginAuthenticateAsServer(serverCertificate, false, SslProtocols.None, false, asyncCallback, asyncState);
		}

		/// <summary>Вызывается серверами для запуска асинхронной операции проверки подлинности сервера и (при необходимости) клиента с использованием указанных сертификатов, требований и протокола безопасности системы по умолчанию.</summary>
		/// <param name="serverCertificate">Сертификат X509, который используется для проверки подлинности сервера.</param>
		/// <param name="clientCertificateRequired">Значение <see cref="T:System.Boolean" />, которое указывает, получает ли клиент запрос на сертификат для проверки подлинности. Обратите внимание, что это — только запрос. Если сертификат не предоставляется, сервер продолжает принимать запрос на подключение.</param>
		/// <param name="checkCertificateRevocation">Значение <see cref="T:System.Boolean" />, которое указывает, проверяется ли список отзыва сертификатов при проверке подлинности.</param>
		/// <param name="asyncCallback">Делегат <see cref="T:System.AsyncCallback" />, который ссылается на метод, вызываемый после выполнения проверки подлинности.</param>
		/// <param name="asyncState">Пользовательский объект, содержащий сведения об операции. Этот объект передается делегату <paramref name="asyncCallback" /> после завершения операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, представляющий состояние асинхронной операции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="serverCertificate" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Произошел сбой проверки подлинности, и этот объект остался в неработоспособном состоянии.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		/// -или- 
		/// Попытка проверки подлинности сервера с использованием <see cref="T:System.Net.Security.SslStream" /> уже выполнена.  
		/// -или- 
		/// Проверка подлинности уже выполняется.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Метод <see cref="Overload:System.Net.Security.SslStream.BeginAuthenticateAsServer" /> не поддерживается в Windows 95, Windows 98 и Windows Millennium.</exception>
		// Token: 0x0600446C RID: 17516 RVA: 0x000ECD0D File Offset: 0x000EAF0D
		public virtual IAsyncResult BeginAuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState)
		{
			return this.BeginAuthenticateAsServer(serverCertificate, clientCertificateRequired, SslProtocols.None, checkCertificateRevocation, asyncCallback, asyncState);
		}

		/// <summary>Вызывается серверами для запуска асинхронной операции проверки подлинности сервера и (при необходимости) клиента с использованием указанных сертификатов, требований и протокола безопасности.</summary>
		/// <param name="serverCertificate">Сертификат X509, который используется для проверки подлинности сервера.</param>
		/// <param name="clientCertificateRequired">Значение <see cref="T:System.Boolean" />, которое указывает, получает ли клиент запрос на сертификат для проверки подлинности. Обратите внимание, что это — только запрос. Если сертификат не предоставляется, сервер продолжает принимать запрос на подключение.</param>
		/// <param name="enabledSslProtocols">Значение из перечисления <see cref="T:System.Security.Authentication.SslProtocols" />, представляющее протокол, используемый для проверки подлинности.</param>
		/// <param name="checkCertificateRevocation">Значение <see cref="T:System.Boolean" />, которое указывает, проверяется ли список отзыва сертификатов при проверке подлинности.</param>
		/// <param name="asyncCallback">Делегат <see cref="T:System.AsyncCallback" />, который ссылается на метод, вызываемый после выполнения проверки подлинности.</param>
		/// <param name="asyncState">Пользовательский объект, содержащий сведения об операции. Этот объект передается делегату <paramref name="asyncCallback" /> после завершения операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, представляющий состояние асинхронной операции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="serverCertificate" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="enabledSslProtocols" /> не является допустимым значением <see cref="T:System.Security.Authentication.SslProtocols" />.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Произошел сбой проверки подлинности, и этот объект остался в неработоспособном состоянии.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		/// -или- 
		/// Попытка проверки подлинности сервера с использованием <see cref="T:System.Net.Security.SslStream" /> уже выполнена.  
		///
		/// или - 
		/// Проверка подлинности уже выполняется.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Метод <see cref="Overload:System.Net.Security.SslStream.BeginAuthenticateAsServer" /> не поддерживается в Windows 95, Windows 98 и Windows Millennium.</exception>
		// Token: 0x0600446D RID: 17517 RVA: 0x000ECD1D File Offset: 0x000EAF1D
		public virtual IAsyncResult BeginAuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState)
		{
			return TaskToApm.Begin(this.Impl.AuthenticateAsServerAsync(serverCertificate, clientCertificateRequired, enabledSslProtocols, checkCertificateRevocation), asyncCallback, asyncState);
		}

		/// <summary>Завершает находящуюся в состоянии ожидания асинхронную операцию проверки подлинности клиента, которая была до этого запущена вызовом метода <see cref="Overload:System.Net.Security.SslStream.BeginAuthenticateAsClient" />.</summary>
		/// <param name="asyncResult">Экземпляр <see cref="T:System.IAsyncResult" />, возвращенный вызовом метода <see cref="Overload:System.Net.Security.SslStream.BeginAuthenticateAsClient" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asyncResult" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="asyncResult" /> не был создан вызовом метода <see cref="Overload:System.Net.Security.SslStream.BeginAuthenticateAsClient" />.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Произошел сбой проверки подлинности, и этот объект остался в неработоспособном состоянии.</exception>
		/// <exception cref="T:System.InvalidOperationException">Нет ожидающей завершения операции проверки подлинности клиента.</exception>
		// Token: 0x0600446E RID: 17518 RVA: 0x0009571A File Offset: 0x0009391A
		public virtual void EndAuthenticateAsServer(IAsyncResult asyncResult)
		{
			TaskToApm.End(asyncResult);
		}

		/// <summary>Получает объект <see cref="T:System.Net.TransportContext" />, который используется для проверки подлинности с использованием расширенной защиты.</summary>
		/// <returns>Объект <see cref="T:System.Net.TransportContext" />, содержащий токен привязки канала (CBT) для расширенной защиты.</returns>
		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x0600446F RID: 17519 RVA: 0x00002F6A File Offset: 0x0000116A
		public TransportContext TransportContext
		{
			get
			{
				return null;
			}
		}

		/// <summary>Вызывается клиентами для проверки подлинности сервера и, при необходимости, клиента в подключении "клиент-сервер" в рамках асинхронной операции.</summary>
		/// <param name="targetHost">Имя сервера, который совместно использует <see cref="T:System.Net.Security.SslStream" />.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="targetHost" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Произошел сбой проверки подлинности, и этот объект остался в неработоспособном состоянии.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		/// -или- 
		/// Попытка проверки подлинности сервера с использованием <see cref="T:System.Net.Security.SslStream" /> уже выполнена.  
		///
		/// или - 
		/// Проверка подлинности уже выполняется.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		// Token: 0x06004470 RID: 17520 RVA: 0x000ECD38 File Offset: 0x000EAF38
		public virtual Task AuthenticateAsClientAsync(string targetHost)
		{
			return this.Impl.AuthenticateAsClientAsync(targetHost, new X509CertificateCollection(), SslProtocols.None, false);
		}

		/// <summary>Вызывается клиентами для проверки подлинности сервера и, при необходимости, клиента в подключении "клиент-сервер" в рамках асинхронной операции. Процесс проверки подлинности использует указанную коллекцию сертификатов и протокол SSL системы по умолчанию.</summary>
		/// <param name="targetHost">Имя сервера, который будет совместно использовать <see cref="T:System.Net.Security.SslStream" />.</param>
		/// <param name="clientCertificates">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />, который содержит сертификаты клиента.</param>
		/// <param name="checkCertificateRevocation">Значение <see cref="T:System.Boolean" />, которое указывает, проверяется ли список отзыва сертификатов при проверке подлинности.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		// Token: 0x06004471 RID: 17521 RVA: 0x000ECD4D File Offset: 0x000EAF4D
		public virtual Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, bool checkCertificateRevocation)
		{
			return this.Impl.AuthenticateAsClientAsync(targetHost, clientCertificates, SslProtocols.None, checkCertificateRevocation);
		}

		/// <summary>Вызывается клиентами для проверки подлинности сервера и, при необходимости, клиента в подключении "клиент-сервер" в рамках асинхронной операции. Процесс проверки подлинности использует заданную коллекцию сертификатов и протокол SSL.</summary>
		/// <param name="targetHost">Имя сервера, который будет совместно использовать <see cref="T:System.Net.Security.SslStream" />.</param>
		/// <param name="clientCertificates">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" />, который содержит сертификаты клиента.</param>
		/// <param name="enabledSslProtocols">Значение из перечисления <see cref="T:System.Security.Authentication.SslProtocols" />, представляющее протокол, используемый для проверки подлинности.</param>
		/// <param name="checkCertificateRevocation">Значение <see cref="T:System.Boolean" />, которое указывает, проверяется ли список отзыва сертификатов при проверке подлинности.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		// Token: 0x06004472 RID: 17522 RVA: 0x000ECD5E File Offset: 0x000EAF5E
		public virtual Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			return this.Impl.AuthenticateAsClientAsync(targetHost, clientCertificates, enabledSslProtocols, checkCertificateRevocation);
		}

		// Token: 0x06004473 RID: 17523 RVA: 0x000ECD70 File Offset: 0x000EAF70
		public Task AuthenticateAsClientAsync(SslClientAuthenticationOptions sslClientAuthenticationOptions, CancellationToken cancellationToken)
		{
			this.SetAndVerifyValidationCallback(sslClientAuthenticationOptions.RemoteCertificateValidationCallback);
			this.SetAndVerifySelectionCallback(sslClientAuthenticationOptions.LocalCertificateSelectionCallback);
			return this.Impl.AuthenticateAsClientAsync(new MonoSslClientAuthenticationOptions(sslClientAuthenticationOptions), cancellationToken);
		}

		/// <summary>Вызывается серверами для проверки подлинности сервера и, при необходимости, клиента в соединении клиент-сервер с использованием заданного сертификата как асинхронная операция.</summary>
		/// <param name="serverCertificate">Сертификат используется для проверки подлинности сервера.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="serverCertificate" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">Произошел сбой проверки подлинности, и этот объект остался в неработоспособном состоянии.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности уже выполнена.  
		/// -или- 
		/// Попытка проверки подлинности клиента с помощью этого параметра <see cref="T:System.Net.Security.SslStream" /> уже выполнена ранее.  
		/// -или- 
		/// Проверка подлинности уже выполняется.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Метод <see cref="Overload:System.Net.Security.SslStream.AuthenticateAsServerAsync" /> не поддерживается в Windows 95, Windows 98 и Windows Millennium.</exception>
		// Token: 0x06004474 RID: 17524 RVA: 0x000ECD9C File Offset: 0x000EAF9C
		public virtual Task AuthenticateAsServerAsync(X509Certificate serverCertificate)
		{
			return this.Impl.AuthenticateAsServerAsync(serverCertificate, false, SslProtocols.None, false);
		}

		/// <summary>Вызывается серверами для проверки подлинности сервера и при необходимости клиента при подключении между клиентом и сервером с использованием указанных сертификатов, требований и протокола безопасности в рамках асинхронной операции.</summary>
		/// <param name="serverCertificate">Сертификат X509, который используется для проверки подлинности сервера.</param>
		/// <param name="clientCertificateRequired">Значение <see cref="T:System.Boolean" />, которое указывает, получает ли клиент запрос на сертификат для проверки подлинности. Обратите внимание, что это — только запрос. Если сертификат не предоставляется, сервер продолжает принимать запрос на подключение.</param>
		/// <param name="checkCertificateRevocation">Значение <see cref="T:System.Boolean" />, которое указывает, проверяется ли список отзыва сертификатов при проверке подлинности.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		// Token: 0x06004475 RID: 17525 RVA: 0x000ECDAD File Offset: 0x000EAFAD
		public virtual Task AuthenticateAsServerAsync(X509Certificate serverCertificate, bool clientCertificateRequired, bool checkCertificateRevocation)
		{
			return this.Impl.AuthenticateAsServerAsync(serverCertificate, clientCertificateRequired, SslProtocols.None, checkCertificateRevocation);
		}

		/// <summary>Вызывается серверами для проверки подлинности сервера и при необходимости клиента при подключении между клиентом и сервером с использованием указанных сертификатов, требований и протокола безопасности в рамках асинхронной операции.</summary>
		/// <param name="serverCertificate">Сертификат X509, который используется для проверки подлинности сервера.</param>
		/// <param name="clientCertificateRequired">Значение <see cref="T:System.Boolean" />, которое указывает, получает ли клиент запрос на сертификат для проверки подлинности. Обратите внимание, что это — только запрос. Если сертификат не предоставляется, сервер продолжает принимать запрос на подключение.</param>
		/// <param name="enabledSslProtocols">Значение из перечисления <see cref="T:System.Security.Authentication.SslProtocols" />, представляющее протокол, используемый для проверки подлинности.</param>
		/// <param name="checkCertificateRevocation">Значение <see cref="T:System.Boolean" />, которое указывает, проверяется ли список отзыва сертификатов при проверке подлинности.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		// Token: 0x06004476 RID: 17526 RVA: 0x000ECDBE File Offset: 0x000EAFBE
		public virtual Task AuthenticateAsServerAsync(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			return this.Impl.AuthenticateAsServerAsync(serverCertificate, clientCertificateRequired, enabledSslProtocols, checkCertificateRevocation);
		}

		// Token: 0x06004477 RID: 17527 RVA: 0x000ECDD0 File Offset: 0x000EAFD0
		public Task AuthenticateAsServerAsync(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken)
		{
			return this.Impl.AuthenticateAsServerAsync(this.CreateAuthenticationOptions(sslServerAuthenticationOptions), cancellationToken);
		}

		/// <summary>Завершает работу этого класса SslStream.</summary>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		// Token: 0x06004478 RID: 17528 RVA: 0x000ECDE5 File Offset: 0x000EAFE5
		public virtual Task ShutdownAsync()
		{
			return this.Impl.ShutdownAsync();
		}

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, была ли проверка подлинности успешной.</summary>
		/// <returns>Значение <see langword="true" />, если произошла успешная проверка подлинности; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x06004479 RID: 17529 RVA: 0x000ECDF2 File Offset: 0x000EAFF2
		public override bool IsAuthenticated
		{
			get
			{
				return this.Impl.IsAuthenticated;
			}
		}

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, была ли проведена проверка подлинности как для сервера, так и для клиента.</summary>
		/// <returns>Значение <see langword="true" />, если подлинность сервера была проверена, иначе — <see langword="false" />.</returns>
		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x0600447A RID: 17530 RVA: 0x000ECDFF File Offset: 0x000EAFFF
		public override bool IsMutuallyAuthenticated
		{
			get
			{
				return this.Impl.IsMutuallyAuthenticated;
			}
		}

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, использует ли данный поток <see cref="T:System.Net.Security.SslStream" /> шифрование данных.</summary>
		/// <returns>Значение <see langword="true" />, если данные шифруются до передачи по сети и дешифруются при достижении удаленной конечной точки; иначе — <see langword="false" />.</returns>
		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x0600447B RID: 17531 RVA: 0x000ECE0C File Offset: 0x000EB00C
		public override bool IsEncrypted
		{
			get
			{
				return this.Impl.IsEncrypted;
			}
		}

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, подписаны ли данные, отправленные с помощью данного потока.</summary>
		/// <returns>Значение <see langword="true" />, если данные были подписаны перед передачей; иначе — <see langword="false" />.</returns>
		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x0600447C RID: 17532 RVA: 0x000ECE19 File Offset: 0x000EB019
		public override bool IsSigned
		{
			get
			{
				return this.Impl.IsSigned;
			}
		}

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, прошла ли локальная сторона соединения, используемого данным потоком <see cref="T:System.Net.Security.SslStream" />, проверку подлинности как сервер.</summary>
		/// <returns>Значение <see langword="true" />, если локальная конечная точка успешно прошла проверку подлинности как серверная сторона соединения с проверкой подлинности; иначе — <see langword="false" />.</returns>
		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x0600447D RID: 17533 RVA: 0x000ECE26 File Offset: 0x000EB026
		public override bool IsServer
		{
			get
			{
				return this.Impl.IsServer;
			}
		}

		/// <summary>Возвращает значение, указывающее протокол безопасности, используемый для проверки подлинности в данном соединении.</summary>
		/// <returns>Значение из перечисления <see cref="T:System.Security.Authentication.SslProtocols" />, представляющее протокол, используемый для проверки подлинности.</returns>
		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x0600447E RID: 17534 RVA: 0x000ECE33 File Offset: 0x000EB033
		public virtual SslProtocols SslProtocol
		{
			get
			{
				return this.Impl.SslProtocol;
			}
		}

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, проверяется ли список отзыва сертификатов во время процесса проверки сертификатов.</summary>
		/// <returns>Значение <see langword="true" />, если проверяется список отзыва сертификатов; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x0600447F RID: 17535 RVA: 0x000ECE40 File Offset: 0x000EB040
		public virtual bool CheckCertRevocationStatus
		{
			get
			{
				return this.Impl.CheckCertRevocationStatus;
			}
		}

		/// <summary>Возвращает сертификат, используемый для проверки подлинности локальной конечной точки.</summary>
		/// <returns>Объект X509Certificate, представляющий сертификат, переданный для проверки подлинности, или <see langword="null" />, если сертификат не был передан.</returns>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности завершилась неудачно или не выполнялась.</exception>
		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x06004480 RID: 17536 RVA: 0x000ECE4D File Offset: 0x000EB04D
		public virtual X509Certificate LocalCertificate
		{
			get
			{
				return this.Impl.LocalCertificate;
			}
		}

		/// <summary>Возвращает сертификат, используемый для проверки подлинности удаленной конечной точки.</summary>
		/// <returns>Объект X509Certificate, представляющий сертификат, переданный для проверки подлинности, или <see langword="null" />, если сертификат не был передан.</returns>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности завершилась неудачно или не выполнялась.</exception>
		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x06004481 RID: 17537 RVA: 0x000ECE5A File Offset: 0x000EB05A
		public virtual X509Certificate RemoteCertificate
		{
			get
			{
				return this.Impl.RemoteCertificate;
			}
		}

		/// <summary>Возвращает значение, указывающее алгоритм массового шифрования, используемый данным потоком <see cref="T:System.Net.Security.SslStream" />.</summary>
		/// <returns>Значение, указывающее алгоритм массового шифрования, используемый данным потоком <see cref="T:System.Net.Security.SslStream" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Обращение к свойству <see cref="P:System.Net.Security.SslStream.CipherAlgorithm" /> произошло до завершения процесса проверки подлинности или этот процесс завершился неудачно.</exception>
		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x06004482 RID: 17538 RVA: 0x000ECE67 File Offset: 0x000EB067
		public virtual System.Security.Authentication.CipherAlgorithmType CipherAlgorithm
		{
			get
			{
				return this.Impl.CipherAlgorithm;
			}
		}

		/// <summary>Возвращает значение, указывающее стойкость алгоритма шифрования, используемого этим потоком <see cref="T:System.Net.Security.SslStream" />.</summary>
		/// <returns>Значение <see cref="T:System.Int32" />, указывающее стойкость алгоритма, в битах.</returns>
		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x06004483 RID: 17539 RVA: 0x000ECE74 File Offset: 0x000EB074
		public virtual int CipherStrength
		{
			get
			{
				return this.Impl.CipherStrength;
			}
		}

		/// <summary>Возвращает алгоритм, используемый для генерирования кодов проверки подлинности сообщений (MAC).</summary>
		/// <returns>Алгоритм, используемый для создания кодов проверки подлинности сообщения (Mac).</returns>
		/// <exception cref="T:System.InvalidOperationException">Обращение к свойству <see cref="P:System.Net.Security.SslStream.HashAlgorithm" /> произошло до завершения процесса проверки подлинности или этот процесс завершился неудачно.</exception>
		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06004484 RID: 17540 RVA: 0x000ECE81 File Offset: 0x000EB081
		public virtual System.Security.Authentication.HashAlgorithmType HashAlgorithm
		{
			get
			{
				return this.Impl.HashAlgorithm;
			}
		}

		/// <summary>Возвращает значение, указывающее стойкость алгоритма хэширования, используемого данным экземпляром.</summary>
		/// <returns>Значение <see cref="T:System.Int32" />, указывающее стойкость типа алгоритма хэширования (перечисление <see cref="T:System.Security.Authentication.HashAlgorithmType" />) в битах. Допустимые значения: 128 или 160.</returns>
		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06004485 RID: 17541 RVA: 0x000ECE8E File Offset: 0x000EB08E
		public virtual int HashStrength
		{
			get
			{
				return this.Impl.HashStrength;
			}
		}

		/// <summary>Возвращает алгоритм обмена ключами, используемый данным потоком <see cref="T:System.Net.Security.SslStream" />.</summary>
		/// <returns>Значение <see cref="T:System.Security.Authentication.ExchangeAlgorithmType" />.</returns>
		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06004486 RID: 17542 RVA: 0x000ECE9B File Offset: 0x000EB09B
		public virtual System.Security.Authentication.ExchangeAlgorithmType KeyExchangeAlgorithm
		{
			get
			{
				return this.Impl.KeyExchangeAlgorithm;
			}
		}

		/// <summary>Возвращает значение, указывающее стойкость алгоритма обмена ключами, используемого данным экземпляром.</summary>
		/// <returns>Значение <see cref="T:System.Int32" />, указывающее стойкость типа алгоритма хэширования (перечисление <see cref="T:System.Security.Authentication.ExchangeAlgorithmType" />) в битах.</returns>
		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x06004487 RID: 17543 RVA: 0x000ECEA8 File Offset: 0x000EB0A8
		public virtual int KeyExchangeStrength
		{
			get
			{
				return this.Impl.KeyExchangeStrength;
			}
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x06004488 RID: 17544 RVA: 0x000ECEB5 File Offset: 0x000EB0B5
		public SslApplicationProtocol NegotiatedApplicationProtocol
		{
			get
			{
				throw new PlatformNotSupportedException("https://github.com/mono/mono/issues/12880");
			}
		}

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, разрешен ли поиск в базовом потоке.</summary>
		/// <returns>Данное свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x06004489 RID: 17545 RVA: 0x00003062 File Offset: 0x00001262
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, разрешено ли чтение из базового потока.</summary>
		/// <returns>Значение <see langword="true" />, если проверка подлинности выполнена, а чтение из базового потока разрешено; иначе — <see langword="false" />.</returns>
		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x0600448A RID: 17546 RVA: 0x000ECEC1 File Offset: 0x000EB0C1
		public override bool CanRead
		{
			get
			{
				return this.impl != null && this.impl.CanRead;
			}
		}

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, поддерживает ли базовый поток использование времени ожидания.</summary>
		/// <returns>Значение <see langword="true" />, если базовый поток поддерживает время ожидания; иначе — <see langword="false" />.</returns>
		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x0600448B RID: 17547 RVA: 0x00008055 File Offset: 0x00006255
		public override bool CanTimeout
		{
			get
			{
				return base.InnerStream.CanTimeout;
			}
		}

		/// <summary>Возвращает значение типа <see cref="T:System.Boolean" />, указывающее, разрешена ли запись в базовый поток.</summary>
		/// <returns>Значение <see langword="true" />, если проверка подлинности выполнена, а запись в базовый поток разрешена; иначе — <see langword="false" />.</returns>
		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x0600448C RID: 17548 RVA: 0x000ECED8 File Offset: 0x000EB0D8
		public override bool CanWrite
		{
			get
			{
				return this.impl != null && this.impl.CanWrite;
			}
		}

		/// <summary>Возвращает или задает временной интервал, в течение которого операция чтения будет блокироваться, ожидая получения данных.</summary>
		/// <returns>Количество времени, по истечении синхронной операции чтения завершится ошибкой.</returns>
		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x0600448D RID: 17549 RVA: 0x000ECEEF File Offset: 0x000EB0EF
		// (set) Token: 0x0600448E RID: 17550 RVA: 0x000ECEFC File Offset: 0x000EB0FC
		public override int ReadTimeout
		{
			get
			{
				return this.Impl.ReadTimeout;
			}
			set
			{
				this.Impl.ReadTimeout = value;
			}
		}

		/// <summary>Возвращает или задает период времени, в течение которого операция записи блокирует выполнение, ожидая данных.</summary>
		/// <returns>Количество времени, по истечении которого происходит сбой синхронной операции записи.</returns>
		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x0600448F RID: 17551 RVA: 0x000ECF0A File Offset: 0x000EB10A
		// (set) Token: 0x06004490 RID: 17552 RVA: 0x000ECF17 File Offset: 0x000EB117
		public override int WriteTimeout
		{
			get
			{
				return this.Impl.WriteTimeout;
			}
			set
			{
				this.Impl.WriteTimeout = value;
			}
		}

		/// <summary>Возвращает длину данных в базовом потоке.</summary>
		/// <returns>Длина базового потока.</returns>
		/// <exception cref="T:System.NotSupportedException">Возвращение значения данного свойства не поддерживается, если базовый поток является экземпляром класса <see cref="T:System.Net.Sockets.NetworkStream" />.</exception>
		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x06004491 RID: 17553 RVA: 0x000ECF25 File Offset: 0x000EB125
		public override long Length
		{
			get
			{
				return this.Impl.Length;
			}
		}

		/// <summary>Возвращает или задает текущую позицию в базовом потоке.</summary>
		/// <returns>Текущая позиция в базовом потоке.</returns>
		/// <exception cref="T:System.NotSupportedException">Задание данного свойства не поддерживается.  
		/// -или- 
		/// Возвращение значения данного свойства не поддерживается, если базовый поток является экземпляром класса <see cref="T:System.Net.Sockets.NetworkStream" />.</exception>
		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x06004492 RID: 17554 RVA: 0x000ECF32 File Offset: 0x000EB132
		// (set) Token: 0x06004493 RID: 17555 RVA: 0x000ECF3F File Offset: 0x000EB13F
		public override long Position
		{
			get
			{
				return this.Impl.Position;
			}
			set
			{
				throw new NotSupportedException(SR.GetString("This stream does not support seek operations."));
			}
		}

		/// <summary>Задает длину данных в базовом потоке.</summary>
		/// <param name="value">Значение <see cref="T:System.Int64" />, указывающее длину потока.</param>
		// Token: 0x06004494 RID: 17556 RVA: 0x000ECF50 File Offset: 0x000EB150
		public override void SetLength(long value)
		{
			this.Impl.SetLength(value);
		}

		/// <summary>Создает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="offset">Это значение игнорируется.</param>
		/// <param name="origin">Это значение игнорируется.</param>
		/// <returns>Всегда создает исключение <see cref="T:System.NotSupportedException" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Поиск не поддерживается объектами <see cref="T:System.Net.Security.SslStream" />.</exception>
		// Token: 0x06004495 RID: 17557 RVA: 0x000ECF3F File Offset: 0x000EB13F
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException(SR.GetString("This stream does not support seek operations."));
		}

		// Token: 0x06004496 RID: 17558 RVA: 0x000ECF5E File Offset: 0x000EB15E
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			return base.InnerStream.FlushAsync(cancellationToken);
		}

		/// <summary>Принудительно записывает все буферизированные данные в базовое устройство.</summary>
		// Token: 0x06004497 RID: 17559 RVA: 0x00007E6C File Offset: 0x0000606C
		public override void Flush()
		{
			base.InnerStream.Flush();
		}

		// Token: 0x06004498 RID: 17560 RVA: 0x000ECF6C File Offset: 0x000EB16C
		private void CheckDisposed()
		{
			if (this.impl == null)
			{
				throw new ObjectDisposedException("SslStream");
			}
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Net.Security.SslStream" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06004499 RID: 17561 RVA: 0x000ECF84 File Offset: 0x000EB184
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (this.impl != null && disposing)
				{
					this.impl.Dispose();
					this.impl = null;
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		/// <summary>Считывает данные из этого потока и сохраняет их в заданном массиве.</summary>
		/// <param name="buffer">Массив элементов <see cref="T:System.Byte" />, куда помещаются байты, считанные из этого потока.</param>
		/// <param name="offset">Значение <see cref="T:System.Int32" />, содержащее расположение (начиная с нуля) в массиве <paramref name="buffer" />, с которого следует начинать сохранение данных, считанных их этого потока.</param>
		/// <param name="count">Значение <see cref="T:System.Int32" />, содержащий максимальное количество байтов, считываемых из этого потока.</param>
		/// <returns>Значение <see cref="T:System.Int32" />, указывающее количество считанных байтов. Когда данных для чтения не остается, возвращает 0.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="offset" />
		///   <paramref name="&lt;" />
		///   <paramref name="0" />.  
		///  <paramref name="-or-" /><paramref name="offset" /> &gt; длины <paramref name="buffer" />.  
		/// -или- 
		///  <paramref name="offset" /> + число &gt; длины <paramref name="buffer" />.</exception>
		/// <exception cref="T:System.IO.IOException">Сбой операции чтения. Проверьте внутреннее исключение, если такое присутствует, чтобы определить причину сбоя.</exception>
		/// <exception cref="T:System.NotSupportedException">Уже существует выполняющаяся операция чтения.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности не выполнялась.</exception>
		// Token: 0x0600449A RID: 17562 RVA: 0x000ECFCC File Offset: 0x000EB1CC
		public override int Read(byte[] buffer, int offset, int count)
		{
			return this.Impl.Read(buffer, offset, count);
		}

		/// <summary>Записывает в этот поток указанные данные.</summary>
		/// <param name="buffer">Массив элементов <see cref="T:System.Byte" />, предоставляющий байты для записи в поток.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.IOException">Не удалось выполнить операцию записи.</exception>
		/// <exception cref="T:System.NotSupportedException">Уже существует выполняющаяся операция записи.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности не выполнялась.</exception>
		// Token: 0x0600449B RID: 17563 RVA: 0x000ECFDC File Offset: 0x000EB1DC
		public void Write(byte[] buffer)
		{
			this.Impl.Write(buffer);
		}

		/// <summary>Записывает указанное количество элементов <see cref="T:System.Byte" /> в базовый поток, используя заданный буфер (параметр buffer) и начальное расположение (параметр offset).</summary>
		/// <param name="buffer">Массив элементов <see cref="T:System.Byte" />, предоставляющий байты для записи в поток.</param>
		/// <param name="offset">Значение <see cref="T:System.Int32" />, содержащее расположение (начиная с нуля) в массиве <paramref name="buffer" />, с которого требуется начинать чтение байтов, записываемых в поток.</param>
		/// <param name="count">Значение <see cref="T:System.Int32" />, содержащее количество байтов, считываемых из массива <paramref name="buffer" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="offset" />
		///   <paramref name="&lt;" />
		///   <paramref name="0" />.  
		///  <paramref name="-or-" /><paramref name="offset" /> &gt; длины <paramref name="buffer" />.  
		/// -или- 
		///  <paramref name="offset" /> + число &gt; длины <paramref name="buffer" />.</exception>
		/// <exception cref="T:System.IO.IOException">Не удалось выполнить операцию записи.</exception>
		/// <exception cref="T:System.NotSupportedException">Уже существует выполняющаяся операция записи.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности не выполнялась.</exception>
		// Token: 0x0600449C RID: 17564 RVA: 0x000ECFEF File Offset: 0x000EB1EF
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.Impl.Write(buffer, offset, count);
		}

		// Token: 0x0600449D RID: 17565 RVA: 0x000ECFFF File Offset: 0x000EB1FF
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return this.Impl.ReadAsync(buffer, offset, count, cancellationToken);
		}

		// Token: 0x0600449E RID: 17566 RVA: 0x000ED011 File Offset: 0x000EB211
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return this.Impl.WriteAsync(buffer, offset, count, cancellationToken);
		}

		/// <summary>Начинает асинхронную операцию чтения, которая считывает данные из потока и сохраняет их в заданном массиве.</summary>
		/// <param name="buffer">Массив элементов <see cref="T:System.Byte" />, куда помещаются байты, считанные из потока.</param>
		/// <param name="offset">Расположение (начиная с 0) в массиве, заданном параметром <paramref name="buffer" />, с которого начинается сохранение данных, считанных из этого потока.</param>
		/// <param name="count">Максимальное число байтов, которое должно быть считано из потока.</param>
		/// <param name="asyncCallback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, который следует вызвать после завершения операции чтения.</param>
		/// <param name="asyncState">Пользовательский объект, содержащий сведения об операции чтения. Этот объект передается делегату <paramref name="asyncCallback" /> после завершения операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, представляющий состояние асинхронной операции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="offset" />
		///   <paramref name="&lt;" />
		///   <paramref name="0" />.  
		///  <paramref name="-or-" /><paramref name="offset" /> &gt; длины <paramref name="buffer" />.  
		///
		/// или - 
		/// <paramref name="offset" /> + число &gt; длины <paramref name="buffer" />.</exception>
		/// <exception cref="T:System.IO.IOException">Сбой операции чтения.  
		///
		/// или - 
		/// Используется шифрование, но не удается расшифровать данные.</exception>
		/// <exception cref="T:System.NotSupportedException">Уже существует выполняющаяся операция чтения.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности не выполнялась.</exception>
		// Token: 0x0600449F RID: 17567 RVA: 0x000ED023 File Offset: 0x000EB223
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return TaskToApm.Begin(this.Impl.ReadAsync(buffer, offset, count), callback, state);
		}

		/// <summary>Заканчивает асинхронную операцию чтения, запущенную до этого вызовом метода <see cref="M:System.Net.Security.SslStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" />.</summary>
		/// <param name="asyncResult">Экземпляр <see cref="T:System.IAsyncResult" />, возвращенный вызовом метода <see cref="M:System.Net.Security.SslStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" />.</param>
		/// <returns>Значение <see cref="T:System.Int32" />, указывающее количество байтов, считанное из базового потока.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asyncResult" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="asyncResult" /> не был создан вызовом метода <see cref="M:System.Net.Security.SslStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Нет ожидающей завершения операции чтения.
		/// -или-
		/// Проверка подлинности не выполнялась.</exception>
		/// <exception cref="T:System.IO.IOException">Сбой операции чтения.</exception>
		// Token: 0x060044A0 RID: 17568 RVA: 0x0008F0E9 File Offset: 0x0008D2E9
		public override int EndRead(IAsyncResult asyncResult)
		{
			return TaskToApm.End<int>(asyncResult);
		}

		/// <summary>Начинает асинхронную операцию записи, которая записывает байты (<see cref="T:System.Byte" />) из указанного буфера в поток.</summary>
		/// <param name="buffer">Массив элементов <see cref="T:System.Byte" />, предоставляющий байты для записи в поток.</param>
		/// <param name="offset">Расположение (начиная с нуля) в массиве<paramref name="buffer" />, с которого требуется начать считывать байты, предназначенные для записи в поток.</param>
		/// <param name="count">Значение <see cref="T:System.Int32" />, определяющее количество байт, которые требуется считать из массива <paramref name="buffer" />.</param>
		/// <param name="asyncCallback">Делегат <see cref="T:System.AsyncCallback" />, ссылающийся на метод, который следует вызвать после завершения операции записи.</param>
		/// <param name="asyncState">Пользовательский объект, содержащий сведения об операции записи. Этот объект передается делегату <paramref name="asyncCallback" /> после завершения операции.</param>
		/// <returns>Объект <see cref="T:System.IAsyncResult" />, указывающий состояние асинхронной операции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="buffer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="offset" />
		///   <paramref name="&lt;" />
		///   <paramref name="0" />.  
		///  <paramref name="-or-" /><paramref name="offset" /> &gt; длины <paramref name="buffer" />.  
		/// -или- 
		///  <paramref name="offset" /> + число &gt; длины <paramref name="buffer" />.</exception>
		/// <exception cref="T:System.IO.IOException">Не удалось выполнить операцию записи.</exception>
		/// <exception cref="T:System.NotSupportedException">Уже существует выполняющаяся операция записи.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт.</exception>
		/// <exception cref="T:System.InvalidOperationException">Проверка подлинности не выполнялась.</exception>
		// Token: 0x060044A1 RID: 17569 RVA: 0x000ED03C File Offset: 0x000EB23C
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return TaskToApm.Begin(this.Impl.WriteAsync(buffer, offset, count), callback, state);
		}

		/// <summary>Завершает асинхронную операцию записи, запущенную до этого вызовом метода <see cref="M:System.Net.Security.SslStream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" />.</summary>
		/// <param name="asyncResult">Экземпляр <see cref="T:System.IAsyncResult" />, возвращенный вызовом метода <see cref="M:System.Net.Security.SslStream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="asyncResult" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="asyncResult" /> не был создан вызовом метода <see cref="M:System.Net.Security.SslStream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Нет ожидающей завершения операции записи.
		/// -или-
		/// Проверка подлинности не выполнялась.</exception>
		/// <exception cref="T:System.IO.IOException">Не удалось выполнить операцию записи.</exception>
		// Token: 0x060044A2 RID: 17570 RVA: 0x0009571A File Offset: 0x0009391A
		public override void EndWrite(IAsyncResult asyncResult)
		{
			TaskToApm.End(asyncResult);
		}

		// Token: 0x0400292A RID: 10538
		private MobileTlsProvider provider;

		// Token: 0x0400292B RID: 10539
		private MonoTlsSettings settings;

		// Token: 0x0400292C RID: 10540
		private RemoteCertificateValidationCallback validationCallback;

		// Token: 0x0400292D RID: 10541
		private LocalCertificateSelectionCallback selectionCallback;

		// Token: 0x0400292E RID: 10542
		private MobileAuthenticatedStream impl;

		// Token: 0x0400292F RID: 10543
		private bool explicitSettings;
	}
}
