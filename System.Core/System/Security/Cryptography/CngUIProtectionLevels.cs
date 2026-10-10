using System;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Задает уровень защиты ключа в сценариях запроса пользовательского интерфейса (UI).
	///       </summary>
	// Token: 0x02000053 RID: 83
	[Flags]
	public enum CngUIProtectionLevels
	{
		/// <summary>
		///         Пользовательский Интерфейс не подсказка при доступе к ключу.
		///       </summary>
		// Token: 0x0400034A RID: 842
		None = 0,
		/// <summary>
		///         Пользовательский Интерфейс запрос отображается при первом доступе к ключу в процессе.
		///       </summary>
		// Token: 0x0400034B RID: 843
		ProtectKey = 1,
		/// <summary>
		///         Пользовательский Интерфейс приглашение выводится при каждом доступе к ключу.
		///       </summary>
		// Token: 0x0400034C RID: 844
		ForceHighProtection = 2
	}
}
