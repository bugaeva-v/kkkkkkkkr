using System;

namespace System.Collections.Specialized
{
	/// <summary>Реализует интерфейс <see langword="IDictionary" /> с помощью класса <see cref="T:System.Collections.Specialized.ListDictionary" />, когда коллекция небольшая, и переключается на класс <see cref="T:System.Collections.Hashtable" />, когда коллекция увеличивается.</summary>
	// Token: 0x020004A5 RID: 1189
	[Serializable]
	public class HybridDictionary : IDictionary, ICollection, IEnumerable
	{
		/// <summary>Создает пустой объект <see cref="T:System.Collections.Specialized.HybridDictionary" />, в котором регистр не учитывается.</summary>
		// Token: 0x0600262D RID: 9773 RVA: 0x0000219B File Offset: 0x0000039B
		public HybridDictionary()
		{
		}

		/// <summary>Создает объект <see cref="T:System.Collections.Specialized.HybridDictionary" />, в котором учитывается регистр, с указанным исходным размером.</summary>
		/// <param name="initialSize">Приблизительное количество элементов, которое может содержать класс <see cref="T:System.Collections.Specialized.HybridDictionary" />.</param>
		// Token: 0x0600262E RID: 9774 RVA: 0x00085B5B File Offset: 0x00083D5B
		public HybridDictionary(int initialSize) : this(initialSize, false)
		{
		}

		/// <summary>Создает пустой объект <see cref="T:System.Collections.Specialized.HybridDictionary" /> с заданным требованием к учету регистра.</summary>
		/// <param name="caseInsensitive">Логическое выражение, которое определяет, учитывается ли регистр в объекте <see cref="T:System.Collections.Specialized.HybridDictionary" />.</param>
		// Token: 0x0600262F RID: 9775 RVA: 0x00085B65 File Offset: 0x00083D65
		public HybridDictionary(bool caseInsensitive)
		{
			this.caseInsensitive = caseInsensitive;
		}

		/// <summary>Создает объект <see cref="T:System.Collections.Specialized.HybridDictionary" /> указанного исходного размера с заданным требованием к учету регистра.</summary>
		/// <param name="initialSize">Приблизительное количество элементов, которое может содержать класс <see cref="T:System.Collections.Specialized.HybridDictionary" />.</param>
		/// <param name="caseInsensitive">Логическое выражение, которое определяет, учитывается ли регистр в объекте <see cref="T:System.Collections.Specialized.HybridDictionary" />.</param>
		// Token: 0x06002630 RID: 9776 RVA: 0x00085B74 File Offset: 0x00083D74
		public HybridDictionary(int initialSize, bool caseInsensitive)
		{
			this.caseInsensitive = caseInsensitive;
			if (initialSize >= 6)
			{
				if (caseInsensitive)
				{
					this.hashtable = new Hashtable(initialSize, StringComparer.OrdinalIgnoreCase);
					return;
				}
				this.hashtable = new Hashtable(initialSize);
			}
		}

