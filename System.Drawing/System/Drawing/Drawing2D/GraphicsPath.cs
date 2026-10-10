using System;
using System.ComponentModel;

namespace System.Drawing.Drawing2D
{
	/// <summary>Представляет последовательность соединенных линий и кривых. Этот класс не наследуется.</summary>
	// Token: 0x02000155 RID: 341
	public sealed class GraphicsPath : MarshalByRefObject, ICloneable, IDisposable
	{
		// Token: 0x06000E57 RID: 3671 RVA: 0x000207CE File Offset: 0x0001E9CE
		private GraphicsPath(IntPtr ptr)
		{
			this.nativePath = ptr;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> со значением <see cref="P:System.Drawing.Drawing2D.GraphicsPath.FillMode" /> для объекта <see cref="F:System.Drawing.Drawing2D.FillMode.Alternate" />.</summary>
		// Token: 0x06000E58 RID: 3672 RVA: 0x000207E8 File Offset: 0x0001E9E8
		public GraphicsPath()
		{
			GDIPlus.CheckStatus(GDIPlus.GdipCreatePath(FillMode.Alternate, out this.nativePath));
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> с указанным перечислением <see cref="T:System.Drawing.Drawing2D.FillMode" />.</summary>
		/// <param name="fillMode">Перечисление <see cref="T:System.Drawing.Drawing2D.FillMode" />, определяющее, как заполняется внутренняя область этого объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</param>
		// Token: 0x06000E59 RID: 3673 RVA: 0x0002080C File Offset: 0x0001EA0C
		public GraphicsPath(FillMode fillMode)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipCreatePath(fillMode, out this.nativePath));
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> с заданными массивами <see cref="T:System.Drawing.Drawing2D.PathPointType" /> и <see cref="T:System.Drawing.Point" />.</summary>
		/// <param name="pts">Массив структур <see cref="T:System.Drawing.Point" />, определяющий координаты точек, составляющих этот объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</param>
		/// <param name="types">Массив элементов перечисления <see cref="T:System.Drawing.Drawing2D.PathPointType" />, определяющий тип каждой соответствующей точки в массиве <paramref name="pts" />.</param>
		// Token: 0x06000E5A RID: 3674 RVA: 0x00020830 File Offset: 0x0001EA30
		public GraphicsPath(Point[] pts, byte[] types) : this(pts, types, FillMode.Alternate)
		{
		}

		/// <summary>Инициализирует новый экземпляр массива <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> с заданными массивами <see cref="T:System.Drawing.Drawing2D.PathPointType" /> и <see cref="T:System.Drawing.PointF" />.</summary>
		/// <param name="pts">Массив структур <see cref="T:System.Drawing.PointF" />, определяющий координаты точек, составляющих этот объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</param>
		/// <param name="types">Массив элементов перечисления <see cref="T:System.Drawing.Drawing2D.PathPointType" />, определяющий тип каждой соответствующей точки в массиве <paramref name="pts" />.</param>
		// Token: 0x06000E5B RID: 3675 RVA: 0x0002083B File Offset: 0x0001EA3B
		public GraphicsPath(PointF[] pts, byte[] types) : this(pts, types, FillMode.Alternate)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> с указанными массивами <see cref="T:System.Drawing.Drawing2D.PathPointType" /> и <see cref="T:System.Drawing.Point" /> и с заданным элементом перечисления <see cref="T:System.Drawing.Drawing2D.FillMode" />.</summary>
		/// <param name="pts">Массив структур <see cref="T:System.Drawing.Point" />, определяющий координаты точек, составляющих этот объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</param>
		/// <param name="types">Массив элементов перечисления <see cref="T:System.Drawing.Drawing2D.PathPointType" />, определяющий тип каждой соответствующей точки в массиве <paramref name="pts" />.</param>
		/// <param name="fillMode">Перечисление <see cref="T:System.Drawing.Drawing2D.FillMode" />, определяющее, как заполняются внутренние области фигур в этом объекте <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</param>
		// Token: 0x06000E5C RID: 3676 RVA: 0x00020848 File Offset: 0x0001EA48
		public GraphicsPath(Point[] pts, byte[] types, FillMode fillMode)
		{
			if (pts == null)
			{
				throw new ArgumentNullException("pts");
			}
			if (pts.Length != types.Length)
			{
				throw new ArgumentException("Invalid parameter passed. Number of points and types must be same.");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipCreatePath2I(pts, types, pts.Length, fillMode, out this.nativePath));
		}

		/// <summary>Инициализирует новый экземпляр массива <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> с указанными массивами <see cref="T:System.Drawing.Drawing2D.PathPointType" /> и <see cref="T:System.Drawing.PointF" /> и заданным элементом перечисления <see cref="T:System.Drawing.Drawing2D.FillMode" />.</summary>
		/// <param name="pts">Массив структур <see cref="T:System.Drawing.PointF" />, определяющий координаты точек, составляющих этот объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</param>
		/// <param name="types">Массив элементов перечисления <see cref="T:System.Drawing.Drawing2D.PathPointType" />, определяющий тип каждой соответствующей точки в массиве <paramref name="pts" />.</param>
		/// <param name="fillMode">Перечисление <see cref="T:System.Drawing.Drawing2D.FillMode" />, определяющее, как заполняются внутренние области фигур в этом объекте <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</param>
		// Token: 0x06000E5D RID: 3677 RVA: 0x000208A0 File Offset: 0x0001EAA0
		public GraphicsPath(PointF[] pts, byte[] types, FillMode fillMode)
		{
			if (pts == null)
			{
				throw new ArgumentNullException("pts");
			}
			if (pts.Length != types.Length)
			{
				throw new ArgumentException("Invalid parameter passed. Number of points and types must be same.");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipCreatePath2(pts, types, pts.Length, fillMode, out this.nativePath));
		}

		/// <summary>Создает точную копию этого контура.</summary>
		/// <returns>
		///   <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />, создаваемый этим методом, приводится к типу объекта.</returns>
		// Token: 0x06000E5E RID: 3678 RVA: 0x000208F8 File Offset: 0x0001EAF8
		public object Clone()
		{
			IntPtr ptr;
			GDIPlus.CheckStatus(GDIPlus.GdipClonePath(this.nativePath, out ptr));
			return new GraphicsPath(ptr);
		}

		/// <summary>Освобождает все ресурсы, используемые этим объектом <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		// Token: 0x06000E5F RID: 3679 RVA: 0x0002091D File Offset: 0x0001EB1D
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Позволяет объекту попытаться освободить ресурсы и выполнить другие операции очистки, перед тем как он будет уничтожен во время сборки мусора.</summary>
		// Token: 0x06000E60 RID: 3680 RVA: 0x0002092C File Offset: 0x0001EB2C
		~GraphicsPath()
		{
			this.Dispose(false);
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x0002095C File Offset: 0x0001EB5C
		private void Dispose(bool disposing)
		{
			if (this.nativePath != IntPtr.Zero)
			{
				GDIPlus.CheckStatus(GDIPlus.GdipDeletePath(this.nativePath));
				this.nativePath = IntPtr.Zero;
			}
		}

		/// <summary>Получает или задает перечисление <see cref="T:System.Drawing.Drawing2D.FillMode" />, определяющее, как заполняются внутренние области фигур в этом объекте <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <returns>Перечисление <see cref="T:System.Drawing.Drawing2D.FillMode" />, определяющее, как заполняются внутренние области фигур в этом объекте <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</returns>
		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x0002098C File Offset: 0x0001EB8C
		// (set) Token: 0x06000E63 RID: 3683 RVA: 0x000209AC File Offset: 0x0001EBAC
		public FillMode FillMode
		{
			get
			{
				FillMode result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPathFillMode(this.nativePath, out result));
				return result;
			}
			set
			{
				if (value < FillMode.Alternate || value > FillMode.Winding)
				{
					throw new InvalidEnumArgumentException("FillMode", (int)value, typeof(FillMode));
				}
				GDIPlus.CheckStatus(GDIPlus.GdipSetPathFillMode(this.nativePath, value));
			}
		}

		/// <summary>Получает объект <see cref="T:System.Drawing.Drawing2D.PathData" />, инкапсулирующий массивы точек (<paramref name="points" />) и типов (<paramref name="types" />) для этого объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Drawing2D.PathData" />, инкапсулирующий массивы точек и типов для этого объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</returns>
		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x000209E0 File Offset: 0x0001EBE0
		public PathData PathData
		{
			get
			{
				int num;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPointCount(this.nativePath, out num));
				PointF[] points = new PointF[num];
				byte[] types = new byte[num];
				if (num > 0)
				{
					GDIPlus.CheckStatus(GDIPlus.GdipGetPathPoints(this.nativePath, points, num));
					GDIPlus.CheckStatus(GDIPlus.GdipGetPathTypes(this.nativePath, types, num));
				}
				return new PathData
				{
					Points = points,
					Types = types
				};
			}
		}

		/// <summary>Получает точки в контуре.</summary>
		/// <returns>Массив объектов <see cref="T:System.Drawing.PointF" />, представляющий контур.</returns>
		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x00020A48 File Offset: 0x0001EC48
		public PointF[] PathPoints
		{
			get
			{
				int num;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPointCount(this.nativePath, out num));
				if (num == 0)
				{
					throw new ArgumentException("PathPoints");
				}
				PointF[] array = new PointF[num];
				GDIPlus.CheckStatus(GDIPlus.GdipGetPathPoints(this.nativePath, array, num));
				return array;
			}
		}

