using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Linq
{
	/// <summary>
	///         Определяет индексатор, свойство size и метод поиска логических структур данных, сопоставляющих ключи для <see cref="T:System.Collections.Generic.IEnumerable`1" /> последовательности значений.
	///       </summary>
	/// <typeparam name="TKey">
	///           Тип ключей в <see cref="T:System.Linq.ILookup`2" />.
	///         </typeparam>
	/// <typeparam name="TElement">
	///           Тип элементов в <see cref="T:System.Collections.Generic.IEnumerable`1" /> последовательностей, которые составляют значения в <see cref="T:System.Linq.ILookup`2" />.
	///         </typeparam>
	// Token: 0x020000D7 RID: 215
	public interface ILookup<TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
	{
		/// <summary>
		///         Возвращает коллекцию пар количество ключей и значений в <see cref="T:System.Linq.ILookup`2" />.
		///       </summary>
		/// <returns>
		///         Число пар ключ значение коллекции в <see cref="T:System.Linq.ILookup`2" />.
		///       </returns>
		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060007A8 RID: 1960
		int Count { get; }

		/// <summary>
		///         Возвращает <see cref="T:System.Collections.Generic.IEnumerable`1" /> индексированных последовательность значений с помощью указанного ключа.
		///       </summary>
		/// <param name="key">
		///           Ключ требуемой последовательности значений.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Collections.Generic.IEnumerable`1" /> Последовательность значений индексированных с указанным ключом.
		///       </returns>
		// Token: 0x170000E0 RID: 224
		IEnumerable<TElement> this[TKey key]
		{
			get;
		}

		/// <summary>
		///         Определяет, существует ли указанный ключ в <see cref="T:System.Linq.ILookup`2" />.
		///       </summary>
		/// <param name="key">
		///           Ключ для поиска в <see cref="T:System.Linq.ILookup`2" />.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если <paramref name="key" /> в <see cref="T:System.Linq.ILookup`2" />; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x060007AA RID: 1962
		bool Contains(TKey key);
	}
}
