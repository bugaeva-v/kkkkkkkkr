using System;

namespace System.Collections
{
	/// <summary>Предоставляет базовый класс <see langword="abstract" /> для строго типизированной коллекции.</summary>
	// Token: 0x02000A24 RID: 2596
	[Serializable]
	public abstract class CollectionBase : IList, ICollection, IEnumerable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.CollectionBase" /> с начальной емкостью по умолчанию.</summary>
		// Token: 0x06005BD8 RID: 23512 RVA: 0x00135555 File Offset: 0x00133755
		protected CollectionBase()
		{
			this._list = new ArrayList();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.CollectionBase" /> с указанной емкостью.</summary>
		/// <param name="capacity">Число элементов, которые может изначально вместить новый список.</param>
		// Token: 0x06005BD9 RID: 23513 RVA: 0x00135568 File Offset: 0x00133768
		protected CollectionBase(int capacity)
		{
			this._list = new ArrayList(capacity);
		}

		/// <summary>Возвращает объект <see cref="T:System.Collections.ArrayList" />, в котором хранится список элементов экземпляра класса <see cref="T:System.Collections.CollectionBase" />.</summary>
		/// <returns>Класс <see cref="T:System.Collections.ArrayList" />, предоставляющий экземпляр класса <see cref="T:System.Collections.CollectionBase" />.  
		/// Получение значения данного свойства является операцией порядка сложности O(1).</returns>
		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x06005BDA RID: 23514 RVA: 0x0013557C File Offset: 0x0013377C
		protected ArrayList InnerList
		{
			get
			{
				return this._list;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Collections.IList" />, в котором хранится список элементов экземпляра класса <see cref="T:System.Collections.CollectionBase" />.</summary>
		/// <returns>Класс <see cref="T:System.Collections.IList" />, предоставляющий экземпляр класса <see cref="T:System.Collections.CollectionBase" />.</returns>
		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x06005BDB RID: 23515 RVA: 0x0000270D File Offset: 0x0000090D
		protected IList List
		{
			get
			{
				return this;
			}
		}

		/// <summary>Возвращает или задает число элементов, которое может содержать список <see cref="T:System.Collections.CollectionBase" />.</summary>
		/// <returns>Количество элементов, которое может содержать коллекция <see cref="T:System.Collections.CollectionBase" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Для <see cref="P:System.Collections.CollectionBase.Capacity" /> установлено значение, которое меньше <see cref="P:System.Collections.CollectionBase.Count" />.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти в системе.</exception>
		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x06005BDC RID: 23516 RVA: 0x00135584 File Offset: 0x00133784
		// (set) Token: 0x06005BDD RID: 23517 RVA: 0x00135591 File Offset: 0x00133791
		public int Capacity
		{
			get
			{
				return this.InnerList.Capacity;
			}
			set
			{
				this.InnerList.Capacity = value;
			}
		}

		/// <summary>Получает число элементов, содержащихся в экземпляре класса <see cref="T:System.Collections.CollectionBase" />. Это свойство нельзя переопределить.</summary>
		/// <returns>Число элементов, содержащихся в экземпляре класса <see cref="T:System.Collections.CollectionBase" />.  
		/// Получение значения данного свойства является операцией порядка сложности O(1).</returns>
		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x06005BDE RID: 23518 RVA: 0x0013559F File Offset: 0x0013379F
		public int Count
		{
			get
			{
				return this._list.Count;
			}
		}

		/// <summary>Удаляет все объекты из экземпляра класса <see cref="T:System.Collections.CollectionBase" />. Этот метод не может быть переопределен.</summary>
		// Token: 0x06005BDF RID: 23519 RVA: 0x001355AC File Offset: 0x001337AC
		public void Clear()
		{
			this.OnClear();
			this.InnerList.Clear();
			this.OnClearComplete();
		}

		/// <summary>Удаляет элемент по указанному индексу в экземпляре класса <see cref="T:System.Collections.CollectionBase" />. Этот метод нельзя переопределить.</summary>
		/// <param name="index">Индекс (с нуля) элемента, который требуется удалить.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		///
		/// или - 
		/// Значение параметра <paramref name="index" /> больше или равно значению свойства <see cref="P:System.Collections.CollectionBase.Count" />.</exception>
		// Token: 0x06005BE0 RID: 23520 RVA: 0x001355C8 File Offset: 0x001337C8
		public void RemoveAt(int index)
		{
			if (index < 0 || index >= this.Count)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			object value = this.InnerList[index];
			this.OnValidate(value);
			this.OnRemove(index, value);
			this.InnerList.RemoveAt(index);
			try
			{
				this.OnRemoveComplete(index, value);
			}
			catch
			{
				this.InnerList.Insert(index, value);
				throw;
			}
		}

		/// <summary>Получает значение, указывающее, является ли объект <see cref="T:System.Collections.CollectionBase" /> доступным только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если интерфейс <see cref="T:System.Collections.CollectionBase" /> доступен только для чтения; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x06005BE1 RID: 23521 RVA: 0x00135644 File Offset: 0x00133844
		bool IList.IsReadOnly
		{
			get
			{
				return this.InnerList.IsReadOnly;
			}
		}

		/// <summary>Получает значение, указывающее, имеет ли список <see cref="T:System.Collections.CollectionBase" /> фиксированный размер.</summary>
		/// <returns>Значение <see langword="true" />, если словарь <see cref="T:System.Collections.CollectionBase" /> имеет фиксированный размер; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x06005BE2 RID: 23522 RVA: 0x00135651 File Offset: 0x00133851
		bool IList.IsFixedSize
		{
			get
			{
				return this.InnerList.IsFixedSize;
			}
		}

		/// <summary>Возвращает значение, показывающее, является ли доступ к коллекции <see cref="T:System.Collections.CollectionBase" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>
		///   <see langword="true" />, если доступ к классу <see cref="T:System.Collections.CollectionBase" /> является синхронизированным (потокобезопасным); в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x06005BE3 RID: 23523 RVA: 0x0013565E File Offset: 0x0013385E
		bool ICollection.IsSynchronized
		{
			get
			{
				return this.InnerList.IsSynchronized;
			}
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.CollectionBase" />.</summary>
		/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Collections.CollectionBase" />.</returns>
		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x06005BE4 RID: 23524 RVA: 0x0013566B File Offset: 0x0013386B
		object ICollection.SyncRoot
		{
			get
			{
				return this.InnerList.SyncRoot;
			}
		}

		/// <summary>Копирует целый массив <see cref="T:System.Collections.CollectionBase" /> в совместимый одномерный массив <see cref="T:System.Array" />, начиная с заданного индекса целевого массива.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из интерфейса <see cref="T:System.Collections.CollectionBase" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		///
		/// или - 
		/// Число элементов в исходном массиве <see cref="T:System.Collections.CollectionBase" /> больше возможного для размещения числа элементов от положения, заданного значением параметра <paramref name="index" />, до конца массива назначения <paramref name="array" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Тип исходного массива <see cref="T:System.Collections.CollectionBase" /> не может быть автоматически приведен к типу массива назначения <paramref name="array" />.</exception>
		// Token: 0x06005BE5 RID: 23525 RVA: 0x00135678 File Offset: 0x00133878
		void ICollection.CopyTo(Array array, int index)
		{
			this.InnerList.CopyTo(array, index);
		}

		/// <summary>Возвращает или задает элемент по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс элемента, который требуется возвратить или задать.</param>
		/// <returns>Элемент, расположенный по указанному индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		///
		/// или - 
		/// Значение параметра <paramref name="index" /> больше или равно значению свойства <see cref="P:System.Collections.CollectionBase.Count" />.</exception>
		// Token: 0x17000FEC RID: 4076
		object IList.this[int index]
		{
			get
			{
				if (index < 0 || index >= this.Count)
				{
					throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				return this.InnerList[index];
			}
			set
			{
				if (index < 0 || index >= this.Count)
				{
					throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
				}
				this.OnValidate(value);
				object obj = this.InnerList[index];
				this.OnSet(index, obj, value);
				this.InnerList[index] = value;
				try
				{
					this.OnSetComplete(index, obj, value);
				}
				catch
				{
					this.InnerList[index] = obj;
					throw;
				}
			}
		}

		/// <summary>Определяет, содержит ли интерфейс <see cref="T:System.Collections.CollectionBase" /> определенный элемент.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, который требуется найти в коллекции <see cref="T:System.Collections.CollectionBase" />.</param>
		/// <returns>Значение <see langword="true" />, если коллекция <see cref="T:System.Collections.CollectionBase" /> содержит заданный объект <paramref name="value" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06005BE8 RID: 23528 RVA: 0x00135734 File Offset: 0x00133934
		bool IList.Contains(object value)
		{
			return this.InnerList.Contains(value);
		}

		/// <summary>Добавляет объект в конец очереди <see cref="T:System.Collections.CollectionBase" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, добавляемый в конец коллекции <see cref="T:System.Collections.CollectionBase" />.</param>
		/// <returns>Индекс <see cref="T:System.Collections.CollectionBase" />, по которому добавлен параметр <paramref name="value" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.CollectionBase" /> доступен только для чтения.  
		///
		/// или - 
		/// <see cref="T:System.Collections.CollectionBase" /> имеет фиксированный размер.</exception>
		// Token: 0x06005BE9 RID: 23529 RVA: 0x00135744 File Offset: 0x00133944
		int IList.Add(object value)
		{
			this.OnValidate(value);
			this.OnInsert(this.InnerList.Count, value);
			int num = this.InnerList.Add(value);
			try
			{
				this.OnInsertComplete(num, value);
			}
			catch
			{
				this.InnerList.RemoveAt(num);
				throw;
			}
			return num;
		}

		/// <summary>Удаляет первое вхождение указанного объекта из коллекции <see cref="T:System.Collections.CollectionBase" />.</summary>
		/// <param name="value">Элемент <see cref="T:System.Object" />, который требуется удалить из <see cref="T:System.Collections.CollectionBase" />.</param>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="value" /> не найдено в объекте <see cref="T:System.Collections.CollectionBase" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.CollectionBase" /> доступен только для чтения.  
		///
		/// или - 
		/// <see cref="T:System.Collections.CollectionBase" /> имеет фиксированный размер.</exception>
		// Token: 0x06005BEA RID: 23530 RVA: 0x001357A4 File Offset: 0x001339A4
		void IList.Remove(object value)
		{
			this.OnValidate(value);
			int num = this.InnerList.IndexOf(value);
			if (num < 0)
			{
				throw new ArgumentException("Cannot remove the specified item because it was not found in the specified Collection.");
			}
			this.OnRemove(num, value);
			this.InnerList.RemoveAt(num);
			try
			{
				this.OnRemoveComplete(num, value);
			}
			catch
			{
				this.InnerList.Insert(num, value);
				throw;
			}
		}

		/// <summary>Осуществляет поиск указанного объекта <see cref="T:System.Object" /> и возвращает отсчитываемый от нуля индекс первого вхождения в коллекцию <see cref="T:System.Collections.CollectionBase" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, который требуется найти в коллекции <see cref="T:System.Collections.CollectionBase" />.</param>
		/// <returns>Индекс (с нуля) первого вхождения параметра <paramref name="value" />, если оно найдено в коллекции <see cref="T:System.Collections.CollectionBase" />; в противном случае -1.</returns>
		// Token: 0x06005BEB RID: 23531 RVA: 0x00135814 File Offset: 0x00133A14
		int IList.IndexOf(object value)
		{
			return this.InnerList.IndexOf(value);
		}

		/// <summary>Вставляет элемент в коллекцию <see cref="T:System.Collections.CollectionBase" /> по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс, по которому следует вставить элемент <paramref name="value" />.</param>
		/// <param name="value">Вставляемый объект <see cref="T:System.Object" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		///
		/// или - 
		/// Значение <paramref name="index" /> больше значения <see cref="P:System.Collections.CollectionBase.Count" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.CollectionBase" /> доступен только для чтения.  
		///
		/// или - 
		/// <see cref="T:System.Collections.CollectionBase" /> имеет фиксированный размер.</exception>
		// Token: 0x06005BEC RID: 23532 RVA: 0x00135824 File Offset: 0x00133A24
		void IList.Insert(int index, object value)
		{
			if (index < 0 || index > this.Count)
			{
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			this.OnValidate(value);
			this.OnInsert(index, value);
			this.InnerList.Insert(index, value);
			try
			{
				this.OnInsertComplete(index, value);
			}
			catch
			{
				this.InnerList.RemoveAt(index);
				throw;
			}
		}

		/// <summary>Возвращает перечислитель, перебирающий элементы экземпляра класса <see cref="T:System.Collections.CollectionBase" />.</summary>
		/// <returns>Перечислитель <see cref="T:System.Collections.IEnumerator" /> для экземпляра класса <see cref="T:System.Collections.CollectionBase" />.</returns>
		// Token: 0x06005BED RID: 23533 RVA: 0x00135894 File Offset: 0x00133A94
		public IEnumerator GetEnumerator()
		{
			return this.InnerList.GetEnumerator();
		}

		/// <summary>Выполняет дополнительные пользовательские действия перед заданием значения в экземпляре класса <see cref="T:System.Collections.CollectionBase" />.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс, по которому может быть найдено значение <paramref name="oldValue" />.</param>
		/// <param name="oldValue">Значение, которое требуется заменить на <paramref name="newValue" />.</param>
		/// <param name="newValue">Новое значение элемента по индексу <paramref name="index" />.</param>
		// Token: 0x06005BEE RID: 23534 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void OnSet(int index, object oldValue, object newValue)
		{
		}

		/// <summary>Выполняет дополнительные пользовательские действия перед вставкой нового элемента в экземпляр класса <see cref="T:System.Collections.CollectionBase" />.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс, по которому должен быть вставлен параметр <paramref name="value" />.</param>
		/// <param name="value">Новое значение элемента по индексу <paramref name="index" />.</param>
		// Token: 0x06005BEF RID: 23535 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void OnInsert(int index, object value)
		{
		}

		/// <summary>Выполняет дополнительные пользовательские действия при очистке содержимого экземпляра <see cref="T:System.Collections.CollectionBase" />.</summary>
		// Token: 0x06005BF0 RID: 23536 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void OnClear()
		{
		}

		/// <summary>Осуществляет дополнительные пользовательские действия при удалении элемента из экземпляра класса <see cref="T:System.Collections.CollectionBase" />.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс, по которому может быть найдено значение <paramref name="value" />.</param>
		/// <param name="value">Значение элемента, удаляемого из <paramref name="index" />.</param>
		// Token: 0x06005BF1 RID: 23537 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void OnRemove(int index, object value)
		{
		}

		/// <summary>Выполняет дополнительные пользовательские операции при проверке значения.</summary>
		/// <param name="value">Объект для проверки.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005BF2 RID: 23538 RVA: 0x001358A1 File Offset: 0x00133AA1
		protected virtual void OnValidate(object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
		}

		/// <summary>Выполняет дополнительные пользовательские действия после задания значения в экземпляре класса <see cref="T:System.Collections.CollectionBase" />.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс, по которому может быть найдено значение <paramref name="oldValue" />.</param>
		/// <param name="oldValue">Значение, которое требуется заменить на <paramref name="newValue" />.</param>
		/// <param name="newValue">Новое значение элемента по индексу <paramref name="index" />.</param>
		// Token: 0x06005BF3 RID: 23539 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void OnSetComplete(int index, object oldValue, object newValue)
		{
		}

		/// <summary>Выполняет дополнительные пользовательские действия после вставки нового элемента в экземпляр класса <see cref="T:System.Collections.CollectionBase" />.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс, по которому должен быть вставлен параметр <paramref name="value" />.</param>
		/// <param name="value">Новое значение элемента по индексу <paramref name="index" />.</param>
		// Token: 0x06005BF4 RID: 23540 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void OnInsertComplete(int index, object value)
		{
		}

		/// <summary>Осуществляет дополнительные пользовательские действия после удаления содержимого экземпляра класса <see cref="T:System.Collections.CollectionBase" />.</summary>
		// Token: 0x06005BF5 RID: 23541 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void OnClearComplete()
		{
		}

		/// <summary>Осуществляет дополнительные пользовательские действия после удаления элемента из экземпляра класса <see cref="T:System.Collections.CollectionBase" />.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс, по которому может быть найдено значение <paramref name="value" />.</param>
		/// <param name="value">Значение элемента, удаляемого из <paramref name="index" />.</param>
		// Token: 0x06005BF6 RID: 23542 RVA: 0x00004BF9 File Offset: 0x00002DF9
		protected virtual void OnRemoveComplete(int index, object value)
		{
		}

		// Token: 0x04003886 RID: 14470
		private ArrayList _list;
	}
}