		/// <summary>Получает типы соответствующих точек в массиве <see cref="P:System.Drawing.Drawing2D.GraphicsPath.PathPoints" />.</summary>
		/// <returns>Массив байтов, определяющий типы соответствующих точек в контуре.</returns>
		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x00020A90 File Offset: 0x0001EC90
		public byte[] PathTypes
		{
			get
			{
				int num;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPointCount(this.nativePath, out num));
				if (num == 0)
				{
					throw new ArgumentException("PathTypes");
				}
				byte[] array = new byte[num];
				GDIPlus.CheckStatus(GDIPlus.GdipGetPathTypes(this.nativePath, array, num));
				return array;
			}
		}

		/// <summary>Получает число элементов в массиве <see cref="P:System.Drawing.Drawing2D.GraphicsPath.PathPoints" /> или <see cref="P:System.Drawing.Drawing2D.GraphicsPath.PathTypes" />.</summary>
		/// <returns>Целое число, определяющее количество элементов в массиве <see cref="P:System.Drawing.Drawing2D.GraphicsPath.PathPoints" /> или <see cref="P:System.Drawing.Drawing2D.GraphicsPath.PathTypes" />.</returns>
		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x00020AD8 File Offset: 0x0001ECD8
		public int PointCount
		{
			get
			{
				int result;
				GDIPlus.CheckStatus(GDIPlus.GdipGetPointCount(this.nativePath, out result));
				return result;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x00020AF8 File Offset: 0x0001ECF8
		// (set) Token: 0x06000E69 RID: 3689 RVA: 0x00020B00 File Offset: 0x0001ED00
		internal IntPtr NativeObject
		{
			get
			{
				return this.nativePath;
			}
			set
			{
				this.nativePath = value;
			}
		}

		/// <summary>Присоединяет дугу эллипса к текущей фигуре.</summary>
		/// <param name="rect">Объект <see cref="T:System.Drawing.Rectangle" />, представляющий прямоугольник, ограничивающий эллипс, частью которого является дуга.</param>
		/// <param name="startAngle">Начальный угол дуги, измеряемый в градусах, от оси X по часовой стрелке.</param>
		/// <param name="sweepAngle">Угол между объектом <paramref name="startAngle" /> и концом дуги.</param>
		// Token: 0x06000E6A RID: 3690 RVA: 0x00020B09 File Offset: 0x0001ED09
		public void AddArc(Rectangle rect, float startAngle, float sweepAngle)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathArcI(this.nativePath, rect.X, rect.Y, rect.Width, rect.Height, startAngle, sweepAngle));
		}

		/// <summary>Присоединяет дугу эллипса к текущей фигуре.</summary>
		/// <param name="rect">Объект <see cref="T:System.Drawing.RectangleF" />, представляющий прямоугольник, ограничивающий эллипс, частью которого является дуга.</param>
		/// <param name="startAngle">Начальный угол дуги, измеряемый в градусах, от оси X по часовой стрелке.</param>
		/// <param name="sweepAngle">Угол между объектом <paramref name="startAngle" /> и концом дуги.</param>
		// Token: 0x06000E6B RID: 3691 RVA: 0x00020B39 File Offset: 0x0001ED39
		public void AddArc(RectangleF rect, float startAngle, float sweepAngle)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathArc(this.nativePath, rect.X, rect.Y, rect.Width, rect.Height, startAngle, sweepAngle));
		}

		/// <summary>Присоединяет дугу эллипса к текущей фигуре.</summary>
		/// <param name="x">Координата по оси X левого верхнего угла прямоугольной области, определяющей эллипс, дуга которого отображается.</param>
		/// <param name="y">Координата по оси Y левого верхнего угла прямоугольной области, определяющей эллипс, дуга которого отображается.</param>
		/// <param name="width">Ширина прямоугольной области, определяющей эллипс, дуга которого отображается.</param>
		/// <param name="height">Высота прямоугольной области, определяющей эллипс, дуга которого отображается.</param>
		/// <param name="startAngle">Начальный угол дуги, измеряемый в градусах, от оси X по часовой стрелке.</param>
		/// <param name="sweepAngle">Угол между объектом <paramref name="startAngle" /> и концом дуги.</param>
		// Token: 0x06000E6C RID: 3692 RVA: 0x00020B69 File Offset: 0x0001ED69
		public void AddArc(int x, int y, int width, int height, float startAngle, float sweepAngle)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathArcI(this.nativePath, x, y, width, height, startAngle, sweepAngle));
		}

		/// <summary>Присоединяет дугу эллипса к текущей фигуре.</summary>
		/// <param name="x">Координата по оси X левого верхнего угла прямоугольной области, определяющей эллипс, дуга которого отображается.</param>
		/// <param name="y">Координата по оси Y левого верхнего угла прямоугольной области, определяющей эллипс, дуга которого отображается.</param>
		/// <param name="width">Ширина прямоугольной области, определяющей эллипс, дуга которого отображается.</param>
		/// <param name="height">Высота прямоугольной области, определяющей эллипс, дуга которого отображается.</param>
		/// <param name="startAngle">Начальный угол дуги, измеряемый в градусах, от оси X по часовой стрелке.</param>
		/// <param name="sweepAngle">Угол между объектом <paramref name="startAngle" /> и концом дуги.</param>
		// Token: 0x06000E6D RID: 3693 RVA: 0x00020B84 File Offset: 0x0001ED84
		public void AddArc(float x, float y, float width, float height, float startAngle, float sweepAngle)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathArc(this.nativePath, x, y, width, height, startAngle, sweepAngle));
		}

		/// <summary>Добавляет в текущую фигуру кривую Безье третьего порядка.</summary>
		/// <param name="pt1">Объект <see cref="T:System.Drawing.Point" />, представляющий собой начальную точку кривой.</param>
		/// <param name="pt2">Объект <see cref="T:System.Drawing.Point" />, представляющий собой первую контрольную точку кривой.</param>
		/// <param name="pt3">Объект <see cref="T:System.Drawing.Point" />, представляющий собой вторую контрольную точку кривой.</param>
		/// <param name="pt4">Объект <see cref="T:System.Drawing.Point" />, представляющий конечную точку кривой.</param>
		// Token: 0x06000E6E RID: 3694 RVA: 0x00020BA0 File Offset: 0x0001EDA0
		public void AddBezier(Point pt1, Point pt2, Point pt3, Point pt4)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathBezierI(this.nativePath, pt1.X, pt1.Y, pt2.X, pt2.Y, pt3.X, pt3.Y, pt4.X, pt4.Y));
		}

		/// <summary>Добавляет в текущую фигуру кривую Безье третьего порядка.</summary>
		/// <param name="pt1">Объект <see cref="T:System.Drawing.PointF" />, представляющий собой начальную точку кривой.</param>
		/// <param name="pt2">Объект <see cref="T:System.Drawing.PointF" />, представляющий собой первую контрольную точку кривой.</param>
		/// <param name="pt3">Объект <see cref="T:System.Drawing.PointF" />, представляющий собой вторую контрольную точку кривой.</param>
		/// <param name="pt4">Объект <see cref="T:System.Drawing.PointF" />, представляющий конечную точку кривой.</param>
		// Token: 0x06000E6F RID: 3695 RVA: 0x00020BF8 File Offset: 0x0001EDF8
		public void AddBezier(PointF pt1, PointF pt2, PointF pt3, PointF pt4)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathBezier(this.nativePath, pt1.X, pt1.Y, pt2.X, pt2.Y, pt3.X, pt3.Y, pt4.X, pt4.Y));
		}

		/// <summary>Добавляет в текущую фигуру кривую Безье третьего порядка.</summary>
		/// <param name="x1">Координата X начальной точки кривой.</param>
		/// <param name="y1">Координата Y начальной точки кривой.</param>
		/// <param name="x2">Координата X первой контрольной точки кривой.</param>
		/// <param name="y2">Координата Y первой контрольной точки кривой.</param>
		/// <param name="x3">Координата X второй контрольной точки кривой.</param>
		/// <param name="y3">Координата Y второй контрольной точки кривой.</param>
		/// <param name="x4">Координата X конечной точки кривой.</param>
		/// <param name="y4">Координата Y конечной точки кривой.</param>
		// Token: 0x06000E70 RID: 3696 RVA: 0x00020C50 File Offset: 0x0001EE50
		public void AddBezier(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathBezierI(this.nativePath, x1, y1, x2, y2, x3, y3, x4, y4));
		}

		/// <summary>Добавляет в текущую фигуру кривую Безье третьего порядка.</summary>
		/// <param name="x1">Координата X начальной точки кривой.</param>
		/// <param name="y1">Координата Y начальной точки кривой.</param>
		/// <param name="x2">Координата X первой контрольной точки кривой.</param>
		/// <param name="y2">Координата Y первой контрольной точки кривой.</param>
		/// <param name="x3">Координата X второй контрольной точки кривой.</param>
		/// <param name="y3">Координата Y второй контрольной точки кривой.</param>
		/// <param name="x4">Координата X конечной точки кривой.</param>
		/// <param name="y4">Координата Y конечной точки кривой.</param>
		// Token: 0x06000E71 RID: 3697 RVA: 0x00020C7C File Offset: 0x0001EE7C
		public void AddBezier(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathBezier(this.nativePath, x1, y1, x2, y2, x3, y3, x4, y4));
		}

		/// <summary>Добавляет в текущую фигуру последовательность соединенных кривых Безье третьего порядка.</summary>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.Point" />, представляющий точки, которые определяют кривые.</param>
		// Token: 0x06000E72 RID: 3698 RVA: 0x00020CA6 File Offset: 0x0001EEA6
		public void AddBeziers(params Point[] points)
		{
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathBeziersI(this.nativePath, points, points.Length));
		}

		/// <summary>Добавляет в текущую фигуру последовательность соединенных кривых Безье третьего порядка.</summary>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.PointF" />, представляющий точки, которые определяют кривые.</param>
		// Token: 0x06000E73 RID: 3699 RVA: 0x00020CCA File Offset: 0x0001EECA
		public void AddBeziers(PointF[] points)
		{
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathBeziers(this.nativePath, points, points.Length));
		}

		/// <summary>Добавляет эллипс в текущий контур.</summary>
		/// <param name="rect">Объект <see cref="T:System.Drawing.RectangleF" />, содержащий ограничивающий прямоугольник, который определяет эллипс.</param>
		// Token: 0x06000E74 RID: 3700 RVA: 0x00020CEE File Offset: 0x0001EEEE
		public void AddEllipse(RectangleF rect)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathEllipse(this.nativePath, rect.X, rect.Y, rect.Width, rect.Height));
		}

		/// <summary>Добавляет эллипс в текущий контур.</summary>
		/// <param name="x">Координата X верхнего левого угла ограничивающего прямоугольника, который определяет эллипс.</param>
		/// <param name="y">Координата Y верхнего левого угла ограничивающего прямоугольника, который определяет эллипс.</param>
		/// <param name="width">Ширина ограничивающего прямоугольника, определяющего эллипс.</param>
		/// <param name="height">Высота ограничивающего прямоугольника, определяющего эллипс.</param>
		// Token: 0x06000E75 RID: 3701 RVA: 0x00020D1C File Offset: 0x0001EF1C
		public void AddEllipse(float x, float y, float width, float height)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathEllipse(this.nativePath, x, y, width, height));
		}

		/// <summary>Добавляет эллипс в текущий контур.</summary>
		/// <param name="rect">Объект <see cref="T:System.Drawing.Rectangle" />, содержащий ограничивающий прямоугольник, который определяет эллипс.</param>
		// Token: 0x06000E76 RID: 3702 RVA: 0x00020D33 File Offset: 0x0001EF33
		public void AddEllipse(Rectangle rect)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathEllipseI(this.nativePath, rect.X, rect.Y, rect.Width, rect.Height));
		}

		/// <summary>Добавляет эллипс в текущий контур.</summary>
		/// <param name="x">Координата X верхнего левого угла ограничивающего прямоугольника, который определяет эллипс.</param>
		/// <param name="y">Координата Y верхнего левого угла ограничивающего прямоугольника, который определяет эллипс.</param>
		/// <param name="width">Ширина ограничивающего прямоугольника, определяющего эллипс.</param>
		/// <param name="height">Высота ограничивающего прямоугольника, определяющего эллипс.</param>
		// Token: 0x06000E77 RID: 3703 RVA: 0x00020D61 File Offset: 0x0001EF61
		public void AddEllipse(int x, int y, int width, int height)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathEllipseI(this.nativePath, x, y, width, height));
		}

		/// <summary>Добавляет отрезок прямой к этому объекту <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <param name="pt1">Объект <see cref="T:System.Drawing.Point" />, представляющий начальную точку линии.</param>
		/// <param name="pt2">Объект <see cref="T:System.Drawing.Point" />, представляющий конечную точку линии.</param>
		// Token: 0x06000E78 RID: 3704 RVA: 0x00020D78 File Offset: 0x0001EF78
		public void AddLine(Point pt1, Point pt2)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathLineI(this.nativePath, pt1.X, pt1.Y, pt2.X, pt2.Y));
		}

		/// <summary>Добавляет отрезок прямой к этому объекту <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <param name="pt1">Объект <see cref="T:System.Drawing.PointF" />, представляющий начальную точку линии.</param>
		/// <param name="pt2">Объект <see cref="T:System.Drawing.PointF" />, представляющий конечную точку линии.</param>
		// Token: 0x06000E79 RID: 3705 RVA: 0x00020DA6 File Offset: 0x0001EFA6
		public void AddLine(PointF pt1, PointF pt2)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathLine(this.nativePath, pt1.X, pt1.Y, pt2.X, pt2.Y));
		}

		/// <summary>Добавляет отрезок прямой к текущей фигуре.</summary>
		/// <param name="x1">Координата X начальной точки линии.</param>
		/// <param name="y1">Координата Y начальной точки линии.</param>
		/// <param name="x2">Координата X конечной точки линии.</param>
		/// <param name="y2">Координата Y конечной точки линии.</param>
		// Token: 0x06000E7A RID: 3706 RVA: 0x00020DD4 File Offset: 0x0001EFD4
		public void AddLine(int x1, int y1, int x2, int y2)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathLineI(this.nativePath, x1, y1, x2, y2));
		}

		/// <summary>Добавляет отрезок прямой к этому объекту <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <param name="x1">Координата X начальной точки линии.</param>
		/// <param name="y1">Координата Y начальной точки линии.</param>
		/// <param name="x2">Координата X конечной точки линии.</param>
		/// <param name="y2">Координата Y конечной точки линии.</param>
		// Token: 0x06000E7B RID: 3707 RVA: 0x00020DEB File Offset: 0x0001EFEB
		public void AddLine(float x1, float y1, float x2, float y2)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathLine(this.nativePath, x1, y1, x2, y2));
		}

		/// <summary>Добавляет последовательность соединенных отрезков прямых в конец этого объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.Point" />, представляющий точки, которые определяют добавляемые отрезки прямых.</param>
		// Token: 0x06000E7C RID: 3708 RVA: 0x00020E02 File Offset: 0x0001F002
		public void AddLines(Point[] points)
		{
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			if (points.Length == 0)
			{
				throw new ArgumentException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathLine2I(this.nativePath, points, points.Length));
		}

		/// <summary>Добавляет последовательность соединенных отрезков прямых в конец этого объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.PointF" />, представляющий точки, которые определяют добавляемые отрезки прямых.</param>
		// Token: 0x06000E7D RID: 3709 RVA: 0x00020E35 File Offset: 0x0001F035
		public void AddLines(PointF[] points)
		{
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			if (points.Length == 0)
			{
				throw new ArgumentException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathLine2(this.nativePath, points, points.Length));
		}

		/// <summary>Добавляет контур сектора к данному контуру.</summary>
		/// <param name="rect">Объект <see cref="T:System.Drawing.Rectangle" />, представляющий ограничивающий прямоугольник, определяющий эллипс, сектор которого отображается.</param>
		/// <param name="startAngle">Начальный угол сектора, измеряемый в градусах от оси X по часовой стрелке.</param>
		/// <param name="sweepAngle">Угол между объектом <paramref name="startAngle" /> и концом сектора, измеряемый в градусах по часовой стрелке от объекта <paramref name="startAngle" />.</param>
		// Token: 0x06000E7E RID: 3710 RVA: 0x00020E68 File Offset: 0x0001F068
		public void AddPie(Rectangle rect, float startAngle, float sweepAngle)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathPie(this.nativePath, (float)rect.X, (float)rect.Y, (float)rect.Width, (float)rect.Height, startAngle, sweepAngle));
		}

		/// <summary>Добавляет контур сектора к данному контуру.</summary>
		/// <param name="x">Координата по оси X левого верхнего угла ограничивающего прямоугольника, определяющего эллипс, сектор которого отображается.</param>
		/// <param name="y">Координата по оси Y левого верхнего угла ограничивающего прямоугольника, определяющего эллипс, сектор которого отображается.</param>
		/// <param name="width">Ширина ограничивающего прямоугольника, определяющего эллипс, сектор которого отображается.</param>
		/// <param name="height">Высота ограничивающего прямоугольника, определяющего эллипс, сектор которого отображается.</param>
		/// <param name="startAngle">Начальный угол сектора, измеряемый в градусах от оси X по часовой стрелке.</param>
		/// <param name="sweepAngle">Угол между объектом <paramref name="startAngle" /> и концом сектора, измеряемый в градусах по часовой стрелке от объекта <paramref name="startAngle" />.</param>
		// Token: 0x06000E7F RID: 3711 RVA: 0x00020E9C File Offset: 0x0001F09C
		public void AddPie(int x, int y, int width, int height, float startAngle, float sweepAngle)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathPieI(this.nativePath, x, y, width, height, startAngle, sweepAngle));
		}

		/// <summary>Добавляет контур сектора к данному контуру.</summary>
		/// <param name="x">Координата по оси X левого верхнего угла ограничивающего прямоугольника, определяющего эллипс, сектор которого отображается.</param>
		/// <param name="y">Координата по оси Y левого верхнего угла ограничивающего прямоугольника, определяющего эллипс, сектор которого отображается.</param>
		/// <param name="width">Ширина ограничивающего прямоугольника, определяющего эллипс, сектор которого отображается.</param>
		/// <param name="height">Высота ограничивающего прямоугольника, определяющего эллипс, сектор которого отображается.</param>
		/// <param name="startAngle">Начальный угол сектора, измеряемый в градусах от оси X по часовой стрелке.</param>
		/// <param name="sweepAngle">Угол между объектом <paramref name="startAngle" /> и концом сектора, измеряемый в градусах по часовой стрелке от объекта <paramref name="startAngle" />.</param>
		// Token: 0x06000E80 RID: 3712 RVA: 0x00020EB7 File Offset: 0x0001F0B7
		public void AddPie(float x, float y, float width, float height, float startAngle, float sweepAngle)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathPie(this.nativePath, x, y, width, height, startAngle, sweepAngle));
		}

		/// <summary>Добавляет многоугольник к этому контуру.</summary>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.Point" />, определяющий добавляемый многоугольник.</param>
		// Token: 0x06000E81 RID: 3713 RVA: 0x00020ED2 File Offset: 0x0001F0D2
		public void AddPolygon(Point[] points)
		{
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathPolygonI(this.nativePath, points, points.Length));
		}

		/// <summary>Добавляет многоугольник к этому контуру.</summary>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.PointF" />, определяющий добавляемый многоугольник.</param>
		// Token: 0x06000E82 RID: 3714 RVA: 0x00020EF6 File Offset: 0x0001F0F6
		public void AddPolygon(PointF[] points)
		{
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathPolygon(this.nativePath, points, points.Length));
		}

		/// <summary>Добавляет прямоугольник к этому контуру.</summary>
		/// <param name="rect">Объект <see cref="T:System.Drawing.Rectangle" />, представляющий добавляемый прямоугольник.</param>
		// Token: 0x06000E83 RID: 3715 RVA: 0x00020F1A File Offset: 0x0001F11A
		public void AddRectangle(Rectangle rect)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathRectangleI(this.nativePath, rect.X, rect.Y, rect.Width, rect.Height));
		}

		/// <summary>Добавляет прямоугольник к этому контуру.</summary>
		/// <param name="rect">Объект <see cref="T:System.Drawing.RectangleF" />, представляющий добавляемый прямоугольник.</param>
		// Token: 0x06000E84 RID: 3716 RVA: 0x00020F48 File Offset: 0x0001F148
		public void AddRectangle(RectangleF rect)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathRectangle(this.nativePath, rect.X, rect.Y, rect.Width, rect.Height));
		}

		/// <summary>Добавляет последовательность прямоугольников к данному контуру.</summary>
		/// <param name="rects">Массив структур <see cref="T:System.Drawing.Rectangle" />, представляющий добавляемые прямоугольники.</param>
		// Token: 0x06000E85 RID: 3717 RVA: 0x00020F76 File Offset: 0x0001F176
		public void AddRectangles(Rectangle[] rects)
		{
			if (rects == null)
			{
				throw new ArgumentNullException("rects");
			}
			if (rects.Length == 0)
			{
				throw new ArgumentException("rects");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathRectanglesI(this.nativePath, rects, rects.Length));
		}

		/// <summary>Добавляет последовательность прямоугольников к данному контуру.</summary>
		/// <param name="rects">Массив структур <see cref="T:System.Drawing.RectangleF" />, представляющий добавляемые прямоугольники.</param>
		// Token: 0x06000E86 RID: 3718 RVA: 0x00020FA9 File Offset: 0x0001F1A9
		public void AddRectangles(RectangleF[] rects)
		{
			if (rects == null)
			{
				throw new ArgumentNullException("rects");
			}
			if (rects.Length == 0)
			{
				throw new ArgumentException("rects");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathRectangles(this.nativePath, rects, rects.Length));
		}

		/// <summary>Добавляет указанный объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> к этому контуру.</summary>
		/// <param name="addingPath">Добавляемый объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</param>
		/// <param name="connect">Логическое значение, определяющее, является ли первая фигура в добавленном контуре частью последней фигуры в данном контуре. Значение <see langword="true" /> указывает, что (если это возможно) первая фигура в добавленном контуре является частью последней фигуры в данном контуре. Значение <see langword="false" /> указывает, что первая фигура в добавленном контуре отделена от последней фигуры в данном контуре.</param>
		// Token: 0x06000E87 RID: 3719 RVA: 0x00020FDC File Offset: 0x0001F1DC
		public void AddPath(GraphicsPath addingPath, bool connect)
		{
			if (addingPath == null)
			{
				throw new ArgumentNullException("addingPath");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathPath(this.nativePath, addingPath.nativePath, connect));
		}

		/// <summary>Получает последнюю точку массива <see cref="P:System.Drawing.Drawing2D.GraphicsPath.PathPoints" /> для этого объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.PointF" />, представляющий последнюю точку в этом объекте <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</returns>
		// Token: 0x06000E88 RID: 3720 RVA: 0x00021004 File Offset: 0x0001F204
		public PointF GetLastPoint()
		{
			PointF result;
			GDIPlus.CheckStatus(GDIPlus.GdipGetPathLastPoint(this.nativePath, out result));
			return result;
		}

		/// <summary>Добавляет замкнутую кривую к этому контуру. Используется кривая фундаментального сплайна, поскольку кривая проходит через все точки массива.</summary>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.Point" />, представляющий точки, которые определяют кривую.</param>
		// Token: 0x06000E89 RID: 3721 RVA: 0x00021024 File Offset: 0x0001F224
		public void AddClosedCurve(Point[] points)
		{
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathClosedCurveI(this.nativePath, points, points.Length));
		}

		/// <summary>Добавляет замкнутую кривую к этому контуру. Используется кривая фундаментального сплайна, поскольку кривая проходит через все точки массива.</summary>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.PointF" />, представляющий точки, которые определяют кривую.</param>
		// Token: 0x06000E8A RID: 3722 RVA: 0x00021048 File Offset: 0x0001F248
		public void AddClosedCurve(PointF[] points)
		{
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathClosedCurve(this.nativePath, points, points.Length));
		}

		/// <summary>Добавляет замкнутую кривую к этому контуру. Используется кривая фундаментального сплайна, поскольку кривая проходит через все точки массива.</summary>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.Point" />, представляющий точки, которые определяют кривую.</param>
		/// <param name="tension">Значение между 0 и 1, определяющее степень изгиба кривой между точками; значение 0 соответствует наименьшей кривой (наиболее острый угол), а 1 – наиболее сглаженной кривой.</param>
		// Token: 0x06000E8B RID: 3723 RVA: 0x0002106C File Offset: 0x0001F26C
		public void AddClosedCurve(Point[] points, float tension)
		{
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathClosedCurve2I(this.nativePath, points, points.Length, tension));
		}

		/// <summary>Добавляет замкнутую кривую к этому контуру. Используется кривая фундаментального сплайна, поскольку кривая проходит через все точки массива.</summary>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.PointF" />, представляющий точки, которые определяют кривую.</param>
		/// <param name="tension">Значение между 0 и 1, определяющее степень изгиба кривой между точками; значение 0 соответствует наименьшей кривой (наиболее острый угол), а 1 – наиболее сглаженной кривой.</param>
		// Token: 0x06000E8C RID: 3724 RVA: 0x00021091 File Offset: 0x0001F291
		public void AddClosedCurve(PointF[] points, float tension)
		{
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathClosedCurve2(this.nativePath, points, points.Length, tension));
		}

		/// <summary>Добавляет в текущую фигуру кривую сплайна. Используется кривая фундаментального сплайна, поскольку кривая проходит через все точки массива.</summary>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.Point" />, представляющий точки, которые определяют кривую.</param>
		// Token: 0x06000E8D RID: 3725 RVA: 0x000210B6 File Offset: 0x0001F2B6
		public void AddCurve(Point[] points)
		{
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathCurveI(this.nativePath, points, points.Length));
		}

		/// <summary>Добавляет в текущую фигуру кривую сплайна. Используется кривая фундаментального сплайна, поскольку кривая проходит через все точки массива.</summary>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.PointF" />, представляющий точки, которые определяют кривую.</param>
		// Token: 0x06000E8E RID: 3726 RVA: 0x000210DA File Offset: 0x0001F2DA
		public void AddCurve(PointF[] points)
		{
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathCurve(this.nativePath, points, points.Length));
		}

		/// <summary>Добавляет в текущую фигуру кривую сплайна.</summary>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.Point" />, представляющий точки, которые определяют кривую.</param>
		/// <param name="tension">Значение, определяющее степень изгиба кривой между контрольными точками. Значения, превышающие 1, приводят к непредсказуемым результатам.</param>
		// Token: 0x06000E8F RID: 3727 RVA: 0x000210FE File Offset: 0x0001F2FE
		public void AddCurve(Point[] points, float tension)
		{
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathCurve2I(this.nativePath, points, points.Length, tension));
		}

		/// <summary>Добавляет в текущую фигуру кривую сплайна.</summary>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.PointF" />, представляющий точки, которые определяют кривую.</param>
		/// <param name="tension">Значение, определяющее степень изгиба кривой между контрольными точками. Значения, превышающие 1, приводят к непредсказуемым результатам.</param>
		// Token: 0x06000E90 RID: 3728 RVA: 0x00021123 File Offset: 0x0001F323
		public void AddCurve(PointF[] points, float tension)
		{
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathCurve2(this.nativePath, points, points.Length, tension));
		}

		/// <summary>Добавляет в текущую фигуру кривую сплайна.</summary>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.Point" />, представляющий точки, которые определяют кривую.</param>
		/// <param name="offset">Индекс элемента в массиве <paramref name="points" />, который используется в качестве первой точки кривой.</param>
		/// <param name="numberOfSegments">Значение, определяющее степень изгиба кривой между контрольными точками. Значения, превышающие 1, приводят к непредсказуемым результатам.</param>
		/// <param name="tension">Значение, определяющее степень изгиба кривой между контрольными точками. Значения, превышающие 1, приводят к непредсказуемым результатам.</param>
		// Token: 0x06000E91 RID: 3729 RVA: 0x00021148 File Offset: 0x0001F348
		public void AddCurve(Point[] points, int offset, int numberOfSegments, float tension)
		{
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathCurve3I(this.nativePath, points, points.Length, offset, numberOfSegments, tension));
		}

		/// <summary>Добавляет в текущую фигуру кривую сплайна.</summary>
		/// <param name="points">Массив структур <see cref="T:System.Drawing.PointF" />, представляющий точки, которые определяют кривую.</param>
		/// <param name="offset">Индекс элемента в массиве <paramref name="points" />, который используется в качестве первой точки кривой.</param>
		/// <param name="numberOfSegments">Количество сегментов, используемых для отображения кривой. Сегмент может быть определен как линия, соединяющая две точки.</param>
		/// <param name="tension">Значение, определяющее степень изгиба кривой между контрольными точками. Значения, превышающие 1, приводят к непредсказуемым результатам.</param>
		// Token: 0x06000E92 RID: 3730 RVA: 0x00021170 File Offset: 0x0001F370
		public void AddCurve(PointF[] points, int offset, int numberOfSegments, float tension)
		{
			if (points == null)
			{
				throw new ArgumentNullException("points");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathCurve3(this.nativePath, points, points.Length, offset, numberOfSegments, tension));
		}

		/// <summary>Очищает массивы <see cref="P:System.Drawing.Drawing2D.GraphicsPath.PathPoints" /> и <see cref="P:System.Drawing.Drawing2D.GraphicsPath.PathTypes" /> и устанавливает <see cref="T:System.Drawing.Drawing2D.FillMode" /> в <see cref="F:System.Drawing.Drawing2D.FillMode.Alternate" />.</summary>
		// Token: 0x06000E93 RID: 3731 RVA: 0x00021198 File Offset: 0x0001F398
		public void Reset()
		{
			GDIPlus.CheckStatus(GDIPlus.GdipResetPath(this.nativePath));
		}

		/// <summary>Изменяет порядок точек в массиве <see cref="P:System.Drawing.Drawing2D.GraphicsPath.PathPoints" /> этого объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> на противоположный.</summary>
		// Token: 0x06000E94 RID: 3732 RVA: 0x000211AA File Offset: 0x0001F3AA
		public void Reverse()
		{
			GDIPlus.CheckStatus(GDIPlus.GdipReversePath(this.nativePath));
		}

		/// <summary>Применяет матрицу преобразования к этому объекту <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <param name="matrix">Объект <see cref="T:System.Drawing.Drawing2D.Matrix" />, представляющий применяемое преобразование.</param>
		// Token: 0x06000E95 RID: 3733 RVA: 0x000211BC File Offset: 0x0001F3BC
		public void Transform(Matrix matrix)
		{
			if (matrix == null)
			{
				throw new ArgumentNullException("matrix");
			}
			GDIPlus.CheckStatus(GDIPlus.GdipTransformPath(this.nativePath, matrix.nativeMatrix));
		}

		/// <summary>Добавляет строку текста в этот контур.</summary>
		/// <param name="s">Добавляемый объект <see cref="T:System.String" />.</param>
		/// <param name="family">Объект <see cref="T:System.Drawing.FontFamily" />, представляющий имя шрифта, с использованием которого выводится текст.</param>
		/// <param name="style">Перечисление <see cref="T:System.Drawing.FontStyle" />, представляющее информацию о стиле текста (полужирный, курсив и т. д.). Оно должно быть приведено к целому числу (см. пример кода ниже в этом разделе).</param>
		/// <param name="emSize">Высота рамки максимального пробела, ограничивающей символ.</param>
		/// <param name="origin">Объект <see cref="T:System.Drawing.Point" />, представляющий точку начала текста.</param>
		/// <param name="format">Объект <see cref="T:System.Drawing.StringFormat" />, задающий информацию о форматировании текста, такую как интервал между строками и выравнивание.</param>
		// Token: 0x06000E96 RID: 3734 RVA: 0x000211E4 File Offset: 0x0001F3E4
		[MonoTODO("The StringFormat parameter is ignored when using libgdiplus.")]
		public void AddString(string s, FontFamily family, int style, float emSize, Point origin, StringFormat format)
		{
			this.AddString(s, family, style, emSize, new Rectangle
			{
				X = origin.X,
				Y = origin.Y
			}, format);
		}

		/// <summary>Добавляет строку текста в этот контур.</summary>
		/// <param name="s">Добавляемый объект <see cref="T:System.String" />.</param>
		/// <param name="family">Объект <see cref="T:System.Drawing.FontFamily" />, представляющий имя шрифта, с использованием которого выводится текст.</param>
		/// <param name="style">Перечисление <see cref="T:System.Drawing.FontStyle" />, представляющее информацию о стиле текста (полужирный, курсив и т. д.). Оно должно быть приведено к целому числу (см. пример кода ниже в этом разделе).</param>
		/// <param name="emSize">Высота рамки максимального пробела, ограничивающей символ.</param>
		/// <param name="origin">Объект <see cref="T:System.Drawing.PointF" />, представляющий точку начала текста.</param>
		/// <param name="format">Объект <see cref="T:System.Drawing.StringFormat" />, задающий информацию о форматировании текста, такую как интервал между строками и выравнивание.</param>
		// Token: 0x06000E97 RID: 3735 RVA: 0x00021224 File Offset: 0x0001F424
		[MonoTODO("The StringFormat parameter is ignored when using libgdiplus.")]
		public void AddString(string s, FontFamily family, int style, float emSize, PointF origin, StringFormat format)
		{
			this.AddString(s, family, style, emSize, new RectangleF
			{
				X = origin.X,
				Y = origin.Y
			}, format);
		}

		/// <summary>Добавляет строку текста в этот контур.</summary>
		/// <param name="s">Добавляемый объект <see cref="T:System.String" />.</param>
		/// <param name="family">Объект <see cref="T:System.Drawing.FontFamily" />, представляющий имя шрифта, с использованием которого выводится текст.</param>
		/// <param name="style">Перечисление <see cref="T:System.Drawing.FontStyle" />, представляющее информацию о стиле текста (полужирный, курсив и т. д.). Оно должно быть приведено к целому числу (см. пример кода ниже в этом разделе).</param>
		/// <param name="emSize">Высота рамки максимального пробела, ограничивающей символ.</param>
		/// <param name="layoutRect">Объект <see cref="T:System.Drawing.Rectangle" />, представляющий прямоугольник, который ограничивает текст.</param>
		/// <param name="format">Объект <see cref="T:System.Drawing.StringFormat" />, задающий информацию о форматировании текста, такую как интервал между строками и выравнивание.</param>
		// Token: 0x06000E98 RID: 3736 RVA: 0x00021264 File Offset: 0x0001F464
		[MonoTODO("The layoutRect and StringFormat parameters are ignored when using libgdiplus.")]
		public void AddString(string s, FontFamily family, int style, float emSize, Rectangle layoutRect, StringFormat format)
		{
			if (family == null)
			{
				throw new ArgumentException("family");
			}
			IntPtr format2 = (format == null) ? IntPtr.Zero : format.NativeObject;
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathStringI(this.nativePath, s, s.Length, family.NativeFamily, style, emSize, ref layoutRect, format2));
		}

		/// <summary>Добавляет строку текста в этот контур.</summary>
		/// <param name="s">Добавляемый объект <see cref="T:System.String" />.</param>
		/// <param name="family">Объект <see cref="T:System.Drawing.FontFamily" />, представляющий имя шрифта, с использованием которого выводится текст.</param>
		/// <param name="style">Перечисление <see cref="T:System.Drawing.FontStyle" />, представляющее информацию о стиле текста (полужирный, курсив и т. д.). Оно должно быть приведено к целому числу (см. пример кода ниже в этом разделе).</param>
		/// <param name="emSize">Высота рамки максимального пробела, ограничивающей символ.</param>
		/// <param name="layoutRect">Объект <see cref="T:System.Drawing.RectangleF" />, представляющий прямоугольник, который ограничивает текст.</param>
		/// <param name="format">Объект <see cref="T:System.Drawing.StringFormat" />, задающий информацию о форматировании текста, такую как интервал между строками и выравнивание.</param>
		// Token: 0x06000E99 RID: 3737 RVA: 0x000212B8 File Offset: 0x0001F4B8
		[MonoTODO("The layoutRect and StringFormat parameters are ignored when using libgdiplus.")]
		public void AddString(string s, FontFamily family, int style, float emSize, RectangleF layoutRect, StringFormat format)
		{
			if (family == null)
			{
				throw new ArgumentException("family");
			}
			IntPtr format2 = (format == null) ? IntPtr.Zero : format.NativeObject;
			GDIPlus.CheckStatus(GDIPlus.GdipAddPathString(this.nativePath, s, s.Length, family.NativeFamily, style, emSize, ref layoutRect, format2));
		}

		/// <summary>Удаляет все токены из этого контура.</summary>
		// Token: 0x06000E9A RID: 3738 RVA: 0x00021309 File Offset: 0x0001F509
		public void ClearMarkers()
		{
			GDIPlus.CheckStatus(GDIPlus.GdipClearPathMarkers(this.nativePath));
		}

		/// <summary>Замыкает все незамкнутые фигуры в этом контуре и открывает новую фигуру. Каждая незамкнутая фигура замыкается путем соединения ее начальной и конечной точек линией.</summary>
		// Token: 0x06000E9B RID: 3739 RVA: 0x0002131B File Offset: 0x0001F51B
		public void CloseAllFigures()
		{
			GDIPlus.CheckStatus(GDIPlus.GdipClosePathFigures(this.nativePath));
		}

		/// <summary>Замыкает текущую фигуру и открывает новую фигуру. Если текущая фигура содержит последовательность соединенных линий и кривых, метод замыкает ее путем соединения начальной и конечной точек линией.</summary>
		// Token: 0x06000E9C RID: 3740 RVA: 0x0002132D File Offset: 0x0001F52D
		public void CloseFigure()
		{
			GDIPlus.CheckStatus(GDIPlus.GdipClosePathFigure(this.nativePath));
		}

		/// <summary>Преобразует каждую кривую в данном контуре в последовательность соединенных отрезков прямых.</summary>
		// Token: 0x06000E9D RID: 3741 RVA: 0x0002133F File Offset: 0x0001F53F
		public void Flatten()
		{
			this.Flatten(null, 0.25f);
		}

		/// <summary>Применяет указанное преобразование, а затем преобразует каждую кривую в данном объекте <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> в последовательность соединенных отрезков прямых.</summary>
		/// <param name="matrix">Объект <see cref="T:System.Drawing.Drawing2D.Matrix" />, посредством которого необходимо преобразовать этот объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> перед выравниванием.</param>
		// Token: 0x06000E9E RID: 3742 RVA: 0x0002134D File Offset: 0x0001F54D
		public void Flatten(Matrix matrix)
		{
			this.Flatten(matrix, 0.25f);
		}

		/// <summary>Преобразует каждую кривую в этом объекте <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> в последовательность соединенных отрезков прямых.</summary>
		/// <param name="matrix">Объект <see cref="T:System.Drawing.Drawing2D.Matrix" />, посредством которого необходимо преобразовать этот объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> перед выравниванием.</param>
		/// <param name="flatness">Указывает максимальное допустимое расхождение между кривой и ее выровненной аппроксимацией. Значение по умолчанию равно 0,25. Уменьшение значения выровненности увеличивает количество отрезков прямых в аппроксимации.</param>
		// Token: 0x06000E9F RID: 3743 RVA: 0x0002135C File Offset: 0x0001F55C
		public void Flatten(Matrix matrix, float flatness)
		{
			IntPtr matrix2 = (matrix == null) ? IntPtr.Zero : matrix.nativeMatrix;
			GDIPlus.CheckStatus(GDIPlus.GdipFlattenPath(this.nativePath, matrix2, flatness));
		}

		/// <summary>Возвращает прямоугольник, ограничивающий этот объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.RectangleF" />, представляющий прямоугольник, который ограничивает этот объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</returns>
		// Token: 0x06000EA0 RID: 3744 RVA: 0x0002138C File Offset: 0x0001F58C
		public RectangleF GetBounds()
		{
			return this.GetBounds(null, null);
		}

		/// <summary>Возвращает ограничивающий прямоугольник для этого объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />, когда данный контур преобразуется с помощью указанного объекта <see cref="T:System.Drawing.Drawing2D.Matrix" />.</summary>
		/// <param name="matrix">Объект <see cref="T:System.Drawing.Drawing2D.Matrix" />, определяющий преобразование, которое нужно применить к данному контуру до вычисления ограничивающего прямоугольника. Этот контур не преобразуется постоянно; преобразование используется только для процесса вычисления ограничивающего прямоугольника.</param>
		/// <returns>Объект <see cref="T:System.Drawing.RectangleF" />, представляющий прямоугольник, который ограничивает этот объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</returns>
		// Token: 0x06000EA1 RID: 3745 RVA: 0x00021396 File Offset: 0x0001F596
		public RectangleF GetBounds(Matrix matrix)
		{
			return this.GetBounds(matrix, null);
		}

		/// <summary>Возвращает ограничивающий прямоугольник для этого объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />, когда данный контур преобразуется с помощью указанного объекта <see cref="T:System.Drawing.Drawing2D.Matrix" /> и отображается с помощью заданного объекта <see cref="T:System.Drawing.Pen" />.</summary>
		/// <param name="matrix">Объект <see cref="T:System.Drawing.Drawing2D.Matrix" />, определяющий преобразование, которое нужно применить к данному контуру до вычисления ограничивающего прямоугольника. Этот контур не преобразуется постоянно; преобразование используется только для процесса вычисления ограничивающего прямоугольника.</param>
		/// <param name="pen">Объект <see cref="T:System.Drawing.Pen" />, посредством которого производится отображение объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</param>
		/// <returns>Объект <see cref="T:System.Drawing.RectangleF" />, представляющий прямоугольник, который ограничивает этот объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</returns>
		// Token: 0x06000EA2 RID: 3746 RVA: 0x000213A0 File Offset: 0x0001F5A0
		public RectangleF GetBounds(Matrix matrix, Pen pen)
		{
			IntPtr matrix2 = (matrix == null) ? IntPtr.Zero : matrix.nativeMatrix;
			IntPtr pen2 = (pen == null) ? IntPtr.Zero : pen.NativePen;
			RectangleF result;
			GDIPlus.CheckStatus(GDIPlus.GdipGetPathWorldBounds(this.nativePath, out result, matrix2, pen2));
			return result;
		}

		/// <summary>Указывает, содержится ли определенная точка внутри контура этого объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> при его отображении с помощью указанного объекта <see cref="T:System.Drawing.Pen" />.</summary>
		/// <param name="point">Объект <see cref="T:System.Drawing.Point" />, определяющий местоположение для тестирования.</param>
		/// <param name="pen">Объект <see cref="T:System.Drawing.Pen" /> для проверки.</param>
		/// <returns>Этот метод возвращает значение <see langword="true" />, если указанная точка содержится внутри контура данного объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> при отображении его с помощью указанного объекта <see cref="T:System.Drawing.Pen" />; в противном случае, возвращается значение <see langword="false" />.</returns>
		// Token: 0x06000EA3 RID: 3747 RVA: 0x000213E4 File Offset: 0x0001F5E4
		public bool IsOutlineVisible(Point point, Pen pen)
		{
			return this.IsOutlineVisible(point.X, point.Y, pen, null);
		}

		/// <summary>Указывает, содержится ли определенная точка внутри контура этого объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> при его отображении с помощью указанного объекта <see cref="T:System.Drawing.Pen" />.</summary>
		/// <param name="point">Объект <see cref="T:System.Drawing.PointF" />, определяющий местоположение для тестирования.</param>
		/// <param name="pen">Объект <see cref="T:System.Drawing.Pen" /> для проверки.</param>
		/// <returns>Этот метод возвращает значение <see langword="true" />, если указанная точка содержится внутри контура данного объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> при отображении его с помощью указанного объекта <see cref="T:System.Drawing.Pen" />; в противном случае, возвращается значение <see langword="false" />.</returns>
		// Token: 0x06000EA4 RID: 3748 RVA: 0x000213FC File Offset: 0x0001F5FC
		public bool IsOutlineVisible(PointF point, Pen pen)
		{
			return this.IsOutlineVisible(point.X, point.Y, pen, null);
		}

		/// <summary>Указывает, содержится ли определенная точка внутри контура этого объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> при его отображении с помощью указанного объекта <see cref="T:System.Drawing.Pen" />.</summary>
		/// <param name="x">Координата тестируемой точки по оси X.</param>
		/// <param name="y">Координата тестируемой точки по оси Y.</param>
		/// <param name="pen">Объект <see cref="T:System.Drawing.Pen" /> для проверки.</param>
		/// <returns>Этот метод возвращает значение <see langword="true" />, если указанная точка содержится внутри контура данного объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> при отображении его с помощью указанного объекта <see cref="T:System.Drawing.Pen" />; в противном случае, возвращается значение <see langword="false" />.</returns>
		// Token: 0x06000EA5 RID: 3749 RVA: 0x00021414 File Offset: 0x0001F614
		public bool IsOutlineVisible(int x, int y, Pen pen)
		{
			return this.IsOutlineVisible(x, y, pen, null);
		}

		/// <summary>Указывает, содержится ли определенная точка внутри контура этого объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> при его отображении с помощью указанного объекта <see cref="T:System.Drawing.Pen" />.</summary>
		/// <param name="x">Координата тестируемой точки по оси X.</param>
		/// <param name="y">Координата тестируемой точки по оси Y.</param>
		/// <param name="pen">Объект <see cref="T:System.Drawing.Pen" /> для проверки.</param>
		/// <returns>Этот метод возвращает значение <see langword="true" />, если указанная точка содержится внутри контура данного объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> при отображении его с помощью указанного объекта <see cref="T:System.Drawing.Pen" />; в противном случае, возвращается значение <see langword="false" />.</returns>
		// Token: 0x06000EA6 RID: 3750 RVA: 0x00021420 File Offset: 0x0001F620
		public bool IsOutlineVisible(float x, float y, Pen pen)
		{
			return this.IsOutlineVisible(x, y, pen, null);
		}

		/// <summary>Указывает, содержится ли определенная точка внутри контура этого объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> при его отображении с помощью указанного объекта <see cref="T:System.Drawing.Pen" /> и использовании заданного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="pt">Объект <see cref="T:System.Drawing.Point" />, определяющий местоположение для тестирования.</param>
		/// <param name="pen">Объект <see cref="T:System.Drawing.Pen" /> для проверки.</param>
		/// <param name="graphics">Объект <see cref="T:System.Drawing.Graphics" />, видимость которого следует проверить.</param>
		/// <returns>Этот метод возвращает значение <see langword="true" />, если указанная точка содержится внутри контура данного объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> при отображении его с помощью указанного объекта <see cref="T:System.Drawing.Pen" />; в противном случае, возвращается значение <see langword="false" />.</returns>
		// Token: 0x06000EA7 RID: 3751 RVA: 0x0002142C File Offset: 0x0001F62C
		public bool IsOutlineVisible(Point pt, Pen pen, Graphics graphics)
		{
			return this.IsOutlineVisible(pt.X, pt.Y, pen, graphics);
		}

		/// <summary>Указывает, содержится ли определенная точка внутри контура этого объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> при его отображении с помощью указанного объекта <see cref="T:System.Drawing.Pen" /> и использовании заданного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="pt">Объект <see cref="T:System.Drawing.PointF" />, определяющий местоположение для тестирования.</param>
		/// <param name="pen">Объект <see cref="T:System.Drawing.Pen" /> для проверки.</param>
		/// <param name="graphics">Объект <see cref="T:System.Drawing.Graphics" />, видимость которого следует проверить.</param>
		/// <returns>Этот метод возвращает значение <see langword="true" />, если указанная точка содержится внутри (под) контура данного объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> при отображении его с помощью указанного объекта <see cref="T:System.Drawing.Pen" />; в противном случае, возвращается значение <see langword="false" />.</returns>
		// Token: 0x06000EA8 RID: 3752 RVA: 0x00021444 File Offset: 0x0001F644
		public bool IsOutlineVisible(PointF pt, Pen pen, Graphics graphics)
		{
			return this.IsOutlineVisible(pt.X, pt.Y, pen, graphics);
		}

		/// <summary>Указывает, содержится ли определенная точка внутри контура этого объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> при его отображении с помощью указанного объекта <see cref="T:System.Drawing.Pen" /> и использовании заданного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="x">Координата тестируемой точки по оси X.</param>
		/// <param name="y">Координата тестируемой точки по оси Y.</param>
		/// <param name="pen">Объект <see cref="T:System.Drawing.Pen" /> для проверки.</param>
		/// <param name="graphics">Объект <see cref="T:System.Drawing.Graphics" />, видимость которого следует проверить.</param>
		/// <returns>Этот метод возвращает значение <see langword="true" />, если указанная точка содержится внутри контура данного объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> при отображении его с помощью указанного объекта <see cref="T:System.Drawing.Pen" />; в противном случае, возвращается значение <see langword="false" />.</returns>
		// Token: 0x06000EA9 RID: 3753 RVA: 0x0002145C File Offset: 0x0001F65C
		public bool IsOutlineVisible(int x, int y, Pen pen, Graphics graphics)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			IntPtr graphics2 = (graphics == null) ? IntPtr.Zero : graphics.nativeObject;
			bool result;
			GDIPlus.CheckStatus(GDIPlus.GdipIsOutlineVisiblePathPointI(this.nativePath, x, y, pen.NativePen, graphics2, out result));
			return result;
		}

		/// <summary>Указывает, содержится ли определенная точка внутри контура этого объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> при его отображении с помощью указанного объекта <see cref="T:System.Drawing.Pen" /> и использовании заданного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="x">Координата тестируемой точки по оси X.</param>
		/// <param name="y">Координата тестируемой точки по оси Y.</param>
		/// <param name="pen">Объект <see cref="T:System.Drawing.Pen" /> для проверки.</param>
		/// <param name="graphics">Объект <see cref="T:System.Drawing.Graphics" />, видимость которого следует проверить.</param>
		/// <returns>Этот метод возвращает значение <see langword="true" />, если указанная точка содержится внутри (под) контура данного объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> при отображении его с помощью указанного объекта <see cref="T:System.Drawing.Pen" />; в противном случае, возвращается значение <see langword="false" />.</returns>
		// Token: 0x06000EAA RID: 3754 RVA: 0x000214A8 File Offset: 0x0001F6A8
		public bool IsOutlineVisible(float x, float y, Pen pen, Graphics graphics)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			IntPtr graphics2 = (graphics == null) ? IntPtr.Zero : graphics.nativeObject;
			bool result;
			GDIPlus.CheckStatus(GDIPlus.GdipIsOutlineVisiblePathPoint(this.nativePath, x, y, pen.NativePen, graphics2, out result));
			return result;
		}

		/// <summary>Указывает, содержится ли указанная точка внутри этого объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <param name="point">Объект <see cref="T:System.Drawing.Point" />, определяющий проверяемую точку.</param>
		/// <returns>Этот метод возвращает значение <see langword="true" />, если указанная точка содержится в данном объекте <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />; в противном случае, возвращается значение <see langword="false" />.</returns>
		// Token: 0x06000EAB RID: 3755 RVA: 0x000214F2 File Offset: 0x0001F6F2
		public bool IsVisible(Point point)
		{
			return this.IsVisible(point.X, point.Y, null);
		}

		/// <summary>Указывает, содержится ли указанная точка внутри этого объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <param name="point">Объект <see cref="T:System.Drawing.PointF" />, определяющий проверяемую точку.</param>
		/// <returns>Этот метод возвращает значение <see langword="true" />, если указанная точка содержится в данном объекте <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />; в противном случае, возвращается значение <see langword="false" />.</returns>
		// Token: 0x06000EAC RID: 3756 RVA: 0x00021509 File Offset: 0x0001F709
		public bool IsVisible(PointF point)
		{
			return this.IsVisible(point.X, point.Y, null);
		}

		/// <summary>Указывает, содержится ли указанная точка внутри этого объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <param name="x">Координата тестируемой точки по оси X.</param>
		/// <param name="y">Координата тестируемой точки по оси Y.</param>
		/// <returns>Этот метод возвращает значение <see langword="true" />, если указанная точка содержится в данном объекте <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />; в противном случае, возвращается значение <see langword="false" />.</returns>
		// Token: 0x06000EAD RID: 3757 RVA: 0x00021520 File Offset: 0x0001F720
		public bool IsVisible(int x, int y)
		{
			return this.IsVisible(x, y, null);
		}

		/// <summary>Указывает, содержится ли указанная точка внутри этого объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <param name="x">Координата тестируемой точки по оси X.</param>
		/// <param name="y">Координата тестируемой точки по оси Y.</param>
		/// <returns>Этот метод возвращает значение <see langword="true" />, если указанная точка содержится в данном объекте <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />; в противном случае, возвращается значение <see langword="false" />.</returns>
		// Token: 0x06000EAE RID: 3758 RVA: 0x0002152B File Offset: 0x0001F72B
		public bool IsVisible(float x, float y)
		{
			return this.IsVisible(x, y, null);
		}

		/// <summary>Указывает, содержится ли указанная точка внутри этого объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <param name="pt">Объект <see cref="T:System.Drawing.Point" />, определяющий проверяемую точку.</param>
		/// <param name="graphics">Объект <see cref="T:System.Drawing.Graphics" />, видимость которого следует проверить.</param>
		/// <returns>Этот метод возвращает значение <see langword="true" />, если указанная точка содержится в данном объекте <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />; в противном случае, возвращается значение <see langword="false" />.</returns>
		// Token: 0x06000EAF RID: 3759 RVA: 0x00021536 File Offset: 0x0001F736
		public bool IsVisible(Point pt, Graphics graphics)
		{
			return this.IsVisible(pt.X, pt.Y, graphics);
		}

		/// <summary>Указывает, содержится ли указанная точка внутри этого объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <param name="pt">Объект <see cref="T:System.Drawing.PointF" />, определяющий проверяемую точку.</param>
		/// <param name="graphics">Объект <see cref="T:System.Drawing.Graphics" />, видимость которого следует проверить.</param>
		/// <returns>Этот метод возвращает значение <see langword="true" />, если указанная точка содержится в данном объекте; в противном случае, возвращается значение <see langword="false" />.</returns>
		// Token: 0x06000EB0 RID: 3760 RVA: 0x0002154D File Offset: 0x0001F74D
		public bool IsVisible(PointF pt, Graphics graphics)
		{
			return this.IsVisible(pt.X, pt.Y, graphics);
		}

		/// <summary>Указывает, содержится ли указанная точка внутри этого объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />, путем использования заданного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="x">Координата тестируемой точки по оси X.</param>
		/// <param name="y">Координата тестируемой точки по оси Y.</param>
		/// <param name="graphics">Объект <see cref="T:System.Drawing.Graphics" />, видимость которого следует проверить.</param>
		/// <returns>Этот метод возвращает значение <see langword="true" />, если указанная точка содержится в данном объекте <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />; в противном случае, возвращается значение <see langword="false" />.</returns>
		// Token: 0x06000EB1 RID: 3761 RVA: 0x00021564 File Offset: 0x0001F764
		public bool IsVisible(int x, int y, Graphics graphics)
		{
			IntPtr graphics2 = (graphics == null) ? IntPtr.Zero : graphics.nativeObject;
			bool result;
			GDIPlus.CheckStatus(GDIPlus.GdipIsVisiblePathPointI(this.nativePath, x, y, graphics2, out result));
			return result;
		}

		/// <summary>Указывает, содержится ли указанная точка внутри этого объекта <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> в видимой вырезанной области заданного объекта <see cref="T:System.Drawing.Graphics" />.</summary>
		/// <param name="x">Координата тестируемой точки по оси X.</param>
		/// <param name="y">Координата тестируемой точки по оси Y.</param>
		/// <param name="graphics">Объект <see cref="T:System.Drawing.Graphics" />, видимость которого следует проверить.</param>
		/// <returns>Этот метод возвращает значение <see langword="true" />, если указанная точка содержится в данном объекте <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />; в противном случае, возвращается значение <see langword="false" />.</returns>
		// Token: 0x06000EB2 RID: 3762 RVA: 0x00021598 File Offset: 0x0001F798
		public bool IsVisible(float x, float y, Graphics graphics)
		{
			IntPtr graphics2 = (graphics == null) ? IntPtr.Zero : graphics.nativeObject;
			bool result;
			GDIPlus.CheckStatus(GDIPlus.GdipIsVisiblePathPoint(this.nativePath, x, y, graphics2, out result));
			return result;
		}

		/// <summary>Устанавливает токен на этом объекте <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		// Token: 0x06000EB3 RID: 3763 RVA: 0x000215CC File Offset: 0x0001F7CC
		public void SetMarkers()
		{
			GDIPlus.CheckStatus(GDIPlus.GdipSetPathMarker(this.nativePath));
		}

		/// <summary>Открывает новую фигуру, не замыкая при этом текущую фигуру. Все последующие точки, добавляемые к контуру, добавляются к этой новой фигуре.</summary>
		// Token: 0x06000EB4 RID: 3764 RVA: 0x000215DE File Offset: 0x0001F7DE
		public void StartFigure()
		{
			GDIPlus.CheckStatus(GDIPlus.GdipStartPathFigure(this.nativePath));
		}

		/// <summary>Применяет преобразование перекоса, определяемое прямоугольником и параллелограммом, к этому объекту <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <param name="destPoints">Массив структур <see cref="T:System.Drawing.PointF" />, определяющий параллелограмм, в который преобразуется прямоугольник, заданный объектом <paramref name="srcRect" />. Массив может содержать три или четыре элемента. Если массив содержит три элемента, то правый нижний угол параллелограмма вычисляется из первых трех точек.</param>
		/// <param name="srcRect">Объект <see cref="T:System.Drawing.RectangleF" />, представляющий прямоугольник, который преобразуется в параллелограмм, определяемый объектом <paramref name="destPoints" />.</param>
		// Token: 0x06000EB5 RID: 3765 RVA: 0x000215F0 File Offset: 0x0001F7F0
		[MonoTODO("GdipWarpPath isn't implemented in libgdiplus")]
		public void Warp(PointF[] destPoints, RectangleF srcRect)
		{
			this.Warp(destPoints, srcRect, null, WarpMode.Perspective, 0.25f);
		}

		/// <summary>Применяет преобразование перекоса, определяемое прямоугольником и параллелограммом, к этому объекту <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <param name="destPoints">Массив структур <see cref="T:System.Drawing.PointF" />, определяющий параллелограмм, в который преобразуется прямоугольник, заданный объектом <paramref name="srcRect" />. Массив может содержать три или четыре элемента. Если массив содержит три элемента, то правый нижний угол параллелограмма вычисляется из первых трех точек.</param>
		/// <param name="srcRect">Объект <see cref="T:System.Drawing.RectangleF" />, представляющий прямоугольник, который преобразуется в параллелограмм, определяемый объектом <paramref name="destPoints" />.</param>
		/// <param name="matrix">Объект <see cref="T:System.Drawing.Drawing2D.Matrix" />, определяющий геометрическое преобразование для контура.</param>
		// Token: 0x06000EB6 RID: 3766 RVA: 0x00021601 File Offset: 0x0001F801
		[MonoTODO("GdipWarpPath isn't implemented in libgdiplus")]
		public void Warp(PointF[] destPoints, RectangleF srcRect, Matrix matrix)
		{
			this.Warp(destPoints, srcRect, matrix, WarpMode.Perspective, 0.25f);
		}

		/// <summary>Применяет преобразование перекоса, определяемое прямоугольником и параллелограммом, к этому объекту <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <param name="destPoints">Массив структур <see cref="T:System.Drawing.PointF" />, определяющий параллелограмм, в который преобразуется прямоугольник, заданный объектом <paramref name="srcRect" />. Массив может содержать три или четыре элемента. Если массив содержит три элемента, то правый нижний угол параллелограмма вычисляется из первых трех точек.</param>
		/// <param name="srcRect">Объект <see cref="T:System.Drawing.RectangleF" />, представляющий прямоугольник, который преобразуется в параллелограмм, определяемый объектом <paramref name="destPoints" />.</param>
		/// <param name="matrix">Объект <see cref="T:System.Drawing.Drawing2D.Matrix" />, определяющий геометрическое преобразование для контура.</param>
		/// <param name="warpMode">Перечисление <see cref="T:System.Drawing.Drawing2D.WarpMode" />, указывающее, перспективный или билинейный режим использует операция перекоса.</param>
		// Token: 0x06000EB7 RID: 3767 RVA: 0x00021612 File Offset: 0x0001F812
		[MonoTODO("GdipWarpPath isn't implemented in libgdiplus")]
		public void Warp(PointF[] destPoints, RectangleF srcRect, Matrix matrix, WarpMode warpMode)
		{
			this.Warp(destPoints, srcRect, matrix, warpMode, 0.25f);
		}

		/// <summary>Применяет преобразование перекоса, определяемое прямоугольником и параллелограммом, к этому объекту <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <param name="destPoints">Массив структур <see cref="T:System.Drawing.PointF" />, определяющий параллелограмм, в который преобразуется прямоугольник, заданный объектом <paramref name="srcRect" />. Массив может содержать три или четыре элемента. Если массив содержит три элемента, то правый нижний угол параллелограмма вычисляется из первых трех точек.</param>
		/// <param name="srcRect">Объект <see cref="T:System.Drawing.RectangleF" />, представляющий прямоугольник, который преобразуется в параллелограмм, определяемый объектом <paramref name="destPoints" />.</param>
		/// <param name="matrix">Объект <see cref="T:System.Drawing.Drawing2D.Matrix" />, определяющий геометрическое преобразование для контура.</param>
		/// <param name="warpMode">Перечисление <see cref="T:System.Drawing.Drawing2D.WarpMode" />, указывающее, перспективный или билинейный режим использует операция перекоса.</param>
		/// <param name="flatness">Значение от 0 до 1, определяющее, насколько гладок результирующий контур. Для получения дополнительных сведений см. методы <see cref="M:System.Drawing.Drawing2D.GraphicsPath.Flatten" />.</param>
		// Token: 0x06000EB8 RID: 3768 RVA: 0x00021624 File Offset: 0x0001F824
		[MonoTODO("GdipWarpPath isn't implemented in libgdiplus")]
		public void Warp(PointF[] destPoints, RectangleF srcRect, Matrix matrix, WarpMode warpMode, float flatness)
		{
			if (destPoints == null)
			{
				throw new ArgumentNullException("destPoints");
			}
			IntPtr matrix2 = (matrix == null) ? IntPtr.Zero : matrix.nativeMatrix;
			GDIPlus.CheckStatus(GDIPlus.GdipWarpPath(this.nativePath, matrix2, destPoints, destPoints.Length, srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height, warpMode, flatness));
		}

		/// <summary>Добавляет дополнительное очертание к контуру.</summary>
		/// <param name="pen">Объект <see cref="T:System.Drawing.Pen" />, определяющий расстояние между исходными очертаниями контура и новыми очертаниями, которые создает данный метод.</param>
		// Token: 0x06000EB9 RID: 3769 RVA: 0x00021685 File Offset: 0x0001F885
		[MonoTODO("GdipWidenPath isn't implemented in libgdiplus")]
		public void Widen(Pen pen)
		{
			this.Widen(pen, null, 0.25f);
		}

		/// <summary>Добавляет дополнительное очертание в объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" />.</summary>
		/// <param name="pen">Объект <see cref="T:System.Drawing.Pen" />, определяющий расстояние между исходными очертаниями контура и новыми очертаниями, которые создает данный метод.</param>
		/// <param name="matrix">Объект <see cref="T:System.Drawing.Drawing2D.Matrix" />, определяющий геометрическое преобразование для контура перед расширением.</param>
		// Token: 0x06000EBA RID: 3770 RVA: 0x00021694 File Offset: 0x0001F894
		[MonoTODO("GdipWidenPath isn't implemented in libgdiplus")]
		public void Widen(Pen pen, Matrix matrix)
		{
			this.Widen(pen, matrix, 0.25f);
		}

		/// <summary>Заменяет данный объект <see cref="T:System.Drawing.Drawing2D.GraphicsPath" /> кривыми, окружающими область, заполняемую при отображении контура указанным пером.</summary>
		/// <param name="pen">Объект <see cref="T:System.Drawing.Pen" />, определяющий расстояние между исходными очертаниями контура и новыми очертаниями, которые создает данный метод.</param>
		/// <param name="matrix">Объект <see cref="T:System.Drawing.Drawing2D.Matrix" />, определяющий геометрическое преобразование для контура перед расширением.</param>
		/// <param name="flatness">Значение, указывающее сглаженность кривых.</param>
		// Token: 0x06000EBB RID: 3771 RVA: 0x000216A4 File Offset: 0x0001F8A4
		[MonoTODO("GdipWidenPath isn't implemented in libgdiplus")]
		public void Widen(Pen pen, Matrix matrix, float flatness)
		{
			if (pen == null)
			{
				throw new ArgumentNullException("pen");
			}
			if (this.PointCount == 0)
			{
				return;
			}
			IntPtr matrix2 = (matrix == null) ? IntPtr.Zero : matrix.nativeMatrix;
			GDIPlus.CheckStatus(GDIPlus.GdipWidenPath(this.nativePath, pen.NativePen, matrix2, flatness));
		}

		// Token: 0x04000B74 RID: 2932
		private const float FlatnessDefault = 0.25f;

		// Token: 0x04000B75 RID: 2933
		internal IntPtr nativePath = IntPtr.Zero;
	}
}
