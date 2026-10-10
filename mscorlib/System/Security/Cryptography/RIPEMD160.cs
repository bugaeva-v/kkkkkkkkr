using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Представляет абстрактный класс, от которого наследуются все реализации хэш-алгоритма MD160.</summary>
	// Token: 0x020004A7 RID: 1191
	[ComVisible(true)]
	public abstract class RIPEMD160 : HashAlgorithm
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.RIPEMD160" />.</summary>
		// Token: 0x06002FA2 RID: 12194 RVA: 0x000AAFBA File Offset: 0x000A91BA
		protected RIPEMD160()
		{
			this.HashSizeValue = 160;
		}

		/// <summary>Создает экземпляр реализации по умолчанию хэш-алгоритма <see cref="T:System.Security.Cryptography.RIPEMD160" />.</summary>
		/// <returns>Новый экземпляр хэш-алгоритма <see cref="T:System.Security.Cryptography.RIPEMD160" />.</returns>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Алгоритм использовался с включенным режимом FIPS, но не является FIPS-совместимым.</exception>
		// Token: 0x06002FA3 RID: 12195 RVA: 0x000AAFCD File Offset: 0x000A91CD
		public new static RIPEMD160 Create()
		{
			return RIPEMD160.Create("System.Security.Cryptography.RIPEMD160");
		}

		/// <summary>Создает экземпляр заданной реализации хэш-алгоритма <see cref="T:System.Security.Cryptography.RIPEMD160" />.</summary>
		/// <param name="hashName">Имя конкретной реализации <see cref="T:System.Security.Cryptography.RIPEMD160" />, которую требуется использовать.</param>
		/// <returns>Новый экземпляр заданной реализации класса <see cref="T:System.Security.Cryptography.RIPEMD160" />.</returns>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Алгоритм, описание которого содержится в параметре <paramref name="hashName" />, использовался с включенным режимом FIPS, но не является FIPS-совместимым.</exception>
		// Token: 0x06002FA4 RID: 12196 RVA: 0x000AAFD9 File Offset: 0x000A91D9
		public new static RIPEMD160 Create(string hashName)
		{
			return (RIPEMD160)CryptoConfig.CreateFromName(hashName);
		}
	}
}
