using System;

namespace System.Drawing.Imaging
{
	/// <summary>Указывает, какие объекты GDI+ используют сведения о настройке цвета.</summary>
	// Token: 0x020000F6 RID: 246
	public enum ColorAdjustType
	{
		/// <summary>Сведения о настройке цвета, которые используются всеми объектами GDI+, у которых нет своих сведений о настройке цвета.</summary>
		// Token: 0x0400083B RID: 2107
		Default,
		/// <summary>Сведения о настройке цвета для объектов <see cref="T:System.Drawing.Bitmap" />.</summary>
		// Token: 0x0400083C RID: 2108
		Bitmap,
		/// <summary>Сведения о настройке цвета для объектов <see cref="T:System.Drawing.Brush" />.</summary>
		// Token: 0x0400083D RID: 2109
		Brush,
		/// <summary>Сведения о настройке цвета для объектов <see cref="T:System.Drawing.Pen" />.</summary>
		// Token: 0x0400083E RID: 2110
		Pen,
		/// <summary>Сведения о настройке цвета для текста.</summary>
		// Token: 0x0400083F RID: 2111
		Text,
		/// <summary>Количество указанных типов.</summary>
		// Token: 0x04000840 RID: 2112
		Count,
		/// <summary>Количество указанных типов.</summary>
		// Token: 0x04000841 RID: 2113
		Any
	}
}
