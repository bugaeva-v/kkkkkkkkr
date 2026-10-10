using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Collections
{
	/// <summary>Предоставляет коллекцию пар «ключ-значение», упорядоченных по ключам. Доступ к парам можно получить по ключу и индексу.</summary>
	// Token: 0x02000A2C RID: 2604
	[DebuggerTypeProxy(typeof(SortedList.SortedListDebugView))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public class SortedList : IDictionary, ICollection, IEnumerable, ICloneable
	{
		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.SortedList" /> с начальной емкостью по умолчанию, упорядоченный в соответствии с интерфейсом <see cref="T:System.IComparable" />, который реализован каждым ключом, добавленным в объект <see cref="T:System.Collections.SortedList" />.</summary>
		// Token: 0x06005C45 RID: 23621 RVA: 0x00136682 File Offset: 0x00134882
		public SortedList()
		{
			this.Init();
		}

		// Token: 0x06005C46 RID: 23622 RVA: 0x00136690 File Offset: 0x00134890
		private void Init()
		{
			this.keys = Array.Empty<object>();
			this.values = Array.Empty<object>();
			this._size = 0;
			this.comparer = new Comparer(CultureInfo.CurrentCulture);
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.SortedList" /> с указанной начальной емкостью, упорядоченный в соответствии с интерфейсом <see cref="T:System.IComparable" />, который реализован каждым ключом, добавленным в объект <see cref="T:System.Collections.SortedList" />.</summary>
		/// <param name="initialCapacity">Начальное количество элементов, которое может содержать объект <see cref="T:System.Collections.SortedList" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="initialCapacity" /> меньше нуля.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Недостаточно свободной памяти для создания объекта <see cref="T:System.Collections.SortedList" /> с указанным значением параметра <paramref name="initialCapacity" />.</exception>
		// Token: 0x06005C47 RID: 23623 RVA: 0x001366C0 File Offset: 0x001348C0
		public SortedList(int initialCapacity)
		{
			if (initialCapacity < 0)
			{
				throw new ArgumentOutOfRangeException("initialCapacity", "Non-negative number required.");
			}
			this.keys = new object[initialCapacity];
			this.values = new object[initialCapacity];
			this.comparer = new Comparer(CultureInfo.CurrentCulture);
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.SortedList" /> с начальной емкостью по умолчанию, упорядоченный в соответствии с указанным интерфейсом <see cref="T:System.Collections.IComparer" />.</summary>
		/// <param name="comparer">Реализация интерфейса <see cref="T:System.Collections.IComparer" />, используемая при сравнении ключей.  
		/// -или- 
		///  Значение <see langword="null" />, используемое в реализации интерфейса <see cref="T:System.IComparable" /> каждого ключа.</param>
		// Token: 0x06005C48 RID: 23624 RVA: 0x0013670F File Offset: 0x0013490F
		public SortedList(IComparer comparer) : this()
		{
			if (comparer != null)
			{
				this.comparer = comparer;
			}
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.SortedList" /> с указанной начальной емкостью, упорядоченный в соответствии с указанным интерфейсом <see cref="T:System.Collections.IComparer" />.</summary>
		/// <param name="comparer">Реализация интерфейса <see cref="T:System.Collections.IComparer" />, используемая при сравнении ключей.  
		/// -или- 
		///  Значение <see langword="null" />, используемое в реализации интерфейса <see cref="T:System.IComparable" /> каждого ключа.</param>
		/// <param name="capacity">Начальное количество элементов, которое может содержать объект <see cref="T:System.Collections.SortedList" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="capacity" /> меньше нуля.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Недостаточно свободной памяти для создания объекта <see cref="T:System.Collections.SortedList" /> с указанным значением параметра <paramref name="capacity" />.</exception>
		// Token: 0x06005C49 RID: 23625 RVA: 0x00136721 File Offset: 0x00134921
		public SortedList(IComparer comparer, int capacity) : this(comparer)
		{
			this.Capacity = capacity;
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Collections.SortedList" />, содержащий элементы, скопированные из указанного словаря, обладающий начальной емкостью, равной количеству скопированных элементов и упорядоченный в соответствии с реализацией интерфейса <see cref="T:System.IComparable" /> каждого ключа.</summary>
		/// <param name="d">Реализация интерфейса <see cref="T:System.Collections.IDictionary" /> для копирования в новый объект <see cref="T:System.Collections.SortedList" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="d" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Один или несколько элементов в <paramref name="d" /> не реализуют интерфейс <see cref="T:System.IComparable" />.</exception>
		// Token: 0x06005C4A RID: 23626 RVA: 0x00136731 File Offset: 0x00134931
		public SortedList(IDictionary d) : this(d, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Collections.SortedList" />, содержащий элементы, скопированные из указанного словаря, обладающий начальной емкостью, равной количеству скопированных элементов и упорядоченный в соответствии с указанным интерфейсом <see cref="T:System.Collections.IComparer" />.</summary>
		/// <param name="d">Реализация интерфейса <see cref="T:System.Collections.IDictionary" /> для копирования в новый объект <see cref="T:System.Collections.SortedList" />.</param>
		/// <param name="comparer">Реализация интерфейса <see cref="T:System.Collections.IComparer" />, используемая при сравнении ключей.  
		/// -или- 
		///  Значение <see langword="null" />, используемое в реализации интерфейса <see cref="T:System.IComparable" /> каждого ключа.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="d" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="comparer" /> имеет значение <see langword="null" />, и один или несколько элементов в <paramref name="d" /> не реализуют интерфейс <see cref="T:System.IComparable" />.</exception>
		// Token: 0x06005C4B RID: 23627 RVA: 0x0013673C File Offset: 0x0013493C
		public SortedList(IDictionary d, IComparer comparer) : this(comparer, (d != null) ? d.Count : 0)
		{
			if (d == null)
			{
				throw new ArgumentNullException("d", "Dictionary cannot be null.");
			}
			d.Keys.CopyTo(this.keys, 0);
			d.Values.CopyTo(this.values, 0);
			Array.Sort(this.keys, comparer);
			for (int i = 0; i < this.keys.Length; i++)
			{
				this.values[i] = d[this.keys[i]];
			}
			this._size = d.Count;
		}

		/// <summary>Добавляет элемент с указанными ключом и значением в объект <see cref="T:System.Collections.SortedList" />.</summary>
		/// <param name="key">Ключ добавляемого элемента.</param>
		/// <param name="value">Добавляемое значение элемента. Допускается значение <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Элемент с указанным значением параметра <paramref name="key" /> уже существует в объекте <see cref="T:System.Collections.SortedList" />.  
		/// -или- 
		/// Для объекта <see cref="T:System.Collections.SortedList" /> задано использование интерфейса <see cref="T:System.IComparable" />, а параметр <paramref name="key" /> не реализует интерфейс <see cref="T:System.IComparable" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.SortedList" /> доступен только для чтения.  
		/// -или- 
		/// <see cref="T:System.Collections.SortedList" /> имеет фиксированный размер.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Недостаточно свободной памяти для добавления элемента в объект <see cref="T:System.Collections.SortedList" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Средство сравнения выдает исключение.</exception>
		// Token: 0x06005C4C RID: 23628 RVA: 0x001367D4 File Offset: 0x001349D4
		public virtual void Add(object key, object value)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key", "Key cannot be null.");
			}
			int num = Array.BinarySearch(this.keys, 0, this._size, key, this.comparer);
			if (num >= 0)
			{
				throw new ArgumentException(SR.Format("Item has already been added. Key in dictionary: '{0}'  Key being added: '{1}'", this.GetKey(num), key));
			}
			this.Insert(~num, key, value);
		}

		/// <summary>Возвращает или задает емкость объекта <see cref="T:System.Collections.SortedList" />.</summary>
		/// <returns>Начальное количество элементов, которое может содержать объект <see cref="T:System.Collections.SortedList" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Присваиваемое значение меньше, чем текущее число элементов в объекте <see cref="T:System.Collections.SortedList" />.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти в системе.</exception>
		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x06005C4D RID: 23629 RVA: 0x00136834 File Offset: 0x00134A34
		// (set) Token: 0x06005C4E RID: 23630 RVA: 0x00136840 File Offset: 0x00134A40
		public virtual int Capacity
		{
			get
			{
				return this.keys.Length;
			}
			set
			{
				if (value < this.Count)
				{
					throw new ArgumentOutOfRangeException("value", "capacity was less than the current size.");
				}
				if (value != this.keys.Length)
				{
					if (value > 0)
					{
						object[] destinationArray = new object[value];
						object[] destinationArray2 = new object[value];
						if (this._size > 0)
						{
							Array.Copy(this.keys, 0, destinationArray, 0, this._size);
							Array.Copy(this.values, 0, destinationArray2, 0, this._size);
						}
						this.keys = destinationArray;
						this.values = destinationArray2;
						return;
					}
					this.keys = Array.Empty<object>();
					this.values = Array.Empty<object>();
				}
			}
		}

		/// <summary>Получает количество элементов, содержащихся в объекте <see cref="T:System.Collections.SortedList" />.</summary>
		/// <returns>Количество элементов, содержащихся в объекте <see cref="T:System.Collections.SortedList" />.</returns>
		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x06005C4F RID: 23631 RVA: 0x001368D9 File Offset: 0x00134AD9
		public virtual int Count
		{
			get
			{
				return this._size;
			}
		}

		/// <summary>Получает ключи из объекта <see cref="T:System.Collections.SortedList" />.</summary>
		/// <returns>Объект <see cref="T:System.Collections.ICollection" />, содержащий ключи из объекта <see cref="T:System.Collections.SortedList" />.</returns>
		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x06005C50 RID: 23632 RVA: 0x001368E1 File Offset: 0x00134AE1
		public virtual ICollection Keys
		{
			get
			{
				return this.GetKeyList();
			}
		}

		/// <summary>Получает значения из объекта <see cref="T:System.Collections.SortedList" />.</summary>
		/// <returns>Объект <see cref="T:System.Collections.ICollection" />, содержащий значения из объекта <see cref="T:System.Collections.SortedList" />.</returns>
		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x06005C51 RID: 23633 RVA: 0x001368E9 File Offset: 0x00134AE9
		public virtual ICollection Values
		{
			get
			{
				return this.GetValueList();
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли объект <see cref="T:System.Collections.SortedList" /> доступным только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Collections.SortedList" /> доступен только для чтения; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x06005C52 RID: 23634 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает значение, показывающее, имеет ли объект <see cref="T:System.Collections.SortedList" /> фиксированный размер.</summary>
		/// <returns>
		///   <see langword="true" />, если объект <see cref="T:System.Collections.SortedList" /> имеет фиксированный размер, в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x06005C53 RID: 23635 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает значение, указывающее на то, является ли доступ к объекту <see cref="T:System.Collections.SortedList" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>Значение <see langword="true" />, если доступ к объекту <see cref="T:System.Collections.SortedList" /> является синхронизированным (потокобезопасным); в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x06005C54 RID: 23636 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает объект, который позволяет синхронизировать доступ к объекту <see cref="T:System.Collections.SortedList" />.</summary>
		/// <returns>Объект, который позволяет синхронизировать доступ к объекту <see cref="T:System.Collections.SortedList" />.</returns>
		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x06005C55 RID: 23637 RVA: 0x001368F1 File Offset: 0x00134AF1
		public virtual object SyncRoot
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

		/// <summary>Удаляет все элементы из объекта <see cref="T:System.Collections.SortedList" />.</summary>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.SortedList" /> доступен только для чтения.  
		/// -или- 
		/// <see cref="T:System.Collections.SortedList" /> имеет фиксированный размер.</exception>
		// Token: 0x06005C56 RID: 23638 RVA: 0x00136913 File Offset: 0x00134B13
		public virtual void Clear()
		{
			this.version++;
			Array.Clear(this.keys, 0, this._size);
			Array.Clear(this.values, 0, this._size);
			this._size = 0;
		}

		/// <summary>Создает неполную копию объекта <see cref="T:System.Collections.SortedList" />.</summary>
		/// <returns>Неполная копия объекта <see cref="T:System.Collections.SortedList" />.</returns>
		// Token: 0x06005C57 RID: 23639 RVA: 0x00136950 File Offset: 0x00134B50
		public virtual object Clone()
		{
			SortedList sortedList = new SortedList(this._size);
			Array.Copy(this.keys, 0, sortedList.keys, 0, this._size);
			Array.Copy(this.values, 0, sortedList.values, 0, this._size);
			sortedList._size = this._size;
			sortedList.version = this.version;
			sortedList.comparer = this.comparer;
			return sortedList;
		}

		/// <summary>Определяет, содержит ли объект <see cref="T:System.Collections.SortedList" /> указанный ключ.</summary>
		/// <param name="key">Ключ для размещения в объекте <see cref="T:System.Collections.SortedList" />.</param>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Collections.SortedList" /> содержит элемент с указанным значением параметра <paramref name="key" />; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Средство сравнения выдает исключение.</exception>
		// Token: 0x06005C58 RID: 23640 RVA: 0x001369C0 File Offset: 0x00134BC0
		public virtual bool Contains(object key)
		{
			return this.IndexOfKey(key) >= 0;
		}

		/// <summary>Определяет, содержит ли объект <see cref="T:System.Collections.SortedList" /> указанный ключ.</summary>
		/// <param name="key">Ключ для размещения в объекте <see cref="T:System.Collections.SortedList" />.</param>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Collections.SortedList" /> содержит элемент с указанным значением параметра <paramref name="key" />; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Средство сравнения выдает исключение.</exception>
		// Token: 0x06005C59 RID: 23641 RVA: 0x001369C0 File Offset: 0x00134BC0
		public virtual bool ContainsKey(object key)
		{
			return this.IndexOfKey(key) >= 0;
		}

		/// <summary>Определяет, содержит ли объект <see cref="T:System.Collections.SortedList" /> указанное значение.</summary>
		/// <param name="value">Значение, которое требуется найти в объекте <see cref="T:System.Collections.SortedList" />. Допускается значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Collections.SortedList" /> содержит элемент с указанным значением параметра <paramref name="value" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06005C5A RID: 23642 RVA: 0x001369CF File Offset: 0x00134BCF
		public virtual bool ContainsValue(object value)
		{
			return this.IndexOfValue(value) >= 0;
		}

		/// <summary>Копирует элементы объекта <see cref="T:System.Collections.SortedList" /> в одномерный объект <see cref="T:System.Array" /> начиная с указанного значения индекса массива.</summary>
		/// <param name="array">Одномерный объект <see cref="T:System.Array" />, который является конечным объектом для объектов <see cref="T:System.Collections.DictionaryEntry" />, копируемых из объекта <see cref="T:System.Collections.SortedList" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="arrayIndex">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="arrayIndex" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		/// -или- 
		/// Количество элементов в исходном объекте <see cref="T:System.Collections.SortedList" /> превышает размер доступного места, начиная с индекса массива <paramref name="arrayIndex" /> и до конца массива назначения <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Тип исходного массива <see cref="T:System.Collections.SortedList" /> не может быть автоматически приведен к типу массива назначения <paramref name="array" />.</exception>
		// Token: 0x06005C5B RID: 23643 RVA: 0x001369E0 File Offset: 0x00134BE0
		public virtual void CopyTo(Array array, int arrayIndex)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array", "Array cannot be null.");
			}
			if (array.Rank != 1)
			{
				throw new ArgumentException("Only single dimensional arrays are supported for the requested action.", "array");
			}
			if (arrayIndex < 0)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", "Non-negative number required.");
			}
			if (array.Length - arrayIndex < this.Count)
			{
				throw new ArgumentException("Destination array is not long enough to copy all the items in the collection. Check array index and length.");
			}
			for (int i = 0; i < this.Count; i++)
			{
				DictionaryEntry dictionaryEntry = new DictionaryEntry(this.keys[i], this.values[i]);
				array.SetValue(dictionaryEntry, i + arrayIndex);
			}
		}

		// Token: 0x06005C5C RID: 23644 RVA: 0x00136A80 File Offset: 0x00134C80
		internal virtual KeyValuePairs[] ToKeyValuePairsArray()
		{
			KeyValuePairs[] array = new KeyValuePairs[this.Count];
			for (int i = 0; i < this.Count; i++)
			{
				array[i] = new KeyValuePairs(this.keys[i], this.values[i]);
			}
			return array;
		}

		// Token: 0x06005C5D RID: 23645 RVA: 0x00136AC4 File Offset: 0x00134CC4
		private void EnsureCapacity(int min)
		{
			int num = (this.keys.Length == 0) ? 16 : (this.keys.Length * 2);
			if (num > 2146435071)
			{
				num = 2146435071;
			}
			if (num < min)
			{
				num = min;
			}
			this.Capacity = num;
		}

		/// <summary>Получает значение с указанным индексом из объекта <see cref="T:System.Collections.SortedList" />.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс значения, которое нужно получить.</param>
		/// <returns>Возвращает значение по указанному индексу в классе <see cref="T:System.Collections.SortedList" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="index" /> находится вне диапазона допустимых индексов объекта <see cref="T:System.Collections.SortedList" />.</exception>
		// Token: 0x06005C5E RID: 23646 RVA: 0x00136B04 File Offset: 0x00134D04
		public virtual object GetByIndex(int index)
		{
			if (index < 0 || index >= this.Count)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			return this.values[index];
		}

		/// <summary>Возвращает объект <see cref="T:System.Collections.IEnumerator" />, осуществляющий перебор <see cref="T:System.Collections.SortedList" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IEnumerator" /> для <see cref="T:System.Collections.SortedList" />.</returns>
		// Token: 0x06005C5F RID: 23647 RVA: 0x00136B2B File Offset: 0x00134D2B
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SortedList.SortedListEnumerator(this, 0, this._size, 3);
		}

		/// <summary>Возвращает объект <see cref="T:System.Collections.IDictionaryEnumerator" />, осуществляющий перебор элементов объекта <see cref="T:System.Collections.SortedList" />.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IDictionaryEnumerator" /> для объекта <see cref="T:System.Collections.SortedList" />.</returns>
		// Token: 0x06005C60 RID: 23648 RVA: 0x00136B2B File Offset: 0x00134D2B
		public virtual IDictionaryEnumerator GetEnumerator()
		{
			return new SortedList.SortedListEnumerator(this, 0, this._size, 3);
		}

		/// <summary>Получает ключ с указанным индексом из объекта <see cref="T:System.Collections.SortedList" />.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс получаемого ключа.</param>
		/// <returns>Ключ с указанным значением индекса из объекта<see cref="T:System.Collections.SortedList" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="index" /> находится вне диапазона допустимых индексов объекта <see cref="T:System.Collections.SortedList" />.</exception>
		// Token: 0x06005C61 RID: 23649 RVA: 0x00136B3B File Offset: 0x00134D3B
		public virtual object GetKey(int index)
		{
			if (index < 0 || index >= this.Count)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			return this.keys[index];
		}

		/// <summary>Получает ключи из объекта <see cref="T:System.Collections.SortedList" />.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IList" />, содержащий ключи из объекта <see cref="T:System.Collections.SortedList" />.</returns>
		// Token: 0x06005C62 RID: 23650 RVA: 0x00136B62 File Offset: 0x00134D62
		public virtual IList GetKeyList()
		{
			if (this.keyList == null)
			{
				this.keyList = new SortedList.KeyList(this);
			}
			return this.keyList;
		}

		/// <summary>Получает значения из объекта <see cref="T:System.Collections.SortedList" />.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IList" />, содержащий значения из объекта <see cref="T:System.Collections.SortedList" />.</returns>
		// Token: 0x06005C63 RID: 23651 RVA: 0x00136B7E File Offset: 0x00134D7E
		public virtual IList GetValueList()
		{
			if (this.valueList == null)
			{
				this.valueList = new SortedList.ValueList(this);
			}
			return this.valueList;
		}

		/// <summary>Получает или задает значение, связанное с указанным ключом в объекте <see cref="T:System.Collections.SortedList" />.</summary>
		/// <param name="key">Ключ, связанный с задаваемым или возвращаемым значением.</param>
		/// <returns>Значение, связанное с параметром <paramref name="key" /> в объекте <see cref="T:System.Collections.SortedList" />, если ключ <paramref name="key" /> найден; в противном случае — значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Свойство задано, и объект <see cref="T:System.Collections.SortedList" /> доступен только для чтения.  
		/// -или- 
		/// Свойство задано, <paramref name="key" /> не существует в коллекции, а <see cref="T:System.Collections.SortedList" /> имеет фиксированный размер.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Недостаточно свободной памяти для добавления элемента в объект <see cref="T:System.Collections.SortedList" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Средство сравнения выдает исключение.</exception>
		// Token: 0x1700100B RID: 4107
		public virtual object this[object key]
		{
			get
			{
				int num = this.IndexOfKey(key);
				if (num >= 0)
				{
					return this.values[num];
				}
				return null;
			}
			set
			{
				if (key == null)
				{
					throw new ArgumentNullException("key", "Key cannot be null.");
				}
				int num = Array.BinarySearch(this.keys, 0, this._size, key, this.comparer);
				if (num >= 0)
				{
					this.values[num] = value;
					this.version++;
					return;
				}
				this.Insert(~num, key, value);
			}
		}

		/// <summary>Возвращает индекс (с нуля) указанного ключа в объекте <see cref="T:System.Collections.SortedList" />.</summary>
		/// <param name="key">Ключ для размещения в объекте <see cref="T:System.Collections.SortedList" />.</param>
		/// <returns>Индекс (с нуля) параметра <paramref name="key" />, если параметр <paramref name="key" /> найден в объекте <see cref="T:System.Collections.SortedList" />; в противном случае — значение -1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Средство сравнения выдает исключение.</exception>
		// Token: 0x06005C66 RID: 23654 RVA: 0x00136C20 File Offset: 0x00134E20
		public virtual int IndexOfKey(object key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key", "Key cannot be null.");
			}
			int num = Array.BinarySearch(this.keys, 0, this._size, key, this.comparer);
			if (num < 0)
			{
				return -1;
			}
			return num;
		}

		/// <summary>Индекс (с нуля) первого вхождения указанного значения в объекте <see cref="T:System.Collections.SortedList" />.</summary>
		/// <param name="value">Значение, которое требуется найти в объекте <see cref="T:System.Collections.SortedList" />. Допускается значение <see langword="null" />.</param>
		/// <returns>Индекс (с нуля) первого вхождения значения параметра <paramref name="value" />, если значение <paramref name="value" /> найдено в объекте <see cref="T:System.Collections.SortedList" />; в противном случае — значение -1.</returns>
		// Token: 0x06005C67 RID: 23655 RVA: 0x00136C61 File Offset: 0x00134E61
		public virtual int IndexOfValue(object value)
		{
			return Array.IndexOf<object>(this.values, value, 0, this._size);
		}

		// Token: 0x06005C68 RID: 23656 RVA: 0x00136C78 File Offset: 0x00134E78
		private void Insert(int index, object key, object value)
		{
			if (this._size == this.keys.Length)
			{
				this.EnsureCapacity(this._size + 1);
			}
			if (index < this._size)
			{
				Array.Copy(this.keys, index, this.keys, index + 1, this._size - index);
				Array.Copy(this.values, index, this.values, index + 1, this._size - index);
			}
			this.keys[index] = key;
			this.values[index] = value;
			this._size++;
			this.version++;
		}

		/// <summary>Удаляет элемент с указанным индексом из объекта <see cref="T:System.Collections.SortedList" />.</summary>
		/// <param name="index">Индекс (с нуля) элемента, который требуется удалить.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="index" /> находится вне диапазона допустимых индексов объекта <see cref="T:System.Collections.SortedList" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.SortedList" /> доступен только для чтения.  
		/// -или- 
		/// <see cref="T:System.Collections.SortedList" /> имеет фиксированный размер.</exception>
		// Token: 0x06005C69 RID: 23657 RVA: 0x00136D14 File Offset: 0x00134F14
		public virtual void RemoveAt(int index)
		{
			if (index < 0 || index >= this.Count)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			this._size--;
			if (index < this._size)
			{
				Array.Copy(this.keys, index + 1, this.keys, index, this._size - index);
				Array.Copy(this.values, index + 1, this.values, index, this._size - index);
			}
			this.keys[this._size] = null;
			this.values[this._size] = null;
			this.version++;
		}

		/// <summary>Удаляет элемент с указанным ключом из объекта <see cref="T:System.Collections.SortedList" />.</summary>
		/// <param name="key">Ключ элемента, который требуется удалить.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.SortedList" /> доступен только для чтения.  
		/// -или- 
		/// <see cref="T:System.Collections.SortedList" /> имеет фиксированный размер.</exception>
		// Token: 0x06005C6A RID: 23658 RVA: 0x00136DBC File Offset: 0x00134FBC
		public virtual void Remove(object key)
		{
			int num = this.IndexOfKey(key);
			if (num >= 0)
			{
				this.RemoveAt(num);
			}
		}

		/// <summary>Заменяет значение по указанному индексу в объекте <see cref="T:System.Collections.SortedList" />.</summary>
		/// <param name="index">Индекс (с нуля) сохраняемого параметра <paramref name="value" />.</param>
		/// <param name="value">Объект <see cref="T:System.Object" />, сохраняемый в объекте <see cref="T:System.Collections.SortedList" />. Допускается значение <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение <paramref name="index" /> находится вне диапазона допустимых индексов объекта <see cref="T:System.Collections.SortedList" />.</exception>
		// Token: 0x06005C6B RID: 23659 RVA: 0x00136DDC File Offset: 0x00134FDC
		public virtual void SetByIndex(int index, object value)
		{
			if (index < 0 || index >= this.Count)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			this.values[index] = value;
			this.version++;
		}

		/// <summary>Возвращает синхронизированную (потокобезопасную) оболочку объекта <see cref="T:System.Collections.SortedList" />.</summary>
		/// <param name="list">Синхронизируемый объект <see cref="T:System.Collections.SortedList" />.</param>
		/// <returns>Синхронизированная (потокобезопасная) оболочка объекта <see cref="T:System.Collections.SortedList" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="list" /> — <see langword="null" />.</exception>
		// Token: 0x06005C6C RID: 23660 RVA: 0x00136E12 File Offset: 0x00135012
		public static SortedList Synchronized(SortedList list)
		{
			if (list == null)
			{
				throw new ArgumentNullException("list");
			}
			return new SortedList.SyncSortedList(list);
		}

		/// <summary>Задает значение емкости, равное действительному количеству элементов в объекте <see cref="T:System.Collections.SortedList" />.</summary>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.SortedList" /> доступен только для чтения.  
		/// -или- 
		/// <see cref="T:System.Collections.SortedList" /> имеет фиксированный размер.</exception>
		// Token: 0x06005C6D RID: 23661 RVA: 0x00136E28 File Offset: 0x00135028
		public virtual void TrimToSize()
		{
			this.Capacity = this._size;
		}

		// Token: 0x0400389B RID: 14491
		private object[] keys;

		// Token: 0x0400389C RID: 14492
		private object[] values;

		// Token: 0x0400389D RID: 14493
		private int _size;

		// Token: 0x0400389E RID: 14494
		private int version;

		// Token: 0x0400389F RID: 14495
		private IComparer comparer;

		// Token: 0x040038A0 RID: 14496
		private SortedList.KeyList keyList;

		// Token: 0x040038A1 RID: 14497
		private SortedList.ValueList valueList;

		// Token: 0x040038A2 RID: 14498
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x040038A3 RID: 14499
		private const int _defaultCapacity = 16;

		// Token: 0x040038A4 RID: 14500
		internal const int MaxArrayLength = 2146435071;

		// Token: 0x02000A2D RID: 2605
		[Serializable]
		private class SyncSortedList : SortedList
		{
			// Token: 0x06005C6E RID: 23662 RVA: 0x00136E36 File Offset: 0x00135036
			internal SyncSortedList(SortedList list)
			{
				this._list = list;
				this._root = list.SyncRoot;
			}

			// Token: 0x1700100C RID: 4108
			// (get) Token: 0x06005C6F RID: 23663 RVA: 0x00136E54 File Offset: 0x00135054
			public override int Count
			{
				get
				{
					object root = this._root;
					int count;
					lock (root)
					{
						count = this._list.Count;
					}
					return count;
				}
			}

			// Token: 0x1700100D RID: 4109
			// (get) Token: 0x06005C70 RID: 23664 RVA: 0x00136E9C File Offset: 0x0013509C
			public override object SyncRoot
			{
				get
				{
					return this._root;
				}
			}

			// Token: 0x1700100E RID: 4110
			// (get) Token: 0x06005C71 RID: 23665 RVA: 0x00136EA4 File Offset: 0x001350A4
			public override bool IsReadOnly
			{
				get
				{
					return this._list.IsReadOnly;
				}
			}

			// Token: 0x1700100F RID: 4111
			// (get) Token: 0x06005C72 RID: 23666 RVA: 0x00136EB1 File Offset: 0x001350B1
			public override bool IsFixedSize
			{
				get
				{
					return this._list.IsFixedSize;
				}
			}

			// Token: 0x17001010 RID: 4112
			// (get) Token: 0x06005C73 RID: 23667 RVA: 0x000040F7 File Offset: 0x000022F7
			public override bool IsSynchronized
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17001011 RID: 4113
			public override object this[object key]
			{
				get
				{
					object root = this._root;
					object result;
					lock (root)
					{
						result = this._list[key];
					}
					return result;
				}
				set
				{
					object root = this._root;
					lock (root)
					{
						this._list[key] = value;
					}
				}
			}

			// Token: 0x06005C76 RID: 23670 RVA: 0x00136F50 File Offset: 0x00135150
			public override void Add(object key, object value)
			{
				object root = this._root;
				lock (root)
				{
					this._list.Add(key, value);
				}
			}

			// Token: 0x17001012 RID: 4114
			// (get) Token: 0x06005C77 RID: 23671 RVA: 0x00136F98 File Offset: 0x00135198
			public override int Capacity
			{
				get
				{
					object root = this._root;
					int capacity;
					lock (root)
					{
						capacity = this._list.Capacity;
					}
					return capacity;
				}
			}

			// Token: 0x06005C78 RID: 23672 RVA: 0x00136FE0 File Offset: 0x001351E0
			public override void Clear()
			{
				object root = this._root;
				lock (root)
				{
					this._list.Clear();
				}
			}

			// Token: 0x06005C79 RID: 23673 RVA: 0x00137028 File Offset: 0x00135228
			public override object Clone()
			{
				object root = this._root;
				object result;
				lock (root)
				{
					result = this._list.Clone();
				}
				return result;
			}

			// Token: 0x06005C7A RID: 23674 RVA: 0x00137070 File Offset: 0x00135270
			public override bool Contains(object key)
			{
				object root = this._root;
				bool result;
				lock (root)
				{
					result = this._list.Contains(key);
				}
				return result;
			}

			// Token: 0x06005C7B RID: 23675 RVA: 0x001370B8 File Offset: 0x001352B8
			public override bool ContainsKey(object key)
			{
				object root = this._root;
				bool result;
				lock (root)
				{
					result = this._list.ContainsKey(key);
				}
				return result;
			}

			// Token: 0x06005C7C RID: 23676 RVA: 0x00137100 File Offset: 0x00135300
			public override bool ContainsValue(object key)
			{
				object root = this._root;
				bool result;
				lock (root)
				{
					result = this._list.ContainsValue(key);
				}
				return result;
			}

			// Token: 0x06005C7D RID: 23677 RVA: 0x00137148 File Offset: 0x00135348
			public override void CopyTo(Array array, int index)
			{
				object root = this._root;
				lock (root)
				{
					this._list.CopyTo(array, index);
				}
			}

			// Token: 0x06005C7E RID: 23678 RVA: 0x00137190 File Offset: 0x00135390
			public override object GetByIndex(int index)
			{
				object root = this._root;
				object byIndex;
				lock (root)
				{
					byIndex = this._list.GetByIndex(index);
				}
				return byIndex;
			}

			// Token: 0x06005C7F RID: 23679 RVA: 0x001371D8 File Offset: 0x001353D8
			public override IDictionaryEnumerator GetEnumerator()
			{
				object root = this._root;
				IDictionaryEnumerator enumerator;
				lock (root)
				{
					enumerator = this._list.GetEnumerator();
				}
				return enumerator;
			}

			// Token: 0x06005C80 RID: 23680 RVA: 0x00137220 File Offset: 0x00135420
			public override object GetKey(int index)
			{
				object root = this._root;
				object key;
				lock (root)
				{
					key = this._list.GetKey(index);
				}
				return key;
			}

			// Token: 0x06005C81 RID: 23681 RVA: 0x00137268 File Offset: 0x00135468
			public override IList GetKeyList()
			{
				object root = this._root;
				IList keyList;
				lock (root)
				{
					keyList = this._list.GetKeyList();
				}
				return keyList;
			}

			// Token: 0x06005C82 RID: 23682 RVA: 0x001372B0 File Offset: 0x001354B0
			public override IList GetValueList()
			{
				object root = this._root;
				IList valueList;
				lock (root)
				{
					valueList = this._list.GetValueList();
				}
				return valueList;
			}

			// Token: 0x06005C83 RID: 23683 RVA: 0x001372F8 File Offset: 0x001354F8
			public override int IndexOfKey(object key)
			{
				if (key == null)
				{
					throw new ArgumentNullException("key", "Key cannot be null.");
				}
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.IndexOfKey(key);
				}
				return result;
			}

			// Token: 0x06005C84 RID: 23684 RVA: 0x00137354 File Offset: 0x00135554
			public override int IndexOfValue(object value)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.IndexOfValue(value);
				}
				return result;
			}

			// Token: 0x06005C85 RID: 23685 RVA: 0x0013739C File Offset: 0x0013559C
			public override void RemoveAt(int index)
			{
				object root = this._root;
				lock (root)
				{
					this._list.RemoveAt(index);
				}
			}

			// Token: 0x06005C86 RID: 23686 RVA: 0x001373E4 File Offset: 0x001355E4
			public override void Remove(object key)
			{
				object root = this._root;
				lock (root)
				{
					this._list.Remove(key);
				}
			}

			// Token: 0x06005C87 RID: 23687 RVA: 0x0013742C File Offset: 0x0013562C
			public override void SetByIndex(int index, object value)
			{
				object root = this._root;
				lock (root)
				{
					this._list.SetByIndex(index, value);
				}
			}

			// Token: 0x06005C88 RID: 23688 RVA: 0x00137474 File Offset: 0x00135674
			internal override KeyValuePairs[] ToKeyValuePairsArray()
			{
				return this._list.ToKeyValuePairsArray();
			}

			// Token: 0x06005C89 RID: 23689 RVA: 0x00137484 File Offset: 0x00135684
			public override void TrimToSize()
			{
				object root = this._root;
				lock (root)
				{
					this._list.TrimToSize();
				}
			}

			// Token: 0x040038A5 RID: 14501
			private SortedList _list;

			// Token: 0x040038A6 RID: 14502
			private object _root;
		}

		// Token: 0x02000A2E RID: 2606
		[Serializable]
		private class SortedListEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable
		{
			// Token: 0x06005C8A RID: 23690 RVA: 0x001374CC File Offset: 0x001356CC
			internal SortedListEnumerator(SortedList sortedList, int index, int count, int getObjRetType)
			{
				this._sortedList = sortedList;
				this._index = index;
				this._startIndex = index;
				this._endIndex = index + count;
				this._version = sortedList.version;
				this._getObjectRetType = getObjRetType;
				this._current = false;
			}

			// Token: 0x06005C8B RID: 23691 RVA: 0x000231CD File Offset: 0x000213CD
			public object Clone()
			{
				return base.MemberwiseClone();
			}

			// Token: 0x17001013 RID: 4115
			// (get) Token: 0x06005C8C RID: 23692 RVA: 0x00137518 File Offset: 0x00135718
			public virtual object Key
			{
				get
				{
					if (this._version != this._sortedList.version)
					{
						throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
					}
					if (!this._current)
					{
						throw new InvalidOperationException("Enumeration has either not started or has already finished.");
					}
					return this._key;
				}
			}

			// Token: 0x06005C8D RID: 23693 RVA: 0x00137554 File Offset: 0x00135754
			public virtual bool MoveNext()
			{
				if (this._version != this._sortedList.version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				if (this._index < this._endIndex)
				{
					this._key = this._sortedList.keys[this._index];
					this._value = this._sortedList.values[this._index];
					this._index++;
					this._current = true;
					return true;
				}
				this._key = null;
				this._value = null;
				this._current = false;
				return false;
			}

			// Token: 0x17001014 RID: 4116
			// (get) Token: 0x06005C8E RID: 23694 RVA: 0x001375EC File Offset: 0x001357EC
			public virtual DictionaryEntry Entry
			{
				get
				{
					if (this._version != this._sortedList.version)
					{
						throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
					}
					if (!this._current)
					{
						throw new InvalidOperationException("Enumeration has either not started or has already finished.");
					}
					return new DictionaryEntry(this._key, this._value);
				}
			}

			// Token: 0x17001015 RID: 4117
			// (get) Token: 0x06005C8F RID: 23695 RVA: 0x0013763C File Offset: 0x0013583C
			public virtual object Current
			{
				get
				{
					if (!this._current)
					{
						throw new InvalidOperationException("Enumeration has either not started or has already finished.");
					}
					if (this._getObjectRetType == 1)
					{
						return this._key;
					}
					if (this._getObjectRetType == 2)
					{
						return this._value;
					}
					return new DictionaryEntry(this._key, this._value);
				}
			}

			// Token: 0x17001016 RID: 4118
			// (get) Token: 0x06005C90 RID: 23696 RVA: 0x00137692 File Offset: 0x00135892
			public virtual object Value
			{
				get
				{
					if (this._version != this._sortedList.version)
					{
						throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
					}
					if (!this._current)
					{
						throw new InvalidOperationException("Enumeration has either not started or has already finished.");
					}
					return this._value;
				}
			}

			// Token: 0x06005C91 RID: 23697 RVA: 0x001376CC File Offset: 0x001358CC
			public virtual void Reset()
			{
				if (this._version != this._sortedList.version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				this._index = this._startIndex;
				this._current = false;
				this._key = null;
				this._value = null;
			}

			// Token: 0x040038A7 RID: 14503
			private SortedList _sortedList;

			// Token: 0x040038A8 RID: 14504
			private object _key;

			// Token: 0x040038A9 RID: 14505
			private object _value;

			// Token: 0x040038AA RID: 14506
			private int _index;

			// Token: 0x040038AB RID: 14507
			private int _startIndex;

			// Token: 0x040038AC RID: 14508
			private int _endIndex;

			// Token: 0x040038AD RID: 14509
			private int _version;

			// Token: 0x040038AE RID: 14510
			private bool _current;

			// Token: 0x040038AF RID: 14511
			private int _getObjectRetType;

			// Token: 0x040038B0 RID: 14512
			internal const int Keys = 1;

			// Token: 0x040038B1 RID: 14513
			internal const int Values = 2;

			// Token: 0x040038B2 RID: 14514
			internal const int DictEntry = 3;
		}

		// Token: 0x02000A2F RID: 2607
		[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
		[Serializable]
		private class KeyList : IList, ICollection, IEnumerable
		{
			// Token: 0x06005C92 RID: 23698 RVA: 0x00137718 File Offset: 0x00135918
			internal KeyList(SortedList sortedList)
			{
				this.sortedList = sortedList;
			}

			// Token: 0x17001017 RID: 4119
			// (get) Token: 0x06005C93 RID: 23699 RVA: 0x00137727 File Offset: 0x00135927
			public virtual int Count
			{
				get
				{
					return this.sortedList._size;
				}
			}

			// Token: 0x17001018 RID: 4120
			// (get) Token: 0x06005C94 RID: 23700 RVA: 0x000040F7 File Offset: 0x000022F7
			public virtual bool IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17001019 RID: 4121
			// (get) Token: 0x06005C95 RID: 23701 RVA: 0x000040F7 File Offset: 0x000022F7
			public virtual bool IsFixedSize
			{
				get
				{
					return true;
				}
			}

			// Token: 0x1700101A RID: 4122
			// (get) Token: 0x06005C96 RID: 23702 RVA: 0x00137734 File Offset: 0x00135934
			public virtual bool IsSynchronized
			{
				get
				{
					return this.sortedList.IsSynchronized;
				}
			}

			// Token: 0x1700101B RID: 4123
			// (get) Token: 0x06005C97 RID: 23703 RVA: 0x00137741 File Offset: 0x00135941
			public virtual object SyncRoot
			{
				get
				{
					return this.sortedList.SyncRoot;
				}
			}

			// Token: 0x06005C98 RID: 23704 RVA: 0x0013774E File Offset: 0x0013594E
			public virtual int Add(object key)
			{
				throw new NotSupportedException("This operation is not supported on SortedList nested types because they require modifying the original SortedList.");
			}

			// Token: 0x06005C99 RID: 23705 RVA: 0x0013774E File Offset: 0x0013594E
			public virtual void Clear()
			{
				throw new NotSupportedException("This operation is not supported on SortedList nested types because they require modifying the original SortedList.");
			}

			// Token: 0x06005C9A RID: 23706 RVA: 0x0013775A File Offset: 0x0013595A
			public virtual bool Contains(object key)
			{
				return this.sortedList.Contains(key);
			}

			// Token: 0x06005C9B RID: 23707 RVA: 0x00137768 File Offset: 0x00135968
			public virtual void CopyTo(Array array, int arrayIndex)
			{
				if (array != null && array.Rank != 1)
				{
					throw new ArgumentException("Only single dimensional arrays are supported for the requested action.", "array");
				}
				Array.Copy(this.sortedList.keys, 0, array, arrayIndex, this.sortedList.Count);
			}

			// Token: 0x06005C9C RID: 23708 RVA: 0x0013774E File Offset: 0x0013594E
			public virtual void Insert(int index, object value)
			{
				throw new NotSupportedException("This operation is not supported on SortedList nested types because they require modifying the original SortedList.");
			}

			// Token: 0x1700101C RID: 4124
			public virtual object this[int index]
			{
				get
				{
					return this.sortedList.GetKey(index);
				}
				set
				{
					throw new NotSupportedException("Mutating a key collection derived from a dictionary is not allowed.");
				}
			}

			// Token: 0x06005C9F RID: 23711 RVA: 0x001377BE File Offset: 0x001359BE
			public virtual IEnumerator GetEnumerator()
			{
				return new SortedList.SortedListEnumerator(this.sortedList, 0, this.sortedList.Count, 1);
			}

			// Token: 0x06005CA0 RID: 23712 RVA: 0x001377D8 File Offset: 0x001359D8
			public virtual int IndexOf(object key)
			{
				if (key == null)
				{
					throw new ArgumentNullException("key", "Key cannot be null.");
				}
				int num = Array.BinarySearch(this.sortedList.keys, 0, this.sortedList.Count, key, this.sortedList.comparer);
				if (num >= 0)
				{
					return num;
				}
				return -1;
			}

			// Token: 0x06005CA1 RID: 23713 RVA: 0x0013774E File Offset: 0x0013594E
			public virtual void Remove(object key)
			{
				throw new NotSupportedException("This operation is not supported on SortedList nested types because they require modifying the original SortedList.");
			}

			// Token: 0x06005CA2 RID: 23714 RVA: 0x0013774E File Offset: 0x0013594E
			public virtual void RemoveAt(int index)
			{
				throw new NotSupportedException("This operation is not supported on SortedList nested types because they require modifying the original SortedList.");
			}

			// Token: 0x040038B3 RID: 14515
			private SortedList sortedList;
		}

		// Token: 0x02000A30 RID: 2608
		[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
		[Serializable]
		private class ValueList : IList, ICollection, IEnumerable
		{
			// Token: 0x06005CA3 RID: 23715 RVA: 0x00137828 File Offset: 0x00135A28
			internal ValueList(SortedList sortedList)
			{
				this.sortedList = sortedList;
			}

			// Token: 0x1700101D RID: 4125
			// (get) Token: 0x06005CA4 RID: 23716 RVA: 0x00137837 File Offset: 0x00135A37
			public virtual int Count
			{
				get
				{
					return this.sortedList._size;
				}
			}

			// Token: 0x1700101E RID: 4126
			// (get) Token: 0x06005CA5 RID: 23717 RVA: 0x000040F7 File Offset: 0x000022F7
			public virtual bool IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x1700101F RID: 4127
			// (get) Token: 0x06005CA6 RID: 23718 RVA: 0x000040F7 File Offset: 0x000022F7
			public virtual bool IsFixedSize
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17001020 RID: 4128
			// (get) Token: 0x06005CA7 RID: 23719 RVA: 0x00137844 File Offset: 0x00135A44
			public virtual bool IsSynchronized
			{
				get
				{
					return this.sortedList.IsSynchronized;
				}
			}

			// Token: 0x17001021 RID: 4129
			// (get) Token: 0x06005CA8 RID: 23720 RVA: 0x00137851 File Offset: 0x00135A51
			public virtual object SyncRoot
			{
				get
				{
					return this.sortedList.SyncRoot;
				}
			}

			// Token: 0x06005CA9 RID: 23721 RVA: 0x0013774E File Offset: 0x0013594E
			public virtual int Add(object key)
			{
				throw new NotSupportedException("This operation is not supported on SortedList nested types because they require modifying the original SortedList.");
			}

			// Token: 0x06005CAA RID: 23722 RVA: 0x0013774E File Offset: 0x0013594E
			public virtual void Clear()
			{
				throw new NotSupportedException("This operation is not supported on SortedList nested types because they require modifying the original SortedList.");
			}

			// Token: 0x06005CAB RID: 23723 RVA: 0x0013785E File Offset: 0x00135A5E
			public virtual bool Contains(object value)
			{
				return this.sortedList.ContainsValue(value);
			}

			// Token: 0x06005CAC RID: 23724 RVA: 0x0013786C File Offset: 0x00135A6C
			public virtual void CopyTo(Array array, int arrayIndex)
			{
				if (array != null && array.Rank != 1)
				{
					throw new ArgumentException("Only single dimensional arrays are supported for the requested action.", "array");
				}
				Array.Copy(this.sortedList.values, 0, array, arrayIndex, this.sortedList.Count);
			}

			// Token: 0x06005CAD RID: 23725 RVA: 0x0013774E File Offset: 0x0013594E
			public virtual void Insert(int index, object value)
			{
				throw new NotSupportedException("This operation is not supported on SortedList nested types because they require modifying the original SortedList.");
			}

			// Token: 0x17001022 RID: 4130
			public virtual object this[int index]
			{
				get
				{
					return this.sortedList.GetByIndex(index);
				}
				set
				{
					throw new NotSupportedException("This operation is not supported on SortedList nested types because they require modifying the original SortedList.");
				}
			}

			// Token: 0x06005CB0 RID: 23728 RVA: 0x001378B6 File Offset: 0x00135AB6
			public virtual IEnumerator GetEnumerator()
			{
				return new SortedList.SortedListEnumerator(this.sortedList, 0, this.sortedList.Count, 2);
			}

			// Token: 0x06005CB1 RID: 23729 RVA: 0x001378D0 File Offset: 0x00135AD0
			public virtual int IndexOf(object value)
			{
				return Array.IndexOf<object>(this.sortedList.values, value, 0, this.sortedList.Count);
			}

			// Token: 0x06005CB2 RID: 23730 RVA: 0x0013774E File Offset: 0x0013594E
			public virtual void Remove(object value)
			{
				throw new NotSupportedException("This operation is not supported on SortedList nested types because they require modifying the original SortedList.");
			}

			// Token: 0x06005CB3 RID: 23731 RVA: 0x0013774E File Offset: 0x0013594E
			public virtual void RemoveAt(int index)
			{
				throw new NotSupportedException("This operation is not supported on SortedList nested types because they require modifying the original SortedList.");
			}

			// Token: 0x040038B4 RID: 14516
			private SortedList sortedList;
		}

		// Token: 0x02000A31 RID: 2609
		internal class SortedListDebugView
		{
			// Token: 0x06005CB4 RID: 23732 RVA: 0x001378EF File Offset: 0x00135AEF
			public SortedListDebugView(SortedList sortedList)
			{
				if (sortedList == null)
				{
					throw new ArgumentNullException("sortedList");
				}
				this._sortedList = sortedList;
			}

			// Token: 0x17001023 RID: 4131
			// (get) Token: 0x06005CB5 RID: 23733 RVA: 0x0013790C File Offset: 0x00135B0C
			[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
			public KeyValuePairs[] Items
			{
				get
				{
					return this._sortedList.ToKeyValuePairsArray();
				}
			}

			// Token: 0x040038B5 RID: 14517
			private SortedList _sortedList;
		}
	}
}
