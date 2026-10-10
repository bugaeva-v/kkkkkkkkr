using System;

namespace System.Drawing.Printing
{
	/// <summary>Указывает тип выполняющейся операции печати.</summary>
	// Token: 0x020000BF RID: 191
	public enum PrintAction
	{
		/// <summary>Операция печати выполняется в файл.</summary>
		// Token: 0x040006FA RID: 1786
		PrintToFile,
		/// <summary>Операция печати — это обзор печати.</summary>
		// Token: 0x040006FB RID: 1787
		PrintToPreview,
		/// <summary>Операция печати — это печать на принтер.</summary>
		// Token: 0x040006FC RID: 1788
		PrintToPrinter
	}
}
