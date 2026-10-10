using System;
using System.Collections.Generic;
using System.Linq;

namespace System.Data
{
	/// <summary>Содержит методы расширений для классов коллекции строк данных.</summary>
	// Token: 0x0200000D RID: 13
	public static class EnumerableRowCollectionExtensions
	{
		/// <summary>Выполняет фильтрацию последовательности строк на основе заданного предиката.</summary>
		/// <param name="source">Коллекция <see cref="T:System.Data.EnumerableRowCollection" />, элементы <see cref="T:System.Data.DataRow" /> которой подлежат фильтрации.</param>
		/// <param name="predicate">Функция для проверки каждого элемента на соответствие условию.</param>
		/// <typeparam name="TRow">Тип элементов строки в объекте <paramref name="source" />, обычно <see cref="T:System.Data.DataRow" />.</typeparam>
		/// <returns>Объект <see cref="T:System.Data.OrderedEnumerableRowCollection`1" />, содержащий строки входной последовательности, которые удовлетворяют условию.</returns>
		// Token: 0x06000041 RID: 65 RVA: 0x00002BE1 File Offset: 0x00000DE1
		public static EnumerableRowCollection<TRow> Where<TRow>(this EnumerableRowCollection<TRow> source, Func<TRow, bool> predicate)
		{
			EnumerableRowCollection<TRow> enumerableRowCollection = new EnumerableRowCollection<TRow>(source, source.Where(predicate), null);
			enumerableRowCollection.AddPredicate(predicate);
			return enumerableRowCollection;
		}

		/// <summary>Сортирует строки объекта <see cref="T:System.Data.EnumerableRowCollection" /> в порядке возрастания по заданному ключу.</summary>
		/// <param name="source">Коллекция <see cref="T:System.Data.EnumerableRowCollection" />, элементы <see cref="T:System.Data.DataRow" /> которой подлежат упорядочению.</param>
		/// <param name="keySelector">Функция, извлекающая ключ из элемента.</param>
		/// <typeparam name="TRow">Тип элементов строки в объекте <paramref name="source" />, обычно <see cref="T:System.Data.DataRow" />.</typeparam>
		/// <typeparam name="TKey">Тип ключа, возвращаемого функцией <paramref name="keySelector" />.</typeparam>
		/// <returns>Объект <see cref="T:System.Data.OrderedEnumerableRowCollection`1" />, элементы которого отсортированы по заданному ключу.</returns>
		// Token: 0x06000042 RID: 66 RVA: 0x00002BF8 File Offset: 0x00000DF8
		public static OrderedEnumerableRowCollection<TRow> OrderBy<TRow, TKey>(this EnumerableRowCollection<TRow> source, Func<TRow, TKey> keySelector)
		{
			IEnumerable<TRow> enumerableRows = source.OrderBy(keySelector);
			OrderedEnumerableRowCollection<TRow> orderedEnumerableRowCollection = new OrderedEnumerableRowCollection<TRow>(source, enumerableRows);
			orderedEnumerableRowCollection.AddSortExpression<TKey>(keySelector, false, true);
			return orderedEnumerableRowCollection;
		}

		/// <summary>Сортирует строки объекта <see cref="T:System.Data.EnumerableRowCollection" /> в порядке возрастания по указанному ключу и компаратору.</summary>
		/// <param name="source">Коллекция <see cref="T:System.Data.EnumerableRowCollection" />, элементы <see cref="T:System.Data.DataRow" /> которой подлежат упорядочению.</param>
		/// <param name="keySelector">Функция, извлекающая ключ из элемента.</param>
		/// <param name="comparer">Компаратор <see cref="T:System.Collections.Generic.IComparer`1" />, используемый для сравнения ключей.</param>
		/// <typeparam name="TRow">Тип элементов строки в объекте <paramref name="source" />, обычно <see cref="T:System.Data.DataRow" />.</typeparam>
		/// <typeparam name="TKey">Тип ключа, возвращаемого функцией <paramref name="keySelector" />.</typeparam>
		/// <returns>Объект <see cref="T:System.Data.OrderedEnumerableRowCollection`1" />, элементы которого отсортированы по заданному ключу и компаратору.</returns>
		// Token: 0x06000043 RID: 67 RVA: 0x00002C20 File Offset: 0x00000E20
		public static OrderedEnumerableRowCollection<TRow> OrderBy<TRow, TKey>(this EnumerableRowCollection<TRow> source, Func<TRow, TKey> keySelector, IComparer<TKey> comparer)
		{
			IEnumerable<TRow> enumerableRows = source.OrderBy(keySelector, comparer);
			OrderedEnumerableRowCollection<TRow> orderedEnumerableRowCollection = new OrderedEnumerableRowCollection<TRow>(source, enumerableRows);
			orderedEnumerableRowCollection.AddSortExpression<TKey>(keySelector, comparer, false, true);
			return orderedEnumerableRowCollection;
		}

