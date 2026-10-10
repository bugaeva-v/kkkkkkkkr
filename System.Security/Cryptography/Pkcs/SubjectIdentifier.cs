using System;
using System.Security.Cryptography.Pkcs.Asn1;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using Internal.Cryptography;
using Unity;

namespace System.Security.Cryptography.Pkcs
{
	/// <summary>Класс <see cref="T:System.Security.Cryptography.Pkcs.SubjectIdentifier" /> определяет тип идентификатора субъекта, например <see cref="T:System.Security.Cryptography.Pkcs.CmsSigner" /> или <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipient" />.  Субъекта можно определить по поставщику и серийному номеру сертификата или по ключу субъекта.</summary>
	// Token: 0x02000089 RID: 137
	public sealed class SubjectIdentifier
	{
		// Token: 0x06000492 RID: 1170 RVA: 0x00014843 File Offset: 0x00012A43
		internal SubjectIdentifier(SubjectIdentifierType type, object value)
		{
			this.Type = type;
			this.Value = value;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00014859 File Offset: 0x00012A59
		internal SubjectIdentifier(SignerIdentifierAsn signerIdentifierAsn) : this(signerIdentifierAsn.IssuerAndSerialNumber, signerIdentifierAsn.SubjectKeyIdentifier)
		{
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00014870 File Offset: 0x00012A70
		internal unsafe SubjectIdentifier(IssuerAndSerialNumberAsn? issuerAndSerialNumber, ReadOnlyMemory<byte>? subjectKeyIdentifier)
		{
			if (issuerAndSerialNumber != null)
			{
				IssuerAndSerialNumberAsn value = issuerAndSerialNumber.Value;
				ReadOnlySpan<byte> span = value.Issuer.Span;
				value = issuerAndSerialNumber.Value;
				ReadOnlySpan<byte> span2 = value.SerialNumber.Span;
				bool flag = false;
				for (int i = 0; i < span2.Length; i++)
				{
					if (*span2[i] != 0)
					{
						flag = true;
						break;
					}
				}
				if (!flag && SubjectIdentifier.DummySignerEncodedValue.AsSpan<byte>().SequenceEqual(span))
				{
					this.Type = 3;
					this.Value = null;
					return;
				}
				this.Type = 1;
				X500DistinguishedName x500DistinguishedName = new X500DistinguishedName(span.ToArray());
				this.Value = new X509IssuerSerial(x500DistinguishedName.Name, span2.ToBigEndianHex());
				return;
			}
			else
			{
				if (subjectKeyIdentifier != null)
				{
					this.Type = 2;
					this.Value = subjectKeyIdentifier.Value.Span.ToBigEndianHex();
					return;
				}
				throw new CryptographicException();
			}
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.SubjectIdentifier.Type" /> возвращает тип идентификатора субъекта. Субъекта можно определить по поставщику и серийному номеру сертификата или по ключу субъекта.</summary>
		/// <returns>Член перечисления <see cref="T:System.Security.Cryptography.Pkcs.SubjectIdentifierType" />, определяющий тип субъекта.</returns>
		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00014969 File Offset: 0x00012B69
		public SubjectIdentifierType Type { get; }

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.SubjectIdentifier.Value" /> содержит значение идентификатора субъекта. Свойство <see cref="P:System.Security.Cryptography.Pkcs.SubjectIdentifier.Type" /> позволяет определить тип идентификатора субъекта, а свойство <see cref="P:System.Security.Cryptography.Pkcs.SubjectIdentifier.Value" /> — получить соответствующее значение.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, который представляет значение идентификатора субъекта. Этот объект <see cref="T:System.Object" /> может относиться к одному из следующих типов в зависимости от значения свойства <see cref="P:System.Security.Cryptography.Pkcs.SubjectIdentifier.Type" />.  
		///  Свойство<see cref="P:System.Security.Cryptography.Pkcs.SubjectIdentifier.Type" />  
		///   Object 
		///   IssuerAndSerialNumber 
		///  <see cref="T:System.Security.Cryptography.Xml.X509IssuerSerial" /> SubjectKeyIdentifier 
		///  <see cref="T:System.String" /></returns>
		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x00014971 File Offset: 0x00012B71
		public object Value { get; }

		// Token: 0x06000498 RID: 1176 RVA: 0x000029A4 File Offset: 0x00000BA4
		internal SubjectIdentifier()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040002BF RID: 703
		private const string DummySignerSubjectName = "CN=Dummy Signer";

		// Token: 0x040002C0 RID: 704
		internal static readonly byte[] DummySignerEncodedValue = new X500DistinguishedName("CN=Dummy Signer").RawData;
	}
}
