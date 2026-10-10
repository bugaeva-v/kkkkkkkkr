using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Вычисляет хэш-код проверки подлинности сообщения (HMAC) с помощью хэш-функции <see cref="T:System.Security.Cryptography.SHA512" />.</summary>
	// Token: 0x02000496 RID: 1174
	[ComVisible(true)]
	public class HMACSHA512 : HMAC
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.HMACSHA512" /> созданным случайным образом ключом.</summary>
		// Token: 0x06002F13 RID: 12051 RVA: 0x000A7F9F File Offset: 0x000A619F
		public HMACSHA512() : this(Utils.GenerateRandom(128))
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.HMACSHA512" /> указанными данными ключа.</summary>
		/// <param name="key">Секретный ключ для шифрования <see cref="T:System.Security.Cryptography.HMACSHA512" />. Ключ может иметь любую длину. Однако рекомендуемый размер равен 128 байтам. Если длина ключа превышает 128 байт, ключ хэшируется (с помощью хэш-функции SHA-512) для получения 128-байтового ключа. Если он меньше 128 байт, то он заполняется до 128 байт.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002F14 RID: 12052 RVA: 0x000A7FB4 File Offset: 0x000A61B4
		[SecuritySafeCritical]
		public HMACSHA512(byte[] key)
		{
			this.m_hashName = "SHA512";
			this.m_hash1 = HMAC.GetHashAlgorithmWithFipsFallback(() => new SHA512Managed(), () => HashAlgorithm.Create("System.Security.Cryptography.SHA512CryptoServiceProvider"));
			this.m_hash2 = HMAC.GetHashAlgorithmWithFipsFallback(() => new SHA512Managed(), () => HashAlgorithm.Create("System.Security.Cryptography.SHA512CryptoServiceProvider"));
			this.HashSizeValue = 512;
			base.BlockSizeValue = this.BlockSize;
			base.InitializeKey(key);
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06002F15 RID: 12053 RVA: 0x000A808D File Offset: 0x000A628D
		private int BlockSize
		{
			get
			{
				if (!this.m_useLegacyBlockSize)
				{
					return 128;
				}
				return 64;
			}
		}

		/// <summary>Предоставляет обходной путь для реализации .NET Framework 2.0 алгоритма <see cref="T:System.Security.Cryptography.HMACSHA512" />, соответствующий реализации .NET Framework 2.0 с пакетом обновления 1 (SP1).</summary>
		/// <returns>
		///   <see langword="true" />, чтобы включить взаимодействие приложений .NET Framework 2.0 с пакетом обновления 1 (SP1) с приложениями .NET Framework 2.0; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06002F16 RID: 12054 RVA: 0x000A809F File Offset: 0x000A629F
		// (set) Token: 0x06002F17 RID: 12055 RVA: 0x000A80A7 File Offset: 0x000A62A7
		public bool ProduceLegacyHmacValues
		{
			get
			{
				return this.m_useLegacyBlockSize;
			}
			set
			{
				this.m_useLegacyBlockSize = value;
				base.BlockSizeValue = this.BlockSize;
				base.InitializeKey(this.KeyValue);
			}
		}

		// Token: 0x04002177 RID: 8567
		private bool m_useLegacyBlockSize = Utils._ProduceLegacyHmacValues();
	}
}
