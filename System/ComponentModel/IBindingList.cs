using System;
using System.Collections;

namespace System.ComponentModel
{
	/// <summary>Обеспечивает возможности, необходимые для поддержки как сложных, так и простых скриптов при связывании с источником данных.</summary>
	// Token: 0x020003AF RID: 943
	public interface IBindingList : IList, ICollection, IEnumerable
	{
		/// <summary>Возвращает значение, показывающее, можно ли добавить элементы в список, используя метод <see cref="M:System.ComponentModel.IBindingList.AddNew" />.</summary>
		/// <returns>Значение <see langword="true" />, если можно добавить элементы в список с помощью метода <see cref="M:System.ComponentModel.IBindingList.AddNew" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001EDE RID: 7902
		bool AllowNew { get; }

		/// <summary>Добавляет новый элемент в список.</summary>
		/// <returns>Элемент, который нужно добавить в список.</returns>
		/// <exception cref="T:System.NotSupportedException">Свойство <see cref="P:System.ComponentModel.IBindingList.AllowNew" /> имеет значение <see langword="false" />.</exception>
		// Token: 0x06001EDF RID: 7903
		object AddNew();

		/// <summary>Возвращает значение, показывающее, можно ли обновить элементы в списке.</summary>
		/// <returns>Значение <see langword="true" />, если можно обновить элементы в списке; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001EE0 RID: 7904
		bool AllowEdit { get; }

		/// <summary>Возвращает значение, показывающее, можно ли удалить элементы из списка с помощью метода <see cref="M:System.Collections.IList.Remove(System.Object)" /> или <see cref="M:System.Collections.IList.RemoveAt(System.Int32)" />.</summary>
		/// <returns>Значение <see langword="true" />, если можно удалить элементы из списка; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001EE1 RID: 7905
		bool AllowRemove { get; }

		/// <summary>Возвращает значение, показывающее, происходит ли событие <see cref="E:System.ComponentModel.IBindingList.ListChanged" /> при изменениях в списке или при изменении элемента списка.</summary>
		/// <returns>Значение <see langword="true" />, если при изменениях в списке или при изменении элемента списка вызывается событие <see cref="E:System.ComponentModel.IBindingList.ListChanged" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001EE2 RID: 7906
		bool SupportsChangeNotification { get; }

		/// <summary>Возвращает значение, показывающее, поддерживает ли список поиск с использованием метода <see cref="M:System.ComponentModel.IBindingList.Find(System.ComponentModel.PropertyDescriptor,System.Object)" />.</summary>
		/// <returns>Значение <see langword="true" />, если список поддерживает поиск с использованием метода <see cref="M:System.ComponentModel.IBindingList.Find(System.ComponentModel.PropertyDescriptor,System.Object)" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001EE3 RID: 7907
		bool SupportsSearching { get; }

		/// <summary>Возвращает значение, показывающее, поддерживает ли список сортировку.</summary>
		/// <returns>Значение <see langword="true" />, если список поддерживает сортировку; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001EE4 RID: 7908
		bool SupportsSorting { get; }

		/// <summary>Возвращает значение, показывающее, отсортированы ли элементы списка.</summary>
		/// <returns>Значение <see langword="true" />, если был вызван метод <see cref="M:System.ComponentModel.IBindingList.ApplySort(System.ComponentModel.PropertyDescriptor,System.ComponentModel.ListSortDirection)" />, а метод <see cref="M:System.ComponentModel.IBindingList.RemoveSort" /> не вызывался; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Свойство <see cref="P:System.ComponentModel.IBindingList.SupportsSorting" /> имеет значение <see langword="false" />.</exception>
		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001EE5 RID: 7909
		bool IsSorted { get; }

		/// <summary>Возвращает дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" />, используемый для сортировки.</summary>
		/// <returns>Дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" />, используемый для сортировки.</returns>
		/// <exception cref="T:System.NotSupportedException">Свойство <see cref="P:System.ComponentModel.IBindingList.SupportsSorting" /> имеет значение <see langword="false" />.</exception>
		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001EE6 RID: 7910
		PropertyDescriptor SortProperty { get; }

		/// <summary>Возвращает направление сортировки.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.ComponentModel.ListSortDirection" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Свойство <see cref="P:System.ComponentModel.IBindingList.SupportsSorting" /> имеет значение <see langword="false" />.</exception>
		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001EE7 RID: 7911
		ListSortDirection SortDirection { get; }

		/// <summary>Происходит при изменении в списке или в элементе списка.</summary>
		// Token: 0x1400002A RID: 42
		// (add) Token: 0x06001EE8 RID: 7912
		// (remove) Token: 0x06001EE9 RID: 7913
		event ListChangedEventHandler ListChanged;

		/// <summary>Добавляет дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" /> к индексам, используемым для поиска.</summary>
		/// <param name="property">Дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" />, добавляемый к индексам, используемым для поиска.</param>
		// Token: 0x06001EEA RID: 7914
		void AddIndex(PropertyDescriptor property);

		/// <summary>Сортирует список, используя дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" /> и направление <see cref="T:System.ComponentModel.ListSortDirection" />.</summary>
		/// <param name="property">Дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" /> для сортировки.</param>
		/// <param name="direction">Одно из значений перечисления <see cref="T:System.ComponentModel.ListSortDirection" />.</param>
		/// <exception cref="T:System.NotSupportedException">Свойство <see cref="P:System.ComponentModel.IBindingList.SupportsSorting" /> имеет значение <see langword="false" />.</exception>
		// Token: 0x06001EEB RID: 7915
		void ApplySort(PropertyDescriptor property, ListSortDirection direction);

		/// <summary>Возвращает индекс строки с данным дескриптором <see cref="T:System.ComponentModel.PropertyDescriptor" />.</summary>
		/// <param name="property">Дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" /> для поиска.</param>
		/// <param name="key">Значение параметра <paramref name="property" />, используемое для поиска.</param>
		/// <returns>Индекс строки с данным дескриптором <see cref="T:System.ComponentModel.PropertyDescriptor" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Свойство <see cref="P:System.ComponentModel.IBindingList.SupportsSearching" /> имеет значение <see langword="false" />.</exception>
		// Token: 0x06001EEC RID: 7916
		int Find(PropertyDescriptor property, object key);

		/// <summary>Удаляет дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" /> из индексов, используемых для поиска.</summary>
		/// <param name="property">Дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" />, удаляемый из индексов, используемых для поиска.</param>
		// Token: 0x06001EED RID: 7917
		void RemoveIndex(PropertyDescriptor property);

		/// <summary>Удаляет любую сортировку, выполненную с использованием метода <see cref="M:System.ComponentModel.IBindingList.ApplySort(System.ComponentModel.PropertyDescriptor,System.ComponentModel.ListSortDirection)" />.</summary>
		/// <exception cref="T:System.NotSupportedException">Свойство <see cref="P:System.ComponentModel.IBindingList.SupportsSorting" /> имеет значение <see langword="false" />.</exception>
		// Token: 0x06001EEE RID: 7918
		void RemoveSort();
	}
}
