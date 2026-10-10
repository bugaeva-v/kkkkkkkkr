using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Расшифровывает данные обмена ключами PKCS #1.</summary>
	// Token: 0x020004AE RID: 1198
	[ComVisible(true)]
	public class RSAPKCS1KeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.RSAPKCS1KeyExchangeDeformatter" />.</summary>
		// Token: 0x0600301A RID: 12314 RVA: 0x000AE760 File Offset: 0x000AC960
		public RSAPKCS1KeyExchangeDeformatter()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.RSAPKCS1KeyExchangeDeformatter" /> с заданным ключом.</summary>
		/// <param name="key">Экземпляр алгоритма <see cref="T:System.Security.Cryptography.RSA" />, в котором содержится закрытый ключ.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600301B RID: 12315 RVA: 0x000AE9D0 File Offset: 0x000ACBD0
		public RSAPKCS1KeyExchangeDeformatter(AsymmetricAlgorithm key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			this._rsaKey = (RSA)key;
		}

		/// <summary>Получает или задает алгоритм генерации случайных чисел, используемый при создании механизма обмена ключами.</summary>
		/// <returns>Экземпляр используемого алгоритма генерации случайных чисел.</returns>
		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x0600301C RID: 12316 RVA: 0x000AE9F2 File Offset: 0x000ACBF2
		// (set) Token: 0x0600301D RID: 12317 RVA: 0x000AE9FA File Offset: 0x000ACBFA
		public RandomNumberGenerator RNG
		{
			get
			{
				return this.RngValue;
			}
			set
			{
				this.RngValue = value;
			}
		}

		/// <summary>Получает параметры для обмена ключами PKCS #1.</summary>
		/// <returns>Строка XML, содержащая параметры операции обмена ключами PKCS #1.</returns>
		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x0600301E RID: 12318 RVA: 0x0000AF5E File Offset: 0x0000915E
		// (set) Token: 0x0600301F RID: 12319 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public override string Parameters
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Извлекает конфиденциальные сведения из зашифрованных данных обмена ключами.</summary>
		/// <param name="rgbIn">Данные обмена ключами, в которых скрыты конфиденциальные сведения.</param>
		/// <returns>Конфиденциальные сведения, извлекаемые из данных обмена ключами.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">Ключ отсутствует.</exception>
		// Token: 0x06003020 RID: 12320 RVA: 0x000AEA04 File Offset: 0x000ACC04
		public override byte[] DecryptKeyExchange(byte[] rgbIn)
		{
			if (this._rsaKey == null)
			{
				throw new CryptographicUnexpectedOperationException(Environment.GetResourceString("No asymmetric key object has been associated with this formatter object."));
			}
			byte[] array;
			if (this.OverridesDecrypt)
			{
				array = this._rsaKey.Decrypt(rgbIn, RSAEncryptionPadding.Pkcs1);
			}
			else
			{
				byte[] array2 = this._rsaKey.DecryptValue(rgbIn);
				int num = 2;
				while (num < array2.Length && array2[num] != 0)
				{
					num++;
				}
				if (num >= array2.Length)
				{
					throw new CryptographicUnexpectedOperationException(Environment.GetResourceString("Error occurred while decoding PKCS1 padding."));
				}
				num++;
				array = new byte[array2.Length - num];
				Buffer.InternalBlockCopy(array2, num, array, 0, array.Length);
			}
			return array;
		}

		/// <summary>Задает закрытый ключ для расшифровки конфиденциальных данных.</summary>
		/// <param name="key">Экземпляр алгоритма <see cref="T:System.Security.Cryptography.RSA" />, в котором содержится закрытый ключ.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003021 RID: 12321 RVA: 0x000AEA98 File Offset: 0x000ACC98
		public override void SetKey(AsymmetricAlgorithm key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			this._rsaKey = (RSA)key;
			this._rsaOverridesDecrypt = null;
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06003022 RID: 12322 RVA: 0x000AEAC0 File Offset: 0x000ACCC0
		private bool OverridesDecrypt
		{
			get
			{
				if (this._rsaOverridesDecrypt == null)
				{
					this._rsaOverridesDecrypt = new bool?(Utils.DoesRsaKeyOverride(this._rsaKey, "Decrypt", new Type[]
					{
						typeof(byte[]),
						typeof(RSAEncryptionPadding)
					}));
				}
				return this._rsaOverridesDecrypt.Value;
			}
		}

		// Token: 0x040021D0 RID: 8656
		private RSA _rsaKey;

		// Token: 0x040021D1 RID: 8657
		private bool? _rsaOverridesDecrypt;

		// Token: 0x040021D2 RID: 8658
		private RandomNumberGenerator RngValue;
	}
}
