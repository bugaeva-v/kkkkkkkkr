using System;
using System.Threading;
using Internal.Cryptography;
using Unity;

namespace System.Security.Cryptography.Pkcs
{
	/// <summary>Класс <see cref="T:System.Security.Cryptography.Pkcs.KeyAgreeRecipientInfo" /> определяет информацию о получателе при согласовании ключей. В алгоритмах согласования ключей обычно используется алгоритм согласования ключей Диффи-Хеллмана, в котором обе стороны, использующие ключ шифрования, участвуют в создании этого ключа и, в соответствии с определением, согласовывают этот ключ. Эта ситуация противоположна использованию алгоритмов передачи ключей, при которых одна сторона создает ключ и отправляет, т. е. передает его другой стороне.</summary>
	// Token: 0x02000077 RID: 119
	public sealed class KeyAgreeRecipientInfo : RecipientInfo
	{
		// Token: 0x060003E9 RID: 1001 RVA: 0x000126C0 File Offset: 0x000108C0
		internal KeyAgreeRecipientInfo(KeyAgreeRecipientInfoPal pal) : base(RecipientInfoType.KeyAgreement, pal)
		{
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.KeyAgreeRecipientInfo.Version" /> возвращает версию получателя согласования ключей. Версия автоматически устанавливается для объектов в данном классе, а значение этого свойства указывает на то, что получатель участвует в алгоритме согласования ключей.</summary>
		/// <returns>Версия объекта <see cref="T:System.Security.Cryptography.Pkcs.KeyAgreeRecipientInfo" />.</returns>
		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x000126CA File Offset: 0x000108CA
		public override int Version
		{
			get
			{
				return this.Pal.Version;
			}
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.KeyAgreeRecipientInfo.RecipientIdentifier" /> возвращает идентификатор получателя.</summary>
		/// <returns>Идентификатор получателя.</returns>
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x000126D8 File Offset: 0x000108D8
		public override SubjectIdentifier RecipientIdentifier
		{
			get
			{
				SubjectIdentifier result;
				if ((result = this._lazyRecipientIdentifier) == null)
				{
					result = (this._lazyRecipientIdentifier = this.Pal.RecipientIdentifier);
				}
				return result;
			}
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.KeyAgreeRecipientInfo.KeyEncryptionAlgorithm" /> возвращает алгоритм, с помощью которого осуществляется согласование ключей.</summary>
		/// <returns>Значение алгоритма, с помощью которого осуществляется согласование ключей.</returns>
		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x00012708 File Offset: 0x00010908
		public override AlgorithmIdentifier KeyEncryptionAlgorithm
		{
			get
			{
				AlgorithmIdentifier result;
				if ((result = this._lazyKeyEncryptionAlgorithm) == null)
				{
					result = (this._lazyKeyEncryptionAlgorithm = this.Pal.KeyEncryptionAlgorithm);
				}
				return result;
			}
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.KeyAgreeRecipientInfo.EncryptedKey" /> возвращает зашифрованный материал ключа получателя.</summary>
		/// <returns>Массив байтовых значений, который содержит зашифрованный материал ключа получателя.</returns>
		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x00012738 File Offset: 0x00010938
		public override byte[] EncryptedKey
		{
			get
			{
				byte[] result;
				if ((result = this._lazyEncryptedKey) == null)
				{
					result = (this._lazyEncryptedKey = this.Pal.EncryptedKey);
				}
				return result;
			}
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.KeyAgreeRecipientInfo.OriginatorIdentifierOrKey" /> возвращает информацию об инициаторе согласования ключей для алгоритмов согласования ключей, которые гарантируют эту информацию.</summary>
		/// <returns>Объект, содержащий информацию об инициаторе согласования ключей.</returns>
		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x00012768 File Offset: 0x00010968
		public SubjectIdentifierOrKey OriginatorIdentifierOrKey
		{
			get
			{
				SubjectIdentifierOrKey result;
				if ((result = this._lazyOriginatorIdentifierKey) == null)
				{
					result = (this._lazyOriginatorIdentifierKey = this.Pal.OriginatorIdentifierOrKey);
				}
				return result;
			}
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.KeyAgreeRecipientInfo.Date" /> возвращает дату и время запуска протокола согласования ключей инициатором.</summary>
		/// <returns>Дата и время запуска протокола согласования ключей инициатором.</returns>
		/// <exception cref="T:System.InvalidOperationException">Тип идентификатора получателя не является идентификатором ключа субъекта.</exception>
		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x00012797 File Offset: 0x00010997
		public DateTime Date
		{
			get
			{
				if (this._lazyDate == null)
				{
					this._lazyDate = new DateTime?(this.Pal.Date);
					Interlocked.MemoryBarrier();
				}
				return this._lazyDate.Value;
			}
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.KeyAgreeRecipientInfo.OtherKeyAttribute" /> возвращает атрибуты материала ключа.</summary>
		/// <returns>Атрибуты материала ключа.</returns>
		/// <exception cref="T:System.InvalidOperationException">Тип идентификатора получателя не является идентификатором ключа субъекта.</exception>
		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x000127CC File Offset: 0x000109CC
		public CryptographicAttributeObject OtherKeyAttribute
		{
			get
			{
				CryptographicAttributeObject result;
				if ((result = this._lazyOtherKeyAttribute) == null)
				{
					result = (this._lazyOtherKeyAttribute = this.Pal.OtherKeyAttribute);
				}
				return result;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x000127FB File Offset: 0x000109FB
		private new KeyAgreeRecipientInfoPal Pal
		{
			get
			{
				return (KeyAgreeRecipientInfoPal)base.Pal;
			}
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x000029A4 File Offset: 0x00000BA4
		internal KeyAgreeRecipientInfo()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04000289 RID: 649
		private volatile SubjectIdentifier _lazyRecipientIdentifier;

		// Token: 0x0400028A RID: 650
		private volatile AlgorithmIdentifier _lazyKeyEncryptionAlgorithm;

		// Token: 0x0400028B RID: 651
		private volatile byte[] _lazyEncryptedKey;

		// Token: 0x0400028C RID: 652
		private volatile SubjectIdentifierOrKey _lazyOriginatorIdentifierKey;

		// Token: 0x0400028D RID: 653
		private DateTime? _lazyDate;

		// Token: 0x0400028E RID: 654
		private volatile CryptographicAttributeObject _lazyOtherKeyAttribute;
	}
}
