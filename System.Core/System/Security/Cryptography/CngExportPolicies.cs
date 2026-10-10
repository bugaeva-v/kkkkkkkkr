using System;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Задает политики экспорта для ключа.
	///       </summary>
	// Token: 0x0200004D RID: 77
	[Flags]
	public enum CngExportPolicies
	{
		/// <summary>
		///         Политики экспорта не устанавливаются.
		///          Экспорт ключа разрешен без ограничений.
		///       </summary>
		// Token: 0x0400032E RID: 814
		None = 0,
		/// <summary>
		///         Закрытый ключ может быть экспортирован несколько раз.
		///       </summary>
		// Token: 0x0400032F RID: 815
		AllowExport = 1,
		/// <summary>
		///         Закрытый ключ может быть экспортирован несколько раз, как обычный текст.
		///       </summary>
		// Token: 0x04000330 RID: 816
		AllowPlaintextExport = 2,
		/// <summary>
		///         Закрытый ключ может быть экспортирован один раз для архивирования.
		///       </summary>
		// Token: 0x04000331 RID: 817
		AllowArchiving = 4,
		/// <summary>
		///         Закрытый ключ можно экспортировать один раз в виде открытого текста.
		///       </summary>
		// Token: 0x04000332 RID: 818
		AllowPlaintextArchiving = 8
	}
}
