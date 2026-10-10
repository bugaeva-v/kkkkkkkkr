using System;
using System.ComponentModel;
using System.Numerics.Hashing;

namespace System.Drawing
{
	/// <summary>Представляет упорядоченную пару координат Х и Y с плавающей запятой, определяющую точку на двумерной плоскости.</summary>
	// Token: 0x02000048 RID: 72
	[Serializable]
	public struct PointF : IEquatable<PointF>
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.PointF" /> с указанными координатами.</summary>
		/// <param name="x">Положение точки по горизонтали.</param>
		/// <param name="y">Положение точки по вертикали.</param>
		// Token: 0x06000253 RID: 595 RVA: 0x00007295 File Offset: 0x00005495
		public PointF(float x, float y)
		{
			this.x = x;
			this.y = y;
		}

		/// <summary>Возвращает значение, указывающее, пуст ли массив <see cref="T:System.Drawing.PointF" />.</summary>
		/// <returns>Значение<see langword="true" />, если оба свойства <see cref="P:System.Drawing.PointF.X" /> и <see cref="P:System.Drawing.PointF.Y" /> равны 0, в противном случае возвращается значение <see langword="false" />.</returns>
		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000254 RID: 596 RVA: 0x000072A5 File Offset: 0x000054A5
		[Browsable(false)]
		public bool IsEmpty
		{
			get
			{
				return this.x == 0f && this.y == 0f;
			}
		}

		/// <summary>Возвращает или задает координату Х точки <see cref="T:System.Drawing.PointF" />.</summary>
		/// <returns>Координата Х точки <see cref="T:System.Drawing.PointF" />.</returns>
		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000255 RID: 597 RVA: 0x000072C3 File Offset: 0x000054C3
		// (set) Token: 0x06000256 RID: 598 RVA: 0x000072CB File Offset: 0x000054CB
		public float X
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

		/// <summary>Возвращает или задает координату Y точки <see cref="T:System.Drawing.PointF" />.</summary>
		/// <returns>Координата Y точки <see cref="T:System.Drawing.PointF" />.</returns>
		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000257 RID: 599 RVA: 0x000072D4 File Offset: 0x000054D4
		// (set) Token: 0x06000258 RID: 600 RVA: 0x000072DC File Offset: 0x000054DC
		public float Y
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

		/// <summary>Смещает точку <see cref="T:System.Drawing.PointF" /> на заданное значение <see cref="T:System.Drawing.Size" />.</summary>
		/// <param name="pt">Класс <see cref="T:System.Drawing.PointF" /> для преобразования.</param>
		/// <param name="sz">Объект <see cref="T:System.Drawing.Size" />, определяющий пару чисел, которые нужно добавить к значениям координат <paramref name="pt" />.</param>
		/// <returns>Смещенная точка <see cref="T:System.Drawing.PointF" />.</returns>
		// Token: 0x06000259 RID: 601 RVA: 0x000072E5 File Offset: 0x000054E5
		public static PointF operator +(PointF pt, Size sz)
		{
			return PointF.Add(pt, sz);
		}

		/// <summary>Смещает <see cref="T:System.Drawing.PointF" /> на отрицательное значение, заданное параметром <see cref="T:System.Drawing.Size" />.</summary>
		/// <param name="pt">Класс <see cref="T:System.Drawing.PointF" /> для преобразования.</param>
		/// <param name="sz">Размер <see cref="T:System.Drawing.Size" />, указывающий числа для вычитания из координат <paramref name="pt" />.</param>
		/// <returns>Смещенная точка <see cref="T:System.Drawing.PointF" />.</returns>
		// Token: 0x0600025A RID: 602 RVA: 0x000072EE File Offset: 0x000054EE
		public static PointF operator -(PointF pt, Size sz)
		{
			return PointF.Subtract(pt, sz);
		}

