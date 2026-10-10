using System;
using System.Globalization;
using System.Runtime.Versioning;
using System.Security;

namespace System
{
	/// <summary>Представляет 32-разрядное целое число со знаком.</summary>
	// Token: 0x02000149 RID: 329
	[Serializable]
	public readonly struct Int32 : IComparable, IConvertible, IFormattable, IComparable<int>, IEquatable<int>, ISpanFormattable
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
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="value" /> не является классом <see cref="T:System.Int32" />.</exception>
		// Token: 0x06000C43 RID: 3139 RVA: 0x0003231C File Offset: 0x0003051C
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (!(value is int))
			{
				throw new ArgumentException("Object must be of type Int32.");
			}
			int num = (int)value;
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

		/// <summary>Сравнивает данный экземпляр с заданным 32-битовым целым числом со знаком и возвращает значение, указывающее, как соотносятся их значения.</summary>
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
		// Token: 0x06000C44 RID: 3140 RVA: 0x00032357 File Offset: 0x00030557
		public int CompareTo(int value)
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
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="obj" /> является экземпляром типа <see cref="T:System.Int32" /> и равен значению данного экземпляра; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000C45 RID: 3141 RVA: 0x00032368 File Offset: 0x00030568
		public override bool Equals(object obj)
		{
			return obj is int && this == (int)obj;
		}

		/// <summary>Возвращает значение, указывающее, равен ли этот экземпляр заданному значению типа <see cref="T:System.Int32" />.</summary>
		/// <param name="obj">Значение типа <see cref="T:System.Int32" /> для сравнения с данным экземпляром.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="obj" /> совпадает со значением данного экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000C46 RID: 3142 RVA: 0x0003237E File Offset: 0x0003057E
		[NonVersionable]
		public bool Equals(int obj)
		{
			return this == obj;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06000C47 RID: 3143 RVA: 0x00032385 File Offset: 0x00030585
		public override int GetHashCode()
		{
			return this;
		}

		/// <summary>Преобразовывает числовое значение данного экземпляра в эквивалентное ему строковое представление.</summary>
		/// <returns>Строковое представление значения данного экземпляра, состоящее из знака минус, если число отрицательное, и последовательности цифр в диапазоне от 0 до 9 с ненулевой первой цифрой.</returns>
		// Token: 0x06000C48 RID: 3144 RVA: 0x00032389 File Offset: 0x00030589
		public override string ToString()
		{
			return Number.FormatInt32(this, null, null);
		}

		/// <summary>Преобразует числовое значение данного экземпляра в эквивалентное строковое представление с использованием указанного формата.</summary>
		/// <param name="format">Стандартная или пользовательская строка числового формата.</param>
		/// <returns>Строковое представление значения данного экземпляра, определяемое параметром <paramref name="format" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> является недопустимым или не поддерживается.</exception>
		// Token: 0x06000C49 RID: 3145 RVA: 0x00032399 File Offset: 0x00030599
		public string ToString(string format)
		{
			return Number.FormatInt32(this, format, null);
		}

		/// <summary>Преобразует числовое значение данного экземпляра в эквивалентное ему строковое представление с использованием указанных сведений об особенностях форматирования для данного языка и региональных параметров.</summary>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление значения данного экземпляра, определяемое параметром <paramref name="provider" />.</returns>
		// Token: 0x06000C4A RID: 3146 RVA: 0x000323A9 File Offset: 0x000305A9
		[SecuritySafeCritical]
		public string ToString(IFormatProvider provider)
		{
			return Number.FormatInt32(this, null, provider);
		}

		/// <summary>Преобразует числовое значение данного экземпляра в эквивалентное ему строковое представление с использованием указанного формата и сведений об особенностях форматирования для данного языка и региональных параметров.</summary>
		/// <param name="format">Стандартная или пользовательская строка числового формата.</param>
		/// <param name="provider">Объект, предоставляющий сведения о форматировании для определенного языка и региональных параметров.</param>
		/// <returns>Строковое представление значения данного экземпляра, определяемое параметрами <paramref name="format" /> и <paramref name="provider" />.</returns>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> является недопустимым или не поддерживается.</exception>
		// Token: 0x06000C4B RID: 3147 RVA: 0x000323B9 File Offset: 0x000305B9
		[SecuritySafeCritical]
		public string ToString(string format, IFormatProvider provider)
		{
			return Number.FormatInt32(this, format, provider);
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x000323C9 File Offset: 0x000305C9
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider provider = null)
		{
			return Number.TryFormatInt32(this, format, provider, destination, out charsWritten);
		}

		/// <summary>Преобразует строковое представление числа в эквивалентное ему 32-битовое целое число со знаком.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число.</param>
		/// <returns>32-разрядное целое число со знаком, эквивалентное числу, содержащемуся в параметре <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> имеет неправильный формат.</exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="s" /> представляет число, которое меньше значения <see cref="F:System.Int32.MinValue" /> или больше значения <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x06000C4D RID: 3149 RVA: 0x000323D7 File Offset: 0x000305D7
		public static int Parse(string s)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Number.ParseInt32(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo);
		}

