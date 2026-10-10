using System;
using System.Globalization;
using System.Runtime.Versioning;
using System.Security;

namespace System
{
	/// <summary>Представляет 16-разрядное целое число со знаком.</summary>
	// Token: 0x02000148 RID: 328
	[Serializable]
	public readonly struct Int16 : IComparable, IConvertible, IFormattable, IComparable<short>, IEquatable<short>, ISpanFormattable
	{
		/// <summary>Сравнивает данный экземпляр с указанным объектом и возвращает целое число, которое показывает, является ли значение данного экземпляра меньше, больше или равно значению объекта.</summary>
		/// <param name="value">Объект для сравнения или значение <see langword="null" />.</param>
		/// <returns>Знаковое число, представляющее относительные значения этого экземпляра и параметра <paramref name="value" />.  
		///   Возвращаемое значение 
		///   Описание: 
		///   Меньше нуля 
		///   Этот экземпляр меньше параметра <paramref name="value" />.  
		///
		///   Нуль 
		///   Этот экземпляр и параметр <paramref name="value" /> равны.  
		///
		///   Больше нуля 
		///   Этот экземпляр больше параметра <paramref name="value" />.  
		///
		/// - или - 
		///  Свойство <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="value" /> не является классом <see cref="T:System.Int16" />.</exception>
		// Token: 0x06000C1E RID: 3102 RVA: 0x00031F8F File Offset: 0x0003018F
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (value is short)
			{
				return (int)(this - (short)value);
			}
			throw new ArgumentException("Object must be of type Int16.");
		}

		/// <summary>Сравнивает данный экземпляр с указанным 16-битовым знаковым целым числом и возвращает целое число, которое показывает, является ли значение данного экземпляра меньше, больше или равным значению заданного 16-битового знакового целого числа.</summary>
		/// <param name="value">Целое число для сравнения.</param>
		/// <returns>Знаковое число, представляющее относительные значения этого экземпляра и параметра <paramref name="value" />.  
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
		// Token: 0x06000C1F RID: 3103 RVA: 0x00031FB2 File Offset: 0x000301B2
		public int CompareTo(short value)
		{
			return (int)(this - value);
		}

		/// <summary>Возвращает значение, показывающее, равен ли данный экземпляр заданному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="obj" /> является экземпляром типа <see cref="T:System.Int16" /> и равен значению данного экземпляра; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000C20 RID: 3104 RVA: 0x00031FB8 File Offset: 0x000301B8
		public override bool Equals(object obj)
		{
			return obj is short && this == (short)obj;
		}

