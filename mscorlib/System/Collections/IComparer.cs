using System;

namespace System.Collections
{
	/// <summary>Предоставляет метод, который сравнивает два объекта.</summary>
	// Token: 0x02000A13 RID: 2579
	public interface IComparer
	{
		/// <summary>Сравнение двух объектов и возврат значения, указывающего, является ли один объект меньшим, равным или большим другого.</summary>
		/// <param name="x">Первый из сравниваемых объектов.</param>
		/// <param name="y">Второй из сравниваемых объектов.</param>
		/// <returns>Целое число со знаком, представляющее результат сравнения значений <paramref name="x" /> и <paramref name="y" />:   — Если меньше 0, <paramref name="x" /> меньше <paramref name="y" />.   — Если 0, <paramref name="x" /> равно <paramref name="y" />.   — Если больше 0, <paramref name="x" /> больше <paramref name="y" />.</returns>
		/// <exception cref="T:System.ArgumentException">Ни параметр <paramref name="x" />, ни параметр <paramref name="y" /> не реализует интерфейс <see cref="T:System.IComparable" />.  
		///
		/// или - 
		/// Параметры <paramref name="x" /> и <paramref name="y" /> имеют разные типы и не могут сравниваться друг с другом.</exception>
		// Token: 0x06005B82 RID: 23426
		int Compare(object x, object y);
	}
}
