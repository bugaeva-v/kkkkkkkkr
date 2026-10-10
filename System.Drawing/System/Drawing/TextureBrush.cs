using System;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace System.Drawing
{
	/// <summary>Каждое свойство класса <see cref="T:System.Drawing.TextureBrush" /> является объектом <see cref="T:System.Drawing.Brush" />, использующим изображение для заливки внутренней части формы. Этот класс не наследуется.</summary>
	// Token: 0x02000042 RID: 66
	public sealed class TextureBrush : Brush
	{
		/// <summary>Инициализирует новый объект <see cref="T:System.Drawing.TextureBrush" />, использующий указанное изображение.</summary>
		/// <param name="bitmap">Объект <see cref="T:System.Drawing.Image" />, с помощью которого объект <see cref="T:System.Drawing.TextureBrush" /> выполняет заливку внутренней части.</param>
		// Token: 0x06000144 RID: 324 RVA: 0x00005CBA File Offset: 0x00003EBA
		public TextureBrush(Image bitmap) : this(bitmap, WrapMode.Tile)
		{
		}

		/// <summary>Инициализирует новый объект <see cref="T:System.Drawing.TextureBrush" />, использующий указанное изображение и режим переноса.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" />, с помощью которого объект <see cref="T:System.Drawing.TextureBrush" /> выполняет заливку внутренней части.</param>
		/// <param name="wrapMode">Перечисление <see cref="T:System.Drawing.Drawing2D.WrapMode" />, указывающее способ наложения объекта <see cref="T:System.Drawing.TextureBrush" />.</param>
		// Token: 0x06000145 RID: 325 RVA: 0x00005CC4 File Offset: 0x00003EC4
		public TextureBrush(Image image, WrapMode wrapMode)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			if (wrapMode < WrapMode.Tile || wrapMode > WrapMode.Clamp)
			{
				throw new InvalidEnumArgumentException("wrapMode", (int)wrapMode, typeof(WrapMode));
			}
			IntPtr zero = IntPtr.Zero;
			SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipCreateTexture(new HandleRef(image, image.nativeImage), (int)wrapMode, out zero));
			base.SetNativeBrushInternal(zero);
		}

		/// <summary>Инициализирует новый объект <see cref="T:System.Drawing.TextureBrush" />, использующий указанное изображение, режим переноса и ограничивающий прямоугольник.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" />, с помощью которого объект <see cref="T:System.Drawing.TextureBrush" /> выполняет заливку внутренней части.</param>
		/// <param name="wrapMode">Перечисление <see cref="T:System.Drawing.Drawing2D.WrapMode" />, указывающее способ наложения объекта <see cref="T:System.Drawing.TextureBrush" />.</param>
		/// <param name="dstRect">Структура <see cref="T:System.Drawing.RectangleF" />, представляющая ограничивающий прямоугольник для объекта <see cref="T:System.Drawing.TextureBrush" />.</param>
		// Token: 0x06000146 RID: 326 RVA: 0x00005D2C File Offset: 0x00003F2C
		public TextureBrush(Image image, WrapMode wrapMode, RectangleF dstRect)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			if (wrapMode < WrapMode.Tile || wrapMode > WrapMode.Clamp)
			{
				throw new InvalidEnumArgumentException("wrapMode", (int)wrapMode, typeof(WrapMode));
			}
			IntPtr zero = IntPtr.Zero;
			SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipCreateTexture2(new HandleRef(image, image.nativeImage), (int)wrapMode, dstRect.X, dstRect.Y, dstRect.Width, dstRect.Height, out zero));
			base.SetNativeBrushInternal(zero);
		}

		/// <summary>Инициализирует новый объект <see cref="T:System.Drawing.TextureBrush" />, использующий указанное изображение, режим переноса и ограничивающий прямоугольник.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" />, с помощью которого объект <see cref="T:System.Drawing.TextureBrush" /> выполняет заливку внутренней части.</param>
		/// <param name="wrapMode">Перечисление <see cref="T:System.Drawing.Drawing2D.WrapMode" />, указывающее способ наложения объекта <see cref="T:System.Drawing.TextureBrush" />.</param>
		/// <param name="dstRect">Структура <see cref="T:System.Drawing.Rectangle" />, представляющая ограничивающий прямоугольник для объекта <see cref="T:System.Drawing.TextureBrush" />.</param>
		// Token: 0x06000147 RID: 327 RVA: 0x00005DB0 File Offset: 0x00003FB0
		public TextureBrush(Image image, WrapMode wrapMode, Rectangle dstRect)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			if (wrapMode < WrapMode.Tile || wrapMode > WrapMode.Clamp)
			{
				throw new InvalidEnumArgumentException("wrapMode", (int)wrapMode, typeof(WrapMode));
			}
			IntPtr zero = IntPtr.Zero;
			SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipCreateTexture2I(new HandleRef(image, image.nativeImage), (int)wrapMode, dstRect.X, dstRect.Y, dstRect.Width, dstRect.Height, out zero));
			base.SetNativeBrushInternal(zero);
		}

		/// <summary>Инициализирует новый объект <see cref="T:System.Drawing.TextureBrush" />, использующий указанное изображение и ограничивающий прямоугольник.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" />, с помощью которого объект <see cref="T:System.Drawing.TextureBrush" /> выполняет заливку внутренней части.</param>
		/// <param name="dstRect">Структура <see cref="T:System.Drawing.RectangleF" />, представляющая ограничивающий прямоугольник для объекта <see cref="T:System.Drawing.TextureBrush" />.</param>
		// Token: 0x06000148 RID: 328 RVA: 0x00005E31 File Offset: 0x00004031
		public TextureBrush(Image image, RectangleF dstRect) : this(image, dstRect, null)
		{
		}

		/// <summary>Инициализирует новый объект <see cref="T:System.Drawing.TextureBrush" />, использующий указанное изображение, ограничивающий прямоугольник и атрибуты изображения.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" />, с помощью которого объект <see cref="T:System.Drawing.TextureBrush" /> выполняет заливку внутренней части.</param>
		/// <param name="dstRect">Структура <see cref="T:System.Drawing.RectangleF" />, представляющая ограничивающий прямоугольник для объекта <see cref="T:System.Drawing.TextureBrush" />.</param>
		/// <param name="imageAttr">Объект <see cref="T:System.Drawing.Imaging.ImageAttributes" />, содержащий дополнительные сведения об изображении, используемом объектом <see cref="T:System.Drawing.TextureBrush" />.</param>
		// Token: 0x06000149 RID: 329 RVA: 0x00005E3C File Offset: 0x0000403C
		public TextureBrush(Image image, RectangleF dstRect, ImageAttributes imageAttr)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			IntPtr zero = IntPtr.Zero;
			SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipCreateTextureIA(new HandleRef(image, image.nativeImage), new HandleRef(imageAttr, (imageAttr == null) ? IntPtr.Zero : imageAttr.nativeImageAttributes), dstRect.X, dstRect.Y, dstRect.Width, dstRect.Height, out zero));
			base.SetNativeBrushInternal(zero);
		}

		/// <summary>Инициализирует новый объект <see cref="T:System.Drawing.TextureBrush" />, использующий указанное изображение и ограничивающий прямоугольник.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" />, с помощью которого объект <see cref="T:System.Drawing.TextureBrush" /> выполняет заливку внутренней части.</param>
		/// <param name="dstRect">Структура <see cref="T:System.Drawing.Rectangle" />, представляющая ограничивающий прямоугольник для объекта <see cref="T:System.Drawing.TextureBrush" />.</param>
		// Token: 0x0600014A RID: 330 RVA: 0x00005EB4 File Offset: 0x000040B4
		public TextureBrush(Image image, Rectangle dstRect) : this(image, dstRect, null)
		{
		}

		/// <summary>Инициализирует новый объект <see cref="T:System.Drawing.TextureBrush" />, использующий указанное изображение, ограничивающий прямоугольник и атрибуты изображения.</summary>
		/// <param name="image">Объект <see cref="T:System.Drawing.Image" />, с помощью которого объект <see cref="T:System.Drawing.TextureBrush" /> выполняет заливку внутренней части.</param>
		/// <param name="dstRect">Структура <see cref="T:System.Drawing.Rectangle" />, представляющая ограничивающий прямоугольник для объекта <see cref="T:System.Drawing.TextureBrush" />.</param>
		/// <param name="imageAttr">Объект <see cref="T:System.Drawing.Imaging.ImageAttributes" />, содержащий дополнительные сведения об изображении, используемом объектом <see cref="T:System.Drawing.TextureBrush" />.</param>
		// Token: 0x0600014B RID: 331 RVA: 0x00005EC0 File Offset: 0x000040C0
		public TextureBrush(Image image, Rectangle dstRect, ImageAttributes imageAttr)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			IntPtr zero = IntPtr.Zero;
			SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipCreateTextureIAI(new HandleRef(image, image.nativeImage), new HandleRef(imageAttr, (imageAttr == null) ? IntPtr.Zero : imageAttr.nativeImageAttributes), dstRect.X, dstRect.Y, dstRect.Width, dstRect.Height, out zero));
			base.SetNativeBrushInternal(zero);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00005F38 File Offset: 0x00004138
		internal TextureBrush(IntPtr nativeBrush)
		{
			base.SetNativeBrushInternal(nativeBrush);
		}

		/// <summary>Создает точную копию объекта <see cref="T:System.Drawing.TextureBrush" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.TextureBrush" />, созданный данным методом, используется как объект <see cref="T:System.Object" />.</returns>
		// Token: 0x0600014D RID: 333 RVA: 0x00005F48 File Offset: 0x00004148
		public override object Clone()
		{
			IntPtr zero = IntPtr.Zero;
			SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipCloneBrush(new HandleRef(this, base.NativeBrush), out zero));
			return new TextureBrush(zero);
		}

		/// <summary>Получает или задает копию объекта <see cref="T:System.Drawing.Drawing2D.Matrix" />, определяющую локальное геометрическое преобразование для изображения, связанного с объектом <see cref="T:System.Drawing.TextureBrush" />.</summary>
		/// <returns>Копия объекта <see cref="T:System.Drawing.Drawing2D.Matrix" />, определяющего геометрическое преобразование, применяемое только для тех участков, заливка которых выполнена с использованием объекта <see cref="T:System.Drawing.TextureBrush" />.</returns>
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00005F7C File Offset: 0x0000417C
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00005FB2 File Offset: 0x000041B2
		public Matrix Transform
		{
			get
			{
				Matrix matrix = new Matrix();
				SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipGetTextureTransform(new HandleRef(this, base.NativeBrush), new HandleRef(matrix, matrix.nativeMatrix)));
				return matrix;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipSetTextureTransform(new HandleRef(this, base.NativeBrush), new HandleRef(value, value.nativeMatrix)));
			}
		}

		/// <summary>Получает или задает перечисление <see cref="T:System.Drawing.Drawing2D.WrapMode" />, задающее режим переноса для объекта <see cref="T:System.Drawing.TextureBrush" />.</summary>
		/// <returns>Перечисление <see cref="T:System.Drawing.Drawing2D.WrapMode" />, указывающее, как покрывается мозаикой заливка, выполненная с помощью объекта <see cref="T:System.Drawing.Drawing2D.LinearGradientBrush" />.</returns>
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00005FE4 File Offset: 0x000041E4
		// (set) Token: 0x06000151 RID: 337 RVA: 0x0000600C File Offset: 0x0000420C
		public WrapMode WrapMode
		{
			get
			{
				int result = 0;
				SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipGetTextureWrapMode(new HandleRef(this, base.NativeBrush), out result));
				return (WrapMode)result;
			}
			set
			{
				if (value < WrapMode.Tile || value > WrapMode.Clamp)
				{
					throw new InvalidEnumArgumentException("value", (int)value, typeof(WrapMode));
				}
				SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipSetTextureWrapMode(new HandleRef(this, base.NativeBrush), (int)value));
			}
		}

		/// <summary>Получает объект <see cref="T:System.Drawing.Image" />, связанный с объектом <see cref="T:System.Drawing.TextureBrush" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Image" />, представляющий изображение, с помощью которого объект <see cref="T:System.Drawing.TextureBrush" /> производит заливку форм.</returns>
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00006044 File Offset: 0x00004244
		public Image Image
		{
			get
			{
				IntPtr nativeImage;
				SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipGetTextureImage(new HandleRef(this, base.NativeBrush), out nativeImage));
				return Image.CreateImageObject(nativeImage);
			}
		}

		/// <summary>Сбрасывает свойство <see langword="Transform" /> объекта идентификации <see cref="T:System.Drawing.TextureBrush" />.</summary>
		// Token: 0x06000153 RID: 339 RVA: 0x0000606F File Offset: 0x0000426F
		public void ResetTransform()
		{
			SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipResetTextureTransform(new HandleRef(this, base.NativeBrush)));
		}

		/// <summary>Перемножает объект <see cref="T:System.Drawing.Drawing2D.Matrix" />, который представляет локальное геометрическое преобразование этого объекта <see cref="T:System.Drawing.TextureBrush" />, и указанный объект <see cref="T:System.Drawing.Drawing2D.Matrix" />, добавляя в начало указанный объект <see cref="T:System.Drawing.Drawing2D.Matrix" />.</summary>
		/// <param name="matrix">Объект <see cref="T:System.Drawing.Drawing2D.Matrix" />, на который умножается геометрическое преобразование.</param>
		// Token: 0x06000154 RID: 340 RVA: 0x00006087 File Offset: 0x00004287
		public void MultiplyTransform(Matrix matrix)
		{
			this.MultiplyTransform(matrix, MatrixOrder.Prepend);
		}

		/// <summary>Перемножает объект <see cref="T:System.Drawing.Drawing2D.Matrix" />, который представляет локальное геометрическое преобразование этого объекта, <see cref="T:System.Drawing.TextureBrush" /> и указанный объект <see cref="T:System.Drawing.Drawing2D.Matrix" /> в указанном порядке.</summary>
		/// <param name="matrix">Объект <see cref="T:System.Drawing.Drawing2D.Matrix" />, на который умножается геометрическое преобразование.</param>
		/// <param name="order">Перечисление <see cref="T:System.Drawing.Drawing2D.MatrixOrder" />, которое указывает порядок перемножения двух матриц.</param>
		// Token: 0x06000155 RID: 341 RVA: 0x00006094 File Offset: 0x00004294
		public void MultiplyTransform(Matrix matrix, MatrixOrder order)
		{
			if (matrix == null)
			{
				throw new ArgumentNullException("matrix");
			}
			if (matrix.nativeMatrix == IntPtr.Zero)
			{
				return;
			}
			SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipMultiplyTextureTransform(new HandleRef(this, base.NativeBrush), new HandleRef(matrix, matrix.nativeMatrix), order));
		}

		/// <summary>Выполняет перевод локального геометрического преобразования этого объекта <see cref="T:System.Drawing.TextureBrush" /> с использованием заданных измерений. Этот метод вставляет перевод перед преобразованием.</summary>
		/// <param name="dx">Измерение, с использованием которого необходимо перевести преобразование в направлении Х.</param>
		/// <param name="dy">Измерение, с использованием которого необходимо перевести преобразование в направлении Y.</param>
		// Token: 0x06000156 RID: 342 RVA: 0x000060E5 File Offset: 0x000042E5
		public void TranslateTransform(float dx, float dy)
		{
			this.TranslateTransform(dx, dy, MatrixOrder.Prepend);
		}

		/// <summary>Переводит локальное геометрическое преобразование этого объекта <see cref="T:System.Drawing.TextureBrush" /> с использованием заданных измерений в заданном порядке.</summary>
		/// <param name="dx">Измерение, с использованием которого необходимо перевести преобразование в направлении Х.</param>
		/// <param name="dy">Измерение, с использованием которого необходимо перевести преобразование в направлении Y.</param>
		/// <param name="order">Порядок применения преобразования (в начале или в конце).</param>
		// Token: 0x06000157 RID: 343 RVA: 0x000060F0 File Offset: 0x000042F0
		public void TranslateTransform(float dx, float dy, MatrixOrder order)
		{
			SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipTranslateTextureTransform(new HandleRef(this, base.NativeBrush), dx, dy, order));
		}

		/// <summary>Изменяет масштаб локального геометрического преобразования объекта <see cref="T:System.Drawing.TextureBrush" /> на заданные значения. Этот метод вставляет изменение масштаба перед преобразованием.</summary>
		/// <param name="sx">Величина изменения масштаба в направлении Х.</param>
		/// <param name="sy">Величина изменения масштаба в направлении У.</param>
		// Token: 0x06000158 RID: 344 RVA: 0x0000610B File Offset: 0x0000430B
		public void ScaleTransform(float sx, float sy)
		{
			this.ScaleTransform(sx, sy, MatrixOrder.Prepend);
		}

		/// <summary>Изменяет масштаб локального геометрического преобразования этого объекта <see cref="T:System.Drawing.TextureBrush" /> с использованием заданных величин в заданном порядке.</summary>
		/// <param name="sx">Величина изменения масштаба в направлении Х.</param>
		/// <param name="sy">Величина изменения масштаба в направлении У.</param>
		/// <param name="order">Перечисление <see cref="T:System.Drawing.Drawing2D.MatrixOrder" />, которое указывает, где добавляется матрица масштабирования: в начале или в конце.</param>
		// Token: 0x06000159 RID: 345 RVA: 0x00006116 File Offset: 0x00004316
		public void ScaleTransform(float sx, float sy, MatrixOrder order)
		{
			SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipScaleTextureTransform(new HandleRef(this, base.NativeBrush), sx, sy, order));
		}

		/// <summary>Поворачивает локальное геометрическое преобразование этого объекта <see cref="T:System.Drawing.TextureBrush" /> на заданную величину. Этот метод добавляет поворот перед преобразованием.</summary>
		/// <param name="angle">Угол поворота.</param>
		// Token: 0x0600015A RID: 346 RVA: 0x00006131 File Offset: 0x00004331
		public void RotateTransform(float angle)
		{
			this.RotateTransform(angle, MatrixOrder.Prepend);
		}

		/// <summary>Поворачивает локальное геометрического преобразование этого объекта <see cref="T:System.Drawing.TextureBrush" /> с использованием заданных величин в заданном порядке.</summary>
		/// <param name="angle">Угол поворота.</param>
		/// <param name="order">Перечисление <see cref="T:System.Drawing.Drawing2D.MatrixOrder" />, которое указывает, где добавляется матрица поворота: в начале или в конце.</param>
		// Token: 0x0600015B RID: 347 RVA: 0x0000613B File Offset: 0x0000433B
		public void RotateTransform(float angle, MatrixOrder order)
		{
			SafeNativeMethods.Gdip.CheckStatus(GDIPlus.GdipRotateTextureTransform(new HandleRef(this, base.NativeBrush), angle, order));
		}
	}
}
