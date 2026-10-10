using System;

namespace System.Globalization
{
	/// <summary>Определяет стили, разрешенные в аргументах числовой строки, передаваемые методам <see langword="Parse" /> и <see langword="TryParse" /> целочисленных типов и числовых типов с плавающей запяой.</summary>
	// Token: 0x0200096D RID: 2413
	[Flags]
	public enum NumberStyles
	{
		/// <summary>Указывает, что элементы стиля, такие как начальные или конечные пробел, тысячи сепараторы или десятичного разделителя, не могут присутствовать в анализируемой строки. Анализируемая строка должна состоять только из целых десятичных чисел.</summary>
		// Token: 0x040034D1 RID: 13521
		None = 0,
		/// <summary>Указывает, что анализируемая строка может начинаться со знаков пробела. Допустимые знаки пробела имеют следующие значения в кодировке Юникод: U+0009, U+000A, U+000B, U+000C, U+000D и U+0020. Обратите внимание, что это подмножество символов, для которых метод <see cref="M:System.Char.IsWhiteSpace(System.Char)" /> возвращает значение <see langword="true" />.</summary>
		// Token: 0x040034D2 RID: 13522
		AllowLeadingWhite = 1,
		/// <summary>Указывает, что анализируемая строка может оканчиваться знаками пробела. Допустимые знаки пробела имеют следующие значения в кодировке Юникод: U+0009, U+000A, U+000B, U+000C, U+000D и U+0020. Обратите внимание, что это подмножество символов, для которых метод <see cref="M:System.Char.IsWhiteSpace(System.Char)" /> возвращает значение <see langword="true" />.</summary>
		// Token: 0x040034D3 RID: 13523
		AllowTrailingWhite = 2,
		/// <summary>Указывает, что числовая строка может включать начальный знак. Допустимые начальные знаки определяются свойствами <see cref="P:System.Globalization.NumberFormatInfo.PositiveSign" /> и <see cref="P:System.Globalization.NumberFormatInfo.NegativeSign" />.</summary>
		// Token: 0x040034D4 RID: 13524
		AllowLeadingSign = 4,
		/// <summary>Указывает, что числовая строка может включать конечный знак. Допустимые конечные знаки определяются свойствами <see cref="P:System.Globalization.NumberFormatInfo.PositiveSign" /> и <see cref="P:System.Globalization.NumberFormatInfo.NegativeSign" />.</summary>
		// Token: 0x040034D5 RID: 13525
		AllowTrailingSign = 8,
		/// <summary>Указывает, что в числовой строке может находиться одна пара скобок, в которых заключено число. Скобки означают, что анализируемая строка представляет отрицательное число.</summary>
		// Token: 0x040034D6 RID: 13526
		AllowParentheses = 16,
		/// <summary>Указывает, что числовая строка может включать десятичный разделитель. Если значение <see cref="T:System.Globalization.NumberStyles" /> включает флаг <see cref="F:System.Globalization.NumberStyles.AllowCurrencySymbol" /> и анализируемая строка включает обозначение денежной единицы, символ десятичного разделителя определяется свойством <see cref="P:System.Globalization.NumberFormatInfo.CurrencyDecimalSeparator" />. В противном случае символ десятичного разделителя определяется свойством <see cref="P:System.Globalization.NumberFormatInfo.NumberDecimalSeparator" />.</summary>
		// Token: 0x040034D7 RID: 13527
		AllowDecimalPoint = 32,
		/// <summary>Указывает, что в числовой строке могут находиться разделители групп, например символы, отделяющие сотни от тысяч. Если значение <see cref="T:System.Globalization.NumberStyles" /> включает флаг <see cref="F:System.Globalization.NumberStyles.AllowCurrencySymbol" /> и анализируемая строка содержит обозначение денежной единицы, допустимый разделитель группы определяется свойством <see cref="P:System.Globalization.NumberFormatInfo.CurrencyGroupSeparator" />, и количество цифр в каждой группе определяется свойством <see cref="P:System.Globalization.NumberFormatInfo.CurrencyGroupSizes" />. В противном случае допустимый разделитель групп определяется свойством <see cref="P:System.Globalization.NumberFormatInfo.NumberGroupSeparator" />, а количество цифр в каждой группе определяется свойством <see cref="P:System.Globalization.NumberFormatInfo.NumberGroupSizes" />.</summary>
		// Token: 0x040034D8 RID: 13528
		AllowThousands = 64,
		/// <summary>Указывает, что числовая строка может быть в экспоненциальном представлении. Флаг <see cref="F:System.Globalization.NumberStyles.AllowExponent" /> позволяет включить в разбираемую строку экспоненту, начинающуюся с символа E или e, за которым следует необязательный положительный или отрицательный знак и целое число. Другими словами, он успешно выполняет анализ строки в форме nnnExx, nnnE+xx и nnnE-xx. Он не допускает наличия десятичного разделителя или знака в значащей части числа, или мантиссе; чтобы разрешить эти элементы в анализируемой строке, используйте флаги <see cref="F:System.Globalization.NumberStyles.AllowDecimalPoint" /> и <see cref="F:System.Globalization.NumberStyles.AllowLeadingSign" /> или составной стиль, включающий эти отдельные флаги.</summary>
		// Token: 0x040034D9 RID: 13529
		AllowExponent = 128,
		/// <summary>Указывает, что числовая строка может содержать символ денежной единицы. Допустимые символы денежных единиц определяются свойством <see cref="P:System.Globalization.NumberFormatInfo.CurrencySymbol" />.</summary>
		// Token: 0x040034DA RID: 13530
		AllowCurrencySymbol = 256,
		/// <summary>Указывает, что числовая строка представляет шестнадцатеричное значение. К допустимым шестнадцатеричным значениям относятся цифры 0-9 и шестнадцатеричные знаки A-F и a-f. Строки, которые анализируются с помощью этого стиля, не могут иметь префикс "0x" или "&amp;h". Строка, анализируемая с использованием стиля <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" />, всегда интерпретируется как шестнадцатеричное значение. С флагом <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> можно объединять только флаги <see cref="F:System.Globalization.NumberStyles.AllowLeadingWhite" /> и <see cref="F:System.Globalization.NumberStyles.AllowTrailingWhite" />. Перечисление <see cref="T:System.Globalization.NumberStyles" /> включает составной стиль <see cref="F:System.Globalization.NumberStyles.HexNumber" />, состоящий из этих трех флагов.</summary>
		// Token: 0x040034DB RID: 13531
		AllowHexSpecifier = 512,
		/// <summary>Указывает, что используются стили <see cref="F:System.Globalization.NumberStyles.AllowLeadingWhite" />, <see cref="F:System.Globalization.NumberStyles.AllowTrailingWhite" /> и <see cref="F:System.Globalization.NumberStyles.AllowLeadingSign" />. Это стили составного числа.</summary>
		// Token: 0x040034DC RID: 13532
		Integer = 7,
		/// <summary>Указывает, что используются стили <see cref="F:System.Globalization.NumberStyles.AllowLeadingWhite" />, <see cref="F:System.Globalization.NumberStyles.AllowTrailingWhite" /> и <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" />. Это стили составного числа.</summary>
		// Token: 0x040034DD RID: 13533
		HexNumber = 515,
		/// <summary>Указывает, что используются стили <see cref="F:System.Globalization.NumberStyles.AllowLeadingWhite" />, <see cref="F:System.Globalization.NumberStyles.AllowTrailingWhite" />, <see cref="F:System.Globalization.NumberStyles.AllowLeadingSign" />, <see cref="F:System.Globalization.NumberStyles.AllowTrailingSign" />, <see cref="F:System.Globalization.NumberStyles.AllowDecimalPoint" /> и <see cref="F:System.Globalization.NumberStyles.AllowThousands" />. Это стили составного числа.</summary>
		// Token: 0x040034DE RID: 13534
		Number = 111,
		/// <summary>Указывает, что используются стили <see cref="F:System.Globalization.NumberStyles.AllowLeadingWhite" />, <see cref="F:System.Globalization.NumberStyles.AllowTrailingWhite" />, <see cref="F:System.Globalization.NumberStyles.AllowLeadingSign" />, <see cref="F:System.Globalization.NumberStyles.AllowDecimalPoint" /> и <see cref="F:System.Globalization.NumberStyles.AllowExponent" />. Это стили составного числа.</summary>
		// Token: 0x040034DF RID: 13535
		Float = 167,
		/// <summary>Указывает, что используются все стили, кроме <see cref="F:System.Globalization.NumberStyles.AllowExponent" /> и <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" />. Это стили составного числа.</summary>
		// Token: 0x040034E0 RID: 13536
		Currency = 383,
		/// <summary>Указывает, что используются все стили, кроме <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" />. Это стили составного числа.</summary>
		// Token: 0x040034E1 RID: 13537
		Any = 511
	}
}
