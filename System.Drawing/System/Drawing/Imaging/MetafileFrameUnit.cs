using System;

namespace System.Drawing.Imaging
{
	/// <summary>Указывает единицу измерения прямоугольника, используемого для определения размеров и положения метафайлов. Эти данные указываются во время создания объекта <see cref="T:System.Drawing.Imaging.Metafile" />.</summary>
	// Token: 0x0200010D RID: 269
	public enum MetafileFrameUnit
	{
		/// <summary>Единица измерения – 1 пиксель.</summary>
		// Token: 0x040009E2 RID: 2530
		Pixel = 2,
		/// <summary>Единица измерения – 1 точка принтера.</summary>
		// Token: 0x040009E3 RID: 2531
		Point,
		/// <summary>Единица измерения – 1 дюйм.</summary>
		// Token: 0x040009E4 RID: 2532
		Inch,
		/// <summary>Единица измерения – 1/300 дюйма.</summary>
		// Token: 0x040009E5 RID: 2533
		Document,
		/// <summary>Единица измерения — 1 миллиметр.</summary>
		// Token: 0x040009E6 RID: 2534
		Millimeter,
		/// <summary>Единица измерения — 0,01 миллиметр. Обеспечивает совместимость с GDI.</summary>
		// Token: 0x040009E7 RID: 2535
		GdiCompatible
	}
}
