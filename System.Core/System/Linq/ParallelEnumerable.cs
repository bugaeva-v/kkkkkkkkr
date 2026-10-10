using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq.Parallel;
using System.Threading;

namespace System.Linq
{
	/// <summary>
	///         Предоставляет набор методов для выполнения запросов к объектам, реализующим ParallelQuery{TSource}.
	///          Это параллельный эквивалент объекта <see cref="T:System.Linq.Enumerable" />.
	///       </summary>
	// Token: 0x02000082 RID: 130
	public static class ParallelEnumerable
	{
		/// <summary>
		///         Позволяет осуществлять параллельный запрос.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Collections.Generic.IEnumerable`1" /> Для преобразования <see cref="T:System.Linq.ParallelQuery`1" />.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Источник как <see cref="T:System.Linq.ParallelQuery`1" /> для привязки к методам расширения ParallelEnumerable.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		// Token: 0x060002AE RID: 686 RVA: 0x000081B7 File Offset: 0x000063B7
		public static ParallelQuery<TSource> AsParallel<TSource>(this IEnumerable<TSource> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new ParallelEnumerableWrapper<TSource>(source);
		}

		/// <summary>
		///         Позволяет осуществлять параллельный запрос, производимый модулем секционирования, предназначенным для разделения входной последовательности на секции.
		///       </summary>
		/// <param name="source">
		///           Разделитель входной последовательности.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         <paramref name="source" /> В форме ParallelQuery для привязки к методам расширения ParallelEnumerable.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		// Token: 0x060002AF RID: 687 RVA: 0x000081CD File Offset: 0x000063CD
		public static ParallelQuery<TSource> AsParallel<TSource>(this Partitioner<TSource> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new PartitionerQueryOperator<TSource>(source);
		}

		/// <summary>
		///         Позволяет обрабатывать источник данных как упорядоченный независимо от отсутствия упорядоченности по умолчанию.
		///          Метод AsOrdered можно вызывать только для универсальных последовательностей, возвращаемых методами AsParallel, ParallelEnumerable.Range и ParallelEnumerable.Repeat.
		///       </summary>
		/// <param name="source">
		///           Входная последовательность.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Исходная последовательность, поддерживающая первоначальный порядок в последовательных операторах запроса.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Генерируется, если <paramref name="source" /> не содержит элементов
		///
		///             -или-
		///
		///             Если <paramref name="source" /> не является одним из AsParallel, ParallelEnumerable.Range и ParallelEnumerable.Repeat.
		///           </exception>
		// Token: 0x060002B0 RID: 688 RVA: 0x000081E4 File Offset: 0x000063E4
		public static ParallelQuery<TSource> AsOrdered<TSource>(this ParallelQuery<TSource> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (!(source is ParallelEnumerableWrapper<TSource>) && !(source is IParallelPartitionable<TSource>))
			{
				PartitionerQueryOperator<TSource> partitionerQueryOperator = source as PartitionerQueryOperator<TSource>;
				if (partitionerQueryOperator == null)
				{
					throw new InvalidOperationException("AsOrdered may only be called on the result of AsParallel, ParallelEnumerable.Range, or ParallelEnumerable.Repeat.");
				}
				if (!partitionerQueryOperator.Orderable)
				{
					throw new InvalidOperationException("AsOrdered may not be used with a partitioner that is not orderable.");
				}
			}
			return new OrderingQueryOperator<TSource>(QueryOperator<TSource>.AsQueryOperator(source), true);
		}

		/// <summary>
		///         Позволяет обрабатывать источник данных как упорядоченный независимо от отсутствия упорядоченности по умолчанию.
		///          Метод AsOrdered можно вызывать только для неуниверсальных последовательностей, возвращаемых методами AsParallel, ParallelEnumerable.Range и ParallelEnumerable.Repeat.
		///       </summary>
		/// <param name="source">
		///           Входная последовательность.
		///         </param>
		/// <returns>
		///         Исходная последовательность, поддерживающая первоначальный порядок в последовательных операторах запроса.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             генерируется, если <paramref name="source" /> не содержит элементов
		///
		///             -или-
		///
		///              При AsOrdered вызывается наполовину с помощью запроса.
		///              Может вызываться сразу после <see cref="M:System.Linq.ParallelEnumerable.AsParallel(System.Collections.IEnumerable)" />, <see cref="M:System.Linq.ParallelEnumerable.Range(System.Int32,System.Int32)" /> или <see cref="M:System.Linq.ParallelEnumerable.Repeat``1(``0,System.Int32)" />.
		///           </exception>
		// Token: 0x060002B1 RID: 689 RVA: 0x00008243 File Offset: 0x00006443
		public static ParallelQuery AsOrdered(this ParallelQuery source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			ParallelEnumerableWrapper parallelEnumerableWrapper = source as ParallelEnumerableWrapper;
			if (parallelEnumerableWrapper == null)
			{
				throw new InvalidOperationException("Non-generic AsOrdered may only be called on the result of the non-generic AsParallel.");
			}
			return new OrderingQueryOperator<object>(QueryOperator<object>.AsQueryOperator(parallelEnumerableWrapper), true);
		}

		/// <summary>
		///         Позволяет обрабатывать промежуточный запрос как содержащий неупорядоченные элементы.
		///       </summary>
		/// <param name="source">
		///           Входная последовательность.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Исходная последовательность со случайным порядком.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		// Token: 0x060002B2 RID: 690 RVA: 0x00008272 File Offset: 0x00006472
		public static ParallelQuery<TSource> AsUnordered<TSource>(this ParallelQuery<TSource> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new OrderingQueryOperator<TSource>(QueryOperator<TSource>.AsQueryOperator(source), false);
		}

		/// <summary>
		///         Позволяет осуществлять параллельный запрос.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Collections.Generic.IEnumerable`1" /> Для преобразования <see cref="T:System.Linq.ParallelQuery" />.
		///         </param>
		/// <returns>
		///         Значение источника source в форме ParallelQuery для привязки к методам расширения ParallelEnumerable.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		// Token: 0x060002B3 RID: 691 RVA: 0x0000828E File Offset: 0x0000648E
		public static ParallelQuery AsParallel(this IEnumerable source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new ParallelEnumerableWrapper(source);
		}

		/// <summary>
		///         Преобразует <see cref="T:System.Linq.ParallelQuery`1" /> в <see cref="T:System.Collections.Generic.IEnumerable`1" /> для принудительного последовательного вычисления запроса.
		///       </summary>
		/// <param name="source">
		///           Объект <see cref="T:System.Linq.ParallelQuery`1" /> для преобразования <see cref="T:System.Collections.Generic.IEnumerable`1" />.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Источник как <see cref="T:System.Collections.Generic.IEnumerable`1" /> для привязки к последовательным методам расширения.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		// Token: 0x060002B4 RID: 692 RVA: 0x000082A4 File Offset: 0x000064A4
		public static IEnumerable<TSource> AsSequential<TSource>(this ParallelQuery<TSource> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			ParallelEnumerableWrapper<TSource> parallelEnumerableWrapper = source as ParallelEnumerableWrapper<TSource>;
			if (parallelEnumerableWrapper != null)
			{
				return parallelEnumerableWrapper.WrappedEnumerable;
			}
			return source;
		}

		/// <summary>
		///         Задает степень параллельности для использования в запросе.
		///          Степень параллельности — это максимальное число задач, выполняемых одновременно для обработки запроса.
		///       </summary>
		/// <param name="source">
		///           Объект ParallelQuery, для которого нужно установить предел степени параллельности.
		///         </param>
		/// <param name="degreeOfParallelism">
		///           Степень параллельности для запроса.
		///            Значение по умолчанию — Math.Min (<see cref="P:System.Environment.ProcessorCount" />, <see langword="MAX_SUPPORTED_DOP" />) где <see langword="MAX_SUPPORTED_DOP" /> — 512.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Объект ParallelQuery, представляющий такой же запрос, как исходный, с установленным пределом степени параллельности.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="degreeOfParallelism" /> значение меньше 1 или больше 511.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             В запросе WithDegreeOfParallelism используется несколько раз.
		///           </exception>
		// Token: 0x060002B5 RID: 693 RVA: 0x000082D4 File Offset: 0x000064D4
		public static ParallelQuery<TSource> WithDegreeOfParallelism<TSource>(this ParallelQuery<TSource> source, int degreeOfParallelism)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (degreeOfParallelism < 1 || degreeOfParallelism > 512)
			{
				throw new ArgumentOutOfRangeException("degreeOfParallelism");
			}
			QuerySettings empty = QuerySettings.Empty;
			empty.DegreeOfParallelism = new int?(degreeOfParallelism);
			return new QueryExecutionOption<TSource>(QueryOperator<TSource>.AsQueryOperator(source), empty);
		}

