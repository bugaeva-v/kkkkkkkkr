using System;

namespace System.Drawing
{
	/// <summary>Задает сведения о стиле, применяемые к тексту.</summary>
	// Token: 0x0200001E RID: 30
	[Flags]
	public enum FontStyle
	{
		/// <summary>Стандартный текст.</summary>
		// Token: 0x0400015C RID: 348
		Regular = 0,
		/// <summary>Текст, выделенный жирным шрифтом.</summary>
		// Token: 0x0400015D RID: 349
		Bold = 1,
		/// <summary>Текст, выделенный курсивом.</summary>
		// Token: 0x0400015E RID: 350
		Italic = 2,
		/// <summary>Текст, выделенный подчеркиванием.</summary>
		// Token: 0x0400015F RID: 351
		Underline = 4,
		/// <summary>Текст с линией посредине.</summary>
		// Token: 0x04000160 RID: 352
		Strikeout = 8
	}
}
