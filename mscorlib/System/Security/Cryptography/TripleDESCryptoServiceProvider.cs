using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Определяет объект-оболочку для доступа к реализации алгоритма <see cref="T:System.Security.Cryptography.TripleDES" />, предоставляемой поставщиком служб шифрования (CSP). Этот класс не наследуется.</summary>
	// Token: 0x020004C1 RID: 1217
	[ComVisible(true)]
	public sealed class TripleDESCryptoServiceProvider : TripleDES
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.TripleDESCryptoServiceProvider" />.</summary>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Поставщик служб шифрования <see cref="T:System.Security.Cryptography.TripleDES" /> недоступен.</exception>
		// Token: 0x060030AF RID: 12463 RVA: 0x000B1251 File Offset: 0x000AF451
		[SecuritySafeCritical]
		public TripleDESCryptoServiceProvider()
		{
			if (!Utils.HasAlgorithm(26115, 0))
			{
				throw new CryptographicException(Environment.GetResourceString("Cryptographic service provider (CSP) could not be found for this algorithm."));
			}
			this.FeedbackSizeValue = 8;
		}

		/// <summary>Создает объект-шифратор для алгоритма симметричного шифрования <see cref="T:System.Security.Cryptography.TripleDES" /> с заданным ключом (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" />) и вектором инициализации (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).</summary>
		/// <param name="rgbKey">Секретный ключ, который должен использоваться для симметричного алгоритма.</param>
		/// <param name="rgbIV">Вектор инициализации, который должен использоваться для симметричного алгоритма.  
		///
		///  Вектор инициализации должен быть длиной 8 байт. Если более чем 8 байт, усекается и исключение не создается. Перед вызовом <see cref="M:System.Security.Cryptography.TripleDESCryptoServiceProvider.CreateEncryptor(System.Byte[],System.Byte[])" />, проверьте длину вектора инициализации и создайте исключение, если оно слишком длинное.</param>
		/// <returns>Объект-шифратор для алгоритма симметричного шифрования <see cref="T:System.Security.Cryptography.TripleDES" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значение свойства <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Mode" /> равно <see cref="F:System.Security.Cryptography.CipherMode.OFB" />.  
		/// -или- 
		/// Значение свойства <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Mode" /> равно <see cref="F:System.Security.Cryptography.CipherMode.CFB" /> и значение свойства <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.FeedbackSize" /> не равно 8.  
		/// -или- 
		/// Недопустимый размер ключа.  
		/// -или- 
		/// Данные о размере ключа, используемого в алгоритме, недоступны.</exception>
		// Token: 0x060030B0 RID: 12464 RVA: 0x000B127D File Offset: 0x000AF47D
		[SecuritySafeCritical]
		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
		{
			if (TripleDES.IsWeakKey(rgbKey))
			{
				throw new CryptographicException(Environment.GetResourceString("Specified key is a known weak key for '{0}' and cannot be used."), "TripleDES");
			}
			return new TripleDESTransform(this, true, rgbKey, rgbIV);
		}

		/// <summary>Создает объект-дешифратор для алгоритма симметричного шифрования <see cref="T:System.Security.Cryptography.TripleDES" /> с заданным ключом (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" />) и вектором инициализации (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).</summary>
		/// <param name="rgbKey">Секретный ключ, который должен использоваться для симметричного алгоритма.</param>
		/// <param name="rgbIV">Вектор инициализации, который должен использоваться для симметричного алгоритма.</param>
		/// <returns>Объект-дешифратор для алгоритма симметричного шифрования <see cref="T:System.Security.Cryptography.TripleDES" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значение свойства <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Mode" /> равно <see cref="F:System.Security.Cryptography.CipherMode.OFB" />.  
		/// -или- 
		/// Значение свойства <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Mode" /> равно <see cref="F:System.Security.Cryptography.CipherMode.CFB" /> и значение свойства <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.FeedbackSize" /> не равно 8.  
		/// -или- 
		/// Недопустимый размер ключа.  
		///
		/// или - 
		/// Данные о размере ключа, используемого в алгоритме, недоступны.</exception>
		// Token: 0x060030B1 RID: 12465 RVA: 0x000B12A5 File Offset: 0x000AF4A5
		[SecuritySafeCritical]
		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
		{
			if (TripleDES.IsWeakKey(rgbKey))
			{
				throw new CryptographicException(Environment.GetResourceString("Specified key is a known weak key for '{0}' and cannot be used."), "TripleDES");
			}
			return new TripleDESTransform(this, false, rgbKey, rgbIV);
		}

		/// <summary>Генерирует случайный ключ (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" />) для использования данным алгоритмом.</summary>
		// Token: 0x060030B2 RID: 12466 RVA: 0x000B12D0 File Offset: 0x000AF4D0
		public override void GenerateKey()
		{
			this.KeyValue = new byte[this.KeySizeValue / 8];
			Utils.StaticRandomNumberGenerator.GetBytes(this.KeyValue);
			while (TripleDES.IsWeakKey(this.KeyValue))
			{
				Utils.StaticRandomNumberGenerator.GetBytes(this.KeyValue);
			}
		}

		/// <summary>Создает случайный вектор инициализации (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />), используемый для данного алгоритма.</summary>
		// Token: 0x060030B3 RID: 12467 RVA: 0x000A6F11 File Offset: 0x000A5111
		public override void GenerateIV()
		{
			this.IVValue = new byte[8];
			Utils.StaticRandomNumberGenerator.GetBytes(this.IVValue);
		}
	}
}
