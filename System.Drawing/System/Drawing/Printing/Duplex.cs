using System;

namespace System.Drawing.Printing
{
	/// <summary>Задает параметр двухсторонней печати.</summary>
	// Token: 0x020000B7 RID: 183
	public enum Duplex
	{
		/// <summary>Задает параметр двухсторонней печати по умолчанию.</summary>
		// Token: 0x0400065E RID: 1630
		Default = -1,
		/// <summary>Односторонняя печать.</summary>
		// Token: 0x0400065F RID: 1631
		Simplex = 1,
		/// <summary>Двухсторонняя горизонтальная печать.</summary>
		// Token: 0x04000660 RID: 1632
		Horizontal = 3,
		/// <summary>Двухсторонняя вертикальная печать.</summary>
		// Token: 0x04000661 RID: 1633
		Vertical = 2
	}
}
