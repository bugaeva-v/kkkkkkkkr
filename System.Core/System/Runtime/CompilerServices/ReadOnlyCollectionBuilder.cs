using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace System.Runtime.CompilerServices
{
	/// <summary>
	///         Построитель для коллекции, предназначенной только для чтения.
	///       </summary>
	/// <typeparam name="T">
	///           Тип элемента коллекции.
	///         </typeparam>
	// Token: 0x020002E5 RID: 741
	[Serializable]
	public sealed class ReadOnlyCollectionBuilder<T> : IList<!0>, ICollection<!0>, IEnumerable<!0>, IEnumerable, IList, ICollection
	{
		/// <summary>
		///         Создает документ ReadOnlyCollectionBuilder.
		///       </summary>
		// Token: 0x06001676 RID: 5750 RVA: 0x0004BD7E File Offset: 0x00049F7E
		public ReadOnlyCollectionBuilder()
		{
			this._items = Array.Empty<T>();
		}

		/// <summary>
		///         Создает ReadOnlyCollectionBuilder с заданной начальной емкостью.
		///          Содержимого нет, но построитель резервирует пространство для заданного числа элементов перед любой более не требуются.
		///       </summary>
		/// <param name="capacity">
		///           Исходная емкость.
		///         </param>
		// Token: 0x06001677 RID: 5751 RVA: 0x0004BD91 File Offset: 0x00049F91
		public ReadOnlyCollectionBuilder(int capacity)
		{
			if (capacity < 0)
			{
				throw new ArgumentOutOfRangeException("capacity");
			}
			this._items = new T[capacity];
		}

		/// <summary>
		///         Создает ReadOnlyCollectionBuilder, копирование содержимого данной коллекции.
		///       </summary>
		/// <param name="collection">
		///           Скопируйте элементы из коллекции.
		///         </param>
		// Token: 0x06001678 RID: 5752 RVA: 0x0004BDB4 File Offset: 0x00049FB4
		public ReadOnlyCollectionBuilder(IEnumerable<T> collection)
		{
			if (collection == null)
			{
				throw new ArgumentNullException("collection");
			}
			ICollection<T> collection2 = collection as ICollection<T>;
			if (collection2 != null)
			{
				int count = collection2.Count;
				this._items = new T[count];
				collection2.CopyTo(this._items, 0);
				this._size = count;
				return;
			}
			this._size = 0;
			this._items = new T[4];
			foreach (T item in collection)
			{
				this.Add(item);
			}
		}

		/// <summary>
		///         Возвращает и задает емкость данного ReadOnlyCollectionBuilder.
		///       </summary>
		/// <returns>
		///         Емкость данного ReadOnlyCollectionBuilder.
		///       </returns>
		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001679 RID: 5753 RVA: 0x0004BE54 File Offset: 0x0004A054
		// (set) Token: 0x0600167A RID: 5754 RVA: 0x0004BE60 File Offset: 0x0004A060
		public int Capacity
		{
			get
			{
				return this._items.Length;
			}
			set
			{
				if (value < this._size)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				if (value != this._items.Length)
				{
					if (value > 0)
					{
						T[] array = new T[value];
						if (this._size > 0)
						{
							Array.Copy(this._items, 0, array, 0, this._size);
						}
						this._items = array;
						return;
					}
					this._items = Array.Empty<T>();
				}
			}
		}

		/// <summary>
		///         Возвращает количество элементов в ReadOnlyCollectionBuilder.
		///       </summary>
		/// <returns>
		///         Число элементов в массиве ReadOnlyCollectionBuilder.
		///       </returns>
		// Token: 0x170003DA RID: 986
		// (get) Token: 0x0600167B RID: 5755 RVA: 0x0004BEC7 File Offset: 0x0004A0C7
		public int Count
		{
			get
			{
				return this._size;
			}
		}

		/// <summary>
		///         Возвращает индекс первого вхождения заданного значения в построитель.
		///       </summary>
		/// <param name="item">
		///           Искомый элемент.
		///         </param>
		/// <returns>
		///         Индекс первого вхождения элемента.
		///       </returns>
		// Token: 0x0600167C RID: 5756 RVA: 0x0004BECF File Offset: 0x0004A0CF
		public int IndexOf(T item)
		{
			return Array.IndexOf<T>(this._items, item, 0, this._size);
		}

		/// <summary>
		///         Вставляет элемент в список <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" /> по указанному индексу.
		///       </summary>
		/// <param name="index">
		///           Отсчитываемый от нуля индекс, по которому следует вставить элемент.
		///         </param>
		/// <param name="item">
		///           Объект, вставляемый в коллекцию <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" />.
		///         </param>
		// Token: 0x0600167D RID: 5757 RVA: 0x0004BEE4 File Offset: 0x0004A0E4
		public void Insert(int index, T item)
		{
			if (index > this._size)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (this._size == this._items.Length)
			{
				this.EnsureCapacity(this._size + 1);
			}
			if (index < this._size)
			{
				Array.Copy(this._items, index, this._items, index + 1, this._size - index);
			}
			this._items[index] = item;
			this._size++;
			this._version++;
		}

		/// <summary>
		///         Удаляет элемент <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" />, расположенный по указанному индексу.
		///       </summary>
		/// <param name="index">
		///           Отсчитываемый от нуля индекс удаляемого элемента.
		///         </param>
		// Token: 0x0600167E RID: 5758 RVA: 0x0004BF74 File Offset: 0x0004A174
		public void RemoveAt(int index)
		{
			if (index < 0 || index >= this._size)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			this._size--;
			if (index < this._size)
			{
				Array.Copy(this._items, index + 1, this._items, index, this._size - index);
			}
			this._items[this._size] = default(T);
			this._version++;
		}

		/// <summary>
		///         Возвращает или задает элемент по указанному индексу.
		///       </summary>
		/// <param name="index">
		///           Отсчитываемый от нуля индекс элемента, который требуется возвратить или задать.
		///         </param>
		/// <returns>
		///         Элемент, расположенный по указанному индексу.
		///       </returns>
		// Token: 0x170003DB RID: 987
		public T this[int index]
		{
			get
			{
				if (index >= this._size)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				return this._items[index];
			}
			set
			{
				if (index >= this._size)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				this._items[index] = value;
				this._version++;
			}
		}

		/// <summary>
		///         Добавляет элемент в коллекцию <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" />.
		///       </summary>
		/// <param name="item">
		///           Объект, добавляемый в коллекцию <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" />.
		///         </param>
		// Token: 0x06001681 RID: 5761 RVA: 0x0004C048 File Offset: 0x0004A248
		public void Add(T item)
		{
			if (this._size == this._items.Length)
			{
				this.EnsureCapacity(this._size + 1);
			}
			T[] items = this._items;
			int size = this._size;
			this._size = size + 1;
			items[size] = item;
			this._version++;
		}

		/// <summary>
		///         Удаляет все элементы из коллекции <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" />.
		///       </summary>
		// Token: 0x06001682 RID: 5762 RVA: 0x0004C09E File Offset: 0x0004A29E
		public void Clear()
		{
			if (this._size > 0)
			{
				Array.Clear(this._items, 0, this._size);
				this._size = 0;
			}
			this._version++;
		}

		/// <summary>
		///         Определяет, является ли <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" /> содержит определенное значение
		///       </summary>
		/// <param name="item">
		///           объект для поиска в <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" />.
		///         </param>
		/// <returns>
		///         значение true, если элемент найден в <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" />; в противном случае — значение false.
		///       </returns>
		// Token: 0x06001683 RID: 5763 RVA: 0x0004C0D0 File Offset: 0x0004A2D0
		public bool Contains(T item)
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
			EqualityComparer<T> @default = EqualityComparer<T>.Default;
			for (int j = 0; j < this._size; j++)
			{
				if (@default.Equals(this._items[j], item))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>
		///         Копирует элементы коллекции <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" /> для <see cref="T:System.Array" />, начиная с указанного <see cref="T:System.Array" /> индекса.
		///       </summary>
		/// <param name="array">
		///           Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из интерфейса <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" />.
		///         </param>
		/// <param name="arrayIndex">
		///           Отсчитываемый от нуля индекс в массиве, с которого начинается копирование.
		///         </param>
		// Token: 0x06001684 RID: 5764 RVA: 0x0004C13C File Offset: 0x0004A33C
		public void CopyTo(T[] array, int arrayIndex)
		{
			Array.Copy(this._items, 0, array, arrayIndex, this._size);
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001685 RID: 5765 RVA: 0x000023D1 File Offset: 0x000005D1
		bool ICollection<!0>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>
		///         Удаляет первое вхождение указанного объекта из коллекции <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" />.
		///       </summary>
		/// <param name="item">
		///           Объект, который необходимо удалить из коллекции <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" />.
		///         </param>
		/// <returns>
		///         значение true, если элемент был успешно удален из <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" />; в противном случае — значение false.
		///          Этот метод также возвращает значение false, если элемент не найден в исходной коллекции <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" />.
		///       </returns>
		// Token: 0x06001686 RID: 5766 RVA: 0x0004C154 File Offset: 0x0004A354
		public bool Remove(T item)
		{
			int num = this.IndexOf(item);
			if (num >= 0)
			{
				this.RemoveAt(num);
				return true;
			}
			return false;
		}

		/// <summary>
		///         Возвращает перечислитель, выполняющий перебор элементов в коллекции.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Collections.Generic.IEnumerator`1" />, который может использоваться для выполнения итерации по коллекции.
		///       </returns>
		// Token: 0x06001687 RID: 5767 RVA: 0x0004C177 File Offset: 0x0004A377
		public IEnumerator<T> GetEnumerator()
		{
			return new ReadOnlyCollectionBuilder<T>.Enumerator(this);
		}

		/// <summary>
		///         Возвращает перечислитель, выполняющий перебор элементов в коллекции.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для итерации элементов коллекции.
		///       </returns>
		// Token: 0x06001688 RID: 5768 RVA: 0x0004C17F File Offset: 0x0004A37F
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>
		///         Получает значение, указывающее, является ли объект <see cref="T:System.Collections.IList" /> доступным только для чтения.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если интерфейс <see cref="T:System.Collections.IList" /> доступен только для чтения; в противном случае — значение <see langword="false" />.
		///       </returns>
		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001689 RID: 5769 RVA: 0x000023D1 File Offset: 0x000005D1
		bool IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>
		///         Добавляет элемент в коллекцию <see cref="T:System.Collections.IList" />.
		///       </summary>
		/// <param name="value">
		///           Объект <see cref="T:System.Object" />, добавляемый в список <see cref="T:System.Collections.IList" />.
		///         </param>
		/// <returns>
		///         Позиция, на которую вставлен новый элемент.
		///       </returns>
		// Token: 0x0600168A RID: 5770 RVA: 0x0004C188 File Offset: 0x0004A388
		int IList.Add(object value)
		{
			ReadOnlyCollectionBuilder<T>.ValidateNullValue(value, "value");
			try
			{
				this.Add((T)((object)value));
			}
			catch (InvalidCastException)
			{
				throw Error.InvalidTypeException(value, typeof(T), "value");
			}
			return this.Count - 1;
		}

		/// <summary>
		///         Определяет, содержит ли коллекция <see cref="T:System.Collections.IList" /> указанное значение.
		///       </summary>
		/// <param name="value">
		///           Объект <see cref="T:System.Object" />, который требуется найти в коллекции <see cref="T:System.Collections.IList" />.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если параметр <paramref name="item" /> найден в коллекции <see cref="T:System.Collections.IList" />; в противном случае — значение <see langword="false" />.
		///       </returns>
		// Token: 0x0600168B RID: 5771 RVA: 0x0004C1E0 File Offset: 0x0004A3E0
		bool IList.Contains(object value)
		{
			return ReadOnlyCollectionBuilder<T>.IsCompatibleObject(value) && this.Contains((T)((object)value));
		}

		/// <summary>
		///         Определяет индекс заданного элемента в списке <see cref="T:System.Collections.IList" />.
		///       </summary>
		/// <param name="value">
		///           Объект для поиска в <see cref="T:System.Collections.IList" />.
		///         </param>
		/// <returns>
		///         Индекс значения <paramref name="item" />, если оно найдено в списке; в противном случае — значение -1.
		///       </returns>
		// Token: 0x0600168C RID: 5772 RVA: 0x0004C1F8 File Offset: 0x0004A3F8
		int IList.IndexOf(object value)
		{
			if (ReadOnlyCollectionBuilder<T>.IsCompatibleObject(value))
			{
				return this.IndexOf((T)((object)value));
			}
			return -1;
		}

		/// <summary>
		///         Вставляет элемент в список <see cref="T:System.Collections.IList" /> по указанному индексу.
		///       </summary>
		/// <param name="index">
		///           Отсчитываемый от нуля индекс, по которому следует вставить элемент <paramref name="item" />.
		///         </param>
		/// <param name="value">
		///           Объект, вставляемый в коллекцию <see cref="T:System.Collections.IList" />.
		///         </param>
		// Token: 0x0600168D RID: 5773 RVA: 0x0004C210 File Offset: 0x0004A410
		void IList.Insert(int index, object value)
		{
			ReadOnlyCollectionBuilder<T>.ValidateNullValue(value, "value");
			try
			{
				this.Insert(index, (T)((object)value));
			}
			catch (InvalidCastException)
			{
				throw Error.InvalidTypeException(value, typeof(T), "value");
			}
		}

		/// <summary>
		///         Получает значение, указывающее, имеет ли список <see cref="T:System.Collections.IList" /> фиксированный размер.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если словарь <see cref="T:System.Collections.IList" /> имеет фиксированный размер; в противном случае — значение <see langword="false" />.
		///       </returns>
		// Token: 0x170003DE RID: 990
		// (get) Token: 0x0600168E RID: 5774 RVA: 0x000023D1 File Offset: 0x000005D1
		bool IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>
		///         Удаляет первое вхождение указанного объекта из коллекции <see cref="T:System.Collections.IList" />.
		///       </summary>
		/// <param name="value">
		///           Объект, который необходимо удалить из коллекции <see cref="T:System.Collections.IList" />.
		///         </param>
		// Token: 0x0600168F RID: 5775 RVA: 0x0004C260 File Offset: 0x0004A460
		void IList.Remove(object value)
		{
			if (ReadOnlyCollectionBuilder<T>.IsCompatibleObject(value))
			{
				this.Remove((T)((object)value));
			}
		}

		/// <summary>
		///         Возвращает или задает элемент по указанному индексу.
		///       </summary>
		/// <param name="index">
		///           Отсчитываемый от нуля индекс элемента, который требуется возвратить или задать.
		///         </param>
		/// <returns>
		///         Элемент, расположенный по указанному индексу.
		///       </returns>
		// Token: 0x170003DF RID: 991
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				ReadOnlyCollectionBuilder<T>.ValidateNullValue(value, "value");
				try
				{
					this[index] = (T)((object)value);
				}
				catch (InvalidCastException)
				{
					throw Error.InvalidTypeException(value, typeof(T), "value");
				}
			}
		}

		/// <summary>
		///         Копирует элементы коллекции <see cref="T:System.Collections.Generic.ICollection`1" /> в массив, начиная с указанного индекса массива.
		///       </summary>
		/// <param name="array">
		///           Одномерный массив, в который копируются элементы из коллекции <see cref="T:System.Collections.Generic.ICollection`1" />.
		///            Индекс в массиве должен начинаться с нуля.
		///         </param>
		/// <param name="index">
		///           Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.
		///         </param>
		// Token: 0x06001692 RID: 5778 RVA: 0x0004C2D8 File Offset: 0x0004A4D8
		void ICollection.CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (array.Rank != 1)
			{
				throw new ArgumentException("array");
			}
			Array.Copy(this._items, 0, array, index, this._size);
		}

		/// <summary>
		///         Возвращает значение, показывающее, является ли доступ к коллекции <see cref="T:System.Collections.ICollection" /> синхронизированным (потокобезопасным).
		///       </summary>
		/// <returns>
		///         <see langword="true" />, если доступ к классу <see cref="T:System.Collections.ICollection" /> является синхронизированным (потокобезопасным); в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001693 RID: 5779 RVA: 0x000023D1 File Offset: 0x000005D1
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>
		///         Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.ICollection" />.
		///       </summary>
		/// <returns>
		///         Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Collections.ICollection" />.
		///       </returns>
		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001694 RID: 5780 RVA: 0x000022A7 File Offset: 0x000004A7
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>
		///         Изменяет порядок элементов во всем списке <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" /> на обратный.
		///       </summary>
		// Token: 0x06001695 RID: 5781 RVA: 0x0004C310 File Offset: 0x0004A510
		public void Reverse()
		{
			this.Reverse(0, this.Count);
		}

		/// <summary>
		///         Изменяет порядок элементов в указанном диапазоне.
		///       </summary>
		/// <param name="index">
		///           Отсчитываемый от нуля индекс начала диапазона, порядок элементов которого требуется изменить.
		///         </param>
		/// <param name="count">
		///           Число элементов в диапазоне, порядок сортировки в котором требуется изменить.
		///         </param>
		// Token: 0x06001696 RID: 5782 RVA: 0x0004C31F File Offset: 0x0004A51F
		public void Reverse(int index, int count)
		{
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			Array.Reverse<T>(this._items, index, count);
			this._version++;
		}

		/// <summary>
		///         Копирует элементы списка <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" /> в новый массив.
		///       </summary>
		/// <returns>
		///         Массив, содержащий копии элементов списка <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" />.
		///       </returns>
		// Token: 0x06001697 RID: 5783 RVA: 0x0004C35C File Offset: 0x0004A55C
		public T[] ToArray()
		{
			T[] array = new T[this._size];
			Array.Copy(this._items, 0, array, 0, this._size);
			return array;
		}

		/// <summary>
		///         Создает <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> содержит все элементы <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" />, и избегайте использования копирования элементов в новый массив, если это возможно.
		///          Сбрасывает <see cref="T:System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1" /> после <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> будет создан.
		///       </summary>
		/// <returns>
		///         Новый экземпляр класса <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />.
		///       </returns>
		// Token: 0x06001698 RID: 5784 RVA: 0x0004C38C File Offset: 0x0004A58C
		public ReadOnlyCollection<T> ToReadOnlyCollection()
		{
			T[] list;
			if (this._size == this._items.Length)
			{
				list = this._items;
			}
			else
			{
				list = this.ToArray();
			}
			this._items = Array.Empty<T>();
			this._size = 0;
			this._version++;
			return new TrueReadOnlyCollection<T>(list);
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x0004C3E0 File Offset: 0x0004A5E0
		private void EnsureCapacity(int min)
		{
			if (this._items.Length < min)
			{
				int num = 4;
				if (this._items.Length != 0)
				{
					num = this._items.Length * 2;
				}
				if (num < min)
				{
					num = min;
				}
				this.Capacity = num;
			}
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x0004C41C File Offset: 0x0004A61C
		private static bool IsCompatibleObject(object value)
		{
			return value is T || (value == null && default(T) == null);
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x0004C44C File Offset: 0x0004A64C
		private static void ValidateNullValue(object value, string argument)
		{
			if (value == null && default(T) != null)
			{
				throw Error.InvalidNullValue(typeof(T), argument);
			}
		}

		// Token: 0x04000B56 RID: 2902
		private const int DefaultCapacity = 4;

		// Token: 0x04000B57 RID: 2903
		private T[] _items;

		// Token: 0x04000B58 RID: 2904
		private int _size;

		// Token: 0x04000B59 RID: 2905
		private int _version;

		// Token: 0x020002E6 RID: 742
		[Serializable]
		private class Enumerator : IEnumerator<!0>, IDisposable, IEnumerator
		{
			// Token: 0x0600169C RID: 5788 RVA: 0x0004C47D File Offset: 0x0004A67D
			internal Enumerator(ReadOnlyCollectionBuilder<T> builder)
			{
				this._builder = builder;
				this._version = builder._version;
				this._index = 0;
				this._current = default(T);
			}

			// Token: 0x170003E2 RID: 994
			// (get) Token: 0x0600169D RID: 5789 RVA: 0x0004C4AB File Offset: 0x0004A6AB
			public T Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x0600169E RID: 5790 RVA: 0x00003A59 File Offset: 0x00001C59
			public void Dispose()
			{
			}

			// Token: 0x170003E3 RID: 995
			// (get) Token: 0x0600169F RID: 5791 RVA: 0x0004C4B3 File Offset: 0x0004A6B3
			object IEnumerator.Current
			{
				get
				{
					if (this._index == 0 || this._index > this._builder._size)
					{
						throw Error.EnumerationIsDone();
					}
					return this._current;
				}
			}

			// Token: 0x060016A0 RID: 5792 RVA: 0x0004C4E4 File Offset: 0x0004A6E4
			public bool MoveNext()
			{
				if (this._version != this._builder._version)
				{
					throw Error.CollectionModifiedWhileEnumerating();
				}
				if (this._index < this._builder._size)
				{
					T[] items = this._builder._items;
					int index = this._index;
					this._index = index + 1;
					this._current = items[index];
					return true;
				}
				this._index = this._builder._size + 1;
				this._current = default(T);
				return false;
			}

			// Token: 0x060016A1 RID: 5793 RVA: 0x0004C566 File Offset: 0x0004A766
			void IEnumerator.Reset()
			{
				if (this._version != this._builder._version)
				{
					throw Error.CollectionModifiedWhileEnumerating();
				}
				this._index = 0;
				this._current = default(T);
			}

			// Token: 0x04000B5A RID: 2906
			private readonly ReadOnlyCollectionBuilder<T> _builder;

			// Token: 0x04000B5B RID: 2907
			private readonly int _version;

			// Token: 0x04000B5C RID: 2908
			private int _index;

			// Token: 0x04000B5D RID: 2909
			private T _current;
		}
	}
}