		/// <summary>Сортирует строки объекта <see cref="T:System.Data.EnumerableRowCollection" /> в порядке убывания по заданному ключу.</summary>
		/// <param name="source">Коллекция <see cref="T:System.Data.EnumerableRowCollection" />, элементы <see cref="T:System.Data.DataRow" /> которой подлежат упорядочению.</param>
		/// <param name="keySelector">Функция, извлекающая ключ из элемента.</param>
		/// <typeparam name="TRow">Тип элементов строки в объекте <paramref name="source" />, обычно <see cref="T:System.Data.DataRow" />.</typeparam>
		/// <typeparam name="TKey">Тип ключа, возвращаемого функцией <paramref name="keySelector" />.</typeparam>
		/// <returns>Объект <see cref="T:System.Data.OrderedEnumerableRowCollection`1" />, элементы которого отсортированы по заданному ключу.</returns>
		// Token: 0x06000044 RID: 68 RVA: 0x00002C48 File Offset: 0x00000E48
		public static OrderedEnumerableRowCollection<TRow> OrderByDescending<TRow, TKey>(this EnumerableRowCollection<TRow> source, Func<TRow, TKey> keySelector)
		{
			IEnumerable<TRow> enumerableRows = source.OrderByDescending(keySelector);
			OrderedEnumerableRowCollection<TRow> orderedEnumerableRowCollection = new OrderedEnumerableRowCollection<TRow>(source, enumerableRows);
			orderedEnumerableRowCollection.AddSortExpression<TKey>(keySelector, true, true);
			return orderedEnumerableRowCollection;
		}

		/// <summary>Сортирует строки объекта <see cref="T:System.Data.EnumerableRowCollection" /> в порядке убывания в соответствии с указанным ключом и компаратором.</summary>
		/// <param name="source">Коллекция <see cref="T:System.Data.EnumerableRowCollection" />, элементы <see cref="T:System.Data.DataRow" /> которой подлежат упорядочению.</param>
		/// <param name="keySelector">Функция, извлекающая ключ из элемента.</param>
		/// <param name="comparer">Компаратор <see cref="T:System.Collections.Generic.IComparer`1" />, используемый для сравнения ключей.</param>
		/// <typeparam name="TRow">Тип элементов строки в объекте <paramref name="source" />, обычно <see cref="T:System.Data.DataRow" />.</typeparam>
		/// <typeparam name="TKey">Тип ключа, возвращаемого функцией <paramref name="keySelector" />.</typeparam>
		/// <returns>Объект <see cref="T:System.Data.OrderedEnumerableRowCollection`1" />, элементы которого отсортированы по заданному ключу и компаратору.</returns>
		// Token: 0x06000045 RID: 69 RVA: 0x00002C70 File Offset: 0x00000E70
		public static OrderedEnumerableRowCollection<TRow> OrderByDescending<TRow, TKey>(this EnumerableRowCollection<TRow> source, Func<TRow, TKey> keySelector, IComparer<TKey> comparer)
		{
			IEnumerable<TRow> enumerableRows = source.OrderByDescending(keySelector, comparer);
			OrderedEnumerableRowCollection<TRow> orderedEnumerableRowCollection = new OrderedEnumerableRowCollection<TRow>(source, enumerableRows);
			orderedEnumerableRowCollection.AddSortExpression<TKey>(keySelector, comparer, true, true);
			return orderedEnumerableRowCollection;
		}

