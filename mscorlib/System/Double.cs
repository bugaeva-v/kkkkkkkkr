using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Security;

namespace System
{
	/// <summary>Представляет число двойной точности с плавающей запятой.</summary>
	// Token: 0x02000112 RID: 274
	[Serializable]
	public readonly struct Double : IComparable, IConvertible, IFormattable, IComparable<double>, IEquatable<double>, ISpanFormattable
	{
		// Token: 0x06000A93 RID: 2707 RVA: 0x00028258 File Offset: 0x00026458
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsFinite(double d)
		{
			return (BitConverter.DoubleToInt64Bits(d) & long.MaxValue) < 9218868437227405312L;
		}

		/// <summary>Возвращает значение, позволяющее определить, равно ли данное число плюс или минус бесконечности.</summary>
		/// <param name="d">Число двойной точности с плавающей запятой.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="d" /> равен значению <see cref="F:System.Double.PositiveInfinity" /> или <see cref="F:System.Double.NegativeInfinity" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A94 RID: 2708 RVA: 0x00028275 File Offset: 0x00026475
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsInfinity(double d)
		{
			return (BitConverter.DoubleToInt64Bits(d) & long.MaxValue) == 9218868437227405312L;
		}

		/// <summary>Возвращает значение, показывающее, что указанное значение не является числом (<see cref="F:System.Double.NaN" />).</summary>
		/// <param name="d">Число двойной точности с плавающей запятой.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="d" /> равно значению <see cref="F:System.Double.NaN" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A95 RID: 2709 RVA: 0x00028292 File Offset: 0x00026492
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNaN(double d)
		{
			return (BitConverter.DoubleToInt64Bits(d) & long.MaxValue) > 9218868437227405312L;
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x000282AF File Offset: 0x000264AF
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNegative(double d)
		{
			return (BitConverter.DoubleToInt64Bits(d) & long.MinValue) == long.MinValue;
		}

		/// <summary>Возвращает значение, позволяющее определить, равно ли данное число минус бесконечности.</summary>
		/// <param name="d">Число двойной точности с плавающей запятой.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="d" /> равно значению <see cref="F:System.Double.NegativeInfinity" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A97 RID: 2711 RVA: 0x000282CC File Offset: 0x000264CC
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNegativeInfinity(double d)
		{
			return d == double.NegativeInfinity;
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x000282DC File Offset: 0x000264DC
		[NonVersionable]
		public static bool IsNormal(double d)
		{
			long num = BitConverter.DoubleToInt64Bits(d);
			num &= long.MaxValue;
			return num < 9218868437227405312L && num != 0L && (num & 9218868437227405312L) != 0L;
		}

		/// <summary>Возвращает значение, показывающее, равно ли данное число плюс бесконечности.</summary>
		/// <param name="d">Число двойной точности с плавающей запятой.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="d" /> равно значению <see cref="F:System.Double.PositiveInfinity" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A99 RID: 2713 RVA: 0x0002831C File Offset: 0x0002651C
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsPositiveInfinity(double d)
		{
			return d == double.PositiveInfinity;
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x0002832C File Offset: 0x0002652C
		[NonVersionable]
		public static bool IsSubnormal(double d)
		{
			long num = BitConverter.DoubleToInt64Bits(d);
			num &= long.MaxValue;
			return num < 9218868437227405312L && num != 0L && (num & 9218868437227405312L) == 0L;
		}

		/// <summary>Сравнивает данный экземпляр с указанным объектом и возвращает целое число, которое показывает, является ли значение данного экземпляра меньше, больше или равно значению заданного объекта.</summary>
		/// <param name="value">Объект для сравнения или значение <see langword="null" />.</param>
		/// <returns>Знаковое число, представляющее относительные значения этого экземпляра и параметра <paramref name="value" />.  
		///   Значение 
		///   Описание: 
		///   Отрицательное целое число 
		///   Этот экземпляр меньше параметра <paramref name="value" />.  
		///
		/// -или- 
		/// Данный экземпляр не является числом (<see cref="F:System.Double.NaN" />), а параметр <paramref name="value" /> является.  
		///
		///   Нуль 
		///   Этот экземпляр и параметр <paramref name="value" /> равны.  
		///
		/// - или - 
		/// И данный экземпляр, и <paramref name="value" /> являются <see langword="Double.NaN" />, <see cref="F:System.Double.PositiveInfinity" /> или <see cref="F:System.Double.NegativeInfinity" />. Положительное целое число 
		///   Этот экземпляр больше параметра <paramref name="value" />.  
		///
		/// -или- 
		/// Данный экземпляр является числом, а параметр <paramref name="value" /> — нет (<see cref="F:System.Double.NaN" />).  
		///
		/// -или- 
		///  Свойство <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> не является объектом <see cref="T:System.Double" />.</exception>
		// Token: 0x06000A9B RID: 2715 RVA: 0x0002836C File Offset: 0x0002656C
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (!(value is double))
			{
				throw new ArgumentException("Object must be of type Double.");
			}
			double num = (double)value;
			if (this < num)
			{
				return -1;
			}
			if (this > num)
			{
				return 1;
			}
			if (this == num)
			{
				return 0;
			}
			if (!double.IsNaN(this))
			{
				return 1;
			}
			if (!double.IsNaN(num))
			{
				return -1;
			}
			return 0;
		}

		/// <summary>Сравнивает данный экземпляр с заданным числом двойной точности с плавающей запятой и возвращает целое число, которое показывает, является ли значение данного экземпляра меньше, больше или равно значению заданного числа двойной точности с плавающей запятой.</summary>
		/// <param name="value">Число двойной точности с плавающей запятой для сравнения.</param>
		/// <returns>Знаковое число, представляющее относительные значения этого экземпляра и параметра <paramref name="value" />.  
		///   Возвращаемое значение 
		///   Описание: 
		///   Меньше нуля 
		///   Этот экземпляр меньше параметра <paramref name="value" />.  
		///
		/// -или- 
		/// Данный экземпляр не является числом (<see cref="F:System.Double.NaN" />), а параметр <paramref name="value" /> является.  
		///
		///   Нуль 
		///   Этот экземпляр и параметр <paramref name="value" /> равны.  
		///
		/// -или- 
		/// И этот экземпляр, и параметр <paramref name="value" /> не являются числами (<see cref="F:System.Double.NaN" />), равны <see cref="F:System.Double.PositiveInfinity" /> или <see cref="F:System.Double.NegativeInfinity" />.  
		///
		///   Больше нуля 
		///   Этот экземпляр больше параметра <paramref name="value" />.  
		///
		/// -или- 
		/// Данный экземпляр является числом, а параметр <paramref name="value" /> — нет (<see cref="F:System.Double.NaN" />).</returns>
		// Token: 0x06000A9C RID: 2716 RVA: 0x000283C3 File Offset: 0x000265C3
		public int CompareTo(double value)
		{
			if (this < value)
			{
				return -1;
			}
			if (this > value)
			{
				return 1;
			}
			if (this == value)
			{
				return 0;
			}
			if (!double.IsNaN(this))
			{
				return 1;
			}
			if (!double.IsNaN(value))
			{
				return -1;
			}
			return 0;
		}

		/// <summary>Возвращает значение, показывающее, равен ли данный экземпляр заданному объекту.</summary>
		/// <param name="obj">Объект для сравнения с данным экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="obj" /> является экземпляром типа <see cref="T:System.Double" /> и равен значению данного экземпляра; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A9D RID: 2717 RVA: 0x000283F0 File Offset: 0x000265F0
		public override bool Equals(object obj)
		{
			if (!(obj is double))
			{
				return false;
			}
			double num = (double)obj;
			return num == this || (double.IsNaN(num) && double.IsNaN(this));
		}

		/// <summary>Возвращает значение, указывающее, равны ли два заданных значения <see cref="T:System.Double" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="left" /> и <paramref name="right" /> равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A9E RID: 2718 RVA: 0x00028426 File Offset: 0x00026626
		[NonVersionable]
		public static bool operator ==(double left, double right)
		{
			return left == right;
		}

		/// <summary>Возвращает значение, указывающее, не равны ли два заданных значения <see cref="T:System.Double" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="left" /> и <paramref name="right" /> не равны друг другу; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000A9F RID: 2719 RVA: 0x0002842C File Offset: 0x0002662C
		[NonVersionable]
		public static bool operator !=(double left, double right)
		{
			return left != right;
		}

		/// <summary>Возвращает значение, указывающее, действительно ли заданное значение <see cref="T:System.Double" /> меньше другого заданного значения <see cref="T:System.Double" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если значение <paramref name="left" /> меньше значения <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000AA0 RID: 2720 RVA: 0x00028435 File Offset: 0x00026635
		[NonVersionable]
		public static bool operator <(double left, double right)
		{
			return left < right;
		}

		/// <summary>Возвращает значение, указывающее, действительно ли заданное значение <see cref="T:System.Double" /> больше другого заданного значения <see cref="T:System.Double" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="left" /> больше <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000AA1 RID: 2721 RVA: 0x0002843B File Offset: 0x0002663B
		[NonVersionable]
		public static bool operator >(double left, double right)
		{
			return left > right;
		}

		/// <summary>Возвращает значение, указывающее, действительно ли заданное значение <see cref="T:System.Double" /> меньше или равно другому заданному значению <see cref="T:System.Double" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если значение <paramref name="left" /> меньше или равно значению <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000AA2 RID: 2722 RVA: 0x00028441 File Offset: 0x00026641
		[NonVersionable]
		public static bool operator <=(double left, double right)
		{
			return left <= right;
		}

		/// <summary>Возвращает значение, указывающее, действительно ли заданное значение <see cref="T:System.Double" /> больше или равно другому заданному значению <see cref="T:System.Double" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если значение <paramref name="left" /> больше или равно значению <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000AA3 RID: 2723 RVA: 0x0002844A File Offset: 0x0002664A
		[NonVersionable]
		public static bool operator >=(double left, double right)
		{
			return left >= right;
		}

		/// <summary>Возвращает значение, позволяющее определить, представляют ли этот экземпляр и заданный объект <see cref="T:System.Double" /> одно и то же значение.</summary>
		/// <param name="obj">Объект <see cref="T:System.Double" />, сравниваемый с этим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="obj" /> равно данному экземпляру; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000AA4 RID: 2724 RVA: 0x00028453 File Offset: 0x00026653
		public bool Equals(double obj)
		{
			return obj == this || (double.IsNaN(obj) && double.IsNaN(this));
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06000AA5 RID: 2725 RVA: 0x00028470 File Offset: 0x00026670
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode()
		{
			long num = BitConverter.DoubleToInt64Bits(this);
			if ((num - 1L & 9223372036854775807L) >= 9218868437227405312L)
			{
				num &= 9218868437227405312L;
			}
			return (int)num ^ (int)(num >> 32);
		}

		/// <summary>Преобразовывает числовое значение данного экземпляра в эквивалентное ему строковое представление.</summary>
		/// <returns>Строковое представление значения этого экземпляра.</returns>
		// Token: 0x06000AA6 RID: 2726 RVA: 0x000284B2 File Offset: 0x000266B2
		public override string ToString()
		{
			return Number.FormatDouble(this, null, NumberFormatInfo.CurrentInfo);
		}

		/// <summary>Преобразует числовое значение данного экземпляра в эквивалентное строковое представление с использованием указанного формата.</summary>
		/// <param name="format">Строка числового формата.</param>
		/// <returns>Строковое представление значения данного экземпляра, определяемое параметром <paramref name="format" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> недопустим.</exception>
		// Token: 0x06000AA7 RID: 2727 RVA: 0x000284C1 File Offset: 0x000266C1
		public string ToString(string format)
		{
			return Number.FormatDouble(this, format, NumberFormatInfo.CurrentInfo);
		}

		/// <summary>Преобразует числовое значение данного экземпляра в эквивалентное ему строковое представление с использованием указанных сведений об особенностях форматирования для данного языка и региональных параметров.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление значения данного экземпляра, определяемое параметром <paramref name="provider" />.</returns>
		// Token: 0x06000AA8 RID: 2728 RVA: 0x000284D0 File Offset: 0x000266D0
		[SecuritySafeCritical]
		public string ToString(IFormatProvider provider)
		{
			return Number.FormatDouble(this, null, NumberFormatInfo.GetInstance(provider));
		}

		/// <summary>Преобразует числовое значение данного экземпляра в эквивалентное ему строковое представление с использованием указанного формата и сведений об особенностях форматирования для данного языка и региональных параметров.</summary>
		/// <param name="format">Строка числового формата.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление значения данного экземпляра, определяемое параметрами <paramref name="format" /> и <paramref name="provider" />.</returns>
		// Token: 0x06000AA9 RID: 2729 RVA: 0x000284E0 File Offset: 0x000266E0
		[SecuritySafeCritical]
		public string ToString(string format, IFormatProvider provider)
		{
			return Number.FormatDouble(this, format, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x000284F0 File Offset: 0x000266F0
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider provider = null)
		{
			return Number.TryFormatDouble(this, format, NumberFormatInfo.GetInstance(provider), destination, out charsWritten);
		}

		/// <summary>Преобразует строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число.</param>
		/// <returns>Число с плавающей запятой двойной точности, которое эквивалентно числовому значению или символу, заданному параметром <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> не представляет число в допустимом формате.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="s" /> представляет число меньше <see cref="F:System.Double.MinValue" /> или больше <see cref="F:System.Double.MaxValue" />.</exception>
		// Token: 0x06000AAB RID: 2731 RVA: 0x00028503 File Offset: 0x00026703
		public static double Parse(string s)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Number.ParseDouble(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, NumberFormatInfo.CurrentInfo);
		}

		/// <summary>Преобразует строковое представление числа указанного стиля в эквивалентное ему число двойной точности с плавающей запятой.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число.</param>
		/// <param name="style">Побитовое сочетание значений перечисления, обозначающих элементы стиля, которые могут присутствовать в параметре <paramref name="s" />. Типичным задаваемым значением является сочетание <see cref="F:System.Globalization.NumberStyles.Float" /> и <see cref="F:System.Globalization.NumberStyles.AllowThousands" />.</param>
		/// <returns>Число с плавающей запятой двойной точности, которое эквивалентно числовому значению или символу, заданному параметром <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> не представляет число в допустимом формате.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="s" /> представляет число меньше <see cref="F:System.Double.MinValue" /> или больше <see cref="F:System.Double.MaxValue" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		/// -или- 
		///  <paramref name="style" /> включает значение <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" />.</exception>
		// Token: 0x06000AAC RID: 2732 RVA: 0x00028524 File Offset: 0x00026724
		public static double Parse(string s, NumberStyles style)
		{
			NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Number.ParseDouble(s, style, NumberFormatInfo.CurrentInfo);
		}

		/// <summary>Преобразует строковое представление числа, выраженное в заданном формате, связанном с языком и региональными параметрами, в эквивалентное ему число двойной точности с плавающей запятой.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число.</param>
		/// <param name="provider">Объект, который предоставляет сведения о форматировании параметра <paramref name="s" /> в зависимости от языка и региональных параметров.</param>
		/// <returns>Число с плавающей запятой двойной точности, которое эквивалентно числовому значению или символу, заданному параметром <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> не представляет число в допустимом формате.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="s" /> представляет число меньше <see cref="F:System.Double.MinValue" /> или больше <see cref="F:System.Double.MaxValue" />.</exception>
		// Token: 0x06000AAD RID: 2733 RVA: 0x00028547 File Offset: 0x00026747
		public static double Parse(string s, IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Number.ParseDouble(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, NumberFormatInfo.GetInstance(provider));
		}

		/// <summary>Преобразует строковое представление числа указанного стиля, выраженное в формате, соответствующем определенному языку и региональным параметрам, в эквивалентное ему число двойной точности с плавающей запятой.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число.</param>
		/// <param name="style">Побитовое сочетание значений перечисления, обозначающих элементы стиля, которые могут присутствовать в параметре <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.NumberStyles.Float" /> в сочетании со значением <see cref="F:System.Globalization.NumberStyles.AllowThousands" />.</param>
		/// <param name="provider">Объект, который предоставляет сведения о форматировании параметра <paramref name="s" /> в зависимости от языка и региональных параметров.</param>
		/// <returns>Число с плавающей запятой двойной точности, которое эквивалентно числовому значению или символу, заданному параметром <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="s" /> не представляет числовое значение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		/// -или- 
		///  <paramref name="style" /> является значением <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" />.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="s" /> представляет число меньше <see cref="F:System.Double.MinValue" /> или больше <see cref="F:System.Double.MaxValue" />.</exception>
		// Token: 0x06000AAE RID: 2734 RVA: 0x00028569 File Offset: 0x00026769
		public static double Parse(string s, NumberStyles style, IFormatProvider provider)
		{
			NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Number.ParseDouble(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0002858D File Offset: 0x0002678D
		public static double Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
			return Number.ParseDouble(s, style, NumberFormatInfo.GetInstance(provider));
		}

		/// <summary>Преобразует строковое представление числа в эквивалентное ему число двойной точности с плавающей запятой. Возвращает значение, указывающее, успешно ли выполнено преобразование.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число.</param>
		/// <param name="result">При возврате этот метод содержит число двойной точности с плавающей запятой, эквивалентное параметру <paramref name="s" />, если преобразование завершилось успешно, или нуль, если оно завершилось неудачно. Преобразование завершается сбоем, если значение параметра <paramref name="s" /> равно <see langword="null" /> или <see cref="F:System.String.Empty" />, не является числом допустимого формата или представляет число меньше <see cref="F:System.Double.MinValue" /> или больше <see cref="F:System.Double.MaxValue" />. Этот параметр передается неинициализированным; любое значение, первоначально предоставленное в объекте <paramref name="result" />, будет перезаписано.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="s" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000AB0 RID: 2736 RVA: 0x000285A2 File Offset: 0x000267A2
		public static bool TryParse(string s, out double result)
		{
			if (s == null)
			{
				result = 0.0;
				return false;
			}
			return double.TryParse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, NumberFormatInfo.CurrentInfo, out result);
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x000285CA File Offset: 0x000267CA
		public static bool TryParse(ReadOnlySpan<char> s, out double result)
		{
			return double.TryParse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, NumberFormatInfo.CurrentInfo, out result);
		}

		/// <summary>Преобразует строковое представление числа указанного стиля, выраженное в формате, соответствующем определенному языку и региональным параметрам, в эквивалентное ему число двойной точности с плавающей запятой. Возвращает значение, указывающее, успешно ли выполнено преобразование.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число.</param>
		/// <param name="style">Побитовое сочетание значений <see cref="T:System.Globalization.NumberStyles" />, определяющее разрешенный формат параметра <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.NumberStyles.Float" /> в сочетании со значением <see cref="F:System.Globalization.NumberStyles.AllowThousands" />.</param>
		/// <param name="provider">Интерфейс <see cref="T:System.IFormatProvider" /> предоставляет сведения о форматировании параметра <paramref name="s" /> для соответствующего языка и региональных параметров.</param>
		/// <param name="result">При возврате этот метод содержит число двойной точности с плавающей запятой, эквивалентное числовому значению или символу, содержащемуся в параметре <paramref name="s" />, если преобразование завершилось успешно, или нуль, если оно завершилось неудачно. Преобразование завершается неудачно, если параметр <paramref name="s" /> имеет значение <see langword="null" /> или <see cref="F:System.String.Empty" />, не является значением в формате, совместимом с параметром <paramref name="style" />, представляет число меньше <see cref="F:System.SByte.MinValue" /> или больше <see cref="F:System.SByte.MaxValue" />, либо если <paramref name="style" /> не является допустимой комбинацией перечисленных констант <see cref="T:System.Globalization.NumberStyles" />. Этот параметр передается неинициализированным; любое значение, первоначально предоставленное в объекте <paramref name="result" />, будет перезаписано.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="s" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		/// -или- 
		///  <paramref name="style" /> включает значение <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" />.</exception>
		// Token: 0x06000AB2 RID: 2738 RVA: 0x000285DD File Offset: 0x000267DD
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out double result)
		{
			NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
			if (s == null)
			{
				result = 0.0;
				return false;
			}
			return double.TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00028608 File Offset: 0x00026808
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out double result)
		{
			NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
			return double.TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00028620 File Offset: 0x00026820
		private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out double result)
		{
			if (!Number.TryParseDouble(s, style, info, out result))
			{
				ReadOnlySpan<char> span = s.Trim();
				if (span.EqualsOrdinal(info.PositiveInfinitySymbol))
				{
					result = double.PositiveInfinity;
				}
				else if (span.EqualsOrdinal(info.NegativeInfinitySymbol))
				{
					result = double.NegativeInfinity;
				}
				else
				{
					if (!span.EqualsOrdinal(info.NaNSymbol))
					{
						return false;
					}
					result = double.NaN;
				}
			}
			return true;
		}

		/// <summary>Возвращает <see cref="T:System.TypeCode" /> для типа значения <see cref="T:System.Double" />.</summary>
		/// <returns>Константа перечислимого типа, <see cref="F:System.TypeCode.Double" />.</returns>
		// Token: 0x06000AB5 RID: 2741 RVA: 0x000286A2 File Offset: 0x000268A2
		public TypeCode GetTypeCode()
		{
			return TypeCode.Double;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>
		///   <see langword="true" />, если значение текущего экземпляра не равно нулю; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000AB6 RID: 2742 RVA: 0x000286A6 File Offset: 0x000268A6
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this);
		}

		/// <summary>Данное преобразование не поддерживается. При попытке использовать этот метод выбрасывается исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x06000AB7 RID: 2743 RVA: 0x000286AF File Offset: 0x000268AF
		char IConvertible.ToChar(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "Double", "Char"));
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToSByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.SByte" />.</returns>
		// Token: 0x06000AB8 RID: 2744 RVA: 0x000286CA File Offset: 0x000268CA
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Byte" />.</returns>
		// Token: 0x06000AB9 RID: 2745 RVA: 0x000286D3 File Offset: 0x000268D3
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Int16" />.</returns>
		// Token: 0x06000ABA RID: 2746 RVA: 0x000286DC File Offset: 0x000268DC
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.UInt16" />.</returns>
		// Token: 0x06000ABB RID: 2747 RVA: 0x000286E5 File Offset: 0x000268E5
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Int32" />.</returns>
		// Token: 0x06000ABC RID: 2748 RVA: 0x000286EE File Offset: 0x000268EE
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.UInt32" />.</returns>
		// Token: 0x06000ABD RID: 2749 RVA: 0x000286F7 File Offset: 0x000268F7
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Int64" />.</returns>
		// Token: 0x06000ABE RID: 2750 RVA: 0x00028700 File Offset: 0x00026900
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.UInt64" />.</returns>
		// Token: 0x06000ABF RID: 2751 RVA: 0x00028709 File Offset: 0x00026909
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToSingle(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Single" />.</returns>
		// Token: 0x06000AC0 RID: 2752 RVA: 0x00028712 File Offset: 0x00026912
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToDouble(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, не измененное.</returns>
		// Token: 0x06000AC1 RID: 2753 RVA: 0x0002871B File Offset: 0x0002691B
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return this;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToDecimal(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Decimal" />.</returns>
		// Token: 0x06000AC2 RID: 2754 RVA: 0x0002871F File Offset: 0x0002691F
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this);
		}

		/// <summary>Данное преобразование не поддерживается. При попытке использовать этот метод возникает исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x06000AC3 RID: 2755 RVA: 0x00028728 File Offset: 0x00026928
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "Double", "DateTime"));
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)" />.</summary>
		/// <param name="type">Тип, к которому необходимо привести это значение <see cref="T:System.Double" />.</param>
		/// <param name="provider">Реализация интерфейса <see cref="T:System.IFormatProvider" />, предоставляющая сведения о формате возвращаемого значения, связанные с языком и региональными параметрами.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <paramref name="type" />.</returns>
		// Token: 0x06000AC4 RID: 2756 RVA: 0x00028743 File Offset: 0x00026943
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x040010D9 RID: 4313
		private readonly double m_value;

		/// <summary>Представляет минимально допустимое значение типа <see cref="T:System.Double" />. Это поле является константой.</summary>
		// Token: 0x040010DA RID: 4314
		public const double MinValue = -1.7976931348623157E+308;

		/// <summary>Представляет наибольшее возможное значение типа <see cref="T:System.Double" />. Это поле является константой.</summary>
		// Token: 0x040010DB RID: 4315
		public const double MaxValue = 1.7976931348623157E+308;

		/// <summary>Представляет наименьшее положительное значение <see cref="T:System.Double" /> больше нуля. Это поле является константой.</summary>
		// Token: 0x040010DC RID: 4316
		public const double Epsilon = 5E-324;

		/// <summary>Представляет минус бесконечность. Это поле является константой.</summary>
		// Token: 0x040010DD RID: 4317
		public const double NegativeInfinity = double.NegativeInfinity;

		/// <summary>Представляет плюс бесконечность. Это поле является константой.</summary>
		// Token: 0x040010DE RID: 4318
		public const double PositiveInfinity = double.PositiveInfinity;

		/// <summary>Представляет значение, не являющееся числом (<see langword="NaN" />). Это поле является константой.</summary>
		// Token: 0x040010DF RID: 4319
		public const double NaN = double.NaN;

		// Token: 0x040010E0 RID: 4320
		internal const double NegativeZero = --0.0;
	}
}
