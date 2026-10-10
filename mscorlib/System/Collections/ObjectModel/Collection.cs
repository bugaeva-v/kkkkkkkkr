using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.Collections.ObjectModel
{
	/// <summary>Предоставляет базовый класс для универсальной коллекции.</summary>
	/// <typeparam name="T">Тип элементов в коллекции.</typeparam>
	// Token: 0x02000A80 RID: 2688
	[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public class Collection<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<!0>, IReadOnlyCollection<T>
	{
		/// <summary>Инициализирует новый экземпляр пустого класса <see cref="T:System.Collections.ObjectModel.Collection`1" />.</summary>
		// Token: 0x06005FFE RID: 24574 RVA: 0x001421A7 File Offset: 0x001403A7
		public Collection()
		{
			this.items = new List<T>();
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Collections.ObjectModel.Collection`1" />, который служит оболочкой для указанного списка.</summary>
		/// <param name="list">Список помещается в оболочку в новой коллекции.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="list" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005FFF RID: 24575 RVA: 0x001421BA File Offset: 0x001403BA
		public Collection(IList<T> list)
		{
			if (list == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.list);
			}
			this.items = list;
		}

		/// <summary>Получает число элементов, фактически содержащихся в списке <see cref="T:System.Collections.ObjectModel.Collection`1" />.</summary>
		/// <returns>Число элементов, фактически содержащихся в списке <see cref="T:System.Collections.ObjectModel.Collection`1" />.</returns>
		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x06006000 RID: 24576 RVA: 0x001421D2 File Offset: 0x001403D2
		public int Count
		{
			get
			{
				return this.items.Count;
			}
		}

		/// <summary>Получает оболочку <see cref="T:System.Collections.Generic.IList`1" /> для <see cref="T:System.Collections.ObjectModel.Collection`1" />.</summary>
		/// <returns>Оболочка <see cref="T:System.Collections.Generic.IList`1" /> для <see cref="T:System.Collections.ObjectModel.Collection`1" />.</returns>
		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x06006001 RID: 24577 RVA: 0x001421DF File Offset: 0x001403DF
		protected IList<T> Items
		{
			get
			{
				return this.items;
			}
		}

		/// <summary>Возвращает или задает элемент по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс элемента, который требуется возвратить или задать.</param>
		/// <returns>Элемент, расположенный по указанному индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		///
		/// или - 
		/// Значение параметра <paramref name="index" /> больше или равно значению свойства <see cref="P:System.Collections.ObjectModel.Collection`1.Count" />.</exception>
		// Token: 0x170010E6 RID: 4326
		public T this[int index]
		{
			get
			{
				return this.items[index];
			}
			set
			{
				if (this.items.IsReadOnly)
				{
					ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
				}
				if (index >= this.items.Count)
				{
					ThrowHelper.ThrowArgumentOutOfRange_IndexException();
				}
				this.SetItem(index, value);
			}
		}

		/// <summary>Добавляет объект в конец очереди <see cref="T:System.Collections.ObjectModel.Collection`1" />.</summary>
		/// <param name="item">Объект, добавляемый в конец коллекции <see cref="T:System.Collections.ObjectModel.Collection`1" />. Для ссылочных типов допускается значение <see langword="null" />.</param>
		// Token: 0x06006004 RID: 24580 RVA: 0x00142228 File Offset: 0x00140428
		public void Add(T item)
		{
			if (this.items.IsReadOnly)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
			int count = this.items.Count;
			this.InsertItem(count, item);
		}

		/// <summary>Удаляет из коллекции <see cref="T:System.Collections.ObjectModel.Collection`1" /> все элементы.</summary>
		// Token: 0x06006005 RID: 24581 RVA: 0x0014225D File Offset: 0x0014045D
		public void Clear()
		{
			if (this.items.IsReadOnly)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
			this.ClearItems();
		}

		/// <summary>Копирует целый массив <see cref="T:System.Collections.ObjectModel.Collection`1" /> в совместимый одномерный массив <see cref="T:System.Array" />, начиная с заданного индекса целевого массива.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из интерфейса <see cref="T:System.Collections.ObjectModel.Collection`1" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Число элементов в исходной коллекции <see cref="T:System.Collections.ObjectModel.Collection`1" /> больше доступного места от положения, заданного значением параметра <paramref name="index" />, до конца массива назначения <paramref name="array" />.</exception>
		// Token: 0x06006006 RID: 24582 RVA: 0x00142279 File Offset: 0x00140479
		public void CopyTo(T[] array, int index)
		{
			this.items.CopyTo(array, index);
		}

		/// <summary>Определяет, входит ли элемент в коллекцию <see cref="T:System.Collections.ObjectModel.Collection`1" />.</summary>
		/// <param name="item">Объект для поиска в <see cref="T:System.Collections.ObjectModel.Collection`1" />. Для ссылочных типов допускается значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="item" /> найден в коллекции <see cref="T:System.Collections.ObjectModel.Collection`1" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06006007 RID: 24583 RVA: 0x00142288 File Offset: 0x00140488
		public bool Contains(T item)
		{
			return this.items.Contains(item);
		}

		/// <summary>Возвращает перечислитель, осуществляющий перебор элементов списка <see cref="T:System.Collections.ObjectModel.Collection`1" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.Generic.IEnumerator`1" /> для <see cref="T:System.Collections.ObjectModel.Collection`1" />.</returns>
		// Token: 0x06006008 RID: 24584 RVA: 0x00142296 File Offset: 0x00140496
		public IEnumerator<T> GetEnumerator()
		{
			return this.items.GetEnumerator();
		}

		/// <summary>Осуществляет поиск указанного объекта и возвращает отсчитываемый от нуля индекс первого вхождения, найденного в пределах всего списка <see cref="T:System.Collections.ObjectModel.Collection`1" />.</summary>
		/// <param name="item">Объект для поиска в <see cref="T:System.Collections.Generic.List`1" />. Для ссылочных типов допускается значение <see langword="null" />.</param>
		/// <returns>Индекс (с нуля) первого вхождения параметра <paramref name="item" />, если оно найдено в коллекции <see cref="T:System.Collections.ObjectModel.Collection`1" />; в противном случае -1.</returns>
		// Token: 0x06006009 RID: 24585 RVA: 0x001422A3 File Offset: 0x001404A3
		public int IndexOf(T item)
		{
			return this.items.IndexOf(item);
		}

		/// <summary>Вставляет элемент в коллекцию <see cref="T:System.Collections.ObjectModel.Collection`1" /> по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс, по которому следует вставить элемент <paramref name="item" />.</param>
		/// <param name="item">Вставляемый объект. Для ссылочных типов допускается значение <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		///
		/// или - 
		/// Значение <paramref name="index" /> больше значения <see cref="P:System.Collections.ObjectModel.Collection`1.Count" />.</exception>
		// Token: 0x0600600A RID: 24586 RVA: 0x001422B1 File Offset: 0x001404B1
		public void Insert(int index, T item)
		{
			if (this.items.IsReadOnly)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
			if (index > this.items.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexException();
			}
			this.InsertItem(index, item);
		}

		/// <summary>Удаляет первое вхождение указанного объекта из коллекции <see cref="T:System.Collections.ObjectModel.Collection`1" />.</summary>
		/// <param name="item">Объект, который необходимо удалить из коллекции <see cref="T:System.Collections.ObjectModel.Collection`1" />. Для ссылочных типов допускается значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если элемент <paramref name="item" /> успешно удален, в противном случае — значение <see langword="false" />.  Этот метод также возвращает <see langword="false" />, если объект <paramref name="item" /> не был найден в исходной коллекции <see cref="T:System.Collections.ObjectModel.Collection`1" />.</returns>
		// Token: 0x0600600B RID: 24587 RVA: 0x001422E4 File Offset: 0x001404E4
		public bool Remove(T item)
		{
			if (this.items.IsReadOnly)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
			int num = this.items.IndexOf(item);
			if (num < 0)
			{
				return false;
			}
			this.RemoveItem(num);
			return true;
		}

		/// <summary>Удаляет элемент списка <see cref="T:System.Collections.ObjectModel.Collection`1" /> с указанным индексом.</summary>
		/// <param name="index">Индекс (с нуля) элемента, который требуется удалить.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		///
		/// или - 
		/// Значение параметра <paramref name="index" /> больше или равно значению свойства <see cref="P:System.Collections.ObjectModel.Collection`1.Count" />.</exception>
		// Token: 0x0600600C RID: 24588 RVA: 0x00142320 File Offset: 0x00140520
		public void RemoveAt(int index)
		{
			if (this.items.IsReadOnly)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
			if (index >= this.items.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexException();
			}
			this.RemoveItem(index);
		}

		/// <summary>Удаляет из коллекции <see cref="T:System.Collections.ObjectModel.Collection`1" /> все элементы.</summary>
		// Token: 0x0600600D RID: 24589 RVA: 0x00142350 File Offset: 0x00140550
		protected virtual void ClearItems()
		{
			this.items.Clear();
		}

		/// <summary>Вставляет элемент в коллекцию <see cref="T:System.Collections.ObjectModel.Collection`1" /> по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс, по которому следует вставить элемент <paramref name="item" />.</param>
		/// <param name="item">Вставляемый объект. Для ссылочных типов допускается значение <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		///
		/// или - 
		/// Значение <paramref name="index" /> больше значения <see cref="P:System.Collections.ObjectModel.Collection`1.Count" />.</exception>
		// Token: 0x0600600E RID: 24590 RVA: 0x0014235D File Offset: 0x0014055D
		protected virtual void InsertItem(int index, T item)
		{
			this.items.Insert(index, item);
		}

		/// <summary>Удаляет элемент списка <see cref="T:System.Collections.ObjectModel.Collection`1" /> с указанным индексом.</summary>
		/// <param name="index">Индекс (с нуля) элемента, который требуется удалить.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		///
		/// или - 
		/// Значение параметра <paramref name="index" /> больше или равно значению свойства <see cref="P:System.Collections.ObjectModel.Collection`1.Count" />.</exception>
		// Token: 0x0600600F RID: 24591 RVA: 0x0014236C File Offset: 0x0014056C
		protected virtual void RemoveItem(int index)
		{
			this.items.RemoveAt(index);
		}

		/// <summary>Заменяет элемент по указанному индексу.</summary>
		/// <param name="index">Индекс (с нуля) элемента, который требуется заменить.</param>
		/// <param name="item">Новое значение элемента по указанному индексу. Для ссылочных типов допускается значение <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		///
		/// или - 
		/// Значение <paramref name="index" /> больше значения <see cref="P:System.Collections.ObjectModel.Collection`1.Count" />.</exception>
		// Token: 0x06006010 RID: 24592 RVA: 0x0014237A File Offset: 0x0014057A
		protected virtual void SetItem(int index, T item)
		{
			this.items[index] = item;
		}

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x06006011 RID: 24593 RVA: 0x00142389 File Offset: 0x00140589
		bool ICollection<!0>.IsReadOnly
		{
			get
			{
				return this.items.IsReadOnly;
			}
		}

		/// <summary>Возвращает перечислитель, который осуществляет итерацию по коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для итерации элементов коллекции.</returns>
		// Token: 0x06006012 RID: 24594 RVA: 0x00142396 File Offset: 0x00140596
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.items.GetEnumerator();
		}

		/// <summary>Возвращает значение, показывающее, является ли доступ к коллекции <see cref="T:System.Collections.ICollection" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>
		///   <see langword="true" />, если доступ к классу <see cref="T:System.Collections.ICollection" /> является синхронизированным (потокобезопасным); в противном случае — <see langword="false" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.ObjectModel.Collection`1" /> это свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x06006013 RID: 24595 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.ICollection" />.</summary>
		/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Collections.ICollection" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.ObjectModel.Collection`1" /> это свойство всегда возвращает текущий экземпляр.</returns>
		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x06006014 RID: 24596 RVA: 0x001423A4 File Offset: 0x001405A4
		object ICollection.SyncRoot
		{
			get
			{
				ICollection collection = this.items as ICollection;
				if (collection == null)
				{
					return this;
				}
				return collection.SyncRoot;
			}
		}

		/// <summary>Копирует элементы коллекции <see cref="T:System.Collections.ICollection" /> в массив <see cref="T:System.Array" />, начиная с указанного индекса массива <see cref="T:System.Array" />.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из интерфейса <see cref="T:System.Collections.ICollection" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		///
		/// или - 
		/// Массив <paramref name="array" /> не имеет индексации, начинающейся с нуля.  
		///
		/// или - 
		/// Число элементов в исходном массиве <see cref="T:System.Collections.ICollection" /> больше доступного места от положения, заданного значением параметра <paramref name="index" />, до конца массива назначения <paramref name="array" />.  
		///
		/// или - 
		/// Тип исходного массива <see cref="T:System.Collections.ICollection" /> не может быть автоматически приведен к типу массива назначения <paramref name="array" />.</exception>
		// Token: 0x06006015 RID: 24597 RVA: 0x001423C8 File Offset: 0x001405C8
		void ICollection.CopyTo(Array array, int index)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (array.Rank != 1)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
			}
			if (array.GetLowerBound(0) != 0)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_NonZeroLowerBound);
			}
			if (index < 0)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (array.Length - index < this.Count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
			}
			T[] array2 = array as T[];
			if (array2 != null)
			{
				this.items.CopyTo(array2, index);
				return;
			}
			Type elementType = array.GetType().GetElementType();
			Type typeFromHandle = typeof(T);
			if (!elementType.IsAssignableFrom(typeFromHandle) && !typeFromHandle.IsAssignableFrom(elementType))
			{
				ThrowHelper.ThrowArgumentException_Argument_InvalidArrayType();
			}
			object[] array3 = array as object[];
			if (array3 == null)
			{
				ThrowHelper.ThrowArgumentException_Argument_InvalidArrayType();
			}
			int count = this.items.Count;
			try
			{
				for (int i = 0; i < count; i++)
				{
					array3[index++] = this.items[i];
				}
			}
			catch (ArrayTypeMismatchException)
			{
				ThrowHelper.ThrowArgumentException_Argument_InvalidArrayType();
			}
		}

		/// <summary>Возвращает или задает элемент по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс элемента, который требуется возвратить или задать.</param>
		/// <returns>Элемент, расположенный по указанному индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> не является допустимым индексом в <see cref="T:System.Collections.IList" />.</exception>
		/// <exception cref="T:System.ArgumentException">Свойство задано, и тип параметра <paramref name="value" /> не может быть назначен <see cref="T:System.Collections.IList" />.</exception>
		// Token: 0x170010EA RID: 4330
		object IList.this[int index]
		{
			get
			{
				return this.items[index];
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

		/// <summary>Получает значение, указывающее, является ли объект <see cref="T:System.Collections.IList" /> доступным только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если интерфейс <see cref="T:System.Collections.IList" /> доступен только для чтения; в противном случае — значение <see langword="false" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.ObjectModel.Collection`1" /> это свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x06006018 RID: 24600 RVA: 0x00142389 File Offset: 0x00140589
		bool IList.IsReadOnly
		{
			get
			{
				return this.items.IsReadOnly;
			}
		}

		/// <summary>Получает значение, указывающее, имеет ли список <see cref="T:System.Collections.IList" /> фиксированный размер.</summary>
		/// <returns>Значение <see langword="true" />, если словарь <see cref="T:System.Collections.IList" /> имеет фиксированный размер; в противном случае — значение <see langword="false" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.ObjectModel.Collection`1" /> это свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x06006019 RID: 24601 RVA: 0x00142520 File Offset: 0x00140720
		bool IList.IsFixedSize
		{
			get
			{
				IList list = this.items as IList;
				if (list != null)
				{
					return list.IsFixedSize;
				}
				return this.items.IsReadOnly;
			}
		}

		/// <summary>Добавляет элемент в коллекцию <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, добавляемый в список <see cref="T:System.Collections.IList" />.</param>
		/// <returns>Позиция, на которую вставлен новый элемент.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> имеет тип, который не может быть назначен <see cref="T:System.Collections.IList" />.</exception>
		// Token: 0x0600601A RID: 24602 RVA: 0x00142550 File Offset: 0x00140750
		int IList.Add(object value)
		{
			if (this.items.IsReadOnly)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
			ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(value, ExceptionArgument.value);
			try
			{
				this.Add((T)((object)value));
			}
			catch (InvalidCastException)
			{
				ThrowHelper.ThrowWrongValueTypeArgumentException(value, typeof(T));
			}
			return this.Count - 1;
		}

		/// <summary>Определяет, содержит ли коллекция <see cref="T:System.Collections.IList" /> указанное значение.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, который требуется найти в коллекции <see cref="T:System.Collections.IList" />.</param>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Object" /> найден в <see cref="T:System.Collections.IList" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> имеет тип, который не может быть назначен <see cref="T:System.Collections.IList" />.</exception>
		// Token: 0x0600601B RID: 24603 RVA: 0x001425B4 File Offset: 0x001407B4
		bool IList.Contains(object value)
		{
			return Collection<T>.IsCompatibleObject(value) && this.Contains((T)((object)value));
		}

		/// <summary>Определяет индекс заданного элемента в списке <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, который требуется найти в коллекции <see cref="T:System.Collections.IList" />.</param>
		/// <returns>Индекс <paramref name="value" />, если он найден в списке; в противном случае — значение -1.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> имеет тип, который не может быть назначен <see cref="T:System.Collections.IList" />.</exception>
		// Token: 0x0600601C RID: 24604 RVA: 0x001425CC File Offset: 0x001407CC
		int IList.IndexOf(object value)
		{
			if (Collection<T>.IsCompatibleObject(value))
			{
				return this.IndexOf((T)((object)value));
			}
			return -1;
		}

		/// <summary>Вставляет элемент в <see cref="T:System.Collections.IList" /> по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс, по которому следует вставить элемент <paramref name="value" />.</param>
		/// <param name="value">Объект <see cref="T:System.Object" />, вставляемый в <see cref="T:System.Collections.IList" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> не является допустимым индексом в <see cref="T:System.Collections.IList" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> имеет тип, который не может быть назначен <see cref="T:System.Collections.IList" />.</exception>
		// Token: 0x0600601D RID: 24605 RVA: 0x001425E4 File Offset: 0x001407E4
		void IList.Insert(int index, object value)
		{
			if (this.items.IsReadOnly)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
			ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(value, ExceptionArgument.value);
			try
			{
				this.Insert(index, (T)((object)value));
			}
			catch (InvalidCastException)
			{
				ThrowHelper.ThrowWrongValueTypeArgumentException(value, typeof(T));
			}
		}

		/// <summary>Удаляет первое вхождение указанного объекта из коллекции <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">Элемент <see cref="T:System.Object" />, который требуется удалить из <see cref="T:System.Collections.IList" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> имеет тип, который не может быть назначен <see cref="T:System.Collections.IList" />.</exception>
		// Token: 0x0600601E RID: 24606 RVA: 0x00142640 File Offset: 0x00140840
		void IList.Remove(object value)
		{
			if (this.items.IsReadOnly)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
			if (Collection<T>.IsCompatibleObject(value))
			{
				this.Remove((T)((object)value));
			}
		}

		// Token: 0x0600601F RID: 24607 RVA: 0x0014266C File Offset: 0x0014086C
		private static bool IsCompatibleObject(object value)
		{
			return value is T || (value == null && default(T) == null);
		}

		// Token: 0x040039A9 RID: 14761
		private IList<T> items;
	}
}
