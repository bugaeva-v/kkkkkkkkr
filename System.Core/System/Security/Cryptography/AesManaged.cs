using System;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Предоставляет управляемую реализацию алгоритма симметричного расширенный стандарт шифрования (AES).
	///       </summary>
	// Token: 0x02000038 RID: 56
	public sealed class AesManaged : Aes
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.AesManaged" />.
		///       </summary>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             Параметр политики безопасности Windows для FIPS включен.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Эта реализация не является частью криптографических алгоритмов, утвержденных FIPS для платформы Windows.
		///           </exception>
		// Token: 0x060000C7 RID: 199 RVA: 0x00002C4C File Offset: 0x00000E4C
		public AesManaged()
		{
			if (CryptoConfig.AllowOnlyFipsAlgorithms)
			{
				throw new InvalidOperationException(SR.GetString("This implementation is not part of the Windows Platform FIPS validated cryptographic algorithms."));
			}
			this.m_rijndael = new RijndaelManaged();
			this.m_rijndael.BlockSize = this.BlockSize;
			this.m_rijndael.KeySize = this.KeySize;
		}

		/// <summary>
		///         Возвращает или задает число бит для обратной связи.
		///       </summary>
		/// <returns>
		///         Размер ответа в битах.
		///       </returns>
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00002CA3 File Offset: 0x00000EA3
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00002CB0 File Offset: 0x00000EB0
		public override int FeedbackSize
		{
			get
			{
				return this.m_rijndael.FeedbackSize;
			}
			set
			{
				this.m_rijndael.FeedbackSize = value;
			}
		}

		/// <summary>
		///         Возвращает или задает вектор инициализации (IV) для симметричного алгоритма.
		///       </summary>
		/// <returns>
		///         Вектор инициализации, используемый для симметричного алгоритма
		///       </returns>
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00002CBE File Offset: 0x00000EBE
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00002CCB File Offset: 0x00000ECB
		public override byte[] IV
		{
			get
			{
				return this.m_rijndael.IV;
			}
			set
			{
				this.m_rijndael.IV = value;
			}
		}

		/// <summary>
		///         Возвращает или задает секретный ключ для симметричного алгоритма.
		///       </summary>
		/// <returns>
		///         Ключ для симметричного алгоритма.
		///       </returns>
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00002CD9 File Offset: 0x00000ED9
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00002CE6 File Offset: 0x00000EE6
		public override byte[] Key
		{
			get
			{
				return this.m_rijndael.Key;
			}
			set
			{
				this.m_rijndael.Key = value;
			}
		}

		/// <summary>
		///         Возвращает или задает размер (в битах) секретный ключ для симметричного алгоритма.
		///       </summary>
		/// <returns>
		///         Размер (в битах) ключа, используемого симметричным алгоритмом.
		///       </returns>
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00002CF4 File Offset: 0x00000EF4
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00002D01 File Offset: 0x00000F01
		public override int KeySize
		{
			get
			{
				return this.m_rijndael.KeySize;
			}
			set
			{
				this.m_rijndael.KeySize = value;
			}
		}

		/// <summary>
		///         Возвращает или задает режим функционирования симметричного алгоритма.
		///       </summary>
		/// <returns>
		///         Одно из значений перечисления, указывающее режим блочного шифра для использования при шифровании.
		///          Значение по умолчанию — <see cref="F:System.Security.Cryptography.CipherMode.CBC" />.
		///       </returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///             <see cref="P:System.Security.Cryptography.AesManaged.Mode" /> имеет значение <see cref="F:System.Security.Cryptography.CipherMode.CFB" /> или <see cref="F:System.Security.Cryptography.CipherMode.OFB" />.
		///           </exception>
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00002D0F File Offset: 0x00000F0F
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00002D1C File Offset: 0x00000F1C
		public override CipherMode Mode
		{
			get
			{
				return this.m_rijndael.Mode;
			}
			set
			{
				if (value == CipherMode.CFB || value == CipherMode.OFB)
				{
					throw new CryptographicException(SR.GetString("Specified cipher mode is not valid for this algorithm."));
				}
				this.m_rijndael.Mode = value;
			}
		}

		/// <summary>
		///         Возвращает или задает режим заполнения, используемый в симметричном алгоритме.
		///       </summary>
		/// <returns>
		///         Одно из значений перечисления, указывающее тип применяемого заполнения.
		///          Значение по умолчанию — <see cref="F:System.Security.Cryptography.PaddingMode.PKCS7" />.
		///       </returns>
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00002D42 File Offset: 0x00000F42
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00002D4F File Offset: 0x00000F4F
		public override PaddingMode Padding
		{
			get
			{
				return this.m_rijndael.Padding;
			}
			set
			{
				this.m_rijndael.Padding = value;
			}
		}

		/// <summary>
		///         Создает симметричный объект-дешифратор с помощью текущий ключ и вектор инициализации (IV).
		///       </summary>
		/// <returns>
		///         Симметричный объект-дешифратор.
		///       </returns>
		// Token: 0x060000D4 RID: 212 RVA: 0x00002D5D File Offset: 0x00000F5D
		public override ICryptoTransform CreateDecryptor()
		{
			return this.m_rijndael.CreateDecryptor();
		}

		/// <summary>
		///         Создает симметричный объект-дешифратор с использованием указанного ключа и вектора инициализации (IV).
		///       </summary>
		/// <param name="key">
		///           Секретный ключ, который должен использоваться для симметричного алгоритма.
		///         </param>
		/// <param name="iv">
		///           Вектор инициализации, который должен использоваться для симметричного алгоритма.
		///         </param>
		/// <returns>
		///         Симметричный объект-дешифратор.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="key" /> или <paramref name="iv" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="key" /> недопустим.
		///           </exception>
		// Token: 0x060000D5 RID: 213 RVA: 0x00002D6C File Offset: 0x00000F6C
		public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			if (!base.ValidKeySize(key.Length * 8))
			{
				throw new ArgumentException(SR.GetString("Specified key is not a valid size for this algorithm."), "key");
			}
			if (iv != null && iv.Length * 8 != this.BlockSizeValue)
			{
				throw new ArgumentException(SR.GetString("Specified initialization vector (IV) does not match the block size for this algorithm."), "iv");
			}
			return this.m_rijndael.CreateDecryptor(key, iv);
		}

		/// <summary>
		///         Создает симметричный объект-шифратор с помощью текущий ключ и вектор инициализации (IV).
		///       </summary>
		/// <returns>
		///         Симметричный объект-шифратор.
		///       </returns>
		// Token: 0x060000D6 RID: 214 RVA: 0x00002DDB File Offset: 0x00000FDB
		public override ICryptoTransform CreateEncryptor()
		{
			return this.m_rijndael.CreateEncryptor();
		}

		/// <summary>
		///         Создает симметричный объект-шифратор с использованием указанного ключа и вектора инициализации (IV).
		///       </summary>
		/// <param name="key">
		///           Секретный ключ, который должен использоваться для симметричного алгоритма.
		///         </param>
		/// <param name="iv">
		///           Вектор инициализации, который должен использоваться для симметричного алгоритма.
		///         </param>
		/// <returns>
		///         Симметричный объект-шифратор.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="key" /> или <paramref name="iv" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="key" /> недопустим.
		///           </exception>
		// Token: 0x060000D7 RID: 215 RVA: 0x00002DE8 File Offset: 0x00000FE8
		public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			if (!base.ValidKeySize(key.Length * 8))
			{
				throw new ArgumentException(SR.GetString("Specified key is not a valid size for this algorithm."), "key");
			}
			if (iv != null && iv.Length * 8 != this.BlockSizeValue)
			{
				throw new ArgumentException(SR.GetString("Specified initialization vector (IV) does not match the block size for this algorithm."), "iv");
			}
			return this.m_rijndael.CreateEncryptor(key, iv);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002E58 File Offset: 0x00001058
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing)
				{
					((IDisposable)this.m_rijndael).Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		/// <summary>
		///         Создает случайный вектор инициализации (IV) для симметричного алгоритма.
		///       </summary>
		// Token: 0x060000D9 RID: 217 RVA: 0x00002E90 File Offset: 0x00001090
		public override void GenerateIV()
		{
			this.m_rijndael.GenerateIV();
		}

		/// <summary>
		///         Создает случайный ключ для симметричного алгоритма.
		///       </summary>
		// Token: 0x060000DA RID: 218 RVA: 0x00002E9D File Offset: 0x0000109D
		public override void GenerateKey()
		{
			this.m_rijndael.GenerateKey();
		}

		// Token: 0x040002DA RID: 730
		private RijndaelManaged m_rijndael;
	}
}
