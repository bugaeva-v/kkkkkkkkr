using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Представляет абстрактный базовый класс, от которого наследуются все реализации симметричных алгоритмов шифрования.</summary>
	// Token: 0x020004BF RID: 1215
	[ComVisible(true)]
	public abstract class SymmetricAlgorithm : IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.SymmetricAlgorithm" />.</summary>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Реализация производного класса алгоритма симметричного шифрования не является допустимой.</exception>
		// Token: 0x06003089 RID: 12425 RVA: 0x000B0CCE File Offset: 0x000AEECE
		protected SymmetricAlgorithm()
		{
			this.ModeValue = CipherMode.CBC;
			this.PaddingValue = PaddingMode.PKCS7;
		}

		/// <summary>Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.Security.Cryptography.SymmetricAlgorithm" />.</summary>
		// Token: 0x0600308A RID: 12426 RVA: 0x000B0CE4 File Offset: 0x000AEEE4
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает все ресурсы, используемые классом <see cref="T:System.Security.Cryptography.SymmetricAlgorithm" />.</summary>
		// Token: 0x0600308B RID: 12427 RVA: 0x000A5C13 File Offset: 0x000A3E13
		public void Clear()
		{
			((IDisposable)this).Dispose();
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Security.Cryptography.SymmetricAlgorithm" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x0600308C RID: 12428 RVA: 0x000B0CF4 File Offset: 0x000AEEF4
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.KeyValue != null)
				{
					Array.Clear(this.KeyValue, 0, this.KeyValue.Length);
					this.KeyValue = null;
				}
				if (this.IVValue != null)
				{
					Array.Clear(this.IVValue, 0, this.IVValue.Length);
					this.IVValue = null;
				}
			}
		}

		/// <summary>Возвращает или задает размер блока криптографической операции (в битах).</summary>
		/// <returns>Размер блока в битах.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Недопустимый размер блока.</exception>
		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x0600308D RID: 12429 RVA: 0x000B0D4A File Offset: 0x000AEF4A
		// (set) Token: 0x0600308E RID: 12430 RVA: 0x000B0D54 File Offset: 0x000AEF54
		public virtual int BlockSize
		{
			get
			{
				return this.BlockSizeValue;
			}
			set
			{
				for (int i = 0; i < this.LegalBlockSizesValue.Length; i++)
				{
					if (this.LegalBlockSizesValue[i].SkipSize == 0)
					{
						if (this.LegalBlockSizesValue[i].MinSize == value)
						{
							this.BlockSizeValue = value;
							this.IVValue = null;
							return;
						}
					}
					else
					{
						for (int j = this.LegalBlockSizesValue[i].MinSize; j <= this.LegalBlockSizesValue[i].MaxSize; j += this.LegalBlockSizesValue[i].SkipSize)
						{
							if (j == value)
							{
								if (this.BlockSizeValue != value)
								{
									this.BlockSizeValue = value;
									this.IVValue = null;
								}
								return;
							}
						}
					}
				}
				throw new CryptographicException(Environment.GetResourceString("Specified block size is not valid for this algorithm."));
			}
		}

		/// <summary>Возвращает или задает размер ответа в криптографической операции (в битах).</summary>
		/// <returns>Размер ответа в битах.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Размер порции данных обратной связи превышает размер блока.</exception>
		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x0600308F RID: 12431 RVA: 0x000B0E00 File Offset: 0x000AF000
		// (set) Token: 0x06003090 RID: 12432 RVA: 0x000B0E08 File Offset: 0x000AF008
		public virtual int FeedbackSize
		{
			get
			{
				return this.FeedbackSizeValue;
			}
			set
			{
				if (value <= 0 || value > this.BlockSizeValue || value % 8 != 0)
				{
					throw new CryptographicException(Environment.GetResourceString("Specified feedback size is invalid."));
				}
				this.FeedbackSizeValue = value;
			}
		}

		/// <summary>Возвращает или задает вектор инициализации (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />) для симметричного алгоритма.</summary>
		/// <returns>Вектор инициализации.</returns>
		/// <exception cref="T:System.ArgumentNullException">Предпринята попытка задания для вектора инициализации значения <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Предпринята попытка задания недопустимого размера вектора инициализации.</exception>
		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06003091 RID: 12433 RVA: 0x000B0E33 File Offset: 0x000AF033
		// (set) Token: 0x06003092 RID: 12434 RVA: 0x000B0E53 File Offset: 0x000AF053
		public virtual byte[] IV
		{
			get
			{
				if (this.IVValue == null)
				{
					this.GenerateIV();
				}
				return (byte[])this.IVValue.Clone();
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				if (value.Length != this.BlockSizeValue / 8)
				{
					throw new CryptographicException(Environment.GetResourceString("Specified initialization vector (IV) does not match the block size for this algorithm."));
				}
				this.IVValue = (byte[])value.Clone();
			}
		}

		/// <summary>Возвращает или задает секретный ключ для симметричного алгоритма.</summary>
		/// <returns>Секретный ключ, который должен использоваться для симметричного алгоритма.</returns>
		/// <exception cref="T:System.ArgumentNullException">Предпринята попытка установить для этого ключа значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Недопустимый размер ключа.</exception>
		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06003093 RID: 12435 RVA: 0x0000DD46 File Offset: 0x0000BF46
		// (set) Token: 0x06003094 RID: 12436 RVA: 0x000B0E94 File Offset: 0x000AF094
		public virtual byte[] Key
		{
			get
			{
				if (this.KeyValue == null)
				{
					this.GenerateKey();
				}
				return (byte[])this.KeyValue.Clone();
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				if (!this.ValidKeySize(value.Length * 8))
				{
					throw new CryptographicException(Environment.GetResourceString("Specified key is not a valid size for this algorithm."));
				}
				this.KeyValue = (byte[])value.Clone();
				this.KeySizeValue = value.Length * 8;
			}
		}

		/// <summary>Возвращает размеры блоков (в битах), которые поддерживаются симметричным алгоритмом.</summary>
		/// <returns>Массив, в котором содержатся размеры блоков, поддерживаемые данным алгоритмом.</returns>
		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06003095 RID: 12437 RVA: 0x000B0EE8 File Offset: 0x000AF0E8
		public virtual KeySizes[] LegalBlockSizes
		{
			get
			{
				return (KeySizes[])this.LegalBlockSizesValue.Clone();
			}
		}

		/// <summary>Возвращает размеры ключа (в битах), которые поддерживаются симметричным алгоритмом.</summary>
		/// <returns>Массив, содержащий размеры ключа, поддерживаемые алгоритмом.</returns>
		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06003096 RID: 12438 RVA: 0x000B0EFA File Offset: 0x000AF0FA
		public virtual KeySizes[] LegalKeySizes
		{
			get
			{
				return (KeySizes[])this.LegalKeySizesValue.Clone();
			}
		}

		/// <summary>Возвращает или задает размер секретного ключа (в битах), используемого симметричным алгоритмом.</summary>
		/// <returns>Размер секретного ключа (в битах), используемого симметричным алгоритмом.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Недопустимый размер ключа.</exception>
		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06003097 RID: 12439 RVA: 0x000A8FA6 File Offset: 0x000A71A6
		// (set) Token: 0x06003098 RID: 12440 RVA: 0x000B0F0C File Offset: 0x000AF10C
		public virtual int KeySize
		{
			get
			{
				return this.KeySizeValue;
			}
			set
			{
				if (!this.ValidKeySize(value))
				{
					throw new CryptographicException(Environment.GetResourceString("Specified key is not a valid size for this algorithm."));
				}
				this.KeySizeValue = value;
				this.KeyValue = null;
			}
		}

		/// <summary>Возвращает или задает режим функционирования симметричного алгоритма.</summary>
		/// <returns>Режим функционирования симметричного алгоритма. Значение по умолчанию — <see cref="F:System.Security.Cryptography.CipherMode.CBC" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Данный режим шифрования отличается от значений свойства <see cref="T:System.Security.Cryptography.CipherMode" />.</exception>
		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06003099 RID: 12441 RVA: 0x000B0F35 File Offset: 0x000AF135
		// (set) Token: 0x0600309A RID: 12442 RVA: 0x000B0F3D File Offset: 0x000AF13D
		public virtual CipherMode Mode
		{
			get
			{
				return this.ModeValue;
			}
			set
			{
				if (value < CipherMode.CBC || CipherMode.CFB < value)
				{
					throw new CryptographicException(Environment.GetResourceString("Specified cipher mode is not valid for this algorithm."));
				}
				this.ModeValue = value;
			}
		}

		/// <summary>Возвращает или задает режим заполнения, используемый в симметричном алгоритме.</summary>
		/// <returns>Режим заполнения, используемый в симметричном алгоритме. Значение по умолчанию — <see cref="F:System.Security.Cryptography.PaddingMode.PKCS7" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Данный режим заполнения отличается от значений свойства <see cref="T:System.Security.Cryptography.PaddingMode" />.</exception>
		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x0600309B RID: 12443 RVA: 0x000B0F5E File Offset: 0x000AF15E
		// (set) Token: 0x0600309C RID: 12444 RVA: 0x000B0F66 File Offset: 0x000AF166
		public virtual PaddingMode Padding
		{
			get
			{
				return this.PaddingValue;
			}
			set
			{
				if (value < PaddingMode.None || PaddingMode.ISO10126 < value)
				{
					throw new CryptographicException(Environment.GetResourceString("Specified padding mode is not valid for this algorithm."));
				}
				this.PaddingValue = value;
			}
		}

		/// <summary>Определяет допустимость указанного размера ключа для текущего алгоритма.</summary>
		/// <param name="bitLength">Длина в битах для проверки допустимости размера ключа.</param>
		/// <returns>Значение <see langword="true" />, если заданный размер ключа допустим для текущего алгоритма; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600309D RID: 12445 RVA: 0x000B0F88 File Offset: 0x000AF188
		public bool ValidKeySize(int bitLength)
		{
			KeySizes[] legalKeySizes = this.LegalKeySizes;
			if (legalKeySizes == null)
			{
				return false;
			}
			for (int i = 0; i < legalKeySizes.Length; i++)
			{
				if (legalKeySizes[i].SkipSize == 0)
				{
					if (legalKeySizes[i].MinSize == bitLength)
					{
						return true;
					}
				}
				else
				{
					for (int j = legalKeySizes[i].MinSize; j <= legalKeySizes[i].MaxSize; j += legalKeySizes[i].SkipSize)
					{
						if (j == bitLength)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		/// <summary>Создает криптографический объект по умолчанию, используемый для выполнения симметричного алгоритма.</summary>
		/// <returns>Криптографический объект по умолчанию, используемый для выполнения симметричного алгоритма.</returns>
		// Token: 0x0600309E RID: 12446 RVA: 0x000B0FEE File Offset: 0x000AF1EE
		public static SymmetricAlgorithm Create()
		{
			return SymmetricAlgorithm.Create("System.Security.Cryptography.SymmetricAlgorithm");
		}

		/// <summary>Создает заданный криптографический объект, используемый для выполнения симметричного алгоритма.</summary>
		/// <param name="algName">Имя конкретной реализации класса <see cref="T:System.Security.Cryptography.SymmetricAlgorithm" /> для использования.</param>
		/// <returns>Криптографический объект, используемый для выполнения симметричного алгоритма.</returns>
		// Token: 0x0600309F RID: 12447 RVA: 0x000B0FFA File Offset: 0x000AF1FA
		public static SymmetricAlgorithm Create(string algName)
		{
			return (SymmetricAlgorithm)CryptoConfig.CreateFromName(algName);
		}

		/// <summary>Создает симметричный объект-шифратор с текущим свойством <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" /> и вектором инициализации (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).</summary>
		/// <returns>Симметричный объект-шифратор.</returns>
		// Token: 0x060030A0 RID: 12448 RVA: 0x000B1007 File Offset: 0x000AF207
		public virtual ICryptoTransform CreateEncryptor()
		{
			return this.CreateEncryptor(this.Key, this.IV);
		}

		/// <summary>Если переопределено в производном классе, создает симметричный объект-шифратор с заданным свойством <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" /> и вектором инициализации (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).</summary>
		/// <param name="rgbKey">Секретный ключ, который должен использоваться для симметричного алгоритма.</param>
		/// <param name="rgbIV">Вектор инициализации, который должен использоваться для симметричного алгоритма.</param>
		/// <returns>Симметричный объект-шифратор.</returns>
		// Token: 0x060030A1 RID: 12449
		public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV);

		/// <summary>Создает симметричный объект-дешифратор с текущим свойством <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" /> и вектором инициализации (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).</summary>
		/// <returns>Симметричный объект-дешифратор.</returns>
		// Token: 0x060030A2 RID: 12450 RVA: 0x000B101B File Offset: 0x000AF21B
		public virtual ICryptoTransform CreateDecryptor()
		{
			return this.CreateDecryptor(this.Key, this.IV);
		}

		/// <summary>При переопределении в производном классе создает симметричный объект-дешифратор с указанным свойством <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" /> и вектором инициализации (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).</summary>
		/// <param name="rgbKey">Секретный ключ, который должен использоваться для симметричного алгоритма.</param>
		/// <param name="rgbIV">Вектор инициализации, который должен использоваться для симметричного алгоритма.</param>
		/// <returns>Симметричный объект-дешифратор.</returns>
		// Token: 0x060030A3 RID: 12451
		public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV);

		/// <summary>Если переопределено в производном классе, генерирует произвольный ключ (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" />), используемый для алгоритма.</summary>
		// Token: 0x060030A4 RID: 12452
		public abstract void GenerateKey();

		/// <summary>Если переопределено в производном классе, создает произвольный вектор инициализации (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />), используемый для алгоритма.</summary>
		// Token: 0x060030A5 RID: 12453
		public abstract void GenerateIV();

		/// <summary>Представляет размер блока криптографической операции (в битах).</summary>
		// Token: 0x040021EE RID: 8686
		protected int BlockSizeValue;

		/// <summary>Представляет размер ответа в криптографической операции (в битах).</summary>
		// Token: 0x040021EF RID: 8687
		protected int FeedbackSizeValue;

		/// <summary>Представляет вектор инициализации (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />) для симметричного алгоритма.</summary>
		// Token: 0x040021F0 RID: 8688
		protected byte[] IVValue;

		/// <summary>Представляет секретный ключ для симметричного алгоритма.</summary>
		// Token: 0x040021F1 RID: 8689
		protected byte[] KeyValue;

		/// <summary>Задает размеры блоков (в битах), которые поддерживаются симметричным алгоритмом.</summary>
		// Token: 0x040021F2 RID: 8690
		protected KeySizes[] LegalBlockSizesValue;

		/// <summary>Задает размеры ключей в битах, которые поддерживаются симметричным алгоритмом.</summary>
		// Token: 0x040021F3 RID: 8691
		protected KeySizes[] LegalKeySizesValue;

		/// <summary>Представляет размер секретного ключа (в битах), используемого симметричным алгоритмом.</summary>
		// Token: 0x040021F4 RID: 8692
		protected int KeySizeValue;

		/// <summary>Представляет режим шифрования, используемый в симметричном алгоритме.</summary>
		// Token: 0x040021F5 RID: 8693
		protected CipherMode ModeValue;

		/// <summary>Представляет режим заполнения, используемый в симметричном алгоритме.</summary>
		// Token: 0x040021F6 RID: 8694
		protected PaddingMode PaddingValue;
	}
}
