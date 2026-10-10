using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Создает данные обмена ключами с помощью заполнения OAEP, используя объект <see cref="T:System.Security.Cryptography.RSA" />.</summary>
	// Token: 0x020004AD RID: 1197
	[ComVisible(true)]
	public class RSAOAEPKeyExchangeFormatter : AsymmetricKeyExchangeFormatter
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.RSAOAEPKeyExchangeFormatter" />.</summary>
		// Token: 0x0600300F RID: 12303 RVA: 0x000AE86C File Offset: 0x000ACA6C
		public RSAOAEPKeyExchangeFormatter()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.RSAOAEPKeyExchangeFormatter" /> с заданным ключом.</summary>
		/// <param name="key">Экземпляр алгоритма <see cref="T:System.Security.Cryptography.RSA" />, в котором содержится открытый ключ.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003010 RID: 12304 RVA: 0x000AE874 File Offset: 0x000ACA74
		public RSAOAEPKeyExchangeFormatter(AsymmetricAlgorithm key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			this._rsaKey = (RSA)key;
		}

		/// <summary>Возвращает или задает параметр, используемый для создания отбивки при создании процесса обмена ключами.</summary>
		/// <returns>Значение параметра.</returns>
		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06003011 RID: 12305 RVA: 0x000AE896 File Offset: 0x000ACA96
		// (set) Token: 0x06003012 RID: 12306 RVA: 0x000AE8B2 File Offset: 0x000ACAB2
		public byte[] Parameter
		{
			get
			{
				if (this.ParameterValue != null)
				{
					return (byte[])this.ParameterValue.Clone();
				}
				return null;
			}
			set
			{
				if (value != null)
				{
					this.ParameterValue = (byte[])value.Clone();
					return;
				}
				this.ParameterValue = null;
			}
		}

		/// <summary>Возвращает параметры для обмена ключами Optimal Asymmetric Encryption Padding (OAEP).</summary>
		/// <returns>XML-строка, содержащая параметры операции обмена ключами OAEP.</returns>
		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06003013 RID: 12307 RVA: 0x0000AF5E File Offset: 0x0000915E
		public override string Parameters
		{
			get
			{
				return null;
			}
		}

		/// <summary>Получает или задает алгоритм генерации случайных чисел, используемый при создании механизма обмена ключами.</summary>
		/// <returns>Экземпляр используемого алгоритма генерации случайных чисел.</returns>
		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06003014 RID: 12308 RVA: 0x000AE8D0 File Offset: 0x000ACAD0
		// (set) Token: 0x06003015 RID: 12309 RVA: 0x000AE8D8 File Offset: 0x000ACAD8
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
		// Token: 0x06003016 RID: 12310 RVA: 0x000AE8E1 File Offset: 0x000ACAE1
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
		/// <exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">Ключ отсутствует.</exception>
		// Token: 0x06003017 RID: 12311 RVA: 0x000AE90C File Offset: 0x000ACB0C
		[SecuritySafeCritical]
		public override byte[] CreateKeyExchange(byte[] rgbData)
		{
			if (this._rsaKey == null)
			{
				throw new CryptographicUnexpectedOperationException(Environment.GetResourceString("No asymmetric key object has been associated with this formatter object."));
			}
			if (this.OverridesEncrypt)
			{
				return this._rsaKey.Encrypt(rgbData, RSAEncryptionPadding.OaepSHA1);
			}
			return Utils.RsaOaepEncrypt(this._rsaKey, SHA1.Create(), new PKCS1MaskGenerationMethod(), RandomNumberGenerator.Create(), rgbData);
		}

		/// <summary>Создает из указанных входных данных зашифрованные данные для обмена ключами.</summary>
		/// <param name="rgbData">Секретные сведения, которые будут переданы при обмене ключами.</param>
		/// <param name="symAlgType">Этот параметр не используется в текущей версии.</param>
		/// <returns>Зашифрованные данные обмена ключами для отправки предполагаемому получателю.</returns>
		// Token: 0x06003018 RID: 12312 RVA: 0x000AE966 File Offset: 0x000ACB66
		public override byte[] CreateKeyExchange(byte[] rgbData, Type symAlgType)
		{
			return this.CreateKeyExchange(rgbData);
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06003019 RID: 12313 RVA: 0x000AE970 File Offset: 0x000ACB70
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

		// Token: 0x040021CC RID: 8652
		private byte[] ParameterValue;

		// Token: 0x040021CD RID: 8653
		private RSA _rsaKey;

		// Token: 0x040021CE RID: 8654
		private bool? _rsaOverridesEncrypt;

		// Token: 0x040021CF RID: 8655
		private RandomNumberGenerator RngValue;
	}
}
