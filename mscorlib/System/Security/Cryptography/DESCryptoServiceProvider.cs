using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Определяет объект-оболочку для доступа к версии алгоритма <see cref="T:System.Security.Cryptography.DES" />, предоставляемой поставщиком служб шифрования (CSP). Этот класс не наследуется.</summary>
	// Token: 0x02000489 RID: 1161
	[ComVisible(true)]
	public sealed class DESCryptoServiceProvider : DES
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.DESCryptoServiceProvider" />.</summary>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Поставщик служб шифрования <see cref="T:System.Security.Cryptography.DES" /> недоступен.</exception>
		// Token: 0x06002EC0 RID: 11968 RVA: 0x000A6DF0 File Offset: 0x000A4FF0
		[SecuritySafeCritical]
		public DESCryptoServiceProvider()
		{
			if (!Utils.HasAlgorithm(26113, 0))
			{
				throw new CryptographicException(Environment.GetResourceString("Cryptographic service provider (CSP) could not be found for this algorithm."));
			}
			this.FeedbackSizeValue = 8;
		}

		/// <summary>Создает объект-шифратор для алгоритма симметричного шифрования <see cref="T:System.Security.Cryptography.DES" /> с заданным ключом (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" />) и вектором инициализации (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).</summary>
		/// <param name="rgbKey">Секретный ключ, который должен использоваться для симметричного алгоритма.</param>
		/// <param name="rgbIV">Вектор инициализации, который должен использоваться для симметричного алгоритма.</param>
		/// <returns>Объект-шифратор для алгоритма симметричного шифрования <see cref="T:System.Security.Cryptography.DES" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значение свойства <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Mode" /> равно <see cref="F:System.Security.Cryptography.CipherMode.OFB" />.  
		///
		/// или - 
		/// Значение свойства <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Mode" /> равно <see cref="F:System.Security.Cryptography.CipherMode.CFB" /> и значение свойства <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.FeedbackSize" /> не равно 8.  
		///
		/// или - 
		/// Недопустимый размер ключа.  
		///
		/// или - 
		/// Данные о размере ключа, используемого в алгоритме, недоступны.</exception>
		// Token: 0x06002EC1 RID: 11969 RVA: 0x000A6E1C File Offset: 0x000A501C
		[SecuritySafeCritical]
		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
		{
			if (DES.IsWeakKey(rgbKey))
			{
				throw new CryptographicException(Environment.GetResourceString("Specified key is a known weak key for '{0}' and cannot be used."), "DES");
			}
			if (DES.IsSemiWeakKey(rgbKey))
			{
				throw new CryptographicException(Environment.GetResourceString("Specified key is a known semi-weak key for '{0}' and cannot be used."), "DES");
			}
			return new DESTransform(this, true, rgbKey, rgbIV);
		}

		/// <summary>Создает объект-дешифратор для алгоритма симметричного шифрования <see cref="T:System.Security.Cryptography.DES" /> с заданным ключом (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" />) и вектором инициализации (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />).</summary>
		/// <param name="rgbKey">Секретный ключ, который должен использоваться для симметричного алгоритма.</param>
		/// <param name="rgbIV">Вектор инициализации, который должен использоваться для симметричного алгоритма.</param>
		/// <returns>Объект-дешифратор для алгоритма симметричного шифрования <see cref="T:System.Security.Cryptography.DES" />.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Значение свойства <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Mode" /> равно <see cref="F:System.Security.Cryptography.CipherMode.OFB" />.  
		///
		/// или - 
		/// Значение свойства <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Mode" /> равно <see cref="F:System.Security.Cryptography.CipherMode.CFB" /> и значение свойства <see cref="P:System.Security.Cryptography.SymmetricAlgorithm.FeedbackSize" /> не равно 8.  
		///
		/// или - 
		/// Недопустимый размер ключа.  
		///
		/// или - 
		/// Данные о размере ключа, используемого в алгоритме, недоступны.</exception>
		// Token: 0x06002EC2 RID: 11970 RVA: 0x000A6E6C File Offset: 0x000A506C
		[SecuritySafeCritical]
		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
		{
			if (DES.IsWeakKey(rgbKey))
			{
				throw new CryptographicException(Environment.GetResourceString("Specified key is a known weak key for '{0}' and cannot be used."), "DES");
			}
			if (DES.IsSemiWeakKey(rgbKey))
			{
				throw new CryptographicException(Environment.GetResourceString("Specified key is a known semi-weak key for '{0}' and cannot be used."), "DES");
			}
			return new DESTransform(this, false, rgbKey, rgbIV);
		}

		/// <summary>Создает случайный ключ (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.Key" />), используемый для данного алгоритма.</summary>
		// Token: 0x06002EC3 RID: 11971 RVA: 0x000A6EBC File Offset: 0x000A50BC
		public override void GenerateKey()
		{
			this.KeyValue = new byte[8];
			Utils.StaticRandomNumberGenerator.GetBytes(this.KeyValue);
			while (DES.IsWeakKey(this.KeyValue) || DES.IsSemiWeakKey(this.KeyValue))
			{
				Utils.StaticRandomNumberGenerator.GetBytes(this.KeyValue);
			}
		}

		/// <summary>Создает случайный вектор инициализации (<see cref="P:System.Security.Cryptography.SymmetricAlgorithm.IV" />), используемый для данного алгоритма.</summary>
		// Token: 0x06002EC4 RID: 11972 RVA: 0x000A6F11 File Offset: 0x000A5111
		public override void GenerateIV()
		{
			this.IVValue = new byte[8];
			Utils.StaticRandomNumberGenerator.GetBytes(this.IVValue);
		}
	}
}
