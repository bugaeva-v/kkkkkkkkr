using System;
using System.Globalization;
using System.Runtime.Versioning;
using System.Security;

namespace System
{
	/// <summary>Представляет 8-разрядное целое число со знаком.</summary>
	// Token: 0x0200017A RID: 378
	[CLSCompliant(false)]
	[Serializable]
	public readonly struct SByte : IComparable, IConvertible, IFormattable, IComparable<sbyte>, IEquatable<sbyte>, ISpanFormattable
	{
		/// <summary>Сравнивает этот экземпляр с заданным объектом и возвращает значение, указывающее, как соотносятся значения этих объектов.</summary>
		/// <param name="obj">Объект для сравнения или значение <see langword="null" />.</param>
		/// <returns>Знаковое число, представляющее относительные значения этого экземпляра и параметра <paramref name="obj" />.  
		///   Возвращаемое значение 
		///   Описание: 
		///   Меньше нуля 
		///   Этот экземпляр меньше параметра <paramref name="obj" />.  
		///
		///   Нуль 
		///   Этот экземпляр и параметр <paramref name="obj" /> равны.  
		///
		///   Больше нуля 
		///   Этот экземпляр больше параметра <paramref name="obj" />.  
		///
		/// - или - 
		///  Свойство <paramref name="obj" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="obj" /> не является классом <see cref="T:System.SByte" />.</exception>
		// Token: 0x06000EE9 RID: 3817 RVA: 0x0003CAA2 File Offset: 0x0003ACA2
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				return 1;
			}
			if (!(obj is sbyte))
			{
				throw new ArgumentException("Object must be of type SByte.");
			}
			return (int)(this - (sbyte)obj);
		}

		/// <summary>Сравнивает данный экземпляр с заданным 8-битовым целым числом со знаком и возвращает значение, указывающее, как соотносятся их значения.</summary>
		/// <param name="value">8-битовое целое число со знаком для сравнения.</param>
		/// <returns>Целое число со знаком, показывающее относительный порядок данного экземпляра и <paramref name="value" />.  
		///   Возвращаемое значение 
		///   Описание: 
		///   Меньше нуля 
		///   Этот экземпляр меньше параметра <paramref name="value" />.  
		///
		///   Нуль 
		///   Этот экземпляр и параметр <paramref name="value" /> равны.  
		///
		///   Больше нуля 
		///   Этот экземпляр больше параметра <paramref name="value" />.</returns>
		// Token: 0x06000EEA RID: 3818 RVA: 0x0003CAC5 File Offset: 0x0003ACC5
		public int CompareTo(sbyte value)
		{
			return (int)(this - value);
		}

		/// <summary>Возвращает значение, показывающее, равен ли данный экземпляр заданному объекту.</summary>
		/// <param name="obj">Объект для сравнения с данным экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="obj" /> является экземпляром типа <see cref="T:System.SByte" /> и равен значению данного экземпляра; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000EEB RID: 3819 RVA: 0x0003CACB File Offset: 0x0003ACCB
		public override bool Equals(object obj)
		{
			return obj is sbyte && this == (sbyte)obj;
		}

		/// <summary>Возвращает значение, указывающее, равен ли этот экземпляр заданному значению типа <see cref="T:System.SByte" />.</summary>
		/// <param name="obj">Значение типа <see cref="T:System.SByte" /> для сравнения с данным экземпляром.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="obj" /> совпадает со значением данного экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000EEC RID: 3820 RVA: 0x0003CAE1 File Offset: 0x0003ACE1
		[NonVersionable]
		public bool Equals(sbyte obj)
		{
			return this == obj;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06000EED RID: 3821 RVA: 0x0003CAE8 File Offset: 0x0003ACE8
		public override int GetHashCode()
		{
			return (int)this ^ (int)this << 8;
		}

		/// <summary>Преобразовывает числовое значение данного экземпляра в эквивалентное ему строковое представление.</summary>
		/// <returns>Строковое представление значения данного экземпляра, состоящее из знака минус, если число отрицательное, и последовательности цифр в диапазоне от 0 до 9 с ненулевой первой цифрой.</returns>
		// Token: 0x06000EEE RID: 3822 RVA: 0x0003CAF1 File Offset: 0x0003ACF1
		public override string ToString()
		{
			return Number.FormatInt32((int)this, null, null);
		}

		/// <summary>Преобразует числовое значение данного экземпляра в эквивалентное ему строковое представление с использованием указанных сведений об особенностях форматирования для данного языка и региональных параметров.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление значения данного экземпляра, определяемое параметром <paramref name="provider" />.</returns>
		// Token: 0x06000EEF RID: 3823 RVA: 0x0003CB01 File Offset: 0x0003AD01
		[SecuritySafeCritical]
		public string ToString(IFormatProvider provider)
		{
			return Number.FormatInt32((int)this, null, provider);
		}

		/// <summary>Преобразует числовое значение данного экземпляра в эквивалентное строковое представление с использованием указанного формата.</summary>
		/// <param name="format">Стандартная или пользовательская строка числового формата.</param>
		/// <returns>Строковое представление значения данного экземпляра, определяемое параметром <paramref name="format" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> недопустим.</exception>
		// Token: 0x06000EF0 RID: 3824 RVA: 0x0003CB11 File Offset: 0x0003AD11
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		/// <summary>Преобразует числовое значение данного экземпляра в эквивалентное ему строковое представление с использованием указанного формата и сведений об особенностях форматирования для данного языка и региональных параметров.</summary>
		/// <param name="format">Стандартная или пользовательская строка числового формата.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление значения данного экземпляра, определяемое параметрами <paramref name="format" /> и <paramref name="provider" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> недопустим.</exception>
		// Token: 0x06000EF1 RID: 3825 RVA: 0x0003CB1C File Offset: 0x0003AD1C
		public string ToString(string format, IFormatProvider provider)
		{
			if (this < 0 && format != null && format.Length > 0 && (format[0] == 'X' || format[0] == 'x'))
			{
				return Number.FormatUInt32((uint)this & 255U, format, provider);
			}
			return Number.FormatInt32((int)this, format, provider);
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x0003CB74 File Offset: 0x0003AD74
		public unsafe bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider provider = null)
		{
			if (this < 0 && format.Length > 0 && (*format[0] == 88 || *format[0] == 120))
			{
				return Number.TryFormatUInt32((uint)this & 255U, format, provider, destination, out charsWritten);
			}
			return Number.TryFormatInt32((int)this, format, provider, destination, out charsWritten);
		}

		/// <summary>Преобразует строковое представление числа в эквивалентное ему 8-битовое целое число со знаком.</summary>
		/// <param name="s">Строка, представляющая преобразуемое число. Данная строка интерпретируется с использованием стиля <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <returns>8-битовое целое число со знаком, эквивалентное числу, содержащемуся в параметре <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> не состоит из необязательного знака, за которым следует последовательность цифр (0–9).</exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="s" /> представляет число, которое меньше значения <see cref="F:System.SByte.MinValue" /> или больше значения <see cref="F:System.SByte.MaxValue" />.</exception>
		// Token: 0x06000EF3 RID: 3827 RVA: 0x0003CBC9 File Offset: 0x0003ADC9
		[CLSCompliant(false)]
		public static sbyte Parse(string s)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return sbyte.Parse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo);
		}

		/// <summary>Преобразует строковое представление числа в указанном формате в эквивалентное ему 8-битовое целое число со знаком.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число. Строка интерпретируется с использованием стиля, указанного в <paramref name="style" />.</param>
		/// <param name="style">Побитовое сочетание значений перечисления, обозначающих элементы стиля, которые могут быть представлены в параметре <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <returns>8-битовое целое число со знаком, эквивалентное числу, указанному в параметре <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> не представлен в формате, совместимом с <paramref name="style" />.</exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="s" /> представляет число, которое меньше значения <see cref="F:System.SByte.MinValue" /> или больше значения <see cref="F:System.SByte.MaxValue" />.  
		///
		/// или - 
		/// <paramref name="s" /> содержит ненулевые дробные разряды.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		///
		/// или - 
		/// <paramref name="style" /> не является сочетанием значений <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> и <see cref="F:System.Globalization.NumberStyles.HexNumber" />.</exception>
		// Token: 0x06000EF4 RID: 3828 RVA: 0x0003CBE6 File Offset: 0x0003ADE6
		[CLSCompliant(false)]
		public static sbyte Parse(string s, NumberStyles style)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return sbyte.Parse(s, style, NumberFormatInfo.CurrentInfo);
		}

		/// <summary>Преобразует строковое представление числа в указанном формате, соответствующем языку и региональным параметрам, в эквивалентное ему 8-битовое целое число со знаком.</summary>
		/// <param name="s">Строка, представляющая преобразуемое число. Данная строка интерпретируется с использованием стиля <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <param name="provider">Объект, который предоставляет сведения о форматировании параметра <paramref name="s" /> в зависимости от языка и региональных параметров. Если значение параметра <paramref name="provider" /> равно <see langword="null" />, используются текущий язык и региональные параметры потока.</param>
		/// <returns>8-битовое целое число со знаком, эквивалентное числу, указанному в параметре <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> имеет неправильный формат.</exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="s" /> представляет число, которое меньше значения <see cref="F:System.SByte.MinValue" /> или больше значения <see cref="F:System.SByte.MaxValue" />.</exception>
		// Token: 0x06000EF5 RID: 3829 RVA: 0x0003CC09 File Offset: 0x0003AE09
		[CLSCompliant(false)]
		public static sbyte Parse(string s, IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return sbyte.Parse(s, NumberStyles.Integer, NumberFormatInfo.GetInstance(provider));
		}

		/// <summary>Преобразует строковое представление числа в формате, соответствующем определенному стилю, языку и региональным параметрам, в эквивалентное ему 8-битовое целое число со знаком.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число. Строка интерпретируется с использованием стиля, указанного в <paramref name="style" />.</param>
		/// <param name="style">Побитовое сочетание значений перечисления, обозначающих элементы стиля, которые могут быть представлены в параметре <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <param name="provider">Объект, который предоставляет сведения о форматировании параметра <paramref name="s" /> в зависимости от языка и региональных параметров. Если значение параметра <paramref name="provider" /> равно <see langword="null" />, используются текущий язык и региональные параметры потока.</param>
		/// <returns>8-битовое значение типа byte со знаком, эквивалентное числу, заданному в параметре <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		///
		/// или - 
		/// <paramref name="style" /> не является сочетанием <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> и <see cref="F:System.Globalization.NumberStyles.HexNumber" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> не представлен в формате, совместимом с <paramref name="style" />.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="s" /> представляет число, которое меньше <see cref="F:System.SByte.MinValue" /> или больше <see cref="F:System.SByte.MaxValue" />.  
		///
		/// или - 
		/// <paramref name="s" /> содержит ненулевые дробные разряды.</exception>
		// Token: 0x06000EF6 RID: 3830 RVA: 0x0003CC27 File Offset: 0x0003AE27
		[CLSCompliant(false)]
		public static sbyte Parse(string s, NumberStyles style, IFormatProvider provider)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return sbyte.Parse(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x0003CC4B File Offset: 0x0003AE4B
		[CLSCompliant(false)]
		public static sbyte Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return sbyte.Parse(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x0003CC60 File Offset: 0x0003AE60
		private static sbyte Parse(string s, NumberStyles style, NumberFormatInfo info)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return sbyte.Parse(s, style, info);
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x0003CC7C File Offset: 0x0003AE7C
		private static sbyte Parse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info)
		{
			int num = 0;
			try
			{
				num = Number.ParseInt32(s, style, info);
			}
			catch (OverflowException innerException)
			{
				throw new OverflowException("Value was either too large or too small for a signed byte.", innerException);
			}
			if ((style & NumberStyles.AllowHexSpecifier) != NumberStyles.None)
			{
				if (num < 0 || num > 255)
				{
					throw new OverflowException("Value was either too large or too small for a signed byte.");
				}
				return (sbyte)num;
			}
			else
			{
				if (num < -128 || num > 127)
				{
					throw new OverflowException("Value was either too large or too small for a signed byte.");
				}
				return (sbyte)num;
			}
		}

		/// <summary>Предпринимает попытку преобразования строкового представления числа в его эквивалент типа <see cref="T:System.SByte" /> и возвращает значение, позволяющее определить, успешно ли выполнено преобразование.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число.</param>
		/// <param name="result">По возвращении из этого метода содержит 8-битовое целочисленное значение со знаком, эквивалентное числу, содержащемуся в параметре <paramref name="s" />, если преобразование выполнено успешно, или ноль, если оно завершилось неудачей. Преобразование завершается неудачей, если параметр <paramref name="s" /> равен <see langword="null" />, или <see cref="F:System.String.Empty" /> не в правильном формате или представляет число меньше <see cref="F:System.SByte.MinValue" /> или больше <see cref="F:System.SByte.MaxValue" />. Этот параметр передается неинициализированным; любое значение, первоначально предоставленное в объекте <paramref name="result" />, будет перезаписано.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="s" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000EFA RID: 3834 RVA: 0x0003CCF0 File Offset: 0x0003AEF0
		[CLSCompliant(false)]
		public static bool TryParse(string s, out sbyte result)
		{
			if (s == null)
			{
				result = 0;
				return false;
			}
			return sbyte.TryParse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x0003CD0C File Offset: 0x0003AF0C
		[CLSCompliant(false)]
		public static bool TryParse(ReadOnlySpan<char> s, out sbyte result)
		{
			return sbyte.TryParse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
		}

		/// <summary>Предпринимает попытку преобразования числа в формате, который определяется заданным стилем и языком и региональными параметрами, в эквивалент типа <see cref="T:System.SByte" /> и возвращает значение, определяющее, успешно ли выполнено преобразование.</summary>
		/// <param name="s">Строка, представляющая преобразуемое число.</param>
		/// <param name="style">Побитовая комбинация значений перечисления, которая показывает разрешенный формат параметра <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <param name="provider">Объект, который предоставляет сведения о форматировании параметра <paramref name="s" /> в зависимости от языка и региональных параметров.</param>
		/// <param name="result">При возвращении этим методом содержит 8-битное целочисленное значение со знаком, эквивалентное числу, содержащемуся в параметре <paramref name="s" />, если преобразование выполнено успешно, или нуль, если оно завершилось неудачей. Преобразование завершается сбоем, если параметр <paramref name="s" /> равен <see langword="null" /> или <see cref="F:System.String.Empty" />, не находится в формате, совместимом с <paramref name="style" /> или представляет собой число меньше <see cref="F:System.SByte.MinValue" /> или больше <see cref="F:System.SByte.MaxValue" />. Этот параметр передается неинициализированным; любое значение, первоначально предоставленное в объекте <paramref name="result" />, будет перезаписано.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="s" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		///
		/// или - 
		/// <paramref name="style" /> не является сочетанием значений <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> и <see cref="F:System.Globalization.NumberStyles.HexNumber" />.</exception>
		// Token: 0x06000EFC RID: 3836 RVA: 0x0003CD1B File Offset: 0x0003AF1B
		[CLSCompliant(false)]
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out sbyte result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				result = 0;
				return false;
			}
			return sbyte.TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x0003CD3E File Offset: 0x0003AF3E
		[CLSCompliant(false)]
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out sbyte result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return sbyte.TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x0003CD54 File Offset: 0x0003AF54
		private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out sbyte result)
		{
			result = 0;
			int num;
			if (!Number.TryParseInt32(s, style, info, out num))
			{
				return false;
			}
			if ((style & NumberStyles.AllowHexSpecifier) != NumberStyles.None)
			{
				if (num < 0 || num > 255)
				{
					return false;
				}
				result = (sbyte)num;
				return true;
			}
			else
			{
				if (num < -128 || num > 127)
				{
					return false;
				}
				result = (sbyte)num;
				return true;
			}
		}

		/// <summary>Возвращает <see cref="T:System.TypeCode" /> для типа значения <see cref="T:System.SByte" />.</summary>
		/// <returns>Константа перечислимого типа, <see cref="F:System.TypeCode.SByte" />.</returns>
		// Token: 0x06000EFF RID: 3839 RVA: 0x0003CDA0 File Offset: 0x0003AFA0
		public TypeCode GetTypeCode()
		{
			return TypeCode.SByte;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не используется.</param>
		/// <returns>
		///   <see langword="true" />, если значение текущего экземпляра не равно нулю; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000F00 RID: 3840 RVA: 0x0003CDA3 File Offset: 0x0003AFA3
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToChar(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Char" />.</returns>
		// Token: 0x06000F01 RID: 3841 RVA: 0x0003CDAC File Offset: 0x0003AFAC
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToSByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, не измененное.</returns>
		// Token: 0x06000F02 RID: 3842 RVA: 0x0003CDB5 File Offset: 0x0003AFB5
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return this;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не используется.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Byte" />.</returns>
		// Token: 0x06000F03 RID: 3843 RVA: 0x0003CDB9 File Offset: 0x0003AFB9
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Int16" />.</returns>
		// Token: 0x06000F04 RID: 3844 RVA: 0x0003CDC2 File Offset: 0x0003AFC2
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.UInt16" />.</returns>
		// Token: 0x06000F05 RID: 3845 RVA: 0x0003CDCB File Offset: 0x0003AFCB
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Int32" />.</returns>
		// Token: 0x06000F06 RID: 3846 RVA: 0x0003CDB5 File Offset: 0x0003AFB5
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return (int)this;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.UInt32" />.</returns>
		// Token: 0x06000F07 RID: 3847 RVA: 0x0003CDD4 File Offset: 0x0003AFD4
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Int64" />.</returns>
		// Token: 0x06000F08 RID: 3848 RVA: 0x0003CDDD File Offset: 0x0003AFDD
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.UInt64" />.</returns>
		// Token: 0x06000F09 RID: 3849 RVA: 0x0003CDE6 File Offset: 0x0003AFE6
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToSingle(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Single" />.</returns>
		// Token: 0x06000F0A RID: 3850 RVA: 0x0003CDEF File Offset: 0x0003AFEF
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToDouble(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Double" />.</returns>
		// Token: 0x06000F0B RID: 3851 RVA: 0x0003CDF8 File Offset: 0x0003AFF8
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToDecimal(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не используется.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Decimal" />.</returns>
		// Token: 0x06000F0C RID: 3852 RVA: 0x0003CE01 File Offset: 0x0003B001
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this);
		}

		/// <summary>Данное преобразование не поддерживается. Попытка его выполнения приводит к созданию исключения <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Отсутствует. Данное преобразование не поддерживается.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x06000F0D RID: 3853 RVA: 0x0003CE0A File Offset: 0x0003B00A
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "SByte", "DateTime"));
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)" />.</summary>
		/// <param name="type">Тип <see cref="T:System.Type" />, к которому необходимо привести это значение <see cref="T:System.SByte" />.</param>
		/// <param name="provider">Реализация <see cref="T:System.IFormatProvider" />, предоставляющая сведения о формате возвращаемого значения.</param>
		/// <returns>Значение текущего экземпляра, преобразованное в объект типа <paramref name="type" />.</returns>
		// Token: 0x06000F0E RID: 3854 RVA: 0x0003CE25 File Offset: 0x0003B025
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x040012D8 RID: 4824
		private readonly sbyte m_value;

		/// <summary>Представляет наибольшее возможное значение типа <see cref="T:System.SByte" />. Это поле является константой.</summary>
		// Token: 0x040012D9 RID: 4825
		public const sbyte MaxValue = 127;

		/// <summary>Представляет минимально допустимое значение типа <see cref="T:System.SByte" />. Это поле является константой.</summary>
		// Token: 0x040012DA RID: 4826
		public const sbyte MinValue = -128;
	}
}
