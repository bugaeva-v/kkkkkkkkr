using System;

namespace System.Data.OleDb
{
	/// <summary>Возвращает сведения о литералах, используемых в текстовых командах, значениях данных и объектах баз данных.</summary>
	// Token: 0x0200016A RID: 362
	[MonoTODO("OleDb is not implemented.")]
	public enum OleDbLiteral
	{
		/// <summary>Двоичный литерал в текстовой команде. Отображается в DBLITERAL_BINARY_LITERAL.</summary>
		// Token: 0x04000BD6 RID: 3030
		Binary_Literal = 1,
		/// <summary>Имя каталога в текстовой команде. Отображается в DBLITERAL_CATALOG_NAME.</summary>
		// Token: 0x04000BD7 RID: 3031
		Catalog_Name,
		/// <summary>Знак, отделяющий имя каталога от остальной части идентификатора в текстовой команде. Отображается в DBLITERAL_CATALOG_SEPARATOR.</summary>
		// Token: 0x04000BD8 RID: 3032
		Catalog_Separator,
		/// <summary>Символьный литерал в текстовой команде. Отображается в DBLITERAL_CHAR_LITERAL.</summary>
		// Token: 0x04000BD9 RID: 3033
		Char_Literal,
		/// <summary>Псевдоним столбца в текстовой команде. Отображается в DBLITERAL_COLUMN_ALIAS.</summary>
		// Token: 0x04000BDA RID: 3034
		Column_Alias,
		/// <summary>Имя столбца, используемое в текстовой команде или в интерфейсе определения данных. Отображается в DBLITERAL_COLUMN_NAME.</summary>
		// Token: 0x04000BDB RID: 3035
		Column_Name,
		/// <summary>Имя корреляции (псевдоним таблицы) в текстовой команде. Отображается в DBLITERAL_CORRELATION_NAME.</summary>
		// Token: 0x04000BDC RID: 3036
		Correlation_Name,
		/// <summary>Имя куба в составе схемы (или каталога, если поставщик не поддерживает схемы).</summary>
		// Token: 0x04000BDD RID: 3037
		Cube_Name = 21,
		/// <summary>Имя курсора в текстовой команде. Отображается в DBLITERAL_CURSOR_NAME.</summary>
		// Token: 0x04000BDE RID: 3038
		Cursor_Name = 8,
		/// <summary>Имя размерности. Если данная размерность входит в состав нескольких кубов, здесь указывается одна строка для каждого сочетания "куб-размерность".</summary>
		// Token: 0x04000BDF RID: 3039
		Dimension_Name = 22,
		/// <summary>Знак, используемый в выражении LIKE в качестве подстановочного знака для символа, возвращаемого для литерала DBLITERAL_LIKE_PERCENT. Например, если знак процента (%) служит для обозначения нескольких символов (возможно, нулевого их числа) и указана обратная косая черта (\), последовательность знаков "abc\%%" соответствует всем символьным значениям, начинающимся с "abc%". В некоторых диалектах SQL предусмотрено специальное выражение (ESCAPE-выражение), с помощью которого можно переопределить это значение. Отображается в DBLITERAL_ESCAPE_PERCENT_PREFIX.</summary>
		// Token: 0x04000BE0 RID: 3040
		Escape_Percent_Prefix = 9,
		/// <summary>Escape-символ (если есть), используемый в качестве суффикса для символа, возвращаемого для литерала DBLITERAL_LIKE_PERCENT. Например, если знак процента (%) служит для обозначения нескольких символов (возможно, нулевого их числа), а знаки процента вставляются в текст заключенными в квадратные скобки, значение DBLITERAL_ESCAPE_PERCENT_PREFIX равно "[", DBLITERAL_ESCAPE_PERCENT_SUFFIX равно "]", а последовательность знаков "abc[%]%" соответствует всем символьным значениям, начинающимся с "abc%". Поставщики, не использующие суффикс для вставки знака DBLITERAL_ESCAPE_PERCENT, не возвращают значение этого литерала и при запросе могут установить значение элемента lt структуры DBLITERAL равным DBLITERAL_INVALID. Отображается в DBLITERAL_ESCAPE_PERCENT_SUFFIX.</summary>
		// Token: 0x04000BE1 RID: 3041
		Escape_Percent_Suffix = 29,
		/// <summary>Знак, используемый в выражении LIKE в качестве подстановочного знака для символа, возвращаемого для литерала DBLITERAL_LIKE_UNDERSCORE. Например, если знак подчеркивания () служит для обозначения только одного символа и указана обратная косая черта (\), последовательность знаков "abc\\ " соответствует всем пятизначным символьным значениям, начинающимся с "abc\". В некоторых диалектах SQL предусмотрено специальное выражение (ESCAPE-выражение), с помощью которого можно переопределить это значение. Отображается в DBLITERAL_ESCAPE_UNDERSCORE_PREFIX.</summary>
		// Token: 0x04000BE2 RID: 3042
		Escape_Underscore_Prefix = 10,
		/// <summary>Знак, используемый в выражении LIKE в качестве подстановочного знака для символа, возвращаемого для литерала DBLITERAL_LIKE_UNDERSCORE. Например, если знак подчеркивания () служит для обозначения только одного символа и указана обратная косая черта (\), последовательность знаков "abc\\ " соответствует всем пятизначным символьным значениям, начинающимся с "abc\". В некоторых диалектах SQL предусмотрено специальное выражение (ESCAPE-выражение), с помощью которого можно переопределить это значение. Отображается в DBLITERAL_ESCAPE_UNDERSCORE_SUFFIX.</summary>
		// Token: 0x04000BE3 RID: 3043
		Escape_Underscore_Suffix = 30,
		/// <summary>Имя иерархии. Если размерность не содержит иерархий или содержит только одну иерархию, в текущем столбце стоит значение null.</summary>
		// Token: 0x04000BE4 RID: 3044
		Hierarchy_Name = 23,
		/// <summary>Имя индекса, используемое в текстовой команде или в интерфейсе определения данных. Отображается в DBLITERAL_INDEX_NAME.</summary>
		// Token: 0x04000BE5 RID: 3045
		Index_Name = 11,
		/// <summary>Недопустимое значение. Отображается в DBLITERAL_INVALID.</summary>
		// Token: 0x04000BE6 RID: 3046
		Invalid = 0,
		/// <summary>Имя куба, к которому относится текущий уровень.</summary>
		// Token: 0x04000BE7 RID: 3047
		Level_Name = 24,
		/// <summary>Знак, используемый в выражении LIKE для соответствия нескольким знакам или отсутствию знаков. Например, если это знак процента (%), то последовательность знаков "abc%" соответствует всем символьным значениям, начинающимся с "abc". Отображается в DBLITERAL_LIKE_PERCENT.</summary>
		// Token: 0x04000BE8 RID: 3048
		Like_Percent = 12,
		/// <summary>Знак, используемый в выражении LIKE для соответствия только одному знаку. Например, если это знак подчеркивания (), то последовательность знаков "abc\" соответствует всем четырехзначным символьным значениям, начинающимся с "abc". Отображается в DBLITERAL_LIKE_UNDERSCORE.</summary>
		// Token: 0x04000BE9 RID: 3049
		Like_Underscore,
		/// <summary>Имя элемента.</summary>
		// Token: 0x04000BEA RID: 3050
		Member_Name = 25,
		/// <summary>Имя процедуры в текстовой команде. Отображается в DBLITERAL_PROCEDURE_NAME.</summary>
		// Token: 0x04000BEB RID: 3051
		Procedure_Name = 14,
		/// <summary>Имя свойства.</summary>
		// Token: 0x04000BEC RID: 3052
		Property_Name = 26,
		/// <summary>Знак, используемый в текстовой команде в качестве открывающей кавычки для заключения в кавычки идентификаторов, содержащих специальные знаки. Отображается в DBLITERAL_QUOTE_PREFIX.</summary>
		// Token: 0x04000BED RID: 3053
		Quote_Prefix = 15,
		/// <summary>Знак, используемый в текстовой команде в качестве закрывающей кавычки для заключения в кавычки идентификаторов, содержащих специальные знаки. Поставщики 1.x, использующие один и тот же знак в качестве префикса и суффикса, могут не возвращать это значение литерала и при запросе могут установить значение элемента структуры DBLITERAL равным DBLITERAL_INVALID. Отображается в DBLITERAL_QUOTE_SUFFIX.</summary>
		// Token: 0x04000BEE RID: 3054
		Quote_Suffix = 28,
		/// <summary>Имя схемы в текстовой команде. Отображается в DBLITERAL_SCHEMA_NAME.</summary>
		// Token: 0x04000BEF RID: 3055
		Schema_Name = 16,
		/// <summary>Знак, отделяющий имя схемы от остальной части идентификатора в текстовой команде. Отображается в DBLITERAL_SCHEMA_SEPARATOR.</summary>
		// Token: 0x04000BF0 RID: 3056
		Schema_Separator = 27,
		/// <summary>Имя таблицы, используемое в текстовой команде или в интерфейсе определения данных. Отображается в DBLITERAL_TABLE_NAME.</summary>
		// Token: 0x04000BF1 RID: 3057
		Table_Name = 17,
		/// <summary>Текстовая команда, например оператор SQL. Отображается в DBLITERAL_TEXT_COMMAND.</summary>
		// Token: 0x04000BF2 RID: 3058
		Text_Command,
		/// <summary>Имя пользователя в текстовой команде. Отображается в DBLITERAL_USER_NAME.</summary>
		// Token: 0x04000BF3 RID: 3059
		User_Name,
		/// <summary>Имя представления в текстовой команде. Отображается в DBLITERAL_VIEW_NAME.</summary>
		// Token: 0x04000BF4 RID: 3060
		View_Name
	}
}