		/// <summary>Возвращает значение, указывающее, равен ли этот экземпляр заданному значению типа <see cref="T:System.Int16" />.</summary>
		/// <param name="obj">Значение типа <see cref="T:System.Int16" /> для сравнения с данным экземпляром.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="obj" /> совпадает со значением данного экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000C21 RID: 3105 RVA: 0x00031FCE File Offset: 0x000301CE
		[NonVersionable]
		public bool Equals(short obj)
		{
			return this == obj;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06000C22 RID: 3106 RVA: 0x00031FD5 File Offset: 0x000301D5
		public override int GetHashCode()
		{
			return (int)((ushort)this) | (int)this << 16;
		}

		/// <summary>Преобразовывает числовое значение данного экземпляра в эквивалентное ему строковое представление.</summary>
		/// <returns>Строковое представление значения этого экземпляра, содержащее знак минус, если значение отрицательное, и последовательность цифр в диапазоне от 0 до 9 без нулей в начале.</returns>
		// Token: 0x06000C23 RID: 3107 RVA: 0x00031FE0 File Offset: 0x000301E0
		public override string ToString()
		{
			return Number.FormatInt32((int)this, null, null);
		}

		/// <summary>Преобразует числовое значение данного экземпляра в эквивалентное ему строковое представление с использованием указанных сведений об особенностях форматирования для данного языка и региональных параметров.</summary>
		/// <param name="provider">Объект <see cref="T:System.IFormatProvider" />, предоставляющий сведения о форматировании, связанные с определенным языком и региональными параметрами.</param>
		/// <returns>Строковое представление значения данного экземпляра, определяемое параметром <paramref name="provider" />.</returns>
		// Token: 0x06000C24 RID: 3108 RVA: 0x00031FF0 File Offset: 0x000301F0
		[SecuritySafeCritical]
		public string ToString(IFormatProvider provider)
		{
			return Number.FormatInt32((int)this, null, provider);
		}

		/// <summary>Преобразует числовое значение данного экземпляра в эквивалентное строковое представление с использованием указанного формата.</summary>
		/// <param name="format">Строка числового формата.</param>
		/// <returns>Строковое представление значения данного экземпляра, определяемое параметром <paramref name="format" />.</returns>
		// Token: 0x06000C25 RID: 3109 RVA: 0x00032000 File Offset: 0x00030200
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		/// <summary>Преобразовывает числовое значение данного экземпляра в эквивалентное ему строковое представление с использованием указанного формата и сведений об особенностях форматирования для данного языка и региональных параметров.</summary>
		/// <param name="format">Строка числового формата.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление значения данного экземпляра, определяемое параметрами <paramref name="format" /> и <paramref name="provider" />.</returns>
		// Token: 0x06000C26 RID: 3110 RVA: 0x0003200C File Offset: 0x0003020C
		public string ToString(string format, IFormatProvider provider)
		{
			if (this < 0 && format != null && format.Length > 0 && (format[0] == 'X' || format[0] == 'x'))
			{
				return Number.FormatUInt32((uint)this & 65535U, format, provider);
			}
			return Number.FormatInt32((int)this, format, provider);
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x00032064 File Offset: 0x00030264
		public unsafe bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider provider = null)
		{
			if (this < 0 && format.Length > 0 && (*format[0] == 88 || *format[0] == 120))
			{
				return Number.TryFormatUInt32((uint)this & 65535U, format, provider, destination, out charsWritten);
			}
			return Number.TryFormatInt32((int)this, format, provider, destination, out charsWritten);
		}

		/// <summary>Преобразует строковое представление числа в эквивалентное ему 16-битовое целое число со знаком.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число.</param>
		/// <returns>16-разрядное целое число со знаком, эквивалентное числу, содержащемуся в параметре <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> имеет неправильный формат.</exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="s" /> представляет число, которое меньше значения <see cref="F:System.Int16.MinValue" /> или больше значения <see cref="F:System.Int16.MaxValue" />.</exception>
		// Token: 0x06000C28 RID: 3112 RVA: 0x000320B9 File Offset: 0x000302B9
		public static short Parse(string s)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return short.Parse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo);
		}

		/// <summary>Преобразует строковое представление числа в указанном формате в эквивалентное ему 16-битовое целое число со знаком.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число.</param>
		/// <param name="style">Побитовое сочетание значений перечисления, обозначающих элементы стиля, которые могут быть представлены в параметре <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <returns>16-разрядное целое число со знаком, эквивалентное числу, заданному в параметре <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		///
		/// или - 
		/// <paramref name="style" /> не является сочетанием значений <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> и <see cref="F:System.Globalization.NumberStyles.HexNumber" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> не представлен в формате, совместимом с <paramref name="style" />.</exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="s" /> представляет число, которое меньше значения <see cref="F:System.Int16.MinValue" /> или больше значения <see cref="F:System.Int16.MaxValue" />.  
		///
		/// или - 
		/// <paramref name="s" /> содержит ненулевые дробные цифры.</exception>
		// Token: 0x06000C29 RID: 3113 RVA: 0x000320D6 File Offset: 0x000302D6
		public static short Parse(string s, NumberStyles style)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return short.Parse(s, style, NumberFormatInfo.CurrentInfo);
		}

		/// <summary>Преобразует строковое представление числа в указанном формате, соответствующем языку и региональным параметрам, в эквивалентное ему 16-битовое целое число со знаком.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число.</param>
		/// <param name="provider">Интерфейс <see cref="T:System.IFormatProvider" /> предоставляет сведения о форматировании параметра <paramref name="s" /> для соответствующего языка и региональных параметров.</param>
		/// <returns>16-разрядное целое число со знаком, эквивалентное числу, заданному в параметре <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> имеет неправильный формат.</exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="s" /> представляет число, которое меньше значения <see cref="F:System.Int16.MinValue" /> или больше значения <see cref="F:System.Int16.MaxValue" />.</exception>
		// Token: 0x06000C2A RID: 3114 RVA: 0x000320F9 File Offset: 0x000302F9
		public static short Parse(string s, IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return short.Parse(s, NumberStyles.Integer, NumberFormatInfo.GetInstance(provider));
		}

		/// <summary>Преобразует строковое представление числа в формате, соответствующем языку и региональным параметрам, в эквивалентное ему 16-битовое целое число со знаком.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число.</param>
		/// <param name="style">Побитовое сочетание значений перечисления, обозначающих элементы стиля, которые могут быть представлены в параметре <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <param name="provider">Интерфейс <see cref="T:System.IFormatProvider" /> предоставляет сведения о форматировании параметра <paramref name="s" /> для соответствующего языка и региональных параметров.</param>
		/// <returns>16-разрядное целое число со знаком, эквивалентное числу, заданному в параметре <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		///
		/// или - 
		/// <paramref name="style" /> не является сочетанием значений <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> и <see cref="F:System.Globalization.NumberStyles.HexNumber" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> не представлен в формате, совместимом с <paramref name="style" />.</exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="s" /> представляет число, которое меньше значения <see cref="F:System.Int16.MinValue" /> или больше значения <see cref="F:System.Int16.MaxValue" />.  
		///
		/// или - 
		/// <paramref name="s" /> содержит ненулевые дробные цифры.</exception>
		// Token: 0x06000C2B RID: 3115 RVA: 0x00032117 File Offset: 0x00030317
		public static short Parse(string s, NumberStyles style, IFormatProvider provider)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return short.Parse(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x0003213B File Offset: 0x0003033B
		public static short Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return short.Parse(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x00032150 File Offset: 0x00030350
		private static short Parse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info)
		{
			int num = 0;
			try
			{
				num = Number.ParseInt32(s, style, info);
			}
			catch (OverflowException innerException)
			{
				throw new OverflowException("Value was either too large or too small for an Int16.", innerException);
			}
			if ((style & NumberStyles.AllowHexSpecifier) != NumberStyles.None)
			{
				if (num < 0 || num > 65535)
				{
					throw new OverflowException("Value was either too large or too small for an Int16.");
				}
				return (short)num;
			}
			else
			{
				if (num < -32768 || num > 32767)
				{
					throw new OverflowException("Value was either too large or too small for an Int16.");
				}
				return (short)num;
			}
		}

		/// <summary>Преобразует строковое представление числа в эквивалентное ему 16-битовое целое число со знаком. Возвращает значение, указывающее, успешно ли выполнено преобразование.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число.</param>
		/// <param name="result">При возвращении этим методом содержит 16-битное целочисленное значение со знаком, эквивалентное числу, содержащемуся в параметре <paramref name="s" />, если преобразование выполнено успешно, или нуль, если оно завершилось неудачей. Преобразование завершается сбоем, если параметр <paramref name="s" /> равен <see langword="null" /> или <see cref="F:System.String.Empty" />, не находится в правильном формате или представляет число меньше <see cref="F:System.Int16.MinValue" /> или больше <see cref="F:System.Int16.MaxValue" />. Этот параметр передается неинициализированным; любое значение, первоначально предоставленное в объекте <paramref name="result" />, будет перезаписано.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="s" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000C2E RID: 3118 RVA: 0x000321C8 File Offset: 0x000303C8
		public static bool TryParse(string s, out short result)
		{
			if (s == null)
			{
				result = 0;
				return false;
			}
			return short.TryParse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x000321E4 File Offset: 0x000303E4
		public static bool TryParse(ReadOnlySpan<char> s, out short result)
		{
			return short.TryParse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
		}

		/// <summary>Преобразует строковое представление числа в формате, соответствующем языку и региональным параметрам, в эквивалентное ему 16-битовое целое число со знаком. Возвращает значение, указывающее, успешно ли выполнено преобразование.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число. Строка интерпретируется с использованием стиля, указанного в <paramref name="style" />.</param>
		/// <param name="style">Побитовое сочетание значений перечисления, обозначающих элементы стиля, которые могут быть представлены в параметре <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <param name="provider">Объект, который предоставляет сведения о форматировании параметра <paramref name="s" /> в зависимости от языка и региональных параметров.</param>
		/// <param name="result">При возвращении этим методом содержит 16-битное целочисленное значение со знаком, эквивалентное числу, содержащемуся в параметре <paramref name="s" />, если преобразование выполнено успешно, или нуль, если оно завершилось неудачей. Преобразование завершается сбоем, если параметр <paramref name="s" /> равен <see langword="null" /> или <see cref="F:System.String.Empty" />, не находится в формате, совместимом с <paramref name="style" /> или представляет собой число меньше <see cref="F:System.Int16.MinValue" /> или больше <see cref="F:System.Int16.MaxValue" />. Этот параметр передается неинициализированным; любое значение, первоначально предоставленное в объекте <paramref name="result" />, будет перезаписано.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="s" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		///
		/// или - 
		/// <paramref name="style" /> не является сочетанием значений <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> и <see cref="F:System.Globalization.NumberStyles.HexNumber" />.</exception>
		// Token: 0x06000C30 RID: 3120 RVA: 0x000321F3 File Offset: 0x000303F3
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out short result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				result = 0;
				return false;
			}
			return short.TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x00032216 File Offset: 0x00030416
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out short result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return short.TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x0003222C File Offset: 0x0003042C
		private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out short result)
		{
			result = 0;
			int num;
			if (!Number.TryParseInt32(s, style, info, out num))
			{
				return false;
			}
			if ((style & NumberStyles.AllowHexSpecifier) != NumberStyles.None)
			{
				if (num < 0 || num > 65535)
				{
					return false;
				}
				result = (short)num;
				return true;
			}
			else
			{
				if (num < -32768 || num > 32767)
				{
					return false;
				}
				result = (short)num;
				return true;
			}
		}

		/// <summary>Возвращает <see cref="T:System.TypeCode" /> для типа значения <see cref="T:System.Int16" />.</summary>
		/// <returns>Константа перечислимого типа, <see cref="F:System.TypeCode.Int16" />.</returns>
		// Token: 0x06000C33 RID: 3123 RVA: 0x0003227E File Offset: 0x0003047E
		public TypeCode GetTypeCode()
		{
			return TypeCode.Int16;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>
		///   <see langword="true" />, если значение текущего экземпляра не равно нулю; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000C34 RID: 3124 RVA: 0x00032281 File Offset: 0x00030481
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToChar(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Char" />.</returns>
		// Token: 0x06000C35 RID: 3125 RVA: 0x0003228A File Offset: 0x0003048A
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToSByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.SByte" />.</returns>
		// Token: 0x06000C36 RID: 3126 RVA: 0x00032293 File Offset: 0x00030493
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Byte" />.</returns>
		// Token: 0x06000C37 RID: 3127 RVA: 0x0003229C File Offset: 0x0003049C
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, не измененное.</returns>
		// Token: 0x06000C38 RID: 3128 RVA: 0x000322A5 File Offset: 0x000304A5
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return this;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, не измененное.</returns>
		// Token: 0x06000C39 RID: 3129 RVA: 0x000322A9 File Offset: 0x000304A9
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Int32" />.</returns>
		// Token: 0x06000C3A RID: 3130 RVA: 0x000322B2 File Offset: 0x000304B2
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.UInt32" />.</returns>
		// Token: 0x06000C3B RID: 3131 RVA: 0x000322BB File Offset: 0x000304BB
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Int64" />.</returns>
		// Token: 0x06000C3C RID: 3132 RVA: 0x000322C4 File Offset: 0x000304C4
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.UInt64" />.</returns>
		// Token: 0x06000C3D RID: 3133 RVA: 0x000322CD File Offset: 0x000304CD
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToSingle(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Single" />.</returns>
		// Token: 0x06000C3E RID: 3134 RVA: 0x000322D6 File Offset: 0x000304D6
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToDouble(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Double" />.</returns>
		// Token: 0x06000C3F RID: 3135 RVA: 0x000322DF File Offset: 0x000304DF
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToDecimal(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Decimal" />.</returns>
		// Token: 0x06000C40 RID: 3136 RVA: 0x000322E8 File Offset: 0x000304E8
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this);
		}

		/// <summary>Данное преобразование не поддерживается. При попытке использовать этот метод выбрасывается исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x06000C41 RID: 3137 RVA: 0x000322F1 File Offset: 0x000304F1
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "Int16", "DateTime"));
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)" />.</summary>
		/// <param name="type">Тип, к которому необходимо привести это значение <see cref="T:System.Int16" />.</param>
		/// <param name="provider">Реализация интерфейса <see cref="T:System.IFormatProvider" />, предоставляющая сведения о формате возвращаемого значения.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <paramref name="type" />.</returns>
		// Token: 0x06000C42 RID: 3138 RVA: 0x0003230C File Offset: 0x0003050C
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x04001252 RID: 4690
		private readonly short m_value;

		/// <summary>Представляет наибольшее возможное значение типа <see cref="T:System.Int16" />. Это поле является константой.</summary>
		// Token: 0x04001253 RID: 4691
		public const short MaxValue = 32767;

		/// <summary>Представляет минимально допустимое значение типа <see cref="T:System.Int16" />. Это поле является константой.</summary>
		// Token: 0x04001254 RID: 4692
		public const short MinValue = -32768;
	}
}
