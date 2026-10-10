using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Уровень области для IPv6-адреса.</summary>
	// Token: 0x020006FF RID: 1791
	public enum ScopeLevel
	{
		/// <summary>Уровень области не указан.</summary>
		// Token: 0x040021B7 RID: 8631
		None,
		/// <summary>Область имеет уровень интерфейса.</summary>
		// Token: 0x040021B8 RID: 8632
		Interface,
		/// <summary>Область имеет уровень связи.</summary>
		// Token: 0x040021B9 RID: 8633
		Link,
		/// <summary>Область имеет уровень подсети.</summary>
		// Token: 0x040021BA RID: 8634
		Subnet,
		/// <summary>Область имеет уровень администратора.</summary>
		// Token: 0x040021BB RID: 8635
		Admin,
		/// <summary>Область имеет уровень сайта.</summary>
		// Token: 0x040021BC RID: 8636
		Site,
		/// <summary>Область имеет уровень организации.</summary>
		// Token: 0x040021BD RID: 8637
		Organization = 8,
		/// <summary>Область является глобальной.</summary>
		// Token: 0x040021BE RID: 8638
		Global = 14
	}
}
