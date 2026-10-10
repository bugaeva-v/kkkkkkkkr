using System;
using System.Globalization;
using System.Runtime.Versioning;
using System.Security;

namespace System
{
	/// <summary>Представляет 16-битовое целое число без знака.</summary>
	// Token: 0x020001A6 RID: 422
	[CLSCompliant(false)]
	[Serializable]
	public readonly struct UInt16 : IComparable, IConvertible, IFormattable, IComparable<ushort>, IEquatable<ushort>, ISpanFormattable
	{
		/// <summary>Сравнивает этот экземпляр с заданным объектом и возвращает значение, указывающее, как соотносятся значения этих объектов.</summary>
		/// <param name="value">Объект для сравнения или значение <see langword="null" />.</param>
		/// <returns>Знаковое число, представляющее относительные значения этого экземпляра и параметра <paramref name="value" />.  
		///   Возвращаемое значение 
		///   Описание 
		///   Меньше нуля 
		///   Этот экземпляр меньше параметра <paramref name="value" />.  
		///
		///   Нуль 
		///   Этот экземпляр и параметр <paramref name="value" /> равны.  
		///
		///   Больше нуля 
		///   Этот экземпляр больше параметра <paramref name="value" />.  
		///
		/// -или- 
		///  Свойство <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> не является объектом <see cref="T:System.UInt16" />.</exception>
		// Token: 0x060011F4 RID: 4596 RVA: 0x00047D74 File Offset: 0x00045F74
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (value is ushort)
			{
				return (int)(this - (ushort)value);
			}
			throw new ArgumentException("Object must be of type UInt16.");
		}

		/// <summary>Сравнивает данный экземпляр с заданным 16-битовым целым числом без знака и возвращает значение, указывающее, как соотносятся их значения.</summary>
		/// <param name="value">Целое число без знака для сравнения.</param>
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
		// Token: 0x060011F5 RID: 4597 RVA: 0x000225BE File Offset: 0x000207BE
		public int CompareTo(ushort value)
		{
			return (int)(this - value);
		}

		/// <summary>Возвращает значение, показывающее, равен ли данный экземпляр заданному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="obj" /> является экземпляром типа <see cref="T:System.UInt16" /> и равен значению данного экземпляра; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060011F6 RID: 4598 RVA: 0x00047D97 File Offset: 0x00045F97
		public override bool Equals(object obj)
		{
			return obj is ushort && this == (ushort)obj;
		}