		/// <summary>
		///         Наборы <see cref="T:System.Threading.CancellationToken" /> для связи с запросом.
		///       </summary>
		/// <param name="source">
		///           Объект ParallelQuery, свойство которого нужно установить.
		///         </param>
		/// <param name="cancellationToken">
		///           Токен отмены.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Объект ParallelQuery, представляющий такой же запрос, как исходный, но с зарегистрированным токеном отмены.
		///       </returns>
		/// <exception cref="T:System.ObjectDisposedException">
		///             <see cref="T:System.Threading.CancellationTokenSource" /> Связанных с <paramref name="cancellationToken" /> был удален.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="WithCancellation" /> несколько раз используется в запросе.
		///           </exception>
		// Token: 0x060002B6 RID: 694 RVA: 0x00008328 File Offset: 0x00006528
		public static ParallelQuery<TSource> WithCancellation<TSource>(this ParallelQuery<TSource> source, CancellationToken cancellationToken)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			QuerySettings empty = QuerySettings.Empty;
			empty.CancellationState = new CancellationState(cancellationToken);
			return new QueryExecutionOption<TSource>(QueryOperator<TSource>.AsQueryOperator(source), empty);
		}

		/// <summary>
		///         Задает режим выполнения запроса.
		///       </summary>
		/// <param name="source">
		///           Объект ParallelQuery, свойство которого нужно установить.
		///         </param>
		/// <param name="executionMode">
		///           Режим, в котором следует выполнять запрос.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Объект ParallelQuery, представляющий такой же запрос, как исходный, но с зарегистрированным режимом выполнения.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="executionMode" /> не является допустимым значением <see cref="T:System.Linq.ParallelExecutionMode" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             В запросе WithExecutionMode используется несколько раз.
		///           </exception>
		// Token: 0x060002B7 RID: 695 RVA: 0x00008364 File Offset: 0x00006564
		public static ParallelQuery<TSource> WithExecutionMode<TSource>(this ParallelQuery<TSource> source, ParallelExecutionMode executionMode)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (executionMode != ParallelExecutionMode.Default && executionMode != ParallelExecutionMode.ForceParallelism)
			{
				throw new ArgumentException("The executionMode argument contains an invalid value.");
			}
			QuerySettings empty = QuerySettings.Empty;
			empty.ExecutionMode = new ParallelExecutionMode?(executionMode);
			return new QueryExecutionOption<TSource>(QueryOperator<TSource>.AsQueryOperator(source), empty);
		}

		/// <summary>
		///         Задает параметры слияния для запроса, определяющие способ буферизации выходных данных запросом.
		///       </summary>
		/// <param name="source">
		///           Объект ParallelQuery, свойство которого нужно установить.
		///         </param>
		/// <param name="mergeOptions">
		///           Параметры слияния, устанавливаемые для данного запроса.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Объект ParallelQuery, представляющий такой же запрос, как исходный, но с зарегистрированными параметрами слияния.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="mergeOptions" /> не является допустимым значением <see cref="T:System.Linq.ParallelMergeOptions" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="WithMergeOptions" />используется несколько раз в запросе.
		///           </exception>
		// Token: 0x060002B8 RID: 696 RVA: 0x000083B0 File Offset: 0x000065B0
		public static ParallelQuery<TSource> WithMergeOptions<TSource>(this ParallelQuery<TSource> source, ParallelMergeOptions mergeOptions)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (mergeOptions != ParallelMergeOptions.Default && mergeOptions != ParallelMergeOptions.AutoBuffered && mergeOptions != ParallelMergeOptions.NotBuffered && mergeOptions != ParallelMergeOptions.FullyBuffered)
			{
				throw new ArgumentException("The mergeOptions argument contains an invalid value.");
			}
			QuerySettings empty = QuerySettings.Empty;
			empty.MergeOptions = new ParallelMergeOptions?(mergeOptions);
			return new QueryExecutionOption<TSource>(QueryOperator<TSource>.AsQueryOperator(source), empty);
		}

		/// <summary>
		///         Генерирует параллельную последовательность целых чисел в заданном диапазоне.
		///       </summary>
		/// <param name="start">
		///           Значение первого целого числа для последовательности.
		///         </param>
		/// <param name="count">
		///           Количество генерируемых последовательных целых чисел.
		///         </param>
		/// <returns>
		///         Интерфейс IEnumerable&lt;Int32&gt; в C# или IEnumerable(Of Int32) в Visual Basic, содержащий диапазон последовательных целых чисел.
		///       </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="count" /> меньше 0 - или - <paramref name="start" /> + <paramref name="count" /> -1 больше, чем <see cref="F:System.Int32.MaxValue" />.
		///           </exception>
		// Token: 0x060002B9 RID: 697 RVA: 0x00008404 File Offset: 0x00006604
		public static ParallelQuery<int> Range(int start, int count)
		{
			if (count < 0 || (count > 0 && 2147483647 - (count - 1) < start))
			{
				throw new ArgumentOutOfRangeException("count");
			}
			return new RangeEnumerable(start, count);
		}

		/// <summary>
		///         Создает параллельную последовательность, содержащую одно повторяющееся значение.
		///       </summary>
		/// <param name="element">
		///           Повторяемое значение.
		///         </param>
		/// <param name="count">
		///           Требуемое число повторений данного значения в создаваемой последовательности.
		///         </param>
		/// <typeparam name="TResult">
		///           Тип значения, которое будет повторяться в результирующей последовательности.
		///         </typeparam>
		/// <returns>
		///         Последовательность, содержащая повторяющееся значение.
		///       </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Значение параметра <paramref name="count" /> меньше 0.
		///           </exception>
		// Token: 0x060002BA RID: 698 RVA: 0x0000842C File Offset: 0x0000662C
		public static ParallelQuery<TResult> Repeat<TResult>(TResult element, int count)
		{
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			return new RepeatEnumerable<TResult>(element, count);
		}

		/// <summary>
		///         Возвращает пустой набор ParallelQuery{TResult} с указанным аргументом типа.
		///       </summary>
		/// <typeparam name="TResult">
		///           Тип, присваиваемый параметру типа возвращаемой универсальной последовательности.
		///         </typeparam>
		/// <returns>
		///         Пустой последовательностью является аргументом типа <paramref name="TResult" />.
		///       </returns>
		// Token: 0x060002BB RID: 699 RVA: 0x00008444 File Offset: 0x00006644
		public static ParallelQuery<TResult> Empty<TResult>()
		{
			return EmptyEnumerable<TResult>.Instance;
		}

		/// <summary>
		///         Параллельно вызывает указанное действие для каждого элемента в <paramref name="source" />.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.ParallelQuery`1" /> Элементы которого будут обрабатываться <paramref name="action" />.
		///         </param>
		/// <param name="action">
		///           Действие, вызываемое для каждого элемента.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="action" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002BC RID: 700 RVA: 0x0000844B File Offset: 0x0000664B
		public static void ForAll<TSource>(this ParallelQuery<TSource> source, Action<TSource> action)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (action == null)
			{
				throw new ArgumentNullException("action");
			}
			new ForAllOperator<TSource>(source, action).RunSynchronously();
		}

		/// <summary>
		///         Выполняет параллельную фильтрацию последовательности значений на основе предиката.
		///       </summary>
		/// <param name="source">
		///           Последовательность для фильтрации.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки каждого элемента на соответствие условию.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов исходной последовательности.
		///         </typeparam>
		/// <returns>
		///         Последовательность, содержащая элементы входной последовательности, которые удовлетворяют условию.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="predicate" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002BD RID: 701 RVA: 0x00008475 File Offset: 0x00006675
		public static ParallelQuery<TSource> Where<TSource>(this ParallelQuery<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			return new WhereQueryOperator<TSource>(source, predicate);
		}

		/// <summary>
		///         Выполняет параллельную фильтрацию последовательности значений на основе предиката.
		///          Индекс каждого элемента используется в логике функции предиката.
		///       </summary>
		/// <param name="source">
		///           Последовательность для фильтрации.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки каждого элемента на соответствие условию.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов исходной последовательности.
		///         </typeparam>
		/// <returns>
		///         Последовательность, содержащая элементы входной последовательности, которые удовлетворяют условию.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="predicate" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Более чем <see cref="F:System.Int32.MaxValue" /> выполняется перечисление элементов в запросе.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002BE RID: 702 RVA: 0x0000849A File Offset: 0x0000669A
		public static ParallelQuery<TSource> Where<TSource>(this ParallelQuery<TSource> source, Func<TSource, int, bool> predicate)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			return new IndexedWhereQueryOperator<TSource>(source, predicate);
		}

		/// <summary>
		///         Параллельно проецирует каждый элемент последовательности в новую форму.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которых вызывается функция преобразования.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип элементов, возвращаемых селектором.
		///         </typeparam>
		/// <returns>
		///         Последовательность, элементы которого являются результатом преобразования вызова функции для каждого элемента <paramref name="source" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002BF RID: 703 RVA: 0x000084BF File Offset: 0x000066BF
		public static ParallelQuery<TResult> Select<TSource, TResult>(this ParallelQuery<TSource> source, Func<TSource, TResult> selector)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (selector == null)
			{
				throw new ArgumentNullException("selector");
			}
			return new SelectQueryOperator<TSource, TResult>(source, selector);
		}

		/// <summary>
		///         Параллельно проецирует каждый элемент последовательности в новую форму, добавляя индекс элемента.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которых вызывается функция преобразования.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип элементов, возвращаемых селектором.
		///         </typeparam>
		/// <returns>
		///         Последовательность, элементы которой получены в результате вызова функции преобразования для каждого элемента <paramref name="source" /> на основе индекса, предоставленного в <paramref name="selector" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> — это пустая ссылка (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с использованием маркера, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             При оценке запроса получено одно или несколько исключений.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             В запросе перечислено элементов больше, чем определено в <see cref="F:System.Int32.MaxValue" />.
		///              Такая ситуация может возникнуть в сценариях потоковой передачи.
		///           </exception>
		// Token: 0x060002C0 RID: 704 RVA: 0x000084E4 File Offset: 0x000066E4
		public static ParallelQuery<TResult> Select<TSource, TResult>(this ParallelQuery<TSource> source, Func<TSource, int, TResult> selector)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (selector == null)
			{
				throw new ArgumentNullException("selector");
			}
			return new IndexedSelectQueryOperator<TSource, TResult>(source, selector);
		}

		/// <summary>
		///         Параллельно объединяет две последовательности, используя указанную функцию предиката.
		///       </summary>
		/// <param name="first">
		///           Первая последовательность для сворачивания.
		///         </param>
		/// <param name="second">
		///           Вторая последовательность для сворачивания.
		///         </param>
		/// <param name="resultSelector">
		///           Функция для создания результирующего элемента для пары соответствующих элементов.
		///         </param>
		/// <typeparam name="TFirst">
		///           Тип элементов первой последовательности.
		///         </typeparam>
		/// <typeparam name="TSecond">
		///           Тип элементов второй последовательности.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип возвращаемых элементов.
		///         </typeparam>
		/// <returns>
		///         Последовательность, которая содержит элементы типа <paramref name="TResult" /> , полученные в результате <paramref name="resultSelector" /> парные двух последовательностей.
		///          Если длины последовательностей различаются, длина ограничивается более короткой последовательностью.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="first" />или <paramref name="second" /> или <paramref name="resultSelector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с использованием маркера, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             При оценке запроса получено одно или несколько исключений.
		///           </exception>
		// Token: 0x060002C1 RID: 705 RVA: 0x00008509 File Offset: 0x00006709
		public static ParallelQuery<TResult> Zip<TFirst, TSecond, TResult>(this ParallelQuery<TFirst> first, ParallelQuery<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
		{
			if (first == null)
			{
				throw new ArgumentNullException("first");
			}
			if (second == null)
			{
				throw new ArgumentNullException("second");
			}
			if (resultSelector == null)
			{
				throw new ArgumentNullException("resultSelector");
			}
			return new ZipQueryOperator<TFirst, TSecond, TResult>(first, second, resultSelector);
		}

		/// <summary>
		///         Эту перегрузку Zip вызывать не следует.
		///          Этот метод помечен как устаревший и всегда вызывает исключение <see cref="T:System.NotSupportedException" /> при вызове.
		///       </summary>
		/// <param name="first">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="second">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="resultSelector">
		///           Этот параметр не используется.
		///         </param>
		/// <typeparam name="TFirst">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <typeparam name="TSecond">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <returns>
		///         Данная перегрузка всегда возникает исключение <see cref="T:System.NotSupportedException" />.
		///       </returns>
		/// <exception cref="T:System.NotSupportedException">
		///             Исключение, возникающее при вызове этого метода.
		///           </exception>
		// Token: 0x060002C2 RID: 706 RVA: 0x0000853D File Offset: 0x0000673D
		[Obsolete("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
		public static ParallelQuery<TResult> Zip<TFirst, TSecond, TResult>(this ParallelQuery<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
		{
			throw new NotSupportedException("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.");
		}

		/// <summary>
		///         Устанавливает параллельную корреляцию между элементами двух последовательностей на основе сопоставления ключей.
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
		///           Тип элементов второй последовательности.
		///         </typeparam>
		/// <typeparam name="TInner">
		///           Тип элементов первой последовательности.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключей, возвращаемых функциями селектора ключа.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип результирующих элементов.
		///         </typeparam>
		/// <returns>
		///         Последовательность, которая содержит элементы типа <paramref name="TResult" /> полученные в результате внутреннего соединения двух последовательностей.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="action" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002C3 RID: 707 RVA: 0x00008549 File Offset: 0x00006749
		public static ParallelQuery<TResult> Join<TOuter, TInner, TKey, TResult>(this ParallelQuery<TOuter> outer, ParallelQuery<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector)
		{
			return outer.Join(inner, outerKeySelector, innerKeySelector, resultSelector, null);
		}

		/// <summary>
		///         Эту перегрузку Join вызывать не следует.
		///          Этот метод помечен как устаревший и всегда вызывает исключение <see cref="T:System.NotSupportedException" /> при вызове.
		///       </summary>
		/// <param name="outer">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="inner">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="outerKeySelector">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="innerKeySelector">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="resultSelector">
		///           Этот параметр не используется.
		///         </param>
		/// <typeparam name="TOuter">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <typeparam name="TInner">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <returns>
		///         Эта перегрузка всегда создает исключение <see cref="T:System.NotSupportedException" />.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="action" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002C4 RID: 708 RVA: 0x0000853D File Offset: 0x0000673D
		[Obsolete("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
		public static ParallelQuery<TResult> Join<TOuter, TInner, TKey, TResult>(this ParallelQuery<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector)
		{
			throw new NotSupportedException("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.");
		}

		/// <summary>
		///         Устанавливает параллельную корреляцию между элементами двух последовательностей на основе сопоставления ключей.
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
		///           Тип элементов второй последовательности.
		///         </typeparam>
		/// <typeparam name="TInner">
		///           Тип элементов первой последовательности.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключей, возвращаемых функциями селектора ключа.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип результирующих элементов.
		///         </typeparam>
		/// <returns>
		///         Последовательность, которая содержит элементы типа <paramref name="TResult" /> полученные в результате внутреннего соединения двух последовательностей.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="action" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002C5 RID: 709 RVA: 0x00008558 File Offset: 0x00006758
		public static ParallelQuery<TResult> Join<TOuter, TInner, TKey, TResult>(this ParallelQuery<TOuter> outer, ParallelQuery<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector, IEqualityComparer<TKey> comparer)
		{
			if (outer == null)
			{
				throw new ArgumentNullException("outer");
			}
			if (inner == null)
			{
				throw new ArgumentNullException("inner");
			}
			if (outerKeySelector == null)
			{
				throw new ArgumentNullException("outerKeySelector");
			}
			if (innerKeySelector == null)
			{
				throw new ArgumentNullException("innerKeySelector");
			}
			if (resultSelector == null)
			{
				throw new ArgumentNullException("resultSelector");
			}
			return new JoinQueryOperator<TOuter, TInner, TKey, TResult>(outer, inner, outerKeySelector, innerKeySelector, resultSelector, comparer);
		}

		/// <summary>
		///         Эту перегрузку Join вызывать не следует.
		///          Этот метод помечен как устаревший и всегда вызывает исключение <see cref="T:System.NotSupportedException" /> при вызове.
		///       </summary>
		/// <param name="outer">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="inner">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="outerKeySelector">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="innerKeySelector">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="resultSelector">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="comparer">
		///           Этот параметр не используется.
		///         </param>
		/// <typeparam name="TOuter">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <typeparam name="TInner">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <returns>
		///         Эта перегрузка всегда создает исключение <see cref="T:System.NotSupportedException" />.
		///       </returns>
		/// <exception cref="T:System.NotSupportedException">
		///             Исключение, которое возникает при вызове этого метода.
		///           </exception>
		// Token: 0x060002C6 RID: 710 RVA: 0x0000853D File Offset: 0x0000673D
		[Obsolete("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
		public static ParallelQuery<TResult> Join<TOuter, TInner, TKey, TResult>(this ParallelQuery<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector, IEqualityComparer<TKey> comparer)
		{
			throw new NotSupportedException("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.");
		}

		/// <summary>
		///         Устанавливает параллельную корреляцию между элементами двух последовательностей на основе равенства ключей и группирует результаты.
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
		///           Тип элементов второй последовательности.
		///         </typeparam>
		/// <typeparam name="TInner">
		///           Тип элементов первой последовательности.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключей, возвращаемых функциями селектора ключа.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип результирующих элементов.
		///         </typeparam>
		/// <returns>
		///         Последовательность, которая содержит элементы типа <paramref name="TResult" /> полученные в результате выполнения группированное соединение двух последовательностей.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="action" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002C7 RID: 711 RVA: 0x000085B9 File Offset: 0x000067B9
		public static ParallelQuery<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this ParallelQuery<TOuter> outer, ParallelQuery<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
		{
			return outer.GroupJoin(inner, outerKeySelector, innerKeySelector, resultSelector, null);
		}

		/// <summary>
		///         Эту перегрузку GroupJoin вызывать не следует.
		///          Этот метод помечен как устаревший и всегда вызывает исключение <see cref="T:System.NotSupportedException" /> при вызове.
		///       </summary>
		/// <param name="outer">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="inner">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="outerKeySelector">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="innerKeySelector">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="resultSelector">
		///           Этот параметр не используется.
		///         </param>
		/// <typeparam name="TOuter">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <typeparam name="TInner">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <returns>
		///         Эта перегрузка всегда создает исключение <see cref="T:System.NotSupportedException" />.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="action" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002C8 RID: 712 RVA: 0x0000853D File Offset: 0x0000673D
		[Obsolete("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
		public static ParallelQuery<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this ParallelQuery<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
		{
			throw new NotSupportedException("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.");
		}

		/// <summary>
		///         Устанавливает параллельную корреляцию между элементами двух последовательностей на основе равенства ключа и группирует результаты.
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
		///           <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> Для хэширования и сравнения ключей.
		///         </param>
		/// <typeparam name="TOuter">
		///           Тип элементов второй последовательности.
		///         </typeparam>
		/// <typeparam name="TInner">
		///           Тип элементов первой последовательности.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключей, возвращаемых функциями селектора ключа.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип результирующих элементов.
		///         </typeparam>
		/// <returns>
		///         Последовательность, которая содержит элементы типа <paramref name="TResult" /> полученные в результате выполнения группированное соединение двух последовательностей.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="action" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002C9 RID: 713 RVA: 0x000085C8 File Offset: 0x000067C8
		public static ParallelQuery<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this ParallelQuery<TOuter> outer, ParallelQuery<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
		{
			if (outer == null)
			{
				throw new ArgumentNullException("outer");
			}
			if (inner == null)
			{
				throw new ArgumentNullException("inner");
			}
			if (outerKeySelector == null)
			{
				throw new ArgumentNullException("outerKeySelector");
			}
			if (innerKeySelector == null)
			{
				throw new ArgumentNullException("innerKeySelector");
			}
			if (resultSelector == null)
			{
				throw new ArgumentNullException("resultSelector");
			}
			return new GroupJoinQueryOperator<TOuter, TInner, TKey, TResult>(outer, inner, outerKeySelector, innerKeySelector, resultSelector, comparer);
		}

		/// <summary>
		///         Эту перегрузку GroupJoin вызывать не следует.
		///          Этот метод помечен как устаревший и всегда вызывает исключение <see cref="T:System.NotSupportedException" /> при вызове.
		///       </summary>
		/// <param name="outer">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="inner">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="outerKeySelector">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="innerKeySelector">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="resultSelector">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="comparer">
		///           Этот параметр не используется.
		///         </param>
		/// <typeparam name="TOuter">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <typeparam name="TInner">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <returns>
		///         Эта перегрузка всегда создает исключение <see cref="T:System.NotSupportedException" />.
		///       </returns>
		/// <exception cref="T:System.NotSupportedException">
		///             Исключение, которое возникает при вызове этого метода.
		///           </exception>
		// Token: 0x060002CA RID: 714 RVA: 0x0000853D File Offset: 0x0000673D
		[Obsolete("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
		public static ParallelQuery<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this ParallelQuery<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
		{
			throw new NotSupportedException("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.");
		}

		/// <summary>
		///         Параллельно проецирует каждый элемент последовательности в <see cref="T:System.Collections.Generic.IEnumerable`1" /> и объединяет результирующие последовательности в одну последовательность.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, которые следует проецировать.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип элементов последовательности, возвращаемой селектором.
		///         </typeparam>
		/// <returns>
		///         Последовательность, элементы которой получены в результате вызова функции преобразования "один ко многим" для каждого элемента входной последовательности.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002CB RID: 715 RVA: 0x00008629 File Offset: 0x00006829
		public static ParallelQuery<TResult> SelectMany<TSource, TResult>(this ParallelQuery<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (selector == null)
			{
				throw new ArgumentNullException("selector");
			}
			return new SelectManyQueryOperator<TSource, TResult, TResult>(source, selector, null, null);
		}

		/// <summary>
		///         Параллельно проецирует каждый элемент последовательности в объект <see cref="T:System.Collections.Generic.IEnumerable`1" /> и объединяет результирующие последовательности в одну последовательность.
		///          Индекс каждого элемента исходной последовательности используется в проецированной форме этого элемента.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, которые следует проецировать.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип элементов последовательности, возвращаемой селектором.
		///         </typeparam>
		/// <returns>
		///         Последовательность, элементы которой получены в результате вызова функции преобразования "один ко многим" для каждого элемента входной последовательности.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> — это пустая ссылка (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с использованием маркера, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             В запросе перечислено элементов больше, чем определено в <see cref="F:System.Int32.MaxValue" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             При оценке запроса получено одно или несколько исключений.
		///           </exception>
		// Token: 0x060002CC RID: 716 RVA: 0x00008650 File Offset: 0x00006850
		public static ParallelQuery<TResult> SelectMany<TSource, TResult>(this ParallelQuery<TSource> source, Func<TSource, int, IEnumerable<TResult>> selector)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (selector == null)
			{
				throw new ArgumentNullException("selector");
			}
			return new SelectManyQueryOperator<TSource, TResult, TResult>(source, null, selector, null);
		}

		/// <summary>
		///         Проецирует каждый элемент последовательности в <see cref="T:System.Collections.Generic.IEnumerable`1" />, объединяет результирующие последовательности в одну и вызывает функцию селектора результата для каждого элемента этой последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, которые следует проецировать.
		///         </param>
		/// <param name="collectionSelector">
		///           Функция преобразования, применяемая к каждому исходному элементу; второй параметр функции представляет индекс исходного элемента.
		///         </param>
		/// <param name="resultSelector">
		///           Функция, создающая результирующий элемент для элемента первой последовательности и коллекции соответствующих элементов второй последовательности.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип промежуточных элементов собранные <paramref name="collectionSelector" />.
		///         </typeparam>
		/// <typeparam name="TCollection">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип элементов полученной последовательности.
		///         </typeparam>
		/// <returns>
		///         Последовательность, элементы которой получены в результате вызова функции преобразования один ко многим <paramref name="collectionSelector" /> для каждого элемента <paramref name="source" /> на основе индекса, предоставленного для <paramref name="collectionSelector" />, и последующего сопоставления каждого элемента такой промежуточной последовательности и соответствующего ему исходного элемента с полученным элементом.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Более чем <see cref="F:System.Int32.MaxValue" /> выполняется перечисление элементов в запросе.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002CD RID: 717 RVA: 0x00008677 File Offset: 0x00006877
		public static ParallelQuery<TResult> SelectMany<TSource, TCollection, TResult>(this ParallelQuery<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (collectionSelector == null)
			{
				throw new ArgumentNullException("collectionSelector");
			}
			if (resultSelector == null)
			{
				throw new ArgumentNullException("resultSelector");
			}
			return new SelectManyQueryOperator<TSource, TCollection, TResult>(source, collectionSelector, null, resultSelector);
		}

		/// <summary>
		///         Проецирует каждый элемент последовательности в <see cref="T:System.Collections.Generic.IEnumerable`1" />, объединяет результирующие последовательности в одну и вызывает функцию селектора результата для каждого элемента этой последовательности.
		///          Индекс каждого элемента исходной последовательности используется в промежуточной проецированной форме этого элемента.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, которые следует проецировать.
		///         </param>
		/// <param name="collectionSelector">
		///           Функция преобразования, применяемая к каждому исходному элементу; второй параметр функции представляет индекс исходного элемента.
		///         </param>
		/// <param name="resultSelector">
		///           Функция, создающая результирующий элемент для элемента первой последовательности и коллекции соответствующих элементов второй последовательности.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип промежуточных элементов собранные <paramref name="collectionSelector" />.
		///         </typeparam>
		/// <typeparam name="TCollection">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип возвращаемых элементов.
		///         </typeparam>
		/// <returns>
		///         Последовательность, элементы которой получены в результате вызова функции преобразования один ко многим <paramref name="collectionSelector" /> для каждого элемента <paramref name="source" /> на основе индекса, предоставленного для <paramref name="collectionSelector" />, и последующего сопоставления каждого элемента такой промежуточной последовательности и соответствующего ему исходного элемента с полученным элементом.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Более чем <see cref="F:System.Int32.MaxValue" /> выполняется перечисление элементов в запросе.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002CE RID: 718 RVA: 0x000086AC File Offset: 0x000068AC
		public static ParallelQuery<TResult> SelectMany<TSource, TCollection, TResult>(this ParallelQuery<TSource> source, Func<TSource, int, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (collectionSelector == null)
			{
				throw new ArgumentNullException("collectionSelector");
			}
			if (resultSelector == null)
			{
				throw new ArgumentNullException("resultSelector");
			}
			return new SelectManyQueryOperator<TSource, TCollection, TResult>(source, null, collectionSelector, resultSelector);
		}

		/// <summary>
		///         Параллельно сортирует элементы последовательности в порядке возрастания ключа.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, которые следует упорядочить.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ из элемента.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией <paramref name="keySelector" />.
		///         </typeparam>
		/// <returns>
		///         Объект OrderedParallelQuery{TSource}, элементы которого отсортированы по ключу.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="keySelector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002CF RID: 719 RVA: 0x000086E1 File Offset: 0x000068E1
		public static OrderedParallelQuery<TSource> OrderBy<TSource, TKey>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (keySelector == null)
			{
				throw new ArgumentNullException("keySelector");
			}
			return new OrderedParallelQuery<TSource>(new SortQueryOperator<TSource, TKey>(source, keySelector, null, false));
		}

		/// <summary>
		///         Параллельно сортирует элементы последовательности в порядке возрастания с использованием указанного компаратора.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, которые следует упорядочить.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ из элемента.
		///         </param>
		/// <param name="comparer">
		///           Компаратор IComparer{TKey}, используемый для сравнения ключей.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией <paramref name="keySelector" />.
		///         </typeparam>
		/// <returns>
		///         Объект OrderedParallelQuery{TSource}, элементы которого отсортированы по ключу.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="keySelector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002D0 RID: 720 RVA: 0x0000870D File Offset: 0x0000690D
		public static OrderedParallelQuery<TSource> OrderBy<TSource, TKey>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (keySelector == null)
			{
				throw new ArgumentNullException("keySelector");
			}
			return new OrderedParallelQuery<TSource>(new SortQueryOperator<TSource, TKey>(source, keySelector, comparer, false));
		}

		/// <summary>
		///         Параллельно сортирует элементы последовательности в порядке убывания ключа.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, которые следует упорядочить.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ из элемента.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией <paramref name="keySelector" />.
		///         </typeparam>
		/// <returns>
		///         Объект OrderedParallelQuery{TSource}, элементы которого отсортированы по ключу в порядке убывания.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="keySelector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002D1 RID: 721 RVA: 0x00008739 File Offset: 0x00006939
		public static OrderedParallelQuery<TSource> OrderByDescending<TSource, TKey>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (keySelector == null)
			{
				throw new ArgumentNullException("keySelector");
			}
			return new OrderedParallelQuery<TSource>(new SortQueryOperator<TSource, TKey>(source, keySelector, null, true));
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
		///           Компаратор IComparer{TKey}, используемый для сравнения ключей.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией <paramref name="keySelector" />.
		///         </typeparam>
		/// <returns>
		///         Объект OrderedParallelQuery{TSource}, элементы которого отсортированы по ключу в порядке убывания.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="KeySelector" /> является пустой ссылкой (Nothing в Visual Basic)...
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002D2 RID: 722 RVA: 0x00008765 File Offset: 0x00006965
		public static OrderedParallelQuery<TSource> OrderByDescending<TSource, TKey>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (keySelector == null)
			{
				throw new ArgumentNullException("keySelector");
			}
			return new OrderedParallelQuery<TSource>(new SortQueryOperator<TSource, TKey>(source, keySelector, comparer, true));
		}

		/// <summary>
		///         Параллельно выполняет дополнительное упорядочение элементов последовательности в порядке возрастания ключа.
		///       </summary>
		/// <param name="source">
		///           Объект OrderedParallelQuery{TSource}, который содержит элементы для сортировки.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ из элемента.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией <paramref name="keySelector" />.
		///         </typeparam>
		/// <returns>
		///         Объект OrderedParallelQuery{TSource}, элементы которого отсортированы по ключу.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="keySelector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002D3 RID: 723 RVA: 0x00008791 File Offset: 0x00006991
		public static OrderedParallelQuery<TSource> ThenBy<TSource, TKey>(this OrderedParallelQuery<TSource> source, Func<TSource, TKey> keySelector)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (keySelector == null)
			{
				throw new ArgumentNullException("keySelector");
			}
			return new OrderedParallelQuery<TSource>((QueryOperator<TSource>)source.OrderedEnumerable.CreateOrderedEnumerable<TKey>(keySelector, null, false));
		}

		/// <summary>
		///         Параллельно выполняет дополнительное упорядочение элементов последовательности в порядке возрастания с использованием указанного компаратора.
		///       </summary>
		/// <param name="source">
		///           Объект OrderedParallelQuery{TSource}, который содержит элементы для сортировки.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ из элемента.
		///         </param>
		/// <param name="comparer">
		///           Компаратор IComparer{TKey}, используемый для сравнения ключей.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией <paramref name="keySelector" />.
		///         </typeparam>
		/// <returns>
		///         Объект OrderedParallelQuery{TSource}, элементы которого отсортированы по ключу.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="keySelector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002D4 RID: 724 RVA: 0x000087C7 File Offset: 0x000069C7
		public static OrderedParallelQuery<TSource> ThenBy<TSource, TKey>(this OrderedParallelQuery<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (keySelector == null)
			{
				throw new ArgumentNullException("keySelector");
			}
			return new OrderedParallelQuery<TSource>((QueryOperator<TSource>)source.OrderedEnumerable.CreateOrderedEnumerable<TKey>(keySelector, comparer, false));
		}

		/// <summary>
		///         Параллельно выполняет дополнительное упорядочение элементов последовательности в порядке убывания ключа.
		///       </summary>
		/// <param name="source">
		///           Объект OrderedParallelQuery{TSource}, который содержит элементы для сортировки.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ из элемента.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией <paramref name="keySelector" />.
		///         </typeparam>
		/// <returns>
		///         Последовательность, элементы которой сортируются по ключу в порядке убывания.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="keySelector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002D5 RID: 725 RVA: 0x000087FD File Offset: 0x000069FD
		public static OrderedParallelQuery<TSource> ThenByDescending<TSource, TKey>(this OrderedParallelQuery<TSource> source, Func<TSource, TKey> keySelector)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (keySelector == null)
			{
				throw new ArgumentNullException("keySelector");
			}
			return new OrderedParallelQuery<TSource>((QueryOperator<TSource>)source.OrderedEnumerable.CreateOrderedEnumerable<TKey>(keySelector, null, true));
		}

		/// <summary>
		///         Параллельно выполняет дополнительное упорядочение элементов последовательности в порядке убывания с использованием указанного компаратора.
		///       </summary>
		/// <param name="source">
		///           Объект OrderedParallelQuery{TSource}, который содержит элементы для сортировки.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ из элемента.
		///         </param>
		/// <param name="comparer">
		///           Компаратор IComparer{TKey}, используемый для сравнения ключей.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией <paramref name="keySelector" />.
		///         </typeparam>
		/// <returns>
		///         Последовательность, элементы которой сортируются по ключу в порядке убывания.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="keySelector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002D6 RID: 726 RVA: 0x00008833 File Offset: 0x00006A33
		public static OrderedParallelQuery<TSource> ThenByDescending<TSource, TKey>(this OrderedParallelQuery<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (keySelector == null)
			{
				throw new ArgumentNullException("keySelector");
			}
			return new OrderedParallelQuery<TSource>((QueryOperator<TSource>)source.OrderedEnumerable.CreateOrderedEnumerable<TKey>(keySelector, comparer, true));
		}

		/// <summary>
		///         Группирует элементы параллельной последовательности в соответствии с заданной функцией селектора ключа.
		///       </summary>
		/// <param name="source">
		///           Объект OrderedParallelQuery{TSource}, который содержит элементы для сортировки.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ из элемента.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией <paramref name="keySelector" />.
		///         </typeparam>
		/// <returns>
		///         Последовательность групп, которые сортируются в порядке убывания по параметру <paramref name="TKey" />.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="action" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002D7 RID: 727 RVA: 0x00008869 File Offset: 0x00006A69
		public static ParallelQuery<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector)
		{
			return source.GroupBy(keySelector, null);
		}

		/// <summary>
		///         Параллельно группирует элементы последовательности в соответствии с заданной функцией селектора ключа и сравнивает ключи с помощью указанного <see cref="T:System.Collections.Generic.IComparer`1" />.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.OrderedParallelQuery`1" /> Содержащий элементы для сортировки.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ из элемента.
		///         </param>
		/// <param name="comparer">
		///           <see cref="T:System.Collections.Generic.IComparer`1" /> Для сравнения ключей.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией <paramref name="keySelector" />&gt;.
		///         </typeparam>
		/// <returns>
		///         Последовательность групп, которые сортируются в порядке убывания по параметру <paramref name="TKey" />.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="action" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002D8 RID: 728 RVA: 0x00008873 File Offset: 0x00006A73
		public static ParallelQuery<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (keySelector == null)
			{
				throw new ArgumentNullException("keySelector");
			}
			return new GroupByQueryOperator<TSource, TKey, TSource>(source, keySelector, null, comparer);
		}

		/// <summary>
		///         Группирует элементы параллельной последовательности в соответствии с заданной функцией селектора ключа и проецирует элементы каждой группы с помощью указанной функции.
		///       </summary>
		/// <param name="source">
		///           <see cref="T:System.Linq.OrderedParallelQuery`1" /> Содержащий элементы для сортировки.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ из элемента.
		///         </param>
		/// <param name="elementSelector">
		///           Функция, сопоставляющая каждый исходный элемент с элементом в <see cref="T:System.Linq.IGrouping`2" />.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией <paramref name="keySelector" />.
		///         </typeparam>
		/// <typeparam name="TElement">
		///           Тип элементов в <see cref="T:System.Linq.IGrouping`2" />.
		///         </typeparam>
		/// <returns>
		///         Последовательность групп, которые сортируются в порядке убывания по параметру <paramref name="TKey" />.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="action" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002D9 RID: 729 RVA: 0x0000889A File Offset: 0x00006A9A
		public static ParallelQuery<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
		{
			return source.GroupBy(keySelector, elementSelector, null);
		}

		/// <summary>
		///         Группирует элементы параллельной последовательности в соответствии с функцией селектора ключа.
		///          Ключи сравниваются с помощью компаратора, элементы каждой группы проецируются с помощью указанной функции.
		///       </summary>
		/// <param name="source">
		///           Объект OrderedParallelQuery{TSource}, который содержит элементы для сортировки.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ из элемента.
		///         </param>
		/// <param name="elementSelector">
		///           Функция, сопоставляющая каждый исходный элемент с элементом в IGrouping.
		///         </param>
		/// <param name="comparer">
		///           Компаратор IComparer{TSource}, используемый для сравнения ключей.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией <paramref name="keySelector" />.
		///         </typeparam>
		/// <typeparam name="TElement">
		///           Тип элементов в IGrouping.
		///         </typeparam>
		/// <returns>
		///         Последовательность групп, которые сортируются в порядке убывания по параметру <paramref name="TKey" />.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="action" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002DA RID: 730 RVA: 0x000088A5 File Offset: 0x00006AA5
		public static ParallelQuery<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (keySelector == null)
			{
				throw new ArgumentNullException("keySelector");
			}
			if (elementSelector == null)
			{
				throw new ArgumentNullException("elementSelector");
			}
			return new GroupByQueryOperator<TSource, TKey, TElement>(source, keySelector, elementSelector, comparer);
		}

		/// <summary>
		///         Группирует элементы параллельной последовательности в соответствии с заданной функцией селектора ключа и создает результирующее значение для каждой группы и ее ключа.
		///       </summary>
		/// <param name="source">
		///           Последовательность, элементы которой требуется сгруппировать.
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
		///           Тип ключа, возвращаемого функцией <paramref name="keySelector" />.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип результирующего значения, возвращаемые <paramref name="resultSelector" />.
		///         </typeparam>
		/// <returns>
		///         Последовательность элементов типа <paramref name="TResult" /> которой каждый элемент представляет проекцию группы и ее ключа.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="action" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002DB RID: 731 RVA: 0x000088DC File Offset: 0x00006ADC
		public static ParallelQuery<TResult> GroupBy<TSource, TKey, TResult>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector)
		{
			if (resultSelector == null)
			{
				throw new ArgumentNullException("resultSelector");
			}
			return from grouping in source.GroupBy(keySelector)
			select resultSelector(grouping.Key, grouping);
		}

		/// <summary>
		///         Группирует элементы параллельной последовательности в соответствии с заданной функцией селектора ключа и создает результирующее значение для каждой группы и ее ключа.
		///          Ключи сравниваются с использованием заданного компаратора.
		///       </summary>
		/// <param name="source">
		///           Последовательность, элементы которой требуется сгруппировать.
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
		///           Тип ключа, возвращаемого функцией <paramref name="keySelector" />.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип результирующего значения, возвращаемые <paramref name="resultSelector" />.
		///         </typeparam>
		/// <returns>
		///         Последовательность групп.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="action" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002DC RID: 732 RVA: 0x00008924 File Offset: 0x00006B24
		public static ParallelQuery<TResult> GroupBy<TSource, TKey, TResult>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
		{
			if (resultSelector == null)
			{
				throw new ArgumentNullException("resultSelector");
			}
			return from grouping in source.GroupBy(keySelector, comparer)
			select resultSelector(grouping.Key, grouping);
		}

		/// <summary>
		///         Группирует элементы параллельной последовательности в соответствии с заданной функцией селектора ключа и создает результирующее значение для каждой группы и ее ключа.
		///          Элементы каждой группы проецируются с помощью указанной функции.
		///       </summary>
		/// <param name="source">
		///           Последовательность, элементы которой требуется сгруппировать.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ для каждого элемента.
		///         </param>
		/// <param name="elementSelector">
		///           Функция, сопоставляющая каждый исходный элемент с элементом в IGrouping&lt;TKey, TElement&gt;.
		///         </param>
		/// <param name="resultSelector">
		///           Функция для создания результирующего значения для каждой группы.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией <paramref name="keySelector" />.
		///         </typeparam>
		/// <typeparam name="TElement">
		///           Тип элементов в каждом IGrouping{TKey, TElement}.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип результирующего значения, возвращаемые <paramref name="resultSelector" />.
		///         </typeparam>
		/// <returns>
		///         Последовательность элементов типа <paramref name="TResult" /> которой каждый элемент представляет проекцию группы и ее ключа.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="action" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002DD RID: 733 RVA: 0x0000896C File Offset: 0x00006B6C
		public static ParallelQuery<TResult> GroupBy<TSource, TKey, TElement, TResult>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
		{
			if (resultSelector == null)
			{
				throw new ArgumentNullException("resultSelector");
			}
			return from grouping in source.GroupBy(keySelector, elementSelector)
			select resultSelector(grouping.Key, grouping);
		}

		/// <summary>
		///         Группирует элементы последовательности в соответствии с заданной функцией селектора ключа и создает результирующее значение для каждой группы и ее ключа.
		///          Значения ключей сравниваются с помощью указанного компаратора, элементы каждой группы проецируются с помощью указанной функции.
		///       </summary>
		/// <param name="source">
		///           Последовательность, элементы которой требуется сгруппировать.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ для каждого элемента.
		///         </param>
		/// <param name="elementSelector">
		///           Функция, сопоставляющая каждый исходный элемент с элементом в IGrouping{Key, TElement}.
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
		///           Тип ключа, возвращаемого функцией <paramref name="keySelector" />.
		///         </typeparam>
		/// <typeparam name="TElement">
		///           Тип элементов в каждом IGrouping{TKey, TElement}.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип результирующего значения, возвращаемые <paramref name="resultSelector" />.
		///         </typeparam>
		/// <returns>
		///         Последовательность элементов типа <paramref name="TResult" /> которой каждый элемент представляет проекцию группы и ее ключа.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="action" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002DE RID: 734 RVA: 0x000089B4 File Offset: 0x00006BB4
		public static ParallelQuery<TResult> GroupBy<TSource, TKey, TElement, TResult>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
		{
			if (resultSelector == null)
			{
				throw new ArgumentNullException("resultSelector");
			}
			return from grouping in source.GroupBy(keySelector, elementSelector, comparer)
			select resultSelector(grouping.Key, grouping);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x000089FC File Offset: 0x00006BFC
		private static T PerformAggregation<T>(this ParallelQuery<T> source, Func<T, T, T> reduce, T seed, bool seedIsSpecified, bool throwIfEmpty, QueryAggregationOptions options)
		{
			return new AssociativeAggregationOperator<T, T, T>(source, seed, null, seedIsSpecified, reduce, reduce, (T obj) => obj, throwIfEmpty, options).Aggregate();
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00008A3C File Offset: 0x00006C3C
		private static TAccumulate PerformSequentialAggregation<TSource, TAccumulate>(this ParallelQuery<TSource> source, TAccumulate seed, bool seedIsSpecified, Func<TAccumulate, TSource, TAccumulate> func)
		{
			TAccumulate result;
			using (IEnumerator<TSource> enumerator = source.GetEnumerator())
			{
				TAccumulate taccumulate;
				if (seedIsSpecified)
				{
					taccumulate = seed;
				}
				else
				{
					if (!enumerator.MoveNext())
					{
						throw new InvalidOperationException("Sequence contains no elements");
					}
					taccumulate = (TAccumulate)((object)enumerator.Current);
				}
				while (enumerator.MoveNext())
				{
					TSource arg = enumerator.Current;
					try
					{
						taccumulate = func(taccumulate, arg);
					}
					catch (Exception ex)
					{
						throw new AggregateException(new Exception[]
						{
							ex
						});
					}
				}
				result = taccumulate;
			}
			return result;
		}

		/// <summary>
		///         Параллельно применяет к последовательности агрегатную функцию.
		///       </summary>
		/// <param name="source">
		///           Последовательность, для которой выполняется статистическая операция.
		///         </param>
		/// <param name="func">
		///           Агрегатная функция, вызываемая для каждого элемента.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Конечное агрегатное значение.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="func" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x060002E1 RID: 737 RVA: 0x00008AD8 File Offset: 0x00006CD8
		public static TSource Aggregate<TSource>(this ParallelQuery<TSource> source, Func<TSource, TSource, TSource> func)
		{
			return source.Aggregate(func, QueryAggregationOptions.AssociativeCommutative);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00008AE4 File Offset: 0x00006CE4
		internal static TSource Aggregate<TSource>(this ParallelQuery<TSource> source, Func<TSource, TSource, TSource> func, QueryAggregationOptions options)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (func == null)
			{
				throw new ArgumentNullException("func");
			}
			if ((~(QueryAggregationOptions.Associative | QueryAggregationOptions.Commutative) & options) != QueryAggregationOptions.None)
			{
				throw new ArgumentOutOfRangeException("options");
			}
			if ((options & QueryAggregationOptions.Associative) != QueryAggregationOptions.Associative)
			{
				return source.PerformSequentialAggregation(default(TSource), false, func);
			}
			return source.PerformAggregation(func, default(TSource), false, true, options);
		}

		/// <summary>
		///         Параллельно применяет к последовательности агрегатную функцию.
		///          Указанное начальное значение используется в качестве исходного значения агрегатной операции.
		///       </summary>
		/// <param name="source">
		///           Последовательность, для которой выполняется статистическая операция.
		///         </param>
		/// <param name="seed">
		///           Начальное агрегатное значение.
		///         </param>
		/// <param name="func">
		///           Агрегатная функция, вызываемая для каждого элемента.
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
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="func" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x060002E3 RID: 739 RVA: 0x00008B49 File Offset: 0x00006D49
		public static TAccumulate Aggregate<TSource, TAccumulate>(this ParallelQuery<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
		{
			return source.Aggregate(seed, func, QueryAggregationOptions.AssociativeCommutative);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00008B54 File Offset: 0x00006D54
		internal static TAccumulate Aggregate<TSource, TAccumulate>(this ParallelQuery<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, QueryAggregationOptions options)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (func == null)
			{
				throw new ArgumentNullException("func");
			}
			if ((~(QueryAggregationOptions.Associative | QueryAggregationOptions.Commutative) & options) != QueryAggregationOptions.None)
			{
				throw new ArgumentOutOfRangeException("options");
			}
			return source.PerformSequentialAggregation(seed, true, func);
		}

		/// <summary>
		///         Параллельно применяет к последовательности агрегатную функцию.
		///          Указанное начальное значение служит исходным значением для агрегатной операции, а указанная функция используется для выбора результирующего значения.
		///       </summary>
		/// <param name="source">
		///           Последовательность, для которой выполняется статистическая операция.
		///         </param>
		/// <param name="seed">
		///           Начальное агрегатное значение.
		///         </param>
		/// <param name="func">
		///           Агрегатная функция, вызываемая для каждого элемента.
		///         </param>
		/// <param name="resultSelector">
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
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="func" /> или <paramref name="resultSelector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x060002E5 RID: 741 RVA: 0x00008B8C File Offset: 0x00006D8C
		public static TResult Aggregate<TSource, TAccumulate, TResult>(this ParallelQuery<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (func == null)
			{
				throw new ArgumentNullException("func");
			}
			if (resultSelector == null)
			{
				throw new ArgumentNullException("resultSelector");
			}
			TAccumulate arg = source.PerformSequentialAggregation(seed, true, func);
			TResult result;
			try
			{
				result = resultSelector(arg);
			}
			catch (Exception ex)
			{
				throw new AggregateException(new Exception[]
				{
					ex
				});
			}
			return result;
		}

		/// <summary>
		///         Параллельно применяет к последовательности агрегатную функцию.
		///          Эта перегрузка недоступна в последовательной реализации.
		///       </summary>
		/// <param name="source">
		///           Последовательность, для которой выполняется статистическая операция.
		///         </param>
		/// <param name="seed">
		///           Начальное агрегатное значение.
		///         </param>
		/// <param name="updateAccumulatorFunc">
		///           Агрегатная функция, вызываемая для каждого элемента в секции.
		///         </param>
		/// <param name="combineAccumulatorsFunc">
		///           Агрегатная функция, вызываемая для суммарного результата, полученного из каждой секции.
		///         </param>
		/// <param name="resultSelector">
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
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="updateAccumulatorFunc" /> или <paramref name="combineAccumulatorsFunc" /> или <paramref name="resultSelector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x060002E6 RID: 742 RVA: 0x00008BFC File Offset: 0x00006DFC
		public static TResult Aggregate<TSource, TAccumulate, TResult>(this ParallelQuery<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> updateAccumulatorFunc, Func<TAccumulate, TAccumulate, TAccumulate> combineAccumulatorsFunc, Func<TAccumulate, TResult> resultSelector)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (updateAccumulatorFunc == null)
			{
				throw new ArgumentNullException("updateAccumulatorFunc");
			}
			if (combineAccumulatorsFunc == null)
			{
				throw new ArgumentNullException("combineAccumulatorsFunc");
			}
			if (resultSelector == null)
			{
				throw new ArgumentNullException("resultSelector");
			}
			return new AssociativeAggregationOperator<TSource, TAccumulate, TResult>(source, seed, null, true, updateAccumulatorFunc, combineAccumulatorsFunc, resultSelector, false, QueryAggregationOptions.AssociativeCommutative).Aggregate();
		}

		/// <summary>
		///         Параллельно применяет к последовательности агрегатную функцию.
		///          Эта перегрузка недоступна в последовательной реализации.
		///       </summary>
		/// <param name="source">
		///           Последовательность, для которой выполняется статистическая операция.
		///         </param>
		/// <param name="seedFactory">
		///           Функция, возвращающая начальное агрегатное значение.
		///         </param>
		/// <param name="updateAccumulatorFunc">
		///           Агрегатная функция, вызываемая для каждого элемента в секции.
		///         </param>
		/// <param name="combineAccumulatorsFunc">
		///           Агрегатная функция, вызываемая для суммарного результата, полученного из каждой секции.
		///         </param>
		/// <param name="resultSelector">
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
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="seedFactory" /> или <paramref name="updateAccumulatorFunc" /> или <paramref name="combineAccumulatorsFunc" /> или <paramref name="resultSelector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x060002E7 RID: 743 RVA: 0x00008C58 File Offset: 0x00006E58
		public static TResult Aggregate<TSource, TAccumulate, TResult>(this ParallelQuery<TSource> source, Func<TAccumulate> seedFactory, Func<TAccumulate, TSource, TAccumulate> updateAccumulatorFunc, Func<TAccumulate, TAccumulate, TAccumulate> combineAccumulatorsFunc, Func<TAccumulate, TResult> resultSelector)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (seedFactory == null)
			{
				throw new ArgumentNullException("seedFactory");
			}
			if (updateAccumulatorFunc == null)
			{
				throw new ArgumentNullException("updateAccumulatorFunc");
			}
			if (combineAccumulatorsFunc == null)
			{
				throw new ArgumentNullException("combineAccumulatorsFunc");
			}
			if (resultSelector == null)
			{
				throw new ArgumentNullException("resultSelector");
			}
			return new AssociativeAggregationOperator<TSource, TAccumulate, TResult>(source, default(TAccumulate), seedFactory, true, updateAccumulatorFunc, combineAccumulatorsFunc, resultSelector, false, QueryAggregationOptions.AssociativeCommutative).Aggregate();
		}

		/// <summary>
		///         Возвращает количество элементов в параллельной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность, элементы которой требуется подсчитать.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Число элементов во входной последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Количество элементов в исходном больше, чем <see cref="F:System.Int32.MaxValue" />.
		///              (В данном случае является InnerException <see cref="T:System.OverflowException" />) - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002E8 RID: 744 RVA: 0x00008CC8 File Offset: 0x00006EC8
		public static int Count<TSource>(this ParallelQuery<TSource> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			ParallelEnumerableWrapper<TSource> parallelEnumerableWrapper = source as ParallelEnumerableWrapper<TSource>;
			if (parallelEnumerableWrapper != null)
			{
				ICollection<TSource> collection = parallelEnumerableWrapper.WrappedEnumerable as ICollection<TSource>;
				if (collection != null)
				{
					return collection.Count;
				}
			}
			return new CountAggregationOperator<TSource>(source).Aggregate();
		}

		/// <summary>
		///         Возвращает число, представляющее количество элементов параллельной последовательности, удовлетворяющих заданному условию.
		///       </summary>
		/// <param name="source">
		///           Последовательность, элементы которой требуется подсчитать.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки каждого элемента на соответствие условию.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Число, представляющее количество элементов последовательности, удовлетворяющих условию функции предиката.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="predicate" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Количество элементов в исходном больше, чем <see cref="F:System.Int32.MaxValue" />.
		///              (В данном случае является InnerException <see cref="T:System.OverflowException" />) - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002E9 RID: 745 RVA: 0x00008D0E File Offset: 0x00006F0E
		public static int Count<TSource>(this ParallelQuery<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			return new CountAggregationOperator<TSource>(source.Where(predicate)).Aggregate();
		}

		/// <summary>
		///         Возвращает значение типа Int64, представляющее общее число элементов в параллельной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность, элементы которой требуется подсчитать.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Число элементов во входной последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Количество элементов в исходном больше, чем <see cref="F:System.Int64.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Вычисленный результат больше, чем <see cref="F:System.Int64.MaxValue" />.
		///           </exception>
		// Token: 0x060002EA RID: 746 RVA: 0x00008D40 File Offset: 0x00006F40
		public static long LongCount<TSource>(this ParallelQuery<TSource> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			ParallelEnumerableWrapper<TSource> parallelEnumerableWrapper = source as ParallelEnumerableWrapper<TSource>;
			if (parallelEnumerableWrapper != null)
			{
				ICollection<TSource> collection = parallelEnumerableWrapper.WrappedEnumerable as ICollection<TSource>;
				if (collection != null)
				{
					return (long)collection.Count;
				}
			}
			return new LongCountAggregationOperator<TSource>(source).Aggregate();
		}

		/// <summary>
		///         Возвращает значение типа Int64, представляющее число элементов параллельной последовательности, удовлетворяющих заданному условию.
		///       </summary>
		/// <param name="source">
		///           Последовательность, элементы которой требуется подсчитать.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки каждого элемента на соответствие условию.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Число, представляющее количество элементов последовательности, удовлетворяющих условию функции предиката.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="predicate" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Количество элементов в исходном больше, чем <see cref="F:System.Int64.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Вычисленный результат больше, чем <see cref="F:System.Int64.MaxValue" />.
		///           </exception>
		// Token: 0x060002EB RID: 747 RVA: 0x00008D87 File Offset: 0x00006F87
		public static long LongCount<TSource>(this ParallelQuery<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			return new LongCountAggregationOperator<TSource>(source.Where(predicate)).Aggregate();
		}

		/// <summary>
		///         Параллельно вычисляет сумму для последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, сумму которых требуется вычислить.
		///         </param>
		/// <returns>
		///         Сумма проецированных значений последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма больше, чем <see cref="F:System.Int32.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002EC RID: 748 RVA: 0x00008DB6 File Offset: 0x00006FB6
		public static int Sum(this ParallelQuery<int> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new IntSumAggregationOperator(source).Aggregate();
		}

		/// <summary>
		///         Параллельно вычисляет сумму для последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, сумму которых требуется вычислить.
		///         </param>
		/// <returns>
		///         Сумма проецированных значений последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма больше, чем <see cref="F:System.Int32.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002ED RID: 749 RVA: 0x00008DD1 File Offset: 0x00006FD1
		public static int? Sum(this ParallelQuery<int?> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new NullableIntSumAggregationOperator(source).Aggregate();
		}

		/// <summary>
		///         Параллельно вычисляет сумму для последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, сумму которых требуется вычислить.
		///         </param>
		/// <returns>
		///         Сумма проецированных значений последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма больше, чем <see cref="F:System.Int64.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002EE RID: 750 RVA: 0x00008DEC File Offset: 0x00006FEC
		public static long Sum(this ParallelQuery<long> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new LongSumAggregationOperator(source).Aggregate();
		}

		/// <summary>
		///         Параллельно вычисляет сумму для последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, сумму которых требуется вычислить.
		///         </param>
		/// <returns>
		///         Сумма проецированных значений последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма больше, чем <see cref="F:System.Int64.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002EF RID: 751 RVA: 0x00008E07 File Offset: 0x00007007
		public static long? Sum(this ParallelQuery<long?> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new NullableLongSumAggregationOperator(source).Aggregate();
		}

		/// <summary>
		///         Параллельно вычисляет сумму для последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, сумму которых требуется вычислить.
		///         </param>
		/// <returns>
		///         Сумма проецированных значений последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма больше, чем <see cref="F:System.Single.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002F0 RID: 752 RVA: 0x00008E22 File Offset: 0x00007022
		public static float Sum(this ParallelQuery<float> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new FloatSumAggregationOperator(source).Aggregate();
		}

		/// <summary>
		///         Параллельно вычисляет сумму для последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, сумму которых требуется вычислить.
		///         </param>
		/// <returns>
		///         Сумма проецированных значений последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма больше, чем <see cref="F:System.Single.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002F1 RID: 753 RVA: 0x00008E3D File Offset: 0x0000703D
		public static float? Sum(this ParallelQuery<float?> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new NullableFloatSumAggregationOperator(source).Aggregate();
		}

		/// <summary>
		///         Параллельно вычисляет сумму для последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, сумму которых требуется вычислить.
		///         </param>
		/// <returns>
		///         Сумма проецированных значений последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма больше, чем <see cref="F:System.Double.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002F2 RID: 754 RVA: 0x00008E58 File Offset: 0x00007058
		public static double Sum(this ParallelQuery<double> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new DoubleSumAggregationOperator(source).Aggregate();
		}

		/// <summary>
		///         Параллельно вычисляет сумму для последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, сумму которых требуется вычислить.
		///         </param>
		/// <returns>
		///         Сумма проецированных значений последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма больше, чем <see cref="F:System.Double.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002F3 RID: 755 RVA: 0x00008E73 File Offset: 0x00007073
		public static double? Sum(this ParallelQuery<double?> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new NullableDoubleSumAggregationOperator(source).Aggregate();
		}

		/// <summary>
		///         Параллельно вычисляет сумму для последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, сумму которых требуется вычислить.
		///         </param>
		/// <returns>
		///         Сумма проецированных значений последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма больше, чем <see cref="F:System.Decimal.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002F4 RID: 756 RVA: 0x00008E8E File Offset: 0x0000708E
		public static decimal Sum(this ParallelQuery<decimal> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new DecimalSumAggregationOperator(source).Aggregate();
		}

		/// <summary>
		///         Параллельно вычисляет сумму для последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, сумму которых требуется вычислить.
		///         </param>
		/// <returns>
		///         Сумма проецированных значений последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма больше, чем <see cref="F:System.Decimal.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002F5 RID: 757 RVA: 0x00008EA9 File Offset: 0x000070A9
		public static decimal? Sum(this ParallelQuery<decimal?> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new NullableDecimalSumAggregationOperator(source).Aggregate();
		}

		/// <summary>
		///         Параллельно вычисляет сумму для последовательности значений, получаемой в результате применения функции преобразования к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, сумму которых требуется вычислить.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов исходной последовательности.
		///         </typeparam>
		/// <returns>
		///         Сумма проецированных значений последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с использованием маркера, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="selector" /> — это пустая ссылка (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма больше, чем <see cref="F:System.Int32.MaxValue" />.
		///              -или- При оценке запроса получено одно или несколько исключений.
		///           </exception>
		// Token: 0x060002F6 RID: 758 RVA: 0x00008EC4 File Offset: 0x000070C4
		public static int Sum<TSource>(this ParallelQuery<TSource> source, Func<TSource, int> selector)
		{
			return source.Select(selector).Sum();
		}

		/// <summary>
		///         Параллельно вычисляет сумму для последовательности значений, получаемой в результате применения функции преобразования к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, сумму которых требуется вычислить.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Сумма проецированных значений последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма больше, чем <see cref="F:System.Int32.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002F7 RID: 759 RVA: 0x00008ED2 File Offset: 0x000070D2
		public static int? Sum<TSource>(this ParallelQuery<TSource> source, Func<TSource, int?> selector)
		{
			return source.Select(selector).Sum();
		}

		/// <summary>
		///         Параллельно вычисляет сумму для последовательности значений, получаемой в результате применения функции преобразования к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, сумму которых требуется вычислить.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Сумма проецированных значений последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма больше, чем <see cref="F:System.Int64.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002F8 RID: 760 RVA: 0x00008EE0 File Offset: 0x000070E0
		public static long Sum<TSource>(this ParallelQuery<TSource> source, Func<TSource, long> selector)
		{
			return source.Select(selector).Sum();
		}

		/// <summary>
		///         Параллельно вычисляет сумму для последовательности значений, получаемой в результате применения функции преобразования к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, сумму которых требуется вычислить.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Сумма проецированных значений последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма больше, чем <see cref="F:System.Int64.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002F9 RID: 761 RVA: 0x00008EEE File Offset: 0x000070EE
		public static long? Sum<TSource>(this ParallelQuery<TSource> source, Func<TSource, long?> selector)
		{
			return source.Select(selector).Sum();
		}

		/// <summary>
		///         Параллельно вычисляет сумму для последовательности значений, получаемой в результате применения функции преобразования к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, сумму которых требуется вычислить.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Сумма проецированных значений последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма больше, чем <see cref="F:System.Single.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002FA RID: 762 RVA: 0x00008EFC File Offset: 0x000070FC
		public static float Sum<TSource>(this ParallelQuery<TSource> source, Func<TSource, float> selector)
		{
			return source.Select(selector).Sum();
		}

		/// <summary>
		///         Параллельно вычисляет сумму для последовательности значений, получаемой в результате применения функции преобразования к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, сумму которых требуется вычислить.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Сумма проецированных значений последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма больше, чем <see cref="F:System.Single.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002FB RID: 763 RVA: 0x00008F0A File Offset: 0x0000710A
		public static float? Sum<TSource>(this ParallelQuery<TSource> source, Func<TSource, float?> selector)
		{
			return source.Select(selector).Sum();
		}

		/// <summary>
		///         Параллельно вычисляет сумму для последовательности значений, получаемой в результате применения функции преобразования к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, сумму которых требуется вычислить.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Сумма проецированных значений последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма больше, чем <see cref="F:System.Double.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002FC RID: 764 RVA: 0x00008F18 File Offset: 0x00007118
		public static double Sum<TSource>(this ParallelQuery<TSource> source, Func<TSource, double> selector)
		{
			return source.Select(selector).Sum();
		}

		/// <summary>
		///         Параллельно вычисляет сумму для последовательности значений, получаемой в результате применения функции преобразования к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, сумму которых требуется вычислить.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Сумма проецированных значений последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма больше, чем <see cref="F:System.Double.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002FD RID: 765 RVA: 0x00008F26 File Offset: 0x00007126
		public static double? Sum<TSource>(this ParallelQuery<TSource> source, Func<TSource, double?> selector)
		{
			return source.Select(selector).Sum();
		}

		/// <summary>
		///         Параллельно вычисляет сумму для последовательности значений, получаемой в результате применения функции преобразования к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, сумму которых требуется вычислить.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Сумма проецированных значений последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма больше, чем <see cref="F:System.Decimal.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002FE RID: 766 RVA: 0x00008F34 File Offset: 0x00007134
		public static decimal Sum<TSource>(this ParallelQuery<TSource> source, Func<TSource, decimal> selector)
		{
			return source.Select(selector).Sum();
		}

		/// <summary>
		///         Параллельно вычисляет сумму для последовательности значений, получаемой в результате применения функции преобразования к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, сумму которых требуется вычислить.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Сумма проецированных значений последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма больше, чем <see cref="F:System.Decimal.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x060002FF RID: 767 RVA: 0x00008F42 File Offset: 0x00007142
		public static decimal? Sum<TSource>(this ParallelQuery<TSource> source, Func<TSource, decimal?> selector)
		{
			return source.Select(selector).Sum();
		}

		/// <summary>
		///         Возвращает минимальное значение, которое содержится в параллельной последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется минимальное значение.
		///         </param>
		/// <returns>
		///         Минимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов и <paramref name="TSource" /> является типом значения, не допускающие значения NULL.
		///           </exception>
		// Token: 0x06000300 RID: 768 RVA: 0x00008F50 File Offset: 0x00007150
		public static int Min(this ParallelQuery<int> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new IntMinMaxAggregationOperator(source, -1).Aggregate();
		}

		/// <summary>
		///         Возвращает минимальное значение, которое содержится в параллельной последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется минимальное значение.
		///         </param>
		/// <returns>
		///         Минимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x06000301 RID: 769 RVA: 0x00008F6C File Offset: 0x0000716C
		public static int? Min(this ParallelQuery<int?> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new NullableIntMinMaxAggregationOperator(source, -1).Aggregate();
		}

		/// <summary>
		///         Возвращает минимальное значение, которое содержится в параллельной последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется минимальное значение.
		///         </param>
		/// <returns>
		///         Минимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов и <paramref name="TSource" /> является типом значения, не допускающие значения NULL.
		///           </exception>
		// Token: 0x06000302 RID: 770 RVA: 0x00008F88 File Offset: 0x00007188
		public static long Min(this ParallelQuery<long> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new LongMinMaxAggregationOperator(source, -1).Aggregate();
		}

		/// <summary>
		///         Возвращает минимальное значение, которое содержится в параллельной последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется минимальное значение.
		///         </param>
		/// <returns>
		///         Минимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x06000303 RID: 771 RVA: 0x00008FA4 File Offset: 0x000071A4
		public static long? Min(this ParallelQuery<long?> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new NullableLongMinMaxAggregationOperator(source, -1).Aggregate();
		}

		/// <summary>
		///         Возвращает минимальное значение, которое содержится в параллельной последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется минимальное значение.
		///         </param>
		/// <returns>
		///         Минимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов и <paramref name="TSource" /> является типом значения, не допускающие значения NULL.
		///           </exception>
		// Token: 0x06000304 RID: 772 RVA: 0x00008FC0 File Offset: 0x000071C0
		public static float Min(this ParallelQuery<float> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new FloatMinMaxAggregationOperator(source, -1).Aggregate();
		}

		/// <summary>
		///         Возвращает минимальное значение, которое содержится в параллельной последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется минимальное значение.
		///         </param>
		/// <returns>
		///         Минимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x06000305 RID: 773 RVA: 0x00008FDC File Offset: 0x000071DC
		public static float? Min(this ParallelQuery<float?> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new NullableFloatMinMaxAggregationOperator(source, -1).Aggregate();
		}

		/// <summary>
		///         Возвращает минимальное значение, которое содержится в параллельной последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется минимальное значение.
		///         </param>
		/// <returns>
		///         Минимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов и <paramref name="TSource" /> является типом значения, не допускающие значения NULL.
		///           </exception>
		// Token: 0x06000306 RID: 774 RVA: 0x00008FF8 File Offset: 0x000071F8
		public static double Min(this ParallelQuery<double> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new DoubleMinMaxAggregationOperator(source, -1).Aggregate();
		}

		/// <summary>
		///         Возвращает минимальное значение, которое содержится в параллельной последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется минимальное значение.
		///         </param>
		/// <returns>
		///         Минимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x06000307 RID: 775 RVA: 0x00009014 File Offset: 0x00007214
		public static double? Min(this ParallelQuery<double?> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new NullableDoubleMinMaxAggregationOperator(source, -1).Aggregate();
		}

		/// <summary>
		///         Возвращает минимальное значение, которое содержится в параллельной последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется минимальное значение.
		///         </param>
		/// <returns>
		///         Минимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов и <paramref name="TSource" /> является типом значения, не допускающие значения NULL.
		///           </exception>
		// Token: 0x06000308 RID: 776 RVA: 0x00009030 File Offset: 0x00007230
		public static decimal Min(this ParallelQuery<decimal> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new DecimalMinMaxAggregationOperator(source, -1).Aggregate();
		}

		/// <summary>
		///         Возвращает минимальное значение, которое содержится в параллельной последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется минимальное значение.
		///         </param>
		/// <returns>
		///         Минимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x06000309 RID: 777 RVA: 0x0000904C File Offset: 0x0000724C
		public static decimal? Min(this ParallelQuery<decimal?> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new NullableDecimalMinMaxAggregationOperator(source, -1).Aggregate();
		}

		/// <summary>
		///         Возвращает минимальное значение, которое содержится в параллельной последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется минимальное значение.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Минимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов и <paramref name="TSource" /> является типом значения, не допускающие значения NULL.
		///           </exception>
		// Token: 0x0600030A RID: 778 RVA: 0x00009068 File Offset: 0x00007268
		public static TSource Min<TSource>(this ParallelQuery<TSource> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return AggregationMinMaxHelpers<TSource>.ReduceMin(source);
		}

		/// <summary>
		///         Параллельно вызывает функцию преобразования для каждого элемента последовательности и возвращает минимальное значение.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется минимальное значение.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Минимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов и <paramref name="TSource" /> является типом значения, не допускающие значения NULL.
		///           </exception>
		// Token: 0x0600030B RID: 779 RVA: 0x0000907E File Offset: 0x0000727E
		public static int Min<TSource>(this ParallelQuery<TSource> source, Func<TSource, int> selector)
		{
			return source.Select(selector).Min<int>();
		}

		/// <summary>
		///         Параллельно вызывает функцию преобразования для каждого элемента последовательности и возвращает минимальное значение.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется минимальное значение.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Минимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x0600030C RID: 780 RVA: 0x0000908C File Offset: 0x0000728C
		public static int? Min<TSource>(this ParallelQuery<TSource> source, Func<TSource, int?> selector)
		{
			return source.Select(selector).Min<int?>();
		}

		/// <summary>
		///         Параллельно вызывает функцию преобразования для каждого элемента последовательности и возвращает минимальное значение.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется минимальное значение.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Минимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов и <paramref name="TSource" /> является типом значения, не допускающие значения NULL.
		///           </exception>
		// Token: 0x0600030D RID: 781 RVA: 0x0000909A File Offset: 0x0000729A
		public static long Min<TSource>(this ParallelQuery<TSource> source, Func<TSource, long> selector)
		{
			return source.Select(selector).Min<long>();
		}

		/// <summary>
		///         Параллельно вызывает функцию преобразования для каждого элемента последовательности и возвращает минимальное значение.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется минимальное значение.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Минимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x0600030E RID: 782 RVA: 0x000090A8 File Offset: 0x000072A8
		public static long? Min<TSource>(this ParallelQuery<TSource> source, Func<TSource, long?> selector)
		{
			return source.Select(selector).Min<long?>();
		}

		/// <summary>
		///         Параллельно вызывает функцию преобразования для каждого элемента последовательности и возвращает минимальное значение.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется минимальное значение.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Минимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов и <paramref name="TSource" /> является типом значения, не допускающие значения NULL.
		///           </exception>
		// Token: 0x0600030F RID: 783 RVA: 0x000090B6 File Offset: 0x000072B6
		public static float Min<TSource>(this ParallelQuery<TSource> source, Func<TSource, float> selector)
		{
			return source.Select(selector).Min<float>();
		}

		/// <summary>
		///         Параллельно вызывает функцию преобразования для каждого элемента последовательности и возвращает минимальное значение.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется минимальное значение.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Минимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x06000310 RID: 784 RVA: 0x000090C4 File Offset: 0x000072C4
		public static float? Min<TSource>(this ParallelQuery<TSource> source, Func<TSource, float?> selector)
		{
			return source.Select(selector).Min<float?>();
		}

		/// <summary>
		///         Параллельно вызывает функцию преобразования для каждого элемента последовательности и возвращает минимальное значение.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется минимальное значение.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Минимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов и <paramref name="TSource" /> является типом значения, не допускающие значения NULL.
		///           </exception>
		// Token: 0x06000311 RID: 785 RVA: 0x000090D2 File Offset: 0x000072D2
		public static double Min<TSource>(this ParallelQuery<TSource> source, Func<TSource, double> selector)
		{
			return source.Select(selector).Min<double>();
		}

		/// <summary>
		///         Параллельно вызывает функцию преобразования для каждого элемента последовательности и возвращает минимальное значение.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется минимальное значение.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Минимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x06000312 RID: 786 RVA: 0x000090E0 File Offset: 0x000072E0
		public static double? Min<TSource>(this ParallelQuery<TSource> source, Func<TSource, double?> selector)
		{
			return source.Select(selector).Min<double?>();
		}

		/// <summary>
		///         Параллельно вызывает функцию преобразования для каждого элемента последовательности и возвращает минимальное значение.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется минимальное значение.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Минимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов и <paramref name="TSource" /> является типом значения, не допускающие значения NULL.
		///           </exception>
		// Token: 0x06000313 RID: 787 RVA: 0x000090EE File Offset: 0x000072EE
		public static decimal Min<TSource>(this ParallelQuery<TSource> source, Func<TSource, decimal> selector)
		{
			return source.Select(selector).Min<decimal>();
		}

		/// <summary>
		///         Параллельно вызывает функцию преобразования для каждого элемента последовательности и возвращает минимальное значение.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется минимальное значение.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Минимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x06000314 RID: 788 RVA: 0x000090FC File Offset: 0x000072FC
		public static decimal? Min<TSource>(this ParallelQuery<TSource> source, Func<TSource, decimal?> selector)
		{
			return source.Select(selector).Min<decimal?>();
		}

		/// <summary>
		///         Параллельно вызывает функцию преобразования для каждого элемента последовательности и возвращает минимальное значение.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется минимальное значение.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип значения, возвращаемый <paramref name="selector" />.
		///         </typeparam>
		/// <returns>
		///         Минимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов и <paramref name="TSource" /> является типом значения, не допускающие значения NULL.
		///           </exception>
		// Token: 0x06000315 RID: 789 RVA: 0x0000910A File Offset: 0x0000730A
		public static TResult Min<TSource, TResult>(this ParallelQuery<TSource> source, Func<TSource, TResult> selector)
		{
			return source.Select(selector).Min<TResult>();
		}

		/// <summary>
		///         Возвращает максимальное значение, которое содержится в параллельно обрабатываемой последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется максимальное значение.
		///         </param>
		/// <returns>
		///         Максимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x06000316 RID: 790 RVA: 0x00009118 File Offset: 0x00007318
		public static int Max(this ParallelQuery<int> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new IntMinMaxAggregationOperator(source, 1).Aggregate();
		}

		/// <summary>
		///         Возвращает максимальное значение, которое содержится в параллельно обрабатываемой последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется максимальное значение.
		///         </param>
		/// <returns>
		///         Максимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x06000317 RID: 791 RVA: 0x00009134 File Offset: 0x00007334
		public static int? Max(this ParallelQuery<int?> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new NullableIntMinMaxAggregationOperator(source, 1).Aggregate();
		}

		/// <summary>
		///         Возвращает максимальное значение, которое содержится в параллельно обрабатываемой последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется максимальное значение.
		///         </param>
		/// <returns>
		///         Максимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x06000318 RID: 792 RVA: 0x00009150 File Offset: 0x00007350
		public static long Max(this ParallelQuery<long> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new LongMinMaxAggregationOperator(source, 1).Aggregate();
		}

		/// <summary>
		///         Возвращает максимальное значение, которое содержится в параллельно обрабатываемой последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется максимальное значение.
		///         </param>
		/// <returns>
		///         Максимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x06000319 RID: 793 RVA: 0x0000916C File Offset: 0x0000736C
		public static long? Max(this ParallelQuery<long?> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new NullableLongMinMaxAggregationOperator(source, 1).Aggregate();
		}

		/// <summary>
		///         Возвращает максимальное значение, которое содержится в параллельно обрабатываемой последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется максимальное значение.
		///         </param>
		/// <returns>
		///         Максимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x0600031A RID: 794 RVA: 0x00009188 File Offset: 0x00007388
		public static float Max(this ParallelQuery<float> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new FloatMinMaxAggregationOperator(source, 1).Aggregate();
		}

		/// <summary>
		///         Возвращает максимальное значение, которое содержится в параллельно обрабатываемой последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется максимальное значение.
		///         </param>
		/// <returns>
		///         Максимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x0600031B RID: 795 RVA: 0x000091A4 File Offset: 0x000073A4
		public static float? Max(this ParallelQuery<float?> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new NullableFloatMinMaxAggregationOperator(source, 1).Aggregate();
		}

		/// <summary>
		///         Возвращает максимальное значение, которое содержится в параллельно обрабатываемой последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется максимальное значение.
		///         </param>
		/// <returns>
		///         Максимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x0600031C RID: 796 RVA: 0x000091C0 File Offset: 0x000073C0
		public static double Max(this ParallelQuery<double> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new DoubleMinMaxAggregationOperator(source, 1).Aggregate();
		}

		/// <summary>
		///         Возвращает максимальное значение, которое содержится в параллельно обрабатываемой последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется максимальное значение.
		///         </param>
		/// <returns>
		///         Максимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x0600031D RID: 797 RVA: 0x000091DC File Offset: 0x000073DC
		public static double? Max(this ParallelQuery<double?> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new NullableDoubleMinMaxAggregationOperator(source, 1).Aggregate();
		}

		/// <summary>
		///         Возвращает максимальное значение, которое содержится в параллельно обрабатываемой последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется максимальное значение.
		///         </param>
		/// <returns>
		///         Максимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x0600031E RID: 798 RVA: 0x000091F8 File Offset: 0x000073F8
		public static decimal Max(this ParallelQuery<decimal> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new DecimalMinMaxAggregationOperator(source, 1).Aggregate();
		}

		/// <summary>
		///         Возвращает максимальное значение, которое содержится в параллельно обрабатываемой последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется максимальное значение.
		///         </param>
		/// <returns>
		///         Максимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x0600031F RID: 799 RVA: 0x00009214 File Offset: 0x00007414
		public static decimal? Max(this ParallelQuery<decimal?> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new NullableDecimalMinMaxAggregationOperator(source, 1).Aggregate();
		}

		/// <summary>
		///         Возвращает максимальное значение, которое содержится в параллельно обрабатываемой последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется максимальное значение.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов исходной последовательности.
		///         </typeparam>
		/// <returns>
		///         Максимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов и <paramref name="TSource" /> является типом значения, не допускающие значения NULL.
		///           </exception>
		// Token: 0x06000320 RID: 800 RVA: 0x00009230 File Offset: 0x00007430
		public static TSource Max<TSource>(this ParallelQuery<TSource> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return AggregationMinMaxHelpers<TSource>.ReduceMax(source);
		}

		/// <summary>
		///         Параллельно вызывает функцию преобразования для каждого элемента последовательности и возвращает максимальное значение.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется максимальное значение.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Максимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов и <paramref name="TSource" /> является типом значения, не допускающие значения NULL.
		///           </exception>
		// Token: 0x06000321 RID: 801 RVA: 0x00009246 File Offset: 0x00007446
		public static int Max<TSource>(this ParallelQuery<TSource> source, Func<TSource, int> selector)
		{
			return source.Select(selector).Max<int>();
		}

		/// <summary>
		///         Параллельно вызывает функцию преобразования для каждого элемента последовательности и возвращает максимальное значение.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется максимальное значение.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Максимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x06000322 RID: 802 RVA: 0x00009254 File Offset: 0x00007454
		public static int? Max<TSource>(this ParallelQuery<TSource> source, Func<TSource, int?> selector)
		{
			return source.Select(selector).Max<int?>();
		}

		/// <summary>
		///         Параллельно вызывает функцию преобразования для каждого элемента последовательности и возвращает максимальное значение.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется максимальное значение.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Максимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов и <paramref name="TSource" /> является типом значения, не допускающие значения NULL.
		///           </exception>
		// Token: 0x06000323 RID: 803 RVA: 0x00009262 File Offset: 0x00007462
		public static long Max<TSource>(this ParallelQuery<TSource> source, Func<TSource, long> selector)
		{
			return source.Select(selector).Max<long>();
		}

		/// <summary>
		///         Параллельно вызывает функцию преобразования для каждого элемента последовательности и возвращает максимальное значение.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется максимальное значение.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Максимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x06000324 RID: 804 RVA: 0x00009270 File Offset: 0x00007470
		public static long? Max<TSource>(this ParallelQuery<TSource> source, Func<TSource, long?> selector)
		{
			return source.Select(selector).Max<long?>();
		}

		/// <summary>
		///         Параллельно вызывает функцию преобразования для каждого элемента последовательности и возвращает максимальное значение.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется максимальное значение.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Максимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов и <paramref name="TSource" /> является типом значения, не допускающие значения NULL.
		///           </exception>
		// Token: 0x06000325 RID: 805 RVA: 0x0000927E File Offset: 0x0000747E
		public static float Max<TSource>(this ParallelQuery<TSource> source, Func<TSource, float> selector)
		{
			return source.Select(selector).Max<float>();
		}

		/// <summary>
		///         Параллельно вызывает функцию преобразования для каждого элемента последовательности и возвращает максимальное значение.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется максимальное значение.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Максимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x06000326 RID: 806 RVA: 0x0000928C File Offset: 0x0000748C
		public static float? Max<TSource>(this ParallelQuery<TSource> source, Func<TSource, float?> selector)
		{
			return source.Select(selector).Max<float?>();
		}

		/// <summary>
		///         Параллельно вызывает функцию преобразования для каждого элемента последовательности и возвращает максимальное значение.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется максимальное значение.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Максимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов и <paramref name="TSource" /> является типом значения, не допускающие значения NULL.
		///           </exception>
		// Token: 0x06000327 RID: 807 RVA: 0x0000929A File Offset: 0x0000749A
		public static double Max<TSource>(this ParallelQuery<TSource> source, Func<TSource, double> selector)
		{
			return source.Select(selector).Max<double>();
		}

		/// <summary>
		///         Параллельно вызывает функцию преобразования для каждого элемента последовательности и возвращает максимальное значение.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется максимальное значение.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Максимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x06000328 RID: 808 RVA: 0x000092A8 File Offset: 0x000074A8
		public static double? Max<TSource>(this ParallelQuery<TSource> source, Func<TSource, double?> selector)
		{
			return source.Select(selector).Max<double?>();
		}

		/// <summary>
		///         Параллельно вызывает функцию преобразования для каждого элемента последовательности и возвращает максимальное значение.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется максимальное значение.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Максимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов и <paramref name="TSource" /> является типом значения, не допускающие значения NULL.
		///           </exception>
		// Token: 0x06000329 RID: 809 RVA: 0x000092B6 File Offset: 0x000074B6
		public static decimal Max<TSource>(this ParallelQuery<TSource> source, Func<TSource, decimal> selector)
		{
			return source.Select(selector).Max<decimal>();
		}

		/// <summary>
		///         Параллельно вызывает функцию преобразования для каждого элемента последовательности и возвращает максимальное значение.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется максимальное значение.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Максимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x0600032A RID: 810 RVA: 0x000092C4 File Offset: 0x000074C4
		public static decimal? Max<TSource>(this ParallelQuery<TSource> source, Func<TSource, decimal?> selector)
		{
			return source.Select(selector).Max<decimal?>();
		}

		/// <summary>
		///         Параллельно вызывает функцию преобразования для каждого элемента последовательности и возвращает максимальное значение.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, для которой определяется максимальное значение.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TResult">
		///           Тип значения, возвращаемый <paramref name="selector" />.
		///         </typeparam>
		/// <returns>
		///         Максимальное значение в последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов и <paramref name="TSource" /> является типом значения, не допускающие значения NULL.
		///           </exception>
		// Token: 0x0600032B RID: 811 RVA: 0x000092D2 File Offset: 0x000074D2
		public static TResult Max<TSource, TResult>(this ParallelQuery<TSource> source, Func<TSource, TResult> selector)
		{
			return source.Select(selector).Max<TResult>();
		}

		/// <summary>
		///         Параллельно вычисляет среднее значение для последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, используемых для вычисления среднего.
		///         </param>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма или количество элементов в последовательности больше, чем <see cref="F:System.Int32.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x0600032C RID: 812 RVA: 0x000092E0 File Offset: 0x000074E0
		public static double Average(this ParallelQuery<int> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new IntAverageAggregationOperator(source).Aggregate();
		}

		/// <summary>
		///         Параллельно вычисляет среднее значение для последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, используемых для вычисления среднего.
		///         </param>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма или количество элементов в последовательности больше, чем <see cref="F:System.Int32.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x0600032D RID: 813 RVA: 0x000092FB File Offset: 0x000074FB
		public static double? Average(this ParallelQuery<int?> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new NullableIntAverageAggregationOperator(source).Aggregate();
		}

		/// <summary>
		///         Параллельно вычисляет среднее значение для последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, используемых для вычисления среднего.
		///         </param>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма или количество элементов в последовательности больше, чем <see cref="F:System.Int32.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x0600032E RID: 814 RVA: 0x00009316 File Offset: 0x00007516
		public static double Average(this ParallelQuery<long> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new LongAverageAggregationOperator(source).Aggregate();
		}

		/// <summary>
		///         Параллельно вычисляет среднее значение для последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, используемых для вычисления среднего.
		///         </param>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма или количество элементов в последовательности больше, чем <see cref="F:System.Int32.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x0600032F RID: 815 RVA: 0x00009331 File Offset: 0x00007531
		public static double? Average(this ParallelQuery<long?> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new NullableLongAverageAggregationOperator(source).Aggregate();
		}

		/// <summary>
		///         Параллельно вычисляет среднее значение для последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, используемых для вычисления среднего.
		///         </param>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x06000330 RID: 816 RVA: 0x0000934C File Offset: 0x0000754C
		public static float Average(this ParallelQuery<float> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new FloatAverageAggregationOperator(source).Aggregate();
		}

		/// <summary>
		///         Параллельно вычисляет среднее значение для последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, используемых для вычисления среднего.
		///         </param>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x06000331 RID: 817 RVA: 0x00009367 File Offset: 0x00007567
		public static float? Average(this ParallelQuery<float?> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new NullableFloatAverageAggregationOperator(source).Aggregate();
		}

		/// <summary>
		///         Параллельно вычисляет среднее значение для последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, используемых для вычисления среднего.
		///         </param>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x06000332 RID: 818 RVA: 0x00009382 File Offset: 0x00007582
		public static double Average(this ParallelQuery<double> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new DoubleAverageAggregationOperator(source).Aggregate();
		}

		/// <summary>
		///         Параллельно вычисляет среднее значение для последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Исходная последовательность.
		///         </param>
		/// <returns>
		///         Возвращает среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Последовательность значений, используемых для вычисления среднего. Среднее для последовательности значений.<paramref name="source" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x06000333 RID: 819 RVA: 0x0000939D File Offset: 0x0000759D
		public static double? Average(this ParallelQuery<double?> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new NullableDoubleAverageAggregationOperator(source).Aggregate();
		}

		/// <summary>
		///         Параллельно вычисляет среднее значение для последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, используемых для вычисления среднего.
		///         </param>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x06000334 RID: 820 RVA: 0x000093B8 File Offset: 0x000075B8
		public static decimal Average(this ParallelQuery<decimal> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new DecimalAverageAggregationOperator(source).Aggregate();
		}

		/// <summary>
		///         Параллельно вычисляет среднее значение для последовательности значений.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, используемых для вычисления среднего.
		///         </param>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x06000335 RID: 821 RVA: 0x000093D3 File Offset: 0x000075D3
		public static decimal? Average(this ParallelQuery<decimal?> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new NullableDecimalAverageAggregationOperator(source).Aggregate();
		}

		/// <summary>
		///         Параллельно вычисляет среднее значение для последовательности значений, получаемой в результате применения функции преобразования к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, используемых для вычисления среднего.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма или количество элементов в последовательности больше, чем <see cref="F:System.Int32.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///              (Исключение как внутреннее исключение в <see cref="T:System.AggregateException" />).
		///             <paramref name="selector" /> Функция возвращает значение больше, чем MaxValue для типа элемента.
		///           </exception>
		// Token: 0x06000336 RID: 822 RVA: 0x000093EE File Offset: 0x000075EE
		public static double Average<TSource>(this ParallelQuery<TSource> source, Func<TSource, int> selector)
		{
			return source.Select(selector).Average();
		}

		/// <summary>
		///         Параллельно вычисляет среднее значение для последовательности значений, получаемой в результате применения функции преобразования к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, используемых для вычисления среднего.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма или количество элементов в последовательности больше, чем <see cref="F:System.Int32.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///              (Исключение как внутреннее исключение в <see cref="T:System.AggregateException" />).
		///             <paramref name="selector" /> Функция возвращает значение больше, чем MaxValue для типа элемента.
		///           </exception>
		// Token: 0x06000337 RID: 823 RVA: 0x000093FC File Offset: 0x000075FC
		public static double? Average<TSource>(this ParallelQuery<TSource> source, Func<TSource, int?> selector)
		{
			return source.Select(selector).Average();
		}

		/// <summary>
		///         Параллельно вычисляет среднее значение для последовательности значений, получаемой в результате применения функции преобразования к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, используемых для вычисления среднего.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма или количество элементов в последовательности больше, чем <see cref="F:System.Int32.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///              (Исключение как внутреннее исключение в <see cref="T:System.AggregateException" />).
		///             <paramref name="selector" /> Функция возвращает значение больше, чем MaxValue для типа элемента.
		///           </exception>
		// Token: 0x06000338 RID: 824 RVA: 0x0000940A File Offset: 0x0000760A
		public static double Average<TSource>(this ParallelQuery<TSource> source, Func<TSource, long> selector)
		{
			return source.Select(selector).Average();
		}

		/// <summary>
		///         Параллельно вычисляет среднее значение для последовательности значений, получаемой в результате применения функции преобразования к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, используемых для вычисления среднего.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Сумма или количество элементов в последовательности больше, чем <see cref="F:System.Int64.MaxValue" />.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///              (Исключение как внутреннее исключение в <see cref="T:System.AggregateException" />).
		///             <paramref name="selector" /> Функция возвращает значение больше, чем MaxValue для типа элемента.
		///           </exception>
		// Token: 0x06000339 RID: 825 RVA: 0x00009418 File Offset: 0x00007618
		public static double? Average<TSource>(this ParallelQuery<TSource> source, Func<TSource, long?> selector)
		{
			return source.Select(selector).Average();
		}

		/// <summary>
		///         Параллельно вычисляет среднее значение для последовательности значений, получаемой в результате применения функции преобразования к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, используемых для вычисления среднего.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///              (Исключение как внутреннее исключение в <see cref="T:System.AggregateException" />).
		///             <paramref name="selector" /> Функция возвращает значение больше, чем MaxValue для типа элемента.
		///           </exception>
		// Token: 0x0600033A RID: 826 RVA: 0x00009426 File Offset: 0x00007626
		public static float Average<TSource>(this ParallelQuery<TSource> source, Func<TSource, float> selector)
		{
			return source.Select(selector).Average();
		}

		/// <summary>
		///         Параллельно вычисляет среднее значение для последовательности значений, получаемой в результате применения функции преобразования к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, используемых для вычисления среднего.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///              (Исключение как внутреннее исключение в <see cref="T:System.AggregateException" />).
		///             <paramref name="selector" /> Функция возвращает значение больше, чем MaxValue для типа элемента.
		///           </exception>
		// Token: 0x0600033B RID: 827 RVA: 0x00009434 File Offset: 0x00007634
		public static float? Average<TSource>(this ParallelQuery<TSource> source, Func<TSource, float?> selector)
		{
			return source.Select(selector).Average();
		}

		/// <summary>
		///         Параллельно вычисляет среднее значение для последовательности значений, получаемой в результате применения функции преобразования к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, используемых для вычисления среднего.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///              (Исключение как внутреннее исключение в <see cref="T:System.AggregateException" />).
		///             <paramref name="selector" /> Функция возвращает значение больше, чем MaxValue для типа элемента.
		///           </exception>
		// Token: 0x0600033C RID: 828 RVA: 0x00009442 File Offset: 0x00007642
		public static double Average<TSource>(this ParallelQuery<TSource> source, Func<TSource, double> selector)
		{
			return source.Select(selector).Average();
		}

		/// <summary>
		///         Параллельно вычисляет среднее значение для последовательности значений, получаемой в результате применения функции преобразования к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, используемых для вычисления среднего.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///              (Исключение как внутреннее исключение в <see cref="T:System.AggregateException" />).
		///             <paramref name="selector" /> Функция возвращает значение больше, чем MaxValue для типа элемента.
		///           </exception>
		// Token: 0x0600033D RID: 829 RVA: 0x00009450 File Offset: 0x00007650
		public static double? Average<TSource>(this ParallelQuery<TSource> source, Func<TSource, double?> selector)
		{
			return source.Select(selector).Average();
		}

		/// <summary>
		///         Параллельно вычисляет среднее значение для последовательности значений, получаемой в результате применения функции преобразования к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, используемых для вычисления среднего.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             (Исключение как внутреннее исключение в <see cref="T:System.AggregateException" />).
		///             <paramref name="selector" /> Функция возвращает значение больше, чем MaxValue для типа элемента.
		///           </exception>
		// Token: 0x0600033E RID: 830 RVA: 0x0000945E File Offset: 0x0000765E
		public static decimal Average<TSource>(this ParallelQuery<TSource> source, Func<TSource, decimal> selector)
		{
			return source.Select(selector).Average();
		}

		/// <summary>
		///         Параллельно вычисляет среднее значение для последовательности значений, получаемой в результате применения функции преобразования к каждому элементу входной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, используемых для вычисления среднего.
		///         </param>
		/// <param name="selector">
		///           Функция преобразования, применяемая к каждому элементу.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Среднее для последовательности значений.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="selector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///              (Исключение как внутреннее исключение в <see cref="T:System.AggregateException" />).
		///             <paramref name="selector" /> Функция возвращает значение больше, чем MaxValue для типа элемента.
		///           </exception>
		// Token: 0x0600033F RID: 831 RVA: 0x0000946C File Offset: 0x0000766C
		public static decimal? Average<TSource>(this ParallelQuery<TSource> source, Func<TSource, decimal?> selector)
		{
			return source.Select(selector).Average();
		}

		/// <summary>
		///         Параллельно проверяет, удовлетворяет ли условию хотя бы один элемент в последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность, к элементам которой применяется предикат.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки каждого элемента на соответствие условию.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Значение true, если хотя бы один элемент исходной последовательности проходит проверку, определяемую указанным предикатом; в противном случае — значение false.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="predicate" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000340 RID: 832 RVA: 0x0000947A File Offset: 0x0000767A
		public static bool Any<TSource>(this ParallelQuery<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			return new AnyAllSearchOperator<TSource>(source, true, predicate).Aggregate();
		}

		/// <summary>
		///         Проверяет, содержит ли параллельная последовательность какие-либо элементы.
		///       </summary>
		/// <param name="source">
		///           Последовательность, проверяемая на наличие элементов.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Значение true, если исходная последовательность содержит какие-либо элементы; в противном случае — значение false.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000341 RID: 833 RVA: 0x000094A5 File Offset: 0x000076A5
		public static bool Any<TSource>(this ParallelQuery<TSource> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return source.Any((TSource x) => true);
		}

		/// <summary>
		///         Параллельно проверяет, все ли элементы последовательности удовлетворяют условию.
		///       </summary>
		/// <param name="source">
		///           Последовательность, к элементам которой применяется предикат.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки каждого элемента на соответствие условию.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Значение true, если каждый элемент исходной последовательности проходит проверку, определяемую указанным предикатом, или если последовательность пуста; в противном случае — значение false.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="predicate" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000342 RID: 834 RVA: 0x000094DA File Offset: 0x000076DA
		public static bool All<TSource>(this ParallelQuery<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			return new AnyAllSearchOperator<TSource>(source, false, predicate).Aggregate();
		}

		/// <summary>
		///         Параллельно определяет, содержится ли указанный элемент в последовательности, используя компаратор проверки на равенство по умолчанию.
		///       </summary>
		/// <param name="source">
		///           Последовательность, в которой требуется найти данное значение.
		///         </param>
		/// <param name="value">
		///           Значение, которое требуется найти в последовательности.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Значение true, если исходная последовательность содержит элемент с указанным значением; в противном случае — значение false.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000343 RID: 835 RVA: 0x00009505 File Offset: 0x00007705
		public static bool Contains<TSource>(this ParallelQuery<TSource> source, TSource value)
		{
			return source.Contains(value, null);
		}

		/// <summary>
		///         Параллельно определяет, содержит ли последовательность указанный элемент, используя указанный <see cref="T:System.Collections.Generic.IEqualityComparer`1" />.
		///       </summary>
		/// <param name="source">
		///           Последовательность, в которой требуется найти данное значение.
		///         </param>
		/// <param name="value">
		///           Значение, которое требуется найти в последовательности.
		///         </param>
		/// <param name="comparer">
		///           Компаратор проверки на равенство, используемый для сравнения значений.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Значение true, если исходная последовательность содержит элемент с указанным значением; в противном случае — значение false.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000344 RID: 836 RVA: 0x0000950F File Offset: 0x0000770F
		public static bool Contains<TSource>(this ParallelQuery<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new ContainsSearchOperator<TSource>(source, value, comparer).Aggregate();
		}

		/// <summary>
		///         Возвращает указанное число идущих подряд элементов с начала параллельной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность, из которой требуется возвратить элементы.
		///         </param>
		/// <param name="count">
		///           Число возвращаемых элементов.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Последовательность, содержащая заданное число элементов с начала входной последовательности.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000345 RID: 837 RVA: 0x0000952C File Offset: 0x0000772C
		public static ParallelQuery<TSource> Take<TSource>(this ParallelQuery<TSource> source, int count)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (count > 0)
			{
				return new TakeOrSkipQueryOperator<TSource>(source, count, true);
			}
			return ParallelEnumerable.Empty<TSource>();
		}

		/// <summary>
		///         Возвращает цепочку элементов параллельной последовательности, удовлетворяющих указанному условию.
		///       </summary>
		/// <param name="source">
		///           Последовательность, из которой требуется возвратить элементы.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки каждого элемента на соответствие условию.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Последовательность, содержащая элементы входной последовательности до первого элемента, который не прошел проверку.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="predicate" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000346 RID: 838 RVA: 0x0000954E File Offset: 0x0000774E
		public static ParallelQuery<TSource> TakeWhile<TSource>(this ParallelQuery<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			return new TakeOrSkipWhileQueryOperator<TSource>(source, predicate, null, true);
		}

		/// <summary>
		///         Возвращает цепочку элементов параллельной последовательности, удовлетворяющих указанному условию.
		///          Индекс элемента используется в логике функции предиката.
		///       </summary>
		/// <param name="source">
		///           Последовательность, из которой требуется возвратить элементы.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки каждого элемента исходной последовательности условие; Второй параметр функции представляет индекс исходного элемента.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Последовательность, содержащая элементы входной последовательности до первого элемента, который не прошел проверку.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="predicate" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Более чем <see cref="F:System.Int32.MaxValue" /> элементы перечисляются этим запросом.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000347 RID: 839 RVA: 0x00009575 File Offset: 0x00007775
		public static ParallelQuery<TSource> TakeWhile<TSource>(this ParallelQuery<TSource> source, Func<TSource, int, bool> predicate)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			return new TakeOrSkipWhileQueryOperator<TSource>(source, null, predicate, true);
		}

		/// <summary>
		///         Пропускает заданное число элементов в параллельной последовательности и возвращает остальные элементы.
		///       </summary>
		/// <param name="source">
		///           Последовательность, из которой требуется возвратить элементы.
		///         </param>
		/// <param name="count">
		///           Число элементов, пропускаемых перед возвращением остальных элементов.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Последовательность, содержащая элементы из входной последовательности, начиная с указанного индекса.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Количество больше чем <see cref="F:System.Int32.MaxValue" />
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000348 RID: 840 RVA: 0x0000959C File Offset: 0x0000779C
		public static ParallelQuery<TSource> Skip<TSource>(this ParallelQuery<TSource> source, int count)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (count <= 0)
			{
				return source;
			}
			return new TakeOrSkipQueryOperator<TSource>(source, count, false);
		}

		/// <summary>
		///         Пропускает элементы в параллельной последовательности, пока они удовлетворяют заданному условию, и затем возвращает оставшиеся элементы.
		///       </summary>
		/// <param name="source">
		///           Последовательность, из которой требуется возвратить элементы.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки каждого элемента на соответствие условию.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Последовательность, содержащая цепочку элементов входной последовательности, начиная с первого элемента, который не прошел проверку, заданную предикатом.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="predicate" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000349 RID: 841 RVA: 0x000095BA File Offset: 0x000077BA
		public static ParallelQuery<TSource> SkipWhile<TSource>(this ParallelQuery<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			return new TakeOrSkipWhileQueryOperator<TSource>(source, predicate, null, false);
		}

		/// <summary>
		///         Пропускает элементы в параллельной последовательности, пока они удовлетворяют заданному условию, и затем возвращает оставшиеся элементы.
		///          Индекс элемента используется в логике функции предиката.
		///       </summary>
		/// <param name="source">
		///           Последовательность, из которой требуется возвратить элементы.
		///         </param>
		/// <param name="predicate">
		///           Функция, применяемая к каждому исходному элементу для проверки условия; второй параметр функции представляет индекс исходного элемента.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Последовательность, содержащая цепочку элементов входной последовательности, начиная с первого элемента, который не прошел проверку, заданную предикатом.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="predicate" /> — это пустая ссылка (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с использованием маркера, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             В запросе перечислено элементов больше, чем определено в <see cref="F:System.Int32.MaxValue" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             При оценке запроса получено одно или несколько исключений.
		///           </exception>
		// Token: 0x0600034A RID: 842 RVA: 0x000095E1 File Offset: 0x000077E1
		public static ParallelQuery<TSource> SkipWhile<TSource>(this ParallelQuery<TSource> source, Func<TSource, int, bool> predicate)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			return new TakeOrSkipWhileQueryOperator<TSource>(source, null, predicate, false);
		}

		/// <summary>
		///         Сцепляет две параллельные последовательности.
		///       </summary>
		/// <param name="first">
		///           Первая из объединяемых последовательностей.
		///         </param>
		/// <param name="second">
		///           Последовательность, объединяемая с первой последовательностью.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов входных последовательностей.
		///         </typeparam>
		/// <returns>
		///         Последовательность, содержащая сцепленные элементы двух входных последовательностей.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="first" /> или <paramref name="second" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		// Token: 0x0600034B RID: 843 RVA: 0x00009608 File Offset: 0x00007808
		public static ParallelQuery<TSource> Concat<TSource>(this ParallelQuery<TSource> first, ParallelQuery<TSource> second)
		{
			if (first == null)
			{
				throw new ArgumentNullException("first");
			}
			if (second == null)
			{
				throw new ArgumentNullException("second");
			}
			return new ConcatQueryOperator<TSource>(first, second);
		}

		/// <summary>
		///         Эту перегрузку Concat вызывать не следует.
		///          Этот метод помечен как устаревший и всегда вызывает исключение <see cref="T:System.NotSupportedException" /> при вызове.
		///       </summary>
		/// <param name="first">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="second">
		///           Этот параметр не используется.
		///         </param>
		/// <typeparam name="TSource">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <returns>
		///         Эта перегрузка всегда создает исключение <see cref="T:System.NotSupportedException" />.
		///       </returns>
		/// <exception cref="T:System.NotSupportedException">
		///             Исключение, которое возникает при вызове этого метода.
		///           </exception>
		// Token: 0x0600034C RID: 844 RVA: 0x0000853D File Offset: 0x0000673D
		[Obsolete("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
		public static ParallelQuery<TSource> Concat<TSource>(this ParallelQuery<TSource> first, IEnumerable<TSource> second)
		{
			throw new NotSupportedException("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.");
		}

		/// <summary>
		///         Определяет, совпадают ли две параллельные последовательности, используя для сравнения элементов компаратор проверки на равенство по умолчанию, предназначенный для их типа.
		///       </summary>
		/// <param name="first">
		///           Последовательность для сравнения со второй последовательностью.
		///         </param>
		/// <param name="second">
		///           Последовательность, сравниваемая с первой входной последовательностью.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов входных последовательностей.
		///         </typeparam>
		/// <returns>
		///         Значение true, если у двух исходных последовательностей одинаковая длина и соответствующие элементы совпадают согласно компаратору проверки на равенство по умолчанию для этого типа элементов; в противном случае — значение false.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="first" /> или <paramref name="second" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x0600034D RID: 845 RVA: 0x0000962D File Offset: 0x0000782D
		public static bool SequenceEqual<TSource>(this ParallelQuery<TSource> first, ParallelQuery<TSource> second)
		{
			if (first == null)
			{
				throw new ArgumentNullException("first");
			}
			if (second == null)
			{
				throw new ArgumentNullException("second");
			}
			return first.SequenceEqual(second, null);
		}

		/// <summary>
		///         Эту перегрузку SequenceEqual вызывать не следует.
		///          Этот метод помечен как устаревший и всегда вызывает исключение <see cref="T:System.NotSupportedException" /> при вызове.
		///       </summary>
		/// <param name="first">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="second">
		///           Этот параметр не используется.
		///         </param>
		/// <typeparam name="TSource">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <returns>
		///         Эта перегрузка всегда создает исключение <see cref="T:System.NotSupportedException" />.
		///       </returns>
		/// <exception cref="T:System.NotSupportedException">
		///             Возникает каждый раз при вызове этого метода.
		///           </exception>
		// Token: 0x0600034E RID: 846 RVA: 0x0000853D File Offset: 0x0000673D
		[Obsolete("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
		public static bool SequenceEqual<TSource>(this ParallelQuery<TSource> first, IEnumerable<TSource> second)
		{
			throw new NotSupportedException("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.");
		}

		/// <summary>
		///         Определяет, совпадают ли две параллельные последовательности, используя для сравнения элементов указанный компаратор проверки на равенство IEqualityComparer{T}.
		///       </summary>
		/// <param name="first">
		///           Последовательность для сравнения с <paramref name="second" />.
		///         </param>
		/// <param name="second">
		///           Последовательность, сравниваемая с первой входной последовательностью.
		///         </param>
		/// <param name="comparer">
		///           <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> Можно использовать для сравнения элементов.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов входных последовательностей.
		///         </typeparam>
		/// <returns>
		///         Значение true, если у двух исходных последовательностей одинаковая длина и соответствующие элементы совпадают согласно компаратору проверки на равенство по умолчанию для этого типа элементов; в противном случае — значение false.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="first" /> или <paramref name="second" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x0600034F RID: 847 RVA: 0x00009654 File Offset: 0x00007854
		public static bool SequenceEqual<TSource>(this ParallelQuery<TSource> first, ParallelQuery<TSource> second, IEqualityComparer<TSource> comparer)
		{
			if (first == null)
			{
				throw new ArgumentNullException("first");
			}
			if (second == null)
			{
				throw new ArgumentNullException("second");
			}
			comparer = (comparer ?? EqualityComparer<TSource>.Default);
			ParallelQuery parallelQuery = QueryOperator<TSource>.AsQueryOperator(first);
			QueryOperator<TSource> queryOperator = QueryOperator<TSource>.AsQueryOperator(second);
			QuerySettings querySettings = parallelQuery.SpecifiedQuerySettings.Merge(queryOperator.SpecifiedQuerySettings).WithDefaults().WithPerExecutionSettings(new CancellationTokenSource(), new Shared<bool>(false));
			IEnumerator<TSource> enumerator = first.GetEnumerator();
			try
			{
				IEnumerator<TSource> enumerator2 = second.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						if (!enumerator2.MoveNext() || !comparer.Equals(enumerator.Current, enumerator2.Current))
						{
							return false;
						}
					}
					if (enumerator2.MoveNext())
					{
						return false;
					}
				}
				catch (Exception ex)
				{
					ExceptionAggregator.ThrowOCEorAggregateException(ex, querySettings.CancellationState);
				}
				finally
				{
					ParallelEnumerable.DisposeEnumerator<TSource>(enumerator2, querySettings.CancellationState);
				}
			}
			finally
			{
				ParallelEnumerable.DisposeEnumerator<TSource>(enumerator, querySettings.CancellationState);
			}
			return true;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00009768 File Offset: 0x00007968
		private static void DisposeEnumerator<TSource>(IEnumerator<TSource> e, CancellationState cancelState)
		{
			try
			{
				e.Dispose();
			}
			catch (Exception ex)
			{
				ExceptionAggregator.ThrowOCEorAggregateException(ex, cancelState);
			}
		}

		/// <summary>
		///         Эту перегрузку SequenceEqual вызывать не следует.
		///          Этот метод помечен как устаревший и всегда вызывает исключение <see cref="T:System.NotSupportedException" /> при вызове.
		///       </summary>
		/// <param name="first">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="second">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="comparer">
		///           Этот параметр не используется.
		///         </param>
		/// <typeparam name="TSource">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <returns>
		///         Эта перегрузка всегда создает исключение <see cref="T:System.NotSupportedException" />.
		///       </returns>
		/// <exception cref="T:System.NotSupportedException">
		///             Возникает каждый раз при вызове этого метода.
		///           </exception>
		// Token: 0x06000351 RID: 849 RVA: 0x0000853D File Offset: 0x0000673D
		[Obsolete("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
		public static bool SequenceEqual<TSource>(this ParallelQuery<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			throw new NotSupportedException("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.");
		}

		/// <summary>
		///         Возвращает различающиеся элементы параллельной последовательности, используя для сравнения значений компаратор проверки на равенство по умолчанию.
		///       </summary>
		/// <param name="source">
		///           Последовательность, из которой требуется удалить дубликаты элементов.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Последовательность, содержащая различающиеся элементы из исходной последовательности.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000352 RID: 850 RVA: 0x00009798 File Offset: 0x00007998
		public static ParallelQuery<TSource> Distinct<TSource>(this ParallelQuery<TSource> source)
		{
			return source.Distinct(null);
		}

		/// <summary>
		///         Возвращает различающиеся элементы параллельной последовательности, используя для сравнения значений указанный компаратор <see cref="T:System.Collections.Generic.IEqualityComparer`1" />.
		///       </summary>
		/// <param name="source">
		///           Последовательность, из которой требуется удалить дубликаты элементов.
		///         </param>
		/// <param name="comparer">
		///           Компаратор <see cref="T:System.Collections.Generic.IEqualityComparer`1" />, используемый для сравнения значений.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Последовательность, содержащая различающиеся элементы из исходной последовательности.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             При оценке запроса получено одно или несколько исключений.
		///           </exception>
		// Token: 0x06000353 RID: 851 RVA: 0x000097A1 File Offset: 0x000079A1
		public static ParallelQuery<TSource> Distinct<TSource>(this ParallelQuery<TSource> source, IEqualityComparer<TSource> comparer)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new DistinctQueryOperator<TSource>(source, comparer);
		}

		/// <summary>
		///         Находит объединение множеств, представленных двумя параллельными последовательностями, используя компаратор проверки на равенство по умолчанию.
		///       </summary>
		/// <param name="first">
		///           Последовательность, различающиеся элементы которой образуют первое множество для объединения.
		///         </param>
		/// <param name="second">
		///           Последовательность, различающиеся элементы которой образуют второе множество для объединения.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов входных последовательностей.
		///         </typeparam>
		/// <returns>
		///         Последовательность, которая содержит элементы, имеющиеся в обеих входных последовательностях, кроме дубликатов.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="first" /> или <paramref name="second" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000354 RID: 852 RVA: 0x000097B8 File Offset: 0x000079B8
		public static ParallelQuery<TSource> Union<TSource>(this ParallelQuery<TSource> first, ParallelQuery<TSource> second)
		{
			return first.Union(second, null);
		}

		/// <summary>
		///         Эту перегрузку Union вызывать не следует.
		///          Этот метод помечен как устаревший и всегда вызывает исключение <see cref="T:System.NotSupportedException" /> при вызове.
		///       </summary>
		/// <param name="first">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="second">
		///           Этот параметр не используется.
		///         </param>
		/// <typeparam name="TSource">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <returns>
		///         Эта перегрузка всегда создает исключение <see cref="T:System.NotSupportedException" />.
		///       </returns>
		/// <exception cref="T:System.NotSupportedException">
		///             Исключение, которое возникает при вызове этого метода.
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000355 RID: 853 RVA: 0x0000853D File Offset: 0x0000673D
		[Obsolete("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
		public static ParallelQuery<TSource> Union<TSource>(this ParallelQuery<TSource> first, IEnumerable<TSource> second)
		{
			throw new NotSupportedException("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.");
		}

		/// <summary>
		///         Находит объединение множеств, представленных двумя параллельными последовательностями, используя указанный компаратор IEqualityComparer{T}.
		///       </summary>
		/// <param name="first">
		///           Последовательность, различающиеся элементы которой образуют первое множество для объединения.
		///         </param>
		/// <param name="second">
		///           Последовательность, различающиеся элементы которой образуют второе множество для объединения.
		///         </param>
		/// <param name="comparer">
		///           <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> Для сравнения значений.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов входных последовательностей.
		///         </typeparam>
		/// <returns>
		///         Последовательность, которая содержит элементы, имеющиеся в обеих входных последовательностях, кроме дубликатов.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="first" /> или <paramref name="second" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000356 RID: 854 RVA: 0x000097C2 File Offset: 0x000079C2
		public static ParallelQuery<TSource> Union<TSource>(this ParallelQuery<TSource> first, ParallelQuery<TSource> second, IEqualityComparer<TSource> comparer)
		{
			if (first == null)
			{
				throw new ArgumentNullException("first");
			}
			if (second == null)
			{
				throw new ArgumentNullException("second");
			}
			return new UnionQueryOperator<TSource>(first, second, comparer);
		}

		/// <summary>
		///         Эту перегрузку Union вызывать не следует.
		///          Этот метод помечен как устаревший и всегда вызывает исключение <see cref="T:System.NotSupportedException" /> при вызове.
		///       </summary>
		/// <param name="first">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="second">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="comparer">
		///           Этот параметр не используется.
		///         </param>
		/// <typeparam name="TSource">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <returns>
		///         Эта перегрузка всегда создает исключение <see cref="T:System.NotSupportedException" />.
		///       </returns>
		/// <exception cref="T:System.NotSupportedException">
		///             Исключение, которое возникает при вызове этого метода.
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000357 RID: 855 RVA: 0x0000853D File Offset: 0x0000673D
		[Obsolete("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
		public static ParallelQuery<TSource> Union<TSource>(this ParallelQuery<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			throw new NotSupportedException("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.");
		}

		/// <summary>
		///         Находит пересечение множеств, представленных двумя параллельными последовательностями, используя для сравнения значений компаратор проверки на равенство по умолчанию.
		///       </summary>
		/// <param name="first">
		///           Последовательность, различающиеся элементы которой, входящие также в <paramref name="second" /> будут возвращены.
		///         </param>
		/// <param name="second">
		///           Последовательность, из которой возвращаются различающиеся элементы, входящие также в первую последовательность.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов входных последовательностей.
		///         </typeparam>
		/// <returns>
		///         Последовательность элементов, представляющая собой пересечение двух заданных последовательностей как множеств.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="action" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000358 RID: 856 RVA: 0x000097E8 File Offset: 0x000079E8
		public static ParallelQuery<TSource> Intersect<TSource>(this ParallelQuery<TSource> first, ParallelQuery<TSource> second)
		{
			return first.Intersect(second, null);
		}

		/// <summary>
		///         Эту перегрузку Intersect вызывать не следует.
		///          Этот метод помечен как устаревший и всегда вызывает исключение <see cref="T:System.NotSupportedException" /> при вызове.
		///       </summary>
		/// <param name="first">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="second">
		///           Этот параметр не используется.
		///         </param>
		/// <typeparam name="TSource">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <returns>
		///         Эта перегрузка всегда создает исключение <see cref="T:System.NotSupportedException" />.
		///       </returns>
		/// <exception cref="T:System.NotSupportedException">
		///             Исключение, которое возникает при вызове этого метода.
		///           </exception>
		// Token: 0x06000359 RID: 857 RVA: 0x0000853D File Offset: 0x0000673D
		[Obsolete("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
		public static ParallelQuery<TSource> Intersect<TSource>(this ParallelQuery<TSource> first, IEnumerable<TSource> second)
		{
			throw new NotSupportedException("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.");
		}

		/// <summary>
		///         Находит пересечение множеств, представленных двумя параллельными последовательностями, используя для сравнения значений указанный компаратор IEqualityComparer{T}.
		///       </summary>
		/// <param name="first">
		///           Последовательность, различающиеся элементы которой, входящие также в <paramref name="second" /> будут возвращены.
		///         </param>
		/// <param name="second">
		///           Последовательность, из которой возвращаются различающиеся элементы, входящие также в первую последовательность.
		///         </param>
		/// <param name="comparer">
		///           <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> Для сравнения значений.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов входных последовательностей.
		///         </typeparam>
		/// <returns>
		///         Последовательность элементов, представляющая собой пересечение двух заданных последовательностей как множеств.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="action" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x0600035A RID: 858 RVA: 0x000097F2 File Offset: 0x000079F2
		public static ParallelQuery<TSource> Intersect<TSource>(this ParallelQuery<TSource> first, ParallelQuery<TSource> second, IEqualityComparer<TSource> comparer)
		{
			if (first == null)
			{
				throw new ArgumentNullException("first");
			}
			if (second == null)
			{
				throw new ArgumentNullException("second");
			}
			return new IntersectQueryOperator<TSource>(first, second, comparer);
		}

		/// <summary>
		///         Эту перегрузку Intersect вызывать не следует.
		///          Этот метод помечен как устаревший и всегда вызывает исключение <see cref="T:System.NotSupportedException" /> при вызове.
		///       </summary>
		/// <param name="first">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="second">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="comparer">
		///           Этот параметр не используется.
		///         </param>
		/// <typeparam name="TSource">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <returns>
		///         Эта перегрузка всегда создает исключение <see cref="T:System.NotSupportedException" />.
		///       </returns>
		/// <exception cref="T:System.NotSupportedException">
		///             Исключение, которое возникает при вызове этого метода.
		///           </exception>
		// Token: 0x0600035B RID: 859 RVA: 0x0000853D File Offset: 0x0000673D
		[Obsolete("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
		public static ParallelQuery<TSource> Intersect<TSource>(this ParallelQuery<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			throw new NotSupportedException("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.");
		}

		/// <summary>
		///         Находит разность множеств, представленных двумя параллельными последовательностями, используя для сравнения значений компаратор проверки на равенство по умолчанию.
		///       </summary>
		/// <param name="first">
		///           Последовательность, элементы которой, отсутствующие в <paramref name="second" /> будут возвращены.
		///         </param>
		/// <param name="second">
		///           Последовательность, элементы которой, входящие также в первую последовательность, должны быть исключены из возвращаемой последовательности.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов входных последовательностей.
		///         </typeparam>
		/// <returns>
		///         Последовательность, представляющая собой разность двух последовательностей как множеств.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="first" /> или <paramref name="second" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x0600035C RID: 860 RVA: 0x00009818 File Offset: 0x00007A18
		public static ParallelQuery<TSource> Except<TSource>(this ParallelQuery<TSource> first, ParallelQuery<TSource> second)
		{
			return first.Except(second, null);
		}

		/// <summary>
		///         Эту перегрузку Except вызывать не следует.
		///          Этот метод помечен как устаревший и всегда вызывает исключение <see cref="T:System.NotSupportedException" /> при вызове.
		///       </summary>
		/// <param name="first">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="second">
		///           Этот параметр не используется.
		///         </param>
		/// <typeparam name="TSource">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <returns>
		///         Эта перегрузка всегда создает исключение <see cref="T:System.NotSupportedException" />.
		///       </returns>
		/// <exception cref="T:System.NotSupportedException">
		///             Исключение, которое возникает при вызове этого метода.
		///           </exception>
		// Token: 0x0600035D RID: 861 RVA: 0x0000853D File Offset: 0x0000673D
		[Obsolete("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
		public static ParallelQuery<TSource> Except<TSource>(this ParallelQuery<TSource> first, IEnumerable<TSource> second)
		{
			throw new NotSupportedException("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.");
		}

		/// <summary>
		///         Находит разность множеств, представленных двумя параллельными последовательностями, используя указанный <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> для сравнения значений.
		///       </summary>
		/// <param name="first">
		///           Последовательность, элементы которой, отсутствующие в <paramref name="second" /> будут возвращены.
		///         </param>
		/// <param name="second">
		///           Последовательность, элементы которой, входящие также в первую последовательность, должны быть исключены из возвращаемой последовательности.
		///         </param>
		/// <param name="comparer">
		///           <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> для сравнения значений.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов входных последовательностей.
		///         </typeparam>
		/// <returns>
		///         Последовательность, представляющая собой разность двух последовательностей как множеств.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="first" /> или <paramref name="second" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x0600035E RID: 862 RVA: 0x00009822 File Offset: 0x00007A22
		public static ParallelQuery<TSource> Except<TSource>(this ParallelQuery<TSource> first, ParallelQuery<TSource> second, IEqualityComparer<TSource> comparer)
		{
			if (first == null)
			{
				throw new ArgumentNullException("first");
			}
			if (second == null)
			{
				throw new ArgumentNullException("second");
			}
			return new ExceptQueryOperator<TSource>(first, second, comparer);
		}

		/// <summary>
		///         Эту перегрузку Except вызывать не следует.
		///          Этот метод помечен как устаревший и всегда вызывает исключение <see cref="T:System.NotSupportedException" /> при вызове.
		///       </summary>
		/// <param name="first">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="second">
		///           Этот параметр не используется.
		///         </param>
		/// <param name="comparer">
		///           Этот параметр не используется.
		///         </param>
		/// <typeparam name="TSource">
		///           Этот параметр типа не используется.
		///         </typeparam>
		/// <returns>
		///         Эта перегрузка всегда создает исключение <see cref="T:System.NotSupportedException" />.
		///       </returns>
		/// <exception cref="T:System.NotSupportedException">
		///             Исключение, которое возникает при вызове этого метода.
		///           </exception>
		// Token: 0x0600035F RID: 863 RVA: 0x0000853D File Offset: 0x0000673D
		[Obsolete("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.")]
		public static ParallelQuery<TSource> Except<TSource>(this ParallelQuery<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			throw new NotSupportedException("The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.");
		}

		/// <summary>
		///         Преобразует <see cref="T:System.Linq.ParallelQuery`1" /> в <see cref="T:System.Collections.Generic.IEnumerable`1" /> для принудительного последовательного вычисления запроса.
		///       </summary>
		/// <param name="source">
		///           Последовательность, приводится к типу <see cref="T:System.Collections.Generic.IEnumerable`1" />.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Входной последовательности, типизированного как <see cref="T:System.Collections.Generic.IEnumerable`1" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		// Token: 0x06000360 RID: 864 RVA: 0x00009848 File Offset: 0x00007A48
		public static IEnumerable<TSource> AsEnumerable<TSource>(this ParallelQuery<TSource> source)
		{
			return source.AsSequential<TSource>();
		}

		/// <summary>
		///         Создает массив из <see cref="T:System.Linq.ParallelQuery`1" />.
		///       </summary>
		/// <param name="source">
		///           Последовательность, из которой создается массив.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Массив, содержащий элементы из входной последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000361 RID: 865 RVA: 0x00009850 File Offset: 0x00007A50
		public static TSource[] ToArray<TSource>(this ParallelQuery<TSource> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			QueryOperator<TSource> queryOperator = source as QueryOperator<TSource>;
			if (queryOperator != null)
			{
				return queryOperator.ExecuteAndGetResultsAsArray();
			}
			return source.ToList<TSource>().ToArray<TSource>();
		}

		/// <summary>
		///         Создает <see cref="T:System.Collections.Generic.List`1" /> из <see cref="T:System.Linq.ParallelQuery`1" />.
		///       </summary>
		/// <param name="source">
		///           Последовательность для создания <see cref="T:System.Collections.Generic.List`1" /> из.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Объект <see cref="T:System.Collections.Generic.List`1" />  содержащий элементы из входной последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000362 RID: 866 RVA: 0x00009888 File Offset: 0x00007A88
		public static List<TSource> ToList<TSource>(this ParallelQuery<TSource> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			List<TSource> list = new List<TSource>();
			QueryOperator<TSource> queryOperator = source as QueryOperator<TSource>;
			IEnumerator<TSource> enumerator;
			if (queryOperator != null)
			{
				if (queryOperator.OrdinalIndexState == OrdinalIndexState.Indexable && queryOperator.OutputOrdered)
				{
					return new List<TSource>(source.ToArray<TSource>());
				}
				enumerator = queryOperator.GetEnumerator(new ParallelMergeOptions?(ParallelMergeOptions.FullyBuffered));
			}
			else
			{
				enumerator = source.GetEnumerator();
			}
			using (enumerator)
			{
				while (enumerator.MoveNext())
				{
					TSource item = enumerator.Current;
					list.Add(item);
				}
			}
			return list;
		}

		/// <summary>
		///         Создает <see cref="T:System.Collections.Generic.Dictionary`2" /> из <see cref="T:System.Linq.ParallelQuery`1" /> в соответствии с заданной функцией селектора ключа.
		///       </summary>
		/// <param name="source">
		///           Последовательность для создания <see cref="T:System.Collections.Generic.Dictionary`2" /> из.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ из каждого элемента.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией <paramref name="keySelector" />.
		///         </typeparam>
		/// <returns>
		///         Объект <see cref="T:System.Collections.Generic.Dictionary`2" /> содержащий ключи и значения.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="keySelector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             <paramref name="keySelector" /> создает ключ, который является пустой ссылкой (Nothing в Visual Basic).
		///              - или - <paramref name="keySelector" /> создает повторяющиеся ключи для двух элементов.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000363 RID: 867 RVA: 0x0000991C File Offset: 0x00007B1C
		public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector)
		{
			return source.ToDictionary(keySelector, EqualityComparer<TKey>.Default);
		}

		/// <summary>
		///         Создает <see cref="T:System.Collections.Generic.Dictionary`2" />  из <see cref="T:System.Linq.ParallelQuery`1" /> в соответствии с указанной функцией выбора ключа функции и компаратором ключей.
		///       </summary>
		/// <param name="source">
		///           Последовательность для создания <see cref="T:System.Collections.Generic.Dictionary`2" /> из.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ из каждого элемента.
		///         </param>
		/// <param name="comparer">
		///           <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> Для сравнения ключей.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией <paramref name="keySelector" />.
		///         </typeparam>
		/// <returns>
		///         Объект <see cref="T:System.Collections.Generic.Dictionary`2" /> содержащий ключи и значения.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="keySelector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             <paramref name="keySelector" /> создает ключ, который является пустой ссылкой (Nothing в Visual Basic).
		///              - или - <paramref name="keySelector" /> создает повторяющиеся ключи для двух элементов.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000364 RID: 868 RVA: 0x0000992C File Offset: 0x00007B2C
		public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (keySelector == null)
			{
				throw new ArgumentNullException("keySelector");
			}
			Dictionary<TKey, TSource> dictionary = new Dictionary<TKey, TSource>(comparer);
			QueryOperator<TSource> queryOperator = source as QueryOperator<TSource>;
			IEnumerator<TSource> enumerator = (queryOperator == null) ? source.GetEnumerator() : queryOperator.GetEnumerator(new ParallelMergeOptions?(ParallelMergeOptions.FullyBuffered), true);
			using (enumerator)
			{
				while (enumerator.MoveNext())
				{
					TSource tsource = enumerator.Current;
					try
					{
						TKey key = keySelector(tsource);
						dictionary.Add(key, tsource);
					}
					catch (Exception ex)
					{
						throw new AggregateException(new Exception[]
						{
							ex
						});
					}
				}
			}
			return dictionary;
		}

		/// <summary>
		///         Создает <see cref="T:System.Collections.Generic.Dictionary`2" /> из <see cref="T:System.Linq.ParallelQuery`1" /> в соответствии с указанной функцией выбора ключа и функции селектора элемента.
		///       </summary>
		/// <param name="source">
		///           Последовательность для создания <see cref="T:System.Collections.Generic.Dictionary`2" /> из.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ из каждого элемента.
		///         </param>
		/// <param name="elementSelector">
		///           Функция преобразования для получения результирующего значения каждого элемента.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией <paramref name="keySelector" />.
		///         </typeparam>
		/// <typeparam name="TElement">
		///           Тип значения, возвращаемый <paramref name="elementSelector" />.
		///         </typeparam>
		/// <returns>
		///         Объект <see cref="T:System.Collections.Generic.Dictionary`2" /> содержащий значения типа <paramref name="TElement" /> выбранные из входной последовательности
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="keySelector" /> или <paramref name="elementSelector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             <paramref name="keySelector" /> создает ключ, который является пустой ссылкой (Nothing в Visual Basic).
		///              - или - <paramref name="keySelector" /> создает повторяющиеся ключи для двух элементов.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000365 RID: 869 RVA: 0x000099E4 File Offset: 0x00007BE4
		public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
		{
			return source.ToDictionary(keySelector, elementSelector, EqualityComparer<TKey>.Default);
		}

		/// <summary>
		///         Создает <see cref="T:System.Collections.Generic.Dictionary`2" /> из <see cref="T:System.Linq.ParallelQuery`1" /> в соответствии с заданной функцией селектора ключа, средства сравнения и функции выбора элементов.
		///       </summary>
		/// <param name="source">
		///           Последовательность для создания <see cref="T:System.Collections.Generic.Dictionary`2" /> из.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ из каждого элемента.
		///         </param>
		/// <param name="elementSelector">
		///           Функция преобразования для получения результирующего значения каждого элемента.
		///         </param>
		/// <param name="comparer">
		///           <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> Для сравнения ключей.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией <paramref name="keySelector" />.
		///         </typeparam>
		/// <typeparam name="TElement">
		///           Тип значения, возвращаемый <paramref name="elementSelector" />.
		///         </typeparam>
		/// <returns>
		///         Объект <see cref="T:System.Collections.Generic.Dictionary`2" /> содержащий значения типа <paramref name="TElement" /> выбранные из входной последовательности
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="keySelector" /> или <paramref name="elementSelector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             <paramref name="keySelector" /> создает ключ, который является пустой ссылкой (Nothing в Visual Basic).
		///              - или - <paramref name="keySelector" /> создает повторяющиеся ключи для двух элементов.
		///              - или - один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000366 RID: 870 RVA: 0x000099F4 File Offset: 0x00007BF4
		public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (keySelector == null)
			{
				throw new ArgumentNullException("keySelector");
			}
			if (elementSelector == null)
			{
				throw new ArgumentNullException("elementSelector");
			}
			Dictionary<TKey, TElement> dictionary = new Dictionary<TKey, TElement>(comparer);
			QueryOperator<TSource> queryOperator = source as QueryOperator<TSource>;
			IEnumerator<TSource> enumerator = (queryOperator == null) ? source.GetEnumerator() : queryOperator.GetEnumerator(new ParallelMergeOptions?(ParallelMergeOptions.FullyBuffered), true);
			using (enumerator)
			{
				while (enumerator.MoveNext())
				{
					TSource arg = enumerator.Current;
					try
					{
						dictionary.Add(keySelector(arg), elementSelector(arg));
					}
					catch (Exception ex)
					{
						throw new AggregateException(new Exception[]
						{
							ex
						});
					}
				}
			}
			return dictionary;
		}

		/// <summary>
		///         Создает <see cref="T:System.Linq.ILookup`2" /> из <see cref="T:System.Linq.ParallelQuery`1" /> в соответствии с заданной функцией селектора ключа.
		///       </summary>
		/// <param name="source">
		///           Последовательность для создания <see cref="T:System.Linq.ILookup`2" /> из.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ из каждого элемента.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией <paramref name="keySelector" />.
		///         </typeparam>
		/// <returns>
		///         Объект <see cref="T:System.Linq.ILookup`2" /> содержащий ключи и значения.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="keySelector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000367 RID: 871 RVA: 0x00009ABC File Offset: 0x00007CBC
		public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector)
		{
			return source.ToLookup(keySelector, EqualityComparer<TKey>.Default);
		}

		/// <summary>
		///         Создает <see cref="T:System.Linq.ILookup`2" /> из <see cref="T:System.Linq.ParallelQuery`1" /> в соответствии с указанной функцией выбора ключа функции и компаратором ключей.
		///       </summary>
		/// <param name="source">
		///           Последовательность для создания <see cref="T:System.Linq.ILookup`2" /> из.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ из каждого элемента.
		///         </param>
		/// <param name="comparer">
		///           <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> Для сравнения ключей.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией <paramref name="keySelector" />.
		///         </typeparam>
		/// <returns>
		///         Объект <see cref="T:System.Linq.ILookup`2" /> содержащий ключи и значения.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="keySelector" /> или является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000368 RID: 872 RVA: 0x00009ACC File Offset: 0x00007CCC
		public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (keySelector == null)
			{
				throw new ArgumentNullException("keySelector");
			}
			comparer = (comparer ?? EqualityComparer<TKey>.Default);
			ParallelQuery<IGrouping<TKey, TSource>> parallelQuery = source.GroupBy(keySelector, comparer);
			Lookup<TKey, TSource> lookup = new Lookup<TKey, TSource>(comparer);
			QueryOperator<IGrouping<TKey, TSource>> queryOperator = parallelQuery as QueryOperator<IGrouping<TKey, TSource>>;
			IEnumerator<IGrouping<TKey, TSource>> enumerator = (queryOperator == null) ? parallelQuery.GetEnumerator() : queryOperator.GetEnumerator(new ParallelMergeOptions?(ParallelMergeOptions.FullyBuffered));
			using (enumerator)
			{
				while (enumerator.MoveNext())
				{
					IGrouping<TKey, TSource> grouping = enumerator.Current;
					lookup.Add(grouping);
				}
			}
			return lookup;
		}

		/// <summary>
		///         Создает <see cref="T:System.Linq.ILookup`2" /> из <see cref="T:System.Linq.ParallelQuery`1" /> в соответствии с указанной функцией выбора ключа и функции селектора элемента.
		///       </summary>
		/// <param name="source">
		///           Последовательность для создания <see cref="T:System.Linq.ILookup`2" /> из.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ из каждого элемента.
		///         </param>
		/// <param name="elementSelector">
		///           Функция преобразования для получения результирующего значения каждого элемента.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией <paramref name="keySelector" />.
		///         </typeparam>
		/// <typeparam name="TElement">
		///           Тип значения, возвращаемый <paramref name="elementSelector" />.
		///         </typeparam>
		/// <returns>
		///         Объект <see cref="T:System.Linq.ILookup`2" /> содержащий значения типа <paramref name="TElement" /> выбранные из входной последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="keySelector" /> или <paramref name="elementSelector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000369 RID: 873 RVA: 0x00009B68 File Offset: 0x00007D68
		public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
		{
			return source.ToLookup(keySelector, elementSelector, EqualityComparer<TKey>.Default);
		}

		/// <summary>
		///         Создает <see cref="T:System.Linq.ILookup`2" /> из <see cref="T:System.Linq.ParallelQuery`1" /> в соответствии с заданной функцией селектора ключа и компаратором функции выбора элементов.
		///       </summary>
		/// <param name="source">
		///           Последовательность для создания <see cref="T:System.Linq.ILookup`2" /> из.
		///         </param>
		/// <param name="keySelector">
		///           Функция, извлекающая ключ из каждого элемента.
		///         </param>
		/// <param name="elementSelector">
		///           Функция преобразования для получения результирующего значения каждого элемента.
		///         </param>
		/// <param name="comparer">
		///           <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> Для сравнения ключей.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов последовательности <paramref name="source" />.
		///         </typeparam>
		/// <typeparam name="TKey">
		///           Тип ключа, возвращаемого функцией <paramref name="keySelector" />.
		///         </typeparam>
		/// <typeparam name="TElement">
		///           Тип значения, возвращаемый <paramref name="elementSelector" />.
		///         </typeparam>
		/// <returns>
		///         Словарь поиска Lookup&lt;(Of &lt;(TKey, TElement&gt;)&gt;), содержащий значения типа TElement, выбранные из входной последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="keySelector" /> или <paramref name="elementSelector" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x0600036A RID: 874 RVA: 0x00009B78 File Offset: 0x00007D78
		public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this ParallelQuery<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (keySelector == null)
			{
				throw new ArgumentNullException("keySelector");
			}
			if (elementSelector == null)
			{
				throw new ArgumentNullException("elementSelector");
			}
			comparer = (comparer ?? EqualityComparer<TKey>.Default);
			ParallelQuery<IGrouping<TKey, TElement>> parallelQuery = source.GroupBy(keySelector, elementSelector, comparer);
			Lookup<TKey, TElement> lookup = new Lookup<TKey, TElement>(comparer);
			QueryOperator<IGrouping<TKey, TElement>> queryOperator = parallelQuery as QueryOperator<IGrouping<TKey, TElement>>;
			IEnumerator<IGrouping<TKey, TElement>> enumerator = (queryOperator == null) ? parallelQuery.GetEnumerator() : queryOperator.GetEnumerator(new ParallelMergeOptions?(ParallelMergeOptions.FullyBuffered));
			using (enumerator)
			{
				while (enumerator.MoveNext())
				{
					IGrouping<TKey, TElement> grouping = enumerator.Current;
					lookup.Add(grouping);
				}
			}
			return lookup;
		}

		/// <summary>
		///         Изменяет порядок элементов параллельной последовательности на противоположный.
		///       </summary>
		/// <param name="source">
		///           Последовательность значений, которые следует расставить в обратном порядке.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Последовательность, элементы которой соответствуют элементам входной последовательности, но следуют в противоположном порядке.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x0600036B RID: 875 RVA: 0x00009C24 File Offset: 0x00007E24
		public static ParallelQuery<TSource> Reverse<TSource>(this ParallelQuery<TSource> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new ReverseQueryOperator<TSource>(source);
		}

		/// <summary>
		///         Выполняет фильтрацию элементов ParallelQuery по заданному типу.
		///       </summary>
		/// <param name="source">
		///           Последовательность, элементы которой следует фильтровать.
		///         </param>
		/// <typeparam name="TResult">
		///           Тип, по которому фильтруются элементы последовательности.
		///         </typeparam>
		/// <returns>
		///         Последовательность, содержащая элементы входной последовательности типа.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x0600036C RID: 876 RVA: 0x00009C3A File Offset: 0x00007E3A
		public static ParallelQuery<TResult> OfType<TResult>(this ParallelQuery source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return source.OfType<TResult>();
		}

		/// <summary>
		///         Преобразует элементы запроса ParallelQuery в заданный тип.
		///       </summary>
		/// <param name="source">
		///           Последовательность, содержащая преобразуемые элементы.
		///         </param>
		/// <typeparam name="TResult">
		///           Тип, который требуется преобразовать элементы <paramref name="source" /> для.
		///         </typeparam>
		/// <returns>
		///         Последовательность, которая содержит все элементы исходной последовательности, преобразованные в заданный тип.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.InvalidCastException">
		///             Не удалось преобразовать тип исходной последовательности для <paramref name="TResult" />.
		///           </exception>
		// Token: 0x0600036D RID: 877 RVA: 0x00009C50 File Offset: 0x00007E50
		public static ParallelQuery<TResult> Cast<TResult>(this ParallelQuery source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return source.Cast<TResult>();
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00009C68 File Offset: 0x00007E68
		private static TSource GetOneWithPossibleDefault<TSource>(QueryOperator<TSource> queryOp, bool throwIfTwo, bool defaultIfEmpty)
		{
			using (IEnumerator<TSource> enumerator = queryOp.GetEnumerator(new ParallelMergeOptions?(ParallelMergeOptions.FullyBuffered)))
			{
				if (enumerator.MoveNext())
				{
					TSource result = enumerator.Current;
					if (throwIfTwo && enumerator.MoveNext())
					{
						throw new InvalidOperationException("Sequence contains more than one matching element");
					}
					return result;
				}
			}
			if (defaultIfEmpty)
			{
				return default(TSource);
			}
			throw new InvalidOperationException("Sequence contains no elements");
		}

		/// <summary>
		///         Возвращает первый элемент параллельной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность, из которой требуется возвратить первый элемент.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Первый элемент указанной последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x0600036F RID: 879 RVA: 0x00009CE0 File Offset: 0x00007EE0
		public static TSource First<TSource>(this ParallelQuery<TSource> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			FirstQueryOperator<TSource> firstQueryOperator = new FirstQueryOperator<TSource>(source, null);
			QuerySettings querySettings = firstQueryOperator.SpecifiedQuerySettings.WithDefaults();
			if (firstQueryOperator.LimitsParallelism)
			{
				ParallelExecutionMode? executionMode = querySettings.ExecutionMode;
				ParallelExecutionMode parallelExecutionMode = ParallelExecutionMode.ForceParallelism;
				if (!(executionMode.GetValueOrDefault() == parallelExecutionMode & executionMode != null))
				{
					return ExceptionAggregator.WrapEnumerable<TSource>(CancellableEnumerable.Wrap<TSource>(firstQueryOperator.Child.AsSequentialQuery(querySettings.CancellationState.ExternalCancellationToken), querySettings.CancellationState.ExternalCancellationToken), querySettings.CancellationState).First<TSource>();
				}
			}
			return ParallelEnumerable.GetOneWithPossibleDefault<TSource>(firstQueryOperator, false, false);
		}

		/// <summary>
		///         Возвращает первый элемент параллельной последовательности, удовлетворяющий указанному условию.
		///       </summary>
		/// <param name="source">
		///           Последовательность, из которой требуется возвратить элемент.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки каждого элемента на соответствие условию.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Первый элемент последовательности, который прошел проверку, определенную указанной функцией предиката.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="predicate" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Ни один элемент в <paramref name="source" /> удовлетворяет условию предиката <paramref name="predicate" />.
		///           </exception>
		// Token: 0x06000370 RID: 880 RVA: 0x00009D7C File Offset: 0x00007F7C
		public static TSource First<TSource>(this ParallelQuery<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			FirstQueryOperator<TSource> firstQueryOperator = new FirstQueryOperator<TSource>(source, predicate);
			QuerySettings querySettings = firstQueryOperator.SpecifiedQuerySettings.WithDefaults();
			if (firstQueryOperator.LimitsParallelism)
			{
				ParallelExecutionMode? executionMode = querySettings.ExecutionMode;
				ParallelExecutionMode parallelExecutionMode = ParallelExecutionMode.ForceParallelism;
				if (!(executionMode.GetValueOrDefault() == parallelExecutionMode & executionMode != null))
				{
					return ExceptionAggregator.WrapEnumerable<TSource>(CancellableEnumerable.Wrap<TSource>(firstQueryOperator.Child.AsSequentialQuery(querySettings.CancellationState.ExternalCancellationToken), querySettings.CancellationState.ExternalCancellationToken), querySettings.CancellationState).First(ExceptionAggregator.WrapFunc<TSource, bool>(predicate, querySettings.CancellationState));
				}
			}
			return ParallelEnumerable.GetOneWithPossibleDefault<TSource>(firstQueryOperator, false, false);
		}

		/// <summary>
		///         Возвращает первый элемент параллельной последовательности или значение по умолчанию, если последовательность не содержит элементов.
		///       </summary>
		/// <param name="source">
		///           Последовательность, из которой требуется возвратить первый элемент.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Default(TSource) Если <paramref name="source" /> является пустой; в противном случае — первый элемент в <paramref name="source" />.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000371 RID: 881 RVA: 0x00009E34 File Offset: 0x00008034
		public static TSource FirstOrDefault<TSource>(this ParallelQuery<TSource> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			FirstQueryOperator<TSource> firstQueryOperator = new FirstQueryOperator<TSource>(source, null);
			QuerySettings querySettings = firstQueryOperator.SpecifiedQuerySettings.WithDefaults();
			if (firstQueryOperator.LimitsParallelism)
			{
				ParallelExecutionMode? executionMode = querySettings.ExecutionMode;
				ParallelExecutionMode parallelExecutionMode = ParallelExecutionMode.ForceParallelism;
				if (!(executionMode.GetValueOrDefault() == parallelExecutionMode & executionMode != null))
				{
					return ExceptionAggregator.WrapEnumerable<TSource>(CancellableEnumerable.Wrap<TSource>(firstQueryOperator.Child.AsSequentialQuery(querySettings.CancellationState.ExternalCancellationToken), querySettings.CancellationState.ExternalCancellationToken), querySettings.CancellationState).FirstOrDefault<TSource>();
				}
			}
			return ParallelEnumerable.GetOneWithPossibleDefault<TSource>(firstQueryOperator, false, true);
		}

		/// <summary>
		///         Возвращает первый удовлетворяющий условию элемент параллельной последовательности или значение по умолчанию, если таких элементов не найдено.
		///       </summary>
		/// <param name="source">
		///           Последовательность, из которой требуется возвратить элемент.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки каждого элемента на соответствие условию.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Default(TSource) Если <paramref name="source" /> пуст или если элемент не прошел проверку, определенную предикатом; в противном случае — первый элемент в <paramref name="source" /> прошедший проверку, заданную предикатом.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="predicate" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000372 RID: 882 RVA: 0x00009ED0 File Offset: 0x000080D0
		public static TSource FirstOrDefault<TSource>(this ParallelQuery<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			FirstQueryOperator<TSource> firstQueryOperator = new FirstQueryOperator<TSource>(source, predicate);
			QuerySettings querySettings = firstQueryOperator.SpecifiedQuerySettings.WithDefaults();
			if (firstQueryOperator.LimitsParallelism)
			{
				ParallelExecutionMode? executionMode = querySettings.ExecutionMode;
				ParallelExecutionMode parallelExecutionMode = ParallelExecutionMode.ForceParallelism;
				if (!(executionMode.GetValueOrDefault() == parallelExecutionMode & executionMode != null))
				{
					return ExceptionAggregator.WrapEnumerable<TSource>(CancellableEnumerable.Wrap<TSource>(firstQueryOperator.Child.AsSequentialQuery(querySettings.CancellationState.ExternalCancellationToken), querySettings.CancellationState.ExternalCancellationToken), querySettings.CancellationState).FirstOrDefault(ExceptionAggregator.WrapFunc<TSource, bool>(predicate, querySettings.CancellationState));
				}
			}
			return ParallelEnumerable.GetOneWithPossibleDefault<TSource>(firstQueryOperator, false, true);
		}

		/// <summary>
		///         Возвращает последний элемент параллельной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность, из которой требуется возвратить последний элемент.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Значение, находящееся в последней позиции исходной последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> не содержит элементов.
		///           </exception>
		// Token: 0x06000373 RID: 883 RVA: 0x00009F88 File Offset: 0x00008188
		public static TSource Last<TSource>(this ParallelQuery<TSource> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			LastQueryOperator<TSource> lastQueryOperator = new LastQueryOperator<TSource>(source, null);
			QuerySettings querySettings = lastQueryOperator.SpecifiedQuerySettings.WithDefaults();
			if (lastQueryOperator.LimitsParallelism)
			{
				ParallelExecutionMode? executionMode = querySettings.ExecutionMode;
				ParallelExecutionMode parallelExecutionMode = ParallelExecutionMode.ForceParallelism;
				if (!(executionMode.GetValueOrDefault() == parallelExecutionMode & executionMode != null))
				{
					return ExceptionAggregator.WrapEnumerable<TSource>(CancellableEnumerable.Wrap<TSource>(lastQueryOperator.Child.AsSequentialQuery(querySettings.CancellationState.ExternalCancellationToken), querySettings.CancellationState.ExternalCancellationToken), querySettings.CancellationState).Last<TSource>();
				}
			}
			return ParallelEnumerable.GetOneWithPossibleDefault<TSource>(lastQueryOperator, false, false);
		}

		/// <summary>
		///         Возвращает последний элемент параллельной последовательности, удовлетворяющий указанному условию.
		///       </summary>
		/// <param name="source">
		///           Последовательность, из которой требуется возвратить элемент.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки каждого элемента на соответствие условию.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Последний элемент последовательности, который прошел проверку, определенную указанной функцией предиката.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="predicate" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Ни один элемент в <paramref name="source" /> удовлетворяет условию предиката <paramref name="predicate" />.
		///           </exception>
		// Token: 0x06000374 RID: 884 RVA: 0x0000A024 File Offset: 0x00008224
		public static TSource Last<TSource>(this ParallelQuery<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			LastQueryOperator<TSource> lastQueryOperator = new LastQueryOperator<TSource>(source, predicate);
			QuerySettings querySettings = lastQueryOperator.SpecifiedQuerySettings.WithDefaults();
			if (lastQueryOperator.LimitsParallelism)
			{
				ParallelExecutionMode? executionMode = querySettings.ExecutionMode;
				ParallelExecutionMode parallelExecutionMode = ParallelExecutionMode.ForceParallelism;
				if (!(executionMode.GetValueOrDefault() == parallelExecutionMode & executionMode != null))
				{
					return ExceptionAggregator.WrapEnumerable<TSource>(CancellableEnumerable.Wrap<TSource>(lastQueryOperator.Child.AsSequentialQuery(querySettings.CancellationState.ExternalCancellationToken), querySettings.CancellationState.ExternalCancellationToken), querySettings.CancellationState).Last(ExceptionAggregator.WrapFunc<TSource, bool>(predicate, querySettings.CancellationState));
				}
			}
			return ParallelEnumerable.GetOneWithPossibleDefault<TSource>(lastQueryOperator, false, false);
		}

		/// <summary>
		///         Возвращает последний элемент параллельной последовательности или значение по умолчанию, если последовательность не содержит элементов.
		///       </summary>
		/// <param name="source">
		///           Последовательность, из которой требуется возвратить элемент.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         default(), если исходная последовательность пуста; в противном случае — последний элемент последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000375 RID: 885 RVA: 0x0000A0DC File Offset: 0x000082DC
		public static TSource LastOrDefault<TSource>(this ParallelQuery<TSource> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			LastQueryOperator<TSource> lastQueryOperator = new LastQueryOperator<TSource>(source, null);
			QuerySettings querySettings = lastQueryOperator.SpecifiedQuerySettings.WithDefaults();
			if (lastQueryOperator.LimitsParallelism)
			{
				ParallelExecutionMode? executionMode = querySettings.ExecutionMode;
				ParallelExecutionMode parallelExecutionMode = ParallelExecutionMode.ForceParallelism;
				if (!(executionMode.GetValueOrDefault() == parallelExecutionMode & executionMode != null))
				{
					return ExceptionAggregator.WrapEnumerable<TSource>(CancellableEnumerable.Wrap<TSource>(lastQueryOperator.Child.AsSequentialQuery(querySettings.CancellationState.ExternalCancellationToken), querySettings.CancellationState.ExternalCancellationToken), querySettings.CancellationState).LastOrDefault<TSource>();
				}
			}
			return ParallelEnumerable.GetOneWithPossibleDefault<TSource>(lastQueryOperator, false, true);
		}

		/// <summary>
		///         Возвращает последний элемент параллельной последовательности, удовлетворяющий указанному условию, или значение по умолчанию, если ни одного такого элемента не найдено.
		///       </summary>
		/// <param name="source">
		///           Последовательность, из которой требуется возвратить элемент.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки каждого элемента на соответствие условию.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         default(), если последовательность пуста или ни один ее элемент не прошел проверку функцией предиката; в противном случае — последний элемент, прошедший проверку функцией предиката.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="predicate" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000376 RID: 886 RVA: 0x0000A178 File Offset: 0x00008378
		public static TSource LastOrDefault<TSource>(this ParallelQuery<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			LastQueryOperator<TSource> lastQueryOperator = new LastQueryOperator<TSource>(source, predicate);
			QuerySettings querySettings = lastQueryOperator.SpecifiedQuerySettings.WithDefaults();
			if (lastQueryOperator.LimitsParallelism)
			{
				ParallelExecutionMode? executionMode = querySettings.ExecutionMode;
				ParallelExecutionMode parallelExecutionMode = ParallelExecutionMode.ForceParallelism;
				if (!(executionMode.GetValueOrDefault() == parallelExecutionMode & executionMode != null))
				{
					return ExceptionAggregator.WrapEnumerable<TSource>(CancellableEnumerable.Wrap<TSource>(lastQueryOperator.Child.AsSequentialQuery(querySettings.CancellationState.ExternalCancellationToken), querySettings.CancellationState.ExternalCancellationToken), querySettings.CancellationState).LastOrDefault(ExceptionAggregator.WrapFunc<TSource, bool>(predicate, querySettings.CancellationState));
				}
			}
			return ParallelEnumerable.GetOneWithPossibleDefault<TSource>(lastQueryOperator, false, true);
		}

		/// <summary>
		///         Возвращает единственный элемент параллельной последовательности и генерирует исключение, если число элементов последовательности отлично от 1.
		///       </summary>
		/// <param name="source">
		///           Последовательность, из которой требуется возвратить единственный элемент.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Единственный элемент входной последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Входная последовательность содержит более одного элемента.
		///              - или - входная последовательность пуста.
		///           </exception>
		// Token: 0x06000377 RID: 887 RVA: 0x0000A22F File Offset: 0x0000842F
		public static TSource Single<TSource>(this ParallelQuery<TSource> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return ParallelEnumerable.GetOneWithPossibleDefault<TSource>(new SingleQueryOperator<TSource>(source, null), true, false);
		}

		/// <summary>
		///         Возвращает единственный элемент параллельной последовательности, удовлетворяющий заданному условию, и генерирует исключение, если таких элементов больше одного.
		///       </summary>
		/// <param name="source">
		///           Последовательность, из которой требуется возвратить единственный элемент.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки элемента на соответствие условию.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Единственный элемент входной последовательности, удовлетворяющий условию.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с использованием маркера, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> или <paramref name="predicate" /> — это пустая ссылка (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             При оценке запроса получено одно или несколько исключений.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Не найдены элементы, отвечающие условию параметра <paramref name="predicate" />.
		///              -или- Несколько элементов отвечают условию параметра <paramref name="predicate" />.
		///           </exception>
		// Token: 0x06000378 RID: 888 RVA: 0x0000A24D File Offset: 0x0000844D
		public static TSource Single<TSource>(this ParallelQuery<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			return ParallelEnumerable.GetOneWithPossibleDefault<TSource>(new SingleQueryOperator<TSource>(source, predicate), true, false);
		}

		/// <summary>
		///         Возвращает единственный элемент параллельной последовательности или значение по умолчанию, если последовательность пуста; если в последовательности более одного элемента, создается исключение.
		///       </summary>
		/// <param name="source">
		///           Последовательность, из которой требуется возвратить единственный элемент.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Единственный элемент входной последовательности или default(), если в последовательности нет элементов.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x06000379 RID: 889 RVA: 0x0000A279 File Offset: 0x00008479
		public static TSource SingleOrDefault<TSource>(this ParallelQuery<TSource> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return ParallelEnumerable.GetOneWithPossibleDefault<TSource>(new SingleQueryOperator<TSource>(source, null), true, true);
		}

		/// <summary>
		///         Возвращает единственный элемент параллельной последовательности, удовлетворяющий заданному условию, или значение по умолчанию, если такого элемента не существует; если условию удовлетворяет более одного элемента, создается исключение.
		///       </summary>
		/// <param name="source">
		///           Последовательность, из которой требуется возвратить единственный элемент.
		///         </param>
		/// <param name="predicate">
		///           Функция для проверки элемента на соответствие условию.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Единственный элемент входной последовательности, удовлетворяющий условию, или default(), если такой элемент не найден.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="source" /> или <paramref name="predicate" /> является пустой ссылкой (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="source" /> пуст или возвращается несколько элементов.
		///           </exception>
		// Token: 0x0600037A RID: 890 RVA: 0x0000A297 File Offset: 0x00008497
		public static TSource SingleOrDefault<TSource>(this ParallelQuery<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			return ParallelEnumerable.GetOneWithPossibleDefault<TSource>(new SingleQueryOperator<TSource>(source, predicate), true, true);
		}

		/// <summary>
		///         Возвращает элементы указанной параллельной последовательности или одноэлементную коллекцию, содержащую значение параметра типа по умолчанию, если последовательность пуста.
		///       </summary>
		/// <param name="source">
		///           Последовательность, для которой возвращается значение по умолчанию, если она пуста.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Последовательность, содержащая default(TSource), если <paramref name="source" /> является пустой; в противном случае — <paramref name="source" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x0600037B RID: 891 RVA: 0x0000A2C4 File Offset: 0x000084C4
		public static ParallelQuery<TSource> DefaultIfEmpty<TSource>(this ParallelQuery<TSource> source)
		{
			return source.DefaultIfEmpty(default(TSource));
		}

		/// <summary>
		///         Возвращает элементы указанной параллельной последовательности или одноэлементную коллекцию, содержащую указанное значение, если последовательность пуста.
		///       </summary>
		/// <param name="source">
		///           Последовательность, для которой возвращается указанное значение, если она пуста.
		///         </param>
		/// <param name="defaultValue">
		///           Значение, возвращаемое в случае пустой последовательности.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Последовательность, содержащая defaultValue, если <paramref name="source" /> является пустой; в противном случае — <paramref name="source" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x0600037C RID: 892 RVA: 0x0000A2E0 File Offset: 0x000084E0
		public static ParallelQuery<TSource> DefaultIfEmpty<TSource>(this ParallelQuery<TSource> source, TSource defaultValue)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return new DefaultIfEmptyQueryOperator<TSource>(source, defaultValue);
		}

		/// <summary>
		///         Возвращает элемент по указанному индексу в параллельной последовательности.
		///       </summary>
		/// <param name="source">
		///           Последовательность, из которой требуется возвратить элемент.
		///         </param>
		/// <param name="index">
		///           Отсчитываемый от нуля индекс извлекаемого элемента.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         Элемент, находящийся в указанной позиции в исходной последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="index" /> — меньше 0 или больше или равно количеству элементов в <paramref name="source" />.
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x0600037D RID: 893 RVA: 0x0000A2F8 File Offset: 0x000084F8
		public static TSource ElementAt<TSource>(this ParallelQuery<TSource> source, int index)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			TSource result;
			if (new ElementAtQueryOperator<TSource>(source, index).Aggregate(out result, false))
			{
				return result;
			}
			throw new ArgumentOutOfRangeException("index");
		}

		/// <summary>
		///         Возвращает элемент по указанному индексу в параллельной последовательности или значение по умолчанию, если индекс вне допустимого диапазона.
		///       </summary>
		/// <param name="source">
		///           Последовательность, из которой требуется возвратить элемент.
		///         </param>
		/// <param name="index">
		///           Отсчитываемый от нуля индекс извлекаемого элемента.
		///         </param>
		/// <typeparam name="TSource">
		///           Тип элементов <paramref name="source" />.
		///         </typeparam>
		/// <returns>
		///         default(TSource), если индекс указывает позицию вне исходной последовательности; в противном случае — элемент, находящийся в указанной позиции в исходной последовательности.
		///       </returns>
		/// <exception cref="T:System.OperationCanceledException">
		///             Запрос отменен с маркером, переданного через <paramref name="WithCancellation" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <paramref name="source" /> является ссылкой на null (Nothing в Visual Basic).
		///           </exception>
		/// <exception cref="T:System.AggregateException">
		///             Один или несколько исключений возникло во время оценки запроса.
		///           </exception>
		// Token: 0x0600037E RID: 894 RVA: 0x0000A340 File Offset: 0x00008540
		public static TSource ElementAtOrDefault<TSource>(this ParallelQuery<TSource> source, int index)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			TSource result;
			if (index >= 0 && new ElementAtQueryOperator<TSource>(source, index).Aggregate(out result, true))
			{
				return result;
			}
			return default(TSource);
		}

		// Token: 0x040003B9 RID: 953
		private const string RIGHT_SOURCE_NOT_PARALLEL_STR = "The second data source of a binary operator must be of type System.Linq.ParallelQuery<T> rather than System.Collections.Generic.IEnumerable<T>. To fix this problem, use the AsParallel() extension method to convert the right data source to System.Linq.ParallelQuery<T>.";
	}
}
