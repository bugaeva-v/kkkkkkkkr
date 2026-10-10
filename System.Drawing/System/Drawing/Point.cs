using System;
using System.ComponentModel;
using System.Numerics.Hashing;

namespace System.Drawing
{
	/// <summary>Представляет упорядоченную пару целых чисел — координат Х и Y, определяющую точку на двумерной плоскости.</summary>
	// Token: 0x02000047 RID: 71
	[TypeConverter(typeof(PointConverter))]
	[Serializable]
	public struct Point : IEquatable<Point>
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Point" /> с указанными координатами.</summary>
		/// <param name="x">Положение точки по горизонтали.</param>
		/// <param name="y">Положение точки по вертикали.</param>
		// Token: 0x06000237 RID: 567 RVA: 0x0000702D File Offset: 0x0000522D
		public Point(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Point" /> из <see cref="T:System.Drawing.Size" />.</summary>
		/// <param name="sz">
		///   <see cref="T:System.Drawing.Size" />, задающий координаты нового объекта <see cref="T:System.Drawing.Point" />.</param>
		// Token: 0x06000238 RID: 568 RVA: 0x0000703D File Offset: 0x0000523D
		public Point(Size sz)
		{
			this.x = sz.Width;
			this.y = sz.Height;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Point" />, используя в качестве координат указанное целое значение.</summary>
		/// <param name="dw">32-разрядное целое число, задающее координаты для нового объекта <see cref="T:System.Drawing.Point" />.</param>
		// Token: 0x06000239 RID: 569 RVA: 0x00007059 File Offset: 0x00005259
		public Point(int dw)
		{
			this.x = (int)Point.LowInt16(dw);
			this.y = (int)Point.HighInt16(dw);
		}

		/// <summary>Возвращает значение, указывающее, пуст ли массив <see cref="T:System.Drawing.Point" />.</summary>
		/// <returns>Значение<see langword="true" />, если оба свойства <see cref="P:System.Drawing.Point.X" /> и <see cref="P:System.Drawing.Point.Y" /> равны 0, в противном случае возвращается значение <see langword="false" />.</returns>
		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00007073 File Offset: 0x00005273
		[Browsable(false)]
		public bool IsEmpty
		{
			get
			{
				return this.x == 0 && this.y == 0;
			}
		}

		/// <summary>Возвращает или задает координату Х точки <see cref="T:System.Drawing.Point" />.</summary>
		/// <returns>Координата Х точки <see cref="T:System.Drawing.Point" />.</returns>
		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00007088 File Offset: 0x00005288
		// (set) Token: 0x0600023C RID: 572 RVA: 0x00007090 File Offset: 0x00005290
		public int X
		{
			get
			{
				return this.x;
			}
			set
			{
				this.x = value;
			}
		}

		/// <summary>Возвращает или задает координату Y точки <see cref="T:System.Drawing.Point" />.</summary>
		/// <returns>Координата Y точки <see cref="T:System.Drawing.Point" />.</returns>
		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600023D RID: 573 RVA: 0x00007099 File Offset: 0x00005299
		// (set) Token: 0x0600023E RID: 574 RVA: 0x000070A1 File Offset: 0x000052A1
		public int Y
		{
			get
			{
				return this.y;
			}
			set
			{
				this.y = value;
			}
		}

		/// <summary>Преобразует указанную структуру <see cref="T:System.Drawing.Point" /> в структуру <see cref="T:System.Drawing.PointF" />.</summary>
		/// <param name="p">Преобразуемая структура <see cref="T:System.Drawing.Point" />.</param>
		/// <returns>Объект <see cref="T:System.Drawing.PointF" />, являющийся результатом преобразования.</returns>
		// Token: 0x0600023F RID: 575 RVA: 0x000070AA File Offset: 0x000052AA
		public static implicit operator PointF(Point p)
		{
			return new PointF((float)p.X, (float)p.Y);
		}

		/// <summary>Преобразует указанную структуру <see cref="T:System.Drawing.Point" /> в структуру <see cref="T:System.Drawing.Size" />.</summary>
		/// <param name="p">Преобразуемая структура <see cref="T:System.Drawing.Point" />.</param>
		/// <returns>Объект <see cref="T:System.Drawing.Size" />, являющийся результатом преобразования.</returns>
		// Token: 0x06000240 RID: 576 RVA: 0x000070C1 File Offset: 0x000052C1
		public static explicit operator Size(Point p)
		{
			return new Size(p.X, p.Y);
		}

		/// <summary>Смещает точку <see cref="T:System.Drawing.Point" /> на заданное значение <see cref="T:System.Drawing.Size" />.</summary>
		/// <param name="pt">Класс <see cref="T:System.Drawing.Point" /> для преобразования.</param>
		/// <param name="sz">Объект <see cref="T:System.Drawing.Size" />, определяющий пару чисел, которые нужно добавить к значениям координат <paramref name="pt" />.</param>
		/// <returns>Смещенная точка <see cref="T:System.Drawing.Point" />.</returns>
		// Token: 0x06000241 RID: 577 RVA: 0x000070D6 File Offset: 0x000052D6
		public static Point operator +(Point pt, Size sz)
		{
			return Point.Add(pt, sz);
		}

		/// <summary>Смещает <see cref="T:System.Drawing.Point" /> на отрицательное значение, заданное параметром <see cref="T:System.Drawing.Size" />.</summary>
		/// <param name="pt">Класс <see cref="T:System.Drawing.Point" /> для преобразования.</param>
		/// <param name="sz">Объект <see cref="T:System.Drawing.Size" />, задающий пару чисел, вычитаемых из координат параметра <paramref name="pt" />.</param>
		/// <returns>Структура <see cref="T:System.Drawing.Point" />, преобразуемая при помощи отрицательного значения заданной структуры <see cref="T:System.Drawing.Size" />.</returns>
		// Token: 0x06000242 RID: 578 RVA: 0x000070DF File Offset: 0x000052DF
		public static Point operator -(Point pt, Size sz)
		{
			return Point.Subtract(pt, sz);
		}

		/// <summary>Сравнивает два объекта <see cref="T:System.Drawing.Point" />. Результат определяет, равны значения свойств <see cref="P:System.Drawing.Point.X" /> и <see cref="P:System.Drawing.Point.Y" /> двух объектов <see cref="T:System.Drawing.Point" /> или нет.</summary>
		/// <param name="left">Ключ <see cref="T:System.Drawing.Point" /> для сравнения.</param>
		/// <param name="right">Ключ <see cref="T:System.Drawing.Point" /> для сравнения.</param>
		/// <returns>Значение <see langword="true" />, если значения <see cref="P:System.Drawing.Point.X" /> и <see cref="P:System.Drawing.Point.Y" /> параметров <paramref name="left" /> и <paramref name="right" /> равны, в противном случае значение <see langword="false" />.</returns>
		// Token: 0x06000243 RID: 579 RVA: 0x000070E8 File Offset: 0x000052E8
		public static bool operator ==(Point left, Point right)
		{
			return left.X == right.X && left.Y == right.Y;
		}

		/// <summary>Сравнивает два объекта <see cref="T:System.Drawing.Point" />. Результат показывает неравенство значений свойств <see cref="P:System.Drawing.Point.X" /> или <see cref="P:System.Drawing.Point.Y" /> двух объектов <see cref="T:System.Drawing.Point" />.</summary>
		/// <param name="left">Ключ <see cref="T:System.Drawing.Point" /> для сравнения.</param>
		/// <param name="right">Ключ <see cref="T:System.Drawing.Point" /> для сравнения.</param>
		/// <returns>Значение <see langword="true" />, если значения либо свойств <see cref="P:System.Drawing.Point.X" />, либо свойств <see cref="P:System.Drawing.Point.Y" /> параметров <paramref name="left" /> и <paramref name="right" /> отличаются, в противном случае значение <see langword="false" />.</returns>
		// Token: 0x06000244 RID: 580 RVA: 0x0000710C File Offset: 0x0000530C
		public static bool operator !=(Point left, Point right)
		{
			return !(left == right);
		}

		/// <summary>Добавляет заданный размер <see cref="T:System.Drawing.Size" /> к точке <see cref="T:System.Drawing.Point" />.</summary>
		/// <param name="pt">Добавляемый объект <see cref="T:System.Drawing.Point" />.</param>
		/// <param name="sz">Точка <see cref="T:System.Drawing.Size" /> для добавления.</param>
		/// <returns>Точка <see cref="T:System.Drawing.Point" />, представляющая результат операции добавления.</returns>
		// Token: 0x06000245 RID: 581 RVA: 0x00007118 File Offset: 0x00005318
		public static Point Add(Point pt, Size sz)
		{
			return new Point(pt.X + sz.Width, pt.Y + sz.Height);
		}

		/// <summary>Возвращает результат вычитания заданного размера <see cref="T:System.Drawing.Size" /> из заданной точки <see cref="T:System.Drawing.Point" />.</summary>
		/// <param name="pt">Точка <see cref="T:System.Drawing.Point" />, из которой осуществляется вычитание.</param>
		/// <param name="sz">Размер <see cref="T:System.Drawing.Size" />, вычитаемый из точки <see cref="T:System.Drawing.Point" />.</param>
		/// <returns>Точка <see cref="T:System.Drawing.Point" />, полученная в результате операции вычитания.</returns>
		// Token: 0x06000246 RID: 582 RVA: 0x0000713D File Offset: 0x0000533D
		public static Point Subtract(Point pt, Size sz)
		{
			return new Point(pt.X - sz.Width, pt.Y - sz.Height);
		}

		/// <summary>Преобразует указанную структуру <see cref="T:System.Drawing.PointF" /> в структуру <see cref="T:System.Drawing.Point" />, округляя значения <see cref="T:System.Drawing.PointF" /> до ближайшего большего целого числа.</summary>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Drawing.PointF" />.</param>
		/// <returns>Объект <see cref="T:System.Drawing.Point" />, который является результатом преобразований этого метода.</returns>
		// Token: 0x06000247 RID: 583 RVA: 0x00007162 File Offset: 0x00005362
		public static Point Ceiling(PointF value)
		{
			return new Point((int)Math.Ceiling((double)value.X), (int)Math.Ceiling((double)value.Y));
		}

		/// <summary>Преобразует указанную точку <see cref="T:System.Drawing.PointF" /> в точку <see cref="T:System.Drawing.Point" /> путем усечения значений объекта <see cref="T:System.Drawing.Point" />.</summary>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Drawing.PointF" />.</param>
		/// <returns>Объект <see cref="T:System.Drawing.Point" />, который является результатом преобразований этого метода.</returns>
		// Token: 0x06000248 RID: 584 RVA: 0x00007185 File Offset: 0x00005385
		public static Point Truncate(PointF value)
		{
			return new Point((int)value.X, (int)value.Y);
		}

		/// <summary>Преобразует указанный объект <see cref="T:System.Drawing.PointF" /> в <see cref="T:System.Drawing.Point" />, округляя значения <see cref="T:System.Drawing.Point" /> до ближайших целых чисел.</summary>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Drawing.PointF" />.</param>
		/// <returns>Объект <see cref="T:System.Drawing.Point" />, который является результатом преобразований этого метода.</returns>
		// Token: 0x06000249 RID: 585 RVA: 0x0000719C File Offset: 0x0000539C
		public static Point Round(PointF value)
		{
			return new Point((int)Math.Round((double)value.X), (int)Math.Round((double)value.Y));
		}

		/// <summary>Определяет, содержит ли объект <see cref="T:System.Drawing.Point" /> те же координаты, что и указанный объект <see cref="T:System.Object" />.</summary>
		/// <param name="obj">Объект <see cref="T:System.Object" /> для проверки.</param>
		/// <returns>Значение <see langword="true" />, если параметром <paramref name="obj" /> является объект <see cref="T:System.Drawing.Point" /> с тем же координатами, что и у объекта <see cref="T:System.Drawing.Point" />.</returns>
		// Token: 0x0600024A RID: 586 RVA: 0x000071BF File Offset: 0x000053BF
		public override bool Equals(object obj)
		{
			return obj is Point && this.Equals((Point)obj);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000071D7 File Offset: 0x000053D7
		public bool Equals(Point other)
		{
			return this == other;
		}

		/// <summary>Возвращает хэш-код для данного свойства <see cref="T:System.Drawing.Point" />.</summary>
		/// <returns>Целочисленное значение, определяющее хэш-код для этой структуры <see cref="T:System.Drawing.Point" />.</returns>
		// Token: 0x0600024C RID: 588 RVA: 0x000071E5 File Offset: 0x000053E5
		public override int GetHashCode()
		{
			return HashHelpers.Combine(this.X, this.Y);
		}

		/// <summary>Преобразует объект <see cref="T:System.Drawing.Point" /> на заданную величину.</summary>
		/// <param name="dx">Величина смещения по оси X.</param>
		/// <param name="dy">Величина смещения по оси Y.</param>
		// Token: 0x0600024D RID: 589 RVA: 0x000071F8 File Offset: 0x000053F8
		public void Offset(int dx, int dy)
		{
			this.X += dx;
			this.Y += dy;
		}

		/// <summary>Смещает точку <see cref="T:System.Drawing.Point" /> на указанную точку <see cref="T:System.Drawing.Point" />.</summary>
		/// <param name="p">Точка <see cref="T:System.Drawing.Point" />, полученная смещением на значения точки <see cref="T:System.Drawing.Point" />.</param>
		// Token: 0x0600024E RID: 590 RVA: 0x00007216 File Offset: 0x00005416
		public void Offset(Point p)
		{
			this.Offset(p.X, p.Y);
		}

		/// <summary>Преобразует объект <see cref="T:System.Drawing.Point" /> в строку, доступную для чтения.</summary>
		/// <returns>Строка, представляющая эту структуру <see cref="T:System.Drawing.Point" />.</returns>
		// Token: 0x0600024F RID: 591 RVA: 0x0000722C File Offset: 0x0000542C
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"{X=",
				this.X.ToString(),
				",Y=",
				this.Y.ToString(),
				"}"
			});
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000727E File Offset: 0x0000547E
		private static short HighInt16(int n)
		{
			return (short)(n >> 16 & 65535);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000728B File Offset: 0x0000548B
		private static short LowInt16(int n)
		{
			return (short)(n & 65535);
		}

		/// <summary>Представляет объект <see cref="T:System.Drawing.Point" />, у которого значения <see cref="P:System.Drawing.Point.X" /> и <see cref="P:System.Drawing.Point.Y" /> установлены равными нулю.</summary>
		// Token: 0x0400038B RID: 907
		public static readonly Point Empty;

		// Token: 0x0400038C RID: 908
		private int x;

		// Token: 0x0400038D RID: 909
		private int y;
	}
}
