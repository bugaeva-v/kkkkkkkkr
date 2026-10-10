using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Создает данные обмена ключами по стандарту PKCS 1 с помощью <see cref="T:System.Security.Cryptography.RSA" />.</summary>
	// Token: 0x020004AF RID: 1199
	[ComVisible(true)]
	public class RSAPKCS1KeyExchangeFormatter : AsymmetricKeyExchangeFormatter
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.RSAPKCS1KeyExchangeFormatter" />.</summary>
		// Token: 0x06003023 RID: 12323 RVA: 0x000AE86C File Offset: 0x000ACA6C
		public RSAPKCS1KeyExchangeFormatter()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.RSAPKCS1KeyExchangeFormatter" /> с заданным ключом.</summary>
		/// <param name="key">Экземпляр алгоритма <see cref="T:System.Security.Cryptography.RSA" />, в котором содержится открытый ключ.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003024 RID: 12324 RVA: 0x000AEB20 File Offset: 0x000ACD20
		public RSAPKCS1KeyExchangeFormatter(AsymmetricAlgorithm key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			this._rsaKey = (RSA)key;
		}

		/// <summary>Получает параметры для обмена ключами PKCS #1.</summary>
		/// <returns>Строка XML, содержащая параметры операции обмена ключами PKCS #1.</returns>
		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06003025 RID: 12325 RVA: 0x000AEB42 File Offset: 0x000ACD42
		public override string Parameters
		{
			get
			{
				return "<enc:KeyEncryptionMethod enc:Algorithm=\"http://www.microsoft.com/xml/security/algorithm/PKCS1-v1.5-KeyEx\" xmlns:enc=\"http://www.microsoft.com/xml/security/encryption/v1.0\" />";
			}
		}

		/// <summary>Получает или задает алгоритм генерации случайных чисел, используемый при создании механизма обмена ключами.</summary>
		/// <returns>Экземпляр используемого алгоритма генерации случайных чисел.</returns>
		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06003026 RID: 12326 RVA: 0x000AEB49 File Offset: 0x000ACD49
		// (set) Token: 0x06003027 RID: 12327 RVA: 0x000AEB51 File Offset: 0x000ACD51
		public RandomNumberGenerator Rng
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

		/// <summary>Задает открытый ключ, используемый для шифрования данных обмена ключами.</summary>
		/// <param name="key">Экземпляр алгоритма <see cref="T:System.Security.Cryptography.RSA" />, в котором содержится открытый ключ.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003028 RID: 12328 RVA: 0x000AEB5A File Offset: 0x000ACD5A
		public override void SetKey(AsymmetricAlgorithm key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			this._rsaKey = (RSA)key;
			this._rsaOverridesEncrypt = null;
		}

		/// <summary>Создает из указанных входных данных зашифрованные данные для обмена ключами.</summary>
		/// <param name="rgbData">Секретные сведения, которые будут переданы при обмене ключами.</param>
		/// <returns>Зашифрованные данные обмена ключами для отправки предполагаемому получателю.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Объект <paramref name="rgbData" /> имеет слишком большой размер.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">Ключ имеет значение <see langword="null" />.</exception>
		// Token: 0x06003029 RID: 12329 RVA: 0x000AEB84 File Offset: 0x000ACD84
		public override byte[] CreateKeyExchange(byte[] rgbData)
		{
			if (rgbData == null)
			{
				throw new ArgumentNullException("rgbData");
			}
			if (this._rsaKey == null)
			{
				throw new CryptographicUnexpectedOperationException(Environment.GetResourceString("No asymmetric key object has been associated with this formatter object."));
			}
			byte[] result;
			if (this.OverridesEncrypt)
			{
				result = this._rsaKey.Encrypt(rgbData, RSAEncryptionPadding.Pkcs1);
			}
			else
			{
				int num = this._rsaKey.KeySize / 8;
				if (rgbData.Length + 11 > num)
				{
					throw new CryptographicException(Environment.GetResourceString("The data to be encrypted exceeds the maximum for this modulus of {0} bytes.", new object[]
					{
						num - 11
					}));
				}
				byte[] array = new byte[num];
				if (this.RngValue == null)
				{
					this.RngValue = RandomNumberGenerator.Create();
				}
				this.Rng.GetNonZeroBytes(array);
				array[0] = 0;
				array[1] = 2;
				array[num - rgbData.Length - 1] = 0;
				Buffer.InternalBlockCopy(rgbData, 0, array, num - rgbData.Length, rgbData.Length);
				result = this._rsaKey.EncryptValue(array);
			}
			return result;
		}

		/// <summary>Создает из указанных входных данных зашифрованные данные для обмена ключами.</summary>
		/// <param name="rgbData">Секретные сведения, которые будут переданы при обмене ключами.</param>
		/// <param name="symAlgType">Этот параметр не используется в текущей версии.</param>
		/// <returns>Зашифрованные данные обмена ключами для отправки предполагаемому получателю.</returns>
		// Token: 0x0600302A RID: 12330 RVA: 0x000AE966 File Offset: 0x000ACB66
		public override byte[] CreateKeyExchange(byte[] rgbData, Type symAlgType)
		{
			return this.CreateKeyExchange(rgbData);
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x0600302B RID: 12331 RVA: 0x000AEC68 File Offset: 0x000ACE68
		private bool OverridesEncrypt
		{
			get
			{
				if (this._rsaOverridesEncrypt == null)
				{
					this._rsaOverridesEncrypt = new bool?(Utils.DoesRsaKeyOverride(this._rsaKey, "Encrypt", new Type[]
					{
						typeof(byte[]),
						typeof(RSAEncryptionPadding)
					}));
				}
				return this._rsaOverridesEncrypt.Value;
			}
		}

		// Token: 0x040021D3 RID: 8659
		private RandomNumberGenerator RngValue;

		// Token: 0x040021D4 RID: 8660
		private RSA _rsaKey;

		// Token: 0x040021D5 RID: 8661
		private bool? _rsaOverridesEncrypt;
	}
}