		/// <summary>Возвращает значение, указывающее, равен ли этот экземпляр заданному значению типа <see cref="T:System.UInt16" />.</summary>
		/// <param name="obj">16-битовое целое число без знака для сравнения с данным экземпляром.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="obj" /> совпадает со значением данного экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060011F7 RID: 4599 RVA: 0x00022594 File Offset: 0x00020794
		[NonVersionable]
		public bool Equals(ushort obj)
		{
			return this == obj;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x060011F8 RID: 4600 RVA: 0x00022825 File Offset: 0x00020A25
		public override int GetHashCode()
		{
			return (int)this;
		}

		/// <summary>Преобразовывает числовое значение данного экземпляра в эквивалентное ему строковое представление.</summary>
		/// <returns>Строковое представление значения данного экземпляра, состоящее из последовательности цифр от 0 до 9 без знака и нулей в начале.</returns>
		// Token: 0x060011F9 RID: 4601 RVA: 0x00047DAD File Offset: 0x00045FAD
		public override string ToString()
		{
			return Number.FormatUInt32((uint)this, null, null);
		}

		/// <summary>Преобразует числовое значение данного экземпляра в эквивалентное ему строковое представление с использованием указанных сведений об особенностях форматирования для данного языка и региональных параметров.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление значения данного экземпляра, состоящее из последовательности цифр от 0 до 9 без знака и нулей в начале.</returns>
		// Token: 0x060011FA RID: 4602 RVA: 0x00047DBD File Offset: 0x00045FBD
		[SecuritySafeCritical]
		public string ToString(IFormatProvider provider)
		{
			return Number.FormatUInt32((uint)this, null, provider);
		}

		/// <summary>Преобразует числовое значение данного экземпляра в эквивалентное ему строковое представление с использованием указанного формата.</summary>
		/// <param name="format">Строка числового формата.</param>
		/// <returns>Строковое представление значения данного экземпляра, определяемое параметром <paramref name="format" />.</returns>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="format" /> является недопустимым.</exception>
		// Token: 0x060011FB RID: 4603 RVA: 0x00047DCD File Offset: 0x00045FCD
		public string ToString(string format)
		{
			return Number.FormatUInt32((uint)this, format, null);
		}

		/// <summary>Преобразует числовое значение данного экземпляра в эквивалентное ему строковое представление с использованием указанного формата и сведений об особенностях форматирования для данного языка и региональных параметров.</summary>
		/// <param name="format">Строка числового формата.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление значения данного экземпляра, определяемое параметрами <paramref name="format" /> и <paramref name="provider" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> недопустим.</exception>
		// Token: 0x060011FC RID: 4604 RVA: 0x00047DDD File Offset: 0x00045FDD
		[SecuritySafeCritical]
		public string ToString(string format, IFormatProvider provider)
		{
			return Number.FormatUInt32((uint)this, format, provider);
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x00047DED File Offset: 0x00045FED
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider provider = null)
		{
			return Number.TryFormatUInt32((uint)this, format, provider, destination, out charsWritten);
		}

		/// <summary>Преобразует строковое представление числа в эквивалентное ему 16-битовое целое число без знака.</summary>
		/// <param name="s">Строка, представляющая преобразуемое число.</param>
		/// <returns>16-разрядное целое число без знака, эквивалентное числу, содержащемуся в параметре <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> имеет неправильный формат.</exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="s" /> представляет число, которое меньше значения <see cref="F:System.UInt16.MinValue" /> или больше значения <see cref="F:System.UInt16.MaxValue" />.</exception>
		// Token: 0x060011FE RID: 4606 RVA: 0x00047DFB File Offset: 0x00045FFB
		[CLSCompliant(false)]
		public static ushort Parse(string s)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return ushort.Parse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo);
		}

		/// <summary>Преобразует строковое представление числа в указанном формате в эквивалентное ему 16-битовое целое число без знака.  
		/// Этот метод несовместим с CLS. CLS-совместимая альтернатива — <see cref="M:System.Int32.Parse(System.String,System.Globalization.NumberStyles)" />.</summary>
		/// <param name="s">Строка, представляющая преобразуемое число. Строка интерпретируется с использованием стиля, указанного параметром <paramref name="style" />.</param>
		/// <param name="style">Побитовое сочетание значений перечисления, которое показывает разрешенный формат параметра <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <returns>16-битовое целое число без знака, эквивалентное числу, заданному параметром <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		/// -или- 
		///  <paramref name="style" /> не является сочетанием значений <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> и <see cref="F:System.Globalization.NumberStyles.HexNumber" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> не представлен в формате, совместимом с <paramref name="style" />.</exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="s" /> представляет число, которое меньше значения <see cref="F:System.UInt16.MinValue" /> или больше значения <see cref="F:System.UInt16.MaxValue" />.  
		/// -или- 
		///  <paramref name="s" /> содержит ненулевые дробные разряды.</exception>
		// Token: 0x060011FF RID: 4607 RVA: 0x00047E18 File Offset: 0x00046018
		[CLSCompliant(false)]
		public static ushort Parse(string s, NumberStyles style)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return ushort.Parse(s, style, NumberFormatInfo.CurrentInfo);
		}

		/// <summary>Преобразует строковое представление числа в эквивалентное ему 16-разрядное целое число без знака в указанном формате, соответствующем языку и региональным параметрам.</summary>
		/// <param name="s">Строка, представляющая преобразуемое число.</param>
		/// <param name="provider">Объект, который предоставляет сведения о форматировании параметра <paramref name="s" /> в зависимости от языка и региональных параметров.</param>
		/// <returns>16-битовое целое число без знака, эквивалентное числу, заданному параметром <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> имеет неправильный формат.</exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="s" /> представляет число, которое меньше значения <see cref="F:System.UInt16.MinValue" /> или больше значения <see cref="F:System.UInt16.MaxValue" />.</exception>
		// Token: 0x06001200 RID: 4608 RVA: 0x00047E3B File Offset: 0x0004603B
		[CLSCompliant(false)]
		public static ushort Parse(string s, IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return ushort.Parse(s, NumberStyles.Integer, NumberFormatInfo.GetInstance(provider));
		}

		/// <summary>Преобразует строковое представление числа в формате, соответствующем стилю, языку и региональным параметрам, в эквивалентное ему 16-битовое целое число без знака.</summary>
		/// <param name="s">Строка, представляющая преобразуемое число. Строка интерпретируется с использованием стиля, указанного параметром <paramref name="style" />.</param>
		/// <param name="style">Побитовое сочетание значений перечисления, обозначающих элементы стиля, которые могут присутствовать в параметре <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <param name="provider">Объект, который предоставляет сведения о форматировании параметра <paramref name="s" /> в зависимости от языка и региональных параметров.</param>
		/// <returns>16-битовое целое число без знака, эквивалентное числу, заданному параметром <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		/// -или- 
		///  <paramref name="style" /> не является сочетанием значений <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> и <see cref="F:System.Globalization.NumberStyles.HexNumber" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> не представлен в формате, совместимом с <paramref name="style" />.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="s" /> представляет число, которое меньше <see cref="F:System.UInt16.MinValue" /> или больше <see cref="F:System.UInt16.MaxValue" />.  
		/// -или- 
		///  <paramref name="s" /> содержит ненулевые дробные разряды.</exception>
		// Token: 0x06001201 RID: 4609 RVA: 0x00047E59 File Offset: 0x00046059
		[CLSCompliant(false)]
		public static ushort Parse(string s, NumberStyles style, IFormatProvider provider)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return ushort.Parse(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x00047E7D File Offset: 0x0004607D
		[CLSCompliant(false)]
		public static ushort Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return ushort.Parse(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x00047E94 File Offset: 0x00046094
		private static ushort Parse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info)
		{
			uint num = 0U;
			try
			{
				num = Number.ParseUInt32(s, style, info);
			}
			catch (OverflowException innerException)
			{
				throw new OverflowException("Value was either too large or too small for a UInt16.", innerException);
			}
			if (num > 65535U)
			{
				throw new OverflowException("Value was either too large or too small for a UInt16.");
			}
			return (ushort)num;
		}

		/// <summary>Предпринимает попытку преобразования строкового представления числа в эквивалентное ему 16-битовое целое число без знака. Возвращает значение, указывающее, успешно ли выполнено преобразование.</summary>
		/// <param name="s">Строка, представляющая преобразуемое число.</param>
		/// <param name="result">При возвращении этим методом содержит 16-разрядное целочисленное значение без знака, эквивалентное числу, содержащемуся в параметре <paramref name="s" />, если преобразование выполнено успешно, или нуль, если оно завершилось сбоем. Преобразование завершается ошибкой, если параметр <paramref name="s" /> имеет значение <see langword="null" /> или <see cref="F:System.String.Empty" /> (неверный формат). или представляет число, которое меньше значения <see cref="F:System.UInt16.MinValue" /> или больше значения <see cref="F:System.UInt16.MaxValue" />. Этот параметр передается неинициализированным; любое значение, первоначально предоставленное в объекте <paramref name="result" />, будет перезаписано.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="s" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001204 RID: 4612 RVA: 0x00047EE0 File Offset: 0x000460E0
		[CLSCompliant(false)]
		public static bool TryParse(string s, out ushort result)
		{
			if (s == null)
			{
				result = 0;
				return false;
			}
			return ushort.TryParse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00047EFC File Offset: 0x000460FC
		[CLSCompliant(false)]
		public static bool TryParse(ReadOnlySpan<char> s, out ushort result)
		{
			return ushort.TryParse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
		}

		/// <summary>Предпринимает попытку преобразовать строковое представление числа в формате, соответствующем стилю, языку и региональным параметрам, в эквивалентное 16-битовое целое число без знака. Возвращает значение, указывающее, успешно ли выполнено преобразование.</summary>
		/// <param name="s">Строка, представляющая преобразуемое число. Строка интерпретируется с использованием стиля, указанного параметром <paramref name="style" />.</param>
		/// <param name="style">Побитовая комбинация значений перечисления, которая показывает разрешенный формат параметра <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <param name="provider">Объект, который предоставляет сведения о форматировании параметра <paramref name="s" /> в зависимости от языка и региональных параметров.</param>
		/// <param name="result">При возвращении этим методом содержит 16-разрядное целочисленное значение без знака, эквивалентное числу, содержащемуся в параметре <paramref name="s" />, если преобразование выполнено успешно, или нуль, если оно завершилось сбоем. Преобразование завершается сбоем, если параметр <paramref name="s" /> равен <see langword="null" /> или <see cref="F:System.String.Empty" />, не находится в формате, совместимом с <paramref name="style" /> или представляет собой число меньше <see cref="F:System.UInt16.MinValue" /> или больше <see cref="F:System.UInt16.MaxValue" />. Этот параметр передается неинициализированным; любое значение, первоначально предоставленное в объекте <paramref name="result" />, будет перезаписано.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="s" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		/// -или- 
		///  <paramref name="style" /> не является сочетанием значений <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> и <see cref="F:System.Globalization.NumberStyles.HexNumber" />.</exception>
		// Token: 0x06001206 RID: 4614 RVA: 0x00047F0B File Offset: 0x0004610B
		[CLSCompliant(false)]
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ushort result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				result = 0;
				return false;
			}
			return ushort.TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00047F2E File Offset: 0x0004612E
		[CLSCompliant(false)]
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out ushort result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return ushort.TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x00047F44 File Offset: 0x00046144
		private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out ushort result)
		{
			result = 0;
			uint num;
			if (!Number.TryParseUInt32(s, style, info, out num))
			{
				return false;
			}
			if (num > 65535U)
			{
				return false;
			}
			result = (ushort)num;
			return true;
		}

		/// <summary>Возвращает <see cref="T:System.TypeCode" /> для типа значения <see cref="T:System.UInt16" />.</summary>
		/// <returns>Константа перечислимого типа, <see cref="F:System.TypeCode.UInt16" />.</returns>
		// Token: 0x06001209 RID: 4617 RVA: 0x00047F71 File Offset: 0x00046171
		public TypeCode GetTypeCode()
		{
			return TypeCode.UInt16;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>
		///   <see langword="true" />, если значение текущего экземпляра не равно нулю; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600120A RID: 4618 RVA: 0x00047F74 File Offset: 0x00046174
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToChar(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Char" />.</returns>
		// Token: 0x0600120B RID: 4619 RVA: 0x00047F7D File Offset: 0x0004617D
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToSByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Текущее значение данного экземпляра, приведенное к типу <see cref="T:System.SByte" />.</returns>
		// Token: 0x0600120C RID: 4620 RVA: 0x00047F86 File Offset: 0x00046186
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Byte" />.</returns>
		// Token: 0x0600120D RID: 4621 RVA: 0x00047F8F File Offset: 0x0004618F
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Текущее значение данного экземпляра, приведенное к типу <see cref="T:System.Int16" />.</returns>
		// Token: 0x0600120E RID: 4622 RVA: 0x00047F98 File Offset: 0x00046198
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Текущее значение данного экземпляра без изменений.</returns>
		// Token: 0x0600120F RID: 4623 RVA: 0x00022825 File Offset: 0x00020A25
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return this;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение данного экземпляра, приведенное к типу <see cref="T:System.Int32" />.</returns>
		// Token: 0x06001210 RID: 4624 RVA: 0x00047FA1 File Offset: 0x000461A1
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Текущее значение данного экземпляра, приведенное к типу <see cref="T:System.UInt32" />.</returns>
		// Token: 0x06001211 RID: 4625 RVA: 0x00047FAA File Offset: 0x000461AA
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Текущее значение данного экземпляра, приведенное к типу <see cref="T:System.Int64" />.</returns>
		// Token: 0x06001212 RID: 4626 RVA: 0x00047FB3 File Offset: 0x000461B3
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Текущее значение данного экземпляра, приведенное к типу <see cref="T:System.UInt64" />.</returns>
		// Token: 0x06001213 RID: 4627 RVA: 0x00047FBC File Offset: 0x000461BC
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToSingle(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Текущее значение данного экземпляра, приведенное к типу <see cref="T:System.Single" />.</returns>
		// Token: 0x06001214 RID: 4628 RVA: 0x00047FC5 File Offset: 0x000461C5
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToDouble(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Текущее значение данного экземпляра, приведенное к типу <see cref="T:System.Double" />.</returns>
		// Token: 0x06001215 RID: 4629 RVA: 0x00047FCE File Offset: 0x000461CE
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToDecimal(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Текущее значение данного экземпляра, приведенное к типу <see cref="T:System.Decimal" />.</returns>
		// Token: 0x06001216 RID: 4630 RVA: 0x00047FD7 File Offset: 0x000461D7
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this);
		}

		/// <summary>Данное преобразование не поддерживается. При попытке использовать этот метод выбрасывается исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x06001217 RID: 4631 RVA: 0x00047FE0 File Offset: 0x000461E0
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "UInt16", "DateTime"));
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)" />.</summary>
		/// <param name="type">Тип, к которому необходимо привести это значение <see cref="T:System.UInt16" />.</param>
		/// <param name="provider">Реализация интерфейса <see cref="T:System.IFormatProvider" />, предоставляющая сведения о формате возвращаемого значения.</param>
		/// <returns>Текущее значение данного экземпляра, приведенное к типу <paramref name="type" />.</returns>
		// Token: 0x06001218 RID: 4632 RVA: 0x00047FFB File Offset: 0x000461FB
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x0400135B RID: 4955
		private readonly ushort m_value;

		/// <summary>Представляет наибольшее возможное значение типа <see cref="T:System.UInt16" />. Это поле является константой.</summary>
		// Token: 0x0400135C RID: 4956
		public const ushort MaxValue = 65535;

		/// <summary>Представляет минимально допустимое значение типа <see cref="T:System.UInt16" />. Это поле является константой.</summary>
		// Token: 0x0400135D RID: 4957
		public const ushort MinValue = 0;
	}
}
