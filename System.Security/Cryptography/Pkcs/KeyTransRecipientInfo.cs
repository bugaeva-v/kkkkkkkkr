using System;
using Internal.Cryptography;
using Unity;

namespace System.Security.Cryptography.Pkcs
{
	/// <summary>Класс <see cref="T:System.Security.Cryptography.Pkcs.KeyTransRecipientInfo" /> определяет информацию о получателе при передаче ключей.        В алгоритме передачи ключей обычно используется алгоритм RSA, в котором отправитель создает общий криптографический ключ и передает его получателю. Эта ситуация противоположна использованию алгоритма согласования ключей, в котором обе стороны участвуют в создании ключа шифрования, тем самым взаимно соглашаясь использовать этот ключ.</summary>
	// Token: 0x02000078 RID: 120
	public sealed class KeyTransRecipientInfo : RecipientInfo
	{
		// Token: 0x060003F3 RID: 1011 RVA: 0x00012808 File Offset: 0x00010A08
		internal KeyTransRecipientInfo(KeyTransRecipientInfoPal pal) : base(RecipientInfoType.KeyTransport, pal)
		{
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.KeyTransRecipientInfo.Version" /> возвращает версию получателя передачи ключей. Версия получателя при передаче ключей автоматически устанавливается для объектов в данном классе, а значение этого свойства указывает на то, что получатель участвует в алгоритме передаче ключей.</summary>
		/// <returns>Целочисленное значение, обозначающее версию объекта <see cref="T:System.Security.Cryptography.Pkcs.RecipientInfo" /> передачи ключей.</returns>
		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00012812 File Offset: 0x00010A12
		public override int Version
		{
			get
			{
				return this.Pal.Version;
			}
		}

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.KeyTransRecipientInfo.RecipientIdentifier" /> возвращает идентификатор субъекта, связанный с зашифрованным содержимым.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.Pkcs.SubjectIdentifier" /> объекта, в котором хранится идентификатор получателя, участвующего в передаче ключа.</returns>
		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00012820 File Offset: 0x00010A20
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

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.KeyTransRecipientInfo.KeyEncryptionAlgorithm" /> возвращает алгоритм шифрования ключа, с помощью которого шифруется ключ шифрования содержимого.</summary>
		/// <returns>
		///   <see cref="T:System.Security.Cryptography.Pkcs.AlgorithmIdentifier" /> Объекта, в котором хранится идентификатор алгоритма шифрования ключей.</returns>
		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00012850 File Offset: 0x00010A50
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

		/// <summary>Свойство <see cref="P:System.Security.Cryptography.Pkcs.KeyTransRecipientInfo.EncryptedKey" /> возвращает зашифрованный ключ для получателя передачи ключей.</summary>
		/// <returns>Массив байтовых значений, представляющий зашифрованный ключ.</returns>
		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00012880 File Offset: 0x00010A80
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

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x000128AF File Offset: 0x00010AAF
		private new KeyTransRecipientInfoPal Pal
		{
			get
			{
				return (KeyTransRecipientInfoPal)base.Pal;
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x000029A4 File Offset: 0x00000BA4
		internal KeyTransRecipientInfo()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x0400028F RID: 655
		private volatile SubjectIdentifier _lazyRecipientIdentifier;

		// Token: 0x04000290 RID: 656
		private volatile AlgorithmIdentifier _lazyKeyEncryptionAlgorithm;

		// Token: 0x04000291 RID: 657
		private volatile byte[] _lazyEncryptedKey;
	}
}
