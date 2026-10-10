using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace System.Collections.Concurrent
{
	/// <summary>Предоставляет потокобезопасную коллекцию, обслуживаемую по принципу "последним поступил — первым обслужен" (LIFO).</summary>
	/// <typeparam name="T">Тип элементов в стеке.</typeparam>
	// Token: 0x02000A5E RID: 2654
	[DebuggerTypeProxy(typeof(IProducerConsumerCollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public class ConcurrentStack<T> : IProducerConsumerCollection<!0>, IEnumerable<!0>, IEnumerable, ICollection, IReadOnlyCollection<T>
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />.</summary>
		// Token: 0x06005F50 RID: 24400 RVA: 0x0000259F File Offset: 0x0000079F
		public ConcurrentStack()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />, который содержит элементы, скопированные из указанной коллекции.</summary>
		/// <param name="collection">Коллекция, элементы которой копируются в новую коллекцию <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="collection" /> имеет значение NULL.</exception>
		// Token: 0x06005F51 RID: 24401 RVA: 0x001409B0 File Offset: 0x0013EBB0
		public ConcurrentStack(IEnumerable<T> collection)
		{
			if (collection == null)
			{
				throw new ArgumentNullException("collection");
			}
			this.InitializeFromCollection(collection);
		}

		// Token: 0x06005F52 RID: 24402 RVA: 0x001409D0 File Offset: 0x0013EBD0
		private void InitializeFromCollection(IEnumerable<T> collection)
		{
			ConcurrentStack<T>.Node node = null;
			foreach (T value in collection)
			{
				node = new ConcurrentStack<T>.Node(value)
				{
					_next = node
				};
			}
			this._head = node;
		}

		/// <summary>Возвращает значение, указывающее, является ли коллекция <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" /> пустой.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" /> пуст; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x06005F53 RID: 24403 RVA: 0x00140A28 File Offset: 0x0013EC28
		public bool IsEmpty
		{
			get
			{
				return this._head == null;
			}
		}

		/// <summary>Получает число элементов, содержащихся в интерфейсе <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />.</summary>
		/// <returns>Число элементов, содержащихся в интерфейсе <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />.</returns>
		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x06005F54 RID: 24404 RVA: 0x00140A38 File Offset: 0x0013EC38
		public int Count
		{
			get
			{
				int num = 0;
				for (ConcurrentStack<T>.Node node = this._head; node != null; node = node._next)
				{
					num++;
				}
				return num;
			}
		}

		/// <summary>Возвращает значение, указывающее, синхронизирован ли доступ к коллекции <see cref="T:System.Collections.ICollection" /> с SyncRoot.</summary>
		/// <returns>Всегда возвращает <see langword="false" /> укажите доступа не синхронизированы.</returns>
		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x06005F55 RID: 24405 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.ICollection" />. Данное свойство не поддерживается.</summary>
		/// <returns>Возвращает значение null (Nothing в Visual Basic).</returns>
		/// <exception cref="T:System.NotSupportedException">Свойство SyncRoot не поддерживается</exception>
		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x06005F56 RID: 24406 RVA: 0x0013E2B7 File Offset: 0x0013C4B7
		object ICollection.SyncRoot
		{
			get
			{
				throw new NotSupportedException("The SyncRoot property may not be used for the synchronization of concurrent collections.");
			}
		}

		/// <summary>Удаляет все объекты из <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />.</summary>
		// Token: 0x06005F57 RID: 24407 RVA: 0x00140A61 File Offset: 0x0013EC61
		public void Clear()
		{
			this._head = null;
		}

		/// <summary>Копирует элементы коллекции <see cref="T:System.Collections.ICollection" /> в массив <see cref="T:System.Array" />, начиная с указанного индекса массива <see cref="T:System.Array" />.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы коллекции <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="array" /> является ссылкой на null (Nothing в Visual Basic).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным. - или - <paramref name="array" /> не поддерживает индексацию, начинающуюся с нуля. - или - <paramref name="index" /> больше или равен длине <paramref name="array" />, - или - количество элементов в источнике <see cref="T:System.Collections.ICollection" /> больше, чем свободное пространство в диапазоне от <paramref name="index" /> до конца массива назначения <paramref name="array" />. - или - тип источника <see cref="T:System.Collections.ICollection" /> не может быть автоматически приведен к типу массива назначения <paramref name="array" />.</exception>
		// Token: 0x06005F58 RID: 24408 RVA: 0x00140A6C File Offset: 0x0013EC6C
		void ICollection.CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			((ICollection)this.ToList()).CopyTo(array, index);
		}

		/// <summary>Копирует элементы коллекции <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" /> в существующий одномерный массив <see cref="T:System.Array" />, начиная с указанного значения индекса массива.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы коллекции <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="array" /> является ссылкой на null (Nothing в Visual Basic).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="index" /> является равным или больше, чем длина <paramref name="array" /> - или - Число элементов в источнике <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" /> больше, чем свободное пространство от <paramref name="index" /> до конца массива назначения <paramref name="array" />.</exception>
		// Token: 0x06005F59 RID: 24409 RVA: 0x00140A89 File Offset: 0x0013EC89
		public void CopyTo(T[] array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			this.ToList().CopyTo(array, index);
		}

		/// <summary>Вставляет объект как верхний элемент стека <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />.</summary>
		/// <param name="item">Объект, вставляемый в <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />. Значение ссылочных типов может быть пустой ссылкой (Nothing в Visual Basic).</param>
		// Token: 0x06005F5A RID: 24410 RVA: 0x00140AA8 File Offset: 0x0013ECA8
		public void Push(T item)
		{
			ConcurrentStack<T>.Node node = new ConcurrentStack<T>.Node(item);
			node._next = this._head;
			if (Interlocked.CompareExchange<ConcurrentStack<T>.Node>(ref this._head, node, node._next) == node._next)
			{
				return;
			}
			this.PushCore(node, node);
		}

		/// <summary>Вставляет неделимым блоком несколько объектов в качестве верхнего элемента <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />.</summary>
		/// <param name="items">Объекты, вставляемые в <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="items" /> является ссылкой на null (Nothing в Visual Basic).</exception>
		// Token: 0x06005F5B RID: 24411 RVA: 0x00140AED File Offset: 0x0013ECED
		public void PushRange(T[] items)
		{
			if (items == null)
			{
				throw new ArgumentNullException("items");
			}
			this.PushRange(items, 0, items.Length);
		}

		/// <summary>Вставляет неделимым блоком несколько объектов в качестве верхнего элемента <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />.</summary>
		/// <param name="items">Объекты, вставляемые в <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />.</param>
		/// <param name="startIndex">Отсчитываемое от нуля смещение в массиве <paramref name="items" />, с которого начинается вставка элементов в начало <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />.</param>
		/// <param name="count">Число элементов, вставляемых в начало <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="items" /> является ссылкой на null (Nothing в Visual Basic).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> или <paramref name="count" /> является отрицательным значением. Или значение параметра <paramref name="startIndex" /> больше или равно длине <paramref name="items" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значение <paramref name="startIndex" /> + <paramref name="count" /> превышает длину <paramref name="items" />.</exception>
		// Token: 0x06005F5C RID: 24412 RVA: 0x00140B08 File Offset: 0x0013ED08
		public void PushRange(T[] items, int startIndex, int count)
		{
			ConcurrentStack<T>.ValidatePushPopRangeInput(items, startIndex, count);
			if (count == 0)
			{
				return;
			}
			ConcurrentStack<T>.Node node2;
			ConcurrentStack<T>.Node node = node2 = new ConcurrentStack<T>.Node(items[startIndex]);
			for (int i = startIndex + 1; i < startIndex + count; i++)
			{
				node2 = new ConcurrentStack<T>.Node(items[i])
				{
					_next = node2
				};
			}
			node._next = this._head;
			if (Interlocked.CompareExchange<ConcurrentStack<T>.Node>(ref this._head, node2, node._next) == node._next)
			{
				return;
			}
			this.PushCore(node2, node);
		}

		// Token: 0x06005F5D RID: 24413 RVA: 0x00140B88 File Offset: 0x0013ED88
		private void PushCore(ConcurrentStack<T>.Node head, ConcurrentStack<T>.Node tail)
		{
			SpinWait spinWait = default(SpinWait);
			do
			{
				spinWait.SpinOnce();
				tail._next = this._head;
			}
			while (Interlocked.CompareExchange<ConcurrentStack<T>.Node>(ref this._head, head, tail._next) != tail._next);
			if (CDSCollectionETWBCLProvider.Log.IsEnabled())
			{
				CDSCollectionETWBCLProvider.Log.ConcurrentStack_FastPushFailed(spinWait.Count);
			}
		}

		// Token: 0x06005F5E RID: 24414 RVA: 0x00140BEC File Offset: 0x0013EDEC
		private static void ValidatePushPopRangeInput(T[] items, int startIndex, int count)
		{
			if (items == null)
			{
				throw new ArgumentNullException("items");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "The count argument must be greater than or equal to zero.");
			}
			int num = items.Length;
			if (startIndex >= num || startIndex < 0)
			{
				throw new ArgumentOutOfRangeException("startIndex", "The startIndex argument must be greater than or equal to zero.");
			}
			if (num - count < startIndex)
			{
				throw new ArgumentException("The sum of the startIndex and count arguments must be less than or equal to the collection's Count.");
			}
		}

		// Token: 0x06005F5F RID: 24415 RVA: 0x00140C48 File Offset: 0x0013EE48
		bool IProducerConsumerCollection<!0>.TryAdd(T item)
		{
			this.Push(item);
			return true;
		}

		/// <summary>Пытается вернуть объект из начала <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" /> без его удаления.</summary>
		/// <param name="result">Параметр <paramref name="result" />, возвращаемый данным методом, содержит объект, расположенный в начале коллекции <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />, или неопределенное значение, если операцию не удалось выполнить.</param>
		/// <returns>Значение true, если объект был успешно возвращен; в противном случае — значение false.</returns>
		// Token: 0x06005F60 RID: 24416 RVA: 0x00140C54 File Offset: 0x0013EE54
		public bool TryPeek(out T result)
		{
			ConcurrentStack<T>.Node head = this._head;
			if (head == null)
			{
				result = default(T);
				return false;
			}
			result = head._value;
			return true;
		}

		/// <summary>Пытается извлечь и вернуть верхний объект <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />.</summary>
		/// <param name="result">В случае успешного выполнения операции параметр <paramref name="result" />, возвращаемый данным методом, содержит удаленный объект. Если объект, доступный для удаления, не найден, значение не определено.</param>
		/// <returns>Значение true, если элемент был успешно удален и возвращен из начала <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />; в противном случае — значение false.</returns>
		// Token: 0x06005F61 RID: 24417 RVA: 0x00140C84 File Offset: 0x0013EE84
		public bool TryPop(out T result)
		{
			ConcurrentStack<T>.Node head = this._head;
			if (head == null)
			{
				result = default(T);
				return false;
			}
			if (Interlocked.CompareExchange<ConcurrentStack<T>.Node>(ref this._head, head._next, head) == head)
			{
				result = head._value;
				return true;
			}
			return this.TryPopCore(out result);
		}

		/// <summary>Пытается извлечь и вернуть несколько объектов из начала <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" /> в виде неделимого блока.</summary>
		/// <param name="items">Массив <see cref="T:System.Array" />, в который будут добавлены объекты, извлеченные из начала <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />.</param>
		/// <returns>Число объектов, успешно извлеченных из начала <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" /> и вставленных в массив <paramref name="items" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="items" /> — это аргумент null (Nothing в Visual Basic).</exception>
		// Token: 0x06005F62 RID: 24418 RVA: 0x00140CD0 File Offset: 0x0013EED0
		public int TryPopRange(T[] items)
		{
			if (items == null)
			{
				throw new ArgumentNullException("items");
			}
			return this.TryPopRange(items, 0, items.Length);
		}

		/// <summary>Пытается извлечь и вернуть несколько объектов из начала <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" /> в виде неделимого блока.</summary>
		/// <param name="items">Массив <see cref="T:System.Array" />, в который будут добавлены объекты, извлеченные из начала <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />.</param>
		/// <param name="startIndex">Отсчитываемое от нуля смещение в массиве <paramref name="items" />, с которого начинается вставка элементов из начала <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />.</param>
		/// <param name="count">Число элементов, извлекаемых из начала <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" /> и вставляемых в массив <paramref name="items" />.</param>
		/// <returns>Число объектов, успешно извлеченных из верхней части стека и вставленных в <paramref name="items" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="items" /> является ссылкой на null (Nothing в Visual Basic).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> или <paramref name="count" /> является отрицательным значением. Или значение параметра <paramref name="startIndex" /> больше или равно длине <paramref name="items" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значение <paramref name="startIndex" /> + <paramref name="count" /> превышает длину <paramref name="items" />.</exception>
		// Token: 0x06005F63 RID: 24419 RVA: 0x00140CEC File Offset: 0x0013EEEC
		public int TryPopRange(T[] items, int startIndex, int count)
		{
			ConcurrentStack<T>.ValidatePushPopRangeInput(items, startIndex, count);
			if (count == 0)
			{
				return 0;
			}
			ConcurrentStack<T>.Node head;
			int num = this.TryPopCore(count, out head);
			if (num > 0)
			{
				ConcurrentStack<T>.CopyRemovedItems(head, items, startIndex, num);
			}
			return num;
		}

		// Token: 0x06005F64 RID: 24420 RVA: 0x00140D20 File Offset: 0x0013EF20
		private bool TryPopCore(out T result)
		{
			ConcurrentStack<T>.Node node;
			if (this.TryPopCore(1, out node) == 1)
			{
				result = node._value;
				return true;
			}
			result = default(T);
			return false;
		}

		// Token: 0x06005F65 RID: 24421 RVA: 0x00140D50 File Offset: 0x0013EF50
		private int TryPopCore(int count, out ConcurrentStack<T>.Node poppedHead)
		{
			SpinWait spinWait = default(SpinWait);
			int num = 1;
			Random random = null;
			ConcurrentStack<T>.Node head;
			int num2;
			for (;;)
			{
				head = this._head;
				if (head == null)
				{
					break;
				}
				ConcurrentStack<T>.Node node = head;
				num2 = 1;
				while (num2 < count && node._next != null)
				{
					node = node._next;
					num2++;
				}
				if (Interlocked.CompareExchange<ConcurrentStack<T>.Node>(ref this._head, node._next, head) == head)
				{
					goto Block_5;
				}
				for (int i = 0; i < num; i++)
				{
					spinWait.SpinOnce();
				}
				if (spinWait.NextSpinWillYield)
				{
					if (random == null)
					{
						random = new Random();
					}
					num = random.Next(1, 8);
				}
				else
				{
					num *= 2;
				}
			}
			if (count == 1 && CDSCollectionETWBCLProvider.Log.IsEnabled())
			{
				CDSCollectionETWBCLProvider.Log.ConcurrentStack_FastPopFailed(spinWait.Count);
			}
			poppedHead = null;
			return 0;
			Block_5:
			if (count == 1 && CDSCollectionETWBCLProvider.Log.IsEnabled())
			{
				CDSCollectionETWBCLProvider.Log.ConcurrentStack_FastPopFailed(spinWait.Count);
			}
			poppedHead = head;
			return num2;
		}

		// Token: 0x06005F66 RID: 24422 RVA: 0x00140E3C File Offset: 0x0013F03C
		private static void CopyRemovedItems(ConcurrentStack<T>.Node head, T[] collection, int startIndex, int nodesCount)
		{
			ConcurrentStack<T>.Node node = head;
			for (int i = startIndex; i < startIndex + nodesCount; i++)
			{
				collection[i] = node._value;
				node = node._next;
			}
		}

		// Token: 0x06005F67 RID: 24423 RVA: 0x00140E6D File Offset: 0x0013F06D
		bool IProducerConsumerCollection<!0>.TryTake(out T item)
		{
			return this.TryPop(out item);
		}

		/// <summary>Копирует элементы, хранящиеся в <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />, в новый массив.</summary>
		/// <returns>Новый массив, содержащий снимок элементов, скопированных из коллекции <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />.</returns>
		// Token: 0x06005F68 RID: 24424 RVA: 0x00140E78 File Offset: 0x0013F078
		public T[] ToArray()
		{
			ConcurrentStack<T>.Node head = this._head;
			if (head != null)
			{
				return this.ToList(head).ToArray();
			}
			return Array.Empty<T>();
		}

		// Token: 0x06005F69 RID: 24425 RVA: 0x00140EA3 File Offset: 0x0013F0A3
		private List<T> ToList()
		{
			return this.ToList(this._head);
		}

		// Token: 0x06005F6A RID: 24426 RVA: 0x00140EB4 File Offset: 0x0013F0B4
		private List<T> ToList(ConcurrentStack<T>.Node curr)
		{
			List<T> list = new List<T>();
			while (curr != null)
			{
				list.Add(curr._value);
				curr = curr._next;
			}
			return list;
		}

		/// <summary>Возвращает перечислитель, осуществляющий перебор элементов списка <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />.</summary>
		/// <returns>Перечислитель для коллекции <see cref="T:System.Collections.Concurrent.ConcurrentStack`1" />.</returns>
		// Token: 0x06005F6B RID: 24427 RVA: 0x00140EE1 File Offset: 0x0013F0E1
		public IEnumerator<T> GetEnumerator()
		{
			return this.GetEnumerator(this._head);
		}

		// Token: 0x06005F6C RID: 24428 RVA: 0x00140EF1 File Offset: 0x0013F0F1
		private IEnumerator<T> GetEnumerator(ConcurrentStack<T>.Node head)
		{
			for (ConcurrentStack<T>.Node current = head; current != null; current = current._next)
			{
				yield return current._value;
			}
			yield break;
		}

		/// <summary>Возвращает перечислитель, который осуществляет итерацию по коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для итерации элементов коллекции.</returns>
		// Token: 0x06005F6D RID: 24429 RVA: 0x0013E2C3 File Offset: 0x0013C4C3
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}

		// Token: 0x04003956 RID: 14678
		private volatile ConcurrentStack<T>.Node _head;

		// Token: 0x04003957 RID: 14679
		private const int BACKOFF_MAX_YIELDS = 8;

		// Token: 0x02000A5F RID: 2655
		[Serializable]
		private class Node
		{
			// Token: 0x06005F6E RID: 24430 RVA: 0x00140F00 File Offset: 0x0013F100
			internal Node(T value)
			{
				this._value = value;
				this._next = null;
			}

			// Token: 0x04003958 RID: 14680
			internal readonly T _value;

			// Token: 0x04003959 RID: 14681
			internal ConcurrentStack<T>.Node _next;
		}
	}
}
