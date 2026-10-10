using System;

namespace System.Drawing.Imaging
{
	/// <summary>Указывает тип данных о цвете в системной палитре. Это могут быть данные о цвете с альфа-составляющей, только черно-белые данные или полутоновые данные.</summary>
	// Token: 0x02000111 RID: 273
	[Flags]
	public enum PaletteFlags
	{
		/// <summary>Данные с альфа-составляющей.</summary>
		// Token: 0x04000A1C RID: 2588
		HasAlpha = 1,
		/// <summary>Черно-белые данные.</summary>
		// Token: 0x04000A1D RID: 2589
		GrayScale = 2,
		/// <summary>Полутоновые данные.</summary>
		// Token: 0x04000A1E RID: 2590
		Halftone = 4
	}
}
