using System;

namespace System.Drawing.Drawing2D
{
	/// <summary>Задает доступные стили отрезка, с помощью которых объект <see cref="T:System.Drawing.Pen" />завершает строку.</summary>
	// Token: 0x02000145 RID: 325
	public enum LineCap
	{
		/// <summary>Задает плоское завершение отрезка.</summary>
		// Token: 0x04000B27 RID: 2855
		Flat,
		/// <summary>Задает квадратное завершение отрезка.</summary>
		// Token: 0x04000B28 RID: 2856
		Square,
		/// <summary>Задает круглое завершение отрезка.</summary>
		// Token: 0x04000B29 RID: 2857
		Round,
		/// <summary>Задает треугольное завершение отрезка.</summary>
		// Token: 0x04000B2A RID: 2858
		Triangle,
		/// <summary>Не задает маркер.</summary>
		// Token: 0x04000B2B RID: 2859
		NoAnchor = 16,
		/// <summary>Задает квадратный маркер завершения отрезка.</summary>
		// Token: 0x04000B2C RID: 2860
		SquareAnchor,
		/// <summary>Задает круглый маркер.</summary>
		// Token: 0x04000B2D RID: 2861
		RoundAnchor,
		/// <summary>Задает маркер в форме ромба.</summary>
		// Token: 0x04000B2E RID: 2862
		DiamondAnchor,
		/// <summary>Задает маркер в форме стрелки.</summary>
		// Token: 0x04000B2F RID: 2863
		ArrowAnchor,
		/// <summary>Задает пользовательское завершение отрезка.</summary>
		// Token: 0x04000B30 RID: 2864
		Custom = 255,
		/// <summary>Задает маску, используемую для проверки того, является ли завершение отрезка маркером.</summary>
		// Token: 0x04000B31 RID: 2865
		AnchorMask = 240
	}
}
