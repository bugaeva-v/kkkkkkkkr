using System;
using System.Security.Cryptography.X509Certificates;

namespace System.Security.Cryptography.Pkcs
{
	/// <summary>Класс <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipient" /> определяет получателя сообщения CMS/PKCS 7.</summary>
	// Token: 0x02000069 RID: 105
	public sealed class CmsRecipient
	{
		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.CmsRecipient.#ctor(System.Security.Cryptography.X509Certificates.X509Certificate2)" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipient" />, используя указанный сертификат получателя.</summary>
		/// <param name="certificate">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />, представляющий сертификат получателя.</param>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Завершение операции шифрования невозможно.</exception>
		// Token: 0x0600037E RID: 894 RVA: 0x00010E58 File Offset: 0x0000F058
		public CmsRecipient(X509Certificate2 certificate) : this(SubjectIdentifierType.IssuerAndSerialNumber, certificate)
		{
		}

		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.CmsRecipient.#ctor(System.Security.Cryptography.Pkcs.SubjectIdentifierType,System.Security.Cryptography.X509Certificates.X509Certificate2)" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.CmsRecipient" />, используя указанные тип идентификатора получателя и сертификат получателя.</summary>
		/// <param name="recipientIdentifierType">Член перечисления <see cref="T:System.Security.Cryptography.Pkcs.SubjectIdentifierType" />, определяющий тип идентификатора получателя.</param>
		/// <param name="certificate">Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />, представляющий сертификат получателя.</param>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Завершение операции шифрования невозможно.</exception>
		// Token: 0x0600037F RID: 895 RVA: 0x00010E64 File Offset: 0x0000F064
		public CmsRecipient(SubjectIdentifierType recipientIdentifierType, X509Certificate2 certificate)
		{
			if (certificate == null)
			{
				throw new ArgumentNullException("certificate");
			}
			switch (recipientIdentifierType)
			{
			case SubjectIdentifierType.Unknown:
				recipientIdentifierType = SubjectIdentifierType.IssuerAndSerialNumber;
				break;
			case SubjectIdentifierType.IssuerAndSerialNumber:
			case SubjectIdentifierType.SubjectKeyIdentifier:
				break;
			default:
				throw new CryptographicException(SR.Format("The subject identifier type {0} is not valid.", recipientIdentifierType));
			}
			this.RecipientIdentifierType = recipientIdentifierType;
			this.Certificate = certificate;
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.CmsRecipient.RecipientIdentifierType" /> возвращает тип идентификатора получателя.</summary>
		/// <returns>Член перечисления <see cref="T:System.Security.Cryptography.Pkcs.SubjectIdentifierType" />, определяющий тип идентификатора получателя.</returns>
		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00010EC2 File Offset: 0x0000F0C2
		public SubjectIdentifierType RecipientIdentifierType { get; }

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.CmsRecipient.Certificate" /> возвращает сертификат, связанный с данным получателем.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />, содержащий сертификат, связанный с данным получателем.</returns>
		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00010ECA File Offset: 0x0000F0CA
		public X509Certificate2 Certificate { get; }
	}
}
