using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Вычисляет хэш-код аутентификации сообщения (HMAC) с помощью хэш-функции <see cref="T:System.Security.Cryptography.MD5" />.</summary>
	// Token: 0x0200048F RID: 1167
	[ComVisible(true)]
	public class HMACMD5 : HMAC
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.HMACMD5" /> ключом, созданным с помощью алгоритма генерации случайных чисел.</summary>
		// Token: 0x06002EF9 RID: 12025 RVA: 0x000A7C58 File Offset: 0x000A5E58
		public HMACMD5() : this(Utils.GenerateRandom(64))
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.HMACMD5" />, используя указанный ключ.</summary>
		/// <param name="key">Секретный ключ для шифрования <see cref="T:System.Security.Cryptography.HMACMD5" />. Длина ключа может быть произвольной, но если она превышает 64 байта, ключ хэшируется (с помощью хэш-функции SHA-1) для получения 64-байтового ключа. Поэтому рекомендуется использовать секретный ключ длиной 64 байта.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002EFA RID: 12026 RVA: 0x000A7C67 File Offset: 0x000A5E67
		public HMACMD5(byte[] key)
		{
			this.m_hashName = "MD5";
			this.m_hash1 = new MD5CryptoServiceProvider();
			this.m_hash2 = new MD5CryptoServiceProvider();
			this.HashSizeValue = 128;
			base.InitializeKey(key);
		}
	}
}
