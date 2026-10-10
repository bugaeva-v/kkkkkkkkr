using System;
using System.Security.Cryptography.Asn1;
using Internal.Cryptography;

namespace System.Security.Cryptography.Pkcs
{
	/// <summary>Класс <see cref="T:System.Security.Cryptography.Pkcs.Pkcs9MessageDigest" /> определяет хэш сообщения CMS/PKCS 7.</summary>
	// Token: 0x0200007D RID: 125
	public sealed class Pkcs9MessageDigest : Pkcs9AttributeObject
	{
		/// <summary>Конструктор <see cref="M:System.Security.Cryptography.Pkcs.Pkcs9MessageDigest.#ctor" /> создает экземпляр класса <see cref="T:System.Security.Cryptography.Pkcs.Pkcs9MessageDigest" />.</summary>
		// Token: 0x06000413 RID: 1043 RVA: 0x00012B59 File Offset: 0x00010D59
		public Pkcs9MessageDigest() : base(Oid.FromOidValue("1.2.840.113549.1.9.4", OidGroup.ExtensionOrAttribute))
		{
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00012B6C File Offset: 0x00010D6C
		internal Pkcs9MessageDigest(ReadOnlySpan<byte> signatureDigest)
		{
			using (AsnWriter asnWriter = new AsnWriter(AsnEncodingRules.DER))
			{
				asnWriter.WriteOctetString(signatureDigest);
				base.RawData = asnWriter.Encode();
			}
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.Pkcs9MessageDigest.MessageDigest" /> возвращает хэш.</summary>
		/// <returns>Массив байтовых значений, содержащий хэш.</returns>
		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x00012BB8 File Offset: 0x00010DB8
		public byte[] MessageDigest
		{
			get
			{
				byte[] result;
				if ((result = this._lazyMessageDigest) == null)
				{
					result = (this._lazyMessageDigest = Pkcs9MessageDigest.Decode(base.RawData));
				}
				return result;
			}
		}

		/// <summary>Копирует информацию из объекта <see cref="T:System.Security.Cryptography.AsnEncodedData" />.</summary>
		/// <param name="asnEncodedData">Объект <see cref="T:System.Security.Cryptography.AsnEncodedData" />, из которого копируется информация.</param>
		// Token: 0x06000416 RID: 1046 RVA: 0x00012BE7 File Offset: 0x00010DE7
		public override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			base.CopyFrom(asnEncodedData);
			this._lazyMessageDigest = null;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00012BF9 File Offset: 0x00010DF9
		private static byte[] Decode(byte[] rawData)
		{
			if (rawData == null)
			{
				return null;
			}
			return PkcsPal.Instance.DecodeOctetString(rawData);
		}

		// Token: 0x04000295 RID: 661
		private volatile byte[] _lazyMessageDigest;
	}
}
