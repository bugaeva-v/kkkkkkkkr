using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.Collections.Concurrent
{
	/// <summary>Предоставляет потокобезопасную коллекцию, обслуживаемую по принципу "первым поступил — первым обслужен" (FIFO).</summary>
	/// <typeparam name="T">Тип элементов в очереди.</typeparam>
	// Token: 0x02000A52 RID: 2642
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(IProducerConsumerCollectionDebugView<>))]
	[Serializable]
	public class ConcurrentQueue<T> : IProducerConsumerCollection<T>, IEnumerable<!0>, IEnumerable, ICollection, IReadOnlyCollection<T>
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" />.</summary>
		// Token: 0x06005EC4 RID: 24260 RVA: 0x0013E188 File Offset: 0x0013C388
		public ConcurrentQueue()
		{
			this._crossSegmentLock = new object();
			this._tail = (this._head = new ConcurrentQueue<T>.Segment(32));
		}

		// Token: 0x06005EC5 RID: 24261 RVA: 0x0013E1C0 File Offset: 0x0013C3C0
		private void InitializeFromCollection(IEnumerable<T> collection)
		{
			this._crossSegmentLock = new object();
			int num = 32;
			ICollection<T> collection2 = collection as ICollection<T>;
			if (collection2 != null)
			{
				int count = collection2.Count;
				if (count > num)
				{
					num = Math.Min(ConcurrentQueue<T>.Segment.RoundUpToPowerOf2(count), 1048576);
				}
			}
			this._tail = (this._head = new ConcurrentQueue<T>.Segment(num));
			foreach (T item in collection)
			{
				this.Enqueue(item);
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" />, который содержит элементы, скопированные из указанной коллекции.</summary>
		/// <param name="collection">Коллекция, элементы которой копируются в новую коллекцию <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="collection" /> имеет значение NULL.</exception>
		// Token: 0x06005EC6 RID: 24262 RVA: 0x0013E25C File Offset: 0x0013C45C
		public ConcurrentQueue(IEnumerable<T> collection)
		{
			if (collection == null)
			{
				throw new ArgumentNullException("collection");
			}
			this.InitializeFromCollection(collection);
		}

		/// <summary>Копирует элементы коллекции <see cref="T:System.Collections.ICollection" /> в массив <see cref="T:System.Array" />, начиная с указанного индекса массива <see cref="T:System.Array" />.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы коллекции <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="array" /> является ссылкой на null (Nothing в Visual Basic).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным. - или - <paramref name="array" /> не поддерживает индексацию, начинающуюся с нуля. - или - <paramref name="index" /> больше или равен длине <paramref name="array" />, - или - количество элементов в источнике <see cref="T:System.Collections.ICollection" /> больше, чем свободное пространство в диапазоне от <paramref name="index" /> до конца массива назначения <paramref name="array" />. - или - тип источника <see cref="T:System.Collections.ICollection" /> не может быть автоматически приведен к типу массива назначения <paramref name="array" />.</exception>
		// Token: 0x06005EC7 RID: 24263 RVA: 0x0013E27C File Offset: 0x0013C47C
		void ICollection.CopyTo(Array array, int index)
		{
			T[] array2 = array as T[];
			if (array2 != null)
			{
				this.CopyTo(array2, index);
				return;
			}
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			this.ToArray().CopyTo(array, index);
		}

		/// <summary>Возвращает значение, указывающее, синхронизирован ли доступ к коллекции <see cref="T:System.Collections.ICollection" /> с SyncRoot.</summary>
		/// <returns>Всегда возвращает <see langword="false" /> укажите доступа не синхронизированы.</returns>
		// Token: 0x170010A0 RID: 4256
		// (get) Token: 0x06005EC8 RID: 24264 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.ICollection" />. Данное свойство не поддерживается.</summary>
		/// <returns>Возвращает значение null (Nothing в Visual Basic).</returns>
		/// <exception cref="T:System.NotSupportedException">Свойство SyncRoot не поддерживается.</exception>
		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x06005EC9 RID: 24265 RVA: 0x0013E2B7 File Offset: 0x0013C4B7
		object ICollection.SyncRoot
		{
			get
			{
				throw new NotSupportedException("The SyncRoot property may not be used for the synchronization of concurrent collections.");
			}
		}

		/// <summary>Возвращает перечислитель, который осуществляет итерацию по коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который может использоваться для итерации элементов коллекции.</returns>
		// Token: 0x06005ECA RID: 24266 RVA: 0x0013E2C3 File Offset: 0x0013C4C3
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}

		// Token: 0x06005ECB RID: 24267 RVA: 0x0013E2CB File Offset: 0x0013C4CB
		bool IProducerConsumerCollection<!0>.TryAdd(T item)
		{
			this.Enqueue(item);
			return true;
		}

		// Token: 0x06005ECC RID: 24268 RVA: 0x0007E92F File Offset: 0x0007CB2F
		bool IProducerConsumerCollection<!0>.TryTake(out T item)
		{
			return this.TryDequeue(out item);
		}

		/// <summary>Возвращает значение, указывающее, является ли коллекция <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" /> пустой.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" /> пуст; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x06005ECD RID: 24269 RVA: 0x0013E2D8 File Offset: 0x0013C4D8
		public bool IsEmpty
		{
			get
			{
				T t;
				return !this.TryPeek(out t, false);
			}
		}

		/// <summary>Копирует элементы, хранящиеся в <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" />, в новый массив.</summary>
		/// <returns>Новый массив, содержащий снимок элементов, скопированных из коллекции <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" />.</returns>
		// Token: 0x06005ECE RID: 24270 RVA: 0x0013E2F4 File Offset: 0x0013C4F4
		public T[] ToArray()
		{
			ConcurrentQueue<T>.Segment head;
			int headHead;
			ConcurrentQueue<T>.Segment tail;
			int tailTail;
			this.SnapForObservation(out head, out headHead, out tail, out tailTail);
			T[] array = new T[ConcurrentQueue<T>.GetCount(head, headHead, tail, tailTail)];
			using (IEnumerator<T> enumerator = this.Enumerate(head, headHead, tail, tailTail))
			{
				int num = 0;
				while (enumerator.MoveNext())
				{
					T t = enumerator.Current;
					array[num++] = t;
				}
			}
			return array;
		}

		/// <summary>Получает число элементов, содержащихся в интерфейсе <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" />.</summary>
		/// <returns>Число элементов, содержащихся в интерфейсе <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" />.</returns>
		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x06005ECF RID: 24271 RVA: 0x0013E370 File Offset: 0x0013C570
		public int Count
		{
			get
			{
				SpinWait spinWait = default(SpinWait);
				ConcurrentQueue<T>.Segment head;
				ConcurrentQueue<T>.Segment tail;
				int num;
				int num2;
				int num3;
				int num4;
				for (;;)
				{
					head = this._head;
					tail = this._tail;
					num = Volatile.Read(ref head._headAndTail.Head);
					num2 = Volatile.Read(ref head._headAndTail.Tail);
					if (head == tail)
					{
						if (head == this._head && head == this._tail && num == Volatile.Read(ref head._headAndTail.Head) && num2 == Volatile.Read(ref head._headAndTail.Tail))
						{
							break;
						}
					}
					else
					{
						if (head._nextSegment != tail)
						{
							goto IL_13C;
						}
						num3 = Volatile.Read(ref tail._headAndTail.Head);
						num4 = Volatile.Read(ref tail._headAndTail.Tail);
						if (head == this._head && tail == this._tail && num == Volatile.Read(ref head._headAndTail.Head) && num2 == Volatile.Read(ref head._headAndTail.Tail) && num3 == Volatile.Read(ref tail._headAndTail.Head) && num4 == Volatile.Read(ref tail._headAndTail.Tail))
						{
							goto Block_12;
						}
					}
					spinWait.SpinOnce();
				}
				return ConcurrentQueue<T>.GetCount(head, num, num2);
				Block_12:
				return ConcurrentQueue<T>.GetCount(head, num, num2) + ConcurrentQueue<T>.GetCount(tail, num3, num4);
				IL_13C:
				this.SnapForObservation(out head, out num, out tail, out num4);
				return (int)ConcurrentQueue<T>.GetCount(head, num, tail, num4);
			}
		}

		// Token: 0x06005ED0 RID: 24272 RVA: 0x0013E4DE File Offset: 0x0013C6DE
		private static int GetCount(ConcurrentQueue<T>.Segment s, int head, int tail)
		{
			if (head == tail || head == tail - s.FreezeOffset)
			{
				return 0;
			}
			head &= s._slotsMask;
			tail &= s._slotsMask;
			if (head >= tail)
			{
				return s._slots.Length - head + tail;
			}
			return tail - head;
		}

		// Token: 0x06005ED1 RID: 24273 RVA: 0x0013E51C File Offset: 0x0013C71C
		private static long GetCount(ConcurrentQueue<T>.Segment head, int headHead, ConcurrentQueue<T>.Segment tail, int tailTail)
		{
			long num = 0L;
			int num2 = ((head == tail) ? tailTail : Volatile.Read(ref head._headAndTail.Tail)) - head.FreezeOffset;
			if (headHead < num2)
			{
				headHead &= head._slotsMask;
				num2 &= head._slotsMask;
				num += (long)((headHead < num2) ? (num2 - headHead) : (head._slots.Length - headHead + num2));
			}
			if (head != tail)
			{
				for (ConcurrentQueue<T>.Segment nextSegment = head._nextSegment; nextSegment != tail; nextSegment = nextSegment._nextSegment)
				{
					num += (long)(nextSegment._headAndTail.Tail - nextSegment.FreezeOffset);
				}
				num += (long)(tailTail - tail.FreezeOffset);
			}
			return num;
		}

		/// <summary>Копирует элементы коллекции <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" /> в существующий одномерный массив <see cref="T:System.Array" />, начиная с указанного значения индекса массива.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы коллекции <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="array" /> является ссылкой на null (Nothing в Visual Basic).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="index" /> является равным или больше, чем длина <paramref name="array" /> - или - Число элементов в источнике <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" /> больше, чем свободное пространство от <paramref name="index" /> до конца массива назначения <paramref name="array" />.</exception>
		// Token: 0x06005ED2 RID: 24274 RVA: 0x0013E5B8 File Offset: 0x0013C7B8
		public void CopyTo(T[] array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "The index argument must be greater than or equal zero.");
			}
			ConcurrentQueue<T>.Segment head;
			int headHead;
			ConcurrentQueue<T>.Segment tail;
			int tailTail;
			this.SnapForObservation(out head, out headHead, out tail, out tailTail);
			long count = ConcurrentQueue<T>.GetCount(head, headHead, tail, tailTail);
			if ((long)index > (long)array.Length - count)
			{
				throw new ArgumentException("The number of elements in the collection is greater than the available space from index to the end of the destination array.");
			}
			int num = index;
			using (IEnumerator<T> enumerator = this.Enumerate(head, headHead, tail, tailTail))
			{
				while (enumerator.MoveNext())
				{
					T t = enumerator.Current;
					array[num++] = t;
				}
			}
		}

		/// <summary>Возвращает перечислитель, осуществляющий перебор элементов списка <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" />.</summary>
		/// <returns>Перечислитель для содержимого <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" />.</returns>
		// Token: 0x06005ED3 RID: 24275 RVA: 0x0013E664 File Offset: 0x0013C864
		public IEnumerator<T> GetEnumerator()
		{
			ConcurrentQueue<T>.Segment head;
			int headHead;
			ConcurrentQueue<T>.Segment tail;
			int tailTail;
			this.SnapForObservation(out head, out headHead, out tail, out tailTail);
			return this.Enumerate(head, headHead, tail, tailTail);
		}

		// Token: 0x06005ED4 RID: 24276 RVA: 0x0013E68C File Offset: 0x0013C88C
		private void SnapForObservation(out ConcurrentQueue<T>.Segment head, out int headHead, out ConcurrentQueue<T>.Segment tail, out int tailTail)
		{
			object crossSegmentLock = this._crossSegmentLock;
			lock (crossSegmentLock)
			{
				head = this._head;
				tail = this._tail;
				ConcurrentQueue<T>.Segment segment = head;
				for (;;)
				{
					segment._preservedForObservation = true;
					if (segment == tail)
					{
						break;
					}
					segment = segment._nextSegment;
				}
				tail.EnsureFrozenForEnqueues();
				headHead = Volatile.Read(ref head._headAndTail.Head);
				tailTail = Volatile.Read(ref tail._headAndTail.Tail);
			}
		}

		// Token: 0x06005ED5 RID: 24277 RVA: 0x0013E720 File Offset: 0x0013C920
		private T GetItemWhenAvailable(ConcurrentQueue<T>.Segment segment, int i)
		{
			int num = i + 1 & segment._slotsMask;
			if ((segment._slots[i].SequenceNumber & segment._slotsMask) != num)
			{
				SpinWait spinWait = default(SpinWait);
				while ((Volatile.Read(ref segment._slots[i].SequenceNumber) & segment._slotsMask) != num)
				{
					spinWait.SpinOnce();
				}
			}
			return segment._slots[i].Item;
		}

		// Token: 0x06005ED6 RID: 24278 RVA: 0x0013E795 File Offset: 0x0013C995
		private IEnumerator<T> Enumerate(ConcurrentQueue<T>.Segment head, int headHead, ConcurrentQueue<T>.Segment tail, int tailTail)
		{
			int headTail = ((head == tail) ? tailTail : Volatile.Read(ref head._headAndTail.Tail)) - head.FreezeOffset;
			if (headHead < headTail)
			{
				headHead &= head._slotsMask;
				headTail &= head._slotsMask;
				if (headHead < headTail)
				{
					int num;
					for (int i = headHead; i < headTail; i = num + 1)
					{
						yield return this.GetItemWhenAvailable(head, i);
						num = i;
					}
				}
				else
				{
					int num;
					for (int i = headHead; i < head._slots.Length; i = num + 1)
					{
						yield return this.GetItemWhenAvailable(head, i);
						num = i;
					}
					for (int i = 0; i < headTail; i = num + 1)
					{
						yield return this.GetItemWhenAvailable(head, i);
						num = i;
					}
				}
			}
			if (head != tail)
			{
				int num;
				ConcurrentQueue<T>.Segment s;
				for (s = head._nextSegment; s != tail; s = s._nextSegment)
				{
					int i = s._headAndTail.Tail - s.FreezeOffset;
					for (int j = 0; j < i; j = num + 1)
					{
						yield return this.GetItemWhenAvailable(s, j);
						num = j;
					}
				}
				s = null;
				tailTail -= tail.FreezeOffset;
				for (int i = 0; i < tailTail; i = num + 1)
				{
					yield return this.GetItemWhenAvailable(tail, i);
					num = i;
				}
			}
			yield break;
		}

		/// <summary>Добавляет объект в конец очереди <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" />.</summary>
		/// <param name="item">Объект, добавляемый в конец <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" />. Значение ссылочных типов может быть пустой ссылкой (Nothing в Visual Basic).</param>
		// Token: 0x06005ED7 RID: 24279 RVA: 0x0013E7C1 File Offset: 0x0013C9C1
		public void Enqueue(T item)
		{
			if (!this._tail.TryEnqueue(item))
			{
				this.EnqueueSlow(item);
			}
		}

		// Token: 0x06005ED8 RID: 24280 RVA: 0x0013E7DC File Offset: 0x0013C9DC
		private void EnqueueSlow(T item)
		{
			for (;;)
			{
				ConcurrentQueue<T>.Segment tail = this._tail;
				if (tail.TryEnqueue(item))
				{
					break;
				}
				object crossSegmentLock = this._crossSegmentLock;
				lock (crossSegmentLock)
				{
					if (tail == this._tail)
					{
						tail.EnsureFrozenForEnqueues();
						ConcurrentQueue<T>.Segment segment = new ConcurrentQueue<T>.Segment(tail._preservedForObservation ? 32 : Math.Min(tail.Capacity * 2, 1048576));
						tail._nextSegment = segment;
						this._tail = segment;
					}
				}
			}
		}

		/// <summary>Пытается удалить и вернуть объект, находящийся в начале параллельной очереди.</summary>
		/// <param name="result">В случае успешного выполнения операции параметр <paramref name="result" />, возвращаемый данным методом, содержит удаленный объект. Если объект, доступный для удаления, не найден, значение не определено.</param>
		/// <returns>Значение <see langword="true" />, если элемент был успешно удален и возвращен из начала <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06005ED9 RID: 24281 RVA: 0x0013E87C File Offset: 0x0013CA7C
		public bool TryDequeue(out T result)
		{
			return this._head.TryDequeue(out result) || this.TryDequeueSlow(out result);
		}

		// Token: 0x06005EDA RID: 24282 RVA: 0x0013E898 File Offset: 0x0013CA98
		private bool TryDequeueSlow(out T item)
		{
			for (;;)
			{
				ConcurrentQueue<T>.Segment head = this._head;
				if (head.TryDequeue(out item))
				{
					break;
				}
				if (head._nextSegment == null)
				{
					goto Block_1;
				}
				if (head.TryDequeue(out item))
				{
					return true;
				}
				object crossSegmentLock = this._crossSegmentLock;
				lock (crossSegmentLock)
				{
					if (head == this._head)
					{
						this._head = head._nextSegment;
					}
				}
			}
			return true;
			Block_1:
			item = default(T);
			return false;
		}

		/// <summary>Пытается вернуть объект из начала <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" /> без его удаления.</summary>
		/// <param name="result">Параметр <paramref name="result" />, возвращаемый данным методом, содержит объект, расположенный в начале <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" />, или неопределенное значение, если операцию не удалось выполнить.</param>
		/// <returns>Значение <see langword="true" />, если объект был успешно возвращен; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06005EDB RID: 24283 RVA: 0x0013E928 File Offset: 0x0013CB28
		public bool TryPeek(out T result)
		{
			return this.TryPeek(out result, true);
		}

		// Token: 0x06005EDC RID: 24284 RVA: 0x0013E934 File Offset: 0x0013CB34
		private bool TryPeek(out T result, bool resultUsed)
		{
			ConcurrentQueue<T>.Segment segment = this._head;
			for (;;)
			{
				ConcurrentQueue<T>.Segment segment2 = Volatile.Read<ConcurrentQueue<T>.Segment>(ref segment._nextSegment);
				if (segment.TryPeek(out result, resultUsed))
				{
					break;
				}
				if (segment2 != null)
				{
					segment = segment2;
				}
				else if (Volatile.Read<ConcurrentQueue<T>.Segment>(ref segment._nextSegment) == null)
				{
					goto Block_3;
				}
			}
			return true;
			Block_3:
			result = default(T);
			return false;
		}

		// Token: 0x06005EDD RID: 24285 RVA: 0x0013E980 File Offset: 0x0013CB80
		public void Clear()
		{
			object crossSegmentLock = this._crossSegmentLock;
			lock (crossSegmentLock)
			{
				this._tail.EnsureFrozenForEnqueues();
				this._tail = (this._head = new ConcurrentQueue<T>.Segment(32));
			}
		}

		// Token: 0x0400391C RID: 14620
		private const int InitialSegmentLength = 32;

		// Token: 0x0400391D RID: 14621
		private const int MaxSegmentLength = 1048576;

		// Token: 0x0400391E RID: 14622
		private object _crossSegmentLock;

		// Token: 0x0400391F RID: 14623
		private volatile ConcurrentQueue<T>.Segment _tail;

		// Token: 0x04003920 RID: 14624
		private volatile ConcurrentQueue<T>.Segment _head;

		// Token: 0x02000A53 RID: 2643
		[DebuggerDisplay("Capacity = {Capacity}")]
		internal sealed class Segment
		{
			// Token: 0x06005EDE RID: 24286 RVA: 0x0013E9E4 File Offset: 0x0013CBE4
			public Segment(int boundedLength)
			{
				this._slots = new ConcurrentQueue<T>.Segment.Slot[boundedLength];
				this._slotsMask = boundedLength - 1;
				for (int i = 0; i < this._slots.Length; i++)
				{
					this._slots[i].SequenceNumber = i;
				}
			}

			// Token: 0x06005EDF RID: 24287 RVA: 0x0013EA31 File Offset: 0x0013CC31
			internal static int RoundUpToPowerOf2(int i)
			{
				i--;
				i |= i >> 1;
				i |= i >> 2;
				i |= i >> 4;
				i |= i >> 8;
				i |= i >> 16;
				return i + 1;
			}

			// Token: 0x170010A4 RID: 4260
			// (get) Token: 0x06005EE0 RID: 24288 RVA: 0x0013EA5F File Offset: 0x0013CC5F
			internal int Capacity
			{
				get
				{
					return this._slots.Length;
				}
			}

			// Token: 0x170010A5 RID: 4261
			// (get) Token: 0x06005EE1 RID: 24289 RVA: 0x0013EA69 File Offset: 0x0013CC69
			internal int FreezeOffset
			{
				get
				{
					return this._slots.Length * 2;
				}
			}

			// Token: 0x06005EE2 RID: 24290 RVA: 0x0013EA78 File Offset: 0x0013CC78
			internal void EnsureFrozenForEnqueues()
			{
				if (!this._frozenForEnqueues)
				{
					this._frozenForEnqueues = true;
					SpinWait spinWait = default(SpinWait);
					for (;;)
					{
						int num = Volatile.Read(ref this._headAndTail.Tail);
						if (Interlocked.CompareExchange(ref this._headAndTail.Tail, num + this.FreezeOffset, num) == num)
						{
							break;
						}
						spinWait.SpinOnce();
					}
				}
			}

			// Token: 0x06005EE3 RID: 24291 RVA: 0x0013EAD4 File Offset: 0x0013CCD4
			public bool TryDequeue(out T item)
			{
				SpinWait spinWait = default(SpinWait);
				int num;
				int num2;
				for (;;)
				{
					num = Volatile.Read(ref this._headAndTail.Head);
					num2 = (num & this._slotsMask);
					int num3 = Volatile.Read(ref this._slots[num2].SequenceNumber) - (num + 1);
					if (num3 == 0)
					{
						if (Interlocked.CompareExchange(ref this._headAndTail.Head, num + 1, num) == num)
						{
							break;
						}
					}
					else if (num3 < 0)
					{
						bool frozenForEnqueues = this._frozenForEnqueues;
						int num4 = Volatile.Read(ref this._headAndTail.Tail);
						if (num4 - num <= 0 || (frozenForEnqueues && num4 - this.FreezeOffset - num <= 0))
						{
							goto IL_EE;
						}
					}
					spinWait.SpinOnce();
				}
				item = this._slots[num2].Item;
				if (!Volatile.Read(ref this._preservedForObservation))
				{
					this._slots[num2].Item = default(T);
					Volatile.Write(ref this._slots[num2].SequenceNumber, num + this._slots.Length);
				}
				return true;
				IL_EE:
				item = default(T);
				return false;
			}

			// Token: 0x06005EE4 RID: 24292 RVA: 0x0013EBE4 File Offset: 0x0013CDE4
			public bool TryPeek(out T result, bool resultUsed)
			{
				if (resultUsed)
				{
					this._preservedForObservation = true;
					Interlocked.MemoryBarrier();
				}
				SpinWait spinWait = default(SpinWait);
				int num2;
				for (;;)
				{
					int num = Volatile.Read(ref this._headAndTail.Head);
					num2 = (num & this._slotsMask);
					int num3 = Volatile.Read(ref this._slots[num2].SequenceNumber) - (num + 1);
					if (num3 == 0)
					{
						break;
					}
					if (num3 < 0)
					{
						bool frozenForEnqueues = this._frozenForEnqueues;
						int num4 = Volatile.Read(ref this._headAndTail.Tail);
						if (num4 - num <= 0 || (frozenForEnqueues && num4 - this.FreezeOffset - num <= 0))
						{
							goto IL_AE;
						}
					}
					spinWait.SpinOnce();
				}
				result = (resultUsed ? this._slots[num2].Item : default(T));
				return true;
				IL_AE:
				result = default(T);
				return false;
			}

			// Token: 0x06005EE5 RID: 24293 RVA: 0x0013ECB4 File Offset: 0x0013CEB4
			public bool TryEnqueue(T item)
			{
				SpinWait spinWait = default(SpinWait);
				int num;
				int num2;
				for (;;)
				{
					num = Volatile.Read(ref this._headAndTail.Tail);
					num2 = (num & this._slotsMask);
					int num3 = Volatile.Read(ref this._slots[num2].SequenceNumber) - num;
					if (num3 == 0)
					{
						if (Interlocked.CompareExchange(ref this._headAndTail.Tail, num + 1, num) == num)
						{
							break;
						}
					}
					else if (num3 < 0)
					{
						return false;
					}
					spinWait.SpinOnce();
				}
				this._slots[num2].Item = item;
				Volatile.Write(ref this._slots[num2].SequenceNumber, num + 1);
				return true;
			}

			// Token: 0x04003921 RID: 14625
			internal readonly ConcurrentQueue<T>.Segment.Slot[] _slots;

			// Token: 0x04003922 RID: 14626
			internal readonly int _slotsMask;

			// Token: 0x04003923 RID: 14627
			internal PaddedHeadAndTail _headAndTail;

			// Token: 0x04003924 RID: 14628
			internal bool _preservedForObservation;

			// Token: 0x04003925 RID: 14629
			internal bool _frozenForEnqueues;

			// Token: 0x04003926 RID: 14630
			internal ConcurrentQueue<T>.Segment _nextSegment;

			// Token: 0x02000A54 RID: 2644
			[DebuggerDisplay("Item = {Item}, SequenceNumber = {SequenceNumber}")]
			[StructLayout(LayoutKind.Auto)]
			internal struct Slot
			{
				// Token: 0x04003927 RID: 14631
				public T Item;

				// Token: 0x04003928 RID: 14632
				public int SequenceNumber;
			}
		}
	}
}
