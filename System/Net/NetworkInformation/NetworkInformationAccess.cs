using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Указывает разрешение на доступ к сведениям о сетевых интерфейсах и статистике трафика.</summary>
	// Token: 0x020006F5 RID: 1781
	[Flags]
	public enum NetworkInformationAccess
	{
		/// <summary>Нет доступа к сведениям о сети.</summary>
		// Token: 0x04002192 RID: 8594
		None = 0,
		/// <summary>Доступ на чтение к сведениям о сети.</summary>
		// Token: 0x04002193 RID: 8595
		Read = 1,
		/// <summary>Доступ к сведениям о сети, разрешающий проверку связи.</summary>
		// Token: 0x04002194 RID: 8596
		Ping = 4
	}
}
