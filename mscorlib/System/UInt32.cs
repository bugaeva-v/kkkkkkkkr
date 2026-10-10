using System;
using System.Globalization;
using System.Runtime.Versioning;
using System.Security;

namespace System
{
	/// <summary>Представляет 32-битовое целое число без знака.</summary>
	// Token: 0x020001A7 RID: 423
	[CLSCompliant(false)]
	[Serializable]
	public readonly struct UInt32 : IComparable, IConvertible, IFormattable, IComparable<uint>, IEquatable<uint>, ISpanFormattable
	{
		/// <summary>Сравнивает этот экземпляр с заданным объектом и возвращает значение, указывающее, как соотносятся значения этих объектов.</summary>
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
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> не является объектом <see cref="T:System.UInt32" />.</exception>
		// Token: 0x06001219 RID: 4633 RVA: 0x0004800C File Offset: 0x0004620C
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (!(value is uint))
			{
				throw new ArgumentException("Object must be of type UInt32.");
			}
			uint num = (uint)value;
			if (this < num)
			{
				return -1;
			}
			if (this > num)
			{
				return 1;
			}
			return 0;
		}

		/// <summary>Сравнивает данный экземпляр с заданным 32-битовым целым числом без знака и возвращает значение, указывающее, как соотносятся их значения.</summary>
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
		// Token: 0x0600121A RID: 4634 RVA: 0x00048047 File Offset: 0x00046247
		public int CompareTo(uint value)
		{
			if (this < value)
			{
				return -1;
			}
			if (this > value)
			{
				return 1;
			}
			return 0;
		}

		/// <summary>Возвращает значение, показывающее, равен ли данный экземпляр заданному объекту.</summary>
		/// <param name="obj">Объект для сравнения с данным экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="obj" /> является экземпляром типа <see cref="T:System.UInt32" /> и равен значению данного экземпляра; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600121B RID: 4635 RVA: 0x00048058 File Offset: 0x00046258
		public override bool Equals(object obj)
		{
			return obj is uint && this == (uint)obj;
		}

		/// <summary>Возвращает значение, позволяющее определить, равен ли данный экземпляр заданному объекту типа <see cref="T:System.UInt32" />.</summary>
		/// <param name="obj">Значение для сравнения с данным экземпляром.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="obj" /> совпадает со значением данного экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600121C RID: 4636 RVA: 0x0004806E File Offset: 0x0004626E
		[NonVersionable]
		public bool Equals(uint obj)
		{
			return this == obj;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x0600121D RID: 4637 RVA: 0x00048075 File Offset: 0x00046275
		public override int GetHashCode()
		{
			return (int)this;
		}

		/// <summary>Преобразовывает числовое значение данного экземпляра в эквивалентное ему строковое представление.</summary>
		/// <returns>Строковое представление значения данного экземпляра, состоящее из последовательности цифр от 0 до 9 без знака и начальных нулей.</returns>
		// Token: 0x0600121E RID: 4638 RVA: 0x00048079 File Offset: 0x00046279
		public override string ToString()
		{
			return Number.FormatUInt32(this, null, null);
		}

		/// <summary>Преобразует числовое значение данного экземпляра в эквивалентное ему строковое представление с использованием указанных сведений об особенностях форматирования для данного языка и региональных параметров.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление значения данного экземпляра, состоящее из последовательности цифр от 0 до 9 без знака и нулей в начале.</returns>
		// Token: 0x0600121F RID: 4639 RVA: 0x00048089 File Offset: 0x00046289
		[SecuritySafeCritical]
		public string ToString(IFormatProvider provider)
		{
			return Number.FormatUInt32(this, null, provider);
		}

		/// <summary>Преобразует числовое значение данного экземпляра в эквивалентное ему строковое представление с использованием указанного формата.</summary>
		/// <param name="format">Строка числового формата.</param>
		/// <returns>Строковое представление значения данного экземпляра, определяемое параметром <paramref name="format" />.</returns>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="format" /> является недопустимым.</exception>
		// Token: 0x06001220 RID: 4640 RVA: 0x00048099 File Offset: 0x00046299
		public string ToString(string format)
		{
			return Number.FormatUInt32(this, format, null);
		}

		/// <summary>Преобразует числовое значение данного экземпляра в эквивалентное ему строковое представление с использованием указанного формата и сведений об особенностях форматирования для данного языка и региональных параметров.</summary>
		/// <param name="format">Строка числового формата.</param>
		/// <param name="provider">Объект, который представляет связанную с языком и региональными параметрами информацию о форматировании этого экземпляра.</param>
		/// <returns>Строковое представление значения данного экземпляра, определяемое параметрами <paramref name="format" /> и <paramref name="provider" />.</returns>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="format" /> является недопустимым.</exception>
		// Token: 0x06001221 RID: 4641 RVA: 0x000480A9 File Offset: 0x000462A9
		[SecuritySafeCritical]
		public string ToString(string format, IFormatProvider provider)
		{
			return Number.FormatUInt32(this, format, provider);
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x000480B9 File Offset: 0x000462B9
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider provider = null)
		{
			return Number.TryFormatUInt32(this, format, provider, destination, out charsWritten);
		}

		/// <summary>Преобразует строковое представление числа в эквивалентное ему 32-битовое целое число без знака.</summary>
		/// <param name="s">Строка, содержащая число для преобразования.</param>
		/// <returns>32-разрядное целое число без знака, эквивалентное числу, содержащемуся в параметре <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="s" /> имеет неправильный формат.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="s" /> представляет число, которое меньше <see cref="F:System.UInt32.MinValue" /> или больше <see cref="F:System.UInt32.MaxValue" />.</exception>
		// Token: 0x06001223 RID: 4643 RVA: 0x000480C7 File Offset: 0x000462C7
		[CLSCompliant(false)]
		public static uint Parse(string s)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Number.ParseUInt32(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo);
		}

