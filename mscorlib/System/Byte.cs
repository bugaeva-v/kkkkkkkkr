using System;
using System.Globalization;
using System.Runtime.Versioning;
using System.Security;

namespace System
{
	/// <summary>Представляет 8-битовое целое число без знака.</summary>
	// Token: 0x02000103 RID: 259
	[Serializable]
	public readonly struct Byte : IComparable, IConvertible, IFormattable, IComparable<byte>, IEquatable<byte>, ISpanFormattable
	{
		/// <summary>Сравнивает этот экземпляр с заданным объектом и возвращает значение, указывающее, как соотносятся значения этих объектов.</summary>
		/// <param name="value">Объект для сравнения или значение <see langword="null" />.</param>
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
		///   Этот экземпляр больше параметра <paramref name="value" />.  
		///
		/// - или - 
		///  Свойство <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> не является объектом <see cref="T:System.Byte" />.</exception>
		// Token: 0x060007B6 RID: 1974 RVA: 0x00022298 File Offset: 0x00020498
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (!(value is byte))
			{
				throw new ArgumentException("Object must be of type Byte.");
			}
			return (int)(this - (byte)value);
		}

		/// <summary>Сравнивает данный экземпляр с заданным 8-битовым целым числом без знака и возвращает значение, указывающее, как соотносятся их значения.</summary>
		/// <param name="value">8-битовое целое число без знака для сравнения.</param>
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
		// Token: 0x060007B7 RID: 1975 RVA: 0x000222BB File Offset: 0x000204BB
		public int CompareTo(byte value)
		{
			return (int)(this - value);
		}

		/// <summary>Возвращает значение, показывающее, равен ли данный экземпляр заданному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром, или значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="obj" /> является экземпляром типа <see cref="T:System.Byte" /> и равен значению данного экземпляра; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060007B8 RID: 1976 RVA: 0x000222C1 File Offset: 0x000204C1
		public override bool Equals(object obj)
		{
			return obj is byte && this == (byte)obj;
		}

