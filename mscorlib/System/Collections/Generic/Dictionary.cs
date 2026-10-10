using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Threading;

namespace System.Collections.Generic
{
	/// <summary>Представляет коллекцию ключей и значений.</summary>
	/// <typeparam name="TKey">Тип ключей в словаре.</typeparam>
	/// <typeparam name="TValue">Тип значений в словаре.</typeparam>
	// Token: 0x02000A89 RID: 2697
	[DebuggerTypeProxy(typeof(IDictionaryDebugView<, >))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<!0, !1>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, ISerializable, IDeserializationCallback
	{
		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Generic.Dictionary`2" />, имеющий начальную емкость по умолчанию и использующий функцию сравнения по умолчанию, проверяющую равенство для данного типа ключа.</summary>
		// Token: 0x0600609F RID: 24735 RVA: 0x001434D0 File Offset: 0x001416D0
		public Dictionary() : this(0, null)
		{
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Generic.Dictionary`2" />, имеющий заданную начальную емкость и использующий функцию сравнения по умолчанию, проверяющую равенство для данного типа ключа.</summary>
		/// <param name="capacity">Начальное количество элементов, которое может содержать коллекция <see cref="T:System.Collections.Generic.Dictionary`2" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="capacity" /> меньше 0.</exception>
		// Token: 0x060060A0 RID: 24736 RVA: 0x001434DA File Offset: 0x001416DA
		public Dictionary(int capacity) : this(capacity, null)
		{
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Generic.Dictionary`2" /> начальной емкостью по умолчанию, использующий указанную функцию сравнения <see cref="T:System.Collections.Generic.IEqualityComparer`1" />.</summary>
		/// <param name="comparer">Реализация <see cref="T:System.Collections.Generic.IEqualityComparer`1" />, которую следует использовать при сравнении ключей, или <see langword="null" />, если для данного типа ключа должна использоваться реализация <see cref="T:System.Collections.Generic.EqualityComparer`1" /> по умолчанию.</param>
		// Token: 0x060060A1 RID: 24737 RVA: 0x001434E4 File Offset: 0x001416E4
		public Dictionary(IEqualityComparer<TKey> comparer) : this(0, comparer)
		{
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Generic.Dictionary`2" /> заданной начальной емкостью, использующий указанную функцию сравнения <see cref="T:System.Collections.Generic.IEqualityComparer`1" />.</summary>
		/// <param name="capacity">Начальное количество элементов, которое может содержать коллекция <see cref="T:System.Collections.Generic.Dictionary`2" />.</param>
		/// <param name="comparer">Реализация <see cref="T:System.Collections.Generic.IEqualityComparer`1" />, которую следует использовать при сравнении ключей, или <see langword="null" />, если для данного типа ключа должна использоваться реализация <see cref="T:System.Collections.Generic.EqualityComparer`1" /> по умолчанию.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="capacity" /> меньше 0.</exception>
		// Token: 0x060060A2 RID: 24738 RVA: 0x001434EE File Offset: 0x001416EE
		public Dictionary(int capacity, IEqualityComparer<TKey> comparer)
		{
			if (capacity < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.capacity);
			}
			if (capacity > 0)
			{
				this.Initialize(capacity);
			}
			if (comparer != EqualityComparer<TKey>.Default)
			{
				this._comparer = comparer;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Generic.Dictionary`2" />, который содержит элементы, скопированные из заданной коллекции <see cref="T:System.Collections.Generic.IDictionary`2" />, и использует функцию сравнения по умолчанию, проверяющую равенство для данного типа ключа.</summary>
		/// <param name="dictionary">Объект <see cref="T:System.Collections.Generic.IDictionary`2" />, элементы которого копируются в новый объект <see cref="T:System.Collections.Generic.Dictionary`2" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="dictionary" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="dictionary" /> содержит один или несколько ключей-дубликатов.</exception>
		// Token: 0x060060A3 RID: 24739 RVA: 0x0014351C File Offset: 0x0014171C
		public Dictionary(IDictionary<TKey, TValue> dictionary) : this(dictionary, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Generic.Dictionary`2" />, который содержит элементы, скопированные из заданной коллекции <see cref="T:System.Collections.Generic.IDictionary`2" />, и использует указанный интерфейс <see cref="T:System.Collections.Generic.IEqualityComparer`1" />.</summary>
		/// <param name="dictionary">Объект <see cref="T:System.Collections.Generic.IDictionary`2" />, элементы которого копируются в новый объект <see cref="T:System.Collections.Generic.Dictionary`2" />.</param>
		/// <param name="comparer">Реализация <see cref="T:System.Collections.Generic.IEqualityComparer`1" />, которую следует использовать при сравнении ключей, или <see langword="null" />, если для данного типа ключа должна использоваться реализация <see cref="T:System.Collections.Generic.EqualityComparer`1" /> по умолчанию.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="dictionary" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="dictionary" /> содержит один или несколько ключей-дубликатов.</exception>
		// Token: 0x060060A4 RID: 24740 RVA: 0x00143528 File Offset: 0x00141728
		public Dictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer) : this((dictionary != null) ? dictionary.Count : 0, comparer)
		{
			if (dictionary == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.dictionary);
			}
			if (dictionary.GetType() == typeof(Dictionary<TKey, TValue>))
			{
				Dictionary<TKey, TValue> dictionary2 = (Dictionary<TKey, TValue>)dictionary;
				int count = dictionary2._count;
				Dictionary<TKey, TValue>.Entry[] entries = dictionary2._entries;
				for (int i = 0; i < count; i++)
				{
					if (entries[i].hashCode >= 0)
					{
						this.Add(entries[i].key, entries[i].value);
					}
				}
				return;
			}
			foreach (KeyValuePair<TKey, TValue> keyValuePair in dictionary)
			{
				this.Add(keyValuePair.Key, keyValuePair.Value);
			}
		}

		// Token: 0x060060A5 RID: 24741 RVA: 0x00143600 File Offset: 0x00141800
		public Dictionary(IEnumerable<KeyValuePair<TKey, TValue>> collection) : this(collection, null)
		{
		}

		// Token: 0x060060A6 RID: 24742 RVA: 0x0014360C File Offset: 0x0014180C
		public Dictionary(IEnumerable<KeyValuePair<TKey, TValue>> collection, IEqualityComparer<TKey> comparer)
		{
			ICollection<KeyValuePair<TKey, TValue>> collection2 = collection as ICollection<KeyValuePair<TKey, TValue>>;
			this..ctor((collection2 != null) ? collection2.Count : 0, comparer);
			if (collection == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.collection);
			}
			foreach (KeyValuePair<TKey, TValue> keyValuePair in collection)
			{
				this.Add(keyValuePair.Key, keyValuePair.Value);
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Generic.Dictionary`2" /> с сериализованными данными.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который содержит сведения, требуемые для сериализации коллекции <see cref="T:System.Collections.Generic.Dictionary`2" />.</param>
		/// <param name="context">Структура <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащая исходный объект и объект назначения для сериализованного потока, связанного с коллекцией <see cref="T:System.Collections.Generic.Dictionary`2" />.</param>
		// Token: 0x060060A7 RID: 24743 RVA: 0x00143684 File Offset: 0x00141884
		protected Dictionary(SerializationInfo info, StreamingContext context)
		{
			HashHelpers.SerializationInfoTable.Add(this, info);
		}

		/// <summary>Возвращает интерфейс <see cref="T:System.Collections.Generic.IEqualityComparer`1" />, используемый для установления равенства ключей словаря.</summary>
		/// <returns>Реализация универсального интерфейса <see cref="T:System.Collections.Generic.IEqualityComparer`1" />, используемая для установления равенства ключей текущего словаря <see cref="T:System.Collections.Generic.Dictionary`2" /> и для задания хэш-кодов ключей.</returns>
		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x060060A8 RID: 24744 RVA: 0x00143698 File Offset: 0x00141898
		public IEqualityComparer<TKey> Comparer
		{
			get
			{
				if (this._comparer != null)
				{
					return this._comparer;
				}
				return EqualityComparer<TKey>.Default;
			}
		}

		/// <summary>Возвращает число пар "ключ-значение", содержащихся в словаре <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary>
		/// <returns>Число пар "ключ-значение", содержащихся в словаре <see cref="T:System.Collections.Generic.Dictionary`2" />.</returns>
		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x060060A9 RID: 24745 RVA: 0x001436BB File Offset: 0x001418BB
		public int Count
		{
			get
			{
				return this._count - this._freeCount;
			}
		}

		/// <summary>Возвращает коллекцию, содержащую ключи из словаря <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" />, содержащий ключи из <see cref="T:System.Collections.Generic.Dictionary`2" />.</returns>
		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x060060AA RID: 24746 RVA: 0x001436CA File Offset: 0x001418CA
		public Dictionary<TKey, TValue>.KeyCollection Keys
		{
			get
			{
				if (this._keys == null)
				{
					this._keys = new Dictionary<TKey, TValue>.KeyCollection(this);
				}
				return this._keys;
			}
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x060060AB RID: 24747 RVA: 0x001436CA File Offset: 0x001418CA
		ICollection<TKey> IDictionary<!0, !1>.Keys
		{
			get
			{
				if (this._keys == null)
				{
					this._keys = new Dictionary<TKey, TValue>.KeyCollection(this);
				}
				return this._keys;
			}
		}

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x060060AC RID: 24748 RVA: 0x001436CA File Offset: 0x001418CA
		IEnumerable<TKey> IReadOnlyDictionary<!0, !1>.Keys
		{
			get
			{
				if (this._keys == null)
				{
					this._keys = new Dictionary<TKey, TValue>.KeyCollection(this);
				}
				return this._keys;
			}
		}

		/// <summary>Возвращает коллекцию, содержащую значения из словаря <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary>
		/// <returns>Коллекция <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" />, содержащая значения из словаря <see cref="T:System.Collections.Generic.Dictionary`2" />.</returns>
		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x060060AD RID: 24749 RVA: 0x001436E6 File Offset: 0x001418E6
		public Dictionary<TKey, TValue>.ValueCollection Values
		{
			get
			{
				if (this._values == null)
				{
					this._values = new Dictionary<TKey, TValue>.ValueCollection(this);
				}
				return this._values;
			}
		}

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x060060AE RID: 24750 RVA: 0x001436E6 File Offset: 0x001418E6
		ICollection<TValue> IDictionary<!0, !1>.Values
		{
			get
			{
				if (this._values == null)
				{
					this._values = new Dictionary<TKey, TValue>.ValueCollection(this);
				}
				return this._values;
			}
		}

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x060060AF RID: 24751 RVA: 0x001436E6 File Offset: 0x001418E6
		IEnumerable<TValue> IReadOnlyDictionary<!0, !1>.Values
		{
			get
			{
				if (this._values == null)
				{
					this._values = new Dictionary<TKey, TValue>.ValueCollection(this);
				}
				return this._values;
			}
		}

		/// <summary>Возвращает или задает значение, связанное с указанным ключом.</summary>
		/// <param name="key">Ключ, значение которого требуется получить или задать.</param>
		/// <returns>Значение, связанное с указанным ключом. Если указанный ключ не найден, операция получения создает исключение <see cref="T:System.Collections.Generic.KeyNotFoundException" />, а операция задания значения создает новый элемент с указанным ключом.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Collections.Generic.KeyNotFoundException">Свойство получено, а <paramref name="key" /> не существует в коллекции.</exception>
		// Token: 0x17001121 RID: 4385
		public TValue this[TKey key]
		{
			get
			{
				int num = this.FindEntry(key);
				if (num >= 0)
				{
					return this._entries[num].value;
				}
				ThrowHelper.ThrowKeyNotFoundException(key);
				return default(TValue);
			}
			set
			{
				this.TryInsert(key, value, InsertionBehavior.OverwriteExisting);
			}
		}

		/// <summary>Добавляет указанные ключ и значение в словарь.</summary>
		/// <param name="key">Ключ добавляемого элемента.</param>
		/// <param name="value">Добавляемое значение элемента. Для ссылочных типов допускается значение <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Элемент с таким ключом уже существует в <see cref="T:System.Collections.Generic.Dictionary`2" />.</exception>
		// Token: 0x060060B2 RID: 24754 RVA: 0x0014374F File Offset: 0x0014194F
		public void Add(TKey key, TValue value)
		{
			this.TryInsert(key, value, InsertionBehavior.ThrowOnExisting);
		}

		// Token: 0x060060B3 RID: 24755 RVA: 0x0014375B File Offset: 0x0014195B
		void ICollection<KeyValuePair<!0, !1>>.Add(KeyValuePair<TKey, TValue> keyValuePair)
		{
			this.Add(keyValuePair.Key, keyValuePair.Value);
		}

		// Token: 0x060060B4 RID: 24756 RVA: 0x00143774 File Offset: 0x00141974
		bool ICollection<KeyValuePair<!0, !1>>.Contains(KeyValuePair<TKey, TValue> keyValuePair)
		{
			int num = this.FindEntry(keyValuePair.Key);
			return num >= 0 && EqualityComparer<TValue>.Default.Equals(this._entries[num].value, keyValuePair.Value);
		}

		// Token: 0x060060B5 RID: 24757 RVA: 0x001437BC File Offset: 0x001419BC
		bool ICollection<KeyValuePair<!0, !1>>.Remove(KeyValuePair<TKey, TValue> keyValuePair)
		{
			int num = this.FindEntry(keyValuePair.Key);
			if (num >= 0 && EqualityComparer<TValue>.Default.Equals(this._entries[num].value, keyValuePair.Value))
			{
				this.Remove(keyValuePair.Key);
				return true;
			}
			return false;
		}

		/// <summary>Удаляет все ключи и значения из словаря <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary>
		// Token: 0x060060B6 RID: 24758 RVA: 0x00143810 File Offset: 0x00141A10
		public void Clear()
		{
			int count = this._count;
			if (count > 0)
			{
				Array.Clear(this._buckets, 0, this._buckets.Length);
				this._count = 0;
				this._freeList = -1;
				this._freeCount = 0;
				Array.Clear(this._entries, 0, count);
			}
			this._version++;
		}

		/// <summary>Определяет, содержится ли указанный ключ в словаре <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary>
		/// <param name="key">Ключ, который требуется найти в <see cref="T:System.Collections.Generic.Dictionary`2" />.</param>
		/// <returns>
		///   <see langword="true" />, если <see cref="T:System.Collections.Generic.Dictionary`2" /> содержит элемент с указанным ключом, в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		// Token: 0x060060B7 RID: 24759 RVA: 0x0014386C File Offset: 0x00141A6C
		public bool ContainsKey(TKey key)
		{
			return this.FindEntry(key) >= 0;
		}

		/// <summary>Определяет, содержит ли коллекция <see cref="T:System.Collections.Generic.Dictionary`2" /> указанное значение.</summary>
		/// <param name="value">Значение, которое требуется найти в словаре <see cref="T:System.Collections.Generic.Dictionary`2" />. Для ссылочных типов допускается значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Collections.Generic.Dictionary`2" /> содержит элемент с указанным значением; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060060B8 RID: 24760 RVA: 0x0014387C File Offset: 0x00141A7C
		public bool ContainsValue(TValue value)
		{
			Dictionary<TKey, TValue>.Entry[] entries = this._entries;
			if (value == null)
			{
				for (int i = 0; i < this._count; i++)
				{
					if (entries[i].hashCode >= 0 && entries[i].value == null)
					{
						return true;
					}
				}
			}
			else if (default(TValue) != null)
			{
				for (int j = 0; j < this._count; j++)
				{
					if (entries[j].hashCode >= 0 && EqualityComparer<TValue>.Default.Equals(entries[j].value, value))
					{
						return true;
					}
				}
			}
			else
			{
				EqualityComparer<TValue> @default = EqualityComparer<TValue>.Default;
				for (int k = 0; k < this._count; k++)
				{
					if (entries[k].hashCode >= 0 && @default.Equals(entries[k].value, value))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060060B9 RID: 24761 RVA: 0x00143968 File Offset: 0x00141B68
		private void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (index > array.Length)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (array.Length - index < this.Count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
			}
			int count = this._count;
			Dictionary<TKey, TValue>.Entry[] entries = this._entries;
			for (int i = 0; i < count; i++)
			{
				if (entries[i].hashCode >= 0)
				{
					array[index++] = new KeyValuePair<TKey, TValue>(entries[i].key, entries[i].value);
				}
			}
		}

		/// <summary>Возвращает перечислитель, осуществляющий перебор элементов списка <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary>
		/// <returns>Структура <see cref="T:System.Collections.Generic.Dictionary`2.Enumerator" /> для <see cref="T:System.Collections.Generic.Dictionary`2" />.</returns>
		// Token: 0x060060BA RID: 24762 RVA: 0x001439EE File Offset: 0x00141BEE
		public Dictionary<TKey, TValue>.Enumerator GetEnumerator()
		{
			return new Dictionary<TKey, TValue>.Enumerator(this, 2);
		}

		// Token: 0x060060BB RID: 24763 RVA: 0x001439F7 File Offset: 0x00141BF7
		IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<!0, !1>>.GetEnumerator()
		{
			return new Dictionary<TKey, TValue>.Enumerator(this, 2);
		}

		/// <summary>Реализует интерфейс <see cref="T:System.Runtime.Serialization.ISerializable" /> и возвращает данные, необходимые для сериализации экземпляра <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который содержит сведения, требуемые для сериализации экземпляра <see cref="T:System.Collections.Generic.Dictionary`2" />.</param>
		/// <param name="context">Структура <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащая исходный и конечный объекты сериализованного потока, связанного с экземпляром <see cref="T:System.Collections.Generic.Dictionary`2" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="info" /> — <see langword="null" />.</exception>
		// Token: 0x060060BC RID: 24764 RVA: 0x00143A08 File Offset: 0x00141C08
		[SecurityCritical]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.info);
			}
			info.AddValue("Version", this._version);
			info.AddValue("Comparer", this._comparer ?? EqualityComparer<TKey>.Default, typeof(IEqualityComparer<TKey>));
			info.AddValue("HashSize", (this._buckets == null) ? 0 : this._buckets.Length);
			if (this._buckets != null)
			{
				KeyValuePair<TKey, TValue>[] array = new KeyValuePair<TKey, TValue>[this.Count];
				this.CopyTo(array, 0);
				info.AddValue("KeyValuePairs", array, typeof(KeyValuePair<TKey, TValue>[]));
			}
		}

		// Token: 0x060060BD RID: 24765 RVA: 0x00143AA4 File Offset: 0x00141CA4
		private int FindEntry(TKey key)
		{
			if (key == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
			}
			int num = -1;
			int[] buckets = this._buckets;
			Dictionary<TKey, TValue>.Entry[] entries = this._entries;
			int num2 = 0;
			if (buckets != null)
			{
				IEqualityComparer<TKey> comparer = this._comparer;
				if (comparer == null)
				{
					int num3 = key.GetHashCode() & int.MaxValue;
					num = buckets[num3 % buckets.Length] - 1;
					if (default(TKey) != null)
					{
						while (num < entries.Length && (entries[num].hashCode != num3 || !EqualityComparer<TKey>.Default.Equals(entries[num].key, key)))
						{
							num = entries[num].next;
							if (num2 >= entries.Length)
							{
								ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
							}
							num2++;
						}
					}
					else
					{
						EqualityComparer<TKey> @default = EqualityComparer<TKey>.Default;
						while (num < entries.Length && (entries[num].hashCode != num3 || !@default.Equals(entries[num].key, key)))
						{
							num = entries[num].next;
							if (num2 >= entries.Length)
							{
								ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
							}
							num2++;
						}
					}
				}
				else
				{
					int num4 = comparer.GetHashCode(key) & int.MaxValue;
					num = buckets[num4 % buckets.Length] - 1;
					while (num < entries.Length && (entries[num].hashCode != num4 || !comparer.Equals(entries[num].key, key)))
					{
						num = entries[num].next;
						if (num2 >= entries.Length)
						{
							ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
						}
						num2++;
					}
				}
			}
			return num;
		}

		// Token: 0x060060BE RID: 24766 RVA: 0x00143C28 File Offset: 0x00141E28
		private int Initialize(int capacity)
		{
			int prime = HashHelpers.GetPrime(capacity);
			this._freeList = -1;
			this._buckets = new int[prime];
			this._entries = new Dictionary<TKey, TValue>.Entry[prime];
			return prime;
		}

		// Token: 0x060060BF RID: 24767 RVA: 0x00143C5C File Offset: 0x00141E5C
		private bool TryInsert(TKey key, TValue value, InsertionBehavior behavior)
		{
			if (key == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
			}
			this._version++;
			if (this._buckets == null)
			{
				this.Initialize(0);
			}
			Dictionary<TKey, TValue>.Entry[] entries = this._entries;
			IEqualityComparer<TKey> comparer = this._comparer;
			int num = ((comparer == null) ? key.GetHashCode() : comparer.GetHashCode(key)) & int.MaxValue;
			int num2 = 0;
			ref int ptr = ref this._buckets[num % this._buckets.Length];
			int i = ptr - 1;
			if (comparer == null)
			{
				if (default(TKey) != null)
				{
					while (i < entries.Length)
					{
						if (entries[i].hashCode == num && EqualityComparer<TKey>.Default.Equals(entries[i].key, key))
						{
							if (behavior == InsertionBehavior.OverwriteExisting)
							{
								entries[i].value = value;
								return true;
							}
							if (behavior == InsertionBehavior.ThrowOnExisting)
							{
								ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException(key);
							}
							return false;
						}
						else
						{
							i = entries[i].next;
							if (num2 >= entries.Length)
							{
								ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
							}
							num2++;
						}
					}
				}
				else
				{
					EqualityComparer<TKey> @default = EqualityComparer<TKey>.Default;
					while (i < entries.Length)
					{
						if (entries[i].hashCode == num && @default.Equals(entries[i].key, key))
						{
							if (behavior == InsertionBehavior.OverwriteExisting)
							{
								entries[i].value = value;
								return true;
							}
							if (behavior == InsertionBehavior.ThrowOnExisting)
							{
								ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException(key);
							}
							return false;
						}
						else
						{
							i = entries[i].next;
							if (num2 >= entries.Length)
							{
								ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
							}
							num2++;
						}
					}
				}
			}
			else
			{
				while (i < entries.Length)
				{
					if (entries[i].hashCode == num && comparer.Equals(entries[i].key, key))
					{
						if (behavior == InsertionBehavior.OverwriteExisting)
						{
							entries[i].value = value;
							return true;
						}
						if (behavior == InsertionBehavior.ThrowOnExisting)
						{
							ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException(key);
						}
						return false;
					}
					else
					{
						i = entries[i].next;
						if (num2 >= entries.Length)
						{
							ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
						}
						num2++;
					}
				}
			}
			bool flag = false;
			bool flag2 = false;
			int num3;
			if (this._freeCount > 0)
			{
				num3 = this._freeList;
				flag2 = true;
				this._freeCount--;
			}
			else
			{
				int count = this._count;
				if (count == entries.Length)
				{
					this.Resize();
					flag = true;
				}
				num3 = count;
				this._count = count + 1;
				entries = this._entries;
			}
			ref int ptr2 = ref flag ? ref this._buckets[num % this._buckets.Length] : ref ptr;
			ref Dictionary<TKey, TValue>.Entry ptr3 = ref entries[num3];
			if (flag2)
			{
				this._freeList = ptr3.next;
			}
			ptr3.hashCode = num;
			ptr3.next = ptr2 - 1;
			ptr3.key = key;
			ptr3.value = value;
			ptr2 = num3 + 1;
			return true;
		}

		/// <summary>Реализует интерфейс <see cref="T:System.Runtime.Serialization.ISerializable" /> и вызывает событие десериализации при завершении десериализации.</summary>
		/// <param name="sender">Источник события десериализации.</param>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, связанный с текущим экземпляром класса <see cref="T:System.Collections.Generic.Dictionary`2" />, является недопустимым.</exception>
		// Token: 0x060060C0 RID: 24768 RVA: 0x00143F20 File Offset: 0x00142120
		public virtual void OnDeserialization(object sender)
		{
			SerializationInfo serializationInfo;
			HashHelpers.SerializationInfoTable.TryGetValue(this, out serializationInfo);
			if (serializationInfo == null)
			{
				return;
			}
			int @int = serializationInfo.GetInt32("Version");
			int int2 = serializationInfo.GetInt32("HashSize");
			this._comparer = (IEqualityComparer<TKey>)serializationInfo.GetValue("Comparer", typeof(IEqualityComparer<TKey>));
			if (int2 != 0)
			{
				this.Initialize(int2);
				KeyValuePair<TKey, TValue>[] array = (KeyValuePair<TKey, TValue>[])serializationInfo.GetValue("KeyValuePairs", typeof(KeyValuePair<TKey, TValue>[]));
				if (array == null)
				{
					ThrowHelper.ThrowSerializationException(ExceptionResource.Serialization_MissingKeys);
				}
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].Key == null)
					{
						ThrowHelper.ThrowSerializationException(ExceptionResource.Serialization_NullKey);
					}
					this.Add(array[i].Key, array[i].Value);
				}
			}
			else
			{
				this._buckets = null;
			}
			this._version = @int;
			HashHelpers.SerializationInfoTable.Remove(this);
		}

		// Token: 0x060060C1 RID: 24769 RVA: 0x00144010 File Offset: 0x00142210
		private void Resize()
		{
			this.Resize(HashHelpers.ExpandPrime(this._count), false);
		}

		// Token: 0x060060C2 RID: 24770 RVA: 0x00144024 File Offset: 0x00142224
		private void Resize(int newSize, bool forceNewHashCodes)
		{
			int[] array = new int[newSize];
			Dictionary<TKey, TValue>.Entry[] array2 = new Dictionary<TKey, TValue>.Entry[newSize];
			int count = this._count;
			Array.Copy(this._entries, 0, array2, 0, count);
			if (default(TKey) == null && forceNewHashCodes)
			{
				for (int i = 0; i < count; i++)
				{
					if (array2[i].hashCode >= 0)
					{
						array2[i].hashCode = (array2[i].key.GetHashCode() & int.MaxValue);
					}
				}
			}
			for (int j = 0; j < count; j++)
			{
				if (array2[j].hashCode >= 0)
				{
					int num = array2[j].hashCode % newSize;
					array2[j].next = array[num] - 1;
					array[num] = j + 1;
				}
			}
			this._buckets = array;
			this._entries = array2;
		}

		/// <summary>Удаляет значение с указанным ключом из <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary>
		/// <param name="key">Ключ элемента, который требуется удалить.</param>
		/// <returns>Значение <see langword="true" />, если элемент был найден и удален; в противном случае — значение <see langword="false" />.  Этот метод возвращает значение <see langword="false" />, если ключ <paramref name="key" /> не удалось найти в <see cref="T:System.Collections.Generic.Dictionary`2" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		// Token: 0x060060C3 RID: 24771 RVA: 0x00144110 File Offset: 0x00142310
		public bool Remove(TKey key)
		{
			if (key == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
			}
			if (this._buckets != null)
			{
				IEqualityComparer<TKey> comparer = this._comparer;
				int num = ((comparer != null) ? comparer.GetHashCode(key) : key.GetHashCode()) & int.MaxValue;
				int num2 = num % this._buckets.Length;
				int num3 = -1;
				Dictionary<TKey, TValue>.Entry ptr;
				for (int i = this._buckets[num2] - 1; i >= 0; i = ptr.next)
				{
					ptr = ref this._entries[i];
					if (ptr.hashCode == num)
					{
						IEqualityComparer<TKey> comparer2 = this._comparer;
						if ((comparer2 != null) ? comparer2.Equals(ptr.key, key) : EqualityComparer<TKey>.Default.Equals(ptr.key, key))
						{
							if (num3 < 0)
							{
								this._buckets[num2] = ptr.next + 1;
							}
							else
							{
								this._entries[num3].next = ptr.next;
							}
							ptr.hashCode = -1;
							ptr.next = this._freeList;
							if (RuntimeHelpers.IsReferenceOrContainsReferences<TKey>())
							{
								ptr.key = default(TKey);
							}
							if (RuntimeHelpers.IsReferenceOrContainsReferences<TValue>())
							{
								ptr.value = default(TValue);
							}
							this._freeList = i;
							this._freeCount++;
							this._version++;
							return true;
						}
					}
					num3 = i;
				}
			}
			return false;
		}

		// Token: 0x060060C4 RID: 24772 RVA: 0x00144268 File Offset: 0x00142468
		public bool Remove(TKey key, out TValue value)
		{
			if (key == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
			}
			if (this._buckets != null)
			{
				IEqualityComparer<TKey> comparer = this._comparer;
				int num = ((comparer != null) ? comparer.GetHashCode(key) : key.GetHashCode()) & int.MaxValue;
				int num2 = num % this._buckets.Length;
				int num3 = -1;
				Dictionary<TKey, TValue>.Entry ptr;
				for (int i = this._buckets[num2] - 1; i >= 0; i = ptr.next)
				{
					ptr = ref this._entries[i];
					if (ptr.hashCode == num)
					{
						IEqualityComparer<TKey> comparer2 = this._comparer;
						if ((comparer2 != null) ? comparer2.Equals(ptr.key, key) : EqualityComparer<TKey>.Default.Equals(ptr.key, key))
						{
							if (num3 < 0)
							{
								this._buckets[num2] = ptr.next + 1;
							}
							else
							{
								this._entries[num3].next = ptr.next;
							}
							value = ptr.value;
							ptr.hashCode = -1;
							ptr.next = this._freeList;
							if (RuntimeHelpers.IsReferenceOrContainsReferences<TKey>())
							{
								ptr.key = default(TKey);
							}
							if (RuntimeHelpers.IsReferenceOrContainsReferences<TValue>())
							{
								ptr.value = default(TValue);
							}
							this._freeList = i;
							this._freeCount++;
							this._version++;
							return true;
						}
					}
					num3 = i;
				}
			}
			value = default(TValue);
			return false;
		}

		/// <summary>Возвращает значение, связанное с заданным ключом.</summary>
		/// <param name="key">Ключ значения, которое необходимо получить.</param>
		/// <param name="value">Этот метод возвращает значение, связанное с указанным ключом, если он найден; в противном случае — значение по умолчанию для типа параметра <paramref name="value" />. Этот параметр передается неинициализированным.</param>
		/// <returns>
		///   <see langword="true" />, если <see cref="T:System.Collections.Generic.Dictionary`2" /> содержит элемент с указанным ключом, в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		// Token: 0x060060C5 RID: 24773 RVA: 0x001443D4 File Offset: 0x001425D4
		public bool TryGetValue(TKey key, out TValue value)
		{
			int num = this.FindEntry(key);
			if (num >= 0)
			{
				value = this._entries[num].value;
				return true;
			}
			value = default(TValue);
			return false;
		}

		// Token: 0x060060C6 RID: 24774 RVA: 0x0014440E File Offset: 0x0014260E
		public bool TryAdd(TKey key, TValue value)
		{
			return this.TryInsert(key, value, InsertionBehavior.None);
		}

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x060060C7 RID: 24775 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		bool ICollection<KeyValuePair<!0, !1>>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060060C8 RID: 24776 RVA: 0x00144419 File Offset: 0x00142619
		void ICollection<KeyValuePair<!0, !1>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
			this.CopyTo(array, index);
		}

		/// <summary>Копирует элементы коллекции <see cref="T:System.Collections.Generic.ICollection`1" /> в массив, начиная с указанного индекса массива.</summary>
		/// <param name="array">Одномерный массив, в который копируются элементы из коллекции <see cref="T:System.Collections.Generic.ICollection`1" />. Индекс в массиве должен начинаться с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		/// -или- 
		///  В массиве <paramref name="array" /> не используется индексация, начинающаяся с нуля.  
		/// -или- 
		/// Число элементов в исходном массиве <see cref="T:System.Collections.Generic.ICollection`1" /> больше доступного места от положения, заданного значением параметра <paramref name="index" />, до конца массива назначения <paramref name="array" />.  
		/// -или- 
		/// Тип исходного массива <see cref="T:System.Collections.Generic.ICollection`1" /> не может быть автоматически приведен к типу массива назначения <paramref name="array" />.</exception>
		// Token: 0x060060C9 RID: 24777 RVA: 0x00144424 File Offset: 0x00142624
		void ICollection.CopyTo(Array array, int index)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (array.Rank != 1)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
			}
			if (array.GetLowerBound(0) != 0)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_NonZeroLowerBound);
			}
			if (index > array.Length)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (array.Length - index < this.Count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
			}
			KeyValuePair<TKey, TValue>[] array2 = array as KeyValuePair<TKey, TValue>[];
			if (array2 != null)
			{
				this.CopyTo(array2, index);
				return;
			}
			DictionaryEntry[] array3 = array as DictionaryEntry[];
			if (array3 != null)
			{
				Dictionary<TKey, TValue>.Entry[] entries = this._entries;
				for (int i = 0; i < this._count; i++)
				{
					if (entries[i].hashCode >= 0)
					{
						array3[index++] = new DictionaryEntry(entries[i].key, entries[i].value);
					}
				}
				return;
			}
			object[] array4 = array as object[];
			if (array4 == null)
			{
				ThrowHelper.ThrowArgumentException_Argument_InvalidArrayType();
			}
			try
			{
				int count = this._count;
				Dictionary<TKey, TValue>.Entry[] entries2 = this._entries;
				for (int j = 0; j < count; j++)
				{
					if (entries2[j].hashCode >= 0)
					{
						array4[index++] = new KeyValuePair<TKey, TValue>(entries2[j].key, entries2[j].value);
					}
				}
			}
			catch (ArrayTypeMismatchException)
			{
				ThrowHelper.ThrowArgumentException_Argument_InvalidArrayType();
			}
		}

		/// <summary>Возвращает перечислитель, выполняющий перебор элементов в коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для итерации элементов коллекции.</returns>
		// Token: 0x060060CA RID: 24778 RVA: 0x001439F7 File Offset: 0x00141BF7
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new Dictionary<TKey, TValue>.Enumerator(this, 2);
		}

		// Token: 0x060060CB RID: 24779 RVA: 0x00144584 File Offset: 0x00142784
		public int EnsureCapacity(int capacity)
		{
			if (capacity < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.capacity);
			}
			int num = (this._entries == null) ? 0 : this._entries.Length;
			if (num >= capacity)
			{
				return num;
			}
			if (this._buckets == null)
			{
				return this.Initialize(capacity);
			}
			int prime = HashHelpers.GetPrime(capacity);
			this.Resize(prime, false);
			return prime;
		}

		// Token: 0x060060CC RID: 24780 RVA: 0x001445D6 File Offset: 0x001427D6
		public void TrimExcess()
		{
			this.TrimExcess(this.Count);
		}

		// Token: 0x060060CD RID: 24781 RVA: 0x001445E4 File Offset: 0x001427E4
		public void TrimExcess(int capacity)
		{
			if (capacity < this.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.capacity);
			}
			int prime = HashHelpers.GetPrime(capacity);
			Dictionary<TKey, TValue>.Entry[] entries = this._entries;
			int num = (entries == null) ? 0 : entries.Length;
			if (prime >= num)
			{
				return;
			}
			int count = this._count;
			this.Initialize(prime);
			Dictionary<TKey, TValue>.Entry[] entries2 = this._entries;
			int[] buckets = this._buckets;
			int num2 = 0;
			for (int i = 0; i < count; i++)
			{
				int hashCode = entries[i].hashCode;
				if (hashCode >= 0)
				{
					Dictionary<TKey, TValue>.Entry[] array = entries2;
					int num3 = num2;
					array[num3] = entries[i];
					int num4 = hashCode % prime;
					array[num3].next = buckets[num4] - 1;
					buckets[num4] = num2 + 1;
					num2++;
				}
			}
			this._count = num2;
			this._freeCount = 0;
		}

		/// <summary>Получает значение, определяющее, является ли доступ к коллекции <see cref="T:System.Collections.ICollection" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>
		///   <see langword="true" />, если доступ к классу <see cref="T:System.Collections.ICollection" /> является синхронизированным (потокобезопасным); в противном случае — <see langword="false" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.Generic.Dictionary`2" /> это свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x060060CE RID: 24782 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.ICollection" />.</summary>
		/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Collections.ICollection" />.</returns>
		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x060060CF RID: 24783 RVA: 0x001446AB File Offset: 0x001428AB
		object ICollection.SyncRoot
		{
			get
			{
				if (this._syncRoot == null)
				{
					Interlocked.CompareExchange<object>(ref this._syncRoot, new object(), null);
				}
				return this._syncRoot;
			}
		}

		/// <summary>Возвращает значение, показывающее, имеет ли объект <see cref="T:System.Collections.IDictionary" /> фиксированный размер.</summary>
		/// <returns>Значение <see langword="true" />, если словарь <see cref="T:System.Collections.IDictionary" /> имеет фиксированный размер; в противном случае — значение <see langword="false" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.Generic.Dictionary`2" /> это свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x060060D0 RID: 24784 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		bool IDictionary.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает значение, которое определяет, является ли коллекция <see cref="T:System.Collections.IDictionary" /> доступной только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если интерфейс <see cref="T:System.Collections.IDictionary" /> доступен только для чтения; в противном случае — значение <see langword="false" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.Generic.Dictionary`2" /> это свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x060060D1 RID: 24785 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		bool IDictionary.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает интерфейс <see cref="T:System.Collections.ICollection" />, содержащий ключи <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.ICollection" />, содержащий ключи из <see cref="T:System.Collections.IDictionary" />.</returns>
		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x060060D2 RID: 24786 RVA: 0x001446CD File Offset: 0x001428CD
		ICollection IDictionary.Keys
		{
			get
			{
				return this.Keys;
			}
		}

		/// <summary>Возвращает интерфейс <see cref="T:System.Collections.ICollection" />, содержащий значения из <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <returns>Коллекция <see cref="T:System.Collections.ICollection" />, содержащая значения из словаря <see cref="T:System.Collections.IDictionary" />.</returns>
		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x060060D3 RID: 24787 RVA: 0x001446D5 File Offset: 0x001428D5
		ICollection IDictionary.Values
		{
			get
			{
				return this.Values;
			}
		}

		/// <summary>Возвращает или задает значение с указанным ключом.</summary>
		/// <param name="key">Ключ значения, которое необходимо получить.</param>
		/// <returns>Значение, связанное с указанным ключом, или <see langword="null" />, если <paramref name="key" /> отсутствует в словаре или <paramref name="key" /> имеет тип, который не допускает присваивание типу ключа <paramref name="TKey" /> коллекции <see cref="T:System.Collections.Generic.Dictionary`2" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Назначаемое значение и параметр <paramref name="key" /> типа, который не может быть назначен типу ключа <paramref name="TKey" /> объекта <see cref="T:System.Collections.Generic.Dictionary`2" />.  
		/// -или- 
		/// Значение присваивается, при этом тип параметра <paramref name="value" /> не допускает присваивание типу значения <paramref name="TValue" /> объекту <see cref="T:System.Collections.Generic.Dictionary`2" />.</exception>
		// Token: 0x17001129 RID: 4393
		object IDictionary.this[object key]
		{
			get
			{
				if (Dictionary<TKey, TValue>.IsCompatibleKey(key))
				{
					int num = this.FindEntry((TKey)((object)key));
					if (num >= 0)
					{
						return this._entries[num].value;
					}
				}
				return null;
			}
			set
			{
				if (key == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
				}
				ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TValue>(value, ExceptionArgument.value);
				try
				{
					TKey key2 = (TKey)((object)key);
					try
					{
						this[key2] = (TValue)((object)value);
					}
					catch (InvalidCastException)
					{
						ThrowHelper.ThrowWrongValueTypeArgumentException(value, typeof(TValue));
					}
				}
				catch (InvalidCastException)
				{
					ThrowHelper.ThrowWrongKeyTypeArgumentException(key, typeof(TKey));
				}
			}
		}

		// Token: 0x060060D6 RID: 24790 RVA: 0x00144798 File Offset: 0x00142998
		private static bool IsCompatibleKey(object key)
		{
			if (key == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
			}
			return key is TKey;
		}

		/// <summary>Добавляет указанные ключ и значение в словарь.</summary>
		/// <param name="key">Объект, который используется в качестве ключа.</param>
		/// <param name="value">Объект, который используется в качестве значения.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="key" /> имеет тип, который не может быть назначен типу ключа <paramref name="TKey" /> объекта <see cref="T:System.Collections.Generic.Dictionary`2" />.  
		/// -или- 
		///  Тип параметра <paramref name="value" /> не допускает присваивание типу значений <paramref name="TValue" /> словаря <see cref="T:System.Collections.Generic.Dictionary`2" />.  
		/// -или- 
		/// Значение с таким ключом уже существует в <see cref="T:System.Collections.Generic.Dictionary`2" />.</exception>
		// Token: 0x060060D7 RID: 24791 RVA: 0x001447AC File Offset: 0x001429AC
		void IDictionary.Add(object key, object value)
		{
			if (key == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
			}
			ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TValue>(value, ExceptionArgument.value);
			try
			{
				TKey key2 = (TKey)((object)key);
				try
				{
					this.Add(key2, (TValue)((object)value));
				}
				catch (InvalidCastException)
				{
					ThrowHelper.ThrowWrongValueTypeArgumentException(value, typeof(TValue));
				}
			}
			catch (InvalidCastException)
			{
				ThrowHelper.ThrowWrongKeyTypeArgumentException(key, typeof(TKey));
			}
		}

		/// <summary>Определяет, содержится ли элемент с указанным ключом в <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <param name="key">Ключ, который требуется найти в <see cref="T:System.Collections.IDictionary" />.</param>
		/// <returns>
		///   <see langword="true" />, если <see cref="T:System.Collections.IDictionary" /> содержит элемент с указанным ключом, в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		// Token: 0x060060D8 RID: 24792 RVA: 0x00144824 File Offset: 0x00142A24
		bool IDictionary.Contains(object key)
		{
			return Dictionary<TKey, TValue>.IsCompatibleKey(key) && this.ContainsKey((TKey)((object)key));
		}

		/// <summary>Возвращает перечислитель <see cref="T:System.Collections.IDictionaryEnumerator" /> для словаря <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IDictionaryEnumerator" /> для <see cref="T:System.Collections.IDictionary" />.</returns>
		// Token: 0x060060D9 RID: 24793 RVA: 0x0014483C File Offset: 0x00142A3C
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return new Dictionary<TKey, TValue>.Enumerator(this, 1);
		}

		/// <summary>Удаляет элемент с указанным ключом из <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <param name="key">Ключ элемента, который требуется удалить.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		// Token: 0x060060DA RID: 24794 RVA: 0x0014484A File Offset: 0x00142A4A
		void IDictionary.Remove(object key)
		{
			if (Dictionary<TKey, TValue>.IsCompatibleKey(key))
			{
				this.Remove((TKey)((object)key));
			}
		}

		// Token: 0x040039BF RID: 14783
		private int[] _buckets;

		// Token: 0x040039C0 RID: 14784
		private Dictionary<TKey, TValue>.Entry[] _entries;

		// Token: 0x040039C1 RID: 14785
		private int _count;

		// Token: 0x040039C2 RID: 14786
		private int _freeList;

		// Token: 0x040039C3 RID: 14787
		private int _freeCount;

		// Token: 0x040039C4 RID: 14788
		private int _version;

		// Token: 0x040039C5 RID: 14789
		private IEqualityComparer<TKey> _comparer;

		// Token: 0x040039C6 RID: 14790
		private Dictionary<TKey, TValue>.KeyCollection _keys;

		// Token: 0x040039C7 RID: 14791
		private Dictionary<TKey, TValue>.ValueCollection _values;

		// Token: 0x040039C8 RID: 14792
		private object _syncRoot;

		// Token: 0x040039C9 RID: 14793
		private const string VersionName = "Version";

		// Token: 0x040039CA RID: 14794
		private const string HashSizeName = "HashSize";

		// Token: 0x040039CB RID: 14795
		private const string KeyValuePairsName = "KeyValuePairs";

		// Token: 0x040039CC RID: 14796
		private const string ComparerName = "Comparer";

		// Token: 0x02000A8A RID: 2698
		private struct Entry
		{
			// Token: 0x040039CD RID: 14797
			public int hashCode;

			// Token: 0x040039CE RID: 14798
			public int next;

			// Token: 0x040039CF RID: 14799
			public TKey key;

			// Token: 0x040039D0 RID: 14800
			public TValue value;
		}

		/// <summary>Выполняет перечисление элементов коллекции <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary>
		/// <typeparam name="TKey" />
		/// <typeparam name="TValue" />
		// Token: 0x02000A8B RID: 2699
		[Serializable]
		public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator
		{
			// Token: 0x060060DB RID: 24795 RVA: 0x00144861 File Offset: 0x00142A61
			internal Enumerator(Dictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
			{
				this._dictionary = dictionary;
				this._version = dictionary._version;
				this._index = 0;
				this._getEnumeratorRetType = getEnumeratorRetType;
				this._current = default(KeyValuePair<TKey, TValue>);
			}

			/// <summary>Перемещает перечислитель к следующему элементу коллекции <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary>
			/// <returns>Значение <see langword="true" />, если перечислитель был успешно перемещен к следующему элементу; значение <see langword="false" />, если перечислитель достиг конца коллекции.</returns>
			/// <exception cref="T:System.InvalidOperationException">После создания перечислителя семейство было изменено.</exception>
			// Token: 0x060060DC RID: 24796 RVA: 0x00144890 File Offset: 0x00142A90
			public bool MoveNext()
			{
				if (this._version != this._dictionary._version)
				{
					ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
				}
				while (this._index < this._dictionary._count)
				{
					Dictionary<TKey, TValue>.Entry[] entries = this._dictionary._entries;
					int index = this._index;
					this._index = index + 1;
					ref Dictionary<TKey, TValue>.Entry ptr = ref entries[index];
					if (ptr.hashCode >= 0)
					{
						this._current = new KeyValuePair<TKey, TValue>(ptr.key, ptr.value);
						return true;
					}
				}
				this._index = this._dictionary._count + 1;
				this._current = default(KeyValuePair<TKey, TValue>);
				return false;
			}

			/// <summary>Возвращает элемент, расположенный в текущей позиции перечислителя.</summary>
			/// <returns>Элемент коллекции <see cref="T:System.Collections.Generic.Dictionary`2" />, находящийся в текущей позиции перечислителя.</returns>
			// Token: 0x1700112A RID: 4394
			// (get) Token: 0x060060DD RID: 24797 RVA: 0x0014492E File Offset: 0x00142B2E
			public KeyValuePair<TKey, TValue> Current
			{
				get
				{
					return this._current;
				}
			}

			/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.Collections.Generic.Dictionary`2.Enumerator" />.</summary>
			// Token: 0x060060DE RID: 24798 RVA: 0x00004BF9 File Offset: 0x00002DF9
			public void Dispose()
			{
			}

			/// <summary>Возвращает элемент, расположенный в текущей позиции перечислителя.</summary>
			/// <returns>Элемент коллекции, находящийся в текущей позиции перечислителя, в виде объекта <see cref="T:System.Object" />.</returns>
			/// <exception cref="T:System.InvalidOperationException">Перечислитель размещается перед первым элементом семейства или после его последнего элемента.</exception>
			// Token: 0x1700112B RID: 4395
			// (get) Token: 0x060060DF RID: 24799 RVA: 0x00144938 File Offset: 0x00142B38
			object IEnumerator.Current
			{
				get
				{
					if (this._index == 0 || this._index == this._dictionary._count + 1)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen();
					}
					if (this._getEnumeratorRetType == 1)
					{
						return new DictionaryEntry(this._current.Key, this._current.Value);
					}
					return new KeyValuePair<TKey, TValue>(this._current.Key, this._current.Value);
				}
			}

			/// <summary>Устанавливает перечислитель в его начальное положение, т. е. перед первым элементом коллекции.</summary>
			/// <exception cref="T:System.InvalidOperationException">После создания перечислителя семейство было изменено.</exception>
			// Token: 0x060060E0 RID: 24800 RVA: 0x001449BB File Offset: 0x00142BBB
			void IEnumerator.Reset()
			{
				if (this._version != this._dictionary._version)
				{
					ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
				}
				this._index = 0;
				this._current = default(KeyValuePair<TKey, TValue>);
			}

			/// <summary>Возвращает элемент, расположенный в текущей позиции перечислителя.</summary>
			/// <returns>Элемент словаря, находящийся в текущей позиции перечислителя, в виде объекта <see cref="T:System.Collections.DictionaryEntry" />.</returns>
			/// <exception cref="T:System.InvalidOperationException">Перечислитель размещается перед первым элементом семейства или после его последнего элемента.</exception>
			// Token: 0x1700112C RID: 4396
			// (get) Token: 0x060060E1 RID: 24801 RVA: 0x001449E8 File Offset: 0x00142BE8
			DictionaryEntry IDictionaryEnumerator.Entry
			{
				get
				{
					if (this._index == 0 || this._index == this._dictionary._count + 1)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen();
					}
					return new DictionaryEntry(this._current.Key, this._current.Value);
				}
			}

			/// <summary>Возвращает ключ элемента, расположенного в текущей позиции перечислителя.</summary>
			/// <returns>Ключ элемента словаря, расположенного в текущей позиции перечислителя.</returns>
			/// <exception cref="T:System.InvalidOperationException">Перечислитель размещается перед первым элементом семейства или после его последнего элемента.</exception>
			// Token: 0x1700112D RID: 4397
			// (get) Token: 0x060060E2 RID: 24802 RVA: 0x00144A3C File Offset: 0x00142C3C
			object IDictionaryEnumerator.Key
			{
				get
				{
					if (this._index == 0 || this._index == this._dictionary._count + 1)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen();
					}
					return this._current.Key;
				}
			}

			/// <summary>Возвращает значение элемента, расположенного в текущей позиции перечислителя.</summary>
			/// <returns>Значение элемента словаря, расположенного в текущей позиции перечислителя.</returns>
			/// <exception cref="T:System.InvalidOperationException">Перечислитель размещается перед первым элементом семейства или после его последнего элемента.</exception>
			// Token: 0x1700112E RID: 4398
			// (get) Token: 0x060060E3 RID: 24803 RVA: 0x00144A70 File Offset: 0x00142C70
			object IDictionaryEnumerator.Value
			{
				get
				{
					if (this._index == 0 || this._index == this._dictionary._count + 1)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen();
					}
					return this._current.Value;
				}
			}

			// Token: 0x040039D1 RID: 14801
			private Dictionary<TKey, TValue> _dictionary;

			// Token: 0x040039D2 RID: 14802
			private int _version;

			// Token: 0x040039D3 RID: 14803
			private int _index;

			// Token: 0x040039D4 RID: 14804
			private KeyValuePair<TKey, TValue> _current;

			// Token: 0x040039D5 RID: 14805
			private int _getEnumeratorRetType;

			// Token: 0x040039D6 RID: 14806
			internal const int DictEntry = 1;

			// Token: 0x040039D7 RID: 14807
			internal const int KeyValuePair = 2;
		}

		/// <summary>Представляет коллекцию ключей в <see cref="T:System.Collections.Generic.Dictionary`2" />. Этот класс не наследуется.</summary>
		/// <typeparam name="TKey" />
		/// <typeparam name="TValue" />
		// Token: 0x02000A8C RID: 2700
		[DebuggerDisplay("Count = {Count}")]
		[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView<, >))]
		[Serializable]
		public sealed class KeyCollection : ICollection<!0>, IEnumerable<!0>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
		{
			/// <summary>Инициализирует новый экземпляр <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" />, который отражает ключи в указанном словаре <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary>
			/// <param name="dictionary">Словарь <see cref="T:System.Collections.Generic.Dictionary`2" />, ключи которого отражены в новой коллекции <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" />.</param>
			/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="dictionary" /> имеет значение <see langword="null" />.</exception>
			// Token: 0x060060E4 RID: 24804 RVA: 0x00144AA4 File Offset: 0x00142CA4
			public KeyCollection(Dictionary<TKey, TValue> dictionary)
			{
				if (dictionary == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.dictionary);
				}
				this._dictionary = dictionary;
			}

			/// <summary>Возвращает перечислитель, осуществляющий перебор элементов списка <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" />.</summary>
			/// <returns>Новый объект <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection.Enumerator" /> для <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" />.</returns>
			// Token: 0x060060E5 RID: 24805 RVA: 0x00144ABC File Offset: 0x00142CBC
			public Dictionary<TKey, TValue>.KeyCollection.Enumerator GetEnumerator()
			{
				return new Dictionary<TKey, TValue>.KeyCollection.Enumerator(this._dictionary);
			}

			/// <summary>Копирует элементы коллекции <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" /> в существующий одномерный массив <see cref="T:System.Array" />, начиная с указанного значения индекса массива.</summary>
			/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из интерфейса <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
			/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
			/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
			/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
			/// <exception cref="T:System.ArgumentException">Число элементов в исходной коллекции <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" /> больше доступного места от положения, заданного значением параметра <paramref name="index" />, до конца массива назначения <paramref name="array" />.</exception>
			// Token: 0x060060E6 RID: 24806 RVA: 0x00144ACC File Offset: 0x00142CCC
			public void CopyTo(TKey[] array, int index)
			{
				if (array == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
				}
				if (index < 0 || index > array.Length)
				{
					ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
				}
				if (array.Length - index < this._dictionary.Count)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
				}
				int count = this._dictionary._count;
				Dictionary<TKey, TValue>.Entry[] entries = this._dictionary._entries;
				for (int i = 0; i < count; i++)
				{
					if (entries[i].hashCode >= 0)
					{
						array[index++] = entries[i].key;
					}
				}
			}

			/// <summary>Получает число элементов, содержащихся в интерфейсе <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" />.</summary>
			/// <returns>Число элементов, содержащихся в интерфейсе <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" />.  
			/// Получение значения данного свойства является операцией порядка сложности O(1).</returns>
			// Token: 0x1700112F RID: 4399
			// (get) Token: 0x060060E7 RID: 24807 RVA: 0x00144B54 File Offset: 0x00142D54
			public int Count
			{
				get
				{
					return this._dictionary.Count;
				}
			}

			// Token: 0x17001130 RID: 4400
			// (get) Token: 0x060060E8 RID: 24808 RVA: 0x000040F7 File Offset: 0x000022F7
			bool ICollection<!0>.IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x060060E9 RID: 24809 RVA: 0x00144B61 File Offset: 0x00142D61
			void ICollection<!0>.Add(TKey item)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_KeyCollectionSet);
			}

			// Token: 0x060060EA RID: 24810 RVA: 0x00144B61 File Offset: 0x00142D61
			void ICollection<!0>.Clear()
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_KeyCollectionSet);
			}

			// Token: 0x060060EB RID: 24811 RVA: 0x00144B6A File Offset: 0x00142D6A
			bool ICollection<!0>.Contains(TKey item)
			{
				return this._dictionary.ContainsKey(item);
			}

			// Token: 0x060060EC RID: 24812 RVA: 0x00144B78 File Offset: 0x00142D78
			bool ICollection<!0>.Remove(TKey item)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_KeyCollectionSet);
				return false;
			}

			// Token: 0x060060ED RID: 24813 RVA: 0x00144B82 File Offset: 0x00142D82
			IEnumerator<TKey> IEnumerable<!0>.GetEnumerator()
			{
				return new Dictionary<TKey, TValue>.KeyCollection.Enumerator(this._dictionary);
			}

			/// <summary>Возвращает перечислитель, который осуществляет итерацию по коллекции.</summary>
			/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для итерации элементов коллекции.</returns>
			// Token: 0x060060EE RID: 24814 RVA: 0x00144B82 File Offset: 0x00142D82
			IEnumerator IEnumerable.GetEnumerator()
			{
				return new Dictionary<TKey, TValue>.KeyCollection.Enumerator(this._dictionary);
			}

			/// <summary>Копирует элементы коллекции <see cref="T:System.Collections.ICollection" /> в массив <see cref="T:System.Array" />, начиная с указанного индекса массива <see cref="T:System.Array" />.</summary>
			/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из интерфейса <see cref="T:System.Collections.ICollection" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
			/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
			/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
			/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
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
			// Token: 0x060060EF RID: 24815 RVA: 0x00144B94 File Offset: 0x00142D94
			void ICollection.CopyTo(Array array, int index)
			{
				if (array == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
				}
				if (array.Rank != 1)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
				}
				if (array.GetLowerBound(0) != 0)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_NonZeroLowerBound);
				}
				if (index > array.Length)
				{
					ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
				}
				if (array.Length - index < this._dictionary.Count)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
				}
				TKey[] array2 = array as TKey[];
				if (array2 != null)
				{
					this.CopyTo(array2, index);
					return;
				}
				object[] array3 = array as object[];
				if (array3 == null)
				{
					ThrowHelper.ThrowArgumentException_Argument_InvalidArrayType();
				}
				int count = this._dictionary._count;
				Dictionary<TKey, TValue>.Entry[] entries = this._dictionary._entries;
				try
				{
					for (int i = 0; i < count; i++)
					{
						if (entries[i].hashCode >= 0)
						{
							array3[index++] = entries[i].key;
						}
					}
				}
				catch (ArrayTypeMismatchException)
				{
					ThrowHelper.ThrowArgumentException_Argument_InvalidArrayType();
				}
			}

			/// <summary>Возвращает значение, показывающее, является ли доступ к коллекции <see cref="T:System.Collections.ICollection" /> синхронизированным (потокобезопасным).</summary>
			/// <returns>
			///   <see langword="true" />, если доступ к классу <see cref="T:System.Collections.ICollection" /> является синхронизированным (потокобезопасным); в противном случае — <see langword="false" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" /> это свойство всегда возвращает значение <see langword="false" />.</returns>
			// Token: 0x17001131 RID: 4401
			// (get) Token: 0x060060F0 RID: 24816 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.ICollection" />.</summary>
			/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Collections.ICollection" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" /> это свойство всегда возвращает текущий экземпляр.</returns>
			// Token: 0x17001132 RID: 4402
			// (get) Token: 0x060060F1 RID: 24817 RVA: 0x00144C80 File Offset: 0x00142E80
			object ICollection.SyncRoot
			{
				get
				{
					return ((ICollection)this._dictionary).SyncRoot;
				}
			}

			// Token: 0x040039D8 RID: 14808
			private Dictionary<TKey, TValue> _dictionary;

			/// <summary>Выполняет перечисление элементов коллекции <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" />.</summary>
			/// <typeparam name="TKey" />
			/// <typeparam name="TValue" />
			// Token: 0x02000A8D RID: 2701
			[Serializable]
			public struct Enumerator : IEnumerator<!0>, IDisposable, IEnumerator
			{
				// Token: 0x060060F2 RID: 24818 RVA: 0x00144C8D File Offset: 0x00142E8D
				internal Enumerator(Dictionary<TKey, TValue> dictionary)
				{
					this._dictionary = dictionary;
					this._version = dictionary._version;
					this._index = 0;
					this._currentKey = default(TKey);
				}

				/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection.Enumerator" />.</summary>
				// Token: 0x060060F3 RID: 24819 RVA: 0x00004BF9 File Offset: 0x00002DF9
				public void Dispose()
				{
				}

				/// <summary>Перемещает перечислитель к следующему элементу коллекции <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" />.</summary>
				/// <returns>Значение <see langword="true" />, если перечислитель был успешно перемещен к следующему элементу; значение <see langword="false" />, если перечислитель достиг конца коллекции.</returns>
				/// <exception cref="T:System.InvalidOperationException">После создания перечислителя семейство было изменено.</exception>
				// Token: 0x060060F4 RID: 24820 RVA: 0x00144CB8 File Offset: 0x00142EB8
				public bool MoveNext()
				{
					if (this._version != this._dictionary._version)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
					}
					while (this._index < this._dictionary._count)
					{
						Dictionary<TKey, TValue>.Entry[] entries = this._dictionary._entries;
						int index = this._index;
						this._index = index + 1;
						ref Dictionary<TKey, TValue>.Entry ptr = ref entries[index];
						if (ptr.hashCode >= 0)
						{
							this._currentKey = ptr.key;
							return true;
						}
					}
					this._index = this._dictionary._count + 1;
					this._currentKey = default(TKey);
					return false;
				}

				/// <summary>Возвращает элемент, расположенный в текущей позиции перечислителя.</summary>
				/// <returns>Элемент коллекции <see cref="T:System.Collections.Generic.Dictionary`2.KeyCollection" />, находящийся в текущей позиции перечислителя.</returns>
				// Token: 0x17001133 RID: 4403
				// (get) Token: 0x060060F5 RID: 24821 RVA: 0x00144D4B File Offset: 0x00142F4B
				public TKey Current
				{
					get
					{
						return this._currentKey;
					}
				}

				/// <summary>Возвращает элемент, расположенный в текущей позиции перечислителя.</summary>
				/// <returns>Элемент коллекции, соответствующий текущей позиции перечислителя.</returns>
				/// <exception cref="T:System.InvalidOperationException">Перечислитель размещается перед первым элементом семейства или после его последнего элемента.</exception>
				// Token: 0x17001134 RID: 4404
				// (get) Token: 0x060060F6 RID: 24822 RVA: 0x00144D53 File Offset: 0x00142F53
				object IEnumerator.Current
				{
					get
					{
						if (this._index == 0 || this._index == this._dictionary._count + 1)
						{
							ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen();
						}
						return this._currentKey;
					}
				}

				/// <summary>Устанавливает перечислитель в его начальное положение, т. е. перед первым элементом коллекции.</summary>
				/// <exception cref="T:System.InvalidOperationException">После создания перечислителя семейство было изменено.</exception>
				// Token: 0x060060F7 RID: 24823 RVA: 0x00144D82 File Offset: 0x00142F82
				void IEnumerator.Reset()
				{
					if (this._version != this._dictionary._version)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
					}
					this._index = 0;
					this._currentKey = default(TKey);
				}

				// Token: 0x040039D9 RID: 14809
				private Dictionary<TKey, TValue> _dictionary;

				// Token: 0x040039DA RID: 14810
				private int _index;

				// Token: 0x040039DB RID: 14811
				private int _version;

				// Token: 0x040039DC RID: 14812
				private TKey _currentKey;
			}
		}

		/// <summary>Представляет коллекцию значений в <see cref="T:System.Collections.Generic.Dictionary`2" />. Этот класс не наследуется.</summary>
		/// <typeparam name="TKey" />
		/// <typeparam name="TValue" />
		// Token: 0x02000A8E RID: 2702
		[DebuggerDisplay("Count = {Count}")]
		[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView<, >))]
		[Serializable]
		public sealed class ValueCollection : ICollection<!1>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
		{
			/// <summary>Инициализирует новый экземпляр <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" />, который отражает значения в указанном словаре <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary>
			/// <param name="dictionary">Словарь <see cref="T:System.Collections.Generic.Dictionary`2" />, значения которого отражены в новой коллекции <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" />.</param>
			/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="dictionary" /> имеет значение <see langword="null" />.</exception>
			// Token: 0x060060F8 RID: 24824 RVA: 0x00144DAF File Offset: 0x00142FAF
			public ValueCollection(Dictionary<TKey, TValue> dictionary)
			{
				if (dictionary == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.dictionary);
				}
				this._dictionary = dictionary;
			}

			/// <summary>Возвращает перечислитель, осуществляющий перебор элементов списка <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" />.</summary>
			/// <returns>Новый объект <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection.Enumerator" /> для <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" />.</returns>
			// Token: 0x060060F9 RID: 24825 RVA: 0x00144DC7 File Offset: 0x00142FC7
			public Dictionary<TKey, TValue>.ValueCollection.Enumerator GetEnumerator()
			{
				return new Dictionary<TKey, TValue>.ValueCollection.Enumerator(this._dictionary);
			}

			/// <summary>Копирует элементы коллекции <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" /> в существующий одномерный массив <see cref="T:System.Array" />, начиная с указанного значения индекса массива.</summary>
			/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из интерфейса <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
			/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
			/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
			/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
			/// <exception cref="T:System.ArgumentException">Число элементов в исходной коллекции <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" /> больше доступного места от положения, заданного значением параметра <paramref name="index" />, до конца массива назначения <paramref name="array" />.</exception>
			// Token: 0x060060FA RID: 24826 RVA: 0x00144DD4 File Offset: 0x00142FD4
			public void CopyTo(TValue[] array, int index)
			{
				if (array == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
				}
				if (index < 0 || index > array.Length)
				{
					ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
				}
				if (array.Length - index < this._dictionary.Count)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
				}
				int count = this._dictionary._count;
				Dictionary<TKey, TValue>.Entry[] entries = this._dictionary._entries;
				for (int i = 0; i < count; i++)
				{
					if (entries[i].hashCode >= 0)
					{
						array[index++] = entries[i].value;
					}
				}
			}

			/// <summary>Получает число элементов, содержащихся в интерфейсе <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" />.</summary>
			/// <returns>Число элементов, содержащихся в интерфейсе <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" />.</returns>
			// Token: 0x17001135 RID: 4405
			// (get) Token: 0x060060FB RID: 24827 RVA: 0x00144E5C File Offset: 0x0014305C
			public int Count
			{
				get
				{
					return this._dictionary.Count;
				}
			}

			// Token: 0x17001136 RID: 4406
			// (get) Token: 0x060060FC RID: 24828 RVA: 0x000040F7 File Offset: 0x000022F7
			bool ICollection<!1>.IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x060060FD RID: 24829 RVA: 0x00144E69 File Offset: 0x00143069
			void ICollection<!1>.Add(TValue item)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ValueCollectionSet);
			}

			// Token: 0x060060FE RID: 24830 RVA: 0x00144E72 File Offset: 0x00143072
			bool ICollection<!1>.Remove(TValue item)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ValueCollectionSet);
				return false;
			}

			// Token: 0x060060FF RID: 24831 RVA: 0x00144E69 File Offset: 0x00143069
			void ICollection<!1>.Clear()
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ValueCollectionSet);
			}

			// Token: 0x06006100 RID: 24832 RVA: 0x00144E7C File Offset: 0x0014307C
			bool ICollection<!1>.Contains(TValue item)
			{
				return this._dictionary.ContainsValue(item);
			}

			// Token: 0x06006101 RID: 24833 RVA: 0x00144E8A File Offset: 0x0014308A
			IEnumerator<TValue> IEnumerable<!1>.GetEnumerator()
			{
				return new Dictionary<TKey, TValue>.ValueCollection.Enumerator(this._dictionary);
			}

			/// <summary>Возвращает перечислитель, который осуществляет итерацию по коллекции.</summary>
			/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для итерации элементов коллекции.</returns>
			// Token: 0x06006102 RID: 24834 RVA: 0x00144E8A File Offset: 0x0014308A
			IEnumerator IEnumerable.GetEnumerator()
			{
				return new Dictionary<TKey, TValue>.ValueCollection.Enumerator(this._dictionary);
			}

			/// <summary>Копирует элементы коллекции <see cref="T:System.Collections.ICollection" /> в массив <see cref="T:System.Array" />, начиная с указанного индекса массива <see cref="T:System.Array" />.</summary>
			/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из интерфейса <see cref="T:System.Collections.ICollection" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
			/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
			/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
			/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
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
			// Token: 0x06006103 RID: 24835 RVA: 0x00144E9C File Offset: 0x0014309C
			void ICollection.CopyTo(Array array, int index)
			{
				if (array == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
				}
				if (array.Rank != 1)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
				}
				if (array.GetLowerBound(0) != 0)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_NonZeroLowerBound);
				}
				if (index > array.Length)
				{
					ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
				}
				if (array.Length - index < this._dictionary.Count)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
				}
				TValue[] array2 = array as TValue[];
				if (array2 != null)
				{
					this.CopyTo(array2, index);
					return;
				}
				object[] array3 = array as object[];
				if (array3 == null)
				{
					ThrowHelper.ThrowArgumentException_Argument_InvalidArrayType();
				}
				int count = this._dictionary._count;
				Dictionary<TKey, TValue>.Entry[] entries = this._dictionary._entries;
				try
				{
					for (int i = 0; i < count; i++)
					{
						if (entries[i].hashCode >= 0)
						{
							array3[index++] = entries[i].value;
						}
					}
				}
				catch (ArrayTypeMismatchException)
				{
					ThrowHelper.ThrowArgumentException_Argument_InvalidArrayType();
				}
			}

			/// <summary>Возвращает значение, показывающее, является ли доступ к коллекции <see cref="T:System.Collections.ICollection" /> синхронизированным (потокобезопасным).</summary>
			/// <returns>
			///   <see langword="true" />, если доступ к классу <see cref="T:System.Collections.ICollection" /> является синхронизированным (потокобезопасным); в противном случае — <see langword="false" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" /> это свойство всегда возвращает значение <see langword="false" />.</returns>
			// Token: 0x17001137 RID: 4407
			// (get) Token: 0x06006104 RID: 24836 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.ICollection" />.</summary>
			/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Collections.ICollection" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" /> это свойство всегда возвращает текущий экземпляр.</returns>
			// Token: 0x17001138 RID: 4408
			// (get) Token: 0x06006105 RID: 24837 RVA: 0x00144F88 File Offset: 0x00143188
			object ICollection.SyncRoot
			{
				get
				{
					return ((ICollection)this._dictionary).SyncRoot;
				}
			}

			// Token: 0x040039DD RID: 14813
			private Dictionary<TKey, TValue> _dictionary;

			/// <summary>Выполняет перечисление элементов коллекции <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" />.</summary>
			/// <typeparam name="TKey" />
			/// <typeparam name="TValue" />
			// Token: 0x02000A8F RID: 2703
			[Serializable]
			public struct Enumerator : IEnumerator<TValue>, IDisposable, IEnumerator
			{
				// Token: 0x06006106 RID: 24838 RVA: 0x00144F95 File Offset: 0x00143195
				internal Enumerator(Dictionary<TKey, TValue> dictionary)
				{
					this._dictionary = dictionary;
					this._version = dictionary._version;
					this._index = 0;
					this._currentValue = default(TValue);
				}

				/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection.Enumerator" />.</summary>
				// Token: 0x06006107 RID: 24839 RVA: 0x00004BF9 File Offset: 0x00002DF9
				public void Dispose()
				{
				}

				/// <summary>Перемещает перечислитель к следующему элементу коллекции <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" />.</summary>
				/// <returns>Значение <see langword="true" />, если перечислитель был успешно перемещен к следующему элементу; значение <see langword="false" />, если перечислитель достиг конца коллекции.</returns>
				/// <exception cref="T:System.InvalidOperationException">После создания перечислителя семейство было изменено.</exception>
				// Token: 0x06006108 RID: 24840 RVA: 0x00144FC0 File Offset: 0x001431C0
				public bool MoveNext()
				{
					if (this._version != this._dictionary._version)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
					}
					while (this._index < this._dictionary._count)
					{
						Dictionary<TKey, TValue>.Entry[] entries = this._dictionary._entries;
						int index = this._index;
						this._index = index + 1;
						ref Dictionary<TKey, TValue>.Entry ptr = ref entries[index];
						if (ptr.hashCode >= 0)
						{
							this._currentValue = ptr.value;
							return true;
						}
					}
					this._index = this._dictionary._count + 1;
					this._currentValue = default(TValue);
					return false;
				}

				/// <summary>Возвращает элемент, расположенный в текущей позиции перечислителя.</summary>
				/// <returns>Элемент коллекции <see cref="T:System.Collections.Generic.Dictionary`2.ValueCollection" />, находящийся в текущей позиции перечислителя.</returns>
				// Token: 0x17001139 RID: 4409
				// (get) Token: 0x06006109 RID: 24841 RVA: 0x00145053 File Offset: 0x00143253
				public TValue Current
				{
					get
					{
						return this._currentValue;
					}
				}

				/// <summary>Возвращает элемент, расположенный в текущей позиции перечислителя.</summary>
				/// <returns>Элемент коллекции, соответствующий текущей позиции перечислителя.</returns>
				/// <exception cref="T:System.InvalidOperationException">Перечислитель размещается перед первым элементом семейства или после его последнего элемента.</exception>
				// Token: 0x1700113A RID: 4410
				// (get) Token: 0x0600610A RID: 24842 RVA: 0x0014505B File Offset: 0x0014325B
				object IEnumerator.Current
				{
					get
					{
						if (this._index == 0 || this._index == this._dictionary._count + 1)
						{
							ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen();
						}
						return this._currentValue;
					}
				}

				/// <summary>Устанавливает перечислитель в его начальное положение, т. е. перед первым элементом коллекции.</summary>
				/// <exception cref="T:System.InvalidOperationException">После создания перечислителя семейство было изменено.</exception>
				// Token: 0x0600610B RID: 24843 RVA: 0x0014508A File Offset: 0x0014328A
				void IEnumerator.Reset()
				{
					if (this._version != this._dictionary._version)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
					}
					this._index = 0;
					this._currentValue = default(TValue);
				}

				// Token: 0x040039DE RID: 14814
				private Dictionary<TKey, TValue> _dictionary;

				// Token: 0x040039DF RID: 14815
				private int _index;

				// Token: 0x040039E0 RID: 14816
				private int _version;

				// Token: 0x040039E1 RID: 14817
				private TValue _currentValue;
			}
		}
	}
}
