using System;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Unity;

namespace System.Drawing
{
	/// <summary>Инкапсулирует поверхность рисования GDI+. Этот класс не наследуется.</summary>
	// Token: 0x02000071 RID: 113
	public sealed class Graphics : MarshalByRefObject, IDisposable, IDeviceContext
	{
		// Token: 0x060004A5 RID: 1189 RVA: 0x0000C54C File Offset: 0x0000A74C
		internal Graphics(IntPtr nativeGraphics)
		{
			this.nativeObject = IntPtr.Zero;
			base..ctor();
			this.nativeObject = nativeGraphics;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0000C568 File Offset: 0x0000A768
		internal Graphics(IntPtr nativeGraphics, Image image) : this(nativeGraphics)
		{
			Metafile metafile = image as Metafile;
			if (metafile != null)
			{
				this._metafileHolder = metafile.AddMetafileHolder();
			}
		}

		/// <summary>Позволяет объекту попытаться освободить ресурсы и выполнить другие операции очистки, перед тем как он будет уничтожен во время сборки мусора.</summary>
		// Token: 0x060004A7 RID: 1191 RVA: 0x0000C594 File Offset: 0x0000A794
		~Graphics()
		{
			this.Dispose();
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x0000C5C0 File Offset: 0x0000A7C0
		internal static float systemDpiX
		{
			get
			{
				if (Graphics.defDpiX == 0f)
				{
					Graphics graphics = Graphics.FromImage(new Bitmap(1, 1));
					Graphics.defDpiX = graphics.DpiX;
					Graphics.defDpiY = graphics.DpiY;
				}
				return Graphics.defDpiX;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x0000C5F4 File Offset: 0x0000A7F4
		internal static float systemDpiY
		{
			get
			{
				if (Graphics.defDpiY == 0f)
				{
					Graphics graphics = Graphics.FromImage(new Bitmap(1, 1));
					Graphics.defDpiX = graphics.DpiX;
					Graphics.defDpiY = graphics.DpiY;
				}
				return Graphics.defDpiY;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x0000C628 File Offset: 0x0000A828
		internal IntPtr NativeGraphics
		{
			get
			{
				return this.nativeObject;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x0000C628 File Offset: 0x0000A828
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x0000C630 File Offset: 0x0000A830
		internal IntPtr NativeObject
		{
			get
			{
				return this.nativeObject;
			}
			set
			{
				this.nativeObject = value;
			}
		}

		/// <summary>Добавляет комментарий к текущему объекту <see cref="T:System.Drawing.Imaging.Metafile" />.</summary>
		/// <param name="data">Массив байтов, содержащий комментарий.</param>
		// Token: 0x060004AD RID: 1197 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles, both WMF and EMF formats, aren't supported.")]
		public void AddMetafileComment(byte[] data)
		{
			throw new NotImplementedException();
		}

		/// <summary>Сохраняет графический контейнер, содержащий текущее состояние данного объекта <see cref="T:System.Drawing.Graphics" />, а затем открывает и использует новый графический контейнер.</summary>
		/// <returns>Данный метод возвращает объект <see cref="T:System.Drawing.Drawing2D.GraphicsContainer" />, который представляет состояние объекта <see cref="T:System.Drawing.Graphics" /> на момент вызова метода.</returns>
		// Token: 0x060004AE RID: 1198 RVA: 0x0000C63C File Offset: 0x0000A83C
		public GraphicsContainer BeginContainer()
		{
			uint state;
			GDIPlus.CheckStatus(GDIPlus.GdipBeginContainer2(this.nativeObject, out state));
			return new GraphicsContainer(state);
		}

		/// <summary>Сохраняет графический контейнер, содержащий текущее состояние данного объекта <see cref="T:System.Drawing.Graphics" />, а также открывает и использует новый графический контейнер с указанным преобразованием масштаба.</summary>
		/// <param name="dstrect">Структура <see cref="T:System.Drawing.Rectangle" />, которая вместе с параметром <paramref name="srcrect" /> задает преобразование масштаба для контейнера.</param>
		/// <param name="srcrect">Структура <see cref="T:System.Drawing.Rectangle" />, которая вместе с параметром <paramref name="dstrect" /> задает преобразование масштаба для контейнера.</param>
		/// <param name="unit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицу измерения для контейнера.</param>
		/// <returns>Данный метод возвращает объект <see cref="T:System.Drawing.Drawing2D.GraphicsContainer" />, который представляет состояние объекта <see cref="T:System.Drawing.Graphics" /> на момент вызова метода.</returns>
		// Token: 0x060004AF RID: 1199 RVA: 0x0000C664 File Offset: 0x0000A864
		[MonoTODO("The rectangles and unit parameters aren't supported in libgdiplus")]
		public GraphicsContainer BeginContainer(Rectangle dstrect, Rectangle srcrect, GraphicsUnit unit)
		{
			uint state;
			GDIPlus.CheckStatus(GDIPlus.GdipBeginContainerI(this.nativeObject, ref dstrect, ref srcrect, unit, out state));
			return new GraphicsContainer(state);
		}

		/// <summary>Сохраняет графический контейнер, содержащий текущее состояние данного объекта <see cref="T:System.Drawing.Graphics" />, а также открывает и использует новый графический контейнер с указанным преобразованием масштаба.</summary>
		/// <param name="dstrect">Структура <see cref="T:System.Drawing.RectangleF" />, которая вместе с параметром <paramref name="srcrect" /> задает преобразование масштаба для нового графического контейнера.</param>
		/// <param name="srcrect">Структура <see cref="T:System.Drawing.RectangleF" />, которая вместе с параметром <paramref name="dstrect" /> задает преобразование масштаба для нового графического контейнера.</param>
		/// <param name="unit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицу измерения для контейнера.</param>
		/// <returns>Данный метод возвращает объект <see cref="T:System.Drawing.Drawing2D.GraphicsContainer" />, который представляет состояние объекта <see cref="T:System.Drawing.Graphics" /> на момент вызова метода.</returns>
		// Token: 0x060004B0 RID: 1200 RVA: 0x0000C690 File Offset: 0x0000A890
		[MonoTODO("The rectangles and unit parameters aren't supported in libgdiplus")]
		public GraphicsContainer BeginContainer(RectangleF dstrect, RectangleF srcrect, GraphicsUnit unit)
		{
			uint state;
			GDIPlus.CheckStatus(GDIPlus.GdipBeginContainer(this.nativeObject, ref dstrect, ref srcrect, unit, out state));
			return new GraphicsContainer(state);
		}

		/// <summary>Очищает всю поверхность рисования и выполняет заливку поверхности указанным цветом фона.</summary>
		/// <param name="color">Структура <see cref="T:System.Drawing.Color" />, которая представляет собой цвет фона для поверхности рисования.</param>
		// Token: 0x060004B1 RID: 1201 RVA: 0x0000C6BA File Offset: 0x0000A8BA
		public void Clear(Color color)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipGraphicsClear(this.nativeObject, color.ToArgb()));
		}

		/// <summary>Выполняет перемещение набора битов данных о цвете, соответствующих прямоугольнику пикселей, с экрана на поверхность рисования объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="upperLeftSource">Точка в верхнем левом углу исходного прямоугольника.</param>
		/// <param name="upperLeftDestination">Точка в верхнем левом углу целевого прямоугольника.</param>
		/// <param name="blockRegionSize">Размер передаваемой области.</param>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Операция выполнена со сбоем.</exception>
		// Token: 0x060004B2 RID: 1202 RVA: 0x0000C6D3 File Offset: 0x0000A8D3
		[MonoLimitation("Works on Win32 and on X11 (but not on Cocoa and Quartz)")]
		public void CopyFromScreen(Point upperLeftSource, Point upperLeftDestination, Size blockRegionSize)
		{
			this.CopyFromScreen(upperLeftSource.X, upperLeftSource.Y, upperLeftDestination.X, upperLeftDestination.Y, blockRegionSize, CopyPixelOperation.SourceCopy);
		}

		/// <summary>Выполняет перемещение набора битов данных о цвете, соответствующих прямоугольнику пикселей, с экрана на поверхность рисования объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="upperLeftSource">Точка в верхнем левом углу исходного прямоугольника.</param>
		/// <param name="upperLeftDestination">Точка в верхнем левом углу целевого прямоугольника.</param>
		/// <param name="blockRegionSize">Размер передаваемой области.</param>
		/// <param name="copyPixelOperation">Одно из значений <see cref="T:System.Drawing.CopyPixelOperation" />.</param>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
		///   <paramref name="copyPixelOperation" /> не является членом <see cref="T:System.Drawing.CopyPixelOperation" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Операция выполнена со сбоем.</exception>
		// Token: 0x060004B3 RID: 1203 RVA: 0x0000C6FD File Offset: 0x0000A8FD
		[MonoLimitation("Works on Win32 and (for CopyPixelOperation.SourceCopy only) on X11 but not on Cocoa and Quartz")]
		public void CopyFromScreen(Point upperLeftSource, Point upperLeftDestination, Size blockRegionSize, CopyPixelOperation copyPixelOperation)
		{
			this.CopyFromScreen(upperLeftSource.X, upperLeftSource.Y, upperLeftDestination.X, upperLeftDestination.Y, blockRegionSize, copyPixelOperation);
		}

		/// <summary>Выполняет перемещение набора битов данных о цвете, соответствующих прямоугольнику пикселей, с экрана на поверхность рисования объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="sourceX">Координата X точки в верхнем левом углу исходного прямоугольника.</param>
		/// <param name="sourceY">Координата Y точки в верхнем левом углу исходного прямоугольника.</param>
		/// <param name="destinationX">Координата X точки в верхнем левом углу целевого прямоугольника.</param>
		/// <param name="destinationY">Координата Y точки в верхнем левом углу целевого прямоугольника.</param>
		/// <param name="blockRegionSize">Размер передаваемой области.</param>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Операция выполнена со сбоем.</exception>
		// Token: 0x060004B4 RID: 1204 RVA: 0x0000C724 File Offset: 0x0000A924
		[MonoLimitation("Works on Win32 and on X11 (but not on Cocoa and Quartz)")]
		public void CopyFromScreen(int sourceX, int sourceY, int destinationX, int destinationY, Size blockRegionSize)
		{
			this.CopyFromScreen(sourceX, sourceY, destinationX, destinationY, blockRegionSize, CopyPixelOperation.SourceCopy);
		}

		/// <summary>Выполняет перемещение набора битов данных о цвете, соответствующих прямоугольнику пикселей, с экрана на поверхность рисования объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="sourceX">Координата X точки в верхнем левом углу исходного прямоугольника.</param>
		/// <param name="sourceY">Координата Y точки в верхнем левом углу исходного прямоугольника.</param>
		/// <param name="destinationX">Координата X точки в верхнем левом углу целевого прямоугольника.</param>
		/// <param name="destinationY">Координата Y точки в верхнем левом углу целевого прямоугольника.</param>
		/// <param name="blockRegionSize">Размер передаваемой области.</param>
		/// <param name="copyPixelOperation">Одно из значений <see cref="T:System.Drawing.CopyPixelOperation" />.</param>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
		///   <paramref name="copyPixelOperation" /> не является членом <see cref="T:System.Drawing.CopyPixelOperation" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">Операция выполнена со сбоем.</exception>
		// Token: 0x060004B5 RID: 1205 RVA: 0x0000C738 File Offset: 0x0000A938
		[MonoLimitation("Works on Win32 and (for CopyPixelOperation.SourceCopy only) on X11 but not on Cocoa and Quartz")]
		public void CopyFromScreen(int sourceX, int sourceY, int destinationX, int destinationY, Size blockRegionSize, CopyPixelOperation copyPixelOperation)
		{
			if (!Enum.IsDefined(typeof(CopyPixelOperation), copyPixelOperation))
			{
				throw new InvalidEnumArgumentException(Locale.GetText("Enum argument value '{0}' is not valid for CopyPixelOperation", new object[]
				{
					copyPixelOperation
				}));
			}
			if (GDIPlus.UseX11Drawable)
			{
				this.CopyFromScreenX11(sourceX, sourceY, destinationX, destinationY, blockRegionSize, copyPixelOperation);
				return;
			}
			if (GDIPlus.UseCarbonDrawable)
			{
				this.CopyFromScreenMac(sourceX, sourceY, destinationX, destinationY, blockRegionSize, copyPixelOperation);
				return;
			}
			if (GDIPlus.UseCocoaDrawable)
			{
				this.CopyFromScreenMac(sourceX, sourceY, destinationX, destinationY, blockRegionSize, copyPixelOperation);
				return;
			}
			this.CopyFromScreenWin32(sourceX, sourceY, destinationX, destinationY, blockRegionSize, copyPixelOperation);
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0000C7D4 File Offset: 0x0000A9D4
		private void CopyFromScreenWin32(int sourceX, int sourceY, int destinationX, int destinationY, Size blockRegionSize, CopyPixelOperation copyPixelOperation)
		{
			IntPtr dc = GDIPlus.GetDC(GDIPlus.GetDesktopWindow());
			IntPtr hdc = this.GetHdc();
			GDIPlus.BitBlt(hdc, destinationX, destinationY, blockRegionSize.Width, blockRegionSize.Height, dc, sourceX, sourceY, (int)copyPixelOperation);
			GDIPlus.ReleaseDC(IntPtr.Zero, dc);
			this.ReleaseHdc(hdc);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00009B6A File Offset: 0x00007D6A
		private void CopyFromScreenMac(int sourceX, int sourceY, int destinationX, int destinationY, Size blockRegionSize, CopyPixelOperation copyPixelOperation)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0000C824 File Offset: 0x0000AA24
		private void CopyFromScreenX11(int sourceX, int sourceY, int destinationX, int destinationY, Size blockRegionSize, CopyPixelOperation copyPixelOperation)
		{
			int pane = -1;
			int num = 0;
			if (copyPixelOperation != CopyPixelOperation.SourceCopy)
			{
				throw new NotImplementedException("Operation not implemented under X11");
			}
			if (GDIPlus.Display == IntPtr.Zero)
			{
				GDIPlus.Display = GDIPlus.XOpenDisplay(IntPtr.Zero);
			}
			IntPtr drawable = GDIPlus.XRootWindow(GDIPlus.Display, 0);
			IntPtr visual = GDIPlus.XDefaultVisual(GDIPlus.Display, 0);
			XVisualInfo xvisualInfo = default(XVisualInfo);
			xvisualInfo.visualid = GDIPlus.XVisualIDFromVisual(visual);
			IntPtr intPtr = GDIPlus.XGetVisualInfo(GDIPlus.Display, 1, ref xvisualInfo, ref num);
			xvisualInfo = (XVisualInfo)Marshal.PtrToStructure(intPtr, typeof(XVisualInfo));
			IntPtr intPtr2 = GDIPlus.XGetImage(GDIPlus.Display, drawable, sourceX, sourceY, blockRegionSize.Width, blockRegionSize.Height, pane, 2);
			if (intPtr2 == IntPtr.Zero)
			{
				throw new InvalidOperationException(string.Format("XGetImage returned NULL when asked to for a {0}x{1} region block", blockRegionSize.Width, blockRegionSize.Height));
			}
			Bitmap bitmap = new Bitmap(blockRegionSize.Width, blockRegionSize.Height);
			int num2 = (int)xvisualInfo.red_mask;
			int num3 = (int)xvisualInfo.blue_mask;
			int num4 = (int)xvisualInfo.green_mask;
			for (int i = 0; i < blockRegionSize.Height; i++)
			{
				for (int j = 0; j < blockRegionSize.Width; j++)
				{
					int num5 = GDIPlus.XGetPixel(intPtr2, j, i);
					uint depth = xvisualInfo.depth;
					int red;
					int green;
					int blue;
					if (depth != 16U)
					{
						if (depth != 24U && depth != 32U)
						{
							throw new NotImplementedException(Locale.GetText("{0}bbp depth not supported.", new object[]
							{
								xvisualInfo.depth
							}));
						}
						red = ((num5 & num2) >> 16 & 255);
						green = ((num5 & num4) >> 8 & 255);
						blue = (num5 & num3 & 255);
					}
					else
					{
						red = ((num5 & num2) >> 8 & 255);
						green = ((num5 & num4) >> 3 & 255);
						blue = ((num5 & num3) << 3 & 255);
					}
					bitmap.SetPixel(j, i, Color.FromArgb(255, red, green, blue));
				}
			}
			this.DrawImage(bitmap, destinationX, destinationY);
			bitmap.Dispose();
			GDIPlus.XDestroyImage(intPtr2);
			GDIPlus.XFree(intPtr);
		}

		/// <summary>Освобождает все ресурсы, используемые этим объектом <see cref="T:System.Drawing.Graphics" />.</summary>
		// Token: 0x060004B9 RID: 1209 RVA: 0x0000CA70 File Offset: 0x0000AC70
		public void Dispose()
		{
			if (!this.disposed)
			{
				if (this.deviceContextHdc != IntPtr.Zero)
				{
					this.ReleaseHdc();
				}
				if (GDIPlus.UseCarbonDrawable || GDIPlus.UseCocoaDrawable)
				{
					this.Flush();
					if (this.maccontext != null)
					{
						this.maccontext.Release();
					}
				}
				Status status = GDIPlus.GdipDeleteGraphics(this.nativeObject);
				this.nativeObject = IntPtr.Zero;
				GDIPlus.CheckStatus(status);
				if (this._metafileHolder != null)
				{
					Metafile.MetafileHolder metafileHolder = this._metafileHolder;
					this._metafileHolder = null;
					metafileHolder.GraphicsDisposed();
				}
				this.disposed = true;
			}
			GC.SuppressFinalize(this);
		}

		/// <summary>Рисует дугу, которая является частью эллипса, заданного структурой <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <param name="pen">Объект <see cref="T:System.Drawing.Pen" />, определяющий цвет, ширину и стиль дуги.</param>
		/// <param name="rect">Структура <see cref="T:System.Drawing.RectangleF" />, определяющая границы эллипса.</param>
		/// <param name="startAngle">Угол (в градусах), который измеряется по часовой стрелке, начиная от оси X и заканчивая начальной точкой дуги.</param>
		/// <param name="sweepAngle">Угол (в градусах), который измеряется по часовой стрелке, начиная от значения параметра <paramref name="startAngle" /> и заканчивая конечной точкой дуги.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004BA RID: 1210 RVA: 0x0000CB06 File Offset: 0x0000AD06
		public void DrawArc(Pen pen, Rectangle rect, float startAngle, float sweepAngle)
		{
			this.DrawArc(pen, (float)rect.X, (float)rect.Y, (float)rect.Width, (float)rect.Height, startAngle, sweepAngle);
		}

		/// <summary>Рисует дугу, которая является частью эллипса, заданного структурой <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <param name="pen">Объект <see cref="T:System.Drawing.Pen" />, определяющий цвет, ширину и стиль дуги.</param>
		/// <param name="rect">Структура <see cref="T:System.Drawing.RectangleF" />, определяющая границы эллипса.</param>
		/// <param name="startAngle">Угол (в градусах), который измеряется по часовой стрелке, начиная от оси X и заканчивая начальной точкой дуги.</param>
		/// <param name="sweepAngle">Угол (в градусах), который измеряется по часовой стрелке, начиная от значения параметра <paramref name="startAngle" /> и заканчивая конечной точкой дуги.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="pen" /> равно <see langword="null" /></exception>
		// Token: 0x060004BB RID: 1211 RVA: 0x0000CB32 File Offset: 0x0000AD32
		public void DrawArc(Pen pen, RectangleF rect, float startAngle, float sweepAngle)
		{
			this.DrawArc(pen, rect.X, rect.Y, rect.Width, rect.Height, startAngle, sweepAngle);
		}

		/// <summary>Рисует дугу, которая является частью эллипса, заданного парой координат, шириной и высотой.</summary>
		/// <param name="pen">Объект <see cref="T:System.Drawing.Pen" />, определяющий цвет, ширину и стиль дуги.</param>
		/// <param name="x">Координата X верхнего левого угла прямоугольника, определяющего эллипс.</param>
		/// <param name="y">Координата Y верхнего левого угла прямоугольника, определяющего эллипс.</param>
		/// <param name="width">Ширина прямоугольника, определяющего эллипс.</param>
		/// <param name="height">Высота прямоугольника, определяющего эллипс.</param>
		/// <param name="startAngle">Угол (в градусах), который измеряется по часовой стрелке, начиная от оси X и заканчивая начальной точкой дуги.</param>
		/// <param name="sweepAngle">Угол (в градусах), который измеряется по часовой стрелке, начиная от значения параметра <paramref name="startAngle" /> и заканчивая конечной точкой дуги.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004BC RID: 1212 RVA: 0x0000CB5A File Offset: 0x0000AD5A
		public void DrawArc(Pen pen, float x, float y, float width, float height, float startAngle, float sweepAngle)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawArc(this.nativeObject, pen.NativePen, x, y, width, height, startAngle, sweepAngle));
		}

		/// <summary>Рисует дугу, которая является частью эллипса, заданного парой координат, шириной и высотой.</summary>
		/// <param name="pen">Объект <see cref="T:System.Drawing.Pen" />, определяющий цвет, ширину и стиль дуги.</param>
		/// <param name="x">Координата X верхнего левого угла прямоугольника, определяющего эллипс.</param>
		/// <param name="y">Координата Y верхнего левого угла прямоугольника, определяющего эллипс.</param>
		/// <param name="width">Ширина прямоугольника, определяющего эллипс.</param>
		/// <param name="height">Высота прямоугольника, определяющего эллипс.</param>
		/// <param name="startAngle">Угол (в градусах), который измеряется по часовой стрелке, начиная от оси X и заканчивая начальной точкой дуги.</param>
		/// <param name="sweepAngle">Угол (в градусах), который измеряется по часовой стрелке, начиная от значения параметра <paramref name="startAngle" /> и заканчивая конечной точкой дуги.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004BD RID: 1213 RVA: 0x0000CB8A File Offset: 0x0000AD8A
		public void DrawArc(Pen pen, int x, int y, int width, int height, int startAngle, int sweepAngle)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawArcI(this.nativeObject, pen.NativePen, x, y, width, height, (float)startAngle, (float)sweepAngle));
		}

		/// <summary>Строит сплайн Безье, определяемый четырьмя структурами <see cref="T:System.Drawing.PointF" />.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и стиль кривой.</param>
		/// <param name="pt1">Структура <see cref="T:System.Drawing.PointF" />, представляющая начальную точку кривой.</param>
		/// <param name="pt2">Структура <see cref="T:System.Drawing.PointF" />, представляющая первую контрольную точку кривой.</param>
		/// <param name="pt3">Структура <see cref="T:System.Drawing.PointF" />, представляющая вторую контрольную точку кривой.</param>
		/// <param name="pt4">Структура <see cref="T:System.Drawing.PointF" />, представляющая конечную точку кривой.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004BE RID: 1214 RVA: 0x0000CBBC File Offset: 0x0000ADBC
		public void DrawBezier(Pen pen, PointF pt1, PointF pt2, PointF pt3, PointF pt4)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawBezier(this.nativeObject, pen.NativePen, pt1.X, pt1.Y, pt2.X, pt2.Y, pt3.X, pt3.Y, pt4.X, pt4.Y));
		}

		/// <summary>Строит сплайн Безье, определяемый четырьмя структурами <see cref="T:System.Drawing.Point" />.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и стиль кривой.</param>
		/// <param name="pt1">Структура <see cref="T:System.Drawing.Point" />, представляющая начальную точку кривой.</param>
		/// <param name="pt2">Структура <see cref="T:System.Drawing.Point" />, представляющая первую контрольную точку кривой.</param>
		/// <param name="pt3">Структура <see cref="T:System.Drawing.Point" />, представляющая вторую контрольную точку кривой.</param>
		/// <param name="pt4">Структура <see cref="T:System.Drawing.Point" />, представляющая конечную точку кривой.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004BF RID: 1215 RVA: 0x0000CC28 File Offset: 0x0000AE28
		public void DrawBezier(Pen pen, Point pt1, Point pt2, Point pt3, Point pt4)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawBezierI(this.nativeObject, pen.NativePen, pt1.X, pt1.Y, pt2.X, pt2.Y, pt3.X, pt3.Y, pt4.X, pt4.Y));
		}

		/// <summary>Строит сплайн Безье, определяемый четырьмя упорядоченными парами координат, которые представляют точки.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и стиль кривой.</param>
		/// <param name="x1">Координата X начальной точки кривой.</param>
		/// <param name="y1">Координата Y начальной точки кривой.</param>
		/// <param name="x2">Координата X первой контрольной точки кривой.</param>
		/// <param name="y2">Координата Y первой контрольной точки кривой.</param>
		/// <param name="x3">Координата X второй контрольной точки кривой.</param>
		/// <param name="y3">Координата Y второй контрольной точки кривой.</param>
		/// <param name="x4">Координата X конечной точки кривой.</param>
		/// <param name="y4">Координата Y конечной точки кривой.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004C0 RID: 1216 RVA: 0x0000CC94 File Offset: 0x0000AE94
		public void DrawBezier(Pen pen, float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawBezier(this.nativeObject, pen.NativePen, x1, y1, x2, y2, x3, y3, x4, y4));
		}