		/// <summary>Возвращает или задает значение, связанное с указанным ключом.</summary>
		/// <param name="key">Задаваемое или получаемое значение ключа.</param>
		/// <returns>Значение, связанное с указанным ключом. Если указанный ключ не найден, при попытке его получения возвращается значение <see langword="null" />, а при попытке задания ключа создается новая запись с использованием указанного ключа.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x170007AC RID: 1964
		public object this[object key]
		{
			get
			{
				ListDictionary listDictionary = this.list;
				if (this.hashtable != null)
				{
					return this.hashtable[key];
				}
				if (listDictionary != null)
				{
					return listDictionary[key];
				}
				if (key == null)
				{
					throw new ArgumentNullException("key");
				}
				return null;
			}
			set
			{
				if (this.hashtable != null)
				{
					this.hashtable[key] = value;
					return;
				}
				if (this.list == null)
				{
					this.list = new ListDictionary(this.caseInsensitive ? StringComparer.OrdinalIgnoreCase : null);
					this.list[key] = value;
					return;
				}
				if (this.list.Count >= 8)
				{
					this.ChangeOver();
					this.hashtable[key] = value;
					return;
				}
				this.list[key] = value;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06002633 RID: 9779 RVA: 0x00085C6F File Offset: 0x00083E6F
		private ListDictionary List
		{
			get
			{
				if (this.list == null)
				{
					this.list = new ListDictionary(this.caseInsensitive ? StringComparer.OrdinalIgnoreCase : null);
				}
				return this.list;
			}
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x00085C9C File Offset: 0x00083E9C
		private void ChangeOver()
		{
			IDictionaryEnumerator enumerator = this.list.GetEnumerator();
			Hashtable hashtable;
			if (this.caseInsensitive)
			{
				hashtable = new Hashtable(13, StringComparer.OrdinalIgnoreCase);
			}
			else
			{
				hashtable = new Hashtable(13);
			}
			while (enumerator.MoveNext())
			{
				hashtable.Add(enumerator.Key, enumerator.Value);
			}
			this.hashtable = hashtable;
			this.list = null;
		}

		/// <summary>Возвращает число пар "ключ-значение", содержащихся в словаре <see cref="T:System.Collections.Specialized.HybridDictionary" />.</summary>
		/// <returns>Число пар "ключ-значение", содержащихся в словаре <see cref="T:System.Collections.Specialized.HybridDictionary" />.  
		/// Получение значения данного свойства является операцией порядка сложности O(1).</returns>
		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06002635 RID: 9781 RVA: 0x00085D00 File Offset: 0x00083F00
		public int Count
		{
			get
			{
				ListDictionary listDictionary = this.list;
				if (this.hashtable != null)
				{
					return this.hashtable.Count;
				}
				if (listDictionary != null)
				{
					return listDictionary.Count;
				}
				return 0;
			}
		}

		/// <summary>Получает коллекцию <see cref="T:System.Collections.ICollection" />, содержащую ключи из коллекции <see cref="T:System.Collections.Specialized.HybridDictionary" />.</summary>
		/// <returns>Коллекция <see cref="T:System.Collections.ICollection" />, содержащая ключи из коллекции <see cref="T:System.Collections.Specialized.HybridDictionary" />.</returns>
		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06002636 RID: 9782 RVA: 0x00085D33 File Offset: 0x00083F33
		public ICollection Keys
		{
			get
			{
				if (this.hashtable != null)
				{
					return this.hashtable.Keys;
				}
				return this.List.Keys;
			}
		}

		/// <summary>Получает значение, указывающее, является ли объект <see cref="T:System.Collections.Specialized.HybridDictionary" /> доступным только для чтения.</summary>
		/// <returns>Данное свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06002637 RID: 9783 RVA: 0x00003062 File Offset: 0x00001262
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает значение, указывающее, имеет ли список <see cref="T:System.Collections.Specialized.HybridDictionary" /> фиксированный размер.</summary>
		/// <returns>Данное свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06002638 RID: 9784 RVA: 0x00003062 File Offset: 0x00001262
		public bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает значение, показывающее, является ли доступ к <see cref="T:System.Collections.Specialized.HybridDictionary" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>Данное свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06002639 RID: 9785 RVA: 0x00003062 File Offset: 0x00001262
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.Specialized.HybridDictionary" />.</summary>
		/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Collections.Specialized.HybridDictionary" />.</returns>
		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x0600263A RID: 9786 RVA: 0x000075E1 File Offset: 0x000057E1
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>Возвращает интерфейс <see cref="T:System.Collections.ICollection" />, содержащий значения из <see cref="T:System.Collections.Specialized.HybridDictionary" />.</summary>
		/// <returns>Коллекция <see cref="T:System.Collections.ICollection" />, содержащая значения из словаря <see cref="T:System.Collections.Specialized.HybridDictionary" />.</returns>
		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x0600263B RID: 9787 RVA: 0x00085D54 File Offset: 0x00083F54
		public ICollection Values
		{
			get
			{
				if (this.hashtable != null)
				{
					return this.hashtable.Values;
				}
				return this.List.Values;
			}
		}

		/// <summary>Добавляет запись с указанными ключом и значением в <see cref="T:System.Collections.Specialized.HybridDictionary" />.</summary>
		/// <param name="key">Ключ записи, которую требуется добавить.</param>
		/// <param name="value">Добавляемое значение записи. Допускается значение <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Запись с таким ключом уже существует в <see cref="T:System.Collections.Specialized.HybridDictionary" />.</exception>
		// Token: 0x0600263C RID: 9788 RVA: 0x00085D78 File Offset: 0x00083F78
		public void Add(object key, object value)
		{
			if (this.hashtable != null)
			{
				this.hashtable.Add(key, value);
				return;
			}
			if (this.list == null)
			{
				this.list = new ListDictionary(this.caseInsensitive ? StringComparer.OrdinalIgnoreCase : null);
				this.list.Add(key, value);
				return;
			}
			if (this.list.Count + 1 >= 9)
			{
				this.ChangeOver();
				this.hashtable.Add(key, value);
				return;
			}
			this.list.Add(key, value);
		}

		/// <summary>Удаляет все записи из <see cref="T:System.Collections.Specialized.HybridDictionary" />.</summary>
		// Token: 0x0600263D RID: 9789 RVA: 0x00085DFE File Offset: 0x00083FFE
		public void Clear()
		{
			if (this.hashtable != null)
			{
				Hashtable hashtable = this.hashtable;
				this.hashtable = null;
				hashtable.Clear();
			}
			if (this.list != null)
			{
				ListDictionary listDictionary = this.list;
				this.list = null;
				listDictionary.Clear();
			}
		}

		/// <summary>Определяет, содержит ли объект <see cref="T:System.Collections.Specialized.HybridDictionary" /> указанный ключ.</summary>
		/// <param name="key">Ключ, который требуется найти в <see cref="T:System.Collections.Specialized.HybridDictionary" />.</param>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Collections.Specialized.HybridDictionary" /> содержит запись с указанным ключом; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600263E RID: 9790 RVA: 0x00085E34 File Offset: 0x00084034
		public bool Contains(object key)
		{
			ListDictionary listDictionary = this.list;
			if (this.hashtable != null)
			{
				return this.hashtable.Contains(key);
			}
			if (listDictionary != null)
			{
				return listDictionary.Contains(key);
			}
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			return false;
		}

		/// <summary>Копирует записи <see cref="T:System.Collections.Specialized.HybridDictionary" /> в одномерный экземпляр массива <see cref="T:System.Array" /> по указанному индексу.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, который является назначением для объектов <see cref="T:System.Collections.DictionaryEntry" />, копируемых из коллекции <see cref="T:System.Collections.Specialized.HybridDictionary" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		///
		/// или - 
		/// Число элементов в исходном массиве <see cref="T:System.Collections.Specialized.HybridDictionary" /> больше возможного для размещения числа элементов от положения, заданного значением параметра <paramref name="arrayIndex" />, до конца массива назначения <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Тип исходного массива <see cref="T:System.Collections.Specialized.HybridDictionary" /> не может быть автоматически приведен к типу массива назначения <paramref name="array" />.</exception>
		// Token: 0x0600263F RID: 9791 RVA: 0x00085E77 File Offset: 0x00084077
		public void CopyTo(Array array, int index)
		{
			if (this.hashtable != null)
			{
				this.hashtable.CopyTo(array, index);
				return;
			}
			this.List.CopyTo(array, index);
		}

		/// <summary>Возвращает объект <see cref="T:System.Collections.IDictionaryEnumerator" />, осуществляющий перебор <see cref="T:System.Collections.Specialized.HybridDictionary" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IDictionaryEnumerator" /> для <see cref="T:System.Collections.Specialized.HybridDictionary" />.</returns>
		// Token: 0x06002640 RID: 9792 RVA: 0x00085E9C File Offset: 0x0008409C
		public IDictionaryEnumerator GetEnumerator()
		{
			if (this.hashtable != null)
			{
				return this.hashtable.GetEnumerator();
			}
			if (this.list == null)
			{
				this.list = new ListDictionary(this.caseInsensitive ? StringComparer.OrdinalIgnoreCase : null);
			}
			return this.list.GetEnumerator();
		}

		/// <summary>Возвращает объект <see cref="T:System.Collections.IEnumerator" />, осуществляющий перебор <see cref="T:System.Collections.Specialized.HybridDictionary" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IEnumerator" /> для <see cref="T:System.Collections.Specialized.HybridDictionary" />.</returns>
		// Token: 0x06002641 RID: 9793 RVA: 0x00085EEC File Offset: 0x000840EC
		IEnumerator IEnumerable.GetEnumerator()
		{
			if (this.hashtable != null)
			{
				return this.hashtable.GetEnumerator();
			}
			if (this.list == null)
			{
				this.list = new ListDictionary(this.caseInsensitive ? StringComparer.OrdinalIgnoreCase : null);
			}
			return this.list.GetEnumerator();
		}

		/// <summary>Удаляет запись с указанным ключом из коллекции <see cref="T:System.Collections.Specialized.HybridDictionary" />.</summary>
		/// <param name="key">Ключ записи, которую требуется удалить.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002642 RID: 9794 RVA: 0x00085F3B File Offset: 0x0008413B
		public void Remove(object key)
		{
			if (this.hashtable != null)
			{
				this.hashtable.Remove(key);
				return;
			}
			if (this.list != null)
			{
				this.list.Remove(key);
				return;
			}
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
		}

		// Token: 0x040014E4 RID: 5348
		private const int CutoverPoint = 9;

		// Token: 0x040014E5 RID: 5349
		private const int InitialHashtableSize = 13;

		// Token: 0x040014E6 RID: 5350
		private const int FixedSizeCutoverPoint = 6;

		// Token: 0x040014E7 RID: 5351
		private ListDictionary list;

		// Token: 0x040014E8 RID: 5352
		private Hashtable hashtable;

		// Token: 0x040014E9 RID: 5353
		private readonly bool caseInsensitive;
	}
}
