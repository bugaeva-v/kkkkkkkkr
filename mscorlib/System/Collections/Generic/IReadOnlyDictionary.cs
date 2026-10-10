using System;

namespace System.Collections.Generic
{
	/// <summary>Представляет универсальную коллекцию пар «ключ-значение», доступную только для чтения.</summary>
	/// <typeparam name="TKey">Тип ключей в словаре, доступном только для чтения.</typeparam>
	/// <typeparam name="TValue">Тип значений в словаре, доступном только для чтения.</typeparam>
	// Token: 0x02000A9E RID: 2718
	public interface IReadOnlyDictionary<TKey, TValue> : IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<!0, !1>>, IEnumerable
	{
		/// <summary>Определяет, содержится ли в словаре, доступном только для чтения, элемент с указанным ключом.</summary>
		/// <param name="key">Искомый ключ.</param>
		/// <returns>Значение <see langword="true" />, если в доступном только для чтения словаре содержится элемент с указанным ключом; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06006131 RID: 24881
		bool ContainsKey(TKey key);

		/// <summary>Получает значение, связанное с указанным ключом.</summary>
		/// <param name="key">Искомый ключ.</param>
		/// <param name="value">Этот метод возвращает значение, связанное с указанным ключом, если он найден; в противном случае — значение по умолчанию для данного типа параметра <paramref name="value" />. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="true" />, если объект, который реализует интерфейс <see cref="T:System.Collections.Generic.IReadOnlyDictionary`2" />, содержит элемент, имеющий указанный ключ; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06006132 RID: 24882
		bool TryGetValue(TKey key, out TValue value);

		/// <summary>Получает элемент, имеющий указанный ключ в доступном только для чтения словаре.</summary>
		/// <param name="key">Искомый ключ.</param>
		/// <returns>Элемент, имеющий указанный ключ в доступном только для чтения словаре.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Collections.Generic.KeyNotFoundException">Свойство получено и параметр <paramref name="key" /> не найден.</exception>
		// Token: 0x17001148 RID: 4424
		TValue this[TKey key]
		{
			get;
		}

		/// <summary>Получает перечисляемую коллекция, содержащую ключи в словаре только для чтения.</summary>
		/// <returns>Перечисляемая коллекция, содержащая ключи в словаре только для чтения.</returns>
		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x06006134 RID: 24884
		IEnumerable<TKey> Keys { get; }

		/// <summary>Получает перечисляемую коллекцию, содержащая значения в словаре только для чтения.</summary>
		/// <returns>Перечисляемая коллекция, содержащая значения в словаре только для чтения.</returns>
		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x06006135 RID: 24885
		IEnumerable<TValue> Values { get; }
	}
}
