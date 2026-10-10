using System;

namespace System.Text.RegularExpressions
{
	/// <summary>Представляет метод, вызываемый каждый раз, когда обнаружено совпадение регулярного выражения во время работы метода <see cref="Overload:System.Text.RegularExpressions.Regex.Replace" />.</summary>
	/// <param name="match">Объект <see cref="T:System.Text.RegularExpressions.Match" />, представляющий отдельное совпадение регулярного выражения во время работы метода <see cref="Overload:System.Text.RegularExpressions.Regex.Replace" />.</param>
	/// <returns>Строка, возвращенная методом, представленным делегатом <see cref="T:System.Text.RegularExpressions.MatchEvaluator" />.</returns>
	// Token: 0x020001F8 RID: 504
	// (Invoke) Token: 0x06000DB5 RID: 3509
	public delegate string MatchEvaluator(Match match);
}
