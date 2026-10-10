using System;
using System.Collections.Generic;

namespace System.Data
{
	/// <summary>Содержит методы расширения для класса <see cref="T:System.Data.TypedTableBase`1" />.</summary>
	// Token: 0x02000012 RID: 18
	public static class TypedTableBaseExtensions
	{
		/// <summary>Выполняет фильтрацию последовательности строк на основе указанного предиката.</summary>
		/// <param name="source">Объект <see cref="T:System.Data.TypedTableBase`1" />, содержащий фильтруемые элементы <see cref="T:System.Data.DataRow" />.</param>
		/// <param name="predicate">Функция для проверки каждого элемента на соответствие условию.</param>
		/// <typeparam name="TRow">Тип элементов строки в объекте <paramref name="source" />, обычно <see cref="T:System.Data.DataRow" />.</typeparam>
		/// <returns>Объект <see cref="T:System.Data.OrderedEnumerableRowCollection`1" />, содержащий строки входной последовательности, которые удовлетворяют условию.</returns>
		// Token: 0x0600005D RID: 93 RVA: 0x000031DB File Offset: 0x000013DB
		public static EnumerableRowCollection<TRow> Where<TRow>(this TypedTableBase<TRow> source, Func<TRow, bool> predicate) where TRow : DataRow
		{
			DataSetUtil.CheckArgumentNull<TypedTableBase<TRow>>(source, "source");
			return new EnumerableRowCollection<TRow>(source).Where(predicate);
		}

		/// <summary>Сортирует строки объекта <see cref="T:System.Data.TypedTableBase`1" /> в порядке возрастания по заданному ключу.</summary>
		/// <param name="source">Объект <see cref="T:System.Data.TypedTableBase`1" />, содержащий упорядочиваемые элементы <see cref="T:System.Data.DataRow" />.</param>
		/// <param name="keySelector">Функция, извлекающая ключ из элемента.</param>
		/// <typeparam name="TRow">Тип элементов строки в объекте <paramref name="source" />, обычно <see cref="T:System.Data.DataRow" />.</typeparam>
		/// <typeparam name="TKey">Тип ключа, возвращаемого функцией <paramref name="keySelector" />.</typeparam>
		/// <returns>Объект <see cref="T:System.Data.OrderedEnumerableRowCollection`1" />, элементы которого сортируются по заданному ключу.</returns>
		// Token: 0x0600005E RID: 94 RVA: 0x000031F4 File Offset: 0x000013F4
		public static OrderedEnumerableRowCollection<TRow> OrderBy<TRow, TKey>(this TypedTableBase<TRow> source, Func<TRow, TKey> keySelector) where TRow : DataRow
		{
			DataSetUtil.CheckArgumentNull<TypedTableBase<TRow>>(source, "source");
			return new EnumerableRowCollection<TRow>(source).OrderBy(keySelector);
		}

		/// <summary>Сортирует строки объекта <see cref="T:System.Data.TypedTableBase`1" /> в порядке возрастания по указанному ключу и компаратору.</summary>
		/// <param name="source">Объект <see cref="T:System.Data.TypedTableBase`1" />, содержащий упорядочиваемые элементы <see cref="T:System.Data.DataRow" />.</param>
		/// <param name="keySelector">Функция, извлекающая ключ из элемента.</param>
		/// <param name="comparer">Компаратор <see cref="T:System.Collections.Generic.IComparer`1" />, используемый для сравнения ключей.</param>
		/// <typeparam name="TRow">Тип элементов строки в объекте <paramref name="source" />, обычно <see cref="T:System.Data.DataRow" />.</typeparam>
		/// <typeparam name="TKey">Тип ключа, возвращаемого функцией <paramref name="keySelector" />.</typeparam>
		/// <returns>Объект <see cref="T:System.Data.OrderedEnumerableRowCollection`1" />, элементы которого отсортированы по указанному ключу и компаратору.</returns>
		// Token: 0x0600005F RID: 95 RVA: 0x0000320D File Offset: 0x0000140D
		public static OrderedEnumerableRowCollection<TRow> OrderBy<TRow, TKey>(this TypedTableBase<TRow> source, Func<TRow, TKey> keySelector, IComparer<TKey> comparer) where TRow : DataRow
		{
			DataSetUtil.CheckArgumentNull<TypedTableBase<TRow>>(source, "source");
			return new EnumerableRowCollection<TRow>(source).OrderBy(keySelector, comparer);
		}

		/// <summary>Сортирует строки объекта <see cref="T:System.Data.TypedTableBase`1" /> в порядке убывания по указанному ключу.</summary>
		/// <param name="source">Объект <see cref="T:System.Data.TypedTableBase`1" />, содержащий упорядочиваемые элементы <see cref="T:System.Data.DataRow" />.</param>
		/// <param name="keySelector">Функция, извлекающая ключ из элемента.</param>
		/// <typeparam name="TRow">Тип элементов строки в объекте <paramref name="source" />, обычно <see cref="T:System.Data.DataRow" />.</typeparam>
		/// <typeparam name="TKey">Тип ключа, возвращаемого функцией <paramref name="keySelector" />.</typeparam>
		/// <returns>Объект <see cref="T:System.Data.OrderedEnumerableRowCollection`1" />, элементы которого сортируются по заданному ключу.</returns>
		// Token: 0x06000060 RID: 96 RVA: 0x00003227 File Offset: 0x00001427
		public static OrderedEnumerableRowCollection<TRow> OrderByDescending<TRow, TKey>(this TypedTableBase<TRow> source, Func<TRow, TKey> keySelector) where TRow : DataRow
		{
			DataSetUtil.CheckArgumentNull<TypedTableBase<TRow>>(source, "source");
			return new EnumerableRowCollection<TRow>(source).OrderByDescending(keySelector);
		}