		/// <summary>Выполняет вторичную сортировку строк объекта <see cref="T:System.Data.EnumerableRowCollection" /> в порядке возрастания по заданному ключу.</summary>
		/// <param name="source">Коллекция <see cref="T:System.Data.EnumerableRowCollection" />, элементы <see cref="T:System.Data.DataRow" /> которой подлежат упорядочению.</param>
		/// <param name="keySelector">Функция, извлекающая ключ из элемента.</param>
		/// <typeparam name="TRow">Тип элементов строки в объекте <paramref name="source" />, обычно <see cref="T:System.Data.DataRow" />.</typeparam>
		/// <typeparam name="TKey">Тип ключа, возвращаемого функцией <paramref name="keySelector" />.</typeparam>
		/// <returns>Объект <see cref="T:System.Data.OrderedEnumerableRowCollection`1" />, элементы которого отсортированы по заданному ключу.</returns>
		// Token: 0x06000046 RID: 70 RVA: 0x00002C98 File Offset: 0x00000E98
		public static OrderedEnumerableRowCollection<TRow> ThenBy<TRow, TKey>(this OrderedEnumerableRowCollection<TRow> source, Func<TRow, TKey> keySelector)
		{
			IEnumerable<TRow> enumerableRows = ((IOrderedEnumerable<TRow>)source.EnumerableRows).ThenBy(keySelector);
			OrderedEnumerableRowCollection<TRow> orderedEnumerableRowCollection = new OrderedEnumerableRowCollection<TRow>(source, enumerableRows);
			orderedEnumerableRowCollection.AddSortExpression<TKey>(keySelector, false, false);
			return orderedEnumerableRowCollection;
		}

		/// <summary>Выполняет вторичную сортировку строк объекта <see cref="T:System.Data.EnumerableRowCollection" /> в порядке возрастания по заданному ключу и компаратору.</summary>
		/// <param name="source">Коллекция <see cref="T:System.Data.EnumerableRowCollection" />, элементы <see cref="T:System.Data.DataRow" /> которой подлежат упорядочению.</param>
		/// <param name="keySelector">Функция, извлекающая ключ из элемента.</param>
		/// <param name="comparer">Компаратор <see cref="T:System.Collections.Generic.IComparer`1" />, используемый для сравнения ключей.</param>
		/// <typeparam name="TRow">Тип элементов строки в объекте <paramref name="source" />, обычно <see cref="T:System.Data.DataRow" />.</typeparam>
		/// <typeparam name="TKey">Тип ключа, возвращаемого функцией <paramref name="keySelector" />.</typeparam>
		/// <returns>Объект <see cref="T:System.Data.OrderedEnumerableRowCollection`1" />, элементы которого отсортированы по заданному ключу и компаратору.</returns>
		// Token: 0x06000047 RID: 71 RVA: 0x00002CC8 File Offset: 0x00000EC8
		public static OrderedEnumerableRowCollection<TRow> ThenBy<TRow, TKey>(this OrderedEnumerableRowCollection<TRow> source, Func<TRow, TKey> keySelector, IComparer<TKey> comparer)
		{
			IEnumerable<TRow> enumerableRows = ((IOrderedEnumerable<TRow>)source.EnumerableRows).ThenBy(keySelector, comparer);
			OrderedEnumerableRowCollection<TRow> orderedEnumerableRowCollection = new OrderedEnumerableRowCollection<TRow>(source, enumerableRows);
			orderedEnumerableRowCollection.AddSortExpression<TKey>(keySelector, comparer, false, false);
			return orderedEnumerableRowCollection;
		}

		/// <summary>Выполняет вторичную сортировку строк объекта <see cref="T:System.Data.EnumerableRowCollection" /> в порядке убывания по заданному ключу.</summary>
		/// <param name="source">Коллекция <see cref="T:System.Data.EnumerableRowCollection" />, элементы <see cref="T:System.Data.DataRow" /> которой подлежат упорядочению.</param>
		/// <param name="keySelector">Функция, извлекающая ключ из элемента.</param>
		/// <typeparam name="TRow">Тип элементов строки в объекте <paramref name="source" />, обычно <see cref="T:System.Data.DataRow" />.</typeparam>
		/// <typeparam name="TKey">Тип ключа, возвращаемого функцией <paramref name="keySelector" />.</typeparam>
		/// <returns>Объект <see cref="T:System.Data.OrderedEnumerableRowCollection`1" />, элементы которого отсортированы по заданному ключу.</returns>
		// Token: 0x06000048 RID: 72 RVA: 0x00002CFC File Offset: 0x00000EFC
		public static OrderedEnumerableRowCollection<TRow> ThenByDescending<TRow, TKey>(this OrderedEnumerableRowCollection<TRow> source, Func<TRow, TKey> keySelector)
		{
			IEnumerable<TRow> enumerableRows = ((IOrderedEnumerable<TRow>)source.EnumerableRows).ThenByDescending(keySelector);
			OrderedEnumerableRowCollection<TRow> orderedEnumerableRowCollection = new OrderedEnumerableRowCollection<TRow>(source, enumerableRows);
			orderedEnumerableRowCollection.AddSortExpression<TKey>(keySelector, true, false);
			return orderedEnumerableRowCollection;
		}

