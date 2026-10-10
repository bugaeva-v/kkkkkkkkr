using System;

namespace System.Collections.Generic
{
	/// <summary>Представляет универсальную коллекцию пар «ключ-значение».</summary>
	/// <typeparam name="TKey">Тип ключей в словаре.</typeparam>
	/// <typeparam name="TValue">Тип значений в словаре.</typeparam>
	// Token: 0x02000A95 RID: 2709
	public interface IDictionary<TKey, TValue> : ICollection<KeyValuePair<!0, !1>>, IEnumerable<KeyValuePair<!0, !1>>, IEnumerable
	{
		/// <summary>Возвращает или задает элемент с указанным ключом.</summary>
		/// <param name="key">Ключ элемента, который требуется получить или задать.</param>
		/// <returns>Элемент с указанным ключом.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Collections.Generic.KeyNotFoundException">Свойство получено и параметр <paramref name="key" /> не найден.</exception>
		/// <exception cref="T:System.NotSupportedException">Свойство задано, и список <see cref="T:System.Collections.Generic.IDictionary`2" /> доступен только для чтения.</exception>
		// Token: 0x1700113F RID: 4415
		TValue this[TKey key]
		{
			get;
			set;
		}

		/// <summary>Возвращает интерфейс <see cref="T:System.Collections.Generic.ICollection`1" />, содержащий ключи <see cref="T:System.Collections.Generic.IDictionary`2" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.Generic.ICollection`1" />, содержащий ключи объекта, который реализует <see cref="T:System.Collections.Generic.IDictionary`2" />.</returns>
		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x0600611B RID: 24859
		ICollection<TKey> Keys { get; }

		/// <summary>Возвращает интерфейс <see cref="T:System.Collections.Generic.ICollection`1" />, содержащий значения из <see cref="T:System.Collections.Generic.IDictionary`2" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.Generic.ICollection`1" />, содержащий значения объекта, который реализует <see cref="T:System.Collections.Generic.IDictionary`2" />.</returns>
		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x0600611C RID: 24860
		ICollection<TValue> Values { get; }

		/// <summary>Определяет, содержится ли элемент с указанным ключом в <see cref="T:System.Collections.Generic.IDictionary`2" />.</summary>
		/// <param name="key">Ключ, который требуется найти в <see cref="T:System.Collections.Generic.IDictionary`2" />.</param>
		/// <returns>Значение <see langword="true" />, если в <see cref="T:System.Collections.Generic.IDictionary`2" /> содержится элемент с данным ключом; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600611D RID: 24861
		bool ContainsKey(TKey key);

		/// <summary>Добавляет элемент с указанными ключом и значением в объект <see cref="T:System.Collections.Generic.IDictionary`2" />.</summary>
		/// <param name="key">Объект, используемый в качестве ключа добавляемого элемента.</param>
		/// <param name="value">Объект, используемый в качестве значения добавляемого элемента.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Элемент с таким ключом уже существует в <see cref="T:System.Collections.Generic.IDictionary`2" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.Generic.IDictionary`2" /> доступен только для чтения.</exception>
		// Token: 0x0600611E RID: 24862
		void Add(TKey key, TValue value);

		/// <summary>Удаляет элемент с указанным ключом из <see cref="T:System.Collections.Generic.IDictionary`2" />.</summary>
		/// <param name="key">Ключ элемента, который требуется удалить.</param>
		/// <returns>Значение <see langword="true" />, если элемент успешно удален; в противном случае — значение <see langword="false" />.  Этот метод также возвращает <see langword="false" />, если объект <paramref name="key" /> не был найден в исходной коллекции <see cref="T:System.Collections.Generic.IDictionary`2" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.Generic.IDictionary`2" /> доступен только для чтения.</exception>
		// Token: 0x0600611F RID: 24863
		bool Remove(TKey key);

		/// <summary>Возвращает значение, связанное с заданным ключом.</summary>
		/// <param name="key">Ключ, значение которого необходимо получить.</param>
		/// <param name="value">Этот метод возвращает значение, связанное с указанным ключом, если он найден; в противном случае — значение по умолчанию для данного типа параметра <paramref name="value" />. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="true" />, если объект, реализующий <see cref="T:System.Collections.Generic.IDictionary`2" />, содержит элемент с указанным ключом, в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06006120 RID: 24864
		bool TryGetValue(TKey key, out TValue value);
	}
}
