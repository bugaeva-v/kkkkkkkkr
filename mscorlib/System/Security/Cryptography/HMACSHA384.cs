using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Вычисляет хэш-код проверки подлинности сообщения (HMAC) с помощью хэш-функции <see cref="T:System.Security.Cryptography.SHA384" />.</summary>
	// Token: 0x02000494 RID: 1172
	[ComVisible(true)]
	public class HMACSHA384 : HMAC
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.HMACSHA384" /> ключом, созданным с помощью алгоритма генерации случайных чисел.</summary>
		// Token: 0x06002F08 RID: 12040 RVA: 0x000A7E59 File Offset: 0x000A6059
		public HMACSHA384() : this(Utils.GenerateRandom(128))
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.HMACSHA384" />, используя указанные данные ключа.</summary>
		/// <param name="key">Секретный ключ для шифрования <see cref="T:System.Security.Cryptography.HMACSHA384" />. Ключ может иметь любую длину. Однако рекомендуемый размер равен 128 байтам. Если длина ключа превышает 128 байт, ключ хэшируется (с помощью хэш-функции SHA-384) для получения 128-байтового ключа. Если он меньше 128 байт, то он заполняется до 128 байт.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002F09 RID: 12041 RVA: 0x000A7E6C File Offset: 0x000A606C
		[SecuritySafeCritical]
		public HMACSHA384(byte[] key)
		{
			this.m_hashName = "SHA384";
			this.m_hash1 = HMAC.GetHashAlgorithmWithFipsFallback(() => new SHA384Managed(), () => HashAlgorithm.Create("System.Security.Cryptography.SHA384CryptoServiceProvider"));
			this.m_hash2 = HMAC.GetHashAlgorithmWithFipsFallback(() => new SHA384Managed(), () => HashAlgorithm.Create("System.Security.Cryptography.SHA384CryptoServiceProvider"));
			this.HashSizeValue = 384;
			base.BlockSizeValue = this.BlockSize;
			base.InitializeKey(key);
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06002F0A RID: 12042 RVA: 0x000A7F45 File Offset: 0x000A6145
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

		/// <summary>Предоставляет обходной путь для реализации .NET Framework 2.0 алгоритма <see cref="T:System.Security.Cryptography.HMACSHA384" />, который не соответствует реализации .NET Framework 2.0 с пакетом обновления 1 (SP1).</summary>
		/// <returns>
		///   <see langword="true" />, чтобы включить взаимодействие приложений .NET Framework 2.0 с пакетом обновления 1 (SP1) с приложениями .NET Framework 2.0; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06002F0B RID: 12043 RVA: 0x000A7F57 File Offset: 0x000A6157
		// (set) Token: 0x06002F0C RID: 12044 RVA: 0x000A7F5F File Offset: 0x000A615F
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

		// Token: 0x04002171 RID: 8561
		private bool m_useLegacyBlockSize = Utils._ProduceLegacyHmacValues();
	}
}
