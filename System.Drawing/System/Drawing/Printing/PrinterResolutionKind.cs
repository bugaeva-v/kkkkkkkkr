using System;

namespace System.Drawing.Printing
{
	/// <summary>Задает разрешающую способность принтера.</summary>
	// Token: 0x020000C4 RID: 196
	public enum PrinterResolutionKind
	{
		/// <summary>Высокое разрешение.</summary>
		// Token: 0x04000706 RID: 1798
		High = -4,
		/// <summary>Среднее разрешение.</summary>
		// Token: 0x04000707 RID: 1799
		Medium,
		/// <summary>Низкое разрешение.</summary>
		// Token: 0x04000708 RID: 1800
		Low,
		/// <summary>Черновое разрешение.</summary>
		// Token: 0x04000709 RID: 1801
		Draft,
		/// <summary>Настраиваемое разрешение.</summary>
		// Token: 0x0400070A RID: 1802
		Custom
	}
}
