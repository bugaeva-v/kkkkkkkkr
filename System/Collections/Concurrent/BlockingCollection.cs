using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace System.Collections.Concurrent
{
	/// <summary>Предоставляет возможности блокировки и ограничения для потокобезопасных коллекций, реализующих <see cref="T:System.Collections.Concurrent.IProducerConsumerCollection`1" />.</summary>
	/// <typeparam name="T">Тип элементов в коллекции.</typeparam>
	// Token: 0x02000499 RID: 1177
	[DebuggerDisplay("Count = {Count}, Type = {_collection}")]
	[DebuggerTypeProxy(typeof(BlockingCollectionDebugView<>))]
	public class BlockingCollection<T> : IEnumerable<!0>, IEnumerable, ICollection, IDisposable, IReadOnlyCollection<T>
	{
		/// <summary>Получает предельную емкость данного экземпляра <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</summary>
		/// <returns>Предельная емкость данной коллекции или значение int.MaxValue, если предельное значение не указано.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> удален.</exception>
		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06002592 RID: 9618 RVA: 0x00083942 File Offset: 0x00081B42
		public int BoundedCapacity
		{
			get
			{
				this.CheckDisposed();
				return this._boundedCapacity;
			}
		}

		/// <summary>Возвращает значение, указывающее, помечена ли данная коллекция <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> как закрытая для добавления элементов.</summary>
		/// <returns>Значение, указывающее, помечена ли коллекция как закрытая для добавления.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> удален.</exception>
		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06002593 RID: 9619 RVA: 0x00083950 File Offset: 0x00081B50
		public bool IsAddingCompleted
		{
			get
			{
				this.CheckDisposed();
				return this._currentAdders == int.MinValue;
			}
		}

		/// <summary>Возвращает значение, указывающее, помечена ли данная коллекция <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> как закрытая для добавления элементов и является ли она пустой.</summary>
		/// <returns>Значение, указывающее, помечена ли данная коллекция как закрытая для добавления элементов и является ли она пустой.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> удален.</exception>
		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06002594 RID: 9620 RVA: 0x00083967 File Offset: 0x00081B67
		public bool IsCompleted
		{
			get
			{
				this.CheckDisposed();
				return this.IsAddingCompleted && this._occupiedNodes.CurrentCount == 0;
			}
		}

		/// <summary>Возвращает число элементов, содержащихся в списке <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</summary>
		/// <returns>Количество элементов, содержащихся в коллекции <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> удален.</exception>
		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06002595 RID: 9621 RVA: 0x00083987 File Offset: 0x00081B87
		public int Count
		{
			get
			{
				this.CheckDisposed();
				return this._occupiedNodes.CurrentCount;
			}
		}

		/// <summary>Возвращает значение, показывающее, является ли доступ к коллекции <see cref="T:System.Collections.ICollection" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>Всегда возвращает <see langword="false" /> укажите права доступа не синхронизированы.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> удален.</exception>
		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06002596 RID: 9622 RVA: 0x0008399A File Offset: 0x00081B9A
		bool ICollection.IsSynchronized
		{
			get
			{
				this.CheckDisposed();
				return false;
			}
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.ICollection" />. Данное свойство не поддерживается.</summary>
		/// <returns>Возвращает значение null.</returns>
		/// <exception cref="T:System.NotSupportedException">Свойство SyncRoot не поддерживается.</exception>
		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06002597 RID: 9623 RVA: 0x000839A3 File Offset: 0x00081BA3
		object ICollection.SyncRoot
		{
			get
			{
				throw new NotSupportedException("The SyncRoot property may not be used for the synchronization of concurrent collections.");
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> без верхней границы.</summary>
		// Token: 0x06002598 RID: 9624 RVA: 0x000839AF File Offset: 0x00081BAF
		public BlockingCollection() : this(new ConcurrentQueue<T>())
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> с указанной верхней границей.</summary>
		/// <param name="boundedCapacity">Предельный размер коллекции.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="boundedCapacity" /> не является положительным значением.</exception>
		// Token: 0x06002599 RID: 9625 RVA: 0x000839BC File Offset: 0x00081BBC
		public BlockingCollection(int boundedCapacity) : this(new ConcurrentQueue<T>(), boundedCapacity)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> с указанной верхней границей, используя предоставленную коллекцию <see cref="T:System.Collections.Concurrent.IProducerConsumerCollection`1" /> в качестве базового хранилища данных.</summary>
		/// <param name="collection">Коллекция, используемая в качестве базового хранилища данных.</param>
		/// <param name="boundedCapacity">Предельный размер коллекции.</param>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="collection" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="boundedCapacity" /> не является положительным значением.</exception>
		/// <exception cref="T:System.ArgumentException">Предоставленный <paramref name="collection" /> содержит больше значений, чем разрешается <paramref name="boundedCapacity" />.</exception>
		// Token: 0x0600259A RID: 9626 RVA: 0x000839CC File Offset: 0x00081BCC
		public BlockingCollection(IProducerConsumerCollection<T> collection, int boundedCapacity)
		{
			if (boundedCapacity < 1)
			{
				throw new ArgumentOutOfRangeException("boundedCapacity", boundedCapacity, "The boundedCapacity argument must be positive.");
			}
			if (collection == null)
			{
				throw new ArgumentNullException("collection");
			}
			int count = collection.Count;
			if (count > boundedCapacity)
			{
				throw new ArgumentException("The collection argument contains more items than are allowed by the boundedCapacity.");
			}
			this.Initialize(collection, boundedCapacity, count);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> без верхней границы, используя предоставленную коллекцию <see cref="T:System.Collections.Concurrent.IProducerConsumerCollection`1" /> в качестве базового хранилища данных.</summary>
		/// <param name="collection">Коллекция, используемая в качестве базового хранилища данных.</param>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="collection" /> имеет значение NULL.</exception>
		// Token: 0x0600259B RID: 9627 RVA: 0x00083A26 File Offset: 0x00081C26
		public BlockingCollection(IProducerConsumerCollection<T> collection)
		{
			if (collection == null)
			{
				throw new ArgumentNullException("collection");
			}
			this.Initialize(collection, -1, collection.Count);
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x00083A4C File Offset: 0x00081C4C
		private void Initialize(IProducerConsumerCollection<T> collection, int boundedCapacity, int collectionCount)
		{
			this._collection = collection;
			this._boundedCapacity = boundedCapacity;
			this._isDisposed = false;
			this._consumersCancellationTokenSource = new CancellationTokenSource();
			this._producersCancellationTokenSource = new CancellationTokenSource();
			if (boundedCapacity == -1)
			{
				this._freeNodes = null;
			}
			else
			{
				this._freeNodes = new SemaphoreSlim(boundedCapacity - collectionCount);
			}
			this._occupiedNodes = new SemaphoreSlim(collectionCount);
		}

		/// <summary>Добавляет элемент в коллекцию <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</summary>
		/// <param name="item">Элемент, добавляемый в коллекцию. Это значение может быть пустой ссылкой.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Коллекция <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> была помечена как завершенная в отношении добавлений.  
		/// -или- 
		/// Указанная коллекция не принимает такой элемент.</exception>
		// Token: 0x0600259D RID: 9629 RVA: 0x00083AAC File Offset: 0x00081CAC
		public void Add(T item)
		{
			this.TryAddWithNoTimeValidation(item, -1, default(CancellationToken));
		}

		/// <summary>Добавляет элемент в коллекцию <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</summary>
		/// <param name="item">Элемент, добавляемый в коллекцию. Это значение может быть пустой ссылкой.</param>
		/// <param name="cancellationToken">Маркер отмены, который следует контролировать.</param>
		/// <exception cref="T:System.OperationCanceledException">Если <see cref="T:System.Threading.CancellationToken" /> отменяется.</exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///   <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> был удален, или был удален <see cref="T:System.Threading.CancellationTokenSource" />, которому принадлежит <paramref name="cancellationToken" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Коллекция <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> была помечена как завершенная в отношении добавлений.  
		/// -или- 
		/// Указанная коллекция не принимает такой элемент.</exception>
		// Token: 0x0600259E RID: 9630 RVA: 0x00083ACB File Offset: 0x00081CCB
		public void Add(T item, CancellationToken cancellationToken)
		{
			this.TryAddWithNoTimeValidation(item, -1, cancellationToken);
		}

		/// <summary>Пытается добавить указанный элемент в <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</summary>
		/// <param name="item">Элемент, добавляемый в коллекцию.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="item" /> удалось добавить; в противном случае — значение <see langword="false" />. Если элемент является дубликатом, а соответствующая коллекция не поддерживает повторяющиеся элементы, создается исключение <see cref="T:System.InvalidOperationException" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Коллекция <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> была помечена как завершенная в отношении добавлений.  
		/// -или- 
		/// Указанная коллекция не принимает такой элемент.</exception>
		// Token: 0x0600259F RID: 9631 RVA: 0x00083AD8 File Offset: 0x00081CD8
		public bool TryAdd(T item)
		{
			return this.TryAddWithNoTimeValidation(item, 0, default(CancellationToken));
		}

		/// <summary>Пытается добавить указанный элемент в <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</summary>
		/// <param name="item">Элемент, добавляемый в коллекцию.</param>
		/// <param name="timeout">Период <see cref="T:System.TimeSpan" />, представляющий время ожидания в миллисекундах, или период <see cref="T:System.TimeSpan" />, представляющий -1 миллисекунду для неограниченного ожидания.</param>
		/// <returns>Значение true, если элемент <paramref name="item" /> удалось добавить в коллекцию в течение указанного интервала времени; в противном случае — значение false.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="timeout" /> является отрицательным числом, отличным от значения -1 миллисекунда, которое представляет неограниченное время ожидания, либо время ожидания превышает <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Коллекция <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> была помечена как завершенная в отношении добавлений.  
		/// -или- 
		/// Указанная коллекция не принимает такой элемент.</exception>
		// Token: 0x060025A0 RID: 9632 RVA: 0x00083AF8 File Offset: 0x00081CF8
		public bool TryAdd(T item, TimeSpan timeout)
		{
			BlockingCollection<T>.ValidateTimeout(timeout);
			return this.TryAddWithNoTimeValidation(item, (int)timeout.TotalMilliseconds, default(CancellationToken));
		}

		/// <summary>Пытается добавить указанный элемент в коллекцию <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> в течение указанного периода времени.</summary>
		/// <param name="item">Элемент, добавляемый в коллекцию.</param>
		/// <param name="millisecondsTimeout">Время ожидания в миллисекундах или функция <see cref="F:System.Threading.Timeout.Infinite" /> (-1) в случае неограниченного времени ожидания.</param>
		/// <returns>Значение true, если элемент <paramref name="item" /> удалось добавить в коллекцию в течение указанного времени; в противном случае — значение false. Если элемент является дубликатом, а соответствующая коллекция не поддерживает повторяющиеся элементы, создается исключение <see cref="T:System.InvalidOperationException" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от –1, что означает бесконечное время ожидания.</exception>
		/// <exception cref="T:System.InvalidOperationException">Коллекция <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> была помечена как завершенная в отношении добавлений.  
		///
		/// или - 
		/// Указанная коллекция не принимает такой элемент.</exception>
		// Token: 0x060025A1 RID: 9633 RVA: 0x00083B24 File Offset: 0x00081D24
		public bool TryAdd(T item, int millisecondsTimeout)
		{
			BlockingCollection<T>.ValidateMillisecondsTimeout(millisecondsTimeout);
			return this.TryAddWithNoTimeValidation(item, millisecondsTimeout, default(CancellationToken));
		}

		/// <summary>Пытается добавить указанный элемент в коллекцию <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> в течение указанного периода времени, контролируя маркер отмены.</summary>
		/// <param name="item">Элемент, добавляемый в коллекцию.</param>
		/// <param name="millisecondsTimeout">Время ожидания в миллисекундах или функция <see cref="F:System.Threading.Timeout.Infinite" /> (-1) в случае неограниченного времени ожидания.</param>
		/// <param name="cancellationToken">Маркер отмены, который следует контролировать.</param>
		/// <returns>Значение true, если элемент <paramref name="item" /> удалось добавить в коллекцию в течение указанного времени; в противном случае — значение false. Если элемент является дубликатом, а соответствующая коллекция не поддерживает повторяющиеся элементы, создается исключение <see cref="T:System.InvalidOperationException" />.</returns>
		/// <exception cref="T:System.OperationCanceledException">Если <see cref="T:System.Threading.CancellationToken" /> отменяется.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> был удален или базовый объект <see cref="T:System.Threading.CancellationTokenSource" /> был удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от –1, что означает бесконечное время ожидания.</exception>
		/// <exception cref="T:System.InvalidOperationException">Коллекция <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> была помечена как завершенная в отношении добавлений.  
		///
		/// или - 
		/// Указанная коллекция не принимает такой элемент.</exception>
		// Token: 0x060025A2 RID: 9634 RVA: 0x00083B48 File Offset: 0x00081D48
		public bool TryAdd(T item, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			BlockingCollection<T>.ValidateMillisecondsTimeout(millisecondsTimeout);
			return this.TryAddWithNoTimeValidation(item, millisecondsTimeout, cancellationToken);
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x00083B5C File Offset: 0x00081D5C
		private bool TryAddWithNoTimeValidation(T item, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			this.CheckDisposed();
			if (cancellationToken.IsCancellationRequested)
			{
				throw new OperationCanceledException("The operation was canceled.", cancellationToken);
			}
			if (this.IsAddingCompleted)
			{
				throw new InvalidOperationException("The collection has been marked as complete with regards to additions.");
			}
			bool flag = true;
			if (this._freeNodes != null)
			{
				CancellationTokenSource cancellationTokenSource = null;
				try
				{
					flag = this._freeNodes.Wait(0);
					if (!flag && millisecondsTimeout != 0)
					{
						cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, this._producersCancellationTokenSource.Token);
						flag = this._freeNodes.Wait(millisecondsTimeout, cancellationTokenSource.Token);
					}
				}
				catch (OperationCanceledException)
				{
					if (cancellationToken.IsCancellationRequested)
					{
						throw new OperationCanceledException("The operation was canceled.", cancellationToken);
					}
					throw new InvalidOperationException("CompleteAdding may not be used concurrently with additions to the collection.");
				}
				finally
				{
					if (cancellationTokenSource != null)
					{
						cancellationTokenSource.Dispose();
					}
				}
			}
			if (flag)
			{
				SpinWait spinWait = default(SpinWait);
				for (;;)
				{
					int currentAdders = this._currentAdders;
					if ((currentAdders & -2147483648) != 0)
					{
						break;
					}
					if (Interlocked.CompareExchange(ref this._currentAdders, currentAdders + 1, currentAdders) == currentAdders)
					{
						goto IL_104;
					}
					spinWait.SpinOnce();
				}
				spinWait.Reset();
				while (this._currentAdders != -2147483648)
				{
					spinWait.SpinOnce();
				}
				throw new InvalidOperationException("The collection has been marked as complete with regards to additions.");
				IL_104:
				try
				{
					bool flag2 = false;
					try
					{
						cancellationToken.ThrowIfCancellationRequested();
						flag2 = this._collection.TryAdd(item);
					}
					catch
					{
						if (this._freeNodes != null)
						{
							this._freeNodes.Release();
						}
						throw;
					}
					if (!flag2)
					{
						throw new InvalidOperationException("The underlying collection didn't accept the item.");
					}
					this._occupiedNodes.Release();
				}
				finally
				{
					Interlocked.Decrement(ref this._currentAdders);
				}
			}
			return flag;
		}

		/// <summary>Удаляет элемент из <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</summary>
		/// <returns>Элемент, удаленный из коллекции.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Базовая коллекция была изменена за пределами данного экземпляра <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> или коллекция <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> пуста и помечена как полная и более недоступная для добавления объектов.</exception>
		// Token: 0x060025A4 RID: 9636 RVA: 0x00083D00 File Offset: 0x00081F00
		public T Take()
		{
			T result;
			if (!this.TryTake(out result, -1, CancellationToken.None))
			{
				throw new InvalidOperationException("The collection argument is empty and has been marked as complete with regards to additions.");
			}
			return result;
		}

		/// <summary>Удаляет элемент из <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</summary>
		/// <param name="cancellationToken">Объект, который можно использовать для отмены операции извлечения.</param>
		/// <returns>Элемент, удаленный из коллекции.</returns>
		/// <exception cref="T:System.OperationCanceledException">
		///   <see cref="T:System.Threading.CancellationToken" /> отменен.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Был удален <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> или отменен создавший маркер объект <see cref="T:System.Threading.CancellationTokenSource" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Базовая коллекция была изменена за пределами данного экземпляра <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />, или коллекция BlockingCollection помечена как закрытая для добавления, или коллекция <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> пуста.</exception>
		// Token: 0x060025A5 RID: 9637 RVA: 0x00083D2C File Offset: 0x00081F2C
		public T Take(CancellationToken cancellationToken)
		{
			T result;
			if (!this.TryTake(out result, -1, cancellationToken))
			{
				throw new InvalidOperationException("The collection argument is empty and has been marked as complete with regards to additions.");
			}
			return result;
		}

		/// <summary>Пытается удалить элемент из коллекции <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</summary>
		/// <param name="item">Элемент, который необходимо удалить из коллекции.</param>
		/// <returns>Значение <see langword="true" />, если элемент удалось удалить; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> удален.</exception>
		/// <exception cref="T:System.InvalidOperationException">Базовая коллекция была изменена за пределами этого экземпляра <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</exception>
		// Token: 0x060025A6 RID: 9638 RVA: 0x00083D51 File Offset: 0x00081F51
		public bool TryTake(out T item)
		{
			return this.TryTake(out item, 0, CancellationToken.None);
		}

		/// <summary>Пытается удалить элемент из коллекции <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> в течение указанного периода времени.</summary>
		/// <param name="item">Элемент, который необходимо удалить из коллекции.</param>
		/// <param name="timeout">Объект, представляющий время ожидания в миллисекундах, или объект, представляющий -1 миллисекунду для неограниченного ожидания.</param>
		/// <returns>Значение <see langword="true" />, если элемент удалось удалить из коллекции в течение указанного времени; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="timeout" /> является отрицательным числом, отличным от -1 миллисекунды, которое представляет неограниченное время ожидания. 
		///
		/// или - 
		/// Значение <paramref name="timeout" /> больше значения <see cref="F:System.Int32.MaxValue" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Базовая коллекция была изменена за пределами этого экземпляра <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</exception>
		// Token: 0x060025A7 RID: 9639 RVA: 0x00083D60 File Offset: 0x00081F60
		public bool TryTake(out T item, TimeSpan timeout)
		{
			BlockingCollection<T>.ValidateTimeout(timeout);
			return this.TryTakeWithNoTimeValidation(out item, (int)timeout.TotalMilliseconds, CancellationToken.None, null);
		}

		/// <summary>Пытается удалить элемент из коллекции <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> в течение указанного периода времени.</summary>
		/// <param name="item">Элемент, который необходимо удалить из коллекции.</param>
		/// <param name="millisecondsTimeout">Время ожидания в миллисекундах или функция <see cref="F:System.Threading.Timeout.Infinite" /> (-1) в случае неограниченного времени ожидания.</param>
		/// <returns>Значение <see langword="true" />, если элемент удалось удалить из коллекции в течение указанного времени; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от –1, что означает бесконечное время ожидания.</exception>
		/// <exception cref="T:System.InvalidOperationException">Базовая коллекция была изменена за пределами этого экземпляра <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</exception>
		// Token: 0x060025A8 RID: 9640 RVA: 0x00083D7D File Offset: 0x00081F7D
		public bool TryTake(out T item, int millisecondsTimeout)
		{
			BlockingCollection<T>.ValidateMillisecondsTimeout(millisecondsTimeout);
			return this.TryTakeWithNoTimeValidation(out item, millisecondsTimeout, CancellationToken.None, null);
		}

		/// <summary>Пытается удалить элемент из коллекции <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> в течение указанного периода времени, контролируя маркер отмены.</summary>
		/// <param name="item">Элемент, который необходимо удалить из коллекции.</param>
		/// <param name="millisecondsTimeout">Время ожидания в миллисекундах или <see cref="F:System.Threading.Timeout.Infinite" /> (-1) для неограниченного времени ожидания.</param>
		/// <param name="cancellationToken">Маркер отмены, который следует контролировать.</param>
		/// <returns>Значение <see langword="true" />, если элемент удалось удалить из коллекции в течение указанного времени; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.OperationCanceledException">
		///   <see cref="T:System.Threading.CancellationToken" /> был отменен.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> был удален или базовый объект <see cref="T:System.Threading.CancellationTokenSource" /> был удален.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от –1, что означает бесконечное время ожидания.</exception>
		/// <exception cref="T:System.InvalidOperationException">Базовая коллекция была изменена за пределами этого экземпляра <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</exception>
		// Token: 0x060025A9 RID: 9641 RVA: 0x00083D93 File Offset: 0x00081F93
		public bool TryTake(out T item, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			BlockingCollection<T>.ValidateMillisecondsTimeout(millisecondsTimeout);
			return this.TryTakeWithNoTimeValidation(out item, millisecondsTimeout, cancellationToken, null);
		}

		// Token: 0x060025AA RID: 9642 RVA: 0x00083DA8 File Offset: 0x00081FA8
		private bool TryTakeWithNoTimeValidation(out T item, int millisecondsTimeout, CancellationToken cancellationToken, CancellationTokenSource combinedTokenSource)
		{
			this.CheckDisposed();
			item = default(T);
			if (cancellationToken.IsCancellationRequested)
			{
				throw new OperationCanceledException("The operation was canceled.", cancellationToken);
			}
			if (this.IsCompleted)
			{
				return false;
			}
			bool flag = false;
			CancellationTokenSource cancellationTokenSource = combinedTokenSource;
			try
			{
				flag = this._occupiedNodes.Wait(0);
				if (!flag && millisecondsTimeout != 0)
				{
					if (combinedTokenSource == null)
					{
						cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, this._consumersCancellationTokenSource.Token);
					}
					flag = this._occupiedNodes.Wait(millisecondsTimeout, cancellationTokenSource.Token);
				}
			}
			catch (OperationCanceledException)
			{
				if (cancellationToken.IsCancellationRequested)
				{
					throw new OperationCanceledException("The operation was canceled.", cancellationToken);
				}
				return false;
			}
			finally
			{
				if (cancellationTokenSource != null && combinedTokenSource == null)
				{
					cancellationTokenSource.Dispose();
				}
			}
			if (flag)
			{
				bool flag2 = false;
				bool flag3 = true;
				try
				{
					cancellationToken.ThrowIfCancellationRequested();
					flag2 = this._collection.TryTake(out item);
					flag3 = false;
					if (!flag2)
					{
						throw new InvalidOperationException("The underlying collection was modified from outside of the BlockingCollection<T>.");
					}
				}
				finally
				{
					if (flag2)
					{
						if (this._freeNodes != null)
						{
							this._freeNodes.Release();
						}
					}
					else if (flag3)
					{
						this._occupiedNodes.Release();
					}
					if (this.IsCompleted)
					{
						this.CancelWaitingConsumers();
					}
				}
			}
			return flag;
		}

		/// <summary>Добавляет указанный элемент в один из указанных экземпляров <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</summary>
		/// <param name="collections">Массив коллекций.</param>
		/// <param name="item">Элемент, добавляемый в одну из коллекций.</param>
		/// <returns>Индекс коллекции в массиве <paramref name="collections" />, в которую добавляется элемент.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Хотя бы один из экземпляров <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> был удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="collections" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Число <paramref name="collections" /> больше, чем максимальный размер (62 для STA и 63 для MTA).</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="collections" /> аргумент является массивом длины 0, содержит элемент null или хотя бы одна коллекция была помечена как готовая для добавления.</exception>
		/// <exception cref="T:System.InvalidOperationException">Хотя бы одна базовая коллекция не приняла элемент.</exception>
		// Token: 0x060025AB RID: 9643 RVA: 0x00083EE0 File Offset: 0x000820E0
		public static int AddToAny(BlockingCollection<T>[] collections, T item)
		{
			return BlockingCollection<T>.TryAddToAny(collections, item, -1, CancellationToken.None);
		}

		/// <summary>Добавляет указанный элемент в один из указанных экземпляров <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</summary>
		/// <param name="collections">Массив коллекций.</param>
		/// <param name="item">Элемент, добавляемый в одну из коллекций.</param>
		/// <param name="cancellationToken">Маркер отмены, который следует контролировать.</param>
		/// <returns>Индекс коллекции в массиве <paramref name="collections" />, в которую добавляется элемент.</returns>
		/// <exception cref="T:System.OperationCanceledException">Если <see cref="T:System.Threading.CancellationToken" /> отменяется.</exception>
		/// <exception cref="T:System.InvalidOperationException">Хотя бы одна базовая коллекция не приняла элемент.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="collections" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Число <paramref name="collections" /> больше, чем максимальный размер (62 для STA и 63 для MTA).</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="collections" /> аргумент является массивом длины 0, содержит элемент null или хотя бы одна коллекция была помечена как готовая для добавления.</exception>
		/// <exception cref="T:System.ObjectDisposedException">По крайней мере один из экземпляров <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> был удален или <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />, был удален.</exception>
		// Token: 0x060025AC RID: 9644 RVA: 0x00083EEF File Offset: 0x000820EF
		public static int AddToAny(BlockingCollection<T>[] collections, T item, CancellationToken cancellationToken)
		{
			return BlockingCollection<T>.TryAddToAny(collections, item, -1, cancellationToken);
		}

		/// <summary>Пытается добавить указанный элемент в один из указанных экземпляров <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</summary>
		/// <param name="collections">Массив коллекций.</param>
		/// <param name="item">Элемент, добавляемый в одну из коллекций.</param>
		/// <returns>Индекс коллекции, в которую был добавлен элемент, в массиве <paramref name="collections" />, или -1, если добавить элемент не удалось.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Хотя бы один из экземпляров <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> был удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="collections" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Число <paramref name="collections" /> больше, чем максимальный размер (62 для STA и 63 для MTA).</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="collections" /> аргумент является массивом длины 0, содержит элемент null или хотя бы одна коллекция была помечена как готовая для добавления.</exception>
		/// <exception cref="T:System.InvalidOperationException">Хотя бы одна базовая коллекция не приняла элемент.</exception>
		// Token: 0x060025AD RID: 9645 RVA: 0x00083EFA File Offset: 0x000820FA
		public static int TryAddToAny(BlockingCollection<T>[] collections, T item)
		{
			return BlockingCollection<T>.TryAddToAny(collections, item, 0, CancellationToken.None);
		}

		/// <summary>Пытается добавить указанный элемент в любой из указанных экземпляров <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />, контролируя указанный маркер отмены.</summary>
		/// <param name="collections">Массив коллекций.</param>
		/// <param name="item">Элемент, добавляемый в одну из коллекций.</param>
		/// <param name="timeout">Период <see cref="T:System.TimeSpan" />, представляющий время ожидания в миллисекундах, или период <see cref="T:System.TimeSpan" />, представляющий -1 миллисекунду для неограниченного ожидания.</param>
		/// <returns>Индекс коллекции, в которую был добавлен элемент, в массиве <paramref name="collections" />, или -1, если добавить элемент не удалось.</returns>
		/// <exception cref="T:System.ObjectDisposedException">По крайней мере один из экземпляров <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> или <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" /> был удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="collections" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="timeout" /> является отрицательным числом, отличным от значения -1 миллисекунда, которое представляет неограниченное время ожидания, либо время ожидания превышает <see cref="F:System.Int32.MaxValue" />.  
		/// -или- 
		/// Число <paramref name="collections" /> больше, чем максимальный размер (62 для STA и 63 для MTA).</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="collections" /> аргумент является массивом длины 0, содержит элемент null или хотя бы одна коллекция была помечена как готовая для добавления.</exception>
		/// <exception cref="T:System.InvalidOperationException">Хотя бы одна базовая коллекция не приняла элемент.</exception>
		// Token: 0x060025AE RID: 9646 RVA: 0x00083F09 File Offset: 0x00082109
		public static int TryAddToAny(BlockingCollection<T>[] collections, T item, TimeSpan timeout)
		{
			BlockingCollection<T>.ValidateTimeout(timeout);
			return BlockingCollection<T>.TryAddToAnyCore(collections, item, (int)timeout.TotalMilliseconds, CancellationToken.None);
		}

		/// <summary>Пытается добавить указанный элемент в один из указанных экземпляров <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</summary>
		/// <param name="collections">Массив коллекций.</param>
		/// <param name="item">Элемент, добавляемый в одну из коллекций.</param>
		/// <param name="millisecondsTimeout">Время ожидания в миллисекундах или функция <see cref="F:System.Threading.Timeout.Infinite" /> (-1) в случае неограниченного времени ожидания.</param>
		/// <returns>Индекс коллекции, в которую был добавлен элемент, в массиве <paramref name="collections" />, или -1, если добавить элемент не удалось.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Хотя бы один из экземпляров <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> был удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="collections" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от –1, что означает бесконечное время ожидания. 
		/// -или- 
		/// Число <paramref name="collections" /> больше, чем максимальный размер (62 для STA и 63 для MTA).</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="collections" /> аргумент является массивом длины 0, содержит элемент null или хотя бы одна коллекция была помечена как готовая для добавления.</exception>
		/// <exception cref="T:System.InvalidOperationException">Хотя бы одна базовая коллекция не приняла элемент.</exception>
		// Token: 0x060025AF RID: 9647 RVA: 0x00083F25 File Offset: 0x00082125
		public static int TryAddToAny(BlockingCollection<T>[] collections, T item, int millisecondsTimeout)
		{
			BlockingCollection<T>.ValidateMillisecondsTimeout(millisecondsTimeout);
			return BlockingCollection<T>.TryAddToAnyCore(collections, item, millisecondsTimeout, CancellationToken.None);
		}

		/// <summary>Пытается добавить указанный элемент в один из указанных экземпляров <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</summary>
		/// <param name="collections">Массив коллекций.</param>
		/// <param name="item">Элемент, добавляемый в одну из коллекций.</param>
		/// <param name="millisecondsTimeout">Время ожидания в миллисекундах или функция <see cref="F:System.Threading.Timeout.Infinite" /> (-1) в случае неограниченного времени ожидания.</param>
		/// <param name="cancellationToken">Маркер отмены, который следует контролировать.</param>
		/// <returns>Индекс коллекции, в которую был добавлен элемент, в массиве <paramref name="collections" />, или -1, если добавить элемент не удалось.</returns>
		/// <exception cref="T:System.OperationCanceledException">Если <see cref="T:System.Threading.CancellationToken" /> отменяется.</exception>
		/// <exception cref="T:System.InvalidOperationException">Хотя бы одна базовая коллекция не приняла элемент.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="collections" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от –1, что означает бесконечное время ожидания. 
		/// -или- 
		/// Число <paramref name="collections" /> больше, чем максимальный размер (62 для STA и 63 для MTA).</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="collections" /> аргумент является массивом длины 0, содержит элемент null или хотя бы одна коллекция была помечена как готовая для добавления.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Хотя бы один из экземпляров <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> был удален.</exception>
		// Token: 0x060025B0 RID: 9648 RVA: 0x00083F3A File Offset: 0x0008213A
		public static int TryAddToAny(BlockingCollection<T>[] collections, T item, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			BlockingCollection<T>.ValidateMillisecondsTimeout(millisecondsTimeout);
			return BlockingCollection<T>.TryAddToAnyCore(collections, item, millisecondsTimeout, cancellationToken);
		}

		// Token: 0x060025B1 RID: 9649 RVA: 0x00083F4C File Offset: 0x0008214C
		private static int TryAddToAnyCore(BlockingCollection<T>[] collections, T item, int millisecondsTimeout, CancellationToken externalCancellationToken)
		{
			BlockingCollection<T>.ValidateCollectionsArray(collections, true);
			int num = millisecondsTimeout;
			uint startTime = 0U;
			if (millisecondsTimeout != -1)
			{
				startTime = (uint)Environment.TickCount;
			}
			int num2 = BlockingCollection<T>.TryAddToAnyFast(collections, item);
			if (num2 > -1)
			{
				return num2;
			}
			CancellationToken[] tokens;
			List<WaitHandle> handles = BlockingCollection<T>.GetHandles(collections, externalCancellationToken, true, out tokens);
			while (millisecondsTimeout == -1 || num >= 0)
			{
				num2 = -1;
				using (CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(tokens))
				{
					handles.Add(cancellationTokenSource.Token.WaitHandle);
					num2 = WaitHandle.WaitAny(handles.ToArray(), num);
					handles.RemoveAt(handles.Count - 1);
					if (cancellationTokenSource.IsCancellationRequested)
					{
						if (externalCancellationToken.IsCancellationRequested)
						{
							throw new OperationCanceledException("The operation was canceled.", externalCancellationToken);
						}
						throw new ArgumentException("At least one of the specified collections is marked as complete with regards to additions.", "collections");
					}
				}
				if (num2 == 258)
				{
					return -1;
				}
				if (collections[num2].TryAdd(item))
				{
					return num2;
				}
				if (millisecondsTimeout != -1)
				{
					num = BlockingCollection<T>.UpdateTimeOut(startTime, millisecondsTimeout);
				}
			}
			return -1;
		}

		// Token: 0x060025B2 RID: 9650 RVA: 0x0008404C File Offset: 0x0008224C
		private static int TryAddToAnyFast(BlockingCollection<T>[] collections, T item)
		{
			for (int i = 0; i < collections.Length; i++)
			{
				if (collections[i]._freeNodes == null)
				{
					collections[i].TryAdd(item);
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x00084080 File Offset: 0x00082280
		private static List<WaitHandle> GetHandles(BlockingCollection<T>[] collections, CancellationToken externalCancellationToken, bool isAddOperation, out CancellationToken[] cancellationTokens)
		{
			List<WaitHandle> list = new List<WaitHandle>(collections.Length + 1);
			List<CancellationToken> list2 = new List<CancellationToken>(collections.Length + 1);
			list2.Add(externalCancellationToken);
			if (isAddOperation)
			{
				for (int i = 0; i < collections.Length; i++)
				{
					if (collections[i]._freeNodes != null)
					{
						list.Add(collections[i]._freeNodes.AvailableWaitHandle);
						list2.Add(collections[i]._producersCancellationTokenSource.Token);
					}
				}
			}
			else
			{
				for (int j = 0; j < collections.Length; j++)
				{
					if (!collections[j].IsCompleted)
					{
						list.Add(collections[j]._occupiedNodes.AvailableWaitHandle);
						list2.Add(collections[j]._consumersCancellationTokenSource.Token);
					}
				}
			}
			cancellationTokens = list2.ToArray();
			return list;
		}

		// Token: 0x060025B4 RID: 9652 RVA: 0x00084134 File Offset: 0x00082334
		private static int UpdateTimeOut(uint startTime, int originalWaitMillisecondsTimeout)
		{
			if (originalWaitMillisecondsTimeout == 0)
			{
				return 0;
			}
			uint num = (uint)(Environment.TickCount - (int)startTime);
			if (num > 2147483647U)
			{
				return 0;
			}
			int num2 = originalWaitMillisecondsTimeout - (int)num;
			if (num2 <= 0)
			{
				return 0;
			}
			return num2;
		}

		/// <summary>Извлекает элемент из любого из указанных экземпляров <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</summary>
		/// <param name="collections">Массив коллекций.</param>
		/// <param name="item">Элемент, удаленный из одной из коллекций.</param>
		/// <returns>Индекс коллекции в массиве <paramref name="collections" />, из которой удален элемент.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Хотя бы один из экземпляров <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> был удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="collections" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Число <paramref name="collections" /> больше, чем максимальный размер (62 для STA и 63 для MTA).</exception>
		/// <exception cref="T:System.ArgumentException">Аргумент <paramref name="collections" /> является массивом с нулевой длиной или содержит элемент null, либо в коллекции был вызван метод<see cref="M:System.Collections.Concurrent.BlockingCollection`1.CompleteAdding" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Хотя бы одна из базовых коллекций была изменена за пределами ее экземпляра <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</exception>
		// Token: 0x060025B5 RID: 9653 RVA: 0x00084163 File Offset: 0x00082363
		public static int TakeFromAny(BlockingCollection<T>[] collections, out T item)
		{
			return BlockingCollection<T>.TakeFromAny(collections, out item, CancellationToken.None);
		}

		/// <summary>Извлекает элемент из любого из указанных экземпляров <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />, контролируя указанный маркер отмены.</summary>
		/// <param name="collections">Массив коллекций.</param>
		/// <param name="item">Элемент, удаленный из одной из коллекций.</param>
		/// <param name="cancellationToken">Маркер отмены, который следует контролировать.</param>
		/// <returns>Индекс коллекции в массиве <paramref name="collections" />, из которой удален элемент.</returns>
		/// <exception cref="T:System.OperationCanceledException">Если <see cref="T:System.Threading.CancellationToken" /> отменяется.</exception>
		/// <exception cref="T:System.InvalidOperationException">Хотя бы одна из базовых коллекций была изменена за пределами ее экземпляра <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="collections" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Число <paramref name="collections" /> больше, чем максимальный размер (62 для STA и 63 для MTA).</exception>
		/// <exception cref="T:System.ArgumentException">Аргумент <paramref name="collections" /> является массивом с нулевой длиной или содержит элемент null, либо в коллекции был вызван метод<see cref="M:System.Collections.Concurrent.BlockingCollection`1.CompleteAdding" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Хотя бы один из экземпляров <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> был удален.</exception>
		// Token: 0x060025B6 RID: 9654 RVA: 0x00084171 File Offset: 0x00082371
		public static int TakeFromAny(BlockingCollection<T>[] collections, out T item, CancellationToken cancellationToken)
		{
			return BlockingCollection<T>.TryTakeFromAnyCore(collections, out item, -1, true, cancellationToken);
		}

		/// <summary>Пытается удалить элемент из любого из указанных экземпляров <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</summary>
		/// <param name="collections">Массив коллекций.</param>
		/// <param name="item">Элемент, удаленный из одной из коллекций.</param>
		/// <returns>Индекс коллекции, из которой был удален элемент, в массиве <paramref name="collections" />, или -1, если удалить элемент не удалось.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Хотя бы один из экземпляров <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> был удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="collections" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Число <paramref name="collections" /> больше, чем максимальный размер (62 для STA и 63 для MTA).</exception>
		/// <exception cref="T:System.ArgumentException">Аргумент <paramref name="collections" /> представляет собой массив нулевой длины или содержит элемент null.</exception>
		/// <exception cref="T:System.InvalidOperationException">Хотя бы одна из базовых коллекций была изменена за пределами ее экземпляра <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</exception>
		// Token: 0x060025B7 RID: 9655 RVA: 0x0008417D File Offset: 0x0008237D
		public static int TryTakeFromAny(BlockingCollection<T>[] collections, out T item)
		{
			return BlockingCollection<T>.TryTakeFromAny(collections, out item, 0);
		}

		/// <summary>Пытается удалить элемент из любого из указанных экземпляров <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</summary>
		/// <param name="collections">Массив коллекций.</param>
		/// <param name="item">Элемент, удаленный из одной из коллекций.</param>
		/// <param name="timeout">Период <see cref="T:System.TimeSpan" />, представляющий время ожидания в миллисекундах, или период <see cref="T:System.TimeSpan" />, представляющий -1 миллисекунду для неограниченного ожидания.</param>
		/// <returns>Индекс коллекции, из которой был удален элемент, в массиве <paramref name="collections" />, или -1, если удалить элемент не удалось.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Хотя бы один из экземпляров <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> был удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="collections" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="timeout" /> является отрицательным числом, отличным от значения -1 миллисекунда, которое представляет неограниченное время ожидания, либо время ожидания превышает <see cref="F:System.Int32.MaxValue" />.  
		///
		/// или - 
		/// Число <paramref name="collections" /> больше, чем максимальный размер (62 для STA и 63 для MTA).</exception>
		/// <exception cref="T:System.ArgumentException">Аргумент <paramref name="collections" /> представляет собой массив нулевой длины или содержит элемент null.</exception>
		/// <exception cref="T:System.InvalidOperationException">Хотя бы одна из базовых коллекций была изменена за пределами ее экземпляра <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</exception>
		// Token: 0x060025B8 RID: 9656 RVA: 0x00084187 File Offset: 0x00082387
		public static int TryTakeFromAny(BlockingCollection<T>[] collections, out T item, TimeSpan timeout)
		{
			BlockingCollection<T>.ValidateTimeout(timeout);
			return BlockingCollection<T>.TryTakeFromAnyCore(collections, out item, (int)timeout.TotalMilliseconds, false, CancellationToken.None);
		}

		/// <summary>Пытается удалить элемент из любого из указанных экземпляров <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</summary>
		/// <param name="collections">Массив коллекций.</param>
		/// <param name="item">Элемент, удаленный из одной из коллекций.</param>
		/// <param name="millisecondsTimeout">Время ожидания в миллисекундах или функция <see cref="F:System.Threading.Timeout.Infinite" /> (-1) в случае неограниченного времени ожидания.</param>
		/// <returns>Индекс коллекции, из которой был удален элемент, в массиве <paramref name="collections" />, или -1, если удалить элемент не удалось.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Хотя бы один из экземпляров <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> был удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="collections" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от –1, что означает бесконечное время ожидания. 
		///
		/// или - 
		/// Число <paramref name="collections" /> больше, чем максимальный размер (62 для STA и 63 для MTA).</exception>
		/// <exception cref="T:System.ArgumentException">Аргумент <paramref name="collections" /> представляет собой массив нулевой длины или содержит элемент null.</exception>
		/// <exception cref="T:System.InvalidOperationException">Хотя бы одна из базовых коллекций была изменена за пределами ее экземпляра <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</exception>
		// Token: 0x060025B9 RID: 9657 RVA: 0x000841A4 File Offset: 0x000823A4
		public static int TryTakeFromAny(BlockingCollection<T>[] collections, out T item, int millisecondsTimeout)
		{
			BlockingCollection<T>.ValidateMillisecondsTimeout(millisecondsTimeout);
			return BlockingCollection<T>.TryTakeFromAnyCore(collections, out item, millisecondsTimeout, false, CancellationToken.None);
		}

		/// <summary>Пытается удалить элемент из любого из указанных экземпляров <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</summary>
		/// <param name="collections">Массив коллекций.</param>
		/// <param name="item">Элемент, удаленный из одной из коллекций.</param>
		/// <param name="millisecondsTimeout">Время ожидания в миллисекундах или функция <see cref="F:System.Threading.Timeout.Infinite" /> (-1) в случае неограниченного времени ожидания.</param>
		/// <param name="cancellationToken">Маркер отмены, который следует контролировать.</param>
		/// <returns>Индекс коллекции, из которой был удален элемент, в массиве <paramref name="collections" />, или -1, если удалить элемент не удалось.</returns>
		/// <exception cref="T:System.OperationCanceledException">Если <see cref="T:System.Threading.CancellationToken" /> отменяется.</exception>
		/// <exception cref="T:System.InvalidOperationException">Хотя бы одна из базовых коллекций была изменена за пределами ее экземпляра <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="collections" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="millisecondsTimeout" /> является отрицательным числом, отличным от –1, что означает бесконечное время ожидания. 
		/// -или- 
		/// Число <paramref name="collections" /> больше, чем максимальный размер (62 для STA и 63 для MTA).</exception>
		/// <exception cref="T:System.ArgumentException">Аргумент <paramref name="collections" /> представляет собой массив нулевой длины или содержит элемент null.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Хотя бы один из экземпляров <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> был удален.</exception>
		// Token: 0x060025BA RID: 9658 RVA: 0x000841BA File Offset: 0x000823BA
		public static int TryTakeFromAny(BlockingCollection<T>[] collections, out T item, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			BlockingCollection<T>.ValidateMillisecondsTimeout(millisecondsTimeout);
			return BlockingCollection<T>.TryTakeFromAnyCore(collections, out item, millisecondsTimeout, false, cancellationToken);
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x000841CC File Offset: 0x000823CC
		private static int TryTakeFromAnyCore(BlockingCollection<T>[] collections, out T item, int millisecondsTimeout, bool isTakeOperation, CancellationToken externalCancellationToken)
		{
			BlockingCollection<T>.ValidateCollectionsArray(collections, false);
			for (int i = 0; i < collections.Length; i++)
			{
				if (!collections[i].IsCompleted && collections[i]._occupiedNodes.CurrentCount > 0 && collections[i].TryTake(out item))
				{
					return i;
				}
			}
			return BlockingCollection<T>.TryTakeFromAnyCoreSlow(collections, out item, millisecondsTimeout, isTakeOperation, externalCancellationToken);
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x00084220 File Offset: 0x00082420
		private static int TryTakeFromAnyCoreSlow(BlockingCollection<T>[] collections, out T item, int millisecondsTimeout, bool isTakeOperation, CancellationToken externalCancellationToken)
		{
			int num = millisecondsTimeout;
			uint startTime = 0U;
			if (millisecondsTimeout != -1)
			{
				startTime = (uint)Environment.TickCount;
			}
			while (millisecondsTimeout == -1 || num >= 0)
			{
				CancellationToken[] tokens;
				List<WaitHandle> handles = BlockingCollection<T>.GetHandles(collections, externalCancellationToken, false, out tokens);
				if (handles.Count == 0 && isTakeOperation)
				{
					throw new ArgumentException("All collections are marked as complete with regards to additions.", "collections");
				}
				if (handles.Count != 0)
				{
					using (CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(tokens))
					{
						handles.Add(cancellationTokenSource.Token.WaitHandle);
						int num2 = WaitHandle.WaitAny(handles.ToArray(), num);
						if (cancellationTokenSource.IsCancellationRequested && externalCancellationToken.IsCancellationRequested)
						{
							throw new OperationCanceledException("The operation was canceled.", externalCancellationToken);
						}
						if (!cancellationTokenSource.IsCancellationRequested)
						{
							if (num2 == 258)
							{
								break;
							}
							if (collections.Length != handles.Count - 1)
							{
								for (int i = 0; i < collections.Length; i++)
								{
									if (collections[i]._occupiedNodes.AvailableWaitHandle == handles[num2])
									{
										num2 = i;
										break;
									}
								}
							}
							if (collections[num2].TryTake(out item))
							{
								return num2;
							}
						}
					}
					if (millisecondsTimeout != -1)
					{
						num = BlockingCollection<T>.UpdateTimeOut(startTime, millisecondsTimeout);
						continue;
					}
					continue;
				}
				break;
			}
			item = default(T);
			return -1;
		}

		/// <summary>Помечает экземпляры <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> как не допускающие добавления дополнительных элементов.</summary>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> удален.</exception>
		// Token: 0x060025BD RID: 9661 RVA: 0x00084368 File Offset: 0x00082568
		public void CompleteAdding()
		{
			this.CheckDisposed();
			if (this.IsAddingCompleted)
			{
				return;
			}
			SpinWait spinWait = default(SpinWait);
			for (;;)
			{
				int currentAdders = this._currentAdders;
				if ((currentAdders & -2147483648) != 0)
				{
					break;
				}
				if (Interlocked.CompareExchange(ref this._currentAdders, currentAdders | -2147483648, currentAdders) == currentAdders)
				{
					goto Block_4;
				}
				spinWait.SpinOnce();
			}
			spinWait.Reset();
			while (this._currentAdders != -2147483648)
			{
				spinWait.SpinOnce();
			}
			return;
			Block_4:
			spinWait.Reset();
			while (this._currentAdders != -2147483648)
			{
				spinWait.SpinOnce();
			}
			if (this.Count == 0)
			{
				this.CancelWaitingConsumers();
			}
			this.CancelWaitingProducers();
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x00084413 File Offset: 0x00082613
		private void CancelWaitingConsumers()
		{
			this._consumersCancellationTokenSource.Cancel();
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x00084420 File Offset: 0x00082620
		private void CancelWaitingProducers()
		{
			this._producersCancellationTokenSource.Cancel();
		}

		/// <summary>Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</summary>
		// Token: 0x060025C0 RID: 9664 RVA: 0x0008442D File Offset: 0x0008262D
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Освобождает ресурсы, используемые экземпляром <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.</summary>
		/// <param name="disposing">Значение, определяющее, выполняется ли ликвидация явно (true) или в результате выполнения метода завершения (false).</param>
		// Token: 0x060025C1 RID: 9665 RVA: 0x0008443C File Offset: 0x0008263C
		protected virtual void Dispose(bool disposing)
		{
			if (!this._isDisposed)
			{
				if (this._freeNodes != null)
				{
					this._freeNodes.Dispose();
				}
				this._occupiedNodes.Dispose();
				this._isDisposed = true;
			}
		}

		/// <summary>Копирует элементы из экземпляра <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> в новый массив.</summary>
		/// <returns>Массив, содержащий копии элементов коллекции.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> удален.</exception>
		// Token: 0x060025C2 RID: 9666 RVA: 0x0008446B File Offset: 0x0008266B
		public T[] ToArray()
		{
			this.CheckDisposed();
			return this._collection.ToArray();
		}

		/// <summary>Копирует все элементы из экземпляра <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> в совместимый одномерный массив начиная с указанного индекса в целевом массиве.</summary>
		/// <param name="array">Одномерный массив, в который копируются элементы экземпляра <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />. Индекс в массиве должен начинаться с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="array" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Аргумент <paramref name="index" /> больше или равен значению длины <paramref name="array" />.  
		/// Массив назначения слишком мал для хранения всех элементов BlockingCcollection.  
		/// Ранг массива не соответствует.  
		/// Тип массива не совместим с типом элементов BlockingCollection.</exception>
		// Token: 0x060025C3 RID: 9667 RVA: 0x000492FA File Offset: 0x000474FA
		public void CopyTo(T[] array, int index)
		{
			((ICollection)this).CopyTo(array, index);
		}

		/// <summary>Копирует все элементы из экземпляра <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> в совместимый одномерный массив начиная с указанного индекса в целевом массиве.</summary>
		/// <param name="array">Одномерный массив, в который копируются элементы экземпляра <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />. Индекс в массиве должен начинаться с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> удален.</exception>
		/// <exception cref="T:System.ArgumentNullException">Аргумент <paramref name="array" /> имеет значение NULL.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Аргумент <paramref name="index" /> меньше нуля.</exception>
		/// <exception cref="T:System.ArgumentException">Аргумент <paramref name="index" /> больше или равен значению <paramref name="array" />, массив является многомерным или параметр типа для коллекции не может быть автоматически приведен к типу массива назначения.</exception>
		// Token: 0x060025C4 RID: 9668 RVA: 0x00084480 File Offset: 0x00082680
		void ICollection.CopyTo(Array array, int index)
		{
			this.CheckDisposed();
			T[] array2 = this._collection.ToArray();
			try
			{
				Array.Copy(array2, 0, array, index, array2.Length);
			}
			catch (ArgumentNullException)
			{
				throw new ArgumentNullException("array");
			}
			catch (ArgumentOutOfRangeException)
			{
				throw new ArgumentOutOfRangeException("index", index, "The index argument must be greater than or equal zero.");
			}
			catch (ArgumentException)
			{
				throw new ArgumentException("The number of elements in the collection is greater than the available space from index to the end of the destination array.", "index");
			}
			catch (RankException)
			{
				throw new ArgumentException("The array argument is multidimensional.", "array");
			}
			catch (InvalidCastException)
			{
				throw new ArgumentException("The array argument is of the incorrect type.", "array");
			}
			catch (ArrayTypeMismatchException)
			{
				throw new ArgumentException("The array argument is of the incorrect type.", "array");
			}
		}

		/// <summary>Предоставляет получающий интерфейс <see cref="T:System.Collections.Generic.IEnumerator`1" /> для элементов коллекции.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" />, удаляющий и возвращающий элементы из коллекции.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> удален.</exception>
		// Token: 0x060025C5 RID: 9669 RVA: 0x00084560 File Offset: 0x00082760
		public IEnumerable<T> GetConsumingEnumerable()
		{
			return this.GetConsumingEnumerable(CancellationToken.None);
		}

		/// <summary>Предоставляет получающий интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" /> для элементов коллекции.</summary>
		/// <param name="cancellationToken">Маркер отмены, который следует контролировать.</param>
		/// <returns>Интерфейс <see cref="T:System.Collections.Generic.IEnumerable`1" />, удаляющий и возвращающий элементы из коллекции.</returns>
		/// <exception cref="T:System.OperationCanceledException">Если <see cref="T:System.Threading.CancellationToken" /> отменяется.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Был удален <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> или объект <see cref="T:System.Threading.CancellationTokenSource" />, создавший <paramref name="cancellationToken" />.</exception>
		// Token: 0x060025C6 RID: 9670 RVA: 0x0008456D File Offset: 0x0008276D
		public IEnumerable<T> GetConsumingEnumerable(CancellationToken cancellationToken)
		{
			CancellationTokenSource linkedTokenSource = null;
			try
			{
				linkedTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, this._consumersCancellationTokenSource.Token);
				while (!this.IsCompleted)
				{
					T t;
					if (this.TryTakeWithNoTimeValidation(out t, -1, cancellationToken, linkedTokenSource))
					{
						yield return t;
					}
				}
			}
			finally
			{
				if (linkedTokenSource != null)
				{
					linkedTokenSource.Dispose();
				}
			}
			yield break;
			yield break;
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x00084584 File Offset: 0x00082784
		IEnumerator<T> IEnumerable<!0>.GetEnumerator()
		{
			this.CheckDisposed();
			return this._collection.GetEnumerator();
		}

		/// <summary>Предоставляет интерфейс <see cref="T:System.Collections.IEnumerator" /> для элементов коллекции.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IEnumerator" /> для элементов коллекции.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Объект <see cref="T:System.Collections.Concurrent.BlockingCollection`1" /> удален.</exception>
		// Token: 0x060025C8 RID: 9672 RVA: 0x00084597 File Offset: 0x00082797
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x000845A0 File Offset: 0x000827A0
		private static void ValidateCollectionsArray(BlockingCollection<T>[] collections, bool isAddOperation)
		{
			if (collections == null)
			{
				throw new ArgumentNullException("collections");
			}
			if (collections.Length < 1)
			{
				throw new ArgumentException("The collections argument is a zero-length array.", "collections");
			}
			if ((!BlockingCollection<T>.IsSTAThread && collections.Length > 63) || (BlockingCollection<T>.IsSTAThread && collections.Length > 62))
			{
				throw new ArgumentOutOfRangeException("collections", "The collections length is greater than the supported range for 32 bit machine.");
			}
			for (int i = 0; i < collections.Length; i++)
			{
				if (collections[i] == null)
				{
					throw new ArgumentException("The collections argument contains at least one null element.", "collections");
				}
				if (collections[i]._isDisposed)
				{
					throw new ObjectDisposedException("collections", "The collections argument contains at least one disposed element.");
				}
				if (isAddOperation && collections[i].IsAddingCompleted)
				{
					throw new ArgumentException("At least one of the specified collections is marked as complete with regards to additions.", "collections");
				}
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x060025CA RID: 9674 RVA: 0x00003062 File Offset: 0x00001262
		private static bool IsSTAThread
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x00084658 File Offset: 0x00082858
		private static void ValidateTimeout(TimeSpan timeout)
		{
			long num = (long)timeout.TotalMilliseconds;
			if ((num < 0L || num > 2147483647L) && num != -1L)
			{
				throw new ArgumentOutOfRangeException("timeout", timeout, string.Format(CultureInfo.InvariantCulture, "The specified timeout must represent a value between -1 and {0}, inclusive.", int.MaxValue));
			}
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x000846AB File Offset: 0x000828AB
		private static void ValidateMillisecondsTimeout(int millisecondsTimeout)
		{
			if (millisecondsTimeout < 0 && millisecondsTimeout != -1)
			{
				throw new ArgumentOutOfRangeException("millisecondsTimeout", millisecondsTimeout, string.Format(CultureInfo.InvariantCulture, "The specified timeout must represent a value between -1 and {0}, inclusive.", int.MaxValue));
			}
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x000846DF File Offset: 0x000828DF
		private void CheckDisposed()
		{
			if (this._isDisposed)
			{
				throw new ObjectDisposedException("BlockingCollection", "The collection has been disposed.");
			}
		}

		// Token: 0x040014B2 RID: 5298
		private IProducerConsumerCollection<T> _collection;

		// Token: 0x040014B3 RID: 5299
		private int _boundedCapacity;

		// Token: 0x040014B4 RID: 5300
		private const int NON_BOUNDED = -1;

		// Token: 0x040014B5 RID: 5301
		private SemaphoreSlim _freeNodes;

		// Token: 0x040014B6 RID: 5302
		private SemaphoreSlim _occupiedNodes;

		// Token: 0x040014B7 RID: 5303
		private bool _isDisposed;

		// Token: 0x040014B8 RID: 5304
		private CancellationTokenSource _consumersCancellationTokenSource;

		// Token: 0x040014B9 RID: 5305
		private CancellationTokenSource _producersCancellationTokenSource;

		// Token: 0x040014BA RID: 5306
		private volatile int _currentAdders;

		// Token: 0x040014BB RID: 5307
		private const int COMPLETE_ADDING_ON_MASK = -2147483648;
	}
}
