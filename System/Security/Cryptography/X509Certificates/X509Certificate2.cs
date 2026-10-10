using System;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Internal.Cryptography;
using Microsoft.Win32.SafeHandles;
using Mono;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Представляет сертификат X.509.</summary>
	// Token: 0x020002D0 RID: 720
	[Serializable]
	public class X509Certificate2 : X509Certificate
	{
		/// <summary>Сбрасывает состояние объекта <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.</summary>
		// Token: 0x06001632 RID: 5682 RVA: 0x000590C4 File Offset: 0x000572C4
		public override void Reset()
		{
			this.lazyRawData = null;
			this.lazySignatureAlgorithm = null;
			this.lazyVersion = 0;
			this.lazySubjectName = null;
			this.lazyIssuerName = null;
			this.lazyPublicKey = null;
			this.lazyPrivateKey = null;
			this.lazyExtensions = null;
			base.Reset();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.</summary>
		// Token: 0x06001633 RID: 5683 RVA: 0x0005911F File Offset: 0x0005731F
		public X509Certificate2()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> с использованием информации из указанного массива байтов.</summary>
		/// <param name="rawData">Массив байтов, содержащий данные сертификата X.509.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка сертификата. Например: 
		/// – Заданный файл сертификата не существует.  
		/// — Сертификат недействителен.  
		/// — Пароль сертификата неверен.</exception>
		// Token: 0x06001634 RID: 5684 RVA: 0x00059128 File Offset: 0x00057328
		public X509Certificate2(byte[] rawData) : base(rawData)
		{
			if (rawData != null && rawData.Length != 0)
			{
				using (SafePasswordHandle safePasswordHandle = new SafePasswordHandle(null))
				{
					X509CertificateImpl impl = X509Helper.Import(rawData, safePasswordHandle, X509KeyStorageFlags.DefaultKeySet);
					base.ImportHandle(impl);
				}
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> с использованием массива байтов и пароля.</summary>
		/// <param name="rawData">Массив байтов, содержащий данные сертификата X.509.</param>
		/// <param name="password">Пароль для доступа к данным сертификата X.509.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка сертификата. Например: 
		/// – Заданный файл сертификата не существует.  
		/// — Сертификат недействителен.  
		/// — Пароль сертификата неверен.</exception>
		// Token: 0x06001635 RID: 5685 RVA: 0x00059178 File Offset: 0x00057378
		public X509Certificate2(byte[] rawData, string password) : base(rawData, password)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> с использованием массива байтов и пароля.</summary>
		/// <param name="rawData">Массив байтов, содержащий данные из сертификата X.509.</param>
		/// <param name="password">Пароль для доступа к данным сертификата X.509.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка сертификата. Например: 
		/// – Заданный файл сертификата не существует.  
		/// — Сертификат недействителен.  
		/// — Пароль сертификата неверен.</exception>
		// Token: 0x06001636 RID: 5686 RVA: 0x00059182 File Offset: 0x00057382
		[CLSCompliant(false)]
		public X509Certificate2(byte[] rawData, SecureString password) : base(rawData, password)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> с использованием массива байтов, пароля и флага хранилища ключей.</summary>
		/// <param name="rawData">Массив байтов, содержащий данные сертификата X.509.</param>
		/// <param name="password">Пароль для доступа к данным сертификата X.509.</param>
		/// <param name="keyStorageFlags">Поразрядное сочетание значений перечисления, определяющих, где и как следует импортировать сертификат.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка сертификата. Например: 
		/// – Заданный файл сертификата не существует.  
		/// — Сертификат недействителен.  
		/// — Пароль сертификата неверен.</exception>
		// Token: 0x06001637 RID: 5687 RVA: 0x0005918C File Offset: 0x0005738C
		public X509Certificate2(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) : base(rawData, password, keyStorageFlags)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> с использованием массива байтов, пароля и флага хранилища ключей.</summary>
		/// <param name="rawData">Массив байтов, содержащий данные из сертификата X.509.</param>
		/// <param name="password">Пароль для доступа к данным сертификата X.509.</param>
		/// <param name="keyStorageFlags">Поразрядное сочетание значений перечисления, определяющих, где и как следует импортировать сертификат.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка сертификата. Пример: 
		/// – Заданный файл сертификата не существует.  
		/// — Сертификат недействителен.  
		/// — Пароль сертификата неверен.</exception>
		// Token: 0x06001638 RID: 5688 RVA: 0x00059197 File Offset: 0x00057397
		[CLSCompliant(false)]
		public X509Certificate2(byte[] rawData, SecureString password, X509KeyStorageFlags keyStorageFlags) : base(rawData, password, keyStorageFlags)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> с помощью неуправляемого дескриптора.</summary>
		/// <param name="handle">Указатель на контекст сертификата в неуправляемом коде. Структура на языке C вызывается <see langword="PCCERT_CONTEXT" />.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка сертификата. Пример: 
		/// – Заданный файл сертификата не существует.  
		/// — Сертификат недействителен.  
		/// — Пароль сертификата неверен.</exception>
		// Token: 0x06001639 RID: 5689 RVA: 0x000591A2 File Offset: 0x000573A2
		public X509Certificate2(IntPtr handle) : base(handle)
		{
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x000591AB File Offset: 0x000573AB
		internal X509Certificate2(X509Certificate2Impl impl) : base(impl)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> с помощью имени файла сертификата.</summary>
		/// <param name="fileName">Имя файла сертификата.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка сертификата. Пример: 
		/// – Заданный файл сертификата не существует.  
		/// — Сертификат недействителен.  
		/// — Пароль сертификата неверен.</exception>
		// Token: 0x0600163B RID: 5691 RVA: 0x000591B4 File Offset: 0x000573B4
		public X509Certificate2(string fileName) : base(fileName)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />, используя имя файла сертификата и пароль для доступа к сертификату.</summary>
		/// <param name="fileName">Имя файла сертификата.</param>
		/// <param name="password">Пароль для доступа к данным сертификата X.509.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка сертификата. Например: 
		/// – Заданный файл сертификата не существует.  
		/// — Сертификат недействителен.  
		/// — Пароль сертификата неверен.</exception>
		// Token: 0x0600163C RID: 5692 RVA: 0x000591BD File Offset: 0x000573BD
		public X509Certificate2(string fileName, string password) : base(fileName, password)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> с использованием имени файла сертификата и пароля.</summary>
		/// <param name="fileName">Имя файла сертификата.</param>
		/// <param name="password">Пароль для доступа к данным сертификата X.509.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка сертификата. Например: 
		/// – Заданный файл сертификата не существует.  
		/// — Сертификат недействителен.  
		/// — Пароль сертификата неверен.</exception>
		// Token: 0x0600163D RID: 5693 RVA: 0x000591C7 File Offset: 0x000573C7
		public X509Certificate2(string fileName, SecureString password) : base(fileName, password)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> с использованием имени файла сертификата и пароля для доступа к сертификату, а также флага хранилища ключа.</summary>
		/// <param name="fileName">Имя файла сертификата.</param>
		/// <param name="password">Пароль для доступа к данным сертификата X.509.</param>
		/// <param name="keyStorageFlags">Поразрядное сочетание значений перечисления, определяющих, где и как следует импортировать сертификат.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка сертификата. Например: 
		/// – Заданный файл сертификата не существует.  
		/// — Сертификат недействителен.  
		/// — Пароль сертификата неверен.</exception>
		// Token: 0x0600163E RID: 5694 RVA: 0x000591D1 File Offset: 0x000573D1
		public X509Certificate2(string fileName, string password, X509KeyStorageFlags keyStorageFlags) : base(fileName, password, keyStorageFlags)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> с использованием имени файла сертификата, пароля и флага хранилища ключа.</summary>
		/// <param name="fileName">Имя файла сертификата.</param>
		/// <param name="password">Пароль для доступа к данным сертификата X.509.</param>
		/// <param name="keyStorageFlags">Поразрядное сочетание значений перечисления, определяющих, где и как следует импортировать сертификат.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка сертификата. Пример: 
		/// – Заданный файл сертификата не существует.  
		/// — Сертификат недействителен.  
		/// — Пароль сертификата неверен.</exception>
		// Token: 0x0600163F RID: 5695 RVA: 0x000591DC File Offset: 0x000573DC
		public X509Certificate2(string fileName, SecureString password, X509KeyStorageFlags keyStorageFlags) : base(fileName, password, keyStorageFlags)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> с помощью объекта <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />.</summary>
		/// <param name="certificate">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка сертификата. Например: 
		/// – Заданный файл сертификата не существует.  
		/// — Сертификат недействителен.  
		/// — Пароль сертификата неверен.</exception>
		// Token: 0x06001640 RID: 5696 RVA: 0x000591E7 File Offset: 0x000573E7
		public X509Certificate2(X509Certificate certificate) : base(certificate)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />, используя заданную информацию о сериализации и контексте потоков.</summary>
		/// <param name="info">Сведения о сериализации, необходимые для десериализации нового объекта <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.</param>
		/// <param name="context">Контекстные сведения об источнике десериализуемого потока.</param>
		// Token: 0x06001641 RID: 5697 RVA: 0x000591F0 File Offset: 0x000573F0
		protected X509Certificate2(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			throw new PlatformNotSupportedException();
		}

		/// <summary>Получает или задает значение, указывающее на архивирование сертификата X.509.</summary>
		/// <returns>Значение <see langword="true" />, если сертификат архивирован, значение<see langword="false" />, если сертификат не архивирован.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Сертификат не читается.</exception>
		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001642 RID: 5698 RVA: 0x000591FF File Offset: 0x000573FF
		// (set) Token: 0x06001643 RID: 5699 RVA: 0x00059212 File Offset: 0x00057412
		public bool Archived
		{
			get
			{
				base.ThrowIfInvalid();
				return this.Impl.Archived;
			}
			set
			{
				base.ThrowIfInvalid();
				this.Impl.Archived = value;
			}
		}

		/// <summary>Возвращает коллекцию объектов <see cref="T:System.Security.Cryptography.X509Certificates.X509Extension" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Сертификат не читается.</exception>
		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001644 RID: 5700 RVA: 0x00059228 File Offset: 0x00057428
		public X509ExtensionCollection Extensions
		{
			get
			{
				base.ThrowIfInvalid();
				X509ExtensionCollection x509ExtensionCollection = this.lazyExtensions;
				if (x509ExtensionCollection == null)
				{
					x509ExtensionCollection = new X509ExtensionCollection();
					foreach (X509Extension x509Extension in this.Impl.Extensions)
					{
						X509Extension x509Extension2 = X509Certificate2.CreateCustomExtensionIfAny(x509Extension.Oid);
						if (x509Extension2 == null)
						{
							x509ExtensionCollection.Add(x509Extension);
						}
						else
						{
							x509Extension2.CopyFrom(x509Extension);
							x509ExtensionCollection.Add(x509Extension2);
						}
					}
					this.lazyExtensions = x509ExtensionCollection;
				}
				return x509ExtensionCollection;
			}
		}

		/// <summary>Получает или задает связанный псевдоним для сертификата.</summary>
		/// <returns>Понятное имя сертификата.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Сертификат не читается.</exception>
		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001645 RID: 5701 RVA: 0x000592C0 File Offset: 0x000574C0
		// (set) Token: 0x06001646 RID: 5702 RVA: 0x000592D3 File Offset: 0x000574D3
		public string FriendlyName
		{
			get
			{
				base.ThrowIfInvalid();
				return this.Impl.FriendlyName;
			}
			set
			{
				base.ThrowIfInvalid();
				this.Impl.FriendlyName = value;
			}
		}

		/// <summary>Возвращает значение, которое указывает, содержит ли объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> закрытый ключ.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> содержит закрытый ключ; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Недопустимый контекст сертификата.</exception>
		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001647 RID: 5703 RVA: 0x000592E7 File Offset: 0x000574E7
		public bool HasPrivateKey
		{
			get
			{
				base.ThrowIfInvalid();
				return this.Impl.HasPrivateKey;
			}
		}

		/// <summary>Получает или задает объект <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" />, который представляет закрытый ключ, связанный с сертификатом.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" />, являющийся поставщиком служб шифрования RSA или DSA.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значение ключа не является значением RSA или DSA, или ключ не читается.</exception>
		/// <exception cref="T:System.ArgumentNullException">Для этого свойства устанавливается значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Алгоритм ключа для этого закрытого ключа не поддерживается.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">Ключи X.509 не совпадают.</exception>
		/// <exception cref="T:System.ArgumentException">Значение ключа поставщика служб шифрования равно <see langword="null" />.</exception>
		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001648 RID: 5704 RVA: 0x000592FC File Offset: 0x000574FC
		// (set) Token: 0x06001649 RID: 5705 RVA: 0x00011F54 File Offset: 0x00010154
		public AsymmetricAlgorithm PrivateKey
		{
			get
			{
				base.ThrowIfInvalid();
				if (!this.HasPrivateKey)
				{
					return null;
				}
				if (this.lazyPrivateKey == null)
				{
					string keyAlgorithm = this.GetKeyAlgorithm();
					if (!(keyAlgorithm == "1.2.840.113549.1.1.1"))
					{
						if (!(keyAlgorithm == "1.2.840.10040.4.1"))
						{
							throw new NotSupportedException("The certificate key algorithm is not supported.");
						}
						this.lazyPrivateKey = this.Impl.GetDSAPrivateKey();
					}
					else
					{
						this.lazyPrivateKey = this.Impl.GetRSAPrivateKey();
					}
				}
				return this.lazyPrivateKey;
			}
			set
			{
				throw new PlatformNotSupportedException();
			}
		}

		/// <summary>Получает различающееся имя поставщика сертификата.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.X509Certificates.X500DistinguishedName" />, содержащий имя поставщика сертификата.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Недопустимый контекст сертификата.</exception>
		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x0600164A RID: 5706 RVA: 0x00059384 File Offset: 0x00057584
		public X500DistinguishedName IssuerName
		{
			get
			{
				base.ThrowIfInvalid();
				X500DistinguishedName x500DistinguishedName = this.lazyIssuerName;
				if (x500DistinguishedName == null)
				{
					x500DistinguishedName = (this.lazyIssuerName = this.Impl.IssuerName);
				}
				return x500DistinguishedName;
			}
		}

		/// <summary>Получает дату в формате местного времени, после которой сертификат недействителен.</summary>
		/// <returns>Объект <see cref="T:System.DateTime" />, представляющий дату окончания срока действия сертификата.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Сертификат не читается.</exception>
		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x0600164B RID: 5707 RVA: 0x000593BB File Offset: 0x000575BB
		public DateTime NotAfter
		{
			get
			{
				return base.GetNotAfter();
			}
		}

		/// <summary>Получает дату в формате местного времени, после которой сертификат становится действительным.</summary>
		/// <returns>Объект <see cref="T:System.DateTime" />, представляющий дату вступления в силу сертификата.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Сертификат не читается.</exception>
		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x0600164C RID: 5708 RVA: 0x000593C3 File Offset: 0x000575C3
		public DateTime NotBefore
		{
			get
			{
				return base.GetNotBefore();
			}
		}

		/// <summary>Получает объект <see cref="P:System.Security.Cryptography.X509Certificates.X509Certificate2.PublicKey" />, связанный с сертификатом.</summary>
		/// <returns>Объект <see cref="P:System.Security.Cryptography.X509Certificates.X509Certificate2.PublicKey" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значение ключа не является значением RSA или DSA, или ключ не читается.</exception>
		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x0600164D RID: 5709 RVA: 0x000593CC File Offset: 0x000575CC
		public PublicKey PublicKey
		{
			get
			{
				base.ThrowIfInvalid();
				PublicKey publicKey = this.lazyPublicKey;
				if (publicKey == null)
				{
					string keyAlgorithm = this.GetKeyAlgorithm();
					byte[] keyAlgorithmParameters = this.GetKeyAlgorithmParameters();
					byte[] publicKey2 = this.GetPublicKey();
					Oid oid = new Oid(keyAlgorithm);
					publicKey = (this.lazyPublicKey = new PublicKey(oid, new AsnEncodedData(oid, keyAlgorithmParameters), new AsnEncodedData(oid, publicKey2)));
				}
				return publicKey;
			}
		}

		/// <summary>Получает необработанные данные сертификата.</summary>
		/// <returns>Необработанные данные сертификата в качестве массива байтов.</returns>
		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x0600164E RID: 5710 RVA: 0x00059428 File Offset: 0x00057628
		public byte[] RawData
		{
			get
			{
				base.ThrowIfInvalid();
				byte[] array = this.lazyRawData;
				if (array == null)
				{
					array = (this.lazyRawData = this.Impl.RawData);
				}
				return array.CloneByteArray();
			}
		}

		/// <summary>Получает серийный номер сертификата в виде шестнадцатеричной строки в обратном порядке.</summary>
		/// <returns>Серийный номер сертификата в виде шестнадцатеричной строки с обратным порядком байтов.</returns>
		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x0600164F RID: 5711 RVA: 0x00059464 File Offset: 0x00057664
		public string SerialNumber
		{
			get
			{
				return this.GetSerialNumberString();
			}
		}

		/// <summary>Получает алгоритм, используемый для создания подписи сертификата.</summary>
		/// <returns>Идентификатор объекта алгоритма подписи.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Сертификат не читается.</exception>
		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001650 RID: 5712 RVA: 0x0005946C File Offset: 0x0005766C
		public Oid SignatureAlgorithm
		{
			get
			{
				base.ThrowIfInvalid();
				Oid oid = this.lazySignatureAlgorithm;
				if (oid == null)
				{
					string signatureAlgorithm = this.Impl.SignatureAlgorithm;
					oid = (this.lazySignatureAlgorithm = Oid.FromOidValue(signatureAlgorithm, OidGroup.SignatureAlgorithm));
				}
				return oid;
			}
		}

		/// <summary>Получает различающееся имя субъекта от сертификата.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.X509Certificates.X500DistinguishedName" />, представляющий имя субъекта сертификата.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Недопустимый контекст сертификата.</exception>
		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001651 RID: 5713 RVA: 0x000594AC File Offset: 0x000576AC
		public X500DistinguishedName SubjectName
		{
			get
			{
				base.ThrowIfInvalid();
				X500DistinguishedName x500DistinguishedName = this.lazySubjectName;
				if (x500DistinguishedName == null)
				{
					x500DistinguishedName = (this.lazySubjectName = this.Impl.SubjectName);
				}
				return x500DistinguishedName;
			}
		}

		/// <summary>Получает отпечаток сертификата.</summary>
		/// <returns>Отпечаток сертификата.</returns>
		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001652 RID: 5714 RVA: 0x000594E3 File Offset: 0x000576E3
		public string Thumbprint
		{
			get
			{
				return this.GetCertHash().ToHexStringUpper();
			}
		}

		/// <summary>Получает версию формата сертификата X.509.</summary>
		/// <returns>Формат сертификата.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Сертификат не читается.</exception>
		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001653 RID: 5715 RVA: 0x000594F0 File Offset: 0x000576F0
		public int Version
		{
			get
			{
				base.ThrowIfInvalid();
				int num = this.lazyVersion;
				if (num == 0)
				{
					num = (this.lazyVersion = this.Impl.Version);
				}
				return num;
			}
		}

		/// <summary>Показывает тип сертификата, содержащегося в массиве байтов.</summary>
		/// <param name="rawData">Массив байтов, содержащий данные сертификата X.509.</param>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509ContentType" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="rawData" /> имеет нулевую длину, или его значение равно <see langword="null" />.</exception>
		// Token: 0x06001654 RID: 5716 RVA: 0x00059527 File Offset: 0x00057727
		public static X509ContentType GetCertContentType(byte[] rawData)
		{
			if (rawData == null || rawData.Length == 0)
			{
				throw new ArgumentException("Array cannot be empty or null.", "rawData");
			}
			return X509Pal.Instance.GetCertContentType(rawData);
		}

		/// <summary>Показывает тип сертификата, содержащегося в файле.</summary>
		/// <param name="fileName">Имя файла сертификата.</param>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509ContentType" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="fileName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001655 RID: 5717 RVA: 0x0005954B File Offset: 0x0005774B
		public static X509ContentType GetCertContentType(string fileName)
		{
			if (fileName == null)
			{
				throw new ArgumentNullException("fileName");
			}
			Path.GetFullPath(fileName);
			return X509Pal.Instance.GetCertContentType(fileName);
		}

		/// <summary>Получает имена субъекта и поставщика сертификата.</summary>
		/// <param name="nameType">Значение <see cref="T:System.Security.Cryptography.X509Certificates.X509NameType" /> для субъекта.</param>
		/// <param name="forIssuer">Значение <see langword="true" /> для включения имени поставщика; в противном случае — <see langword="false" />.</param>
		/// <returns>Имя сертификата.</returns>
		// Token: 0x06001656 RID: 5718 RVA: 0x0005956D File Offset: 0x0005776D
		public string GetNameInfo(X509NameType nameType, bool forIssuer)
		{
			return this.Impl.GetNameInfo(nameType, forIssuer);
		}

		/// <summary>Отображает сертификат X.509 в текстовом формате.</summary>
		/// <returns>Сведения о сертификате.</returns>
		// Token: 0x06001657 RID: 5719 RVA: 0x0005957C File Offset: 0x0005777C
		public override string ToString()
		{
			return base.ToString(true);
		}

		/// <summary>Отображает сертификат X.509 в текстовом формате.</summary>
		/// <param name="verbose">Значение <see langword="true" /> для отображения открытого ключа, закрытого ключа, расширений и т. д.; значение <see langword="false" /> для отображения сведений, аналогичных классу <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />, в том числе отпечаток, серийный номер, имена субъекта и поставщика и т. д.</param>
		/// <returns>Сведения о сертификате.</returns>
		// Token: 0x06001658 RID: 5720 RVA: 0x00059588 File Offset: 0x00057788
		public override string ToString(bool verbose)
		{
			if (!verbose || !base.IsValid)
			{
				return this.ToString();
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("[Version]");
			stringBuilder.Append("  V");
			stringBuilder.Append(this.Version);
			stringBuilder.AppendLine();
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("[Subject]");
			stringBuilder.Append("  ");
			stringBuilder.Append(this.SubjectName.Name);
			string nameInfo = this.GetNameInfo(X509NameType.SimpleName, false);
			if (nameInfo.Length > 0)
			{
				stringBuilder.AppendLine();
				stringBuilder.Append("  ");
				stringBuilder.Append("Simple Name: ");
				stringBuilder.Append(nameInfo);
			}
			string nameInfo2 = this.GetNameInfo(X509NameType.EmailName, false);
			if (nameInfo2.Length > 0)
			{
				stringBuilder.AppendLine();
				stringBuilder.Append("  ");
				stringBuilder.Append("Email Name: ");
				stringBuilder.Append(nameInfo2);
			}
			string nameInfo3 = this.GetNameInfo(X509NameType.UpnName, false);
			if (nameInfo3.Length > 0)
			{
				stringBuilder.AppendLine();
				stringBuilder.Append("  ");
				stringBuilder.Append("UPN Name: ");
				stringBuilder.Append(nameInfo3);
			}
			string nameInfo4 = this.GetNameInfo(X509NameType.DnsName, false);
			if (nameInfo4.Length > 0)
			{
				stringBuilder.AppendLine();
				stringBuilder.Append("  ");
				stringBuilder.Append("DNS Name: ");
				stringBuilder.Append(nameInfo4);
			}
			stringBuilder.AppendLine();
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("[Issuer]");
			stringBuilder.Append("  ");
			stringBuilder.Append(this.IssuerName.Name);
			nameInfo = this.GetNameInfo(X509NameType.SimpleName, true);
			if (nameInfo.Length > 0)
			{
				stringBuilder.AppendLine();
				stringBuilder.Append("  ");
				stringBuilder.Append("Simple Name: ");
				stringBuilder.Append(nameInfo);
			}
			nameInfo2 = this.GetNameInfo(X509NameType.EmailName, true);
			if (nameInfo2.Length > 0)
			{
				stringBuilder.AppendLine();
				stringBuilder.Append("  ");
				stringBuilder.Append("Email Name: ");
				stringBuilder.Append(nameInfo2);
			}
			nameInfo3 = this.GetNameInfo(X509NameType.UpnName, true);
			if (nameInfo3.Length > 0)
			{
				stringBuilder.AppendLine();
				stringBuilder.Append("  ");
				stringBuilder.Append("UPN Name: ");
				stringBuilder.Append(nameInfo3);
			}
			nameInfo4 = this.GetNameInfo(X509NameType.DnsName, true);
			if (nameInfo4.Length > 0)
			{
				stringBuilder.AppendLine();
				stringBuilder.Append("  ");
				stringBuilder.Append("DNS Name: ");
				stringBuilder.Append(nameInfo4);
			}
			stringBuilder.AppendLine();
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("[Serial Number]");
			stringBuilder.Append("  ");
			stringBuilder.AppendLine(this.SerialNumber);
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("[Not Before]");
			stringBuilder.Append("  ");
			stringBuilder.AppendLine(X509Certificate.FormatDate(this.NotBefore));
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("[Not After]");
			stringBuilder.Append("  ");
			stringBuilder.AppendLine(X509Certificate.FormatDate(this.NotAfter));
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("[Thumbprint]");
			stringBuilder.Append("  ");
			stringBuilder.AppendLine(this.Thumbprint);
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("[Signature Algorithm]");
			stringBuilder.Append("  ");
			stringBuilder.Append(this.SignatureAlgorithm.FriendlyName);
			stringBuilder.Append('(');
			stringBuilder.Append(this.SignatureAlgorithm.Value);
			stringBuilder.AppendLine(")");
			stringBuilder.AppendLine();
			stringBuilder.Append("[Public Key]");
			try
			{
				PublicKey publicKey = this.PublicKey;
				stringBuilder.AppendLine();
				stringBuilder.Append("  ");
				stringBuilder.Append("Algorithm: ");
				stringBuilder.Append(publicKey.Oid.FriendlyName);
				try
				{
					stringBuilder.AppendLine();
					stringBuilder.Append("  ");
					stringBuilder.Append("Length: ");
					using (RSA rsapublicKey = this.GetRSAPublicKey())
					{
						if (rsapublicKey != null)
						{
							stringBuilder.Append(rsapublicKey.KeySize);
						}
					}
				}
				catch (NotSupportedException)
				{
				}
				stringBuilder.AppendLine();
				stringBuilder.Append("  ");
				stringBuilder.Append("Key Blob: ");
				stringBuilder.AppendLine(publicKey.EncodedKeyValue.Format(true));
				stringBuilder.Append("  ");
				stringBuilder.Append("Parameters: ");
				stringBuilder.Append(publicKey.EncodedParameters.Format(true));
			}
			catch (CryptographicException)
			{
			}
			this.Impl.AppendPrivateKeyInfo(stringBuilder);
			X509ExtensionCollection extensions = this.Extensions;
			if (extensions.Count > 0)
			{
				stringBuilder.AppendLine();
				stringBuilder.AppendLine();
				stringBuilder.Append("[Extensions]");
				foreach (X509Extension x509Extension in extensions)
				{
					try
					{
						stringBuilder.AppendLine();
						stringBuilder.Append("* ");
						stringBuilder.Append(x509Extension.Oid.FriendlyName);
						stringBuilder.Append('(');
						stringBuilder.Append(x509Extension.Oid.Value);
						stringBuilder.Append("):");
						stringBuilder.AppendLine();
						stringBuilder.Append("  ");
						stringBuilder.Append(x509Extension.Format(true));
					}
					catch (CryptographicException)
					{
					}
				}
			}
			stringBuilder.AppendLine();
			return stringBuilder.ToString();
		}

		/// <summary>Заполняет объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> данными из массива байтов.</summary>
		/// <param name="rawData">Массив байтов, содержащий данные сертификата X.509.</param>
		// Token: 0x06001659 RID: 5721 RVA: 0x00059B38 File Offset: 0x00057D38
		public override void Import(byte[] rawData)
		{
			base.Import(rawData);
		}

		/// <summary>Заполняет объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> с помощью данных из массива данных, пароля и флагов, чтобы определить способ импорта закрытого ключа.</summary>
		/// <param name="rawData">Массив байтов, содержащий данные сертификата X.509.</param>
		/// <param name="password">Пароль для доступа к данным сертификата X.509.</param>
		/// <param name="keyStorageFlags">Поразрядное сочетание значений перечисления, определяющих, где и как следует импортировать сертификат.</param>
		// Token: 0x0600165A RID: 5722 RVA: 0x00059B41 File Offset: 0x00057D41
		public override void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags)
		{
			base.Import(rawData, password, keyStorageFlags);
		}

		/// <summary>Заполняет объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> с помощью данных из массива данных, пароля и флага хранилища ключа.</summary>
		/// <param name="rawData">Массив байтов, содержащий данные из сертификата X.509.</param>
		/// <param name="password">Пароль для доступа к данным сертификата X.509.</param>
		/// <param name="keyStorageFlags">Поразрядное сочетание значений перечисления, определяющих, где и как следует импортировать сертификат.</param>
		// Token: 0x0600165B RID: 5723 RVA: 0x00059B4C File Offset: 0x00057D4C
		[CLSCompliant(false)]
		public override void Import(byte[] rawData, SecureString password, X509KeyStorageFlags keyStorageFlags)
		{
			base.Import(rawData, password, keyStorageFlags);
		}

		/// <summary>Заполняет объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> сведениями из файла сертификата.</summary>
		/// <param name="fileName">Имя сертификата.</param>
		// Token: 0x0600165C RID: 5724 RVA: 0x00059B57 File Offset: 0x00057D57
		public override void Import(string fileName)
		{
			base.Import(fileName);
		}

		/// <summary>Заполняет объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> сведениями из файла сертификата, паролем и значением <see cref="T:System.Security.Cryptography.X509Certificates.X509KeyStorageFlags" />.</summary>
		/// <param name="fileName">Имя файла сертификата.</param>
		/// <param name="password">Пароль для доступа к данным сертификата X.509.</param>
		/// <param name="keyStorageFlags">Поразрядное сочетание значений перечисления, определяющих, где и как следует импортировать сертификат.</param>
		// Token: 0x0600165D RID: 5725 RVA: 0x00059B60 File Offset: 0x00057D60
		public override void Import(string fileName, string password, X509KeyStorageFlags keyStorageFlags)
		{
			base.Import(fileName, password, keyStorageFlags);
		}

		/// <summary>Заполняет объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> сведениями из файла сертификата, паролем и флагом хранилища ключа.</summary>
		/// <param name="fileName">Имя файла сертификата.</param>
		/// <param name="password">Пароль для доступа к данным сертификата X.509.</param>
		/// <param name="keyStorageFlags">Поразрядное сочетание значений перечисления, определяющих, где и как следует импортировать сертификат.</param>
		// Token: 0x0600165E RID: 5726 RVA: 0x00059B6B File Offset: 0x00057D6B
		[CLSCompliant(false)]
		public override void Import(string fileName, SecureString password, X509KeyStorageFlags keyStorageFlags)
		{
			base.Import(fileName, password, keyStorageFlags);
		}

		/// <summary>Выполняет проверку цепочки X.509 с использованием базовой политики проверки.</summary>
		/// <returns>Значение <see langword="true" />, если проверка прошла успешно; значение <see langword="false" />, если произошел сбой проверки.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Сертификат не читается.</exception>
		// Token: 0x0600165F RID: 5727 RVA: 0x00059B76 File Offset: 0x00057D76
		public bool Verify()
		{
			return this.Impl.Verify(this);
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x00059B84 File Offset: 0x00057D84
		private static X509Extension CreateCustomExtensionIfAny(Oid oid)
		{
			string value = oid.Value;
			if (!(value == "2.5.29.10"))
			{
				if (value == "2.5.29.19")
				{
					return new X509BasicConstraintsExtension();
				}
				if (value == "2.5.29.15")
				{
					return new X509KeyUsageExtension();
				}
				if (value == "2.5.29.37")
				{
					return new X509EnhancedKeyUsageExtension();
				}
				if (!(value == "2.5.29.14"))
				{
					return null;
				}
				return new X509SubjectKeyIdentifierExtension();
			}
			else
			{
				if (!X509Pal.Instance.SupportsLegacyBasicConstraintsExtension)
				{
					return null;
				}
				return new X509BasicConstraintsExtension();
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001661 RID: 5729 RVA: 0x00059C08 File Offset: 0x00057E08
		internal new X509Certificate2Impl Impl
		{
			get
			{
				X509Certificate2Impl x509Certificate2Impl = base.Impl as X509Certificate2Impl;
				X509Helper.ThrowIfContextInvalid(x509Certificate2Impl);
				return x509Certificate2Impl;
			}
		}

		// Token: 0x04000CEF RID: 3311
		private volatile byte[] lazyRawData;

		// Token: 0x04000CF0 RID: 3312
		private volatile Oid lazySignatureAlgorithm;

		// Token: 0x04000CF1 RID: 3313
		private volatile int lazyVersion;

		// Token: 0x04000CF2 RID: 3314
		private volatile X500DistinguishedName lazySubjectName;

		// Token: 0x04000CF3 RID: 3315
		private volatile X500DistinguishedName lazyIssuerName;

		// Token: 0x04000CF4 RID: 3316
		private volatile PublicKey lazyPublicKey;

		// Token: 0x04000CF5 RID: 3317
		private volatile AsymmetricAlgorithm lazyPrivateKey;

		// Token: 0x04000CF6 RID: 3318
		private volatile X509ExtensionCollection lazyExtensions;
	}
}
