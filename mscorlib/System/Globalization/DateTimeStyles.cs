using System;

namespace System.Globalization
{
	/// <summary>Определяет параметры форматирования, регулирующие синтаксический анализ строк для некоторых методов синтаксического анализа дат и времени.</summary>
	// Token: 0x02000961 RID: 2401
	[Flags]
	public enum DateTimeStyles
	{
		/// <summary>Необходимо использовать параметры форматирования по умолчанию. Это значение представляет стиль по умолчанию для методов <see cref="M:System.DateTime.Parse(System.String)" />, <see cref="M:System.DateTime.ParseExact(System.String,System.String,System.IFormatProvider)" /> и <see cref="M:System.DateTime.TryParse(System.String,System.DateTime@)" />.</summary>
		// Token: 0x0400347A RID: 13434
		None = 0,
		/// <summary>При анализе не следует учитывать начальные пробелы. Исключением является их появление в шаблонах формата <see cref="T:System.Globalization.DateTimeFormatInfo" />.</summary>
		// Token: 0x0400347B RID: 13435
		AllowLeadingWhite = 1,
		/// <summary>При анализе не следует учитывать конечные пробелы. Исключением является их появление в шаблонах формата <see cref="T:System.Globalization.DateTimeFormatInfo" />.</summary>
		// Token: 0x0400347C RID: 13436
		AllowTrailingWhite = 2,
		/// <summary>При анализе не следует учитывать дополнительные пробелы в середине строки. Исключением является их появление в шаблонах формата <see cref="T:System.Globalization.DateTimeFormatInfo" />.</summary>
		// Token: 0x0400347D RID: 13437
		AllowInnerWhite = 4,
		/// <summary>При анализе не следует учитывать дополнительные пробелы в любом месте строки. Исключением является их появление в шаблонах формата <see cref="T:System.Globalization.DateTimeFormatInfo" />. Это значение представляет собой сочетание значений <see cref="F:System.Globalization.DateTimeStyles.AllowLeadingWhite" />, <see cref="F:System.Globalization.DateTimeStyles.AllowTrailingWhite" /> и <see cref="F:System.Globalization.DateTimeStyles.AllowInnerWhite" />.</summary>
		// Token: 0x0400347E RID: 13438
		AllowWhiteSpaces = 7,
		/// <summary>Если в анализируемой строке содержится только время и отсутствует дата, в методах анализа подразумевается дата по Григорианскому календарю, где год = 1, месяц = 1 и день = 1. Если это значение не используется, подразумевается текущая дата.</summary>
		// Token: 0x0400347F RID: 13439
		NoCurrentDateDefault = 8,
		/// <summary>Дата и время возвращаются в формате UTC. Если во входной строке указано местное время (с помощью описателя часового пояса или <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal" />), дата и время преобразуются из местного времени в UTC. Если во входной строке указано время в формате UTC (с помощью описателя часового пояса или <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal" />), преобразование не выполняется. Если во входной строке не указано местное время или время в формате UTC, преобразование не выполняется и результирующее свойство <see cref="P:System.DateTime.Kind" /> имеет значение <see cref="F:System.DateTimeKind.Unspecified" />.</summary>
		// Token: 0x04003480 RID: 13440
		AdjustToUniversal = 16,
		/// <summary>Если в анализируемой строке часовой пояс не указан, подразумевается, что используется местное время.</summary>
		// Token: 0x04003481 RID: 13441
		AssumeLocal = 32,
		/// <summary>Если в анализируемой строке часовой пояс не указан, подразумевается, что используется время в формате UTC.</summary>
		// Token: 0x04003482 RID: 13442
		AssumeUniversal = 64,
		/// <summary>Поле даты <see cref="T:System.DateTimeKind" /> сохраняется, когда объект <see cref="T:System.DateTime" /> преобразуется в строку с помощью описателя стандартного формата "o" или "r", а затем строка преобразуется обратно в объект <see cref="T:System.DateTime" />.</summary>
		// Token: 0x04003483 RID: 13443
		RoundtripKind = 128
	}
}
