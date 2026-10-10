using System;
using System.ComponentModel;
using System.Numerics.Hashing;

namespace System.Drawing
{
	/// <summary>Содержит упорядоченную пару чисел с плавающей запятой, обычно ширину и высоту прямоугольника.</summary>
	// Token: 0x0200004C RID: 76
	[TypeConverter(typeof(SizeFConverter))]
	[Serializable]
	public struct SizeF : IEquatable<SizeF>
	{
		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Drawing.SizeF" /> из указанной существующей структуры <see cref="T:System.Drawing.SizeF" />.</summary>
		/// <param name="size">Структура <see cref="T:System.Drawing.SizeF" />, из которой будет создана новая структура <see cref="T:System.Drawing.SizeF" />.</param>
		// Token: 0x060002D9 RID: 729 RVA: 0x0000838C File Offset: 0x0000658C
		public SizeF(SizeF size)
		{
			this.width = size.width;
			this.height = size.height;
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Drawing.SizeF" /> из указанной структуры <see cref="T:System.Drawing.PointF" />.</summary>
		/// <param name="pt">Структура <see cref="T:System.Drawing.PointF" />, из которой инициализируется эта структура <see cref="T:System.Drawing.SizeF" />.</param>
		// Token: 0x060002DA RID: 730 RVA: 0x000083A6 File Offset: 0x000065A6
		public SizeF(PointF pt)
		{
			this.width = pt.X;
			this.height = pt.Y;
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Drawing.SizeF" /> из указанных измерений.</summary>
		/// <param name="width">Компонент ширины новой структуры <see cref="T:System.Drawing.SizeF" />.</param>
		/// <param name="height">Компонент высоты новой структуры <see cref="T:System.Drawing.SizeF" />.</param>
		// Token: 0x060002DB RID: 731 RVA: 0x000083C2 File Offset: 0x000065C2
		public SizeF(float width, float height)
		{
			this.width = width;
			this.height = height;
		}

		/// <summary>Прибавляет ширину и высоту одной структуры <see cref="T:System.Drawing.SizeF" /> к ширине и высоте другой структуры <see cref="T:System.Drawing.SizeF" />.</summary>
		/// <param name="sz1">Первая структура <see cref="T:System.Drawing.SizeF" /> для сложения.</param>
		/// <param name="sz2">Вторая структура <see cref="T:System.Drawing.SizeF" /> для сложения.</param>
		/// <returns>Структура <see cref="T:System.Drawing.Size" />, получаемая в результате операции сложения.</returns>
		// Token: 0x060002DC RID: 732 RVA: 0x000083D2 File Offset: 0x000065D2
		public static SizeF operator +(SizeF sz1, SizeF sz2)
		{
			return SizeF.Add(sz1, sz2);
		}

		/// <summary>Вычитает ширину и высоту одной структуры <see cref="T:System.Drawing.SizeF" /> из ширины и высоты другой структуры <see cref="T:System.Drawing.SizeF" />.</summary>
		/// <param name="sz1">Структура <see cref="T:System.Drawing.SizeF" />, которая находится слева от оператора вычитания.</param>
		/// <param name="sz2">Структура <see cref="T:System.Drawing.SizeF" />, которая находится справа от оператора вычитания.</param>
		/// <returns>Структура <see cref="T:System.Drawing.SizeF" />, полученная в результате операции вычитания.</returns>
		// Token: 0x060002DD RID: 733 RVA: 0x000083DB File Offset: 0x000065DB
		public static SizeF operator -(SizeF sz1, SizeF sz2)
		{
			return SizeF.Subtract(sz1, sz2);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x000083E4 File Offset: 0x000065E4
		public static SizeF operator *(float left, SizeF right)
		{
			return SizeF.Multiply(right, left);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x000083ED File Offset: 0x000065ED
		public static SizeF operator *(SizeF left, float right)
		{
			return SizeF.Multiply(left, right);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x000083F6 File Offset: 0x000065F6
		public static SizeF operator /(SizeF left, float right)
		{
			return new SizeF(left.width / right, left.height / right);
		}

		/// <summary>Проверяет равенство двух структур <see cref="T:System.Drawing.SizeF" /> .</summary>
		/// <param name="sz1">Структура <see cref="T:System.Drawing.SizeF" />, которая находится слева от оператора равенства.</param>
		/// <param name="sz2">Структура <see cref="T:System.Drawing.SizeF" />, которая находится справа от оператора равенства.</param>
		/// <returns>Значение <see langword="true" />, если у <paramref name="sz1" /> и <paramref name="sz2" /> равны значения ширины и высоты, в противном случае значение <see langword="false" />.</returns>
		// Token: 0x060002E1 RID: 737 RVA: 0x0000840D File Offset: 0x0000660D
		public static bool operator ==(SizeF sz1, SizeF sz2)
		{
			return sz1.Width == sz2.Width && sz1.Height == sz2.Height;
		}

		/// <summary>Определяет равенство двух структур <see cref="T:System.Drawing.SizeF" />.</summary>
		/// <param name="sz1">Структура <see cref="T:System.Drawing.SizeF" />, которая находится слева от оператора неравенства.</param>
		/// <param name="sz2">Структура <see cref="T:System.Drawing.SizeF" />, которая находится справа от оператора неравенства.</param>
		/// <returns>Значение <see langword="true" />, если параметры <paramref name="sz1" /> и <paramref name="sz2" /> отличаются по ширине или высоте, и значение <see langword="false" />, если параметры <paramref name="sz1" /> и <paramref name="sz2" /> равны.</returns>
		// Token: 0x060002E2 RID: 738 RVA: 0x00008431 File Offset: 0x00006631
		public static bool operator !=(SizeF sz1, SizeF sz2)
		{
			return !(sz1 == sz2);
		}

		/// <summary>Преобразует указанную структуру <see cref="T:System.Drawing.SizeF" /> в структуру <see cref="T:System.Drawing.PointF" />.</summary>
		/// <param name="size">Преобразуемая структура <see cref="T:System.Drawing.SizeF" />.</param>
		/// <returns>Структура <see cref="T:System.Drawing.PointF" />, которая является результатом преобразования, выполненного с помощью этого оператора.</returns>
		// Token: 0x060002E3 RID: 739 RVA: 0x0000843D File Offset: 0x0000663D
		public static explicit operator PointF(SizeF size)
		{
			return new PointF(size.Width, size.Height);
		}

		/// <summary>Возвращает значение, указывающее, имеет ли эта структура <see cref="T:System.Drawing.SizeF" /> нулевую ширину и высоту.</summary>
		/// <returns>
		///   <see langword="true" /> При этом <see cref="T:System.Drawing.SizeF" /> структура имеет ширину и высоту элемента равно нулю; в противном случае <see langword="false" />.</returns>
		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x00008452 File Offset: 0x00006652
		[Browsable(false)]
		public bool IsEmpty
		{
			get
			{
				return this.width == 0f && this.height == 0f;
			}
		}

		/// <summary>Получает или задает горизонтальный компонент этой структуры <see cref="T:System.Drawing.SizeF" />.</summary>
		/// <returns>Горизонтальный компонент этой структуры <see cref="T:System.Drawing.SizeF" />, обычно измеряемый в пикселях.</returns>
		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00008470 File Offset: 0x00006670
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x00008478 File Offset: 0x00006678
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

		/// <summary>Возвращает или задает вертикальный компонент этой структуры <see cref="T:System.Drawing.SizeF" />.</summary>
		/// <returns>Вертикальный компонент этой структуры <see cref="T:System.Drawing.SizeF" />, обычно измеряемый в пикселях.</returns>
		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x00008481 File Offset: 0x00006681
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x00008489 File Offset: 0x00006689
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

		/// <summary>Прибавляет ширину и высоту одной структуры <see cref="T:System.Drawing.SizeF" /> к ширине и высоте другой структуры <see cref="T:System.Drawing.SizeF" />.</summary>
		/// <param name="sz1">Первая структура <see cref="T:System.Drawing.SizeF" /> для сложения.</param>
		/// <param name="sz2">Вторая структура <see cref="T:System.Drawing.SizeF" /> для сложения.</param>
		/// <returns>Структура <see cref="T:System.Drawing.SizeF" />, получаемая в результате операции сложения.</returns>
		// Token: 0x060002E9 RID: 745 RVA: 0x00008492 File Offset: 0x00006692
		public static SizeF Add(SizeF sz1, SizeF sz2)
		{
			return new SizeF(sz1.Width + sz2.Width, sz1.Height + sz2.Height);
		}

		/// <summary>Вычитает ширину и высоту одной структуры <see cref="T:System.Drawing.SizeF" /> из ширины и высоты другой структуры <see cref="T:System.Drawing.SizeF" />.</summary>
		/// <param name="sz1">Структура <see cref="T:System.Drawing.SizeF" />, которая находится слева от оператора вычитания.</param>
		/// <param name="sz2">Структура <see cref="T:System.Drawing.SizeF" />, которая находится справа от оператора вычитания.</param>
		/// <returns>Структура <see cref="T:System.Drawing.SizeF" />, полученная в результате операции вычитания.</returns>
		// Token: 0x060002EA RID: 746 RVA: 0x000084B7 File Offset: 0x000066B7
		public static SizeF Subtract(SizeF sz1, SizeF sz2)
		{
			return new SizeF(sz1.Width - sz2.Width, sz1.Height - sz2.Height);
		}

		/// <summary>Проверяет, является ли указанный объект структурой <see cref="T:System.Drawing.SizeF" /> с измерениями, совпадающими с измерениями данной структуры <see cref="T:System.Drawing.SizeF" />.</summary>
		/// <param name="obj">Объект <see cref="T:System.Object" /> для проверки.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="obj" /> является размером <see cref="T:System.Drawing.SizeF" /> и его значения ширины и высоты совпадают с соответствующими значениями размера <see cref="T:System.Drawing.SizeF" />, в противном случае значение <see langword="false" />.</returns>
		// Token: 0x060002EB RID: 747 RVA: 0x000084DC File Offset: 0x000066DC
		public override bool Equals(object obj)
		{
			return obj is SizeF && this.Equals((SizeF)obj);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000084F4 File Offset: 0x000066F4
		public bool Equals(SizeF other)
		{
			return this == other;
		}

		/// <summary>Возвращает хэш-код для этой структуры <see cref="T:System.Drawing.Size" />.</summary>
		/// <returns>Целое значение, указывающее значение хэша для этой структуры <see cref="T:System.Drawing.Size" />.</returns>
		// Token: 0x060002ED RID: 749 RVA: 0x00008504 File Offset: 0x00006704
		public override int GetHashCode()
		{
			return HashHelpers.Combine(this.Width.GetHashCode(), this.Height.GetHashCode());
		}

		/// <summary>Преобразует структуру <see cref="T:System.Drawing.SizeF" /> в структуру <see cref="T:System.Drawing.PointF" />.</summary>
		/// <returns>Структура <see cref="T:System.Drawing.PointF" />.</returns>
		// Token: 0x060002EE RID: 750 RVA: 0x00008532 File Offset: 0x00006732
		public PointF ToPointF()
		{
			return (PointF)this;
		}

		/// <summary>Преобразует структуру <see cref="T:System.Drawing.SizeF" /> в структуру <see cref="T:System.Drawing.Size" />.</summary>
		/// <returns>Структура <see cref="T:System.Drawing.Size" />.</returns>
		// Token: 0x060002EF RID: 751 RVA: 0x0000853F File Offset: 0x0000673F
		public Size ToSize()
		{
			return Size.Truncate(this);
		}

		/// <summary>Создает удобную для восприятия строку, представляющую эту структуру <see cref="T:System.Drawing.SizeF" />.</summary>
		/// <returns>Строка, представляющая эту структуру <see cref="T:System.Drawing.SizeF" />.</returns>
		// Token: 0x060002F0 RID: 752 RVA: 0x0000854C File Offset: 0x0000674C
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"{Width=",
				this.width.ToString(),
				", Height=",
				this.height.ToString(),
				"}"
			});
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00008598 File Offset: 0x00006798
		private static SizeF Multiply(SizeF size, float multiplier)
		{
			return new SizeF(size.width * multiplier, size.height * multiplier);
		}

		/// <summary>Возвращает структуру <see cref="T:System.Drawing.SizeF" />, имеющую значения <see cref="P:System.Drawing.SizeF.Height" /> и <see cref="P:System.Drawing.SizeF.Width" />, равные 0.</summary>
		// Token: 0x0400039E RID: 926
		public static readonly SizeF Empty;

		// Token: 0x0400039F RID: 927
		private float width;

		// Token: 0x040003A0 RID: 928
		private float height;
	}
}
