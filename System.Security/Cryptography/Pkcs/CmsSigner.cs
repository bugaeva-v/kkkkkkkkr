using System;
using System.Collections.Generic;
using System.Security.Cryptography.Asn1;
using System.Security.Cryptography.Pkcs.Asn1;
using System.Security.Cryptography.X509Certificates;
using Internal.Cryptography;

namespace System.Security.Cryptography.Pkcs
{
	/// <summary>Класс <see cref="T:System.Security.Cryptography.Pkcs.CmsSigner" /> обеспечивает функциональность подписывания.</summary>
	// Token: 0x02000072 RID: 114
	public sealed class CmsSigner
	{
		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.CmsSigner.Certificate" /> возвращает или устанавливает объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />, который представляет сертификат для подписи.</summary>
		/// <returns>
		///   <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> Объект, представляющий сертификат для подписи.</returns>
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00011A88 File Offset: 0x0000FC88
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x00011A90 File Offset: 0x0000FC90
		public X509Certificate2 Certificate { get; set; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x00011A99 File Offset: 0x0000FC99
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x00011AA1 File Offset: 0x0000FCA1
		public AsymmetricAlgorithm PrivateKey { get; set; }

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.CmsSigner.Certificates" /> возвращает коллекцию <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />, которая содержит сертификаты, связанные с подписываемым сообщением.</summary>
		/// <returns>
		///   <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> Коллекции, который представляет коллекцию сертификатов, связанных с подписываемым сообщением.</returns>
		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x00011AAA File Offset: 0x0000FCAA
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x00011AB2 File Offset: 0x0000FCB2
		public X509Certificate2Collection Certificates { get; private set; }

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.CmsSigner.DigestAlgorithm" /> возвращает или устанавливает идентификатор <see cref="T:System.Security.Cryptography.Oid" />, который представляет хэш-алгоритм, использующийся для подписи.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Oid" />, представляющий хэш-алгоритм, использующийся для подписи.</returns>
		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x00011ABB File Offset: 0x0000FCBB
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x00011AC3 File Offset: 0x0000FCC3
		public Oid DigestAlgorithm { get; set; }

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.CmsSigner.IncludeOption" /> устанавливает или возвращает параметр, который определяет, должны ли в создаваемое сообщение CMS/PKCS 7 включаться корневой сертификат и вся цепочка сертификатов, связанные с сертификатом для подписи.</summary>
		/// <returns>Член перечисления <see cref="T:System.Security.Cryptography.X509Certificates.X509IncludeOption" />, который определяет длину цепочки сертификатов X509, которая должна быть включена в объект <see cref="T:System.Security.Cryptography.Pkcs.CmsSigner" />. Свойство <see cref="P:System.Security.Cryptography.Pkcs.CmsSigner.IncludeOption" /> может принимать одно из следующих значений перечисления <see cref="T:System.Security.Cryptography.X509Certificates.X509IncludeOption" />.  
		///   name 
		///   Значение 
		///   Смысл 
		///  <see cref="F:System.Security.Cryptography.X509Certificates.X509IncludeOption.None" /> 0 
		///   Цепочка сертификатов не включается.  
		///
		///  <see cref="F:System.Security.Cryptography.X509Certificates.X509IncludeOption.ExcludeRoot" /> 1 
		///   Цепочка сертификатов включается за исключением корневого сертификата.  
		///
		///  <see cref="F:System.Security.Cryptography.X509Certificates.X509IncludeOption.EndCertOnly" /> 2 
		///   Включается только конечный сертификат.  
		///
		///  <see cref="F:System.Security.Cryptography.X509Certificates.X509IncludeOption.WholeChain" /> 3 
		///   Цепочка сертификатов включается, в том числе и корневой сертификат.</returns>
		/// <exception cref="T:System.ArgumentException">Один из переданных методу аргументов имеет недопустимое значение.</exception>
		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00011ACC File Offset: 0x0000FCCC
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00011AD4 File Offset: 0x0000FCD4
		public X509IncludeOption IncludeOption { get; set; }

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.CmsSigner.SignedAttributes" /> возвращает коллекцию <see cref="T:System.Security.Cryptography.CryptographicAttributeObjectCollection" /> подписанных атрибутов, связываемых с конечным содержимым <see cref="T:System.Security.Cryptography.Pkcs.SignerInfo" />. Подписанные атрибуты подписываются вместе с указанным содержимым.</summary>
		/// <returns>Коллекция <see cref="T:System.Security.Cryptography.CryptographicAttributeObjectCollection" />, которая представляет подписанные атрибуты. Если подписанные атрибуты отсутствуют, значением свойства является пустая коллекция.</returns>
		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00011ADD File Offset: 0x0000FCDD
		// (set) Token: 0x060003BA RID: 954 RVA: 0x00011AE5 File Offset: 0x0000FCE5
		public CryptographicAttributeObjectCollection SignedAttributes { get; private set; }

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.CmsSigner.UnsignedAttributes" /> возвращает коллекцию <see cref="T:System.Security.Cryptography.CryptographicAttributeObjectCollection" /> неподписанных атрибутов PKCS 9, связываемых с конечным содержимым <see cref="T:System.Security.Cryptography.Pkcs.SignerInfo" />. Неподписанные атрибуты можно изменять. При этом подпись не становится недействительной.</summary>
		/// <returns>Коллекция <see cref="T:System.Security.Cryptography.CryptographicAttributeObjectCollection" />, которая представляет неподписанные атрибуты. Если неподписанные атрибуты отсутствуют, значением свойства является пустая коллекция.</returns>
		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060003BB RID: 955 RVA: 0x00011AEE File Offset: 0x0000FCEE
		// (set) Token: 0x060003BC RID: 956 RVA: 0x00011AF6 File Offset: 0x0000FCF6
		public CryptographicAttributeObjectCollection UnsignedAttributes { get; private set; }

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.CmsSigner.SignerIdentifierType" /> устанавливает и возвращает тип идентификатора подписавшего.</summary>
		/// <returns>Член перечисления <see cref="T:System.Security.Cryptography.Pkcs.SubjectIdentifierType" />, определяющий тип идентификатора подписавшего.</returns>
		/// <exception cref="T:System.ArgumentException">Один из переданных методу аргументов имеет недопустимое значение.</exception>
		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060003BD RID: 957 RVA: 0x00011AFF File Offset: 0x0000FCFF
		// (set) Token: 0x060003BE RID: 958 RVA: 0x00011B07 File Offset: 0x0000FD07
		public SubjectIdentifierType SignerIdentifierType
		{
			get
			{
				return this._signerIdentifierType;
			}
			set
			{
				if (value < SubjectIdentifierType.IssuerAndSerialNumber || value > SubjectIdentifierType.NoSignature)
				{
					throw new ArgumentException(SR.Format("The subject identifier type {0} is not valid.", value));
				}
				this._signerIdentifierType = value;
			}
		}

		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.CmsSigner.#ctor" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.CmsSigner" />, используя тип идентификатора субъекта по умолчанию.</summary>
		// Token: 0x060003BF RID: 959 RVA: 0x00011B2E File Offset: 0x0000FD2E
		public CmsSigner() : this(SubjectIdentifierType.IssuerAndSerialNumber, null)
		{
		}

		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.CmsSigner.#ctor(System.Security.Cryptography.Pkcs.SubjectIdentifierType)" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.CmsSigner" />, используя указанный тип идентификатора субъекта.</summary>
		/// <param name="signerIdentifierType">Член перечисления <see cref="T:System.Security.Cryptography.Pkcs.SubjectIdentifierType" />, определяющий тип идентификатора подписавшего.</param>
		// Token: 0x060003C0 RID: 960 RVA: 0x00011B38 File Offset: 0x0000FD38
		public CmsSigner(SubjectIdentifierType signerIdentifierType) : this(signerIdentifierType, null)
		{
		}

		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.CmsSigner.#ctor(System.Security.Cryptography.X509Certificates.X509Certificate2)" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.CmsSigner" />, используя указанный сертификат для подписи.</summary>
		/// <param name="certificate">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />, представляющий сертификат для подписи.</param>
		// Token: 0x060003C1 RID: 961 RVA: 0x00011B42 File Offset: 0x0000FD42
		public CmsSigner(X509Certificate2 certificate) : this(SubjectIdentifierType.IssuerAndSerialNumber, certificate)
		{
		}

		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.CmsSigner.#ctor(System.Security.Cryptography.CspParameters)" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.CmsSigner" />, используя указанные параметры поставщика служб шифрования. Конструктор <see cref="M:System.Security.Cryptography.Pkcs.CmsSigner.#ctor(System.Security.Cryptography.CspParameters)" /> полезно использовать в случаях, когда известен конкретный поставщик служб шифрования и закрытый ключ для подписи.</summary>
		/// <param name="parameters">Объект <see cref="T:System.Security.Cryptography.CspParameters" />, представляющий набор параметров поставщика служб шифрования для использования.</param>
		// Token: 0x060003C2 RID: 962 RVA: 0x00011B4C File Offset: 0x0000FD4C
		public CmsSigner(CspParameters parameters)
		{
			this.Certificates = new X509Certificate2Collection();
			this.SignedAttributes = new CryptographicAttributeObjectCollection();
			this.UnsignedAttributes = new CryptographicAttributeObjectCollection();
			base..ctor();
			throw new PlatformNotSupportedException();
		}

		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.CmsSigner.#ctor(System.Security.Cryptography.Pkcs.SubjectIdentifierType,System.Security.Cryptography.X509Certificates.X509Certificate2)" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.CmsSigner" />, используя указанный тип идентификатора подписавшего и сертификат для подписи.</summary>
		/// <param name="signerIdentifierType">Член перечисления <see cref="T:System.Security.Cryptography.Pkcs.SubjectIdentifierType" />, определяющий тип идентификатора подписавшего.</param>
		/// <param name="certificate">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />, представляющий сертификат для подписи.</param>
		// Token: 0x060003C3 RID: 963 RVA: 0x00011B7C File Offset: 0x0000FD7C
		public CmsSigner(SubjectIdentifierType signerIdentifierType, X509Certificate2 certificate)
		{
			this.Certificates = new X509Certificate2Collection();
			this.SignedAttributes = new CryptographicAttributeObjectCollection();
			this.UnsignedAttributes = new CryptographicAttributeObjectCollection();
			base..ctor();
			switch (signerIdentifierType)
			{
			case SubjectIdentifierType.Unknown:
				this._signerIdentifierType = SubjectIdentifierType.IssuerAndSerialNumber;
				this.IncludeOption = X509IncludeOption.ExcludeRoot;
				break;
			case SubjectIdentifierType.IssuerAndSerialNumber:
				this._signerIdentifierType = signerIdentifierType;
				this.IncludeOption = X509IncludeOption.ExcludeRoot;
				break;
			case SubjectIdentifierType.SubjectKeyIdentifier:
				this._signerIdentifierType = signerIdentifierType;
				this.IncludeOption = X509IncludeOption.ExcludeRoot;
				break;
			case SubjectIdentifierType.NoSignature:
				this._signerIdentifierType = signerIdentifierType;
				this.IncludeOption = X509IncludeOption.None;
				break;
			default:
				this._signerIdentifierType = SubjectIdentifierType.IssuerAndSerialNumber;
				this.IncludeOption = X509IncludeOption.ExcludeRoot;
				break;
			}
			this.Certificate = certificate;
			this.DigestAlgorithm = new Oid(CmsSigner.s_defaultAlgorithm);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00011C2D File Offset: 0x0000FE2D
		internal void CheckCertificateValue()
		{
			if (this.SignerIdentifierType == SubjectIdentifierType.NoSignature)
			{
				return;
			}
			if (this.Certificate == null)
			{
				throw new PlatformNotSupportedException("No signer certificate was provided. This platform does not implement the certificate picker UI.");
			}
			if (!this.Certificate.HasPrivateKey)
			{
				throw new CryptographicException("A certificate with a private key is required.");
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00011C64 File Offset: 0x0000FE64
		internal SignerInfoAsn Sign(ReadOnlyMemory<byte> data, string contentTypeOid, bool silent, out X509Certificate2Collection chainCerts)
		{
			HashAlgorithmName digestAlgorithm = Helpers.GetDigestAlgorithm(this.DigestAlgorithm);
			IncrementalHash hasher = IncrementalHash.CreateHash(digestAlgorithm);
			hasher.AppendData(data.Span);
			byte[] hashAndReset = hasher.GetHashAndReset();
			SignerInfoAsn result = default(SignerInfoAsn);
			result.DigestAlgorithm.Algorithm = this.DigestAlgorithm;
			CryptographicAttributeObjectCollection signedAttributes = this.SignedAttributes;
			if ((signedAttributes != null && signedAttributes.Count > 0) || contentTypeOid != "1.2.840.113549.1.7.1")
			{
				List<AttributeAsn> list = CmsSigner.BuildAttributes(this.SignedAttributes);
				using (AsnWriter asnWriter = new AsnWriter(AsnEncodingRules.DER))
				{
					asnWriter.PushSetOf();
					asnWriter.WriteOctetString(hashAndReset);
					asnWriter.PopSetOf();
					list.Add(new AttributeAsn
					{
						AttrType = new Oid("1.2.840.113549.1.9.4", "1.2.840.113549.1.9.4"),
						AttrValues = asnWriter.Encode()
					});
				}
				if (contentTypeOid != null)
				{
					using (AsnWriter asnWriter2 = new AsnWriter(AsnEncodingRules.DER))
					{
						asnWriter2.PushSetOf();
						asnWriter2.WriteObjectIdentifier(contentTypeOid);
						asnWriter2.PopSetOf();
						list.Add(new AttributeAsn
						{
							AttrType = new Oid("1.2.840.113549.1.9.3", "1.2.840.113549.1.9.3"),
							AttrValues = asnWriter2.Encode()
						});
					}
				}
				using (AsnWriter asnWriter3 = AsnSerializer.Serialize<SignedAttributesSet>(new SignedAttributesSet
				{
					SignedAttributes = Helpers.NormalizeSet<AttributeAsn>(list.ToArray(), delegate(byte[] normalized)
					{
						AsnReader asnReader = new AsnReader(normalized, AsnEncodingRules.DER);
						hasher.AppendData(asnReader.PeekContentBytes().Span);
					})
				}, AsnEncodingRules.BER))
				{
					result.SignedAttributes = new ReadOnlyMemory<byte>?(asnWriter3.Encode());
				}
				hashAndReset = hasher.GetHashAndReset();
			}
			switch (this.SignerIdentifierType)
			{
			case SubjectIdentifierType.IssuerAndSerialNumber:
			{
				byte[] serialNumber = this.Certificate.GetSerialNumber();
				Array.Reverse<byte>(serialNumber);
				result.Sid.IssuerAndSerialNumber = new IssuerAndSerialNumberAsn?(new IssuerAndSerialNumberAsn
				{
					Issuer = this.Certificate.IssuerName.RawData,
					SerialNumber = serialNumber
				});
				result.Version = 1;
				break;
			}
			case SubjectIdentifierType.SubjectKeyIdentifier:
				result.Sid.SubjectKeyIdentifier = new ReadOnlyMemory<byte>?(this.Certificate.GetSubjectKeyIdentifier());
				result.Version = 3;
				break;
			case SubjectIdentifierType.NoSignature:
				result.Sid.IssuerAndSerialNumber = new IssuerAndSerialNumberAsn?(new IssuerAndSerialNumberAsn
				{
					Issuer = SubjectIdentifier.DummySignerEncodedValue,
					SerialNumber = new byte[1]
				});
				result.Version = 1;
				break;
			default:
				throw new CryptographicException();
			}
			if (this.UnsignedAttributes != null && this.UnsignedAttributes.Count > 0)
			{
				List<AttributeAsn> list2 = CmsSigner.BuildAttributes(this.UnsignedAttributes);
				result.UnsignedAttributes = Helpers.NormalizeSet<AttributeAsn>(list2.ToArray(), null);
			}
			Oid algorithm;
			ReadOnlyMemory<byte> signatureValue;
			if (!CmsSignature.Sign(hashAndReset, digestAlgorithm, this.Certificate, silent, out algorithm, out signatureValue))
			{
				throw new CryptographicException("Could not determine signature algorithm for the signer certificate.");
			}
			result.SignatureValue = signatureValue;
			result.SignatureAlgorithm.Algorithm = algorithm;
			X509Certificate2Collection x509Certificate2Collection = new X509Certificate2Collection();
			x509Certificate2Collection.AddRange(this.Certificates);
			if (this.SignerIdentifierType != SubjectIdentifierType.NoSignature)
			{
				if (this.IncludeOption == X509IncludeOption.EndCertOnly)
				{
					x509Certificate2Collection.Add(this.Certificate);
				}
				else if (this.IncludeOption != X509IncludeOption.None)
				{
					X509Chain x509Chain = new X509Chain();
					x509Chain.ChainPolicy.RevocationMode = X509RevocationMode.NoCheck;
					x509Chain.ChainPolicy.VerificationFlags = X509VerificationFlags.AllFlags;
					if (!x509Chain.Build(this.Certificate))
					{
						foreach (X509ChainStatus x509ChainStatus in x509Chain.ChainStatus)
						{
							if (x509ChainStatus.Status == X509ChainStatusFlags.PartialChain)
							{
								throw new CryptographicException("The certificate chain is incomplete, the self-signed root authority could not be determined.");
							}
						}
					}
					X509ChainElementCollection chainElements = x509Chain.ChainElements;
					int count = chainElements.Count;
					int num = count - 1;
					if (num == 0)
					{
						num = -1;
					}
					for (int j = 0; j < count; j++)
					{
						X509Certificate2 certificate = chainElements[j].Certificate;
						if (j == num && this.IncludeOption == X509IncludeOption.ExcludeRoot && certificate.SubjectName.RawData.AsSpan<byte>().SequenceEqual(certificate.IssuerName.RawData))
						{
							break;
						}
						x509Certificate2Collection.Add(certificate);
					}
				}
			}
			chainCerts = x509Certificate2Collection;
			return result;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00012108 File Offset: 0x00010308
		internal static List<AttributeAsn> BuildAttributes(CryptographicAttributeObjectCollection attributes)
		{
			List<AttributeAsn> list = new List<AttributeAsn>();
			if (attributes == null || attributes.Count == 0)
			{
				return list;
			}
			foreach (CryptographicAttributeObject cryptographicAttributeObject in attributes)
			{
				using (AsnWriter asnWriter = new AsnWriter(AsnEncodingRules.DER))
				{
					asnWriter.PushSetOf();
					foreach (AsnEncodedData asnEncodedData in cryptographicAttributeObject.Values)
					{
						asnWriter.WriteEncodedValue(asnEncodedData.RawData);
					}
					asnWriter.PopSetOf();
					AttributeAsn item = new AttributeAsn
					{
						AttrType = cryptographicAttributeObject.Oid,
						AttrValues = asnWriter.Encode()
					};
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x04000270 RID: 624
		private static readonly Oid s_defaultAlgorithm = Oid.FromOidValue("1.3.14.3.2.26", OidGroup.HashAlgorithm);

		// Token: 0x04000271 RID: 625
		private SubjectIdentifierType _signerIdentifierType;
	}
}
