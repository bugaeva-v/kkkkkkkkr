using System;
using System.ComponentModel;
using System.Numerics.Hashing;

namespace System.Drawing
{
	/// <summary>Сохраняет упорядоченную пару целых чисел, указывающих <see cref="P:System.Drawing.Size.Height" /> и <see cref="P:System.Drawing.Size.Width" />.</summary>
	// Token: 0x0200004B RID: 75
	[TypeConverter(typeof(SizeConverter))]
	[Serializable]
	public struct Size : IEquatable<Size>
	{
		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Drawing.Size" /> из указанной структуры <see cref="T:System.Drawing.Point" />.</summary>
		/// <param name="pt">Структура <see cref="T:System.Drawing.Point" />, из которой инициализируется эта структура <see cref="T:System.Drawing.Size" />.</param>
		// Token: 0x060002BA RID: 698 RVA: 0x00008109 File Offset: 0x00006309
		public Size(Point pt)
		{
			this.width = pt.X;
			this.height = pt.Y;
		}

		/// <summary>Инициализирует новый экземпляр структуры <see cref="T:System.Drawing.Size" /> из указанных измерений.</summary>
		/// <param name="width">Компонент ширины нового <see cref="T:System.Drawing.Size" />.</param>
		/// <param name="height">Компонент высоты нового размера <see cref="T:System.Drawing.Size" />.</param>
		// Token: 0x060002BB RID: 699 RVA: 0x00008125 File Offset: 0x00006325
		public Size(int width, int height)
		{
			this.width = width;
			this.height = height;
		}

		/// <summary>Преобразует указанную структуру <see cref="T:System.Drawing.Size" /> в структуру <see cref="T:System.Drawing.SizeF" />.</summary>
		/// <param name="p">Преобразуемая структура <see cref="T:System.Drawing.Size" />.</param>
		/// <returns>Структура <see cref="T:System.Drawing.SizeF" />, которая является результатом преобразования, выполненного с помощью этого оператора.</returns>
		// Token: 0x060002BC RID: 700 RVA: 0x00008135 File Offset: 0x00006335
		public static implicit operator SizeF(Size p)
		{
			return new SizeF((float)p.Width, (float)p.Height);
		}

		/// <summary>Прибавляет ширину и высоту одной структуры <see cref="T:System.Drawing.Size" /> к ширине и высоте другой структуры <see cref="T:System.Drawing.Size" />.</summary>
		/// <param name="sz1">Первый прибавляемый размер <see cref="T:System.Drawing.Size" />.</param>
		/// <param name="sz2">Второй прибавляемый размер <see cref="T:System.Drawing.Size" />.</param>
		/// <returns>Структура <see cref="T:System.Drawing.Size" />, получаемая в результате операции сложения.</returns>
		// Token: 0x060002BD RID: 701 RVA: 0x0000814C File Offset: 0x0000634C
		public static Size operator +(Size sz1, Size sz2)
		{
			return Size.Add(sz1, sz2);
		}

