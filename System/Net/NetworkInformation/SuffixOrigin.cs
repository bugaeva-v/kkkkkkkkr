using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Указывает, каким образом был задан суффикс узла.</summary>
	// Token: 0x02000700 RID: 1792
	public enum SuffixOrigin
	{
		/// <summary>Суффикс был задан с помощью неопределенного источника.</summary>
		// Token: 0x040021C0 RID: 8640
		Other,
		/// <summary>Суффикс был настроен вручную.</summary>
		// Token: 0x040021C1 RID: 8641
		Manual,
		/// <summary>Суффикс является общеизвестным. Общеизвестные суффиксы указаны в стандартных документах RFC и назначены Администрацией адресного пространства Интернет (Iana) или в реестре адресов. Эти суффиксы зарезервированы для особых целей.</summary>
		// Token: 0x040021C2 RID: 8642
		WellKnown,
		/// <summary>Суффикс был назначен DHCP-сервером.</summary>
		// Token: 0x040021C3 RID: 8643
		OriginDhcp,
		/// <summary>Суффикс является локальным суффиксом канала.</summary>
		// Token: 0x040021C4 RID: 8644
		LinkLayerAddress,
		/// <summary>Суффикс был назначен случайным образом.</summary>
		// Token: 0x040021C5 RID: 8645
		Random
	}
}
