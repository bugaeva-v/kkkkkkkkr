using System;

namespace System.Security.Authentication.ExtendedProtection
{
	/// <summary>Представляет типы привязки токенов.</summary>
	// Token: 0x020002A2 RID: 674
	public enum TokenBindingType
	{
		/// <summary>Используется для установки привязки  токенов при подключении к серверу.</summary>
		// Token: 0x04000BF1 RID: 3057
		Provided,
		/// <summary>Используется, когда запрашиваемые токены должны быть представлены на другом сервере.</summary>
		// Token: 0x04000BF2 RID: 3058
		Referred
	}
}
