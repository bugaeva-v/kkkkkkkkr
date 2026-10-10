using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Представляет базовый класс, от которого наследуются все реализации алгоритма симметричного шифрования <see cref="T:System.Security.Cryptography.Rijndael" />.</summary>
	// Token: 0x020004A3 RID: 1187
	[ComVisible(true)]
	public abstract class Rijndael : SymmetricAlgorithm
	{
		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Security.Cryptography.Rijndael" />.</summary>
		// Token: 0x06002F80 RID: 12160 RVA: 0x000A9123 File Offset: 0x000A7323
		protected Rijndael()
		{
			this.KeySizeValue = 256;
			this.BlockSizeValue = 128;
			this.FeedbackSizeValue = this.BlockSizeValue;
			this.LegalBlockSizesValue = Rijndael.s_legalBlockSizes;
			this.LegalKeySizesValue = Rijndael.s_legalKeySizes;
		}

		/// <summary>Создает криптографический объект для выполнения алгоритма <see cref="T:System.Security.Cryptography.Rijndael" />.</summary>
		/// <returns>Криптографический объект.</returns>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Этот алгоритм был использован с включенным режимом FIPS, однако он не совместим с FIPS.</exception>
		// Token: 0x06002F81 RID: 12161 RVA: 0x000A9163 File Offset: 0x000A7363
		public new static Rijndael Create()
		{
			return Rijndael.Create("System.Security.Cryptography.Rijndael");
		}

		/// <summary>Создает криптографический объект для выполнения заданной реализации алгоритма <see cref="T:System.Security.Cryptography.Rijndael" />.</summary>
		/// <param name="algName">Имя конкретной реализации <see cref="T:System.Security.Cryptography.Rijndael" />, которую необходимо создать.</param>
		/// <returns>Криптографический объект.</returns>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Алгоритм, описание которого содержится в параметре<paramref name="algName" />, использовался с включенным режимом FIPS, но не является FIPS-совместимым.</exception>
		// Token: 0x06002F82 RID: 12162 RVA: 0x000A916F File Offset: 0x000A736F
		public new static Rijndael Create(string algName)
		{
			return (Rijndael)CryptoConfig.CreateFromName(algName);
		}

		// Token: 0x04002197 RID: 8599
		private static KeySizes[] s_legalBlockSizes = new KeySizes[]
		{
			new KeySizes(128, 256, 64)
		};

		// Token: 0x04002198 RID: 8600
		private static KeySizes[] s_legalKeySizes = new KeySizes[]
		{
			new KeySizes(128, 256, 64)
		};
	}
}
