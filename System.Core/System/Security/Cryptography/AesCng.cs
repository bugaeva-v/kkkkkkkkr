using System;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Предоставляет реализацию алгоритма AES на платформе криптографии следующего поколения (CNG).
	///       </summary>
	// Token: 0x02000055 RID: 85
	public sealed class AesCng : Aes
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.AesCng" /> с использованием временного ключа.
		///       </summary>
		// Token: 0x060001B5 RID: 437 RVA: 0x00003F0D File Offset: 0x0000210D
		public AesCng()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.AesCng" /> с указанным именем ключа, который представляет существующий сохраненный ключ AES.
		///       </summary>
		/// <param name="keyName">
		///           Имя ключа.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="keyName" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///
		///         Криптография следующего поколения (CNG) не поддерживается в этой системе.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Все остальные ошибки.
		///           </exception>
		// Token: 0x060001B6 RID: 438 RVA: 0x00003F0D File Offset: 0x0000210D
		public AesCng(string keyName)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.AesCng" /> с указанным именем ключа (представляет существующий сохраненный ключ AES) и указанным поставщиком хранилища ключей (KSP).
		///       </summary>
		/// <param name="keyName">
		///           Имя ключа.
		///         </param>
		/// <param name="provider">
		///           Поставщик KSP, который содержит ключ.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="keyName" /> имеет значение <see langword="null" />.
		///
		///             -или-
		///
		///             Свойство <paramref name="provider" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///
		///         Криптография следующего поколения (CNG) не поддерживается в этой системе.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Все остальные ошибки.
		///           </exception>
		// Token: 0x060001B7 RID: 439 RVA: 0x00003F0D File Offset: 0x0000210D
		public AesCng(string keyName, CngProvider provider)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.AesCng" /> с указанным именем ключа, который представляет существующий сохраненный ключ AES, указанного поставщика хранилища ключей (KSP) и параметры открытия ключа.
		///       </summary>
		/// <param name="keyName">
		///           Имя ключа.
		///         </param>
		/// <param name="provider">
		///           Поставщик KSP, который содержит ключ.
		///         </param>
		/// <param name="openOptions">
		///           Побитовое сочетание значений перечисления, которые определяют параметры открытия ключа, например, расположение, из которого открывается ключ (компьютер или пользовательское хранилище), или отключение запросов пользовательского интерфейса.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="keyName" /> имеет значение <see langword="null" />.
		///
		///             -или-
		///
		///             Свойство <paramref name="provider" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///
		///         Криптография следующего поколения (CNG) не поддерживается в этой системе.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Все остальные ошибки.
		///           </exception>
		// Token: 0x060001B8 RID: 440 RVA: 0x00003F0D File Offset: 0x0000210D
		public AesCng(string keyName, CngProvider provider, CngKeyOpenOptions openOptions)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Возвращает или задает ключ для алгоритма <see cref="T:System.Security.Cryptography.AesCng" />.
		///       </summary>
		/// <returns>
		///         Ключ для алгоритма <see cref="T:System.Security.Cryptography.AesCng" />.
		///       </returns>
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x000023CA File Offset: 0x000005CA
		// (set) Token: 0x060001BA RID: 442 RVA: 0x000023CA File Offset: 0x000005CA
		public override byte[] Key
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		///         Возвращает или задает размер (в битах) секретного ключа, который используется алгоритмом <see cref="T:System.Security.Cryptography.AesCng" />.
		///       </summary>
		/// <returns>
		///         Размер (в битах) секретного ключа, который используется алгоритмом <see cref="T:System.Security.Cryptography.AesCng" />.
		///       </returns>
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001BB RID: 443 RVA: 0x000023CA File Offset: 0x000005CA
		// (set) Token: 0x060001BC RID: 444 RVA: 0x000023CA File Offset: 0x000005CA
		public override int KeySize
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		///         Создает симметричный объект-дешифратор АES с текущим ключом и вектором инициализации (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).
		///       </summary>
		/// <returns>
		///         Симметричный объект-дешифратор AES.
		///       </returns>
		// Token: 0x060001BD RID: 445 RVA: 0x000023CA File Offset: 0x000005CA
		public override ICryptoTransform CreateDecryptor()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Создает симметричный объект-дешифратор AES с указанным ключом и вектором инициализации (IV).
		///       </summary>
		/// <param name="rgbKey">
		///           Секретный ключ, который нужно использовать для алгоритма AES.
		///            Размер ключа должен составлять 128, 192 или 256 битов.
		///         </param>
		/// <param name="rgbIV">
		///           Вектор инициализации, который нужно использовать для алгоритма AES.
		///         </param>
		/// <returns>
		///         Симметричный объект-дешифратор AES.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Элемент <paramref name="rgbKey" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             Размер элемента <paramref name="rgbKey" /> недопустимый для этого алгоритма.
		///
		///             -или-
		///
		///             Размер элемента <paramref name="rgbIV" /> не соответствует размеру блоков для этого алгоритма.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Элемент <paramref name="rgbKey" /> — это слабый ключ для этого алгоритма, поэтому он не может использоваться.
		///
		///             -или-
		///
		///             Элемент <paramref name="rgbIV" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060001BE RID: 446 RVA: 0x000023CA File Offset: 0x000005CA
		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Создает симметричный объект-шифратор AES с помощью текущего ключа и вектора инициализации (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).
		///       </summary>
		/// <returns>
		///         Симметричный объект-шифратор AES.
		///       </returns>
		// Token: 0x060001BF RID: 447 RVA: 0x000023CA File Offset: 0x000005CA
		public override ICryptoTransform CreateEncryptor()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Создает симметричный объект-шифратор AES с помощью указанного ключа и вектора инициализации (IV).
		///       </summary>
		/// <param name="rgbKey">
		///           Секретный ключ, который нужно использовать для алгоритма AES.
		///            Размер ключа должен составлять 128, 192 или 256 битов.
		///         </param>
		/// <param name="rgbIV">
		///           Вектор инициализации, который нужно использовать для алгоритма AES.
		///         </param>
		/// <returns>
		///         Симметричный объект-шифратор AES.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Элемент <paramref name="rgbKey" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             Размер элемента <paramref name="rgbKey" /> недопустимый для этого алгоритма.
		///
		///             -или-
		///
		///             Размер элемента <paramref name="rgbIV" /> не соответствует размеру блоков для этого алгоритма.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Элемент <paramref name="rgbKey" /> — это слабый ключ для этого алгоритма, поэтому он не может использоваться.
		///
		///             -или-
		///
		///             Элемент <paramref name="rgbIV" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060001C0 RID: 448 RVA: 0x0000392D File Offset: 0x00001B2D
		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
		{
			return null;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000023CA File Offset: 0x000005CA
		protected override void Dispose(bool disposing)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Создает случайный вектор инициализации (IV), который нужно использовать для алгоритма AES.
		///       </summary>
		// Token: 0x060001C2 RID: 450 RVA: 0x000023CA File Offset: 0x000005CA
		public override void GenerateIV()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Создает случайный ключ для использования алгоритма AES.
		///       </summary>
		// Token: 0x060001C3 RID: 451 RVA: 0x000023CA File Offset: 0x000005CA
		public override void GenerateKey()
		{
			throw new NotImplementedException();
		}
	}
}
