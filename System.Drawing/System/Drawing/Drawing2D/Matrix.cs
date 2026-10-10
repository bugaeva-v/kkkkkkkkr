using System;
using System.Runtime.InteropServices;

namespace System.Drawing.Drawing2D
{
	/// <summary>Инкапсулирует аффинное представление с матричным преобразованием 3 на 3, представляющим геометрическое преобразование. Этот класс не наследуется.</summary>
	// Token: 0x02000157 RID: 343
	public sealed class Matrix : MarshalByRefObject, IDisposable
	{
		// Token: 0x06000EE0 RID: 3808 RVA: 0x00021F0B File Offset: 0x0002010B
		internal Matrix(IntPtr ptr)
		{
			this.nativeMatrix = ptr;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Drawing2D.Matrix" /> в виде единичной матрицы.</summary>
		// Token: 0x06000EE1 RID: 3809 RVA: 0x00021F1A File Offset: 0x0002011A
		public Matrix()
		{
			GDIPlus.CheckStatus(GDIPlus.GdipCreateMatrix(out this.nativeMatrix));
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Drawing2D.Matrix" /> для геометрического преобразования, определяемого указанным прямоугольником и массивом точек.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.Rectangle" />, представляющая преобразуемый прямоугольник.</param>
		/// <param name="plgpts">Массив из трех структур <see cref="T:System.Drawing.Point" />, представляющих точки параллелограмма, в которые преобразуются левый верхний, правый верхний и левый нижний углы прямоугольника. Правый нижний угол параллелограмма выражается из первых трех углов.</param>
		// Token: 0x06000EE2 RID: 3810 RVA: 0x00021F32 File Offset: 0x00020132
		public Matrix(Rectangle rect, Point[] plgpts)
		{
			if (plgpts == null)
			{
				throw new ArgumentNullException("plgpts");
			}
			if (plgpts.Length != 3)
			{
				throw new ArgumentException("plgpts");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipCreateMatrix3I(ref rect, plgpts, out this.nativeMatrix));
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Drawing2D.Matrix" /> для геометрического преобразования, определяемого указанным прямоугольником и массивом точек.</summary>
		/// <param name="rect">Структура <see cref="T:System.Drawing.RectangleF" />, представляющая преобразуемый прямоугольник.</param>
		/// <param name="plgpts">Массив из трех структур <see cref="T:System.Drawing.PointF" />, представляющих точки параллелограмма, в которые преобразуются левый верхний, правый верхний и левый нижний углы прямоугольника. Правый нижний угол параллелограмма выражается из первых трех углов.</param>
		// Token: 0x06000EE3 RID: 3811 RVA: 0x00021F6C File Offset: 0x0002016C
		public Matrix(RectangleF rect, PointF[] plgpts)
		{
			if (plgpts == null)
			{
				throw new ArgumentNullException("plgpts");
			}
			if (plgpts.Length != 3)
			{
				throw new ArgumentException("plgpts");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipCreateMatrix3(ref rect, plgpts, out this.nativeMatrix));
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Drawing2D.Matrix" /> с указанными элементами.</summary>
		/// <param name="m11">Значение на пересечении первой строки и первого столбца нового объекта <see cref="T:System.Drawing.Drawing2D.Matrix" />.</param>
		/// <param name="m12">Значение на пересечении первой строки и второго столбца нового объекта <see cref="T:System.Drawing.Drawing2D.Matrix" />.</param>
		/// <param name="m21">Значение на пересечении второй строки и первого столбца нового объекта <see cref="T:System.Drawing.Drawing2D.Matrix" />.</param>
		/// <param name="m22">Значение на пересечении второй строки и второго столбца нового объекта <see cref="T:System.Drawing.Drawing2D.Matrix" />.</param>
		/// <param name="dx">Значение на пересечении третьей строки и первого столбца нового объекта <see cref="T:System.Drawing.Drawing2D.Matrix" />.</param>
		/// <param name="dy">Значение на пересечении третьей строки и второго столбца нового объекта <see cref="T:System.Drawing.Drawing2D.Matrix" />.</param>
		// Token: 0x06000EE4 RID: 3812 RVA: 0x00021FA6 File Offset: 0x000201A6
		public Matrix(float m11, float m12, float m21, float m22, float dx, float dy)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipCreateMatrix2(m11, m12, m21, m22, dx, dy, out this.nativeMatrix));
		}

		/// <summary>Получает массив значений с плавающей запятой, представляющий элементы этого объекта <see cref="T:System.Drawing.Drawing2D.Matrix" />.</summary>
		/// <returns>Массив значений с плавающей запятой, представляющий элементы этого объекта <see cref="T:System.Drawing.Drawing2D.Matrix" />.</returns>
		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x00021FC8 File Offset: 0x000201C8
		public float[] Elements
		{
			get
			{
				float[] array = new float[6];
				IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(float)) * 6);
				try
				{
					GDIPlus.CheckStatus(GDIPlus.GdipGetMatrixElements(this.nativeMatrix, intPtr));
					Marshal.Copy(intPtr, array, 0, 6);
				}
				finally
				{
					Marshal.FreeHGlobal(intPtr);
				}
				return array;
			}
		}

