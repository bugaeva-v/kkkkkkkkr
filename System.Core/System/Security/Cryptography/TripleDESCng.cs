using System;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Предоставляет реализацию алгоритма 3DES на платформе криптографии следующего поколения (CNG).
	///       </summary>
	// Token: 0x02000060 RID: 96
	public sealed class TripleDESCng : TripleDES
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.TripleDESCng" /> с использованием временного ключа.
		///       </summary>
		// Token: 0x0600020F RID: 527 RVA: 0x00006184 File Offset: 0x00004384
		public TripleDESCng()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.TripleDESCng" /> с указанным именем ключа, который представляет существующий сохраненный ключ 3DES.
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
		// Token: 0x06000210 RID: 528 RVA: 0x00006184 File Offset: 0x00004384
		public TripleDESCng(string keyName)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.TripleDESCng" /> с указанным именем ключа, который представляет существующий сохраненный ключ 3DES, и заданным поставщиком хранилища ключей (KSP).
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
		// Token: 0x06000211 RID: 529 RVA: 0x00006184 File Offset: 0x00004384
		public TripleDESCng(string keyName, CngProvider provider)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.TripleDESCng" /> с указанным именем ключа, который представляет существующий сохраненный ключ 3DES, указанного поставщика хранилища ключей (KSP) и параметры открытия ключа.
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
		// Token: 0x06000212 RID: 530 RVA: 0x00006184 File Offset: 0x00004384
		public TripleDESCng(string keyName, CngProvider provider, CngKeyOpenOptions openOptions)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Возвращает или задает ключ для алгоритма <see cref="T:System.Security.Cryptography.TripleDESCng" />.
		///       </summary>
		/// <returns>
		///         Ключ для алгоритма <see cref="T:System.Security.Cryptography.TripleDESCng" />.
		///       </returns>
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000213 RID: 531 RVA: 0x000023CA File Offset: 0x000005CA
		// (set) Token: 0x06000214 RID: 532 RVA: 0x000023CA File Offset: 0x000005CA
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
		///         Возвращает или задает размер (в битах) секретного ключа, который используется алгоритмом <see cref="T:System.Security.Cryptography.TripleDESCng" />.
		///       </summary>
		/// <returns>
		///         Размер (в битах) секретного ключа, который используется алгоритмом <see cref="T:System.Security.Cryptography.TripleDESCng" />.
		///       </returns>
		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000215 RID: 533 RVA: 0x000023CA File Offset: 0x000005CA
		// (set) Token: 0x06000216 RID: 534 RVA: 0x000023CA File Offset: 0x000005CA
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
		///         Создает симметричный объект-дешифратор 3DES с текущим ключом и вектором инициализации (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).
		///       </summary>
		/// <returns>
		///         Симметричный объект-дешифратор 3DES.
		///       </returns>
		// Token: 0x06000217 RID: 535 RVA: 0x000023CA File Offset: 0x000005CA
		public override ICryptoTransform CreateDecryptor()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Создает симметричный объект-дешифратор 3DES с указанным ключом и вектором инициализации (IV).
		///       </summary>
		/// <param name="rgbKey">
		///           Секретный ключ, используемый для алгоритма 3DES.
		///            Размер ключа должен составлять 192 бита.
		///         </param>
		/// <param name="rgbIV">
		///           Вектор инициализации, используемый для алгоритма 3DES.
		///         </param>
		/// <returns>
		///         Симметричный объект-дешифратор 3DES.
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
		// Token: 0x06000218 RID: 536 RVA: 0x000023CA File Offset: 0x000005CA
		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Создает симметричный объект-шифратор 3DES с помощью текущего ключа и вектора инициализации (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).
		///       </summary>
		/// <returns>
		///         Симметричный объект-шифратор 3DES.
		///       </returns>
		// Token: 0x06000219 RID: 537 RVA: 0x000023CA File Offset: 0x000005CA
		public override ICryptoTransform CreateEncryptor()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Создает симметричный объект-шифратор 3DES с указанным ключом и вектором инициализации (IV).
		///       </summary>
		/// <param name="rgbKey">
		///           Секретный ключ, используемый для алгоритма 3DES.
		///            Размер ключа должен составлять 192 бита.
		///         </param>
		/// <param name="rgbIV">
		///           Вектор инициализации, используемый для алгоритма 3DES.
		///         </param>
		/// <returns>
		///         Симметричный объект-шифратор 3DES.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="rgbKey" /> имеет значение <see langword="null" />.
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
		// Token: 0x0600021A RID: 538 RVA: 0x0000392D File Offset: 0x00001B2D
		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
		{
			return null;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x000023CA File Offset: 0x000005CA
		protected override void Dispose(bool disposing)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Создает случайный вектор инициализации (IV), который нужно использовать для алгоритма 3DES.
		///       </summary>
		// Token: 0x0600021C RID: 540 RVA: 0x000023CA File Offset: 0x000005CA
		public override void GenerateIV()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Создает случайный ключ для использования алгоритма 3DES.
		///       </summary>
		// Token: 0x0600021D RID: 541 RVA: 0x000023CA File Offset: 0x000005CA
		public override void GenerateKey()
		{
			throw new NotImplementedException();
		}
	}
}
