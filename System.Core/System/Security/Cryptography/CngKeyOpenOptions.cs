using System;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Задает параметры открытия ключа.
	///       </summary>
	// Token: 0x0200004F RID: 79
	[Flags]
	public enum CngKeyOpenOptions
	{
		/// <summary>
		///         Параметры открытия ключа не указаны.
		///       </summary>
		// Token: 0x04000338 RID: 824
		None = 0,
		/// <summary>
		///         Если <see cref="F:System.Security.Cryptography.CngKeyOpenOptions.MachineKey" /> значение не указано, вместо него открывается ключа пользователя.
		///       </summary>
		// Token: 0x04000339 RID: 825
		UserKey = 0,
		/// <summary>
		///         Открывается ключ компьютера.
		///       </summary>
		// Token: 0x0400033A RID: 826
		MachineKey = 32,
		/// <summary>
		///         Запросы пользовательского интерфейса подавляются.
		///       </summary>
		// Token: 0x0400033B RID: 827
		Silent = 64
	}
}
