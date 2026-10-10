using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.Collections.ObjectModel
{
	/// <summary>Предоставляет абстрактный базовый класс для коллекции, ключи которой внедрены в значения.</summary>
	/// <typeparam name="TKey">Тип ключей в коллекции.</typeparam>
	/// <typeparam name="TItem">Тип элементов в коллекции.</typeparam>
	// Token: 0x02000A82 RID: 2690
	[DebuggerTypeProxy(typeof(CollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public abstract class KeyedCollection<TKey, TItem> : Collection<TItem>
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" />, в котором используется компаратор по умолчанию.</summary>
		// Token: 0x06006040 RID: 24640 RVA: 0x001428F1 File Offset: 0x00140AF1
		protected KeyedCollection() : this(null, 0)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" />, в котором используется заданный компаратор.</summary>
		/// <param name="comparer">Реализация универсального интерфейса <see cref="T:System.Collections.Generic.IEqualityComparer`1" />, которая может использоваться при сравнении ключей, или <see langword="null" />, чтобы использовать компаратор по умолчанию для типа ключа, полученного из <see cref="P:System.Collections.Generic.EqualityComparer`1.Default" />.</param>
		// Token: 0x06006041 RID: 24641 RVA: 0x001428FB File Offset: 0x00140AFB
		protected KeyedCollection(IEqualityComparer<TKey> comparer) : this(comparer, 0)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" />, который использует заданный компаратор и создает словарь поиска при превышении заданного порога.</summary>
		/// <param name="comparer">Реализация универсального интерфейса <see cref="T:System.Collections.Generic.IEqualityComparer`1" />, которая может использоваться при сравнении ключей, или <see langword="null" />, чтобы использовать компаратор по умолчанию для типа ключа, полученного из <see cref="P:System.Collections.Generic.EqualityComparer`1.Default" />.</param>
		/// <param name="dictionaryCreationThreshold">Количество элементов, которое может содержать коллекция без создания словаря поиска (при значении 0 словарь поиска создается при добавлении первого элемента), или –1, чтобы словарь поиска не создавался никогда.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="dictionaryCreationThreshold" /> меньше -1.</exception>
		// Token: 0x06006042 RID: 24642 RVA: 0x00142908 File Offset: 0x00140B08
		protected KeyedCollection(IEqualityComparer<TKey> comparer, int dictionaryCreationThreshold) : base(new List<TItem>())
		{
			if (comparer == null)
			{
				comparer = EqualityComparer<TKey>.Default;
			}
			if (dictionaryCreationThreshold == -1)
			{
				dictionaryCreationThreshold = int.MaxValue;
			}
			if (dictionaryCreationThreshold < -1)
			{
				throw new ArgumentOutOfRangeException("dictionaryCreationThreshold", "The specified threshold for creating dictionary is out of range.");
			}
			this.comparer = comparer;
			this.threshold = dictionaryCreationThreshold;
		}

		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x06006043 RID: 24643 RVA: 0x00142957 File Offset: 0x00140B57
		private new List<TItem> Items
		{
			get
			{
				return (List<TItem>)base.Items;
			}
		}

		/// <summary>Получает универсальный компаратор, используемый для определения равенства ключей в коллекции.</summary>
		/// <returns>Реализация универсального интерфейса <see cref="T:System.Collections.Generic.IEqualityComparer`1" />, используемого для определения равенства ключей в коллекции.</returns>
		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x06006044 RID: 24644 RVA: 0x00142964 File Offset: 0x00140B64
		public IEqualityComparer<TKey> Comparer
		{
			get
			{
				return this.comparer;
			}
		}

		/// <summary>Получает элемент с указанным ключом.</summary>
		/// <param name="key">Ключ элемента, который требуется получить.</param>
		/// <returns>Элемент с указанным ключом. Если элемент с указанным ключом не найден, выдается исключение.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.Collections.Generic.KeyNotFoundException">Элемент с указанным ключом отсутствует в коллекции.</exception>
		// Token: 0x170010F9 RID: 4345
		public TItem this[TKey key]
		{
			get
			{
				TItem result;
				if (this.TryGetValue(key, out result))
				{
					return result;
				}
				throw new KeyNotFoundException(SR.Format("The given key '{0}' was not present in the dictionary.", key.ToString()));
			}
		}

		/// <summary>Определяет, содержится ли в коллекции элемент с указанным ключом.</summary>
		/// <param name="key">Ключ, который требуется найти в <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" />.</param>
		/// <returns>
		///   <see langword="true" />, если <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" /> содержит элемент с указанным ключом, в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		// Token: 0x06006046 RID: 24646 RVA: 0x001429A4 File Offset: 0x00140BA4
		public bool Contains(TKey key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			if (this.dict != null)
			{
				return this.dict.ContainsKey(key);
			}
			foreach (TItem item in this.Items)
			{
				if (this.comparer.Equals(this.GetKeyForItem(item), key))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06006047 RID: 24647 RVA: 0x00142A34 File Offset: 0x00140C34
		public bool TryGetValue(TKey key, out TItem item)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			if (this.dict != null)
			{
				return this.dict.TryGetValue(key, out item);
			}
			foreach (TItem titem in this.Items)
			{
				TKey keyForItem = this.GetKeyForItem(titem);
				if (keyForItem != null && this.comparer.Equals(key, keyForItem))
				{
					item = titem;
					return true;
				}
			}
			item = default(TItem);
			return false;
		}

		// Token: 0x06006048 RID: 24648 RVA: 0x00142AE0 File Offset: 0x00140CE0
		private bool ContainsItem(TItem item)
		{
			TKey keyForItem;
			if (this.dict == null || (keyForItem = this.GetKeyForItem(item)) == null)
			{
				return this.Items.Contains(item);
			}
			TItem x;
			return this.dict.TryGetValue(keyForItem, out x) && EqualityComparer<TItem>.Default.Equals(x, item);
		}

		/// <summary>Удаляет элемент с указанным ключом из <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" />.</summary>
		/// <param name="key">Ключ удаляемого элемента.</param>
		/// <returns>Значение <see langword="true" />, если элемент успешно удален, в противном случае — значение <see langword="false" />.  Этот метод также возвращает значение <see langword="false" />, если элемент <paramref name="key" /> не найден в <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		// Token: 0x06006049 RID: 24649 RVA: 0x00142B30 File Offset: 0x00140D30
		public bool Remove(TKey key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			if (this.dict != null)
			{
				TItem item;
				return this.dict.TryGetValue(key, out item) && base.Remove(item);
			}
			for (int i = 0; i < this.Items.Count; i++)
			{
				if (this.comparer.Equals(this.GetKeyForItem(this.Items[i]), key))
				{
					this.RemoveItem(i);
					return true;
				}
			}
			return false;
		}

		/// <summary>Получает словарь поиска <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" />.</summary>
		/// <returns>Словарь поиска коллекции <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" />, если он существует; в противном случае — значение <see langword="null" />.</returns>
		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x0600604A RID: 24650 RVA: 0x00142BB2 File Offset: 0x00140DB2
		protected IDictionary<TKey, TItem> Dictionary
		{
			get
			{
				return this.dict;
			}
		}

		/// <summary>Изменяет ключ, связанный с указанным элементом в словаре поиска.</summary>
		/// <param name="item">Элемент, ключ которого требуется изменить.</param>
		/// <param name="newKey">Новый ключ для <paramref name="item" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="item" /> — <see langword="null" />.  
		/// -или- 
		///  <paramref name="key" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="item" /> не найден.  
		/// -или- 
		///  Указанный параметр <paramref name="key" /> уже существует в <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" />.</exception>
		// Token: 0x0600604B RID: 24651 RVA: 0x00142BBC File Offset: 0x00140DBC
		protected void ChangeItemKey(TItem item, TKey newKey)
		{
			if (!this.ContainsItem(item))
			{
				throw new ArgumentException("The specified item does not exist in this KeyedCollection.");
			}
			TKey keyForItem = this.GetKeyForItem(item);
			if (!this.comparer.Equals(keyForItem, newKey))
			{
				if (newKey != null)
				{
					this.AddKey(newKey, item);
				}
				if (keyForItem != null)
				{
					this.RemoveKey(keyForItem);
				}
			}
		}

		/// <summary>Удаляет все элементы из коллекции <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" />.</summary>
		// Token: 0x0600604C RID: 24652 RVA: 0x00142C13 File Offset: 0x00140E13
		protected override void ClearItems()
		{
			base.ClearItems();
			if (this.dict != null)
			{
				this.dict.Clear();
			}
			this.keyCount = 0;
		}

		/// <summary>При реализации в производном классе извлекает ключ из указанного элемента.</summary>
		/// <param name="item">Элемент, из которого нужно извлечь ключ.</param>
		/// <returns>Ключ для указанного элемента.</returns>
		// Token: 0x0600604D RID: 24653
		protected abstract TKey GetKeyForItem(TItem item);

		/// <summary>Добавляет элемент в список <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" /> в позиции с указанным индексом.</summary>
		/// <param name="index">Индекс (с нуля), по которому следует вставить параметр <paramref name="item" />.</param>
		/// <param name="item">Объект, который нужно вставить.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="index" /> больше значения <see cref="P:System.Collections.ObjectModel.Collection`1.Count" />.</exception>
		// Token: 0x0600604E RID: 24654 RVA: 0x00142C38 File Offset: 0x00140E38
		protected override void InsertItem(int index, TItem item)
		{
			TKey keyForItem = this.GetKeyForItem(item);
			if (keyForItem != null)
			{
				this.AddKey(keyForItem, item);
			}
			base.InsertItem(index, item);
		}

		/// <summary>Удаляет элемент списка <see cref="T:System.Collections.ObjectModel.KeyedCollection`2" /> с указанным индексом.</summary>
		/// <param name="index">Индекс элемента, который должен быть удален.</param>
		// Token: 0x0600604F RID: 24655 RVA: 0x00142C68 File Offset: 0x00140E68
		protected override void RemoveItem(int index)
		{
			TKey keyForItem = this.GetKeyForItem(this.Items[index]);
			if (keyForItem != null)
			{
				this.RemoveKey(keyForItem);
			}
			base.RemoveItem(index);
		}

		/// <summary>Заменяет элемент по заданному индексу указанным элементом.</summary>
		/// <param name="index">Индекс (с нуля) заменяемого элемента.</param>
		/// <param name="item">Новый элемент.</param>
		// Token: 0x06006050 RID: 24656 RVA: 0x00142CA0 File Offset: 0x00140EA0
		protected override void SetItem(int index, TItem item)
		{
			TKey keyForItem = this.GetKeyForItem(item);
			TKey keyForItem2 = this.GetKeyForItem(this.Items[index]);
			if (this.comparer.Equals(keyForItem2, keyForItem))
			{
				if (keyForItem != null && this.dict != null)
				{
					this.dict[keyForItem] = item;
				}
			}
			else
			{
				if (keyForItem != null)
				{
					this.AddKey(keyForItem, item);
				}
				if (keyForItem2 != null)
				{
					this.RemoveKey(keyForItem2);
				}
			}
			base.SetItem(index, item);
		}

		// Token: 0x06006051 RID: 24657 RVA: 0x00142D20 File Offset: 0x00140F20
		private void AddKey(TKey key, TItem item)
		{
			if (this.dict != null)
			{
				this.dict.Add(key, item);
				return;
			}
			if (this.keyCount == this.threshold)
			{
				this.CreateDictionary();
				this.dict.Add(key, item);
				return;
			}
			if (this.Contains(key))
			{
				throw new ArgumentException(SR.Format("An item with the same key has already been added. Key: {0}", key));
			}
			this.keyCount++;
		}

		// Token: 0x06006052 RID: 24658 RVA: 0x00142D94 File Offset: 0x00140F94
		private void CreateDictionary()
		{
			this.dict = new Dictionary<TKey, TItem>(this.comparer);
			foreach (TItem titem in this.Items)
			{
				TKey keyForItem = this.GetKeyForItem(titem);
				if (keyForItem != null)
				{
					this.dict.Add(keyForItem, titem);
				}
			}
		}

		// Token: 0x06006053 RID: 24659 RVA: 0x00142E10 File Offset: 0x00141010
		private void RemoveKey(TKey key)
		{
			if (this.dict != null)
			{
				this.dict.Remove(key);
				return;
			}
			this.keyCount--;
		}

		// Token: 0x040039AC RID: 14764
		private const int defaultThreshold = 0;

		// Token: 0x040039AD RID: 14765
		private readonly IEqualityComparer<TKey> comparer;

		// Token: 0x040039AE RID: 14766
		private Dictionary<TKey, TItem> dict;

		// Token: 0x040039AF RID: 14767
		private int keyCount;

		// Token: 0x040039B0 RID: 14768
		private readonly int threshold;
	}
}
