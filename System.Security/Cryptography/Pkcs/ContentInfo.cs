using System;
using Internal.Cryptography;

namespace System.Security.Cryptography.Pkcs
{
	/// <summary>Класс <see cref="T:System.Security.Cryptography.Pkcs.ContentInfo" /> представляет структуру данных содержимого CMS/PKCS 7, определенную в документации по стандартам CMS/PKCS 7. Эта структура данных лежит в основе всех сообщений CMS/PKCS 7.</summary>
	// Token: 0x02000074 RID: 116
	public sealed class ContentInfo
	{
		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.ContentInfo.#ctor(System.Byte[])" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.ContentInfo" />, используя массив байтовых значений в качестве данных и идентификатор <paramref name="object identifier" /> (OID) по умолчанию, определяющий тип содержимого.</summary>
		/// <param name="content">Массив байтовых значений, представляющий данные, из которых необходимо создать объект <see cref="T:System.Security.Cryptography.Pkcs.ContentInfo" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		// Token: 0x060003CA RID: 970 RVA: 0x00012223 File Offset: 0x00010423
		public ContentInfo(byte[] content) : this(Oid.FromOidValue("1.2.840.113549.1.7.1", OidGroup.ExtensionOrAttribute), content)
		{
		}

		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.ContentInfo.#ctor(System.Security.Cryptography.Oid,System.Byte[])" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.ContentInfo" />, используя указанный тип содержимого и массив байтовых значений в качестве данных.</summary>
		/// <param name="contentType">Объект <see cref="T:System.Security.Cryptography.Oid" />, который содержит идентификатор объекта (OID), определяющий тип содержимого. Тип может иметь значение data, digestedData, encryptedData, envelopedData, hashedData, signedAndEnvelopedData или signedData.  Дополнительные сведения см. в разделе "Замечания".</param>
		/// <param name="content">Массив байтовых значений, представляющий данные, из которых необходимо создать объект <see cref="T:System.Security.Cryptography.Pkcs.ContentInfo" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		// Token: 0x060003CB RID: 971 RVA: 0x00012237 File Offset: 0x00010437
		public ContentInfo(Oid contentType, byte[] content)
		{
			if (contentType == null)
			{
				throw new ArgumentNullException("contentType");
			}
			if (content == null)
			{
				throw new ArgumentNullException("content");
			}
			this.ContentType = contentType;
			this.Content = content;
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.ContentInfo.ContentType" /> получает объект <see cref="T:System.Security.Cryptography.Oid" />, который содержит идентификатор <paramref name="object identifier" /> (OID) типа содержимого внутреннего содержимого сообщения CMS/PKCS #7.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Oid" />, который содержит значение OID, определяющее тип содержимого.</returns>
		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00012269 File Offset: 0x00010469
		public Oid ContentType { get; }

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.ContentInfo.Content" /> получает содержимое сообщения CMS/PKCS #7.</summary>
		/// <returns>Массив байтовых значений, представляющий содержимое.</returns>
		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00012271 File Offset: 0x00010471
		public byte[] Content { get; }

		/// <summary>Статический метод <see cref="M:System.Security.Cryptography.Pkcs.ContentInfo.GetContentType(System.Byte[])" /> получает тип внешнего содержимого закодированного сообщения <see cref="T:System.Security.Cryptography.Pkcs.ContentInfo" />, представленного массивом байтовых значений.</summary>
		/// <param name="encodedMessage">Массив байтовых значений, представляющий закодированное сообщение <see cref="T:System.Security.Cryptography.Pkcs.ContentInfo" />, из которого извлекается тип внешнего содержимого.</param>
		/// <returns>При успешном выполнении метод возвращает объект <see cref="T:System.Security.Cryptography.Oid" />, содержащий тип внешнего содержимого указанного закодированного сообщения <see cref="T:System.Security.Cryptography.Pkcs.ContentInfo" />.  
		/// При сбое метода создается исключение.</returns>
		/// <exception cref="T:System.ArgumentNullException">Пустая ссылка была передана методу, не принимающему ее в качестве допустимого аргумента.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Во время выполнения операции шифрования произошла ошибка.</exception>
		// Token: 0x060003CE RID: 974 RVA: 0x00012279 File Offset: 0x00010479
		public static Oid GetContentType(byte[] encodedMessage)
		{
			if (encodedMessage == null)
			{
				throw new ArgumentNullException("encodedMessage");
			}
			return PkcsPal.Instance.GetEncodedMessageType(encodedMessage);
		}
	}
}