		/// <summary>Смещает указанную точку <see cref="T:System.Drawing.PointF" /> на заданное значение <see cref="T:System.Drawing.SizeF" />.</summary>
		/// <param name="pt">Класс <see cref="T:System.Drawing.PointF" /> для преобразования.</param>
		/// <param name="sz">Размер <see cref="T:System.Drawing.SizeF" />, указывающий числа для добавления к координатам X и Y точки <see cref="T:System.Drawing.PointF" />.</param>
		/// <returns>Смещенная точка <see cref="T:System.Drawing.PointF" />.</returns>
		// Token: 0x0600025B RID: 603 RVA: 0x000072F7 File Offset: 0x000054F7
		public static PointF operator +(PointF pt, SizeF sz)
		{
			return PointF.Add(pt, sz);
		}

		/// <summary>Смещает точку <see cref="T:System.Drawing.PointF" /> на отрицательную величину заданного размера <see cref="T:System.Drawing.SizeF" />.</summary>
		/// <param name="pt">Класс <see cref="T:System.Drawing.PointF" /> для преобразования.</param>
		/// <param name="sz">Размер <see cref="T:System.Drawing.SizeF" />, указывающий числа для вычитания из координат <paramref name="pt" />.</param>
		/// <returns>Смещенная точка <see cref="T:System.Drawing.PointF" />.</returns>
		// Token: 0x0600025C RID: 604 RVA: 0x00007300 File Offset: 0x00005500
		public static PointF operator -(PointF pt, SizeF sz)
		{
			return PointF.Subtract(pt, sz);
		}

		/// <summary>Сравнивает две структуры <see cref="T:System.Drawing.PointF" />. Результат определяет, равны или нет значения свойств <see cref="P:System.Drawing.PointF.X" /> и <see cref="P:System.Drawing.PointF.Y" /> двух структур <see cref="T:System.Drawing.PointF" />.</summary>
		/// <param name="left">Ключ <see cref="T:System.Drawing.PointF" /> для сравнения.</param>
		/// <param name="right">Ключ <see cref="T:System.Drawing.PointF" /> для сравнения.</param>
		/// <returns>Значение <see langword="true" />, если значения <see cref="P:System.Drawing.PointF.X" /> и <see cref="P:System.Drawing.PointF.Y" /> левой и правой структур <see cref="T:System.Drawing.PointF" /> равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600025D RID: 605 RVA: 0x00007309 File Offset: 0x00005509
		public static bool operator ==(PointF left, PointF right)
		{
			return left.X == right.X && left.Y == right.Y;
		}

		/// <summary>Определяет неравенство координат указанных точек.</summary>
		/// <param name="left">Ключ <see cref="T:System.Drawing.PointF" /> для сравнения.</param>
		/// <param name="right">Ключ <see cref="T:System.Drawing.PointF" /> для сравнения.</param>
		/// <returns>Значение <see langword="true" />, чтобы указать, что значения <see cref="P:System.Drawing.PointF.X" /> и <see cref="P:System.Drawing.PointF.Y" /> параметров <paramref name="left" /> и <paramref name="right" /> не равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600025E RID: 606 RVA: 0x0000732D File Offset: 0x0000552D
		public static bool operator !=(PointF left, PointF right)
		{
			return !(left == right);
		}

		/// <summary>Смещает указанную точку <see cref="T:System.Drawing.PointF" /> на заданное значение <see cref="T:System.Drawing.Size" />.</summary>
		/// <param name="pt">Класс <see cref="T:System.Drawing.PointF" /> для преобразования.</param>
		/// <param name="sz">Объект <see cref="T:System.Drawing.Size" />, определяющий числа, которые нужно добавить к значениям координат <paramref name="pt" />.</param>
		/// <returns>Смещенная точка <see cref="T:System.Drawing.PointF" />.</returns>
		// Token: 0x0600025F RID: 607 RVA: 0x00007339 File Offset: 0x00005539
		public static PointF Add(PointF pt, Size sz)
		{
			return new PointF(pt.X + (float)sz.Width, pt.Y + (float)sz.Height);
		}

