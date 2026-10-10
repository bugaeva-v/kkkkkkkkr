using System;

namespace System.Collections.Generic
{
	/// <summary>Определяет метод, реализуемый типом для сравнения двух объектов.</summary>
	/// <typeparam name="T">Тип объектов для сравнения.</typeparam>
	// Token: 0x02000A94 RID: 2708
	public interface IComparer<in T>
	{
		/// <summary>Сравнение двух объектов и возврат значения, указывающего, является ли один объект меньшим, равным или большим другого.</summary>
		/// <param name="x">Первый из сравниваемых объектов.</param>
		/// <param name="y">Второй из сравниваемых объектов.</param>
		/// <returns>Знаковое целое число, которое определяет относительные значения параметров <paramref name="x" /> и <paramref name="y" />, как показано в следующей таблице.  
		///   Значение   Описание   Меньше нуля  <paramref name="x" /> меньше <paramref name="y" />.   Ноль <paramref name="x" /> равно <paramref name="y" />.   Больше нуля <paramref name="x" /> больше <paramref name="y" />.</returns>
		// Token: 0x06006118 RID: 24856
		int Compare(T x, T y);
	}
}
