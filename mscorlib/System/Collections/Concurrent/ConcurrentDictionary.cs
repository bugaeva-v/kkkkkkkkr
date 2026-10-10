using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;

namespace System.Collections.Concurrent
{
	/// <summary>Представляет потокобезопасную коллекцию пар "ключ-значение", доступ к которой могут одновременно получать несколько потоков.</summary>
	/// <typeparam name="TKey">Тип ключей в словаре.</typeparam>
	/// <typeparam name="TValue">Тип значений в словаре.</typeparam>
	// Token: 0x02000A58 RID: 2648
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(IDictionaryDebugView<, >))]
	[Serializable]
	public class ConcurrentDictionary<TKey, TValue> : IDictionary<!0, !1>, ICollection<KeyValuePair<!0, !1>>, IEnumerable<KeyValuePair<!0, !1>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<!0, !1>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>
	{
		// Token: 0x06005EF3 RID: 24307 RVA: 0x0013F0E8 File Offset: 0x0013D2E8
		private static bool IsValueWriteAtomic()
		{
			Type typeFromHandle = typeof(TValue);
			if (!typeFromHandle.IsValueType)
			{
				return true;
			}
			switch (Type.GetTypeCode(typeFromHandle))
			{
			case TypeCode.Boolean:
			case TypeCode.Char:
			case TypeCode.SByte:
			case TypeCode.Byte:
			case TypeCode.Int16:
			case TypeCode.UInt16:
			case TypeCode.Int32:
			case TypeCode.UInt32:
			case TypeCode.Single:
				return true;
			case TypeCode.Int64:
			case TypeCode.UInt64:
			case TypeCode.Double:
				return IntPtr.Size == 8;
			default:
				return false;
			}
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />, который обладает уровнем параллелизма и начальной емкостью по умолчанию, а также использует для типа ключа функцию сравнения по умолчанию.</summary>
		// Token: 0x06005EF4 RID: 24308 RVA: 0x0013F157 File Offset: 0x0013D357
		public ConcurrentDictionary() : this(ConcurrentDictionary<TKey, TValue>.DefaultConcurrencyLevel, 31, true, null)
		{
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />, который обладает указанными уровнем параллелизма и емкостью, а также использует для типа ключей функцию сравнения по умолчанию.</summary>
		/// <param name="concurrencyLevel">Предполагаемое количество потоков, которые будут параллельно обновлять коллекцию <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</param>
		/// <param name="capacity">Начальное количество элементов, которое может содержать коллекция <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="concurrencyLevel" /> меньше 1.  
		/// -или- 
		///  Значение параметра <paramref name="capacity" /> меньше 0.</exception>
		// Token: 0x06005EF5 RID: 24309 RVA: 0x0013F168 File Offset: 0x0013D368
		public ConcurrentDictionary(int concurrencyLevel, int capacity) : this(concurrencyLevel, capacity, false, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />, который содержит элементы, скопированные из указанной коллекции <see cref="T:System.Collections.Generic.IEnumerable`1" />, обладает уровнем параллелизма и начальной емкостью по умолчанию, а также использует для типа ключа функцию сравнения по умолчанию.</summary>
		/// <param name="collection">Объект <see cref="T:System.Collections.Generic.IEnumerable`1" />, элементы которого копируются в новый объект <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="collection" /> или любой из его ключей — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="collection" /> содержит один или несколько ключей-дубликатов.</exception>
		// Token: 0x06005EF6 RID: 24310 RVA: 0x0013F174 File Offset: 0x0013D374
		public ConcurrentDictionary(IEnumerable<KeyValuePair<TKey, TValue>> collection) : this(collection, null)
		{
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />, который имеет уровень параллелизма и емкость по умолчанию, а также использует указанный интерфейс <see cref="T:System.Collections.Generic.IEqualityComparer`1" />.</summary>
		/// <param name="comparer">Реализация сравнения равенства, используемая при сравнении ключей.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="comparer" /> — <see langword="null" />.</exception>
		// Token: 0x06005EF7 RID: 24311 RVA: 0x0013F17E File Offset: 0x0013D37E
		public ConcurrentDictionary(IEqualityComparer<TKey> comparer) : this(ConcurrentDictionary<TKey, TValue>.DefaultConcurrencyLevel, 31, true, comparer)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />, который содержит элементы, скопированные из указанной коллекции <see cref="T:System.Collections.IEnumerable" />, обладает уровнем параллелизма по умолчанию, начальной емкостью по умолчанию, а также использует заданный интерфейс <see cref="T:System.Collections.Generic.IEqualityComparer`1" />.</summary>
		/// <param name="collection">Объект <see cref="T:System.Collections.Generic.IEnumerable`1" />, элементы которого копируются в новый объект <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</param>
		/// <param name="comparer">Реализация интерфейса <see cref="T:System.Collections.Generic.IEqualityComparer`1" />, используемая при сравнении ключей.</param>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="collection" /> или <paramref name="comparer" /> — <see langword="null" />.</exception>
		// Token: 0x06005EF8 RID: 24312 RVA: 0x0013F18F File Offset: 0x0013D38F
		public ConcurrentDictionary(IEnumerable<KeyValuePair<TKey, TValue>> collection, IEqualityComparer<TKey> comparer) : this(comparer)
		{
			if (collection == null)
			{
				throw new ArgumentNullException("collection");
			}
			this.InitializeFromCollection(collection);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />, который содержит элементы, скопированные из заданной коллекции <see cref="T:System.Collections.IEnumerable" />, и использует указанный интерфейс <see cref="T:System.Collections.Generic.IEqualityComparer`1" />.</summary>
		/// <param name="concurrencyLevel">Предполагаемое количество потоков, которые будут параллельно обновлять коллекцию <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</param>
		/// <param name="collection">Объект <see cref="T:System.Collections.Generic.IEnumerable`1" />, элементы которого копируются в новый объект <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</param>
		/// <param name="comparer">Реализация интерфейса <see cref="T:System.Collections.Generic.IEqualityComparer`1" />, используемая при сравнении ключей.</param>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="collection" /> или <paramref name="comparer" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="concurrencyLevel" /> меньше 1.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="collection" /> содержит один или несколько ключей-дубликатов.</exception>
		// Token: 0x06005EF9 RID: 24313 RVA: 0x0013F1AD File Offset: 0x0013D3AD
		public ConcurrentDictionary(int concurrencyLevel, IEnumerable<KeyValuePair<TKey, TValue>> collection, IEqualityComparer<TKey> comparer) : this(concurrencyLevel, 31, false, comparer)
		{
			if (collection == null)
			{
				throw new ArgumentNullException("collection");
			}
			this.InitializeFromCollection(collection);
		}

		// Token: 0x06005EFA RID: 24314 RVA: 0x0013F1D0 File Offset: 0x0013D3D0
		private void InitializeFromCollection(IEnumerable<KeyValuePair<TKey, TValue>> collection)
		{
			foreach (KeyValuePair<TKey, TValue> keyValuePair in collection)
			{
				if (keyValuePair.Key == null)
				{
					ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
				}
				TValue tvalue;
				if (!this.TryAddInternal(keyValuePair.Key, this._comparer.GetHashCode(keyValuePair.Key), keyValuePair.Value, false, false, out tvalue))
				{
					throw new ArgumentException("The source argument contains duplicate keys.");
				}
			}
			if (this._budget == 0)
			{
				this._budget = this._tables._buckets.Length / this._tables._locks.Length;
			}
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />, который обладает указанными уровнем параллелизма и начальной емкостью, а также использует указанный интерфейс <see cref="T:System.Collections.Generic.IEqualityComparer`1" />.</summary>
		/// <param name="concurrencyLevel">Предполагаемое количество потоков, которые будут параллельно обновлять коллекцию <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</param>
		/// <param name="capacity">Начальное количество элементов, которое может содержать коллекция <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</param>
		/// <param name="comparer">Реализация интерфейса <see cref="T:System.Collections.Generic.IEqualityComparer`1" />, используемая при сравнении ключей.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="comparer" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="concurrencyLevel" /> или <paramref name="capacity" /> меньше 1.</exception>
		// Token: 0x06005EFB RID: 24315 RVA: 0x0013F288 File Offset: 0x0013D488
		public ConcurrentDictionary(int concurrencyLevel, int capacity, IEqualityComparer<TKey> comparer) : this(concurrencyLevel, capacity, false, comparer)
		{
		}

		// Token: 0x06005EFC RID: 24316 RVA: 0x0013F294 File Offset: 0x0013D494
		internal ConcurrentDictionary(int concurrencyLevel, int capacity, bool growLockArray, IEqualityComparer<TKey> comparer)
		{
			if (concurrencyLevel < 1)
			{
				throw new ArgumentOutOfRangeException("concurrencyLevel", "The concurrencyLevel argument must be positive.");
			}
			if (capacity < 0)
			{
				throw new ArgumentOutOfRangeException("capacity", "The capacity argument must be greater than or equal to zero.");
			}
			if (capacity < concurrencyLevel)
			{
				capacity = concurrencyLevel;
			}
			object[] array = new object[concurrencyLevel];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new object();
			}
			int[] countPerLock = new int[array.Length];
			ConcurrentDictionary<TKey, TValue>.Node[] array2 = new ConcurrentDictionary<TKey, TValue>.Node[capacity];
			this._tables = new ConcurrentDictionary<TKey, TValue>.Tables(array2, array, countPerLock);
			this._comparer = (comparer ?? EqualityComparer<TKey>.Default);
			this._growLockArray = growLockArray;
			this._budget = array2.Length / array.Length;
		}

		/// <summary>Пытается добавить указанную пару "ключ-значение" в коллекцию <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</summary>
		/// <param name="key">Ключ добавляемого элемента.</param>
		/// <param name="value">Добавляемое значение элемента. Для ссылочных типов допускается значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если пара "ключ-значение" были добавлены в <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" /> успешно; значение <see langword="false" />, если ключ уже существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.OverflowException">Словарь уже содержит максимальное количество элементов (<see cref="F:System.Int32.MaxValue" />).</exception>
		// Token: 0x06005EFD RID: 24317 RVA: 0x0013F338 File Offset: 0x0013D538
		public bool TryAdd(TKey key, TValue value)
		{
			if (key == null)
			{
				ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
			}
			TValue tvalue;
			return this.TryAddInternal(key, this._comparer.GetHashCode(key), value, false, true, out tvalue);
		}

		/// <summary>Определяет, содержится ли указанный ключ в словаре <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</summary>
		/// <param name="key">Ключ, который требуется найти в <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</param>
		/// <returns>
		///   <see langword="true" />, если <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" /> содержит элемент с указанным ключом, в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		// Token: 0x06005EFE RID: 24318 RVA: 0x0013F36C File Offset: 0x0013D56C
		public bool ContainsKey(TKey key)
		{
			if (key == null)
			{
				ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
			}
			TValue tvalue;
			return this.TryGetValue(key, out tvalue);
		}

		/// <summary>Пытается удалить и вернуть значение с указанным ключом из коллекции <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</summary>
		/// <param name="key">Ключ удаляемого и возвращаемого элемента.</param>
		/// <param name="value">Параметр, возвращаемый данным методом, содержит объект, удаленный из коллекции <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" /> или значение по умолчанию типа <see langword="TValue" />, если <paramref name="key" /> не существует.</param>
		/// <returns>Значение <see langword="true" />, если объект успешно удален; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005EFF RID: 24319 RVA: 0x0013F390 File Offset: 0x0013D590
		public bool TryRemove(TKey key, out TValue value)
		{
			if (key == null)
			{
				ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
			}
			return this.TryRemoveInternal(key, out value, false, default(TValue));
		}

		// Token: 0x06005F00 RID: 24320 RVA: 0x0013F3BC File Offset: 0x0013D5BC
		private bool TryRemoveInternal(TKey key, out TValue value, bool matchValue, TValue oldValue)
		{
			int hashCode = this._comparer.GetHashCode(key);
			for (;;)
			{
				ConcurrentDictionary<TKey, TValue>.Tables tables = this._tables;
				int num;
				int num2;
				ConcurrentDictionary<TKey, TValue>.GetBucketAndLockNo(hashCode, out num, out num2, tables._buckets.Length, tables._locks.Length);
				object obj = tables._locks[num2];
				lock (obj)
				{
					if (tables != this._tables)
					{
						continue;
					}
					ConcurrentDictionary<TKey, TValue>.Node node = null;
					ConcurrentDictionary<TKey, TValue>.Node node2 = tables._buckets[num];
					while (node2 != null)
					{
						if (hashCode == node2._hashcode && this._comparer.Equals(node2._key, key))
						{
							if (matchValue && !EqualityComparer<TValue>.Default.Equals(oldValue, node2._value))
							{
								value = default(TValue);
								return false;
							}
							if (node == null)
							{
								Volatile.Write<ConcurrentDictionary<TKey, TValue>.Node>(ref tables._buckets[num], node2._next);
							}
							else
							{
								node._next = node2._next;
							}
							value = node2._value;
							tables._countPerLock[num2]--;
							return true;
						}
						else
						{
							node = node2;
							node2 = node2._next;
						}
					}
				}
				break;
			}
			value = default(TValue);
			return false;
		}

		/// <summary>Пытается получить значение, связанное с указанным ключом, из коллекции <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</summary>
		/// <param name="key">Ключ значения, которое необходимо получить.</param>
		/// <param name="value">Параметр, возвращаемый этим методом, содержит объект из коллекции <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" /> с заданным ключом или значение по умолчанию, если операцию не удалось выполнить.</param>
		/// <returns>Значение <see langword="true" />, если ключ был найден в коллекции <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005F01 RID: 24321 RVA: 0x0013F510 File Offset: 0x0013D710
		public bool TryGetValue(TKey key, out TValue value)
		{
			if (key == null)
			{
				ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
			}
			return this.TryGetValueInternal(key, this._comparer.GetHashCode(key), out value);
		}

		// Token: 0x06005F02 RID: 24322 RVA: 0x0013F534 File Offset: 0x0013D734
		private bool TryGetValueInternal(TKey key, int hashcode, out TValue value)
		{
			ConcurrentDictionary<TKey, TValue>.Tables tables = this._tables;
			int bucket = ConcurrentDictionary<TKey, TValue>.GetBucket(hashcode, tables._buckets.Length);
			for (ConcurrentDictionary<TKey, TValue>.Node node = Volatile.Read<ConcurrentDictionary<TKey, TValue>.Node>(ref tables._buckets[bucket]); node != null; node = node._next)
			{
				if (hashcode == node._hashcode && this._comparer.Equals(node._key, key))
				{
					value = node._value;
					return true;
				}
			}
			value = default(TValue);
			return false;
		}

		/// <summary>Обновляет значение, связанное с <paramref name="key" /> до <paramref name="newValue" />, если существующее значение <paramref name="key" /> равно <paramref name="comparisonValue" />.</summary>
		/// <param name="key">Ключ, значение которого сравнивается со значением параметра <paramref name="comparisonValue" /> и, возможно, заменяется.</param>
		/// <param name="newValue">Значение, которым заменяется значение элемента, который задал ключ <paramref name="key" /> в случае положительного результата сравнения на равенство.</param>
		/// <param name="comparisonValue">Значение, которое сравнивается со значением элемента с указанным <paramref name="key" />.</param>
		/// <returns>Значение <see langword="true" />, если значение с ключом <paramref name="key" /> оказалось равным значению параметра <paramref name="comparisonValue" /> и было заменено значением <paramref name="newValue" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		// Token: 0x06005F03 RID: 24323 RVA: 0x0013F5AC File Offset: 0x0013D7AC
		public bool TryUpdate(TKey key, TValue newValue, TValue comparisonValue)
		{
			if (key == null)
			{
				ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
			}
			return this.TryUpdateInternal(key, this._comparer.GetHashCode(key), newValue, comparisonValue);
		}

		// Token: 0x06005F04 RID: 24324 RVA: 0x0013F5D0 File Offset: 0x0013D7D0
		private bool TryUpdateInternal(TKey key, int hashcode, TValue newValue, TValue comparisonValue)
		{
			IEqualityComparer<TValue> @default = EqualityComparer<TValue>.Default;
			bool result;
			for (;;)
			{
				ConcurrentDictionary<TKey, TValue>.Tables tables = this._tables;
				int num;
				int num2;
				ConcurrentDictionary<TKey, TValue>.GetBucketAndLockNo(hashcode, out num, out num2, tables._buckets.Length, tables._locks.Length);
				object obj = tables._locks[num2];
				lock (obj)
				{
					if (tables != this._tables)
					{
						continue;
					}
					ConcurrentDictionary<TKey, TValue>.Node node = null;
					ConcurrentDictionary<TKey, TValue>.Node node2 = tables._buckets[num];
					while (node2 != null)
					{
						if (hashcode == node2._hashcode && this._comparer.Equals(node2._key, key))
						{
							if (@default.Equals(node2._value, comparisonValue))
							{
								if (ConcurrentDictionary<TKey, TValue>.s_isValueWriteAtomic)
								{
									node2._value = newValue;
								}
								else
								{
									ConcurrentDictionary<TKey, TValue>.Node node3 = new ConcurrentDictionary<TKey, TValue>.Node(node2._key, newValue, hashcode, node2._next);
									if (node == null)
									{
										Volatile.Write<ConcurrentDictionary<TKey, TValue>.Node>(ref tables._buckets[num], node3);
									}
									else
									{
										node._next = node3;
									}
								}
								return true;
							}
							return false;
						}
						else
						{
							node = node2;
							node2 = node2._next;
						}
					}
					result = false;
				}
				break;
			}
			return result;
		}

		/// <summary>Удаляет все ключи и значения из словаря <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</summary>
		// Token: 0x06005F05 RID: 24325 RVA: 0x0013F6FC File Offset: 0x0013D8FC
		public void Clear()
		{
			int toExclusive = 0;
			try
			{
				this.AcquireAllLocks(ref toExclusive);
				ConcurrentDictionary<TKey, TValue>.Tables tables = new ConcurrentDictionary<TKey, TValue>.Tables(new ConcurrentDictionary<TKey, TValue>.Node[31], this._tables._locks, new int[this._tables._countPerLock.Length]);
				this._tables = tables;
				this._budget = Math.Max(1, tables._buckets.Length / tables._locks.Length);
			}
			finally
			{
				this.ReleaseLocks(0, toExclusive);
			}
		}

		// Token: 0x06005F06 RID: 24326 RVA: 0x0013F784 File Offset: 0x0013D984
		void ICollection<KeyValuePair<!0, !1>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "The index argument is less than zero.");
			}
			int toExclusive = 0;
			try
			{
				this.AcquireAllLocks(ref toExclusive);
				int num = 0;
				int num2 = 0;
				while (num2 < this._tables._locks.Length && num >= 0)
				{
					num += this._tables._countPerLock[num2];
					num2++;
				}
				if (array.Length - num < index || num < 0)
				{
					throw new ArgumentException("The index is equal to or greater than the length of the array, or the number of elements in the dictionary is greater than the available space from index to the end of the destination array.");
				}
				this.CopyToPairs(array, index);
			}
			finally
			{
				this.ReleaseLocks(0, toExclusive);
			}
		}

		/// <summary>Копирует пары "ключ-значение", хранящиеся в коллекции <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />, в новый массив.</summary>
		/// <returns>Новый массив, содержащий снимок пар "ключ-значение", скопированных из коллекции <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</returns>
		// Token: 0x06005F07 RID: 24327 RVA: 0x0013F82C File Offset: 0x0013DA2C
		public KeyValuePair<TKey, TValue>[] ToArray()
		{
			int toExclusive = 0;
			checked
			{
				KeyValuePair<TKey, TValue>[] result;
				try
				{
					this.AcquireAllLocks(ref toExclusive);
					int num = 0;
					for (int i = 0; i < this._tables._locks.Length; i++)
					{
						num += this._tables._countPerLock[i];
					}
					if (num == 0)
					{
						result = Array.Empty<KeyValuePair<TKey, TValue>>();
					}
					else
					{
						KeyValuePair<TKey, TValue>[] array = new KeyValuePair<TKey, TValue>[num];
						this.CopyToPairs(array, 0);
						result = array;
					}
				}
				finally
				{
					this.ReleaseLocks(0, toExclusive);
				}
				return result;
			}
		}

		// Token: 0x06005F08 RID: 24328 RVA: 0x0013F8B0 File Offset: 0x0013DAB0
		private void CopyToPairs(KeyValuePair<TKey, TValue>[] array, int index)
		{
			foreach (ConcurrentDictionary<TKey, TValue>.Node node in this._tables._buckets)
			{
				while (node != null)
				{
					array[index] = new KeyValuePair<TKey, TValue>(node._key, node._value);
					index++;
					node = node._next;
				}
			}
		}

		// Token: 0x06005F09 RID: 24329 RVA: 0x0013F908 File Offset: 0x0013DB08
		private void CopyToEntries(DictionaryEntry[] array, int index)
		{
			foreach (ConcurrentDictionary<TKey, TValue>.Node node in this._tables._buckets)
			{
				while (node != null)
				{
					array[index] = new DictionaryEntry(node._key, node._value);
					index++;
					node = node._next;
				}
			}
		}

		// Token: 0x06005F0A RID: 24330 RVA: 0x0013F96C File Offset: 0x0013DB6C
		private void CopyToObjects(object[] array, int index)
		{
			foreach (ConcurrentDictionary<TKey, TValue>.Node node in this._tables._buckets)
			{
				while (node != null)
				{
					array[index] = new KeyValuePair<TKey, TValue>(node._key, node._value);
					index++;
					node = node._next;
				}
			}
		}

		/// <summary>Возвращает перечислитель, осуществляющий перебор элементов списка <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</summary>
		/// <returns>Перечислитель для коллекции <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</returns>
		// Token: 0x06005F0B RID: 24331 RVA: 0x0013F9C5 File Offset: 0x0013DBC5
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			ConcurrentDictionary<TKey, TValue>.Node[] buckets = this._tables._buckets;
			int num;
			for (int i = 0; i < buckets.Length; i = num + 1)
			{
				ConcurrentDictionary<TKey, TValue>.Node current;
				for (current = Volatile.Read<ConcurrentDictionary<TKey, TValue>.Node>(ref buckets[i]); current != null; current = current._next)
				{
					yield return new KeyValuePair<TKey, TValue>(current._key, current._value);
				}
				current = null;
				num = i;
			}
			yield break;
		}

		// Token: 0x06005F0C RID: 24332 RVA: 0x0013F9D4 File Offset: 0x0013DBD4
		private bool TryAddInternal(TKey key, int hashcode, TValue value, bool updateIfExists, bool acquireLock, out TValue resultingValue)
		{
			checked
			{
				ConcurrentDictionary<TKey, TValue>.Tables tables;
				bool flag;
				for (;;)
				{
					tables = this._tables;
					int num;
					int num2;
					ConcurrentDictionary<TKey, TValue>.GetBucketAndLockNo(hashcode, out num, out num2, tables._buckets.Length, tables._locks.Length);
					flag = false;
					bool flag2 = false;
					try
					{
						if (acquireLock)
						{
							Monitor.Enter(tables._locks[num2], ref flag2);
						}
						if (tables != this._tables)
						{
							continue;
						}
						ConcurrentDictionary<TKey, TValue>.Node node = null;
						for (ConcurrentDictionary<TKey, TValue>.Node node2 = tables._buckets[num]; node2 != null; node2 = node2._next)
						{
							if (hashcode == node2._hashcode && this._comparer.Equals(node2._key, key))
							{
								if (updateIfExists)
								{
									if (ConcurrentDictionary<TKey, TValue>.s_isValueWriteAtomic)
									{
										node2._value = value;
									}
									else
									{
										ConcurrentDictionary<TKey, TValue>.Node node3 = new ConcurrentDictionary<TKey, TValue>.Node(node2._key, value, hashcode, node2._next);
										if (node == null)
										{
											Volatile.Write<ConcurrentDictionary<TKey, TValue>.Node>(ref tables._buckets[num], node3);
										}
										else
										{
											node._next = node3;
										}
									}
									resultingValue = value;
								}
								else
								{
									resultingValue = node2._value;
								}
								return false;
							}
							node = node2;
						}
						Volatile.Write<ConcurrentDictionary<TKey, TValue>.Node>(ref tables._buckets[num], new ConcurrentDictionary<TKey, TValue>.Node(key, value, hashcode, tables._buckets[num]));
						tables._countPerLock[num2]++;
						if (tables._countPerLock[num2] > this._budget)
						{
							flag = true;
						}
					}
					finally
					{
						if (flag2)
						{
							Monitor.Exit(tables._locks[num2]);
						}
					}
					break;
				}
				if (flag)
				{
					this.GrowTable(tables);
				}
				resultingValue = value;
				return true;
			}
		}

		/// <summary>Возвращает или задает значение, связанное с указанным ключом.</summary>
		/// <param name="key">Ключ, значение которого требуется получить или задать.</param>
		/// <returns>Значение пары "ключ-значение" по указанному индексу.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Collections.Generic.KeyNotFoundException">Свойство получено, а <paramref name="key" /> не существует в коллекции.</exception>
		// Token: 0x170010A8 RID: 4264
		public TValue this[TKey key]
		{
			get
			{
				TValue result;
				if (!this.TryGetValue(key, out result))
				{
					ConcurrentDictionary<TKey, TValue>.ThrowKeyNotFoundException(key);
				}
				return result;
			}
			set
			{
				if (key == null)
				{
					ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
				}
				TValue tvalue;
				this.TryAddInternal(key, this._comparer.GetHashCode(key), value, true, true, out tvalue);
			}
		}

		// Token: 0x06005F0F RID: 24335 RVA: 0x0004DFA6 File Offset: 0x0004C1A6
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowKeyNotFoundException(object key)
		{
			throw new KeyNotFoundException(SR.Format("The given key '{0}' was not present in the dictionary.", key.ToString()));
		}

		// Token: 0x06005F10 RID: 24336 RVA: 0x0013FBCB File Offset: 0x0013DDCB
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowKeyNullException()
		{
			throw new ArgumentNullException("key");
		}

		/// <summary>Возвращает число пар "ключ-значение", содержащихся в словаре <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</summary>
		/// <returns>Число пар "ключ-значение", содержащихся в словаре <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</returns>
		/// <exception cref="T:System.OverflowException">Словарь уже содержит максимальное количество элементов (<see cref="F:System.Int32.MaxValue" />).</exception>
		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x06005F11 RID: 24337 RVA: 0x0013FBD8 File Offset: 0x0013DDD8
		public int Count
		{
			get
			{
				int toExclusive = 0;
				int countInternal;
				try
				{
					this.AcquireAllLocks(ref toExclusive);
					countInternal = this.GetCountInternal();
				}
				finally
				{
					this.ReleaseLocks(0, toExclusive);
				}
				return countInternal;
			}
		}

		// Token: 0x06005F12 RID: 24338 RVA: 0x0013FC14 File Offset: 0x0013DE14
		private int GetCountInternal()
		{
			int num = 0;
			for (int i = 0; i < this._tables._countPerLock.Length; i++)
			{
				num += this._tables._countPerLock[i];
			}
			return num;
		}

		/// <summary>Добавляет пару "ключ-значение" в <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />, используя указанную функцию, если ключ еще не существует. Возвращает новое значение или существующее значение, если ключ существует.</summary>
		/// <param name="key">Ключ добавляемого элемента.</param>
		/// <param name="valueFactory">Функция, используемая для создания значения для ключа.</param>
		/// <returns>Значение для ключа. Этим значением будет существующее значение ключа, если ключ уже имеется в словаре, или новое значение, если ключ не существовал в словаре.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="key" /> или <paramref name="valueFactory" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.OverflowException">Словарь уже содержит максимальное количество элементов (<see cref="F:System.Int32.MaxValue" />).</exception>
		// Token: 0x06005F13 RID: 24339 RVA: 0x0013FC54 File Offset: 0x0013DE54
		public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory)
		{
			if (key == null)
			{
				ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
			}
			if (valueFactory == null)
			{
				throw new ArgumentNullException("valueFactory");
			}
			int hashCode = this._comparer.GetHashCode(key);
			TValue result;
			if (!this.TryGetValueInternal(key, hashCode, out result))
			{
				this.TryAddInternal(key, hashCode, valueFactory(key), false, true, out result);
			}
			return result;
		}

		/// <summary>Добавляет пару "ключ-значение" в коллекцию <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />, используя указанную функцию и аргумент, если этот ключ еще не существует, или возвращает существующее значение при наличии ключа.</summary>
		/// <param name="key">Ключ добавляемого элемента.</param>
		/// <param name="valueFactory">Функция, используемая для создания значения для ключа.</param>
		/// <param name="factoryArgument">Значение аргумента, передаваемое в <paramref name="valueFactory" />.</param>
		/// <typeparam name="TArg">Тип аргумента для передачи в <paramref name="valueFactory" />.</typeparam>
		/// <returns>Значение для ключа. Этим значением будет существующее значение ключа, если ключ уже имеется в словаре, или новое значение, если ключ не существовал в словаре.</returns>
		// Token: 0x06005F14 RID: 24340 RVA: 0x0013FCAC File Offset: 0x0013DEAC
		public TValue GetOrAdd<TArg>(TKey key, Func<TKey, TArg, TValue> valueFactory, TArg factoryArgument)
		{
			if (key == null)
			{
				ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
			}
			if (valueFactory == null)
			{
				throw new ArgumentNullException("valueFactory");
			}
			int hashCode = this._comparer.GetHashCode(key);
			TValue result;
			if (!this.TryGetValueInternal(key, hashCode, out result))
			{
				this.TryAddInternal(key, hashCode, valueFactory(key, factoryArgument), false, true, out result);
			}
			return result;
		}

		/// <summary>Добавляет пару "ключ-значение" в коллекцию <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />, если ключ еще не существует. Возвращает новое значение или существующее значение, если ключ существует.</summary>
		/// <param name="key">Ключ добавляемого элемента.</param>
		/// <param name="value">Значение, которое необходимо добавить, если ключ еще не существует.</param>
		/// <returns>Значение для ключа. Этим значением будет существующее значение ключа, если ключ уже имеется в словаре, или новое значение, если ключ не существовал в словаре.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.OverflowException">Словарь уже содержит максимальное количество элементов (<see cref="F:System.Int32.MaxValue" />).</exception>
		// Token: 0x06005F15 RID: 24341 RVA: 0x0013FD04 File Offset: 0x0013DF04
		public TValue GetOrAdd(TKey key, TValue value)
		{
			if (key == null)
			{
				ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
			}
			int hashCode = this._comparer.GetHashCode(key);
			TValue result;
			if (!this.TryGetValueInternal(key, hashCode, out result))
			{
				this.TryAddInternal(key, hashCode, value, false, true, out result);
			}
			return result;
		}

		/// <summary>Использует указанные функции и аргумент, чтобы добавлять пару "ключ-значение" в коллекцию <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />, если этот ключ еще не существует, или чтобы обновить пару "ключ-значение" в коллекции <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />, если ключ существует.</summary>
		/// <param name="key">Ключ, который добавляется или значение которого обновляется.</param>
		/// <param name="addValueFactory">Функция, используемая для создания значения для несуществующего ключа.</param>
		/// <param name="updateValueFactory">Функция, используемая для создания нового значения для существующего ключа на основе его текущего значения.</param>
		/// <param name="factoryArgument">Аргумент, передаваемый в <paramref name="addValueFactory" /> и <paramref name="updateValueFactory" />.</param>
		/// <typeparam name="TArg">Тип аргумента для передачи в <paramref name="addValueFactory" /> и <paramref name="updateValueFactory" />.</typeparam>
		/// <returns>Новое значение для ключа. Это значение будет либо значением функции <paramref name="addValueFactory" /> (если ключ отсутствовал), либо результатом выполнения функции <paramref name="updateValueFactory" /> (если ключ присутствовал).</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" />, <paramref name="addValueFactory" /> или <paramref name="updateValueFactory" /> является ссылкой на NULL (Nothing в Visual Basic).</exception>
		// Token: 0x06005F16 RID: 24342 RVA: 0x0013FD48 File Offset: 0x0013DF48
		public TValue AddOrUpdate<TArg>(TKey key, Func<TKey, TArg, TValue> addValueFactory, Func<TKey, TValue, TArg, TValue> updateValueFactory, TArg factoryArgument)
		{
			if (key == null)
			{
				ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
			}
			if (addValueFactory == null)
			{
				throw new ArgumentNullException("addValueFactory");
			}
			if (updateValueFactory == null)
			{
				throw new ArgumentNullException("updateValueFactory");
			}
			int hashCode = this._comparer.GetHashCode(key);
			TValue tvalue2;
			for (;;)
			{
				TValue tvalue;
				TValue result;
				if (this.TryGetValueInternal(key, hashCode, out tvalue))
				{
					tvalue2 = updateValueFactory(key, tvalue, factoryArgument);
					if (this.TryUpdateInternal(key, hashCode, tvalue2, tvalue))
					{
						break;
					}
				}
				else if (this.TryAddInternal(key, hashCode, addValueFactory(key, factoryArgument), false, true, out result))
				{
					return result;
				}
			}
			return tvalue2;
		}

		/// <summary>Использует заданные функции, чтобы добавить пару "ключ-значение" в коллекцию <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />, если данный ключ еще не существует, или чтобы обновить пару "ключ-значение" в коллекции <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" /> в случае наличия ключа.</summary>
		/// <param name="key">Ключ, который добавляется или значение которого обновляется</param>
		/// <param name="addValueFactory">Функция, используемая для создания значения для несуществующего ключа</param>
		/// <param name="updateValueFactory">Функция, используемая для создания нового значения для существующего ключа на основе его текущего значения</param>
		/// <returns>Новое значение для ключа. Это значение будет либо значением функции <paramref name="addValueFactory" /> (если ключ отсутствовал), либо результатом выполнения функции <paramref name="updateValueFactory" /> (если ключ присутствовал).</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="key" />, <paramref name="addValueFactory" /> или <paramref name="updateValueFactory" /> равно <see langword="null" />.</exception>
		/// <exception cref="T:System.OverflowException">Словарь уже содержит максимальное количество элементов (<see cref="F:System.Int32.MaxValue" />).</exception>
		// Token: 0x06005F17 RID: 24343 RVA: 0x0013FDC8 File Offset: 0x0013DFC8
		public TValue AddOrUpdate(TKey key, Func<TKey, TValue> addValueFactory, Func<TKey, TValue, TValue> updateValueFactory)
		{
			if (key == null)
			{
				ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
			}
			if (addValueFactory == null)
			{
				throw new ArgumentNullException("addValueFactory");
			}
			if (updateValueFactory == null)
			{
				throw new ArgumentNullException("updateValueFactory");
			}
			int hashCode = this._comparer.GetHashCode(key);
			TValue tvalue2;
			for (;;)
			{
				TValue tvalue;
				TValue result;
				if (this.TryGetValueInternal(key, hashCode, out tvalue))
				{
					tvalue2 = updateValueFactory(key, tvalue);
					if (this.TryUpdateInternal(key, hashCode, tvalue2, tvalue))
					{
						break;
					}
				}
				else if (this.TryAddInternal(key, hashCode, addValueFactory(key), false, true, out result))
				{
					return result;
				}
			}
			return tvalue2;
		}

		/// <summary>Добавляет пару "ключ-значение" в коллекцию <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />, если данный ключ еще не существует, или обновляет пару "ключ-значение" в коллекции <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />, используя указанную функцию, в случае наличия ключа.</summary>
		/// <param name="key">Ключ, который добавляется или значение которого обновляется</param>
		/// <param name="addValue">Значение, добавляемое для несуществующего ключа</param>
		/// <param name="updateValueFactory">Функция, используемая для создания нового значения для существующего ключа на основе его текущего значения</param>
		/// <returns>Новое значение для ключа. Это значение будет либо значением функции <paramref name="addValue" /> (если ключ отсутствовал), либо результатом выполнения функции <paramref name="updateValueFactory" /> (если ключ присутствовал).</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="key" /> или <paramref name="updateValueFactory" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.OverflowException">Словарь уже содержит максимальное количество элементов (<see cref="F:System.Int32.MaxValue" />).</exception>
		// Token: 0x06005F18 RID: 24344 RVA: 0x0013FE44 File Offset: 0x0013E044
		public TValue AddOrUpdate(TKey key, TValue addValue, Func<TKey, TValue, TValue> updateValueFactory)
		{
			if (key == null)
			{
				ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
			}
			if (updateValueFactory == null)
			{
				throw new ArgumentNullException("updateValueFactory");
			}
			int hashCode = this._comparer.GetHashCode(key);
			TValue tvalue2;
			for (;;)
			{
				TValue tvalue;
				TValue result;
				if (this.TryGetValueInternal(key, hashCode, out tvalue))
				{
					tvalue2 = updateValueFactory(key, tvalue);
					if (this.TryUpdateInternal(key, hashCode, tvalue2, tvalue))
					{
						break;
					}
				}
				else if (this.TryAddInternal(key, hashCode, addValue, false, true, out result))
				{
					return result;
				}
			}
			return tvalue2;
		}

		/// <summary>Возвращает значение, указывающее, является ли коллекция <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" /> пустой.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" /> пуст; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x06005F19 RID: 24345 RVA: 0x0013FEAC File Offset: 0x0013E0AC
		public bool IsEmpty
		{
			get
			{
				int toExclusive = 0;
				try
				{
					this.AcquireAllLocks(ref toExclusive);
					for (int i = 0; i < this._tables._countPerLock.Length; i++)
					{
						if (this._tables._countPerLock[i] != 0)
						{
							return false;
						}
					}
				}
				finally
				{
					this.ReleaseLocks(0, toExclusive);
				}
				return true;
			}
		}

		// Token: 0x06005F1A RID: 24346 RVA: 0x0013FF14 File Offset: 0x0013E114
		void IDictionary<!0, !1>.Add(TKey key, TValue value)
		{
			if (!this.TryAdd(key, value))
			{
				throw new ArgumentException("The key already existed in the dictionary.");
			}
		}

		// Token: 0x06005F1B RID: 24347 RVA: 0x0013FF2C File Offset: 0x0013E12C
		bool IDictionary<!0, !1>.Remove(TKey key)
		{
			TValue tvalue;
			return this.TryRemove(key, out tvalue);
		}

		/// <summary>Возвращает коллекцию, содержащую ключи из словаря <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary>
		/// <returns>Коллекция ключей в <see cref="T:System.Collections.Generic.Dictionary`2" />.</returns>
		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x06005F1C RID: 24348 RVA: 0x0013FF42 File Offset: 0x0013E142
		public ICollection<TKey> Keys
		{
			get
			{
				return this.GetKeys();
			}
		}

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x06005F1D RID: 24349 RVA: 0x0013FF42 File Offset: 0x0013E142
		IEnumerable<TKey> IReadOnlyDictionary<!0, !1>.Keys
		{
			get
			{
				return this.GetKeys();
			}
		}

		/// <summary>Возвращает коллекцию, содержащую значения <see cref="T:System.Collections.Generic.Dictionary`2" />.</summary>
		/// <returns>Коллекция, содержащая значения словаря <see cref="T:System.Collections.Generic.Dictionary`2" />.</returns>
		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x06005F1E RID: 24350 RVA: 0x0013FF4A File Offset: 0x0013E14A
		public ICollection<TValue> Values
		{
			get
			{
				return this.GetValues();
			}
		}

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x06005F1F RID: 24351 RVA: 0x0013FF4A File Offset: 0x0013E14A
		IEnumerable<TValue> IReadOnlyDictionary<!0, !1>.Values
		{
			get
			{
				return this.GetValues();
			}
		}

		// Token: 0x06005F20 RID: 24352 RVA: 0x0013FF52 File Offset: 0x0013E152
		void ICollection<KeyValuePair<!0, !1>>.Add(KeyValuePair<TKey, TValue> keyValuePair)
		{
			((IDictionary<TKey, TValue>)this).Add(keyValuePair.Key, keyValuePair.Value);
		}

		// Token: 0x06005F21 RID: 24353 RVA: 0x0013FF68 File Offset: 0x0013E168
		bool ICollection<KeyValuePair<!0, !1>>.Contains(KeyValuePair<TKey, TValue> keyValuePair)
		{
			TValue x;
			return this.TryGetValue(keyValuePair.Key, out x) && EqualityComparer<TValue>.Default.Equals(x, keyValuePair.Value);
		}

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x06005F22 RID: 24354 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		bool ICollection<KeyValuePair<!0, !1>>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06005F23 RID: 24355 RVA: 0x0013FF9C File Offset: 0x0013E19C
		bool ICollection<KeyValuePair<!0, !1>>.Remove(KeyValuePair<TKey, TValue> keyValuePair)
		{
			if (keyValuePair.Key == null)
			{
				throw new ArgumentNullException("keyValuePair", "TKey is a reference type and item.Key is null.");
			}
			TValue tvalue;
			return this.TryRemoveInternal(keyValuePair.Key, out tvalue, true, keyValuePair.Value);
		}

		/// <summary>Возвращает перечислитель, осуществляющий перебор элементов списка <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</summary>
		/// <returns>Перечислитель для коллекции <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</returns>
		// Token: 0x06005F24 RID: 24356 RVA: 0x0013FFDE File Offset: 0x0013E1DE
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>Добавляет указанные ключ и значение в словарь.</summary>
		/// <param name="key">Объект, который используется в качестве ключа.</param>
		/// <param name="value">Объект, который используется в качестве значения.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="key" /> имеет тип, который не может быть назначен типу ключа объекта <see cref="T:System.Collections.Generic.Dictionary`2" />.  
		/// -или- 
		///  Параметр <paramref name="value" /> имеет тип, который не может быть назначен типу значений в словаре <see cref="T:System.Collections.Generic.Dictionary`2" />.  
		/// -или- 
		/// Значение с таким ключом уже существует в <see cref="T:System.Collections.Generic.Dictionary`2" />.</exception>
		/// <exception cref="T:System.OverflowException">Словарь уже содержит максимальное количество элементов (<see cref="F:System.Int32.MaxValue" />).</exception>
		// Token: 0x06005F25 RID: 24357 RVA: 0x0013FFE8 File Offset: 0x0013E1E8
		void IDictionary.Add(object key, object value)
		{
			if (key == null)
			{
				ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
			}
			if (!(key is TKey))
			{
				throw new ArgumentException("The key was of an incorrect type for this dictionary.");
			}
			TValue value2;
			try
			{
				value2 = (TValue)((object)value);
			}
			catch (InvalidCastException)
			{
				throw new ArgumentException("The value was of an incorrect type for this dictionary.");
			}
			((IDictionary<TKey, TValue>)this).Add((TKey)((object)key), value2);
		}

		/// <summary>Получает значение, указывающее, содержит ли <see cref="T:System.Collections.Generic.IDictionary`2" /> элемент с выбранным ключом.</summary>
		/// <param name="key">Ключ, который требуется найти в <see cref="T:System.Collections.Generic.IDictionary`2" />.</param>
		/// <returns>
		///   <see langword="true" />, если <see cref="T:System.Collections.Generic.IDictionary`2" /> содержит элемент с указанным ключом, в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		// Token: 0x06005F26 RID: 24358 RVA: 0x00140044 File Offset: 0x0013E244
		bool IDictionary.Contains(object key)
		{
			if (key == null)
			{
				ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
			}
			return key is TKey && this.ContainsKey((TKey)((object)key));
		}

		/// <summary>Предоставляет объект <see cref="T:System.Collections.IDictionaryEnumerator" /> для коллекции <see cref="T:System.Collections.Generic.IDictionary`2" />.</summary>
		/// <returns>Новый объект <see cref="T:System.Collections.IDictionaryEnumerator" /> для <see cref="T:System.Collections.Generic.IDictionary`2" />.</returns>
		// Token: 0x06005F27 RID: 24359 RVA: 0x00140064 File Offset: 0x0013E264
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return new ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator(this);
		}

		/// <summary>Возвращает значение, показывающее, имеет ли объект <see cref="T:System.Collections.Generic.IDictionary`2" /> фиксированный размер.</summary>
		/// <returns>Значение <see langword="true" />, если словарь <see cref="T:System.Collections.Generic.IDictionary`2" /> имеет фиксированный размер; в противном случае — значение <see langword="false" />. Для <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" /> это свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x06005F28 RID: 24360 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		bool IDictionary.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает значение, которое определяет, является ли коллекция <see cref="T:System.Collections.Generic.IDictionary`2" /> доступной только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если интерфейс <see cref="T:System.Collections.Generic.IDictionary`2" /> доступен только для чтения; в противном случае — значение <see langword="false" />. Для <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" /> это свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x06005F29 RID: 24361 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		bool IDictionary.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает коллекцию <see cref="T:System.Collections.ICollection" />, содержащую ключи из объекта <see cref="T:System.Collections.Generic.IDictionary`2" />.</summary>
		/// <returns>Интерфейс, содержащий ключи <see cref="T:System.Collections.Generic.IDictionary`2" />.</returns>
		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x06005F2A RID: 24362 RVA: 0x0013FF42 File Offset: 0x0013E142
		ICollection IDictionary.Keys
		{
			get
			{
				return this.GetKeys();
			}
		}

		/// <summary>Удаляет элемент с указанным ключом из <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <param name="key">Ключ элемента, который требуется удалить.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		// Token: 0x06005F2B RID: 24363 RVA: 0x0014006C File Offset: 0x0013E26C
		void IDictionary.Remove(object key)
		{
			if (key == null)
			{
				ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
			}
			if (key is TKey)
			{
				TValue tvalue;
				this.TryRemove((TKey)((object)key), out tvalue);
			}
		}

		/// <summary>Возвращает коллекцию <see cref="T:System.Collections.ICollection" />, которая содержит значения в <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <returns>Интерфейс, который содержит значения в объекте <see cref="T:System.Collections.IDictionary" />.</returns>
		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x06005F2C RID: 24364 RVA: 0x0013FF4A File Offset: 0x0013E14A
		ICollection IDictionary.Values
		{
			get
			{
				return this.GetValues();
			}
		}

		/// <summary>Возвращает или задает значение, связанное с указанным ключом.</summary>
		/// <param name="key">Ключ, значение которого требуется получить или задать.</param>
		/// <returns>Значение, связанное с указанным ключом, или <see langword="null" />, если <paramref name="key" /> отсутствует в словаре или тип параметра <paramref name="key" /> не допускает присваивание типу ключа коллекции <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значение присваивается. <paramref name="key" /> имеет тип, который не может быть назначен типу ключа или типу значения <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" />.</exception>
		// Token: 0x170010B4 RID: 4276
		object IDictionary.this[object key]
		{
			get
			{
				if (key == null)
				{
					ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
				}
				TValue tvalue;
				if (key is TKey && this.TryGetValue((TKey)((object)key), out tvalue))
				{
					return tvalue;
				}
				return null;
			}
			set
			{
				if (key == null)
				{
					ConcurrentDictionary<TKey, TValue>.ThrowKeyNullException();
				}
				if (!(key is TKey))
				{
					throw new ArgumentException("The key was of an incorrect type for this dictionary.");
				}
				if (!(value is TValue))
				{
					throw new ArgumentException("The value was of an incorrect type for this dictionary.");
				}
				this[(TKey)((object)key)] = (TValue)((object)value);
			}
		}

		/// <summary>Копирует элементы коллекции <see cref="T:System.Collections.ICollection" /> в массив, начиная с указанного индекса массива.</summary>
		/// <param name="array">Одномерный массив, в который копируются элементы из коллекции <see cref="T:System.Collections.ICollection" />. Индекс в массиве должен начинаться с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.</exception>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="index" /> больше или равно длине массива <paramref name="array" />.  
		/// -или- 
		/// Число элементов в исходной коллекции <see cref="T:System.Collections.ICollection" /> больше доступного места от положения, заданного значением параметра <paramref name="index" />, до конца массива назначения <paramref name="array" />.</exception>
		// Token: 0x06005F2F RID: 24367 RVA: 0x00140120 File Offset: 0x0013E320
		void ICollection.CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "The index argument is less than zero.");
			}
			int toExclusive = 0;
			try
			{
				this.AcquireAllLocks(ref toExclusive);
				ConcurrentDictionary<TKey, TValue>.Tables tables = this._tables;
				int num = 0;
				int num2 = 0;
				while (num2 < tables._locks.Length && num >= 0)
				{
					num += tables._countPerLock[num2];
					num2++;
				}
				if (array.Length - num < index || num < 0)
				{
					throw new ArgumentException("The index is equal to or greater than the length of the array, or the number of elements in the dictionary is greater than the available space from index to the end of the destination array.");
				}
				KeyValuePair<TKey, TValue>[] array2 = array as KeyValuePair<TKey, TValue>[];
				if (array2 != null)
				{
					this.CopyToPairs(array2, index);
				}
				else
				{
					DictionaryEntry[] array3 = array as DictionaryEntry[];
					if (array3 != null)
					{
						this.CopyToEntries(array3, index);
					}
					else
					{
						object[] array4 = array as object[];
						if (array4 == null)
						{
							throw new ArgumentException("The array is multidimensional, or the type parameter for the set cannot be cast automatically to the type of the destination array.", "array");
						}
						this.CopyToObjects(array4, index);
					}
				}
			}
			finally
			{
				this.ReleaseLocks(0, toExclusive);
			}
		}

		/// <summary>Получает значение, указывающее, синхронизирован ли доступ к <see cref="T:System.Collections.ICollection" /> с SyncRoot.</summary>
		/// <returns>
		///   <see langword="true" />, если доступ к классу <see cref="T:System.Collections.ICollection" /> является синхронизированным (потокобезопасным); в противном случае — <see langword="false" />. Для <see cref="T:System.Collections.Concurrent.ConcurrentDictionary`2" /> это свойство всегда возвращает <see langword="false" />.</returns>
		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x06005F30 RID: 24368 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.ICollection" />. Данное свойство не поддерживается.</summary>
		/// <returns>Всегда возвращает значение NULL.</returns>
		/// <exception cref="T:System.NotSupportedException">Данное свойство не поддерживается.</exception>
		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x06005F31 RID: 24369 RVA: 0x0013E2B7 File Offset: 0x0013C4B7
		object ICollection.SyncRoot
		{
			get
			{
				throw new NotSupportedException("The SyncRoot property may not be used for the synchronization of concurrent collections.");
			}
		}

		// Token: 0x06005F32 RID: 24370 RVA: 0x00140214 File Offset: 0x0013E414
		private void GrowTable(ConcurrentDictionary<TKey, TValue>.Tables tables)
		{
			int toExclusive = 0;
			try
			{
				this.AcquireLocks(0, 1, ref toExclusive);
				if (tables == this._tables)
				{
					long num = 0L;
					for (int i = 0; i < tables._countPerLock.Length; i++)
					{
						num += (long)tables._countPerLock[i];
					}
					if (num < (long)(tables._buckets.Length / 4))
					{
						this._budget = 2 * this._budget;
						if (this._budget < 0)
						{
							this._budget = int.MaxValue;
						}
					}
					else
					{
						int num2 = 0;
						bool flag = false;
						object[] array;
						checked
						{
							try
							{
								num2 = tables._buckets.Length * 2 + 1;
								while (num2 % 3 == 0 || num2 % 5 == 0 || num2 % 7 == 0)
								{
									num2 += 2;
								}
								if (num2 > 2146435071)
								{
									flag = true;
								}
							}
							catch (OverflowException)
							{
								flag = true;
							}
							if (flag)
							{
								num2 = 2146435071;
								this._budget = int.MaxValue;
							}
							this.AcquireLocks(1, tables._locks.Length, ref toExclusive);
							array = tables._locks;
						}
						if (this._growLockArray && tables._locks.Length < 1024)
						{
							array = new object[tables._locks.Length * 2];
							Array.Copy(tables._locks, 0, array, 0, tables._locks.Length);
							for (int j = tables._locks.Length; j < array.Length; j++)
							{
								array[j] = new object();
							}
						}
						ConcurrentDictionary<TKey, TValue>.Node[] array2 = new ConcurrentDictionary<TKey, TValue>.Node[num2];
						int[] array3 = new int[array.Length];
						for (int k = 0; k < tables._buckets.Length; k++)
						{
							checked
							{
								ConcurrentDictionary<TKey, TValue>.Node next;
								for (ConcurrentDictionary<TKey, TValue>.Node node = tables._buckets[k]; node != null; node = next)
								{
									next = node._next;
									int num3;
									int num4;
									ConcurrentDictionary<TKey, TValue>.GetBucketAndLockNo(node._hashcode, out num3, out num4, array2.Length, array.Length);
									array2[num3] = new ConcurrentDictionary<TKey, TValue>.Node(node._key, node._value, node._hashcode, array2[num3]);
									array3[num4]++;
								}
							}
						}
						this._budget = Math.Max(1, array2.Length / array.Length);
						this._tables = new ConcurrentDictionary<TKey, TValue>.Tables(array2, array, array3);
					}
				}
			}
			finally
			{
				this.ReleaseLocks(0, toExclusive);
			}
		}

		// Token: 0x06005F33 RID: 24371 RVA: 0x0014045C File Offset: 0x0013E65C
		private static int GetBucket(int hashcode, int bucketCount)
		{
			return (hashcode & int.MaxValue) % bucketCount;
		}

		// Token: 0x06005F34 RID: 24372 RVA: 0x00140467 File Offset: 0x0013E667
		private static void GetBucketAndLockNo(int hashcode, out int bucketNo, out int lockNo, int bucketCount, int lockCount)
		{
			bucketNo = (hashcode & int.MaxValue) % bucketCount;
			lockNo = bucketNo % lockCount;
		}

		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x06005F35 RID: 24373 RVA: 0x0014047B File Offset: 0x0013E67B
		private static int DefaultConcurrencyLevel
		{
			get
			{
				return PlatformHelper.ProcessorCount;
			}
		}

		// Token: 0x06005F36 RID: 24374 RVA: 0x00140484 File Offset: 0x0013E684
		private void AcquireAllLocks(ref int locksAcquired)
		{
			if (CDSCollectionETWBCLProvider.Log.IsEnabled())
			{
				CDSCollectionETWBCLProvider.Log.ConcurrentDictionary_AcquiringAllLocks(this._tables._buckets.Length);
			}
			this.AcquireLocks(0, 1, ref locksAcquired);
			this.AcquireLocks(1, this._tables._locks.Length, ref locksAcquired);
		}

		// Token: 0x06005F37 RID: 24375 RVA: 0x001404D8 File Offset: 0x0013E6D8
		private void AcquireLocks(int fromInclusive, int toExclusive, ref int locksAcquired)
		{
			object[] locks = this._tables._locks;
			for (int i = fromInclusive; i < toExclusive; i++)
			{
				bool flag = false;
				try
				{
					Monitor.Enter(locks[i], ref flag);
				}
				finally
				{
					if (flag)
					{
						locksAcquired++;
					}
				}
			}
		}

		// Token: 0x06005F38 RID: 24376 RVA: 0x00140528 File Offset: 0x0013E728
		private void ReleaseLocks(int fromInclusive, int toExclusive)
		{
			for (int i = fromInclusive; i < toExclusive; i++)
			{
				Monitor.Exit(this._tables._locks[i]);
			}
		}

		// Token: 0x06005F39 RID: 24377 RVA: 0x00140558 File Offset: 0x0013E758
		private ReadOnlyCollection<TKey> GetKeys()
		{
			int toExclusive = 0;
			ReadOnlyCollection<TKey> result;
			try
			{
				this.AcquireAllLocks(ref toExclusive);
				int countInternal = this.GetCountInternal();
				if (countInternal < 0)
				{
					throw new OutOfMemoryException();
				}
				List<TKey> list = new List<TKey>(countInternal);
				for (int i = 0; i < this._tables._buckets.Length; i++)
				{
					for (ConcurrentDictionary<TKey, TValue>.Node node = this._tables._buckets[i]; node != null; node = node._next)
					{
						list.Add(node._key);
					}
				}
				result = new ReadOnlyCollection<TKey>(list);
			}
			finally
			{
				this.ReleaseLocks(0, toExclusive);
			}
			return result;
		}

		// Token: 0x06005F3A RID: 24378 RVA: 0x001405F0 File Offset: 0x0013E7F0
		private ReadOnlyCollection<TValue> GetValues()
		{
			int toExclusive = 0;
			ReadOnlyCollection<TValue> result;
			try
			{
				this.AcquireAllLocks(ref toExclusive);
				int countInternal = this.GetCountInternal();
				if (countInternal < 0)
				{
					throw new OutOfMemoryException();
				}
				List<TValue> list = new List<TValue>(countInternal);
				for (int i = 0; i < this._tables._buckets.Length; i++)
				{
					for (ConcurrentDictionary<TKey, TValue>.Node node = this._tables._buckets[i]; node != null; node = node._next)
					{
						list.Add(node._value);
					}
				}
				result = new ReadOnlyCollection<TValue>(list);
			}
			finally
			{
				this.ReleaseLocks(0, toExclusive);
			}
			return result;
		}

		// Token: 0x06005F3B RID: 24379 RVA: 0x00140688 File Offset: 0x0013E888
		[OnSerializing]
		private void OnSerializing(StreamingContext context)
		{
			ConcurrentDictionary<TKey, TValue>.Tables tables = this._tables;
			this._serializationArray = this.ToArray();
			this._serializationConcurrencyLevel = tables._locks.Length;
			this._serializationCapacity = tables._buckets.Length;
		}

		// Token: 0x06005F3C RID: 24380 RVA: 0x001406C6 File Offset: 0x0013E8C6
		[OnSerialized]
		private void OnSerialized(StreamingContext context)
		{
			this._serializationArray = null;
		}

		// Token: 0x06005F3D RID: 24381 RVA: 0x001406D0 File Offset: 0x0013E8D0
		[OnDeserialized]
		private void OnDeserialized(StreamingContext context)
		{
			KeyValuePair<TKey, TValue>[] serializationArray = this._serializationArray;
			ConcurrentDictionary<TKey, TValue>.Node[] buckets = new ConcurrentDictionary<TKey, TValue>.Node[this._serializationCapacity];
			int[] countPerLock = new int[this._serializationConcurrencyLevel];
			object[] array = new object[this._serializationConcurrencyLevel];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new object();
			}
			this._tables = new ConcurrentDictionary<TKey, TValue>.Tables(buckets, array, countPerLock);
			this.InitializeFromCollection(serializationArray);
			this._serializationArray = null;
		}

		// Token: 0x0400393D RID: 14653
		[NonSerialized]
		private volatile ConcurrentDictionary<TKey, TValue>.Tables _tables;

		// Token: 0x0400393E RID: 14654
		private IEqualityComparer<TKey> _comparer;

		// Token: 0x0400393F RID: 14655
		[NonSerialized]
		private readonly bool _growLockArray;

		// Token: 0x04003940 RID: 14656
		[NonSerialized]
		private int _budget;

		// Token: 0x04003941 RID: 14657
		private KeyValuePair<TKey, TValue>[] _serializationArray;

		// Token: 0x04003942 RID: 14658
		private int _serializationConcurrencyLevel;

		// Token: 0x04003943 RID: 14659
		private int _serializationCapacity;

		// Token: 0x04003944 RID: 14660
		private const int DefaultCapacity = 31;

		// Token: 0x04003945 RID: 14661
		private const int MaxLockNumber = 1024;

		// Token: 0x04003946 RID: 14662
		private static readonly bool s_isValueWriteAtomic = ConcurrentDictionary<TKey, TValue>.IsValueWriteAtomic();

		// Token: 0x02000A59 RID: 2649
		private sealed class Tables
		{
			// Token: 0x06005F3F RID: 24383 RVA: 0x0014074D File Offset: 0x0013E94D
			internal Tables(ConcurrentDictionary<TKey, TValue>.Node[] buckets, object[] locks, int[] countPerLock)
			{
				this._buckets = buckets;
				this._locks = locks;
				this._countPerLock = countPerLock;
			}

			// Token: 0x04003947 RID: 14663
			internal readonly ConcurrentDictionary<TKey, TValue>.Node[] _buckets;

			// Token: 0x04003948 RID: 14664
			internal readonly object[] _locks;

			// Token: 0x04003949 RID: 14665
			internal volatile int[] _countPerLock;
		}

		// Token: 0x02000A5A RID: 2650
		[Serializable]
		private sealed class Node
		{
			// Token: 0x06005F40 RID: 24384 RVA: 0x0014076C File Offset: 0x0013E96C
			internal Node(TKey key, TValue value, int hashcode, ConcurrentDictionary<TKey, TValue>.Node next)
			{
				this._key = key;
				this._value = value;
				this._next = next;
				this._hashcode = hashcode;
			}

			// Token: 0x0400394A RID: 14666
			internal readonly TKey _key;

			// Token: 0x0400394B RID: 14667
			internal TValue _value;

			// Token: 0x0400394C RID: 14668
			internal volatile ConcurrentDictionary<TKey, TValue>.Node _next;

			// Token: 0x0400394D RID: 14669
			internal readonly int _hashcode;
		}

		// Token: 0x02000A5B RID: 2651
		[Serializable]
		private sealed class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x06005F41 RID: 24385 RVA: 0x00140793 File Offset: 0x0013E993
			internal DictionaryEnumerator(ConcurrentDictionary<TKey, TValue> dictionary)
			{
				this._enumerator = dictionary.GetEnumerator();
			}

			// Token: 0x170010B8 RID: 4280
			// (get) Token: 0x06005F42 RID: 24386 RVA: 0x001407A8 File Offset: 0x0013E9A8
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

			// Token: 0x170010B9 RID: 4281
			// (get) Token: 0x06005F43 RID: 24387 RVA: 0x001407EC File Offset: 0x0013E9EC
			public object Key
			{
				get
				{
					KeyValuePair<TKey, TValue> keyValuePair = this._enumerator.Current;
					return keyValuePair.Key;
				}
			}

			// Token: 0x170010BA RID: 4282
			// (get) Token: 0x06005F44 RID: 24388 RVA: 0x00140814 File Offset: 0x0013EA14
			public object Value
			{
				get
				{
					KeyValuePair<TKey, TValue> keyValuePair = this._enumerator.Current;
					return keyValuePair.Value;
				}
			}

			// Token: 0x170010BB RID: 4283
			// (get) Token: 0x06005F45 RID: 24389 RVA: 0x00140839 File Offset: 0x0013EA39
			public object Current
			{
				get
				{
					return this.Entry;
				}
			}

			// Token: 0x06005F46 RID: 24390 RVA: 0x00140846 File Offset: 0x0013EA46
			public bool MoveNext()
			{
				return this._enumerator.MoveNext();
			}

			// Token: 0x06005F47 RID: 24391 RVA: 0x00140853 File Offset: 0x0013EA53
			public void Reset()
			{
				this._enumerator.Reset();
			}

			// Token: 0x0400394E RID: 14670
			private IEnumerator<KeyValuePair<TKey, TValue>> _enumerator;
		}
	}
}
