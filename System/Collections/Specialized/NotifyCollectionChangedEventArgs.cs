using System;

namespace System.Collections.Specialized
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Collections.Specialized.INotifyCollectionChanged.CollectionChanged" />.</summary>
	// Token: 0x020004B5 RID: 1205
	public class NotifyCollectionChangedEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Collections.Specialized.NotifyCollectionChangedEventArgs" />, описывающий изменение <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Reset" />.</summary>
		/// <param name="action">Действие, вызвавшее событие. Должно быть установлено значение <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Reset" />.</param>
		// Token: 0x060026EC RID: 9964 RVA: 0x00087523 File Offset: 0x00085723
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action)
		{
			if (action != NotifyCollectionChangedAction.Reset)
			{
				throw new ArgumentException(SR.Format("Constructor supports only the '{0}' action.", NotifyCollectionChangedAction.Reset), "action");
			}
			this.InitializeAdd(action, null, -1);
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Collections.Specialized.NotifyCollectionChangedEventArgs" />, описывающий изменение для одного элемента.</summary>
		/// <param name="action">Действие, вызвавшее событие. Возможными значениями являются: <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Reset" />, <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Add" /> или <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Remove" />.</param>
		/// <param name="changedItem">Элемент, затронутый изменением.</param>
		/// <exception cref="T:System.ArgumentException">Если параметр <paramref name="action" /> не имеет значения Reset, Add или Remove или если параметр <paramref name="action" /> имеет значение Reset и параметр <paramref name="changedItem" /> не равен null.</exception>
		// Token: 0x060026ED RID: 9965 RVA: 0x00087564 File Offset: 0x00085764
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem)
		{
			if (action != NotifyCollectionChangedAction.Add && action != NotifyCollectionChangedAction.Remove && action != NotifyCollectionChangedAction.Reset)
			{
				throw new ArgumentException("Constructor only supports either a Reset, Add, or Remove action.", "action");
			}
			if (action != NotifyCollectionChangedAction.Reset)
			{
				this.InitializeAddOrRemove(action, new object[]
				{
					changedItem
				}, -1);
				return;
			}
			if (changedItem != null)
			{
				throw new ArgumentException("Reset action must be initialized with no changed items.", "action");
			}
			this.InitializeAdd(action, null, -1);
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Collections.Specialized.NotifyCollectionChangedEventArgs" />, описывающий изменение для одного элемента.</summary>
		/// <param name="action">Действие, вызвавшее событие. Возможными значениями являются: <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Reset" />, <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Add" /> или <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Remove" />.</param>
		/// <param name="changedItem">Элемент, затронутый изменением.</param>
		/// <param name="index">Индекс, указывающий, где произошло изменение.</param>
		/// <exception cref="T:System.ArgumentException">Если параметр <paramref name="action" /> не имеет значения Reset, Add или Remove или если параметр <paramref name="action" /> имеет значение Reset и либо параметр <paramref name="changedItems" /> не равен null, либо параметр <paramref name="index" /> не равен -1.</exception>
		// Token: 0x060026EE RID: 9966 RVA: 0x000875D4 File Offset: 0x000857D4
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index)
		{
			if (action != NotifyCollectionChangedAction.Add && action != NotifyCollectionChangedAction.Remove && action != NotifyCollectionChangedAction.Reset)
			{
				throw new ArgumentException("Constructor only supports either a Reset, Add, or Remove action.", "action");
			}
			if (action != NotifyCollectionChangedAction.Reset)
			{
				this.InitializeAddOrRemove(action, new object[]
				{
					changedItem
				}, index);
				return;
			}
			if (changedItem != null)
			{
				throw new ArgumentException("Reset action must be initialized with no changed items.", "action");
			}
			if (index != -1)
			{
				throw new ArgumentException("Reset action must be initialized with index -1.", "action");
			}
			this.InitializeAdd(action, null, -1);
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Collections.Specialized.NotifyCollectionChangedEventArgs" />, описывающий изменение для нескольких элементов.</summary>
		/// <param name="action">Действие, вызвавшее событие. Возможными значениями являются: <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Reset" />, <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Add" /> или <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Remove" />.</param>
		/// <param name="changedItems">Элементы, затрагиваемые изменением.</param>
		// Token: 0x060026EF RID: 9967 RVA: 0x00087658 File Offset: 0x00085858
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems)
		{
			if (action != NotifyCollectionChangedAction.Add && action != NotifyCollectionChangedAction.Remove && action != NotifyCollectionChangedAction.Reset)
			{
				throw new ArgumentException("Constructor only supports either a Reset, Add, or Remove action.", "action");
			}
			if (action == NotifyCollectionChangedAction.Reset)
			{
				if (changedItems != null)
				{
					throw new ArgumentException("Reset action must be initialized with no changed items.", "action");
				}
				this.InitializeAdd(action, null, -1);
				return;
			}
			else
			{
				if (changedItems == null)
				{
					throw new ArgumentNullException("changedItems");
				}
				this.InitializeAddOrRemove(action, changedItems, -1);
				return;
			}
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Collections.Specialized.NotifyCollectionChangedEventArgs" />, описывающий изменение для нескольких элементов или изменение <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Reset" />.</summary>
		/// <param name="action">Действие, вызвавшее событие. Возможными значениями являются: <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Reset" />, <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Add" /> или <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Remove" />.</param>
		/// <param name="changedItems">Элементы, затронутые изменением.</param>
		/// <param name="startingIndex">Индекс, указывающий, где произошло изменение.</param>
		/// <exception cref="T:System.ArgumentException">Если параметр <paramref name="action" /> не имеет значения Reset, Add или Remove, или если параметр <paramref name="action" /> имеет значение Reset и либо параметр <paramref name="changedItems" /> не равен null, либо параметр <paramref name="startingIndex" /> не равен -1, или если действием является Add или Remove и параметр <paramref name="startingIndex" /> меньше -1.</exception>
		/// <exception cref="T:System.ArgumentNullException">Если <paramref name="action" /> имеет значение Add или Remove и параметр <paramref name="changedItems" /> равен nul.</exception>
		// Token: 0x060026F0 RID: 9968 RVA: 0x000876CC File Offset: 0x000858CC
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems, int startingIndex)
		{
			if (action != NotifyCollectionChangedAction.Add && action != NotifyCollectionChangedAction.Remove && action != NotifyCollectionChangedAction.Reset)
			{
				throw new ArgumentException("Constructor only supports either a Reset, Add, or Remove action.", "action");
			}
			if (action == NotifyCollectionChangedAction.Reset)
			{
				if (changedItems != null)
				{
					throw new ArgumentException("Reset action must be initialized with no changed items.", "action");
				}
				if (startingIndex != -1)
				{
					throw new ArgumentException("Reset action must be initialized with index -1.", "action");
				}
				this.InitializeAdd(action, null, -1);
				return;
			}
			else
			{
				if (changedItems == null)
				{
					throw new ArgumentNullException("changedItems");
				}
				if (startingIndex < -1)
				{
					throw new ArgumentException("Index cannot be negative.", "startingIndex");
				}
				this.InitializeAddOrRemove(action, changedItems, startingIndex);
				return;
			}
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Collections.Specialized.NotifyCollectionChangedEventArgs" />, описывающий изменение <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Replace" /> для одного элемента.</summary>
		/// <param name="action">Действие, вызвавшее событие. Возможным значением может быть только <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Replace" />.</param>
		/// <param name="newItem">Новый элемент, заменяющий исходный элемент.</param>
		/// <param name="oldItem">Исходный элемент, который заменяется.</param>
		/// <exception cref="T:System.ArgumentException">Если параметр <paramref name="action" /> не имеет значения Replace.</exception>
		// Token: 0x060026F1 RID: 9969 RVA: 0x00087768 File Offset: 0x00085968
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem)
		{
			if (action != NotifyCollectionChangedAction.Replace)
			{
				throw new ArgumentException(SR.Format("Constructor supports only the '{0}' action.", NotifyCollectionChangedAction.Replace), "action");
			}
			this.InitializeMoveOrReplace(action, new object[]
			{
				newItem
			}, new object[]
			{
				oldItem
			}, -1, -1);
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Collections.Specialized.NotifyCollectionChangedEventArgs" />, описывающий изменение <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Replace" /> для одного элемента.</summary>
		/// <param name="action">Действие, вызвавшее событие. Возможным значением может быть <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Replace" />.</param>
		/// <param name="newItem">Новый элемент, заменяющий исходный элемент.</param>
		/// <param name="oldItem">Исходный элемент, который заменяется.</param>
		/// <param name="index">Индекс заменяемого элемента.</param>
		/// <exception cref="T:System.ArgumentException">Если параметр <paramref name="action" /> не имеет значения Replace.</exception>
		// Token: 0x060026F2 RID: 9970 RVA: 0x000877C8 File Offset: 0x000859C8
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem, int index)
		{
			if (action != NotifyCollectionChangedAction.Replace)
			{
				throw new ArgumentException(SR.Format("Constructor supports only the '{0}' action.", NotifyCollectionChangedAction.Replace), "action");
			}
			this.InitializeMoveOrReplace(action, new object[]
			{
				newItem
			}, new object[]
			{
				oldItem
			}, index, index);
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Collections.Specialized.NotifyCollectionChangedEventArgs" />, описывающий изменение <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Replace" /> для нескольких элементов.</summary>
		/// <param name="action">Действие, вызвавшее событие. Возможным значением может быть только <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Replace" />.</param>
		/// <param name="newItems">Новые элементы, заменяющие исходные.</param>
		/// <param name="oldItems">Заменяемые исходные элементы.</param>
		/// <exception cref="T:System.ArgumentException">Если параметр <paramref name="action" /> не имеет значения Replace.</exception>
		/// <exception cref="T:System.ArgumentNullException">Если параметр <paramref name="oldItems" /> или <paramref name="newItems" /> имеет значение null.</exception>
		// Token: 0x060026F3 RID: 9971 RVA: 0x00087828 File Offset: 0x00085A28
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems)
		{
			if (action != NotifyCollectionChangedAction.Replace)
			{
				throw new ArgumentException(SR.Format("Constructor supports only the '{0}' action.", NotifyCollectionChangedAction.Replace), "action");
			}
			if (newItems == null)
			{
				throw new ArgumentNullException("newItems");
			}
			if (oldItems == null)
			{
				throw new ArgumentNullException("oldItems");
			}
			this.InitializeMoveOrReplace(action, newItems, oldItems, -1, -1);
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Collections.Specialized.NotifyCollectionChangedEventArgs" />, описывающий изменение <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Replace" /> для нескольких элементов.</summary>
		/// <param name="action">Действие, вызвавшее событие. Возможным значением может быть только <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Replace" />.</param>
		/// <param name="newItems">Новые элементы, заменяющие исходные.</param>
		/// <param name="oldItems">Заменяемые исходные элементы.</param>
		/// <param name="startingIndex">Индекс первого заменяемого элемента.</param>
		/// <exception cref="T:System.ArgumentException">Если параметр <paramref name="action" /> не имеет значения Replace.</exception>
		/// <exception cref="T:System.ArgumentNullException">Если параметр <paramref name="oldItems" /> или <paramref name="newItems" /> имеет значение null.</exception>
		// Token: 0x060026F4 RID: 9972 RVA: 0x00087890 File Offset: 0x00085A90
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex)
		{
			if (action != NotifyCollectionChangedAction.Replace)
			{
				throw new ArgumentException(SR.Format("Constructor supports only the '{0}' action.", NotifyCollectionChangedAction.Replace), "action");
			}
			if (newItems == null)
			{
				throw new ArgumentNullException("newItems");
			}
			if (oldItems == null)
			{
				throw new ArgumentNullException("oldItems");
			}
			this.InitializeMoveOrReplace(action, newItems, oldItems, startingIndex, startingIndex);
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Collections.Specialized.NotifyCollectionChangedEventArgs" />, описывающий изменение <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Move" /> для одного элемента.</summary>
		/// <param name="action">Действие, вызвавшее событие. Возможным значением может быть только <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Move" />.</param>
		/// <param name="changedItem">Элемент, затронутый изменением.</param>
		/// <param name="index">Новый индекс для измененного элемента.</param>
		/// <param name="oldIndex">Старый индекс для измененного элемента.</param>
		/// <exception cref="T:System.ArgumentException">Если параметр <paramref name="action" /> не имеет значения Move или если параметр <paramref name="index" /> меньше 0.</exception>
		// Token: 0x060026F5 RID: 9973 RVA: 0x000878FC File Offset: 0x00085AFC
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index, int oldIndex)
		{
			if (action != NotifyCollectionChangedAction.Move)
			{
				throw new ArgumentException(SR.Format("Constructor supports only the '{0}' action.", NotifyCollectionChangedAction.Move), "action");
			}
			if (index < 0)
			{
				throw new ArgumentException("Index cannot be negative.", "index");
			}
			object[] array = new object[]
			{
				changedItem
			};
			this.InitializeMoveOrReplace(action, array, array, index, oldIndex);
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Collections.Specialized.NotifyCollectionChangedEventArgs" />, описывающий изменение <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Move" /> для нескольких элементов.</summary>
		/// <param name="action">Действие, вызвавшее событие. Возможным значением может быть только <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Move" />.</param>
		/// <param name="changedItems">Элементы, затронутые изменением.</param>
		/// <param name="index">Новый индекс для измененных элементов.</param>
		/// <param name="oldIndex">Старый индекс для измененных элементов.</param>
		/// <exception cref="T:System.ArgumentException">Если параметр <paramref name="action" /> не имеет значения Move или если параметр <paramref name="index" /> меньше 0.</exception>
		// Token: 0x060026F6 RID: 9974 RVA: 0x00087968 File Offset: 0x00085B68
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems, int index, int oldIndex)
		{
			if (action != NotifyCollectionChangedAction.Move)
			{
				throw new ArgumentException(SR.Format("Constructor supports only the '{0}' action.", NotifyCollectionChangedAction.Move), "action");
			}
			if (index < 0)
			{
				throw new ArgumentException("Index cannot be negative.", "index");
			}
			this.InitializeMoveOrReplace(action, changedItems, changedItems, index, oldIndex);
		}

		// Token: 0x060026F7 RID: 9975 RVA: 0x000879C8 File Offset: 0x00085BC8
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int newIndex, int oldIndex)
		{
			this._action = action;
			this._newItems = ((newItems == null) ? null : new ReadOnlyList(newItems));
			this._oldItems = ((oldItems == null) ? null : new ReadOnlyList(oldItems));
			this._newStartingIndex = newIndex;
			this._oldStartingIndex = oldIndex;
		}

		// Token: 0x060026F8 RID: 9976 RVA: 0x00087A24 File Offset: 0x00085C24
		private void InitializeAddOrRemove(NotifyCollectionChangedAction action, IList changedItems, int startingIndex)
		{
			if (action == NotifyCollectionChangedAction.Add)
			{
				this.InitializeAdd(action, changedItems, startingIndex);
				return;
			}
			if (action == NotifyCollectionChangedAction.Remove)
			{
				this.InitializeRemove(action, changedItems, startingIndex);
			}
		}

		// Token: 0x060026F9 RID: 9977 RVA: 0x00087A40 File Offset: 0x00085C40
		private void InitializeAdd(NotifyCollectionChangedAction action, IList newItems, int newStartingIndex)
		{
			this._action = action;
			this._newItems = ((newItems == null) ? null : new ReadOnlyList(newItems));
			this._newStartingIndex = newStartingIndex;
		}

		// Token: 0x060026FA RID: 9978 RVA: 0x00087A62 File Offset: 0x00085C62
		private void InitializeRemove(NotifyCollectionChangedAction action, IList oldItems, int oldStartingIndex)
		{
			this._action = action;
			this._oldItems = ((oldItems == null) ? null : new ReadOnlyList(oldItems));
			this._oldStartingIndex = oldStartingIndex;
		}

		// Token: 0x060026FB RID: 9979 RVA: 0x00087A84 File Offset: 0x00085C84
		private void InitializeMoveOrReplace(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex, int oldStartingIndex)
		{
			this.InitializeAdd(action, newItems, startingIndex);
			this.InitializeRemove(action, oldItems, oldStartingIndex);
		}

		/// <summary>Получает действие, вызвавшее событие.</summary>
		/// <returns>Значение <see cref="T:System.Collections.Specialized.NotifyCollectionChangedAction" />, который описывает действие, вызвавшее событие.</returns>
		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x060026FC RID: 9980 RVA: 0x00087A9A File Offset: 0x00085C9A
		public NotifyCollectionChangedAction Action
		{
			get
			{
				return this._action;
			}
		}

		/// <summary>Получает список новых элементов, связанных с изменением.</summary>
		/// <returns>Список новых элементов, связанных с изменением.</returns>
		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x060026FD RID: 9981 RVA: 0x00087AA2 File Offset: 0x00085CA2
		public IList NewItems
		{
			get
			{
				return this._newItems;
			}
		}

		/// <summary>Получает список элементов, на которые повлияло действие <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Replace" />, Remove или Move.</summary>
		/// <returns>Список элементов, на которые повлияло действие <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Replace" />, Remove или Move.</returns>
		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x060026FE RID: 9982 RVA: 0x00087AAA File Offset: 0x00085CAA
		public IList OldItems
		{
			get
			{
				return this._oldItems;
			}
		}

		/// <summary>Возвращает индекс, в котором произошло изменение.</summary>
		/// <returns>Отсчитываемый от нуля индекс, в котором произошло изменение.</returns>
		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x060026FF RID: 9983 RVA: 0x00087AB2 File Offset: 0x00085CB2
		public int NewStartingIndex
		{
			get
			{
				return this._newStartingIndex;
			}
		}

		/// <summary>Получает индекс, при котором произошло действие <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Move" />, Remove или Replace.</summary>
		/// <returns>Индекс (с нуля), при котором произошло действие <see cref="F:System.Collections.Specialized.NotifyCollectionChangedAction.Move" />, Remove или Replace.</returns>
		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06002700 RID: 9984 RVA: 0x00087ABA File Offset: 0x00085CBA
		public int OldStartingIndex
		{
			get
			{
				return this._oldStartingIndex;
			}
		}

		// Token: 0x0400151B RID: 5403
		private NotifyCollectionChangedAction _action;

		// Token: 0x0400151C RID: 5404
		private IList _newItems;

		// Token: 0x0400151D RID: 5405
		private IList _oldItems;

		// Token: 0x0400151E RID: 5406
		private int _newStartingIndex = -1;

		// Token: 0x0400151F RID: 5407
		private int _oldStartingIndex = -1;
	}
}
