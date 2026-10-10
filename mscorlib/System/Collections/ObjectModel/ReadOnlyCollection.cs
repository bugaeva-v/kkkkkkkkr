using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace System.Collections.ObjectModel
{
	/// <summary>Предоставляет базовый класс для универсальной коллекции, доступной только для чтения.</summary>
	/// <typeparam name="T">Тип элементов в коллекции.</typeparam>
	// Token: 0x02000A81 RID: 2689
	[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public class ReadOnlyCollection<T> : IList<!0>, ICollection<!0>, IEnumerable<!0>, IEnumerable, IList, ICollection, IReadOnlyList<!0>, IReadOnlyCollection<T>
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />, который является доступной только для чтения оболочкой для указанного списка.</summary>
		/// <param name="list">Список, для которого создается оболочка.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="list" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06006020 RID: 24608 RVA: 0x00142699 File Offset: 0x00140899
		public ReadOnlyCollection(IList<T> list)
		{
			if (list == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.list);
			}
			this.list = list;
		}

		/// <summary>Получает число элементов, содержащихся в экземпляре класса <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />.</summary>
		/// <returns>Число элементов, содержащихся в экземпляре класса <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />.</returns>
		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x06006021 RID: 24609 RVA: 0x001426B1 File Offset: 0x001408B1
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		/// <summary>Получает элемент с указанным индексом.</summary>
		/// <param name="index">Индекс элемента (с нуля), который требуется получить.</param>
		/// <returns>Элемент, расположенный по указанному индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		///
		/// или - 
		/// Значение параметра <paramref name="index" /> больше или равно значению свойства <see cref="P:System.Collections.ObjectModel.ReadOnlyCollection`1.Count" />.</exception>
		// Token: 0x170010EE RID: 4334
		public T this[int index]
		{
			get
			{
				return this.list[index];
			}
		}

		/// <summary>Определяет, входит ли элемент в коллекцию <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />.</summary>
		/// <param name="value">Объект для поиска в <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />. Для ссылочных типов допускается значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="value" /> найден в коллекции <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06006023 RID: 24611 RVA: 0x001426CC File Offset: 0x001408CC
		public bool Contains(T value)
		{
			return this.list.Contains(value);
		}

		/// <summary>Копирует целый массив <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> в совместимый одномерный массив <see cref="T:System.Array" />, начиная с заданного индекса целевого массива.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из интерфейса <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Число элементов в исходной коллекции <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> больше доступного места от положения, заданного значением параметра <paramref name="index" />, до конца массива назначения <paramref name="array" />.</exception>
		// Token: 0x06006024 RID: 24612 RVA: 0x001426DA File Offset: 0x001408DA
		public void CopyTo(T[] array, int index)
		{
			this.list.CopyTo(array, index);
		}

		/// <summary>Возвращает перечислитель, осуществляющий перебор элементов списка <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.Generic.IEnumerator`1" /> для <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />.</returns>
		// Token: 0x06006025 RID: 24613 RVA: 0x001426E9 File Offset: 0x001408E9
		public IEnumerator<T> GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		/// <summary>Осуществляет поиск указанного объекта и возвращает отсчитываемый от нуля индекс первого вхождения, найденного в пределах всего списка <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />.</summary>
		/// <param name="value">Объект для поиска в <see cref="T:System.Collections.Generic.List`1" />. Для ссылочных типов допускается значение <see langword="null" />.</param>
		/// <returns>Индекс (с нуля) первого вхождения параметра <paramref name="item" />, если оно найдено в коллекции <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />; в противном случае -1.</returns>
		// Token: 0x06006026 RID: 24614 RVA: 0x001426F6 File Offset: 0x001408F6
		public int IndexOf(T value)
		{
			return this.list.IndexOf(value);
		}

		/// <summary>Возвращает список <see cref="T:System.Collections.Generic.IList`1" />, для которого <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> создает оболочку.</summary>
		/// <returns>Список <see cref="T:System.Collections.Generic.IList`1" />, для которого <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> создает оболочку.</returns>
		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x06006027 RID: 24615 RVA: 0x00142704 File Offset: 0x00140904
		protected IList<T> Items
		{
			get
			{
				return this.list;
			}
		}

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x06006028 RID: 24616 RVA: 0x000040F7 File Offset: 0x000022F7
		bool ICollection<!0>.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170010F1 RID: 4337
		T IList<!0>.this[int index]
		{
			get
			{
				return this.list[index];
			}
			set
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
		}

		// Token: 0x0600602B RID: 24619 RVA: 0x0014270C File Offset: 0x0014090C
		void ICollection<!0>.Add(T value)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		}

		// Token: 0x0600602C RID: 24620 RVA: 0x0014270C File Offset: 0x0014090C
		void ICollection<!0>.Clear()
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		}

		// Token: 0x0600602D RID: 24621 RVA: 0x0014270C File Offset: 0x0014090C
		void IList<!0>.Insert(int index, T value)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		}

		// Token: 0x0600602E RID: 24622 RVA: 0x00142715 File Offset: 0x00140915
		bool ICollection<!0>.Remove(T value)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			return false;
		}

		// Token: 0x0600602F RID: 24623 RVA: 0x0014270C File Offset: 0x0014090C
		void IList<!0>.RemoveAt(int index)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		}

		/// <summary>Возвращает перечислитель, который осуществляет итерацию по коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для итерации элементов коллекции.</returns>
		// Token: 0x06006030 RID: 24624 RVA: 0x0014271F File Offset: 0x0014091F
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		/// <summary>Возвращает значение, показывающее, является ли доступ к коллекции <see cref="T:System.Collections.ICollection" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>
		///   <see langword="true" />, если доступ к классу <see cref="T:System.Collections.ICollection" /> является синхронизированным (потокобезопасным); в противном случае — <see langword="false" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> это свойство всегда возвращает значение <see langword="false" />.</returns>
		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x06006031 RID: 24625 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.ICollection" />.</summary>
		/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Collections.ICollection" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> это свойство всегда возвращает текущий экземпляр.</returns>
		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x06006032 RID: 24626 RVA: 0x0014272C File Offset: 0x0014092C
		object ICollection.SyncRoot
		{
			get
			{
				if (this._syncRoot == null)
				{
					ICollection collection = this.list as ICollection;
					if (collection != null)
					{
						this._syncRoot = collection.SyncRoot;
					}
					else
					{
						Interlocked.CompareExchange<object>(ref this._syncRoot, new object(), null);
					}
				}
				return this._syncRoot;
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
		// Token: 0x06006033 RID: 24627 RVA: 0x00142778 File Offset: 0x00140978
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
				this.list.CopyTo(array2, index);
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
			int count = this.list.Count;
			try
			{
				for (int i = 0; i < count; i++)
				{
					array3[index++] = this.list[i];
				}
			}
			catch (ArrayTypeMismatchException)
			{
				ThrowHelper.ThrowArgumentException_Argument_InvalidArrayType();
			}
		}

		/// <summary>Получает значение, указывающее, имеет ли список <see cref="T:System.Collections.IList" /> фиксированный размер.</summary>
		/// <returns>Значение <see langword="true" />, если словарь <see cref="T:System.Collections.IList" /> имеет фиксированный размер; в противном случае — значение <see langword="false" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> это свойство всегда возвращает значение <see langword="true" />.</returns>
		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x06006034 RID: 24628 RVA: 0x000040F7 File Offset: 0x000022F7
		bool IList.IsFixedSize
		{
			get
			{
				return true;
			}
		}

		/// <summary>Получает значение, указывающее, является ли объект <see cref="T:System.Collections.IList" /> доступным только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если интерфейс <see cref="T:System.Collections.IList" /> доступен только для чтения; в противном случае — значение <see langword="false" />.  В используемой по умолчанию реализации <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> это свойство всегда возвращает значение <see langword="true" />.</returns>
		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x06006035 RID: 24629 RVA: 0x000040F7 File Offset: 0x000022F7
		bool IList.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		/// <summary>Получает элемент с указанным индексом. Исключение <see cref="T:System.NotSupportedException" /> возникает при попытке задать элемент по указанному индексу.</summary>
		/// <param name="index">Индекс элемента (с нуля), который требуется получить.</param>
		/// <returns>Элемент, расположенный по указанному индексу.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> не является допустимым индексом в <see cref="T:System.Collections.IList" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Выдается всегда, если данное свойство задано.</exception>
		// Token: 0x170010F6 RID: 4342
		object IList.this[int index]
		{
			get
			{
				return this.list[index];
			}
			set
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
		}

		/// <summary>Добавляет элемент в коллекцию <see cref="T:System.Collections.IList" />.  Данная реализация всегда создает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, добавляемый в список <see cref="T:System.Collections.IList" />.</param>
		/// <returns>Позиция, на которую вставлен новый элемент.</returns>
		/// <exception cref="T:System.NotSupportedException">Создается всегда.</exception>
		// Token: 0x06006038 RID: 24632 RVA: 0x00142887 File Offset: 0x00140A87
		int IList.Add(object value)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			return -1;
		}

		/// <summary>Удаляет все элементы из коллекции <see cref="T:System.Collections.IList" />.  Данная реализация всегда создает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <exception cref="T:System.NotSupportedException">Создается всегда.</exception>
		// Token: 0x06006039 RID: 24633 RVA: 0x0014270C File Offset: 0x0014090C
		void IList.Clear()
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		}

		// Token: 0x0600603A RID: 24634 RVA: 0x00142894 File Offset: 0x00140A94
		private static bool IsCompatibleObject(object value)
		{
			return value is T || (value == null && default(T) == null);
		}

		/// <summary>Определяет, содержит ли коллекция <see cref="T:System.Collections.IList" /> указанное значение.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, который требуется найти в коллекции <see cref="T:System.Collections.IList" />.</param>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Object" /> найден в <see cref="T:System.Collections.IList" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Тип параметра <paramref name="value" /> отличен от типа, указанного для параметра универсального типа <paramref name="T" />.</exception>
		// Token: 0x0600603B RID: 24635 RVA: 0x001428C1 File Offset: 0x00140AC1
		bool IList.Contains(object value)
		{
			return ReadOnlyCollection<T>.IsCompatibleObject(value) && this.Contains((T)((object)value));
		}

		/// <summary>Определяет индекс заданного элемента в списке <see cref="T:System.Collections.IList" />.</summary>
		/// <param name="value">Объект <see cref="T:System.Object" />, который требуется найти в коллекции <see cref="T:System.Collections.IList" />.</param>
		/// <returns>Индекс <paramref name="value" />, если он найден в списке; в противном случае — значение -1.</returns>
		/// <exception cref="T:System.ArgumentException">Тип параметра <paramref name="value" /> отличен от типа, указанного для параметра универсального типа <paramref name="T" />.</exception>
		// Token: 0x0600603C RID: 24636 RVA: 0x001428D9 File Offset: 0x00140AD9
		int IList.IndexOf(object value)
		{
			if (ReadOnlyCollection<T>.IsCompatibleObject(value))
			{
				return this.IndexOf((T)((object)value));
			}
			return -1;
		}

		/// <summary>Вставляет элемент в список <see cref="T:System.Collections.IList" /> по указанному индексу.  Данная реализация всегда создает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс, по которому следует вставить элемент <paramref name="value" />.</param>
		/// <param name="value">Объект <see cref="T:System.Object" />, вставляемый в <see cref="T:System.Collections.IList" />.</param>
		/// <exception cref="T:System.NotSupportedException">Создается всегда.</exception>
		// Token: 0x0600603D RID: 24637 RVA: 0x0014270C File Offset: 0x0014090C
		void IList.Insert(int index, object value)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		}

		/// <summary>Удаляет первое вхождение указанного объекта из коллекции <see cref="T:System.Collections.IList" />.  Данная реализация всегда создает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="value">Элемент <see cref="T:System.Object" />, который требуется удалить из <see cref="T:System.Collections.IList" />.</param>
		/// <exception cref="T:System.NotSupportedException">Создается всегда.</exception>
		// Token: 0x0600603E RID: 24638 RVA: 0x0014270C File Offset: 0x0014090C
		void IList.Remove(object value)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		}

		/// <summary>Удаляет элемент <see cref="T:System.Collections.IList" />, расположенный по указанному индексу.  Данная реализация всегда создает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс удаляемого элемента.</param>
		/// <exception cref="T:System.NotSupportedException">Создается всегда.</exception>
		// Token: 0x0600603F RID: 24639 RVA: 0x0014270C File Offset: 0x0014090C
		void IList.RemoveAt(int index)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		}

		// Token: 0x040039AA RID: 14762
		private IList<T> list;

		// Token: 0x040039AB RID: 14763
		[NonSerialized]
		private object _syncRoot;
	}
}