		/// <summary>Вычитает ширину и высоту одной структуры <see cref="T:System.Drawing.Size" /> из ширины и высоты другой структуры <see cref="T:System.Drawing.Size" />.</summary>
		/// <param name="sz1">Структура <see cref="T:System.Drawing.Size" />, которая находится слева от оператора вычитания.</param>
		/// <param name="sz2">Структура <see cref="T:System.Drawing.Size" />, которая находится справа от оператора вычитания.</param>
		/// <returns>Структура <see cref="T:System.Drawing.Size" />, полученная в результате операции вычитания.</returns>
		// Token: 0x060002BE RID: 702 RVA: 0x00008155 File Offset: 0x00006355
		public static Size operator -(Size sz1, Size sz2)
		{
			return Size.Subtract(sz1, sz2);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000815E File Offset: 0x0000635E
		public static Size operator *(int left, Size right)
		{
			return Size.Multiply(right, left);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00008167 File Offset: 0x00006367
		public static Size operator *(Size left, int right)
		{
			return Size.Multiply(left, right);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00008170 File Offset: 0x00006370
		public static Size operator /(Size left, int right)
		{
			return new Size(left.width / right, left.height / right);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00008187 File Offset: 0x00006387
		public static SizeF operator *(float left, Size right)
		{
			return Size.Multiply(right, left);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00008190 File Offset: 0x00006390
		public static SizeF operator *(Size left, float right)
		{
			return Size.Multiply(left, right);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00008199 File Offset: 0x00006399
		public static SizeF operator /(Size left, float right)
		{
			return new SizeF((float)left.width / right, (float)left.height / right);
		}

		/// <summary>Проверяет равенство двух структур <see cref="T:System.Drawing.Size" /> .</summary>
		/// <param name="sz1">Структура <see cref="T:System.Drawing.Size" />, которая находится слева от оператора равенства.</param>
		/// <param name="sz2">Структура <see cref="T:System.Drawing.Size" />, которая находится справа от оператора равенства.</param>
		/// <returns>Значение <see langword="true" />, если у <paramref name="sz1" /> и <paramref name="sz2" /> равны значения ширины и высоты, в противном случае значение <see langword="false" />.</returns>
		// Token: 0x060002C5 RID: 709 RVA: 0x000081B2 File Offset: 0x000063B2
		public static bool operator ==(Size sz1, Size sz2)
		{
			return sz1.Width == sz2.Width && sz1.Height == sz2.Height;
		}

		/// <summary>Определяет равенство двух структур <see cref="T:System.Drawing.Size" />.</summary>
		/// <param name="sz1">Структура <see cref="T:System.Drawing.Size" />, которая находится слева от оператора неравенства.</param>
		/// <param name="sz2">Структура <see cref="T:System.Drawing.Size" />, которая находится справа от оператора неравенства.</param>
		/// <returns>Значение <see langword="true" />, если параметры <paramref name="sz1" /> и <paramref name="sz2" /> отличаются по ширине или высоте, и значение <see langword="false" />, если параметры <paramref name="sz1" /> и <paramref name="sz2" /> равны.</returns>
		// Token: 0x060002C6 RID: 710 RVA: 0x000081D6 File Offset: 0x000063D6
		public static bool operator !=(Size sz1, Size sz2)
		{
			return !(sz1 == sz2);
		}

		/// <summary>Преобразует указанную структуру <see cref="T:System.Drawing.Size" /> в структуру <see cref="T:System.Drawing.Point" />.</summary>
		/// <param name="size">Преобразуемая структура <see cref="T:System.Drawing.Size" />.</param>
		/// <returns>Структура <see cref="T:System.Drawing.Point" />, которая является результатом преобразования, выполненного с помощью этого оператора.</returns>
		// Token: 0x060002C7 RID: 711 RVA: 0x000081E2 File Offset: 0x000063E2
		public static explicit operator Point(Size size)
		{
			return new Point(size.Width, size.Height);
		}

		/// <summary>Проверяет, равны ли 0 ширина и высота структуры <see cref="T:System.Drawing.Size" />.</summary>
		/// <returns>Это свойство возвращает значение <see langword="true" />, если структура <see cref="T:System.Drawing.Size" /> имеет нулевые значения ширины и высоты; в противном случае возвращается значение <see langword="false" />.</returns>
		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x000081F7 File Offset: 0x000063F7
		[Browsable(false)]
		public bool IsEmpty
		{
			get
			{
				return this.width == 0 && this.height == 0;
			}
		}

		/// <summary>Получает или задает горизонтальный компонент этой структуры <see cref="T:System.Drawing.Size" />.</summary>
		/// <returns>Горизонтальный компонент этой структуры <see cref="T:System.Drawing.Size" />, обычно измеряемый в пикселях.</returns>
		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x0000820C File Offset: 0x0000640C
		// (set) Token: 0x060002CA RID: 714 RVA: 0x00008214 File Offset: 0x00006414
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

		/// <summary>Возвращает или задает вертикальный компонент этой структуры <see cref="T:System.Drawing.Size" />.</summary>
		/// <returns>Вертикальный компонент этой структуры <see cref="T:System.Drawing.Size" />, обычно измеряемый в пикселях.</returns>
		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060002CB RID: 715 RVA: 0x0000821D File Offset: 0x0000641D
		// (set) Token: 0x060002CC RID: 716 RVA: 0x00008225 File Offset: 0x00006425
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

		/// <summary>Прибавляет ширину и высоту одной структуры <see cref="T:System.Drawing.Size" /> к ширине и высоте другой структуры <see cref="T:System.Drawing.Size" />.</summary>
		/// <param name="sz1">Первая структура <see cref="T:System.Drawing.Size" /> для сложения.</param>
		/// <param name="sz2">Вторая структура <see cref="T:System.Drawing.Size" /> для сложения.</param>
		/// <returns>Структура <see cref="T:System.Drawing.Size" />, получаемая в результате операции сложения.</returns>
		// Token: 0x060002CD RID: 717 RVA: 0x0000822E File Offset: 0x0000642E
		public static Size Add(Size sz1, Size sz2)
		{
			return new Size(sz1.Width + sz2.Width, sz1.Height + sz2.Height);
		}

		/// <summary>Преобразует указанную структуру <see cref="T:System.Drawing.SizeF" /> в структуру <see cref="T:System.Drawing.Size" />, округляя значения структуры <see cref="T:System.Drawing.Size" /> до ближайшего большего целого числа.</summary>
		/// <param name="value">Преобразуемая структура <see cref="T:System.Drawing.SizeF" />.</param>
		/// <returns>Структура <see cref="T:System.Drawing.Size" />, которая является результатом преобразования, выполненного с помощью этого метода.</returns>
		// Token: 0x060002CE RID: 718 RVA: 0x00008253 File Offset: 0x00006453
		public static Size Ceiling(SizeF value)
		{
			return new Size((int)Math.Ceiling((double)value.Width), (int)Math.Ceiling((double)value.Height));
		}

		/// <summary>Вычитает ширину и высоту одной структуры <see cref="T:System.Drawing.Size" /> из ширины и высоты другой структуры <see cref="T:System.Drawing.Size" />.</summary>
		/// <param name="sz1">Структура <see cref="T:System.Drawing.Size" />, которая находится слева от оператора вычитания.</param>
		/// <param name="sz2">Структура <see cref="T:System.Drawing.Size" />, которая находится справа от оператора вычитания.</param>
		/// <returns>Структура <see cref="T:System.Drawing.Size" />, полученная в результате операции вычитания.</returns>
		// Token: 0x060002CF RID: 719 RVA: 0x00008276 File Offset: 0x00006476
		public static Size Subtract(Size sz1, Size sz2)
		{
			return new Size(sz1.Width - sz2.Width, sz1.Height - sz2.Height);
		}

		/// <summary>Преобразует указанную структуру <see cref="T:System.Drawing.SizeF" /> в структуру <see cref="T:System.Drawing.Size" />, округляя значения структуры <see cref="T:System.Drawing.SizeF" /> до ближайших меньших целых чисел.</summary>
		/// <param name="value">Преобразуемая структура <see cref="T:System.Drawing.SizeF" />.</param>
		/// <returns>Структура <see cref="T:System.Drawing.Size" />, которая является результатом преобразования, выполненного с помощью этого метода.</returns>
		// Token: 0x060002D0 RID: 720 RVA: 0x0000829B File Offset: 0x0000649B
		public static Size Truncate(SizeF value)
		{
			return new Size((int)value.Width, (int)value.Height);
		}

		/// <summary>Преобразует указанную структуру <see cref="T:System.Drawing.SizeF" /> в структуру <see cref="T:System.Drawing.Size" />, округляя значения структуры <see cref="T:System.Drawing.SizeF" /> до ближайших целых чисел.</summary>
		/// <param name="value">Преобразуемая структура <see cref="T:System.Drawing.SizeF" />.</param>
		/// <returns>Структура <see cref="T:System.Drawing.Size" />, которая является результатом преобразования, выполненного с помощью этого метода.</returns>
		// Token: 0x060002D1 RID: 721 RVA: 0x000082B2 File Offset: 0x000064B2
		public static Size Round(SizeF value)
		{
			return new Size((int)Math.Round((double)value.Width), (int)Math.Round((double)value.Height));
		}

		/// <summary>Проверяет, является ли указанный объект структурой <see cref="T:System.Drawing.Size" /> с измерениями, совпадающими с измерениями данной структуры <see cref="T:System.Drawing.Size" />.</summary>
		/// <param name="obj">Объект <see cref="T:System.Object" /> для проверки.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="obj" /> является размером <see cref="T:System.Drawing.Size" /> и его значения ширины и высоты совпадают с соответствующими значениями размера <see cref="T:System.Drawing.Size" />, в противном случае значение <see langword="false" />.</returns>
		// Token: 0x060002D2 RID: 722 RVA: 0x000082D5 File Offset: 0x000064D5
		public override bool Equals(object obj)
		{
			return obj is Size && this.Equals((Size)obj);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x000082ED File Offset: 0x000064ED
		public bool Equals(Size other)
		{
			return this == other;
		}

		/// <summary>Возвращает хэш-код для этой структуры <see cref="T:System.Drawing.Size" />.</summary>
		/// <returns>Целое значение, указывающее значение хэша для этой структуры <see cref="T:System.Drawing.Size" />.</returns>
		// Token: 0x060002D4 RID: 724 RVA: 0x000082FB File Offset: 0x000064FB
		public override int GetHashCode()
		{
			return HashHelpers.Combine(this.Width, this.Height);
		}

		/// <summary>Создает удобную для восприятия строку, представляющую эту структуру <see cref="T:System.Drawing.Size" />.</summary>
		/// <returns>Строка, представляющая эту структуру <see cref="T:System.Drawing.Size" />.</returns>
		// Token: 0x060002D5 RID: 725 RVA: 0x00008310 File Offset: 0x00006510
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

		// Token: 0x060002D6 RID: 726 RVA: 0x0000835C File Offset: 0x0000655C
		private static Size Multiply(Size size, int multiplier)
		{
			return new Size(size.width * multiplier, size.height * multiplier);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00008373 File Offset: 0x00006573
		private static SizeF Multiply(Size size, float multiplier)
		{
			return new SizeF((float)size.width * multiplier, (float)size.height * multiplier);
		}

		/// <summary>Возвращает структуру <see cref="T:System.Drawing.Size" />, имеющую значения <see cref="P:System.Drawing.Size.Height" /> и <see cref="P:System.Drawing.Size.Width" />, равные 0.</summary>
		// Token: 0x0400039B RID: 923
		public static readonly Size Empty;

		// Token: 0x0400039C RID: 924
		private int width;

		// Token: 0x0400039D RID: 925
		private int height;
	}
}
