using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace System.Collections.Concurrent
{
	/// <summary>Представляет потокобезопасную неупорядоченную коллекцию объектов.</summary>
	/// <typeparam name="T">Тип элементов, хранимых в коллекции.</typeparam>
	// Token: 0x0200049D RID: 1181
	[DebuggerTypeProxy(typeof(IProducerConsumerCollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public class ConcurrentBag<T> : IProducerConsumerCollection<T>, IEnumerable<!0>, IEnumerable, ICollection, IReadOnlyCollection<T>
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />.</summary>
		// Token: 0x060025E0 RID: 9696 RVA: 0x00084934 File Offset: 0x00082B34
		public ConcurrentBag()
		{
			this._locals = new ThreadLocal<ConcurrentBag<T>.WorkStealingQueue>();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />, который содержит элементы, скопированные из указанной коллекции.</summary>
		/// <param name="collection">Коллекция, элементы которой копируются в новую коллекцию <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="collection" /> является ссылкой на null (Nothing в Visual Basic).</exception>
		// Token: 0x060025E1 RID: 9697 RVA: 0x00084948 File Offset: 0x00082B48
		public ConcurrentBag(IEnumerable<T> collection)
		{
			if (collection == null)
			{
				throw new ArgumentNullException("collection", "The collection argument is null.");
			}
			this._locals = new ThreadLocal<ConcurrentBag<T>.WorkStealingQueue>();
			ConcurrentBag<T>.WorkStealingQueue currentThreadWorkStealingQueue = this.GetCurrentThreadWorkStealingQueue(true);
			foreach (T item in collection)
			{
				currentThreadWorkStealingQueue.LocalPush(item, ref this._emptyToNonEmptyListTransitionCount);
			}
		}

		/// <summary>Добавляет объект в <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />.</summary>
		/// <param name="item">Объект, который должен быть добавлен в коллекцию <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />. Значение ссылочных типов может быть пустой ссылкой (Nothing в Visual Basic).</param>
		// Token: 0x060025E2 RID: 9698 RVA: 0x000849C4 File Offset: 0x00082BC4
		public void Add(T item)
		{
			this.GetCurrentThreadWorkStealingQueue(true).LocalPush(item, ref this._emptyToNonEmptyListTransitionCount);
		}

		// Token: 0x060025E3 RID: 9699 RVA: 0x000849D9 File Offset: 0x00082BD9
		bool IProducerConsumerCollection<!0>.TryAdd(T item)
		{
			this.Add(item);
			return true;
		}

		/// <summary>Пытается удалить и вернуть объект из коллекции <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />.</summary>
		/// <param name="result">Параметр <paramref name="result" />, возвращаемый данным методом, содержит объект, удаленный из <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" /> или значение по умолчанию <typeparamref name="T" />, если контейнер пуст.</param>
		/// <returns>Значение true, если объект был успешно удален; в противном случае — значение false.</returns>
		// Token: 0x060025E4 RID: 9700 RVA: 0x000849E4 File Offset: 0x00082BE4
		public bool TryTake(out T result)
		{
			ConcurrentBag<T>.WorkStealingQueue currentThreadWorkStealingQueue = this.GetCurrentThreadWorkStealingQueue(false);
			return (currentThreadWorkStealingQueue != null && currentThreadWorkStealingQueue.TryLocalPop(out result)) || this.TrySteal(out result, true);
		}

		/// <summary>Пытается вернуть объект из <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" /> без его удаления.</summary>
		/// <param name="result">Параметр <paramref name="result" />, возвращаемый данным методом, содержит объект из <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" /> или значение по умолчанию <typeparamref name="T" />, если произошел сбой операции.</param>
		/// <returns>Значение true, если объект был успешно возвращен; в противном случае — значение false.</returns>
		// Token: 0x060025E5 RID: 9701 RVA: 0x00084A10 File Offset: 0x00082C10
		public bool TryPeek(out T result)
		{
			ConcurrentBag<T>.WorkStealingQueue currentThreadWorkStealingQueue = this.GetCurrentThreadWorkStealingQueue(false);
			return (currentThreadWorkStealingQueue != null && currentThreadWorkStealingQueue.TryLocalPeek(out result)) || this.TrySteal(out result, false);
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x00084A3B File Offset: 0x00082C3B
		private ConcurrentBag<T>.WorkStealingQueue GetCurrentThreadWorkStealingQueue(bool forceCreate)
		{
			ConcurrentBag<T>.WorkStealingQueue result;
			if ((result = this._locals.Value) == null)
			{
				if (!forceCreate)
				{
					return null;
				}
				result = this.CreateWorkStealingQueueForCurrentThread();
			}
			return result;
		}

		// Token: 0x060025E7 RID: 9703 RVA: 0x00084A58 File Offset: 0x00082C58
		private ConcurrentBag<T>.WorkStealingQueue CreateWorkStealingQueueForCurrentThread()
		{
			object globalQueuesLock = this.GlobalQueuesLock;
			ConcurrentBag<T>.WorkStealingQueue result;
			lock (globalQueuesLock)
			{
				ConcurrentBag<T>.WorkStealingQueue workStealingQueues = this._workStealingQueues;
				ConcurrentBag<T>.WorkStealingQueue workStealingQueue = (workStealingQueues != null) ? this.GetUnownedWorkStealingQueue() : null;
				if (workStealingQueue == null)
				{
					workStealingQueue = (this._workStealingQueues = new ConcurrentBag<T>.WorkStealingQueue(workStealingQueues));
				}
				this._locals.Value = workStealingQueue;
				result = workStealingQueue;
			}
			return result;
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x00084ACC File Offset: 0x00082CCC
		private ConcurrentBag<T>.WorkStealingQueue GetUnownedWorkStealingQueue()
		{
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			for (ConcurrentBag<T>.WorkStealingQueue workStealingQueue = this._workStealingQueues; workStealingQueue != null; workStealingQueue = workStealingQueue._nextQueue)
			{
				if (workStealingQueue._ownerThreadId == currentManagedThreadId)
				{
					return workStealingQueue;
				}
			}
			return null;
		}

		// Token: 0x060025E9 RID: 9705 RVA: 0x00084B00 File Offset: 0x00082D00
		private bool TrySteal(out T result, bool take)
		{
			if (take)
			{
				CDSCollectionETWBCLProvider.Log.ConcurrentBag_TryTakeSteals();
			}
			else
			{
				CDSCollectionETWBCLProvider.Log.ConcurrentBag_TryPeekSteals();
			}
			for (;;)
			{
				long num = Interlocked.Read(ref this._emptyToNonEmptyListTransitionCount);
				ConcurrentBag<T>.WorkStealingQueue currentThreadWorkStealingQueue = this.GetCurrentThreadWorkStealingQueue(false);
				if ((currentThreadWorkStealingQueue == null) ? this.TryStealFromTo(this._workStealingQueues, null, out result, take) : (this.TryStealFromTo(currentThreadWorkStealingQueue._nextQueue, null, out result, take) || this.TryStealFromTo(this._workStealingQueues, currentThreadWorkStealingQueue, out result, take)))
				{
					break;
				}
				if (Interlocked.Read(ref this._emptyToNonEmptyListTransitionCount) == num)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x00084B88 File Offset: 0x00082D88
		private bool TryStealFromTo(ConcurrentBag<T>.WorkStealingQueue startInclusive, ConcurrentBag<T>.WorkStealingQueue endExclusive, out T result, bool take)
		{
			for (ConcurrentBag<T>.WorkStealingQueue workStealingQueue = startInclusive; workStealingQueue != endExclusive; workStealingQueue = workStealingQueue._nextQueue)
			{
				if (workStealingQueue.TrySteal(out result, take))
				{
					return true;
				}
			}
			result = default(T);
			return false;
		}

		/// <summary>Копирует элементы коллекции <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" /> в существующий одномерный массив <see cref="T:System.Array" />, начиная с указанного значения индекса массива.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы коллекции <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="array" /> является ссылкой на null (Nothing в Visual Basic).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="index" /> больше или равен длине <paramref name="array" /> -или- число элементов в источнике <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" /> превышает объем доступного пространства в диапазоне от <paramref name="index" /> до конца массива назначения <paramref name="array" />.</exception>
		// Token: 0x060025EB RID: 9707 RVA: 0x00084BBC File Offset: 0x00082DBC
		public void CopyTo(T[] array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array", "The array argument is null.");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "The index argument must be greater than or equal zero.");
			}
			if (this._workStealingQueues == null)
			{
				return;
			}
			bool lockTaken = false;
			try
			{
				this.FreezeBag(ref lockTaken);
				int dangerousCount = this.DangerousCount;
				if (index > array.Length - dangerousCount)
				{
					throw new ArgumentException("The number of elements in the collection is greater than the available space from index to the end of the destination array.", "index");
				}
				try
				{
					this.CopyFromEachQueueToArray(array, index);
				}
				catch (ArrayTypeMismatchException ex)
				{
					throw new InvalidCastException(ex.Message, ex);
				}
			}
			finally
			{
				this.UnfreezeBag(lockTaken);
			}
		}

		// Token: 0x060025EC RID: 9708 RVA: 0x00084C64 File Offset: 0x00082E64
		private int CopyFromEachQueueToArray(T[] array, int index)
		{
			int num = index;
			for (ConcurrentBag<T>.WorkStealingQueue workStealingQueue = this._workStealingQueues; workStealingQueue != null; workStealingQueue = workStealingQueue._nextQueue)
			{
				num += workStealingQueue.DangerousCopyTo(array, num);
			}
			return num - index;
		}

		/// <summary>Копирует элементы коллекции <see cref="T:System.Collections.ICollection" /> в массив <see cref="T:System.Array" />, начиная с указанного индекса массива <see cref="T:System.Array" />.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы коллекции <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="array" /> является ссылкой на null (Nothing в Visual Basic).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Массив <paramref name="array" /> является многомерным. - или - <paramref name="array" /> не поддерживает индексацию, начинающуюся с нуля. - или - <paramref name="index" /> больше или равен длине <paramref name="array" />, - или - количество элементов в источнике <see cref="T:System.Collections.ICollection" /> больше, чем свободное пространство в диапазоне от <paramref name="index" /> до конца массива назначения <paramref name="array" />. - или - тип источника <see cref="T:System.Collections.ICollection" /> не может быть автоматически приведен к типу массива назначения <paramref name="array" />.</exception>
		// Token: 0x060025ED RID: 9709 RVA: 0x00084C98 File Offset: 0x00082E98
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
				throw new ArgumentNullException("array", "The array argument is null.");
			}
			this.ToArray().CopyTo(array, index);
		}

		/// <summary>Копирует элементы <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" /> в новый массив.</summary>
		/// <returns>Новый массив, содержащий снимок элементов, скопированных из коллекции <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />.</returns>
		// Token: 0x060025EE RID: 9710 RVA: 0x00084CD8 File Offset: 0x00082ED8
		public T[] ToArray()
		{
			if (this._workStealingQueues != null)
			{
				bool lockTaken = false;
				try
				{
					this.FreezeBag(ref lockTaken);
					int dangerousCount = this.DangerousCount;
					if (dangerousCount > 0)
					{
						T[] array = new T[dangerousCount];
						this.CopyFromEachQueueToArray(array, 0);
						return array;
					}
				}
				finally
				{
					this.UnfreezeBag(lockTaken);
				}
			}
			return Array.Empty<T>();
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x00084D3C File Offset: 0x00082F3C
		public void Clear()
		{
			if (this._workStealingQueues == null)
			{
				return;
			}
			ConcurrentBag<T>.WorkStealingQueue currentThreadWorkStealingQueue = this.GetCurrentThreadWorkStealingQueue(false);
			if (currentThreadWorkStealingQueue != null)
			{
				currentThreadWorkStealingQueue.LocalClear();
				if (currentThreadWorkStealingQueue._nextQueue == null && currentThreadWorkStealingQueue == this._workStealingQueues)
				{
					return;
				}
			}
			bool lockTaken = false;
			try
			{
				this.FreezeBag(ref lockTaken);
				for (ConcurrentBag<T>.WorkStealingQueue workStealingQueue = this._workStealingQueues; workStealingQueue != null; workStealingQueue = workStealingQueue._nextQueue)
				{
					T t;
					while (workStealingQueue.TrySteal(out t, true))
					{
					}
				}
			}
			finally
			{
				this.UnfreezeBag(lockTaken);
			}
		}

		/// <summary>Возвращает перечислитель, осуществляющий перебор элементов списка <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />.</summary>
		/// <returns>Перечислитель для содержимого <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />.</returns>
		// Token: 0x060025F0 RID: 9712 RVA: 0x00084DC0 File Offset: 0x00082FC0
		public IEnumerator<T> GetEnumerator()
		{
			return new ConcurrentBag<T>.Enumerator(this.ToArray());
		}

		/// <summary>Возвращает перечислитель, осуществляющий перебор элементов списка <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />.</summary>
		/// <returns>Перечислитель для содержимого <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />.</returns>
		// Token: 0x060025F1 RID: 9713 RVA: 0x00084DCD File Offset: 0x00082FCD
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>Получает число элементов, содержащихся в интерфейсе <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />.</summary>
		/// <returns>Число элементов, содержащихся в интерфейсе <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />.</returns>
		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x060025F2 RID: 9714 RVA: 0x00084DD8 File Offset: 0x00082FD8
		public int Count
		{
			get
			{
				if (this._workStealingQueues == null)
				{
					return 0;
				}
				bool lockTaken = false;
				int dangerousCount;
				try
				{
					this.FreezeBag(ref lockTaken);
					dangerousCount = this.DangerousCount;
				}
				finally
				{
					this.UnfreezeBag(lockTaken);
				}
				return dangerousCount;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x060025F3 RID: 9715 RVA: 0x00084E20 File Offset: 0x00083020
		private int DangerousCount
		{
			get
			{
				int num = 0;
				checked
				{
					for (ConcurrentBag<T>.WorkStealingQueue workStealingQueue = this._workStealingQueues; workStealingQueue != null; workStealingQueue = workStealingQueue._nextQueue)
					{
						num += workStealingQueue.DangerousCount;
					}
					return num;
				}
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли коллекция <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" /> пустой.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" /> пуст; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x060025F4 RID: 9716 RVA: 0x00084E50 File Offset: 0x00083050
		public bool IsEmpty
		{
			get
			{
				ConcurrentBag<T>.WorkStealingQueue currentThreadWorkStealingQueue = this.GetCurrentThreadWorkStealingQueue(false);
				if (currentThreadWorkStealingQueue != null)
				{
					if (!currentThreadWorkStealingQueue.IsEmpty)
					{
						return false;
					}
					if (currentThreadWorkStealingQueue._nextQueue == null && currentThreadWorkStealingQueue == this._workStealingQueues)
					{
						return true;
					}
				}
				bool lockTaken = false;
				try
				{
					this.FreezeBag(ref lockTaken);
					for (ConcurrentBag<T>.WorkStealingQueue workStealingQueue = this._workStealingQueues; workStealingQueue != null; workStealingQueue = workStealingQueue._nextQueue)
					{
						if (!workStealingQueue.IsEmpty)
						{
							return false;
						}
					}
				}
				finally
				{
					this.UnfreezeBag(lockTaken);
				}
				return true;
			}
		}

		/// <summary>Возвращает значение, указывающее, синхронизирован ли доступ к коллекции <see cref="T:System.Collections.ICollection" /> с SyncRoot.</summary>
		/// <returns>Всегда возвращает <see langword="false" /> укажите доступа не синхронизированы.</returns>
		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x060025F5 RID: 9717 RVA: 0x00003062 File Offset: 0x00001262
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
		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x060025F6 RID: 9718 RVA: 0x000839A3 File Offset: 0x00081BA3
		object ICollection.SyncRoot
		{
			get
			{
				throw new NotSupportedException("The SyncRoot property may not be used for the synchronization of concurrent collections.");
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x060025F7 RID: 9719 RVA: 0x00084ED0 File Offset: 0x000830D0
		private object GlobalQueuesLock
		{
			get
			{
				return this._locals;
			}
		}

		// Token: 0x060025F8 RID: 9720 RVA: 0x00084ED8 File Offset: 0x000830D8
		private void FreezeBag(ref bool lockTaken)
		{
			Monitor.Enter(this.GlobalQueuesLock, ref lockTaken);
			ConcurrentBag<T>.WorkStealingQueue workStealingQueues = this._workStealingQueues;
			for (ConcurrentBag<T>.WorkStealingQueue workStealingQueue = workStealingQueues; workStealingQueue != null; workStealingQueue = workStealingQueue._nextQueue)
			{
				Monitor.Enter(workStealingQueue, ref workStealingQueue._frozen);
			}
			Interlocked.MemoryBarrier();
			for (ConcurrentBag<T>.WorkStealingQueue workStealingQueue2 = workStealingQueues; workStealingQueue2 != null; workStealingQueue2 = workStealingQueue2._nextQueue)
			{
				if (workStealingQueue2._currentOp != 0)
				{
					SpinWait spinWait = default(SpinWait);
					do
					{
						spinWait.SpinOnce();
					}
					while (workStealingQueue2._currentOp != 0);
				}
			}
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x00084F4C File Offset: 0x0008314C
		private void UnfreezeBag(bool lockTaken)
		{
			if (lockTaken)
			{
				for (ConcurrentBag<T>.WorkStealingQueue workStealingQueue = this._workStealingQueues; workStealingQueue != null; workStealingQueue = workStealingQueue._nextQueue)
				{
					if (workStealingQueue._frozen)
					{
						workStealingQueue._frozen = false;
						Monitor.Exit(workStealingQueue);
					}
				}
				Monitor.Exit(this.GlobalQueuesLock);
			}
		}

		// Token: 0x040014CB RID: 5323
		private readonly ThreadLocal<ConcurrentBag<T>.WorkStealingQueue> _locals;

		// Token: 0x040014CC RID: 5324
		private volatile ConcurrentBag<T>.WorkStealingQueue _workStealingQueues;

		// Token: 0x040014CD RID: 5325
		private long _emptyToNonEmptyListTransitionCount;

		// Token: 0x0200049E RID: 1182
		private sealed class WorkStealingQueue
		{
			// Token: 0x060025FA RID: 9722 RVA: 0x00084F91 File Offset: 0x00083191
			internal WorkStealingQueue(ConcurrentBag<T>.WorkStealingQueue nextQueue)
			{
				this._ownerThreadId = Environment.CurrentManagedThreadId;
				this._nextQueue = nextQueue;
			}

			// Token: 0x170007A3 RID: 1955
			// (get) Token: 0x060025FB RID: 9723 RVA: 0x00084FC4 File Offset: 0x000831C4
			internal bool IsEmpty
			{
				get
				{
					return this._headIndex >= this._tailIndex;
				}
			}

			// Token: 0x060025FC RID: 9724 RVA: 0x00084FDC File Offset: 0x000831DC
			internal void LocalPush(T item, ref long emptyToNonEmptyListTransitionCount)
			{
				bool flag = false;
				try
				{
					Interlocked.Exchange(ref this._currentOp, 1);
					int num = this._tailIndex;
					if (num == 2147483647)
					{
						this._currentOp = 0;
						lock (this)
						{
							this._headIndex &= this._mask;
							num = (this._tailIndex = (num & this._mask));
							Interlocked.Exchange(ref this._currentOp, 1);
						}
					}
					int headIndex = this._headIndex;
					if (!this._frozen && (headIndex < num - 1 & num < headIndex + this._mask))
					{
						this._array[num & this._mask] = item;
						this._tailIndex = num + 1;
					}
					else
					{
						this._currentOp = 0;
						Monitor.Enter(this, ref flag);
						headIndex = this._headIndex;
						int num2 = num - headIndex;
						if (num2 >= this._mask)
						{
							T[] array = new T[this._array.Length << 1];
							int num3 = headIndex & this._mask;
							if (num3 == 0)
							{
								Array.Copy(this._array, 0, array, 0, this._array.Length);
							}
							else
							{
								Array.Copy(this._array, num3, array, 0, this._array.Length - num3);
								Array.Copy(this._array, 0, array, this._array.Length - num3, num3);
							}
							this._array = array;
							this._headIndex = 0;
							num = (this._tailIndex = num2);
							this._mask = (this._mask << 1 | 1);
						}
						this._array[num & this._mask] = item;
						this._tailIndex = num + 1;
						if (num2 == 0)
						{
							Interlocked.Increment(ref emptyToNonEmptyListTransitionCount);
						}
						this._addTakeCount -= this._stealCount;
						this._stealCount = 0;
					}
					checked
					{
						this._addTakeCount++;
					}
				}
				finally
				{
					this._currentOp = 0;
					if (flag)
					{
						Monitor.Exit(this);
					}
				}
			}

			// Token: 0x060025FD RID: 9725 RVA: 0x00085234 File Offset: 0x00083434
			internal void LocalClear()
			{
				lock (this)
				{
					if (this._headIndex < this._tailIndex)
					{
						this._headIndex = (this._tailIndex = 0);
						this._addTakeCount = (this._stealCount = 0);
						Array.Clear(this._array, 0, this._array.Length);
					}
				}
			}

			// Token: 0x060025FE RID: 9726 RVA: 0x000852B8 File Offset: 0x000834B8
			internal bool TryLocalPop(out T result)
			{
				int num = this._tailIndex;
				if (this._headIndex >= num)
				{
					result = default(T);
					return false;
				}
				bool flag = false;
				bool result2;
				try
				{
					this._currentOp = 2;
					Interlocked.Exchange(ref this._tailIndex, --num);
					if (!this._frozen && this._headIndex < num)
					{
						int num2 = num & this._mask;
						result = this._array[num2];
						this._array[num2] = default(T);
						this._addTakeCount--;
						result2 = true;
					}
					else
					{
						this._currentOp = 0;
						Monitor.Enter(this, ref flag);
						if (this._headIndex <= num)
						{
							int num3 = num & this._mask;
							result = this._array[num3];
							this._array[num3] = default(T);
							this._addTakeCount--;
							result2 = true;
						}
						else
						{
							this._tailIndex = num + 1;
							result = default(T);
							result2 = false;
						}
					}
				}
				finally
				{
					this._currentOp = 0;
					if (flag)
					{
						Monitor.Exit(this);
					}
				}
				return result2;
			}

			// Token: 0x060025FF RID: 9727 RVA: 0x00085404 File Offset: 0x00083604
			internal bool TryLocalPeek(out T result)
			{
				int tailIndex = this._tailIndex;
				if (this._headIndex < tailIndex)
				{
					lock (this)
					{
						if (this._headIndex < tailIndex)
						{
							result = this._array[tailIndex - 1 & this._mask];
							return true;
						}
					}
				}
				result = default(T);
				return false;
			}

			// Token: 0x06002600 RID: 9728 RVA: 0x00085488 File Offset: 0x00083688
			internal bool TrySteal(out T result, bool take)
			{
				lock (this)
				{
					int headIndex = this._headIndex;
					if (take)
					{
						if (headIndex < this._tailIndex - 1 && this._currentOp != 1)
						{
							SpinWait spinWait = default(SpinWait);
							do
							{
								spinWait.SpinOnce();
							}
							while (this._currentOp == 1);
						}
						Interlocked.Exchange(ref this._headIndex, headIndex + 1);
						if (headIndex < this._tailIndex)
						{
							int num = headIndex & this._mask;
							result = this._array[num];
							this._array[num] = default(T);
							this._stealCount++;
							return true;
						}
						this._headIndex = headIndex;
					}
					else if (headIndex < this._tailIndex)
					{
						result = this._array[headIndex & this._mask];
						return true;
					}
				}
				result = default(T);
				return false;
			}

			// Token: 0x06002601 RID: 9729 RVA: 0x000855A8 File Offset: 0x000837A8
			internal int DangerousCopyTo(T[] array, int arrayIndex)
			{
				int headIndex = this._headIndex;
				int dangerousCount = this.DangerousCount;
				for (int i = arrayIndex + dangerousCount - 1; i >= arrayIndex; i--)
				{
					array[i] = this._array[headIndex++ & this._mask];
				}
				return dangerousCount;
			}

			// Token: 0x170007A4 RID: 1956
			// (get) Token: 0x06002602 RID: 9730 RVA: 0x000855F8 File Offset: 0x000837F8
			internal int DangerousCount
			{
				get
				{
					return this._addTakeCount - this._stealCount;
				}
			}

			// Token: 0x040014CE RID: 5326
			private const int InitialSize = 32;

			// Token: 0x040014CF RID: 5327
			private const int StartIndex = 0;

			// Token: 0x040014D0 RID: 5328
			private volatile int _headIndex;

			// Token: 0x040014D1 RID: 5329
			private volatile int _tailIndex;

			// Token: 0x040014D2 RID: 5330
			private volatile T[] _array = new T[32];

			// Token: 0x040014D3 RID: 5331
			private volatile int _mask = 31;

			// Token: 0x040014D4 RID: 5332
			private int _addTakeCount;

			// Token: 0x040014D5 RID: 5333
			private int _stealCount;

			// Token: 0x040014D6 RID: 5334
			internal volatile int _currentOp;

			// Token: 0x040014D7 RID: 5335
			internal bool _frozen;

			// Token: 0x040014D8 RID: 5336
			internal readonly ConcurrentBag<T>.WorkStealingQueue _nextQueue;

			// Token: 0x040014D9 RID: 5337
			internal readonly int _ownerThreadId;
		}

		// Token: 0x0200049F RID: 1183
		internal enum Operation
		{
			// Token: 0x040014DB RID: 5339
			None,
			// Token: 0x040014DC RID: 5340
			Add,
			// Token: 0x040014DD RID: 5341
			Take
		}

		// Token: 0x020004A0 RID: 1184
		[Serializable]
		private sealed class Enumerator : IEnumerator<!0>, IDisposable, IEnumerator
		{
			// Token: 0x06002603 RID: 9731 RVA: 0x00085607 File Offset: 0x00083807
			public Enumerator(T[] array)
			{
				this._array = array;
			}

			// Token: 0x06002604 RID: 9732 RVA: 0x00085618 File Offset: 0x00083818
			public bool MoveNext()
			{
				if (this._index < this._array.Length)
				{
					T[] array = this._array;
					int index = this._index;
					this._index = index + 1;
					this._current = array[index];
					return true;
				}
				this._index = this._array.Length + 1;
				return false;
			}

			// Token: 0x170007A5 RID: 1957
			// (get) Token: 0x06002605 RID: 9733 RVA: 0x0008566A File Offset: 0x0008386A
			public T Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x170007A6 RID: 1958
			// (get) Token: 0x06002606 RID: 9734 RVA: 0x00085672 File Offset: 0x00083872
			object IEnumerator.Current
			{
				get
				{
					if (this._index == 0 || this._index == this._array.Length + 1)
					{
						throw new InvalidOperationException("Enumeration has either not started or has already finished.");
					}
					return this.Current;
				}
			}

			// Token: 0x06002607 RID: 9735 RVA: 0x000856A4 File Offset: 0x000838A4
			public void Reset()
			{
				this._index = 0;
				this._current = default(T);
			}

			// Token: 0x06002608 RID: 9736 RVA: 0x00003917 File Offset: 0x00001B17
			public void Dispose()
			{
			}

			// Token: 0x040014DE RID: 5342
			private readonly T[] _array;

			// Token: 0x040014DF RID: 5343
			private T _current;

			// Token: 0x040014E0 RID: 5344
			private int _index;
		}
	}
}
