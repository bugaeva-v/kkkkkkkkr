using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Castle.Components.DictionaryAdapter
{
	// Token: 0x02000136 RID: 310
	public class BindingList<T> : IBindingList<!0>, IList<T>, ICollection<!0>, IEnumerable<!0>, IEnumerable, IBindingListSource, ICancelAddNew, IRaiseItemChangedEvents, IList, ICollection
	{
		// Token: 0x06000856 RID: 2134 RVA: 0x00016735 File Offset: 0x00014935
		public BindingList()
		{
			this.list = new BindingList<T>();
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00016748 File Offset: 0x00014948
		public BindingList(IList<T> list)
		{
			this.list = new BindingList<T>(list);
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x0001675C File Offset: 0x0001495C
		public BindingList(BindingList<T> list)
		{
			if (list == null)
			{
				throw new ArgumentNullException("list");
			}
			this.list = list;
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x00016779 File Offset: 0x00014979
		public BindingList<T> InnerList
		{
			get
			{
				return this.list;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x00016781 File Offset: 0x00014981
		public IBindingList AsBindingList
		{
			get
			{
				return this.list;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x00016789 File Offset: 0x00014989
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x00016796 File Offset: 0x00014996
		bool ICollection<!0>.IsReadOnly
		{
			get
			{
				return ((ICollection<T>)this.list).IsReadOnly;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x000167A3 File Offset: 0x000149A3
		bool IList.IsReadOnly
		{
			get
			{
				return ((IList)this.list).IsReadOnly;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x000167B0 File Offset: 0x000149B0
		bool IList.IsFixedSize
		{
			get
			{
				return ((IList)this.list).IsFixedSize;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x000167BD File Offset: 0x000149BD
		bool ICollection.IsSynchronized
		{
			get
			{
				return ((ICollection)this.list).IsSynchronized;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x000167CA File Offset: 0x000149CA
		object ICollection.SyncRoot
		{
			get
			{
				return ((ICollection)this.list).SyncRoot;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x000167D7 File Offset: 0x000149D7
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x000167E4 File Offset: 0x000149E4
		public bool AllowNew
		{
			get
			{
				return this.list.AllowNew;
			}
			set
			{
				this.list.AllowNew = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x000167F2 File Offset: 0x000149F2
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x000167FF File Offset: 0x000149FF
		public bool AllowEdit
		{
			get
			{
				return this.list.AllowEdit;
			}
			set
			{
				this.list.AllowEdit = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x0001680D File Offset: 0x00014A0D
		// (set) Token: 0x06000866 RID: 2150 RVA: 0x0001681A File Offset: 0x00014A1A
		public bool AllowRemove
		{
			get
			{
				return this.list.AllowRemove;
			}
			set
			{
				this.list.AllowRemove = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x00016828 File Offset: 0x00014A28
		// (set) Token: 0x06000868 RID: 2152 RVA: 0x00016835 File Offset: 0x00014A35
		public bool RaiseListChangedEvents
		{
			get
			{
				return this.list.RaiseListChangedEvents;
			}
			set
			{
				this.list.RaiseListChangedEvents = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x00016843 File Offset: 0x00014A43
		bool IRaiseItemChangedEvents.RaisesItemChangedEvents
		{
			get
			{
				return ((IRaiseItemChangedEvents)this.list).RaisesItemChangedEvents;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x00016850 File Offset: 0x00014A50
		bool IBindingList<!0>.SupportsChangeNotification
		{
			get
			{
				return this.AsBindingList.SupportsChangeNotification;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x0001685D File Offset: 0x00014A5D
		bool IBindingList<!0>.SupportsSearching
		{
			get
			{
				return this.AsBindingList.SupportsSearching;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x0001686A File Offset: 0x00014A6A
		bool IBindingList<!0>.SupportsSorting
		{
			get
			{
				return this.AsBindingList.SupportsSorting;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x00016877 File Offset: 0x00014A77
		bool IBindingList<!0>.IsSorted
		{
			get
			{
				return this.AsBindingList.IsSorted;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x00016884 File Offset: 0x00014A84
		PropertyDescriptor IBindingList<!0>.SortProperty
		{
			get
			{
				return this.AsBindingList.SortProperty;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x00016891 File Offset: 0x00014A91
		ListSortDirection IBindingList<!0>.SortDirection
		{
			get
			{
				return this.AsBindingList.SortDirection;
			}
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0001689E File Offset: 0x00014A9E
		int IBindingList<!0>.Find(PropertyDescriptor property, object key)
		{
			return this.AsBindingList.Find(property, key);
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x000168AD File Offset: 0x00014AAD
		void IBindingList<!0>.AddIndex(PropertyDescriptor property)
		{
			this.AsBindingList.AddIndex(property);
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x000168BB File Offset: 0x00014ABB
		void IBindingList<!0>.RemoveIndex(PropertyDescriptor property)
		{
			this.AsBindingList.RemoveIndex(property);
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x000168C9 File Offset: 0x00014AC9
		void IBindingList<!0>.ApplySort(PropertyDescriptor property, ListSortDirection direction)
		{
			this.AsBindingList.ApplySort(property, direction);
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x000168D8 File Offset: 0x00014AD8
		void IBindingList<!0>.RemoveSort()
		{
			this.AsBindingList.RemoveSort();
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000875 RID: 2165 RVA: 0x000168E5 File Offset: 0x00014AE5
		// (remove) Token: 0x06000876 RID: 2166 RVA: 0x000168F3 File Offset: 0x00014AF3
		public event AddingNewEventHandler AddingNew
		{
			add
			{
				this.list.AddingNew += value;
			}
			remove
			{
				this.list.AddingNew -= value;
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000877 RID: 2167 RVA: 0x00016901 File Offset: 0x00014B01
		// (remove) Token: 0x06000878 RID: 2168 RVA: 0x0001690F File Offset: 0x00014B0F
		public event ListChangedEventHandler ListChanged
		{
			add
			{
				this.list.ListChanged += value;
			}
			remove
			{
				this.list.ListChanged -= value;
			}
		}

		// Token: 0x17000178 RID: 376
		public T this[int index]
		{
			get
			{
				return this.list[index];
			}
			set
			{
				this.list[index] = value;
			}
		}

		// Token: 0x17000179 RID: 377
		object IList.this[int index]
		{
			get
			{
				return ((IList)this.list)[index];
			}
			set
			{
				((IList)this.list)[index] = value;
			}
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00016957 File Offset: 0x00014B57
		public bool Contains(T item)
		{
			return this.list.Contains(item);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00016965 File Offset: 0x00014B65
		bool IList.Contains(object value)
		{
			return ((IList)this.list).Contains(value);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00016973 File Offset: 0x00014B73
		public int IndexOf(T item)
		{
			return this.list.IndexOf(item);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00016981 File Offset: 0x00014B81
		int IList.IndexOf(object value)
		{
			return ((IList)this.list).IndexOf(value);
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x0001698F File Offset: 0x00014B8F
		public void CopyTo(T[] array, int index)
		{
			this.list.CopyTo(array, index);
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x0001699E File Offset: 0x00014B9E
		void ICollection.CopyTo(Array array, int index)
		{
			((ICollection)this.list).CopyTo(array, index);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x000169AD File Offset: 0x00014BAD
		public IEnumerator<T> GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x000169BA File Offset: 0x00014BBA
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x000169C7 File Offset: 0x00014BC7
		public T AddNew()
		{
			return this.list.AddNew();
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x000169D4 File Offset: 0x00014BD4
		public void CancelNew(int index)
		{
			this.list.CancelNew(index);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x000169E2 File Offset: 0x00014BE2
		public void EndNew(int index)
		{
			this.list.EndNew(index);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x000169F0 File Offset: 0x00014BF0
		public void Add(T item)
		{
			this.list.Add(item);
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x000169FE File Offset: 0x00014BFE
		int IList.Add(object item)
		{
			return ((IList)this.list).Add(item);
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00016A0C File Offset: 0x00014C0C
		public void Insert(int index, T item)
		{
			this.list.Insert(index, item);
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00016A1B File Offset: 0x00014C1B
		void IList.Insert(int index, object item)
		{
			((IList)this.list).Insert(index, item);
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00016A2A File Offset: 0x00014C2A
		public void RemoveAt(int index)
		{
			this.list.RemoveAt(index);
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00016A38 File Offset: 0x00014C38
		public bool Remove(T item)
		{
			return this.list.Remove(item);
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00016A46 File Offset: 0x00014C46
		void IList.Remove(object item)
		{
			((IList)this.list).Remove(item);
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00016A54 File Offset: 0x00014C54
		public void Clear()
		{
			this.list.Clear();
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00016A61 File Offset: 0x00014C61
		public void ResetBindings()
		{
			this.list.ResetBindings();
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00016A6E File Offset: 0x00014C6E
		public void ResetItem(int index)
		{
			this.list.ResetItem(index);
		}

		// Token: 0x040001F0 RID: 496
		private readonly BindingList<T> list;
	}
}
