using System;
using System.Collections;
using System.Collections.Generic;
using Unity;

namespace System.Net.Http.Headers
{
	/// <summary>Представляет коллекцию значений заголовков.</summary>
	/// <typeparam name="T">Тип коллекции заголовков.</typeparam>
	// Token: 0x02000044 RID: 68
	public sealed class HttpHeaderValueCollection<T> : ICollection<T>, IEnumerable<T>, IEnumerable where T : class
	{
		// Token: 0x06000251 RID: 593 RVA: 0x00008ED0 File Offset: 0x000070D0
		internal HttpHeaderValueCollection(HttpHeaders headers, HeaderInfo headerInfo)
		{
			this.list = new List<T>();
			this.headers = headers;
			this.headerInfo = headerInfo;
		}

		/// <summary>Возвращает число заголовков в <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.</summary>
		/// <returns>Число заголовков в коллекции.</returns>
		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00008EF1 File Offset: 0x000070F1
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00008EFE File Offset: 0x000070FE
		internal List<string> InvalidValues
		{
			get
			{
				return this.invalidValues;
			}
		}

		/// <summary>Возвращает значение, указывающее, доступен ли экземпляр <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" /> только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если экземпляр класса <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" /> доступен только для чтения, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00008F06 File Offset: 0x00007106
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Добавляет запись в коллекцию <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.</summary>
		/// <param name="item">Элемент для добавления в коллекцию заголовков.</param>
		// Token: 0x06000255 RID: 597 RVA: 0x00008F09 File Offset: 0x00007109
		public void Add(T item)
		{
			this.list.Add(item);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00008F17 File Offset: 0x00007117
		internal void AddRange(List<T> values)
		{
			this.list.AddRange(values);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00008F25 File Offset: 0x00007125
		internal void AddInvalidValue(string invalidValue)
		{
			if (this.invalidValues == null)
			{
				this.invalidValues = new List<string>();
			}
			this.invalidValues.Add(invalidValue);
		}

		/// <summary>Удаляет все записи из <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.</summary>
		// Token: 0x06000258 RID: 600 RVA: 0x00008F46 File Offset: 0x00007146
		public void Clear()
		{
			this.list.Clear();
			this.invalidValues = null;
		}

		/// <summary>Определяет, содержит ли объект <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" /> элемент.</summary>
		/// <param name="item">Элемент, используемый для поиска в коллекции заголовков.</param>
		/// <returns>Значение <see langword="true" />, если экземпляр <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" /> содержит запись, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000259 RID: 601 RVA: 0x00008F5A File Offset: 0x0000715A
		public bool Contains(T item)
		{
			return this.list.Contains(item);
		}

		/// <summary>Копирует целый массив <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" /> в совместимый одномерный массив <see cref="T:System.Array" />, начиная с заданного индекса целевого массива.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из интерфейса <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="arrayIndex">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		// Token: 0x0600025A RID: 602 RVA: 0x00008F68 File Offset: 0x00007168
		public void CopyTo(T[] array, int arrayIndex)
		{
			this.list.CopyTo(array, arrayIndex);
		}

		/// <summary>Анализирует и добавляет запись в <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.</summary>
		/// <param name="input">Добавляемая запись.</param>
		// Token: 0x0600025B RID: 603 RVA: 0x00008F77 File Offset: 0x00007177
		public void ParseAdd(string input)
		{
			this.headers.AddValue(input, this.headerInfo, false);
		}

		/// <summary>Удаляет заданный элемент из <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.</summary>
		/// <param name="item">Удаляемый элемент.</param>
		/// <returns>
		///   <see langword="true" /> при удалении <paramref name="item" /> из экземпляра <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />. В противном случае — <see langword="false" />.</returns>
		// Token: 0x0600025C RID: 604 RVA: 0x00008F8D File Offset: 0x0000718D
		public bool Remove(T item)
		{
			return this.list.Remove(item);
		}

		/// <summary>Возвращает строку, представляющую текущий объект <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />. .</summary>
		/// <returns>Строка, представляющая текущий объект.</returns>
		// Token: 0x0600025D RID: 605 RVA: 0x00008F9C File Offset: 0x0000719C
		public override string ToString()
		{
			string text = string.Join<T>(this.headerInfo.Separator, this.list);
			if (this.invalidValues != null)
			{
				text += string.Join(this.headerInfo.Separator, this.invalidValues);
			}
			return text;
		}

		/// <summary>Определяет, можно ли проанализировать и добавить входные данные в <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.</summary>
		/// <param name="input">Запись для проверки.</param>
		/// <returns>Возвращает значение <see langword="true" />, если <paramref name="input" /> можно проанализировать и добавить в экземпляр <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600025E RID: 606 RVA: 0x00008FE6 File Offset: 0x000071E6
		public bool TryParseAdd(string input)
		{
			return this.headers.AddValue(input, this.headerInfo, true);
		}

		/// <summary>Возвращает перечислитель, осуществляющий перебор элементов списка <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.</summary>
		/// <returns>Перечислитель для экземпляра <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.</returns>
		// Token: 0x0600025F RID: 607 RVA: 0x00008FFB File Offset: 0x000071FB
		public IEnumerator<T> GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		/// <summary>Возвращает перечислитель, осуществляющий перебор элементов списка <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.</summary>
		/// <returns>Перечислитель для экземпляра <see cref="T:System.Net.Http.Headers.HttpHeaderValueCollection`1" />.</returns>
		// Token: 0x06000260 RID: 608 RVA: 0x0000900D File Offset: 0x0000720D
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00009015 File Offset: 0x00007215
		internal T Find(Predicate<T> predicate)
		{
			return this.list.Find(predicate);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00009024 File Offset: 0x00007224
		internal void Remove(Predicate<T> predicate)
		{
			T t = this.Find(predicate);
			if (t != null)
			{
				this.Remove(t);
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00008EC9 File Offset: 0x000070C9
		internal HttpHeaderValueCollection()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04000102 RID: 258
		private readonly List<T> list;

		// Token: 0x04000103 RID: 259
		private readonly HttpHeaders headers;

		// Token: 0x04000104 RID: 260
		private readonly HeaderInfo headerInfo;

		// Token: 0x04000105 RID: 261
		private List<string> invalidValues;
	}
}
