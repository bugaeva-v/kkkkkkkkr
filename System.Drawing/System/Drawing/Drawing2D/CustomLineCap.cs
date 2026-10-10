using System;
using System.Runtime.InteropServices;

namespace System.Drawing.Drawing2D
{
	/// <summary>Инкапсулирует определяемое пользователем завершение отрезка.</summary>
	// Token: 0x0200013B RID: 315
	public class CustomLineCap : MarshalByRefObject, ICloneable, IDisposable
	{
		// Token: 0x06000E18 RID: 3608 RVA: 0x0001FDFD File Offset: 0x0001DFFD
		internal static CustomLineCap CreateCustomLineCapObject(IntPtr cap)
		{
			return new CustomLineCap(cap);
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00003A04 File Offset: 0x00001C04
		internal CustomLineCap()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Drawing2D.CustomLineCap" /> с заданными контуром и заполнением.</summary>
		/// <param name="fillPath">Объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />, определяющий заполнение для пользовательского завершения отрезка.</param>
		/// <param name="strokePath">Объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />, определяющий контур для пользовательского завершения отрезка.</param>
		// Token: 0x06000E1A RID: 3610 RVA: 0x0001FE05 File Offset: 0x0001E005
		public CustomLineCap(GraphicsPath fillPath, GraphicsPath strokePath) : this(fillPath, strokePath, LineCap.Flat)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Drawing2D.CustomLineCap" /> из указанного существующего перечисления <see cref="T:System.Drawing.Drawing2D.LineCap" /> с заданными контуром и заполнением.</summary>
		/// <param name="fillPath">Объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />, определяющий заполнение для пользовательского завершения отрезка.</param>
		/// <param name="strokePath">Объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />, определяющий контур для пользовательского завершения отрезка.</param>
		/// <param name="baseCap">Завершение отрезка, из которого создается пользовательское завершение.</param>
		// Token: 0x06000E1B RID: 3611 RVA: 0x0001FE10 File Offset: 0x0001E010
		public CustomLineCap(GraphicsPath fillPath, GraphicsPath strokePath, LineCap baseCap) : this(fillPath, strokePath, baseCap, 0f)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Drawing2D.CustomLineCap" /> из указанного существующего перечисления <see cref="T:System.Drawing.Drawing2D.LineCap" /> с определенным контуром, заполнением и углублением.</summary>
		/// <param name="fillPath">Объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />, определяющий заполнение для пользовательского завершения отрезка.</param>
		/// <param name="strokePath">Объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />, определяющий контур для пользовательского завершения отрезка.</param>
		/// <param name="baseCap">Завершение отрезка, из которого создается пользовательское завершение.</param>
		/// <param name="baseInset">Расстояние между отрезком и его завершением.</param>
		// Token: 0x06000E1C RID: 3612 RVA: 0x0001FE20 File Offset: 0x0001E020
		public CustomLineCap(GraphicsPath fillPath, GraphicsPath strokePath, LineCap baseCap, float baseInset)
		{
			IntPtr nativeLineCap;
			int num = GDIPlus.GdipCreateCustomLineCap(new HandleRef(fillPath, (fillPath == null) ? IntPtr.Zero : fillPath.nativePath), new HandleRef(strokePath, (strokePath == null) ? IntPtr.Zero : strokePath.nativePath), baseCap, baseInset, out nativeLineCap);
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
			this.SetNativeLineCap(nativeLineCap);
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x0001FE7B File Offset: 0x0001E07B
		internal CustomLineCap(IntPtr nativeLineCap)
		{
			this.SetNativeLineCap(nativeLineCap);
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x0001FE8A File Offset: 0x0001E08A
		internal void SetNativeLineCap(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException("handle");
			}
			this.nativeCap = new SafeCustomLineCapHandle(handle);
		}

		/// <summary>Освобождает все ресурсы, используемые этим объектом <see cref="T:System.Drawing.Drawing2D.CustomLineCap" />.</summary>
		// Token: 0x06000E1F RID: 3615 RVA: 0x0001FEB0 File Offset: 0x0001E0B0
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Drawing.Drawing2D.CustomLineCap" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06000E20 RID: 3616 RVA: 0x0001FEBF File Offset: 0x0001E0BF
		protected virtual void Dispose(bool disposing)
		{
			if (this._disposed)
			{
				return;
			}
			if (disposing && this.nativeCap != null)
			{
				this.nativeCap.Dispose();
			}
			this._disposed = true;
		}

		/// <summary>Позволяет объекту <see cref="T:System.Drawing.Drawing2D.CustomLineCap" /> попытаться освободить ресурсы и выполнить другие операции очистки, перед тем как объект <see cref="T:System.Drawing.Drawing2D.CustomLineCap" /> будет утилизирован в процессе сборки мусора.</summary>
		// Token: 0x06000E21 RID: 3617 RVA: 0x0001FEE8 File Offset: 0x0001E0E8
		~CustomLineCap()
		{
			this.Dispose(false);
		}

		/// <summary>Создает точную копию данного объекта <see cref="T:System.Drawing.Drawing2D.CustomLineCap" />.</summary>
		/// <returns>
		///   <see cref="T:System.Drawing.Drawing2D.CustomLineCap" />, создаваемый этим методом, приводится к типу объекта.</returns>
		// Token: 0x06000E22 RID: 3618 RVA: 0x0001FF18 File Offset: 0x0001E118
		public object Clone()
		{
			return this.CoreClone();
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x0001FF20 File Offset: 0x0001E120
		internal virtual object CoreClone()
		{
			IntPtr cap;
			int num = GDIPlus.GdipCloneCustomLineCap(new HandleRef(this, this.nativeCap), out cap);
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
			return CustomLineCap.CreateCustomLineCapObject(cap);
		}

		/// <summary>Задает завершения, используемые для начала и конца линий, составляющих данное пользовательское завершение отрезка.</summary>
		/// <param name="startCap">Перечисление <see cref="T:System.Drawing.Drawing2D.LineCap" />, используемое в начале линии в данном завершении.</param>
		/// <param name="endCap">Перечисление <see cref="T:System.Drawing.Drawing2D.LineCap" />, используемое в конце линии в данном завершении.</param>
		// Token: 0x06000E24 RID: 3620 RVA: 0x0001FF58 File Offset: 0x0001E158
		public void SetStrokeCaps(LineCap startCap, LineCap endCap)
		{
			int num = GDIPlus.GdipSetCustomLineCapStrokeCaps(new HandleRef(this, this.nativeCap), startCap, endCap);
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
		}

		/// <summary>Получает завершения, используемые для начала и конца линий, составляющих данное пользовательское завершение отрезка.</summary>
		/// <param name="startCap">Перечисление <see cref="T:System.Drawing.Drawing2D.LineCap" />, используемое в начале линии в данном завершении.</param>
		/// <param name="endCap">Перечисление <see cref="T:System.Drawing.Drawing2D.LineCap" />, используемое в конце линии в данном завершении.</param>
		// Token: 0x06000E25 RID: 3621 RVA: 0x0001FF88 File Offset: 0x0001E188
		public void GetStrokeCaps(out LineCap startCap, out LineCap endCap)
		{
			int num = GDIPlus.GdipGetCustomLineCapStrokeCaps(new HandleRef(this, this.nativeCap), out startCap, out endCap);
			if (num != 0)
			{
				throw SafeNativeMethods.Gdip.StatusException(num);
			}
		}

		/// <summary>Получает или задает перечисление <see cref="T:System.Drawing.Drawing2D.LineJoin" />, определяющее, как соединены отрезки, составляющие данный объект <see cref="T:System.Drawing.Drawing2D.CustomLineCap" />.</summary>
		/// <returns>Перечисление <see cref="T:System.Drawing.Drawing2D.LineJoin" />, которое использует данный объект <see cref="T:System.Drawing.Drawing2D.CustomLineCap" /> для связи отрезков.</returns>
		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000E26 RID: 3622 RVA: 0x0001FFB8 File Offset: 0x0001E1B8
		// (set) Token: 0x06000E27 RID: 3623 RVA: 0x0001FFEC File Offset: 0x0001E1EC
		public LineJoin StrokeJoin
		{
			get
			{
				LineJoin result;
				int num = GDIPlus.GdipGetCustomLineCapStrokeJoin(new HandleRef(this, this.nativeCap), out result);
				if (num != 0)
				{
					throw SafeNativeMethods.Gdip.StatusException(num);
				}
				return result;
			}
			set
			{
				int num = GDIPlus.GdipSetCustomLineCapStrokeJoin(new HandleRef(this, this.nativeCap), value);
				if (num != 0)
				{
					throw SafeNativeMethods.Gdip.StatusException(num);
				}
			}
		}

		/// <summary>Получает или задает перечисление <see cref="T:System.Drawing.Drawing2D.LineCap" />, на котором основан этот объект <see cref="T:System.Drawing.Drawing2D.CustomLineCap" />.</summary>
		/// <returns>Перечисление <see cref="T:System.Drawing.Drawing2D.LineCap" />, на котором основан этот объект <see cref="T:System.Drawing.Drawing2D.CustomLineCap" />.</returns>
		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000E28 RID: 3624 RVA: 0x0002001C File Offset: 0x0001E21C
		// (set) Token: 0x06000E29 RID: 3625 RVA: 0x00020050 File Offset: 0x0001E250
		public LineCap BaseCap
		{
			get
			{
				LineCap result;
				int num = GDIPlus.GdipGetCustomLineCapBaseCap(new HandleRef(this, this.nativeCap), out result);
				if (num != 0)
				{
					throw SafeNativeMethods.Gdip.StatusException(num);
				}
				return result;
			}
			set
			{
				int num = GDIPlus.GdipSetCustomLineCapBaseCap(new HandleRef(this, this.nativeCap), value);
				if (num != 0)
				{
					throw SafeNativeMethods.Gdip.StatusException(num);
				}
			}
		}

		/// <summary>Получает или задает расстояние между отрезком и его завершением.</summary>
		/// <returns>Расстояние между началом завершения отрезка и концом отрезка.</returns>
		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000E2A RID: 3626 RVA: 0x00020080 File Offset: 0x0001E280
		// (set) Token: 0x06000E2B RID: 3627 RVA: 0x000200B4 File Offset: 0x0001E2B4
		public float BaseInset
		{
			get
			{
				float result;
				int num = GDIPlus.GdipGetCustomLineCapBaseInset(new HandleRef(this, this.nativeCap), out result);
				if (num != 0)
				{
					throw SafeNativeMethods.Gdip.StatusException(num);
				}
				return result;
			}
			set
			{
				int num = GDIPlus.GdipSetCustomLineCapBaseInset(new HandleRef(this, this.nativeCap), value);
				if (num != 0)
				{
					throw SafeNativeMethods.Gdip.StatusException(num);
				}
			}
		}

		/// <summary>Получает или задает величину, на которую масштабируется данный объект класса <see cref="T:System.Drawing.Drawing2D.CustomLineCap" /> по отношению к ширине объекта <see cref="T:System.Drawing.Pen" />.</summary>
		/// <returns>Величина, на которую масштабируется завершение отрезка.</returns>
		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000E2C RID: 3628 RVA: 0x000200E4 File Offset: 0x0001E2E4
		// (set) Token: 0x06000E2D RID: 3629 RVA: 0x00020118 File Offset: 0x0001E318
		public float WidthScale
		{
			get
			{
				float result;
				int num = GDIPlus.GdipGetCustomLineCapWidthScale(new HandleRef(this, this.nativeCap), out result);
				if (num != 0)
				{
					throw SafeNativeMethods.Gdip.StatusException(num);
				}
				return result;
			}
			set
			{
				int num = GDIPlus.GdipSetCustomLineCapWidthScale(new HandleRef(this, this.nativeCap), value);
				if (num != 0)
				{
					throw SafeNativeMethods.Gdip.StatusException(num);
				}
			}
		}

		// Token: 0x04000ACF RID: 2767
		internal SafeCustomLineCapHandle nativeCap;

		// Token: 0x04000AD0 RID: 2768
		private bool _disposed;
	}
}
