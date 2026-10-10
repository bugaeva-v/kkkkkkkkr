using System;

namespace System.Globalization
{
	/// <summary>Определяет параметры форматирования, задающие способ разбора строки методами <see cref="Overload:System.TimeSpan.ParseExact" /> и <see cref="Overload:System.TimeSpan.TryParseExact" />.</summary>
	// Token: 0x0200097B RID: 2427
	[Flags]
	public enum TimeSpanStyles
	{
		/// <summary>Указывает, что входные данные обрабатываются как отрицательный интервал времени только при наличии отрицательного знака.</summary>
		// Token: 0x0400352E RID: 13614
		None = 0,
		/// <summary>Указывает, что входные данные всегда обрабатываются как отрицательный интервал времени.</summary>
		// Token: 0x0400352F RID: 13615
		AssumeNegative = 1
	}
}
