using System;
using System.ComponentModel;

namespace System.Drawing.Imaging
{
	/// <summary>Указывает формат файла изображения. Не наследуется.</summary>
	// Token: 0x02000118 RID: 280
	[TypeConverter(typeof(ImageFormatConverter))]
	public sealed class ImageFormat
	{
		/// <summary>Инициализация нового экземпляра класса <see cref="T:System.Drawing.Imaging.ImageFormat" /> с использованием указанной структуры <see cref="T:System.Guid" />.</summary>
		/// <param name="guid">Структура <see cref="T:System.Guid" />, определяющая конкретный формат изображений.</param>
		// Token: 0x06000CFE RID: 3326 RVA: 0x0001E011 File Offset: 0x0001C211
		public ImageFormat(Guid guid)
		{
			this.guid = guid;
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x0001E020 File Offset: 0x0001C220
		private ImageFormat(string name, string guid)
		{
			this.name = name;
			this.guid = new Guid(guid);
		}

		/// <summary>Возвращает значение, определяющее, эквивалентен ли указанный объект <see cref="T:System.Drawing.Imaging.ImageFormat" /> объекту <see cref="T:System.Drawing.Imaging.ImageFormat" />.</summary>
		/// <param name="o">Объект для тестирования.</param>
		/// <returns>Возвращает значение <see langword="true" />, если параметр <paramref name="o" /> является объектом <see cref="T:System.Drawing.Imaging.ImageFormat" />, эквивалентным объекту <see cref="T:System.Drawing.Imaging.ImageFormat" />; в обратном случае возвращается <see langword="false" />.</returns>
		// Token: 0x06000D00 RID: 3328 RVA: 0x0001E03C File Offset: 0x0001C23C
		public override bool Equals(object o)
		{
			ImageFormat imageFormat = o as ImageFormat;
			return imageFormat != null && imageFormat.Guid.Equals(this.guid);
		}

		/// <summary>Возвращает значение хэш-кода, представляющее данный объект.</summary>
		/// <returns>Хэш-код, представляющий данный объект.</returns>
		// Token: 0x06000D01 RID: 3329 RVA: 0x0001E069 File Offset: 0x0001C269
		public override int GetHashCode()
		{
			return this.guid.GetHashCode();
		}

		/// <summary>Преобразует этот объект <see cref="T:System.Drawing.Imaging.ImageFormat" /> в удобную для восприятия строку.</summary>
		/// <returns>Строка, представляющая данный объект <see cref="T:System.Drawing.Imaging.ImageFormat" />.</returns>
		// Token: 0x06000D02 RID: 3330 RVA: 0x0001E07C File Offset: 0x0001C27C
		public override string ToString()
		{
			if (this.name != null)
			{
				return this.name;
			}
			return "[ImageFormat: " + this.guid.ToString() + "]";
		}

		/// <summary>Возвращает структуру <see cref="T:System.Guid" />, представляющую объект <see cref="T:System.Drawing.Imaging.ImageFormat" />.</summary>
		/// <returns>Структура <see cref="T:System.Guid" />, представляющая объект <see cref="T:System.Drawing.Imaging.ImageFormat" />.</returns>
		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000D03 RID: 3331 RVA: 0x0001E0AD File Offset: 0x0001C2AD
		public Guid Guid
		{
			get
			{
				return this.guid;
			}
		}

		/// <summary>Возвращает формат точечного рисунка (BMP).</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Imaging.ImageFormat" />, определяющий формат точечных рисунков.</returns>
		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x0001E0B8 File Offset: 0x0001C2B8
		public static ImageFormat Bmp
		{
			get
			{
				object obj = ImageFormat.locker;
				ImageFormat bmpImageFormat;
				lock (obj)
				{
					if (ImageFormat.BmpImageFormat == null)
					{
						ImageFormat.BmpImageFormat = new ImageFormat("Bmp", "b96b3cab-0728-11d3-9d7b-0000f81ef32e");
					}
					bmpImageFormat = ImageFormat.BmpImageFormat;
				}
				return bmpImageFormat;
			}
		}

		/// <summary>Возвращает формат расширенных метафайлов (EMF).</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Imaging.ImageFormat" />, определяющий формат расширенных метафайлов.</returns>
		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000D05 RID: 3333 RVA: 0x0001E114 File Offset: 0x0001C314
		public static ImageFormat Emf
		{
			get
			{
				object obj = ImageFormat.locker;
				ImageFormat emfImageFormat;
				lock (obj)
				{
					if (ImageFormat.EmfImageFormat == null)
					{
						ImageFormat.EmfImageFormat = new ImageFormat("Emf", "b96b3cac-0728-11d3-9d7b-0000f81ef32e");
					}
					emfImageFormat = ImageFormat.EmfImageFormat;
				}
				return emfImageFormat;
			}
		}

		/// <summary>Возвращает формат Exif.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Imaging.ImageFormat" />, определяющий формат Exif.</returns>
		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000D06 RID: 3334 RVA: 0x0001E170 File Offset: 0x0001C370
		public static ImageFormat Exif
		{
			get
			{
				object obj = ImageFormat.locker;
				ImageFormat exifImageFormat;
				lock (obj)
				{
					if (ImageFormat.ExifImageFormat == null)
					{
						ImageFormat.ExifImageFormat = new ImageFormat("Exif", "b96b3cb2-0728-11d3-9d7b-0000f81ef32e");
					}
					exifImageFormat = ImageFormat.ExifImageFormat;
				}
				return exifImageFormat;
			}
		}

		/// <summary>Возвращает формат изображения GIF.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Imaging.ImageFormat" />, определяющий формат GIF.</returns>
		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000D07 RID: 3335 RVA: 0x0001E1CC File Offset: 0x0001C3CC
		public static ImageFormat Gif
		{
			get
			{
				object obj = ImageFormat.locker;
				ImageFormat gifImageFormat;
				lock (obj)
				{
					if (ImageFormat.GifImageFormat == null)
					{
						ImageFormat.GifImageFormat = new ImageFormat("Gif", "b96b3cb0-0728-11d3-9d7b-0000f81ef32e");
					}
					gifImageFormat = ImageFormat.GifImageFormat;
				}
				return gifImageFormat;
			}
		}

		/// <summary>Возвращает формат значков Windows.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Imaging.ImageFormat" />, определяющий формат значков Windows.</returns>
		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000D08 RID: 3336 RVA: 0x0001E228 File Offset: 0x0001C428
		public static ImageFormat Icon
		{
			get
			{
				object obj = ImageFormat.locker;
				ImageFormat iconImageFormat;
				lock (obj)
				{
					if (ImageFormat.IconImageFormat == null)
					{
						ImageFormat.IconImageFormat = new ImageFormat("Icon", "b96b3cb5-0728-11d3-9d7b-0000f81ef32e");
					}
					iconImageFormat = ImageFormat.IconImageFormat;
				}
				return iconImageFormat;
			}
		}

		/// <summary>Возвращает формат изображений JPEG.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Imaging.ImageFormat" />, определяющий формат JPEG.</returns>
		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000D09 RID: 3337 RVA: 0x0001E284 File Offset: 0x0001C484
		public static ImageFormat Jpeg
		{
			get
			{
				object obj = ImageFormat.locker;
				ImageFormat jpegImageFormat;
				lock (obj)
				{
					if (ImageFormat.JpegImageFormat == null)
					{
						ImageFormat.JpegImageFormat = new ImageFormat("Jpeg", "b96b3cae-0728-11d3-9d7b-0000f81ef32e");
					}
					jpegImageFormat = ImageFormat.JpegImageFormat;
				}
				return jpegImageFormat;
			}
		}

		/// <summary>Получает формат точечных рисунков в памяти.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Imaging.ImageFormat" />, определяющий формат точечного рисунка в памяти.</returns>
		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x0001E2E0 File Offset: 0x0001C4E0
		public static ImageFormat MemoryBmp
		{
			get
			{
				object obj = ImageFormat.locker;
				ImageFormat memoryBmpImageFormat;
				lock (obj)
				{
					if (ImageFormat.MemoryBmpImageFormat == null)
					{
						ImageFormat.MemoryBmpImageFormat = new ImageFormat("MemoryBMP", "b96b3caa-0728-11d3-9d7b-0000f81ef32e");
					}
					memoryBmpImageFormat = ImageFormat.MemoryBmpImageFormat;
				}
				return memoryBmpImageFormat;
			}
		}

		/// <summary>Возвращает формат изображений PNG.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Imaging.ImageFormat" />, определяющий формат изображений PNG.</returns>
		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x0001E33C File Offset: 0x0001C53C
		public static ImageFormat Png
		{
			get
			{
				object obj = ImageFormat.locker;
				ImageFormat pngImageFormat;
				lock (obj)
				{
					if (ImageFormat.PngImageFormat == null)
					{
						ImageFormat.PngImageFormat = new ImageFormat("Png", "b96b3caf-0728-11d3-9d7b-0000f81ef32e");
					}
					pngImageFormat = ImageFormat.PngImageFormat;
				}
				return pngImageFormat;
			}
		}

		/// <summary>Возвращает формат изображений TIFF.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Imaging.ImageFormat" />, определяющий формат изображений TIFF.</returns>
		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x0001E398 File Offset: 0x0001C598
		public static ImageFormat Tiff
		{
			get
			{
				object obj = ImageFormat.locker;
				ImageFormat tiffImageFormat;
				lock (obj)
				{
					if (ImageFormat.TiffImageFormat == null)
					{
						ImageFormat.TiffImageFormat = new ImageFormat("Tiff", "b96b3cb1-0728-11d3-9d7b-0000f81ef32e");
					}
					tiffImageFormat = ImageFormat.TiffImageFormat;
				}
				return tiffImageFormat;
			}
		}

		/// <summary>Возвращает формат метафайлов Windows WMF.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Imaging.ImageFormat" />, определяющий формат метафайлов Windows.</returns>
		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x0001E3F4 File Offset: 0x0001C5F4
		public static ImageFormat Wmf
		{
			get
			{
				object obj = ImageFormat.locker;
				ImageFormat wmfImageFormat;
				lock (obj)
				{
					if (ImageFormat.WmfImageFormat == null)
					{
						ImageFormat.WmfImageFormat = new ImageFormat("Wmf", "b96b3cad-0728-11d3-9d7b-0000f81ef32e");
					}
					wmfImageFormat = ImageFormat.WmfImageFormat;
				}
				return wmfImageFormat;
			}
		}

		// Token: 0x04000A59 RID: 2649
		private Guid guid;

		// Token: 0x04000A5A RID: 2650
		private string name;

		// Token: 0x04000A5B RID: 2651
		private const string BmpGuid = "b96b3cab-0728-11d3-9d7b-0000f81ef32e";

		// Token: 0x04000A5C RID: 2652
		private const string EmfGuid = "b96b3cac-0728-11d3-9d7b-0000f81ef32e";

		// Token: 0x04000A5D RID: 2653
		private const string ExifGuid = "b96b3cb2-0728-11d3-9d7b-0000f81ef32e";

		// Token: 0x04000A5E RID: 2654
		private const string GifGuid = "b96b3cb0-0728-11d3-9d7b-0000f81ef32e";

		// Token: 0x04000A5F RID: 2655
		private const string TiffGuid = "b96b3cb1-0728-11d3-9d7b-0000f81ef32e";

		// Token: 0x04000A60 RID: 2656
		private const string PngGuid = "b96b3caf-0728-11d3-9d7b-0000f81ef32e";

		// Token: 0x04000A61 RID: 2657
		private const string MemoryBmpGuid = "b96b3caa-0728-11d3-9d7b-0000f81ef32e";

		// Token: 0x04000A62 RID: 2658
		private const string IconGuid = "b96b3cb5-0728-11d3-9d7b-0000f81ef32e";

		// Token: 0x04000A63 RID: 2659
		private const string JpegGuid = "b96b3cae-0728-11d3-9d7b-0000f81ef32e";

		// Token: 0x04000A64 RID: 2660
		private const string WmfGuid = "b96b3cad-0728-11d3-9d7b-0000f81ef32e";

		// Token: 0x04000A65 RID: 2661
		private static object locker = new object();

		// Token: 0x04000A66 RID: 2662
		private static ImageFormat BmpImageFormat;

		// Token: 0x04000A67 RID: 2663
		private static ImageFormat EmfImageFormat;

		// Token: 0x04000A68 RID: 2664
		private static ImageFormat ExifImageFormat;

		// Token: 0x04000A69 RID: 2665
		private static ImageFormat GifImageFormat;

		// Token: 0x04000A6A RID: 2666
		private static ImageFormat TiffImageFormat;

		// Token: 0x04000A6B RID: 2667
		private static ImageFormat PngImageFormat;

		// Token: 0x04000A6C RID: 2668
		private static ImageFormat MemoryBmpImageFormat;

		// Token: 0x04000A6D RID: 2669
		private static ImageFormat IconImageFormat;

		// Token: 0x04000A6E RID: 2670
		private static ImageFormat JpegImageFormat;

		// Token: 0x04000A6F RID: 2671
		private static ImageFormat WmfImageFormat;
	}
}