		/// <summary>Строит последовательность сплайнов Безье из массива структур <see cref="T:System.Drawing.Point" />.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и стиль кривой.</param>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.Point" />, представляющий точки, которые  определяют кривую. Количество точек в массиве должно быть кратно трем плюс 1, например 4, 7 или 10.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="points" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004C1 RID: 1217 RVA: 0x0000CCD4 File Offset: 0x0000AED4
		public void DrawBeziers(Pen pen, Point[] points)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			int num = points.Length;
			if (num < 4)
			{
				return;
			}
			for (int i = 0; i < num - 1; i += 3)
			{
				Point point = points[i];
				Point point2 = points[i + 1];
				Point point3 = points[i + 2];
				Point point4 = points[i + 3];
				GDIPlus.CheckStatus(GDIPlus.GdipDrawBezier(this.nativeObject, pen.NativePen, (float)point.X, (float)point.Y, (float)point2.X, (float)point2.Y, (float)point3.X, (float)point3.Y, (float)point4.X, (float)point4.Y));
			}
		}

		/// <summary>Строит последовательность сплайнов Безье из массива структур <see cref="T:System.Drawing.PointF" />.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и стиль кривой.</param>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.PointF" />, представляющий точки, которые  определяют кривую. Количество точек в массиве должно быть кратно трем плюс 1, например 4, 7 или 10.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="points" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004C2 RID: 1218 RVA: 0x0000CD98 File Offset: 0x0000AF98
		public void DrawBeziers(Pen pen, PointF[] points)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			int num = points.Length;
			if (num < 4)
			{
				return;
			}
			for (int i = 0; i < num - 1; i += 3)
			{
				PointF pointF = points[i];
				PointF pointF2 = points[i + 1];
				PointF pointF3 = points[i + 2];
				PointF pointF4 = points[i + 3];
				GDIPlus.CheckStatus(GDIPlus.GdipDrawBezier(this.nativeObject, pen.NativePen, pointF.X, pointF.Y, pointF2.X, pointF2.Y, pointF3.X, pointF3.Y, pointF4.X, pointF4.Y));
			}
		}

		/// <summary>Строит замкнутый фундаментальный сплайн, определяемый массивом структур <see cref="T:System.Drawing.PointF" />.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и высоту кривой.</param>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.PointF" />, определяющий сплайн.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="points" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004C3 RID: 1219 RVA: 0x0000CE4E File Offset: 0x0000B04E
		public void DrawClosedCurve(Pen pen, PointF[] points)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawClosedCurve(this.nativeObject, pen.NativePen, points, points.Length));
		}

		/// <summary>Строит замкнутый фундаментальный сплайн, определяемый массивом структур <see cref="T:System.Drawing.Point" />.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и высоту кривой.</param>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.Point" />, определяющий сплайн.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="points" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004C4 RID: 1220 RVA: 0x0000CE86 File Offset: 0x0000B086
		public void DrawClosedCurve(Pen pen, Point[] points)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawClosedCurveI(this.nativeObject, pen.NativePen, points, points.Length));
		}

		/// <summary>Строит замкнутый фундаментальный сплайн, определяемый массивом структур <see cref="T:System.Drawing.Point" />, с указанным натяжением.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и высоту кривой.</param>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.Point" />, определяющий сплайн.</param>
		/// <param name="tension">Значение не ниже 0,0F, которое задает натяжение кривой.</param>
		/// <param name="fillmode">Элемент перечисления <see cref="T:System.Drawing.Drawing2D.FillMode" />, определяющий способ заполнения кривой. Данный параметр является обязательным, однако не обрабатывается.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="points" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004C5 RID: 1221 RVA: 0x0000CEBE File Offset: 0x0000B0BE
		public void DrawClosedCurve(Pen pen, Point[] points, float tension, FillMode fillmode)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawClosedCurve2I(this.nativeObject, pen.NativePen, points, points.Length, tension));
		}

		/// <summary>Строит замкнутый фундаментальный сплайн, определяемый массивом структур <see cref="T:System.Drawing.PointF" />, с указанным натяжением.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и высоту кривой.</param>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.PointF" />, определяющий сплайн.</param>
		/// <param name="tension">Значение не ниже 0,0F, которое задает натяжение кривой.</param>
		/// <param name="fillmode">Элемент перечисления <see cref="T:System.Drawing.Drawing2D.FillMode" />, определяющий способ заполнения кривой. Данный параметр является обязательным, однако не обрабатывается.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="points" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004C6 RID: 1222 RVA: 0x0000CEF7 File Offset: 0x0000B0F7
		public void DrawClosedCurve(Pen pen, PointF[] points, float tension, FillMode fillmode)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawClosedCurve2(this.nativeObject, pen.NativePen, points, points.Length, tension));
		}

		/// <summary>Строит фундаментальный сплайн через точки указанного массива структур <see cref="T:System.Drawing.Point" />.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и высоту кривой.</param>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.Point" />, определяющий сплайн.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="points" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004C7 RID: 1223 RVA: 0x0000CF30 File Offset: 0x0000B130
		public void DrawCurve(Pen pen, Point[] points)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawCurveI(this.nativeObject, pen.NativePen, points, points.Length));
		}

		/// <summary>Строит фундаментальный сплайн через точки указанного массива структур <see cref="T:System.Drawing.PointF" />.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и стиль кривой.</param>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.PointF" />, определяющий сплайн.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="points" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004C8 RID: 1224 RVA: 0x0000CF68 File Offset: 0x0000B168
		public void DrawCurve(Pen pen, PointF[] points)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawCurve(this.nativeObject, pen.NativePen, points, points.Length));
		}

		/// <summary>Строит фундаментальный сплайн через точки указанного массива структур <see cref="T:System.Drawing.PointF" /> с указанным натяжением.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и стиль кривой.</param>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.PointF" />, представляющий точки, которые определяют кривую.</param>
		/// <param name="tension">Значение не ниже 0,0F, которое задает натяжение кривой.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="points" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004C9 RID: 1225 RVA: 0x0000CFA0 File Offset: 0x0000B1A0
		public void DrawCurve(Pen pen, PointF[] points, float tension)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawCurve2(this.nativeObject, pen.NativePen, points, points.Length, tension));
		}

		/// <summary>Строит фундаментальный сплайн через точки указанного массива структур <see cref="T:System.Drawing.Point" /> с указанным натяжением.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и стиль кривой.</param>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.Point" />, определяющий сплайн.</param>
		/// <param name="tension">Значение не ниже 0,0F, которое задает натяжение кривой.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="points" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004CA RID: 1226 RVA: 0x0000CFD9 File Offset: 0x0000B1D9
		public void DrawCurve(Pen pen, Point[] points, float tension)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawCurve2I(this.nativeObject, pen.NativePen, points, points.Length, tension));
		}

		/// <summary>Строит фундаментальный сплайн через точки указанного массива структур <see cref="T:System.Drawing.PointF" />. Смещение при рисовании начинается от начала массива.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и стиль кривой.</param>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.PointF" />, определяющий сплайн.</param>
		/// <param name="offset">Смещение от первого элемента в массиве параметра <paramref name="points" /> до начальной точки кривой.</param>
		/// <param name="numberOfSegments">Количество сегментов, включаемых в кривую после начальной точки.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="points" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004CB RID: 1227 RVA: 0x0000D012 File Offset: 0x0000B212
		public void DrawCurve(Pen pen, PointF[] points, int offset, int numberOfSegments)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawCurve3(this.nativeObject, pen.NativePen, points, points.Length, offset, numberOfSegments, 0.5f));
		}

		/// <summary>Строит фундаментальный сплайн через точки указанного массива структур <see cref="T:System.Drawing.Point" /> с указанным натяжением.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и стиль кривой.</param>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.Point" />, определяющий сплайн.</param>
		/// <param name="offset">Смещение от первого элемента в массиве параметра <paramref name="points" /> до начальной точки кривой.</param>
		/// <param name="numberOfSegments">Количество сегментов, включаемых в кривую после начальной точки.</param>
		/// <param name="tension">Значение не ниже 0,0F, которое задает натяжение кривой.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="points" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004CC RID: 1228 RVA: 0x0000D052 File Offset: 0x0000B252
		public void DrawCurve(Pen pen, Point[] points, int offset, int numberOfSegments, float tension)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawCurve3I(this.nativeObject, pen.NativePen, points, points.Length, offset, numberOfSegments, tension));
		}

		/// <summary>Строит фундаментальный сплайн через точки указанного массива структур <see cref="T:System.Drawing.PointF" /> с указанным натяжением. Смещение при рисовании начинается от начала массива.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и стиль кривой.</param>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.PointF" />, определяющий сплайн.</param>
		/// <param name="offset">Смещение от первого элемента в массиве параметра <paramref name="points" /> до начальной точки кривой.</param>
		/// <param name="numberOfSegments">Количество сегментов, включаемых в кривую после начальной точки.</param>
		/// <param name="tension">Значение не ниже 0,0F, которое задает натяжение кривой.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="points" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004CD RID: 1229 RVA: 0x0000D08F File Offset: 0x0000B28F
		public void DrawCurve(Pen pen, PointF[] points, int offset, int numberOfSegments, float tension)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawCurve3(this.nativeObject, pen.NativePen, points, points.Length, offset, numberOfSegments, tension));
		}

		/// <summary>Рисует эллипс, определяемый ограничивающей структурой <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и стиль эллипса.</param>
		/// <param name="rect">Структура <see cref="T:System.Drawing.Rectangle" />, определяющая границы эллипса.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004CE RID: 1230 RVA: 0x0000D0CC File Offset: 0x0000B2CC
		public void DrawEllipse(Pen pen, Rectangle rect)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			this.DrawEllipse(pen, rect.X, rect.Y, rect.Width, rect.Height);
		}

		/// <summary>Рисует эллипс, определяемый ограничивающей структурой <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и стиль эллипса.</param>
		/// <param name="rect">Структура <see cref="T:System.Drawing.RectangleF" />, определяющая границы эллипса.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004CF RID: 1231 RVA: 0x0000D0FF File Offset: 0x0000B2FF
		public void DrawEllipse(Pen pen, RectangleF rect)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			this.DrawEllipse(pen, rect.X, rect.Y, rect.Width, rect.Height);
		}

		/// <summary>Рисует эллипс, определяемый ограничивающим прямоугольником, заданным с помощью координат верхнего левого угла прямоугольника, высоты и ширины.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и стиль эллипса.</param>
		/// <param name="x">Координата X верхнего левого угла ограничивающего прямоугольника, который определяет эллипс.</param>
		/// <param name="y">Координата Y верхнего левого угла ограничивающего прямоугольника, который определяет эллипс.</param>
		/// <param name="width">Ширина ограничивающего прямоугольника, который определяет эллипс.</param>
		/// <param name="height">Высота ограничивающего прямоугольника, который определяет эллипс.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004D0 RID: 1232 RVA: 0x0000D132 File Offset: 0x0000B332
		public void DrawEllipse(Pen pen, int x, int y, int width, int height)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawEllipseI(this.nativeObject, pen.NativePen, x, y, width, height));
		}

		/// <summary>Рисует эллипс, определяемый ограничивающим прямоугольником, заданным с помощью пары координат, ширины и высоты.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и стиль эллипса.</param>
		/// <param name="x">Координата X верхнего левого угла ограничивающего прямоугольника, который определяет эллипс.</param>
		/// <param name="y">Координата Y верхнего левого угла ограничивающего прямоугольника, который определяет эллипс.</param>
		/// <param name="width">Ширина ограничивающего прямоугольника, который определяет эллипс.</param>
		/// <param name="height">Высота ограничивающего прямоугольника, который определяет эллипс.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004D1 RID: 1233 RVA: 0x0000D15E File Offset: 0x0000B35E
		public void DrawEllipse(Pen pen, float x, float y, float width, float height)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawEllipse(this.nativeObject, pen.NativePen, x, y, width, height));
		}

		/// <summary>Формирует изображение, представленное указанным объектом <see cref="T:System.Drawing.Icon" />, в пределах области, заданной структурой <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <param name="icon">Объект <see cref="T:System.Drawing.Icon" /> для рисования.</param>
		/// <param name="targetRect">Структура <see cref="T:System.Drawing.Rectangle" />, которая задает расположение и размер создаваемого изображения на экране. Изображение, содержащееся в параметре <paramref name="icon" />, масштабируется по размерам этой прямоугольной области.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="icon" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004D2 RID: 1234 RVA: 0x0000D18A File Offset: 0x0000B38A
		public void DrawIcon(Icon icon, Rectangle targetRect)
		{
			if (icon == null)
			{
				throw new ArgumentNullException("icon");
			}
			this.DrawImage(icon.GetInternalBitmap(), targetRect);
		}

		/// <summary>Формирует изображение, представленное указанным объектом <see cref="T:System.Drawing.Icon" />, в указанных координатах.</summary>
		/// <param name="icon">Объект <see cref="T:System.Drawing.Icon" /> для рисования.</param>
		/// <param name="x">Координата X верхнего левого угла формируемого изображения.</param>
		/// <param name="y">Координата Y верхнего левого угла формируемого изображения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="icon" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004D3 RID: 1235 RVA: 0x0000D1A7 File Offset: 0x0000B3A7
		public void DrawIcon(Icon icon, int x, int y)
		{
			if (icon == null)
			{
				throw new ArgumentNullException("icon");
			}
			this.DrawImage(icon.GetInternalBitmap(), x, y);
		}

		/// <summary>Формирует изображение, представленное указанным объектом <see cref="T:System.Drawing.Icon" />, без его масштабирования.</summary>
		/// <param name="icon">Объект <see cref="T:System.Drawing.Icon" /> для рисования.</param>
		/// <param name="targetRect">Структура <see cref="T:System.Drawing.Rectangle" />, которая задает расположение и размер создаваемого изображения. Изображение не масштабируется до размеров данного прямоугольника и сохраняет свой исходный размер. Если изображение больше этого прямоугольника, то оно обрезается до его размеров.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="icon" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004D4 RID: 1236 RVA: 0x0000D1C5 File Offset: 0x0000B3C5
		public void DrawIconUnstretched(Icon icon, Rectangle targetRect)
		{
			if (icon == null)
			{
				throw new ArgumentNullException("icon");
			}
			this.DrawImageUnscaled(icon.GetInternalBitmap(), targetRect);
		}

		/// <summary>Рисует заданный объект <see cref="T:System.Drawing.Image" /> в заданном месте, используя указанный размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="rect">Структура <see cref="T:System.Drawing.RectangleF" />, которая задает расположение и размер формируемого изображения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004D5 RID: 1237 RVA: 0x0000D1E4 File Offset: 0x0000B3E4
		public void DrawImage(Image image, RectangleF rect)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImageRect(this.nativeObject, image.NativeObject, rect.X, rect.Y, rect.Width, rect.Height));
		}

		/// <summary>Рисует заданный объект <see cref="T:System.Drawing.Image" /> в указанном месте, используя его исходный фактический размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="point">Структура <see cref="T:System.Drawing.PointF" />, задающая расположение верхнего левого угла формируемого изображения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004D6 RID: 1238 RVA: 0x0000D231 File Offset: 0x0000B431
		public void DrawImage(Image image, PointF point)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImage(this.nativeObject, image.NativeObject, point.X, point.Y));
		}

		/// <summary>Рисует указанный объект <see cref="T:System.Drawing.Image" /> в заданном месте, используя указанную форму и размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="destPoints">Массив из трех структур <see cref="T:System.Drawing.Point" />, определяющих параллелограмм.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004D7 RID: 1239 RVA: 0x0000D265 File Offset: 0x0000B465
		public void DrawImage(Image image, Point[] destPoints)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			if (destPoints == null)
			{
				throw new ArgumentNullException("destPoints");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImagePointsI(this.nativeObject, image.NativeObject, destPoints, destPoints.Length));
		}

		/// <summary>Рисует заданный объект <see cref="T:System.Drawing.Image" /> в указанном месте, используя его исходный фактический размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="point">Структура <see cref="T:System.Drawing.Point" />, представляющая расположение верхнего левого угла изображения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004D8 RID: 1240 RVA: 0x0000D29D File Offset: 0x0000B49D
		public void DrawImage(Image image, Point point)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			this.DrawImage(image, point.X, point.Y);
		}

		/// <summary>Рисует заданный объект <see cref="T:System.Drawing.Image" /> в заданном месте, используя указанный размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="rect">Структура <see cref="T:System.Drawing.Rectangle" />, которая задает расположение и размер формируемого изображения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004D9 RID: 1241 RVA: 0x0000D2C2 File Offset: 0x0000B4C2
		public void DrawImage(Image image, Rectangle rect)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			this.DrawImage(image, rect.X, rect.Y, rect.Width, rect.Height);
		}

		/// <summary>Рисует указанный объект <see cref="T:System.Drawing.Image" /> в заданном месте, используя указанную форму и размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="destPoints">Массив из трех структур <see cref="T:System.Drawing.PointF" />, определяющих параллелограмм.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004DA RID: 1242 RVA: 0x0000D2F5 File Offset: 0x0000B4F5
		public void DrawImage(Image image, PointF[] destPoints)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			if (destPoints == null)
			{
				throw new ArgumentNullException("destPoints");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImagePoints(this.nativeObject, image.NativeObject, destPoints, destPoints.Length));
		}

		/// <summary>Рисует указанное изображение, используя его исходный фактический размер, в месте, заданном парой координат.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="x">Координата X верхнего левого угла формируемого изображения.</param>
		/// <param name="y">Координата Y верхнего левого угла формируемого изображения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004DB RID: 1243 RVA: 0x0000D32D File Offset: 0x0000B52D
		public void DrawImage(Image image, int x, int y)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImageI(this.nativeObject, image.NativeObject, x, y));
		}

		/// <summary>Рисует заданный объект <see cref="T:System.Drawing.Image" /> в указанном месте, используя его исходный фактический размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="x">Координата X верхнего левого угла формируемого изображения.</param>
		/// <param name="y">Координата Y верхнего левого угла формируемого изображения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004DC RID: 1244 RVA: 0x0000D355 File Offset: 0x0000B555
		public void DrawImage(Image image, float x, float y)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImage(this.nativeObject, image.NativeObject, x, y));
		}

		/// <summary>Рисует заданную часть указанного объекта <see cref="T:System.Drawing.Image" /> в заданном месте, используя заданный размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="destRect">Структура <see cref="T:System.Drawing.Rectangle" />, которая задает расположение и размер формируемого изображения. Изображение масштабируется по размерам прямоугольника.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.Rectangle" />, которая задает часть объекта <paramref name="image" /> для рисования.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицы измерения, используемые параметром <paramref name="srcRect" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004DD RID: 1245 RVA: 0x0000D380 File Offset: 0x0000B580
		public void DrawImage(Image image, Rectangle destRect, Rectangle srcRect, GraphicsUnit srcUnit)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImageRectRectI(this.nativeObject, image.NativeObject, destRect.X, destRect.Y, destRect.Width, destRect.Height, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, srcUnit, IntPtr.Zero, null, IntPtr.Zero));
		}

		/// <summary>Рисует заданную часть указанного объекта <see cref="T:System.Drawing.Image" /> в заданном месте, используя заданный размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="destRect">Структура <see cref="T:System.Drawing.RectangleF" />, которая задает расположение и размер формируемого изображения. Изображение масштабируется по размерам прямоугольника.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.RectangleF" />, которая задает часть объекта <paramref name="image" /> для рисования.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицы измерения, используемые параметром <paramref name="srcRect" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004DE RID: 1246 RVA: 0x0000D3F8 File Offset: 0x0000B5F8
		public void DrawImage(Image image, RectangleF destRect, RectangleF srcRect, GraphicsUnit srcUnit)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImageRectRect(this.nativeObject, image.NativeObject, destRect.X, destRect.Y, destRect.Width, destRect.Height, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, srcUnit, IntPtr.Zero, null, IntPtr.Zero));
		}

		/// <summary>Рисует заданную часть указанного объекта <see cref="T:System.Drawing.Image" /> в заданном месте, используя заданный размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="destPoints">Массив из трех структур <see cref="T:System.Drawing.Point" />, определяющих параллелограмм.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.Rectangle" />, которая задает часть объекта <paramref name="image" /> для рисования.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицы измерения, используемые параметром <paramref name="srcRect" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004DF RID: 1247 RVA: 0x0000D470 File Offset: 0x0000B670
		public void DrawImage(Image image, Point[] destPoints, Rectangle srcRect, GraphicsUnit srcUnit)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			if (destPoints == null)
			{
				throw new ArgumentNullException("destPoints");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImagePointsRectI(this.nativeObject, image.NativeObject, destPoints, destPoints.Length, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, srcUnit, IntPtr.Zero, null, IntPtr.Zero));
		}

		/// <summary>Рисует заданную часть указанного объекта <see cref="T:System.Drawing.Image" /> в заданном месте, используя заданный размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="destPoints">Массив из трех структур <see cref="T:System.Drawing.PointF" />, определяющих параллелограмм.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.RectangleF" />, которая задает часть объекта <paramref name="image" /> для рисования.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицы измерения, используемые параметром <paramref name="srcRect" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004E0 RID: 1248 RVA: 0x0000D4DC File Offset: 0x0000B6DC
		public void DrawImage(Image image, PointF[] destPoints, RectangleF srcRect, GraphicsUnit srcUnit)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			if (destPoints == null)
			{
				throw new ArgumentNullException("destPoints");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImagePointsRect(this.nativeObject, image.NativeObject, destPoints, destPoints.Length, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, srcUnit, IntPtr.Zero, null, IntPtr.Zero));
		}

		/// <summary>Рисует заданную часть указанного объекта <see cref="T:System.Drawing.Image" /> в заданном месте.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="destPoints">Массив из трех структур <see cref="T:System.Drawing.Point" />, определяющих параллелограмм.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.Rectangle" />, которая задает часть объекта <paramref name="image" /> для рисования.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицы измерения, используемые параметром <paramref name="srcRect" />.</param>
		/// <param name="imageAttr">Атрибуты <see cref="T:System.Drawing.Imaging.ImageAttributes" />, содержащие сведения о гамме и перекрашивании для объекта <paramref name="image" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004E1 RID: 1249 RVA: 0x0000D548 File Offset: 0x0000B748
		public void DrawImage(Image image, Point[] destPoints, Rectangle srcRect, GraphicsUnit srcUnit, ImageAttributes imageAttr)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			if (destPoints == null)
			{
				throw new ArgumentNullException("destPoints");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImagePointsRectI(this.nativeObject, image.NativeObject, destPoints, destPoints.Length, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, srcUnit, (imageAttr != null) ? imageAttr.nativeImageAttributes : IntPtr.Zero, null, IntPtr.Zero));
		}

		/// <summary>Рисует заданный объект <see cref="T:System.Drawing.Image" /> в заданном месте, используя указанный размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="x">Координата X верхнего левого угла формируемого изображения.</param>
		/// <param name="y">Координата Y верхнего левого угла формируемого изображения.</param>
		/// <param name="width">Ширина формируемого изображения.</param>
		/// <param name="height">Высота формируемого изображения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004E2 RID: 1250 RVA: 0x0000D5C1 File Offset: 0x0000B7C1
		public void DrawImage(Image image, float x, float y, float width, float height)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImageRect(this.nativeObject, image.NativeObject, x, y, width, height));
		}

		/// <summary>Рисует заданную часть указанного объекта <see cref="T:System.Drawing.Image" /> в заданном месте, используя заданный размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="destPoints">Массив из трех структур <see cref="T:System.Drawing.PointF" />, определяющих параллелограмм.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.RectangleF" />, которая задает часть объекта <paramref name="image" /> для рисования.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицы измерения, используемые параметром <paramref name="srcRect" />.</param>
		/// <param name="imageAttr">Атрибуты <see cref="T:System.Drawing.Imaging.ImageAttributes" />, содержащие сведения о гамме и перекрашивании для объекта <paramref name="image" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004E3 RID: 1251 RVA: 0x0000D5F0 File Offset: 0x0000B7F0
		public void DrawImage(Image image, PointF[] destPoints, RectangleF srcRect, GraphicsUnit srcUnit, ImageAttributes imageAttr)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			if (destPoints == null)
			{
				throw new ArgumentNullException("destPoints");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImagePointsRect(this.nativeObject, image.NativeObject, destPoints, destPoints.Length, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, srcUnit, (imageAttr != null) ? imageAttr.nativeImageAttributes : IntPtr.Zero, null, IntPtr.Zero));
		}

		/// <summary>Рисует часть изображения в заданном месте.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="x">Координата X верхнего левого угла формируемого изображения.</param>
		/// <param name="y">Координата Y верхнего левого угла формируемого изображения.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.Rectangle" />, которая задает часть объекта <paramref name="image" /> для рисования.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицы измерения, используемые параметром <paramref name="srcRect" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004E4 RID: 1252 RVA: 0x0000D66C File Offset: 0x0000B86C
		public void DrawImage(Image image, int x, int y, Rectangle srcRect, GraphicsUnit srcUnit)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImagePointRectI(this.nativeObject, image.NativeObject, x, y, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, srcUnit));
		}

		/// <summary>Рисует заданный объект <see cref="T:System.Drawing.Image" /> в заданном месте, используя указанный размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="x">Координата X верхнего левого угла формируемого изображения.</param>
		/// <param name="y">Координата Y верхнего левого угла формируемого изображения.</param>
		/// <param name="width">Ширина формируемого изображения.</param>
		/// <param name="height">Высота формируемого изображения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004E5 RID: 1253 RVA: 0x0000D6BD File Offset: 0x0000B8BD
		public void DrawImage(Image image, int x, int y, int width, int height)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImageRectI(this.nativeObject, image.nativeObject, x, y, width, height));
		}

		/// <summary>Рисует часть изображения в заданном месте.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="x">Координата X верхнего левого угла формируемого изображения.</param>
		/// <param name="y">Координата Y верхнего левого угла формируемого изображения.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.RectangleF" />, которая задает часть объекта <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицы измерения, используемые параметром <paramref name="srcRect" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004E6 RID: 1254 RVA: 0x0000D6EC File Offset: 0x0000B8EC
		public void DrawImage(Image image, float x, float y, RectangleF srcRect, GraphicsUnit srcUnit)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImagePointRect(this.nativeObject, image.nativeObject, x, y, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, srcUnit));
		}

		/// <summary>Рисует заданную часть указанного объекта <see cref="T:System.Drawing.Image" /> в заданном месте, используя заданный размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="destPoints">Массив из трех структур <see cref="T:System.Drawing.PointF" />, определяющих параллелограмм.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.RectangleF" />, которая задает часть объекта <paramref name="image" /> для рисования.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицы измерения, используемые параметром <paramref name="srcRect" />.</param>
		/// <param name="imageAttr">Атрибуты <see cref="T:System.Drawing.Imaging.ImageAttributes" />, содержащие сведения о гамме и перекрашивании для объекта <paramref name="image" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.DrawImageAbort" />, который задает метод, вызываемый в процессе создания изображения. Этот метод часто вызывается, чтобы проверить, следует ли остановить выполнение метода <see cref="M:System.Drawing.Graphics.DrawImage(System.Drawing.Image,System.Drawing.PointF[],System.Drawing.RectangleF,System.Drawing.GraphicsUnit,System.Drawing.Imaging.ImageAttributes,System.Drawing.Graphics.DrawImageAbort)" /> в соответствии с условиями, определяемыми приложением.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004E7 RID: 1255 RVA: 0x0000D740 File Offset: 0x0000B940
		public void DrawImage(Image image, PointF[] destPoints, RectangleF srcRect, GraphicsUnit srcUnit, ImageAttributes imageAttr, Graphics.DrawImageAbort callback)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			if (destPoints == null)
			{
				throw new ArgumentNullException("destPoints");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImagePointsRect(this.nativeObject, image.NativeObject, destPoints, destPoints.Length, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, srcUnit, (imageAttr != null) ? imageAttr.nativeImageAttributes : IntPtr.Zero, callback, IntPtr.Zero));
		}

		/// <summary>Рисует заданную часть указанного объекта <see cref="T:System.Drawing.Image" /> в заданном месте, используя заданный размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="destPoints">Массив из трех структур <see cref="T:System.Drawing.PointF" />, определяющих параллелограмм.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.Rectangle" />, которая задает часть объекта <paramref name="image" /> для рисования.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицы измерения, используемые параметром <paramref name="srcRect" />.</param>
		/// <param name="imageAttr">Атрибуты <see cref="T:System.Drawing.Imaging.ImageAttributes" />, содержащие сведения о гамме и перекрашивании для объекта <paramref name="image" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.DrawImageAbort" />, который задает метод, вызываемый в процессе создания изображения. Этот метод часто вызывается, чтобы проверить, следует ли остановить выполнение метода <see cref="M:System.Drawing.Graphics.DrawImage(System.Drawing.Image,System.Drawing.Point[],System.Drawing.Rectangle,System.Drawing.GraphicsUnit,System.Drawing.Imaging.ImageAttributes,System.Drawing.Graphics.DrawImageAbort)" /> в соответствии с условиями, определяемыми приложением.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004E8 RID: 1256 RVA: 0x0000D7BC File Offset: 0x0000B9BC
		public void DrawImage(Image image, Point[] destPoints, Rectangle srcRect, GraphicsUnit srcUnit, ImageAttributes imageAttr, Graphics.DrawImageAbort callback)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			if (destPoints == null)
			{
				throw new ArgumentNullException("destPoints");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImagePointsRectI(this.nativeObject, image.NativeObject, destPoints, destPoints.Length, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, srcUnit, (imageAttr != null) ? imageAttr.nativeImageAttributes : IntPtr.Zero, callback, IntPtr.Zero));
		}

		/// <summary>Рисует заданную часть указанного объекта <see cref="T:System.Drawing.Image" /> в заданном месте, используя заданный размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="destPoints">Массив из трех структур <see cref="T:System.Drawing.PointF" />, определяющих параллелограмм.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.Rectangle" />, которая задает часть объекта <paramref name="image" /> для рисования.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицы измерения, используемые параметром <paramref name="srcRect" />.</param>
		/// <param name="imageAttr">Атрибуты <see cref="T:System.Drawing.Imaging.ImageAttributes" />, содержащие сведения о гамме и перекрашивании для объекта <paramref name="image" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.DrawImageAbort" />, который задает метод, вызываемый в процессе создания изображения. Этот метод часто вызывается, чтобы проверить, следует ли остановить выполнение метода <see cref="M:System.Drawing.Graphics.DrawImage(System.Drawing.Image,System.Drawing.Point[],System.Drawing.Rectangle,System.Drawing.GraphicsUnit,System.Drawing.Imaging.ImageAttributes,System.Drawing.Graphics.DrawImageAbort,System.Int32)" /> в соответствии с условиями, определяемыми приложением.</param>
		/// <param name="callbackData">Значение, содержащее дополнительные данные для делегата <see cref="T:System.Drawing.Graphics.DrawImageAbort" />, которые используются при проверке необходимости остановки выполнения метода <see cref="M:System.Drawing.Graphics.DrawImage(System.Drawing.Image,System.Drawing.Point[],System.Drawing.Rectangle,System.Drawing.GraphicsUnit,System.Drawing.Imaging.ImageAttributes,System.Drawing.Graphics.DrawImageAbort,System.Int32)" />.</param>
		// Token: 0x060004E9 RID: 1257 RVA: 0x0000D838 File Offset: 0x0000BA38
		public void DrawImage(Image image, Point[] destPoints, Rectangle srcRect, GraphicsUnit srcUnit, ImageAttributes imageAttr, Graphics.DrawImageAbort callback, int callbackData)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			if (destPoints == null)
			{
				throw new ArgumentNullException("destPoints");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImagePointsRectI(this.nativeObject, image.NativeObject, destPoints, destPoints.Length, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, srcUnit, (imageAttr != null) ? imageAttr.nativeImageAttributes : IntPtr.Zero, callback, (IntPtr)callbackData));
		}

		/// <summary>Рисует заданную часть указанного объекта <see cref="T:System.Drawing.Image" /> в заданном месте, используя заданный размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="destRect">Структура <see cref="T:System.Drawing.Rectangle" />, которая задает расположение и размер формируемого изображения. Изображение масштабируется по размерам прямоугольника.</param>
		/// <param name="srcX">Координата X верхнего левого угла отображаемой части исходного изображения.</param>
		/// <param name="srcY">Координата Y верхнего левого угла отображаемой части исходного изображения.</param>
		/// <param name="srcWidth">Ширина отображаемой части исходного изображения.</param>
		/// <param name="srcHeight">Высота отображаемой части исходного изображения.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицы измерения, используемые для определения исходного прямоугольника.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004EA RID: 1258 RVA: 0x0000D8B4 File Offset: 0x0000BAB4
		public void DrawImage(Image image, Rectangle destRect, float srcX, float srcY, float srcWidth, float srcHeight, GraphicsUnit srcUnit)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImageRectRect(this.nativeObject, image.NativeObject, (float)destRect.X, (float)destRect.Y, (float)destRect.Width, (float)destRect.Height, srcX, srcY, srcWidth, srcHeight, srcUnit, IntPtr.Zero, null, IntPtr.Zero));
		}

		/// <summary>Рисует заданную часть указанного объекта <see cref="T:System.Drawing.Image" /> в заданном месте, используя заданный размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="destPoints">Массив из трех структур <see cref="T:System.Drawing.PointF" />, определяющих параллелограмм.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.RectangleF" />, которая задает часть объекта <paramref name="image" /> для рисования.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицы измерения, используемые параметром <paramref name="srcRect" />.</param>
		/// <param name="imageAttr">Атрибуты <see cref="T:System.Drawing.Imaging.ImageAttributes" />, содержащие сведения о гамме и перекрашивании для объекта <paramref name="image" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.DrawImageAbort" />, который задает метод, вызываемый в процессе создания изображения. Этот метод часто вызывается, чтобы проверить, следует ли остановить выполнение метода <see cref="M:System.Drawing.Graphics.DrawImage(System.Drawing.Image,System.Drawing.PointF[],System.Drawing.RectangleF,System.Drawing.GraphicsUnit,System.Drawing.Imaging.ImageAttributes,System.Drawing.Graphics.DrawImageAbort,System.Int32)" /> в соответствии с условиями, определяемыми приложением.</param>
		/// <param name="callbackData">Значение, содержащее дополнительные данные для делегата <see cref="T:System.Drawing.Graphics.DrawImageAbort" />, которые используются при проверке необходимости остановки выполнения метода <see cref="M:System.Drawing.Graphics.DrawImage(System.Drawing.Image,System.Drawing.PointF[],System.Drawing.RectangleF,System.Drawing.GraphicsUnit,System.Drawing.Imaging.ImageAttributes,System.Drawing.Graphics.DrawImageAbort,System.Int32)" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004EB RID: 1259 RVA: 0x0000D91C File Offset: 0x0000BB1C
		public void DrawImage(Image image, PointF[] destPoints, RectangleF srcRect, GraphicsUnit srcUnit, ImageAttributes imageAttr, Graphics.DrawImageAbort callback, int callbackData)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImagePointsRect(this.nativeObject, image.NativeObject, destPoints, destPoints.Length, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, srcUnit, (imageAttr != null) ? imageAttr.nativeImageAttributes : IntPtr.Zero, callback, (IntPtr)callbackData));
		}

		/// <summary>Рисует заданную часть указанного объекта <see cref="T:System.Drawing.Image" /> в заданном месте, используя заданный размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="destRect">Структура <see cref="T:System.Drawing.Rectangle" />, которая задает расположение и размер формируемого изображения. Изображение масштабируется по размерам прямоугольника.</param>
		/// <param name="srcX">Координата X верхнего левого угла отображаемой части исходного изображения.</param>
		/// <param name="srcY">Координата Y верхнего левого угла отображаемой части исходного изображения.</param>
		/// <param name="srcWidth">Ширина отображаемой части исходного изображения.</param>
		/// <param name="srcHeight">Высота отображаемой части исходного изображения.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицы измерения, используемые для определения исходного прямоугольника.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004EC RID: 1260 RVA: 0x0000D97C File Offset: 0x0000BB7C
		public void DrawImage(Image image, Rectangle destRect, int srcX, int srcY, int srcWidth, int srcHeight, GraphicsUnit srcUnit)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImageRectRectI(this.nativeObject, image.NativeObject, destRect.X, destRect.Y, destRect.Width, destRect.Height, srcX, srcY, srcWidth, srcHeight, srcUnit, IntPtr.Zero, null, IntPtr.Zero));
		}

		/// <summary>Рисует заданную часть указанного объекта <see cref="T:System.Drawing.Image" /> в заданном месте, используя заданный размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="destRect">Структура <see cref="T:System.Drawing.Rectangle" />, которая задает расположение и размер формируемого изображения. Изображение масштабируется по размерам прямоугольника.</param>
		/// <param name="srcX">Координата X верхнего левого угла отображаемой части исходного изображения.</param>
		/// <param name="srcY">Координата Y верхнего левого угла отображаемой части исходного изображения.</param>
		/// <param name="srcWidth">Ширина отображаемой части исходного изображения.</param>
		/// <param name="srcHeight">Высота отображаемой части исходного изображения.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицы измерения, используемые для определения исходного прямоугольника.</param>
		/// <param name="imageAttrs">Атрибуты <see cref="T:System.Drawing.Imaging.ImageAttributes" />, содержащие сведения о гамме и перекрашивании для объекта <paramref name="image" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004ED RID: 1261 RVA: 0x0000D9E0 File Offset: 0x0000BBE0
		public void DrawImage(Image image, Rectangle destRect, float srcX, float srcY, float srcWidth, float srcHeight, GraphicsUnit srcUnit, ImageAttributes imageAttrs)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImageRectRect(this.nativeObject, image.NativeObject, (float)destRect.X, (float)destRect.Y, (float)destRect.Width, (float)destRect.Height, srcX, srcY, srcWidth, srcHeight, srcUnit, (imageAttrs != null) ? imageAttrs.nativeImageAttributes : IntPtr.Zero, null, IntPtr.Zero));
		}

		/// <summary>Рисует заданную часть указанного объекта <see cref="T:System.Drawing.Image" /> в заданном месте, используя заданный размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="destRect">Структура <see cref="T:System.Drawing.Rectangle" />, которая задает расположение и размер формируемого изображения. Изображение масштабируется по размерам прямоугольника.</param>
		/// <param name="srcX">Координата X верхнего левого угла отображаемой части исходного изображения.</param>
		/// <param name="srcY">Координата Y верхнего левого угла отображаемой части исходного изображения.</param>
		/// <param name="srcWidth">Ширина отображаемой части исходного изображения.</param>
		/// <param name="srcHeight">Высота отображаемой части исходного изображения.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицы измерения, используемые для определения исходного прямоугольника.</param>
		/// <param name="imageAttr">Атрибуты <see cref="T:System.Drawing.Imaging.ImageAttributes" />, содержащие сведения о гамме и перекрашивании для объекта <paramref name="image" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004EE RID: 1262 RVA: 0x0000DA54 File Offset: 0x0000BC54
		public void DrawImage(Image image, Rectangle destRect, int srcX, int srcY, int srcWidth, int srcHeight, GraphicsUnit srcUnit, ImageAttributes imageAttr)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImageRectRectI(this.nativeObject, image.NativeObject, destRect.X, destRect.Y, destRect.Width, destRect.Height, srcX, srcY, srcWidth, srcHeight, srcUnit, (imageAttr != null) ? imageAttr.nativeImageAttributes : IntPtr.Zero, null, IntPtr.Zero));
		}

		/// <summary>Рисует заданную часть указанного объекта <see cref="T:System.Drawing.Image" /> в заданном месте, используя заданный размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="destRect">Структура <see cref="T:System.Drawing.Rectangle" />, которая задает расположение и размер формируемого изображения. Изображение масштабируется по размерам прямоугольника.</param>
		/// <param name="srcX">Координата X верхнего левого угла отображаемой части исходного изображения.</param>
		/// <param name="srcY">Координата Y верхнего левого угла отображаемой части исходного изображения.</param>
		/// <param name="srcWidth">Ширина отображаемой части исходного изображения.</param>
		/// <param name="srcHeight">Высота отображаемой части исходного изображения.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицы измерения, используемые для определения исходного прямоугольника.</param>
		/// <param name="imageAttr">Атрибуты <see cref="T:System.Drawing.Imaging.ImageAttributes" />, содержащие сведения о гамме и перекрашивании объекта <paramref name="image" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.DrawImageAbort" />, который задает метод, вызываемый в процессе создания изображения. Этот метод часто вызывается, чтобы проверить, следует ли остановить выполнение метода <see cref="M:System.Drawing.Graphics.DrawImage(System.Drawing.Image,System.Drawing.Rectangle,System.Int32,System.Int32,System.Int32,System.Int32,System.Drawing.GraphicsUnit,System.Drawing.Imaging.ImageAttributes,System.Drawing.Graphics.DrawImageAbort)" /> в соответствии с условиями, определяемыми приложением.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004EF RID: 1263 RVA: 0x0000DAC4 File Offset: 0x0000BCC4
		public void DrawImage(Image image, Rectangle destRect, int srcX, int srcY, int srcWidth, int srcHeight, GraphicsUnit srcUnit, ImageAttributes imageAttr, Graphics.DrawImageAbort callback)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImageRectRectI(this.nativeObject, image.NativeObject, destRect.X, destRect.Y, destRect.Width, destRect.Height, srcX, srcY, srcWidth, srcHeight, srcUnit, (imageAttr != null) ? imageAttr.nativeImageAttributes : IntPtr.Zero, callback, IntPtr.Zero));
		}

		/// <summary>Рисует заданную часть указанного объекта <see cref="T:System.Drawing.Image" /> в заданном месте, используя заданный размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="destRect">Структура <see cref="T:System.Drawing.Rectangle" />, которая задает расположение и размер формируемого изображения. Изображение масштабируется по размерам прямоугольника.</param>
		/// <param name="srcX">Координата X верхнего левого угла отображаемой части исходного изображения.</param>
		/// <param name="srcY">Координата Y верхнего левого угла отображаемой части исходного изображения.</param>
		/// <param name="srcWidth">Ширина отображаемой части исходного изображения.</param>
		/// <param name="srcHeight">Высота отображаемой части исходного изображения.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицы измерения, используемые для определения исходного прямоугольника.</param>
		/// <param name="imageAttrs">Атрибуты <see cref="T:System.Drawing.Imaging.ImageAttributes" />, содержащие сведения о гамме и перекрашивании для объекта <paramref name="image" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.DrawImageAbort" />, который задает метод, вызываемый в процессе создания изображения. Этот метод часто вызывается, чтобы проверить, следует ли остановить выполнение метода <see cref="M:System.Drawing.Graphics.DrawImage(System.Drawing.Image,System.Drawing.Rectangle,System.Single,System.Single,System.Single,System.Single,System.Drawing.GraphicsUnit,System.Drawing.Imaging.ImageAttributes,System.Drawing.Graphics.DrawImageAbort)" /> в соответствии с условиями, определяемыми приложением.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004F0 RID: 1264 RVA: 0x0000DB34 File Offset: 0x0000BD34
		public void DrawImage(Image image, Rectangle destRect, float srcX, float srcY, float srcWidth, float srcHeight, GraphicsUnit srcUnit, ImageAttributes imageAttrs, Graphics.DrawImageAbort callback)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImageRectRect(this.nativeObject, image.NativeObject, (float)destRect.X, (float)destRect.Y, (float)destRect.Width, (float)destRect.Height, srcX, srcY, srcWidth, srcHeight, srcUnit, (imageAttrs != null) ? imageAttrs.nativeImageAttributes : IntPtr.Zero, callback, IntPtr.Zero));
		}

		/// <summary>Рисует заданную часть указанного объекта <see cref="T:System.Drawing.Image" /> в заданном месте, используя заданный размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="destRect">Структура <see cref="T:System.Drawing.Rectangle" />, которая задает расположение и размер формируемого изображения. Изображение масштабируется по размерам прямоугольника.</param>
		/// <param name="srcX">Координата X верхнего левого угла отображаемой части исходного изображения.</param>
		/// <param name="srcY">Координата Y верхнего левого угла отображаемой части исходного изображения.</param>
		/// <param name="srcWidth">Ширина отображаемой части исходного изображения.</param>
		/// <param name="srcHeight">Высота отображаемой части исходного изображения.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицы измерения, используемые для определения исходного прямоугольника.</param>
		/// <param name="imageAttrs">Атрибуты <see cref="T:System.Drawing.Imaging.ImageAttributes" />, содержащие сведения о гамме и перекрашивании для объекта <paramref name="image" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.DrawImageAbort" />, который задает метод, вызываемый в процессе создания изображения. Этот метод часто вызывается, чтобы проверить, следует ли остановить выполнение метода <see cref="M:System.Drawing.Graphics.DrawImage(System.Drawing.Image,System.Drawing.Rectangle,System.Single,System.Single,System.Single,System.Single,System.Drawing.GraphicsUnit,System.Drawing.Imaging.ImageAttributes,System.Drawing.Graphics.DrawImageAbort,System.IntPtr)" /> в соответствии с условиями, определяемыми приложением.</param>
		/// <param name="callbackData">Значение, содержащее дополнительные данные для делегата <see cref="T:System.Drawing.Graphics.DrawImageAbort" />, которые используются при проверке необходимости остановки выполнения метода <see langword="DrawImage" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004F1 RID: 1265 RVA: 0x0000DBA8 File Offset: 0x0000BDA8
		public void DrawImage(Image image, Rectangle destRect, float srcX, float srcY, float srcWidth, float srcHeight, GraphicsUnit srcUnit, ImageAttributes imageAttrs, Graphics.DrawImageAbort callback, IntPtr callbackData)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImageRectRect(this.nativeObject, image.NativeObject, (float)destRect.X, (float)destRect.Y, (float)destRect.Width, (float)destRect.Height, srcX, srcY, srcWidth, srcHeight, srcUnit, (imageAttrs != null) ? imageAttrs.nativeImageAttributes : IntPtr.Zero, callback, callbackData));
		}

		/// <summary>Рисует заданную часть указанного объекта <see cref="T:System.Drawing.Image" /> в заданном месте, используя заданный размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="destRect">Структура <see cref="T:System.Drawing.Rectangle" />, которая задает расположение и размер формируемого изображения. Изображение масштабируется по размерам прямоугольника.</param>
		/// <param name="srcX">Координата X верхнего левого угла отображаемой части исходного изображения.</param>
		/// <param name="srcY">Координата Y верхнего левого угла отображаемой части исходного изображения.</param>
		/// <param name="srcWidth">Ширина отображаемой части исходного изображения.</param>
		/// <param name="srcHeight">Высота отображаемой части исходного изображения.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицы измерения, используемые для определения исходного прямоугольника.</param>
		/// <param name="imageAttrs">Атрибуты <see cref="T:System.Drawing.Imaging.ImageAttributes" />, содержащие сведения о гамме и перекрашивании для объекта <paramref name="image" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.DrawImageAbort" />, который задает метод, вызываемый в процессе создания изображения. Этот метод часто вызывается, чтобы проверить, следует ли остановить выполнение метода <see cref="M:System.Drawing.Graphics.DrawImage(System.Drawing.Image,System.Drawing.Rectangle,System.Int32,System.Int32,System.Int32,System.Int32,System.Drawing.GraphicsUnit,System.Drawing.Imaging.ImageAttributes,System.Drawing.Graphics.DrawImageAbort,System.IntPtr)" /> в соответствии с условиями, определяемыми приложением.</param>
		/// <param name="callbackData">Значение, содержащее дополнительные данные для делегата <see cref="T:System.Drawing.Graphics.DrawImageAbort" />, которые используются при проверке необходимости остановки выполнения метода <see langword="DrawImage" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004F2 RID: 1266 RVA: 0x0000DC18 File Offset: 0x0000BE18
		public void DrawImage(Image image, Rectangle destRect, int srcX, int srcY, int srcWidth, int srcHeight, GraphicsUnit srcUnit, ImageAttributes imageAttrs, Graphics.DrawImageAbort callback, IntPtr callbackData)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawImageRectRect(this.nativeObject, image.NativeObject, (float)destRect.X, (float)destRect.Y, (float)destRect.Width, (float)destRect.Height, (float)srcX, (float)srcY, (float)srcWidth, (float)srcHeight, srcUnit, (imageAttrs != null) ? imageAttrs.nativeImageAttributes : IntPtr.Zero, callback, callbackData));
		}

		/// <summary>Рисует заданное изображение в заданном месте, используя его исходный фактический размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="point">Структура <see cref="T:System.Drawing.Point" />, задающая верхний левый угол создаваемого рисунка.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004F3 RID: 1267 RVA: 0x0000DC8C File Offset: 0x0000BE8C
		public void DrawImageUnscaled(Image image, Point point)
		{
			this.DrawImageUnscaled(image, point.X, point.Y);
		}

		/// <summary>Рисует заданное изображение в заданном месте, используя его исходный фактический размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="rect">Структура <see cref="T:System.Drawing.Rectangle" />, задающая верхний левый угол создаваемого рисунка. Свойства X и Y прямоугольника определяют верхний левый угол. Свойства ширины и высоты не обрабатываются.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004F4 RID: 1268 RVA: 0x0000DCA3 File Offset: 0x0000BEA3
		public void DrawImageUnscaled(Image image, Rectangle rect)
		{
			this.DrawImageUnscaled(image, rect.X, rect.Y, rect.Width, rect.Height);
		}

		/// <summary>Рисует заданное изображение, используя его исходный фактический размер, в месте, указанном парой координат.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="x">Координата X верхнего левого угла формируемого изображения.</param>
		/// <param name="y">Координата Y верхнего левого угла формируемого изображения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004F5 RID: 1269 RVA: 0x0000DCC8 File Offset: 0x0000BEC8
		public void DrawImageUnscaled(Image image, int x, int y)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			this.DrawImage(image, x, y, image.Width, image.Height);
		}

		/// <summary>Рисует заданное изображение в заданном месте, используя его исходный фактический размер.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" /> для рисования.</param>
		/// <param name="x">Координата X верхнего левого угла формируемого изображения.</param>
		/// <param name="y">Координата Y верхнего левого угла формируемого изображения.</param>
		/// <param name="width">Не используется.</param>
		/// <param name="height">Не используется.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004F6 RID: 1270 RVA: 0x0000DCF0 File Offset: 0x0000BEF0
		public void DrawImageUnscaled(Image image, int x, int y, int width, int height)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			if (width <= 0 || height <= 0)
			{
				return;
			}
			using (Image image2 = new Bitmap(width, height))
			{
				using (Graphics graphics = Graphics.FromImage(image2))
				{
					graphics.DrawImage(image, 0, 0, image.Width, image.Height);
					this.DrawImage(image2, x, y, width, height);
				}
			}
		}

		/// <summary>Рисует заданное изображение без масштабирования и при необходимости обрезает его, чтобы оно вмещалось в указываемом прямоугольнике.</summary>
		/// <param name="image">Изображение <see cref="T:System.Drawing.Image" /> для отрисовки.</param>
		/// <param name="rect">Прямоугольник <see cref="T:System.Drawing.Rectangle" />, в котором должно быть нарисовано изображение.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004F7 RID: 1271 RVA: 0x0000DD7C File Offset: 0x0000BF7C
		public void DrawImageUnscaledAndClipped(Image image, Rectangle rect)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			int width = (image.Width > rect.Width) ? rect.Width : image.Width;
			int height = (image.Height > rect.Height) ? rect.Height : image.Height;
			this.DrawImageUnscaled(image, rect.X, rect.Y, width, height);
		}

		/// <summary>Проводит линию, соединяющую две структуры <see cref="T:System.Drawing.PointF" />.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и стиль линии.</param>
		/// <param name="pt1">Структура <see cref="T:System.Drawing.PointF" />, представляющая первую точку для соединения.</param>
		/// <param name="pt2">Структура <see cref="T:System.Drawing.PointF" />, представляющая вторую точка для соединения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004F8 RID: 1272 RVA: 0x0000DDEC File Offset: 0x0000BFEC
		public void DrawLine(Pen pen, PointF pt1, PointF pt2)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawLine(this.nativeObject, pen.NativePen, pt1.X, pt1.Y, pt2.X, pt2.Y));
		}

		/// <summary>Проводит линию, соединяющую две структуры <see cref="T:System.Drawing.Point" />.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и стиль линии.</param>
		/// <param name="pt1">Структура <see cref="T:System.Drawing.Point" />, представляющая первую точку для соединения.</param>
		/// <param name="pt2">Структура <see cref="T:System.Drawing.Point" />, представляющая вторую точка для соединения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004F9 RID: 1273 RVA: 0x0000DE3C File Offset: 0x0000C03C
		public void DrawLine(Pen pen, Point pt1, Point pt2)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawLineI(this.nativeObject, pen.NativePen, pt1.X, pt1.Y, pt2.X, pt2.Y));
		}

		/// <summary>Проводит линию, соединяющую две точки, задаваемые парами координат.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и стиль линии.</param>
		/// <param name="x1">Координата X первой точки.</param>
		/// <param name="y1">Координата Y первой точки.</param>
		/// <param name="x2">Координата X второй точки.</param>
		/// <param name="y2">Координата Y второй точки.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004FA RID: 1274 RVA: 0x0000DE89 File Offset: 0x0000C089
		public void DrawLine(Pen pen, int x1, int y1, int x2, int y2)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawLineI(this.nativeObject, pen.NativePen, x1, y1, x2, y2));
		}

		/// <summary>Проводит линию, соединяющую две точки, задаваемые парами координат.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и стиль линии.</param>
		/// <param name="x1">Координата X первой точки.</param>
		/// <param name="y1">Координата Y первой точки.</param>
		/// <param name="x2">Координата X второй точки.</param>
		/// <param name="y2">Координата Y второй точки.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004FB RID: 1275 RVA: 0x0000DEB8 File Offset: 0x0000C0B8
		public void DrawLine(Pen pen, float x1, float y1, float x2, float y2)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			if (!float.IsNaN(x1) && !float.IsNaN(y1) && !float.IsNaN(x2) && !float.IsNaN(y2))
			{
				GDIPlus.CheckStatus(GDIPlus.GdipDrawLine(this.nativeObject, pen.NativePen, x1, y1, x2, y2));
			}
		}

		/// <summary>Рисует ряд сегментов линий, которые соединяют массив структур <see cref="T:System.Drawing.PointF" />.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и стиль сегментов линии.</param>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.PointF" />, представляющий точки для соединения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="points" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004FC RID: 1276 RVA: 0x0000DF11 File Offset: 0x0000C111
		public void DrawLines(Pen pen, PointF[] points)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawLines(this.nativeObject, pen.NativePen, points, points.Length));
		}

		/// <summary>Рисует ряд сегментов линий, которые соединяют массив структур <see cref="T:System.Drawing.Point" />.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и стиль сегментов линии.</param>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.Point" />, представляющий точки для соединения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="points" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004FD RID: 1277 RVA: 0x0000DF49 File Offset: 0x0000C149
		public void DrawLines(Pen pen, Point[] points)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawLinesI(this.nativeObject, pen.NativePen, points, points.Length));
		}

		/// <summary>Рисует объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и стиль контура.</param>
		/// <param name="path">Объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> для рисования.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004FE RID: 1278 RVA: 0x0000DF81 File Offset: 0x0000C181
		public void DrawPath(Pen pen, GraphicsPath path)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawPath(this.nativeObject, pen.NativePen, path.nativePath));
		}

		/// <summary>Рисует сектор, который определяется эллипсом, заданным структурой <see cref="T:System.Drawing.Rectangle" /> и двумя радиальными линиями.</summary>
		/// <param name="pen">Объект <see cref="T:System.Drawing.Pen" />, определяющий цвет, ширину и стиль сектора.</param>
		/// <param name="rect">Структура <see cref="T:System.Drawing.Rectangle" />, представляющая ограничивающий прямоугольник, определяющий эллипс, частью которого является данный сектор.</param>
		/// <param name="startAngle">Угол (в градусах), который измеряется по часовой стрелке, начиная от оси X и заканчивая первой стороной сектора.</param>
		/// <param name="sweepAngle">Угол (в градусах), который измеряется по часовой стрелке, начиная от значения параметра <paramref name="startAngle" /> и заканчивая второй стороной сектора.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060004FF RID: 1279 RVA: 0x0000DFBB File Offset: 0x0000C1BB
		public void DrawPie(Pen pen, Rectangle rect, float startAngle, float sweepAngle)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			this.DrawPie(pen, (float)rect.X, (float)rect.Y, (float)rect.Width, (float)rect.Height, startAngle, sweepAngle);
		}

		/// <summary>Рисует сектор, который определяется эллипсом, заданным структурой <see cref="T:System.Drawing.RectangleF" /> и двумя радиальными линиями.</summary>
		/// <param name="pen">Объект <see cref="T:System.Drawing.Pen" />, определяющий цвет, ширину и стиль сектора.</param>
		/// <param name="rect">Структура <see cref="T:System.Drawing.RectangleF" />, представляющая ограничивающий прямоугольник, определяющий эллипс, частью которого является данный сектор.</param>
		/// <param name="startAngle">Угол (в градусах), который измеряется по часовой стрелке, начиная от оси X и заканчивая первой стороной сектора.</param>
		/// <param name="sweepAngle">Угол (в градусах), который измеряется по часовой стрелке, начиная от значения параметра <paramref name="startAngle" /> и заканчивая второй стороной сектора.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000500 RID: 1280 RVA: 0x0000DFF5 File Offset: 0x0000C1F5
		public void DrawPie(Pen pen, RectangleF rect, float startAngle, float sweepAngle)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			this.DrawPie(pen, rect.X, rect.Y, rect.Width, rect.Height, startAngle, sweepAngle);
		}

		/// <summary>Рисует сектор, определяемый эллипсом, который задан парой координат, шириной, высотой и двумя радиальными линиями.</summary>
		/// <param name="pen">Объект <see cref="T:System.Drawing.Pen" />, определяющий цвет, ширину и стиль сектора.</param>
		/// <param name="x">Координата X верхнего левого угла ограничивающего прямоугольника, определяющего эллипс, частью которого является сектор.</param>
		/// <param name="y">Координата Y верхнего левого угла ограничивающего прямоугольника, определяющего эллипс, частью которого является сектор.</param>
		/// <param name="width">Ширина ограничивающего прямоугольника, определяющего эллипс, частью которого является данный сектор.</param>
		/// <param name="height">Высота ограничивающего прямоугольника, определяющего эллипс, частью которого является данный сектор.</param>
		/// <param name="startAngle">Угол (в градусах), который измеряется по часовой стрелке, начиная от оси X и заканчивая первой стороной сектора.</param>
		/// <param name="sweepAngle">Угол (в градусах), который измеряется по часовой стрелке, начиная от значения параметра <paramref name="startAngle" /> и заканчивая второй стороной сектора.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000501 RID: 1281 RVA: 0x0000E02B File Offset: 0x0000C22B
		public void DrawPie(Pen pen, float x, float y, float width, float height, float startAngle, float sweepAngle)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawPie(this.nativeObject, pen.NativePen, x, y, width, height, startAngle, sweepAngle));
		}

		/// <summary>Рисует сектор, определяемый эллипсом, который задан парой координат, шириной, высотой и двумя радиальными линиями.</summary>
		/// <param name="pen">Объект <see cref="T:System.Drawing.Pen" />, определяющий цвет, ширину и стиль сектора.</param>
		/// <param name="x">Координата X верхнего левого угла ограничивающего прямоугольника, определяющего эллипс, частью которого является сектор.</param>
		/// <param name="y">Координата Y верхнего левого угла ограничивающего прямоугольника, определяющего эллипс, частью которого является сектор.</param>
		/// <param name="width">Ширина ограничивающего прямоугольника, определяющего эллипс, частью которого является данный сектор.</param>
		/// <param name="height">Высота ограничивающего прямоугольника, определяющего эллипс, частью которого является данный сектор.</param>
		/// <param name="startAngle">Угол (в градусах), который измеряется по часовой стрелке, начиная от оси X и заканчивая первой стороной сектора.</param>
		/// <param name="sweepAngle">Угол (в градусах), который измеряется по часовой стрелке, начиная от значения параметра <paramref name="startAngle" /> и заканчивая второй стороной сектора.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000502 RID: 1282 RVA: 0x0000E05B File Offset: 0x0000C25B
		public void DrawPie(Pen pen, int x, int y, int width, int height, int startAngle, int sweepAngle)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawPieI(this.nativeObject, pen.NativePen, x, y, width, height, (float)startAngle, (float)sweepAngle));
		}

		/// <summary>Рисует многоугольник, определяемый массивом структур <see cref="T:System.Drawing.Point" />.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и стиль многоугольника.</param>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.Point" />, которые представляют вершины многоугольника.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000503 RID: 1283 RVA: 0x0000E08D File Offset: 0x0000C28D
		public void DrawPolygon(Pen pen, Point[] points)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawPolygonI(this.nativeObject, pen.NativePen, points, points.Length));
		}

		/// <summary>Рисует многоугольник, определяемый массивом структур <see cref="T:System.Drawing.PointF" />.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и стиль многоугольника.</param>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.PointF" />, которые представляют вершины многоугольника.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="points" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000504 RID: 1284 RVA: 0x0000E0C5 File Offset: 0x0000C2C5
		public void DrawPolygon(Pen pen, PointF[] points)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawPolygon(this.nativeObject, pen.NativePen, points, points.Length));
		}

		/// <summary>Рисует прямоугольник, определяемый структурой <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и стиль прямоугольника.</param>
		/// <param name="rect">Структура <see cref="T:System.Drawing.Rectangle" />, представляющая прямоугольник для рисования.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000505 RID: 1285 RVA: 0x0000E0FD File Offset: 0x0000C2FD
		public void DrawRectangle(Pen pen, Rectangle rect)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			this.DrawRectangle(pen, rect.Left, rect.Top, rect.Width, rect.Height);
		}

		/// <summary>Рисует прямоугольник, определяемый парой координат, шириной и высотой.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и стиль прямоугольника.</param>
		/// <param name="x">Координата X верхнего левого угла прямоугольника для рисования.</param>
		/// <param name="y">Координата Y верхнего левого угла прямоугольника для рисования.</param>
		/// <param name="width">Ширина прямоугольника для рисования.</param>
		/// <param name="height">Высота прямоугольника для рисования.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000506 RID: 1286 RVA: 0x0000E130 File Offset: 0x0000C330
		public void DrawRectangle(Pen pen, float x, float y, float width, float height)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawRectangle(this.nativeObject, pen.NativePen, x, y, width, height));
		}

		/// <summary>Рисует прямоугольник, определяемый парой координат, шириной и высотой.</summary>
		/// <param name="pen">Структура <see cref="T:System.Drawing.Pen" />, определяющая цвет, ширину и стиль прямоугольника.</param>
		/// <param name="x">Координата X верхнего левого угла прямоугольника для рисования.</param>
		/// <param name="y">Координата Y верхнего левого угла прямоугольника для рисования.</param>
		/// <param name="width">Ширина прямоугольника для рисования.</param>
		/// <param name="height">Высота прямоугольника для рисования.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000507 RID: 1287 RVA: 0x0000E15C File Offset: 0x0000C35C
		public void DrawRectangle(Pen pen, int x, int y, int width, int height)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawRectangleI(this.nativeObject, pen.NativePen, x, y, width, height));
		}

		/// <summary>Рисует набор прямоугольников, определяемых структурами <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <param name="pen">Объект <see cref="T:System.Drawing.Pen" />, определяющий цвет, ширину и стиль контуров прямоугольников.</param>
		/// <param name="rects">Массив структур <see cref="T:System.Drawing.RectangleF" />, которые представляют прямоугольники для рисования.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="rects" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="rects" /> представляет собой массив нулевой длины.</exception>
		// Token: 0x06000508 RID: 1288 RVA: 0x0000E188 File Offset: 0x0000C388
		public void DrawRectangles(Pen pen, RectangleF[] rects)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("image");
			}
			if (rects == null)
			{
				throw new ArgumentNullException("rects");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawRectangles(this.nativeObject, pen.NativePen, rects, rects.Length));
		}

		/// <summary>Рисует набор прямоугольников, определяемых структурами <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <param name="pen">Объект <see cref="T:System.Drawing.Pen" />, определяющий цвет, ширину и стиль контуров прямоугольников.</param>
		/// <param name="rects">Массив структур <see cref="T:System.Drawing.Rectangle" />, которые представляют прямоугольники для рисования.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pen" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="rects" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="rects" /> представляет собой массив нулевой длины.</exception>
		// Token: 0x06000509 RID: 1289 RVA: 0x0000E1C0 File Offset: 0x0000C3C0
		public void DrawRectangles(Pen pen, Rectangle[] rects)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("image");
			}
			if (rects == null)
			{
				throw new ArgumentNullException("rects");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawRectanglesI(this.nativeObject, pen.NativePen, rects, rects.Length));
		}

		/// <summary>Создает заданную текстовую строку в указанном прямоугольнике с помощью заданных объектов <see cref="T:System.Drawing.Brush" /> и <see cref="T:System.Drawing.Font" />.</summary>
		/// <param name="s">Строка для рисования.</param>
		/// <param name="font">Объект <see cref="T:System.Drawing.Font" />, определяющий формат текста строки.</param>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий цвет и текстуру создаваемого текста.</param>
		/// <param name="layoutRectangle">Структура <see cref="T:System.Drawing.RectangleF" />, которая задает расположение создаваемого текста.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600050A RID: 1290 RVA: 0x0000E1F8 File Offset: 0x0000C3F8
		public void DrawString(string s, Font font, Brush brush, RectangleF layoutRectangle)
		{
			this.DrawString(s, font, brush, layoutRectangle, null);
		}

		/// <summary>Создает заданную текстовую строку в указанном месте с помощью заданных объектов <see cref="T:System.Drawing.Brush" /> и <see cref="T:System.Drawing.Font" />.</summary>
		/// <param name="s">Строка для рисования.</param>
		/// <param name="font">Объект <see cref="T:System.Drawing.Font" />, определяющий формат текста строки.</param>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий цвет и текстуру создаваемого текста.</param>
		/// <param name="point">Структура <see cref="T:System.Drawing.PointF" />, задающая верхний левый угол создаваемого текста.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600050B RID: 1291 RVA: 0x0000E206 File Offset: 0x0000C406
		public void DrawString(string s, Font font, Brush brush, PointF point)
		{
			this.DrawString(s, font, brush, new RectangleF(point.X, point.Y, 0f, 0f), null);
		}

		/// <summary>Создает заданную текстовую строку в указанном месте с помощью заданных объектов <see cref="T:System.Drawing.Brush" /> и <see cref="T:System.Drawing.Font" />, используя атрибуты форматирования заданного формата <see cref="T:System.Drawing.StringFormat" />.</summary>
		/// <param name="s">Строка для рисования.</param>
		/// <param name="font">Объект <see cref="T:System.Drawing.Font" />, определяющий формат текста строки.</param>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий цвет и текстуру создаваемого текста.</param>
		/// <param name="point">Структура <see cref="T:System.Drawing.PointF" />, задающая верхний левый угол создаваемого текста.</param>
		/// <param name="format">Объект <see cref="T:System.Drawing.StringFormat" />, определяющий атрибуты форматирования, такие как межстрочный интервал и выравнивание, которые применяются к создаваемому тексту.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600050C RID: 1292 RVA: 0x0000E22F File Offset: 0x0000C42F
		public void DrawString(string s, Font font, Brush brush, PointF point, StringFormat format)
		{
			this.DrawString(s, font, brush, new RectangleF(point.X, point.Y, 0f, 0f), format);
		}

		/// <summary>Создает заданную текстовую строку в указанном месте с помощью заданных объектов <see cref="T:System.Drawing.Brush" /> и <see cref="T:System.Drawing.Font" />.</summary>
		/// <param name="s">Строка для рисования.</param>
		/// <param name="font">Объект <see cref="T:System.Drawing.Font" />, определяющий формат текста строки.</param>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий цвет и текстуру создаваемого текста.</param>
		/// <param name="x">Координата X верхнего левого угла отображаемого текста.</param>
		/// <param name="y">Координата Y верхнего левого угла отображаемого текста.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600050D RID: 1293 RVA: 0x0000E259 File Offset: 0x0000C459
		public void DrawString(string s, Font font, Brush brush, float x, float y)
		{
			this.DrawString(s, font, brush, new RectangleF(x, y, 0f, 0f), null);
		}

		/// <summary>Создает заданную текстовую строку в указанном месте с помощью заданных объектов <see cref="T:System.Drawing.Brush" /> и <see cref="T:System.Drawing.Font" />, используя атрибуты форматирования заданного формата <see cref="T:System.Drawing.StringFormat" />.</summary>
		/// <param name="s">Строка для рисования.</param>
		/// <param name="font">Объект <see cref="T:System.Drawing.Font" />, определяющий формат текста строки.</param>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий цвет и текстуру создаваемого текста.</param>
		/// <param name="x">Координата X верхнего левого угла отображаемого текста.</param>
		/// <param name="y">Координата Y верхнего левого угла отображаемого текста.</param>
		/// <param name="format">Объект <see cref="T:System.Drawing.StringFormat" />, определяющий атрибуты форматирования, такие как межстрочный интервал и выравнивание, которые применяются к создаваемому тексту.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600050E RID: 1294 RVA: 0x0000E278 File Offset: 0x0000C478
		public void DrawString(string s, Font font, Brush brush, float x, float y, StringFormat format)
		{
			this.DrawString(s, font, brush, new RectangleF(x, y, 0f, 0f), format);
		}

		/// <summary>Создает заданную текстовую строку в указанном прямоугольнике с помощью заданных объектов <see cref="T:System.Drawing.Brush" /> и <see cref="T:System.Drawing.Font" />, используя атрибуты форматирования заданного формата <see cref="T:System.Drawing.StringFormat" />.</summary>
		/// <param name="s">Строка для рисования.</param>
		/// <param name="font">Объект <see cref="T:System.Drawing.Font" />, определяющий формат текста строки.</param>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий цвет и текстуру создаваемого текста.</param>
		/// <param name="layoutRectangle">Структура <see cref="T:System.Drawing.RectangleF" />, которая задает расположение создаваемого текста.</param>
		/// <param name="format">Объект <see cref="T:System.Drawing.StringFormat" />, определяющий атрибуты форматирования, такие как межстрочный интервал и выравнивание, которые применяются к создаваемому тексту.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600050F RID: 1295 RVA: 0x0000E298 File Offset: 0x0000C498
		public void DrawString(string s, Font font, Brush brush, RectangleF layoutRectangle, StringFormat format)
		{
			if (font == null)
			{
				throw new ArgumentNullException("font");
			}
			if (brush == null)
			{
				throw new ArgumentNullException("brush");
			}
			if (s == null || s.Length == 0)
			{
				return;
			}
			GDIPlus.CheckStatus(GDIPlus.GdipDrawString(this.nativeObject, s, s.Length, font.NativeObject, ref layoutRectangle, (format != null) ? format.NativeObject : IntPtr.Zero, brush.NativeBrush));
		}

		/// <summary>Закрывает текущий графический контейнер и восстанавливает состояние данного объекта <see cref="T:System.Drawing.Graphics" />, которое было сохранено при вызове метода <see cref="M:System.Drawing.Graphics.BeginContainer" />.</summary>
		/// <param name="container">Объект <see cref="T:System.Drawing.Drawing2D.GraphicsContainer" />, представляющий контейнер, восстанавливаемый этим методом.</param>
		// Token: 0x06000510 RID: 1296 RVA: 0x0000E304 File Offset: 0x0000C504
		public void EndContainer(GraphicsContainer container)
		{
			if (container == null)
			{
				throw new ArgumentNullException("container");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipEndContainer(this.nativeObject, container.NativeObject));
		}

		/// <summary>Отправляет записи указанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова для их отображения в заданном параллелограмме.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destPoints">Массив из трех структур <see cref="T:System.Drawing.Point" />, определяющих параллелограмм, который задает размер и расположение отображаемого метафайла.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		// Token: 0x06000511 RID: 1297 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, Point[] destPoints, Graphics.EnumerateMetafileProc callback)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи указанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова для их отображения в заданном прямоугольнике.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destRect">Структура <see cref="T:System.Drawing.RectangleF" />, которая задает расположение и размер отображаемого метафайла.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		// Token: 0x06000512 RID: 1298 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, RectangleF destRect, Graphics.EnumerateMetafileProc callback)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи указанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова для их отображения в заданном параллелограмме.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destPoints">Массив из трех структур <see cref="T:System.Drawing.PointF" />, определяющих параллелограмм, который задает размер и расположение отображаемого метафайла.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		// Token: 0x06000513 RID: 1299 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, PointF[] destPoints, Graphics.EnumerateMetafileProc callback)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи указанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова для их отображения в заданном прямоугольнике.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destRect">Структура <see cref="T:System.Drawing.Rectangle" />, которая задает расположение и размер отображаемого метафайла.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		// Token: 0x06000514 RID: 1300 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, Rectangle destRect, Graphics.EnumerateMetafileProc callback)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи указанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданной точке.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destPoint">Структура <see cref="T:System.Drawing.Point" />, задающая положение верхнего левого угла отображаемого метафайла.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		// Token: 0x06000515 RID: 1301 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, Point destPoint, Graphics.EnumerateMetafileProc callback)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи указанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданной точке.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destPoint">Структура <see cref="T:System.Drawing.PointF" />, задающая положение верхнего левого угла отображаемого метафайла.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		// Token: 0x06000516 RID: 1302 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, PointF destPoint, Graphics.EnumerateMetafileProc callback)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи указанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданной точке.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destPoint">Структура <see cref="T:System.Drawing.PointF" />, задающая положение верхнего левого угла отображаемого метафайла.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		/// <param name="callbackData">Внутренний указатель, который является обязательным, однако не обрабатывается. Для этого параметра можно передать объект <see cref="F:System.IntPtr.Zero" />.</param>
		// Token: 0x06000517 RID: 1303 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, PointF destPoint, Graphics.EnumerateMetafileProc callback, IntPtr callbackData)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи указанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова для их отображения в заданном прямоугольнике.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destRect">Структура <see cref="T:System.Drawing.Rectangle" />, которая задает расположение и размер отображаемого метафайла.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		/// <param name="callbackData">Внутренний указатель, который является обязательным, однако не обрабатывается. Для этого параметра можно передать объект <see cref="F:System.IntPtr.Zero" />.</param>
		// Token: 0x06000518 RID: 1304 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, Rectangle destRect, Graphics.EnumerateMetafileProc callback, IntPtr callbackData)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи указанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова для их отображения в заданном параллелограмме.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destPoints">Массив из трех структур <see cref="T:System.Drawing.PointF" />, определяющих параллелограмм, который задает размер и расположение отображаемого метафайла.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		/// <param name="callbackData">Внутренний указатель, который является обязательным, однако не обрабатывается. Для этого параметра можно передать объект <see cref="F:System.IntPtr.Zero" />.</param>
		// Token: 0x06000519 RID: 1305 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, PointF[] destPoints, Graphics.EnumerateMetafileProc callback, IntPtr callbackData)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи указанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданной точке.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destPoint">Структура <see cref="T:System.Drawing.Point" />, задающая положение верхнего левого угла отображаемого метафайла.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		/// <param name="callbackData">Внутренний указатель, который является обязательным, однако не обрабатывается. Для этого параметра можно передать объект <see cref="F:System.IntPtr.Zero" />.</param>
		// Token: 0x0600051A RID: 1306 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, Point destPoint, Graphics.EnumerateMetafileProc callback, IntPtr callbackData)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи указанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова для их отображения в заданном параллелограмме.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destPoints">Массив из трех структур <see cref="T:System.Drawing.Point" />, определяющих параллелограмм, который задает размер и расположение отображаемого метафайла.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		/// <param name="callbackData">Внутренний указатель, который является обязательным, однако не обрабатывается. Для этого параметра можно передать объект <see cref="F:System.IntPtr.Zero" />.</param>
		// Token: 0x0600051B RID: 1307 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, Point[] destPoints, Graphics.EnumerateMetafileProc callback, IntPtr callbackData)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи указанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова для их отображения в заданном прямоугольнике.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destRect">Структура <see cref="T:System.Drawing.RectangleF" />, которая задает расположение и размер отображаемого метафайла.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		/// <param name="callbackData">Внутренний указатель, который является обязательным, однако не обрабатывается. Для этого параметра можно передать объект <see cref="F:System.IntPtr.Zero" />.</param>
		// Token: 0x0600051C RID: 1308 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, RectangleF destRect, Graphics.EnumerateMetafileProc callback, IntPtr callbackData)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи в выбранном прямоугольнике из объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданной точке.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destPoint">Структура <see cref="T:System.Drawing.PointF" />, задающая положение верхнего левого угла отображаемого метафайла.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.RectangleF" />, задающая часть метафайла, предназначенную для рисования, относительно его верхнего левого угла.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицу измерения, которая должна использоваться для определения части метафайла, содержащейся в прямоугольнике, указываемом параметром <paramref name="srcRect" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		// Token: 0x0600051D RID: 1309 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, PointF destPoint, RectangleF srcRect, GraphicsUnit srcUnit, Graphics.EnumerateMetafileProc callback)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи в выбранном прямоугольнике из объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданной точке.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destPoint">Структура <see cref="T:System.Drawing.Point" />, задающая положение верхнего левого угла отображаемого метафайла.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.Rectangle" />, задающая часть метафайла, предназначенную для рисования, относительно его верхнего левого угла.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицу измерения, которая должна использоваться для определения части метафайла, содержащейся в прямоугольнике, указываемом параметром <paramref name="srcRect" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		// Token: 0x0600051E RID: 1310 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, Point destPoint, Rectangle srcRect, GraphicsUnit srcUnit, Graphics.EnumerateMetafileProc callback)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи в выбранном прямоугольнике из объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданном параллелограмме.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destPoints">Массив из трех структур <see cref="T:System.Drawing.PointF" />, определяющих параллелограмм, который задает размер и расположение отображаемого метафайла.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.RectangleF" />, задающая часть метафайла, предназначенную для рисования, относительно его верхнего левого угла.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицу измерения, которая должна использоваться для определения части метафайла, содержащейся в прямоугольнике, указываемом параметром <paramref name="srcRect" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		// Token: 0x0600051F RID: 1311 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, PointF[] destPoints, RectangleF srcRect, GraphicsUnit srcUnit, Graphics.EnumerateMetafileProc callback)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи в выбранном прямоугольнике из объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданном параллелограмме.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destPoints">Массив из трех структур <see cref="T:System.Drawing.Point" />, определяющих параллелограмм, который задает размер и расположение отображаемого метафайла.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.Rectangle" />, задающая часть метафайла, предназначенную для рисования, относительно его верхнего левого угла.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицу измерения, которая должна использоваться для определения части метафайла, содержащейся в прямоугольнике, указываемом параметром <paramref name="srcRect" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		// Token: 0x06000520 RID: 1312 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, Point[] destPoints, Rectangle srcRect, GraphicsUnit srcUnit, Graphics.EnumerateMetafileProc callback)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи в выбранном прямоугольнике из объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданном прямоугольнике.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destRect">Структура <see cref="T:System.Drawing.RectangleF" />, которая задает расположение и размер отображаемого метафайла.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.RectangleF" />, задающая часть метафайла, предназначенную для рисования, относительно его верхнего левого угла.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицу измерения, которая должна использоваться для определения части метафайла, содержащейся в прямоугольнике, указываемом параметром <paramref name="srcRect" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		// Token: 0x06000521 RID: 1313 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, RectangleF destRect, RectangleF srcRect, GraphicsUnit srcUnit, Graphics.EnumerateMetafileProc callback)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи в выбранном прямоугольнике из объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданном прямоугольнике.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destRect">Структура <see cref="T:System.Drawing.Rectangle" />, которая задает расположение и размер отображаемого метафайла.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.Rectangle" />, задающая часть метафайла, предназначенную для рисования, относительно его верхнего левого угла.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицу измерения, которая должна использоваться для определения части метафайла, содержащейся в прямоугольнике, указываемом параметром <paramref name="srcRect" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		// Token: 0x06000522 RID: 1314 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, Rectangle destRect, Rectangle srcRect, GraphicsUnit srcUnit, Graphics.EnumerateMetafileProc callback)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи указанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданном прямоугольнике, используя указанные атрибуты изображения.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destRect">Структура <see cref="T:System.Drawing.RectangleF" />, которая задает расположение и размер отображаемого метафайла.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		/// <param name="callbackData">Внутренний указатель, который является обязательным, однако не обрабатывается. Для этого параметра можно передать объект <see cref="F:System.IntPtr.Zero" />.</param>
		/// <param name="imageAttr">Объект <see cref="T:System.Drawing.Imaging.ImageAttributes" />, задающий сведения об атрибутах формируемого изображения.</param>
		// Token: 0x06000523 RID: 1315 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, RectangleF destRect, Graphics.EnumerateMetafileProc callback, IntPtr callbackData, ImageAttributes imageAttr)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи указанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданной точке, используя указанные атрибуты изображения.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destPoint">Структура <see cref="T:System.Drawing.Point" />, задающая положение верхнего левого угла отображаемого метафайла.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		/// <param name="callbackData">Внутренний указатель, который является обязательным, однако не обрабатывается. Для этого параметра можно передать объект <see cref="F:System.IntPtr.Zero" />.</param>
		/// <param name="imageAttr">Объект <see cref="T:System.Drawing.Imaging.ImageAttributes" />, задающий сведения об атрибутах формируемого изображения.</param>
		// Token: 0x06000524 RID: 1316 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, Point destPoint, Graphics.EnumerateMetafileProc callback, IntPtr callbackData, ImageAttributes imageAttr)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи указанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданной точке, используя указанные атрибуты изображения.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destPoint">Структура <see cref="T:System.Drawing.PointF" />, задающая положение верхнего левого угла отображаемого метафайла.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		/// <param name="callbackData">Внутренний указатель, который является обязательным, однако не обрабатывается. Для этого параметра можно передать объект <see cref="F:System.IntPtr.Zero" />.</param>
		/// <param name="imageAttr">Объект <see cref="T:System.Drawing.Imaging.ImageAttributes" />, задающий сведения об атрибутах формируемого изображения.</param>
		// Token: 0x06000525 RID: 1317 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, PointF destPoint, Graphics.EnumerateMetafileProc callback, IntPtr callbackData, ImageAttributes imageAttr)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи указанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданном параллелограмме, используя указанные атрибуты изображения.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destPoints">Массив из трех структур <see cref="T:System.Drawing.Point" />, определяющих параллелограмм, который задает размер и расположение отображаемого метафайла.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		/// <param name="callbackData">Внутренний указатель, который является обязательным, однако не обрабатывается. Для этого параметра можно передать объект <see cref="F:System.IntPtr.Zero" />.</param>
		/// <param name="imageAttr">Объект <see cref="T:System.Drawing.Imaging.ImageAttributes" />, задающий сведения об атрибутах формируемого изображения.</param>
		// Token: 0x06000526 RID: 1318 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, Point[] destPoints, Graphics.EnumerateMetafileProc callback, IntPtr callbackData, ImageAttributes imageAttr)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи указанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданном параллелограмме, используя указанные атрибуты изображения.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destPoints">Массив из трех структур <see cref="T:System.Drawing.PointF" />, определяющих параллелограмм, который задает размер и расположение отображаемого метафайла.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		/// <param name="callbackData">Внутренний указатель, который является обязательным, однако не обрабатывается. Для этого параметра можно передать объект <see cref="F:System.IntPtr.Zero" />.</param>
		/// <param name="imageAttr">Объект <see cref="T:System.Drawing.Imaging.ImageAttributes" />, задающий сведения об атрибутах формируемого изображения.</param>
		// Token: 0x06000527 RID: 1319 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, PointF[] destPoints, Graphics.EnumerateMetafileProc callback, IntPtr callbackData, ImageAttributes imageAttr)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи указанного объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданном прямоугольнике, используя указанные атрибуты изображения.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destRect">Структура <see cref="T:System.Drawing.Rectangle" />, которая задает расположение и размер отображаемого метафайла.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		/// <param name="callbackData">Внутренний указатель, который является обязательным, однако не обрабатывается. Для этого параметра можно передать объект <see cref="F:System.IntPtr.Zero" />.</param>
		/// <param name="imageAttr">Объект <see cref="T:System.Drawing.Imaging.ImageAttributes" />, задающий сведения об атрибутах формируемого изображения.</param>
		// Token: 0x06000528 RID: 1320 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, Rectangle destRect, Graphics.EnumerateMetafileProc callback, IntPtr callbackData, ImageAttributes imageAttr)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи в выбранном прямоугольнике из объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданном прямоугольнике.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destRect">Структура <see cref="T:System.Drawing.Rectangle" />, которая задает расположение и размер отображаемого метафайла.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.Rectangle" />, задающая часть метафайла, предназначенную для рисования, относительно его верхнего левого угла.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицу измерения, которая должна использоваться для определения части метафайла, содержащейся в прямоугольнике, указываемом параметром <paramref name="srcRect" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		/// <param name="callbackData">Внутренний указатель, который является обязательным, однако не обрабатывается. Для этого параметра можно передать объект <see cref="F:System.IntPtr.Zero" />.</param>
		// Token: 0x06000529 RID: 1321 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, Rectangle destRect, Rectangle srcRect, GraphicsUnit srcUnit, Graphics.EnumerateMetafileProc callback, IntPtr callbackData)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи в выбранном прямоугольнике из объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданном параллелограмме.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destPoints">Массив из трех структур <see cref="T:System.Drawing.PointF" />, определяющих параллелограмм, который задает размер и расположение отображаемого метафайла.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.RectangleF" />, задающая часть метафайла, предназначенную для рисования, относительно его верхнего левого угла.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицу измерения, которая должна использоваться для определения части метафайла, содержащейся в прямоугольнике, указываемом параметром <paramref name="srcRect" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		/// <param name="callbackData">Внутренний указатель, который является обязательным, однако не обрабатывается. Для этого параметра можно передать объект <see cref="F:System.IntPtr.Zero" />.</param>
		// Token: 0x0600052A RID: 1322 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, PointF[] destPoints, RectangleF srcRect, GraphicsUnit srcUnit, Graphics.EnumerateMetafileProc callback, IntPtr callbackData)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи в выбранном прямоугольнике из объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданном прямоугольнике.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destRect">Структура <see cref="T:System.Drawing.RectangleF" />, которая задает расположение и размер отображаемого метафайла.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.RectangleF" />, задающая часть метафайла, предназначенную для рисования, относительно его верхнего левого угла.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицу измерения, которая должна использоваться для определения части метафайла, содержащейся в прямоугольнике, указываемом параметром <paramref name="srcRect" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		/// <param name="callbackData">Внутренний указатель, который является обязательным, однако не обрабатывается. Для этого параметра можно передать объект <see cref="F:System.IntPtr.Zero" />.</param>
		// Token: 0x0600052B RID: 1323 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, RectangleF destRect, RectangleF srcRect, GraphicsUnit srcUnit, Graphics.EnumerateMetafileProc callback, IntPtr callbackData)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи в выбранном прямоугольнике из объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданной точке.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destPoint">Структура <see cref="T:System.Drawing.PointF" />, задающая положение верхнего левого угла отображаемого метафайла.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.RectangleF" />, задающая часть метафайла, предназначенную для рисования, относительно его верхнего левого угла.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицу измерения, которая должна использоваться для определения части метафайла, содержащейся в прямоугольнике, указываемом параметром <paramref name="srcRect" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		/// <param name="callbackData">Внутренний указатель, который является обязательным, однако не обрабатывается. Для этого параметра можно передать объект <see cref="F:System.IntPtr.Zero" />.</param>
		// Token: 0x0600052C RID: 1324 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, PointF destPoint, RectangleF srcRect, GraphicsUnit srcUnit, Graphics.EnumerateMetafileProc callback, IntPtr callbackData)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи в выбранном прямоугольнике из объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданной точке.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destPoint">Структура <see cref="T:System.Drawing.Point" />, задающая положение верхнего левого угла отображаемого метафайла.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.Rectangle" />, задающая часть метафайла, предназначенную для рисования, относительно его верхнего левого угла.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицу измерения, которая должна использоваться для определения части метафайла, содержащейся в прямоугольнике, указываемом параметром <paramref name="srcRect" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		/// <param name="callbackData">Внутренний указатель, который является обязательным, однако не обрабатывается. Для этого параметра можно передать объект <see cref="F:System.IntPtr.Zero" />.</param>
		// Token: 0x0600052D RID: 1325 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, Point destPoint, Rectangle srcRect, GraphicsUnit srcUnit, Graphics.EnumerateMetafileProc callback, IntPtr callbackData)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи в выбранном прямоугольнике из объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданном параллелограмме.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destPoints">Массив из трех структур <see cref="T:System.Drawing.Point" />, определяющих параллелограмм, который задает размер и расположение отображаемого метафайла.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.Rectangle" />, задающая часть метафайла, предназначенную для рисования, относительно его верхнего левого угла.</param>
		/// <param name="srcUnit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицу измерения, которая должна использоваться для определения части метафайла, содержащейся в прямоугольнике, указываемом параметром <paramref name="srcRect" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		/// <param name="callbackData">Внутренний указатель, который является обязательным, однако не обрабатывается. Для этого параметра можно передать объект <see cref="F:System.IntPtr.Zero" />.</param>
		// Token: 0x0600052E RID: 1326 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, Point[] destPoints, Rectangle srcRect, GraphicsUnit srcUnit, Graphics.EnumerateMetafileProc callback, IntPtr callbackData)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи в выбранном прямоугольнике из объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданном параллелограмме, используя указанные атрибуты изображения.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destPoints">Массив из трех структур <see cref="T:System.Drawing.Point" />, определяющих параллелограмм, который задает размер и расположение отображаемого метафайла.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.Rectangle" />, задающая часть метафайла, предназначенную для рисования, относительно его верхнего левого угла.</param>
		/// <param name="unit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицу измерения, которая должна использоваться для определения части метафайла, содержащейся в прямоугольнике, указываемом параметром <paramref name="srcRect" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		/// <param name="callbackData">Внутренний указатель, который является обязательным, однако не обрабатывается. Для этого параметра можно передать объект <see cref="F:System.IntPtr.Zero" />.</param>
		/// <param name="imageAttr">Объект <see cref="T:System.Drawing.Imaging.ImageAttributes" />, задающий сведения об атрибутах формируемого изображения.</param>
		// Token: 0x0600052F RID: 1327 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, Point[] destPoints, Rectangle srcRect, GraphicsUnit unit, Graphics.EnumerateMetafileProc callback, IntPtr callbackData, ImageAttributes imageAttr)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи в выбранном прямоугольнике из объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданном прямоугольнике, используя указанные атрибуты изображения.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destRect">Структура <see cref="T:System.Drawing.Rectangle" />, которая задает расположение и размер отображаемого метафайла.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.Rectangle" />, задающая часть метафайла, предназначенную для рисования, относительно его верхнего левого угла.</param>
		/// <param name="unit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицу измерения, которая должна использоваться для определения части метафайла, содержащейся в прямоугольнике, указываемом параметром <paramref name="srcRect" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		/// <param name="callbackData">Внутренний указатель, который является обязательным, однако не обрабатывается. Для этого параметра можно передать объект <see cref="F:System.IntPtr.Zero" />.</param>
		/// <param name="imageAttr">Объект <see cref="T:System.Drawing.Imaging.ImageAttributes" />, задающий сведения об атрибутах формируемого изображения.</param>
		// Token: 0x06000530 RID: 1328 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, Rectangle destRect, Rectangle srcRect, GraphicsUnit unit, Graphics.EnumerateMetafileProc callback, IntPtr callbackData, ImageAttributes imageAttr)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи в выбранном прямоугольнике из объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданной точке, используя указанные атрибуты изображения.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destPoint">Структура <see cref="T:System.Drawing.Point" />, задающая положение верхнего левого угла отображаемого метафайла.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.Rectangle" />, задающая часть метафайла, предназначенную для рисования, относительно его верхнего левого угла.</param>
		/// <param name="unit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицу измерения, которая должна использоваться для определения части метафайла, содержащейся в прямоугольнике, указываемом параметром <paramref name="srcRect" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		/// <param name="callbackData">Внутренний указатель, который является обязательным, однако не обрабатывается. Для этого параметра можно передать объект <see cref="F:System.IntPtr.Zero" />.</param>
		/// <param name="imageAttr">Объект <see cref="T:System.Drawing.Imaging.ImageAttributes" />, задающий сведения об атрибутах формируемого изображения.</param>
		// Token: 0x06000531 RID: 1329 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, Point destPoint, Rectangle srcRect, GraphicsUnit unit, Graphics.EnumerateMetafileProc callback, IntPtr callbackData, ImageAttributes imageAttr)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи в выбранном прямоугольнике из объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданном прямоугольнике, используя указанные атрибуты изображения.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destRect">Структура <see cref="T:System.Drawing.RectangleF" />, которая задает расположение и размер отображаемого метафайла.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.RectangleF" />, задающая часть метафайла, предназначенную для рисования, относительно его верхнего левого угла.</param>
		/// <param name="unit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицу измерения, которая должна использоваться для определения части метафайла, содержащейся в прямоугольнике, указываемом параметром <paramref name="srcRect" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		/// <param name="callbackData">Внутренний указатель, который является обязательным, однако не обрабатывается. Для этого параметра можно передать объект <see cref="F:System.IntPtr.Zero" />.</param>
		/// <param name="imageAttr">Объект <see cref="T:System.Drawing.Imaging.ImageAttributes" />, задающий сведения об атрибутах формируемого изображения.</param>
		// Token: 0x06000532 RID: 1330 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, RectangleF destRect, RectangleF srcRect, GraphicsUnit unit, Graphics.EnumerateMetafileProc callback, IntPtr callbackData, ImageAttributes imageAttr)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи в выбранном прямоугольнике из объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданном параллелограмме, используя указанные атрибуты изображения.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destPoints">Массив из трех структур <see cref="T:System.Drawing.PointF" />, определяющих параллелограмм, который задает размер и расположение отображаемого метафайла.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.RectangleF" />, задающая часть метафайла, предназначенную для рисования, относительно его верхнего левого угла.</param>
		/// <param name="unit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицу измерения, которая должна использоваться для определения части метафайла, содержащейся в прямоугольнике, указываемом параметром <paramref name="srcRect" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		/// <param name="callbackData">Внутренний указатель, который является обязательным, однако не обрабатывается. Для этого параметра можно передать объект <see cref="F:System.IntPtr.Zero" />.</param>
		/// <param name="imageAttr">Объект <see cref="T:System.Drawing.Imaging.ImageAttributes" />, задающий сведения об атрибутах формируемого изображения.</param>
		// Token: 0x06000533 RID: 1331 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, PointF[] destPoints, RectangleF srcRect, GraphicsUnit unit, Graphics.EnumerateMetafileProc callback, IntPtr callbackData, ImageAttributes imageAttr)
		{
			throw new NotImplementedException();
		}

		/// <summary>Отправляет записи в выбранном прямоугольнике из объекта <see cref="T:System.Drawing.Imaging.Metafile" /> по одной записи за раз в метод обратного вызова, который отображает их в заданной точке, используя указанные атрибуты изображения.</summary>
		/// <param name="metafile">Объект <see cref="T:System.Drawing.Imaging.Metafile" /> для перечисления.</param>
		/// <param name="destPoint">Структура <see cref="T:System.Drawing.PointF" />, задающая положение верхнего левого угла отображаемого метафайла.</param>
		/// <param name="srcRect">Структура <see cref="T:System.Drawing.RectangleF" />, задающая часть метафайла, предназначенную для рисования, относительно его верхнего левого угла.</param>
		/// <param name="unit">Элемент перечисления <see cref="T:System.Drawing.GraphicsUnit" />, задающий единицу измерения, которая должна использоваться для определения части метафайла, содержащейся в прямоугольнике, указываемом параметром <paramref name="srcRect" />.</param>
		/// <param name="callback">Делегат <see cref="T:System.Drawing.Graphics.EnumerateMetafileProc" />, задающий метод, в который отправляются записи метафайлов.</param>
		/// <param name="callbackData">Внутренний указатель, который является обязательным, однако не обрабатывается. Для этого параметра можно передать объект <see cref="F:System.IntPtr.Zero" />.</param>
		/// <param name="imageAttr">Объект <see cref="T:System.Drawing.Imaging.ImageAttributes" />, задающий сведения об атрибутах формируемого изображения.</param>
		// Token: 0x06000534 RID: 1332 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO("Metafiles enumeration, for both WMF and EMF formats, isn't supported.")]
		public void EnumerateMetafile(Metafile metafile, PointF destPoint, RectangleF srcRect, GraphicsUnit unit, Graphics.EnumerateMetafileProc callback, IntPtr callbackData, ImageAttributes imageAttr)
		{
			throw new NotImplementedException();
		}

		/// <summary>Обновляет отсеченную область данного объекта <see cref="T:System.Drawing.Graphics" />, чтобы исключить из нее часть, определяемую структурой <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.Rectangle" />, которая задает прямоугольник, исключаемый из отсеченной области.</param>
		// Token: 0x06000535 RID: 1333 RVA: 0x0000E32A File Offset: 0x0000C52A
		public void ExcludeClip(Rectangle rect)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipSetClipRectI(this.nativeObject, rect.X, rect.Y, rect.Width, rect.Height, CombineMode.Exclude));
		}

		/// <summary>Обновляет отсеченную область данного объекта <see cref="T:System.Drawing.Graphics" />, чтобы исключить из нее часть, определяемую структурой <see cref="T:System.Drawing.Region" />.</summary>
		/// <param name="region">Объект <see cref="T:System.Drawing.Region" />, который задает область, исключаемую из отсеченной области.</param>
		// Token: 0x06000536 RID: 1334 RVA: 0x0000E359 File Offset: 0x0000C559
		public void ExcludeClip(Region region)
		{
			if (region == null)
			{
				throw new ArgumentNullException("region");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipSetClipRegion(this.nativeObject, region.NativeObject, CombineMode.Exclude));
		}

		/// <summary>Заполняет внутреннюю часть замкнутой фундаментальной кривой, определяемой массивом структур <see cref="T:System.Drawing.PointF" />.</summary>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий параметры заливки.</param>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.PointF" />, определяющий сплайн.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="points" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000537 RID: 1335 RVA: 0x0000E380 File Offset: 0x0000C580
		public void FillClosedCurve(Brush brush, PointF[] points)
		{
			if (brush == null)
			{
				throw new ArgumentNullException("brush");
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipFillClosedCurve(this.nativeObject, brush.NativeBrush, points, points.Length));
		}

		/// <summary>Заполняет внутреннюю часть замкнутой фундаментальной кривой, определяемой массивом структур <see cref="T:System.Drawing.Point" />.</summary>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий параметры заливки.</param>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.Point" />, определяющий сплайн.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="points" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000538 RID: 1336 RVA: 0x0000E3B8 File Offset: 0x0000C5B8
		public void FillClosedCurve(Brush brush, Point[] points)
		{
			if (brush == null)
			{
				throw new ArgumentNullException("brush");
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipFillClosedCurveI(this.nativeObject, brush.NativeBrush, points, points.Length));
		}

		/// <summary>Заполняет внутреннюю часть замкнутой фундаментальной сплайновой кривой, определяемой массивом структур <see cref="T:System.Drawing.PointF" />, используя указанный режим заливки.</summary>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий параметры заливки.</param>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.PointF" />, определяющий сплайн.</param>
		/// <param name="fillmode">Элемент перечисления <see cref="T:System.Drawing.Drawing2D.FillMode" />, определяющий способ заполнения кривой.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="points" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000539 RID: 1337 RVA: 0x0000E3F0 File Offset: 0x0000C5F0
		public void FillClosedCurve(Brush brush, PointF[] points, FillMode fillmode)
		{
			if (brush == null)
			{
				throw new ArgumentNullException("brush");
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			this.FillClosedCurve(brush, points, fillmode, 0.5f);
		}

		/// <summary>Заполняет внутреннюю часть замкнутой фундаментальной сплайновой кривой, определяемой массивом структур <see cref="T:System.Drawing.Point" />, используя указанный режим заливки.</summary>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий параметры заливки.</param>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.Point" />, определяющий сплайн.</param>
		/// <param name="fillmode">Элемент перечисления <see cref="T:System.Drawing.Drawing2D.FillMode" />, определяющий способ заполнения кривой.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="points" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600053A RID: 1338 RVA: 0x0000E41C File Offset: 0x0000C61C
		public void FillClosedCurve(Brush brush, Point[] points, FillMode fillmode)
		{
			if (brush == null)
			{
				throw new ArgumentNullException("brush");
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			this.FillClosedCurve(brush, points, fillmode, 0.5f);
		}

		/// <summary>Заполняет внутреннюю часть замкнутой фундаментальной сплайновой кривой, определяемой массивом структур <see cref="T:System.Drawing.PointF" />, используя указанный режим заливки и натяжение.</summary>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий параметры заливки.</param>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.PointF" />, определяющий сплайн.</param>
		/// <param name="fillmode">Элемент перечисления <see cref="T:System.Drawing.Drawing2D.FillMode" />, определяющий способ заполнения кривой.</param>
		/// <param name="tension">Значение не ниже 0,0F, которое задает натяжение кривой.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="points" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600053B RID: 1339 RVA: 0x0000E448 File Offset: 0x0000C648
		public void FillClosedCurve(Brush brush, PointF[] points, FillMode fillmode, float tension)
		{
			if (brush == null)
			{
				throw new ArgumentNullException("brush");
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipFillClosedCurve2(this.nativeObject, brush.NativeBrush, points, points.Length, tension, fillmode));
		}

		/// <summary>Заполняет внутреннюю часть замкнутой фундаментальной сплайновой кривой, определяемой массивом структур <see cref="T:System.Drawing.Point" />, используя указанный режим заливки и натяжение.</summary>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий параметры заливки.</param>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.Point" />, определяющий сплайн.</param>
		/// <param name="fillmode">Элемент перечисления <see cref="T:System.Drawing.Drawing2D.FillMode" />, определяющий способ заполнения кривой.</param>
		/// <param name="tension">Значение не ниже 0,0F, которое задает натяжение кривой.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="points" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600053C RID: 1340 RVA: 0x0000E483 File Offset: 0x0000C683
		public void FillClosedCurve(Brush brush, Point[] points, FillMode fillmode, float tension)
		{
			if (brush == null)
			{
				throw new ArgumentNullException("brush");
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipFillClosedCurve2I(this.nativeObject, brush.NativeBrush, points, points.Length, tension, fillmode));
		}

		/// <summary>Заполняет внутреннюю часть эллипса, определяемого ограничивающим прямоугольником, который задан структурой <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий параметры заливки.</param>
		/// <param name="rect">Структура <see cref="T:System.Drawing.Rectangle" />, представляющая ограничивающий прямоугольник, который определяет эллипс.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600053D RID: 1341 RVA: 0x0000E4BE File Offset: 0x0000C6BE
		public void FillEllipse(Brush brush, Rectangle rect)
		{
			if (brush == null)
			{
				throw new ArgumentNullException("brush");
			}
			this.FillEllipse(brush, rect.X, rect.Y, rect.Width, rect.Height);
		}

		/// <summary>Заполняет внутреннюю часть эллипса, определяемого ограничивающим прямоугольником, который задан структурой <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий параметры заливки.</param>
		/// <param name="rect">Структура <see cref="T:System.Drawing.RectangleF" />, представляющая ограничивающий прямоугольник, который определяет эллипс.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600053E RID: 1342 RVA: 0x0000E4F1 File Offset: 0x0000C6F1
		public void FillEllipse(Brush brush, RectangleF rect)
		{
			if (brush == null)
			{
				throw new ArgumentNullException("brush");
			}
			this.FillEllipse(brush, rect.X, rect.Y, rect.Width, rect.Height);
		}

		/// <summary>Заполняет внутреннюю часть эллипса, определяемого ограничивающим прямоугольником, заданным с помощью пары координат, ширины и высоты.</summary>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий параметры заливки.</param>
		/// <param name="x">Координата X верхнего левого угла ограничивающего прямоугольника, который определяет эллипс.</param>
		/// <param name="y">Координата Y верхнего левого угла ограничивающего прямоугольника, который определяет эллипс.</param>
		/// <param name="width">Ширина ограничивающего прямоугольника, который определяет эллипс.</param>
		/// <param name="height">Высота ограничивающего прямоугольника, который определяет эллипс.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600053F RID: 1343 RVA: 0x0000E524 File Offset: 0x0000C724
		public void FillEllipse(Brush brush, float x, float y, float width, float height)
		{
			if (brush == null)
			{
				throw new ArgumentNullException("brush");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipFillEllipse(this.nativeObject, brush.NativeBrush, x, y, width, height));
		}

		/// <summary>Заполняет внутреннюю часть эллипса, определяемого ограничивающим прямоугольником, заданным с помощью пары координат, ширины и высоты.</summary>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий параметры заливки.</param>
		/// <param name="x">Координата X верхнего левого угла ограничивающего прямоугольника, который определяет эллипс.</param>
		/// <param name="y">Координата Y верхнего левого угла ограничивающего прямоугольника, который определяет эллипс.</param>
		/// <param name="width">Ширина ограничивающего прямоугольника, который определяет эллипс.</param>
		/// <param name="height">Высота ограничивающего прямоугольника, который определяет эллипс.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000540 RID: 1344 RVA: 0x0000E550 File Offset: 0x0000C750
		public void FillEllipse(Brush brush, int x, int y, int width, int height)
		{
			if (brush == null)
			{
				throw new ArgumentNullException("brush");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipFillEllipseI(this.nativeObject, brush.NativeBrush, x, y, width, height));
		}

		/// <summary>Заполняет внутреннюю часть объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий параметры заливки.</param>
		/// <param name="path">Объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />, представляющий контур для заливки.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="path" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000541 RID: 1345 RVA: 0x0000E57C File Offset: 0x0000C77C
		public void FillPath(Brush brush, GraphicsPath path)
		{
			if (brush == null)
			{
				throw new ArgumentNullException("brush");
			}
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipFillPath(this.nativeObject, brush.NativeBrush, path.nativePath));
		}

		/// <summary>Заполняет внутреннюю часть сектора, определяемого эллипсом, который задан структурой <see cref="T:System.Drawing.RectangleF" /> и двумя радиальными линиями.</summary>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий параметры заливки.</param>
		/// <param name="rect">Структура <see cref="T:System.Drawing.Rectangle" />, представляющая ограничивающий прямоугольник, определяющий эллипс, частью которого является данный сектор.</param>
		/// <param name="startAngle">Угол (в градусах), который измеряется по часовой стрелке, начиная от оси X и заканчивая первой стороной сектора.</param>
		/// <param name="sweepAngle">Угол (в градусах), который измеряется по часовой стрелке, начиная от значения параметра <paramref name="startAngle" /> и заканчивая второй стороной сектора.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000542 RID: 1346 RVA: 0x0000E5B8 File Offset: 0x0000C7B8
		public void FillPie(Brush brush, Rectangle rect, float startAngle, float sweepAngle)
		{
			if (brush == null)
			{
				throw new ArgumentNullException("brush");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipFillPie(this.nativeObject, brush.NativeBrush, (float)rect.X, (float)rect.Y, (float)rect.Width, (float)rect.Height, startAngle, sweepAngle));
		}

		/// <summary>Заполняет внутреннюю часть сектора, определяемого эллипсом, который задан парой координат, шириной, высотой и двумя радиальными линиями.</summary>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий параметры заливки.</param>
		/// <param name="x">Координата X верхнего левого угла ограничивающего прямоугольника, определяющего эллипс, частью которого является сектор.</param>
		/// <param name="y">Координата Y верхнего левого угла ограничивающего прямоугольника, определяющего эллипс, частью которого является сектор.</param>
		/// <param name="width">Ширина ограничивающего прямоугольника, определяющего эллипс, частью которого является данный сектор.</param>
		/// <param name="height">Высота ограничивающего прямоугольника, определяющего эллипс, частью которого является данный сектор.</param>
		/// <param name="startAngle">Угол (в градусах), который измеряется по часовой стрелке, начиная от оси X и заканчивая первой стороной сектора.</param>
		/// <param name="sweepAngle">Угол (в градусах), который измеряется по часовой стрелке, начиная от значения параметра <paramref name="startAngle" /> и заканчивая второй стороной сектора.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000543 RID: 1347 RVA: 0x0000E60C File Offset: 0x0000C80C
		public void FillPie(Brush brush, int x, int y, int width, int height, int startAngle, int sweepAngle)
		{
			if (brush == null)
			{
				throw new ArgumentNullException("brush");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipFillPieI(this.nativeObject, brush.NativeBrush, x, y, width, height, (float)startAngle, (float)sweepAngle));
		}

		/// <summary>Заполняет внутреннюю часть сектора, определяемого эллипсом, который задан парой координат, шириной, высотой и двумя радиальными линиями.</summary>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий параметры заливки.</param>
		/// <param name="x">Координата X верхнего левого угла ограничивающего прямоугольника, определяющего эллипс, частью которого является сектор.</param>
		/// <param name="y">Координата Y верхнего левого угла ограничивающего прямоугольника, определяющего эллипс, частью которого является сектор.</param>
		/// <param name="width">Ширина ограничивающего прямоугольника, определяющего эллипс, частью которого является данный сектор.</param>
		/// <param name="height">Высота ограничивающего прямоугольника, определяющего эллипс, частью которого является данный сектор.</param>
		/// <param name="startAngle">Угол (в градусах), который измеряется по часовой стрелке, начиная от оси X и заканчивая первой стороной сектора.</param>
		/// <param name="sweepAngle">Угол (в градусах), который измеряется по часовой стрелке, начиная от значения параметра <paramref name="startAngle" /> и заканчивая второй стороной сектора.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000544 RID: 1348 RVA: 0x0000E63E File Offset: 0x0000C83E
		public void FillPie(Brush brush, float x, float y, float width, float height, float startAngle, float sweepAngle)
		{
			if (brush == null)
			{
				throw new ArgumentNullException("brush");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipFillPie(this.nativeObject, brush.NativeBrush, x, y, width, height, startAngle, sweepAngle));
		}

		/// <summary>Заполняет внутреннюю часть многоугольника, определяемого массивом точек, заданных структурами <see cref="T:System.Drawing.PointF" />.</summary>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий параметры заливки.</param>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.PointF" />, которые представляют вершины закрашиваемого многоугольника.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="points" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000545 RID: 1349 RVA: 0x0000E66E File Offset: 0x0000C86E
		public void FillPolygon(Brush brush, PointF[] points)
		{
			if (brush == null)
			{
				throw new ArgumentNullException("brush");
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipFillPolygon2(this.nativeObject, brush.NativeBrush, points, points.Length));
		}

		/// <summary>Заполняет внутреннюю часть многоугольника, определяемого массивом точек, заданных структурами <see cref="T:System.Drawing.Point" />.</summary>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий параметры заливки.</param>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.Point" />, которые представляют вершины закрашиваемого многоугольника.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="points" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000546 RID: 1350 RVA: 0x0000E6A6 File Offset: 0x0000C8A6
		public void FillPolygon(Brush brush, Point[] points)
		{
			if (brush == null)
			{
				throw new ArgumentNullException("brush");
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipFillPolygon2I(this.nativeObject, brush.NativeBrush, points, points.Length));
		}

		/// <summary>Заполняет внутреннюю часть многоугольника, определенного массивом точек, которые задаются структурами <see cref="T:System.Drawing.Point" />, используя указанный режим заливки.</summary>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий параметры заливки.</param>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.Point" />, которые представляют вершины закрашиваемого многоугольника.</param>
		/// <param name="fillMode">Элемент перечисления <see cref="T:System.Drawing.Drawing2D.FillMode" />, определяющий стиль заливки.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="points" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000547 RID: 1351 RVA: 0x0000E6DE File Offset: 0x0000C8DE
		public void FillPolygon(Brush brush, Point[] points, FillMode fillMode)
		{
			if (brush == null)
			{
				throw new ArgumentNullException("brush");
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipFillPolygonI(this.nativeObject, brush.NativeBrush, points, points.Length, fillMode));
		}

		/// <summary>Заполняет внутреннюю часть многоугольника, определенного массивом точек, которые задаются структурами <see cref="T:System.Drawing.PointF" />, используя указанный режим заливки.</summary>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий параметры заливки.</param>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.PointF" />, которые представляют вершины закрашиваемого многоугольника.</param>
		/// <param name="fillMode">Элемент перечисления <see cref="T:System.Drawing.Drawing2D.FillMode" />, определяющий стиль заливки.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="points" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000548 RID: 1352 RVA: 0x0000E717 File Offset: 0x0000C917
		public void FillPolygon(Brush brush, PointF[] points, FillMode fillMode)
		{
			if (brush == null)
			{
				throw new ArgumentNullException("brush");
			}
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipFillPolygon(this.nativeObject, brush.NativeBrush, points, points.Length, fillMode));
		}

		/// <summary>Заполняет внутреннюю часть прямоугольника, определяемого структурой <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий параметры заливки.</param>
		/// <param name="rect">Структура <see cref="T:System.Drawing.RectangleF" />, представляющая прямоугольник для заливки.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000549 RID: 1353 RVA: 0x0000E750 File Offset: 0x0000C950
		public void FillRectangle(Brush brush, RectangleF rect)
		{
			if (brush == null)
			{
				throw new ArgumentNullException("brush");
			}
			this.FillRectangle(brush, rect.Left, rect.Top, rect.Width, rect.Height);
		}

		/// <summary>Заполняет внутреннюю часть прямоугольника, определяемого структурой <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий параметры заливки.</param>
		/// <param name="rect">Структура <see cref="T:System.Drawing.Rectangle" />, представляющая прямоугольник для заливки.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600054A RID: 1354 RVA: 0x0000E783 File Offset: 0x0000C983
		public void FillRectangle(Brush brush, Rectangle rect)
		{
			if (brush == null)
			{
				throw new ArgumentNullException("brush");
			}
			this.FillRectangle(brush, rect.Left, rect.Top, rect.Width, rect.Height);
		}

		/// <summary>Заполняет внутреннюю часть прямоугольника, который задается парой координат, шириной и высотой.</summary>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий параметры заливки.</param>
		/// <param name="x">Координата X верхнего левого угла прямоугольника для заливки.</param>
		/// <param name="y">Координата Y верхнего левого угла прямоугольника для заливки.</param>
		/// <param name="width">Ширина прямоугольника для заливки.</param>
		/// <param name="height">Высота прямоугольника для заливки.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600054B RID: 1355 RVA: 0x0000E7B6 File Offset: 0x0000C9B6
		public void FillRectangle(Brush brush, int x, int y, int width, int height)
		{
			if (brush == null)
			{
				throw new ArgumentNullException("brush");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipFillRectangleI(this.nativeObject, brush.NativeBrush, x, y, width, height));
		}

		/// <summary>Заполняет внутреннюю часть прямоугольника, который задается парой координат, шириной и высотой.</summary>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий параметры заливки.</param>
		/// <param name="x">Координата X верхнего левого угла прямоугольника для заливки.</param>
		/// <param name="y">Координата Y верхнего левого угла прямоугольника для заливки.</param>
		/// <param name="width">Ширина прямоугольника для заливки.</param>
		/// <param name="height">Высота прямоугольника для заливки.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600054C RID: 1356 RVA: 0x0000E7E2 File Offset: 0x0000C9E2
		public void FillRectangle(Brush brush, float x, float y, float width, float height)
		{
			if (brush == null)
			{
				throw new ArgumentNullException("brush");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipFillRectangle(this.nativeObject, brush.NativeBrush, x, y, width, height));
		}

		/// <summary>Заполняет внутреннюю часть набора прямоугольников, определяемых структурами <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий параметры заливки.</param>
		/// <param name="rects">Массив структур <see cref="T:System.Drawing.Rectangle" />, которые представляют прямоугольники для заливки.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="rects" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="rects" /> представляет собой массив нулевой длины.</exception>
		// Token: 0x0600054D RID: 1357 RVA: 0x0000E80E File Offset: 0x0000CA0E
		public void FillRectangles(Brush brush, Rectangle[] rects)
		{
			if (brush == null)
			{
				throw new ArgumentNullException("brush");
			}
			if (rects == null)
			{
				throw new ArgumentNullException("rects");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipFillRectanglesI(this.nativeObject, brush.NativeBrush, rects, rects.Length));
		}

		/// <summary>Заполняет внутреннюю часть набора прямоугольников, определяемых структурами <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий параметры заливки.</param>
		/// <param name="rects">Массив структур <see cref="T:System.Drawing.RectangleF" />, которые представляют прямоугольники для заливки.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="rects" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="Rects" /> представляет собой массив нулевой длины.</exception>
		// Token: 0x0600054E RID: 1358 RVA: 0x0000E846 File Offset: 0x0000CA46
		public void FillRectangles(Brush brush, RectangleF[] rects)
		{
			if (brush == null)
			{
				throw new ArgumentNullException("brush");
			}
			if (rects == null)
			{
				throw new ArgumentNullException("rects");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipFillRectangles(this.nativeObject, brush.NativeBrush, rects, rects.Length));
		}

		/// <summary>Заполняет внутреннюю часть объекта <see cref="T:System.Drawing.Region" />.</summary>
		/// <param name="brush">Объект <see cref="T:System.Drawing.Brush" />, определяющий параметры заливки.</param>
		/// <param name="region">Объект <see cref="T:System.Drawing.Region" />, представляющий область для заливки.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="brush" /> имеет значение <see langword="null" />.  
		/// -или- 
		///  Свойство <paramref name="region" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600054F RID: 1359 RVA: 0x0000E87E File Offset: 0x0000CA7E
		public void FillRegion(Brush brush, Region region)
		{
			if (brush == null)
			{
				throw new ArgumentNullException("brush");
			}
			if (region == null)
			{
				throw new ArgumentNullException("region");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipFillRegion(this.nativeObject, brush.NativeBrush, region.NativeObject));
		}

		/// <summary>Вызывает принудительное выполнение всех отложенных графических операций и немедленно возвращается, не дожидаясь их окончания.</summary>
		// Token: 0x06000550 RID: 1360 RVA: 0x0000E8B8 File Offset: 0x0000CAB8
		public void Flush()
		{
			this.Flush(FlushIntention.Flush);
		}

		/// <summary>Вызывает принудительное выполнение всех отложенных графических операций. При этом в соответствии с настройкой метод дожидается или не дожидается окончания операций для возврата.</summary>
		/// <param name="intention">Элемент перечисления <see cref="T:System.Drawing.Drawing2D.FlushIntention" />, который определяет, будет ли метод выполнять немедленный возврат, или будет ожидать окончания всех выполняемых операций.</param>
		// Token: 0x06000551 RID: 1361 RVA: 0x0000E8C1 File Offset: 0x0000CAC1
		public void Flush(FlushIntention intention)
		{
			if (this.nativeObject == IntPtr.Zero)
			{
				return;
			}
			GDIPlus.CheckStatus(GDIPlus.GdipFlush(this.nativeObject, intention));
			if (this.maccontext != null)
			{
				this.maccontext.Synchronize();
			}
		}

		/// <summary>Создает новый объект <see cref="T:System.Drawing.Graphics" /> из указанного дескриптора для контекста устройств.</summary>
		/// <param name="hdc">Дескриптор контекста устройства.</param>
		/// <returns>Этот метод возвращает новый объект <see cref="T:System.Drawing.Graphics" /> для заданного контекста устройств.</returns>
		// Token: 0x06000552 RID: 1362 RVA: 0x0000E8FC File Offset: 0x0000CAFC
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static Graphics FromHdc(IntPtr hdc)
		{
			IntPtr nativeGraphics;
			GDIPlus.CheckStatus(GDIPlus.GdipCreateFromHDC(hdc, out nativeGraphics));
			return new Graphics(nativeGraphics);
		}

		/// <summary>Создает новый объект <see cref="T:System.Drawing.Graphics" /> из указанного дескриптора контекста устройства и дескриптора устройства.</summary>
		/// <param name="hdc">Дескриптор контекста устройства.</param>
		/// <param name="hdevice">Дескриптор устройства.</param>
		/// <returns>Этот метод возвращает новый объект <see cref="T:System.Drawing.Graphics" /> для заданного контекста устройств и самого устройства.</returns>
		// Token: 0x06000553 RID: 1363 RVA: 0x00009B6A File Offset: 0x00007D6A
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[MonoTODO]
		public static Graphics FromHdc(IntPtr hdc, IntPtr hdevice)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает объект <see cref="T:System.Drawing.Graphics" /> для заданного контекста устройств.</summary>
		/// <param name="hdc">Дескриптор контекста устройства.</param>
		/// <returns>Объект <see cref="T:System.Drawing.Graphics" /> для заданного контекста устройств.</returns>
		// Token: 0x06000554 RID: 1364 RVA: 0x0000E91C File Offset: 0x0000CB1C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static Graphics FromHdcInternal(IntPtr hdc)
		{
			GDIPlus.Display = hdc;
			return null;
		}

		/// <summary>Создает новый объект <see cref="T:System.Drawing.Graphics" /> из указанного дескриптора окна.</summary>
		/// <param name="hwnd">Дескриптор окна.</param>
		/// <returns>Этот метод возвращает новый объект <see cref="T:System.Drawing.Graphics" /> для заданного дескриптора окна.</returns>
		// Token: 0x06000555 RID: 1365 RVA: 0x0000E928 File Offset: 0x0000CB28
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static Graphics FromHwnd(IntPtr hwnd)
		{
			if (GDIPlus.UseCocoaDrawable)
			{
				if (hwnd == IntPtr.Zero)
				{
					throw new NotSupportedException("Opening display graphics is not supported");
				}
				CocoaContext cgcontextForNSView = MacSupport.GetCGContextForNSView(hwnd);
				IntPtr nativeGraphics;
				GDIPlus.GdipCreateFromContext_macosx(cgcontextForNSView.ctx, cgcontextForNSView.width, cgcontextForNSView.height, out nativeGraphics);
				return new Graphics(nativeGraphics)
				{
					maccontext = cgcontextForNSView
				};
			}
			else
			{
				IntPtr nativeGraphics;
				if (GDIPlus.UseCarbonDrawable)
				{
					CarbonContext cgcontextForView = MacSupport.GetCGContextForView(hwnd);
					GDIPlus.GdipCreateFromContext_macosx(cgcontextForView.ctx, cgcontextForView.width, cgcontextForView.height, out nativeGraphics);
					return new Graphics(nativeGraphics)
					{
						maccontext = cgcontextForView
					};
				}
				if (GDIPlus.UseX11Drawable)
				{
					if (GDIPlus.Display == IntPtr.Zero)
					{
						GDIPlus.Display = GDIPlus.XOpenDisplay(IntPtr.Zero);
						if (GDIPlus.Display == IntPtr.Zero)
						{
							throw new NotSupportedException("Could not open display (X-Server required. Check your DISPLAY environment variable)");
						}
					}
					if (hwnd == IntPtr.Zero)
					{
						hwnd = GDIPlus.XRootWindow(GDIPlus.Display, GDIPlus.XDefaultScreen(GDIPlus.Display));
					}
					return Graphics.FromXDrawable(hwnd, GDIPlus.Display);
				}
				GDIPlus.CheckStatus(GDIPlus.GdipCreateFromHWND(hwnd, out nativeGraphics));
				return new Graphics(nativeGraphics);
			}
		}

		/// <summary>Создает новый объект <see cref="T:System.Drawing.Graphics" /> для указанного дескриптора окна.</summary>
		/// <param name="hwnd">Дескриптор окна.</param>
		/// <returns>Объект <see cref="T:System.Drawing.Graphics" /> для указанного дескриптора окна.</returns>
		// Token: 0x06000556 RID: 1366 RVA: 0x0000EA43 File Offset: 0x0000CC43
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static Graphics FromHwndInternal(IntPtr hwnd)
		{
			return Graphics.FromHwnd(hwnd);
		}

		/// <summary>Создает новый объект <see cref="T:System.Drawing.Graphics" /> из указанного объекта <see cref="T:System.Drawing.Image" />.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" />, на основе которого будет создан новый объект <see cref="T:System.Drawing.Graphics" />.</param>
		/// <returns>Этот метод возвращает новый объект <see cref="T:System.Drawing.Graphics" /> для указанного объекта <see cref="T:System.Drawing.Image" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="image" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Exception">Объект <paramref name="image" /> имеет индексированный формат пикселей или его формат не определен.</exception>
		// Token: 0x06000557 RID: 1367 RVA: 0x0000EA4C File Offset: 0x0000CC4C
		public static Graphics FromImage(Image image)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			if ((image.PixelFormat & PixelFormat.Indexed) != PixelFormat.Undefined)
			{
				throw new Exception(Locale.GetText("Cannot create Graphics from an indexed bitmap."));
			}
			IntPtr nativeGraphics;
			GDIPlus.CheckStatus(GDIPlus.GdipGetImageGraphicsContext(image.nativeObject, out nativeGraphics));
			Graphics graphics = new Graphics(nativeGraphics, image);
			if (GDIPlus.RunningOnUnix())
			{
				Rectangle rectangle = new Rectangle(0, 0, image.Width, image.Height);
				GDIPlus.GdipSetVisibleClip_linux(graphics.NativeObject, ref rectangle);
			}
			return graphics;
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0000EACC File Offset: 0x0000CCCC
		internal static Graphics FromXDrawable(IntPtr drawable, IntPtr display)
		{
			IntPtr nativeGraphics;
			GDIPlus.CheckStatus(GDIPlus.GdipCreateFromXDrawable_linux(drawable, display, out nativeGraphics));
			return new Graphics(nativeGraphics);
		}

		/// <summary>Возвращает дескриптор текущей полутоновой палитры Windows.</summary>
		/// <returns>Внутренний указатель, который задает дескриптор палитры.</returns>
		// Token: 0x06000559 RID: 1369 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO]
		public static IntPtr GetHalftonePalette()
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает дескриптор контекста устройства, связанный с данным объектом <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <returns>Дескриптор контекста устройства, связанный с данным объектом <see cref="T:System.Drawing.Graphics" />.</returns>
		// Token: 0x0600055A RID: 1370 RVA: 0x0000EAED File Offset: 0x0000CCED
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public IntPtr GetHdc()
		{
			GDIPlus.CheckStatus(GDIPlus.GdipGetDC(this.nativeObject, out this.deviceContextHdc));
			return this.deviceContextHdc;
		}

		/// <summary>Возвращает цвет, ближайший к указанной структуре <see cref="T:System.Drawing.Color" />.</summary>
		/// <param name="color">Структура <see cref="T:System.Drawing.Color" />, для которой необходимо найти соответствие.</param>
		/// <returns>Структура <see cref="T:System.Drawing.Color" />, представляющая цвет, ближайший к цвету, определяемому с помощью параметра <paramref name="color" />.</returns>
		// Token: 0x0600055B RID: 1371 RVA: 0x0000EB0C File Offset: 0x0000CD0C
		public Color GetNearestColor(Color color)
		{
			int argb;
			GDIPlus.CheckStatus(GDIPlus.GdipGetNearestColor(this.nativeObject, out argb));
			return Color.FromArgb(argb);
		}

		/// <summary>Обновляет отсеченную область данного объекта <see cref="T:System.Drawing.Graphics" />, включая в нее пересечение текущей отсеченной области и указанной области <see cref="T:System.Drawing.Region" />.</summary>
		/// <param name="region">Объект <see cref="T:System.Drawing.Region" />, пересекающийся с текущей областью.</param>
		// Token: 0x0600055C RID: 1372 RVA: 0x0000EB31 File Offset: 0x0000CD31
		public void IntersectClip(Region region)
		{
			if (region == null)
			{
				throw new ArgumentNullException("region");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipSetClipRegion(this.nativeObject, region.NativeObject, CombineMode.Intersect));
		}

		/// <summary>Обновляет отсеченную область данного объекта <see cref="T:System.Drawing.Graphics" />, включая в нее пересечение текущей отсеченной области и указанной структуры <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.RectangleF" />, пересекающаяся с текущей вырезанной областью.</param>
		// Token: 0x0600055D RID: 1373 RVA: 0x0000EB58 File Offset: 0x0000CD58
		public void IntersectClip(RectangleF rect)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipSetClipRect(this.nativeObject, rect.X, rect.Y, rect.Width, rect.Height, CombineMode.Intersect));
		}

		/// <summary>Обновляет отсеченную область данного объекта <see cref="T:System.Drawing.Graphics" />, включая в нее пересечение текущей отсеченной области и указанной структуры <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.Rectangle" />, пересекающаяся с текущей вырезанной областью.</param>
		// Token: 0x0600055E RID: 1374 RVA: 0x0000EB87 File Offset: 0x0000CD87
		public void IntersectClip(Rectangle rect)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipSetClipRectI(this.nativeObject, rect.X, rect.Y, rect.Width, rect.Height, CombineMode.Intersect));
		}

		/// <summary>Указывает, содержится ли заданная структура <see cref="T:System.Drawing.Point" /> в видимой отсеченной области данного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="point">Структура <see cref="T:System.Drawing.Point" /> для проверки видимости.</param>
		/// <returns>Значение <see langword="true" />, если точка, задаваемая параметром <paramref name="point" />, содержится в видимой вырезанной области данного объекта <see cref="T:System.Drawing.Graphics" />; в противном случае устанавливается значение <see langword="false" />.</returns>
		// Token: 0x0600055F RID: 1375 RVA: 0x0000EBB8 File Offset: 0x0000CDB8
		public bool IsVisible(Point point)
		{
			bool result = false;
			GDIPlus.CheckStatus(GDIPlus.GdipIsVisiblePointI(this.nativeObject, point.X, point.Y, out result));
			return result;
		}

		/// <summary>Указывает, содержится ли прямоугольник, задаваемый структурой <see cref="T:System.Drawing.RectangleF" />, в видимой отсеченной области данного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.RectangleF" /> для проверки видимости.</param>
		/// <returns>Значение <see langword="true" />, если прямоугольник, задаваемый параметром <paramref name="rect" />, содержится в видимой отсеченной области данного объекта <see cref="T:System.Drawing.Graphics" />; в противном случае значение <see langword="false" />.</returns>
		// Token: 0x06000560 RID: 1376 RVA: 0x0000EBE8 File Offset: 0x0000CDE8
		public bool IsVisible(RectangleF rect)
		{
			bool result = false;
			GDIPlus.CheckStatus(GDIPlus.GdipIsVisibleRect(this.nativeObject, rect.X, rect.Y, rect.Width, rect.Height, out result));
			return result;
		}

		/// <summary>Указывает, содержится ли заданная структура <see cref="T:System.Drawing.PointF" /> в видимой отсеченной области данного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="point">Структура <see cref="T:System.Drawing.PointF" /> для проверки видимости.</param>
		/// <returns>Значение <see langword="true" />, если точка, задаваемая параметром <paramref name="point" />, содержится в видимой вырезанной области данного объекта <see cref="T:System.Drawing.Graphics" />; в противном случае устанавливается значение <see langword="false" />.</returns>
		// Token: 0x06000561 RID: 1377 RVA: 0x0000EC28 File Offset: 0x0000CE28
		public bool IsVisible(PointF point)
		{
			bool result = false;
			GDIPlus.CheckStatus(GDIPlus.GdipIsVisiblePoint(this.nativeObject, point.X, point.Y, out result));
			return result;
		}

		/// <summary>Указывает, содержится ли прямоугольник, задаваемый структурой <see cref="T:System.Drawing.Rectangle" />, в видимой отсеченной области данного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.Rectangle" /> для проверки видимости.</param>
		/// <returns>Значение <see langword="true" />, если прямоугольник, задаваемый параметром <paramref name="rect" />, содержится в видимой отсеченной области данного объекта <see cref="T:System.Drawing.Graphics" />; в противном случае значение <see langword="false" />.</returns>
		// Token: 0x06000562 RID: 1378 RVA: 0x0000EC58 File Offset: 0x0000CE58
		public bool IsVisible(Rectangle rect)
		{
			bool result = false;
			GDIPlus.CheckStatus(GDIPlus.GdipIsVisibleRectI(this.nativeObject, rect.X, rect.Y, rect.Width, rect.Height, out result));
			return result;
		}

		/// <summary>Указывает, содержится ли точка, задаваемая с помощью пары координат, в видимой отсеченной области данного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="x">Координата X точки для проверки на видимость.</param>
		/// <param name="y">Координата Y точки для проверки на видимость.</param>
		/// <returns>Значение <see langword="true" />, если точка, определяемая параметрами <paramref name="x" /> и <paramref name="y" />, содержится внутри видимой вырезанной области данного объекта <see cref="T:System.Drawing.Graphics" />; в противном случае устанавливается значение <see langword="false" />.</returns>
		// Token: 0x06000563 RID: 1379 RVA: 0x0000EC96 File Offset: 0x0000CE96
		public bool IsVisible(float x, float y)
		{
			return this.IsVisible(new PointF(x, y));
		}

		/// <summary>Указывает, содержится ли точка, задаваемая с помощью пары координат, в видимой отсеченной области данного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="x">Координата X точки для проверки на видимость.</param>
		/// <param name="y">Координата Y точки для проверки на видимость.</param>
		/// <returns>Значение <see langword="true" />, если точка, определяемая параметрами <paramref name="x" /> и <paramref name="y" />, содержится внутри видимой вырезанной области данного объекта <see cref="T:System.Drawing.Graphics" />; в противном случае устанавливается значение <see langword="false" />.</returns>
		// Token: 0x06000564 RID: 1380 RVA: 0x0000ECA5 File Offset: 0x0000CEA5
		public bool IsVisible(int x, int y)
		{
			return this.IsVisible(new Point(x, y));
		}

		/// <summary>Указывает, содержится ли прямоугольник, задаваемый с помощью пары координат, ширины и высоты, в видимой отсеченной области данного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="x">Координата X верхнего левого угла прямоугольника для проверки на видимость.</param>
		/// <param name="y">Координата Y верхнего левого угла прямоугольника для проверки на видимость.</param>
		/// <param name="width">Ширина прямоугольника для проверки на видимость.</param>
		/// <param name="height">Высота прямоугольника для проверки на видимость.</param>
		/// <returns>Значение <see langword="true" />, если прямоугольник, определяемый параметрами <paramref name="x" />, <paramref name="y" />, <paramref name="width" /> и <paramref name="height" />, содержится внутри видимой отсеченной области данного объекта <see cref="T:System.Drawing.Graphics" />; в противном случае значение <see langword="false" />.</returns>
		// Token: 0x06000565 RID: 1381 RVA: 0x0000ECB4 File Offset: 0x0000CEB4
		public bool IsVisible(float x, float y, float width, float height)
		{
			return this.IsVisible(new RectangleF(x, y, width, height));
		}

		/// <summary>Указывает, содержится ли прямоугольник, задаваемый с помощью пары координат, ширины и высоты, в видимой отсеченной области данного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="x">Координата X верхнего левого угла прямоугольника для проверки на видимость.</param>
		/// <param name="y">Координата Y верхнего левого угла прямоугольника для проверки на видимость.</param>
		/// <param name="width">Ширина прямоугольника для проверки на видимость.</param>
		/// <param name="height">Высота прямоугольника для проверки на видимость.</param>
		/// <returns>Значение <see langword="true" />, если прямоугольник, определяемый параметрами <paramref name="x" />, <paramref name="y" />, <paramref name="width" /> и <paramref name="height" />, содержится внутри видимой отсеченной области данного объекта <see cref="T:System.Drawing.Graphics" />; в противном случае значение <see langword="false" />.</returns>
		// Token: 0x06000566 RID: 1382 RVA: 0x0000ECC6 File Offset: 0x0000CEC6
		public bool IsVisible(int x, int y, int width, int height)
		{
			return this.IsVisible(new Rectangle(x, y, width, height));
		}

		/// <summary>Возвращает массив объектов <see cref="T:System.Drawing.Region" />, каждый из которых ограничивает диапазон позиций символов в рамках указанной строки.</summary>
		/// <param name="text">Строка для измерения.</param>
		/// <param name="font">Объект <see cref="T:System.Drawing.Font" />, определяющий формат текста строки.</param>
		/// <param name="layoutRect">Структура <see cref="T:System.Drawing.RectangleF" />, которая задает прямоугольник компоновки для строки.</param>
		/// <param name="stringFormat">Объект <see cref="T:System.Drawing.StringFormat" />, представляющий сведения о форматировании для строки, например межстрочный интервал.</param>
		/// <returns>Этот метод возвращает массив объектов <see cref="T:System.Drawing.Region" />, каждый из которых ограничивает диапазон позиций символов в рамках указанной строки.</returns>
		// Token: 0x06000567 RID: 1383 RVA: 0x0000ECD8 File Offset: 0x0000CED8
		public Region[] MeasureCharacterRanges(string text, Font font, RectangleF layoutRect, StringFormat stringFormat)
		{
			if (text == null || text.Length == 0)
			{
				return new Region[0];
			}
			if (font == null)
			{
				throw new ArgumentNullException("font");
			}
			if (stringFormat == null)
			{
				throw new ArgumentException("stringFormat");
			}
			int measurableCharacterRangeCount = stringFormat.GetMeasurableCharacterRangeCount();
			if (measurableCharacterRangeCount == 0)
			{
				return new Region[0];
			}
			IntPtr[] array = new IntPtr[measurableCharacterRangeCount];
			Region[] array2 = new Region[measurableCharacterRangeCount];
			for (int i = 0; i < measurableCharacterRangeCount; i++)
			{
				array2[i] = new Region();
				array[i] = array2[i].NativeObject;
			}
			GDIPlus.CheckStatus(GDIPlus.GdipMeasureCharacterRanges(this.nativeObject, text, text.Length, font.NativeObject, ref layoutRect, stringFormat.NativeObject, measurableCharacterRangeCount, out array[0]));
			return array2;
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0000ED84 File Offset: 0x0000CF84
		private SizeF GdipMeasureString(IntPtr graphics, string text, Font font, ref RectangleF layoutRect, IntPtr stringFormat)
		{
			if (text == null || text.Length == 0)
			{
				return SizeF.Empty;
			}
			if (font == null)
			{
				throw new ArgumentNullException("font");
			}
			RectangleF rectangleF = default(RectangleF);
			GDIPlus.CheckStatus(GDIPlus.GdipMeasureString(this.nativeObject, text, text.Length, font.NativeObject, ref layoutRect, stringFormat, out rectangleF, null, null));
			return new SizeF(rectangleF.Width, rectangleF.Height);
		}

		/// <summary>Измеряет указанную строку в процессе ее создания с помощью заданного объекта <see cref="T:System.Drawing.Font" />.</summary>
		/// <param name="text">Строка для измерения.</param>
		/// <param name="font">Объект <see cref="T:System.Drawing.Font" />, определяющий формат текста строки.</param>
		/// <returns>Этот метод возвращает структуру <see cref="T:System.Drawing.SizeF" />, представляющую размер в единицах, задаваемых свойством <see cref="P:System.Drawing.Graphics.PageUnit" />, для строки, которая определяется параметром <paramref name="text" /> в процессе рисования с использованием шрифта <paramref name="font" />.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="font" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000569 RID: 1385 RVA: 0x0000EDF2 File Offset: 0x0000CFF2
		public SizeF MeasureString(string text, Font font)
		{
			return this.MeasureString(text, font, SizeF.Empty);
		}

		/// <summary>Измеряет указанную строку в процессе ее создания с заданным шрифтом <see cref="T:System.Drawing.Font" /> в пределах заданной области макета.</summary>
		/// <param name="text">Строка для измерения.</param>
		/// <param name="font">Объект <see cref="T:System.Drawing.Font" /> определяет формат текстовой строки.</param>
		/// <param name="layoutArea">Структура <see cref="T:System.Drawing.SizeF" />, которая задает максимальную область размещения для текста.</param>
		/// <returns>Этот метод возвращает структуру <see cref="T:System.Drawing.SizeF" />, представляющую размер в единицах, задаваемых свойством <see cref="P:System.Drawing.Graphics.PageUnit" />, для строки, которая определяется параметром <paramref name="text" /> в процессе рисования с использованием шрифта <paramref name="font" />.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="font" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600056A RID: 1386 RVA: 0x0000EE04 File Offset: 0x0000D004
		public SizeF MeasureString(string text, Font font, SizeF layoutArea)
		{
			RectangleF rectangleF = new RectangleF(0f, 0f, layoutArea.Width, layoutArea.Height);
			return this.GdipMeasureString(this.nativeObject, text, font, ref rectangleF, IntPtr.Zero);
		}

		/// <summary>Измеряет указанную строку в процессе ее создания с помощью заданного объекта <see cref="T:System.Drawing.Font" />.</summary>
		/// <param name="text">Строка для измерения.</param>
		/// <param name="font">Объект <see cref="T:System.Drawing.Font" />, определяющий формат текстовой строки.</param>
		/// <param name="width">Максимальная ширина строки (в пикселях).</param>
		/// <returns>Этот метод возвращает структуру <see cref="T:System.Drawing.SizeF" />, представляющую размер в единицах, задаваемых свойством <see cref="P:System.Drawing.Graphics.PageUnit" /> для строки, которая определяется параметром <paramref name="text" /> в процессе рисования с использованием шрифта <paramref name="font" />.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="font" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600056B RID: 1387 RVA: 0x0000EE48 File Offset: 0x0000D048
		public SizeF MeasureString(string text, Font font, int width)
		{
			RectangleF rectangleF = new RectangleF(0f, 0f, (float)width, 2.1474836E+09f);
			return this.GdipMeasureString(this.nativeObject, text, font, ref rectangleF, IntPtr.Zero);
		}

		/// <summary>Измеряет указанную строку при ее отображении с заданным шрифтом <see cref="T:System.Drawing.Font" /> и отформатированную с помощью заданного формата <see cref="T:System.Drawing.StringFormat" />.</summary>
		/// <param name="text">Строка для измерения.</param>
		/// <param name="font">Объект <see cref="T:System.Drawing.Font" /> определяет формат текстовой строки.</param>
		/// <param name="layoutArea">Структура <see cref="T:System.Drawing.SizeF" />, которая задает максимальную область размещения для текста.</param>
		/// <param name="stringFormat">Объект <see cref="T:System.Drawing.StringFormat" />, представляющий сведения о форматировании для строки, например межстрочный интервал.</param>
		/// <returns>Этот метод возвращает структуру <see cref="T:System.Drawing.SizeF" />, представляющую размер в единицах, задаваемых свойством <see cref="P:System.Drawing.Graphics.PageUnit" />, для строки, которая определяется параметром <paramref name="text" /> при отображении с шрифтом <paramref name="font" /> и форматом <paramref name="stringFormat" />.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="font" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600056C RID: 1388 RVA: 0x0000EE84 File Offset: 0x0000D084
		public SizeF MeasureString(string text, Font font, SizeF layoutArea, StringFormat stringFormat)
		{
			RectangleF rectangleF = new RectangleF(0f, 0f, layoutArea.Width, layoutArea.Height);
			IntPtr stringFormat2 = (stringFormat == null) ? IntPtr.Zero : stringFormat.NativeObject;
			return this.GdipMeasureString(this.nativeObject, text, font, ref rectangleF, stringFormat2);
		}

		/// <summary>Измеряет указанную строку при ее отображении с заданным шрифтом <see cref="T:System.Drawing.Font" /> и отформатированную с помощью заданного формата <see cref="T:System.Drawing.StringFormat" />.</summary>
		/// <param name="text">Строка для измерения.</param>
		/// <param name="font">Объект <see cref="T:System.Drawing.Font" />, определяющий формат текста строки.</param>
		/// <param name="width">Максимальная ширина строки.</param>
		/// <param name="format">Объект <see cref="T:System.Drawing.StringFormat" />, представляющий сведения о форматировании для строки, например межстрочный интервал.</param>
		/// <returns>Этот метод возвращает структуру <see cref="T:System.Drawing.SizeF" />, представляющую размер в единицах, задаваемых свойством <see cref="P:System.Drawing.Graphics.PageUnit" />, для строки, которая определяется параметром <paramref name="text" /> при отображении с шрифтом <paramref name="font" /> и форматом <paramref name="stringFormat" />.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="font" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600056D RID: 1389 RVA: 0x0000EED4 File Offset: 0x0000D0D4
		public SizeF MeasureString(string text, Font font, int width, StringFormat format)
		{
			RectangleF rectangleF = new RectangleF(0f, 0f, (float)width, 2.1474836E+09f);
			IntPtr stringFormat = (format == null) ? IntPtr.Zero : format.NativeObject;
			return this.GdipMeasureString(this.nativeObject, text, font, ref rectangleF, stringFormat);
		}

		/// <summary>Измеряет указанную строку при ее отображении с заданным шрифтом <see cref="T:System.Drawing.Font" /> и отформатированную с помощью заданного формата <see cref="T:System.Drawing.StringFormat" />.</summary>
		/// <param name="text">Строка для измерения.</param>
		/// <param name="font">Объект <see cref="T:System.Drawing.Font" /> определяет формат текстовой строки.</param>
		/// <param name="origin">Структура <see cref="T:System.Drawing.PointF" />, представляющая расположение верхнего левого угла строки.</param>
		/// <param name="stringFormat">Объект <see cref="T:System.Drawing.StringFormat" />, представляющий сведения о форматировании для строки, например межстрочный интервал.</param>
		/// <returns>Этот метод возвращает структуру <see cref="T:System.Drawing.SizeF" />, представляющую размер в единицах, задаваемых свойством <see cref="P:System.Drawing.Graphics.PageUnit" />, для строки, которая определяется параметром <paramref name="text" /> при отображении с шрифтом <paramref name="font" /> и форматом <paramref name="stringFormat" />.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="font" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600056E RID: 1390 RVA: 0x0000EF20 File Offset: 0x0000D120
		public SizeF MeasureString(string text, Font font, PointF origin, StringFormat stringFormat)
		{
			RectangleF rectangleF = new RectangleF(origin.X, origin.Y, 0f, 0f);
			IntPtr stringFormat2 = (stringFormat == null) ? IntPtr.Zero : stringFormat.NativeObject;
			return this.GdipMeasureString(this.nativeObject, text, font, ref rectangleF, stringFormat2);
		}

		/// <summary>Измеряет указанную строку при ее отображении с заданным шрифтом <see cref="T:System.Drawing.Font" /> и отформатированную с помощью заданного формата <see cref="T:System.Drawing.StringFormat" />.</summary>
		/// <param name="text">Строка для измерения.</param>
		/// <param name="font">Объект <see cref="T:System.Drawing.Font" />, определяющий формат текста строки.</param>
		/// <param name="layoutArea">Структура <see cref="T:System.Drawing.SizeF" />, которая задает максимальную область размещения для текста.</param>
		/// <param name="stringFormat">Объект <see cref="T:System.Drawing.StringFormat" />, представляющий сведения о форматировании для строки, например межстрочный интервал.</param>
		/// <param name="charactersFitted">Количество знаков в строке.</param>
		/// <param name="linesFilled">Количество строк текста в строке.</param>
		/// <returns>Этот метод возвращает структуру <see cref="T:System.Drawing.SizeF" />, представляющую размер строки, в единицах, задаваемых свойством <see cref="P:System.Drawing.Graphics.PageUnit" /> параметра <paramref name="text" />, при отображении с использованием шрифта <paramref name="font" /> и формата <paramref name="stringFormat" />.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="font" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600056F RID: 1391 RVA: 0x0000EF70 File Offset: 0x0000D170
		public unsafe SizeF MeasureString(string text, Font font, SizeF layoutArea, StringFormat stringFormat, out int charactersFitted, out int linesFilled)
		{
			charactersFitted = 0;
			linesFilled = 0;
			if (text == null || text.Length == 0)
			{
				return SizeF.Empty;
			}
			if (font == null)
			{
				throw new ArgumentNullException("font");
			}
			RectangleF rectangleF = default(RectangleF);
			RectangleF rectangleF2 = new RectangleF(0f, 0f, layoutArea.Width, layoutArea.Height);
			IntPtr stringFormat2 = (stringFormat == null) ? IntPtr.Zero : stringFormat.NativeObject;
			fixed (int* ptr = &charactersFitted)
			{
				int* codepointsFitted = ptr;
				fixed (int* ptr2 = &linesFilled)
				{
					int* linesFilled2 = ptr2;
					GDIPlus.CheckStatus(GDIPlus.GdipMeasureString(this.nativeObject, text, text.Length, font.NativeObject, ref rectangleF2, stringFormat2, out rectangleF, codepointsFitted, linesFilled2));
					ptr = null;
				}
				return new SizeF(rectangleF.Width, rectangleF.Height);
			}
		}

		/// <summary>Умножает мировое преобразование данного объекта <see cref="T:System.Drawing.Graphics" /> на указываемый объект <see cref="T:System.Drawing.Drawing2D.Matrix" />.</summary>
		/// <param name="matrix">Матрица <see cref="T:System.Drawing.Drawing2D.Matrix" /> 4x4, на которую умножается мировое преобразование.</param>
		// Token: 0x06000570 RID: 1392 RVA: 0x0000F02F File Offset: 0x0000D22F
		public void MultiplyTransform(Matrix matrix)
		{
			this.MultiplyTransform(matrix, MatrixOrder.Prepend);
		}

		/// <summary>Умножает мировое преобразование данного объекта <see cref="T:System.Drawing.Graphics" /> на указываемый объект <see cref="T:System.Drawing.Drawing2D.Matrix" /> в заданном порядке.</summary>
		/// <param name="matrix">Матрица <see cref="T:System.Drawing.Drawing2D.Matrix" /> 4x4, на которую умножается мировое преобразование.</param>
		/// <param name="order">Член перечисления <see cref="T:System.Drawing.Drawing2D.MatrixOrder" />, определяющий порядок умножения.</param>
		// Token: 0x06000571 RID: 1393 RVA: 0x0000F039 File Offset: 0x0000D239
		public void MultiplyTransform(Matrix matrix, MatrixOrder order)
		{
			if (matrix == null)
			{
				throw new ArgumentNullException("matrix");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipMultiplyWorldTransform(this.nativeObject, matrix.nativeMatrix, order));
		}

		/// <summary>Освобождает дескриптор контекста устройства, полученный в результате предыдущего вызова метода <see cref="M:System.Drawing.Graphics.GetHdc" /> данного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="hdc">Дескриптор контекста устройства, полученный в результате предыдущего вызова метода <see cref="M:System.Drawing.Graphics.GetHdc" /> данного объекта <see cref="T:System.Drawing.Graphics" />.</param>
		// Token: 0x06000572 RID: 1394 RVA: 0x0000F060 File Offset: 0x0000D260
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void ReleaseHdc(IntPtr hdc)
		{
			this.ReleaseHdcInternal(hdc);
		}

		/// <summary>Освобождает дескриптор контекста устройства, полученный в результате предыдущего вызова метода <see cref="M:System.Drawing.Graphics.GetHdc" /> данного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		// Token: 0x06000573 RID: 1395 RVA: 0x0000F069 File Offset: 0x0000D269
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public void ReleaseHdc()
		{
			this.ReleaseHdcInternal(this.deviceContextHdc);
		}

		/// <summary>Освобождает дескриптор контекста устройства.</summary>
		/// <param name="hdc">Дескриптор контекста устройства.</param>
		// Token: 0x06000574 RID: 1396 RVA: 0x0000F078 File Offset: 0x0000D278
		[MonoLimitation("Can only be used when hdc was provided by Graphics.GetHdc() method")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void ReleaseHdcInternal(IntPtr hdc)
		{
			Status status = Status.InvalidParameter;
			if (hdc == this.deviceContextHdc)
			{
				status = GDIPlus.GdipReleaseDC(this.nativeObject, this.deviceContextHdc);
				this.deviceContextHdc = IntPtr.Zero;
			}
			GDIPlus.CheckStatus(status);
		}

		/// <summary>Сбрасывает отсеченную область данного объекта <see cref="T:System.Drawing.Graphics" /> и делает ее бесконечной.</summary>
		// Token: 0x06000575 RID: 1397 RVA: 0x0000F0B8 File Offset: 0x0000D2B8
		public void ResetClip()
		{
			GDIPlus.CheckStatus(GDIPlus.GdipResetClip(this.nativeObject));
		}

		/// <summary>Сбрасывает матрицу мирового преобразования данного объекта <see cref="T:System.Drawing.Graphics" /> и делает ее единичной матрицей.</summary>
		// Token: 0x06000576 RID: 1398 RVA: 0x0000F0CA File Offset: 0x0000D2CA
		public void ResetTransform()
		{
			GDIPlus.CheckStatus(GDIPlus.GdipResetWorldTransform(this.nativeObject));
		}

		/// <summary>Восстанавливает состояние данного объекта <see cref="T:System.Drawing.Graphics" /> в состояние, представленное объектом <see cref="T:System.Drawing.Drawing2D.GraphicsState" />.</summary>
		/// <param name="gstate">Объект <see cref="T:System.Drawing.Drawing2D.GraphicsState" />, представляющий состояние, в которое должен восстанавливаться данный объект <see cref="T:System.Drawing.Graphics" />.</param>
		// Token: 0x06000577 RID: 1399 RVA: 0x0000F0DC File Offset: 0x0000D2DC
		public void Restore(GraphicsState gstate)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipRestoreGraphics(this.nativeObject, (uint)gstate.nativeState));
		}

		/// <summary>Применяет заданный поворот к матрице преобразования данного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="angle">Угол поворота в градусах.</param>
		// Token: 0x06000578 RID: 1400 RVA: 0x0000F0F4 File Offset: 0x0000D2F4
		public void RotateTransform(float angle)
		{
			this.RotateTransform(angle, MatrixOrder.Prepend);
		}

		/// <summary>Применяет заданный поворот к матрице преобразования данного объекта <see cref="T:System.Drawing.Graphics" /> в указанном порядке.</summary>
		/// <param name="angle">Угол поворота в градусах.</param>
		/// <param name="order">Элемент перечисления <see cref="T:System.Drawing.Drawing2D.MatrixOrder" />, который указывает, добавляется ли поворот к началу или к концу матричного преобразования.</param>
		// Token: 0x06000579 RID: 1401 RVA: 0x0000F0FE File Offset: 0x0000D2FE
		public void RotateTransform(float angle, MatrixOrder order)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipRotateWorldTransform(this.nativeObject, angle, order));
		}

		/// <summary>Сохраняет текущее состояние данного объекта <see cref="T:System.Drawing.Graphics" /> и связывает сохраненное состояние с объектом <see cref="T:System.Drawing.Drawing2D.GraphicsState" />.</summary>
		/// <returns>Этот метод возвращает объект <see cref="T:System.Drawing.Drawing2D.GraphicsState" />, который представляет сохраненное состояние данного объекта <see cref="T:System.Drawing.Graphics" />.</returns>
		// Token: 0x0600057A RID: 1402 RVA: 0x0000F114 File Offset: 0x0000D314
		public GraphicsState Save()
		{
			uint nativeState;
			GDIPlus.CheckStatus(GDIPlus.GdipSaveGraphics(this.nativeObject, out nativeState));
			return new GraphicsState((int)nativeState);
		}

		/// <summary>Применяет заданную операцию масштабирования к матрице преобразования данного объекта <see cref="T:System.Drawing.Graphics" /> путем ее добавления перед матрицей преобразования объекта.</summary>
		/// <param name="sx">Коэффициент масштабирования по оси X.</param>
		/// <param name="sy">Коэффициент масштабирования по оси Y.</param>
		// Token: 0x0600057B RID: 1403 RVA: 0x0000F139 File Offset: 0x0000D339
		public void ScaleTransform(float sx, float sy)
		{
			this.ScaleTransform(sx, sy, MatrixOrder.Prepend);
		}

		/// <summary>Применяет заданную операцию масштабирования к матрице преобразования данного объекта <see cref="T:System.Drawing.Graphics" /> в указанном порядке.</summary>
		/// <param name="sx">Коэффициент масштабирования по оси X.</param>
		/// <param name="sy">Коэффициент масштабирования по оси Y.</param>
		/// <param name="order">Элемент перечисления <see cref="T:System.Drawing.Drawing2D.MatrixOrder" />, указывающий порядок добавления операции масштабирования: перед матрицей преобразования или после нее.</param>
		// Token: 0x0600057C RID: 1404 RVA: 0x0000F144 File Offset: 0x0000D344
		public void ScaleTransform(float sx, float sy, MatrixOrder order)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipScaleWorldTransform(this.nativeObject, sx, sy, order));
		}

		/// <summary>Задает в качестве отсеченной области данного объекта <see cref="T:System.Drawing.Graphics" /> прямоугольник, задаваемый структурой <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.RectangleF" />, представляющая новую отсеченную область.</param>
		// Token: 0x0600057D RID: 1405 RVA: 0x0000F159 File Offset: 0x0000D359
		public void SetClip(RectangleF rect)
		{
			this.SetClip(rect, CombineMode.Replace);
		}

		/// <summary>Задает в качестве отсеченной области данного объекта <see cref="T:System.Drawing.Graphics" /> указанный объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <param name="path">Объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />, содержащий новую вырезанную область.</param>
		// Token: 0x0600057E RID: 1406 RVA: 0x0000F163 File Offset: 0x0000D363
		public void SetClip(GraphicsPath path)
		{
			this.SetClip(path, CombineMode.Replace);
		}

		/// <summary>Задает в качестве отсеченной области данного объекта <see cref="T:System.Drawing.Graphics" /> прямоугольник, задаваемый структурой <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.Rectangle" />, представляющая новую отсеченную область.</param>
		// Token: 0x0600057F RID: 1407 RVA: 0x0000F16D File Offset: 0x0000D36D
		public void SetClip(Rectangle rect)
		{
			this.SetClip(rect, CombineMode.Replace);
		}

		/// <summary>Задает в качестве отсеченной области данного объекта <see cref="T:System.Drawing.Graphics" /> значение свойства <see langword="Clip" /> указанного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="g">Объект <see cref="T:System.Drawing.Graphics" />, из которого извлекается новая отсеченная область.</param>
		// Token: 0x06000580 RID: 1408 RVA: 0x0000F177 File Offset: 0x0000D377
		public void SetClip(Graphics g)
		{
			this.SetClip(g, CombineMode.Replace);
		}

		/// <summary>Задает в качестве отсеченной области данного объекта <see cref="T:System.Drawing.Graphics" /> результат указанной операции объединения текущей отсеченной области и свойства <see cref="P:System.Drawing.Graphics.Clip" /> заданного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="g">Объект <see cref="T:System.Drawing.Graphics" />, который задает отсеченную область для объединения.</param>
		/// <param name="combineMode">Элемент перечисления <see cref="T:System.Drawing.Drawing2D.CombineMode" />, задающий используемую операцию объединения.</param>
		// Token: 0x06000581 RID: 1409 RVA: 0x0000F181 File Offset: 0x0000D381
		public void SetClip(Graphics g, CombineMode combineMode)
		{
			if (g == null)
			{
				throw new ArgumentNullException("g");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipSetClipGraphics(this.nativeObject, g.NativeObject, combineMode));
		}

		/// <summary>Задает в качестве отсеченной области данного объекта <see cref="T:System.Drawing.Graphics" /> результат указанной операции объединения текущей отсеченной области и прямоугольника, задаваемого структурой <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.Rectangle" /> для объединения.</param>
		/// <param name="combineMode">Элемент перечисления <see cref="T:System.Drawing.Drawing2D.CombineMode" />, задающий используемую операцию объединения.</param>
		// Token: 0x06000582 RID: 1410 RVA: 0x0000F1A8 File Offset: 0x0000D3A8
		public void SetClip(Rectangle rect, CombineMode combineMode)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipSetClipRectI(this.nativeObject, rect.X, rect.Y, rect.Width, rect.Height, combineMode));
		}

		/// <summary>Задает в качестве отсеченной области данного объекта <see cref="T:System.Drawing.Graphics" /> результат указанной операции объединения текущей отсеченной области и прямоугольника, задаваемого структурой <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.RectangleF" /> для объединения.</param>
		/// <param name="combineMode">Элемент перечисления <see cref="T:System.Drawing.Drawing2D.CombineMode" />, задающий используемую операцию объединения.</param>
		// Token: 0x06000583 RID: 1411 RVA: 0x0000F1D7 File Offset: 0x0000D3D7
		public void SetClip(RectangleF rect, CombineMode combineMode)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipSetClipRect(this.nativeObject, rect.X, rect.Y, rect.Width, rect.Height, combineMode));
		}

		/// <summary>Задает в качестве отсеченной области данного объекта <see cref="T:System.Drawing.Graphics" /> результат указанной операции объединения текущей отсеченной области и заданной области <see cref="T:System.Drawing.Region" />.</summary>
		/// <param name="region">Область <see cref="T:System.Drawing.Region" /> для объединения.</param>
		/// <param name="combineMode">Элемент из перечисления <see cref="T:System.Drawing.Drawing2D.CombineMode" />, задающий используемую операцию объединения.</param>
		// Token: 0x06000584 RID: 1412 RVA: 0x0000F206 File Offset: 0x0000D406
		public void SetClip(Region region, CombineMode combineMode)
		{
			if (region == null)
			{
				throw new ArgumentNullException("region");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipSetClipRegion(this.nativeObject, region.NativeObject, combineMode));
		}

		/// <summary>Задает в качестве отсеченной области данного объекта <see cref="T:System.Drawing.Graphics" /> результат указанной операции объединения текущей отсеченной области и заданной области <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <param name="path">Область <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> для объединения.</param>
		/// <param name="combineMode">Элемент перечисления <see cref="T:System.Drawing.Drawing2D.CombineMode" />, задающий используемую операцию объединения.</param>
		// Token: 0x06000585 RID: 1413 RVA: 0x0000F22D File Offset: 0x0000D42D
		public void SetClip(GraphicsPath path, CombineMode combineMode)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipSetClipPath(this.nativeObject, path.nativePath, combineMode));
		}

		/// <summary>Преобразует массив точек из одной системы координат в другую, используя текущие мировое и страничное преобразования данного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="destSpace">Элемент перечисления <see cref="T:System.Drawing.Drawing2D.CoordinateSpace" />, задающий целевую систему координат.</param>
		/// <param name="srcSpace">Элемент перечисления <see cref="T:System.Drawing.Drawing2D.CoordinateSpace" />, задающий исходную систему координат.</param>
		/// <param name="pts">Массив структур <see cref="T:System.Drawing.PointF" />, которые представляют точки для преобразования.</param>
		// Token: 0x06000586 RID: 1414 RVA: 0x0000F254 File Offset: 0x0000D454
		public void TransformPoints(CoordinateSpace destSpace, CoordinateSpace srcSpace, PointF[] pts)
		{
			if (pts == null)
			{
				throw new ArgumentNullException("pts");
			}
			IntPtr intPtr = GDIPlus.FromPointToUnManagedMemory(pts);
			GDIPlus.CheckStatus(GDIPlus.GdipTransformPoints(this.nativeObject, destSpace, srcSpace, intPtr, pts.Length));
			GDIPlus.FromUnManagedMemoryToPoint(intPtr, pts);
		}

		/// <summary>Преобразует массив точек из одной системы координат в другую, используя текущие мировое и страничное преобразования данного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="destSpace">Элемент перечисления <see cref="T:System.Drawing.Drawing2D.CoordinateSpace" />, задающий целевую систему координат.</param>
		/// <param name="srcSpace">Элемент перечисления <see cref="T:System.Drawing.Drawing2D.CoordinateSpace" />, задающий исходную систему координат.</param>
		/// <param name="pts">Массив структур <see cref="T:System.Drawing.Point" />, которые представляют точки для преобразования.</param>
		// Token: 0x06000587 RID: 1415 RVA: 0x0000F294 File Offset: 0x0000D494
		public void TransformPoints(CoordinateSpace destSpace, CoordinateSpace srcSpace, Point[] pts)
		{
			if (pts == null)
			{
				throw new ArgumentNullException("pts");
			}
			IntPtr intPtr = GDIPlus.FromPointToUnManagedMemoryI(pts);
			GDIPlus.CheckStatus(GDIPlus.GdipTransformPointsI(this.nativeObject, destSpace, srcSpace, intPtr, pts.Length));
			GDIPlus.FromUnManagedMemoryToPointI(intPtr, pts);
		}

		/// <summary>Сдвигает отсеченную область данного объекта <see cref="T:System.Drawing.Graphics" /> на указанные значения в горизонтальном и вертикальном направлениях.</summary>
		/// <param name="dx">Координата X сдвига.</param>
		/// <param name="dy">Координата Y сдвига.</param>
		// Token: 0x06000588 RID: 1416 RVA: 0x0000F2D3 File Offset: 0x0000D4D3
		public void TranslateClip(int dx, int dy)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipTranslateClipI(this.nativeObject, dx, dy));
		}

		/// <summary>Сдвигает отсеченную область данного объекта <see cref="T:System.Drawing.Graphics" /> на указанные значения в горизонтальном и вертикальном направлениях.</summary>
		/// <param name="dx">Координата X сдвига.</param>
		/// <param name="dy">Координата Y сдвига.</param>
		// Token: 0x06000589 RID: 1417 RVA: 0x0000F2E7 File Offset: 0x0000D4E7
		public void TranslateClip(float dx, float dy)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipTranslateClip(this.nativeObject, dx, dy));
		}

		/// <summary>Изменяет начало системы координат путем добавления заданного сдвига перед матрицей преобразования данного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="dx">Координата X сдвига.</param>
		/// <param name="dy">Координата Y сдвига.</param>
		// Token: 0x0600058A RID: 1418 RVA: 0x0000F2FB File Offset: 0x0000D4FB
		public void TranslateTransform(float dx, float dy)
		{
			this.TranslateTransform(dx, dy, MatrixOrder.Prepend);
		}

		/// <summary>Изменяет начало системы координат путем применения заданного сдвига к матрице преобразования данного объекта <see cref="T:System.Drawing.Graphics" /> в указанном порядке.</summary>
		/// <param name="dx">Координата X сдвига.</param>
		/// <param name="dy">Координата Y сдвига.</param>
		/// <param name="order">Элемент перечисления <see cref="T:System.Drawing.Drawing2D.MatrixOrder" />, задающий порядок добавления сдвига к матрице преобразования: перед матрицей или после нее.</param>
		// Token: 0x0600058B RID: 1419 RVA: 0x0000F306 File Offset: 0x0000D506
		public void TranslateTransform(float dx, float dy, MatrixOrder order)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipTranslateWorldTransform(this.nativeObject, dx, dy, order));
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Drawing.Region" />, ограничивающий область рисования данного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Region" />, ограничивающий часть данного объекта <see cref="T:System.Drawing.Graphics" />, доступную для рисования в текущий момент.</returns>
		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x0000F31C File Offset: 0x0000D51C
		// (set) Token: 0x0600058D RID: 1421 RVA: 0x0000F346 File Offset: 0x0000D546
		public Region Clip
		{
			get
			{
				Region region = new Region();
				GDIPlus.CheckStatus(GDIPlus.GdipGetClip(this.nativeObject, region.NativeObject));
				return region;
			}
			set
			{
				this.SetClip(value, CombineMode.Replace);
			}
		}

		/// <summary>Возвращает структуру <see cref="T:System.Drawing.RectangleF" />, которая  ограничивает отсеченную область данного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <returns>Структура <see cref="T:System.Drawing.RectangleF" />, представляющая ограничивающий прямоугольник для отсеченной области данного объекта <see cref="T:System.Drawing.Graphics" />.</returns>
		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x0000F350 File Offset: 0x0000D550
		public RectangleF ClipBounds
		{
			get
			{
				RectangleF result = default(RectangleF);
				GDIPlus.CheckStatus(GDIPlus.GdipGetClipBounds(this.nativeObject, out result));
				return result;
			}
		}

		/// <summary>Возвращает значение, задающее способ рисования составных изображений в данном объекте <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <returns>Это свойство задает элемент перечисления <see cref="T:System.Drawing.Drawing2D.CompositingMode" />. Значение по умолчанию — <see cref="F:System.Drawing.Drawing2D.CompositingMode.SourceOver" />.</returns>
		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x0000F378 File Offset: 0x0000D578
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x0000F398 File Offset: 0x0000D598
		public CompositingMode CompositingMode
		{
			get
			{
				CompositingMode result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetCompositingMode(this.nativeObject, out result));
				return result;
			}
			set
			{
				GDIPlus.CheckStatus(GDIPlus.GdipSetCompositingMode(this.nativeObject, value));
			}
		}

		/// <summary>Возвращает или задает качество отрисовки составных изображений, которые формируются в данном объекте <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <returns>Это свойство задает элемент перечисления <see cref="T:System.Drawing.Drawing2D.CompositingQuality" />. Значение по умолчанию — <see cref="F:System.Drawing.Drawing2D.CompositingQuality.Default" />.</returns>
		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x0000F3AC File Offset: 0x0000D5AC
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x0000F3CC File Offset: 0x0000D5CC
		public CompositingQuality CompositingQuality
		{
			get
			{
				CompositingQuality result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetCompositingQuality(this.nativeObject, out result));
				return result;
			}
			set
			{
				GDIPlus.CheckStatus(GDIPlus.GdipSetCompositingQuality(this.nativeObject, value));
			}
		}

		/// <summary>Возвращает горизонтальное разрешение данного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <returns>Значение горизонтального разрешения в точках на дюйм, поддерживаемое данным объектом <see cref="T:System.Drawing.Graphics" />.</returns>
		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x0000F3E0 File Offset: 0x0000D5E0
		public float DpiX
		{
			get
			{
				float result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetDpiX(this.nativeObject, out result));
				return result;
			}
		}

		/// <summary>Возвращает вертикальное разрешение данного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <returns>Значение вертикального разрешения в точках на дюйм, поддерживаемое данным объектом <see cref="T:System.Drawing.Graphics" />.</returns>
		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x0000F400 File Offset: 0x0000D600
		public float DpiY
		{
			get
			{
				float result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetDpiY(this.nativeObject, out result));
				return result;
			}
		}

		/// <summary>Возвращает или задает режим интерполяции, связанный с данным объектом <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Drawing.Drawing2D.InterpolationMode" />.</returns>
		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x0000F420 File Offset: 0x0000D620
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x0000F442 File Offset: 0x0000D642
		public InterpolationMode InterpolationMode
		{
			get
			{
				InterpolationMode result = InterpolationMode.Invalid;
				GDIPlus.CheckStatus(GDIPlus.GdipGetInterpolationMode(this.nativeObject, out result));
				return result;
			}
			set
			{
				GDIPlus.CheckStatus(GDIPlus.GdipSetInterpolationMode(this.nativeObject, value));
			}
		}

		/// <summary>Возвращает значение, которое указывает, является ли отсеченная область данного объекта <see cref="T:System.Drawing.Graphics" /> пустой.</summary>
		/// <returns>Значение <see langword="true" />, если вырезанная область данного объекта <see cref="T:System.Drawing.Graphics" /> является пустой; в противном случае устанавливается значение <see langword="false" />.</returns>
		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x0000F458 File Offset: 0x0000D658
		public bool IsClipEmpty
		{
			get
			{
				bool result = false;
				GDIPlus.CheckStatus(GDIPlus.GdipIsClipEmpty(this.nativeObject, out result));
				return result;
			}
		}

		/// <summary>Возвращает значение, которое указывает, является ли видимая отсеченная область данного объекта <see cref="T:System.Drawing.Graphics" /> пустой.</summary>
		/// <returns>Значение <see langword="true" />, если видимая часть отсеченной области данного объекта <see cref="T:System.Drawing.Graphics" /> является пустой; в противном случае значение <see langword="false" />.</returns>
		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x0000F47C File Offset: 0x0000D67C
		public bool IsVisibleClipEmpty
		{
			get
			{
				bool result = false;
				GDIPlus.CheckStatus(GDIPlus.GdipIsVisibleClipEmpty(this.nativeObject, out result));
				return result;
			}
		}

		/// <summary>Возвращает или задает масштабирование между мировыми и страничными единицами измерения для данного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <returns>Это свойство задает значение для масштабирования между мировыми и страничными единицами измерения для данного объекта <see cref="T:System.Drawing.Graphics" />.</returns>
		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x0000F4A0 File Offset: 0x0000D6A0
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x0000F4C0 File Offset: 0x0000D6C0
		public float PageScale
		{
			get
			{
				float result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPageScale(this.nativeObject, out result));
				return result;
			}
			set
			{
				GDIPlus.CheckStatus(GDIPlus.GdipSetPageScale(this.nativeObject, value));
			}
		}

		/// <summary>Возвращает или задает единицу измерения для страничных координат в данном объекте <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <returns>Одно из значений единиц измерения <see cref="T:System.Drawing.GraphicsUnit" />, отличное от <see cref="F:System.Drawing.GraphicsUnit.World" />.</returns>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">Объект <see cref="P:System.Drawing.Graphics.PageUnit" /> устанавливается равным значению <see cref="F:System.Drawing.GraphicsUnit.World" />, которое не является физической единицей измерения.</exception>
		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x0000F4D4 File Offset: 0x0000D6D4
		// (set) Token: 0x0600059C RID: 1436 RVA: 0x0000F4F4 File Offset: 0x0000D6F4
		public GraphicsUnit PageUnit
		{
			get
			{
				GraphicsUnit result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPageUnit(this.nativeObject, out result));
				return result;
			}
			set
			{
				GDIPlus.CheckStatus(GDIPlus.GdipSetPageUnit(this.nativeObject, value));
			}
		}

		/// <summary>Получает или задает значение, которое задает порядок смещения пикселей во время отрисовки данного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <returns>Это свойство задает элемент перечисления <see cref="T:System.Drawing.Drawing2D.PixelOffsetMode" />.</returns>
		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x0000F508 File Offset: 0x0000D708
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x0000F52A File Offset: 0x0000D72A
		[MonoTODO("This property does not do anything when used with libgdiplus.")]
		public PixelOffsetMode PixelOffsetMode
		{
			get
			{
				PixelOffsetMode result = PixelOffsetMode.Invalid;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPixelOffsetMode(this.nativeObject, out result));
				return result;
			}
			set
			{
				GDIPlus.CheckStatus(GDIPlus.GdipSetPixelOffsetMode(this.nativeObject, value));
			}
		}

		/// <summary>Возвращает или задает начало координат при отрисовке данного объекта <see cref="T:System.Drawing.Graphics" /> для сглаживания и для кистей штриховки.</summary>
		/// <returns>Структура <see cref="T:System.Drawing.Point" />, которая представляет начало координат для сглаживания с параметром 8 бит на пиксель и 16 бит на пиксель, а также используется для настройки начала координат кистей штриховки.</returns>
		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x0000F540 File Offset: 0x0000D740
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x0000F568 File Offset: 0x0000D768
		public Point RenderingOrigin
		{
			get
			{
				int x;
				int y;
				GDIPlus.CheckStatus(GDIPlus.GdipGetRenderingOrigin(this.nativeObject, out x, out y));
				return new Point(x, y);
			}
			set
			{
				GDIPlus.CheckStatus(GDIPlus.GdipSetRenderingOrigin(this.nativeObject, value.X, value.Y));
			}
		}

		/// <summary>Возвращает или задает качество отрисовки данного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Drawing.Drawing2D.SmoothingMode" />.</returns>
		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x0000F588 File Offset: 0x0000D788
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x0000F5AA File Offset: 0x0000D7AA
		public SmoothingMode SmoothingMode
		{
			get
			{
				SmoothingMode result = SmoothingMode.Invalid;
				GDIPlus.CheckStatus(GDIPlus.GdipGetSmoothingMode(this.nativeObject, out result));
				return result;
			}
			set
			{
				GDIPlus.CheckStatus(GDIPlus.GdipSetSmoothingMode(this.nativeObject, value));
			}
		}

		/// <summary>Возвращает или задает значение гамма-коррекции для отрисовки текста.</summary>
		/// <returns>Значение гамма-коррекции, используемое для отрисовки сглаженного текста и текста ClearType.</returns>
		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x0000F5C0 File Offset: 0x0000D7C0
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x0000F5E0 File Offset: 0x0000D7E0
		[MonoTODO("This property does not do anything when used with libgdiplus.")]
		public int TextContrast
		{
			get
			{
				int result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetTextContrast(this.nativeObject, out result));
				return result;
			}
			set
			{
				GDIPlus.CheckStatus(GDIPlus.GdipSetTextContrast(this.nativeObject, value));
			}
		}

		/// <summary>Возвращает или задает режим отрисовки для текста, связанного с данным объектом <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Drawing.Text.TextRenderingHint" />.</returns>
		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x0000F5F4 File Offset: 0x0000D7F4
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x0000F614 File Offset: 0x0000D814
		public TextRenderingHint TextRenderingHint
		{
			get
			{
				TextRenderingHint result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetTextRenderingHint(this.nativeObject, out result));
				return result;
			}
			set
			{
				GDIPlus.CheckStatus(GDIPlus.GdipSetTextRenderingHint(this.nativeObject, value));
			}
		}

		/// <summary>Возвращает или задает копию геометрического мирового преобразования для данного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <returns>Копия матрицы <see cref="T:System.Drawing.Drawing2D.Matrix" />, которая представляет геометрическое мировое преобразование для данного объекта <see cref="T:System.Drawing.Graphics" />.</returns>
		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x0000F628 File Offset: 0x0000D828
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x0000F652 File Offset: 0x0000D852
		public Matrix Transform
		{
			get
			{
				Matrix matrix = new Matrix();
				GDIPlus.CheckStatus(GDIPlus.GdipGetWorldTransform(this.nativeObject, matrix.nativeMatrix));
				return matrix;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				GDIPlus.CheckStatus(GDIPlus.GdipSetWorldTransform(this.nativeObject, value.nativeMatrix));
			}
		}

		/// <summary>Возвращает ограничивающий прямоугольник видимой отсеченной области данного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <returns>Структура <see cref="T:System.Drawing.RectangleF" />, представляющая ограничивающий прямоугольник для видимой отсеченной области данного объекта <see cref="T:System.Drawing.Graphics" />.</returns>
		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x0000F678 File Offset: 0x0000D878
		public RectangleF VisibleClipBounds
		{
			get
			{
				RectangleF result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetVisibleClipBounds(this.nativeObject, out result));
				return result;
			}
		}

		/// <summary>Возвращает кумулятивный контекст графики.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий кумулятивный контекст графики.</returns>
		// Token: 0x060005AA RID: 1450 RVA: 0x00009B6A File Offset: 0x00007D6A
		[MonoTODO]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object GetContextInfo()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00005B7D File Offset: 0x00003D7D
		internal Graphics()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04000494 RID: 1172
		internal IntPtr nativeObject;

		// Token: 0x04000495 RID: 1173
		internal IMacContext maccontext;

		// Token: 0x04000496 RID: 1174
		private bool disposed;

		// Token: 0x04000497 RID: 1175
		private static float defDpiX;

		// Token: 0x04000498 RID: 1176
		private static float defDpiY;

		// Token: 0x04000499 RID: 1177
		private IntPtr deviceContextHdc;

		// Token: 0x0400049A RID: 1178
		private Metafile.MetafileHolder _metafileHolder;

		// Token: 0x0400049B RID: 1179
		private const string MetafileEnumeration = "Metafiles enumeration, for both WMF and EMF formats, isn't supported.";

		/// <summary>Предоставляет метод обратного вызова для метода <see cref="Overload:System.Drawing.Graphics.EnumerateMetafile" />.</summary>
		/// <param name="recordType">Элемент перечисления <see cref="T:System.Drawing.Imaging.EmfPlusRecordType" />, задающий тип записи метафайла.</param>
		/// <param name="flags">Набор флагов, определяющих атрибуты записи.</param>
		/// <param name="dataSize">Число байтов в данных записи.</param>
		/// <param name="data">Указатель на буфер, содержащий данные записи.</param>
		/// <param name="callbackData">Не используется.</param>
		/// <returns>Возвратите значение <see langword="true" />, если нужно продолжить перечисление записей, в противном случае возвратите значение <see langword="false" />.</returns>
		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x060005AD RID: 1453
		public delegate bool EnumerateMetafileProc(EmfPlusRecordType recordType, int flags, int dataSize, IntPtr data, PlayRecordCallback callbackData);

		/// <summary>Предоставляет метод обратного вызова, используемый в случае, когда метод <see cref="Overload:System.Drawing.Graphics.DrawImage" /> должен преждевременно отменить выполнение и прекратить рисование изображения.</summary>
		/// <param name="callbackdata">Внутренний указатель, определяющий данные для метода обратного вызова. Этот параметр не передается всеми перегруженными членами <see cref="Overload:System.Drawing.Graphics.DrawImage" />. Проверить, отсутствует ли этот параметр, можно путем проверки значения <see cref="F:System.IntPtr.Zero" />.</param>
		/// <returns>Данный метод возвращает значение <see langword="true" />, если принимается решение, что метод <see cref="Overload:System.Drawing.Graphics.DrawImage" /> должен преждевременно прекратить выполнение. В противном случае возвращается значение <see langword="false" />, указывающее на необходимость продолжения выполнения метода <see cref="Overload:System.Drawing.Graphics.DrawImage" />.</returns>
		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x060005B1 RID: 1457
		public delegate bool DrawImageAbort(IntPtr callbackdata);
	}
}
