using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Осуществляет доступ к управляемой версии алгоритма <see cref="T:System.Security.Cryptography.Rijndael" />. Этот класс не наследуется.</summary>
	// Token: 0x020004A4 RID: 1188
	[ComVisible(true)]
	public sealed class RijndaelManaged : Rijndael
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.RijndaelManaged" />.</summary>
		/// <exception cref="T:System.InvalidOperationException">Этот класс не соответствует стандарту FIPS.</exception>
		// Token: 0x06002F84 RID: 12164 RVA: 0x000A91BC File Offset: 0x000A73BC
		public RijndaelManaged()
		{
			if (CryptoConfig.AllowOnlyFipsAlgorithms)
			{
				throw new InvalidOperationException(Environment.GetResourceString("This implementation is not part of the Windows Platform FIPS validated cryptographic algorithms."));
			}
		}

		/// <summary>Создает объект-шифратор <see cref="T:System.Security.Cryptography.Rijndael" /> для алгоритма симметричного шифрования с заданным ключом (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" />) и вектором инициализации (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).</summary>
		/// <param name="rgbKey">Секретный ключ, используемый в алгоритме симметричного шифрования. Размер ключа должен составлять 128, 192 или 256 битов.</param>
		/// <param name="rgbIV">Вектор инициализации, используемый в алгоритме симметричного шифрования.</param>
		/// <returns>Объект-шифратор для алгоритма симметричного шифрования <see cref="T:System.Security.Cryptography.Rijndael" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="rgbKey" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Параметр <paramref name="rgbIV" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значение свойства <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Mode" /> не <see cref="F:System.Security.Cryptography.CipherMode.ECB" />, <see cref="F:System.Security.Cryptography.CipherMode.CBC" /> или <see cref="F:System.Security.Cryptography.CipherMode.CFB" />.</exception>
		// Token: 0x06002F85 RID: 12165 RVA: 0x000A91DB File Offset: 0x000A73DB
		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
		{
			return this.NewEncryptor(rgbKey, this.ModeValue, rgbIV, this.FeedbackSizeValue, RijndaelManagedTransformMode.Encrypt);
		}

		/// <summary>Создает объект-дешифратор <see cref="T:System.Security.Cryptography.Rijndael" /> для алгоритма симметричного шифрования с заданным ключом (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" />) и вектором инициализации (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).</summary>
		/// <param name="rgbKey">Секретный ключ, используемый в алгоритме симметричного шифрования. Размер ключа должен составлять 128, 192 или 256 битов.</param>
		/// <param name="rgbIV">Вектор инициализации, используемый в алгоритме симметричного шифрования.</param>
		/// <returns>Объект-дешифратор для алгоритма симметричного шифрования <see cref="T:System.Security.Cryptography.Rijndael" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="rgbKey" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Параметр <paramref name="rgbIV" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значение свойства <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Mode" /> не <see cref="F:System.Security.Cryptography.CipherMode.ECB" />, <see cref="F:System.Security.Cryptography.CipherMode.CBC" /> или <see cref="F:System.Security.Cryptography.CipherMode.CFB" />.</exception>
		// Token: 0x06002F86 RID: 12166 RVA: 0x000A91F2 File Offset: 0x000A73F2
		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
		{
			return this.NewEncryptor(rgbKey, this.ModeValue, rgbIV, this.FeedbackSizeValue, RijndaelManagedTransformMode.Decrypt);
		}

		/// <summary>Генерирует случайный ключ (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" />) для использования данным алгоритмом.</summary>
		// Token: 0x06002F87 RID: 12167 RVA: 0x000A9209 File Offset: 0x000A7409
		public override void GenerateKey()
		{
			this.KeyValue = Utils.GenerateRandom(this.KeySizeValue / 8);
		}

		/// <summary>Генерирует случайный вектор инициализации (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />) для использования данным алгоритмом.</summary>
		// Token: 0x06002F88 RID: 12168 RVA: 0x000A921E File Offset: 0x000A741E
		public override void GenerateIV()
		{
			this.IVValue = Utils.GenerateRandom(this.BlockSizeValue / 8);
		}

		// Token: 0x06002F89 RID: 12169 RVA: 0x000A9233 File Offset: 0x000A7433
		private ICryptoTransform NewEncryptor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int feedbackSize, RijndaelManagedTransformMode encryptMode)
		{
			if (rgbKey == null)
			{
				rgbKey = Utils.GenerateRandom(this.KeySizeValue / 8);
			}
			if (rgbIV == null)
			{
				rgbIV = Utils.GenerateRandom(this.BlockSizeValue / 8);
			}
			return new RijndaelManagedTransform(rgbKey, mode, rgbIV, this.BlockSizeValue, feedbackSize, this.PaddingValue, encryptMode);
		}
	}
}
