using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Представляет оболочку основного объекта подписи XML для упрощения создания подписей XML.</summary>
	// Token: 0x02000056 RID: 86
	public class SignedXml
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.SignedXml" />.</summary>
		// Token: 0x0600025B RID: 603 RVA: 0x0000A98D File Offset: 0x00008B8D
		public SignedXml()
		{
			this.Initialize(null);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.SignedXml" /> на основе заданного XML-документа.</summary>
		/// <param name="document">Объект <see cref="T:System.Xml.XmlDocument" />, с помощью которого инициализируется новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.SignedXml" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="document" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Параметр <paramref name="document" /> содержит свойство <see cref="P:System.Xml.XmlDocument.DocumentElement" /> со значением null.</exception>
		// Token: 0x0600025C RID: 604 RVA: 0x0000A9AE File Offset: 0x00008BAE
		public SignedXml(XmlDocument document)
		{
			if (document == null)
			{
				throw new ArgumentNullException("document");
			}
			this.Initialize(document.DocumentElement);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.SignedXml" /> на основании указанного объекта <see cref="T:System.Xml.XmlElement" />.</summary>
		/// <param name="elem">Объект <see cref="T:System.Xml.XmlElement" />, с помощью которого инициализируется новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.SignedXml" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="elem" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600025D RID: 605 RVA: 0x0000A9E2 File Offset: 0x00008BE2
		public SignedXml(XmlElement elem)
		{
			if (elem == null)
			{
				throw new ArgumentNullException("elem");
			}
			this.Initialize(elem);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000AA14 File Offset: 0x00008C14
		private void Initialize(XmlElement element)
		{
			this._containingDocument = ((element == null) ? null : element.OwnerDocument);
			this._context = element;
			this.m_signature = new Signature();
			this.m_signature.SignedXml = this;
			this.m_signature.SignedInfo = new SignedInfo();
			this._signingKey = null;
			this._safeCanonicalizationMethods = new Collection<string>(SignedXml.KnownCanonicalizationMethods);
		}

		/// <summary>Получает или задает имя установленного ключа, который будет использоваться для подписывания объекта <see cref="T:System.Security.Cryptography.Xml.SignedXml" />.</summary>
		/// <returns>Имя установленного ключа, который будет использоваться для подписывания объекта <see cref="T:System.Security.Cryptography.Xml.SignedXml" />.</returns>
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600025F RID: 607 RVA: 0x0000AA78 File Offset: 0x00008C78
		// (set) Token: 0x06000260 RID: 608 RVA: 0x0000AA80 File Offset: 0x00008C80
		public string SigningKeyName
		{
			get
			{
				return this.m_strSigningKeyName;
			}
			set
			{
				this.m_strSigningKeyName = value;
			}
		}

		/// <summary>Задает текущий объект <see cref="T:System.Xml.XmlResolver" />.</summary>
		/// <returns>Текущий объект <see cref="T:System.Xml.XmlResolver" />. Объектом по умолчанию является объект <see cref="T:System.Xml.XmlSecureResolver" />.</returns>
		// Token: 0x17000087 RID: 135
		// (set) Token: 0x06000261 RID: 609 RVA: 0x0000AA89 File Offset: 0x00008C89
		public XmlResolver Resolver
		{
			set
			{
				this._xmlResolver = value;
				this._bResolverSet = true;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0000AA99 File Offset: 0x00008C99
		internal bool ResolverSet
		{
			get
			{
				return this._bResolverSet;
			}
		}

		/// <summary>Получает делегат, который будет вызван для проверки формата (но не криптографической безопасности) XML-сигнатуры.</summary>
		/// <returns>Значение <see langword="true" />, формат приемлем; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000263 RID: 611 RVA: 0x0000AAA1 File Offset: 0x00008CA1
		// (set) Token: 0x06000264 RID: 612 RVA: 0x0000AAA9 File Offset: 0x00008CA9
		public Func<SignedXml, bool> SignatureFormatValidator
		{
			get
			{
				return this._signatureFormatValidator;
			}
			set
			{
				this._signatureFormatValidator = value;
			}
		}

		/// <summary>Возвращает имена методов, алгоритмы каноничности которых явно разрешены.</summary>
		/// <returns>Коллекция имен методов, которые безопасно создают канонический XML.</returns>
		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000265 RID: 613 RVA: 0x0000AAB2 File Offset: 0x00008CB2
		public Collection<string> SafeCanonicalizationMethods
		{
			get
			{
				return this._safeCanonicalizationMethods;
			}
		}

		/// <summary>Получает или задает ключ асимметричного алгоритма, используемого для подписывания объекта <see cref="T:System.Security.Cryptography.Xml.SignedXml" />.</summary>
		/// <returns>Ключ асимметричного алгоритма, используемого для подписывания объекта <see cref="T:System.Security.Cryptography.Xml.SignedXml" />.</returns>
		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0000AABA File Offset: 0x00008CBA
		// (set) Token: 0x06000267 RID: 615 RVA: 0x0000AAC2 File Offset: 0x00008CC2
		public AsymmetricAlgorithm SigningKey
		{
			get
			{
				return this._signingKey;
			}
			set
			{
				this._signingKey = value;
			}
		}

		/// <summary>Получает или задает объект <see cref="T:System.Security.Cryptography.Xml.EncryptedXml" />, который определяет правила обработки шифрования XML.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Xml.EncryptedXml" />, который определяет правила обработки шифрования XML.</returns>
		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0000AACB File Offset: 0x00008CCB
		// (set) Token: 0x06000269 RID: 617 RVA: 0x0000AAEC File Offset: 0x00008CEC
		public EncryptedXml EncryptedXml
		{
			get
			{
				if (this._exml == null)
				{
					this._exml = new EncryptedXml(this._containingDocument);
				}
				return this._exml;
			}
			set
			{
				this._exml = value;
			}
		}

		/// <summary>Получает объект <see cref="T:System.Security.Cryptography.Xml.Signature" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.SignedXml" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Xml.Signature" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.SignedXml" />.</returns>
		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0000AAF5 File Offset: 0x00008CF5
		public Signature Signature
		{
			get
			{
				return this.m_signature;
			}
		}

		/// <summary>Получает объект <see cref="T:System.Security.Cryptography.Xml.SignedInfo" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.SignedXml" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Xml.SignedInfo" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.SignedXml" />.</returns>
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600026B RID: 619 RVA: 0x0000AAFD File Offset: 0x00008CFD
		public SignedInfo SignedInfo
		{
			get
			{
				return this.m_signature.SignedInfo;
			}
		}

		/// <summary>Получает метод подписи для текущего объекта <see cref="T:System.Security.Cryptography.Xml.SignedXml" />.</summary>
		/// <returns>Метод подписи для текущего объекта <see cref="T:System.Security.Cryptography.Xml.SignedXml" />.</returns>
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0000AB0A File Offset: 0x00008D0A
		public string SignatureMethod
		{
			get
			{
				return this.m_signature.SignedInfo.SignatureMethod;
			}
		}

		/// <summary>Получает длину подписи для текущего объекта <see cref="T:System.Security.Cryptography.Xml.SignedXml" />.</summary>
		/// <returns>Длина подписи для текущего объекта <see cref="T:System.Security.Cryptography.Xml.SignedXml" />.</returns>
		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0000AB1C File Offset: 0x00008D1C
		public string SignatureLength
		{
			get
			{
				return this.m_signature.SignedInfo.SignatureLength;
			}
		}

		/// <summary>Получает значение подписи для текущего объекта <see cref="T:System.Security.Cryptography.Xml.SignedXml" />.</summary>
		/// <returns>Массив байтов, содержащий значение подписи текущего объекта <see cref="T:System.Security.Cryptography.Xml.SignedXml" />.</returns>
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600026E RID: 622 RVA: 0x0000AB2E File Offset: 0x00008D2E
		public byte[] SignatureValue
		{
			get
			{
				return this.m_signature.SignatureValue;
			}
		}

		/// <summary>Получает или задает объект <see cref="T:System.Security.Cryptography.Xml.KeyInfo" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.SignedXml" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Xml.KeyInfo" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.SignedXml" />.</returns>
		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600026F RID: 623 RVA: 0x0000AB3B File Offset: 0x00008D3B
		// (set) Token: 0x06000270 RID: 624 RVA: 0x0000AB48 File Offset: 0x00008D48
		public KeyInfo KeyInfo
		{
			get
			{
				return this.m_signature.KeyInfo;
			}
			set
			{
				this.m_signature.KeyInfo = value;
			}
		}

		/// <summary>Возвращает XML-представление объекта <see cref="T:System.Security.Cryptography.Xml.SignedXml" />.</summary>
		/// <returns>XML-представление объекта <see cref="T:System.Security.Cryptography.Xml.Signature" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значение свойства <see cref="P:System.Security.Cryptography.Xml.SignedXml.SignedInfo" /> — <see langword="null" />.  
		/// -или- 
		/// Значение свойства <see cref="P:System.Security.Cryptography.Xml.SignedXml.SignatureValue" /> — <see langword="null" />.</exception>
		// Token: 0x06000271 RID: 625 RVA: 0x0000AB56 File Offset: 0x00008D56
		public XmlElement GetXml()
		{
			if (this._containingDocument != null)
			{
				return this.m_signature.GetXml(this._containingDocument);
			}
			return this.m_signature.GetXml();
		}

		/// <summary>Загружает состояние <see cref="T:System.Security.Cryptography.Xml.SignedXml" /> из элемента XML.</summary>
		/// <param name="value">Элемент XML, из которого загружается состояние <see cref="T:System.Security.Cryptography.Xml.SignedXml" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Параметр <paramref name="value" /> не содержит допустимое свойство <see cref="P:System.Security.Cryptography.Xml.SignedXml.SignatureValue" />.  
		/// -или- 
		/// Параметр <paramref name="value" /> не содержит допустимое свойство <see cref="P:System.Security.Cryptography.Xml.SignedXml.SignedInfo" />.</exception>
		// Token: 0x06000272 RID: 626 RVA: 0x0000AB7D File Offset: 0x00008D7D
		public void LoadXml(XmlElement value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			this.m_signature.LoadXml(value);
			if (this._context == null)
			{
				this._context = value;
			}
			this._bCacheValid = false;
		}

		/// <summary>Добавляет объект <see cref="T:System.Security.Cryptography.Xml.Reference" /> к объекту <see cref="T:System.Security.Cryptography.Xml.SignedXml" />, который определяет метод хэширования, значение хэша и преобразование, с помощью которых создается цифровая подпись XML.</summary>
		/// <param name="reference">Объект <see cref="T:System.Security.Cryptography.Xml.Reference" />, который определяет метод хэширования, значение хэша и преобразование, с помощью которых создается цифровая подпись XML.</param>
		// Token: 0x06000273 RID: 627 RVA: 0x0000ABAF File Offset: 0x00008DAF
		public void AddReference(Reference reference)
		{
			this.m_signature.SignedInfo.AddReference(reference);
		}

		/// <summary>Добавляет объект <see cref="T:System.Security.Cryptography.Xml.DataObject" /> к списку подписываемых объектов.</summary>
		/// <param name="dataObject">Объект <see cref="T:System.Security.Cryptography.Xml.DataObject" />, который добавляется к списку подписываемых объектов.</param>
		// Token: 0x06000274 RID: 628 RVA: 0x0000ABC2 File Offset: 0x00008DC2
		public void AddObject(DataObject dataObject)
		{
			this.m_signature.AddObject(dataObject);
		}

		/// <summary>Определяет, проверяется ли свойство <see cref="P:System.Security.Cryptography.Xml.SignedXml.Signature" /> с помощью открытого ключа в подписи.</summary>
		/// <returns>Значение <see langword="true" />, если свойство <see cref="P:System.Security.Cryptography.Xml.SignedXml.Signature" /> проверяется; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Свойство <see cref="P:System.Security.Cryptography.AsymmetricAlgorithm.SignatureAlgorithm" /> открытого ключа в подписи не совпадает со свойством <see cref="P:System.Security.Cryptography.Xml.SignedXml.SignatureMethod" />.  
		/// -или- 
		/// Не удалось создать описание сигнатуры.  
		/// или 
		/// Не удалось создать хэш-алгоритм.</exception>
		// Token: 0x06000275 RID: 629 RVA: 0x0000ABD0 File Offset: 0x00008DD0
		public bool CheckSignature()
		{
			AsymmetricAlgorithm asymmetricAlgorithm;
			return this.CheckSignatureReturningKey(out asymmetricAlgorithm);
		}

		/// <summary>Определяет, проверяется ли свойство <see cref="P:System.Security.Cryptography.Xml.SignedXml.Signature" /> с помощью открытого ключа в подписи.</summary>
		/// <param name="signingKey">При завершении выполнения этого метода содержит реализацию объекта <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" />, содержащего открытый ключ в подписи. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="true" />, если свойство <see cref="P:System.Security.Cryptography.Xml.SignedXml.Signature" /> проверяется с помощью открытого ключа в подписи; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="signingKey" /> имеет значение null.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Свойство <see cref="P:System.Security.Cryptography.AsymmetricAlgorithm.SignatureAlgorithm" /> открытого ключа в подписи не совпадает со свойством <see cref="P:System.Security.Cryptography.Xml.SignedXml.SignatureMethod" />.  
		/// -или- 
		/// Не удалось создать описание сигнатуры.  
		/// или 
		/// Не удалось создать хэш-алгоритм.</exception>
		// Token: 0x06000276 RID: 630 RVA: 0x0000ABE8 File Offset: 0x00008DE8
		public bool CheckSignatureReturningKey(out AsymmetricAlgorithm signingKey)
		{
			SignedXmlDebugLog.LogBeginSignatureVerification(this, this._context);
			signingKey = null;
			bool flag = false;
			if (!this.CheckSignatureFormat())
			{
				return false;
			}
			AsymmetricAlgorithm publicKey;
			do
			{
				publicKey = this.GetPublicKey();
				if (publicKey != null)
				{
					flag = this.CheckSignature(publicKey);
					SignedXmlDebugLog.LogVerificationResult(this, publicKey, flag);
				}
			}
			while (publicKey != null && !flag);
			signingKey = publicKey;
			return flag;
		}

		/// <summary>Определяет, проверяется ли свойство <see cref="P:System.Security.Cryptography.Xml.SignedXml.Signature" /> для указанного ключа.</summary>
		/// <param name="key">Реализация свойства <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" />, которому принадлежит ключ, используемый для проверки свойства <see cref="P:System.Security.Cryptography.Xml.SignedXml.Signature" />.</param>
		/// <returns>Значение <see langword="true" />, если свойство <see cref="P:System.Security.Cryptography.Xml.SignedXml.Signature" /> проверяется для указанного ключа; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Свойство <see cref="P:System.Security.Cryptography.AsymmetricAlgorithm.SignatureAlgorithm" /> параметра <paramref name="key" /> не совпадает со свойством <see cref="P:System.Security.Cryptography.Xml.SignedXml.SignatureMethod" />.  
		/// -или- 
		/// Не удалось создать описание сигнатуры.  
		/// или 
		/// Не удалось создать хэш-алгоритм.</exception>
		// Token: 0x06000277 RID: 631 RVA: 0x0000AC36 File Offset: 0x00008E36
		public bool CheckSignature(AsymmetricAlgorithm key)
		{
			if (!this.CheckSignatureFormat())
			{
				return false;
			}
			if (!this.CheckSignedInfo(key))
			{
				SignedXmlDebugLog.LogVerificationFailure(this, "SignedInfo");
				return false;
			}
			if (!this.CheckDigestedReferences())
			{
				SignedXmlDebugLog.LogVerificationFailure(this, "references");
				return false;
			}
			SignedXmlDebugLog.LogVerificationResult(this, key, true);
			return true;
		}

		/// <summary>Определяет, проверяется ли свойство <see cref="P:System.Security.Cryptography.Xml.SignedXml.Signature" /> для указанного алгоритма кода проверки подлинности сообщения.</summary>
		/// <param name="macAlg">Реализация объекта <see cref="T:System.Security.Cryptography.KeyedHashAlgorithm" />, который содержит код проверки подлинности сообщения, используемый для проверки свойства <see cref="P:System.Security.Cryptography.Xml.SignedXml.Signature" />.</param>
		/// <returns>Значение <see langword="true" />, если свойство <see cref="P:System.Security.Cryptography.Xml.SignedXml.Signature" /> проверяется для указанного кода проверки подлинности сообщения; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="macAlg" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Свойство <see cref="P:System.Security.Cryptography.HashAlgorithm.HashSize" /> указанного объекта <see cref="T:System.Security.Cryptography.KeyedHashAlgorithm" /> недопустимо.  
		/// -или- 
		/// Значение свойства <see cref="P:System.Security.Cryptography.Xml.SignedXml.Signature" /> — <see langword="null" />.  
		/// -или- 
		/// Не удалось создать криптографическое преобразование, используемое для проверки подписи.</exception>
		// Token: 0x06000278 RID: 632 RVA: 0x0000AC76 File Offset: 0x00008E76
		public bool CheckSignature(KeyedHashAlgorithm macAlg)
		{
			if (!this.CheckSignatureFormat())
			{
				return false;
			}
			if (!this.CheckSignedInfo(macAlg))
			{
				SignedXmlDebugLog.LogVerificationFailure(this, "SignedInfo");
				return false;
			}
			if (!this.CheckDigestedReferences())
			{
				SignedXmlDebugLog.LogVerificationFailure(this, "references");
				return false;
			}
			SignedXmlDebugLog.LogVerificationResult(this, macAlg, true);
			return true;
		}

		/// <summary>Определяет, проверяется ли свойство <see cref="P:System.Security.Cryptography.Xml.SignedXml.Signature" /> для указанного объекта <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> и действителен ли сертификат (необязательно).</summary>
		/// <param name="certificate">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />, используемый для проверки свойства <see cref="P:System.Security.Cryptography.Xml.SignedXml.Signature" />.</param>
		/// <param name="verifySignatureOnly">Значение <see langword="true" />, чтобы проверять только подпись; значение <see langword="false" />, чтобы проверять подпись и сертификат.</param>
		/// <returns>Значение <see langword="true" />, если подпись является допустимой; в противном случае — значение <see langword="false" />.  
		/// -или- 
		///  Значение <see langword="true" />, если подпись и сертификат действительны; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="certificate" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Не удалось создать описание сигнатуры для параметра <paramref name="certificate" />.</exception>
		// Token: 0x06000279 RID: 633 RVA: 0x0000ACB8 File Offset: 0x00008EB8
		public bool CheckSignature(X509Certificate2 certificate, bool verifySignatureOnly)
		{
			if (!verifySignatureOnly)
			{
				foreach (X509Extension x509Extension in certificate.Extensions)
				{
					if (string.Compare(x509Extension.Oid.Value, "2.5.29.15", StringComparison.OrdinalIgnoreCase) == 0)
					{
						X509KeyUsageExtension x509KeyUsageExtension = new X509KeyUsageExtension();
						x509KeyUsageExtension.CopyFrom(x509Extension);
						SignedXmlDebugLog.LogVerifyKeyUsage(this, certificate, x509KeyUsageExtension);
						if ((x509KeyUsageExtension.KeyUsages & X509KeyUsageFlags.DigitalSignature) == X509KeyUsageFlags.None && (x509KeyUsageExtension.KeyUsages & X509KeyUsageFlags.NonRepudiation) <= X509KeyUsageFlags.None)
						{
							SignedXmlDebugLog.LogVerificationFailure(this, "X509 key usage verification");
							return false;
						}
						break;
					}
				}
				X509Chain x509Chain = new X509Chain();
				x509Chain.ChainPolicy.ExtraStore.AddRange(this.BuildBagOfCerts());
				bool flag = x509Chain.Build(certificate);
				SignedXmlDebugLog.LogVerifyX509Chain(this, x509Chain, certificate);
				if (!flag)
				{
					SignedXmlDebugLog.LogVerificationFailure(this, "X509 chain verification");
					return false;
				}
			}
			using (AsymmetricAlgorithm anyPublicKey = Utils.GetAnyPublicKey(certificate))
			{
				if (!this.CheckSignature(anyPublicKey))
				{
					return false;
				}
			}
			SignedXmlDebugLog.LogVerificationResult(this, certificate, true);
			return true;
		}

		/// <summary>Вычисляет цифровую подпись XML.</summary>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значение свойства <see cref="P:System.Security.Cryptography.Xml.SignedXml.SigningKey" /> — <see langword="null" />.  
		/// -или- 
		/// Свойство <see cref="P:System.Security.Cryptography.Xml.SignedXml.SigningKey" /> не является объектом <see cref="T:System.Security.Cryptography.DSA" /> или объектом <see cref="T:System.Security.Cryptography.RSA" />.  
		/// -или- 
		/// Не удалось загрузить ключ.</exception>
		// Token: 0x0600027A RID: 634 RVA: 0x0000ADBC File Offset: 0x00008FBC
		public void ComputeSignature()
		{
			SignedXmlDebugLog.LogBeginSignatureComputation(this, this._context);
			this.BuildDigestedReferences();
			AsymmetricAlgorithm signingKey = this.SigningKey;
			if (signingKey == null)
			{
				throw new CryptographicException("Signing key is not loaded.");
			}
			if (this.SignedInfo.SignatureMethod == null)
			{
				if (signingKey is DSA)
				{
					this.SignedInfo.SignatureMethod = "http://www.w3.org/2000/09/xmldsig#dsa-sha1";
				}
				else
				{
					if (!(signingKey is RSA))
					{
						throw new CryptographicException("Failed to create signing key.");
					}
					if (this.SignedInfo.SignatureMethod == null)
					{
						this.SignedInfo.SignatureMethod = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256";
					}
				}
			}
			SignatureDescription signatureDescription = CryptoHelpers.CreateFromName<SignatureDescription>(this.SignedInfo.SignatureMethod);
			if (signatureDescription == null)
			{
				throw new CryptographicException("SignatureDescription could not be created for the signature algorithm supplied.");
			}
			HashAlgorithm hashAlgorithm = signatureDescription.CreateDigest();
			if (hashAlgorithm == null)
			{
				throw new CryptographicException("Could not create hash algorithm object.");
			}
			this.GetC14NDigest(hashAlgorithm);
			AsymmetricSignatureFormatter asymmetricSignatureFormatter = signatureDescription.CreateFormatter(signingKey);
			SignedXmlDebugLog.LogSigning(this, signingKey, signatureDescription, hashAlgorithm, asymmetricSignatureFormatter);
			this.m_signature.SignatureValue = asymmetricSignatureFormatter.CreateSignature(hashAlgorithm);
		}

		/// <summary>Вычисляет цифровую подпись XML с помощью указанного алгоритма кода проверки подлинности сообщения.</summary>
		/// <param name="macAlg">Объект <see cref="T:System.Security.Cryptography.KeyedHashAlgorithm" />, в котором содержится код проверки подлинности сообщения, используемый для вычисления значения свойства <see cref="P:System.Security.Cryptography.Xml.SignedXml.Signature" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="macAlg" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Объект <see cref="T:System.Security.Cryptography.KeyedHashAlgorithm" />, определенный параметром <paramref name="macAlg" /> не является экземпляром <see cref="T:System.Security.Cryptography.HMACSHA1" />.  
		/// -или- 
		/// Свойство <see cref="P:System.Security.Cryptography.HashAlgorithm.HashSize" /> указанного объекта <see cref="T:System.Security.Cryptography.KeyedHashAlgorithm" /> недопустимо.  
		/// -или- 
		/// Не удалось создать криптографическое преобразование, используемое для проверки подписи.</exception>
		// Token: 0x0600027B RID: 635 RVA: 0x0000AEAC File Offset: 0x000090AC
		public void ComputeSignature(KeyedHashAlgorithm macAlg)
		{
			if (macAlg == null)
			{
				throw new ArgumentNullException("macAlg");
			}
			HMAC hmac = macAlg as HMAC;
			if (hmac == null)
			{
				throw new CryptographicException("The key does not fit the SignatureMethod.");
			}
			int num;
			if (this.m_signature.SignedInfo.SignatureLength == null)
			{
				num = hmac.HashSize;
			}
			else
			{
				num = Convert.ToInt32(this.m_signature.SignedInfo.SignatureLength, null);
			}
			if (num < 0 || num > hmac.HashSize)
			{
				throw new CryptographicException("The length of the signature with a MAC should be less than the hash output length.");
			}
			if (num % 8 != 0)
			{
				throw new CryptographicException("The length in bits of the signature with a MAC should be a multiple of 8.");
			}
			this.BuildDigestedReferences();
			string hashName = hmac.HashName;
			if (!(hashName == "SHA1"))
			{
				if (!(hashName == "SHA256"))
				{
					if (!(hashName == "SHA384"))
					{
						if (!(hashName == "SHA512"))
						{
							if (!(hashName == "MD5"))
							{
								if (!(hashName == "RIPEMD160"))
								{
									throw new CryptographicException("The key does not fit the SignatureMethod.");
								}
								this.SignedInfo.SignatureMethod = "http://www.w3.org/2001/04/xmldsig-more#hmac-ripemd160";
							}
							else
							{
								this.SignedInfo.SignatureMethod = "http://www.w3.org/2001/04/xmldsig-more#hmac-md5";
							}
						}
						else
						{
							this.SignedInfo.SignatureMethod = "http://www.w3.org/2001/04/xmldsig-more#hmac-sha512";
						}
					}
					else
					{
						this.SignedInfo.SignatureMethod = "http://www.w3.org/2001/04/xmldsig-more#hmac-sha384";
					}
				}
				else
				{
					this.SignedInfo.SignatureMethod = "http://www.w3.org/2001/04/xmldsig-more#hmac-sha256";
				}
			}
			else
			{
				this.SignedInfo.SignatureMethod = "http://www.w3.org/2000/09/xmldsig#hmac-sha1";
			}
			Array c14NDigest = this.GetC14NDigest(hmac);
			SignedXmlDebugLog.LogSigning(this, hmac);
			this.m_signature.SignatureValue = new byte[num / 8];
			Buffer.BlockCopy(c14NDigest, 0, this.m_signature.SignatureValue, 0, num / 8);
		}

		/// <summary>Возвращает открытый ключ подписи.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.AsymmetricAlgorithm" />, содержащий открытый ключ подписи, или значение <see langword="null" />, если найти ключ не удалось.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значение свойства <see cref="P:System.Security.Cryptography.Xml.SignedXml.KeyInfo" /> — <see langword="null" />.</exception>
		// Token: 0x0600027C RID: 636 RVA: 0x0000B040 File Offset: 0x00009240
		protected virtual AsymmetricAlgorithm GetPublicKey()
		{
			if (this.KeyInfo == null)
			{
				throw new CryptographicException("A KeyInfo element is required to check the signature.");
			}
			if (this._x509Enum != null)
			{
				AsymmetricAlgorithm nextCertificatePublicKey = this.GetNextCertificatePublicKey();
				if (nextCertificatePublicKey != null)
				{
					return nextCertificatePublicKey;
				}
			}
			if (this._keyInfoEnum == null)
			{
				this._keyInfoEnum = this.KeyInfo.GetEnumerator();
			}
			while (this._keyInfoEnum.MoveNext())
			{
				RSAKeyValue rsakeyValue = this._keyInfoEnum.Current as RSAKeyValue;
				if (rsakeyValue != null)
				{
					return rsakeyValue.Key;
				}
				DSAKeyValue dsakeyValue = this._keyInfoEnum.Current as DSAKeyValue;
				if (dsakeyValue != null)
				{
					return dsakeyValue.Key;
				}
				KeyInfoX509Data keyInfoX509Data = this._keyInfoEnum.Current as KeyInfoX509Data;
				if (keyInfoX509Data != null)
				{
					this._x509Collection = Utils.BuildBagOfCerts(keyInfoX509Data, CertUsageType.Verification);
					if (this._x509Collection.Count > 0)
					{
						this._x509Enum = this._x509Collection.GetEnumerator();
						AsymmetricAlgorithm nextCertificatePublicKey2 = this.GetNextCertificatePublicKey();
						if (nextCertificatePublicKey2 != null)
						{
							return nextCertificatePublicKey2;
						}
					}
				}
			}
			return null;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000B12C File Offset: 0x0000932C
		private X509Certificate2Collection BuildBagOfCerts()
		{
			X509Certificate2Collection x509Certificate2Collection = new X509Certificate2Collection();
			if (this.KeyInfo != null)
			{
				foreach (object obj in this.KeyInfo)
				{
					KeyInfoX509Data keyInfoX509Data = ((KeyInfoClause)obj) as KeyInfoX509Data;
					if (keyInfoX509Data != null)
					{
						x509Certificate2Collection.AddRange(Utils.BuildBagOfCerts(keyInfoX509Data, CertUsageType.Verification));
					}
				}
			}
			return x509Certificate2Collection;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000B1A4 File Offset: 0x000093A4
		private AsymmetricAlgorithm GetNextCertificatePublicKey()
		{
			while (this._x509Enum.MoveNext())
			{
				X509Certificate2 x509Certificate = (X509Certificate2)this._x509Enum.Current;
				if (x509Certificate != null)
				{
					return Utils.GetAnyPublicKey(x509Certificate);
				}
			}
			return null;
		}

		/// <summary>Возвращает объект <see cref="T:System.Xml.XmlElement" /> с указанным идентификатором из указанного объекта <see cref="T:System.Xml.XmlDocument" />.</summary>
		/// <param name="document">Объект <see cref="T:System.Xml.XmlDocument" />, из которого извлекается объект <see cref="T:System.Xml.XmlElement" />.</param>
		/// <param name="idValue">Идентификатор объекта <see cref="T:System.Xml.XmlElement" />, извлекаемого из объекта <see cref="T:System.Xml.XmlDocument" />.</param>
		/// <returns>Объект <see cref="T:System.Xml.XmlElement" /> с указанным идентификатором, извлеченный из указанного объекта <see cref="T:System.Xml.XmlDocument" />, или значение <see langword="null" />, если найти такой объект не удалось.</returns>
		// Token: 0x0600027F RID: 639 RVA: 0x000067EC File Offset: 0x000049EC
		public virtual XmlElement GetIdElement(XmlDocument document, string idValue)
		{
			return SignedXml.DefaultGetIdElement(document, idValue);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000B1DC File Offset: 0x000093DC
		internal static XmlElement DefaultGetIdElement(XmlDocument document, string idValue)
		{
			if (document == null)
			{
				return null;
			}
			try
			{
				XmlConvert.VerifyNCName(idValue);
			}
			catch (XmlException)
			{
				return null;
			}
			XmlElement xmlElement = document.GetElementById(idValue);
			if (xmlElement != null)
			{
				XmlDocument xmlDocument = (XmlDocument)document.CloneNode(true);
				XmlElement elementById = xmlDocument.GetElementById(idValue);
				if (elementById != null)
				{
					elementById.Attributes.RemoveAll();
					if (xmlDocument.GetElementById(idValue) != null)
					{
						throw new CryptographicException("Malformed reference element.");
					}
				}
				return xmlElement;
			}
			xmlElement = SignedXml.GetSingleReferenceTarget(document, "Id", idValue);
			if (xmlElement != null)
			{
				return xmlElement;
			}
			xmlElement = SignedXml.GetSingleReferenceTarget(document, "id", idValue);
			if (xmlElement != null)
			{
				return xmlElement;
			}
			return SignedXml.GetSingleReferenceTarget(document, "ID", idValue);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000B288 File Offset: 0x00009488
		private static bool DefaultSignatureFormatValidator(SignedXml signedXml)
		{
			return !signedXml.DoesSignatureUseTruncatedHmac() && signedXml.DoesSignatureUseSafeCanonicalizationMethod();
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000B2A0 File Offset: 0x000094A0
		private bool DoesSignatureUseTruncatedHmac()
		{
			if (this.SignedInfo.SignatureLength == null)
			{
				return false;
			}
			HMAC hmac = CryptoHelpers.CreateFromName<HMAC>(this.SignatureMethod);
			if (hmac == null)
			{
				return false;
			}
			int num = 0;
			return !int.TryParse(this.SignedInfo.SignatureLength, out num) || num != hmac.HashSize;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000B2F4 File Offset: 0x000094F4
		private bool DoesSignatureUseSafeCanonicalizationMethod()
		{
			using (IEnumerator<string> enumerator = this.SafeCanonicalizationMethods.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (string.Equals(enumerator.Current, this.SignedInfo.CanonicalizationMethod, StringComparison.OrdinalIgnoreCase))
					{
						return true;
					}
				}
			}
			SignedXmlDebugLog.LogUnsafeCanonicalizationMethod(this, this.SignedInfo.CanonicalizationMethod, this.SafeCanonicalizationMethods);
			return false;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000B36C File Offset: 0x0000956C
		private bool ReferenceUsesSafeTransformMethods(Reference reference)
		{
			TransformChain transformChain = reference.TransformChain;
			int count = transformChain.Count;
			for (int i = 0; i < count; i++)
			{
				Transform transform = transformChain[i];
				if (!this.IsSafeTransform(transform.Algorithm))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000B3AC File Offset: 0x000095AC
		private bool IsSafeTransform(string transformAlgorithm)
		{
			using (IEnumerator<string> enumerator = this.SafeCanonicalizationMethods.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (string.Equals(enumerator.Current, transformAlgorithm, StringComparison.OrdinalIgnoreCase))
					{
						return true;
					}
				}
			}
			using (IEnumerator<string> enumerator = SignedXml.DefaultSafeTransformMethods.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (string.Equals(enumerator.Current, transformAlgorithm, StringComparison.OrdinalIgnoreCase))
					{
						return true;
					}
				}
			}
			SignedXmlDebugLog.LogUnsafeTransformMethod(this, transformAlgorithm, this.SafeCanonicalizationMethods, SignedXml.DefaultSafeTransformMethods);
			return false;
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0000B454 File Offset: 0x00009654
		private static IList<string> KnownCanonicalizationMethods
		{
			get
			{
				if (SignedXml.s_knownCanonicalizationMethods == null)
				{
					SignedXml.s_knownCanonicalizationMethods = new List<string>
					{
						"http://www.w3.org/TR/2001/REC-xml-c14n-20010315",
						"http://www.w3.org/TR/2001/REC-xml-c14n-20010315#WithComments",
						"http://www.w3.org/2001/10/xml-exc-c14n#",
						"http://www.w3.org/2001/10/xml-exc-c14n#WithComments"
					};
				}
				return SignedXml.s_knownCanonicalizationMethods;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000287 RID: 647 RVA: 0x0000B4A4 File Offset: 0x000096A4
		private static IList<string> DefaultSafeTransformMethods
		{
			get
			{
				if (SignedXml.s_defaultSafeTransformMethods == null)
				{
					SignedXml.s_defaultSafeTransformMethods = new List<string>
					{
						"http://www.w3.org/2000/09/xmldsig#enveloped-signature",
						"http://www.w3.org/2000/09/xmldsig#base64",
						"urn:mpeg:mpeg21:2003:01-REL-R-NS:licenseTransform",
						"http://www.w3.org/2002/07/decrypt#XML"
					};
				}
				return SignedXml.s_defaultSafeTransformMethods;
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000B4F4 File Offset: 0x000096F4
		private byte[] GetC14NDigest(HashAlgorithm hash)
		{
			bool flag = hash is KeyedHashAlgorithm;
			if (flag || !this._bCacheValid || !this.SignedInfo.CacheValid)
			{
				string text = (this._containingDocument == null) ? null : this._containingDocument.BaseURI;
				XmlResolver xmlResolver = this._bResolverSet ? this._xmlResolver : new XmlSecureResolver(new XmlUrlResolver(), text);
				XmlDocument xmlDocument = Utils.PreProcessElementInput(this.SignedInfo.GetXml(), xmlResolver, text);
				CanonicalXmlNodeList namespaces = (this._context == null) ? null : Utils.GetPropagatedAttributes(this._context);
				SignedXmlDebugLog.LogNamespacePropagation(this, namespaces);
				Utils.AddNamespaces(xmlDocument.DocumentElement, namespaces);
				Transform canonicalizationMethodObject = this.SignedInfo.CanonicalizationMethodObject;
				canonicalizationMethodObject.Resolver = xmlResolver;
				canonicalizationMethodObject.BaseURI = text;
				SignedXmlDebugLog.LogBeginCanonicalization(this, canonicalizationMethodObject);
				canonicalizationMethodObject.LoadInput(xmlDocument);
				SignedXmlDebugLog.LogCanonicalizedOutput(this, canonicalizationMethodObject);
				this._digestedSignedInfo = canonicalizationMethodObject.GetDigestedOutput(hash);
				this._bCacheValid = !flag;
			}
			return this._digestedSignedInfo;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000B5EC File Offset: 0x000097EC
		private int GetReferenceLevel(int index, ArrayList references)
		{
			if (this._refProcessed[index])
			{
				return this._refLevelCache[index];
			}
			this._refProcessed[index] = true;
			Reference reference = (Reference)references[index];
			if (reference.Uri == null || reference.Uri.Length == 0 || (reference.Uri.Length > 0 && reference.Uri[0] != '#'))
			{
				this._refLevelCache[index] = 0;
				return 0;
			}
			if (reference.Uri.Length <= 0 || reference.Uri[0] != '#')
			{
				throw new CryptographicException("Malformed reference element.");
			}
			string text = Utils.ExtractIdFromLocalUri(reference.Uri);
			if (text == "xpointer(/)")
			{
				this._refLevelCache[index] = 0;
				return 0;
			}
			for (int i = 0; i < references.Count; i++)
			{
				if (((Reference)references[i]).Id == text)
				{
					this._refLevelCache[index] = this.GetReferenceLevel(i, references) + 1;
					return this._refLevelCache[index];
				}
			}
			this._refLevelCache[index] = 0;
			return 0;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000B700 File Offset: 0x00009900
		private void BuildDigestedReferences()
		{
			ArrayList references = this.SignedInfo.References;
			this._refProcessed = new bool[references.Count];
			this._refLevelCache = new int[references.Count];
			SignedXml.ReferenceLevelSortOrder referenceLevelSortOrder = new SignedXml.ReferenceLevelSortOrder();
			referenceLevelSortOrder.References = references;
			ArrayList arrayList = new ArrayList();
			foreach (object obj in references)
			{
				Reference value = (Reference)obj;
				arrayList.Add(value);
			}
			arrayList.Sort(referenceLevelSortOrder);
			CanonicalXmlNodeList canonicalXmlNodeList = new CanonicalXmlNodeList();
			foreach (object obj2 in this.m_signature.ObjectList)
			{
				DataObject dataObject = (DataObject)obj2;
				canonicalXmlNodeList.Add(dataObject.GetXml());
			}
			foreach (object obj3 in arrayList)
			{
				Reference reference = (Reference)obj3;
				if (reference.DigestMethod == null)
				{
					reference.DigestMethod = "http://www.w3.org/2001/04/xmlenc#sha256";
				}
				SignedXmlDebugLog.LogSigningReference(this, reference);
				reference.UpdateHashValue(this._containingDocument, canonicalXmlNodeList);
				if (reference.Id != null)
				{
					canonicalXmlNodeList.Add(reference.GetXml());
				}
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000B890 File Offset: 0x00009A90
		private bool CheckDigestedReferences()
		{
			ArrayList references = this.m_signature.SignedInfo.References;
			for (int i = 0; i < references.Count; i++)
			{
				Reference reference = (Reference)references[i];
				if (!this.ReferenceUsesSafeTransformMethods(reference))
				{
					return false;
				}
				SignedXmlDebugLog.LogVerifyReference(this, reference);
				byte[] array = null;
				try
				{
					array = reference.CalculateHashValue(this._containingDocument, this.m_signature.ReferencedItems);
				}
				catch (CryptoSignedXmlRecursionException)
				{
					SignedXmlDebugLog.LogSignedXmlRecursionLimit(this, reference);
					return false;
				}
				SignedXmlDebugLog.LogVerifyReferenceHash(this, reference, array, reference.DigestValue);
				if (!SignedXml.CryptographicEquals(array, reference.DigestValue))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000B93C File Offset: 0x00009B3C
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private static bool CryptographicEquals(byte[] a, byte[] b)
		{
			int num = 0;
			if (a.Length != b.Length)
			{
				return false;
			}
			int num2 = a.Length;
			for (int i = 0; i < num2; i++)
			{
				num |= (int)(a[i] - b[i]);
			}
			return num == 0;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000B974 File Offset: 0x00009B74
		private bool CheckSignatureFormat()
		{
			if (this._signatureFormatValidator == null)
			{
				return true;
			}
			SignedXmlDebugLog.LogBeginCheckSignatureFormat(this, this._signatureFormatValidator);
			bool result = this._signatureFormatValidator(this);
			SignedXmlDebugLog.LogFormatValidationResult(this, result);
			return result;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000B9AC File Offset: 0x00009BAC
		private bool CheckSignedInfo(AsymmetricAlgorithm key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			SignedXmlDebugLog.LogBeginCheckSignedInfo(this, this.m_signature.SignedInfo);
			SignatureDescription signatureDescription = CryptoHelpers.CreateFromName<SignatureDescription>(this.SignatureMethod);
			if (signatureDescription == null)
			{
				throw new CryptographicException("SignatureDescription could not be created for the signature algorithm supplied.");
			}
			Type type = Type.GetType(signatureDescription.KeyAlgorithm);
			if (!SignedXml.IsKeyTheCorrectAlgorithm(key, type))
			{
				return false;
			}
			HashAlgorithm hashAlgorithm = signatureDescription.CreateDigest();
			if (hashAlgorithm == null)
			{
				throw new CryptographicException("Could not create hash algorithm object.");
			}
			byte[] c14NDigest = this.GetC14NDigest(hashAlgorithm);
			AsymmetricSignatureDeformatter asymmetricSignatureDeformatter = signatureDescription.CreateDeformatter(key);
			SignedXmlDebugLog.LogVerifySignedInfo(this, key, signatureDescription, hashAlgorithm, asymmetricSignatureDeformatter, c14NDigest, this.m_signature.SignatureValue);
			return asymmetricSignatureDeformatter.VerifySignature(c14NDigest, this.m_signature.SignatureValue);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000BA5C File Offset: 0x00009C5C
		private bool CheckSignedInfo(KeyedHashAlgorithm macAlg)
		{
			if (macAlg == null)
			{
				throw new ArgumentNullException("macAlg");
			}
			SignedXmlDebugLog.LogBeginCheckSignedInfo(this, this.m_signature.SignedInfo);
			int num;
			if (this.m_signature.SignedInfo.SignatureLength == null)
			{
				num = macAlg.HashSize;
			}
			else
			{
				num = Convert.ToInt32(this.m_signature.SignedInfo.SignatureLength, null);
			}
			if (num < 0 || num > macAlg.HashSize)
			{
				throw new CryptographicException("The length of the signature with a MAC should be less than the hash output length.");
			}
			if (num % 8 != 0)
			{
				throw new CryptographicException("The length in bits of the signature with a MAC should be a multiple of 8.");
			}
			if (this.m_signature.SignatureValue == null)
			{
				throw new CryptographicException("Signature requires a SignatureValue.");
			}
			if (this.m_signature.SignatureValue.Length != num / 8)
			{
				throw new CryptographicException("The length of the signature with a MAC should be less than the hash output length.");
			}
			byte[] c14NDigest = this.GetC14NDigest(macAlg);
			SignedXmlDebugLog.LogVerifySignedInfo(this, macAlg, c14NDigest, this.m_signature.SignatureValue);
			for (int i = 0; i < this.m_signature.SignatureValue.Length; i++)
			{
				if (this.m_signature.SignatureValue[i] != c14NDigest[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000BB60 File Offset: 0x00009D60
		private static XmlElement GetSingleReferenceTarget(XmlDocument document, string idAttributeName, string idValue)
		{
			string xpath = string.Concat(new string[]
			{
				"//*[@",
				idAttributeName,
				"=\"",
				idValue,
				"\"]"
			});
			XmlNodeList xmlNodeList = document.SelectNodes(xpath);
			if (xmlNodeList == null || xmlNodeList.Count == 0)
			{
				return null;
			}
			if (xmlNodeList.Count == 1)
			{
				return xmlNodeList[0] as XmlElement;
			}
			throw new CryptographicException("Malformed reference element.");
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000BBD0 File Offset: 0x00009DD0
		private static bool IsKeyTheCorrectAlgorithm(AsymmetricAlgorithm key, Type expectedType)
		{
			Type type = key.GetType();
			if (type == expectedType)
			{
				return true;
			}
			if (expectedType.IsSubclassOf(type))
			{
				return true;
			}
			while (expectedType != null && expectedType.BaseType != typeof(AsymmetricAlgorithm))
			{
				expectedType = expectedType.BaseType;
			}
			return !(expectedType == null) && type.IsSubclassOf(expectedType);
		}

		/// <summary>Представляет объект <see cref="T:System.Security.Cryptography.Xml.Signature" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.SignedXml" />.</summary>
		// Token: 0x040001D9 RID: 473
		protected Signature m_signature;

		/// <summary>Представляет имя установленного ключа, который будет использоваться для подписывания объекта <see cref="T:System.Security.Cryptography.Xml.SignedXml" />.</summary>
		// Token: 0x040001DA RID: 474
		protected string m_strSigningKeyName;

		// Token: 0x040001DB RID: 475
		private AsymmetricAlgorithm _signingKey;

		// Token: 0x040001DC RID: 476
		private XmlDocument _containingDocument;

		// Token: 0x040001DD RID: 477
		private IEnumerator _keyInfoEnum;

		// Token: 0x040001DE RID: 478
		private X509Certificate2Collection _x509Collection;

		// Token: 0x040001DF RID: 479
		private IEnumerator _x509Enum;

		// Token: 0x040001E0 RID: 480
		private bool[] _refProcessed;

		// Token: 0x040001E1 RID: 481
		private int[] _refLevelCache;

		// Token: 0x040001E2 RID: 482
		internal XmlResolver _xmlResolver;

		// Token: 0x040001E3 RID: 483
		internal XmlElement _context;

		// Token: 0x040001E4 RID: 484
		private bool _bResolverSet;

		// Token: 0x040001E5 RID: 485
		private Func<SignedXml, bool> _signatureFormatValidator = new Func<SignedXml, bool>(SignedXml.DefaultSignatureFormatValidator);

		// Token: 0x040001E6 RID: 486
		private Collection<string> _safeCanonicalizationMethods;

		// Token: 0x040001E7 RID: 487
		private static IList<string> s_knownCanonicalizationMethods;

		// Token: 0x040001E8 RID: 488
		private static IList<string> s_defaultSafeTransformMethods;

		// Token: 0x040001E9 RID: 489
		private const string XmlDsigMoreHMACMD5Url = "http://www.w3.org/2001/04/xmldsig-more#hmac-md5";

		// Token: 0x040001EA RID: 490
		private const string XmlDsigMoreHMACSHA256Url = "http://www.w3.org/2001/04/xmldsig-more#hmac-sha256";

		// Token: 0x040001EB RID: 491
		private const string XmlDsigMoreHMACSHA384Url = "http://www.w3.org/2001/04/xmldsig-more#hmac-sha384";

		// Token: 0x040001EC RID: 492
		private const string XmlDsigMoreHMACSHA512Url = "http://www.w3.org/2001/04/xmldsig-more#hmac-sha512";

		// Token: 0x040001ED RID: 493
		private const string XmlDsigMoreHMACRIPEMD160Url = "http://www.w3.org/2001/04/xmldsig-more#hmac-ripemd160";

		// Token: 0x040001EE RID: 494
		private EncryptedXml _exml;

		/// <summary>Представляет универсальный код ресурса (URI) стандартного пространства имен для цифровых подписей XML. Это поле является константой.</summary>
		// Token: 0x040001EF RID: 495
		public const string XmlDsigNamespaceUrl = "http://www.w3.org/2000/09/xmldsig#";

		/// <summary>Представляет универсальный код ресурса (URI) стандартного минимального алгоритма канонизации для цифровых подписей XML. Это поле является константой.</summary>
		// Token: 0x040001F0 RID: 496
		public const string XmlDsigMinimalCanonicalizationUrl = "http://www.w3.org/2000/09/xmldsig#minimal";

		/// <summary>Представляет универсальный код ресурса (URI) стандартного алгоритма канонизации для цифровых подписей XML. Это поле является константой.</summary>
		// Token: 0x040001F1 RID: 497
		public const string XmlDsigCanonicalizationUrl = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";

		/// <summary>Представляет универсальный код ресурса (URI) стандартного алгоритма канонизации для цифровых подписей XML и включает комментарии. Это поле является константой.</summary>
		// Token: 0x040001F2 RID: 498
		public const string XmlDsigCanonicalizationWithCommentsUrl = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315#WithComments";

		/// <summary>Представляет универсальный код ресурса (URI) для стандартного метода выборки <see cref="T:System.Security.Cryptography.SHA1" /> для цифровых подписей XML. Это поле является константой.</summary>
		// Token: 0x040001F3 RID: 499
		public const string XmlDsigSHA1Url = "http://www.w3.org/2000/09/xmldsig#sha1";

		/// <summary>Представляет универсальный код ресурса (URI) стандартного алгоритма <see cref="T:System.Security.Cryptography.DSA" /> для цифровых подписей XML. Это поле является константой.</summary>
		// Token: 0x040001F4 RID: 500
		public const string XmlDsigDSAUrl = "http://www.w3.org/2000/09/xmldsig#dsa-sha1";

		/// <summary>Представляет универсальный код ресурса (URI) стандартного метода подписи <see cref="T:System.Security.Cryptography.RSA" /> для цифровых подписей XML. Это поле является константой.</summary>
		// Token: 0x040001F5 RID: 501
		public const string XmlDsigRSASHA1Url = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";

		/// <summary>Представляет универсальный код ресурса (URI) стандартного алгоритма <see cref="T:System.Security.Cryptography.HMACSHA1" /> для цифровых подписей XML. Это поле является константой.</summary>
		// Token: 0x040001F6 RID: 502
		public const string XmlDsigHMACSHA1Url = "http://www.w3.org/2000/09/xmldsig#hmac-sha1";

		/// <summary>Представляет универсальный код ресурса (URI) для стандартного метода выборки <see cref="T:System.Security.Cryptography.SHA256" /> для цифровых подписей XML. Это поле является константой.</summary>
		// Token: 0x040001F7 RID: 503
		public const string XmlDsigSHA256Url = "http://www.w3.org/2001/04/xmlenc#sha256";

		/// <summary>Представляет универсальный код ресурса (URI) для варианта метода подписи SHA-256 <see cref="T:System.Security.Cryptography.RSA" /> для цифровых подписей XML. Это поле является константой.</summary>
		// Token: 0x040001F8 RID: 504
		public const string XmlDsigRSASHA256Url = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256";

		/// <summary>Представляет универсальный код ресурса (URI) для стандартного метода выборки <see cref="T:System.Security.Cryptography.SHA384" /> для цифровых подписей XML. Это поле является константой.</summary>
		// Token: 0x040001F9 RID: 505
		public const string XmlDsigSHA384Url = "http://www.w3.org/2001/04/xmldsig-more#sha384";

		/// <summary>Представляет универсальный код ресурса (URI) для варианта метода подписи SHA-384 <see cref="T:System.Security.Cryptography.RSA" /> для цифровых подписей XML. Это поле является константой.</summary>
		// Token: 0x040001FA RID: 506
		public const string XmlDsigRSASHA384Url = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha384";

		/// <summary>Представляет универсальный код ресурса (URI) для стандартного метода выборки <see cref="T:System.Security.Cryptography.SHA512" /> для цифровых подписей XML. Это поле является константой.</summary>
		// Token: 0x040001FB RID: 507
		public const string XmlDsigSHA512Url = "http://www.w3.org/2001/04/xmlenc#sha512";

		/// <summary>Представляет универсальный код ресурса (URI) для варианта метода подписи SHA-512 <see cref="T:System.Security.Cryptography.RSA" /> для цифровых подписей XML. Это поле является константой.</summary>
		// Token: 0x040001FC RID: 508
		public const string XmlDsigRSASHA512Url = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha512";

		/// <summary>Представляет универсальный код ресурса (URI) канонического преобразования XML. Это поле является константой.</summary>
		// Token: 0x040001FD RID: 509
		public const string XmlDsigC14NTransformUrl = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";

		/// <summary>Представляет универсальный код ресурса (URI) канонического преобразования XML с комментариями. Это поле является константой.</summary>
		// Token: 0x040001FE RID: 510
		public const string XmlDsigC14NWithCommentsTransformUrl = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315#WithComments";

		/// <summary>Представляет универсальный код ресурса (URI) исключительной канонизации XML. Это поле является константой.</summary>
		// Token: 0x040001FF RID: 511
		public const string XmlDsigExcC14NTransformUrl = "http://www.w3.org/2001/10/xml-exc-c14n#";

		/// <summary>Представляет универсальный код ресурса (URI) исключительной канонизации XML с комментариями. Это поле является константой.</summary>
		// Token: 0x04000200 RID: 512
		public const string XmlDsigExcC14NWithCommentsTransformUrl = "http://www.w3.org/2001/10/xml-exc-c14n#WithComments";

		/// <summary>Представляет универсальный код ресурса (URI) преобразования Base64. Это поле является константой.</summary>
		// Token: 0x04000201 RID: 513
		public const string XmlDsigBase64TransformUrl = "http://www.w3.org/2000/09/xmldsig#base64";

		/// <summary>Представляет универсальный код ресурса (URI) языка XPath (XML Path Language). Это поле является константой.</summary>
		// Token: 0x04000202 RID: 514
		public const string XmlDsigXPathTransformUrl = "http://www.w3.org/TR/1999/REC-xpath-19991116";

		/// <summary>Представляет универсальный код ресурса (URI) преобразования XSLT. Это поле является константой.</summary>
		// Token: 0x04000203 RID: 515
		public const string XmlDsigXsltTransformUrl = "http://www.w3.org/TR/1999/REC-xslt-19991116";

		/// <summary>Представляет универсальный код ресурса (URI) преобразования запечатанной подписи. Это поле является константой.</summary>
		// Token: 0x04000204 RID: 516
		public const string XmlDsigEnvelopedSignatureTransformUrl = "http://www.w3.org/2000/09/xmldsig#enveloped-signature";

		/// <summary>Представляет универсальный код ресурса (URI) преобразования шифрования режима XML. Это поле является константой.</summary>
		// Token: 0x04000205 RID: 517
		public const string XmlDecryptionTransformUrl = "http://www.w3.org/2002/07/decrypt#XML";

		/// <summary>Представляет универсальный код ресурса (URI) алгоритма преобразования лицензий, который используется для нормализации лицензий XrML для сигнатур.</summary>
		// Token: 0x04000206 RID: 518
		public const string XmlLicenseTransformUrl = "urn:mpeg:mpeg21:2003:01-REL-R-NS:licenseTransform";

		// Token: 0x04000207 RID: 519
		private bool _bCacheValid;

		// Token: 0x04000208 RID: 520
		private byte[] _digestedSignedInfo;

		// Token: 0x02000057 RID: 87
		private class ReferenceLevelSortOrder : IComparer
		{
			// Token: 0x17000095 RID: 149
			// (get) Token: 0x06000293 RID: 659 RVA: 0x0000BC39 File Offset: 0x00009E39
			// (set) Token: 0x06000294 RID: 660 RVA: 0x0000BC41 File Offset: 0x00009E41
			public ArrayList References
			{
				get
				{
					return this._references;
				}
				set
				{
					this._references = value;
				}
			}

			// Token: 0x06000295 RID: 661 RVA: 0x0000BC4C File Offset: 0x00009E4C
			public int Compare(object a, object b)
			{
				Reference reference = a as Reference;
				Reference reference2 = b as Reference;
				int index = 0;
				int index2 = 0;
				int num = 0;
				foreach (object obj in this.References)
				{
					Reference reference3 = (Reference)obj;
					if (reference3 == reference)
					{
						index = num;
					}
					if (reference3 == reference2)
					{
						index2 = num;
					}
					num++;
				}
				int referenceLevel = reference.SignedXml.GetReferenceLevel(index, this.References);
				int referenceLevel2 = reference2.SignedXml.GetReferenceLevel(index2, this.References);
				return referenceLevel.CompareTo(referenceLevel2);
			}

			// Token: 0x04000209 RID: 521
			private ArrayList _references;
		}
	}
}