		/// <summary>Преобразует строковое представление числа в указанном формате в эквивалентное ему 32-битовое целое число без знака.</summary>
		/// <param name="s">Строка, содержащая число для преобразования. Строка интерпретируется с использованием стиля, указанного параметром <paramref name="style" />.</param>
		/// <param name="style">Побитовое сочетание значений перечисления, которое показывает разрешенный формат параметра <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <returns>32-битовое целое число без знака, эквивалентное числу, заданному параметром <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		///
		/// или - 
		/// <paramref name="style" /> не является сочетанием значений <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> и <see cref="F:System.Globalization.NumberStyles.HexNumber" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> не представлен в формате, совместимом с <paramref name="style" />.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="s" /> представляет число, которое меньше <see cref="F:System.UInt32.MinValue" /> или больше <see cref="F:System.UInt32.MaxValue" />.  
		///
		/// или - 
		/// <paramref name="s" /> содержит ненулевые дробные разряды.</exception>
		// Token: 0x06001224 RID: 4644 RVA: 0x000480E4 File Offset: 0x000462E4
		[CLSCompliant(false)]
		public static uint Parse(string s, NumberStyles style)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Number.ParseUInt32(s, style, NumberFormatInfo.CurrentInfo);
		}

		/// <summary>Преобразует строковое представление числа в эквивалентное ему 32-разрядное целое число без знака в указанном формате, соответствующем языку и региональным параметрам.</summary>
		/// <param name="s">Строка, представляющая преобразуемое число.</param>
		/// <param name="provider">Объект, который предоставляет сведения о форматировании параметра <paramref name="s" /> в зависимости от языка и региональных параметров.</param>
		/// <returns>32-битовое целое число без знака, эквивалентное числу, заданному параметром <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> имеет неправильный стиль.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="s" /> представляет число меньше <see cref="F:System.UInt32.MinValue" /> или больше <see cref="F:System.UInt32.MaxValue" />.</exception>
		// Token: 0x06001225 RID: 4645 RVA: 0x00048107 File Offset: 0x00046307
		[CLSCompliant(false)]
		public static uint Parse(string s, IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Number.ParseUInt32(s, NumberStyles.Integer, NumberFormatInfo.GetInstance(provider));
		}

		/// <summary>Преобразует строковое представление числа в формате, соответствующем стилю, языку и региональным параметрам, в эквивалентное ему 32-битовое целое число без знака.</summary>
		/// <param name="s">Строка, содержащая число для преобразования. Строка интерпретируется с использованием стиля, указанного параметром <paramref name="style" />.</param>
		/// <param name="style">Побитовое сочетание значений перечисления, обозначающих элементы стиля, которые могут быть представлены в параметре <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <param name="provider">Объект, который предоставляет сведения о форматировании параметра <paramref name="s" /> в зависимости от языка и региональных параметров.</param>
		/// <returns>32-битовое целое число без знака, эквивалентное числу, заданному параметром <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		///
		/// или - 
		/// <paramref name="style" /> не является сочетанием значений <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> и <see cref="F:System.Globalization.NumberStyles.HexNumber" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> не представлен в формате, совместимом с <paramref name="style" />.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="s" /> представляет число, которое меньше <see cref="F:System.UInt32.MinValue" /> или больше <see cref="F:System.UInt32.MaxValue" />.  
		///
		/// или - 
		/// <paramref name="s" /> содержит ненулевые дробные разряды.</exception>
		// Token: 0x06001226 RID: 4646 RVA: 0x00048125 File Offset: 0x00046325
		[CLSCompliant(false)]
		public static uint Parse(string s, NumberStyles style, IFormatProvider provider)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Number.ParseUInt32(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x00048149 File Offset: 0x00046349
		[CLSCompliant(false)]
		public static uint Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.ParseUInt32(s, style, NumberFormatInfo.GetInstance(provider));
		}

		/// <summary>Предпринимает попытку преобразования строкового представления числа в эквивалентное ему 32-битовое целое число без знака. Возвращает значение, указывающее, успешно ли выполнено преобразование.</summary>
		/// <param name="s">Строка, представляющая преобразуемое число.</param>
		/// <param name="result">При возвращении этим методом содержит 32-разрядное целочисленное значение без знака, эквивалентное числу, содержащемуся в параметре <paramref name="s" />, если преобразование выполнено успешно, или нуль, если оно завершилось сбоем. Преобразование завершается неудачей, если параметр <paramref name="s" /> равен <see langword="null" /> или <see cref="F:System.String.Empty" />, либо он находится в неверном формате или представляет число меньше <see cref="F:System.UInt32.MinValue" /> или больше <see cref="F:System.UInt32.MaxValue" />. Этот параметр передается неинициализированным; любое значение, первоначально предоставленное в объекте <paramref name="result" />, будет перезаписано.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="s" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001228 RID: 4648 RVA: 0x0004815E File Offset: 0x0004635E
		[CLSCompliant(false)]
		public static bool TryParse(string s, out uint result)
		{
			if (s == null)
			{
				result = 0U;
				return false;
			}
			return Number.TryParseUInt32(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x0004817A File Offset: 0x0004637A
		[CLSCompliant(false)]
		public static bool TryParse(ReadOnlySpan<char> s, out uint result)
		{
			return Number.TryParseUInt32(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
		}

		/// <summary>Предпринимает попытку преобразовать строковое представление числа в формате, соответствующем стилю, языку и региональным параметрам, в эквивалентное 32-битовое целое число без знака. Возвращает значение, указывающее, успешно ли выполнено преобразование.</summary>
		/// <param name="s">Строка, представляющая преобразуемое число. Строка интерпретируется с использованием стиля, указанного параметром <paramref name="style" />.</param>
		/// <param name="style">Побитовая комбинация значений перечисления, которая показывает разрешенный формат параметра <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <param name="provider">Объект, который предоставляет сведения о форматировании параметра <paramref name="s" /> в зависимости от языка и региональных параметров.</param>
		/// <param name="result">При возвращении этим методом содержит 32-разрядное целочисленное значение без знака, эквивалентное числу, содержащемуся в параметре <paramref name="s" />, если преобразование выполнено успешно, или нуль, если оно завершилось сбоем. Преобразование завершается сбоем, если значение параметра <paramref name="s" /> равно <see langword="null" /> или <see cref="F:System.String.Empty" />, либо его формат не соответствует формату, заданному в параметре <paramref name="style" />, либо оно представляет число меньше <see cref="F:System.UInt32.MinValue" /> или больше <see cref="F:System.UInt32.MaxValue" />. Этот параметр передается неинициализированным; любое значение, первоначально предоставленное в объекте <paramref name="result" />, будет перезаписано.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="s" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		///
		/// или - 
		/// <paramref name="style" /> не является сочетанием значений <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> и <see cref="F:System.Globalization.NumberStyles.HexNumber" />.</exception>
		// Token: 0x0600122A RID: 4650 RVA: 0x00048189 File Offset: 0x00046389
		[CLSCompliant(false)]
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out uint result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				result = 0U;
				return false;
			}
			return Number.TryParseUInt32(s, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x000481AC File Offset: 0x000463AC
		[CLSCompliant(false)]
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out uint result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.TryParseUInt32(s, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		/// <summary>Возвращает <see cref="T:System.TypeCode" /> для типа значения <see cref="T:System.UInt32" />.</summary>
		/// <returns>Константа перечислимого типа, <see cref="F:System.TypeCode.UInt32" />.</returns>
		// Token: 0x0600122C RID: 4652 RVA: 0x000481C2 File Offset: 0x000463C2
		public TypeCode GetTypeCode()
		{
			return TypeCode.UInt32;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>
		///   <see langword="true" />, если значение текущего экземпляра не равно нулю; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600122D RID: 4653 RVA: 0x000481C6 File Offset: 0x000463C6
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToChar(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Char" />.</returns>
		// Token: 0x0600122E RID: 4654 RVA: 0x000481CF File Offset: 0x000463CF
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToSByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.SByte" />.</returns>
		// Token: 0x0600122F RID: 4655 RVA: 0x000481D8 File Offset: 0x000463D8
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Byte" />.</returns>
		// Token: 0x06001230 RID: 4656 RVA: 0x000481E1 File Offset: 0x000463E1
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Int16" />.</returns>
		// Token: 0x06001231 RID: 4657 RVA: 0x000481EA File Offset: 0x000463EA
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.UInt16" />.</returns>
		// Token: 0x06001232 RID: 4658 RVA: 0x000481F3 File Offset: 0x000463F3
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Int32" />.</returns>
		// Token: 0x06001233 RID: 4659 RVA: 0x000481FC File Offset: 0x000463FC
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, не измененное.</returns>
		// Token: 0x06001234 RID: 4660 RVA: 0x00048075 File Offset: 0x00046275
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return this;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Int64" />.</returns>
		// Token: 0x06001235 RID: 4661 RVA: 0x00048205 File Offset: 0x00046405
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.UInt64" />.</returns>
		// Token: 0x06001236 RID: 4662 RVA: 0x0004820E File Offset: 0x0004640E
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToSingle(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Single" />.</returns>
		// Token: 0x06001237 RID: 4663 RVA: 0x00048217 File Offset: 0x00046417
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToDouble(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Double" />.</returns>
		// Token: 0x06001238 RID: 4664 RVA: 0x00048220 File Offset: 0x00046420
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToDecimal(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Decimal" />.</returns>
		// Token: 0x06001239 RID: 4665 RVA: 0x00048229 File Offset: 0x00046429
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this);
		}

		/// <summary>Данное преобразование не поддерживается. При попытке использовать этот метод выбрасывается исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x0600123A RID: 4666 RVA: 0x00048232 File Offset: 0x00046432
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "UInt32", "DateTime"));
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)" />.</summary>
		/// <param name="type">Тип, к которому необходимо привести это значение <see cref="T:System.UInt32" />.</param>
		/// <param name="provider">Реализация интерфейса <see cref="T:System.IFormatProvider" />, предоставляющая сведения о формате возвращаемого значения, связанные с языком и региональными параметрами.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <paramref name="type" />.</returns>
		// Token: 0x0600123B RID: 4667 RVA: 0x0004824D File Offset: 0x0004644D
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x0400135E RID: 4958
		private readonly uint m_value;

		/// <summary>Представляет наибольшее возможное значение типа <see cref="T:System.UInt32" />. Это поле является константой.</summary>
		// Token: 0x0400135F RID: 4959
		public const uint MaxValue = 4294967295U;

		/// <summary>Представляет минимально допустимое значение типа <see cref="T:System.UInt32" />. Это поле является константой.</summary>
		// Token: 0x04001360 RID: 4960
		public const uint MinValue = 0U;
	}
}
