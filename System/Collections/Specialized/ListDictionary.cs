using System;
using System.Threading;

namespace System.Collections.Specialized
{
	/// <summary>Реализует интерфейс <see langword="IDictionary" /> с помощью однонаправленного списка. Рекомендуется для коллекций, которые обычно содержат менее 10 элементов.</summary>
	// Token: 0x020004A7 RID: 1191
	[Serializable]
	public class ListDictionary : IDictionary, ICollection, IEnumerable
	{
		/// <summary>Создает пустую коллекцию <see cref="T:System.Collections.Specialized.ListDictionary" />, используя компаратор по умолчанию.</summary>
		// Token: 0x06002648 RID: 9800 RVA: 0x0000219B File Offset: 0x0000039B
		public ListDictionary()
		{
		}

		/// <summary>Создает пустую коллекцию <see cref="T:System.Collections.Specialized.ListDictionary" />, используя компаратор по умолчанию.</summary>
		/// <param name="comparer">Интерфейс <see cref="T:System.Collections.IComparer" />, который используется для определения равенства двух ключей.  
		///
		/// или - 
		/// Значение <see langword="null" /> для использования блока сравнения по умолчанию, который является реализацией метода <see cref="M:System.Object.Equals(System.Object)" /> для каждого ключа.</param>
		// Token: 0x06002649 RID: 9801 RVA: 0x00085F75 File Offset: 0x00084175
		public ListDictionary(IComparer comparer)
		{
			this.comparer = comparer;
		}

		/// <summary>Возвращает или задает значение, связанное с указанным ключом.</summary>
		/// <param name="key">Задаваемое или получаемое значение ключа.</param>
		/// <returns>Значение, связанное с указанным ключом. Если указанный ключ не найден, при попытке его получения возвращается значение <see langword="null" />, а при попытке задания ключа создается новая запись с использованием указанного ключа.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x170007B6 RID: 1974
		public object this[object key]
		{
			get
			{
				if (key == null)
				{
					throw new ArgumentNullException("key");
				}
				ListDictionary.DictionaryNode next = this.head;
				if (this.comparer == null)
				{
					while (next != null)
					{
						if (next.key.Equals(key))
						{
							return next.value;
						}
						next = next.next;
					}
				}
				else
				{
					while (next != null)
					{
						object key2 = next.key;
						if (this.comparer.Compare(key2, key) == 0)
						{
							return next.value;
						}
						next = next.next;
					}
				}
				return null;
			}
			set
			{
				if (key == null)
				{
					throw new ArgumentNullException("key");
				}
				this.version++;
				ListDictionary.DictionaryNode dictionaryNode = null;
				ListDictionary.DictionaryNode next;
				for (next = this.head; next != null; next = next.next)
				{
					object key2 = next.key;
					if ((this.comparer == null) ? key2.Equals(key) : (this.comparer.Compare(key2, key) == 0))
					{
						break;
					}
					dictionaryNode = next;
				}
				if (next != null)
				{
					next.value = value;
					return;
				}
				ListDictionary.DictionaryNode dictionaryNode2 = new ListDictionary.DictionaryNode();
				dictionaryNode2.key = key;
				dictionaryNode2.value = value;
				if (dictionaryNode != null)
				{
					dictionaryNode.next = dictionaryNode2;
				}
				else
				{
					this.head = dictionaryNode2;
				}
				this.count++;
			}
		}

		/// <summary>Возвращает число пар "ключ-значение", содержащихся в словаре <see cref="T:System.Collections.Specialized.ListDictionary" />.</summary>
		/// <returns>Число пар "ключ-значение", содержащихся в словаре <see cref="T:System.Collections.Specialized.ListDictionary" />.</returns>
		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x0600264C RID: 9804 RVA: 0x000860A6 File Offset: 0x000842A6
		public int Count
		{
			get
			{
				return this.count;
			}
		}

		/// <summary>Получает коллекцию <see cref="T:System.Collections.ICollection" />, содержащую ключи из коллекции <see cref="T:System.Collections.Specialized.ListDictionary" />.</summary>
		/// <returns>Коллекция <see cref="T:System.Collections.ICollection" />, содержащая ключи из коллекции <see cref="T:System.Collections.Specialized.ListDictionary" />.</returns>
		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x0600264D RID: 9805 RVA: 0x000860AE File Offset: 0x000842AE
		public ICollection Keys
		{
			get
			{
				return new ListDictionary.NodeKeyValueCollection(this, true);
			}
		}

