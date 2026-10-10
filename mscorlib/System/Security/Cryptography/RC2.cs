using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Представляет базовый класс, от которого должны производиться все реализации алгоритма <see cref="T:System.Security.Cryptography.RC2" />.</summary>
	// Token: 0x020004A1 RID: 1185
	[ComVisible(true)]
	public abstract class RC2 : SymmetricAlgorithm
	{
		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Security.Cryptography.RC2" />.</summary>
		// Token: 0x06002F6E RID: 12142 RVA: 0x000A8EEA File Offset: 0x000A70EA
		protected RC2()
		{
			this.KeySizeValue = 128;
			this.BlockSizeValue = 64;
			this.FeedbackSizeValue = this.BlockSizeValue;
			this.LegalBlockSizesValue = RC2.s_legalBlockSizes;
			this.LegalKeySizesValue = RC2.s_legalKeySizes;
		}

		/// <summary>Получает или задает эффективный размер секретного ключа, используемого алгоритмом <see cref="T:System.Security.Cryptography.RC2" />, в битах.</summary>
		/// <returns>Эффективный размер ключа, используемого алгоритмом <see cref="T:System.Security.Cryptography.RC2" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Недопустимый эффективный размер ключа.</exception>
		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06002F6F RID: 12143 RVA: 0x000A8F27 File Offset: 0x000A7127
		// (set) Token: 0x06002F70 RID: 12144 RVA: 0x000A8F40 File Offset: 0x000A7140
		public virtual int EffectiveKeySize
		{
			get
			{
				if (this.EffectiveKeySizeValue == 0)
				{
					return this.KeySizeValue;
				}
				return this.EffectiveKeySizeValue;
			}
			set
			{
				if (value > this.KeySizeValue)
				{
					throw new CryptographicException(Environment.GetResourceString("EffectiveKeySize value must be at least as large as the KeySize value."));
				}
				if (value == 0)
				{
					this.EffectiveKeySizeValue = value;
					return;
				}
				if (value < 40)
				{
					throw new CryptographicException(Environment.GetResourceString("EffectiveKeySize value must be at least 40 bits."));
				}
				if (base.ValidKeySize(value))
				{
					this.EffectiveKeySizeValue = value;
					return;
				}
				throw new CryptographicException(Environment.GetResourceString("Specified key is not a valid size for this algorithm."));
			}
		}

		/// <summary>Получает или задает размер секретного ключа, используемого алгоритмом <see cref="T:System.Security.Cryptography.RC2" />, в битах.</summary>
		/// <returns>Размер секретного ключа, используемого алгоритмом <see cref="T:System.Security.Cryptography.RC2" />, в битах.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значение для размера ключа RC2 меньше значения эффективного размера ключа.</exception>
		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06002F71 RID: 12145 RVA: 0x000A8FA6 File Offset: 0x000A71A6
		// (set) Token: 0x06002F72 RID: 12146 RVA: 0x000A8FAE File Offset: 0x000A71AE
		public override int KeySize
		{
			get
			{
				return this.KeySizeValue;
			}
			set
			{
				if (value < this.EffectiveKeySizeValue)
				{
					throw new CryptographicException(Environment.GetResourceString("EffectiveKeySize value must be at least as large as the KeySize value."));
				}
				base.KeySize = value;
			}
		}

		/// <summary>Создает экземпляр криптографического объекта для выполнения алгоритма <see cref="T:System.Security.Cryptography.RC2" />.</summary>
		/// <returns>Экземпляр криптографического объекта.</returns>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Этот алгоритм был использован с включенным режимом FIPS, однако он не совместим с FIPS.</exception>
		// Token: 0x06002F73 RID: 12147 RVA: 0x000A8FD0 File Offset: 0x000A71D0
		public new static RC2 Create()
		{
			return RC2.Create("System.Security.Cryptography.RC2");
		}

		/// <summary>Создает экземпляр криптографического объекта для выполнения заданной реализации алгоритма <see cref="T:System.Security.Cryptography.RC2" />.</summary>
		/// <param name="AlgName">Имя конкретной реализации <see cref="T:System.Security.Cryptography.RC2" />, которую требуется использовать.</param>
		/// <returns>Экземпляр криптографического объекта.</returns>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Алгоритм, описание которого содержится в параметре<paramref name="algName" />, использовался с включенным режимом FIPS, но не является FIPS-совместимым.</exception>
		// Token: 0x06002F74 RID: 12148 RVA: 0x000A8FDC File Offset: 0x000A71DC
		public new static RC2 Create(string AlgName)
		{
			return (RC2)CryptoConfig.CreateFromName(AlgName);
		}

		/// <summary>Представляет эффективный размер секретного ключа (в битах), используемого алгоритмом <see cref="T:System.Security.Cryptography.RC2" />.</summary>
		// Token: 0x04002192 RID: 8594
		protected int EffectiveKeySizeValue;

		// Token: 0x04002193 RID: 8595
		private static KeySizes[] s_legalBlockSizes = new KeySizes[]
		{
			new KeySizes(64, 64, 0)
		};

		// Token: 0x04002194 RID: 8596
		private static KeySizes[] s_legalKeySizes = new KeySizes[]
		{
			new KeySizes(40, 1024, 8)
		};
	}
}
