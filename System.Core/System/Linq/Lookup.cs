using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity;

namespace System.Linq
{
	/// <summary>
	///         Представляет коллекцию ключей, каждый из сопоставляется с одним или несколькими значениями.
	///       </summary>
	/// <typeparam name="TKey">
	///           Тип ключей в <see cref="T:System.Linq.Lookup`2" />.
	///         </typeparam>
	/// <typeparam name="TElement">
	///           Тип элементов каждого <see cref="T:System.Collections.Generic.IEnumerable`1" /> значение в <see cref="T:System.Linq.Lookup`2" />.
	///         </typeparam>
	// Token: 0x020000D8 RID: 216
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(SystemLinq_LookupDebugView<, >))]
	public class Lookup<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable, IIListProvider<IGrouping<TKey, TElement>>
	{
		// Token: 0x060007AB RID: 1963 RVA: 0x0001B020 File Offset: 0x00019220
		internal static Lookup<TKey, TElement> Create<TSource>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			Lookup<TKey, TElement> lookup = new Lookup<TKey, TElement>(comparer);
			foreach (TSource arg in source)
			{
				lookup.GetGrouping(keySelector(arg), true).Add(elementSelector(arg));
			}
			return lookup;
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0001B084 File Offset: 0x00019284
		internal static Lookup<TKey, TElement> Create(IEnumerable<TElement> source, Func<TElement, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
			Lookup<TKey, TElement> lookup = new Lookup<TKey, TElement>(comparer);
			foreach (TElement telement in source)
			{
				lookup.GetGrouping(keySelector(telement), true).Add(telement);
			}
			return lookup;
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0001B0E4 File Offset: 0x000192E4
		internal static Lookup<TKey, TElement> CreateForJoin(IEnumerable<TElement> source, Func<TElement, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
			Lookup<TKey, TElement> lookup = new Lookup<TKey, TElement>(comparer);
			foreach (TElement telement in source)
			{
				TKey tkey = keySelector(telement);
				if (tkey != null)
				{
					lookup.GetGrouping(tkey, true).Add(telement);
				}
			}
			return lookup;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0001B14C File Offset: 0x0001934C
		private Lookup(IEqualityComparer<TKey> comparer)
		{
			this._comparer = (comparer ?? EqualityComparer<TKey>.Default);
			this._groupings = new Grouping<TKey, TElement>[7];
		}

		/// <summary>
		///         Возвращает коллекцию пар количество ключей и значений в <see cref="T:System.Linq.Lookup`2" />.
		///       </summary>
		/// <returns>
		///         Число пар ключ значение коллекции в <see cref="T:System.Linq.Lookup`2" />.
		///       </returns>
		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x0001B170 File Offset: 0x00019370
		public int Count
		{
			get
			{
				return this._count;
			}
		}

		/// <summary>
		///         Возвращает коллекцию значений, индексированных по указанному ключу.
		///       </summary>
		/// <param name="key">
		///           Ключ требуемой коллекции значений.
		///         </param>
		/// <returns>
		///         Коллекция значений, индексированных по указанному ключу.
		///       </returns>
		// Token: 0x170000E2 RID: 226
		public IEnumerable<TElement> this[TKey key]
		{
			get
			{
				Grouping<TKey, TElement> grouping = this.GetGrouping(key, false);
				if (grouping != null)
				{
					return grouping;
				}
				return Array.Empty<TElement>();
			}
		}

		/// <summary>
		///         Определяет, является ли указанный ключ в <see cref="T:System.Linq.Lookup`2" />.
		///       </summary>
		/// <param name="key">
		///           Ключ для поиска в <see cref="T:System.Linq.Lookup`2" />.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если <paramref name="key" /> в <see cref="T:System.Linq.Lookup`2" />; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x060007B1 RID: 1969 RVA: 0x0001B198 File Offset: 0x00019398
		public bool Contains(TKey key)
		{
			return this.GetGrouping(key, false) != null;
		}

		/// <summary>
		///         Возвращает универсальный перечислитель, выполняющий перебор элементов <see cref="T:System.Linq.Lookup`2" />.
		///       </summary>
		/// <returns>
		///         Перечислитель для коллекции <see cref="T:System.Linq.Lookup`2" />.
		///       </returns>
		// Token: 0x060007B2 RID: 1970 RVA: 0x0001B1A5 File Offset: 0x000193A5
		public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
		{
			Grouping<TKey, TElement> g = this._lastGrouping;
			if (g != null)
			{
				do
				{
					g = g._next;
					yield return g;
				}
				while (g != this._lastGrouping);
			}
			yield break;
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0001B1B4 File Offset: 0x000193B4
		IGrouping<TKey, TElement>[] IIListProvider<IGrouping<!0, !1>>.ToArray()
		{
			IGrouping<TKey, TElement>[] array = new IGrouping<TKey, TElement>[this._count];
			int num = 0;
			Grouping<TKey, TElement> grouping = this._lastGrouping;
			if (grouping != null)
			{
				do
				{
					grouping = grouping._next;
					array[num] = grouping;
					num++;
				}
				while (grouping != this._lastGrouping);
			}
			return array;
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x0001B1F4 File Offset: 0x000193F4
		internal TResult[] ToArray<TResult>(Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
		{
			TResult[] array = new TResult[this._count];
			int num = 0;
			Grouping<TKey, TElement> grouping = this._lastGrouping;
			if (grouping != null)
			{
				do
				{
					grouping = grouping._next;
					grouping.Trim();
					array[num] = resultSelector(grouping._key, grouping._elements);
					num++;
				}
				while (grouping != this._lastGrouping);
			}
			return array;
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x0001B250 File Offset: 0x00019450
		List<IGrouping<TKey, TElement>> IIListProvider<IGrouping<!0, !1>>.ToList()
		{
			List<IGrouping<TKey, TElement>> list = new List<IGrouping<TKey, TElement>>(this._count);
			Grouping<TKey, TElement> grouping = this._lastGrouping;
			if (grouping != null)
			{
				do
				{
					grouping = grouping._next;
					list.Add(grouping);
				}
				while (grouping != this._lastGrouping);
			}
			return list;
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x0001B28C File Offset: 0x0001948C
		internal List<TResult> ToList<TResult>(Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
		{
			List<TResult> list = new List<TResult>(this._count);
			Grouping<TKey, TElement> grouping = this._lastGrouping;
			if (grouping != null)
			{
				do
				{
					grouping = grouping._next;
					grouping.Trim();
					list.Add(resultSelector(grouping._key, grouping._elements));
				}
				while (grouping != this._lastGrouping);
			}
			return list;
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0001B170 File Offset: 0x00019370
		int IIListProvider<IGrouping<!0, !1>>.GetCount(bool onlyIfCheap)
		{
			return this._count;
		}

		/// <summary>
		///         Применяет функцию преобразования к каждому ключу и связанным с ним значениям и возвращает результаты.
		///       </summary>
		/// <param name="resultSelector">
		///           Функция результирующее значение из каждого ключа и связанные с ним параметры проекта.
		///         </param>
		/// <typeparam name="TResult">
		///           Тип результирующих значений, полученных при <paramref name="resultSelector" />.
		///         </typeparam>
		/// <returns>
		///         Коллекция, содержащая одно значение для каждой пары ключ значение коллекции в <see cref="T:System.Linq.Lookup`2" />.
		///       </returns>
		// Token: 0x060007B8 RID: 1976 RVA: 0x0001B2DE File Offset: 0x000194DE
		public IEnumerable<TResult> ApplyResultSelector<TResult>(Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
		{
			Grouping<TKey, TElement> g = this._lastGrouping;
			if (g != null)
			{
				do
				{
					g = g._next;
					g.Trim();
					yield return resultSelector(g._key, g._elements);
				}
				while (g != this._lastGrouping);
			}
			yield break;
		}

		/// <summary>
		///         Возвращает перечислитель, осуществляющий перебор элементов списка <see cref="T:System.Linq.Lookup`2" />.
		///          Этот класс не наследуется.
		///       </summary>
		/// <returns>
		///         Перечислитель для коллекции <see cref="T:System.Linq.Lookup`2" />.
		///       </returns>
		// Token: 0x060007B9 RID: 1977 RVA: 0x0001B2F5 File Offset: 0x000194F5
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x0001B2FD File Offset: 0x000194FD
		private int InternalGetHashCode(TKey key)
		{
			if (key != null)
			{
				return this._comparer.GetHashCode(key) & int.MaxValue;
			}
			return 0;
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0001B31C File Offset: 0x0001951C
		internal Grouping<TKey, TElement> GetGrouping(TKey key, bool create)
		{
			int num = this.InternalGetHashCode(key);
			for (Grouping<TKey, TElement> grouping = this._groupings[num % this._groupings.Length]; grouping != null; grouping = grouping._hashNext)
			{
				if (grouping._hashCode == num && this._comparer.Equals(grouping._key, key))
				{
					return grouping;
				}
			}
			if (create)
			{
				if (this._count == this._groupings.Length)
				{
					this.Resize();
				}
				int num2 = num % this._groupings.Length;
				Grouping<TKey, TElement> grouping2 = new Grouping<TKey, TElement>();
				grouping2._key = key;
				grouping2._hashCode = num;
				grouping2._elements = new TElement[1];
				grouping2._hashNext = this._groupings[num2];
				this._groupings[num2] = grouping2;
				if (this._lastGrouping == null)
				{
					grouping2._next = grouping2;
				}
				else
				{
					grouping2._next = this._lastGrouping._next;
					this._lastGrouping._next = grouping2;
				}
				this._lastGrouping = grouping2;
				this._count++;
				return grouping2;
			}
			return null;
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x0001B414 File Offset: 0x00019614
		private void Resize()
		{
			int num = checked(this._count * 2 + 1);
			Grouping<TKey, TElement>[] array = new Grouping<TKey, TElement>[num];
			Grouping<TKey, TElement> grouping = this._lastGrouping;
			do
			{
				grouping = grouping._next;
				int num2 = grouping._hashCode % num;
				grouping._hashNext = array[num2];
				array[num2] = grouping;
			}
			while (grouping != this._lastGrouping);
			this._groupings = array;
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x0000235B File Offset: 0x0000055B
		internal Lookup()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x0400058C RID: 1420
		private readonly IEqualityComparer<TKey> _comparer;

		// Token: 0x0400058D RID: 1421
		private Grouping<TKey, TElement>[] _groupings;

		// Token: 0x0400058E RID: 1422
		private Grouping<TKey, TElement> _lastGrouping;

		// Token: 0x0400058F RID: 1423
		private int _count;
	}
}
