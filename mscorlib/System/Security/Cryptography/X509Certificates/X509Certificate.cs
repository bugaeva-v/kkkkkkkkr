using System;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using Internal.Cryptography;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Предоставляет методы, помогающие использовать сертификаты X.509 v.3.</summary>
	// Token: 0x020004D9 RID: 1241
	[Serializable]
	public class X509Certificate : IDisposable, IDeserializationCallback, ISerializable
	{
		/// <summary>Сбрасывает состояние объекта <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.</summary>
		// Token: 0x0600316C RID: 12652 RVA: 0x000B6CDC File Offset: 0x000B4EDC
		public virtual void Reset()
		{
			if (this.impl != null)
			{
				this.impl.Dispose();
				this.impl = null;
			}
			this.lazyCertHash = null;
			this.lazyIssuer = null;
			this.lazySubject = null;
			this.lazySerialNumber = null;
			this.lazyKeyAlgorithm = null;
			this.lazyKeyAlgorithmParameters = null;
			this.lazyPublicKey = null;
			this.lazyNotBefore = DateTime.MinValue;
			this.lazyNotAfter = DateTime.MinValue;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />.</summary>
		// Token: 0x0600316D RID: 12653 RVA: 0x000B6D58 File Offset: 0x000B4F58
		public X509Certificate()
		{
		}

		/// <summary>Инициализирует новый класс <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />, определенный из последовательности байтов, представляющих сертификат X.509v3.</summary>
		/// <param name="data">Массив байтов, содержащий данные сертификата X.509.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка сертификата. Например: 
		/// – Заданный файл сертификата не существует.  
		/// — Сертификат недействителен.  
		/// — Пароль сертификата неверен.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="rawData" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Длина параметра <paramref name="rawData" /> равна 0.</exception>
		// Token: 0x0600316E RID: 12654 RVA: 0x000B6D76 File Offset: 0x000B4F76
		public X509Certificate(byte[] data)
		{
			if (data != null && data.Length != 0)
			{
				this.impl = X509Helper.Import(data);
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> с использованием массива байтов и пароля.</summary>
		/// <param name="rawData">Массив байтов, содержащий данные сертификата X.509.</param>
		/// <param name="password">Пароль для доступа к данным сертификата X.509.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка сертификата. Например: 
		/// – Заданный файл сертификата не существует.  
		/// — Сертификат недействителен.  
		/// — Пароль сертификата неверен.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="rawData" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Длина параметра <paramref name="rawData" /> равна 0.</exception>
		// Token: 0x0600316F RID: 12655 RVA: 0x000B6DA7 File Offset: 0x000B4FA7
		public X509Certificate(byte[] rawData, string password) : this(rawData, password, X509KeyStorageFlags.DefaultKeySet)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> с использованием массива байтов и пароля.</summary>
		/// <param name="rawData">Массив байтов, содержащий данные из сертификата X.509.</param>
		/// <param name="password">Пароль для доступа к данным сертификата X.509.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка сертификата. Например: 
		/// – Заданный файл сертификата не существует.  
		/// — Сертификат недействителен.  
		/// — Пароль сертификата неверен.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="rawData" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Длина параметра <paramref name="rawData" /> равна 0.</exception>
		// Token: 0x06003170 RID: 12656 RVA: 0x000B6DB2 File Offset: 0x000B4FB2
		[CLSCompliant(false)]
		public X509Certificate(byte[] rawData, SecureString password) : this(rawData, password, X509KeyStorageFlags.DefaultKeySet)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> с использованием массива байтов, пароля и флага хранилища ключей.</summary>
		/// <param name="rawData">Массив байтов, содержащий данные сертификата X.509.</param>
		/// <param name="password">Пароль для доступа к данным сертификата X.509.</param>
		/// <param name="keyStorageFlags">Поразрядное сочетание значений перечисления, определяющих, где и как следует импортировать сертификат.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка сертификата. Например: 
		/// – Заданный файл сертификата не существует.  
		/// — Сертификат недействителен.  
		/// — Пароль сертификата неверен.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="rawData" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Длина параметра <paramref name="rawData" /> равна 0.</exception>
		// Token: 0x06003171 RID: 12657 RVA: 0x000B6DC0 File Offset: 0x000B4FC0
		public X509Certificate(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags)
		{
			if (rawData == null || rawData.Length == 0)
			{
				throw new ArgumentException("Array cannot be empty or null.", "rawData");
			}
			X509Certificate.ValidateKeyStorageFlags(keyStorageFlags);
			using (SafePasswordHandle safePasswordHandle = new SafePasswordHandle(password))
			{
				this.impl = X509Helper.Import(rawData, safePasswordHandle, keyStorageFlags);
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> с использованием массива байтов, пароля и флага хранилища ключей.</summary>
		/// <param name="rawData">Массив байтов, содержащий данные из сертификата X.509.</param>
		/// <param name="password">Пароль для доступа к данным сертификата X.509.</param>
		/// <param name="keyStorageFlags">Поразрядное сочетание значений перечисления, определяющих, где и как следует импортировать сертификат.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка сертификата. Например: 
		/// – Заданный файл сертификата не существует.  
		/// — Сертификат недействителен.  
		/// — Пароль сертификата неверен.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="rawData" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Длина параметра <paramref name="rawData" /> равна 0.</exception>
		// Token: 0x06003172 RID: 12658 RVA: 0x000B6E38 File Offset: 0x000B5038
		[CLSCompliant(false)]
		public X509Certificate(byte[] rawData, SecureString password, X509KeyStorageFlags keyStorageFlags)
		{
			if (rawData == null || rawData.Length == 0)
			{
				throw new ArgumentException("Array cannot be empty or null.", "rawData");
			}
			X509Certificate.ValidateKeyStorageFlags(keyStorageFlags);
			using (SafePasswordHandle safePasswordHandle = new SafePasswordHandle(password))
			{
				this.impl = X509Helper.Import(rawData, safePasswordHandle, keyStorageFlags);
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> с помощью дескриптора неуправляемой структуры <see langword="PCCERT_CONTEXT" />.</summary>
		/// <param name="handle">Дескриптор неуправляемой структуры <see langword="PCCERT_CONTEXT" />.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка сертификата. Например: 
		/// – Заданный файл сертификата не существует.  
		/// — Сертификат недействителен.  
		/// — Пароль сертификата неверен.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр дескриптора не представляет допустимой структуры <see langword="PCCERT_CONTEXT" />.</exception>
		// Token: 0x06003173 RID: 12659 RVA: 0x000B6EB0 File Offset: 0x000B50B0
		public X509Certificate(IntPtr handle)
		{
			throw new PlatformNotSupportedException("Initializing `X509Certificate` from native handle is not supported.");
		}

		// Token: 0x06003174 RID: 12660 RVA: 0x000B6ED8 File Offset: 0x000B50D8
		internal X509Certificate(X509CertificateImpl impl)
		{
			this.impl = X509Helper.InitFromCertificate(impl);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> именем подписанного файла PKCS7.</summary>
		/// <param name="fileName">Имя подписанного файла PKCS7.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка сертификата. Например: 
		/// – Заданный файл сертификата не существует.  
		/// — Сертификат недействителен.  
		/// — Пароль сертификата неверен.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="fileName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003175 RID: 12661 RVA: 0x000B6F02 File Offset: 0x000B5102
		public X509Certificate(string fileName) : this(fileName, null, X509KeyStorageFlags.DefaultKeySet)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />, именем подписанного файла PKCS7 и паролем для доступа к сертификату.</summary>
		/// <param name="fileName">Имя подписанного файла PKCS7.</param>
		/// <param name="password">Пароль для доступа к данным сертификата X.509.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка сертификата. Например: 
		/// – Заданный файл сертификата не существует.  
		/// — Сертификат недействителен.  
		/// — Пароль сертификата неверен.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="fileName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003176 RID: 12662 RVA: 0x000B6F0D File Offset: 0x000B510D
		public X509Certificate(string fileName, string password) : this(fileName, password, X509KeyStorageFlags.DefaultKeySet)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> с использованием имени файла сертификата и пароля.</summary>
		/// <param name="fileName">Имя файла сертификата.</param>
		/// <param name="password">Пароль для доступа к данным сертификата X.509.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка сертификата. Например: 
		/// – Заданный файл сертификата не существует.  
		/// — Сертификат недействителен.  
		/// — Пароль сертификата неверен.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="fileName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003177 RID: 12663 RVA: 0x000B6F18 File Offset: 0x000B5118
		[CLSCompliant(false)]
		public X509Certificate(string fileName, SecureString password) : this(fileName, password, X509KeyStorageFlags.DefaultKeySet)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />, именем подписанного файла PKCS7 и паролем для доступа к сертификату и флагом хранилища ключей.</summary>
		/// <param name="fileName">Имя подписанного файла PKCS7.</param>
		/// <param name="password">Пароль для доступа к данным сертификата X.509.</param>
		/// <param name="keyStorageFlags">Поразрядное сочетание значений перечисления, определяющих, где и как следует импортировать сертификат.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка сертификата. Например: 
		/// – Заданный файл сертификата не существует.  
		/// — Сертификат недействителен.  
		/// — Пароль сертификата неверен.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="fileName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003178 RID: 12664 RVA: 0x000B6F24 File Offset: 0x000B5124
		public X509Certificate(string fileName, string password, X509KeyStorageFlags keyStorageFlags)
		{
			if (fileName == null)
			{
				throw new ArgumentNullException("fileName");
			}
			X509Certificate.ValidateKeyStorageFlags(keyStorageFlags);
			byte[] rawData = File.ReadAllBytes(fileName);
			using (SafePasswordHandle safePasswordHandle = new SafePasswordHandle(password))
			{
				this.impl = X509Helper.Import(rawData, safePasswordHandle, keyStorageFlags);
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> с использованием имени файла сертификата, пароля и флага хранилища ключа.</summary>
		/// <param name="fileName">Имя файла сертификата.</param>
		/// <param name="password">Пароль для доступа к данным сертификата X.509.</param>
		/// <param name="keyStorageFlags">Поразрядное сочетание значений перечисления, определяющих, где и как следует импортировать сертификат.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка сертификата. Например: 
		/// – Заданный файл сертификата не существует.  
		/// — Сертификат недействителен.  
		/// — Пароль сертификата неверен.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="fileName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003179 RID: 12665 RVA: 0x000B6F9C File Offset: 0x000B519C
		[CLSCompliant(false)]
		public X509Certificate(string fileName, SecureString password, X509KeyStorageFlags keyStorageFlags) : this()
		{
			if (fileName == null)
			{
				throw new ArgumentNullException("fileName");
			}
			X509Certificate.ValidateKeyStorageFlags(keyStorageFlags);
			byte[] rawData = File.ReadAllBytes(fileName);
			using (SafePasswordHandle safePasswordHandle = new SafePasswordHandle(password))
			{
				this.impl = X509Helper.Import(rawData, safePasswordHandle, keyStorageFlags);
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> с помощью другого класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />.</summary>
		/// <param name="cert">Класс <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />, из которого инициализируется данный класс.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка сертификата. Например: 
		/// – Заданный файл сертификата не существует.  
		/// — Сертификат недействителен.  
		/// — Пароль сертификата неверен.</exception>
		/// <exception cref="T:System.ArgumentNullException">параметр <paramref name="cert" /> имеет значение <see langword="null" />;</exception>
		// Token: 0x0600317A RID: 12666 RVA: 0x000B6FFC File Offset: 0x000B51FC
		public X509Certificate(X509Certificate cert)
		{
			if (cert == null)
			{
				throw new ArgumentNullException("cert");
			}
			this.impl = X509Helper.InitFromCertificate(cert);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> с помощью объекта <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и структуры <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, описывающий информацию о сериализации.</param>
		/// <param name="context">Структура<see cref="T:System.Runtime.Serialization.StreamingContext" />, описывающая способ выполнения сериализации.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка сертификата. Например: 
		/// – Заданный файл сертификата не существует.  
		/// — Сертификат недействителен.  
		/// — Пароль сертификата неверен.</exception>
		// Token: 0x0600317B RID: 12667 RVA: 0x000B7034 File Offset: 0x000B5234
		public X509Certificate(SerializationInfo info, StreamingContext context) : this()
		{
			throw new PlatformNotSupportedException();
		}

		/// <summary>Создает сертификат X.509v3 из заданного подписанного файла PKCS7.</summary>
		/// <param name="filename">Путь к подписанному файлу PKCS7, из которого создается сертификат X.509.</param>
		/// <returns>Созданный сертификат X.509.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="filename" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600317C RID: 12668 RVA: 0x000B7041 File Offset: 0x000B5241
		public static X509Certificate CreateFromCertFile(string filename)
		{
			return new X509Certificate(filename);
		}

		/// <summary>Создает сертификат X.509v3 из заданного подписанного файла.</summary>
		/// <param name="filename">Путь к подписанному файлу для создания сертификата X.509.</param>
		/// <returns>Созданный сертификат X.509.</returns>
		// Token: 0x0600317D RID: 12669 RVA: 0x000B7041 File Offset: 0x000B5241
		public static X509Certificate CreateFromSignedFile(string filename)
		{
			return new X509Certificate(filename);
		}

		/// <summary>Получает сведения сериализации со всеми данными, необходимыми для повторного создания экземпляра текущего объекта <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />.</summary>
		/// <param name="info">Объект, который требуется заполнить информацией о сериализации.</param>
		/// <param name="context">Контекст назначения сериализации.</param>
		// Token: 0x0600317E RID: 12670 RVA: 0x0001B98B File Offset: 0x00019B8B
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		/// <summary>Реализует интерфейс <see cref="T:System.Runtime.Serialization.ISerializable" /> и вызывается событием десериализации после завершения десериализации в ходе обратного вызова.</summary>
		/// <param name="sender">Источник события десериализации.</param>
		// Token: 0x0600317F RID: 12671 RVA: 0x0001B98B File Offset: 0x00019B8B
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			throw new PlatformNotSupportedException();
		}

		/// <summary>Получает дескриптор контекста сертификата Microsoft Cryptographic API, описанный неуправляемой структурой <see langword="PCCERT_CONTEXT" />.</summary>
		/// <returns>Структура <see cref="T:System.IntPtr" />, представляющая неуправляемую структуру <see langword="PCCERT_CONTEXT" />.</returns>
		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06003180 RID: 12672 RVA: 0x000B7049 File Offset: 0x000B5249
		public IntPtr Handle
		{
			get
			{
				if (X509Helper.IsValid(this.impl))
				{
					return this.impl.Handle;
				}
				return IntPtr.Zero;
			}
		}

		/// <summary>Получает имя центра сертификации, выдавшего сертификат X.509v3.</summary>
		/// <returns>Имя центра сертификации, выдавшего сертификат X.509v3.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Недопустимый дескриптор сертификата.</exception>
		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06003181 RID: 12673 RVA: 0x000B706C File Offset: 0x000B526C
		public string Issuer
		{
			get
			{
				this.ThrowIfInvalid();
				string text = this.lazyIssuer;
				if (text == null)
				{
					text = (this.lazyIssuer = this.Impl.Issuer);
				}
				return text;
			}
		}

		/// <summary>Возвращает различающееся имя субъекта из сертификата.</summary>
		/// <returns>Различающееся имя субъекта из сертификата.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Недопустимый дескриптор сертификата.</exception>
		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06003182 RID: 12674 RVA: 0x000B70A4 File Offset: 0x000B52A4
		public string Subject
		{
			get
			{
				this.ThrowIfInvalid();
				string text = this.lazySubject;
				if (text == null)
				{
					text = (this.lazySubject = this.Impl.Subject);
				}
				return text;
			}
		}

		/// <summary>Освобождает все ресурсы, используемые текущим объектом <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />.</summary>
		// Token: 0x06003183 RID: 12675 RVA: 0x000B70DB File Offset: 0x000B52DB
		public void Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>Освобождает все неуправляемые ресурсы, используемые объектом <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />, и при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить управляемые и неуправляемые ресурсы; значение <see langword="false" /> позволяет освободить только неуправляемые ресурсы.</param>
		// Token: 0x06003184 RID: 12676 RVA: 0x000B70E4 File Offset: 0x000B52E4
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.Reset();
			}
		}

		/// <summary>Сравнивает два объекта <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> на равенство.</summary>
		/// <param name="obj">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />, который требуется сравнить с текущим объектом.</param>
		/// <returns>Значение <see langword="true" />, если текущий объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> равен объекту, заданному параметром <paramref name="other" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06003185 RID: 12677 RVA: 0x000B70F0 File Offset: 0x000B52F0
		public override bool Equals(object obj)
		{
			X509Certificate x509Certificate = obj as X509Certificate;
			return x509Certificate != null && this.Equals(x509Certificate);
		}

		/// <summary>Сравнивает два объекта <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> на равенство.</summary>
		/// <param name="other">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />, который требуется сравнить с текущим объектом.</param>
		/// <returns>Значение <see langword="true" />, если текущий объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> равен объекту, заданному параметром <paramref name="other" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06003186 RID: 12678 RVA: 0x000B7110 File Offset: 0x000B5310
		public virtual bool Equals(X509Certificate other)
		{
			if (other == null)
			{
				return false;
			}
			if (this.Impl == null)
			{
				return other.Impl == null;
			}
			if (!this.Issuer.Equals(other.Issuer))
			{
				return false;
			}
			byte[] rawSerialNumber = this.GetRawSerialNumber();
			byte[] rawSerialNumber2 = other.GetRawSerialNumber();
			if (rawSerialNumber.Length != rawSerialNumber2.Length)
			{
				return false;
			}
			for (int i = 0; i < rawSerialNumber.Length; i++)
			{
				if (rawSerialNumber[i] != rawSerialNumber2[i])
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Экспортирует текущий объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> в массив байтов в формате, описанном одним из значений <see cref="T:System.Security.Cryptography.X509Certificates.X509ContentType" />.</summary>
		/// <param name="contentType">Одно из значений <see cref="T:System.Security.Cryptography.X509Certificates.X509ContentType" />, описывающих способы форматирования выходных данных.</param>
		/// <returns>Массив байтов, представляющий текущий объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значение, отличное от <see cref="F:System.Security.Cryptography.X509Certificates.X509ContentType.Cert" />, <see cref="F:System.Security.Cryptography.X509Certificates.X509ContentType.SerializedCert" /> или <see cref="F:System.Security.Cryptography.X509Certificates.X509ContentType.Pkcs12" />, было передано в параметр <paramref name="contentType" />.  
		/// -или- 
		/// Не удалось экспортировать сертификат.</exception>
		// Token: 0x06003187 RID: 12679 RVA: 0x000B717A File Offset: 0x000B537A
		public virtual byte[] Export(X509ContentType contentType)
		{
			return this.Export(contentType, null);
		}

		/// <summary>Экспортирует текущий объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> в массив байтов в формате, описанном одним из значений <see cref="T:System.Security.Cryptography.X509Certificates.X509ContentType" />, с использованием заданного пароля.</summary>
		/// <param name="contentType">Одно из значений <see cref="T:System.Security.Cryptography.X509Certificates.X509ContentType" />, описывающих способы форматирования выходных данных.</param>
		/// <param name="password">Пароль для доступа к данным сертификата X.509.</param>
		/// <returns>Массив байтов, представляющий текущий объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значение, отличное от <see cref="F:System.Security.Cryptography.X509Certificates.X509ContentType.Cert" />, <see cref="F:System.Security.Cryptography.X509Certificates.X509ContentType.SerializedCert" /> или <see cref="F:System.Security.Cryptography.X509Certificates.X509ContentType.Pkcs12" />, было передано в параметр <paramref name="contentType" />.  
		/// -или- 
		/// Не удалось экспортировать сертификат.</exception>
		// Token: 0x06003188 RID: 12680 RVA: 0x000B7184 File Offset: 0x000B5384
		public virtual byte[] Export(X509ContentType contentType, string password)
		{
			this.VerifyContentType(contentType);
			if (this.Impl == null)
			{
				throw new CryptographicException(-2147467261);
			}
			byte[] result;
			using (SafePasswordHandle safePasswordHandle = new SafePasswordHandle(password))
			{
				result = this.Impl.Export(contentType, safePasswordHandle);
			}
			return result;
		}

		/// <summary>Экспортирует текущий объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> в массив байтов с использованием заданных формата и пароля.</summary>
		/// <param name="contentType">Одно из значений <see cref="T:System.Security.Cryptography.X509Certificates.X509ContentType" />, описывающих способы форматирования выходных данных.</param>
		/// <param name="password">Пароль для доступа к данным сертификата X.509.</param>
		/// <returns>Массив байтов, представляющий текущий объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значение, отличное от <see cref="F:System.Security.Cryptography.X509Certificates.X509ContentType.Cert" />, <see cref="F:System.Security.Cryptography.X509Certificates.X509ContentType.SerializedCert" /> или <see cref="F:System.Security.Cryptography.X509Certificates.X509ContentType.Pkcs12" />, было передано в параметр <paramref name="contentType" />.  
		/// -или- 
		/// Не удалось экспортировать сертификат.</exception>
		// Token: 0x06003189 RID: 12681 RVA: 0x000B71E0 File Offset: 0x000B53E0
		[CLSCompliant(false)]
		public virtual byte[] Export(X509ContentType contentType, SecureString password)
		{
			this.VerifyContentType(contentType);
			if (this.Impl == null)
			{
				throw new CryptographicException(-2147467261);
			}
			byte[] result;
			using (SafePasswordHandle safePasswordHandle = new SafePasswordHandle(password))
			{
				result = this.Impl.Export(contentType, safePasswordHandle);
			}
			return result;
		}

		/// <summary>Возвращает необработанные данные для всего сертификата X.509v3 в виде шестнадцатеричной строки.</summary>
		/// <returns>Данные сертификата X.509 в виде шестнадцатеричной строки.</returns>
		// Token: 0x0600318A RID: 12682 RVA: 0x000B723C File Offset: 0x000B543C
		public virtual string GetRawCertDataString()
		{
			this.ThrowIfInvalid();
			return this.GetRawCertData().ToHexStringUpper();
		}

		/// <summary>Возвращает хэш-значение для сертификата X.509v3 в виде массива байтов.</summary>
		/// <returns>Хэш-значение для сертификата X.509.</returns>
		// Token: 0x0600318B RID: 12683 RVA: 0x000B724F File Offset: 0x000B544F
		public virtual byte[] GetCertHash()
		{
			this.ThrowIfInvalid();
			return this.GetRawCertHash().CloneByteArray();
		}

		/// <summary>Возвращает хэш-значение для сертификата X.509v3, который вычисляется с помощью указанного криптографического хэш-алгоритма.</summary>
		/// <param name="hashAlgorithm">Имя используемого криптографического хэш-алгоритма.</param>
		/// <returns>Массив байтов, содержащий хэш-значение для сертификата X.509.</returns>
		// Token: 0x0600318C RID: 12684 RVA: 0x0001B98B File Offset: 0x00019B8B
		public virtual byte[] GetCertHash(HashAlgorithmName hashAlgorithm)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600318D RID: 12685 RVA: 0x0001B98B File Offset: 0x00019B8B
		public virtual bool TryGetCertHash(HashAlgorithmName hashAlgorithm, Span<byte> destination, out int bytesWritten)
		{
			throw new PlatformNotSupportedException();
		}

		/// <summary>Возвращает хэш-значение SHA1 для сертификата X.509v3 в виде шестнадцатеричной строки.</summary>
		/// <returns>Представление шестнадцатеричной строки хэш-значения сертификата X.509.</returns>
		// Token: 0x0600318E RID: 12686 RVA: 0x000B7262 File Offset: 0x000B5462
		public virtual string GetCertHashString()
		{
			this.ThrowIfInvalid();
			return this.GetRawCertHash().ToHexStringUpper();
		}

		/// <summary>Возвращает шестнадцатеричную строку, содержащую хэш-значение для сертификата X.509v3, который вычисляется с помощью указанного криптографического хэш-алгоритма.</summary>
		/// <param name="hashAlgorithm">Имя используемого криптографического хэш-алгоритма.</param>
		/// <returns>Представление шестнадцатеричной строки хэш-значения сертификата X.509.</returns>
		// Token: 0x0600318F RID: 12687 RVA: 0x000B7275 File Offset: 0x000B5475
		public virtual string GetCertHashString(HashAlgorithmName hashAlgorithm)
		{
			this.ThrowIfInvalid();
			return this.GetCertHash(hashAlgorithm).ToHexStringUpper();
		}

		// Token: 0x06003190 RID: 12688 RVA: 0x000B728C File Offset: 0x000B548C
		private byte[] GetRawCertHash()
		{
			byte[] result;
			if ((result = this.lazyCertHash) == null)
			{
				result = (this.lazyCertHash = this.Impl.Thumbprint);
			}
			return result;
		}

		/// <summary>Возвращает дату вступления в силу сертификата X.509v3.</summary>
		/// <returns>Дата вступления в силу сертификата X.509.</returns>
		// Token: 0x06003191 RID: 12689 RVA: 0x000B72BC File Offset: 0x000B54BC
		public virtual string GetEffectiveDateString()
		{
			return this.GetNotBefore().ToString();
		}

		/// <summary>Возвращает срок действия сертификата X.509v3.</summary>
		/// <returns>Срок действия сертификата X.509.</returns>
		// Token: 0x06003192 RID: 12690 RVA: 0x000B72D8 File Offset: 0x000B54D8
		public virtual string GetExpirationDateString()
		{
			return this.GetNotAfter().ToString();
		}

		/// <summary>Возвращает имя формата сертификата X.509v3.</summary>
		/// <returns>Формат сертификата X.509.</returns>
		// Token: 0x06003193 RID: 12691 RVA: 0x000B72F3 File Offset: 0x000B54F3
		public virtual string GetFormat()
		{
			return "X509";
		}

		/// <summary>Возвращает открытый ключ для сертификата X.509v3 в виде шестнадцатеричной строки.</summary>
		/// <returns>Открытый ключ для сертификата X.509 в виде шестнадцатеричной строки.</returns>
		// Token: 0x06003194 RID: 12692 RVA: 0x000B72FA File Offset: 0x000B54FA
		public virtual string GetPublicKeyString()
		{
			return this.GetPublicKey().ToHexStringUpper();
		}

		/// <summary>Возвращает необработанные данные для всего сертификата X.509v3 в виде массива байтов.</summary>
		/// <returns>Массив байтов, содержащий данные сертификата X.509.</returns>
		// Token: 0x06003195 RID: 12693 RVA: 0x000B7307 File Offset: 0x000B5507
		public virtual byte[] GetRawCertData()
		{
			this.ThrowIfInvalid();
			return this.Impl.RawData.CloneByteArray();
		}

		/// <summary>Возвращает хэш-код для сертификата X.509v3 в виде целого числа.</summary>
		/// <returns>Хэш-код для сертификата X.509 в виде целого числа.</returns>
		// Token: 0x06003196 RID: 12694 RVA: 0x000B7320 File Offset: 0x000B5520
		public override int GetHashCode()
		{
			if (this.Impl == null)
			{
				return 0;
			}
			byte[] rawCertHash = this.GetRawCertHash();
			int num = 0;
			int num2 = 0;
			while (num2 < rawCertHash.Length && num2 < 4)
			{
				num = (num << 8 | (int)rawCertHash[num2]);
				num2++;
			}
			return num;
		}

		/// <summary>Возвращает сведения об алгоритме ключа для сертификата X.509v3 в виде строки.</summary>
		/// <returns>Сведения об алгоритме ключа для сертификата X.509 в виде строки.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Недопустимый контекст сертификата.</exception>
		// Token: 0x06003197 RID: 12695 RVA: 0x000B735C File Offset: 0x000B555C
		public virtual string GetKeyAlgorithm()
		{
			this.ThrowIfInvalid();
			string text = this.lazyKeyAlgorithm;
			if (text == null)
			{
				text = (this.lazyKeyAlgorithm = this.Impl.KeyAlgorithm);
			}
			return text;
		}

		/// <summary>Возвращает параметры алгоритма ключа для сертификата X.509v3 в виде массива байтов.</summary>
		/// <returns>Параметры алгоритма ключа для сертификата X.509 в виде массива байтов.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Недопустимый контекст сертификата.</exception>
		// Token: 0x06003198 RID: 12696 RVA: 0x000B7394 File Offset: 0x000B5594
		public virtual byte[] GetKeyAlgorithmParameters()
		{
			this.ThrowIfInvalid();
			byte[] array = this.lazyKeyAlgorithmParameters;
			if (array == null)
			{
				array = (this.lazyKeyAlgorithmParameters = this.Impl.KeyAlgorithmParameters);
			}
			return array.CloneByteArray();
		}

		/// <summary>Возвращает параметры алгоритма ключа для сертификата X.509v3 в виде шестнадцатеричной строки.</summary>
		/// <returns>Параметры алгоритма ключа для сертификата X.509 в виде шестнадцатеричной строки.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Недопустимый контекст сертификата.</exception>
		// Token: 0x06003199 RID: 12697 RVA: 0x000B73D0 File Offset: 0x000B55D0
		public virtual string GetKeyAlgorithmParametersString()
		{
			this.ThrowIfInvalid();
			return this.GetKeyAlgorithmParameters().ToHexStringUpper();
		}

		/// <summary>Возвращает открытый ключ для сертификата X.509v3 в виде массива байтов.</summary>
		/// <returns>Открытый ключ для сертификата X.509 в виде массива байтов.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Недопустимый контекст сертификата.</exception>
		// Token: 0x0600319A RID: 12698 RVA: 0x000B73E4 File Offset: 0x000B55E4
		public virtual byte[] GetPublicKey()
		{
			this.ThrowIfInvalid();
			byte[] array = this.lazyPublicKey;
			if (array == null)
			{
				array = (this.lazyPublicKey = this.Impl.PublicKeyValue);
			}
			return array.CloneByteArray();
		}

		/// <summary>Возвращает серийный номер сертификата X.509v3 в виде массива байтов в прямом порядке.</summary>
		/// <returns>Серийный номер сертификата X.509 в виде массива байтов в прямом порядке.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Недопустимый контекст сертификата.</exception>
		// Token: 0x0600319B RID: 12699 RVA: 0x000B7420 File Offset: 0x000B5620
		public virtual byte[] GetSerialNumber()
		{
			this.ThrowIfInvalid();
			byte[] array = this.GetRawSerialNumber().CloneByteArray();
			Array.Reverse<byte>(array);
			return array;
		}

		/// <summary>Возвращает серийный номер сертификата X.509v3 в виде шестнадцатеричной строки в прямом порядке.</summary>
		/// <returns>Серийный номер сертификата X.509 в виде шестнадцатеричной строки в прямом порядке.</returns>
		// Token: 0x0600319C RID: 12700 RVA: 0x000B7439 File Offset: 0x000B5639
		public virtual string GetSerialNumberString()
		{
			this.ThrowIfInvalid();
			return this.GetRawSerialNumber().ToHexStringUpper();
		}

		// Token: 0x0600319D RID: 12701 RVA: 0x000B744C File Offset: 0x000B564C
		private byte[] GetRawSerialNumber()
		{
			byte[] result;
			if ((result = this.lazySerialNumber) == null)
			{
				result = (this.lazySerialNumber = this.Impl.SerialNumber);
			}
			return result;
		}

		/// <summary>Возвращает имя участника, которому выдан сертификат.</summary>
		/// <returns>Имя участника, которому выдан сертификат.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Недопустимый контекст сертификата.</exception>
		// Token: 0x0600319E RID: 12702 RVA: 0x000B747B File Offset: 0x000B567B
		[Obsolete("This method has been deprecated.  Please use the Subject property instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
		public virtual string GetName()
		{
			this.ThrowIfInvalid();
			return this.Impl.LegacySubject;
		}

		/// <summary>Возвращает имя центра сертификации, выдавшего сертификат X.509v3.</summary>
		/// <returns>Имя центра сертификации, выдавшего сертификат X.509.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Произошла ошибка сертификата. Например: 
		/// – Заданный файл сертификата не существует.  
		/// — Сертификат недействителен.  
		/// — Пароль сертификата неверен.</exception>
		// Token: 0x0600319F RID: 12703 RVA: 0x000B748E File Offset: 0x000B568E
		[Obsolete("This method has been deprecated.  Please use the Issuer property instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
		public virtual string GetIssuerName()
		{
			this.ThrowIfInvalid();
			return this.Impl.LegacyIssuer;
		}

		/// <summary>Возвращает строковое представление текущего объекта <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />.</summary>
		/// <returns>Строковое представление текущего объекта <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />.</returns>
		// Token: 0x060031A0 RID: 12704 RVA: 0x000B74A1 File Offset: 0x000B56A1
		public override string ToString()
		{
			return this.ToString(false);
		}

		/// <summary>Возвращает строковое представление текущего объекта <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> с дополнительными сведениями, если заданы.</summary>
		/// <param name="fVerbose">Значение <see langword="true" /> для создания подробной формы строкового представления; в противном случае — <see langword="false" />.</param>
		/// <returns>Строковое представление текущего объекта <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" />.</returns>
		// Token: 0x060031A1 RID: 12705 RVA: 0x000B74AC File Offset: 0x000B56AC
		public virtual string ToString(bool fVerbose)
		{
			if (!fVerbose || !X509Helper.IsValid(this.impl))
			{
				return base.ToString();
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("[Subject]");
			stringBuilder.Append("  ");
			stringBuilder.AppendLine(this.Subject);
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("[Issuer]");
			stringBuilder.Append("  ");
			stringBuilder.AppendLine(this.Issuer);
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("[Serial Number]");
			stringBuilder.Append("  ");
			byte[] serialNumber = this.GetSerialNumber();
			Array.Reverse<byte>(serialNumber);
			stringBuilder.Append(serialNumber.ToHexArrayUpper());
			stringBuilder.AppendLine();
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("[Not Before]");
			stringBuilder.Append("  ");
			stringBuilder.AppendLine(X509Certificate.FormatDate(this.GetNotBefore()));
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("[Not After]");
			stringBuilder.Append("  ");
			stringBuilder.AppendLine(X509Certificate.FormatDate(this.GetNotAfter()));
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("[Thumbprint]");
			stringBuilder.Append("  ");
			stringBuilder.Append(this.GetRawCertHash().ToHexArrayUpper());
			stringBuilder.AppendLine();
			return stringBuilder.ToString();
		}

		/// <summary>Заполняет объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> данными из массива байтов.</summary>
		/// <param name="rawData">Массив байтов, содержащий данные сертификата X.509.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="rawData" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Длина параметра <paramref name="rawData" /> равна 0.</exception>
		// Token: 0x060031A2 RID: 12706 RVA: 0x000B7605 File Offset: 0x000B5805
		[ComVisible(false)]
		public virtual void Import(byte[] rawData)
		{
			throw new PlatformNotSupportedException("X509Certificate is immutable on this platform. Use the equivalent constructor instead.");
		}

		/// <summary>Заполняет объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> с помощью данных из массива байтов, пароля и флагов, чтобы определить способ импорта закрытого ключа.</summary>
		/// <param name="rawData">Массив байтов, содержащий данные сертификата X.509.</param>
		/// <param name="password">Пароль для доступа к данным сертификата X.509.</param>
		/// <param name="keyStorageFlags">Поразрядное сочетание значений перечисления, определяющих, где и как следует импортировать сертификат.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="rawData" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Длина параметра <paramref name="rawData" /> равна 0.</exception>
		// Token: 0x060031A3 RID: 12707 RVA: 0x000B7605 File Offset: 0x000B5805
		[ComVisible(false)]
		public virtual void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags)
		{
			throw new PlatformNotSupportedException("X509Certificate is immutable on this platform. Use the equivalent constructor instead.");
		}

		/// <summary>Заполняет объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> с помощью данных из массива данных, пароля и флага хранилища ключа.</summary>
		/// <param name="rawData">Массив байтов, содержащий данные из сертификата X.509.</param>
		/// <param name="password">Пароль для доступа к данным сертификата X.509.</param>
		/// <param name="keyStorageFlags">Поразрядное сочетание значений перечисления, определяющих, где и как следует импортировать сертификат.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="rawData" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Длина параметра <paramref name="rawData" /> равна 0.</exception>
		// Token: 0x060031A4 RID: 12708 RVA: 0x000B7605 File Offset: 0x000B5805
		public virtual void Import(byte[] rawData, SecureString password, X509KeyStorageFlags keyStorageFlags)
		{
			throw new PlatformNotSupportedException("X509Certificate is immutable on this platform. Use the equivalent constructor instead.");
		}

		/// <summary>Заполняет объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> сведениями из файла сертификата.</summary>
		/// <param name="fileName">Имя файла сертификата, представленное в виде строки.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="fileName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060031A5 RID: 12709 RVA: 0x000B7605 File Offset: 0x000B5805
		[ComVisible(false)]
		public virtual void Import(string fileName)
		{
			throw new PlatformNotSupportedException("X509Certificate is immutable on this platform. Use the equivalent constructor instead.");
		}

		/// <summary>Заполняет объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> сведениями из файла сертификата, паролем и значением <see cref="T:System.Security.Cryptography.X509Certificates.X509KeyStorageFlags" />.</summary>
		/// <param name="fileName">Имя файла сертификата, представленное в виде строки.</param>
		/// <param name="password">Пароль для доступа к данным сертификата X.509.</param>
		/// <param name="keyStorageFlags">Поразрядное сочетание значений перечисления, определяющих, где и как следует импортировать сертификат.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="fileName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060031A6 RID: 12710 RVA: 0x000B7605 File Offset: 0x000B5805
		[ComVisible(false)]
		public virtual void Import(string fileName, string password, X509KeyStorageFlags keyStorageFlags)
		{
			throw new PlatformNotSupportedException("X509Certificate is immutable on this platform. Use the equivalent constructor instead.");
		}

		/// <summary>Заполняет объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> сведениями из файла сертификата, паролем и флагом хранилища ключа.</summary>
		/// <param name="fileName">Имя файла сертификата.</param>
		/// <param name="password">Пароль для доступа к данным сертификата X.509.</param>
		/// <param name="keyStorageFlags">Поразрядное сочетание значений перечисления, определяющих, где и как следует импортировать сертификат.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="fileName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060031A7 RID: 12711 RVA: 0x000B7605 File Offset: 0x000B5805
		public virtual void Import(string fileName, SecureString password, X509KeyStorageFlags keyStorageFlags)
		{
			throw new PlatformNotSupportedException("X509Certificate is immutable on this platform. Use the equivalent constructor instead.");
		}

		// Token: 0x060031A8 RID: 12712 RVA: 0x000B7614 File Offset: 0x000B5814
		internal DateTime GetNotAfter()
		{
			this.ThrowIfInvalid();
			DateTime dateTime = this.lazyNotAfter;
			if (dateTime == DateTime.MinValue)
			{
				dateTime = (this.lazyNotAfter = this.impl.NotAfter);
			}
			return dateTime;
		}

		// Token: 0x060031A9 RID: 12713 RVA: 0x000B7654 File Offset: 0x000B5854
		internal DateTime GetNotBefore()
		{
			this.ThrowIfInvalid();
			DateTime dateTime = this.lazyNotBefore;
			if (dateTime == DateTime.MinValue)
			{
				dateTime = (this.lazyNotBefore = this.impl.NotBefore);
			}
			return dateTime;
		}

		/// <summary>Преобразует указанные дату и время в строку.</summary>
		/// <param name="date">Преобразовываемые дата и время.</param>
		/// <returns>Строка, представляющая значение объекта <see cref="T:System.DateTime" />.</returns>
		// Token: 0x060031AA RID: 12714 RVA: 0x000B7694 File Offset: 0x000B5894
		protected static string FormatDate(DateTime date)
		{
			CultureInfo cultureInfo = CultureInfo.CurrentCulture;
			if (!cultureInfo.DateTimeFormat.Calendar.IsValidDay(date.Year, date.Month, date.Day, 0))
			{
				if (cultureInfo.DateTimeFormat.Calendar is UmAlQuraCalendar)
				{
					cultureInfo = (cultureInfo.Clone() as CultureInfo);
					cultureInfo.DateTimeFormat.Calendar = new HijriCalendar();
				}
				else
				{
					cultureInfo = CultureInfo.InvariantCulture;
				}
			}
			return date.ToString(cultureInfo);
		}

		// Token: 0x060031AB RID: 12715 RVA: 0x000B7710 File Offset: 0x000B5910
		internal static void ValidateKeyStorageFlags(X509KeyStorageFlags keyStorageFlags)
		{
			if ((keyStorageFlags & ~(X509KeyStorageFlags.UserKeySet | X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.Exportable | X509KeyStorageFlags.UserProtected | X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.EphemeralKeySet)) != X509KeyStorageFlags.DefaultKeySet)
			{
				throw new ArgumentException("Value of flags is invalid.", "keyStorageFlags");
			}
			X509KeyStorageFlags x509KeyStorageFlags = keyStorageFlags & (X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.EphemeralKeySet);
			if (x509KeyStorageFlags == (X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.EphemeralKeySet))
			{
				throw new ArgumentException(SR.Format("The flags '{0}' may not be specified together.", x509KeyStorageFlags), "keyStorageFlags");
			}
		}

		// Token: 0x060031AC RID: 12716 RVA: 0x000B7758 File Offset: 0x000B5958
		private void VerifyContentType(X509ContentType contentType)
		{
			if (contentType != X509ContentType.Cert && contentType != X509ContentType.SerializedCert && contentType != X509ContentType.Pfx)
			{
				throw new CryptographicException("Invalid content type.");
			}
		}

		// Token: 0x060031AD RID: 12717 RVA: 0x000B7771 File Offset: 0x000B5971
		internal void ImportHandle(X509CertificateImpl impl)
		{
			this.Reset();
			this.impl = impl;
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x060031AE RID: 12718 RVA: 0x000B7780 File Offset: 0x000B5980
		internal X509CertificateImpl Impl
		{
			get
			{
				return this.impl;
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x060031AF RID: 12719 RVA: 0x000B7788 File Offset: 0x000B5988
		internal bool IsValid
		{
			get
			{
				return X509Helper.IsValid(this.impl);
			}
		}

		// Token: 0x060031B0 RID: 12720 RVA: 0x000B7795 File Offset: 0x000B5995
		internal void ThrowIfInvalid()
		{
			X509Helper.ThrowIfContextInvalid(this.impl);
		}

		// Token: 0x04002298 RID: 8856
		private X509CertificateImpl impl;

		// Token: 0x04002299 RID: 8857
		private volatile byte[] lazyCertHash;

		// Token: 0x0400229A RID: 8858
		private volatile byte[] lazySerialNumber;

		// Token: 0x0400229B RID: 8859
		private volatile string lazyIssuer;

		// Token: 0x0400229C RID: 8860
		private volatile string lazySubject;

		// Token: 0x0400229D RID: 8861
		private volatile string lazyKeyAlgorithm;

		// Token: 0x0400229E RID: 8862
		private volatile byte[] lazyKeyAlgorithmParameters;

		// Token: 0x0400229F RID: 8863
		private volatile byte[] lazyPublicKey;

		// Token: 0x040022A0 RID: 8864
		private DateTime lazyNotBefore = DateTime.MinValue;

		// Token: 0x040022A1 RID: 8865
		private DateTime lazyNotAfter = DateTime.MinValue;

		// Token: 0x040022A2 RID: 8866
		internal const X509KeyStorageFlags KeyStorageFlagsAll = X509KeyStorageFlags.UserKeySet | X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.Exportable | X509KeyStorageFlags.UserProtected | X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.EphemeralKeySet;
	}
}
