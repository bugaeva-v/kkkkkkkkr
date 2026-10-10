using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Выполняет расшифровку данных обмена ключами, зашифрованных с использованием заполнения OAEP.</summary>
	// Token: 0x020004AC RID: 1196
	[ComVisible(true)]
	public class RSAOAEPKeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.RSAOAEPKeyExchangeDeformatter" />.</summary>
		// Token: 0x06003008 RID: 12296 RVA: 0x000AE760 File Offset: 0x000AC960
		public RSAOAEPKeyExchangeDeformatter()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.RSAOAEPKeyExchangeDeformatter" /> с заданным ключом.</summary>
		/// <param name="key">Экземпляр алгоритма <see cref="T:System.Security.Cryptography.RSA" />, в котором содержится закрытый ключ.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		// Token: 0x06003009 RID: 12297 RVA: 0x000AE768 File Offset: 0x000AC968
		public RSAOAEPKeyExchangeDeformatter(AsymmetricAlgorithm key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			this._rsaKey = (RSA)key;
		}

		/// <summary>Получает параметры для обмена ключами с использованием заполнения OAEP.</summary>
		/// <returns>XML-строка с параметрами операции обмена ключами с использованием заполнения OAEP.</returns>
		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x0600300A RID: 12298 RVA: 0x0000AF5E File Offset: 0x0000915E
		// (set) Token: 0x0600300B RID: 12299 RVA: 0x00004BF9 File Offset: 0x00002DF9
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

		/// <summary>Извлекает секретные сведения из зашифрованных данных обмена ключами.</summary>
		/// <param name="rgbData">Данные обмена ключами, в которых скрыты секретные сведения.</param>
		/// <returns>Секретные сведения, извлеченные из данных обмена ключами.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Проверка данных обмена ключами закончилась неудачей.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">Отсутствует ключ.</exception>
		// Token: 0x0600300C RID: 12300 RVA: 0x000AE78C File Offset: 0x000AC98C
		[SecuritySafeCritical]
		public override byte[] DecryptKeyExchange(byte[] rgbData)
		{
			if (this._rsaKey == null)
			{
				throw new CryptographicUnexpectedOperationException(Environment.GetResourceString("No asymmetric key object has been associated with this formatter object."));
			}
			if (this.OverridesDecrypt)
			{
				return this._rsaKey.Decrypt(rgbData, RSAEncryptionPadding.OaepSHA1);
			}
			return Utils.RsaOaepDecrypt(this._rsaKey, SHA1.Create(), new PKCS1MaskGenerationMethod(), rgbData);
		}

		/// <summary>Задает закрытый ключ, используемый для расшифровки секретных сведений.</summary>
		/// <param name="key">Экземпляр алгоритма <see cref="T:System.Security.Cryptography.RSA" />, в котором содержится закрытый ключ.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		// Token: 0x0600300D RID: 12301 RVA: 0x000AE7E1 File Offset: 0x000AC9E1
		public override void SetKey(AsymmetricAlgorithm key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			this._rsaKey = (RSA)key;
			this._rsaOverridesDecrypt = null;
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x0600300E RID: 12302 RVA: 0x000AE80C File Offset: 0x000ACA0C
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

		// Token: 0x040021CA RID: 8650
		private RSA _rsaKey;

		// Token: 0x040021CB RID: 8651
		private bool? _rsaOverridesDecrypt;
	}
}