		/// <summary>Сортирует строки объекта <see cref="T:System.Data.TypedTableBase`1" /> в порядке убывания в соответствии с указанным ключом и компаратором.</summary>
		/// <param name="source">Объект <see cref="T:System.Data.TypedTableBase`1" />, содержащий упорядочиваемые элементы <see cref="T:System.Data.DataRow" />.</param>
		/// <param name="keySelector">Функция, извлекающая ключ из элемента.</param>
		/// <param name="comparer">Компаратор <see cref="T:System.Collections.Generic.IComparer`1" />, используемый для сравнения ключей.</param>
		/// <typeparam name="TRow">Тип элементов строки в объекте <paramref name="source" />, обычно <see cref="T:System.Data.DataRow" />.</typeparam>
		/// <typeparam name="TKey">Тип ключа, возвращаемого функцией <paramref name="keySelector" />.</typeparam>
		/// <returns>Объект <see cref="T:System.Data.OrderedEnumerableRowCollection`1" />, элементы которого отсортированы по указанному ключу и компаратору.</returns>
		// Token: 0x06000061 RID: 97 RVA: 0x00003240 File Offset: 0x00001440
		public static OrderedEnumerableRowCollection<TRow> OrderByDescending<TRow, TKey>(this TypedTableBase<TRow> source, Func<TRow, TKey> keySelector, IComparer<TKey> comparer) where TRow : DataRow
		{
			DataSetUtil.CheckArgumentNull<TypedTableBase<TRow>>(source, "source");
			return new EnumerableRowCollection<TRow>(source).OrderByDescending(keySelector, comparer);
		}

		/// <summary>Проецирует каждый элемент <see cref="T:System.Data.TypedTableBase`1" /> в новую форму.</summary>
		/// <param name="source">Объект <see cref="T:System.Data.TypedTableBase`1" />, содержащий элементы <see cref="T:System.Data.DataRow" />, для которых будет вызвана функция преобразования.</param>
		/// <param name="selector">Функция преобразования, применяемая к каждому элементу.</param>
		/// <typeparam name="TRow">Тип элементов строки в объекте <paramref name="source" />, обычно <see cref="T:System.Data.DataRow" />.</typeparam>
		/// <typeparam name="S" />
		/// <returns>Объект <see cref="T:System.Data.EnumerableRowCollection`1" />, элементы которого получены в результате вызова функции преобразования для каждого элемента последовательности <paramref name="source" />.</returns>
		// Token: 0x06000062 RID: 98 RVA: 0x0000325A File Offset: 0x0000145A
		public static EnumerableRowCollection<S> Select<TRow, S>(this TypedTableBase<TRow> source, Func<TRow, S> selector) where TRow : DataRow
		{
			DataSetUtil.CheckArgumentNull<TypedTableBase<TRow>>(source, "source");
			return new EnumerableRowCollection<TRow>(source).Select(selector);
		}

		/// <summary>Перечисляет элементы строки данных <see cref="T:System.Data.TypedTableBase`1" /> и возвращает объект <see cref="T:System.Data.EnumerableRowCollection`1" />, в котором универсальный параметр <paramref name="T" /> равен <see cref="T:System.Data.DataRow" />. Этот объект может использоваться в выражении LINQ или запросе метода.</summary>
		/// <param name="source">Исходный объект <see cref="T:System.Data.TypedTableBase`1" />, который требуется сделать перечисляемым.</param>
		/// <typeparam name="TRow">Тип, в который преобразуются элементы источника.</typeparam>
		/// <returns>Объект <see cref="T:System.Data.EnumerableRowCollection`1" />, где универсальный параметр <paramref name="T" /> имеет значение <see cref="T:System.Data.DataRow" />.</returns>
		// Token: 0x06000063 RID: 99 RVA: 0x00003273 File Offset: 0x00001473
		public static EnumerableRowCollection<TRow> AsEnumerable<TRow>(this TypedTableBase<TRow> source) where TRow : DataRow
		{
			DataSetUtil.CheckArgumentNull<TypedTableBase<TRow>>(source, "source");
			return new EnumerableRowCollection<TRow>(source);
		}

		/// <summary>Возвращает элемент в указанной строке в последовательности или значение по умолчанию, если строка вне допустимого диапазона.</summary>
		/// <param name="source">Перечисляемый объект, из которого требуется возвратить элемент.</param>
		/// <param name="index">Отсчитываемый от нуля индекс извлекаемого элемента.</param>
		/// <typeparam name="TRow">Тип элементов или строки.</typeparam>
		/// <returns>Элемент, расположенный в указанной строке в последовательности.</returns>
		// Token: 0x06000064 RID: 100 RVA: 0x00003288 File Offset: 0x00001488
		public static TRow ElementAtOrDefault<TRow>(this TypedTableBase<TRow> source, int index) where TRow : DataRow
		{
			if (index >= 0 && index < source.Rows.Count)
			{
				return (TRow)((object)source.Rows[index]);
			}
			return default(TRow);
		}
	}
}
