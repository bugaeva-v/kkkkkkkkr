using System;

namespace System.Security.Cryptography
{
	/// <summary>
	///         Задает криптографические операции, которые могут использовать ключ криптографии следующего поколения (CNG).
	///       </summary>
	// Token: 0x02000051 RID: 81
	[Flags]
	public enum CngKeyUsages
	{
		/// <summary>
		///         Без использования значения присваиваются ключ.
		///       </summary>
		// Token: 0x04000340 RID: 832
		None = 0,
		/// <summary>
		///         Ключ может использоваться для шифрования и расшифровки.
		///       </summary>
		// Token: 0x04000341 RID: 833
		Decryption = 1,
		/// <summary>
		///         Ключ может использоваться для подписывания и проверки.
		///       </summary>
		// Token: 0x04000342 RID: 834
		Signing = 2,
		/// <summary>
		///         Ключ может использоваться для формирования секретного соглашения и обмена ключами.
		///       </summary>
		// Token: 0x04000343 RID: 835
		KeyAgreement = 4,
		/// <summary>
		///         Ключ может использоваться для всех целей.
		///       </summary>
		// Token: 0x04000344 RID: 836
		AllUsages = 16777215
	}
}
