using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace System.Collections.ObjectModel
{
	/// <summary>Представляет динамическую коллекцию данных, которая выдает уведомления при добавлении и удалении элементов, а также при обновлении списка.</summary>
	/// <typeparam name="T">Тип элементов в коллекции.</typeparam>
	// Token: 0x02000495 RID: 1173
	[DebuggerTypeProxy(typeof(CollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public class ObservableCollection<T> : Collection<T>, INotifyCollectionChanged, INotifyPropertyChanged
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.ObjectModel.ObservableCollection`1" />.</summary>
		// Token: 0x06002565 RID: 9573 RVA: 0x000833B2 File Offset: 0x000815B2
		public ObservableCollection()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.ObjectModel.ObservableCollection`1" />, который содержит элементы, скопированные из указанной коллекции.</summary>
		/// <param name="collection">Коллекция, из которой копируются элементы.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="collection" /> не может иметь значение <see langword="null" />.</exception>
		// Token: 0x06002566 RID: 9574 RVA: 0x000833BA File Offset: 0x000815BA
		public ObservableCollection(IEnumerable<T> collection) : base(ObservableCollection<T>.CreateCopy(collection, "collection"))
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.ObjectModel.ObservableCollection`1" />, который содержит элементы, скопированные из указанного списка.</summary>
		/// <param name="list">Список, из которого копируются элементы.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="list" /> не может иметь значение <see langword="null" />.</exception>
		// Token: 0x06002567 RID: 9575 RVA: 0x000833CD File Offset: 0x000815CD
		public ObservableCollection(List<T> list) : base(ObservableCollection<T>.CreateCopy(list, "list"))
		{
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x000833E0 File Offset: 0x000815E0
		private static List<T> CreateCopy(IEnumerable<T> collection, string paramName)
		{
			if (collection == null)
			{
				throw new ArgumentNullException(paramName);
			}
			return new List<T>(collection);
		}

		/// <summary>Перемещает элемент в новое положение в коллекции по указанному индексу.</summary>
		/// <param name="oldIndex">Отсчитываемый от нуля индекс, указывающий положение перемещаемого элемента.</param>
		/// <param name="newIndex">Отсчитываемый от нуля индекс, указывающий новое положение элемента.</param>
		// Token: 0x06002569 RID: 9577 RVA: 0x000833F2 File Offset: 0x000815F2
		public void Move(int oldIndex, int newIndex)
		{
			this.MoveItem(oldIndex, newIndex);
		}

		/// <summary>Возникает при смене значения свойства.</summary>
		// Token: 0x1400004A RID: 74
		// (add) Token: 0x0600256A RID: 9578 RVA: 0x000833FC File Offset: 0x000815FC
		// (remove) Token: 0x0600256B RID: 9579 RVA: 0x00083405 File Offset: 0x00081605
		event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
		{
			add
			{
				this.PropertyChanged += value;
			}
			remove
			{
				this.PropertyChanged -= value;
			}
		}

		/// <summary>Происходит при добавлении, удалении, изменении или перемещении элемента либо при обновлении всего списка.</summary>
		// Token: 0x1400004B RID: 75
		// (add) Token: 0x0600256C RID: 9580 RVA: 0x00083410 File Offset: 0x00081610
		// (remove) Token: 0x0600256D RID: 9581 RVA: 0x00083448 File Offset: 0x00081648
		[NonSerialized]
		public virtual event NotifyCollectionChangedEventHandler CollectionChanged;

		/// <summary>Удаляет все элементы из коллекции.</summary>
		// Token: 0x0600256E RID: 9582 RVA: 0x0008347D File Offset: 0x0008167D
		protected override void ClearItems()
		{
			this.CheckReentrancy();
			base.ClearItems();
			this.OnCountPropertyChanged();
			this.OnIndexerPropertyChanged();
			this.OnCollectionReset();
		}

		/// <summary>Удаляет элемент по указанному индексу коллекции.</summary>
		/// <param name="index">Индекс (с нуля) элемента, который требуется удалить.</param>
		// Token: 0x0600256F RID: 9583 RVA: 0x000834A0 File Offset: 0x000816A0
		protected override void RemoveItem(int index)
		{
			this.CheckReentrancy();
			T t = base[index];
			base.RemoveItem(index);
			this.OnCountPropertyChanged();
			this.OnIndexerPropertyChanged();
			this.OnCollectionChanged(NotifyCollectionChangedAction.Remove, t, index);
		}

		/// <summary>Вставляет элемент в коллекцию по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс, по которому следует вставить элемент <paramref name="item" />.</param>
		/// <param name="item">Вставляемый объект.</param>
		// Token: 0x06002570 RID: 9584 RVA: 0x000834DC File Offset: 0x000816DC
		protected override void InsertItem(int index, T item)
		{
			this.CheckReentrancy();
			base.InsertItem(index, item);
			this.OnCountPropertyChanged();
			this.OnIndexerPropertyChanged();
			this.OnCollectionChanged(NotifyCollectionChangedAction.Add, item, index);
		}

		/// <summary>Заменяет элемент по указанному индексу.</summary>
		/// <param name="index">Индекс (с нуля) элемента, который требуется заменить.</param>
		/// <param name="item">Новое значение элемента по указанному индексу.</param>
		// Token: 0x06002571 RID: 9585 RVA: 0x00083508 File Offset: 0x00081708
		protected override void SetItem(int index, T item)
		{
			this.CheckReentrancy();
			T t = base[index];
			base.SetItem(index, item);
			this.OnIndexerPropertyChanged();
			this.OnCollectionChanged(NotifyCollectionChangedAction.Replace, t, item, index);
		}

		/// <summary>Перемещает элемент в новое положение в коллекции по указанному индексу.</summary>
		/// <param name="oldIndex">Отсчитываемый от нуля индекс, указывающий положение перемещаемого элемента.</param>
		/// <param name="newIndex">Отсчитываемый от нуля индекс, указывающий новое положение элемента.</param>
		// Token: 0x06002572 RID: 9586 RVA: 0x00083548 File Offset: 0x00081748
		protected virtual void MoveItem(int oldIndex, int newIndex)
		{
			this.CheckReentrancy();
			T t = base[oldIndex];
			base.RemoveItem(oldIndex);
			base.InsertItem(newIndex, t);
			this.OnIndexerPropertyChanged();
			this.OnCollectionChanged(NotifyCollectionChangedAction.Move, t, newIndex, oldIndex);
		}

		/// <summary>Вызывает событие <see cref="E:System.Collections.ObjectModel.ObservableCollection`1.PropertyChanged" /> с предоставленным аргументами.</summary>
		/// <param name="e">Аргументы вызываемого события.</param>
		// Token: 0x06002573 RID: 9587 RVA: 0x00083587 File Offset: 0x00081787
		protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged == null)
			{
				return;
			}
			propertyChanged(this, e);
		}

		/// <summary>Возникает при смене значения свойства.</summary>
		// Token: 0x1400004C RID: 76
		// (add) Token: 0x06002574 RID: 9588 RVA: 0x0008359C File Offset: 0x0008179C
		// (remove) Token: 0x06002575 RID: 9589 RVA: 0x000835D4 File Offset: 0x000817D4
		[NonSerialized]
		protected virtual event PropertyChangedEventHandler PropertyChanged;

		/// <summary>Вызывает событие <see cref="E:System.Collections.ObjectModel.ObservableCollection`1.CollectionChanged" /> с предоставленным аргументами.</summary>
		/// <param name="e">Аргументы вызываемого события.</param>
		// Token: 0x06002576 RID: 9590 RVA: 0x0008360C File Offset: 0x0008180C
		protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
		{
			NotifyCollectionChangedEventHandler collectionChanged = this.CollectionChanged;
			if (collectionChanged != null)
			{
				this._blockReentrancyCount++;
				try
				{
					collectionChanged(this, e);
				}
				finally
				{
					this._blockReentrancyCount--;
				}
			}
		}

		/// <summary>Запрещает выполнение повторных попыток изменения этой коллекции.</summary>
		/// <returns>Объект <see cref="T:System.IDisposable" />, который может использоваться для удаления объекта.</returns>
		// Token: 0x06002577 RID: 9591 RVA: 0x0008365C File Offset: 0x0008185C
		protected IDisposable BlockReentrancy()
		{
			this._blockReentrancyCount++;
			return this.EnsureMonitorInitialized();
		}

		/// <summary>Проводит проверку на реентерабельные попытки изменения этой коллекции.</summary>
		/// <exception cref="T:System.InvalidOperationException">Если был вызван метод <see cref="M:System.Collections.ObjectModel.ObservableCollection`1.BlockReentrancy" />, возвращаемое значение <see cref="T:System.IDisposable" /> которого ещё не было уничтожено. Как правило, это означает проведение дополнительных попыток изменения коллекции во время события <see cref="E:System.Collections.ObjectModel.ObservableCollection`1.CollectionChanged" />. Однако это зависит от того, когда производные классы вызывают метод <see cref="M:System.Collections.ObjectModel.ObservableCollection`1.BlockReentrancy" />.</exception>
		// Token: 0x06002578 RID: 9592 RVA: 0x00083672 File Offset: 0x00081872
		protected void CheckReentrancy()
		{
			if (this._blockReentrancyCount > 0)
			{
				NotifyCollectionChangedEventHandler collectionChanged = this.CollectionChanged;
				if (collectionChanged != null && collectionChanged.GetInvocationList().Length > 1)
				{
					throw new InvalidOperationException("Cannot change ObservableCollection during a CollectionChanged event.");
				}
			}
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x000836A1 File Offset: 0x000818A1
		private void OnCountPropertyChanged()
		{
			this.OnPropertyChanged(EventArgsCache.CountPropertyChanged);
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x000836AE File Offset: 0x000818AE
		private void OnIndexerPropertyChanged()
		{
			this.OnPropertyChanged(EventArgsCache.IndexerPropertyChanged);
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x000836BB File Offset: 0x000818BB
		private void OnCollectionChanged(NotifyCollectionChangedAction action, object item, int index)
		{
			this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(action, item, index));
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x000836CB File Offset: 0x000818CB
		private void OnCollectionChanged(NotifyCollectionChangedAction action, object item, int index, int oldIndex)
		{
			this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(action, item, index, oldIndex));
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x000836DD File Offset: 0x000818DD
		private void OnCollectionChanged(NotifyCollectionChangedAction action, object oldItem, object newItem, int index)
		{
			this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(action, newItem, oldItem, index));
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x000836EF File Offset: 0x000818EF
		private void OnCollectionReset()
		{
			this.OnCollectionChanged(EventArgsCache.ResetCollectionChanged);
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x000836FC File Offset: 0x000818FC
		private ObservableCollection<T>.SimpleMonitor EnsureMonitorInitialized()
		{
			ObservableCollection<T>.SimpleMonitor result;
			if ((result = this._monitor) == null)
			{
				result = (this._monitor = new ObservableCollection<T>.SimpleMonitor(this));
			}
			return result;
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x00083722 File Offset: 0x00081922
		[OnSerializing]
		private void OnSerializing(StreamingContext context)
		{
			this.EnsureMonitorInitialized();
			this._monitor._busyCount = this._blockReentrancyCount;
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x0008373C File Offset: 0x0008193C
		[OnDeserialized]
		private void OnDeserialized(StreamingContext context)
		{
			if (this._monitor != null)
			{
				this._blockReentrancyCount = this._monitor._busyCount;
				this._monitor._collection = this;
			}
		}

		// Token: 0x040014A7 RID: 5287
		private ObservableCollection<T>.SimpleMonitor _monitor;

		// Token: 0x040014A8 RID: 5288
		[NonSerialized]
		private int _blockReentrancyCount;

		// Token: 0x02000496 RID: 1174
		[Serializable]
		private sealed class SimpleMonitor : IDisposable
		{
			// Token: 0x06002582 RID: 9602 RVA: 0x00083763 File Offset: 0x00081963
			public SimpleMonitor(ObservableCollection<T> collection)
			{
				this._collection = collection;
			}

			// Token: 0x06002583 RID: 9603 RVA: 0x00083772 File Offset: 0x00081972
			public void Dispose()
			{
				this._collection._blockReentrancyCount--;
			}

			// Token: 0x040014AB RID: 5291
			internal int _busyCount;

			// Token: 0x040014AC RID: 5292
			[NonSerialized]
			internal ObservableCollection<T> _collection;
		}
	}
}
