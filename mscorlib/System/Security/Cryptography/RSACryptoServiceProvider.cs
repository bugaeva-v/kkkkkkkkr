using System;
using System.IO;
using System.Runtime.InteropServices;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	/// <summary>Выполняет асимметричное шифрование и расшифровку с помощью реализации алгоритма <see cref="T:System.Security.Cryptography.RSA" />, предоставляемого поставщиком служб шифрования (CSP). Этот класс не наследуется.</summary>
	// Token: 0x020004AB RID: 1195
	[ComVisible(true)]
	public sealed class RSACryptoServiceProvider : RSA, ICspAsymmetricAlgorithm
	{
		/// <summary>Получает имя алгоритма подписи, доступного в этой реализации <see cref="T:System.Security.Cryptography.RSA" />.</summary>
		/// <returns>Имя алгоритма подписи.</returns>
		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06002FDA RID: 12250 RVA: 0x000110AD File Offset: 0x0000F2AD
		public override string SignatureAlgorithm
		{
			get
			{
				return "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
			}
		}

		/// <summary>Получает или задает значение, указывающее, следует ли сохранять ключ в хранилище ключей компьютера, а не в хранилище профилей пользователей.</summary>
		/// <returns>Значение <see langword="true" />, если ключ необходимо сохранить в хранилище ключей компьютера; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06002FDB RID: 12251 RVA: 0x000ADCA5 File Offset: 0x000ABEA5
		// (set) Token: 0x06002FDC RID: 12252 RVA: 0x000ADCB1 File Offset: 0x000ABEB1
		public static bool UseMachineKeyStore
		{
			get
			{
				return RSACryptoServiceProvider.s_UseMachineKeyStore == CspProviderFlags.UseMachineKeyStore;
			}
			set
			{
				RSACryptoServiceProvider.s_UseMachineKeyStore = (value ? CspProviderFlags.UseMachineKeyStore : CspProviderFlags.NoFlags);
			}
		}

		// Token: 0x06002FDD RID: 12253 RVA: 0x000ADCC1 File Offset: 0x000ABEC1
		[SecuritySafeCritical]
		protected override byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
		{
			return HashAlgorithm.Create(hashAlgorithm.Name).ComputeHash(data, offset, count);
		}

		// Token: 0x06002FDE RID: 12254 RVA: 0x000ADCD7 File Offset: 0x000ABED7
		[SecuritySafeCritical]
		protected override byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm)
		{
			return HashAlgorithm.Create(hashAlgorithm.Name).ComputeHash(data);
		}

		// Token: 0x06002FDF RID: 12255 RVA: 0x000ADCEC File Offset: 0x000ABEEC
		private static int GetAlgorithmId(HashAlgorithmName hashAlgorithm)
		{
			string name = hashAlgorithm.Name;
			if (name == "MD5")
			{
				return 32771;
			}
			if (name == "SHA1")
			{
				return 32772;
			}
			if (name == "SHA256")
			{
				return 32780;
			}
			if (name == "SHA384")
			{
				return 32781;
			}
			if (!(name == "SHA512"))
			{
				throw new CryptographicException(Environment.GetResourceString("'{0}' is not a known hash algorithm.", new object[]
				{
					hashAlgorithm.Name
				}));
			}
			return 32782;
		}

		/// <summary>Шифрует данные с помощью алгоритма <see cref="T:System.Security.Cryptography.RSA" />, используя указанное заполнение.</summary>
		/// <param name="data">Данные, которые необходимо зашифровать.</param>
		/// <param name="padding">Заполнение.</param>
		/// <returns>Зашифрованные данные.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="data" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="padding" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Этот режим заполнения не поддерживается.</exception>
		// Token: 0x06002FE0 RID: 12256 RVA: 0x000ADD84 File Offset: 0x000ABF84
		public override byte[] Encrypt(byte[] data, RSAEncryptionPadding padding)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			if (padding == null)
			{
				throw new ArgumentNullException("padding");
			}
			if (padding == RSAEncryptionPadding.Pkcs1)
			{
				return this.Encrypt(data, false);
			}
			if (padding == RSAEncryptionPadding.OaepSHA1)
			{
				return this.Encrypt(data, true);
			}
			throw RSACryptoServiceProvider.PaddingModeNotSupported();
		}

		/// <summary>Расшифровывает данные, зашифрованные с помощью алгоритма <see cref="T:System.Security.Cryptography.RSA" /> с использованием указанного заполнения.</summary>
		/// <param name="data">Расшифровываемые данные.</param>
		/// <param name="padding">Заполнение.</param>
		/// <returns>Расшифрованные данные.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="data" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="padding" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Этот режим заполнения не поддерживается.</exception>
		// Token: 0x06002FE1 RID: 12257 RVA: 0x000ADDE4 File Offset: 0x000ABFE4
		public override byte[] Decrypt(byte[] data, RSAEncryptionPadding padding)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			if (padding == null)
			{
				throw new ArgumentNullException("padding");
			}
			if (padding == RSAEncryptionPadding.Pkcs1)
			{
				return this.Decrypt(data, false);
			}
			if (padding == RSAEncryptionPadding.OaepSHA1)
			{
				return this.Decrypt(data, true);
			}
			throw RSACryptoServiceProvider.PaddingModeNotSupported();
		}

		/// <summary>Вычисляет подпись для указанного хэш-значения путем его шифрования с закрытым ключом с использованием указанного заполнения.</summary>
		/// <param name="hash">Хэш-значение подписываемых данных.</param>
		/// <param name="hashAlgorithm">Хэш-алгоритм, используемый для создания хэш-значения данных.</param>
		/// <param name="padding">Заполнение.</param>
		/// <returns>Подпись <see cref="T:System.Security.Cryptography.RSA" /> для указанного хэш-значения.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="hashAlgorithm" /> имеет значение <see langword="null" /> или <see cref="F:System.String.Empty" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="hash" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="padding" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значение параметра <paramref name="padding" /> не равно <see cref="P:System.Security.Cryptography.RSASignaturePadding.Pkcs1" />.</exception>
		// Token: 0x06002FE2 RID: 12258 RVA: 0x000ADE44 File Offset: 0x000AC044
		public override byte[] SignHash(byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			if (hash == null)
			{
				throw new ArgumentNullException("hash");
			}
			if (string.IsNullOrEmpty(hashAlgorithm.Name))
			{
				throw RSA.HashAlgorithmNameNullOrEmpty();
			}
			if (padding == null)
			{
				throw new ArgumentNullException("padding");
			}
			if (padding != RSASignaturePadding.Pkcs1)
			{
				throw RSACryptoServiceProvider.PaddingModeNotSupported();
			}
			return this.SignHash(hash, RSACryptoServiceProvider.GetAlgorithmId(hashAlgorithm));
		}

		/// <summary>Проверяет допустимость цифровой подписи путем определения хэш-значения в этой подписи с помощью указанного хэш-алгоритма и заполнения, сравнивая его с предоставленным хэш-значением.</summary>
		/// <param name="hash">Хэш-значение подписанных данных.</param>
		/// <param name="signature">Данные подписи, которые требуется поверить.</param>
		/// <param name="hashAlgorithm">Имя хэш-алгоритма, используемого для создания хэш-значения.</param>
		/// <param name="padding">Заполнение.</param>
		/// <returns>Значение <see langword="true" />, если подпись является допустимой; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="hashAlgorithm" /> имеет значение <see langword="null" /> или <see cref="F:System.String.Empty" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="hash" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="padding" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значение параметра <paramref name="padding" /> не равно <see cref="P:System.Security.Cryptography.RSASignaturePadding.Pkcs1" />.</exception>
		// Token: 0x06002FE3 RID: 12259 RVA: 0x000ADEA8 File Offset: 0x000AC0A8
		public override bool VerifyHash(byte[] hash, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			if (hash == null)
			{
				throw new ArgumentNullException("hash");
			}
			if (signature == null)
			{
				throw new ArgumentNullException("signature");
			}
			if (string.IsNullOrEmpty(hashAlgorithm.Name))
			{
				throw RSA.HashAlgorithmNameNullOrEmpty();
			}
			if (padding == null)
			{
				throw new ArgumentNullException("padding");
			}
			if (padding != RSASignaturePadding.Pkcs1)
			{
				throw RSACryptoServiceProvider.PaddingModeNotSupported();
			}
			return this.VerifyHash(hash, RSACryptoServiceProvider.GetAlgorithmId(hashAlgorithm), signature);
		}

		// Token: 0x06002FE4 RID: 12260 RVA: 0x000ADF1C File Offset: 0x000AC11C
		private static Exception PaddingModeNotSupported()
		{
			return new CryptographicException(Environment.GetResourceString("Specified padding mode is not valid for this algorithm."));
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" />, используя ключ по умолчанию.</summary>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Не удалось получить поставщик служб шифрования (CSP).</exception>
		// Token: 0x06002FE5 RID: 12261 RVA: 0x000ADF2D File Offset: 0x000AC12D
		public RSACryptoServiceProvider() : this(1024)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> с заданными параметрами.</summary>
		/// <param name="parameters">Параметры, передаваемые поставщику служб шифрования (CSP).</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Невозможно получить CSP.</exception>
		// Token: 0x06002FE6 RID: 12262 RVA: 0x000ADF3A File Offset: 0x000AC13A
		public RSACryptoServiceProvider(CspParameters parameters) : this(1024, parameters)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> с указанным размером ключа.</summary>
		/// <param name="dwKeySize">Размер используемого ключа в битах.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Не удалось получить поставщик служб шифрования (CSP).</exception>
		// Token: 0x06002FE7 RID: 12263 RVA: 0x000ADF48 File Offset: 0x000AC148
		public RSACryptoServiceProvider(int dwKeySize)
		{
			this.privateKeyExportable = true;
			base..ctor();
			this.Common(dwKeySize, false);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> указанным размером ключа и параметрами.</summary>
		/// <param name="dwKeySize">Размер используемого ключа в битах.</param>
		/// <param name="parameters">Параметры, передаваемые поставщику служб шифрования (CSP).</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Невозможно получить CSP.  
		///
		/// или - 
		/// Невозможно создать ключ.</exception>
		// Token: 0x06002FE8 RID: 12264 RVA: 0x000ADF60 File Offset: 0x000AC160
		public RSACryptoServiceProvider(int dwKeySize, CspParameters parameters)
		{
			this.privateKeyExportable = true;
			base..ctor();
			bool flag = parameters != null;
			this.Common(dwKeySize, flag);
			if (flag)
			{
				this.Common(parameters);
			}
		}

		// Token: 0x06002FE9 RID: 12265 RVA: 0x000ADF94 File Offset: 0x000AC194
		private void Common(int dwKeySize, bool parameters)
		{
			this.LegalKeySizesValue = new KeySizes[1];
			this.LegalKeySizesValue[0] = new KeySizes(384, 16384, 8);
			base.KeySize = dwKeySize;
			this.rsa = new RSAManaged(this.KeySize);
			this.rsa.KeyGenerated += this.OnKeyGenerated;
			this.persistKey = parameters;
			if (parameters)
			{
				return;
			}
			CspParameters cspParameters = new CspParameters(1);
			if (RSACryptoServiceProvider.UseMachineKeyStore)
			{
				cspParameters.Flags |= CspProviderFlags.UseMachineKeyStore;
			}
			this.store = new KeyPairPersistence(cspParameters);
		}

		// Token: 0x06002FEA RID: 12266 RVA: 0x000AE028 File Offset: 0x000AC228
		private void Common(CspParameters p)
		{
			this.store = new KeyPairPersistence(p);
			bool flag = this.store.Load();
			bool flag2 = (p.Flags & CspProviderFlags.UseExistingKey) > CspProviderFlags.NoFlags;
			this.privateKeyExportable = ((p.Flags & CspProviderFlags.UseNonExportableKey) == CspProviderFlags.NoFlags);
			if (flag2 && !flag)
			{
				throw new CryptographicException("Keyset does not exist");
			}
			if (this.store.KeyValue != null)
			{
				this.persisted = true;
				this.FromXmlString(this.store.KeyValue);
			}
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x000AE0A0 File Offset: 0x000AC2A0
		~RSACryptoServiceProvider()
		{
			this.Dispose(false);
		}

		/// <summary>Получает имя алгоритма обмена ключами, доступного в этой реализации <see cref="T:System.Security.Cryptography.RSA" />.</summary>
		/// <returns>Имя алгоритма обмена ключами, если он существует; в противном случае — <see langword="null" />.</returns>
		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06002FEC RID: 12268 RVA: 0x0001107E File Offset: 0x0000F27E
		public override string KeyExchangeAlgorithm
		{
			get
			{
				return "RSA-PKCS1-KeyEx";
			}
		}

		/// <summary>Получает размер текущего ключа.</summary>
		/// <returns>Размер ключа в битах.</returns>
		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06002FED RID: 12269 RVA: 0x000AE0D0 File Offset: 0x000AC2D0
		public override int KeySize
		{
			get
			{
				if (this.rsa == null)
				{
					return this.KeySizeValue;
				}
				return this.rsa.KeySize;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, следует ли сохранить ключ в поставщике служб шифрования (CSP).</summary>
		/// <returns>Значение <see langword="true" />, если ключ необходимо сохранить в поставщике служб шифрования; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06002FEE RID: 12270 RVA: 0x000AE0EC File Offset: 0x000AC2EC
		// (set) Token: 0x06002FEF RID: 12271 RVA: 0x000AE0F4 File Offset: 0x000AC2F4
		public bool PersistKeyInCsp
		{
			get
			{
				return this.persistKey;
			}
			set
			{
				this.persistKey = value;
				if (this.persistKey)
				{
					this.OnKeyGenerated(this.rsa, null);
				}
			}
		}

		/// <summary>Возвращает значение, указывающее, содержит ли объект <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> только открытый ключ.</summary>
		/// <returns>
		///   <see langword="true" />, если объект <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> содержит только открытый ключ; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06002FF0 RID: 12272 RVA: 0x000AE112 File Offset: 0x000AC312
		[ComVisible(false)]
		public bool PublicOnly
		{
			get
			{
				return this.rsa.PublicOnly;
			}
		}

		/// <summary>Расшифровывает данные с помощью алгоритма <see cref="T:System.Security.Cryptography.RSA" />.</summary>
		/// <param name="rgb">Данные, предназначенные для расшифровки.</param>
		/// <param name="fOAEP">
		///   <see langword="true" /> для выполнения прямой расшифровки <see cref="T:System.Security.Cryptography.RSA" /> с помощью заполнения OAEP (доступно только на компьютере под управлением Microsoft Windows XP или более поздних версий); в противном случае — <see langword="false" /> для использования заполнения PKCS #1 v1.5.</param>
		/// <returns>Расшифрованные данные, которые до шифрования являются исходным открытым текстом.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Не удалось получить поставщик служб шифрования (CSP).  
		///
		/// или - 
		/// Параметр <paramref name="fOAEP" /> имеет значение <see langword="true" />, и длина параметра <paramref name="rgb" /> больше <see cref="P:System.Security.Cryptography.RSACryptoServiceProvider.KeySize" />.  
		///
		/// или - 
		/// Параметр <paramref name="fOAEP" /> имеет значение <see langword="true" />, и OAEP не поддерживается.  
		///
		/// или - 
		/// Ключ не соответствует зашифрованным данным. Однако текст исключения может оказаться неточным. Например, это может быть текст Недостаточно памяти сервера для обработки команды.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rgb" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002FF1 RID: 12273 RVA: 0x000AE120 File Offset: 0x000AC320
		public byte[] Decrypt(byte[] rgb, bool fOAEP)
		{
			if (rgb == null)
			{
				throw new ArgumentNullException("rgb");
			}
			if (rgb.Length > this.KeySize / 8)
			{
				throw new CryptographicException(Environment.GetResourceString("The data to be decrypted exceeds the maximum for this modulus of {0} bytes.", new object[]
				{
					this.KeySize / 8
				}));
			}
			if (this.m_disposed)
			{
				throw new ObjectDisposedException("rsa");
			}
			AsymmetricKeyExchangeDeformatter asymmetricKeyExchangeDeformatter;
			if (fOAEP)
			{
				asymmetricKeyExchangeDeformatter = new RSAOAEPKeyExchangeDeformatter(this.rsa);
			}
			else
			{
				asymmetricKeyExchangeDeformatter = new RSAPKCS1KeyExchangeDeformatter(this.rsa);
			}
			return asymmetricKeyExchangeDeformatter.DecryptKeyExchange(rgb);
		}

		/// <summary>Этот метод не поддерживается в текущей версии.</summary>
		/// <param name="rgb">Данные, предназначенные для расшифровки.</param>
		/// <returns>Расшифрованные данные, которые до шифрования являются исходным открытым текстом.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не поддерживается в текущей версии.</exception>
		// Token: 0x06002FF2 RID: 12274 RVA: 0x000AE1A7 File Offset: 0x000AC3A7
		public override byte[] DecryptValue(byte[] rgb)
		{
			if (!this.rsa.IsCrtPossible)
			{
				throw new CryptographicException("Incomplete private key - missing CRT.");
			}
			return this.rsa.DecryptValue(rgb);
		}

		/// <summary>Зашифровывает данные с помощью алгоритма <see cref="T:System.Security.Cryptography.RSA" />.</summary>
		/// <param name="rgb">Данные, предназначенные для шифрования.</param>
		/// <param name="fOAEP">
		///   <see langword="true" /> для выполнения прямой расшифровки <see cref="T:System.Security.Cryptography.RSA" /> с помощью заполнения OAEP (доступно только на компьютере под управлением Windows XP или более поздних версий). В противном случае — <see langword="false" /> для использования заполнения PKCS #1 v1.5.</param>
		/// <returns>Зашифрованные данные.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Не удалось получить поставщик служб шифрования (CSP).  
		///
		/// или - 
		/// Длина параметра <paramref name="rgb" /> превышает максимально допустимую длину.  
		///
		/// или - 
		/// Параметр <paramref name="fOAEP" /> имеет значение <see langword="true" />, и заполнение OAEP не поддерживается.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="rgb" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002FF3 RID: 12275 RVA: 0x000AE1D0 File Offset: 0x000AC3D0
		public byte[] Encrypt(byte[] rgb, bool fOAEP)
		{
			AsymmetricKeyExchangeFormatter asymmetricKeyExchangeFormatter;
			if (fOAEP)
			{
				asymmetricKeyExchangeFormatter = new RSAOAEPKeyExchangeFormatter(this.rsa);
			}
			else
			{
				asymmetricKeyExchangeFormatter = new RSAPKCS1KeyExchangeFormatter(this.rsa);
			}
			return asymmetricKeyExchangeFormatter.CreateKeyExchange(rgb);
		}

		/// <summary>Этот метод не поддерживается в текущей версии.</summary>
		/// <param name="rgb">Данные, предназначенные для шифрования.</param>
		/// <returns>Зашифрованные данные.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не поддерживается в текущей версии.</exception>
		// Token: 0x06002FF4 RID: 12276 RVA: 0x000AE203 File Offset: 0x000AC403
		public override byte[] EncryptValue(byte[] rgb)
		{
			return this.rsa.EncryptValue(rgb);
		}

		/// <summary>Экспортирует <see cref="T:System.Security.Cryptography.RSAParameters" />.</summary>
		/// <param name="includePrivateParameters">Значение <see langword="true" /> для включения закрытых параметров; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Параметры для <see cref="T:System.Security.Cryptography.RSA" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Не удалось экспортировать ключ.</exception>
		// Token: 0x06002FF5 RID: 12277 RVA: 0x000AE214 File Offset: 0x000AC414
		public override RSAParameters ExportParameters(bool includePrivateParameters)
		{
			if (includePrivateParameters && !this.privateKeyExportable)
			{
				throw new CryptographicException("cannot export private key");
			}
			RSAParameters rsaparameters = this.rsa.ExportParameters(includePrivateParameters);
			if (includePrivateParameters)
			{
				if (rsaparameters.D == null)
				{
					throw new ArgumentNullException("Missing D parameter for the private key.");
				}
				if (rsaparameters.P == null || rsaparameters.Q == null || rsaparameters.DP == null || rsaparameters.DQ == null || rsaparameters.InverseQ == null)
				{
					throw new CryptographicException("Missing some CRT parameters for the private key.");
				}
			}
			return rsaparameters;
		}

		/// <summary>Импортирует заданный <see cref="T:System.Security.Cryptography.RSAParameters" />.</summary>
		/// <param name="parameters">Параметры для <see cref="T:System.Security.Cryptography.RSA" />.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Не удалось получить поставщик служб шифрования (CSP).  
		///
		/// или - 
		/// У параметра <paramref name="parameters" /> отсутствуют некоторые поля.</exception>
		// Token: 0x06002FF6 RID: 12278 RVA: 0x000AE28E File Offset: 0x000AC48E
		public override void ImportParameters(RSAParameters parameters)
		{
			this.rsa.ImportParameters(parameters);
		}

		// Token: 0x06002FF7 RID: 12279 RVA: 0x000AE29C File Offset: 0x000AC49C
		private HashAlgorithm GetHash(object halg)
		{
			if (halg == null)
			{
				throw new ArgumentNullException("halg");
			}
			HashAlgorithm hashAlgorithm;
			if (halg is string)
			{
				hashAlgorithm = this.GetHashFromString((string)halg);
			}
			else if (halg is HashAlgorithm)
			{
				hashAlgorithm = (HashAlgorithm)halg;
			}
			else
			{
				if (!(halg is Type))
				{
					throw new ArgumentException("halg");
				}
				hashAlgorithm = (HashAlgorithm)Activator.CreateInstance((Type)halg);
			}
			if (hashAlgorithm == null)
			{
				throw new ArgumentException("Could not find provider for halg='" + ((halg != null) ? halg.ToString() : null) + "'.", "halg");
			}
			return hashAlgorithm;
		}

		// Token: 0x06002FF8 RID: 12280 RVA: 0x000AE334 File Offset: 0x000AC534
		private HashAlgorithm GetHashFromString(string name)
		{
			HashAlgorithm hashAlgorithm = HashAlgorithm.Create(name);
			if (hashAlgorithm != null)
			{
				return hashAlgorithm;
			}
			HashAlgorithm result;
			try
			{
				result = HashAlgorithm.Create(this.GetHashNameFromOID(name));
			}
			catch (CryptographicException ex)
			{
				throw new ArgumentException(ex.Message, "halg", ex);
			}
			return result;
		}

		/// <summary>Вычисляет хэш-значение заданного массива байтов с помощью указанного алгоритма хэширования и подписывает результирующее хэш-значение.</summary>
		/// <param name="buffer">Входные данные, для которых нужно вычислить хэш.</param>
		/// <param name="halg">Хэш-алгоритм, который следует использовать для создания хэш-значения.</param>
		/// <returns>Подпись <see cref="T:System.Security.Cryptography.RSA" /> для указанных данных.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="halg" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="halg" /> не является допустимым типом.</exception>
		// Token: 0x06002FF9 RID: 12281 RVA: 0x000AE384 File Offset: 0x000AC584
		public byte[] SignData(byte[] buffer, object halg)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			return this.SignData(buffer, 0, buffer.Length, halg);
		}

		/// <summary>Вычисляет хэш-значение заданного потока с помощью указанного алгоритма хэширования и подписывает результирующее хэш-значение.</summary>
		/// <param name="inputStream">Входные данные, для которых нужно вычислить хэш.</param>
		/// <param name="halg">Хэш-алгоритм, который следует использовать для создания хэш-значения.</param>
		/// <returns>Подпись <see cref="T:System.Security.Cryptography.RSA" /> для указанных данных.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="halg" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="halg" /> не является допустимым типом.</exception>
		// Token: 0x06002FFA RID: 12282 RVA: 0x000AE3A0 File Offset: 0x000AC5A0
		public byte[] SignData(Stream inputStream, object halg)
		{
			HashAlgorithm hash = this.GetHash(halg);
			byte[] hashValue = hash.ComputeHash(inputStream);
			return PKCS1.Sign_v15(this, hash, hashValue);
		}

		/// <summary>Вычисляет хэш-значение подмножества заданного массива байтов с помощью указанного алгоритма хэширования и подписывает результирующее хэш-значение.</summary>
		/// <param name="buffer">Входные данные, для которых нужно вычислить хэш.</param>
		/// <param name="offset">Смещение в массиве, начиная с которого следует использовать данные.</param>
		/// <param name="count">Число байтов в массиве для использования в качестве данных.</param>
		/// <param name="halg">Хэш-алгоритм, который следует использовать для создания хэш-значения.</param>
		/// <returns>Подпись <see cref="T:System.Security.Cryptography.RSA" /> для указанных данных.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="halg" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="halg" /> не является допустимым типом.</exception>
		// Token: 0x06002FFB RID: 12283 RVA: 0x000AE3C8 File Offset: 0x000AC5C8
		public byte[] SignData(byte[] buffer, int offset, int count, object halg)
		{
			HashAlgorithm hash = this.GetHash(halg);
			byte[] hashValue = hash.ComputeHash(buffer, offset, count);
			return PKCS1.Sign_v15(this, hash, hashValue);
		}

		// Token: 0x06002FFC RID: 12284 RVA: 0x000AE3F0 File Offset: 0x000AC5F0
		private string GetHashNameFromOID(string oid)
		{
			if (oid == "1.3.14.3.2.26")
			{
				return "SHA1";
			}
			if (oid == "1.2.840.113549.2.5")
			{
				return "MD5";
			}
			if (oid == "2.16.840.1.101.3.4.2.1")
			{
				return "SHA256";
			}
			if (oid == "2.16.840.1.101.3.4.2.2")
			{
				return "SHA384";
			}
			if (!(oid == "2.16.840.1.101.3.4.2.3"))
			{
				throw new CryptographicException(oid + " is an unsupported hash algorithm for RSA signing");
			}
			return "SHA512";
		}

		/// <summary>Вычисляет подпись для указанного хэш-значения путем его шифрования с помощью закрытого ключа.</summary>
		/// <param name="rgbHash">Хэш-значение подписываемых данных.</param>
		/// <param name="str">Идентификатор хэш-алгоритма (OID), используемый для создания хэш-значения данных.</param>
		/// <returns>Подпись <see cref="T:System.Security.Cryptography.RSA" /> для указанного хэш-значения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="rgbHash" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Не удалось получить поставщик служб шифрования (CSP).  
		///
		/// или - 
		/// Отсутствует закрытый ключ.</exception>
		// Token: 0x06002FFD RID: 12285 RVA: 0x000AE470 File Offset: 0x000AC670
		public byte[] SignHash(byte[] rgbHash, string str)
		{
			if (rgbHash == null)
			{
				throw new ArgumentNullException("rgbHash");
			}
			HashAlgorithm hash = HashAlgorithm.Create((str == null) ? "SHA1" : this.GetHashNameFromOID(str));
			return PKCS1.Sign_v15(this, hash, rgbHash);
		}

		// Token: 0x06002FFE RID: 12286 RVA: 0x000AE4AA File Offset: 0x000AC6AA
		private byte[] SignHash(byte[] rgbHash, int calgHash)
		{
			return PKCS1.Sign_v15(this, RSACryptoServiceProvider.InternalHashToHashAlgorithm(calgHash), rgbHash);
		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x000AE4BC File Offset: 0x000AC6BC
		private static HashAlgorithm InternalHashToHashAlgorithm(int calgHash)
		{
			if (calgHash == 32771)
			{
				return MD5.Create();
			}
			if (calgHash == 32772)
			{
				return SHA1.Create();
			}
			switch (calgHash)
			{
			case 32780:
				return SHA256.Create();
			case 32781:
				return SHA384.Create();
			case 32782:
				return SHA512.Create();
			default:
				throw new NotImplementedException(calgHash.ToString());
			}
		}

		/// <summary>Проверяет допустимость цифровой подписи путем определения хэш-значения в этой подписи с помощью предоставленного открытого ключа и его сравнения с хэш-значением предоставленных данных.</summary>
		/// <param name="buffer">подписанные данные;</param>
		/// <param name="halg">Имя хэш-алгоритма, используемого для создания хэш-значения данных.</param>
		/// <param name="signature">Данные подписи, которые требуется поверить.</param>
		/// <returns>Значение <see langword="true" />, если подпись является допустимой; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="halg" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="halg" /> не является допустимым типом.</exception>
		// Token: 0x06003000 RID: 12288 RVA: 0x000AE520 File Offset: 0x000AC720
		public bool VerifyData(byte[] buffer, object halg, byte[] signature)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (signature == null)
			{
				throw new ArgumentNullException("signature");
			}
			HashAlgorithm hash = this.GetHash(halg);
			byte[] hashValue = hash.ComputeHash(buffer);
			return PKCS1.Verify_v15(this, hash, hashValue, signature);
		}

		/// <summary>Проверяет допустимость цифровой подписи путем определения хэш-значения в этой подписи с помощью предоставленного открытого ключа и его сравнения с предоставленным хэш-значением.</summary>
		/// <param name="rgbHash">Хэш-значение подписанных данных.</param>
		/// <param name="str">Идентификатор хэш-алгоритма (OID), используемый для создания хэш-значения данных.</param>
		/// <param name="rgbSignature">Данные подписи, которые требуется поверить.</param>
		/// <returns>Значение <see langword="true" />, если подпись является допустимой; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="rgbHash" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Параметр <paramref name="rgbSignature" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Не удалось получить поставщик служб шифрования (CSP).  
		///
		/// или - 
		/// Не удалось проверить подпись.</exception>
		// Token: 0x06003001 RID: 12289 RVA: 0x000AE564 File Offset: 0x000AC764
		public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature)
		{
			if (rgbHash == null)
			{
				throw new ArgumentNullException("rgbHash");
			}
			if (rgbSignature == null)
			{
				throw new ArgumentNullException("rgbSignature");
			}
			HashAlgorithm hash = HashAlgorithm.Create((str == null) ? "SHA1" : this.GetHashNameFromOID(str));
			return PKCS1.Verify_v15(this, hash, rgbHash, rgbSignature);
		}

		// Token: 0x06003002 RID: 12290 RVA: 0x000AE5AD File Offset: 0x000AC7AD
		private bool VerifyHash(byte[] rgbHash, int calgHash, byte[] rgbSignature)
		{
			return PKCS1.Verify_v15(this, RSACryptoServiceProvider.InternalHashToHashAlgorithm(calgHash), rgbHash, rgbSignature);
		}

		// Token: 0x06003003 RID: 12291 RVA: 0x000AE5BD File Offset: 0x000AC7BD
		protected override void Dispose(bool disposing)
		{
			if (!this.m_disposed)
			{
				if (this.persisted && !this.persistKey)
				{
					this.store.Remove();
				}
				if (this.rsa != null)
				{
					this.rsa.Clear();
				}
				this.m_disposed = true;
			}
		}

		// Token: 0x06003004 RID: 12292 RVA: 0x000AE5FC File Offset: 0x000AC7FC
		private void OnKeyGenerated(object sender, EventArgs e)
		{
			if (this.persistKey && !this.persisted)
			{
				this.store.KeyValue = this.ToXmlString(!this.rsa.PublicOnly);
				this.store.Save();
				this.persisted = true;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Security.Cryptography.CspKeyContainerInfo" />, описывающий дополнительные сведения о паре ключей шифрования.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.CspKeyContainerInfo" />, описывающий дополнительные сведения о паре ключей шифрования.</returns>
		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06003005 RID: 12293 RVA: 0x000AE64A File Offset: 0x000AC84A
		[ComVisible(false)]
		public CspKeyContainerInfo CspKeyContainerInfo
		{
			[SecuritySafeCritical]
			get
			{
				return new CspKeyContainerInfo(this.store.Parameters);
			}
		}

		/// <summary>Экспортирует большой двоичный объект, содержащий ключевые сведения, связанные с объектом <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" />.</summary>
		/// <param name="includePrivateParameters">
		///   <see langword="true" />, чтобы включить закрытый ключ; в противном случае — <see langword="false" />.</param>
		/// <returns>Массив байтов, содержащий ключевые сведения, связанные с объектом <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" />.</returns>
		// Token: 0x06003006 RID: 12294 RVA: 0x000AE65C File Offset: 0x000AC85C
		[SecuritySafeCritical]
		[ComVisible(false)]
		public byte[] ExportCspBlob(bool includePrivateParameters)
		{
			byte[] array;
			if (includePrivateParameters)
			{
				array = CryptoConvert.ToCapiPrivateKeyBlob(this);
			}
			else
			{
				array = CryptoConvert.ToCapiPublicKeyBlob(this);
			}
			array[5] = ((this.store != null && this.store.Parameters.KeyNumber == 2) ? 36 : 164);
			return array;
		}

		/// <summary>Импортирует большой двоичный объект, представляющий данные ключа RSA.</summary>
		/// <param name="keyBlob">Массив байтов, представляющий большой двоичный объект ключа RSA.</param>
		// Token: 0x06003007 RID: 12295 RVA: 0x000AE6A8 File Offset: 0x000AC8A8
		[ComVisible(false)]
		[SecuritySafeCritical]
		public void ImportCspBlob(byte[] keyBlob)
		{
			if (keyBlob == null)
			{
				throw new ArgumentNullException("keyBlob");
			}
			RSA rsa = CryptoConvert.FromCapiKeyBlob(keyBlob);
			if (rsa is RSACryptoServiceProvider)
			{
				RSAParameters parameters = rsa.ExportParameters(!(rsa as RSACryptoServiceProvider).PublicOnly);
				this.ImportParameters(parameters);
			}
			else
			{
				try
				{
					RSAParameters parameters2 = rsa.ExportParameters(true);
					this.ImportParameters(parameters2);
				}
				catch
				{
					RSAParameters parameters3 = rsa.ExportParameters(false);
					this.ImportParameters(parameters3);
				}
			}
			CspParameters cspParameters = new CspParameters(1);
			cspParameters.KeyNumber = ((keyBlob[5] == 36) ? 2 : 1);
			if (RSACryptoServiceProvider.UseMachineKeyStore)
			{
				cspParameters.Flags |= CspProviderFlags.UseMachineKeyStore;
			}
			this.store = new KeyPairPersistence(cspParameters);
		}

		// Token: 0x040021C0 RID: 8640
		private static volatile CspProviderFlags s_UseMachineKeyStore;

		// Token: 0x040021C1 RID: 8641
		private const int PROV_RSA_FULL = 1;

		// Token: 0x040021C2 RID: 8642
		private const int AT_KEYEXCHANGE = 1;

		// Token: 0x040021C3 RID: 8643
		private const int AT_SIGNATURE = 2;

		// Token: 0x040021C4 RID: 8644
		private KeyPairPersistence store;

		// Token: 0x040021C5 RID: 8645
		private bool persistKey;

		// Token: 0x040021C6 RID: 8646
		private bool persisted;

		// Token: 0x040021C7 RID: 8647
		private bool privateKeyExportable;

		// Token: 0x040021C8 RID: 8648
		private bool m_disposed;

		// Token: 0x040021C9 RID: 8649
		private RSAManaged rsa;
	}
}
