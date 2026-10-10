using System;

namespace System.Drawing.Drawing2D
{
	/// <summary>Задает тип заполнения, который объект <see cref="T:System.Drawing.Pen" /> использует для заполнения линий.</summary>
	// Token: 0x0200014C RID: 332
	public enum PenType
	{
		/// <summary>Задает сплошное заполнение.</summary>
		// Token: 0x04000B51 RID: 2897
		SolidColor,
		/// <summary>Задает заполнение штриховкой.</summary>
		// Token: 0x04000B52 RID: 2898
		HatchFill,
		/// <summary>Задает заполнение с текстурой точечного рисунка.</summary>
		// Token: 0x04000B53 RID: 2899
		TextureFill,
		/// <summary>Задает градиентное заполнение контура.</summary>
		// Token: 0x04000B54 RID: 2900
		PathGradient,
		/// <summary>Задает линейное градиентное заполнение.</summary>
		// Token: 0x04000B55 RID: 2901
		LinearGradient
	}
}
