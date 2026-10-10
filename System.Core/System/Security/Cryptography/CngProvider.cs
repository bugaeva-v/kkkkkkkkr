using System;
using System.Security.Permissions;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Инкапсулирует имя поставщика хранилища ключей (KSP) для работы с объектами криптографии следующего поколения (CNG).
	///       </summary>
	// Token: 0x02000046 RID: 70
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	[Serializable]
	public sealed class CngProvider : IEquatable<CngProvider>
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.CngProvider" />.
		///       </summary>
		/// <param name="provider">
		///           Имя поставщика хранилища ключей (KSP) для инициализации.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="provider" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="provider" /> Длина параметра равно 0 (нулю).
		///           </exception>
		// Token: 0x0600014B RID: 331 RVA: 0x00003794 File Offset: 0x00001994
		public CngProvider(string provider)
		{
			if (provider == null)
			{
				throw new ArgumentNullException("provider");
			}
			if (provider.Length == 0)
			{
				throw new ArgumentException(SR.GetString("The provider name '{0}' is invalid.", new object[]
				{
					provider
				}), "provider");
			}
			this.m_provider = provider;
		}

		/// <summary>
		///         Возвращает имя поставщика хранилища ключей (KSP), текущий <see cref="T:System.Security.Cryptography.CngProvider" /> указывает объект.
		///       </summary>
		/// <returns>
		///         Внедренное имя.
		///       </returns>
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600014C RID: 332 RVA: 0x000037E3 File Offset: 0x000019E3
		public string Provider
		{
			get
			{
				return this.m_provider;
			}
		}

		/// <summary>
		///         Определяет неравенство двух <see cref="T:System.Security.Cryptography.CngProvider" /> объекта задают того же поставщика хранилища ключей (KSP).
		///       </summary>
		/// <param name="left">
		///           Объект, задающий поставщика хранилищ КЛЮЧЕЙ.
		///         </param>
		/// <param name="right">
		///           Второй объект, который требуется сравнить с объектом, идентифицируемым параметром <paramref name="left" />.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если два объекта представляют различных поставщиков хранилищ КЛЮЧЕЙ; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x0600014D RID: 333 RVA: 0x000037EB File Offset: 0x000019EB
		public static bool operator ==(CngProvider left, CngProvider right)
		{
			if (left == null)
			{
				return right == null;
			}
			return left.Equals(right);
		}

		/// <summary>
		///         Определяет неравенство двух <see cref="T:System.Security.Cryptography.CngProvider" /> объекты не отражают того же поставщика хранилища ключей (KSP).
		///       </summary>
		/// <param name="left">
		///           Объект, задающий поставщика хранилищ КЛЮЧЕЙ.
		///         </param>
		/// <param name="right">
		///           Второй объект, который требуется сравнить с объектом, идентифицируемым параметром <paramref name="left" />.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если два объекта представляют различных поставщиков хранилищ КЛЮЧЕЙ; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x0600014E RID: 334 RVA: 0x000037FC File Offset: 0x000019FC
		public static bool operator !=(CngProvider left, CngProvider right)
		{
			if (left == null)
			{
				return right != null;
			}
			return !left.Equals(right);
		}

		/// <summary>
		///         Сравнивает заданный объект с текущим объектом <see cref="T:System.Security.Cryptography.CngProvider" />.
		///       </summary>
		/// <param name="obj">
		///           Объект, который требуется сравнить с текущим объектом <see cref="T:System.Security.Cryptography.CngProvider" />.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если <paramref name="obj" /> параметр <see cref="T:System.Security.Cryptography.CngProvider" /> задающим же provider(KSP) хранилища ключей, что и текущий объект; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x0600014F RID: 335 RVA: 0x00003810 File Offset: 0x00001A10
		public override bool Equals(object obj)
		{
			return this.Equals(obj as CngProvider);
		}

		/// <summary>
		///         Сравнивает заданный объект <see cref="T:System.Security.Cryptography.CngProvider" /> с текущим объектом <see cref="T:System.Security.Cryptography.CngProvider" />.
		///       </summary>
		/// <param name="other">
		///           Объект, который требуется сравнить с текущим объектом <see cref="T:System.Security.Cryptography.CngProvider" />.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если <paramref name="other" /> параметр задает того же поставщика хранилища ключей (KSP), что и текущий объект; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06000150 RID: 336 RVA: 0x0000381E File Offset: 0x00001A1E
		public bool Equals(CngProvider other)
		{
			return other != null && this.m_provider.Equals(other.Provider);
		}

		/// <summary>
		///         Создает хэш-значение для имени поставщика хранилища ключей (KSP), внедренный в текущем <see cref="T:System.Security.Cryptography.CngProvider" /> объекта.
		///       </summary>
		/// <returns>
		///         Хэш-значение внедренного имени поставщика хранилища КЛЮЧЕЙ.
		///       </returns>
		// Token: 0x06000151 RID: 337 RVA: 0x00003836 File Offset: 0x00001A36
		public override int GetHashCode()
		{
			return this.m_provider.GetHashCode();
		}

		/// <summary>
		///         Возвращает имя поставщика хранилища ключей (KSP), текущий <see cref="T:System.Security.Cryptography.CngProvider" /> указывает объект.
		///       </summary>
		/// <returns>
		///         Внедренное имя.
		///       </returns>
		// Token: 0x06000152 RID: 338 RVA: 0x00003843 File Offset: 0x00001A43
		public override string ToString()
		{
			return this.m_provider.ToString();
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Security.Cryptography.CngProvider" /> объект, задающий поставщика хранилища ключей для Microsoft смарт-карты.
		///       </summary>
		/// <returns>
		///         Объект, задающий поставщика хранилищ ключей смарт-карт Microsoft.
		///       </returns>
		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00003850 File Offset: 0x00001A50
		public static CngProvider MicrosoftSmartCardKeyStorageProvider
		{
			get
			{
				if (CngProvider.s_msSmartCardKsp == null)
				{
					CngProvider.s_msSmartCardKsp = new CngProvider("Microsoft Smart Card Key Storage Provider");
				}
				return CngProvider.s_msSmartCardKsp;
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Security.Cryptography.CngProvider" /> определяющий поставщик хранилища ключей программного обеспечения Microsoft.
		///       </summary>
		/// <returns>
		///         Объект, задающий поставщик хранилища ключей программного обеспечения Microsoft.
		///       </returns>
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00003879 File Offset: 0x00001A79
		public static CngProvider MicrosoftSoftwareKeyStorageProvider
		{
			get
			{
				if (CngProvider.s_msSoftwareKsp == null)
				{
					CngProvider.s_msSoftwareKsp = new CngProvider("Microsoft Software Key Storage Provider");
				}
				return CngProvider.s_msSoftwareKsp;
			}
		}

		// Token: 0x04000321 RID: 801
		private static volatile CngProvider s_msSmartCardKsp;

		// Token: 0x04000322 RID: 802
		private static volatile CngProvider s_msSoftwareKsp;

		// Token: 0x04000323 RID: 803
		private string m_provider;
	}
}
