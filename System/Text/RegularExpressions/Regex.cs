using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;

namespace System.Text.RegularExpressions
{
	/// <summary>Представляет постоянное регулярное выражение.</summary>
	// Token: 0x020001F5 RID: 501
	public class Regex : ISerializable
	{
		/// <summary>Возвращает или задает максимальное количество записей в текущей статической кэш-памяти скомпилированных регулярных выражений.</summary>
		/// <returns>Максимальное количество записей в статической кэш-памяти.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение в операции задания меньше нуля.</exception>
		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x000365B8 File Offset: 0x000347B8
		// (set) Token: 0x06000D60 RID: 3424 RVA: 0x000365C0 File Offset: 0x000347C0
		public static int CacheSize
		{
			get
			{
				return Regex.s_cacheSize;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				Dictionary<Regex.CachedCodeEntryKey, Regex.CachedCodeEntry> obj = Regex.s_cache;
				lock (obj)
				{
					Regex.s_cacheSize = value;
					while (Regex.s_cacheCount > Regex.s_cacheSize)
					{
						Regex.CachedCodeEntry cachedCodeEntry = Regex.s_cacheLast;
						if (Regex.s_cacheCount >= 10)
						{
							Regex.s_cache.Remove(cachedCodeEntry.Key);
						}
						Regex.s_cacheLast = cachedCodeEntry.Next;
						if (cachedCodeEntry.Next != null)
						{
							cachedCodeEntry.Next.Previous = null;
						}
						else
						{
							Regex.s_cacheFirst = null;
						}
						Regex.s_cacheCount--;
					}
				}
			}
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00036670 File Offset: 0x00034870
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Regex.CachedCodeEntry GetCachedCode(Regex.CachedCodeEntryKey key, bool isToAdd)
		{
			Regex.CachedCodeEntry cachedCodeEntry = Regex.s_cacheFirst;
			if (cachedCodeEntry != null && cachedCodeEntry.Key == key)
			{
				return cachedCodeEntry;
			}
			if (Regex.s_cacheSize == 0)
			{
				return null;
			}
			return this.GetCachedCodeEntryInternal(key, isToAdd);
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x000366A8 File Offset: 0x000348A8
		private Regex.CachedCodeEntry GetCachedCodeEntryInternal(Regex.CachedCodeEntryKey key, bool isToAdd)
		{
			Dictionary<Regex.CachedCodeEntryKey, Regex.CachedCodeEntry> obj = Regex.s_cache;
			Regex.CachedCodeEntry result;
			lock (obj)
			{
				Regex.CachedCodeEntry cachedCodeEntry = Regex.LookupCachedAndPromote(key);
				if (cachedCodeEntry == null && isToAdd && Regex.s_cacheSize != 0)
				{
					cachedCodeEntry = new Regex.CachedCodeEntry(key, this.capnames, this.capslist, this._code, this.caps, this.capsize, this._runnerref, this._replref);
					if (Regex.s_cacheFirst != null)
					{
						Regex.s_cacheFirst.Next = cachedCodeEntry;
						cachedCodeEntry.Previous = Regex.s_cacheFirst;
					}
					Regex.s_cacheFirst = cachedCodeEntry;
					Regex.s_cacheCount++;
					if (Regex.s_cacheCount >= 10)
					{
						if (Regex.s_cacheCount == 10)
						{
							this.FillCacheDictionary();
						}
						else
						{
							Regex.s_cache.Add(key, cachedCodeEntry);
						}
					}
					if (Regex.s_cacheLast == null)
					{
						Regex.s_cacheLast = cachedCodeEntry;
					}
					else if (Regex.s_cacheCount > Regex.s_cacheSize)
					{
						Regex.CachedCodeEntry cachedCodeEntry2 = Regex.s_cacheLast;
						if (Regex.s_cacheCount >= 10)
						{
							Regex.s_cache.Remove(cachedCodeEntry2.Key);
						}
						cachedCodeEntry2.Next.Previous = null;
						Regex.s_cacheLast = cachedCodeEntry2.Next;
						Regex.s_cacheCount--;
					}
				}
				result = cachedCodeEntry;
			}
			return result;
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x000367F4 File Offset: 0x000349F4
		private void FillCacheDictionary()
		{
			Regex.s_cache.Clear();
			for (Regex.CachedCodeEntry previous = Regex.s_cacheFirst; previous != null; previous = previous.Previous)
			{
				Regex.s_cache.Add(previous.Key, previous);
			}
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x0003682E File Offset: 0x00034A2E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryGetCacheValue(Regex.CachedCodeEntryKey key, out Regex.CachedCodeEntry entry)
		{
			if (Regex.s_cacheCount >= 10)
			{
				return Regex.s_cache.TryGetValue(key, out entry);
			}
			return Regex.TryGetCacheValueSmall(key, out entry);
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x0003684D File Offset: 0x00034A4D
		private static bool TryGetCacheValueSmall(Regex.CachedCodeEntryKey key, out Regex.CachedCodeEntry entry)
		{
			Regex.CachedCodeEntry cachedCodeEntry = Regex.s_cacheFirst;
			for (entry = ((cachedCodeEntry != null) ? cachedCodeEntry.Previous : null); entry != null; entry = entry.Previous)
			{
				if (entry.Key == key)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00036884 File Offset: 0x00034A84
		private static Regex.CachedCodeEntry LookupCachedAndPromote(Regex.CachedCodeEntryKey key)
		{
			Regex.CachedCodeEntry cachedCodeEntry = Regex.s_cacheFirst;
			if (cachedCodeEntry != null && cachedCodeEntry.Key == key)
			{
				return Regex.s_cacheFirst;
			}
			Regex.CachedCodeEntry cachedCodeEntry2;
			if (Regex.TryGetCacheValue(key, out cachedCodeEntry2))
			{
				if (Regex.s_cacheLast == cachedCodeEntry2)
				{
					Regex.s_cacheLast = cachedCodeEntry2.Next;
				}
				else
				{
					cachedCodeEntry2.Previous.Next = cachedCodeEntry2.Next;
				}
				cachedCodeEntry2.Next.Previous = cachedCodeEntry2.Previous;
				Regex.s_cacheFirst.Next = cachedCodeEntry2;
				cachedCodeEntry2.Previous = Regex.s_cacheFirst;
				cachedCodeEntry2.Next = null;
				Regex.s_cacheFirst = cachedCodeEntry2;
			}
			return cachedCodeEntry2;
		}

		/// <summary>Указывает, обнаружено ли в указанной входной строке соответствие заданному регулярному выражению.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <param name="pattern">Шаблон регулярного выражения для сопоставления.</param>
		/// <returns>Значение <see langword="true" />, если регулярное выражение обнаруживает соответствие; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Произошла ошибка анализа регулярного выражения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" /> или <paramref name="pattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D67 RID: 3431 RVA: 0x00036915 File Offset: 0x00034B15
		public static bool IsMatch(string input, string pattern)
		{
			return Regex.IsMatch(input, pattern, RegexOptions.None, Regex.s_defaultMatchTimeout);
		}

		/// <summary>Указывает, обнаружено ли в указанной входной строке соответствие заданному регулярному выражению, используя указанные параметры сопоставления.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <param name="pattern">Шаблон регулярного выражения для сопоставления.</param>
		/// <param name="options">Побитовая комбинация значений перечисления, предоставляющая параметры для сопоставления.</param>
		/// <returns>Значение <see langword="true" />, если регулярное выражение обнаруживает соответствие; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Произошла ошибка анализа регулярного выражения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" /> или <paramref name="pattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="options" /> не является допустимым значением <see cref="T:System.Text.RegularExpressions.RegexOptions" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D68 RID: 3432 RVA: 0x00036924 File Offset: 0x00034B24
		public static bool IsMatch(string input, string pattern, RegexOptions options)
		{
			return Regex.IsMatch(input, pattern, options, Regex.s_defaultMatchTimeout);
		}

		/// <summary>Указывает, обнаружено ли в указанной входной строке соответствие заданному регулярному выражению, с помощью указанных параметров сопоставления и интервала времени ожидания.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <param name="pattern">Шаблон регулярного выражения для сопоставления.</param>
		/// <param name="options">Побитовая комбинация значений перечисления, предоставляющая параметры для сопоставления.</param>
		/// <param name="matchTimeout">Интервал времени ожидания или <see cref="F:System.Text.RegularExpressions.Regex.InfiniteMatchTimeout" />, чтобы указать, что метод не должен превышать время ожидания.</param>
		/// <returns>Значение <see langword="true" />, если регулярное выражение обнаруживает соответствие; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Произошла ошибка анализа регулярного выражения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" /> или <paramref name="pattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="options" /> не является допустимым значением <see cref="T:System.Text.RegularExpressions.RegexOptions" />.  
		/// -или- 
		///  Значение параметра <paramref name="matchTimeout" /> отрицательное, равно нулю или больше, чем приблизительно 24 дня.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло.</exception>
		// Token: 0x06000D69 RID: 3433 RVA: 0x00036933 File Offset: 0x00034B33
		public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
		{
			return new Regex(pattern, options, matchTimeout, true).IsMatch(input);
		}

		/// <summary>Указывает, обнаружено ли в указанной входной строке соответствие регулярному выражению, заданному в конструкторе <see cref="T:System.Text.RegularExpressions.Regex" />.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <returns>Значение <see langword="true" />, если регулярное выражение обнаруживает соответствие; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="input" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D6A RID: 3434 RVA: 0x00036944 File Offset: 0x00034B44
		public bool IsMatch(string input)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			return this.IsMatch(input, this.UseOptionR() ? input.Length : 0);
		}

		/// <summary>Указывает, обнаружено ли в указанной входной строке соответствие (начинающееся с указанной позиции в этой строке) регулярному выражению, заданному в конструкторе <see cref="T:System.Text.RegularExpressions.Regex" />.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <param name="startat">Расположение символа, с которого необходимо начать поиск.</param>
		/// <returns>Значение <see langword="true" />, если регулярное выражение обнаруживает соответствие; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="input" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="startat" /> имеет значение меньше нуля или больше длины <paramref name="input" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D6B RID: 3435 RVA: 0x0003696C File Offset: 0x00034B6C
		public bool IsMatch(string input, int startat)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			return this.Run(true, -1, input, 0, input.Length, startat) == null;
		}

		/// <summary>Ищет в указанной входной строке первое вхождение заданного регулярного выражения.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <param name="pattern">Шаблон регулярного выражения для сопоставления.</param>
		/// <returns>Объект, содержащий сведения о совпадении.</returns>
		/// <exception cref="T:System.ArgumentException">Произошла ошибка анализа регулярного выражения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" /> или <paramref name="pattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D6C RID: 3436 RVA: 0x00036990 File Offset: 0x00034B90
		public static Match Match(string input, string pattern)
		{
			return Regex.Match(input, pattern, RegexOptions.None, Regex.s_defaultMatchTimeout);
		}

		/// <summary>Ищет во входной строке первое вхождение заданного регулярного выражения, используя указанные параметры сопоставления.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <param name="pattern">Шаблон регулярного выражения для сопоставления.</param>
		/// <param name="options">Побитовая комбинация значений перечисления, предоставляющая параметры для сопоставления.</param>
		/// <returns>Объект, содержащий сведения о совпадении.</returns>
		/// <exception cref="T:System.ArgumentException">Произошла ошибка анализа регулярного выражения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" /> или <paramref name="pattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="options" /> не является допустимой битовой комбинацией значений <see cref="T:System.Text.RegularExpressions.RegexOptions" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D6D RID: 3437 RVA: 0x0003699F File Offset: 0x00034B9F
		public static Match Match(string input, string pattern, RegexOptions options)
		{
			return Regex.Match(input, pattern, options, Regex.s_defaultMatchTimeout);
		}

		/// <summary>Ищет во входной строке первое вхождение заданного регулярного выражения, используя указанные параметры сопоставления и интервал времени ожидания.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <param name="pattern">Шаблон регулярного выражения для сопоставления.</param>
		/// <param name="options">Побитовая комбинация значений перечисления, предоставляющая параметры для сопоставления.</param>
		/// <param name="matchTimeout">Интервал времени ожидания или <see cref="F:System.Text.RegularExpressions.Regex.InfiniteMatchTimeout" />, чтобы указать, что метод не должен превышать время ожидания.</param>
		/// <returns>Объект, содержащий сведения о совпадении.</returns>
		/// <exception cref="T:System.ArgumentException">Произошла ошибка анализа регулярного выражения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" /> или <paramref name="pattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="options" /> не является допустимой битовой комбинацией значений <see cref="T:System.Text.RegularExpressions.RegexOptions" />.  
		///
		/// или - 
		/// Значение параметра <paramref name="matchTimeout" /> отрицательное, равно нулю или больше, чем приблизительно 24 дня.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D6E RID: 3438 RVA: 0x000369AE File Offset: 0x00034BAE
		public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
		{
			return new Regex(pattern, options, matchTimeout, true).Match(input);
		}

		/// <summary>Ищет в указанной входной строке первое вхождение регулярного выражения, указанного в конструкторе <see cref="T:System.Text.RegularExpressions.Regex" />.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <returns>Объект, содержащий сведения о совпадении.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="input" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D6F RID: 3439 RVA: 0x000369BF File Offset: 0x00034BBF
		public Match Match(string input)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			return this.Match(input, this.UseOptionR() ? input.Length : 0);
		}

		/// <summary>Ищет во входной строке первое вхождение регулярного выражения, начиная с указанной начальной позиции.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <param name="startat">Отсчитываемая от нуля позиция символа, с которой начинается поиск.</param>
		/// <returns>Объект, содержащий сведения о совпадении.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="input" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="startat" /> имеет значение меньше нуля или больше длины <paramref name="input" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D70 RID: 3440 RVA: 0x000369E7 File Offset: 0x00034BE7
		public Match Match(string input, int startat)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			return this.Run(false, -1, input, 0, input.Length, startat);
		}

		/// <summary>Ищет во входной строке первое вхождение регулярного выражения, начиная с указанной начальной позиции и выполняя поиск только по указанному количеству символов.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <param name="beginning">Отсчитываемая от нуля позиция символа во входной строке, определяющая самую левую позицию диапазона поиска.</param>
		/// <param name="length">Количество символов в подстроке для включения в поиск.</param>
		/// <returns>Объект, содержащий сведения о совпадении.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="input" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="beginning" /> имеет значение меньше нуля или больше длины <paramref name="input" />.  
		/// -или- 
		///  Параметр <paramref name="length" /> имеет значение меньше нуля или больше длины <paramref name="input" />.  
		///
		/// или - 
		/// <paramref name="beginning" /><see langword="+" /><paramref name="length" /><see langword="-1" /> определяет позицию, которая находится вне диапазона <paramref name="input" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D71 RID: 3441 RVA: 0x00036A08 File Offset: 0x00034C08
		public Match Match(string input, int beginning, int length)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			return this.Run(false, -1, input, beginning, length, this.UseOptionR() ? (beginning + length) : beginning);
		}

		/// <summary>Ищет в указанной входной строке все вхождения заданного регулярного выражения.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <param name="pattern">Шаблон регулярного выражения для сопоставления.</param>
		/// <returns>Коллекция объектов <see cref="T:System.Text.RegularExpressions.Match" />, найденных при поиске. Если соответствующие объекты не найдены, метод возвращает пустой объект коллекции.</returns>
		/// <exception cref="T:System.ArgumentException">Произошла ошибка анализа регулярного выражения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" /> или <paramref name="pattern" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000D72 RID: 3442 RVA: 0x00036A31 File Offset: 0x00034C31
		public static MatchCollection Matches(string input, string pattern)
		{
			return Regex.Matches(input, pattern, RegexOptions.None, Regex.s_defaultMatchTimeout);
		}

		/// <summary>Ищет в указанной входной строке все вхождения заданного регулярного выражения, используя указанные параметры сопоставления.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <param name="pattern">Шаблон регулярного выражения для сопоставления.</param>
		/// <param name="options">Побитовая комбинация значений перечисления, задающая параметры для сопоставления.</param>
		/// <returns>Коллекция объектов <see cref="T:System.Text.RegularExpressions.Match" />, найденных при поиске. Если соответствующие объекты не найдены, метод возвращает пустой объект коллекции.</returns>
		/// <exception cref="T:System.ArgumentException">Произошла ошибка анализа регулярного выражения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" /> или <paramref name="pattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="options" /> не является допустимой битовой комбинацией значений <see cref="T:System.Text.RegularExpressions.RegexOptions" />.</exception>
		// Token: 0x06000D73 RID: 3443 RVA: 0x00036A40 File Offset: 0x00034C40
		public static MatchCollection Matches(string input, string pattern, RegexOptions options)
		{
			return Regex.Matches(input, pattern, options, Regex.s_defaultMatchTimeout);
		}

		/// <summary>Ищет в указанной входной строке все вхождения заданного регулярного выражения, используя указанные параметры сопоставления и интервал времени ожидания.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <param name="pattern">Шаблон регулярного выражения для сопоставления.</param>
		/// <param name="options">Побитовая комбинация значений перечисления, задающая параметры для сопоставления.</param>
		/// <param name="matchTimeout">Интервал времени ожидания или <see cref="F:System.Text.RegularExpressions.Regex.InfiniteMatchTimeout" />, чтобы указать, что метод не должен превышать время ожидания.</param>
		/// <returns>Коллекция объектов <see cref="T:System.Text.RegularExpressions.Match" />, найденных при поиске. Если соответствующие объекты не найдены, метод возвращает пустой объект коллекции.</returns>
		/// <exception cref="T:System.ArgumentException">Произошла ошибка анализа регулярного выражения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" /> или <paramref name="pattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="options" /> не является допустимой битовой комбинацией значений <see cref="T:System.Text.RegularExpressions.RegexOptions" />.  
		///
		/// или - 
		/// Значение параметра <paramref name="matchTimeout" /> отрицательное, равно нулю или больше, чем приблизительно 24 дня.</exception>
		// Token: 0x06000D74 RID: 3444 RVA: 0x00036A4F File Offset: 0x00034C4F
		public static MatchCollection Matches(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
		{
			return new Regex(pattern, options, matchTimeout, true).Matches(input);
		}

		/// <summary>Ищет в указанной входной строке все вхождения регулярного выражения.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <returns>Коллекция объектов <see cref="T:System.Text.RegularExpressions.Match" />, найденных при поиске. Если соответствующие объекты не найдены, метод возвращает пустой объект коллекции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="input" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000D75 RID: 3445 RVA: 0x00036A60 File Offset: 0x00034C60
		public MatchCollection Matches(string input)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			return this.Matches(input, this.UseOptionR() ? input.Length : 0);
		}

		/// <summary>Ищет в указанной входной строке все вхождения регулярного выражения, начиная с указанной начальной позиции.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <param name="startat">Позиция символа во входной строке, с которой необходимо начать поиск.</param>
		/// <returns>Коллекция объектов <see cref="T:System.Text.RegularExpressions.Match" />, найденных при поиске. Если соответствующие объекты не найдены, метод возвращает пустой объект коллекции.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="input" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="startat" /> имеет значение меньше нуля или больше длины <paramref name="input" />.</exception>
		// Token: 0x06000D76 RID: 3446 RVA: 0x00036A88 File Offset: 0x00034C88
		public MatchCollection Matches(string input, int startat)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			return new MatchCollection(this, input, 0, input.Length, startat);
		}

		/// <summary>В указанной входной строке заменяет все строки, соответствующие указанному регулярному выражению, указанной строкой замены.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <param name="pattern">Шаблон регулярного выражения для сопоставления.</param>
		/// <param name="replacement">Строка замены.</param>
		/// <returns>Новая строка, идентичная входной строке, за исключением того что строка замены занимает место каждой соответствующей строки. Если для <paramref name="pattern" /> не найдено соответствия в текущем экземпляре, метод возвращает текущий экземпляр без изменений.</returns>
		/// <exception cref="T:System.ArgumentException">Произошла ошибка анализа регулярного выражения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" />, <paramref name="pattern" /> или <paramref name="replacement" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D77 RID: 3447 RVA: 0x00036AA7 File Offset: 0x00034CA7
		public static string Replace(string input, string pattern, string replacement)
		{
			return Regex.Replace(input, pattern, replacement, RegexOptions.None, Regex.s_defaultMatchTimeout);
		}

		/// <summary>В указанной входной строке заменяет все строки, соответствующие указанному регулярному выражению, указанной строкой замены. Указанные параметры изменяют операцию сопоставления.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <param name="pattern">Шаблон регулярного выражения для сопоставления.</param>
		/// <param name="replacement">Строка замены.</param>
		/// <param name="options">Побитовая комбинация значений перечисления, предоставляющая параметры для сопоставления.</param>
		/// <returns>Новая строка, идентичная входной строке, за исключением того что строка замены занимает место каждой соответствующей строки. Если для <paramref name="pattern" /> не найдено соответствия в текущем экземпляре, метод возвращает текущий экземпляр без изменений.</returns>
		/// <exception cref="T:System.ArgumentException">Произошла ошибка анализа регулярного выражения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" />, <paramref name="pattern" /> или <paramref name="replacement" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="options" /> не является допустимой битовой комбинацией значений <see cref="T:System.Text.RegularExpressions.RegexOptions" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D78 RID: 3448 RVA: 0x00036AB7 File Offset: 0x00034CB7
		public static string Replace(string input, string pattern, string replacement, RegexOptions options)
		{
			return Regex.Replace(input, pattern, replacement, options, Regex.s_defaultMatchTimeout);
		}

		/// <summary>В указанной входной строке заменяет все строки, соответствующие указанному регулярному выражению, указанной строкой замены. Дополнительные параметры определяют параметры, которые изменяют соответствующую операцию и интервал времени ожидания, если совпадение не найдено.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <param name="pattern">Шаблон регулярного выражения для сопоставления.</param>
		/// <param name="replacement">Строка замены.</param>
		/// <param name="options">Побитовая комбинация значений перечисления, предоставляющая параметры для сопоставления.</param>
		/// <param name="matchTimeout">Интервал времени ожидания или <see cref="F:System.Text.RegularExpressions.Regex.InfiniteMatchTimeout" />, чтобы указать, что метод не должен превышать время ожидания.</param>
		/// <returns>Новая строка, идентичная входной строке, за исключением того что строка замены занимает место каждой соответствующей строки. Если для <paramref name="pattern" /> не найдено соответствия в текущем экземпляре, метод возвращает текущий экземпляр без изменений.</returns>
		/// <exception cref="T:System.ArgumentException">Произошла ошибка анализа регулярного выражения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" />, <paramref name="pattern" /> или <paramref name="replacement" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="options" /> не является допустимой битовой комбинацией значений <see cref="T:System.Text.RegularExpressions.RegexOptions" />.  
		/// -или- 
		///  Значение параметра <paramref name="matchTimeout" /> отрицательное, равно нулю или больше, чем приблизительно 24 дня.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D79 RID: 3449 RVA: 0x00036AC7 File Offset: 0x00034CC7
		public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout)
		{
			return new Regex(pattern, options, matchTimeout, true).Replace(input, replacement);
		}