		/// <summary>Возвращает значение, определяющее, является ли объект <see cref="T:System.Drawing.Drawing2D.Matrix" /> единичной матрицей.</summary>
		/// <returns>Это свойство имеет значение <see langword="true" />, если данная матрица <see cref="T:System.Drawing.Drawing2D.Matrix" /> единичная; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x00022028 File Offset: 0x00020228
		public bool IsIdentity
		{
			get
			{
				bool result;
				GDIPlus.CheckStatus(GDIPlus.GdipIsMatrixIdentity(this.nativeMatrix, out result));
				return result;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли матрица <see cref="T:System.Drawing.Drawing2D.Matrix" /> обратимой.</summary>
		/// <returns>Это свойство имеет значение <see langword="true" />, если матрица <see cref="T:System.Drawing.Drawing2D.Matrix" /> является обратимой; в противном случае, значение равно <see langword="false" />.</returns>
		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x00022048 File Offset: 0x00020248
		public bool IsInvertible
		{
			get
			{
				bool result;
				GDIPlus.CheckStatus(GDIPlus.GdipIsMatrixInvertible(this.nativeMatrix, out result));
				return result;
			}
		}

		/// <summary>Получает значение смещения по оси x (значение dx, или элемент на пересечении третьей строки и первого столбца) объекта <see cref="T:System.Drawing.Drawing2D.Matrix" />.</summary>
		/// <returns>Значение смещения по оси X объекта <see cref="T:System.Drawing.Drawing2D.Matrix" />.</returns>
		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x00022068 File Offset: 0x00020268
		public float OffsetX
		{
			get
			{
				return this.Elements[4];
			}
		}

		/// <summary>Возвращает значение смещения по оси Y (значение dy, или элемент на пересечении третьей строки и второго столбца) для этого объекта <see cref="T:System.Drawing.Drawing2D.Matrix" />.</summary>
		/// <returns>Значение смещения по оси Y этого объекта <see cref="T:System.Drawing.Drawing2D.Matrix" />.</returns>
		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x00022072 File Offset: 0x00020272
		public float OffsetY
		{
			get
			{
				return this.Elements[5];
			}
		}

		/// <summary>Создает точную копию данного объекта <see cref="T:System.Drawing.Drawing2D.Matrix" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Drawing2D.Matrix" />, создаваемый данным методом.</returns>
		// Token: 0x06000EEA RID: 3818 RVA: 0x0002207C File Offset: 0x0002027C
		public Matrix Clone()
		{
			IntPtr ptr;
			GDIPlus.CheckStatus(GDIPlus.GdipCloneMatrix(this.nativeMatrix, out ptr));
			return new Matrix(ptr);
		}

		/// <summary>Освобождает все ресурсы, используемые этим объектом <see cref="T:System.Drawing.Drawing2D.Matrix" />.</summary>
		// Token: 0x06000EEB RID: 3819 RVA: 0x000220A1 File Offset: 0x000202A1
		public void Dispose()
		{
			if (this.nativeMatrix != IntPtr.Zero)
			{
				GDIPlus.CheckStatus(GDIPlus.GdipDeleteMatrix(this.nativeMatrix));
				this.nativeMatrix = IntPtr.Zero;
			}
			GC.SuppressFinalize(this);
		}

		/// <summary>Проверяет, является ли заданный объект объектом <see cref="T:System.Drawing.Drawing2D.Matrix" /> и идентичен ли он этому объекту <see cref="T:System.Drawing.Drawing2D.Matrix" />.</summary>
		/// <param name="obj">Объект для тестирования.</param>
		/// <returns>Данный метод возвращает значение <see langword="true" />, если объект <paramref name="obj" /> является указанным объектом <see cref="T:System.Drawing.Drawing2D.Matrix" />, идентичным этому объекту <see cref="T:System.Drawing.Drawing2D.Matrix" />; в противном случае, возвращает значение <see langword="false" />.</returns>
		// Token: 0x06000EEC RID: 3820 RVA: 0x000220D8 File Offset: 0x000202D8
		public override bool Equals(object obj)
		{
			Matrix matrix = obj as Matrix;
			if (matrix != null)
			{
				bool result;
				GDIPlus.CheckStatus(GDIPlus.GdipIsMatrixEqual(this.nativeMatrix, matrix.nativeMatrix, out result));
				return result;
			}
			return false;
		}

		/// <summary>Позволяет объекту попытаться освободить ресурсы и выполнить другие операции очистки, перед тем как объект будет утилизирован в процессе сборки мусора.</summary>
		// Token: 0x06000EED RID: 3821 RVA: 0x0002210C File Offset: 0x0002030C
		~Matrix()
		{
			this.Dispose();
		}

		/// <summary>Возвращает хэш-код.</summary>
		/// <returns>Хэш-код для данного объекта <see cref="T:System.Drawing.Drawing2D.Matrix" />.</returns>
		// Token: 0x06000EEE RID: 3822 RVA: 0x00003BAB File Offset: 0x00001DAB
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Обращает матрицу <see cref="T:System.Drawing.Drawing2D.Matrix" />, если она обратима.</summary>
		// Token: 0x06000EEF RID: 3823 RVA: 0x00022138 File Offset: 0x00020338
		public void Invert()
		{
			GDIPlus.CheckStatus(GDIPlus.GdipInvertMatrix(this.nativeMatrix));
		}

		/// <summary>Умножает эту матрицу <see cref="T:System.Drawing.Drawing2D.Matrix" /> на матрицу, указанную в параметре <paramref name="matrix" />, путем добавления указанной матрицы <see cref="T:System.Drawing.Drawing2D.Matrix" />.</summary>
		/// <param name="matrix">Матрица <see cref="T:System.Drawing.Drawing2D.Matrix" />, с помощью которой производится умножение этой матрицы <see cref="T:System.Drawing.Drawing2D.Matrix" />.</param>
		// Token: 0x06000EF0 RID: 3824 RVA: 0x0002214A File Offset: 0x0002034A
		public void Multiply(Matrix matrix)
		{
			this.Multiply(matrix, MatrixOrder.Prepend);
		}

		/// <summary>Умножает этот объект <see cref="T:System.Drawing.Drawing2D.Matrix" /> на матрицу, указанную в параметре <paramref name="matrix" />, в порядке, задаваемом в параметре <paramref name="order" />.</summary>
		/// <param name="matrix">Матрица <see cref="T:System.Drawing.Drawing2D.Matrix" />, с помощью которой производится умножение этой матрицы <see cref="T:System.Drawing.Drawing2D.Matrix" />.</param>
		/// <param name="order">Объект <see cref="T:System.Drawing.Drawing2D.MatrixOrder" />, представляющий порядок перемножения.</param>
		// Token: 0x06000EF1 RID: 3825 RVA: 0x00022154 File Offset: 0x00020354
		public void Multiply(Matrix matrix, MatrixOrder order)
		{
			if (matrix == null)
			{
				throw new ArgumentNullException("matrix");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipMultiplyMatrix(this.nativeMatrix, matrix.nativeMatrix, order));
		}

		/// <summary>Сбрасывает этот объект <see cref="T:System.Drawing.Drawing2D.Matrix" />, чтобы получить элементы единичной матрицы.</summary>
		// Token: 0x06000EF2 RID: 3826 RVA: 0x0002217B File Offset: 0x0002037B
		public void Reset()
		{
			GDIPlus.CheckStatus(GDIPlus.GdipSetMatrixElements(this.nativeMatrix, 1f, 0f, 0f, 1f, 0f, 0f));
		}

		/// <summary>Добавляет в этот объект <see cref="T:System.Drawing.Drawing2D.Matrix" /> поворот по часовой стрелке вокруг начала координат на указанный угол.</summary>
		/// <param name="angle">Угол поворота в градусах.</param>
		// Token: 0x06000EF3 RID: 3827 RVA: 0x000221AB File Offset: 0x000203AB
		public void Rotate(float angle)
		{
			this.Rotate(angle, MatrixOrder.Prepend);
		}

		/// <summary>Применяет поворот по часовой стрелке вокруг начала координат (нулевые координаты x и y) на величину, указанную в параметре <paramref name="angle" />,  к этому объекту <see cref="T:System.Drawing.Drawing2D.Matrix" />.</summary>
		/// <param name="angle">Угол (величина) поворота в градусах.</param>
		/// <param name="order">Объект <see cref="T:System.Drawing.Drawing2D.MatrixOrder" />, задающий порядок (в конце или в начале), в котором применяется поворот к этому объекту <see cref="T:System.Drawing.Drawing2D.Matrix" />.</param>
		// Token: 0x06000EF4 RID: 3828 RVA: 0x000221B5 File Offset: 0x000203B5
		public void Rotate(float angle, MatrixOrder order)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipRotateMatrix(this.nativeMatrix, angle, order));
		}

