using System;

namespace System
{
	/// <summary>Представляет метод, который сравнивает два объекта одного типа.</summary>
	/// <param name="x">Первый из сравниваемых объектов.</param>
	/// <param name="y">Второй из сравниваемых объектов.</param>
	/// <typeparam name="T">Тип сравниваемых объектов.</typeparam>
	/// <returns>Знаковое целое число, которое определяет относительные значения параметров <paramref name="x" /> и <paramref name="y" />, как показано в следующей таблице.  
	///   Значение  Описание  Меньше 0 <paramref name="x" /> меньше <paramref name="y" />.   0 <paramref name="x" /> равно <paramref name="y" />.   Больше 0 <paramref name="x" /> больше <paramref name="y" />.</returns>
	// Token: 0x020000EE RID: 238
	// (Invoke) Token: 0x060006DB RID: 1755
	public delegate int Comparison<in T>(T x, T y);
}
