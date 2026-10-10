using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Вычисляет хэш <see cref="T:System.Security.Cryptography.SHA256" /> для входных данных.</summary>
	// Token: 0x020004B2 RID: 1202
	[ComVisible(true)]
	public abstract class SHA256 : HashAlgorithm
	{
		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Security.Cryptography.SHA256" />.</summary>
		// Token: 0x06003038 RID: 12344 RVA: 0x000AF48C File Offset: 0x000AD68C
		protected SHA256()
		{
			this.HashSizeValue = 256;
		}

		/// <summary>Создает экземпляр реализации класса <see cref="T:System.Security.Cryptography.SHA256" /> по умолчанию.</summary>
		/// <returns>Новый экземпляр класса <see cref="T:System.Security.Cryptography.SHA256" />. На платформе .NET Framework этот метод создает экземпляр класса <see cref="T:System.Security.Cryptography.SHA256Managed" />, если не используется режим FIPS. Если режим FIPS активен, то он создает экземпляр класса <see cref="T:System.Security.Cryptography.SHA256Cng" />. На платформе .NET Core он возвращает экземпляр закрытого класса, являющегося производным от класса <see cref="T:System.Security.Cryptography.SHA256" />.</returns>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Только для .NET Framework 4.6.1 и более ранних версий: этот алгоритм был использован с включенным режимом FIPS, однако он несовместим с FIPS.</exception>
		// Token: 0x06003039 RID: 12345 RVA: 0x000AF49F File Offset: 0x000AD69F
		public new static SHA256 Create()
		{
			return SHA256.Create("System.Security.Cryptography.SHA256");
		}

		/// <summary>Создает экземпляр заданной реализации класса <see cref="T:System.Security.Cryptography.SHA256" />.</summary>
		/// <param name="hashName">Имя конкретной реализации класса <see cref="T:System.Security.Cryptography.SHA256" />, которую требуется использовать.</param>
		/// <returns>Новый экземпляр класса <see cref="T:System.Security.Cryptography.SHA256" />, использующий заданную реализацию.</returns>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Только для .NET Framework: включен режим FIPS, но <paramref name="hashName" /> запрашивает <see cref="T:System.Security.Cryptography.SHA256Managed" />, который несовместим с FIPS.</exception>
		// Token: 0x0600303A RID: 12346 RVA: 0x000AF4AB File Offset: 0x000AD6AB
		public new static SHA256 Create(string hashName)
		{
			return (SHA256)CryptoConfig.CreateFromName(hashName);
		}
	}
}
