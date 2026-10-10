using System;
using System.Globalization;
using System.Runtime.Versioning;
using System.Security;

namespace System
{
	/// <summary>Представляет 64-битовое целое число без знака.</summary>
	// Token: 0x020001A8 RID: 424
	[CLSCompliant(false)]
	[Serializable]
	public readonly struct UInt64 : IComparable, IConvertible, IFormattable, IComparable<ulong>, IEquatable<ulong>, ISpanFormattable
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
		///   <paramref name="value" /> не является объектом <see cref="T:System.UInt64" />.</exception>
		// Token: 0x0600123C RID: 4668 RVA: 0x00048260 File Offset: 0x00046460
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (!(value is ulong))
			{
				throw new ArgumentException("Object must be of type UInt64.");
			}
			ulong num = (ulong)value;
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

		/// <summary>Сравнивает данный экземпляр с заданным 64-битовым целым числом без знака и возвращает значение, указывающее, как соотносятся их значения.</summary>
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
		// Token: 0x0600123D RID: 4669 RVA: 0x0004829B File Offset: 0x0004649B
		public int CompareTo(ulong value)
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
		/// <param name="obj">Объект, сравниваемый с этим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="obj" /> является экземпляром типа <see cref="T:System.UInt64" /> и равен значению данного экземпляра; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600123E RID: 4670 RVA: 0x000482AC File Offset: 0x000464AC
		public override bool Equals(object obj)
		{
			return obj is ulong && this == (ulong)obj;
		}

		/// <summary>Возвращает значение, указывающее, равен ли этот экземпляр заданному значению типа <see cref="T:System.UInt64" />.</summary>
		/// <param name="obj">Значение типа <see cref="T:System.UInt64" /> для сравнения с данным экземпляром.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="obj" /> совпадает со значением данного экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600123F RID: 4671 RVA: 0x000325D2 File Offset: 0x000307D2
		[NonVersionable]
		public bool Equals(ulong obj)
		{
			return this == obj;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001240 RID: 4672 RVA: 0x000482C2 File Offset: 0x000464C2
		public override int GetHashCode()
		{
			return (int)this ^ (int)(this >> 32);
		}

		/// <summary>Преобразовывает числовое значение данного экземпляра в эквивалентное ему строковое представление.</summary>
		/// <returns>Строковое представление значения данного экземпляра, состоящее из последовательности цифр от 0 до 9 без знака и начальных нулей.</returns>
		// Token: 0x06001241 RID: 4673 RVA: 0x000482CE File Offset: 0x000464CE
		public override string ToString()
		{
			return Number.FormatUInt64(this, null, null);
		}

		/// <summary>Преобразует числовое значение данного экземпляра в эквивалентное ему строковое представление с использованием указанных сведений об особенностях форматирования для данного языка и региональных параметров.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление значения данного экземпляра, состоящее из последовательности цифр от 0 до 9 без знака и начальных нулей.</returns>
		// Token: 0x06001242 RID: 4674 RVA: 0x000482DE File Offset: 0x000464DE
		[SecuritySafeCritical]
		public string ToString(IFormatProvider provider)
		{
			return Number.FormatUInt64(this, null, provider);
		}

		/// <summary>Преобразует числовое значение данного экземпляра в эквивалентное ему строковое представление с использованием указанного формата.</summary>
		/// <param name="format">Строка числового формата.</param>
		/// <returns>Строковое представление значения данного экземпляра, определяемое параметром <paramref name="format" />.</returns>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="format" /> является недопустимым.</exception>
		// Token: 0x06001243 RID: 4675 RVA: 0x000482EE File Offset: 0x000464EE
		public string ToString(string format)
		{
			return Number.FormatUInt64(this, format, null);
		}

		/// <summary>Преобразует числовое значение данного экземпляра в эквивалентное ему строковое представление с использованием указанного формата и сведений об особенностях форматирования для данного языка и региональных параметров.</summary>
		/// <param name="format">Строка числового формата.</param>
		/// <param name="provider">Объект, который представляет связанную с языком и региональными параметрами информацию о форматировании этого экземпляра.</param>
		/// <returns>Строковое представление значения данного экземпляра, определяемое параметрами <paramref name="format" /> и <paramref name="provider" />.</returns>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="format" /> является недопустимым.</exception>
		// Token: 0x06001244 RID: 4676 RVA: 0x000482FE File Offset: 0x000464FE
		[SecuritySafeCritical]
		public string ToString(string format, IFormatProvider provider)
		{
			return Number.FormatUInt64(this, format, provider);
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x0004830E File Offset: 0x0004650E
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider provider = null)
		{
			return Number.TryFormatUInt64(this, format, provider, destination, out charsWritten);
		}

		/// <summary>Преобразует строковое представление числа в эквивалентное ему 64-битовое целое число без знака.</summary>
		/// <param name="s">Строка, представляющая преобразуемое число.</param>
		/// <returns>64-разрядное целое число без знака, эквивалентное числу, содержащемуся в параметре <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="s" /> имеет неправильный формат.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="s" /> представляет число, которое меньше <see cref="F:System.UInt64.MinValue" /> или больше <see cref="F:System.UInt64.MaxValue" />.</exception>
		// Token: 0x06001246 RID: 4678 RVA: 0x0004831C File Offset: 0x0004651C
		[CLSCompliant(false)]
		public static ulong Parse(string s)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Number.ParseUInt64(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo);
		}

