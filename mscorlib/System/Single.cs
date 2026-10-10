using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Security;

namespace System
{
	/// <summary>Представляет число с плавающей запятой одиночной точности.</summary>
	// Token: 0x0200017C RID: 380
	[Serializable]
	public readonly struct Single : IComparable, IConvertible, IFormattable, IComparable<float>, IEquatable<float>, ISpanFormattable
	{
		// Token: 0x06000F10 RID: 3856 RVA: 0x0003CE35 File Offset: 0x0003B035
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsFinite(float f)
		{
			return (BitConverter.SingleToInt32Bits(f) & int.MaxValue) < 2139095040;
		}

		/// <summary>Возвращает значение, позволяющее определить, равно ли данное число плюс или минус бесконечности.</summary>
		/// <param name="f">Число с плавающей запятой одиночной точности.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="f" /> равен значению <see cref="F:System.Single.PositiveInfinity" /> или <see cref="F:System.Single.NegativeInfinity" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000F11 RID: 3857 RVA: 0x0003CE4A File Offset: 0x0003B04A
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsInfinity(float f)
		{
			return (BitConverter.SingleToInt32Bits(f) & int.MaxValue) == 2139095040;
		}

		/// <summary>Возвращает значение, показывающее, что указанное значение не является числом (<see cref="F:System.Single.NaN" />).</summary>
		/// <param name="f">Число с плавающей запятой одиночной точности.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="f" /> относится к нечисловому типу (<see cref="F:System.Single.NaN" />); в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000F12 RID: 3858 RVA: 0x0003CE5F File Offset: 0x0003B05F
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNaN(float f)
		{
			return (BitConverter.SingleToInt32Bits(f) & int.MaxValue) > 2139095040;
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x0003CE74 File Offset: 0x0003B074
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNegative(float f)
		{
			return (BitConverter.SingleToInt32Bits(f) & int.MinValue) == int.MinValue;
		}

		/// <summary>Возвращает значение, позволяющее определить, равно ли данное число минус бесконечности.</summary>
		/// <param name="f">Число с плавающей запятой одиночной точности.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="f" /> равно значению <see cref="F:System.Single.NegativeInfinity" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000F14 RID: 3860 RVA: 0x0003CE89 File Offset: 0x0003B089
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNegativeInfinity(float f)
		{
			return f == float.NegativeInfinity;
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x0003CE94 File Offset: 0x0003B094
		[NonVersionable]
		public static bool IsNormal(float f)
		{
			int num = BitConverter.SingleToInt32Bits(f);
			num &= int.MaxValue;
			return num < 2139095040 && num != 0 && (num & 2139095040) != 0;
		}

		/// <summary>Возвращает значение, показывающее, равно ли данное число плюс бесконечности.</summary>
		/// <param name="f">Число с плавающей запятой одиночной точности.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="f" /> равно значению <see cref="F:System.Single.PositiveInfinity" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000F16 RID: 3862 RVA: 0x0003CEC7 File Offset: 0x0003B0C7
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsPositiveInfinity(float f)
		{
			return f == float.PositiveInfinity;
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x0003CED4 File Offset: 0x0003B0D4
		[NonVersionable]
		public static bool IsSubnormal(float f)
		{
			int num = BitConverter.SingleToInt32Bits(f);
			num &= int.MaxValue;
			return num < 2139095040 && num != 0 && (num & 2139095040) == 0;
		}

		/// <summary>Сравнивает данный экземпляр с указанным объектом и возвращает целое число, которое показывает, является ли значение данного экземпляра меньше, больше или равно значению заданного объекта.</summary>
		/// <param name="value">Объект для сравнения или значение <see langword="null" />.</param>
		/// <returns>Знаковое число, представляющее относительные значения этого экземпляра и параметра <paramref name="value" />.  
		///   Возвращаемое значение 
		///   Описание: 
		///   Меньше нуля 
		///   Этот экземпляр меньше параметра <paramref name="value" />.  
		///
		/// -или- 
		/// Данный экземпляр не является числом (<see cref="F:System.Single.NaN" />), а параметр <paramref name="value" /> является.  
		///
		///   Нуль 
		///   Этот экземпляр и параметр <paramref name="value" /> равны.  
		///
		/// -или- 
		/// И данный экземпляр, и значение относятся к нечисловому типу (<see cref="F:System.Single.NaN" />), равны <see cref="F:System.Single.PositiveInfinity" /> или <see cref="F:System.Single.NegativeInfinity" />.  
		///
		///   Больше нуля 
		///   Этот экземпляр больше параметра <paramref name="value" />.  
		///
		/// -или- 
		/// Данный экземпляр является числом, а параметр <paramref name="value" /> — нет (<see cref="F:System.Single.NaN" />).  
		///
		/// - или - 
		///  Свойство <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> не является объектом <see cref="T:System.Single" />.</exception>
		// Token: 0x06000F18 RID: 3864 RVA: 0x0003CF08 File Offset: 0x0003B108
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (!(value is float))
			{
				throw new ArgumentException("Object must be of type Single.");
			}
			float num = (float)value;
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
			if (!float.IsNaN(this))
			{
				return 1;
			}
			if (!float.IsNaN(num))
			{
				return -1;
			}
			return 0;
		}

		/// <summary>Сравнивает данный экземпляр с заданным числом с плавающей запятой одиночной точности и возвращает целое число, которое показывает, является ли значение данного экземпляра меньше, больше или равным значению заданного числа с плавающей запятой одиночной точности.</summary>
		/// <param name="value">Сравниваемое число с плавающей запятой одиночной точности.</param>
		/// <returns>Знаковое число, представляющее относительные значения этого экземпляра и параметра <paramref name="value" />.  
		///   Возвращаемое значение 
		///   Описание 
		///   Меньше нуля 
		///   Этот экземпляр меньше параметра <paramref name="value" />.  
		///
		/// -или- 
		/// Данный экземпляр не является числом (<see cref="F:System.Single.NaN" />), а параметр <paramref name="value" /> является.  
		///
		///   Нуль 
		///   Этот экземпляр и параметр <paramref name="value" /> равны.  
		///
		/// - или - 
		/// И этот экземпляр, и параметр <paramref name="value" /> не являются числами (<see cref="F:System.Single.NaN" />), равны <see cref="F:System.Single.PositiveInfinity" /> или <see cref="F:System.Single.NegativeInfinity" />.  
		///
		///   Больше нуля 
		///   Этот экземпляр больше параметра <paramref name="value" />.  
		///
		/// -или- 
		/// Данный экземпляр является числом, а параметр <paramref name="value" /> — нет (<see cref="F:System.Single.NaN" />).</returns>
		// Token: 0x06000F19 RID: 3865 RVA: 0x0003CF5F File Offset: 0x0003B15F
		public int CompareTo(float value)
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
			if (!float.IsNaN(this))
			{
				return 1;
			}
			if (!float.IsNaN(value))
			{
				return -1;
			}
			return 0;
		}

		/// <summary>Возвращает значение, указывающее, равны ли два заданных значения <see cref="T:System.Single" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="left" /> и <paramref name="right" /> равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000F1A RID: 3866 RVA: 0x00028426 File Offset: 0x00026626
		[NonVersionable]
		public static bool operator ==(float left, float right)
		{
			return left == right;
		}

		/// <summary>Возвращает значение, указывающее, не равны ли два заданных значения <see cref="T:System.Single" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="left" /> и <paramref name="right" /> не равны друг другу; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000F1B RID: 3867 RVA: 0x0002842C File Offset: 0x0002662C
		[NonVersionable]
		public static bool operator !=(float left, float right)
		{
			return left != right;
		}

		/// <summary>Возвращает значение, указывающее, действительно ли заданное значение <see cref="T:System.Single" /> меньше другого заданного значения <see cref="T:System.Single" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если значение <paramref name="left" /> меньше значения <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000F1C RID: 3868 RVA: 0x00028435 File Offset: 0x00026635
		[NonVersionable]
		public static bool operator <(float left, float right)
		{
			return left < right;
		}

		/// <summary>Возвращает значение, указывающее, действительно ли заданное значение <see cref="T:System.Single" /> больше другого заданного значения <see cref="T:System.Single" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="left" /> больше <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000F1D RID: 3869 RVA: 0x0002843B File Offset: 0x0002663B
		[NonVersionable]
		public static bool operator >(float left, float right)
		{
			return left > right;
		}

		/// <summary>Возвращает значение, указывающее, действительно ли заданное значение <see cref="T:System.Single" /> меньше или равно другому заданному значению <see cref="T:System.Single" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если значение <paramref name="left" /> меньше или равно значению <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000F1E RID: 3870 RVA: 0x00028441 File Offset: 0x00026641
		[NonVersionable]
		public static bool operator <=(float left, float right)
		{
			return left <= right;
		}

		/// <summary>Возвращает значение, указывающее, действительно ли заданное значение <see cref="T:System.Single" /> больше или равно другому заданному значению <see cref="T:System.Single" />.</summary>
		/// <param name="left">Первое сравниваемое значение.</param>
		/// <param name="right">Второе сравниваемое значение.</param>
		/// <returns>
		///   <see langword="true" />, если значение <paramref name="left" /> больше или равно значению <paramref name="right" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000F1F RID: 3871 RVA: 0x0002844A File Offset: 0x0002664A
		[NonVersionable]
		public static bool operator >=(float left, float right)
		{
			return left >= right;
		}

		/// <summary>Возвращает значение, показывающее, равен ли данный экземпляр заданному объекту.</summary>
		/// <param name="obj">Объект для сравнения с данным экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="obj" /> является экземпляром типа <see cref="T:System.Single" /> и равен значению данного экземпляра; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000F20 RID: 3872 RVA: 0x0003CF8C File Offset: 0x0003B18C
		public override bool Equals(object obj)
		{
			if (!(obj is float))
			{
				return false;
			}
			float num = (float)obj;
			return num == this || (float.IsNaN(num) && float.IsNaN(this));
		}

		/// <summary>Возвращает значение, позволяющее определить, представляют ли этот экземпляр и заданный объект <see cref="T:System.Single" /> одно и то же значение.</summary>
		/// <param name="obj">Объект для сравнения с данным экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="obj" /> равно данному экземпляру; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000F21 RID: 3873 RVA: 0x0003CFC2 File Offset: 0x0003B1C2
		public bool Equals(float obj)
		{
			return obj == this || (float.IsNaN(obj) && float.IsNaN(this));
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06000F22 RID: 3874 RVA: 0x0003CFDC File Offset: 0x0003B1DC
		public override int GetHashCode()
		{
			int num = BitConverter.SingleToInt32Bits(this);
			if ((num - 1 & 2147483647) >= 2139095040)
			{
				num &= 2139095040;
			}
			return num;
		}

		/// <summary>Преобразовывает числовое значение данного экземпляра в эквивалентное ему строковое представление.</summary>
		/// <returns>Строковое представление значения этого экземпляра.</returns>
		// Token: 0x06000F23 RID: 3875 RVA: 0x0003D00A File Offset: 0x0003B20A
		public override string ToString()
		{
			return Number.FormatSingle(this, null, NumberFormatInfo.CurrentInfo);
		}

		/// <summary>Преобразует числовое значение данного экземпляра в эквивалентное ему строковое представление с использованием указанных сведений об особенностях форматирования для данного языка и региональных параметров.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление значения данного экземпляра, определяемое параметром <paramref name="provider" />.</returns>
		// Token: 0x06000F24 RID: 3876 RVA: 0x0003D019 File Offset: 0x0003B219
		[SecuritySafeCritical]
		public string ToString(IFormatProvider provider)
		{
			return Number.FormatSingle(this, null, NumberFormatInfo.GetInstance(provider));
		}

		/// <summary>Преобразует числовое значение данного экземпляра в эквивалентное строковое представление с использованием указанного формата.</summary>
		/// <param name="format">Строка числового формата.</param>
		/// <returns>Строковое представление значения данного экземпляра, определяемое параметром <paramref name="format" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> недопустим.</exception>
		// Token: 0x06000F25 RID: 3877 RVA: 0x0003D029 File Offset: 0x0003B229
		public string ToString(string format)
		{
			return Number.FormatSingle(this, format, NumberFormatInfo.CurrentInfo);
		}

		/// <summary>Преобразует числовое значение данного экземпляра в эквивалентное ему строковое представление с использованием указанного формата и сведений об особенностях форматирования для данного языка и региональных параметров.</summary>
		/// <param name="format">Строка числового формата.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление значения данного экземпляра, определяемое параметрами <paramref name="format" /> и <paramref name="provider" />.</returns>
		// Token: 0x06000F26 RID: 3878 RVA: 0x0003D038 File Offset: 0x0003B238
		[SecuritySafeCritical]
		public string ToString(string format, IFormatProvider provider)
		{
			return Number.FormatSingle(this, format, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x0003D048 File Offset: 0x0003B248
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider provider = null)
		{
			return Number.TryFormatSingle(this, format, NumberFormatInfo.GetInstance(provider), destination, out charsWritten);
		}

		/// <summary>Преобразует строковое представление числа в эквивалентное ему число с плавающей запятой одиночной точности.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число.</param>
		/// <returns>Число с плавающей запятой одиночной точности, эквивалентное числовому значению или символу, указанному в параметре <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> не представляет число в допустимом формате.</exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="s" /> представляет число, которое меньше значения <see cref="F:System.Single.MinValue" /> или больше значения <see cref="F:System.Single.MaxValue" />.</exception>
		// Token: 0x06000F28 RID: 3880 RVA: 0x0003D05B File Offset: 0x0003B25B
		public static float Parse(string s)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Number.ParseSingle(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, NumberFormatInfo.CurrentInfo);
		}

		/// <summary>Преобразует строковое представление числа в указанном стиле в эквивалентное ему число с плавающей запятой одиночной точности.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число.</param>
		/// <param name="style">Побитовое сочетание значений перечисления, обозначающих элементы стиля, которые могут быть представлены в параметре <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.NumberStyles.Float" /> в сочетании со значением <see cref="F:System.Globalization.NumberStyles.AllowThousands" />.</param>
		/// <returns>Число с плавающей запятой одиночной точности, эквивалентное числовому значению или символу, указанному в параметре <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> не является числом в допустимом формате.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="s" /> представляет число, которое меньше <see cref="F:System.Single.MinValue" /> или больше <see cref="F:System.Single.MaxValue" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		/// -или- 
		///  <paramref name="style" /> включает значение <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" />.</exception>
		// Token: 0x06000F29 RID: 3881 RVA: 0x0003D07C File Offset: 0x0003B27C
		public static float Parse(string s, NumberStyles style)
		{
			NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Number.ParseSingle(s, style, NumberFormatInfo.CurrentInfo);
		}

		/// <summary>Преобразует строковое представление числа, записанное в формате, соответствующем определенному языку и региональным параметрам, в эквивалентное ему число с плавающей запятой одиночной точности.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число.</param>
		/// <param name="provider">Объект, который предоставляет сведения о форматировании параметра <paramref name="s" /> в зависимости от языка и региональных параметров.</param>
		/// <returns>Число с плавающей запятой одиночной точности, эквивалентное числовому значению или символу, указанному в параметре <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> не представляет число в допустимом формате.</exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="s" /> представляет число, которое меньше значения <see cref="F:System.Single.MinValue" /> или больше значения <see cref="F:System.Single.MaxValue" />.</exception>
		// Token: 0x06000F2A RID: 3882 RVA: 0x0003D09F File Offset: 0x0003B29F
		public static float Parse(string s, IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Number.ParseSingle(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, NumberFormatInfo.GetInstance(provider));
		}

		/// <summary>Преобразует строковое представление числа в указанном стиле и с использованием формата, соответствующего данному языку и региональным параметрам, в эквивалентное ему число с плавающей запятой одиночной точности.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число.</param>
		/// <param name="style">Побитовое сочетание значений перечисления, обозначающих элементы стиля, которые могут быть представлены в параметре <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.NumberStyles.Float" /> в сочетании со значением <see cref="F:System.Globalization.NumberStyles.AllowThousands" />.</param>
		/// <param name="provider">Объект, который предоставляет сведения о форматировании параметра <paramref name="s" /> в зависимости от языка и региональных параметров.</param>
		/// <returns>Число с плавающей запятой одиночной точности, эквивалентное числовому значению или символу, указанному в параметре <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="s" /> не представляет числовое значение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		/// -или- 
		///  <paramref name="style" /> является значением <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" />.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="s" /> представляет число меньше <see cref="F:System.Single.MinValue" /> или больше <see cref="F:System.Single.MaxValue" />.</exception>
		// Token: 0x06000F2B RID: 3883 RVA: 0x0003D0C1 File Offset: 0x0003B2C1
		public static float Parse(string s, NumberStyles style, IFormatProvider provider)
		{
			NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Number.ParseSingle(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x0003D0E5 File Offset: 0x0003B2E5
		public static float Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
			return Number.ParseSingle(s, style, NumberFormatInfo.GetInstance(provider));
		}

		/// <summary>Преобразует строковое представление числа в эквивалентное ему число с плавающей запятой одиночной точности. Возвращает значение, указывающее, успешно ли выполнено преобразование.</summary>
		/// <param name="s">Строка, представляющая преобразуемое число.</param>
		/// <param name="result">Когда этот метод возвращает значение, оно содержит эквивалент числового значения или символа, содержащегося в параметре <paramref name="s" />, представленный в виде числа с плавающей запятой одиночной точности, если преобразование прошло успешно, или нуль, если произошел сбой преобразования. Преобразование завершается сбоем, если значение параметра <paramref name="s" /> равно <see langword="null" /> или <see cref="F:System.String.Empty" />, не является числом допустимого формата или представляет число меньше <see cref="F:System.Single.MinValue" /> или больше <see cref="F:System.Single.MaxValue" />. Этот параметр передается неинициализированным; любое значение, первоначально предоставленное в объекте <paramref name="result" />, будет перезаписано.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="s" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000F2D RID: 3885 RVA: 0x0003D0FA File Offset: 0x0003B2FA
		public static bool TryParse(string s, out float result)
		{
			if (s == null)
			{
				result = 0f;
				return false;
			}
			return float.TryParse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, NumberFormatInfo.CurrentInfo, out result);
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x0003D11E File Offset: 0x0003B31E
		public static bool TryParse(ReadOnlySpan<char> s, out float result)
		{
			return float.TryParse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, NumberFormatInfo.CurrentInfo, out result);
		}

		/// <summary>Преобразует строковое представление числа в указанном стиле и с использованием формата, соответствующего данному языку и региональным параметрам, в эквивалентное ему число с плавающей запятой одиночной точности. Возвращает значение, указывающее, успешно ли выполнено преобразование.</summary>
		/// <param name="s">Строка, представляющая преобразуемое число.</param>
		/// <param name="style">Побитовая комбинация значений перечисления, которая показывает разрешенный формат параметра <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.NumberStyles.Float" /> в сочетании со значением <see cref="F:System.Globalization.NumberStyles.AllowThousands" />.</param>
		/// <param name="provider">Объект, который предоставляет сведения о форматировании параметра <paramref name="s" /> в зависимости от языка и региональных параметров.</param>
		/// <param name="result">Когда этот метод возвращает значение, оно содержит эквивалент числового значения или символа, содержащегося в параметре <paramref name="s" />, представленный в виде числа с плавающей запятой одиночной точности, если преобразование прошло успешно, или нуль, если произошел сбой преобразования. Преобразование завершается неудачно, если параметр <paramref name="s" /> имеет значение <see langword="null" /> или <see cref="F:System.String.Empty" />, не является значением в формате, совместимом с параметром <paramref name="style" />, представляет число меньше <see cref="F:System.Single.MinValue" /> или больше <see cref="F:System.Single.MaxValue" />, либо если <paramref name="style" /> не является допустимой комбинацией перечисленных констант <see cref="T:System.Globalization.NumberStyles" />. Этот параметр передается неинициализированным; любое значение, первоначально предоставленное в объекте <paramref name="result" />, будет перезаписано.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="s" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		///
		/// или - 
		/// <paramref name="style" /> является значением <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" />.</exception>
		// Token: 0x06000F2F RID: 3887 RVA: 0x0003D131 File Offset: 0x0003B331
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out float result)
		{
			NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
			if (s == null)
			{
				result = 0f;
				return false;
			}
			return float.TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x0003D158 File Offset: 0x0003B358
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out float result)
		{
			NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
			return float.TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x0003D170 File Offset: 0x0003B370
		private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out float result)
		{
			if (!Number.TryParseSingle(s, style, info, out result))
			{
				ReadOnlySpan<char> span = s.Trim();
				if (span.EqualsOrdinal(info.PositiveInfinitySymbol))
				{
					result = float.PositiveInfinity;
				}
				else if (span.EqualsOrdinal(info.NegativeInfinitySymbol))
				{
					result = float.NegativeInfinity;
				}
				else
				{
					if (!span.EqualsOrdinal(info.NaNSymbol))
					{
						return false;
					}
					result = float.NaN;
				}
			}
			return true;
		}

		/// <summary>Возвращает <see cref="T:System.TypeCode" /> для типа значения <see cref="T:System.Single" />.</summary>
		/// <returns>Константа перечислимого типа, <see cref="F:System.TypeCode.Single" />.</returns>
		// Token: 0x06000F32 RID: 3890 RVA: 0x0003D1E6 File Offset: 0x0003B3E6
		public TypeCode GetTypeCode()
		{
			return TypeCode.Single;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>
		///   <see langword="true" />, если значение текущего экземпляра не равно нулю; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000F33 RID: 3891 RVA: 0x0003D1EA File Offset: 0x0003B3EA
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this);
		}

		/// <summary>Данное преобразование не поддерживается. При попытке использовать этот метод выбрасывается исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x06000F34 RID: 3892 RVA: 0x0003D1F3 File Offset: 0x0003B3F3
		char IConvertible.ToChar(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "Single", "Char"));
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToSByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.SByte" />.</returns>
		// Token: 0x06000F35 RID: 3893 RVA: 0x0003D20E File Offset: 0x0003B40E
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Byte" />.</returns>
		// Token: 0x06000F36 RID: 3894 RVA: 0x0003D217 File Offset: 0x0003B417
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Int16" />.</returns>
		// Token: 0x06000F37 RID: 3895 RVA: 0x0003D220 File Offset: 0x0003B420
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.UInt16" />.</returns>
		// Token: 0x06000F38 RID: 3896 RVA: 0x0003D229 File Offset: 0x0003B429
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Int32" />.</returns>
		// Token: 0x06000F39 RID: 3897 RVA: 0x0003D232 File Offset: 0x0003B432
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.UInt32" />.</returns>
		// Token: 0x06000F3A RID: 3898 RVA: 0x0003D23B File Offset: 0x0003B43B
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Int64" />.</returns>
		// Token: 0x06000F3B RID: 3899 RVA: 0x0003D244 File Offset: 0x0003B444
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.UInt64" />.</returns>
		// Token: 0x06000F3C RID: 3900 RVA: 0x0003D24D File Offset: 0x0003B44D
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToSingle(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, не измененное.</returns>
		// Token: 0x06000F3D RID: 3901 RVA: 0x0003D256 File Offset: 0x0003B456
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return this;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToDouble(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Double" />.</returns>
		// Token: 0x06000F3E RID: 3902 RVA: 0x0003D25A File Offset: 0x0003B45A
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToDecimal(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Decimal" />.</returns>
		// Token: 0x06000F3F RID: 3903 RVA: 0x0003D263 File Offset: 0x0003B463
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this);
		}

		/// <summary>Данное преобразование не поддерживается. При попытке использовать этот метод выбрасывается исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x06000F40 RID: 3904 RVA: 0x0003D26C File Offset: 0x0003B46C
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "Single", "DateTime"));
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)" />.</summary>
		/// <param name="type">Тип, к которому необходимо привести это значение <see cref="T:System.Single" />.</param>
		/// <param name="provider">Объект, предоставляющий сведения о формате возвращаемого значения.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <paramref name="type" />.</returns>
		// Token: 0x06000F41 RID: 3905 RVA: 0x0003D287 File Offset: 0x0003B487
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x040012DB RID: 4827
		private readonly float m_value;

		/// <summary>Представляет минимально допустимое значение типа <see cref="T:System.Single" />. Это поле является константой.</summary>
		// Token: 0x040012DC RID: 4828
		public const float MinValue = -3.4028235E+38f;

		/// <summary>Представляет наименьшее положительное значение <see cref="T:System.Single" /> больше нуля. Это поле является константой.</summary>
		// Token: 0x040012DD RID: 4829
		public const float Epsilon = 1E-45f;

		/// <summary>Представляет наибольшее возможное значение типа <see cref="T:System.Single" />. Это поле является константой.</summary>
		// Token: 0x040012DE RID: 4830
		public const float MaxValue = 3.4028235E+38f;

		/// <summary>Представляет плюс бесконечность. Это поле является константой.</summary>
		// Token: 0x040012DF RID: 4831
		public const float PositiveInfinity = float.PositiveInfinity;

		/// <summary>Представляет минус бесконечность. Это поле является константой.</summary>
		// Token: 0x040012E0 RID: 4832
		public const float NegativeInfinity = float.NegativeInfinity;

		/// <summary>Представляет нечисловое значение (<see langword="NaN" />). Это поле является константой.</summary>
		// Token: 0x040012E1 RID: 4833
		public const float NaN = float.NaN;

		// Token: 0x040012E2 RID: 4834
		internal const float NegativeZero = --0f;
	}
}
