using System;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Threading;

namespace System.Collections.Specialized
{
	/// <summary>Представляет коллекцию пар "ключ-значение", доступ к которым можно получить по ключу и индексу.</summary>
	// Token: 0x020004AD RID: 1197
	[Serializable]
	public class OrderedDictionary : IOrderedDictionary, IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</summary>
		// Token: 0x0600268A RID: 9866 RVA: 0x00086A50 File Offset: 0x00084C50
		public OrderedDictionary() : this(0)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Specialized.OrderedDictionary" />, используя указанную исходную емкость.</summary>
		/// <param name="capacity">Начальное количество элементов, которое может содержать коллекция <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</param>
		// Token: 0x0600268B RID: 9867 RVA: 0x00086A59 File Offset: 0x00084C59
		public OrderedDictionary(int capacity) : this(capacity, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Specialized.OrderedDictionary" /> с помощью указанного компаратора.</summary>
		/// <param name="comparer">Интерфейс <see cref="T:System.Collections.IComparer" />, который используется для определения равенства двух ключей.  
		/// -или- 
		///  Значение <see langword="null" /> для использования блока сравнения по умолчанию, который является реализацией метода <see cref="M:System.Object.Equals(System.Object)" /> для каждого ключа.</param>
		// Token: 0x0600268C RID: 9868 RVA: 0x00086A63 File Offset: 0x00084C63
		public OrderedDictionary(IEqualityComparer comparer) : this(0, comparer)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Specialized.OrderedDictionary" />, используя указанную исходную емкость и компаратор.</summary>
		/// <param name="capacity">Начальное количество элементов, которое может содержать коллекция <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</param>
		/// <param name="comparer">Интерфейс <see cref="T:System.Collections.IComparer" />, который используется для определения равенства двух ключей.  
		/// -или- 
		///  Значение <see langword="null" /> для использования блока сравнения по умолчанию, который является реализацией метода <see cref="M:System.Object.Equals(System.Object)" /> для каждого ключа.</param>
		// Token: 0x0600268D RID: 9869 RVA: 0x00086A6D File Offset: 0x00084C6D
		public OrderedDictionary(int capacity, IEqualityComparer comparer)
		{
			this._initialCapacity = capacity;
			this._comparer = comparer;
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x00086A83 File Offset: 0x00084C83
		private OrderedDictionary(OrderedDictionary dictionary)
		{
			this._readOnly = true;
			this._objectsArray = dictionary._objectsArray;
			this._objectsTable = dictionary._objectsTable;
			this._comparer = dictionary._comparer;
			this._initialCapacity = dictionary._initialCapacity;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Specialized.OrderedDictionary" />, который может быть сериализован с помощью объектов <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий сведения, которые требуются для сериализации коллекции <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий исходный объект и объект назначения для сериализованного потока, связанного с коллекцией <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</param>
		// Token: 0x0600268F RID: 9871 RVA: 0x00086AC2 File Offset: 0x00084CC2
		protected OrderedDictionary(SerializationInfo info, StreamingContext context)
		{
			this._siInfo = info;
		}

		/// <summary>Получает число пар ключ/значение, содержащихся в коллекции <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</summary>
		/// <returns>Число пар ключ/значение, содержащихся в коллекции <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</returns>
		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06002690 RID: 9872 RVA: 0x00086AD1 File Offset: 0x00084CD1
		public int Count
		{
			get
			{
				return this.objectsArray.Count;
			}
		}

		/// <summary>Получает значение, указывающее, имеет ли список <see cref="T:System.Collections.Specialized.OrderedDictionary" /> фиксированный размер.</summary>
		/// <returns>Значение <see langword="true" />, если словарь <see cref="T:System.Collections.Specialized.OrderedDictionary" /> имеет фиксированный размер; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06002691 RID: 9873 RVA: 0x00086ADE File Offset: 0x00084CDE
		bool IDictionary.IsFixedSize
		{
			get
			{
				return this._readOnly;
			}
		}

		/// <summary>Получает значение, указывающее, является ли коллекция <see cref="T:System.Collections.Specialized.OrderedDictionary" /> доступной только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если коллекция <see cref="T:System.Collections.Specialized.OrderedDictionary" /> доступна только для чтения; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06002692 RID: 9874 RVA: 0x00086ADE File Offset: 0x00084CDE
		public bool IsReadOnly
		{
			get
			{
				return this._readOnly;
			}
		}

		/// <summary>Возвращает значение, указывающее на то, является ли доступ к объекту <see cref="T:System.Collections.Specialized.OrderedDictionary" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>Этот метод всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06002693 RID: 9875 RVA: 0x00003062 File Offset: 0x00001262
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает объект <see cref="T:System.Collections.ICollection" />, содержащий ключи из коллекции <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</summary>
		/// <returns>Объект <see cref="T:System.Collections.ICollection" />, содержащий ключи из коллекции <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</returns>
		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06002694 RID: 9876 RVA: 0x00086AE6 File Offset: 0x00084CE6
		public ICollection Keys
		{
			get
			{
				return new OrderedDictionary.OrderedDictionaryKeyValueCollection(this.objectsArray, true);
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06002695 RID: 9877 RVA: 0x00086AF4 File Offset: 0x00084CF4
		private ArrayList objectsArray
		{
			get
			{
				if (this._objectsArray == null)
				{
					this._objectsArray = new ArrayList(this._initialCapacity);
				}
				return this._objectsArray;
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06002696 RID: 9878 RVA: 0x00086B15 File Offset: 0x00084D15
		private Hashtable objectsTable
		{
			get
			{
				if (this._objectsTable == null)
				{
					this._objectsTable = new Hashtable(this._initialCapacity, this._comparer);
				}
				return this._objectsTable;
			}
		}

		/// <summary>Возвращает объект, который позволяет синхронизировать доступ к объекту <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</summary>
		/// <returns>Объект, который позволяет синхронизировать доступ к объекту <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</returns>
		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06002697 RID: 9879 RVA: 0x00086B3C File Offset: 0x00084D3C
		object ICollection.SyncRoot
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

		/// <summary>Возвращает или задает значение по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс возвращаемого или задаваемого значения.</param>
		/// <returns>Значение элемента с заданным индексом.</returns>
		/// <exception cref="T:System.NotSupportedException">Свойство задается, и коллекция <see cref="T:System.Collections.Specialized.OrderedDictionary" /> доступна только для чтения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		/// -или- 
		///  Значение параметра <paramref name="index" /> больше или равно значению свойства <see cref="P:System.Collections.Specialized.OrderedDictionary.Count" />.</exception>
		// Token: 0x170007D1 RID: 2001
		public object this[int index]
		{
			get
			{
				return ((DictionaryEntry)this.objectsArray[index]).Value;
			}
			set
			{
				if (this._readOnly)
				{
					throw new NotSupportedException("The OrderedDictionary is readonly and cannot be modified.");
				}
				if (index < 0 || index >= this.objectsArray.Count)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				object key = ((DictionaryEntry)this.objectsArray[index]).Key;
				this.objectsArray[index] = new DictionaryEntry(key, value);
				this.objectsTable[key] = value;
			}
		}

		/// <summary>Возвращает или задает значение с указанным ключом.</summary>
		/// <param name="key">Ключ, значение которого требуется получить или задать.</param>
		/// <returns>Значение, связанное с указанным ключом. Если указанный ключ не найден, при попытке его получения возвращается значение <see langword="null" />, а при попытке задания ключа создается новый элемент с использованием указанного ключа.</returns>
		/// <exception cref="T:System.NotSupportedException">Свойство задается, и коллекция <see cref="T:System.Collections.Specialized.OrderedDictionary" /> доступна только для чтения.</exception>
		// Token: 0x170007D2 RID: 2002
		public object this[object key]
		{
			get
			{
				return this.objectsTable[key];
			}
			set
			{
				if (this._readOnly)
				{
					throw new NotSupportedException("The OrderedDictionary is readonly and cannot be modified.");
				}
				if (this.objectsTable.Contains(key))
				{
					this.objectsTable[key] = value;
					this.objectsArray[this.IndexOfKey(key)] = new DictionaryEntry(key, value);
					return;
				}
				this.Add(key, value);
			}
		}

		/// <summary>Получает объект <see cref="T:System.Collections.ICollection" />, содержащий значения из коллекции <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</summary>
		/// <returns>Получает объект <see cref="T:System.Collections.ICollection" />, содержащий значения из коллекции <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</returns>
		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x0600269C RID: 9884 RVA: 0x00086C76 File Offset: 0x00084E76
		public ICollection Values
		{
			get
			{
				return new OrderedDictionary.OrderedDictionaryKeyValueCollection(this.objectsArray, false);
			}
		}

		/// <summary>Добавляет запись с указанным ключом и значением в коллекцию <see cref="T:System.Collections.Specialized.OrderedDictionary" /> с наименьшим доступным индексом.</summary>
		/// <param name="key">Ключ записи, которую требуется добавить.</param>
		/// <param name="value">Добавляемое значение записи. Это значение может быть равно <see langword="null" />.</param>
		/// <exception cref="T:System.NotSupportedException">Коллекция <see cref="T:System.Collections.Specialized.OrderedDictionary" /> доступна только для чтения.</exception>
		/// <exception cref="T:System.ArgumentException">Элемент с таким ключом уже существует в коллекции <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</exception>
		// Token: 0x0600269D RID: 9885 RVA: 0x00086C84 File Offset: 0x00084E84
		public void Add(object key, object value)
		{
			if (this._readOnly)
			{
				throw new NotSupportedException("The OrderedDictionary is readonly and cannot be modified.");
			}
			this.objectsTable.Add(key, value);
			this.objectsArray.Add(new DictionaryEntry(key, value));
		}

		/// <summary>Удаляет все элементы из коллекции <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</summary>
		/// <exception cref="T:System.NotSupportedException">Коллекция <see cref="T:System.Collections.Specialized.OrderedDictionary" /> доступна только для чтения.</exception>
		// Token: 0x0600269E RID: 9886 RVA: 0x00086CBE File Offset: 0x00084EBE
		public void Clear()
		{
			if (this._readOnly)
			{
				throw new NotSupportedException("The OrderedDictionary is readonly and cannot be modified.");
			}
			this.objectsTable.Clear();
			this.objectsArray.Clear();
		}

		/// <summary>Возвращает доступную только для чтения копию текущей коллекции <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</summary>
		/// <returns>Доступная только для чтения копия текущей коллекции <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</returns>
		// Token: 0x0600269F RID: 9887 RVA: 0x00086CE9 File Offset: 0x00084EE9
		public OrderedDictionary AsReadOnly()
		{
			return new OrderedDictionary(this);
		}

		/// <summary>Определяет, содержит ли коллекция <see cref="T:System.Collections.Specialized.OrderedDictionary" /> указанный ключ.</summary>
		/// <param name="key">Ключ, который требуется отыскать в коллекции <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</param>
		/// <returns>Значение <see langword="true" />, если коллекция <see cref="T:System.Collections.Specialized.OrderedDictionary" /> содержит элемент с указанным ключом, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060026A0 RID: 9888 RVA: 0x00086CF1 File Offset: 0x00084EF1
		public bool Contains(object key)
		{
			return this.objectsTable.Contains(key);
		}

		/// <summary>Копирует элементы коллекции <see cref="T:System.Collections.Specialized.OrderedDictionary" /> в одномерный объект <see cref="T:System.Array" /> по указанному индексу.</summary>
		/// <param name="array">Одномерный объект <see cref="T:System.Array" />, который является конечным объектом для объектов <see cref="T:System.Collections.DictionaryEntry" />, копируемых из коллекции <see cref="T:System.Collections.Specialized.OrderedDictionary" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		// Token: 0x060026A1 RID: 9889 RVA: 0x00086CFF File Offset: 0x00084EFF
		public void CopyTo(Array array, int index)
		{
			this.objectsTable.CopyTo(array, index);
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x00086D10 File Offset: 0x00084F10
		private int IndexOfKey(object key)
		{
			for (int i = 0; i < this.objectsArray.Count; i++)
			{
				object key2 = ((DictionaryEntry)this.objectsArray[i]).Key;
				if (this._comparer != null)
				{
					if (this._comparer.Equals(key2, key))
					{
						return i;
					}
				}
				else if (key2.Equals(key))
				{
					return i;
				}
			}
			return -1;
		}

		/// <summary>Вставляет новую запись в коллекцию <see cref="T:System.Collections.Specialized.OrderedDictionary" /> с указанным ключом и значением по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс, по которому следует вставить элемент.</param>
		/// <param name="key">Ключ записи, которую требуется добавить.</param>
		/// <param name="value">Добавляемое значение записи. Допускается значение <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> выходит за пределы диапазона.</exception>
		/// <exception cref="T:System.NotSupportedException">Эта коллекция доступна только для чтения.</exception>
		// Token: 0x060026A3 RID: 9891 RVA: 0x00086D74 File Offset: 0x00084F74
		public void Insert(int index, object key, object value)
		{
			if (this._readOnly)
			{
				throw new NotSupportedException("The OrderedDictionary is readonly and cannot be modified.");
			}
			if (index > this.Count || index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			this.objectsTable.Add(key, value);
			this.objectsArray.Insert(index, new DictionaryEntry(key, value));
		}

		/// <summary>Удаляет запись с указанным индексом из коллекции <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс записи, которую требуется удалить.</param>
		/// <exception cref="T:System.NotSupportedException">Коллекция <see cref="T:System.Collections.Specialized.OrderedDictionary" /> доступна только для чтения.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		///
		/// или - 
		/// Значение параметра <paramref name="index" /> больше или равно значению свойства <see cref="P:System.Collections.Specialized.OrderedDictionary.Count" />.</exception>
		// Token: 0x060026A4 RID: 9892 RVA: 0x00086DD4 File Offset: 0x00084FD4
		public void RemoveAt(int index)
		{
			if (this._readOnly)
			{
				throw new NotSupportedException("The OrderedDictionary is readonly and cannot be modified.");
			}
			if (index >= this.Count || index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			object key = ((DictionaryEntry)this.objectsArray[index]).Key;
			this.objectsArray.RemoveAt(index);
			this.objectsTable.Remove(key);
		}

		/// <summary>Удаляет запись с указанным ключом из коллекции <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</summary>
		/// <param name="key">Ключ записи, которую требуется удалить.</param>
		/// <exception cref="T:System.NotSupportedException">Коллекция <see cref="T:System.Collections.Specialized.OrderedDictionary" /> доступна только для чтения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="key" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060026A5 RID: 9893 RVA: 0x00086E40 File Offset: 0x00085040
		public void Remove(object key)
		{
			if (this._readOnly)
			{
				throw new NotSupportedException("The OrderedDictionary is readonly and cannot be modified.");
			}
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			int num = this.IndexOfKey(key);
			if (num < 0)
			{
				return;
			}
			this.objectsTable.Remove(key);
			this.objectsArray.RemoveAt(num);
		}

		/// <summary>Возвращает объект <see cref="T:System.Collections.IDictionaryEnumerator" />, который выполняет перебор элементов коллекции <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IDictionaryEnumerator" /> для коллекции <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</returns>
		// Token: 0x060026A6 RID: 9894 RVA: 0x00086E93 File Offset: 0x00085093
		public virtual IDictionaryEnumerator GetEnumerator()
		{
			return new OrderedDictionary.OrderedDictionaryEnumerator(this.objectsArray, 3);
		}

		/// <summary>Возвращает объект <see cref="T:System.Collections.IDictionaryEnumerator" />, который выполняет перебор элементов коллекции <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IDictionaryEnumerator" /> для коллекции <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</returns>
		// Token: 0x060026A7 RID: 9895 RVA: 0x00086E93 File Offset: 0x00085093
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new OrderedDictionary.OrderedDictionaryEnumerator(this.objectsArray, 3);
		}

		/// <summary>Реализует интерфейс <see cref="T:System.Runtime.Serialization.ISerializable" /> и возвращает данные, необходимые для сериализации коллекции <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий сведения, которые требуются для сериализации коллекции <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий исходный объект и объект назначения для сериализованного потока, связанного с коллекцией <see cref="T:System.Collections.Specialized.OrderedDictionary" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060026A8 RID: 9896 RVA: 0x00086EA4 File Offset: 0x000850A4
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("KeyComparer", this._comparer, typeof(IEqualityComparer));
			info.AddValue("ReadOnly", this._readOnly);
			info.AddValue("InitialCapacity", this._initialCapacity);
			object[] array = new object[this.Count];
			this._objectsArray.CopyTo(array);
			info.AddValue("ArrayList", array);
		}

		/// <summary>Реализует интерфейс <see cref="T:System.Runtime.Serialization.ISerializable" /> и вызывается событием десериализации после завершения десериализации в ходе обратного вызова.</summary>
		/// <param name="sender">Источник события десериализации.</param>
		// Token: 0x060026A9 RID: 9897 RVA: 0x00086F20 File Offset: 0x00085120
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			this.OnDeserialization(sender);
		}

		/// <summary>Реализует интерфейс <see cref="T:System.Runtime.Serialization.ISerializable" /> и вызывается событием десериализации после завершения десериализации в ходе обратного вызова.</summary>
		/// <param name="sender">Источник события десериализации.</param>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, связанный с текущей коллекцией <see cref="T:System.Collections.Specialized.OrderedDictionary" />, является недопустимым.</exception>
		// Token: 0x060026AA RID: 9898 RVA: 0x00086F2C File Offset: 0x0008512C
		protected virtual void OnDeserialization(object sender)
		{
			if (this._siInfo == null)
			{
				throw new SerializationException("OnDeserialization method was called while the object was not being deserialized.");
			}
			this._comparer = (IEqualityComparer)this._siInfo.GetValue("KeyComparer", typeof(IEqualityComparer));
			this._readOnly = this._siInfo.GetBoolean("ReadOnly");
			this._initialCapacity = this._siInfo.GetInt32("InitialCapacity");
			object[] array = (object[])this._siInfo.GetValue("ArrayList", typeof(object[]));
			if (array != null)
			{
				foreach (object obj in array)
				{
					DictionaryEntry dictionaryEntry;
					try
					{
						dictionaryEntry = (DictionaryEntry)obj;
					}
					catch
					{
						throw new SerializationException("There was an error deserializing the OrderedDictionary.  The ArrayList does not contain DictionaryEntries.");
					}
					this.objectsArray.Add(dictionaryEntry);
					this.objectsTable.Add(dictionaryEntry.Key, dictionaryEntry.Value);
				}
			}
		}

		// Token: 0x040014FF RID: 5375
		private ArrayList _objectsArray;

		// Token: 0x04001500 RID: 5376
		private Hashtable _objectsTable;

		// Token: 0x04001501 RID: 5377
		private int _initialCapacity;

		// Token: 0x04001502 RID: 5378
		private IEqualityComparer _comparer;

		// Token: 0x04001503 RID: 5379
		private bool _readOnly;

		// Token: 0x04001504 RID: 5380
		private object _syncRoot;

		// Token: 0x04001505 RID: 5381
		private SerializationInfo _siInfo;

		// Token: 0x04001506 RID: 5382
		private const string KeyComparerName = "KeyComparer";

		// Token: 0x04001507 RID: 5383
		private const string ArrayListName = "ArrayList";

		// Token: 0x04001508 RID: 5384
		private const string ReadOnlyName = "ReadOnly";

		// Token: 0x04001509 RID: 5385
		private const string InitCapacityName = "InitialCapacity";

		// Token: 0x020004AE RID: 1198
		private class OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x060026AB RID: 9899 RVA: 0x00087028 File Offset: 0x00085228
			internal OrderedDictionaryEnumerator(ArrayList array, int objectReturnType)
			{
				this._arrayEnumerator = array.GetEnumerator();
				this._objectReturnType = objectReturnType;
			}

			// Token: 0x170007D4 RID: 2004
			// (get) Token: 0x060026AC RID: 9900 RVA: 0x00087044 File Offset: 0x00085244
			public object Current
			{
				get
				{
					if (this._objectReturnType == 1)
					{
						DictionaryEntry dictionaryEntry = (DictionaryEntry)this._arrayEnumerator.Current;
						return dictionaryEntry.Key;
					}
					if (this._objectReturnType == 2)
					{
						DictionaryEntry dictionaryEntry = (DictionaryEntry)this._arrayEnumerator.Current;
						return dictionaryEntry.Value;
					}
					return this.Entry;
				}
			}

			// Token: 0x170007D5 RID: 2005
			// (get) Token: 0x060026AD RID: 9901 RVA: 0x000870A0 File Offset: 0x000852A0
			public DictionaryEntry Entry
			{
				get
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)this._arrayEnumerator.Current;
					object key = dictionaryEntry.Key;
					dictionaryEntry = (DictionaryEntry)this._arrayEnumerator.Current;
					return new DictionaryEntry(key, dictionaryEntry.Value);
				}
			}

			// Token: 0x170007D6 RID: 2006
			// (get) Token: 0x060026AE RID: 9902 RVA: 0x000870E4 File Offset: 0x000852E4
			public object Key
			{
				get
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)this._arrayEnumerator.Current;
					return dictionaryEntry.Key;
				}
			}

			// Token: 0x170007D7 RID: 2007
			// (get) Token: 0x060026AF RID: 9903 RVA: 0x0008710C File Offset: 0x0008530C
			public object Value
			{
				get
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)this._arrayEnumerator.Current;
					return dictionaryEntry.Value;
				}
			}

			// Token: 0x060026B0 RID: 9904 RVA: 0x00087131 File Offset: 0x00085331
			public bool MoveNext()
			{
				return this._arrayEnumerator.MoveNext();
			}

			// Token: 0x060026B1 RID: 9905 RVA: 0x0008713E File Offset: 0x0008533E
			public void Reset()
			{
				this._arrayEnumerator.Reset();
			}

			// Token: 0x0400150A RID: 5386
			private int _objectReturnType;

			// Token: 0x0400150B RID: 5387
			internal const int Keys = 1;

			// Token: 0x0400150C RID: 5388
			internal const int Values = 2;

			// Token: 0x0400150D RID: 5389
			internal const int DictionaryEntry = 3;

			// Token: 0x0400150E RID: 5390
			private IEnumerator _arrayEnumerator;
		}