		/// <summary>Выполняет вторичную сортировку строк объекта <see cref="T:System.Data.EnumerableRowCollection" /> в порядке убывания по заданному ключу и компаратору.</summary>
		/// <param name="source">Коллекция <see cref="T:System.Data.EnumerableRowCollection" />, элементы <see cref="T:System.Data.DataRow" /> которой подлежат упорядочению.</param>
		/// <param name="keySelector">Функция, извлекающая ключ из элемента.</param>
		/// <param name="comparer">Компаратор <see cref="T:System.Collections.Generic.IComparer`1" />, используемый для сравнения ключей.</param>
		/// <typeparam name="TRow">Тип элементов строки в объекте <paramref name="source" />, обычно <see cref="T:System.Data.DataRow" />.</typeparam>
		/// <typeparam name="TKey">Тип ключа, возвращаемого функцией <paramref name="keySelector" />.</typeparam>
		/// <returns>Объект <see cref="T:System.Data.OrderedEnumerableRowCollection`1" />, элементы которого отсортированы по заданному ключу и компаратору.</returns>
		// Token: 0x06000049 RID: 73 RVA: 0x00002D2C File Offset: 0x00000F2C
		public static OrderedEnumerableRowCollection<TRow> ThenByDescending<TRow, TKey>(this OrderedEnumerableRowCollection<TRow> source, Func<TRow, TKey> keySelector, IComparer<TKey> comparer)
		{
			IEnumerable<TRow> enumerableRows = ((IOrderedEnumerable<TRow>)source.EnumerableRows).ThenByDescending(keySelector, comparer);
			OrderedEnumerableRowCollection<TRow> orderedEnumerableRowCollection = new OrderedEnumerableRowCollection<TRow>(source, enumerableRows);
			orderedEnumerableRowCollection.AddSortExpression<TKey>(keySelector, comparer, true, false);
			return orderedEnumerableRowCollection;
		}

		/// <summary>Проецирует каждый элемент <see cref="T:System.Data.EnumerableRowCollection`1" /> в новую форму.</summary>
		/// <param name="source">Коллекция <see cref="T:System.Data.EnumerableRowCollection`1" />, содержащая элементы <see cref="T:System.Data.DataRow" />, для которых будет вызвана функция преобразования.</param>
		/// <param name="selector">Функция преобразования, применяемая к каждому элементу.</param>
		/// <typeparam name="TRow">Тип элементов строки в объекте <paramref name="source" />, обычно <see cref="T:System.Data.DataRow" />.</typeparam>
		/// <typeparam name="S">Тип, в который будет преобразован объект <paramref name="TRow" />.</typeparam>
		/// <returns>Объект <see cref="T:System.Data.EnumerableRowCollection`1" />, элементы которого получены в результате вызова функции преобразования для каждого элемента последовательности <paramref name="source" />.</returns>
		// Token: 0x0600004A RID: 74 RVA: 0x00002D60 File Offset: 0x00000F60
		public static EnumerableRowCollection<S> Select<TRow, S>(this EnumerableRowCollection<TRow> source, Func<TRow, S> selector)
		{
			IEnumerable<S> enumerableRows = source.Select(selector);
			return new EnumerableRowCollection<S>(source as EnumerableRowCollection<S>, enumerableRows, selector as Func<S, S>);
		}

		/// <summary>Преобразовывает элементы объекта <see cref="T:System.Data.EnumerableRowCollection" /> в заданный тип.</summary>
		/// <param name="source">Объект <see cref="T:System.Data.EnumerableRowCollection" />, содержащий преобразуемые элементы.</param>
		/// <typeparam name="TResult">Тип, в который преобразуются элементы источника.</typeparam>
		/// <returns>Объект <see cref="T:System.Data.EnumerableRowCollection" />, который содержит все элементы исходной последовательности, преобразованные в заданный тип.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Элемент последовательности не может быть приведен к типу <paramref name="TResult" />.</exception>
		// Token: 0x0600004B RID: 75 RVA: 0x00002D88 File Offset: 0x00000F88
		public static EnumerableRowCollection<TResult> Cast<TResult>(this EnumerableRowCollection source)
		{
			if (source != null && source.ElementType.Equals(typeof(TResult)))
			{
				return (EnumerableRowCollection<TResult>)source;
			}
			return new EnumerableRowCollection<TResult>(source.Cast<TResult>(), typeof(TResult).IsAssignableFrom(source.ElementType) && typeof(DataRow).IsAssignableFrom(typeof(TResult)), source.Table);
		}
	}
}
