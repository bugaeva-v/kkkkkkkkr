using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x0200013D RID: 317
	public interface IBindingList<T> : IList<T>, ICollection<!0>, IEnumerable<!0>, IEnumerable, IBindingListSource, ICancelAddNew, IRaiseItemChangedEvents
	{
		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060008AC RID: 2220
		bool AllowNew { get; }

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060008AD RID: 2221
		bool AllowEdit { get; }

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060008AE RID: 2222
		bool AllowRemove { get; }

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060008AF RID: 2223
		bool SupportsChangeNotification { get; }

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060008B0 RID: 2224
		bool SupportsSearching { get; }

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060008B1 RID: 2225
		bool SupportsSorting { get; }

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060008B2 RID: 2226
		bool IsSorted { get; }

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060008B3 RID: 2227
		PropertyDescriptor SortProperty { get; }

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060008B4 RID: 2228
		ListSortDirection SortDirection { get; }

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060008B5 RID: 2229
		// (remove) Token: 0x060008B6 RID: 2230
		event ListChangedEventHandler ListChanged;

		// Token: 0x060008B7 RID: 2231
		T AddNew();

		// Token: 0x060008B8 RID: 2232
		int Find(PropertyDescriptor property, object key);

		// Token: 0x060008B9 RID: 2233
		void AddIndex(PropertyDescriptor property);

		// Token: 0x060008BA RID: 2234
		void RemoveIndex(PropertyDescriptor property);

		// Token: 0x060008BB RID: 2235
		void ApplySort(PropertyDescriptor property, ListSortDirection direction);

		// Token: 0x060008BC RID: 2236
		void RemoveSort();
	}
}
