using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Представляет базовый класс для алгоритмов DES, от которых должны наследовать все реализации <see cref="T:System.Security.Cryptography.DES" />.</summary>
	// Token: 0x02000488 RID: 1160
	[ComVisible(true)]
	public abstract class DES : SymmetricAlgorithm
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.DES" />.</summary>
		// Token: 0x06002EB6 RID: 11958 RVA: 0x000A6B2A File Offset: 0x000A4D2A
		protected DES()
		{
			this.KeySizeValue = 64;
			this.BlockSizeValue = 64;
			this.FeedbackSizeValue = this.BlockSizeValue;
			this.LegalBlockSizesValue = DES.s_legalBlockSizes;
			this.LegalKeySizesValue = DES.s_legalKeySizes;
		}

		/// <summary>Получает или задает секретный ключ для алгоритма DES (<see cref="T:System.Security.Cryptography.DES" />).</summary>
		/// <returns>Секретный ключ для алгоритма <see cref="T:System.Security.Cryptography.DES" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Предпринята попытка установить для этого ключа значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Предпринята попытка установить ключ, длина которого не равна <see cref="F:System.Security.Cryptography.SymmetricAlgorithm.BlockSizeValue" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Предпринята попытка установить слабый ключ (см. <see cref="M:System.Security.Cryptography.DES.IsWeakKey(System.Byte[])" />) или частично слабый ключ (см. <see cref="M:System.Security.Cryptography.DES.IsSemiWeakKey(System.Byte[])" />).</exception>
		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06002EB7 RID: 11959 RVA: 0x000A6B64 File Offset: 0x000A4D64
		// (set) Token: 0x06002EB8 RID: 11960 RVA: 0x000A6BA0 File Offset: 0x000A4DA0
		public override byte[] Key
		{
			get
			{
				if (this.KeyValue == null)
				{
					do
					{
						this.GenerateKey();
					}
					while (DES.IsWeakKey(this.KeyValue) || DES.IsSemiWeakKey(this.KeyValue));
				}
				return (byte[])this.KeyValue.Clone();
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				if (!base.ValidKeySize(value.Length * 8))
				{
					throw new ArgumentException(Environment.GetResourceString("Specified key is not a valid size for this algorithm."));
				}
				if (DES.IsWeakKey(value))
				{
					throw new CryptographicException(Environment.GetResourceString("Specified key is a known weak key for '{0}' and cannot be used."), "DES");
				}
				if (DES.IsSemiWeakKey(value))
				{
					throw new CryptographicException(Environment.GetResourceString("Specified key is a known semi-weak key for '{0}' and cannot be used."), "DES");
				}
				this.KeyValue = (byte[])value.Clone();
				this.KeySizeValue = value.Length * 8;
			}
		}

		/// <summary>Создает экземпляр криптографического объекта для выполнения алгоритма DES (<see cref="T:System.Security.Cryptography.DES" />).</summary>
		/// <returns>Криптографический объект.</returns>
		// Token: 0x06002EB9 RID: 11961 RVA: 0x000A6C2E File Offset: 0x000A4E2E
		public new static DES Create()
		{
			return DES.Create("System.Security.Cryptography.DES");
		}

		/// <summary>Создает экземпляр криптографического объекта для выполнения заданной реализации алгоритма <see cref="T:System.Security.Cryptography.DES" />.</summary>
		/// <param name="algName">Имя конкретной реализации <see cref="T:System.Security.Cryptography.DES" />, которую требуется использовать.</param>
		/// <returns>Криптографический объект.</returns>
		// Token: 0x06002EBA RID: 11962 RVA: 0x000A6C3A File Offset: 0x000A4E3A
		public new static DES Create(string algName)
		{
			return (DES)CryptoConfig.CreateFromName(algName);
		}

		/// <summary>Определяет, является ли указанный ключ слабым.</summary>
		/// <param name="rgbKey">Секретный ключ, проверяемый на слабость.</param>
		/// <returns>Значение <see langword="true" />, если ключ слабый; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Недопустимый размер параметра <paramref name="rgbKey" />.</exception>
		// Token: 0x06002EBB RID: 11963 RVA: 0x000A6C48 File Offset: 0x000A4E48
		public static bool IsWeakKey(byte[] rgbKey)
		{
			if (!DES.IsLegalKeySize(rgbKey))
			{
				throw new CryptographicException(Environment.GetResourceString("Specified key is not a valid size for this algorithm."));
			}
			ulong num = DES.QuadWordFromBigEndian(Utils.FixupKeyParity(rgbKey));
			return num == 72340172838076673UL || num == 18374403900871474942UL || num == 2242545357694045710UL || num == 16204198716015505905UL;
		}

		/// <summary>Определяет, является ли указанный ключ частично слабым.</summary>
		/// <param name="rgbKey">Секретный ключ, проверяемый на частичную слабость.</param>
		/// <returns>Значение <see langword="true" />, если ключ частично слабый; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Недопустимый размер параметра <paramref name="rgbKey" />.</exception>
		// Token: 0x06002EBC RID: 11964 RVA: 0x000A6CAC File Offset: 0x000A4EAC
		public static bool IsSemiWeakKey(byte[] rgbKey)
		{
			if (!DES.IsLegalKeySize(rgbKey))
			{
				throw new CryptographicException(Environment.GetResourceString("Specified key is not a valid size for this algorithm."));
			}
			ulong num = DES.QuadWordFromBigEndian(Utils.FixupKeyParity(rgbKey));
			return num == 143554428589179390UL || num == 18303189645120372225UL || num == 2296870857142767345UL || num == 16149873216566784270UL || num == 135110050437988849UL || num == 16141428838415593729UL || num == 2305315235293957886UL || num == 18311634023271562766UL || num == 80784550989267214UL || num == 2234100979542855169UL || num == 16212643094166696446UL || num == 18365959522720284401UL;
		}

		// Token: 0x06002EBD RID: 11965 RVA: 0x000A6D73 File Offset: 0x000A4F73
		private static bool IsLegalKeySize(byte[] rgbKey)
		{
			return rgbKey != null && rgbKey.Length == 8;
		}

		// Token: 0x06002EBE RID: 11966 RVA: 0x000A6D81 File Offset: 0x000A4F81
		private static ulong QuadWordFromBigEndian(byte[] block)
		{
			return (ulong)block[0] << 56 | (ulong)block[1] << 48 | (ulong)block[2] << 40 | (ulong)block[3] << 32 | (ulong)block[4] << 24 | (ulong)block[5] << 16 | (ulong)block[6] << 8 | (ulong)block[7];
		}

		// Token: 0x04002157 RID: 8535
		private static KeySizes[] s_legalBlockSizes = new KeySizes[]
		{
			new KeySizes(64, 64, 0)
		};

		// Token: 0x04002158 RID: 8536
		private static KeySizes[] s_legalKeySizes = new KeySizes[]
		{
			new KeySizes(64, 64, 0)
		};
	}
}
