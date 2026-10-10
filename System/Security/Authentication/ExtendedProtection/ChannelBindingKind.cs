using System;

namespace System.Security.Authentication.ExtendedProtection
{
	/// <summary>Перечисление <see cref="T:System.Security.Authentication.ExtendedProtection.ChannelBindingKind" /> представляет типы привязок каналов, которые можно ставить в очередь из безопасных каналов.</summary>
	// Token: 0x020002A5 RID: 677
	public enum ChannelBindingKind
	{
		/// <summary>Неизвестный тип привязки канала.</summary>
		// Token: 0x04000BF6 RID: 3062
		Unknown,
		/// <summary>Привязка канала, полностью уникальная для данного канала (например, сеансовый ключ протокола TLS).</summary>
		// Token: 0x04000BF7 RID: 3063
		Unique = 25,
		/// <summary>Привязка канала, уникальная для данной конечной точки (например, сертификат сервера протокола TLS).</summary>
		// Token: 0x04000BF8 RID: 3064
		Endpoint
	}
}
