using System;

namespace System.Drawing.Drawing2D
{
	/// <summary>Определяет направление линейного градиента.</summary>
	// Token: 0x02000147 RID: 327
	public enum LinearGradientMode
	{
		/// <summary>Задает градиент слева направо.</summary>
		// Token: 0x04000B38 RID: 2872
		Horizontal,
		/// <summary>Задает градиент сверху вниз.</summary>
		// Token: 0x04000B39 RID: 2873
		Vertical,
		/// <summary>Задает градиент от левого верхнего угла до правого нижнего угла.</summary>
		// Token: 0x04000B3A RID: 2874
		ForwardDiagonal,
		/// <summary>Задает градиент от правого верхнего угла до левого нижнего угла.</summary>
		// Token: 0x04000B3B RID: 2875
		BackwardDiagonal
	}
}
