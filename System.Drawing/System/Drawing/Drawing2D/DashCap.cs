using System;

namespace System.Drawing.Drawing2D
{
	/// <summary>Задает тип графической формы, используемой для обоих концов каждого штриха в пунктирной линии.</summary>
	// Token: 0x02000132 RID: 306
	public enum DashCap
	{
		/// <summary>Задает квадратное завершение для обоих концов каждого штриха.</summary>
		// Token: 0x04000AAD RID: 2733
		Flat,
		/// <summary>Задает круглое завершение для обоих концов каждого штриха.</summary>
		// Token: 0x04000AAE RID: 2734
		Round = 2,
		/// <summary>Задает треугольное завершение для обоих концов каждого штриха.</summary>
		// Token: 0x04000AAF RID: 2735
		Triangle
	}
}
