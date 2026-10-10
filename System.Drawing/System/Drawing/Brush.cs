using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace System.Drawing
{
	/// <summary>Определяет объекты, которые используются для заливки внутри графических фигур, таких как прямоугольники, эллипсы, круги, многоугольники и дорожки.</summary>
	// Token: 0x02000018 RID: 24
	public abstract class Brush : MarshalByRefObject, ICloneable, IDisposable
	{
		/// <summary>При переопределении в производном классе создает точную копию этого объекта <see cref="T:System.Drawing.Brush" />.</summary>
		/// <returns>Новый объект <see cref="T:System.Drawing.Brush" />, созданный данным методом.</returns>
		// Token: 0x06000047 RID: 71
		public abstract object Clone();

		/// <summary>В производном классе определяет ссылку на объект-кисть GDI+.</summary>
		/// <param name="brush">Указатель на объект-кисть GDI+.</param>
		// Token: 0x06000048 RID: 72 RVA: 0x00003931 File Offset: 0x00001B31
		protected internal void SetNativeBrush(IntPtr brush)
		{
			this.SetNativeBrushInternal(brush);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000393A File Offset: 0x00001B3A
		internal void SetNativeBrushInternal(IntPtr brush)
		{
			this._nativeBrush = brush;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00003943 File Offset: 0x00001B43
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal IntPtr NativeBrush
		{
			get
			{
				return this._nativeBrush;
			}
		}

		/// <summary>Освобождает все ресурсы, используемые этим объектом <see cref="T:System.Drawing.Brush" />.</summary>
		// Token: 0x0600004B RID: 75 RVA: 0x0000394B File Offset: 0x00001B4B
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Drawing.Brush" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x0600004C RID: 76 RVA: 0x0000395C File Offset: 0x00001B5C
		protected virtual void Dispose(bool disposing)
		{
			if (this._nativeBrush != IntPtr.Zero)
			{
				try
				{
					GDIPlus.GdipDeleteBrush(new HandleRef(this, this._nativeBrush));
				}
				catch (Exception ex) when (!ClientUtils.IsSecurityOrCriticalException(ex))
				{
				}
				finally
				{
					this._nativeBrush = IntPtr.Zero;
				}
			}
		}

		/// <summary>Позволяет объекту попытаться освободить ресурсы и выполнить другие операции очистки, перед тем как он будет уничтожен во время сборки мусора.</summary>
		// Token: 0x0600004D RID: 77 RVA: 0x000039D4 File Offset: 0x00001BD4
		~Brush()
		{
			this.Dispose(false);
		}

		// Token: 0x04000150 RID: 336
		private IntPtr _nativeBrush;
	}
}