		/// <summary>Получает значение, указывающее, является ли объект <see cref="T:System.Collections.Specialized.ListDictionary" /> доступным только для чтения.</summary>
		/// <returns>Данное свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x0600264E RID: 9806 RVA: 0x00003062 File Offset: 0x00001262
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает значение, указывающее, имеет ли список <see cref="T:System.Collections.Specialized.ListDictionary" /> фиксированный размер.</summary>
		/// <returns>Данное свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x0600264F RID: 9807 RVA: 0x00003062 File Offset: 0x00001262
		public bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает значение, показывающее, является ли доступ к <see cref="T:System.Collections.Specialized.ListDictionary" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>Данное свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06002650 RID: 9808 RVA: 0x00003062 File Offset: 0x00001262
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.Specialized.ListDictionary" />.</summary>
		/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Collections.Specialized.ListDictionary" />.</returns>
		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06002651 RID: 9809 RVA: 0x000860B7 File Offset: 0x000842B7
		public object SyncRoot
		{
			get
			{
				if (this._syncRoot == null)
				{
					Interlocked.CompareExchange(ref this._syncRoot, new object(), null);
				}
				return this._syncRoot;
			}
		}

		/// <summary>Возвращает интерфейс <see cref="T:System.Collections.ICollection" />, содержащий значения из <see cref="T:System.Collections.Specialized.ListDictionary" />.</summary>
		/// <returns>Коллекция <see cref="T:System.Collections.ICollection" />, содержащая значения из словаря <see cref="T:System.Collections.Specialized.ListDictionary" />.</returns>
		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06002652 RID: 9810 RVA: 0x000860D9 File Offset: 0x000842D9
		public ICollection Values
		{
			get
			{
				return new ListDictionary.NodeKeyValueCollection(this, false);
			}
		}

		/// <summary>Добавляет запись с указанными ключом и значением в <see cref="T:System.Collections.Specialized.ListDictionary" />.</summary>
		/// <param name="key">Ключ записи, которую требуется добавить.</param>
		/// <param name="value">Добавляемое значение записи. Допускается значение <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Запись с таким ключом уже существует в <see cref="T:System.Collections.Specialized.ListDictionary" />.</exception>
		// Token: 0x06002653 RID: 9811 RVA: 0x000860E4 File Offset: 0x000842E4
		public void Add(object key, object value)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			this.version++;
			ListDictionary.DictionaryNode dictionaryNode = null;
			for (ListDictionary.DictionaryNode next = this.head; next != null; next = next.next)
			{
				object key2 = next.key;
				if ((this.comparer == null) ? key2.Equals(key) : (this.comparer.Compare(key2, key) == 0))
				{
					throw new ArgumentException(SR.Format("An item with the same key has already been added. Key: {0}", key));
				}
				dictionaryNode = next;
			}
			ListDictionary.DictionaryNode dictionaryNode2 = new ListDictionary.DictionaryNode();
			dictionaryNode2.key = key;
			dictionaryNode2.value = value;
			if (dictionaryNode != null)
			{
				dictionaryNode.next = dictionaryNode2;
			}
			else
			{
				this.head = dictionaryNode2;
			}
			this.count++;
		}

		/// <summary>Удаляет все записи из <see cref="T:System.Collections.Specialized.ListDictionary" />.</summary>
		// Token: 0x06002654 RID: 9812 RVA: 0x00086194 File Offset: 0x00084394
		public void Clear()
		{
			this.count = 0;
			this.head = null;
			this.version++;
		}

