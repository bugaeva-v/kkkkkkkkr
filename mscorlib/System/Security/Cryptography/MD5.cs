using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Представляет абстрактный класс, от которого наследуются все реализации хэш-алгоритма <see cref="T:System.Security.Cryptography.MD5" />.</summary>
	// Token: 0x0200049D RID: 1181
	[ComVisible(true)]
	public abstract class MD5 : HashAlgorithm
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.MD5" />.</summary>
		// Token: 0x06002F44 RID: 12100 RVA: 0x0000F94D File Offset: 0x0000DB4D
		protected MD5()
		{
			this.HashSizeValue = 128;
		}

		/// <summary>Создает экземпляр реализации по умолчанию хэш-алгоритма <see cref="T:System.Security.Cryptography.MD5" />.</summary>
		/// <returns>Новый экземпляр хэш-алгоритма <see cref="T:System.Security.Cryptography.MD5" />.</returns>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Алгоритм использовался с включенным режимом FIPS, но не является FIPS-совместимым.</exception>
		// Token: 0x06002F45 RID: 12101 RVA: 0x000A8614 File Offset: 0x000A6814
		public new static MD5 Create()
		{
			return MD5.Create("System.Security.Cryptography.MD5");
		}

		/// <summary>Создает экземпляр заданной реализации хэш-алгоритма <see cref="T:System.Security.Cryptography.MD5" />.</summary>
		/// <param name="algName">Имя конкретной реализации <see cref="T:System.Security.Cryptography.MD5" />, которую требуется использовать.</param>
		/// <returns>Новый экземпляр заданной реализации класса <see cref="T:System.Security.Cryptography.MD5" />.</returns>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Алгоритм, описание которого содержится в параметре<paramref name="algName" />, использовался с включенным режимом FIPS, но не является FIPS-совместимым.</exception>
		// Token: 0x06002F46 RID: 12102 RVA: 0x000A8620 File Offset: 0x000A6820
		public new static MD5 Create(string algName)
		{
			return (MD5)CryptoConfig.CreateFromName(algName);
		}
	}
}
