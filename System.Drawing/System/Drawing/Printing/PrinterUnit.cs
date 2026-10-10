using System;

namespace System.Drawing.Printing
{
	/// <summary>Задает несколько элементов измерения, используемых для печати.</summary>
	// Token: 0x020000C5 RID: 197
	public enum PrinterUnit
	{
		/// <summary>Единица по умолчанию (0,01 дюйма).</summary>
		// Token: 0x0400070C RID: 1804
		Display,
		/// <summary>Одна тысячная дюйма (0,001 дюйма).</summary>
		// Token: 0x0400070D RID: 1805
		ThousandthsOfAnInch,
		/// <summary>Одна сотая доля миллиметра (0,01 мм).</summary>
		// Token: 0x0400070E RID: 1806
		HundredthsOfAMillimeter,
		/// <summary>Одна десятая миллиметра (0,1 мм).</summary>
		// Token: 0x0400070F RID: 1807
		TenthsOfAMillimeter
	}
}
