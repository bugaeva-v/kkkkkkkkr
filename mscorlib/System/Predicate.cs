using System;

namespace System
{
	/// <summary>Представляет метод, определяющий набор критериев и соответствие указанного объекта этим критериям.</summary>
	/// <param name="obj">Объект, проверяемый на соответствие критериям, заданным в методе, который представлен его делегатом.</param>
	/// <typeparam name="T">Тип сравниваемого объекта.</typeparam>
	/// <returns>Значение <see langword="true" />, если объект <paramref name="obj" /> удовлетворяет критериям, заданным в методе, который представляет этот делегат; в противном случае — значение <see langword="false" />.</returns>
	// Token: 0x020000F0 RID: 240
	// (Invoke) Token: 0x060006E3 RID: 1763
	public delegate bool Predicate<in T>(T obj);
}
