using System;
using System.ComponentModel;
using System.Numerics.Hashing;

namespace System.Drawing
{
	/// <summary>Содержит набор из четырех чисел с плавающей запятой, определяющих расположение и размер прямоугольника. Для расширения функций области используйте объект <see cref="T:System.Drawing.Region" />.</summary>
	// Token: 0x0200004A RID: 74
	[Serializable]
	public struct RectangleF : IEquatable<RectangleF>
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.RectangleF" /> заданным расположением и размером.</summary>
		/// <param name="x">Координата по оси X верхнего левого угла прямоугольника.</param>
		/// <param name="y">Координата по оси Y верхнего левого угла прямоугольника.</param>
		/// <param name="width">Ширина прямоугольника.</param>
		/// <param name="height">Высота прямоугольника.</param>
		// Token: 0x06000292 RID: 658 RVA: 0x00007AE1 File Offset: 0x00005CE1
		public RectangleF(float x, float y, float width, float height)
		{
			this.x = x;
			this.y = y;
			this.width = width;
			this.height = height;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.RectangleF" /> заданным расположением и размером.</summary>
		/// <param name="location">Объект <see cref="T:System.Drawing.PointF" />, представляющий левый верхний угол прямоугольной области.</param>
		/// <param name="size">Объект <see cref="T:System.Drawing.SizeF" />, представляющий ширину и высоту прямоугольной области.</param>
		// Token: 0x06000293 RID: 659 RVA: 0x00007B00 File Offset: 0x00005D00
		public RectangleF(PointF location, SizeF size)
		{
			this.x = location.X;
			this.y = location.Y;
			this.width = size.Width;
			this.height = size.Height;
		}

		/// <summary>Создает структуру <see cref="T:System.Drawing.RectangleF" /> с заданным расположением левого верхнего и правого нижнего углов.</summary>
		/// <param name="left">Координата по оси X верхнего левого угла прямоугольной области.</param>
		/// <param name="top">Координата по оси Y верхнего левого угла прямоугольной области.</param>
		/// <param name="right">Координата по оси X нижнего правого угла прямоугольной области.</param>
		/// <param name="bottom">Координата по оси Y нижнего правого угла прямоугольной области.</param>
		/// <returns>Новый объект <see cref="T:System.Drawing.RectangleF" />, созданный данным методом.</returns>
		// Token: 0x06000294 RID: 660 RVA: 0x00007B36 File Offset: 0x00005D36
		public static RectangleF FromLTRB(float left, float top, float right, float bottom)
		{
			return new RectangleF(left, top, right - left, bottom - top);
		}

		/// <summary>Возвращает или задает координаты левого верхнего угла структуры <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.PointF" />, представляющий левый верхний угол структуры <see cref="T:System.Drawing.RectangleF" />.</returns>
		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000295 RID: 661 RVA: 0x00007B45 File Offset: 0x00005D45
		// (set) Token: 0x06000296 RID: 662 RVA: 0x00007B58 File Offset: 0x00005D58
		[Browsable(false)]
		public PointF Location
		{
			get
			{
				return new PointF(this.X, this.Y);
			}
			set
			{
				this.X = value.X;
				this.Y = value.Y;
			}
		}

		/// <summary>Возвращает или задает размер этого объекта <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.SizeF" />, представляющий ширину и высоту структуры <see cref="T:System.Drawing.RectangleF" />.</returns>
		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000297 RID: 663 RVA: 0x00007B74 File Offset: 0x00005D74
		// (set) Token: 0x06000298 RID: 664 RVA: 0x00007B87 File Offset: 0x00005D87
		[Browsable(false)]
		public SizeF Size
		{
			get
			{
				return new SizeF(this.Width, this.Height);
			}
			set
			{
				this.Width = value.Width;
				this.Height = value.Height;
			}
		}

		/// <summary>Возвращает или задает координату по оси X левого верхнего угла структуры <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <returns>Координата по оси X верхнего левого угла структуры <see cref="T:System.Drawing.RectangleF" />. Значение по умолчанию — 0.</returns>
		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000299 RID: 665 RVA: 0x00007BA3 File Offset: 0x00005DA3
		// (set) Token: 0x0600029A RID: 666 RVA: 0x00007BAB File Offset: 0x00005DAB
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

		/// <summary>Возвращает или задает координату по оси Y левого верхнего угла структуры <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <returns>Координата по оси Y верхнего левого угла структуры <see cref="T:System.Drawing.RectangleF" />. Значение по умолчанию — 0.</returns>
		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600029B RID: 667 RVA: 0x00007BB4 File Offset: 0x00005DB4
		// (set) Token: 0x0600029C RID: 668 RVA: 0x00007BBC File Offset: 0x00005DBC
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

		/// <summary>Возвращает или задает ширину структуры <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <returns>Ширина структуры <see cref="T:System.Drawing.RectangleF" />. Значение по умолчанию — 0.</returns>
		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00007BC5 File Offset: 0x00005DC5
		// (set) Token: 0x0600029E RID: 670 RVA: 0x00007BCD File Offset: 0x00005DCD
		public float Width
		{
			get
			{
				return this.width;
			}
			set
			{
				this.width = value;
			}
		}

		/// <summary>Возвращает или задает высоту в структуре <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <returns>Высота этой структуры <see cref="T:System.Drawing.RectangleF" />. Значение по умолчанию — 0.</returns>
		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600029F RID: 671 RVA: 0x00007BD6 File Offset: 0x00005DD6
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x00007BDE File Offset: 0x00005DDE
		public float Height
		{
			get
			{
				return this.height;
			}
			set
			{
				this.height = value;
			}
		}

		/// <summary>Возвращает координату по оси X левого края структуры <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <returns>Координата по оси X левого края структуры <see cref="T:System.Drawing.RectangleF" />.</returns>
		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x00007BE7 File Offset: 0x00005DE7
		[Browsable(false)]
		public float Left
		{
			get
			{
				return this.X;
			}
		}

		/// <summary>Возвращает координату по оси Y верхнего края структуры <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <returns>Координата по оси Y верхнего края структуры <see cref="T:System.Drawing.RectangleF" />.</returns>
		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x00007BEF File Offset: 0x00005DEF
		[Browsable(false)]
		public float Top
		{
			get
			{
				return this.Y;
			}
		}

		/// <summary>Возвращает координату по оси X, являющуюся суммой значений свойств <see cref="P:System.Drawing.RectangleF.X" /> и <see cref="P:System.Drawing.RectangleF.Width" /> структуры <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <returns>Координата по оси X, являющаяся суммой значений свойств <see cref="P:System.Drawing.RectangleF.X" /> и <see cref="P:System.Drawing.RectangleF.Width" /> структуры <see cref="T:System.Drawing.RectangleF" />.</returns>
		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x00007BF7 File Offset: 0x00005DF7
		[Browsable(false)]
		public float Right
		{
			get
			{
				return this.X + this.Width;
			}
		}

		/// <summary>Возвращает координату по оси Y, являющуюся суммой значений свойств <see cref="P:System.Drawing.RectangleF.Y" /> и <see cref="P:System.Drawing.RectangleF.Height" /> структуры <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <returns>Координата по оси Y, являющаяся суммой значений свойств <see cref="P:System.Drawing.RectangleF.Y" /> и <see cref="P:System.Drawing.RectangleF.Height" /> структуры <see cref="T:System.Drawing.RectangleF" />.</returns>
		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x00007C06 File Offset: 0x00005E06
		[Browsable(false)]
		public float Bottom
		{
			get
			{
				return this.Y + this.Height;
			}
		}

		/// <summary>Возвращает значение, указывающее, равно ли нулю значение свойства <see cref="P:System.Drawing.RectangleF.Width" /> или <see cref="P:System.Drawing.RectangleF.Height" /> этого объекта <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <returns>
		///   <see langword="true" /> Если <see cref="P:System.Drawing.RectangleF.Width" /> или <see cref="P:System.Drawing.RectangleF.Height" /> свойства данного объекта <see cref="T:System.Drawing.RectangleF" /> имеет нулевое значение; в противном случае <see langword="false" />.</returns>
		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00007C15 File Offset: 0x00005E15
		[Browsable(false)]
		public bool IsEmpty
		{
			get
			{
				return this.Width <= 0f || this.Height <= 0f;
			}
		}

		/// <summary>Проверяет, является ли <paramref name="obj" /> прямоугольником <see cref="T:System.Drawing.RectangleF" /> с таким же расположением и размером, что и <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <param name="obj">Объект <see cref="T:System.Object" /> для проверки.</param>
		/// <returns>Значение <see langword="true" />, если параметром <paramref name="obj" /> является <see cref="T:System.Drawing.RectangleF" />, и его свойства <see langword="X" />, <see langword="Y" />, <see langword="Width" /> и <see langword="Height" /> равны соответствующим свойствам объекта <see cref="T:System.Drawing.RectangleF" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060002A6 RID: 678 RVA: 0x00007C36 File Offset: 0x00005E36
		public override bool Equals(object obj)
		{
			return obj is RectangleF && this.Equals((RectangleF)obj);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00007C4E File Offset: 0x00005E4E
		public bool Equals(RectangleF other)
		{
			return this == other;
		}

		/// <summary>Проверяет, имеют ли две структуры <see cref="T:System.Drawing.RectangleF" /> одинаковое положение и размер.</summary>
		/// <param name="left">Структура <see cref="T:System.Drawing.RectangleF" />, которая находится слева от оператора равенства.</param>
		/// <param name="right">Структура <see cref="T:System.Drawing.RectangleF" />, которая находится справа от оператора равенства.</param>
		/// <returns>Значение <see langword="true" />, если у двух заданных структур <see cref="T:System.Drawing.RectangleF" /> равны свойства <see cref="P:System.Drawing.RectangleF.X" />, <see cref="P:System.Drawing.RectangleF.Y" />, <see cref="P:System.Drawing.RectangleF.Width" /> и <see cref="P:System.Drawing.RectangleF.Height" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060002A8 RID: 680 RVA: 0x00007C5C File Offset: 0x00005E5C
		public static bool operator ==(RectangleF left, RectangleF right)
		{
			return left.X == right.X && left.Y == right.Y && left.Width == right.Width && left.Height == right.Height;
		}

		/// <summary>Проверяет, различаются ли две структуры <see cref="T:System.Drawing.RectangleF" /> по положению или размеру.</summary>
		/// <param name="left">Структура <see cref="T:System.Drawing.RectangleF" />, которая находится слева от оператора неравенства.</param>
		/// <param name="right">Структура <see cref="T:System.Drawing.RectangleF" />, которая находится справа от оператора неравенства.</param>
		/// <returns>Значение <see langword="true" />, если значения каких-либо из свойств <see cref="P:System.Drawing.RectangleF.X" />, <see cref="P:System.Drawing.RectangleF.Y" />, <see cref="P:System.Drawing.RectangleF.Width" /> или <see cref="P:System.Drawing.RectangleF.Height" /> двух структур <see cref="T:System.Drawing.Rectangle" /> не совпадают; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060002A9 RID: 681 RVA: 0x00007CAB File Offset: 0x00005EAB
		public static bool operator !=(RectangleF left, RectangleF right)
		{
			return !(left == right);
		}

		/// <summary>Определяет, содержится ли заданная точка в структуре <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <param name="x">Координата тестируемой точки по оси X.</param>
		/// <param name="y">Координата тестируемой точки по оси Y.</param>
		/// <returns>Значение <see langword="true" />, если точка, определенная параметрами <paramref name="x" /> и <paramref name="y" />, содержится в структуре <see cref="T:System.Drawing.RectangleF" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060002AA RID: 682 RVA: 0x00007CB7 File Offset: 0x00005EB7
		public bool Contains(float x, float y)
		{
			return this.X <= x && x < this.X + this.Width && this.Y <= y && y < this.Y + this.Height;
		}

		/// <summary>Определяет, содержится ли заданная точка в структуре <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <param name="pt">Объект <see cref="T:System.Drawing.PointF" /> для проверки.</param>
		/// <returns>Значение <see langword="true" />, если точка, представленная параметром <paramref name="pt" />, содержится в структуре <see cref="T:System.Drawing.RectangleF" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060002AB RID: 683 RVA: 0x00007CED File Offset: 0x00005EED
		public bool Contains(PointF pt)
		{
			return this.Contains(pt.X, pt.Y);
		}

		/// <summary>Определяет, содержится ли вся прямоугольная область, представленная параметром <paramref name="rect" />, в структуре <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <param name="rect">Объект <see cref="T:System.Drawing.RectangleF" /> для проверки.</param>
		/// <returns>Значение <see langword="true" />, если прямоугольная область, представленная параметром <paramref name="rect" />, полностью содержится в прямоугольной области, представленной структурой <see cref="T:System.Drawing.RectangleF" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060002AC RID: 684 RVA: 0x00007D04 File Offset: 0x00005F04
		public bool Contains(RectangleF rect)
		{
			return this.X <= rect.X && rect.X + rect.Width <= this.X + this.Width && this.Y <= rect.Y && rect.Y + rect.Height <= this.Y + this.Height;
		}

		/// <summary>Возвращает хэш-код для этой структуры <see cref="T:System.Drawing.RectangleF" />. Дополнительные сведения об использовании хэш-кодов см. в разделе <see langword="Object.GetHashCode" />.</summary>
		/// <returns>Хэш-код для этого экземпляра <see cref="T:System.Drawing.RectangleF" />.</returns>
		// Token: 0x060002AD RID: 685 RVA: 0x00007D70 File Offset: 0x00005F70
		public override int GetHashCode()
		{
			return HashHelpers.Combine(HashHelpers.Combine(HashHelpers.Combine(this.X.GetHashCode(), this.Y.GetHashCode()), this.Width.GetHashCode()), this.Height.GetHashCode());
		}

		/// <summary>Увеличивает структуру данного прямоугольника <see cref="T:System.Drawing.RectangleF" /> на заданную величину.</summary>
		/// <param name="x">Величина, на которую увеличится структура <see cref="T:System.Drawing.RectangleF" /> в горизонтальном направлении.</param>
		/// <param name="y">Величина, на которую увеличится структура <see cref="T:System.Drawing.RectangleF" /> в вертикальном направлении.</param>
		// Token: 0x060002AE RID: 686 RVA: 0x00007DC4 File Offset: 0x00005FC4
		public void Inflate(float x, float y)
		{
			this.X -= x;
			this.Y -= y;
			this.Width += 2f * x;
			this.Height += 2f * y;
		}

		/// <summary>Увеличивает данный объект <see cref="T:System.Drawing.RectangleF" /> на заданную величину.</summary>
		/// <param name="size">Величина, на которую требуется увеличить данный прямоугольник.</param>
		// Token: 0x060002AF RID: 687 RVA: 0x00007E15 File Offset: 0x00006015
		public void Inflate(SizeF size)
		{
			this.Inflate(size.Width, size.Height);
		}

		/// <summary>Создает и возвращает увеличенную копию заданной структуры <see cref="T:System.Drawing.RectangleF" />. Копия увеличивается на заданную величину, а исходный прямоугольник не изменяется.</summary>
		/// <param name="rect">Копируемый объект <see cref="T:System.Drawing.RectangleF" />. Этот прямоугольник не изменяется.</param>
		/// <param name="x">Величина, на которую необходимо увеличить копию прямоугольника в горизонтальном направлении.</param>
		/// <param name="y">Величина, на которую необходимо увеличить копию прямоугольника в вертикальном направлении.</param>
		/// <returns>Увеличенный объект <see cref="T:System.Drawing.RectangleF" />.</returns>
		// Token: 0x060002B0 RID: 688 RVA: 0x00007E2C File Offset: 0x0000602C
		public static RectangleF Inflate(RectangleF rect, float x, float y)
		{
			RectangleF result = rect;
			result.Inflate(x, y);
			return result;
		}

		/// <summary>Заменяет данную структуру <see cref="T:System.Drawing.RectangleF" /> пересечением самого себя и заданной структуры <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <param name="rect">Пересекаемый прямоугольник.</param>
		// Token: 0x060002B1 RID: 689 RVA: 0x00007E48 File Offset: 0x00006048
		public void Intersect(RectangleF rect)
		{
			RectangleF rectangleF = RectangleF.Intersect(rect, this);
			this.X = rectangleF.X;
			this.Y = rectangleF.Y;
			this.Width = rectangleF.Width;
			this.Height = rectangleF.Height;
		}

		/// <summary>Возвращает структуру <see cref="T:System.Drawing.RectangleF" />, представляющую пересечение двух прямоугольников. Если пересечение отсутствует, возвращается пустая структура <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <param name="a">Прямоугольник для пересечения.</param>
		/// <param name="b">Прямоугольник для пересечения.</param>
		/// <returns>Третья структура <see cref="T:System.Drawing.RectangleF" />, размер которой представляет область наложения двух указанных прямоугольников.</returns>
		// Token: 0x060002B2 RID: 690 RVA: 0x00007E98 File Offset: 0x00006098
		public static RectangleF Intersect(RectangleF a, RectangleF b)
		{
			float num = Math.Max(a.X, b.X);
			float num2 = Math.Min(a.X + a.Width, b.X + b.Width);
			float num3 = Math.Max(a.Y, b.Y);
			float num4 = Math.Min(a.Y + a.Height, b.Y + b.Height);
			if (num2 >= num && num4 >= num3)
			{
				return new RectangleF(num, num3, num2 - num, num4 - num3);
			}
			return RectangleF.Empty;
		}

		/// <summary>Определяет, пересекается ли данный прямоугольник с прямоугольником <paramref name="rect" />.</summary>
		/// <param name="rect">Прямоугольник для проверки.</param>
		/// <returns>Значение <see langword="true" />, если пересечение есть; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060002B3 RID: 691 RVA: 0x00007F30 File Offset: 0x00006130
		public bool IntersectsWith(RectangleF rect)
		{
			return rect.X < this.X + this.Width && this.X < rect.X + rect.Width && rect.Y < this.Y + this.Height && this.Y < rect.Y + rect.Height;
		}

		/// <summary>Создает третий прямоугольник минимального размера, позволяющего ему вместить оба прямоугольника, образующих объединение.</summary>
		/// <param name="a">Прямоугольник, предназначенный для объединения.</param>
		/// <param name="b">Прямоугольник, предназначенный для объединения.</param>
		/// <returns>Третья структура <see cref="T:System.Drawing.RectangleF" />, содержащая оба прямоугольника, образующих объединение.</returns>
		// Token: 0x060002B4 RID: 692 RVA: 0x00007F9C File Offset: 0x0000619C
		public static RectangleF Union(RectangleF a, RectangleF b)
		{
			float num = Math.Min(a.X, b.X);
			float num2 = Math.Max(a.X + a.Width, b.X + b.Width);
			float num3 = Math.Min(a.Y, b.Y);
			float num4 = Math.Max(a.Y + a.Height, b.Y + b.Height);
			return new RectangleF(num, num3, num2 - num, num4 - num3);
		}

		/// <summary>Изменяет положение этого прямоугольника на указанную величину.</summary>
		/// <param name="pos">Величина, на которую смещается положение.</param>
		// Token: 0x060002B5 RID: 693 RVA: 0x00008026 File Offset: 0x00006226
		public void Offset(PointF pos)
		{
			this.Offset(pos.X, pos.Y);
		}

		/// <summary>Изменяет положение этого прямоугольника на указанную величину.</summary>
		/// <param name="x">Величина, на которую смещается положение по горизонтали.</param>
		/// <param name="y">Величина, на которую смещается положение по вертикали.</param>
		// Token: 0x060002B6 RID: 694 RVA: 0x0000803C File Offset: 0x0000623C
		public void Offset(float x, float y)
		{
			this.X += x;
			this.Y += y;
		}

		/// <summary>Преобразует указанную структуру <see cref="T:System.Drawing.Rectangle" /> в структуру <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <param name="r">Преобразуемая структура <see cref="T:System.Drawing.Rectangle" />.</param>
		/// <returns>Структура <see cref="T:System.Drawing.RectangleF" />, преобразованная из заданной структуры <see cref="T:System.Drawing.Rectangle" />.</returns>
		// Token: 0x060002B7 RID: 695 RVA: 0x0000805A File Offset: 0x0000625A
		public static implicit operator RectangleF(Rectangle r)
		{
			return new RectangleF((float)r.X, (float)r.Y, (float)r.Width, (float)r.Height);
		}

		/// <summary>Преобразует <see langword="Location" /> и <see cref="T:System.Drawing.Size" /> этого прямоугольника <see cref="T:System.Drawing.RectangleF" /> в удобную для восприятия строку.</summary>
		/// <returns>Строка, содержащая позицию, ширину и высоту этой структуры <see cref="T:System.Drawing.RectangleF" />. Например, "{X=20, Y=20, Width=100, Height=50}".</returns>
		// Token: 0x060002B8 RID: 696 RVA: 0x00008084 File Offset: 0x00006284
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"{X=",
				this.X.ToString(),
				",Y=",
				this.Y.ToString(),
				",Width=",
				this.Width.ToString(),
				",Height=",
				this.Height.ToString(),
				"}"
			});
		}

		/// <summary>Представляет экземпляр класса <see cref="T:System.Drawing.RectangleF" /> с неинициализированными членами.</summary>
		// Token: 0x04000396 RID: 918
		public static readonly RectangleF Empty;

		// Token: 0x04000397 RID: 919
		private float x;

		// Token: 0x04000398 RID: 920
		private float y;

		// Token: 0x04000399 RID: 921
		private float width;

		// Token: 0x0400039A RID: 922
		private float height;
	}
}