		/// <summary>Возвращает значение, позволяющее определить, представляют ли этот экземпляр и заданный объект <see cref="T:System.Byte" /> одно и то же значение.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="obj" /> равно данному экземпляру; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060007B9 RID: 1977 RVA: 0x00022057 File Offset: 0x00020257
		[NonVersionable]
		public bool Equals(byte obj)
		{
			return this == obj;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.Byte" />.</returns>
		// Token: 0x060007BA RID: 1978 RVA: 0x000221D5 File Offset: 0x000203D5
		public override int GetHashCode()
		{
			return (int)this;
		}

		/// <summary>Преобразует строковое представление числа в его эквивалент типа <see cref="T:System.Byte" />.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число. Данная строка интерпретируется с использованием стиля <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <returns>Байтовое значение, эквивалентное числу, которое содержится в параметре <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> находится в неправильном формате.</exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="s" /> представляет число, которое меньше значения <see cref="F:System.Byte.MinValue" /> или больше значения <see cref="F:System.Byte.MaxValue" />.</exception>
		// Token: 0x060007BB RID: 1979 RVA: 0x000222D7 File Offset: 0x000204D7
		public static byte Parse(string s)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return byte.Parse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo);
		}

		/// <summary>Преобразует строковое представление числа с указанным стилем в его эквивалент в формате <see cref="T:System.Byte" />.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число. Строка интерпретируется с использованием стиля, указанного в <paramref name="style" />.</param>
		/// <param name="style">Побитовое сочетание значений перечисления, обозначающих элементы стиля, которые могут быть представлены в параметре <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <returns>Байтовое значение, эквивалентное числу, которое содержится в параметре <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> находится в неправильном формате.</exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="s" /> представляет число, которое меньше значения <see cref="F:System.Byte.MinValue" /> или больше значения <see cref="F:System.Byte.MaxValue" />.  
		///
		/// или - 
		/// <paramref name="s" /> содержит ненулевые дробные разряды.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		///
		/// или - 
		/// <paramref name="style" /> не является сочетанием значений <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> и <see cref="F:System.Globalization.NumberStyles.HexNumber" />.</exception>
		// Token: 0x060007BC RID: 1980 RVA: 0x000222F4 File Offset: 0x000204F4
		public static byte Parse(string s, NumberStyles style)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return byte.Parse(s, style, NumberFormatInfo.CurrentInfo);
		}

		/// <summary>Преобразует строковое представление числа в указанном формате, связанном с определенным языком и региональными параметрами, в его эквивалент типа <see cref="T:System.Byte" />.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число. Данная строка интерпретируется с использованием стиля <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <param name="provider">Объект, который предоставляет сведения об анализе параметра <paramref name="s" /> для определенного языка и региональных параметров. Если значение параметра <paramref name="provider" /> равно <see langword="null" />, используются текущий язык и региональные параметры потока.</param>
		/// <returns>Байтовое значение, эквивалентное числу, которое содержится в параметре <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> находится в неправильном формате.</exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="s" /> представляет число, которое меньше значения <see cref="F:System.Byte.MinValue" /> или больше значения <see cref="F:System.Byte.MaxValue" />.</exception>
		// Token: 0x060007BD RID: 1981 RVA: 0x00022317 File Offset: 0x00020517
		public static byte Parse(string s, IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return byte.Parse(s, NumberStyles.Integer, NumberFormatInfo.GetInstance(provider));
		}

		/// <summary>Преобразует строковое представление числа в указанном стиле и формате, связанном с определенным языком и региональными параметрами, в его эквивалент типа <see cref="T:System.Byte" />.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число. Строка интерпретируется с использованием стиля, указанного в <paramref name="style" />.</param>
		/// <param name="style">Побитовое сочетание значений перечисления, обозначающих элементы стиля, которые могут быть представлены в параметре <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <param name="provider">Объект, который предоставляет сведения о формате параметра <paramref name="s" /> для определенного языка и региональных параметров. Если значение параметра <paramref name="provider" /> равно <see langword="null" />, используются текущий язык и региональные параметры потока.</param>
		/// <returns>Байтовое значение, эквивалентное числу, которое содержится в параметре <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> находится в неправильном формате.</exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="s" /> представляет число, которое меньше значения <see cref="F:System.Byte.MinValue" /> или больше значения <see cref="F:System.Byte.MaxValue" />.  
		///
		/// или - 
		/// <paramref name="s" /> содержит ненулевые дробные разряды.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		///
		/// или - 
		/// <paramref name="style" /> не является сочетанием значений <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> и <see cref="F:System.Globalization.NumberStyles.HexNumber" />.</exception>
		// Token: 0x060007BE RID: 1982 RVA: 0x00022335 File Offset: 0x00020535
		public static byte Parse(string s, NumberStyles style, IFormatProvider provider)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return byte.Parse(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00022359 File Offset: 0x00020559
		public static byte Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return byte.Parse(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00022370 File Offset: 0x00020570
		private static byte Parse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info)
		{
			int num = 0;
			try
			{
				num = Number.ParseInt32(s, style, info);
			}
			catch (OverflowException innerException)
			{
				throw new OverflowException("Value was either too large or too small for an unsigned byte.", innerException);
			}
			if (num < 0 || num > 255)
			{
				throw new OverflowException("Value was either too large or too small for an unsigned byte.");
			}
			return (byte)num;
		}

		/// <summary>Предпринимает попытку преобразования строкового представления числа в его эквивалент типа <see cref="T:System.Byte" /> и возвращает значение, позволяющее определить, успешно ли выполнено преобразование.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число. Данная строка интерпретируется с использованием стиля <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <param name="result">При возврате этого метода содержит значение <see cref="T:System.Byte" />, эквивалентное числу, содержащемуся в параметре <paramref name="s" />, если преобразование выполнено успешно, или ноль, если оно завершилось неудачей. Этот параметр передается неинициализированным; любое значение, первоначально предоставленное в объекте <paramref name="result" />, будет перезаписано.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="s" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060007C1 RID: 1985 RVA: 0x000223C0 File Offset: 0x000205C0
		public static bool TryParse(string s, out byte result)
		{
			if (s == null)
			{
				result = 0;
				return false;
			}
			return byte.TryParse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x000223DC File Offset: 0x000205DC
		public static bool TryParse(ReadOnlySpan<char> s, out byte result)
		{
			return byte.TryParse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
		}

		/// <summary>Преобразует строковое представление числа в указанном стиле и формате, связанном с определенным языком и региональными параметрами, в его эквивалент типа <see cref="T:System.Byte" />. Возвращает значение, указывающее, успешно ли выполнено преобразование.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число. Строка интерпретируется с использованием стиля, указанного в <paramref name="style" />.</param>
		/// <param name="style">Побитовое сочетание значений перечисления, обозначающих элементы стиля, которые могут быть представлены в параметре <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <param name="provider">Объект, который предоставляет сведения о форматировании параметра <paramref name="s" /> в зависимости от языка и региональных параметров. Если значение параметра <paramref name="provider" /> равно <see langword="null" />, используются текущий язык и региональные параметры потока.</param>
		/// <param name="result">По возврате из этого метода содержит 8-битовое целочисленное значение без знака, эквивалентное числу, содержащемуся в параметре <paramref name="s" />, если преобразование выполнено успешно, или ноль, если оно завершилось неудачей. Преобразование завершается сбоем, если параметр <paramref name="s" /> равен <see langword="null" /> или <see cref="F:System.String.Empty" />, не находится в правильном формате или представляет число меньше <see cref="F:System.Byte.MinValue" /> или больше <see cref="F:System.Byte.MaxValue" />. Этот параметр передается неинициализированным; любое значение, первоначально предоставленное в объекте <paramref name="result" />, будет перезаписано.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="s" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		///
		/// или - 
		/// <paramref name="style" /> не является сочетанием значений <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> и <see cref="F:System.Globalization.NumberStyles.HexNumber" />.</exception>
		// Token: 0x060007C3 RID: 1987 RVA: 0x000223EB File Offset: 0x000205EB
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out byte result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				result = 0;
				return false;
			}
			return byte.TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x0002240E File Offset: 0x0002060E
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out byte result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return byte.TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00022424 File Offset: 0x00020624
		private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out byte result)
		{
			result = 0;
			int num;
			if (!Number.TryParseInt32(s, style, info, out num))
			{
				return false;
			}
			if (num < 0 || num > 255)
			{
				return false;
			}
			result = (byte)num;
			return true;
		}

		/// <summary>Преобразует значение текущего объекта <see cref="T:System.Byte" /> в эквивалентное ему строковое представление.</summary>
		/// <returns>Строковое представление значения данного объекта, состоящее из последовательности цифр в диапазоне от 0 до 9 без начальных нулей.</returns>
		// Token: 0x060007C6 RID: 1990 RVA: 0x00022455 File Offset: 0x00020655
		public override string ToString()
		{
			return Number.FormatInt32((int)this, null, null);
		}

		/// <summary>Преобразует значение текущего объекта <see cref="T:System.Byte" /> в эквивалентное ему строковое представление с использованием заданного формата.</summary>
		/// <param name="format">Строка числового формата.</param>
		/// <returns>Строковое представление текущего объекта <see cref="T:System.Byte" />, отформатированное, как указано в параметре <paramref name="format" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> содержит неподдерживаемый спецификатор. Спецификаторы поддерживаемого формата перечислены в разделе "Примечания".</exception>
		// Token: 0x060007C7 RID: 1991 RVA: 0x00022465 File Offset: 0x00020665
		public string ToString(string format)
		{
			return Number.FormatInt32((int)this, format, null);
		}

		/// <summary>Преобразует числовое значение текущего объекта <see cref="T:System.Byte" /> в эквивалентное ему строковое представление с использованием указанных сведений об особенностях форматирования для данного языка и региональных параметров.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление значения данного объекта в формате, заданном в параметре <paramref name="provider" />.</returns>
		// Token: 0x060007C8 RID: 1992 RVA: 0x00022475 File Offset: 0x00020675
		[SecuritySafeCritical]
		public string ToString(IFormatProvider provider)
		{
			return Number.FormatInt32((int)this, null, provider);
		}

		/// <summary>Преобразует числовое значение текущего объекта <see cref="T:System.Byte" /> в эквивалентное ему строковое представление с использованием указанного формата и сведений об особенностях форматирования для данного языка и региональных параметров.</summary>
		/// <param name="format">Стандартная или пользовательская строка числового формата.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление текущего объекта <see cref="T:System.Byte" />, отформатированное, как указано в параметрах <paramref name="format" /> и <paramref name="provider" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> содержит неподдерживаемый спецификатор. Спецификаторы поддерживаемого формата перечислены в разделе "Примечания".</exception>
		// Token: 0x060007C9 RID: 1993 RVA: 0x00022485 File Offset: 0x00020685
		[SecuritySafeCritical]
		public string ToString(string format, IFormatProvider provider)
		{
			return Number.FormatInt32((int)this, format, provider);
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00022495 File Offset: 0x00020695
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider provider = null)
		{
			return Number.TryFormatInt32((int)this, format, provider, destination, out charsWritten);
		}

		/// <summary>Возвращает <see cref="T:System.TypeCode" /> для типа значения <see cref="T:System.Byte" />.</summary>
		/// <returns>Константа перечислимого типа, <see cref="F:System.TypeCode.Byte" />.</returns>
		// Token: 0x060007CB RID: 1995 RVA: 0x000224A3 File Offset: 0x000206A3
		public TypeCode GetTypeCode()
		{
			return TypeCode.Byte;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>
		///   <see langword="true" />, если значение текущего экземпляра не равно нулю; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060007CC RID: 1996 RVA: 0x000224A6 File Offset: 0x000206A6
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToChar(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Char" />.</returns>
		// Token: 0x060007CD RID: 1997 RVA: 0x000224AF File Offset: 0x000206AF
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToSByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.SByte" />.</returns>
		// Token: 0x060007CE RID: 1998 RVA: 0x000224B8 File Offset: 0x000206B8
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, не измененное.</returns>
		// Token: 0x060007CF RID: 1999 RVA: 0x000221D5 File Offset: 0x000203D5
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return this;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Int16" />.</returns>
		// Token: 0x060007D0 RID: 2000 RVA: 0x000224C1 File Offset: 0x000206C1
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.UInt16" />.</returns>
		// Token: 0x060007D1 RID: 2001 RVA: 0x000224CA File Offset: 0x000206CA
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Int32" />.</returns>
		// Token: 0x060007D2 RID: 2002 RVA: 0x000224D3 File Offset: 0x000206D3
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.UInt32" />.</returns>
		// Token: 0x060007D3 RID: 2003 RVA: 0x000224DC File Offset: 0x000206DC
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Int64" />.</returns>
		// Token: 0x060007D4 RID: 2004 RVA: 0x000224E5 File Offset: 0x000206E5
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.UInt64" />.</returns>
		// Token: 0x060007D5 RID: 2005 RVA: 0x000224EE File Offset: 0x000206EE
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToSingle(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Single" />.</returns>
		// Token: 0x060007D6 RID: 2006 RVA: 0x000224F7 File Offset: 0x000206F7
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToDouble(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Double" />.</returns>
		// Token: 0x060007D7 RID: 2007 RVA: 0x00022500 File Offset: 0x00020700
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToDecimal(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Decimal" />.</returns>
		// Token: 0x060007D8 RID: 2008 RVA: 0x00022509 File Offset: 0x00020709
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this);
		}

		/// <summary>Данное преобразование не поддерживается. При попытке использовать этот метод выбрасывается исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x060007D9 RID: 2009 RVA: 0x00022512 File Offset: 0x00020712
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "Byte", "DateTime"));
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)" />.</summary>
		/// <param name="type">Тип, к которому необходимо привести это значение <see cref="T:System.Byte" />.</param>
		/// <param name="provider">Реализация интерфейса <see cref="T:System.IFormatProvider" />, предоставляющая сведения о формате возвращаемого значения.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <paramref name="type" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Запрошенное преобразование типа не поддерживается.</exception>
		// Token: 0x060007DA RID: 2010 RVA: 0x0002252D File Offset: 0x0002072D
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x04001074 RID: 4212
		private readonly byte m_value;

		/// <summary>Представляет наибольшее возможное значение типа <see cref="T:System.Byte" />. Это поле является константой.</summary>
		// Token: 0x04001075 RID: 4213
		public const byte MaxValue = 255;

		/// <summary>Представляет минимально допустимое значение типа <see cref="T:System.Byte" />. Это поле является константой.</summary>
		// Token: 0x04001076 RID: 4214
		public const byte MinValue = 0;
	}
}
