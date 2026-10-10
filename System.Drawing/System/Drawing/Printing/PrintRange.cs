using System;

namespace System.Drawing.Printing
{
	/// <summary>Задает выводимую на печать часть документа.</summary>
	// Token: 0x020000C2 RID: 194
	public enum PrintRange
	{
		/// <summary>На печать выводятся все страницы.</summary>
		// Token: 0x040006FE RID: 1790
		AllPages,
		/// <summary>На печать выводятся страницы с <see cref="P:System.Drawing.Printing.PrinterSettings.FromPage" /> по <see cref="P:System.Drawing.Printing.PrinterSettings.ToPage" />.</summary>
		// Token: 0x040006FF RID: 1791
		SomePages = 2,
		/// <summary>На печать выводятся выделенные страницы.</summary>
		// Token: 0x04000700 RID: 1792
		Selection = 1,
		/// <summary>Выполняется печать отображаемой в данный момент страницы</summary>
		// Token: 0x04000701 RID: 1793
		CurrentPage = 4194304
	}
}
