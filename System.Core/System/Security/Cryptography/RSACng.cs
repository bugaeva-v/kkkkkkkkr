using System;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Предоставляет реализацию алгоритма SHA на платформе криптографии следующего поколения (CNG).
	///       </summary>
	// Token: 0x02000054 RID: 84
	public sealed class RSACng : RSA
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.RSACng" /> с парой случайных 2048-битных ключей.
		///       </summary>
		// Token: 0x060001AE RID: 430 RVA: 0x00003EF3 File Offset: 0x000020F3
		public RSACng() : this(2048)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.RSACng" /> с созданным случайным образом ключом указанного размера.
		///       </summary>
		/// <param name="keySize">
		///           Размер создаваемого ключа в битах.
		///         </param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Недопустимый параметр <paramref name="keySize" />.
		///           </exception>
		// Token: 0x060001AF RID: 431 RVA: 0x00003F00 File Offset: 0x00002100
		public RSACng(int keySize)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.RSACng" /> с заданным ключом.
		///       </summary>
		/// <param name="key">
		///           Ключ, используемый для операций RSA.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="key" /> не является допустимым ключом RSA.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="key" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060001B0 RID: 432 RVA: 0x00003F00 File Offset: 0x00002100
		public RSACng(CngKey key)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Получает ключ, который будет использоваться объектом <see cref="T:System.Security.Cryptography.RSACng" /> для любой выполняемой им криптографической операции.
		///       </summary>
		/// <returns>
		///         Ключ, используемый объектом <see cref="T:System.Security.Cryptography.RSACng" />.
		///       </returns>
		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x000023CA File Offset: 0x000005CA
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x000023CA File Offset: 0x000005CA
		public CngKey Key
		{
			[SecuritySafeCritical]
			get
			{
				throw new NotImplementedException();
			}
			private set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		///         Экспортирует ключ, используемый объектом RSA, в объект <see cref="T:System.Security.Cryptography.RSAParameters" />.
		///       </summary>
		/// <param name="includePrivateParameters">
		///           Значение <see langword="true" /> для включения закрытых параметров; в противном случае — значение <see langword="false" />.
		///         </param>
		/// <returns>
		///         Ключ, используемый объектом RSA.
		///       </returns>
		// Token: 0x060001B3 RID: 435 RVA: 0x000023CA File Offset: 0x000005CA
		public override RSAParameters ExportParameters(bool includePrivateParameters)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Заменяет существующий ключ, с которым работает текущий экземпляр, создавая новый объект <see cref="T:System.Security.Cryptography.CngKey" /> для структуры параметров.
		///       </summary>
		/// <param name="parameters">
		///           Параметры RSA.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="parameters" /> не содержит ни модуль, ни показатель степени.
		///           </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             <paramref name="parameters" /> не является допустимым ключом RSA.
		///
		///             -или-
		///
		///             <paramref name="parameters" /> — это полная пара ключей, и используется KSP по умолчанию.
		///           </exception>
		// Token: 0x060001B4 RID: 436 RVA: 0x000023CA File Offset: 0x000005CA
		public override void ImportParameters(RSAParameters parameters)
		{
			throw new NotImplementedException();
		}
	}
}
