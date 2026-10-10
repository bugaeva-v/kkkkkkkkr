using System;
using System.Diagnostics;
using System.Threading;

namespace System.Collections
{
	/// <summary>Представляет коллекцию объектов, основанную на принципе «первым поступил — первым обслужен».</summary>
	// Token: 0x02000A27 RID: 2599
	[DebuggerTypeProxy(typeof(Queue.QueueDebugView))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public class Queue : ICollection, IEnumerable, ICloneable
	{
		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Queue" /> с заданными по умолчанию исходной емкостью и коэффициентом роста.</summary>
		// Token: 0x06005C15 RID: 23573 RVA: 0x00135AFF File Offset: 0x00133CFF
		public Queue() : this(32, 2f)
		{
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Queue" /> с указанной начальной емкостью и заданным по умолчанию коэффициентом роста.</summary>
		/// <param name="capacity">Начальное количество элементов, которое может содержать коллекция <see cref="T:System.Collections.Queue" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="capacity" /> меньше нуля.</exception>
		// Token: 0x06005C16 RID: 23574 RVA: 0x00135B0E File Offset: 0x00133D0E
		public Queue(int capacity) : this(capacity, 2f)
		{
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.Collections.Queue" /> с указанными начальной емкостью и коэффициентом роста.</summary>
		/// <param name="capacity">Начальное количество элементов, которое может содержать коллекция <see cref="T:System.Collections.Queue" />.</param>
		/// <param name="growFactor">Коэффициент, на который умножается емкость расширяемой коллекции <see cref="T:System.Collections.Queue" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="capacity" /> меньше нуля.  
		///
		/// или - 
		/// <paramref name="growFactor" /> меньше 1,0 или больше 10,0.</exception>
		// Token: 0x06005C17 RID: 23575 RVA: 0x00135B1C File Offset: 0x00133D1C
		public Queue(int capacity, float growFactor)
		{
			if (capacity < 0)
			{
				throw new ArgumentOutOfRangeException("capacity", "Non-negative number required.");
			}
			if ((double)growFactor < 1.0 || (double)growFactor > 10.0)
			{
				throw new ArgumentOutOfRangeException("growFactor", SR.Format("Queue grow factor must be between {0} and {1}.", 1, 10));
			}
			this._array = new object[capacity];
			this._head = 0;
			this._tail = 0;
			this._size = 0;
			this._growFactor = (int)(growFactor * 100f);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Queue" />, содержащий элементы, скопированные из указанной коллекции, и обладающий начальной емкостью, равной количеству скопированных элементов, и заданным по умолчанию коэффициентом роста.</summary>
		/// <param name="col">Интерфейс <see cref="T:System.Collections.ICollection" />, из которого копируются элементы.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="col" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005C18 RID: 23576 RVA: 0x00135BB0 File Offset: 0x00133DB0
		public Queue(ICollection col) : this((col == null) ? 32 : col.Count)
		{
			if (col == null)
			{
				throw new ArgumentNullException("col");
			}
			foreach (object obj in col)
			{
				this.Enqueue(obj);
			}
		}

		/// <summary>Получает число элементов, содержащихся в интерфейсе <see cref="T:System.Collections.Queue" />.</summary>
		/// <returns>Число элементов, содержащихся в интерфейсе <see cref="T:System.Collections.Queue" />.</returns>
		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x06005C19 RID: 23577 RVA: 0x00135BFB File Offset: 0x00133DFB
		public virtual int Count
		{
			get
			{
				return this._size;
			}
		}

		/// <summary>Создает неполную копию <see cref="T:System.Collections.Queue" />.</summary>
		/// <returns>Неполная копия <see cref="T:System.Collections.Queue" />.</returns>
		// Token: 0x06005C1A RID: 23578 RVA: 0x00135C04 File Offset: 0x00133E04
		public virtual object Clone()
		{
			Queue queue = new Queue(this._size);
			queue._size = this._size;
			int num = this._size;
			int num2 = (this._array.Length - this._head < num) ? (this._array.Length - this._head) : num;
			Array.Copy(this._array, this._head, queue._array, 0, num2);
			num -= num2;
			if (num > 0)
			{
				Array.Copy(this._array, 0, queue._array, this._array.Length - this._head, num);
			}
			queue._version = this._version;
			return queue;
		}

		/// <summary>Возвращает значение, показывающее, является ли доступ к коллекции <see cref="T:System.Collections.Queue" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>
		///   <see langword="true" />, если доступ к классу <see cref="T:System.Collections.Queue" /> является синхронизированным (потокобезопасным); в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x06005C1B RID: 23579 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.Queue" />.</summary>
		/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Collections.Queue" />.</returns>
		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x06005C1C RID: 23580 RVA: 0x00135CA5 File Offset: 0x00133EA5
		public virtual object SyncRoot
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

		/// <summary>Удаляет все объекты из <see cref="T:System.Collections.Queue" />.</summary>
		// Token: 0x06005C1D RID: 23581 RVA: 0x00135CC8 File Offset: 0x00133EC8
		public virtual void Clear()
		{
			if (this._size != 0)
			{
				if (this._head < this._tail)
				{
					Array.Clear(this._array, this._head, this._size);
				}
				else
				{
					Array.Clear(this._array, this._head, this._array.Length - this._head);
					Array.Clear(this._array, 0, this._tail);
				}
				this._size = 0;
			}
			this._head = 0;
			this._tail = 0;
			this._version++;
		}

		/// <summary>Копирует элементы коллекции <see cref="T:System.Collections.Queue" /> в существующий одномерный массив <see cref="T:System.Array" />, начиная с указанного значения индекса массива.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из интерфейса <see cref="T:System.Collections.Queue" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="array" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным.  
		///
		/// или - 
		/// Число элементов в исходном массиве <see cref="T:System.Collections.Queue" /> больше возможного для размещения числа элементов от положения, заданного значением параметра <paramref name="index" />, до конца массива назначения <paramref name="array" />.</exception>
		/// <exception cref="T:System.ArrayTypeMismatchException">Тип исходного массива <see cref="T:System.Collections.Queue" /> не может быть автоматически приведен к типу массива назначения <paramref name="array" />.</exception>
		// Token: 0x06005C1E RID: 23582 RVA: 0x00135D5C File Offset: 0x00133F5C
		public virtual void CopyTo(Array array, int index)
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
				throw new ArgumentOutOfRangeException("index", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			if (array.Length - index < this._size)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			int num = this._size;
			if (num == 0)
			{
				return;
			}
			int num2 = (this._array.Length - this._head < num) ? (this._array.Length - this._head) : num;
			Array.Copy(this._array, this._head, array, index, num2);
			num -= num2;
			if (num > 0)
			{
				Array.Copy(this._array, 0, array, index + this._array.Length - this._head, num);
			}
		}

		/// <summary>Добавляет объект в конец очереди <see cref="T:System.Collections.Queue" />.</summary>
		/// <param name="obj">Объект, добавляемый в коллекцию <see cref="T:System.Collections.Queue" />. Допускается значение <see langword="null" />.</param>
		// Token: 0x06005C1F RID: 23583 RVA: 0x00135E2C File Offset: 0x0013402C
		public virtual void Enqueue(object obj)
		{
			if (this._size == this._array.Length)
			{
				int num = (int)((long)this._array.Length * (long)this._growFactor / 100L);
				if (num < this._array.Length + 4)
				{
					num = this._array.Length + 4;
				}
				this.SetCapacity(num);
			}
			this._array[this._tail] = obj;
			this._tail = (this._tail + 1) % this._array.Length;
			this._size++;
			this._version++;
		}

		/// <summary>Возвращает перечислитель, осуществляющий перебор элементов списка <see cref="T:System.Collections.Queue" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IEnumerator" /> для <see cref="T:System.Collections.Queue" />.</returns>
		// Token: 0x06005C20 RID: 23584 RVA: 0x00135EC0 File Offset: 0x001340C0
		public virtual IEnumerator GetEnumerator()
		{
			return new Queue.QueueEnumerator(this);
		}

		/// <summary>Удаляет объект из начала очереди <see cref="T:System.Collections.Queue" /> и возвращает его.</summary>
		/// <returns>Объект, удаляемый из начала очереди <see cref="T:System.Collections.Queue" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Очередь <see cref="T:System.Collections.Queue" /> является пустой.</exception>
		// Token: 0x06005C21 RID: 23585 RVA: 0x00135EC8 File Offset: 0x001340C8
		public virtual object Dequeue()
		{
			if (this.Count == 0)
			{
				throw new InvalidOperationException("Queue empty.");
			}
			object result = this._array[this._head];
			this._array[this._head] = null;
			this._head = (this._head + 1) % this._array.Length;
			this._size--;
			this._version++;
			return result;
		}

		/// <summary>Возвращает объект, находящийся в начале очереди <see cref="T:System.Collections.Queue" />, но не удаляет его.</summary>
		/// <returns>Объект, находящийся в начале очереди <see cref="T:System.Collections.Queue" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Очередь <see cref="T:System.Collections.Queue" /> является пустой.</exception>
		// Token: 0x06005C22 RID: 23586 RVA: 0x00135F36 File Offset: 0x00134136
		public virtual object Peek()
		{
			if (this.Count == 0)
			{
				throw new InvalidOperationException("Queue empty.");
			}
			return this._array[this._head];
		}

		/// <summary>Возвращает новый объект <see cref="T:System.Collections.Queue" />, заключает исходную очередь в оболочку и является потокобезопасным.</summary>
		/// <param name="queue">Коллекция <see cref="T:System.Collections.Queue" />, которую требуется синхронизировать.</param>
		/// <returns>Синхронизированная (потокобезопасная) оболочка коллекции <see cref="T:System.Collections.Queue" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="queue" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005C23 RID: 23587 RVA: 0x00135F58 File Offset: 0x00134158
		public static Queue Synchronized(Queue queue)
		{
			if (queue == null)
			{
				throw new ArgumentNullException("queue");
			}
			return new Queue.SynchronizedQueue(queue);
		}

		/// <summary>Определяет, входит ли элемент в коллекцию <see cref="T:System.Collections.Queue" />.</summary>
		/// <param name="obj">Объект <see cref="T:System.Object" />, который требуется найти в коллекции <see cref="T:System.Collections.Queue" />. Допускается значение <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="obj" /> найден в коллекции <see cref="T:System.Collections.Queue" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06005C24 RID: 23588 RVA: 0x00135F70 File Offset: 0x00134170
		public virtual bool Contains(object obj)
		{
			int num = this._head;
			int size = this._size;
			while (size-- > 0)
			{
				if (obj == null)
				{
					if (this._array[num] == null)
					{
						return true;
					}
				}
				else if (this._array[num] != null && this._array[num].Equals(obj))
				{
					return true;
				}
				num = (num + 1) % this._array.Length;
			}
			return false;
		}

		// Token: 0x06005C25 RID: 23589 RVA: 0x00135FCE File Offset: 0x001341CE
		internal object GetElement(int i)
		{
			return this._array[(this._head + i) % this._array.Length];
		}

		/// <summary>Копирует элементы <see cref="T:System.Collections.Queue" /> в новый массив.</summary>
		/// <returns>Новый массив, содержащий элементы, скопированные из <see cref="T:System.Collections.Queue" />.</returns>
		// Token: 0x06005C26 RID: 23590 RVA: 0x00135FE8 File Offset: 0x001341E8
		public virtual object[] ToArray()
		{
			if (this._size == 0)
			{
				return Array.Empty<object>();
			}
			object[] array = new object[this._size];
			if (this._head < this._tail)
			{
				Array.Copy(this._array, this._head, array, 0, this._size);
			}
			else
			{
				Array.Copy(this._array, this._head, array, 0, this._array.Length - this._head);
				Array.Copy(this._array, 0, array, this._array.Length - this._head, this._tail);
			}
			return array;
		}

		// Token: 0x06005C27 RID: 23591 RVA: 0x00136080 File Offset: 0x00134280
		private void SetCapacity(int capacity)
		{
			object[] array = new object[capacity];
			if (this._size > 0)
			{
				if (this._head < this._tail)
				{
					Array.Copy(this._array, this._head, array, 0, this._size);
				}
				else
				{
					Array.Copy(this._array, this._head, array, 0, this._array.Length - this._head);
					Array.Copy(this._array, 0, array, this._array.Length - this._head, this._tail);
				}
			}
			this._array = array;
			this._head = 0;
			this._tail = ((this._size == capacity) ? 0 : this._size);
			this._version++;
		}

		/// <summary>Задает значение емкости, равное действительному количеству элементов в <see cref="T:System.Collections.Queue" />.</summary>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Collections.Queue" /> доступен только для чтения.</exception>
		// Token: 0x06005C28 RID: 23592 RVA: 0x0013613E File Offset: 0x0013433E
		public virtual void TrimToSize()
		{
			this.SetCapacity(this._size);
		}

		// Token: 0x0400388A RID: 14474
		private object[] _array;

		// Token: 0x0400388B RID: 14475
		private int _head;

		// Token: 0x0400388C RID: 14476
		private int _tail;

		// Token: 0x0400388D RID: 14477
		private int _size;

		// Token: 0x0400388E RID: 14478
		private int _growFactor;

		// Token: 0x0400388F RID: 14479
		private int _version;

		// Token: 0x04003890 RID: 14480
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x04003891 RID: 14481
		private const int _MinimumGrow = 4;

		// Token: 0x04003892 RID: 14482
		private const int _ShrinkThreshold = 32;

		// Token: 0x02000A28 RID: 2600
		[Serializable]
		private class SynchronizedQueue : Queue
		{
			// Token: 0x06005C29 RID: 23593 RVA: 0x0013614C File Offset: 0x0013434C
			internal SynchronizedQueue(Queue q)
			{
				this._q = q;
				this._root = this._q.SyncRoot;
			}

			// Token: 0x17000FFA RID: 4090
			// (get) Token: 0x06005C2A RID: 23594 RVA: 0x000040F7 File Offset: 0x000022F7
			public override bool IsSynchronized
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000FFB RID: 4091
			// (get) Token: 0x06005C2B RID: 23595 RVA: 0x0013616C File Offset: 0x0013436C
			public override object SyncRoot
			{
				get
				{
					return this._root;
				}
			}

			// Token: 0x17000FFC RID: 4092
			// (get) Token: 0x06005C2C RID: 23596 RVA: 0x00136174 File Offset: 0x00134374
			public override int Count
			{
				get
				{
					object root = this._root;
					int count;
					lock (root)
					{
						count = this._q.Count;
					}
					return count;
				}
			}

			// Token: 0x06005C2D RID: 23597 RVA: 0x001361BC File Offset: 0x001343BC
			public override void Clear()
			{
				object root = this._root;
				lock (root)
				{
					this._q.Clear();
				}
			}

			// Token: 0x06005C2E RID: 23598 RVA: 0x00136204 File Offset: 0x00134404
			public override object Clone()
			{
				object root = this._root;
				object result;
				lock (root)
				{
					result = new Queue.SynchronizedQueue((Queue)this._q.Clone());
				}
				return result;
			}

			// Token: 0x06005C2F RID: 23599 RVA: 0x00136258 File Offset: 0x00134458
			public override bool Contains(object obj)
			{
				object root = this._root;
				bool result;
				lock (root)
				{
					result = this._q.Contains(obj);
				}
				return result;
			}

			// Token: 0x06005C30 RID: 23600 RVA: 0x001362A0 File Offset: 0x001344A0
			public override void CopyTo(Array array, int arrayIndex)
			{
				object root = this._root;
				lock (root)
				{
					this._q.CopyTo(array, arrayIndex);
				}
			}

			// Token: 0x06005C31 RID: 23601 RVA: 0x001362E8 File Offset: 0x001344E8
			public override void Enqueue(object value)
			{
				object root = this._root;
				lock (root)
				{
					this._q.Enqueue(value);
				}
			}

			// Token: 0x06005C32 RID: 23602 RVA: 0x00136330 File Offset: 0x00134530
			public override object Dequeue()
			{
				object root = this._root;
				object result;
				lock (root)
				{
					result = this._q.Dequeue();
				}
				return result;
			}

			// Token: 0x06005C33 RID: 23603 RVA: 0x00136378 File Offset: 0x00134578
			public override IEnumerator GetEnumerator()
			{
				object root = this._root;
				IEnumerator enumerator;
				lock (root)
				{
					enumerator = this._q.GetEnumerator();
				}
				return enumerator;
			}

			// Token: 0x06005C34 RID: 23604 RVA: 0x001363C0 File Offset: 0x001345C0
			public override object Peek()
			{
				object root = this._root;
				object result;
				lock (root)
				{
					result = this._q.Peek();
				}
				return result;
			}

			// Token: 0x06005C35 RID: 23605 RVA: 0x00136408 File Offset: 0x00134608
			public override object[] ToArray()
			{
				object root = this._root;
				object[] result;
				lock (root)
				{
					result = this._q.ToArray();
				}
				return result;
			}

			// Token: 0x06005C36 RID: 23606 RVA: 0x00136450 File Offset: 0x00134650
			public override void TrimToSize()
			{
				object root = this._root;
				lock (root)
				{
					this._q.TrimToSize();
				}
			}

			// Token: 0x04003893 RID: 14483
			private Queue _q;

			// Token: 0x04003894 RID: 14484
			private object _root;
		}

		// Token: 0x02000A29 RID: 2601
		[Serializable]
		private class QueueEnumerator : IEnumerator, ICloneable
		{
			// Token: 0x06005C37 RID: 23607 RVA: 0x00136498 File Offset: 0x00134698
			internal QueueEnumerator(Queue q)
			{
				this._q = q;
				this._version = this._q._version;
				this._index = 0;
				this._currentElement = this._q._array;
				if (this._q._size == 0)
				{
					this._index = -1;
				}
			}

			// Token: 0x06005C38 RID: 23608 RVA: 0x000231CD File Offset: 0x000213CD
			public object Clone()
			{
				return base.MemberwiseClone();
			}

			// Token: 0x06005C39 RID: 23609 RVA: 0x001364F0 File Offset: 0x001346F0
			public virtual bool MoveNext()
			{
				if (this._version != this._q._version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				if (this._index < 0)
				{
					this._currentElement = this._q._array;
					return false;
				}
				this._currentElement = this._q.GetElement(this._index);
				this._index++;
				if (this._index == this._q._size)
				{
					this._index = -1;
				}
				return true;
			}

			// Token: 0x17000FFD RID: 4093
			// (get) Token: 0x06005C3A RID: 23610 RVA: 0x00136577 File Offset: 0x00134777
			public virtual object Current
			{
				get
				{
					if (this._currentElement != this._q._array)
					{
						return this._currentElement;
					}
					if (this._index == 0)
					{
						throw new InvalidOperationException("Enumeration has not started. Call MoveNext.");
					}
					throw new InvalidOperationException("Enumeration already finished.");
				}
			}

			// Token: 0x06005C3B RID: 23611 RVA: 0x001365B0 File Offset: 0x001347B0
			public virtual void Reset()
			{
				if (this._version != this._q._version)
				{
					throw new InvalidOperationException("Collection was modified; enumeration operation may not execute.");
				}
				if (this._q._size == 0)
				{
					this._index = -1;
				}
				else
				{
					this._index = 0;
				}
				this._currentElement = this._q._array;
			}

			// Token: 0x04003895 RID: 14485
			private Queue _q;

			// Token: 0x04003896 RID: 14486
			private int _index;

			// Token: 0x04003897 RID: 14487
			private int _version;

			// Token: 0x04003898 RID: 14488
			private object _currentElement;
		}

		// Token: 0x02000A2A RID: 2602
		internal class QueueDebugView
		{
			// Token: 0x06005C3C RID: 23612 RVA: 0x00136609 File Offset: 0x00134809
			public QueueDebugView(Queue queue)
			{
				if (queue == null)
				{
					throw new ArgumentNullException("queue");
				}
				this._queue = queue;
			}

			// Token: 0x17000FFE RID: 4094
			// (get) Token: 0x06005C3D RID: 23613 RVA: 0x00136626 File Offset: 0x00134826
			[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
			public object[] Items
			{
				get
				{
					return this._queue.ToArray();
				}
			}

			// Token: 0x04003899 RID: 14489
			private Queue _queue;
		}
	}
}
