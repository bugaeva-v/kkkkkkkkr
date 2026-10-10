using System;
using System.Runtime.InteropServices;

namespace System.Drawing
{
	/// <summary>Определяет кисть одного цвета. Кисти используются для заливки графических фигур, таких как прямоугольники, эллипсы, круги, многоугольники и контуры. Этот класс не наследуется.</summary>
	// Token: 0x0200003A RID: 58
	public sealed class SolidBrush : Brush
	{
		/// <summary>Инициализирует новый объект <see cref="T:System.Drawing.SolidBrush" /> указанного цвета.</summary>
		/// <param name="color">Структура <see cref="T:System.Drawing.Color" />, представляющая цвет этой кисти.</param>
		// Token: 0x060000F6 RID: 246 RVA: 0x000057A8 File Offset: 0x000039A8
		public SolidBrush(Color color)
		{
			this._color = color;
			IntPtr zero = IntPtr.Zero;
			SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipCreateSolidFill(this._color.ToArgb(), out zero));
			base.SetNativeBrushInternal(zero);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000057F1 File Offset: 0x000039F1
		internal SolidBrush(Color color, bool immutable) : this(color)
		{
			this._immutable = immutable;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00005801 File Offset: 0x00003A01
		internal SolidBrush(IntPtr nativeBrush)
		{
			base.SetNativeBrushInternal(nativeBrush);
		}

		/// <summary>Создает точную копию объекта <see cref="T:System.Drawing.SolidBrush" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.SolidBrush" />, создаваемый с помощью данного метода.</returns>
		// Token: 0x060000F9 RID: 249 RVA: 0x0000581C File Offset: 0x00003A1C
		public override object Clone()
		{
			IntPtr zero = IntPtr.Zero;
			SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipCloneBrush(new HandleRef(this, base.NativeBrush), out zero));
			return new SolidBrush(zero);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000584D File Offset: 0x00003A4D
		protected override void Dispose(bool disposing)
		{
			if (!disposing)
			{
				this._immutable = false;
			}
			else if (this._immutable)
			{
				throw new ArgumentException(SR.Format("Changes cannot be made to {0} because permissions are not valid.", new object[]
				{
					"Brush"
				}));
			}
			base.Dispose(disposing);
		}

		/// <summary>Получает или задает цвет объекта <see cref="T:System.Drawing.SolidBrush" />.</summary>
		/// <returns>Структура <see cref="T:System.Drawing.Color" />, представляющая цвет этой кисти.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.Drawing.SolidBrush.Color" /> должно быть установлено доступным только для чтения <see cref="T:System.Drawing.SolidBrush" />.</exception>
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00005888 File Offset: 0x00003A88
		// (set) Token: 0x060000FC RID: 252 RVA: 0x000058D4 File Offset: 0x00003AD4
		public Color Color
		{
			get
			{
				if (this._color == Color.Empty)
				{
					int argb;
					SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipGetSolidFillColor(new HandleRef(this, base.NativeBrush), out argb));
					this._color = Color.FromArgb(argb);
				}
				return this._color;
			}
			set
			{
				if (this._immutable)
				{
					throw new ArgumentException(SR.Format("Changes cannot be made to {0} because permissions are not valid.", new object[]
					{
						"Brush"
					}));
				}
				if (this._color != value)
				{
					Color color = this._color;
					this.InternalSetColor(value);
				}
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00005923 File Offset: 0x00003B23
		private void InternalSetColor(Color value)
		{
			SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipSetSolidFillColor(new HandleRef(this, base.NativeBrush), value.ToArgb()));
			this._color = value;
		}

		// Token: 0x04000355 RID: 853
		private Color _color = Color.Empty;

		// Token: 0x04000356 RID: 854
		private bool _immutable;
	}
}
