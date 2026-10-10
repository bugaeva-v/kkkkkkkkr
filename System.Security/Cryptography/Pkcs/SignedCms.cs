using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Asn1;
using System.Security.Cryptography.Pkcs.Asn1;
using System.Security.Cryptography.X509Certificates;
using Internal.Cryptography;

namespace System.Security.Cryptography.Pkcs
{
	/// <summary>Класс <see cref="T:System.Security.Cryptography.Pkcs.SignedCms" /> обеспечивает подписывание и проверку сообщений CMS/PKCS 7.</summary>
	// Token: 0x02000084 RID: 132
	public sealed class SignedCms
	{
		// Token: 0x0600043C RID: 1084 RVA: 0x00012EC0 File Offset: 0x000110C0
		private static ContentInfo MakeEmptyContentInfo()
		{
			return new ContentInfo(new Oid(SignedCms.s_cmsDataOid), Array.Empty<byte>());
		}

		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.SignedCms.#ctor" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.SignedCms" />.</summary>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		// Token: 0x0600043D RID: 1085 RVA: 0x00012ED6 File Offset: 0x000110D6
		public SignedCms() : this(SubjectIdentifierType.IssuerAndSerialNumber, SignedCms.MakeEmptyContentInfo(), false)
		{
		}

		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.SignedCms.#ctor(System.Security.Cryptography.Pkcs.SubjectIdentifierType)" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.SignedCms" />, используя в качестве типа идентификатора субъекта по умолчанию для подписавших указанный тип идентификатора субъекта.</summary>
		/// <param name="signerIdentifierType">Член перечисления <see cref="T:System.Security.Cryptography.Pkcs.SubjectIdentifierType" />, который определяет тип идентификатора субъекта по умолчанию для подписавших.</param>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		// Token: 0x0600043E RID: 1086 RVA: 0x00012EE5 File Offset: 0x000110E5
		public SignedCms(SubjectIdentifierType signerIdentifierType) : this(signerIdentifierType, SignedCms.MakeEmptyContentInfo(), false)
		{
		}

		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.SignedCms.#ctor(System.Security.Cryptography.Pkcs.ContentInfo)" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.SignedCms" />, используя в качестве внутреннего содержимого указанную информацию о содержимом.</summary>
		/// <param name="contentInfo">Объект <see cref="T:System.Security.Cryptography.Pkcs.ContentInfo" />, который определяет информацию о содержимом, используемую в качестве внутреннего содержимого сообщения <see cref="T:System.Security.Cryptography.Pkcs.SignedCms" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		// Token: 0x0600043F RID: 1087 RVA: 0x00012EF4 File Offset: 0x000110F4
		public SignedCms(ContentInfo contentInfo) : this(SubjectIdentifierType.IssuerAndSerialNumber, contentInfo, false)
		{
		}

		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.SignedCms.#ctor(System.Security.Cryptography.Pkcs.SubjectIdentifierType,System.Security.Cryptography.Pkcs.ContentInfo)" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.SignedCms" />, используя в качестве типа идентификатора субъекта по умолчанию для подписавших указанный тип идентификатора субъекта и используя в качестве внутреннего содержимого информацию о содержимом.</summary>
		/// <param name="signerIdentifierType">Член перечисления <see cref="T:System.Security.Cryptography.Pkcs.SubjectIdentifierType" />, который определяет тип идентификатора субъекта по умолчанию для подписавших.</param>
		/// <param name="contentInfo">Объект <see cref="T:System.Security.Cryptography.Pkcs.ContentInfo" />, который определяет информацию о содержимом, используемую в качестве внутреннего содержимого сообщения <see cref="T:System.Security.Cryptography.Pkcs.SignedCms" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		// Token: 0x06000440 RID: 1088 RVA: 0x00012EFF File Offset: 0x000110FF
		public SignedCms(SubjectIdentifierType signerIdentifierType, ContentInfo contentInfo) : this(signerIdentifierType, contentInfo, false)
		{
		}

		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.SignedCms.#ctor(System.Security.Cryptography.Pkcs.ContentInfo,System.Boolean)" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.SignedCms" />, используя в качестве внутреннего содержимого указанную информацию о содержимом и используя отсоединенное состояние.</summary>
		/// <param name="contentInfo">Объект <see cref="T:System.Security.Cryptography.Pkcs.ContentInfo" />, который определяет информацию о содержимом, используемую в качестве внутреннего содержимого сообщения <see cref="T:System.Security.Cryptography.Pkcs.SignedCms" />.</param>
		/// <param name="detached">Значение типа <see cref="T:System.Boolean" />, которое определяет, что  объект <see cref="T:System.Security.Cryptography.Pkcs.SignedCms" /> предназначен для отсоединенной подписи. Если свойство <paramref name="detached" /> имеет значение <see langword="true" />, подпись отсоединяется. Если свойство <paramref name="detached" /> имеет значение <see langword="false" />, подпись не отсоединяется.</param>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		// Token: 0x06000441 RID: 1089 RVA: 0x00012F0A File Offset: 0x0001110A
		public SignedCms(ContentInfo contentInfo, bool detached) : this(SubjectIdentifierType.IssuerAndSerialNumber, contentInfo, detached)
		{
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.SignedCms.Version" /> возвращает версию сообщения CMS/PKCS 7.</summary>
		/// <returns>Целочисленное значение, представляющее версию сообщения CMS/PKCS 7.</returns>
		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x00012F15 File Offset: 0x00011115
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x00012F1D File Offset: 0x0001111D
		public int Version { get; private set; }

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.SignedCms.ContentInfo" /> возвращает внутреннее содержимое закодированного сообщения CMS/PKCS 7.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Pkcs.ContentInfo" />, который представляет содержимое закодированного сообщения CMS/PKCS 7.</returns>
		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x00012F26 File Offset: 0x00011126
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x00012F2E File Offset: 0x0001112E
		public ContentInfo ContentInfo { get; private set; }

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.SignedCms.Detached" /> определяет, предназначен ли объект <see cref="T:System.Security.Cryptography.Pkcs.SignedCms" /> для отсоединенной подписи.</summary>
		/// <returns>Значение типа <see cref="T:System.Boolean" />, которое определяет, что  объект <see cref="T:System.Security.Cryptography.Pkcs.SignedCms" /> предназначен для отсоединенной подписи. Если это свойство имеет значение <see langword="true" />, подпись отсоединяется. Если это свойство имеет значение <see langword="false" />, подпись не отсоединяется.</returns>
		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x00012F37 File Offset: 0x00011137
		// (set) Token: 0x06000447 RID: 1095 RVA: 0x00012F3F File Offset: 0x0001113F
		public bool Detached { get; private set; }

		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.SignedCms.#ctor(System.Security.Cryptography.Pkcs.SubjectIdentifierType,System.Security.Cryptography.Pkcs.ContentInfo,System.Boolean)" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.SignedCms" />, используя в качестве типа идентификатора субъекта по умолчанию для подписавших указанный тип идентификатора субъекта, используя в качестве внутреннего содержимого информацию о содержимом и используя отсоединенное состояние.</summary>
		/// <param name="signerIdentifierType">Член перечисления <see cref="T:System.Security.Cryptography.Pkcs.SubjectIdentifierType" />, который определяет тип идентификатора субъекта по умолчанию для подписавших.</param>
		/// <param name="contentInfo">Объект <see cref="T:System.Security.Cryptography.Pkcs.ContentInfo" />, который определяет информацию о содержимом, используемую в качестве внутреннего содержимого сообщения <see cref="T:System.Security.Cryptography.Pkcs.SignedCms" />.</param>
		/// <param name="detached">Значение типа <see cref="T:System.Boolean" />, которое определяет, что  объект <see cref="T:System.Security.Cryptography.Pkcs.SignedCms" /> предназначен для отсоединенной подписи. Если свойство <paramref name="detached" /> имеет значение <see langword="true" />, подпись отсоединяется. Если свойство detached имеет значение <see langword="false" />, подпись не отсоединяется.</param>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		// Token: 0x06000448 RID: 1096 RVA: 0x00012F48 File Offset: 0x00011148
		public SignedCms(SubjectIdentifierType signerIdentifierType, ContentInfo contentInfo, bool detached)
		{
			if (contentInfo == null)
			{
				throw new ArgumentNullException("contentInfo");
			}
			if (contentInfo.Content == null)
			{
				throw new ArgumentNullException("contentInfo.Content");
			}
			this.ContentInfo = contentInfo;
			this.Detached = detached;
			this.Version = 0;
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.SignedCms.Certificates" /> возвращает сертификаты, связанные с закодированным сообщением CMS/PKCS 7.</summary>
		/// <returns>Коллекция <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />, которая представляет набор сертификатов для закодированного сообщения CMS/PKCS 7.</returns>
		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x00012F88 File Offset: 0x00011188
		public X509Certificate2Collection Certificates
		{
			get
			{
				X509Certificate2Collection x509Certificate2Collection = new X509Certificate2Collection();
				if (!this._hasData)
				{
					return x509Certificate2Collection;
				}
				CertificateChoiceAsn[] certificateSet = this._signedData.CertificateSet;
				if (certificateSet == null)
				{
					return x509Certificate2Collection;
				}
				foreach (CertificateChoiceAsn certificateChoiceAsn in certificateSet)
				{
					x509Certificate2Collection.Add(new X509Certificate2(certificateChoiceAsn.Certificate.Value.ToArray()));
				}
				return x509Certificate2Collection;
			}
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.SignedCms.SignerInfos" /> возвращает коллекцию <see cref="T:System.Security.Cryptography.Pkcs.SignerInfoCollection" />, связанную с сообщением CMS/PKCS 7.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Pkcs.SignerInfoCollection" />, который представляет информацию о подписавшем сообщения CMS/PKCS 7.</returns>
		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x00012FF1 File Offset: 0x000111F1
		public SignerInfoCollection SignerInfos
		{
			get
			{
				if (!this._hasData)
				{
					return new SignerInfoCollection();
				}
				return new SignerInfoCollection(this._signedData.SignerInfos, this);
			}
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.SignedCms.Encode" /> кодирует информацию в объекте в сообщение CMS/PKCS 7.</summary>
		/// <returns>Массив байтовых значений, представляющий закодированное сообщение. Закодированное сообщение можно раскодировать с помощью метода <see cref="M:System.Security.Cryptography.Pkcs.SignedCms.Decode(System.Byte[])" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Завершение операции шифрования невозможно.</exception>
		/// <exception cref="T:System.InvalidOperationException">Вызов метода был недопустим для текущего состояния объекта.</exception>
		// Token: 0x0600044B RID: 1099 RVA: 0x00013014 File Offset: 0x00011214
		public byte[] Encode()
		{
			if (!this._hasData)
			{
				throw new InvalidOperationException("The CMS message is not signed.");
			}
			byte[] result;
			try
			{
				result = Helpers.EncodeContentInfo<SignedDataAsn>(this._signedData, "1.2.840.113549.1.7.2", AsnEncodingRules.DER);
			}
			catch (CryptographicException)
			{
				if (this.Detached)
				{
					throw;
				}
				SignedDataAsn value = this._signedData;
				value.EncapContentInfo.Content = null;
				using (AsnWriter asnWriter = AsnSerializer.Serialize<SignedDataAsn>(value, AsnEncodingRules.DER))
				{
					value = AsnSerializer.Deserialize<SignedDataAsn>(asnWriter.Encode(), AsnEncodingRules.BER);
				}
				value.EncapContentInfo.Content = this._signedData.EncapContentInfo.Content;
				result = Helpers.EncodeContentInfo<SignedDataAsn>(value, "1.2.840.113549.1.7.2", AsnEncodingRules.BER);
			}
			return result;
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.SignedCms.Decode(System.Byte[])" /> раскодирует закодированное сообщение <see cref="T:System.Security.Cryptography.Pkcs.SignedCms" />. После успешного раскодирования раскодированную информацию можно получить с помощью свойств объекта <see cref="T:System.Security.Cryptography.Pkcs.SignedCms" />.</summary>
		/// <param name="encodedMessage">Массив байтовых значений, представляющий закодированное сообщение CMS/PKCS 7, подлежащее раскодированию.</param>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Завершение операции шифрования невозможно.</exception>
		// Token: 0x0600044C RID: 1100 RVA: 0x000130DC File Offset: 0x000112DC
		public void Decode(byte[] encodedMessage)
		{
			if (encodedMessage == null)
			{
				throw new ArgumentNullException("encodedMessage");
			}
			this.Decode(new ReadOnlyMemory<byte>(encodedMessage));
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x000130F8 File Offset: 0x000112F8
		internal void Decode(ReadOnlyMemory<byte> encodedMessage)
		{
			int num;
			ContentInfoAsn contentInfoAsn = AsnSerializer.Deserialize<ContentInfoAsn>(encodedMessage, AsnEncodingRules.BER, out num);
			if (contentInfoAsn.ContentType != "1.2.840.113549.1.7.2")
			{
				throw new CryptographicException("Invalid cryptographic message type.");
			}
			this._heldData = contentInfoAsn.Content.ToArray();
			this._signedData = AsnSerializer.Deserialize<SignedDataAsn>(this._heldData, AsnEncodingRules.BER);
			this._contentType = this._signedData.EncapContentInfo.ContentType;
			this._hasPkcs7Content = false;
			if (!this.Detached)
			{
				ReadOnlyMemory<byte>? content = this._signedData.EncapContentInfo.Content;
				ReadOnlyMemory<byte> value;
				if (content != null)
				{
					value = SignedCms.GetContent(content.Value, this._contentType);
					this._hasPkcs7Content = (content.Value.Length == value.Length);
				}
				else
				{
					value = ReadOnlyMemory<byte>.Empty;
				}
				this._heldContent = new ReadOnlyMemory<byte>?(value);
				this.ContentInfo = new ContentInfo(new Oid(this._contentType), value.ToArray());
			}
			else
			{
				this._heldContent = new ReadOnlyMemory<byte>?(this.ContentInfo.Content.CloneByteArray());
			}
			this.Version = this._signedData.Version;
			this._hasData = true;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00013238 File Offset: 0x00011438
		internal static ReadOnlyMemory<byte> GetContent(ReadOnlyMemory<byte> wrappedContent, string contentType)
		{
			byte[] array = null;
			int length = 0;
			try
			{
				AsnReader asnReader = new AsnReader(wrappedContent, AsnEncodingRules.BER);
				ReadOnlyMemory<byte> result;
				if (asnReader.TryGetPrimitiveOctetStringBytes(out result))
				{
					return result;
				}
				array = ArrayPool<byte>.Shared.Rent(wrappedContent.Length);
				if (!asnReader.TryCopyOctetStringBytes(array, out length))
				{
					throw new CryptographicException();
				}
				return array.AsSpan(0, length).ToArray();
			}
			catch (Exception)
			{
				if (contentType == "1.2.840.113549.1.7.1")
				{
					throw;
				}
			}
			finally
			{
				if (array != null)
				{
					array.AsSpan(0, length).Clear();
					ArrayPool<byte>.Shared.Return(array, false);
				}
			}
			return wrappedContent;
		}

		/// <summary>Создает подпись и добавляет ее к сообщению CMS/PKCS 7.</summary>
		/// <exception cref="T:System.InvalidOperationException">.NET Framework (все версии) и .NET Core 3.0 и более поздние версии: не указан сертификат получателя.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">.NET Core версии 2.2 и более ранние версии: не указан сертификат подписавшего.</exception>
		// Token: 0x0600044F RID: 1103 RVA: 0x000132F8 File Offset: 0x000114F8
		public void ComputeSignature()
		{
			throw new PlatformNotSupportedException("No signer certificate was provided. This platform does not implement the certificate picker UI.");
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.SignedCms.ComputeSignature(System.Security.Cryptography.Pkcs.CmsSigner)" /> создает подпись для указанного подписавшего и добавляет эту подпись к сообщению CMS/PKCS 7.</summary>
		/// <param name="signer">Объект <see cref="T:System.Security.Cryptography.Pkcs.CmsSigner" />, представляющий подписавшего.</param>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Завершение операции шифрования невозможно.</exception>
		// Token: 0x06000450 RID: 1104 RVA: 0x00013304 File Offset: 0x00011504
		public void ComputeSignature(CmsSigner signer)
		{
			this.ComputeSignature(signer, true);
		}

		/// <summary>Создает подпись для указанного подписавшего и добавляет эту подпись к сообщению CMS/PKCS 7.</summary>
		/// <param name="signer">Объект <see cref="T:System.Security.Cryptography.Pkcs.CmsSigner" />, представляющий подписавшего.</param>
		/// <param name="silent">Этот параметр не используется.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="signer" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Завершение операции шифрования невозможно.</exception>
		/// <exception cref="T:System.InvalidOperationException">Только .NET Framework: сертификат для подписи не указан.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Только .NET Core: сертификат для подписи не указан.</exception>
		// Token: 0x06000451 RID: 1105 RVA: 0x00013310 File Offset: 0x00011510
		public void ComputeSignature(CmsSigner signer, bool silent)
		{
			if (signer == null)
			{
				throw new ArgumentNullException("signer");
			}
			if (this.ContentInfo.Content.Length == 0)
			{
				throw new CryptographicException("Cannot create CMS signature for empty content.");
			}
			ReadOnlyMemory<byte> data = this._heldContent ?? this.ContentInfo.Content;
			string text;
			if ((text = this._contentType) == null)
			{
				text = (this.ContentInfo.ContentType.Value ?? "1.2.840.113549.1.7.1");
			}
			string text2 = text;
			X509Certificate2Collection newCerts;
			SignerInfoAsn signerInfoAsn = signer.Sign(data, text2, silent, out newCerts);
			bool flag = false;
			if (!this._hasData)
			{
				flag = true;
				this._signedData = new SignedDataAsn
				{
					DigestAlgorithms = Array.Empty<AlgorithmIdentifierAsn>(),
					SignerInfos = Array.Empty<SignerInfoAsn>(),
					EncapContentInfo = new EncapsulatedContentInfoAsn
					{
						ContentType = text2
					}
				};
				if (!this.Detached)
				{
					using (AsnWriter asnWriter = new AsnWriter(AsnEncodingRules.DER))
					{
						asnWriter.WriteOctetString(data.Span);
						this._signedData.EncapContentInfo.Content = new ReadOnlyMemory<byte>?(asnWriter.Encode());
					}
				}
				this._hasData = true;
			}
			int num = this._signedData.SignerInfos.Length;
			Array.Resize<SignerInfoAsn>(ref this._signedData.SignerInfos, num + 1);
			this._signedData.SignerInfos[num] = signerInfoAsn;
			this.UpdateCertificatesFromAddition(newCerts);
			this.ConsiderDigestAddition(signerInfoAsn.DigestAlgorithm);
			this.UpdateMetadata();
			if (flag)
			{
				this.Reencode();
			}
		}

		/// <summary>Удаляет подпись с указанным индексом из коллекции <see cref="P:System.Security.Cryptography.Pkcs.SignedCms.SignerInfos" />.</summary>
		/// <param name="index">Индекс подписи (начиная с нуля), которую требуется удалить.</param>
		/// <exception cref="T:System.InvalidOperationException">Сообщение CMS/PKCS 7 Не имеет подписи, и <paramref name="index" /> является недействительным.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		///
		/// или - 
		/// <paramref name="index" /> больше чем номер в подписи минус 1.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Не удалось удалить сигнатуру.  
		///
		/// или - 
		/// Произошла внутренняя ошибка шифрования.</exception>
		// Token: 0x06000452 RID: 1106 RVA: 0x000134B0 File Offset: 0x000116B0
		public void RemoveSignature(int index)
		{
			if (!this._hasData)
			{
				throw new InvalidOperationException("The CMS message is not signed.");
			}
			if (index < 0 || index >= this._signedData.SignerInfos.Length)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			AlgorithmIdentifierAsn digestAlgorithm = this._signedData.SignerInfos[index].DigestAlgorithm;
			Helpers.RemoveAt<SignerInfoAsn>(ref this._signedData.SignerInfos, index);
			this.ConsiderDigestRemoval(digestAlgorithm);
			this.UpdateMetadata();
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.SignedCms.RemoveSignature(System.Security.Cryptography.Pkcs.SignerInfo)" /> удаляет подпись для указанного объекта <see cref="T:System.Security.Cryptography.Pkcs.SignerInfo" />.</summary>
		/// <param name="signerInfo">Объект <see cref="T:System.Security.Cryptography.Pkcs.SignerInfo" />, который представляет удаляемую подпись другой стороны.</param>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение аргумента находится вне допустимого диапазона значений, определенного вызываемым методом.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Завершение операции шифрования невозможно.</exception>
		// Token: 0x06000453 RID: 1107 RVA: 0x0001352C File Offset: 0x0001172C
		public void RemoveSignature(SignerInfo signerInfo)
		{
			if (signerInfo == null)
			{
				throw new ArgumentNullException("signerInfo");
			}
			int num = this.SignerInfos.FindIndexForSigner(signerInfo);
			if (num < 0)
			{
				throw new CryptographicException("Cannot find the original signer.");
			}
			this.RemoveSignature(num);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0001356C File Offset: 0x0001176C
		internal ReadOnlySpan<byte> GetHashableContentSpan()
		{
			ReadOnlyMemory<byte> value = this._heldContent.Value;
			if (!this._hasPkcs7Content)
			{
				return value.Span;
			}
			return new AsnReader(value, AsnEncodingRules.BER).PeekContentBytes().Span;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x000135AC File Offset: 0x000117AC
		internal void Reencode()
		{
			ContentInfo contentInfo = this.ContentInfo;
			try
			{
				byte[] encodedMessage = this.Encode();
				if (this.Detached)
				{
					this._heldContent = null;
				}
				this.Decode(encodedMessage);
			}
			finally
			{
				this.ContentInfo = contentInfo;
			}
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x000135FC File Offset: 0x000117FC
		private void UpdateMetadata()
		{
			int version = 1;
			if ((this._contentType ?? this.ContentInfo.ContentType.Value) != "1.2.840.113549.1.7.1")
			{
				version = 3;
			}
			else if (this._signedData.SignerInfos.Any((SignerInfoAsn si) => si.Version == 3))
			{
				version = 3;
			}
			this.Version = version;
			this._signedData.Version = version;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0001367C File Offset: 0x0001187C
		private void ConsiderDigestAddition(AlgorithmIdentifierAsn candidate)
		{
			int num = this._signedData.DigestAlgorithms.Length;
			for (int i = 0; i < num; i++)
			{
				ref AlgorithmIdentifierAsn other = ref this._signedData.DigestAlgorithms[i];
				if (candidate.Equals(ref other))
				{
					return;
				}
			}
			Array.Resize<AlgorithmIdentifierAsn>(ref this._signedData.DigestAlgorithms, num + 1);
			this._signedData.DigestAlgorithms[num] = candidate;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x000136E8 File Offset: 0x000118E8
		private void ConsiderDigestRemoval(AlgorithmIdentifierAsn candidate)
		{
			bool flag = true;
			for (int i = 0; i < this._signedData.SignerInfos.Length; i++)
			{
				ref AlgorithmIdentifierAsn other = ref this._signedData.SignerInfos[i].DigestAlgorithm;
				if (candidate.Equals(ref other))
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				return;
			}
			for (int j = 0; j < this._signedData.DigestAlgorithms.Length; j++)
			{
				ref AlgorithmIdentifierAsn other2 = ref this._signedData.DigestAlgorithms[j];
				if (candidate.Equals(ref other2))
				{
					Helpers.RemoveAt<AlgorithmIdentifierAsn>(ref this._signedData.DigestAlgorithms, j);
					return;
				}
			}
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00013780 File Offset: 0x00011980
		internal void UpdateCertificatesFromAddition(X509Certificate2Collection newCerts)
		{
			if (newCerts.Count == 0)
			{
				return;
			}
			CertificateChoiceAsn[] certificateSet = this._signedData.CertificateSet;
			int num = (certificateSet != null) ? certificateSet.Length : 0;
			if (num > 0 || newCerts.Count > 1)
			{
				HashSet<X509Certificate2> hashSet = new HashSet<X509Certificate2>(this.Certificates.OfType<X509Certificate2>());
				for (int i = 0; i < newCerts.Count; i++)
				{
					X509Certificate2 item = newCerts[i];
					if (!hashSet.Add(item))
					{
						newCerts.RemoveAt(i);
						i--;
					}
				}
			}
			if (newCerts.Count == 0)
			{
				return;
			}
			if (this._signedData.CertificateSet == null)
			{
				this._signedData.CertificateSet = new CertificateChoiceAsn[newCerts.Count];
			}
			else
			{
				Array.Resize<CertificateChoiceAsn>(ref this._signedData.CertificateSet, num + newCerts.Count);
			}
			for (int j = num; j < this._signedData.CertificateSet.Length; j++)
			{
				this._signedData.CertificateSet[j] = new CertificateChoiceAsn
				{
					Certificate = new ReadOnlyMemory<byte>?(newCerts[j - num].RawData)
				};
			}
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.SignedCms.CheckSignature(System.Boolean)" /> проверяет цифровые подписи подписанного сообщения CMS/PKCS 7 и, при необходимости, сертификаты подписавших.</summary>
		/// <param name="verifySignatureOnly">Значение типа <see cref="T:System.Boolean" />, которое определяет, следует ли проверять только цифровые подписи без проверки сертификатов подписавших.  
		/// Если параметр <paramref name="verifySignatureOnly" /> имеет значение <see langword="true" />, будут проверяться только цифровые подписи. Если значение равно <see langword="false" />, проверяются цифровые подписи, сертификаты подписавших и назначения сертификатов. Назначение сертификата считается действительным, если в сертификате не используется ключ или если ключ поддерживает цифровые подписи или неподдельность.</param>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Завершение операции шифрования невозможно.</exception>
		/// <exception cref="T:System.InvalidOperationException">Вызов метода был недопустим для текущего состояния объекта.</exception>
		// Token: 0x0600045A RID: 1114 RVA: 0x00013894 File Offset: 0x00011A94
		public void CheckSignature(bool verifySignatureOnly)
		{
			this.CheckSignature(new X509Certificate2Collection(), verifySignatureOnly);
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.SignedCms.CheckSignature(System.Security.Cryptography.X509Certificates.X509Certificate2Collection,System.Boolean)" /> проверяет цифровые подписи подписанного сообщения CMS/PKCS 7, используя указанную коллекцию сертификатов, и, при необходимости, сертификаты подписавших.</summary>
		/// <param name="extraStore">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />, который может использоваться для проверки цепочки сертификатов. Если при проверке цепочки сертификатов не будут использоваться дополнительные сертификаты, используйте метод <see cref="M:System.Security.Cryptography.Pkcs.SignedCms.CheckSignature(System.Boolean)" /> вместо <see cref="M:System.Security.Cryptography.Pkcs.SignedCms.CheckSignature(System.Security.Cryptography.X509Certificates.X509Certificate2Collection,System.Boolean)" />.</param>
		/// <param name="verifySignatureOnly">Значение типа <see cref="T:System.Boolean" />, которое определяет, следует ли проверять только цифровые подписи без проверки сертификатов подписавших.  
		/// Если параметр <paramref name="verifySignatureOnly" /> имеет значение <see langword="true" />, будут проверяться только цифровые подписи. Если значение равно <see langword="false" />, проверяются цифровые подписи, сертификаты подписавших и назначения сертификатов. Назначение сертификата считается действительным, если в сертификате не используется ключ или если ключ поддерживает цифровые подписи или неподдельность.</param>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Завершение операции шифрования невозможно.</exception>
		/// <exception cref="T:System.InvalidOperationException">Вызов метода был недопустим для текущего состояния объекта.</exception>
		// Token: 0x0600045B RID: 1115 RVA: 0x000138A2 File Offset: 0x00011AA2
		public void CheckSignature(X509Certificate2Collection extraStore, bool verifySignatureOnly)
		{
			if (!this._hasData)
			{
				throw new InvalidOperationException("The CMS message is not signed.");
			}
			if (extraStore == null)
			{
				throw new ArgumentNullException("extraStore");
			}
			SignedCms.CheckSignatures(this.SignerInfos, extraStore, verifySignatureOnly);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x000138D4 File Offset: 0x00011AD4
		private static void CheckSignatures(SignerInfoCollection signers, X509Certificate2Collection extraStore, bool verifySignatureOnly)
		{
			if (signers.Count < 1)
			{
				throw new CryptographicException("The signed cryptographic message does not have a signer for the specified signer index.");
			}
			foreach (SignerInfo signerInfo in signers)
			{
				signerInfo.CheckSignature(extraStore, verifySignatureOnly);
				SignerInfoCollection counterSignerInfos = signerInfo.CounterSignerInfos;
				if (counterSignerInfos.Count > 0)
				{
					SignedCms.CheckSignatures(counterSignerInfos, extraStore, verifySignatureOnly);
				}
			}
		}

		/// <summary>Метод <see cref="M:System.Security.Cryptography.Pkcs.SignedCms.CheckHash" /> проверяет целостность данных сообщения CMS/PKCS 7. Метод <see cref="M:System.Security.Cryptography.Pkcs.SignedCms.CheckHash" /> является специализированным методом, используемым в специальных приложениях инфраструктуры безопасности, которым требуется проверить только хэш CMS-сообщения, а не выполнять полную проверку цифровой подписи. Метод <see cref="M:System.Security.Cryptography.Pkcs.SignedCms.CheckHash" /> не проверяет подлинность автора или отправителя сообщения, поскольку он не выполняет проверку цифровой подписи. В общем случае для проверки целостности и подлинности сообщений CMS/PKCS 7 следует использовать методы <see cref="M:System.Security.Cryptography.Pkcs.SignedCms.CheckSignature(System.Boolean)" /> и <see cref="M:System.Security.Cryptography.Pkcs.SignedCms.CheckSignature(System.Security.Cryptography.X509Certificates.X509Certificate2Collection,System.Boolean)" />.</summary>
		/// <exception cref="T:System.InvalidOperationException">Вызов метода был недопустим для текущего состояния объекта.</exception>
		// Token: 0x0600045D RID: 1117 RVA: 0x0001392C File Offset: 0x00011B2C
		public void CheckHash()
		{
			if (!this._hasData)
			{
				throw new InvalidOperationException("The CMS message is not signed.");
			}
			SignerInfoCollection signerInfos = this.SignerInfos;
			if (signerInfos.Count < 1)
			{
				throw new CryptographicException("The signed cryptographic message does not have a signer for the specified signer index.");
			}
			foreach (SignerInfo signerInfo in signerInfos)
			{
				if (signerInfo.SignerIdentifier.Type == SubjectIdentifierType.NoSignature)
				{
					signerInfo.CheckHash();
				}
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00013991 File Offset: 0x00011B91
		internal ref SignedDataAsn GetRawData()
		{
			return ref this._signedData;
		}

		// Token: 0x040002A2 RID: 674
		private static readonly Oid s_cmsDataOid = Oid.FromOidValue("1.2.840.113549.1.7.1", OidGroup.ExtensionOrAttribute);

		// Token: 0x040002A3 RID: 675
		private SignedDataAsn _signedData;

		// Token: 0x040002A4 RID: 676
		private bool _hasData;

		// Token: 0x040002A5 RID: 677
		private Memory<byte> _heldData;

		// Token: 0x040002A6 RID: 678
		private ReadOnlyMemory<byte>? _heldContent;

		// Token: 0x040002A7 RID: 679
		private bool _hasPkcs7Content;

		// Token: 0x040002A8 RID: 680
		private string _contentType;
	}
}
