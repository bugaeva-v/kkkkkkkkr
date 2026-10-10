using System;

namespace System.Drawing.Imaging
{
	/// <summary>Используется для определения значения параметра, передаваемого кодировщику изображений JPEG или TIFF при использовании методов <see cref="M:System.Drawing.Image.Save(System.String,System.Drawing.Imaging.ImageCodecInfo,System.Drawing.Imaging.EncoderParameters)" /> или <see cref="M:System.Drawing.Image.SaveAdd(System.Drawing.Imaging.EncoderParameters)" />.</summary>
	// Token: 0x02000105 RID: 261
	public enum EncoderValue
	{
		/// <summary>Не используется в GDI+ версии 1.0.</summary>
		// Token: 0x0400098E RID: 2446
		ColorTypeCMYK,
		/// <summary>Не используется в GDI+ версии 1.0.</summary>
		// Token: 0x0400098F RID: 2447
		ColorTypeYCCK,
		/// <summary>Определяет схему сжатия LZW. Может передаваться кодировщику TIFF в качестве параметра категории сжатия.</summary>
		// Token: 0x04000990 RID: 2448
		CompressionLZW,
		/// <summary>Определяет схему сжатия CCITT3. Может передаваться кодировщику TIFF в качестве параметра категории сжатия.</summary>
		// Token: 0x04000991 RID: 2449
		CompressionCCITT3,
		/// <summary>Определяет схему сжатия CCITT4. Может передаваться кодировщику TIFF в качестве параметра категории сжатия.</summary>
		// Token: 0x04000992 RID: 2450
		CompressionCCITT4,
		/// <summary>Определяет схему сжатия RLE. Может передаваться кодировщику TIFF в качестве параметра категории сжатия.</summary>
		// Token: 0x04000993 RID: 2451
		CompressionRle,
		/// <summary>Указывает на отсутствие сжатия. Может передаваться кодировщику TIFF в качестве параметра категории сжатия.</summary>
		// Token: 0x04000994 RID: 2452
		CompressionNone,
		/// <summary>Не используется в GDI+ версии 1.0.</summary>
		// Token: 0x04000995 RID: 2453
		ScanMethodInterlaced,
		/// <summary>Не используется в GDI+ версии 1.0.</summary>
		// Token: 0x04000996 RID: 2454
		ScanMethodNonInterlaced,
		/// <summary>Не используется в GDI+ версии 1.0.</summary>
		// Token: 0x04000997 RID: 2455
		VersionGif87,
		/// <summary>Не используется в GDI+ версии 1.0.</summary>
		// Token: 0x04000998 RID: 2456
		VersionGif89,
		/// <summary>Не используется в GDI+ версии 1.0.</summary>
		// Token: 0x04000999 RID: 2457
		RenderProgressive,
		/// <summary>Не используется в GDI+ версии 1.0.</summary>
		// Token: 0x0400099A RID: 2458
		RenderNonProgressive,
		/// <summary>Указывает, что изображение нужно повернуть по часовой стрелке на 90 градусов вокруг его центра. Может передаваться кодировщику JPEG в качестве параметра категории преобразования.</summary>
		// Token: 0x0400099B RID: 2459
		TransformRotate90,
		/// <summary>Указывает, что изображение нужно повернуть на 180 градусов вокруг его центра. Может передаваться кодировщику JPEG в качестве параметра категории преобразования.</summary>
		// Token: 0x0400099C RID: 2460
		TransformRotate180,
		/// <summary>Указывает, что изображение нужно повернуть по часовой стрелке на 270 градусов вокруг его центра. Может передаваться кодировщику JPEG в качестве параметра категории преобразования.</summary>
		// Token: 0x0400099D RID: 2461
		TransformRotate270,
		/// <summary>Указывает, что изображение нужно зеркально отразить горизонтально (относительно вертикальной оси). Может передаваться кодировщику JPEG в качестве параметра категории преобразования.</summary>
		// Token: 0x0400099E RID: 2462
		TransformFlipHorizontal,
		/// <summary>Указывает, что изображение нужно зеркально отразить вертикально (относительно горизонтальной оси). Может передаваться кодировщику JPEG в качестве параметра категории преобразования.</summary>
		// Token: 0x0400099F RID: 2463
		TransformFlipVertical,
		/// <summary>Указывает, что в изображении присутствует более одного кадра (страницы). Может передаваться кодировщику TIFF в качестве параметра категории флага сохранения.</summary>
		// Token: 0x040009A0 RID: 2464
		MultiFrame,
		/// <summary>Указывает последний кадр многокадрового изображения. Может передаваться кодировщику TIFF в качестве параметра категории флага сохранения.</summary>
		// Token: 0x040009A1 RID: 2465
		LastFrame,
		/// <summary>Указывает на то, что многокадровый файл или поток должен быть закрыт. Может передаваться кодировщику TIFF в качестве параметра категории флага сохранения.</summary>
		// Token: 0x040009A2 RID: 2466
		Flush,
		/// <summary>Не используется в GDI+ версии 1.0.</summary>
		// Token: 0x040009A3 RID: 2467
		FrameDimensionTime,
		/// <summary>Не используется в GDI+ версии 1.0.</summary>
		// Token: 0x040009A4 RID: 2468
		FrameDimensionResolution,
		/// <summary>Указывает, что кадр должен быть добавлен в размер страницы изображения. Может передаваться кодировщику TIFF в качестве параметра категории флага сохранения.</summary>
		// Token: 0x040009A5 RID: 2469
		FrameDimensionPage
	}
}
