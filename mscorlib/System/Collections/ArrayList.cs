using System;
using System.Diagnostics;
using System.Threading;

namespace System.Collections
{
	/// <summary>Реализует интерфейс <see cref="T:System.Collections.IList" /> с помощью массива с динамическим изменением размера по требованию.</summary>
	// Token: 0x02000A3B RID: 2619
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(ArrayList.ArrayListDebugView))]
	[Serializable]
	public class ArrayList : IList, ICollection, IEnumerable, ICloneable
	{
		// Token: 0x06005D01 RID: 23809 RVA: 0x0000259F File Offset: 0x0000079F
		internal ArrayList(bool trash)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.ArrayList" />, который является пустым и имеет начальную емкость по умолчанию.</summary>
		// Token: 0x06005D02 RID: 23810 RVA: 0x00138E17 File Offset: 0x00137017
		public ArrayList()
		{
			this._items = Array.Empty<object>();
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.ArrayList" /> с указанной начальной емкостью.</summary>
		/// <param name="capacity">Число элементов, которые может изначально вместить новый список.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="capacity" /> меньше нуля.</exception>
		// Token: 0x06005D03 RID: 23811 RVA: 0x00138E2C File Offset: 0x0013702C
		public ArrayList(int capacity)
		{
			if (capacity < 0)
			{
				throw new ArgumentOutOfRangeException("capacity", SR.Format("'{0}' must be non-negative.", "capacity"));
			}
			if (capacity == 0)
			{
				this._items = Array.Empty<object>();
				return;
			}
			this._items = new object[capacity];
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.ArrayList" />, который содержит элементы, скопированные из указанной коллекции, и обладает начальной емкостью, равной количеству скопированных элементов.</summary>
		/// <param name="c">Интерфейс <see cref="T:System.Collections.ICollection" />, элементы которого копируются в новый список.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="c" /> — <see langword="null" />.</exception>
		// Token: 0x06005D04 RID: 23812 RVA: 0x00138E78 File Offset: 0x00137078
		public ArrayList(ICollection c)
		{
			if (c == null)
			{
				throw new ArgumentNullException("c", "Collection cannot be null.");
			}
			int count = c.Count;
			if (count == 0)
			{
				this._items = Array.Empty<object>();
				return;
			}
			this._items = new object[count];
			this.AddRange(c);
		}

		/// <summary>Возвращает или задает число элементов, которое может содержать список <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <returns>Количество элементов, которое может содержать коллекция <see cref="T:System.Collections.ArrayList" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Для <see cref="P:System.Collections.ArrayList.Capacity" /> установлено значение, которое меньше <see cref="P:System.Collections.ArrayList.Count" />.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти в системе.</exception>
		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x06005D05 RID: 23813 RVA: 0x00138EC7 File Offset: 0x001370C7
		// (set) Token: 0x06005D06 RID: 23814 RVA: 0x00138ED4 File Offset: 0x001370D4
		public virtual int Capacity
		{
			get
			{
				return this._items.Length;
			}
			set
			{
				if (value < this._size)
				{
					throw new ArgumentOutOfRangeException("value", "capacity was less than the current size.");
				}
				if (value != this._items.Length)
				{
					if (value > 0)
					{
						object[] array = new object[value];
						if (this._size > 0)
						{
							Array.Copy(this._items, 0, array, 0, this._size);
						}
						this._items = array;
						return;
					}
					this._items = new object[4];
				}
			}
		}

		/// <summary>Получает число элементов, фактически содержащихся в списке <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <returns>Число элементов, фактически содержащихся в списке <see cref="T:System.Collections.ArrayList" />.</returns>
		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x06005D07 RID: 23815 RVA: 0x00138F41 File Offset: 0x00137141
		public virtual int Count
		{
			get
			{
				return this._size;
			}
		}

		/// <summary>Получает значение, указывающее, имеет ли список <see cref="T:System.Collections.ArrayList" /> фиксированный размер.</summary>
		/// <returns>Значение <see langword="true" />, если словарь <see cref="T:System.Collections.ArrayList" /> имеет фиксированный размер; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x06005D08 RID: 23816 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает значение, указывающее, является ли объект <see cref="T:System.Collections.ArrayList" /> доступным только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если интерфейс <see cref="T:System.Collections.ArrayList" /> доступен только для чтения; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x06005D09 RID: 23817 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает значение, показывающее, является ли доступ к коллекции <see cref="T:System.Collections.ArrayList" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>
		///   <see langword="true" />, если доступ к классу <see cref="T:System.Collections.ArrayList" /> является синхронизированным (потокобезопасным); в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x06005D0A RID: 23818 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Collections.ArrayList" />.</returns>
		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x06005D0B RID: 23819 RVA: 0x00138F49 File Offset: 0x00137149
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

		/// <summary>Возвращает или задает элемент по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс элемента, который требуется возвратить или задать.</param>
		/// <returns>Элемент, расположенный по указанному индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="index" /> больше или равно значению свойства <see cref="P:System.Collections.ArrayList.Count" />.</exception>
		// Token: 0x1700103B RID: 4155
		public virtual object this[int index]
		{
			get
			{
				if (index < 0 || index >= this._size)
				{
					throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				return this._items[index];
			}
			set
			{
				if (index < 0 || index >= this._size)
				{
					throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				this._items[index] = value;
				this._version++;
			}
		}

		/// <summary>Создает оболочку класса <see cref="T:System.Collections.ArrayList" /> для указанного интерфейса <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="list">Класс <see cref="T:System.Collections.IList" />, для которого создается оболочка.</param>
		/// <returns>Оболочка <see cref="T:System.Collections.ArrayList" /> интерфейса <see cref="T:System.Collections.IList" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="list" /> — <see langword="null" />.</exception>
		// Token: 0x06005D0E RID: 23822 RVA: 0x00138FC8 File Offset: 0x001371C8
		public static ArrayList Adapter(IList list)
		{
			if (list == null)
			{
				throw new ArgumentNullException("list");
			}
			return new ArrayList.IListWrapper(list);
		}

		/// <summary>Добавляет объект в конец очереди <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, добавляемый в конец коллекции <see cref="T:System.Collections.ArrayList" />. Допускается значение <see langword="null" />.</param>
		/// <returns>Индекс <see cref="T:System.Collections.ArrayList" />, по которому добавлен параметр <paramref name="value" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.ArrayList" /> доступен только для чтения.  
		/// -или- 
		/// <see cref="T:System.Collections.ArrayList" /> имеет фиксированный размер.</exception>
		// Token: 0x06005D0F RID: 23823 RVA: 0x00138FE0 File Offset: 0x001371E0
		public virtual int Add(object value)
		{
			if (this._size == this._items.Length)
			{
				this.EnsureCapacity(this._size + 1);
			}
			this._items[this._size] = value;
			this._version++;
			int size = this._size;
			this._size = size + 1;
			return size;
		}

		/// <summary>Добавляет элементы интерфейса <see cref="T:System.Collections.ICollection" /> в конец списка <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <param name="c">Интерфейс <see cref="T:System.Collections.ICollection" />, элементы которого добавляются в конец списка <see cref="T:System.Collections.ArrayList" />. Сама коллекция не может иметь значение <see langword="null" />, но может содержать элементы со значением <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="c" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.ArrayList" /> доступен только для чтения.  
		/// -или- 
		/// <see cref="T:System.Collections.ArrayList" /> имеет фиксированный размер.</exception>
		// Token: 0x06005D10 RID: 23824 RVA: 0x00139038 File Offset: 0x00137238
		public virtual void AddRange(ICollection c)
		{
			this.InsertRange(this._size, c);
		}

		/// <summary>Выполняет поиск элемента в диапазоне элементов отсортированного списка <see cref="T:System.Collections.ArrayList" />, используя указанную функцию сравнения, и возвращает индекс элемента, отсчитываемый от нуля.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс начала диапазона поиска.</param>
		/// <param name="count">Длина диапазона поиска.</param>
		/// <param name="value">Искомый объект <see cref="T:System.Object" />. Допускается значение <see langword="null" />.</param>
		/// <param name="comparer">Реализация интерфейса <see cref="T:System.Collections.IComparer" />, которая используется при сравнении элементов.  
		/// -или- 
		///  Значение <see langword="null" />, чтобы использовать функцию сравнения по умолчанию, которая является реализацией <see cref="T:System.IComparable" /> для каждого элемента.</param>
		/// <returns>Начинающийся с нуля индекс элемента <paramref name="value" /> в отсортированном списке <see cref="T:System.Collections.ArrayList" />, если элемент <paramref name="value" /> найден; в противном случае — отрицательное число, которое является двоичным дополнением индекса следующего элемента, большего, чем <paramref name="value" />, или, если большего элемента не существует, двоичным дополнением значения <see cref="P:System.Collections.ArrayList.Count" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметры <paramref name="index" /> и <paramref name="count" /> не указывают допустимый диапазон в <see cref="T:System.Collections.ArrayList" />.  
		/// -или- 
		///  <paramref name="comparer" /> имеет значение <see langword="null" />, и ни <paramref name="value" />, ни элементы <see cref="T:System.Collections.ArrayList" /> не реализуют интерфейс <see cref="T:System.IComparable" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="comparer" /> имеет значение <see langword="null" />, и тип <paramref name="value" /> не совпадает с типом элементов <see cref="T:System.Collections.ArrayList" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.</exception>
		// Token: 0x06005D11 RID: 23825 RVA: 0x00139048 File Offset: 0x00137248
		public virtual int BinarySearch(int index, int count, object value, IComparer comparer)
		{
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Non-negative number required.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			if (this._size - index < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			return Array.BinarySearch(this._items, index, count, value, comparer);
		}

		/// <summary>Выполняет поиск элемента по всему отсортированному списку <see cref="T:System.Collections.ArrayList" />, используя компаратор по умолчанию, и возвращает индекс элемента, отсчитываемый от нуля.</summary>
		/// <param name="value">Искомый объект <see cref="T:System.Object" />. Допускается значение <see langword="null" />.</param>
		/// <returns>Начинающийся с нуля индекс элемента <paramref name="value" /> в отсортированном списке <see cref="T:System.Collections.ArrayList" />, если элемент <paramref name="value" /> найден; в противном случае — отрицательное число, которое является двоичным дополнением индекса следующего элемента, большего, чем <paramref name="value" />, или, если большего элемента не существует, двоичным дополнением значения <see cref="P:System.Collections.ArrayList.Count" />.</returns>
		/// <exception cref="T:System.ArgumentException">Ни один из элементов <paramref name="value" /> и <see cref="T:System.Collections.ArrayList" /> не реализуют интерфейс <see cref="T:System.IComparable" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Тип <paramref name="value" /> не совпадает с типом элементов <see cref="T:System.Collections.ArrayList" />.</exception>
		// Token: 0x06005D12 RID: 23826 RVA: 0x001390A3 File Offset: 0x001372A3
		public virtual int BinarySearch(object value)
		{
			return this.BinarySearch(0, this.Count, value, null);
		}

		/// <summary>Выполняет поиск элемента по всему отсортированному списку <see cref="T:System.Collections.ArrayList" />, используя указанный компаратор, и возвращает индекс элемента, отсчитываемый от нуля.</summary>
		/// <param name="value">Искомый объект <see cref="T:System.Object" />. Допускается значение <see langword="null" />.</param>
		/// <param name="comparer">Реализация интерфейса <see cref="T:System.Collections.IComparer" />, которая используется при сравнении элементов.  
		/// -или- 
		///  Значение <see langword="null" />, чтобы использовать функцию сравнения по умолчанию, которая является реализацией <see cref="T:System.IComparable" /> для каждого элемента.</param>
		/// <returns>Начинающийся с нуля индекс элемента <paramref name="value" /> в отсортированном списке <see cref="T:System.Collections.ArrayList" />, если элемент <paramref name="value" /> найден; в противном случае — отрицательное число, которое является двоичным дополнением индекса следующего элемента, большего, чем <paramref name="value" />, или, если большего элемента не существует, двоичным дополнением значения <see cref="P:System.Collections.ArrayList.Count" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="comparer" /> имеет значение <see langword="null" />, и ни <paramref name="value" />, ни элементы <see cref="T:System.Collections.ArrayList" /> не реализуют интерфейс <see cref="T:System.IComparable" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="comparer" /> имеет значение <see langword="null" />, и тип <paramref name="value" /> не совпадает с типом элементов <see cref="T:System.Collections.ArrayList" />.</exception>
		// Token: 0x06005D13 RID: 23827 RVA: 0x001390B4 File Offset: 0x001372B4
		public virtual int BinarySearch(object value, IComparer comparer)
		{
			return this.BinarySearch(0, this.Count, value, comparer);
		}

		/// <summary>Удаляет из коллекции <see cref="T:System.Collections.ArrayList" /> все элементы.</summary>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.ArrayList" /> доступен только для чтения.  
		/// -или- 
		/// <see cref="T:System.Collections.ArrayList" /> имеет фиксированный размер.</exception>
		// Token: 0x06005D14 RID: 23828 RVA: 0x001390C5 File Offset: 0x001372C5
		public virtual void Clear()
		{
			if (this._size > 0)
			{
				Array.Clear(this._items, 0, this._size);
				this._size = 0;
			}
			this._version++;
		}

		/// <summary>Создает неполную копию <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <returns>Неполная копия <see cref="T:System.Collections.ArrayList" />.</returns>
		// Token: 0x06005D15 RID: 23829 RVA: 0x001390F8 File Offset: 0x001372F8
		public virtual object Clone()
		{
			ArrayList arrayList = new ArrayList(this._size);
			arrayList._size = this._size;
			arrayList._version = this._version;
			Array.Copy(this._items, 0, arrayList._items, 0, this._size);
			return arrayList;
		}

		/// <summary>Определяет, входит ли элемент в коллекцию <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <param name="item">Объект <see cref="T:System.Object" />, который требуется найти в коллекции <see cref="T:System.Collections.ArrayList" />. Допускается значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="item" /> найден в коллекции <see cref="T:System.Collections.ArrayList" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06005D16 RID: 23830 RVA: 0x00139144 File Offset: 0x00137344
		public virtual bool Contains(object item)
		{
			if (item == null)
			{
				for (int i = 0; i < this._size; i++)
				{
					if (this._items[i] == null)
					{
						return true;
					}
				}
				return false;
			}
			for (int j = 0; j < this._size; j++)
			{
				if (this._items[j] != null && this._items[j].Equals(item))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Копирует весь список <see cref="T:System.Collections.ArrayList" /> в совместимый одномерный массив <see cref="T:System.Array" />, начиная с начального элемента целевого массива.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из интерфейса <see cref="T:System.Collections.ArrayList" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		/// -или- 
		/// Число элементов в исходном массиве <see cref="T:System.Collections.ArrayList" /> больше числа элементов, которые может содержать массив назначения <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Тип исходного массива <see cref="T:System.Collections.ArrayList" /> не может быть автоматически приведен к типу массива назначения <paramref name="array" />.</exception>
		// Token: 0x06005D17 RID: 23831 RVA: 0x001391A1 File Offset: 0x001373A1
		public virtual void CopyTo(Array array)
		{
			this.CopyTo(array, 0);
		}

		/// <summary>Копирует целый массив <see cref="T:System.Collections.ArrayList" /> в совместимый одномерный массив <see cref="T:System.Array" />, начиная с заданного индекса целевого массива.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из интерфейса <see cref="T:System.Collections.ArrayList" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="arrayIndex">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="arrayIndex" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		/// -или- 
		/// Число элементов в исходной коллекции <see cref="T:System.Collections.ArrayList" /> больше доступного места от положения, заданного значением параметра <paramref name="arrayIndex" />, до конца массива назначения <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Тип исходного массива <see cref="T:System.Collections.ArrayList" /> не может быть автоматически приведен к типу массива назначения <paramref name="array" />.</exception>
		// Token: 0x06005D18 RID: 23832 RVA: 0x001391AB File Offset: 0x001373AB
		public virtual void CopyTo(Array array, int arrayIndex)
		{
			if (array != null && array.Rank != 1)
			{
				throw new ArgumentException("Only single dimensional arrays are supported for the requested action.", "array");
			}
			Array.Copy(this._items, 0, array, arrayIndex, this._size);
		}

		/// <summary>Копирует диапазон элементов из списка <see cref="T:System.Collections.ArrayList" /> в совместимый одномерный массив <see cref="T:System.Array" />, начиная с указанного индекса целевого массива.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс исходного списка <see cref="T:System.Collections.ArrayList" />, с которого начинается копирование.</param>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из интерфейса <see cref="T:System.Collections.ArrayList" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="arrayIndex">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <param name="count">Число элементов для копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="arrayIndex" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		/// -или- 
		///  Значение параметра <paramref name="index" /> больше или равно значению <see cref="P:System.Collections.ArrayList.Count" /> исходного списка <see cref="T:System.Collections.ArrayList" />.  
		/// -или- 
		/// Число элементов от <paramref name="index" /> до конца исходного списка <see cref="T:System.Collections.ArrayList" /> больше доступного места от положения, заданного значением параметра <paramref name="arrayIndex" />, до конца массива назначения <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Тип исходного массива <see cref="T:System.Collections.ArrayList" /> не может быть автоматически приведен к типу массива назначения <paramref name="array" />.</exception>
		// Token: 0x06005D19 RID: 23833 RVA: 0x001391E0 File Offset: 0x001373E0
		public virtual void CopyTo(int index, Array array, int arrayIndex, int count)
		{
			if (this._size - index < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (array != null && array.Rank != 1)
			{
				throw new ArgumentException("Only single dimensional arrays are supported for the requested action.", "array");
			}
			Array.Copy(this._items, index, array, arrayIndex, count);
		}

		// Token: 0x06005D1A RID: 23834 RVA: 0x00139230 File Offset: 0x00137430
		private void EnsureCapacity(int min)
		{
			if (this._items.Length < min)
			{
				int num = (this._items.Length == 0) ? 4 : (this._items.Length * 2);
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
		}

		/// <summary>Возвращает оболочку <see cref="T:System.Collections.IList" /> фиксированного размера.</summary>
		/// <param name="list">Класс <see cref="T:System.Collections.IList" />, для которого создается оболочка.</param>
		/// <returns>Оболочка <see cref="T:System.Collections.IList" /> фиксированного размера.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="list" /> — <see langword="null" />.</exception>
		// Token: 0x06005D1B RID: 23835 RVA: 0x0013927A File Offset: 0x0013747A
		public static IList FixedSize(IList list)
		{
			if (list == null)
			{
				throw new ArgumentNullException("list");
			}
			return new ArrayList.FixedSizeList(list);
		}

		/// <summary>Возвращает оболочку <see cref="T:System.Collections.ArrayList" /> фиксированного размера.</summary>
		/// <param name="list">Класс <see cref="T:System.Collections.ArrayList" />, для которого создается оболочка.</param>
		/// <returns>Оболочка <see cref="T:System.Collections.ArrayList" /> фиксированного размера.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="list" /> — <see langword="null" />.</exception>
		// Token: 0x06005D1C RID: 23836 RVA: 0x00139290 File Offset: 0x00137490
		public static ArrayList FixedSize(ArrayList list)
		{
			if (list == null)
			{
				throw new ArgumentNullException("list");
			}
			return new ArrayList.FixedSizeArrayList(list);
		}

		/// <summary>Возвращает перечислитель для класса <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <returns>
		///   <see cref="T:System.Collections.IEnumerator" /> для всей коллекции <see cref="T:System.Collections.ArrayList" />.</returns>
		// Token: 0x06005D1D RID: 23837 RVA: 0x001392A6 File Offset: 0x001374A6
		public virtual IEnumerator GetEnumerator()
		{
			return new ArrayList.ArrayListEnumeratorSimple(this);
		}

		/// <summary>Возвращает перечислитель для диапазона элементов в списке <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <param name="index">Отсчитываемый от нуля начальный индекс участка списка <see cref="T:System.Collections.ArrayList" />, на который должен ссылаться перечислитель.</param>
		/// <param name="count">Количество элементов в участке списка <see cref="T:System.Collections.ArrayList" />, на который должен ссылаться перечислитель.</param>
		/// <returns>Интерфейс <see cref="T:System.Collections.IEnumerator" /> для указанного диапазона элементов списка <see cref="T:System.Collections.ArrayList" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="index" /> и <paramref name="count" /> не указывают допустимый диапазон в <see cref="T:System.Collections.ArrayList" />.</exception>
		// Token: 0x06005D1E RID: 23838 RVA: 0x001392B0 File Offset: 0x001374B0
		public virtual IEnumerator GetEnumerator(int index, int count)
		{
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Non-negative number required.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			if (this._size - index < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			return new ArrayList.ArrayListEnumerator(this, index, count);
		}

		/// <summary>Осуществляет поиск указанного объекта <see cref="T:System.Object" /> и возвращает отсчитываемый от нуля индекс первого вхождения в коллекцию <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, который требуется найти в коллекции <see cref="T:System.Collections.ArrayList" />. Допускается значение <see langword="null" />.</param>
		/// <returns>Индекс (с нуля) первого вхождения параметра <paramref name="value" />, если оно найдено в коллекции <see cref="T:System.Collections.ArrayList" />; в противном случае -1.</returns>
		// Token: 0x06005D1F RID: 23839 RVA: 0x00139303 File Offset: 0x00137503
		public virtual int IndexOf(object value)
		{
			return Array.IndexOf(this._items, value, 0, this._size);
		}

		/// <summary>Осуществляет поиск указанного объекта <see cref="T:System.Object" /> и возвращает отсчитываемый от нуля индекс первого вхождения в диапазоне элементов списка <see cref="T:System.Collections.ArrayList" />, начиная с заданного индекса и до последнего элемента.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, который требуется найти в коллекции <see cref="T:System.Collections.ArrayList" />. Допускается значение <see langword="null" />.</param>
		/// <param name="startIndex">Индекс (с нуля) начальной позиции поиска. Значение 0 (ноль) действительно в пустом списке.</param>
		/// <returns>Отсчитываемый от нуля индекс первого вхождения элемента <paramref name="value" /> в диапазоне элементов списка <see cref="T:System.Collections.ArrayList" />, начиная с позиции <paramref name="startIndex" /> и до конца списка, если элемент найден; в противном случае значение –1.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> находится вне диапазона допустимых индексов для <see cref="T:System.Collections.ArrayList" />.</exception>
		// Token: 0x06005D20 RID: 23840 RVA: 0x00139318 File Offset: 0x00137518
		public virtual int IndexOf(object value, int startIndex)
		{
			if (startIndex > this._size)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			return Array.IndexOf(this._items, value, startIndex, this._size - startIndex);
		}

		/// <summary>Выполняет поиск указанного объекта <see cref="T:System.Object" /> и возвращает отсчитываемый от нуля индекс первого вхождения в диапазоне элементов списка <see cref="T:System.Collections.ArrayList" />, который начинается с заданного индекса и содержит указанное число элементов.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, который требуется найти в коллекции <see cref="T:System.Collections.ArrayList" />. Допускается значение <see langword="null" />.</param>
		/// <param name="startIndex">Индекс (с нуля) начальной позиции поиска. Значение 0 (ноль) действительно в пустом списке.</param>
		/// <param name="count">Число элементов в диапазоне, в котором выполняется поиск.</param>
		/// <returns>Отсчитываемый от нуля индекс первого вхождения <paramref name="value" /> в диапазоне элементов списка <see cref="T:System.Collections.ArrayList" />, который начинается с позиции <paramref name="startIndex" /> и содержит <paramref name="count" /> элементов, если искомый объект найден; в противном случае значение –1.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> находится вне диапазона допустимых индексов для <see cref="T:System.Collections.ArrayList" />.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.  
		/// -или- 
		///  <paramref name="startIndex" /> и <paramref name="count" /> не указывают допустимый раздел в <see cref="T:System.Collections.ArrayList" />.</exception>
		// Token: 0x06005D21 RID: 23841 RVA: 0x00139348 File Offset: 0x00137548
		public virtual int IndexOf(object value, int startIndex, int count)
		{
			if (startIndex > this._size)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (count < 0 || startIndex > this._size - count)
			{
				throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
			}
			return Array.IndexOf(this._items, value, startIndex, count);
		}

		/// <summary>Вставляет элемент в коллекцию <see cref="T:System.Collections.ArrayList" /> по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс, по которому следует вставить элемент <paramref name="value" />.</param>
		/// <param name="value">Вставляемый объект <see cref="T:System.Object" />. Допускается значение <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		/// -или- 
		///  Значение <paramref name="index" /> больше значения <see cref="P:System.Collections.ArrayList.Count" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.ArrayList" /> доступен только для чтения.  
		/// -или- 
		/// <see cref="T:System.Collections.ArrayList" /> имеет фиксированный размер.</exception>
		// Token: 0x06005D22 RID: 23842 RVA: 0x0013939C File Offset: 0x0013759C
		public virtual void Insert(int index, object value)
		{
			if (index < 0 || index > this._size)
			{
				throw new ArgumentOutOfRangeException("index", "Insertion index was out of range. Must be non-negative and less than or equal to size.");
			}
			if (this._size == this._items.Length)
			{
				this.EnsureCapacity(this._size + 1);
			}
			if (index < this._size)
			{
				Array.Copy(this._items, index, this._items, index + 1, this._size - index);
			}
			this._items[index] = value;
			this._size++;
			this._version++;
		}

		/// <summary>Вставляет элементы коллекции в список <see cref="T:System.Collections.ArrayList" /> в позиции с указанным индексом.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс места вставки новых элементов.</param>
		/// <param name="c">Коллекция <see cref="T:System.Collections.ICollection" />, элементы которой требуется вставить в список <see cref="T:System.Collections.ArrayList" />. Сама коллекция не может иметь значение <see langword="null" />, но может содержать элементы со значением <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="c" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		/// -или- 
		///  Значение <paramref name="index" /> больше значения <see cref="P:System.Collections.ArrayList.Count" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.ArrayList" /> доступен только для чтения.  
		/// -или- 
		/// <see cref="T:System.Collections.ArrayList" /> имеет фиксированный размер.</exception>
		// Token: 0x06005D23 RID: 23843 RVA: 0x00139430 File Offset: 0x00137630
		public virtual void InsertRange(int index, ICollection c)
		{
			if (c == null)
			{
				throw new ArgumentNullException("c", "Collection cannot be null.");
			}
			if (index < 0 || index > this._size)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			int count = c.Count;
			if (count > 0)
			{
				this.EnsureCapacity(this._size + count);
				if (index < this._size)
				{
					Array.Copy(this._items, index, this._items, index + count, this._size - index);
				}
				object[] array = new object[count];
				c.CopyTo(array, 0);
				array.CopyTo(this._items, index);
				this._size += count;
				this._version++;
			}
		}

		/// <summary>Осуществляет поиск указанного объекта <see cref="T:System.Object" /> и возвращает отсчитываемый от нуля индекс последнего вхождения в коллекцию <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, который требуется найти в коллекции <see cref="T:System.Collections.ArrayList" />. Допускается значение <see langword="null" />.</param>
		/// <returns>Отсчитываемый от нуля индекс последнего вхождения <paramref name="value" /> в пределах всего списка <see cref="T:System.Collections.ArrayList" />, если элемент найден; в противном случае значение –1.</returns>
		// Token: 0x06005D24 RID: 23844 RVA: 0x001394E4 File Offset: 0x001376E4
		public virtual int LastIndexOf(object value)
		{
			return this.LastIndexOf(value, this._size - 1, this._size);
		}

		/// <summary>Осуществляет поиск указанного объекта <see cref="T:System.Object" /> и возвращает отсчитываемый от нуля индекс последнего вхождения в диапазоне элементов списка <see cref="T:System.Collections.ArrayList" />, начиная с первого элемента и заканчивая элементом с заданным индексом.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, который требуется найти в коллекции <see cref="T:System.Collections.ArrayList" />. Допускается значение <see langword="null" />.</param>
		/// <param name="startIndex">Индекс (с нуля) начала диапазона поиска в обратном направлении.</param>
		/// <returns>Отсчитываемый от нуля индекс последнего вхождения элемента <paramref name="value" /> в диапазоне элементов списка <see cref="T:System.Collections.ArrayList" />, начиная с первого элемента и до позиции <paramref name="startIndex" />, если элемент найден; в противном случае значение -1.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> находится вне диапазона допустимых индексов для <see cref="T:System.Collections.ArrayList" />.</exception>
		// Token: 0x06005D25 RID: 23845 RVA: 0x001394FB File Offset: 0x001376FB
		public virtual int LastIndexOf(object value, int startIndex)
		{
			if (startIndex >= this._size)
			{
				throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			return this.LastIndexOf(value, startIndex, startIndex + 1);
		}

		/// <summary>Выполняет поиск указанного объекта <see cref="T:System.Object" /> и возвращает отсчитываемый от нуля индекс последнего вхождения в диапазоне элементов списка <see cref="T:System.Collections.ArrayList" />, содержащем указанное число элементов и заканчивающемся в позиции с указанным индексом.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, который требуется найти в коллекции <see cref="T:System.Collections.ArrayList" />. Допускается значение <see langword="null" />.</param>
		/// <param name="startIndex">Индекс (с нуля) начала диапазона поиска в обратном направлении.</param>
		/// <param name="count">Число элементов в диапазоне, в котором выполняется поиск.</param>
		/// <returns>Отсчитываемый от нуля индекс последнего вхождения <paramref name="value" /> в диапазоне элементов списка <see cref="T:System.Collections.ArrayList" />, состоящем из <paramref name="count" /> элементов и заканчивающемся в позиции <paramref name="startIndex" />, если элемент найден. В противном случае значение –1.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> находится вне диапазона допустимых индексов для <see cref="T:System.Collections.ArrayList" />.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.  
		/// -или- 
		///  <paramref name="startIndex" /> и <paramref name="count" /> не указывают допустимый раздел в <see cref="T:System.Collections.ArrayList" />.</exception>
		// Token: 0x06005D26 RID: 23846 RVA: 0x00139524 File Offset: 0x00137724
		public virtual int LastIndexOf(object value, int startIndex, int count)
		{
			if (this.Count != 0 && (startIndex < 0 || count < 0))
			{
				throw new ArgumentOutOfRangeException((startIndex < 0) ? "startIndex" : "count", "Non-negative number required.");
			}
			if (this._size == 0)
			{
				return -1;
			}
			if (startIndex >= this._size || count > startIndex + 1)
			{
				throw new ArgumentOutOfRangeException((startIndex >= this._size) ? "startIndex" : "count", "Must be less than or equal to the size of the collection.");
			}
			return Array.LastIndexOf(this._items, value, startIndex, count);
		}

		/// <summary>Возвращает программу-оболочку <see cref="T:System.Collections.IList" />, доступную только для чтения.</summary>
		/// <param name="list">Класс <see cref="T:System.Collections.IList" />, для которого создается оболочка.</param>
		/// <returns>Доступная только для чтения программа-оболочка <see cref="T:System.Collections.IList" /> для параметра <paramref name="list" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="list" /> — <see langword="null" />.</exception>
		// Token: 0x06005D27 RID: 23847 RVA: 0x001395A3 File Offset: 0x001377A3
		public static IList ReadOnly(IList list)
		{
			if (list == null)
			{
				throw new ArgumentNullException("list");
			}
			return new ArrayList.ReadOnlyList(list);
		}

		/// <summary>Возвращает программу-оболочку <see cref="T:System.Collections.ArrayList" />, доступную только для чтения.</summary>
		/// <param name="list">Класс <see cref="T:System.Collections.ArrayList" />, для которого создается оболочка.</param>
		/// <returns>Доступная только для чтения программа-оболочка <see cref="T:System.Collections.ArrayList" /> для параметра <paramref name="list" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="list" /> — <see langword="null" />.</exception>
		// Token: 0x06005D28 RID: 23848 RVA: 0x001395B9 File Offset: 0x001377B9
		public static ArrayList ReadOnly(ArrayList list)
		{
			if (list == null)
			{
				throw new ArgumentNullException("list");
			}
			return new ArrayList.ReadOnlyArrayList(list);
		}

		/// <summary>Удаляет первое вхождение указанного объекта из коллекции <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <param name="obj">Элемент <see cref="T:System.Object" />, который требуется удалить из <see cref="T:System.Collections.ArrayList" />. Допускается значение <see langword="null" />.</param>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.ArrayList" /> доступен только для чтения.  
		/// -или- 
		/// <see cref="T:System.Collections.ArrayList" /> имеет фиксированный размер.</exception>
		// Token: 0x06005D29 RID: 23849 RVA: 0x001395D0 File Offset: 0x001377D0
		public virtual void Remove(object obj)
		{
			int num = this.IndexOf(obj);
			if (num >= 0)
			{
				this.RemoveAt(num);
			}
		}

		/// <summary>Удаляет элемент списка <see cref="T:System.Collections.ArrayList" /> с указанным индексом.</summary>
		/// <param name="index">Индекс (с нуля) элемента, который требуется удалить.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="index" /> больше или равно значению свойства <see cref="P:System.Collections.ArrayList.Count" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.ArrayList" /> доступен только для чтения.  
		/// -или- 
		/// <see cref="T:System.Collections.ArrayList" /> имеет фиксированный размер.</exception>
		// Token: 0x06005D2A RID: 23850 RVA: 0x001395F0 File Offset: 0x001377F0
		public virtual void RemoveAt(int index)
		{
			if (index < 0 || index >= this._size)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			this._size--;
			if (index < this._size)
			{
				Array.Copy(this._items, index + 1, this._items, index, this._size - index);
			}
			this._items[this._size] = null;
			this._version++;
		}

		/// <summary>Удаляет диапазон элементов из списка <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс начала диапазона элементов, которые требуется удалить.</param>
		/// <param name="count">Число удаляемых элементов.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Параметры <paramref name="index" /> и <paramref name="count" /> не указывают допустимый диапазон элементов в списке <see cref="T:System.Collections.ArrayList" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.ArrayList" /> доступен только для чтения.  
		/// -или- 
		/// <see cref="T:System.Collections.ArrayList" /> имеет фиксированный размер.</exception>
		// Token: 0x06005D2B RID: 23851 RVA: 0x0013966C File Offset: 0x0013786C
		public virtual void RemoveRange(int index, int count)
		{
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Non-negative number required.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			if (this._size - index < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (count > 0)
			{
				int i = this._size;
				this._size -= count;
				if (index < this._size)
				{
					Array.Copy(this._items, index + count, this._items, index, this._size - index);
				}
				while (i > this._size)
				{
					this._items[--i] = null;
				}
				this._version++;
			}
		}

		/// <summary>Возвращает список <see cref="T:System.Collections.ArrayList" />, элементы которого являются копиями указанного значения.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, который требуется скопировать несколько раз в новый список <see cref="T:System.Collections.ArrayList" />. Допускается значение <see langword="null" />.</param>
		/// <param name="count">Количество копий значения <paramref name="value" />.</param>
		/// <returns>Список <see cref="T:System.Collections.ArrayList" /> с количеством элементов, равным <paramref name="count" />, которые являются копиями объекта <paramref name="value" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="count" /> меньше нуля.</exception>
		// Token: 0x06005D2C RID: 23852 RVA: 0x0013971C File Offset: 0x0013791C
		public static ArrayList Repeat(object value, int count)
		{
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			ArrayList arrayList = new ArrayList((count > 4) ? count : 4);
			for (int i = 0; i < count; i++)
			{
				arrayList.Add(value);
			}
			return arrayList;
		}

		/// <summary>Изменяет порядок элементов во всем списке <see cref="T:System.Collections.ArrayList" /> на обратный.</summary>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.ArrayList" /> доступен только для чтения.</exception>
		// Token: 0x06005D2D RID: 23853 RVA: 0x00139760 File Offset: 0x00137960
		public virtual void Reverse()
		{
			this.Reverse(0, this.Count);
		}

		/// <summary>Изменяет порядок элементов в указанном диапазоне.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс начала диапазона, порядок элементов которого требуется изменить.</param>
		/// <param name="count">Число элементов в диапазоне, порядок сортировки в котором требуется изменить.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Параметры <paramref name="index" /> и <paramref name="count" /> не указывают допустимый диапазон элементов в списке <see cref="T:System.Collections.ArrayList" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.ArrayList" /> доступен только для чтения.</exception>
		// Token: 0x06005D2E RID: 23854 RVA: 0x00139770 File Offset: 0x00137970
		public virtual void Reverse(int index, int count)
		{
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Non-negative number required.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			if (this._size - index < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			Array.Reverse<object>(this._items, index, count);
			this._version++;
		}

		/// <summary>Копирует элементы коллекции в диапазон элементов списка <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс списка <see cref="T:System.Collections.ArrayList" />, с которого начинается копирование элементов коллекции <paramref name="c" />.</param>
		/// <param name="c">Интерфейс <see cref="T:System.Collections.ICollection" />, элементы которого копируются в список <see cref="T:System.Collections.ArrayList" />. Сама коллекция не может иметь значение <see langword="null" />, но может содержать элементы со значением <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		/// -или- 
		///  <paramref name="index" /> плюс количество элементов в <paramref name="c" /> больше, чем <see cref="P:System.Collections.ArrayList.Count" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="c" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.ArrayList" /> доступен только для чтения.</exception>
		// Token: 0x06005D2F RID: 23855 RVA: 0x001397D8 File Offset: 0x001379D8
		public virtual void SetRange(int index, ICollection c)
		{
			if (c == null)
			{
				throw new ArgumentNullException("c", "Collection cannot be null.");
			}
			int count = c.Count;
			if (index < 0 || index > this._size - count)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (count > 0)
			{
				c.CopyTo(this._items, index);
				this._version++;
			}
		}

		/// <summary>Возвращает список <see cref="T:System.Collections.ArrayList" />, представляющий подмножество элементов исходного списка <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс списка <see cref="T:System.Collections.ArrayList" />, с которого начинается диапазон.</param>
		/// <param name="count">Число элементов в диапазоне.</param>
		/// <returns>Список <see cref="T:System.Collections.ArrayList" />, представляющий подмножество элементов исходного списка <see cref="T:System.Collections.ArrayList" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Параметры <paramref name="index" /> и <paramref name="count" /> не указывают допустимый диапазон элементов в списке <see cref="T:System.Collections.ArrayList" />.</exception>
		// Token: 0x06005D30 RID: 23856 RVA: 0x00139840 File Offset: 0x00137A40
		public virtual ArrayList GetRange(int index, int count)
		{
			if (index < 0 || count < 0)
			{
				throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
			}
			if (this._size - index < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			return new ArrayList.Range(this, index, count);
		}

		/// <summary>Сортирует элементы во всем списке <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.ArrayList" /> доступен только для чтения.</exception>
		// Token: 0x06005D31 RID: 23857 RVA: 0x0013988E File Offset: 0x00137A8E
		public virtual void Sort()
		{
			this.Sort(0, this.Count, Comparer.Default);
		}

		/// <summary>Сортирует элементы во всем списке <see cref="T:System.Collections.ArrayList" /> с помощью указанной функции сравнения.</summary>
		/// <param name="comparer">Реализация интерфейса <see cref="T:System.Collections.IComparer" />, которая используется при сравнении элементов.  
		/// -или- 
		/// Пустая ссылка (<see langword="Nothing" /> в Visual Basic) для использования реализации <see cref="T:System.IComparable" /> каждого элемента.</param>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.ArrayList" /> доступен только для чтения.</exception>
		/// <exception cref="T:System.InvalidOperationException">При сравнении двух элементов возникла ошибка.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <see langword="null" /> передается для <paramref name="comparer" />, а элементы в списке не реализуют <see cref="T:System.IComparable" />.</exception>
		// Token: 0x06005D32 RID: 23858 RVA: 0x001398A2 File Offset: 0x00137AA2
		public virtual void Sort(IComparer comparer)
		{
			this.Sort(0, this.Count, comparer);
		}

		/// <summary>Сортирует элементы в диапазоне элементов списка <see cref="T:System.Collections.ArrayList" /> с помощью указанной функции сравнения.</summary>
		/// <param name="index">Индекс (с нуля) начала диапазона, который требуется отсортировать.</param>
		/// <param name="count">Длина диапазона сортировки.</param>
		/// <param name="comparer">Реализация интерфейса <see cref="T:System.Collections.IComparer" />, которая используется при сравнении элементов.  
		/// -или- 
		/// Пустая ссылка (<see langword="Nothing" /> в Visual Basic) для использования реализации <see cref="T:System.IComparable" /> каждого элемента.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="index" /> и <paramref name="count" /> не указывают допустимый диапазон в <see cref="T:System.Collections.ArrayList" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.ArrayList" /> доступен только для чтения.</exception>
		/// <exception cref="T:System.InvalidOperationException">При сравнении двух элементов возникла ошибка.</exception>
		// Token: 0x06005D33 RID: 23859 RVA: 0x001398B4 File Offset: 0x00137AB4
		public virtual void Sort(int index, int count, IComparer comparer)
		{
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Non-negative number required.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			if (this._size - index < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			Array.Sort(this._items, index, count, comparer);
			this._version++;
		}

		/// <summary>Возвращает синхронизированную (потокобезопасную) оболочку <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="list">Коллекция <see cref="T:System.Collections.IList" />, которую требуется синхронизировать.</param>
		/// <returns>Синхронизированная (потокобезопасная) оболочка <see cref="T:System.Collections.IList" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="list" /> — <see langword="null" />.</exception>
		// Token: 0x06005D34 RID: 23860 RVA: 0x0013991B File Offset: 0x00137B1B
		public static IList Synchronized(IList list)
		{
			if (list == null)
			{
				throw new ArgumentNullException("list");
			}
			return new ArrayList.SyncIList(list);
		}

		/// <summary>Возвращает синхронизированную (потокобезопасную) оболочку <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <param name="list">Коллекция <see cref="T:System.Collections.ArrayList" />, которую требуется синхронизировать.</param>
		/// <returns>Синхронизированная (потокобезопасная) оболочка <see cref="T:System.Collections.ArrayList" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="list" /> — <see langword="null" />.</exception>
		// Token: 0x06005D35 RID: 23861 RVA: 0x00139931 File Offset: 0x00137B31
		public static ArrayList Synchronized(ArrayList list)
		{
			if (list == null)
			{
				throw new ArgumentNullException("list");
			}
			return new ArrayList.SyncArrayList(list);
		}

		/// <summary>Копирует элементы списка <see cref="T:System.Collections.ArrayList" /> в новый массив <see cref="T:System.Object" />.</summary>
		/// <returns>Массив <see cref="T:System.Object" />, содержащий копии элементов списка <see cref="T:System.Collections.ArrayList" />.</returns>
		// Token: 0x06005D36 RID: 23862 RVA: 0x00139948 File Offset: 0x00137B48
		public virtual object[] ToArray()
		{
			if (this._size == 0)
			{
				return Array.Empty<object>();
			}
			object[] array = new object[this._size];
			Array.Copy(this._items, 0, array, 0, this._size);
			return array;
		}

		/// <summary>Копирует элементы списка <see cref="T:System.Collections.ArrayList" /> в новый массив с элементами указанного типа.</summary>
		/// <param name="type">Элемент <see cref="T:System.Type" /> массива назначения, используемый для создания и копирования элементов в этот массив.</param>
		/// <returns>Массив элементов указанного типа, содержащий копии элементов массива <see cref="T:System.Collections.ArrayList" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Тип исходного списка <see cref="T:System.Collections.ArrayList" /> не может быть автоматически приведен к указанному типу.</exception>
		// Token: 0x06005D37 RID: 23863 RVA: 0x00139984 File Offset: 0x00137B84
		public virtual Array ToArray(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			Array array = Array.CreateInstance(type, this._size);
			Array.Copy(this._items, 0, array, 0, this._size);
			return array;
		}

		/// <summary>Задает значение емкости, равное действительному количеству элементов в <see cref="T:System.Collections.ArrayList" />.</summary>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.ArrayList" /> доступен только для чтения.  
		/// -или- 
		/// <see cref="T:System.Collections.ArrayList" /> имеет фиксированный размер.</exception>
		// Token: 0x06005D38 RID: 23864 RVA: 0x001399C7 File Offset: 0x00137BC7
		public virtual void TrimToSize()
		{
			this.Capacity = this._size;
		}

		// Token: 0x040038D0 RID: 14544
		private object[] _items;

		// Token: 0x040038D1 RID: 14545
		private int _size;

		// Token: 0x040038D2 RID: 14546
		private int _version;

		// Token: 0x040038D3 RID: 14547
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x040038D4 RID: 14548
		private const int _defaultCapacity = 4;

		// Token: 0x040038D5 RID: 14549
		internal const int MaxArrayLength = 2146435071;

		// Token: 0x02000A3C RID: 2620
		[Serializable]
		private class IListWrapper : ArrayList
		{
			// Token: 0x06005D39 RID: 23865 RVA: 0x001399D5 File Offset: 0x00137BD5
			internal IListWrapper(IList list)
			{
				this._list = list;
				this._version = 0;
			}

			// Token: 0x1700103C RID: 4156
			// (get) Token: 0x06005D3A RID: 23866 RVA: 0x001399EB File Offset: 0x00137BEB
			// (set) Token: 0x06005D3B RID: 23867 RVA: 0x001399F8 File Offset: 0x00137BF8
			public override int Capacity
			{
				get
				{
					return this._list.Count;
				}
				set
				{
					if (value < this.Count)
					{
						throw new ArgumentOutOfRangeException("value", "capacity was less than the current size.");
					}
				}
			}

			// Token: 0x1700103D RID: 4157
			// (get) Token: 0x06005D3C RID: 23868 RVA: 0x001399EB File Offset: 0x00137BEB
			public override int Count
			{
				get
				{
					return this._list.Count;
				}
			}

			// Token: 0x1700103E RID: 4158
			// (get) Token: 0x06005D3D RID: 23869 RVA: 0x00139A13 File Offset: 0x00137C13
			public override bool IsReadOnly
			{
				get
				{
					return this._list.IsReadOnly;
				}
			}

			// Token: 0x1700103F RID: 4159
			// (get) Token: 0x06005D3E RID: 23870 RVA: 0x00139A20 File Offset: 0x00137C20
			public override bool IsFixedSize
			{
				get
				{
					return this._list.IsFixedSize;
				}
			}

			// Token: 0x17001040 RID: 4160
			// (get) Token: 0x06005D3F RID: 23871 RVA: 0x00139A2D File Offset: 0x00137C2D
			public override bool IsSynchronized
			{
				get
				{
					return this._list.IsSynchronized;
				}
			}

			// Token: 0x17001041 RID: 4161
			public override object this[int index]
			{
				get
				{
					return this._list[index];
				}
				set
				{
					this._list[index] = value;
					this._version++;
				}
			}

			// Token: 0x17001042 RID: 4162
			// (get) Token: 0x06005D42 RID: 23874 RVA: 0x00139A65 File Offset: 0x00137C65
			public override object SyncRoot
			{
				get
				{
					return this._list.SyncRoot;
				}
			}

			// Token: 0x06005D43 RID: 23875 RVA: 0x00139A72 File Offset: 0x00137C72
			public override int Add(object obj)
			{
				int result = this._list.Add(obj);
				this._version++;
				return result;
			}

			// Token: 0x06005D44 RID: 23876 RVA: 0x00139A8E File Offset: 0x00137C8E
			public override void AddRange(ICollection c)
			{
				this.InsertRange(this.Count, c);
			}

			// Token: 0x06005D45 RID: 23877 RVA: 0x00139AA0 File Offset: 0x00137CA0
			public override int BinarySearch(int index, int count, object value, IComparer comparer)
			{
				if (index < 0 || count < 0)
				{
					throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
				}
				if (this.Count - index < count)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				if (comparer == null)
				{
					comparer = Comparer.Default;
				}
				int i = index;
				int num = index + count - 1;
				while (i <= num)
				{
					int num2 = (i + num) / 2;
					int num3 = comparer.Compare(value, this._list[num2]);
					if (num3 == 0)
					{
						return num2;
					}
					if (num3 < 0)
					{
						num = num2 - 1;
					}
					else
					{
						i = num2 + 1;
					}
				}
				return ~i;
			}

			// Token: 0x06005D46 RID: 23878 RVA: 0x00139B2F File Offset: 0x00137D2F
			public override void Clear()
			{
				if (this._list.IsFixedSize)
				{
					throw new NotSupportedException("Collection was of a fixed size.");
				}
				this._list.Clear();
				this._version++;
			}

			// Token: 0x06005D47 RID: 23879 RVA: 0x00139B62 File Offset: 0x00137D62
			public override object Clone()
			{
				return new ArrayList.IListWrapper(this._list);
			}

			// Token: 0x06005D48 RID: 23880 RVA: 0x00139B6F File Offset: 0x00137D6F
			public override bool Contains(object obj)
			{
				return this._list.Contains(obj);
			}

			// Token: 0x06005D49 RID: 23881 RVA: 0x00139B7D File Offset: 0x00137D7D
			public override void CopyTo(Array array, int index)
			{
				this._list.CopyTo(array, index);
			}

			// Token: 0x06005D4A RID: 23882 RVA: 0x00139B8C File Offset: 0x00137D8C
			public override void CopyTo(int index, Array array, int arrayIndex, int count)
			{
				if (array == null)
				{
					throw new ArgumentNullException("array");
				}
				if (index < 0 || arrayIndex < 0)
				{
					throw new ArgumentOutOfRangeException((index < 0) ? "index" : "arrayIndex", "Non-negative number required.");
				}
				if (count < 0)
				{
					throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
				}
				if (array.Length - arrayIndex < count)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				if (array.Rank != 1)
				{
					throw new ArgumentException("Only single dimensional arrays are supported for the requested action.", "array");
				}
				if (this._list.Count - index < count)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				for (int i = index; i < index + count; i++)
				{
					array.SetValue(this._list[i], arrayIndex++);
				}
			}

			// Token: 0x06005D4B RID: 23883 RVA: 0x00139C52 File Offset: 0x00137E52
			public override IEnumerator GetEnumerator()
			{
				return this._list.GetEnumerator();
			}

			// Token: 0x06005D4C RID: 23884 RVA: 0x00139C60 File Offset: 0x00137E60
			public override IEnumerator GetEnumerator(int index, int count)
			{
				if (index < 0 || count < 0)
				{
					throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
				}
				if (this._list.Count - index < count)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				return new ArrayList.IListWrapper.IListWrapperEnumWrapper(this, index, count);
			}

			// Token: 0x06005D4D RID: 23885 RVA: 0x00139CB3 File Offset: 0x00137EB3
			public override int IndexOf(object value)
			{
				return this._list.IndexOf(value);
			}

			// Token: 0x06005D4E RID: 23886 RVA: 0x00139CC1 File Offset: 0x00137EC1
			public override int IndexOf(object value, int startIndex)
			{
				return this.IndexOf(value, startIndex, this._list.Count - startIndex);
			}

			// Token: 0x06005D4F RID: 23887 RVA: 0x00139CD8 File Offset: 0x00137ED8
			public override int IndexOf(object value, int startIndex, int count)
			{
				if (startIndex < 0 || startIndex > this.Count)
				{
					throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				if (count < 0 || startIndex > this.Count - count)
				{
					throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
				}
				int num = startIndex + count;
				if (value == null)
				{
					for (int i = startIndex; i < num; i++)
					{
						if (this._list[i] == null)
						{
							return i;
						}
					}
					return -1;
				}
				for (int j = startIndex; j < num; j++)
				{
					if (this._list[j] != null && this._list[j].Equals(value))
					{
						return j;
					}
				}
				return -1;
			}

			// Token: 0x06005D50 RID: 23888 RVA: 0x00139D77 File Offset: 0x00137F77
			public override void Insert(int index, object obj)
			{
				this._list.Insert(index, obj);
				this._version++;
			}

			// Token: 0x06005D51 RID: 23889 RVA: 0x00139D94 File Offset: 0x00137F94
			public override void InsertRange(int index, ICollection c)
			{
				if (c == null)
				{
					throw new ArgumentNullException("c", "Collection cannot be null.");
				}
				if (index < 0 || index > this.Count)
				{
					throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				if (c.Count > 0)
				{
					ArrayList arrayList = this._list as ArrayList;
					if (arrayList != null)
					{
						arrayList.InsertRange(index, c);
					}
					else
					{
						foreach (object value in c)
						{
							this._list.Insert(index++, value);
						}
					}
					this._version++;
				}
			}

			// Token: 0x06005D52 RID: 23890 RVA: 0x00139E29 File Offset: 0x00138029
			public override int LastIndexOf(object value)
			{
				return this.LastIndexOf(value, this._list.Count - 1, this._list.Count);
			}

			// Token: 0x06005D53 RID: 23891 RVA: 0x00139E4A File Offset: 0x0013804A
			public override int LastIndexOf(object value, int startIndex)
			{
				return this.LastIndexOf(value, startIndex, startIndex + 1);
			}

			// Token: 0x06005D54 RID: 23892 RVA: 0x00139E58 File Offset: 0x00138058
			public override int LastIndexOf(object value, int startIndex, int count)
			{
				if (this._list.Count == 0)
				{
					return -1;
				}
				if (startIndex < 0 || startIndex >= this._list.Count)
				{
					throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				if (count < 0 || count > startIndex + 1)
				{
					throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
				}
				int num = startIndex - count + 1;
				if (value == null)
				{
					for (int i = startIndex; i >= num; i--)
					{
						if (this._list[i] == null)
						{
							return i;
						}
					}
					return -1;
				}
				for (int j = startIndex; j >= num; j--)
				{
					if (this._list[j] != null && this._list[j].Equals(value))
					{
						return j;
					}
				}
				return -1;
			}

			// Token: 0x06005D55 RID: 23893 RVA: 0x00139F08 File Offset: 0x00138108
			public override void Remove(object value)
			{
				int num = this.IndexOf(value);
				if (num >= 0)
				{
					this.RemoveAt(num);
				}
			}

			// Token: 0x06005D56 RID: 23894 RVA: 0x00139F28 File Offset: 0x00138128
			public override void RemoveAt(int index)
			{
				this._list.RemoveAt(index);
				this._version++;
			}

			// Token: 0x06005D57 RID: 23895 RVA: 0x00139F44 File Offset: 0x00138144
			public override void RemoveRange(int index, int count)
			{
				if (index < 0 || count < 0)
				{
					throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
				}
				if (this._list.Count - index < count)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				if (count > 0)
				{
					this._version++;
				}
				while (count > 0)
				{
					this._list.RemoveAt(index);
					count--;
				}
			}

			// Token: 0x06005D58 RID: 23896 RVA: 0x00139FB8 File Offset: 0x001381B8
			public override void Reverse(int index, int count)
			{
				if (index < 0 || count < 0)
				{
					throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
				}
				if (this._list.Count - index < count)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				int i = index;
				int num = index + count - 1;
				while (i < num)
				{
					object value = this._list[i];
					this._list[i++] = this._list[num];
					this._list[num--] = value;
				}
				this._version++;
			}

			// Token: 0x06005D59 RID: 23897 RVA: 0x0013A05C File Offset: 0x0013825C
			public override void SetRange(int index, ICollection c)
			{
				if (c == null)
				{
					throw new ArgumentNullException("c", "Collection cannot be null.");
				}
				if (index < 0 || index > this._list.Count - c.Count)
				{
					throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				if (c.Count > 0)
				{
					foreach (object value in c)
					{
						this._list[index++] = value;
					}
					this._version++;
				}
			}

			// Token: 0x06005D5A RID: 23898 RVA: 0x0013A0E4 File Offset: 0x001382E4
			public override ArrayList GetRange(int index, int count)
			{
				if (index < 0 || count < 0)
				{
					throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
				}
				if (this._list.Count - index < count)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				return new ArrayList.Range(this, index, count);
			}

			// Token: 0x06005D5B RID: 23899 RVA: 0x0013A138 File Offset: 0x00138338
			public override void Sort(int index, int count, IComparer comparer)
			{
				if (index < 0 || count < 0)
				{
					throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
				}
				if (this._list.Count - index < count)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				object[] array = new object[count];
				this.CopyTo(index, array, 0, count);
				Array.Sort(array, 0, count, comparer);
				for (int i = 0; i < count; i++)
				{
					this._list[i + index] = array[i];
				}
				this._version++;
			}

			// Token: 0x06005D5C RID: 23900 RVA: 0x0013A1C8 File Offset: 0x001383C8
			public override object[] ToArray()
			{
				if (this.Count == 0)
				{
					return Array.Empty<object>();
				}
				object[] array = new object[this.Count];
				this._list.CopyTo(array, 0);
				return array;
			}

			// Token: 0x06005D5D RID: 23901 RVA: 0x0013A200 File Offset: 0x00138400
			public override Array ToArray(Type type)
			{
				if (type == null)
				{
					throw new ArgumentNullException("type");
				}
				Array array = Array.CreateInstance(type, this._list.Count);
				this._list.CopyTo(array, 0);
				return array;
			}

			// Token: 0x06005D5E RID: 23902 RVA: 0x00004BF9 File Offset: 0x00002DF9
			public override void TrimToSize()
			{
			}

			// Token: 0x040038D6 RID: 14550
			private IList _list;

			// Token: 0x02000A3D RID: 2621
			[Serializable]
			private sealed class IListWrapperEnumWrapper : IEnumerator, ICloneable
			{
				// Token: 0x06005D5F RID: 23903 RVA: 0x0013A244 File Offset: 0x00138444
				internal IListWrapperEnumWrapper(ArrayList.IListWrapper listWrapper, int startIndex, int count)
				{
					this._en = listWrapper.GetEnumerator();
					this._initialStartIndex = startIndex;
					this._initialCount = count;
					while (startIndex-- > 0 && this._en.MoveNext())
					{
					}
					this._remaining = count;
					this._firstCall = true;
				}

				// Token: 0x06005D60 RID: 23904 RVA: 0x0000259F File Offset: 0x0000079F
				private IListWrapperEnumWrapper()
				{
				}

				// Token: 0x06005D61 RID: 23905 RVA: 0x0013A298 File Offset: 0x00138498
				public object Clone()
				{
					return new ArrayList.IListWrapper.IListWrapperEnumWrapper
					{
						_en = (IEnumerator)((ICloneable)this._en).Clone(),
						_initialStartIndex = this._initialStartIndex,
						_initialCount = this._initialCount,
						_remaining = this._remaining,
						_firstCall = this._firstCall
					};
				}

				// Token: 0x06005D62 RID: 23906 RVA: 0x0013A2F8 File Offset: 0x001384F8
				public bool MoveNext()
				{
					if (this._firstCall)
					{
						this._firstCall = false;
						int remaining = this._remaining;
						this._remaining = remaining - 1;
						return remaining > 0 && this._en.MoveNext();
					}
					if (this._remaining < 0)
					{
						return false;
					}
					if (this._en.MoveNext())
					{
						int remaining = this._remaining;
						this._remaining = remaining - 1;
						return remaining > 0;
					}
					return false;
				}

				// Token: 0x17001043 RID: 4163
				// (get) Token: 0x06005D63 RID: 23907 RVA: 0x0013A364 File Offset: 0x00138564
				public object Current
				{
					get
					{
						if (this._firstCall)
						{
							throw new InvalidOperationException("Enumeration has not started. Call MoveNext.");
						}
						if (this._remaining < 0)
						{
							throw new InvalidOperationException("Enumeration already finished.");
						}
						return this._en.Current;
					}
				}

				// Token: 0x06005D64 RID: 23908 RVA: 0x0013A398 File Offset: 0x00138598
				public void Reset()
				{
					this._en.Reset();
					int initialStartIndex = this._initialStartIndex;
					while (initialStartIndex-- > 0 && this._en.MoveNext())
					{
					}
					this._remaining = this._initialCount;
					this._firstCall = true;
				}

				// Token: 0x040038D7 RID: 14551
				private IEnumerator _en;

				// Token: 0x040038D8 RID: 14552
				private int _remaining;

				// Token: 0x040038D9 RID: 14553
				private int _initialStartIndex;

				// Token: 0x040038DA RID: 14554
				private int _initialCount;

				// Token: 0x040038DB RID: 14555
				private bool _firstCall;
			}
		}

		// Token: 0x02000A3E RID: 2622
		[Serializable]
		private class SyncArrayList : ArrayList
		{
			// Token: 0x06005D65 RID: 23909 RVA: 0x0013A3DF File Offset: 0x001385DF
			internal SyncArrayList(ArrayList list) : base(false)
			{
				this._list = list;
				this._root = list.SyncRoot;
			}

			// Token: 0x17001044 RID: 4164
			// (get) Token: 0x06005D66 RID: 23910 RVA: 0x0013A3FC File Offset: 0x001385FC
			// (set) Token: 0x06005D67 RID: 23911 RVA: 0x0013A444 File Offset: 0x00138644
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
				set
				{
					object root = this._root;
					lock (root)
					{
						this._list.Capacity = value;
					}
				}
			}

			// Token: 0x17001045 RID: 4165
			// (get) Token: 0x06005D68 RID: 23912 RVA: 0x0013A48C File Offset: 0x0013868C
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

			// Token: 0x17001046 RID: 4166
			// (get) Token: 0x06005D69 RID: 23913 RVA: 0x0013A4D4 File Offset: 0x001386D4
			public override bool IsReadOnly
			{
				get
				{
					return this._list.IsReadOnly;
				}
			}

			// Token: 0x17001047 RID: 4167
			// (get) Token: 0x06005D6A RID: 23914 RVA: 0x0013A4E1 File Offset: 0x001386E1
			public override bool IsFixedSize
			{
				get
				{
					return this._list.IsFixedSize;
				}
			}

			// Token: 0x17001048 RID: 4168
			// (get) Token: 0x06005D6B RID: 23915 RVA: 0x000040F7 File Offset: 0x000022F7
			public override bool IsSynchronized
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17001049 RID: 4169
			public override object this[int index]
			{
				get
				{
					object root = this._root;
					object result;
					lock (root)
					{
						result = this._list[index];
					}
					return result;
				}
				set
				{
					object root = this._root;
					lock (root)
					{
						this._list[index] = value;
					}
				}
			}

			// Token: 0x1700104A RID: 4170
			// (get) Token: 0x06005D6E RID: 23918 RVA: 0x0013A580 File Offset: 0x00138780
			public override object SyncRoot
			{
				get
				{
					return this._root;
				}
			}

			// Token: 0x06005D6F RID: 23919 RVA: 0x0013A588 File Offset: 0x00138788
			public override int Add(object value)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.Add(value);
				}
				return result;
			}

			// Token: 0x06005D70 RID: 23920 RVA: 0x0013A5D0 File Offset: 0x001387D0
			public override void AddRange(ICollection c)
			{
				object root = this._root;
				lock (root)
				{
					this._list.AddRange(c);
				}
			}

			// Token: 0x06005D71 RID: 23921 RVA: 0x0013A618 File Offset: 0x00138818
			public override int BinarySearch(object value)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.BinarySearch(value);
				}
				return result;
			}

			// Token: 0x06005D72 RID: 23922 RVA: 0x0013A660 File Offset: 0x00138860
			public override int BinarySearch(object value, IComparer comparer)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.BinarySearch(value, comparer);
				}
				return result;
			}

			// Token: 0x06005D73 RID: 23923 RVA: 0x0013A6AC File Offset: 0x001388AC
			public override int BinarySearch(int index, int count, object value, IComparer comparer)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.BinarySearch(index, count, value, comparer);
				}
				return result;
			}

			// Token: 0x06005D74 RID: 23924 RVA: 0x0013A6F8 File Offset: 0x001388F8
			public override void Clear()
			{
				object root = this._root;
				lock (root)
				{
					this._list.Clear();
				}
			}

			// Token: 0x06005D75 RID: 23925 RVA: 0x0013A740 File Offset: 0x00138940
			public override object Clone()
			{
				object root = this._root;
				object result;
				lock (root)
				{
					result = new ArrayList.SyncArrayList((ArrayList)this._list.Clone());
				}
				return result;
			}

			// Token: 0x06005D76 RID: 23926 RVA: 0x0013A794 File Offset: 0x00138994
			public override bool Contains(object item)
			{
				object root = this._root;
				bool result;
				lock (root)
				{
					result = this._list.Contains(item);
				}
				return result;
			}

			// Token: 0x06005D77 RID: 23927 RVA: 0x0013A7DC File Offset: 0x001389DC
			public override void CopyTo(Array array)
			{
				object root = this._root;
				lock (root)
				{
					this._list.CopyTo(array);
				}
			}

			// Token: 0x06005D78 RID: 23928 RVA: 0x0013A824 File Offset: 0x00138A24
			public override void CopyTo(Array array, int index)
			{
				object root = this._root;
				lock (root)
				{
					this._list.CopyTo(array, index);
				}
			}

			// Token: 0x06005D79 RID: 23929 RVA: 0x0013A86C File Offset: 0x00138A6C
			public override void CopyTo(int index, Array array, int arrayIndex, int count)
			{
				object root = this._root;
				lock (root)
				{
					this._list.CopyTo(index, array, arrayIndex, count);
				}
			}

			// Token: 0x06005D7A RID: 23930 RVA: 0x0013A8B8 File Offset: 0x00138AB8
			public override IEnumerator GetEnumerator()
			{
				object root = this._root;
				IEnumerator enumerator;
				lock (root)
				{
					enumerator = this._list.GetEnumerator();
				}
				return enumerator;
			}

			// Token: 0x06005D7B RID: 23931 RVA: 0x0013A900 File Offset: 0x00138B00
			public override IEnumerator GetEnumerator(int index, int count)
			{
				object root = this._root;
				IEnumerator enumerator;
				lock (root)
				{
					enumerator = this._list.GetEnumerator(index, count);
				}
				return enumerator;
			}

			// Token: 0x06005D7C RID: 23932 RVA: 0x0013A94C File Offset: 0x00138B4C
			public override int IndexOf(object value)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.IndexOf(value);
				}
				return result;
			}

			// Token: 0x06005D7D RID: 23933 RVA: 0x0013A994 File Offset: 0x00138B94
			public override int IndexOf(object value, int startIndex)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.IndexOf(value, startIndex);
				}
				return result;
			}

			// Token: 0x06005D7E RID: 23934 RVA: 0x0013A9E0 File Offset: 0x00138BE0
			public override int IndexOf(object value, int startIndex, int count)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.IndexOf(value, startIndex, count);
				}
				return result;
			}

			// Token: 0x06005D7F RID: 23935 RVA: 0x0013AA2C File Offset: 0x00138C2C
			public override void Insert(int index, object value)
			{
				object root = this._root;
				lock (root)
				{
					this._list.Insert(index, value);
				}
			}

			// Token: 0x06005D80 RID: 23936 RVA: 0x0013AA74 File Offset: 0x00138C74
			public override void InsertRange(int index, ICollection c)
			{
				object root = this._root;
				lock (root)
				{
					this._list.InsertRange(index, c);
				}
			}

			// Token: 0x06005D81 RID: 23937 RVA: 0x0013AABC File Offset: 0x00138CBC
			public override int LastIndexOf(object value)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.LastIndexOf(value);
				}
				return result;
			}

			// Token: 0x06005D82 RID: 23938 RVA: 0x0013AB04 File Offset: 0x00138D04
			public override int LastIndexOf(object value, int startIndex)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.LastIndexOf(value, startIndex);
				}
				return result;
			}

			// Token: 0x06005D83 RID: 23939 RVA: 0x0013AB50 File Offset: 0x00138D50
			public override int LastIndexOf(object value, int startIndex, int count)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.LastIndexOf(value, startIndex, count);
				}
				return result;
			}

			// Token: 0x06005D84 RID: 23940 RVA: 0x0013AB9C File Offset: 0x00138D9C
			public override void Remove(object value)
			{
				object root = this._root;
				lock (root)
				{
					this._list.Remove(value);
				}
			}

			// Token: 0x06005D85 RID: 23941 RVA: 0x0013ABE4 File Offset: 0x00138DE4
			public override void RemoveAt(int index)
			{
				object root = this._root;
				lock (root)
				{
					this._list.RemoveAt(index);
				}
			}

			// Token: 0x06005D86 RID: 23942 RVA: 0x0013AC2C File Offset: 0x00138E2C
			public override void RemoveRange(int index, int count)
			{
				object root = this._root;
				lock (root)
				{
					this._list.RemoveRange(index, count);
				}
			}

			// Token: 0x06005D87 RID: 23943 RVA: 0x0013AC74 File Offset: 0x00138E74
			public override void Reverse(int index, int count)
			{
				object root = this._root;
				lock (root)
				{
					this._list.Reverse(index, count);
				}
			}

			// Token: 0x06005D88 RID: 23944 RVA: 0x0013ACBC File Offset: 0x00138EBC
			public override void SetRange(int index, ICollection c)
			{
				object root = this._root;
				lock (root)
				{
					this._list.SetRange(index, c);
				}
			}

			// Token: 0x06005D89 RID: 23945 RVA: 0x0013AD04 File Offset: 0x00138F04
			public override ArrayList GetRange(int index, int count)
			{
				object root = this._root;
				ArrayList range;
				lock (root)
				{
					range = this._list.GetRange(index, count);
				}
				return range;
			}

			// Token: 0x06005D8A RID: 23946 RVA: 0x0013AD50 File Offset: 0x00138F50
			public override void Sort()
			{
				object root = this._root;
				lock (root)
				{
					this._list.Sort();
				}
			}

			// Token: 0x06005D8B RID: 23947 RVA: 0x0013AD98 File Offset: 0x00138F98
			public override void Sort(IComparer comparer)
			{
				object root = this._root;
				lock (root)
				{
					this._list.Sort(comparer);
				}
			}

			// Token: 0x06005D8C RID: 23948 RVA: 0x0013ADE0 File Offset: 0x00138FE0
			public override void Sort(int index, int count, IComparer comparer)
			{
				object root = this._root;
				lock (root)
				{
					this._list.Sort(index, count, comparer);
				}
			}

			// Token: 0x06005D8D RID: 23949 RVA: 0x0013AE28 File Offset: 0x00139028
			public override object[] ToArray()
			{
				object root = this._root;
				object[] result;
				lock (root)
				{
					result = this._list.ToArray();
				}
				return result;
			}

			// Token: 0x06005D8E RID: 23950 RVA: 0x0013AE70 File Offset: 0x00139070
			public override Array ToArray(Type type)
			{
				object root = this._root;
				Array result;
				lock (root)
				{
					result = this._list.ToArray(type);
				}
				return result;
			}

			// Token: 0x06005D8F RID: 23951 RVA: 0x0013AEB8 File Offset: 0x001390B8
			public override void TrimToSize()
			{
				object root = this._root;
				lock (root)
				{
					this._list.TrimToSize();
				}
			}

			// Token: 0x040038DC RID: 14556
			private ArrayList _list;

			// Token: 0x040038DD RID: 14557
			private object _root;
		}

		// Token: 0x02000A3F RID: 2623
		[Serializable]
		private class SyncIList : IList, ICollection, IEnumerable
		{
			// Token: 0x06005D90 RID: 23952 RVA: 0x0013AF00 File Offset: 0x00139100
			internal SyncIList(IList list)
			{
				this._list = list;
				this._root = list.SyncRoot;
			}

			// Token: 0x1700104B RID: 4171
			// (get) Token: 0x06005D91 RID: 23953 RVA: 0x0013AF1C File Offset: 0x0013911C
			public virtual int Count
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

			// Token: 0x1700104C RID: 4172
			// (get) Token: 0x06005D92 RID: 23954 RVA: 0x0013AF64 File Offset: 0x00139164
			public virtual bool IsReadOnly
			{
				get
				{
					return this._list.IsReadOnly;
				}
			}

			// Token: 0x1700104D RID: 4173
			// (get) Token: 0x06005D93 RID: 23955 RVA: 0x0013AF71 File Offset: 0x00139171
			public virtual bool IsFixedSize
			{
				get
				{
					return this._list.IsFixedSize;
				}
			}

			// Token: 0x1700104E RID: 4174
			// (get) Token: 0x06005D94 RID: 23956 RVA: 0x000040F7 File Offset: 0x000022F7
			public virtual bool IsSynchronized
			{
				get
				{
					return true;
				}
			}

			// Token: 0x1700104F RID: 4175
			public virtual object this[int index]
			{
				get
				{
					object root = this._root;
					object result;
					lock (root)
					{
						result = this._list[index];
					}
					return result;
				}
				set
				{
					object root = this._root;
					lock (root)
					{
						this._list[index] = value;
					}
				}
			}

			// Token: 0x17001050 RID: 4176
			// (get) Token: 0x06005D97 RID: 23959 RVA: 0x0013B010 File Offset: 0x00139210
			public virtual object SyncRoot
			{
				get
				{
					return this._root;
				}
			}

			// Token: 0x06005D98 RID: 23960 RVA: 0x0013B018 File Offset: 0x00139218
			public virtual int Add(object value)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.Add(value);
				}
				return result;
			}

			// Token: 0x06005D99 RID: 23961 RVA: 0x0013B060 File Offset: 0x00139260
			public virtual void Clear()
			{
				object root = this._root;
				lock (root)
				{
					this._list.Clear();
				}
			}

			// Token: 0x06005D9A RID: 23962 RVA: 0x0013B0A8 File Offset: 0x001392A8
			public virtual bool Contains(object item)
			{
				object root = this._root;
				bool result;
				lock (root)
				{
					result = this._list.Contains(item);
				}
				return result;
			}

			// Token: 0x06005D9B RID: 23963 RVA: 0x0013B0F0 File Offset: 0x001392F0
			public virtual void CopyTo(Array array, int index)
			{
				object root = this._root;
				lock (root)
				{
					this._list.CopyTo(array, index);
				}
			}

			// Token: 0x06005D9C RID: 23964 RVA: 0x0013B138 File Offset: 0x00139338
			public virtual IEnumerator GetEnumerator()
			{
				object root = this._root;
				IEnumerator enumerator;
				lock (root)
				{
					enumerator = this._list.GetEnumerator();
				}
				return enumerator;
			}

			// Token: 0x06005D9D RID: 23965 RVA: 0x0013B180 File Offset: 0x00139380
			public virtual int IndexOf(object value)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.IndexOf(value);
				}
				return result;
			}

			// Token: 0x06005D9E RID: 23966 RVA: 0x0013B1C8 File Offset: 0x001393C8
			public virtual void Insert(int index, object value)
			{
				object root = this._root;
				lock (root)
				{
					this._list.Insert(index, value);
				}
			}

			// Token: 0x06005D9F RID: 23967 RVA: 0x0013B210 File Offset: 0x00139410
			public virtual void Remove(object value)
			{
				object root = this._root;
				lock (root)
				{
					this._list.Remove(value);
				}
			}

			// Token: 0x06005DA0 RID: 23968 RVA: 0x0013B258 File Offset: 0x00139458
			public virtual void RemoveAt(int index)
			{
				object root = this._root;
				lock (root)
				{
					this._list.RemoveAt(index);
				}
			}

			// Token: 0x040038DE RID: 14558
			private IList _list;

			// Token: 0x040038DF RID: 14559
			private object _root;
		}

		// Token: 0x02000A40 RID: 2624
		[Serializable]
		private class FixedSizeList : IList, ICollection, IEnumerable
		{
			// Token: 0x06005DA1 RID: 23969 RVA: 0x0013B2A0 File Offset: 0x001394A0
			internal FixedSizeList(IList l)
			{
				this._list = l;
			}

			// Token: 0x17001051 RID: 4177
			// (get) Token: 0x06005DA2 RID: 23970 RVA: 0x0013B2AF File Offset: 0x001394AF
			public virtual int Count
			{
				get
				{
					return this._list.Count;
				}
			}

			// Token: 0x17001052 RID: 4178
			// (get) Token: 0x06005DA3 RID: 23971 RVA: 0x0013B2BC File Offset: 0x001394BC
			public virtual bool IsReadOnly
			{
				get
				{
					return this._list.IsReadOnly;
				}
			}

			// Token: 0x17001053 RID: 4179
			// (get) Token: 0x06005DA4 RID: 23972 RVA: 0x000040F7 File Offset: 0x000022F7
			public virtual bool IsFixedSize
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17001054 RID: 4180
			// (get) Token: 0x06005DA5 RID: 23973 RVA: 0x0013B2C9 File Offset: 0x001394C9
			public virtual bool IsSynchronized
			{
				get
				{
					return this._list.IsSynchronized;
				}
			}

			// Token: 0x17001055 RID: 4181
			public virtual object this[int index]
			{
				get
				{
					return this._list[index];
				}
				set
				{
					this._list[index] = value;
				}
			}

			// Token: 0x17001056 RID: 4182
			// (get) Token: 0x06005DA8 RID: 23976 RVA: 0x0013B2F3 File Offset: 0x001394F3
			public virtual object SyncRoot
			{
				get
				{
					return this._list.SyncRoot;
				}
			}

			// Token: 0x06005DA9 RID: 23977 RVA: 0x0004ED88 File Offset: 0x0004CF88
			public virtual int Add(object obj)
			{
				throw new NotSupportedException("Collection was of a fixed size.");
			}

			// Token: 0x06005DAA RID: 23978 RVA: 0x0004ED88 File Offset: 0x0004CF88
			public virtual void Clear()
			{
				throw new NotSupportedException("Collection was of a fixed size.");
			}

			// Token: 0x06005DAB RID: 23979 RVA: 0x0013B300 File Offset: 0x00139500
			public virtual bool Contains(object obj)
			{
				return this._list.Contains(obj);
			}

			// Token: 0x06005DAC RID: 23980 RVA: 0x0013B30E File Offset: 0x0013950E
			public virtual void CopyTo(Array array, int index)
			{
				this._list.CopyTo(array, index);
			}

			// Token: 0x06005DAD RID: 23981 RVA: 0x0013B31D File Offset: 0x0013951D
			public virtual IEnumerator GetEnumerator()
			{
				return this._list.GetEnumerator();
			}

			// Token: 0x06005DAE RID: 23982 RVA: 0x0013B32A File Offset: 0x0013952A
			public virtual int IndexOf(object value)
			{
				return this._list.IndexOf(value);
			}

			// Token: 0x06005DAF RID: 23983 RVA: 0x0004ED88 File Offset: 0x0004CF88
			public virtual void Insert(int index, object obj)
			{
				throw new NotSupportedException("Collection was of a fixed size.");
			}

			// Token: 0x06005DB0 RID: 23984 RVA: 0x0004ED88 File Offset: 0x0004CF88
			public virtual void Remove(object value)
			{
				throw new NotSupportedException("Collection was of a fixed size.");
			}

			// Token: 0x06005DB1 RID: 23985 RVA: 0x0004ED88 File Offset: 0x0004CF88
			public virtual void RemoveAt(int index)
			{
				throw new NotSupportedException("Collection was of a fixed size.");
			}

			// Token: 0x040038E0 RID: 14560
			private IList _list;
		}

		// Token: 0x02000A41 RID: 2625
		[Serializable]
		private class FixedSizeArrayList : ArrayList
		{
			// Token: 0x06005DB2 RID: 23986 RVA: 0x0013B338 File Offset: 0x00139538
			internal FixedSizeArrayList(ArrayList l)
			{
				this._list = l;
				this._version = this._list._version;
			}

			// Token: 0x17001057 RID: 4183
			// (get) Token: 0x06005DB3 RID: 23987 RVA: 0x0013B358 File Offset: 0x00139558
			public override int Count
			{
				get
				{
					return this._list.Count;
				}
			}

			// Token: 0x17001058 RID: 4184
			// (get) Token: 0x06005DB4 RID: 23988 RVA: 0x0013B365 File Offset: 0x00139565
			public override bool IsReadOnly
			{
				get
				{
					return this._list.IsReadOnly;
				}
			}

			// Token: 0x17001059 RID: 4185
			// (get) Token: 0x06005DB5 RID: 23989 RVA: 0x000040F7 File Offset: 0x000022F7
			public override bool IsFixedSize
			{
				get
				{
					return true;
				}
			}

			// Token: 0x1700105A RID: 4186
			// (get) Token: 0x06005DB6 RID: 23990 RVA: 0x0013B372 File Offset: 0x00139572
			public override bool IsSynchronized
			{
				get
				{
					return this._list.IsSynchronized;
				}
			}

			// Token: 0x1700105B RID: 4187
			public override object this[int index]
			{
				get
				{
					return this._list[index];
				}
				set
				{
					this._list[index] = value;
					this._version = this._list._version;
				}
			}

			// Token: 0x1700105C RID: 4188
			// (get) Token: 0x06005DB9 RID: 23993 RVA: 0x0013B3AD File Offset: 0x001395AD
			public override object SyncRoot
			{
				get
				{
					return this._list.SyncRoot;
				}
			}

			// Token: 0x06005DBA RID: 23994 RVA: 0x0004ED88 File Offset: 0x0004CF88
			public override int Add(object obj)
			{
				throw new NotSupportedException("Collection was of a fixed size.");
			}

			// Token: 0x06005DBB RID: 23995 RVA: 0x0004ED88 File Offset: 0x0004CF88
			public override void AddRange(ICollection c)
			{
				throw new NotSupportedException("Collection was of a fixed size.");
			}

			// Token: 0x06005DBC RID: 23996 RVA: 0x0013B3BA File Offset: 0x001395BA
			public override int BinarySearch(int index, int count, object value, IComparer comparer)
			{
				return this._list.BinarySearch(index, count, value, comparer);
			}

			// Token: 0x1700105D RID: 4189
			// (get) Token: 0x06005DBD RID: 23997 RVA: 0x0013B3CC File Offset: 0x001395CC
			// (set) Token: 0x06005DBE RID: 23998 RVA: 0x0004ED88 File Offset: 0x0004CF88
			public override int Capacity
			{
				get
				{
					return this._list.Capacity;
				}
				set
				{
					throw new NotSupportedException("Collection was of a fixed size.");
				}
			}

			// Token: 0x06005DBF RID: 23999 RVA: 0x0004ED88 File Offset: 0x0004CF88
			public override void Clear()
			{
				throw new NotSupportedException("Collection was of a fixed size.");
			}

			// Token: 0x06005DC0 RID: 24000 RVA: 0x0013B3D9 File Offset: 0x001395D9
			public override object Clone()
			{
				return new ArrayList.FixedSizeArrayList(this._list)
				{
					_list = (ArrayList)this._list.Clone()
				};
			}

			// Token: 0x06005DC1 RID: 24001 RVA: 0x0013B3FC File Offset: 0x001395FC
			public override bool Contains(object obj)
			{
				return this._list.Contains(obj);
			}

			// Token: 0x06005DC2 RID: 24002 RVA: 0x0013B40A File Offset: 0x0013960A
			public override void CopyTo(Array array, int index)
			{
				this._list.CopyTo(array, index);
			}

			// Token: 0x06005DC3 RID: 24003 RVA: 0x0013B419 File Offset: 0x00139619
			public override void CopyTo(int index, Array array, int arrayIndex, int count)
			{
				this._list.CopyTo(index, array, arrayIndex, count);
			}

			// Token: 0x06005DC4 RID: 24004 RVA: 0x0013B42B File Offset: 0x0013962B
			public override IEnumerator GetEnumerator()
			{
				return this._list.GetEnumerator();
			}

			// Token: 0x06005DC5 RID: 24005 RVA: 0x0013B438 File Offset: 0x00139638
			public override IEnumerator GetEnumerator(int index, int count)
			{
				return this._list.GetEnumerator(index, count);
			}

			// Token: 0x06005DC6 RID: 24006 RVA: 0x0013B447 File Offset: 0x00139647
			public override int IndexOf(object value)
			{
				return this._list.IndexOf(value);
			}

			// Token: 0x06005DC7 RID: 24007 RVA: 0x0013B455 File Offset: 0x00139655
			public override int IndexOf(object value, int startIndex)
			{
				return this._list.IndexOf(value, startIndex);
			}

			// Token: 0x06005DC8 RID: 24008 RVA: 0x0013B464 File Offset: 0x00139664
			public override int IndexOf(object value, int startIndex, int count)
			{
				return this._list.IndexOf(value, startIndex, count);
			}

			// Token: 0x06005DC9 RID: 24009 RVA: 0x0004ED88 File Offset: 0x0004CF88
			public override void Insert(int index, object obj)
			{
				throw new NotSupportedException("Collection was of a fixed size.");
			}

			// Token: 0x06005DCA RID: 24010 RVA: 0x0004ED88 File Offset: 0x0004CF88
			public override void InsertRange(int index, ICollection c)
			{
				throw new NotSupportedException("Collection was of a fixed size.");
			}

			// Token: 0x06005DCB RID: 24011 RVA: 0x0013B474 File Offset: 0x00139674
			public override int LastIndexOf(object value)
			{
				return this._list.LastIndexOf(value);
			}

			// Token: 0x06005DCC RID: 24012 RVA: 0x0013B482 File Offset: 0x00139682
			public override int LastIndexOf(object value, int startIndex)
			{
				return this._list.LastIndexOf(value, startIndex);
			}

			// Token: 0x06005DCD RID: 24013 RVA: 0x0013B491 File Offset: 0x00139691
			public override int LastIndexOf(object value, int startIndex, int count)
			{
				return this._list.LastIndexOf(value, startIndex, count);
			}

			// Token: 0x06005DCE RID: 24014 RVA: 0x0004ED88 File Offset: 0x0004CF88
			public override void Remove(object value)
			{
				throw new NotSupportedException("Collection was of a fixed size.");
			}

			// Token: 0x06005DCF RID: 24015 RVA: 0x0004ED88 File Offset: 0x0004CF88
			public override void RemoveAt(int index)
			{
				throw new NotSupportedException("Collection was of a fixed size.");
			}

			// Token: 0x06005DD0 RID: 24016 RVA: 0x0004ED88 File Offset: 0x0004CF88
			public override void RemoveRange(int index, int count)
			{
				throw new NotSupportedException("Collection was of a fixed size.");
			}

			// Token: 0x06005DD1 RID: 24017 RVA: 0x0013B4A1 File Offset: 0x001396A1
			public override void SetRange(int index, ICollection c)
			{
				this._list.SetRange(index, c);
				this._version = this._list._version;
			}

			// Token: 0x06005DD2 RID: 24018 RVA: 0x0013B4C4 File Offset: 0x001396C4
			public override ArrayList GetRange(int index, int count)
			{
				if (index < 0 || count < 0)
				{
					throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
				}
				if (this.Count - index < count)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				return new ArrayList.Range(this, index, count);
			}

			// Token: 0x06005DD3 RID: 24019 RVA: 0x0013B512 File Offset: 0x00139712
			public override void Reverse(int index, int count)
			{
				this._list.Reverse(index, count);
				this._version = this._list._version;
			}

			// Token: 0x06005DD4 RID: 24020 RVA: 0x0013B532 File Offset: 0x00139732
			public override void Sort(int index, int count, IComparer comparer)
			{
				this._list.Sort(index, count, comparer);
				this._version = this._list._version;
			}

			// Token: 0x06005DD5 RID: 24021 RVA: 0x0013B553 File Offset: 0x00139753
			public override object[] ToArray()
			{
				return this._list.ToArray();
			}

			// Token: 0x06005DD6 RID: 24022 RVA: 0x0013B560 File Offset: 0x00139760
			public override Array ToArray(Type type)
			{
				return this._list.ToArray(type);
			}

			// Token: 0x06005DD7 RID: 24023 RVA: 0x0004ED88 File Offset: 0x0004CF88
			public override void TrimToSize()
			{
				throw new NotSupportedException("Collection was of a fixed size.");
			}

			// Token: 0x040038E1 RID: 14561
			private ArrayList _list;
		}

		// Token: 0x02000A42 RID: 2626
		[Serializable]
		private class ReadOnlyList : IList, ICollection, IEnumerable
		{
			// Token: 0x06005DD8 RID: 24024 RVA: 0x0013B56E File Offset: 0x0013976E
			internal ReadOnlyList(IList l)
			{
				this._list = l;
			}

			// Token: 0x1700105E RID: 4190
			// (get) Token: 0x06005DD9 RID: 24025 RVA: 0x0013B57D File Offset: 0x0013977D
			public virtual int Count
			{
				get
				{
					return this._list.Count;
				}
			}

			// Token: 0x1700105F RID: 4191
			// (get) Token: 0x06005DDA RID: 24026 RVA: 0x000040F7 File Offset: 0x000022F7
			public virtual bool IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17001060 RID: 4192
			// (get) Token: 0x06005DDB RID: 24027 RVA: 0x000040F7 File Offset: 0x000022F7
			public virtual bool IsFixedSize
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17001061 RID: 4193
			// (get) Token: 0x06005DDC RID: 24028 RVA: 0x0013B58A File Offset: 0x0013978A
			public virtual bool IsSynchronized
			{
				get
				{
					return this._list.IsSynchronized;
				}
			}

			// Token: 0x17001062 RID: 4194
			public virtual object this[int index]
			{
				get
				{
					return this._list[index];
				}
				set
				{
					throw new NotSupportedException("Collection is read-only.");
				}
			}

			// Token: 0x17001063 RID: 4195
			// (get) Token: 0x06005DDF RID: 24031 RVA: 0x0013B5B1 File Offset: 0x001397B1
			public virtual object SyncRoot
			{
				get
				{
					return this._list.SyncRoot;
				}
			}

			// Token: 0x06005DE0 RID: 24032 RVA: 0x0013B5A5 File Offset: 0x001397A5
			public virtual int Add(object obj)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06005DE1 RID: 24033 RVA: 0x0013B5A5 File Offset: 0x001397A5
			public virtual void Clear()
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06005DE2 RID: 24034 RVA: 0x0013B5BE File Offset: 0x001397BE
			public virtual bool Contains(object obj)
			{
				return this._list.Contains(obj);
			}

			// Token: 0x06005DE3 RID: 24035 RVA: 0x0013B5CC File Offset: 0x001397CC
			public virtual void CopyTo(Array array, int index)
			{
				this._list.CopyTo(array, index);
			}

			// Token: 0x06005DE4 RID: 24036 RVA: 0x0013B5DB File Offset: 0x001397DB
			public virtual IEnumerator GetEnumerator()
			{
				return this._list.GetEnumerator();
			}

			// Token: 0x06005DE5 RID: 24037 RVA: 0x0013B5E8 File Offset: 0x001397E8
			public virtual int IndexOf(object value)
			{
				return this._list.IndexOf(value);
			}

			// Token: 0x06005DE6 RID: 24038 RVA: 0x0013B5A5 File Offset: 0x001397A5
			public virtual void Insert(int index, object obj)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06005DE7 RID: 24039 RVA: 0x0013B5A5 File Offset: 0x001397A5
			public virtual void Remove(object value)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06005DE8 RID: 24040 RVA: 0x0013B5A5 File Offset: 0x001397A5
			public virtual void RemoveAt(int index)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x040038E2 RID: 14562
			private IList _list;
		}

		// Token: 0x02000A43 RID: 2627
		[Serializable]
		private class ReadOnlyArrayList : ArrayList
		{
			// Token: 0x06005DE9 RID: 24041 RVA: 0x0013B5F6 File Offset: 0x001397F6
			internal ReadOnlyArrayList(ArrayList l)
			{
				this._list = l;
			}

			// Token: 0x17001064 RID: 4196
			// (get) Token: 0x06005DEA RID: 24042 RVA: 0x0013B605 File Offset: 0x00139805
			public override int Count
			{
				get
				{
					return this._list.Count;
				}
			}

			// Token: 0x17001065 RID: 4197
			// (get) Token: 0x06005DEB RID: 24043 RVA: 0x000040F7 File Offset: 0x000022F7
			public override bool IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17001066 RID: 4198
			// (get) Token: 0x06005DEC RID: 24044 RVA: 0x000040F7 File Offset: 0x000022F7
			public override bool IsFixedSize
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17001067 RID: 4199
			// (get) Token: 0x06005DED RID: 24045 RVA: 0x0013B612 File Offset: 0x00139812
			public override bool IsSynchronized
			{
				get
				{
					return this._list.IsSynchronized;
				}
			}

			// Token: 0x17001068 RID: 4200
			public override object this[int index]
			{
				get
				{
					return this._list[index];
				}
				set
				{
					throw new NotSupportedException("Collection is read-only.");
				}
			}

			// Token: 0x17001069 RID: 4201
			// (get) Token: 0x06005DF0 RID: 24048 RVA: 0x0013B62D File Offset: 0x0013982D
			public override object SyncRoot
			{
				get
				{
					return this._list.SyncRoot;
				}
			}

			// Token: 0x06005DF1 RID: 24049 RVA: 0x0013B5A5 File Offset: 0x001397A5
			public override int Add(object obj)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06005DF2 RID: 24050 RVA: 0x0013B5A5 File Offset: 0x001397A5
			public override void AddRange(ICollection c)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06005DF3 RID: 24051 RVA: 0x0013B63A File Offset: 0x0013983A
			public override int BinarySearch(int index, int count, object value, IComparer comparer)
			{
				return this._list.BinarySearch(index, count, value, comparer);
			}

			// Token: 0x1700106A RID: 4202
			// (get) Token: 0x06005DF4 RID: 24052 RVA: 0x0013B64C File Offset: 0x0013984C
			// (set) Token: 0x06005DF5 RID: 24053 RVA: 0x0013B5A5 File Offset: 0x001397A5
			public override int Capacity
			{
				get
				{
					return this._list.Capacity;
				}
				set
				{
					throw new NotSupportedException("Collection is read-only.");
				}
			}

			// Token: 0x06005DF6 RID: 24054 RVA: 0x0013B5A5 File Offset: 0x001397A5
			public override void Clear()
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06005DF7 RID: 24055 RVA: 0x0013B659 File Offset: 0x00139859
			public override object Clone()
			{
				return new ArrayList.ReadOnlyArrayList(this._list)
				{
					_list = (ArrayList)this._list.Clone()
				};
			}

			// Token: 0x06005DF8 RID: 24056 RVA: 0x0013B67C File Offset: 0x0013987C
			public override bool Contains(object obj)
			{
				return this._list.Contains(obj);
			}

			// Token: 0x06005DF9 RID: 24057 RVA: 0x0013B68A File Offset: 0x0013988A
			public override void CopyTo(Array array, int index)
			{
				this._list.CopyTo(array, index);
			}

			// Token: 0x06005DFA RID: 24058 RVA: 0x0013B699 File Offset: 0x00139899
			public override void CopyTo(int index, Array array, int arrayIndex, int count)
			{
				this._list.CopyTo(index, array, arrayIndex, count);
			}

			// Token: 0x06005DFB RID: 24059 RVA: 0x0013B6AB File Offset: 0x001398AB
			public override IEnumerator GetEnumerator()
			{
				return this._list.GetEnumerator();
			}

			// Token: 0x06005DFC RID: 24060 RVA: 0x0013B6B8 File Offset: 0x001398B8
			public override IEnumerator GetEnumerator(int index, int count)
			{
				return this._list.GetEnumerator(index, count);
			}

			// Token: 0x06005DFD RID: 24061 RVA: 0x0013B6C7 File Offset: 0x001398C7
			public override int IndexOf(object value)
			{
				return this._list.IndexOf(value);
			}

			// Token: 0x06005DFE RID: 24062 RVA: 0x0013B6D5 File Offset: 0x001398D5
			public override int IndexOf(object value, int startIndex)
			{
				return this._list.IndexOf(value, startIndex);
			}

			// Token: 0x06005DFF RID: 24063 RVA: 0x0013B6E4 File Offset: 0x001398E4
			public override int IndexOf(object value, int startIndex, int count)
			{
				return this._list.IndexOf(value, startIndex, count);
			}

			// Token: 0x06005E00 RID: 24064 RVA: 0x0013B5A5 File Offset: 0x001397A5
			public override void Insert(int index, object obj)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06005E01 RID: 24065 RVA: 0x0013B5A5 File Offset: 0x001397A5
			public override void InsertRange(int index, ICollection c)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06005E02 RID: 24066 RVA: 0x0013B6F4 File Offset: 0x001398F4
			public override int LastIndexOf(object value)
			{
				return this._list.LastIndexOf(value);
			}

			// Token: 0x06005E03 RID: 24067 RVA: 0x0013B702 File Offset: 0x00139902
			public override int LastIndexOf(object value, int startIndex)
			{
				return this._list.LastIndexOf(value, startIndex);
			}

			// Token: 0x06005E04 RID: 24068 RVA: 0x0013B711 File Offset: 0x00139911
			public override int LastIndexOf(object value, int startIndex, int count)
			{
				return this._list.LastIndexOf(value, startIndex, count);
			}

			// Token: 0x06005E05 RID: 24069 RVA: 0x0013B5A5 File Offset: 0x001397A5
			public override void Remove(object value)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06005E06 RID: 24070 RVA: 0x0013B5A5 File Offset: 0x001397A5
			public override void RemoveAt(int index)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06005E07 RID: 24071 RVA: 0x0013B5A5 File Offset: 0x001397A5
			public override void RemoveRange(int index, int count)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06005E08 RID: 24072 RVA: 0x0013B5A5 File Offset: 0x001397A5
			public override void SetRange(int index, ICollection c)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06005E09 RID: 24073 RVA: 0x0013B724 File Offset: 0x00139924
			public override ArrayList GetRange(int index, int count)
			{
				if (index < 0 || count < 0)
				{
					throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
				}
				if (this.Count - index < count)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				return new ArrayList.Range(this, index, count);
			}

			// Token: 0x06005E0A RID: 24074 RVA: 0x0013B5A5 File Offset: 0x001397A5
			public override void Reverse(int index, int count)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06005E0B RID: 24075 RVA: 0x0013B5A5 File Offset: 0x001397A5
			public override void Sort(int index, int count, IComparer comparer)
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x06005E0C RID: 24076 RVA: 0x0013B772 File Offset: 0x00139972
			public override object[] ToArray()
			{
				return this._list.ToArray();
			}

			// Token: 0x06005E0D RID: 24077 RVA: 0x0013B77F File Offset: 0x0013997F
			public override Array ToArray(Type type)
			{
				return this._list.ToArray(type);
			}

			// Token: 0x06005E0E RID: 24078 RVA: 0x0013B5A5 File Offset: 0x001397A5
			public override void TrimToSize()
			{
				throw new NotSupportedException("Collection is read-only.");
			}

			// Token: 0x040038E3 RID: 14563
			private ArrayList _list;
		}

		// Token: 0x02000A44 RID: 2628
		[Serializable]
		private sealed class ArrayListEnumerator : IEnumerator, ICloneable
		{
			// Token: 0x06005E0F RID: 24079 RVA: 0x0013B78D File Offset: 0x0013998D
			internal ArrayListEnumerator(ArrayList list, int index, int count)
			{
				this._list = list;
				this._startIndex = index;
				this._index = index - 1;
				this._endIndex = this._index + count;
				this._version = list._version;
				this._currentElement = null;
			}

			// Token: 0x06005E10 RID: 24080 RVA: 0x000231CD File Offset: 0x000213CD
			public object Clone()
			{
				return base.MemberwiseClone();
			}

			// Token: 0x06005E11 RID: 24081 RVA: 0x0013B7D0 File Offset: 0x001399D0
			public bool MoveNext()
			{
				if (this._version != this._list._version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				if (this._index < this._endIndex)
				{
					ArrayList list = this._list;
					int index = this._index + 1;
					this._index = index;
					this._currentElement = list[index];
					return true;
				}
				this._index = this._endIndex + 1;
				return false;
			}

			// Token: 0x1700106B RID: 4203
			// (get) Token: 0x06005E12 RID: 24082 RVA: 0x0013B83C File Offset: 0x00139A3C
			public object Current
			{
				get
				{
					if (this._index < this._startIndex)
					{
						throw new InvalidOperationException("Enumeration has not started. Call MoveNext.");
					}
					if (this._index > this._endIndex)
					{
						throw new InvalidOperationException("Enumeration already finished.");
					}
					return this._currentElement;
				}
			}

			// Token: 0x06005E13 RID: 24083 RVA: 0x0013B876 File Offset: 0x00139A76
			public void Reset()
			{
				if (this._version != this._list._version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				this._index = this._startIndex - 1;
			}

			// Token: 0x040038E4 RID: 14564
			private ArrayList _list;

			// Token: 0x040038E5 RID: 14565
			private int _index;

			// Token: 0x040038E6 RID: 14566
			private int _endIndex;

			// Token: 0x040038E7 RID: 14567
			private int _version;

			// Token: 0x040038E8 RID: 14568
			private object _currentElement;

			// Token: 0x040038E9 RID: 14569
			private int _startIndex;
		}

		// Token: 0x02000A45 RID: 2629
		[Serializable]
		private class Range : ArrayList
		{
			// Token: 0x06005E14 RID: 24084 RVA: 0x0013B8A4 File Offset: 0x00139AA4
			internal Range(ArrayList list, int index, int count) : base(false)
			{
				this._baseList = list;
				this._baseIndex = index;
				this._baseSize = count;
				this._baseVersion = list._version;
				this._version = list._version;
			}

			// Token: 0x06005E15 RID: 24085 RVA: 0x0013B8DA File Offset: 0x00139ADA
			private void InternalUpdateRange()
			{
				if (this._baseVersion != this._baseList._version)
				{
					throw new InvalidOperationException("This range in the underlying list is invalid. A possible cause is that elements were removed.");
				}
			}

			// Token: 0x06005E16 RID: 24086 RVA: 0x0013B8FA File Offset: 0x00139AFA
			private void InternalUpdateVersion()
			{
				this._baseVersion++;
				this._version++;
			}

			// Token: 0x06005E17 RID: 24087 RVA: 0x0013B918 File Offset: 0x00139B18
			public override int Add(object value)
			{
				this.InternalUpdateRange();
				this._baseList.Insert(this._baseIndex + this._baseSize, value);
				this.InternalUpdateVersion();
				int baseSize = this._baseSize;
				this._baseSize = baseSize + 1;
				return baseSize;
			}

			// Token: 0x06005E18 RID: 24088 RVA: 0x0013B95C File Offset: 0x00139B5C
			public override void AddRange(ICollection c)
			{
				if (c == null)
				{
					throw new ArgumentNullException("c");
				}
				this.InternalUpdateRange();
				int count = c.Count;
				if (count > 0)
				{
					this._baseList.InsertRange(this._baseIndex + this._baseSize, c);
					this.InternalUpdateVersion();
					this._baseSize += count;
				}
			}

			// Token: 0x06005E19 RID: 24089 RVA: 0x0013B9B8 File Offset: 0x00139BB8
			public override int BinarySearch(int index, int count, object value, IComparer comparer)
			{
				if (index < 0 || count < 0)
				{
					throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
				}
				if (this._baseSize - index < count)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				this.InternalUpdateRange();
				int num = this._baseList.BinarySearch(this._baseIndex + index, count, value, comparer);
				if (num >= 0)
				{
					return num - this._baseIndex;
				}
				return num + this._baseIndex;
			}

			// Token: 0x1700106C RID: 4204
			// (get) Token: 0x06005E1A RID: 24090 RVA: 0x0013BA31 File Offset: 0x00139C31
			// (set) Token: 0x06005E1B RID: 24091 RVA: 0x001399F8 File Offset: 0x00137BF8
			public override int Capacity
			{
				get
				{
					return this._baseList.Capacity;
				}
				set
				{
					if (value < this.Count)
					{
						throw new ArgumentOutOfRangeException("value", "capacity was less than the current size.");
					}
				}
			}

			// Token: 0x06005E1C RID: 24092 RVA: 0x0013BA3E File Offset: 0x00139C3E
			public override void Clear()
			{
				this.InternalUpdateRange();
				if (this._baseSize != 0)
				{
					this._baseList.RemoveRange(this._baseIndex, this._baseSize);
					this.InternalUpdateVersion();
					this._baseSize = 0;
				}
			}

			// Token: 0x06005E1D RID: 24093 RVA: 0x0013BA72 File Offset: 0x00139C72
			public override object Clone()
			{
				this.InternalUpdateRange();
				return new ArrayList.Range(this._baseList, this._baseIndex, this._baseSize)
				{
					_baseList = (ArrayList)this._baseList.Clone()
				};
			}

			// Token: 0x06005E1E RID: 24094 RVA: 0x0013BAA8 File Offset: 0x00139CA8
			public override bool Contains(object item)
			{
				this.InternalUpdateRange();
				if (item == null)
				{
					for (int i = 0; i < this._baseSize; i++)
					{
						if (this._baseList[this._baseIndex + i] == null)
						{
							return true;
						}
					}
					return false;
				}
				for (int j = 0; j < this._baseSize; j++)
				{
					if (this._baseList[this._baseIndex + j] != null && this._baseList[this._baseIndex + j].Equals(item))
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x06005E1F RID: 24095 RVA: 0x0013BB2C File Offset: 0x00139D2C
			public override void CopyTo(Array array, int index)
			{
				if (array == null)
				{
					throw new ArgumentNullException("array");
				}
				if (array.Rank != 1)
				{
					throw new ArgumentException("Only single dimensional arrays are supported for the requested action.", "array");
				}
				if (index < 0)
				{
					throw new ArgumentOutOfRangeException("index", "Non-negative number required.");
				}
				if (array.Length - index < this._baseSize)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				this.InternalUpdateRange();
				this._baseList.CopyTo(this._baseIndex, array, index, this._baseSize);
			}

			// Token: 0x06005E20 RID: 24096 RVA: 0x0013BBB0 File Offset: 0x00139DB0
			public override void CopyTo(int index, Array array, int arrayIndex, int count)
			{
				if (array == null)
				{
					throw new ArgumentNullException("array");
				}
				if (array.Rank != 1)
				{
					throw new ArgumentException("Only single dimensional arrays are supported for the requested action.", "array");
				}
				if (index < 0 || count < 0)
				{
					throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
				}
				if (array.Length - arrayIndex < count)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				if (this._baseSize - index < count)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				this.InternalUpdateRange();
				this._baseList.CopyTo(this._baseIndex + index, array, arrayIndex, count);
			}

			// Token: 0x1700106D RID: 4205
			// (get) Token: 0x06005E21 RID: 24097 RVA: 0x0013BC53 File Offset: 0x00139E53
			public override int Count
			{
				get
				{
					this.InternalUpdateRange();
					return this._baseSize;
				}
			}

			// Token: 0x1700106E RID: 4206
			// (get) Token: 0x06005E22 RID: 24098 RVA: 0x0013BC61 File Offset: 0x00139E61
			public override bool IsReadOnly
			{
				get
				{
					return this._baseList.IsReadOnly;
				}
			}

			// Token: 0x1700106F RID: 4207
			// (get) Token: 0x06005E23 RID: 24099 RVA: 0x0013BC6E File Offset: 0x00139E6E
			public override bool IsFixedSize
			{
				get
				{
					return this._baseList.IsFixedSize;
				}
			}

			// Token: 0x17001070 RID: 4208
			// (get) Token: 0x06005E24 RID: 24100 RVA: 0x0013BC7B File Offset: 0x00139E7B
			public override bool IsSynchronized
			{
				get
				{
					return this._baseList.IsSynchronized;
				}
			}

			// Token: 0x06005E25 RID: 24101 RVA: 0x0013BC88 File Offset: 0x00139E88
			public override IEnumerator GetEnumerator()
			{
				return this.GetEnumerator(0, this._baseSize);
			}

			// Token: 0x06005E26 RID: 24102 RVA: 0x0013BC98 File Offset: 0x00139E98
			public override IEnumerator GetEnumerator(int index, int count)
			{
				if (index < 0 || count < 0)
				{
					throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
				}
				if (this._baseSize - index < count)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				this.InternalUpdateRange();
				return this._baseList.GetEnumerator(this._baseIndex + index, count);
			}

			// Token: 0x06005E27 RID: 24103 RVA: 0x0013BCF8 File Offset: 0x00139EF8
			public override ArrayList GetRange(int index, int count)
			{
				if (index < 0 || count < 0)
				{
					throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
				}
				if (this._baseSize - index < count)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				this.InternalUpdateRange();
				return new ArrayList.Range(this, index, count);
			}

			// Token: 0x17001071 RID: 4209
			// (get) Token: 0x06005E28 RID: 24104 RVA: 0x0013BD4C File Offset: 0x00139F4C
			public override object SyncRoot
			{
				get
				{
					return this._baseList.SyncRoot;
				}
			}

			// Token: 0x06005E29 RID: 24105 RVA: 0x0013BD5C File Offset: 0x00139F5C
			public override int IndexOf(object value)
			{
				this.InternalUpdateRange();
				int num = this._baseList.IndexOf(value, this._baseIndex, this._baseSize);
				if (num >= 0)
				{
					return num - this._baseIndex;
				}
				return -1;
			}

			// Token: 0x06005E2A RID: 24106 RVA: 0x0013BD98 File Offset: 0x00139F98
			public override int IndexOf(object value, int startIndex)
			{
				if (startIndex < 0)
				{
					throw new ArgumentOutOfRangeException("startIndex", "Non-negative number required.");
				}
				if (startIndex > this._baseSize)
				{
					throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				this.InternalUpdateRange();
				int num = this._baseList.IndexOf(value, this._baseIndex + startIndex, this._baseSize - startIndex);
				if (num >= 0)
				{
					return num - this._baseIndex;
				}
				return -1;
			}

			// Token: 0x06005E2B RID: 24107 RVA: 0x0013BE04 File Offset: 0x0013A004
			public override int IndexOf(object value, int startIndex, int count)
			{
				if (startIndex < 0 || startIndex > this._baseSize)
				{
					throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				if (count < 0 || startIndex > this._baseSize - count)
				{
					throw new ArgumentOutOfRangeException("count", "Count must be positive and count must refer to a location within the string/array/collection.");
				}
				this.InternalUpdateRange();
				int num = this._baseList.IndexOf(value, this._baseIndex + startIndex, count);
				if (num >= 0)
				{
					return num - this._baseIndex;
				}
				return -1;
			}

			// Token: 0x06005E2C RID: 24108 RVA: 0x0013BE78 File Offset: 0x0013A078
			public override void Insert(int index, object value)
			{
				if (index < 0 || index > this._baseSize)
				{
					throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				this.InternalUpdateRange();
				this._baseList.Insert(this._baseIndex + index, value);
				this.InternalUpdateVersion();
				this._baseSize++;
			}

			// Token: 0x06005E2D RID: 24109 RVA: 0x0013BED0 File Offset: 0x0013A0D0
			public override void InsertRange(int index, ICollection c)
			{
				if (index < 0 || index > this._baseSize)
				{
					throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				if (c == null)
				{
					throw new ArgumentNullException("c");
				}
				this.InternalUpdateRange();
				int count = c.Count;
				if (count > 0)
				{
					this._baseList.InsertRange(this._baseIndex + index, c);
					this._baseSize += count;
					this.InternalUpdateVersion();
				}
			}

			// Token: 0x06005E2E RID: 24110 RVA: 0x0013BF44 File Offset: 0x0013A144
			public override int LastIndexOf(object value)
			{
				this.InternalUpdateRange();
				int num = this._baseList.LastIndexOf(value, this._baseIndex + this._baseSize - 1, this._baseSize);
				if (num >= 0)
				{
					return num - this._baseIndex;
				}
				return -1;
			}

			// Token: 0x06005E2F RID: 24111 RVA: 0x00139E4A File Offset: 0x0013804A
			public override int LastIndexOf(object value, int startIndex)
			{
				return this.LastIndexOf(value, startIndex, startIndex + 1);
			}

			// Token: 0x06005E30 RID: 24112 RVA: 0x0013BF88 File Offset: 0x0013A188
			public override int LastIndexOf(object value, int startIndex, int count)
			{
				this.InternalUpdateRange();
				if (this._baseSize == 0)
				{
					return -1;
				}
				if (startIndex >= this._baseSize)
				{
					throw new ArgumentOutOfRangeException("startIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				if (startIndex < 0)
				{
					throw new ArgumentOutOfRangeException("startIndex", "Non-negative number required.");
				}
				int num = this._baseList.LastIndexOf(value, this._baseIndex + startIndex, count);
				if (num >= 0)
				{
					return num - this._baseIndex;
				}
				return -1;
			}

			// Token: 0x06005E31 RID: 24113 RVA: 0x0013BFF8 File Offset: 0x0013A1F8
			public override void RemoveAt(int index)
			{
				if (index < 0 || index >= this._baseSize)
				{
					throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				this.InternalUpdateRange();
				this._baseList.RemoveAt(this._baseIndex + index);
				this.InternalUpdateVersion();
				this._baseSize--;
			}

			// Token: 0x06005E32 RID: 24114 RVA: 0x0013C050 File Offset: 0x0013A250
			public override void RemoveRange(int index, int count)
			{
				if (index < 0 || count < 0)
				{
					throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
				}
				if (this._baseSize - index < count)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				this.InternalUpdateRange();
				if (count > 0)
				{
					this._baseList.RemoveRange(this._baseIndex + index, count);
					this.InternalUpdateVersion();
					this._baseSize -= count;
				}
			}

			// Token: 0x06005E33 RID: 24115 RVA: 0x0013C0C8 File Offset: 0x0013A2C8
			public override void Reverse(int index, int count)
			{
				if (index < 0 || count < 0)
				{
					throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
				}
				if (this._baseSize - index < count)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				this.InternalUpdateRange();
				this._baseList.Reverse(this._baseIndex + index, count);
				this.InternalUpdateVersion();
			}

			// Token: 0x06005E34 RID: 24116 RVA: 0x0013C130 File Offset: 0x0013A330
			public override void SetRange(int index, ICollection c)
			{
				this.InternalUpdateRange();
				if (index < 0 || index >= this._baseSize)
				{
					throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				this._baseList.SetRange(this._baseIndex + index, c);
				if (c.Count > 0)
				{
					this.InternalUpdateVersion();
				}
			}

			// Token: 0x06005E35 RID: 24117 RVA: 0x0013C184 File Offset: 0x0013A384
			public override void Sort(int index, int count, IComparer comparer)
			{
				if (index < 0 || count < 0)
				{
					throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
				}
				if (this._baseSize - index < count)
				{
					throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
				}
				this.InternalUpdateRange();
				this._baseList.Sort(this._baseIndex + index, count, comparer);
				this.InternalUpdateVersion();
			}

			// Token: 0x17001072 RID: 4210
			public override object this[int index]
			{
				get
				{
					this.InternalUpdateRange();
					if (index < 0 || index >= this._baseSize)
					{
						throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
					}
					return this._baseList[this._baseIndex + index];
				}
				set
				{
					this.InternalUpdateRange();
					if (index < 0 || index >= this._baseSize)
					{
						throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
					}
					this._baseList[this._baseIndex + index] = value;
					this.InternalUpdateVersion();
				}
			}

			// Token: 0x06005E38 RID: 24120 RVA: 0x0013C264 File Offset: 0x0013A464
			public override object[] ToArray()
			{
				this.InternalUpdateRange();
				if (this._baseSize == 0)
				{
					return Array.Empty<object>();
				}
				object[] array = new object[this._baseSize];
				Array.Copy(this._baseList._items, this._baseIndex, array, 0, this._baseSize);
				return array;
			}

			// Token: 0x06005E39 RID: 24121 RVA: 0x0013C2B0 File Offset: 0x0013A4B0
			public override Array ToArray(Type type)
			{
				if (type == null)
				{
					throw new ArgumentNullException("type");
				}
				this.InternalUpdateRange();
				Array array = Array.CreateInstance(type, this._baseSize);
				this._baseList.CopyTo(this._baseIndex, array, 0, this._baseSize);
				return array;
			}

			// Token: 0x06005E3A RID: 24122 RVA: 0x0013C2FE File Offset: 0x0013A4FE
			public override void TrimToSize()
			{
				throw new NotSupportedException("The specified operation is not supported on Ranges.");
			}

			// Token: 0x040038EA RID: 14570
			private ArrayList _baseList;

			// Token: 0x040038EB RID: 14571
			private int _baseIndex;

			// Token: 0x040038EC RID: 14572
			private int _baseSize;

			// Token: 0x040038ED RID: 14573
			private int _baseVersion;
		}

		// Token: 0x02000A46 RID: 2630
		[Serializable]
		private sealed class ArrayListEnumeratorSimple : IEnumerator, ICloneable
		{
			// Token: 0x06005E3B RID: 24123 RVA: 0x0013C30C File Offset: 0x0013A50C
			internal ArrayListEnumeratorSimple(ArrayList list)
			{
				this._list = list;
				this._index = -1;
				this._version = list._version;
				this._isArrayList = (list.GetType() == typeof(ArrayList));
				this._currentElement = ArrayList.ArrayListEnumeratorSimple.s_dummyObject;
			}

			// Token: 0x06005E3C RID: 24124 RVA: 0x000231CD File Offset: 0x000213CD
			public object Clone()
			{
				return base.MemberwiseClone();
			}

			// Token: 0x06005E3D RID: 24125 RVA: 0x0013C360 File Offset: 0x0013A560
			public bool MoveNext()
			{
				if (this._version != this._list._version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				if (this._isArrayList)
				{
					if (this._index < this._list._size - 1)
					{
						object[] items = this._list._items;
						int num = this._index + 1;
						this._index = num;
						this._currentElement = items[num];
						return true;
					}
					this._currentElement = ArrayList.ArrayListEnumeratorSimple.s_dummyObject;
					this._index = this._list._size;
					return false;
				}
				else
				{
					if (this._index < this._list.Count - 1)
					{
						ArrayList list = this._list;
						int num = this._index + 1;
						this._index = num;
						this._currentElement = list[num];
						return true;
					}
					this._index = this._list.Count;
					this._currentElement = ArrayList.ArrayListEnumeratorSimple.s_dummyObject;
					return false;
				}
			}

			// Token: 0x17001073 RID: 4211
			// (get) Token: 0x06005E3E RID: 24126 RVA: 0x0013C444 File Offset: 0x0013A644
			public object Current
			{
				get
				{
					object currentElement = this._currentElement;
					if (ArrayList.ArrayListEnumeratorSimple.s_dummyObject != currentElement)
					{
						return currentElement;
					}
					if (this._index == -1)
					{
						throw new InvalidOperationException("Enumeration has not started. Call MoveNext.");
					}
					throw new InvalidOperationException("Enumeration already finished.");
				}
			}

			// Token: 0x06005E3F RID: 24127 RVA: 0x0013C480 File Offset: 0x0013A680
			public void Reset()
			{
				if (this._version != this._list._version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				this._currentElement = ArrayList.ArrayListEnumeratorSimple.s_dummyObject;
				this._index = -1;
			}

			// Token: 0x040038EE RID: 14574
			private ArrayList _list;

			// Token: 0x040038EF RID: 14575
			private int _index;

			// Token: 0x040038F0 RID: 14576
			private int _version;

			// Token: 0x040038F1 RID: 14577
			private object _currentElement;

			// Token: 0x040038F2 RID: 14578
			private bool _isArrayList;

			// Token: 0x040038F3 RID: 14579
			private static object s_dummyObject = new object();
		}

		// Token: 0x02000A47 RID: 2631
		internal class ArrayListDebugView
		{
			// Token: 0x06005E41 RID: 24129 RVA: 0x0013C4BE File Offset: 0x0013A6BE
			public ArrayListDebugView(ArrayList arrayList)
			{
				if (arrayList == null)
				{
					throw new ArgumentNullException("arrayList");
				}
				this._arrayList = arrayList;
			}

			// Token: 0x17001074 RID: 4212
			// (get) Token: 0x06005E42 RID: 24130 RVA: 0x0013C4DB File Offset: 0x0013A6DB
			[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
			public object[] Items
			{
				get
				{
					return this._arrayList.ToArray();
				}
			}

			// Token: 0x040038F4 RID: 14580
			private ArrayList _arrayList;
		}
	}
}
