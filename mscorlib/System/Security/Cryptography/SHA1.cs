using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Вычисляет хэш <see cref="T:System.Security.Cryptography.SHA1" /> для входных данных.</summary>
	// Token: 0x020004B0 RID: 1200
	[ComVisible(true)]
	public abstract class SHA1 : HashAlgorithm
	{
		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Security.Cryptography.SHA1" />.</summary>
		/// <exception cref="T:System.InvalidOperationException">Политика данного объекта не соответствует стандарту FIPS.</exception>
		// Token: 0x0600302C RID: 12332 RVA: 0x000AAFBA File Offset: 0x000A91BA
		protected SHA1()
		{
			this.HashSizeValue = 160;
		}

		/// <summary>Создает экземпляр реализации класса <see cref="T:System.Security.Cryptography.SHA1" /> по умолчанию.</summary>
		/// <returns>Новый экземпляр класса <see cref="T:System.Security.Cryptography.SHA1" />.</returns>
		// Token: 0x0600302D RID: 12333 RVA: 0x000AECC8 File Offset: 0x000ACEC8
		public new static SHA1 Create()
		{
			return SHA1.Create("System.Security.Cryptography.SHA1");
		}

		/// <summary>Создает экземпляр заданной реализации класса <see cref="T:System.Security.Cryptography.SHA1" />.</summary>
		/// <param name="hashName">Имя конкретной реализации класса <see cref="T:System.Security.Cryptography.SHA1" />, которую требуется использовать.</param>
		/// <returns>Новый экземпляр класса <see cref="T:System.Security.Cryptography.SHA1" />, использующий заданную реализацию.</returns>
		// Token: 0x0600302E RID: 12334 RVA: 0x000AECD4 File Offset: 0x000ACED4
		public new static SHA1 Create(string hashName)
		{
			return (SHA1)CryptoConfig.CreateFromName(hashName);
		}
	}
}
