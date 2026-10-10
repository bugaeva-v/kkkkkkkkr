using System;

namespace System.Globalization
{
	/// <summary>Указывает, является ли календарь солнечным, лунным или лунно-солнечным.</summary>
	// Token: 0x02000952 RID: 2386
	public enum CalendarAlgorithmType
	{
		/// <summary>Календарь на неизвестной основе.</summary>
		// Token: 0x040033AB RID: 13227
		Unknown,
		/// <summary>Солнечный календарь.</summary>
		// Token: 0x040033AC RID: 13228
		SolarCalendar,
		/// <summary>Лунный календарь.</summary>
		// Token: 0x040033AD RID: 13229
		LunarCalendar,
		/// <summary>Лунно-солнечный календарь.</summary>
		// Token: 0x040033AE RID: 13230
		LunisolarCalendar
	}
}
