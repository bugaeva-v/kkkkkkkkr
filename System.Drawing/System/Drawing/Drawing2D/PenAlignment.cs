using System;

namespace System.Drawing.Drawing2D
{
	/// <summary>Определяет выравнивание объекта <see cref="T:System.Drawing.Pen" /> по отношению к теоретической линии, ширина которой равна нулю.</summary>
	// Token: 0x0200014B RID: 331
	public enum PenAlignment
	{
		/// <summary>Определяет, что объект <see cref="T:System.Drawing.Pen" /> располагается по центру над теоретической линией.</summary>
		// Token: 0x04000B4B RID: 2891
		Center,
		/// <summary>Определяет, что объект <see cref="T:System.Drawing.Pen" /> располагается внутри теоретической линии.</summary>
		// Token: 0x04000B4C RID: 2892
		Inset,
		/// <summary>Определяет, что объект <see cref="T:System.Drawing.Pen" /> располагается снаружи по отношению к теоретической линии.</summary>
		// Token: 0x04000B4D RID: 2893
		Outset,
		/// <summary>Определяет, что объект <see cref="T:System.Drawing.Pen" /> располагается слева от теоретической линии.</summary>
		// Token: 0x04000B4E RID: 2894
		Left,
		/// <summary>Определяет, что объект <see cref="T:System.Drawing.Pen" /> располагается справа от теоретической линии.</summary>
		// Token: 0x04000B4F RID: 2895
		Right
	}
}