		/// <summary>Применяет поворот по часовой стрелке к этому объекту<see cref="T:System.Drawing.Drawing2D.Matrix" />; поворот производится вокруг точки, указанной в параметре <paramref name="point" />, и путем добавления поворота в начало.</summary>
		/// <param name="angle">Угол (величина) поворота в градусах.</param>
		/// <param name="point">Объект <see cref="T:System.Drawing.PointF" />, представляющий центральную точку поворота.</param>
		// Token: 0x06000EF5 RID: 3829 RVA: 0x000221C9 File Offset: 0x000203C9
		public void RotateAt(float angle, PointF point)
		{
			this.RotateAt(angle, point, MatrixOrder.Prepend);
		}

		/// <summary>Применяет поворот по часовой стрелке вокруг указанной точки к объекту <see cref="T:System.Drawing.Drawing2D.Matrix" /> в указанном порядке.</summary>
		/// <param name="angle">Угол поворота в градусах.</param>
		/// <param name="point">Объект <see cref="T:System.Drawing.PointF" />, представляющий центральную точку поворота.</param>
		/// <param name="order">Объект <see cref="T:System.Drawing.Drawing2D.MatrixOrder" />, задающий порядок (в конце или в начале), в котором применяется поворот.</param>
		// Token: 0x06000EF6 RID: 3830 RVA: 0x000221D4 File Offset: 0x000203D4
		public void RotateAt(float angle, PointF point, MatrixOrder order)
		{
			if (order < MatrixOrder.Prepend || order > MatrixOrder.Append)
			{
				throw new ArgumentException("order");
			}
			angle *= 0.017453292f;
			float num = (float)Math.Cos((double)angle);
			float num2 = (float)Math.Sin((double)angle);
			float num3 = -point.X * num + point.Y * num2 + point.X;
			float num4 = -point.X * num2 - point.Y * num + point.Y;
			float[] elements = this.Elements;
			Status status;
			if (order == MatrixOrder.Prepend)
			{
				status = GDIPlus.GdipSetMatrixElements(this.nativeMatrix, num * elements[0] + num2 * elements[2], num * elements[1] + num2 * elements[3], -num2 * elements[0] + num * elements[2], -num2 * elements[1] + num * elements[3], num3 * elements[0] + num4 * elements[2] + elements[4], num3 * elements[1] + num4 * elements[3] + elements[5]);
			}
			else
			{
				status = GDIPlus.GdipSetMatrixElements(this.nativeMatrix, elements[0] * num + elements[1] * -num2, elements[0] * num2 + elements[1] * num, elements[2] * num + elements[3] * -num2, elements[2] * num2 + elements[3] * num, elements[4] * num + elements[5] * -num2 + num3, elements[4] * num2 + elements[5] * num + num4);
			}
			GDIPlus.CheckStatus(status);
		}

