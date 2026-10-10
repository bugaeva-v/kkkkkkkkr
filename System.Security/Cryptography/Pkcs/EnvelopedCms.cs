using System;
using System.Security.Cryptography.X509Certificates;
using Internal.Cryptography;

namespace System.Security.Cryptography.Pkcs
{
	/// <summary>Класс <see cref="T:System.Security.Cryptography.Pkcs.EnvelopedCms" /> представляет структуру CMS/PKCS 7 для запечатанных данных.</summary>
	// Token: 0x02000075 RID: 117
	public sealed class EnvelopedCms
	{
		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.EnvelopedCms.#ctor" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.EnvelopedCms" />.</summary>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		// Token: 0x060003CF RID: 975 RVA: 0x00012294 File Offset: 0x00010494
		public EnvelopedCms() : this(new ContentInfo(Array.Empty<byte>()))
		{
		}

		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.EnvelopedCms.#ctor(System.Security.Cryptography.Pkcs.ContentInfo)" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.EnvelopedCms" />, используя в качестве типа внутреннего содержимого указанную информацию о содержимом.</summary>
		/// <param name="contentInfo">Экземпляр класса <see cref="P:System.Security.Cryptography.Pkcs.EnvelopedCms.ContentInfo" />, представляющий содержимое и его тип.</param>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		// Token: 0x060003D0 RID: 976 RVA: 0x000122A6 File Offset: 0x000104A6
		public EnvelopedCms(ContentInfo contentInfo) : this(contentInfo, new AlgorithmIdentifier(Oid.FromOidValue("1.2.840.113549.3.7", OidGroup.EncryptionAlgorithm)))
		{
		}

		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.EnvelopedCms.#ctor(System.Security.Cryptography.Pkcs.ContentInfo,System.Security.Cryptography.Pkcs.AlgorithmIdentifier)" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.EnvelopedCms" />, используя указанную информацию о содержимом и алгоритм шифрования. Указанная информация о содержимом используется в качестве типа внутреннего содержимого.</summary>
		/// <param name="contentInfo">Объект <see cref="T:System.Security.Cryptography.Pkcs.ContentInfo" />, представляющий содержимое и его тип.</param>
		/// <param name="encryptionAlgorithm">Объект <see cref="T:System.Security.Cryptography.Pkcs.AlgorithmIdentifier" />, определяющий алгоритм шифрования.</param>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		// Token: 0x060003D1 RID: 977 RVA: 0x000122C0 File Offset: 0x000104C0
		public EnvelopedCms(ContentInfo contentInfo, AlgorithmIdentifier encryptionAlgorithm)
		{
			if (contentInfo == null)
			{
				throw new ArgumentNullException("contentInfo");
			}
			if (encryptionAlgorithm == null)
			{
				throw new ArgumentNullException("encryptionAlgorithm");
			}
			this.Version = 0;
			this.ContentInfo = contentInfo;
			this.ContentEncryptionAlgorithm = encryptionAlgorithm;
			this.Certificates = new X509Certificate2Collection();
			this.UnprotectedAttributes = new CryptographicAttributeObjectCollection();
			this._decryptorPal = null;
			this._lastCall = EnvelopedCms.LastCall.Ctor;
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.EnvelopedCms.Version" /> возвращает версию запечатанного сообщения CMS/PKCS 7.</summary>
		/// <returns>Целочисленное значение, представляющее версию запечатанного сообщения CMS/PKCS #7.</returns>
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00012328 File Offset: 0x00010528
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x00012330 File Offset: 0x00010530
		public int Version { get; private set; }

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.EnvelopedCms.ContentInfo" /> возвращает информацию о внутреннем содержимом запечатанного сообщения CMS/PKCS 7.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Pkcs.ContentInfo" />, который представляет информацию о внутреннем содержимом запечатанного сообщения CMS/PKCS 7.</returns>
		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00012339 File Offset: 0x00010539
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x00012341 File Offset: 0x00010541
		public ContentInfo ContentInfo { get; private set; }

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.EnvelopedCms.ContentEncryptionAlgorithm" /> возвращает идентификатор алгоритма, с помощью которого шифруется содержимое.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Pkcs.AlgorithmIdentifier" />, представляющий идентификатор алгоритма.</returns>
		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x0001234A File Offset: 0x0001054A
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x00012352 File Offset: 0x00010552
		public AlgorithmIdentifier ContentEncryptionAlgorithm { get; private set; }

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.EnvelopedCms.Certificates" /> возвращает набор сертификатов, связанных с запечатанным сообщением CMS/PKCS 7.</summary>
		/// <returns>Коллекция <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />, которая представляет сертификаты X.509, используемые для запечатанного сообщения CMS/PKCS 7. Если сертификата не существует, значением свойства является пустая коллекция.</returns>
		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x0001235B File Offset: 0x0001055B
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x00012363 File Offset: 0x00010563
		public X509Certificate2Collection Certificates { get; private set; }

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.EnvelopedCms.UnprotectedAttributes" /> возвращает незащищенные (незашифрованные) атрибуты, связанные с запечатанным сообщением CMS/PKCS 7. Незащищенные атрибуты не шифруются, поэтому их конфиденциальность в объекте <see cref="T:System.Security.Cryptography.Pkcs.EnvelopedCms" /> не обеспечивается.</summary>
		/// <returns>Коллекция <see cref="T:System.Security.Cryptography.CryptographicAttributeObjectCollection" />, представляющая незащищенные атрибуты. Если незащищенных атрибутов не существует, значением свойства является пустая коллекция.</returns>
		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060003DA RID: 986 RVA: 0x0001236C File Offset: 0x0001056C
		// (set) Token: 0x060003DB RID: 987 RVA: 0x00012374 File Offset: 0x00010574
		public CryptographicAttributeObjectCollection UnprotectedAttributes { get; private set; }

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.EnvelopedCms.RecipientInfos" /> возвращает информацию о получателе, связанную с запечатанным сообщением CMS/PKCS 7.</summary>
		/// <returns>Коллекция <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfoCollection" />, представляющая информацию о получателе. Если получателя не существует, значением свойства является пустая коллекция.</returns>
		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00012380 File Offset: 0x00010580
		public RecipientInfoCollection RecipientInfos
		{
			get
			{
				switch (this._lastCall)
				{
				case EnvelopedCms.LastCall.Ctor:
					return new RecipientInfoCollection();
				case EnvelopedCms.LastCall.Encrypt:
					throw PkcsPal.Instance.CreateRecipientInfosAfterEncryptException();
				case EnvelopedCms.LastCall.Decode:
				case EnvelopedCms.LastCall.Decrypt:
					return this._decryptorPal.RecipientInfos;
				default:
					throw new InvalidOperationException();
				}
			}
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.EnvelopedCms.Encrypt(System.Security.Cryptography.Pkcs.CmsRecipient)" /> зашифровывает содержимое сообщения CMS/PKCS 7, используя указанную информацию о получателе.</summary>
		/// <param name="recipient">Объект <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipient" />, представляющий информацию о получателе.</param>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Завершение операции шифрования невозможно.</exception>
		// Token: 0x060003DD RID: 989 RVA: 0x000123D0 File Offset: 0x000105D0
		public void Encrypt(CmsRecipient recipient)
		{
			if (recipient == null)
			{
				throw new ArgumentNullException("recipient");
			}
			this.Encrypt(new CmsRecipientCollection(recipient));
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.EnvelopedCms.Encrypt(System.Security.Cryptography.Pkcs.CmsRecipientCollection)" /> зашифровывает содержимое сообщения CMS/PKCS 7, используя информацию об указанном списке получателей. Сообщение шифруется с помощью ключа шифрования сообщения с симметричным алгоритмом шифрования, таким как Triple DES. В этом случае ключ шифрования сообщения шифруется с помощью открытого ключа каждого из получателей.</summary>
		/// <param name="recipients">Коллекция <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipientCollection" />, представляющая информацию о списке получателей.</param>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Завершение операции шифрования невозможно.</exception>
		// Token: 0x060003DE RID: 990 RVA: 0x000123EC File Offset: 0x000105EC
		public void Encrypt(CmsRecipientCollection recipients)
		{
			if (recipients == null)
			{
				throw new ArgumentNullException("recipients");
			}
			if (recipients.Count == 0)
			{
				throw new PlatformNotSupportedException("The recipients collection is empty. You must specify at least one recipient. This platform does not implement the certificate picker UI.");
			}
			if (this._decryptorPal != null)
			{
				this._decryptorPal.Dispose();
				this._decryptorPal = null;
			}
			this._encodedMessage = PkcsPal.Instance.Encrypt(recipients, this.ContentInfo, this.ContentEncryptionAlgorithm, this.Certificates, this.UnprotectedAttributes);
			this._lastCall = EnvelopedCms.LastCall.Encrypt;
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.EnvelopedCms.Encode" /> кодирует содержимого запечатанного сообщения CMS/PKCS 7 и возвращает его в виде массива байтовых значений. Шифрование необходимо выполнить до кодирования.</summary>
		/// <returns>В случае успешного выполнения метода он возвращает массив байтовых значений, представляющих закодированную информацию.  
		/// При сбое метода создается исключение.</returns>
		/// <exception cref="T:System.InvalidOperationException">Вызов метода был недопустим для текущего состояния объекта.</exception>
		// Token: 0x060003DF RID: 991 RVA: 0x00012464 File Offset: 0x00010664
		public byte[] Encode()
		{
			if (this._encodedMessage == null)
			{
				throw new InvalidOperationException("The CMS message is not encrypted.");
			}
			return this._encodedMessage.CloneByteArray();
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.EnvelopedCms.Decode(System.Byte[])" /> раскодирует указанное запечатанное сообщение CMS/PKCS 7 и переопределяет значения всех переменных-членов объекта <see cref="T:System.Security.Cryptography.Pkcs.EnvelopedCms" />.</summary>
		/// <param name="encodedMessage">Массив байтовых значений, представляющий информацию, которую требуется раскодировать.</param>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		// Token: 0x060003E0 RID: 992 RVA: 0x00012484 File Offset: 0x00010684
		public void Decode(byte[] encodedMessage)
		{
			if (encodedMessage == null)
			{
				throw new ArgumentNullException("encodedMessage");
			}
			if (this._decryptorPal != null)
			{
				this._decryptorPal.Dispose();
				this._decryptorPal = null;
			}
			int version;
			ContentInfo contentInfo;
			AlgorithmIdentifier contentEncryptionAlgorithm;
			X509Certificate2Collection certificates;
			CryptographicAttributeObjectCollection unprotectedAttributes;
			this._decryptorPal = PkcsPal.Instance.Decode(encodedMessage, out version, out contentInfo, out contentEncryptionAlgorithm, out certificates, out unprotectedAttributes);
			this.Version = version;
			this.ContentInfo = contentInfo;
			this.ContentEncryptionAlgorithm = contentEncryptionAlgorithm;
			this.Certificates = certificates;
			this.UnprotectedAttributes = unprotectedAttributes;
			this._encodedMessage = contentInfo.Content.CloneByteArray();
			this._lastCall = EnvelopedCms.LastCall.Decode;
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.EnvelopedCms.Decrypt" /> расшифровывает содержимое раскодированного запечатанного сообщения CMS/PKCS 7. Метод <see cref="M:System.Security.Cryptography.Pkcs.EnvelopedCms.Decrypt" /> выполняет поиск подходящего сертификата и закрытого ключа в хранилищах MY текущего пользователя и компьютера.</summary>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Завершение операции шифрования невозможно.</exception>
		/// <exception cref="T:System.InvalidOperationException">Вызов метода был недопустим для текущего состояния объекта.</exception>
		// Token: 0x060003E1 RID: 993 RVA: 0x00012510 File Offset: 0x00010710
		public void Decrypt()
		{
			this.DecryptContent(this.RecipientInfos, null);
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.EnvelopedCms.Decrypt(System.Security.Cryptography.Pkcs.RecipientInfo)" /> расшифровывает содержимое раскодированного запечатанного сообщения CMS/PKCS 7, используя закрытый ключ, связанный с сертификатом, который определяется указанной информацией о получателе.</summary>
		/// <param name="recipientInfo">Объект <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfo" />, представляющий информацию о получателе, которая определяет сертификат, связанный с закрытым ключом, который должен использоваться для расшифровки.</param>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Завершение операции шифрования невозможно.</exception>
		/// <exception cref="T:System.InvalidOperationException">Вызов метода был недопустим для текущего состояния объекта.</exception>
		// Token: 0x060003E2 RID: 994 RVA: 0x0001251F File Offset: 0x0001071F
		public void Decrypt(RecipientInfo recipientInfo)
		{
			if (recipientInfo == null)
			{
				throw new ArgumentNullException("recipientInfo");
			}
			this.DecryptContent(new RecipientInfoCollection(recipientInfo), null);
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.EnvelopedCms.Decrypt(System.Security.Cryptography.Pkcs.RecipientInfo,System.Security.Cryptography.X509Certificates.X509Certificate2Collection)" /> расшифровывает содержимое раскодированного запечатанного сообщения CMS/PKCS 7, используя закрытый ключ, связанный с сертификатом, который определяется указанной информацией о получателе, и используя указанную коллекцию сертификатов.  Метод <see cref="M:System.Security.Cryptography.Pkcs.EnvelopedCms.Decrypt(System.Security.Cryptography.Pkcs.RecipientInfo,System.Security.Cryptography.X509Certificates.X509Certificate2Collection)" /> выполняет поиск подходящего для расшифровки сертификата в указанной коллекции сертификатов и в хранилище сертификатов MY.</summary>
		/// <param name="recipientInfo">Объект <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfo" />, представляющий информацию о получателе для использования при расшифровке.</param>
		/// <param name="extraStore">Коллекция <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />, представляющая дополнительные сертификаты для использования при расшифровке. Метод <see cref="M:System.Security.Cryptography.Pkcs.EnvelopedCms.Decrypt(System.Security.Cryptography.Pkcs.RecipientInfo,System.Security.Cryptography.X509Certificates.X509Certificate2Collection)" /> выполняет поиск подходящего для расшифровки сертификата в этой коллекции сертификатов и в хранилище сертификатов MY.</param>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Завершение операции шифрования невозможно.</exception>
		/// <exception cref="T:System.InvalidOperationException">Вызов метода был недопустим для текущего состояния объекта.</exception>
		// Token: 0x060003E3 RID: 995 RVA: 0x0001253C File Offset: 0x0001073C
		public void Decrypt(RecipientInfo recipientInfo, X509Certificate2Collection extraStore)
		{
			if (recipientInfo == null)
			{
				throw new ArgumentNullException("recipientInfo");
			}
			if (extraStore == null)
			{
				throw new ArgumentNullException("extraStore");
			}
			this.DecryptContent(new RecipientInfoCollection(recipientInfo), extraStore);
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.EnvelopedCms.Decrypt(System.Security.Cryptography.X509Certificates.X509Certificate2Collection)" /> расшифровывает содержимое раскодированного запечатанного сообщения CMS/PKCS 7, используя указанную коллекцию сертификатов. Метод <see cref="M:System.Security.Cryptography.Pkcs.EnvelopedCms.Decrypt(System.Security.Cryptography.X509Certificates.X509Certificate2Collection)" /> выполняет поиск подходящего для расшифровки сертификата в указанной коллекции сертификатов и в хранилище сертификатов MY.</summary>
		/// <param name="extraStore">Коллекция <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />, представляющая дополнительные сертификаты для использования при расшифровке. Метод <see cref="M:System.Security.Cryptography.Pkcs.EnvelopedCms.Decrypt(System.Security.Cryptography.X509Certificates.X509Certificate2Collection)" /> выполняет поиск подходящего для расшифровки сертификата в этой коллекции сертификатов и в хранилище сертификатов MY.</param>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Завершение операции шифрования невозможно.</exception>
		/// <exception cref="T:System.InvalidOperationException">Вызов метода был недопустим для текущего состояния объекта.</exception>
		// Token: 0x060003E4 RID: 996 RVA: 0x00012567 File Offset: 0x00010767
		public void Decrypt(X509Certificate2Collection extraStore)
		{
			if (extraStore == null)
			{
				throw new ArgumentNullException("extraStore");
			}
			this.DecryptContent(this.RecipientInfos, extraStore);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00012584 File Offset: 0x00010784
		private void DecryptContent(RecipientInfoCollection recipientInfos, X509Certificate2Collection extraStore)
		{
			switch (this._lastCall)
			{
			case EnvelopedCms.LastCall.Ctor:
				throw new InvalidOperationException("The CMS message is not encrypted.");
			case EnvelopedCms.LastCall.Encrypt:
				throw PkcsPal.Instance.CreateDecryptAfterEncryptException();
			case EnvelopedCms.LastCall.Decode:
			{
				extraStore = (extraStore ?? new X509Certificate2Collection());
				X509Certificate2Collection x509Certificate2Collection = new X509Certificate2Collection();
				PkcsPal.Instance.AddCertsFromStoreForDecryption(x509Certificate2Collection);
				x509Certificate2Collection.AddRange(extraStore);
				X509Certificate2Collection certificates = this.Certificates;
				ContentInfo contentInfo = null;
				Exception ex = PkcsPal.Instance.CreateRecipientsNotFoundException();
				foreach (RecipientInfo recipientInfo in recipientInfos)
				{
					X509Certificate2 x509Certificate = x509Certificate2Collection.TryFindMatchingCertificate(recipientInfo.RecipientIdentifier);
					if (x509Certificate == null)
					{
						ex = PkcsPal.Instance.CreateRecipientsNotFoundException();
					}
					else
					{
						contentInfo = this._decryptorPal.TryDecrypt(recipientInfo, x509Certificate, certificates, extraStore, out ex);
						if (ex == null)
						{
							break;
						}
					}
				}
				if (ex != null)
				{
					throw ex;
				}
				this.ContentInfo = contentInfo;
				this._encodedMessage = contentInfo.Content.CloneByteArray();
				this._lastCall = EnvelopedCms.LastCall.Decrypt;
				return;
			}
			case EnvelopedCms.LastCall.Decrypt:
				throw PkcsPal.Instance.CreateDecryptTwiceException();
			default:
				throw new InvalidOperationException();
			}
		}

		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.EnvelopedCms.#ctor(System.Security.Cryptography.Pkcs.SubjectIdentifierType,System.Security.Cryptography.Pkcs.ContentInfo)" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.EnvelopedCms" />, используя указанные тип идентификатора субъекта и информацию о содержимом. Указанная информация о содержимом используется в качестве типа внутреннего содержимого.</summary>
		/// <param name="recipientIdentifierType">Член перечисления <see cref="T:System.Security.Cryptography.Pkcs.SubjectIdentifierType" />, определяющий способ идентификации получателя.</param>
		/// <param name="contentInfo">Объект <see cref="T:System.Security.Cryptography.Pkcs.ContentInfo" />, представляющий содержимое и его тип.</param>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		// Token: 0x060003E6 RID: 998 RVA: 0x0001268A File Offset: 0x0001088A
		public EnvelopedCms(SubjectIdentifierType recipientIdentifierType, ContentInfo contentInfo) : this(contentInfo)
		{
			if (recipientIdentifierType == SubjectIdentifierType.SubjectKeyIdentifier)
			{
				this.Version = 2;
			}
		}

		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.EnvelopedCms.#ctor(System.Security.Cryptography.Pkcs.SubjectIdentifierType,System.Security.Cryptography.Pkcs.ContentInfo,System.Security.Cryptography.Pkcs.AlgorithmIdentifier)" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.EnvelopedCms" />, используя указанный тип идентификатора субъекта, информацию о содержимом и алгоритм шифрования. Указанная информация о содержимом используется в качестве типа внутреннего содержимого.</summary>
		/// <param name="recipientIdentifierType">Член перечисления <see cref="T:System.Security.Cryptography.Pkcs.SubjectIdentifierType" />, определяющий способ идентификации получателя.</param>
		/// <param name="contentInfo">Объект <see cref="T:System.Security.Cryptography.Pkcs.ContentInfo" />, представляющий содержимое и его тип.</param>
		/// <param name="encryptionAlgorithm">Объект <see cref="T:System.Security.Cryptography.Pkcs.AlgorithmIdentifier" />, определяющий алгоритм шифрования.</param>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		// Token: 0x060003E7 RID: 999 RVA: 0x0001269E File Offset: 0x0001089E
		public EnvelopedCms(SubjectIdentifierType recipientIdentifierType, ContentInfo contentInfo, AlgorithmIdentifier encryptionAlgorithm) : this(contentInfo, encryptionAlgorithm)
		{
			if (recipientIdentifierType == SubjectIdentifierType.SubjectKeyIdentifier)
			{
				this.Version = 2;
			}
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.EnvelopedCms.Encrypt" /> зашифровывает содержимое сообщения CMS/PKCS 7.</summary>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Завершение операции шифрования невозможно.</exception>
		// Token: 0x060003E8 RID: 1000 RVA: 0x000126B3 File Offset: 0x000108B3
		public void Encrypt()
		{
			this.Encrypt(new CmsRecipientCollection());
		}

		// Token: 0x04000281 RID: 641
		private DecryptorPal _decryptorPal;

		// Token: 0x04000282 RID: 642
		private byte[] _encodedMessage;

		// Token: 0x04000283 RID: 643
		private EnvelopedCms.LastCall _lastCall;

		// Token: 0x02000076 RID: 118
		private enum LastCall
		{
			// Token: 0x04000285 RID: 645
			Ctor = 1,
			// Token: 0x04000286 RID: 646
			Encrypt,
			// Token: 0x04000287 RID: 647
			Decode,
			// Token: 0x04000288 RID: 648
			Decrypt
		}
	}
}
