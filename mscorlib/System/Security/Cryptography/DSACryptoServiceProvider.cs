using System;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	/// <summary>Определяет объект-оболочку для доступа к реализации алгоритма <see cref="T:System.Security.Cryptography.DSA" />, предоставляемой поставщиком служб шифрования (CSP). Этот класс не наследуется.</summary>
	// Token: 0x020004C9 RID: 1225
	[ComVisible(true)]
	public sealed class DSACryptoServiceProvider : DSA, ICspAsymmetricAlgorithm
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" />.</summary>
		// Token: 0x060030FC RID: 12540 RVA: 0x000B39F6 File Offset: 0x000B1BF6
		public DSACryptoServiceProvider() : this(1024)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> заданными параметрами для поставщика служб шифрования (CSP).</summary>
		/// <param name="parameters">Параметры для CSP.</param>
		// Token: 0x060030FD RID: 12541 RVA: 0x000B3A03 File Offset: 0x000B1C03
		public DSACryptoServiceProvider(CspParameters parameters) : this(1024, parameters)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> с указанным размером ключа.</summary>
		/// <param name="dwKeySize">Размер ключа для алгоритма асимметричного шифрования в битах.</param>
		// Token: 0x060030FE RID: 12542 RVA: 0x000B3A11 File Offset: 0x000B1C11
		public DSACryptoServiceProvider(int dwKeySize)
		{
			this.privateKeyExportable = true;
			base..ctor();
			this.Common(dwKeySize, false);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> заданным размером ключа и параметрами для поставщика служб шифрования (CSP).</summary>
		/// <param name="dwKeySize">Размер ключа для криптографического алгоритма в битах.</param>
		/// <param name="parameters">Параметры для CSP.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Невозможно получить CSP.  
		///
		/// или - 
		/// Невозможно создать ключ.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="dwKeySize" /> выходит за пределы диапазона.</exception>
		// Token: 0x060030FF RID: 12543 RVA: 0x000B3A28 File Offset: 0x000B1C28
		public DSACryptoServiceProvider(int dwKeySize, CspParameters parameters)
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

		// Token: 0x06003100 RID: 12544 RVA: 0x000B3A5C File Offset: 0x000B1C5C
		private void Common(int dwKeySize, bool parameters)
		{
			this.LegalKeySizesValue = new KeySizes[1];
			this.LegalKeySizesValue[0] = new KeySizes(512, 1024, 64);
			this.KeySize = dwKeySize;
			this.dsa = new DSAManaged(dwKeySize);
			this.dsa.KeyGenerated += this.OnKeyGenerated;
			this.persistKey = parameters;
			if (parameters)
			{
				return;
			}
			CspParameters cspParameters = new CspParameters(13);
			if (DSACryptoServiceProvider.useMachineKeyStore)
			{
				cspParameters.Flags |= CspProviderFlags.UseMachineKeyStore;
			}
			this.store = new KeyPairPersistence(cspParameters);
		}

		// Token: 0x06003101 RID: 12545 RVA: 0x000B3AEC File Offset: 0x000B1CEC
		private void Common(CspParameters parameters)
		{
			this.store = new KeyPairPersistence(parameters);
			this.store.Load();
			if (this.store.KeyValue != null)
			{
				this.persisted = true;
				this.FromXmlString(this.store.KeyValue);
			}
			this.privateKeyExportable = ((parameters.Flags & CspProviderFlags.UseNonExportableKey) == CspProviderFlags.NoFlags);
		}

		// Token: 0x06003102 RID: 12546 RVA: 0x000B3B48 File Offset: 0x000B1D48
		~DSACryptoServiceProvider()
		{
			this.Dispose(false);
		}

		/// <summary>Получает имя алгоритма обмена ключами.</summary>
		/// <returns>Имя алгоритма обмена ключами.</returns>
		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06003103 RID: 12547 RVA: 0x0000AF5E File Offset: 0x0000915E
		public override string KeyExchangeAlgorithm
		{
			get
			{
				return null;
			}
		}

		/// <summary>Получает размер ключа (в битах), используемого алгоритмом асимметричного шифрования.</summary>
		/// <returns>Размер ключа, используемого алгоритмом асимметричного шифрования.</returns>
		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06003104 RID: 12548 RVA: 0x000B3B78 File Offset: 0x000B1D78
		public override int KeySize
		{
			get
			{
				return this.dsa.KeySize;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, следует ли сохранить ключ в поставщике служб шифрования (CSP).</summary>
		/// <returns>Значение <see langword="true" />, если ключ необходимо сохранить в поставщике служб шифрования; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06003105 RID: 12549 RVA: 0x000B3B85 File Offset: 0x000B1D85
		// (set) Token: 0x06003106 RID: 12550 RVA: 0x000B3B8D File Offset: 0x000B1D8D
		public bool PersistKeyInCsp
		{
			get
			{
				return this.persistKey;
			}
			set
			{
				this.persistKey = value;
			}
		}

		/// <summary>Возвращает значение, указывающее, содержит ли объект <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> только открытый ключ.</summary>
		/// <returns>
		///   <see langword="true" />, если объект <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" /> содержит только открытый ключ; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06003107 RID: 12551 RVA: 0x000B3B96 File Offset: 0x000B1D96
		[ComVisible(false)]
		public bool PublicOnly
		{
			get
			{
				return this.dsa.PublicOnly;
			}
		}

		/// <summary>Получает имя алгоритма подписи.</summary>
		/// <returns>Имя алгоритма подписи.</returns>
		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06003108 RID: 12552 RVA: 0x00012A75 File Offset: 0x00010C75
		public override string SignatureAlgorithm
		{
			get
			{
				return "http://www.w3.org/2000/09/xmldsig#dsa-sha1";
			}
		}

		/// <summary>Получает или задает значение, указывающее, следует ли сохранять ключ в хранилище ключей компьютера, а не в хранилище профилей пользователей.</summary>
		/// <returns>Значение <see langword="true" />, если ключ необходимо сохранить в хранилище ключей компьютера; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06003109 RID: 12553 RVA: 0x000B3BA3 File Offset: 0x000B1DA3
		// (set) Token: 0x0600310A RID: 12554 RVA: 0x000B3BAA File Offset: 0x000B1DAA
		public static bool UseMachineKeyStore
		{
			get
			{
				return DSACryptoServiceProvider.useMachineKeyStore;
			}
			set
			{
				DSACryptoServiceProvider.useMachineKeyStore = value;
			}
		}

		/// <summary>Экспортирует <see cref="T:System.Security.Cryptography.DSAParameters" />.</summary>
		/// <param name="includePrivateParameters">Значение <see langword="true" /> для включения закрытых параметров; в противном случае — значение <see langword="false" />.</param>
		/// <returns>Параметры для <see cref="T:System.Security.Cryptography.DSA" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Не удалось экспортировать ключ.</exception>
		// Token: 0x0600310B RID: 12555 RVA: 0x000B3BB2 File Offset: 0x000B1DB2
		public override DSAParameters ExportParameters(bool includePrivateParameters)
		{
			if (includePrivateParameters && !this.privateKeyExportable)
			{
				throw new CryptographicException(Locale.GetText("Cannot export private key"));
			}
			return this.dsa.ExportParameters(includePrivateParameters);
		}

		/// <summary>Импортирует заданный <see cref="T:System.Security.Cryptography.DSAParameters" />.</summary>
		/// <param name="parameters">Параметры для <see cref="T:System.Security.Cryptography.DSA" />.</param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Не удалось получить поставщик служб шифрования (CSP).  
		///
		/// или - 
		/// У параметра <paramref name="parameters" /> отсутствуют некоторые поля.</exception>
		// Token: 0x0600310C RID: 12556 RVA: 0x000B3BDB File Offset: 0x000B1DDB
		public override void ImportParameters(DSAParameters parameters)
		{
			this.dsa.ImportParameters(parameters);
		}

		/// <summary>Создает подпись <see cref="T:System.Security.Cryptography.DSA" /> для указанных данных.</summary>
		/// <param name="rgbHash">Данные, которые должны быть подписаны.</param>
		/// <returns>Цифровая подпись для указанных данных.</returns>
		// Token: 0x0600310D RID: 12557 RVA: 0x000B3BE9 File Offset: 0x000B1DE9
		public override byte[] CreateSignature(byte[] rgbHash)
		{
			return this.dsa.CreateSignature(rgbHash);
		}

		/// <summary>Вычисляет и подписывает хэш-значение заданного массива байтов.</summary>
		/// <param name="buffer">Входные данные, для которых нужно вычислить хэш.</param>
		/// <returns>Подпись <see cref="T:System.Security.Cryptography.DSA" /> для указанных данных.</returns>
		// Token: 0x0600310E RID: 12558 RVA: 0x000B3BF8 File Offset: 0x000B1DF8
		public byte[] SignData(byte[] buffer)
		{
			byte[] rgbHash = SHA1.Create().ComputeHash(buffer);
			return this.dsa.CreateSignature(rgbHash);
		}

		/// <summary>Подписывает данные массива байтов, расположенные в области, указанной начальным и конечным индексом.</summary>
		/// <param name="buffer">Входные данные, которые необходимо подписать.</param>
		/// <param name="offset">Смещение в массиве, начиная с которого следует использовать данные.</param>
		/// <param name="count">Число байтов в массиве для использования в качестве данных.</param>
		/// <returns>Подпись <see cref="T:System.Security.Cryptography.DSA" /> для указанных данных.</returns>
		// Token: 0x0600310F RID: 12559 RVA: 0x000B3C20 File Offset: 0x000B1E20
		public byte[] SignData(byte[] buffer, int offset, int count)
		{
			byte[] rgbHash = SHA1.Create().ComputeHash(buffer, offset, count);
			return this.dsa.CreateSignature(rgbHash);
		}

		/// <summary>Вычисляет и подписывает хэш-значение заданного входного потока.</summary>
		/// <param name="inputStream">Входные данные, для которых нужно вычислить хэш.</param>
		/// <returns>Подпись <see cref="T:System.Security.Cryptography.DSA" /> для указанных данных.</returns>
		// Token: 0x06003110 RID: 12560 RVA: 0x000B3C48 File Offset: 0x000B1E48
		public byte[] SignData(Stream inputStream)
		{
			byte[] rgbHash = SHA1.Create().ComputeHash(inputStream);
			return this.dsa.CreateSignature(rgbHash);
		}

		/// <summary>Вычисляет подпись для указанного хэш-значения путем его шифрования с помощью закрытого ключа.</summary>
		/// <param name="rgbHash">Хэш-значение подписываемых данных.</param>
		/// <param name="str">Имя хэш-алгоритма, используемого для создания хэш-значения данных.</param>
		/// <returns>Подпись <see cref="T:System.Security.Cryptography.DSA" /> для указанного хэш-значения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="rgbHash" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Не удалось получить поставщик служб шифрования (CSP).  
		///
		/// или - 
		/// Отсутствует закрытый ключ.</exception>
		// Token: 0x06003111 RID: 12561 RVA: 0x000B3C6D File Offset: 0x000B1E6D
		public byte[] SignHash(byte[] rgbHash, string str)
		{
			if (string.Compare(str, "SHA1", true, CultureInfo.InvariantCulture) != 0)
			{
				throw new CryptographicException(Locale.GetText("Only SHA1 is supported."));
			}
			return this.dsa.CreateSignature(rgbHash);
		}

		/// <summary>Проверяет заданную подпись путем сравнения ее с сигнатурой, вычисленной для указанных данных.</summary>
		/// <param name="rgbData">подписанные данные;</param>
		/// <param name="rgbSignature">Данные подписи, которые требуется поверить.</param>
		/// <returns>Значение <see langword="true" />, если подпись верна; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06003112 RID: 12562 RVA: 0x000B3CA0 File Offset: 0x000B1EA0
		public bool VerifyData(byte[] rgbData, byte[] rgbSignature)
		{
			byte[] rgbHash = SHA1.Create().ComputeHash(rgbData);
			return this.dsa.VerifySignature(rgbHash, rgbSignature);
		}

		/// <summary>Проверяет заданную подпись путем сравнения ее с сигнатурой, вычисленной для заданного хэш-значения.</summary>
		/// <param name="rgbHash">Хэш-значение подписываемых данных.</param>
		/// <param name="str">Имя хэш-алгоритма, используемого для создания хэш-значения данных.</param>
		/// <param name="rgbSignature">Данные подписи, которые требуется поверить.</param>
		/// <returns>Значение <see langword="true" />, если подпись верна; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="rgbHash" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Параметр <paramref name="rgbSignature" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Не удалось получить поставщик служб шифрования (CSP).  
		///
		/// или - 
		/// Не удалось проверить подпись.</exception>
		// Token: 0x06003113 RID: 12563 RVA: 0x000B3CC6 File Offset: 0x000B1EC6
		public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature)
		{
			if (str == null)
			{
				str = "SHA1";
			}
			if (string.Compare(str, "SHA1", true, CultureInfo.InvariantCulture) != 0)
			{
				throw new CryptographicException(Locale.GetText("Only SHA1 is supported."));
			}
			return this.dsa.VerifySignature(rgbHash, rgbSignature);
		}

		/// <summary>Проверяет подпись <see cref="T:System.Security.Cryptography.DSA" /> для указанных данных.</summary>
		/// <param name="rgbHash">Данные, подписанные с помощью <paramref name="rgbSignature" />.</param>
		/// <param name="rgbSignature">Подпись, которую требуется проверить с использованием <paramref name="rgbData" />.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="rgbSignature" /> совпадает с подписью, вычисленной с помощью указанного хэш-алгоритма и ключа для <paramref name="rgbHash" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06003114 RID: 12564 RVA: 0x000B3D02 File Offset: 0x000B1F02
		public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
		{
			return this.dsa.VerifySignature(rgbHash, rgbSignature);
		}

		// Token: 0x06003115 RID: 12565 RVA: 0x000B3D14 File Offset: 0x000B1F14
		protected override byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
		{
			if (hashAlgorithm != HashAlgorithmName.SHA1)
			{
				throw new CryptographicException(Environment.GetResourceString("'{0}' is not a known hash algorithm.", new object[]
				{
					hashAlgorithm.Name
				}));
			}
			return HashAlgorithm.Create(hashAlgorithm.Name).ComputeHash(data, offset, count);
		}

		// Token: 0x06003116 RID: 12566 RVA: 0x000B3D64 File Offset: 0x000B1F64
		protected override byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm)
		{
			if (hashAlgorithm != HashAlgorithmName.SHA1)
			{
				throw new CryptographicException(Environment.GetResourceString("'{0}' is not a known hash algorithm.", new object[]
				{
					hashAlgorithm.Name
				}));
			}
			return HashAlgorithm.Create(hashAlgorithm.Name).ComputeHash(data);
		}

		// Token: 0x06003117 RID: 12567 RVA: 0x000B3DB0 File Offset: 0x000B1FB0
		protected override void Dispose(bool disposing)
		{
			if (!this.m_disposed)
			{
				if (this.persisted && !this.persistKey)
				{
					this.store.Remove();
				}
				if (this.dsa != null)
				{
					this.dsa.Clear();
				}
				this.m_disposed = true;
			}
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x000B3DF0 File Offset: 0x000B1FF0
		private void OnKeyGenerated(object sender, EventArgs e)
		{
			if (this.persistKey && !this.persisted)
			{
				this.store.KeyValue = this.ToXmlString(!this.dsa.PublicOnly);
				this.store.Save();
				this.persisted = true;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Security.Cryptography.CspKeyContainerInfo" />, описывающий дополнительные сведения о паре ключей шифрования.</summary>
		/// <returns>Объект <see cref="T:System.Security.Cryptography.CspKeyContainerInfo" />, описывающий дополнительные сведения о паре ключей шифрования.</returns>
		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06003119 RID: 12569 RVA: 0x0000AF5E File Offset: 0x0000915E
		[ComVisible(false)]
		[MonoTODO("call into KeyPairPersistence to get details")]
		public CspKeyContainerInfo CspKeyContainerInfo
		{
			[SecuritySafeCritical]
			get
			{
				return null;
			}
		}

		/// <summary>Экспортирует большой двоичный объект, в котором содержатся данные ключа, связанные с объектом <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" />.</summary>
		/// <param name="includePrivateParameters">
		///   <see langword="true" />, чтобы включить закрытый ключ; в противном случае — <see langword="false" />.</param>
		/// <returns>Массив байтов, в котором содержатся данные ключа, связанные с объектом <see cref="T:System.Security.Cryptography.DSACryptoServiceProvider" />.</returns>
		// Token: 0x0600311A RID: 12570 RVA: 0x000B3E40 File Offset: 0x000B2040
		[ComVisible(false)]
		[SecuritySafeCritical]
		public byte[] ExportCspBlob(bool includePrivateParameters)
		{
			byte[] result;
			if (includePrivateParameters)
			{
				result = CryptoConvert.ToCapiPrivateKeyBlob(this);
			}
			else
			{
				result = CryptoConvert.ToCapiPublicKeyBlob(this);
			}
			return result;
		}

		/// <summary>Импортирует большой двоичный объект, представляющий данные ключа DSA.</summary>
		/// <param name="keyBlob">Массив байтов, представляющий большой двоичный объект ключа DSA.</param>
		// Token: 0x0600311B RID: 12571 RVA: 0x000B3E64 File Offset: 0x000B2064
		[SecuritySafeCritical]
		[ComVisible(false)]
		public void ImportCspBlob(byte[] keyBlob)
		{
			if (keyBlob == null)
			{
				throw new ArgumentNullException("keyBlob");
			}
			DSA dsa = CryptoConvert.FromCapiKeyBlobDSA(keyBlob);
			if (dsa is DSACryptoServiceProvider)
			{
				DSAParameters parameters = dsa.ExportParameters(!(dsa as DSACryptoServiceProvider).PublicOnly);
				this.ImportParameters(parameters);
				return;
			}
			try
			{
				DSAParameters parameters2 = dsa.ExportParameters(true);
				this.ImportParameters(parameters2);
			}
			catch
			{
				DSAParameters parameters3 = dsa.ExportParameters(false);
				this.ImportParameters(parameters3);
			}
		}

		// Token: 0x04002255 RID: 8789
		private const int PROV_DSS_DH = 13;

		// Token: 0x04002256 RID: 8790
		private KeyPairPersistence store;

		// Token: 0x04002257 RID: 8791
		private bool persistKey;

		// Token: 0x04002258 RID: 8792
		private bool persisted;

		// Token: 0x04002259 RID: 8793
		private bool privateKeyExportable;

		// Token: 0x0400225A RID: 8794
		private bool m_disposed;

		// Token: 0x0400225B RID: 8795
		private DSAManaged dsa;

		// Token: 0x0400225C RID: 8796
		private static bool useMachineKeyStore;
	}
}
