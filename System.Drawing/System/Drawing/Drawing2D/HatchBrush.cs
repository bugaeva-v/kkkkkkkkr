using System;
using System.Runtime.InteropServices;

namespace System.Drawing.Drawing2D
{
	/// <summary>Задает прямоугольную кисть со стилем штриховки, основным цветом и цветом фона. Этот класс не наследуется.</summary>
	// Token: 0x02000142 RID: 322
	public sealed class HatchBrush : Brush
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Drawing2D.HatchBrush" /> с указанным перечислением <see cref="T:System.Drawing.Drawing2D.HatchStyle" /> и основным цветом.</summary>
		/// <param name="hatchstyle">Одно из значений <see cref="T:System.Drawing.Drawing2D.HatchStyle" />, представляющее шаблон, нарисованный данным объектом <see cref="T:System.Drawing.Drawing2D.HatchBrush" />.</param>
		/// <param name="foreColor">Структура <see cref="T:System.Drawing.Color" />, представляющая цвет линий, нарисованных данным объектом <see cref="T:System.Drawing.Drawing2D.HatchBrush" />.</param>
		// Token: 0x06000E3F RID: 3647 RVA: 0x00020593 File Offset: 0x0001E793
		public HatchBrush(HatchStyle hatchstyle, Color foreColor) : this(hatchstyle, foreColor, Color.FromArgb(-16777216))
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Drawing2D.HatchBrush" /> с указанным перечислением <see cref="T:System.Drawing.Drawing2D.HatchStyle" />, основным цветом и цветом фона.</summary>
		/// <param name="hatchstyle">Одно из значений <see cref="T:System.Drawing.Drawing2D.HatchStyle" />, представляющее шаблон, нарисованный данным объектом <see cref="T:System.Drawing.Drawing2D.HatchBrush" />.</param>
		/// <param name="foreColor">Структура <see cref="T:System.Drawing.Color" />, представляющая цвет линий, нарисованных данным объектом <see cref="T:System.Drawing.Drawing2D.HatchBrush" />.</param>
		/// <param name="backColor">Структура <see cref="T:System.Drawing.Color" />, представляющая цвет интервалов между линиями, нарисованными данным объектом <see cref="T:System.Drawing.Drawing2D.HatchBrush" />.</param>
		// Token: 0x06000E40 RID: 3648 RVA: 0x000205A8 File Offset: 0x0001E7A8
		public HatchBrush(HatchStyle hatchstyle, Color foreColor, Color backColor)
		{
			if (hatchstyle < HatchStyle.Horizontal || hatchstyle > HatchStyle.SolidDiamond)
			{
				throw new ArgumentException(SR.Format("The value of argument '{0}' ({1}) is invalid for Enum type '{2}'.", new object[]
				{
					"hatchstyle",
					hatchstyle,
					"HatchStyle"
				}), "hatchstyle");
			}
			IntPtr nativeBrushInternal;
			SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipCreateHatchBrush((int)hatchstyle, foreColor.ToArgb(), backColor.ToArgb(), out nativeBrushInternal));
			base.SetNativeBrushInternal(nativeBrushInternal);
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x00005F38 File Offset: 0x00004138
		internal HatchBrush(IntPtr nativeBrush)
		{
			base.SetNativeBrushInternal(nativeBrush);
		}

		/// <summary>Создает точную копию объекта <see cref="T:System.Drawing.Drawing2D.HatchBrush" />.</summary>
		/// <returns>
		///   <see cref="T:System.Drawing.Drawing2D.HatchBrush" />, создаваемый этим методом, приводится к типу объекта.</returns>
		// Token: 0x06000E42 RID: 3650 RVA: 0x0002061C File Offset: 0x0001E81C
		public override object Clone()
		{
			IntPtr zero = IntPtr.Zero;
			SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipCloneBrush(new HandleRef(this, base.NativeBrush), out zero));
			return new HatchBrush(zero);
		}

		/// <summary>Получает стиль штриховки для данного объекта <see cref="T:System.Drawing.Drawing2D.HatchBrush" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Drawing.Drawing2D.HatchStyle" />, представляющее шаблон этого объекта <see cref="T:System.Drawing.Drawing2D.HatchBrush" />.</returns>
		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x00020650 File Offset: 0x0001E850
		public HatchStyle HatchStyle
		{
			get
			{
				int result;
				SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipGetHatchStyle(new HandleRef(this, base.NativeBrush), out result));
				return (HatchStyle)result;
			}
		}

		/// <summary>Получает цвет линий штриховки, нарисованных данным объектом <see cref="T:System.Drawing.Drawing2D.HatchBrush" />.</summary>
		/// <returns>Структура <see cref="T:System.Drawing.Color" />, представляющая основной цвет для данного объекта <see cref="T:System.Drawing.Drawing2D.HatchBrush" />.</returns>
		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x00020678 File Offset: 0x0001E878
		public Color ForegroundColor
		{
			get
			{
				int argb;
				SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipGetHatchForegroundColor(new HandleRef(this, base.NativeBrush), out argb));
				return Color.FromArgb(argb);
			}
		}

		/// <summary>Получает цвет интервалов между линиями штриховки, нарисованными данным объектом <see cref="T:System.Drawing.Drawing2D.HatchBrush" />.</summary>
		/// <returns>Структура <see cref="T:System.Drawing.Color" />, представляющая цвет фона для данного объекта <see cref="T:System.Drawing.Drawing2D.HatchBrush" />.</returns>
		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x000206A4 File Offset: 0x0001E8A4
		public Color BackgroundColor
		{
			get
			{
				int argb;
				SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipGetHatchBackgroundColor(new HandleRef(this, base.NativeBrush), out argb));
				return Color.FromArgb(argb);
			}
		}
	}
}
