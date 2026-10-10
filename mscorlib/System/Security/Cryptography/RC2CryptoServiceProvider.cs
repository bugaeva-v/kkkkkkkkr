using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Определяет объект-оболочку для доступа к реализации алгоритма <see cref="T:System.Security.Cryptography.RC2" />, предоставляемой поставщиком служб шифрования (CSP). Этот класс не наследуется.</summary>
	// Token: 0x020004A2 RID: 1186
	[ComVisible(true)]
	public sealed class RC2CryptoServiceProvider : RC2
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.RC2CryptoServiceProvider" />.</summary>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Не удалось получить поставщик служб шифрования (CSP).</exception>
		/// <exception cref="T:System.InvalidOperationException">Обнаружен алгоритм, не соответствующий стандарту FIPS.</exception>
		// Token: 0x06002F76 RID: 12150 RVA: 0x000A9020 File Offset: 0x000A7220
		[SecuritySafeCritical]
		public RC2CryptoServiceProvider()
		{
			if (CryptoConfig.AllowOnlyFipsAlgorithms)
			{
				throw new InvalidOperationException(Environment.GetResourceString("This implementation is not part of the Windows Platform FIPS validated cryptographic algorithms."));
			}
			if (!Utils.HasAlgorithm(26114, 0))
			{
				throw new CryptographicException(Environment.GetResourceString("Cryptographic service provider (CSP) could not be found for this algorithm."));
			}
			this.LegalKeySizesValue = RC2CryptoServiceProvider.s_legalKeySizes;
			this.FeedbackSizeValue = 8;
		}

		/// <summary>Получает или задает эффективный размер секретного ключа (в битах), используемого алгоритмом <see cref="T:System.Security.Cryptography.RC2" />.</summary>
		/// <returns>Эффективный размер ключа (в битах), используемого алгоритмом <see cref="T:System.Security.Cryptography.RC2" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">Для свойства <see cref="P:System.Security.Cryptography.RC2CryptoServiceProvider.EffectiveKeySize" /> задано значение, отличное от значения свойства <see cref="F:System.Security.Cryptography.SymmetricAlgorithm.KeySizeValue" />.</exception>
		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06002F77 RID: 12151 RVA: 0x000A8FA6 File Offset: 0x000A71A6
		// (set) Token: 0x06002F78 RID: 12152 RVA: 0x000A9079 File Offset: 0x000A7279
		public override int EffectiveKeySize
		{
			get
			{
				return this.KeySizeValue;
			}
			set
			{
				if (value != this.KeySizeValue)
				{
					throw new CryptographicUnexpectedOperationException(Environment.GetResourceString("EffectiveKeySize must be the same as KeySize in this implementation."));
				}
			}
		}

		/// <summary>Получает или задает значение, определяющее необходимость создания ключа с привязкой, имеющей длину 11 байтов и нулевое значение.</summary>
		/// <returns>Значение <see langword="true" />, если ключ необходимо создать с привязкой, имеющей длину 11 байтов и нулевое значение; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06002F79 RID: 12153 RVA: 0x000A9094 File Offset: 0x000A7294
		// (set) Token: 0x06002F7A RID: 12154 RVA: 0x000A909C File Offset: 0x000A729C
		[ComVisible(false)]
		public bool UseSalt
		{
			get
			{
				return this.m_use40bitSalt;
			}
			set
			{
				this.m_use40bitSalt = value;
			}
		}

		/// <summary>Создает объект-шифратор для алгоритма симметричного шифрования <see cref="T:System.Security.Cryptography.RC2" /> с заданным ключом (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" />) и вектором инициализации (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).</summary>
		/// <param name="rgbKey">Секретный ключ, который должен использоваться для симметричного алгоритма.</param>
		/// <param name="rgbIV">Вектор инициализации, который должен использоваться для симметричного алгоритма.</param>
		/// <returns>Объект-шифратор для алгоритма симметричного шифрования <see cref="T:System.Security.Cryptography.RC2" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Использовался режим шифрования <see cref="F:System.Security.Cryptography.CipherMode.OFB" />.  
		///
		/// или - 
		/// Использовался режим шифрования <see cref="F:System.Security.Cryptography.CipherMode.CFB" /> с размером порции данных обратной связи менее 8 бит.  
		///
		/// или - 
		/// Недопустимый размер ключа.  
		///
		/// или - 
		/// Данные о размере ключа, используемого в алгоритме, недоступны.</exception>
		// Token: 0x06002F7B RID: 12155 RVA: 0x000A90A5 File Offset: 0x000A72A5
		[SecuritySafeCritical]
		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
		{
			if (this.m_use40bitSalt)
			{
				throw new NotImplementedException("UseSalt=true is not implemented on Mono yet");
			}
			return new RC2Transform(this, true, rgbKey, rgbIV);
		}

		/// <summary>Создает объект-дешифратор для алгоритма симметричного шифрования <see cref="T:System.Security.Cryptography.RC2" /> с заданным ключом (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" />) и вектором инициализации (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).</summary>
		/// <param name="rgbKey">Секретный ключ, который должен использоваться для симметричного алгоритма.</param>
		/// <param name="rgbIV">Вектор инициализации, который должен использоваться для симметричного алгоритма.</param>
		/// <returns>Объект-дешифратор для алгоритма симметричного шифрования <see cref="T:System.Security.Cryptography.RC2" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Использовался режим шифрования <see cref="F:System.Security.Cryptography.CipherMode.OFB" />.  
		///
		/// или - 
		/// Использовался режим шифрования <see cref="F:System.Security.Cryptography.CipherMode.CFB" /> с размером порции данных обратной связи менее 8 бит.  
		///
		/// или - 
		/// Недопустимый размер ключа.  
		///
		/// или - 
		/// Данные о размере ключа, используемого в алгоритме, недоступны.</exception>
		// Token: 0x06002F7C RID: 12156 RVA: 0x000A90C3 File Offset: 0x000A72C3
		[SecuritySafeCritical]
		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
		{
			if (this.m_use40bitSalt)
			{
				throw new NotImplementedException("UseSalt=true is not implemented on Mono yet");
			}
			return new RC2Transform(this, false, rgbKey, rgbIV);
		}

		/// <summary>Создает случайный ключ (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" />), используемый для данного алгоритма.</summary>
		// Token: 0x06002F7D RID: 12157 RVA: 0x000A90E1 File Offset: 0x000A72E1
		public override void GenerateKey()
		{
			this.KeyValue = new byte[this.KeySizeValue / 8];
			Utils.StaticRandomNumberGenerator.GetBytes(this.KeyValue);
		}

		/// <summary>Создает случайный вектор инициализации (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />), используемый для данного алгоритма.</summary>
		// Token: 0x06002F7E RID: 12158 RVA: 0x000A6F11 File Offset: 0x000A5111
		public override void GenerateIV()
		{
			this.IVValue = new byte[8];
			Utils.StaticRandomNumberGenerator.GetBytes(this.IVValue);
		}

		// Token: 0x04002195 RID: 8597
		private bool m_use40bitSalt;

		// Token: 0x04002196 RID: 8598
		private static KeySizes[] s_legalKeySizes = new KeySizes[]
		{
			new KeySizes(40, 128, 8)
		};
	}
}
