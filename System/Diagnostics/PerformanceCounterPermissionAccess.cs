using System;

namespace System.Diagnostics
{
	/// <summary>Определяет уровни доступа, используемые классами разрешений <see cref="T:System.Diagnostics.PerformanceCounter" />.</summary>
	// Token: 0x02000277 RID: 631
	[Flags]
	public enum PerformanceCounterPermissionAccess
	{
		/// <summary>Класс <see cref="T:System.Diagnostics.PerformanceCounter" /> не имеет разрешений.</summary>
		// Token: 0x04000B25 RID: 2853
		None = 0,
		/// <summary>Класс <see cref="T:System.Diagnostics.PerformanceCounter" /> может читать категории.</summary>
		// Token: 0x04000B26 RID: 2854
		[Obsolete]
		Browse = 1,
		/// <summary>Класс <see cref="T:System.Diagnostics.PerformanceCounter" /> может читать категории.</summary>
		// Token: 0x04000B27 RID: 2855
		Read = 1,
		/// <summary>Класс <see cref="T:System.Diagnostics.PerformanceCounter" /> может записывать категории.</summary>
		// Token: 0x04000B28 RID: 2856
		Write = 2,
		/// <summary>Класс <see cref="T:System.Diagnostics.PerformanceCounter" /> может читать и записывать категории.</summary>
		// Token: 0x04000B29 RID: 2857
		[Obsolete]
		Instrument = 3,
		/// <summary>Класс <see cref="T:System.Diagnostics.PerformanceCounter" /> может читать, записывать и создавать категории.</summary>
		// Token: 0x04000B2A RID: 2858
		Administer = 7
	}
}
