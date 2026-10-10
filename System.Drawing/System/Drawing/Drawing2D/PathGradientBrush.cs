using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace System.Drawing.Drawing2D
{
	/// <summary>Инкапсулирует объект <see cref="T:System.Drawing.Brush" />, заполняющий градиентом внутреннюю область объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />. Этот класс не наследуется.</summary>
	// Token: 0x02000158 RID: 344
	[MonoTODO("libgdiplus/cairo doesn't support path gradients - unless it can be mapped to a radial gradient")]
	public sealed class PathGradientBrush : Brush
	{
		// Token: 0x06000F04 RID: 3844 RVA: 0x00022430 File Offset: 0x00020630
		internal PathGradientBrush(IntPtr native)
		{
			base.SetNativeBrush(native);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Drawing2D.PathGradientBrush" /> с указанным контуром.</summary>
		/// <param name="path">Объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />, определяющий область, заполненную этим объектом <see cref="T:System.Drawing.Drawing2D.PathGradientBrush" />.</param>
		// Token: 0x06000F05 RID: 3845 RVA: 0x00022440 File Offset: 0x00020640
		public PathGradientBrush(GraphicsPath path)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			IntPtr nativeBrush;
			GDIPlus.CheckStatus(GDIPlus.GdipCreatePathGradientFromPath(path.nativePath, out nativeBrush));
			base.SetNativeBrush(nativeBrush);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Drawing2D.PathGradientBrush" /> с указанными точками.</summary>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.Point" />, представляющий точки, образующие вершины контура.</param>
		// Token: 0x06000F06 RID: 3846 RVA: 0x0002247A File Offset: 0x0002067A
		public PathGradientBrush(Point[] points) : this(points, WrapMode.Clamp)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Drawing2D.PathGradientBrush" /> с указанными точками.</summary>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.PointF" />, представляющий точки, образующие вершины контура.</param>
		// Token: 0x06000F07 RID: 3847 RVA: 0x00022484 File Offset: 0x00020684
		public PathGradientBrush(PointF[] points) : this(points, WrapMode.Clamp)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Drawing2D.PathGradientBrush" /> с указанными точками и режимом переноса.</summary>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.Point" />, представляющий точки, образующие вершины контура.</param>
		/// <param name="wrapMode">Объект <see cref="T:System.Drawing.Drawing2D.WrapMode" />, который задает, как покрывается мозаикой заливка, выполненная с помощью объекта <see cref="T:System.Drawing.Drawing2D.PathGradientBrush" />.</param>
		// Token: 0x06000F08 RID: 3848 RVA: 0x00022490 File Offset: 0x00020690
		public PathGradientBrush(Point[] points, WrapMode wrapMode)
		{
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			if (wrapMode < WrapMode.Tile || wrapMode > WrapMode.Clamp)
			{
				throw new InvalidEnumArgumentException("WrapMode");
			}
			IntPtr nativeBrush;
			GDIPlus.CheckStatus(GDIPlus.GdipCreatePathGradientI(points, points.Length, wrapMode, out nativeBrush));
			base.SetNativeBrush(nativeBrush);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Drawing2D.PathGradientBrush" /> с указанными точками и режимом переноса.</summary>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.PointF" />, представляющий точки, образующие вершины контура.</param>
		/// <param name="wrapMode">Объект <see cref="T:System.Drawing.Drawing2D.WrapMode" />, который задает, как покрывается мозаикой заливка, выполненная с помощью объекта <see cref="T:System.Drawing.Drawing2D.PathGradientBrush" />.</param>
		// Token: 0x06000F09 RID: 3849 RVA: 0x000224DC File Offset: 0x000206DC
		public PathGradientBrush(PointF[] points, WrapMode wrapMode)
		{
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			if (wrapMode < WrapMode.Tile || wrapMode > WrapMode.Clamp)
			{
				throw new InvalidEnumArgumentException("WrapMode");
			}
			IntPtr nativeBrush;
			GDIPlus.CheckStatus(GDIPlus.GdipCreatePathGradient(points, points.Length, wrapMode, out nativeBrush));
			base.SetNativeBrush(nativeBrush);
		}

		/// <summary>Получает или задает объект <see cref="T:System.Drawing.Drawing2D.Blend" />, определяющий позиции и коэффициенты, задающие настраиваемый спад для градиента.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Drawing2D.Blend" />, представляющий настраиваемый спад для градиента.</returns>
		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000F0A RID: 3850 RVA: 0x00022528 File Offset: 0x00020728
		// (set) Token: 0x06000F0B RID: 3851 RVA: 0x0002257C File Offset: 0x0002077C
		public Blend Blend
		{
			get
			{
				int num;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPathGradientBlendCount(base.NativeBrush, out num));
				float[] array = new float[num];
				float[] positions = new float[num];
				GDIPlus.CheckStatus(GDIPlus.GdipGetPathGradientBlend(base.NativeBrush, array, positions, num));
				return new Blend
				{
					Factors = array,
					Positions = positions
				};
			}
			set
			{
				float[] factors = value.Factors;
				float[] positions = value.Positions;
				int num = factors.Length;
				if (num == 0 || positions.Length == 0)
				{
					throw new ArgumentException("Invalid Blend object. It should have at least 2 elements in each of the factors and positions arrays.");
				}
				if (num != positions.Length)
				{
					throw new ArgumentException("Invalid Blend object. It should contain the same number of factors and positions values.");
				}
				if (positions[0] != 0f)
				{
					throw new ArgumentException("Invalid Blend object. The positions array must have 0.0 as its first element.");
				}
				if (positions[num - 1] != 1f)
				{
					throw new ArgumentException("Invalid Blend object. The positions array must have 1.0 as its last element.");
				}
				GDIPlus.CheckStatus(GDIPlus.GdipSetPathGradientBlend(base.NativeBrush, factors, positions, num));
			}
		}

		/// <summary>Получает или задает цвет в центре градиента контура.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Color" />, представляющий цвет в центре градиента контура.</returns>
		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000F0C RID: 3852 RVA: 0x00022600 File Offset: 0x00020800
		// (set) Token: 0x06000F0D RID: 3853 RVA: 0x00022625 File Offset: 0x00020825
		public Color CenterColor
		{
			get
			{
				int argb;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPathGradientCenterColor(base.NativeBrush, out argb));
				return Color.FromArgb(argb);
			}
			set
			{
				GDIPlus.CheckStatus(GDIPlus.GdipSetPathGradientCenterColor(base.NativeBrush, value.ToArgb()));
			}
		}

		/// <summary>Получает или задает центральную точку градиента контура.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.PointF" />, представляющий центральную точку градиента контура.</returns>
		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x00022640 File Offset: 0x00020840
		// (set) Token: 0x06000F0F RID: 3855 RVA: 0x00022660 File Offset: 0x00020860
		public PointF CenterPoint
		{
			get
			{
				PointF result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPathGradientCenterPoint(base.NativeBrush, out result));
				return result;
			}
			set
			{
				PointF pointF = value;
				GDIPlus.CheckStatus(GDIPlus.GdipSetPathGradientCenterPoint(base.NativeBrush, ref pointF));
			}
		}

		/// <summary>Получает или задает точку фокуса для градиентного перехода.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.PointF" />, представляющая точку фокуса для градиентного перехода.</returns>
		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000F10 RID: 3856 RVA: 0x00022684 File Offset: 0x00020884
		// (set) Token: 0x06000F11 RID: 3857 RVA: 0x000226AC File Offset: 0x000208AC
		public PointF FocusScales
		{
			get
			{
				float x;
				float y;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPathGradientFocusScales(base.NativeBrush, out x, out y));
				return new PointF(x, y);
			}
			set
			{
				GDIPlus.CheckStatus(GDIPlus.GdipSetPathGradientFocusScales(base.NativeBrush, value.X, value.Y));
			}
		}

		/// <summary>Получает или задает объект <see cref="T:System.Drawing.Drawing2D.ColorBlend" />, определяющий многоцветный линейный градиент.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Drawing2D.ColorBlend" />, определяющий многоцветный линейный градиент.</returns>
		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000F12 RID: 3858 RVA: 0x000226CC File Offset: 0x000208CC
		// (set) Token: 0x06000F13 RID: 3859 RVA: 0x00022758 File Offset: 0x00020958
		public ColorBlend InterpolationColors
		{
			get
			{
				int num;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPathGradientPresetBlendCount(base.NativeBrush, out num));
				if (num < 1)
				{
					num = 1;
				}
				int[] array = new int[num];
				float[] positions = new float[num];
				if (num > 1)
				{
					GDIPlus.CheckStatus(GDIPlus.GdipGetPathGradientPresetBlend(base.NativeBrush, array, positions, num));
				}
				ColorBlend colorBlend = new ColorBlend();
				Color[] array2 = new Color[num];
				for (int i = 0; i < num; i++)
				{
					array2[i] = Color.FromArgb(array[i]);
				}
				colorBlend.Colors = array2;
				colorBlend.Positions = positions;
				return colorBlend;
			}
			set
			{
				Color[] colors = value.Colors;
				float[] positions = value.Positions;
				int num = colors.Length;
				if (num == 0 || positions.Length == 0)
				{
					throw new ArgumentException("Invalid ColorBlend object. It should have at least 2 elements in each of the colors and positions arrays.");
				}
				if (num != positions.Length)
				{
					throw new ArgumentException("Invalid ColorBlend object. It should contain the same number of positions and color values.");
				}
				if (positions[0] != 0f)
				{
					throw new ArgumentException("Invalid ColorBlend object. The positions array must have 0.0 as its first element.");
				}
				if (positions[num - 1] != 1f)
				{
					throw new ArgumentException("Invalid ColorBlend object. The positions array must have 1.0 as its last element.");
				}
				int[] array = new int[colors.Length];
				for (int i = 0; i < colors.Length; i++)
				{
					array[i] = colors[i].ToArgb();
				}
				GDIPlus.CheckStatus(GDIPlus.GdipSetPathGradientPresetBlend(base.NativeBrush, array, positions, num));
			}
		}

		/// <summary>Получает ограничивающий прямоугольник для этого объекта <see cref="T:System.Drawing.Drawing2D.PathGradientBrush" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.RectangleF" />, представляющая прямоугольную область, которая ограничивает контур, заполняемый объектом <see cref="T:System.Drawing.Drawing2D.PathGradientBrush" />.</returns>
		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x00022808 File Offset: 0x00020A08
		public RectangleF Rectangle
		{
			get
			{
				RectangleF result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPathGradientRect(base.NativeBrush, out result));
				return result;
			}
		}

		/// <summary>Получает или задает массив цветов, соответствующих точкам контура, заполняемого объектом <see cref="T:System.Drawing.Drawing2D.PathGradientBrush" />.</summary>
		/// <returns>Массив структур <see cref="T:System.Drawing.Color" />, представляющий цвета, связанные с каждой точкой контура, заполняемого объектом <see cref="T:System.Drawing.Drawing2D.PathGradientBrush" />.</returns>
		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000F15 RID: 3861 RVA: 0x00022828 File Offset: 0x00020A28
		// (set) Token: 0x06000F16 RID: 3862 RVA: 0x00022884 File Offset: 0x00020A84
		public Color[] SurroundColors
		{
			get
			{
				int num;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPathGradientSurroundColorCount(base.NativeBrush, out num));
				int[] array = new int[num];
				GDIPlus.CheckStatus(GDIPlus.GdipGetPathGradientSurroundColorsWithCount(base.NativeBrush, array, ref num));
				Color[] array2 = new Color[num];
				for (int i = 0; i < num; i++)
				{
					array2[i] = Color.FromArgb(array[i]);
				}
				return array2;
			}
			set
			{
				int num = value.Length;
				int[] array = new int[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = value[i].ToArgb();
				}
				GDIPlus.CheckStatus(GDIPlus.GdipSetPathGradientSurroundColorsWithCount(base.NativeBrush, array, ref num));
			}
		}

		/// <summary>Получает или задает копию объекта <see cref="T:System.Drawing.Drawing2D.Matrix" />, определяющего локальное геометрическое преобразование для этого объекта <see cref="T:System.Drawing.Drawing2D.PathGradientBrush" />.</summary>
		/// <returns>Копия объекта <see cref="T:System.Drawing.Drawing2D.Matrix" />, определяющая геометрическое преобразование, применяемое только для участков, заливка которых выполнена с помощью объекта <see cref="T:System.Drawing.Drawing2D.PathGradientBrush" />.</returns>
		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000F17 RID: 3863 RVA: 0x000228CC File Offset: 0x00020ACC
		// (set) Token: 0x06000F18 RID: 3864 RVA: 0x000228F6 File Offset: 0x00020AF6
		public Matrix Transform
		{
			get
			{
				Matrix matrix = new Matrix();
				GDIPlus.CheckStatus(GDIPlus.GdipGetPathGradientTransform(base.NativeBrush, matrix.nativeMatrix));
				return matrix;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("Transform");
				}
				GDIPlus.CheckStatus(GDIPlus.GdipSetPathGradientTransform(base.NativeBrush, value.nativeMatrix));
			}
		}

		/// <summary>Получает или задает объект <see cref="T:System.Drawing.Drawing2D.WrapMode" />, определяющий режим переноса для этого объекта <see cref="T:System.Drawing.Drawing2D.PathGradientBrush" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Drawing2D.WrapMode" />, который задает, как покрывается мозаикой заливка, выполненная с помощью объекта <see cref="T:System.Drawing.Drawing2D.PathGradientBrush" />.</returns>
		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000F19 RID: 3865 RVA: 0x0002291C File Offset: 0x00020B1C
		// (set) Token: 0x06000F1A RID: 3866 RVA: 0x0002293C File Offset: 0x00020B3C
		public WrapMode WrapMode
		{
			get
			{
				WrapMode result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPathGradientWrapMode(base.NativeBrush, out result));
				return result;
			}
			set
			{
				if (value < WrapMode.Tile || value > WrapMode.Clamp)
				{
					throw new InvalidEnumArgumentException("WrapMode");
				}
				GDIPlus.CheckStatus(GDIPlus.GdipSetPathGradientWrapMode(base.NativeBrush, value));
			}
		}

		/// <summary>Обновляет матрицу преобразования кисти с использованием произведения матрицы преобразования кисти и другой матрицы.</summary>
		/// <param name="matrix">Объект <see cref="T:System.Drawing.Drawing2D.Matrix" />, который будет умножен на текущую матрицу преобразования кисти.</param>
		// Token: 0x06000F1B RID: 3867 RVA: 0x00022962 File Offset: 0x00020B62
		public void MultiplyTransform(Matrix matrix)
		{
			this.MultiplyTransform(matrix, MatrixOrder.Prepend);
		}

		/// <summary>Обновляет матрицу преобразования кисти с использованием произведения матрицы преобразования кисти и другой матрицы.</summary>
		/// <param name="matrix">Объект <see cref="T:System.Drawing.Drawing2D.Matrix" />, который будет умножен на текущую матрицу преобразования кисти.</param>
		/// <param name="order">Объект <see cref="T:System.Drawing.Drawing2D.MatrixOrder" />, задающий порядок умножения двух матриц.</param>
		// Token: 0x06000F1C RID: 3868 RVA: 0x0002296C File Offset: 0x00020B6C
		public void MultiplyTransform(Matrix matrix, MatrixOrder order)
		{
			if (matrix == null)
			{
				throw new ArgumentNullException("matrix");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipMultiplyPathGradientTransform(base.NativeBrush, matrix.nativeMatrix, order));
		}

		/// <summary>Возвращает свойству <see cref="P:System.Drawing.Drawing2D.PathGradientBrush.Transform" /> единичное значение.</summary>
		// Token: 0x06000F1D RID: 3869 RVA: 0x00022993 File Offset: 0x00020B93
		public void ResetTransform()
		{
			GDIPlus.CheckStatus(GDIPlus.GdipResetPathGradientTransform(base.NativeBrush));
		}

		/// <summary>Поворачивает локальное геометрическое преобразование на заданную величину. Этот метод добавляет поворот к преобразованию.</summary>
		/// <param name="angle">Угол (величина) поворота.</param>
		// Token: 0x06000F1E RID: 3870 RVA: 0x000229A5 File Offset: 0x00020BA5
		public void RotateTransform(float angle)
		{
			this.RotateTransform(angle, MatrixOrder.Prepend);
		}

		/// <summary>Поворачивает локальное геометрическое преобразование на указанную величину в заданном порядке.</summary>
		/// <param name="angle">Угол (величина) поворота.</param>
		/// <param name="order">Объект <see cref="T:System.Drawing.Drawing2D.MatrixOrder" />, указывающий, где будет добавляться матрица поворота: в начале или в конце.</param>
		// Token: 0x06000F1F RID: 3871 RVA: 0x000229AF File Offset: 0x00020BAF
		public void RotateTransform(float angle, MatrixOrder order)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipRotatePathGradientTransform(base.NativeBrush, angle, order));
		}

		/// <summary>Масштабирует локальное геометрическое преобразование на заданные величины. Этот метод добавляет в преобразование масштабирующую матрицу.</summary>
		/// <param name="sx">Масштабный коэффициент преобразования по оси X.</param>
		/// <param name="sy">Масштабный коэффициент преобразования по оси Y.</param>
		// Token: 0x06000F20 RID: 3872 RVA: 0x000229C3 File Offset: 0x00020BC3
		public void ScaleTransform(float sx, float sy)
		{
			this.ScaleTransform(sx, sy, MatrixOrder.Prepend);
		}

		/// <summary>Масштабирует локальное геометрическое преобразование на заданные величины в указанном порядке.</summary>
		/// <param name="sx">Масштабный коэффициент преобразования по оси X.</param>
		/// <param name="sy">Масштабный коэффициент преобразования по оси Y.</param>
		/// <param name="order">Объект <see cref="T:System.Drawing.Drawing2D.MatrixOrder" />, указывающий, где добавляется матрица масштабирования: в начале или в конце.</param>
		// Token: 0x06000F21 RID: 3873 RVA: 0x000229CE File Offset: 0x00020BCE
		public void ScaleTransform(float sx, float sy, MatrixOrder order)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipScalePathGradientTransform(base.NativeBrush, sx, sy, order));
		}

		/// <summary>Создает градиент с цветом центра и линейным переходом к одному окружающему цвету.</summary>
		/// <param name="focus">Значение от 0 до 1, определяющее, в какой позиции вдоль любого луча из центра контура к его границе интенсивность центрального цвета будет максимальной. Значение 1 (по умолчанию) помещает максимальную интенсивность в центр контура.</param>
		// Token: 0x06000F22 RID: 3874 RVA: 0x000229E3 File Offset: 0x00020BE3
		public void SetBlendTriangularShape(float focus)
		{
			this.SetBlendTriangularShape(focus, 1f);
		}

		/// <summary>Создает градиент с цветом центра и линейным переходом к каждому из окружающих цветов.</summary>
		/// <param name="focus">Значение от 0 до 1, определяющее, в какой позиции вдоль любого луча из центра контура к его границе интенсивность центрального цвета будет максимальной. Значение 1 (по умолчанию) помещает максимальную интенсивность в центр контура.</param>
		/// <param name="scale">Значение от 0 до 1, определяющее максимальную интенсивность центрального цвета, которая смешивается с граничным цветом. Значение 1 соответствует максимально возможной интенсивности центрального цвета — оно установлено по умолчанию.</param>
		// Token: 0x06000F23 RID: 3875 RVA: 0x000229F1 File Offset: 0x00020BF1
		public void SetBlendTriangularShape(float focus, float scale)
		{
			if (focus < 0f || focus > 1f || scale < 0f || scale > 1f)
			{
				throw new ArgumentException("Invalid parameter passed.");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipSetPathGradientLinearBlend(base.NativeBrush, focus, scale));
		}

		/// <summary>Создает градиентную кисть, которая изменяет цвет, начиная с центра контура, и заканчивая границей контура. Переход от одного цвета к другому выполняется на основе колоколообразной кривой.</summary>
		/// <param name="focus">Значение от 0 до 1, определяющее, в какой позиции вдоль любого луча из центра контура к его границе интенсивность центрального цвета будет максимальной. Значение 1 (по умолчанию) помещает максимальную интенсивность в центр контура.</param>
		// Token: 0x06000F24 RID: 3876 RVA: 0x00022A30 File Offset: 0x00020C30
		public void SetSigmaBellShape(float focus)
		{
			this.SetSigmaBellShape(focus, 1f);
		}

		/// <summary>Создает градиентную кисть, которая изменяет цвет, начиная с центра контура, и заканчивая границей контура. Переход от одного цвета к другому выполняется на основе колоколообразной кривой.</summary>
		/// <param name="focus">Значение от 0 до 1, определяющее, в какой позиции вдоль любого луча из центра контура к его границе интенсивность центрального цвета будет максимальной. Значение 1 (по умолчанию) помещает максимальную интенсивность в центр контура.</param>
		/// <param name="scale">Значение от 0 до 1, определяющее максимальную интенсивность центрального цвета, которая смешивается с граничным цветом. Значение 1 соответствует максимально возможной интенсивности центрального цвета — оно установлено по умолчанию.</param>
		// Token: 0x06000F25 RID: 3877 RVA: 0x00022A3E File Offset: 0x00020C3E
		public void SetSigmaBellShape(float focus, float scale)
		{
			if (focus < 0f || focus > 1f || scale < 0f || scale > 1f)
			{
				throw new ArgumentException("Invalid parameter passed.");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipSetPathGradientSigmaBlend(base.NativeBrush, focus, scale));
		}

		/// <summary>Применяет указанный сдвиг к локальному геометрическому преобразованию. Этот метод добавляет сдвиг к преобразованию.</summary>
		/// <param name="dx">Значение сдвига по оси X.</param>
		/// <param name="dy">Значение сдвига по оси Y.</param>
		// Token: 0x06000F26 RID: 3878 RVA: 0x00022A7D File Offset: 0x00020C7D
		public void TranslateTransform(float dx, float dy)
		{
			this.TranslateTransform(dx, dy, MatrixOrder.Prepend);
		}

		/// <summary>Применяет указанный сдвиг к локальному геометрическому преобразованию в заданном порядке.</summary>
		/// <param name="dx">Значение сдвига по оси X.</param>
		/// <param name="dy">Значение сдвига по оси Y.</param>
		/// <param name="order">Порядок применения преобразования (в начале или в конце).</param>
		// Token: 0x06000F27 RID: 3879 RVA: 0x00022A88 File Offset: 0x00020C88
		public void TranslateTransform(float dx, float dy, MatrixOrder order)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipTranslatePathGradientTransform(base.NativeBrush, dx, dy, order));
		}

		/// <summary>Создает точную копию данного объекта <see cref="T:System.Drawing.Drawing2D.PathGradientBrush" />.</summary>
		/// <returns>
		///   <see cref="T:System.Drawing.Drawing2D.PathGradientBrush" />, создаваемый этим методом, приводится к типу объекта.</returns>
		// Token: 0x06000F28 RID: 3880 RVA: 0x00022AA0 File Offset: 0x00020CA0
		public override object Clone()
		{
			IntPtr native;
			GDIPlus.CheckStatus((Status)GDIPlus.GdipCloneBrush(new HandleRef(this, base.NativeBrush), out native));
			return new PathGradientBrush(native);
		}
	}
}
