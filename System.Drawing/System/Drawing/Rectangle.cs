using System;
using System.ComponentModel;
using System.Numerics.Hashing;

namespace System.Drawing
{
	/// <summary>Содержит набор из четырех целых чисел, определяющих расположение и размер прямоугольника.</summary>
	// Token: 0x02000049 RID: 73
	[TypeConverter(typeof(RectangleConverter))]
	[Serializable]
	public struct Rectangle : IEquatable<Rectangle>
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Rectangle" /> заданным расположением и размером.</summary>
		/// <param name="x">Координата по оси X верхнего левого угла прямоугольника.</param>
		/// <param name="y">Координата по оси Y верхнего левого угла прямоугольника.</param>
		/// <param name="width">Ширина прямоугольника.</param>
		/// <param name="height">Высота прямоугольника.</param>
		// Token: 0x06000268 RID: 616 RVA: 0x00007474 File Offset: 0x00005674
		public Rectangle(int x, int y, int width, int height)
		{
			this.x = x;
			this.y = y;
			this.width = width;
			this.height = height;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Drawing.Rectangle" /> заданным расположением и размером.</summary>
		/// <param name="location">Объект <see cref="T:System.Drawing.Point" />, представляющий левый верхний угол прямоугольной области.</param>
		/// <param name="size">Объект <see cref="T:System.Drawing.Size" />, представляющий ширину и высоту прямоугольной области.</param>
		// Token: 0x06000269 RID: 617 RVA: 0x00007493 File Offset: 0x00005693
		public Rectangle(Point location, Size size)
		{
			this.x = location.X;
			this.y = location.Y;
			this.width = size.Width;
			this.height = size.Height;
		}

		/// <summary>Создает структуру <see cref="T:System.Drawing.Rectangle" /> с заданным положением краев.</summary>
		/// <param name="left">Координата по оси X верхнего левого угла структуры <see cref="T:System.Drawing.Rectangle" />.</param>
		/// <param name="top">Координата по оси Y верхнего левого угла структуры <see cref="T:System.Drawing.Rectangle" />.</param>
		/// <param name="right">Координата по оси X нижнего правого угла структуры <see cref="T:System.Drawing.Rectangle" />.</param>
		/// <param name="bottom">Координата по оси Y нижнего правого угла структуры <see cref="T:System.Drawing.Rectangle" />.</param>
		/// <returns>Новый объект <see cref="T:System.Drawing.Rectangle" />, созданный данным методом.</returns>
		// Token: 0x0600026A RID: 618 RVA: 0x000074C9 File Offset: 0x000056C9
		public static Rectangle FromLTRB(int left, int top, int right, int bottom)
		{
			return new Rectangle(left, top, right - left, bottom - top);
		}

		/// <summary>Возвращает или задает координаты левого верхнего угла структуры <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Point" />, представляющий левый верхний угол структуры <see cref="T:System.Drawing.Rectangle" />.</returns>
		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600026B RID: 619 RVA: 0x000074D8 File Offset: 0x000056D8
		// (set) Token: 0x0600026C RID: 620 RVA: 0x000074EB File Offset: 0x000056EB
		[Browsable(false)]
		public Point Location
		{
			get
			{
				return new Point(this.X, this.Y);
			}
			set
			{
				this.X = value.X;
				this.Y = value.Y;
			}
		}

		/// <summary>Возвращает или задает размер этого объекта <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <returns>Объект <see cref="T:System.Drawing.Size" />, представляющий ширину и высоту структуры <see cref="T:System.Drawing.Rectangle" />.</returns>
		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00007507 File Offset: 0x00005707
		// (set) Token: 0x0600026E RID: 622 RVA: 0x0000751A File Offset: 0x0000571A
		[Browsable(false)]
		public Size Size
		{
			get
			{
				return new Size(this.Width, this.Height);
			}
			set
			{
				this.Width = value.Width;
				this.Height = value.Height;
			}
		}

		/// <summary>Возвращает или задает координату по оси X левого верхнего угла структуры <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <returns>Координата по оси X верхнего левого угла структуры <see cref="T:System.Drawing.Rectangle" />. Значение по умолчанию — 0.</returns>
		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600026F RID: 623 RVA: 0x00007536 File Offset: 0x00005736
		// (set) Token: 0x06000270 RID: 624 RVA: 0x0000753E File Offset: 0x0000573E
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

		/// <summary>Возвращает или задает координату по оси Y левого верхнего угла структуры <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <returns>Координата по оси Y верхнего левого угла структуры <see cref="T:System.Drawing.Rectangle" />. Значение по умолчанию — 0.</returns>
		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00007547 File Offset: 0x00005747
		// (set) Token: 0x06000272 RID: 626 RVA: 0x0000754F File Offset: 0x0000574F
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

		/// <summary>Возвращает или задает ширину структуры <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <returns>Ширина структуры <see cref="T:System.Drawing.Rectangle" />. Значение по умолчанию — 0.</returns>
		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00007558 File Offset: 0x00005758
		// (set) Token: 0x06000274 RID: 628 RVA: 0x00007560 File Offset: 0x00005760
		public int Width
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

		/// <summary>Возвращает или задает высоту в структуре <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <returns>Высота этой структуры <see cref="T:System.Drawing.Rectangle" />. Значение по умолчанию — 0.</returns>
		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00007569 File Offset: 0x00005769
		// (set) Token: 0x06000276 RID: 630 RVA: 0x00007571 File Offset: 0x00005771
		public int Height
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

		/// <summary>Возвращает координату по оси X левого края структуры <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <returns>Координата по оси X левого края структуры <see cref="T:System.Drawing.Rectangle" />.</returns>
		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0000757A File Offset: 0x0000577A
		[Browsable(false)]
		public int Left
		{
			get
			{
				return this.X;
			}
		}

		/// <summary>Возвращает координату по оси Y верхнего края структуры <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <returns>Координата по оси Y верхнего края структуры <see cref="T:System.Drawing.Rectangle" />.</returns>
		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000278 RID: 632 RVA: 0x00007582 File Offset: 0x00005782
		[Browsable(false)]
		public int Top
		{
			get
			{
				return this.Y;
			}
		}

		/// <summary>Возвращает координату по оси X, являющуюся суммой значений свойств <see cref="P:System.Drawing.Rectangle.X" /> и <see cref="P:System.Drawing.Rectangle.Width" /> данной структуры <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <returns>Координата по оси X, являющаяся суммой значений свойств <see cref="P:System.Drawing.Rectangle.X" /> и <see cref="P:System.Drawing.Rectangle.Width" /> данной структуры <see cref="T:System.Drawing.Rectangle" />.</returns>
		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000279 RID: 633 RVA: 0x0000758A File Offset: 0x0000578A
		[Browsable(false)]
		public int Right
		{
			get
			{
				return this.X + this.Width;
			}
		}

		/// <summary>Возвращает координату по оси Y, являющуюся суммой значений свойств <see cref="P:System.Drawing.Rectangle.Y" /> и <see cref="P:System.Drawing.Rectangle.Height" /> данной структуры <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <returns>Координата по оси Y, являющаяся суммой значений свойств <see cref="P:System.Drawing.Rectangle.Y" /> и <see cref="P:System.Drawing.Rectangle.Height" /> данной структуры <see cref="T:System.Drawing.Rectangle" />.</returns>
		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600027A RID: 634 RVA: 0x00007599 File Offset: 0x00005799
		[Browsable(false)]
		public int Bottom
		{
			get
			{
				return this.Y + this.Height;
			}
		}

		/// <summary>Проверяет, все ли числовые свойства этого прямоугольника <see cref="T:System.Drawing.Rectangle" /> имеют нулевые значения.</summary>
		/// <returns>Данное свойство возвращает значение <see langword="true" />, если значения всех свойств <see cref="P:System.Drawing.Rectangle.Width" />, <see cref="P:System.Drawing.Rectangle.Height" />, <see cref="P:System.Drawing.Rectangle.X" /> и <see cref="P:System.Drawing.Rectangle.Y" /> этого прямоугольника <see cref="T:System.Drawing.Rectangle" /> равны нулю. В противном случае возвращается значение <see langword="false" />.</returns>
		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600027B RID: 635 RVA: 0x000075A8 File Offset: 0x000057A8
		[Browsable(false)]
		public bool IsEmpty
		{
			get
			{
				return this.height == 0 && this.width == 0 && this.x == 0 && this.y == 0;
			}
		}

		/// <summary>Проверяет, является ли <paramref name="obj" /> структурой <see cref="T:System.Drawing.Rectangle" /> с таким же расположением и размером, что и структура <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <param name="obj">Объект <see cref="T:System.Object" /> для проверки.</param>
		/// <returns>Этот метод возвращает значение <see langword="true" />, если параметр <paramref name="obj" /> является структурой <see cref="T:System.Drawing.Rectangle" />, и ее свойства <see cref="P:System.Drawing.Rectangle.X" />, <see cref="P:System.Drawing.Rectangle.Y" />, <see cref="P:System.Drawing.Rectangle.Width" /> и <see cref="P:System.Drawing.Rectangle.Height" /> равны соответствующим свойствам данной структуры <see cref="T:System.Drawing.Rectangle" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600027C RID: 636 RVA: 0x000075CD File Offset: 0x000057CD
		public override bool Equals(object obj)
		{
			return obj is Rectangle && this.Equals((Rectangle)obj);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x000075E5 File Offset: 0x000057E5
		public bool Equals(Rectangle other)
		{
			return this == other;
		}

		/// <summary>Проверяет, имеют ли две структуры <see cref="T:System.Drawing.Rectangle" /> одинаковое положение и размер.</summary>
		/// <param name="left">Структура <see cref="T:System.Drawing.Rectangle" />, которая находится слева от оператора равенства.</param>
		/// <param name="right">Структура <see cref="T:System.Drawing.Rectangle" />, которая находится справа от оператора равенства.</param>
		/// <returns>Этот оператор возвращает значение <see langword="true" />, если у двух структур <see cref="T:System.Drawing.Rectangle" /> равны свойства <see cref="P:System.Drawing.Rectangle.X" />, <see cref="P:System.Drawing.Rectangle.Y" />, <see cref="P:System.Drawing.Rectangle.Width" /> и <see cref="P:System.Drawing.Rectangle.Height" />.</returns>
		// Token: 0x0600027E RID: 638 RVA: 0x000075F4 File Offset: 0x000057F4
		public static bool operator ==(Rectangle left, Rectangle right)
		{
			return left.X == right.X && left.Y == right.Y && left.Width == right.Width && left.Height == right.Height;
		}

		/// <summary>Проверяет, различаются ли две структуры <see cref="T:System.Drawing.Rectangle" /> по положению или размеру.</summary>
		/// <param name="left">Структура <see cref="T:System.Drawing.Rectangle" />, которая находится слева от оператора неравенства.</param>
		/// <param name="right">Структура <see cref="T:System.Drawing.Rectangle" />, которая находится справа от оператора неравенства.</param>
		/// <returns>Этот оператор возвращает значение <see langword="true" />, если значения каких-либо из свойств <see cref="P:System.Drawing.Rectangle.X" />, <see cref="P:System.Drawing.Rectangle.Y" />, <see cref="P:System.Drawing.Rectangle.Width" /> или <see cref="P:System.Drawing.Rectangle.Height" /> двух структур <see cref="T:System.Drawing.Rectangle" /> не совпадают; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600027F RID: 639 RVA: 0x00007643 File Offset: 0x00005843
		public static bool operator !=(Rectangle left, Rectangle right)
		{
			return !(left == right);
		}

		/// <summary>Преобразует указанную структуру <see cref="T:System.Drawing.RectangleF" /> в структуру <see cref="T:System.Drawing.Rectangle" />, округляя значения <see cref="T:System.Drawing.RectangleF" /> до ближайшего большего целого числа.</summary>
		/// <param name="value">Преобразуемая структура <see cref="T:System.Drawing.RectangleF" />.</param>
		/// <returns>Возвращает значение типа <see cref="T:System.Drawing.Rectangle" />.</returns>
		// Token: 0x06000280 RID: 640 RVA: 0x0000764F File Offset: 0x0000584F
		public static Rectangle Ceiling(RectangleF value)
		{
			return new Rectangle((int)Math.Ceiling((double)value.X), (int)Math.Ceiling((double)value.Y), (int)Math.Ceiling((double)value.Width), (int)Math.Ceiling((double)value.Height));
		}

		/// <summary>Преобразует указанный объект <see cref="T:System.Drawing.RectangleF" /> в <see cref="T:System.Drawing.Rectangle" /> путем усечения значений <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <param name="value">Преобразуемая структура <see cref="T:System.Drawing.RectangleF" />.</param>
		/// <returns>Усеченное значение <see cref="T:System.Drawing.Rectangle" />.</returns>
		// Token: 0x06000281 RID: 641 RVA: 0x0000768E File Offset: 0x0000588E
		public static Rectangle Truncate(RectangleF value)
		{
			return new Rectangle((int)value.X, (int)value.Y, (int)value.Width, (int)value.Height);
		}

		/// <summary>Преобразует указанный <see cref="T:System.Drawing.RectangleF" /> в <see cref="T:System.Drawing.Rectangle" />, округляя значения <see cref="T:System.Drawing.RectangleF" /> до ближайших целых чисел.</summary>
		/// <param name="value">Преобразуемая структура <see cref="T:System.Drawing.RectangleF" />.</param>
		/// <returns>Округленное целочисленное значение <see cref="T:System.Drawing.Rectangle" />.</returns>
		// Token: 0x06000282 RID: 642 RVA: 0x000076B5 File Offset: 0x000058B5
		public static Rectangle Round(RectangleF value)
		{
			return new Rectangle((int)Math.Round((double)value.X), (int)Math.Round((double)value.Y), (int)Math.Round((double)value.Width), (int)Math.Round((double)value.Height));
		}

		/// <summary>Определяет, содержится ли заданная точка в структуре <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <param name="x">Координата тестируемой точки по оси X.</param>
		/// <param name="y">Координата тестируемой точки по оси Y.</param>
		/// <returns>Этот метод возвращает значение <see langword="true" />, если точка, определенная параметрами <paramref name="x" /> и <paramref name="y" />, содержится в структуре <see cref="T:System.Drawing.Rectangle" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000283 RID: 643 RVA: 0x000076F4 File Offset: 0x000058F4
		public bool Contains(int x, int y)
		{
			return this.X <= x && x < this.X + this.Width && this.Y <= y && y < this.Y + this.Height;
		}

		/// <summary>Определяет, содержится ли заданная точка в структуре <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <param name="pt">Объект <see cref="T:System.Drawing.Point" /> для проверки.</param>
		/// <returns>Этот метод возвращает значение <see langword="true" />, если точка, представленная <paramref name="pt" />, содержится в структуре <see cref="T:System.Drawing.Rectangle" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000284 RID: 644 RVA: 0x0000772A File Offset: 0x0000592A
		public bool Contains(Point pt)
		{
			return this.Contains(pt.X, pt.Y);
		}

		/// <summary>Определяет, содержится ли вся прямоугольная область, представленная параметром <paramref name="rect" />, в структуре <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <param name="rect">Объект <see cref="T:System.Drawing.Rectangle" /> для проверки.</param>
		/// <returns>Этот метод возвращает значение <see langword="true" />, если прямоугольная область, представленная параметром <paramref name="rect" />, полностью содержится в структуре <see cref="T:System.Drawing.Rectangle" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000285 RID: 645 RVA: 0x00007740 File Offset: 0x00005940
		public bool Contains(Rectangle rect)
		{
			return this.X <= rect.X && rect.X + rect.Width <= this.X + this.Width && this.Y <= rect.Y && rect.Y + rect.Height <= this.Y + this.Height;
		}

		/// <summary>Возвращает хэш-код данной структуры <see cref="T:System.Drawing.Rectangle" />. Дополнительные сведения об использовании хэш-кодов см. в разделе <see cref="M:System.Object.GetHashCode" />.</summary>
		/// <returns>Целое число, представляющее хэш-код для этого прямоугольника.</returns>
		// Token: 0x06000286 RID: 646 RVA: 0x000077AC File Offset: 0x000059AC
		public override int GetHashCode()
		{
			return HashHelpers.Combine(HashHelpers.Combine(HashHelpers.Combine(this.X, this.Y), this.Width), this.Height);
		}

		/// <summary>Увеличивает данный объект <see cref="T:System.Drawing.Rectangle" /> на заданную величину.</summary>
		/// <param name="width">Величина, на которую требуется увеличить данный прямоугольник <see cref="T:System.Drawing.Rectangle" /> в горизонтальном направлении.</param>
		/// <param name="height">Величина, на которую требуется увеличить данный прямоугольник <see cref="T:System.Drawing.Rectangle" /> в вертикальном направлении.</param>
		// Token: 0x06000287 RID: 647 RVA: 0x000077D5 File Offset: 0x000059D5
		public void Inflate(int width, int height)
		{
			this.X -= width;
			this.Y -= height;
			this.Width += 2 * width;
			this.Height += 2 * height;
		}

		/// <summary>Увеличивает данный объект <see cref="T:System.Drawing.Rectangle" /> на заданную величину.</summary>
		/// <param name="size">Величина, на которую требуется увеличить данный прямоугольник.</param>
		// Token: 0x06000288 RID: 648 RVA: 0x00007813 File Offset: 0x00005A13
		public void Inflate(Size size)
		{
			this.Inflate(size.Width, size.Height);
		}

		/// <summary>Создает и возвращает увеличенную копию заданной структуры <see cref="T:System.Drawing.Rectangle" />. Копия увеличивается на заданную величину. Исходная структура <see cref="T:System.Drawing.Rectangle" /> остается без изменений.</summary>
		/// <param name="rect">Объект <see cref="T:System.Drawing.Rectangle" />, являющийся исходным. Этот прямоугольник не изменяется.</param>
		/// <param name="x">Величина, на которую требуется увеличить данный прямоугольник <see cref="T:System.Drawing.Rectangle" /> в горизонтальном направлении.</param>
		/// <param name="y">Величина, на которую требуется увеличить данный прямоугольник <see cref="T:System.Drawing.Rectangle" /> в вертикальном направлении.</param>
		/// <returns>Увеличенный объект <see cref="T:System.Drawing.Rectangle" />.</returns>
		// Token: 0x06000289 RID: 649 RVA: 0x0000782C File Offset: 0x00005A2C
		public static Rectangle Inflate(Rectangle rect, int x, int y)
		{
			Rectangle result = rect;
			result.Inflate(x, y);
			return result;
		}

		/// <summary>Заменяет данный объект <see cref="T:System.Drawing.Rectangle" /> его пересечением с указанным прямоугольником <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <param name="rect">Объект <see cref="T:System.Drawing.Rectangle" />, с которым происходит пересечение.</param>
		// Token: 0x0600028A RID: 650 RVA: 0x00007848 File Offset: 0x00005A48
		public void Intersect(Rectangle rect)
		{
			Rectangle rectangle = Rectangle.Intersect(rect, this);
			this.X = rectangle.X;
			this.Y = rectangle.Y;
			this.Width = rectangle.Width;
			this.Height = rectangle.Height;
		}

		/// <summary>Возвращает третью структуру <see cref="T:System.Drawing.Rectangle" />, представляющую собой пересечение двух других структур <see cref="T:System.Drawing.Rectangle" />. Если пересечение отсутствует, возвращается пустая структура <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <param name="a">Прямоугольник для пересечения.</param>
		/// <param name="b">Прямоугольник для пересечения.</param>
		/// <returns>Объект <see cref="T:System.Drawing.Rectangle" />, представляющий собой пересечение параметров <paramref name="a" /> и <paramref name="b" />.</returns>
		// Token: 0x0600028B RID: 651 RVA: 0x00007898 File Offset: 0x00005A98
		public static Rectangle Intersect(Rectangle a, Rectangle b)
		{
			int num = Math.Max(a.X, b.X);
			int num2 = Math.Min(a.X + a.Width, b.X + b.Width);
			int num3 = Math.Max(a.Y, b.Y);
			int num4 = Math.Min(a.Y + a.Height, b.Y + b.Height);
			if (num2 >= num && num4 >= num3)
			{
				return new Rectangle(num, num3, num2 - num, num4 - num3);
			}
			return Rectangle.Empty;
		}

		/// <summary>Определяет, пересекается ли данный прямоугольник с прямоугольником <paramref name="rect" />.</summary>
		/// <param name="rect">Прямоугольник для проверки.</param>
		/// <returns>При наличии пересечения этот метод возвращает значение <see langword="true" />, в противном случае возвращается значение <see langword="false" />.</returns>
		// Token: 0x0600028C RID: 652 RVA: 0x00007930 File Offset: 0x00005B30
		public bool IntersectsWith(Rectangle rect)
		{
			return rect.X < this.X + this.Width && this.X < rect.X + rect.Width && rect.Y < this.Y + this.Height && this.Y < rect.Y + rect.Height;
		}

		/// <summary>Возвращает структуру <see cref="T:System.Drawing.Rectangle" />, содержащую объединение двух структур <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <param name="a">Прямоугольник, предназначенный для объединения.</param>
		/// <param name="b">Прямоугольник, предназначенный для объединения.</param>
		/// <returns>Структура <see cref="T:System.Drawing.Rectangle" />, заключающая в себе объединение двух структур <see cref="T:System.Drawing.Rectangle" />.</returns>
		// Token: 0x0600028D RID: 653 RVA: 0x0000799C File Offset: 0x00005B9C
		public static Rectangle Union(Rectangle a, Rectangle b)
		{
			int num = Math.Min(a.X, b.X);
			int num2 = Math.Max(a.X + a.Width, b.X + b.Width);
			int num3 = Math.Min(a.Y, b.Y);
			int num4 = Math.Max(a.Y + a.Height, b.Y + b.Height);
			return new Rectangle(num, num3, num2 - num, num4 - num3);
		}

		/// <summary>Изменяет положение этого прямоугольника на указанную величину.</summary>
		/// <param name="pos">Величина, на которую смещается положение.</param>
		// Token: 0x0600028E RID: 654 RVA: 0x00007A26 File Offset: 0x00005C26
		public void Offset(Point pos)
		{
			this.Offset(pos.X, pos.Y);
		}

		/// <summary>Изменяет положение этого прямоугольника на указанную величину.</summary>
		/// <param name="x">Горизонтальное смещение.</param>
		/// <param name="y">Вертикальное смещение.</param>
		// Token: 0x0600028F RID: 655 RVA: 0x00007A3C File Offset: 0x00005C3C
		public void Offset(int x, int y)
		{
			this.X += x;
			this.Y += y;
		}

		/// <summary>Преобразует атрибуты этого прямоугольника <see cref="T:System.Drawing.Rectangle" /> в удобную для восприятия строку.</summary>
		/// <returns>Строка, содержащая положение, ширину и высоту структуры <see cref="T:System.Drawing.Rectangle" />, например: {X=20, Y=20, Width=100, Height=50}.</returns>
		// Token: 0x06000290 RID: 656 RVA: 0x00007A5C File Offset: 0x00005C5C
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

		/// <summary>Представляет структуру <see cref="T:System.Drawing.Rectangle" />, свойства которой не инициализированы.</summary>
		// Token: 0x04000391 RID: 913
		public static readonly Rectangle Empty;

		// Token: 0x04000392 RID: 914
		private int x;

		// Token: 0x04000393 RID: 915
		private int y;

		// Token: 0x04000394 RID: 916
		private int width;

		// Token: 0x04000395 RID: 917
		private int height;
	}
}
