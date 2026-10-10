using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Вычисляет хэш-код проверки подлинности сообщения (HMAC) с помощью хэш-функции <see cref="T:System.Security.Cryptography.SHA1" />.</summary>
	// Token: 0x02000491 RID: 1169
	[ComVisible(true)]
	public class HMACSHA1 : HMAC
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.HMACSHA1" /> созданным случайным образом ключом.</summary>
		// Token: 0x06002EFD RID: 12029 RVA: 0x000A7CEC File Offset: 0x000A5EEC
		public HMACSHA1() : this(Utils.GenerateRandom(64))
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.HMACSHA1" /> указанными данными ключа.</summary>
		/// <param name="key">Секретный ключ для шифрования <see cref="T:System.Security.Cryptography.HMACSHA1" />. Длина ключа может быть произвольной, но если она превышает 64 байта, ключ хэшируется (с помощью хэш-функции SHA-1) для получения 64-байтового ключа. Поэтому рекомендуется использовать секретный ключ длиной 64 байта.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002EFE RID: 12030 RVA: 0x000A7CFB File Offset: 0x000A5EFB
		public HMACSHA1(byte[] key) : this(key, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.HMACSHA1" /> с указанными данными ключа и значением, определяющим необходимость использования управляемой версии алгоритма SHA1.</summary>
		/// <param name="key">Секретный ключ для шифрования <see cref="T:System.Security.Cryptography.HMACSHA1" />. Длина ключа может быть произвольной, но если она превышает 64 байта, ключ хэшируется (с помощью хэш-функции SHA-1) для получения 64-байтового ключа. Поэтому рекомендуется использовать секретный ключ длиной 64 байта.</param>
		/// <param name="useManagedSha1">Значение <see langword="true" /> для использования управляемой реализации алгоритма SHA1 (класс <see cref="T:System.Security.Cryptography.SHA1Managed" />); значение <see langword="false" /> для использования неуправляемой реализации (класс <see cref="T:System.Security.Cryptography.SHA1CryptoServiceProvider" />).</param>
		// Token: 0x06002EFF RID: 12031 RVA: 0x000A7D08 File Offset: 0x000A5F08
		public HMACSHA1(byte[] key, bool useManagedSha1)
		{
			this.m_hashName = "SHA1";
			if (useManagedSha1)
			{
				this.m_hash1 = new SHA1Managed();
				this.m_hash2 = new SHA1Managed();
			}
			else
			{
				this.m_hash1 = new SHA1CryptoServiceProvider();
				this.m_hash2 = new SHA1CryptoServiceProvider();
			}
			this.HashSizeValue = 160;
			base.InitializeKey(key);
		}
	}
}
