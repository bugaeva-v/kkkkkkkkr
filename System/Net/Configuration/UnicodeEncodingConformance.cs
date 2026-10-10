using System;

namespace System.Net.Configuration
{
	/// <summary>Управляет тем, как символы юникода выводятся методами <see cref="Overload:System.Net.WebUtility.HtmlEncode" />.</summary>
	// Token: 0x02000759 RID: 1881
	public enum UnicodeEncodingConformance
	{
		/// <summary>Используйте автоматическое поведение. Поведение кодирования в Юникод определяется текущей целевой рабочей средой приложения. Для .NET Framework 4.5 и более поздних версиях, поведение кодирование Юникод строгое.</summary>
		// Token: 0x0400236B RID: 9067
		Auto,
		/// <summary>Используйте строгое поведение. Указывает, что отдельные суррогатные кодовые точки UTF-16 объединяются в одну кодовую точку при вызове методов <see cref="Overload:System.Net.WebUtility.HtmlEncode" />. Например, при использовании входной строки "\uD84C\uDFB4" (или "\U000233B4") результатом выполнения методов <see cref="Overload:System.Net.WebUtility.HtmlEncode" /> является "&amp;#144308;".  
		/// Если входные данные — неверно сформированная строка UTF-16 (содержит неспаренные суррогаты, например), плохие кодовые точки будут заменены на U+FFFD (символ замены юникода) перед его кодированием в HTML.</summary>
		// Token: 0x0400236C RID: 9068
		Strict,
		/// <summary>Используйте совместимое поведение. Указывает, что отдельные суррогатные кодовые точки UTF-16 выводятся как есть при вызове методов <see cref="Overload:System.Net.WebUtility.HtmlEncode" />. Например, при вводе строки «\uD84C\uDFB4" (или "\U000233B4»), результат <see cref="Overload:System.Net.WebUtility.HtmlEncode" /> — «\uD84C\uDFB4» (ввод не кодирован).</summary>
		// Token: 0x0400236D RID: 9069
		Compat
	}
}
