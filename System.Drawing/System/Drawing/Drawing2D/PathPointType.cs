using System;

namespace System.Drawing.Drawing2D
{
	/// <summary>Указывает тип точки в объекте <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
	// Token: 0x0200014A RID: 330
	public enum PathPointType
	{
		/// <summary>Начальная точка объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		// Token: 0x04000B42 RID: 2882
		Start,
		/// <summary>Отрезок прямой.</summary>
		// Token: 0x04000B43 RID: 2883
		Line,
		/// <summary>Кривая Безье, используемая по умолчанию.</summary>
		// Token: 0x04000B44 RID: 2884
		Bezier = 3,
		/// <summary>Точка маски.</summary>
		// Token: 0x04000B45 RID: 2885
		PathTypeMask = 7,
		/// <summary>Соответствующий сегмент является пунктирным.</summary>
		// Token: 0x04000B46 RID: 2886
		DashMode = 16,
		/// <summary>маркер контура.</summary>
		// Token: 0x04000B47 RID: 2887
		PathMarker = 32,
		/// <summary>Конечные точки субконтура.</summary>
		// Token: 0x04000B48 RID: 2888
		CloseSubpath = 128,
		/// <summary>Кривая Безье третьего порядка.</summary>
		// Token: 0x04000B49 RID: 2889
		Bezier3 = 3
	}
}
