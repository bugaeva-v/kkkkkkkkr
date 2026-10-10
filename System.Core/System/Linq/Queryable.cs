using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace System.Linq
{
	/// <summary>
	///         Предоставляет набор <see langword="static" /> (<see langword="Shared" /> в Visual Basic) методы для запроса структур данных, которые реализуют <see cref="T:System.Linq.IQueryable`1" />.
	///       </summary>
	// Token: 0x02000095 RID: 149
	public static class Queryable
	{
		/// <summary>
		///         Преобразует универсальный <see cref="T:System.Collections.Generic.IEnumerable`1" /> к универсальному <see cref="T:System.Linq.IQueryable`1" />.
		///       </summary>
		/// <param name="source">
		///           Последовательность, подлежащая преобразованию.
		///         </param>
		/// <typeparam name="TElement">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Представляющий входной последовательности.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600044D RID: 1101 RVA: 0x0000CC48 File Offset: 0x0000AE48
		public static IQueryable<TElement> AsQueryable<TElement>(this IEnumerable<TElement> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return (source as IQueryable<TElement>) ?? new EnumerableQuery<TElement>(source);
		}

		/// <summary>
		///         Преобразует <see cref="T:System.Collections.IEnumerable" /> для <see cref="T:System.Linq.IQueryable" />.
		///       </summary>
		/// <param name="source">
		///           Последовательность, подлежащая преобразованию.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable" /> Представляющий входной последовательности.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="source" /> не реализует <see cref="T:System.Collections.Generic.IEnumerable`1" /> для некоторых <paramref name="T" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600044E RID: 1102 RVA: 0x0000CC68 File Offset: 0x0000AE68
		public static IQueryable AsQueryable(this IEnumerable source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			IQueryable queryable = source as IQueryable;
			if (queryable != null)
			{
				return queryable;
			}
			Type type = TypeHelper.FindGenericType(typeof(IEnumerable<>), source.GetType());
			if (type == null)
			{
				throw Error.ArgumentNotIEnumerableGeneric("source");
			}
			return EnumerableQuery.Create(type.GenericTypeArguments[0], source);
		}

		/// <summary>
		///         Выполняет фильтрацию последовательности значений на основе заданного предиката.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Для фильтрации.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки каждого элемента на соответствие условию.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Содержащий элементы из входной последовательности, которые удовлетворяют условию, указанному в <paramref name="predicate" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="predicate" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600044F RID: 1103 RVA: 0x0000CCC8 File Offset: 0x0000AEC8
		public static IQueryable<TSource> Where<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (predicate == null)
			{
				throw Error.ArgumentNull("predicate");
			}
			return source.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.Where_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(predicate)));
		}

		/// <summary>
		///         Выполняет фильтрацию последовательности значений на основе заданного предиката.
		///          Индекс каждого элемента используется в логике функции предиката.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Для фильтрации.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки каждого элемента на соответствие условию; Второй параметр функции представляет индекс элемента в исходной последовательности.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Содержащий элементы из входной последовательности, которые удовлетворяют условию, указанному в <paramref name="predicate" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="predicate" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000450 RID: 1104 RVA: 0x0000CD20 File Offset: 0x0000AF20
		public static IQueryable<TSource> Where<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int, bool>> predicate)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (predicate == null)
			{
				throw Error.ArgumentNull("predicate");
			}
			return source.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.Where_Index_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(predicate)));
		}

		/// <summary>
		///         Фильтрует элементы <see cref="T:System.Linq.IQueryable" /> на основе указанного типа.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable" /> Элементы которой следует фильтровать.
		///         </param>
		/// <typeparam name="TResult">
		///           Тип, по которому фильтруются элементы последовательности.
		///         </typeparam>
		/// <returns>
		///         Коллекция, содержащая элементы из <paramref name="source" /> имеющие тип <paramref name="TResult" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000451 RID: 1105 RVA: 0x0000CD75 File Offset: 0x0000AF75
		public static IQueryable<TResult> OfType<TResult>(this IQueryable source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.CreateQuery<TResult>(Expression.Call(null, CachedReflectionInfo.OfType_TResult_1(typeof(TResult)), source.Expression));
		}

		/// <summary>
		///         Преобразует элементы <see cref="T:System.Linq.IQueryable" /> для указанного типа.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable" /> Содержащая преобразуемые элементы.
		///         </param>
		/// <typeparam name="TResult">
		///           Тип, который требуется преобразовать элементы <paramref name="source" /> для.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Содержит все элементы исходной последовательности, преобразованные заданный тип.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidCastException">
		///             Элемент в последовательности не может быть приведен к типу <paramref name="TResult" />.
		///           </exception>
		// Token: 0x06000452 RID: 1106 RVA: 0x0000CDAB File Offset: 0x0000AFAB
		public static IQueryable<TResult> Cast<TResult>(this IQueryable source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.CreateQuery<TResult>(Expression.Call(null, CachedReflectionInfo.Cast_TResult_1(typeof(TResult)), source.Expression));
		}

		/// <summary>
		///         Проецирует каждый элемент последовательности в новую форму.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, которые следует проецировать.
		///         </param>
		/// <param name="selector">
		///           Функция проекции, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип значения, возвращаемого функцией, представленный <paramref name="selector" />.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Элементы которого получены в результате вызова функции проекции для каждого элемента <paramref name="source" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000453 RID: 1107 RVA: 0x0000CDE4 File Offset: 0x0000AFE4
		public static IQueryable<TResult> Select<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return source.Provider.CreateQuery<TResult>(Expression.Call(null, CachedReflectionInfo.Select_TSource_TResult_2(typeof(TSource), typeof(TResult)), source.Expression, Expression.Quote(selector)));
		}

		/// <summary>
		///         Проецирует каждый элемент последовательности в новую форму, добавляя индекс элемента.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, которые следует проецировать.
		///         </param>
		/// <param name="selector">
		///           Функция проекции, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип значения, возвращаемого функцией, представленный <paramref name="selector" />.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Элементы которого получены в результате вызова функции проекции для каждого элемента <paramref name="source" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000454 RID: 1108 RVA: 0x0000CE44 File Offset: 0x0000B044
		public static IQueryable<TResult> Select<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, int, TResult>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return source.Provider.CreateQuery<TResult>(Expression.Call(null, CachedReflectionInfo.Select_Index_TSource_TResult_2(typeof(TSource), typeof(TResult)), source.Expression, Expression.Quote(selector)));
		}

		/// <summary>
		///         Проецирует каждый элемент последовательности в <see cref="T:System.Collections.Generic.IEnumerable`1" /> и объединяет результирующие последовательности в одну последовательность.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, которые следует проецировать.
		///         </param>
		/// <param name="selector">
		///           Функция проекции, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип элементов последовательности, возвращаемой функцией, представленный <paramref name="selector" />.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Элементы которого получены в результате вызова функции один ко многим проекции для каждого элемента входной последовательности.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000455 RID: 1109 RVA: 0x0000CEA4 File Offset: 0x0000B0A4
		public static IQueryable<TResult> SelectMany<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, IEnumerable<TResult>>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return source.Provider.CreateQuery<TResult>(Expression.Call(null, CachedReflectionInfo.SelectMany_TSource_TResult_2(typeof(TSource), typeof(TResult)), source.Expression, Expression.Quote(selector)));
		}

		/// <summary>
		///         Проецирует каждый элемент последовательности в <see cref="T:System.Collections.Generic.IEnumerable`1" /> и объединяет результирующие последовательности в одну последовательность.
		///          Индекс каждого элемента исходной последовательности используется в проецированной форме этого элемента.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, которые следует проецировать.
		///         </param>
		/// <param name="selector">
		///           Функция проекции, применяемая к каждому элементу; Второй параметр этой функции представляет индекс исходного элемента.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип элементов последовательности, возвращаемой функцией, представленный <paramref name="selector" />.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Элементы которого получены в результате вызова функции один ко многим проекции для каждого элемента входной последовательности.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000456 RID: 1110 RVA: 0x0000CF04 File Offset: 0x0000B104
		public static IQueryable<TResult> SelectMany<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, int, IEnumerable<TResult>>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return source.Provider.CreateQuery<TResult>(Expression.Call(null, CachedReflectionInfo.SelectMany_Index_TSource_TResult_2(typeof(TSource), typeof(TResult)), source.Expression, Expression.Quote(selector)));
		}

		/// <summary>
		///         Проецирует каждый элемент последовательности в <see cref="T:System.Collections.Generic.IEnumerable`1" /> включает индекс исходного элемента, который его создал.
		///          Для каждого элемента каждой промежуточной последовательности вызывается функция селектора результата, и результирующие значения объединяются в одну одномерную последовательность и возвращается.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, которые следует проецировать.
		///         </param>
		/// <param name="collectionSelector">
		///           Функция проекции, применяемая к каждому элементу входной последовательности; Второй параметр этой функции представляет индекс исходного элемента.
		///         </param>
		/// <param name="resultSelector">
		///           Функция проекции, применяемая к каждому элементу каждой промежуточной последовательности.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TCollection">
		///           Тип промежуточных элементов, собираемые функцией, заданной параметром <paramref name="collectionSelector" />.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип элементов результирующей последовательности.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Элементы которого получены в результате вызова функции проекции один ко многим <paramref name="collectionSelector" /> для каждого элемента <paramref name="source" /> и последующего сопоставления каждого элемента такой промежуточной последовательности и соответствующие им <paramref name="source" /> элемента с полученным элементом.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" />, <paramref name="collectionSelector" /> или <paramref name="resultSelector" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000457 RID: 1111 RVA: 0x0000CF64 File Offset: 0x0000B164
		public static IQueryable<TResult> SelectMany<TSource, TCollection, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, int, IEnumerable<TCollection>>> collectionSelector, Expression<Func<TSource, TCollection, TResult>> resultSelector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (collectionSelector == null)
			{
				throw Error.ArgumentNull("collectionSelector");
			}
			if (resultSelector == null)
			{
				throw Error.ArgumentNull("resultSelector");
			}
			return source.Provider.CreateQuery<TResult>(Expression.Call(null, CachedReflectionInfo.SelectMany_Index_TSource_TCollection_TResult_3(typeof(TSource), typeof(TCollection), typeof(TResult)), source.Expression, Expression.Quote(collectionSelector), Expression.Quote(resultSelector)));
		}

		/// <summary>
		///         Проецирует каждый элемент последовательности в <see cref="T:System.Collections.Generic.IEnumerable`1" /> и вызывает функцию селектора результата для каждого элемента этой последовательности.
		///          Результирующие значения из всех промежуточных последовательностей объединяются в одну одномерную последовательность и возвращается.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, которые следует проецировать.
		///         </param>
		/// <param name="collectionSelector">
		///           Функция проекции, применяемая к каждому элементу входной последовательности.
		///         </param>
		/// <param name="resultSelector">
		///           Функция проекции, применяемая к каждому элементу каждой промежуточной последовательности.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TCollection">
		///           Тип промежуточных элементов, собираемые функцией, заданной параметром <paramref name="collectionSelector" />.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип элементов результирующей последовательности.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Элементы которого получены в результате вызова функции проекции один ко многим <paramref name="collectionSelector" /> для каждого элемента <paramref name="source" /> и последующего сопоставления каждого элемента такой промежуточной последовательности и соответствующие им <paramref name="source" /> элемента с полученным элементом.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" />, <paramref name="collectionSelector" /> или <paramref name="resultSelector" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000458 RID: 1112 RVA: 0x0000CFE4 File Offset: 0x0000B1E4
		public static IQueryable<TResult> SelectMany<TSource, TCollection, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, IEnumerable<TCollection>>> collectionSelector, Expression<Func<TSource, TCollection, TResult>> resultSelector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (collectionSelector == null)
			{
				throw Error.ArgumentNull("collectionSelector");
			}
			if (resultSelector == null)
			{
				throw Error.ArgumentNull("resultSelector");
			}
			return source.Provider.CreateQuery<TResult>(Expression.Call(null, CachedReflectionInfo.SelectMany_TSource_TCollection_TResult_3(typeof(TSource), typeof(TCollection), typeof(TResult)), source.Expression, Expression.Quote(collectionSelector), Expression.Quote(resultSelector)));
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0000D064 File Offset: 0x0000B264
		private static Expression GetSourceExpression<TSource>(IEnumerable<TSource> source)
		{
			IQueryable<TSource> queryable = source as IQueryable<TSource>;
			if (queryable == null)
			{
				return Expression.Constant(source, typeof(IEnumerable<TSource>));
			}
			return queryable.Expression;
		}

		/// <summary>
		///         Устанавливает корреляцию между элементами двух последовательностей на основе сопоставления ключей.
		///          Для сравнения ключей используется компаратор проверки на равенство по умолчанию.
		///       </summary>
		/// <param name="outer">
		///           Первая последовательность для соединения.
		///         </param>
		/// <param name="inner">
		///           Последовательность, соединяемая с первой последовательностью.
		///         </param>
		/// <param name="outerKeySelector">
		///           Функция, извлекающая ключ соединения из каждого элемента первой последовательности.
		///         </param>
		/// <param name="innerKeySelector">
		///           Функция, извлекающая ключ соединения из каждого элемента второй последовательности.
		///         </param>
		/// <param name="resultSelector">
		///           Функция для создания результирующего элемента для пары соответствующих элементов.
		///         </param>
		/// <typeparam name="TOuter">
		///           Тип элементов первой последовательности.
		///         </typeparam>
		/// <typeparam name="TInner">
		///           Тип элементов второй последовательности.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключей, возвращаемых функциями селектора ключа.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип результирующих элементов.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Содержит элементы типа <paramref name="TResult" /> полученные в результате внутреннего соединения двух последовательностей.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="outer" /> или <paramref name="inner" /> или <paramref name="outerKeySelector" /> или <paramref name="innerKeySelector" /> или <paramref name="resultSelector" /> — <see langword="null" />.
		///           </exception>
		// Token: 0x0600045A RID: 1114 RVA: 0x0000D094 File Offset: 0x0000B294
		public static IQueryable<TResult> Join<TOuter, TInner, TKey, TResult>(this IQueryable<TOuter> outer, IEnumerable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, TInner, TResult>> resultSelector)
		{
			if (outer == null)
			{
				throw Error.ArgumentNull("outer");
			}
			if (inner == null)
			{
				throw Error.ArgumentNull("inner");
			}
			if (outerKeySelector == null)
			{
				throw Error.ArgumentNull("outerKeySelector");
			}
			if (innerKeySelector == null)
			{
				throw Error.ArgumentNull("innerKeySelector");
			}
			if (resultSelector == null)
			{
				throw Error.ArgumentNull("resultSelector");
			}
			return outer.Provider.CreateQuery<TResult>(Expression.Call(null, CachedReflectionInfo.Join_TOuter_TInner_TKey_TResult_5(typeof(TOuter), typeof(TInner), typeof(TKey), typeof(TResult)), new Expression[]
			{
				outer.Expression,
				Queryable.GetSourceExpression<TInner>(inner),
				Expression.Quote(outerKeySelector),
				Expression.Quote(innerKeySelector),
				Expression.Quote(resultSelector)
			}));
		}

		/// <summary>
		///         Устанавливает корреляцию между элементами двух последовательностей на основе сопоставления ключей.
		///          Указанный <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> используется для сравнения ключей.
		///       </summary>
		/// <param name="outer">
		///           Первая последовательность для соединения.
		///         </param>
		/// <param name="inner">
		///           Последовательность, соединяемая с первой последовательностью.
		///         </param>
		/// <param name="outerKeySelector">
		///           Функция, извлекающая ключ соединения из каждого элемента первой последовательности.
		///         </param>
		/// <param name="innerKeySelector">
		///           Функция, извлекающая ключ соединения из каждого элемента второй последовательности.
		///         </param>
		/// <param name="resultSelector">
		///           Функция для создания результирующего элемента для пары соответствующих элементов.
		///         </param>
		/// <param name="comparer">
		///           <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> Для хэширования и сравнения ключей.
		///         </param>
		/// <typeparam name="TOuter">
		///           Тип элементов первой последовательности.
		///         </typeparam>
		/// <typeparam name="TInner">
		///           Тип элементов второй последовательности.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключей, возвращаемых функциями селектора ключа.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип результирующих элементов.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Содержит элементы типа <paramref name="TResult" /> полученные в результате внутреннего соединения двух последовательностей.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="outer" /> или <paramref name="inner" /> или <paramref name="outerKeySelector" /> или <paramref name="innerKeySelector" /> или <paramref name="resultSelector" /> — <see langword="null" />.
		///           </exception>
		// Token: 0x0600045B RID: 1115 RVA: 0x0000D15C File Offset: 0x0000B35C
		public static IQueryable<TResult> Join<TOuter, TInner, TKey, TResult>(this IQueryable<TOuter> outer, IEnumerable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, TInner, TResult>> resultSelector, IEqualityComparer<TKey> comparer)
		{
			if (outer == null)
			{
				throw Error.ArgumentNull("outer");
			}
			if (inner == null)
			{
				throw Error.ArgumentNull("inner");
			}
			if (outerKeySelector == null)
			{
				throw Error.ArgumentNull("outerKeySelector");
			}
			if (innerKeySelector == null)
			{
				throw Error.ArgumentNull("innerKeySelector");
			}
			if (resultSelector == null)
			{
				throw Error.ArgumentNull("resultSelector");
			}
			return outer.Provider.CreateQuery<TResult>(Expression.Call(null, CachedReflectionInfo.Join_TOuter_TInner_TKey_TResult_6(typeof(TOuter), typeof(TInner), typeof(TKey), typeof(TResult)), new Expression[]
			{
				outer.Expression,
				Queryable.GetSourceExpression<TInner>(inner),
				Expression.Quote(outerKeySelector),
				Expression.Quote(innerKeySelector),
				Expression.Quote(resultSelector),
				Expression.Constant(comparer, typeof(IEqualityComparer<TKey>))
			}));
		}

		/// <summary>
		///         Устанавливает корреляцию между элементами двух последовательностей на основе равенства ключа и группирует результаты.
		///          Для сравнения ключей используется компаратор проверки на равенство по умолчанию.
		///       </summary>
		/// <param name="outer">
		///           Первая последовательность для соединения.
		///         </param>
		/// <param name="inner">
		///           Последовательность, соединяемая с первой последовательностью.
		///         </param>
		/// <param name="outerKeySelector">
		///           Функция, извлекающая ключ соединения из каждого элемента первой последовательности.
		///         </param>
		/// <param name="innerKeySelector">
		///           Функция, извлекающая ключ соединения из каждого элемента второй последовательности.
		///         </param>
		/// <param name="resultSelector">
		///           Функция, создающая результирующий элемент для элемента первой последовательности и коллекции соответствующих элементов второй последовательности.
		///         </param>
		/// <typeparam name="TOuter">
		///           Тип элементов первой последовательности.
		///         </typeparam>
		/// <typeparam name="TInner">
		///           Тип элементов второй последовательности.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключей, возвращаемых функциями селектора ключа.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип результирующих элементов.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Содержащий элементы типа <paramref name="TResult" /> полученные в результате группированное соединение двух последовательностей.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="outer" /> или <paramref name="inner" /> или <paramref name="outerKeySelector" /> или <paramref name="innerKeySelector" /> или <paramref name="resultSelector" /> — <see langword="null" />.
		///           </exception>
		// Token: 0x0600045C RID: 1116 RVA: 0x0000D238 File Offset: 0x0000B438
		public static IQueryable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IQueryable<TOuter> outer, IEnumerable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, IEnumerable<TInner>, TResult>> resultSelector)
		{
			if (outer == null)
			{
				throw Error.ArgumentNull("outer");
			}
			if (inner == null)
			{
				throw Error.ArgumentNull("inner");
			}
			if (outerKeySelector == null)
			{
				throw Error.ArgumentNull("outerKeySelector");
			}
			if (innerKeySelector == null)
			{
				throw Error.ArgumentNull("innerKeySelector");
			}
			if (resultSelector == null)
			{
				throw Error.ArgumentNull("resultSelector");
			}
			return outer.Provider.CreateQuery<TResult>(Expression.Call(null, CachedReflectionInfo.GroupJoin_TOuter_TInner_TKey_TResult_5(typeof(TOuter), typeof(TInner), typeof(TKey), typeof(TResult)), new Expression[]
			{
				outer.Expression,
				Queryable.GetSourceExpression<TInner>(inner),
				Expression.Quote(outerKeySelector),
				Expression.Quote(innerKeySelector),
				Expression.Quote(resultSelector)
			}));
		}

		/// <summary>
		///         Устанавливает корреляцию между элементами двух последовательностей на основе равенства ключа и группирует результаты.
		///          Указанный <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> используется для сравнения ключей.
		///       </summary>
		/// <param name="outer">
		///           Первая последовательность для соединения.
		///         </param>
		/// <param name="inner">
		///           Последовательность, соединяемая с первой последовательностью.
		///         </param>
		/// <param name="outerKeySelector">
		///           Функция, извлекающая ключ соединения из каждого элемента первой последовательности.
		///         </param>
		/// <param name="innerKeySelector">
		///           Функция, извлекающая ключ соединения из каждого элемента второй последовательности.
		///         </param>
		/// <param name="resultSelector">
		///           Функция, создающая результирующий элемент для элемента первой последовательности и коллекции соответствующих элементов второй последовательности.
		///         </param>
		/// <param name="comparer">
		///           Компаратор для хеширования и сравнения ключей.
		///         </param>
		/// <typeparam name="TOuter">
		///           Тип элементов первой последовательности.
		///         </typeparam>
		/// <typeparam name="TInner">
		///           Тип элементов второй последовательности.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключей, возвращаемых функциями селектора ключа.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип результирующих элементов.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Содержащий элементы типа <paramref name="TResult" /> полученные в результате группированное соединение двух последовательностей.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="outer" /> или <paramref name="inner" /> или <paramref name="outerKeySelector" /> или <paramref name="innerKeySelector" /> или <paramref name="resultSelector" /> — <see langword="null" />.
		///           </exception>
		// Token: 0x0600045D RID: 1117 RVA: 0x0000D300 File Offset: 0x0000B500
		public static IQueryable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IQueryable<TOuter> outer, IEnumerable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, IEnumerable<TInner>, TResult>> resultSelector, IEqualityComparer<TKey> comparer)
		{
			if (outer == null)
			{
				throw Error.ArgumentNull("outer");
			}
			if (inner == null)
			{
				throw Error.ArgumentNull("inner");
			}
			if (outerKeySelector == null)
			{
				throw Error.ArgumentNull("outerKeySelector");
			}
			if (innerKeySelector == null)
			{
				throw Error.ArgumentNull("innerKeySelector");
			}
			if (resultSelector == null)
			{
				throw Error.ArgumentNull("resultSelector");
			}
			return outer.Provider.CreateQuery<TResult>(Expression.Call(null, CachedReflectionInfo.GroupJoin_TOuter_TInner_TKey_TResult_6(typeof(TOuter), typeof(TInner), typeof(TKey), typeof(TResult)), new Expression[]
			{
				outer.Expression,
				Queryable.GetSourceExpression<TInner>(inner),
				Expression.Quote(outerKeySelector),
				Expression.Quote(innerKeySelector),
				Expression.Quote(resultSelector),
				Expression.Constant(comparer, typeof(IEqualityComparer<TKey>))
			}));
		}

		/// <summary>
		///         Сортирует элементы последовательности в возрастающем порядке по ключу.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, которые следует упорядочить.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ из элемента.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией, представленного <paramref name="keySelector" />.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IOrderedQueryable`1" /> Элементы которой сортируются по ключу.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="keySelector" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600045E RID: 1118 RVA: 0x0000D3DC File Offset: 0x0000B5DC
		public static IOrderedQueryable<TSource> OrderBy<TSource, TKey>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (keySelector == null)
			{
				throw Error.ArgumentNull("keySelector");
			}
			return (IOrderedQueryable<TSource>)source.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.OrderBy_TSource_TKey_2(typeof(TSource), typeof(TKey)), source.Expression, Expression.Quote(keySelector)));
		}

		/// <summary>
		///         Сортирует элементы последовательности в порядке возрастания с использованием указанного компаратора.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, которые следует упорядочить.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ из элемента.
		///         </param>
		/// <param name="comparer">
		///           <see cref="T:System.Collections.Generic.IComparer`1" /> Для сравнения ключей.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией, представленного <paramref name="keySelector" />.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IOrderedQueryable`1" /> Элементы которой сортируются по ключу.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" />, <paramref name="keySelector" /> или <paramref name="comparer" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600045F RID: 1119 RVA: 0x0000D440 File Offset: 0x0000B640
		public static IOrderedQueryable<TSource> OrderBy<TSource, TKey>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IComparer<TKey> comparer)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (keySelector == null)
			{
				throw Error.ArgumentNull("keySelector");
			}
			return (IOrderedQueryable<TSource>)source.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.OrderBy_TSource_TKey_3(typeof(TSource), typeof(TKey)), source.Expression, Expression.Quote(keySelector), Expression.Constant(comparer, typeof(IComparer<TKey>))));
		}

		/// <summary>
		///         Сортирует элементы последовательности в порядке убывания ключа.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, которые следует упорядочить.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ из элемента.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией, представленного <paramref name="keySelector" />.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IOrderedQueryable`1" /> Элементы которой сортируются в порядке убывания ключа.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="keySelector" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000460 RID: 1120 RVA: 0x0000D4B4 File Offset: 0x0000B6B4
		public static IOrderedQueryable<TSource> OrderByDescending<TSource, TKey>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (keySelector == null)
			{
				throw Error.ArgumentNull("keySelector");
			}
			return (IOrderedQueryable<TSource>)source.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.OrderByDescending_TSource_TKey_2(typeof(TSource), typeof(TKey)), source.Expression, Expression.Quote(keySelector)));
		}

		/// <summary>
		///         Сортирует элементы последовательности в порядке убывания с использованием указанного компаратора.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, которые следует упорядочить.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ из элемента.
		///         </param>
		/// <param name="comparer">
		///           <see cref="T:System.Collections.Generic.IComparer`1" /> Для сравнения ключей.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией, представленного <paramref name="keySelector" />.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IOrderedQueryable`1" /> Элементы которой сортируются в порядке убывания ключа.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" />, <paramref name="keySelector" /> или <paramref name="comparer" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000461 RID: 1121 RVA: 0x0000D518 File Offset: 0x0000B718
		public static IOrderedQueryable<TSource> OrderByDescending<TSource, TKey>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IComparer<TKey> comparer)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (keySelector == null)
			{
				throw Error.ArgumentNull("keySelector");
			}
			return (IOrderedQueryable<TSource>)source.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.OrderByDescending_TSource_TKey_3(typeof(TSource), typeof(TKey)), source.Expression, Expression.Quote(keySelector), Expression.Constant(comparer, typeof(IComparer<TKey>))));
		}

		/// <summary>
		///         Выполняет дополнительное упорядочение элементов последовательности в порядке по возрастанию по ключу.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IOrderedQueryable`1" /> Содержащий элементы для сортировки.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ из каждого элемента.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией, представленный <paramref name="keySelector" />.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IOrderedQueryable`1" /> Элементы которой сортируются по ключу.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="keySelector" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000462 RID: 1122 RVA: 0x0000D58C File Offset: 0x0000B78C
		public static IOrderedQueryable<TSource> ThenBy<TSource, TKey>(this IOrderedQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (keySelector == null)
			{
				throw Error.ArgumentNull("keySelector");
			}
			return (IOrderedQueryable<TSource>)source.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.ThenBy_TSource_TKey_2(typeof(TSource), typeof(TKey)), source.Expression, Expression.Quote(keySelector)));
		}

		/// <summary>
		///         Выполняет дополнительное упорядочение элементов последовательности в порядке возрастания с использованием указанного компаратора.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IOrderedQueryable`1" /> Содержащий элементы для сортировки.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ из каждого элемента.
		///         </param>
		/// <param name="comparer">
		///           <see cref="T:System.Collections.Generic.IComparer`1" /> Для сравнения ключей.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией, представленный <paramref name="keySelector" />.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IOrderedQueryable`1" /> Элементы которой сортируются по ключу.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" />, <paramref name="keySelector" /> или <paramref name="comparer" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000463 RID: 1123 RVA: 0x0000D5F0 File Offset: 0x0000B7F0
		public static IOrderedQueryable<TSource> ThenBy<TSource, TKey>(this IOrderedQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IComparer<TKey> comparer)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (keySelector == null)
			{
				throw Error.ArgumentNull("keySelector");
			}
			return (IOrderedQueryable<TSource>)source.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.ThenBy_TSource_TKey_3(typeof(TSource), typeof(TKey)), source.Expression, Expression.Quote(keySelector), Expression.Constant(comparer, typeof(IComparer<TKey>))));
		}

		/// <summary>
		///         Выполняет дополнительное упорядочение элементов последовательности в порядке убывания ключа.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IOrderedQueryable`1" /> Содержащий элементы для сортировки.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ из каждого элемента.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией, представленный <paramref name="keySelector" />.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IOrderedQueryable`1" /> Элементы которой сортируются в порядке убывания ключа.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="keySelector" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000464 RID: 1124 RVA: 0x0000D664 File Offset: 0x0000B864
		public static IOrderedQueryable<TSource> ThenByDescending<TSource, TKey>(this IOrderedQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (keySelector == null)
			{
				throw Error.ArgumentNull("keySelector");
			}
			return (IOrderedQueryable<TSource>)source.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.ThenByDescending_TSource_TKey_2(typeof(TSource), typeof(TKey)), source.Expression, Expression.Quote(keySelector)));
		}

		/// <summary>
		///         Выполняет дополнительное упорядочение элементов последовательности в порядке убывания с использованием указанного компаратора.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IOrderedQueryable`1" /> Содержащий элементы для сортировки.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ из каждого элемента.
		///         </param>
		/// <param name="comparer">
		///           <see cref="T:System.Collections.Generic.IComparer`1" /> Для сравнения ключей.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, который возвращается <paramref name="keySelector" /> функции.
		///         </typeparam>
		/// <returns>
		///         Коллекция, элементы которой сортируются в порядке убывания ключа.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" />, <paramref name="keySelector" /> или <paramref name="comparer" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000465 RID: 1125 RVA: 0x0000D6C8 File Offset: 0x0000B8C8
		public static IOrderedQueryable<TSource> ThenByDescending<TSource, TKey>(this IOrderedQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IComparer<TKey> comparer)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (keySelector == null)
			{
				throw Error.ArgumentNull("keySelector");
			}
			return (IOrderedQueryable<TSource>)source.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.ThenByDescending_TSource_TKey_3(typeof(TSource), typeof(TKey)), source.Expression, Expression.Quote(keySelector), Expression.Constant(comparer, typeof(IComparer<TKey>))));
		}

		/// <summary>
		///         Возвращает заданное число смежных элементов с начала последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность, из которой требуется возвратить элементы.
		///         </param>
		/// <param name="count">
		///           Число возвращаемых элементов.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Содержащий указанное число элементов с начала <paramref name="source" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000466 RID: 1126 RVA: 0x0000D73C File Offset: 0x0000B93C
		public static IQueryable<TSource> Take<TSource>(this IQueryable<TSource> source, int count)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.Take_TSource_2(typeof(TSource)), source.Expression, Expression.Constant(count)));
		}

		/// <summary>
		///         Возвращает элементы из последовательности, пока указанное условие истинно.
		///       </summary>
		/// <param name="source">
		///           Последовательность, из которой требуется возвратить элементы.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки каждого элемента на соответствие условию.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Содержащая элементы входной последовательности до первого элемента, указанные теста по <paramref name="predicate" /> не прошел.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="predicate" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000467 RID: 1127 RVA: 0x0000D788 File Offset: 0x0000B988
		public static IQueryable<TSource> TakeWhile<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (predicate == null)
			{
				throw Error.ArgumentNull("predicate");
			}
			return source.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.TakeWhile_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(predicate)));
		}

		/// <summary>
		///         Возвращает элементы из последовательности, пока указанное условие истинно.
		///          Индекс элемента используется в логике функции предиката.
		///       </summary>
		/// <param name="source">
		///           Последовательность, из которой требуется возвратить элементы.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки каждого элемента на соответствие условию; Второй параметр функции представляет индекс элемента в исходной последовательности.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Содержащая элементы входной последовательности до первого элемента, указанные теста по <paramref name="predicate" /> не прошел.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="predicate" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000468 RID: 1128 RVA: 0x0000D7E0 File Offset: 0x0000B9E0
		public static IQueryable<TSource> TakeWhile<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int, bool>> predicate)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (predicate == null)
			{
				throw Error.ArgumentNull("predicate");
			}
			return source.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.TakeWhile_Index_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(predicate)));
		}

		/// <summary>
		///         Пропускает заданное число элементов в последовательности и возвращает остальные элементы.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Требуется возвратить элементы.
		///         </param>
		/// <param name="count">
		///           Число элементов, пропускаемых перед возвращением остальных элементов.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Содержащий элементы, начиная с указанного индекса в входной последовательности.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000469 RID: 1129 RVA: 0x0000D838 File Offset: 0x0000BA38
		public static IQueryable<TSource> Skip<TSource>(this IQueryable<TSource> source, int count)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.Skip_TSource_2(typeof(TSource)), source.Expression, Expression.Constant(count)));
		}

		/// <summary>
		///         Пропускает элементы в последовательности, пока заданное условие истинно и затем возвращает оставшиеся элементы.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Требуется возвратить элементы.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки каждого элемента на соответствие условию.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Содержащий элементы из <paramref name="source" /> начиная с первого элемента, в который не прошел проверку, определенную предикатом <paramref name="predicate" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="predicate" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600046A RID: 1130 RVA: 0x0000D884 File Offset: 0x0000BA84
		public static IQueryable<TSource> SkipWhile<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (predicate == null)
			{
				throw Error.ArgumentNull("predicate");
			}
			return source.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.SkipWhile_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(predicate)));
		}

		/// <summary>
		///         Пропускает элементы в последовательности, пока заданное условие истинно и затем возвращает оставшиеся элементы.
		///          Индекс элемента используется в логике функции предиката.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Требуется возвратить элементы.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки каждого элемента на соответствие условию; Второй параметр этой функции представляет индекс исходного элемента.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Содержащий элементы из <paramref name="source" /> начиная с первого элемента, в который не прошел проверку, определенную предикатом <paramref name="predicate" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="predicate" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600046B RID: 1131 RVA: 0x0000D8DC File Offset: 0x0000BADC
		public static IQueryable<TSource> SkipWhile<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int, bool>> predicate)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (predicate == null)
			{
				throw Error.ArgumentNull("predicate");
			}
			return source.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.SkipWhile_Index_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(predicate)));
		}

		/// <summary>
		///         Группирует элементы последовательности в соответствии с заданной функцией селектора ключа.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Элементы которой требуется сгруппировать.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ для каждого элемента.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией, заданной в <paramref name="keySelector" />.
		///         </typeparam>
		/// <returns>
		///         IQueryable&lt;IGrouping&lt;TKey, TSource&gt;&gt; В C# или IQueryable(Of IGrouping(Of TKey, TSource)) в Visual Basic где каждый <see cref="T:System.Linq.IGrouping`2" /> объект содержит последовательность объектов и ключ.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="keySelector" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600046C RID: 1132 RVA: 0x0000D934 File Offset: 0x0000BB34
		public static IQueryable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (keySelector == null)
			{
				throw Error.ArgumentNull("keySelector");
			}
			return source.Provider.CreateQuery<IGrouping<TKey, TSource>>(Expression.Call(null, CachedReflectionInfo.GroupBy_TSource_TKey_2(typeof(TSource), typeof(TKey)), source.Expression, Expression.Quote(keySelector)));
		}

		/// <summary>
		///         Группирует элементы последовательности в соответствии с заданной функцией селектора ключа и проецирует элементы каждой группы с помощью указанной функции.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Элементы которой требуется сгруппировать.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ для каждого элемента.
		///         </param>
		/// <param name="elementSelector">
		///           Функция, сопоставляющая каждый исходный элемент с элементом в <see cref="T:System.Linq.IGrouping`2" />.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией, заданной в <paramref name="keySelector" />.
		///         </typeparam>
		/// <typeparam name="TElement">
		///           Тип элементов в каждом <see cref="T:System.Linq.IGrouping`2" />.
		///         </typeparam>
		/// <returns>
		///         IQueryable&lt;IGrouping&lt;TKey, TElement&gt;&gt; В C# или IQueryable(Of IGrouping(Of TKey, TElement)) в Visual Basic где каждый <see cref="T:System.Linq.IGrouping`2" /> содержит последовательность объектов типа <paramref name="TElement" /> и ключ.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" />, <paramref name="keySelector" /> или <paramref name="elementSelector" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600046D RID: 1133 RVA: 0x0000D994 File Offset: 0x0000BB94
		public static IQueryable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TSource, TElement>> elementSelector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (keySelector == null)
			{
				throw Error.ArgumentNull("keySelector");
			}
			if (elementSelector == null)
			{
				throw Error.ArgumentNull("elementSelector");
			}
			return source.Provider.CreateQuery<IGrouping<TKey, TElement>>(Expression.Call(null, CachedReflectionInfo.GroupBy_TSource_TKey_TElement_3(typeof(TSource), typeof(TKey), typeof(TElement)), source.Expression, Expression.Quote(keySelector), Expression.Quote(elementSelector)));
		}

		/// <summary>
		///         Группирует элементы последовательности в соответствии с заданной функцией селектора ключа и сравнивает ключи с помощью указанного компаратора.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Элементы которой требуется сгруппировать.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ для каждого элемента.
		///         </param>
		/// <param name="comparer">
		///           <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> Для сравнения ключей.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией, заданной в <paramref name="keySelector" />.
		///         </typeparam>
		/// <returns>
		///         IQueryable&lt;IGrouping&lt;TKey, TSource&gt;&gt; В C# или IQueryable(Of IGrouping(Of TKey, TSource)) в Visual Basic где каждый <see cref="T:System.Linq.IGrouping`2" /> содержит последовательность объектов и ключ.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" />, <paramref name="keySelector" /> или <paramref name="comparer" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600046E RID: 1134 RVA: 0x0000DA14 File Offset: 0x0000BC14
		public static IQueryable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IEqualityComparer<TKey> comparer)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (keySelector == null)
			{
				throw Error.ArgumentNull("keySelector");
			}
			return source.Provider.CreateQuery<IGrouping<TKey, TSource>>(Expression.Call(null, CachedReflectionInfo.GroupBy_TSource_TKey_3(typeof(TSource), typeof(TKey)), source.Expression, Expression.Quote(keySelector), Expression.Constant(comparer, typeof(IEqualityComparer<TKey>))));
		}

		/// <summary>
		///         Группирует элементы последовательности и проецирует элементы каждой группы с помощью указанной функции.
		///          Значения ключей сравниваются с помощью указанного компаратора.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Элементы которой требуется сгруппировать.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ для каждого элемента.
		///         </param>
		/// <param name="elementSelector">
		///           Функция, сопоставляющая каждый исходный элемент с элементом в <see cref="T:System.Linq.IGrouping`2" />.
		///         </param>
		/// <param name="comparer">
		///           <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> Для сравнения ключей.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией, заданной в <paramref name="keySelector" />.
		///         </typeparam>
		/// <typeparam name="TElement">
		///           Тип элементов в каждом <see cref="T:System.Linq.IGrouping`2" />.
		///         </typeparam>
		/// <returns>
		///         IQueryable&lt;IGrouping&lt;TKey, TElement&gt;&gt; В C# или IQueryable(Of IGrouping(Of TKey, TElement)) в Visual Basic где каждый <see cref="T:System.Linq.IGrouping`2" /> содержит последовательность объектов типа <paramref name="TElement" /> и ключ.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение параметра <paramref name="source" /> или <paramref name="keySelector" /> или <paramref name="elementSelector" /> или <paramref name="comparer" /> — <see langword="null" />.
		///           </exception>
		// Token: 0x0600046F RID: 1135 RVA: 0x0000DA84 File Offset: 0x0000BC84
		public static IQueryable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TSource, TElement>> elementSelector, IEqualityComparer<TKey> comparer)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (keySelector == null)
			{
				throw Error.ArgumentNull("keySelector");
			}
			if (elementSelector == null)
			{
				throw Error.ArgumentNull("elementSelector");
			}
			return source.Provider.CreateQuery<IGrouping<TKey, TElement>>(Expression.Call(null, CachedReflectionInfo.GroupBy_TSource_TKey_TElement_4(typeof(TSource), typeof(TKey), typeof(TElement)), new Expression[]
			{
				source.Expression,
				Expression.Quote(keySelector),
				Expression.Quote(elementSelector),
				Expression.Constant(comparer, typeof(IEqualityComparer<TKey>))
			}));
		}

		/// <summary>
		///         Группирует элементы последовательности в соответствии с заданной функцией селектора ключа и создает результирующее значение для каждой группы и ее ключа.
		///          Элементы каждой группы проецируются с помощью указанной функции.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Элементы которой требуется сгруппировать.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ для каждого элемента.
		///         </param>
		/// <param name="elementSelector">
		///           Функция, сопоставляющая каждый исходный элемент с элементом в <see cref="T:System.Linq.IGrouping`2" />.
		///         </param>
		/// <param name="resultSelector">
		///           Функция для создания результирующего значения для каждой группы.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией, заданной в <paramref name="keySelector" />.
		///         </typeparam>
		/// <typeparam name="TElement">
		///           Тип элементов в каждом <see cref="T:System.Linq.IGrouping`2" />.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип результирующего значения, возвращаемые <paramref name="resultSelector" />.
		///         </typeparam>
		/// <returns>
		///         T:System.Linq.IQueryable`1 С аргументом типа <paramref name="TResult" /> и где каждый элемент представляет проекцию группы и ее ключа.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение параметра <paramref name="source" /> или <paramref name="keySelector" /> или <paramref name="elementSelector" /> или <paramref name="resultSelector" /> — <see langword="null" />.
		///           </exception>
		// Token: 0x06000470 RID: 1136 RVA: 0x0000DB24 File Offset: 0x0000BD24
		public static IQueryable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TSource, TElement>> elementSelector, Expression<Func<TKey, IEnumerable<TElement>, TResult>> resultSelector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (keySelector == null)
			{
				throw Error.ArgumentNull("keySelector");
			}
			if (elementSelector == null)
			{
				throw Error.ArgumentNull("elementSelector");
			}
			if (resultSelector == null)
			{
				throw Error.ArgumentNull("resultSelector");
			}
			return source.Provider.CreateQuery<TResult>(Expression.Call(null, CachedReflectionInfo.GroupBy_TSource_TKey_TElement_TResult_4(typeof(TSource), typeof(TKey), typeof(TElement), typeof(TResult)), new Expression[]
			{
				source.Expression,
				Expression.Quote(keySelector),
				Expression.Quote(elementSelector),
				Expression.Quote(resultSelector)
			}));
		}

		/// <summary>
		///         Группирует элементы последовательности в соответствии с заданной функцией селектора ключа и создает результирующее значение для каждой группы и ее ключа.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Элементы которой требуется сгруппировать.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ для каждого элемента.
		///         </param>
		/// <param name="resultSelector">
		///           Функция для создания результирующего значения для каждой группы.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией, заданной в <paramref name="keySelector" />.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип результирующего значения, возвращаемые <paramref name="resultSelector" />.
		///         </typeparam>
		/// <returns>
		///         T:System.Linq.IQueryable`1 С аргументом типа <paramref name="TResult" /> и где каждый элемент представляет проекцию группы и ее ключа.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" />, <paramref name="keySelector" /> или <paramref name="resultSelector" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000471 RID: 1137 RVA: 0x0000DBD4 File Offset: 0x0000BDD4
		public static IQueryable<TResult> GroupBy<TSource, TKey, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TKey, IEnumerable<TSource>, TResult>> resultSelector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (keySelector == null)
			{
				throw Error.ArgumentNull("keySelector");
			}
			if (resultSelector == null)
			{
				throw Error.ArgumentNull("resultSelector");
			}
			return source.Provider.CreateQuery<TResult>(Expression.Call(null, CachedReflectionInfo.GroupBy_TSource_TKey_TResult_3(typeof(TSource), typeof(TKey), typeof(TResult)), source.Expression, Expression.Quote(keySelector), Expression.Quote(resultSelector)));
		}

		/// <summary>
		///         Группирует элементы последовательности в соответствии с заданной функцией селектора ключа и создает результирующее значение для каждой группы и ее ключа.
		///          Ключи сравниваются с помощью указанного компаратора.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Элементы которой требуется сгруппировать.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ для каждого элемента.
		///         </param>
		/// <param name="resultSelector">
		///           Функция для создания результирующего значения для каждой группы.
		///         </param>
		/// <param name="comparer">
		///           <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> Для сравнения ключей.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией, заданной в <paramref name="keySelector" />.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип результирующего значения, возвращаемые <paramref name="resultSelector" />.
		///         </typeparam>
		/// <returns>
		///         T:System.Linq.IQueryable`1 С аргументом типа <paramref name="TResult" /> и где каждый элемент представляет проекцию группы и ее ключа.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение параметра <paramref name="source" /> или <paramref name="keySelector" /> или <paramref name="resultSelector" /> или <paramref name="comparer" /> — <see langword="null" />.
		///           </exception>
		// Token: 0x06000472 RID: 1138 RVA: 0x0000DC54 File Offset: 0x0000BE54
		public static IQueryable<TResult> GroupBy<TSource, TKey, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TKey, IEnumerable<TSource>, TResult>> resultSelector, IEqualityComparer<TKey> comparer)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (keySelector == null)
			{
				throw Error.ArgumentNull("keySelector");
			}
			if (resultSelector == null)
			{
				throw Error.ArgumentNull("resultSelector");
			}
			return source.Provider.CreateQuery<TResult>(Expression.Call(null, CachedReflectionInfo.GroupBy_TSource_TKey_TResult_4(typeof(TSource), typeof(TKey), typeof(TResult)), new Expression[]
			{
				source.Expression,
				Expression.Quote(keySelector),
				Expression.Quote(resultSelector),
				Expression.Constant(comparer, typeof(IEqualityComparer<TKey>))
			}));
		}

		/// <summary>
		///         Группирует элементы последовательности в соответствии с заданной функцией селектора ключа и создает результирующее значение для каждой группы и ее ключа.
		///          Ключи сравниваются с помощью указанного компаратора, элементы каждой группы проецируются с помощью указанной функции.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Элементы которой требуется сгруппировать.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ для каждого элемента.
		///         </param>
		/// <param name="elementSelector">
		///           Функция, сопоставляющая каждый исходный элемент с элементом в <see cref="T:System.Linq.IGrouping`2" />.
		///         </param>
		/// <param name="resultSelector">
		///           Функция для создания результирующего значения для каждой группы.
		///         </param>
		/// <param name="comparer">
		///           <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> Для сравнения ключей.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией, заданной в <paramref name="keySelector" />.
		///         </typeparam>
		/// <typeparam name="TElement">
		///           Тип элементов в каждом <see cref="T:System.Linq.IGrouping`2" />.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип результирующего значения, возвращаемые <paramref name="resultSelector" />.
		///         </typeparam>
		/// <returns>
		///         T:System.Linq.IQueryable`1 С аргументом типа <paramref name="TResult" /> и где каждый элемент представляет проекцию группы и ее ключа.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="keySelector" /> или <paramref name="elementSelector" /> или <paramref name="resultSelector" /> или <paramref name="comparer" /> — <see langword="null" />.
		///           </exception>
		// Token: 0x06000473 RID: 1139 RVA: 0x0000DCF4 File Offset: 0x0000BEF4
		public static IQueryable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TSource, TElement>> elementSelector, Expression<Func<TKey, IEnumerable<TElement>, TResult>> resultSelector, IEqualityComparer<TKey> comparer)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (keySelector == null)
			{
				throw Error.ArgumentNull("keySelector");
			}
			if (elementSelector == null)
			{
				throw Error.ArgumentNull("elementSelector");
			}
			if (resultSelector == null)
			{
				throw Error.ArgumentNull("resultSelector");
			}
			return source.Provider.CreateQuery<TResult>(Expression.Call(null, CachedReflectionInfo.GroupBy_TSource_TKey_TElement_TResult_5(typeof(TSource), typeof(TKey), typeof(TElement), typeof(TResult)), new Expression[]
			{
				source.Expression,
				Expression.Quote(keySelector),
				Expression.Quote(elementSelector),
				Expression.Quote(resultSelector),
				Expression.Constant(comparer, typeof(IEqualityComparer<TKey>))
			}));
		}

		/// <summary>
		///         Возвращает различающиеся элементы последовательности, используя для сравнения значений компаратор проверки на равенство по умолчанию.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Для удаления дубликатов.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Содержащая различающиеся элементы из <paramref name="source" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000474 RID: 1140 RVA: 0x0000DDB5 File Offset: 0x0000BFB5
		public static IQueryable<TSource> Distinct<TSource>(this IQueryable<TSource> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.Distinct_TSource_1(typeof(TSource)), source.Expression));
		}

		/// <summary>
		///         Возвращает различающиеся элементы последовательности, используя указанную <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> для сравнения значений.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Для удаления дубликатов.
		///         </param>
		/// <param name="comparer">
		///           <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> Для сравнения значений.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Содержащая различающиеся элементы из <paramref name="source" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="comparer" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000475 RID: 1141 RVA: 0x0000DDEC File Offset: 0x0000BFEC
		public static IQueryable<TSource> Distinct<TSource>(this IQueryable<TSource> source, IEqualityComparer<TSource> comparer)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.Distinct_TSource_2(typeof(TSource)), source.Expression, Expression.Constant(comparer, typeof(IEqualityComparer<TSource>))));
		}

		/// <summary>
		///         Объединяет две последовательности.
		///       </summary>
		/// <param name="source1">
		///           Первая из объединяемых последовательностей.
		///         </param>
		/// <param name="source2">
		///           Последовательность, объединяемая с первой последовательностью.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов входных последовательностей.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Содержащая сцепленные элементы двух входных последовательностей.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source1" /> или <paramref name="source2" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000476 RID: 1142 RVA: 0x0000DE40 File Offset: 0x0000C040
		public static IQueryable<TSource> Concat<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2)
		{
			if (source1 == null)
			{
				throw Error.ArgumentNull("source1");
			}
			if (source2 == null)
			{
				throw Error.ArgumentNull("source2");
			}
			return source1.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.Concat_TSource_2(typeof(TSource)), source1.Expression, Queryable.GetSourceExpression<TSource>(source2)));
		}

		/// <summary>
		///         Объединяет две последовательности, используя указанную функцию предиката.
		///       </summary>
		/// <param name="source1">
		///           Первая последовательность для объединения.
		///         </param>
		/// <param name="source2">
		///           Вторая последовательность для объединения.
		///         </param>
		/// <param name="resultSelector">
		///           Функция, которая указывает, как объединить элементы двух последовательностей.
		///         </param>
		/// <typeparam name="TFirst">
		///           Тип элементов первой входной последовательностью.
		///         </typeparam>
		/// <typeparam name="TSecond">
		///           Тип элементов второй входной последовательности.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип элементов полученной последовательности.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> , Содержащий объединенные элементы двух входных последовательностей.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source1" />или <paramref name="source2 " />— <see langword="null" />.
		///           </exception>
		// Token: 0x06000477 RID: 1143 RVA: 0x0000DE98 File Offset: 0x0000C098
		public static IQueryable<TResult> Zip<TFirst, TSecond, TResult>(this IQueryable<TFirst> source1, IEnumerable<TSecond> source2, Expression<Func<TFirst, TSecond, TResult>> resultSelector)
		{
			if (source1 == null)
			{
				throw Error.ArgumentNull("source1");
			}
			if (source2 == null)
			{
				throw Error.ArgumentNull("source2");
			}
			if (resultSelector == null)
			{
				throw Error.ArgumentNull("resultSelector");
			}
			return source1.Provider.CreateQuery<TResult>(Expression.Call(null, CachedReflectionInfo.Zip_TFirst_TSecond_TResult_3(typeof(TFirst), typeof(TSecond), typeof(TResult)), source1.Expression, Queryable.GetSourceExpression<TSecond>(source2), Expression.Quote(resultSelector)));
		}

		/// <summary>
		///         Находит объединения наборов двух последовательностей, используя компаратор проверки на равенство по умолчанию.
		///       </summary>
		/// <param name="source1">
		///           Последовательность, различающиеся элементы которой образуют первое множество для операции объединения.
		///         </param>
		/// <param name="source2">
		///           Последовательность, различающиеся элементы которой образуют второе множество для операции объединения.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов входных последовательностей.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Содержащий элементы из обеих входных последовательностях, кроме дубликатов.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source1" /> или <paramref name="source2" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000478 RID: 1144 RVA: 0x0000DF18 File Offset: 0x0000C118
		public static IQueryable<TSource> Union<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2)
		{
			if (source1 == null)
			{
				throw Error.ArgumentNull("source1");
			}
			if (source2 == null)
			{
				throw Error.ArgumentNull("source2");
			}
			return source1.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.Union_TSource_2(typeof(TSource)), source1.Expression, Queryable.GetSourceExpression<TSource>(source2)));
		}

		/// <summary>
		///         Создает объединения наборов двух последовательностей с использованием указанного <see cref="T:System.Collections.Generic.IEqualityComparer`1" />.
		///       </summary>
		/// <param name="source1">
		///           Последовательность, различающиеся элементы которой образуют первое множество для операции объединения.
		///         </param>
		/// <param name="source2">
		///           Последовательность, различающиеся элементы которой образуют второе множество для операции объединения.
		///         </param>
		/// <param name="comparer">
		///           <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> Для сравнения значений.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов входных последовательностей.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Содержащий элементы из обеих входных последовательностях, кроме дубликатов.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source1" /> или <paramref name="source2" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000479 RID: 1145 RVA: 0x0000DF70 File Offset: 0x0000C170
		public static IQueryable<TSource> Union<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2, IEqualityComparer<TSource> comparer)
		{
			if (source1 == null)
			{
				throw Error.ArgumentNull("source1");
			}
			if (source2 == null)
			{
				throw Error.ArgumentNull("source2");
			}
			return source1.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.Union_TSource_3(typeof(TSource)), source1.Expression, Queryable.GetSourceExpression<TSource>(source2), Expression.Constant(comparer, typeof(IEqualityComparer<TSource>))));
		}

		/// <summary>
		///         Находит пересечение двух последовательностей, используя для сравнения значений компаратор проверки на равенство по умолчанию.
		///       </summary>
		/// <param name="source1">
		///           Последовательность, различающиеся элементы которой, входящие также в <paramref name="source2" /> возвращаются.
		///         </param>
		/// <param name="source2">
		///           Последовательность, различающиеся элементы которой, входящие также в первую последовательность, возвращаются.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов входных последовательностей.
		///         </typeparam>
		/// <returns>
		///         Последовательность, содержащая пересечения наборов двух последовательностей.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source1" /> или <paramref name="source2" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600047A RID: 1146 RVA: 0x0000DFD8 File Offset: 0x0000C1D8
		public static IQueryable<TSource> Intersect<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2)
		{
			if (source1 == null)
			{
				throw Error.ArgumentNull("source1");
			}
			if (source2 == null)
			{
				throw Error.ArgumentNull("source2");
			}
			return source1.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.Intersect_TSource_2(typeof(TSource)), source1.Expression, Queryable.GetSourceExpression<TSource>(source2)));
		}

		/// <summary>
		///         Находит пересечение двух последовательностей, используя указанный <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> для сравнения значений.
		///       </summary>
		/// <param name="source1">
		///           <see cref="T:System.Linq.IQueryable`1" /> Различающиеся элементы которой, входящие также в <paramref name="source2" /> возвращаются.
		///         </param>
		/// <param name="source2">
		///           <see cref="T:System.Collections.Generic.IEnumerable`1" /> Возвращаются, различающиеся элементы которой, входящие также в первую последовательность.
		///         </param>
		/// <param name="comparer">
		///           <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> Для сравнения значений.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов входных последовательностей.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Содержащий пересечения наборов двух последовательностей.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source1" /> или <paramref name="source2" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600047B RID: 1147 RVA: 0x0000E030 File Offset: 0x0000C230
		public static IQueryable<TSource> Intersect<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2, IEqualityComparer<TSource> comparer)
		{
			if (source1 == null)
			{
				throw Error.ArgumentNull("source1");
			}
			if (source2 == null)
			{
				throw Error.ArgumentNull("source2");
			}
			return source1.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.Intersect_TSource_3(typeof(TSource)), source1.Expression, Queryable.GetSourceExpression<TSource>(source2), Expression.Constant(comparer, typeof(IEqualityComparer<TSource>))));
		}

		/// <summary>
		///         Находит разность двух последовательностей, используя для сравнения значений компаратор проверки на равенство по умолчанию.
		///       </summary>
		/// <param name="source1">
		///           <see cref="T:System.Linq.IQueryable`1" /> Элементы которой, отсутствующие в <paramref name="source2" /> будут возвращены.
		///         </param>
		/// <param name="source2">
		///           <see cref="T:System.Collections.Generic.IEnumerable`1" /> Элементы которой, входящие также в первую последовательность не будет отображаться в возвращаемой последовательности.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов входных последовательностей.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Содержащий разность двух последовательностей.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source1" /> или <paramref name="source2" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600047C RID: 1148 RVA: 0x0000E098 File Offset: 0x0000C298
		public static IQueryable<TSource> Except<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2)
		{
			if (source1 == null)
			{
				throw Error.ArgumentNull("source1");
			}
			if (source2 == null)
			{
				throw Error.ArgumentNull("source2");
			}
			return source1.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.Except_TSource_2(typeof(TSource)), source1.Expression, Queryable.GetSourceExpression<TSource>(source2)));
		}

		/// <summary>
		///         Находит разность двух последовательностей с помощью заданного <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> для сравнения значений.
		///       </summary>
		/// <param name="source1">
		///           <see cref="T:System.Linq.IQueryable`1" /> Элементы которой, отсутствующие в <paramref name="source2" /> будут возвращены.
		///         </param>
		/// <param name="source2">
		///           <see cref="T:System.Collections.Generic.IEnumerable`1" /> Элементы которой, входящие также в первую последовательность не будет отображаться в возвращаемой последовательности.
		///         </param>
		/// <param name="comparer">
		///           <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> Для сравнения значений.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов входных последовательностей.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Содержащий разность двух последовательностей.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source1" /> или <paramref name="source2" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600047D RID: 1149 RVA: 0x0000E0F0 File Offset: 0x0000C2F0
		public static IQueryable<TSource> Except<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2, IEqualityComparer<TSource> comparer)
		{
			if (source1 == null)
			{
				throw Error.ArgumentNull("source1");
			}
			if (source2 == null)
			{
				throw Error.ArgumentNull("source2");
			}
			return source1.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.Except_TSource_3(typeof(TSource)), source1.Expression, Queryable.GetSourceExpression<TSource>(source2), Expression.Constant(comparer, typeof(IEqualityComparer<TSource>))));
		}

		/// <summary>
		///         Возвращает первый элемент последовательности.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Для возвращения первого элемента.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Первый элемент в <paramref name="source" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Исходная последовательность пуста.
		///           </exception>
		// Token: 0x0600047E RID: 1150 RVA: 0x0000E155 File Offset: 0x0000C355
		public static TSource First<TSource>(this IQueryable<TSource> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<TSource>(Expression.Call(null, CachedReflectionInfo.First_TSource_1(typeof(TSource)), source.Expression));
		}

		/// <summary>
		///         Возвращает первый элемент последовательности, удовлетворяющий указанному условию.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Требуется возвратить элемент.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки каждого элемента на соответствие условию.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Первый элемент в <paramref name="source" /> прошедший проверку в <paramref name="predicate" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="predicate" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Элемент не удовлетворяет условию предиката <paramref name="predicate" />.
		///
		///             -или-
		///
		///             Исходная последовательность пуста.
		///           </exception>
		// Token: 0x0600047F RID: 1151 RVA: 0x0000E18C File Offset: 0x0000C38C
		public static TSource First<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (predicate == null)
			{
				throw Error.ArgumentNull("predicate");
			}
			return source.Provider.Execute<TSource>(Expression.Call(null, CachedReflectionInfo.First_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(predicate)));
		}

		/// <summary>
		///         Возвращает первый элемент последовательности или значение по умолчанию, если последовательность не содержит элементов.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Для возвращения первого элемента.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         default(<paramref name="TSource" />) Если <paramref name="source" /> является пустой; в противном случае — первый элемент в <paramref name="source" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000480 RID: 1152 RVA: 0x0000E1E1 File Offset: 0x0000C3E1
		public static TSource FirstOrDefault<TSource>(this IQueryable<TSource> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<TSource>(Expression.Call(null, CachedReflectionInfo.FirstOrDefault_TSource_1(typeof(TSource)), source.Expression));
		}

		/// <summary>
		///         Возвращает первый элемент последовательности, удовлетворяющий заданному условию, или значение по умолчанию, если элемент не найден.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Требуется возвратить элемент.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки каждого элемента на соответствие условию.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         default(<paramref name="TSource" />) Если <paramref name="source" /> пуст или если отсутствует элемент не прошел проверку, определенную предикатом <paramref name="predicate" />; в противном случае — первый элемент в <paramref name="source" /> прошедший проверку, определенную предикатом <paramref name="predicate" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="predicate" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000481 RID: 1153 RVA: 0x0000E218 File Offset: 0x0000C418
		public static TSource FirstOrDefault<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (predicate == null)
			{
				throw Error.ArgumentNull("predicate");
			}
			return source.Provider.Execute<TSource>(Expression.Call(null, CachedReflectionInfo.FirstOrDefault_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(predicate)));
		}

		/// <summary>
		///         Возвращает последний элемент последовательности.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Требуется возвратить последний элемент.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Значение, находящееся в последней позиции в <paramref name="source" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Исходная последовательность пуста.
		///           </exception>
		// Token: 0x06000482 RID: 1154 RVA: 0x0000E26D File Offset: 0x0000C46D
		public static TSource Last<TSource>(this IQueryable<TSource> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<TSource>(Expression.Call(null, CachedReflectionInfo.Last_TSource_1(typeof(TSource)), source.Expression));
		}

		/// <summary>
		///         Возвращает последний элемент последовательности, удовлетворяющий указанному условию.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Требуется возвратить элемент.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки каждого элемента на соответствие условию.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Последний элемент в <paramref name="source" /> прошедший проверку, определенную предикатом <paramref name="predicate" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="predicate" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Элемент не удовлетворяет условию предиката <paramref name="predicate" />.
		///
		///             -или-
		///
		///             Исходная последовательность пуста.
		///           </exception>
		// Token: 0x06000483 RID: 1155 RVA: 0x0000E2A4 File Offset: 0x0000C4A4
		public static TSource Last<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (predicate == null)
			{
				throw Error.ArgumentNull("predicate");
			}
			return source.Provider.Execute<TSource>(Expression.Call(null, CachedReflectionInfo.Last_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(predicate)));
		}

		/// <summary>
		///         Возвращает последний элемент последовательности или значение по умолчанию, если последовательность не содержит элементов.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Требуется возвратить последний элемент.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         default(<paramref name="TSource" />) Если <paramref name="source" /> является пустой; в противном случае — последний элемент в <paramref name="source" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000484 RID: 1156 RVA: 0x0000E2F9 File Offset: 0x0000C4F9
		public static TSource LastOrDefault<TSource>(this IQueryable<TSource> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<TSource>(Expression.Call(null, CachedReflectionInfo.LastOrDefault_TSource_1(typeof(TSource)), source.Expression));
		}

		/// <summary>
		///         Возвращает последний элемент последовательности, удовлетворяющий указанному условию, или значение по умолчанию, если ни одного такого элемента не найдено.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Требуется возвратить элемент.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки каждого элемента на соответствие условию.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         default(<paramref name="TSource" />) Если <paramref name="source" /> пуста или если ни один элемент не прошел проверку функцией предиката; в противном случае — последний элемент <paramref name="source" /> прошедший проверку функцией предиката.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="predicate" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000485 RID: 1157 RVA: 0x0000E330 File Offset: 0x0000C530
		public static TSource LastOrDefault<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (predicate == null)
			{
				throw Error.ArgumentNull("predicate");
			}
			return source.Provider.Execute<TSource>(Expression.Call(null, CachedReflectionInfo.LastOrDefault_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(predicate)));
		}

		/// <summary>
		///         Возвращает единственный элемент последовательности и вызывает исключение, если число элементов последовательности отлично от одного.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Чтобы вернуть единственный элемент.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Единственный элемент входной последовательности.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> имеет более одного элемента.
		///           </exception>
		// Token: 0x06000486 RID: 1158 RVA: 0x0000E385 File Offset: 0x0000C585
		public static TSource Single<TSource>(this IQueryable<TSource> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<TSource>(Expression.Call(null, CachedReflectionInfo.Single_TSource_1(typeof(TSource)), source.Expression));
		}

		/// <summary>
		///         Возвращает единственный элемент последовательности, удовлетворяющий указанному условию, и вызывает исключение, если таких элементов больше одного.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Для возврата из одного элемента.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки элемента на соответствие условию.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Единственный элемент входной последовательности, удовлетворяющий условию предиката <paramref name="predicate" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="predicate" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Элемент не удовлетворяет условию предиката <paramref name="predicate" />.
		///
		///             -или-
		///
		///             Удовлетворяет более одного элемента в <paramref name="predicate" />.
		///
		///             -или-
		///
		///             Исходная последовательность пуста.
		///           </exception>
		// Token: 0x06000487 RID: 1159 RVA: 0x0000E3BC File Offset: 0x0000C5BC
		public static TSource Single<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (predicate == null)
			{
				throw Error.ArgumentNull("predicate");
			}
			return source.Provider.Execute<TSource>(Expression.Call(null, CachedReflectionInfo.Single_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(predicate)));
		}

		/// <summary>
		///         Возвращает единственный элемент последовательности или значение по умолчанию, если последовательность пуста; Этот метод создает исключение, если в последовательности более одного элемента.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Чтобы вернуть единственный элемент.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Единственный элемент входной последовательности или default(<paramref name="TSource" />), если последовательность не содержит элементов.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> имеет более одного элемента.
		///           </exception>
		// Token: 0x06000488 RID: 1160 RVA: 0x0000E411 File Offset: 0x0000C611
		public static TSource SingleOrDefault<TSource>(this IQueryable<TSource> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<TSource>(Expression.Call(null, CachedReflectionInfo.SingleOrDefault_TSource_1(typeof(TSource)), source.Expression));
		}

		/// <summary>
		///         Возвращает единственный элемент последовательности, удовлетворяющий указанному условию, или значение по умолчанию, если такого элемента не существует; если условию удовлетворяет более одного элемента, вызывается исключение.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Для возврата из одного элемента.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки элемента на соответствие условию.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Единственный элемент входной последовательности, удовлетворяющий условию предиката <paramref name="predicate" />, или default(<paramref name="TSource" />), если элемент не найден.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="predicate" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Удовлетворяет более одного элемента в <paramref name="predicate" />.
		///           </exception>
		// Token: 0x06000489 RID: 1161 RVA: 0x0000E448 File Offset: 0x0000C648
		public static TSource SingleOrDefault<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (predicate == null)
			{
				throw Error.ArgumentNull("predicate");
			}
			return source.Provider.Execute<TSource>(Expression.Call(null, CachedReflectionInfo.SingleOrDefault_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(predicate)));
		}

		/// <summary>
		///         Возвращает элемент по указанному индексу в последовательности.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Требуется возвратить элемент.
		///         </param>
		/// <param name="index">
		///           Отсчитываемый от нуля индекс извлекаемого элемента.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Элемент в указанной позиции в <paramref name="source" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Значение параметра <paramref name="index" /> меньше нуля.
		///           </exception>
		// Token: 0x0600048A RID: 1162 RVA: 0x0000E4A0 File Offset: 0x0000C6A0
		public static TSource ElementAt<TSource>(this IQueryable<TSource> source, int index)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (index < 0)
			{
				throw Error.ArgumentOutOfRange("index");
			}
			return source.Provider.Execute<TSource>(Expression.Call(null, CachedReflectionInfo.ElementAt_TSource_2(typeof(TSource)), source.Expression, Expression.Constant(index)));
		}

		/// <summary>
		///         Возвращает элемент последовательности по указанному индексу или значение по умолчанию, если индекс вне допустимого диапазона.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Требуется возвратить элемент.
		///         </param>
		/// <param name="index">
		///           Отсчитываемый от нуля индекс извлекаемого элемента.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         default(<paramref name="TSource" />) Если <paramref name="index" /> выходит за границы <paramref name="source" />; в противном случае — элемент в указанной позиции в <paramref name="source" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600048B RID: 1163 RVA: 0x0000E4FC File Offset: 0x0000C6FC
		public static TSource ElementAtOrDefault<TSource>(this IQueryable<TSource> source, int index)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<TSource>(Expression.Call(null, CachedReflectionInfo.ElementAtOrDefault_TSource_2(typeof(TSource)), source.Expression, Expression.Constant(index)));
		}

		/// <summary>
		///         Возвращает элементы указанной последовательности или значение по умолчанию параметра типа одноэлементную коллекцию, если последовательность пуста.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Для возврата значение по умолчанию, если не указано.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Содержащий <see langword="default" />(<paramref name="TSource" />) Если <paramref name="source" /> является пустой; в противном случае — <paramref name="source" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600048C RID: 1164 RVA: 0x0000E548 File Offset: 0x0000C748
		public static IQueryable<TSource> DefaultIfEmpty<TSource>(this IQueryable<TSource> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.DefaultIfEmpty_TSource_1(typeof(TSource)), source.Expression));
		}

		/// <summary>
		///         Возвращает элементы указанной последовательности или значение заданного одноэлементную коллекцию, если последовательность пуста.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Для возврата указанное значение, если не указано.
		///         </param>
		/// <param name="defaultValue">
		///           Значение, возвращаемое в случае пустой последовательности.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Содержащий <paramref name="defaultValue" /> Если <paramref name="source" /> является пустой; в противном случае — <paramref name="source" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600048D RID: 1165 RVA: 0x0000E580 File Offset: 0x0000C780
		public static IQueryable<TSource> DefaultIfEmpty<TSource>(this IQueryable<TSource> source, TSource defaultValue)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.DefaultIfEmpty_TSource_2(typeof(TSource)), source.Expression, Expression.Constant(defaultValue, typeof(TSource))));
		}

		/// <summary>
		///         Определяет, содержит ли последовательность указанный элемент, используя компаратор проверки на равенство по умолчанию.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> В которой требуется найти <paramref name="item" />.
		///         </param>
		/// <param name="item">
		///           Объект, который требуется найти в последовательности.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         <see langword="true" /> Если входная последовательность содержит элемент с указанным значением; в противном случае — <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600048E RID: 1166 RVA: 0x0000E5D8 File Offset: 0x0000C7D8
		public static bool Contains<TSource>(this IQueryable<TSource> source, TSource item)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<bool>(Expression.Call(null, CachedReflectionInfo.Contains_TSource_2(typeof(TSource)), source.Expression, Expression.Constant(item, typeof(TSource))));
		}

		/// <summary>
		///         Определяет, содержит ли последовательность указанный элемент, используя указанный <see cref="T:System.Collections.Generic.IEqualityComparer`1" />.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> В которой требуется найти <paramref name="item" />.
		///         </param>
		/// <param name="item">
		///           Объект, который требуется найти в последовательности.
		///         </param>
		/// <param name="comparer">
		///           <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> Для сравнения значений.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         <see langword="true" /> Если входная последовательность содержит элемент с указанным значением; в противном случае — <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600048F RID: 1167 RVA: 0x0000E630 File Offset: 0x0000C830
		public static bool Contains<TSource>(this IQueryable<TSource> source, TSource item, IEqualityComparer<TSource> comparer)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<bool>(Expression.Call(null, CachedReflectionInfo.Contains_TSource_3(typeof(TSource)), source.Expression, Expression.Constant(item, typeof(TSource)), Expression.Constant(comparer, typeof(IEqualityComparer<TSource>))));
		}

		/// <summary>
		///         Изменяет порядок элементов в последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, которые следует расставить в обратном порядке.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         <see cref="T:System.Linq.IQueryable`1" /> Элементы которой соответствуют элементам входной последовательности в обратном порядке.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000490 RID: 1168 RVA: 0x0000E696 File Offset: 0x0000C896
		public static IQueryable<TSource> Reverse<TSource>(this IQueryable<TSource> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.Reverse_TSource_1(typeof(TSource)), source.Expression));
		}

		/// <summary>
		///         Определяет, совпадают ли две последовательности, используя для сравнения элементов компаратор проверки на равенство по умолчанию.
		///       </summary>
		/// <param name="source1">
		///           <see cref="T:System.Linq.IQueryable`1" /> Элементы которой требуется сравнить данные для <paramref name="source2" />.
		///         </param>
		/// <param name="source2">
		///           <see cref="T:System.Collections.Generic.IEnumerable`1" /> Элементы которой требуется сравнить их первой последовательности.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов входных последовательностей.
		///         </typeparam>
		/// <returns>
		///         <see langword="true" /> Если у двух исходных последовательностей одинаковая длина и соответствующие элементы совпадают; в противном случае — <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source1" /> или <paramref name="source2" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000491 RID: 1169 RVA: 0x0000E6CC File Offset: 0x0000C8CC
		public static bool SequenceEqual<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2)
		{
			if (source1 == null)
			{
				throw Error.ArgumentNull("source1");
			}
			if (source2 == null)
			{
				throw Error.ArgumentNull("source2");
			}
			return source1.Provider.Execute<bool>(Expression.Call(null, CachedReflectionInfo.SequenceEqual_TSource_2(typeof(TSource)), source1.Expression, Queryable.GetSourceExpression<TSource>(source2)));
		}

		/// <summary>
		///         Определяет, равны ли две последовательности, используя указанную <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> для сравнения элементов.
		///       </summary>
		/// <param name="source1">
		///           <see cref="T:System.Linq.IQueryable`1" /> Элементы которой требуется сравнить данные для <paramref name="source2" />.
		///         </param>
		/// <param name="source2">
		///           <see cref="T:System.Collections.Generic.IEnumerable`1" /> Элементы которой требуется сравнить их первой последовательности.
		///         </param>
		/// <param name="comparer">
		///           <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> Можно использовать для сравнения элементов.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов входных последовательностей.
		///         </typeparam>
		/// <returns>
		///         <see langword="true" /> Если у двух исходных последовательностей одинаковая длина и соответствующие элементы совпадают; в противном случае — <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source1" /> или <paramref name="source2" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000492 RID: 1170 RVA: 0x0000E724 File Offset: 0x0000C924
		public static bool SequenceEqual<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2, IEqualityComparer<TSource> comparer)
		{
			if (source1 == null)
			{
				throw Error.ArgumentNull("source1");
			}
			if (source2 == null)
			{
				throw Error.ArgumentNull("source2");
			}
			return source1.Provider.Execute<bool>(Expression.Call(null, CachedReflectionInfo.SequenceEqual_TSource_3(typeof(TSource)), source1.Expression, Queryable.GetSourceExpression<TSource>(source2), Expression.Constant(comparer, typeof(IEqualityComparer<TSource>))));
		}

		/// <summary>
		///         Определяет, содержит ли последовательность какие-либо элементы.
		///       </summary>
		/// <param name="source">
		///           Для проверки, пустая последовательность.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         <see langword="true" /> Если исходная последовательность содержит элементы; в противном случае — <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000493 RID: 1171 RVA: 0x0000E789 File Offset: 0x0000C989
		public static bool Any<TSource>(this IQueryable<TSource> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<bool>(Expression.Call(null, CachedReflectionInfo.Any_TSource_1(typeof(TSource)), source.Expression));
		}

		/// <summary>
		///         Определяет, удовлетворяет ли какой-либо элемент последовательности условие.
		///       </summary>
		/// <param name="source">
		///           Последовательность, элементы которой проверяемое условие.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки каждого элемента на соответствие условию.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         <see langword="true" /> Если все элементы в исходной последовательности проходит проверку, определяемую указанным предикатом; в противном случае — <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="predicate" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000494 RID: 1172 RVA: 0x0000E7C0 File Offset: 0x0000C9C0
		public static bool Any<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (predicate == null)
			{
				throw Error.ArgumentNull("predicate");
			}
			return source.Provider.Execute<bool>(Expression.Call(null, CachedReflectionInfo.Any_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(predicate)));
		}

		/// <summary>
		///         Определяет, является ли элементы последовательности удовлетворяют условию.
		///       </summary>
		/// <param name="source">
		///           Последовательность, элементы которой проверяемое условие.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки каждого элемента на соответствие условию.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         <see langword="true" /> Если каждый элемент исходной последовательности проходит проверку, определяемую указанным предикатом, или если последовательность пуста; в противном случае — <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="predicate" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000495 RID: 1173 RVA: 0x0000E818 File Offset: 0x0000CA18
		public static bool All<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (predicate == null)
			{
				throw Error.ArgumentNull("predicate");
			}
			return source.Provider.Execute<bool>(Expression.Call(null, CachedReflectionInfo.All_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(predicate)));
		}

		/// <summary>
		///         Возвращает количество элементов в последовательности.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Содержащий элементы которой требуется подсчитать.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Число элементов во входной последовательности.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Число элементов в <paramref name="source" /> больше, чем <see cref="F:System.Int32.MaxValue" />.
		///           </exception>
		// Token: 0x06000496 RID: 1174 RVA: 0x0000E86D File Offset: 0x0000CA6D
		public static int Count<TSource>(this IQueryable<TSource> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<int>(Expression.Call(null, CachedReflectionInfo.Count_TSource_1(typeof(TSource)), source.Expression));
		}

		/// <summary>
		///         Возвращает количество элементов в указанной последовательности, удовлетворяющий условию.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Содержащий элементы которой требуется подсчитать.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки каждого элемента на соответствие условию.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Число элементов в последовательности, удовлетворяющий условию функции предиката.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="predicate" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Число элементов в <paramref name="source" /> больше, чем <see cref="F:System.Int32.MaxValue" />.
		///           </exception>
		// Token: 0x06000497 RID: 1175 RVA: 0x0000E8A4 File Offset: 0x0000CAA4
		public static int Count<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (predicate == null)
			{
				throw Error.ArgumentNull("predicate");
			}
			return source.Provider.Execute<int>(Expression.Call(null, CachedReflectionInfo.Count_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(predicate)));
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Int64" /> представляющее общее число элементов в последовательности.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Содержащий элементы которой требуется подсчитать.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Число элементов в <paramref name="source" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Число элементов превышает <see cref="F:System.Int64.MaxValue" />.
		///           </exception>
		// Token: 0x06000498 RID: 1176 RVA: 0x0000E8F9 File Offset: 0x0000CAF9
		public static long LongCount<TSource>(this IQueryable<TSource> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<long>(Expression.Call(null, CachedReflectionInfo.LongCount_TSource_1(typeof(TSource)), source.Expression));
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Int64" /> представляющий количество элементов последовательности, удовлетворяющих заданному условию.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.IQueryable`1" /> Содержащий элементы которой требуется подсчитать.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки каждого элемента на соответствие условию.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Число элементов в <paramref name="source" /> удовлетворяющих условию функции предиката.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="predicate" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Количество соответствующих элементов превышает <see cref="F:System.Int64.MaxValue" />.
		///           </exception>
		// Token: 0x06000499 RID: 1177 RVA: 0x0000E930 File Offset: 0x0000CB30
		public static long LongCount<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (predicate == null)
			{
				throw Error.ArgumentNull("predicate");
			}
			return source.Provider.Execute<long>(Expression.Call(null, CachedReflectionInfo.LongCount_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(predicate)));
		}

		/// <summary>
		///         Возвращает минимальное значение универсального <see cref="T:System.Linq.IQueryable`1" />.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, чтобы определить минимальное.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Минимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600049A RID: 1178 RVA: 0x0000E985 File Offset: 0x0000CB85
		public static TSource Min<TSource>(this IQueryable<TSource> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<TSource>(Expression.Call(null, CachedReflectionInfo.Min_TSource_1(typeof(TSource)), source.Expression));
		}

		/// <summary>
		///         Вызывает функцию проекции для каждого элемента универсального <see cref="T:System.Linq.IQueryable`1" /> и возвращает минимальное результирующее значение.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, чтобы определить минимальное.
		///         </param>
		/// <param name="selector">
		///           Функция проекции, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип значения, возвращаемого функцией, представленный <paramref name="selector" />.
		///         </typeparam>
		/// <returns>
		///         Минимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600049B RID: 1179 RVA: 0x0000E9BC File Offset: 0x0000CBBC
		public static TResult Min<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return source.Provider.Execute<TResult>(Expression.Call(null, CachedReflectionInfo.Min_TSource_TResult_2(typeof(TSource), typeof(TResult)), source.Expression, Expression.Quote(selector)));
		}

		/// <summary>
		///         Возвращает максимальное значение в универсальной коллекции <see cref="T:System.Linq.IQueryable`1" />.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, чтобы определить максимальное значение.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Максимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600049C RID: 1180 RVA: 0x0000EA1B File Offset: 0x0000CC1B
		public static TSource Max<TSource>(this IQueryable<TSource> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<TSource>(Expression.Call(null, CachedReflectionInfo.Max_TSource_1(typeof(TSource)), source.Expression));
		}

		/// <summary>
		///         Вызывает функцию проекции для каждого элемента универсального <see cref="T:System.Linq.IQueryable`1" /> и возвращает максимальное результирующее значение.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, чтобы определить максимальное значение.
		///         </param>
		/// <param name="selector">
		///           Функция проекции, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип значения, возвращаемого функцией, представленный <paramref name="selector" />.
		///         </typeparam>
		/// <returns>
		///         Максимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600049D RID: 1181 RVA: 0x0000EA54 File Offset: 0x0000CC54
		public static TResult Max<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return source.Provider.Execute<TResult>(Expression.Call(null, CachedReflectionInfo.Max_TSource_TResult_2(typeof(TSource), typeof(TResult)), source.Expression, Expression.Quote(selector)));
		}

		/// <summary>
		///         Вычисляет сумму последовательности <see cref="T:System.Int32" /> значения.
		///       </summary>
		/// <param name="source">
		///           Последовательность <see cref="T:System.Int32" /> значения для вычисления суммы.
		///         </param>
		/// <returns>
		///         Сумма значений в последовательности.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Сумма больше, чем <see cref="F:System.Int32.MaxValue" />.
		///           </exception>
		// Token: 0x0600049E RID: 1182 RVA: 0x0000EAB3 File Offset: 0x0000CCB3
		public static int Sum(this IQueryable<int> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<int>(Expression.Call(null, CachedReflectionInfo.Sum_Int32_1, source.Expression));
		}

		/// <summary>
		///         Вычисляет сумму последовательности nullable <see cref="T:System.Int32" /> значения.
		///       </summary>
		/// <param name="source">
		///           Последовательность nullable <see cref="T:System.Int32" /> значения для вычисления суммы.
		///         </param>
		/// <returns>
		///         Сумма значений в последовательности.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Сумма больше, чем <see cref="F:System.Int32.MaxValue" />.
		///           </exception>
		// Token: 0x0600049F RID: 1183 RVA: 0x0000EADF File Offset: 0x0000CCDF
		public static int? Sum(this IQueryable<int?> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<int?>(Expression.Call(null, CachedReflectionInfo.Sum_NullableInt32_1, source.Expression));
		}

		/// <summary>
		///         Вычисляет сумму последовательности <see cref="T:System.Int64" /> значения.
		///       </summary>
		/// <param name="source">
		///           Последовательность <see cref="T:System.Int64" /> значения для вычисления суммы.
		///         </param>
		/// <returns>
		///         Сумма значений в последовательности.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Сумма больше, чем <see cref="F:System.Int64.MaxValue" />.
		///           </exception>
		// Token: 0x060004A0 RID: 1184 RVA: 0x0000EB0B File Offset: 0x0000CD0B
		public static long Sum(this IQueryable<long> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<long>(Expression.Call(null, CachedReflectionInfo.Sum_Int64_1, source.Expression));
		}

		/// <summary>
		///         Вычисляет сумму последовательности nullable <see cref="T:System.Int64" /> значения.
		///       </summary>
		/// <param name="source">
		///           Последовательность nullable <see cref="T:System.Int64" /> значения для вычисления суммы.
		///         </param>
		/// <returns>
		///         Сумма значений в последовательности.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Сумма больше, чем <see cref="F:System.Int64.MaxValue" />.
		///           </exception>
		// Token: 0x060004A1 RID: 1185 RVA: 0x0000EB37 File Offset: 0x0000CD37
		public static long? Sum(this IQueryable<long?> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<long?>(Expression.Call(null, CachedReflectionInfo.Sum_NullableInt64_1, source.Expression));
		}

		/// <summary>
		///         Вычисляет сумму последовательности <see cref="T:System.Single" /> значения.
		///       </summary>
		/// <param name="source">
		///           Последовательность <see cref="T:System.Single" /> значения для вычисления суммы.
		///         </param>
		/// <returns>
		///         Сумма значений в последовательности.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060004A2 RID: 1186 RVA: 0x0000EB63 File Offset: 0x0000CD63
		public static float Sum(this IQueryable<float> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<float>(Expression.Call(null, CachedReflectionInfo.Sum_Single_1, source.Expression));
		}

		/// <summary>
		///         Вычисляет сумму последовательности nullable <see cref="T:System.Single" /> значения.
		///       </summary>
		/// <param name="source">
		///           Последовательность nullable <see cref="T:System.Single" /> значения для вычисления суммы.
		///         </param>
		/// <returns>
		///         Сумма значений в последовательности.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060004A3 RID: 1187 RVA: 0x0000EB8F File Offset: 0x0000CD8F
		public static float? Sum(this IQueryable<float?> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<float?>(Expression.Call(null, CachedReflectionInfo.Sum_NullableSingle_1, source.Expression));
		}

		/// <summary>
		///         Вычисляет сумму последовательности <see cref="T:System.Double" /> значения.
		///       </summary>
		/// <param name="source">
		///           Последовательность <see cref="T:System.Double" /> значения для вычисления суммы.
		///         </param>
		/// <returns>
		///         Сумма значений в последовательности.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060004A4 RID: 1188 RVA: 0x0000EBBB File Offset: 0x0000CDBB
		public static double Sum(this IQueryable<double> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<double>(Expression.Call(null, CachedReflectionInfo.Sum_Double_1, source.Expression));
		}

		/// <summary>
		///         Вычисляет сумму последовательности nullable <see cref="T:System.Double" /> значения.
		///       </summary>
		/// <param name="source">
		///           Последовательность nullable <see cref="T:System.Double" /> значения для вычисления суммы.
		///         </param>
		/// <returns>
		///         Сумма значений в последовательности.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060004A5 RID: 1189 RVA: 0x0000EBE7 File Offset: 0x0000CDE7
		public static double? Sum(this IQueryable<double?> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<double?>(Expression.Call(null, CachedReflectionInfo.Sum_NullableDouble_1, source.Expression));
		}

		/// <summary>
		///         Вычисляет сумму последовательности <see cref="T:System.Decimal" /> значения.
		///       </summary>
		/// <param name="source">
		///           Последовательность <see cref="T:System.Decimal" /> значения для вычисления суммы.
		///         </param>
		/// <returns>
		///         Сумма значений в последовательности.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Сумма больше, чем <see cref="F:System.Decimal.MaxValue" />.
		///           </exception>
		// Token: 0x060004A6 RID: 1190 RVA: 0x0000EC13 File Offset: 0x0000CE13
		public static decimal Sum(this IQueryable<decimal> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<decimal>(Expression.Call(null, CachedReflectionInfo.Sum_Decimal_1, source.Expression));
		}

		/// <summary>
		///         Вычисляет сумму последовательности nullable <see cref="T:System.Decimal" /> значения.
		///       </summary>
		/// <param name="source">
		///           Последовательность nullable <see cref="T:System.Decimal" /> значения для вычисления суммы.
		///         </param>
		/// <returns>
		///         Сумма значений в последовательности.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Сумма больше, чем <see cref="F:System.Decimal.MaxValue" />.
		///           </exception>
		// Token: 0x060004A7 RID: 1191 RVA: 0x0000EC3F File Offset: 0x0000CE3F
		public static decimal? Sum(this IQueryable<decimal?> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<decimal?>(Expression.Call(null, CachedReflectionInfo.Sum_NullableDecimal_1, source.Expression));
		}

		/// <summary>
		///         Вычисляет сумму последовательности <see cref="T:System.Int32" /> значений, получаемой в результате применения функции проекции к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений типа <paramref name="TSource" />.
		///         </param>
		/// <param name="selector">
		///           Функция проекции, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Сумма проецированных значений.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Сумма больше, чем <see cref="F:System.Int32.MaxValue" />.
		///           </exception>
		// Token: 0x060004A8 RID: 1192 RVA: 0x0000EC6C File Offset: 0x0000CE6C
		public static int Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return source.Provider.Execute<int>(Expression.Call(null, CachedReflectionInfo.Sum_Int32_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(selector)));
		}

		/// <summary>
		///         Вычисляет сумму последовательности nullable <see cref="T:System.Int32" /> значений, получаемой в результате применения функции проекции к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений типа <paramref name="TSource" />.
		///         </param>
		/// <param name="selector">
		///           Функция проекции, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Сумма проецированных значений.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Сумма больше, чем <see cref="F:System.Int32.MaxValue" />.
		///           </exception>
		// Token: 0x060004A9 RID: 1193 RVA: 0x0000ECC4 File Offset: 0x0000CEC4
		public static int? Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int?>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return source.Provider.Execute<int?>(Expression.Call(null, CachedReflectionInfo.Sum_NullableInt32_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(selector)));
		}

		/// <summary>
		///         Вычисляет сумму последовательности <see cref="T:System.Int64" /> значений, получаемой в результате применения функции проекции к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений типа <paramref name="TSource" />.
		///         </param>
		/// <param name="selector">
		///           Функция проекции, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Сумма проецированных значений.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Сумма больше, чем <see cref="F:System.Int64.MaxValue" />.
		///           </exception>
		// Token: 0x060004AA RID: 1194 RVA: 0x0000ED1C File Offset: 0x0000CF1C
		public static long Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return source.Provider.Execute<long>(Expression.Call(null, CachedReflectionInfo.Sum_Int64_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(selector)));
		}

		/// <summary>
		///         Вычисляет сумму последовательности nullable <see cref="T:System.Int64" /> значений, получаемой в результате применения функции проекции к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений типа <paramref name="TSource" />.
		///         </param>
		/// <param name="selector">
		///           Функция проекции, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Сумма проецированных значений.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Сумма больше, чем <see cref="F:System.Int64.MaxValue" />.
		///           </exception>
		// Token: 0x060004AB RID: 1195 RVA: 0x0000ED74 File Offset: 0x0000CF74
		public static long? Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long?>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return source.Provider.Execute<long?>(Expression.Call(null, CachedReflectionInfo.Sum_NullableInt64_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(selector)));
		}

		/// <summary>
		///         Вычисляет сумму последовательности <see cref="T:System.Single" /> значений, получаемой в результате применения функции проекции к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений типа <paramref name="TSource" />.
		///         </param>
		/// <param name="selector">
		///           Функция проекции, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Сумма проецированных значений.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060004AC RID: 1196 RVA: 0x0000EDCC File Offset: 0x0000CFCC
		public static float Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return source.Provider.Execute<float>(Expression.Call(null, CachedReflectionInfo.Sum_Single_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(selector)));
		}

		/// <summary>
		///         Вычисляет сумму последовательности nullable <see cref="T:System.Single" /> значений, получаемой в результате применения функции проекции к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений типа <paramref name="TSource" />.
		///         </param>
		/// <param name="selector">
		///           Функция проекции, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Сумма проецированных значений.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060004AD RID: 1197 RVA: 0x0000EE24 File Offset: 0x0000D024
		public static float? Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float?>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return source.Provider.Execute<float?>(Expression.Call(null, CachedReflectionInfo.Sum_NullableSingle_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(selector)));
		}

		/// <summary>
		///         Вычисляет сумму последовательности <see cref="T:System.Double" /> значений, получаемой в результате применения функции проекции к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений типа <paramref name="TSource" />.
		///         </param>
		/// <param name="selector">
		///           Функция проекции, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Сумма проецированных значений.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060004AE RID: 1198 RVA: 0x0000EE7C File Offset: 0x0000D07C
		public static double Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return source.Provider.Execute<double>(Expression.Call(null, CachedReflectionInfo.Sum_Double_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(selector)));
		}

		/// <summary>
		///         Вычисляет сумму последовательности nullable <see cref="T:System.Double" /> значений, получаемой в результате применения функции проекции к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений типа <paramref name="TSource" />.
		///         </param>
		/// <param name="selector">
		///           Функция проекции, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Сумма проецированных значений.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060004AF RID: 1199 RVA: 0x0000EED4 File Offset: 0x0000D0D4
		public static double? Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double?>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return source.Provider.Execute<double?>(Expression.Call(null, CachedReflectionInfo.Sum_NullableDouble_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(selector)));
		}

		/// <summary>
		///         Вычисляет сумму последовательности <see cref="T:System.Decimal" /> значений, получаемой в результате применения функции проекции к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений типа <paramref name="TSource" />.
		///         </param>
		/// <param name="selector">
		///           Функция проекции, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Сумма проецированных значений.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Сумма больше, чем <see cref="F:System.Decimal.MaxValue" />.
		///           </exception>
		// Token: 0x060004B0 RID: 1200 RVA: 0x0000EF2C File Offset: 0x0000D12C
		public static decimal Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return source.Provider.Execute<decimal>(Expression.Call(null, CachedReflectionInfo.Sum_Decimal_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(selector)));
		}

		/// <summary>
		///         Вычисляет сумму последовательности nullable <see cref="T:System.Decimal" /> значений, получаемой в результате применения функции проекции к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений типа <paramref name="TSource" />.
		///         </param>
		/// <param name="selector">
		///           Функция проекции, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Сумма проецированных значений.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Сумма больше, чем <see cref="F:System.Decimal.MaxValue" />.
		///           </exception>
		// Token: 0x060004B1 RID: 1201 RVA: 0x0000EF84 File Offset: 0x0000D184
		public static decimal? Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal?>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return source.Provider.Execute<decimal?>(Expression.Call(null, CachedReflectionInfo.Sum_NullableDecimal_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(selector)));
		}

		/// <summary>
		///         Вычисляет среднее для последовательности <see cref="T:System.Int32" /> значения.
		///       </summary>
		/// <param name="source">
		///           Последовательность <see cref="T:System.Int32" /> значения для вычисления среднего.
		///         </param>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x060004B2 RID: 1202 RVA: 0x0000EFD9 File Offset: 0x0000D1D9
		public static double Average(this IQueryable<int> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<double>(Expression.Call(null, CachedReflectionInfo.Average_Int32_1, source.Expression));
		}

		/// <summary>
		///         Вычисляет среднее для последовательности <see cref="T:System.Int32" />, допускающей значение null.
		///       </summary>
		/// <param name="source">
		///           Последовательность <see cref="T:System.Int32" />, допускающая значение null, для вычисления среднего.
		///         </param>
		/// <returns>
		///         Среднее для последовательности значений или <see langword="null" />, если исходная последовательность пуста или содержит только значения <see langword="null" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060004B3 RID: 1203 RVA: 0x0000F005 File Offset: 0x0000D205
		public static double? Average(this IQueryable<int?> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<double?>(Expression.Call(null, CachedReflectionInfo.Average_NullableInt32_1, source.Expression));
		}

		/// <summary>
		///         Вычисляет среднее для последовательности <see cref="T:System.Int64" /> значения.
		///       </summary>
		/// <param name="source">
		///           Последовательность <see cref="T:System.Int64" /> значения для вычисления среднего.
		///         </param>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x060004B4 RID: 1204 RVA: 0x0000F031 File Offset: 0x0000D231
		public static double Average(this IQueryable<long> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<double>(Expression.Call(null, CachedReflectionInfo.Average_Int64_1, source.Expression));
		}

		/// <summary>
		///         Вычисляет среднее для последовательности nullable <see cref="T:System.Int64" /> значения.
		///       </summary>
		/// <param name="source">
		///           Последовательность nullable <see cref="T:System.Int64" /> значения для вычисления среднего.
		///         </param>
		/// <returns>
		///         Среднее для последовательности значений, или <see langword="null" /> Если исходная последовательность пуста или содержит только <see langword="null" /> значения.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060004B5 RID: 1205 RVA: 0x0000F05D File Offset: 0x0000D25D
		public static double? Average(this IQueryable<long?> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<double?>(Expression.Call(null, CachedReflectionInfo.Average_NullableInt64_1, source.Expression));
		}

		/// <summary>
		///         Вычисляет среднее для последовательности <see cref="T:System.Single" /> значения.
		///       </summary>
		/// <param name="source">
		///           Последовательность <see cref="T:System.Single" /> значения для вычисления среднего.
		///         </param>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x060004B6 RID: 1206 RVA: 0x0000F089 File Offset: 0x0000D289
		public static float Average(this IQueryable<float> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<float>(Expression.Call(null, CachedReflectionInfo.Average_Single_1, source.Expression));
		}

		/// <summary>
		///         Вычисляет среднее для последовательности nullable <see cref="T:System.Single" /> значения.
		///       </summary>
		/// <param name="source">
		///           Последовательность nullable <see cref="T:System.Single" /> значения для вычисления среднего.
		///         </param>
		/// <returns>
		///         Среднее для последовательности значений, или <see langword="null" /> Если исходная последовательность пуста или содержит только <see langword="null" /> значения.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060004B7 RID: 1207 RVA: 0x0000F0B5 File Offset: 0x0000D2B5
		public static float? Average(this IQueryable<float?> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<float?>(Expression.Call(null, CachedReflectionInfo.Average_NullableSingle_1, source.Expression));
		}

		/// <summary>
		///         Вычисляет среднее для последовательности <see cref="T:System.Double" /> значения.
		///       </summary>
		/// <param name="source">
		///           Последовательность <see cref="T:System.Double" /> значения для вычисления среднего.
		///         </param>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x060004B8 RID: 1208 RVA: 0x0000F0E1 File Offset: 0x0000D2E1
		public static double Average(this IQueryable<double> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<double>(Expression.Call(null, CachedReflectionInfo.Average_Double_1, source.Expression));
		}

		/// <summary>
		///         Вычисляет среднее для последовательности nullable <see cref="T:System.Double" /> значения.
		///       </summary>
		/// <param name="source">
		///           Последовательность nullable <see cref="T:System.Double" /> значения для вычисления среднего.
		///         </param>
		/// <returns>
		///         Среднее для последовательности значений, или <see langword="null" /> Если исходная последовательность пуста или содержит только <see langword="null" /> значения.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060004B9 RID: 1209 RVA: 0x0000F10D File Offset: 0x0000D30D
		public static double? Average(this IQueryable<double?> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<double?>(Expression.Call(null, CachedReflectionInfo.Average_NullableDouble_1, source.Expression));
		}

		/// <summary>
		///         Вычисляет среднее для последовательности <see cref="T:System.Decimal" /> значения.
		///       </summary>
		/// <param name="source">
		///           Последовательность <see cref="T:System.Decimal" /> значения для вычисления среднего.
		///         </param>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x060004BA RID: 1210 RVA: 0x0000F139 File Offset: 0x0000D339
		public static decimal Average(this IQueryable<decimal> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<decimal>(Expression.Call(null, CachedReflectionInfo.Average_Decimal_1, source.Expression));
		}

		/// <summary>
		///         Вычисляет среднее для последовательности nullable <see cref="T:System.Decimal" /> значения.
		///       </summary>
		/// <param name="source">
		///           Последовательность nullable <see cref="T:System.Decimal" /> значения для вычисления среднего.
		///         </param>
		/// <returns>
		///         Среднее для последовательности значений, или <see langword="null" /> Если исходная последовательность пуста или содержит только <see langword="null" /> значения.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="source" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060004BB RID: 1211 RVA: 0x0000F165 File Offset: 0x0000D365
		public static decimal? Average(this IQueryable<decimal?> source)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.Execute<decimal?>(Expression.Call(null, CachedReflectionInfo.Average_NullableDecimal_1, source.Expression));
		}

		/// <summary>
		///         Вычисляет среднее для последовательности <see cref="T:System.Int32" /> значений, получаемой в результате применения функции проекции к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для вычисления среднего.
		///         </param>
		/// <param name="selector">
		///           Функция проекции, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x060004BC RID: 1212 RVA: 0x0000F194 File Offset: 0x0000D394
		public static double Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return source.Provider.Execute<double>(Expression.Call(null, CachedReflectionInfo.Average_Int32_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(selector)));
		}

		/// <summary>
		///         Вычисляет среднее для последовательности nullable <see cref="T:System.Int32" /> значений, получаемой в результате применения функции проекции к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для вычисления среднего.
		///         </param>
		/// <param name="selector">
		///           Функция проекции, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Среднее для последовательности значений, или <see langword="null" /> при <paramref name="source" /> последовательность пуста или содержит только <see langword="null" /> значения.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060004BD RID: 1213 RVA: 0x0000F1EC File Offset: 0x0000D3EC
		public static double? Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int?>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return source.Provider.Execute<double?>(Expression.Call(null, CachedReflectionInfo.Average_NullableInt32_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(selector)));
		}

		/// <summary>
		///         Вычисляет среднее для последовательности <see cref="T:System.Single" /> значений, получаемой в результате применения функции проекции к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для вычисления среднего.
		///         </param>
		/// <param name="selector">
		///           Функция проекции, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x060004BE RID: 1214 RVA: 0x0000F244 File Offset: 0x0000D444
		public static float Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return source.Provider.Execute<float>(Expression.Call(null, CachedReflectionInfo.Average_Single_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(selector)));
		}

		/// <summary>
		///         Вычисляет среднее для последовательности nullable <see cref="T:System.Single" /> значений, получаемой в результате применения функции проекции к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для вычисления среднего.
		///         </param>
		/// <param name="selector">
		///           Функция проекции, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Среднее для последовательности значений, или <see langword="null" /> при <paramref name="source" /> последовательность пуста или содержит только <see langword="null" /> значения.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060004BF RID: 1215 RVA: 0x0000F29C File Offset: 0x0000D49C
		public static float? Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float?>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return source.Provider.Execute<float?>(Expression.Call(null, CachedReflectionInfo.Average_NullableSingle_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(selector)));
		}

		/// <summary>
		///         Вычисляет среднее для последовательности <see cref="T:System.Int64" /> значений, получаемой в результате применения функции проекции к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для вычисления среднего.
		///         </param>
		/// <param name="selector">
		///           Функция проекции, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x060004C0 RID: 1216 RVA: 0x0000F2F4 File Offset: 0x0000D4F4
		public static double Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return source.Provider.Execute<double>(Expression.Call(null, CachedReflectionInfo.Average_Int64_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(selector)));
		}

		/// <summary>
		///         Вычисляет среднее для последовательности nullable <see cref="T:System.Int64" /> значений, получаемой в результате применения функции проекции к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для вычисления среднего.
		///         </param>
		/// <param name="selector">
		///           Функция проекции, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Среднее для последовательности значений, или <see langword="null" /> при <paramref name="source" /> последовательность пуста или содержит только <see langword="null" /> значения.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060004C1 RID: 1217 RVA: 0x0000F34C File Offset: 0x0000D54C
		public static double? Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long?>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return source.Provider.Execute<double?>(Expression.Call(null, CachedReflectionInfo.Average_NullableInt64_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(selector)));
		}

		/// <summary>
		///         Вычисляет среднее для последовательности <see cref="T:System.Double" /> значений, получаемой в результате применения функции проекции к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для вычисления среднего.
		///         </param>
		/// <param name="selector">
		///           Функция проекции, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x060004C2 RID: 1218 RVA: 0x0000F3A4 File Offset: 0x0000D5A4
		public static double Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return source.Provider.Execute<double>(Expression.Call(null, CachedReflectionInfo.Average_Double_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(selector)));
		}

		/// <summary>
		///         Вычисляет среднее для последовательности nullable <see cref="T:System.Double" /> значений, получаемой в результате применения функции проекции к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для вычисления среднего.
		///         </param>
		/// <param name="selector">
		///           Функция проекции, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Среднее для последовательности значений, или <see langword="null" /> при <paramref name="source" /> последовательность пуста или содержит только <see langword="null" /> значения.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060004C3 RID: 1219 RVA: 0x0000F3FC File Offset: 0x0000D5FC
		public static double? Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double?>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return source.Provider.Execute<double?>(Expression.Call(null, CachedReflectionInfo.Average_NullableDouble_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(selector)));
		}

		/// <summary>
		///         Вычисляет среднее для последовательности <see cref="T:System.Decimal" /> значений, получаемой в результате применения функции проекции к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, используемых для вычисления среднего.
		///         </param>
		/// <param name="selector">
		///           Функция проекции, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x060004C4 RID: 1220 RVA: 0x0000F454 File Offset: 0x0000D654
		public static decimal Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return source.Provider.Execute<decimal>(Expression.Call(null, CachedReflectionInfo.Average_Decimal_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(selector)));
		}

		/// <summary>
		///         Вычисляет среднее для последовательности nullable <see cref="T:System.Decimal" /> значений, получаемой в результате применения функции проекции к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для вычисления среднего.
		///         </param>
		/// <param name="selector">
		///           Функция проекции, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Среднее для последовательности значений, или <see langword="null" /> при <paramref name="source" /> последовательность пуста или содержит только <see langword="null" /> значения.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060004C5 RID: 1221 RVA: 0x0000F4AC File Offset: 0x0000D6AC
		public static decimal? Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal?>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return source.Provider.Execute<decimal?>(Expression.Call(null, CachedReflectionInfo.Average_NullableDecimal_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(selector)));
		}

		/// <summary>
		///         Применяет к последовательности агрегатную функцию.
		///       </summary>
		/// <param name="source">
		///           Последовательность, для которой выполняется статистическая операция.
		///         </param>
		/// <param name="func">
		///           Агрегатная функция, чтобы применить к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Конечное агрегатное значение.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="func" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x060004C6 RID: 1222 RVA: 0x0000F504 File Offset: 0x0000D704
		public static TSource Aggregate<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, TSource, TSource>> func)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (func == null)
			{
				throw Error.ArgumentNull("func");
			}
			return source.Provider.Execute<TSource>(Expression.Call(null, CachedReflectionInfo.Aggregate_TSource_2(typeof(TSource)), source.Expression, Expression.Quote(func)));
		}

		/// <summary>
		///         Применяет к последовательности агрегатную функцию.
		///          Указанное начальное значение используется в качестве исходного значения агрегатной операции.
		///       </summary>
		/// <param name="source">
		///           Последовательность, для которой выполняется статистическая операция.
		///         </param>
		/// <param name="seed">
		///           Начальное агрегатное значение.
		///         </param>
		/// <param name="func">
		///           Агрегатная функция, вызываемое для каждого элемента.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TAccumulate">
		///           Тип агрегатного значения.
		///         </typeparam>
		/// <returns>
		///         Конечное агрегатное значение.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="func" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060004C7 RID: 1223 RVA: 0x0000F55C File Offset: 0x0000D75C
		public static TAccumulate Aggregate<TSource, TAccumulate>(this IQueryable<TSource> source, TAccumulate seed, Expression<Func<TAccumulate, TSource, TAccumulate>> func)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (func == null)
			{
				throw Error.ArgumentNull("func");
			}
			return source.Provider.Execute<TAccumulate>(Expression.Call(null, CachedReflectionInfo.Aggregate_TSource_TAccumulate_3(typeof(TSource), typeof(TAccumulate)), source.Expression, Expression.Constant(seed), Expression.Quote(func)));
		}

		/// <summary>
		///         Применяет к последовательности агрегатную функцию.
		///          Указанное начальное значение служит исходным значением для агрегатной операции, а указанная функция используется для выбора результирующего значения.
		///       </summary>
		/// <param name="source">
		///           Последовательность, для которой выполняется статистическая операция.
		///         </param>
		/// <param name="seed">
		///           Начальное агрегатное значение.
		///         </param>
		/// <param name="func">
		///           Агрегатная функция, вызываемое для каждого элемента.
		///         </param>
		/// <param name="selector">
		///           Функция, преобразующая конечное агрегатное значение в результирующее значение.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TAccumulate">
		///           Тип агрегатного значения.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип результирующего значения.
		///         </typeparam>
		/// <returns>
		///         Преобразованное конечное агрегатное значение.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" />, <paramref name="func" /> или <paramref name="selector" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x060004C8 RID: 1224 RVA: 0x0000F5C8 File Offset: 0x0000D7C8
		public static TResult Aggregate<TSource, TAccumulate, TResult>(this IQueryable<TSource> source, TAccumulate seed, Expression<Func<TAccumulate, TSource, TAccumulate>> func, Expression<Func<TAccumulate, TResult>> selector)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			if (func == null)
			{
				throw Error.ArgumentNull("func");
			}
			if (selector == null)
			{
				throw Error.ArgumentNull("selector");
			}
			return source.Provider.Execute<TResult>(Expression.Call(null, CachedReflectionInfo.Aggregate_TSource_TAccumulate_TResult_4(typeof(TSource), typeof(TAccumulate), typeof(TResult)), new Expression[]
			{
				source.Expression,
				Expression.Constant(seed),
				Expression.Quote(func),
				Expression.Quote(selector)
			}));
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0000F664 File Offset: 0x0000D864
		public static IQueryable<TSource> SkipLast<TSource>(this IQueryable<TSource> source, int count)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.SkipLast_TSource_2(typeof(TSource)), source.Expression, Expression.Constant(count)));
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0000F6B0 File Offset: 0x0000D8B0
		public static IQueryable<TSource> TakeLast<TSource>(this IQueryable<TSource> source, int count)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.TakeLast_TSource_2(typeof(TSource)), source.Expression, Expression.Constant(count)));
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0000F6FC File Offset: 0x0000D8FC
		public static IQueryable<TSource> Append<TSource>(this IQueryable<TSource> source, TSource element)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.Append_TSource_2(typeof(TSource)), source.Expression, Expression.Constant(element)));
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0000F748 File Offset: 0x0000D948
		public static IQueryable<TSource> Prepend<TSource>(this IQueryable<TSource> source, TSource element)
		{
			if (source == null)
			{
				throw Error.ArgumentNull("source");
			}
			return source.Provider.CreateQuery<TSource>(Expression.Call(null, CachedReflectionInfo.Prepend_TSource_2(typeof(TSource)), source.Expression, Expression.Constant(element)));
		}
	}
}
