using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Вычисляет хэш-код аутентификации сообщения (HMAC) с помощью хэш-функции <see cref="T:System.Security.Cryptography.SHA256" />.</summary>
	// Token: 0x02000492 RID: 1170
	[ComVisible(true)]
	public class HMACSHA256 : HMAC
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.HMACSHA256" /> созданным случайным образом ключом.</summary>
		// Token: 0x06002F00 RID: 12032 RVA: 0x000A7D69 File Offset: 0x000A5F69
		public HMACSHA256() : this(Utils.GenerateRandom(64))
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.HMACSHA256" /> указанными данными ключа.</summary>
		/// <param name="key">Секретный ключ для шифрования <see cref="T:System.Security.Cryptography.HMACSHA256" />. Ключ может иметь любую длину. Однако рекомендуемый размер равен 64 байтам. Если длина ключа превышает 64 байта, ключ хэшируется (с помощью хэш-функции SHA-256) для получения 64-байтового ключа. Если он меньше 64 байт, то он заполняется до 64 байт.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002F01 RID: 12033 RVA: 0x000A7D78 File Offset: 0x000A5F78
		public HMACSHA256(byte[] key)
		{
			this.m_hashName = "SHA256";
			this.m_hash1 = HMAC.GetHashAlgorithmWithFipsFallback(() => new SHA256Managed(), () => HashAlgorithm.Create("System.Security.Cryptography.SHA256CryptoServiceProvider"));
			this.m_hash2 = HMAC.GetHashAlgorithmWithFipsFallback(() => new SHA256Managed(), () => HashAlgorithm.Create("System.Security.Cryptography.SHA256CryptoServiceProvider"));
			this.HashSizeValue = 256;
			base.InitializeKey(key);
		}
	}
}