		/// <summary>Смещает <see cref="T:System.Drawing.PointF" /> на отрицательную величину заданного размера.</summary>
		/// <param name="pt">Класс <see cref="T:System.Drawing.PointF" /> для преобразования.</param>
		/// <param name="sz">Размер <see cref="T:System.Drawing.Size" />, указывающий числа для вычитания из координат <paramref name="pt" />.</param>
		/// <returns>Смещенная точка <see cref="T:System.Drawing.PointF" />.</returns>
		// Token: 0x06000260 RID: 608 RVA: 0x00007360 File Offset: 0x00005560
		public static PointF Subtract(PointF pt, Size sz)
		{
			return new PointF(pt.X - (float)sz.Width, pt.Y - (float)sz.Height);
		}

		/// <summary>Смещает указанную точку <see cref="T:System.Drawing.PointF" /> на заданное значение <see cref="T:System.Drawing.SizeF" />.</summary>
		/// <param name="pt">Класс <see cref="T:System.Drawing.PointF" /> для преобразования.</param>
		/// <param name="sz">Объект <see cref="T:System.Drawing.SizeF" />, определяющий числа, которые нужно добавить к значениям координат <paramref name="pt" />.</param>
		/// <returns>Смещенная точка <see cref="T:System.Drawing.PointF" />.</returns>
		// Token: 0x06000261 RID: 609 RVA: 0x00007387 File Offset: 0x00005587
		public static PointF Add(PointF pt, SizeF sz)
		{
			return new PointF(pt.X + sz.Width, pt.Y + sz.Height);
		}

		/// <summary>Смещает <see cref="T:System.Drawing.PointF" /> на отрицательную величину заданного размера.</summary>
		/// <param name="pt">Класс <see cref="T:System.Drawing.PointF" /> для преобразования.</param>
		/// <param name="sz">Размер <see cref="T:System.Drawing.SizeF" />, указывающий числа для вычитания из координат <paramref name="pt" />.</param>
		/// <returns>Смещенная точка <see cref="T:System.Drawing.PointF" />.</returns>
		// Token: 0x06000262 RID: 610 RVA: 0x000073AC File Offset: 0x000055AC
		public static PointF Subtract(PointF pt, SizeF sz)
		{
			return new PointF(pt.X - sz.Width, pt.Y - sz.Height);
		}

		/// <summary>Определяет, содержит ли объект <see cref="T:System.Drawing.PointF" /> те же координаты, что и указанный объект <see cref="T:System.Object" />.</summary>
		/// <param name="obj">Объект <see cref="T:System.Object" /> для проверки.</param>
		/// <returns>Метод возвращает значение <see langword="true" />, если <paramref name="obj" /> является <see cref="T:System.Drawing.PointF" /> и имеет такие же координаты, как и <see cref="T:System.Drawing.Point" />.</returns>
		// Token: 0x06000263 RID: 611 RVA: 0x000073D1 File Offset: 0x000055D1
		public override bool Equals(object obj)
		{
			return obj is PointF && this.Equals((PointF)obj);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x000073E9 File Offset: 0x000055E9
		public bool Equals(PointF other)
		{
			return this == other;
		}

		/// <summary>Возвращает хэш-код для этой структуры <see cref="T:System.Drawing.PointF" />.</summary>
		/// <returns>Целое значение, указывающее значение хэша для этой структуры <see cref="T:System.Drawing.PointF" />.</returns>
		// Token: 0x06000265 RID: 613 RVA: 0x000073F8 File Offset: 0x000055F8
		public override int GetHashCode()
		{
			return HashHelpers.Combine(this.X.GetHashCode(), this.Y.GetHashCode());
		}

		/// <summary>Преобразует объект <see cref="T:System.Drawing.PointF" /> в строку, доступную для чтения.</summary>
		/// <returns>Строка, представляющая эту структуру <see cref="T:System.Drawing.PointF" />.</returns>
		// Token: 0x06000266 RID: 614 RVA: 0x00007428 File Offset: 0x00005628
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"{X=",
				this.x.ToString(),
				", Y=",
				this.y.ToString(),
				"}"
			});
		}

		/// <summary>Представляет новый экземпляр класса <see cref="T:System.Drawing.PointF" /> с неинициализированными данными членов.</summary>
		// Token: 0x0400038E RID: 910
		public static readonly PointF Empty;

		// Token: 0x0400038F RID: 911
		private float x;

		// Token: 0x04000390 RID: 912
		private float y;
	}
}
