using System;
using System.Runtime.InteropServices;

namespace System.Drawing.Imaging
{
	/// <summary>Задает атрибуты точечного рисунка. Класс <see cref="T:System.Drawing.Imaging.BitmapData" /> используется методами <see cref="Overload:System.Drawing.Bitmap.LockBits" /> и <see cref="M:System.Drawing.Bitmap.UnlockBits(System.Drawing.Imaging.BitmapData)" /> класса <see cref="T:System.Drawing.Bitmap" />. Не наследуется.</summary>
	// Token: 0x02000117 RID: 279
	[StructLayout(LayoutKind.Sequential)]
	public sealed class BitmapData
	{
		/// <summary>Возвращает или задает высоту объекта <see cref="T:System.Drawing.Bitmap" /> в пикселях. Иногда также называется числом строк развертки.</summary>
		/// <returns>Высота объекта <see cref="T:System.Drawing.Bitmap" /> в пикселях.</returns>
		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x0001DFAB File Offset: 0x0001C1AB
		// (set) Token: 0x06000CF2 RID: 3314 RVA: 0x0001DFB3 File Offset: 0x0001C1B3
		public int Height
		{
			get
			{
				return this.height;
			}
			set
			{
				this.height = value;
			}
		}

		/// <summary>Возвращает или задает ширину объекта <see cref="T:System.Drawing.Bitmap" /> в пикселях. Также под этим можно понимать количество пикселей в одной строке развертки.</summary>
		/// <returns>Ширина объекта <see cref="T:System.Drawing.Bitmap" /> в пикселях.</returns>
		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x0001DFBC File Offset: 0x0001C1BC
		// (set) Token: 0x06000CF4 RID: 3316 RVA: 0x0001DFC4 File Offset: 0x0001C1C4
		public int Width
		{
			get
			{
				return this.width;
			}
			set
			{
				this.width = value;
			}
		}

		/// <summary>Возвращает или задает формат пиксельной информации объекта <see cref="T:System.Drawing.Bitmap" />, который возвращает объект <see cref="T:System.Drawing.Imaging.BitmapData" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Imaging.PixelFormat" />, определяющий формат сведений о пикселях в связанном объекте <see cref="T:System.Drawing.Bitmap" />.</returns>
		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x0001DFCD File Offset: 0x0001C1CD
		// (set) Token: 0x06000CF6 RID: 3318 RVA: 0x0001DFD5 File Offset: 0x0001C1D5
		public PixelFormat PixelFormat
		{
			get
			{
				return this.pixel_format;
			}
			set
			{
				this.pixel_format = value;
			}
		}

		/// <summary>Зарезервировано. Не используется.</summary>
		/// <returns>Зарезервировано. Не используется.</returns>
		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x0001DFDE File Offset: 0x0001C1DE
		// (set) Token: 0x06000CF8 RID: 3320 RVA: 0x0001DFE6 File Offset: 0x0001C1E6
		public int Reserved
		{
			get
			{
				return this.reserved;
			}
			set
			{
				this.reserved = value;
			}
		}

		/// <summary>Возвращает или задает адрес данных первого пикселя в точечном рисунке. Также под этим можно понимать первую строку развертки в точечном рисунке.</summary>
		/// <returns>Адрес данных первого пикселя в точечном рисунке.</returns>
		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x0001DFEF File Offset: 0x0001C1EF
		// (set) Token: 0x06000CFA RID: 3322 RVA: 0x0001DFF7 File Offset: 0x0001C1F7
		public IntPtr Scan0
		{
			get
			{
				return this.scan0;
			}
			set
			{
				this.scan0 = value;
			}
		}

		/// <summary>Возвращает или задает ширину шага по индексу (также называемую шириной развертки) объекта <see cref="T:System.Drawing.Bitmap" />.</summary>
		/// <returns>Ширина шага по индексу нового объекта <see cref="T:System.Drawing.Bitmap" /> в байтах.</returns>
		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x0001E000 File Offset: 0x0001C200
		// (set) Token: 0x06000CFC RID: 3324 RVA: 0x0001E008 File Offset: 0x0001C208
		public int Stride
		{
			get
			{
				return this.stride;
			}
			set
			{
				this.stride = value;
			}
		}

		// Token: 0x04000A48 RID: 2632
		private int width;

		// Token: 0x04000A49 RID: 2633
		private int height;

		// Token: 0x04000A4A RID: 2634
		private int stride;

		// Token: 0x04000A4B RID: 2635
		private PixelFormat pixel_format;

		// Token: 0x04000A4C RID: 2636
		private IntPtr scan0;

		// Token: 0x04000A4D RID: 2637
		private int reserved;

		// Token: 0x04000A4E RID: 2638
		private IntPtr palette;

		// Token: 0x04000A4F RID: 2639
		private int property_count;

		// Token: 0x04000A50 RID: 2640
		private IntPtr property;

		// Token: 0x04000A51 RID: 2641
		private float dpi_horz;

		// Token: 0x04000A52 RID: 2642
		private float dpi_vert;

		// Token: 0x04000A53 RID: 2643
		private int image_flags;

		// Token: 0x04000A54 RID: 2644
		private int left;

		// Token: 0x04000A55 RID: 2645
		private int top;

		// Token: 0x04000A56 RID: 2646
		private int x;

		// Token: 0x04000A57 RID: 2647
		private int y;

		// Token: 0x04000A58 RID: 2648
		private int transparent;
	}
}
