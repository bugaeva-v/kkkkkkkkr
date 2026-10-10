using System;
using Internal.Cryptography;

namespace System.Security.Cryptography.Pkcs
{
	/// <summary>Класс <see cref="T:System.Security.Cryptography.Pkcs.Pkcs9ContentType" /> определяет тип содержимого сообщения CMS/PKCS 7.</summary>
	// Token: 0x0200007A RID: 122
	public sealed class Pkcs9ContentType : Pkcs9AttributeObject
	{
		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.Pkcs9ContentType.#ctor" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.Pkcs9ContentType" />.</summary>
		// Token: 0x06000401 RID: 1025 RVA: 0x0001297C File Offset: 0x00010B7C
		public Pkcs9ContentType() : base(Oid.FromOidValue("1.2.840.113549.1.9.3", OidGroup.ExtensionOrAttribute))
		{
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.Pkcs9ContentType.ContentType" /> возвращает объект <see cref="T:System.Security.Cryptography.Oid" />, содержащий тип содержимого.</summary>
		/// <returns>
		///   <see cref="T:System.Security.Cryptography.Oid" /> , Содержащий тип содержимого.</returns>
		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x00012990 File Offset: 0x00010B90
		public Oid ContentType
		{
			get
			{
				Oid result;
				if ((result = this._lazyContentType) == null)
				{
					result = (this._lazyContentType = Pkcs9ContentType.Decode(base.RawData));
				}
				return result;
			}
		}

		/// <summary>Копирует информацию из объекта <see cref="T:System.Security.Cryptography.AsnEncodedData" />.</summary>
		/// <param name="asnEncodedData">Объект <see cref="T:System.Security.Cryptography.AsnEncodedData" />, из которого копируется информация.</param>
		// Token: 0x06000403 RID: 1027 RVA: 0x000129BF File Offset: 0x00010BBF
		public override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			base.CopyFrom(asnEncodedData);
			this._lazyContentType = null;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x000129D1 File Offset: 0x00010BD1
		private static Oid Decode(byte[] rawData)
		{
			if (rawData == null)
			{
				return null;
			}
			return new Oid(PkcsPal.Instance.DecodeOid(rawData));
		}

		// Token: 0x04000292 RID: 658
		private volatile Oid _lazyContentType;
	}
}
