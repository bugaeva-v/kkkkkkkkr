using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Вычисляет хэш <see cref="T:System.Security.Cryptography.SHA384" /> для входных данных.</summary>
	// Token: 0x020004B4 RID: 1204
	[ComVisible(true)]
	public abstract class SHA384 : HashAlgorithm
	{
		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Security.Cryptography.SHA384" />.</summary>
		// Token: 0x0600304C RID: 12364 RVA: 0x000AFBEE File Offset: 0x000ADDEE
		protected SHA384()
		{
			this.HashSizeValue = 384;
		}

		/// <summary>Создает экземпляр реализации класса <see cref="T:System.Security.Cryptography.SHA384" /> по умолчанию.</summary>
		/// <returns>Новый экземпляр класса <see cref="T:System.Security.Cryptography.SHA384" />.</returns>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Этот алгоритм был использован с включенным режимом FIPS, однако он не совместим с FIPS.</exception>
		// Token: 0x0600304D RID: 12365 RVA: 0x000AFC01 File Offset: 0x000ADE01
		public new static SHA384 Create()
		{
			return SHA384.Create("System.Security.Cryptography.SHA384");
		}

		/// <summary>Создает экземпляр заданной реализации класса <see cref="T:System.Security.Cryptography.SHA384" />.</summary>
		/// <param name="hashName">Имя конкретной реализации класса <see cref="T:System.Security.Cryptography.SHA384" />, которую требуется использовать.</param>
		/// <returns>Новый экземпляр класса <see cref="T:System.Security.Cryptography.SHA384" />, использующий заданную реализацию.</returns>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Алгоритм, описание которого содержится в параметре<paramref name="hashName" />, использовался с включенным режимом FIPS, но не является FIPS-совместимым.</exception>
		// Token: 0x0600304E RID: 12366 RVA: 0x000AFC0D File Offset: 0x000ADE0D
		public new static SHA384 Create(string hashName)
		{
			return (SHA384)CryptoConfig.CreateFromName(hashName);
		}
	}
}
