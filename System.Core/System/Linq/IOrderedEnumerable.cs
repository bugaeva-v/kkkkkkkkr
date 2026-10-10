using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Linq
{
	/// <summary>
	///         Представляет упорядоченную последовательность.
	///       </summary>
	/// <typeparam name="TElement">
	///           Тип элементов последовательности.
	///         </typeparam>
	// Token: 0x020000DB RID: 219
	public interface IOrderedEnumerable<out TElement> : IEnumerable<!0>, IEnumerable
	{
		/// <summary>
		///         Выполняет дополнительное упорядочение элементов из <see cref="T:System.Linq.IOrderedEnumerable`1" /> ключа.
		///       </summary>
		/// <param name="keySelector">
		///           <see cref="T:System.Func`2" /> Используется для извлечения ключа для каждого элемента.
		///         </param>
		/// <param name="comparer">
		///           <see cref="T:System.Collections.Generic.IComparer`1" /> Используется для сравнения ключей для размещения в возвращаемой последовательности.
		///         </param>
		/// <param name="descending">
		///           <see langword="true" /> Чтобы отсортировать элементы в порядке убывания; <see langword="false" /> для сортировки элементов в порядке возрастания.
		///         </param>
		/// <typeparam name="TKey">
		///           Тип ключа, полученных при <paramref name="keySelector" />.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IOrderedEnumerable`1" /> Элементы которой сортируются по ключу.
		///       </returns>
		// Token: 0x060007CC RID: 1996
		IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending);
	}
}
