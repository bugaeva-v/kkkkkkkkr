using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Вычисляет хэш <see cref="T:System.Security.Cryptography.SHA512" /> для входных данных.</summary>
	// Token: 0x020004B6 RID: 1206
	[ComVisible(true)]
	public abstract class SHA512 : HashAlgorithm
	{
		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Security.Cryptography.SHA512" />.</summary>
		// Token: 0x06003060 RID: 12384 RVA: 0x000B0386 File Offset: 0x000AE586
		protected SHA512()
		{
			this.HashSizeValue = 512;
		}

		/// <summary>Создает экземпляр реализации класса <see cref="T:System.Security.Cryptography.SHA512" /> по умолчанию.</summary>
		/// <returns>Новый экземпляр класса <see cref="T:System.Security.Cryptography.SHA512" />.</returns>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Этот алгоритм был использован с включенным режимом FIPS, однако он не совместим с FIPS.</exception>
		// Token: 0x06003061 RID: 12385 RVA: 0x000B0399 File Offset: 0x000AE599
		public new static SHA512 Create()
		{
			return SHA512.Create("System.Security.Cryptography.SHA512");
		}

		/// <summary>Создает экземпляр заданной реализации класса <see cref="T:System.Security.Cryptography.SHA512" />.</summary>
		/// <param name="hashName">Имя конкретной реализации класса <see cref="T:System.Security.Cryptography.SHA512" />, которую требуется использовать.</param>
		/// <returns>Новый экземпляр класса <see cref="T:System.Security.Cryptography.SHA512" />, использующий заданную реализацию.</returns>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Алгоритм, описание которого содержится в параметре<paramref name="hashName" />, использовался с включенным режимом FIPS, но не является FIPS-совместимым.</exception>
		// Token: 0x06003062 RID: 12386 RVA: 0x000B03A5 File Offset: 0x000AE5A5
		public new static SHA512 Create(string hashName)
		{
			return (SHA512)CryptoConfig.CreateFromName(hashName);
		}
	}
}
