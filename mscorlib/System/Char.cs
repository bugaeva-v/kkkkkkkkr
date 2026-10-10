using System;
using System.Globalization;
using System.Runtime.Versioning;

namespace System
{
	/// <summary>Представляет символ как элемент кода UTF-16.</summary>
	// Token: 0x02000105 RID: 261
	[Serializable]
	public readonly struct Char : IComparable, IComparable<char>, IEquatable<char>, IConvertible
	{
		// Token: 0x060007DD RID: 2013 RVA: 0x00022554 File Offset: 0x00020754
		private static bool IsLatin1(char ch)
		{
			return ch <= 'ÿ';
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00022561 File Offset: 0x00020761
		private static bool IsAscii(char ch)
		{
			return ch <= '\u007f';
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x0002256B File Offset: 0x0002076B
		private static UnicodeCategory GetLatin1UnicodeCategory(char ch)
		{
			return (UnicodeCategory)char.s_categoryForLatin1[(int)ch];
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x060007E0 RID: 2016 RVA: 0x00022574 File Offset: 0x00020774
		public override int GetHashCode()
		{
			return (int)(this | (int)this << 16);
		}

		/// <summary>Возвращает значение, показывающее, равен ли экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром или <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="obj" /> является экземпляром типа <see cref="T:System.Char" /> и равен значению данного экземпляра; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060007E1 RID: 2017 RVA: 0x0002257E File Offset: 0x0002077E
		public override bool Equals(object obj)
		{
			return obj is char && this == (char)obj;
		}

		/// <summary>Возвращает значение, указывающее, равен ли данный экземпляр указанному объекту <see cref="T:System.Char" />.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="obj" /> равен значению этого экземпляра; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060007E2 RID: 2018 RVA: 0x00022594 File Offset: 0x00020794
		[NonVersionable]
		public bool Equals(char obj)
		{
			return this == obj;
		}

		/// <summary>Сравнивает данный экземпляр с заданным объектом и показывает, расположен ли данный экземпляр перед, после или на той же позиции в порядке сортировки, что и заданный объект <see cref="T:System.Object" />.</summary>
		/// <param name="value">Объект, сравниваемый с этим экземпляром, или <see langword="null" />.</param>
		/// <returns>Число со знаком, которое показывает позицию данного экземпляра в порядке сортировки по отношению к параметру <paramref name="value" />.  
		///   Возвращаемое значение 
		///   Описание: 
		///   Меньше нуля 
		///   Данный экземпляр предшествует параметру <paramref name="value" />.  
		///
		///   Нуль 
		///   Данный экземпляр имеет ту же позицию в порядке сортировки, что и <paramref name="value" />.  
		///
		///   Больше нуля 
		///   Данный экземпляр стоит после параметра <paramref name="value" />.  
		///
		/// - или - 
		///  Свойство <paramref name="value" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> не является объектом <see cref="T:System.Char" />.</exception>
		// Token: 0x060007E3 RID: 2019 RVA: 0x0002259B File Offset: 0x0002079B
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (!(value is char))
			{
				throw new ArgumentException("Object must be of type Char.");
			}
			return (int)(this - (char)value);
		}

		/// <summary>Сравнивает данный экземпляр с заданным объектом <see cref="T:System.Char" /> и показывает, расположен ли данный экземпляр перед, после или на той же позиции в порядке сортировки, что и заданный объект <see cref="T:System.Char" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Char" /> для сравнения.</param>
		/// <returns>Число со знаком, которое показывает позицию данного экземпляра в порядке сортировки по отношению к параметру <paramref name="value" />.  
		///   Возвращаемое значение 
		///   Описание: 
		///   Меньше нуля 
		///   Данный экземпляр предшествует параметру <paramref name="value" />.  
		///
		///   Нуль 
		///   Данный экземпляр имеет ту же позицию в порядке сортировки, что и <paramref name="value" />.  
		///
		///   Больше нуля 
		///   Данный экземпляр стоит после параметра <paramref name="value" />.</returns>
		// Token: 0x060007E4 RID: 2020 RVA: 0x000225BE File Offset: 0x000207BE
		public int CompareTo(char value)
		{
			return (int)(this - value);
		}

		/// <summary>Преобразует значение этого экземпляра в эквивалентное ему строковое представление.</summary>
		/// <returns>Строковое представление значения этого экземпляра.</returns>
		// Token: 0x060007E5 RID: 2021 RVA: 0x000225C4 File Offset: 0x000207C4
		public override string ToString()
		{
			return char.ToString(this);
		}

		/// <summary>Преобразует значение этого экземпляра в эквивалентное ему строковое представление с использованием указанных сведений об особенностях форматирования, связанных с языком и региональными параметрами.</summary>
		/// <param name="provider">(Зарезервирован.) Объект, предоставляющий сведения о форматировании, связанные с определенным языком и региональными параметрами.</param>
		/// <returns>Строковое представление значения данного экземпляра, определяемое параметром <paramref name="provider" />.</returns>
		// Token: 0x060007E6 RID: 2022 RVA: 0x000225C4 File Offset: 0x000207C4
		public string ToString(IFormatProvider provider)
		{
			return char.ToString(this);
		}

		/// <summary>Преобразует указанный символ Юникода в эквивалентное ему строковое представление.</summary>
		/// <param name="c">Знак Юникода, который необходимо преобразовать.</param>
		/// <returns>Строковое представление значения <paramref name="c" />.</returns>
		// Token: 0x060007E7 RID: 2023 RVA: 0x000225CD File Offset: 0x000207CD
		public static string ToString(char c)
		{
			return string.CreateFromChar(c);
		}

		/// <summary>Преобразует значение указанной строки в эквивалентный символ Юникода.</summary>
		/// <param name="s">Строка, содержащая один символ, или <see langword="null" />.</param>
		/// <returns>Символ Юникода, эквивалентный единственному символу в <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Длина <paramref name="s" /> не равна 1.</exception>
		// Token: 0x060007E8 RID: 2024 RVA: 0x000225D5 File Offset: 0x000207D5
		public static char Parse(string s)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (s.Length != 1)
			{
				throw new FormatException("String must be exactly one character long.");
			}
			return s[0];
		}

		/// <summary>Преобразует значение указанной строки в эквивалентный символ Юникода. Возвращает код, позволяющий определить, успешно ли выполнено преобразование.</summary>
		/// <param name="s">Строка, содержащая один символ, или <see langword="null" />.</param>
		/// <param name="result">По возвращении из этого метода содержит символ Юникода, эквивалентный единственному символу в <paramref name="s" />, если преобразование выполнено успешно, или значение без изменений, если преобразование завершилось неудачей. Преобразование не удается выполнить, если параметр <paramref name="s" /> имеет значение <see langword="null" /> или длина параметра <paramref name="s" /> не равна 1. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="s" /> успешно преобразован; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060007E9 RID: 2025 RVA: 0x00022600 File Offset: 0x00020800
		public static bool TryParse(string s, out char result)
		{
			result = '\0';
			if (s == null)
			{
				return false;
			}
			if (s.Length != 1)
			{
				return false;
			}
			result = s[0];
			return true;
		}

		/// <summary>Показывает, относится ли указанный символ Юникода к категории десятичных цифр.</summary>
		/// <param name="c">Знак Юникода, который необходимо вычислить.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="c" /> является десятичной цифрой; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060007EA RID: 2026 RVA: 0x0002261F File Offset: 0x0002081F
		public static bool IsDigit(char c)
		{
			if (char.IsLatin1(c))
			{
				return c >= '0' && c <= '9';
			}
			return CharUnicodeInfo.GetUnicodeCategory(c) == UnicodeCategory.DecimalDigitNumber;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00022642 File Offset: 0x00020842
		internal static bool CheckLetter(UnicodeCategory uc)
		{
			return uc <= UnicodeCategory.OtherLetter;
		}

		/// <summary>Показывает, относится ли указанный символ Юникода к категории букв Юникода.</summary>
		/// <param name="c">Знак Юникода, который необходимо вычислить.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="c" /> является буквой; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060007EC RID: 2028 RVA: 0x0002264B File Offset: 0x0002084B
		public static bool IsLetter(char c)
		{
			if (!char.IsLatin1(c))
			{
				return char.CheckLetter(CharUnicodeInfo.GetUnicodeCategory(c));
			}
			if (char.IsAscii(c))
			{
				c |= ' ';
				return c >= 'a' && c <= 'z';
			}
			return char.CheckLetter(char.GetLatin1UnicodeCategory(c));
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x0002268B File Offset: 0x0002088B
		private static bool IsWhiteSpaceLatin1(char c)
		{
			return c == ' ' || c - '\t' <= '\u0004' || c == '\u00a0' || c == '\u0085';
		}

		/// <summary>Показывает, относится ли указанный символ Юникода к категории пробелов.</summary>
		/// <param name="c">Знак Юникода, который необходимо вычислить.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="c" /> является пробелом; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060007EE RID: 2030 RVA: 0x000226AB File Offset: 0x000208AB
		public static bool IsWhiteSpace(char c)
		{
			if (char.IsLatin1(c))
			{
				return char.IsWhiteSpaceLatin1(c);
			}
			return CharUnicodeInfo.IsWhiteSpace(c);
		}

		/// <summary>Показывает, относится ли указанный символ Юникода к категории букв верхнего регистра.</summary>
		/// <param name="c">Знак Юникода, который необходимо вычислить.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="c" /> является буквой верхнего регистра; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060007EF RID: 2031 RVA: 0x000226C2 File Offset: 0x000208C2
		public static bool IsUpper(char c)
		{
			if (!char.IsLatin1(c))
			{
				return CharUnicodeInfo.GetUnicodeCategory(c) == UnicodeCategory.UppercaseLetter;
			}
			if (char.IsAscii(c))
			{
				return c >= 'A' && c <= 'Z';
			}
			return char.GetLatin1UnicodeCategory(c) == UnicodeCategory.UppercaseLetter;
		}

		/// <summary>Показывает, относится ли указанный символ Юникода к категории букв нижнего регистра.</summary>
		/// <param name="c">Знак Юникода, который необходимо вычислить.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="c" /> является буквой в нижнем регистре; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060007F0 RID: 2032 RVA: 0x000226F7 File Offset: 0x000208F7
		public static bool IsLower(char c)
		{
			if (!char.IsLatin1(c))
			{
				return CharUnicodeInfo.GetUnicodeCategory(c) == UnicodeCategory.LowercaseLetter;
			}
			if (char.IsAscii(c))
			{
				return c >= 'a' && c <= 'z';
			}
			return char.GetLatin1UnicodeCategory(c) == UnicodeCategory.LowercaseLetter;
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x0002272C File Offset: 0x0002092C
		internal static bool CheckPunctuation(UnicodeCategory uc)
		{
			return uc - UnicodeCategory.ConnectorPunctuation <= 6;
		}

		/// <summary>Показывает, относится ли указанный символ Юникода к категории знаков препинания.</summary>
		/// <param name="c">Знак Юникода, который необходимо вычислить.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="c" /> является знаком препинания; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060007F2 RID: 2034 RVA: 0x00022738 File Offset: 0x00020938
		public static bool IsPunctuation(char c)
		{
			if (char.IsLatin1(c))
			{
				return char.CheckPunctuation(char.GetLatin1UnicodeCategory(c));
			}
			return char.CheckPunctuation(CharUnicodeInfo.GetUnicodeCategory(c));
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00022759 File Offset: 0x00020959
		internal static bool CheckLetterOrDigit(UnicodeCategory uc)
		{
			return uc <= UnicodeCategory.OtherLetter || uc == UnicodeCategory.DecimalDigitNumber;
		}

		/// <summary>Показывает, относится ли указанный символ Юникода к категории букв или десятичных цифр.</summary>
		/// <param name="c">Знак Юникода, который необходимо вычислить.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="c" /> является буквой или десятичной цифрой; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060007F4 RID: 2036 RVA: 0x00022766 File Offset: 0x00020966
		public static bool IsLetterOrDigit(char c)
		{
			if (char.IsLatin1(c))
			{
				return char.CheckLetterOrDigit(char.GetLatin1UnicodeCategory(c));
			}
			return char.CheckLetterOrDigit(CharUnicodeInfo.GetUnicodeCategory(c));
		}

		/// <summary>Преобразует значение указанного символа Юникода в его эквивалент в верхнем регистре, используя указанные сведения о форматировании, связанные с языком и региональными параметрами.</summary>
		/// <param name="c">Знак Юникода, который необходимо преобразовать.</param>
		/// <param name="culture">Объект, задающий правила определения регистра для языка и региональных параметров.</param>
		/// <returns>Эквивалент <paramref name="c" /> в верхнем регистре, измененный согласно <paramref name="culture" />, или значение <paramref name="c" /> без изменений, если <paramref name="c" /> уже является буквой верхнего регистра, не имеет эквивалента в верхнем регистре или не является буквой алфавита.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="culture" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060007F5 RID: 2037 RVA: 0x00022787 File Offset: 0x00020987
		public static char ToUpper(char c, CultureInfo culture)
		{
			if (culture == null)
			{
				throw new ArgumentNullException("culture");
			}
			return culture.TextInfo.ToUpper(c);
		}

		/// <summary>Преобразует значение символа Юникода в эквивалентный символ верхнего регистра.</summary>
		/// <param name="c">Знак Юникода, который необходимо преобразовать.</param>
		/// <returns>Эквивалент параметра <paramref name="c" /> в верхнем регистре или значение <paramref name="c" /> без изменений, если <paramref name="c" /> уже является буквой верхнего регистра, не имеет эквивалента в верхнем регистре или не является буквой алфавита.</returns>
		// Token: 0x060007F6 RID: 2038 RVA: 0x000227A3 File Offset: 0x000209A3
		public static char ToUpper(char c)
		{
			return CultureInfo.CurrentCulture.TextInfo.ToUpper(c);
		}

		/// <summary>Преобразует значение символа Юникода в его эквивалент в верхнем регистре, используя правила изменения регистра, связанные с инвариантным языком и региональными параметрами.</summary>
		/// <param name="c">Знак Юникода, который необходимо преобразовать.</param>
		/// <returns>Эквивалент параметра <paramref name="c" /> в верхнем регистре или значение <paramref name="c" /> без изменений, если <paramref name="c" /> уже является буквой верхнего регистра или не является буквой алфавита.</returns>
		// Token: 0x060007F7 RID: 2039 RVA: 0x000227B5 File Offset: 0x000209B5
		public static char ToUpperInvariant(char c)
		{
			return CultureInfo.InvariantCulture.TextInfo.ToUpper(c);
		}

		/// <summary>Преобразует значение указанного символа Юникода в его эквивалент в нижнем регистре, используя указанные сведения о форматировании, связанные с языком и региональными параметрами.</summary>
		/// <param name="c">Знак Юникода, который необходимо преобразовать.</param>
		/// <param name="culture">Объект, задающий правила определения регистра для языка и региональных параметров.</param>
		/// <returns>Эквивалент <paramref name="c" /> в нижнем регистре, измененный согласно <paramref name="culture" />, или значение <paramref name="c" /> без изменений, если <paramref name="c" /> уже является буквой нижнего регистра или не является буквой алфавита.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="culture" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060007F8 RID: 2040 RVA: 0x000227C7 File Offset: 0x000209C7
		public static char ToLower(char c, CultureInfo culture)
		{
			if (culture == null)
			{
				throw new ArgumentNullException("culture");
			}
			return culture.TextInfo.ToLower(c);
		}

		/// <summary>Преобразует значение символа Юникода в его эквивалент в нижнем регистре.</summary>
		/// <param name="c">Знак Юникода, который необходимо преобразовать.</param>
		/// <returns>Эквивалент <paramref name="c" /> в нижнем регистре или значение <paramref name="c" /> без изменений, если <paramref name="c" /> уже является буквой нижнего регистра или не является буквой алфавита.</returns>
		// Token: 0x060007F9 RID: 2041 RVA: 0x000227E3 File Offset: 0x000209E3
		public static char ToLower(char c)
		{
			return CultureInfo.CurrentCulture.TextInfo.ToLower(c);
		}

		/// <summary>Преобразует значение символа Юникода в его эквивалент в нижнем регистре, используя правила изменения регистра, связанные с инвариантным языком и региональными параметрами.</summary>
		/// <param name="c">Знак Юникода, который необходимо преобразовать.</param>
		/// <returns>Эквивалент параметра <paramref name="c" /> в нижнем регистре или значение <paramref name="c" /> без изменений, если <paramref name="c" /> уже является буквой нижнего регистра или не является буквой алфавита.</returns>
		// Token: 0x060007FA RID: 2042 RVA: 0x000227F5 File Offset: 0x000209F5
		public static char ToLowerInvariant(char c)
		{
			return CultureInfo.InvariantCulture.TextInfo.ToLower(c);
		}

		/// <summary>Возвращает <see cref="T:System.TypeCode" /> для типа значения <see cref="T:System.Char" />.</summary>
		/// <returns>Константа перечислимого типа, <see cref="F:System.TypeCode.Char" />.</returns>
		// Token: 0x060007FB RID: 2043 RVA: 0x00022807 File Offset: 0x00020A07
		public TypeCode GetTypeCode()
		{
			return TypeCode.Char;
		}

		/// <summary>Примечание. Это преобразование не поддерживается. Попытка его выполнения приводит к созданию исключения <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Данное преобразование не поддерживается. Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x060007FC RID: 2044 RVA: 0x0002280A File Offset: 0x00020A0A
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "Char", "Boolean"));
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToChar(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Значение текущего объекта <see cref="T:System.Char" /> не изменилось.</returns>
		// Token: 0x060007FD RID: 2045 RVA: 0x00022825 File Offset: 0x00020A25
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return this;
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToSByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Преобразованное значение текущего объекта <see cref="T:System.Char" />.</returns>
		// Token: 0x060007FE RID: 2046 RVA: 0x00022829 File Offset: 0x00020A29
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Преобразованное значение текущего объекта <see cref="T:System.Char" />.</returns>
		// Token: 0x060007FF RID: 2047 RVA: 0x00022832 File Offset: 0x00020A32
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Преобразованное значение текущего объекта <see cref="T:System.Char" />.</returns>
		// Token: 0x06000800 RID: 2048 RVA: 0x0002283B File Offset: 0x00020A3B
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Объект <see cref="T:System.IFormatProvider" />. (Задавайте <see langword="null" />, поскольку параметр <paramref name="provider" /> игнорируется.)</param>
		/// <returns>Преобразованное значение текущего объекта <see cref="T:System.Char" />.</returns>
		// Token: 0x06000801 RID: 2049 RVA: 0x00022844 File Offset: 0x00020A44
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Преобразованное значение текущего объекта <see cref="T:System.Char" />.</returns>
		// Token: 0x06000802 RID: 2050 RVA: 0x0002284D File Offset: 0x00020A4D
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Объект <see cref="T:System.IFormatProvider" />. (Задавайте <see langword="null" />, поскольку параметр <paramref name="provider" /> игнорируется.)</param>
		/// <returns>Преобразованное значение текущего объекта <see cref="T:System.Char" />.</returns>
		// Token: 0x06000803 RID: 2051 RVA: 0x00022856 File Offset: 0x00020A56
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Преобразованное значение текущего объекта <see cref="T:System.Char" />.</returns>
		// Token: 0x06000804 RID: 2052 RVA: 0x0002285F File Offset: 0x00020A5F
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToUInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">Объект <see cref="T:System.IFormatProvider" />. (Задавайте <see langword="null" />, поскольку параметр <paramref name="provider" /> игнорируется.)</param>
		/// <returns>Преобразованное значение текущего объекта <see cref="T:System.Char" />.</returns>
		// Token: 0x06000805 RID: 2053 RVA: 0x00022868 File Offset: 0x00020A68
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		/// <summary>Примечание. Это преобразование не поддерживается. Попытка его выполнения приводит к созданию исключения <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x06000806 RID: 2054 RVA: 0x00022871 File Offset: 0x00020A71
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "Char", "Single"));
		}

		/// <summary>Примечание. Это преобразование не поддерживается. Попытка его выполнения приводит к созданию исключения <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x06000807 RID: 2055 RVA: 0x0002288C File Offset: 0x00020A8C
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "Char", "Double"));
		}

		/// <summary>Примечание. Это преобразование не поддерживается. Попытка его выполнения приводит к созданию исключения <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x06000808 RID: 2056 RVA: 0x000228A7 File Offset: 0x00020AA7
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "Char", "Decimal"));
		}

		/// <summary>Примечание. Это преобразование не поддерживается. Попытка его выполнения приводит к созданию исключения <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">Этот параметр не учитывается.</param>
		/// <returns>Возвращаемое значение отсутствует.</returns>
		/// <exception cref="T:System.InvalidCastException">Данное преобразование не поддерживается.</exception>
		// Token: 0x06000809 RID: 2057 RVA: 0x000228C2 File Offset: 0x00020AC2
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "Char", "DateTime"));
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)" />.</summary>
		/// <param name="type">Объект <see cref="T:System.Type" />.</param>
		/// <param name="provider">Объект <see cref="T:System.IFormatProvider" />.</param>
		/// <returns>Объект указанного типа.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Значение текущего объекта <see cref="T:System.Char" /> нельзя преобразовать в тип, заданный параметром <paramref name="type" />.</exception>
		// Token: 0x0600080A RID: 2058 RVA: 0x000228DD File Offset: 0x00020ADD
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		/// <summary>Показывает, относится ли указанный символ Юникода к категории управляющих символов.</summary>
		/// <param name="c">Знак Юникода, который необходимо вычислить.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="c" /> является управляющим символом; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600080B RID: 2059 RVA: 0x000228ED File Offset: 0x00020AED
		public static bool IsControl(char c)
		{
			if (char.IsLatin1(c))
			{
				return char.GetLatin1UnicodeCategory(c) == UnicodeCategory.Control;
			}
			return CharUnicodeInfo.GetUnicodeCategory(c) == UnicodeCategory.Control;
		}

		/// <summary>Показывает, относится ли символ в указанной позиции в указанной строке к категории управляющих символов.</summary>
		/// <param name="s">Строка.</param>
		/// <param name="index">Позиция символа, который необходимо вычислить в <paramref name="s" />.</param>
		/// <returns>Значение <see langword="true" />, если символ позиции <paramref name="index" /> в <paramref name="s" /> является управляющим; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> имеет значение меньше нуля или больше последней позиции в <paramref name="s" />.</exception>
		// Token: 0x0600080C RID: 2060 RVA: 0x0002290C File Offset: 0x00020B0C
		public static bool IsControl(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			char ch = s[index];
			if (char.IsLatin1(ch))
			{
				return char.GetLatin1UnicodeCategory(ch) == UnicodeCategory.Control;
			}
			return CharUnicodeInfo.GetUnicodeCategory(s, index) == UnicodeCategory.Control;
		}

		/// <summary>Показывает, относится ли указанный символ Юникода в указанной позиции в указанной строке к категории десятичных цифр.</summary>
		/// <param name="s">Строка.</param>
		/// <param name="index">Позиция символа, который необходимо вычислить в <paramref name="s" />.</param>
		/// <returns>
		///   <see langword="true" />, если символ в позиции <paramref name="index" /> в <paramref name="s" /> является десятичной цифрой; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> имеет значение меньше нуля или больше последней позиции в <paramref name="s" />.</exception>
		// Token: 0x0600080D RID: 2061 RVA: 0x00022964 File Offset: 0x00020B64
		public static bool IsDigit(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			char c = s[index];
			if (char.IsLatin1(c))
			{
				return c >= '0' && c <= '9';
			}
			return CharUnicodeInfo.GetUnicodeCategory(s, index) == UnicodeCategory.DecimalDigitNumber;
		}

		/// <summary>Показывает, относится ли символ в указанной позиции в указанной строке к категории букв Юникода.</summary>
		/// <param name="s">Строка.</param>
		/// <param name="index">Позиция символа, который необходимо вычислить в <paramref name="s" />.</param>
		/// <returns>Значение <see langword="true" />, если знак в позиции <paramref name="index" /> в <paramref name="s" /> является буквой; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> имеет значение меньше нуля или больше последней позиции в <paramref name="s" />.</exception>
		// Token: 0x0600080E RID: 2062 RVA: 0x000229C0 File Offset: 0x00020BC0
		public static bool IsLetter(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			char c = s[index];
			if (!char.IsLatin1(c))
			{
				return char.CheckLetter(CharUnicodeInfo.GetUnicodeCategory(s, index));
			}
			if (char.IsAscii(c))
			{
				c |= ' ';
				return c >= 'a' && c <= 'z';
			}
			return char.CheckLetter(char.GetLatin1UnicodeCategory(c));
		}

		/// <summary>Показывает, относится ли символ в указанной позиции в указанной строке к категории букв или десятичных цифр.</summary>
		/// <param name="s">Строка.</param>
		/// <param name="index">Позиция символа, который необходимо вычислить в <paramref name="s" />.</param>
		/// <returns>Значение <see langword="true" />, если знак в позиции <paramref name="index" /> в <paramref name="s" /> является буквой или десятичной цифрой; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> имеет значение меньше нуля или больше последней позиции в <paramref name="s" />.</exception>
		// Token: 0x0600080F RID: 2063 RVA: 0x00022A38 File Offset: 0x00020C38
		public static bool IsLetterOrDigit(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			char ch = s[index];
			if (char.IsLatin1(ch))
			{
				return char.CheckLetterOrDigit(char.GetLatin1UnicodeCategory(ch));
			}
			return char.CheckLetterOrDigit(CharUnicodeInfo.GetUnicodeCategory(s, index));
		}

		/// <summary>Показывает, относится ли указанный символ в указанной позиции в указанной строке к категории букв нижнего регистра.</summary>
		/// <param name="s">Строка.</param>
		/// <param name="index">Позиция символа, который необходимо вычислить в <paramref name="s" />.</param>
		/// <returns>Значение <see langword="true" />, если символ в позиции <paramref name="index" /> в <paramref name="s" /> является буквой в нижнем регистре; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> имеет значение меньше нуля или больше последней позиции в <paramref name="s" />.</exception>
		// Token: 0x06000810 RID: 2064 RVA: 0x00022A90 File Offset: 0x00020C90
		public static bool IsLower(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			char c = s[index];
			if (!char.IsLatin1(c))
			{
				return CharUnicodeInfo.GetUnicodeCategory(s, index) == UnicodeCategory.LowercaseLetter;
			}
			if (char.IsAscii(c))
			{
				return c >= 'a' && c <= 'z';
			}
			return char.GetLatin1UnicodeCategory(c) == UnicodeCategory.LowercaseLetter;
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00022AFB File Offset: 0x00020CFB
		internal static bool CheckNumber(UnicodeCategory uc)
		{
			return uc - UnicodeCategory.DecimalDigitNumber <= 2;
		}

		/// <summary>Показывает, относится ли указанный символ Юникода к категории цифр.</summary>
		/// <param name="c">Знак Юникода, который необходимо вычислить.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="c" /> является цифрой; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000812 RID: 2066 RVA: 0x00022B06 File Offset: 0x00020D06
		public static bool IsNumber(char c)
		{
			if (!char.IsLatin1(c))
			{
				return char.CheckNumber(CharUnicodeInfo.GetUnicodeCategory(c));
			}
			if (char.IsAscii(c))
			{
				return c >= '0' && c <= '9';
			}
			return char.CheckNumber(char.GetLatin1UnicodeCategory(c));
		}

		/// <summary>Показывает, относится ли указанный символ в указанной позиции в указанной строке к категории цифр.</summary>
		/// <param name="s">Строка.</param>
		/// <param name="index">Позиция символа, который необходимо вычислить в <paramref name="s" />.</param>
		/// <returns>Значение <see langword="true" />, если символ в позиции <paramref name="index" /> в <paramref name="s" /> является цифрой; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> имеет значение меньше нуля или больше последней позиции в <paramref name="s" />.</exception>
		// Token: 0x06000813 RID: 2067 RVA: 0x00022B40 File Offset: 0x00020D40
		public static bool IsNumber(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			char c = s[index];
			if (!char.IsLatin1(c))
			{
				return char.CheckNumber(CharUnicodeInfo.GetUnicodeCategory(s, index));
			}
			if (char.IsAscii(c))
			{
				return c >= '0' && c <= '9';
			}
			return char.CheckNumber(char.GetLatin1UnicodeCategory(c));
		}

		/// <summary>Показывает, относится ли указанный символ в указанной позиции в указанной строке к категории знаков препинания.</summary>
		/// <param name="s">Строка.</param>
		/// <param name="index">Позиция символа, который необходимо вычислить в <paramref name="s" />.</param>
		/// <returns>Значение <see langword="true" />, если знак в позиции <paramref name="index" /> в <paramref name="s" /> является знаком препинания; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> имеет значение меньше нуля или больше последней позиции в <paramref name="s" />.</exception>
		// Token: 0x06000814 RID: 2068 RVA: 0x00022BB0 File Offset: 0x00020DB0
		public static bool IsPunctuation(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			char ch = s[index];
			if (char.IsLatin1(ch))
			{
				return char.CheckPunctuation(char.GetLatin1UnicodeCategory(ch));
			}
			return char.CheckPunctuation(CharUnicodeInfo.GetUnicodeCategory(s, index));
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00022C07 File Offset: 0x00020E07
		internal static bool CheckSeparator(UnicodeCategory uc)
		{
			return uc - UnicodeCategory.SpaceSeparator <= 2;
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00022C13 File Offset: 0x00020E13
		private static bool IsSeparatorLatin1(char c)
		{
			return c == ' ' || c == '\u00a0';
		}

		/// <summary>Показывает, относится ли указанный символ Юникода к категории знаков-разделителей.</summary>
		/// <param name="c">Знак Юникода, который необходимо вычислить.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="c" /> является знаком-разделителем; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000817 RID: 2071 RVA: 0x00022C24 File Offset: 0x00020E24
		public static bool IsSeparator(char c)
		{
			if (char.IsLatin1(c))
			{
				return char.IsSeparatorLatin1(c);
			}
			return char.CheckSeparator(CharUnicodeInfo.GetUnicodeCategory(c));
		}

		/// <summary>Показывает, относится ли указанный символ в указанной позиции в указанной строке к категории знаков-разделителей.</summary>
		/// <param name="s">Строка.</param>
		/// <param name="index">Позиция символа, который необходимо вычислить в <paramref name="s" />.</param>
		/// <returns>Значение <see langword="true" />, если символ в позиции <paramref name="index" /> в <paramref name="s" /> является знаком-разделителем; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> имеет значение меньше нуля или больше последней позиции в <paramref name="s" />.</exception>
		// Token: 0x06000818 RID: 2072 RVA: 0x00022C40 File Offset: 0x00020E40
		public static bool IsSeparator(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			char c = s[index];
			if (char.IsLatin1(c))
			{
				return char.IsSeparatorLatin1(c);
			}
			return char.CheckSeparator(CharUnicodeInfo.GetUnicodeCategory(s, index));
		}

		/// <summary>Указывает, имеет ли заданный символ заменяющую кодовую единицу.</summary>
		/// <param name="c">Знак Юникода, который необходимо вычислить.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="c" /> имеет большее или меньшее заменяющее значение; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000819 RID: 2073 RVA: 0x00022C92 File Offset: 0x00020E92
		public static bool IsSurrogate(char c)
		{
			return c >= '\ud800' && c <= '\udfff';
		}

		/// <summary>Указывает, имеет ли указанный символ в указанной позиции в указанной строке заменяющую кодовую единицу.</summary>
		/// <param name="s">Строка.</param>
		/// <param name="index">Позиция символа, который необходимо вычислить в <paramref name="s" />.</param>
		/// <returns>Значение <see langword="true" />, если символ в позиции <paramref name="index" /> в <paramref name="s" /> является большим или меньшим заменяющим значением; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> имеет значение меньше нуля или больше последней позиции в <paramref name="s" />.</exception>
		// Token: 0x0600081A RID: 2074 RVA: 0x00022CA9 File Offset: 0x00020EA9
		public static bool IsSurrogate(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return char.IsSurrogate(s[index]);
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00022CD9 File Offset: 0x00020ED9
		internal static bool CheckSymbol(UnicodeCategory uc)
		{
			return uc - UnicodeCategory.MathSymbol <= 3;
		}

		/// <summary>Показывает, относится ли указанный символ Юникода к категории символьных знаков.</summary>
		/// <param name="c">Знак Юникода, который необходимо вычислить.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="c" /> является символьным знаком; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600081C RID: 2076 RVA: 0x00022CE5 File Offset: 0x00020EE5
		public static bool IsSymbol(char c)
		{
			if (char.IsLatin1(c))
			{
				return char.CheckSymbol(char.GetLatin1UnicodeCategory(c));
			}
			return char.CheckSymbol(CharUnicodeInfo.GetUnicodeCategory(c));
		}

		/// <summary>Показывает, относится ли указанный символ в указанной позиции в указанной строке к категории символьных знаков.</summary>
		/// <param name="s">Строка.</param>
		/// <param name="index">Позиция символа, который необходимо вычислить в <paramref name="s" />.</param>
		/// <returns>Значение <see langword="true" />, если символ в позиции <paramref name="index" /> в <paramref name="s" /> является символьным знаком; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> имеет значение меньше нуля или больше последней позиции в <paramref name="s" />.</exception>
		// Token: 0x0600081D RID: 2077 RVA: 0x00022D08 File Offset: 0x00020F08
		public static bool IsSymbol(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			char ch = s[index];
			if (char.IsLatin1(ch))
			{
				return char.CheckSymbol(char.GetLatin1UnicodeCategory(ch));
			}
			return char.CheckSymbol(CharUnicodeInfo.GetUnicodeCategory(s, index));
		}

		/// <summary>Показывает, относится ли указанный символ в указанной позиции в указанной строке к категории букв верхнего регистра.</summary>
		/// <param name="s">Строка.</param>
		/// <param name="index">Позиция символа, который необходимо вычислить в <paramref name="s" />.</param>
		/// <returns>Значение <see langword="true" />, если сивел в позиции <paramref name="index" /> в <paramref name="s" /> является буквой верхнего регистра; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> имеет значение меньше нуля или больше последней позиции в <paramref name="s" />.</exception>
		// Token: 0x0600081E RID: 2078 RVA: 0x00022D60 File Offset: 0x00020F60
		public static bool IsUpper(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			char c = s[index];
			if (!char.IsLatin1(c))
			{
				return CharUnicodeInfo.GetUnicodeCategory(s, index) == UnicodeCategory.UppercaseLetter;
			}
			if (char.IsAscii(c))
			{
				return c >= 'A' && c <= 'Z';
			}
			return char.GetLatin1UnicodeCategory(c) == UnicodeCategory.UppercaseLetter;
		}

		/// <summary>Показывает, относится ли указанный символ в указанной позиции в указанной строке к категории пробелов.</summary>
		/// <param name="s">Строка.</param>
		/// <param name="index">Позиция символа, который необходимо вычислить в <paramref name="s" />.</param>
		/// <returns>Значение <see langword="true" />, если символ в позиции <paramref name="index" /> в <paramref name="s" /> является пробелом; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> имеет значение меньше нуля или больше последней позиции в <paramref name="s" />.</exception>
		// Token: 0x0600081F RID: 2079 RVA: 0x00022DCC File Offset: 0x00020FCC
		public static bool IsWhiteSpace(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (char.IsLatin1(s[index]))
			{
				return char.IsWhiteSpaceLatin1(s[index]);
			}
			return CharUnicodeInfo.IsWhiteSpace(s, index);
		}

		/// <summary>Относит указанный символ Юникода к группе, определенной одним из значений <see cref="T:System.Globalization.UnicodeCategory" />.</summary>
		/// <param name="c">Знак Юникода, который подлежит категоризации.</param>
		/// <returns>Значение <see cref="T:System.Globalization.UnicodeCategory" />, которое определяет группу, содержащую <paramref name="c" />.</returns>
		// Token: 0x06000820 RID: 2080 RVA: 0x00022E1D File Offset: 0x0002101D
		public static UnicodeCategory GetUnicodeCategory(char c)
		{
			if (char.IsLatin1(c))
			{
				return char.GetLatin1UnicodeCategory(c);
			}
			return CharUnicodeInfo.GetUnicodeCategory((int)c);
		}

		/// <summary>Относит символ Юникода в указанной позиции к группе, определенной одним из значений <see cref="T:System.Globalization.UnicodeCategory" />.</summary>
		/// <param name="s">Объект <see cref="T:System.String" />.</param>
		/// <param name="index">Позиция символа в <paramref name="s" />.</param>
		/// <returns>Перечислимая константа <see cref="T:System.Globalization.UnicodeCategory" />, определяющая группу, которая содержит символ в позиции <paramref name="index" /> в <paramref name="s" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> имеет значение меньше нуля или больше последней позиции в <paramref name="s" />.</exception>
		// Token: 0x06000821 RID: 2081 RVA: 0x00022E34 File Offset: 0x00021034
		public static UnicodeCategory GetUnicodeCategory(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (char.IsLatin1(s[index]))
			{
				return char.GetLatin1UnicodeCategory(s[index]);
			}
			return CharUnicodeInfo.InternalGetUnicodeCategory(s, index);
		}

		/// <summary>Преобразует указанный числовой символ Юникода в число двойной точности с плавающей запятой.</summary>
		/// <param name="c">Знак Юникода, который необходимо преобразовать.</param>
		/// <returns>Числовое значение параметра <paramref name="c" />, если данный символ представляет число; в противном случае — значение -1,0.</returns>
		// Token: 0x06000822 RID: 2082 RVA: 0x00022E85 File Offset: 0x00021085
		public static double GetNumericValue(char c)
		{
			return CharUnicodeInfo.GetNumericValue(c);
		}

		/// <summary>Преобразует числовой символ Юникода в указанной позиции в указанной строке в число двойной точности с плавающей запятой.</summary>
		/// <param name="s">Объект <see cref="T:System.String" />.</param>
		/// <param name="index">Позиция символа в <paramref name="s" />.</param>
		/// <returns>Числовое значение символа в позиции <paramref name="index" /> в <paramref name="s" />, если данный символ представляет число; в противном случае — значение -1.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="index" /> имеет значение меньше нуля или больше последней позиции в <paramref name="s" />.</exception>
		// Token: 0x06000823 RID: 2083 RVA: 0x00022E8D File Offset: 0x0002108D
		public static double GetNumericValue(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return CharUnicodeInfo.GetNumericValue(s, index);
		}

		/// <summary>Определяет, является ли заданный объект <see cref="T:System.Char" /> старшим символом-заместителем.</summary>
		/// <param name="c">Знак Юникода, который необходимо вычислить.</param>
		/// <returns>Значение <see langword="true" />, если числовое значение параметра <paramref name="c" /> лежит в диапазоне от U+D800 до U+DBFF; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000824 RID: 2084 RVA: 0x00022EB8 File Offset: 0x000210B8
		public static bool IsHighSurrogate(char c)
		{
			return c >= '\ud800' && c <= '\udbff';
		}

		/// <summary>Определяет, является ли объект <see cref="T:System.Char" /> в заданной позиции в строке старшим символом-заместителем.</summary>
		/// <param name="s">Строка.</param>
		/// <param name="index">Позиция символа, который необходимо вычислить в <paramref name="s" />.</param>
		/// <returns>Значение <see langword="true" />, если числовое значение заданного символа в параметре <paramref name="s" /> лежит в диапазоне от U+D800 до U+DBFF; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> не является позицией в <paramref name="s" />.</exception>
		// Token: 0x06000825 RID: 2085 RVA: 0x00022ECF File Offset: 0x000210CF
		public static bool IsHighSurrogate(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index < 0 || index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return char.IsHighSurrogate(s[index]);
		}

		/// <summary>Определяет, является ли заданный объект <see cref="T:System.Char" /> младшим символом-заместителем.</summary>
		/// <param name="c">Символ, который необходимо вычислить.</param>
		/// <returns>Значение <see langword="true" />, если числовое значение параметра <paramref name="c" /> лежит в диапазоне от U+DC00 до U+DFFF; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000826 RID: 2086 RVA: 0x00022F03 File Offset: 0x00021103
		public static bool IsLowSurrogate(char c)
		{
			return c >= '\udc00' && c <= '\udfff';
		}

		/// <summary>Определяет, является ли объект <see cref="T:System.Char" /> в заданной позиции в строке младшим символом-заместителем.</summary>
		/// <param name="s">Строка.</param>
		/// <param name="index">Позиция символа, который необходимо вычислить в <paramref name="s" />.</param>
		/// <returns>Значение <see langword="true" />, если числовое значение заданного символа в параметре <paramref name="s" /> лежит в диапазоне от U+DC00 до U+DFFF; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> не является позицией в <paramref name="s" />.</exception>
		// Token: 0x06000827 RID: 2087 RVA: 0x00022F1A File Offset: 0x0002111A
		public static bool IsLowSurrogate(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index < 0 || index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return char.IsLowSurrogate(s[index]);
		}

		/// <summary>Определяет, образуют ли два смежных объекта <see cref="T:System.Char" /> в заданной позиции в строке суррогатную пару.</summary>
		/// <param name="s">Строка.</param>
		/// <param name="index">Начальная позиция пары символов для вычисления в строке <paramref name="s" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="s" /> включает соседние знаки в позициях <paramref name="index" /> и <paramref name="index" /> + 1, числовое значение знака в позиции <paramref name="index" /> лежит в диапазоне от U+D800 до U+DBFF и числовое значение знака в позиции <paramref name="index" /> +1 лежит в диапазоне от U+DC00 до U+DFFF; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> не является позицией в <paramref name="s" />.</exception>
		// Token: 0x06000828 RID: 2088 RVA: 0x00022F50 File Offset: 0x00021150
		public static bool IsSurrogatePair(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index < 0 || index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return index + 1 < s.Length && char.IsSurrogatePair(s[index], s[index + 1]);
		}

		/// <summary>Определяет, образуют ли два заданных объекта <see cref="T:System.Char" /> суррогатную пару.</summary>
		/// <param name="highSurrogate">Символ, который необходимо вычислить в качестве старшего знака-заменителя в паре.</param>
		/// <param name="lowSurrogate">Символ, который необходимо вычислить в качестве младшего знака-заменителя в паре.</param>
		/// <returns>Значение <see langword="true" />, если числовое значение параметра <paramref name="highSurrogate" /> лежит в диапазоне от U+D800 до U+DBFF, а числовое значение параметра <paramref name="lowSurrogate" /> лежит в диапазоне от U+DC00 до U+DFFF; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000829 RID: 2089 RVA: 0x00022FA5 File Offset: 0x000211A5
		public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate)
		{
			return highSurrogate >= '\ud800' && highSurrogate <= '\udbff' && lowSurrogate >= '\udc00' && lowSurrogate <= '\udfff';
		}

		/// <summary>Преобразует заданную кодовую точку Юникода в строку в кодировке UTF-16.</summary>
		/// <param name="utf32">21-битовая кодовая точка Юникода.</param>
		/// <returns>Строка, состоящая из одного объекта <see cref="T:System.Char" /> или суррогатной пары объектов <see cref="T:System.Char" />, эквивалентной кодовой точке, заданной в параметре <paramref name="utf32" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="utf32" /> является недопустимой 21-битовой кодовой точкой Юникода, входящей в диапазон начиная от U+0 до U+10FFFF, за исключением суррогатной пары в диапазоне от U+D800 до U+DBFF.</exception>
		// Token: 0x0600082A RID: 2090 RVA: 0x00022FD0 File Offset: 0x000211D0
		public unsafe static string ConvertFromUtf32(int utf32)
		{
			if (utf32 < 0 || utf32 > 1114111 || (utf32 >= 55296 && utf32 <= 57343))
			{
				throw new ArgumentOutOfRangeException("utf32", "A valid UTF32 value is between 0x000000 and 0x10ffff, inclusive, and should not include surrogate codepoint values (0x00d800 ~ 0x00dfff).");
			}
			if (utf32 < 65536)
			{
				return char.ToString((char)utf32);
			}
			utf32 -= 65536;
			uint num = 0U;
			char* ptr = (char*)(&num);
			*ptr = (char)(utf32 / 1024 + 55296);
			ptr[1] = (char)(utf32 % 1024 + 56320);
			return new string(ptr, 0, 2);
		}

		/// <summary>Преобразует значение суррогатной пары в кодировке UTF-16 в кодовую точку Юникода.</summary>
		/// <param name="highSurrogate">Старшая замещающая единица кода (то есть единица кода в диапазоне от U+D800 до U+DBFF).</param>
		/// <param name="lowSurrogate">Младшая замещающая единица кода (то есть единица кода в диапазоне от U+DC00 до U+DFFF).</param>
		/// <returns>21-битовая кодовая точка Юникода, представленная параметрами <paramref name="highSurrogate" /> и <paramref name="lowSurrogate" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="highSurrogate" /> не находится в диапазоне от U+D800 до U+DBFF или <paramref name="lowSurrogate" /> не находится в диапазоне от U+DC00 до U+DFFF.</exception>
		// Token: 0x0600082B RID: 2091 RVA: 0x00023054 File Offset: 0x00021254
		public static int ConvertToUtf32(char highSurrogate, char lowSurrogate)
		{
			if (!char.IsHighSurrogate(highSurrogate))
			{
				throw new ArgumentOutOfRangeException("highSurrogate", "A valid high surrogate character is between 0xd800 and 0xdbff, inclusive.");
			}
			if (!char.IsLowSurrogate(lowSurrogate))
			{
				throw new ArgumentOutOfRangeException("lowSurrogate", "A valid low surrogate character is between 0xdc00 and 0xdfff, inclusive.");
			}
			return (int)((highSurrogate - '\ud800') * 'Ѐ' + (lowSurrogate - '\udc00')) + 65536;
		}

		/// <summary>Преобразует значение символа в кодировке UTF-16 или суррогатную пару в заданной позиции в строке в кодовую точку Юникода.</summary>
		/// <param name="s">Строка, содержащая символ или суррогатную пару.</param>
		/// <param name="index">Позиция индекса символа или суррогатной пары в <paramref name="s" />.</param>
		/// <returns>21-битовая кодовая точка Юникода, представленная символом или суррогатной парой в позиции в строке <paramref name="s" />, заданной параметром <paramref name="index" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="s" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> не является позицией в <paramref name="s" />.</exception>
		/// <exception cref="T:System.ArgumentException">Заданная позиция индекса содержит суррогатную пару. Первый символ в паре не является допустимым старшим заместителем, или второй символ в паре не является допустимым младшим заместителем.</exception>
		// Token: 0x0600082C RID: 2092 RVA: 0x000230AC File Offset: 0x000212AC
		public static int ConvertToUtf32(string s, int index)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			if (index < 0 || index >= s.Length)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			int num = (int)(s[index] - '\ud800');
			if (num < 0 || num > 2047)
			{
				return (int)s[index];
			}
			if (num > 1023)
			{
				throw new ArgumentException(SR.Format("Found a low surrogate char without a preceding high surrogate at index: {0}. The input may not be in this encoding, or may not contain valid Unicode (UTF-16) characters.", index), "s");
			}
			if (index >= s.Length - 1)
			{
				throw new ArgumentException(SR.Format("Found a high surrogate char without a following low surrogate at index: {0}. The input may not be in this encoding, or may not contain valid Unicode (UTF-16) characters.", index), "s");
			}
			int num2 = (int)(s[index + 1] - '\udc00');
			if (num2 >= 0 && num2 <= 1023)
			{
				return num * 1024 + num2 + 65536;
			}
			throw new ArgumentException(SR.Format("Found a high surrogate char without a following low surrogate at index: {0}. The input may not be in this encoding, or may not contain valid Unicode (UTF-16) characters.", index), "s");
		}

		// Token: 0x04001078 RID: 4216
		private readonly char m_value;

		/// <summary>Представляет наибольшее возможное значение типа <see cref="T:System.Char" />. Это поле является константой.</summary>
		// Token: 0x04001079 RID: 4217
		public const char MaxValue = '￿';

		/// <summary>Представляет минимально допустимое значение типа <see cref="T:System.Char" />. Это поле является константой.</summary>
		// Token: 0x0400107A RID: 4218
		public const char MinValue = '\0';

		// Token: 0x0400107B RID: 4219
		private static readonly byte[] s_categoryForLatin1 = new byte[]
		{
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			11,
			24,
			24,
			24,
			26,
			24,
			24,
			24,
			20,
			21,
			24,
			25,
			24,
			19,
			24,
			24,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			24,
			24,
			25,
			25,
			25,
			24,
			24,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			20,
			24,
			21,
			27,
			18,
			27,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			20,
			25,
			21,
			25,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			11,
			24,
			26,
			26,
			26,
			26,
			28,
			28,
			27,
			28,
			1,
			22,
			25,
			19,
			28,
			27,
			28,
			25,
			10,
			10,
			27,
			1,
			28,
			24,
			27,
			10,
			1,
			23,
			10,
			10,
			10,
			24,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			25,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			25,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1
		};

		// Token: 0x0400107C RID: 4220
		internal const int UNICODE_PLANE00_END = 65535;

		// Token: 0x0400107D RID: 4221
		internal const int UNICODE_PLANE01_START = 65536;

		// Token: 0x0400107E RID: 4222
		internal const int UNICODE_PLANE16_END = 1114111;

		// Token: 0x0400107F RID: 4223
		internal const int HIGH_SURROGATE_START = 55296;

		// Token: 0x04001080 RID: 4224
		internal const int LOW_SURROGATE_END = 57343;
	}
}
