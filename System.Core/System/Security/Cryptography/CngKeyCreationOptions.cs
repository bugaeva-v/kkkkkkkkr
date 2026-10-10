using System;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Указывает параметры, используемые для создания ключа.
	///       </summary>
	// Token: 0x0200004E RID: 78
	[Flags]
	public enum CngKeyCreationOptions
	{
		/// <summary>
		///         Параметры создания ключа не используются.
		///       </summary>
		// Token: 0x04000334 RID: 820
		None = 0,
		/// <summary>
		///         Создать ключ компьютера.
		///       </summary>
		// Token: 0x04000335 RID: 821
		MachineKey = 32,
		/// <summary>
		///         Существующий ключ перезаписывается во время создания ключа.
		///       </summary>
		// Token: 0x04000336 RID: 822
		OverwriteExistingKey = 128
	}
}
