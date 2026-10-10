using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Указывает, каким образом был задан префикс сети IP-адреса.</summary>
	// Token: 0x020006FE RID: 1790
	public enum PrefixOrigin
	{
		/// <summary>Префикс был задан с помощью неопределенного источника.</summary>
		// Token: 0x040021B1 RID: 8625
		Other,
		/// <summary>Префикс был настроен вручную.</summary>
		// Token: 0x040021B2 RID: 8626
		Manual,
		/// <summary>Префикс является общеизвестным. Общеизвестные префиксы указаны в стандартных документах RFC и назначены Администрацией адресного пространства Интернет (Iana) или в реестре адресов. Эти префиксы зарезервированы для особых целей.</summary>
		// Token: 0x040021B3 RID: 8627
		WellKnown,
		/// <summary>Префикс был назначен DHCP-сервером.</summary>
		// Token: 0x040021B4 RID: 8628
		Dhcp,
		/// <summary>Префикс был назначен с помощью объявления маршрутизатора.</summary>
		// Token: 0x040021B5 RID: 8629
		RouterAdvertisement
	}
}