		/// <summary>Применяет указанный вектор масштабирования к этому объекту <see cref="T:System.Drawing.Drawing2D.Matrix" />, добавляя вектор масштабирования в начало.</summary>
		/// <param name="scaleX">Коэффициент изменения масштаба объекта <see cref="T:System.Drawing.Drawing2D.Matrix" /> вдоль оси Х.</param>
		/// <param name="scaleY">Коэффициент изменения масштаба объекта <see cref="T:System.Drawing.Drawing2D.Matrix" /> вдоль оси Y.</param>
		// Token: 0x06000EF7 RID: 3831 RVA: 0x00022326 File Offset: 0x00020526
		public void Scale(float scaleX, float scaleY)
		{
			this.Scale(scaleX, scaleY, MatrixOrder.Prepend);
		}

		/// <summary>Применяет указанный вектор масштабирования (<paramref name="scaleX" /> и <paramref name="scaleY" />) к этому объекту <see cref="T:System.Drawing.Drawing2D.Matrix" /> в указанном порядке.</summary>
		/// <param name="scaleX">Коэффициент изменения масштаба объекта <see cref="T:System.Drawing.Drawing2D.Matrix" /> вдоль оси Х.</param>
		/// <param name="scaleY">Коэффициент изменения масштаба объекта <see cref="T:System.Drawing.Drawing2D.Matrix" /> вдоль оси Y.</param>
		/// <param name="order">Объект <see cref="T:System.Drawing.Drawing2D.MatrixOrder" />, задающий порядок (в конце или в начале), в котором применяется вектор масштабирования к этому объекту <see cref="T:System.Drawing.Drawing2D.Matrix" />.</param>
		// Token: 0x06000EF8 RID: 3832 RVA: 0x00022331 File Offset: 0x00020531
		public void Scale(float scaleX, float scaleY, MatrixOrder order)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipScaleMatrix(this.nativeMatrix, scaleX, scaleY, order));
		}

		/// <summary>Применяет указанный вектор сдвига к этому объекту <see cref="T:System.Drawing.Drawing2D.Matrix" />, добавляя преобразование сдвига в начало.</summary>
		/// <param name="shearX">Коэффициент горизонтального сдвига.</param>
		/// <param name="shearY">Коэффициент вертикального сдвига.</param>
		// Token: 0x06000EF9 RID: 3833 RVA: 0x00022346 File Offset: 0x00020546
		public void Shear(float shearX, float shearY)
		{
			this.Shear(shearX, shearY, MatrixOrder.Prepend);
		}

		/// <summary>Применяет указанный вектор сдвига к этому объекту <see cref="T:System.Drawing.Drawing2D.Matrix" /> в указанном порядке.</summary>
		/// <param name="shearX">Коэффициент горизонтального сдвига.</param>
		/// <param name="shearY">Коэффициент вертикального сдвига.</param>
		/// <param name="order">Объект <see cref="T:System.Drawing.Drawing2D.MatrixOrder" />, задающий порядок (в конце или в начале), в котором применяется сдвиг.</param>
		// Token: 0x06000EFA RID: 3834 RVA: 0x00022351 File Offset: 0x00020551
		public void Shear(float shearX, float shearY, MatrixOrder order)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipShearMatrix(this.nativeMatrix, shearX, shearY, order));
		}

		/// <summary>Применяет геометрическое преобразование, представляемое этим объектом <see cref="T:System.Drawing.Drawing2D.Matrix" />, к указанному массиву точек.</summary>
		/// <param name="pts">Массив структур <see cref="T:System.Drawing.Point" />, который представляет точки для преобразования.</param>
		// Token: 0x06000EFB RID: 3835 RVA: 0x00022366 File Offset: 0x00020566
		public void TransformPoints(Point[] pts)
		{
			if (pts == null)
			{
				throw new ArgumentNullException("pts");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipTransformMatrixPointsI(this.nativeMatrix, pts, pts.Length));
		}

		/// <summary>Применяет геометрическое преобразование, представляемое этим объектом <see cref="T:System.Drawing.Drawing2D.Matrix" />, к указанному массиву точек.</summary>
		/// <param name="pts">Массив структур <see cref="T:System.Drawing.PointF" />, который представляет точки для преобразования.</param>
		// Token: 0x06000EFC RID: 3836 RVA: 0x0002238A File Offset: 0x0002058A
		public void TransformPoints(PointF[] pts)
		{
			if (pts == null)
			{
				throw new ArgumentNullException("pts");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipTransformMatrixPoints(this.nativeMatrix, pts, pts.Length));
		}

		/// <summary>Применяет только компоненты масштабирования и поворота этого объекта <see cref="T:System.Drawing.Drawing2D.Matrix" /> к указанному массиву точек.</summary>
		/// <param name="pts">Массив структур <see cref="T:System.Drawing.Point" />, который представляет точки для преобразования.</param>
		// Token: 0x06000EFD RID: 3837 RVA: 0x000223AE File Offset: 0x000205AE
		public void TransformVectors(Point[] pts)
		{
			if (pts == null)
			{
				throw new ArgumentNullException("pts");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipVectorTransformMatrixPointsI(this.nativeMatrix, pts, pts.Length));
		}

		/// <summary>Умножает каждый вектор массива на матрицу. Элементы смещения данной матрицы (третья строка) игнорируются.</summary>
		/// <param name="pts">Массив структур <see cref="T:System.Drawing.Point" />, который представляет точки для преобразования.</param>
		// Token: 0x06000EFE RID: 3838 RVA: 0x000223D2 File Offset: 0x000205D2
		public void TransformVectors(PointF[] pts)
		{
			if (pts == null)
			{
				throw new ArgumentNullException("pts");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipVectorTransformMatrixPoints(this.nativeMatrix, pts, pts.Length));
		}

		/// <summary>Применяет указанный вектор смещения (<paramref name="offsetX" /> и <paramref name="offsetY" />) к этому объекту <see cref="T:System.Drawing.Drawing2D.Matrix" />, добавляя вектор смещения в начало.</summary>
		/// <param name="offsetX">Величина x, на которую смещается этот объект <see cref="T:System.Drawing.Drawing2D.Matrix" />.</param>
		/// <param name="offsetY">Величина y, на которую смещается этот объект <see cref="T:System.Drawing.Drawing2D.Matrix" />.</param>
		// Token: 0x06000EFF RID: 3839 RVA: 0x000223F6 File Offset: 0x000205F6
		public void Translate(float offsetX, float offsetY)
		{
			this.Translate(offsetX, offsetY, MatrixOrder.Prepend);
		}

		/// <summary>Применяет указанный вектор ссмещения к этому объекту <see cref="T:System.Drawing.Drawing2D.Matrix" /> в указанном порядке.</summary>
		/// <param name="offsetX">Величина x, на которую смещается этот объект <see cref="T:System.Drawing.Drawing2D.Matrix" />.</param>
		/// <param name="offsetY">Величина y, на которую смещается этот объект <see cref="T:System.Drawing.Drawing2D.Matrix" />.</param>
		/// <param name="order">Объект <see cref="T:System.Drawing.Drawing2D.MatrixOrder" />, задающий порядок (в конце или в начале), в котором применяется смещение к этому объекту <see cref="T:System.Drawing.Drawing2D.Matrix" />.</param>
		// Token: 0x06000F00 RID: 3840 RVA: 0x00022401 File Offset: 0x00020601
		public void Translate(float offsetX, float offsetY, MatrixOrder order)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipTranslateMatrix(this.nativeMatrix, offsetX, offsetY, order));
		}

		/// <summary>Умножает каждый вектор массива на матрицу. Элементы смещения данной матрицы (третья строка) игнорируются.</summary>
		/// <param name="pts">Массив структур <see cref="T:System.Drawing.Point" />, который представляет точки для преобразования.</param>
		// Token: 0x06000F01 RID: 3841 RVA: 0x00022416 File Offset: 0x00020616
		public void VectorTransformPoints(Point[] pts)
		{
			this.TransformVectors(pts);
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x0002241F File Offset: 0x0002061F
		// (set) Token: 0x06000F03 RID: 3843 RVA: 0x00022427 File Offset: 0x00020627
		internal IntPtr NativeObject
		{
			get
			{
				return this.nativeMatrix;
			}
			set
			{
				this.nativeMatrix = value;
			}
		}

		// Token: 0x04000B78 RID: 2936
		internal IntPtr nativeMatrix;
	}
}
