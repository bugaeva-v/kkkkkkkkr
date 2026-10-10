using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Вычисляет хэш-код аутентификации сообщения (HMAC) с помощью хэш-функции <see cref="T:System.Security.Cryptography.RIPEMD160" />.</summary>
	// Token: 0x02000490 RID: 1168
	[ComVisible(true)]
	public class HMACRIPEMD160 : HMAC
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.HMACRIPEMD160" /> 64-байтовым ключом, созданным с помощью алгоритма генерации случайных чисел.</summary>
		// Token: 0x06002EFB RID: 12027 RVA: 0x000A7CA2 File Offset: 0x000A5EA2
		public HMACRIPEMD160() : this(Utils.GenerateRandom(64))
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.HMACRIPEMD160" /> указанными данными ключа.</summary>
		/// <param name="key">Секретный ключ для шифрования <see cref="T:System.Security.Cryptography.HMACRIPEMD160" />. Длина ключа может быть произвольной, но если она превышает 64 байта, ключ хэшируется (с помощью хэш-функции SHA-1) для получения 64-байтового ключа. Поэтому рекомендуется использовать секретный ключ длиной 64 байта.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002EFC RID: 12028 RVA: 0x000A7CB1 File Offset: 0x000A5EB1
		public HMACRIPEMD160(byte[] key)
		{
			this.m_hashName = "RIPEMD160";
			this.m_hash1 = new RIPEMD160Managed();
			this.m_hash2 = new RIPEMD160Managed();
			this.HashSizeValue = 160;
			base.InitializeKey(key);
		}
	}
}
