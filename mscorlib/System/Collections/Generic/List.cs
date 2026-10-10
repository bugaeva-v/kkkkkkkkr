using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Collections.Generic
{
	/// <summary>Представляет строго типизированный список объектов, доступных по индексу. Поддерживает методы для поиска по списку, выполнения сортировки и других операций со списками.</summary>
	/// <typeparam name="T">Тип элементов в списке.</typeparam>
	// Token: 0x02000AA3 RID: 2723
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[Serializable]
	public class List<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<!0>, IReadOnlyCollection<T>
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Generic.List`1" />, который является пустым и имеет начальную емкость по умолчанию.</summary>
		// Token: 0x06006142 RID: 24898 RVA: 0x001452D6 File Offset: 0x001434D6
		public List()
		{
			this._items = List<T>.s_emptyArray;
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Generic.List`1" /> с указанной начальной емкостью.</summary>
		/// <param name="capacity">Число элементов, которые может изначально вместить новый список.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="capacity" /> меньше 0.</exception>
		// Token: 0x06006143 RID: 24899 RVA: 0x001452E9 File Offset: 0x001434E9
		public List(int capacity)
		{
			if (capacity < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.capacity, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (capacity == 0)
			{
				this._items = List<T>.s_emptyArray;
				return;
			}
			this._items = new T[capacity];
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Collections.Generic.List`1" />, который содержит элементы, скопированные из указанной коллекции, и имеет емкость, достаточную для размещения всех скопированных элементов.</summary>
		/// <param name="collection">Коллекция, элементы которой копируются в новый список.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="collection" /> — <see langword="null" />.</exception>
		// Token: 0x06006144 RID: 24900 RVA: 0x00145318 File Offset: 0x00143518
		public List(IEnumerable<T> collection)
		{
			if (collection == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.collection);
			}
			ICollection<T> collection2 = collection as ICollection<T>;
			if (collection2 == null)
			{
				this._size = 0;
				this._items = List<T>.s_emptyArray;
				this.AddEnumerable(collection);
				return;
			}
			int count = collection2.Count;
			if (count == 0)
			{
				this._items = List<T>.s_emptyArray;
				return;
			}
			this._items = new T[count];
			collection2.CopyTo(this._items, 0);
			this._size = count;
		}

		/// <summary>Возвращает или задает общее число элементов, которые может вместить внутренняя структура данных без изменения размера.</summary>
		/// <returns>Число элементов, которые может вместить коллекция <see cref="T:System.Collections.Generic.List`1" />, прежде чем потребуется изменить ее размер.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Для <see cref="P:System.Collections.Generic.List`1.Capacity" /> установлено значение, которое меньше <see cref="P:System.Collections.Generic.List`1.Count" />.</exception>
		/// <exception cref="T:System.OutOfMemoryException">Не хватает памяти в системе.</exception>
		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x06006145 RID: 24901 RVA: 0x0014538E File Offset: 0x0014358E
		// (set) Token: 0x06006146 RID: 24902 RVA: 0x00145398 File Offset: 0x00143598
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
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value, ExceptionResource.ArgumentOutOfRange_SmallCapacity);
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
					this._items = List<T>.s_emptyArray;
				}
			}
		}

		/// <summary>Получает число элементов, содержащихся в интерфейсе <see cref="T:System.Collections.Generic.List`1" />.</summary>
		/// <returns>Число элементов, содержащихся в интерфейсе <see cref="T:System.Collections.Generic.List`1" />.</returns>
		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x06006147 RID: 24903 RVA: 0x001453FD File Offset: 0x001435FD
		public int Count
		{
			get
			{
				return this._size;
			}
		}

		/// <summary>Получает значение, указывающее, имеет ли список <see cref="T:System.Collections.IList" /> фиксированный размер.</summary>
		/// <returns>Значение <see langword="true" />, если словарь <see cref="T:System.Collections.IList" /> имеет фиксированный размер; в противном случае — значение <see langword="false" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.Generic.List`1" /> это свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x06006148 RID: 24904 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		bool IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x06006149 RID: 24905 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		bool ICollection<!0>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает значение, указывающее, является ли объект <see cref="T:System.Collections.IList" /> доступным только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если интерфейс <see cref="T:System.Collections.IList" /> доступен только для чтения; в противном случае — значение <see langword="false" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.Generic.List`1" /> это свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x17001152 RID: 4434
		// (get) Token: 0x0600614A RID: 24906 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		bool IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает значение, показывающее, является ли доступ к коллекции <see cref="T:System.Collections.ICollection" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>
		///   <see langword="true" />, если доступ к классу <see cref="T:System.Collections.ICollection" /> является синхронизированным (потокобезопасным); в противном случае — <see langword="false" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.Generic.List`1" /> это свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x0600614B RID: 24907 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.ICollection" />.</summary>
		/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Collections.ICollection" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.Generic.List`1" /> это свойство всегда возвращает текущий экземпляр.</returns>
		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x0600614C RID: 24908 RVA: 0x00145405 File Offset: 0x00143605
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

		/// <summary>Возвращает или задает элемент по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс элемента, который требуется возвратить или задать.</param>
		/// <returns>Элемент, расположенный по указанному индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.  
		/// -или- 
		///  Значение параметра <paramref name="index" /> больше или равно значению свойства <see cref="P:System.Collections.Generic.List`1.Count" />.</exception>
		// Token: 0x17001155 RID: 4437
		public T this[int index]
		{
			get
			{
				if (index >= this._size)
				{
					ThrowHelper.ThrowArgumentOutOfRange_IndexException();
				}
				return this._items[index];
			}
			set
			{
				if (index >= this._size)
				{
					ThrowHelper.ThrowArgumentOutOfRange_IndexException();
				}
				this._items[index] = value;
				this._version++;
			}
		}

		// Token: 0x0600614F RID: 24911 RVA: 0x00145470 File Offset: 0x00143670
		private static bool IsCompatibleObject(object value)
		{
			return value is T || (value == null && default(T) == null);
		}

		/// <summary>Возвращает или задает элемент по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс элемента, который требуется возвратить или задать.</param>
		/// <returns>Элемент, расположенный по указанному индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> не является допустимым индексом в <see cref="T:System.Collections.IList" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство задано, и тип параметра <paramref name="value" /> не может быть назначен <see cref="T:System.Collections.IList" />.</exception>
		// Token: 0x17001156 RID: 4438
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(value, ExceptionArgument.value);
				try
				{
					this[index] = (T)((object)value);
				}
				catch (InvalidCastException)
				{
					ThrowHelper.ThrowWrongValueTypeArgumentException(value, typeof(T));
				}
			}
		}

		/// <summary>Добавляет объект в конец очереди <see cref="T:System.Collections.Generic.List`1" />.</summary>
		/// <param name="item">Объект, добавляемый в конец коллекции <see cref="T:System.Collections.Generic.List`1" />. Для ссылочных типов допускается значение <see langword="null" />.</param>
		// Token: 0x06006152 RID: 24914 RVA: 0x001454F4 File Offset: 0x001436F4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Add(T item)
		{
			this._version++;
			T[] items = this._items;
			int size = this._size;
			if (size < items.Length)
			{
				this._size = size + 1;
				items[size] = item;
				return;
			}
			this.AddWithResize(item);
		}

		// Token: 0x06006153 RID: 24915 RVA: 0x0014553C File Offset: 0x0014373C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AddWithResize(T item)
		{
			int size = this._size;
			this.EnsureCapacity(size + 1);
			this._size = size + 1;
			this._items[size] = item;
		}

		/// <summary>Добавляет элемент в коллекцию <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="item">Объект <see cref="T:System.Object" />, добавляемый в список <see cref="T:System.Collections.IList" />.</param>
		/// <returns>Позиция, на которую вставлен новый элемент.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="item" /> имеет тип, который не может быть назначен <see cref="T:System.Collections.IList" />.</exception>
		// Token: 0x06006154 RID: 24916 RVA: 0x00145570 File Offset: 0x00143770
		int IList.Add(object item)
		{
			ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(item, ExceptionArgument.item);
			try
			{
				this.Add((T)((object)item));
			}
			catch (InvalidCastException)
			{
				ThrowHelper.ThrowWrongValueTypeArgumentException(item, typeof(T));
			}
			return this.Count - 1;
		}

		/// <summary>Добавляет элементы указанной коллекции в конец списка <see cref="T:System.Collections.Generic.List`1" />.</summary>
		/// <param name="collection">Коллекция, элементы которой добавляются в конец списка <see cref="T:System.Collections.Generic.List`1" />. Коллекция не может быть задана значением <see langword="null" />, но может содержать элементы <see langword="null" />, если тип <paramref name="T" /> является ссылочным типом.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="collection" /> — <see langword="null" />.</exception>
		// Token: 0x06006155 RID: 24917 RVA: 0x001455C0 File Offset: 0x001437C0
		public void AddRange(IEnumerable<T> collection)
		{
			this.InsertRange(this._size, collection);
		}

		/// <summary>Возвращает для текущей коллекции оболочку <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />, доступную только для чтения.</summary>
		/// <returns>Объект, который служит оболочкой, обеспечивающей доступность текущего списка <see cref="T:System.Collections.Generic.List`1" /> только для чтения.</returns>
		// Token: 0x06006156 RID: 24918 RVA: 0x001455CF File Offset: 0x001437CF
		public ReadOnlyCollection<T> AsReadOnly()
		{
			return new ReadOnlyCollection<T>(this);
		}

		/// <summary>Выполняет поиск элемента в диапазоне элементов отсортированного списка <see cref="T:System.Collections.Generic.List`1" />, используя указанную функцию сравнения, и возвращает индекс элемента, отсчитываемый от нуля.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс начала диапазона поиска.</param>
		/// <param name="count">Длина диапазона поиска.</param>
		/// <param name="item">Искомый объект. Для ссылочных типов допускается значение <see langword="null" />.</param>
		/// <param name="comparer">Реализация <see cref="T:System.Collections.Generic.IComparer`1" />, которую следует использовать при сравнении элементов, или <see langword="null" />, если должна использоваться функция сравнения по умолчанию <see cref="P:System.Collections.Generic.Comparer`1.Default" />.</param>
		/// <returns>Отсчитываемый от нуля индекс элемента <paramref name="item" /> в отсортированном списке <see cref="T:System.Collections.Generic.List`1" />, если элемент <paramref name="item" /> найден; в противном случае — отрицательное число, которое является поразрядным дополнением индекса следующего элемента, большего, чем <paramref name="item" />, или, если большего элемента не существует, поразрядным дополнением значения <see cref="P:System.Collections.Generic.List`1.Count" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше 0.</exception>
		/// <exception cref="T:System.ArgumentException">Параметры <paramref name="index" /> и <paramref name="count" /> не указывают допустимый диапазон в <see cref="T:System.Collections.Generic.List`1" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="comparer" /> имеет значение <see langword="null" />, а функция сравнения по умолчанию <see cref="P:System.Collections.Generic.Comparer`1.Default" /> не может найти реализацию универсального интерфейса <see cref="T:System.IComparable`1" /> или интерфейса <see cref="T:System.IComparable" /> для типа <paramref name="T" />.</exception>
		// Token: 0x06006157 RID: 24919 RVA: 0x001455D7 File Offset: 0x001437D7
		public int BinarySearch(int index, int count, T item, IComparer<T> comparer)
		{
			if (index < 0)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (count < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (this._size - index < count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
			}
			return Array.BinarySearch<T>(this._items, index, count, item, comparer);
		}

		/// <summary>Выполняет поиск элемента по всему отсортированному списку <see cref="T:System.Collections.Generic.List`1" />, используя компаратор по умолчанию, и возвращает индекс элемента, отсчитываемый от нуля.</summary>
		/// <param name="item">Искомый объект. Для ссылочных типов допускается значение <see langword="null" />.</param>
		/// <returns>Отсчитываемый от нуля индекс элемента <paramref name="item" /> в отсортированном списке <see cref="T:System.Collections.Generic.List`1" />, если элемент <paramref name="item" /> найден; в противном случае — отрицательное число, которое является поразрядным дополнением индекса следующего элемента, большего, чем <paramref name="item" />, или, если большего элемента не существует, поразрядным дополнением значения <see cref="P:System.Collections.Generic.List`1.Count" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Функция сравнения по умолчанию <see cref="P:System.Collections.Generic.Comparer`1.Default" /> не может найти реализацию универсального интерфейса <see cref="T:System.IComparable`1" /> или интерфейса <see cref="T:System.IComparable" /> для типа <paramref name="T" />.</exception>
		// Token: 0x06006158 RID: 24920 RVA: 0x00145610 File Offset: 0x00143810
		public int BinarySearch(T item)
		{
			return this.BinarySearch(0, this.Count, item, null);
		}

		/// <summary>Выполняет поиск элемента по всему отсортированному списку <see cref="T:System.Collections.Generic.List`1" />, используя указанный компаратор, и возвращает индекс элемента, отсчитываемый от нуля.</summary>
		/// <param name="item">Искомый объект. Для ссылочных типов допускается значение <see langword="null" />.</param>
		/// <param name="comparer">Реализация интерфейса <see cref="T:System.Collections.Generic.IComparer`1" />, которая используется при сравнении элементов.  
		/// -или- 
		///  <see langword="null" />, если необходимо использовать функцию сравнения по умолчанию <see cref="P:System.Collections.Generic.Comparer`1.Default" />.</param>
		/// <returns>Отсчитываемый от нуля индекс элемента <paramref name="item" /> в отсортированном списке <see cref="T:System.Collections.Generic.List`1" />, если элемент <paramref name="item" /> найден; в противном случае — отрицательное число, которое является поразрядным дополнением индекса следующего элемента, большего, чем <paramref name="item" />, или, если большего элемента не существует, поразрядным дополнением значения <see cref="P:System.Collections.Generic.List`1.Count" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="comparer" /> имеет значение <see langword="null" />, а функция сравнения по умолчанию <see cref="P:System.Collections.Generic.Comparer`1.Default" /> не может найти реализацию универсального интерфейса <see cref="T:System.IComparable`1" /> или интерфейса <see cref="T:System.IComparable" /> для типа <paramref name="T" />.</exception>
		// Token: 0x06006159 RID: 24921 RVA: 0x00145621 File Offset: 0x00143821
		public int BinarySearch(T item, IComparer<T> comparer)
		{
			return this.BinarySearch(0, this.Count, item, comparer);
		}

		/// <summary>Удаляет из коллекции <see cref="T:System.Collections.Generic.List`1" /> все элементы.</summary>
		// Token: 0x0600615A RID: 24922 RVA: 0x00145634 File Offset: 0x00143834
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Clear()
		{
			this._version++;
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				int size = this._size;
				this._size = 0;
				if (size > 0)
				{
					Array.Clear(this._items, 0, size);
					return;
				}
			}
			else
			{
				this._size = 0;
			}
		}

		/// <summary>Определяет, входит ли элемент в коллекцию <see cref="T:System.Collections.Generic.List`1" />.</summary>
		/// <param name="item">Объект для поиска в <see cref="T:System.Collections.Generic.List`1" />. Для ссылочных типов допускается значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="item" /> найден в коллекции <see cref="T:System.Collections.Generic.List`1" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600615B RID: 24923 RVA: 0x0014567D File Offset: 0x0014387D
		public bool Contains(T item)
		{
			return this._size != 0 && this.IndexOf(item) != -1;
		}

		/// <summary>Определяет, содержит ли коллекция <see cref="T:System.Collections.IList" /> указанное значение.</summary>
		/// <param name="item">Объект <see cref="T:System.Object" />, который требуется найти в коллекции <see cref="T:System.Collections.IList" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="item" /> найден в коллекции <see cref="T:System.Collections.IList" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600615C RID: 24924 RVA: 0x00145696 File Offset: 0x00143896
		bool IList.Contains(object item)
		{
			return List<T>.IsCompatibleObject(item) && this.Contains((T)((object)item));
		}

		/// <summary>Преобразует элементы текущего списка <see cref="T:System.Collections.Generic.List`1" /> в другой тип и возвращает список преобразованных элементов.</summary>
		/// <param name="converter">Делегат <see cref="T:System.Converter`2" />, преобразующий каждый элемент из одного типа в другой.</param>
		/// <typeparam name="TOutput">Тип элементов массива назначения.</typeparam>
		/// <returns>Список <see cref="T:System.Collections.Generic.List`1" /> с элементами конечного типа, преобразованными из текущего списка <see cref="T:System.Collections.Generic.List`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="converter" /> — <see langword="null" />.</exception>
		// Token: 0x0600615D RID: 24925 RVA: 0x001456B0 File Offset: 0x001438B0
		public List<TOutput> ConvertAll<TOutput>(Converter<T, TOutput> converter)
		{
			if (converter == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.converter);
			}
			List<TOutput> list = new List<TOutput>(this._size);
			for (int i = 0; i < this._size; i++)
			{
				list._items[i] = converter(this._items[i]);
			}
			list._size = this._size;
			return list;
		}

		/// <summary>Копирует весь список <see cref="T:System.Collections.Generic.List`1" /> в совместимый одномерный массив, начиная с первого элемента целевого массива.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из интерфейса <see cref="T:System.Collections.Generic.List`1" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Число элементов в исходном массиве <see cref="T:System.Collections.Generic.List`1" /> больше числа элементов, которые может содержать массив назначения <paramref name="array" />.</exception>
		// Token: 0x0600615E RID: 24926 RVA: 0x0014570F File Offset: 0x0014390F
		public void CopyTo(T[] array)
		{
			this.CopyTo(array, 0);
		}

		/// <summary>Копирует элементы коллекции <see cref="T:System.Collections.ICollection" /> в массив <see cref="T:System.Array" />, начиная с указанного индекса массива <see cref="T:System.Array" />.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из интерфейса <see cref="T:System.Collections.ICollection" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="arrayIndex">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="arrayIndex" /> меньше 0.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		/// -или- 
		///  В массиве <paramref name="array" /> не используется индексация, начинающаяся с нуля.  
		/// -или- 
		/// Число элементов в исходном массиве <see cref="T:System.Collections.ICollection" /> больше доступного места от положения, заданного значением параметра <paramref name="arrayIndex" />, до конца массива назначения <paramref name="array" />.  
		/// -или- 
		/// Тип исходного массива <see cref="T:System.Collections.ICollection" /> не может быть автоматически приведен к типу массива назначения <paramref name="array" />.</exception>
		// Token: 0x0600615F RID: 24927 RVA: 0x0014571C File Offset: 0x0014391C
		void ICollection.CopyTo(Array array, int arrayIndex)
		{
			if (array != null && array.Rank != 1)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
			}
			try
			{
				Array.Copy(this._items, 0, array, arrayIndex, this._size);
			}
			catch (ArrayTypeMismatchException)
			{
				ThrowHelper.ThrowArgumentException_Argument_InvalidArrayType();
			}
		}

		/// <summary>Копирует диапазон элементов из списка <see cref="T:System.Collections.Generic.List`1" /> в совместимый одномерный массив, начиная с указанного индекса конечного массива.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс исходного списка <see cref="T:System.Collections.Generic.List`1" />, с которого начинается копирование.</param>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из интерфейса <see cref="T:System.Collections.Generic.List`1" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="arrayIndex">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <param name="count">Число элементов для копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.  
		/// -или- 
		///  Значение параметра <paramref name="arrayIndex" /> меньше 0.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше 0.</exception>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="index" /> больше или равно значению <see cref="P:System.Collections.Generic.List`1.Count" /> исходного списка <see cref="T:System.Collections.Generic.List`1" />.  
		/// -или- 
		/// Число элементов от <paramref name="index" /> до конца исходного списка <see cref="T:System.Collections.Generic.List`1" /> больше доступного места от положения, заданного значением параметра <paramref name="arrayIndex" />, до конца массива назначения <paramref name="array" />.</exception>
		// Token: 0x06006160 RID: 24928 RVA: 0x0014576C File Offset: 0x0014396C
		public void CopyTo(int index, T[] array, int arrayIndex, int count)
		{
			if (this._size - index < count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
			}
			Array.Copy(this._items, index, array, arrayIndex, count);
		}

		/// <summary>Копирует <see cref="T:System.Collections.Generic.List`1" /> целиком в совместимый одномерный массив, начиная с указанного индекса конечного массива.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из интерфейса <see cref="T:System.Collections.Generic.List`1" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="arrayIndex">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="arrayIndex" /> меньше 0.</exception>
		/// <exception cref="T:System.ArgumentException">Число элементов в исходной коллекции <see cref="T:System.Collections.Generic.List`1" /> больше доступного места от положения, заданного значением параметра <paramref name="arrayIndex" />, до конца массива назначения <paramref name="array" />.</exception>
		// Token: 0x06006161 RID: 24929 RVA: 0x00145791 File Offset: 0x00143991
		public void CopyTo(T[] array, int arrayIndex)
		{
			Array.Copy(this._items, 0, array, arrayIndex, this._size);
		}

		// Token: 0x06006162 RID: 24930 RVA: 0x001457A8 File Offset: 0x001439A8
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

		/// <summary>Определяет, содержит ли <see cref="T:System.Collections.Generic.List`1" /> элементы, удовлетворяющие условиям указанного предиката.</summary>
		/// <param name="match">Делегат <see cref="T:System.Predicate`1" />, определяющий условия поиска элементов.</param>
		/// <returns>
		///   <see langword="true" />, если <see cref="T:System.Collections.Generic.List`1" /> содержит один или несколько элементов, удовлетворяющих условиям указанного предиката, в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="match" /> — <see langword="null" />.</exception>
		// Token: 0x06006163 RID: 24931 RVA: 0x001457F2 File Offset: 0x001439F2
		public bool Exists(Predicate<T> match)
		{
			return this.FindIndex(match) != -1;
		}

		/// <summary>Выполняет поиск элемента, удовлетворяющего условиям указанного предиката, и возвращает первое найденное вхождение в пределах всего списка <see cref="T:System.Collections.Generic.List`1" />.</summary>
		/// <param name="match">Делегат <see cref="T:System.Predicate`1" />, определяющий условия поиска элемента.</param>
		/// <returns>Первый элемент, удовлетворяющий условиям указанного предиката, если такой элемент найден; в противном случае — значение по умолчанию для типа <paramref name="T" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="match" /> — <see langword="null" />.</exception>
		// Token: 0x06006164 RID: 24932 RVA: 0x00145804 File Offset: 0x00143A04
		public T Find(Predicate<T> match)
		{
			if (match == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
			}
			for (int i = 0; i < this._size; i++)
			{
				if (match(this._items[i]))
				{
					return this._items[i];
				}
			}
			return default(T);
		}

		/// <summary>Извлекает все элементы, удовлетворяющие условиям указанного предиката.</summary>
		/// <param name="match">Делегат <see cref="T:System.Predicate`1" />, определяющий условия поиска элементов.</param>
		/// <returns>Список <see cref="T:System.Collections.Generic.List`1" />, содержащий все элементы, удовлетворяющие условиям указанного предиката, если такие элементы найдены; в противном случае — пустой список <see cref="T:System.Collections.Generic.List`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="match" /> — <see langword="null" />.</exception>
		// Token: 0x06006165 RID: 24933 RVA: 0x00145858 File Offset: 0x00143A58
		public List<T> FindAll(Predicate<T> match)
		{
			if (match == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
			}
			List<T> list = new List<T>();
			for (int i = 0; i < this._size; i++)
			{
				if (match(this._items[i]))
				{
					list.Add(this._items[i]);
				}
			}
			return list;
		}

		/// <summary>Выполняет поиск элемента, удовлетворяющего условиям указанного предиката, и возвращает отсчитываемый от нуля индекс первого найденного вхождения в пределах всего списка <see cref="T:System.Collections.Generic.List`1" />.</summary>
		/// <param name="match">Делегат <see cref="T:System.Predicate`1" />, определяющий условия поиска элемента.</param>
		/// <returns>Отсчитываемый от нуля индекс первого вхождения элемента, отвечающего условиям предиката <paramref name="match" />, если такой элемент найден. В противном случае значение –1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="match" /> — <see langword="null" />.</exception>
		// Token: 0x06006166 RID: 24934 RVA: 0x001458AC File Offset: 0x00143AAC
		public int FindIndex(Predicate<T> match)
		{
			return this.FindIndex(0, this._size, match);
		}

		/// <summary>Выполняет поиск элемента, удовлетворяющего условиям указанного предиката, и возвращает отсчитываемый от нуля индекс первого вхождения в диапазоне элементов списка <see cref="T:System.Collections.Generic.List`1" />, начиная с заданного индекса и заканчивая последним элементом.</summary>
		/// <param name="startIndex">Индекс (с нуля) начальной позиции поиска.</param>
		/// <param name="match">Делегат <see cref="T:System.Predicate`1" />, определяющий условия поиска элемента.</param>
		/// <returns>Отсчитываемый от нуля индекс первого вхождения элемента, отвечающего условиям предиката <paramref name="match" />, если такой элемент найден. В противном случае значение –1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="match" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> находится вне диапазона допустимых индексов для <see cref="T:System.Collections.Generic.List`1" />.</exception>
		// Token: 0x06006167 RID: 24935 RVA: 0x001458BC File Offset: 0x00143ABC
		public int FindIndex(int startIndex, Predicate<T> match)
		{
			return this.FindIndex(startIndex, this._size - startIndex, match);
		}

		/// <summary>Выполняет поиск элемента, удовлетворяющего условиям указанного предиката, и возвращает отсчитываемый от нуля индекс первого вхождения в диапазоне элементов списка <see cref="T:System.Collections.Generic.List`1" />, начинающемся с заданного индекса и содержащем указанное число элементов.</summary>
		/// <param name="startIndex">Индекс (с нуля) начальной позиции поиска.</param>
		/// <param name="count">Число элементов в диапазоне, в котором выполняется поиск.</param>
		/// <param name="match">Делегат <see cref="T:System.Predicate`1" />, определяющий условия поиска элемента.</param>
		/// <returns>Отсчитываемый от нуля индекс первого вхождения элемента, отвечающего условиям предиката <paramref name="match" />, если такой элемент найден. В противном случае значение –1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="match" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> находится вне диапазона допустимых индексов для <see cref="T:System.Collections.Generic.List`1" />.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше 0.  
		/// -или- 
		///  <paramref name="startIndex" /> и <paramref name="count" /> не указывают допустимый раздел в <see cref="T:System.Collections.Generic.List`1" />.</exception>
		// Token: 0x06006168 RID: 24936 RVA: 0x001458D0 File Offset: 0x00143AD0
		public int FindIndex(int startIndex, int count, Predicate<T> match)
		{
			if (startIndex > this._size)
			{
				ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index();
			}
			if (count < 0 || startIndex > this._size - count)
			{
				ThrowHelper.ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count();
			}
			if (match == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
			}
			int num = startIndex + count;
			for (int i = startIndex; i < num; i++)
			{
				if (match(this._items[i]))
				{
					return i;
				}
			}
			return -1;
		}

		/// <summary>Выполняет поиск элемента, удовлетворяющего условиям указанного предиката, и возвращает последнее найденное вхождение в пределах всего списка <see cref="T:System.Collections.Generic.List`1" />.</summary>
		/// <param name="match">Делегат <see cref="T:System.Predicate`1" />, определяющий условия поиска элемента.</param>
		/// <returns>Последний элемент, удовлетворяющий условиям указанного предиката, если такой элемент найден; в противном случае — значение по умолчанию для типа <paramref name="T" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="match" /> — <see langword="null" />.</exception>
		// Token: 0x06006169 RID: 24937 RVA: 0x00145930 File Offset: 0x00143B30
		public T FindLast(Predicate<T> match)
		{
			if (match == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
			}
			for (int i = this._size - 1; i >= 0; i--)
			{
				if (match(this._items[i]))
				{
					return this._items[i];
				}
			}
			return default(T);
		}

		/// <summary>Выполняет поиск элемента, удовлетворяющего условиям указанного предиката, и возвращает отсчитываемый от нуля индекс последнего найденного вхождения в пределах всего списка <see cref="T:System.Collections.Generic.List`1" />.</summary>
		/// <param name="match">Делегат <see cref="T:System.Predicate`1" />, определяющий условия поиска элемента.</param>
		/// <returns>Отсчитываемый от нуля индекс последнего вхождения элемента, удовлетворяющего условиям предиката <paramref name="match" />, если такой элемент найден; в противном случае — значение –1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="match" /> — <see langword="null" />.</exception>
		// Token: 0x0600616A RID: 24938 RVA: 0x00145983 File Offset: 0x00143B83
		public int FindLastIndex(Predicate<T> match)
		{
			return this.FindLastIndex(this._size - 1, this._size, match);
		}

		/// <summary>Выполняет поиск элемента, удовлетворяющего условиям указанного предиката, и возвращает отсчитываемый от нуля индекс последнего вхождения в диапазоне элементов списка <see cref="T:System.Collections.Generic.List`1" />, начиная с первого элемента и заканчивая элементом с заданным индексом.</summary>
		/// <param name="startIndex">Индекс (с нуля) начала диапазона поиска в обратном направлении.</param>
		/// <param name="match">Делегат <see cref="T:System.Predicate`1" />, определяющий условия поиска элемента.</param>
		/// <returns>Отсчитываемый от нуля индекс последнего вхождения элемента, удовлетворяющего условиям предиката <paramref name="match" />, если такой элемент найден; в противном случае — значение –1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="match" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> находится вне диапазона допустимых индексов для <see cref="T:System.Collections.Generic.List`1" />.</exception>
		// Token: 0x0600616B RID: 24939 RVA: 0x0014599A File Offset: 0x00143B9A
		public int FindLastIndex(int startIndex, Predicate<T> match)
		{
			return this.FindLastIndex(startIndex, startIndex + 1, match);
		}

		/// <summary>Выполняет поиск элемента, удовлетворяющего условиям указанного предиката, и возвращает отсчитываемый от нуля индекс последнего вхождения в диапазоне элементов списка <see cref="T:System.Collections.Generic.List`1" />, содержащем указанное число элементов и заканчивающемся элементом с заданным индексом.</summary>
		/// <param name="startIndex">Индекс (с нуля) начала диапазона поиска в обратном направлении.</param>
		/// <param name="count">Число элементов в диапазоне, в котором выполняется поиск.</param>
		/// <param name="match">Делегат <see cref="T:System.Predicate`1" />, определяющий условия поиска элемента.</param>
		/// <returns>Отсчитываемый от нуля индекс последнего вхождения элемента, удовлетворяющего условиям предиката <paramref name="match" />, если такой элемент найден; в противном случае — значение –1.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="match" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> находится вне диапазона допустимых индексов для <see cref="T:System.Collections.Generic.List`1" />.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше 0.  
		/// -или- 
		///  <paramref name="startIndex" /> и <paramref name="count" /> не указывают допустимый раздел в <see cref="T:System.Collections.Generic.List`1" />.</exception>
		// Token: 0x0600616C RID: 24940 RVA: 0x001459A8 File Offset: 0x00143BA8
		public int FindLastIndex(int startIndex, int count, Predicate<T> match)
		{
			if (match == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
			}
			if (this._size == 0)
			{
				if (startIndex != -1)
				{
					ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index();
				}
			}
			else if (startIndex >= this._size)
			{
				ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index();
			}
			if (count < 0 || startIndex - count + 1 < 0)
			{
				ThrowHelper.ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count();
			}
			int num = startIndex - count;
			for (int i = startIndex; i > num; i--)
			{
				if (match(this._items[i]))
				{
					return i;
				}
			}
			return -1;
		}

		/// <summary>Выполняет указанное действие с каждым элементом списка <see cref="T:System.Collections.Generic.List`1" />.</summary>
		/// <param name="action">Делегат <see cref="T:System.Action`1" />, выполняемый для каждого элемента списка <see cref="T:System.Collections.Generic.List`1" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="action" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Элемент в коллекции изменен.</exception>
		// Token: 0x0600616D RID: 24941 RVA: 0x00145A18 File Offset: 0x00143C18
		public void ForEach(Action<T> action)
		{
			if (action == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.action);
			}
			int version = this._version;
			int num = 0;
			while (num < this._size && version == this._version)
			{
				action(this._items[num]);
				num++;
			}
			if (version != this._version)
			{
				ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
			}
		}

		/// <summary>Возвращает перечислитель, осуществляющий перебор элементов списка <see cref="T:System.Collections.Generic.List`1" />.</summary>
		/// <returns>Новый объект <see cref="T:System.Collections.Generic.List`1.Enumerator" /> для <see cref="T:System.Collections.Generic.List`1" />.</returns>
		// Token: 0x0600616E RID: 24942 RVA: 0x00145A70 File Offset: 0x00143C70
		public List<T>.Enumerator GetEnumerator()
		{
			return new List<T>.Enumerator(this);
		}

		// Token: 0x0600616F RID: 24943 RVA: 0x00145A78 File Offset: 0x00143C78
		IEnumerator<T> IEnumerable<!0>.GetEnumerator()
		{
			return new List<T>.Enumerator(this);
		}

		/// <summary>Возвращает перечислитель, который осуществляет итерацию по коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для итерации элементов коллекции.</returns>
		// Token: 0x06006170 RID: 24944 RVA: 0x00145A78 File Offset: 0x00143C78
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new List<T>.Enumerator(this);
		}

		/// <summary>Создает неполную копию диапазона элементов исходного списка <see cref="T:System.Collections.Generic.List`1" />.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс списка <see cref="T:System.Collections.Generic.List`1" />, с которого начинается диапазон.</param>
		/// <param name="count">Число элементов в диапазоне.</param>
		/// <returns>Неполная копия диапазона элементов исходного списка <see cref="T:System.Collections.Generic.List`1" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше 0.</exception>
		/// <exception cref="T:System.ArgumentException">Параметры <paramref name="index" /> и <paramref name="count" /> не указывают допустимый диапазон элементов в списке <see cref="T:System.Collections.Generic.List`1" />.</exception>
		// Token: 0x06006171 RID: 24945 RVA: 0x00145A88 File Offset: 0x00143C88
		public List<T> GetRange(int index, int count)
		{
			if (index < 0)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (count < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (this._size - index < count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
			}
			List<T> list = new List<T>(count);
			Array.Copy(this._items, index, list._items, 0, count);
			list._size = count;
			return list;
		}

		/// <summary>Осуществляет поиск указанного объекта и возвращает отсчитываемый от нуля индекс первого вхождения, найденного в пределах всего списка <see cref="T:System.Collections.Generic.List`1" />.</summary>
		/// <param name="item">Объект для поиска в <see cref="T:System.Collections.Generic.List`1" />. Для ссылочных типов допускается значение <see langword="null" />.</param>
		/// <returns>Индекс (с нуля) первого вхождения параметра <paramref name="item" />, если оно найдено в коллекции <see cref="T:System.Collections.Generic.List`1" />; в противном случае -1.</returns>
		// Token: 0x06006172 RID: 24946 RVA: 0x00145ADF File Offset: 0x00143CDF
		public int IndexOf(T item)
		{
			return Array.IndexOf<T>(this._items, item, 0, this._size);
		}

		/// <summary>Определяет индекс заданного элемента в списке <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="item">Объект для поиска в <see cref="T:System.Collections.IList" />.</param>
		/// <returns>Индекс <paramref name="item" />, если он найден в списке; в противном случае — значение -1.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="item" /> имеет тип, который не может быть назначен <see cref="T:System.Collections.IList" />.</exception>
		// Token: 0x06006173 RID: 24947 RVA: 0x00145AF4 File Offset: 0x00143CF4
		int IList.IndexOf(object item)
		{
			if (List<T>.IsCompatibleObject(item))
			{
				return this.IndexOf((T)((object)item));
			}
			return -1;
		}

		/// <summary>Осуществляет поиск указанного объекта и возвращает отсчитываемый от нуля индекс первого вхождения в диапазоне элементов списка <see cref="T:System.Collections.Generic.List`1" />, начиная с заданного индекса и до последнего элемента.</summary>
		/// <param name="item">Объект для поиска в <see cref="T:System.Collections.Generic.List`1" />. Для ссылочных типов допускается значение <see langword="null" />.</param>
		/// <param name="index">Индекс (с нуля) начальной позиции поиска. Значение 0 (ноль) действительно в пустом списке.</param>
		/// <returns>Отсчитываемый от нуля индекс первого вхождения элемента <paramref name="item" /> в диапазоне элементов списка <see cref="T:System.Collections.Generic.List`1" />, начиная с позиции <paramref name="index" /> и до конца списка, если элемент найден; в противном случае значение –1.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> находится вне диапазона допустимых индексов для <see cref="T:System.Collections.Generic.List`1" />.</exception>
		// Token: 0x06006174 RID: 24948 RVA: 0x00145B0C File Offset: 0x00143D0C
		public int IndexOf(T item, int index)
		{
			if (index > this._size)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexException();
			}
			return Array.IndexOf<T>(this._items, item, index, this._size - index);
		}

		/// <summary>Выполняет поиск указанного объекта и возвращает отсчитываемый от нуля индекс первого вхождения в диапазоне элементов списка <see cref="T:System.Collections.Generic.List`1" />, начинающемся с заданного индекса и содержащем указанное число элементов.</summary>
		/// <param name="item">Объект для поиска в <see cref="T:System.Collections.Generic.List`1" />. Для ссылочных типов допускается значение <see langword="null" />.</param>
		/// <param name="index">Индекс (с нуля) начальной позиции поиска. Значение 0 (ноль) действительно в пустом списке.</param>
		/// <param name="count">Число элементов в диапазоне, в котором выполняется поиск.</param>
		/// <returns>Отсчитываемый от нуля индекс первого вхождения <paramref name="item" /> в диапазоне элементов списка <see cref="T:System.Collections.Generic.List`1" />, который начинается с позиции <paramref name="index" /> и содержит <paramref name="count" /> элементов, если искомый объект найден; в противном случае значение –1.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> находится вне диапазона допустимых индексов для <see cref="T:System.Collections.Generic.List`1" />.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше 0.  
		/// -или- 
		///  <paramref name="index" /> и <paramref name="count" /> не указывают допустимый раздел в <see cref="T:System.Collections.Generic.List`1" />.</exception>
		// Token: 0x06006175 RID: 24949 RVA: 0x00145B31 File Offset: 0x00143D31
		public int IndexOf(T item, int index, int count)
		{
			if (index > this._size)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexException();
			}
			if (count < 0 || index > this._size - count)
			{
				ThrowHelper.ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count();
			}
			return Array.IndexOf<T>(this._items, item, index, count);
		}

		/// <summary>Вставляет элемент в коллекцию <see cref="T:System.Collections.Generic.List`1" /> по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс, по которому следует вставить элемент <paramref name="item" />.</param>
		/// <param name="item">Вставляемый объект. Для ссылочных типов допускается значение <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="index" /> больше значения <see cref="P:System.Collections.Generic.List`1.Count" />.</exception>
		// Token: 0x06006176 RID: 24950 RVA: 0x00145B64 File Offset: 0x00143D64
		public void Insert(int index, T item)
		{
			if (index > this._size)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_ListInsert);
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

		/// <summary>Вставляет элемент в список <see cref="T:System.Collections.IList" /> по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс, по которому следует вставить элемент <paramref name="item" />.</param>
		/// <param name="item">Объект, вставляемый в коллекцию <see cref="T:System.Collections.IList" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> не является допустимым индексом в <see cref="T:System.Collections.IList" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="item" /> имеет тип, который не может быть назначен <see cref="T:System.Collections.IList" />.</exception>
		// Token: 0x06006177 RID: 24951 RVA: 0x00145BF0 File Offset: 0x00143DF0
		void IList.Insert(int index, object item)
		{
			ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(item, ExceptionArgument.item);
			try
			{
				this.Insert(index, (T)((object)item));
			}
			catch (InvalidCastException)
			{
				ThrowHelper.ThrowWrongValueTypeArgumentException(item, typeof(T));
			}
		}

		/// <summary>Вставляет элементы коллекции в список <see cref="T:System.Collections.Generic.List`1" /> в позиции с указанным индексом.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс места вставки новых элементов.</param>
		/// <param name="collection">Коллекция, элементы которой следует вставить в список <see cref="T:System.Collections.Generic.List`1" />. Коллекция не может быть задана значением <see langword="null" />, но может содержать элементы <see langword="null" />, если тип <paramref name="T" /> является ссылочным типом.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="collection" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.  
		/// -или- 
		///  Значение <paramref name="index" /> больше значения <see cref="P:System.Collections.Generic.List`1.Count" />.</exception>
		// Token: 0x06006178 RID: 24952 RVA: 0x00145C38 File Offset: 0x00143E38
		public void InsertRange(int index, IEnumerable<T> collection)
		{
			if (collection == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.collection);
			}
			if (index > this._size)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexException();
			}
			ICollection<T> collection2 = collection as ICollection<T>;
			if (collection2 != null)
			{
				int count = collection2.Count;
				if (count > 0)
				{
					this.EnsureCapacity(this._size + count);
					if (index < this._size)
					{
						Array.Copy(this._items, index, this._items, index + count, this._size - index);
					}
					if (this == collection2)
					{
						Array.Copy(this._items, 0, this._items, index, index);
						Array.Copy(this._items, index + count, this._items, index * 2, this._size - index);
					}
					else
					{
						collection2.CopyTo(this._items, index);
					}
					this._size += count;
				}
			}
			else
			{
				if (index < this._size)
				{
					using (IEnumerator<T> enumerator = collection.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							T item = enumerator.Current;
							this.Insert(index++, item);
						}
						goto IL_FB;
					}
				}
				this.AddEnumerable(collection);
			}
			IL_FB:
			this._version++;
		}

		/// <summary>Осуществляет поиск указанного объекта и возвращает отсчитываемый от нуля индекс последнего вхождения, найденного в пределах всего списка <see cref="T:System.Collections.Generic.List`1" />.</summary>
		/// <param name="item">Объект для поиска в <see cref="T:System.Collections.Generic.List`1" />. Для ссылочных типов допускается значение <see langword="null" />.</param>
		/// <returns>Отсчитываемый от нуля индекс последнего вхождения <paramref name="item" /> в пределах всего списка <see cref="T:System.Collections.Generic.List`1" />, если элемент найден; в противном случае значение –1.</returns>
		// Token: 0x06006179 RID: 24953 RVA: 0x00145D60 File Offset: 0x00143F60
		public int LastIndexOf(T item)
		{
			if (this._size == 0)
			{
				return -1;
			}
			return this.LastIndexOf(item, this._size - 1, this._size);
		}

		/// <summary>Осуществляет поиск указанного объекта и возвращает отсчитываемый от нуля индекс последнего вхождения в диапазоне элементов списка <see cref="T:System.Collections.Generic.List`1" />, начиная с первого элемента и до позиции с заданным индексом.</summary>
		/// <param name="item">Объект для поиска в <see cref="T:System.Collections.Generic.List`1" />. Для ссылочных типов допускается значение <see langword="null" />.</param>
		/// <param name="index">Индекс (с нуля) начала диапазона поиска в обратном направлении.</param>
		/// <returns>Отсчитываемый от нуля индекс последнего вхождения элемента <paramref name="item" /> в диапазоне элементов списка <see cref="T:System.Collections.Generic.List`1" />, начиная с первого элемента и до позиции <paramref name="index" />, если элемент найден; в противном случае значение -1.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> находится вне диапазона допустимых индексов для <see cref="T:System.Collections.Generic.List`1" />.</exception>
		// Token: 0x0600617A RID: 24954 RVA: 0x00145D81 File Offset: 0x00143F81
		public int LastIndexOf(T item, int index)
		{
			if (index >= this._size)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexException();
			}
			return this.LastIndexOf(item, index, index + 1);
		}

		/// <summary>Выполняет поиск указанного объекта и возвращает отсчитываемый от нуля индекс последнего вхождения в диапазоне элементов списка <see cref="T:System.Collections.Generic.List`1" />, содержащем указанное число элементов и заканчивающемся в позиции с указанным индексом.</summary>
		/// <param name="item">Объект для поиска в <see cref="T:System.Collections.Generic.List`1" />. Для ссылочных типов допускается значение <see langword="null" />.</param>
		/// <param name="index">Индекс (с нуля) начала диапазона поиска в обратном направлении.</param>
		/// <param name="count">Число элементов в диапазоне, в котором выполняется поиск.</param>
		/// <returns>Отсчитываемый от нуля индекс последнего вхождения <paramref name="item" /> в диапазоне элементов списка <see cref="T:System.Collections.Generic.List`1" />, состоящем из <paramref name="count" /> элементов и заканчивающемся в позиции <paramref name="index" />, если элемент найден. В противном случае значение –1.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> находится вне диапазона допустимых индексов для <see cref="T:System.Collections.Generic.List`1" />.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше 0.  
		/// -или- 
		///  <paramref name="index" /> и <paramref name="count" /> не указывают допустимый раздел в <see cref="T:System.Collections.Generic.List`1" />.</exception>
		// Token: 0x0600617B RID: 24955 RVA: 0x00145D9C File Offset: 0x00143F9C
		public int LastIndexOf(T item, int index, int count)
		{
			if (this.Count != 0 && index < 0)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (this.Count != 0 && count < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (this._size == 0)
			{
				return -1;
			}
			if (index >= this._size)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_BiggerThanCollection);
			}
			if (count > index + 1)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_BiggerThanCollection);
			}
			return Array.LastIndexOf<T>(this._items, item, index, count);
		}

		/// <summary>Удаляет первое вхождение указанного объекта из коллекции <see cref="T:System.Collections.Generic.List`1" />.</summary>
		/// <param name="item">Объект, который необходимо удалить из коллекции <see cref="T:System.Collections.Generic.List`1" />. Для ссылочных типов допускается значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если элемент <paramref name="item" /> успешно удален, в противном случае — значение <see langword="false" />.  Этот метод также возвращает <see langword="false" />, если элемент <paramref name="item" /> не найден в коллекции <see cref="T:System.Collections.Generic.List`1" />.</returns>
		// Token: 0x0600617C RID: 24956 RVA: 0x00145E08 File Offset: 0x00144008
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

		/// <summary>Удаляет первое вхождение указанного объекта из коллекции <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="item">Объект, который необходимо удалить из коллекции <see cref="T:System.Collections.IList" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="item" /> имеет тип, который не может быть назначен <see cref="T:System.Collections.IList" />.</exception>
		// Token: 0x0600617D RID: 24957 RVA: 0x00145E2B File Offset: 0x0014402B
		void IList.Remove(object item)
		{
			if (List<T>.IsCompatibleObject(item))
			{
				this.Remove((T)((object)item));
			}
		}

		/// <summary>Удаляет все элементы, удовлетворяющие условиям указанного предиката.</summary>
		/// <param name="match">Делегат <see cref="T:System.Predicate`1" />, определяющий условия удаления элемента.</param>
		/// <returns>Число элементов, удаляемых из списка <see cref="T:System.Collections.Generic.List`1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="match" /> — <see langword="null" />.</exception>
		// Token: 0x0600617E RID: 24958 RVA: 0x00145E44 File Offset: 0x00144044
		public int RemoveAll(Predicate<T> match)
		{
			if (match == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
			}
			int num = 0;
			while (num < this._size && !match(this._items[num]))
			{
				num++;
			}
			if (num >= this._size)
			{
				return 0;
			}
			int i = num + 1;
			while (i < this._size)
			{
				while (i < this._size && match(this._items[i]))
				{
					i++;
				}
				if (i < this._size)
				{
					this._items[num++] = this._items[i++];
				}
			}
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				Array.Clear(this._items, num, this._size - num);
			}
			int result = this._size - num;
			this._size = num;
			this._version++;
			return result;
		}

		/// <summary>Удаляет элемент списка <see cref="T:System.Collections.Generic.List`1" /> с указанным индексом.</summary>
		/// <param name="index">Индекс (с нуля) элемента, который требуется удалить.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.  
		/// -или- 
		///  Значение параметра <paramref name="index" /> больше или равно значению свойства <see cref="P:System.Collections.Generic.List`1.Count" />.</exception>
		// Token: 0x0600617F RID: 24959 RVA: 0x00145F1C File Offset: 0x0014411C
		public void RemoveAt(int index)
		{
			if (index >= this._size)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexException();
			}
			this._size--;
			if (index < this._size)
			{
				Array.Copy(this._items, index + 1, this._items, index, this._size - index);
			}
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				this._items[this._size] = default(T);
			}
			this._version++;
		}

		/// <summary>Удаляет диапазон элементов из списка <see cref="T:System.Collections.Generic.List`1" />.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс начала диапазона элементов, которые требуется удалить.</param>
		/// <param name="count">Число удаляемых элементов.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше 0.</exception>
		/// <exception cref="T:System.ArgumentException">Параметры <paramref name="index" /> и <paramref name="count" /> не указывают допустимый диапазон элементов в списке <see cref="T:System.Collections.Generic.List`1" />.</exception>
		// Token: 0x06006180 RID: 24960 RVA: 0x00145F9C File Offset: 0x0014419C
		public void RemoveRange(int index, int count)
		{
			if (index < 0)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (count < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (this._size - index < count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
			}
			if (count > 0)
			{
				int size = this._size;
				this._size -= count;
				if (index < this._size)
				{
					Array.Copy(this._items, index + count, this._items, index, this._size - index);
				}
				this._version++;
				if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
				{
					Array.Clear(this._items, this._size, count);
				}
			}
		}

		/// <summary>Изменяет порядок элементов во всем списке <see cref="T:System.Collections.Generic.List`1" /> на обратный.</summary>
		// Token: 0x06006181 RID: 24961 RVA: 0x00146036 File Offset: 0x00144236
		public void Reverse()
		{
			this.Reverse(0, this.Count);
		}

		/// <summary>Изменяет порядок элементов в указанном диапазоне.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс начала диапазона, порядок элементов которого требуется изменить.</param>
		/// <param name="count">Число элементов в диапазоне, порядок сортировки в котором требуется изменить.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше 0.</exception>
		/// <exception cref="T:System.ArgumentException">Параметры <paramref name="index" /> и <paramref name="count" /> не указывают допустимый диапазон элементов в списке <see cref="T:System.Collections.Generic.List`1" />.</exception>
		// Token: 0x06006182 RID: 24962 RVA: 0x00146048 File Offset: 0x00144248
		public void Reverse(int index, int count)
		{
			if (index < 0)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (count < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (this._size - index < count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
			}
			if (count > 1)
			{
				Array.Reverse<T>(this._items, index, count);
			}
			this._version++;
		}

		/// <summary>Сортирует элементы во всем списке <see cref="T:System.Collections.Generic.List`1" /> с помощью функции сравнения по умолчанию.</summary>
		/// <exception cref="T:System.InvalidOperationException">Функция сравнения по умолчанию <see cref="P:System.Collections.Generic.Comparer`1.Default" /> не может найти реализацию универсального интерфейса <see cref="T:System.IComparable`1" /> или интерфейса <see cref="T:System.IComparable" /> для типа <paramref name="T" />.</exception>
		// Token: 0x06006183 RID: 24963 RVA: 0x0014609B File Offset: 0x0014429B
		public void Sort()
		{
			this.Sort(0, this.Count, null);
		}

		/// <summary>Сортирует элементы во всем списке <see cref="T:System.Collections.Generic.List`1" /> с помощью указанной функции сравнения.</summary>
		/// <param name="comparer">Реализация <see cref="T:System.Collections.Generic.IComparer`1" />, которую следует использовать при сравнении элементов, или <see langword="null" />, если должна использоваться функция сравнения по умолчанию <see cref="P:System.Collections.Generic.Comparer`1.Default" />.</param>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="comparer" /> является <see langword="null" />, и функция сравнения по умолчанию <see cref="P:System.Collections.Generic.Comparer`1.Default" /> не может найти реализацию универсального интерфейса <see cref="T:System.IComparable`1" /> или интерфейса <see cref="T:System.IComparable" /> для типа <paramref name="T" />.</exception>
		/// <exception cref="T:System.ArgumentException">Реализация <paramref name="comparer" /> вызвала ошибку во время сортировки. Например, <paramref name="comparer" /> может не возвратить 0 при сравнении элемента с самим собой.</exception>
		// Token: 0x06006184 RID: 24964 RVA: 0x001460AB File Offset: 0x001442AB
		public void Sort(IComparer<T> comparer)
		{
			this.Sort(0, this.Count, comparer);
		}

		/// <summary>Сортирует элементы в диапазоне элементов списка <see cref="T:System.Collections.Generic.List`1" /> с помощью указанной функции сравнения.</summary>
		/// <param name="index">Индекс (с нуля) начала диапазона, который требуется отсортировать.</param>
		/// <param name="count">Длина диапазона сортировки.</param>
		/// <param name="comparer">Реализация <see cref="T:System.Collections.Generic.IComparer`1" />, которую следует использовать при сравнении элементов, или <see langword="null" />, если должна использоваться функция сравнения по умолчанию <see cref="P:System.Collections.Generic.Comparer`1.Default" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше 0.  
		/// -или- 
		///  Значение параметра <paramref name="count" /> меньше 0.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="index" /> и <paramref name="count" /> не указывают допустимый диапазон в <see cref="T:System.Collections.Generic.List`1" />.  
		/// -или- 
		/// Реализация <paramref name="comparer" /> вызвала ошибку во время сортировки. Например, <paramref name="comparer" /> может не возвратить 0 при сравнении элемента с самим собой.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="comparer" /> является <see langword="null" />, и функция сравнения по умолчанию <see cref="P:System.Collections.Generic.Comparer`1.Default" /> не может найти реализацию универсального интерфейса <see cref="T:System.IComparable`1" /> или интерфейса <see cref="T:System.IComparable" /> для типа <paramref name="T" />.</exception>
		// Token: 0x06006185 RID: 24965 RVA: 0x001460BC File Offset: 0x001442BC
		public void Sort(int index, int count, IComparer<T> comparer)
		{
			if (index < 0)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (count < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (this._size - index < count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
			}
			if (count > 1)
			{
				Array.Sort<T>(this._items, index, count, comparer);
			}
			this._version++;
		}

		/// <summary>Сортирует элементы во всем списке <see cref="T:System.Collections.Generic.List`1" /> с использованием указанного <see cref="T:System.Comparison`1" />.</summary>
		/// <param name="comparison">
		///   <see cref="T:System.Comparison`1" />, используемый при сравнении элементов.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="comparison" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Реализация <paramref name="comparison" /> вызвала ошибку во время сортировки. Например, <paramref name="comparison" /> может не возвратить 0 при сравнении элемента с самим собой.</exception>
		// Token: 0x06006186 RID: 24966 RVA: 0x00146110 File Offset: 0x00144310
		public void Sort(Comparison<T> comparison)
		{
			if (comparison == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.comparison);
			}
			if (this._size > 1)
			{
				ArraySortHelper<T>.Sort(this._items, 0, this._size, comparison);
			}
			this._version++;
		}

		/// <summary>Копирует элементы списка <see cref="T:System.Collections.Generic.List`1" /> в новый массив.</summary>
		/// <returns>Массив, содержащий копии элементов списка <see cref="T:System.Collections.Generic.List`1" />.</returns>
		// Token: 0x06006187 RID: 24967 RVA: 0x00146148 File Offset: 0x00144348
		public T[] ToArray()
		{
			if (this._size == 0)
			{
				return List<T>.s_emptyArray;
			}
			T[] array = new T[this._size];
			Array.Copy(this._items, 0, array, 0, this._size);
			return array;
		}

		/// <summary>Задает емкость, равную фактическому числу элементов в списке <see cref="T:System.Collections.Generic.List`1" />, если это число меньше порогового значения.</summary>
		// Token: 0x06006188 RID: 24968 RVA: 0x00146184 File Offset: 0x00144384
		public void TrimExcess()
		{
			int num = (int)((double)this._items.Length * 0.9);
			if (this._size < num)
			{
				this.Capacity = this._size;
			}
		}

		/// <summary>Определяет, все ли элементы списка <see cref="T:System.Collections.Generic.List`1" /> удовлетворяют условиям указанного предиката.</summary>
		/// <param name="match">Делегат <see cref="T:System.Predicate`1" />, определяющий условия, проверяемые для элементов.</param>
		/// <returns>
		///   <see langword="true" />, если каждый элемент списка <see cref="T:System.Collections.Generic.List`1" /> удовлетворяет условиям заданного предиката, в противном случае — <see langword="false" />. Если в списке нет элементов, возвращается <see langword="true" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="match" /> — <see langword="null" />.</exception>
		// Token: 0x06006189 RID: 24969 RVA: 0x001461BC File Offset: 0x001443BC
		public bool TrueForAll(Predicate<T> match)
		{
			if (match == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
			}
			for (int i = 0; i < this._size; i++)
			{
				if (!match(this._items[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600618A RID: 24970 RVA: 0x001461FC File Offset: 0x001443FC
		private void AddEnumerable(IEnumerable<T> enumerable)
		{
			this._version++;
			foreach (T t in enumerable)
			{
				if (this._size == this._items.Length)
				{
					this.EnsureCapacity(this._size + 1);
				}
				T[] items = this._items;
				int size = this._size;
				this._size = size + 1;
				items[size] = t;
			}
		}

		// Token: 0x040039E8 RID: 14824
		private const int DefaultCapacity = 4;

		// Token: 0x040039E9 RID: 14825
		private T[] _items;

		// Token: 0x040039EA RID: 14826
		private int _size;

		// Token: 0x040039EB RID: 14827
		private int _version;

		// Token: 0x040039EC RID: 14828
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x040039ED RID: 14829
		private static readonly T[] s_emptyArray = new T[0];

		/// <summary>Выполняет перечисление элементов коллекции <see cref="T:System.Collections.Generic.List`1" />.</summary>
		/// <typeparam name="T" />
		// Token: 0x02000AA4 RID: 2724
		[Serializable]
		public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
		{
			// Token: 0x0600618C RID: 24972 RVA: 0x00146295 File Offset: 0x00144495
			internal Enumerator(List<T> list)
			{
				this._list = list;
				this._index = 0;
				this._version = list._version;
				this._current = default(T);
			}

			/// <summary>Освобождает все ресурсы, занятые модулем <see cref="T:System.Collections.Generic.List`1.Enumerator" />.</summary>
			// Token: 0x0600618D RID: 24973 RVA: 0x00004BF9 File Offset: 0x00002DF9
			public void Dispose()
			{
			}

			/// <summary>Перемещает перечислитель к следующему элементу коллекции <see cref="T:System.Collections.Generic.List`1" />.</summary>
			/// <returns>Значение <see langword="true" />, если перечислитель был успешно перемещен к следующему элементу; значение <see langword="false" />, если перечислитель достиг конца коллекции.</returns>
			/// <exception cref="T:System.InvalidOperationException">После создания перечислителя семейство было изменено.</exception>
			// Token: 0x0600618E RID: 24974 RVA: 0x001462C0 File Offset: 0x001444C0
			public bool MoveNext()
			{
				List<T> list = this._list;
				if (this._version == list._version && this._index < list._size)
				{
					this._current = list._items[this._index];
					this._index++;
					return true;
				}
				return this.MoveNextRare();
			}

			// Token: 0x0600618F RID: 24975 RVA: 0x0014631D File Offset: 0x0014451D
			private bool MoveNextRare()
			{
				if (this._version != this._list._version)
				{
					ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
				}
				this._index = this._list._size + 1;
				this._current = default(T);
				return false;
			}

			/// <summary>Возвращает элемент, расположенный в текущей позиции перечислителя.</summary>
			/// <returns>Элемент коллекции <see cref="T:System.Collections.Generic.List`1" />, находящийся в текущей позиции перечислителя.</returns>
			// Token: 0x17001157 RID: 4439
			// (get) Token: 0x06006190 RID: 24976 RVA: 0x00146357 File Offset: 0x00144557
			public T Current
			{
				get
				{
					return this._current;
				}
			}

			/// <summary>Возвращает элемент, расположенный в текущей позиции перечислителя.</summary>
			/// <returns>Элемент коллекции <see cref="T:System.Collections.Generic.List`1" />, находящийся в текущей позиции перечислителя.</returns>
			/// <exception cref="T:System.InvalidOperationException">Перечислитель размещается перед первым элементом семейства или после его последнего элемента.</exception>
			// Token: 0x17001158 RID: 4440
			// (get) Token: 0x06006191 RID: 24977 RVA: 0x0014635F File Offset: 0x0014455F
			object IEnumerator.Current
			{
				get
				{
					if (this._index == 0 || this._index == this._list._size + 1)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen();
					}
					return this.Current;
				}
			}

			/// <summary>Устанавливает перечислитель в его начальное положение, т. е. перед первым элементом коллекции.</summary>
			/// <exception cref="T:System.InvalidOperationException">После создания перечислителя семейство было изменено.</exception>
			// Token: 0x06006192 RID: 24978 RVA: 0x0014638E File Offset: 0x0014458E
			void IEnumerator.Reset()
			{
				if (this._version != this._list._version)
				{
					ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
				}
				this._index = 0;
				this._current = default(T);
			}

			// Token: 0x040039EE RID: 14830
			private List<T> _list;

			// Token: 0x040039EF RID: 14831
			private int _index;

			// Token: 0x040039F0 RID: 14832
			private int _version;

			// Token: 0x040039F1 RID: 14833
			private T _current;
		}
	}
}
