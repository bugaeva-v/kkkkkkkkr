using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Xml;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Представляет модель процесса для реализации XML-шифрования.</summary>
	// Token: 0x02000038 RID: 56
	public class EncryptedXml
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.EncryptedXml" />.</summary>
		// Token: 0x0600013D RID: 317 RVA: 0x000064EC File Offset: 0x000046EC
		public EncryptedXml() : this(new XmlDocument())
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.EncryptedXml" /> с помощью указанного XML-документа.</summary>
		/// <param name="document">Объект <see cref="T:System.Xml.XmlDocument" />, используемый для инициализации объекта <see cref="T:System.Security.Cryptography.Xml.EncryptedXml" />.</param>
		// Token: 0x0600013E RID: 318 RVA: 0x000064F9 File Offset: 0x000046F9
		public EncryptedXml(XmlDocument document) : this(document, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.EncryptedXml" /> с помощью указанного XML-документа и свидетельства.</summary>
		/// <param name="document">Объект <see cref="T:System.Xml.XmlDocument" />, используемый для инициализации объекта <see cref="T:System.Security.Cryptography.Xml.EncryptedXml" />.</param>
		/// <param name="evidence">Объект <see cref="T:System.Security.Policy.Evidence" />, связанный с объектом <see cref="T:System.Xml.XmlDocument" />.</param>
		// Token: 0x0600013F RID: 319 RVA: 0x00006504 File Offset: 0x00004704
		public EncryptedXml(XmlDocument document, Evidence evidence)
		{
			this._document = document;
			this._evidence = evidence;
			this._xmlResolver = null;
			this._padding = PaddingMode.ISO10126;
			this._mode = CipherMode.CBC;
			this._encoding = Encoding.UTF8;
			this._keyNameMapping = new Hashtable(4);
			this._xmlDsigSearchDepth = 20;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00006559 File Offset: 0x00004759
		private bool IsOverXmlDsigRecursionLimit()
		{
			return this._xmlDsigSearchDepthCounter > this.XmlDSigSearchDepth;
		}

		/// <summary>Возвращает или задает глубину рекурсии цифровой подписи XML-файла для предотвращения бесконечной рекурсии и переполнения стека. Это может произойти, если цифровая подпись XML содержит универсальный код ресурса (URI), который затем указывает обратно на исходный XML-файл.</summary>
		/// <returns>Возвращает <see cref="T:System.Int32" />.</returns>
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000141 RID: 321 RVA: 0x0000656C File Offset: 0x0000476C
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00006574 File Offset: 0x00004774
		public int XmlDSigSearchDepth
		{
			get
			{
				return this._xmlDsigSearchDepth;
			}
			set
			{
				this._xmlDsigSearchDepth = value;
			}
		}

		/// <summary>Возвращает или задает свидетельство объекта <see cref="T:System.Xml.XmlDocument" />, на основе которого создается объект <see cref="T:System.Security.Cryptography.Xml.EncryptedXml" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Policy.Evidence" />.</returns>
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0000657D File Offset: 0x0000477D
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00006585 File Offset: 0x00004785
		public Evidence DocumentEvidence
		{
			get
			{
				return this._evidence;
			}
			set
			{
				this._evidence = value;
			}
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Xml.XmlResolver" />, используемый моделью DOM для разрешения внешних XML-ссылок.</summary>
		/// <returns>Объект <see cref="T:System.Xml.XmlResolver" />.</returns>
		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0000658E File Offset: 0x0000478E
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00006596 File Offset: 0x00004796
		public XmlResolver Resolver
		{
			get
			{
				return this._xmlResolver;
			}
			set
			{
				this._xmlResolver = value;
			}
		}

		/// <summary>Возвращает или задает режим заполнения, используемый для XML-шифрования.</summary>
		/// <returns>Одно из значений <see cref="T:System.Security.Cryptography.PaddingMode" />, указывающее тип заполнения, используемого для шифрования.</returns>
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000147 RID: 327 RVA: 0x0000659F File Offset: 0x0000479F
		// (set) Token: 0x06000148 RID: 328 RVA: 0x000065A7 File Offset: 0x000047A7
		public PaddingMode Padding
		{
			get
			{
				return this._padding;
			}
			set
			{
				this._padding = value;
			}
		}

		/// <summary>Возвращает или задает режим шифрования, используемый для XML-шифрования.</summary>
		/// <returns>Одно из значений <see cref="T:System.Security.Cryptography.CipherMode" />.</returns>
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000149 RID: 329 RVA: 0x000065B0 File Offset: 0x000047B0
		// (set) Token: 0x0600014A RID: 330 RVA: 0x000065B8 File Offset: 0x000047B8
		public CipherMode Mode
		{
			get
			{
				return this._mode;
			}
			set
			{
				this._mode = value;
			}
		}

		/// <summary>Возвращает или задает кодировку, используемую для XML-шифрования.</summary>
		/// <returns>Объект <see cref="T:System.Text.Encoding" />.</returns>
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600014B RID: 331 RVA: 0x000065C1 File Offset: 0x000047C1
		// (set) Token: 0x0600014C RID: 332 RVA: 0x000065C9 File Offset: 0x000047C9
		public Encoding Encoding
		{
			get
			{
				return this._encoding;
			}
			set
			{
				this._encoding = value;
			}
		}

		/// <summary>Возвращает или задает получателя данных о зашифрованном ключе.</summary>
		/// <returns>Получатель данных о зашифрованном ключе.</returns>
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600014D RID: 333 RVA: 0x000065D2 File Offset: 0x000047D2
		// (set) Token: 0x0600014E RID: 334 RVA: 0x000065ED File Offset: 0x000047ED
		public string Recipient
		{
			get
			{
				if (this._recipient == null)
				{
					this._recipient = string.Empty;
				}
				return this._recipient;
			}
			set
			{
				this._recipient = value;
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000065F8 File Offset: 0x000047F8
		private byte[] GetCipherValue(CipherData cipherData)
		{
			if (cipherData == null)
			{
				throw new ArgumentNullException("cipherData");
			}
			WebResponse webResponse = null;
			Stream stream = null;
			if (cipherData.CipherValue != null)
			{
				return cipherData.CipherValue;
			}
			if (cipherData.CipherReference == null)
			{
				throw new CryptographicException("Cipher data is not specified.");
			}
			if (cipherData.CipherReference.CipherValue != null)
			{
				return cipherData.CipherReference.CipherValue;
			}
			if (cipherData.CipherReference.Uri == null)
			{
				throw new CryptographicException(" The specified Uri is not supported.");
			}
			Stream stream2;
			if (cipherData.CipherReference.Uri.Length == 0)
			{
				string baseUri = (this._document == null) ? null : this._document.BaseURI;
				TransformChain transformChain = cipherData.CipherReference.TransformChain;
				if (transformChain == null)
				{
					throw new CryptographicException(" The specified Uri is not supported.");
				}
				stream2 = transformChain.TransformToOctetStream(this._document, this._xmlResolver, baseUri);
			}
			else
			{
				if (cipherData.CipherReference.Uri[0] != '#')
				{
					throw new CryptographicException("Unable to resolve Uri {0}.", cipherData.CipherReference.Uri);
				}
				string idValue = Utils.ExtractIdFromLocalUri(cipherData.CipherReference.Uri);
				XmlElement idElement = this.GetIdElement(this._document, idValue);
				if (idElement == null || idElement.OuterXml == null)
				{
					throw new CryptographicException(" The specified Uri is not supported.");
				}
				stream = new MemoryStream(this._encoding.GetBytes(idElement.OuterXml));
				string baseUri2 = (this._document == null) ? null : this._document.BaseURI;
				TransformChain transformChain2 = cipherData.CipherReference.TransformChain;
				if (transformChain2 == null)
				{
					throw new CryptographicException(" The specified Uri is not supported.");
				}
				stream2 = transformChain2.TransformToOctetStream(stream, this._xmlResolver, baseUri2);
			}
			byte[] array = null;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				Utils.Pump(stream2, memoryStream);
				array = memoryStream.ToArray();
				if (webResponse != null)
				{
					webResponse.Close();
				}
				if (stream != null)
				{
					stream.Close();
				}
				stream2.Close();
			}
			cipherData.CipherReference.CipherValue = array;
			return array;
		}

		/// <summary>Определяет способ разрешения внутренних ссылок универсального кода ресурса (URI).</summary>
		/// <param name="document">Объект <see cref="T:System.Xml.XmlDocument" />, содержащий элемент со значением идентификатора.</param>
		/// <param name="idValue">Строка, представляющая значение идентификатора.</param>
		/// <returns>Объект <see cref="T:System.Xml.XmlElement" />, содержащий идентификатор, указывающий способ разрешения внутренних универсальных кодов ресурса (URI).</returns>
		// Token: 0x06000150 RID: 336 RVA: 0x000067EC File Offset: 0x000049EC
		public virtual XmlElement GetIdElement(XmlDocument document, string idValue)
		{
			return SignedXml.DefaultGetIdElement(document, idValue);
		}

		/// <summary>Извлекает вектор инициализации (IV) расшифровки из объекта <see cref="T:System.Security.Cryptography.Xml.EncryptedData" />.</summary>
		/// <param name="encryptedData">Объект <see cref="T:System.Security.Cryptography.Xml.EncryptedData" />, содержащий извлекаемый вектор инициализации (IV).</param>
		/// <param name="symmetricAlgorithmUri">Универсальный код ресурса (URI), который описывает алгоритм шифрования, связанный со значением параметра <paramref name="encryptedData" />.</param>
		/// <returns>Массив байтов, содержащий вектор инициализации (IV) расшифровки.</returns>
		/// <exception cref="T:System.ArgumentNullException">параметр <paramref name="encryptedData" /> имеет значение <see langword="null" />;</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значение параметра <paramref name="encryptedData" /> содержит свойство <see cref="P:System.Security.Cryptography.Xml.EncryptedType.EncryptionMethod" />, равное значению NULL.  
		/// -или- 
		/// Значение параметра <paramref name="symmetricAlgorithmUrisymAlgUri" /> не является поддерживаемым алгоритмом.</exception>
		// Token: 0x06000151 RID: 337 RVA: 0x000067F8 File Offset: 0x000049F8
		public virtual byte[] GetDecryptionIV(EncryptedData encryptedData, string symmetricAlgorithmUri)
		{
			if (encryptedData == null)
			{
				throw new ArgumentNullException("encryptedData");
			}
			if (symmetricAlgorithmUri == null)
			{
				if (encryptedData.EncryptionMethod == null)
				{
					throw new CryptographicException("Symmetric algorithm is not specified.");
				}
				symmetricAlgorithmUri = encryptedData.EncryptionMethod.KeyAlgorithm;
			}
			int num;
			if (!(symmetricAlgorithmUri == "http://www.w3.org/2001/04/xmlenc#des-cbc") && !(symmetricAlgorithmUri == "http://www.w3.org/2001/04/xmlenc#tripledes-cbc"))
			{
				if (!(symmetricAlgorithmUri == "http://www.w3.org/2001/04/xmlenc#aes128-cbc") && !(symmetricAlgorithmUri == "http://www.w3.org/2001/04/xmlenc#aes192-cbc") && !(symmetricAlgorithmUri == "http://www.w3.org/2001/04/xmlenc#aes256-cbc"))
				{
					throw new CryptographicException(" The specified Uri is not supported.");
				}
				num = 16;
			}
			else
			{
				num = 8;
			}
			byte[] array = new byte[num];
			Buffer.BlockCopy(this.GetCipherValue(encryptedData.CipherData), 0, array, 0, array.Length);
			return array;
		}

		/// <summary>Извлекает ключ расшифровки из указанного объекта <see cref="T:System.Security.Cryptography.Xml.EncryptedData" />.</summary>
		/// <param name="encryptedData">Объект <see cref="T:System.Security.Cryptography.Xml.EncryptedData" />, содержащий извлекаемый ключ расшифровки.</param>
		/// <param name="symmetricAlgorithmUri">Размер извлекаемого ключа расшифровки.</param>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.SymmetricAlgorithm" />, связанный с ключом расшифровки.</returns>
		/// <exception cref="T:System.ArgumentNullException">параметр <paramref name="encryptedData" /> имеет значение <see langword="null" />;</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Параметр encryptedData содержит свойство <see cref="P:System.Security.Cryptography.Xml.EncryptedType.EncryptionMethod" />, равное значению NULL.  
		/// -или- 
		/// Не удается извлечь зашифрованный ключ с помощью указанных параметров.</exception>
		// Token: 0x06000152 RID: 338 RVA: 0x000068B0 File Offset: 0x00004AB0
		public virtual SymmetricAlgorithm GetDecryptionKey(EncryptedData encryptedData, string symmetricAlgorithmUri)
		{
			if (encryptedData == null)
			{
				throw new ArgumentNullException("encryptedData");
			}
			if (encryptedData.KeyInfo == null)
			{
				return null;
			}
			IEnumerator enumerator = encryptedData.KeyInfo.GetEnumerator();
			EncryptedKey encryptedKey = null;
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				KeyInfoName keyInfoName = obj as KeyInfoName;
				if (keyInfoName != null)
				{
					string value = keyInfoName.Value;
					if ((SymmetricAlgorithm)this._keyNameMapping[value] != null)
					{
						return (SymmetricAlgorithm)this._keyNameMapping[value];
					}
					XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(this._document.NameTable);
					xmlNamespaceManager.AddNamespace("enc", "http://www.w3.org/2001/04/xmlenc#");
					XmlNodeList xmlNodeList = this._document.SelectNodes("//enc:EncryptedKey", xmlNamespaceManager);
					if (xmlNodeList == null)
					{
						break;
					}
					using (IEnumerator enumerator2 = xmlNodeList.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							object obj2 = enumerator2.Current;
							XmlElement value2 = ((XmlNode)obj2) as XmlElement;
							EncryptedKey encryptedKey2 = new EncryptedKey();
							encryptedKey2.LoadXml(value2);
							if (encryptedKey2.CarriedKeyName == value && encryptedKey2.Recipient == this.Recipient)
							{
								encryptedKey = encryptedKey2;
								break;
							}
						}
						break;
					}
				}
				KeyInfoRetrievalMethod keyInfoRetrievalMethod = enumerator.Current as KeyInfoRetrievalMethod;
				if (keyInfoRetrievalMethod != null)
				{
					string idValue = Utils.ExtractIdFromLocalUri(keyInfoRetrievalMethod.Uri);
					encryptedKey = new EncryptedKey();
					encryptedKey.LoadXml(this.GetIdElement(this._document, idValue));
					break;
				}
				KeyInfoEncryptedKey keyInfoEncryptedKey = enumerator.Current as KeyInfoEncryptedKey;
				if (keyInfoEncryptedKey != null)
				{
					encryptedKey = keyInfoEncryptedKey.EncryptedKey;
					break;
				}
			}
			if (encryptedKey == null)
			{
				return null;
			}
			if (symmetricAlgorithmUri == null)
			{
				if (encryptedData.EncryptionMethod == null)
				{
					throw new CryptographicException("Symmetric algorithm is not specified.");
				}
				symmetricAlgorithmUri = encryptedData.EncryptionMethod.KeyAlgorithm;
			}
			byte[] array = this.DecryptEncryptedKey(encryptedKey);
			if (array == null)
			{
				throw new CryptographicException("Unable to retrieve the decryption key.");
			}
			SymmetricAlgorithm symmetricAlgorithm = CryptoHelpers.CreateFromName<SymmetricAlgorithm>(symmetricAlgorithmUri);
			if (symmetricAlgorithm == null)
			{
				throw new CryptographicException("Symmetric algorithm is not specified.");
			}
			symmetricAlgorithm.Key = array;
			return symmetricAlgorithm;
		}

		/// <summary>Определяет ключ, представленный элементом <see cref="T:System.Security.Cryptography.Xml.EncryptedKey" />.</summary>
		/// <param name="encryptedKey">Объект <see cref="T:System.Security.Cryptography.Xml.EncryptedKey" />, содержащий извлекаемый ключ.</param>
		/// <returns>Массив байтов, содержащий ключ.</returns>
		/// <exception cref="T:System.ArgumentNullException">параметр <paramref name="encryptedKey" /> имеет значение <see langword="null" />;</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значением параметра <paramref name="encryptedKey" /> не является алгоритм шифрования ключей Triple DES или AES (который также называется Rijndael).</exception>
		// Token: 0x06000153 RID: 339 RVA: 0x00006AAC File Offset: 0x00004CAC
		public virtual byte[] DecryptEncryptedKey(EncryptedKey encryptedKey)
		{
			if (encryptedKey == null)
			{
				throw new ArgumentNullException("encryptedKey");
			}
			if (encryptedKey.KeyInfo == null)
			{
				return null;
			}
			foreach (object obj in encryptedKey.KeyInfo)
			{
				KeyInfoName keyInfoName = obj as KeyInfoName;
				bool useOAEP;
				if (keyInfoName == null)
				{
					IEnumerator enumerator;
					KeyInfoX509Data keyInfoX509Data = enumerator.Current as KeyInfoX509Data;
					if (keyInfoX509Data != null)
					{
						foreach (X509Certificate2 certificate in Utils.BuildBagOfCerts(keyInfoX509Data, CertUsageType.Decryption))
						{
							using (RSA rsaprivateKey = certificate.GetRSAPrivateKey())
							{
								if (rsaprivateKey != null)
								{
									if (encryptedKey.CipherData == null || encryptedKey.CipherData.CipherValue == null)
									{
										throw new CryptographicException("Symmetric algorithm is not specified.");
									}
									useOAEP = (encryptedKey.EncryptionMethod != null && encryptedKey.EncryptionMethod.KeyAlgorithm == "http://www.w3.org/2001/04/xmlenc#rsa-oaep-mgf1p");
									return EncryptedXml.DecryptKey(encryptedKey.CipherData.CipherValue, rsaprivateKey, useOAEP);
								}
							}
						}
						break;
					}
					KeyInfoRetrievalMethod keyInfoRetrievalMethod = enumerator.Current as KeyInfoRetrievalMethod;
					EncryptedKey encryptedKey2;
					if (keyInfoRetrievalMethod != null)
					{
						string idValue = Utils.ExtractIdFromLocalUri(keyInfoRetrievalMethod.Uri);
						encryptedKey2 = new EncryptedKey();
						encryptedKey2.LoadXml(this.GetIdElement(this._document, idValue));
						try
						{
							this._xmlDsigSearchDepthCounter++;
							if (this.IsOverXmlDsigRecursionLimit())
							{
								throw new CryptoSignedXmlRecursionException();
							}
							return this.DecryptEncryptedKey(encryptedKey2);
						}
						finally
						{
							this._xmlDsigSearchDepthCounter--;
						}
					}
					KeyInfoEncryptedKey keyInfoEncryptedKey = enumerator.Current as KeyInfoEncryptedKey;
					if (keyInfoEncryptedKey == null)
					{
						continue;
					}
					encryptedKey2 = keyInfoEncryptedKey.EncryptedKey;
					byte[] array = this.DecryptEncryptedKey(encryptedKey2);
					if (array == null)
					{
						continue;
					}
					SymmetricAlgorithm symmetricAlgorithm = CryptoHelpers.CreateFromName<SymmetricAlgorithm>(encryptedKey.EncryptionMethod.KeyAlgorithm);
					if (symmetricAlgorithm == null)
					{
						throw new CryptographicException("Symmetric algorithm is not specified.");
					}
					symmetricAlgorithm.Key = array;
					if (encryptedKey.CipherData == null || encryptedKey.CipherData.CipherValue == null)
					{
						throw new CryptographicException("Symmetric algorithm is not specified.");
					}
					symmetricAlgorithm.Key = array;
					return EncryptedXml.DecryptKey(encryptedKey.CipherData.CipherValue, symmetricAlgorithm);
				}
				string value = keyInfoName.Value;
				object obj2 = this._keyNameMapping[value];
				if (obj2 == null)
				{
					break;
				}
				if (encryptedKey.CipherData == null || encryptedKey.CipherData.CipherValue == null)
				{
					throw new CryptographicException("Symmetric algorithm is not specified.");
				}
				if (obj2 is SymmetricAlgorithm)
				{
					return EncryptedXml.DecryptKey(encryptedKey.CipherData.CipherValue, (SymmetricAlgorithm)obj2);
				}
				useOAEP = (encryptedKey.EncryptionMethod != null && encryptedKey.EncryptionMethod.KeyAlgorithm == "http://www.w3.org/2001/04/xmlenc#rsa-oaep-mgf1p");
				return EncryptedXml.DecryptKey(encryptedKey.CipherData.CipherValue, (RSA)obj2, useOAEP);
			}
			return null;
		}

		/// <summary>Определяет сопоставление имени ключа с симметричным или асимметричным ключом.</summary>
		/// <param name="keyName">Имя, сопоставляемое с объектом <paramref name="keyObject" />.</param>
		/// <param name="keyObject">Симметричный ключ, сопоставляемый с именем <paramref name="keyName" />.</param>
		/// <exception cref="T:System.ArgumentNullException">параметр <paramref name="keyName" /> имеет значение <see langword="null" />;  
		/// -или- 
		/// параметр <paramref name="keyObject" /> имеет значение <see langword="null" />;</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значением параметра <paramref name="keyObject" /> не является алгоритм RSA или симметричный ключ.</exception>
		// Token: 0x06000154 RID: 340 RVA: 0x00006D70 File Offset: 0x00004F70
		public void AddKeyNameMapping(string keyName, object keyObject)
		{
			if (keyName == null)
			{
				throw new ArgumentNullException("keyName");
			}
			if (keyObject == null)
			{
				throw new ArgumentNullException("keyObject");
			}
			if (!(keyObject is SymmetricAlgorithm) && !(keyObject is RSA))
			{
				throw new CryptographicException("The specified cryptographic transform is not supported.");
			}
			this._keyNameMapping.Add(keyName, keyObject);
		}

		/// <summary>Сбрасывает все сопоставления между именами и ключами.</summary>
		// Token: 0x06000155 RID: 341 RVA: 0x00006DC1 File Offset: 0x00004FC1
		public void ClearKeyNameMappings()
		{
			this._keyNameMapping.Clear();
		}

		/// <summary>Шифрует внешний XML-элемент с помощью сертификата X.509.</summary>
		/// <param name="inputElement">Шифруемый XML-элемент.</param>
		/// <param name="certificate">Сертификат X.509, используемый для шифрования.</param>
		/// <returns>Элемент <see cref="T:System.Security.Cryptography.Xml.EncryptedData" />, представляющий зашифрованные XML-данные.</returns>
		/// <exception cref="T:System.ArgumentNullException">параметр <paramref name="inputElement" /> имеет значение <see langword="null" />;  
		/// -или- 
		/// параметр <paramref name="certificate" /> имеет значение <see langword="null" />;</exception>
		/// <exception cref="T:System.NotSupportedException">Значение параметра <paramref name="certificate" /> не представляет алгоритм шифрования ключей RSA.</exception>
		// Token: 0x06000156 RID: 342 RVA: 0x00006DD0 File Offset: 0x00004FD0
		public EncryptedData Encrypt(XmlElement inputElement, X509Certificate2 certificate)
		{
			if (inputElement == null)
			{
				throw new ArgumentNullException("inputElement");
			}
			if (certificate == null)
			{
				throw new ArgumentNullException("certificate");
			}
			EncryptedData result;
			using (RSA rsapublicKey = certificate.GetRSAPublicKey())
			{
				if (rsapublicKey == null)
				{
					throw new NotSupportedException("The certificate key algorithm is not supported.");
				}
				EncryptedData encryptedData = new EncryptedData();
				encryptedData.Type = "http://www.w3.org/2001/04/xmlenc#Element";
				encryptedData.EncryptionMethod = new EncryptionMethod("http://www.w3.org/2001/04/xmlenc#aes256-cbc");
				EncryptedKey encryptedKey = new EncryptedKey();
				encryptedKey.EncryptionMethod = new EncryptionMethod("http://www.w3.org/2001/04/xmlenc#rsa-1_5");
				encryptedKey.KeyInfo.AddClause(new KeyInfoX509Data(certificate));
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				encryptedKey.CipherData.CipherValue = EncryptedXml.EncryptKey(rijndaelManaged.Key, rsapublicKey, false);
				KeyInfoEncryptedKey clause = new KeyInfoEncryptedKey(encryptedKey);
				encryptedData.KeyInfo.AddClause(clause);
				encryptedData.CipherData.CipherValue = this.EncryptData(inputElement, rijndaelManaged, false);
				result = encryptedData;
			}
			return result;
		}

		/// <summary>Шифрует внешний XML-элемент с помощью ключа, указанного в таблице сопоставления ключей.</summary>
		/// <param name="inputElement">Шифруемый XML-элемент.</param>
		/// <param name="keyName">Имя ключа, которое можно найти в таблице сопоставления ключей.</param>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Xml.EncryptedData" />, представляющий зашифрованные XML-данные.</returns>
		/// <exception cref="T:System.ArgumentNullException">параметр <paramref name="inputElement" /> имеет значение <see langword="null" />;  
		/// -или- 
		/// параметр <paramref name="keyName" /> имеет значение <see langword="null" />;</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значение параметра <paramref name="keyName" /> не совпадает с зарегистрированной парой "ключ-имя".  
		/// -или- 
		/// Ключ шифрования, описанный параметром <paramref name="keyName" />, не поддерживается.</exception>
		// Token: 0x06000157 RID: 343 RVA: 0x00006EB8 File Offset: 0x000050B8
		public EncryptedData Encrypt(XmlElement inputElement, string keyName)
		{
			if (inputElement == null)
			{
				throw new ArgumentNullException("inputElement");
			}
			if (keyName == null)
			{
				throw new ArgumentNullException("keyName");
			}
			object obj = null;
			if (this._keyNameMapping != null)
			{
				obj = this._keyNameMapping[keyName];
			}
			if (obj == null)
			{
				throw new CryptographicException("Unable to retrieve the encryption key.");
			}
			SymmetricAlgorithm symmetricAlgorithm = obj as SymmetricAlgorithm;
			RSA rsa = obj as RSA;
			EncryptedData encryptedData = new EncryptedData();
			encryptedData.Type = "http://www.w3.org/2001/04/xmlenc#Element";
			encryptedData.EncryptionMethod = new EncryptionMethod("http://www.w3.org/2001/04/xmlenc#aes256-cbc");
			string algorithm = null;
			if (symmetricAlgorithm == null)
			{
				algorithm = "http://www.w3.org/2001/04/xmlenc#rsa-1_5";
			}
			else if (symmetricAlgorithm is TripleDES)
			{
				algorithm = "http://www.w3.org/2001/04/xmlenc#kw-tripledes";
			}
			else
			{
				if (!(symmetricAlgorithm is Rijndael) && !(symmetricAlgorithm is Aes))
				{
					throw new CryptographicException("The specified cryptographic transform is not supported.");
				}
				int keySize = symmetricAlgorithm.KeySize;
				if (keySize != 128)
				{
					if (keySize != 192)
					{
						if (keySize == 256)
						{
							algorithm = "http://www.w3.org/2001/04/xmlenc#kw-aes256";
						}
					}
					else
					{
						algorithm = "http://www.w3.org/2001/04/xmlenc#kw-aes192";
					}
				}
				else
				{
					algorithm = "http://www.w3.org/2001/04/xmlenc#kw-aes128";
				}
			}
			EncryptedKey encryptedKey = new EncryptedKey();
			encryptedKey.EncryptionMethod = new EncryptionMethod(algorithm);
			encryptedKey.KeyInfo.AddClause(new KeyInfoName(keyName));
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			encryptedKey.CipherData.CipherValue = ((symmetricAlgorithm == null) ? EncryptedXml.EncryptKey(rijndaelManaged.Key, rsa, false) : EncryptedXml.EncryptKey(rijndaelManaged.Key, symmetricAlgorithm));
			KeyInfoEncryptedKey clause = new KeyInfoEncryptedKey(encryptedKey);
			encryptedData.KeyInfo.AddClause(clause);
			encryptedData.CipherData.CipherValue = this.EncryptData(inputElement, rijndaelManaged, false);
			return encryptedData;
		}

		/// <summary>Расшифровывает все элементы <see langword="&lt;EncryptedData&gt;" /> XML-документа, указанные при инициализации класса <see cref="T:System.Security.Cryptography.Xml.EncryptedXml" />.</summary>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Не найден ключ шифрования, используемый для расшифровки документа.</exception>
		// Token: 0x06000158 RID: 344 RVA: 0x00007030 File Offset: 0x00005230
		public void DecryptDocument()
		{
			XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(this._document.NameTable);
			xmlNamespaceManager.AddNamespace("enc", "http://www.w3.org/2001/04/xmlenc#");
			XmlNodeList xmlNodeList = this._document.SelectNodes("//enc:EncryptedData", xmlNamespaceManager);
			if (xmlNodeList != null)
			{
				foreach (object obj in xmlNodeList)
				{
					XmlElement xmlElement = ((XmlNode)obj) as XmlElement;
					EncryptedData encryptedData = new EncryptedData();
					encryptedData.LoadXml(xmlElement);
					SymmetricAlgorithm decryptionKey = this.GetDecryptionKey(encryptedData, null);
					if (decryptionKey == null)
					{
						throw new CryptographicException("Unable to retrieve the decryption key.");
					}
					byte[] decryptedData = this.DecryptData(encryptedData, decryptionKey);
					this.ReplaceData(xmlElement, decryptedData);
				}
			}
		}

		/// <summary>Шифрует данные в указанном массиве байтов с помощью заданного симметричного алгоритма.</summary>
		/// <param name="plaintext">Данные, которые необходимо зашифровать.</param>
		/// <param name="symmetricAlgorithm">Симметричный алгоритм, используемый для шифрования.</param>
		/// <returns>Массив байтов, содержащий зашифрованные данные.</returns>
		/// <exception cref="T:System.ArgumentNullException">параметр <paramref name="plaintext" /> имеет значение <see langword="null" />;  
		/// -или- 
		/// параметр <paramref name="symmetricAlgorithm" /> имеет значение <see langword="null" />;</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Не удается зашифровать данные с помощью указанных параметров.</exception>
		// Token: 0x06000159 RID: 345 RVA: 0x000070FC File Offset: 0x000052FC
		public byte[] EncryptData(byte[] plaintext, SymmetricAlgorithm symmetricAlgorithm)
		{
			if (plaintext == null)
			{
				throw new ArgumentNullException("plaintext");
			}
			if (symmetricAlgorithm == null)
			{
				throw new ArgumentNullException("symmetricAlgorithm");
			}
			CipherMode mode = symmetricAlgorithm.Mode;
			PaddingMode padding = symmetricAlgorithm.Padding;
			byte[] array = null;
			try
			{
				symmetricAlgorithm.Mode = this._mode;
				symmetricAlgorithm.Padding = this._padding;
				array = symmetricAlgorithm.CreateEncryptor().TransformFinalBlock(plaintext, 0, plaintext.Length);
			}
			finally
			{
				symmetricAlgorithm.Mode = mode;
				symmetricAlgorithm.Padding = padding;
			}
			byte[] array2;
			if (this._mode == CipherMode.ECB)
			{
				array2 = array;
			}
			else
			{
				byte[] iv = symmetricAlgorithm.IV;
				array2 = new byte[array.Length + iv.Length];
				Buffer.BlockCopy(iv, 0, array2, 0, iv.Length);
				Buffer.BlockCopy(array, 0, array2, iv.Length, array.Length);
			}
			return array2;
		}

		/// <summary>Шифрует указанный элемент или его содержимое с помощью заданного симметричного алгоритма.</summary>
		/// <param name="inputElement">Шифруемый элемент или его содержимое.</param>
		/// <param name="symmetricAlgorithm">Симметричный алгоритм, используемый для шифрования.</param>
		/// <param name="content">Значение <see langword="true" /> для шифрования только содержимого элемента; значение <see langword="false" /> для шифрования всего элемента.</param>
		/// <returns>Массив байтов, содержащий зашифрованные данные.</returns>
		/// <exception cref="T:System.ArgumentNullException">параметр <paramref name="inputElement" /> имеет значение <see langword="null" />;  
		/// -или- 
		/// параметр <paramref name="symmetricAlgorithm" /> имеет значение <see langword="null" />;</exception>
		// Token: 0x0600015A RID: 346 RVA: 0x000071C4 File Offset: 0x000053C4
		public byte[] EncryptData(XmlElement inputElement, SymmetricAlgorithm symmetricAlgorithm, bool content)
		{
			if (inputElement == null)
			{
				throw new ArgumentNullException("inputElement");
			}
			if (symmetricAlgorithm == null)
			{
				throw new ArgumentNullException("symmetricAlgorithm");
			}
			byte[] plaintext = content ? this._encoding.GetBytes(inputElement.InnerXml) : this._encoding.GetBytes(inputElement.OuterXml);
			return this.EncryptData(plaintext, symmetricAlgorithm);
		}

		/// <summary>Расшифровывает элемент <see langword="&lt;EncryptedData&gt;" /> с помощью указанного симметричного алгоритма.</summary>
		/// <param name="encryptedData">Расшифровываемые данные.</param>
		/// <param name="symmetricAlgorithm">Симметричный ключ, используемый для расшифровки объекта <paramref name="encryptedData" />.</param>
		/// <returns>Массив байтов, который содержит необработанный расшифрованный обычный текст.</returns>
		/// <exception cref="T:System.ArgumentNullException">параметр <paramref name="encryptedData" /> имеет значение <see langword="null" />;  
		/// -или- 
		/// параметр <paramref name="symmetricAlgorithm" /> имеет значение <see langword="null" />;</exception>
		// Token: 0x0600015B RID: 347 RVA: 0x00007220 File Offset: 0x00005420
		public byte[] DecryptData(EncryptedData encryptedData, SymmetricAlgorithm symmetricAlgorithm)
		{
			if (encryptedData == null)
			{
				throw new ArgumentNullException("encryptedData");
			}
			if (symmetricAlgorithm == null)
			{
				throw new ArgumentNullException("symmetricAlgorithm");
			}
			byte[] cipherValue = this.GetCipherValue(encryptedData.CipherData);
			CipherMode mode = symmetricAlgorithm.Mode;
			PaddingMode padding = symmetricAlgorithm.Padding;
			byte[] iv = symmetricAlgorithm.IV;
			byte[] array = null;
			if (this._mode != CipherMode.ECB)
			{
				array = this.GetDecryptionIV(encryptedData, null);
			}
			byte[] result = null;
			try
			{
				int num = 0;
				if (array != null)
				{
					symmetricAlgorithm.IV = array;
					num = array.Length;
				}
				symmetricAlgorithm.Mode = this._mode;
				symmetricAlgorithm.Padding = this._padding;
				result = symmetricAlgorithm.CreateDecryptor().TransformFinalBlock(cipherValue, num, cipherValue.Length - num);
			}
			finally
			{
				symmetricAlgorithm.Mode = mode;
				symmetricAlgorithm.Padding = padding;
				symmetricAlgorithm.IV = iv;
			}
			return result;
		}

		/// <summary>Заменяет элемент <see langword="&lt;EncryptedData&gt;" /> заданной расшифрованной последовательностью байтов.</summary>
		/// <param name="inputElement">Заменяемый элемент <see langword="&lt;EncryptedData&gt;" />.</param>
		/// <param name="decryptedData">Расшифрованные данные, которыми заменяется элемент <paramref name="inputElement" />.</param>
		/// <exception cref="T:System.ArgumentNullException">параметр <paramref name="inputElement" /> имеет значение <see langword="null" />;  
		/// -или- 
		/// параметр <paramref name="decryptedData" /> имеет значение <see langword="null" />;</exception>
		// Token: 0x0600015C RID: 348 RVA: 0x000072F4 File Offset: 0x000054F4
		public void ReplaceData(XmlElement inputElement, byte[] decryptedData)
		{
			if (inputElement == null)
			{
				throw new ArgumentNullException("inputElement");
			}
			if (decryptedData == null)
			{
				throw new ArgumentNullException("decryptedData");
			}
			XmlNode parentNode = inputElement.ParentNode;
			if (parentNode.NodeType == XmlNodeType.Document)
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.PreserveWhitespace = true;
				using (StringReader stringReader = new StringReader(this._encoding.GetString(decryptedData)))
				{
					using (XmlReader xmlReader = XmlReader.Create(stringReader, Utils.GetSecureXmlReaderSettings(this._xmlResolver)))
					{
						xmlDocument.Load(xmlReader);
					}
				}
				XmlNode newChild = inputElement.OwnerDocument.ImportNode(xmlDocument.DocumentElement, true);
				parentNode.RemoveChild(inputElement);
				parentNode.AppendChild(newChild);
				return;
			}
			XmlNode xmlNode = parentNode.OwnerDocument.CreateElement(parentNode.Prefix, parentNode.LocalName, parentNode.NamespaceURI);
			try
			{
				parentNode.AppendChild(xmlNode);
				xmlNode.InnerXml = this._encoding.GetString(decryptedData);
				XmlNode xmlNode2 = xmlNode.FirstChild;
				XmlNode nextSibling = inputElement.NextSibling;
				while (xmlNode2 != null)
				{
					XmlNode nextSibling2 = xmlNode2.NextSibling;
					parentNode.InsertBefore(xmlNode2, nextSibling);
					xmlNode2 = nextSibling2;
				}
			}
			finally
			{
				parentNode.RemoveChild(xmlNode);
			}
			parentNode.RemoveChild(inputElement);
		}

		/// <summary>Заменяет указанный элемент заданным объектом <see cref="T:System.Security.Cryptography.Xml.EncryptedData" />.</summary>
		/// <param name="inputElement">Элемент, заменяемый элементом <see langword="&lt;EncryptedData&gt;" />.</param>
		/// <param name="encryptedData">Объект <see cref="T:System.Security.Cryptography.Xml.EncryptedData" />, которым заменяется параметр <paramref name="inputElement" />.</param>
		/// <param name="content">Значение <see langword="true" /> для замены только содержимого элемента; значение <see langword="false" /> для замены всего элемента.</param>
		/// <exception cref="T:System.ArgumentNullException">параметр <paramref name="inputElement" /> имеет значение <see langword="null" />;  
		/// -или- 
		/// параметр <paramref name="encryptedData" /> имеет значение <see langword="null" />;</exception>
		// Token: 0x0600015D RID: 349 RVA: 0x00007448 File Offset: 0x00005648
		public static void ReplaceElement(XmlElement inputElement, EncryptedData encryptedData, bool content)
		{
			if (inputElement == null)
			{
				throw new ArgumentNullException("inputElement");
			}
			if (encryptedData == null)
			{
				throw new ArgumentNullException("encryptedData");
			}
			XmlElement xml = encryptedData.GetXml(inputElement.OwnerDocument);
			if (content)
			{
				Utils.RemoveAllChildren(inputElement);
				inputElement.AppendChild(xml);
				return;
			}
			inputElement.ParentNode.ReplaceChild(xml, inputElement);
		}

		/// <summary>Шифрует ключ с помощью симметричного алгоритма. Этот ключ используется получателем для расшифровки элемента <see langword="&lt;EncryptedData&gt;" />.</summary>
		/// <param name="keyData">Шифруемый ключ.</param>
		/// <param name="symmetricAlgorithm">Симметричный ключ, используемый для шифрования параметра <paramref name="keyData" />.</param>
		/// <returns>Массив байтов, представляющий зашифрованное значение параметра <paramref name="keyData" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">параметр <paramref name="keyData" /> имеет значение <see langword="null" />;  
		/// -или- 
		/// параметр <paramref name="symmetricAlgorithm" /> имеет значение <see langword="null" />;</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значением параметра <paramref name="symmetricAlgorithm" /> не является алгоритм шифрования ключей Triple DES или AES (который также называется Rijndael).</exception>
		// Token: 0x0600015E RID: 350 RVA: 0x000074A0 File Offset: 0x000056A0
		public static byte[] EncryptKey(byte[] keyData, SymmetricAlgorithm symmetricAlgorithm)
		{
			if (keyData == null)
			{
				throw new ArgumentNullException("keyData");
			}
			if (symmetricAlgorithm == null)
			{
				throw new ArgumentNullException("symmetricAlgorithm");
			}
			if (symmetricAlgorithm is TripleDES)
			{
				return SymmetricKeyWrap.TripleDESKeyWrapEncrypt(symmetricAlgorithm.Key, keyData);
			}
			if (symmetricAlgorithm is Rijndael || symmetricAlgorithm is Aes)
			{
				return SymmetricKeyWrap.AESKeyWrapEncrypt(symmetricAlgorithm.Key, keyData);
			}
			throw new CryptographicException("The specified cryptographic transform is not supported.");
		}

		/// <summary>Шифрует ключ, используемый получателем для расшифровки элемента <see langword="&lt;EncryptedData&gt;" />.</summary>
		/// <param name="keyData">Шифруемый ключ.</param>
		/// <param name="rsa">Асимметричный ключ, используемый для шифрования параметра <paramref name="keyData" />.</param>
		/// <param name="useOAEP">Значение, указывающее, следует ли использовать заполнение OAEP.</param>
		/// <returns>Массив байтов, представляющий зашифрованное значение параметра <paramref name="keyData" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">параметр <paramref name="keyData" /> имеет значение <see langword="null" />;  
		/// -или- 
		/// параметр <paramref name="rsa" /> имеет значение <see langword="null" />;</exception>
		// Token: 0x0600015F RID: 351 RVA: 0x00007505 File Offset: 0x00005705
		public static byte[] EncryptKey(byte[] keyData, RSA rsa, bool useOAEP)
		{
			if (keyData == null)
			{
				throw new ArgumentNullException("keyData");
			}
			if (rsa == null)
			{
				throw new ArgumentNullException("rsa");
			}
			if (useOAEP)
			{
				return new RSAOAEPKeyExchangeFormatter(rsa).CreateKeyExchange(keyData);
			}
			return new RSAPKCS1KeyExchangeFormatter(rsa).CreateKeyExchange(keyData);
		}

		/// <summary>Расшифровывает элемент <see langword="&lt;EncryptedKey&gt;" /> с помощью симметричного алгоритма.</summary>
		/// <param name="keyData">Массив байтов, представляющий зашифрованный элемент <see langword="&lt;EncryptedKey&gt;" />.</param>
		/// <param name="symmetricAlgorithm">Симметричный ключ, используемый для расшифровки объекта <paramref name="keyData" />.</param>
		/// <returns>Массив байтов, который содержит ключ в виде обычного текста.</returns>
		/// <exception cref="T:System.ArgumentNullException">параметр <paramref name="keyData" /> имеет значение <see langword="null" />;  
		/// -или- 
		/// параметр <paramref name="symmetricAlgorithm" /> имеет значение <see langword="null" />;</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значением элемента <paramref name="symmetricAlgorithm" /> не является алгоритм шифрования ключей Triple DES или AES (который также называется Rijndael).</exception>
		// Token: 0x06000160 RID: 352 RVA: 0x00007540 File Offset: 0x00005740
		public static byte[] DecryptKey(byte[] keyData, SymmetricAlgorithm symmetricAlgorithm)
		{
			if (keyData == null)
			{
				throw new ArgumentNullException("keyData");
			}
			if (symmetricAlgorithm == null)
			{
				throw new ArgumentNullException("symmetricAlgorithm");
			}
			if (symmetricAlgorithm is TripleDES)
			{
				return SymmetricKeyWrap.TripleDESKeyWrapDecrypt(symmetricAlgorithm.Key, keyData);
			}
			if (symmetricAlgorithm is Rijndael || symmetricAlgorithm is Aes)
			{
				return SymmetricKeyWrap.AESKeyWrapDecrypt(symmetricAlgorithm.Key, keyData);
			}
			throw new CryptographicException("The specified cryptographic transform is not supported.");
		}

		/// <summary>Расшифровывает элемент <see langword="&lt;EncryptedKey&gt;" /> с помощью асимметричного алгоритма.</summary>
		/// <param name="keyData">Массив байтов, представляющий зашифрованный элемент <see langword="&lt;EncryptedKey&gt;" />.</param>
		/// <param name="rsa">Асимметричный ключ, используемый для расшифровки объекта <paramref name="keyData" />.</param>
		/// <param name="useOAEP">Значение, указывающее, следует ли использовать заполнение OAEP.</param>
		/// <returns>Массив байтов, который содержит ключ в виде обычного текста.</returns>
		/// <exception cref="T:System.ArgumentNullException">параметр <paramref name="keyData" /> имеет значение <see langword="null" />;  
		/// -или- 
		/// параметр <paramref name="rsa" /> имеет значение <see langword="null" />;</exception>
		// Token: 0x06000161 RID: 353 RVA: 0x000075A5 File Offset: 0x000057A5
		public static byte[] DecryptKey(byte[] keyData, RSA rsa, bool useOAEP)
		{
			if (keyData == null)
			{
				throw new ArgumentNullException("keyData");
			}
			if (rsa == null)
			{
				throw new ArgumentNullException("rsa");
			}
			if (useOAEP)
			{
				return new RSAOAEPKeyExchangeDeformatter(rsa).DecryptKeyExchange(keyData);
			}
			return new RSAPKCS1KeyExchangeDeformatter(rsa).DecryptKeyExchange(keyData);
		}

		/// <summary>Представляет универсальный код ресурса (URI) пространства имен для синтаксиса и обработки XML-шифрования. Это поле является константой.</summary>
		// Token: 0x0400017D RID: 381
		public const string XmlEncNamespaceUrl = "http://www.w3.org/2001/04/xmlenc#";

		/// <summary>Представляет универсальный код ресурса (URI) пространства имен для элемента XML-шифрования. Это поле является константой.</summary>
		// Token: 0x0400017E RID: 382
		public const string XmlEncElementUrl = "http://www.w3.org/2001/04/xmlenc#Element";

		/// <summary>Представляет универсальный код ресурса (URI) пространства имен для содержимого элемента XML-шифрования. Это поле является константой.</summary>
		// Token: 0x0400017F RID: 383
		public const string XmlEncElementContentUrl = "http://www.w3.org/2001/04/xmlenc#Content";

		/// <summary>Представляет универсальный код ресурса (URI) пространства имен для элемента <see langword="&lt;EncryptedKey&gt;" /> XML-шифрования. Это поле является константой.</summary>
		// Token: 0x04000180 RID: 384
		public const string XmlEncEncryptedKeyUrl = "http://www.w3.org/2001/04/xmlenc#EncryptedKey";

		/// <summary>Представляет универсальный код ресурса (URI) пространства имен для алгоритма DES. Это поле является константой.</summary>
		// Token: 0x04000181 RID: 385
		public const string XmlEncDESUrl = "http://www.w3.org/2001/04/xmlenc#des-cbc";

		/// <summary>Представляет универсальный код ресурса (URI) пространства имен для алгоритма Triple DES. Это поле является константой.</summary>
		// Token: 0x04000182 RID: 386
		public const string XmlEncTripleDESUrl = "http://www.w3.org/2001/04/xmlenc#tripledes-cbc";

		/// <summary>Представляет универсальный код ресурса (URI) пространства имен для 128-разрядного алгоритма AES (который также называется алгоритмом Rijndael). Это поле является константой.</summary>
		// Token: 0x04000183 RID: 387
		public const string XmlEncAES128Url = "http://www.w3.org/2001/04/xmlenc#aes128-cbc";

		/// <summary>Представляет универсальный код ресурса (URI) пространства имен для 256-разрядного алгоритма AES (который также называется алгоритмом Rijndael). Это поле является константой.</summary>
		// Token: 0x04000184 RID: 388
		public const string XmlEncAES256Url = "http://www.w3.org/2001/04/xmlenc#aes256-cbc";

		/// <summary>Представляет универсальный код ресурса (URI) пространства имен для 192-разрядного алгоритма AES (который также называется алгоритмом Rijndael). Это поле является константой.</summary>
		// Token: 0x04000185 RID: 389
		public const string XmlEncAES192Url = "http://www.w3.org/2001/04/xmlenc#aes192-cbc";

		/// <summary>Представляет универсальный код ресурса (URI) пространства имен для алгоритма стандарта шифрования с открытым ключом (PKCS) RSA версии 1.5. Это поле является константой.</summary>
		// Token: 0x04000186 RID: 390
		public const string XmlEncRSA15Url = "http://www.w3.org/2001/04/xmlenc#rsa-1_5";

		/// <summary>Представляет универсальный код ресурса (URI) пространства имен для алгоритма шифрования с заполнением OAEP RSA. Это поле является константой.</summary>
		// Token: 0x04000187 RID: 391
		public const string XmlEncRSAOAEPUrl = "http://www.w3.org/2001/04/xmlenc#rsa-oaep-mgf1p";

		/// <summary>Представляет универсальный код ресурса (URI) пространства имен для алгоритма шифрования ключей TRIPLEDES. Это поле является константой.</summary>
		// Token: 0x04000188 RID: 392
		public const string XmlEncTripleDESKeyWrapUrl = "http://www.w3.org/2001/04/xmlenc#kw-tripledes";

		/// <summary>Представляет универсальный код ресурса (URI) пространства имен для 128-разрядного алгоритма шифрования ключей AES (который также называется алгоритмом шифрования ключей Rijndael). Это поле является константой.</summary>
		// Token: 0x04000189 RID: 393
		public const string XmlEncAES128KeyWrapUrl = "http://www.w3.org/2001/04/xmlenc#kw-aes128";

		/// <summary>Представляет универсальный код ресурса (URI) пространства имен для 256-разрядного алгоритма шифрования ключей AES (который также называется алгоритмом шифрования ключей Rijndael). Это поле является константой.</summary>
		// Token: 0x0400018A RID: 394
		public const string XmlEncAES256KeyWrapUrl = "http://www.w3.org/2001/04/xmlenc#kw-aes256";

		/// <summary>Представляет универсальный код ресурса (URI) пространства имен для 192-разрядного алгоритма шифрования ключей AES (который также называется алгоритмом шифрования ключей Rijndael). Это поле является константой.</summary>
		// Token: 0x0400018B RID: 395
		public const string XmlEncAES192KeyWrapUrl = "http://www.w3.org/2001/04/xmlenc#kw-aes192";

		/// <summary>Представляет универсальный код ресурса (URI) пространства имен для алгоритма SHA-256. Это поле является константой.</summary>
		// Token: 0x0400018C RID: 396
		public const string XmlEncSHA256Url = "http://www.w3.org/2001/04/xmlenc#sha256";

		/// <summary>Представляет универсальный код ресурса (URI) пространства имен для алгоритма SHA-512. Это поле является константой.</summary>
		// Token: 0x0400018D RID: 397
		public const string XmlEncSHA512Url = "http://www.w3.org/2001/04/xmlenc#sha512";

		// Token: 0x0400018E RID: 398
		private XmlDocument _document;

		// Token: 0x0400018F RID: 399
		private Evidence _evidence;

		// Token: 0x04000190 RID: 400
		private XmlResolver _xmlResolver;

		// Token: 0x04000191 RID: 401
		private const int _capacity = 4;

		// Token: 0x04000192 RID: 402
		private Hashtable _keyNameMapping;

		// Token: 0x04000193 RID: 403
		private PaddingMode _padding;

		// Token: 0x04000194 RID: 404
		private CipherMode _mode;

		// Token: 0x04000195 RID: 405
		private Encoding _encoding;

		// Token: 0x04000196 RID: 406
		private string _recipient;

		// Token: 0x04000197 RID: 407
		private int _xmlDsigSearchDepthCounter;

		// Token: 0x04000198 RID: 408
		private int _xmlDsigSearchDepth;
	}
}