		/// <summary>Преобразует строковое представление числа в указанном формате в эквивалентное ему 32-битовое целое число со знаком.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число.</param>
		/// <param name="style">Побитовое сочетание значений перечисления, обозначающих элементы стиля, которые могут быть представлены в параметре <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <returns>32-разрядное целое число со знаком, эквивалентное числу, заданному в параметре <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		///
		/// или - 
		/// <paramref name="style" /> не является сочетанием значений <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> и <see cref="F:System.Globalization.NumberStyles.HexNumber" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> не представлен в формате, совместимом с <paramref name="style" />.</exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="s" /> представляет число, которое меньше значения <see cref="F:System.Int32.MinValue" /> или больше значения <see cref="F:System.Int32.MaxValue" />.  
		///
		/// или - 
		/// <paramref name="s" /> содержит ненулевые дробные разряды.</exception>
		// Token: 0x06000C4E RID: 3150 RVA: 0x000323F4 File Offset: 0x000305F4
		public static int Parse(string s, NumberStyles style)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Number.ParseInt32(s, style, NumberFormatInfo.CurrentInfo);
		}

		/// <summary>Преобразует строковое представление числа в указанном формате, соответствующем языку и региональным параметрам, в эквивалентное ему 32-битовое целое число со знаком.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число.</param>
		/// <param name="provider">Объект, который предоставляет сведения о форматировании параметра <paramref name="s" /> в зависимости от языка и региональных параметров.</param>
		/// <returns>32-разрядное целое число со знаком, эквивалентное числу, заданному в параметре <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> находится в неправильном формате.</exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="s" /> представляет число, которое меньше значения <see cref="F:System.Int32.MinValue" /> или больше значения <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x06000C4F RID: 3151 RVA: 0x00032417 File Offset: 0x00030617
		public static int Parse(string s, IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Number.ParseInt32(s, NumberStyles.Integer, NumberFormatInfo.GetInstance(provider));
		}

		/// <summary>Преобразует строковое представление числа в формате, соответствующем языку и региональным параметрам, в эквивалентное ему 32-битовое целое число со знаком.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число.</param>
		/// <param name="style">Побитовое сочетание значений перечисления, обозначающих элементы стиля, которые могут быть представлены в параметре <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <param name="provider">Объект, который предоставляет сведения о формате параметра <paramref name="s" /> для определенного языка и региональных параметров.</param>
		/// <returns>32-разрядное целое число со знаком, эквивалентное числу, заданному в параметре <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		///
		/// или - 
		/// <paramref name="style" /> не является сочетанием значений <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> и <see cref="F:System.Globalization.NumberStyles.HexNumber" />.</exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> не представлен в формате, совместимом с <paramref name="style" />.</exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="s" /> представляет число, которое меньше значения <see cref="F:System.Int32.MinValue" /> или больше значения <see cref="F:System.Int32.MaxValue" />.  
		///
		/// или - 
		/// <paramref name="s" /> содержит ненулевые дробные разряды.</exception>
		// Token: 0x06000C50 RID: 3152 RVA: 0x00032435 File Offset: 0x00030635
		public static int Parse(string s, NumberStyles style, IFormatProvider provider)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Number.ParseInt32(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00032459 File Offset: 0x00030659
		public static int Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.ParseInt32(s, style, NumberFormatInfo.GetInstance(provider));
		}

		/// <summary>Преобразует строковое представление числа в эквивалентное ему 32-битовое целое число со знаком. Возвращает значение, указывающее, успешно ли выполнено преобразование.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число.</param>
		/// <param name="result">При возвращении этим методом содержит 32-разрядное целочисленное значение со знаком, эквивалентное числу, содержащемуся в параметре <paramref name="s" />, если преобразование выполнено успешно, или нуль, если оно завершилось сбоем. Преобразование завершается сбоем, если параметр <paramref name="s" /> равен <see langword="null" /> или <see cref="F:System.String.Empty" />, не находится в правильном формате или представляет число меньше <see cref="F:System.Int32.MinValue" /> или больше <see cref="F:System.Int32.MaxValue" />. Этот параметр передается неинициализированным; любое значение, первоначально предоставленное в объекте <paramref name="result" />, будет перезаписано.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="s" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000C52 RID: 3154 RVA: 0x0003246E File Offset: 0x0003066E
		public static bool TryParse(string s, out int result)
		{
			if (s == null)
			{
				result = 0;
				return false;
			}
			return Number.TryParseInt32(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x0003248A File Offset: 0x0003068A
		public static bool TryParse(ReadOnlySpan<char> s, out int result)
		{
			return Number.TryParseInt32(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
		}

		/// <summary>Преобразует строковое представление числа в формате, соответствующем языку и региональным параметрам, в эквивалентное ему 32-битовое целое число со знаком. Возвращает значение, указывающее, успешно ли выполнено преобразование.</summary>
		/// <param name="s">Строка, содержащая преобразуемое число. Строка интерпретируется с использованием стиля, указанного в <paramref name="style" />.</param>
		/// <param name="style">Побитовое сочетание значений перечисления, обозначающих элементы стиля, которые могут быть представлены в параметре <paramref name="s" />. Обычно указывается значение <see cref="F:System.Globalization.NumberStyles.Integer" />.</param>
		/// <param name="provider">Объект, который предоставляет сведения о форматировании параметра <paramref name="s" /> в зависимости от языка и региональных параметров.</param>
		/// <param name="result">При возвращении этим методом содержит 32-разрядное целочисленное значение со знаком, эквивалентное числу, содержащемуся в параметре <paramref name="s" />, если преобразование выполнено успешно, или нуль, если оно завершилось сбоем. Преобразование завершается сбоем, если параметр <paramref name="s" /> равен <see langword="null" /> или <see cref="F:System.String.Empty" />, не находится в формате, совместимом с <paramref name="style" /> или представляет собой число меньше <see cref="F:System.Int32.MinValue" /> или больше <see cref="F:System.Int32.MaxValue" />. Этот параметр передается неинициализированным; любое значение, первоначально предоставленное в объекте <paramref name="result" />, будет перезаписано.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="s" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> не является значением <see cref="T:System.Globalization.NumberStyles" />.  
		///
		/// или - 
		/// <paramref name="style" /> не является сочетанием значений <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> и <see cref="F:System.Globalization.NumberStyles.HexNumber" />.</exception>
		// Token: 0x06000C54 RID: 3156 RVA: 0x00032499 File Offset: 0x00030699
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out int result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				result = 0;
				return false;
			}
			return Number.TryParseInt32(s, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x000324BC File Offset: 0x000306BC
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out int result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.TryParseInt32(s, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		/// <summary>Возвращает <see cref="T:System.TypeCode" /> для типа значения <see cref="T:System.Int32" />.</summary>
		/// <returns>Константа перечислимого типа, <see cref="F:System.TypeCode.Int32" />.</returns>
		// Token: 0x06000C56 RID: 3158 RVA: 0x000324D2 File Offset: 0x000306D2
		public TypeCode GetTypeCode()
		{
			return TypeCode.Int32;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>
		///   <see langword="true" />, если значение текущего экземпляра не равно нулю; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000C57 RID: 3159 RVA: 0x000324D6 File Offset: 0x000306D6
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToChar(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Char" />.</returns>
		// Token: 0x06000C58 RID: 3160 RVA: 0x000324DF File Offset: 0x000306DF
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToSByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.SByte" />.</returns>
		// Token: 0x06000C59 RID: 3161 RVA: 0x000324E8 File Offset: 0x000306E8
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Byte" />.</returns>
		// Token: 0x06000C5A RID: 3162 RVA: 0x000324F1 File Offset: 0x000306F1
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Int16" />.</returns>
		// Token: 0x06000C5B RID: 3163 RVA: 0x000324FA File Offset: 0x000306FA
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.UInt16" />.</returns>
		// Token: 0x06000C5C RID: 3164 RVA: 0x00032503 File Offset: 0x00030703
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, не измененное.</returns>
		// Token: 0x06000C5D RID: 3165 RVA: 0x00032385 File Offset: 0x00030585
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return this;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.UInt32" />.</returns>
		// Token: 0x06000C5E RID: 3166 RVA: 0x0003250C File Offset: 0x0003070C
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Int64" />.</returns>
		// Token: 0x06000C5F RID: 3167 RVA: 0x00032515 File Offset: 0x00030715
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.UInt64" />.</returns>
		// Token: 0x06000C60 RID: 3168 RVA: 0x0003251E File Offset: 0x0003071E
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToSingle(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Single" />.</returns>
		// Token: 0x06000C61 RID: 3169 RVA: 0x00032527 File Offset: 0x00030727
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToDouble(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Double" />.</returns>
		// Token: 0x06000C62 RID: 3170 RVA: 0x00032530 File Offset: 0x00030730
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToDecimal(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <see cref="T:System.Decimal" />.</returns>
		// Token: 0x06000C63 RID: 3171 RVA: 0x00032539 File Offset: 0x00030739
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this);
		}

		/// <summary>Данное преобразование не поддерживается. При попытке использовать этот метод выбрасывается исключение <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Во всех случаях.</exception>
		// Token: 0x06000C64 RID: 3172 RVA: 0x00032542 File Offset: 0x00030742
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "Int32", "DateTime"));
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)" />.</summary>
		/// <param name="type">Тип, к которому необходимо привести это значение <see cref="T:System.Int32" />.</param>
		/// <param name="provider">Объект, предоставляющий сведения о формате возвращаемого значения.</param>
		/// <returns>Значение текущего экземпляра, приведенное к типу <paramref name="type" />.</returns>
		// Token: 0x06000C65 RID: 3173 RVA: 0x0003255D File Offset: 0x0003075D
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x04001255 RID: 4693
		private readonly int m_value;

		/// <summary>Представляет наибольшее возможное значение типа <see cref="T:System.Int32" />. Это поле является константой.</summary>
		// Token: 0x04001256 RID: 4694
		public const int MaxValue = 2147483647;

		/// <summary>Представляет минимально допустимое значение типа <see cref="T:System.Int32" />. Это поле является константой.</summary>
		// Token: 0x04001257 RID: 4695
		public const int MinValue = -2147483648;
	}
}