		/// <summary>Определяет, содержит ли объект <see cref="T:System.Collections.Specialized.ListDictionary" /> указанный ключ.</summary>
		/// <param name="key">Ключ, который требуется найти в <see cref="T:System.Collections.Specialized.ListDictionary" />.</param>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Collections.Specialized.ListDictionary" /> содержит запись с указанным ключом; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002655 RID: 9813 RVA: 0x000861B4 File Offset: 0x000843B4
		public bool Contains(object key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			for (ListDictionary.DictionaryNode next = this.head; next != null; next = next.next)
			{
				object key2 = next.key;
				if ((this.comparer == null) ? key2.Equals(key) : (this.comparer.Compare(key2, key) == 0))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Копирует записи <see cref="T:System.Collections.Specialized.ListDictionary" /> в одномерный экземпляр массива <see cref="T:System.Array" /> по указанному индексу.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, который является назначением для объектов <see cref="T:System.Collections.DictionaryEntry" />, копируемых из коллекции <see cref="T:System.Collections.Specialized.ListDictionary" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		///
		/// или - 
		/// Число элементов в исходном массиве <see cref="T:System.Collections.Specialized.ListDictionary" /> больше возможного для размещения числа элементов от положения, заданного значением параметра <paramref name="index" />, до конца массива назначения <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Тип исходного массива <see cref="T:System.Collections.Specialized.ListDictionary" /> не может быть автоматически приведен к типу массива назначения <paramref name="array" />.</exception>
		// Token: 0x06002656 RID: 9814 RVA: 0x00086210 File Offset: 0x00084410
		public void CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", index, "Non-negative number required.");
			}
			if (array.Length - index < this.count)
			{
				throw new ArgumentException("Insufficient space in the target location to copy the information.");
			}
			for (ListDictionary.DictionaryNode next = this.head; next != null; next = next.next)
			{
				array.SetValue(new DictionaryEntry(next.key, next.value), index);
				index++;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Collections.IDictionaryEnumerator" />, осуществляющий перебор <see cref="T:System.Collections.Specialized.ListDictionary" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IDictionaryEnumerator" /> для <see cref="T:System.Collections.Specialized.ListDictionary" />.</returns>
		// Token: 0x06002657 RID: 9815 RVA: 0x00086295 File Offset: 0x00084495
		public IDictionaryEnumerator GetEnumerator()
		{
			return new ListDictionary.NodeEnumerator(this);
		}

		/// <summary>Возвращает объект <see cref="T:System.Collections.IEnumerator" />, осуществляющий перебор <see cref="T:System.Collections.Specialized.ListDictionary" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IEnumerator" /> для <see cref="T:System.Collections.Specialized.ListDictionary" />.</returns>
		// Token: 0x06002658 RID: 9816 RVA: 0x00086295 File Offset: 0x00084495
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new ListDictionary.NodeEnumerator(this);
		}

		/// <summary>Удаляет запись с указанным ключом из коллекции <see cref="T:System.Collections.Specialized.ListDictionary" />.</summary>
		/// <param name="key">Ключ записи, которую требуется удалить.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002659 RID: 9817 RVA: 0x000862A0 File Offset: 0x000844A0
		public void Remove(object key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			this.version++;
			ListDictionary.DictionaryNode dictionaryNode = null;
			ListDictionary.DictionaryNode next;
			for (next = this.head; next != null; next = next.next)
			{
				object key2 = next.key;
				if ((this.comparer == null) ? key2.Equals(key) : (this.comparer.Compare(key2, key) == 0))
				{
					break;
				}
				dictionaryNode = next;
			}
			if (next == null)
			{
				return;
			}
			if (next == this.head)
			{
				this.head = next.next;
			}
			else
			{
				dictionaryNode.next = next.next;
			}
			this.count--;
		}

		// Token: 0x040014EA RID: 5354
		private ListDictionary.DictionaryNode head;

		// Token: 0x040014EB RID: 5355
		private int version;

		// Token: 0x040014EC RID: 5356
		private int count;

		// Token: 0x040014ED RID: 5357
		private readonly IComparer comparer;

		// Token: 0x040014EE RID: 5358
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x020004A8 RID: 1192
		private class NodeEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x0600265A RID: 9818 RVA: 0x0008633F File Offset: 0x0008453F
			public NodeEnumerator(ListDictionary list)
			{
				this._list = list;
				this._version = list.version;
				this._start = true;
				this._current = null;
			}

			// Token: 0x170007BE RID: 1982
			// (get) Token: 0x0600265B RID: 9819 RVA: 0x00086368 File Offset: 0x00084568
			public object Current
			{
				get
				{
					return this.Entry;
				}
			}

			// Token: 0x170007BF RID: 1983
			// (get) Token: 0x0600265C RID: 9820 RVA: 0x00086375 File Offset: 0x00084575
			public DictionaryEntry Entry
			{
				get
				{
					if (this._current == null)
					{
						throw new InvalidOperationException("Enumeration has either not started or has already finished.");
					}
					return new DictionaryEntry(this._current.key, this._current.value);
				}
			}

			// Token: 0x170007C0 RID: 1984
			// (get) Token: 0x0600265D RID: 9821 RVA: 0x000863A5 File Offset: 0x000845A5
			public object Key
			{
				get
				{
					if (this._current == null)
					{
						throw new InvalidOperationException("Enumeration has either not started or has already finished.");
					}
					return this._current.key;
				}
			}

			// Token: 0x170007C1 RID: 1985
			// (get) Token: 0x0600265E RID: 9822 RVA: 0x000863C5 File Offset: 0x000845C5
			public object Value
			{
				get
				{
					if (this._current == null)
					{
						throw new InvalidOperationException("Enumeration has either not started or has already finished.");
					}
					return this._current.value;
				}
			}

			// Token: 0x0600265F RID: 9823 RVA: 0x000863E8 File Offset: 0x000845E8
			public bool MoveNext()
			{
				if (this._version != this._list.version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				if (this._start)
				{
					this._current = this._list.head;
					this._start = false;
				}
				else if (this._current != null)
				{
					this._current = this._current.next;
				}
				return this._current != null;
			}

			// Token: 0x06002660 RID: 9824 RVA: 0x00086457 File Offset: 0x00084657
			public void Reset()
			{
				if (this._version != this._list.version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				this._start = true;
				this._current = null;
			}

			// Token: 0x040014EF RID: 5359
			private ListDictionary _list;

			// Token: 0x040014F0 RID: 5360
			private ListDictionary.DictionaryNode _current;

			// Token: 0x040014F1 RID: 5361
			private int _version;

			// Token: 0x040014F2 RID: 5362
			private bool _start;
		}

		// Token: 0x020004A9 RID: 1193
		private class NodeKeyValueCollection : ICollection, IEnumerable
		{
			// Token: 0x06002661 RID: 9825 RVA: 0x00086485 File Offset: 0x00084685
			public NodeKeyValueCollection(ListDictionary list, bool isKeys)
			{
				this._list = list;
				this._isKeys = isKeys;
			}

			// Token: 0x06002662 RID: 9826 RVA: 0x0008649C File Offset: 0x0008469C
			void ICollection.CopyTo(Array array, int index)
			{
				if (array == null)
				{
					throw new ArgumentNullException("array");
				}
				if (index < 0)
				{
					throw new ArgumentOutOfRangeException("index", index, "Non-negative number required.");
				}
				for (ListDictionary.DictionaryNode dictionaryNode = this._list.head; dictionaryNode != null; dictionaryNode = dictionaryNode.next)
				{
					array.SetValue(this._isKeys ? dictionaryNode.key : dictionaryNode.value, index);
					index++;
				}
			}

			// Token: 0x170007C2 RID: 1986
			// (get) Token: 0x06002663 RID: 9827 RVA: 0x0008650C File Offset: 0x0008470C
			int ICollection.Count
			{
				get
				{
					int num = 0;
					for (ListDictionary.DictionaryNode dictionaryNode = this._list.head; dictionaryNode != null; dictionaryNode = dictionaryNode.next)
					{
						num++;
					}
					return num;
				}
			}

			// Token: 0x170007C3 RID: 1987
			// (get) Token: 0x06002664 RID: 9828 RVA: 0x00003062 File Offset: 0x00001262
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170007C4 RID: 1988
			// (get) Token: 0x06002665 RID: 9829 RVA: 0x00086538 File Offset: 0x00084738
			object ICollection.SyncRoot
			{
				get
				{
					return this._list.SyncRoot;
				}
			}

			// Token: 0x06002666 RID: 9830 RVA: 0x00086545 File Offset: 0x00084745
			IEnumerator IEnumerable.GetEnumerator()
			{
				return new ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator(this._list, this._isKeys);
			}

			// Token: 0x040014F3 RID: 5363
			private ListDictionary _list;

			// Token: 0x040014F4 RID: 5364
			private bool _isKeys;

			// Token: 0x020004AA RID: 1194
			private class NodeKeyValueEnumerator : IEnumerator
			{
				// Token: 0x06002667 RID: 9831 RVA: 0x00086558 File Offset: 0x00084758
				public NodeKeyValueEnumerator(ListDictionary list, bool isKeys)
				{
					this._list = list;
					this._isKeys = isKeys;
					this._version = list.version;
					this._start = true;
					this._current = null;
				}

				// Token: 0x170007C5 RID: 1989
				// (get) Token: 0x06002668 RID: 9832 RVA: 0x00086588 File Offset: 0x00084788
				public object Current
				{
					get
					{
						if (this._current == null)
						{
							throw new InvalidOperationException("Enumeration has either not started or has already finished.");
						}
						if (!this._isKeys)
						{
							return this._current.value;
						}
						return this._current.key;
					}
				}

				// Token: 0x06002669 RID: 9833 RVA: 0x000865BC File Offset: 0x000847BC
				public bool MoveNext()
				{
					if (this._version != this._list.version)
					{
						throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
					}
					if (this._start)
					{
						this._current = this._list.head;
						this._start = false;
					}
					else if (this._current != null)
					{
						this._current = this._current.next;
					}
					return this._current != null;
				}

				// Token: 0x0600266A RID: 9834 RVA: 0x0008662B File Offset: 0x0008482B
				public void Reset()
				{
					if (this._version != this._list.version)
					{
						throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
					}
					this._start = true;
					this._current = null;
				}

				// Token: 0x040014F5 RID: 5365
				private ListDictionary _list;

				// Token: 0x040014F6 RID: 5366
				private ListDictionary.DictionaryNode _current;

				// Token: 0x040014F7 RID: 5367
				private int _version;

				// Token: 0x040014F8 RID: 5368
				private bool _isKeys;

				// Token: 0x040014F9 RID: 5369
				private bool _start;
			}
		}

		// Token: 0x020004AB RID: 1195
		[Serializable]
		public class DictionaryNode
		{
			// Token: 0x040014FA RID: 5370
			public object key;

			// Token: 0x040014FB RID: 5371
			public object value;

			// Token: 0x040014FC RID: 5372
			public ListDictionary.DictionaryNode next;
		}
	}
}
