using System;

namespace System.Collections
{
	/// <summary>Поддерживает структурное сравнение объектов коллекции.</summary>
	// Token: 0x02000A1A RID: 2586
	public interface IStructuralComparable
	{
		/// <summary>Определяет позицию текущего объекта коллекции относительно другого объекта в порядке сортировки (находится перед другим объектов, на одной позиции с ним или после другого объекта).</summary>
		/// <param name="other">Объект для сравнения с текущим экземпляром.</param>
		/// <param name="comparer">Объект, который сравнивает члены текущего объекта коллекции с соответствующими членами объекта <paramref name="other" />.</param>
		/// <returns>Целое число со знаком, определяющее соотношение между текущим объектом коллекции и объектом <paramref name="other" /> в порядке сортировки: — Если меньше нуля, текущий экземпляр стоит перед объектом <paramref name="other" />. — Если ноль, текущий экземпляр и объект <paramref name="other" /> равны. — Если больше нуля, текущий экземпляр стоит после объекта <paramref name="other" />.  
		///   Возвращаемое значение 
		///   Описание: 
		///   -1 
		///   Текущий экземпляр стоит перед объектом <paramref name="other" />.  
		///
		///   0 
		///   Текущий экземпляр и объект <paramref name="other" /> равны.  
		///
		///   1 
		///   Текущий экземпляр стоит после объекта <paramref name="other" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="other" /> и этот экземпляр не принадлежат к одному типу.</exception>
		// Token: 0x06005BA2 RID: 23458
		int CompareTo(object other, IComparer comparer);
	}
}
