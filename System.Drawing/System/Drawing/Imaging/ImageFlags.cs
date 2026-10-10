using System;

namespace System.Drawing.Imaging
{
	/// <summary>Указывает атрибуты данных о пикселях, содержащихся в объекте <see cref="T:System.Drawing.Image" />. Свойство <see cref="P:System.Drawing.Image.Flags" /> возвращает члена данного перечисления.</summary>
	// Token: 0x0200010B RID: 267
	[Flags]
	public enum ImageFlags
	{
		/// <summary>Информация о формате отсутствует.</summary>
		// Token: 0x040009CE RID: 2510
		None = 0,
		/// <summary>Данные о пикселях являются масштабируемыми.</summary>
		// Token: 0x040009CF RID: 2511
		Scalable = 1,
		/// <summary>Данных о пикселях содержат сведения об альфа-канале.</summary>
		// Token: 0x040009D0 RID: 2512
		HasAlpha = 2,
		/// <summary>Указывает, что данные о пикселях содержат значения альфа, отличающиеся от 0 (прозрачный) и 255 (непрозрачный).</summary>
		// Token: 0x040009D1 RID: 2513
		HasTranslucent = 4,
		/// <summary>Данные о пикселях частично масштабируемы, но существуют некоторые ограничения.</summary>
		// Token: 0x040009D2 RID: 2514
		PartiallyScalable = 8,
		/// <summary>В данных о пикселях используется цветовое пространство RGB.</summary>
		// Token: 0x040009D3 RID: 2515
		ColorSpaceRgb = 16,
		/// <summary>В данных о пикселях используется цветовое пространство CMYK.</summary>
		// Token: 0x040009D4 RID: 2516
		ColorSpaceCmyk = 32,
		/// <summary>Данные о пикселях являются черно-белыми.</summary>
		// Token: 0x040009D5 RID: 2517
		ColorSpaceGray = 64,
		/// <summary>Указывает, что изображение хранится с использованием цветового пространства YCBCR.</summary>
		// Token: 0x040009D6 RID: 2518
		ColorSpaceYcbcr = 128,
		/// <summary>Указывает, что изображение хранится с использованием цветового пространства YCCK.</summary>
		// Token: 0x040009D7 RID: 2519
		ColorSpaceYcck = 256,
		/// <summary>Указывает, что в изображении хранится информация о разрешении в точках на дюйм.</summary>
		// Token: 0x040009D8 RID: 2520
		HasRealDpi = 4096,
		/// <summary>Указывает, что в изображении хранится размер в пикселях.</summary>
		// Token: 0x040009D9 RID: 2521
		HasRealPixelSize = 8192,
		/// <summary>Данные о пикселях доступны только для чтения.</summary>
		// Token: 0x040009DA RID: 2522
		ReadOnly = 65536,
		/// <summary>Данные о пикселях могут быть кэшированы для более быстрого доступа.</summary>
		// Token: 0x040009DB RID: 2523
		Caching = 131072
	}
}
