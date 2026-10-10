using System;
using Internal.Cryptography;

namespace System.Security.Cryptography.Pkcs
{
	/// <summary>Класс <see cref="T:System.Security.Cryptography.Pkcs.Pkcs9DocumentDescription" /> определяет описание содержимого сообщения CMS/PKCS 7.</summary>
	// Token: 0x0200007B RID: 123
	public sealed class Pkcs9DocumentDescription : Pkcs9AttributeObject
	{
		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.Pkcs9DocumentDescription.#ctor" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.Pkcs9DocumentDescription" />.</summary>
		// Token: 0x06000405 RID: 1029 RVA: 0x000129E8 File Offset: 0x00010BE8
		public Pkcs9DocumentDescription() : base(new Oid("1.3.6.1.4.1.311.88.2.2"))
		{
		}

		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.Pkcs9DocumentDescription.#ctor(System.String)" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.Pkcs9DocumentDescription" />, используя указанное описание содержимого сообщения CMS/PKCS 7.</summary>
		/// <param name="documentDescription">Экземпляр класса <see cref="T:System.String" />, который определяет описание сообщения CMS/PKCS #7.</param>
		// Token: 0x06000406 RID: 1030 RVA: 0x000129FA File Offset: 0x00010BFA
		public Pkcs9DocumentDescription(string documentDescription) : base("1.3.6.1.4.1.311.88.2.2", Pkcs9DocumentDescription.Encode(documentDescription))
		{
			this._lazyDocumentDescription = documentDescription;
		}

		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.Pkcs9DocumentDescription.#ctor(System.Byte[])" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.Pkcs9DocumentDescription" />, используя в качестве закодированного описания содержимого сообщения CMS/PKCS 7 указанный массив байтовых значений.</summary>
		/// <param name="encodedDocumentDescription">Массив байтовых значений, который содержит закодированное описание сообщения CMS/PKCS 7.</param>
		// Token: 0x06000407 RID: 1031 RVA: 0x00012A16 File Offset: 0x00010C16
		public Pkcs9DocumentDescription(byte[] encodedDocumentDescription) : base("1.3.6.1.4.1.311.88.2.2", encodedDocumentDescription)
		{
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.Pkcs9DocumentDescription.DocumentDescription" /> возвращает описание документа.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий описание документа.</returns>
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x00012A24 File Offset: 0x00010C24
		public string DocumentDescription
		{
			get
			{
				string result;
				if ((result = this._lazyDocumentDescription) == null)
				{
					result = (this._lazyDocumentDescription = Pkcs9DocumentDescription.Decode(base.RawData));
				}
				return result;
			}
		}

		/// <summary>Копирует информацию из объекта <see cref="T:System.Security.Cryptography.AsnEncodedData" />.</summary>
		/// <param name="asnEncodedData">Объект <see cref="T:System.Security.Cryptography.AsnEncodedData" />, из которого копируется информация.</param>
		// Token: 0x06000409 RID: 1033 RVA: 0x00012A53 File Offset: 0x00010C53
		public override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			base.CopyFrom(asnEncodedData);
			this._lazyDocumentDescription = null;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00012A65 File Offset: 0x00010C65
		private static string Decode(byte[] rawData)
		{
			if (rawData == null)
			{
				return null;
			}
			return PkcsPal.Instance.DecodeOctetString(rawData).OctetStringToUnicode();
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00012A7C File Offset: 0x00010C7C
		private static byte[] Encode(string documentDescription)
		{
			if (documentDescription == null)
			{
				throw new ArgumentNullException("documentDescription");
			}
			byte[] octets = documentDescription.UnicodeToOctetString();
			return PkcsPal.Instance.EncodeOctetString(octets);
		}

		// Token: 0x04000293 RID: 659
		private volatile string _lazyDocumentDescription;
	}
}