		/// <summary>В указанной входной строке заменяет все строки, соответствующие шаблону регулярного выражения, указанной строкой замены.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <param name="replacement">Строка замены.</param>
		/// <returns>Новая строка, идентичная входной строке, за исключением того что строка замены занимает место каждой соответствующей строки. Если в текущем экземпляре нет соответствия шаблону регулярных выражений, метод возвращает текущий экземпляр без изменений.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" /> или <paramref name="replacement" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D7A RID: 3450 RVA: 0x00036ADA File Offset: 0x00034CDA
		public string Replace(string input, string replacement)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			return this.Replace(input, replacement, -1, this.UseOptionR() ? input.Length : 0);
		}

		/// <summary>В указанной входной строке заменяет указанное максимальное количество строк, соответствующих шаблону регулярного выражения, указанной строкой замены.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <param name="replacement">Строка замены.</param>
		/// <param name="count">Максимальное количество возможных случаев замены.</param>
		/// <returns>Новая строка, идентичная входной строке, за исключением того что строка замены занимает место каждой соответствующей строки. Если в текущем экземпляре нет соответствия шаблону регулярных выражений, метод возвращает текущий экземпляр без изменений.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" /> или <paramref name="replacement" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D7B RID: 3451 RVA: 0x00036B04 File Offset: 0x00034D04
		public string Replace(string input, string replacement, int count)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			return this.Replace(input, replacement, count, this.UseOptionR() ? input.Length : 0);
		}

		/// <summary>В указанной входной подстроке заменяет указанное максимальное количество строк, соответствующих шаблону регулярного выражения, указанной строкой замены.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <param name="replacement">Строка замены.</param>
		/// <param name="count">Максимальное возможное количество случаев замены.</param>
		/// <param name="startat">Позиция символа во входной строке, с которой начинается поиск.</param>
		/// <returns>Новая строка, идентичная входной строке, за исключением того что строка замены занимает место каждой соответствующей строки. Если в текущем экземпляре нет соответствия шаблону регулярных выражений, метод возвращает текущий экземпляр без изменений.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" /> или <paramref name="replacement" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="startat" /> имеет значение меньше нуля или больше длины <paramref name="input" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D7C RID: 3452 RVA: 0x00036B30 File Offset: 0x00034D30
		public string Replace(string input, string replacement, int count, int startat)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			if (replacement == null)
			{
				throw new ArgumentNullException("replacement");
			}
			return RegexReplacement.GetOrCreate(this._replref, replacement, this.caps, this.capsize, this.capnames, this.roptions).Replace(this, input, count, startat);
		}

		/// <summary>В указанной входной строке заменяет все строки, соответствующие указанному регулярному выражению, строкой, возвращенной делегатом <see cref="T:System.Text.RegularExpressions.MatchEvaluator" />.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <param name="pattern">Шаблон регулярного выражения для сопоставления.</param>
		/// <param name="evaluator">Пользовательский метод, анализирующий каждое совпадение и возвращающий либо исходную строку с совпадениями, либо строку замены.</param>
		/// <returns>Новая строка, идентичная входной строке, за исключением того что строка замены занимает место каждой соответствующей строки. Если для <paramref name="pattern" /> не найдено соответствия в текущем экземпляре, метод возвращает текущий экземпляр без изменений.</returns>
		/// <exception cref="T:System.ArgumentException">Произошла ошибка анализа регулярного выражения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" />, <paramref name="pattern" /> или <paramref name="evaluator" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D7D RID: 3453 RVA: 0x00036B87 File Offset: 0x00034D87
		public static string Replace(string input, string pattern, MatchEvaluator evaluator)
		{
			return Regex.Replace(input, pattern, evaluator, RegexOptions.None, Regex.s_defaultMatchTimeout);
		}

		/// <summary>В указанной входной строке заменяет все строки, соответствующие указанному регулярному выражению, строкой, возвращенной делегатом <see cref="T:System.Text.RegularExpressions.MatchEvaluator" />. Указанные параметры изменяют операцию сопоставления.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <param name="pattern">Шаблон регулярного выражения для сопоставления.</param>
		/// <param name="evaluator">Пользовательский метод, анализирующий каждое совпадение и возвращающий либо исходную строку с совпадениями, либо строку замены.</param>
		/// <param name="options">Побитовая комбинация значений перечисления, предоставляющая параметры для сопоставления.</param>
		/// <returns>Новая строка, идентичная входной строке, за исключением того что строка замены занимает место каждой соответствующей строки. Если для <paramref name="pattern" /> не найдено соответствия в текущем экземпляре, метод возвращает текущий экземпляр без изменений.</returns>
		/// <exception cref="T:System.ArgumentException">Произошла ошибка анализа регулярного выражения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" />, <paramref name="pattern" /> или <paramref name="evaluator" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="options" /> не является допустимой битовой комбинацией значений <see cref="T:System.Text.RegularExpressions.RegexOptions" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D7E RID: 3454 RVA: 0x00036B97 File Offset: 0x00034D97
		public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options)
		{
			return Regex.Replace(input, pattern, evaluator, options, Regex.s_defaultMatchTimeout);
		}

		/// <summary>В указанной входной строке заменяет все подстроки, соответствующие указанному регулярному выражению, строкой, возвращенной делегатом <see cref="T:System.Text.RegularExpressions.MatchEvaluator" />. Дополнительные параметры определяют параметры, которые изменяют соответствующую операцию и интервал времени ожидания, если совпадение не найдено.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <param name="pattern">Шаблон регулярного выражения для сопоставления.</param>
		/// <param name="evaluator">Пользовательский метод, анализирующий каждое совпадение и возвращающий либо исходную строку с совпадениями, либо строку замены.</param>
		/// <param name="options">Побитовая комбинация значений перечисления, предоставляющих параметры для сопоставления.</param>
		/// <param name="matchTimeout">Интервал времени ожидания или <see cref="F:System.Text.RegularExpressions.Regex.InfiniteMatchTimeout" />, чтобы указать, что метод не должен превышать время ожидания.</param>
		/// <returns>Новая строка, идентичная входной строке, за исключением того что строка замены занимает место каждой соответствующей строки. Если для <paramref name="pattern" /> не найдено соответствия в текущем экземпляре, метод возвращает текущий экземпляр без изменений.</returns>
		/// <exception cref="T:System.ArgumentException">Произошла ошибка анализа регулярного выражения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" />, <paramref name="pattern" /> или <paramref name="evaluator" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="options" /> не является допустимой битовой комбинацией значений <see cref="T:System.Text.RegularExpressions.RegexOptions" />.  
		///
		/// или - 
		/// Значение параметра <paramref name="matchTimeout" /> отрицательное, равно нулю или больше, чем приблизительно 24 дня.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D7F RID: 3455 RVA: 0x00036BA7 File Offset: 0x00034DA7
		public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout)
		{
			return new Regex(pattern, options, matchTimeout, true).Replace(input, evaluator);
		}

		/// <summary>В указанной входной строке заменяет все строки, соответствующие указанному регулярному выражению, строкой, возвращенной делегатом <see cref="T:System.Text.RegularExpressions.MatchEvaluator" />.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <param name="evaluator">Пользовательский метод, анализирующий каждое совпадение и возвращающий либо исходную строку с совпадениями, либо строку замены.</param>
		/// <returns>Новая строка, идентичная входной строке, за исключением того что строка замены занимает место каждой соответствующей строки. Если в текущем экземпляре нет соответствия шаблону регулярных выражений, метод возвращает текущий экземпляр без изменений.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" /> или <paramref name="evaluator" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D80 RID: 3456 RVA: 0x00036BBA File Offset: 0x00034DBA
		public string Replace(string input, MatchEvaluator evaluator)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			return this.Replace(input, evaluator, -1, this.UseOptionR() ? input.Length : 0);
		}

		/// <summary>В указанной входной строке заменяется указанное максимальное количество строк, соответствующих шаблону регулярного выражения, строкой, возвращенной делегатом <see cref="T:System.Text.RegularExpressions.MatchEvaluator" />.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <param name="evaluator">Пользовательский метод, анализирующий каждое совпадение и возвращающий либо исходную строку с совпадениями, либо строку замены.</param>
		/// <param name="count">Максимальное количество возможных случаев замены.</param>
		/// <returns>Новая строка, идентичная входной строке, за исключением того что строка замены занимает место каждой соответствующей строки. Если в текущем экземпляре нет соответствия шаблону регулярных выражений, метод возвращает текущий экземпляр без изменений.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" /> или <paramref name="evaluator" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D81 RID: 3457 RVA: 0x00036BE4 File Offset: 0x00034DE4
		public string Replace(string input, MatchEvaluator evaluator, int count)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			return this.Replace(input, evaluator, count, this.UseOptionR() ? input.Length : 0);
		}

		/// <summary>В указанной входной подстроке заменяется указанное максимальное количество строк, соответствующих шаблону регулярного выражения, строкой, возвращенной делегатом <see cref="T:System.Text.RegularExpressions.MatchEvaluator" />.</summary>
		/// <param name="input">Строка для поиска соответствия.</param>
		/// <param name="evaluator">Пользовательский метод, анализирующий каждое совпадение и возвращающий либо исходную строку с совпадениями, либо строку замены.</param>
		/// <param name="count">Максимальное количество возможных случаев замены.</param>
		/// <param name="startat">Позиция символа во входной строке, с которой начинается поиск.</param>
		/// <returns>Новая строка, идентичная входной строке, за исключением того что строка замены занимает место каждой соответствующей строки. Если в текущем экземпляре нет соответствия шаблону регулярных выражений, метод возвращает текущий экземпляр без изменений.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" /> или <paramref name="evaluator" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="startat" /> имеет значение меньше нуля или больше длины <paramref name="input" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D82 RID: 3458 RVA: 0x00036C0E File Offset: 0x00034E0E
		public string Replace(string input, MatchEvaluator evaluator, int count, int startat)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			return Regex.Replace(evaluator, this, input, count, startat);
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x00036C2C File Offset: 0x00034E2C
		private static string Replace(MatchEvaluator evaluator, Regex regex, string input, int count, int startat)
		{
			if (evaluator == null)
			{
				throw new ArgumentNullException("evaluator");
			}
			if (count < -1)
			{
				throw new ArgumentOutOfRangeException("count", "Count cannot be less than -1.");
			}
			if (startat < 0 || startat > input.Length)
			{
				throw new ArgumentOutOfRangeException("startat", "Start index cannot be less than 0 or greater than input length.");
			}
			if (count == 0)
			{
				return input;
			}
			Match match = regex.Match(input, startat);
			if (!match.Success)
			{
				return input;
			}
			StringBuilder stringBuilder = StringBuilderCache.Acquire(16);
			if (!regex.RightToLeft)
			{
				int num = 0;
				do
				{
					if (match.Index != num)
					{
						stringBuilder.Append(input, num, match.Index - num);
					}
					num = match.Index + match.Length;
					stringBuilder.Append(evaluator(match));
					if (--count == 0)
					{
						break;
					}
					match = match.NextMatch();
				}
				while (match.Success);
				if (num < input.Length)
				{
					stringBuilder.Append(input, num, input.Length - num);
				}
			}
			else
			{
				List<string> list = new List<string>();
				int num2 = input.Length;
				do
				{
					if (match.Index + match.Length != num2)
					{
						list.Add(input.Substring(match.Index + match.Length, num2 - match.Index - match.Length));
					}
					num2 = match.Index;
					list.Add(evaluator(match));
					if (--count == 0)
					{
						break;
					}
					match = match.NextMatch();
				}
				while (match.Success);
				if (num2 > 0)
				{
					stringBuilder.Append(input, 0, num2);
				}
				for (int i = list.Count - 1; i >= 0; i--)
				{
					stringBuilder.Append(list[i]);
				}
			}
			return StringBuilderCache.GetStringAndRelease(stringBuilder);
		}

		/// <summary>Разделяет входную строку в массив подстрок в позициях, определенных шаблоном регулярного выражения.</summary>
		/// <param name="input">Строка для разделения.</param>
		/// <param name="pattern">Шаблон регулярного выражения для сопоставления.</param>
		/// <returns>Массив строк.</returns>
		/// <exception cref="T:System.ArgumentException">Произошла ошибка анализа регулярного выражения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" /> или <paramref name="pattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D84 RID: 3460 RVA: 0x00036DC4 File Offset: 0x00034FC4
		public static string[] Split(string input, string pattern)
		{
			return Regex.Split(input, pattern, RegexOptions.None, Regex.s_defaultMatchTimeout);
		}

		/// <summary>Разделяет входную строку в массив подстрок в позициях, определенных указанным шаблоном регулярного выражения. Указанные параметры изменяют операцию сопоставления.</summary>
		/// <param name="input">Строка для разделения.</param>
		/// <param name="pattern">Шаблон регулярного выражения для сопоставления.</param>
		/// <param name="options">Побитовая комбинация значений перечисления, предоставляющая параметры для сопоставления.</param>
		/// <returns>Массив строк.</returns>
		/// <exception cref="T:System.ArgumentException">Произошла ошибка анализа регулярного выражения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" /> или <paramref name="pattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="options" /> не является допустимой битовой комбинацией значений <see cref="T:System.Text.RegularExpressions.RegexOptions" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D85 RID: 3461 RVA: 0x00036DD3 File Offset: 0x00034FD3
		public static string[] Split(string input, string pattern, RegexOptions options)
		{
			return Regex.Split(input, pattern, options, Regex.s_defaultMatchTimeout);
		}

		/// <summary>Разделяет входную строку в массив подстрок в позициях, определенных указанным шаблоном регулярного выражения. Дополнительные параметры определяют параметры, которые изменяют соответствующую операцию и интервал времени ожидания, если совпадение не найдено.</summary>
		/// <param name="input">Строка для разделения.</param>
		/// <param name="pattern">Шаблон регулярного выражения для сопоставления.</param>
		/// <param name="options">Побитовая комбинация значений перечисления, предоставляющая параметры для сопоставления.</param>
		/// <param name="matchTimeout">Интервал времени ожидания или <see cref="F:System.Text.RegularExpressions.Regex.InfiniteMatchTimeout" />, чтобы указать, что метод не должен превышать время ожидания.</param>
		/// <returns>Массив строк.</returns>
		/// <exception cref="T:System.ArgumentException">Произошла ошибка анализа регулярного выражения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="input" /> или <paramref name="pattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="options" /> не является допустимой битовой комбинацией значений <see cref="T:System.Text.RegularExpressions.RegexOptions" />.  
		/// -или- 
		///  Значение параметра <paramref name="matchTimeout" /> отрицательное, равно нулю или больше, чем приблизительно 24 дня.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D86 RID: 3462 RVA: 0x00036DE2 File Offset: 0x00034FE2
		public static string[] Split(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
		{
			return new Regex(pattern, options, matchTimeout, true).Split(input);
		}

		/// <summary>Разделяет входную строку в массив подстрок в позициях, определенных шаблоном регулярного выражения, указанным в конструкторе <see cref="T:System.Text.RegularExpressions.Regex" />.</summary>
		/// <param name="input">Строка для разделения.</param>
		/// <returns>Массив строк.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="input" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D87 RID: 3463 RVA: 0x00036DF3 File Offset: 0x00034FF3
		public string[] Split(string input)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			return this.Split(input, 0, this.UseOptionR() ? input.Length : 0);
		}

		/// <summary>Разделяет входную строку указанное максимальное количество раз в массив подстрок в позициях, определенных регулярным выражением, указанным в конструкторе <see cref="T:System.Text.RegularExpressions.Regex" />.</summary>
		/// <param name="input">Строка для разделения.</param>
		/// <param name="count">Максимальное количество возможных случаев разделения.</param>
		/// <returns>Массив строк.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="input" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D88 RID: 3464 RVA: 0x00036E1C File Offset: 0x0003501C
		public string[] Split(string input, int count)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			return Regex.Split(this, input, count, this.UseOptionR() ? input.Length : 0);
		}

		/// <summary>Разделяет входную строку указанное максимальное количество раз в массив подстрок в позициях, определенных регулярным выражением, указанным в конструкторе <see cref="T:System.Text.RegularExpressions.Regex" />. Поиск шаблона регулярного выражения начинается с указанной позиции элемента во входной строке.</summary>
		/// <param name="input">Строка для разделения.</param>
		/// <param name="count">Максимальное количество возможных случаев разделения.</param>
		/// <param name="startat">Позиция символа во входной строке, с которой начинается поиск.</param>
		/// <returns>Массив строк.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="input" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="startat" /> имеет значение меньше нуля или больше длины <paramref name="input" />.</exception>
		/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">Время ожидания истекло. Дополнительные сведения о времени ожидания см. в разделе "Примечания".</exception>
		// Token: 0x06000D89 RID: 3465 RVA: 0x00036E45 File Offset: 0x00035045
		public string[] Split(string input, int count, int startat)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			return Regex.Split(this, input, count, startat);
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00036E60 File Offset: 0x00035060
		private static string[] Split(Regex regex, string input, int count, int startat)
		{
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Count cannot be less than -1.");
			}
			if (startat < 0 || startat > input.Length)
			{
				throw new ArgumentOutOfRangeException("startat", "Start index cannot be less than 0 or greater than input length.");
			}
			if (count == 1)
			{
				return new string[]
				{
					input
				};
			}
			count--;
			Match match = regex.Match(input, startat);
			if (!match.Success)
			{
				return new string[]
				{
					input
				};
			}
			List<string> list = new List<string>();
			if (!regex.RightToLeft)
			{
				int num = 0;
				do
				{
					list.Add(input.Substring(num, match.Index - num));
					num = match.Index + match.Length;
					for (int i = 1; i < match.Groups.Count; i++)
					{
						if (match.IsMatched(i))
						{
							list.Add(match.Groups[i].ToString());
						}
					}
					if (--count == 0)
					{
						break;
					}
					match = match.NextMatch();
				}
				while (match.Success);
				list.Add(input.Substring(num, input.Length - num));
			}
			else
			{
				int num2 = input.Length;
				do
				{
					list.Add(input.Substring(match.Index + match.Length, num2 - match.Index - match.Length));
					num2 = match.Index;
					for (int j = 1; j < match.Groups.Count; j++)
					{
						if (match.IsMatched(j))
						{
							list.Add(match.Groups[j].ToString());
						}
					}
					if (--count == 0)
					{
						break;
					}
					match = match.NextMatch();
				}
				while (match.Success);
				list.Add(input.Substring(0, num2));
				list.Reverse(0, list.Count);
			}
			return list.ToArray();
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x0003701C File Offset: 0x0003521C
		static Regex()
		{
			Regex.s_defaultMatchTimeout = Regex.InitDefaultMatchTimeout();
		}

		/// <summary>Получает интервал времени ожидания текущего экземпляра.</summary>
		/// <returns>Максимальный интервал времени, который может пройти в операции сравнения с шаблоном, прежде чем возникнет исключение <see cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException" />, или <see cref="F:System.Text.RegularExpressions.Regex.InfiniteMatchTimeout" />, если контроль времени ожидания отключен.</returns>
		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000D8C RID: 3468 RVA: 0x0003706C File Offset: 0x0003526C
		public TimeSpan MatchTimeout
		{
			get
			{
				return this.internalMatchTimeout;
			}
		}

		/// <summary>Проверяет, попадает ли интервал времени ожидания в допустимый диапазон.</summary>
		/// <param name="matchTimeout">Время ожидания, которое требуется проверить.</param>
		// Token: 0x06000D8D RID: 3469 RVA: 0x00037074 File Offset: 0x00035274
		protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout)
		{
			if (Regex.InfiniteMatchTimeout == matchTimeout)
			{
				return;
			}
			if (TimeSpan.Zero < matchTimeout && matchTimeout <= Regex.s_maximumMatchTimeout)
			{
				return;
			}
			throw new ArgumentOutOfRangeException("matchTimeout");
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x000370AC File Offset: 0x000352AC
		private static TimeSpan InitDefaultMatchTimeout()
		{
			object data = AppDomain.CurrentDomain.GetData("REGEX_DEFAULT_MATCH_TIMEOUT");
			if (data == null)
			{
				return Regex.InfiniteMatchTimeout;
			}
			if (data is TimeSpan)
			{
				TimeSpan timeSpan = (TimeSpan)data;
				try
				{
					Regex.ValidateMatchTimeout(timeSpan);
				}
				catch (ArgumentOutOfRangeException)
				{
					throw new ArgumentOutOfRangeException(SR.Format("AppDomain data '{0}' contains an invalid value or object for specifying a default matching timeout for System.Text.RegularExpressions.Regex.", "REGEX_DEFAULT_MATCH_TIMEOUT", timeSpan));
				}
				return timeSpan;
			}
			throw new InvalidCastException(SR.Format("AppDomain data '{0}' contains an invalid value or object for specifying a default matching timeout for System.Text.RegularExpressions.Regex.", "REGEX_DEFAULT_MATCH_TIMEOUT", data));
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.RegularExpressions.Regex" />.</summary>
		// Token: 0x06000D8F RID: 3471 RVA: 0x0003712C File Offset: 0x0003532C
		protected Regex()
		{
			this.internalMatchTimeout = Regex.s_defaultMatchTimeout;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.RegularExpressions.Regex" /> для заданного регулярного выражения.</summary>
		/// <param name="pattern">Шаблон регулярного выражения для сопоставления.</param>
		/// <exception cref="T:System.ArgumentException">Произошла ошибка анализа регулярного выражения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pattern" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000D90 RID: 3472 RVA: 0x0003713F File Offset: 0x0003533F
		public Regex(string pattern) : this(pattern, RegexOptions.None, Regex.s_defaultMatchTimeout, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.RegularExpressions.Regex" /> для указанного регулярного выражения с параметрами, изменяющими шаблон.</summary>
		/// <param name="pattern">Шаблон регулярного выражения для сопоставления.</param>
		/// <param name="options">Побитовое сочетание значений перечисления, изменяющих регулярное выражение.</param>
		/// <exception cref="T:System.ArgumentException">Произошла ошибка анализа регулярного выражения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="options" /> содержит недопустимый флаг.</exception>
		// Token: 0x06000D91 RID: 3473 RVA: 0x0003714F File Offset: 0x0003534F
		public Regex(string pattern, RegexOptions options) : this(pattern, options, Regex.s_defaultMatchTimeout, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.RegularExpressions.Regex" /> для указанного регулярного выражения с параметрами, которые изменяют шаблон, и значение, указывающее, как долго метод сравнения с шаблоном должен пытаться найти совпадение, прежде чем время ожидания истечет.</summary>
		/// <param name="pattern">Шаблон регулярного выражения для сопоставления.</param>
		/// <param name="options">Побитовое сочетание значений перечисления, изменяющих регулярное выражение.</param>
		/// <param name="matchTimeout">Интервал времени ожидания или <see cref="F:System.Text.RegularExpressions.Regex.InfiniteMatchTimeout" />, чтобы указать, что метод не должен превышать время ожидания.</param>
		/// <exception cref="T:System.ArgumentException">Произошла ошибка анализа регулярного выражения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="pattern" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="options" /> не является допустимым значением <see cref="T:System.Text.RegularExpressions.RegexOptions" />.  
		/// -или- 
		///  Значение параметра <paramref name="matchTimeout" /> отрицательное, равно нулю или больше, чем приблизительно 24 дня.</exception>
		// Token: 0x06000D92 RID: 3474 RVA: 0x0003715F File Offset: 0x0003535F
		public Regex(string pattern, RegexOptions options, TimeSpan matchTimeout) : this(pattern, options, matchTimeout, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Text.RegularExpressions.Regex" />, используя сериализованные данные.</summary>
		/// <param name="info">Объект, содержащий сериализованный шаблон и сведения <see cref="T:System.Text.RegularExpressions.RegexOptions" />.</param>
		/// <param name="context">Целевой объект этой сериализации. (Этот параметр не используется; задайте значение <see langword="null" />.)</param>
		/// <exception cref="T:System.ArgumentException">Произошла ошибка анализа регулярного выражения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Шаблон, содержащий <paramref name="info" />, имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="info" /> содержит недопустимый флаг <see cref="T:System.Text.RegularExpressions.RegexOptions" />.</exception>
		// Token: 0x06000D93 RID: 3475 RVA: 0x0003716B File Offset: 0x0003536B
		protected Regex(SerializationInfo info, StreamingContext context) : this(info.GetString("pattern"), (RegexOptions)info.GetInt32("options"))
		{
			throw new PlatformNotSupportedException();
		}

		/// <summary>Заполняет объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными даты, необходимыми для десериализации текущего объекта <see cref="T:System.Text.RegularExpressions.Regex" />.</summary>
		/// <param name="si">Объект, который требуется заполнить информацией о сериализации.</param>
		/// <param name="context">Место для хранения и извлечения сериализованных данных. Этот параметр зарезервирован для использования в будущем.</param>
		// Token: 0x06000D94 RID: 3476 RVA: 0x00011F54 File Offset: 0x00010154
		void ISerializable.GetObjectData(SerializationInfo si, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00037190 File Offset: 0x00035390
		private Regex(string pattern, RegexOptions options, TimeSpan matchTimeout, bool addToCache)
		{
			if (pattern == null)
			{
				throw new ArgumentNullException("pattern");
			}
			if (options < RegexOptions.None || options >> 10 != RegexOptions.None)
			{
				throw new ArgumentOutOfRangeException("options");
			}
			if ((options & RegexOptions.ECMAScript) != RegexOptions.None && (options & ~(RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Compiled | RegexOptions.ECMAScript | RegexOptions.CultureInvariant)) != RegexOptions.None)
			{
				throw new ArgumentOutOfRangeException("options");
			}
			Regex.ValidateMatchTimeout(matchTimeout);
			this.pattern = pattern;
			this.roptions = options;
			this.internalMatchTimeout = matchTimeout;
			string cultureKey = ((options & RegexOptions.CultureInvariant) != RegexOptions.None) ? CultureInfo.InvariantCulture.ToString() : CultureInfo.CurrentCulture.ToString();
			Regex.CachedCodeEntryKey key = new Regex.CachedCodeEntryKey(options, cultureKey, pattern);
			Regex.CachedCodeEntry cachedCode = this.GetCachedCode(key, false);
			if (cachedCode == null)
			{
				RegexTree regexTree = RegexParser.Parse(pattern, this.roptions);
				this.capnames = regexTree.CapNames;
				this.capslist = regexTree.CapsList;
				this._code = RegexWriter.Write(regexTree);
				this.caps = this._code.Caps;
				this.capsize = this._code.CapSize;
				this.InitializeReferences();
				if (addToCache)
				{
					cachedCode = this.GetCachedCode(key, true);
				}
			}
			else
			{
				this.caps = cachedCode.Caps;
				this.capnames = cachedCode.Capnames;
				this.capslist = cachedCode.Capslist;
				this.capsize = cachedCode.Capsize;
				this._code = cachedCode.Code;
				this.factory = cachedCode.Factory;
				this._runnerref = cachedCode.Runnerref;
				this._replref = cachedCode.ReplRef;
				this._refsInitialized = true;
			}
			if (this.UseOptionC() && this.factory == null)
			{
				this.factory = this.Compile(this._code, this.roptions);
				if (addToCache && cachedCode != null)
				{
					cachedCode.AddCompiled(this.factory);
				}
				this._code = null;
			}
		}

		/// <summary>Получает или задает словарь, сопоставляющий нумерованные захватываемые группы со значениями их индексов.</summary>
		/// <returns>Словарь, сопоставляющий нумерованные захватываемые группы со значениями их индексов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение, присвоенное свойству <see cref="P:System.Text.RegularExpressions.Regex.Caps" /> в операции задания, равно <see langword="null" />.</exception>
		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x00037347 File Offset: 0x00035547
		// (set) Token: 0x06000D97 RID: 3479 RVA: 0x0003734F File Offset: 0x0003554F
		[CLSCompliant(false)]
		protected IDictionary Caps
		{
			get
			{
				return this.caps;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.caps = ((value as Hashtable) ?? new Hashtable(value));
			}
		}

		/// <summary>Получает или задает словарь, сопоставляющий именованные захватываемые группы со значениями их индексов.</summary>
		/// <returns>Словарь, сопоставляющий именованные захватываемые группы со значениями их индексов.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение, присвоенное свойству <see cref="P:System.Text.RegularExpressions.Regex.CapNames" /> в операции задания, равно <see langword="null" />.</exception>
		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x00037375 File Offset: 0x00035575
		// (set) Token: 0x06000D99 RID: 3481 RVA: 0x0003737D File Offset: 0x0003557D
		[CLSCompliant(false)]
		protected IDictionary CapNames
		{
			get
			{
				return this.capnames;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.capnames = ((value as Hashtable) ?? new Hashtable(value));
			}
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x000373A3 File Offset: 0x000355A3
		[MethodImpl(MethodImplOptions.NoInlining)]
		private RegexRunnerFactory Compile(RegexCode code, RegexOptions roptions)
		{
			return RegexCompiler.Compile(code, roptions);
		}

		/// <summary>Компилирует один или несколько указанных объектов <see cref="T:System.Text.RegularExpressions.Regex" /> в именованную сборку.</summary>
		/// <param name="regexinfos">Массив, описывающий регулярные выражения для компилирования.</param>
		/// <param name="assemblyname">Имя файла сборки.</param>
		/// <exception cref="T:System.ArgumentException">Значением свойства <see cref="P:System.Reflection.AssemblyName.Name" /> параметра <paramref name="assemblyname" /> является пустая или нулевая строка.  
		/// -или- 
		/// Шаблон регулярного выражения одного или более объектов в <paramref name="regexinfos" /> содержит недопустимый синтаксис.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="assemblyname" /> или <paramref name="regexinfos" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Только в .NET Core: создание сборки скомпилированных регулярных выражений не поддерживается.</exception>
		// Token: 0x06000D9B RID: 3483 RVA: 0x000373AC File Offset: 0x000355AC
		public static void CompileToAssembly(RegexCompilationInfo[] regexinfos, AssemblyName assemblyname)
		{
			throw new PlatformNotSupportedException("This platform does not support writing compiled regular expressions to an assembly.");
		}

		/// <summary>Компилирует один или несколько указанных объектов <see cref="T:System.Text.RegularExpressions.Regex" /> в именованную сборку с заданными атрибутами.</summary>
		/// <param name="regexinfos">Массив, описывающий регулярные выражения для компилирования.</param>
		/// <param name="assemblyname">Имя файла сборки.</param>
		/// <param name="attributes">Массив, определяющий атрибуты, применяемые к сборке.</param>
		/// <exception cref="T:System.ArgumentException">Значением свойства <see cref="P:System.Reflection.AssemblyName.Name" /> параметра <paramref name="assemblyname" /> является пустая или нулевая строка.  
		/// -или- 
		/// Шаблон регулярного выражения одного или более объектов в <paramref name="regexinfos" /> содержит недопустимый синтаксис.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="assemblyname" /> или <paramref name="regexinfos" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Только в .NET Core: создание сборки скомпилированных регулярных выражений не поддерживается.</exception>
		// Token: 0x06000D9C RID: 3484 RVA: 0x000373AC File Offset: 0x000355AC
		public static void CompileToAssembly(RegexCompilationInfo[] regexinfos, AssemblyName assemblyname, CustomAttributeBuilder[] attributes)
		{
			throw new PlatformNotSupportedException("This platform does not support writing compiled regular expressions to an assembly.");
		}

		/// <summary>Компилирует один или несколько указанных объектов <see cref="T:System.Text.RegularExpressions.Regex" /> и указанный файл ресурсов в именованную сборку с заданными атрибутами.</summary>
		/// <param name="regexinfos">Массив, описывающий регулярные выражения для компилирования.</param>
		/// <param name="assemblyname">Имя файла сборки.</param>
		/// <param name="attributes">Массив, определяющий атрибуты, применяемые к сборке.</param>
		/// <param name="resourceFile">Имя файла ресурса Win32 для включения в сборку.</param>
		/// <exception cref="T:System.ArgumentException">Значением свойства <see cref="P:System.Reflection.AssemblyName.Name" /> параметра <paramref name="assemblyname" /> является пустая или нулевая строка.  
		/// -или- 
		/// Шаблон регулярного выражения одного или более объектов в <paramref name="regexinfos" /> содержит недопустимый синтаксис.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="assemblyname" /> или <paramref name="regexinfos" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Параметр <paramref name="resourceFile" /> назначает недопустимый файл ресурсов Win32.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Не удается найти файл, заданный свойством <paramref name="resourceFile" />.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">Только в .NET Core: создание сборки скомпилированных регулярных выражений не поддерживается.</exception>
		// Token: 0x06000D9D RID: 3485 RVA: 0x000373AC File Offset: 0x000355AC
		public static void CompileToAssembly(RegexCompilationInfo[] regexinfos, AssemblyName assemblyname, CustomAttributeBuilder[] attributes, string resourceFile)
		{
			throw new PlatformNotSupportedException("This platform does not support writing compiled regular expressions to an assembly.");
		}

		/// <summary>Преобразует минимальный набор символов (\, *, +, ?, |, {, [, (,), ^, $,., # и пробел), заменяя их escape-кодами. При этом обработчику регулярных выражений дается команда интерпретировать эти символы буквально, а не как метасимволы.</summary>
		/// <param name="str">Входная строка, содержащая преобразуемый текст.</param>
		/// <returns>Строка символов с метасимволами, приведенными в преобразованную форму.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="str" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000D9E RID: 3486 RVA: 0x000373B8 File Offset: 0x000355B8
		public static string Escape(string str)
		{
			if (str == null)
			{
				throw new ArgumentNullException("str");
			}
			return RegexParser.Escape(str);
		}

		/// <summary>Преобразует все escape-символы во входной строке обратно в символы.</summary>
		/// <param name="str">Входная строка, содержащая текст для преобразования.</param>
		/// <returns>Строка символов с любыми преобразованными символами, приведенными в их непреобразованную форму.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="str" /> включает нераспознанную escape-последовательность.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="str" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000D9F RID: 3487 RVA: 0x000373CE File Offset: 0x000355CE
		public static string Unescape(string str)
		{
			if (str == null)
			{
				throw new ArgumentNullException("str");
			}
			return RegexParser.Unescape(str);
		}

		/// <summary>Получает параметр, которые были переданы в конструктор <see cref="T:System.Text.RegularExpressions.Regex" />.</summary>
		/// <returns>Один или несколько членов перечисления <see cref="T:System.Text.RegularExpressions.RegexOptions" />, представляющих параметры, переданные в конструктор <see cref="T:System.Text.RegularExpressions.Regex" /></returns>
		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x000373E4 File Offset: 0x000355E4
		public RegexOptions Options
		{
			get
			{
				return this.roptions;
			}
		}

		/// <summary>Получает значение, указывающее на то, выполняется ли регулярным выражением поиск справа налево.</summary>
		/// <returns>Значение <see langword="true" />, если регулярное выражение выполняет поиск справа налево; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x000373EC File Offset: 0x000355EC
		public bool RightToLeft
		{
			get
			{
				return this.UseOptionR();
			}
		}

		/// <summary>Возвращает шаблон регулярного выражения, который был передан в конструктор <see langword="Regex" />.</summary>
		/// <returns>Параметр <paramref name="pattern" />, который был передан в конструктор <see langword="Regex" />.</returns>
		// Token: 0x06000DA2 RID: 3490 RVA: 0x000373F4 File Offset: 0x000355F4
		public override string ToString()
		{
			return this.pattern;
		}

		/// <summary>Возвращает массив имен группы записи для регулярного выражения.</summary>
		/// <returns>Строковый массив имен группы.</returns>
		// Token: 0x06000DA3 RID: 3491 RVA: 0x000373FC File Offset: 0x000355FC
		public string[] GetGroupNames()
		{
			string[] array;
			if (this.capslist == null)
			{
				int num = this.capsize;
				array = new string[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = Convert.ToString(i, CultureInfo.InvariantCulture);
				}
			}
			else
			{
				array = new string[this.capslist.Length];
				Array.Copy(this.capslist, 0, array, 0, this.capslist.Length);
			}
			return array;
		}

		/// <summary>Возвращает массив номеров групп записи, что соответствует именам групп в массиве.</summary>
		/// <returns>Целочисленный массив номеров групп.</returns>
		// Token: 0x06000DA4 RID: 3492 RVA: 0x00037460 File Offset: 0x00035660
		public int[] GetGroupNumbers()
		{
			int[] array;
			if (this.caps == null)
			{
				array = new int[this.capsize];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = i;
				}
			}
			else
			{
				array = new int[this.caps.Count];
				IDictionaryEnumerator enumerator = this.caps.GetEnumerator();
				while (enumerator.MoveNext())
				{
					array[(int)enumerator.Value] = (int)enumerator.Key;
				}
			}
			return array;
		}

		/// <summary>Получает имя группы, соответствующее указанному номеру группы.</summary>
		/// <param name="i">Номер группы для преобразования в соответствующее имя группы.</param>
		/// <returns>Строка, содержащая имя группы, связанное с указанным номером группы. При отсутствии имени группы, соответствующей параметру <paramref name="i" />, метод возвращает значение <see cref="F:System.String.Empty" />.</returns>
		// Token: 0x06000DA5 RID: 3493 RVA: 0x000374D8 File Offset: 0x000356D8
		public string GroupNameFromNumber(int i)
		{
			if (this.capslist == null)
			{
				if (i >= 0 && i < this.capsize)
				{
					return i.ToString(CultureInfo.InvariantCulture);
				}
				return string.Empty;
			}
			else
			{
				if (this.caps != null && !this.caps.TryGetValue(i, out i))
				{
					return string.Empty;
				}
				if (i >= 0 && i < this.capslist.Length)
				{
					return this.capslist[i];
				}
				return string.Empty;
			}
		}

		/// <summary>Возвращает номер группы, соответствующий указанному имени группы.</summary>
		/// <param name="name">Имя группы для преобразования в соответствующий номер группы.</param>
		/// <returns>Номер группы, соответствующий указанному имени группы, или -1, если <paramref name="name" /> является недопустимым именем группы.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000DA6 RID: 3494 RVA: 0x00037550 File Offset: 0x00035750
		public int GroupNumberFromName(string name)
		{
			int num = -1;
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (this.capnames != null)
			{
				if (!this.capnames.TryGetValue(name, out num))
				{
					return -1;
				}
				return num;
			}
			else
			{
				num = 0;
				foreach (char c in name)
				{
					if (c > '9' || c < '0')
					{
						return -1;
					}
					num *= 10;
					num += (int)(c - '0');
				}
				if (num >= 0 && num < this.capsize)
				{
					return num;
				}
				return -1;
			}
		}

		/// <summary>Используется объектом <see cref="T:System.Text.RegularExpressions.Regex" />, который создан методом <see cref="Overload:System.Text.RegularExpressions.Regex.CompileToAssembly" />.</summary>
		/// <exception cref="T:System.NotSupportedException">Ссылки уже инициализированы.</exception>
		// Token: 0x06000DA7 RID: 3495 RVA: 0x000375CC File Offset: 0x000357CC
		protected void InitializeReferences()
		{
			if (this._refsInitialized)
			{
				throw new NotSupportedException("This operation is only allowed once per object.");
			}
			this._refsInitialized = true;
			this._runnerref = new ExclusiveReference();
			this._replref = new WeakReference<RegexReplacement>(null);
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00037600 File Offset: 0x00035800
		internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat)
		{
			if (startat < 0 || startat > input.Length)
			{
				throw new ArgumentOutOfRangeException("startat", "Start index cannot be less than 0 or greater than input length.");
			}
			if (length < 0 || length > input.Length)
			{
				throw new ArgumentOutOfRangeException("length", "Length cannot be less than 0 or exceed input length.");
			}
			RegexRunner regexRunner = this._runnerref.Get();
			if (regexRunner == null)
			{
				if (this.factory != null)
				{
					regexRunner = this.factory.CreateInstance();
				}
				else
				{
					regexRunner = new RegexInterpreter(this._code, this.UseOptionInvariant() ? CultureInfo.InvariantCulture : CultureInfo.CurrentCulture);
				}
			}
			Match result;
			try
			{
				result = regexRunner.Scan(this, input, beginning, beginning + length, startat, prevlen, quick, this.internalMatchTimeout);
			}
			finally
			{
				this._runnerref.Release(regexRunner);
			}
			return result;
		}

		/// <summary>Используется объектом <see cref="T:System.Text.RegularExpressions.Regex" />, который создан методом <see cref="Overload:System.Text.RegularExpressions.Regex.CompileToAssembly" />.</summary>
		/// <returns>Значение <see langword="true" />, если свойство <see cref="P:System.Text.RegularExpressions.Regex.Options" /> содержит параметр <see cref="F:System.Text.RegularExpressions.RegexOptions.Compiled" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000DA9 RID: 3497 RVA: 0x000376CC File Offset: 0x000358CC
		protected bool UseOptionC()
		{
			return Environment.GetEnvironmentVariable("MONO_REGEX_COMPILED_ENABLE") != null && (this.roptions & RegexOptions.Compiled) > RegexOptions.None;
		}

		/// <summary>Используется объектом <see cref="T:System.Text.RegularExpressions.Regex" />, который создан методом <see cref="Overload:System.Text.RegularExpressions.Regex.CompileToAssembly" />.</summary>
		/// <returns>Значение <see langword="true" />, если свойство <see cref="P:System.Text.RegularExpressions.Regex.Options" /> содержит параметр <see cref="F:System.Text.RegularExpressions.RegexOptions.RightToLeft" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000DAA RID: 3498 RVA: 0x000376E7 File Offset: 0x000358E7
		protected internal bool UseOptionR()
		{
			return (this.roptions & RegexOptions.RightToLeft) > RegexOptions.None;
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x000376F5 File Offset: 0x000358F5
		internal bool UseOptionInvariant()
		{
			return (this.roptions & RegexOptions.CultureInvariant) > RegexOptions.None;
		}

		// Token: 0x04000803 RID: 2051
		private const int CacheDictionarySwitchLimit = 10;

		// Token: 0x04000804 RID: 2052
		private static int s_cacheSize = 15;

		// Token: 0x04000805 RID: 2053
		private static readonly Dictionary<Regex.CachedCodeEntryKey, Regex.CachedCodeEntry> s_cache = new Dictionary<Regex.CachedCodeEntryKey, Regex.CachedCodeEntry>(Regex.s_cacheSize);

		// Token: 0x04000806 RID: 2054
		private static int s_cacheCount = 0;

		// Token: 0x04000807 RID: 2055
		private static Regex.CachedCodeEntry s_cacheFirst;

		// Token: 0x04000808 RID: 2056
		private static Regex.CachedCodeEntry s_cacheLast;

		// Token: 0x04000809 RID: 2057
		private static readonly TimeSpan s_maximumMatchTimeout = TimeSpan.FromMilliseconds(2147483646.0);

		// Token: 0x0400080A RID: 2058
		private const string DefaultMatchTimeout_ConfigKeyName = "REGEX_DEFAULT_MATCH_TIMEOUT";

		// Token: 0x0400080B RID: 2059
		internal static readonly TimeSpan s_defaultMatchTimeout;

		/// <summary>Указывает, что для операции сравнения с шаблоном не используется конечное время ожидания.</summary>
		// Token: 0x0400080C RID: 2060
		public static readonly TimeSpan InfiniteMatchTimeout = Timeout.InfiniteTimeSpan;

		/// <summary>Максимальное время, которое может пройти в операции сравнения с шаблоном перед истечением срока ожидания операции.</summary>
		// Token: 0x0400080D RID: 2061
		protected internal TimeSpan internalMatchTimeout;

		// Token: 0x0400080E RID: 2062
		internal const int MaxOptionShift = 10;

		/// <summary>Используется объектом <see cref="T:System.Text.RegularExpressions.Regex" />, который создан методом <see cref="Overload:System.Text.RegularExpressions.Regex.CompileToAssembly" />.</summary>
		// Token: 0x0400080F RID: 2063
		protected internal string pattern;

		/// <summary>Используется объектом <see cref="T:System.Text.RegularExpressions.Regex" />, который создан методом <see cref="Overload:System.Text.RegularExpressions.Regex.CompileToAssembly" />.</summary>
		// Token: 0x04000810 RID: 2064
		protected internal RegexOptions roptions;

		/// <summary>Используется объектом <see cref="T:System.Text.RegularExpressions.Regex" />, который создан методом <see cref="Overload:System.Text.RegularExpressions.Regex.CompileToAssembly" />.</summary>
		// Token: 0x04000811 RID: 2065
		protected internal RegexRunnerFactory factory;

		/// <summary>Используется объектом <see cref="T:System.Text.RegularExpressions.Regex" />, который создан методом <see cref="Overload:System.Text.RegularExpressions.Regex.CompileToAssembly" />.</summary>
		// Token: 0x04000812 RID: 2066
		protected internal Hashtable caps;

		/// <summary>Используется объектом <see cref="T:System.Text.RegularExpressions.Regex" />, который создан методом <see cref="Overload:System.Text.RegularExpressions.Regex.CompileToAssembly" />.</summary>
		// Token: 0x04000813 RID: 2067
		protected internal Hashtable capnames;

		/// <summary>Используется объектом <see cref="T:System.Text.RegularExpressions.Regex" />, который создан методом <see cref="Overload:System.Text.RegularExpressions.Regex.CompileToAssembly" />.</summary>
		// Token: 0x04000814 RID: 2068
		protected internal string[] capslist;

		/// <summary>Используется объектом <see cref="T:System.Text.RegularExpressions.Regex" />, который создан методом <see cref="Overload:System.Text.RegularExpressions.Regex.CompileToAssembly" />.</summary>
		// Token: 0x04000815 RID: 2069
		protected internal int capsize;

		// Token: 0x04000816 RID: 2070
		internal ExclusiveReference _runnerref;

		// Token: 0x04000817 RID: 2071
		internal WeakReference<RegexReplacement> _replref;

		// Token: 0x04000818 RID: 2072
		internal RegexCode _code;

		// Token: 0x04000819 RID: 2073
		internal bool _refsInitialized;

		// Token: 0x020001F6 RID: 502
		internal readonly struct CachedCodeEntryKey : IEquatable<Regex.CachedCodeEntryKey>
		{
			// Token: 0x06000DAC RID: 3500 RVA: 0x00037706 File Offset: 0x00035906
			public CachedCodeEntryKey(RegexOptions options, string cultureKey, string pattern)
			{
				this._options = options;
				this._cultureKey = cultureKey;
				this._pattern = pattern;
			}

			// Token: 0x06000DAD RID: 3501 RVA: 0x0003771D File Offset: 0x0003591D
			public override bool Equals(object obj)
			{
				return obj is Regex.CachedCodeEntryKey && this.Equals((Regex.CachedCodeEntryKey)obj);
			}

			// Token: 0x06000DAE RID: 3502 RVA: 0x00037735 File Offset: 0x00035935
			public bool Equals(Regex.CachedCodeEntryKey other)
			{
				return this._pattern.Equals(other._pattern) && this._options == other._options && this._cultureKey.Equals(other._cultureKey);
			}

			// Token: 0x06000DAF RID: 3503 RVA: 0x0003776B File Offset: 0x0003596B
			public static bool operator ==(Regex.CachedCodeEntryKey left, Regex.CachedCodeEntryKey right)
			{
				return left.Equals(right);
			}

			// Token: 0x06000DB0 RID: 3504 RVA: 0x00037775 File Offset: 0x00035975
			public static bool operator !=(Regex.CachedCodeEntryKey left, Regex.CachedCodeEntryKey right)
			{
				return !left.Equals(right);
			}

			// Token: 0x06000DB1 RID: 3505 RVA: 0x00037782 File Offset: 0x00035982
			public override int GetHashCode()
			{
				return (int)(this._options ^ (RegexOptions)this._cultureKey.GetHashCode() ^ (RegexOptions)this._pattern.GetHashCode());
			}

			// Token: 0x0400081A RID: 2074
			private readonly RegexOptions _options;

			// Token: 0x0400081B RID: 2075
			private readonly string _cultureKey;

			// Token: 0x0400081C RID: 2076
			private readonly string _pattern;
		}

		// Token: 0x020001F7 RID: 503
		internal sealed class CachedCodeEntry
		{
			// Token: 0x06000DB2 RID: 3506 RVA: 0x000377A4 File Offset: 0x000359A4
			public CachedCodeEntry(Regex.CachedCodeEntryKey key, Hashtable capnames, string[] capslist, RegexCode code, Hashtable caps, int capsize, ExclusiveReference runner, WeakReference<RegexReplacement> replref)
			{
				this.Key = key;
				this.Capnames = capnames;
				this.Capslist = capslist;
				this.Code = code;
				this.Caps = caps;
				this.Capsize = capsize;
				this.Runnerref = runner;
				this.ReplRef = replref;
			}

			// Token: 0x06000DB3 RID: 3507 RVA: 0x000377F4 File Offset: 0x000359F4
			public void AddCompiled(RegexRunnerFactory factory)
			{
				this.Factory = factory;
				this.Code = null;
			}

			// Token: 0x0400081D RID: 2077
			public Regex.CachedCodeEntry Next;

			// Token: 0x0400081E RID: 2078
			public Regex.CachedCodeEntry Previous;

			// Token: 0x0400081F RID: 2079
			public readonly Regex.CachedCodeEntryKey Key;

			// Token: 0x04000820 RID: 2080
			public RegexCode Code;

			// Token: 0x04000821 RID: 2081
			public readonly Hashtable Caps;

			// Token: 0x04000822 RID: 2082
			public readonly Hashtable Capnames;

			// Token: 0x04000823 RID: 2083
			public readonly string[] Capslist;

			// Token: 0x04000824 RID: 2084
			public RegexRunnerFactory Factory;

			// Token: 0x04000825 RID: 2085
			public readonly int Capsize;

			// Token: 0x04000826 RID: 2086
			public readonly ExclusiveReference Runnerref;

			// Token: 0x04000827 RID: 2087
			public readonly WeakReference<RegexReplacement> ReplRef;
		}
	}
}