		// Token: 0x020004AF RID: 1199
		private class OrderedDictionaryKeyValueCollection : ICollection, IEnumerable
		{
			// Token: 0x060026B2 RID: 9906 RVA: 0x0008714B File Offset: 0x0008534B
			public OrderedDictionaryKeyValueCollection(ArrayList array, bool isKeys)
			{
				this._objects = array;
				this._isKeys = isKeys;
			}

			// Token: 0x060026B3 RID: 9907 RVA: 0x00087164 File Offset: 0x00085364
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
				foreach (object obj in this._objects)
				{
					array.SetValue(this._isKeys ? ((DictionaryEntry)obj).Key : ((DictionaryEntry)obj).Value, index);
					index++;
				}
			}

			// Token: 0x170007D8 RID: 2008
			// (get) Token: 0x060026B4 RID: 9908 RVA: 0x0008720C File Offset: 0x0008540C
			int ICollection.Count
			{
				get
				{
					return this._objects.Count;
				}
			}

			// Token: 0x170007D9 RID: 2009
			// (get) Token: 0x060026B5 RID: 9909 RVA: 0x00003062 File Offset: 0x00001262
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170007DA RID: 2010
			// (get) Token: 0x060026B6 RID: 9910 RVA: 0x00087219 File Offset: 0x00085419
			object ICollection.SyncRoot
			{
				get
				{
					return this._objects.SyncRoot;
				}
			}

			// Token: 0x060026B7 RID: 9911 RVA: 0x00087226 File Offset: 0x00085426
			IEnumerator IEnumerable.GetEnumerator()
			{
				return new OrderedDictionary.OrderedDictionaryEnumerator(this._objects, this._isKeys ? 1 : 2);
			}

			// Token: 0x0400150F RID: 5391
			private ArrayList _objects;

			// Token: 0x04001510 RID: 5392
			private bool _isKeys;
		}
	}
}
