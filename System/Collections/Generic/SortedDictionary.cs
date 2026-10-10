using System;
using System.Diagnostics;

namespace System.Collections.Generic
{
	/// <summary>Представляет коллекцию пар «ключ-значение», упорядоченных по ключу.</summary>
	/// <typeparam name="TKey">Тип ключей в словаре.</typeparam>
	/// <typeparam name="TValue">Тип значений в словаре.</typeparam>
	// Token: 0x020004CD RID: 1229
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(IDictionaryDebugView<, >))]
	[Serializable]
	public class SortedDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<!0, !1>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>
	{
		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Generic.SortedDictionary`2" />, использующий реализацию <see cref="T:System.Collections.Generic.IComparer`1" /> по умолчанию для типа ключа.</summary>
		// Token: 0x060027D6 RID: 10198 RVA: 0x00089CC1 File Offset: 0x00087EC1
		public SortedDictionary() : this(null)
		{
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Collections.Generic.SortedDictionary`2" />, который содержит элементы, скопированные из указанного словаря <see cref="T:System.Collections.Generic.IDictionary`2" />, и использует для типа ключа реализацию <see cref="T:System.Collections.Generic.IComparer`1" /> по умолчанию.</summary>
		/// <param name="dictionary">Объект <see cref="T:System.Collections.Generic.IDictionary`2" />, элементы которого копируются в новый объект <see cref="T:System.Collections.Generic.SortedDictionary`2" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="dictionary" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="dictionary" /> содержит один или несколько ключей-дубликатов.</exception>
		// Token: 0x060027D7 RID: 10199 RVA: 0x00089CCA File Offset: 0x00087ECA
		public SortedDictionary(IDictionary<TKey, TValue> dictionary) : this(dictionary, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Collections.Generic.SortedDictionary`2" />, который содержит элементы, скопированные из указанного словаря <see cref="T:System.Collections.Generic.IDictionary`2" />, и использует для сравнения ключей указанную реализацию <see cref="T:System.Collections.Generic.IComparer`1" />.</summary>
		/// <param name="dictionary">Объект <see cref="T:System.Collections.Generic.IDictionary`2" />, элементы которого копируются в новый объект <see cref="T:System.Collections.Generic.SortedDictionary`2" />.</param>
		/// <param name="comparer">Реализация <see cref="T:System.Collections.Generic.IComparer`1" />, которую следует использовать при сравнении ключей, или <see langword="null" />, если для данного типа ключа должна использоваться реализация <see cref="T:System.Collections.Generic.Comparer`1" /> по умолчанию.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="dictionary" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="dictionary" /> содержит один или несколько ключей-дубликатов.</exception>
		// Token: 0x060027D8 RID: 10200 RVA: 0x00089CD4 File Offset: 0x00087ED4
		public SortedDictionary(IDictionary<TKey, TValue> dictionary, IComparer<TKey> comparer)
		{
			if (dictionary == null)
			{
				throw new ArgumentNullException("dictionary");
			}
			this._set = new TreeSet<KeyValuePair<TKey, TValue>>(new SortedDictionary<TKey, TValue>.KeyValuePairComparer(comparer));
			foreach (KeyValuePair<TKey, TValue> item in dictionary)
			{
				this._set.Add(item);
			}
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Generic.SortedDictionary`2" />, использующий для сравнения ключей указанную реализацию <see cref="T:System.Collections.Generic.IComparer`1" />.</summary>
		/// <param name="comparer">Реализация <see cref="T:System.Collections.Generic.IComparer`1" />, которую следует использовать при сравнении ключей, или <see langword="null" />, если для данного типа ключа должна использоваться реализация <see cref="T:System.Collections.Generic.Comparer`1" /> по умолчанию.</param>
		// Token: 0x060027D9 RID: 10201 RVA: 0x00089D48 File Offset: 0x00087F48
		public SortedDictionary(IComparer<TKey> comparer)
		{
			this._set = new TreeSet<KeyValuePair<TKey, TValue>>(new SortedDictionary<TKey, TValue>.KeyValuePairComparer(comparer));
		}

		// Token: 0x060027DA RID: 10202 RVA: 0x00089D61 File Offset: 0x00087F61
		void ICollection<KeyValuePair<!0, !1>>.Add(KeyValuePair<TKey, TValue> keyValuePair)
		{
			this._set.Add(keyValuePair);
		}

		// Token: 0x060027DB RID: 10203 RVA: 0x00089D70 File Offset: 0x00087F70
		bool ICollection<KeyValuePair<!0, !1>>.Contains(KeyValuePair<TKey, TValue> keyValuePair)
		{
			SortedSet<KeyValuePair<TKey, TValue>>.Node node = this._set.FindNode(keyValuePair);
			if (node == null)
			{
				return false;
			}
			if (keyValuePair.Value == null)
			{
				return node.Item.Value == null;
			}
			return EqualityComparer<TValue>.Default.Equals(node.Item.Value, keyValuePair.Value);
		}

		// Token: 0x060027DC RID: 10204 RVA: 0x00089DD4 File Offset: 0x00087FD4
		bool ICollection<KeyValuePair<!0, !1>>.Remove(KeyValuePair<TKey, TValue> keyValuePair)
		{
			SortedSet<KeyValuePair<TKey, TValue>>.Node node = this._set.FindNode(keyValuePair);
			if (node == null)
			{
				return false;
			}
			if (EqualityComparer<TValue>.Default.Equals(node.Item.Value, keyValuePair.Value))
			{
				this._set.Remove(keyValuePair);
				return true;
			}
			return false;
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x060027DD RID: 10205 RVA: 0x00003062 File Offset: 0x00001262
		bool ICollection<KeyValuePair<!0, !1>>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает или задает значение, связанное с указанным ключом.</summary>
		/// <param name="key">Ключ, значение которого требуется получить или задать.</param>
		/// <returns>Значение, связанное с указанным ключом. Если указанный ключ не найден, операция получения создает исключение <see cref="T:System.Collections.Generic.KeyNotFoundException" />, а операция задания значения создает новый элемент с указанным ключом.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Collections.Generic.KeyNotFoundException">Свойство получено, а <paramref name="key" /> не существует в коллекции.</exception>
		// Token: 0x17000824 RID: 2084
		public TValue this[TKey key]
		{
			get
			{
				if (key == null)
				{
					throw new ArgumentNullException("key");
				}
				SortedSet<KeyValuePair<TKey, TValue>>.Node node = this._set.FindNode(new KeyValuePair<TKey, TValue>(key, default(TValue)));
				if (node == null)
				{
					throw new KeyNotFoundException(SR.Format("The given key '{0}' was not present in the dictionary.", key.ToString()));
				}
				return node.Item.Value;
			}
			set
			{
				if (key == null)
				{
					throw new ArgumentNullException("key");
				}
				SortedSet<KeyValuePair<TKey, TValue>>.Node node = this._set.FindNode(new KeyValuePair<TKey, TValue>(key, default(TValue)));
				if (node == null)
				{
					this._set.Add(new KeyValuePair<TKey, TValue>(key, value));
					return;
				}
				node.Item = new KeyValuePair<TKey, TValue>(node.Item.Key, value);
				this._set.UpdateVersion();
			}
		}

		/// <summary>Возвращает число пар "ключ-значение", содержащихся в словаре <see cref="T:System.Collections.Generic.SortedDictionary`2" />.</summary>
		/// <returns>Число пар "ключ-значение", содержащихся в словаре <see cref="T:System.Collections.Generic.SortedDictionary`2" />.</returns>
		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x060027E0 RID: 10208 RVA: 0x00089F03 File Offset: 0x00088103
		public int Count
		{
			get
			{
				return this._set.Count;
			}
		}

		/// <summary>Возвращает интерфейс <see cref="T:System.Collections.Generic.IComparer`1" />, используемый для упорядочения элементов словаря <see cref="T:System.Collections.Generic.SortedDictionary`2" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.Generic.IComparer`1" />, используемый для упорядочения элементов словаря <see cref="T:System.Collections.Generic.SortedDictionary`2" />.</returns>
		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x060027E1 RID: 10209 RVA: 0x00089F10 File Offset: 0x00088110
		public IComparer<TKey> Comparer
		{
			get
			{
				return ((SortedDictionary<TKey, TValue>.KeyValuePairComparer)this._set.Comparer).keyComparer;
			}
		}

		/// <summary>Возвращает коллекцию, содержащую ключи из словаря <see cref="T:System.Collections.Generic.SortedDictionary`2" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.Generic.SortedDictionary`2.KeyCollection" />, содержащий ключи из <see cref="T:System.Collections.Generic.SortedDictionary`2" />.</returns>
		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x060027E2 RID: 10210 RVA: 0x00089F27 File Offset: 0x00088127
		public SortedDictionary<TKey, TValue>.KeyCollection Keys
		{
			get
			{
				if (this._keys == null)
				{
					this._keys = new SortedDictionary<TKey, TValue>.KeyCollection(this);
				}
				return this._keys;
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x060027E3 RID: 10211 RVA: 0x00089F43 File Offset: 0x00088143
		ICollection<TKey> IDictionary<!0, !1>.Keys
		{
			get
			{
				return this.Keys;
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x060027E4 RID: 10212 RVA: 0x00089F43 File Offset: 0x00088143
		IEnumerable<TKey> IReadOnlyDictionary<!0, !1>.Keys
		{
			get
			{
				return this.Keys;
			}
		}

		/// <summary>Возвращает коллекцию, содержащую значения из словаря <see cref="T:System.Collections.Generic.SortedDictionary`2" />.</summary>
		/// <returns>Коллекция <see cref="T:System.Collections.Generic.SortedDictionary`2.ValueCollection" />, содержащая значения из словаря <see cref="T:System.Collections.Generic.SortedDictionary`2" />.</returns>
		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x060027E5 RID: 10213 RVA: 0x00089F4B File Offset: 0x0008814B
		public SortedDictionary<TKey, TValue>.ValueCollection Values
		{
			get
			{
				if (this._values == null)
				{
					this._values = new SortedDictionary<TKey, TValue>.ValueCollection(this);
				}
				return this._values;
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x060027E6 RID: 10214 RVA: 0x00089F67 File Offset: 0x00088167
		ICollection<TValue> IDictionary<!0, !1>.Values
		{
			get
			{
				return this.Values;
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x060027E7 RID: 10215 RVA: 0x00089F67 File Offset: 0x00088167
		IEnumerable<TValue> IReadOnlyDictionary<!0, !1>.Values
		{
			get
			{
				return this.Values;
			}
		}

		/// <summary>Добавляет элемент с указанными ключом и значением в словарь <see cref="T:System.Collections.Generic.SortedDictionary`2" />.</summary>
		/// <param name="key">Ключ добавляемого элемента.</param>
		/// <param name="value">Добавляемое значение элемента. Для ссылочных типов допускается значение <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Элемент с таким ключом уже существует в <see cref="T:System.Collections.Generic.SortedDictionary`2" />.</exception>
		// Token: 0x060027E8 RID: 10216 RVA: 0x00089F6F File Offset: 0x0008816F
		public void Add(TKey key, TValue value)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			this._set.Add(new KeyValuePair<TKey, TValue>(key, value));
		}

		/// <summary>Удаляет из коллекции <see cref="T:System.Collections.Generic.SortedDictionary`2" /> все элементы.</summary>
		// Token: 0x060027E9 RID: 10217 RVA: 0x00089F97 File Offset: 0x00088197
		public void Clear()
		{
			this._set.Clear();
		}

		/// <summary>Определяет, содержится ли элемент с указанным ключом в <see cref="T:System.Collections.Generic.SortedDictionary`2" />.</summary>
		/// <param name="key">Ключ, который требуется найти в <see cref="T:System.Collections.Generic.SortedDictionary`2" />.</param>
		/// <returns>
		///   <see langword="true" />, если <see cref="T:System.Collections.Generic.SortedDictionary`2" /> содержит элемент с указанным ключом, в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060027EA RID: 10218 RVA: 0x00089FA4 File Offset: 0x000881A4
		public bool ContainsKey(TKey key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			return this._set.Contains(new KeyValuePair<TKey, TValue>(key, default(TValue)));
		}

		/// <summary>Определяет, содержится ли элемент с указанным значением в словаре <see cref="T:System.Collections.Generic.SortedDictionary`2" />.</summary>
		/// <param name="value">Значение, которое требуется найти в словаре <see cref="T:System.Collections.Generic.SortedDictionary`2" />. Для ссылочных типов допускается значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Collections.Generic.SortedDictionary`2" /> содержит элемент с указанным значением; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060027EB RID: 10219 RVA: 0x00089FE0 File Offset: 0x000881E0
		public bool ContainsValue(TValue value)
		{
			bool found = false;
			if (value == null)
			{
				this._set.InOrderTreeWalk(delegate(SortedSet<KeyValuePair<TKey, TValue>>.Node node)
				{
					if (node.Item.Value == null)
					{
						found = true;
						return false;
					}
					return true;
				});
			}
			else
			{
				EqualityComparer<TValue> valueComparer = EqualityComparer<TValue>.Default;
				this._set.InOrderTreeWalk(delegate(SortedSet<KeyValuePair<TKey, TValue>>.Node node)
				{
					if (valueComparer.Equals(node.Item.Value, value))
					{
						found = true;
						return false;
					}
					return true;
				});
			}
			return found;
		}

		/// <summary>Копирует элементы словаря <see cref="T:System.Collections.Generic.SortedDictionary`2" /> в указанный массив структур <see cref="T:System.Collections.Generic.KeyValuePair`2" /> начиная с заданного индекса.</summary>
		/// <param name="array">Одномерный массив структур <see cref="T:System.Collections.Generic.KeyValuePair`2" />, в который копируются элементы из текущего словаря <see cref="T:System.Collections.Generic.SortedDictionary`2" />. Индексация массива должна начинаться с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.</exception>
		/// <exception cref="T:System.ArgumentException">Число элементов в исходной коллекции <see cref="T:System.Collections.Generic.SortedDictionary`2" /> больше доступного места от положения, заданного значением параметра <paramref name="index" />, до конца массива назначения <paramref name="array" />.</exception>
		// Token: 0x060027EC RID: 10220 RVA: 0x0008A05E File Offset: 0x0008825E
		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
			this._set.CopyTo(array, index);
		}

		/// <summary>Возвращает перечислитель, осуществляющий перебор элементов списка <see cref="T:System.Collections.Generic.SortedDictionary`2" />.</summary>
		/// <returns>Новый объект <see cref="T:System.Collections.Generic.SortedDictionary`2.Enumerator" /> для <see cref="T:System.Collections.Generic.SortedDictionary`2" />.</returns>
		// Token: 0x060027ED RID: 10221 RVA: 0x0008A06D File Offset: 0x0008826D
		public SortedDictionary<TKey, TValue>.Enumerator GetEnumerator()
		{
			return new SortedDictionary<TKey, TValue>.Enumerator(this, 1);
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x0008A076 File Offset: 0x00088276
		IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<!0, !1>>.GetEnumerator()
		{
			return new SortedDictionary<TKey, TValue>.Enumerator(this, 1);
		}

		/// <summary>Удаляет элемент с указанным ключом из <see cref="T:System.Collections.Generic.SortedDictionary`2" />.</summary>
		/// <param name="key">Ключ элемента, который требуется удалить.</param>
		/// <returns>Значение <see langword="true" />, если элемент успешно удален; в противном случае — значение <see langword="false" />.  Этот метод также возвращает <see langword="false" />, если элемент <paramref name="key" /> не найден в коллекции <see cref="T:System.Collections.Generic.SortedDictionary`2" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060027EF RID: 10223 RVA: 0x0008A084 File Offset: 0x00088284
		public bool Remove(TKey key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			return this._set.Remove(new KeyValuePair<TKey, TValue>(key, default(TValue)));
		}

		/// <summary>Возвращает значение, связанное с заданным ключом.</summary>
		/// <param name="key">Ключ значения, которое необходимо получить.</param>
		/// <param name="value">Этот метод возвращает значение, связанное с указанным ключом, если он найден; в противном случае — значение по умолчанию для данного типа параметра <paramref name="value" />.</param>
		/// <returns>
		///   <see langword="true" />, если <see cref="T:System.Collections.Generic.SortedDictionary`2" /> содержит элемент с указанным ключом, в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060027F0 RID: 10224 RVA: 0x0008A0C0 File Offset: 0x000882C0
		public bool TryGetValue(TKey key, out TValue value)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			SortedSet<KeyValuePair<TKey, TValue>>.Node node = this._set.FindNode(new KeyValuePair<TKey, TValue>(key, default(TValue)));
			if (node == null)
			{
				value = default(TValue);
				return false;
			}
			value = node.Item.Value;
			return true;
		}

		/// <summary>Копирует элементы коллекции <see cref="T:System.Collections.Generic.ICollection`1" /> в массив, начиная с указанного индекса массива.</summary>
		/// <param name="array">Одномерный массив, в который копируются элементы из коллекции <see cref="T:System.Collections.Generic.ICollection`1" />. Индекс в массиве должен начинаться с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		/// -или- 
		///  Массив <paramref name="array" /> не имеет индексации, начинающейся с нуля.  
		/// -или- 
		/// Число элементов в исходном массиве <see cref="T:System.Collections.Generic.ICollection`1" /> больше доступного места от положения, заданного значением параметра <paramref name="index" />, до конца массива назначения <paramref name="array" />.  
		/// -или- 
		/// Тип исходного массива <see cref="T:System.Collections.Generic.ICollection`1" /> не может быть автоматически приведен к типу массива назначения <paramref name="array" />.</exception>
		// Token: 0x060027F1 RID: 10225 RVA: 0x0008A11C File Offset: 0x0008831C
		void ICollection.CopyTo(Array array, int index)
		{
			((ICollection)this._set).CopyTo(array, index);
		}

		/// <summary>Получает значение, указывающее, имеет ли список <see cref="T:System.Collections.IDictionary" /> фиксированный размер.</summary>
		/// <returns>Значение <see langword="true" />, если словарь <see cref="T:System.Collections.IDictionary" /> имеет фиксированный размер; в противном случае — значение <see langword="false" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.Generic.SortedDictionary`2" /> это свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x060027F2 RID: 10226 RVA: 0x00003062 File Offset: 0x00001262
		bool IDictionary.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает значение, указывающее, является ли объект <see cref="T:System.Collections.IDictionary" /> доступным только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если интерфейс <see cref="T:System.Collections.IDictionary" /> доступен только для чтения; в противном случае — значение <see langword="false" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.Generic.SortedDictionary`2" /> это свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x060027F3 RID: 10227 RVA: 0x00003062 File Offset: 0x00001262
		bool IDictionary.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает интерфейс <see cref="T:System.Collections.ICollection" />, содержащий ключи <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.ICollection" />, содержащий ключи из <see cref="T:System.Collections.IDictionary" />.</returns>
		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x060027F4 RID: 10228 RVA: 0x00089F43 File Offset: 0x00088143
		ICollection IDictionary.Keys
		{
			get
			{
				return this.Keys;
			}
		}

		/// <summary>Возвращает интерфейс <see cref="T:System.Collections.ICollection" />, содержащий значения из <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <returns>Коллекция <see cref="T:System.Collections.ICollection" />, содержащая значения из словаря <see cref="T:System.Collections.IDictionary" />.</returns>
		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x060027F5 RID: 10229 RVA: 0x00089F67 File Offset: 0x00088167
		ICollection IDictionary.Values
		{
			get
			{
				return this.Values;
			}
		}

		/// <summary>Возвращает или задает элемент с указанным ключом.</summary>
		/// <param name="key">Ключ элемента, который требуется получить.</param>
		/// <returns>Элемент с указанным ключом или <see langword="null" />, если <paramref name="key" /> отсутствует в словаре или тип параметра <paramref name="key" /> не допускает присваивание типу ключа <paramref name="TKey" /> коллекции <see cref="T:System.Collections.Generic.SortedDictionary`2" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Назначаемое значение и параметр <paramref name="key" /> типа, который не может быть назначен типу ключа <paramref name="TKey" /> объекта <see cref="T:System.Collections.Generic.SortedDictionary`2" />.  
		/// -или- 
		/// Значение присваивается, при этом тип параметра <paramref name="value" /> не допускает присваивание типу значения <paramref name="TValue" /> объекту <see cref="T:System.Collections.Generic.SortedDictionary`2" />.</exception>
		// Token: 0x17000831 RID: 2097
		object IDictionary.this[object key]
		{
			get
			{
				TValue tvalue;
				if (SortedDictionary<TKey, TValue>.IsCompatibleKey(key) && this.TryGetValue((TKey)((object)key), out tvalue))
				{
					return tvalue;
				}
				return null;
			}
			set
			{
				if (key == null)
				{
					throw new ArgumentNullException("key");
				}
				if (value == null && default(TValue) != null)
				{
					throw new ArgumentNullException("value");
				}
				try
				{
					TKey key2 = (TKey)((object)key);
					try
					{
						this[key2] = (TValue)((object)value);
					}
					catch (InvalidCastException)
					{
						throw new ArgumentException(SR.Format("The value '{0}' is not of type '{1}' and cannot be used in this generic collection.", value, typeof(TValue)), "value");
					}
				}
				catch (InvalidCastException)
				{
					throw new ArgumentException(SR.Format("The value '{0}' is not of type '{1}' and cannot be used in this generic collection.", key, typeof(TKey)), "key");
				}
			}
		}

		/// <summary>Добавляет элемент с указанными ключом и значением в объект <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <param name="key">Объект, используемый в качестве ключа добавляемого элемента.</param>
		/// <param name="value">Объект, используемый в качестве значения добавляемого элемента.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="key" /> имеет тип, который не может быть назначен типу ключа <paramref name="TKey" /> объекта <see cref="T:System.Collections.IDictionary" />.  
		/// -или- 
		///  Параметр <paramref name="value" /> имеет тип, который не может быть назначен типу значения <paramref name="TValue" /> интерфейса <see cref="T:System.Collections.IDictionary" />.  
		/// -или- 
		/// Элемент с таким ключом уже существует в <see cref="T:System.Collections.IDictionary" />.</exception>
		// Token: 0x060027F8 RID: 10232 RVA: 0x0008A20C File Offset: 0x0008840C
		void IDictionary.Add(object key, object value)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			if (value == null && default(TValue) != null)
			{
				throw new ArgumentNullException("value");
			}
			try
			{
				TKey key2 = (TKey)((object)key);
				try
				{
					this.Add(key2, (TValue)((object)value));
				}
				catch (InvalidCastException)
				{
					throw new ArgumentException(SR.Format("The value '{0}' is not of type '{1}' and cannot be used in this generic collection.", value, typeof(TValue)), "value");
				}
			}
			catch (InvalidCastException)
			{
				throw new ArgumentException(SR.Format("The value '{0}' is not of type '{1}' and cannot be used in this generic collection.", key, typeof(TKey)), "key");
			}
		}

		/// <summary>Определяет, содержится ли элемент с указанным ключом в <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <param name="key">Ключ, который требуется найти в <see cref="T:System.Collections.IDictionary" />.</param>
		/// <returns>Значение <see langword="true" />, если в <see cref="T:System.Collections.IDictionary" /> содержится элемент с данным ключом; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060027F9 RID: 10233 RVA: 0x0008A2BC File Offset: 0x000884BC
		bool IDictionary.Contains(object key)
		{
			return SortedDictionary<TKey, TValue>.IsCompatibleKey(key) && this.ContainsKey((TKey)((object)key));
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x0008A2D4 File Offset: 0x000884D4
		private static bool IsCompatibleKey(object key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			return key is TKey;
		}

		/// <summary>Возвращает перечислитель <see cref="T:System.Collections.IDictionaryEnumerator" /> для словаря <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IDictionaryEnumerator" /> для <see cref="T:System.Collections.IDictionary" />.</returns>
		// Token: 0x060027FB RID: 10235 RVA: 0x0008A2ED File Offset: 0x000884ED
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return new SortedDictionary<TKey, TValue>.Enumerator(this, 2);
		}

		/// <summary>Удаляет элемент с указанным ключом из <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <param name="key">Ключ элемента, который требуется удалить.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060027FC RID: 10236 RVA: 0x0008A2FB File Offset: 0x000884FB
		void IDictionary.Remove(object key)
		{
			if (SortedDictionary<TKey, TValue>.IsCompatibleKey(key))
			{
				this.Remove((TKey)((object)key));
			}
		}

		/// <summary>Возвращает значение, показывающее, является ли доступ к коллекции <see cref="T:System.Collections.ICollection" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>
		///   <see langword="true" />, если доступ к классу <see cref="T:System.Collections.ICollection" /> является синхронизированным (потокобезопасным); в противном случае — <see langword="false" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.Generic.SortedDictionary`2" /> это свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x060027FD RID: 10237 RVA: 0x00003062 File Offset: 0x00001262
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.ICollection" />.</summary>
		/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Collections.ICollection" />.</returns>
		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x060027FE RID: 10238 RVA: 0x0008A312 File Offset: 0x00088512
		object ICollection.SyncRoot
		{
			get
			{
				return ((ICollection)this._set).SyncRoot;
			}
		}

		/// <summary>Возвращает перечислитель, выполняющий перебор элементов в коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для итерации элементов коллекции.</returns>
		// Token: 0x060027FF RID: 10239 RVA: 0x0008A076 File Offset: 0x00088276
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SortedDictionary<TKey, TValue>.Enumerator(this, 1);
		}

		// Token: 0x04001571 RID: 5489
		[NonSerialized]
		private SortedDictionary<TKey, TValue>.KeyCollection _keys;

		// Token: 0x04001572 RID: 5490
		[NonSerialized]
		private SortedDictionary<TKey, TValue>.ValueCollection _values;

		// Token: 0x04001573 RID: 5491
		private TreeSet<KeyValuePair<TKey, TValue>> _set;

		/// <summary>Выполняет перечисление элементов коллекции <see cref="T:System.Collections.Generic.SortedDictionary`2" />.</summary>
		/// <typeparam name="TKey" />
		/// <typeparam name="TValue" />
		// Token: 0x020004CE RID: 1230
		public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator
		{
			// Token: 0x06002800 RID: 10240 RVA: 0x0008A31F File Offset: 0x0008851F
			internal Enumerator(SortedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
			{
				this._treeEnum = dictionary._set.GetEnumerator();
				this._getEnumeratorRetType = getEnumeratorRetType;
			}

			/// <summary>Перемещает перечислитель к следующему элементу коллекции <see cref="T:System.Collections.Generic.SortedDictionary`2" />.</summary>
			/// <returns>Значение <see langword="true" />, если перечислитель был успешно перемещен к следующему элементу; значение <see langword="false" />, если перечислитель достиг конца коллекции.</returns>
			/// <exception cref="T:System.InvalidOperationException">После создания перечислителя семейство было изменено.</exception>
			// Token: 0x06002801 RID: 10241 RVA: 0x0008A339 File Offset: 0x00088539
			public bool MoveNext()
			{
				return this._treeEnum.MoveNext();
			}

			/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.Collections.Generic.SortedDictionary`2.Enumerator" />.</summary>
			// Token: 0x06002802 RID: 10242 RVA: 0x0008A346 File Offset: 0x00088546
			public void Dispose()
			{
				this._treeEnum.Dispose();
			}

			/// <summary>Возвращает элемент, расположенный в текущей позиции перечислителя.</summary>
			/// <returns>Элемент коллекции <see cref="T:System.Collections.Generic.SortedDictionary`2" />, находящийся в текущей позиции перечислителя.</returns>
			// Token: 0x17000834 RID: 2100
			// (get) Token: 0x06002803 RID: 10243 RVA: 0x0008A353 File Offset: 0x00088553
			public KeyValuePair<TKey, TValue> Current
			{
				get
				{
					return this._treeEnum.Current;
				}
			}

			// Token: 0x17000835 RID: 2101
			// (get) Token: 0x06002804 RID: 10244 RVA: 0x0008A360 File Offset: 0x00088560
			internal bool NotStartedOrEnded
			{
				get
				{
					return this._treeEnum.NotStartedOrEnded;
				}
			}

			// Token: 0x06002805 RID: 10245 RVA: 0x0008A36D File Offset: 0x0008856D
			internal void Reset()
			{
				this._treeEnum.Reset();
			}

			/// <summary>Устанавливает перечислитель в его начальное положение, т. е. перед первым элементом коллекции.</summary>
			/// <exception cref="T:System.InvalidOperationException">После создания перечислителя семейство было изменено.</exception>
			// Token: 0x06002806 RID: 10246 RVA: 0x0008A36D File Offset: 0x0008856D
			void IEnumerator.Reset()
			{
				this._treeEnum.Reset();
			}

			/// <summary>Возвращает элемент, расположенный в текущей позиции перечислителя.</summary>
			/// <returns>Элемент коллекции, соответствующий текущей позиции перечислителя.</returns>
			/// <exception cref="T:System.InvalidOperationException">Перечислитель размещается перед первым элементом семейства или после его последнего элемента.</exception>
			// Token: 0x17000836 RID: 2102
			// (get) Token: 0x06002807 RID: 10247 RVA: 0x0008A37C File Offset: 0x0008857C
			object IEnumerator.Current
			{
				get
				{
					if (this.NotStartedOrEnded)
					{
						throw new InvalidOperationException("Enumeration has either not started or has already finished.");
					}
					KeyValuePair<TKey, TValue> keyValuePair;
					if (this._getEnumeratorRetType == 2)
					{
						keyValuePair = this.Current;
						object key = keyValuePair.Key;
						keyValuePair = this.Current;
						return new DictionaryEntry(key, keyValuePair.Value);
					}
					keyValuePair = this.Current;
					TKey key2 = keyValuePair.Key;
					keyValuePair = this.Current;
					return new KeyValuePair<TKey, TValue>(key2, keyValuePair.Value);
				}
			}

			/// <summary>Возвращает ключ элемента, расположенного в текущей позиции перечислителя.</summary>
			/// <returns>Ключ элемента коллекции, расположенного в текущей позиции перечислителя.</returns>
			/// <exception cref="T:System.InvalidOperationException">Перечислитель размещается перед первым элементом семейства или после его последнего элемента.</exception>
			// Token: 0x17000837 RID: 2103
			// (get) Token: 0x06002808 RID: 10248 RVA: 0x0008A3FC File Offset: 0x000885FC
			object IDictionaryEnumerator.Key
			{
				get
				{
					if (this.NotStartedOrEnded)
					{
						throw new InvalidOperationException("Enumeration has either not started or has already finished.");
					}
					KeyValuePair<TKey, TValue> keyValuePair = this.Current;
					return keyValuePair.Key;
				}
			}

			/// <summary>Возвращает значение элемента, расположенного в текущей позиции перечислителя.</summary>
			/// <returns>Значение элемента коллекции, расположенного в текущей позиции перечислителя.</returns>
			/// <exception cref="T:System.InvalidOperationException">Перечислитель размещается перед первым элементом семейства или после его последнего элемента.</exception>
			// Token: 0x17000838 RID: 2104
			// (get) Token: 0x06002809 RID: 10249 RVA: 0x0008A430 File Offset: 0x00088630
			object IDictionaryEnumerator.Value
			{
				get
				{
					if (this.NotStartedOrEnded)
					{
						throw new InvalidOperationException("Enumeration has either not started or has already finished.");
					}
					KeyValuePair<TKey, TValue> keyValuePair = this.Current;
					return keyValuePair.Value;
				}
			}

			/// <summary>Возвращает элемент, расположенный в текущей позиции перечислителя, в виде структуры <see cref="T:System.Collections.DictionaryEntry" />.</summary>
			/// <returns>Элемент коллекции, расположенный в текущей позиции словаря и имеющий вид структуры <see cref="T:System.Collections.DictionaryEntry" />.</returns>
			/// <exception cref="T:System.InvalidOperationException">Перечислитель размещается перед первым элементом семейства или после его последнего элемента.</exception>
			// Token: 0x17000839 RID: 2105
			// (get) Token: 0x0600280A RID: 10250 RVA: 0x0008A464 File Offset: 0x00088664
			DictionaryEntry IDictionaryEnumerator.Entry
			{
				get
				{
					if (this.NotStartedOrEnded)
					{
						throw new InvalidOperationException("Enumeration has either not started or has already finished.");
					}
					KeyValuePair<TKey, TValue> keyValuePair = this.Current;
					object key = keyValuePair.Key;
					keyValuePair = this.Current;
					return new DictionaryEntry(key, keyValuePair.Value);
				}
			}

			// Token: 0x04001574 RID: 5492
			private SortedSet<KeyValuePair<TKey, TValue>>.Enumerator _treeEnum;

			// Token: 0x04001575 RID: 5493
			private int _getEnumeratorRetType;

			// Token: 0x04001576 RID: 5494
			internal const int KeyValuePair = 1;

			// Token: 0x04001577 RID: 5495
			internal const int DictEntry = 2;
		}

		/// <summary>Представляет коллекцию ключей в <see cref="T:System.Collections.Generic.SortedDictionary`2" />. Этот класс не наследуется.</summary>
		/// <typeparam name="TKey" />
		/// <typeparam name="TValue" />
		// Token: 0x020004CF RID: 1231
		[DebuggerDisplay("Count = {Count}")]
		[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView<, >))]
		[Serializable]
		public sealed class KeyCollection : ICollection<!0>, IEnumerable<!0>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
		{
			/// <summary>Инициализирует новый экземпляр <see cref="T:System.Collections.Generic.SortedDictionary`2.KeyCollection" />, который отражает ключи в указанном словаре <see cref="T:System.Collections.Generic.SortedDictionary`2" />.</summary>
			/// <param name="dictionary">Словарь <see cref="T:System.Collections.Generic.SortedDictionary`2" />, ключи которого отражены в новой коллекции <see cref="T:System.Collections.Generic.SortedDictionary`2.KeyCollection" />.</param>
			/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="dictionary" /> имеет значение <see langword="null" />.</exception>
			// Token: 0x0600280B RID: 10251 RVA: 0x0008A4AF File Offset: 0x000886AF
			public KeyCollection(SortedDictionary<TKey, TValue> dictionary)
			{
				if (dictionary == null)
				{
					throw new ArgumentNullException("dictionary");
				}
				this._dictionary = dictionary;
			}

			/// <summary>Возвращает перечислитель, осуществляющий перебор элементов списка <see cref="T:System.Collections.Generic.SortedDictionary`2.KeyCollection" />.</summary>
			/// <returns>Структура <see cref="T:System.Collections.Generic.SortedDictionary`2.KeyCollection.Enumerator" /> для <see cref="T:System.Collections.Generic.SortedDictionary`2.KeyCollection" />.</returns>
			// Token: 0x0600280C RID: 10252 RVA: 0x0008A4CC File Offset: 0x000886CC
			public SortedDictionary<TKey, TValue>.KeyCollection.Enumerator GetEnumerator()
			{
				return new SortedDictionary<TKey, TValue>.KeyCollection.Enumerator(this._dictionary);
			}

			// Token: 0x0600280D RID: 10253 RVA: 0x0008A4D9 File Offset: 0x000886D9
			IEnumerator<TKey> IEnumerable<!0>.GetEnumerator()
			{
				return new SortedDictionary<TKey, TValue>.KeyCollection.Enumerator(this._dictionary);
			}

			/// <summary>Возвращает перечислитель, выполняющий перебор элементов в коллекции.</summary>
			/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для итерации элементов коллекции.</returns>
			// Token: 0x0600280E RID: 10254 RVA: 0x0008A4D9 File Offset: 0x000886D9
			IEnumerator IEnumerable.GetEnumerator()
			{
				return new SortedDictionary<TKey, TValue>.KeyCollection.Enumerator(this._dictionary);
			}

			/// <summary>Копирует элементы коллекции <see cref="T:System.Collections.Generic.SortedDictionary`2.KeyCollection" /> в существующий одномерный массив, начиная с указанного значения индекса массива.</summary>
			/// <param name="array">Одномерный массив, в который копируются элементы из коллекции <see cref="T:System.Collections.Generic.SortedDictionary`2.KeyCollection" />. Индекс в массиве должен начинаться с нуля.</param>
			/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
			/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
			/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.</exception>
			/// <exception cref="T:System.ArgumentException">Число элементов в исходной коллекции <see cref="T:System.Collections.Generic.SortedDictionary`2.KeyCollection" /> больше доступного места от положения, заданного значением параметра <paramref name="index" />, до конца массива назначения <paramref name="array" />.</exception>
			// Token: 0x0600280F RID: 10255 RVA: 0x0008A4EC File Offset: 0x000886EC
			public void CopyTo(TKey[] array, int index)
			{
				if (array == null)
				{
					throw new ArgumentNullException("array");
				}
				if (index < 0)
				{
					throw new ArgumentOutOfRangeException("index", index, "Non-negative number required.");
				}
				if (array.Length - index < this.Count)
				{
					throw new ArgumentException("Destination array is not long enough to copy all the items in the collection. Check array index and length.");
				}
				this._dictionary._set.InOrderTreeWalk(delegate(SortedSet<KeyValuePair<TKey, TValue>>.Node node)
				{
					TKey[] array2 = array;
					int index2 = index;
					index = index2 + 1;
					array2[index2] = node.Item.Key;
					return true;
				});
			}

			/// <summary>Копирует элементы <see cref="T:System.Collections.ICollection" /> в массив, начиная с определенного индекса массива.</summary>
			/// <param name="array">Одномерный массив, в который копируются элементы из коллекции <see cref="T:System.Collections.ICollection" />. Индекс в массиве должен начинаться с нуля.</param>
			/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
			/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
			/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.</exception>
			/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
			///
			/// или - 
			/// Массив <paramref name="array" /> не имеет индексации, начинающейся с нуля.  
			///
			/// или - 
			/// Число элементов в исходном массиве <see cref="T:System.Collections.ICollection" /> больше доступного места от положения, заданного значением параметра <paramref name="index" />, до конца массива назначения <paramref name="array" />.  
			///
			/// или - 
			/// Тип исходного массива <see cref="T:System.Collections.ICollection" /> не может быть автоматически приведен к типу массива назначения <paramref name="array" />.</exception>
			// Token: 0x06002810 RID: 10256 RVA: 0x0008A584 File Offset: 0x00088784
			void ICollection.CopyTo(Array array, int index)
			{
				if (array == null)
				{
					throw new ArgumentNullException("array");
				}
				if (array.Rank != 1)
				{
					throw new ArgumentException("Only single dimensional arrays are supported for the requested action.", "array");
				}
				if (array.GetLowerBound(0) != 0)
				{
					throw new ArgumentException("The lower bound of target array must be zero.", "array");
				}
				if (index < 0)
				{
					throw new ArgumentOutOfRangeException("index", index, "Non-negative number required.");
				}
				if (array.Length - index < this._dictionary.Count)
				{
					throw new ArgumentException("Destination array is not long enough to copy all the items in the collection. Check array index and length.");
				}
				TKey[] array2 = array as TKey[];
				if (array2 != null)
				{
					this.CopyTo(array2, index);
					return;
				}
				try
				{
					object[] objects = (object[])array;
					this._dictionary._set.InOrderTreeWalk(delegate(SortedSet<KeyValuePair<TKey, TValue>>.Node node)
					{
						object[] objects = objects;
						int index2 = index;
						index = index2 + 1;
						objects[index2] = node.Item.Key;
						return true;
					});
				}
				catch (ArrayTypeMismatchException)
				{
					throw new ArgumentException("Target array type is not compatible with the type of items in the collection.", "array");
				}
			}

			/// <summary>Получает число элементов, содержащихся в интерфейсе <see cref="T:System.Collections.Generic.SortedDictionary`2.KeyCollection" />.</summary>
			/// <returns>Число элементов, содержащихся в коллекции <see cref="T:System.Collections.Generic.SortedDictionary`2.KeyCollection" />.</returns>
			// Token: 0x1700083A RID: 2106
			// (get) Token: 0x06002811 RID: 10257 RVA: 0x0008A68C File Offset: 0x0008888C
			public int Count
			{
				get
				{
					return this._dictionary.Count;
				}
			}

			// Token: 0x1700083B RID: 2107
			// (get) Token: 0x06002812 RID: 10258 RVA: 0x0000390E File Offset: 0x00001B0E
			bool ICollection<!0>.IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x06002813 RID: 10259 RVA: 0x0008A699 File Offset: 0x00088899
			void ICollection<!0>.Add(TKey item)
			{
				throw new NotSupportedException("Mutating a key collection derived from a dictionary is not allowed.");
			}

			// Token: 0x06002814 RID: 10260 RVA: 0x0008A699 File Offset: 0x00088899
			void ICollection<!0>.Clear()
			{
				throw new NotSupportedException("Mutating a key collection derived from a dictionary is not allowed.");
			}

			// Token: 0x06002815 RID: 10261 RVA: 0x0008A6A5 File Offset: 0x000888A5
			bool ICollection<!0>.Contains(TKey item)
			{
				return this._dictionary.ContainsKey(item);
			}

			// Token: 0x06002816 RID: 10262 RVA: 0x0008A699 File Offset: 0x00088899
			bool ICollection<!0>.Remove(TKey item)
			{
				throw new NotSupportedException("Mutating a key collection derived from a dictionary is not allowed.");
			}

			/// <summary>Возвращает значение, показывающее, является ли доступ к коллекции <see cref="T:System.Collections.ICollection" /> синхронизированным (потокобезопасным).</summary>
			/// <returns>
			///   <see langword="true" />, если доступ к классу <see cref="T:System.Collections.ICollection" /> является синхронизированным (потокобезопасным); в противном случае — <see langword="false" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.Generic.SortedDictionary`2.KeyCollection" /> это свойство всегда возвращает значение <see langword="false" />.</returns>
			// Token: 0x1700083C RID: 2108
			// (get) Token: 0x06002817 RID: 10263 RVA: 0x00003062 File Offset: 0x00001262
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.ICollection" />.</summary>
			/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Collections.ICollection" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.Generic.SortedDictionary`2.KeyCollection" /> это свойство всегда возвращает текущий экземпляр.</returns>
			// Token: 0x1700083D RID: 2109
			// (get) Token: 0x06002818 RID: 10264 RVA: 0x0008A6B3 File Offset: 0x000888B3
			object ICollection.SyncRoot
			{
				get
				{
					return ((ICollection)this._dictionary).SyncRoot;
				}
			}

			// Token: 0x04001578 RID: 5496
			private SortedDictionary<TKey, TValue> _dictionary;

			/// <summary>Выполняет перечисление элементов коллекции <see cref="T:System.Collections.Generic.SortedDictionary`2.KeyCollection" />.</summary>
			/// <typeparam name="TKey" />
			/// <typeparam name="TValue" />
			// Token: 0x020004D0 RID: 1232
			public struct Enumerator : IEnumerator<!0>, IDisposable, IEnumerator
			{
				// Token: 0x06002819 RID: 10265 RVA: 0x0008A6C0 File Offset: 0x000888C0
				internal Enumerator(SortedDictionary<TKey, TValue> dictionary)
				{
					this._dictEnum = dictionary.GetEnumerator();
				}

				/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.Collections.Generic.SortedDictionary`2.KeyCollection.Enumerator" />.</summary>
				// Token: 0x0600281A RID: 10266 RVA: 0x0008A6CE File Offset: 0x000888CE
				public void Dispose()
				{
					this._dictEnum.Dispose();
				}

				/// <summary>Перемещает перечислитель к следующему элементу коллекции <see cref="T:System.Collections.Generic.SortedDictionary`2.KeyCollection" />.</summary>
				/// <returns>Значение <see langword="true" />, если перечислитель был успешно перемещен к следующему элементу; значение <see langword="false" />, если перечислитель достиг конца коллекции.</returns>
				/// <exception cref="T:System.InvalidOperationException">После создания перечислителя семейство было изменено.</exception>
				// Token: 0x0600281B RID: 10267 RVA: 0x0008A6DB File Offset: 0x000888DB
				public bool MoveNext()
				{
					return this._dictEnum.MoveNext();
				}

				/// <summary>Возвращает элемент, расположенный в текущей позиции перечислителя.</summary>
				/// <returns>Элемент коллекции <see cref="T:System.Collections.Generic.SortedDictionary`2.KeyCollection" />, находящийся в текущей позиции перечислителя.</returns>
				// Token: 0x1700083E RID: 2110
				// (get) Token: 0x0600281C RID: 10268 RVA: 0x0008A6E8 File Offset: 0x000888E8
				public TKey Current
				{
					get
					{
						KeyValuePair<TKey, TValue> keyValuePair = this._dictEnum.Current;
						return keyValuePair.Key;
					}
				}

				/// <summary>Возвращает элемент, расположенный в текущей позиции перечислителя.</summary>
				/// <returns>Элемент коллекции, соответствующий текущей позиции перечислителя.</returns>
				/// <exception cref="T:System.InvalidOperationException">Перечислитель размещается перед первым элементом семейства или после его последнего элемента.</exception>
				// Token: 0x1700083F RID: 2111
				// (get) Token: 0x0600281D RID: 10269 RVA: 0x0008A708 File Offset: 0x00088908
				object IEnumerator.Current
				{
					get
					{
						if (this._dictEnum.NotStartedOrEnded)
						{
							throw new InvalidOperationException("Enumeration has either not started or has already finished.");
						}
						return this.Current;
					}
				}

				/// <summary>Устанавливает перечислитель в его начальное положение, т. е. перед первым элементом коллекции.</summary>
				/// <exception cref="T:System.InvalidOperationException">После создания перечислителя семейство было изменено.</exception>
				// Token: 0x0600281E RID: 10270 RVA: 0x0008A72D File Offset: 0x0008892D
				void IEnumerator.Reset()
				{
					this._dictEnum.Reset();
				}

				// Token: 0x04001579 RID: 5497
				private SortedDictionary<TKey, TValue>.Enumerator _dictEnum;
			}
		}

		/// <summary>Представляет коллекцию значений в <see cref="T:System.Collections.Generic.SortedDictionary`2" />. Этот класс не наследуется.</summary>
		/// <typeparam name="TKey" />
		/// <typeparam name="TValue" />
		// Token: 0x020004D3 RID: 1235
		[DebuggerDisplay("Count = {Count}")]
		[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView<, >))]
		[Serializable]
		public sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
		{
			/// <summary>Инициализирует новый экземпляр <see cref="T:System.Collections.Generic.SortedDictionary`2.ValueCollection" />, который отражает значения в указанном словаре <see cref="T:System.Collections.Generic.SortedDictionary`2" />.</summary>
			/// <param name="dictionary">Словарь <see cref="T:System.Collections.Generic.SortedDictionary`2" />, значения которого отражены в новой коллекции <see cref="T:System.Collections.Generic.SortedDictionary`2.ValueCollection" />.</param>
			/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="dictionary" /> имеет значение <see langword="null" />.</exception>
			// Token: 0x06002823 RID: 10275 RVA: 0x0008A7AD File Offset: 0x000889AD
			public ValueCollection(SortedDictionary<TKey, TValue> dictionary)
			{
				if (dictionary == null)
				{
					throw new ArgumentNullException("dictionary");
				}
				this._dictionary = dictionary;
			}

			/// <summary>Возвращает перечислитель, осуществляющий перебор элементов списка <see cref="T:System.Collections.Generic.SortedDictionary`2.ValueCollection" />.</summary>
			/// <returns>Структура <see cref="T:System.Collections.Generic.SortedDictionary`2.ValueCollection.Enumerator" /> для <see cref="T:System.Collections.Generic.SortedDictionary`2.ValueCollection" />.</returns>
			// Token: 0x06002824 RID: 10276 RVA: 0x0008A7CA File Offset: 0x000889CA
			public SortedDictionary<TKey, TValue>.ValueCollection.Enumerator GetEnumerator()
			{
				return new SortedDictionary<TKey, TValue>.ValueCollection.Enumerator(this._dictionary);
			}

			// Token: 0x06002825 RID: 10277 RVA: 0x0008A7D7 File Offset: 0x000889D7
			IEnumerator<TValue> IEnumerable<!1>.GetEnumerator()
			{
				return new SortedDictionary<TKey, TValue>.ValueCollection.Enumerator(this._dictionary);
			}

			/// <summary>Возвращает перечислитель, выполняющий перебор элементов в коллекции.</summary>
			/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для итерации элементов коллекции.</returns>
			// Token: 0x06002826 RID: 10278 RVA: 0x0008A7D7 File Offset: 0x000889D7
			IEnumerator IEnumerable.GetEnumerator()
			{
				return new SortedDictionary<TKey, TValue>.ValueCollection.Enumerator(this._dictionary);
			}

			/// <summary>Копирует элементы коллекции <see cref="T:System.Collections.Generic.SortedDictionary`2.ValueCollection" /> в существующий одномерный массив, начиная с указанного значения индекса массива.</summary>
			/// <param name="array">Одномерный массив, в который копируются элементы из коллекции <see cref="T:System.Collections.Generic.SortedDictionary`2.ValueCollection" />. Индекс в массиве должен начинаться с нуля.</param>
			/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
			/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
			/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.</exception>
			/// <exception cref="T:System.ArgumentException">Число элементов в исходной коллекции <see cref="T:System.Collections.Generic.SortedDictionary`2.ValueCollection" /> больше доступного места от положения, заданного значением параметра <paramref name="index" />, до конца массива назначения <paramref name="array" />.</exception>
			// Token: 0x06002827 RID: 10279 RVA: 0x0008A7EC File Offset: 0x000889EC
			public void CopyTo(TValue[] array, int index)
			{
				if (array == null)
				{
					throw new ArgumentNullException("array");
				}
				if (index < 0)
				{
					throw new ArgumentOutOfRangeException("index", index, "Non-negative number required.");
				}
				if (array.Length - index < this.Count)
				{
					throw new ArgumentException("Destination array is not long enough to copy all the items in the collection. Check array index and length.");
				}
				this._dictionary._set.InOrderTreeWalk(delegate(SortedSet<KeyValuePair<TKey, TValue>>.Node node)
				{
					TValue[] array2 = array;
					int index2 = index;
					index = index2 + 1;
					array2[index2] = node.Item.Value;
					return true;
				});
			}

			/// <summary>Копирует элементы <see cref="T:System.Collections.ICollection" /> в массив, начиная с определенного индекса массива.</summary>
			/// <param name="array">Одномерный массив, в который копируются элементы из коллекции <see cref="T:System.Collections.ICollection" />. Индекс в массиве должен начинаться с нуля.</param>
			/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
			/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
			/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.</exception>
			/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
			///
			/// или - 
			/// Массив <paramref name="array" /> не имеет индексации, начинающейся с нуля.  
			///
			/// или - 
			/// Число элементов в исходном массиве <see cref="T:System.Collections.ICollection" /> больше доступного места от положения, заданного значением параметра <paramref name="index" />, до конца массива назначения <paramref name="array" />.  
			///
			/// или - 
			/// Тип исходного массива <see cref="T:System.Collections.ICollection" /> не может быть автоматически приведен к типу массива назначения <paramref name="array" />.</exception>
			// Token: 0x06002828 RID: 10280 RVA: 0x0008A884 File Offset: 0x00088A84
			void ICollection.CopyTo(Array array, int index)
			{
				if (array == null)
				{
					throw new ArgumentNullException("array");
				}
				if (array.Rank != 1)
				{
					throw new ArgumentException("Only single dimensional arrays are supported for the requested action.", "array");
				}
				if (array.GetLowerBound(0) != 0)
				{
					throw new ArgumentException("The lower bound of target array must be zero.", "array");
				}
				if (index < 0)
				{
					throw new ArgumentOutOfRangeException("index", index, "Non-negative number required.");
				}
				if (array.Length - index < this._dictionary.Count)
				{
					throw new ArgumentException("Destination array is not long enough to copy all the items in the collection. Check array index and length.");
				}
				TValue[] array2 = array as TValue[];
				if (array2 != null)
				{
					this.CopyTo(array2, index);
					return;
				}
				try
				{
					object[] objects = (object[])array;
					this._dictionary._set.InOrderTreeWalk(delegate(SortedSet<KeyValuePair<TKey, TValue>>.Node node)
					{
						object[] objects = objects;
						int index2 = index;
						index = index2 + 1;
						objects[index2] = node.Item.Value;
						return true;
					});
				}
				catch (ArrayTypeMismatchException)
				{
					throw new ArgumentException("Target array type is not compatible with the type of items in the collection.", "array");
				}
			}

			/// <summary>Получает число элементов, содержащихся в интерфейсе <see cref="T:System.Collections.Generic.SortedDictionary`2.ValueCollection" />.</summary>
			/// <returns>Число элементов, содержащихся в интерфейсе <see cref="T:System.Collections.Generic.SortedDictionary`2.ValueCollection" />.</returns>
			// Token: 0x17000840 RID: 2112
			// (get) Token: 0x06002829 RID: 10281 RVA: 0x0008A98C File Offset: 0x00088B8C
			public int Count
			{
				get
				{
					return this._dictionary.Count;
				}
			}

			// Token: 0x17000841 RID: 2113
			// (get) Token: 0x0600282A RID: 10282 RVA: 0x0000390E File Offset: 0x00001B0E
			bool ICollection<!1>.IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x0600282B RID: 10283 RVA: 0x0008A999 File Offset: 0x00088B99
			void ICollection<!1>.Add(TValue item)
			{
				throw new NotSupportedException("Mutating a value collection derived from a dictionary is not allowed.");
			}

			// Token: 0x0600282C RID: 10284 RVA: 0x0008A999 File Offset: 0x00088B99
			void ICollection<!1>.Clear()
			{
				throw new NotSupportedException("Mutating a value collection derived from a dictionary is not allowed.");
			}

			// Token: 0x0600282D RID: 10285 RVA: 0x0008A9A5 File Offset: 0x00088BA5
			bool ICollection<!1>.Contains(TValue item)
			{
				return this._dictionary.ContainsValue(item);
			}

			// Token: 0x0600282E RID: 10286 RVA: 0x0008A999 File Offset: 0x00088B99
			bool ICollection<!1>.Remove(TValue item)
			{
				throw new NotSupportedException("Mutating a value collection derived from a dictionary is not allowed.");
			}

			/// <summary>Возвращает значение, показывающее, является ли доступ к коллекции <see cref="T:System.Collections.ICollection" /> синхронизированным (потокобезопасным).</summary>
			/// <returns>
			///   <see langword="true" />, если доступ к классу <see cref="T:System.Collections.ICollection" /> является синхронизированным (потокобезопасным); в противном случае — <see langword="false" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.Generic.SortedDictionary`2.ValueCollection" /> это свойство всегда возвращает значение <see langword="false" />.</returns>
			// Token: 0x17000842 RID: 2114
			// (get) Token: 0x0600282F RID: 10287 RVA: 0x00003062 File Offset: 0x00001262
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.ICollection" />.</summary>
			/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Collections.ICollection" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.Generic.SortedDictionary`2.ValueCollection" /> это свойство всегда возвращает текущий экземпляр.</returns>
			// Token: 0x17000843 RID: 2115
			// (get) Token: 0x06002830 RID: 10288 RVA: 0x0008A9B3 File Offset: 0x00088BB3
			object ICollection.SyncRoot
			{
				get
				{
					return ((ICollection)this._dictionary).SyncRoot;
				}
			}

			// Token: 0x0400157E RID: 5502
			private SortedDictionary<TKey, TValue> _dictionary;

			/// <summary>Выполняет перечисление элементов коллекции <see cref="T:System.Collections.Generic.SortedDictionary`2.ValueCollection" />.</summary>
			/// <typeparam name="TKey" />
			/// <typeparam name="TValue" />
			// Token: 0x020004D4 RID: 1236
			public struct Enumerator : IEnumerator<TValue>, IDisposable, IEnumerator
			{
				// Token: 0x06002831 RID: 10289 RVA: 0x0008A9C0 File Offset: 0x00088BC0
				internal Enumerator(SortedDictionary<TKey, TValue> dictionary)
				{
					this._dictEnum = dictionary.GetEnumerator();
				}

				/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.Collections.Generic.SortedDictionary`2.ValueCollection.Enumerator" />.</summary>
				// Token: 0x06002832 RID: 10290 RVA: 0x0008A9CE File Offset: 0x00088BCE
				public void Dispose()
				{
					this._dictEnum.Dispose();
				}

				/// <summary>Перемещает перечислитель к следующему элементу коллекции <see cref="T:System.Collections.Generic.SortedDictionary`2.ValueCollection" />.</summary>
				/// <returns>Значение <see langword="true" />, если перечислитель был успешно перемещен к следующему элементу; значение <see langword="false" />, если перечислитель достиг конца коллекции.</returns>
				/// <exception cref="T:System.InvalidOperationException">После создания перечислителя семейство было изменено.</exception>
				// Token: 0x06002833 RID: 10291 RVA: 0x0008A9DB File Offset: 0x00088BDB
				public bool MoveNext()
				{
					return this._dictEnum.MoveNext();
				}

				/// <summary>Возвращает элемент, расположенный в текущей позиции перечислителя.</summary>
				/// <returns>Элемент коллекции <see cref="T:System.Collections.Generic.SortedDictionary`2.ValueCollection" />, находящийся в текущей позиции перечислителя.</returns>
				// Token: 0x17000844 RID: 2116
				// (get) Token: 0x06002834 RID: 10292 RVA: 0x0008A9E8 File Offset: 0x00088BE8
				public TValue Current
				{
					get
					{
						KeyValuePair<TKey, TValue> keyValuePair = this._dictEnum.Current;
						return keyValuePair.Value;
					}
				}

				/// <summary>Возвращает элемент, расположенный в текущей позиции перечислителя.</summary>
				/// <returns>Элемент коллекции, соответствующий текущей позиции перечислителя.</returns>
				/// <exception cref="T:System.InvalidOperationException">Перечислитель размещается перед первым элементом семейства или после его последнего элемента.</exception>
				// Token: 0x17000845 RID: 2117
				// (get) Token: 0x06002835 RID: 10293 RVA: 0x0008AA08 File Offset: 0x00088C08
				object IEnumerator.Current
				{
					get
					{
						if (this._dictEnum.NotStartedOrEnded)
						{
							throw new InvalidOperationException("Enumeration has either not started or has already finished.");
						}
						return this.Current;
					}
				}

				/// <summary>Устанавливает перечислитель в его начальное положение, т. е. перед первым элементом коллекции.</summary>
				/// <exception cref="T:System.InvalidOperationException">После создания перечислителя семейство было изменено.</exception>
				// Token: 0x06002836 RID: 10294 RVA: 0x0008AA2D File Offset: 0x00088C2D
				void IEnumerator.Reset()
				{
					this._dictEnum.Reset();
				}

				// Token: 0x0400157F RID: 5503
				private SortedDictionary<TKey, TValue>.Enumerator _dictEnum;
			}
		}

		// Token: 0x020004D7 RID: 1239
		[Serializable]
		internal sealed class KeyValuePairComparer : Comparer<KeyValuePair<TKey, TValue>>
		{
			// Token: 0x0600283B RID: 10299 RVA: 0x0008AAAD File Offset: 0x00088CAD
			public KeyValuePairComparer(IComparer<TKey> keyComparer)
			{
				if (keyComparer == null)
				{
					this.keyComparer = Comparer<TKey>.Default;
					return;
				}
				this.keyComparer = keyComparer;
			}

			// Token: 0x0600283C RID: 10300 RVA: 0x0008AACB File Offset: 0x00088CCB
			public override int Compare(KeyValuePair<TKey, TValue> x, KeyValuePair<TKey, TValue> y)
			{
				return this.keyComparer.Compare(x.Key, y.Key);
			}

			// Token: 0x04001584 RID: 5508
			internal IComparer<TKey> keyComparer;
		}
	}
}
