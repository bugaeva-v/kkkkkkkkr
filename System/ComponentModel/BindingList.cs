using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;

namespace System.ComponentModel
{
	/// <summary>Предоставляет универсальную коллекцию, которая поддерживает привязку данных.</summary>
	/// <typeparam name="T">Тип элементов в списке.</typeparam>
	// Token: 0x02000385 RID: 901
	[Serializable]
	public class BindingList<T> : Collection<T>, IBindingList, IList, ICollection, IEnumerable, ICancelAddNew, IRaiseItemChangedEvents
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.BindingList`1" />, используя значения по умолчанию.</summary>
		// Token: 0x06001D8B RID: 7563 RVA: 0x00069210 File Offset: 0x00067410
		public BindingList()
		{
			this.Initialize();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.BindingList`1" />, используя заданный список.</summary>
		/// <param name="list">Список <see cref="T:System.Collections.Generic.IList`1" /> элементов, включаемых в список <see cref="T:System.ComponentModel.BindingList`1" />.</param>
		// Token: 0x06001D8C RID: 7564 RVA: 0x00069248 File Offset: 0x00067448
		public BindingList(IList<T> list) : base(list)
		{
			this.Initialize();
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x00069284 File Offset: 0x00067484
		private void Initialize()
		{
			this.allowNew = this.ItemTypeHasDefaultConstructor;
			if (typeof(INotifyPropertyChanged).IsAssignableFrom(typeof(T)))
			{
				this.raiseItemChangedEvents = true;
				foreach (T item in base.Items)
				{
					this.HookPropertyChanged(item);
				}
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001D8E RID: 7566 RVA: 0x00069300 File Offset: 0x00067500
		private bool ItemTypeHasDefaultConstructor
		{
			get
			{
				Type typeFromHandle = typeof(T);
				return typeFromHandle.IsPrimitive || typeFromHandle.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance, null, Array.Empty<Type>(), null) != null;
			}
		}

		/// <summary>Происходит перед добавлением элемента список.</summary>
		// Token: 0x14000028 RID: 40
		// (add) Token: 0x06001D8F RID: 7567 RVA: 0x0006933A File Offset: 0x0006753A
		// (remove) Token: 0x06001D90 RID: 7568 RVA: 0x00069369 File Offset: 0x00067569
		public event AddingNewEventHandler AddingNew
		{
			add
			{
				bool flag = this.AllowNew;
				this._onAddingNew = (AddingNewEventHandler)Delegate.Combine(this._onAddingNew, value);
				if (flag != this.AllowNew)
				{
					this.FireListChanged(ListChangedType.Reset, -1);
				}
			}
			remove
			{
				bool flag = this.AllowNew;
				this._onAddingNew = (AddingNewEventHandler)Delegate.Remove(this._onAddingNew, value);
				if (flag != this.AllowNew)
				{
					this.FireListChanged(ListChangedType.Reset, -1);
				}
			}
		}

		/// <summary>Вызывает событие <see cref="E:System.ComponentModel.BindingList`1.AddingNew" />.</summary>
		/// <param name="e">Объект класса <see cref="T:System.ComponentModel.AddingNewEventArgs" />, содержащий данные события.</param>
		// Token: 0x06001D91 RID: 7569 RVA: 0x00069398 File Offset: 0x00067598
		protected virtual void OnAddingNew(AddingNewEventArgs e)
		{
			AddingNewEventHandler onAddingNew = this._onAddingNew;
			if (onAddingNew == null)
			{
				return;
			}
			onAddingNew(this, e);
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x000693AC File Offset: 0x000675AC
		private object FireAddingNew()
		{
			AddingNewEventArgs addingNewEventArgs = new AddingNewEventArgs(null);
			this.OnAddingNew(addingNewEventArgs);
			return addingNewEventArgs.NewObject;
		}

		/// <summary>Происходит при изменениях в списке или при изменении элемента списка.</summary>
		// Token: 0x14000029 RID: 41
		// (add) Token: 0x06001D93 RID: 7571 RVA: 0x000693CD File Offset: 0x000675CD
		// (remove) Token: 0x06001D94 RID: 7572 RVA: 0x000693E6 File Offset: 0x000675E6
		public event ListChangedEventHandler ListChanged
		{
			add
			{
				this._onListChanged = (ListChangedEventHandler)Delegate.Combine(this._onListChanged, value);
			}
			remove
			{
				this._onListChanged = (ListChangedEventHandler)Delegate.Remove(this._onListChanged, value);
			}
		}

		/// <summary>Вызывает событие <see cref="E:System.ComponentModel.BindingList`1.ListChanged" />.</summary>
		/// <param name="e">Объект <see cref="T:System.ComponentModel.ListChangedEventArgs" />, содержащий данные события.</param>
		// Token: 0x06001D95 RID: 7573 RVA: 0x000693FF File Offset: 0x000675FF
		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
			ListChangedEventHandler onListChanged = this._onListChanged;
			if (onListChanged == null)
			{
				return;
			}
			onListChanged(this, e);
		}

		/// <summary>Получает или задает значение, показывающее, вызывает ли добавление или удаление элемента списка события <see cref="E:System.ComponentModel.BindingList`1.ListChanged" />.</summary>
		/// <returns>Значение <see langword="true" />, если добавление или удаление элемента списка вызывает события <see cref="E:System.ComponentModel.BindingList`1.ListChanged" />; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001D96 RID: 7574 RVA: 0x00069413 File Offset: 0x00067613
		// (set) Token: 0x06001D97 RID: 7575 RVA: 0x0006941B File Offset: 0x0006761B
		public bool RaiseListChangedEvents
		{
			get
			{
				return this.raiseListChangedEvents;
			}
			set
			{
				this.raiseListChangedEvents = value;
			}
		}

		/// <summary>Вызывает событие <see cref="E:System.ComponentModel.BindingList`1.ListChanged" /> типа <see cref="F:System.ComponentModel.ListChangedType.Reset" />.</summary>
		// Token: 0x06001D98 RID: 7576 RVA: 0x00069424 File Offset: 0x00067624
		public void ResetBindings()
		{
			this.FireListChanged(ListChangedType.Reset, -1);
		}

		/// <summary>Вызывает событие <see cref="E:System.ComponentModel.BindingList`1.ListChanged" /> типа <see cref="F:System.ComponentModel.ListChangedType.ItemChanged" /> для элемента в заданной позиции.</summary>
		/// <param name="position">Отсчитываемый с нуля индекс сбрасываемого элемента.</param>
		// Token: 0x06001D99 RID: 7577 RVA: 0x0006942E File Offset: 0x0006762E
		public void ResetItem(int position)
		{
			this.FireListChanged(ListChangedType.ItemChanged, position);
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x00069438 File Offset: 0x00067638
		private void FireListChanged(ListChangedType type, int index)
		{
			if (this.raiseListChangedEvents)
			{
				this.OnListChanged(new ListChangedEventArgs(type, index));
			}
		}

		/// <summary>Удаляет из коллекции все элементы.</summary>
		// Token: 0x06001D9B RID: 7579 RVA: 0x00069450 File Offset: 0x00067650
		protected override void ClearItems()
		{
			this.EndNew(this.addNewPos);
			if (this.raiseItemChangedEvents)
			{
				foreach (T item in base.Items)
				{
					this.UnhookPropertyChanged(item);
				}
			}
			base.ClearItems();
			this.FireListChanged(ListChangedType.Reset, -1);
		}

		/// <summary>Вставляет заданный элемент в список по указанному индексу.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс, по которому следует вставить элемент.</param>
		/// <param name="item">Элемент, который требуется вставить в список.</param>
		// Token: 0x06001D9C RID: 7580 RVA: 0x000694C0 File Offset: 0x000676C0
		protected override void InsertItem(int index, T item)
		{
			this.EndNew(this.addNewPos);
			base.InsertItem(index, item);
			if (this.raiseItemChangedEvents)
			{
				this.HookPropertyChanged(item);
			}
			this.FireListChanged(ListChangedType.ItemAdded, index);
		}

		/// <summary>Удаляет элемент с указанным индексом.</summary>
		/// <param name="index">Отсчитываемый от нуля индекс удаляемого элемента.</param>
		/// <exception cref="T:System.NotSupportedException">Только что добавленный элемент удаляется и свойство <see cref="P:System.ComponentModel.IBindingList.AllowRemove" /> устанавливается равным <see langword="false" />.</exception>
		// Token: 0x06001D9D RID: 7581 RVA: 0x000694F0 File Offset: 0x000676F0
		protected override void RemoveItem(int index)
		{
			if (!this.allowRemove && (this.addNewPos < 0 || this.addNewPos != index))
			{
				throw new NotSupportedException();
			}
			this.EndNew(this.addNewPos);
			if (this.raiseItemChangedEvents)
			{
				this.UnhookPropertyChanged(base[index]);
			}
			base.RemoveItem(index);
			this.FireListChanged(ListChangedType.ItemDeleted, index);
		}

		/// <summary>Заменяет элемент по заданному индексу указанным элементом.</summary>
		/// <param name="index">Отсчитываемый с нуля индекс заменяемого элемента.</param>
		/// <param name="item">Новое значение для элемента с указанным индексом. Для ссылочных типов допускается значение <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="index" /> меньше нуля.  
		/// -или- 
		///  Значение <paramref name="index" /> больше значения <see cref="P:System.Collections.ObjectModel.Collection`1.Count" />.</exception>
		// Token: 0x06001D9E RID: 7582 RVA: 0x0006954D File Offset: 0x0006774D
		protected override void SetItem(int index, T item)
		{
			if (this.raiseItemChangedEvents)
			{
				this.UnhookPropertyChanged(base[index]);
			}
			base.SetItem(index, item);
			if (this.raiseItemChangedEvents)
			{
				this.HookPropertyChanged(item);
			}
			this.FireListChanged(ListChangedType.ItemChanged, index);
		}

		/// <summary>Уничтожает ожидающий новый элемент.</summary>
		/// <param name="itemIndex">Индекс добавляемого нового элемента</param>
		// Token: 0x06001D9F RID: 7583 RVA: 0x00069583 File Offset: 0x00067783
		public virtual void CancelNew(int itemIndex)
		{
			if (this.addNewPos >= 0 && this.addNewPos == itemIndex)
			{
				this.RemoveItem(this.addNewPos);
				this.addNewPos = -1;
			}
		}

		/// <summary>Фиксирует незафиксированный новый элемент в коллекции.</summary>
		/// <param name="itemIndex">Индекс добавляемого нового элемента.</param>
		// Token: 0x06001DA0 RID: 7584 RVA: 0x000695AA File Offset: 0x000677AA
		public virtual void EndNew(int itemIndex)
		{
			if (this.addNewPos >= 0 && this.addNewPos == itemIndex)
			{
				this.addNewPos = -1;
			}
		}

		/// <summary>Добавляет новый элемент в коллекцию.</summary>
		/// <returns>Элемент, который нужно добавить в список.</returns>
		/// <exception cref="T:System.InvalidOperationException">Свойству <see cref="P:System.Windows.Forms.BindingSource.AllowNew" /> задано значение <see langword="false" />.  
		///
		/// или - 
		/// Для текущего типа элемента не удалось найти открытый конструктор по умолчанию.</exception>
		// Token: 0x06001DA1 RID: 7585 RVA: 0x000695C5 File Offset: 0x000677C5
		public T AddNew()
		{
			return (T)((object)((IBindingList)this).AddNew());
		}

		/// <summary>Добавляет новый элемент в список. Для получения дополнительной информации см. <see cref="M:System.ComponentModel.IBindingList.AddNew" />.</summary>
		/// <returns>Элемент, который нужно добавить в список.</returns>
		/// <exception cref="T:System.NotSupportedException">Этот метод не поддерживается.</exception>
		// Token: 0x06001DA2 RID: 7586 RVA: 0x000695D4 File Offset: 0x000677D4
		object IBindingList.AddNew()
		{
			object obj = this.AddNewCore();
			this.addNewPos = ((obj != null) ? base.IndexOf((T)((object)obj)) : -1);
			return obj;
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x00069601 File Offset: 0x00067801
		private bool AddingNewHandled
		{
			get
			{
				return this._onAddingNew != null && this._onAddingNew.GetInvocationList().Length != 0;
			}
		}

		/// <summary>Добавляет новый элемент в конец коллекции.</summary>
		/// <returns>Элемент, добавленный в коллекцию.</returns>
		/// <exception cref="T:System.InvalidCastException">Тип нового элемента не совпадает с типом объектов, содержащихся в списке <see cref="T:System.ComponentModel.BindingList`1" />.</exception>
		// Token: 0x06001DA4 RID: 7588 RVA: 0x0006961C File Offset: 0x0006781C
		protected virtual object AddNewCore()
		{
			object obj = this.FireAddingNew();
			if (obj == null)
			{
				obj = SecurityUtils.SecureCreateInstance(typeof(T));
			}
			base.Add((T)((object)obj));
			return obj;
		}

		/// <summary>Получает или задает значение, показывающее, можно ли добавлять элементы в список с помощью метода <see cref="M:System.ComponentModel.BindingList`1.AddNew" />.</summary>
		/// <returns>Значение <see langword="true" />, если можно добавить элементы в список с помощью метода <see cref="M:System.ComponentModel.BindingList`1.AddNew" />; в противном случае — значение <see langword="false" />. Значение по умолчанию зависит от базового типа, содержащегося в списке.</returns>
		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001DA5 RID: 7589 RVA: 0x00069650 File Offset: 0x00067850
		// (set) Token: 0x06001DA6 RID: 7590 RVA: 0x0006966F File Offset: 0x0006786F
		public bool AllowNew
		{
			get
			{
				if (this.userSetAllowNew || this.allowNew)
				{
					return this.allowNew;
				}
				return this.AddingNewHandled;
			}
			set
			{
				bool flag = this.AllowNew;
				this.userSetAllowNew = true;
				this.allowNew = value;
				if (flag != value)
				{
					this.FireListChanged(ListChangedType.Reset, -1);
				}
			}
		}

		/// <summary>Возвращает значение, показывающее, можно ли добавить новые элементы в список с помощью метода <see cref="M:System.ComponentModel.BindingList`1.AddNew" />.</summary>
		/// <returns>Значение <see langword="true" />, если можно добавить элементы в список с помощью метода <see cref="M:System.ComponentModel.BindingList`1.AddNew" />; в противном случае — значение <see langword="false" />. Значение по умолчанию зависит от базового типа, содержащегося в списке.</returns>
		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x00069690 File Offset: 0x00067890
		bool IBindingList.AllowNew
		{
			get
			{
				return this.AllowNew;
			}
		}

		/// <summary>Получает или задает значение, показывающее, можно ли редактировать элементы в списке.</summary>
		/// <returns>Значение <see langword="true" />, если элементы списка можно редактировать; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001DA8 RID: 7592 RVA: 0x00069698 File Offset: 0x00067898
		// (set) Token: 0x06001DA9 RID: 7593 RVA: 0x000696A0 File Offset: 0x000678A0
		public bool AllowEdit
		{
			get
			{
				return this.allowEdit;
			}
			set
			{
				if (this.allowEdit != value)
				{
					this.allowEdit = value;
					this.FireListChanged(ListChangedType.Reset, -1);
				}
			}
		}

		/// <summary>Возвращает значение, показывающее, можно ли редактировать элементы в списке.</summary>
		/// <returns>Значение <see langword="true" />, если элементы списка можно редактировать; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001DAA RID: 7594 RVA: 0x000696BA File Offset: 0x000678BA
		bool IBindingList.AllowEdit
		{
			get
			{
				return this.AllowEdit;
			}
		}

		/// <summary>Получает или задает значение, показывающее, можно ли удалять элементы из коллекции.</summary>
		/// <returns>Значение <see langword="true" />, если можно удалить элементы из списка с помощью метода <see cref="M:System.ComponentModel.BindingList`1.RemoveItem(System.Int32)" />; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001DAB RID: 7595 RVA: 0x000696C2 File Offset: 0x000678C2
		// (set) Token: 0x06001DAC RID: 7596 RVA: 0x000696CA File Offset: 0x000678CA
		public bool AllowRemove
		{
			get
			{
				return this.allowRemove;
			}
			set
			{
				if (this.allowRemove != value)
				{
					this.allowRemove = value;
					this.FireListChanged(ListChangedType.Reset, -1);
				}
			}
		}

		/// <summary>Возвращает значение, показывающее, можно ли удалять элементы из списка.</summary>
		/// <returns>Значение <see langword="true" />, если можно удалить элементы из списка с помощью метода <see cref="M:System.ComponentModel.BindingList`1.RemoveItem(System.Int32)" />; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001DAD RID: 7597 RVA: 0x000696E4 File Offset: 0x000678E4
		bool IBindingList.AllowRemove
		{
			get
			{
				return this.AllowRemove;
			}
		}

		/// <summary>Описание этого члена см. в разделе <see cref="P:System.ComponentModel.IBindingList.SupportsChangeNotification" />.</summary>
		/// <returns>Значение <see langword="true" />, если при изменениях в списке или при изменении элемента списка вызывается событие <see cref="E:System.ComponentModel.IBindingList.ListChanged" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001DAE RID: 7598 RVA: 0x000696EC File Offset: 0x000678EC
		bool IBindingList.SupportsChangeNotification
		{
			get
			{
				return this.SupportsChangeNotificationCore;
			}
		}

		/// <summary>Возвращает значение, показывающее, включены ли события <see cref="E:System.ComponentModel.BindingList`1.ListChanged" />.</summary>
		/// <returns>Значение <see langword="true" />, если события <see cref="E:System.ComponentModel.BindingList`1.ListChanged" /> поддерживаются, в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001DAF RID: 7599 RVA: 0x0000390E File Offset: 0x00001B0E
		protected virtual bool SupportsChangeNotificationCore
		{
			get
			{
				return true;
			}
		}

		/// <summary>Описание этого члена см. в разделе <see cref="P:System.ComponentModel.IBindingList.SupportsSearching" />.</summary>
		/// <returns>Значение <see langword="true" />, если список поддерживает поиск с использованием метода <see cref="M:System.ComponentModel.IBindingList.Find(System.ComponentModel.PropertyDescriptor,System.Object)" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001DB0 RID: 7600 RVA: 0x000696F4 File Offset: 0x000678F4
		bool IBindingList.SupportsSearching
		{
			get
			{
				return this.SupportsSearchingCore;
			}
		}

		/// <summary>Возвращает значение, показывающее, поддерживается ли этим списком поиск.</summary>
		/// <returns>Значение <see langword="true" />, если список поддерживает поиск; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x00003062 File Offset: 0x00001262
		protected virtual bool SupportsSearchingCore
		{
			get
			{
				return false;
			}
		}

		/// <summary>Описание этого члена см. в разделе <see cref="P:System.ComponentModel.IBindingList.SupportsSorting" />.</summary>
		/// <returns>Значение <see langword="true" />, если список поддерживает сортировку; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001DB2 RID: 7602 RVA: 0x000696FC File Offset: 0x000678FC
		bool IBindingList.SupportsSorting
		{
			get
			{
				return this.SupportsSortingCore;
			}
		}

		/// <summary>Возвращает значение, показывающее, поддерживается ли этим списком сортировка.</summary>
		/// <returns>Значение <see langword="true" />, если список поддерживает сортировку; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001DB3 RID: 7603 RVA: 0x00003062 File Offset: 0x00001262
		protected virtual bool SupportsSortingCore
		{
			get
			{
				return false;
			}
		}

		/// <summary>Описание этого члена см. в разделе <see cref="P:System.ComponentModel.IBindingList.IsSorted" />.</summary>
		/// <returns>Значение <see langword="true" />, если был вызван метод <see cref="M:System.ComponentModel.IBindingListView.ApplySort(System.ComponentModel.ListSortDescriptionCollection)" />, а метод <see cref="M:System.ComponentModel.IBindingList.RemoveSort" /> не вызывался; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x00069704 File Offset: 0x00067904
		bool IBindingList.IsSorted
		{
			get
			{
				return this.IsSortedCore;
			}
		}

		/// <summary>Возвращает значение, показывающее, сортируется ли список.</summary>
		/// <returns>Значение <see langword="true" />, если список сортируется; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x00003062 File Offset: 0x00001262
		protected virtual bool IsSortedCore
		{
			get
			{
				return false;
			}
		}

		/// <summary>Описание этого члена см. в разделе <see cref="P:System.ComponentModel.IBindingList.SortProperty" />.</summary>
		/// <returns>Дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" />, используемый для сортировки.</returns>
		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x0006970C File Offset: 0x0006790C
		PropertyDescriptor IBindingList.SortProperty
		{
			get
			{
				return this.SortPropertyCore;
			}
		}

		/// <summary>Возвращает дескриптор свойства, используемый для сортировки списка, если сортировка реализуется в производном классе; в противном случае возвращает <see langword="null" />.</summary>
		/// <returns>Дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" />, используемая для сортировки списка.</returns>
		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x00002F6A File Offset: 0x0000116A
		protected virtual PropertyDescriptor SortPropertyCore
		{
			get
			{
				return null;
			}
		}

		/// <summary>Описание этого члена см. в разделе <see cref="P:System.ComponentModel.IBindingList.SortDirection" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.ComponentModel.ListSortDirection" />.</returns>
		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x00069714 File Offset: 0x00067914
		ListSortDirection IBindingList.SortDirection
		{
			get
			{
				return this.SortDirectionCore;
			}
		}

		/// <summary>Возвращает направление сортировки списка.</summary>
		/// <returns>Одно из значений <see cref="T:System.ComponentModel.ListSortDirection" />. Значение по умолчанию — <see cref="F:System.ComponentModel.ListSortDirection.Ascending" />.</returns>
		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x00003062 File Offset: 0x00001262
		protected virtual ListSortDirection SortDirectionCore
		{
			get
			{
				return ListSortDirection.Ascending;
			}
		}

		/// <summary>Сортирует список, используя дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" /> и направление <see cref="T:System.ComponentModel.ListSortDirection" />. Полное описание этого члена см. в разделе, посвященном методу <see cref="M:System.ComponentModel.IBindingList.ApplySort(System.ComponentModel.PropertyDescriptor,System.ComponentModel.ListSortDirection)" />.</summary>
		/// <param name="prop">Дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" /> для сортировки.</param>
		/// <param name="direction">Одно из значений <see cref="T:System.ComponentModel.ListSortDirection" />.</param>
		// Token: 0x06001DBA RID: 7610 RVA: 0x0006971C File Offset: 0x0006791C
		void IBindingList.ApplySort(PropertyDescriptor prop, ListSortDirection direction)
		{
			this.ApplySortCore(prop, direction);
		}

		/// <summary>При переопределении в производном классе сортирует элементы; в противном случае вызывает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="prop">Дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" />, определяющий свойство для сортировки.</param>
		/// <param name="direction">Одно из значений <see cref="T:System.ComponentModel.ListSortDirection" />.</param>
		/// <exception cref="T:System.NotSupportedException">Метод не переопределяется в производном классе.</exception>
		// Token: 0x06001DBB RID: 7611 RVA: 0x000044FA File Offset: 0x000026FA
		protected virtual void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
		{
			throw new NotSupportedException();
		}

		/// <summary>Описание этого элемента см. в разделе <see cref="M:System.ComponentModel.IBindingList.RemoveSort" />.</summary>
		// Token: 0x06001DBC RID: 7612 RVA: 0x00069726 File Offset: 0x00067926
		void IBindingList.RemoveSort()
		{
			this.RemoveSortCore();
		}

		/// <summary>Удаляет любую сортировку, применяемую с помощью метода <see cref="M:System.ComponentModel.BindingList`1.ApplySortCore(System.ComponentModel.PropertyDescriptor,System.ComponentModel.ListSortDirection)" />, если сортировка реализована в производном классе; в противном случае вызывает исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <exception cref="T:System.NotSupportedException">Метод не переопределяется в производном классе.</exception>
		// Token: 0x06001DBD RID: 7613 RVA: 0x000044FA File Offset: 0x000026FA
		protected virtual void RemoveSortCore()
		{
			throw new NotSupportedException();
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.ComponentModel.IBindingList.Find(System.ComponentModel.PropertyDescriptor,System.Object)" />.</summary>
		/// <param name="prop">Дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" /> для поиска.</param>
		/// <param name="key">Значение параметра <paramref name="prop" />, используемое для поиска.</param>
		/// <returns>Индекс строки с данным дескриптором <see cref="T:System.ComponentModel.PropertyDescriptor" />.</returns>
		// Token: 0x06001DBE RID: 7614 RVA: 0x0006972E File Offset: 0x0006792E
		int IBindingList.Find(PropertyDescriptor prop, object key)
		{
			return this.FindCore(prop, key);
		}

		/// <summary>Выполняет поиск индекса элемента, у которого заданный дескриптор свойств равен заданному значению, если поиск реализуется в производном классе; в противном случае — исключение <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="prop">Объект <see cref="T:System.ComponentModel.PropertyDescriptor" />, который требуется найти.</param>
		/// <param name="key">Значение параметр <paramref name="prop" /> для поиска соответствия.</param>
		/// <returns>Отсчитываемый от нуля индекс элемента, соответствующего дескриптору свойств и содержащему заданное значение.</returns>
		/// <exception cref="T:System.NotSupportedException">Метод <see cref="M:System.ComponentModel.BindingList`1.FindCore(System.ComponentModel.PropertyDescriptor,System.Object)" /> не переопределяется в производном классе.</exception>
		// Token: 0x06001DBF RID: 7615 RVA: 0x000044FA File Offset: 0x000026FA
		protected virtual int FindCore(PropertyDescriptor prop, object key)
		{
			throw new NotSupportedException();
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.ComponentModel.IBindingList.AddIndex(System.ComponentModel.PropertyDescriptor)" />.</summary>
		/// <param name="prop">Дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" />, добавляемый как условие поиска.</param>
		// Token: 0x06001DC0 RID: 7616 RVA: 0x00003917 File Offset: 0x00001B17
		void IBindingList.AddIndex(PropertyDescriptor prop)
		{
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.ComponentModel.IBindingList.RemoveIndex(System.ComponentModel.PropertyDescriptor)" />.</summary>
		/// <param name="prop">Дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" />, удаляемый из индексов, используемых для поиска.</param>
		// Token: 0x06001DC1 RID: 7617 RVA: 0x00003917 File Offset: 0x00001B17
		void IBindingList.RemoveIndex(PropertyDescriptor prop)
		{
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x00069738 File Offset: 0x00067938
		private void HookPropertyChanged(T item)
		{
			INotifyPropertyChanged notifyPropertyChanged = item as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
			{
				if (this._propertyChangedEventHandler == null)
				{
					this._propertyChangedEventHandler = new PropertyChangedEventHandler(this.Child_PropertyChanged);
				}
				notifyPropertyChanged.PropertyChanged += this._propertyChangedEventHandler;
			}
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x0006977C File Offset: 0x0006797C
		private void UnhookPropertyChanged(T item)
		{
			INotifyPropertyChanged notifyPropertyChanged = item as INotifyPropertyChanged;
			if (notifyPropertyChanged != null && this._propertyChangedEventHandler != null)
			{
				notifyPropertyChanged.PropertyChanged -= this._propertyChangedEventHandler;
			}
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x000697AC File Offset: 0x000679AC
		private void Child_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (this.RaiseListChangedEvents)
			{
				if (sender == null || e == null || string.IsNullOrEmpty(e.PropertyName))
				{
					this.ResetBindings();
					return;
				}
				T t;
				try
				{
					t = (T)((object)sender);
				}
				catch (InvalidCastException)
				{
					this.ResetBindings();
					return;
				}
				int num = this._lastChangeIndex;
				if (num >= 0 && num < base.Count)
				{
					T t2 = base[num];
					if (t2.Equals(t))
					{
						goto IL_7B;
					}
				}
				num = base.IndexOf(t);
				this._lastChangeIndex = num;
				IL_7B:
				if (num == -1)
				{
					this.UnhookPropertyChanged(t);
					this.ResetBindings();
					return;
				}
				if (this._itemTypeProperties == null)
				{
					this._itemTypeProperties = TypeDescriptor.GetProperties(typeof(T));
				}
				PropertyDescriptor propDesc = this._itemTypeProperties.Find(e.PropertyName, true);
				ListChangedEventArgs e2 = new ListChangedEventArgs(ListChangedType.ItemChanged, num, propDesc);
				this.OnListChanged(e2);
			}
		}

		/// <summary>Возвращает значение, показывающее, приводят ли изменения значения свойства элемента к появлению событий <see cref="E:System.ComponentModel.BindingList`1.ListChanged" /> типа <see cref="F:System.ComponentModel.ListChangedType.ItemChanged" />. Этот метод не может быть переопределен в производном классе.</summary>
		/// <returns>
		///   <see langword="true" /> Если тип списка реализует <see cref="T:System.ComponentModel.INotifyPropertyChanged" />, в противном случае <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001DC5 RID: 7621 RVA: 0x00069898 File Offset: 0x00067A98
		bool IRaiseItemChangedEvents.RaisesItemChangedEvents
		{
			get
			{
				return this.raiseItemChangedEvents;
			}
		}

		// Token: 0x04000EE9 RID: 3817
		private int addNewPos = -1;

		// Token: 0x04000EEA RID: 3818
		private bool raiseListChangedEvents = true;

		// Token: 0x04000EEB RID: 3819
		private bool raiseItemChangedEvents;

		// Token: 0x04000EEC RID: 3820
		[NonSerialized]
		private PropertyDescriptorCollection _itemTypeProperties;

		// Token: 0x04000EED RID: 3821
		[NonSerialized]
		private PropertyChangedEventHandler _propertyChangedEventHandler;

		// Token: 0x04000EEE RID: 3822
		[NonSerialized]
		private AddingNewEventHandler _onAddingNew;

		// Token: 0x04000EEF RID: 3823
		[NonSerialized]
		private ListChangedEventHandler _onListChanged;

		// Token: 0x04000EF0 RID: 3824
		[NonSerialized]
		private int _lastChangeIndex = -1;

		// Token: 0x04000EF1 RID: 3825
		private bool allowNew = true;

		// Token: 0x04000EF2 RID: 3826
		private bool allowEdit = true;

		// Token: 0x04000EF3 RID: 3827
		private bool allowRemove = true;

		// Token: 0x04000EF4 RID: 3828
		private bool userSetAllowNew;
	}
}
