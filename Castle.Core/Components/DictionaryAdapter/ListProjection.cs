using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x0200014A RID: 330
	[DebuggerDisplay("Count = {Count}, Adapter = {Adapter}")]
	[DebuggerTypeProxy(typeof(ListProjectionDebugView<>))]
	public class ListProjection<T> : IBindingList<T>, IList<T>, ICollection<!0>, IEnumerable<T>, IEnumerable, IBindingListSource, ICancelAddNew, IRaiseItemChangedEvents, IBindingList, IList, ICollection, IEditableObject, IRevertibleChangeTracking, IChangeTracking, ICollectionProjection, ICollectionAdapterObserver<T>
	{
		// Token: 0x060008E6 RID: 2278 RVA: 0x00016DD0 File Offset: 0x00014FD0
		public ListProjection(ICollectionAdapter<T> adapter)
		{
			if (adapter == null)
			{
				throw new ArgumentNullException("adapter");
			}
			this.adapter = adapter;
			adapter.Initialize(this);
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x00016E09 File Offset: 0x00015009
		public int Count
		{
			get
			{
				return this.adapter.Count;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x00016E16 File Offset: 0x00015016
		public IBindingList AsBindingList
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x00016E19 File Offset: 0x00015019
		public ICollectionAdapter<T> Adapter
		{
			get
			{
				return this.adapter;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x00016E21 File Offset: 0x00015021
		public IEqualityComparer<T> Comparer
		{
			get
			{
				return this.adapter.Comparer ?? EqualityComparer<T>.Default;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x00016E37 File Offset: 0x00015037
		bool IBindingList<!0>.AllowEdit
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x00016E3A File Offset: 0x0001503A
		bool IBindingList<!0>.AllowNew
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x00016E3D File Offset: 0x0001503D
		bool IBindingList<!0>.AllowRemove
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x00016E40 File Offset: 0x00015040
		bool IBindingList<!0>.SupportsChangeNotification
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x00016E43 File Offset: 0x00015043
		bool IBindingList<!0>.SupportsSearching
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x00016E46 File Offset: 0x00015046
		bool IBindingList<!0>.SupportsSorting
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x00016E49 File Offset: 0x00015049
		bool IBindingList<!0>.IsSorted
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x00016E4C File Offset: 0x0001504C
		PropertyDescriptor IBindingList<!0>.SortProperty
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x00016E4F File Offset: 0x0001504F
		ListSortDirection IBindingList<!0>.SortDirection
		{
			get
			{
				return ListSortDirection.Ascending;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x00016E52 File Offset: 0x00015052
		bool IBindingList.AllowEdit
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x00016E55 File Offset: 0x00015055
		bool IBindingList.AllowNew
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x00016E58 File Offset: 0x00015058
		bool IBindingList.AllowRemove
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x00016E5B File Offset: 0x0001505B
		bool IBindingList.SupportsChangeNotification
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x00016E5E File Offset: 0x0001505E
		bool IBindingList.SupportsSearching
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x00016E61 File Offset: 0x00015061
		bool IBindingList.SupportsSorting
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x00016E64 File Offset: 0x00015064
		bool IBindingList.IsSorted
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x00016E67 File Offset: 0x00015067
		PropertyDescriptor IBindingList.SortProperty
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x00016E6A File Offset: 0x0001506A
		ListSortDirection IBindingList.SortDirection
		{
			get
			{
				return ListSortDirection.Ascending;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x00016E6D File Offset: 0x0001506D
		bool IRaiseItemChangedEvents.RaisesItemChangedEvents
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x00016E70 File Offset: 0x00015070
		bool IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x00016E73 File Offset: 0x00015073
		bool IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x00016E76 File Offset: 0x00015076
		bool ICollection<!0>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000901 RID: 2305 RVA: 0x00016E79 File Offset: 0x00015079
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x00016E7C File Offset: 0x0001507C
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00016E7F File Offset: 0x0001507F
		public virtual bool Contains(T item)
		{
			return this.IndexOf(item) >= 0;
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00016E8E File Offset: 0x0001508E
		bool IList.Contains(object item)
		{
			return this.Contains((T)((object)item));
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00016E9C File Offset: 0x0001509C
		public int IndexOf(T item)
		{
			int count = this.Count;
			IEqualityComparer<T> comparer = this.Comparer;
			for (int i = 0; i < count; i++)
			{
				if (comparer.Equals(this[i], item))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00016ED6 File Offset: 0x000150D6
		int IList.IndexOf(object item)
		{
			return this.IndexOf((T)((object)item));
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00016EE4 File Offset: 0x000150E4
		public void CopyTo(T[] array, int index)
		{
			int count = this.Count;
			int i = 0;
			int num = index;
			while (i < count)
			{
				array[num] = this[i];
				i++;
				num++;
			}
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00016F18 File Offset: 0x00015118
		void ICollection.CopyTo(Array array, int index)
		{
			this.CopyTo((T[])array, index);
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00016F27 File Offset: 0x00015127
		public IEnumerator<T> GetEnumerator()
		{
			int count = this.Count;
			int num;
			for (int i = 0; i < count; i = num + 1)
			{
				yield return this[i];
				num = i;
			}
			yield break;
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00016F36 File Offset: 0x00015136
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x170001AB RID: 427
		public T this[int index]
		{
			get
			{
				return this.adapter[index];
			}
			set
			{
				this.adapter[index] = value;
			}
		}

		// Token: 0x170001AC RID: 428
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this[index] = (T)((object)value);
			}
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00016F78 File Offset: 0x00015178
		public void Replace(IEnumerable<T> items)
		{
			((ICollectionProjection)this).Replace(items);
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00016F84 File Offset: 0x00015184
		void ICollectionProjection.Replace(IEnumerable items)
		{
			this.SuspendEvents();
			try
			{
				this.Clear();
				foreach (object obj in items)
				{
					T item = (T)((object)obj);
					this.Add(item);
				}
			}
			finally
			{
				this.ResumeEvents();
			}
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00016FFC File Offset: 0x000151FC
		protected virtual bool OnReplacing(T oldValue, T newValue)
		{
			return true;
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00016FFF File Offset: 0x000151FF
		bool ICollectionAdapterObserver<!0>.OnReplacing(T oldValue, T newValue)
		{
			return this.OnReplacing(oldValue, newValue);
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00017009 File Offset: 0x00015209
		protected virtual void OnReplaced(T oldValue, T newValue, int index)
		{
			this.DetachPropertyChanged(oldValue);
			this.AttachPropertyChanged(newValue);
			this.NotifyListChanged(ListChangedType.ItemChanged, index);
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00017021 File Offset: 0x00015221
		void ICollectionAdapterObserver<!0>.OnReplaced(T oldValue, T newValue, int index)
		{
			this.OnReplaced(oldValue, newValue, index);
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0001702C File Offset: 0x0001522C
		public virtual T AddNew()
		{
			T result = this.adapter.AddNew();
			this.addNewIndex = this.addedIndex;
			return result;
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00017045 File Offset: 0x00015245
		object IBindingList.AddNew()
		{
			return this.AddNew();
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00017052 File Offset: 0x00015252
		public bool IsNew(int index)
		{
			return index == this.addNewIndex && index >= 0;
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00017066 File Offset: 0x00015266
		public virtual void EndNew(int index)
		{
			if (this.IsNew(index))
			{
				this.addNewIndex = -1;
			}
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00017078 File Offset: 0x00015278
		public virtual void CancelNew(int index)
		{
			if (this.IsNew(index))
			{
				this.RemoveAt(this.addNewIndex);
				this.addNewIndex = -1;
			}
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00017096 File Offset: 0x00015296
		public virtual bool Add(T item)
		{
			return this.adapter.Add(item);
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x000170A4 File Offset: 0x000152A4
		void ICollection<!0>.Add(T item)
		{
			this.Add(item);
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x000170AE File Offset: 0x000152AE
		int IList.Add(object item)
		{
			this.Add((T)((object)item));
			return this.addedIndex;
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x000170C4 File Offset: 0x000152C4
		public void Insert(int index, T item)
		{
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			int count = this.Count;
			if (index > count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			this.EndNew(this.addNewIndex);
			if (index == count)
			{
				this.adapter.Add(item);
				return;
			}
			this.adapter.Insert(index, item);
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00017122 File Offset: 0x00015322
		void IList.Insert(int index, object item)
		{
			this.Insert(index, (T)((object)item));
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x00017131 File Offset: 0x00015331
		protected virtual bool OnInserting(T value)
		{
			return true;
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00017134 File Offset: 0x00015334
		bool ICollectionAdapterObserver<!0>.OnInserting(T value)
		{
			return this.OnInserting(value);
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0001713D File Offset: 0x0001533D
		protected virtual void OnInserted(T newValue, int index)
		{
			this.addedIndex = index;
			this.AttachPropertyChanged(newValue);
			this.NotifyListChanged(ListChangedType.ItemAdded, index);
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00017155 File Offset: 0x00015355
		void ICollectionAdapterObserver<!0>.OnInserted(T newValue, int index)
		{
			this.OnInserted(newValue, index);
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00017160 File Offset: 0x00015360
		public virtual bool Remove(T item)
		{
			int num = this.IndexOf(item);
			if (num < 0)
			{
				return false;
			}
			this.RemoveAt(num);
			return true;
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00017183 File Offset: 0x00015383
		void IList.Remove(object value)
		{
			this.Remove((T)((object)value));
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00017192 File Offset: 0x00015392
		public virtual void RemoveAt(int index)
		{
			this.EndNew(this.addNewIndex);
			this.adapter.Remove(index);
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x000171AC File Offset: 0x000153AC
		public virtual void Clear()
		{
			this.EndNew(this.addNewIndex);
			this.adapter.Clear();
			this.NotifyListReset();
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x000171CB File Offset: 0x000153CB
		void ICollectionProjection.ClearReferences()
		{
			this.adapter.ClearReferences();
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x000171D8 File Offset: 0x000153D8
		protected virtual void OnRemoving(T oldValue)
		{
			this.DetachPropertyChanged(oldValue);
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x000171E1 File Offset: 0x000153E1
		void ICollectionAdapterObserver<!0>.OnRemoving(T oldValue)
		{
			this.OnRemoving(oldValue);
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x000171EA File Offset: 0x000153EA
		protected virtual void OnRemoved(T oldValue, int index)
		{
			this.NotifyListChanged(ListChangedType.ItemDeleted, index);
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x000171F4 File Offset: 0x000153F4
		void ICollectionAdapterObserver<!0>.OnRemoved(T oldValue, int index)
		{
			this.OnRemoved(oldValue, index);
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x00017200 File Offset: 0x00015400
		public bool IsChanged
		{
			get
			{
				if (!this.adapter.HasSnapshot)
				{
					return false;
				}
				int count = this.Count;
				if (this.adapter.SnapshotCount != count)
				{
					return true;
				}
				IEqualityComparer<T> comparer = this.Comparer;
				for (int i = 0; i < count; i++)
				{
					T currentItem = this.adapter.GetCurrentItem(i);
					T snapshotItem = this.adapter.GetSnapshotItem(i);
					if (!comparer.Equals(currentItem, snapshotItem))
					{
						return true;
					}
					IChangeTracking changeTracking = currentItem as IChangeTracking;
					if (changeTracking != null && changeTracking.IsChanged)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x0001728B File Offset: 0x0001548B
		public void BeginEdit()
		{
			if (!this.adapter.HasSnapshot)
			{
				this.adapter.SaveSnapshot();
			}
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x000172A5 File Offset: 0x000154A5
		public void EndEdit()
		{
			this.adapter.DropSnapshot();
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x000172B2 File Offset: 0x000154B2
		public void CancelEdit()
		{
			if (this.adapter.HasSnapshot)
			{
				this.adapter.LoadSnapshot();
				this.adapter.DropSnapshot();
				this.NotifyListReset();
			}
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x000172DD File Offset: 0x000154DD
		public void AcceptChanges()
		{
			this.BeginEdit();
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x000172E5 File Offset: 0x000154E5
		public void RejectChanges()
		{
			this.CancelEdit();
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x000172F0 File Offset: 0x000154F0
		private void AttachPropertyChanged(T value)
		{
			if (typeof(T).GetTypeInfo().IsValueType)
			{
				return;
			}
			INotifyPropertyChanged notifyPropertyChanged = value as INotifyPropertyChanged;
			if (notifyPropertyChanged == null)
			{
				return;
			}
			if (this.propertyHandler == null)
			{
				this.propertyHandler = new PropertyChangedEventHandler(this.HandlePropertyChanged);
			}
			notifyPropertyChanged.PropertyChanged += this.propertyHandler;
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0001734C File Offset: 0x0001554C
		private void DetachPropertyChanged(T value)
		{
			if (typeof(T).GetTypeInfo().IsValueType)
			{
				return;
			}
			INotifyPropertyChanged notifyPropertyChanged = value as INotifyPropertyChanged;
			if (notifyPropertyChanged == null || this.propertyHandler == null)
			{
				return;
			}
			notifyPropertyChanged.PropertyChanged -= this.propertyHandler;
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00017394 File Offset: 0x00015594
		private void HandlePropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			T item;
			if (this.EventsEnabled && this.CanHandle(sender, e) && this.TryGetChangedItem(sender, out item) && this.TryGetChangedIndex(item))
			{
				PropertyDescriptor changedProperty = ListProjection<T>.GetChangedProperty(e);
				ListChangedEventArgs args = new ListChangedEventArgs(ListChangedType.ItemChanged, this.changedIndex, changedProperty);
				this.OnListChanged(args);
			}
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x000173E6 File Offset: 0x000155E6
		private bool CanHandle(object sender, PropertyChangedEventArgs e)
		{
			if (sender == null || e == null || string.IsNullOrEmpty(e.PropertyName))
			{
				this.NotifyListReset();
				return false;
			}
			return true;
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00017404 File Offset: 0x00015604
		private bool TryGetChangedItem(object sender, out T item)
		{
			bool result;
			try
			{
				item = (T)((object)sender);
				result = true;
			}
			catch (InvalidCastException)
			{
				this.NotifyListReset();
				item = default(T);
				result = false;
			}
			return result;
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00017444 File Offset: 0x00015644
		private bool TryGetChangedIndex(T item)
		{
			if (this.changedIndex >= 0 && this.changedIndex < this.Count && this.Comparer.Equals(this[this.changedIndex], item))
			{
				return true;
			}
			this.changedIndex = this.IndexOf(item);
			if (this.changedIndex >= 0)
			{
				return true;
			}
			this.DetachPropertyChanged(item);
			this.NotifyListReset();
			return false;
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x000174AD File Offset: 0x000156AD
		private static PropertyDescriptor GetChangedProperty(PropertyChangedEventArgs e)
		{
			if (ListProjection<T>.itemProperties == null)
			{
				ListProjection<T>.itemProperties = TypeDescriptor.GetProperties(typeof(T));
			}
			return ListProjection<T>.itemProperties.Find(e.PropertyName, true);
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000939 RID: 2361 RVA: 0x000174DC File Offset: 0x000156DC
		// (remove) Token: 0x0600093A RID: 2362 RVA: 0x00017514 File Offset: 0x00015714
		public event ListChangedEventHandler ListChanged;

		// Token: 0x0600093B RID: 2363 RVA: 0x0001754C File Offset: 0x0001574C
		protected virtual void OnListChanged(ListChangedEventArgs args)
		{
			ListChangedEventHandler listChanged = this.ListChanged;
			if (listChanged != null)
			{
				listChanged(this, args);
			}
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x0001756B File Offset: 0x0001576B
		protected void NotifyListChanged(ListChangedType type, int index)
		{
			if (this.EventsEnabled)
			{
				this.OnListChanged(new ListChangedEventArgs(type, index));
			}
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00017582 File Offset: 0x00015782
		protected void NotifyListReset()
		{
			if (this.EventsEnabled)
			{
				this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x00017599 File Offset: 0x00015799
		public bool EventsEnabled
		{
			get
			{
				return this.suspendLevel == 0;
			}
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x000175A4 File Offset: 0x000157A4
		public void SuspendEvents()
		{
			this.suspendLevel++;
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x000175B4 File Offset: 0x000157B4
		public bool ResumeEvents()
		{
			object obj;
			if (this.suspendLevel != 0)
			{
				int num = this.suspendLevel - 1;
				this.suspendLevel = num;
				obj = (num == 0);
			}
			else
			{
				obj = 1;
			}
			object obj2 = obj;
			if (obj2 != null)
			{
				this.NotifyListReset();
			}
			return obj2 != null;
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x000175E9 File Offset: 0x000157E9
		void IBindingList<!0>.AddIndex(PropertyDescriptor property)
		{
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x000175EB File Offset: 0x000157EB
		void IBindingList.AddIndex(PropertyDescriptor property)
		{
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x000175ED File Offset: 0x000157ED
		void IBindingList<!0>.RemoveIndex(PropertyDescriptor property)
		{
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x000175EF File Offset: 0x000157EF
		void IBindingList.RemoveIndex(PropertyDescriptor property)
		{
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x000175F1 File Offset: 0x000157F1
		int IBindingList<!0>.Find(PropertyDescriptor property, object key)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x000175F8 File Offset: 0x000157F8
		int IBindingList.Find(PropertyDescriptor property, object key)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x000175FF File Offset: 0x000157FF
		void IBindingList<!0>.ApplySort(PropertyDescriptor property, ListSortDirection direction)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00017606 File Offset: 0x00015806
		void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0001760D File Offset: 0x0001580D
		void IBindingList<!0>.RemoveSort()
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00017614 File Offset: 0x00015814
		void IBindingList.RemoveSort()
		{
			throw new NotSupportedException();
		}

		// Token: 0x040001FC RID: 508
		private readonly ICollectionAdapter<T> adapter;

		// Token: 0x040001FD RID: 509
		private int addNewIndex = -1;

		// Token: 0x040001FE RID: 510
		private int addedIndex = -1;

		// Token: 0x040001FF RID: 511
		private int suspendLevel;

		// Token: 0x04000200 RID: 512
		private int changedIndex = -1;

		// Token: 0x04000201 RID: 513
		private PropertyChangedEventHandler propertyHandler;

		// Token: 0x04000202 RID: 514
		private static PropertyDescriptorCollection itemProperties;

		// Token: 0x04000203 RID: 515
		private const int NoIndex = -1;
	}
}