		/// <summary>Преобразует строковое представление числа в указанном формате в эквивалентное ему 64-битовое целое число без знака.</summary>
		/// <param name="s">Строка, представляющая преобразуемое число. Строка интерпретируется с использованием стиля, указанного параметром <paramref name="style" />.</param>
		/// <param name="style">Побитовое сочетание значений перечисления, которое показывает разрешенный формат параметра <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <returns>64-битовое целое число без знака, эквивалентное числу, заданному параметром <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		///
		/// или - 
		/// <paramref name="style" /> не является сочетанием значений <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> и <see cref="F:System.Globalization.NumberStyles.HexNumber" />.</exception>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="s" /> не представлен в формате, совместимом с <paramref name="style" />.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="s" /> представляет число, которое меньше <see cref="F:System.UInt64.MinValue" /> или больше <see cref="F:System.UInt64.MaxValue" />.  
		///
		/// или - 
		/// <paramref name="s" /> содержит ненулевые дробные разряды.</exception>
		// Token: 0x06001247 RID: 4679 RVA: 0x00048339 File Offset: 0x00046539
		[CLSCompliant(false)]
		public static ulong Parse(string s, NumberStyles style)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Number.ParseUInt64(s, style, NumberFormatInfo.CurrentInfo);
		}

		/// <summary>Преобразует строковое представление числа в эквивалентное ему 64-разрядное целое число без знака в указанном формате, соответствующем языку и региональным параметрам.</summary>
		/// <param name="s">Строка, представляющая преобразуемое число.</param>
		/// <param name="provider">Объект, который предоставляет сведения о форматировании параметра <paramref name="s" /> в зависимости от языка и региональных параметров.</param>
		/// <returns>64-битовое целое число без знака, эквивалентное числу, заданному параметром <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="s" /> имеет неправильный стиль.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="s" /> представляет число, которое меньше <see cref="F:System.UInt64.MinValue" /> или больше <see cref="F:System.UInt64.MaxValue" />.</exception>
		// Token: 0x06001248 RID: 4680 RVA: 0x0004835C File Offset: 0x0004655C
		[CLSCompliant(false)]
		public static ulong Parse(string s, IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Number.ParseUInt64(s, NumberStyles.Integer, NumberFormatInfo.GetInstance(provider));
		}

		/// <summary>Преобразует строковое представление числа в формате, соответствующем стилю, языку и региональным параметрам, в эквивалентное ему 64-битовое целое число без знака.</summary>
		/// <param name="s">Строка, представляющая преобразуемое число. Строка интерпретируется с использованием стиля, указанного параметром <paramref name="style" />.</param>
		/// <param name="style">Побитовое сочетание значений перечисления, обозначающих элементы стиля, которые могут быть представлены в параметре <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <param name="provider">Объект, который предоставляет сведения о форматировании параметра <paramref name="s" /> в зависимости от языка и региональных параметров.</param>
		/// <returns>64-битовое целое число без знака, эквивалентное числу, заданному параметром <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		///
		/// или - 
		/// <paramref name="style" /> не является сочетанием значений <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> и <see cref="F:System.Globalization.NumberStyles.HexNumber" />.</exception>
		/// <exception cref="T:System.FormatException">Параметр <paramref name="s" /> не представлен в формате, совместимом с <paramref name="style" />.</exception>
		/// <exception cref="T:System.OverflowException">Параметр <paramref name="s" /> представляет число, которое меньше <see cref="F:System.UInt64.MinValue" /> или больше <see cref="F:System.UInt64.MaxValue" />.  
		///
		/// или - 
		/// <paramref name="s" /> содержит ненулевые дробные разряды.</exception>
		// Token: 0x06001249 RID: 4681 RVA: 0x0004837A File Offset: 0x0004657A
		[CLSCompliant(false)]
		public static ulong Parse(string s, NumberStyles style, IFormatProvider provider)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Number.ParseUInt64(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x0004839E File Offset: 0x0004659E
		[CLSCompliant(false)]
		public static ulong Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.ParseUInt64(s, style, NumberFormatInfo.GetInstance(provider));
		}

		/// <summary>Предпринимает попытку преобразования строкового представления числа в эквивалентное ему 64-битовое целое число без знака. Возвращает значение, указывающее, успешно ли выполнено преобразование.</summary>
		/// <param name="s">Строка, представляющая преобразуемое число.</param>
		/// <param name="result">При возвращении этим методом содержит 64-разрядное целочисленное значение без знака, эквивалентное числу, содержащемуся в параметре <paramref name="s" />, если преобразование выполнено успешно, или нуль, если оно завершилось сбоем. Преобразование завершается сбоем, если параметр <paramref name="s" /> равен <see langword="null" /> или <see cref="F:System.String.Empty" />, не находится в правильном формате или представляет число меньше <see cref="F:System.UInt64.MinValue" /> или больше <see cref="F:System.UInt64.MaxValue" />. Этот параметр передается неинициализированным; любое значение, первоначально предоставленное в объекте <paramref name="result" />, будет перезаписано.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="s" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600124B RID: 4683 RVA: 0x000483B3 File Offset: 0x000465B3
		[CLSCompliant(false)]
		public static bool TryParse(string s, out ulong result)
		{
			if (s == null)
			{
				result = 0UL;
				return false;
			}
			return Number.TryParseUInt64(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x000483D0 File Offset: 0x000465D0
		[CLSCompliant(false)]
		public static bool TryParse(ReadOnlySpan<char> s, out ulong result)
		{
			return Number.TryParseUInt64(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
		}

		/// <summary>Предпринимает попытку преобразовать строковое представление числа в формате, соответствующем стилю, языку и региональным параметрам, в эквивалентное 64-битовое целое число без знака. Возвращает значение, указывающее, успешно ли выполнено преобразование.</summary>
		/// <param name="s">Строка, представляющая преобразуемое число. Строка интерпретируется с использованием стиля, указанного параметром <paramref name="style" />.</param>
		/// <param name="style">Побитовая комбинация значений перечисления, которая показывает разрешенный формат параметра <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <param name="provider">Объект, который предоставляет сведения о форматировании параметра <paramref name="s" /> в зависимости от языка и региональных параметров.</param>
		/// <param name="result">При возвращении этим методом содержит 64-разрядное целочисленное значение без знака, эквивалентное числу, содержащемуся в параметре <paramref name="s" />, если преобразование выполнено успешно, или нуль, если оно завершилось сбоем. Преобразование завершается сбоем, если параметр <paramref name="s" /> равен <see langword="null" /> или <see cref="F:System.String.Empty" />, не находится в формате, совместимом с <paramref name="style" /> или представляет собой число меньше <see cref="F:System.UInt64.MinValue" /> или больше <see cref="F:System.UInt64.MaxValue" />. Этот параметр передается неинициализированным; любое значение, первоначально предоставленное в объекте <paramref name="result" />, будет перезаписано.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="s" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		///
		/// или - 
		/// <paramref name="style" /> не является сочетанием значений <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> и <see cref="F:System.Globalization.NumberStyles.HexNumber" />.</exception>
		// Token: 0x0600124D RID: 4685 RVA: 0x000483DF File Offset: 0x000465DF
		[CLSCompliant(false)]
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ulong result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				result = 0UL;
				return false;
			}
			return Number.TryParseUInt64(s, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x00048403 File Offset: 0x00046603
		[CLSCompliant(false)]
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out ulong result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.TryParseUInt64(s, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		/// <summary>Возвращает <see cref="T:System.TypeCode" /> для типа значения <see cref="T:System.UInt64" />.</summary>
		/// <returns>Константа перечислимого типа, <see cref="F:System.TypeCode.UInt64" />.</returns>
		// Token: 0x0600124F RID: 4687 RVA: 0x00048419 File Offset: 0x00046619
		public TypeCode GetTypeCode()
		{
			return TypeCode.UInt64;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>
		///   <see langword="true" />, если значение текущего экземпляра не равно нулю; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001250 RID: 4688 RVA: 0x0004841D File Offset: 0x0004661D
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToChar(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Char" />.</returns>
		// Token: 0x06001251 RID: 4689 RVA: 0x00048426 File Offset: 0x00046626
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToSByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.SByte" />.</returns>
		// Token: 0x06001252 RID: 4690 RVA: 0x0004842F File Offset: 0x0004662F
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Byte" />.</returns>
		// Token: 0x06001253 RID: 4691 RVA: 0x00048438 File Offset: 0x00046638
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Int16" />.</returns>
		// Token: 0x06001254 RID: 4692 RVA: 0x00048441 File Offset: 0x00046641
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.UInt16" />.</returns>
		// Token: 0x06001255 RID: 4693 RVA: 0x0004844A File Offset: 0x0004664A
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Int32" />.</returns>
		// Token: 0x06001256 RID: 4694 RVA: 0x00048453 File Offset: 0x00046653
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.UInt32" />.</returns>
		// Token: 0x06001257 RID: 4695 RVA: 0x0004845C File Offset: 0x0004665C
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Int64" />.</returns>
		// Token: 0x06001258 RID: 4696 RVA: 0x00048465 File Offset: 0x00046665
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, не измененное.</returns>
		// Token: 0x06001259 RID: 4697 RVA: 0x0003277C File Offset: 0x0003097C
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return this;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToSingle(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Single" />.</returns>
		// Token: 0x0600125A RID: 4698 RVA: 0x0004846E File Offset: 0x0004666E
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToDouble(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Double" />.</returns>
		// Token: 0x0600125B RID: 4699 RVA: 0x00048477 File Offset: 0x00046677
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToDecimal(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Decimal" />.</returns>
		// Token: 0x0600125C RID: 4700 RVA: 0x00048480 File Offset: 0x00046680
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this);
		}

		/// <summary>Данное преобразование не поддерживается. При попытке использовать этот метод выбрасывается исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x0600125D RID: 4701 RVA: 0x00048489 File Offset: 0x00046689
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "UInt64", "DateTime"));
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)" />.</summary>
		/// <param name="type">Тип, к которому необходимо привести это значение <see cref="T:System.UInt64" />.</param>
		/// <param name="provider">Реализация интерфейса <see cref="T:System.IFormatProvider" />, предоставляющая сведения о формате возвращаемого значения.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <paramref name="type" />.</returns>
		// Token: 0x0600125E RID: 4702 RVA: 0x000484A4 File Offset: 0x000466A4
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x04001361 RID: 4961
		private readonly ulong m_value;

		/// <summary>Представляет наибольшее возможное значение типа <see cref="T:System.UInt64" />. Это поле является константой.</summary>
		// Token: 0x04001362 RID: 4962
		public const ulong MaxValue = 18446744073709551615UL;

		/// <summary>Представляет минимально допустимое значение типа <see cref="T:System.UInt64" />. Это поле является константой.</summary>
		// Token: 0x04001363 RID: 4963
		public const ulong MinValue = 0UL;
	}
}
