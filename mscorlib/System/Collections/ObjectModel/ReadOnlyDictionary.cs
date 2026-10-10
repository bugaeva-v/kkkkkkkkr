using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Unity;

namespace System.Collections.ObjectModel
{
	/// <summary>Представляет универсальную коллекцию пар «ключ-значение», доступную только для чтения.</summary>
	/// <typeparam name="TKey">Тип ключей в словаре.</typeparam>
	/// <typeparam name="TValue">Тип значений в словаре.</typeparam>
	// Token: 0x02000A83 RID: 2691
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(DictionaryDebugView<, >))]
	[Serializable]
	public class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<!0, !1>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.ObjectModel.ReadOnlyDictionary`2" />, который является оболочкой для указанного словаря.</summary>
		/// <param name="dictionary">Словарь, для которого создается программа-оболочка.</param>
		// Token: 0x06006054 RID: 24660 RVA: 0x00142E36 File Offset: 0x00141036
		public ReadOnlyDictionary(IDictionary<TKey, TValue> dictionary)
		{
			if (dictionary == null)
			{
				throw new ArgumentNullException("dictionary");
			}
			this.m_dictionary = dictionary;
		}

		/// <summary>Получает словарь, упакованный в данный объект <see cref="T:System.Collections.ObjectModel.ReadOnlyDictionary`2" />.</summary>
		/// <returns>Словарь, упакованный в данный объект.</returns>
		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x06006055 RID: 24661 RVA: 0x00142E53 File Offset: 0x00141053
		protected IDictionary<TKey, TValue> Dictionary
		{
			get
			{
				return this.m_dictionary;
			}
		}

		/// <summary>Получает коллекцию ключей, содержащую ключи словаря.</summary>
		/// <returns>Коллекция ключей, содержащая ключи словаря.</returns>
		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x06006056 RID: 24662 RVA: 0x00142E5B File Offset: 0x0014105B
		public ReadOnlyDictionary<TKey, TValue>.KeyCollection Keys
		{
			get
			{
				if (this._keys == null)
				{
					this._keys = new ReadOnlyDictionary<TKey, TValue>.KeyCollection(this.m_dictionary.Keys);
				}
				return this._keys;
			}
		}

		/// <summary>Возвращает коллекцию, содержащую значения словаря.</summary>
		/// <returns>Коллекция, содержащая значения в объекте, который реализует объект <see cref="T:System.Collections.ObjectModel.ReadOnlyDictionary`2" />.</returns>
		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x06006057 RID: 24663 RVA: 0x00142E81 File Offset: 0x00141081
		public ReadOnlyDictionary<TKey, TValue>.ValueCollection Values
		{
			get
			{
				if (this._values == null)
				{
					this._values = new ReadOnlyDictionary<TKey, TValue>.ValueCollection(this.m_dictionary.Values);
				}
				return this._values;
			}
		}

		/// <summary>Определяет, содержится ли в словаре элемент с указанным ключом.</summary>
		/// <param name="key">Ключ, который нужно найти в словаре.</param>
		/// <returns>Значение <see langword="true" />, если словарь содержит элемент с указанным ключом; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06006058 RID: 24664 RVA: 0x00142EA7 File Offset: 0x001410A7
		public bool ContainsKey(TKey key)
		{
			return this.m_dictionary.ContainsKey(key);
		}

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x06006059 RID: 24665 RVA: 0x00142EB5 File Offset: 0x001410B5
		ICollection<TKey> IDictionary<!0, !1>.Keys
		{
			get
			{
				return this.Keys;
			}
		}

		/// <summary>Извлекает значение, связанное с заданным ключом.</summary>
		/// <param name="key">Ключ, значение которого нужно получить.</param>
		/// <param name="value">Этот метод возвращает значение, связанное с указанным ключом, если он найден; в противном случае — значение по умолчанию для данного типа параметра <paramref name="value" />. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение <see langword="true" />, если объект, реализующий <see cref="T:System.Collections.ObjectModel.ReadOnlyDictionary`2" />, содержит элемент с указанным ключом, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600605A RID: 24666 RVA: 0x00142EBD File Offset: 0x001410BD
		public bool TryGetValue(TKey key, out TValue value)
		{
			return this.m_dictionary.TryGetValue(key, out value);
		}

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x0600605B RID: 24667 RVA: 0x00142ECC File Offset: 0x001410CC
		ICollection<TValue> IDictionary<!0, !1>.Values
		{
			get
			{
				return this.Values;
			}
		}

		/// <summary>Получает элемент с указанным ключом.</summary>
		/// <param name="key">Ключ элемента, который требуется получить.</param>
		/// <returns>Элемент с указанным ключом.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Collections.Generic.KeyNotFoundException">Свойство получено и параметр <paramref name="key" /> не найден.</exception>
		// Token: 0x17001100 RID: 4352
		public TValue this[TKey key]
		{
			get
			{
				return this.m_dictionary[key];
			}
		}

		// Token: 0x0600605D RID: 24669 RVA: 0x0013B5A5 File Offset: 0x001397A5
		void IDictionary<!0, !1>.Add(TKey key, TValue value)
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		// Token: 0x0600605E RID: 24670 RVA: 0x0013B5A5 File Offset: 0x001397A5
		bool IDictionary<!0, !1>.Remove(TKey key)
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		// Token: 0x17001101 RID: 4353
		TValue IDictionary<!0, !1>.this[TKey key]
		{
			get
			{
				return this.m_dictionary[key];
			}
			set
			{
				throw new NotSupportedException("Collection is read-only.");
			}
		}

		/// <summary>Получает количество элементов в словаре.</summary>
		/// <returns>Количество элементов словаря.</returns>
		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x06006061 RID: 24673 RVA: 0x00142EE2 File Offset: 0x001410E2
		public int Count
		{
			get
			{
				return this.m_dictionary.Count;
			}
		}

		// Token: 0x06006062 RID: 24674 RVA: 0x00142EEF File Offset: 0x001410EF
		bool ICollection<KeyValuePair<!0, !1>>.Contains(KeyValuePair<TKey, TValue> item)
		{
			return this.m_dictionary.Contains(item);
		}

		// Token: 0x06006063 RID: 24675 RVA: 0x00142EFD File Offset: 0x001410FD
		void ICollection<KeyValuePair<!0, !1>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			this.m_dictionary.CopyTo(array, arrayIndex);
		}

		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x06006064 RID: 24676 RVA: 0x000040F7 File Offset: 0x000022F7
		bool ICollection<KeyValuePair<!0, !1>>.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06006065 RID: 24677 RVA: 0x0013B5A5 File Offset: 0x001397A5
		void ICollection<KeyValuePair<!0, !1>>.Add(KeyValuePair<TKey, TValue> item)
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		// Token: 0x06006066 RID: 24678 RVA: 0x0013B5A5 File Offset: 0x001397A5
		void ICollection<KeyValuePair<!0, !1>>.Clear()
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		// Token: 0x06006067 RID: 24679 RVA: 0x0013B5A5 File Offset: 0x001397A5
		bool ICollection<KeyValuePair<!0, !1>>.Remove(KeyValuePair<TKey, TValue> item)
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		/// <summary>Возвращает перечислитель, осуществляющий перебор элементов списка <see cref="T:System.Collections.ObjectModel.ReadOnlyDictionary`2" />.</summary>
		/// <returns>Перечислитель, который можно использовать для итерации по коллекции.</returns>
		// Token: 0x06006068 RID: 24680 RVA: 0x00142F0C File Offset: 0x0014110C
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return this.m_dictionary.GetEnumerator();
		}

		/// <summary>Возвращает перечислитель, который осуществляет итерацию по коллекции.</summary>
		/// <returns>Перечислитель, который можно использовать для итерации по коллекции.</returns>
		// Token: 0x06006069 RID: 24681 RVA: 0x00142F19 File Offset: 0x00141119
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.m_dictionary.GetEnumerator();
		}

		// Token: 0x0600606A RID: 24682 RVA: 0x00142F26 File Offset: 0x00141126
		private static bool IsCompatibleKey(object key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			return key is TKey;
		}

		/// <summary>Вызывает исключение <see cref="T:System.NotSupportedException" /> во всех случаях.</summary>
		/// <param name="key">Ключ добавляемого элемента.</param>
		/// <param name="value">Добавляемое значение элемента.</param>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x0600606B RID: 24683 RVA: 0x0013B5A5 File Offset: 0x001397A5
		void IDictionary.Add(object key, object value)
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		/// <summary>Вызывает исключение <see cref="T:System.NotSupportedException" /> во всех случаях.</summary>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x0600606C RID: 24684 RVA: 0x0013B5A5 File Offset: 0x001397A5
		void IDictionary.Clear()
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		/// <summary>Определяет, содержится ли в словаре элемент с указанным ключом.</summary>
		/// <param name="key">Ключ, который нужно найти в словаре.</param>
		/// <returns>Значение <see langword="true" />, если словарь содержит элемент с указанным ключом; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		// Token: 0x0600606D RID: 24685 RVA: 0x00142F3F File Offset: 0x0014113F
		bool IDictionary.Contains(object key)
		{
			return ReadOnlyDictionary<TKey, TValue>.IsCompatibleKey(key) && this.ContainsKey((TKey)((object)key));
		}

		/// <summary>Возвращает перечислитель для словаря.</summary>
		/// <returns>Перечислитель для словаря.</returns>
		// Token: 0x0600606E RID: 24686 RVA: 0x00142F58 File Offset: 0x00141158
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			IDictionary dictionary = this.m_dictionary as IDictionary;
			if (dictionary != null)
			{
				return dictionary.GetEnumerator();
			}
			return new ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator(this.m_dictionary);
		}

		/// <summary>Получает значение, указывающее, имеет ли словарь фиксированный размер.</summary>
		/// <returns>Значение <see langword="true" />, если словарь имеет фиксированный размер; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17001104 RID: 4356
		// (get) Token: 0x0600606F RID: 24687 RVA: 0x000040F7 File Offset: 0x000022F7
		bool IDictionary.IsFixedSize
		{
			get
			{
				return true;
			}
		}

		/// <summary>Получает значение, указывающее, действительно ли словарь доступен только для чтения.</summary>
		/// <returns>Значение <see langword="true" /> во всех случаях.</returns>
		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x06006070 RID: 24688 RVA: 0x000040F7 File Offset: 0x000022F7
		bool IDictionary.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		/// <summary>Получает коллекцию, содержащую ключи словаря.</summary>
		/// <returns>Коллекция, содержащая ключи словаря.</returns>
		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x06006071 RID: 24689 RVA: 0x00142EB5 File Offset: 0x001410B5
		ICollection IDictionary.Keys
		{
			get
			{
				return this.Keys;
			}
		}

		/// <summary>Вызывает исключение <see cref="T:System.NotSupportedException" /> во всех случаях.</summary>
		/// <param name="key">Ключ элемента, который требуется удалить.</param>
		/// <exception cref="T:System.NotSupportedException">Во всех случаях.</exception>
		// Token: 0x06006072 RID: 24690 RVA: 0x0013B5A5 File Offset: 0x001397A5
		void IDictionary.Remove(object key)
		{
			throw new NotSupportedException("Collection is read-only.");
		}

		/// <summary>Возвращает коллекцию, содержащую значения словаря.</summary>
		/// <returns>Коллекция, содержащая значения словаря.</returns>
		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x06006073 RID: 24691 RVA: 0x00142ECC File Offset: 0x001410CC
		ICollection IDictionary.Values
		{
			get
			{
				return this.Values;
			}
		}

		/// <summary>Получает элемент с указанным ключом.</summary>
		/// <param name="key">Ключ элемента, который требуется получить или задать.</param>
		/// <returns>Элемент с указанным ключом.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Свойство установлено.  
		/// -или- 
		/// Свойство установлено, ключ <paramref name="key" /> не существует в коллекции и словарь имеет фиксированный размер.</exception>
		// Token: 0x17001108 RID: 4360
		object IDictionary.this[object key]
		{
			get
			{
				if (ReadOnlyDictionary<TKey, TValue>.IsCompatibleKey(key))
				{
					return this[(TKey)((object)key)];
				}
				return null;
			}
			set
			{
				throw new NotSupportedException("Collection is read-only.");
			}
		}

		/// <summary>Копирует элементы словаря в массив, начиная с указанного индекса массива.</summary>
		/// <param name="array">Одномерный массив, в который копируются элементы словаря. Индекс в массиве должен начинаться с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		/// -или- 
		/// Число элементов исходного словаря превышает размер доступного места от индекса <paramref name="index" /> до конца массива <paramref name="array" />.  
		/// -или- 
		/// Тип исходного словаря невозможно автоматически привести к типу целевого массива <paramref name="array" />.</exception>
		// Token: 0x06006076 RID: 24694 RVA: 0x00142FA8 File Offset: 0x001411A8
		void ICollection.CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (array.Rank != 1)
			{
				throw new ArgumentException("Only single dimensional arrays are supported for the requested action.");
			}
			if (array.GetLowerBound(0) != 0)
			{
				throw new ArgumentException("The lower bound of target array must be zero.");
			}
			if (index < 0 || index > array.Length)
			{
				throw new ArgumentOutOfRangeException("index", "Non-negative number required.");
			}
			if (array.Length - index < this.Count)
			{
				throw new ArgumentException("Destination array is not long enough to copy all the items in the collection. Check array index and length.");
			}
			KeyValuePair<TKey, TValue>[] array2 = array as KeyValuePair<TKey, TValue>[];
			if (array2 != null)
			{
				this.m_dictionary.CopyTo(array2, index);
				return;
			}
			DictionaryEntry[] array3 = array as DictionaryEntry[];
			if (array3 != null)
			{
				using (IEnumerator<KeyValuePair<TKey, TValue>> enumerator = this.m_dictionary.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<TKey, TValue> keyValuePair = enumerator.Current;
						array3[index++] = new DictionaryEntry(keyValuePair.Key, keyValuePair.Value);
					}
					return;
				}
			}
			object[] array4 = array as object[];
			if (array4 == null)
			{
				throw new ArgumentException("Target array type is not compatible with the type of items in the collection.");
			}
			try
			{
				foreach (KeyValuePair<TKey, TValue> keyValuePair2 in this.m_dictionary)
				{
					array4[index++] = new KeyValuePair<TKey, TValue>(keyValuePair2.Key, keyValuePair2.Value);
				}
			}
			catch (ArrayTypeMismatchException)
			{
				throw new ArgumentException("Target array type is not compatible with the type of items in the collection.");
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли доступ к словарю синхронизированным (потокобезопасным).</summary>
		/// <returns>Значение <see langword="true" />, если доступ к словарю является синхронизированным (потокобезопасным); в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x06006077 RID: 24695 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает объект, который можно использовать для синхронизации доступа к словарю.</summary>
		/// <returns>Объект, который можно использовать для синхронизации доступа к словарю.</returns>
		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x06006078 RID: 24696 RVA: 0x00143130 File Offset: 0x00141330
		object ICollection.SyncRoot
		{
			get
			{
				if (this._syncRoot == null)
				{
					ICollection collection = this.m_dictionary as ICollection;
					if (collection != null)
					{
						this._syncRoot = collection.SyncRoot;
					}
					else
					{
						Interlocked.CompareExchange<object>(ref this._syncRoot, new object(), null);
					}
				}
				return this._syncRoot;
			}
		}

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x06006079 RID: 24697 RVA: 0x00142EB5 File Offset: 0x001410B5
		IEnumerable<TKey> IReadOnlyDictionary<!0, !1>.Keys
		{
			get
			{
				return this.Keys;
			}
		}

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x0600607A RID: 24698 RVA: 0x00142ECC File Offset: 0x001410CC
		IEnumerable<TValue> IReadOnlyDictionary<!0, !1>.Values
		{
			get
			{
				return this.Values;
			}
		}

		// Token: 0x040039B1 RID: 14769
		private readonly IDictionary<TKey, TValue> m_dictionary;

		// Token: 0x040039B2 RID: 14770
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x040039B3 RID: 14771
		[NonSerialized]
		private ReadOnlyDictionary<TKey, TValue>.KeyCollection _keys;

		// Token: 0x040039B4 RID: 14772
		[NonSerialized]
		private ReadOnlyDictionary<TKey, TValue>.ValueCollection _values;

		// Token: 0x02000A84 RID: 2692
		[Serializable]
		private struct DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x0600607B RID: 24699 RVA: 0x0014317A File Offset: 0x0014137A
			public DictionaryEnumerator(IDictionary<TKey, TValue> dictionary)
			{
				this._dictionary = dictionary;
				this._enumerator = this._dictionary.GetEnumerator();
			}

			// Token: 0x1700110D RID: 4365
			// (get) Token: 0x0600607C RID: 24700 RVA: 0x00143194 File Offset: 0x00141394
			public DictionaryEntry Entry
			{
				get
				{
					KeyValuePair<TKey, TValue> keyValuePair = this._enumerator.Current;
					object key = keyValuePair.Key;
					keyValuePair = this._enumerator.Current;
					return new DictionaryEntry(key, keyValuePair.Value);
				}
			}

			// Token: 0x1700110E RID: 4366
			// (get) Token: 0x0600607D RID: 24701 RVA: 0x001431D8 File Offset: 0x001413D8
			public object Key
			{
				get
				{
					KeyValuePair<TKey, TValue> keyValuePair = this._enumerator.Current;
					return keyValuePair.Key;
				}
			}

			// Token: 0x1700110F RID: 4367
			// (get) Token: 0x0600607E RID: 24702 RVA: 0x00143200 File Offset: 0x00141400
			public object Value
			{
				get
				{
					KeyValuePair<TKey, TValue> keyValuePair = this._enumerator.Current;
					return keyValuePair.Value;
				}
			}

			// Token: 0x17001110 RID: 4368
			// (get) Token: 0x0600607F RID: 24703 RVA: 0x00143225 File Offset: 0x00141425
			public object Current
			{
				get
				{
					return this.Entry;
				}
			}

			// Token: 0x06006080 RID: 24704 RVA: 0x00143232 File Offset: 0x00141432
			public bool MoveNext()
			{
				return this._enumerator.MoveNext();
			}

			// Token: 0x06006081 RID: 24705 RVA: 0x0014323F File Offset: 0x0014143F
			public void Reset()
			{
				this._enumerator.Reset();
			}

			// Token: 0x040039B5 RID: 14773
			private readonly IDictionary<TKey, TValue> _dictionary;

			// Token: 0x040039B6 RID: 14774
			private IEnumerator<KeyValuePair<TKey, TValue>> _enumerator;
		}

		/// <summary>Представляет доступную только для чтения коллекцию ключей объекта <see cref="T:System.Collections.ObjectModel.ReadOnlyDictionary`2" />.</summary>
		/// <typeparam name="TKey" />
		/// <typeparam name="TValue" />
		// Token: 0x02000A85 RID: 2693
		[DebuggerDisplay("Count = {Count}")]
		[DebuggerTypeProxy(typeof(CollectionDebugView<>))]
		[Serializable]
		public sealed class KeyCollection : ICollection<!0>, IEnumerable<!0>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
		{
			// Token: 0x06006082 RID: 24706 RVA: 0x0014324C File Offset: 0x0014144C
			internal KeyCollection(ICollection<TKey> collection)
			{
				if (collection == null)
				{
					throw new ArgumentNullException("collection");
				}
				this._collection = collection;
			}

			// Token: 0x06006083 RID: 24707 RVA: 0x0013B5A5 File Offset: 0x001397A5
			void ICollection<!0>.Add(TKey item)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06006084 RID: 24708 RVA: 0x0013B5A5 File Offset: 0x001397A5
			void ICollection<!0>.Clear()
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06006085 RID: 24709 RVA: 0x00143269 File Offset: 0x00141469
			bool ICollection<!0>.Contains(TKey item)
			{
				return this._collection.Contains(item);
			}

			/// <summary>Копирует элементы коллекции в массив, начиная с указанного индекса массива.</summary>
			/// <param name="array">Одномерный массив, куда копируются элементы из данной коллекции. Индекс в массиве должен начинаться с нуля.</param>
			/// <param name="arrayIndex">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
			/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
			/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="arrayIndex" /> меньше 0.</exception>
			/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
			///
			/// или - 
			/// Количество элементов исходной коллекции превышает размер доступного места от <paramref name="arrayIndex" /> до конца целевого массива <paramref name="array" />.  
			///
			/// или - 
			/// Тип <paramref name="T" /> не может быть автоматически приведен к типу целевого массива <paramref name="array" />.</exception>
			// Token: 0x06006086 RID: 24710 RVA: 0x00143277 File Offset: 0x00141477
			public void CopyTo(TKey[] array, int arrayIndex)
			{
				this._collection.CopyTo(array, arrayIndex);
			}

			/// <summary>Возвращает количество элементов в коллекции.</summary>
			/// <returns>Количество элементов в коллекции.</returns>
			// Token: 0x17001111 RID: 4369
			// (get) Token: 0x06006087 RID: 24711 RVA: 0x00143286 File Offset: 0x00141486
			public int Count
			{
				get
				{
					return this._collection.Count;
				}
			}

			// Token: 0x17001112 RID: 4370
			// (get) Token: 0x06006088 RID: 24712 RVA: 0x000040F7 File Offset: 0x000022F7
			bool ICollection<!0>.IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x06006089 RID: 24713 RVA: 0x0013B5A5 File Offset: 0x001397A5
			bool ICollection<!0>.Remove(TKey item)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			/// <summary>Возвращает перечислитель, выполняющий перебор элементов в коллекции.</summary>
			/// <returns>Перечислитель, который можно использовать для итерации по коллекции.</returns>
			// Token: 0x0600608A RID: 24714 RVA: 0x00143293 File Offset: 0x00141493
			public IEnumerator<TKey> GetEnumerator()
			{
				return this._collection.GetEnumerator();
			}

			/// <summary>Возвращает перечислитель, выполняющий перебор элементов в коллекции.</summary>
			/// <returns>Перечислитель, который можно использовать для итерации по коллекции.</returns>
			// Token: 0x0600608B RID: 24715 RVA: 0x001432A0 File Offset: 0x001414A0
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this._collection.GetEnumerator();
			}

			/// <summary>Копирует элементы коллекции в массив, начиная с указанного индекса массива.</summary>
			/// <param name="array">Одномерный массив, куда копируются элементы из данной коллекции. Индекс в массиве должен начинаться с нуля.</param>
			/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
			/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
			/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.</exception>
			/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
			///
			/// или - 
			/// Количество элементов исходной коллекции превышает размер доступного места от <paramref name="index" /> до конца целевого массива <paramref name="array" />.</exception>
			// Token: 0x0600608C RID: 24716 RVA: 0x001432AD File Offset: 0x001414AD
			void ICollection.CopyTo(Array array, int index)
			{
				ReadOnlyDictionaryHelpers.CopyToNonGenericICollectionHelper<TKey>(this._collection, array, index);
			}

			/// <summary>Получает значение, указывающее, является ли доступ к коллекции синхронизированным (потокобезопасным).</summary>
			/// <returns>Значение <see langword="true" />, если доступ к коллекции является синхронизированным (потокобезопасным); в противном случае — значение <see langword="false" />.</returns>
			// Token: 0x17001113 RID: 4371
			// (get) Token: 0x0600608D RID: 24717 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			/// <summary>Возвращает объект, который можно использовать для синхронизации доступа к коллекции.</summary>
			/// <returns>Объект, который можно использовать для синхронизации доступа к коллекции.</returns>
			// Token: 0x17001114 RID: 4372
			// (get) Token: 0x0600608E RID: 24718 RVA: 0x001432BC File Offset: 0x001414BC
			object ICollection.SyncRoot
			{
				get
				{
					if (this._syncRoot == null)
					{
						ICollection collection = this._collection as ICollection;
						if (collection != null)
						{
							this._syncRoot = collection.SyncRoot;
						}
						else
						{
							Interlocked.CompareExchange<object>(ref this._syncRoot, new object(), null);
						}
					}
					return this._syncRoot;
				}
			}

			// Token: 0x0600608F RID: 24719 RVA: 0x000173AD File Offset: 0x000155AD
			internal KeyCollection()
			{
				ThrowStub.ThrowNotSupportedException();
			}

			// Token: 0x040039B7 RID: 14775
			private readonly ICollection<TKey> _collection;

			// Token: 0x040039B8 RID: 14776
			[NonSerialized]
			private object _syncRoot;
		}

		/// <summary>Представляет доступную только для чтения коллекцию значений объекта <see cref="T:System.Collections.ObjectModel.ReadOnlyDictionary`2" />.</summary>
		/// <typeparam name="TKey" />
		/// <typeparam name="TValue" />
		// Token: 0x02000A86 RID: 2694
		[DebuggerTypeProxy(typeof(CollectionDebugView<>))]
		[DebuggerDisplay("Count = {Count}")]
		[Serializable]
		public sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
		{
			// Token: 0x06006090 RID: 24720 RVA: 0x00143306 File Offset: 0x00141506
			internal ValueCollection(ICollection<TValue> collection)
			{
				if (collection == null)
				{
					throw new ArgumentNullException("collection");
				}
				this._collection = collection;
			}

			// Token: 0x06006091 RID: 24721 RVA: 0x0013B5A5 File Offset: 0x001397A5
			void ICollection<!1>.Add(TValue item)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06006092 RID: 24722 RVA: 0x0013B5A5 File Offset: 0x001397A5
			void ICollection<!1>.Clear()
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06006093 RID: 24723 RVA: 0x00143323 File Offset: 0x00141523
			bool ICollection<!1>.Contains(TValue item)
			{
				return this._collection.Contains(item);
			}

			/// <summary>Копирует элементы коллекции в массив, начиная с указанного индекса массива.</summary>
			/// <param name="array">Одномерный массив, куда копируются элементы из данной коллекции. Индекс в массиве должен начинаться с нуля.</param>
			/// <param name="arrayIndex">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
			/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
			/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="arrayIndex" /> меньше 0.</exception>
			/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
			///
			/// или - 
			/// Количество элементов исходной коллекции превышает размер доступного места от <paramref name="arrayIndex" /> до конца целевого массива <paramref name="array" />.  
			///
			/// или - 
			/// Тип <paramref name="T" /> не может быть автоматически приведен к типу целевого массива <paramref name="array" />.</exception>
			// Token: 0x06006094 RID: 24724 RVA: 0x00143331 File Offset: 0x00141531
			public void CopyTo(TValue[] array, int arrayIndex)
			{
				this._collection.CopyTo(array, arrayIndex);
			}

			/// <summary>Возвращает количество элементов в коллекции.</summary>
			/// <returns>Количество элементов в коллекции.</returns>
			// Token: 0x17001115 RID: 4373
			// (get) Token: 0x06006095 RID: 24725 RVA: 0x00143340 File Offset: 0x00141540
			public int Count
			{
				get
				{
					return this._collection.Count;
				}
			}

			// Token: 0x17001116 RID: 4374
			// (get) Token: 0x06006096 RID: 24726 RVA: 0x000040F7 File Offset: 0x000022F7
			bool ICollection<!1>.IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x06006097 RID: 24727 RVA: 0x0013B5A5 File Offset: 0x001397A5
			bool ICollection<!1>.Remove(TValue item)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			/// <summary>Возвращает перечислитель, выполняющий перебор элементов в коллекции.</summary>
			/// <returns>Перечислитель, который можно использовать для итерации по коллекции.</returns>
			// Token: 0x06006098 RID: 24728 RVA: 0x0014334D File Offset: 0x0014154D
			public IEnumerator<TValue> GetEnumerator()
			{
				return this._collection.GetEnumerator();
			}

			/// <summary>Возвращает перечислитель, выполняющий перебор элементов в коллекции.</summary>
			/// <returns>Перечислитель, который можно использовать для итерации по коллекции.</returns>
			// Token: 0x06006099 RID: 24729 RVA: 0x0014335A File Offset: 0x0014155A
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this._collection.GetEnumerator();
			}

			/// <summary>Копирует элементы коллекции в массив, начиная с указанного индекса массива.</summary>
			/// <param name="array">Одномерный массив, куда копируются элементы из данной коллекции. Индекс в массиве должен начинаться с нуля.</param>
			/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
			/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
			/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.</exception>
			/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
			///
			/// или - 
			/// Количество элементов исходной коллекции превышает размер доступного места от <paramref name="index" /> до конца целевого массива <paramref name="array" />.</exception>
			// Token: 0x0600609A RID: 24730 RVA: 0x00143367 File Offset: 0x00141567
			void ICollection.CopyTo(Array array, int index)
			{
				ReadOnlyDictionaryHelpers.CopyToNonGenericICollectionHelper<TValue>(this._collection, array, index);
			}

			/// <summary>Получает значение, указывающее, является ли доступ к коллекции синхронизированным (потокобезопасным).</summary>
			/// <returns>Значение <see langword="true" />, если доступ к коллекции является синхронизированным (потокобезопасным); в противном случае — значение <see langword="false" />.</returns>
			// Token: 0x17001117 RID: 4375
			// (get) Token: 0x0600609B RID: 24731 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			/// <summary>Возвращает объект, который можно использовать для синхронизации доступа к коллекции.</summary>
			/// <returns>Объект, который можно использовать для синхронизации доступа к коллекции.</returns>
			// Token: 0x17001118 RID: 4376
			// (get) Token: 0x0600609C RID: 24732 RVA: 0x00143378 File Offset: 0x00141578
			object ICollection.SyncRoot
			{
				get
				{
					if (this._syncRoot == null)
					{
						ICollection collection = this._collection as ICollection;
						if (collection != null)
						{
							this._syncRoot = collection.SyncRoot;
						}
						else
						{
							Interlocked.CompareExchange<object>(ref this._syncRoot, new object(), null);
						}
					}
					return this._syncRoot;
				}
			}

			// Token: 0x0600609D RID: 24733 RVA: 0x000173AD File Offset: 0x000155AD
			internal ValueCollection()
			{
				ThrowStub.ThrowNotSupportedException();
			}

			// Token: 0x040039B9 RID: 14777
			private readonly ICollection<TValue> _collection;

			// Token: 0x040039BA RID: 14778
			[NonSerialized]
			private object _syncRoot;
		}
	}
}
